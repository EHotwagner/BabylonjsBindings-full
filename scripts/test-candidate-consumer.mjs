import { createHash } from "node:crypto";
import { mkdtemp, mkdir, readFile, rm, writeFile } from "node:fs/promises";
import { tmpdir } from "node:os";
import { resolve } from "node:path";
import { spawn } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const packageVersion = "0.0.0-candidate.1";
const packageName = `BabylonjsBindings.Candidate.${packageVersion}.nupkg`;
const packageDirectory = resolve(root, "artifacts/candidate-package");
const packagePath = resolve(packageDirectory, packageName);
const evidencePath = resolve(root, "generated-candidates/package/clean-consumer-evidence.json");
const sha256 = value => createHash("sha256").update(value).digest("hex");
const run = (command, args, options = {}) => new Promise((accept, reject) => {
  const environment = { ...process.env, ...options.env };
  // npm exports its active user policy into npm-run children. A clean
  // consumer must use only the fixture's own package/.npmrc policy.
  delete environment.npm_config_allow_scripts;
  delete environment.NPM_CONFIG_ALLOW_SCRIPTS;
  const child = spawn(command, args, { cwd: options.cwd ?? root, env: environment });
  let stdout = "";
  let stderr = "";
  child.stdout.on("data", chunk => { stdout += chunk; });
  child.stderr.on("data", chunk => { stderr += chunk; });
  child.on("error", reject);
  child.on("close", code => code === 0
    ? accept({ stdout, stderr })
    : reject(new Error(`${command} ${args.join(" ")} exited ${code}\n${stdout}\n${stderr}`)));
});

