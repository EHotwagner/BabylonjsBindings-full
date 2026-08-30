// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after interface review, compile, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact dependency-closed interfaces exported by Babylon.js 9.19.0.
module SimpleInterfaces =

    /// Exact structural browser ImageBitmap surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserImageBitmap =
        abstract width: float with get
        abstract height: float with get
        abstract close: unit -> unit

    /// Exact numeric literal type for 1.
    type NumericLiteral1 =
        | Value = 1

    /// Exact string literal type for "ceil".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral0fdfeaa68c7b =
        | [<CompiledName("ceil")>] Value

    /// Exact string literal type for "Y".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral18f5384d58bc =
        | [<CompiledName("Y")>] Value

    /// Exact string literal type for "xr-standard".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral1f8f7b54dd3a =
        | [<CompiledName("xr-standard")>] Value

    /// Exact string literal type for "xAxis".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral49563714cd71 =
        | [<CompiledName("xAxis")>] Value

    /// Exact string literal type for "X".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral4b68ab3847fe =
        | [<CompiledName("X")>] Value

    /// Exact string literal type for "state".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral4ba69735ca53 =
        | [<CompiledName("state")>] Value

    /// Exact string literal type for "yAxis".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral6633baa8668f =
        | [<CompiledName("yAxis")>] Value

    /// Exact string literal type for "inverse".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral7705accd2694 =
        | [<CompiledName("inverse")>] Value

    /// Exact string literal type for "visibility".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral7d2fb3da93a0 =
        | [<CompiledName("visibility")>] Value

    /// Exact string literal type for "linear".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral7f2fe580edb3 =
        | [<CompiledName("linear")>] Value

    /// Exact string literal type for "indices".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral91744de3d4d8 =
        | [<CompiledName("indices")>] Value

    /// Exact string literal type for "floor".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala3e1f4935b09 =
        | [<CompiledName("floor")>] Value

    /// Exact string literal type for "attribute".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala92bfd02c450 =
        | [<CompiledName("attribute")>] Value

    /// Exact string literal type for "round".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala97b0931730e =
        | [<CompiledName("round")>] Value

    /// Exact string literal type for "transform".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralaa214ea38326 =
        | [<CompiledName("transform")>] Value

    /// Exact string literal type for "Z".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralbbeebd879e1d =
        | [<CompiledName("Z")>] Value

    /// Exact string literal type for "decodeMeshDone".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralbe5728c055e1 =
        | [<CompiledName("decodeMeshDone")>] Value

    /// Exact string literal type for "button".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralc3e2d78f3ff3 =
        | [<CompiledName("button")>] Value

    /// Exact string literal type for "exponential".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterald075063d475b =
        | [<CompiledName("exponential")>] Value

    /// Exact string literal type for "".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterale3b0c44298fc =
        | [<CompiledName("")>] Value

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta21f2044e128Object =
        [<EmitIndexer>] abstract Item: ``kind``: string -> float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject8681f48cdb3dObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> string with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte519efeffba5Object =
        abstract ``backgroundColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb55cb151e7bcObject =
        [<EmitIndexer>] abstract Item: ``componentId``: string -> InlineObject6f954ab3fd3eObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte17e9af72fe0Object =
        abstract ``value``: float with get, set
        abstract ``touched``: bool with get, set
        abstract ``pressed``: bool with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta635a5848c40Object =
        abstract ``pulse``: System.Func<float, float, JS.Promise<bool>> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectcead31b74f8fObject =
        abstract ``src``: U2<string, BrowserImageBitmap> with get, set
        abstract ``estimatedRealWorldWidth``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb710d9eb561bObject =
        abstract ``type``: BabylonjsBindings.StringEnums.ComputeCompilationMessageType with get, set
        abstract ``text``: string with get, set
        abstract ``line``: float option with get, set
        abstract ``column``: float option with get, set
        abstract ``length``: float option with get, set
        abstract ``offset``: float option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta21bf015c053Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> obj with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta0383ee925a9Object =
        abstract ``force``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4f1820232dd6Object =
        abstract ``url``: string with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte60cc9a00305Object =
        abstract ``yMax``: float with get, set
        abstract ``yMin``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta5f9699c9ae7Object =
        [<EmitIndexer>] abstract Item: ``kind``: string -> JS.Float32Array with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject5839704047beObject<'T> =
        abstract ``mask``: float option with get, set
        abstract ``insertFirst``: bool option with get, set
        abstract ``scope``: obj option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectedc17de1126fObject =
        abstract ``backgroundColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set
        abstract ``disposeOnClose``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject93dc13e6dc30Object =
        abstract ``eventData``: bool with get, set
        abstract ``id``: string with get, set
        abstract ``type``: string with get, set
        abstract ``value``: obj option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject1f7e3b7e13b4Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGlyphData with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject6f954ab3fd3eObject =
        abstract ``type``: BabylonjsBindings.StringEnums.MotionControllerComponentType with get, set
        abstract ``gamepadIndices``: InlineObject35c0cd1bec32Object with get, set
        abstract ``rootNodeName``: string with get, set
        abstract ``visualResponses``: InlineObjectd24882c70775Object with get, set
        abstract ``touchPointNodeName``: string option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject35c0cd1bec32Object =
        abstract ``button``: float option with get, set
        abstract ``xAxis``: float option with get, set
        abstract ``yAxis``: float option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectd24882c70775Object =
        [<EmitIndexer>] abstract Item: ``stateKey``: string -> InlineObjectbee9436f1edeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectbee9436f1edeObject =
        abstract ``componentProperty``: U4<StringLiteral49563714cd71, StringLiteral6633baa8668f, StringLiteralc3e2d78f3ff3, StringLiteral4ba69735ca53> with get, set
        abstract ``states``: ResizeArray<BabylonjsBindings.StringEnums.MotionControllerComponentStateType> with get, set
        abstract ``valueNodeProperty``: U2<StringLiteralaa214ea38326, StringLiteral7d2fb3da93a0> with get, set
        abstract ``valueNodeName``: string option with get, set
        abstract ``minNodeName``: string option with get, set
        abstract ``maxNodeName``: string option with get, set

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type _IAnimationState =
        abstract ``key``: float with get, set
        abstract ``repeatCount``: float with get, set
        abstract ``workValue``: obj option with get, set
        abstract ``loopMode``: float option with get, set
        abstract ``offsetValue``: obj option with get, set
        abstract ``highLimitValue``: obj option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type _ISamplerData =
        abstract ``noMipMaps``: bool with get, set
        abstract ``samplingMode``: float with get, set
        abstract ``wrapU``: float with get, set
        abstract ``wrapV``: float with get, set

    /// @babylonjs/core/Engines/Processors/shaderProcessingOptions
    [<AllowNullLiteral>]
    type _IShaderProcessingContext =
        abstract ``vertexBufferKindToNumberOfComponents``: InlineObjecta21f2044e128Object option with get, set

    /// @babylonjs/core/Misc/workerPool
    [<AllowNullLiteral>]
    type AutoReleaseWorkerPoolOptions =
        abstract ``idleTimeElapsedBeforeRelease``: float with get, set

    /// @babylonjs/core/Behaviors/behavior
    [<AllowNullLiteral>]
    type Behavior<'T> =
        abstract ``name``: string with get, set
        abstract ``init``: unit -> unit
        abstract ``attach``: ``target``: 'T -> unit
        abstract ``detach``: unit -> unit
        abstract ``attachedNode``: 'T option with get, set

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    [<AllowNullLiteral>]
    type ComputeCompilationMessages =
        abstract ``numErrors``: float with get, set
        abstract ``messages``: ResizeArray<InlineObjectb710d9eb561bObject> with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type CreateEnvTextureOptions =
        abstract ``imageType``: string option with get, set
        abstract ``imageQuality``: float option with get, set
        abstract ``disableIrradianceTexture``: bool option with get, set

    /// @babylonjs/core/Misc/HighDynamicRange/panoramaToCubemap
    [<AllowNullLiteral>]
    type CubeMapInfo =
        abstract ``front``: JS.ArrayBufferView option with get, set
        abstract ``back``: JS.ArrayBufferView option with get, set
        abstract ``left``: JS.ArrayBufferView option with get, set
        abstract ``right``: JS.ArrayBufferView option with get, set
        abstract ``up``: JS.ArrayBufferView option with get, set
        abstract ``down``: JS.ArrayBufferView option with get, set
        abstract ``size``: float with get, set
        abstract ``format``: float with get, set
        abstract ``type``: float with get, set
        abstract ``gammaSpace``: bool with get, set

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type DataCursor =
        abstract ``value``: float with get, set

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    [<AllowNullLiteral>]
    type DepthTextureCreationOptions =
        abstract ``generateStencil``: bool option with get, set
        abstract ``bilinearFiltering``: bool option with get, set
        abstract ``comparisonFunction``: float option with get, set
        abstract ``isCube``: bool option with get, set
        abstract ``samples``: float option with get, set
        abstract ``depthTextureFormat``: float option with get, set
        abstract ``label``: string option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type DOMMatrix =
        abstract ``is2D``: bool with get, set
        abstract ``isIdentity``: bool with get, set
        abstract ``a``: float with get, set
        abstract ``b``: float with get, set
        abstract ``c``: float with get, set
        abstract ``d``: float with get, set
        abstract ``e``: float with get, set
        abstract ``f``: float with get, set
        abstract ``m11``: float with get, set
        abstract ``m12``: float with get, set
        abstract ``m13``: float with get, set
        abstract ``m14``: float with get, set
        abstract ``m21``: float with get, set
        abstract ``m22``: float with get, set
        abstract ``m23``: float with get, set
        abstract ``m24``: float with get, set
        abstract ``m31``: float with get, set
        abstract ``m32``: float with get, set
        abstract ``m33``: float with get, set
        abstract ``m34``: float with get, set
        abstract ``m41``: float with get, set
        abstract ``m42``: float with get, set
        abstract ``m43``: float with get, set
        abstract ``m44``: float with get, set

    /// @babylonjs/core/Engines/engineFeatures
    [<AllowNullLiteral>]
    type EngineFeatures =
        abstract ``forceBitmapOverHTMLImageElement``: bool with get, set
        abstract ``supportRenderAndCopyToLodForFloatTextures``: bool with get, set
        abstract ``supportDepthStencilTexture``: bool with get, set
        abstract ``supportShadowSamplers``: bool with get, set
        abstract ``uniformBufferHardCheckMatrix``: bool with get, set
        abstract ``allowTexturePrefiltering``: bool with get, set
        abstract ``trackUbosInFrame``: bool with get, set
        abstract ``checkUbosContentBeforeUpload``: bool with get, set
        abstract ``supportCSM``: bool with get, set
        abstract ``basisNeedsPOT``: bool with get, set
        abstract ``support3DTextures``: bool with get, set
        abstract ``needTypeSuffixInShaderConstants``: bool with get, set
        abstract ``supportMSAA``: bool with get, set
        abstract ``supportSSAO2``: bool with get, set
        abstract ``supportIBLShadows``: bool with get, set
        abstract ``supportExtendedTextureFormats``: bool with get, set
        abstract ``supportSwitchCaseInShader``: bool with get, set
        abstract ``supportSyncTextureRead``: bool with get, set
        abstract ``needsInvertingBitmap``: bool with get, set
        abstract ``useUBOBindingCache``: bool with get, set
        abstract ``needShaderCodeInlining``: bool with get, set
        abstract ``needToAlwaysBindUniformBuffers``: bool with get, set
        abstract ``supportRenderPasses``: bool with get, set
        abstract ``supportSpriteInstancing``: bool with get, set
        abstract ``forceVertexBufferStrideAndOffsetMultiple4Bytes``: bool with get, set
        abstract ``_checkNonFloatVertexBuffersDontRecreatePipelineContext``: bool with get, set

    /// @babylonjs/loaders/FBX/fbxFileLoader.pure
    [<AllowNullLiteral>]
    type FBXFileLoaderOptions =
        abstract ``normalMapCoordinateSystem``: BabylonjsBindings.StringEnums.FBXNormalMapCoordinateSystem option with get, set

    /// Exact optional-property projection used by Babylon Partial<FBXFileLoaderOptions> signatures.
    [<AllowNullLiteral>]
    type PartialFBXFileLoaderOptions =
        abstract ``normalMapCoordinateSystem``: BabylonjsBindings.StringEnums.FBXNormalMapCoordinateSystem option with get, set

    /// @babylonjs/core/Gamepads/gamepad
    [<AllowNullLiteral>]
    type GamepadButtonChanges =
        abstract ``changed``: bool with get, set
        abstract ``pressChanged``: bool with get, set
        abstract ``touchChanged``: bool with get, set
        abstract ``valueChanged``: bool with get, set

    /// @babylonjs/core/Engines/webgpuEngine.pure
    [<AllowNullLiteral>]
    type GlslangOptions =
        abstract ``glslang``: obj option with get, set
        abstract ``jsPath``: string option with get, set
        abstract ``wasmPath``: string option with get, set

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineBaseMesh
    [<AllowNullLiteral>]
    type GreasedLinePointsOptions =
        abstract ``floatArrayStride``: float option with get, set

    /// @babylonjs/core/Physics/v2/Plugins/havokPlugin
    [<AllowNullLiteral>]
    type HavokPluginParameters =
        abstract ``maxQueryCollectorHits``: float option with get, set
        abstract ``floatingOriginWorldRadius``: float option with get, set

    /// @babylonjs/core/Misc/HighDynamicRange/hdr
    [<AllowNullLiteral>]
    type HDRInfo =
        abstract ``height``: float with get, set
        abstract ``width``: float with get, set
        abstract ``dataPosition``: float with get, set

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type HostInformation =
        abstract ``isMobile``: bool with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundOptionsBase =
        abstract ``autoplay``: bool with get, set
        abstract ``maxInstances``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundPlayOptionsBase =
        abstract ``loop``: bool with get, set
        abstract ``startOffset``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IAbstractSoundPlayOptionsBase> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractSoundPlayOptionsBase =
        abstract ``loop``: bool option with get, set
        abstract ``startOffset``: float option with get, set

    /// @babylonjs/core/Navigation/INavigationEngine
    [<AllowNullLiteral>]
    type IAgentParameters =
        abstract ``radius``: float with get, set
        abstract ``height``: float with get, set
        abstract ``maxAcceleration``: float with get, set
        abstract ``maxSpeed``: float with get, set
        abstract ``collisionQueryRange``: float with get, set
        abstract ``pathOptimizationRange``: float with get, set
        abstract ``separationWeight``: float with get, set
        abstract ``reachRadius``: float option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IArrayItem =
        abstract ``index``: float with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type IAttributeData =
        abstract ``kind``: string with get, set
        abstract ``data``: JS.ArrayBufferView with get, set
        abstract ``size``: float with get, set
        abstract ``byteOffset``: float with get, set
        abstract ``byteStride``: float with get, set
        abstract ``normalized``: bool with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractAudioAnalyzer
    [<AllowNullLiteral>]
    type IAudioAnalyzerOptions =
        abstract ``analyzerEnabled``: bool with get, set
        abstract ``analyzerFFTSize``: BabylonjsBindings.Enums.AudioAnalyzerFFTSizeType with get, set
        abstract ``analyzerMinDecibels``: float with get, set
        abstract ``analyzerMaxDecibels``: float with get, set
        abstract ``analyzerSmoothing``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IAudioAnalyzerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAudioAnalyzerOptions =
        abstract ``analyzerEnabled``: bool option with get, set
        abstract ``analyzerFFTSize``: BabylonjsBindings.Enums.AudioAnalyzerFFTSizeType option with get, set
        abstract ``analyzerMinDecibels``: float option with get, set
        abstract ``analyzerMaxDecibels``: float option with get, set
        abstract ``analyzerSmoothing``: float option with get, set

    /// @babylonjs/core/AudioV2/audioParameter
    [<AllowNullLiteral>]
    type IAudioParameterRampOptions =
        abstract ``duration``: float with get, set
        abstract ``shape``: BabylonjsBindings.StringEnums.AudioParameterRampShape with get, set

    /// Exact optional-property projection used by Babylon Partial<IAudioParameterRampOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAudioParameterRampOptions =
        abstract ``duration``: float option with get, set
        abstract ``shape``: BabylonjsBindings.StringEnums.AudioParameterRampShape option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type ICanvasGradient =
        abstract ``addColorStop``: ``offset``: float * ``color``: string -> unit

    /// Exact readonly projection of IColor3Like used by Babylon DeepImmutable<IColor3Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIColor3Like =
        abstract ``r``: BabylonjsBindings.TypeAliases.float with get
        abstract ``g``: BabylonjsBindings.TypeAliases.float with get
        abstract ``b``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IColor3Like =
        inherit DeepImmutableIColor3Like
        abstract ``r``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``g``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``b``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type ICompressedFormatCapabilities =
        abstract ``astc``: bool option with get, set
        abstract ``bptc``: bool option with get, set
        abstract ``s3tc``: bool option with get, set
        abstract ``pvrtc``: bool option with get, set
        abstract ``etc2``: bool option with get, set
        abstract ``etc1``: bool option with get, set

    /// @babylonjs/core/Compute/IComputeContext
    [<AllowNullLiteral>]
    type IComputeContext =
        abstract ``clear``: unit -> unit

    /// @babylonjs/core/Compute/IComputePipelineContext
    [<AllowNullLiteral>]
    type IComputePipelineContext =
        abstract ``isAsync``: bool with get, set
        abstract ``isReady``: bool with get, set
        abstract ``_name``: string option with get, set
        abstract ``_getComputeShaderCode``: unit -> string option
        abstract ``dispose``: unit -> unit

    /// Function-valued IComputeShaderOptions.processFinalCode property.
    [<AllowNullLiteral>]
    type IComputeShaderOptionsProcessFinalCodeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string -> string

    /// @babylonjs/core/Compute/computeShader.pure
    [<AllowNullLiteral>]
    type IComputeShaderOptions =
        abstract ``bindingsMapping``: BabylonjsBindings.TypeAliases.ComputeBindingMapping with get, set
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``entryPoint``: string option with get, set
        abstract ``processFinalCode``: IComputeShaderOptionsProcessFinalCodeCallback option with get, set
        abstract ``useExplicitComputePipelineLayout``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<IComputeShaderOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIComputeShaderOptions =
        abstract ``bindingsMapping``: BabylonjsBindings.TypeAliases.ComputeBindingMapping option with get, set
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``entryPoint``: string option with get, set
        abstract ``processFinalCode``: IComputeShaderOptionsProcessFinalCodeCallback option with get, set
        abstract ``useExplicitComputePipelineLayout``: bool option with get, set

    /// @babylonjs/core/FlowGraph/flowGraphConnection
    [<AllowNullLiteral>]
    type IConnectable =
        abstract ``uniqueId``: string with get, set
        abstract ``_connectedPoint``: ResizeArray<IConnectable> with get, set
        abstract ``_isSingularConnection``: unit -> bool
        abstract ``_connectionType``: BabylonjsBindings.Enums.FlowGraphConnectionType with get, set
        abstract ``connectTo``: ``point``: IConnectable -> unit

    /// @babylonjs/core/Materials/Textures/textureMerger
    [<AllowNullLiteral>]
    type IConstantChannelInput =
        abstract ``value``: float with get, set

    /// @babylonjs/core/Misc/decorators.serialization
    [<AllowNullLiteral>]
    type ICopySourceOptions =
        abstract ``cloneTexturesOnlyOnce``: bool option with get, set

    /// @babylonjs/core/scene.pure
    [<AllowNullLiteral>]
    type ICreateSceneUboOptions =
        abstract ``trackUBOsInFrame``: bool option with get, set
        abstract ``forceMono``: bool option with get, set

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type ICreateTexture2DArrayFromKTX2Options =
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``invertY``: bool option with get, set

    /// @babylonjs/core/Meshes/csg2
    [<AllowNullLiteral>]
    type ICSG2Options =
        abstract ``manifoldUrl``: string option with get, set
        abstract ``manifoldInstance``: obj with get, set
        abstract ``manifoldMeshInstance``: obj with get, set

    /// Exact optional-property projection used by Babylon Partial<ICSG2Options> signatures.
    [<AllowNullLiteral>]
    type PartialICSG2Options =
        abstract ``manifoldUrl``: string option with get, set
        abstract ``manifoldInstance``: obj option with get, set
        abstract ``manifoldMeshInstance``: obj option with get, set

    /// Function-valued ICubeTextureCreationOptions.onLoad property.
    [<AllowNullLiteral>]
    type ICubeTextureCreationOptionsOnLoadCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued ICubeTextureCreationOptions.onError property.
    [<AllowNullLiteral>]
    type ICubeTextureCreationOptionsOnErrorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``message``: string * ?``exception``: obj -> unit

    /// @babylonjs/core/Materials/Textures/cubeTexture.pure
    [<AllowNullLiteral>]
    type ICubeTextureCreationOptions =
        abstract ``extensions``: ResizeArray<string> option with get, set
        abstract ``noMipmap``: bool option with get, set
        abstract ``files``: ResizeArray<string> option with get, set
        abstract ``buffer``: JS.ArrayBufferView option with get, set
        abstract ``onLoad``: ICubeTextureCreationOptionsOnLoadCallback option with get, set
        abstract ``onError``: ICubeTextureCreationOptionsOnErrorCallback option with get, set
        abstract ``format``: float option with get, set
        abstract ``prefiltered``: bool option with get, set
        abstract ``forcedExtension``: obj option with get, set
        abstract ``createPolynomials``: bool option with get, set
        abstract ``lodScale``: float option with get, set
        abstract ``lodOffset``: float option with get, set
        abstract ``loaderOptions``: obj option with get, set
        abstract ``useSRGBBuffer``: bool option with get, set
        abstract ``sphericalPolynomialTargetSize``: float option with get, set

    /// @babylonjs/core/Materials/material.pure
    [<AllowNullLiteral>]
    type ICustomShaderNameResolveOptions =
        abstract ``processFinalCode``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set

    /// @babylonjs/core/Lights/Shadows/shadowGenerator
    [<AllowNullLiteral>]
    type ICustomShaderOptions =
        abstract ``shaderName``: string with get, set
        abstract ``attributes``: ResizeArray<string> option with get, set
        abstract ``uniforms``: ResizeArray<string> option with get, set
        abstract ``samplers``: ResizeArray<string> option with get, set
        abstract ``defines``: ResizeArray<string> option with get, set

    /// @babylonjs/core/Misc/dataReader
    [<AllowNullLiteral>]
    type IDataBuffer =
        abstract ``readAsync``: ``byteOffset``: float * ``byteLength``: float -> JS.Promise<JS.ArrayBufferView>
        abstract ``byteLength``: float with get

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type IDecodeMeshDoneMessage =
        abstract ``id``: StringLiteralbe5728c055e1 with get, set
        abstract ``totalVertices``: float with get, set

    /// @babylonjs/core/scene.pure
    [<AllowNullLiteral>]
    type IDisposable =
        abstract ``dispose``: unit -> unit

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type IEasingFunction =
        abstract ``ease``: ``gradient``: float -> float

    /// @babylonjs/core/Rendering/edgesRenderer.pure
    [<AllowNullLiteral>]
    type IEdgesRendererOptions =
        abstract ``useAlternateEdgeFinder``: bool option with get, set
        abstract ``useFastVertexMerger``: bool option with get, set
        abstract ``epsilonVertexMerge``: float option with get, set
        abstract ``applyTessellation``: bool option with get, set
        abstract ``epsilonVertexAligned``: float option with get, set
        abstract ``removeDegeneratedTriangles``: bool option with get, set

    /// @babylonjs/core/Decorators/nodeDecorator
    [<AllowNullLiteral>]
    type IEditablePropertyListOption =
        abstract ``label``: string with get, set
        abstract ``value``: float with get, set

    /// @babylonjs/core/Materials/effectRenderer.pure
    [<AllowNullLiteral>]
    type IEffectRendererOptions =
        abstract ``positions``: ResizeArray<float> option with get, set
        abstract ``indices``: ResizeArray<float> option with get, set

    /// Exact readonly projection of IEllipsoidLike used by Babylon DeepImmutable<IEllipsoidLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIEllipsoidLike =
        abstract ``semiMajorAxis``: float with get
        abstract ``semiMinorAxis``: float with get
        abstract ``flattening``: float with get
        abstract ``firstEccentricitySquared``: float with get
        abstract ``secondEccentricitySquared``: float with get

    /// @babylonjs/core/Maths/math.geospatial
    [<AllowNullLiteral>]
    type IEllipsoidLike =
        inherit DeepImmutableIEllipsoidLike
        abstract ``semiMajorAxis``: float with get, set
        abstract ``semiMinorAxis``: float with get, set
        abstract ``flattening``: float with get, set
        abstract ``firstEccentricitySquared``: float with get, set
        abstract ``secondEccentricitySquared``: float with get, set

    /// Function-valued IExplorerExtensibilityOption.action property.
    [<AllowNullLiteral>]
    type IExplorerExtensibilityOptionActionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``entity``: obj -> unit

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IExplorerExtensibilityOption =
        abstract ``label``: string with get, set
        abstract ``action``: IExplorerExtensibilityOptionActionCallback with get, set
        abstract ``keepOpenAfterClick``: bool option with get, set

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<AllowNullLiteral>]
    type IEXRCHannel =
        abstract ``name``: string with get, set
        abstract ``pixelType``: float with get, set

    /// Function-valued IFileRequest.abort property.
    [<AllowNullLiteral>]
    type IFileRequestAbortCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Misc/fileRequest
    [<AllowNullLiteral>]
    type IFileRequest =
        abstract ``onCompleteObservable``: BabylonjsBindings.SimpleClasses.Observable<IFileRequest> with get, set
        abstract ``abort``: IFileRequestAbortCallback with get, set

    /// @babylonjs/core/FlowGraph/flowGraphSceneEventCoordinator
    [<AllowNullLiteral>]
    type IFlowGraphEventTrigger =
        abstract ``type``: BabylonjsBindings.StringEnums.FlowGraphEventType with get, set
        abstract ``payload``: obj option with get, set

    /// @babylonjs/core/FlowGraph/flowGraphLogger
    [<AllowNullLiteral>]
    type IFlowGraphLogItem =
        abstract ``time``: float option with get, set
        abstract ``className``: string with get, set
        abstract ``uniqueId``: string with get, set
        abstract ``action``: BabylonjsBindings.StringEnums.FlowGraphAction with get, set
        abstract ``payload``: obj option with get, set

    /// @babylonjs/core/FlowGraph/CustomTypes/flowGraphMatrix
    [<AllowNullLiteral>]
    type IFlowGraphMatrix<'VectorType> =
        abstract ``m``: ResizeArray<float> with get, set
        abstract ``transformVector``: ``v``: 'VectorType -> 'VectorType
        abstract ``transformVectorToRef``: ``v``: 'VectorType * ``result``: 'VectorType -> 'VectorType
        abstract ``asArray``: unit -> ResizeArray<float>
        abstract ``toArray``: ``emptyArray``: ResizeArray<float> -> ResizeArray<float>
        abstract ``fromArray``: ``array``: ResizeArray<float> -> IFlowGraphMatrix<'VectorType>
        abstract ``multiplyToRef``: ``other``: IFlowGraphMatrix<'VectorType> * ``result``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``multiply``: ``other``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``divideToRef``: ``other``: IFlowGraphMatrix<'VectorType> * ``result``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``divide``: ``other``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``addToRef``: ``other``: IFlowGraphMatrix<'VectorType> * ``result``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``add``: ``other``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``subtractToRef``: ``other``: IFlowGraphMatrix<'VectorType> * ``result``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``subtract``: ``other``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``transpose``: unit -> IFlowGraphMatrix<'VectorType>
        abstract ``determinant``: unit -> float
        abstract ``inverse``: unit -> IFlowGraphMatrix<'VectorType>
        abstract ``getClassName``: unit -> string
        abstract ``equals``: ``other``: IFlowGraphMatrix<'VectorType> * ?``epsilon``: float -> bool

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphSceneTickEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphOnTickEventPayload =
        abstract ``timeSinceStart``: float with get, set
        abstract ``deltaTime``: float with get, set

    /// @babylonjs/core/FrameGraph/Tasks/Rendering/geometryRendererTask
    [<AllowNullLiteral>]
    type IFrameGraphGeometryRendererTextureDescription =
        abstract ``type``: float with get, set
        abstract ``textureType``: float with get, set
        abstract ``textureFormat``: float with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type IGaussianSplattingSplatRange =
        abstract ``offset``: float with get, set
        abstract ``count``: float with get, set

    /// @babylonjs/loaders/SPLAT/gaussianSplattingStream
    [<AllowNullLiteral>]
    type IGaussianSplattingStreamOptions =
        abstract ``deflateURL``: string option with get, set
        abstract ``fflate``: obj option with get, set
        abstract ``debugDisplay``: bool option with get, set
        abstract ``debugLodSource``: BabylonjsBindings.StringEnums.GaussianSplattingStreamDebugLodSource option with get, set
        abstract ``lodBaseDistance``: float option with get, set
        abstract ``lodMultiplier``: float option with get, set
        abstract ``lodBehindPenalty``: float option with get, set
        abstract ``lodRangeMin``: float option with get, set
        abstract ``lodRangeMax``: float option with get, set
        abstract ``maxDecodesPerFrame``: float option with get, set
        abstract ``lodCooldownFrames``: float option with get, set
        abstract ``lodUpdateInterval``: float option with get, set
        abstract ``lodUpdateDistance``: float option with get, set
        abstract ``maxDetailLod``: float option with get, set
        abstract ``frustumCulling``: bool option with get, set
        abstract ``maxConcurrentDownloads``: float option with get, set
        abstract ``maxDownloadRetries``: float option with get, set
        abstract ``memoryBudgetMb``: float option with get, set
        abstract ``maxResidentSplats``: float option with get, set
        abstract ``evictionCooldownFrames``: float option with get, set

    /// @babylonjs/core/Rendering/geometryBufferRenderer.pure
    [<AllowNullLiteral>]
    type IGeometryBufferTextureTypeAndFormat =
        abstract ``textureType``: float with get, set
        abstract ``textureFormat``: float with get, set
        abstract ``samplingMode``: float option with get, set

    /// @babylonjs/core/Meshes/mesh.vertexData
    [<AllowNullLiteral>]
    type IGetSetVerticesData =
        abstract ``isVerticesDataPresent``: ``kind``: string -> bool
        abstract ``getVerticesData``: ``kind``: string * ?``copyWhenShared``: bool * ?``forceCopy``: bool -> BabylonjsBindings.TypeAliases.FloatArray option
        abstract ``getIndices``: ?``copyWhenShared``: bool * ?``forceCopy``: bool -> BabylonjsBindings.TypeAliases.IndicesArray option
        abstract ``setVerticesData``: ``kind``: string * ``data``: BabylonjsBindings.TypeAliases.FloatArray * ``updatable``: bool * ?``stride``: float -> unit
        abstract ``updateVerticesData``: ``kind``: string * ``data``: BabylonjsBindings.TypeAliases.FloatArray * ?``updateExtends``: bool * ?``makeItUnique``: bool -> unit
        abstract ``setIndices``: ``indices``: BabylonjsBindings.TypeAliases.IndicesArray * ``totalVertices``: float option * ?``updatable``: bool -> unit

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAmbienLight =
        abstract ``color``: ResizeArray<float> option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAnimationChannelTarget =
        abstract ``id``: string with get, set
        abstract ``path``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAnimationSampler =
        abstract ``input``: string with get, set
        abstract ``output``: string with get, set
        abstract ``interpolation``: string option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFCameraOrthographic =
        abstract ``xmag``: float with get, set
        abstract ``ymag``: float with get, set
        abstract ``zfar``: float with get, set
        abstract ``znear``: float with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFCameraPerspective =
        abstract ``aspectRatio``: float with get, set
        abstract ``yfov``: float with get, set
        abstract ``zfar``: float with get, set
        abstract ``znear``: float with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFDirectionalLight =
        abstract ``color``: ResizeArray<float> option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFNodeInstanceSkin =
        abstract ``skeletons``: ResizeArray<string> with get, set
        abstract ``skin``: string with get, set
        abstract ``meshes``: ResizeArray<string> with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeMeshesObject =
        interface end

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFPointLight =
        abstract ``color``: ResizeArray<float> option with get, set
        abstract ``constantAttenuation``: float option with get, set
        abstract ``linearAttenuation``: float option with get, set
        abstract ``quadraticAttenuation``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFSpotLight =
        abstract ``color``: ResizeArray<float> option with get, set
        abstract ``constantAttenuation``: float option with get, set
        abstract ``fallOfAngle``: float option with get, set
        abstract ``fallOffExponent``: float option with get, set
        abstract ``linearAttenuation``: float option with get, set
        abstract ``quadraticAttenuation``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechniqueParameter =
        abstract ``type``: float with get, set
        abstract ``count``: float option with get, set
        abstract ``semantic``: string option with get, set
        abstract ``node``: string option with get, set
        abstract ``value``: U4<float, bool, string, ResizeArray<obj>> option with get, set
        abstract ``source``: string option with get, set
        abstract ``babylonValue``: obj option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechniqueStatesFunctions =
        abstract ``blendColor``: ResizeArray<float> option with get, set
        abstract ``blendEquationSeparate``: ResizeArray<float> option with get, set
        abstract ``blendFuncSeparate``: ResizeArray<float> option with get, set
        abstract ``colorMask``: ResizeArray<bool> with get, set
        abstract ``cullFace``: ResizeArray<float> with get, set

    /// @babylonjs/loaders/glTF/glTFValidation
    [<AllowNullLiteral>]
    type IGLTFValidationConfiguration =
        abstract ``url``: string with get, set

    /// @babylonjs/core/Meshes/Builders/textBuilder
    [<AllowNullLiteral>]
    type IGlyphData =
        abstract ``o``: string with get, set
        abstract ``ha``: float with get, set

    /// @babylonjs/core/Collisions/gpuPicker
    [<AllowNullLiteral>]
    type IGPUMultiPickOptions =
        abstract ``readbackStrategy``: BabylonjsBindings.Enums.GPUMultiPickReadbackStrategy option with get, set
        abstract ``maxIndividualReadbackCount``: float option with get, set
        abstract ``individualReadbackAreaRatio``: float option with get, set

    /// @babylonjs/core/Materials/Textures/hardwareTextureWrapper
    [<AllowNullLiteral>]
    type IHardwareTextureWrapper =
        abstract ``underlyingResource``: obj with get, set
        abstract ``set``: ``hardwareTexture``: obj -> unit
        abstract ``setUsage``: ``textureSource``: float * ``generateMipMaps``: bool * ``is2DArray``: bool * ``isCube``: bool * ``is3D``: bool * ``width``: float * ``height``: float * ``depth``: float -> unit
        abstract ``reset``: unit -> unit
        abstract ``release``: unit -> unit

    /// Function-valued IHtmlInCanvasPolyfillModule.installHtmlInCanvasPolyfill property.
    [<AllowNullLiteral>]
    type IHtmlInCanvasPolyfillModuleInstallHtmlInCanvasPolyfillCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``options``: InlineObjecta0383ee925a9Object -> unit

    /// Function-valued IHtmlInCanvasPolyfillModule.uninstallHtmlInCanvasPolyfill property.
    [<AllowNullLiteral>]
    type IHtmlInCanvasPolyfillModuleUninstallHtmlInCanvasPolyfillCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill
    [<AllowNullLiteral>]
    type IHtmlInCanvasPolyfillModule =
        abstract ``installHtmlInCanvasPolyfill``: IHtmlInCanvasPolyfillModuleInstallHtmlInCanvasPolyfillCallback option with get, set
        abstract ``uninstallHtmlInCanvasPolyfill``: IHtmlInCanvasPolyfillModuleUninstallHtmlInCanvasPolyfillCallback option with get, set

    /// @babylonjs/core/Materials/Textures/HTML/htmlInteractionManager
    [<AllowNullLiteral>]
    type IHtmlInteractionManagerOptions =
        abstract ``targetElement``: Browser.Types.HTMLElement option with get, set
        abstract ``enablePointerEvents``: bool option with get, set

    /// @babylonjs/core/Materials/Textures/HTML/htmlRaycastInteractionManager
    [<AllowNullLiteral>]
    type IHtmlRaycastInteractionManagerOptions =
        abstract ``targetElement``: Browser.Types.HTMLElement option with get, set
        abstract ``backFaceCulling``: bool option with get, set
        abstract ``invertY``: bool option with get, set

    /// @babylonjs/core/Lights/IES/iesLoader
    [<AllowNullLiteral>]
    type IIESTextureData =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``data``: JS.Float32Array with get, set

    /// @babylonjs/core/Materials/imageProcessingConfiguration.defines
    [<AllowNullLiteral>]
    type IImageProcessingConfigurationDefines =
        abstract ``IMAGEPROCESSING``: bool with get, set
        abstract ``VIGNETTE``: bool with get, set
        abstract ``VIGNETTEBLENDMODEMULTIPLY``: bool with get, set
        abstract ``VIGNETTEBLENDMODEOPAQUE``: bool with get, set
        abstract ``TONEMAPPING``: float with get, set
        abstract ``CONTRAST``: bool with get, set
        abstract ``EXPOSURE``: bool with get, set
        abstract ``COLORCURVES``: bool with get, set
        abstract ``COLORGRADING``: bool with get, set
        abstract ``COLORGRADING3D``: bool with get, set
        abstract ``SAMPLER3DGREENDEPTH``: bool with get, set
        abstract ``SAMPLER3DBGRMAP``: bool with get, set
        abstract ``DITHER``: bool with get, set
        abstract ``IMAGEPROCESSINGPOSTPROCESS``: bool with get, set
        abstract ``SKIPFINALCOLORCLAMP``: bool with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type IIndicesMessage =
        abstract ``id``: StringLiteral91744de3d4d8 with get, set
        abstract ``data``: U2<JS.Uint16Array, JS.Uint32Array> with get, set

    /// @babylonjs/core/Misc/iInspectable
    [<AllowNullLiteral>]
    type IInspectableOptions =
        abstract ``label``: string with get, set
        abstract ``value``: U2<float, string> with get, set
        abstract ``selected``: bool option with get, set

    /// Function-valued IInspectorContextMenuItem.action property.
    [<AllowNullLiteral>]
    type IInspectorContextMenuItemActionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``entity``: obj -> unit

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IInspectorContextMenuItem =
        abstract ``label``: string with get, set
        abstract ``action``: IInspectorContextMenuItemActionCallback with get, set

    /// @babylonjs/core/Materials/shadowDepthWrapper
    [<AllowNullLiteral>]
    type IIOptionShadowDepthMaterial =
        abstract ``remappedVariables``: ResizeArray<string> option with get, set
        abstract ``standalone``: bool option with get, set
        abstract ``doNotInjectCode``: bool option with get, set

    /// Exact readonly projection of ILatLonLike used by Babylon DeepImmutable<ILatLonLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableILatLonLike =
        abstract ``lat``: float with get
        abstract ``lon``: float with get

    /// @babylonjs/core/Maths/math.geospatial
    [<AllowNullLiteral>]
    type ILatLonLike =
        inherit DeepImmutableILatLonLike
        abstract ``lat``: float with get, set
        abstract ``lon``: float with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type ILeaf =
        abstract ``transcodeFormat``: BabylonjsBindings.Enums.TranscodeTarget with get, set
        abstract ``engineFormat``: BabylonjsBindings.Enums.EngineFormat with get, set
        abstract ``roundToMultiple4``: bool option with get, set

    /// Function-valued ILoadingScreen.displayLoadingUI property.
    [<AllowNullLiteral>]
    type ILoadingScreenDisplayLoadingUICallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued ILoadingScreen.hideLoadingUI property.
    [<AllowNullLiteral>]
    type ILoadingScreenHideLoadingUICallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Loading/loadingScreen.pure
    [<AllowNullLiteral>]
    type ILoadingScreen =
        abstract ``displayLoadingUI``: ILoadingScreenDisplayLoadingUICallback with get, set
        abstract ``hideLoadingUI``: ILoadingScreenHideLoadingUICallback with get, set
        abstract ``loadingUIBackgroundColor``: string with get, set
        abstract ``loadingUIText``: string with get, set

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type IMakeAnimationAdditiveOptions =
        abstract ``referenceFrame``: float option with get, set
        abstract ``range``: string option with get, set
        abstract ``cloneOriginalAnimation``: bool option with get, set
        abstract ``clonedAnimationName``: string option with get, set
        abstract ``fromFrame``: float option with get, set
        abstract ``toFrame``: float option with get, set
        abstract ``clipKeys``: bool option with get, set

    /// @babylonjs/core/Materials/material.pure
    [<AllowNullLiteral>]
    type IMaterialCompilationOptions =
        abstract ``clipPlane``: bool with get, set
        abstract ``useInstances``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IMaterialCompilationOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIMaterialCompilationOptions =
        abstract ``clipPlane``: bool option with get, set
        abstract ``useInstances``: bool option with get, set

    /// @babylonjs/core/Engines/IMaterialContext
    [<AllowNullLiteral>]
    type IMaterialContext =
        abstract ``uniqueId``: float with get, set
        abstract ``useVertexPulling``: bool with get, set
        abstract ``reset``: unit -> unit

    /// Exact readonly projection of IMatrixLike used by Babylon DeepImmutable<IMatrixLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIMatrixLike =
        abstract ``asArray``: unit -> (float * float * float * float * float * float * float * float * float * float * float * float * float * float * float * float)
        abstract ``updateFlag``: BabylonjsBindings.TypeAliases.int with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IMatrixLike =
        inherit DeepImmutableIMatrixLike
        abstract ``asArray``: unit -> (float * float * float * float * float * float * float * float * float * float * float * float * float * float * float * float)
        abstract ``updateFlag``: BabylonjsBindings.TypeAliases.int with get, set

    /// @babylonjs/core/Meshes/abstractMesh.pure
    [<AllowNullLiteral>]
    type IMeshDataCache =
        abstract ``_outputData``: JS.Float32Array option with get, set
        abstract ``_vertexData``: InlineObjecta5f9699c9ae7Object option with get, set

    /// @babylonjs/core/Meshes/Compression/meshoptCompression
    [<AllowNullLiteral>]
    type IMeshoptCompressionConfiguration =
        abstract ``decoder``: InlineObject4f1820232dd6Object with get, set

    /// @babylonjs/core/Meshes/meshUVSpaceRenderer.pure
    [<AllowNullLiteral>]
    type IMeshUVSpaceRendererOptions =
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``textureType``: float option with get, set
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``optimizeUVAllocation``: bool option with get, set
        abstract ``uvEdgeBlending``: bool option with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMinimalMotionControllerObject =
        abstract ``axes``: ResizeArray<float> with get, set
        abstract ``buttons``: ResizeArray<InlineObjecte17e9af72fe0Object> with get, set
        abstract ``hapticActuators``: ResizeArray<InlineObjecta635a5848c40Object> option with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type IMipmap =
        abstract ``data``: JS.Uint8Array option with get, set
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``layerIndex``: float with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMotionControllerLayout =
        abstract ``assetPath``: string with get, set
        abstract ``components``: InlineObjectb55cb151e7bcObject with get, set
        abstract ``gamepadMapping``: U2<StringLiterale3b0c44298fc, StringLiteral1f8f7b54dd3a> with get, set
        abstract ``rootNodeName``: string with get, set
        abstract ``selectComponentId``: string with get, set

    /// @babylonjs/core/Physics/v1/physicsJoint
    [<AllowNullLiteral>]
    type IMotorEnabledJoint =
        abstract ``physicsJoint``: obj with get, set
        abstract ``setMotor``: ?``force``: float * ?``maxForce``: float * ?``motorIndex``: float -> unit
        abstract ``setLimit``: ``upperLimit``: float * ?``lowerLimit``: float * ?``motorIndex``: float -> unit

    /// @babylonjs/core/Materials/Textures/multiRenderTarget.pure
    [<AllowNullLiteral>]
    type IMultiRenderTargetOptions =
        abstract ``createMipMaps``: bool option with get, set
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``types``: ResizeArray<float> option with get, set
        abstract ``samplingModes``: ResizeArray<float> option with get, set
        abstract ``useSRGBBuffers``: ResizeArray<bool> option with get, set
        abstract ``generateDepthBuffer``: bool option with get, set
        abstract ``generateStencilBuffer``: bool option with get, set
        abstract ``generateDepthTexture``: bool option with get, set
        abstract ``formats``: ResizeArray<float> option with get, set
        abstract ``depthTextureFormat``: float option with get, set
        abstract ``textureCount``: float option with get, set
        abstract ``doNotChangeAspectRatio``: bool option with get, set
        abstract ``defaultType``: float option with get, set
        abstract ``samples``: float option with get, set
        abstract ``drawOnlyOnFirstAttachmentByDefault``: bool option with get, set
        abstract ``targetTypes``: ResizeArray<float> option with get, set
        abstract ``faceIndex``: ResizeArray<float> option with get, set
        abstract ``layerIndex``: ResizeArray<float> option with get, set
        abstract ``layerCounts``: ResizeArray<float> option with get, set
        abstract ``creationFlags``: ResizeArray<float> option with get, set
        abstract ``labels``: ResizeArray<string> option with get, set
        abstract ``label``: string option with get, set
        abstract ``dontCreateTextures``: bool option with get, set

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeDataStream =
        abstract ``writeBuffer``: ``buffer``: JS.ArrayBuffer * ``length``: float -> unit

    /// @babylonjs/core/Navigation/INavigationEngine
    [<AllowNullLiteral>]
    type INavMeshParameters =
        abstract ``cs``: float with get, set
        abstract ``ch``: float with get, set
        abstract ``walkableSlopeAngle``: float with get, set
        abstract ``walkableHeight``: float with get, set
        abstract ``walkableClimb``: float with get, set
        abstract ``walkableRadius``: float with get, set
        abstract ``maxEdgeLen``: float with get, set
        abstract ``maxSimplificationError``: float with get, set
        abstract ``minRegionArea``: float with get, set
        abstract ``mergeRegionArea``: float with get, set
        abstract ``maxVertsPerPoly``: float with get, set
        abstract ``detailSampleDist``: float with get, set
        abstract ``detailSampleMaxError``: float with get, set
        abstract ``tileSize``: float option with get, set
        abstract ``borderSize``: float option with get, set

    /// @babylonjs/core/Meshes/Node/Interfaces/nodeGeometryInstancingContext
    [<AllowNullLiteral>]
    type INodeGeometryInstancingContext =
        abstract ``getInstanceIndex``: unit -> float

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type INodeMaterialEditorOptions =
        abstract ``editorURL``: string option with get, set
        abstract ``nodeEditorConfig``: InlineObjecte519efeffba5Object option with get, set

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type INodeMaterialOptions =
        abstract ``emitComments``: bool with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage with get, set

    /// Exact optional-property projection used by Babylon Partial<INodeMaterialOptions> signatures.
    [<AllowNullLiteral>]
    type PartialINodeMaterialOptions =
        abstract ``emitComments``: bool option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set

    /// @babylonjs/core/Particles/Node/nodeParticleSystemSet
    [<AllowNullLiteral>]
    type INodeParticleEditorOptions =
        abstract ``editorURL``: string option with get, set
        abstract ``nodeEditorConfig``: InlineObjectedc17de1126fObject option with get, set

    /// @babylonjs/core/Particles/Node/Blocks/particleSourceTextureBlock.pure
    [<AllowNullLiteral>]
    type INodeParticleTextureData =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``data``: JS.Uint8ClampedArray with get, set

    /// @babylonjs/core/FrameGraph/Node/Types/nodeRenderGraphTypes
    [<AllowNullLiteral>]
    type INodeRenderGraphCreateOptions =
        abstract ``debugTextures``: bool option with get, set
        abstract ``rebuildGraphOnEngineResize``: bool option with get, set
        abstract ``verbose``: bool option with get, set
        abstract ``autoConfigure``: bool option with get, set
        abstract ``autoFillExternalInputs``: bool option with get, set

    /// @babylonjs/core/Engines/instancingAttributeInfo
    [<AllowNullLiteral>]
    type InstancingAttributeInfo =
        abstract ``attributeName``: string with get, set
        abstract ``index``: float option with get, set
        abstract ``attributeSize``: float with get, set
        abstract ``offset``: float with get, set
        abstract ``divisor``: float option with get, set
        abstract ``attributeType``: float option with get, set
        abstract ``normalized``: bool option with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/interactivityGraphParser
    [<AllowNullLiteral>]
    type InteractivityEvent =
        abstract ``eventId``: string with get, set
        abstract ``eventData``: ResizeArray<InlineObject93dc13e6dc30Object> option with get, set

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    [<AllowNullLiteral>]
    type InternalTextureCreationOptions =
        abstract ``createMipMaps``: bool option with get, set
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``type``: float option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``format``: float option with get, set
        abstract ``samples``: float option with get, set
        abstract ``creationFlags``: float option with get, set
        abstract ``useSRGBBuffer``: bool option with get, set
        abstract ``label``: string option with get, set
        abstract ``createMSAATexture``: bool option with get, set
        abstract ``comparisonFunction``: float option with get, set
        abstract ``isCube``: bool option with get, set

    /// @babylonjs/core/Cameras/camera.pure
    [<AllowNullLiteral>]
    type IObliqueParams =
        abstract ``angle``: float with get, set
        abstract ``length``: float with get, set
        abstract ``offset``: float with get, set

    /// @babylonjs/core/Misc/observable.pure
    [<AllowNullLiteral>]
    type IObserver =
        abstract ``remove``: ?``defer``: bool -> unit

    /// @babylonjs/core/Offline/IOfflineProvider
    [<AllowNullLiteral>]
    type IOfflineProvider =
        abstract ``enableSceneOffline``: bool with get, set
        abstract ``enableTexturesOffline``: bool with get, set
        abstract ``open``: ``successCallback``: System.Action * ``errorCallback``: System.Action -> unit
        abstract ``loadImage``: ``url``: string * ``image``: Browser.Types.HTMLImageElement -> unit
        abstract ``loadFile``: ``url``: string * ``sceneLoaded``: System.Action<obj> * ?``progressCallBack``: System.Action<obj> * ?``errorCallback``: System.Action * ?``useArrayBuffer``: bool -> unit

    /// @babylonjs/core/Misc/interfaces/iPerfViewer
    [<AllowNullLiteral>]
    type IPerfCustomEvent =
        abstract ``name``: string with get, set
        abstract ``value``: float option with get, set

    /// @babylonjs/core/Misc/interfaces/iPerfViewer
    [<AllowNullLiteral>]
    type IPerfDatasets =
        abstract ``ids``: ResizeArray<string> with get, set
        abstract ``data``: BabylonjsBindings.SimpleClasses.DynamicFloat32Array with get, set
        abstract ``startingIndices``: BabylonjsBindings.SimpleClasses.DynamicFloat32Array with get, set

    /// @babylonjs/core/Misc/interfaces/iPerfViewer
    [<AllowNullLiteral>]
    type IPerfMetadata =
        abstract ``color``: string option with get, set
        abstract ``hidden``: bool option with get, set
        abstract ``category``: string option with get, set

    /// Function-valued IPerfViewerCollectionStrategy.getData property.
    [<AllowNullLiteral>]
    type IPerfViewerCollectionStrategyGetDataCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> float

    /// Function-valued IPerfViewerCollectionStrategy.dispose property.
    [<AllowNullLiteral>]
    type IPerfViewerCollectionStrategyDisposeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Misc/PerformanceViewer/performanceViewerCollectionStrategies
    [<AllowNullLiteral>]
    type IPerfViewerCollectionStrategy =
        abstract ``id``: string with get, set
        abstract ``getData``: IPerfViewerCollectionStrategyGetDataCallback with get, set
        abstract ``dispose``: IPerfViewerCollectionStrategyDisposeCallback with get, set

    /// @babylonjs/core/Rendering/renderingManager
    [<AllowNullLiteral>]
    type IRenderingManagerAutoClearSetup =
        abstract ``autoClear``: bool with get, set
        abstract ``depth``: bool with get, set
        abstract ``stencil``: bool with get, set

    /// @babylonjs/core/Animations/animatorAvatar
    [<AllowNullLiteral>]
    type IRetargetOptions =
        abstract ``animationGroupName``: string option with get, set
        abstract ``fixAnimations``: bool option with get, set
        abstract ``checkHierarchy``: bool option with get, set
        abstract ``retargetAnimationKeys``: bool option with get, set
        abstract ``fixRootPosition``: bool option with get, set
        abstract ``fixGroundReference``: bool option with get, set
        abstract ``fixGroundReferenceDynamicRefNode``: bool option with get, set
        abstract ``rootNodeName``: string option with get, set
        abstract ``groundReferenceNodeName``: string option with get, set
        abstract ``groundReferenceVerticalAxis``: U4<StringLiterale3b0c44298fc, StringLiteral4b68ab3847fe, StringLiteral18f5384d58bc, StringLiteralbbeebd879e1d> option with get, set
        abstract ``mapNodeNames``: JS.Map<string, string> option with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type ISafeOrbitCameraLimits =
        abstract ``radiusMin``: float option with get, set
        abstract ``elevationMinMax``: (float * float) option with get, set

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderProgressEvent =
        abstract ``lengthComputable``: bool with get
        abstract ``loaded``: float with get
        abstract ``total``: float with get

    /// @babylonjs/core/Misc/interfaces/screenshotSize
    [<AllowNullLiteral>]
    type IScreenshotSize =
        abstract ``height``: float option with get, set
        abstract ``precision``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``finalWidth``: float option with get, set
        abstract ``finalHeight``: float option with get, set

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type ISerializedFlowGraphConnection =
        abstract ``uniqueId``: string with get, set
        abstract ``name``: string with get, set
        abstract ``_connectionType``: BabylonjsBindings.Enums.FlowGraphConnectionType with get, set
        abstract ``connectedPointIds``: ResizeArray<string> with get, set
        abstract ``defaultValue``: obj option with get, set

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type ISerializedFlowGraphContext =
        abstract ``uniqueId``: string with get, set
        abstract ``name``: string option with get, set
        abstract ``_userVariables``: InlineObjecta21bf015c053Object with get, set
        abstract ``_variableTypes``: InlineObject8681f48cdb3dObject option with get, set
        abstract ``_connectionValues``: InlineObjecta21bf015c053Object with get, set
        abstract ``_assetsContext``: InlineObjecta21bf015c053Object option with get, set
        abstract ``enableLogging``: bool option with get, set

    /// Function-valued IShaderMaterialOptions.extraInitializationsAsync property.
    [<AllowNullLiteral>]
    type IShaderMaterialOptionsExtraInitializationsAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> JS.Promise<unit>

    /// @babylonjs/core/Materials/shaderMaterial.pure
    [<AllowNullLiteral>]
    type IShaderMaterialOptions =
        abstract ``needAlphaBlending``: bool with get, set
        abstract ``needAlphaTesting``: bool with get, set
        abstract ``attributes``: ResizeArray<string> with get, set
        abstract ``uniforms``: ResizeArray<string> with get, set
        abstract ``uniformBuffers``: ResizeArray<string> with get, set
        abstract ``samplers``: ResizeArray<string> with get, set
        abstract ``externalTextures``: ResizeArray<string> with get, set
        abstract ``samplerObjects``: ResizeArray<string> with get, set
        abstract ``storageBuffers``: ResizeArray<string> with get, set
        abstract ``defines``: ResizeArray<string> with get, set
        abstract ``useClipPlane``: bool option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set
        abstract ``extraInitializationsAsync``: IShaderMaterialOptionsExtraInitializationsAsyncCallback option with get, set

    /// Exact optional-property projection used by Babylon Partial<IShaderMaterialOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIShaderMaterialOptions =
        abstract ``needAlphaBlending``: bool option with get, set
        abstract ``needAlphaTesting``: bool option with get, set
        abstract ``attributes``: ResizeArray<string> option with get, set
        abstract ``uniforms``: ResizeArray<string> option with get, set
        abstract ``uniformBuffers``: ResizeArray<string> option with get, set
        abstract ``samplers``: ResizeArray<string> option with get, set
        abstract ``externalTextures``: ResizeArray<string> option with get, set
        abstract ``samplerObjects``: ResizeArray<string> option with get, set
        abstract ``storageBuffers``: ResizeArray<string> option with get, set
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``useClipPlane``: bool option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set
        abstract ``extraInitializationsAsync``: IShaderMaterialOptionsExtraInitializationsAsyncCallback option with get, set

    /// @babylonjs/core/Meshes/meshSimplification.common
    [<AllowNullLiteral>]
    type ISimplificationSettings =
        abstract ``quality``: float with get, set
        abstract ``distance``: float with get, set
        abstract ``optimizeMesh``: bool option with get, set

    /// @babylonjs/core/Maths/math.size
    [<AllowNullLiteral>]
    type ISize =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set

    /// @babylonjs/core/Debug/ISkeletonViewer
    [<AllowNullLiteral>]
    type ISkeletonMapShaderColorMapKnot =
        abstract ``color``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``location``: float with get, set

    /// @babylonjs/core/Debug/ISkeletonViewer
    [<AllowNullLiteral>]
    type ISkeletonViewerDisplayOptions =
        abstract ``midStep``: float option with get, set
        abstract ``midStepFactor``: float option with get, set
        abstract ``sphereBaseSize``: float option with get, set
        abstract ``sphereScaleUnit``: float option with get, set
        abstract ``sphereFactor``: float option with get, set
        abstract ``spurFollowsChild``: bool option with get, set
        abstract ``showLocalAxes``: bool option with get, set
        abstract ``localAxesSize``: float option with get, set

    /// @babylonjs/core/Misc/smartArray
    [<AllowNullLiteral>]
    type ISmartArrayLike<'T> =
        abstract ``data``: ResizeArray<'T> with get, set
        abstract ``length``: float with get, set

    /// @babylonjs/core/Lights/lightConstants
    [<AllowNullLiteral>]
    type ISortableLight =
        abstract ``shadowEnabled``: bool with get, set
        abstract ``renderPriority``: float with get, set

    /// @babylonjs/core/Audio/Interfaces/ISoundOptions
    [<AllowNullLiteral>]
    type ISoundOptions =
        abstract ``autoplay``: bool option with get, set
        abstract ``loop``: bool option with get, set
        abstract ``volume``: float option with get, set
        abstract ``spatialSound``: bool option with get, set
        abstract ``maxDistance``: float option with get, set
        abstract ``useCustomAttenuation``: bool option with get, set
        abstract ``rolloffFactor``: float option with get, set
        abstract ``refDistance``: float option with get, set
        abstract ``distanceModel``: U3<StringLiteral7f2fe580edb3, StringLiteral7705accd2694, StringLiterald075063d475b> option with get, set
        abstract ``playbackRate``: float option with get, set
        abstract ``streaming``: bool option with get, set
        abstract ``length``: float option with get, set
        abstract ``offset``: float option with get, set
        abstract ``skipCodecCheck``: bool option with get, set

    /// @babylonjs/core/Audio/soundTrack
    [<AllowNullLiteral>]
    type ISoundTrackOptions =
        abstract ``volume``: float option with get, set
        abstract ``mainTrack``: bool option with get, set

    /// @babylonjs/core/Sprites/ISprites
    [<AllowNullLiteral>]
    type ISpriteJSONSpriteFrameData =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set
        abstract ``w``: float with get, set
        abstract ``h``: float with get, set

    /// @babylonjs/core/Sprites/ISprites
    [<AllowNullLiteral>]
    type ISpriteJSONSpriteSourceSize =
        abstract ``w``: float with get, set
        abstract ``h``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSoundBuffer
    [<AllowNullLiteral>]
    type IStaticSoundBufferCloneOptions =
        abstract ``name``: string with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundBufferCloneOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundBufferCloneOptions =
        abstract ``name``: string option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSoundBuffer
    [<AllowNullLiteral>]
    type IStaticSoundBufferOptions =
        abstract ``skipCodecCheck``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundBufferOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundBufferOptions =
        abstract ``skipCodecCheck``: bool option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundOptionsBase =
        abstract ``duration``: float with get, set
        abstract ``loopEnd``: float with get, set
        abstract ``loopStart``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundOptionsBase> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundOptionsBase =
        abstract ``duration``: float option with get, set
        abstract ``loopEnd``: float option with get, set
        abstract ``loopStart``: float option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundStopOptions =
        abstract ``waitTime``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundStopOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundStopOptions =
        abstract ``waitTime``: float option with get, set

    /// @babylonjs/core/States/IStencilState
    [<AllowNullLiteral>]
    type IStencilStateProperties =
        abstract ``enabled``: bool with get, set
        abstract ``mask``: float with get, set
        abstract ``funcMask``: float with get, set
        abstract ``funcRef``: float with get, set
        abstract ``func``: float with get, set
        abstract ``opStencilDepthPass``: float with get, set
        abstract ``opStencilFail``: float with get, set
        abstract ``opDepthFail``: float with get, set
        abstract ``backFunc``: float with get, set
        abstract ``backOpStencilDepthPass``: float with get, set
        abstract ``backOpStencilFail``: float with get, set
        abstract ``backOpDepthFail``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio
    [<AllowNullLiteral>]
    type IStereoAudioOptions =
        abstract ``stereoEnabled``: bool with get, set
        abstract ``stereoPan``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IStereoAudioOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStereoAudioOptions =
        abstract ``stereoEnabled``: bool option with get, set
        abstract ``stereoPan``: float option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSound
    [<AllowNullLiteral>]
    type IStreamingSoundOptionsBase =
        abstract ``preloadCount``: float with get, set

    /// @babylonjs/core/Meshes/mesh.vertexData.subdivide
    [<AllowNullLiteral>]
    type ISubdivideOptions =
        abstract ``flatOnly``: bool option with get, set
        abstract ``split``: bool option with get, set
        abstract ``uvSmooth``: bool option with get, set
        abstract ``preserveEdges``: bool option with get, set
        abstract ``weight``: float option with get, set

    /// Exact optional-property projection used by Babylon Partial<ISubdivideOptions> signatures.
    [<AllowNullLiteral>]
    type PartialISubdivideOptions =
        abstract ``flatOnly``: bool option with get, set
        abstract ``split``: bool option with get, set
        abstract ``uvSmooth``: bool option with get, set
        abstract ``preserveEdges``: bool option with get, set
        abstract ``weight``: float option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type ITextMetrics =
        abstract ``width``: float with get
        abstract ``actualBoundingBoxLeft``: float with get
        abstract ``actualBoundingBoxRight``: float with get
        abstract ``actualBoundingBoxAscent``: float with get
        abstract ``actualBoundingBoxDescent``: float with get

    /// @babylonjs/core/Materials/Textures/Packer/packer
    [<AllowNullLiteral>]
    type ITexturePackerOptions =
        abstract ``map``: ResizeArray<string> option with get, set
        abstract ``uvsIn``: string option with get, set
        abstract ``uvsOut``: string option with get, set
        abstract ``layout``: float option with get, set
        abstract ``colnum``: float option with get, set
        abstract ``updateInputMeshes``: bool option with get, set
        abstract ``disposeSources``: bool option with get, set
        abstract ``fillBlanks``: bool option with get, set
        abstract ``customFillColor``: string option with get, set
        abstract ``frameSize``: float option with get, set
        abstract ``paddingRatio``: float option with get, set
        abstract ``paddingMode``: float option with get, set
        abstract ``paddingColor``: U2<BabylonjsBindings.SimpleClasses.Color3, BabylonjsBindings.SimpleClasses.Color4> option with get, set

    /// @babylonjs/core/Misc/timer
    [<AllowNullLiteral>]
    type ITimerData<'T> =
        abstract ``startTime``: float with get, set
        abstract ``currentTime``: float with get, set
        abstract ``deltaTime``: float with get, set
        abstract ``completeRate``: float with get, set
        abstract ``payload``: 'T with get, set

    /// @babylonjs/core/Meshes/trailMesh.pure
    [<AllowNullLiteral>]
    type ITrailMeshOptions =
        abstract ``diameter``: float option with get, set
        abstract ``length``: float option with get, set
        abstract ``segments``: float option with get, set
        abstract ``sections``: float option with get, set
        abstract ``doNotTaper``: bool option with get, set
        abstract ``autoStart``: bool option with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/transmissionHelper
    [<AllowNullLiteral>]
    type ITransmissionHelperOptions =
        abstract ``renderSize``: float with get, set
        abstract ``samples``: float with get, set
        abstract ``lodGenerationScale``: float with get, set
        abstract ``lodGenerationOffset``: float with get, set
        abstract ``renderTargetTextureType``: float with get, set
        abstract ``generateMipmaps``: bool with get, set
        abstract ``clearColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set

    /// Exact optional-property projection used by Babylon Partial<ITransmissionHelperOptions> signatures.
    [<AllowNullLiteral>]
    type PartialITransmissionHelperOptions =
        abstract ``renderSize``: float option with get, set
        abstract ``samples``: float option with get, set
        abstract ``lodGenerationScale``: float option with get, set
        abstract ``lodGenerationOffset``: float option with get, set
        abstract ``renderTargetTextureType``: float option with get, set
        abstract ``generateMipmaps``: bool option with get, set
        abstract ``clearColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set

    /// Function-valued IUIEvent.preventDefault property.
    [<AllowNullLiteral>]
    type IUIEventPreventDefaultCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IUIEvent =
        abstract ``inputIndex``: float with get, set
        abstract ``currentTarget``: obj option with get, set
        abstract ``srcElement``: obj option with get, set
        abstract ``type``: string with get, set
        abstract ``target``: obj with get, set
        abstract ``preventDefault``: IUIEventPreventDefaultCallback with get, set

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type IUploadImageToTexture2DArrayLayerOptions =
        abstract ``invertY``: bool option with get, set
        abstract ``premultiplyAlpha``: bool option with get, set

    /// @babylonjs/core/Misc/gradients
    [<AllowNullLiteral>]
    type IValueGradient =
        abstract ``gradient``: float with get, set

    /// Exact readonly projection of IVector2Like used by Babylon DeepImmutable<IVector2Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIVector2Like =
        abstract ``x``: BabylonjsBindings.TypeAliases.float with get
        abstract ``y``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IVector2Like =
        inherit DeepImmutableIVector2Like
        abstract ``x``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``y``: BabylonjsBindings.TypeAliases.float with get, set

    /// Exact readonly projection of IVector3LikeInternal used by Babylon DeepImmutable<IVector3LikeInternal> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIVector3LikeInternal =
        abstract ``_x``: float with get
        abstract ``_y``: float with get
        abstract ``_z``: float with get
        abstract ``_isDirty``: bool option with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IVector3LikeInternal =
        inherit DeepImmutableIVector3LikeInternal
        abstract ``_x``: float with get, set
        abstract ``_y``: float with get, set
        abstract ``_z``: float with get, set
        abstract ``_isDirty``: bool option with get, set

    /// @babylonjs/core/Buffers/buffer.pure
    [<AllowNullLiteral>]
    type IVertexBufferOptions =
        abstract ``updatable``: bool option with get, set
        abstract ``postponeInternalCreation``: bool option with get, set
        abstract ``stride``: float option with get, set
        abstract ``instanced``: bool option with get, set
        abstract ``offset``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``type``: float option with get, set
        abstract ``normalized``: bool option with get, set
        abstract ``useBytes``: bool option with get, set
        abstract ``divisor``: float option with get, set
        abstract ``takeBufferOwnership``: bool option with get, set
        abstract ``label``: string option with get, set

    /// @babylonjs/core/Meshes/mesh.vertexData
    [<AllowNullLiteral>]
    type IVertexDataLike =
        abstract ``positions``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``normals``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``tangents``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs2``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs3``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs4``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs5``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs6``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``colors``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``matricesIndices``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``matricesWeights``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``matricesIndicesExtra``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``matricesWeightsExtra``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``indices``: BabylonjsBindings.TypeAliases.IndicesArray option with get, set

    /// @babylonjs/core/Meshes/csg2
    [<AllowNullLiteral>]
    type IVertexDataRebuildOptions =
        abstract ``rebuildNormals``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<IVertexDataRebuildOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIVertexDataRebuildOptions =
        abstract ``rebuildNormals``: bool option with get, set

    /// @babylonjs/core/Materials/vertexPullingHelper.functions
    [<AllowNullLiteral>]
    type IVertexPullingMetadata =
        abstract ``offset``: float with get, set
        abstract ``stride``: float with get, set
        abstract ``type``: float with get, set
        abstract ``normalized``: bool with get, set

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IViewportLike =
        abstract ``x``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``y``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``width``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``height``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/subNodes/volumeAudioSubNode
    [<AllowNullLiteral>]
    type IVolumeAudioOptions =
        abstract ``volume``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IVolumeAudioOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIVolumeAudioOptions =
        abstract ``volume``: float option with get, set

    /// @babylonjs/core/Misc/interfaces/iWebRequest
    [<AllowNullLiteral>]
    type IWebRequest =
        abstract ``responseURL``: string with get, set
        abstract ``status``: float with get, set
        abstract ``statusText``: string with get, set

    /// @babylonjs/core/XR/webXRInputSource
    [<AllowNullLiteral>]
    type IWebXRControllerOptions =
        abstract ``disableMotionControllerAnimation``: bool option with get, set
        abstract ``doNotLoadControllerMesh``: bool option with get, set
        abstract ``forceControllerProfile``: string option with get, set
        abstract ``renderingGroupId``: float option with get, set

    /// @babylonjs/core/XR/features/WebXRDepthSensing.pure
    [<AllowNullLiteral>]
    type IWebXRDepthSensingOptions =
        abstract ``usagePreference``: ResizeArray<BabylonjsBindings.StringEnums.WebXRDepthUsage> with get, set
        abstract ``dataFormatPreference``: ResizeArray<BabylonjsBindings.StringEnums.WebXRDepthDataFormat> with get, set
        abstract ``disableDepthSensingOnMaterials``: bool option with get, set
        abstract ``useToleranceFactorForDepthSensing``: bool option with get, set
        abstract ``prepareTextureForVisualization``: bool option with get, set

    /// @babylonjs/core/XR/webXRGraphicsBinding
    [<AllowNullLiteral>]
    type IWebXRGraphicsBinding =
        abstract ``bindingType``: BabylonjsBindings.Enums.WebXRGraphicsBindingType with get

    /// @babylonjs/core/XR/features/WebXRImageTracking.pure
    [<AllowNullLiteral>]
    type IWebXRImageTrackingOptions =
        abstract ``images``: ResizeArray<InlineObjectcead31b74f8fObject> with get, set

    /// @babylonjs/core/XR/motionController/webXRControllerComponent
    [<AllowNullLiteral>]
    type IWebXRMotionControllerAxesValue =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    /// @babylonjs/core/XR/motionController/webXRControllerComponent
    [<AllowNullLiteral>]
    type IWebXRMotionControllerComponentChangesValues<'T> =
        abstract ``current``: 'T with get, set
        abstract ``previous``: 'T with get, set

    /// @babylonjs/core/XR/features/WebXRRawCameraAccess.pure
    [<AllowNullLiteral>]
    type IWebXRRawCameraAccessOptions =
        abstract ``doNotDisposeOnDetach``: bool option with get, set

    /// @babylonjs/core/Materials/meshDebugPluginMaterial.pure
    [<AllowNullLiteral>]
    type MeshDebugOptions =
        abstract ``mode``: BabylonjsBindings.Enums.MeshDebugMode option with get, set
        abstract ``multiply``: bool option with get, set
        abstract ``shadedDiffuseColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``shadedSpecularColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``shadedSpecularPower``: float option with get, set
        abstract ``wireframeThickness``: float option with get, set
        abstract ``wireframeTrianglesColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``wireframeVerticesColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``vertexColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``vertexRadius``: float option with get, set
        abstract ``uvScale``: float option with get, set
        abstract ``uvPrimaryColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``uvSecondaryColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set

    /// @babylonjs/core/Rendering/objectRenderer
    [<AllowNullLiteral>]
    type ObjectRendererOptions =
        abstract ``numPasses``: float option with get, set
        abstract ``doNotChangeAspectRatio``: bool option with get, set
        abstract ``enableClusteredLights``: bool option with get, set

    /// @babylonjs/core/Physics/v1/physicsImpostor.pure
    [<AllowNullLiteral>]
    type PhysicsImpostorParameters =
        abstract ``mass``: float with get, set
        abstract ``friction``: float option with get, set
        abstract ``restitution``: float option with get, set
        abstract ``nativeOptions``: obj option with get, set
        abstract ``ignoreParent``: bool option with get, set
        abstract ``disableBidirectionalTransformation``: bool option with get, set
        abstract ``pressure``: float option with get, set
        abstract ``stiffness``: float option with get, set
        abstract ``velocityIterations``: float option with get, set
        abstract ``positionIterations``: float option with get, set
        abstract ``fixedPoints``: float option with get, set
        abstract ``margin``: float option with get, set
        abstract ``damping``: float option with get, set
        abstract ``path``: obj option with get, set
        abstract ``shape``: obj option with get, set

    /// @babylonjs/core/Physics/v2/physicsMaterial
    [<AllowNullLiteral>]
    type PhysicsMaterial =
        abstract ``friction``: float option with get, set
        abstract ``staticFriction``: float option with get, set
        abstract ``restitution``: float option with get, set
        abstract ``frictionCombine``: BabylonjsBindings.Enums.PhysicsMaterialCombineMode option with get, set
        abstract ``restitutionCombine``: BabylonjsBindings.Enums.PhysicsMaterialCombineMode option with get, set

    /// @babylonjs/core/Gizmos/rotationGizmo
    [<AllowNullLiteral>]
    type PlaneRotationGizmoOptions =
        abstract ``color``: BabylonjsBindings.SimpleClasses.Color3 option with get, set

    /// @babylonjs/core/Events/pointerEvents
    [<AllowNullLiteral>]
    type PointerTouch =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set
        abstract ``pointerId``: float with get, set
        abstract ``type``: obj with get, set
        abstract ``button``: float option with get, set

    /// @babylonjs/core/scene.pure
    [<AllowNullLiteral>]
    type SceneOptions =
        abstract ``useGeometryUniqueIdsMap``: bool option with get, set
        abstract ``useMaterialMeshMap``: bool option with get, set
        abstract ``useClonedMeshMap``: bool option with get, set
        abstract ``useFloatingOrigin``: bool option with get, set
        abstract ``virtual``: bool option with get, set
        abstract ``defaultCameraLayerMask``: float option with get, set
        abstract ``defaultRenderableLayerMask``: float option with get, set

    /// @babylonjs/core/Misc/snapshotRenderingHelper
    [<AllowNullLiteral>]
    type SnapshotRenderingHelpersOptions =
        abstract ``morphTargetsNumMaxInfluences``: float option with get, set

    /// @babylonjs/core/Sprites/spriteRenderer
    [<AllowNullLiteral>]
    type SpriteRendererOptions =
        abstract ``pixelPerfect``: bool option with get, set

    /// @babylonjs/core/Engines/thinNativeEngine.pure
    [<AllowNullLiteral>]
    type ThinNativeEngineOptions =
        abstract ``adaptToDeviceRatio``: bool option with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuTintWASM
    [<AllowNullLiteral>]
    type TwgslOptions =
        abstract ``twgsl``: obj option with get, set
        abstract ``jsPath``: string option with get, set
        abstract ``wasmPath``: string option with get, set

    /// @babylonjs/core/Materials/Textures/videoTexture.pure
    [<AllowNullLiteral>]
    type VideoTextureSettings =
        abstract ``autoPlay``: bool option with get, set
        abstract ``muted``: bool option with get, set
        abstract ``loop``: bool option with get, set
        abstract ``autoUpdateTexture``: bool with get, set
        abstract ``poster``: string option with get, set
        abstract ``format``: float option with get, set
        abstract ``independentVideoSource``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<VideoTextureSettings> signatures.
    [<AllowNullLiteral>]
    type PartialVideoTextureSettings =
        abstract ``autoPlay``: bool option with get, set
        abstract ``muted``: bool option with get, set
        abstract ``loop``: bool option with get, set
        abstract ``autoUpdateTexture``: bool option with get, set
        abstract ``poster``: string option with get, set
        abstract ``format``: float option with get, set
        abstract ``independentVideoSource``: bool option with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUBindGroupLayoutEntryInfo =
        abstract ``name``: string with get, set
        abstract ``index``: float with get, set
        abstract ``nameInArrayOfTexture``: string option with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUBindingInfo =
        abstract ``groupIndex``: float with get, set
        abstract ``bindingIndex``: float with get, set

    /// @babylonjs/core/XR/webXRExperienceHelper
    [<AllowNullLiteral>]
    type WebXRSpectatorModeOption =
        abstract ``fps``: float option with get, set
        abstract ``preferredCameraIndex``: float option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractAudioOutNode
    [<AllowNullLiteral>]
    type IAbstractAudioOutNodeOptions =
        inherit IAudioAnalyzerOptions
        inherit IVolumeAudioOptions

    /// Exact optional-property projection used by Babylon Partial<IAbstractAudioOutNodeOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractAudioOutNodeOptions =
        inherit PartialIAudioAnalyzerOptions
        inherit PartialIVolumeAudioOptions

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSoundInstance
    [<AllowNullLiteral>]
    type IAbstractSoundInstanceOptions =
        inherit IAbstractSoundPlayOptionsBase

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundPlayOptions =
        inherit IAbstractSoundPlayOptionsBase
        inherit IVolumeAudioOptions

    /// Exact optional-property projection used by Babylon Partial<IAbstractSoundPlayOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractSoundPlayOptions =
        inherit PartialIAbstractSoundPlayOptionsBase
        inherit PartialIVolumeAudioOptions

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundStoredOptions =
        inherit IAbstractSoundOptionsBase
        inherit IAbstractSoundPlayOptionsBase

    /// @babylonjs/core/Animations/animationKey
    [<AllowNullLiteral>]
    type IAnimationKey =
        abstract ``frame``: float with get, set
        abstract ``value``: obj with get, set
        abstract ``inTangent``: obj option with get, set
        abstract ``outTangent``: obj option with get, set
        abstract ``interpolation``: BabylonjsBindings.Enums.AnimationKeyInterpolation option with get, set
        abstract ``lockedTangent``: bool option with get, set
        abstract ``easingFunction``: IEasingFunction option with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type IAttributeMessage =
        inherit IAttributeData
        abstract ``id``: StringLiterala92bfd02c450 with get, set

    /// @babylonjs/core/Behaviors/behavior
    [<AllowNullLiteral>]
    type IBehaviorAware<'T> =
        abstract ``addBehavior``: ``behavior``: Behavior<'T> -> 'T
        abstract ``removeBehavior``: ``behavior``: Behavior<'T> -> 'T
        abstract ``getBehaviorByName``: ``name``: string -> Behavior<'T> option

    /// Exact readonly projection of IColor4Like used by Babylon DeepImmutable<IColor4Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIColor4Like =
        inherit DeepImmutableIColor3Like
        abstract ``a``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IColor4Like =
        inherit DeepImmutableIColor4Like
        inherit IColor3Like
        abstract ``a``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type IDecodedData =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``transcodedFormat``: float with get, set
        abstract ``mipmaps``: ResizeArray<IMipmap> with get, set
        abstract ``layerCount``: float with get, set
        abstract ``isInGammaSpace``: bool with get, set
        abstract ``hasAlpha``: bool with get, set
        abstract ``transcoderName``: string with get, set
        abstract ``errors``: string option with get, set

    /// @babylonjs/core/DeviceInput/inputInterfaces
    [<AllowNullLiteral>]
    type IDeviceInputSystem =
        inherit IDisposable
        abstract ``pollInput``: ``deviceType``: BabylonjsBindings.Enums.DeviceType * ``deviceSlot``: float * ``inputIndex``: float -> float
        abstract ``isDeviceAvailable``: ``deviceType``: BabylonjsBindings.Enums.DeviceType -> bool

    /// Function-valued IExplorerExtensibilityGroup.predicate property.
    [<AllowNullLiteral>]
    type IExplorerExtensibilityGroupPredicateCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``entity``: obj -> bool

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IExplorerExtensibilityGroup =
        abstract ``predicate``: IExplorerExtensibilityGroupPredicateCallback with get, set
        abstract ``entries``: ResizeArray<IExplorerExtensibilityOption> with get, set

    /// @babylonjs/core/Meshes/Builders/textBuilder
    [<AllowNullLiteral>]
    type IFontData =
        abstract ``resolution``: float with get, set
        abstract ``underlineThickness``: float with get, set
        abstract ``boundingBox``: InlineObjecte60cc9a00305Object with get, set
        abstract ``glyphs``: InlineObject1f7e3b7e13b4Object with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAnimationChannel =
        abstract ``sampler``: string with get, set
        abstract ``target``: IGLTFAnimationChannelTarget with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechniqueStates =
        abstract ``enable``: ResizeArray<float> with get, set
        abstract ``functions``: IGLTFTechniqueStatesFunctions with get, set

    /// Function-valued IInspectable.callback property.
    [<AllowNullLiteral>]
    type IInspectableCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued IInspectable.fileCallback property.
    [<AllowNullLiteral>]
    type IInspectableFileCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``file``: Browser.Types.File -> unit

    /// @babylonjs/core/Misc/iInspectable
    [<AllowNullLiteral>]
    type IInspectable =
        abstract ``label``: string with get, set
        abstract ``propertyName``: string with get, set
        abstract ``type``: BabylonjsBindings.Enums.InspectableType with get, set
        abstract ``min``: float option with get, set
        abstract ``max``: float option with get, set
        abstract ``step``: float option with get, set
        abstract ``callback``: IInspectableCallbackCallback option with get, set
        abstract ``fileCallback``: IInspectableFileCallbackCallback option with get, set
        abstract ``options``: ResizeArray<IInspectableOptions> option with get, set
        abstract ``accept``: string option with get, set

    /// @babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill
    [<AllowNullLiteral>]
    type IInstallHtmlInCanvasPolyfillOptions =
        abstract ``force``: bool option with get, set
        abstract ``moduleSpecifier``: string option with get, set
        abstract ``polyfillModule``: IHtmlInCanvasPolyfillModule option with get, set

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IKeyboardEvent =
        inherit IUIEvent
        abstract ``altKey``: bool with get, set
        abstract ``charCode``: float option with get, set
        abstract ``code``: string with get, set
        abstract ``ctrlKey``: bool with get, set
        abstract ``key``: string with get, set
        abstract ``keyCode``: float with get, set
        abstract ``metaKey``: bool with get, set
        abstract ``shiftKey``: bool with get, set
        abstract ``repeat``: bool option with get, set

    /// Exact readonly projection of ILatLonAltLike used by Babylon DeepImmutable<ILatLonAltLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableILatLonAltLike =
        inherit DeepImmutableILatLonLike
        abstract ``alt``: float with get

    /// @babylonjs/core/Maths/math.geospatial
    [<AllowNullLiteral>]
    type ILatLonAltLike =
        inherit DeepImmutableILatLonAltLike
        inherit ILatLonLike
        abstract ``alt``: float with get, set

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type IMakeAnimationGroupAdditiveOptions =
        inherit IMakeAnimationAdditiveOptions
        abstract ``cloneOriginalAnimationGroup``: bool option with get, set
        abstract ``clonedAnimationGroupName``: string option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type IPath2D =
        abstract ``addPath``: ``path``: IPath2D * ?``transform``: DOMMatrix -> unit
        abstract ``closePath``: unit -> unit
        abstract ``moveTo``: ``x``: float * ``y``: float -> unit
        abstract ``lineTo``: ``x``: float * ``y``: float -> unit
        abstract ``bezierCurveTo``: ``cp1x``: float * ``cp1y``: float * ``cp2x``: float * ``cp2y``: float * ``x``: float * ``y``: float -> unit
        abstract ``quadraticCurveTo``: ``cpx``: float * ``cpy``: float * ``x``: float * ``y``: float -> unit
        abstract ``arc``: ``x``: float * ``y``: float * ``radius``: float * ``startAngle``: float * ``endAngle``: float * ?``counterclockwise``: bool -> unit
        abstract ``arcTo``: ``x1``: float * ``y1``: float * ``x2``: float * ``y2``: float * ``radius``: float -> unit
        abstract ``ellipse``: ``x``: float * ``y``: float * ``radiusX``: float * ``radiusY``: float * ``rotation``: float * ``startAngle``: float * ``endAngle``: float * ?``counterclockwise``: bool -> unit
        abstract ``rect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``roundRect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float * ``radii``: float -> unit

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type ISceneLike =
        abstract ``addPendingData``: ``data``: obj -> unit
        abstract ``removePendingData``: ``data``: obj -> unit
        abstract ``offlineProvider``: IOfflineProvider with get, set

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type ISerializedFlowGraphBlock =
        abstract ``className``: string with get, set
        abstract ``type``: string with get, set
        abstract ``config``: obj with get, set
        abstract ``uniqueId``: string with get, set
        abstract ``dataInputs``: ResizeArray<ISerializedFlowGraphConnection> with get, set
        abstract ``dataOutputs``: ResizeArray<ISerializedFlowGraphConnection> with get, set
        abstract ``metadata``: obj with get, set
        abstract ``signalInputs``: ResizeArray<ISerializedFlowGraphConnection> with get, set
        abstract ``signalOutputs``: ResizeArray<ISerializedFlowGraphConnection> with get, set

    /// @babylonjs/core/Debug/ISkeletonViewer
    [<AllowNullLiteral>]
    type ISkeletonViewerOptions =
        abstract ``pauseAnimations``: bool with get, set
        abstract ``returnToRest``: bool with get, set
        abstract ``displayMode``: float with get, set
        abstract ``displayOptions``: ISkeletonViewerDisplayOptions with get, set
        abstract ``computeBonesUsingShaders``: bool with get, set
        abstract ``useAllBones``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<ISkeletonViewerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialISkeletonViewerOptions =
        abstract ``pauseAnimations``: bool option with get, set
        abstract ``returnToRest``: bool option with get, set
        abstract ``displayMode``: float option with get, set
        abstract ``displayOptions``: ISkeletonViewerDisplayOptions option with get, set
        abstract ``computeBonesUsingShaders``: bool option with get, set
        abstract ``useAllBones``: bool option with get, set

    /// @babylonjs/core/Sprites/ISprites
    [<AllowNullLiteral>]
    type ISpriteJSONSprite =
        abstract ``filename``: string with get, set
        abstract ``frame``: ISpriteJSONSpriteFrameData with get, set
        abstract ``rotated``: bool with get, set
        abstract ``trimmed``: bool with get, set
        abstract ``spriteSourceSize``: ISpriteJSONSpriteFrameData with get, set
        abstract ``sourceSize``: ISpriteJSONSpriteSourceSize with get, set

    /// @babylonjs/core/States/IStencilState
    [<AllowNullLiteral>]
    type IStencilState =
        inherit IStencilStateProperties
        abstract ``reset``: unit -> unit

    /// @babylonjs/core/Materials/Textures/Packer/packer
    [<AllowNullLiteral>]
    type ITexturePackerJSON =
        abstract ``name``: string with get, set
        abstract ``sets``: obj with get, set
        abstract ``options``: ITexturePackerOptions with get, set
        abstract ``frames``: ResizeArray<float> with get, set

    /// Function-valued ITimerOptions.breakCondition property.
    [<AllowNullLiteral>]
    type ITimerOptionsBreakConditionCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ?``data``: ITimerData<'T> -> bool

    /// Function-valued ITimerOptions.onEnded property.
    [<AllowNullLiteral>]
    type ITimerOptionsOnEndedCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: ITimerData<obj> -> unit

    /// Function-valued ITimerOptions.onAborted property.
    [<AllowNullLiteral>]
    type ITimerOptionsOnAbortedCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: ITimerData<obj> -> unit

    /// Function-valued ITimerOptions.onTick property.
    [<AllowNullLiteral>]
    type ITimerOptionsOnTickCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: ITimerData<obj> -> unit

    /// @babylonjs/core/Misc/timer
    [<AllowNullLiteral>]
    type ITimerOptions<'T> =
        abstract ``timeout``: float with get, set
        abstract ``contextObservable``: BabylonjsBindings.SimpleClasses.Observable<'T> with get, set
        abstract ``observableParameters``: InlineObject5839704047beObject<'T> option with get, set
        abstract ``breakCondition``: ITimerOptionsBreakConditionCallback<'T> option with get, set
        abstract ``onEnded``: ITimerOptionsOnEndedCallback<'T> option with get, set
        abstract ``onAborted``: ITimerOptionsOnAbortedCallback<'T> option with get, set
        abstract ``onTick``: ITimerOptionsOnTickCallback<'T> option with get, set

    /// Exact readonly projection of IVector3Like used by Babylon DeepImmutable<IVector3Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIVector3Like =
        inherit DeepImmutableIVector2Like
        abstract ``z``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IVector3Like =
        inherit DeepImmutableIVector3Like
        inherit IVector2Like
        abstract ``z``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.dom.pure
    [<AllowNullLiteral>]
    type IViewportOwnerLike =
        abstract ``viewport``: IViewportLike with get, set

    /// @babylonjs/core/AudioV2/webAudio/subNodes/webAudioBaseSubGraph
    [<AllowNullLiteral>]
    type IWebAudioBaseSubGraphOptions =
        inherit IAudioAnalyzerOptions
        inherit IVolumeAudioOptions

    /// Exact optional-property projection used by Babylon Partial<IWebAudioBaseSubGraphOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebAudioBaseSubGraphOptions =
        inherit PartialIAudioAnalyzerOptions
        inherit PartialIVolumeAudioOptions

    /// @babylonjs/core/XR/webXRInput
    [<AllowNullLiteral>]
    type IWebXRInputOptions =
        abstract ``doNotLoadControllerMeshes``: bool option with get, set
        abstract ``forceInputProfile``: string option with get, set
        abstract ``disableOnlineControllerRepository``: bool option with get, set
        abstract ``customControllersRepositoryURL``: string option with get, set
        abstract ``disableControllerAnimation``: bool option with get, set
        abstract ``controllerOptions``: IWebXRControllerOptions option with get, set

    /// Exact optional-property projection used by Babylon Partial<IWebXRInputOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebXRInputOptions =
        abstract ``doNotLoadControllerMeshes``: bool option with get, set
        abstract ``forceInputProfile``: string option with get, set
        abstract ``disableOnlineControllerRepository``: bool option with get, set
        abstract ``customControllersRepositoryURL``: string option with get, set
        abstract ``disableControllerAnimation``: bool option with get, set
        abstract ``controllerOptions``: IWebXRControllerOptions option with get, set

    /// @babylonjs/core/XR/motionController/webXRControllerComponent
    [<AllowNullLiteral>]
    type IWebXRMotionControllerComponentChanges =
        abstract ``axes``: IWebXRMotionControllerComponentChangesValues<IWebXRMotionControllerAxesValue> option with get, set
        abstract ``pressed``: IWebXRMotionControllerComponentChangesValues<bool> option with get, set
        abstract ``touched``: IWebXRMotionControllerComponentChangesValues<bool> option with get, set
        abstract ``value``: IWebXRMotionControllerComponentChangesValues<float> option with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type MeshData =
        abstract ``indices``: U2<JS.Uint16Array, JS.Uint32Array> option with get, set
        abstract ``attributes``: ResizeArray<IAttributeData> with get, set
        abstract ``totalVertices``: float with get, set

    /// @babylonjs/core/Engines/nativeEngine.pure
    [<AllowNullLiteral>]
    type NativeEngineOptions =
        inherit ThinNativeEngineOptions

    /// @babylonjs/core/Sprites/spriteManager
    [<AllowNullLiteral>]
    type SpriteManagerOptions =
        abstract ``spriteRendererOptions``: SpriteRendererOptions with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUBufferDescription =
        abstract ``binding``: WebGPUBindingInfo with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractAudioBus
    [<AllowNullLiteral>]
    type IAbstractAudioBusOptions =
        inherit IAbstractAudioOutNodeOptions

    /// Exact optional-property projection used by Babylon Partial<IAbstractAudioBusOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractAudioBusOptions =
        inherit PartialIAbstractAudioOutNodeOptions

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IExplorerAdditionalChild =
        abstract ``name``: string with get, set
        abstract ``getClassName``: unit -> string
        abstract ``inspectableCustomProperties``: ResizeArray<IInspectable> with get, set

    /// Exact readonly projection of IPlaneLike used by Babylon DeepImmutable<IPlaneLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIPlaneLike =
        abstract ``normal``: DeepImmutableIVector3Like with get
        abstract ``d``: BabylonjsBindings.TypeAliases.float with get
        abstract ``normalize``: unit -> unit

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IPlaneLike =
        inherit DeepImmutableIPlaneLike
        abstract ``normal``: IVector3Like with get, set
        abstract ``d``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``normalize``: unit -> unit

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IQuaternionLike =
        inherit IVector3Like
        abstract ``w``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type ISerializedFlowGraph =
        abstract ``name``: string option with get, set
        abstract ``uniqueId``: string option with get, set
        abstract ``executionContexts``: ResizeArray<ISerializedFlowGraphContext> with get, set
        abstract ``allBlocks``: ResizeArray<ISerializedFlowGraphBlock> with get, set
        abstract ``rightHanded``: bool option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSoundInstance
    [<AllowNullLiteral>]
    type IStaticSoundInstanceOptions =
        inherit IAbstractSoundInstanceOptions
        inherit IStaticSoundOptionsBase

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundPlayOptions =
        inherit IAbstractSoundPlayOptions
        inherit IStaticSoundOptionsBase
        abstract ``waitTime``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundPlayOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundPlayOptions =
        inherit PartialIAbstractSoundPlayOptions
        inherit PartialIStaticSoundOptionsBase
        abstract ``waitTime``: float option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundStoredOptions =
        inherit IAbstractSoundStoredOptions
        inherit IStaticSoundOptionsBase
        abstract ``pitch``: float with get, set
        abstract ``playbackRate``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSoundInstance
    [<AllowNullLiteral>]
    type IStreamingSoundInstanceOptions =
        inherit IAbstractSoundInstanceOptions
        inherit IStreamingSoundOptionsBase

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSound
    [<AllowNullLiteral>]
    type IStreamingSoundPlayOptions =
        inherit IAbstractSoundPlayOptions

    /// Exact optional-property projection used by Babylon Partial<IStreamingSoundPlayOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStreamingSoundPlayOptions =
        inherit PartialIAbstractSoundPlayOptions

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSound
    [<AllowNullLiteral>]
    type IStreamingSoundStoredOptions =
        inherit IAbstractSoundStoredOptions
        inherit IStreamingSoundOptionsBase

    /// Exact readonly projection of IVector4Like used by Babylon DeepImmutable<IVector4Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIVector4Like =
        inherit DeepImmutableIVector3Like
        abstract ``w``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IVector4Like =
        inherit DeepImmutableIVector4Like
        inherit IVector3Like
        abstract ``w``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IExplorerAdditionalNode =
        abstract ``name``: string with get, set
        abstract ``getContent``: unit -> ResizeArray<IExplorerAdditionalChild>

    /// @babylonjs/core/AudioV2/abstractAudio/mainAudioBus
    [<AllowNullLiteral>]
    type IMainAudioBusOptions =
        inherit IAbstractAudioBusOptions

    /// Exact optional-property projection used by Babylon Partial<IMainAudioBusOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIMainAudioBusOptions =
        inherit PartialIAbstractAudioBusOptions
