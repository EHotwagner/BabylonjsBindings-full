module BabylonjsBindings.CandidateRuntime

open Fable.Core
open Fable.Core.JsInterop
open BabylonjsBindings.FullCandidate
open BabylonjsBindings.Enums
open BabylonjsBindings.StringEnums
open BabylonjsBindings.ObjectTypes

[<Emit("$0")>]
let private asString (value: 'T) : string = jsNative

[<ImportAll("@babylonjs/loaders/glTF/index.js")>]
let loaderRegistration: obj = jsNative

let engine = ``babylonjs/Engines/nullEngine.pure``.NullEngine.Create()
let scene = ``babylonjs/scene.pure``.Scene.Create(engine)
let origin = ``babylonjs/Maths/math.vector.pure``.Vector3.Create(0.0, 0.0, 0.0)
let up = ``babylonjs/Maths/math.vector.pure``.Vector3.Create(0.0, 1.0, 0.0)
let camera = ``babylonjs/Cameras/freeCamera.pure``.FreeCamera.Create("camera", origin, scene)
let light = ``babylonjs/Lights/hemisphericLight.pure``.HemisphericLight.Create("light", up, scene)
let mesh = ``babylonjs/Meshes/Builders/boxBuilder.pure``.CreateBox("box", scene = Some scene)
let dimensions: SizeLike = createObj [ "width" ==> 4.0; "height" ==> 2.0 ] |> unbox

if isNull (mesh :> obj) || scene.meshes.Count <> 1 then
    failwith "full candidate did not construct a Babylon scene"
if uint32 NodeRenderGraphBlockConnectionPointTypes.``All`` <> 4294967295u then
    failwith "unsigned Babylon enum value was not preserved"
if int EShaderType.``FRAGMENT`` <> 35632 then
    failwith "loader enum value was not preserved"
if int AudioAnalyzerFFTSizeType.``N32768`` <> 32768 then
    failwith "numeric literal-union value was not preserved"
if asString PowerPreference.``HighPerformance`` <> "high-performance" then
    failwith "Babylon string enum value was not preserved"
if dimensions.``width`` <> 4.0 || dimensions.``height`` <> 2.0 then
    failwith "Babylon primitive object binding was not preserved"

loaderRegistration |> ignore
camera.dispose()
light.dispose()
engine.dispose()
printfn "Babylon full candidate runtime smoke passed"
