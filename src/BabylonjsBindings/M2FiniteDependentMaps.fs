namespace BabylonjsBindings

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
    type DeviceSourceStatic =
        [<EmitConstructor>] abstract Create: deviceInputSystem: IDeviceInputSystem * deviceType: DeviceTypeGeneric * ?deviceSlot: float -> GenericDeviceSource
        [<EmitConstructor>] abstract Create: deviceInputSystem: IDeviceInputSystem * deviceType: DeviceTypeKeyboard * ?deviceSlot: float -> KeyboardDeviceSource
        [<EmitConstructor>] abstract Create: deviceInputSystem: IDeviceInputSystem * deviceType: DeviceTypeMouse * ?deviceSlot: float -> MouseDeviceSource
        [<EmitConstructor>] abstract Create: deviceInputSystem: IDeviceInputSystem * deviceType: DeviceTypeTouch * ?deviceSlot: float -> TouchDeviceSource
        [<EmitConstructor>] abstract Create: deviceInputSystem: IDeviceInputSystem * deviceType: DeviceTypeDualShock * ?deviceSlot: float -> DualShockDeviceSource
        [<EmitConstructor>] abstract Create: deviceInputSystem: IDeviceInputSystem * deviceType: DeviceTypeXbox * ?deviceSlot: float -> XboxDeviceSource
        [<EmitConstructor>] abstract Create: deviceInputSystem: IDeviceInputSystem * deviceType: DeviceTypeSwitch * ?deviceSlot: float -> SwitchDeviceSource
        [<EmitConstructor>] abstract Create: deviceInputSystem: IDeviceInputSystem * deviceType: DeviceTypeDualSense * ?deviceSlot: float -> DualSenseDeviceSource

    [<Import("DeviceSource", "@babylonjs/core/DeviceInput/InputDevices/deviceSource.js")>]
    let DeviceSource: DeviceSourceStatic = jsNative

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
        inherit FlowGraphBlock
        abstract config: IFlowGraphGetAssetBlockConfiguration<'Discriminator> with get, set
        abstract value: FlowGraphDataConnection<'Asset option> with get
        abstract ``type``: FlowGraphDataConnection<'Discriminator> with get
        abstract index: FlowGraphDataConnection<TypeAliases.FlowGraphNumber> with get
        abstract _updateOutputs: context: FlowGraphContext -> unit
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type FlowGraphGetAssetBlockStatic =
        [<EmitConstructor>] abstract Create: config: IFlowGraphGetAssetBlockConfiguration<FlowGraphAnimationAsset> -> FlowGraphGetAssetBlock<FlowGraphAnimationAsset, Animation>
        [<EmitConstructor>] abstract Create: config: IFlowGraphGetAssetBlockConfiguration<FlowGraphAnimationGroupAsset> -> FlowGraphGetAssetBlock<FlowGraphAnimationGroupAsset, AnimationGroup>
        [<EmitConstructor>] abstract Create: config: IFlowGraphGetAssetBlockConfiguration<FlowGraphMeshAsset> -> FlowGraphGetAssetBlock<FlowGraphMeshAsset, Mesh>
        [<EmitConstructor>] abstract Create: config: IFlowGraphGetAssetBlockConfiguration<FlowGraphMaterialAsset> -> FlowGraphGetAssetBlock<FlowGraphMaterialAsset, Material>
        [<EmitConstructor>] abstract Create: config: IFlowGraphGetAssetBlockConfiguration<FlowGraphCameraAsset> -> FlowGraphGetAssetBlock<FlowGraphCameraAsset, Camera>
        [<EmitConstructor>] abstract Create: config: IFlowGraphGetAssetBlockConfiguration<FlowGraphLightAsset> -> FlowGraphGetAssetBlock<FlowGraphLightAsset, Light>

    [<Import("FlowGraphGetAssetBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetAssetBlock.pure.js")>]
    let FlowGraphGetAssetBlock: FlowGraphGetAssetBlockStatic = jsNative

    [<AllowNullLiteral>]
    type IFlowGraphGetPropertyBlockConfiguration<'Discriminator, 'Asset> =
        inherit IFlowGraphBlockConfiguration
        abstract propertyName: string option with get, set
        abstract ``object``: 'Asset option with get, set
        abstract resetToDefaultWhenUndefined: bool option with get, set

    [<AllowNullLiteral>]
    type FlowGraphGetPropertyBlock<'Property, 'Discriminator, 'Asset> =
        inherit FlowGraphCachedOperationBlock<'Property>
        abstract config: IFlowGraphGetPropertyBlockConfiguration<'Discriminator, 'Asset> with get, set
        abstract ``object``: FlowGraphDataConnection<'Asset> with get
        abstract propertyName: FlowGraphDataConnection<string> with get
        abstract customGetFunction: FlowGraphDataConnection<System.Func<'Asset, string, FlowGraphContext, 'Property option>> with get
        abstract _doOperation: context: FlowGraphContext -> 'Property option
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type FlowGraphGetPropertyBlockStatic =
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphGetPropertyBlockConfiguration<FlowGraphAnimationAsset, Animation> -> FlowGraphGetPropertyBlock<'Property, FlowGraphAnimationAsset, Animation>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphGetPropertyBlockConfiguration<FlowGraphAnimationGroupAsset, AnimationGroup> -> FlowGraphGetPropertyBlock<'Property, FlowGraphAnimationGroupAsset, AnimationGroup>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphGetPropertyBlockConfiguration<FlowGraphMeshAsset, Mesh> -> FlowGraphGetPropertyBlock<'Property, FlowGraphMeshAsset, Mesh>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphGetPropertyBlockConfiguration<FlowGraphMaterialAsset, Material> -> FlowGraphGetPropertyBlock<'Property, FlowGraphMaterialAsset, Material>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphGetPropertyBlockConfiguration<FlowGraphCameraAsset, Camera> -> FlowGraphGetPropertyBlock<'Property, FlowGraphCameraAsset, Camera>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphGetPropertyBlockConfiguration<FlowGraphLightAsset, Light> -> FlowGraphGetPropertyBlock<'Property, FlowGraphLightAsset, Light>

    [<Import("FlowGraphGetPropertyBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetPropertyBlock.pure.js")>]
    let FlowGraphGetPropertyBlock: FlowGraphGetPropertyBlockStatic = jsNative

    [<AllowNullLiteral>]
    type IFlowGraphSetPropertyBlockConfiguration<'Discriminator, 'Asset> =
        abstract propertyName: string option with get, set
        abstract target: 'Asset option with get, set

    [<AllowNullLiteral>]
    type FlowGraphSetPropertyBlock<'Property, 'Discriminator, 'Asset> =
        inherit FlowGraphExecutionBlockWithOutSignal
        abstract config: IFlowGraphSetPropertyBlockConfiguration<'Discriminator, 'Asset> with get, set
        abstract value: FlowGraphDataConnection<'Property> with get
        abstract ``object``: FlowGraphDataConnection<'Asset> with get
        abstract propertyName: FlowGraphDataConnection<string> with get
        abstract customSetFunction: FlowGraphDataConnection<System.Action<'Asset, string, 'Property, FlowGraphContext>> with get
        abstract _execute: context: FlowGraphContext * callingSignal: FlowGraphSignalConnection -> unit
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type FlowGraphSetPropertyBlockStatic =
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphSetPropertyBlockConfiguration<FlowGraphAnimationAsset, Animation> -> FlowGraphSetPropertyBlock<'Property, FlowGraphAnimationAsset, Animation>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphSetPropertyBlockConfiguration<FlowGraphAnimationGroupAsset, AnimationGroup> -> FlowGraphSetPropertyBlock<'Property, FlowGraphAnimationGroupAsset, AnimationGroup>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphSetPropertyBlockConfiguration<FlowGraphMeshAsset, Mesh> -> FlowGraphSetPropertyBlock<'Property, FlowGraphMeshAsset, Mesh>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphSetPropertyBlockConfiguration<FlowGraphMaterialAsset, Material> -> FlowGraphSetPropertyBlock<'Property, FlowGraphMaterialAsset, Material>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphSetPropertyBlockConfiguration<FlowGraphCameraAsset, Camera> -> FlowGraphSetPropertyBlock<'Property, FlowGraphCameraAsset, Camera>
        [<EmitConstructor>] abstract Create<'Property>: config: IFlowGraphSetPropertyBlockConfiguration<FlowGraphLightAsset, Light> -> FlowGraphSetPropertyBlock<'Property, FlowGraphLightAsset, Light>

    [<Import("FlowGraphSetPropertyBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetPropertyBlock.pure.js")>]
    let FlowGraphSetPropertyBlock: FlowGraphSetPropertyBlockStatic = jsNative

    [<AllowNullLiteral>]
    type FlowGraphJsonPointerParserBlock<'Property, 'Asset> =
        inherit FlowGraphCachedOperationBlock<'Property>
        abstract config: IFlowGraphJsonPointerParserBlockConfiguration with get, set
        abstract ``object``: FlowGraphDataConnection<'Asset> with get
        abstract propertyName: FlowGraphDataConnection<string> with get
        abstract setterFunction: FlowGraphDataConnection<System.Action<'Asset, string, 'Property, FlowGraphContext>> with get
        abstract getterFunction: FlowGraphDataConnection<System.Func<'Asset, string, FlowGraphContext, 'Property option>> with get
        abstract generateAnimationsFunction: FlowGraphDataConnection<System.Func<System.Func<ResizeArray<obj>, float, EasingFunction option, ResizeArray<Animation>>>> with get
        abstract templateComponent: FlowGraphPathConverterComponent with get
        abstract _doOperation: context: FlowGraphContext -> 'Property
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type FlowGraphJsonPointerParserBlockStatic =
        [<EmitConstructor>] abstract Create<'Property, 'Asset>: config: IFlowGraphJsonPointerParserBlockConfiguration -> FlowGraphJsonPointerParserBlock<'Property, 'Asset>

    [<Import("FlowGraphJsonPointerParserBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphJsonPointerParserBlock.pure.js")>]
    let FlowGraphJsonPointerParserBlock: FlowGraphJsonPointerParserBlockStatic = jsNative

    [<AllowNullLiteral>]
    type FlowGraphSwitchBlock<'Number> =
        inherit FlowGraphExecutionBlock
        abstract config: IFlowGraphSwitchBlockConfiguration<'Number> with get, set
        abstract ``case``: FlowGraphDataConnection<'Number> with get
        abstract ``default``: FlowGraphSignalConnection with get
        abstract _execute: context: FlowGraphContext * callingSignal: FlowGraphSignalConnection -> unit
        abstract addCase: newCase: 'Number -> unit
        abstract removeCase: caseToRemove: 'Number -> unit
        abstract _getOutputFlowForCase: caseValue: 'Number -> FlowGraphSignalConnection option
        abstract getClassName: unit -> string
        abstract serialize: ?serializationObject: obj -> unit

    type FlowGraphNumberSwitchBlock = FlowGraphSwitchBlock<float>
    type FlowGraphIntegerSwitchBlock = FlowGraphSwitchBlock<FlowGraphInteger>

    [<AllowNullLiteral>]
    type FlowGraphSwitchBlockStatic =
        [<EmitConstructor>] abstract Create: config: IFlowGraphSwitchBlockConfiguration<float> -> FlowGraphNumberSwitchBlock
        [<EmitConstructor>] abstract Create: config: IFlowGraphSwitchBlockConfiguration<FlowGraphInteger> -> FlowGraphIntegerSwitchBlock

    [<Import("FlowGraphSwitchBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSwitchBlock.pure.js")>]
    let FlowGraphSwitchBlock: FlowGraphSwitchBlockStatic = jsNative

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

    /// Compile-time finite resolver view of the locked feature-name result map.
    [<AllowNullLiteral>]
    type ResolveWebXRFeature =
        abstract Resolve: XRAnchorSystem -> WebXRAnchorSystem
        abstract Resolve: XRBackgroundRemover -> WebXRBackgroundRemover
        abstract Resolve: XRHitTest -> WebXRHitTest
        abstract Resolve: XRMeshDetection -> WebXRMeshDetector
        abstract Resolve: XRPhysicsController -> WebXRControllerPhysics
        abstract Resolve: XRPlaneDetection -> WebXRPlaneDetector
        abstract Resolve: XRPointerSelection -> WebXRControllerPointerSelection
        abstract Resolve: XRTeleportation -> WebXRMotionControllerTeleportation
        abstract Resolve: XRFeaturePoints -> WebXRFeaturePointSystem
        abstract Resolve: XRHandTracking -> WebXRHandTracking
        abstract Resolve: XRImageTracking -> WebXRImageTracking
        abstract Resolve: XRNearInteraction -> WebXRNearInteraction
        abstract Resolve: XRDomOverlay -> WebXRDomOverlay
        abstract Resolve: XRMovement -> WebXRControllerMovement
        abstract Resolve: XRLightEstimation -> WebXRLightEstimation
        abstract Resolve: XREyeTracking -> WebXREyeTracking
        abstract Resolve: XRWalkingLocomotion -> WebXRWalkingLocomotion
        abstract Resolve: XRLayers -> WebXRLayers
        abstract Resolve: XRDepthSensing -> WebXRDepthSensing
        abstract Resolve: XRSpaceWarp -> WebXRSpaceWarp
        abstract Resolve: XRRawCameraAccess -> WebXRRawCameraAccess
        abstract Resolve: XRBodyTracking -> WebXRBodyTracking

    /// Compile-time finite resolver view of the locked feature-name options map.
    [<AllowNullLiteral>]
    type ResolveWebXRFeatureOptions =
        abstract Resolve: XRAnchorSystem -> IWebXRAnchorSystemOptions
        abstract Resolve: XRBackgroundRemover -> IWebXRBackgroundRemoverOptions
        abstract Resolve: XRHitTest -> IWebXRHitTestOptions
        abstract Resolve: XRMeshDetection -> IWebXRMeshDetectorOptions
        abstract Resolve: XRPhysicsController -> IWebXRControllerPhysicsOptions
        abstract Resolve: XRPlaneDetection -> IWebXRPlaneDetectorOptions
        abstract Resolve: XRPointerSelection -> IWebXRControllerPointerSelectionOptions
        abstract Resolve: XRTeleportation -> IWebXRTeleportationOptions
        abstract Resolve: XRFeaturePoints -> unit
        abstract Resolve: XRHandTracking -> IWebXRHandTrackingOptions
        abstract Resolve: XRImageTracking -> IWebXRImageTrackingOptions
        abstract Resolve: XRNearInteraction -> IWebXRNearInteractionOptions
        abstract Resolve: XRDomOverlay -> IWebXRDomOverlayOptions
        abstract Resolve: XRMovement -> IWebXRControllerMovementOptions
        abstract Resolve: XRLightEstimation -> IWebXRLightEstimationOptions
        abstract Resolve: XREyeTracking -> unit
        abstract Resolve: XRWalkingLocomotion -> IWebXRWalkingLocomotionOptions
        abstract Resolve: XRLayers -> IWebXRLayersOptions
        abstract Resolve: XRDepthSensing -> IWebXRDepthSensingOptions
        abstract Resolve: XRSpaceWarp -> unit
        abstract Resolve: XRRawCameraAccess -> IWebXRRawCameraAccessOptions
        abstract Resolve: XRBodyTracking -> IWebXRBodyTrackingOptions

    // Singleton views preserve the feature -> options -> result correlation at call sites.
    type ResolveWebXRFeatureAnchorSystem = WebXRAnchorSystem
    type ResolveWebXRFeatureBackgroundRemover = WebXRBackgroundRemover
    type ResolveWebXRFeatureHitTest = WebXRHitTest
    type ResolveWebXRFeatureMeshDetection = WebXRMeshDetector
    type ResolveWebXRFeaturePhysicsController = WebXRControllerPhysics
    type ResolveWebXRFeaturePlaneDetection = WebXRPlaneDetector
    type ResolveWebXRFeaturePointerSelection = WebXRControllerPointerSelection
    type ResolveWebXRFeatureTeleportation = WebXRMotionControllerTeleportation
    type ResolveWebXRFeatureFeaturePoints = WebXRFeaturePointSystem
    type ResolveWebXRFeatureHandTracking = WebXRHandTracking
    type ResolveWebXRFeatureImageTracking = WebXRImageTracking
    type ResolveWebXRFeatureNearInteraction = WebXRNearInteraction
    type ResolveWebXRFeatureDomOverlay = WebXRDomOverlay
    type ResolveWebXRFeatureMovement = WebXRControllerMovement
    type ResolveWebXRFeatureLightEstimation = WebXRLightEstimation
    type ResolveWebXRFeatureEyeTracking = WebXREyeTracking
    type ResolveWebXRFeatureWalkingLocomotion = WebXRWalkingLocomotion
    type ResolveWebXRFeatureLayers = WebXRLayers
    type ResolveWebXRFeatureDepthSensing = WebXRDepthSensing
    type ResolveWebXRFeatureSpaceWarp = WebXRSpaceWarp
    type ResolveWebXRFeatureRawCameraAccess = WebXRRawCameraAccess
    type ResolveWebXRFeatureBodyTracking = WebXRBodyTracking

    type ResolveWebXRFeatureOptionsAnchorSystem = IWebXRAnchorSystemOptions
    type ResolveWebXRFeatureOptionsBackgroundRemover = IWebXRBackgroundRemoverOptions
    type ResolveWebXRFeatureOptionsHitTest = IWebXRHitTestOptions
    type ResolveWebXRFeatureOptionsMeshDetection = IWebXRMeshDetectorOptions
    type ResolveWebXRFeatureOptionsPhysicsController = IWebXRControllerPhysicsOptions
    type ResolveWebXRFeatureOptionsPlaneDetection = IWebXRPlaneDetectorOptions
    type ResolveWebXRFeatureOptionsPointerSelection = IWebXRControllerPointerSelectionOptions
    type ResolveWebXRFeatureOptionsTeleportation = IWebXRTeleportationOptions
    type ResolveWebXRFeatureOptionsFeaturePoints = unit
    type ResolveWebXRFeatureOptionsHandTracking = IWebXRHandTrackingOptions
    type ResolveWebXRFeatureOptionsImageTracking = IWebXRImageTrackingOptions
    type ResolveWebXRFeatureOptionsNearInteraction = IWebXRNearInteractionOptions
    type ResolveWebXRFeatureOptionsDomOverlay = IWebXRDomOverlayOptions
    type ResolveWebXRFeatureOptionsMovement = IWebXRControllerMovementOptions
    type ResolveWebXRFeatureOptionsLightEstimation = IWebXRLightEstimationOptions
    type ResolveWebXRFeatureOptionsEyeTracking = unit
    type ResolveWebXRFeatureOptionsWalkingLocomotion = IWebXRWalkingLocomotionOptions
    type ResolveWebXRFeatureOptionsLayers = IWebXRLayersOptions
    type ResolveWebXRFeatureOptionsDepthSensing = IWebXRDepthSensingOptions
    type ResolveWebXRFeatureOptionsSpaceWarp = unit
    type ResolveWebXRFeatureOptionsRawCameraAccess = IWebXRRawCameraAccessOptions
    type ResolveWebXRFeatureOptionsBodyTracking = IWebXRBodyTrackingOptions

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
        abstract _extendXRSessionInitObject: xrSessionInit: BrowserXRSessionInit -> JS.Promise<BrowserXRSessionInit>
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type WebXRFeatureConstructor =
        [<Emit("$0($1...)")>] abstract Invoke: xrSessionManager: WebXRSessionManager * ?options: obj -> (unit -> IWebXRFeature)

    [<AllowNullLiteral>]
    type WebXRFeaturesManagerStatic =
        [<EmitConstructor>] abstract Create: xrSessionManager: WebXRSessionManager -> WebXRFeaturesManager
        abstract AddWebXRFeature: featureName: string * constructorFunction: WebXRFeatureConstructor * ?version: float * ?stable: bool -> unit
        abstract ConstructFeature: featureName: string * version: float option * xrSessionManager: WebXRSessionManager * ?options: obj -> (unit -> IWebXRFeature)
        abstract GetAvailableFeatures: unit -> ResizeArray<string>
        abstract GetAvailableVersions: featureName: string -> ResizeArray<string>
        abstract GetLatestVersionOfFeature: featureName: string -> float
        abstract GetStableVersionOfFeature: featureName: string -> float

    [<Import("WebXRFeaturesManager", "@babylonjs/core/XR/webXRFeaturesManager.js")>]
    let WebXRFeaturesManager: WebXRFeaturesManagerStatic = jsNative

    [<AllowNullLiteral>]
    type WebXRSpectatorModeOption =
        abstract fps: float option with get, set
        abstract preferredCameraIndex: float option with get, set

    [<AllowNullLiteral>]
    type WebXRExperienceHelper =
        abstract camera: WebXRCamera with get, set
        abstract featuresManager: WebXRFeaturesManager with get, set
        abstract sessionManager: WebXRSessionManager with get, set
        abstract state: WebXRState with get, set
        abstract onInitialXRPoseSetObservable: Observable<WebXRCamera> with get, set
        abstract onStateChangedObservable: Observable<WebXRState> with get, set
        abstract enterXRAsync: sessionMode: BrowserXRSessionMode * referenceSpaceType: BrowserXRReferenceSpaceType * ?renderTarget: WebXRRenderTarget<Browser.Types.WebGLRenderingContext, BrowserXRLayer> * ?sessionCreationOptions: BrowserXRSessionInit -> JS.Promise<WebXRSessionManager>
        abstract exitXRAsync: unit -> JS.Promise<unit>
        abstract enableSpectatorMode: ?options: WebXRSpectatorModeOption -> unit
        abstract disableSpecatatorMode: unit -> unit
        abstract dispose: unit -> unit

    [<AllowNullLiteral>]
    type WebXRExperienceHelperStatic =
        abstract CreateAsync: scene: Scene -> JS.Promise<WebXRExperienceHelper>

    [<Import("WebXRExperienceHelper", "@babylonjs/core/XR/webXRExperienceHelper.js")>]
    let WebXRExperienceHelper: WebXRExperienceHelperStatic = jsNative

    [<AllowNullLiteral>]
    type WebXREnterExitUI =
        abstract options: WebXREnterExitUIOptions with get, set
        abstract overlay: Browser.Types.HTMLDivElement with get
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
        abstract renderTarget: WebXRRenderTarget<Browser.Types.WebGLRenderingContext, BrowserXRLayer> with get, set
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
        abstract enableGazeEvenWhenNoPointerLock: bool with get, set
        abstract exitVROnDoubleTap: bool with get, set
        abstract onEnteringVRObservable: Observable<VRExperienceHelper> with get, set
        abstract onAfterEnteringVRObservable: Observable<OnAfterEnteringVRObservableEvent> with get, set
        abstract onExitingVRObservable: Observable<VRExperienceHelper> with get, set
        abstract onEnteringVR: Observable<VRExperienceHelper> with get
        abstract onExitingVR: Observable<VRExperienceHelper> with get
        abstract onNewMeshSelected: Observable<AbstractMesh> with get, set
        abstract onNewMeshPicked: Observable<PickingInfo> with get, set
        abstract onBeforeCameraTeleport: Observable<Vector3> with get, set
        abstract onAfterCameraTeleport: Observable<Vector3> with get, set
        abstract onSelectedMeshUnselected: Observable<AbstractMesh> with get, set
        abstract raySelectionPredicate: System.Func<AbstractMesh, bool> with get, set
        abstract meshSelectionPredicate: System.Func<AbstractMesh, bool> with get, set
        abstract teleportationEnabled: bool with get, set
        abstract teleportationTarget: Mesh with get, set
        abstract gazeTrackerMesh: Mesh with get, set
        abstract updateGazeTrackerScale: bool with get, set
        abstract updateGazeTrackerColor: bool with get, set
        abstract updateControllerLaserColor: bool with get, set
        abstract displayGaze: bool with get, set
        abstract displayLaserPointer: bool with get, set
        abstract deviceOrientationCamera: DeviceOrientationCamera option with get
        abstract currentVRCamera: Camera option with get
        abstract vrDeviceOrientationCamera: VRDeviceOrientationFreeCamera option with get
        abstract vrButton: Browser.Types.HTMLButtonElement option with get
        abstract requestPointerLockOnFullScreen: bool with get, set
        abstract xr: WebXRDefaultExperience with get, set
        abstract xrTestDone: bool with get, set
        abstract isInVRMode: bool with get
        abstract enterVR: unit -> unit
        abstract exitVR: unit -> unit
        abstract position: Vector3 with get, set
        abstract enableInteractions: unit -> unit
        abstract addFloorMesh: floorMesh: Mesh -> unit
        abstract removeFloorMesh: floorMesh: Mesh -> unit
        abstract enableTeleportation: ?vrTeleportationOptions: VRTeleportationOptions -> unit
        abstract teleportCamera: location: Vector3 -> unit
        abstract setLaserColor: color: Color3 * ?pickedColor: Color3 -> unit
        abstract setLaserLightingState: ?enabled: bool -> unit
        abstract setGazeColor: color: Color3 * ?pickedColor: Color3 -> unit
        abstract changeLaserColor: color: Color3 -> unit
        abstract changeGazeColor: color: Color3 -> unit
        abstract dispose: unit -> unit
        abstract getClassName: unit -> string

    [<AllowNullLiteral>]
    type VRExperienceHelperStatic =
        [<EmitConstructor>] abstract Create: scene: Scene * ?options: VRExperienceHelperOptions -> VRExperienceHelper
        abstract TELEPORTATIONMODE_CONSTANTTIME: float with get
        abstract TELEPORTATIONMODE_CONSTANTSPEED: float with get

    [<Import("VRExperienceHelper", "@babylonjs/core/Cameras/VR/vrExperienceHelper.pure.js")>]
    let VRExperienceHelper: VRExperienceHelperStatic = jsNative

    [<AllowNullLiteral>]
    type HandConstraintBehavior =
        inherit Behavior<TransformNode>
        abstract handConstraintVisibility: HandConstraintVisibility with get, set
        abstract palmUpStrictness: float with get, set
        abstract gazeProximityRadius: float with get, set
        abstract targetOffset: float with get, set
        abstract targetZone: HandConstraintZone with get, set
        abstract zoneOrientationMode: HandConstraintOrientation with get, set
        abstract nodeOrientationMode: HandConstraintOrientation with get, set
        abstract handedness: BrowserXRHandedness with get, set
        abstract lerpTime: float with get, set
        abstract attachedNode: TransformNode option with get
        abstract name: string with get
        abstract enable: unit -> unit
        abstract disable: unit -> unit
        abstract init: unit -> unit
        abstract attach: node: TransformNode -> unit
        abstract detach: unit -> unit
        abstract linkToXRExperience: xr: U2<WebXRExperienceHelper, WebXRFeaturesManager> -> unit

    [<AllowNullLiteral>]
    type HandConstraintBehaviorStatic =
        [<EmitConstructor>] abstract Create: unit -> HandConstraintBehavior

    [<Import("HandConstraintBehavior", "@babylonjs/core/Behaviors/Meshes/handConstraintBehavior.js")>]
    let HandConstraintBehavior: HandConstraintBehaviorStatic = jsNative
