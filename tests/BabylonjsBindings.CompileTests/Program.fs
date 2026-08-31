open Qualification.Babylon
open Fable.Core
open BabylonjsBindings.Enums
open BabylonjsBindings.StringEnums
open BabylonjsBindings.ObjectTypes
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.FiniteDependentMaps
let shaderLanguage: ShaderLanguage = ShaderLanguage.``WGSL``
let loaderState: GLTFLoaderState = GLTFLoaderState.``READY``
let fftSize: AudioAnalyzerFFTSizeType = AudioAnalyzerFFTSizeType.``N32768``
let errorCode: ErrorCodesType = ErrorCodesType.``SceneLoaderError``
let powerPreference: PowerPreference = PowerPreference.``HighPerformance``
let arcRotateInteraction: ArcRotateInteraction = ArcRotateInteraction.``Pan``
let sizeLike: SizeLike = Unchecked.defaultof<SizeLike>
let hotSpotQuery: HotSpotQuery = Unchecked.defaultof<HotSpotQuery>
let textureHandle: BabylonjsBindings.TypeAliases.FrameGraphTextureHandle = 1.0
let stageAction: BabylonjsBindings.TypeAliases.SimpleStageAction = Unchecked.defaultof<BabylonjsBindings.TypeAliases.SimpleStageAction>
let nullableLabel: BabylonjsBindings.TypeAliases.Nullable<string> = None
let easing: IEasingFunction = Unchecked.defaultof<IEasingFunction>
let inspectableOptions: IInspectableOptions = Unchecked.defaultof<IInspectableOptions>
let computePipelineContext: IComputePipelineContext = Unchecked.defaultof<IComputePipelineContext>
let matrixLike: IMatrixLike = Unchecked.defaultof<IMatrixLike>
let readonlyMatrixLike: DeepImmutableIMatrixLike = Unchecked.defaultof<DeepImmutableIMatrixLike>
let readonlyVector3Like: DeepImmutableIVector3Like = Unchecked.defaultof<DeepImmutableIVector3Like>
let readonlyEllipsoidLike: DeepImmutableIEllipsoidLike = Unchecked.defaultof<DeepImmutableIEllipsoidLike>
let mipmap: IMipmap = Unchecked.defaultof<IMipmap>
let simplificationInterface: ISimplificationSettings = Unchecked.defaultof<ISimplificationSettings>
let decodedData: IDecodedData = Unchecked.defaultof<IDecodedData>
let bitArray: BitArray = Unchecked.defaultof<BitArray>
let bitArrayFactory: BitArrayStatic = BitArray
let color3Factory: Color3Static = Color3
let color4Factory: Color4Static = Color4
let meshoptFactory: MeshoptCompressionStatic = MeshoptCompression
let webXRFeatureNameFactory: WebXRFeatureNameStatic = WebXRFeatureName
let partialNodeMaterialOptions: PartialINodeMaterialOptions = Unchecked.defaultof<PartialINodeMaterialOptions>
let animationMaskFactory: AnimationGroupMaskStatic = AnimationGroupMask
let alphaStateFactory: AlphaStateStatic = AlphaState
let richTypeFactory: RichTypeStatic = RichType
let lazyFactoryType: LazyStatic = Lazy
let smartArrayFactory: SmartArrayStatic = SmartArray
let smartArrayNoDuplicateFactory: SmartArrayNoDuplicateStatic = SmartArrayNoDuplicate
let animationEventFactory: AnimationEventStatic = AnimationEvent
let factorGradientFactory: FactorGradientStatic = FactorGradient
let basisTranscodeConfigurationFactory: BasisTranscodeConfigurationStatic = BasisTranscodeConfiguration
let javascriptError: JavaScriptError = Unchecked.defaultof<JavaScriptError>
let baseErrorFactory: BaseErrorStatic = BaseError
let abortErrorFactory: AbortErrorStatic = AbortError
let runtimeErrorFactory: RuntimeErrorStatic = RuntimeError
let readFileErrorFactory: ReadFileErrorStatic = ReadFileError
let filesInputStoreFactory: FilesInputStoreStatic = FilesInputStore
let shaderStoreFactory: ShaderStoreStatic = ShaderStore
let webGPUShaderProcessorFactory: WebGPUShaderProcessorStatic = WebGPUShaderProcessor
let performanceConfiguratorFactory: PerformanceConfiguratorStatic = PerformanceConfigurator
let simplificationSettingsFactory: SimplificationSettingsStatic = SimplificationSettings
let stencilStateComposerFactory: StencilStateComposerStatic = StencilStateComposer
let webGLHardwareTextureFactory: WebGLHardwareTextureStatic = WebGLHardwareTexture
let constantsFactory: ConstantsStatic = Constants
let easingFunctionFactory: EasingFunctionStatic = EasingFunction
let backEaseFactory: BackEaseStatic = BackEase
let bezierCurveEaseFactory: BezierCurveEaseStatic = BezierCurveEase
let bounceEaseFactory: BounceEaseStatic = BounceEase
let circleEaseFactory: CircleEaseStatic = CircleEase
let cubicEaseFactory: CubicEaseStatic = CubicEase
let elasticEaseFactory: ElasticEaseStatic = ElasticEase
let exponentialEaseFactory: ExponentialEaseStatic = ExponentialEase
let powerEaseFactory: PowerEaseStatic = PowerEase
let quadraticEaseFactory: QuadraticEaseStatic = QuadraticEase
let quarticEaseFactory: QuarticEaseStatic = QuarticEase
let quinticEaseFactory: QuinticEaseStatic = QuinticEase
let sineEaseFactory: SineEaseStatic = SineEase
let stencilStateFactory: StencilStateStatic = StencilState
let dataStorageFactory: DataStorageStatic = DataStorage
let thinSpriteFactory: ThinSpriteStatic = ThinSprite
let observerFactory: ObserverStatic = Observer
let observableFactory: ObservableStatic = Observable
let dualShockPadFactory: DualShockPadStatic = DualShockPad
let genericPadFactory: GenericPadStatic = GenericPad
let multiObserverFactory: MultiObserverStatic = MultiObserver
let xbox360PadFactory: Xbox360PadStatic = Xbox360Pad
let prepareAttributesForInstances = BabylonjsBindings.SimpleFunctions.``PrepareAttributesForInstances``
let getRegisteredSceneLoaderPluginMetadata: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetRegisteredSceneLoaderPluginMetadata = BabylonjsBindings.SimpleFunctions.``GetRegisteredSceneLoaderPluginMetadata``
let identityMatrixToRef: BabylonjsBindings.SimpleFunctions.FunctionBinding_IdentityMatrixToRef = BabylonjsBindings.SimpleFunctions.``IdentityMatrixToRef``
let markAsDirty: BabylonjsBindings.SimpleFunctions.FunctionBinding_MarkAsDirty = BabylonjsBindings.SimpleFunctions.``MarkAsDirty``
let scalingMatrixToRef: BabylonjsBindings.SimpleFunctions.FunctionBinding_ScalingMatrixToRef = BabylonjsBindings.SimpleFunctions.``ScalingMatrixToRef``
let translationMatrixToRef: BabylonjsBindings.SimpleFunctions.FunctionBinding_TranslationMatrixToRef = BabylonjsBindings.SimpleFunctions.``TranslationMatrixToRef``
let copyMatrixToArray = BabylonjsBindings.SimpleFunctions.``CopyMatrixToArray``
let copyMatrixToRef = BabylonjsBindings.SimpleFunctions.``CopyMatrixToRef``
let invertMatrixToArray = BabylonjsBindings.SimpleFunctions.``InvertMatrixToArray``
let invertMatrixToRef = BabylonjsBindings.SimpleFunctions.``InvertMatrixToRef``
let multiplyMatricesToArray = BabylonjsBindings.SimpleFunctions.``MultiplyMatricesToArray``
let multiplyMatricesToRef = BabylonjsBindings.SimpleFunctions.``MultiplyMatricesToRef``
let vector3Distance = BabylonjsBindings.SimpleFunctions.``Vector3Distance``
let vector3Dot = BabylonjsBindings.SimpleFunctions.``Vector3Dot``
let vector4Dot = BabylonjsBindings.SimpleFunctions.``Vector4Dot``
let fullOffsetViewProjection = BabylonjsBindings.SimpleFunctions.``GetFullOffsetViewProjectionToRef``
let latLonFromDegreesToRef = BabylonjsBindings.SimpleFunctions.``LatLonFromDegreesToRef``
let latLonToNormalToRef = BabylonjsBindings.SimpleFunctions.``LatLonToNormalToRef``
let vector3CopyToRef = BabylonjsBindings.SimpleFunctions.``Vector3CopyToRef``
let vector3FromFloatsToRef = BabylonjsBindings.SimpleFunctions.``Vector3FromFloatsToRef``
let vector3LerpToRef = BabylonjsBindings.SimpleFunctions.``Vector3LerpToRef``
let vector3NormalizeToRef = BabylonjsBindings.SimpleFunctions.``Vector3NormalizeToRef``
let vector3ScaleInPlace = BabylonjsBindings.SimpleFunctions.``Vector3ScaleInPlace``
let vector3ScaleToRef = BabylonjsBindings.SimpleFunctions.``Vector3ScaleToRef``
let vector3SubtractToRef = BabylonjsBindings.SimpleFunctions.``Vector3SubtractToRef``
let completeGreasedLineColorTable = BabylonjsBindings.SimpleFunctions.``CompleteGreasedLineColorTable``

