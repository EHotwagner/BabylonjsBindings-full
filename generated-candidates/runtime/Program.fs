module BabylonjsBindings.CandidateRuntime

open Fable.Core
open Fable.Core.JsInterop
open BabylonjsBindings.FullCandidate
open BabylonjsBindings.Enums
open BabylonjsBindings.StringEnums
open BabylonjsBindings.ObjectTypes
open BabylonjsBindings.SimpleInterfaces

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
let mutable panDelta = 0.0
let cameraHandlers: ArcRotateHandlers =
    createObj [
        "pan" ==> (fun (deltaX: float) (_deltaY: float) -> panDelta <- deltaX)
        "rotate" ==> (fun (_deltaX: float) (_deltaY: float) -> ())
        "zoom" ==> (fun (_delta: float) -> ())
    ] |> unbox
cameraHandlers.``pan``.Invoke(3.0, 2.0)
let mutable stageCalled = false
let stageAction: TypeAliases.SimpleStageAction = unbox (fun () -> stageCalled <- true)
stageAction.Invoke()
let mutable renderingGroup = -1.0
let renderingGroupAction: TypeAliases.RenderingGroupStageAction = unbox (fun (group: float) -> renderingGroup <- group)
renderingGroupAction.Invoke(7.0)
let easing: IEasingFunction = createObj [ "ease" ==> (fun (gradient: float) -> gradient * gradient) ] |> unbox
let eased = easing.``ease``(0.5)
let mutable loadingShown = false
let loadingScreen: ILoadingScreen =
    createObj [
        "displayLoadingUI" ==> (fun () -> loadingShown <- true)
        "hideLoadingUI" ==> (fun () -> loadingShown <- false)
        "loadingUIBackgroundColor" ==> "black"
        "loadingUIText" ==> "loading"
    ] |> unbox
loadingScreen.``displayLoadingUI``.Invoke()

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
if panDelta <> 3.0 then
    failwith "Babylon function-valued object property was not preserved"
if not stageCalled || renderingGroup <> 7.0 then
    failwith "Babylon callback alias invocation was not preserved"
if eased <> 0.25 || not loadingShown then
    failwith "Babylon dependency-free interface invocation was not preserved"

loaderRegistration |> ignore
camera.dispose()
light.dispose()
engine.dispose()
printfn "Babylon full candidate runtime smoke passed"
