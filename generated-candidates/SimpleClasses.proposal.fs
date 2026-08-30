// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after class review, compile, import, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact dependency-closed runtime classes exported by Babylon.js 9.19.0.
module SimpleClasses =

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.query.pure
    [<AllowNullLiteral>]
    type _OcclusionDataStorage =
        abstract ``occlusionInternalRetryCounter``: float with get, set
        abstract ``isOcclusionQueryInProgress``: bool with get, set
        abstract ``isOccluded``: bool with get, set
        abstract ``occlusionRetryCount``: float with get, set
        abstract ``occlusionType``: float with get, set
        abstract ``occlusionQueryAlgorithmType``: float with get, set
        abstract ``forceRenderingWhenOccluded``: bool with get, set
        abstract ``occlusionForRenderPassId``: float with get, set

    [<AllowNullLiteral>]
    type _OcclusionDataStorageStatic =
        [<EmitConstructor>] abstract Create: unit -> _OcclusionDataStorage

    [<Import("_OcclusionDataStorage", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.query.pure.js")>]
    let _OcclusionDataStorage: _OcclusionDataStorageStatic = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractAudioAnalyzer
    [<AllowNullLiteral>]
    type AbstractAudioAnalyzer =
        abstract ``fftSize``: BabylonjsBindings.Enums.AudioAnalyzerFFTSizeType with get, set
        abstract ``isEnabled``: bool with get, set
        abstract ``minDecibels``: float with get, set
        abstract ``maxDecibels``: float with get, set
        abstract ``smoothing``: float with get, set
        abstract ``dispose``: unit -> unit
        abstract ``enableAsync``: unit -> JS.Promise<unit>
        abstract ``getByteFrequencyData``: unit -> JS.Uint8Array
        abstract ``getByteTimeDomainData``: unit -> JS.Uint8Array
        abstract ``getFloatFrequencyData``: unit -> JS.Float32Array
        abstract ``getFloatTimeDomainData``: unit -> JS.Float32Array
        abstract ``frequencyBinCount``: float with get

    [<AllowNullLiteral>]
    type AbstractAudioAnalyzerStatic =
        interface end

    [<Import("AbstractAudioAnalyzer", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractAudioAnalyzer.js")>]
    let AbstractAudioAnalyzer: AbstractAudioAnalyzerStatic = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio
    [<AllowNullLiteral>]
    type AbstractStereoAudio =
        abstract ``pan``: float with get, set

    [<AllowNullLiteral>]
    type AbstractStereoAudioStatic =
        interface end

    [<Import("AbstractStereoAudio", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio.js")>]
    let AbstractStereoAudio: AbstractStereoAudioStatic = jsNative

    /// @babylonjs/core/States/alphaCullingState
    [<AllowNullLiteral>]
    type AlphaState =
        abstract ``_blendFunctionParameters``: ResizeArray<float option> with get, set
        abstract ``_blendEquationParameters``: ResizeArray<float option> with get, set
        abstract ``_blendConstants``: ResizeArray<float option> with get, set
        abstract ``_isBlendConstantsDirty``: bool with get, set
        abstract ``_alphaBlend``: ResizeArray<obj> with get, set
        abstract ``_numTargetEnabled``: float with get, set
        abstract ``setAlphaBlend``: ``value``: bool * ?``targetIndex``: float -> unit
        abstract ``setAlphaBlendConstants``: ``r``: float * ``g``: float * ``b``: float * ``a``: float -> unit
        abstract ``setAlphaBlendFunctionParameters``: ``srcRGBFactor``: float * ``dstRGBFactor``: float * ``srcAlphaFactor``: float * ``dstAlphaFactor``: float * ?``targetIndex``: float -> unit
        abstract ``setAlphaEquationParameters``: ``rgbEquation``: float * ``alphaEquation``: float * ?``targetIndex``: float -> unit
        abstract ``reset``: unit -> unit
        abstract ``apply``: ``gl``: Browser.Types.WebGLRenderingContext * ?``numTargets``: float -> unit
        abstract ``setAlphaMode``: ``mode``: float * ``targetIndex``: float -> unit
        abstract ``isDirty``: bool with get
        abstract ``alphaBlend``: bool with get, set

    [<AllowNullLiteral>]
    type AlphaStateStatic =
        [<EmitConstructor>] abstract Create: ``_supportBlendParametersPerTarget``: bool -> AlphaState

    [<Import("AlphaState", "@babylonjs/core/States/alphaCullingState.js")>]
    let AlphaState: AlphaStateStatic = jsNative

    /// Uncurried function-valued argument used by AndOrNotEvaluator.
    type AndOrNotEvaluatorMethod1Parameter2Callback = System.Func<obj, bool>

    /// @babylonjs/core/Misc/andOrNotEvaluator
    [<AllowNullLiteral>]
    type AndOrNotEvaluator =
        interface end

    [<AllowNullLiteral>]
    type AndOrNotEvaluatorStatic =
        [<EmitConstructor>] abstract Create: unit -> AndOrNotEvaluator
        abstract ``Eval``: ``query``: string * ``evaluateCallback``: AndOrNotEvaluatorMethod1Parameter2Callback -> bool

    [<Import("AndOrNotEvaluator", "@babylonjs/core/Misc/andOrNotEvaluator.js")>]
    let AndOrNotEvaluator: AndOrNotEvaluatorStatic = jsNative

    /// Uncurried function-valued argument used by AnimationEvent.
    type AnimationEventConstructor5Parameter2Callback = System.Action<float>

    /// Function-valued AnimationEvent.action property.
    [<AllowNullLiteral>]
    type AnimationEventActionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``currentFrame``: float -> unit

    /// @babylonjs/core/Animations/animationEvent
    [<AllowNullLiteral>]
    type AnimationEvent =
        abstract ``frame``: float with get, set
        abstract ``action``: AnimationEventActionCallback with get, set
        abstract ``onlyOnce``: bool option with get, set
        abstract ``isDone``: bool with get, set
        abstract ``_clone``: unit -> AnimationEvent

    [<AllowNullLiteral>]
    type AnimationEventStatic =
        [<EmitConstructor>] abstract Create: ``frame``: float * ``action``: AnimationEventConstructor5Parameter2Callback * ?``onlyOnce``: bool -> AnimationEvent

    [<Import("AnimationEvent", "@babylonjs/core/Animations/animationEvent.js")>]
    let AnimationEvent: AnimationEventStatic = jsNative

    /// @babylonjs/core/Animations/animationGroupMask
    [<AllowNullLiteral>]
    type AnimationGroupMask =
        abstract ``mode``: BabylonjsBindings.Enums.AnimationGroupMaskMode with get, set
        abstract ``disabled``: bool with get, set
        abstract ``addTargetName``: ``name``: U2<string, ResizeArray<string>> -> unit
        abstract ``removeTargetName``: ``name``: U2<string, ResizeArray<string>> -> unit
        abstract ``hasTarget``: ``name``: string -> bool
        abstract ``retainsTarget``: ``name``: string -> bool

    [<AllowNullLiteral>]
    type AnimationGroupMaskStatic =
        [<EmitConstructor>] abstract Create: ?``names``: ResizeArray<string> * ?``mode``: BabylonjsBindings.Enums.AnimationGroupMaskMode -> AnimationGroupMask

    [<Import("AnimationGroupMask", "@babylonjs/core/Animations/animationGroupMask.js")>]
    let AnimationGroupMask: AnimationGroupMaskStatic = jsNative

    /// @babylonjs/core/Animations/animationPropertiesOverride
    [<AllowNullLiteral>]
    type AnimationPropertiesOverride =
        abstract ``enableBlending``: bool with get, set
        abstract ``blendingSpeed``: float with get, set
        abstract ``loopMode``: float with get, set

    [<AllowNullLiteral>]
    type AnimationPropertiesOverrideStatic =
        [<EmitConstructor>] abstract Create: unit -> AnimationPropertiesOverride

    [<Import("AnimationPropertiesOverride", "@babylonjs/core/Animations/animationPropertiesOverride.js")>]
    let AnimationPropertiesOverride: AnimationPropertiesOverrideStatic = jsNative

    /// @babylonjs/core/Animations/animationRange
    [<AllowNullLiteral>]
    type AnimationRange =
        abstract ``name``: string with get, set
        abstract ``from``: float with get, set
        abstract ``to``: float with get, set
        abstract ``clone``: unit -> AnimationRange

    [<AllowNullLiteral>]
    type AnimationRangeStatic =
        [<EmitConstructor>] abstract Create: ``name``: string * ``from``: float * ``to``: float -> AnimationRange

    [<Import("AnimationRange", "@babylonjs/core/Animations/animationRange.js")>]
    let AnimationRange: AnimationRangeStatic = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<AllowNullLiteral>]
    type BabylonFileLoaderConfiguration =
        interface end

    [<AllowNullLiteral>]
    type BabylonFileLoaderConfigurationStatic =
        [<EmitConstructor>] abstract Create: unit -> BabylonFileLoaderConfiguration
        abstract ``LoaderInjectedPhysicsEngine``: obj with get, set

    [<Import("BabylonFileLoaderConfiguration", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let BabylonFileLoaderConfiguration: BabylonFileLoaderConfigurationStatic = jsNative

    /// @babylonjs/core/Maths/math.path
    [<AllowNullLiteral>]
    type BezierCurve =
        interface end

    [<AllowNullLiteral>]
    type BezierCurveStatic =
        [<EmitConstructor>] abstract Create: unit -> BezierCurve
        abstract ``Interpolate``: ``t``: float * ``x1``: float * ``y1``: float * ``x2``: float * ``y2``: float -> float

    [<Import("BezierCurve", "@babylonjs/core/Maths/math.path.js")>]
    let BezierCurve: BezierCurveStatic = jsNative

    /// @babylonjs/core/Misc/bitArray
    [<AllowNullLiteral>]
    type BitArray =
        abstract ``size``: float with get
        abstract ``get``: ``bitIndex``: float -> bool
        abstract ``set``: ``bitIndex``: float * ``value``: bool -> unit

    [<AllowNullLiteral>]
    type BitArrayStatic =
        [<EmitConstructor>] abstract Create: ``size``: float -> BitArray

    [<Import("BitArray", "@babylonjs/core/Misc/bitArray.js")>]
    let BitArray: BitArrayStatic = jsNative

    /// Uncurried function-valued argument used by Database.
    type DatabaseConstructor14Parameter2Callback = System.Func<bool, obj>

    /// Uncurried function-valued argument used by Database.
    type DatabaseMethod18Parameter1Callback = System.Action

    /// Uncurried function-valued argument used by Database.
    type DatabaseMethod18Parameter2Callback = System.Action

    /// Uncurried function-valued argument used by Database.
    type DatabaseMethod25Parameter2Callback = System.Action<obj>

    /// Uncurried function-valued argument used by Database.
    type DatabaseMethod25Parameter3Callback = System.Action<obj>

    /// Uncurried function-valued argument used by Database.
    type DatabaseMethod25Parameter4Callback = System.Action

    /// @babylonjs/core/Offline/database.pure
    [<AllowNullLiteral>]
    type Database =
        abstract ``open``: ``successCallback``: DatabaseMethod18Parameter1Callback * ``errorCallback``: DatabaseMethod18Parameter2Callback -> unit
        abstract ``loadImage``: ``url``: string * ``image``: Browser.Types.HTMLImageElement -> unit
        abstract ``loadFile``: ``url``: string * ``sceneLoaded``: DatabaseMethod25Parameter2Callback * ?``progressCallBack``: DatabaseMethod25Parameter3Callback * ?``errorCallback``: DatabaseMethod25Parameter4Callback * ?``useArrayBuffer``: bool -> unit
        abstract ``enableSceneOffline``: bool with get
        abstract ``enableTexturesOffline``: bool with get

    [<AllowNullLiteral>]
    type DatabaseStatic =
        [<EmitConstructor>] abstract Create: ``urlToScene``: string * ``callbackManifestChecked``: DatabaseConstructor14Parameter2Callback * ?``disableManifestCheck``: bool -> Database
        abstract ``IDBStorageEnabled``: bool with get, set

    [<Import("Database", "@babylonjs/core/Offline/database.pure.js")>]
    let Database: DatabaseStatic = jsNative

    /// @babylonjs/core/Buffers/dataBuffer
    [<AllowNullLiteral>]
    type DataBuffer =
        abstract ``references``: float with get, set
        abstract ``capacity``: float with get, set
        abstract ``is32Bits``: bool with get, set
        abstract ``uniqueId``: float with get
        abstract ``underlyingResource``: obj with get

    [<AllowNullLiteral>]
    type DataBufferStatic =
        [<EmitConstructor>] abstract Create: unit -> DataBuffer

    [<Import("DataBuffer", "@babylonjs/core/Buffers/dataBuffer.js")>]
    let DataBuffer: DataBufferStatic = jsNative

    /// @babylonjs/core/Misc/dataReader
    [<AllowNullLiteral>]
    type DataReader =
        abstract ``buffer``: BabylonjsBindings.SimpleInterfaces.IDataBuffer with get
        abstract ``byteOffset``: float with get, set
        abstract ``loadAsync``: ``byteLength``: float -> JS.Promise<unit>
        abstract ``readUint32``: unit -> float
        abstract ``readUint8Array``: ``byteLength``: float -> JS.Uint8Array
        abstract ``readString``: ``byteLength``: float -> string
        abstract ``skipBytes``: ``byteLength``: float -> unit

    [<AllowNullLiteral>]
    type DataReaderStatic =
        [<EmitConstructor>] abstract Create: ``buffer``: BabylonjsBindings.SimpleInterfaces.IDataBuffer -> DataReader

    [<Import("DataReader", "@babylonjs/core/Misc/dataReader.js")>]
    let DataReader: DataReaderStatic = jsNative

    /// @babylonjs/core/Misc/deepCopier
    [<AllowNullLiteral>]
    type DeepCopier =
        interface end

    [<AllowNullLiteral>]
    type DeepCopierStatic =
        [<EmitConstructor>] abstract Create: unit -> DeepCopier
        abstract ``DeepCopy``: ``source``: obj * ``destination``: obj * ?``doNotCopyList``: ResizeArray<string> * ?``mustCopyList``: ResizeArray<string> * ?``shallowCopyValues``: bool -> unit

    [<Import("DeepCopier", "@babylonjs/core/Misc/deepCopier.js")>]
    let DeepCopier: DeepCopierStatic = jsNative

    /// @babylonjs/core/Loading/loadingScreen.pure
    [<AllowNullLiteral>]
    type DefaultLoadingScreen =
        abstract ``displayLoadingUI``: unit -> unit
        abstract ``hideLoadingUI``: unit -> unit
        abstract ``loadingUIText``: string with get, set
        abstract ``loadingUIBackgroundColor``: string with get, set

    [<AllowNullLiteral>]
    type DefaultLoadingScreenStatic =
        [<EmitConstructor>] abstract Create: ``_renderingCanvas``: Browser.Types.HTMLCanvasElement * ?``_loadingText``: string * ?``_loadingDivBackgroundColor``: string -> DefaultLoadingScreen
        abstract ``DefaultLogoUrl``: string with get, set
        abstract ``DefaultSpinnerUrl``: string with get, set

    [<Import("DefaultLoadingScreen", "@babylonjs/core/Loading/loadingScreen.pure.js")>]
    let DefaultLoadingScreen: DefaultLoadingScreenStatic = jsNative

    /// @babylonjs/core/States/depthCullingState
    [<AllowNullLiteral>]
    type DepthCullingState =
        abstract ``reset``: unit -> unit
        abstract ``apply``: ``gl``: Browser.Types.WebGLRenderingContext -> unit
        abstract ``isDirty``: bool with get
        abstract ``zOffset``: float with get, set
        abstract ``zOffsetUnits``: float with get, set
        abstract ``cullFace``: float option with get, set
        abstract ``cull``: bool option with get, set
        abstract ``depthFunc``: float option with get, set
        abstract ``depthMask``: bool with get, set
        abstract ``depthTest``: bool with get, set
        abstract ``frontFace``: float option with get, set

    [<AllowNullLiteral>]
    type DepthCullingStateStatic =
        [<EmitConstructor>] abstract Create: ?``reset``: bool -> DepthCullingState

    [<Import("DepthCullingState", "@babylonjs/core/States/depthCullingState.js")>]
    let DepthCullingState: DepthCullingStateStatic = jsNative

    /// @babylonjs/core/Particles/solidParticle
    [<AllowNullLiteral>]
    type DepthSortedParticle =
        abstract ``idx``: float with get, set
        abstract ``ind``: float with get, set
        abstract ``indicesLength``: float with get, set
        abstract ``sqDistance``: float with get, set
        abstract ``materialIndex``: float with get, set

    [<AllowNullLiteral>]
    type DepthSortedParticleStatic =
        [<EmitConstructor>] abstract Create: ``idx``: float * ``ind``: float * ``indLength``: float * ``materialIndex``: float -> DepthSortedParticle

    [<Import("DepthSortedParticle", "@babylonjs/core/Particles/solidParticle.js")>]
    let DepthSortedParticle: DepthSortedParticleStatic = jsNative

    /// @babylonjs/core/Misc/PerformanceViewer/dynamicFloat32Array
    [<AllowNullLiteral>]
    type DynamicFloat32Array =
        abstract ``at``: ``index``: float -> float
        abstract ``subarray``: ``start``: float * ``end``: float -> JS.Float32Array
        abstract ``push``: ``item``: float -> unit
        abstract ``itemLength``: float with get

    [<AllowNullLiteral>]
    type DynamicFloat32ArrayStatic =
        [<EmitConstructor>] abstract Create: ``itemCapacity``: float -> DynamicFloat32Array

    [<Import("DynamicFloat32Array", "@babylonjs/core/Misc/PerformanceViewer/dynamicFloat32Array.js")>]
    let DynamicFloat32Array: DynamicFloat32ArrayStatic = jsNative

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type EventConstants =
        interface end

    [<AllowNullLiteral>]
    type EventConstantsStatic =
        [<EmitConstructor>] abstract Create: unit -> EventConstants
        abstract ``DOM_DELTA_PIXEL``: float with get, set
        abstract ``DOM_DELTA_LINE``: float with get, set
        abstract ``DOM_DELTA_PAGE``: float with get, set

    [<Import("EventConstants", "@babylonjs/core/Events/deviceInputEvents.js")>]
    let EventConstants: EventConstantsStatic = jsNative

    /// @babylonjs/core/Misc/observable.pure
    [<AllowNullLiteral>]
    type EventState =
        abstract ``initialize``: ``mask``: float * ?``skipNextObservers``: bool * ?``target``: obj * ?``currentTarget``: obj -> EventState
        abstract ``skipNextObservers``: bool with get, set
        abstract ``mask``: float with get, set
        abstract ``target``: obj option with get, set
        abstract ``currentTarget``: obj option with get, set
        abstract ``lastReturnValue``: obj option with get, set
        abstract ``userInfo``: obj option with get, set

    [<AllowNullLiteral>]
    type EventStateStatic =
        [<EmitConstructor>] abstract Create: ``mask``: float * ?``skipNextObservers``: bool * ?``target``: obj * ?``currentTarget``: obj -> EventState

    [<Import("EventState", "@babylonjs/core/Misc/observable.pure.js")>]
    let EventState: EventStateStatic = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.configuration
    [<AllowNullLiteral>]
    type ExrLoaderGlobalConfiguration =
        interface end

    [<AllowNullLiteral>]
    type ExrLoaderGlobalConfigurationStatic =
        [<EmitConstructor>] abstract Create: unit -> ExrLoaderGlobalConfiguration
        abstract ``DefaultOutputType``: BabylonjsBindings.Enums.EXROutputType with get, set
        abstract ``FFLATEUrl``: string with get, set

    [<Import("ExrLoaderGlobalConfiguration", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.configuration.js")>]
    let ExrLoaderGlobalConfiguration: ExrLoaderGlobalConfigurationStatic = jsNative

    /// @babylonjs/core/Misc/gradients
    [<AllowNullLiteral>]
    type FactorGradient =
        abstract ``gradient``: float with get, set
        abstract ``factor1``: float with get, set
        abstract ``factor2``: float option with get, set
        abstract ``getFactor``: unit -> float

    [<AllowNullLiteral>]
    type FactorGradientStatic =
        [<EmitConstructor>] abstract Create: ``gradient``: float * ``factor1``: float * ?``factor2``: float -> FactorGradient

    [<Import("FactorGradient", "@babylonjs/core/Misc/gradients.js")>]
    let FactorGradient: FactorGradientStatic = jsNative

    /// @babylonjs/core/FlowGraph/CustomTypes/flowGraphInteger.pure
    [<AllowNullLiteral>]
    type FlowGraphInteger =
        abstract ``value``: float with get
        abstract ``add``: ``other``: FlowGraphInteger -> FlowGraphInteger
        abstract ``subtract``: ``other``: FlowGraphInteger -> FlowGraphInteger
        abstract ``multiply``: ``other``: FlowGraphInteger -> FlowGraphInteger
        abstract ``divide``: ``other``: FlowGraphInteger -> FlowGraphInteger
        abstract ``getClassName``: unit -> string
        abstract ``equals``: ``other``: FlowGraphInteger -> bool
        abstract ``toString``: unit -> string

    [<AllowNullLiteral>]
    type FlowGraphIntegerStatic =
        [<EmitConstructor>] abstract Create: ``value``: float -> FlowGraphInteger
        abstract ``ClassName``: string with get, set
        abstract ``FromValue``: ``value``: float -> FlowGraphInteger

    [<Import("FlowGraphInteger", "@babylonjs/core/FlowGraph/CustomTypes/flowGraphInteger.pure.js")>]
    let FlowGraphInteger: FlowGraphIntegerStatic = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphLogger
    [<AllowNullLiteral>]
    type FlowGraphLogger =
        abstract ``logToConsole``: bool with get, set
        abstract ``log``: ResizeArray<BabylonjsBindings.SimpleInterfaces.IFlowGraphLogItem> with get, set
        abstract ``addLogItem``: ``item``: BabylonjsBindings.SimpleInterfaces.IFlowGraphLogItem -> unit
        abstract ``getItemsOfType``: ``action``: BabylonjsBindings.StringEnums.FlowGraphAction -> ResizeArray<BabylonjsBindings.SimpleInterfaces.IFlowGraphLogItem>

    [<AllowNullLiteral>]
    type FlowGraphLoggerStatic =
        [<EmitConstructor>] abstract Create: unit -> FlowGraphLogger

    [<Import("FlowGraphLogger", "@babylonjs/core/FlowGraph/flowGraphLogger.js")>]
    let FlowGraphLogger: FlowGraphLoggerStatic = jsNative

    /// Uncurried function-valued argument used by GradientHelper.
    type GradientHelperMethod1Parameter3Callback = System.Action<BabylonjsBindings.SimpleInterfaces.IValueGradient, BabylonjsBindings.SimpleInterfaces.IValueGradient, float>

    /// @babylonjs/core/Misc/gradients
    [<AllowNullLiteral>]
    type GradientHelper =
        interface end

    [<AllowNullLiteral>]
    type GradientHelperStatic =
        [<EmitConstructor>] abstract Create: unit -> GradientHelper
        abstract ``GetCurrentGradient``: ``ratio``: float * ``gradients``: ResizeArray<BabylonjsBindings.SimpleInterfaces.IValueGradient> * ``updateFunc``: GradientHelperMethod1Parameter3Callback -> unit

    [<Import("GradientHelper", "@babylonjs/core/Misc/gradients.js")>]
    let GradientHelper: GradientHelperStatic = jsNative

    /// @babylonjs/core/Collisions/intersectionInfo
    [<AllowNullLiteral>]
    type IntersectionInfo =
        abstract ``bu``: float option with get, set
        abstract ``bv``: float option with get, set
        abstract ``distance``: float with get, set
        abstract ``faceId``: float with get, set
        abstract ``subMeshId``: float with get, set
        abstract ``_internalSubMeshId``: float with get, set

    [<AllowNullLiteral>]
    type IntersectionInfoStatic =
        [<EmitConstructor>] abstract Create: ``bu``: float option * ``bv``: float option * ``distance``: float -> IntersectionInfo

    [<Import("IntersectionInfo", "@babylonjs/core/Collisions/intersectionInfo.js")>]
    let IntersectionInfo: IntersectionInfoStatic = jsNative

    /// @babylonjs/core/Events/keyboardEvents
    [<AllowNullLiteral>]
    type KeyboardInfo =
        abstract ``type``: float with get, set
        abstract ``event``: BabylonjsBindings.SimpleInterfaces.IKeyboardEvent with get, set

    [<AllowNullLiteral>]
    type KeyboardInfoStatic =
        [<EmitConstructor>] abstract Create: ``type``: float * ``event``: BabylonjsBindings.SimpleInterfaces.IKeyboardEvent -> KeyboardInfo

    [<Import("KeyboardInfo", "@babylonjs/core/Events/keyboardEvents.js")>]
    let KeyboardInfo: KeyboardInfoStatic = jsNative

    /// Uncurried function-valued argument used by Lazy.
    type LazyConstructor3Parameter1Callback<'T> = System.Func<'T>

    /// @babylonjs/core/Misc/lazy
    [<AllowNullLiteral>]
    type Lazy<'T> =
        abstract ``value``: 'T with get

    [<AllowNullLiteral>]
    type LazyStatic =
        [<EmitConstructor>] abstract Create<'T>: ``factory``: LazyConstructor3Parameter1Callback<'T> -> Lazy<'T>

    [<Import("Lazy", "@babylonjs/core/Misc/lazy.js")>]
    let Lazy: LazyStatic = jsNative

    /// @babylonjs/core/Materials/materialFlags
    [<AllowNullLiteral>]
    type MaterialFlags =
        interface end

    [<AllowNullLiteral>]
    type MaterialFlagsStatic =
        [<EmitConstructor>] abstract Create: unit -> MaterialFlags
        abstract ``DiffuseTextureEnabled``: bool with get, set
        abstract ``BaseWeightTextureEnabled``: bool with get, set
        abstract ``BaseDiffuseRoughnessTextureEnabled``: bool with get, set
        abstract ``DetailTextureEnabled``: bool with get, set
        abstract ``DecalMapEnabled``: bool with get, set
        abstract ``AmbientTextureEnabled``: bool with get, set
        abstract ``OpacityTextureEnabled``: bool with get, set
        abstract ``ReflectionTextureEnabled``: bool with get, set
        abstract ``EmissiveTextureEnabled``: bool with get, set
        abstract ``SpecularTextureEnabled``: bool with get, set
        abstract ``BumpTextureEnabled``: bool with get, set
        abstract ``LightmapTextureEnabled``: bool with get, set
        abstract ``RefractionTextureEnabled``: bool with get, set
        abstract ``ColorGradingTextureEnabled``: bool with get, set
        abstract ``FresnelEnabled``: bool with get, set
        abstract ``ClearCoatTextureEnabled``: bool with get, set
        abstract ``ClearCoatBumpTextureEnabled``: bool with get, set
        abstract ``ClearCoatTintTextureEnabled``: bool with get, set
        abstract ``SheenTextureEnabled``: bool with get, set
        abstract ``AnisotropicTextureEnabled``: bool with get, set
        abstract ``ThicknessTextureEnabled``: bool with get, set
        abstract ``RefractionIntensityTextureEnabled``: bool with get, set
        abstract ``TranslucencyIntensityTextureEnabled``: bool with get, set
        abstract ``TranslucencyColorTextureEnabled``: bool with get, set
        abstract ``IridescenceTextureEnabled``: bool with get, set

    [<Import("MaterialFlags", "@babylonjs/core/Materials/materialFlags.js")>]
    let MaterialFlags: MaterialFlagsStatic = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type MatrixManagement =
        interface end

    [<AllowNullLiteral>]
    type MatrixManagementStatic =
        [<EmitConstructor>] abstract Create: unit -> MatrixManagement
        abstract ``_UpdateFlagSeed``: float with get, set

    [<Import("MatrixManagement", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let MatrixManagement: MatrixManagementStatic = jsNative

    /// @babylonjs/core/Engines/nullEngine.pure
    [<AllowNullLiteral>]
    type NullEngineOptions =
        abstract ``renderWidth``: float with get, set
        abstract ``renderHeight``: float with get, set
        abstract ``textureSize``: float with get, set
        abstract ``deterministicLockstep``: bool with get, set
        abstract ``timeStep``: float option with get, set
        abstract ``lockstepMaxSteps``: float with get, set
        abstract ``useHighPrecisionMatrix``: bool option with get, set
        abstract ``renderingCanvas``: Browser.Types.HTMLCanvasElement option with get, set
        abstract ``enableMultiview``: bool option with get, set

    [<AllowNullLiteral>]
    type NullEngineOptionsStatic =
        [<EmitConstructor>] abstract Create: unit -> NullEngineOptions

    [<Import("NullEngineOptions", "@babylonjs/core/Engines/nullEngine.pure.js")>]
    let NullEngineOptions: NullEngineOptionsStatic = jsNative

    /// @babylonjs/core/Cameras/VR/vrExperienceHelper.pure
    [<AllowNullLiteral>]
    type OnAfterEnteringVRObservableEvent =
        abstract ``success``: bool with get, set

    [<AllowNullLiteral>]
    type OnAfterEnteringVRObservableEventStatic =
        [<EmitConstructor>] abstract Create: unit -> OnAfterEnteringVRObservableEvent

    [<Import("OnAfterEnteringVRObservableEvent", "@babylonjs/core/Cameras/VR/vrExperienceHelper.pure.js")>]
    let OnAfterEnteringVRObservableEvent: OnAfterEnteringVRObservableEventStatic = jsNative

    /// @babylonjs/core/Misc/HighDynamicRange/panoramaToCubemap
    [<AllowNullLiteral>]
    type PanoramaToCubeMapTools =
        interface end

    [<AllowNullLiteral>]
    type PanoramaToCubeMapToolsStatic =
        [<EmitConstructor>] abstract Create: unit -> PanoramaToCubeMapTools
        abstract ``ConvertPanoramaToCubemap``: ``float32Array``: JS.Float32Array * ``inputWidth``: float * ``inputHeight``: float * ``size``: float * ?``supersample``: bool * ?``invertY``: bool -> BabylonjsBindings.SimpleInterfaces.CubeMapInfo

    [<Import("PanoramaToCubeMapTools", "@babylonjs/core/Misc/HighDynamicRange/panoramaToCubemap.js")>]
    let PanoramaToCubeMapTools: PanoramaToCubeMapToolsStatic = jsNative

    /// @babylonjs/core/Misc/perfCounter
    [<AllowNullLiteral>]
    type PerfCounter =
        abstract ``fetchNewFrame``: unit -> unit
        abstract ``addCount``: ``newCount``: float * ``fetchResult``: bool -> unit
        abstract ``beginMonitoring``: unit -> unit
        abstract ``endMonitoring``: ?``newFrame``: bool -> unit
        abstract ``endFrame``: unit -> unit
        abstract ``_fetchResult``: unit -> unit
        abstract ``min``: float with get
        abstract ``max``: float with get
        abstract ``average``: float with get
        abstract ``lastSecAverage``: float with get
        abstract ``current``: float with get
        abstract ``total``: float with get
        abstract ``count``: float with get

    [<AllowNullLiteral>]
    type PerfCounterStatic =
        [<EmitConstructor>] abstract Create: unit -> PerfCounter
        abstract ``Enabled``: bool with get, set

    [<Import("PerfCounter", "@babylonjs/core/Misc/perfCounter.js")>]
    let PerfCounter: PerfCounterStatic = jsNative

    /// @babylonjs/core/Engines/performanceConfigurator
    [<AllowNullLiteral>]
    type PerformanceConfigurator =
        interface end

    [<AllowNullLiteral>]
    type PerformanceConfiguratorStatic =
        [<EmitConstructor>] abstract Create: unit -> PerformanceConfigurator
        abstract ``MatrixUse64Bits``: bool with get, set
        abstract ``MatrixTrackPrecisionChange``: bool with get, set
        abstract ``MatrixCurrentType``: obj with get, set
        abstract ``MatrixTrackedMatrices``: ResizeArray<obj> option with get, set
        abstract ``SetMatrixPrecision``: ``use64bits``: bool -> unit

    [<Import("PerformanceConfigurator", "@babylonjs/core/Engines/performanceConfigurator.js")>]
    let PerformanceConfigurator: PerformanceConfiguratorStatic = jsNative

    /// @babylonjs/core/Misc/performanceMonitor
    [<AllowNullLiteral>]
    type PerformanceMonitor =
        abstract ``sampleFrame``: ?``timeMs``: float -> unit
        abstract ``enable``: unit -> unit
        abstract ``disable``: unit -> unit
        abstract ``reset``: unit -> unit
        abstract ``averageFrameTime``: float with get
        abstract ``averageFrameTimeVariance``: float with get
        abstract ``instantaneousFrameTime``: float with get
        abstract ``averageFPS``: float with get
        abstract ``instantaneousFPS``: float with get
        abstract ``isSaturated``: bool with get
        abstract ``isEnabled``: bool with get

    [<AllowNullLiteral>]
    type PerformanceMonitorStatic =
        [<EmitConstructor>] abstract Create: ?``frameSampleSize``: float -> PerformanceMonitor

    [<Import("PerformanceMonitor", "@babylonjs/core/Misc/performanceMonitor.js")>]
    let PerformanceMonitor: PerformanceMonitorStatic = jsNative

    /// @babylonjs/core/Physics/v2/physicsConstraint
    [<AllowNullLiteral>]
    type Physics6DoFLimit =
        abstract ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis with get, set
        abstract ``minLimit``: float option with get, set
        abstract ``maxLimit``: float option with get, set
        abstract ``stiffness``: float option with get, set
        abstract ``damping``: float option with get, set

    [<AllowNullLiteral>]
    type Physics6DoFLimitStatic =
        [<EmitConstructor>] abstract Create: unit -> Physics6DoFLimit

    [<Import("Physics6DoFLimit", "@babylonjs/core/Physics/v2/physicsConstraint.js")>]
    let Physics6DoFLimit: Physics6DoFLimitStatic = jsNative

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsUpdraftEventOptions =
        abstract ``radius``: float with get, set
        abstract ``strength``: float with get, set
        abstract ``height``: float with get, set
        abstract ``updraftMode``: BabylonjsBindings.Enums.PhysicsUpdraftMode with get, set

    [<AllowNullLiteral>]
    type PhysicsUpdraftEventOptionsStatic =
        [<EmitConstructor>] abstract Create: unit -> PhysicsUpdraftEventOptions

    [<Import("PhysicsUpdraftEventOptions", "@babylonjs/core/Physics/physicsHelper.js")>]
    let PhysicsUpdraftEventOptions: PhysicsUpdraftEventOptionsStatic = jsNative

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsVortexEventOptions =
        abstract ``radius``: float with get, set
        abstract ``strength``: float with get, set
        abstract ``height``: float with get, set
        abstract ``centripetalForceThreshold``: float with get, set
        abstract ``centripetalForceMultiplier``: float with get, set
        abstract ``centrifugalForceMultiplier``: float with get, set
        abstract ``updraftForceMultiplier``: float with get, set

    [<AllowNullLiteral>]
    type PhysicsVortexEventOptionsStatic =
        [<EmitConstructor>] abstract Create: unit -> PhysicsVortexEventOptions

    [<Import("PhysicsVortexEventOptions", "@babylonjs/core/Physics/physicsHelper.js")>]
    let PhysicsVortexEventOptions: PhysicsVortexEventOptionsStatic = jsNative

    /// @babylonjs/core/Meshes/geodesicMesh
    [<AllowNullLiteral>]
    type PolyhedronData =
        abstract ``name``: string with get, set
        abstract ``category``: string with get, set
        abstract ``vertex``: ResizeArray<ResizeArray<float>> with get, set
        abstract ``face``: ResizeArray<ResizeArray<float>> with get, set
        abstract ``edgematch``: ResizeArray<ResizeArray<U2<float, string>>> with get, set

    [<AllowNullLiteral>]
    type PolyhedronDataStatic =
        [<EmitConstructor>] abstract Create: ``name``: string * ``category``: string * ``vertex``: ResizeArray<ResizeArray<float>> * ``face``: ResizeArray<ResizeArray<float>> -> PolyhedronData

    [<Import("PolyhedronData", "@babylonjs/core/Meshes/geodesicMesh.js")>]
    let PolyhedronData: PolyhedronDataStatic = jsNative

    /// @babylonjs/core/Misc/precisionDate
    [<AllowNullLiteral>]
    type PrecisionDate =
        interface end

    [<AllowNullLiteral>]
    type PrecisionDateStatic =
        [<EmitConstructor>] abstract Create: unit -> PrecisionDate
        abstract ``Now``: float with get

    [<Import("PrecisionDate", "@babylonjs/core/Misc/precisionDate.js")>]
    let PrecisionDate: PrecisionDateStatic = jsNative

    /// Function-valued RichType.typeTransformer property.
    [<AllowNullLiteral>]
    type RichTypeTypeTransformerCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: obj -> 'T

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<AllowNullLiteral>]
    type RichType<'T> =
        abstract ``typeName``: string with get, set
        abstract ``defaultValue``: 'T with get, set
        abstract ``animationType``: float with get, set
        abstract ``typeTransformer``: RichTypeTypeTransformerCallback<'T> with get, set
        abstract ``serialize``: ``serializationObject``: obj -> unit

    [<AllowNullLiteral>]
    type RichTypeStatic =
        [<EmitConstructor>] abstract Create<'T>: ``typeName``: string * ``defaultValue``: 'T * ?``animationType``: float -> RichType<'T>

    [<Import("RichType", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let RichType: RichTypeStatic = jsNative

    /// @babylonjs/core/Misc/performanceMonitor
    [<AllowNullLiteral>]
    type RollingAverage =
        abstract ``average``: float with get, set
        abstract ``variance``: float with get, set
        abstract ``add``: ``v``: float -> unit
        abstract ``history``: ``i``: float -> float
        abstract ``isSaturated``: unit -> bool
        abstract ``reset``: unit -> unit

    [<AllowNullLiteral>]
    type RollingAverageStatic =
        [<EmitConstructor>] abstract Create: ``length``: float -> RollingAverage

    [<Import("RollingAverage", "@babylonjs/core/Misc/performanceMonitor.js")>]
    let RollingAverage: RollingAverageStatic = jsNative

    /// @babylonjs/core/Loading/sceneLoaderFlags
    [<AllowNullLiteral>]
    type SceneLoaderFlags =
        interface end

    [<AllowNullLiteral>]
    type SceneLoaderFlagsStatic =
        [<EmitConstructor>] abstract Create: unit -> SceneLoaderFlags
        abstract ``ForceFullSceneLoadingForIncremental``: bool with get, set
        abstract ``ShowLoadingScreen``: bool with get, set
        abstract ``loggingLevel``: float with get, set
        abstract ``CleanBoneMatrixWeights``: bool with get, set

    [<Import("SceneLoaderFlags", "@babylonjs/core/Loading/sceneLoaderFlags.js")>]
    let SceneLoaderFlags: SceneLoaderFlagsStatic = jsNative

    /// @babylonjs/core/Engines/Processors/shaderCodeInliner
    [<AllowNullLiteral>]
    type ShaderCodeInliner =
        abstract ``inlineToken``: string with get, set
        abstract ``debug``: bool with get, set
        abstract ``processCode``: unit -> unit
        abstract ``code``: string with get

    [<AllowNullLiteral>]
    type ShaderCodeInlinerStatic =
        [<EmitConstructor>] abstract Create: ``sourceCode``: string * ?``numMaxIterations``: float -> ShaderCodeInliner

    [<Import("ShaderCodeInliner", "@babylonjs/core/Engines/Processors/shaderCodeInliner.js")>]
    let ShaderCodeInliner: ShaderCodeInlinerStatic = jsNative

    /// @babylonjs/core/Meshes/meshSimplification.common
    [<AllowNullLiteral>]
    type SimplificationSettings =
        abstract ``quality``: float with get, set
        abstract ``distance``: float with get, set
        abstract ``optimizeMesh``: bool option with get, set

    [<AllowNullLiteral>]
    type SimplificationSettingsStatic =
        [<EmitConstructor>] abstract Create: ``quality``: float * ``distance``: float * ?``optimizeMesh``: bool -> SimplificationSettings

    [<Import("SimplificationSettings", "@babylonjs/core/Meshes/meshSimplification.common.js")>]
    let SimplificationSettings: SimplificationSettingsStatic = jsNative

    /// @babylonjs/core/Maths/math.size
    [<AllowNullLiteral>]
    type Size =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``toString``: unit -> string
        abstract ``getClassName``: unit -> string
        abstract ``getHashCode``: unit -> float
        abstract ``copyFrom``: ``src``: Size -> unit
        abstract ``copyFromFloats``: ``width``: float * ``height``: float -> Size
        abstract ``set``: ``width``: float * ``height``: float -> Size
        abstract ``multiplyByFloats``: ``w``: float * ``h``: float -> Size
        abstract ``clone``: unit -> Size
        abstract ``equals``: ``other``: Size -> bool
        abstract ``add``: ``otherSize``: Size -> Size
        abstract ``subtract``: ``otherSize``: Size -> Size
        abstract ``scale``: ``scale``: float -> Size
        abstract ``surface``: float with get

    [<AllowNullLiteral>]
    type SizeStatic =
        [<EmitConstructor>] abstract Create: ``width``: float * ``height``: float -> Size
        abstract ``Zero``: unit -> Size
        abstract ``Lerp``: ``start``: Size * ``end``: Size * ``amount``: float -> Size

    [<Import("Size", "@babylonjs/core/Maths/math.size.js")>]
    let Size: SizeStatic = jsNative

    /// Uncurried function-valued argument used by SmartArray.
    type SmartArrayMethod6Parameter1Callback<'T> = System.Action<'T>

    /// Uncurried function-valued argument used by SmartArray.
    type SmartArrayMethod7Parameter1Callback<'T> = System.Func<'T, 'T, float>

    /// @babylonjs/core/Misc/smartArray
    [<AllowNullLiteral>]
    type SmartArray<'T> =
        abstract ``data``: ResizeArray<'T> with get, set
        abstract ``length``: float with get, set
        abstract ``push``: ``value``: 'T -> unit
        abstract ``forEach``: ``func``: SmartArrayMethod6Parameter1Callback<'T> -> unit
        abstract ``sort``: ``compareFn``: SmartArrayMethod7Parameter1Callback<'T> -> unit
        abstract ``reset``: unit -> unit
        abstract ``dispose``: unit -> unit
        abstract ``concat``: ``array``: obj -> unit
        abstract ``indexOf``: ``value``: 'T -> float
        abstract ``contains``: ``value``: 'T -> bool

    [<AllowNullLiteral>]
    type SmartArrayStatic =
        [<EmitConstructor>] abstract Create<'T>: ``capacity``: float -> SmartArray<'T>

    [<Import("SmartArray", "@babylonjs/core/Misc/smartArray.js")>]
    let SmartArray: SmartArrayStatic = jsNative

    /// @babylonjs/core/States/stencilStateComposer
    [<AllowNullLiteral>]
    type StencilStateComposer =
        abstract ``stencilGlobal``: BabylonjsBindings.SimpleInterfaces.IStencilState with get, set
        abstract ``stencilMaterial``: BabylonjsBindings.SimpleInterfaces.IStencilState option with get, set
        abstract ``useStencilGlobalOnly``: bool with get, set
        abstract ``reset``: unit -> unit
        abstract ``apply``: ?``gl``: Browser.Types.WebGLRenderingContext -> unit
        abstract ``isDirty``: bool with get
        abstract ``func``: float with get, set
        abstract ``backFunc``: float with get, set
        abstract ``funcRef``: float with get, set
        abstract ``funcMask``: float with get, set
        abstract ``opStencilFail``: float with get, set
        abstract ``opDepthFail``: float with get, set
        abstract ``opStencilDepthPass``: float with get, set
        abstract ``backOpStencilFail``: float with get, set
        abstract ``backOpDepthFail``: float with get, set
        abstract ``backOpStencilDepthPass``: float with get, set
        abstract ``mask``: float with get, set
        abstract ``enabled``: bool with get, set

    [<AllowNullLiteral>]
    type StencilStateComposerStatic =
        [<EmitConstructor>] abstract Create: ?``reset``: bool -> StencilStateComposer

    [<Import("StencilStateComposer", "@babylonjs/core/States/stencilStateComposer.js")>]
    let StencilStateComposer: StencilStateComposerStatic = jsNative

    /// @babylonjs/core/Gamepads/gamepad
    [<AllowNullLiteral>]
    type StickValues =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    [<AllowNullLiteral>]
    type StickValuesStatic =
        [<EmitConstructor>] abstract Create: ``x``: float * ``y``: float -> StickValues

    [<Import("StickValues", "@babylonjs/core/Gamepads/gamepad.js")>]
    let StickValues: StickValuesStatic = jsNative

    /// @babylonjs/core/Misc/tags
    [<AllowNullLiteral>]
    type Tags =
        interface end

    [<AllowNullLiteral>]
    type TagsStatic =
        [<EmitConstructor>] abstract Create: unit -> Tags
        abstract ``EnableFor``: ``obj``: obj -> unit
        abstract ``DisableFor``: ``obj``: obj -> unit
        abstract ``HasTags``: ``obj``: obj -> bool
        abstract ``GetTags``: ``obj``: obj * ?``asString``: bool -> obj
        abstract ``AddTagsTo``: ``obj``: obj * ``tagsString``: string -> unit
        abstract ``_AddTagTo``: ``obj``: obj * ``tag``: string -> unit
        abstract ``RemoveTagsFrom``: ``obj``: obj * ``tagsString``: string -> unit
        abstract ``_RemoveTagFrom``: ``obj``: obj * ``tag``: string -> unit
        abstract ``MatchesQuery``: ``obj``: obj * ``tagsQuery``: string -> bool

    [<Import("Tags", "@babylonjs/core/Misc/tags.js")>]
    let Tags: TagsStatic = jsNative

    /// @babylonjs/core/Materials/Textures/textureSampler
    [<AllowNullLiteral>]
    type TextureSampler =
        abstract ``samplingMode``: float with get, set
        abstract ``_cachedWrapU``: float option with get, set
        abstract ``_cachedWrapV``: float option with get, set
        abstract ``_cachedWrapR``: float option with get, set
        abstract ``_cachedAnisotropicFilteringLevel``: float option with get, set
        abstract ``_comparisonFunction``: float with get, set
        abstract ``label``: string option with get, set
        abstract ``setParameters``: ?``wrapU``: float * ?``wrapV``: float * ?``wrapR``: float * ?``anisotropicFilteringLevel``: float * ?``samplingMode``: float * ?``comparisonFunction``: float -> TextureSampler
        abstract ``compareSampler``: ``other``: TextureSampler -> bool
        abstract ``wrapU``: float option with get, set
        abstract ``wrapV``: float option with get, set
        abstract ``wrapR``: float option with get, set
        abstract ``anisotropicFilteringLevel``: float option with get, set
        abstract ``comparisonFunction``: float with get, set
        abstract ``useMipMaps``: bool option with get, set

    [<AllowNullLiteral>]
    type TextureSamplerStatic =
        [<EmitConstructor>] abstract Create: unit -> TextureSampler

    [<Import("TextureSampler", "@babylonjs/core/Materials/Textures/textureSampler.js")>]
    let TextureSampler: TextureSamplerStatic = jsNative

    /// @babylonjs/core/Misc/uniqueIdGenerator
    [<AllowNullLiteral>]
    type UniqueIdGenerator =
        interface end

    [<AllowNullLiteral>]
    type UniqueIdGeneratorStatic =
        [<EmitConstructor>] abstract Create: unit -> UniqueIdGenerator
        abstract ``UniqueId``: float with get

    [<Import("UniqueIdGenerator", "@babylonjs/core/Misc/uniqueIdGenerator.js")>]
    let UniqueIdGenerator: UniqueIdGeneratorStatic = jsNative

    /// @babylonjs/core/Meshes/mesh.vertexData
    [<AllowNullLiteral>]
    type VertexDataMaterialInfo =
        abstract ``materialIndex``: float with get, set
        abstract ``verticesStart``: float with get, set
        abstract ``verticesCount``: float with get, set
        abstract ``indexStart``: float with get, set
        abstract ``indexCount``: float with get, set

    [<AllowNullLiteral>]
    type VertexDataMaterialInfoStatic =
        [<EmitConstructor>] abstract Create: unit -> VertexDataMaterialInfo

    [<Import("VertexDataMaterialInfo", "@babylonjs/core/Meshes/mesh.vertexData.js")>]
    let VertexDataMaterialInfo: VertexDataMaterialInfoStatic = jsNative

    /// @babylonjs/core/Maths/math.viewport
    [<AllowNullLiteral>]
    type Viewport =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``toGlobal``: ``renderWidth``: float * ``renderHeight``: float -> Viewport
        abstract ``toGlobalToRef``: ``renderWidth``: float * ``renderHeight``: float * ``ref``: Viewport -> Viewport
        abstract ``clone``: unit -> Viewport

    [<AllowNullLiteral>]
    type ViewportStatic =
        [<EmitConstructor>] abstract Create: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> Viewport

    [<Import("Viewport", "@babylonjs/core/Maths/math.viewport.js")>]
    let Viewport: ViewportStatic = jsNative

    /// @babylonjs/core/Engines/WebGL/webGL2ShaderProcessors
    [<AllowNullLiteral>]
    type WebGL2ShaderProcessor =
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage with get, set
        abstract ``attributeProcessor``: ``attribute``: string -> string
        abstract ``varyingCheck``: ``varying``: string * ``_isFragment``: bool -> bool
        abstract ``varyingProcessor``: ``varying``: string * ``isFragment``: bool -> string
        abstract ``postProcessor``: ``code``: string * ``defines``: ResizeArray<string> * ``isFragment``: bool -> string

    [<AllowNullLiteral>]
    type WebGL2ShaderProcessorStatic =
        [<EmitConstructor>] abstract Create: unit -> WebGL2ShaderProcessor

    [<Import("WebGL2ShaderProcessor", "@babylonjs/core/Engines/WebGL/webGL2ShaderProcessors.js")>]
    let WebGL2ShaderProcessor: WebGL2ShaderProcessorStatic = jsNative

    /// @babylonjs/core/Engines/WebGL/webGLHardwareTexture
    [<AllowNullLiteral>]
    type WebGLHardwareTexture =
        abstract ``memoryAllocated``: bool option with get, set
        abstract ``setUsage``: unit -> unit
        abstract ``set``: ``hardwareTexture``: Browser.Types.WebGLTexture -> unit
        abstract ``reset``: unit -> unit
        abstract ``addMSAARenderBuffer``: ``buffer``: Browser.Types.WebGLRenderbuffer -> unit
        abstract ``releaseMSAARenderBuffers``: unit -> unit
        abstract ``getMSAARenderBuffer``: ?``index``: float -> Browser.Types.WebGLRenderbuffer option
        abstract ``release``: unit -> unit
        abstract ``underlyingResource``: Browser.Types.WebGLTexture option with get

    [<AllowNullLiteral>]
    type WebGLHardwareTextureStatic =
        [<EmitConstructor>] abstract Create: ``existingTexture``: Browser.Types.WebGLTexture option * ``context``: Browser.Types.WebGLRenderingContext -> WebGLHardwareTexture

    [<Import("WebGLHardwareTexture", "@babylonjs/core/Engines/WebGL/webGLHardwareTexture.js")>]
    let WebGLHardwareTexture: WebGLHardwareTextureStatic = jsNative

    /// @babylonjs/core/Engines/WebGPU/webgpuTintWASM
    [<AllowNullLiteral>]
    type WebGPUTintWASM =
        abstract ``initTwgsl``: ?``twgslOptions``: BabylonjsBindings.SimpleInterfaces.TwgslOptions -> JS.Promise<unit>
        abstract ``convertSpirV2WGSL``: ``code``: JS.Uint32Array * ?``disableUniformityAnalysis``: bool -> string

    [<AllowNullLiteral>]
    type WebGPUTintWASMStatic =
        [<EmitConstructor>] abstract Create: unit -> WebGPUTintWASM
        abstract ``ShowWGSLShaderCode``: bool with get, set
        abstract ``DisableUniformityAnalysis``: bool with get, set

    [<Import("WebGPUTintWASM", "@babylonjs/core/Engines/WebGPU/webgpuTintWASM.js")>]
    let WebGPUTintWASM: WebGPUTintWASMStatic = jsNative

    /// Uncurried function-valued argument used by Gamepad.
    type GamepadMethod22Parameter1Callback = System.Action<StickValues>

    /// Uncurried function-valued argument used by Gamepad.
    type GamepadMethod23Parameter1Callback = System.Action<StickValues>

    /// @babylonjs/core/Gamepads/gamepad
    [<AllowNullLiteral>]
    type Gamepad =
        abstract ``id``: string with get, set
        abstract ``index``: float with get, set
        abstract ``browserGamepad``: obj with get, set
        abstract ``type``: float with get, set
        abstract ``_isConnected``: bool with get, set
        abstract ``onleftstickchanged``: ``callback``: GamepadMethod22Parameter1Callback -> unit
        abstract ``onrightstickchanged``: ``callback``: GamepadMethod23Parameter1Callback -> unit
        abstract ``update``: unit -> unit
        abstract ``dispose``: unit -> unit
        abstract ``isConnected``: bool with get
        abstract ``leftStick``: StickValues with get, set
        abstract ``rightStick``: StickValues with get, set

    [<AllowNullLiteral>]
    type GamepadStatic =
        [<EmitConstructor>] abstract Create: ``id``: string * ``index``: float * ``browserGamepad``: obj * ?``leftStickX``: float * ?``leftStickY``: float * ?``rightStickX``: float * ?``rightStickY``: float -> Gamepad
        abstract ``GAMEPAD``: float with get, set
        abstract ``GENERIC``: float with get, set
        abstract ``XBOX``: float with get, set
        abstract ``POSE_ENABLED``: float with get, set
        abstract ``DUALSHOCK``: float with get, set

    [<Import("Gamepad", "@babylonjs/core/Gamepads/gamepad.js")>]
    let Gamepad: GamepadStatic = jsNative

    /// @babylonjs/core/Events/keyboardEvents
    [<AllowNullLiteral>]
    type KeyboardInfoPre =
        inherit KeyboardInfo
        abstract ``type``: float with get, set
        abstract ``event``: BabylonjsBindings.SimpleInterfaces.IKeyboardEvent with get, set
        abstract ``skipOnKeyboardObservable``: bool with get, set
        abstract ``skipOnPointerObservable``: bool with get, set

    [<AllowNullLiteral>]
    type KeyboardInfoPreStatic =
        inherit KeyboardInfoStatic
        [<EmitConstructor>] abstract Create: ``type``: float * ``event``: BabylonjsBindings.SimpleInterfaces.IKeyboardEvent -> KeyboardInfoPre

    [<Import("KeyboardInfoPre", "@babylonjs/core/Events/keyboardEvents.js")>]
    let KeyboardInfoPre: KeyboardInfoPreStatic = jsNative

    /// @babylonjs/core/Misc/smartArray
    [<AllowNullLiteral>]
    type SmartArrayNoDuplicate<'T> =
        inherit SmartArray<'T>
        abstract ``push``: ``value``: 'T -> unit
        abstract ``pushNoDuplicate``: ``value``: 'T -> bool
        abstract ``reset``: unit -> unit
        abstract ``concatWithNoDuplicate``: ``array``: obj -> unit

    [<AllowNullLiteral>]
    type SmartArrayNoDuplicateStatic =
        inherit SmartArrayStatic
        [<EmitConstructor>] abstract Create<'T>: ``capacity``: float -> SmartArrayNoDuplicate<'T>

    [<Import("SmartArrayNoDuplicate", "@babylonjs/core/Misc/smartArray.js")>]
    let SmartArrayNoDuplicate: SmartArrayNoDuplicateStatic = jsNative

    /// @babylonjs/core/Meshes/WebGL/webGLDataBuffer
    [<AllowNullLiteral>]
    type WebGLDataBuffer =
        inherit DataBuffer
        abstract ``underlyingResource``: obj with get

    [<AllowNullLiteral>]
    type WebGLDataBufferStatic =
        inherit DataBufferStatic
        [<EmitConstructor>] abstract Create: ``resource``: Browser.Types.WebGLBuffer -> WebGLDataBuffer

    [<Import("WebGLDataBuffer", "@babylonjs/core/Meshes/WebGL/webGLDataBuffer.js")>]
    let WebGLDataBuffer: WebGLDataBufferStatic = jsNative

    /// @babylonjs/core/Engines/WebGPU/webgpuPerfCounter
    [<AllowNullLiteral>]
    type WebGPUPerfCounter =
        abstract ``counter``: PerfCounter with get, set
        abstract ``_addDuration``: ``currentFrameId``: float * ``duration``: float -> unit

    [<AllowNullLiteral>]
    type WebGPUPerfCounterStatic =
        [<EmitConstructor>] abstract Create: unit -> WebGPUPerfCounter

    [<Import("WebGPUPerfCounter", "@babylonjs/core/Engines/WebGPU/webgpuPerfCounter.js")>]
    let WebGPUPerfCounter: WebGPUPerfCounterStatic = jsNative