// M2 DeviceType dependent-map positive cases (all eight rows).
let m2GenericSource (manager: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager) = manager.getDeviceSource(DeviceTypeGeneric.Generic)
let m2KeyboardSource (manager: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager) = manager.getDeviceSource(DeviceTypeKeyboard.Keyboard)
let m2MouseSource (manager: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager) = manager.getDeviceSource(DeviceTypeMouse.Mouse)
let m2TouchSource (manager: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager) = manager.getDeviceSource(DeviceTypeTouch.Touch)
let m2DualShockSource (manager: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager) = manager.getDeviceSource(DeviceTypeDualShock.DualShock)
let m2XboxSource (manager: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager) = manager.getDeviceSource(DeviceTypeXbox.Xbox)
let m2SwitchSource (manager: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager) = manager.getDeviceSource(DeviceTypeSwitch.Switch)
let m2DualSenseSource (manager: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager) = manager.getDeviceSource(DeviceTypeDualSense.DualSense)
let m2KeyboardInput (source: KeyboardDeviceSource) : float = source.getInput 13.0
let m2MouseInput (source: MouseDeviceSource) : float = source.getInput PointerDeviceInput.LeftClick
let m2DualSenseInput (source: DualSenseDeviceSource) : float = source.getInput DualSenseInput.Cross

