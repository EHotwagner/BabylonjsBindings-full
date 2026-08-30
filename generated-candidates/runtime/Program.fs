module BabylonjsBindings.CandidateRuntime

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
let hotSpot: HotSpotQuery = createObj [ "pointIndex" ==> (1.0, 2.0, 3.0); "barycentric" ==> (0.2, 0.3, 0.5) ] |> unbox
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
let absentLabel: TypeAliases.Nullable<string> = None
let mutable renderingGroup = -1.0
let renderingGroupAction: TypeAliases.RenderingGroupStageAction = unbox (fun (group: float) -> renderingGroup <- group)
renderingGroupAction.Invoke(7.0)
let easing: IEasingFunction = createObj [ "ease" ==> (fun (gradient: float) -> gradient * gradient) ] |> unbox
let eased = easing.``ease``(0.5)
let inspectableOption: IInspectableOptions = createObj [ "label" ==> "quality"; "value" ==> 2.0 ] |> unbox
let mutable loadingShown = false
let loadingScreen: ILoadingScreen =
    createObj [
        "displayLoadingUI" ==> (fun () -> loadingShown <- true)
        "hideLoadingUI" ==> (fun () -> loadingShown <- false)
        "loadingUIBackgroundColor" ==> "black"
        "loadingUIText" ==> "loading"
    ] |> unbox
loadingScreen.``displayLoadingUI``.Invoke()
let bits = BitArray.Create(8.0)
bits.``set``(3.0, true)
let bitWasSet = bits.``get``(3.0)
let curveMidpoint = BezierCurve.``Interpolate``(0.5, 0.0, 0.0, 1.0, 1.0)
let animationMask = AnimationGroupMask.Create(names = ResizeArray [ "hero" ])
animationMask.``addTargetName``(U2.Case1 "enemy")
let alphaState = AlphaState.Create(true)
alphaState.``setAlphaBlend``(true)
let customRichType = RichType.Create("custom-string", "default")
let lazyFactory: LazyConstructor3Parameter1Callback<string> = System.Func<string>(fun () -> "lazy-value")
let lazyValue: Lazy<string> = Lazy.Create(lazyFactory)
let smartValues: SmartArray<float> = SmartArray.Create(4.0)
smartValues.``push``(2.0)
smartValues.``push``(1.0)
let smartComparer: SmartArrayMethod7Parameter1Callback<float> = System.Func<float, float, float>(fun left right -> left - right)
smartValues.``sort``(smartComparer)
let duplicateEntry = createObj [ "name" ==> "single" ]
let uniqueValues: SmartArrayNoDuplicate<obj> = SmartArrayNoDuplicate.Create(4.0)
let firstUniquePush = uniqueValues.``pushNoDuplicate``(duplicateEntry)
let secondUniquePush = uniqueValues.``pushNoDuplicate``(duplicateEntry)
let mutable animationEventFrame = -1.0
let animationEventAction: AnimationEventConstructor5Parameter2Callback = System.Action<float>(fun frame -> animationEventFrame <- frame)
let animationEvent = AnimationEvent.Create(12.0, animationEventAction, onlyOnce = true)
animationEvent.``action``.Invoke(animationEvent.``frame``)
let factorGradient = FactorGradient.Create(0.5, 2.0)
let simplificationSettings = SimplificationSettings.Create(0.75, 20.0, optimizeMesh = true)
let stencilState = StencilStateComposer.Create(true)
let positionStride = SimpleFunctions.``VertexBufferDeduceStride``.Invoke("position")
let absoluteUrl = SimpleFunctions.``IsAbsoluteOrSpecialUrl``.Invoke("https://example.test/asset.glb")
let shortIndices: TypeAliases.IndicesArray = U4.Case1 (ResizeArray [ 0.0; 1.0; 2.0 ])
let indicesNeed32Bits = SimpleFunctions.``AreIndices32Bits``.Invoke(shortIndices, 3.0)
let epsilon = ``Epsilon``
let phi = ``PHI``
let shaderDescriptor = ``clearQuadVertexShaderWGSL``
let paddedNumber = ``PadNumber``.Invoke(7.0, 3.0)
let startsWithBaby = ``StartsWith``.Invoke("babylon", "baby")
let base64DataUrl = ``TestBase64DataUrl``.Invoke("data:text/plain;base64,QQ==")
let stringRichType = ``RichTypeString``
let lookedUpStringRichType = SimpleFunctions.``getRichTypeByFlowGraphType``.Invoke(flowGraphType = "string")

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
if asString ArcRotateInteraction.``Pan`` <> "pan" || asString WebXRLayerType.``XRWebGLLayer`` <> "XRWebGLLayer" then
    failwith "Babylon resolved string-alias union was not preserved"
