import { mkdtemp, mkdir, readFile, rm, stat, writeFile } from "node:fs/promises";
import { createHash } from "node:crypto";
import { tmpdir } from "node:os";
import { extname, resolve } from "node:path";
import { spawn } from "node:child_process";
import { createServer } from "node:http";

const root = resolve(import.meta.dirname, "..");
const projectText = await readFile(resolve(root, "src/BabylonjsBindings/BabylonjsBindings.fsproj"), "utf8");
const sourceVersion = projectText.match(/<Version>([^<]+)<\/Version>/)?.[1];
const packageVersion = process.env.M3_PACKAGE_VERSION ?? "0.1.4";
const packageDirectory = resolve(process.env.M3_PACKAGE_DIRECTORY ?? resolve(root, "artifacts/m3-package"));
if (!sourceVersion || packageVersion !== "0.1.4") throw new Error(`M3 consumer requires candidate package 0.1.4 (source ${sourceVersion ?? "unknown"}, requested ${packageVersion})`);
const run = (command, args, cwd = root) => new Promise((accept, reject) => {
  const environment = { ...process.env, PATH: `/home/developer/.dotnet:${process.env.PATH}` };
  if (cwd !== root) environment.NUGET_PACKAGES = resolve(cwd, ".nuget/packages");
  delete environment.npm_config_allow_scripts;
  delete environment.NPM_CONFIG_ALLOW_SCRIPTS;
  const child = spawn(command, args, { cwd, env: environment }); let output = "";
  child.stdout.on("data", chunk => output += chunk); child.stderr.on("data", chunk => output += chunk);
  child.on("error", reject); child.on("close", code => code === 0 ? accept(output) : reject(new Error(`${command} ${args.join(" ")} exited ${code}\n${output}`)));
});
await mkdir(packageDirectory, { recursive: true });
await run("dotnet", ["build", "src/BabylonjsBindings/BabylonjsBindings.fsproj", "--no-restore", "--configuration", "Release", "--no-incremental", `-p:PackageVersion=${packageVersion}`]);
await run("dotnet", ["pack", "src/BabylonjsBindings/BabylonjsBindings.fsproj", "--no-restore", "--no-build", "--configuration", "Release", "--output", packageDirectory, `-p:PackageVersion=${packageVersion}`]);
const packagePath = resolve(packageDirectory, `BabylonjsBindings.${packageVersion}.nupkg`);
await readFile(packagePath);
const consumer = await mkdtemp(resolve(tmpdir(), "babylon-m3-consumer-"));
try {
  await mkdir(resolve(consumer, ".config"), { recursive: true });
  await writeFile(resolve(consumer, ".config/dotnet-tools.json"), `${JSON.stringify({ version: 1, isRoot: true, tools: { fable: { version: "5.13.0", commands: ["fable"], rollForward: false } } }, null, 2)}\n`);
  await writeFile(resolve(consumer, "global.json"), `${JSON.stringify({ sdk: { version: "10.0.302", rollForward: "disable" } }, null, 2)}\n`);
  await writeFile(resolve(consumer, "NuGet.Config"), `<?xml version="1.0" encoding="utf-8"?><configuration><packageSources><clear/><add key="local" value="${packageDirectory}"/><add key="nuget" value="https://api.nuget.org/v3/index.json"/></packageSources><packageSourceMapping><packageSource key="local"><package pattern="BabylonjsBindings"/></packageSource><packageSource key="nuget"><package pattern="*"/></packageSource></packageSourceMapping></configuration>\n`);
  await writeFile(resolve(consumer, "Consumer.fsproj"), `<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>netstandard2.1</TargetFramework></PropertyGroup><ItemGroup><Compile Include="Program.fs"/><PackageReference Include="BabylonjsBindings" Version="${packageVersion}"/></ItemGroup></Project>\n`);
  await writeFile(resolve(consumer, "Program.fs"), `module M3CleanConsumer
open BabylonjsBindings.HigherOrderRuntimeApis
open BabylonjsBindings.SimpleClasses
let syncBoundary (factory: CoroutineFactory10<int,int,int,int,int,int,int,int,int,int,int>) : SyncCallable10<int,int,int,int,int,int,int,int,int,int,int> = makeSyncFunction.Invoke(factory)
let asyncBoundary (factory: AsyncCoroutineFactory0<int>) scheduler : AsyncCallable0<int> = makeAsyncFunction.Invoke(factory, scheduler)
let accessor<'This,'V> (target: ClassAccessorDecoratorTarget<'This,'V>) context = expandToProperty.Invoke("dirty").Invoke(target, context), addAccessorsForMaterialProperty.Invoke("dirty").Invoke(target, context)
let decorated (method: ThisCallable1<obj,int,int>) (context: ClassMethodDecoratorContext<obj,ThisCallable1<obj,int,int>>) = nativeOverride.filter.Invoke(System.Func<int,bool>(fun x -> x > 0)).Invoke(method, context)
let image (baseCtor: PushMaterialStatic) : ImageProcessingPushMaterialStatic = ImageProcessingMixin.Invoke(baseCtor)
let imageDefines (baseCtor: BackgroundMaterialDefinesBaseStatic) : ImageProcessingDefinesBackgroundMaterialDefinesBaseStatic = ImageProcessingDefinesMixin.Invoke(baseCtor)
let uv (baseCtor: MaterialDefinesStatic) : UVDefinesMaterialDefinesStatic = UVDefinesMixin.Invoke(baseCtor)
printfn "M3 clean consumer passed"
`);
  await writeFile(resolve(consumer, "package.json"), `${JSON.stringify({ private: true, type: "module", dependencies: { "@babylonjs/core": "9.19.0", "@babylonjs/loaders": "9.19.0", "@fable-org/fable-library-js": "2.5.1" } }, null, 2)}\n`);
  await run("npm", ["install", "--ignore-scripts"], consumer);
  await run("dotnet", ["tool", "restore"], consumer);
  await run("dotnet", ["restore", "Consumer.fsproj"], consumer);
  await run("dotnet", ["fable", "Consumer.fsproj", "--outDir", "dist", "--noCache"], consumer);
  const emitted = await readFile(resolve(consumer, "dist/Program.js"), "utf8");
  for (const module of ["@babylonjs/core/Misc/coroutine.js", "@babylonjs/core/Misc/decorators.js", "@babylonjs/core/Materials/imageProcessing.js", "@babylonjs/core/Materials/imageProcessingConfiguration.defines.js", "@babylonjs/core/Materials/uv.defines.js"]) if (!emitted.includes(module)) throw new Error(`clean consumer missing ${module}`);
  const runtime = await run("node", ["dist/Program.js"], consumer);
  if (!runtime.includes("M3 clean consumer passed")) throw new Error("clean consumer did not report pass");
  await writeFile(resolve(consumer, "index.html"), `<!doctype html><meta charset="utf-8"><script type="importmap">{"imports":{"@babylonjs/core/":"/node_modules/@babylonjs/core/","@babylonjs/loaders/":"/node_modules/@babylonjs/loaders/"}}</script><output>running</output><script type="module">Object.defineProperty(navigator,"xr",{configurable:true,value:{isSessionSupported:async()=>true,requestSession:async()=>({end:async()=>{}})}});await import("./dist/Program.js");document.querySelector("output").textContent="M3 packed Chromium consumer passed";</script>`);
  const mime = new Map([[".html", "text/html"], [".js", "text/javascript"]]);
  const server = createServer(async (request, response) => {
    try {
      const pathname = decodeURIComponent(new URL(request.url, "http://127.0.0.1").pathname);
      const file = resolve(consumer, `.${pathname}`);
      if (file !== consumer && !file.startsWith(`${consumer}/`)) throw new Error("path escape");
      if (!(await stat(file)).isFile()) throw new Error("not file");
      response.writeHead(200, { "content-type": mime.get(extname(file)) ?? "application/octet-stream" }); response.end(await readFile(file));
    } catch { response.writeHead(404); response.end("not found"); }
  });
  await new Promise((accept, reject) => { server.once("error", reject); server.listen(0, "127.0.0.1", accept); });
  let browser;
  try {
    const url = `http://127.0.0.1:${server.address().port}/index.html`;
    browser = await run("chromium", ["--headless", "--no-sandbox", "--disable-gpu", "--virtual-time-budget=8000", "--dump-dom", url], consumer);
  } finally { await new Promise(accept => server.close(accept)); }
  if (!browser.includes("<output>M3 packed Chromium consumer passed</output>")) throw new Error(`packed Chromium consumer failed\n${browser}`);
  const chromiumVersion = (await run("chromium", ["--version"], consumer)).trim();
  const packageSha256 = createHash("sha256").update(await readFile(packagePath)).digest("hex");
  const receipt = { schemaVersion: 1, package: packagePath, packageVersion, packageSha256, sourceVersion, fable: "5.13.0", npm: { core: "9.19.0", loaders: "9.19.0" }, node: "pass", chromium: chromiumVersion, isolatedNugetCache: true, result: "pass" };
  await writeFile(resolve(root, "reports/m3-clean-consumer.json"), `${JSON.stringify(receipt, null, 2)}\n`);
  console.log(JSON.stringify(receipt, null, 2));
} finally { await rm(consumer, { recursive: true, force: true }); }