// M2 FlowGraph dependent-map positive cases (all six rows and both switch domains).
let m2AnimationAsset (assets: IAssetContainer) : Animation option = BabylonjsBindings.FiniteDependentMaps.GetFlowGraphAssetWithType.Invoke(assets, FlowGraphAnimationAsset.Value, 0.0)
let m2AnimationGroupAsset (assets: IAssetContainer) : AnimationGroup option = BabylonjsBindings.FiniteDependentMaps.GetFlowGraphAssetWithType.Invoke(assets, FlowGraphAnimationGroupAsset.Value, 0.0)
let m2MeshAsset (assets: IAssetContainer) : Mesh option = BabylonjsBindings.FiniteDependentMaps.GetFlowGraphAssetWithType.Invoke(assets, FlowGraphMeshAsset.Value, 0.0)
let m2MaterialAsset (assets: IAssetContainer) : Material option = BabylonjsBindings.FiniteDependentMaps.GetFlowGraphAssetWithType.Invoke(assets, FlowGraphMaterialAsset.Value, 0.0)
let m2CameraAsset (assets: IAssetContainer) : Camera option = BabylonjsBindings.FiniteDependentMaps.GetFlowGraphAssetWithType.Invoke(assets, FlowGraphCameraAsset.Value, 0.0)
let m2LightAsset (assets: IAssetContainer) : Light option = BabylonjsBindings.FiniteDependentMaps.GetFlowGraphAssetWithType.Invoke(assets, FlowGraphLightAsset.Value, 0.0)
let m2NumberSwitch: FlowGraphNumberSwitchBlock = Unchecked.defaultof<_>
let m2IntegerSwitch: FlowGraphIntegerSwitchBlock = Unchecked.defaultof<_>
let m2MeshGetter: FlowGraphGetPropertyBlock<float, FlowGraphMeshAsset, Mesh> = Unchecked.defaultof<_>
let m2MaterialSetter: FlowGraphSetPropertyBlock<Color3, FlowGraphMaterialAsset, Material> = Unchecked.defaultof<_>
let m2CameraParser: FlowGraphJsonPointerParserBlock<string, Camera> = Unchecked.defaultof<_>
let m2LightAssetBlock: FlowGraphGetAssetBlock<FlowGraphLightAsset, Light> = Unchecked.defaultof<_>