if dimensions.``width`` <> 4.0 || dimensions.``height`` <> 2.0 then
    failwith "Babylon primitive object binding was not preserved"
let pointX, pointY, pointZ = hotSpot.``pointIndex``
if pointX <> 1.0 || pointY <> 2.0 || pointZ <> 3.0 then
    failwith "Babylon tuple-valued object binding was not preserved"
if panDelta <> 3.0 then
    failwith "Babylon function-valued object property was not preserved"
if not stageCalled || renderingGroup <> 7.0 then
    failwith "Babylon callback alias invocation was not preserved"
if absentLabel.IsSome then
    failwith "Babylon generic nullable alias was not preserved"
if eased <> 0.25 || not loadingShown then
    failwith "Babylon dependency-free interface invocation was not preserved"
match inspectableOption.``value`` with
| U2.Case1 value when value = 2.0 -> ()
| _ -> failwith "Babylon interface erased-union property was not preserved"
if not bitWasSet || curveMidpoint <= 0.0 || curveMidpoint >= 1.0 then
    failwith "Babylon dependency-free class import was not preserved"
if not (animationMask.``hasTarget``("hero")) || not (animationMask.``hasTarget``("enemy")) then
    failwith "Babylon erased-union class method was not preserved"
if not alphaState.``alphaBlend`` then
    failwith "Babylon WebGL state class was not preserved"
if customRichType.``typeName`` <> "custom-string" || customRichType.``defaultValue`` <> "default" then
    failwith "Babylon generic runtime class was not preserved"
if lazyValue.``value`` <> "lazy-value" || smartValues.``data``[0] <> 1.0 then
    failwith "Babylon nested-callback generic class was not preserved"
if not firstUniquePush || secondUniquePush || uniqueValues.``length`` <> 1.0 then
    failwith "Babylon inherited generic class was not preserved"
if animationEventFrame <> 12.0 || animationEvent.``onlyOnce`` <> Some true then
    failwith "Babylon undefined-union callback class was not preserved"
if factorGradient.``getFactor``() <> 2.0 || simplificationSettings.``optimizeMesh`` <> Some true || not stencilState.``isDirty`` then
    failwith "Babylon undefined-union class state was not preserved"
if positionStride <> 3.0 || not absoluteUrl then
    failwith "Babylon dependency-closed function import was not preserved"
if indicesNeed32Bits then
    failwith "Babylon erased-union alias/function argument was not preserved"
if epsilon <> 0.001 || phi < 1.618 || phi > 1.619 then
    failwith "Babylon dependency-closed variable import was not preserved"
if shaderDescriptor.``name`` <> "clearQuadVertexShader" || shaderDescriptor.``shader``.Length = 0 then
    failwith "Babylon inline object variable shape was not preserved"
if paddedNumber <> "007" || not startsWithBaby then
    failwith "Babylon callable variable import was not preserved"
if not base64DataUrl.``match`` || base64DataUrl.``type`` <> "text/plain" then
    failwith "Babylon callable variable inline result was not preserved"
if stringRichType.``typeName`` <> "string" || lookedUpStringRichType.``typeName`` <> "string" then
    failwith "Babylon generic class dependency closure was not preserved"

loaderRegistration |> ignore
camera.dispose()
light.dispose()
engine.dispose()
printfn "Babylon full candidate runtime smoke passed"
