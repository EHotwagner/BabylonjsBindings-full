// REVIEWED MAINTAINED SOURCE — exact declaration review and compile proof recorded in generated-candidates
namespace BabylonjsBindings

open Fable.Core

/// Exact primitive aliases and dependency-free callbacks exported by Babylon.js 9.19.0.
module TypeAliases =

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectde9f6c1b6b0f =
        abstract ``width``: System.Double with get, set
        abstract ``height``: System.Double with get, set
        abstract ``depth``: System.Double option with get, set
        abstract ``layers``: System.Double option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject38fb0477dfc1 =
        abstract ``mergeRuntimeAnimations``: bool with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectc2a40b3b5670 =
        abstract ``mergeRuntimeAnimations``: bool with get, set
        abstract ``mergeKeyFrames``: bool with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject4d81806d37f7 =
        [<EmitIndexer>] abstract Item: ``key``: BabylonjsBindings.StringEnums.WebXRBodyJoint -> string option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectfe6bed7521ea =
        [<EmitIndexer>] abstract Item: ``key``: BabylonjsBindings.StringEnums.WebXRHandJoint -> string with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject1818ddef00ab =
        [<EmitIndexer>] abstract Item: ``key``: string -> BabylonjsBindings.ObjectTypes.ComputeBindingLocation with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject6d99c3efc0a5 =
        [<EmitIndexer>] abstract Item: ``key``: string -> AliasObjectf9837e5af8ce with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject48d35bfa5654 =
        abstract ``size``: BabylonjsBindings.TypeAliases.TextureSize with get, set
        abstract ``options``: BabylonjsBindings.ObjectTypes.FrameGraphTextureOptions with get, set
        abstract ``sizeIsPercentage``: bool with get, set
        abstract ``isHistoryTexture``: bool option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject5ddd70d906f6 =
        abstract ``size``: AliasObject38742680c103 with get, set
        abstract ``options``: BabylonjsBindings.ObjectTypes.FrameGraphTextureOptions with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject1508f3d151ec =
        abstract ``leftColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``rightColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``bias``: System.Double option with get, set
        abstract ``power``: System.Double option with get, set
        abstract ``isEnabled``: bool option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject680fbaa03d9c =
        abstract ``defineNames``: AliasObject1aaf511ae5b6 option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject38742680c103 =
        abstract ``width``: System.Double with get, set
        abstract ``height``: System.Double with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectf9837e5af8ce =
        abstract ``type``: BabylonjsBindings.Enums.ComputeBindingType with get, set
        abstract ``object``: obj with get, set
        abstract ``indexInGroupEntries``: System.Double option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject1aaf511ae5b6 =
        [<EmitIndexer>] abstract Item: ``name``: string -> AliasObjectaa4e4b93b6db with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectaa4e4b93b6db =
        abstract ``type``: string with get, set
        abstract ``default``: obj with get, set

    /// @babylonjs/core/Behaviors/Cameras/interpolatingBehavior
    type AllowedAnimValue = U8<System.Double, BabylonjsBindings.SimpleInterfaces.IVector2Like, BabylonjsBindings.SimpleInterfaces.IVector3Like, BabylonjsBindings.SimpleInterfaces.IQuaternionLike, BabylonjsBindings.SimpleInterfaces.IMatrixLike, BabylonjsBindings.SimpleInterfaces.IColor3Like, BabylonjsBindings.SimpleInterfaces.IColor4Like, BabylonjsBindings.ObjectTypes.SizeLike> option

    /// @babylonjs/core/Animations/animation.optimizations
    type AnimationOptimization = U2<AliasObject38fb0477dfc1, AliasObjectc2a40b3b5670>

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    type ComputeBindingList = AliasObject6d99c3efc0a5

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    type ComputeBindingMapping = AliasObject1818ddef00ab

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    type DecoderMessage = U3<BabylonjsBindings.SimpleInterfaces.IDecodeMeshDoneMessage, BabylonjsBindings.SimpleInterfaces.IIndicesMessage, BabylonjsBindings.SimpleInterfaces.IAttributeMessage>

    /// @babylonjs/core/types
    type double = System.Double

    /// @babylonjs/core/types
    type Empty = ResizeArray<BabylonjsBindings.SimpleClasses.Never>

    /// @babylonjs/core/types
    type float = System.Double

    /// @babylonjs/core/types
    type FloatArray = U2<ResizeArray<System.Double>, JS.Float32Array>
    type DeepImmutableFloatArray = U2<System.Collections.Generic.IReadOnlyList<System.Double>, JS.Float32Array>

    /// @babylonjs/core/FlowGraph/utils
    type FlowGraphNumber = U2<System.Double, BabylonjsBindings.SimpleClasses.FlowGraphInteger>

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    type FrameGraphTextureCreationOptions = AliasObject48d35bfa5654

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    type FrameGraphTextureDescription = AliasObject5ddd70d906f6

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    type FrameGraphTextureHandle = System.Double

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderAnimation
    [<AllowNullLiteral>]
    type GetValueFn =
        [<Emit("$0($1...)")>] abstract Invoke: target: obj * source: JS.Float32Array * offset: System.Double * scale: System.Double -> obj

    /// @babylonjs/core/Meshes/Builders/goldbergBuilder
    [<AllowNullLiteral>]
    type GoldbergCreationOption =
        inherit BabylonjsBindings.ObjectTypes.GoldbergVertexDataOption
        abstract ``m``: System.Double option with get, set
        abstract ``n``: System.Double option with get, set
        abstract ``updatable``: bool option with get, set

    /// @babylonjs/core/Materials/fresnelParameters.pure
    type IFresnelParametersCreationOptions = AliasObject1508f3d151ec

    /// @babylonjs/core/types
    type IndicesArray = U4<ResizeArray<System.Double>, JS.Int32Array, JS.Uint32Array, JS.Uint16Array>

    /// @babylonjs/core/types
    type int = System.Double

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginGetDefineNames = AliasObject680fbaa03d9c

    /// @babylonjs/core/Engines/Native/nativeDataStream
    type NativeData = JS.Uint32Array

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeFramebuffer = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeProgram = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeTexture = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeUniform = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeVertexArrayObject = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/FrameGraph/Node/Blocks/inputBlock.pure
    type NodeRenderGraphInputCreationOptions = BabylonjsBindings.TypeAliases.FrameGraphTextureCreationOptions

    /// @babylonjs/core/types
    type Nullable<'T> = 'T option

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type RenderingGroupStageAction =
        [<Emit("$0($1...)")>] abstract Invoke: renderingGroupId: System.Double -> unit

    /// @babylonjs/core/Engines/Extensions/engine.renderTarget.pure
    type RenderTargetTextureSize = BabylonjsBindings.TypeAliases.TextureSize

    /// @babylonjs/core/Engines/Processors/shaderProcessingOptions
    [<AllowNullLiteral>]
    type ShaderCustomProcessingFunction =
        [<Emit("$0($1...)")>] abstract Invoke: shaderType: string * code: string * ?defines: ResizeArray<string> -> string

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type SimpleStageAction =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Maths/tensor
    [<Erase>]
    type TensorValue =
        | TensorValueCase1 of ResizeArray<System.Double>
        | TensorValueCase2 of ResizeArray<BabylonjsBindings.TypeAliases.TensorValue>

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    type TextureSize = U2<System.Double, AliasObjectde9f6c1b6b0f>

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    type XRBodyMeshRigMapping = AliasObject4d81806d37f7

    /// @babylonjs/core/XR/features/WebXRHandTracking.pure
    type XRHandMeshRigMapping = AliasObjectfe6bed7521ea

    /// Exact Symbol.toStringTag literal exposed by SharedArrayBuffer.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserSharedArrayBufferTag =
        | [<CompiledName("SharedArrayBuffer")>] SharedArrayBuffer

    /// Exact ESNext SharedArrayBuffer instance surface used by ArrayBufferLike declarations.
    [<AllowNullLiteral>]
    type BrowserSharedArrayBuffer =
        abstract byteLength: float with get
        abstract growable: bool with get
        abstract maxByteLength: float with get
        abstract slice: ?beginIndex: float * ?endIndex: float -> BrowserSharedArrayBuffer
        abstract grow: ?newByteLength: float -> unit
        [<Emit("$0[Symbol.toStringTag]")>] abstract toStringTag: BrowserSharedArrayBufferTag with get

    /// Yield branch returned by a Babylon coroutine iterator.
    [<AllowNullLiteral>]
    type CoroutineInternalYieldResult =
        abstract ``done``: bool option with get
        abstract value: unit with get

    /// Completion branch returned by a Babylon coroutine iterator.
    [<AllowNullLiteral>]
    type CoroutineInternalReturnResult<'T> =
        abstract ``done``: bool with get
        abstract value: 'T with get

    /// Exact IteratorResult<void, T> union returned by a Babylon coroutine.
    type CoroutineInternalResult<'T> = U2<CoroutineInternalYieldResult, CoroutineInternalReturnResult<'T>>

    /// Exact internal numeric enum required by an exported Babylon alias.
    type AliasEnum150995365430 =
        | ``FLOAT`` = 0
        | ``INT`` = 1
        | ``UINT`` = 2
        | ``DOUBLE`` = 3
        | ``UCHAR`` = 4
        | ``UNDEFINED`` = 5

    /// Exact internal numeric enum required by an exported Babylon alias.
    type AliasEnum6bfd9a7c2404 =
        | ``MIN_X`` = 0
        | ``MIN_Y`` = 1
        | ``MIN_Z`` = 2
        | ``MAX_X`` = 3
        | ``MAX_Y`` = 4
        | ``MAX_Z`` = 5
        | ``MIN_SCALE_X`` = 6
        | ``MIN_SCALE_Y`` = 7
        | ``MIN_SCALE_Z`` = 8
        | ``MAX_SCALE_X`` = 9
        | ``MAX_SCALE_Y`` = 10
        | ``MAX_SCALE_Z`` = 11
        | ``PACKED_POSITION`` = 12
        | ``PACKED_ROTATION`` = 13
        | ``PACKED_SCALE`` = 14
        | ``PACKED_COLOR`` = 15
        | ``X`` = 16
        | ``Y`` = 17
        | ``Z`` = 18
        | ``SCALE_0`` = 19
        | ``SCALE_1`` = 20
        | ``SCALE_2`` = 21
        | ``DIFFUSE_RED`` = 22
        | ``DIFFUSE_GREEN`` = 23
        | ``DIFFUSE_BLUE`` = 24
        | ``OPACITY`` = 25
        | ``F_DC_0`` = 26
        | ``F_DC_1`` = 27
        | ``F_DC_2`` = 28
        | ``F_DC_3`` = 29
        | ``ROT_0`` = 30
        | ``ROT_1`` = 31
        | ``ROT_2`` = 32
        | ``ROT_3`` = 33
        | ``MIN_COLOR_R`` = 34
        | ``MIN_COLOR_G`` = 35
        | ``MIN_COLOR_B`` = 36
        | ``MAX_COLOR_R`` = 37
        | ``MAX_COLOR_G`` = 38
        | ``MAX_COLOR_B`` = 39
        | ``SH_0`` = 40
        | ``SH_1`` = 41
        | ``SH_2`` = 42
        | ``SH_3`` = 43
        | ``SH_4`` = 44
        | ``SH_5`` = 45
        | ``SH_6`` = 46
        | ``SH_7`` = 47
        | ``SH_8`` = 48
        | ``SH_9`` = 49
        | ``SH_10`` = 50
        | ``SH_11`` = 51
        | ``SH_12`` = 52
        | ``SH_13`` = 53
        | ``SH_14`` = 54
        | ``SH_15`` = 55
        | ``SH_16`` = 56
        | ``SH_17`` = 57
        | ``SH_18`` = 58
        | ``SH_19`` = 59
        | ``SH_20`` = 60
        | ``SH_21`` = 61
        | ``SH_22`` = 62
        | ``SH_23`` = 63
        | ``SH_24`` = 64
        | ``SH_25`` = 65
        | ``SH_26`` = 66
        | ``SH_27`` = 67
        | ``SH_28`` = 68
        | ``SH_29`` = 69
        | ``SH_30`` = 70
        | ``SH_31`` = 71
        | ``SH_32`` = 72
        | ``SH_33`` = 73
        | ``SH_34`` = 74
        | ``SH_35`` = 75
        | ``SH_36`` = 76
        | ``SH_37`` = 77
        | ``SH_38`` = 78
        | ``SH_39`` = 79
        | ``SH_40`` = 80
        | ``SH_41`` = 81
        | ``SH_42`` = 82
        | ``SH_43`` = 83
        | ``SH_44`` = 84
        | ``SH_45`` = 85
        | ``SH_46`` = 86
        | ``SH_47`` = 87
        | ``SH_48`` = 88
        | ``SH_49`` = 89
        | ``SH_50`` = 90
        | ``SH_51`` = 91
        | ``SH_52`` = 92
        | ``SH_53`` = 93
        | ``SH_54`` = 94
        | ``SH_55`` = 95
        | ``SH_56`` = 96
        | ``SH_57`` = 97
        | ``SH_58`` = 98
        | ``SH_59`` = 99
        | ``SH_60`` = 100
        | ``SH_61`` = 101
        | ``SH_62`` = 102
        | ``SH_63`` = 103
        | ``SH_64`` = 104
        | ``SH_65`` = 105
        | ``SH_66`` = 106
        | ``SH_67`` = 107
        | ``SH_68`` = 108
        | ``SH_69`` = 109
        | ``SH_70`` = 110
        | ``SH_71`` = 111
        | ``UNDEFINED`` = 112

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectb68403858bab =
        abstract ``value``: AliasEnum6bfd9a7c2404 with get, set
        abstract ``type``: AliasEnum150995365430 with get, set
        abstract ``offset``: System.Double with get, set

    /// @babylonjs/core/Misc/coroutine
    [<AllowNullLiteral>]
    type Coroutine<'T> =
        abstract next: ?value: unit -> CoroutineInternalResult<'T>
        [<Emit("$0.return === undefined ? undefined : $0.return($1)")>] abstract tryReturn: ?value: 'T -> CoroutineInternalResult<'T> option
        [<Emit("$0.throw === undefined ? undefined : $0.throw($1)")>] abstract tryThrow: ?error: obj -> CoroutineInternalResult<'T> option
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> Coroutine<'T>

    /// @babylonjs/core/types
    type DataArray = U3<ResizeArray<System.Double>, U2<JS.ArrayBuffer, BrowserSharedArrayBuffer>, JS.ArrayBufferView>

    /// @babylonjs/core/types
    type ImageSource = U6<BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap, Browser.Types.ImageData, Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, BabylonjsBindings.SimpleInterfaces.BrowserOffscreenCanvas>

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginCreated = BabylonjsBindings.SimpleInterfaces.JavaScriptObject

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.query.pure
    type OcclusionQuery = U2<BabylonjsBindings.SimpleInterfaces.BrowserWebGLQuery, System.Double>

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    type PlyProperty = AliasObjectb68403858bab

    /// @babylonjs/core/Engines/thinEngine.functions
    type WebGLContext = U2<Browser.Types.WebGLRenderingContext, BabylonjsBindings.SimpleInterfaces.BrowserWebGL2RenderingContext>