// M2 WebXR dependent-map positive cases (all twenty-two rows).
let m2XRRows (manager: BabylonjsBindings.FiniteDependentMaps.WebXRFeaturesManager) =
    let anchor: WebXRAnchorSystem = manager.getEnabledFeature XRAnchorSystem.Value
    let background: WebXRBackgroundRemover = manager.getEnabledFeature XRBackgroundRemover.Value
    let hitTest: WebXRHitTest = manager.getEnabledFeature XRHitTest.Value
    let mesh: WebXRMeshDetector = manager.getEnabledFeature XRMeshDetection.Value
    let physics: WebXRControllerPhysics = manager.getEnabledFeature XRPhysicsController.Value
    let plane: WebXRPlaneDetector = manager.getEnabledFeature XRPlaneDetection.Value
    let pointer: WebXRControllerPointerSelection = manager.getEnabledFeature XRPointerSelection.Value
    let teleport: WebXRMotionControllerTeleportation = manager.getEnabledFeature XRTeleportation.Value
    let points: WebXRFeaturePointSystem = manager.getEnabledFeature XRFeaturePoints.Value
    let hands: WebXRHandTracking = manager.getEnabledFeature XRHandTracking.Value
    let images: WebXRImageTracking = manager.getEnabledFeature XRImageTracking.Value
    let near: WebXRNearInteraction = manager.getEnabledFeature XRNearInteraction.Value
    let dom: WebXRDomOverlay = manager.getEnabledFeature XRDomOverlay.Value
    let movement: WebXRControllerMovement = manager.getEnabledFeature XRMovement.Value
    let light: WebXRLightEstimation = manager.getEnabledFeature XRLightEstimation.Value
    let eyes: WebXREyeTracking = manager.getEnabledFeature XREyeTracking.Value
    let walking: WebXRWalkingLocomotion = manager.getEnabledFeature XRWalkingLocomotion.Value
    let layers: WebXRLayers = manager.getEnabledFeature XRLayers.Value
    let depth: WebXRDepthSensing = manager.getEnabledFeature XRDepthSensing.Value
    let warp: WebXRSpaceWarp = manager.getEnabledFeature XRSpaceWarp.Value
    let raw: WebXRRawCameraAccess = manager.getEnabledFeature XRRawCameraAccess.Value
    let body: WebXRBodyTracking = manager.getEnabledFeature XRBodyTracking.Value
    anchor, background, hitTest, mesh, physics, plane, pointer, teleport, points, hands, images, near, dom, movement, light, eyes, walking, layers, depth, warp, raw, body

let m2XRExactOptions (manager: BabylonjsBindings.FiniteDependentMaps.WebXRFeaturesManager) (anchorOptions: IWebXRAnchorSystemOptions) (hitOptions: IWebXRHitTestOptions) =
    let anchor: WebXRAnchorSystem = manager.enableFeature(XRAnchorSystem.Value, moduleOptions = anchorOptions)
    let hit: WebXRHitTest = manager.enableFeature(XRHitTest.Value, moduleOptions = hitOptions)
    anchor, hit

let m2ResolveFeature (resolver: ResolveWebXRFeature) : WebXRAnchorSystem = resolver.Resolve XRAnchorSystem.Value
let m2ResolveOptions (resolver: ResolveWebXRFeatureOptions) : IWebXRHitTestOptions = resolver.Resolve XRHitTest.Value

let m2DownstreamTypes: BabylonjsBindings.FiniteDependentMaps.WebXRExperienceHelper * BabylonjsBindings.FiniteDependentMaps.WebXREnterExitUI * BabylonjsBindings.FiniteDependentMaps.WebXRDefaultExperience * BabylonjsBindings.FiniteDependentMaps.VRExperienceHelper * BabylonjsBindings.FiniteDependentMaps.HandConstraintBehavior = Unchecked.defaultof<_>
let m2DeviceManagerFactory: BabylonjsBindings.FiniteDependentMaps.DeviceSourceManagerStatic = BabylonjsBindings.FiniteDependentMaps.DeviceSourceManager
let m2InternalDeviceManagerFactory: BabylonjsBindings.FiniteDependentMaps.InternalDeviceSourceManagerStatic = BabylonjsBindings.FiniteDependentMaps.InternalDeviceSourceManager
let m2XRFeaturesFactory: BabylonjsBindings.FiniteDependentMaps.WebXRFeaturesManagerStatic = BabylonjsBindings.FiniteDependentMaps.WebXRFeaturesManager
let m2XRExperienceFactory: BabylonjsBindings.FiniteDependentMaps.WebXRExperienceHelperStatic = BabylonjsBindings.FiniteDependentMaps.WebXRExperienceHelper
let m2XREnterExitFactory: BabylonjsBindings.FiniteDependentMaps.WebXREnterExitUIStatic = BabylonjsBindings.FiniteDependentMaps.WebXREnterExitUI
let m2XRDefaultFactory: BabylonjsBindings.FiniteDependentMaps.WebXRDefaultExperienceStatic = BabylonjsBindings.FiniteDependentMaps.WebXRDefaultExperience
let m2VRFactory: BabylonjsBindings.FiniteDependentMaps.VRExperienceHelperStatic = BabylonjsBindings.FiniteDependentMaps.VRExperienceHelper
let m2HandConstraintFactory: BabylonjsBindings.FiniteDependentMaps.HandConstraintBehaviorStatic = BabylonjsBindings.FiniteDependentMaps.HandConstraintBehavior

