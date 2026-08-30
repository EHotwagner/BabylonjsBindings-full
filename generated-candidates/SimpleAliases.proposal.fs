// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after alias review, compile, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact primitive aliases and dependency-free callbacks exported by Babylon.js 9.19.0.
module TypeAliases =

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

    /// @babylonjs/core/types
    type DataArray = U3<ResizeArray<System.Double>, U2<JS.ArrayBuffer, BrowserSharedArrayBuffer>, JS.ArrayBufferView>

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
    type ImageSource = U6<BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap, Browser.Types.ImageData, Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, BabylonjsBindings.SimpleInterfaces.BrowserOffscreenCanvas>

    /// @babylonjs/core/types
    type IndicesArray = U4<ResizeArray<System.Double>, JS.Int32Array, JS.Uint32Array, JS.Uint16Array>

    /// @babylonjs/core/types
    type int = System.Double

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginCreated = BabylonjsBindings.SimpleInterfaces.JavaScriptObject

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

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.query.pure
    type OcclusionQuery = U2<BabylonjsBindings.SimpleInterfaces.BrowserWebGLQuery, System.Double>

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

    /// @babylonjs/core/Engines/thinEngine.functions
    type WebGLContext = U2<Browser.Types.WebGLRenderingContext, BabylonjsBindings.SimpleInterfaces.BrowserWebGL2RenderingContext>

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    type XRBodyMeshRigMapping = AliasObject4d81806d37f7

    /// @babylonjs/core/XR/features/WebXRHandTracking.pure
    type XRHandMeshRigMapping = AliasObjectfe6bed7521ea
