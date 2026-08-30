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
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.SimpleVariables

[<Emit("$0")>]
let asString (value: 'T) : string = jsNative

[<ImportAll("@babylonjs/loaders/glTF/index.js")>]
let loaderRegistration: obj = jsNative

let engine = \`\`babylonjs/Engines/nullEngine.pure\`\`.NullEngine.Create()
let scene = \`\`babylonjs/scene.pure\`\`.Scene.Create(engine)
let origin = \`\`babylonjs/Maths/math.vector.pure\`\`.Vector3.Create(0.0, 0.0, 0.0)
let mesh = \`\`babylonjs/Meshes/Builders/boxBuilder.pure\`\`.CreateBox("consumer-box", scene = Some scene)
let dimensions: SizeLike = createObj [ "width" ==> 8.0; "height" ==> 4.0 ] |> unbox
let hotSpot: HotSpotQuery = createObj [ "pointIndex" ==> (1.0, 2.0, 3.0); "barycentric" ==> (0.2, 0.3, 0.5) ] |> unbox
let mutable zoomDelta = 0.0
let cameraHandlers: ArcRotateHandlers =
    createObj [
        "pan" ==> (fun (_deltaX: float) (_deltaY: float) -> ())
        "rotate" ==> (fun (_deltaX: float) (_deltaY: float) -> ())
        "zoom" ==> (fun (delta: float) -> zoomDelta <- delta)
    ] |> unbox
cameraHandlers.\`\`zoom\`\`.Invoke(6.0)
let mutable stageCalled = false
let stageAction: BabylonjsBindings.TypeAliases.SimpleStageAction = unbox (fun () -> stageCalled <- true)
stageAction.Invoke()
let absentLabel: BabylonjsBindings.TypeAliases.Nullable<string> = None
let easing: IEasingFunction = createObj [ "ease" ==> (fun (gradient: float) -> gradient * 2.0) ] |> unbox
let eased = easing.\`\`ease\`\`(3.0)
let inspectableOption: IInspectableOptions = createObj [ "label" ==> "quality"; "value" ==> 2.0 ] |> unbox
let computePipelineContext: IComputePipelineContext =
    createObj [ "isAsync" ==> false; "isReady" ==> true; "_name" ==> "compute"; "_getComputeShaderCode" ==> (fun () -> "shader"); "dispose" ==> (fun () -> ()) ] |> unbox
let mipmap: IMipmap = createObj [ "data" ==> JS.Constructors.Uint8Array.Create(4); "width" ==> 2.0; "height" ==> 2.0; "layerIndex" ==> 0.0 ] |> unbox
let decodedData: IDecodedData =
    createObj [ "width" ==> 2.0; "height" ==> 2.0; "transcodedFormat" ==> 1.0; "mipmaps" ==> ResizeArray [ mipmap ]; "layerCount" ==> 1.0; "isInGammaSpace" ==> false; "hasAlpha" ==> true; "transcoderName" ==> "proof" ] |> unbox
let bits = BitArray.Create(16.0)
bits.\`\`set\`\`(9.0, true)
let bitWasSet = bits.\`\`get\`\`(9.0)
let animationMask = AnimationGroupMask.Create(names = ResizeArray [ "hero" ])
animationMask.\`\`addTargetName\`\`(U2.Case1 "enemy")
let alphaState = AlphaState.Create(true)
alphaState.\`\`setAlphaBlend\`\`(true)
let customRichType = RichType.Create("custom-string", "default")
let lazyFactory: LazyConstructor3Parameter1Callback<string> = System.Func<string>(fun () -> "lazy-value")
let lazyValue: Lazy<string> = Lazy.Create(lazyFactory)
let smartValues: SmartArray<float> = SmartArray.Create(4.0)
smartValues.\`\`push\`\`(2.0)
smartValues.\`\`push\`\`(1.0)
let smartComparer: SmartArrayMethod7Parameter1Callback<float> = System.Func<float, float, float>(fun left right -> left - right)
smartValues.\`\`sort\`\`(smartComparer)
let duplicateEntry = createObj [ "name" ==> "single" ]
let uniqueValues: SmartArrayNoDuplicate<obj> = SmartArrayNoDuplicate.Create(4.0)
let firstUniquePush = uniqueValues.\`\`pushNoDuplicate\`\`(duplicateEntry)
let secondUniquePush = uniqueValues.\`\`pushNoDuplicate\`\`(duplicateEntry)
let mutable animationEventFrame = -1.0
let animationEventAction: AnimationEventConstructor5Parameter2Callback = System.Action<float>(fun frame -> animationEventFrame <- frame)
let animationEvent = AnimationEvent.Create(12.0, animationEventAction, onlyOnce = true)
animationEvent.\`\`action\`\`.Invoke(animationEvent.\`\`frame\`\`)
let factorGradient = FactorGradient.Create(0.5, 2.0)
let simplificationSettings = SimplificationSettings.Create(0.75, 20.0, optimizeMesh = true)
let stencilState = StencilStateComposer.Create(true)
let halton = Halton2DSequence.Create(4.0)
halton.\`\`next\`\`()
let easingSamples =
    [ BackEase.Create().\`\`ease\`\`(0.5)
      BezierCurveEase.Create().\`\`ease\`\`(0.5)
      BounceEase.Create().\`\`ease\`\`(0.5)
      CircleEase.Create().\`\`ease\`\`(0.5)
      CubicEase.Create().\`\`ease\`\`(0.5)
      ElasticEase.Create().\`\`ease\`\`(0.5)
      ExponentialEase.Create().\`\`ease\`\`(0.5)
      PowerEase.Create().\`\`ease\`\`(0.5)
      QuadraticEase.Create().\`\`ease\`\`(0.5)
      QuarticEase.Create().\`\`ease\`\`(0.5)
      QuinticEase.Create().\`\`ease\`\`(0.5)
      SineEase.Create().\`\`ease\`\`(0.5) ]
DataStorage.\`\`WriteJson\`\`("babylon-bindings-proof", "stored")
let storedValue = DataStorage.\`\`ReadJson\`\`("babylon-bindings-proof", "missing")
let observableA: Observable<string> = Observable.Create()
let observableB: Observable<string> = Observable.Create()
let mutable observedValues = ResizeArray<string>()
let observableCallback: ObservableMethod13Parameter1Callback<string> =
    System.Action<string, EventState>(fun value _ -> observedValues.Add(value))
let observer = observableA.\`\`add\`\`(callback = observableCallback)
let multiCallback: MultiObserverMethod4Parameter2Callback<string> =
    System.Action<string, EventState>(fun value _ -> observedValues.Add($"multi:{value}"))
let multiObserver = MultiObserver.\`\`Watch\`\`(ResizeArray [ observableA; observableB ], multiCallback)
observableA.\`\`notifyObservers\`\`("first") |> ignore
observableB.\`\`notifyObservers\`\`("second") |> ignore
let thinSprite = ThinSprite.Create()
let mutable thinAnimationEnded = false
let thinAnimationEnd: ThinSpriteMethod29Parameter5Callback = System.Action(fun () -> thinAnimationEnded <- true)
thinSprite.\`\`playAnimation\`\`(0.0, 1.0, false, 1.0, Some thinAnimationEnd)
thinSprite.\`\`_animate\`\`(2.0)
thinSprite.\`\`_animate\`\`(2.0)
let positionStride = BabylonjsBindings.SimpleFunctions.\`\`VertexBufferDeduceStride\`\`.Invoke("position")
let shortIndices: BabylonjsBindings.TypeAliases.IndicesArray = U4.Case1 (ResizeArray [ 0.0; 1.0; 2.0 ])
let indicesNeed32Bits = BabylonjsBindings.SimpleFunctions.\`\`AreIndices32Bits\`\`.Invoke(shortIndices, 3.0)
let epsilon = \`\`Epsilon\`\`
let shaderDescriptor = \`\`clearQuadVertexShaderWGSL\`\`
let paddedNumber = \`\`PadNumber\`\`.Invoke(7.0, 3.0)
let base64DataUrl = \`\`TestBase64DataUrl\`\`.Invoke("data:text/plain;base64,QQ==")
let stringRichType = \`\`RichTypeString\`\`
if isNull (mesh :> obj) || scene.meshes.Count <> 1 then failwith "clean consumer scene failed"
if uint32 NodeRenderGraphBlockConnectionPointTypes.\`\`All\`\` <> 4294967295u then failwith "clean consumer enum failed"
if int AudioAnalyzerFFTSizeType.\`\`N32768\`\` <> 32768 then failwith "clean consumer numeric literal union failed"
if asString PowerPreference.\`\`HighPerformance\`\` <> "high-performance" then failwith "clean consumer string enum failed"
if asString ArcRotateInteraction.\`\`Pan\`\` <> "pan" || asString WebXRLayerType.\`\`XRWebGLLayer\`\` <> "XRWebGLLayer" then failwith "clean consumer resolved string union failed"
if dimensions.\`\`width\`\` <> 8.0 || dimensions.\`\`height\`\` <> 4.0 then failwith "clean consumer object type failed"
let pointX, pointY, pointZ = hotSpot.\`\`pointIndex\`\`
if pointX <> 1.0 || pointY <> 2.0 || pointZ <> 3.0 then failwith "clean consumer tuple object failed"
if zoomDelta <> 6.0 then failwith "clean consumer object callback failed"
if not stageCalled then failwith "clean consumer callback alias failed"
if absentLabel.IsSome then failwith "clean consumer nullable alias failed"
if eased <> 6.0 then failwith "clean consumer interface method failed"
match inspectableOption.\`\`value\`\` with
| U2.Case1 value when value = 2.0 -> ()
| _ -> failwith "clean consumer interface erased union failed"
if computePipelineContext.\`\`_name\`\` <> Some "compute" || computePipelineContext.\`\`_getComputeShaderCode\`\`() <> Some "shader" then failwith "clean consumer undefined-union interface failed"
if decodedData.\`\`mipmaps\`\`[0].\`\`data\`\`.Value.length <> 4 || decodedData.\`\`errors\`\`.IsSome then failwith "clean consumer optional interface closure failed"
if not bitWasSet then failwith "clean consumer class import failed"
if not (animationMask.\`\`hasTarget\`\`("hero")) || not (animationMask.\`\`hasTarget\`\`("enemy")) then failwith "clean consumer union class method failed"
if not alphaState.\`\`alphaBlend\`\` then failwith "clean consumer WebGL state class failed"
if customRichType.\`\`typeName\`\` <> "custom-string" || customRichType.\`\`defaultValue\`\` <> "default" then failwith "clean consumer generic class failed"
if lazyValue.\`\`value\`\` <> "lazy-value" || smartValues.\`\`data\`\`[0] <> 1.0 then failwith "clean consumer nested callback class failed"
if not firstUniquePush || secondUniquePush || uniqueValues.\`\`length\`\` <> 1.0 then failwith "clean consumer inherited generic class failed"
if animationEventFrame <> 12.0 || animationEvent.\`\`onlyOnce\`\` <> Some true then failwith "clean consumer undefined-union callback class failed"
if factorGradient.\`\`getFactor\`\`() <> 2.0 || simplificationSettings.\`\`optimizeMesh\`\` <> Some true || not stencilState.\`\`isDirty\`\` then failwith "clean consumer undefined-union class state failed"
if Constants.\`\`AUTOSAMPLERSUFFIX\`\` <> "Sampler" || Constants.\`\`ALPHA_ADD\`\` <> 1.0 || SceneComponentConstants.\`\`NAME_LAYER\`\` <> "Layer" then failwith "clean consumer inferred constants failed"
if ClipboardEventTypes.\`\`COPY\`\` <> 1.0 || KeyboardEventTypes.\`\`KEYDOWN\`\` <> 1.0 || PointerEventTypes.\`\`POINTERDOUBLETAP\`\` <> 64.0 then failwith "clean consumer event constants failed"
if LightConstants.\`\`FALLOFF_PHYSICAL\`\` <> 1.0 || Logger.\`\`AllLogLevel\`\` <> 7.0 || StencilState.\`\`KEEP\`\` <> 7680.0 then failwith "clean consumer subsystem constants failed"
if (halton.\`\`x\`\` = 0.0 && halton.\`\`y\`\` = 0.0) || easingSamples.Length <> 12 || (easingSamples |> List.exists System.Double.IsNaN) then failwith "clean consumer inferred class closure failed"
if storedValue <> "stored" then failwith "clean consumer generic static class method failed"
if observer.IsNone || not (observableA.\`\`hasObservers\`\`()) || observedValues.Count <> 3 || observedValues[0] <> "first" || observedValues[1] <> "multi:first" || observedValues[2] <> "multi:second" then failwith "clean consumer observable closure failed"
if not thinAnimationEnded || thinSprite.\`\`animationStarted\`\` then failwith "clean consumer nullable callback class failed"
multiObserver.\`\`dispose\`\`()
let externalDefineValue: MaterialDefinesConstructor19Parameter1ObjectValue1Object =
    createObj [ "type" ==> "boolean"; "default" ==> false ] |> unbox
let externalDefines: MaterialDefinesConstructor19Parameter1Object =
    createObj [ "CUSTOM" ==> externalDefineValue ] |> unbox
let materialDefines = MaterialDefines.Create(externalDefines)
materialDefines.["CUSTOM"] <- box true
materialDefines.["INSTANCESCOLOR"] <- box true
let instanceAttributes = ResizeArray<string>()
BabylonjsBindings.SimpleFunctions.\`\`PrepareAttributesForInstances\`\`.Invoke(instanceAttributes, materialDefines)
materialDefines.\`\`markAsProcessed\`\`()
let derivedMaterialDefines: ResizeArray<MaterialDefines> =
    ResizeArray [
        DecalMapDefines.Create() :> MaterialDefines
        ImageProcessingConfigurationDefines.Create() :> MaterialDefines
        MaterialAnisotropicDefines.Create() :> MaterialDefines
        MaterialBRDFDefines.Create() :> MaterialDefines
        MaterialClearCoatDefines.Create() :> MaterialDefines
        MaterialDetailMapDefines.Create() :> MaterialDefines
        MaterialGreasedLineDefines.Create() :> MaterialDefines
        MaterialIridescenceDefines.Create() :> MaterialDefines
        MaterialSheenDefines.Create() :> MaterialDefines
        MaterialSubSurfaceDefines.Create() :> MaterialDefines
    ]
if unbox<bool> materialDefines.["CUSTOM"] <> true || materialDefines.\`\`isDirty\`\` || derivedMaterialDefines.Count <> 10 || not (instanceAttributes.Contains("instanceColor")) then failwith "clean consumer material defines closure failed"
if positionStride <> 3.0 then failwith "clean consumer function import failed"
if indicesNeed32Bits then failwith "clean consumer union alias/function failed"
if epsilon <> 0.001 then failwith "clean consumer variable import failed"
if shaderDescriptor.\`\`name\`\` <> "clearQuadVertexShader" || shaderDescriptor.\`\`shader\`\`.Length = 0 then failwith "clean consumer variable shape failed"
if paddedNumber <> "007" then failwith "clean consumer callable variable failed"
if not base64DataUrl.\`\`match\`\` || base64DataUrl.\`\`type\`\` <> "text/plain" then failwith "clean consumer callable variable result failed"
if stringRichType.\`\`typeName\`\` <> "string" then failwith "clean consumer generic class variable failed"
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