// M1 exact projection compile proofs.
let pointerAliasRoundTrip (value: BrowserPointerInputMapEntry<string>) : PointerInputMapEntry<string> = value
let pointerSupportRoundTrip (value: PointerInputMapEntry<string>) : BrowserPointerInputMapEntry<string> = value
let wheelAliasRoundTrip (value: BrowserWheelInputMapEntry<string>) : WheelInputMapEntry<string> = value
let touchAliasRoundTrip (value: BrowserTouchInputMapEntry<string>) : TouchInputMapEntry<string> = value
let keyboardAliasRoundTrip (value: BrowserKeyboardInputMapEntry<string>) : KeyboardInputMapEntry<string> = value
let inputMapAliasRoundTrip (value: BrowserInputMapEntry<string>) : InputMapEntry<string> = value
let pointerDefaultAliasRoundTrip (value: BrowserPointerInputMapEntry<string>) : PointerInputMapEntry = value
let wheelDefaultAliasRoundTrip (value: BrowserWheelInputMapEntry<string>) : WheelInputMapEntry = value
let touchDefaultAliasRoundTrip (value: BrowserTouchInputMapEntry<string>) : TouchInputMapEntry = value
let keyboardDefaultAliasRoundTrip (value: BrowserKeyboardInputMapEntry<string>) : KeyboardInputMapEntry = value
let inputMapDefaultAliasRoundTrip (value: BrowserInputMapEntry<string>) : InputMapEntry = value
let interactionAliasRoundTrip (value: JavaScriptKeyOf<obj>) : InteractionName<obj> = value
let typedArrayConstructorAliasRoundTrip (value: BrowserTypedArrayConstructor<JS.Float32Array>) : TypedArrayConstructor<JS.Float32Array> = value
let typedArrayConstructorDefault: TypedArrayConstructor = Unchecked.defaultof<TypedArrayConstructor>
let createAlignedInt8 (constructor: TypedArrayConstructor<JS.Int8Array>) : JS.Int8Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeInt8(constructor, 4.0)
let createAlignedUint8 (constructor: TypedArrayConstructor<JS.Uint8Array>) : JS.Uint8Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeUint8(constructor, 4.0)
let createAlignedUint8Clamped (constructor: TypedArrayConstructor<JS.Uint8ClampedArray>) : JS.Uint8ClampedArray = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeUint8Clamped(constructor, 4.0)
let createAlignedInt16 (constructor: TypedArrayConstructor<JS.Int16Array>) : JS.Int16Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeInt16(constructor, 4.0)
let createAlignedUint16 (constructor: TypedArrayConstructor<JS.Uint16Array>) : JS.Uint16Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeUint16(constructor, 4.0)
let createAlignedInt32 (constructor: TypedArrayConstructor<JS.Int32Array>) : JS.Int32Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeInt32(constructor, 4.0)
let createAlignedUint32 (constructor: TypedArrayConstructor<JS.Uint32Array>) : JS.Uint32Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeUint32(constructor, 4.0)
let createAlignedFloat32 (constructor: TypedArrayConstructor<JS.Float32Array>) : JS.Float32Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeFloat32(constructor, 4.0)
let createAlignedFloat64 (constructor: TypedArrayConstructor<JS.Float64Array>) : JS.Float64Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeFloat64(constructor, 4.0)
let createAlignedBigInt64 (constructor: TypedArrayConstructor<JS.BigInt64Array>) : JS.BigInt64Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeBigInt64(constructor, 4.0)
let createAlignedBigUint64 (constructor: TypedArrayConstructor<BrowserBigUint64Array>) : BrowserBigUint64Array = BabylonjsBindings.SimpleFunctions.``CreateAlignedTypedArray``.InvokeBigUint64(constructor, 4.0)
let inspectNodeIntersection (tree: IGLTFObjectModelTree) =
    let nodes = tree.``nodes``
    let weights = nodes.``__array__``.``weights``
    weights.``componentsCount``, weights.``length``.``type``, weights.``__array__``.``__target__``, weights.``__array__``.``get``
