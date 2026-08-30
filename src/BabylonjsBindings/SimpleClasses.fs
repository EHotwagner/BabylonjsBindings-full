// MAINTAINED REVIEWED BINDING — exact Babylon.js 9.19.0 dependency-free runtime classes
namespace BabylonjsBindings

open Fable.Core

/// Exact dependency-free runtime classes exported by Babylon.js 9.19.0.
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

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio
    [<AllowNullLiteral>]
    type AbstractStereoAudio =
        abstract ``pan``: float with get, set

    [<AllowNullLiteral>]
    type AbstractStereoAudioStatic =
        interface end

    [<Import("AbstractStereoAudio", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio.js")>]
    let AbstractStereoAudio: AbstractStereoAudioStatic = jsNative

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
        abstract ``Interpolate``: t: float * x1: float * y1: float * x2: float * y2: float -> float

    [<Import("BezierCurve", "@babylonjs/core/Maths/math.path.js")>]
    let BezierCurve: BezierCurveStatic = jsNative

    /// @babylonjs/core/Misc/bitArray
    [<AllowNullLiteral>]
    type BitArray =
        abstract ``size``: float with get
        abstract ``get``: bitIndex: float -> bool
        abstract ``set``: bitIndex: float * value: bool -> unit

    [<AllowNullLiteral>]
    type BitArrayStatic =
        [<EmitConstructor>] abstract Create: size: float -> BitArray

    [<Import("BitArray", "@babylonjs/core/Misc/bitArray.js")>]
    let BitArray: BitArrayStatic = jsNative

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

    /// @babylonjs/core/Misc/deepCopier
    [<AllowNullLiteral>]
    type DeepCopier =
        interface end

    [<AllowNullLiteral>]
    type DeepCopierStatic =
        [<EmitConstructor>] abstract Create: unit -> DeepCopier
        abstract ``DeepCopy``: source: obj * destination: obj * ?doNotCopyList: ResizeArray<string> * ?mustCopyList: ResizeArray<string> * ?shallowCopyValues: bool -> unit

    [<Import("DeepCopier", "@babylonjs/core/Misc/deepCopier.js")>]
    let DeepCopier: DeepCopierStatic = jsNative

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
        [<EmitConstructor>] abstract Create: idx: float * ind: float * indLength: float * materialIndex: float -> DepthSortedParticle

    [<Import("DepthSortedParticle", "@babylonjs/core/Particles/solidParticle.js")>]
    let DepthSortedParticle: DepthSortedParticleStatic = jsNative

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

    /// @babylonjs/core/Cameras/VR/vrExperienceHelper.pure
    [<AllowNullLiteral>]
    type OnAfterEnteringVRObservableEvent =
        abstract ``success``: bool with get, set

    [<AllowNullLiteral>]
    type OnAfterEnteringVRObservableEventStatic =
        [<EmitConstructor>] abstract Create: unit -> OnAfterEnteringVRObservableEvent

    [<Import("OnAfterEnteringVRObservableEvent", "@babylonjs/core/Cameras/VR/vrExperienceHelper.pure.js")>]
    let OnAfterEnteringVRObservableEvent: OnAfterEnteringVRObservableEventStatic = jsNative

    /// @babylonjs/core/Misc/perfCounter
    [<AllowNullLiteral>]
    type PerfCounter =
        abstract ``fetchNewFrame``: unit -> unit
        abstract ``addCount``: newCount: float * fetchResult: bool -> unit
        abstract ``beginMonitoring``: unit -> unit
        abstract ``endMonitoring``: ?newFrame: bool -> unit
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

    /// @babylonjs/core/Misc/performanceMonitor
    [<AllowNullLiteral>]
    type PerformanceMonitor =
        abstract ``sampleFrame``: ?timeMs: float -> unit
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
        [<EmitConstructor>] abstract Create: ?frameSampleSize: float -> PerformanceMonitor

    [<Import("PerformanceMonitor", "@babylonjs/core/Misc/performanceMonitor.js")>]
    let PerformanceMonitor: PerformanceMonitorStatic = jsNative

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

    /// @babylonjs/core/Misc/performanceMonitor
    [<AllowNullLiteral>]
    type RollingAverage =
        abstract ``average``: float with get, set
        abstract ``variance``: float with get, set
        abstract ``add``: v: float -> unit
        abstract ``history``: i: float -> float
        abstract ``isSaturated``: unit -> bool
        abstract ``reset``: unit -> unit

    [<AllowNullLiteral>]
    type RollingAverageStatic =
        [<EmitConstructor>] abstract Create: length: float -> RollingAverage

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
        [<EmitConstructor>] abstract Create: sourceCode: string * ?numMaxIterations: float -> ShaderCodeInliner

    [<Import("ShaderCodeInliner", "@babylonjs/core/Engines/Processors/shaderCodeInliner.js")>]
    let ShaderCodeInliner: ShaderCodeInlinerStatic = jsNative

    /// @babylonjs/core/Gamepads/gamepad
    [<AllowNullLiteral>]
    type StickValues =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    [<AllowNullLiteral>]
    type StickValuesStatic =
        [<EmitConstructor>] abstract Create: x: float * y: float -> StickValues

    [<Import("StickValues", "@babylonjs/core/Gamepads/gamepad.js")>]
    let StickValues: StickValuesStatic = jsNative

    /// @babylonjs/core/Misc/tags
    [<AllowNullLiteral>]
    type Tags =
        interface end

    [<AllowNullLiteral>]
    type TagsStatic =
        [<EmitConstructor>] abstract Create: unit -> Tags
        abstract ``EnableFor``: obj: obj -> unit
        abstract ``DisableFor``: obj: obj -> unit
        abstract ``HasTags``: obj: obj -> bool
        abstract ``GetTags``: obj: obj * ?asString: bool -> obj
        abstract ``AddTagsTo``: obj: obj * tagsString: string -> unit
        abstract ``_AddTagTo``: obj: obj * tag: string -> unit
        abstract ``RemoveTagsFrom``: obj: obj * tagsString: string -> unit
        abstract ``_RemoveTagFrom``: obj: obj * tag: string -> unit
        abstract ``MatchesQuery``: obj: obj * tagsQuery: string -> bool

    [<Import("Tags", "@babylonjs/core/Misc/tags.js")>]
    let Tags: TagsStatic = jsNative

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
