import { mkdtemp, mkdir, readFile, rm, writeFile } from "node:fs/promises";
import { createHash } from "node:crypto";
import { tmpdir } from "node:os";
import { resolve } from "node:path";
import { spawn } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const projectSource = await readFile(resolve(root, "src/BabylonjsBindings/BabylonjsBindings.fsproj"), "utf8");
const packageVersion = projectSource.match(/<Version>([^<]+)<\/Version>/)?.[1];
if (!packageVersion) throw new Error("BabylonjsBindings package version is missing");
const packageDirectory = resolve(root, "artifacts/release-package");
const run = (command, args, cwd = root) => new Promise((accept, reject) => {
  const env = { ...process.env, PATH: `/home/developer/.dotnet:${process.env.PATH}` };
  if (cwd !== root) env.NUGET_PACKAGES = resolve(cwd, ".nuget/packages");
  delete env.npm_config_allow_scripts; delete env.NPM_CONFIG_ALLOW_SCRIPTS;
  const child = spawn(command, args, { cwd, env }); let output = "";
  child.stdout.on("data", chunk => output += chunk); child.stderr.on("data", chunk => output += chunk);
  child.on("error", reject); child.on("close", code => code === 0 ? accept(output) : reject(new Error(`${command} ${args.join(" ")} exited ${code}\n${output}`)));
});
await mkdir(packageDirectory, { recursive: true });
await run("dotnet", ["build", "src/BabylonjsBindings/BabylonjsBindings.fsproj", "--no-restore", "-c", "Release", "--no-incremental"]);
await run("dotnet", ["pack", "src/BabylonjsBindings/BabylonjsBindings.fsproj", "--no-restore", "--no-build", "-c", "Release", "-o", packageDirectory]);
const packagePath = resolve(packageDirectory, `BabylonjsBindings.${packageVersion}.nupkg`);
const packageEntries = (await run("unzip", ["-Z1", packagePath])).split(/\r?\n/).filter(Boolean);
const nuspec = await run("unzip", ["-p", packagePath, "BabylonjsBindings.nuspec"]);
if (packageEntries.some(entry => entry.startsWith("fable/"))) throw new Error("binding package unexpectedly contains library source payload");
if (!packageEntries.includes("lib/netstandard2.1/BabylonjsBindings.dll")) throw new Error("binding package lacks its compiled assembly");
if (!nuspec.includes("fable-binding") || !nuspec.includes("fable-javascript")) throw new Error("binding package lacks Fable binding/target tags");
if (nuspec.includes("Fable.Package.SDK")) throw new Error("binding package exposes Fable.Package.SDK to consumers");
const consumer = await mkdtemp(resolve(tmpdir(), "babylon-full-consumer-"));
try {
  await mkdir(resolve(consumer, ".config"), { recursive: true });
  await writeFile(resolve(consumer, ".config/dotnet-tools.json"), `${JSON.stringify({ version: 1, isRoot: true, tools: { fable: { version: "5.13.0", commands: ["fable"], rollForward: false } } }, null, 2)}\n`);
  await writeFile(resolve(consumer, "global.json"), `${JSON.stringify({ sdk: { version: "10.0.302", rollForward: "disable" } }, null, 2)}\n`);
  await writeFile(resolve(consumer, "NuGet.Config"), `<?xml version="1.0"?><configuration><packageSources><clear/><add key="local" value="${packageDirectory}"/><add key="nuget" value="https://api.nuget.org/v3/index.json"/></packageSources><packageSourceMapping><clear/><packageSource key="local"><package pattern="BabylonjsBindings"/></packageSource><packageSource key="nuget"><package pattern="*"/></packageSource></packageSourceMapping></configuration>\n`);
  await writeFile(resolve(consumer, "Consumer.fsproj"), `<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>netstandard2.1</TargetFramework></PropertyGroup><ItemGroup><Compile Include="Program.fs"/><PackageReference Include="BabylonjsBindings" Version="${packageVersion}"/></ItemGroup></Project>\n`);
  await writeFile(resolve(consumer, "Program.fs"), `module FullConsumer\nopen BabylonjsBindings.TypeFunctionCore\nlet tuple: Tuple<float,N2,FloatTuple2> = Unchecked.defaultof<_>\nlet gltf1: BabylonjsBindings.GltfNamespaces.GLTF1.IGLTFAccessor = Unchecked.defaultof<_>\nlet gltf2: BabylonjsBindings.GltfNamespaces.GLTF2.IAccessor = Unchecked.defaultof<_>\nlet runtime1 = BabylonjsBindings.GltfNamespaces.GLTF1.runtime\nlet runtime2 = BabylonjsBindings.GltfNamespaces.GLTF2.runtime\nlet _ = runtime1.GLTFLoader\nlet _ = runtime2.GLTFLoader\nprintfn "BabylonjsBindings ${packageVersion} clean consumer passed"\n`);
  await writeFile(resolve(consumer, "package.json"), `${JSON.stringify({ private: true, type: "module", dependencies: { "@babylonjs/core": "9.19.0", "@babylonjs/loaders": "9.19.0", "@fable-org/fable-library-js": "2.5.1" } }, null, 2)}\n`);
  await run("npm", ["install", "--ignore-scripts"], consumer);
  await run("dotnet", ["tool", "restore"], consumer);
  await run("dotnet", ["restore", "Consumer.fsproj"], consumer);
  await run("dotnet", ["fable", "Consumer.fsproj", "--outDir", "dist", "--noCache"], consumer);
  const emitted = await readFile(resolve(consumer, "dist/Program.js"), "utf8");
  if (!emitted.includes("@babylonjs/loaders/glTF/index.js")) throw new Error("packed consumer lacks exact glTF namespace import");
  const node = await run("node", ["dist/Program.js"], consumer);
  if (!node.includes("clean consumer passed")) throw new Error("packed Node consumer did not pass");
  const packageSha256 = createHash("sha256").update(await readFile(packagePath)).digest("hex");
  const receipt = { schemaVersion: 1, result: "pass", package: packagePath, packageVersion, packageSha256, fable: "5.13.0", packageShape: { fablePackageType: "binding", sourcePayload: false, sdkDependency: false }, npm: { core: "9.19.0", loaders: "9.19.0" }, node: "pass", exactGltfImport: true, isolatedNugetCache: true };
  await writeFile(resolve(root, "reports/m6-clean-consumer.json"), `${JSON.stringify(receipt, null, 2)}\n`);
  console.log(JSON.stringify(receipt, null, 2));
} finally {
  await rm(consumer, { recursive: true, force: true });
}