let inspectTreeConstituents (tree: IGLTFObjectModelTree) = tree.``cameras``, tree.``nodes``, tree.``materials``, tree.``extensions``, tree.``animations``, tree.``meshes``
let gltfNodesTwoArity: IGLTFObjectModelTreeNodesObject<INode, TransformNode> = Unchecked.defaultof<_>
let gltfNodesOneArity: IGLTFObjectModelTreeNodesObject<INode> = gltfNodesTwoArity
let gltfNodesDefault: IGLTFObjectModelTreeNodesObject = gltfNodesTwoArity
let mappingForKey: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetMappingForKey = BabylonjsBindings.SimpleFunctions.``GetMappingForKey``
let deepMerge: BabylonjsBindings.SimpleFunctions.FunctionBinding_deepMerge = BabylonjsBindings.SimpleFunctions.``deepMerge``
let physicsV1Factory: PhysicsEngineV1Static = PhysicsEngineV1
let physicsV2Factory: PhysicsEngineV2Static = PhysicsEngineV2
let gltfLoaderOptionsTypeOnly: GLTFLoaderOptions = Unchecked.defaultof<GLTFLoaderOptions>
let materialDefinesFactory: MaterialDefinesStatic = MaterialDefines
let decalMapDefinesFactory: DecalMapDefinesStatic = DecalMapDefines
let imageProcessingDefinesFactory: ImageProcessingConfigurationDefinesStatic = ImageProcessingConfigurationDefines
let anisotropicDefinesFactory: MaterialAnisotropicDefinesStatic = MaterialAnisotropicDefines
let brdfDefinesFactory: MaterialBRDFDefinesStatic = MaterialBRDFDefines
let clearCoatDefinesFactory: MaterialClearCoatDefinesStatic = MaterialClearCoatDefines
let detailMapDefinesFactory: MaterialDetailMapDefinesStatic = MaterialDetailMapDefines
let greasedLineDefinesFactory: MaterialGreasedLineDefinesStatic = MaterialGreasedLineDefines
let iridescenceDefinesFactory: MaterialIridescenceDefinesStatic = MaterialIridescenceDefines
let sheenDefinesFactory: MaterialSheenDefinesStatic = MaterialSheenDefines
let subSurfaceDefinesFactory: MaterialSubSurfaceDefinesStatic = MaterialSubSurfaceDefines
let strideFunction = BabylonjsBindings.SimpleFunctions.``VertexBufferDeduceStride``
let epsilon = BabylonjsBindings.SimpleVariables.``Epsilon``
let shaderDescriptor = BabylonjsBindings.SimpleVariables.``clearQuadVertexShaderWGSL``
let padNumber = BabylonjsBindings.SimpleVariables.``PadNumber``
let testBase64DataUrl = BabylonjsBindings.SimpleVariables.``TestBase64DataUrl``
let nativeData: BabylonjsBindings.TypeAliases.NativeData = Unchecked.defaultof<BabylonjsBindings.TypeAliases.NativeData>
let computeBindingMapping: BabylonjsBindings.TypeAliases.ComputeBindingMapping = Unchecked.defaultof<BabylonjsBindings.TypeAliases.ComputeBindingMapping>
let textureSize: BabylonjsBindings.TypeAliases.TextureSize = Unchecked.defaultof<BabylonjsBindings.TypeAliases.TextureSize>
let bodyRigMapping: BabylonjsBindings.TypeAliases.XRBodyMeshRigMapping = Unchecked.defaultof<BabylonjsBindings.TypeAliases.XRBodyMeshRigMapping>
let animationOptimization: BabylonjsBindings.TypeAliases.AnimationOptimization = Unchecked.defaultof<BabylonjsBindings.TypeAliases.AnimationOptimization>
let tensorValue: BabylonjsBindings.TypeAliases.TensorValue = Unchecked.defaultof<BabylonjsBindings.TypeAliases.TensorValue>
let computeShaderOptions: IComputeShaderOptions = Unchecked.defaultof<IComputeShaderOptions>
let imageTrackingOptions: IWebXRImageTrackingOptions = Unchecked.defaultof<IWebXRImageTrackingOptions>
let flowGraphBlockConfiguration: IFlowGraphBlockConfiguration = Unchecked.defaultof<IFlowGraphBlockConfiguration>
let exrHeader: IEXRHeader = Unchecked.defaultof<IEXRHeader>
let gltfLoaderData: IGLTFLoaderData = Unchecked.defaultof<IGLTFLoaderData>
let createDecoderAsync: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateDecoderAsync = BabylonjsBindings.SimpleFunctions.``CreateDecoderAsync``
let getExrHeader: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetExrHeader = BabylonjsBindings.SimpleFunctions.``GetExrHeader``
let basisFileInfoFactory: BasisFileInfoStatic = BasisFileInfo
let nativeDataStreamFactory: NativeDataStreamStatic = NativeDataStream
let validatedNativeDataStreamFactory: ValidatedNativeDataStreamStatic = ValidatedNativeDataStream
let fresnelParametersFactory: FresnelParametersStatic = FresnelParameters
let webXRControllerComponentFactory: WebXRControllerComponentStatic = WebXRControllerComponent
let parseUint8 = BabylonjsBindings.SimpleFunctions.``ParseUint8``
let textureSizeIsObject = BabylonjsBindings.SimpleFunctions.``textureSizeIsObject``
let getMimeType = BabylonjsBindings.SimpleVariables.``GetMimeType``
let mixamoRigMapping = BabylonjsBindings.SimpleVariables.``MixamoRigMapping``
let stringTools = BabylonjsBindings.SimpleVariables.``StringTools``
let guid = BabylonjsBindings.SimpleVariables.``GUID``
let bvhLoaderMetadata = BabylonjsBindings.SimpleVariables.``BVHFileLoaderMetadata``
let gltfMagicBase64Encoded = BabylonjsBindings.SimpleVariables.``GLTFMagicBase64Encoded``
let registeredGltfExtensions: BabylonjsBindings.SimpleVariables.VariableShape_registeredGLTFExtensions = BabylonjsBindings.SimpleVariables.``registeredGLTFExtensions``
let errorCodes: BabylonjsBindings.SimpleVariables.VariableShape_ErrorCodes = BabylonjsBindings.SimpleVariables.``ErrorCodes``
let wgs84Ellipsoid: DeepImmutableIEllipsoidLike = BabylonjsBindings.SimpleVariables.``Wgs84Ellipsoid``
let richTypeColor3: RichType<Color3> = BabylonjsBindings.SimpleVariables.``RichTypeColor3``
let richTypeColor4: RichType<Color4> = BabylonjsBindings.SimpleVariables.``RichTypeColor4``
let staticOffsetColor3: DeepImmutableColor3 = BabylonjsBindings.SimpleVariables.``_StaticOffsetValueColor3``
let staticOffsetColor4: DeepImmutableColor4 = BabylonjsBindings.SimpleVariables.``_StaticOffsetValueColor4``
let staticOffsetSize: DeepImmutableSize = BabylonjsBindings.SimpleVariables.``_StaticOffsetValueSize``
let engine = nullEngine ()
let scene = scene engine
let _ = box "compile-smoke" scene
initialiseLoader ()
if int shaderLanguage <> 1 || int loaderState <> 1 || int fftSize <> 32768 then failwith "maintained enum values drifted"
errorCode |> ignore
powerPreference |> ignore
arcRotateInteraction |> ignore
sizeLike |> ignore
hotSpotQuery |> ignore
textureHandle |> ignore
stageAction |> ignore
nullableLabel |> ignore
easing |> ignore
inspectableOptions |> ignore
computePipelineContext |> ignore
matrixLike |> ignore
readonlyMatrixLike |> ignore
readonlyVector3Like |> ignore
readonlyEllipsoidLike |> ignore
mipmap |> ignore
simplificationInterface |> ignore
decodedData |> ignore
bitArray |> ignore
bitArrayFactory |> ignore
color3Factory |> ignore
color4Factory |> ignore
meshoptFactory |> ignore
webXRFeatureNameFactory |> ignore
partialNodeMaterialOptions |> ignore
animationMaskFactory |> ignore
alphaStateFactory |> ignore
richTypeFactory |> ignore
lazyFactoryType |> ignore
smartArrayFactory |> ignore
smartArrayNoDuplicateFactory |> ignore
animationEventFactory |> ignore
factorGradientFactory |> ignore
basisTranscodeConfigurationFactory |> ignore
javascriptError |> ignore
baseErrorFactory |> ignore
abortErrorFactory |> ignore
runtimeErrorFactory |> ignore
readFileErrorFactory |> ignore
filesInputStoreFactory |> ignore
shaderStoreFactory |> ignore
webGPUShaderProcessorFactory |> ignore
performanceConfiguratorFactory |> ignore
simplificationSettingsFactory |> ignore
stencilStateComposerFactory |> ignore
webGLHardwareTextureFactory |> ignore
constantsFactory |> ignore
easingFunctionFactory |> ignore
backEaseFactory |> ignore
bezierCurveEaseFactory |> ignore
bounceEaseFactory |> ignore
circleEaseFactory |> ignore
cubicEaseFactory |> ignore
elasticEaseFactory |> ignore
exponentialEaseFactory |> ignore
powerEaseFactory |> ignore
quadraticEaseFactory |> ignore
quarticEaseFactory |> ignore
quinticEaseFactory |> ignore
sineEaseFactory |> ignore
stencilStateFactory |> ignore
dataStorageFactory |> ignore
thinSpriteFactory |> ignore
observerFactory |> ignore
observableFactory |> ignore
dualShockPadFactory |> ignore
genericPadFactory |> ignore
multiObserverFactory |> ignore
xbox360PadFactory |> ignore
prepareAttributesForInstances |> ignore
getRegisteredSceneLoaderPluginMetadata |> ignore
identityMatrixToRef |> ignore
markAsDirty |> ignore
scalingMatrixToRef |> ignore
translationMatrixToRef |> ignore
copyMatrixToArray |> ignore
copyMatrixToRef |> ignore
invertMatrixToArray |> ignore
invertMatrixToRef |> ignore
multiplyMatricesToArray |> ignore
multiplyMatricesToRef |> ignore
vector3Distance |> ignore
vector3Dot |> ignore
vector4Dot |> ignore
fullOffsetViewProjection |> ignore
latLonFromDegreesToRef |> ignore
latLonToNormalToRef |> ignore
vector3CopyToRef |> ignore
vector3FromFloatsToRef |> ignore
vector3LerpToRef |> ignore
vector3NormalizeToRef |> ignore
vector3ScaleInPlace |> ignore
vector3ScaleToRef |> ignore
vector3SubtractToRef |> ignore
completeGreasedLineColorTable |> ignore
materialDefinesFactory |> ignore
decalMapDefinesFactory |> ignore
imageProcessingDefinesFactory |> ignore
anisotropicDefinesFactory |> ignore
brdfDefinesFactory |> ignore
clearCoatDefinesFactory |> ignore
detailMapDefinesFactory |> ignore
greasedLineDefinesFactory |> ignore
iridescenceDefinesFactory |> ignore
sheenDefinesFactory |> ignore
subSurfaceDefinesFactory |> ignore
strideFunction |> ignore
epsilon |> ignore
shaderDescriptor |> ignore
padNumber |> ignore
testBase64DataUrl |> ignore
nativeData |> ignore
computeBindingMapping |> ignore
textureSize |> ignore
bodyRigMapping |> ignore
animationOptimization |> ignore
tensorValue |> ignore
computeShaderOptions |> ignore
imageTrackingOptions |> ignore
flowGraphBlockConfiguration |> ignore
exrHeader |> ignore
gltfLoaderData |> ignore
createDecoderAsync |> ignore
getExrHeader |> ignore
basisFileInfoFactory |> ignore
nativeDataStreamFactory |> ignore
validatedNativeDataStreamFactory |> ignore
fresnelParametersFactory |> ignore
webXRControllerComponentFactory |> ignore
parseUint8 |> ignore
textureSizeIsObject |> ignore
getMimeType |> ignore
mixamoRigMapping |> ignore
stringTools |> ignore
guid |> ignore
bvhLoaderMetadata |> ignore
gltfMagicBase64Encoded |> ignore
registeredGltfExtensions |> ignore
errorCodes |> ignore
wgs84Ellipsoid |> ignore
richTypeColor3 |> ignore
richTypeColor4 |> ignore
staticOffsetColor3 |> ignore
staticOffsetColor4 |> ignore
staticOffsetSize |> ignore
printfn "curated Babylon binding compile smoke passed"
