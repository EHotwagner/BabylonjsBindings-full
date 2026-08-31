import { mkdtemp, mkdir, readFile, rm, writeFile } from "node:fs/promises";
import { tmpdir } from "node:os";
import { resolve } from "node:path";
import { spawn } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const projectText = await readFile(resolve(root, "src/BabylonjsBindings/BabylonjsBindings.fsproj"), "utf8");
const packageVersion = process.env.M2_PACKAGE_VERSION ?? projectText.match(/<Version>([^<]+)<\/Version>/)?.[1];
const packageDirectory = resolve(process.env.M2_PACKAGE_DIRECTORY ?? resolve(root, "artifacts/m2-package"));
if (!packageVersion) throw new Error("could not determine package version");
const run = (command, args, cwd = root) => new Promise((accept, reject) => {
  const environment = { ...process.env, PATH: `/home/developer/.dotnet:${process.env.PATH}` };
  delete environment.npm_config_allow_scripts;
  delete environment.NPM_CONFIG_ALLOW_SCRIPTS;
  const child = spawn(command, args, { cwd, env: environment }); let output = "";
  child.stdout.on("data", chunk => output += chunk); child.stderr.on("data", chunk => output += chunk);
  child.on("error", reject); child.on("close", code => code === 0 ? accept(output) : reject(new Error(`${command} ${args.join(" ")} exited ${code}\n${output}`)));
});
await mkdir(packageDirectory, { recursive: true });
await run("dotnet", ["build", "src/BabylonjsBindings/BabylonjsBindings.fsproj", "--no-restore", "--configuration", "Release", `-p:PackageVersion=${packageVersion}`]);
await run("dotnet", ["pack", "src/BabylonjsBindings/BabylonjsBindings.fsproj", "--no-restore", "--no-build", "--configuration", "Release", "--output", packageDirectory, `-p:PackageVersion=${packageVersion}`]);
const packagePath = resolve(packageDirectory, `BabylonjsBindings.${packageVersion}.nupkg`);
await readFile(packagePath);
const consumer = await mkdtemp(resolve(tmpdir(), "babylon-m2-consumer-"));
try {
  await mkdir(resolve(consumer, ".config"), { recursive: true });
  await writeFile(resolve(consumer, ".config/dotnet-tools.json"), `${JSON.stringify({ version: 1, isRoot: true, tools: { fable: { version: "5.13.0", commands: ["fable"], rollForward: false } } }, null, 2)}\n`);
  await writeFile(resolve(consumer, "global.json"), `${JSON.stringify({ sdk: { version: "10.0.302", rollForward: "disable" } }, null, 2)}\n`);
  await writeFile(resolve(consumer, "NuGet.Config"), `<?xml version="1.0" encoding="utf-8"?><configuration><packageSources><clear/><add key="local" value="${packageDirectory}"/><add key="nuget" value="https://api.nuget.org/v3/index.json"/></packageSources><packageSourceMapping><packageSource key="local"><package pattern="BabylonjsBindings"/></packageSource><packageSource key="nuget"><package pattern="*"/></packageSource></packageSourceMapping></configuration>\n`);
  await writeFile(resolve(consumer, "Consumer.fsproj"), `<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>netstandard2.1</TargetFramework></PropertyGroup><ItemGroup><Compile Include="Program.fs"/><PackageReference Include="BabylonjsBindings" Version="${packageVersion}"/></ItemGroup></Project>\n`);
  await writeFile(resolve(consumer, "Program.fs"), `module M2CleanConsumer
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.FiniteDependentMaps
let assets: IAssetContainer = unbox {| animations = [| {| uniqueId = 1; kind = "animation" |} |]; animationGroups = [||]; meshes = [||]; materials = [||]; cameras = [||]; lights = [||] |}
let animation: Animation option = GetFlowGraphAssetWithType.Invoke(assets, FlowGraphAnimationAsset.Value, 0.0)
let manager: WebXRFeaturesManagerStatic = WebXRFeaturesManager
let helper: WebXRExperienceHelperStatic = WebXRExperienceHelper
let hand: HandConstraintBehaviorStatic = HandConstraintBehavior
if animation.IsNone || (manager.GetAvailableFeatures() |> Seq.length) < 0 then failwith "M2 consumer runtime failed"
helper |> ignore; hand |> ignore
printfn "M2 clean consumer passed"
`);
  await writeFile(resolve(consumer, "package.json"), `${JSON.stringify({ private: true, type: "module", dependencies: { "@babylonjs/core": "9.19.0", "@babylonjs/loaders": "9.19.0", "@fable-org/fable-library-js": "2.5.1" } }, null, 2)}\n`);
  await run("npm", ["install", "--ignore-scripts"], consumer);
  await run("dotnet", ["tool", "restore"], consumer);
  await run("dotnet", ["restore", "Consumer.fsproj"], consumer);
  await run("dotnet", ["fable", "Consumer.fsproj", "--outDir", "dist", "--noCache"], consumer);
  const emitted = await readFile(resolve(consumer, "dist/Program.js"), "utf8");
  for (const module of ["@babylonjs/core/FlowGraph/flowGraphAssetsContext.js", "@babylonjs/core/XR/webXRFeaturesManager.js", "@babylonjs/core/XR/webXRExperienceHelper.js", "@babylonjs/core/Behaviors/Meshes/handConstraintBehavior.js"]) if (!emitted.includes(module)) throw new Error(`clean consumer missing ${module}`);
  const runtime = await run("node", ["dist/Program.js"], consumer);
  if (!runtime.includes("M2 clean consumer passed")) throw new Error("clean consumer did not report pass");
  console.log(JSON.stringify({ package: packagePath, packageVersion, fable: "5.13.0", npm: { core: "9.19.0", loaders: "9.19.0" }, result: "pass" }, null, 2));
} finally { await rm(consumer, { recursive: true, force: true }); }
