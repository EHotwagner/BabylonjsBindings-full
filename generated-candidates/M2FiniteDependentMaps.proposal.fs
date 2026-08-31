// REVIEW-ONLY M2 FINITE DEPENDENT MAP PROPOSAL — maintained source requires explicit review

open Fable.Core
open Fable.Core.JsInterop
open BabylonjsBindings.Enums
open BabylonjsBindings.StringEnums
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.SimpleClasses

/// Curated finite projections for the conditional Device, FlowGraph, and WebXR maps.
module FiniteDependentMaps =

    type DeviceTypeGeneric = | Generic = 0
    type DeviceTypeKeyboard = | Keyboard = 1
    type DeviceTypeMouse = | Mouse = 2
    type DeviceTypeTouch = | Touch = 3
    type DeviceTypeDualShock = | DualShock = 4
    type DeviceTypeXbox = | Xbox = 5
    type DeviceTypeSwitch = | Switch = 6
    type DeviceTypeDualSense = | DualSense = 7

    /// Exact PointerInput exclusion of Move and wheel axes used by DeviceInput<Mouse|Touch>.
    type PointerDeviceInput =
        | Horizontal = 0
        | Vertical = 1
        | LeftClick = 2
        | MiddleClick = 3
        | RightClick = 4
        | BrowserBack = 5
        | BrowserForward = 6

    type DeviceInputGeneric = float
    type DeviceInputKeyboard = float
    type DeviceInputMouse = PointerDeviceInput
    type DeviceInputTouch = PointerDeviceInput
    type DeviceInputDualShock = DualShockInput
    type DeviceInputXbox = XboxInput
    type DeviceInputSwitch = SwitchInput
    type DeviceInputDualSense = DualSenseInput
    type DeviceInput = U7<float, PointerDeviceInput, DualShockInput, XboxInput, SwitchInput, DualSenseInput, Never>

    type DeviceSourceEventKeyboard = IKeyboardEvent
    type DeviceSourceEventMouse = U2<IWheelEvent, IPointerEvent>
    type DeviceSourceEventTouch = IPointerEvent
    type DeviceSourceEventGeneric = Never
    type DeviceSourceEventDualShock = Never
    type DeviceSourceEventXbox = Never
    type DeviceSourceEventSwitch = Never
    type DeviceSourceEventDualSense = Never
    type DeviceSourceEvent = U3<IKeyboardEvent, IWheelEvent, IPointerEvent>

    [<AllowNullLiteral>]
    type DeviceSource<'Device, 'Input, 'Event> =
        abstract deviceType: 'Device with get
        abstract deviceSlot: float with get
        abstract onInputChangedObservable: Observable<'Event> with get
        abstract getInput: inputIndex: 'Input -> float

    type GenericDeviceSource = DeviceSource<DeviceTypeGeneric, DeviceInputGeneric, DeviceSourceEventGeneric>
    type KeyboardDeviceSource = DeviceSource<DeviceTypeKeyboard, DeviceInputKeyboard, DeviceSourceEventKeyboard>
    type MouseDeviceSource = DeviceSource<DeviceTypeMouse, DeviceInputMouse, DeviceSourceEventMouse>
    type TouchDeviceSource = DeviceSource<DeviceTypeTouch, DeviceInputTouch, DeviceSourceEventTouch>
    type DualShockDeviceSource = DeviceSource<DeviceTypeDualShock, DeviceInputDualShock, DeviceSourceEventDualShock>
    type XboxDeviceSource = DeviceSource<DeviceTypeXbox, DeviceInputXbox, DeviceSourceEventXbox>
    type SwitchDeviceSource = DeviceSource<DeviceTypeSwitch, DeviceInputSwitch, DeviceSourceEventSwitch>
    type DualSenseDeviceSource = DeviceSource<DeviceTypeDualSense, DeviceInputDualSense, DeviceSourceEventDualSense>
    type DeviceSourceType = U8<GenericDeviceSource, KeyboardDeviceSource, MouseDeviceSource, TouchDeviceSource, DualShockDeviceSource, XboxDeviceSource, SwitchDeviceSource, DualSenseDeviceSource>

    [<AllowNullLiteral>]
    type IObservableManager =
        abstract onDeviceConnectedObservable: Observable<DeviceSourceType> with get
        abstract onDeviceDisconnectedObservable: Observable<DeviceSourceType> with get
        abstract _onInputChanged: deviceType: DeviceType * deviceSlot: float * eventData: IUIEvent -> unit
        abstract _addDevice: deviceSource: DeviceSourceType -> unit
        abstract _removeDevice: deviceType: DeviceType * deviceSlot: float -> unit

    [<AllowNullLiteral>]
    type DeviceSourceManager =
        inherit IObservableManager
        abstract getDeviceSource: deviceType: DeviceTypeGeneric * ?deviceSlot: float -> GenericDeviceSource option
        abstract getDeviceSource: deviceType: DeviceTypeKeyboard * ?deviceSlot: float -> KeyboardDeviceSource option
        abstract getDeviceSource: deviceType: DeviceTypeMouse * ?deviceSlot: float -> MouseDeviceSource option
        abstract getDeviceSource: deviceType: DeviceTypeTouch * ?deviceSlot: float -> TouchDeviceSource option
        abstract getDeviceSource: deviceType: DeviceTypeDualShock * ?deviceSlot: float -> DualShockDeviceSource option
        abstract getDeviceSource: deviceType: DeviceTypeXbox * ?deviceSlot: float -> XboxDeviceSource option
        abstract getDeviceSource: deviceType: DeviceTypeSwitch * ?deviceSlot: float -> SwitchDeviceSource option
        abstract getDeviceSource: deviceType: DeviceTypeDualSense * ?deviceSlot: float -> DualSenseDeviceSource option
        abstract getDeviceSources: deviceType: DeviceTypeGeneric -> System.Collections.Generic.IReadOnlyList<GenericDeviceSource>
        abstract getDeviceSources: deviceType: DeviceTypeKeyboard -> System.Collections.Generic.IReadOnlyList<KeyboardDeviceSource>
        abstract getDeviceSources: deviceType: DeviceTypeMouse -> System.Collections.Generic.IReadOnlyList<MouseDeviceSource>
        abstract getDeviceSources: deviceType: DeviceTypeTouch -> System.Collections.Generic.IReadOnlyList<TouchDeviceSource>
        abstract getDeviceSources: deviceType: DeviceTypeDualShock -> System.Collections.Generic.IReadOnlyList<DualShockDeviceSource>
        abstract getDeviceSources: deviceType: DeviceTypeXbox -> System.Collections.Generic.IReadOnlyList<XboxDeviceSource>
        abstract getDeviceSources: deviceType: DeviceTypeSwitch -> System.Collections.Generic.IReadOnlyList<SwitchDeviceSource>
        abstract getDeviceSources: deviceType: DeviceTypeDualSense -> System.Collections.Generic.IReadOnlyList<DualSenseDeviceSource>
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type DeviceSourceManagerStatic =
        [<EmitConstructor>] abstract Create: engine: AbstractEngine -> DeviceSourceManager

    [<Import("DeviceSourceManager", "@babylonjs/core/DeviceInput/InputDevices/deviceSourceManager.js")>]
    let DeviceSourceManager: DeviceSourceManagerStatic = jsNative

    [<AllowNullLiteral>]
    type InternalDeviceSourceManager =
        abstract _deviceInputSystem: IDeviceInputSystem with get
        abstract _refCount: float with get, set
        abstract registerManager: manager: IObservableManager -> unit
        abstract unregisterManager: manager: IObservableManager -> unit
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type InternalDeviceSourceManagerStatic =
        [<EmitConstructor>] abstract Create: engine: AbstractEngine -> InternalDeviceSourceManager

    [<Import("InternalDeviceSourceManager", "@babylonjs/core/DeviceInput/internalDeviceSourceManager.pure.js")>]
    let InternalDeviceSourceManager: InternalDeviceSourceManagerStatic = jsNative

    [<StringEnum; RequireQualifiedAccess>] type FlowGraphAnimationAsset = | [<CompiledName("Animation")>] Value
    [<StringEnum; RequireQualifiedAccess>] type FlowGraphAnimationGroupAsset = | [<CompiledName("AnimationGroup")>] Value
    [<StringEnum; RequireQualifiedAccess>] type FlowGraphMeshAsset = | [<CompiledName("Mesh")>] Value
    [<StringEnum; RequireQualifiedAccess>] type FlowGraphMaterialAsset = | [<CompiledName("Material")>] Value
    [<StringEnum; RequireQualifiedAccess>] type FlowGraphCameraAsset = | [<CompiledName("Camera")>] Value
    [<StringEnum; RequireQualifiedAccess>] type FlowGraphLightAsset = | [<CompiledName("Light")>] Value

    type AssetTypeAnimation = Animation
    type AssetTypeAnimationGroup = AnimationGroup
    type AssetTypeMesh = Mesh
    type AssetTypeMaterial = Material
    type AssetTypeCamera = Camera
    type AssetTypeLight = Light
    type AssetType = U6<Animation, AnimationGroup, Mesh, Material, Camera, Light>

    [<AllowNullLiteral>]
    type GetFlowGraphAssetWithType =
        [<Emit("$0($1...)")>] abstract Invoke: assetsContext: IAssetContainer * ``type``: FlowGraphAnimationAsset * index: float * ?useIndexAsUniqueId: bool -> Animation option
        [<Emit("$0($1...)")>] abstract Invoke: assetsContext: IAssetContainer * ``type``: FlowGraphAnimationGroupAsset * index: float * ?useIndexAsUniqueId: bool -> AnimationGroup option
        [<Emit("$0($1...)")>] abstract Invoke: assetsContext: IAssetContainer * ``type``: FlowGraphMeshAsset * index: float * ?useIndexAsUniqueId: bool -> Mesh option
        [<Emit("$0($1...)")>] abstract Invoke: assetsContext: IAssetContainer * ``type``: FlowGraphMaterialAsset * index: float * ?useIndexAsUniqueId: bool -> Material option
        [<Emit("$0($1...)")>] abstract Invoke: assetsContext: IAssetContainer * ``type``: FlowGraphCameraAsset * index: float * ?useIndexAsUniqueId: bool -> Camera option
        [<Emit("$0($1...)")>] abstract Invoke: assetsContext: IAssetContainer * ``type``: FlowGraphLightAsset * index: float * ?useIndexAsUniqueId: bool -> Light option

    [<Import("GetFlowGraphAssetWithType", "@babylonjs/core/FlowGraph/flowGraphAssetsContext.js")>]
    let GetFlowGraphAssetWithType: GetFlowGraphAssetWithType = jsNative

    [<AllowNullLiteral>]
    type FlowGraphGetAssetBlock<'Discriminator, 'Asset> =
        abstract config: IFlowGraphGetAssetBlockConfiguration<'Discriminator> with get, set
        abstract value: FlowGraphDataConnection<'Asset option> with get
        abstract ``type``: FlowGraphDataConnection<'Discriminator> with get
        abstract index: FlowGraphDataConnection<TypeAliases.FlowGraphNumber> with get
        abstract _updateOutputs: context: FlowGraphContext -> unit
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type IFlowGraphGetPropertyBlockConfiguration<'Asset> =
        inherit IFlowGraphBlockConfiguration
        abstract propertyName: string option with get, set
        abstract ``object``: 'Asset option with get, set
        abstract resetToDefaultWhenUndefined: bool option with get, set

    [<AllowNullLiteral>]
    type FlowGraphGetPropertyBlock<'Property, 'Asset> =
        abstract config: IFlowGraphGetPropertyBlockConfiguration<'Asset> with get, set
        abstract ``object``: FlowGraphDataConnection<'Asset> with get
        abstract propertyName: FlowGraphDataConnection<string> with get
        abstract customGetFunction: FlowGraphDataConnection<System.Func<'Asset, string, FlowGraphContext, 'Property option>> with get
        abstract _doOperation: context: FlowGraphContext -> 'Property option
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type IFlowGraphSetPropertyBlockConfiguration<'Asset> =
        abstract propertyName: string option with get, set
        abstract target: 'Asset option with get, set

    [<AllowNullLiteral>]
    type FlowGraphSetPropertyBlock<'Property, 'Asset> =
        abstract config: IFlowGraphSetPropertyBlockConfiguration<'Asset> with get, set
        abstract value: FlowGraphDataConnection<'Property> with get
        abstract ``object``: FlowGraphDataConnection<'Asset> with get
        abstract propertyName: FlowGraphDataConnection<string> with get
        abstract customSetFunction: FlowGraphDataConnection<System.Action<'Asset, string, 'Property, FlowGraphContext>> with get
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type FlowGraphJsonPointerParserBlock<'Property, 'Asset> =
        abstract config: IFlowGraphJsonPointerParserBlockConfiguration with get, set
        abstract ``object``: FlowGraphDataConnection<'Asset> with get
        abstract propertyName: FlowGraphDataConnection<string> with get
        abstract setterFunction: FlowGraphDataConnection<System.Action<'Asset, string, 'Property, FlowGraphContext>> with get
        abstract getterFunction: FlowGraphDataConnection<System.Func<'Asset, string, FlowGraphContext, 'Property option>> with get
        abstract _doOperation: context: FlowGraphContext -> 'Property
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type FlowGraphSwitchBlock<'Number> =
        abstract config: IFlowGraphSwitchBlockConfiguration<'Number> with get, set
        abstract ``case``: FlowGraphDataConnection<'Number> with get
        abstract ``default``: FlowGraphSignalConnection with get
        abstract addCase: newCase: 'Number -> unit
        abstract removeCase: caseToRemove: 'Number -> unit
        abstract _getOutputFlowForCase: caseValue: 'Number -> FlowGraphSignalConnection option
        abstract getClassName: unit -> string

    type FlowGraphNumberSwitchBlock = FlowGraphSwitchBlock<float>
    type FlowGraphIntegerSwitchBlock = FlowGraphSwitchBlock<FlowGraphInteger>

    [<StringEnum; RequireQualifiedAccess>] type XRAnchorSystem = | [<CompiledName("xr-anchor-system")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRBackgroundRemover = | [<CompiledName("xr-background-remover")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRHitTest = | [<CompiledName("xr-hit-test")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRMeshDetection = | [<CompiledName("xr-mesh-detection")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRPhysicsController = | [<CompiledName("xr-physics-controller")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRPlaneDetection = | [<CompiledName("xr-plane-detection")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRPointerSelection = | [<CompiledName("xr-controller-pointer-selection")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRTeleportation = | [<CompiledName("xr-controller-teleportation")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRFeaturePoints = | [<CompiledName("xr-feature-points")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRHandTracking = | [<CompiledName("xr-hand-tracking")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRImageTracking = | [<CompiledName("xr-image-tracking")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRNearInteraction = | [<CompiledName("xr-near-interaction")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRDomOverlay = | [<CompiledName("xr-dom-overlay")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRMovement = | [<CompiledName("xr-controller-movement")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRLightEstimation = | [<CompiledName("xr-light-estimation")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XREyeTracking = | [<CompiledName("xr-eye-tracking")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRWalkingLocomotion = | [<CompiledName("xr-walking-locomotion")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRLayers = | [<CompiledName("xr-layers")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRDepthSensing = | [<CompiledName("xr-depth-sensing")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRSpaceWarp = | [<CompiledName("xr-space-warp")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRRawCameraAccess = | [<CompiledName("xr-raw-camera-access")>] Value
    [<StringEnum; RequireQualifiedAccess>] type XRBodyTracking = | [<CompiledName("xr-body-tracking")>] Value

    type WebXRFeatureNameType = U8<XRAnchorSystem, XRBackgroundRemover, XRHitTest, XRMeshDetection, XRPhysicsController, XRPlaneDetection, XRPointerSelection, U8<XRTeleportation, XRFeaturePoints, XRHandTracking, XRImageTracking, XRNearInteraction, XRDomOverlay, XRMovement, U8<XRLightEstimation, XREyeTracking, XRWalkingLocomotion, XRLayers, XRDepthSensing, XRSpaceWarp, XRRawCameraAccess, XRBodyTracking>>>

    [<AllowNullLiteral>]
    type IWebXRFeatureNameTypeMap =
        [<Emit("$0['xr-anchor-system']")>] abstract AnchorSystem: WebXRAnchorSystem with get
        [<Emit("$0['xr-background-remover']")>] abstract BackgroundRemover: WebXRBackgroundRemover with get
        [<Emit("$0['xr-hit-test']")>] abstract HitTest: WebXRHitTest with get
        [<Emit("$0['xr-mesh-detection']")>] abstract MeshDetection: WebXRMeshDetector with get
        [<Emit("$0['xr-physics-controller']")>] abstract PhysicsController: WebXRControllerPhysics with get
        [<Emit("$0['xr-plane-detection']")>] abstract PlaneDetection: WebXRPlaneDetector with get
        [<Emit("$0['xr-controller-pointer-selection']")>] abstract PointerSelection: WebXRControllerPointerSelection with get
        [<Emit("$0['xr-controller-teleportation']")>] abstract Teleportation: WebXRMotionControllerTeleportation with get
        [<Emit("$0['xr-feature-points']")>] abstract FeaturePoints: WebXRFeaturePointSystem with get
        [<Emit("$0['xr-hand-tracking']")>] abstract HandTracking: WebXRHandTracking with get
        [<Emit("$0['xr-image-tracking']")>] abstract ImageTracking: WebXRImageTracking with get
        [<Emit("$0['xr-near-interaction']")>] abstract NearInteraction: WebXRNearInteraction with get
        [<Emit("$0['xr-dom-overlay']")>] abstract DomOverlay: WebXRDomOverlay with get
        [<Emit("$0['xr-controller-movement']")>] abstract Movement: WebXRControllerMovement with get
        [<Emit("$0['xr-light-estimation']")>] abstract LightEstimation: WebXRLightEstimation with get
        [<Emit("$0['xr-eye-tracking']")>] abstract EyeTracking: WebXREyeTracking with get
        [<Emit("$0['xr-walking-locomotion']")>] abstract WalkingLocomotion: WebXRWalkingLocomotion with get
        [<Emit("$0['xr-layers']")>] abstract Layers: WebXRLayers with get
        [<Emit("$0['xr-depth-sensing']")>] abstract DepthSensing: WebXRDepthSensing with get
        [<Emit("$0['xr-space-warp']")>] abstract SpaceWarp: WebXRSpaceWarp with get
        [<Emit("$0['xr-raw-camera-access']")>] abstract RawCameraAccess: WebXRRawCameraAccess with get
        [<Emit("$0['xr-body-tracking']")>] abstract BodyTracking: WebXRBodyTracking with get

    [<AllowNullLiteral>]
    type IWebXRFeatureNameOptionsMap =
        [<Emit("$0['xr-anchor-system']")>] abstract AnchorSystem: IWebXRAnchorSystemOptions with get
        [<Emit("$0['xr-background-remover']")>] abstract BackgroundRemover: IWebXRBackgroundRemoverOptions with get
        [<Emit("$0['xr-hit-test']")>] abstract HitTest: IWebXRHitTestOptions with get
        [<Emit("$0['xr-mesh-detection']")>] abstract MeshDetection: IWebXRMeshDetectorOptions with get
        [<Emit("$0['xr-physics-controller']")>] abstract PhysicsController: IWebXRControllerPhysicsOptions with get
        [<Emit("$0['xr-plane-detection']")>] abstract PlaneDetection: IWebXRPlaneDetectorOptions with get
        [<Emit("$0['xr-controller-pointer-selection']")>] abstract PointerSelection: IWebXRControllerPointerSelectionOptions with get
        [<Emit("$0['xr-controller-teleportation']")>] abstract Teleportation: IWebXRTeleportationOptions with get
        [<Emit("$0['xr-feature-points']")>] abstract FeaturePoints: unit with get
        [<Emit("$0['xr-hand-tracking']")>] abstract HandTracking: IWebXRHandTrackingOptions with get
        [<Emit("$0['xr-image-tracking']")>] abstract ImageTracking: IWebXRImageTrackingOptions with get
        [<Emit("$0['xr-near-interaction']")>] abstract NearInteraction: IWebXRNearInteractionOptions with get
        [<Emit("$0['xr-dom-overlay']")>] abstract DomOverlay: IWebXRDomOverlayOptions with get
        [<Emit("$0['xr-controller-movement']")>] abstract Movement: IWebXRControllerMovementOptions with get
        [<Emit("$0['xr-light-estimation']")>] abstract LightEstimation: IWebXRLightEstimationOptions with get
        [<Emit("$0['xr-eye-tracking']")>] abstract EyeTracking: unit with get
        [<Emit("$0['xr-walking-locomotion']")>] abstract WalkingLocomotion: IWebXRWalkingLocomotionOptions with get
        [<Emit("$0['xr-layers']")>] abstract Layers: IWebXRLayersOptions with get
        [<Emit("$0['xr-depth-sensing']")>] abstract DepthSensing: IWebXRDepthSensingOptions with get
        [<Emit("$0['xr-space-warp']")>] abstract SpaceWarp: unit with get
        [<Emit("$0['xr-raw-camera-access']")>] abstract RawCameraAccess: IWebXRRawCameraAccessOptions with get
        [<Emit("$0['xr-body-tracking']")>] abstract BodyTracking: IWebXRBodyTrackingOptions with get

    type ResolveWebXRFeature<'Feature> = 'Feature
    type ResolveWebXRFeatureOptions<'Options> = 'Options

    [<AllowNullLiteral>]
    type WebXRFeaturesManager =
        abstract enableFeature: featureName: XRAnchorSystem * ?version: U2<float, string> * ?moduleOptions: IWebXRAnchorSystemOptions * ?attachIfPossible: bool * ?required: bool -> WebXRAnchorSystem
        abstract enableFeature: featureName: XRBackgroundRemover * ?version: U2<float, string> * ?moduleOptions: IWebXRBackgroundRemoverOptions * ?attachIfPossible: bool * ?required: bool -> WebXRBackgroundRemover
        abstract enableFeature: featureName: XRHitTest * ?version: U2<float, string> * ?moduleOptions: IWebXRHitTestOptions * ?attachIfPossible: bool * ?required: bool -> WebXRHitTest
        abstract enableFeature: featureName: XRMeshDetection * ?version: U2<float, string> * ?moduleOptions: IWebXRMeshDetectorOptions * ?attachIfPossible: bool * ?required: bool -> WebXRMeshDetector
        abstract enableFeature: featureName: XRPhysicsController * ?version: U2<float, string> * ?moduleOptions: IWebXRControllerPhysicsOptions * ?attachIfPossible: bool * ?required: bool -> WebXRControllerPhysics
        abstract enableFeature: featureName: XRPlaneDetection * ?version: U2<float, string> * ?moduleOptions: IWebXRPlaneDetectorOptions * ?attachIfPossible: bool * ?required: bool -> WebXRPlaneDetector
        abstract enableFeature: featureName: XRPointerSelection * ?version: U2<float, string> * ?moduleOptions: IWebXRControllerPointerSelectionOptions * ?attachIfPossible: bool * ?required: bool -> WebXRControllerPointerSelection
        abstract enableFeature: featureName: XRTeleportation * ?version: U2<float, string> * ?moduleOptions: IWebXRTeleportationOptions * ?attachIfPossible: bool * ?required: bool -> WebXRMotionControllerTeleportation
        abstract enableFeature: featureName: XRFeaturePoints * ?version: U2<float, string> * ?moduleOptions: unit * ?attachIfPossible: bool * ?required: bool -> WebXRFeaturePointSystem
        abstract enableFeature: featureName: XRHandTracking * ?version: U2<float, string> * ?moduleOptions: IWebXRHandTrackingOptions * ?attachIfPossible: bool * ?required: bool -> WebXRHandTracking
        abstract enableFeature: featureName: XRImageTracking * ?version: U2<float, string> * ?moduleOptions: IWebXRImageTrackingOptions * ?attachIfPossible: bool * ?required: bool -> WebXRImageTracking
        abstract enableFeature: featureName: XRNearInteraction * ?version: U2<float, string> * ?moduleOptions: IWebXRNearInteractionOptions * ?attachIfPossible: bool * ?required: bool -> WebXRNearInteraction
        abstract enableFeature: featureName: XRDomOverlay * ?version: U2<float, string> * ?moduleOptions: IWebXRDomOverlayOptions * ?attachIfPossible: bool * ?required: bool -> WebXRDomOverlay
        abstract enableFeature: featureName: XRMovement * ?version: U2<float, string> * ?moduleOptions: IWebXRControllerMovementOptions * ?attachIfPossible: bool * ?required: bool -> WebXRControllerMovement
        abstract enableFeature: featureName: XRLightEstimation * ?version: U2<float, string> * ?moduleOptions: IWebXRLightEstimationOptions * ?attachIfPossible: bool * ?required: bool -> WebXRLightEstimation
        abstract enableFeature: featureName: XREyeTracking * ?version: U2<float, string> * ?moduleOptions: unit * ?attachIfPossible: bool * ?required: bool -> WebXREyeTracking
        abstract enableFeature: featureName: XRWalkingLocomotion * ?version: U2<float, string> * ?moduleOptions: IWebXRWalkingLocomotionOptions * ?attachIfPossible: bool * ?required: bool -> WebXRWalkingLocomotion
        abstract enableFeature: featureName: XRLayers * ?version: U2<float, string> * ?moduleOptions: IWebXRLayersOptions * ?attachIfPossible: bool * ?required: bool -> WebXRLayers
        abstract enableFeature: featureName: XRDepthSensing * ?version: U2<float, string> * ?moduleOptions: IWebXRDepthSensingOptions * ?attachIfPossible: bool * ?required: bool -> WebXRDepthSensing
        abstract enableFeature: featureName: XRSpaceWarp * ?version: U2<float, string> * ?moduleOptions: unit * ?attachIfPossible: bool * ?required: bool -> WebXRSpaceWarp
        abstract enableFeature: featureName: XRRawCameraAccess * ?version: U2<float, string> * ?moduleOptions: IWebXRRawCameraAccessOptions * ?attachIfPossible: bool * ?required: bool -> WebXRRawCameraAccess
        abstract enableFeature: featureName: XRBodyTracking * ?version: U2<float, string> * ?moduleOptions: IWebXRBodyTrackingOptions * ?attachIfPossible: bool * ?required: bool -> WebXRBodyTracking
        abstract getEnabledFeature: featureName: XRAnchorSystem -> WebXRAnchorSystem
        abstract getEnabledFeature: featureName: XRBackgroundRemover -> WebXRBackgroundRemover
        abstract getEnabledFeature: featureName: XRHitTest -> WebXRHitTest
        abstract getEnabledFeature: featureName: XRMeshDetection -> WebXRMeshDetector
        abstract getEnabledFeature: featureName: XRPhysicsController -> WebXRControllerPhysics
        abstract getEnabledFeature: featureName: XRPlaneDetection -> WebXRPlaneDetector
        abstract getEnabledFeature: featureName: XRPointerSelection -> WebXRControllerPointerSelection
        abstract getEnabledFeature: featureName: XRTeleportation -> WebXRMotionControllerTeleportation
        abstract getEnabledFeature: featureName: XRFeaturePoints -> WebXRFeaturePointSystem
        abstract getEnabledFeature: featureName: XRHandTracking -> WebXRHandTracking
        abstract getEnabledFeature: featureName: XRImageTracking -> WebXRImageTracking
        abstract getEnabledFeature: featureName: XRNearInteraction -> WebXRNearInteraction
        abstract getEnabledFeature: featureName: XRDomOverlay -> WebXRDomOverlay
        abstract getEnabledFeature: featureName: XRMovement -> WebXRControllerMovement
        abstract getEnabledFeature: featureName: XRLightEstimation -> WebXRLightEstimation
        abstract getEnabledFeature: featureName: XREyeTracking -> WebXREyeTracking
        abstract getEnabledFeature: featureName: XRWalkingLocomotion -> WebXRWalkingLocomotion
        abstract getEnabledFeature: featureName: XRLayers -> WebXRLayers
        abstract getEnabledFeature: featureName: XRDepthSensing -> WebXRDepthSensing
        abstract getEnabledFeature: featureName: XRSpaceWarp -> WebXRSpaceWarp
        abstract getEnabledFeature: featureName: XRRawCameraAccess -> WebXRRawCameraAccess
        abstract getEnabledFeature: featureName: XRBodyTracking -> WebXRBodyTracking
        abstract attachFeature: featureName: string -> unit
        abstract detachFeature: featureName: string -> unit
        abstract disableFeature: featureName: U2<string, {| Name: string |}> -> bool
        abstract getEnabledFeatures: unit -> ResizeArray<string>
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type WebXRFeaturesManagerStatic =
        [<EmitConstructor>] abstract Create: xrSessionManager: WebXRSessionManager -> WebXRFeaturesManager
        abstract GetAvailableFeatures: unit -> ResizeArray<string>
        abstract GetAvailableVersions: featureName: string -> ResizeArray<string>
        abstract GetLatestVersionOfFeature: featureName: string -> float
        abstract GetStableVersionOfFeature: featureName: string -> float

    [<Import("WebXRFeaturesManager", "@babylonjs/core/XR/webXRFeaturesManager.js")>]
    let WebXRFeaturesManager: WebXRFeaturesManagerStatic = jsNative

    [<AllowNullLiteral>]
    type WebXRExperienceHelper =
        abstract camera: WebXRCamera with get, set
        abstract featuresManager: WebXRFeaturesManager with get, set
        abstract sessionManager: WebXRSessionManager with get, set
        abstract state: WebXRState with get, set
        abstract onInitialXRPoseSetObservable: Observable<WebXRCamera> with get, set
        abstract onStateChangedObservable: Observable<WebXRState> with get, set
        abstract exitXRAsync: unit -> JS.Promise<unit>
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type WebXRExperienceHelperStatic =
        abstract CreateAsync: scene: Scene -> JS.Promise<WebXRExperienceHelper>

    [<Import("WebXRExperienceHelper", "@babylonjs/core/XR/webXRExperienceHelper.js")>]
    let WebXRExperienceHelper: WebXRExperienceHelperStatic = jsNative

    [<AllowNullLiteral>]
    type WebXREnterExitUI =
        abstract options: WebXREnterExitUIOptions with get, set
        abstract activeButtonChangedObservable: Observable<WebXREnterExitUIButton option> with get, set
        abstract setHelperAsync: helper: WebXRExperienceHelper * ?renderTarget: WebXRRenderTarget<Browser.Types.WebGLRenderingContext, BrowserXRLayer> -> JS.Promise<unit>
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type WebXREnterExitUIStatic =
        [<EmitConstructor>] abstract Create: scene: Scene * options: WebXREnterExitUIOptions -> WebXREnterExitUI
        abstract CreateAsync: scene: Scene * helper: WebXRExperienceHelper * options: WebXREnterExitUIOptions -> JS.Promise<WebXREnterExitUI>

    [<Import("WebXREnterExitUI", "@babylonjs/core/XR/webXREnterExitUI.js")>]
    let WebXREnterExitUI: WebXREnterExitUIStatic = jsNative

    [<AllowNullLiteral>]
    type WebXRDefaultExperience =
        abstract baseExperience: WebXRExperienceHelper with get, set
        abstract enterExitUI: WebXREnterExitUI with get, set
        abstract input: WebXRInput with get, set
        abstract pointerSelection: WebXRControllerPointerSelection with get, set
        abstract teleportation: WebXRMotionControllerTeleportation with get, set
        abstract nearInteraction: WebXRNearInteraction with get, set
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type WebXRDefaultExperienceStatic =
        abstract CreateAsync: scene: Scene * ?options: WebXRDefaultExperienceOptions -> JS.Promise<WebXRDefaultExperience>

    [<Import("WebXRDefaultExperience", "@babylonjs/core/XR/webXRDefaultExperience.js")>]
    let WebXRDefaultExperience: WebXRDefaultExperienceStatic = jsNative

    [<AllowNullLiteral>]
    type VRExperienceHelper =
        abstract webVROptions: VRExperienceHelperOptions with get, set
        abstract onEnteringVRObservable: Observable<VRExperienceHelper> with get, set
        abstract onExitingVRObservable: Observable<VRExperienceHelper> with get, set
        abstract xr: WebXRDefaultExperience with get, set
        abstract xrTestDone: bool with get, set
        abstract isInVRMode: bool with get
        abstract enterVR: unit -> unit
        abstract exitVR: unit -> unit
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type VRExperienceHelperStatic =
        [<EmitConstructor>] abstract Create: scene: Scene * ?options: VRExperienceHelperOptions -> VRExperienceHelper
        abstract TELEPORTATIONMODE_CONSTANTTIME: float with get
        abstract TELEPORTATIONMODE_CONSTANTSPEED: float with get

    [<Import("VRExperienceHelper", "@babylonjs/core/Cameras/VR/vrExperienceHelper.pure.js")>]
    let VRExperienceHelper: VRExperienceHelperStatic = jsNative

    [<AllowNullLiteral>]
    type HandConstraintBehavior =
        abstract handConstraintVisibility: HandConstraintVisibility with get, set
        abstract palmUpStrictness: float with get, set
        abstract gazeProximityRadius: float with get, set
        abstract targetOffset: float with get, set
        abstract targetZone: HandConstraintZone with get, set
        abstract zoneOrientationMode: HandConstraintOrientation with get, set
        abstract nodeOrientationMode: HandConstraintOrientation with get, set
        abstract attachedNode: TransformNode option with get
        abstract attach: node: TransformNode -> unit
        abstract detach: unit -> unit
        abstract linkToXRExperience: xr: U2<WebXRExperienceHelper, WebXRFeaturesManager> -> unit

    [<AllowNullLiteral>]
    type HandConstraintBehaviorStatic =
        [<EmitConstructor>] abstract Create: unit -> HandConstraintBehavior

    [<Import("HandConstraintBehavior", "@babylonjs/core/Behaviors/Meshes/handConstraintBehavior.js")>]
    let HandConstraintBehavior: HandConstraintBehaviorStatic = jsNative
