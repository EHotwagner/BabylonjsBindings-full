// REVIEWED MAINTAINED SOURCE — exact declaration, import, and runtime proof recorded in generated-candidates
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

    /// @babylonjs/core/Events/clipboardEvents
    [<AllowNullLiteral>]
    type ClipboardEventTypes =
        interface end

    [<AllowNullLiteral>]
    type ClipboardEventTypesStatic =
        [<EmitConstructor>] abstract Create: unit -> ClipboardEventTypes
        abstract ``COPY``: float with get
        abstract ``CUT``: float with get
        abstract ``PASTE``: float with get

    [<Import("ClipboardEventTypes", "@babylonjs/core/Events/clipboardEvents.js")>]
    let ClipboardEventTypes: ClipboardEventTypesStatic = jsNative

    /// @babylonjs/core/Engines/constants
    [<AllowNullLiteral>]
    type Constants =
        interface end

    [<AllowNullLiteral>]
    type ConstantsStatic =
        [<EmitConstructor>] abstract Create: unit -> Constants
        abstract ``AUTOSAMPLERSUFFIX``: string with get
        abstract ``DISABLEUA``: string with get
        abstract ``ALPHA_DISABLE``: float with get
        abstract ``ALPHA_ADD``: float with get
        abstract ``ALPHA_COMBINE``: float with get
        abstract ``ALPHA_SUBTRACT``: float with get
        abstract ``ALPHA_MULTIPLY``: float with get
        abstract ``ALPHA_MAXIMIZED``: float with get
        abstract ``ALPHA_ONEONE``: float with get
        abstract ``ALPHA_PREMULTIPLIED``: float with get
        abstract ``ALPHA_PREMULTIPLIED_PORTERDUFF``: float with get
        abstract ``ALPHA_INTERPOLATE``: float with get
        abstract ``ALPHA_SCREENMODE``: float with get
        abstract ``ALPHA_ONEONE_ONEONE``: float with get
        abstract ``ALPHA_ALPHATOCOLOR``: float with get
        abstract ``ALPHA_REVERSEONEMINUS``: float with get
        abstract ``ALPHA_SRC_DSTONEMINUSSRCALPHA``: float with get
        abstract ``ALPHA_ONEONE_ONEZERO``: float with get
        abstract ``ALPHA_EXCLUSION``: float with get
        abstract ``ALPHA_LAYER_ACCUMULATE``: float with get
        abstract ``ALPHA_MIN``: float with get
        abstract ``ALPHA_MAX``: float with get
        abstract ``ALPHA_DUAL_SRC0_ADD_SRC1xDST``: float with get
        abstract ``ALPHA_REPLACE_COLOR``: float with get
        abstract ``ALPHA_EQUATION_ADD``: float with get
        abstract ``ALPHA_EQUATION_SUBSTRACT``: float with get
        abstract ``ALPHA_EQUATION_REVERSE_SUBTRACT``: float with get
        abstract ``ALPHA_EQUATION_MAX``: float with get
        abstract ``ALPHA_EQUATION_MIN``: float with get
        abstract ``ALPHA_EQUATION_DARKEN``: float with get
        abstract ``DELAYLOADSTATE_NONE``: float with get
        abstract ``DELAYLOADSTATE_LOADED``: float with get
        abstract ``DELAYLOADSTATE_LOADING``: float with get
        abstract ``DELAYLOADSTATE_NOTLOADED``: float with get
        abstract ``NEVER``: float with get
        abstract ``ALWAYS``: float with get
        abstract ``LESS``: float with get
        abstract ``EQUAL``: float with get
        abstract ``LEQUAL``: float with get
        abstract ``GREATER``: float with get
        abstract ``GEQUAL``: float with get
        abstract ``NOTEQUAL``: float with get
        abstract ``KEEP``: float with get
        abstract ``ZERO``: float with get
        abstract ``REPLACE``: float with get
        abstract ``INCR``: float with get
        abstract ``DECR``: float with get
        abstract ``INVERT``: float with get
        abstract ``INCR_WRAP``: float with get
        abstract ``DECR_WRAP``: float with get
        abstract ``TEXTURE_CLAMP_ADDRESSMODE``: float with get
        abstract ``TEXTURE_WRAP_ADDRESSMODE``: float with get
        abstract ``TEXTURE_MIRROR_ADDRESSMODE``: float with get
        abstract ``TEXTURE_REPETITION_NONE``: float with get
        abstract ``TEXTURE_REPETITION_NOISE_BLEND``: float with get
        abstract ``TEXTURE_REPETITION_HEX_TILING``: float with get
        abstract ``TEXTURE_REPETITION_TILE_RANDOMIZATION``: float with get
        abstract ``TEXTURE_REPETITION_VORONOI_BOMBING``: float with get
        abstract ``TEXTURE_CREATIONFLAG_STORAGE``: float with get
        abstract ``TEXTUREFORMAT_ALPHA``: float with get
        abstract ``TEXTUREFORMAT_LUMINANCE``: float with get
        abstract ``TEXTUREFORMAT_LUMINANCE_ALPHA``: float with get
        abstract ``TEXTUREFORMAT_RGB``: float with get
        abstract ``TEXTUREFORMAT_RGBA``: float with get
        abstract ``TEXTUREFORMAT_RED``: float with get
        abstract ``TEXTUREFORMAT_R``: float with get
        abstract ``TEXTUREFORMAT_R16_UNORM``: float with get
        abstract ``TEXTUREFORMAT_RG16_UNORM``: float with get
        abstract ``TEXTUREFORMAT_RGB16_UNORM``: float with get
        abstract ``TEXTUREFORMAT_RGBA16_UNORM``: float with get
        abstract ``TEXTUREFORMAT_R16_SNORM``: float with get
        abstract ``TEXTUREFORMAT_RG16_SNORM``: float with get
        abstract ``TEXTUREFORMAT_RGB16_SNORM``: float with get
        abstract ``TEXTUREFORMAT_RGBA16_SNORM``: float with get
        abstract ``TEXTUREFORMAT_RG``: float with get
        abstract ``TEXTUREFORMAT_RED_INTEGER``: float with get
        abstract ``TEXTUREFORMAT_R_INTEGER``: float with get
        abstract ``TEXTUREFORMAT_RG_INTEGER``: float with get
        abstract ``TEXTUREFORMAT_RGB_INTEGER``: float with get
        abstract ``TEXTUREFORMAT_RGBA_INTEGER``: float with get
        abstract ``TEXTUREFORMAT_BGRA``: float with get
        abstract ``TEXTUREFORMAT_DEPTH24_STENCIL8``: float with get
        abstract ``TEXTUREFORMAT_DEPTH32_FLOAT``: float with get
        abstract ``TEXTUREFORMAT_DEPTH16``: float with get
        abstract ``TEXTUREFORMAT_DEPTH24``: float with get
        abstract ``TEXTUREFORMAT_DEPTH24UNORM_STENCIL8``: float with get
        abstract ``TEXTUREFORMAT_DEPTH32FLOAT_STENCIL8``: float with get
        abstract ``TEXTUREFORMAT_STENCIL8``: float with get
        abstract ``TEXTUREFORMAT_UNDEFINED``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_BPTC_UNORM``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB_ALPHA_BPTC_UNORM``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGB_BPTC_SIGNED_FLOAT``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_S3TC_DXT5``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_S3TC_DXT3``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_S3TC_DXT1``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGB_S3TC_DXT1``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB_S3TC_DXT1_EXT``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_4x4``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_5x4``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_5x5``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_6x5``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_6x6``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_8x5``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_8x6``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_8x8``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_10x5``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_10x6``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_10x8``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_10x10``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_12x10``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA_ASTC_12x12``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGB_ETC1_WEBGL``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGB8_ETC2``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ETC2``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_RGBA8_ETC2_EAC``: float with get
        abstract ``TEXTUREFORMAT_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_BYTE``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_INT``: float with get
        abstract ``TEXTURETYPE_FLOAT``: float with get
        abstract ``TEXTURETYPE_HALF_FLOAT``: float with get
        abstract ``TEXTURETYPE_BYTE``: float with get
        abstract ``TEXTURETYPE_SHORT``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_SHORT``: float with get
        abstract ``TEXTURETYPE_INT``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_INTEGER``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_SHORT_4_4_4_4``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_SHORT_5_5_5_1``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_SHORT_5_6_5``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_INT_2_10_10_10_REV``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_INT_24_8``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_INT_10F_11F_11F_REV``: float with get
        abstract ``TEXTURETYPE_UNSIGNED_INT_5_9_9_9_REV``: float with get
        abstract ``TEXTURETYPE_FLOAT_32_UNSIGNED_INT_24_8_REV``: float with get
        abstract ``TEXTURETYPE_UNDEFINED``: float with get
        abstract ``TEXTURE_2D``: float with get
        abstract ``TEXTURE_2D_ARRAY``: float with get
        abstract ``TEXTURE_CUBE_MAP``: float with get
        abstract ``TEXTURE_CUBE_MAP_ARRAY``: float with get
        abstract ``TEXTURE_3D``: float with get
        abstract ``TEXTURE_NEAREST_SAMPLINGMODE``: float with get
        abstract ``TEXTURE_NEAREST_NEAREST``: float with get
        abstract ``TEXTURE_BILINEAR_SAMPLINGMODE``: float with get
        abstract ``TEXTURE_LINEAR_LINEAR``: float with get
        abstract ``TEXTURE_TRILINEAR_SAMPLINGMODE``: float with get
        abstract ``TEXTURE_LINEAR_LINEAR_MIPLINEAR``: float with get
        abstract ``TEXTURE_NEAREST_NEAREST_MIPNEAREST``: float with get
        abstract ``TEXTURE_NEAREST_LINEAR_MIPNEAREST``: float with get
        abstract ``TEXTURE_NEAREST_LINEAR_MIPLINEAR``: float with get
        abstract ``TEXTURE_NEAREST_LINEAR``: float with get
        abstract ``TEXTURE_NEAREST_NEAREST_MIPLINEAR``: float with get
        abstract ``TEXTURE_LINEAR_NEAREST_MIPNEAREST``: float with get
        abstract ``TEXTURE_LINEAR_NEAREST_MIPLINEAR``: float with get
        abstract ``TEXTURE_LINEAR_LINEAR_MIPNEAREST``: float with get
        abstract ``TEXTURE_LINEAR_NEAREST``: float with get
        abstract ``TEXTURE_EXPLICIT_MODE``: float with get
        abstract ``TEXTURE_SPHERICAL_MODE``: float with get
        abstract ``TEXTURE_PLANAR_MODE``: float with get
        abstract ``TEXTURE_CUBIC_MODE``: float with get
        abstract ``TEXTURE_PROJECTION_MODE``: float with get
        abstract ``TEXTURE_SKYBOX_MODE``: float with get
        abstract ``TEXTURE_INVCUBIC_MODE``: float with get
        abstract ``TEXTURE_EQUIRECTANGULAR_MODE``: float with get
        abstract ``TEXTURE_FIXED_EQUIRECTANGULAR_MODE``: float with get
        abstract ``TEXTURE_FIXED_EQUIRECTANGULAR_MIRRORED_MODE``: float with get
        abstract ``TEXTURE_FILTERING_QUALITY_OFFLINE``: float with get
        abstract ``TEXTURE_FILTERING_QUALITY_HIGH``: float with get
        abstract ``TEXTURE_FILTERING_QUALITY_MEDIUM``: float with get
        abstract ``TEXTURE_FILTERING_QUALITY_LOW``: float with get
        abstract ``SCALEMODE_FLOOR``: float with get
        abstract ``SCALEMODE_NEAREST``: float with get
        abstract ``SCALEMODE_CEILING``: float with get
        abstract ``MATERIAL_TextureDirtyFlag``: float with get
        abstract ``MATERIAL_LightDirtyFlag``: float with get
        abstract ``MATERIAL_FresnelDirtyFlag``: float with get
        abstract ``MATERIAL_AttributesDirtyFlag``: float with get
        abstract ``MATERIAL_MiscDirtyFlag``: float with get
        abstract ``MATERIAL_PrePassDirtyFlag``: float with get
        abstract ``MATERIAL_ImageProcessingDirtyFlag``: float with get
        abstract ``MATERIAL_AllDirtyFlag``: float with get
        abstract ``MATERIAL_TriangleFillMode``: float with get
        abstract ``MATERIAL_WireFrameFillMode``: float with get
        abstract ``MATERIAL_PointFillMode``: float with get
        abstract ``MATERIAL_PointListDrawMode``: float with get
        abstract ``MATERIAL_LineListDrawMode``: float with get
        abstract ``MATERIAL_LineLoopDrawMode``: float with get
        abstract ``MATERIAL_LineStripDrawMode``: float with get
        abstract ``MATERIAL_TriangleStripDrawMode``: float with get
        abstract ``MATERIAL_TriangleFanDrawMode``: float with get
        abstract ``MATERIAL_ClockWiseSideOrientation``: float with get
        abstract ``MATERIAL_CounterClockWiseSideOrientation``: float with get
        abstract ``MATERIAL_DIFFUSE_MODEL_E_OREN_NAYAR``: float with get
        abstract ``MATERIAL_DIFFUSE_MODEL_BURLEY``: float with get
        abstract ``MATERIAL_DIFFUSE_MODEL_LAMBERT``: float with get
        abstract ``MATERIAL_DIFFUSE_MODEL_LEGACY``: float with get
        abstract ``MATERIAL_DIELECTRIC_SPECULAR_MODEL_GLTF``: float with get
        abstract ``MATERIAL_DIELECTRIC_SPECULAR_MODEL_OPENPBR``: float with get
        abstract ``MATERIAL_CONDUCTOR_SPECULAR_MODEL_GLTF``: float with get
        abstract ``MATERIAL_CONDUCTOR_SPECULAR_MODEL_OPENPBR``: float with get
        abstract ``ACTION_NothingTrigger``: float with get
        abstract ``ACTION_OnPickTrigger``: float with get
        abstract ``ACTION_OnLeftPickTrigger``: float with get
        abstract ``ACTION_OnRightPickTrigger``: float with get
        abstract ``ACTION_OnCenterPickTrigger``: float with get
        abstract ``ACTION_OnPickDownTrigger``: float with get
        abstract ``ACTION_OnDoublePickTrigger``: float with get
        abstract ``ACTION_OnPickUpTrigger``: float with get
        abstract ``ACTION_OnPickOutTrigger``: float with get
        abstract ``ACTION_OnLongPressTrigger``: float with get
        abstract ``ACTION_OnPointerOverTrigger``: float with get
        abstract ``ACTION_OnPointerOutTrigger``: float with get
        abstract ``ACTION_OnEveryFrameTrigger``: float with get
        abstract ``ACTION_OnIntersectionEnterTrigger``: float with get
        abstract ``ACTION_OnIntersectionExitTrigger``: float with get
        abstract ``ACTION_OnKeyDownTrigger``: float with get
        abstract ``ACTION_OnKeyUpTrigger``: float with get
        abstract ``PARTICLES_BILLBOARDMODE_Y``: float with get
        abstract ``PARTICLES_BILLBOARDMODE_ALL``: float with get
        abstract ``PARTICLES_BILLBOARDMODE_STRETCHED``: float with get
        abstract ``PARTICLES_BILLBOARDMODE_STRETCHED_LOCAL``: float with get
        abstract ``MESHES_CULLINGSTRATEGY_STANDARD``: float with get
        abstract ``MESHES_CULLINGSTRATEGY_BOUNDINGSPHERE_ONLY``: float with get
        abstract ``MESHES_CULLINGSTRATEGY_OPTIMISTIC_INCLUSION``: float with get
        abstract ``MESHES_CULLINGSTRATEGY_OPTIMISTIC_INCLUSION_THEN_BSPHERE_ONLY``: float with get
        abstract ``SCENELOADER_NO_LOGGING``: float with get
        abstract ``SCENELOADER_MINIMAL_LOGGING``: float with get
        abstract ``SCENELOADER_SUMMARY_LOGGING``: float with get
        abstract ``SCENELOADER_DETAILED_LOGGING``: float with get
        abstract ``PREPASS_IRRADIANCE_LEGACY_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_POSITION_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_VELOCITY_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_REFLECTIVITY_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_COLOR_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_DEPTH_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_NORMAL_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_ALBEDO_SQRT_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_WORLD_NORMAL_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_LOCAL_POSITION_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_SCREENSPACE_DEPTH_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_VELOCITY_LINEAR_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_ALBEDO_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_NORMALIZED_VIEW_DEPTH_TEXTURE_TYPE``: float with get
        abstract ``PREPASS_IRRADIANCE_TEXTURE_TYPE``: float with get
        abstract ``BUFFER_CREATIONFLAG_READ``: float with get
        abstract ``BUFFER_CREATIONFLAG_WRITE``: float with get
        abstract ``BUFFER_CREATIONFLAG_READWRITE``: float with get
        abstract ``BUFFER_CREATIONFLAG_UNIFORM``: float with get
        abstract ``BUFFER_CREATIONFLAG_VERTEX``: float with get
        abstract ``BUFFER_CREATIONFLAG_INDEX``: float with get
        abstract ``BUFFER_CREATIONFLAG_STORAGE``: float with get
        abstract ``BUFFER_CREATIONFLAG_INDIRECT``: float with get
        abstract ``RENDERPASS_MAIN``: float with get
        abstract ``INPUT_ALT_KEY``: float with get
        abstract ``INPUT_CTRL_KEY``: float with get
        abstract ``INPUT_META_KEY1``: float with get
        abstract ``INPUT_META_KEY2``: float with get
        abstract ``INPUT_META_KEY3``: float with get
        abstract ``INPUT_SHIFT_KEY``: float with get
        abstract ``SNAPSHOTRENDERING_STANDARD``: float with get
        abstract ``SNAPSHOTRENDERING_FAST``: float with get
        abstract ``PERSPECTIVE_CAMERA``: float with get
        abstract ``ORTHOGRAPHIC_CAMERA``: float with get
        abstract ``FOVMODE_VERTICAL_FIXED``: float with get
        abstract ``FOVMODE_HORIZONTAL_FIXED``: float with get
        abstract ``RIG_MODE_NONE``: float with get
        abstract ``RIG_MODE_STEREOSCOPIC_ANAGLYPH``: float with get
        abstract ``RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_PARALLEL``: float with get
        abstract ``RIG_MODE_STEREOSCOPIC_SIDEBYSIDE_CROSSEYED``: float with get
        abstract ``RIG_MODE_STEREOSCOPIC_OVERUNDER``: float with get
        abstract ``RIG_MODE_STEREOSCOPIC_INTERLACED``: float with get
        abstract ``RIG_MODE_VR``: float with get
        abstract ``RIG_MODE_CUSTOM``: float with get
        abstract ``MAX_SUPPORTED_UV_SETS``: float with get
        abstract ``GL_ALPHA_EQUATION_ADD``: float with get
        abstract ``GL_ALPHA_EQUATION_MIN``: float with get
        abstract ``GL_ALPHA_EQUATION_MAX``: float with get
        abstract ``GL_ALPHA_EQUATION_SUBTRACT``: float with get
        abstract ``GL_ALPHA_EQUATION_REVERSE_SUBTRACT``: float with get
        abstract ``GL_ALPHA_FUNCTION_SRC``: float with get
        abstract ``GL_ALPHA_FUNCTION_ONE_MINUS_SRC_COLOR``: float with get
        abstract ``GL_ALPHA_FUNCTION_SRC_ALPHA``: float with get
        abstract ``GL_ALPHA_FUNCTION_ONE_MINUS_SRC_ALPHA``: float with get
        abstract ``GL_ALPHA_FUNCTION_DST_ALPHA``: float with get
        abstract ``GL_ALPHA_FUNCTION_ONE_MINUS_DST_ALPHA``: float with get
        abstract ``GL_ALPHA_FUNCTION_DST_COLOR``: float with get
        abstract ``GL_ALPHA_FUNCTION_ONE_MINUS_DST_COLOR``: float with get
        abstract ``GL_ALPHA_FUNCTION_SRC_ALPHA_SATURATED``: float with get
        abstract ``GL_ALPHA_FUNCTION_CONSTANT_COLOR``: float with get
        abstract ``GL_ALPHA_FUNCTION_ONE_MINUS_CONSTANT_COLOR``: float with get
        abstract ``GL_ALPHA_FUNCTION_CONSTANT_ALPHA``: float with get
        abstract ``GL_ALPHA_FUNCTION_ONE_MINUS_CONSTANT_ALPHA``: float with get
        abstract ``GL_ALPHA_FUNCTION_SRC1_COLOR``: float with get
        abstract ``GL_ALPHA_FUNCTION_ONE_MINUS_SRC1_COLOR``: float with get
        abstract ``GL_ALPHA_FUNCTION_SRC1_ALPHA``: float with get
        abstract ``GL_ALPHA_FUNCTION_ONE_MINUS_SRC1_ALPHA``: float with get
        abstract ``SnippetUrl``: string with get, set
        abstract ``FOGMODE_NONE``: float with get, set
        abstract ``FOGMODE_EXP``: float with get, set
        abstract ``FOGMODE_EXP2``: float with get, set
        abstract ``FOGMODE_LINEAR``: float with get, set
        abstract ``BYTE``: float with get, set
        abstract ``UNSIGNED_BYTE``: float with get, set
        abstract ``SHORT``: float with get, set
        abstract ``UNSIGNED_SHORT``: float with get, set
        abstract ``INT``: float with get, set
        abstract ``UNSIGNED_INT``: float with get, set
        abstract ``FLOAT``: float with get, set
        abstract ``HALF_FLOAT``: float with get, set
        abstract ``PositionKind``: string with get, set
        abstract ``NormalKind``: string with get, set
        abstract ``TangentKind``: string with get, set
        abstract ``UVKind``: string with get, set
        abstract ``UV2Kind``: string with get, set
        abstract ``UV3Kind``: string with get, set
        abstract ``UV4Kind``: string with get, set
        abstract ``UV5Kind``: string with get, set
        abstract ``UV6Kind``: string with get, set
        abstract ``ColorKind``: string with get, set
        abstract ``ColorInstanceKind``: string with get, set
        abstract ``MatricesIndicesKind``: string with get, set
        abstract ``MatricesWeightsKind``: string with get, set
        abstract ``MatricesIndicesExtraKind``: string with get, set
        abstract ``MatricesWeightsExtraKind``: string with get, set
        abstract ``ANIMATIONTYPE_FLOAT``: float with get
        abstract ``ANIMATIONTYPE_VECTOR3``: float with get
        abstract ``ANIMATIONTYPE_QUATERNION``: float with get
        abstract ``ANIMATIONTYPE_MATRIX``: float with get
        abstract ``ANIMATIONTYPE_COLOR3``: float with get
        abstract ``ANIMATIONTYPE_COLOR4``: float with get
        abstract ``ANIMATIONTYPE_VECTOR2``: float with get
        abstract ``ANIMATIONTYPE_SIZE``: float with get
        abstract ``ShadowMinZ``: float with get, set
        abstract ``ShadowMaxZ``: float with get, set
        abstract ``OUTLINELAYER_SAMPLING_TRIDIRECTIONAL``: float with get
        abstract ``OUTLINELAYER_SAMPLING_OCTADIRECTIONAL``: float with get

    [<Import("Constants", "@babylonjs/core/Engines/constants.js")>]
    let Constants: ConstantsStatic = jsNative

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

    /// @babylonjs/core/Misc/dataStorage
    [<AllowNullLiteral>]
    type DataStorage =
        interface end

    [<AllowNullLiteral>]
    type DataStorageStatic =
        [<EmitConstructor>] abstract Create: unit -> DataStorage
        abstract ``ReadString``: ``key``: string * ``defaultValue``: string -> string
        abstract ``WriteString``: ``key``: string * ``value``: string -> unit
        abstract ``ReadBoolean``: ``key``: string * ``defaultValue``: bool -> bool
        abstract ``WriteBoolean``: ``key``: string * ``value``: bool -> unit
        abstract ``ReadNumber``: ``key``: string * ``defaultValue``: float -> float
        abstract ``WriteNumber``: ``key``: string * ``value``: float -> unit
        abstract ``ReadJson``<'T>: ``key``: string * ``defaultValue``: 'T -> 'T
        abstract ``WriteJson``<'T>: ``key``: string * ``value``: 'T -> unit

    [<Import("DataStorage", "@babylonjs/core/Misc/dataStorage.js")>]
    let DataStorage: DataStorageStatic = jsNative

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

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type EasingFunction =
        abstract ``setEasingMode``: ``easingMode``: float -> unit
        abstract ``getEasingMode``: unit -> float
        abstract ``easeInCore``: ``gradient``: float -> float
        abstract ``ease``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type EasingFunctionStatic =
        [<EmitConstructor>] abstract Create: unit -> EasingFunction
        abstract ``EASINGMODE_EASEIN``: float with get
        abstract ``EASINGMODE_EASEOUT``: float with get
        abstract ``EASINGMODE_EASEINOUT``: float with get

    [<Import("EasingFunction", "@babylonjs/core/Animations/easing.js")>]
    let EasingFunction: EasingFunctionStatic = jsNative

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

    /// @babylonjs/core/Maths/halton2DSequence
    [<AllowNullLiteral>]
    type Halton2DSequence =
        abstract ``x``: float with get
        abstract ``y``: float with get
        abstract ``regenerate``: ``numSamples``: float -> unit
        abstract ``setDimensions``: ``width``: float * ``height``: float -> unit
        abstract ``next``: unit -> unit

    [<AllowNullLiteral>]
    type Halton2DSequenceStatic =
        [<EmitConstructor>] abstract Create: ``numSamples``: float * ?``baseX``: float * ?``baseY``: float * ?``width``: float * ?``height``: float -> Halton2DSequence

    [<Import("Halton2DSequence", "@babylonjs/core/Maths/halton2DSequence.js")>]
    let Halton2DSequence: Halton2DSequenceStatic = jsNative

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
    type KeyboardEventTypes =
        interface end

    [<AllowNullLiteral>]
    type KeyboardEventTypesStatic =
        [<EmitConstructor>] abstract Create: unit -> KeyboardEventTypes
        abstract ``KEYDOWN``: float with get
        abstract ``KEYUP``: float with get

    [<Import("KeyboardEventTypes", "@babylonjs/core/Events/keyboardEvents.js")>]
    let KeyboardEventTypes: KeyboardEventTypesStatic = jsNative

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

    /// @babylonjs/core/Lights/lightConstants
    [<AllowNullLiteral>]
    type LightConstants =
        interface end

    [<AllowNullLiteral>]
    type LightConstantsStatic =
        [<EmitConstructor>] abstract Create: unit -> LightConstants
        abstract ``FALLOFF_DEFAULT``: float with get
        abstract ``FALLOFF_PHYSICAL``: float with get
        abstract ``FALLOFF_GLTF``: float with get
        abstract ``FALLOFF_STANDARD``: float with get
        abstract ``LIGHTMAP_DEFAULT``: float with get
        abstract ``LIGHTMAP_SPECULAR``: float with get
        abstract ``LIGHTMAP_SHADOWSONLY``: float with get
        abstract ``INTENSITYMODE_AUTOMATIC``: float with get
        abstract ``INTENSITYMODE_LUMINOUSPOWER``: float with get
        abstract ``INTENSITYMODE_LUMINOUSINTENSITY``: float with get
        abstract ``INTENSITYMODE_ILLUMINANCE``: float with get
        abstract ``INTENSITYMODE_LUMINANCE``: float with get
        abstract ``LIGHTTYPEID_POINTLIGHT``: float with get
        abstract ``LIGHTTYPEID_DIRECTIONALLIGHT``: float with get
        abstract ``LIGHTTYPEID_SPOTLIGHT``: float with get
        abstract ``LIGHTTYPEID_HEMISPHERICLIGHT``: float with get
        abstract ``LIGHTTYPEID_RECT_AREALIGHT``: float with get
        abstract ``LIGHTTYPEID_CLUSTERED_CONTAINER``: float with get
        abstract ``CompareLightsPriority``: ``a``: BabylonjsBindings.SimpleInterfaces.ISortableLight * ``b``: BabylonjsBindings.SimpleInterfaces.ISortableLight -> float

    [<Import("LightConstants", "@babylonjs/core/Lights/lightConstants.js")>]
    let LightConstants: LightConstantsStatic = jsNative

    /// Function-valued Logger.OnNewCacheEntry property.
    [<AllowNullLiteral>]
    type LoggerOnNewCacheEntryCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``entry``: string -> unit

    /// Function-valued Logger.Log property.
    [<AllowNullLiteral>]
    type LoggerLogCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``message``: U2<string, ResizeArray<obj>> * ?``limit``: float -> unit

    /// Function-valued Logger.Warn property.
    [<AllowNullLiteral>]
    type LoggerWarnCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``message``: U2<string, ResizeArray<obj>> * ?``limit``: float -> unit

    /// Function-valued Logger.Error property.
    [<AllowNullLiteral>]
    type LoggerErrorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``message``: U2<string, ResizeArray<obj>> * ?``limit``: float -> unit

    /// @babylonjs/core/Misc/logger
    [<AllowNullLiteral>]
    type Logger =
        interface end

    [<AllowNullLiteral>]
    type LoggerStatic =
        [<EmitConstructor>] abstract Create: unit -> Logger
        abstract ``NoneLogLevel``: float with get
        abstract ``MessageLogLevel``: float with get
        abstract ``WarningLogLevel``: float with get
        abstract ``ErrorLogLevel``: float with get
        abstract ``AllLogLevel``: float with get
        abstract ``MessageLimitReached``: string with get, set
        abstract ``errorsCount``: float with get, set
        abstract ``OnNewCacheEntry``: LoggerOnNewCacheEntryCallback with get, set
        abstract ``Log``: LoggerLogCallback with get, set
        abstract ``Warn``: LoggerWarnCallback with get, set
        abstract ``Error``: LoggerErrorCallback with get, set
        abstract ``ClearLogCache``: unit -> unit
        abstract ``LogCache``: string with get
        abstract ``LogLevels``: float with set

    [<Import("Logger", "@babylonjs/core/Misc/logger.js")>]
    let Logger: LoggerStatic = jsNative

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

    /// @babylonjs/core/Events/pointerEvents
    [<AllowNullLiteral>]
    type PointerEventTypes =
        interface end

    [<AllowNullLiteral>]
    type PointerEventTypesStatic =
        [<EmitConstructor>] abstract Create: unit -> PointerEventTypes
        abstract ``POINTERDOWN``: float with get
        abstract ``POINTERUP``: float with get
        abstract ``POINTERMOVE``: float with get
        abstract ``POINTERWHEEL``: float with get
        abstract ``POINTERPICK``: float with get
        abstract ``POINTERTAP``: float with get
        abstract ``POINTERDOUBLETAP``: float with get

    [<Import("PointerEventTypes", "@babylonjs/core/Events/pointerEvents.js")>]
    let PointerEventTypes: PointerEventTypesStatic = jsNative

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

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type SceneComponentConstants =
        interface end

    [<AllowNullLiteral>]
    type SceneComponentConstantsStatic =
        [<EmitConstructor>] abstract Create: unit -> SceneComponentConstants
        abstract ``NAME_EFFECTLAYER``: string with get
        abstract ``NAME_LAYER``: string with get
        abstract ``NAME_LENSFLARESYSTEM``: string with get
        abstract ``NAME_BOUNDINGBOXRENDERER``: string with get
        abstract ``NAME_PARTICLESYSTEM``: string with get
        abstract ``NAME_GAMEPAD``: string with get
        abstract ``NAME_SIMPLIFICATIONQUEUE``: string with get
        abstract ``NAME_GEOMETRYBUFFERRENDERER``: string with get
        abstract ``NAME_PREPASSRENDERER``: string with get
        abstract ``NAME_DEPTHRENDERER``: string with get
        abstract ``NAME_DEPTHPEELINGRENDERER``: string with get
        abstract ``NAME_POSTPROCESSRENDERPIPELINEMANAGER``: string with get
        abstract ``NAME_SPRITE``: string with get
        abstract ``NAME_SUBSURFACE``: string with get
        abstract ``NAME_OUTLINERENDERER``: string with get
        abstract ``NAME_PROCEDURALTEXTURE``: string with get
        abstract ``NAME_SHADOWGENERATOR``: string with get
        abstract ``NAME_OCTREE``: string with get
        abstract ``NAME_PHYSICSENGINE``: string with get
        abstract ``NAME_AUDIO``: string with get
        abstract ``NAME_FLUIDRENDERER``: string with get
        abstract ``NAME_IBLCDFGENERATOR``: string with get
        abstract ``NAME_CLUSTEREDLIGHTING``: string with get
        abstract ``STEP_ISREADYFORMESH_EFFECTLAYER``: float with get
        abstract ``STEP_ISREADYFORMESH_DEPTHRENDERER``: float with get
        abstract ``STEP_BEFOREEVALUATEACTIVEMESH_BOUNDINGBOXRENDERER``: float with get
        abstract ``STEP_EVALUATESUBMESH_BOUNDINGBOXRENDERER``: float with get
        abstract ``STEP_PREACTIVEMESH_BOUNDINGBOXRENDERER``: float with get
        abstract ``STEP_CAMERADRAWRENDERTARGET_EFFECTLAYER``: float with get
        abstract ``STEP_BEFORECAMERADRAW_PREPASS``: float with get
        abstract ``STEP_BEFORECAMERADRAW_EFFECTLAYER``: float with get
        abstract ``STEP_BEFORECAMERADRAW_LAYER``: float with get
        abstract ``STEP_BEFORERENDERTARGETDRAW_PREPASS``: float with get
        abstract ``STEP_BEFORERENDERTARGETDRAW_LAYER``: float with get
        abstract ``STEP_BEFORERENDERINGMESH_PREPASS``: float with get
        abstract ``STEP_BEFORERENDERINGMESH_OUTLINE``: float with get
        abstract ``STEP_AFTERRENDERINGMESH_PREPASS``: float with get
        abstract ``STEP_AFTERRENDERINGMESH_OUTLINE``: float with get
        abstract ``STEP_AFTERRENDERINGGROUPDRAW_EFFECTLAYER_DRAW``: float with get
        abstract ``STEP_AFTERRENDERINGGROUPDRAW_BOUNDINGBOXRENDERER``: float with get
        abstract ``STEP_BEFORECAMERAUPDATE_SIMPLIFICATIONQUEUE``: float with get
        abstract ``STEP_BEFORECLEAR_PROCEDURALTEXTURE``: float with get
        abstract ``STEP_BEFORECLEAR_PREPASS``: float with get
        abstract ``STEP_BEFORERENDERTARGETCLEAR_PREPASS``: float with get
        abstract ``STEP_AFTERRENDERTARGETDRAW_PREPASS``: float with get
        abstract ``STEP_AFTERRENDERTARGETDRAW_LAYER``: float with get
        abstract ``STEP_AFTERCAMERADRAW_PREPASS``: float with get
        abstract ``STEP_AFTERCAMERADRAW_EFFECTLAYER``: float with get
        abstract ``STEP_AFTERCAMERADRAW_LENSFLARESYSTEM``: float with get
        abstract ``STEP_AFTERCAMERADRAW_EFFECTLAYER_DRAW``: float with get
        abstract ``STEP_AFTERCAMERADRAW_LAYER``: float with get
        abstract ``STEP_AFTERCAMERADRAW_FLUIDRENDERER``: float with get
        abstract ``STEP_AFTERCAMERAPOSTPROCESS_LAYER``: float with get
        abstract ``STEP_AFTERRENDERTARGETPOSTPROCESS_LAYER``: float with get
        abstract ``STEP_AFTERRENDER_AUDIO``: float with get
        abstract ``STEP_GATHERRENDERTARGETS_DEPTHRENDERER``: float with get
        abstract ``STEP_GATHERRENDERTARGETS_GEOMETRYBUFFERRENDERER``: float with get
        abstract ``STEP_GATHERRENDERTARGETS_SHADOWGENERATOR``: float with get
        abstract ``STEP_GATHERRENDERTARGETS_POSTPROCESSRENDERPIPELINEMANAGER``: float with get
        abstract ``STEP_GATHERACTIVECAMERARENDERTARGETS_DEPTHRENDERER``: float with get
        abstract ``STEP_GATHERACTIVECAMERARENDERTARGETS_FLUIDRENDERER``: float with get
        abstract ``STEP_GATHERACTIVECAMERARENDERTARGETS_CLUSTEREDLIGHTING``: float with get
        abstract ``STEP_POINTERMOVE_SPRITE``: float with get
        abstract ``STEP_POINTERDOWN_SPRITE``: float with get
        abstract ``STEP_POINTERUP_SPRITE``: float with get

    [<Import("SceneComponentConstants", "@babylonjs/core/sceneComponent.js")>]
    let SceneComponentConstants: SceneComponentConstantsStatic = jsNative

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

    /// @babylonjs/core/States/stencilState
    [<AllowNullLiteral>]
    type StencilState =
        abstract ``reset``: unit -> unit
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
        abstract ``stencilFunc``: float with get, set
        abstract ``stencilBackFunc``: float with get, set
        abstract ``stencilFuncRef``: float with get, set
        abstract ``stencilFuncMask``: float with get, set
        abstract ``stencilOpStencilFail``: float with get, set
        abstract ``stencilOpDepthFail``: float with get, set
        abstract ``stencilOpStencilDepthPass``: float with get, set
        abstract ``stencilBackOpStencilFail``: float with get, set
        abstract ``stencilBackOpDepthFail``: float with get, set
        abstract ``stencilBackOpStencilDepthPass``: float with get, set
        abstract ``stencilMask``: float with get, set
        abstract ``stencilTest``: bool with get, set

    [<AllowNullLiteral>]
    type StencilStateStatic =
        [<EmitConstructor>] abstract Create: unit -> StencilState
        abstract ``ALWAYS``: float with get
        abstract ``KEEP``: float with get
        abstract ``REPLACE``: float with get

    [<Import("StencilState", "@babylonjs/core/States/stencilState.js")>]
    let StencilState: StencilStateStatic = jsNative

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

    /// Uncurried function-valued argument used by ThinSprite.
    type ThinSpriteMethod29Parameter5Callback = System.Action

    /// @babylonjs/core/Sprites/thinSprite
    [<AllowNullLiteral>]
    type ThinSprite =
        abstract ``cellIndex``: float with get, set
        abstract ``cellRef``: string with get, set
        abstract ``position``: BabylonjsBindings.SimpleInterfaces.IVector3Like with get, set
        abstract ``color``: BabylonjsBindings.SimpleInterfaces.IColor4Like with get, set
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``angle``: float with get, set
        abstract ``invertU``: bool with get, set
        abstract ``invertV``: bool with get, set
        abstract ``isVisible``: bool with get, set
        abstract ``_xOffset``: float with get, set
        abstract ``_yOffset``: float with get, set
        abstract ``_xSize``: float with get, set
        abstract ``_ySize``: float with get, set
        abstract ``playAnimation``: ``from``: float * ``to``: float * ``loop``: bool * ``delay``: float * ``onAnimationEnd``: ThinSpriteMethod29Parameter5Callback option -> unit
        abstract ``stopAnimation``: unit -> unit
        abstract ``_animate``: ``deltaTime``: float -> unit
        abstract ``animationStarted``: bool with get
        abstract ``fromIndex``: float with get
        abstract ``toIndex``: float with get
        abstract ``loopAnimation``: bool with get
        abstract ``delay``: float with get

    [<AllowNullLiteral>]
    type ThinSpriteStatic =
        [<EmitConstructor>] abstract Create: unit -> ThinSprite

    [<Import("ThinSprite", "@babylonjs/core/Sprites/thinSprite.js")>]
    let ThinSprite: ThinSpriteStatic = jsNative

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

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type BackEase =
        inherit EasingFunction
        abstract ``amplitude``: float with get, set
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type BackEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: ?``amplitude``: float -> BackEase

    [<Import("BackEase", "@babylonjs/core/Animations/easing.js")>]
    let BackEase: BackEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type BezierCurveEase =
        inherit EasingFunction
        abstract ``x1``: float with get, set
        abstract ``y1``: float with get, set
        abstract ``x2``: float with get, set
        abstract ``y2``: float with get, set
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type BezierCurveEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: ?``x1``: float * ?``y1``: float * ?``x2``: float * ?``y2``: float -> BezierCurveEase

    [<Import("BezierCurveEase", "@babylonjs/core/Animations/easing.js")>]
    let BezierCurveEase: BezierCurveEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type BounceEase =
        inherit EasingFunction
        abstract ``bounces``: float with get, set
        abstract ``bounciness``: float with get, set
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type BounceEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: ?``bounces``: float * ?``bounciness``: float -> BounceEase

    [<Import("BounceEase", "@babylonjs/core/Animations/easing.js")>]
    let BounceEase: BounceEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type CircleEase =
        inherit EasingFunction
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type CircleEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: unit -> CircleEase

    [<Import("CircleEase", "@babylonjs/core/Animations/easing.js")>]
    let CircleEase: CircleEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type CubicEase =
        inherit EasingFunction
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type CubicEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: unit -> CubicEase

    [<Import("CubicEase", "@babylonjs/core/Animations/easing.js")>]
    let CubicEase: CubicEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type ElasticEase =
        inherit EasingFunction
        abstract ``oscillations``: float with get, set
        abstract ``springiness``: float with get, set
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type ElasticEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: ?``oscillations``: float * ?``springiness``: float -> ElasticEase

    [<Import("ElasticEase", "@babylonjs/core/Animations/easing.js")>]
    let ElasticEase: ElasticEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type ExponentialEase =
        inherit EasingFunction
        abstract ``exponent``: float with get, set
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type ExponentialEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: ?``exponent``: float -> ExponentialEase

    [<Import("ExponentialEase", "@babylonjs/core/Animations/easing.js")>]
    let ExponentialEase: ExponentialEaseStatic = jsNative

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

    /// Uncurried function-valued argument used by Observer.
    type ObserverConstructor7Parameter1Callback<'T> = System.Action<'T, EventState>

    /// Function-valued Observer.callback property.
    [<AllowNullLiteral>]
    type ObserverCallbackCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ``eventData``: 'T * ``eventState``: EventState -> unit

    /// Function-valued Observer._remove property.
    [<AllowNullLiteral>]
    type ObserverRemoveCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ?``defer``: bool -> unit

    /// @babylonjs/core/Misc/observable.pure
    [<AllowNullLiteral>]
    type Observer<'T> =
        abstract ``callback``: ObserverCallbackCallback<'T> with get, set
        abstract ``mask``: float with get, set
        abstract ``scope``: obj with get, set
        abstract ``_willBeUnregistered``: bool with get, set
        abstract ``unregisterOnNextCall``: bool with get, set
        abstract ``_remove``: ObserverRemoveCallback<'T> option with get, set
        abstract ``remove``: ?``defer``: bool -> unit

    [<AllowNullLiteral>]
    type ObserverStatic =
        [<EmitConstructor>] abstract Create<'T>: ``callback``: ObserverConstructor7Parameter1Callback<'T> * ``mask``: float * ?``scope``: obj -> Observer<'T>

    [<Import("Observer", "@babylonjs/core/Misc/observable.pure.js")>]
    let Observer: ObserverStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type PowerEase =
        inherit EasingFunction
        abstract ``power``: float with get, set
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type PowerEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: ?``power``: float -> PowerEase

    [<Import("PowerEase", "@babylonjs/core/Animations/easing.js")>]
    let PowerEase: PowerEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type QuadraticEase =
        inherit EasingFunction
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type QuadraticEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: unit -> QuadraticEase

    [<Import("QuadraticEase", "@babylonjs/core/Animations/easing.js")>]
    let QuadraticEase: QuadraticEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type QuarticEase =
        inherit EasingFunction
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type QuarticEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: unit -> QuarticEase

    [<Import("QuarticEase", "@babylonjs/core/Animations/easing.js")>]
    let QuarticEase: QuarticEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type QuinticEase =
        inherit EasingFunction
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type QuinticEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: unit -> QuinticEase

    [<Import("QuinticEase", "@babylonjs/core/Animations/easing.js")>]
    let QuinticEase: QuinticEaseStatic = jsNative

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type SineEase =
        inherit EasingFunction
        abstract ``easeInCore``: ``gradient``: float -> float

    [<AllowNullLiteral>]
    type SineEaseStatic =
        inherit EasingFunctionStatic
        [<EmitConstructor>] abstract Create: unit -> SineEase

    [<Import("SineEase", "@babylonjs/core/Animations/easing.js")>]
    let SineEase: SineEaseStatic = jsNative

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

    /// Uncurried function-valued argument used by Observable.
    type ObservableConstructor10Parameter1Callback<'T> = System.Action<Observer<'T>>

    /// Uncurried function-valued argument used by Observable.
    type ObservableMethod13Parameter1Callback<'T> = System.Action<'T, EventState>

    /// Uncurried function-valued argument used by Observable.
    type ObservableMethod16Parameter1Callback<'T> = System.Action<'T, EventState>

    /// Uncurried function-valued argument used by Observable.
    type ObservableMethod18Parameter1Callback<'T> = System.Action<'T, EventState>

    /// @babylonjs/core/Misc/observable.pure
    [<AllowNullLiteral>]
    type Observable<'T> =
        abstract ``notifyIfTriggered``: bool with get, set
        abstract ``_eventState``: EventState with get, set
        abstract ``add``: ?``callback``: ObservableMethod13Parameter1Callback<'T> * ?``mask``: float * ?``insertFirst``: bool * ?``scope``: obj * ?``unregisterOnFirstCall``: bool -> Observer<'T> option
        abstract ``addOnce``: ?``callback``: ObservableMethod16Parameter1Callback<'T> -> Observer<'T> option
        abstract ``remove``: ``observer``: Observer<'T> option -> bool
        abstract ``removeCallback``: ``callback``: ObservableMethod18Parameter1Callback<'T> * ?``scope``: obj -> bool
        abstract ``_deferUnregister``: ``observer``: Observer<'T> -> unit
        abstract ``makeObserverTopPriority``: ``observer``: Observer<'T> -> unit
        abstract ``makeObserverBottomPriority``: ``observer``: Observer<'T> -> unit
        abstract ``notifyObservers``: ``eventData``: 'T * ?``mask``: float * ?``target``: obj * ?``currentTarget``: obj * ?``userInfo``: obj -> bool
        abstract ``notifyObserver``: ``observer``: Observer<'T> * ``eventData``: 'T * ?``mask``: float -> unit
        abstract ``hasObservers``: unit -> bool
        abstract ``clear``: unit -> unit
        abstract ``cleanLastNotifiedState``: unit -> unit
        abstract ``clone``: unit -> Observable<'T>
        abstract ``hasSpecificMask``: ?``mask``: float -> bool
        abstract ``observers``: ResizeArray<Observer<'T>> with get

    [<AllowNullLiteral>]
    type ObservableStatic =
        [<EmitConstructor>] abstract Create<'T>: ?``onObserverAdded``: ObservableConstructor10Parameter1Callback<'T> * ?``notifyIfTriggered``: bool -> Observable<'T>
        abstract ``FromPromise``<'T, 'E>: ``promise``: JS.Promise<'T> * ?``onErrorObservable``: Observable<'E> -> Observable<'T>

    [<Import("Observable", "@babylonjs/core/Misc/observable.pure.js")>]
    let Observable: ObservableStatic = jsNative

    /// Uncurried function-valued argument used by DualShockPad.
    type DualShockPadMethod28Parameter1Callback = System.Action<float>

    /// Uncurried function-valued argument used by DualShockPad.
    type DualShockPadMethod29Parameter1Callback = System.Action<float>

    /// Uncurried function-valued argument used by DualShockPad.
    type DualShockPadMethod34Parameter1Callback = System.Action<BabylonjsBindings.Enums.DualShockButton>

    /// Uncurried function-valued argument used by DualShockPad.
    type DualShockPadMethod35Parameter1Callback = System.Action<BabylonjsBindings.Enums.DualShockButton>

    /// Uncurried function-valued argument used by DualShockPad.
    type DualShockPadMethod36Parameter1Callback = System.Action<BabylonjsBindings.Enums.DualShockDpad>

    /// Uncurried function-valued argument used by DualShockPad.
    type DualShockPadMethod37Parameter1Callback = System.Action<BabylonjsBindings.Enums.DualShockDpad>

    /// @babylonjs/core/Gamepads/dualShockGamepad
    [<AllowNullLiteral>]
    type DualShockPad =
        inherit Gamepad
        abstract ``onButtonDownObservable``: Observable<BabylonjsBindings.Enums.DualShockButton> with get, set
        abstract ``onButtonUpObservable``: Observable<BabylonjsBindings.Enums.DualShockButton> with get, set
        abstract ``onPadDownObservable``: Observable<BabylonjsBindings.Enums.DualShockDpad> with get, set
        abstract ``onPadUpObservable``: Observable<BabylonjsBindings.Enums.DualShockDpad> with get, set
        abstract ``onlefttriggerchanged``: ``callback``: DualShockPadMethod28Parameter1Callback -> unit
        abstract ``onrighttriggerchanged``: ``callback``: DualShockPadMethod29Parameter1Callback -> unit
        abstract ``onbuttondown``: ``callback``: DualShockPadMethod34Parameter1Callback -> unit
        abstract ``onbuttonup``: ``callback``: DualShockPadMethod35Parameter1Callback -> unit
        abstract ``ondpaddown``: ``callback``: DualShockPadMethod36Parameter1Callback -> unit
        abstract ``ondpadup``: ``callback``: DualShockPadMethod37Parameter1Callback -> unit
        abstract ``update``: unit -> unit
        abstract ``dispose``: unit -> unit
        abstract ``leftTrigger``: float with get, set
        abstract ``rightTrigger``: float with get, set
        abstract ``buttonCross``: float with get, set
        abstract ``buttonCircle``: float with get, set
        abstract ``buttonSquare``: float with get, set
        abstract ``buttonTriangle``: float with get, set
        abstract ``buttonOptions``: float with get, set
        abstract ``buttonShare``: float with get, set
        abstract ``buttonL1``: float with get, set
        abstract ``buttonR1``: float with get, set
        abstract ``buttonLeftStick``: float with get, set
        abstract ``buttonRightStick``: float with get, set
        abstract ``dPadUp``: float with get, set
        abstract ``dPadDown``: float with get, set
        abstract ``dPadLeft``: float with get, set
        abstract ``dPadRight``: float with get, set

    [<AllowNullLiteral>]
    type DualShockPadStatic =
        inherit GamepadStatic
        [<EmitConstructor>] abstract Create: ``id``: string * ``index``: float * ``gamepad``: obj -> DualShockPad

    [<Import("DualShockPad", "@babylonjs/core/Gamepads/dualShockGamepad.js")>]
    let DualShockPad: DualShockPadStatic = jsNative

    /// Uncurried function-valued argument used by GenericPad.
    type GenericPadMethod6Parameter1Callback = System.Action<float>

    /// Uncurried function-valued argument used by GenericPad.
    type GenericPadMethod7Parameter1Callback = System.Action<float>

    /// @babylonjs/core/Gamepads/gamepad
    [<AllowNullLiteral>]
    type GenericPad =
        inherit Gamepad
        abstract ``onButtonDownObservable``: Observable<float> with get, set
        abstract ``onButtonUpObservable``: Observable<float> with get, set
        abstract ``onbuttondown``: ``callback``: GenericPadMethod6Parameter1Callback -> unit
        abstract ``onbuttonup``: ``callback``: GenericPadMethod7Parameter1Callback -> unit
        abstract ``update``: unit -> unit
        abstract ``dispose``: unit -> unit

    [<AllowNullLiteral>]
    type GenericPadStatic =
        inherit GamepadStatic
        [<EmitConstructor>] abstract Create: ``id``: string * ``index``: float * ``browserGamepad``: obj -> GenericPad

    [<Import("GenericPad", "@babylonjs/core/Gamepads/gamepad.js")>]
    let GenericPad: GenericPadStatic = jsNative

    /// Uncurried function-valued argument used by MultiObserver.
    type MultiObserverMethod4Parameter2Callback<'T> = System.Action<'T, EventState>

    /// @babylonjs/core/Misc/observable.extensions.pure
    [<AllowNullLiteral>]
    type MultiObserver<'T> =
        abstract ``dispose``: unit -> unit

    [<AllowNullLiteral>]
    type MultiObserverStatic =
        [<EmitConstructor>] abstract Create<'T>: unit -> MultiObserver<'T>
        abstract ``Watch``<'T>: ``observables``: ResizeArray<Observable<'T>> * ``callback``: MultiObserverMethod4Parameter2Callback<'T> * ?``mask``: float * ?``scope``: obj -> MultiObserver<'T>

    [<Import("MultiObserver", "@babylonjs/core/Misc/observable.extensions.pure.js")>]
    let MultiObserver: MultiObserverStatic = jsNative

    /// Uncurried function-valued argument used by Xbox360Pad.
    type Xbox360PadMethod29Parameter1Callback = System.Action<float>

    /// Uncurried function-valued argument used by Xbox360Pad.
    type Xbox360PadMethod30Parameter1Callback = System.Action<float>

    /// Uncurried function-valued argument used by Xbox360Pad.
    type Xbox360PadMethod35Parameter1Callback = System.Action<BabylonjsBindings.Enums.Xbox360Button>

    /// Uncurried function-valued argument used by Xbox360Pad.
    type Xbox360PadMethod36Parameter1Callback = System.Action<BabylonjsBindings.Enums.Xbox360Button>

    /// Uncurried function-valued argument used by Xbox360Pad.
    type Xbox360PadMethod37Parameter1Callback = System.Action<BabylonjsBindings.Enums.Xbox360Dpad>

    /// Uncurried function-valued argument used by Xbox360Pad.
    type Xbox360PadMethod38Parameter1Callback = System.Action<BabylonjsBindings.Enums.Xbox360Dpad>

    /// @babylonjs/core/Gamepads/xboxGamepad
    [<AllowNullLiteral>]
    type Xbox360Pad =
        inherit Gamepad
        abstract ``onButtonDownObservable``: Observable<BabylonjsBindings.Enums.Xbox360Button> with get, set
        abstract ``onButtonUpObservable``: Observable<BabylonjsBindings.Enums.Xbox360Button> with get, set
        abstract ``onPadDownObservable``: Observable<BabylonjsBindings.Enums.Xbox360Dpad> with get, set
        abstract ``onPadUpObservable``: Observable<BabylonjsBindings.Enums.Xbox360Dpad> with get, set
        abstract ``onlefttriggerchanged``: ``callback``: Xbox360PadMethod29Parameter1Callback -> unit
        abstract ``onrighttriggerchanged``: ``callback``: Xbox360PadMethod30Parameter1Callback -> unit
        abstract ``onbuttondown``: ``callback``: Xbox360PadMethod35Parameter1Callback -> unit
        abstract ``onbuttonup``: ``callback``: Xbox360PadMethod36Parameter1Callback -> unit
        abstract ``ondpaddown``: ``callback``: Xbox360PadMethod37Parameter1Callback -> unit
        abstract ``ondpadup``: ``callback``: Xbox360PadMethod38Parameter1Callback -> unit
        abstract ``update``: unit -> unit
        abstract ``dispose``: unit -> unit
        abstract ``leftTrigger``: float with get, set
        abstract ``rightTrigger``: float with get, set
        abstract ``buttonA``: float with get, set
        abstract ``buttonB``: float with get, set
        abstract ``buttonX``: float with get, set
        abstract ``buttonY``: float with get, set
        abstract ``buttonStart``: float with get, set
        abstract ``buttonBack``: float with get, set
        abstract ``buttonLB``: float with get, set
        abstract ``buttonRB``: float with get, set
        abstract ``buttonLeftStick``: float with get, set
        abstract ``buttonRightStick``: float with get, set
        abstract ``dPadUp``: float with get, set
        abstract ``dPadDown``: float with get, set
        abstract ``dPadLeft``: float with get, set
        abstract ``dPadRight``: float with get, set

    [<AllowNullLiteral>]
    type Xbox360PadStatic =
        inherit GamepadStatic
        [<EmitConstructor>] abstract Create: ``id``: string * ``index``: float * ``gamepad``: obj * ?``xboxOne``: bool -> Xbox360Pad

    [<Import("Xbox360Pad", "@babylonjs/core/Gamepads/xboxGamepad.js")>]
    let Xbox360Pad: Xbox360PadStatic = jsNative
