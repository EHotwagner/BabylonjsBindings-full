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

[<Emit("$0[$1]")>]
let private tupleItem (value: 'T) (index: int) : float = jsNative

[<AllowNullLiteral>]
type TaggedVector =
    inherit IVector3Like
    abstract ``tag``: string with get, set

[<AllowNullLiteral>]
type TaggedLatLon =
    inherit ILatLonLike
    abstract ``tag``: string with get, set

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
let computePipelineContext: IComputePipelineContext =
    createObj [ "isAsync" ==> false; "isReady" ==> true; "_name" ==> "compute"; "_getComputeShaderCode" ==> (fun () -> "shader"); "dispose" ==> (fun () -> ()) ] |> unbox
let mipmap: IMipmap = createObj [ "data" ==> JS.Constructors.Uint8Array.Create(4); "width" ==> 2.0; "height" ==> 2.0; "layerIndex" ==> 0.0 ] |> unbox
let decodedData: IDecodedData =
    createObj [ "width" ==> 2.0; "height" ==> 2.0; "transcodedFormat" ==> 1.0; "mipmaps" ==> ResizeArray [ mipmap ]; "layerCount" ==> 1.0; "isInGammaSpace" ==> false; "hasAlpha" ==> true; "transcoderName" ==> "proof" ] |> unbox
let vertexDataLike: IVertexDataLike = createObj [ "positions" ==> ResizeArray [ 0.0; 1.0; 2.0 ] ] |> unbox
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
let red = Color3.Create(1.0, 0.0, 0.0)
let blue = Color3.Create(0.0, 0.0, 1.0)
let magenta = red.``add``(unbox<DeepImmutableIColor3Like> blue)
let translucentMagenta = Color4.``FromColor3``(unbox<DeepImmutableIColor3Like> magenta, 0.5)
let completedColors = BabylonjsBindings.SimpleFunctions.``CompleteGreasedLineColorTable``.Invoke(4.0, ResizeArray [ red; blue ], GreasedLineMeshColorDistribution.``COLOR_DISTRIBUTION_REPEAT``, Color3.``Black``())
let richColor3 = SimpleVariables.``RichTypeColor3``
let richColor4 = SimpleVariables.``RichTypeColor4``
let staticColor3 = SimpleVariables.``_StaticOffsetValueColor3``
let staticColor4 = SimpleVariables.``_StaticOffsetValueColor4``
let staticSize = SimpleVariables.``_StaticOffsetValueSize``
let meshoptDecoderUrl = MeshoptCompression.``Configuration``.``decoder``.``url``
let anchorFeatureName = asString WebXRFeatureName.``ANCHOR_SYSTEM``
let animationMask = AnimationGroupMask.Create(names = ResizeArray [ "hero" ])
animationMask.``addTargetName``(U2.Case1 "enemy")
let alphaState = AlphaState.Create(true)
alphaState.``setAlphaBlend``(true)
let customRichType = RichType.Create("custom-string", "default")
let lazyFactory = System.Func<string>(fun () -> "lazy-value")
let lazyValue: Lazy<string> = Lazy.Create(lazyFactory)
let smartValues: SmartArray<float> = SmartArray.Create(4.0)
smartValues.``push``(2.0)
smartValues.``push``(1.0)
let smartComparer = System.Func<float, float, float>(fun left right -> left - right)
smartValues.``sort``(smartComparer)
let duplicateEntry = createObj [ "name" ==> "single" ]
let uniqueValues: SmartArrayNoDuplicate<obj> = SmartArrayNoDuplicate.Create(4.0)
let firstUniquePush = uniqueValues.``pushNoDuplicate``(duplicateEntry)
let secondUniquePush = uniqueValues.``pushNoDuplicate``(duplicateEntry)
let mutable animationEventFrame = -1.0
let animationEventAction = System.Action<float>(fun frame -> animationEventFrame <- frame)
let animationEvent = AnimationEvent.Create(12.0, animationEventAction, onlyOnce = true)
animationEvent.``action``.Invoke(animationEvent.``frame``)
let factorGradient = FactorGradient.Create(0.5, 2.0)
let simplificationSettings = SimplificationSettings.Create(0.75, 20.0, optimizeMesh = true)
let stencilState = StencilStateComposer.Create(true)
let halton = Halton2DSequence.Create(4.0)
halton.``next``()
let easingSamples =
    [ BackEase.Create().``ease``(0.5)
      BezierCurveEase.Create().``ease``(0.5)
      BounceEase.Create().``ease``(0.5)
      CircleEase.Create().``ease``(0.5)
      CubicEase.Create().``ease``(0.5)
      ElasticEase.Create().``ease``(0.5)
      ExponentialEase.Create().``ease``(0.5)
      PowerEase.Create().``ease``(0.5)
      QuadraticEase.Create().``ease``(0.5)
      QuarticEase.Create().``ease``(0.5)
      QuinticEase.Create().``ease``(0.5)
      SineEase.Create().``ease``(0.5) ]
let stencilDefaults = StencilState.Create()
DataStorage.``WriteJson``("babylon-bindings-proof", "stored")
let storedValue = DataStorage.``ReadJson``("babylon-bindings-proof", "missing")
let compressionFormats: BasisTranscodeConfigurationProperty1Object =
    createObj [ "etc1" ==> true; "bc7" ==> false ] |> unbox
let basisConfiguration = BasisTranscodeConfiguration.Create()
basisConfiguration.``supportedCompressionFormats`` <- Some compressionFormats
basisConfiguration.``loadMipmapLevels`` <- Some true
let abortError: BaseError = AbortError.Create("binding aborted") :> BaseError
let innerError = System.Exception("inner failure")
let runtimeError = RuntimeError.Create("runtime failure", ErrorCodesType.``SceneLoaderError``, innerError)
let proofFile: Browser.Types.File = createObj [ "name" ==> "proof.babylon" ] |> unbox
let readFileError = ReadFileError.Create("read failure", proofFile)
let matrixValues = (0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
let matrixLike: IMatrixLike = createObj [ "asArray" ==> (fun () -> matrixValues); "updateFlag" ==> -1.0 ] |> unbox
BabylonjsBindings.SimpleFunctions.``IdentityMatrixToRef``.Invoke(matrixLike)
let identityDiagonal = tupleItem matrixValues 0, tupleItem matrixValues 5, tupleItem matrixValues 10, tupleItem matrixValues 15
BabylonjsBindings.SimpleFunctions.``TranslationMatrixToRef``.Invoke(2.0, 3.0, 4.0, matrixLike)
let translation = tupleItem matrixValues 12, tupleItem matrixValues 13, tupleItem matrixValues 14
BabylonjsBindings.SimpleFunctions.``ScalingMatrixToRef``.Invoke(5.0, 6.0, 7.0, matrixLike)
let scaling = tupleItem matrixValues 0, tupleItem matrixValues 5, tupleItem matrixValues 10
BabylonjsBindings.SimpleFunctions.``MarkAsDirty``.Invoke(matrixLike)
let readonlyMatrix: DeepImmutableIMatrixLike = matrixLike :> DeepImmutableIMatrixLike
let copiedMatrix = ResizeArray(List.replicate 16 0.0)
BabylonjsBindings.SimpleFunctions.``CopyMatrixToArray``.Invoke(readonlyMatrix, U2.Case2 copiedMatrix)
let targetMatrixValues = (0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
let targetMatrix: IMatrixLike = createObj [ "asArray" ==> (fun () -> targetMatrixValues); "updateFlag" ==> -1.0 ] |> unbox
BabylonjsBindings.SimpleFunctions.``CopyMatrixToRef``.Invoke(readonlyMatrix, targetMatrix)
let copiedTargetScale = tupleItem targetMatrixValues 0
let inverseMatrix = ResizeArray(List.replicate 16 0.0)
let invertible = BabylonjsBindings.SimpleFunctions.``InvertMatrixToArray``.Invoke(readonlyMatrix, U2.Case2 inverseMatrix)
let inverseTargetValues = (0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
let inverseTarget: IMatrixLike = createObj [ "asArray" ==> (fun () -> inverseTargetValues); "updateFlag" ==> -1.0 ] |> unbox
let invertibleToRef = BabylonjsBindings.SimpleFunctions.``InvertMatrixToRef``.Invoke(readonlyMatrix, inverseTarget)
let product = ResizeArray(List.replicate 16 0.0)
BabylonjsBindings.SimpleFunctions.``MultiplyMatricesToArray``.Invoke(readonlyMatrix, inverseTarget :> DeepImmutableIMatrixLike, U2.Case2 product)
BabylonjsBindings.SimpleFunctions.``MultiplyMatricesToRef``.Invoke(readonlyMatrix, inverseTarget :> DeepImmutableIMatrixLike, targetMatrix)
let vectorA: IVector3Like = createObj [ "x" ==> 1.0; "y" ==> 2.0; "z" ==> 2.0 ] |> unbox
let vectorB: IVector3Like = createObj [ "x" ==> 4.0; "y" ==> 6.0; "z" ==> 2.0 ] |> unbox
let vector4A: IVector4Like = createObj [ "x" ==> 1.0; "y" ==> 2.0; "z" ==> 3.0; "w" ==> 4.0 ] |> unbox
let vector4B: IVector4Like = createObj [ "x" ==> 2.0; "y" ==> 3.0; "z" ==> 4.0; "w" ==> 5.0 ] |> unbox
let vector2Text = BabylonjsBindings.SimpleFunctions.``Vector2ToFixed``.Invoke(vectorA :> DeepImmutableIVector2Like, 1.0)
let vector3Dot = BabylonjsBindings.SimpleFunctions.``Vector3Dot``.Invoke(vectorA :> DeepImmutableIVector3Like, vectorB :> DeepImmutableIVector3Like)
let vector3Length = BabylonjsBindings.SimpleFunctions.``Vector3Length``.Invoke(vectorA :> DeepImmutableIVector3Like)
let vector3LengthSquared = BabylonjsBindings.SimpleFunctions.``Vector3LengthSquared``.Invoke(vectorA :> DeepImmutableIVector3Like)
let vector3Distance = BabylonjsBindings.SimpleFunctions.``Vector3Distance``.Invoke(vectorA :> DeepImmutableIVector3Like, vectorB :> DeepImmutableIVector3Like)
let vector3DistanceSquared = BabylonjsBindings.SimpleFunctions.``Vector3DistanceSquared``.Invoke(vectorA :> DeepImmutableIVector3Like, vectorB :> DeepImmutableIVector3Like)
let planeDistance = BabylonjsBindings.SimpleFunctions.``Vector3SignedDistanceToPlaneFromPositionAndNormal``.Invoke(vectorA :> DeepImmutableIVector3Like, vectorA :> DeepImmutableIVector3Like, vectorB :> DeepImmutableIVector3Like)
let vector3Text = BabylonjsBindings.SimpleFunctions.``Vector3ToFixed``.Invoke(vectorA :> DeepImmutableIVector3Like, 1.0)
let vector4Dot = BabylonjsBindings.SimpleFunctions.``Vector4Dot``.Invoke(vector4A :> DeepImmutableIVector4Like, vector4B :> DeepImmutableIVector4Like)
let vector4Text = BabylonjsBindings.SimpleFunctions.``Vector4ToFixed``.Invoke(vector4A :> DeepImmutableIVector4Like, 1.0)
let genericVector: TaggedVector = createObj [ "x" ==> 0.0; "y" ==> 0.0; "z" ==> 0.0; "tag" ==> "preserved" ] |> unbox
let fromFloatsResult = BabylonjsBindings.SimpleFunctions.``Vector3FromFloatsToRef``.Invoke(1.0, 2.0, 3.0, genericVector)
let scaleToRefResult = BabylonjsBindings.SimpleFunctions.``Vector3ScaleToRef``.Invoke(vectorA :> DeepImmutableIVector3Like, 2.0, genericVector)
let copyToRefResult = BabylonjsBindings.SimpleFunctions.``Vector3CopyToRef``.Invoke(vectorB :> DeepImmutableIVector3Like, genericVector)
let subtractToRefResult = BabylonjsBindings.SimpleFunctions.``Vector3SubtractToRef``.Invoke(vectorB :> DeepImmutableIVector3Like, vectorA :> DeepImmutableIVector3Like, genericVector)
let lerpToRefResult = BabylonjsBindings.SimpleFunctions.``Vector3LerpToRef``.Invoke(vectorA :> DeepImmutableIVector3Like, vectorB :> DeepImmutableIVector3Like, 0.5, genericVector)
let normalizeToRefResult = BabylonjsBindings.SimpleFunctions.``Vector3NormalizeToRef``.Invoke(vectorA :> DeepImmutableIVector3Like, genericVector)
let scaleInPlaceResult = BabylonjsBindings.SimpleFunctions.``Vector3ScaleInPlace``.Invoke(genericVector, 2.0)
let genericLatLon: TaggedLatLon = createObj [ "lat" ==> 0.0; "lon" ==> 0.0; "tag" ==> "coordinates" ] |> unbox
let degreesResult = BabylonjsBindings.SimpleFunctions.``LatLonFromDegreesToRef``.Invoke(90.0, 180.0, genericLatLon)
let normalResult = BabylonjsBindings.SimpleFunctions.``LatLonToNormalToRef``.Invoke(genericLatLon :> DeepImmutableILatLonLike, genericVector)
let wgs84 = SimpleVariables.``Wgs84Ellipsoid``
let floatingOriginResult = BabylonjsBindings.SimpleFunctions.``GetFullOffsetViewProjectionToRef``.Invoke(vectorA, inverseTarget :> DeepImmutableIMatrixLike, inverseTarget :> DeepImmutableIMatrixLike, targetMatrix)
let filesToLoad = FilesInputStore.``FilesToLoad``
let shaderStore = ShaderStore.``GetShadersStore``()
shaderStore.["codexInlineObjectProof"] <- "void main() {}"
let uniformMat4Size = WebGPUShaderProcessor.``UniformSizes``.["mat4"]
let observableA: Observable<string> = Observable.Create()
let observableB: Observable<string> = Observable.Create()
let mutable observedValues = ResizeArray<string>()
let observableCallback =
    System.Action<string, EventState>(fun value _ -> observedValues.Add(value))
// Observable implements IReadonlyObservable with a required-callback overload;
// spell the class's optional argument explicitly so Fable can select it.
let observer = observableA.``add``(?callback = Some observableCallback)
let multiCallback =
    System.Action<string, EventState>(fun value _ -> observedValues.Add($"multi:{value}"))
let multiObserver = MultiObserver.``Watch``(ResizeArray [ observableA; observableB ], multiCallback)
observableA.``notifyObservers``("first") |> ignore
observableB.``notifyObservers``("second") |> ignore
let thinSprite = ThinSprite.Create()
let mutable thinAnimationEnded = false
let thinAnimationEnd = System.Action(fun () -> thinAnimationEnded <- true)
thinSprite.``playAnimation``(0.0, 1.0, false, 1.0, Some thinAnimationEnd)
thinSprite.``_animate``(2.0)
thinSprite.``_animate``(2.0)
let positionStride = SimpleFunctions.``VertexBufferDeduceStride``.Invoke("position")
let absoluteUrl = SimpleFunctions.``IsAbsoluteOrSpecialUrl``.Invoke("https://example.test/asset.glb")
let shortIndices: TypeAliases.IndicesArray = U4.Case1 (ResizeArray [ 0.0; 1.0; 2.0 ])
let indicesNeed32Bits = SimpleFunctions.``AreIndices32Bits``.Invoke(shortIndices, 3.0)
let fresnel = FresnelParameters.Create()
fresnel.``bias`` <- 0.25
fresnel.``power`` <- 3.0
let serializedFresnel = fresnel.``serialize``()
let objectTextureSize: TypeAliases.TextureSize =
    createObj [ "width" ==> 16.0; "height" ==> 8.0 ] |> unbox
let textureObjectRecognized = SimpleFunctions.``textureSizeIsObject``.Invoke(objectTextureSize)
let glbMimeType = SimpleVariables.``GetMimeType``.Invoke("model.glb")
let epsilon = ``Epsilon``
let phi = ``PHI``
let shaderDescriptor = ``clearQuadVertexShaderWGSL``
let paddedNumber = ``PadNumber``.Invoke(7.0, 3.0)
let startsWithBaby = ``StartsWith``.Invoke("babylon", "baby")
let base64DataUrl = ``TestBase64DataUrl``.Invoke("data:text/plain;base64,QQ==")
let stringRichType = ``RichTypeString``
let lookedUpStringRichType = SimpleFunctions.``getRichTypeByFlowGraphType``.Invoke(flowGraphType = "string")
let generatedGuid = ``GUID``.``RandomId``.Invoke()
let bvhLoaderMetadata = ``BVHFileLoaderMetadata``
let gltfMagicBase64Encoded = ``GLTFMagicBase64Encoded``
let maxHalfFloat = ``MaxHalfFloat``
let int8Size = ``INT8_SIZE``
let nodeHasWindow = ``DomManagement``.``IsWindowObjectExist``.Invoke()

if isNull (mesh :> obj) || scene.meshes.Count <> 1 then
    failwith "full candidate did not construct a Babylon scene"
if fresnel.``bias`` <> 0.25 || fresnel.``power`` <> 3.0 || serializedFresnel.``bias`` <> 0.25 || not textureObjectRecognized || glbMimeType <> Some "model/gltf-binary" then
    failwith "candidate recursive alias and promoted import closure failed"
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
if computePipelineContext.``_name`` <> Some "compute" || computePipelineContext.``_getComputeShaderCode``() <> Some "shader" then
    failwith "Babylon undefined-union interface was not preserved"
if decodedData.``mipmaps``[0].``data``.Value.length <> 4 || decodedData.``errors``.IsSome || vertexDataLike.``normals``.IsSome then
    failwith "Babylon optional interface dependency closure was not preserved"
if not bitWasSet || curveMidpoint <= 0.0 || curveMidpoint >= 1.0 then
    failwith "Babylon dependency-free class import was not preserved"
if magenta.``r`` <> 1.0 || magenta.``g`` <> 0.0 || magenta.``b`` <> 1.0 || translucentMagenta.``a`` <> 0.5 || completedColors.Count <> 4 || not (obj.ReferenceEquals(completedColors[0], red)) || not (obj.ReferenceEquals(completedColors[2], red)) then
    failwith "Babylon constrained color classes and greased-line function were not preserved"
if richColor3.``typeName`` <> "Color3" || richColor4.``typeName`` <> "Color4" || staticColor3.``r`` <> 0.0 || staticColor4.``a`` <> 0.0 || staticSize.``width`` <> 0.0 then
    failwith "Babylon color and readonly offset variables were not preserved"
if not (meshoptDecoderUrl.Contains("meshopt")) || anchorFeatureName <> "xr-anchor-system" then
    failwith "Babylon recursive interface/class imports were not preserved"
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
if Constants.``AUTOSAMPLERSUFFIX`` <> "Sampler" || Constants.``ALPHA_ADD`` <> 1.0 || SceneComponentConstants.``NAME_LAYER`` <> "Layer" then
    failwith "Babylon inferred literal class constants were not preserved"
if ClipboardEventTypes.``COPY`` <> 1.0 || KeyboardEventTypes.``KEYDOWN`` <> 1.0 || PointerEventTypes.``POINTERDOUBLETAP`` <> 64.0 then
    failwith "Babylon inferred event constants were not preserved"
if LightConstants.``FALLOFF_PHYSICAL`` <> 1.0 || Logger.``AllLogLevel`` <> 7.0 || StencilState.``KEEP`` <> 7680.0 then
    failwith "Babylon inferred subsystem constants were not preserved"
if halton.``x`` = 0.0 && halton.``y`` = 0.0 then
    failwith "Babylon inferred readonly instance state was not preserved"
if easingSamples.Length <> 12 || (easingSamples |> List.exists System.Double.IsNaN) || stencilDefaults.``func`` <> StencilState.``ALWAYS`` then
    failwith "Babylon inferred-literal class dependency closure was not preserved"
if storedValue <> "stored" then
    failwith "Babylon generic static class method was not preserved"
if basisConfiguration.``supportedCompressionFormats``.Value.``etc1`` <> Some true || basisConfiguration.``loadMipmapLevels`` <> Some true || isNull (box filesToLoad) then
    failwith "Babylon inline object class properties were not preserved"
if abortError.name <> "AbortError" || abortError.message <> "binding aborted" || abortError.stack.IsNone || abortError.cause.IsSome then
    failwith "Babylon JavaScript Error inheritance was not preserved"
if runtimeError.name <> "RuntimeError" || runtimeError.``errorCode`` <> ErrorCodesType.``SceneLoaderError`` || runtimeError.``innerError``.IsNone || SimpleVariables.``ErrorCodes``.``ReadFileError`` <> ErrorCodesType.``ReadFileError`` then
    failwith "Babylon runtime error code closure was not preserved"
if readFileError.name <> "ReadFileError" || readFileError.``errorCode`` <> ErrorCodesType.``ReadFileError`` || not (obj.ReferenceEquals(readFileError.``file``, proofFile)) then
    failwith "Babylon read-file error inheritance was not preserved"
if identityDiagonal <> (1.0, 1.0, 1.0, 1.0) || translation <> (2.0, 3.0, 4.0) || scaling <> (5.0, 6.0, 7.0) || matrixLike.``updateFlag`` < 0.0 then
    failwith "Babylon fixed matrix tuple functions were not preserved"
if copiedMatrix[0] <> 5.0 || copiedMatrix[5] <> 6.0 || copiedMatrix[10] <> 7.0 || copiedTargetScale <> 5.0 || not invertible || not invertibleToRef || inverseMatrix[0] <> 0.2 || product[0] <> 1.0 then
    failwith "Babylon readonly matrix function closure was not preserved"
if vector2Text <> "{X: 1.0 Y: 2.0}" || vector3Dot <> 20.0 || vector3Length <> 3.0 || vector3LengthSquared <> 9.0 || vector3Distance <> 5.0 || vector3DistanceSquared <> 25.0 || planeDistance <> 11.0 || vector3Text <> "{X: 1.0 Y: 2.0 Z: 2.0}" || vector4Dot <> 40.0 || vector4Text <> "{X: 1.0 Y: 2.0 Z: 3.0 W: 4.0}" then
    failwith "Babylon readonly vector function closure was not preserved"
if fromFloatsResult.``tag`` <> "preserved" || not (obj.ReferenceEquals(fromFloatsResult, scaleToRefResult)) || not (obj.ReferenceEquals(fromFloatsResult, copyToRefResult)) || not (obj.ReferenceEquals(fromFloatsResult, subtractToRefResult)) || not (obj.ReferenceEquals(fromFloatsResult, lerpToRefResult)) || not (obj.ReferenceEquals(fromFloatsResult, normalizeToRefResult)) || not (obj.ReferenceEquals(fromFloatsResult, scaleInPlaceResult)) then
    failwith "Babylon constrained generic vector identity was not preserved"
if degreesResult.``tag`` <> "coordinates" || abs (degreesResult.``lat`` - System.Math.PI / 2.0) > 0.0000001 || abs (degreesResult.``lon`` - System.Math.PI) > 0.0000001 || not (obj.ReferenceEquals(normalResult, genericVector)) || abs (normalResult.``z`` - 1.0) > 0.0000001 then
    failwith "Babylon constrained generic geospatial identity was not preserved"
if wgs84.``semiMajorAxis`` <> 6378137.0 || wgs84.``semiMinorAxis`` >= wgs84.``semiMajorAxis`` || not (obj.ReferenceEquals(floatingOriginResult, targetMatrix)) then
    failwith "Babylon readonly geospatial and floating-origin closure was not preserved"
if shaderStore.["codexInlineObjectProof"] <> "void main() {}" || ShaderStore.``GetShadersRepository``() <> "src/Shaders/" || uniformMat4Size <> 16.0 then
    failwith "Babylon inline object class returns and static stores were not preserved"
if observer.IsNone || not (observableA.``hasObservers``()) || observedValues.Count <> 3 || observedValues[0] <> "first" || observedValues[1] <> "multi:first" || observedValues[2] <> "multi:second" then
    failwith "Babylon observable callback and overload closure was not preserved"
if not thinAnimationEnded || thinSprite.``animationStarted`` then
    failwith "Babylon nullable callback class method was not preserved"
multiObserver.``dispose``()
let externalDefineValue: MaterialDefinesConstructor19Parameter1ObjectValue1Object =
    createObj [ "type" ==> "boolean"; "default" ==> false ] |> unbox
let externalDefines: MaterialDefinesConstructor19Parameter1Object =
    createObj [ "CUSTOM" ==> externalDefineValue ] |> unbox
let materialDefines = MaterialDefines.Create(externalDefines)
materialDefines.["CUSTOM"] <- box true
materialDefines.["INSTANCESCOLOR"] <- box true
let instanceAttributes = ResizeArray<string>()
SimpleFunctions.``PrepareAttributesForInstances``.Invoke(instanceAttributes, materialDefines)
materialDefines.``markAsProcessed``()
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
if unbox<bool> materialDefines.["CUSTOM"] <> true || materialDefines.``isDirty`` || derivedMaterialDefines.Count <> 10 || not (instanceAttributes.Contains("instanceColor")) then
    failwith "Babylon indexed inline-object material defines closure was not preserved"
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
if generatedGuid.Length = 0 || bvhLoaderMetadata.``name`` <> "bvh" || bvhLoaderMetadata.``extensions``.``.bvh``.``isBinary`` || gltfMagicBase64Encoded.Length = 0 || maxHalfFloat <> 65504.0 || int8Size <> 1.0 then
    failwith "Babylon native helper and loader metadata batch was not preserved"
nodeHasWindow |> ignore

loaderRegistration |> ignore
camera.dispose()
light.dispose()
engine.dispose()
printfn "Babylon full candidate runtime smoke passed"