await run("dotnet", ["restore", "generated-candidates/package/BabylonjsBindings.Candidate.fsproj", "--locked-mode"]);
await run("dotnet", ["pack", "generated-candidates/package/BabylonjsBindings.Candidate.fsproj", "--no-restore", "--output", packageDirectory]);
const packageBytes = await readFile(packagePath);
const consumer = await mkdtemp(resolve(tmpdir(), "babylon-bindings-consumer-"));
try {
  await mkdir(resolve(consumer, "dist"), { recursive: true });
  await writeFile(resolve(consumer, "NuGet.Config"), `<?xml version="1.0" encoding="utf-8"?>
<configuration><packageSources><clear/><add key="candidate" value="${packageDirectory}"/><add key="nuget" value="https://api.nuget.org/v3/index.json"/></packageSources></configuration>\n`);
  await writeFile(resolve(consumer, "Consumer.fsproj"), `<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup><TargetFramework>netstandard2.1</TargetFramework><RestorePackagesWithLockFile>true</RestorePackagesWithLockFile></PropertyGroup>
  <ItemGroup><Compile Include="Program.fs"/><PackageReference Include="BabylonjsBindings.Candidate" Version="${packageVersion}"/></ItemGroup>
</Project>\n`);
  await writeFile(resolve(consumer, "Program.fs"), `module CleanConsumer

open Fable.Core
open Fable.Core.JsInterop
open BabylonjsBindings.FullCandidate
open BabylonjsBindings.Enums
open BabylonjsBindings.StringEnums
open BabylonjsBindings.ObjectTypes

[<Emit("$0")>]
let asString (value: 'T) : string = jsNative

[<ImportAll("@babylonjs/loaders/glTF/index.js")>]
let loaderRegistration: obj = jsNative

let engine = \`\`babylonjs/Engines/nullEngine.pure\`\`.NullEngine.Create()
let scene = \`\`babylonjs/scene.pure\`\`.Scene.Create(engine)
let origin = \`\`babylonjs/Maths/math.vector.pure\`\`.Vector3.Create(0.0, 0.0, 0.0)
let mesh = \`\`babylonjs/Meshes/Builders/boxBuilder.pure\`\`.CreateBox("consumer-box", scene = Some scene)
let dimensions: SizeLike = createObj [ "width" ==> 8.0; "height" ==> 4.0 ] |> unbox
if isNull (mesh :> obj) || scene.meshes.Count <> 1 then failwith "clean consumer scene failed"
if uint32 NodeRenderGraphBlockConnectionPointTypes.\`\`All\`\` <> 4294967295u then failwith "clean consumer enum failed"
if int AudioAnalyzerFFTSizeType.\`\`N32768\`\` <> 32768 then failwith "clean consumer numeric literal union failed"
if asString PowerPreference.\`\`HighPerformance\`\` <> "high-performance" then failwith "clean consumer string enum failed"
if dimensions.\`\`width\`\` <> 8.0 || dimensions.\`\`height\`\` <> 4.0 then failwith "clean consumer object type failed"
loaderRegistration |> ignore
engine.dispose()
printfn "Babylon candidate clean consumer passed"
`);
  await writeFile(resolve(consumer, "package.json"), `${JSON.stringify({
    private: true,
    type: "module",
    allowScripts: {},
    dependencies: { "@babylonjs/core": "9.19.0", "@babylonjs/loaders": "9.19.0" }
  }, null, 2)}\n`);
  const npmConfig = resolve(consumer, ".npmrc");
  await writeFile(npmConfig, "ignore-scripts=true\n");

  const packages = resolve(consumer, ".nuget");
  await run("dotnet", ["restore", "Consumer.fsproj", "--configfile", "NuGet.Config", "--packages", packages], { cwd: consumer });
  const npmEnvironment = { NPM_CONFIG_USERCONFIG: npmConfig };
  await run("npm", ["install", "--package-lock-only"], { cwd: consumer, env: npmEnvironment });
  await run("npm", ["ci"], { cwd: consumer, env: npmEnvironment });
  await run("dotnet", ["fable", resolve(consumer, "Consumer.fsproj"), "--outDir", resolve(consumer, "dist"), "--noCache"], {
    cwd: root,
    env: { NUGET_PACKAGES: packages }
  });
  const execution = await run("node", [resolve(consumer, "dist/Program.js")], { cwd: consumer });
  if (!execution.stdout.includes("Babylon candidate clean consumer passed")) throw new Error(`clean consumer did not report success\n${execution.stdout}`);

  const emitted = await readFile(resolve(consumer, "dist/Program.js"), "utf8");
  const imports = [...new Set([...emitted.matchAll(/(?:from\s+|import\s+)["'](@babylonjs\/(?:core|loaders)\/[^"']+)["']/g)].map(match => match[1]))].sort();
  if (!imports.some(value => value.startsWith("@babylonjs/core/")) || !imports.some(value => value.startsWith("@babylonjs/loaders/"))) {
    throw new Error(`clean consumer did not emit both core and loader imports: ${imports.join(", ")}`);
  }
  for (const specifier of imports) {
    if (!specifier.endsWith(".js")) throw new Error(`clean consumer emitted a non-explicit import: ${specifier}`);
    const resolved = resolve(consumer, "node_modules", specifier);
    await readFile(resolved);
  }
  const manifest = JSON.parse(await readFile(resolve(root, ".config/dotnet-tools.json"), "utf8"));
  const evidence = {
    schemaVersion: 1,
    package: { id: "BabylonjsBindings.Candidate", version: packageVersion, sha256: sha256(packageBytes) },
    toolchain: { fable: manifest.tools.fable.version, node: process.version },
    npm: { "@babylonjs/core": "9.19.0", "@babylonjs/loaders": "9.19.0" },
    emittedProgramSha256: sha256(emitted),
    imports,
    projectReference: false,
    status: "pass"
  };
  await writeFile(evidencePath, `${JSON.stringify(evidence, null, 2)}\n`);
  console.log(`clean consumer passed from ${packageName} with ${imports.length} modular imports`);
} finally {
  await rm(consumer, { recursive: true, force: true });
}
