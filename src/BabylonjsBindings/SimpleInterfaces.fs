// REVIEWED MAINTAINED SOURCE — exact declaration review and compile proof recorded in generated-candidates
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

    /// Exact browser image color-space conversion literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserColorSpaceConversion =
        | [<CompiledName("default")>] Default
        | [<CompiledName("none")>] None

    /// Exact browser image orientation literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserImageOrientation =
        | [<CompiledName("flipY")>] FlipY
        | [<CompiledName("from-image")>] FromImage
        | [<CompiledName("none")>] None

    /// Exact browser premultiplied-alpha literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserPremultiplyAlpha =
        | [<CompiledName("default")>] Default
        | [<CompiledName("none")>] None
        | [<CompiledName("premultiply")>] Premultiply

    /// Exact browser bitmap resize-quality literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserResizeQuality =
        | [<CompiledName("high")>] High
        | [<CompiledName("low")>] Low
        | [<CompiledName("medium")>] Medium
        | [<CompiledName("pixelated")>] Pixelated

    /// Exact structural browser ImageBitmapOptions surface.
    [<AllowNullLiteral>]
    type BrowserImageBitmapOptions =
        abstract colorSpaceConversion: BrowserColorSpaceConversion option with get, set
        abstract imageOrientation: BrowserImageOrientation option with get, set
        abstract premultiplyAlpha: BrowserPremultiplyAlpha option with get, set
        abstract resizeHeight: float option with get, set
        abstract resizeQuality: BrowserResizeQuality option with get, set
        abstract resizeWidth: float option with get, set

    /// Structural non-primitive JavaScript object surface used by TypeScript `object` declarations.
    [<AllowNullLiteral>]
    type JavaScriptObject =
        interface end

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
    type InlineObject8f714ae92303Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> InlineObject8cfb1cd4bfe4Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4d78ed30f56dObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> InlineObjectbcd9ce4e2e0aObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta0383ee925a9Object =
        abstract ``force``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject672ce066a49aObject =
        abstract ``singleTile``: bool with get, set
        abstract ``longName``: bool with get, set
        abstract ``deepFormat``: bool with get, set
        abstract ``multiPart``: bool with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte6832153d51cObject =
        abstract ``xMin``: float with get, set
        abstract ``xMax``: float with get, set
        abstract ``yMin``: float with get, set
        abstract ``yMax``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectf9136a0bdd3aObject =
        abstract ``isBinary``: bool with get
        abstract ``mimeType``: string option with get

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
    type InlineObjectc6343ebc447eObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFTechniqueParameter with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject249788b2ccc7Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFAnimationSampler with get, set

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
    type InlineObject8cfb1cd4bfe4Object =
        abstract ``type``: BabylonjsBindings.SimpleClasses.RichType<obj> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectbcd9ce4e2e0aObject =
        abstract ``type``: BabylonjsBindings.SimpleClasses.RichType<obj> with get, set
        abstract ``value``: obj option with get, set

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

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<AllowNullLiteral>]
    type IDecodeChannel =
        [<EmitIndexer>] abstract Item: ``name``: string -> float with get, set

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

    /// @babylonjs/core/FlowGraph/flowGraphBlock
    [<AllowNullLiteral>]
    type IFlowGraphBlockConfiguration =
        abstract ``name``: string option with get, set
        [<EmitIndexer>] abstract Item: ``extraPropertyKey``: string -> obj with get, set

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
    type IGLTFProperty =
        abstract ``extensions``: InlineObjecta21bf015c053Object option with get, set
        abstract ``extras``: JavaScriptObject option with get, set

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
    type IGLTFTechniqueCommonProfile =
        abstract ``lightingModel``: string with get, set
        abstract ``texcoordBindings``: JavaScriptObject with get, set
        abstract ``parameters``: ResizeArray<obj> option with get, set

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
    type ISceneLoaderPluginExtensions =
        [<EmitIndexer>] abstract Item: ``extension``: string -> InlineObjectf9136a0bdd3aObject with get

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

    /// @babylonjs/core/XR/features/WebXRDOMOverlay.pure
    [<AllowNullLiteral>]
    type IWebXRDomOverlayOptions =
        abstract ``element``: U2<Browser.Types.Element, string> with get, set
        abstract ``supressXRSelectEvents``: bool option with get, set

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

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type ICreateTexture2DArrayFromImageUrlsOptions =
        inherit IUploadImageToTexture2DArrayLayerOptions
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``textureType``: float option with get, set
        abstract ``imageBitmapOptions``: BrowserImageBitmapOptions option with get, set

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

    /// Function-valued IEXRDecoder.scanOrder property.
    [<AllowNullLiteral>]
    type IEXRDecoderScanOrderCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float -> float

    /// Function-valued IEXRDecoder.uncompress property.
    [<AllowNullLiteral>]
    type IEXRDecoderUncompressCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``decoder``: IEXRDecoder -> JS.DataView

    /// Function-valued IEXRDecoder.getter property.
    [<AllowNullLiteral>]
    type IEXRDecoderGetterCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: DataCursor -> float

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<AllowNullLiteral>]
    type IEXRDecoder =
        abstract ``size``: float with get, set
        abstract ``viewer``: JS.DataView with get, set
        abstract ``array``: JS.Uint8Array with get, set
        abstract ``byteArray``: U2<JS.Float32Array, JS.Uint16Array> option with get, set
        abstract ``offset``: DataCursor with get, set
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``channels``: float with get, set
        abstract ``channelLineOffsets``: IDecodeChannel with get, set
        abstract ``scanOrder``: IEXRDecoderScanOrderCallback with get, set
        abstract ``bytesPerLine``: float with get, set
        abstract ``outLineWidth``: float with get, set
        abstract ``lines``: float with get, set
        abstract ``scanlineBlockSize``: float with get, set
        abstract ``inputSize``: float option with get, set
        abstract ``type``: float with get, set
        abstract ``uncompress``: IEXRDecoderUncompressCallback option with get, set
        abstract ``getter``: IEXRDecoderGetterCallback with get, set
        abstract ``format``: float with get, set
        abstract ``outputChannels``: float with get, set
        abstract ``decodeChannels``: IDecodeChannel with get, set
        abstract ``blockCount``: float option with get, set
        abstract ``linearSpace``: bool with get, set
        abstract ``textureType``: float with get, set

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<AllowNullLiteral>]
    type IEXRHeader =
        abstract ``version``: float with get, set
        abstract ``spec``: InlineObject672ce066a49aObject with get, set
        abstract ``dataWindow``: InlineObjecte6832153d51cObject with get, set
        abstract ``channels``: ResizeArray<IEXRCHannel> with get, set
        [<EmitIndexer>] abstract Item: ``name``: string -> obj with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphBitwiseBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``valueType``: BabylonjsBindings.StringEnums.FlowGraphTypes with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathCombineExtractBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphCombineMatrixBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``inputIsColumnMajor``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/flowGraphConsoleLogBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphConsoleLogBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``messageTemplate``: string option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphConstantBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphConstantBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``value``: 'T with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphDataSwitchBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphDataSwitchBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``cases``: ResizeArray<BabylonjsBindings.TypeAliases.FlowGraphNumber> with get, set
        abstract ``treatCasesAsIntegers``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphDoNBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphDoNBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``startIndex``: BabylonjsBindings.SimpleClasses.FlowGraphInteger option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphFlipFlopBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphFlipFlopBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``startValue``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphTypeToTypeBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphFloatToIntConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``roundingMode``: U3<StringLiterala3e1f4935b09, StringLiteral0fdfeaa68c7b, StringLiterala97b0931730e> option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphForLoopBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphForLoopBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``initialIndex``: BabylonjsBindings.TypeAliases.FlowGraphNumber option with get, set
        abstract ``incrementIndexWhenLoopDone``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetAssetBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphGetAssetBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``type``: 'T with get, set
        abstract ``index``: U2<float, BabylonjsBindings.SimpleClasses.FlowGraphInteger> option with get, set
        abstract ``useIndexAsUniqueId``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetVariableBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphGetVariableBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``variable``: string with get, set
        abstract ``initialValue``: 'T option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphInterpolationBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphInterpolationBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``keyFramesCount``: float option with get, set
        abstract ``duration``: float option with get, set
        abstract ``propertyName``: U2<string, ResizeArray<string>> option with get, set
        abstract ``animationType``: U2<float, BabylonjsBindings.StringEnums.FlowGraphTypes> option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphKeyboardEventBlock
    [<AllowNullLiteral>]
    type IFlowGraphKeyboardEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``stopPropagation``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphMathBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``useMatrixPerComponent``: bool option with get, set
        abstract ``type``: BabylonjsBindings.StringEnums.FlowGraphTypes option with get, set
        abstract ``preventIntegerFloatArithmetic``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMatrixMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphMatrixBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``matrixType``: BabylonjsBindings.StringEnums.FlowGraphTypes with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphMultiGateBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphMultiGateBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``outputSignalCount``: float with get, set
        abstract ``isRandom``: bool option with get, set
        abstract ``isLoop``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphVectorMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphNormalizeBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``nanOnZeroLength``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPhysicsCollisionEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphPhysicsCollisionEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphRandomBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``min``: float option with get, set
        abstract ``max``: float option with get, set
        abstract ``seed``: float option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphReceiveCustomEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphReceiveCustomEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``eventId``: string with get, set
        abstract ``eventData``: InlineObject8f714ae92303Object with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphRoundBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``roundHalfAwayFromZero``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphSendCustomEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphSendCustomEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``eventId``: string with get, set
        abstract ``eventData``: InlineObject4d78ed30f56dObject with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSequenceBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphSequenceBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``outputSignalCount``: float option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetVariableBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphSetVariableBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``variable``: string option with get, set
        abstract ``variables``: ResizeArray<string> option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSwitchBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphSwitchBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``cases``: ResizeArray<'T> with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphVectorMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphTransformBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``vectorType``: BabylonjsBindings.StringEnums.FlowGraphTypes with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphWaitAllBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphWaitAllBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``inputSignalCount``: float with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphWhileLoopBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphWhileLoopBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``doWhile``: bool option with get, set

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
    type IGLTFChildRootProperty =
        inherit IGLTFProperty
        abstract ``name``: string option with get, set

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    [<AllowNullLiteral>]
    type IGLTFLoaderData =
        abstract ``json``: JavaScriptObject with get, set
        abstract ``bin``: IDataBuffer option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFMeshPrimitive =
        inherit IGLTFProperty
        abstract ``attributes``: InlineObject8681f48cdb3dObject with get, set
        abstract ``indices``: string with get, set
        abstract ``material``: string with get, set
        abstract ``mode``: float option with get, set

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

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMotionControllerLayoutMap =
        [<EmitIndexer>] abstract Item: ``handedness``: string -> IMotionControllerLayout with get, set

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

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphKeyDownEventBlock
    [<AllowNullLiteral>]
    type IFlowGraphKeyDownEventBlockConfiguration =
        inherit IFlowGraphKeyboardEventBlockConfiguration
        abstract ``ignoreRepeat``: bool option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAccessor =
        inherit IGLTFChildRootProperty
        abstract ``bufferView``: string with get, set
        abstract ``byteOffset``: float with get, set
        abstract ``byteStride``: float with get, set
        abstract ``count``: float with get, set
        abstract ``type``: string with get, set
        abstract ``componentType``: BabylonjsBindings.Enums.EComponentType with get, set
        abstract ``max``: ResizeArray<float> option with get, set
        abstract ``min``: ResizeArray<float> option with get, set
        abstract ``name``: string option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAnimation =
        inherit IGLTFChildRootProperty
        abstract ``channels``: ResizeArray<IGLTFAnimationChannel> option with get, set
        abstract ``parameters``: InlineObject8681f48cdb3dObject option with get, set
        abstract ``samplers``: InlineObject249788b2ccc7Object option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFBuffer =
        inherit IGLTFChildRootProperty
        abstract ``uri``: string with get, set
        abstract ``byteLength``: float option with get, set
        abstract ``type``: string option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFBufferView =
        inherit IGLTFChildRootProperty
        abstract ``buffer``: string with get, set
        abstract ``byteOffset``: float with get, set
        abstract ``byteLength``: float with get, set
        abstract ``byteStride``: float with get, set
        abstract ``target``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFCamera =
        inherit IGLTFChildRootProperty
        abstract ``type``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFImage =
        inherit IGLTFChildRootProperty
        abstract ``uri``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFLight =
        inherit IGLTFChildRootProperty
        abstract ``type``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFMaterial =
        inherit IGLTFChildRootProperty
        abstract ``technique``: string option with get, set
        abstract ``values``: ResizeArray<string> with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFMesh =
        inherit IGLTFChildRootProperty
        abstract ``primitives``: ResizeArray<IGLTFMeshPrimitive> with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFProgram =
        inherit IGLTFChildRootProperty
        abstract ``attributes``: ResizeArray<string> with get, set
        abstract ``fragmentShader``: string with get, set
        abstract ``vertexShader``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFSampler =
        inherit IGLTFChildRootProperty
        abstract ``magFilter``: float option with get, set
        abstract ``minFilter``: float option with get, set
        abstract ``wrapS``: float option with get, set
        abstract ``wrapT``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFScene =
        inherit IGLTFChildRootProperty
        abstract ``nodes``: ResizeArray<string> with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFShader =
        inherit IGLTFChildRootProperty
        abstract ``uri``: string with get, set
        abstract ``type``: BabylonjsBindings.Enums.EShaderType with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechnique =
        inherit IGLTFChildRootProperty
        abstract ``parameters``: InlineObjectc6343ebc447eObject with get, set
        abstract ``program``: string with get, set
        abstract ``attributes``: InlineObject8681f48cdb3dObject with get, set
        abstract ``uniforms``: InlineObject8681f48cdb3dObject with get, set
        abstract ``states``: IGLTFTechniqueStates with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMotionControllerProfile =
        abstract ``fallbackProfileIds``: ResizeArray<string> with get, set
        abstract ``layouts``: IMotionControllerLayoutMap with get, set
        abstract ``profileId``: string with get, set

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

    /// @babylonjs/core/Sprites/ISprites
    [<AllowNullLiteral>]
    type ISpriteJSONAtlas =
        abstract ``frames``: ResizeArray<ISpriteJSONSprite> with get, set
        abstract ``meta``: JavaScriptObject option with get, set

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

    /// Distinct ambient OffscreenCanvas handle used by ImageBitmapSource.
    [<AllowNullLiteral>]
    type BrowserOffscreenCanvas =
        interface end

    /// Distinct ambient WebGL2 rendering-context handle.
    [<AllowNullLiteral>]
    type BrowserWebGL2RenderingContext =
        interface end

    /// Distinct ambient WebAudio context handle.
    [<AllowNullLiteral>]
    type BrowserAudioContext =
        interface end

    /// Distinct ambient WebAudio destination-node handle.
    [<AllowNullLiteral>]
    type BrowserAudioDestinationNode =
        interface end

    /// Distinct ambient media-stream audio destination-node handle.
    [<AllowNullLiteral>]
    type BrowserMediaStreamAudioDestinationNode =
        interface end

    /// Distinct ambient WebXR session handle.
    [<AllowNullLiteral>]
    type BrowserXRSession =
        interface end

    /// Distinct ambient WebXR frame handle.
    [<AllowNullLiteral>]
    type BrowserXRFrame =
        interface end

    /// Distinct ambient WebXR layer handle.
    [<AllowNullLiteral>]
    type BrowserXRLayer =
        interface end

    /// Distinct ambient WebXR WebGL-layer handle.
    [<AllowNullLiteral>]
    type BrowserXRWebGLLayer =
        inherit BrowserXRLayer

    /// Distinct ambient WebXR WebGL-layer initialization surface.
    [<AllowNullLiteral>]
    type BrowserXRWebGLLayerInit =
        interface end

    /// Distinct ambient WebXR session initialization surface.
    [<AllowNullLiteral>]
    type BrowserXRSessionInit =
        interface end

    /// Exact WebXR reference-space literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRReferenceSpaceType =
        | [<CompiledName("viewer")>] Viewer
        | [<CompiledName("local")>] Local
        | [<CompiledName("local-floor")>] LocalFloor
        | [<CompiledName("bounded-floor")>] BoundedFloor
        | [<CompiledName("unbounded")>] Unbounded

    /// Exact WebXR session-mode literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRSessionMode =
        | [<CompiledName("inline")>] Inline
        | [<CompiledName("immersive-ar")>] ImmersiveAr
        | [<CompiledName("immersive-vr")>] ImmersiveVr

    /// Exact WebGPU power-preference literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUPowerPreference =
        | [<CompiledName("high-performance")>] HighPerformance
        | [<CompiledName("low-power")>] LowPower

    /// Exact numeric literal type for 33776.
    type NumericLiteral33776 =
        | Value = 33776

    /// Exact numeric literal type for 33777.
    type NumericLiteral33777 =
        | Value = 33777

    /// Exact numeric literal type for 33778.
    type NumericLiteral33778 =
        | Value = 33778

    /// Exact numeric literal type for 33779.
    type NumericLiteral33779 =
        | Value = 33779

    /// Exact numeric literal type for 34046.
    type NumericLiteral34046 =
        | Value = 34046

    /// Exact numeric literal type for 34047.
    type NumericLiteral34047 =
        | Value = 34047

    /// Exact numeric literal type for 35916.
    type NumericLiteral35916 =
        | Value = 35916

    /// Exact numeric literal type for 35917.
    type NumericLiteral35917 =
        | Value = 35917

    /// Exact numeric literal type for 35918.
    type NumericLiteral35918 =
        | Value = 35918

    /// Exact numeric literal type for 35919.
    type NumericLiteral35919 =
        | Value = 35919

    /// Exact numeric enum subset projected from a TypeScript Exclude utility.
    type PointerInputExcluding6a48353fe9 =
        | LeftClick = 2
        | MiddleClick = 3
        | RightClick = 4
        | BrowserBack = 5
        | BrowserForward = 6
        | MouseWheelX = 7
        | MouseWheelY = 8
        | MouseWheelZ = 9
        | Move = 12

    /// Exact numeric enum subset projected from a TypeScript Exclude utility.
    type PointerInputExcluding9b1eb22bd0 =
        | LeftClick = 2
        | MiddleClick = 3
        | RightClick = 4
        | BrowserBack = 5
        | BrowserForward = 6
        | Move = 12

    /// Exact opaque WebGLQuery handle.
    [<AllowNullLiteral>]
    type BrowserWebGLQuery =
        interface end

    /// Distinct opaque handle for the ambient JavaScript RegExp API.
    [<AllowNullLiteral>]
    type BrowserRegExp =
        interface end

    /// Exact GPUBuffer map-state literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUBufferMapState =
        | [<CompiledName("mapped")>] Mapped
        | [<CompiledName("pending")>] Pending
        | [<CompiledName("unmapped")>] Unmapped

    /// Exact WebGPU comparison-function literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUCompareFunction =
        | [<CompiledName("never")>] Never
        | [<CompiledName("less")>] Less
        | [<CompiledName("equal")>] Equal
        | [<CompiledName("less-equal")>] LessEqual
        | [<CompiledName("greater")>] Greater
        | [<CompiledName("not-equal")>] NotEqual
        | [<CompiledName("greater-equal")>] GreaterEqual
        | [<CompiledName("always")>] Always

    /// Exact WebGPU storage-texture access literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUStorageTextureAccess =
        | [<CompiledName("write-only")>] WriteOnly
        | [<CompiledName("read-only")>] ReadOnly
        | [<CompiledName("read-write")>] ReadWrite

    /// Exact WebGPU texture sample type literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUTextureSampleType =
        | [<CompiledName("float")>] Float
        | [<CompiledName("unfilterable-float")>] UnfilterableFloat
        | [<CompiledName("depth")>] Depth
        | [<CompiledName("sint")>] Sint
        | [<CompiledName("uint")>] Uint

    /// Exact WebGPU sampler binding type literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUSamplerBindingType =
        | [<CompiledName("filtering")>] Filtering
        | [<CompiledName("non-filtering")>] NonFiltering
        | [<CompiledName("comparison")>] Comparison

    /// Exact WebGPU GPUBuffer instance surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserGPUBuffer =
        abstract label: string with get, set
        abstract size: float with get
        abstract usage: float with get
        abstract mapState: BrowserGPUBufferMapState with get
        abstract mapAsync: mode: float * ?offset: float * ?size: float -> JS.Promise<unit>
        abstract getMappedRange: ?offset: float * ?size: float -> JS.ArrayBuffer
        abstract unmap: unit -> unit
        abstract destroy: unit -> unit

    /// Distinct ambient WebGPU device handle.
    [<AllowNullLiteral>]
    type BrowserGPUDevice =
        interface end

    /// Distinct ambient WebGPU render-pass encoder handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderPassEncoder =
        interface end

    /// Distinct ambient WebGPU render bundle handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderBundle =
        interface end

    /// Distinct ambient WebGPU sampler handle.
    [<AllowNullLiteral>]
    type BrowserGPUSampler =
        interface end

    /// Distinct ambient WebGPU render-bundle encoder handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderBundleEncoder =
        interface end

    /// Distinct ambient WebGPU programmable-stage descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPUProgrammableStage =
        interface end

    /// Distinct ambient WebGPU device-descriptor surface.
    [<AllowNullLiteral>]
    type BrowserGPUDeviceDescriptor =
        interface end

    /// Exact WebGPU adapter-request options surface.
    [<AllowNullLiteral>]
    type BrowserGPURequestAdapterOptions =
        abstract featureLevel: string option with get, set
        abstract powerPreference: BrowserGPUPowerPreference option with get, set
        abstract forceFallbackAdapter: bool option with get, set
        abstract xrCompatible: bool option with get, set

    /// Exact GPUTextureFormat literals from the WebGPU specification.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUTextureFormat =
        | [<CompiledName("r8unorm")>] R8unorm
        | [<CompiledName("r8snorm")>] R8snorm
        | [<CompiledName("r8uint")>] R8uint
        | [<CompiledName("r8sint")>] R8sint
        | [<CompiledName("r16unorm")>] R16unorm
        | [<CompiledName("r16snorm")>] R16snorm
        | [<CompiledName("r16uint")>] R16uint
        | [<CompiledName("r16sint")>] R16sint
        | [<CompiledName("r16float")>] R16float
        | [<CompiledName("rg8unorm")>] Rg8unorm
        | [<CompiledName("rg8snorm")>] Rg8snorm
        | [<CompiledName("rg8uint")>] Rg8uint
        | [<CompiledName("rg8sint")>] Rg8sint
        | [<CompiledName("r32uint")>] R32uint
        | [<CompiledName("r32sint")>] R32sint
        | [<CompiledName("r32float")>] R32float
        | [<CompiledName("rg16unorm")>] Rg16unorm
        | [<CompiledName("rg16snorm")>] Rg16snorm
        | [<CompiledName("rg16uint")>] Rg16uint
        | [<CompiledName("rg16sint")>] Rg16sint
        | [<CompiledName("rg16float")>] Rg16float
        | [<CompiledName("rgba8unorm")>] Rgba8unorm
        | [<CompiledName("rgba8unorm-srgb")>] Rgba8unormSrgb
        | [<CompiledName("rgba8snorm")>] Rgba8snorm
        | [<CompiledName("rgba8uint")>] Rgba8uint
        | [<CompiledName("rgba8sint")>] Rgba8sint
        | [<CompiledName("bgra8unorm")>] Bgra8unorm
        | [<CompiledName("bgra8unorm-srgb")>] Bgra8unormSrgb
        | [<CompiledName("rgb9e5ufloat")>] Rgb9e5ufloat
        | [<CompiledName("rgb10a2uint")>] Rgb10a2uint
        | [<CompiledName("rgb10a2unorm")>] Rgb10a2unorm
        | [<CompiledName("rg11b10ufloat")>] Rg11b10ufloat
        | [<CompiledName("rg32uint")>] Rg32uint
        | [<CompiledName("rg32sint")>] Rg32sint
        | [<CompiledName("rg32float")>] Rg32float
        | [<CompiledName("rgba16unorm")>] Rgba16unorm
        | [<CompiledName("rgba16snorm")>] Rgba16snorm
        | [<CompiledName("rgba16uint")>] Rgba16uint
        | [<CompiledName("rgba16sint")>] Rgba16sint
        | [<CompiledName("rgba16float")>] Rgba16float
        | [<CompiledName("rgba32uint")>] Rgba32uint
        | [<CompiledName("rgba32sint")>] Rgba32sint
        | [<CompiledName("rgba32float")>] Rgba32float
        | [<CompiledName("stencil8")>] Stencil8
        | [<CompiledName("depth16unorm")>] Depth16unorm
        | [<CompiledName("depth24plus")>] Depth24plus
        | [<CompiledName("depth24plus-stencil8")>] Depth24plusStencil8
        | [<CompiledName("depth32float")>] Depth32float
        | [<CompiledName("depth32float-stencil8")>] Depth32floatStencil8
        | [<CompiledName("bc1-rgba-unorm")>] Bc1RgbaUnorm
        | [<CompiledName("bc1-rgba-unorm-srgb")>] Bc1RgbaUnormSrgb
        | [<CompiledName("bc2-rgba-unorm")>] Bc2RgbaUnorm
        | [<CompiledName("bc2-rgba-unorm-srgb")>] Bc2RgbaUnormSrgb
        | [<CompiledName("bc3-rgba-unorm")>] Bc3RgbaUnorm
        | [<CompiledName("bc3-rgba-unorm-srgb")>] Bc3RgbaUnormSrgb
        | [<CompiledName("bc4-r-unorm")>] Bc4RUnorm
        | [<CompiledName("bc4-r-snorm")>] Bc4RSnorm
        | [<CompiledName("bc5-rg-unorm")>] Bc5RgUnorm
        | [<CompiledName("bc5-rg-snorm")>] Bc5RgSnorm
        | [<CompiledName("bc6h-rgb-ufloat")>] Bc6hRgbUfloat
        | [<CompiledName("bc6h-rgb-float")>] Bc6hRgbFloat
        | [<CompiledName("bc7-rgba-unorm")>] Bc7RgbaUnorm
        | [<CompiledName("bc7-rgba-unorm-srgb")>] Bc7RgbaUnormSrgb
        | [<CompiledName("etc2-rgb8unorm")>] Etc2Rgb8unorm
        | [<CompiledName("etc2-rgb8unorm-srgb")>] Etc2Rgb8unormSrgb
        | [<CompiledName("etc2-rgb8a1unorm")>] Etc2Rgb8a1unorm
        | [<CompiledName("etc2-rgb8a1unorm-srgb")>] Etc2Rgb8a1unormSrgb
        | [<CompiledName("etc2-rgba8unorm")>] Etc2Rgba8unorm
        | [<CompiledName("etc2-rgba8unorm-srgb")>] Etc2Rgba8unormSrgb
        | [<CompiledName("eac-r11unorm")>] EacR11unorm
        | [<CompiledName("eac-r11snorm")>] EacR11snorm
        | [<CompiledName("eac-rg11unorm")>] EacRg11unorm
        | [<CompiledName("eac-rg11snorm")>] EacRg11snorm
        | [<CompiledName("astc-4x4-unorm")>] Astc4x4Unorm
        | [<CompiledName("astc-4x4-unorm-srgb")>] Astc4x4UnormSrgb
        | [<CompiledName("astc-5x4-unorm")>] Astc5x4Unorm
        | [<CompiledName("astc-5x4-unorm-srgb")>] Astc5x4UnormSrgb
        | [<CompiledName("astc-5x5-unorm")>] Astc5x5Unorm
        | [<CompiledName("astc-5x5-unorm-srgb")>] Astc5x5UnormSrgb
        | [<CompiledName("astc-6x5-unorm")>] Astc6x5Unorm
        | [<CompiledName("astc-6x5-unorm-srgb")>] Astc6x5UnormSrgb
        | [<CompiledName("astc-6x6-unorm")>] Astc6x6Unorm
        | [<CompiledName("astc-6x6-unorm-srgb")>] Astc6x6UnormSrgb
        | [<CompiledName("astc-8x5-unorm")>] Astc8x5Unorm
        | [<CompiledName("astc-8x5-unorm-srgb")>] Astc8x5UnormSrgb
        | [<CompiledName("astc-8x6-unorm")>] Astc8x6Unorm
        | [<CompiledName("astc-8x6-unorm-srgb")>] Astc8x6UnormSrgb
        | [<CompiledName("astc-8x8-unorm")>] Astc8x8Unorm
        | [<CompiledName("astc-8x8-unorm-srgb")>] Astc8x8UnormSrgb
        | [<CompiledName("astc-10x5-unorm")>] Astc10x5Unorm
        | [<CompiledName("astc-10x5-unorm-srgb")>] Astc10x5UnormSrgb
        | [<CompiledName("astc-10x6-unorm")>] Astc10x6Unorm
        | [<CompiledName("astc-10x6-unorm-srgb")>] Astc10x6UnormSrgb
        | [<CompiledName("astc-10x8-unorm")>] Astc10x8Unorm
        | [<CompiledName("astc-10x8-unorm-srgb")>] Astc10x8UnormSrgb
        | [<CompiledName("astc-10x10-unorm")>] Astc10x10Unorm
        | [<CompiledName("astc-10x10-unorm-srgb")>] Astc10x10UnormSrgb
        | [<CompiledName("astc-12x10-unorm")>] Astc12x10Unorm
        | [<CompiledName("astc-12x10-unorm-srgb")>] Astc12x10UnormSrgb
        | [<CompiledName("astc-12x12-unorm")>] Astc12x12Unorm
        | [<CompiledName("astc-12x12-unorm-srgb")>] Astc12x12UnormSrgb

    /// Exact WEBGL_compressed_texture_s3tc extension surface.
    [<AllowNullLiteral>]
    type BrowserWebGLCompressedTextureS3tc =
        abstract COMPRESSED_RGB_S3TC_DXT1_EXT: NumericLiteral33776 with get
        abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: NumericLiteral33777 with get
        abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: NumericLiteral33778 with get
        abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: NumericLiteral33779 with get

    /// Exact WEBGL_compressed_texture_s3tc_srgb extension surface.
    [<AllowNullLiteral>]
    type BrowserWebGLCompressedTextureS3tcSrgb =
        abstract COMPRESSED_SRGB_S3TC_DXT1_EXT: NumericLiteral35916 with get
        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT: NumericLiteral35917 with get
        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT: NumericLiteral35918 with get
        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT: NumericLiteral35919 with get

    /// Exact EXT_texture_filter_anisotropic extension surface.
    [<AllowNullLiteral>]
    type BrowserExtTextureFilterAnisotropic =
        abstract TEXTURE_MAX_ANISOTROPY_EXT: NumericLiteral34046 with get
        abstract MAX_TEXTURE_MAX_ANISOTROPY_EXT: NumericLiteral34047 with get

    /// Exact Babylon EXT_disjoint_timer_query extension surface.
    [<AllowNullLiteral>]
    type BrowserExtDisjointTimerQuery =
        abstract QUERY_COUNTER_BITS_EXT: float with get, set
        abstract TIME_ELAPSED_EXT: float with get, set
        abstract TIMESTAMP_EXT: float with get, set
        abstract GPU_DISJOINT_EXT: float with get, set
        abstract QUERY_RESULT_EXT: float with get, set
        abstract QUERY_RESULT_AVAILABLE_EXT: float with get, set
        abstract queryCounterEXT: query: BrowserWebGLQuery * target: float -> unit
        abstract createQueryEXT: unit -> BrowserWebGLQuery
        abstract beginQueryEXT: target: float * query: BrowserWebGLQuery -> unit
        abstract endQueryEXT: target: float -> unit
        abstract getQueryObjectEXT: query: BrowserWebGLQuery * target: float -> obj
        abstract deleteQueryEXT: query: BrowserWebGLQuery -> unit

    /// Exact string literal type for "form".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral07397d633f25 =
        | [<CompiledName("form")>] Value

    /// Exact string literal type for "status".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral073c1634c496 =
        | [<CompiledName("status")>] Value

    /// Exact string literal type for "separator".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral080856f98d1e =
        | [<CompiledName("separator")>] Value

    /// Exact string literal type for "marquee".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral0ada0c035439 =
        | [<CompiledName("marquee")>] Value

    /// Exact string literal type for "table".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral0d4fc4a78d37 =
        | [<CompiledName("table")>] Value

    /// Exact string literal type for "main".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral0d6e4079e367 =
        | [<CompiledName("main")>] Value

    /// Exact string literal type for "searchbox".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral131ff8f4616b =
        | [<CompiledName("searchbox")>] Value

    /// Exact string literal type for "none".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral140bedbf9c3f =
        | [<CompiledName("none")>] Value

    /// Exact string literal type for "treegrid".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral189c7d737ca4 =
        | [<CompiledName("treegrid")>] Value

    /// Exact string literal type for "listitem".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral1bbc1b324415 =
        | [<CompiledName("listitem")>] Value

    /// Exact string literal type for "tooltip".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral1fb691986729 =
        | [<CompiledName("tooltip")>] Value

    /// Exact string literal type for "application".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral1fe289205936 =
        | [<CompiledName("application")>] Value

    /// Exact string literal type for "rowheader".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral224f0009e42e =
        | [<CompiledName("rowheader")>] Value

    /// Exact string literal type for "search".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral241932906782 =
        | [<CompiledName("search")>] Value

    /// Exact string literal type for "scrollbar".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral255512839036 =
        | [<CompiledName("scrollbar")>] Value

    /// Exact string literal type for "directory".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral333178788eae =
        | [<CompiledName("directory")>] Value

    /// Exact string literal type for "menu".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral398991009da1 =
        | [<CompiledName("menu")>] Value

    /// Exact string literal type for "cell".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral39d02b42938b =
        | [<CompiledName("cell")>] Value

    /// Exact string literal type for "document".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral43cc23fa52b8 =
        | [<CompiledName("document")>] Value

    /// Exact string literal type for "definition".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral4c4ed1afbfda =
        | [<CompiledName("definition")>] Value

    /// Exact string literal type for "math".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral58a6d6801ae7 =
        | [<CompiledName("math")>] Value

    /// Exact string literal type for "term".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral599f7703547e =
        | [<CompiledName("term")>] Value

    /// Exact string literal type for "heading".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral5e60ff5ac0ec =
        | [<CompiledName("heading")>] Value

    /// Exact string literal type for "meter".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral5eff322a1bd4 =
        | [<CompiledName("meter")>] Value

    /// Exact string literal type for "rowgroup".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral60f68f2044f1 =
        | [<CompiledName("rowgroup")>] Value

    /// Exact string literal type for "row".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral634768dae147 =
        | [<CompiledName("row")>] Value

    /// Exact string literal type for "dialog".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral694018943365 =
        | [<CompiledName("dialog")>] Value

    /// Exact string literal type for "tab".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral7508386a2056 =
        | [<CompiledName("tab")>] Value

    /// Exact string literal type for "switch".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral78b49fb2cc2d =
        | [<CompiledName("switch")>] Value

    /// Exact string literal type for "log".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral836ff184e7b4 =
        | [<CompiledName("log")>] Value

    /// Exact string literal type for "article".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral84393add8c48 =
        | [<CompiledName("article")>] Value

    /// Exact string literal type for "figure".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral889393fb69a5 =
        | [<CompiledName("figure")>] Value

    /// Exact string literal type for "banner".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral8c7ed2d9be59 =
        | [<CompiledName("banner")>] Value

    /// Exact string literal type for "combobox".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral92b4bb2797eb =
        | [<CompiledName("combobox")>] Value

    /// Exact string literal type for "contentinfo".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral9b3294b2882a =
        | [<CompiledName("contentinfo")>] Value

    /// Exact string literal type for "list".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala330395cc0a5 =
        | [<CompiledName("list")>] Value

    /// Exact string literal type for "alertdialog".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala52734c22880 =
        | [<CompiledName("alertdialog")>] Value

    /// Exact string literal type for "group".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralad936fcbed63 =
        | [<CompiledName("group")>] Value

    /// Exact string literal type for "columnheader".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraladb0e4b720cb =
        | [<CompiledName("columnheader")>] Value

    /// Exact string literal type for "treeitem".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralafe1839cc6d9 =
        | [<CompiledName("treeitem")>] Value

    /// Exact string literal type for "img".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralb29814cf5792 =
        | [<CompiledName("img")>] Value

    /// Exact string literal type for "menubar".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralb451d42f5637 =
        | [<CompiledName("menubar")>] Value

    /// Exact string literal type for "presentation".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralbfac314fefdc =
        | [<CompiledName("presentation")>] Value

    /// Exact string literal type for "region".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralc697d2981bf4 =
        | [<CompiledName("region")>] Value

    /// Exact string literal type for "feed".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralc8bc2586cdd8 =
        | [<CompiledName("feed")>] Value

    /// Exact string literal type for "tablist".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralcd3a6cfa3373 =
        | [<CompiledName("tablist")>] Value

    /// Exact string literal type for "timer".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralcd94ec90364d =
        | [<CompiledName("timer")>] Value

    /// Exact string literal type for "toolbar".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterald45928fd48ad =
        | [<CompiledName("toolbar")>] Value

    /// Exact string literal type for "navigation".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterald70d5a7909ed =
        | [<CompiledName("navigation")>] Value

    /// Exact string literal type for "tabpanel".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraldc6cd41a7aaf =
        | [<CompiledName("tabpanel")>] Value

    /// Exact string literal type for "tree".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraldc9c5edb8b2d =
        | [<CompiledName("tree")>] Value

    /// Exact string literal type for "alert".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraldf905058dd67 =
        | [<CompiledName("alert")>] Value

    /// Exact string literal type for "slider".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterale0d98dc32438 =
        | [<CompiledName("slider")>] Value

    /// Exact string literal type for "note".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraledb465624291 =
        | [<CompiledName("note")>] Value

    /// Exact string literal type for "complementary".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralf3051005444c =
        | [<CompiledName("complementary")>] Value

    /// Exact string literal type for "spinbutton".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralf4a201309311 =
        | [<CompiledName("spinbutton")>] Value

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject350439cd372aObject =
        abstract ``COMPLETION_STATUS_KHR``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type MappedObject582662fc4f76 =
        abstract ``abort``: System.Action<Browser.Types.Event option> with get, set
        abstract ``animationcancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``animationend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``animationiteration``: System.Action<Browser.Types.Event option> with get, set
        abstract ``animationstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``auxclick``: System.Action<Browser.Types.Event option> with get, set
        abstract ``beforeinput``: System.Action<Browser.Types.Event option> with get, set
        abstract ``beforematch``: System.Action<Browser.Types.Event option> with get, set
        abstract ``beforetoggle``: System.Action<Browser.Types.Event option> with get, set
        abstract ``blur``: System.Action<Browser.Types.Event option> with get, set
        abstract ``cancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``canplay``: System.Action<Browser.Types.Event option> with get, set
        abstract ``canplaythrough``: System.Action<Browser.Types.Event option> with get, set
        abstract ``change``: System.Action<Browser.Types.Event option> with get, set
        abstract ``click``: System.Action<Browser.Types.Event option> with get, set
        abstract ``close``: System.Action<Browser.Types.Event option> with get, set
        abstract ``compositionend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``compositionstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``compositionupdate``: System.Action<Browser.Types.Event option> with get, set
        abstract ``contextlost``: System.Action<Browser.Types.Event option> with get, set
        abstract ``contextmenu``: System.Action<Browser.Types.Event option> with get, set
        abstract ``contextrestored``: System.Action<Browser.Types.Event option> with get, set
        abstract ``copy``: System.Action<Browser.Types.Event option> with get, set
        abstract ``cuechange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``cut``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dblclick``: System.Action<Browser.Types.Event option> with get, set
        abstract ``drag``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragenter``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragleave``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragover``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``drop``: System.Action<Browser.Types.Event option> with get, set
        abstract ``durationchange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``emptied``: System.Action<Browser.Types.Event option> with get, set
        abstract ``ended``: System.Action<Browser.Types.Event option> with get, set
        abstract ``error``: System.Action<Browser.Types.Event option> with get, set
        abstract ``focus``: System.Action<Browser.Types.Event option> with get, set
        abstract ``focusin``: System.Action<Browser.Types.Event option> with get, set
        abstract ``focusout``: System.Action<Browser.Types.Event option> with get, set
        abstract ``formdata``: System.Action<Browser.Types.Event option> with get, set
        abstract ``fullscreenchange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``fullscreenerror``: System.Action<Browser.Types.Event option> with get, set
        abstract ``gotpointercapture``: System.Action<Browser.Types.Event option> with get, set
        abstract ``input``: System.Action<Browser.Types.Event option> with get, set
        abstract ``invalid``: System.Action<Browser.Types.Event option> with get, set
        abstract ``keydown``: System.Action<Browser.Types.Event option> with get, set
        abstract ``keypress``: System.Action<Browser.Types.Event option> with get, set
        abstract ``keyup``: System.Action<Browser.Types.Event option> with get, set
        abstract ``load``: System.Action<Browser.Types.Event option> with get, set
        abstract ``loadeddata``: System.Action<Browser.Types.Event option> with get, set
        abstract ``loadedmetadata``: System.Action<Browser.Types.Event option> with get, set
        abstract ``loadstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``lostpointercapture``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mousedown``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseenter``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseleave``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mousemove``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseout``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseover``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseup``: System.Action<Browser.Types.Event option> with get, set
        abstract ``paste``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pause``: System.Action<Browser.Types.Event option> with get, set
        abstract ``play``: System.Action<Browser.Types.Event option> with get, set
        abstract ``playing``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointercancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerdown``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerenter``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerleave``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointermove``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerout``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerover``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerrawupdate``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerup``: System.Action<Browser.Types.Event option> with get, set
        abstract ``progress``: System.Action<Browser.Types.Event option> with get, set
        abstract ``ratechange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``reset``: System.Action<Browser.Types.Event option> with get, set
        abstract ``resize``: System.Action<Browser.Types.Event option> with get, set
        abstract ``scroll``: System.Action<Browser.Types.Event option> with get, set
        abstract ``scrollend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``securitypolicyviolation``: System.Action<Browser.Types.Event option> with get, set
        abstract ``seeked``: System.Action<Browser.Types.Event option> with get, set
        abstract ``seeking``: System.Action<Browser.Types.Event option> with get, set
        abstract ``select``: System.Action<Browser.Types.Event option> with get, set
        abstract ``selectionchange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``selectstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``slotchange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``stalled``: System.Action<Browser.Types.Event option> with get, set
        abstract ``submit``: System.Action<Browser.Types.Event option> with get, set
        abstract ``suspend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``timeupdate``: System.Action<Browser.Types.Event option> with get, set
        abstract ``toggle``: System.Action<Browser.Types.Event option> with get, set
        abstract ``touchcancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``touchend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``touchmove``: System.Action<Browser.Types.Event option> with get, set
        abstract ``touchstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``transitioncancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``transitionend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``transitionrun``: System.Action<Browser.Types.Event option> with get, set
        abstract ``transitionstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``volumechange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``waiting``: System.Action<Browser.Types.Event option> with get, set
        abstract ``webkitanimationend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``webkitanimationiteration``: System.Action<Browser.Types.Event option> with get, set
        abstract ``webkitanimationstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``webkittransitionend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``wheel``: System.Action<Browser.Types.Event option> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type MappedObjectb2cbdb655794 =
        abstract ``aria-activedescendant``: obj with get, set
        abstract ``aria-atomic``: obj with get, set
        abstract ``aria-autocomplete``: obj with get, set
        abstract ``aria-busy``: obj with get, set
        abstract ``aria-checked``: obj with get, set
        abstract ``aria-colcount``: obj with get, set
        abstract ``aria-colindex``: obj with get, set
        abstract ``aria-colspan``: obj with get, set
        abstract ``aria-controls``: obj with get, set
        abstract ``aria-describedby``: obj with get, set
        abstract ``aria-description``: obj with get, set
        abstract ``aria-details``: obj with get, set
        abstract ``aria-disabled``: obj with get, set
        abstract ``aria-dropeffect``: obj with get, set
        abstract ``aria-errormessage``: obj with get, set
        abstract ``aria-expanded``: obj with get, set
        abstract ``aria-flowto``: obj with get, set
        abstract ``aria-grabbed``: obj with get, set
        abstract ``aria-haspopup``: obj with get, set
        abstract ``aria-hidden``: obj with get, set
        abstract ``aria-invalid``: obj with get, set
        abstract ``aria-label``: obj with get, set
        abstract ``aria-labelledby``: obj with get, set
        abstract ``aria-level``: obj with get, set
        abstract ``aria-live``: obj with get, set
        abstract ``aria-modal``: obj with get, set
        abstract ``aria-multiline``: obj with get, set
        abstract ``aria-multiselectable``: obj with get, set
        abstract ``aria-orientation``: obj with get, set
        abstract ``aria-owns``: obj with get, set
        abstract ``aria-placeholder``: obj with get, set
        abstract ``aria-posinset``: obj with get, set
        abstract ``aria-pressed``: obj with get, set
        abstract ``aria-readonly``: obj with get, set
        abstract ``aria-relevant``: obj with get, set
        abstract ``aria-required``: obj with get, set
        abstract ``aria-rowcount``: obj with get, set
        abstract ``aria-rowindex``: obj with get, set
        abstract ``aria-rowspan``: obj with get, set
        abstract ``aria-selected``: obj with get, set
        abstract ``aria-setsize``: obj with get, set
        abstract ``aria-sort``: obj with get, set
        abstract ``aria-valuemax``: obj with get, set
        abstract ``aria-valuemin``: obj with get, set
        abstract ``aria-valuenow``: obj with get, set
        abstract ``aria-valuetext``: obj with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectff2afb4ca968Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> U3<float, string, bool> option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectafdc7fcd70d1Object =
        abstract ``vertexCode``: string with get, set
        abstract ``fragmentCode``: string with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type BufferImageData =
        abstract ``length``: float with get, set
        abstract ``position``: float with get, set

    /// @babylonjs/core/Engines/engineCapabilities
    [<AllowNullLiteral>]
    type EngineCapabilities =
        abstract ``maxTexturesImageUnits``: float with get, set
        abstract ``maxVertexTextureImageUnits``: float with get, set
        abstract ``maxCombinedTexturesImageUnits``: float with get, set
        abstract ``maxTextureSize``: float with get, set
        abstract ``maxSamples``: float option with get, set
        abstract ``maxDrawBuffers``: float option with get, set
        abstract ``maxCubemapTextureSize``: float with get, set
        abstract ``maxRenderTextureSize``: float with get, set
        abstract ``maxVertexAttribs``: float with get, set
        abstract ``maxVaryingVectors``: float with get, set
        abstract ``maxVertexUniformVectors``: float with get, set
        abstract ``maxFragmentUniformVectors``: float with get, set
        abstract ``shaderFloatPrecision``: float with get, set
        abstract ``standardDerivatives``: bool with get, set
        abstract ``s3tc``: BrowserWebGLCompressedTextureS3tc option with get, set
        abstract ``s3tc_srgb``: BrowserWebGLCompressedTextureS3tcSrgb option with get, set
        abstract ``pvrtc``: obj with get, set
        abstract ``etc1``: obj with get, set
        abstract ``etc2``: obj with get, set
        abstract ``astc``: obj with get, set
        abstract ``bptc``: obj with get, set
        abstract ``textureFloat``: bool with get, set
        abstract ``vertexArrayObject``: bool with get, set
        abstract ``textureAnisotropicFilterExtension``: BrowserExtTextureFilterAnisotropic option with get, set
        abstract ``maxAnisotropy``: float with get, set
        abstract ``instancedArrays``: bool with get, set
        abstract ``uintIndices``: bool with get, set
        abstract ``highPrecisionShaderSupported``: bool with get, set
        abstract ``fragmentDepthSupported``: bool with get, set
        abstract ``textureFloatLinearFiltering``: bool with get, set
        abstract ``textureFloatRender``: bool with get, set
        abstract ``textureHalfFloat``: bool with get, set
        abstract ``textureHalfFloatLinearFiltering``: bool with get, set
        abstract ``textureHalfFloatRender``: bool with get, set
        abstract ``textureLOD``: bool with get, set
        abstract ``texelFetch``: bool with get, set
        abstract ``drawBuffersExtension``: bool with get, set
        abstract ``depthTextureExtension``: bool with get, set
        abstract ``colorBufferFloat``: bool with get, set
        abstract ``blendFloat``: bool with get, set
        abstract ``colorBufferHalfFloat``: bool option with get, set
        abstract ``timerQuery``: BrowserExtDisjointTimerQuery option with get, set
        abstract ``canUseTimestampForTimerQuery``: bool with get, set
        abstract ``supportOcclusionQuery``: bool with get, set
        abstract ``multiview``: obj option with get, set
        abstract ``oculusMultiview``: obj option with get, set
        abstract ``parallelShaderCompile``: InlineObject350439cd372aObject option with get, set
        abstract ``maxMSAASamples``: float with get, set
        abstract ``blendMinMax``: bool with get, set
        abstract ``canUseGLInstanceID``: bool with get, set
        abstract ``canUseGLVertexID``: bool with get, set
        abstract ``supportComputeShaders``: bool with get, set
        abstract ``supportSRGBBuffers``: bool with get, set
        abstract ``supportTransformFeedbacks``: bool with get, set
        abstract ``textureMaxLevel``: bool with get, set
        abstract ``texture2DArrayMaxLayerCount``: float with get, set
        abstract ``disableMorphTargetTexture``: bool with get, set
        abstract ``supportFloatTexturesResolve``: bool with get, set
        abstract ``rg11b10ufColorRenderable``: bool with get, set
        abstract ``textureNorm16``: bool with get, set
        abstract ``blendParametersPerTarget``: bool with get, set
        abstract ``dualSourceBlending``: bool with get, set
        abstract ``supportReadWriteStorageTextures``: bool with get, set

    /// @babylonjs/core/IAccessibilityTag
    [<AllowNullLiteral>]
    type IAccessibilityTag =
        abstract ``description``: string option with get, set
        abstract ``eventHandler``: MappedObject582662fc4f76 option with get, set
        abstract ``role``: U2<U8<StringLiterald45928fd48ad, StringLiteral1fb691986729, StringLiteralc8bc2586cdd8, StringLiteral58a6d6801ae7, StringLiteralbfac314fefdc, StringLiteral140bedbf9c3f, StringLiteraledb465624291, StringLiteral1fe289205936>, U2<U8<StringLiteral84393add8c48, StringLiteral39d02b42938b, StringLiteraladb0e4b720cb, StringLiteral4c4ed1afbfda, StringLiteral333178788eae, StringLiteral43cc23fa52b8, StringLiteral889393fb69a5, StringLiteralad936fcbed63>, U2<U8<StringLiteral5e60ff5ac0ec, StringLiteralb29814cf5792, StringLiterala330395cc0a5, StringLiteral1bbc1b324415, StringLiteral5eff322a1bd4, StringLiteral634768dae147, StringLiteral60f68f2044f1, StringLiteral224f0009e42e>, U2<U8<StringLiteral080856f98d1e, StringLiteral0d4fc4a78d37, StringLiteral599f7703547e, StringLiteral255512839036, StringLiteral131ff8f4616b, StringLiterale0d98dc32438, StringLiteralf4a201309311, StringLiteral78b49fb2cc2d>, U2<U8<StringLiteral7508386a2056, StringLiteraldc6cd41a7aaf, StringLiteralafe1839cc6d9, StringLiteral92b4bb2797eb, StringLiteral398991009da1, StringLiteralb451d42f5637, StringLiteralcd3a6cfa3373, StringLiteraldc9c5edb8b2d>, U2<U8<StringLiteral189c7d737ca4, StringLiteral8c7ed2d9be59, StringLiteralf3051005444c, StringLiteral9b3294b2882a, StringLiteral07397d633f25, StringLiteral0d6e4079e367, StringLiterald70d5a7909ed, StringLiteralc697d2981bf4>, U8<StringLiteral241932906782, StringLiteraldf905058dd67, StringLiteral836ff184e7b4, StringLiteral0ada0c035439, StringLiteral073c1634c496, StringLiteralcd94ec90364d, StringLiterala52734c22880, StringLiteral694018943365>>>>>>> option with get, set
        abstract ``aria``: MappedObjectb2cbdb655794 option with get, set

    /// @babylonjs/core/Audio/Interfaces/IAudioEngineOptions
    [<AllowNullLiteral>]
    type IAudioEngineOptions =
        abstract ``audioContext``: BrowserAudioContext option with get, set
        abstract ``audioDestination``: U2<BrowserAudioDestinationNode, BrowserMediaStreamAudioDestinationNode> option with get, set

    /// @babylonjs/core/Misc/customAnimationFrameRequester
    [<AllowNullLiteral>]
    type ICustomAnimationFrameRequester =
        abstract ``renderFunction``: System.Delegate option with get, set
        abstract ``requestAnimationFrame``: System.Delegate with get, set
        abstract ``requestID``: float option with get, set
        abstract ``cancelAnimationFrame``: System.Delegate option with get, set

    /// @babylonjs/core/Engines/IDrawContext
    [<AllowNullLiteral>]
    type IDrawContext =
        abstract ``uniqueId``: float with get, set
        abstract ``useInstancing``: bool with get, set
        abstract ``enableIndirectDraw``: bool with get, set
        abstract ``indirectDrawBuffer``: BrowserGPUBuffer option with get, set
        abstract ``setIndirectData``: ``indexOrVertexCount``: float * ``instanceCount``: float * ``firstIndexOrVertex``: float * ?``forceUpdate``: bool -> unit
        abstract ``reset``: unit -> unit
        abstract ``dispose``: unit -> unit

    /// Function-valued IImage.onload property.
    [<AllowNullLiteral>]
    type IImageOnloadCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``ev``: Browser.Types.Event -> obj

    /// Function-valued IImage.onerror property.
    [<AllowNullLiteral>]
    type IImageOnerrorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``ev``: Browser.Types.Event -> obj

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type IImage =
        abstract ``onload``: IImageOnloadCallback option with get, set
        abstract ``onerror``: IImageOnerrorCallback option with get, set
        abstract ``src``: string with get, set
        abstract ``width``: float with get
        abstract ``height``: float with get
        abstract ``naturalHeight``: float with get
        abstract ``naturalWidth``: float with get
        abstract ``crossOrigin``: string option with get, set
        abstract ``referrerPolicy``: string with get, set

    /// Function-valued INodeGeometryExecutionContext.getOverridePositionsContextualValue property.
    [<AllowNullLiteral>]
    type INodeGeometryExecutionContextGetOverridePositionsContextualValueCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> obj

    /// Function-valued INodeGeometryExecutionContext.getOverrideNormalsContextualValue property.
    [<AllowNullLiteral>]
    type INodeGeometryExecutionContextGetOverrideNormalsContextualValueCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> obj

    /// Function-valued INodeGeometryExecutionContext.getOverrideUVs1ContextualValue property.
    [<AllowNullLiteral>]
    type INodeGeometryExecutionContextGetOverrideUVs1ContextualValueCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> obj

    /// @babylonjs/core/Meshes/Node/Interfaces/nodeGeometryExecutionContext
    [<AllowNullLiteral>]
    type INodeGeometryExecutionContext =
        abstract ``getExecutionIndex``: unit -> float
        abstract ``getExecutionFaceIndex``: unit -> float
        abstract ``getExecutionLoopIndex``: unit -> float
        abstract ``getOverridePositionsContextualValue``: INodeGeometryExecutionContextGetOverridePositionsContextualValueCallback option with get, set
        abstract ``getOverrideNormalsContextualValue``: INodeGeometryExecutionContextGetOverrideNormalsContextualValueCallback option with get, set
        abstract ``getOverrideUVs1ContextualValue``: INodeGeometryExecutionContextGetOverrideUVs1ContextualValueCallback option with get, set

    /// @babylonjs/core/ObjectModel/objectModelInterfaces
    [<AllowNullLiteral>]
    type IObjectInfo<'T, 'O> =
        abstract ``object``: 'O with get, set
        abstract ``info``: 'T with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuBundleList
    [<AllowNullLiteral>]
    type IWebGPURenderItem =
        abstract ``run``: ``renderPass``: BrowserGPURenderPassEncoder -> unit
        abstract ``clone``: unit -> IWebGPURenderItem

    /// @babylonjs/core/Engines/WebGPU/webgpuPipelineContext
    [<AllowNullLiteral>]
    type IWebGPURenderPipelineStageDescriptor =
        abstract ``vertexStage``: BrowserGPUProgrammableStage with get, set
        abstract ``fragmentStage``: BrowserGPUProgrammableStage option with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type PLYHeader =
        abstract ``vertexCount``: float with get, set
        abstract ``chunkCount``: float with get, set
        abstract ``rowVertexLength``: float with get, set
        abstract ``rowChunkLength``: float with get, set
        abstract ``vertexProperties``: ResizeArray<BabylonjsBindings.TypeAliases.PlyProperty> with get, set
        abstract ``chunkProperties``: ResizeArray<BabylonjsBindings.TypeAliases.PlyProperty> with get, set
        abstract ``dataView``: JS.DataView with get, set
        abstract ``buffer``: JS.ArrayBuffer with get, set
        abstract ``shDegree``: float with get, set
        abstract ``shCoefficientCount``: float with get, set
        abstract ``shBuffer``: JS.ArrayBuffer option with get, set

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type AbstractEngineOptions =
        abstract ``limitDeviceRatio``: float option with get, set
        abstract ``audioEngine``: bool option with get, set
        abstract ``audioEngineOptions``: IAudioEngineOptions option with get, set
        abstract ``deterministicLockstep``: bool option with get, set
        abstract ``lockstepMaxSteps``: float option with get, set
        abstract ``timeStep``: float option with get, set
        abstract ``doNotHandleContextLost``: bool option with get, set
        abstract ``doNotHandleTouchAction``: bool option with get, set
        abstract ``useHighPrecisionMatrix``: bool option with get, set
        abstract ``useLargeWorldRendering``: bool option with get
        abstract ``adaptToDeviceRatio``: bool option with get, set
        abstract ``antialias``: bool option with get, set
        abstract ``stencil``: bool option with get, set
        abstract ``premultipliedAlpha``: bool option with get, set
        abstract ``useExactSrgbConversions``: bool option with get, set
        abstract ``canvasTabIndex``: float option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureIrradianceTextureInfoV1 =
        abstract ``size``: float with get, set
        abstract ``faces``: ResizeArray<BufferImageData> with get, set
        abstract ``dominantDirection``: ResizeArray<float> option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureSpecularInfoV1 =
        abstract ``mipmaps``: ResizeArray<BufferImageData> with get, set
        abstract ``lodGenerationScale``: float with get, set

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IMouseEvent =
        inherit IUIEvent
        abstract ``inputIndex``: PointerInputExcluding6a48353fe9 with get, set
        abstract ``altKey``: bool with get, set
        abstract ``button``: float with get, set
        abstract ``buttons``: float with get, set
        abstract ``clientX``: float with get, set
        abstract ``clientY``: float with get, set
        abstract ``ctrlKey``: bool with get, set
        abstract ``detail``: float option with get, set
        abstract ``metaKey``: bool with get, set
        abstract ``movementX``: float with get, set
        abstract ``movementY``: float with get, set
        abstract ``mozMovementX``: float option with get, set
        abstract ``mozMovementY``: float option with get, set
        abstract ``msMovementX``: float option with get, set
        abstract ``msMovementY``: float option with get, set
        abstract ``offsetX``: float with get, set
        abstract ``offsetY``: float with get, set
        abstract ``pageX``: float with get, set
        abstract ``pageY``: float with get, set
        abstract ``shiftKey``: bool with get, set
        abstract ``webkitMovementX``: float option with get, set
        abstract ``webkitMovementY``: float option with get, set
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    /// @babylonjs/core/Misc/observable.pure
    [<AllowNullLiteral>]
    type IReadonlyObservable<'T> =
        abstract ``add``: ``callback``: System.Action<'T, BabylonjsBindings.SimpleClasses.EventState> * ?``mask``: float * ?``insertFirst``: bool * ?``scope``: obj * ?``unregisterOnFirstCall``: bool -> IObserver
        abstract ``addOnce``: ``callback``: System.Action<'T, BabylonjsBindings.SimpleClasses.EventState> -> IObserver

    /// Function-valued ISceneLoaderPluginMetadata.canDirectLoad property.
    [<AllowNullLiteral>]
    type ISceneLoaderPluginMetadataCanDirectLoadCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: string -> bool

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderPluginMetadata =
        abstract ``name``: string with get
        abstract ``extensions``: U2<string, ISceneLoaderPluginExtensions> with get
        abstract ``canDirectLoad``: ISceneLoaderPluginMetadataCanDirectLoadCallback option with get, set

    /// Function-valued IShaderProcessor.preProcessShaderCode property.
    [<AllowNullLiteral>]
    type IShaderProcessorPreProcessShaderCodeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string * ``isFragment``: bool -> string

    /// Function-valued IShaderProcessor.attributeProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorAttributeProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``attribute``: string * ``preProcessors``: InlineObject8681f48cdb3dObject * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.varyingCheck property.
    [<AllowNullLiteral>]
    type IShaderProcessorVaryingCheckCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``varying``: string * ``isFragment``: bool -> bool

    /// Function-valued IShaderProcessor.varyingProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorVaryingProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``varying``: string * ``isFragment``: bool * ``preProcessors``: InlineObject8681f48cdb3dObject * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.uniformProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorUniformProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``uniform``: string * ``isFragment``: bool * ``preProcessors``: InlineObject8681f48cdb3dObject * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.uniformBufferProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorUniformBufferProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``uniformBuffer``: string * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.textureProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorTextureProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: string * ``isFragment``: bool * ``preProcessors``: InlineObject8681f48cdb3dObject * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.endOfUniformBufferProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorEndOfUniformBufferProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``closingBracketLine``: string * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.lineProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorLineProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``line``: string * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.preProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorPreProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string * ``defines``: ResizeArray<string> * ``preProcessors``: InlineObject8681f48cdb3dObject * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.postProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorPostProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string * ``defines``: ResizeArray<string> * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option * ``patameters``: InlineObjectff2afb4ca968Object * ``preProcessors``: InlineObject8681f48cdb3dObject * ``preProcessorsFromCode``: InlineObject8681f48cdb3dObject -> string

    /// Function-valued IShaderProcessor.initializeShaders property.
    [<AllowNullLiteral>]
    type IShaderProcessorInitializeShadersCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``processingContext``: _IShaderProcessingContext option -> unit

    /// Function-valued IShaderProcessor.finalizeShaders property.
    [<AllowNullLiteral>]
    type IShaderProcessorFinalizeShadersCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``vertexCode``: string * ``fragmentCode``: string * ``processingContext``: _IShaderProcessingContext option -> InlineObjectafdc7fcd70d1Object

    /// @babylonjs/core/Engines/Processors/iShaderProcessor
    [<AllowNullLiteral>]
    type IShaderProcessor =
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage with get, set
        abstract ``uniformRegexp``: BrowserRegExp option with get, set
        abstract ``uniformBufferRegexp``: BrowserRegExp option with get, set
        abstract ``textureRegexp``: BrowserRegExp option with get, set
        abstract ``noPrecision``: bool option with get, set
        abstract ``parseGLES3``: bool option with get, set
        abstract ``attributeKeywordName``: string option with get, set
        abstract ``varyingVertexKeywordName``: string option with get, set
        abstract ``varyingFragmentKeywordName``: string option with get, set
        abstract ``preProcessShaderCode``: IShaderProcessorPreProcessShaderCodeCallback option with get, set
        abstract ``attributeProcessor``: IShaderProcessorAttributeProcessorCallback option with get, set
        abstract ``varyingCheck``: IShaderProcessorVaryingCheckCallback option with get, set
        abstract ``varyingProcessor``: IShaderProcessorVaryingProcessorCallback option with get, set
        abstract ``uniformProcessor``: IShaderProcessorUniformProcessorCallback option with get, set
        abstract ``uniformBufferProcessor``: IShaderProcessorUniformBufferProcessorCallback option with get, set
        abstract ``textureProcessor``: IShaderProcessorTextureProcessorCallback option with get, set
        abstract ``endOfUniformBufferProcessor``: IShaderProcessorEndOfUniformBufferProcessorCallback option with get, set
        abstract ``lineProcessor``: IShaderProcessorLineProcessorCallback option with get, set
        abstract ``preProcessor``: IShaderProcessorPreProcessorCallback option with get, set
        abstract ``postProcessor``: IShaderProcessorPostProcessorCallback option with get, set
        abstract ``initializeShaders``: IShaderProcessorInitializeShadersCallback option with get, set
        abstract ``finalizeShaders``: IShaderProcessorFinalizeShadersCallback option with get, set

    /// Function-valued IWebXRFeature.getXRSessionInitExtension property.
    [<AllowNullLiteral>]
    type IWebXRFeatureGetXRSessionInitExtensionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> JS.Promise<BrowserXRSessionInit>

    /// @babylonjs/core/XR/webXRFeaturesManager
    [<AllowNullLiteral>]
    type IWebXRFeature =
        inherit IDisposable
        abstract ``attached``: bool with get, set
        abstract ``disableAutoAttach``: bool with get, set
        abstract ``attach``: ?``force``: bool -> bool
        abstract ``detach``: unit -> bool
        abstract ``isCompatible``: unit -> bool
        abstract ``isDisposed``: bool with get, set
        abstract ``xrNativeFeatureName``: string option with get, set
        abstract ``dependsOn``: ResizeArray<string> option with get, set
        abstract ``getXRSessionInitExtension``: IWebXRFeatureGetXRSessionInitExtensionCallback option with get, set
        abstract ``onFeatureAttachObservable``: BabylonjsBindings.SimpleClasses.Observable<IWebXRFeature> with get, set
        abstract ``onFeatureDetachObservable``: BabylonjsBindings.SimpleClasses.Observable<IWebXRFeature> with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUSamplerDescription =
        abstract ``binding``: WebGPUBindingInfo with get, set
        abstract ``type``: BrowserGPUSamplerBindingType with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUTextureDescription =
        abstract ``autoBindSampler``: bool option with get, set
        abstract ``isTextureArray``: bool with get, set
        abstract ``isStorageTexture``: bool with get, set
        abstract ``storageTextureAccess``: BrowserGPUStorageTextureAccess option with get, set
        abstract ``textures``: ResizeArray<WebGPUBindingInfo> with get, set
        abstract ``sampleType``: BrowserGPUTextureSampleType option with get, set

    /// @babylonjs/core/XR/webXRTypes
    [<AllowNullLiteral>]
    type WebXRRenderTarget<'TContext, 'TLayer when 'TLayer :> BrowserXRLayer> =
        inherit IDisposable
        abstract ``canvasContext``: 'TContext with get, set
        abstract ``xrLayer``: 'TLayer option with get, set
        abstract ``initializeXRLayerAsync``: ``xrSession``: BrowserXRSession -> JS.Promise<'TLayer>

    /// @babylonjs/core/Engines/Processors/shaderProcessingOptions
    [<AllowNullLiteral>]
    type _IProcessingOptions =
        abstract ``defines``: ResizeArray<string> with get, set
        abstract ``indexParameters``: obj with get, set
        abstract ``isFragment``: bool with get, set
        abstract ``shouldUseHighPrecisionShader``: bool with get, set
        abstract ``supportsUniformBuffers``: bool with get, set
        abstract ``shadersRepository``: string with get, set
        abstract ``includesShadersStore``: InlineObject8681f48cdb3dObject with get, set
        abstract ``processor``: IShaderProcessor option with get, set
        abstract ``version``: string with get, set
        abstract ``platformName``: string with get, set
        abstract ``lookForClosingBracketForUniformBuffer``: bool option with get, set
        abstract ``processingContext``: _IShaderProcessingContext option with get, set
        abstract ``isNDCHalfZRange``: bool with get, set
        abstract ``useReverseDepthBuffer``: bool with get, set
        abstract ``processCodeAfterIncludes``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set

    /// Exact optional-property projection used by Babylon Partial<_IProcessingOptions> signatures.
    [<AllowNullLiteral>]
    type Partial_IProcessingOptions =
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``indexParameters``: obj option with get, set
        abstract ``isFragment``: bool option with get, set
        abstract ``shouldUseHighPrecisionShader``: bool option with get, set
        abstract ``supportsUniformBuffers``: bool option with get, set
        abstract ``shadersRepository``: string option with get, set
        abstract ``includesShadersStore``: InlineObject8681f48cdb3dObject option with get, set
        abstract ``processor``: IShaderProcessor option with get, set
        abstract ``version``: string option with get, set
        abstract ``platformName``: string option with get, set
        abstract ``lookForClosingBracketForUniformBuffer``: bool option with get, set
        abstract ``processingContext``: _IShaderProcessingContext option with get, set
        abstract ``isNDCHalfZRange``: bool option with get, set
        abstract ``useReverseDepthBuffer``: bool option with get, set
        abstract ``processCodeAfterIncludes``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set

    /// @babylonjs/core/Engines/thinEngine.pure
    [<AllowNullLiteral>]
    type EngineOptions =
        inherit AbstractEngineOptions
        inherit Browser.Types.WebGLContextAttributes
        abstract ``disableWebGL2Support``: bool option with get, set
        abstract ``useHighPrecisionFloats``: bool option with get, set
        abstract ``xrCompatible``: bool option with get, set
        abstract ``failIfMajorPerformanceCaveat``: bool option with get, set
        abstract ``forceSRGBBufferSupportState``: bool option with get, set
        abstract ``loseContextOnDispose``: bool option with get, set

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IPointerEvent =
        inherit IMouseEvent
        abstract ``inputIndex``: PointerInputExcluding9b1eb22bd0 with get, set
        abstract ``pointerId``: float with get, set
        abstract ``pointerType``: string with get, set

    /// @babylonjs/core/Engines/webgpuEngine.pure
    [<AllowNullLiteral>]
    type WebGPUEngineOptions =
        inherit AbstractEngineOptions
        inherit BrowserGPURequestAdapterOptions
        abstract ``featureLevel``: string option with get, set
        abstract ``powerPreference``: BrowserGPUPowerPreference option with get, set
        abstract ``forceFallbackAdapter``: bool option with get, set
        abstract ``xrCompatible``: bool option with get, set
        abstract ``deviceDescriptor``: BrowserGPUDeviceDescriptor option with get, set
        abstract ``enableAllFeatures``: bool option with get, set
        abstract ``setMaximumLimits``: bool option with get, set
        abstract ``swapChainFormat``: BrowserGPUTextureFormat option with get, set
        abstract ``enableGPUDebugMarkers``: bool option with get, set
        abstract ``glslangOptions``: GlslangOptions option with get, set
        abstract ``twgslOptions``: TwgslOptions option with get, set

    /// Function-valued ICanvas.remove property.
    [<AllowNullLiteral>]
    type ICanvasRemoveCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type ICanvas =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``getContext``: ``contextType``: string * ?``contextAttributes``: obj -> ICanvasRenderingContext
        abstract ``toDataURL``: ``mime``: string -> string
        abstract ``remove``: ICanvasRemoveCallback option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type ICanvasRenderingContext =
        abstract ``lineJoin``: string with get, set
        abstract ``miterLimit``: float with get, set
        abstract ``font``: string with get, set
        abstract ``strokeStyle``: U2<string, ICanvasGradient> with get, set
        abstract ``fillStyle``: U2<string, ICanvasGradient> with get, set
        abstract ``filter``: string with get, set
        abstract ``globalAlpha``: float with get, set
        abstract ``shadowColor``: string with get, set
        abstract ``shadowBlur``: float with get, set
        abstract ``shadowOffsetX``: float with get, set
        abstract ``shadowOffsetY``: float with get, set
        abstract ``lineWidth``: float with get, set
        abstract ``canvas``: ICanvas with get
        abstract ``clearRect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``save``: unit -> unit
        abstract ``restore``: unit -> unit
        abstract ``fillRect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``scale``: ``x``: float * ``y``: float -> unit
        abstract ``rotate``: ``angle``: float -> unit
        abstract ``translate``: ``x``: float * ``y``: float -> unit
        abstract ``strokeRect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``rect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``clip``: unit -> unit
        abstract ``putImageData``: ``imageData``: Browser.Types.ImageData * ``dx``: float * ``dy``: float -> unit
        abstract ``arc``: ``x``: float * ``y``: float * ``radius``: float * ``startAngle``: float * ``endAngle``: float * ?``anticlockwise``: bool -> unit
        abstract ``beginPath``: unit -> unit
        abstract ``closePath``: unit -> unit
        abstract ``moveTo``: ``x``: float * ``y``: float -> unit
        abstract ``lineTo``: ``x``: float * ``y``: float -> unit
        abstract ``quadraticCurveTo``: ``cpx``: float * ``cpy``: float * ``x``: float * ``y``: float -> unit
        abstract ``measureText``: ``text``: string -> ITextMetrics
        abstract ``stroke``: ?``path``: IPath2D -> unit
        abstract ``fill``: unit -> unit
        abstract ``drawImage``: ``image``: obj * ``sx``: float * ``sy``: float * ``sWidth``: float * ``sHeight``: float * ``dx``: float * ``dy``: float * ``dWidth``: float * ``dHeight``: float -> unit
        abstract ``drawImage``: ``image``: obj * ``dx``: float * ``dy``: float * ``dWidth``: float * ``dHeight``: float -> unit
        abstract ``drawImage``: ``image``: obj * ``dx``: float * ``dy``: float -> unit
        abstract ``getImageData``: ``sx``: float * ``sy``: float * ``sw``: float * ``sh``: float -> Browser.Types.ImageData
        abstract ``setLineDash``: ``segments``: ResizeArray<float> -> unit
        abstract ``fillText``: ``text``: string * ``x``: float * ``y``: float * ?``maxWidth``: float -> unit
        abstract ``strokeText``: ``text``: string * ``x``: float * ``y``: float * ?``maxWidth``: float -> unit
        abstract ``createLinearGradient``: ``x0``: float * ``y0``: float * ``x1``: float * ``y1``: float -> ICanvasGradient
        abstract ``createRadialGradient``: ``x0``: float * ``y0``: float * ``r0``: float * ``x1``: float * ``y1``: float * ``r1``: float -> ICanvasGradient
        abstract ``setTransform``: ``a``: float * ``b``: float * ``c``: float * ``d``: float * ``e``: float * ``f``: float -> unit
        abstract ``getTransform``: unit -> DOMMatrix

    /// Distinct ambient VideoFrame handle used by ImageBitmapSource.
    [<AllowNullLiteral>]
    type BrowserVideoFrame =
        interface end

    /// Distinct ambient SVGImageElement handle used by ImageBitmapSource.
    [<AllowNullLiteral>]
    type BrowserSVGImageElement =
        interface end

    /// Exact standard ImageBitmapSource union accepted by Babylon engine APIs.
    type BrowserImageBitmapSource = U9<Browser.Types.HTMLImageElement, BrowserSVGImageElement, Browser.Types.HTMLVideoElement, Browser.Types.HTMLCanvasElement, BrowserImageBitmap, BrowserOffscreenCanvas, BrowserVideoFrame, Browser.Types.Blob, Browser.Types.ImageData>

    /// Distinct ambient Fetch Response handle.
    [<AllowNullLiteral>]
    type BrowserResponse =
        interface end

    /// Distinct ambient Fetch BodyInit value handle.
    [<AllowNullLiteral>]
    type BrowserBodyInit =
        interface end

    /// Distinct ambient MediaStream handle.
    [<AllowNullLiteral>]
    type BrowserMediaStream =
        interface end

    /// Distinct ambient AbortSignal handle.
    [<AllowNullLiteral>]
    type BrowserAbortSignal =
        interface end

    /// Ambient XMLHttpRequest handle used by Babylon request modifiers.
    [<AllowNullLiteral>]
    type BrowserXMLHttpRequest =
        abstract setRequestHeader: name: string * value: string -> unit

    /// Distinct ambient FormData handle.
    [<AllowNullLiteral>]
    type BrowserFormData =
        interface end

    /// Distinct ambient URLSearchParams handle.
    [<AllowNullLiteral>]
    type BrowserURLSearchParams =
        interface end

    /// Exact XMLHttpRequest request-body union.
    type BrowserXMLHttpRequestBodyInit = U6<Browser.Types.Blob, JS.ArrayBufferView, JS.ArrayBuffer, BrowserFormData, BrowserURLSearchParams, string>

    /// Exact DOM event-listener options surface.
    [<AllowNullLiteral>]
    type BrowserEventListenerOptions =
        abstract capture: bool option with get, set

    /// Exact DOM add-event-listener options surface.
    [<AllowNullLiteral>]
    type BrowserAddEventListenerOptions =
        inherit BrowserEventListenerOptions
        abstract once: bool option with get, set
        abstract passive: bool option with get, set
        abstract signal: BrowserAbortSignal option with get, set

    /// Exact XMLHttpRequest response-type literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXMLHttpRequestResponseType =
        | [<CompiledName("")>] Default
        | [<CompiledName("arraybuffer")>] ArrayBuffer
        | [<CompiledName("blob")>] Blob
        | [<CompiledName("document")>] Document
        | [<CompiledName("json")>] Json
        | [<CompiledName("text")>] Text

    /// Exact WebGL context-event extension surface.
    [<AllowNullLiteral>]
    type BrowserWebGLContextEvent =
        inherit Browser.Types.Event
        abstract statusMessage: string with get

    /// Exact nominal type for a required JavaScript null literal.
    [<AllowNullLiteral>]
    type JavaScriptNull =
        interface end

    /// Erased, owner-typed JavaScript property key.
    [<Erase>]
    type JavaScriptKeyOf<'TOwner> =
        | JavaScriptKeyOf of string

    /// Exact pointer input-source discriminator.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserPointerInputSource =
        | [<CompiledName("pointer")>] Value

    /// Exact wheel input-source discriminator.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserWheelInputSource =
        | [<CompiledName("wheel")>] Value

    /// Exact touch input-source discriminator.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserTouchInputSource =
        | [<CompiledName("touch")>] Value

    /// Exact keyboard input-source discriminator.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserKeyboardInputSource =
        | [<CompiledName("keyboard")>] Value

    /// Exact modifier state shared by Babylon input-map entries.
    [<AllowNullLiteral>]
    type BrowserInputModifiers =
        abstract ctrl: bool option with get, set
        abstract shift: bool option with get, set
        abstract alt: bool option with get, set

    /// Exact pointer input-map entry.
    [<AllowNullLiteral>]
    type BrowserPointerInputMapEntry<'TInteraction> =
        abstract source: BrowserPointerInputSource with get, set
        abstract interaction: 'TInteraction with get, set
        abstract sensitivity: float option with get, set
        abstract sensitivityX: float option with get, set
        abstract sensitivityY: float option with get, set
        abstract button: float option with get, set
        abstract modifiers: BrowserInputModifiers option with get, set

    /// Exact wheel input-map entry.
    [<AllowNullLiteral>]
    type BrowserWheelInputMapEntry<'TInteraction> =
        abstract source: BrowserWheelInputSource with get, set
        abstract interaction: 'TInteraction with get, set
        abstract sensitivity: float option with get, set
        abstract modifiers: BrowserInputModifiers option with get, set

    /// Exact touch input-map entry.
    [<AllowNullLiteral>]
    type BrowserTouchInputMapEntry<'TInteraction> =
        abstract source: BrowserTouchInputSource with get, set
        abstract interaction: 'TInteraction with get, set
        abstract sensitivity: float option with get, set
        abstract sensitivityX: float option with get, set
        abstract sensitivityY: float option with get, set
        abstract touchCount: float option with get, set

    /// Exact keyboard input-map entry.
    [<AllowNullLiteral>]
    type BrowserKeyboardInputMapEntry<'TInteraction> =
        abstract source: BrowserKeyboardInputSource with get, set
        abstract interaction: 'TInteraction with get, set
        abstract sensitivity: float option with get, set
        abstract key: U2<float, ResizeArray<float>> option with get, set
        abstract modifiers: BrowserInputModifiers option with get, set

    /// Exact discriminated union of Babylon input-map entries.
    type BrowserInputMapEntry<'TInteraction> = U4<BrowserPointerInputMapEntry<'TInteraction>, BrowserWheelInputMapEntry<'TInteraction>, BrowserTouchInputMapEntry<'TInteraction>, BrowserKeyboardInputMapEntry<'TInteraction>>

    /// @babylonjs/core/Cameras/inputMapper — exact exported aliases over reviewed support projections.
    type PointerInputMapEntry<'TInteraction> = BrowserPointerInputMapEntry<'TInteraction>
    type WheelInputMapEntry<'TInteraction> = BrowserWheelInputMapEntry<'TInteraction>
    type TouchInputMapEntry<'TInteraction> = BrowserTouchInputMapEntry<'TInteraction>
    type KeyboardInputMapEntry<'TInteraction> = BrowserKeyboardInputMapEntry<'TInteraction>
    type InputMapEntry<'TInteraction> = BrowserInputMapEntry<'TInteraction>
    type InteractionName<'THandlers> = JavaScriptKeyOf<'THandlers>
    type PointerInputMapEntry = PointerInputMapEntry<string>
    type WheelInputMapEntry = WheelInputMapEntry<string>
    type TouchInputMapEntry = TouchInputMapEntry<string>
    type KeyboardInputMapEntry = KeyboardInputMapEntry<string>
    type InputMapEntry = InputMapEntry<string>

    /// Distinct ambient WebGPU render pipeline handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderPipeline =
        interface end

    /// Distinct ambient WebGPU query set handle.
    [<AllowNullLiteral>]
    type BrowserGPUQuerySet =
        interface end

    /// Distinct ambient WebGPU command encoder handle.
    [<AllowNullLiteral>]
    type BrowserGPUCommandEncoder =
        interface end

    /// Distinct ambient WebGPU texture handle.
    [<AllowNullLiteral>]
    type BrowserGPUTexture =
        interface end

    /// Distinct ambient WebGPU bind group handle.
    [<AllowNullLiteral>]
    type BrowserGPUBindGroup =
        interface end

    /// Distinct ambient WebGPU bind-group layout handle.
    [<AllowNullLiteral>]
    type BrowserGPUBindGroupLayout =
        interface end

    /// Distinct ambient WebGPU texture view handle.
    [<AllowNullLiteral>]
    type BrowserGPUTextureView =
        interface end

    /// Distinct ambient WebGPU render-pass descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderPassDescriptor =
        interface end

    /// Distinct ambient WebGPU render-pipeline descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderPipelineDescriptor =
        interface end

    /// Distinct ambient WebGPU bind-group-layout entry handle.
    [<AllowNullLiteral>]
    type BrowserGPUBindGroupLayoutEntry =
        interface end

    /// Distinct ambient WebGPU bind-group entry handle.
    [<AllowNullLiteral>]
    type BrowserGPUBindGroupEntry =
        interface end

    /// Distinct ambient WebGPU compute-pass descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPUComputePassDescriptor =
        interface end

    /// Distinct ambient WebGPU texture-view descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPUTextureViewDescriptor =
        interface end

    /// Distinct ambient Web Audio buffer handle.
    [<AllowNullLiteral>]
    type BrowserAudioBuffer =
        interface end

    /// Distinct ambient Web Audio node handle.
    [<AllowNullLiteral>]
    type BrowserAudioNode =
        interface end

    /// Distinct ambient Web Audio gain node handle.
    [<AllowNullLiteral>]
    type BrowserGainNode =
        interface end

    /// Distinct ambient Web Audio buffer-source node handle.
    [<AllowNullLiteral>]
    type BrowserAudioBufferSourceNode =
        interface end

    /// Distinct ambient media-track constraints handle.
    [<AllowNullLiteral>]
    type BrowserMediaTrackConstraints =
        interface end

    /// Distinct ambient pointer-event initializer handle.
    [<AllowNullLiteral>]
    type BrowserPointerEventInit =
        interface end

    /// Distinct ambient WebGL vertex-array object handle.
    [<AllowNullLiteral>]
    type BrowserWebGLVertexArrayObject =
        interface end

    /// Distinct ambient Web Worker handle.
    [<AllowNullLiteral>]
    type BrowserWorker =
        interface end

    /// Exact indexed WebGPU supported-limits surface exposed by Babylon's declaration augmentation.
    [<AllowNullLiteral>]
    type BrowserGPUSupportedLimits =
        [<EmitIndexer>] abstract Item: name: string -> float with get

    /// Exact GPUFeatureName literals from the WebGPU specification.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUFeatureName =
        | [<CompiledName("core-features-and-limits")>] CoreFeaturesAndLimits
        | [<CompiledName("depth-clip-control")>] DepthClipControl
        | [<CompiledName("depth32float-stencil8")>] Depth32floatStencil8
        | [<CompiledName("texture-compression-bc")>] TextureCompressionBc
        | [<CompiledName("texture-compression-bc-sliced-3d")>] TextureCompressionBcSliced3d
        | [<CompiledName("texture-compression-etc2")>] TextureCompressionEtc2
        | [<CompiledName("texture-compression-astc")>] TextureCompressionAstc
        | [<CompiledName("texture-compression-astc-sliced-3d")>] TextureCompressionAstcSliced3d
        | [<CompiledName("timestamp-query")>] TimestampQuery
        | [<CompiledName("indirect-first-instance")>] IndirectFirstInstance
        | [<CompiledName("shader-f16")>] ShaderF16
        | [<CompiledName("rg11b10ufloat-renderable")>] Rg11b10ufloatRenderable
        | [<CompiledName("bgra8unorm-storage")>] Bgra8unormStorage
        | [<CompiledName("float32-filterable")>] Float32Filterable
        | [<CompiledName("float32-blendable")>] Float32Blendable
        | [<CompiledName("clip-distances")>] ClipDistances
        | [<CompiledName("dual-source-blending")>] DualSourceBlending
        | [<CompiledName("subgroups")>] Subgroups
        | [<CompiledName("texture-formats-tier1")>] TextureFormatsTier1
        | [<CompiledName("texture-formats-tier2")>] TextureFormatsTier2
        | [<CompiledName("primitive-index")>] PrimitiveIndex
        | [<CompiledName("texture-component-swizzle")>] TextureComponentSwizzle
        | [<CompiledName("subgroup-size-control")>] SubgroupSizeControl

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject199751a08a94Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject6f1e46ea81ecObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> Browser.Types.WebGLUniformLocation option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type PartialObject2faf2a718deaObject =
        abstract ``useInstances``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type MappedObjecta6e853a8bf06 =
        abstract ``jsDecoderModule``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``jsMSCTranscoder``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmBaseUrl``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmMSCTranscoder``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmUASTCToASTC``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmUASTCToBC7``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmUASTCToR8_UNORM``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmUASTCToRG8_UNORM``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmUASTCToRGBA_SRGB``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmUASTCToRGBA_UNORM``: U2<JS.ArrayBuffer, obj> option with get, set
        abstract ``wasmZSTDDecoder``: U2<JS.ArrayBuffer, obj> option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject66fd69dd870cObject =
        abstract ``backgroundColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set
        abstract ``hostScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``customBlockDescriptions``: ResizeArray<INodeRenderGraphCustomBlockDescription> option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type ImmutableObjectf897d083ff3aObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> BabylonjsBindings.SimpleClasses.VertexBuffer with get

    /// Function-valued _IExecutionQueueItem.process property.
    [<AllowNullLiteral>]
    type _IExecutionQueueItemProcessCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``particle``: BabylonjsBindings.SimpleClasses.Particle * ``system``: BabylonjsBindings.SimpleClasses.ThinParticleSystem -> unit

    /// @babylonjs/core/Particles/Queue/executionQueue
    [<AllowNullLiteral>]
    type _IExecutionQueueItem =
        abstract ``process``: _IExecutionQueueItemProcessCallback with get, set
        abstract ``previousItem``: _IExecutionQueueItem option with get, set
        abstract ``nextItem``: _IExecutionQueueItem option with get, set

    /// Function-valued EffectWrapperCreationOptions.onCompiled property.
    [<AllowNullLiteral>]
    type EffectWrapperCreationOptionsOnCompiledCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: BabylonjsBindings.SimpleClasses.Effect -> unit

    /// Function-valued EffectWrapperCreationOptions.extraInitializations property.
    [<AllowNullLiteral>]
    type EffectWrapperCreationOptionsExtraInitializationsCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``useWebGPU``: bool * ``list``: ResizeArray<JS.Promise<obj>> -> unit

    /// Function-valued EffectWrapperCreationOptions.extraInitializationsAsync property.
    [<AllowNullLiteral>]
    type EffectWrapperCreationOptionsExtraInitializationsAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> JS.Promise<unit>

    /// @babylonjs/core/Materials/effectRenderer.pure
    [<AllowNullLiteral>]
    type EffectWrapperCreationOptions =
        abstract ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine option with get, set
        abstract ``fragmentShader``: string option with get, set
        abstract ``useShaderStore``: bool option with get, set
        abstract ``vertexShader``: string option with get, set
        abstract ``vertexUrl``: string option with get, set
        abstract ``attributeNames``: ResizeArray<string> option with get, set
        abstract ``uniformNames``: ResizeArray<string> option with get, set
        abstract ``uniforms``: ResizeArray<string> option with get, set
        abstract ``samplerNames``: ResizeArray<string> option with get, set
        abstract ``samplers``: ResizeArray<string> option with get, set
        abstract ``uniformBuffers``: ResizeArray<string> option with get, set
        abstract ``defines``: U2<string, ResizeArray<string>> option with get, set
        abstract ``indexParameters``: obj option with get, set
        abstract ``blockCompilation``: bool option with get, set
        abstract ``onCompiled``: EffectWrapperCreationOptionsOnCompiledCallback option with get, set
        abstract ``name``: string option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set
        abstract ``extraInitializations``: EffectWrapperCreationOptionsExtraInitializationsCallback option with get, set
        abstract ``extraInitializationsAsync``: EffectWrapperCreationOptionsExtraInitializationsAsyncCallback option with get, set
        abstract ``useAsPostProcess``: bool option with get, set
        abstract ``allowEmptySourceTexture``: bool option with get, set

    /// Exact required non-null projection used by Required<NonNullableFields<EffectWrapperCreationOptions>> signatures.
    [<AllowNullLiteral>]
    type RequiredNonNullableEffectWrapperCreationOptions =
        abstract ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine with get, set
        abstract ``fragmentShader``: string with get, set
        abstract ``useShaderStore``: bool with get, set
        abstract ``vertexShader``: string with get, set
        abstract ``vertexUrl``: string with get, set
        abstract ``attributeNames``: ResizeArray<string> with get, set
        abstract ``uniformNames``: ResizeArray<string> with get, set
        abstract ``uniforms``: ResizeArray<string> with get, set
        abstract ``samplerNames``: ResizeArray<string> with get, set
        abstract ``samplers``: ResizeArray<string> with get, set
        abstract ``uniformBuffers``: ResizeArray<string> with get, set
        abstract ``defines``: U2<string, ResizeArray<string>> with get, set
        abstract ``indexParameters``: obj with get, set
        abstract ``blockCompilation``: bool with get, set
        abstract ``onCompiled``: EffectWrapperCreationOptionsOnCompiledCallback with get, set
        abstract ``name``: string with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage with get, set
        abstract ``extraInitializations``: EffectWrapperCreationOptionsExtraInitializationsCallback with get, set
        abstract ``extraInitializationsAsync``: EffectWrapperCreationOptionsExtraInitializationsAsyncCallback with get, set
        abstract ``useAsPostProcess``: bool with get, set
        abstract ``allowEmptySourceTexture``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IAbstractSoundOptionsBase> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractSoundOptionsBase =
        abstract ``autoplay``: bool option with get, set
        abstract ``maxInstances``: float option with get, set

    /// @babylonjs/core/Actions/action.pure
    [<AllowNullLiteral>]
    type IAction =
        abstract ``trigger``: float with get, set
        abstract ``triggerOptions``: obj with get, set
        abstract ``getTriggerParameter``: unit -> obj
        abstract ``_executeCurrent``: ?``evt``: BabylonjsBindings.SimpleClasses.ActionEvent -> unit
        abstract ``serialize``: ``parent``: obj -> obj
        abstract ``_prepare``: unit -> unit
        abstract ``_actionManager``: BabylonjsBindings.SimpleClasses.AbstractActionManager option with get, set
        abstract ``then``: ``action``: IAction -> IAction
        abstract ``_evaluateConditionForCurrentFrame``: unit -> bool

    /// @babylonjs/core/Actions/actionEvent
    [<AllowNullLiteral>]
    type IActionEvent =
        abstract ``source``: obj with get, set
        abstract ``pointerX``: float with get, set
        abstract ``pointerY``: float with get, set
        abstract ``meshUnderPointer``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set
        abstract ``sourceEvent``: obj option with get, set
        abstract ``additionalData``: obj option with get, set

    /// @babylonjs/core/Animations/animatable.interface
    [<AllowNullLiteral>]
    type IAnimatable =
        abstract ``animations``: ResizeArray<BabylonjsBindings.SimpleClasses.Animation> option with get, set

    /// @babylonjs/core/BakedVertexAnimation/bakedVertexAnimationManager
    [<AllowNullLiteral>]
    type IBakedVertexAnimationManager =
        abstract ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``isEnabled``: bool with get, set
        abstract ``animationParameters``: BabylonjsBindings.SimpleClasses.Vector4 with get, set
        abstract ``time``: float with get, set
        abstract ``bind``: ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``useInstances``: bool -> unit
        abstract ``setAnimationParameters``: ``startFrame``: float * ``endFrame``: float * ``offset``: float * ``speedFramesPerSecond``: float -> unit
        abstract ``dispose``: ?``forceDisposeTextures``: bool -> unit
        abstract ``getClassName``: unit -> string

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    [<AllowNullLiteral>]
    type IBasePhysicsCollisionEvent =
        abstract ``collider``: BabylonjsBindings.SimpleClasses.PhysicsBody with get, set
        abstract ``collidedAgainst``: BabylonjsBindings.SimpleClasses.PhysicsBody with get, set
        abstract ``colliderIndex``: float with get, set
        abstract ``collidedAgainstIndex``: float with get, set
        abstract ``type``: BabylonjsBindings.StringEnums.PhysicsEventType with get, set

    /// Function-valued ICameraInput.checkInputs property.
    [<AllowNullLiteral>]
    type ICameraInputCheckInputsCallback<'Tcamera when 'Tcamera :> BabylonjsBindings.SimpleClasses.Camera> =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Cameras/cameraInputsManager
    [<AllowNullLiteral>]
    type ICameraInput<'Tcamera when 'Tcamera :> BabylonjsBindings.SimpleClasses.Camera> =
        abstract ``camera``: 'Tcamera option with get, set
        abstract ``getClassName``: unit -> string
        abstract ``getSimpleName``: unit -> string
        abstract ``attachControl``: ?``noPreventDefault``: bool -> unit
        abstract ``detachControl``: unit -> unit
        abstract ``checkInputs``: ICameraInputCheckInputsCallback<'Tcamera> option with get, set

    /// @babylonjs/core/Misc/interfaces/iClipPlanesHolder
    [<AllowNullLiteral>]
    type IClipPlanesHolder =
        abstract ``clipPlane``: BabylonjsBindings.SimpleClasses.Plane option with get, set
        abstract ``clipPlane2``: BabylonjsBindings.SimpleClasses.Plane option with get, set
        abstract ``clipPlane3``: BabylonjsBindings.SimpleClasses.Plane option with get, set
        abstract ``clipPlane4``: BabylonjsBindings.SimpleClasses.Plane option with get, set
        abstract ``clipPlane5``: BabylonjsBindings.SimpleClasses.Plane option with get, set
        abstract ``clipPlane6``: BabylonjsBindings.SimpleClasses.Plane option with get, set

    /// @babylonjs/core/Collisions/collisionCoordinator.pure
    [<AllowNullLiteral>]
    type ICollisionCoordinator =
        abstract ``createCollider``: unit -> BabylonjsBindings.SimpleClasses.Collider
        abstract ``getNewPosition``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``displacement``: BabylonjsBindings.SimpleClasses.Vector3 * ``collider``: BabylonjsBindings.SimpleClasses.Collider * ``maximumRetry``: float * ``excludedMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option * ``onNewPosition``: System.Action<float, BabylonjsBindings.SimpleClasses.Vector3, BabylonjsBindings.SimpleClasses.AbstractMesh option> * ``collisionIndex``: float * ?``slideOnCollide``: bool -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``init``: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> unit

    /// Function-valued IComputeEffectCreationOptions.onCompiled property.
    [<AllowNullLiteral>]
    type IComputeEffectCreationOptionsOnCompiledCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: BabylonjsBindings.SimpleClasses.ComputeEffect -> unit

    /// Function-valued IComputeEffectCreationOptions.onError property.
    [<AllowNullLiteral>]
    type IComputeEffectCreationOptionsOnErrorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: BabylonjsBindings.SimpleClasses.ComputeEffect * ``errors``: string -> unit

    /// Function-valued IComputeEffectCreationOptions.processFinalCode property.
    [<AllowNullLiteral>]
    type IComputeEffectCreationOptionsProcessFinalCodeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string -> string

    /// @babylonjs/core/Compute/computeEffect
    [<AllowNullLiteral>]
    type IComputeEffectCreationOptions =
        abstract ``defines``: obj with get, set
        abstract ``entryPoint``: string option with get, set
        abstract ``onCompiled``: IComputeEffectCreationOptionsOnCompiledCallback option with get, set
        abstract ``onError``: IComputeEffectCreationOptionsOnErrorCallback option with get, set
        abstract ``processFinalCode``: IComputeEffectCreationOptionsProcessFinalCodeCallback option with get, set
        abstract ``useExplicitComputePipelineLayout``: bool option with get, set

    /// @babylonjs/core/Meshes/Builders/capsuleBuilder.pure
    [<AllowNullLiteral>]
    type ICreateCapsuleOptions =
        abstract ``orientation``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``subdivisions``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``radius``: float option with get, set
        abstract ``capSubdivisions``: float option with get, set
        abstract ``radiusTop``: float option with get, set
        abstract ``radiusBottom``: float option with get, set
        abstract ``topCapSubdivisions``: float option with get, set
        abstract ``bottomCapSubdivisions``: float option with get, set
        abstract ``updatable``: bool option with get, set

    /// @babylonjs/core/Culling/boundingInfo
    [<AllowNullLiteral>]
    type ICullable =
        abstract ``isInFrustum``: ``frustumPlanes``: ResizeArray<BabylonjsBindings.SimpleClasses.Plane> -> bool
        abstract ``isCompletelyInFrustum``: ``frustumPlanes``: ResizeArray<BabylonjsBindings.SimpleClasses.Plane> -> bool

    /// @babylonjs/core/Meshes/Compression/dracoCodec
    [<AllowNullLiteral>]
    type IDracoCodecConfiguration =
        abstract ``wasmUrl``: string option with get, set
        abstract ``wasmBinaryUrl``: string option with get, set
        abstract ``fallbackUrl``: string option with get, set
        abstract ``numWorkers``: float option with get, set
        abstract ``workerPool``: BabylonjsBindings.SimpleClasses.WorkerPool option with get, set
        abstract ``wasmBinary``: JS.ArrayBuffer option with get, set
        abstract ``jsModule``: obj option with get, set

    /// @babylonjs/core/Materials/iEffectFallbacks
    [<AllowNullLiteral>]
    type IEffectFallbacks =
        abstract ``reduce``: ``currentDefines``: string * ``effect``: BabylonjsBindings.SimpleClasses.Effect -> string
        abstract ``unBindMesh``: unit -> unit
        abstract ``hasMoreFallbacks``: bool with get, set

    /// @babylonjs/core/Particles/flowMap
    [<AllowNullLiteral>]
    type IFlowable =
        abstract ``direction``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    [<AllowNullLiteral>]
    type IFrameGraphPass =
        abstract ``name``: string with get, set
        abstract ``disabled``: bool with get, set
        abstract ``setInitializeFunc``: ``func``: System.Action<BabylonjsBindings.SimpleClasses.FrameGraphContext> -> unit
        abstract ``setExecuteFunc``: ``func``: System.Action<BabylonjsBindings.SimpleClasses.FrameGraphContext> -> unit
        abstract ``_initialize``: unit -> unit
        abstract ``_execute``: unit -> unit
        abstract ``_isValid``: unit -> string option
        abstract ``_dispose``: unit -> unit

    /// @babylonjs/core/Meshes/mesh.pure
    [<AllowNullLiteral>]
    type IInstanceDataStorageRenderPassVisibleInstances =
        abstract ``defaultRenderId``: float with get, set
        abstract ``selfDefaultRenderId``: float with get, set
        abstract ``intermediateDefaultRenderId``: float with get, set
        [<EmitIndexer>] abstract Item: ``renderId``: float -> ResizeArray<BabylonjsBindings.SimpleClasses.InstancedMesh> option with get, set

    /// @babylonjs/core/Materials/Textures/Loaders/internalTextureLoader
    [<AllowNullLiteral>]
    type IInternalTextureLoader =
        abstract ``supportCascades``: bool with get, set
        abstract ``loadCubeData``: ``data``: U2<JS.ArrayBufferView, ResizeArray<JS.ArrayBufferView>> * ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``createPolynomials``: bool * ``onLoad``: System.Action<obj option> option * ``onError``: System.Action<string option, obj option> option * ?``options``: obj -> unit
        abstract ``loadData``: ``data``: JS.ArrayBufferView * ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``callback``: System.Action<float, float, bool, bool, System.Action, bool option> * ?``options``: obj -> unit

    /// @babylonjs/core/Misc/khronosTextureContainer2
    [<AllowNullLiteral>]
    type IKhronosTextureContainer2Options =
        abstract ``numWorkers``: float option with get, set
        abstract ``workerPool``: BabylonjsBindings.SimpleClasses.AutoReleaseWorkerPool option with get, set
        abstract ``binariesAndModulesContainer``: MappedObjecta6e853a8bf06 option with get, set

    /// Function-valued INodeRenderGraphCustomBlockDescription.factory property.
    [<AllowNullLiteral>]
    type INodeRenderGraphCustomBlockDescriptionFactoryCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``frameGraph``: BabylonjsBindings.SimpleClasses.FrameGraph * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.NodeRenderGraphBlock

    /// @babylonjs/core/FrameGraph/Node/Types/nodeRenderGraphTypes
    [<AllowNullLiteral>]
    type INodeRenderGraphCustomBlockDescription =
        abstract ``name``: string with get, set
        abstract ``description``: string with get, set
        abstract ``menu``: string with get, set
        abstract ``factory``: INodeRenderGraphCustomBlockDescriptionFactoryCallback with get, set

    /// @babylonjs/core/Particles/EmitterTypes/IParticleEmitterType
    [<AllowNullLiteral>]
    type IParticleEmitterType =
        abstract ``startDirectionFunction``: ``worldMatrix``: BabylonjsBindings.SimpleClasses.Matrix * ``directionToUpdate``: BabylonjsBindings.SimpleClasses.Vector3 * ``particle``: BabylonjsBindings.SimpleClasses.Particle * ``isLocal``: bool * ``inverseWorldMatrix``: BabylonjsBindings.SimpleClasses.Matrix -> unit
        abstract ``startPositionFunction``: ``worldMatrix``: BabylonjsBindings.SimpleClasses.Matrix * ``positionToUpdate``: BabylonjsBindings.SimpleClasses.Vector3 * ``particle``: BabylonjsBindings.SimpleClasses.Particle * ``isLocal``: bool -> unit
        abstract ``clone``: unit -> IParticleEmitterType
        abstract ``applyToShader``: ``uboOrEffect``: BabylonjsBindings.SimpleClasses.UniformBufferEffectCommonAccessor -> unit
        abstract ``buildUniformLayout``: ``ubo``: BabylonjsBindings.SimpleClasses.UniformBuffer -> unit
        abstract ``getEffectDefines``: unit -> string
        abstract ``getClassName``: unit -> string
        abstract ``serialize``: unit -> obj
        abstract ``parse``: ``serializationObject``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene option -> unit

    /// @babylonjs/core/Misc/PerformanceViewer/performanceViewerCollector
    [<AllowNullLiteral>]
    type IPerformanceViewerStrategyParameter =
        abstract ``strategyCallback``: BabylonjsBindings.TypeAliases.PerfStrategyInitialization with get, set
        abstract ``category``: string option with get, set
        abstract ``hidden``: bool option with get, set

    /// Function-valued IPhysicsEnabledObject.getWorldMatrix property.
    [<AllowNullLiteral>]
    type IPhysicsEnabledObjectGetWorldMatrixCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> BabylonjsBindings.SimpleClasses.Matrix

    /// Function-valued IPhysicsEnabledObject.getChildMeshes property.
    [<AllowNullLiteral>]
    type IPhysicsEnabledObjectGetChildMeshesCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``directDescendantsOnly``: bool -> ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh>

    /// Function-valued IPhysicsEnabledObject.getIndices property.
    [<AllowNullLiteral>]
    type IPhysicsEnabledObjectGetIndicesCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> BabylonjsBindings.TypeAliases.IndicesArray option

    /// Function-valued IPhysicsEnabledObject.getScene property.
    [<AllowNullLiteral>]
    type IPhysicsEnabledObjectGetSceneCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> BabylonjsBindings.SimpleClasses.Scene

    /// @babylonjs/core/Physics/v1/physicsImpostor.pure
    [<AllowNullLiteral>]
    type IPhysicsEnabledObject =
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``rotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion option with get, set
        abstract ``scaling``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``rotation``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``parent``: obj option with get, set
        abstract ``getBoundingInfo``: unit -> BabylonjsBindings.SimpleClasses.BoundingInfo
        abstract ``computeWorldMatrix``: ``force``: bool -> BabylonjsBindings.SimpleClasses.Matrix
        abstract ``getWorldMatrix``: IPhysicsEnabledObjectGetWorldMatrixCallback option with get, set
        abstract ``getChildMeshes``: IPhysicsEnabledObjectGetChildMeshesCallback option with get, set
        abstract ``getVerticesData``: ``kind``: string -> BabylonjsBindings.TypeAliases.FloatArray option
        abstract ``getIndices``: IPhysicsEnabledObjectGetIndicesCallback option with get, set
        abstract ``getScene``: IPhysicsEnabledObjectGetSceneCallback option with get, set
        abstract ``getAbsolutePosition``: unit -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``getAbsolutePivotPoint``: unit -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``rotate``: ``axis``: BabylonjsBindings.SimpleClasses.Vector3 * ``amount``: float * ?``space``: BabylonjsBindings.Enums.Space -> BabylonjsBindings.SimpleClasses.TransformNode
        abstract ``translate``: ``axis``: BabylonjsBindings.SimpleClasses.Vector3 * ``distance``: float * ?``space``: BabylonjsBindings.Enums.Space -> BabylonjsBindings.SimpleClasses.TransformNode
        abstract ``setAbsolutePosition``: ``absolutePosition``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.TransformNode
        abstract ``getClassName``: unit -> string

    /// @babylonjs/core/Engines/renderTargetWrapper
    [<AllowNullLiteral>]
    type IRenderTargetTexture =
        abstract ``renderTarget``: BabylonjsBindings.SimpleClasses.RenderTargetWrapper option with get, set

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type ISceneComponent =
        abstract ``name``: string with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get, set
        abstract ``register``: unit -> unit
        abstract ``rebuild``: unit -> unit
        abstract ``dispose``: unit -> unit

    /// @babylonjs/core/Lights/Shadows/shadowGenerator
    [<AllowNullLiteral>]
    type IShadowGenerator =
        abstract ``id``: string with get, set
        abstract ``doNotSerialize``: bool option with get, set
        abstract ``getShadowMap``: unit -> BabylonjsBindings.SimpleClasses.RenderTargetTexture option
        abstract ``isReady``: ``subMesh``: BabylonjsBindings.SimpleClasses.SubMesh * ``useInstances``: bool * ``isTransparent``: bool -> bool
        abstract ``prepareDefines``: ``defines``: BabylonjsBindings.SimpleClasses.MaterialDefines * ``lightIndex``: float -> unit
        abstract ``bindShadowLight``: ``lightIndex``: string * ``effect``: BabylonjsBindings.SimpleClasses.Effect -> unit
        abstract ``getTransformMatrix``: unit -> BabylonjsBindings.SimpleClasses.Matrix
        abstract ``recreateShadowMap``: unit -> unit
        abstract ``forceCompilation``: ?``onCompiled``: System.Action<IShadowGenerator> * ?``options``: PartialObject2faf2a718deaObject -> unit
        abstract ``forceCompilationAsync``: ?``options``: PartialObject2faf2a718deaObject -> JS.Promise<unit>
        abstract ``serialize``: unit -> obj
        abstract ``dispose``: unit -> unit

    /// Function-valued IShadowLight.customProjectionMatrixBuilder property.
    [<AllowNullLiteral>]
    type IShadowLightCustomProjectionMatrixBuilderCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``viewMatrix``: BabylonjsBindings.SimpleClasses.Matrix * ``renderList``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> * ``result``: BabylonjsBindings.SimpleClasses.Matrix -> unit

    /// @babylonjs/core/Lights/shadowLight
    [<AllowNullLiteral>]
    type IShadowLight =
        inherit BabylonjsBindings.TypeAliases.NodeRenderGraphValue
        inherit BabylonjsBindings.SimpleClasses.Light
        abstract ``id``: string with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``direction``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``transformedPosition``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``transformedDirection``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``name``: string with get, set
        abstract ``shadowMinZ``: float with get, set
        abstract ``shadowMaxZ``: float with get, set
        abstract ``computeTransformedInformation``: unit -> bool
        abstract ``getScene``: unit -> BabylonjsBindings.SimpleClasses.Scene
        abstract ``customProjectionMatrixBuilder``: IShadowLightCustomProjectionMatrixBuilderCallback with get, set
        abstract ``setShadowProjectionMatrix``: ``matrix``: BabylonjsBindings.SimpleClasses.Matrix * ``viewMatrix``: BabylonjsBindings.SimpleClasses.Matrix * ``renderList``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> -> IShadowLight
        abstract ``getDepthScale``: unit -> float
        abstract ``needCube``: unit -> bool
        abstract ``needProjectionMatrixCompute``: unit -> bool
        abstract ``forceProjectionMatrixCompute``: unit -> unit
        abstract ``getShadowDirection``: ?``faceIndex``: float -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``getDepthMinZ``: ``activeCamera``: BabylonjsBindings.SimpleClasses.Camera option -> float
        abstract ``getDepthMaxZ``: ``activeCamera``: BabylonjsBindings.SimpleClasses.Camera option -> float

    /// Exact optional-property projection used by Babylon Partial<IStreamingSoundOptionsBase> signatures.
    [<AllowNullLiteral>]
    type PartialIStreamingSoundOptionsBase =
        abstract ``preloadCount``: float option with get, set

    /// Function-valued ITextureCreationOptions.onLoad property.
    [<AllowNullLiteral>]
    type ITextureCreationOptionsOnLoadCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued ITextureCreationOptions.onError property.
    [<AllowNullLiteral>]
    type ITextureCreationOptionsOnErrorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``message``: string * ?``exception``: obj -> unit

    /// @babylonjs/core/Materials/Textures/texture.pure
    [<AllowNullLiteral>]
    type ITextureCreationOptions =
        abstract ``noMipmap``: bool option with get, set
        abstract ``invertY``: bool option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``onLoad``: ITextureCreationOptionsOnLoadCallback option with get, set
        abstract ``onError``: ITextureCreationOptionsOnErrorCallback option with get, set
        abstract ``buffer``: U6<string, JS.ArrayBuffer, JS.ArrayBufferView, Browser.Types.HTMLImageElement, Browser.Types.Blob, BrowserImageBitmap> option with get, set
        abstract ``deleteBuffer``: bool option with get, set
        abstract ``format``: float option with get, set
        abstract ``mimeType``: string option with get, set
        abstract ``loaderOptions``: obj option with get, set
        abstract ``creationFlags``: float option with get, set
        abstract ``useSRGBBuffer``: bool option with get, set
        abstract ``internalTexture``: BabylonjsBindings.SimpleClasses.InternalTexture option with get, set
        abstract ``gammaSpace``: bool option with get, set
        abstract ``forcedExtension``: string option with get, set

    /// @babylonjs/core/Layers/thinEffectLayer
    [<AllowNullLiteral>]
    type IThinEffectLayerOptions =
        abstract ``mainTextureRatio``: float option with get, set
        abstract ``mainTextureFixedSize``: float option with get, set
        abstract ``mainTextureType``: float option with get, set
        abstract ``mainTextureFormat``: float option with get, set
        abstract ``alphaBlendingMode``: float option with get, set
        abstract ``camera``: BabylonjsBindings.SimpleClasses.Camera option with get, set
        abstract ``renderingGroupId``: float option with get, set

    /// Exact required-property projection used by Required<IThinEffectLayerOptions> signatures.
    [<AllowNullLiteral>]
    type RequiredIThinEffectLayerOptions =
        abstract ``mainTextureRatio``: float with get, set
        abstract ``mainTextureFixedSize``: float with get, set
        abstract ``mainTextureType``: float with get, set
        abstract ``mainTextureFormat``: float with get, set
        abstract ``alphaBlendingMode``: float with get, set
        abstract ``camera``: BabylonjsBindings.SimpleClasses.Camera with get, set
        abstract ``renderingGroupId``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IThinEffectLayerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIThinEffectLayerOptions =
        abstract ``mainTextureRatio``: float option with get, set
        abstract ``mainTextureFixedSize``: float option with get, set
        abstract ``mainTextureType``: float option with get, set
        abstract ``mainTextureFormat``: float option with get, set
        abstract ``alphaBlendingMode``: float option with get, set
        abstract ``camera``: BabylonjsBindings.SimpleClasses.Camera option with get, set
        abstract ``renderingGroupId``: float option with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuMaterialContext
    [<AllowNullLiteral>]
    type IWebGPUMaterialContextSamplerCache =
        abstract ``sampler``: BabylonjsBindings.SimpleClasses.TextureSampler option with get, set
        abstract ``hashCode``: float with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuMaterialContext
    [<AllowNullLiteral>]
    type IWebGPUMaterialContextTextureCache =
        abstract ``texture``: U2<BabylonjsBindings.SimpleClasses.InternalTexture, BabylonjsBindings.SimpleClasses.ExternalTexture> option with get, set
        abstract ``isFloatOrDepthTexture``: bool with get, set
        abstract ``isExternalTexture``: bool with get, set

    /// @babylonjs/core/Engines/webgpuEngine.pure
    [<AllowNullLiteral>]
    type IWebGPURenderPassWrapper =
        abstract ``renderPassDescriptor``: BrowserGPURenderPassDescriptor option with get, set
        abstract ``colorAttachmentViewDescriptor``: BrowserGPUTextureViewDescriptor option with get, set
        abstract ``depthAttachmentViewDescriptor``: BrowserGPUTextureViewDescriptor option with get, set
        abstract ``colorAttachmentGPUTextures``: ResizeArray<BabylonjsBindings.SimpleClasses.WebGPUHardwareTexture option> with get, set
        abstract ``depthTextureFormat``: BrowserGPUTextureFormat option with get, set

    /// @babylonjs/core/Engines/webgpuEngine.pure
    [<AllowNullLiteral>]
    type IWebGPURenderPipelineAsyncCreationOptions =
        abstract ``effect``: BabylonjsBindings.SimpleClasses.Effect with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set
        abstract ``fillMode``: float option with get, set
        abstract ``sampleCount``: float option with get, set
        abstract ``colorFormat``: BrowserGPUTextureFormat option with get, set
        abstract ``depthStencilFormat``: BrowserGPUTextureFormat option with get, set
        abstract ``alphaMode``: float option with get, set
        abstract ``depthWrite``: bool option with get, set
        abstract ``depthTest``: bool option with get, set
        abstract ``depthCompare``: float option with get, set
        abstract ``cullEnabled``: bool option with get, set
        abstract ``cullFace``: float option with get, set
        abstract ``frontFace``: float option with get, set
        abstract ``writeMask``: float option with get, set
        abstract ``stencilEnabled``: bool option with get, set

    /// @babylonjs/core/Physics/castingResult
    [<AllowNullLiteral>]
    type IXYZ =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set
        abstract ``z``: float with get, set

    /// @babylonjs/core/Meshes/mesh.pure
    [<AllowNullLiteral>]
    type MeshCloneOptions =
        abstract ``parent``: BabylonjsBindings.SimpleClasses.Node option with get, set
        abstract ``doNotCloneChildren``: bool option with get, set
        abstract ``clonePhysicsImpostor``: bool option with get, set
        abstract ``cloneThinInstances``: bool option with get, set

    /// Exact required-property projection used by Required<ObjectRendererOptions> signatures.
    [<AllowNullLiteral>]
    type RequiredObjectRendererOptions =
        abstract ``numPasses``: float with get, set
        abstract ``doNotChangeAspectRatio``: bool with get, set
        abstract ``enableClusteredLights``: bool with get, set

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    [<AllowNullLiteral>]
    type PhysicsConstraintParameters =
        abstract ``pivotA``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``pivotB``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``axisA``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``axisB``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``perpAxisA``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``perpAxisB``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``maxDistance``: float option with get, set
        abstract ``collision``: bool option with get, set

    /// @babylonjs/core/Physics/v1/IPhysicsEnginePlugin
    [<AllowNullLiteral>]
    type PhysicsImpostorJoint =
        abstract ``mainImpostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor with get, set
        abstract ``connectedImpostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor with get, set
        abstract ``joint``: BabylonjsBindings.SimpleClasses.PhysicsJoint with get, set

    /// @babylonjs/core/Physics/v1/physicsJoint
    [<AllowNullLiteral>]
    type PhysicsJointData =
        abstract ``mainPivot``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``connectedPivot``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``mainAxis``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``connectedAxis``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``collision``: bool option with get, set
        abstract ``nativeParams``: obj option with get, set

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    [<AllowNullLiteral>]
    type PhysicsMassProperties =
        abstract ``centerOfMass``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``mass``: float option with get, set
        abstract ``inertia``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``inertiaOrientation``: BabylonjsBindings.SimpleClasses.Quaternion option with get, set

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    [<AllowNullLiteral>]
    type PhysicsShapeParameters =
        abstract ``center``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``radius``: float option with get, set
        abstract ``pointA``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``pointB``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``rotation``: BabylonjsBindings.SimpleClasses.Quaternion option with get, set
        abstract ``extents``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.Mesh option with get, set
        abstract ``includeChildMeshes``: bool option with get, set
        abstract ``heightFieldSizeX``: float option with get, set
        abstract ``heightFieldSizeZ``: float option with get, set
        abstract ``numHeightFieldSamplesX``: float option with get, set
        abstract ``numHeightFieldSamplesZ``: float option with get, set
        abstract ``heightFieldData``: JS.Float32Array option with get, set
        abstract ``groundMesh``: BabylonjsBindings.SimpleClasses.GroundMesh option with get, set

    /// Function-valued PrePassEffectConfiguration.dispose property.
    [<AllowNullLiteral>]
    type PrePassEffectConfigurationDisposeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued PrePassEffectConfiguration.createPostProcess property.
    [<AllowNullLiteral>]
    type PrePassEffectConfigurationCreatePostProcessCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> BabylonjsBindings.SimpleClasses.PostProcess

    /// @babylonjs/core/Rendering/prePassEffectConfiguration
    [<AllowNullLiteral>]
    type PrePassEffectConfiguration =
        abstract ``name``: string with get, set
        abstract ``postProcess``: BabylonjsBindings.SimpleClasses.PostProcess option with get, set
        abstract ``texturesRequired``: ResizeArray<float> with get, set
        abstract ``enabled``: bool with get, set
        abstract ``needsImageProcessing``: bool option with get, set
        abstract ``clearColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set
        abstract ``dispose``: PrePassEffectConfigurationDisposeCallback option with get, set
        abstract ``createPostProcess``: PrePassEffectConfigurationCreatePostProcessCallback option with get, set

    /// @babylonjs/core/Materials/Textures/renderTargetTexture.pure
    [<AllowNullLiteral>]
    type RenderTargetTextureOptions =
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``doNotChangeAspectRatio``: bool option with get, set
        abstract ``type``: float option with get, set
        abstract ``isCube``: bool option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``generateDepthBuffer``: bool option with get, set
        abstract ``generateStencilBuffer``: bool option with get, set
        abstract ``isMulti``: bool option with get, set
        abstract ``format``: float option with get, set
        abstract ``delayAllocation``: bool option with get, set
        abstract ``samples``: float option with get, set
        abstract ``creationFlags``: float option with get, set
        abstract ``noColorAttachment``: bool option with get, set
        abstract ``colorAttachment``: BabylonjsBindings.SimpleClasses.InternalTexture option with get, set
        abstract ``useSRGBBuffer``: bool option with get, set
        abstract ``gammaSpace``: bool option with get, set
        abstract ``existingObjectRenderer``: BabylonjsBindings.SimpleClasses.ObjectRenderer option with get, set
        abstract ``enableClusteredLights``: bool option with get, set

    /// @babylonjs/core/Engines/thinEngine.pure
    [<AllowNullLiteral>]
    type TexImageParameters =
        abstract ``internalFormat``: float with get, set
        abstract ``format``: float with get, set
        abstract ``type``: float with get, set

    /// @babylonjs/core/Cameras/cameraInputsManager
    [<AllowNullLiteral>]
    type CameraInputsMap<'Tcamera when 'Tcamera :> BabylonjsBindings.SimpleClasses.Camera> =
        [<EmitIndexer>] abstract Item: ``name``: string -> ICameraInput<'Tcamera> with get, set
        [<EmitIndexer>] abstract Item: ``idx``: float -> ICameraInput<'Tcamera> with get, set

    /// Exact optional-property projection used by Babylon Partial<IAbstractSoundStoredOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractSoundStoredOptions =
        inherit PartialIAbstractSoundOptionsBase
        inherit PartialIAbstractSoundPlayOptionsBase

    /// @babylonjs/core/Audio/Interfaces/IAudioEngine
    [<AllowNullLiteral>]
    type IAudioEngine =
        inherit IDisposable
        abstract ``canUseWebAudio``: bool with get
        abstract ``audioContext``: BrowserAudioContext option with get
        abstract ``masterGain``: BrowserGainNode with get
        abstract ``isMP3supported``: bool with get
        abstract ``isOGGsupported``: bool with get
        abstract ``WarnedWebAudioUnsupported``: bool with get, set
        abstract ``useCustomUnlockedButton``: bool with get, set
        abstract ``unlocked``: bool with get
        abstract ``onAudioUnlockedObservable``: BabylonjsBindings.SimpleClasses.Observable<IAudioEngine> with get, set
        abstract ``onAudioLockedObservable``: BabylonjsBindings.SimpleClasses.Observable<IAudioEngine> with get, set
        abstract ``lock``: unit -> unit
        abstract ``unlock``: unit -> unit
        abstract ``getGlobalVolume``: unit -> float
        abstract ``setGlobalVolume``: ``newVolume``: float -> unit
        abstract ``connectToAnalyser``: ``analyser``: BabylonjsBindings.SimpleClasses.Analyser -> unit
        abstract ``_resumeAudioContextOnStateChange``: unit -> unit

    /// @babylonjs/core/Meshes/Compression/dracoCompression
    [<AllowNullLiteral>]
    type IDracoCompressionConfiguration =
        abstract ``decoder``: IDracoCodecConfiguration with get, set

    /// @babylonjs/core/Rendering/edgesRenderer.pure
    [<AllowNullLiteral>]
    type IEdgesRenderer =
        inherit IDisposable
        abstract ``isEnabled``: bool with get, set
        abstract ``render``: unit -> unit
        abstract ``isReady``: unit -> bool
        abstract ``customInstances``: BabylonjsBindings.SimpleClasses.SmartArray<BabylonjsBindings.SimpleClasses.Matrix> with get, set

    /// @babylonjs/core/Meshes/abstractMesh.pure
    [<AllowNullLiteral>]
    type IMeshDataOptions =
        abstract ``applySkeleton``: bool option with get, set
        abstract ``applyMorph``: bool option with get, set
        abstract ``applyBakedVertexAnimation``: bool option with get, set
        abstract ``bakedVertexAnimationSettings``: BabylonjsBindings.SimpleClasses.DeepImmutableVector4 option with get, set
        abstract ``updatePositionsArray``: bool option with get, set
        abstract ``cache``: IMeshDataCache option with get, set

    /// @babylonjs/core/FrameGraph/Node/Types/nodeRenderGraphTypes
    [<AllowNullLiteral>]
    type INodeRenderGraphEditorOptions =
        abstract ``editorURL``: string option with get, set
        abstract ``nodeRenderGraphEditorConfig``: InlineObject66fd69dd870cObject option with get, set

    /// @babylonjs/core/Particles/IParticleSystem
    [<AllowNullLiteral>]
    type IParticleSystem =
        abstract ``uniqueId``: float with get, set
        abstract ``animations``: ResizeArray<BabylonjsBindings.SimpleClasses.Animation> with get, set
        abstract ``id``: string with get, set
        abstract ``name``: string with get, set
        abstract ``emitter``: U2<BabylonjsBindings.SimpleClasses.AbstractMesh, BabylonjsBindings.SimpleClasses.Vector3> option with get, set
        abstract ``isBillboardBased``: bool with get, set
        abstract ``renderingGroupId``: float with get, set
        abstract ``layerMask``: float with get, set
        abstract ``updateSpeed``: float with get, set
        abstract ``targetStopDuration``: float with get, set
        abstract ``particleTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``blendMode``: float with get, set
        abstract ``minLifeTime``: float with get, set
        abstract ``maxLifeTime``: float with get, set
        abstract ``minSize``: float with get, set
        abstract ``maxSize``: float with get, set
        abstract ``minScaleX``: float with get, set
        abstract ``maxScaleX``: float with get, set
        abstract ``minScaleY``: float with get, set
        abstract ``maxScaleY``: float with get, set
        abstract ``color1``: BabylonjsBindings.SimpleClasses.Color4 with get, set
        abstract ``color2``: BabylonjsBindings.SimpleClasses.Color4 with get, set
        abstract ``colorDead``: BabylonjsBindings.SimpleClasses.Color4 with get, set
        abstract ``emitRate``: float with get, set
        abstract ``gravity``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``minEmitPower``: float with get, set
        abstract ``maxEmitPower``: float with get, set
        abstract ``minAngularSpeed``: float with get, set
        abstract ``maxAngularSpeed``: float with get, set
        abstract ``minInitialRotation``: float with get, set
        abstract ``maxInitialRotation``: float with get, set
        abstract ``particleEmitterType``: IParticleEmitterType option with get, set
        abstract ``startDelay``: float with get, set
        abstract ``preWarmCycles``: float with get, set
        abstract ``preWarmStepOffset``: float with get, set
        abstract ``spriteCellChangeSpeed``: float with get, set
        abstract ``startSpriteCellID``: float with get, set
        abstract ``endSpriteCellID``: float with get, set
        abstract ``spriteCellLoop``: bool with get, set
        abstract ``spriteCellWidth``: float with get, set
        abstract ``spriteCellHeight``: float with get, set
        abstract ``spriteRandomStartCell``: bool with get, set
        abstract ``isAnimationSheetEnabled``: bool with get, set
        abstract ``translationPivot``: BabylonjsBindings.SimpleClasses.Vector2 with get, set
        abstract ``noiseTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``noiseStrength``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``billboardMode``: float with get, set
        abstract ``useLogarithmicDepth``: bool with get, set
        abstract ``limitVelocityDamping``: float with get, set
        abstract ``beginAnimationOnStart``: bool with get, set
        abstract ``beginAnimationFrom``: float with get, set
        abstract ``beginAnimationTo``: float with get, set
        abstract ``beginAnimationLoop``: bool with get, set
        abstract ``disposeOnStop``: bool with get, set
        abstract ``manualEmitCount``: float with get, set
        abstract ``isLocal``: bool with get, set
        abstract ``snippetId``: string with get, set
        abstract ``defaultProjectionMatrix``: BabylonjsBindings.SimpleClasses.Matrix with get, set
        abstract ``updateInAnimate``: bool with get, set
        abstract ``_wasDispatched``: bool with get, set
        abstract ``isNodeGenerated``: bool with get, set
        abstract ``doNotSerialize``: bool option with get, set
        abstract ``getCapacity``: unit -> float
        abstract ``getActiveCount``: unit -> float
        abstract ``isStarted``: unit -> bool
        abstract ``animate``: unit -> unit
        abstract ``render``: unit -> float
        abstract ``dispose``: ?``disposeTexture``: bool * ?``disposeAttachedSubEmitters``: bool * ?``disposeEndSubEmitters``: bool -> unit
        abstract ``onDisposeObservable``: BabylonjsBindings.SimpleClasses.Observable<IParticleSystem> with get, set
        abstract ``onStoppedObservable``: BabylonjsBindings.SimpleClasses.Observable<IParticleSystem> with get, set
        abstract ``onStartedObservable``: BabylonjsBindings.SimpleClasses.Observable<IParticleSystem> with get, set
        abstract ``clone``: ``name``: string * ``newEmitter``: obj -> IParticleSystem option
        abstract ``serialize``: ``serializeTexture``: bool -> obj
        abstract ``rebuild``: unit -> unit
        abstract ``forceRefreshGradients``: unit -> unit
        abstract ``start``: ?``delay``: float -> unit
        abstract ``stop``: unit -> unit
        abstract ``reset``: unit -> unit
        abstract ``isStopping``: unit -> bool
        abstract ``isReady``: unit -> bool
        abstract ``getClassName``: unit -> string
        abstract ``getCustomEffect``: ``blendMode``: float -> BabylonjsBindings.SimpleClasses.Effect option
        abstract ``setCustomEffect``: ``effect``: BabylonjsBindings.SimpleClasses.Effect option * ``blendMode``: float -> unit
        abstract ``fillDefines``: ``defines``: ResizeArray<string> * ``blendMode``: float * ?``fillImageProcessing``: bool -> unit
        abstract ``fillUniformsAttributesAndSamplerNames``: ``uniforms``: ResizeArray<string> * ``attributes``: ResizeArray<string> * ``samplers``: ResizeArray<string> -> unit
        abstract ``onBeforeDrawParticlesObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.SimpleClasses.Effect option> with get, set
        abstract ``vertexShaderName``: string with get, set
        abstract ``vertexBuffers``: ImmutableObjectf897d083ff3aObject with get, set
        abstract ``indexBuffer``: BabylonjsBindings.SimpleClasses.DataBuffer option with get, set
        abstract ``addColorGradient``: ``gradient``: float * ``color1``: BabylonjsBindings.SimpleClasses.Color4 * ?``color2``: BabylonjsBindings.SimpleClasses.Color4 -> IParticleSystem
        abstract ``removeColorGradient``: ``gradient``: float -> IParticleSystem
        abstract ``addSizeGradient``: ``gradient``: float * ``factor``: float * ?``factor2``: float -> IParticleSystem
        abstract ``removeSizeGradient``: ``gradient``: float -> IParticleSystem
        abstract ``getColorGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.ColorGradient> option
        abstract ``getSizeGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``getAngularSpeedGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``addAngularSpeedGradient``: ``gradient``: float * ``factor``: float * ?``factor2``: float -> IParticleSystem
        abstract ``removeAngularSpeedGradient``: ``gradient``: float -> IParticleSystem
        abstract ``getVelocityGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``addVelocityGradient``: ``gradient``: float * ``factor``: float * ?``factor2``: float -> IParticleSystem
        abstract ``removeVelocityGradient``: ``gradient``: float -> IParticleSystem
        abstract ``getLimitVelocityGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``addLimitVelocityGradient``: ``gradient``: float * ``factor``: float * ?``factor2``: float -> IParticleSystem
        abstract ``removeLimitVelocityGradient``: ``gradient``: float -> IParticleSystem
        abstract ``addDragGradient``: ``gradient``: float * ``factor``: float * ?``factor2``: float -> IParticleSystem
        abstract ``removeDragGradient``: ``gradient``: float -> IParticleSystem
        abstract ``getDragGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``addEmitRateGradient``: ``gradient``: float * ``factor``: float * ?``factor2``: float -> IParticleSystem
        abstract ``removeEmitRateGradient``: ``gradient``: float -> IParticleSystem
        abstract ``getEmitRateGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``addStartSizeGradient``: ``gradient``: float * ``factor``: float * ?``factor2``: float -> IParticleSystem
        abstract ``removeStartSizeGradient``: ``gradient``: float -> IParticleSystem
        abstract ``getStartSizeGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``addLifeTimeGradient``: ``gradient``: float * ``factor``: float * ?``factor2``: float -> IParticleSystem
        abstract ``removeLifeTimeGradient``: ``gradient``: float -> IParticleSystem
        abstract ``getLifeTimeGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``addRampGradient``: ``gradient``: float * ``color``: BabylonjsBindings.SimpleClasses.Color3 -> IParticleSystem
        abstract ``getRampGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.Color3Gradient> option
        abstract ``useRampGradients``: bool with get, set
        abstract ``addColorRemapGradient``: ``gradient``: float * ``min``: float * ``max``: float -> IParticleSystem
        abstract ``getColorRemapGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``addAlphaRemapGradient``: ``gradient``: float * ``min``: float * ``max``: float -> IParticleSystem
        abstract ``getAlphaRemapGradients``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.FactorGradient> option
        abstract ``createPointEmitter``: ``direction1``: BabylonjsBindings.SimpleClasses.Vector3 * ``direction2``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.PointParticleEmitter
        abstract ``createHemisphericEmitter``: ``radius``: float * ``radiusRange``: float -> BabylonjsBindings.SimpleClasses.HemisphericParticleEmitter
        abstract ``createSphereEmitter``: ``radius``: float * ``radiusRange``: float -> BabylonjsBindings.SimpleClasses.SphereParticleEmitter
        abstract ``createDirectedSphereEmitter``: ``radius``: float * ``direction1``: BabylonjsBindings.SimpleClasses.Vector3 * ``direction2``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.SphereDirectedParticleEmitter
        abstract ``createCylinderEmitter``: ``radius``: float * ``height``: float * ``radiusRange``: float * ``directionRandomizer``: float -> BabylonjsBindings.SimpleClasses.CylinderParticleEmitter
        abstract ``createDirectedCylinderEmitter``: ``radius``: float * ``height``: float * ``radiusRange``: float * ``direction1``: BabylonjsBindings.SimpleClasses.Vector3 * ``direction2``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.CylinderDirectedParticleEmitter
        abstract ``createConeEmitter``: ``radius``: float * ``angle``: float -> BabylonjsBindings.SimpleClasses.ConeParticleEmitter
        abstract ``createDirectedConeEmitter``: ``radius``: float * ``angle``: float * ``direction1``: BabylonjsBindings.SimpleClasses.Vector3 * ``direction2``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.ConeDirectedParticleEmitter
        abstract ``createBoxEmitter``: ``direction1``: BabylonjsBindings.SimpleClasses.Vector3 * ``direction2``: BabylonjsBindings.SimpleClasses.Vector3 * ``minEmitBox``: BabylonjsBindings.SimpleClasses.Vector3 * ``maxEmitBox``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.BoxParticleEmitter
        abstract ``createMeshEmitter``: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option -> BabylonjsBindings.SimpleClasses.MeshParticleEmitter
        abstract ``getScene``: unit -> BabylonjsBindings.SimpleClasses.Scene option

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    [<AllowNullLiteral>]
    type IPhysicsCollisionEvent =
        inherit IBasePhysicsCollisionEvent
        abstract ``point``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``distance``: float with get, set
        abstract ``impulse``: float with get, set
        abstract ``normal``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set

    /// Function-valued IPhysicsEnginePlugin.getBodyPressure property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginGetBodyPressureCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> float

    /// Function-valued IPhysicsEnginePlugin.setBodyPressure property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginSetBodyPressureCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``pressure``: float -> unit

    /// Function-valued IPhysicsEnginePlugin.getBodyStiffness property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginGetBodyStiffnessCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> float

    /// Function-valued IPhysicsEnginePlugin.setBodyStiffness property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginSetBodyStiffnessCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``stiffness``: float -> unit

    /// Function-valued IPhysicsEnginePlugin.getBodyVelocityIterations property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginGetBodyVelocityIterationsCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> float

    /// Function-valued IPhysicsEnginePlugin.setBodyVelocityIterations property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginSetBodyVelocityIterationsCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``velocityIterations``: float -> unit

    /// Function-valued IPhysicsEnginePlugin.getBodyPositionIterations property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginGetBodyPositionIterationsCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> float

    /// Function-valued IPhysicsEnginePlugin.setBodyPositionIterations property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginSetBodyPositionIterationsCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``positionIterations``: float -> unit

    /// Function-valued IPhysicsEnginePlugin.appendAnchor property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginAppendAnchorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``otherImpostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``width``: float * ``height``: float * ``influence``: float * ``noCollisionBetweenLinkedBodies``: bool -> unit

    /// Function-valued IPhysicsEnginePlugin.appendHook property.
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginAppendHookCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``otherImpostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``length``: float * ``influence``: float * ``noCollisionBetweenLinkedBodies``: bool -> unit

    /// @babylonjs/core/Physics/v1/IPhysicsEnginePlugin
    [<AllowNullLiteral>]
    type IPhysicsEnginePlugin =
        abstract ``world``: obj with get, set
        abstract ``name``: string with get, set
        abstract ``setGravity``: ``gravity``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``setTimeStep``: ``timeStep``: float -> unit
        abstract ``getTimeStep``: unit -> float
        abstract ``executeStep``: ``delta``: float * ``impostors``: ResizeArray<BabylonjsBindings.SimpleClasses.PhysicsImpostor> -> unit
        abstract ``getPluginVersion``: unit -> float
        abstract ``applyImpulse``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``force``: BabylonjsBindings.SimpleClasses.Vector3 * ``contactPoint``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``applyForce``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``force``: BabylonjsBindings.SimpleClasses.Vector3 * ``contactPoint``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``generatePhysicsBody``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> unit
        abstract ``removePhysicsBody``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> unit
        abstract ``generateJoint``: ``joint``: PhysicsImpostorJoint -> unit
        abstract ``removeJoint``: ``joint``: PhysicsImpostorJoint -> unit
        abstract ``isSupported``: unit -> bool
        abstract ``setTransformationFromPhysicsBody``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> unit
        abstract ``setPhysicsBodyTransformation``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``newPosition``: BabylonjsBindings.SimpleClasses.Vector3 * ``newRotation``: BabylonjsBindings.SimpleClasses.Quaternion -> unit
        abstract ``setLinearVelocity``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``velocity``: BabylonjsBindings.SimpleClasses.Vector3 option -> unit
        abstract ``setAngularVelocity``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``velocity``: BabylonjsBindings.SimpleClasses.Vector3 option -> unit
        abstract ``getLinearVelocity``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> BabylonjsBindings.SimpleClasses.Vector3 option
        abstract ``getAngularVelocity``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> BabylonjsBindings.SimpleClasses.Vector3 option
        abstract ``setBodyMass``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``mass``: float -> unit
        abstract ``getBodyMass``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> float
        abstract ``getBodyFriction``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> float
        abstract ``setBodyFriction``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``friction``: float -> unit
        abstract ``getBodyRestitution``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> float
        abstract ``setBodyRestitution``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``restitution``: float -> unit
        abstract ``getBodyPressure``: IPhysicsEnginePluginGetBodyPressureCallback option with get, set
        abstract ``setBodyPressure``: IPhysicsEnginePluginSetBodyPressureCallback option with get, set
        abstract ``getBodyStiffness``: IPhysicsEnginePluginGetBodyStiffnessCallback option with get, set
        abstract ``setBodyStiffness``: IPhysicsEnginePluginSetBodyStiffnessCallback option with get, set
        abstract ``getBodyVelocityIterations``: IPhysicsEnginePluginGetBodyVelocityIterationsCallback option with get, set
        abstract ``setBodyVelocityIterations``: IPhysicsEnginePluginSetBodyVelocityIterationsCallback option with get, set
        abstract ``getBodyPositionIterations``: IPhysicsEnginePluginGetBodyPositionIterationsCallback option with get, set
        abstract ``setBodyPositionIterations``: IPhysicsEnginePluginSetBodyPositionIterationsCallback option with get, set
        abstract ``appendAnchor``: IPhysicsEnginePluginAppendAnchorCallback option with get, set
        abstract ``appendHook``: IPhysicsEnginePluginAppendHookCallback option with get, set
        abstract ``sleepBody``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> unit
        abstract ``wakeUpBody``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> unit
        abstract ``raycast``: ``from``: BabylonjsBindings.SimpleClasses.Vector3 * ``to``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.PhysicsRaycastResult
        abstract ``raycastToRef``: ``from``: BabylonjsBindings.SimpleClasses.Vector3 * ``to``: BabylonjsBindings.SimpleClasses.Vector3 * ``result``: BabylonjsBindings.SimpleClasses.PhysicsRaycastResult -> unit
        abstract ``updateDistanceJoint``: ``joint``: BabylonjsBindings.SimpleClasses.PhysicsJoint * ``maxDistance``: float * ?``minDistance``: float -> unit
        abstract ``setMotor``: ``joint``: IMotorEnabledJoint * ``speed``: float * ?``maxForce``: float * ?``motorIndex``: float -> unit
        abstract ``setLimit``: ``joint``: IMotorEnabledJoint * ``upperLimit``: float * ?``lowerLimit``: float * ?``motorIndex``: float -> unit
        abstract ``getRadius``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> float
        abstract ``getBoxSizeToRef``: ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor * ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``syncMeshWithImpostor``: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor -> unit
        abstract ``dispose``: unit -> unit

    /// Function-valued IProceduralTextureCreationOptions.extraInitializationsAsync property.
    [<AllowNullLiteral>]
    type IProceduralTextureCreationOptionsExtraInitializationsAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> JS.Promise<unit>

    /// @babylonjs/core/Materials/Textures/Procedurals/proceduralTexture.pure
    [<AllowNullLiteral>]
    type IProceduralTextureCreationOptions =
        inherit RenderTargetTextureOptions
        abstract ``fallbackTexture``: BabylonjsBindings.SimpleClasses.Texture option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set
        abstract ``extraInitializationsAsync``: IProceduralTextureCreationOptionsExtraInitializationsAsyncCallback option with get, set
        abstract ``skipSceneRegistration``: bool option with get, set

    /// @babylonjs/core/Sprites/spriteManager
    [<AllowNullLiteral>]
    type ISpriteManager =
        inherit IDisposable
        abstract ``uniqueId``: float with get, set
        abstract ``name``: string with get, set
        abstract ``layerMask``: float with get, set
        abstract ``isPickable``: bool with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get, set
        abstract ``renderingGroupId``: float with get, set
        abstract ``sprites``: ResizeArray<BabylonjsBindings.SimpleClasses.Sprite> with get, set
        abstract ``texture``: BabylonjsBindings.SimpleClasses.Texture with get, set
        abstract ``cellWidth``: float with get, set
        abstract ``cellHeight``: float with get, set
        abstract ``_wasDispatched``: bool with get, set
        abstract ``doNotSerialize``: bool option with get, set
        abstract ``intersects``: ``ray``: BabylonjsBindings.SimpleClasses.Ray * ``camera``: BabylonjsBindings.SimpleClasses.Camera * ?``predicate``: System.Func<BabylonjsBindings.SimpleClasses.Sprite, bool> * ?``fastCheck``: bool -> BabylonjsBindings.SimpleClasses.PickingInfo option
        abstract ``multiIntersects``: ``ray``: BabylonjsBindings.SimpleClasses.Ray * ``camera``: BabylonjsBindings.SimpleClasses.Camera * ?``predicate``: System.Func<BabylonjsBindings.SimpleClasses.Sprite, bool> -> ResizeArray<BabylonjsBindings.SimpleClasses.PickingInfo> option
        abstract ``render``: unit -> unit
        abstract ``rebuild``: unit -> unit
        abstract ``serialize``: ?``serializeTexture``: bool -> obj

    /// @babylonjs/core/Meshes/mesh.pure
    [<AllowNullLiteral>]
    type MeshCreationOptions =
        inherit MeshCloneOptions
        abstract ``source``: BabylonjsBindings.SimpleClasses.Mesh option with get, set

    /// @babylonjs/core/Physics/v2/physicsShape
    [<AllowNullLiteral>]
    type PhysicShapeOptions =
        abstract ``type``: BabylonjsBindings.Enums.PhysicsShapeType option with get, set
        abstract ``parameters``: PhysicsShapeParameters option with get, set
        abstract ``pluginData``: obj option with get, set

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    [<AllowNullLiteral>]
    type RenderTargetCreationOptions =
        inherit InternalTextureCreationOptions
        abstract ``generateDepthBuffer``: bool option with get, set
        abstract ``generateStencilBuffer``: bool option with get, set
        abstract ``noColorAttachment``: bool option with get, set
        abstract ``colorAttachment``: BabylonjsBindings.SimpleClasses.InternalTexture option with get, set

    /// @babylonjs/core/IAssetContainer
    [<AllowNullLiteral>]
    type IAssetContainer =
        abstract ``rootNodes``: ResizeArray<BabylonjsBindings.SimpleClasses.Node> with get, set
        abstract ``cameras``: ResizeArray<BabylonjsBindings.SimpleClasses.Camera> with get, set
        abstract ``lights``: ResizeArray<BabylonjsBindings.SimpleClasses.Light> with get, set
        abstract ``meshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> with get, set
        abstract ``skeletons``: ResizeArray<BabylonjsBindings.SimpleClasses.Skeleton> with get, set
        abstract ``particleSystems``: ResizeArray<IParticleSystem> with get, set
        abstract ``animations``: ResizeArray<BabylonjsBindings.SimpleClasses.Animation> with get, set
        abstract ``animationGroups``: ResizeArray<BabylonjsBindings.SimpleClasses.AnimationGroup> with get, set
        abstract ``multiMaterials``: ResizeArray<BabylonjsBindings.SimpleClasses.MultiMaterial> with get, set
        abstract ``materials``: ResizeArray<BabylonjsBindings.SimpleClasses.Material> with get, set
        abstract ``morphTargetManagers``: ResizeArray<BabylonjsBindings.SimpleClasses.MorphTargetManager> with get, set
        abstract ``geometries``: ResizeArray<BabylonjsBindings.SimpleClasses.Geometry> with get, set
        abstract ``transformNodes``: ResizeArray<BabylonjsBindings.SimpleClasses.TransformNode> with get, set
        abstract ``actionManagers``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractActionManager> with get, set
        abstract ``textures``: ResizeArray<BabylonjsBindings.SimpleClasses.BaseTexture> with get, set
        abstract ``environmentTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``postProcesses``: ResizeArray<BabylonjsBindings.SimpleClasses.PostProcess> with get, set
        abstract ``sounds``: ResizeArray<BabylonjsBindings.SimpleClasses.Sound> option with get, set
        abstract ``effectLayers``: ResizeArray<BabylonjsBindings.SimpleClasses.EffectLayer> with get, set
        abstract ``layers``: ResizeArray<BabylonjsBindings.SimpleClasses.Layer> with get, set
        abstract ``reflectionProbes``: ResizeArray<BabylonjsBindings.SimpleClasses.ReflectionProbe> with get, set
        abstract ``lensFlareSystems``: ResizeArray<BabylonjsBindings.SimpleClasses.LensFlareSystem> with get, set
        abstract ``proceduralTextures``: ResizeArray<BabylonjsBindings.SimpleClasses.ProceduralTexture> with get, set
        abstract ``spriteManagers``: ResizeArray<ISpriteManager> option with get, set
        abstract ``getNodes``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.Node>

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundStoredOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundStoredOptions =
        inherit PartialIAbstractSoundStoredOptions
        inherit PartialIStaticSoundOptionsBase
        abstract ``pitch``: float option with get, set
        abstract ``playbackRate``: float option with get, set

    /// Function-valued IPipelineContext._handlesSpectorRebuildCallback property.
    [<AllowNullLiteral>]
    type IPipelineContextHandlesSpectorRebuildCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``onCompiled``: System.Action<obj> -> unit

    /// @babylonjs/core/Engines/IPipelineContext
    [<AllowNullLiteral>]
    type IPipelineContext =
        abstract ``isAsync``: bool with get
        abstract ``isReady``: bool with get
        abstract ``vertexBufferKindToType``: InlineObjecta21f2044e128Object option with get, set
        abstract ``_name``: string option with get, set
        abstract ``_getVertexShaderCode``: unit -> string option
        abstract ``_getFragmentShaderCode``: unit -> string option
        abstract ``_handlesSpectorRebuildCallback``: IPipelineContextHandlesSpectorRebuildCallbackCallback option with get, set
        abstract ``_fillEffectInformation``: ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``uniformBuffersNames``: InlineObject199751a08a94Object * ``uniformsNames``: ResizeArray<string> * ``uniforms``: InlineObject6f1e46ea81ecObject * ``samplerList``: ResizeArray<string> * ``samplers``: InlineObject199751a08a94Object * ``attributesNames``: ResizeArray<string> * ``attributes``: ResizeArray<float> -> unit
        abstract ``dispose``: unit -> unit
        abstract ``setEngine``<'T when 'T :> BabylonjsBindings.SimpleClasses.AbstractEngine>: ``engine``: 'T -> unit
        abstract ``setInt``: ``uniformName``: string * ``value``: float -> unit
        abstract ``setInt2``: ``uniformName``: string * ``x``: float * ``y``: float -> unit
        abstract ``setInt3``: ``uniformName``: string * ``x``: float * ``y``: float * ``z``: float -> unit
        abstract ``setInt4``: ``uniformName``: string * ``x``: float * ``y``: float * ``z``: float * ``w``: float -> unit
        abstract ``setIntArray``: ``uniformName``: string * ``array``: JS.Int32Array -> unit
        abstract ``setIntArray2``: ``uniformName``: string * ``array``: JS.Int32Array -> unit
        abstract ``setIntArray3``: ``uniformName``: string * ``array``: JS.Int32Array -> unit
        abstract ``setIntArray4``: ``uniformName``: string * ``array``: JS.Int32Array -> unit
        abstract ``setUInt``: ``uniformName``: string * ``value``: float -> unit
        abstract ``setUInt2``: ``uniformName``: string * ``x``: float * ``y``: float -> unit
        abstract ``setUInt3``: ``uniformName``: string * ``x``: float * ``y``: float * ``z``: float -> unit
        abstract ``setUInt4``: ``uniformName``: string * ``x``: float * ``y``: float * ``z``: float * ``w``: float -> unit
        abstract ``setUIntArray``: ``uniformName``: string * ``array``: JS.Uint32Array -> unit
        abstract ``setUIntArray2``: ``uniformName``: string * ``array``: JS.Uint32Array -> unit
        abstract ``setUIntArray3``: ``uniformName``: string * ``array``: JS.Uint32Array -> unit
        abstract ``setUIntArray4``: ``uniformName``: string * ``array``: JS.Uint32Array -> unit
        abstract ``setArray``: ``uniformName``: string * ``array``: BabylonjsBindings.TypeAliases.FloatArray -> unit
        abstract ``setArray2``: ``uniformName``: string * ``array``: BabylonjsBindings.TypeAliases.FloatArray -> unit
        abstract ``setArray3``: ``uniformName``: string * ``array``: BabylonjsBindings.TypeAliases.FloatArray -> unit
        abstract ``setArray4``: ``uniformName``: string * ``array``: BabylonjsBindings.TypeAliases.FloatArray -> unit
        abstract ``setMatrices``: ``uniformName``: string * ``matrices``: JS.Float32Array -> unit
        abstract ``setMatrix``: ``uniformName``: string * ``matrix``: IMatrixLike -> unit
        abstract ``setMatrix3x3``: ``uniformName``: string * ``matrix``: JS.Float32Array -> unit
        abstract ``setMatrix2x2``: ``uniformName``: string * ``matrix``: JS.Float32Array -> unit
        abstract ``setFloat``: ``uniformName``: string * ``value``: float -> unit
        abstract ``setVector2``: ``uniformName``: string * ``vector2``: IVector2Like -> unit
        abstract ``setFloat2``: ``uniformName``: string * ``x``: float * ``y``: float -> unit
        abstract ``setVector3``: ``uniformName``: string * ``vector3``: IVector3Like -> unit
        abstract ``setFloat3``: ``uniformName``: string * ``x``: float * ``y``: float * ``z``: float -> unit
        abstract ``setVector4``: ``uniformName``: string * ``vector4``: IVector4Like -> unit
        abstract ``setQuaternion``: ``uniformName``: string * ``quaternion``: IQuaternionLike -> unit
        abstract ``setFloat4``: ``uniformName``: string * ``x``: float * ``y``: float * ``z``: float * ``w``: float -> unit
        abstract ``setColor3``: ``uniformName``: string * ``color3``: IColor3Like -> unit
        abstract ``setColor4``: ``uniformName``: string * ``color3``: IColor3Like * ``alpha``: float -> unit
        abstract ``setDirectColor4``: ``uniformName``: string * ``color4``: IColor4Like -> unit

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type ISceneSerializableComponent =
        inherit ISceneComponent
        abstract ``addFromContainer``: ``container``: IAssetContainer -> unit
        abstract ``removeFromContainer``: ``container``: IAssetContainer * ?``dispose``: bool -> unit
        abstract ``serialize``: ``serializationObject``: obj -> unit

    /// Function-valued ICreateAndPreparePipelineContextOptions.rebuildRebind property.
    [<AllowNullLiteral>]
    type ICreateAndPreparePipelineContextOptionsRebuildRebindCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``vertexSourceCode``: string * ``fragmentSourceCode``: string * ``onCompiled``: System.Action<IPipelineContext> * ``onError``: System.Action<string> -> unit

    /// Function-valued ICreateAndPreparePipelineContextOptions.onRenderingStateCompiled property.
    [<AllowNullLiteral>]
    type ICreateAndPreparePipelineContextOptionsOnRenderingStateCompiledCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``pipelineContext``: IPipelineContext -> unit

    /// @babylonjs/core/Materials/effect.functions
    [<AllowNullLiteral>]
    type ICreateAndPreparePipelineContextOptions =
        abstract ``parallelShaderCompile``: InlineObject350439cd372aObject option with get, set
        abstract ``shaderProcessingContext``: _IShaderProcessingContext option with get, set
        abstract ``existingPipelineContext``: IPipelineContext option with get, set
        abstract ``name``: string option with get, set
        abstract ``rebuildRebind``: ICreateAndPreparePipelineContextOptionsRebuildRebindCallback option with get, set
        abstract ``onRenderingStateCompiled``: ICreateAndPreparePipelineContextOptionsOnRenderingStateCompiledCallback option with get, set
        abstract ``context``: U2<BrowserWebGL2RenderingContext, Browser.Types.WebGLRenderingContext> option with get, set
        abstract ``createAsRaw``: bool option with get, set
        abstract ``vertex``: string with get, set
        abstract ``fragment``: string with get, set
        abstract ``defines``: string option with get, set
        abstract ``transformFeedbackVaryings``: ResizeArray<string> option with get, set
        abstract ``disableParallelCompilation``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<ICreateAndPreparePipelineContextOptions> signatures.
    [<AllowNullLiteral>]
    type PartialICreateAndPreparePipelineContextOptions =
        abstract ``parallelShaderCompile``: InlineObject350439cd372aObject option with get, set
        abstract ``shaderProcessingContext``: _IShaderProcessingContext option with get, set
        abstract ``existingPipelineContext``: IPipelineContext option with get, set
        abstract ``name``: string option with get, set
        abstract ``rebuildRebind``: ICreateAndPreparePipelineContextOptionsRebuildRebindCallback option with get, set
        abstract ``onRenderingStateCompiled``: ICreateAndPreparePipelineContextOptionsOnRenderingStateCompiledCallback option with get, set
        abstract ``context``: U2<BrowserWebGL2RenderingContext, Browser.Types.WebGLRenderingContext> option with get, set
        abstract ``createAsRaw``: bool option with get, set
        abstract ``vertex``: string option with get, set
        abstract ``fragment``: string option with get, set
        abstract ``defines``: string option with get, set
        abstract ``transformFeedbackVaryings``: ResizeArray<string> option with get, set
        abstract ``disableParallelCompilation``: bool option with get, set

    /// Function-valued IEffectCreationOptions.onCompiled property.
    [<AllowNullLiteral>]
    type IEffectCreationOptionsOnCompiledCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: BabylonjsBindings.SimpleClasses.Effect -> unit

    /// Function-valued IEffectCreationOptions.onError property.
    [<AllowNullLiteral>]
    type IEffectCreationOptionsOnErrorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``errors``: string -> unit

    /// Function-valued IEffectCreationOptions.extraInitializationsAsync property.
    [<AllowNullLiteral>]
    type IEffectCreationOptionsExtraInitializationsAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> JS.Promise<unit>

    /// @babylonjs/core/Materials/effect.pure
    [<AllowNullLiteral>]
    type IEffectCreationOptions =
        abstract ``attributes``: ResizeArray<string> with get, set
        abstract ``uniformsNames``: ResizeArray<string> with get, set
        abstract ``uniformBuffersNames``: ResizeArray<string> option with get, set
        abstract ``samplers``: ResizeArray<string> with get, set
        abstract ``defines``: obj with get, set
        abstract ``fallbacks``: IEffectFallbacks option with get, set
        abstract ``onCompiled``: IEffectCreationOptionsOnCompiledCallback option with get, set
        abstract ``onError``: IEffectCreationOptionsOnErrorCallback option with get, set
        abstract ``indexParameters``: obj option with get, set
        abstract ``maxSimultaneousLights``: float option with get, set
        abstract ``transformFeedbackVaryings``: ResizeArray<string> option with get, set
        abstract ``processFinalCode``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set
        abstract ``processCodeAfterIncludes``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set
        abstract ``multiTarget``: bool option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set
        abstract ``existingPipelineContext``: IPipelineContext option with get, set
        abstract ``extraInitializationsAsync``: IEffectCreationOptionsExtraInitializationsAsyncCallback option with get, set
        abstract ``disableParallelShaderCompilation``: bool option with get, set

    /// @babylonjs/core/Materials/effect.functions
    [<AllowNullLiteral>]
    type IPipelineGenerationOptions =
        abstract ``shaderNameOrContent``: U2<string, BabylonjsBindings.ObjectTypes.IShaderPath> with get, set
        abstract ``key``: string option with get, set
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``addGlobalDefines``: bool option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set
        abstract ``platformName``: string option with get, set
        abstract ``extendedProcessingOptions``: Partial_IProcessingOptions option with get, set
        abstract ``extendedCreatePipelineOptions``: PartialICreateAndPreparePipelineContextOptions option with get, set
        abstract ``waitForIsReady``: bool option with get, set
        abstract ``disableParallelCompilation``: bool option with get, set

    /// Distinct ambient WebXR input-source handle.
    [<AllowNullLiteral>]
    type BrowserXRInputSource =
        interface end

    /// Distinct ambient WebXR view handle.
    [<AllowNullLiteral>]
    type BrowserXRView =
        interface end

    /// Exact WebXR eye literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXREye =
        | [<CompiledName("left")>] Left
        | [<CompiledName("none")>] None
        | [<CompiledName("right")>] Right

    /// Exact string literal type for "equalpower".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral4c471054ce25 =
        | [<CompiledName("equalpower")>] Value

    /// Exact string literal type for "HRTF".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralaa280ec1bd96 =
        | [<CompiledName("HRTF")>] Value

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectf1b2bf97a74bObject =
        abstract ``skyBox``: bool option with get, set
        abstract ``ground``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectd4819b480ee2Object =
        abstract ``hostScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``hostElement``: Browser.Types.HTMLElement option with get, set
        abstract ``attachToLiveScene``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject41a2570c8837Object =
        abstract ``rebuild``: bool option with get, set
        abstract ``update``: bool option with get, set
        abstract ``activatePreviewCommand``: bool option with get, set
        abstract ``callback``: System.Func<BabylonjsBindings.SimpleClasses.Scene option, obj, U2<bool, unit> option> option with get, set
        abstract ``onValidation``: System.Func<obj, string, bool> option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject92311f1edd4fObject =
        abstract ``min``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``max``: BabylonjsBindings.SimpleClasses.Vector3 with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject3620a0f42da7Object =
        abstract ``min``: float with get, set
        abstract ``max``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectc76a33138ea4Object =
        abstract ``backgroundColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set
        abstract ``hostScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``hostMesh``: BabylonjsBindings.SimpleClasses.Mesh option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectf897d083ff3aObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> BabylonjsBindings.SimpleClasses.VertexBuffer with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject188c62dea3f2Object =
        abstract ``babylonAnimatable``: IAnimatable with get, set
        abstract ``babylonAnimation``: BabylonjsBindings.SimpleClasses.Animation with get, set

    /// @babylonjs/core/Physics/v2/characterController
    [<AllowNullLiteral>]
    type CharacterShapeOptions =
        abstract ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape option with get, set
        abstract ``capsuleHeight``: float option with get, set
        abstract ``capsuleRadius``: float option with get, set

    /// @babylonjs/core/Physics/v2/characterController
    [<AllowNullLiteral>]
    type CharacterSurfaceInfo =
        abstract ``isSurfaceDynamic``: bool with get, set
        abstract ``supportedState``: BabylonjsBindings.Enums.CharacterSupportedState with get, set
        abstract ``averageSurfaceNormal``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``averageSurfaceVelocity``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``averageAngularSurfaceVelocity``: BabylonjsBindings.SimpleClasses.Vector3 with get, set

    /// @babylonjs/core/Misc/dds.pure
    [<AllowNullLiteral>]
    type DDSInfo =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``mipmapCount``: float with get, set
        abstract ``isFourCC``: bool with get, set
        abstract ``isRGB``: bool with get, set
        abstract ``isLuminance``: bool with get, set
        abstract ``isCube``: bool with get, set
        abstract ``isCompressed``: bool with get, set
        abstract ``dxgiFormat``: float with get, set
        abstract ``textureType``: float with get, set
        abstract ``sphericalPolynomial``: BabylonjsBindings.SimpleClasses.SphericalPolynomial option with get, set

    /// Function-valued EquiRectangularCaptureOptions.meshesFilter property.
    [<AllowNullLiteral>]
    type EquiRectangularCaptureOptionsMeshesFilterCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh -> bool

    /// @babylonjs/core/Misc/equirectangularCapture.pure
    [<AllowNullLiteral>]
    type EquiRectangularCaptureOptions =
        abstract ``size``: float with get, set
        abstract ``meshesFilter``: EquiRectangularCaptureOptionsMeshesFilterCallback option with get, set
        abstract ``filename``: string option with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``probe``: BabylonjsBindings.SimpleClasses.ReflectionProbe option with get, set

    /// @babylonjs/core/Materials/GreasedLine/greasedLineMaterialInterfaces
    [<AllowNullLiteral>]
    type GreasedLineMaterialOptions =
        abstract ``forceGLSL``: bool option with get, set
        abstract ``width``: float option with get, set
        abstract ``sizeAttenuation``: bool option with get, set
        abstract ``materialType``: BabylonjsBindings.Enums.GreasedLineMeshMaterialType option with get, set
        abstract ``color``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``colorMode``: BabylonjsBindings.Enums.GreasedLineMeshColorMode option with get, set
        abstract ``colors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color3> option with get, set
        abstract ``useColors``: bool option with get, set
        abstract ``colorsSampling``: float option with get, set
        abstract ``colorDistributionType``: BabylonjsBindings.Enums.GreasedLineMeshColorDistributionType option with get, set
        abstract ``useDash``: bool option with get, set
        abstract ``dashCount``: float option with get, set
        abstract ``dashOffset``: float option with get, set
        abstract ``dashRatio``: float option with get, set
        abstract ``visibility``: float option with get, set
        abstract ``resolution``: BabylonjsBindings.SimpleClasses.Vector2 option with get, set
        abstract ``cameraFacing``: bool option with get, set
        abstract ``colorsTexture``: BabylonjsBindings.SimpleClasses.RawTexture option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoader.pure
    [<AllowNullLiteral>]
    type IAnimationTargetInfo =
        abstract ``target``: obj with get, set
        abstract ``properties``: ResizeArray<BabylonjsBindings.SimpleClasses.AnimationPropertyInfo> with get, set

    /// @babylonjs/core/Misc/assetsManager
    [<AllowNullLiteral>]
    type IAssetsProgressEvent =
        abstract ``remainingCount``: float with get, set
        abstract ``totalCount``: float with get, set
        abstract ``task``: BabylonjsBindings.SimpleClasses.AbstractAssetTask with get, set

    /// @babylonjs/core/Debug/ISkeletonViewer
    [<AllowNullLiteral>]
    type IBoneWeightShaderOptions =
        abstract ``skeleton``: BabylonjsBindings.SimpleClasses.Skeleton with get, set
        abstract ``colorBase``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``colorZero``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``colorQuarter``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``colorHalf``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``colorFull``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``targetBoneIndex``: float option with get, set

    /// @babylonjs/core/Culling/Helper/IBoundingInfoHelperPlatform
    [<AllowNullLiteral>]
    type IBoundingInfoHelperPlatform =
        abstract ``processAsync``: ``mesh``: U2<BabylonjsBindings.SimpleClasses.AbstractMesh, ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh>> -> JS.Promise<unit>
        abstract ``registerMeshListAsync``: ``mesh``: U2<BabylonjsBindings.SimpleClasses.AbstractMesh, ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh>> -> JS.Promise<unit>
        abstract ``processMeshList``: unit -> unit
        abstract ``fetchResultsForMeshListAsync``: unit -> JS.Promise<unit>
        abstract ``dispose``: unit -> unit

    /// @babylonjs/core/Physics/v2/characterController
    [<AllowNullLiteral>]
    type ICharacterControllerCollisionEvent =
        abstract ``collider``: BabylonjsBindings.SimpleClasses.PhysicsBody with get, set
        abstract ``colliderIndex``: float with get, set
        abstract ``impulse``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``impulsePosition``: BabylonjsBindings.SimpleClasses.Vector3 with get, set

    /// @babylonjs/core/Layers/effectLayer
    [<AllowNullLiteral>]
    type IEffectLayerOptions =
        abstract ``mainTextureRatio``: float with get, set
        abstract ``mainTextureFixedSize``: float option with get, set
        abstract ``alphaBlendingMode``: float with get, set
        abstract ``camera``: BabylonjsBindings.SimpleClasses.Camera option with get, set
        abstract ``renderingGroupId``: float with get, set
        abstract ``mainTextureType``: float with get, set
        abstract ``mainTextureFormat``: float with get, set
        abstract ``generateStencilBuffer``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IEffectLayerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIEffectLayerOptions =
        abstract ``mainTextureRatio``: float option with get, set
        abstract ``mainTextureFixedSize``: float option with get, set
        abstract ``alphaBlendingMode``: float option with get, set
        abstract ``camera``: BabylonjsBindings.SimpleClasses.Camera option with get, set
        abstract ``renderingGroupId``: float option with get, set
        abstract ``mainTextureType``: float option with get, set
        abstract ``mainTextureFormat``: float option with get, set
        abstract ``generateStencilBuffer``: bool option with get, set

    /// @babylonjs/core/Helpers/environmentHelper
    [<AllowNullLiteral>]
    type IEnvironmentHelperOptions =
        abstract ``createGround``: bool with get, set
        abstract ``groundSize``: float with get, set
        abstract ``groundTexture``: U2<string, BabylonjsBindings.SimpleClasses.BaseTexture> with get, set
        abstract ``groundColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``groundOpacity``: float with get, set
        abstract ``enableGroundShadow``: bool with get, set
        abstract ``groundShadowLevel``: float with get, set
        abstract ``enableGroundMirror``: bool with get, set
        abstract ``groundMirrorSizeRatio``: float with get, set
        abstract ``groundMirrorBlurKernel``: float with get, set
        abstract ``groundMirrorAmount``: float with get, set
        abstract ``groundMirrorFresnelWeight``: float with get, set
        abstract ``groundMirrorFallOffDistance``: float with get, set
        abstract ``groundMirrorTextureType``: float with get, set
        abstract ``groundYBias``: float with get, set
        abstract ``createSkybox``: bool with get, set
        abstract ``skyboxSize``: float with get, set
        abstract ``skyboxTexture``: U2<string, BabylonjsBindings.SimpleClasses.BaseTexture> with get, set
        abstract ``skyboxColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``backgroundYRotation``: float with get, set
        abstract ``sizeAuto``: bool with get, set
        abstract ``rootPosition``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``setupImageProcessing``: bool with get, set
        abstract ``environmentTexture``: U2<string, BabylonjsBindings.SimpleClasses.BaseTexture> with get, set
        abstract ``cameraExposure``: float with get, set
        abstract ``cameraContrast``: float with get, set
        abstract ``toneMappingEnabled``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IEnvironmentHelperOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIEnvironmentHelperOptions =
        abstract ``createGround``: bool option with get, set
        abstract ``groundSize``: float option with get, set
        abstract ``groundTexture``: U2<string, BabylonjsBindings.SimpleClasses.BaseTexture> option with get, set
        abstract ``groundColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``groundOpacity``: float option with get, set
        abstract ``enableGroundShadow``: bool option with get, set
        abstract ``groundShadowLevel``: float option with get, set
        abstract ``enableGroundMirror``: bool option with get, set
        abstract ``groundMirrorSizeRatio``: float option with get, set
        abstract ``groundMirrorBlurKernel``: float option with get, set
        abstract ``groundMirrorAmount``: float option with get, set
        abstract ``groundMirrorFresnelWeight``: float option with get, set
        abstract ``groundMirrorFallOffDistance``: float option with get, set
        abstract ``groundMirrorTextureType``: float option with get, set
        abstract ``groundYBias``: float option with get, set
        abstract ``createSkybox``: bool option with get, set
        abstract ``skyboxSize``: float option with get, set
        abstract ``skyboxTexture``: U2<string, BabylonjsBindings.SimpleClasses.BaseTexture> option with get, set
        abstract ``skyboxColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``backgroundYRotation``: float option with get, set
        abstract ``sizeAuto``: bool option with get, set
        abstract ``rootPosition``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``setupImageProcessing``: bool option with get, set
        abstract ``environmentTexture``: U2<string, BabylonjsBindings.SimpleClasses.BaseTexture> option with get, set
        abstract ``cameraExposure``: float option with get, set
        abstract ``cameraContrast``: float option with get, set
        abstract ``toneMappingEnabled``: bool option with get, set

    /// @babylonjs/core/FlowGraph/flowGraphCoordinator
    [<AllowNullLiteral>]
    type IFlowGraphCoordinatorConfiguration =
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get, set

    /// @babylonjs/core/FlowGraph/flowGraph
    [<AllowNullLiteral>]
    type IFlowGraphEditorLaunchOptions =
        abstract ``editorURL``: string option with get, set
        abstract ``flowGraphEditorConfig``: InlineObjectd4819b480ee2Object option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPointerOutEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphPointerOutEventPayload =
        abstract ``pointerId``: float with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set
        abstract ``over``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPointerOverEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphPointerOverEventPayload =
        abstract ``pointerId``: float with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set
        abstract ``out``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set

    /// @babylonjs/core/Materials/GaussianSplatting/gaussianSplattingDebugMaterialPlugin.pure
    [<AllowNullLiteral>]
    type IGaussianSplattingDebugOptions =
        abstract ``clippingBox``: InlineObject92311f1edd4fObject option with get, set
        abstract ``opacityCulling``: InlineObject3620a0f42da7Object option with get, set
        abstract ``sizeCulling``: InlineObject3620a0f42da7Object option with get, set
        abstract ``opacityScale``: float with get, set
        abstract ``opacitySaturate``: bool with get, set
        abstract ``shDc``: bool with get, set
        abstract ``shOrder1``: bool with get, set
        abstract ``shOrder2``: bool with get, set
        abstract ``shOrder3``: bool with get, set
        abstract ``shOrder4``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IGaussianSplattingDebugOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIGaussianSplattingDebugOptions =
        abstract ``clippingBox``: InlineObject92311f1edd4fObject option with get, set
        abstract ``opacityCulling``: InlineObject3620a0f42da7Object option with get, set
        abstract ``sizeCulling``: InlineObject3620a0f42da7Object option with get, set
        abstract ``opacityScale``: float option with get, set
        abstract ``opacitySaturate``: bool option with get, set
        abstract ``shDc``: bool option with get, set
        abstract ``shOrder1``: bool option with get, set
        abstract ``shOrder2``: bool option with get, set
        abstract ``shOrder3``: bool option with get, set
        abstract ``shOrder4``: bool option with get, set

    /// @babylonjs/core/Collisions/gpuPicker
    [<AllowNullLiteral>]
    type IGPUMultiPickingInfo =
        abstract ``meshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh option> with get, set
        abstract ``thinInstanceIndexes``: ResizeArray<float> option with get, set
        abstract ``pickedPoints``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3 option> option with get, set
        abstract ``normals``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3 option> option with get, set

    /// Function-valued IGPUParticleSystemPlatform.contextLost property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformContextLostCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued IGPUParticleSystemPlatform.isUpdateBufferCreated property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformIsUpdateBufferCreatedCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> bool

    /// Function-valued IGPUParticleSystemPlatform.isUpdateBufferReady property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformIsUpdateBufferReadyCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> bool

    /// Function-valued IGPUParticleSystemPlatform.createUpdateBuffer property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformCreateUpdateBufferCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``defines``: string -> BabylonjsBindings.SimpleClasses.UniformBufferEffectCommonAccessor

    /// Function-valued IGPUParticleSystemPlatform.createVertexBuffers property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformCreateVertexBuffersCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``updateBuffer``: BabylonjsBindings.SimpleClasses.Buffer * ``renderVertexBuffers``: InlineObjectf897d083ff3aObject -> unit

    /// Function-valued IGPUParticleSystemPlatform.createParticleBuffer property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformCreateParticleBufferCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: ResizeArray<float> -> U2<BabylonjsBindings.TypeAliases.DataArray, BabylonjsBindings.SimpleClasses.DataBuffer>

    /// Function-valued IGPUParticleSystemPlatform.bindDrawBuffers property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformBindDrawBuffersCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``index``: float * ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``indexBuffer``: BabylonjsBindings.SimpleClasses.DataBuffer option -> unit

    /// Function-valued IGPUParticleSystemPlatform.preUpdateParticleBuffer property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformPreUpdateParticleBufferCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued IGPUParticleSystemPlatform.updateParticleBuffer property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformUpdateParticleBufferCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``index``: float * ``targetBuffer``: BabylonjsBindings.SimpleClasses.Buffer * ``currentActiveCount``: float -> unit

    /// Function-valued IGPUParticleSystemPlatform.releaseBuffers property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformReleaseBuffersCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued IGPUParticleSystemPlatform.releaseVertexBuffers property.
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatformReleaseVertexBuffersCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Particles/IGPUParticleSystemPlatform
    [<AllowNullLiteral>]
    type IGPUParticleSystemPlatform =
        abstract ``alignDataInBuffer``: bool with get, set
        abstract ``contextLost``: IGPUParticleSystemPlatformContextLostCallback with get, set
        abstract ``isUpdateBufferCreated``: IGPUParticleSystemPlatformIsUpdateBufferCreatedCallback with get, set
        abstract ``isUpdateBufferReady``: IGPUParticleSystemPlatformIsUpdateBufferReadyCallback with get, set
        abstract ``createUpdateBuffer``: IGPUParticleSystemPlatformCreateUpdateBufferCallback with get, set
        abstract ``createVertexBuffers``: IGPUParticleSystemPlatformCreateVertexBuffersCallback with get, set
        abstract ``createParticleBuffer``: IGPUParticleSystemPlatformCreateParticleBufferCallback with get, set
        abstract ``bindDrawBuffers``: IGPUParticleSystemPlatformBindDrawBuffersCallback with get, set
        abstract ``preUpdateParticleBuffer``: IGPUParticleSystemPlatformPreUpdateParticleBufferCallback with get, set
        abstract ``updateParticleBuffer``: IGPUParticleSystemPlatformUpdateParticleBufferCallback with get, set
        abstract ``releaseBuffers``: IGPUParticleSystemPlatformReleaseBuffersCallback with get, set
        abstract ``releaseVertexBuffers``: IGPUParticleSystemPlatformReleaseVertexBuffersCallback with get, set

    /// @babylonjs/core/Collisions/gpuPicker
    [<AllowNullLiteral>]
    type IGPUPickingInfo =
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set
        abstract ``thinInstanceIndex``: float option with get, set
        abstract ``pickedPoint``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``normal``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set

    /// @babylonjs/core/Materials/GreasedLine/greasedLineMaterialInterfaces
    [<AllowNullLiteral>]
    type IGreasedLineMaterial =
        abstract ``visibility``: float with get, set
        abstract ``width``: float with get, set
        abstract ``useDash``: bool with get, set
        abstract ``dashCount``: float with get, set
        abstract ``dashOffset``: float with get, set
        abstract ``dashRatio``: float with get, set
        abstract ``useColors``: bool with get, set
        abstract ``colorMode``: BabylonjsBindings.Enums.GreasedLineMeshColorMode with get, set
        abstract ``colors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color3> option with get, set
        abstract ``sizeAttenuation``: bool with get, set
        abstract ``color``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``colorsDistributionType``: BabylonjsBindings.Enums.GreasedLineMeshColorDistributionType with get, set
        abstract ``resolution``: BabylonjsBindings.SimpleClasses.Vector2 with get, set
        abstract ``colorsTexture``: BabylonjsBindings.SimpleClasses.RawTexture option with get, set
        abstract ``setColor``: ``value``: BabylonjsBindings.SimpleClasses.Color3 option * ?``doNotMarkDirty``: bool -> unit
        abstract ``setColors``: ``colors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color3> option * ``lazy``: bool * ?``forceNewTexture``: bool -> unit
        abstract ``updateLazy``: unit -> unit

    /// @babylonjs/core/Materials/Textures/Filtering/hdrFiltering
    [<AllowNullLiteral>]
    type IHDRFilteringOptions =
        abstract ``hdrScale``: float option with get, set
        abstract ``quality``: float option with get, set

    /// @babylonjs/core/Materials/Textures/htmlElementTexture.pure
    [<AllowNullLiteral>]
    type IHtmlElementTextureOptions =
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``format``: float option with get, set
        abstract ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine option with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene option with get, set

    /// @babylonjs/core/Materials/Textures/HTML/htmlTexture
    [<AllowNullLiteral>]
    type IHtmlTextureOptions =
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``format``: float option with get, set
        abstract ``autoUpdate``: bool option with get, set
        abstract ``useSvgFallback``: bool option with get, set
        abstract ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine option with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene option with get, set

    /// @babylonjs/core/Meshes/lattice
    [<AllowNullLiteral>]
    type ILatticeOptions =
        abstract ``resolutionX``: float with get, set
        abstract ``resolutionY``: float with get, set
        abstract ``resolutionZ``: float with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``size``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``autoAdaptToMesh``: BabylonjsBindings.SimpleClasses.Mesh option with get, set

    /// Exact optional-property projection used by Babylon Partial<ILatticeOptions> signatures.
    [<AllowNullLiteral>]
    type PartialILatticeOptions =
        abstract ``resolutionX``: float option with get, set
        abstract ``resolutionY``: float option with get, set
        abstract ``resolutionZ``: float option with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``size``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``autoAdaptToMesh``: BabylonjsBindings.SimpleClasses.Mesh option with get, set

    /// @babylonjs/core/Meshes/csg2
    [<AllowNullLiteral>]
    type IMeshRebuildOptions =
        abstract ``rebuildNormals``: bool option with get, set
        abstract ``centerMesh``: bool option with get, set
        abstract ``materialToUse``: BabylonjsBindings.SimpleClasses.Material option with get, set

    /// Exact optional-property projection used by Babylon Partial<IMeshRebuildOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIMeshRebuildOptions =
        abstract ``rebuildNormals``: bool option with get, set
        abstract ``centerMesh``: bool option with get, set
        abstract ``materialToUse``: BabylonjsBindings.SimpleClasses.Material option with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMotionControllerButtonMeshMap =
        abstract ``pressedMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set
        abstract ``unpressedMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set
        abstract ``valueMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMotionControllerMeshMap =
        abstract ``maxMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set
        abstract ``minMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set
        abstract ``valueMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeCamera =
        abstract ``createVideo``: ``constraints``: BrowserMediaTrackConstraints -> obj
        abstract ``updateVideoTexture``: ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture option * ``video``: Browser.Types.HTMLVideoElement * ``invertY``: bool -> unit

    /// @babylonjs/core/Meshes/Node/nodeGeometry
    [<AllowNullLiteral>]
    type INodeGeometryEditorOptions =
        abstract ``editorURL``: string option with get, set
        abstract ``nodeGeometryEditorConfig``: InlineObjectc76a33138ea4Object option with get, set

    /// @babylonjs/core/Culling/Octrees/octreeBlock
    [<AllowNullLiteral>]
    type IOctreeContainer<'T> =
        abstract ``blocks``: ResizeArray<BabylonjsBindings.SimpleClasses.OctreeBlock<'T>> with get, set

    /// @babylonjs/core/Physics/physicsShapeCastQuery
    [<AllowNullLiteral>]
    type IPhysicsShapeCastQuery =
        abstract ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape with get, set
        abstract ``rotation``: BabylonjsBindings.SimpleClasses.Quaternion with get, set
        abstract ``startPosition``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``endPosition``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``shouldHitTriggers``: bool with get, set
        abstract ``ignoreBody``: BabylonjsBindings.SimpleClasses.PhysicsBody option with get, set

    /// @babylonjs/core/Physics/physicsShapeProximityCastQuery
    [<AllowNullLiteral>]
    type IPhysicsShapeProximityCastQuery =
        abstract ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``rotation``: BabylonjsBindings.SimpleClasses.Quaternion with get, set
        abstract ``maxDistance``: float with get, set
        abstract ``shouldHitTriggers``: bool with get, set
        abstract ``ignoreBody``: BabylonjsBindings.SimpleClasses.PhysicsBody option with get, set

    /// Function-valued IPickingCustomization.internalPickerForMesh property.
    [<AllowNullLiteral>]
    type IPickingCustomizationInternalPickerForMeshCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``pickingInfo``: BabylonjsBindings.SimpleClasses.PickingInfo option * ``rayFunction``: System.Func<BabylonjsBindings.SimpleClasses.Matrix, bool, BabylonjsBindings.SimpleClasses.Ray> * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``world``: BabylonjsBindings.SimpleClasses.Matrix * ?``fastCheck``: bool * ?``onlyBoundingInfo``: bool * ?``trianglePredicate``: BabylonjsBindings.TypeAliases.TrianglePickingPredicate * ?``skipBoundingInfo``: bool -> BabylonjsBindings.SimpleClasses.PickingInfo

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type IPickingCustomization =
        abstract ``internalPickerForMesh``: IPickingCustomizationInternalPickerForMeshCallback option with get, set

    /// @babylonjs/core/Physics/physicsRaycastResult
    [<AllowNullLiteral>]
    type IRaycastQuery =
        abstract ``membership``: float option with get, set
        abstract ``collideWith``: float option with get, set
        abstract ``shouldHitTriggers``: bool option with get, set
        abstract ``ignoreBody``: BabylonjsBindings.SimpleClasses.PhysicsBody option with get, set

    /// @babylonjs/core/Rendering/geometryBufferRenderer.pure
    [<AllowNullLiteral>]
    type ISavedTransformationMatrix =
        abstract ``world``: BabylonjsBindings.SimpleClasses.Matrix with get, set
        abstract ``viewProjection``: BabylonjsBindings.SimpleClasses.Matrix with get, set

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/IShapeBlock
    [<AllowNullLiteral>]
    type IShapeBlock =
        abstract ``particle``: BabylonjsBindings.SimpleClasses.NodeParticleConnectionPoint with get, set
        abstract ``output``: BabylonjsBindings.SimpleClasses.NodeParticleConnectionPoint with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudioListener
    [<AllowNullLiteral>]
    type ISpatialAudioListenerOptions =
        abstract ``listenerAutoUpdate``: bool with get, set
        abstract ``listenerEnabled``: bool with get, set
        abstract ``listenerMinUpdateTime``: float with get, set
        abstract ``listenerPosition``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``listenerRotation``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``listenerRotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion with get, set

    /// Exact optional-property projection used by Babylon Partial<ISpatialAudioListenerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialISpatialAudioListenerOptions =
        abstract ``listenerAutoUpdate``: bool option with get, set
        abstract ``listenerEnabled``: bool option with get, set
        abstract ``listenerMinUpdateTime``: float option with get, set
        abstract ``listenerPosition``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``listenerRotation``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``listenerRotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudio
    [<AllowNullLiteral>]
    type ISpatialAudioOptions =
        abstract ``spatialAutoUpdate``: bool with get, set
        abstract ``spatialConeInnerAngle``: float with get, set
        abstract ``spatialConeOuterAngle``: float with get, set
        abstract ``spatialConeOuterVolume``: float with get, set
        abstract ``spatialDistanceModel``: U3<StringLiteral7f2fe580edb3, StringLiteral7705accd2694, StringLiterald075063d475b> with get, set
        abstract ``spatialEnabled``: bool with get, set
        abstract ``spatialMaxDistance``: float with get, set
        abstract ``spatialMinUpdateTime``: float with get, set
        abstract ``spatialOrientation``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``spatialPanningEnabled``: bool with get, set
        abstract ``spatialPanningModel``: U2<StringLiteral4c471054ce25, StringLiteralaa280ec1bd96> with get, set
        abstract ``spatialPosition``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``spatialMinDistance``: float with get, set
        abstract ``spatialRolloffFactor``: float with get, set
        abstract ``spatialRotation``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``spatialRotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion with get, set

    /// Exact optional-property projection used by Babylon Partial<ISpatialAudioOptions> signatures.
    [<AllowNullLiteral>]
    type PartialISpatialAudioOptions =
        abstract ``spatialAutoUpdate``: bool option with get, set
        abstract ``spatialConeInnerAngle``: float option with get, set
        abstract ``spatialConeOuterAngle``: float option with get, set
        abstract ``spatialConeOuterVolume``: float option with get, set
        abstract ``spatialDistanceModel``: U3<StringLiteral7f2fe580edb3, StringLiteral7705accd2694, StringLiterald075063d475b> option with get, set
        abstract ``spatialEnabled``: bool option with get, set
        abstract ``spatialMaxDistance``: float option with get, set
        abstract ``spatialMinUpdateTime``: float option with get, set
        abstract ``spatialOrientation``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``spatialPanningEnabled``: bool option with get, set
        abstract ``spatialPanningModel``: U2<StringLiteral4c471054ce25, StringLiteralaa280ec1bd96> option with get, set
        abstract ``spatialPosition``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``spatialMinDistance``: float option with get, set
        abstract ``spatialRolloffFactor``: float option with get, set
        abstract ``spatialRotation``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``spatialRotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion option with get, set

    /// @babylonjs/core/Sprites/spriteMap.pure
    [<AllowNullLiteral>]
    type ISpriteMapOptions =
        abstract ``stageSize``: BabylonjsBindings.SimpleClasses.Vector2 option with get, set
        abstract ``outputSize``: BabylonjsBindings.SimpleClasses.Vector2 option with get, set
        abstract ``outputPosition``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``outputRotation``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``layerCount``: float option with get, set
        abstract ``maxAnimationFrames``: float option with get, set
        abstract ``baseTile``: float option with get, set
        abstract ``flipU``: bool option with get, set
        abstract ``colorMultiply``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``frameRotationDirection``: BabylonjsBindings.Enums.SpriteMapFrameRotationDirection option with get, set

    /// @babylonjs/core/Misc/assetsManager
    [<AllowNullLiteral>]
    type ITextureAssetTask<'Tex when 'Tex :> BabylonjsBindings.SimpleClasses.BaseTexture> =
        abstract ``texture``: 'Tex with get, set

    /// @babylonjs/core/Materials/Textures/textureMerger
    [<AllowNullLiteral>]
    type ITextureChannelInput =
        abstract ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set
        abstract ``sourceChannel``: float with get, set

    /// @babylonjs/core/Materials/Textures/Packer/frame
    [<AllowNullLiteral>]
    type ITexturePackerFrame =
        abstract ``id``: float with get, set
        abstract ``scale``: BabylonjsBindings.SimpleClasses.Vector2 with get, set
        abstract ``offset``: BabylonjsBindings.SimpleClasses.Vector2 with get, set

    /// Function-valued ITextureProcessOperand.dispose property.
    [<AllowNullLiteral>]
    type ITextureProcessOperandDisposeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type ITextureProcessOperand =
        abstract ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``factor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set
        abstract ``channel``: BabylonjsBindings.Enums.TextureChannel option with get, set
        abstract ``colorSpace``: BabylonjsBindings.Enums.TextureColorSpace option with get, set
        abstract ``dispose``: ITextureProcessOperandDisposeCallback option with get, set

    /// @babylonjs/core/XR/features/WebXRAnchorSystem.pure
    [<AllowNullLiteral>]
    type IWebXRAnchorSystemOptions =
        abstract ``worldParentNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set
        abstract ``doNotRemoveAnchorsOnSessionEnded``: bool option with get, set
        abstract ``clearAnchorsOnSessionInit``: bool option with get, set

    /// @babylonjs/core/XR/features/WebXRBackgroundRemover.pure
    [<AllowNullLiteral>]
    type IWebXRBackgroundRemoverOptions =
        abstract ``backgroundMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> option with get, set
        abstract ``environmentHelperRemovalFlags``: InlineObjectf1b2bf97a74bObject option with get, set
        abstract ``ignoreEnvironmentHelper``: bool option with get, set

    /// @babylonjs/core/XR/features/WebXRFeaturePointSystem.pure
    [<AllowNullLiteral>]
    type IWebXRFeaturePoint =
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``confidenceValue``: float with get, set

    /// @babylonjs/core/XR/features/WebXRHitTestLegacy
    [<AllowNullLiteral>]
    type IWebXRLegacyHitTestOptions =
        abstract ``testOnPointerDownOnly``: bool option with get, set
        abstract ``worldParentNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set

    /// @babylonjs/core/XR/features/WebXRLightEstimation.pure
    [<AllowNullLiteral>]
    type IWebXRLightEstimation =
        abstract ``lightIntensity``: float with get, set
        abstract ``lightColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``lightDirection``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``sphericalHarmonics``: BabylonjsBindings.SimpleClasses.SphericalHarmonics with get, set

    /// @babylonjs/core/Physics/v2/physicsAggregate
    [<AllowNullLiteral>]
    type PhysicsAggregateParameters =
        abstract ``mass``: float with get, set
        abstract ``friction``: float option with get, set
        abstract ``restitution``: float option with get, set
        abstract ``radius``: float option with get, set
        abstract ``pointA``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``pointB``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``extents``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``rotation``: BabylonjsBindings.SimpleClasses.Quaternion option with get, set
        abstract ``center``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.Mesh option with get, set
        abstract ``startAsleep``: bool option with get, set
        abstract ``isTriggerShape``: bool option with get, set

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsGravitationalFieldEventData =
        abstract ``sphere``: BabylonjsBindings.SimpleClasses.Mesh with get, set

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsHitData =
        abstract ``force``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``contactPoint``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``distanceFromOrigin``: float with get, set
        abstract ``instanceIndex``: float option with get, set

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsRadialExplosionEventData =
        abstract ``sphere``: BabylonjsBindings.SimpleClasses.Mesh with get, set

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsUpdraftEventData =
        abstract ``cylinder``: BabylonjsBindings.SimpleClasses.Mesh option with get, set

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsVortexEventData =
        abstract ``cylinder``: BabylonjsBindings.SimpleClasses.Mesh with get, set

    /// @babylonjs/core/Gizmos/positionGizmo
    [<AllowNullLiteral>]
    type PositionGizmoOptions =
        abstract ``additionalTransformNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set

    /// @babylonjs/core/Gizmos/scaleGizmo
    [<AllowNullLiteral>]
    type ScaleGizmoOptions =
        abstract ``additionalTransformNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set

    /// @babylonjs/core/Cameras/VR/vrExperienceHelper.pure
    [<AllowNullLiteral>]
    type VRExperienceHelperOptions =
        abstract ``createDeviceOrientationCamera``: bool option with get, set
        abstract ``createFallbackVRDeviceOrientationFreeCamera``: bool option with get, set
        abstract ``laserToggle``: bool option with get, set
        abstract ``floorMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.Mesh> option with get, set
        abstract ``vrDeviceOrientationCameraMetrics``: BabylonjsBindings.SimpleClasses.VRCameraMetrics option with get, set
        abstract ``useXR``: bool option with get, set

    /// @babylonjs/core/Cameras/VR/vrExperienceHelper.pure
    [<AllowNullLiteral>]
    type VRTeleportationOptions =
        abstract ``floorMeshName``: string option with get, set
        abstract ``floorMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.Mesh> option with get, set
        abstract ``teleportationMode``: float option with get, set
        abstract ``teleportationTime``: float option with get, set
        abstract ``teleportationSpeed``: float option with get, set
        abstract ``easingFunction``: BabylonjsBindings.SimpleClasses.EasingFunction option with get, set

    /// @babylonjs/core/Physics/v1/physicsJoint
    [<AllowNullLiteral>]
    type DistanceJointData =
        inherit PhysicsJointData
        abstract ``maxDistance``: float with get, set

    /// @babylonjs/core/Navigation/INavigationEngine
    [<AllowNullLiteral>]
    type ICrowd =
        abstract ``addAgent``: ``pos``: BabylonjsBindings.SimpleClasses.Vector3 * ``parameters``: IAgentParameters * ``transform``: BabylonjsBindings.SimpleClasses.TransformNode -> float
        abstract ``getAgentPosition``: ``index``: float -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``getAgentPositionToRef``: ``index``: float * ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``getAgentVelocity``: ``index``: float -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``getAgentVelocityToRef``: ``index``: float * ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``getAgentNextTargetPath``: ``index``: float -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``getAgentState``: ``index``: float -> float
        abstract ``overOffmeshConnection``: ``index``: float -> bool
        abstract ``getAgentNextTargetPathToRef``: ``index``: float * ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``removeAgent``: ``index``: float -> unit
        abstract ``getAgents``: unit -> ResizeArray<float>
        abstract ``update``: ``deltaTime``: float -> unit
        abstract ``agentGoto``: ``index``: float * ``destination``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``agentTeleport``: ``index``: float * ``destination``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``updateAgentParameters``: ``index``: float * ``parameters``: IAgentParameters -> unit
        abstract ``setDefaultQueryExtent``: ``extent``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``getDefaultQueryExtent``: unit -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``getDefaultQueryExtentToRef``: ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``getCorners``: ``index``: float -> ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>
        abstract ``dispose``: unit -> unit

    /// @babylonjs/core/Materials/Textures/dynamicTexture.pure
    [<AllowNullLiteral>]
    type IDynamicTextureOptions =
        inherit ITextureCreationOptions
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene option with get, set

    /// @babylonjs/core/Decorators/nodeDecorator
    [<AllowNullLiteral>]
    type IEditablePropertyOption =
        abstract ``embedded``: bool option with get, set
        abstract ``min``: float option with get, set
        abstract ``max``: float option with get, set
        abstract ``notifiers``: InlineObject41a2570c8837Object option with get, set
        abstract ``options``: ResizeArray<IEditablePropertyListOption> option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphMeshPickEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphMeshPickEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``stopPropagation``: bool option with get, set
        abstract ``targetMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPointerOutEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphPointerOutEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``stopPropagation``: bool option with get, set
        abstract ``targetMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPointerOverEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphPointerOverEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``stopPropagation``: bool option with get, set
        abstract ``targetMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set

    /// @babylonjs/core/Gizmos/gizmo
    [<AllowNullLiteral>]
    type IGizmo =
        inherit IDisposable
        abstract ``isHovered``: bool with get
        abstract ``_rootMesh``: BabylonjsBindings.SimpleClasses.Mesh with get, set
        abstract ``scaleRatio``: float with get, set
        abstract ``attachedMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set
        abstract ``attachedNode``: BabylonjsBindings.SimpleClasses.Node option with get, set
        abstract ``updateGizmoRotationToMatchAttachedMesh``: bool with get, set
        abstract ``gizmoLayer``: BabylonjsBindings.SimpleClasses.UtilityLayerRenderer with get, set
        abstract ``updateGizmoPositionToMatchAttachedMesh``: bool with get, set
        abstract ``anchorPoint``: BabylonjsBindings.Enums.GizmoAnchorPoint with get, set
        abstract ``coordinatesMode``: BabylonjsBindings.Enums.GizmoCoordinatesMode with get, set
        abstract ``updateScale``: bool with get, set
        abstract ``customRotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion option with get, set
        abstract ``setCustomMesh``: ``mesh``: BabylonjsBindings.SimpleClasses.Mesh -> unit
        abstract ``additionalTransformNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set

    /// Function-valued IInterpolationPropertyInfo.getValue property.
    [<AllowNullLiteral>]
    type IInterpolationPropertyInfoGetValueCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``target``: obj * ``source``: JS.Float32Array * ``offset``: float * ``scale``: float -> obj

    /// Function-valued IInterpolationPropertyInfo.getStride property.
    [<AllowNullLiteral>]
    type IInterpolationPropertyInfoGetStrideCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``target``: obj -> float

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type IInterpolationPropertyInfo =
        abstract ``type``: float with get, set
        abstract ``name``: string with get, set
        abstract ``getValue``: IInterpolationPropertyInfoGetValueCallback with get, set
        abstract ``getStride``: IInterpolationPropertyInfoGetStrideCallback with get, set
        abstract ``buildAnimations``: ``target``: obj * ``name``: string * ``fps``: float * ``keys``: ResizeArray<obj> -> ResizeArray<InlineObject188c62dea3f2Object>

    /// Function-valued ISimplificationTask.successCallback property.
    [<AllowNullLiteral>]
    type ISimplificationTaskSuccessCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Meshes/meshSimplification
    [<AllowNullLiteral>]
    type ISimplificationTask =
        abstract ``settings``: ResizeArray<ISimplificationSettings> with get, set
        abstract ``simplificationType``: BabylonjsBindings.Enums.SimplificationType with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.Mesh with get, set
        abstract ``successCallback``: ISimplificationTaskSuccessCallbackCallback option with get, set
        abstract ``parallelProcessing``: bool with get, set

    /// @babylonjs/core/Meshes/meshSimplification
    [<AllowNullLiteral>]
    type ISimplifier =
        abstract ``simplify``: ``settings``: ISimplificationSettings * ``successCallback``: System.Action<BabylonjsBindings.SimpleClasses.Mesh> * ?``errorCallback``: System.Action -> unit

    /// @babylonjs/core/Debug/ISkeletonViewer
    [<AllowNullLiteral>]
    type ISkeletonMapShaderOptions =
        abstract ``skeleton``: BabylonjsBindings.SimpleClasses.Skeleton with get, set
        abstract ``colorMap``: ResizeArray<ISkeletonMapShaderColorMapKnot> option with get, set

    /// @babylonjs/core/Layers/thinGlowLayer
    [<AllowNullLiteral>]
    type IThinGlowLayerOptions =
        inherit IThinEffectLayerOptions
        abstract ``blurKernelSize``: float option with get, set
        abstract ``ldrMerge``: bool option with get, set
        abstract ``excludeByDefault``: bool option with get, set

    /// Exact required-property projection used by Required<IThinGlowLayerOptions> signatures.
    [<AllowNullLiteral>]
    type RequiredIThinGlowLayerOptions =
        inherit RequiredIThinEffectLayerOptions
        abstract ``blurKernelSize``: float with get, set
        abstract ``ldrMerge``: bool with get, set
        abstract ``excludeByDefault``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IThinGlowLayerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIThinGlowLayerOptions =
        inherit PartialIThinEffectLayerOptions
        abstract ``blurKernelSize``: float option with get, set
        abstract ``ldrMerge``: bool option with get, set
        abstract ``excludeByDefault``: bool option with get, set

    /// @babylonjs/core/Layers/thinHighlightLayer
    [<AllowNullLiteral>]
    type IThinHighlightLayerOptions =
        inherit IThinEffectLayerOptions
        abstract ``blurTextureSizeRatio``: float option with get, set
        abstract ``blurVerticalSize``: float option with get, set
        abstract ``blurHorizontalSize``: float option with get, set
        abstract ``isStroke``: bool option with get, set
        abstract ``forceGLSL``: bool option with get, set

    /// Exact required-property projection used by Required<IThinHighlightLayerOptions> signatures.
    [<AllowNullLiteral>]
    type RequiredIThinHighlightLayerOptions =
        inherit RequiredIThinEffectLayerOptions
        abstract ``blurTextureSizeRatio``: float with get, set
        abstract ``blurVerticalSize``: float with get, set
        abstract ``blurHorizontalSize``: float with get, set
        abstract ``isStroke``: bool with get, set
        abstract ``forceGLSL``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IThinHighlightLayerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIThinHighlightLayerOptions =
        inherit PartialIThinEffectLayerOptions
        abstract ``blurTextureSizeRatio``: float option with get, set
        abstract ``blurVerticalSize``: float option with get, set
        abstract ``blurHorizontalSize``: float option with get, set
        abstract ``isStroke``: bool option with get, set
        abstract ``forceGLSL``: bool option with get, set

    /// @babylonjs/core/Layers/thinSelectionOutlineLayer
    [<AllowNullLiteral>]
    type IThinSelectionOutlineLayerOptions =
        inherit IThinEffectLayerOptions
        abstract ``forceGLSL``: bool option with get, set
        abstract ``storeCameraSpaceZ``: bool option with get, set
        abstract ``outlineMethod``: float option with get, set
        abstract ``useDepthOcclusion``: bool option with get, set

    /// Exact required-property projection used by Required<IThinSelectionOutlineLayerOptions> signatures.
    [<AllowNullLiteral>]
    type RequiredIThinSelectionOutlineLayerOptions =
        inherit RequiredIThinEffectLayerOptions
        abstract ``forceGLSL``: bool with get, set
        abstract ``storeCameraSpaceZ``: bool with get, set
        abstract ``outlineMethod``: float with get, set
        abstract ``useDepthOcclusion``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IThinSelectionOutlineLayerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIThinSelectionOutlineLayerOptions =
        inherit PartialIThinEffectLayerOptions
        abstract ``forceGLSL``: bool option with get, set
        abstract ``storeCameraSpaceZ``: bool option with get, set
        abstract ``outlineMethod``: float option with get, set
        abstract ``useDepthOcclusion``: bool option with get, set

    /// @babylonjs/core/XR/webXRRenderTargetTextureProvider
    [<AllowNullLiteral>]
    type IWebXRRenderTargetTextureProvider =
        inherit IDisposable
        abstract ``trySetViewportForView``: ``viewport``: BabylonjsBindings.SimpleClasses.Viewport * ``view``: BrowserXRView -> bool
        abstract ``getRenderTargetTextureForEye``: ``eye``: BrowserXREye -> BabylonjsBindings.SimpleClasses.RenderTargetTexture option
        abstract ``getRenderTargetTextureForView``: ``view``: BrowserXRView -> BabylonjsBindings.SimpleClasses.RenderTargetTexture option

    /// @babylonjs/core/Gizmos/rotationGizmo
    [<AllowNullLiteral>]
    type RotationGizmoOptions =
        abstract ``updateScale``: bool option with get, set
        abstract ``xOptions``: PlaneRotationGizmoOptions option with get, set
        abstract ``yOptions``: PlaneRotationGizmoOptions option with get, set
        abstract ``zOptions``: PlaneRotationGizmoOptions option with get, set
        abstract ``additionalTransformNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set

    /// Function-valued SpringJointData.forceApplicationCallback property.
    [<AllowNullLiteral>]
    type SpringJointDataForceApplicationCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Physics/v1/physicsJoint
    [<AllowNullLiteral>]
    type SpringJointData =
        inherit PhysicsJointData
        abstract ``length``: float with get, set
        abstract ``stiffness``: float with get, set
        abstract ``damping``: float with get, set
        abstract ``forceApplicationCallback``: SpringJointDataForceApplicationCallbackCallback with get, set

    /// @babylonjs/core/PostProcesses/thinCircleOfConfusionPostProcess
    [<AllowNullLiteral>]
    type ThinCircleOfConfusionPostProcessOptions =
        inherit EffectWrapperCreationOptions
        abstract ``depthNotNormalized``: bool option with get, set

    /// @babylonjs/core/PostProcesses/thinImageProcessingPostProcess
    [<AllowNullLiteral>]
    type ThinImageProcessingPostProcessOptions =
        inherit EffectWrapperCreationOptions
        abstract ``imageProcessingConfiguration``: BabylonjsBindings.SimpleClasses.ImageProcessingConfiguration option with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene option with get, set

    /// Exact required non-null projection used by Required<NonNullableFields<ThinImageProcessingPostProcessOptions>> signatures.
    [<AllowNullLiteral>]
    type RequiredNonNullableThinImageProcessingPostProcessOptions =
        inherit RequiredNonNullableEffectWrapperCreationOptions
        abstract ``imageProcessingConfiguration``: BabylonjsBindings.SimpleClasses.ImageProcessingConfiguration with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get, set

    /// @babylonjs/core/PostProcesses/thinTonemapPostProcess
    [<AllowNullLiteral>]
    type ThinTonemapPostProcessOptions =
        inherit EffectWrapperCreationOptions
        abstract ``operator``: BabylonjsBindings.Enums.TonemappingOperator option with get, set
        abstract ``exposureAdjustment``: float option with get, set

    /// @babylonjs/core/Materials/Textures/Procedurals/customProceduralTexture
    [<AllowNullLiteral>]
    type ICustomProceduralTextureCreationOptions =
        inherit IProceduralTextureCreationOptions
        abstract ``skipJson``: bool option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFNode =
        inherit IGLTFChildRootProperty
        abstract ``camera``: string option with get, set
        abstract ``children``: ResizeArray<string> with get, set
        abstract ``skin``: string option with get, set
        abstract ``jointName``: string option with get, set
        abstract ``light``: string option with get, set
        abstract ``matrix``: ResizeArray<float> with get, set
        abstract ``mesh``: string option with get, set
        abstract ``meshes``: ResizeArray<string> option with get, set
        abstract ``rotation``: ResizeArray<float> option with get, set
        abstract ``scale``: ResizeArray<float> option with get, set
        abstract ``translation``: ResizeArray<float> option with get, set
        abstract ``babylonNode``: BabylonjsBindings.SimpleClasses.Node option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFSkins =
        inherit IGLTFChildRootProperty
        abstract ``bindShapeMatrix``: ResizeArray<float> with get, set
        abstract ``inverseBindMatrices``: string with get, set
        abstract ``jointNames``: ResizeArray<string> with get, set
        abstract ``babylonSkeleton``: BabylonjsBindings.SimpleClasses.Skeleton option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTexture =
        inherit IGLTFChildRootProperty
        abstract ``sampler``: string with get, set
        abstract ``source``: string with get, set
        abstract ``format``: BabylonjsBindings.Enums.ETextureFormat option with get, set
        abstract ``internalFormat``: BabylonjsBindings.Enums.ETextureFormat option with get, set
        abstract ``target``: float option with get, set
        abstract ``type``: float option with get, set
        abstract ``babylonTexture``: BabylonjsBindings.SimpleClasses.Texture option with get, set

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderAsyncResult =
        abstract ``meshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> with get
        abstract ``particleSystems``: ResizeArray<IParticleSystem> with get
        abstract ``skeletons``: ResizeArray<BabylonjsBindings.SimpleClasses.Skeleton> with get
        abstract ``animationGroups``: ResizeArray<BabylonjsBindings.SimpleClasses.AnimationGroup> with get
        abstract ``transformNodes``: ResizeArray<BabylonjsBindings.SimpleClasses.TransformNode> with get
        abstract ``geometries``: ResizeArray<BabylonjsBindings.SimpleClasses.Geometry> with get
        abstract ``lights``: ResizeArray<BabylonjsBindings.SimpleClasses.Light> with get
        abstract ``spriteManagers``: ResizeArray<ISpriteManager> with get

    /// Function-valued ISceneLoaderPluginBase.loadFile property.
    [<AllowNullLiteral>]
    type ISceneLoaderPluginBaseLoadFileCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``fileOrUrl``: U3<Browser.Types.File, string, JS.ArrayBufferView> * ``rootUrl``: string * ``onSuccess``: System.Action<obj, string option> * ?``onProgress``: System.Action<ISceneLoaderProgressEvent> * ?``useArrayBuffer``: bool * ?``onError``: System.Action<BabylonjsBindings.SimpleClasses.WebRequest option, BabylonjsBindings.SimpleClasses.LoadFileError option> * ?``name``: string -> IFileRequest option

    /// Function-valued ISceneLoaderPluginBase.directLoad property.
    [<AllowNullLiteral>]
    type ISceneLoaderPluginBaseDirectLoadCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: string -> U2<obj, JS.Promise<obj>>

    /// Function-valued ISceneLoaderPluginBase.rewriteRootURL property.
    [<AllowNullLiteral>]
    type ISceneLoaderPluginBaseRewriteRootURLCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``rootUrl``: string * ?``responseURL``: string -> string

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderPluginBase =
        inherit ISceneLoaderPluginMetadata
        abstract ``loadFile``: ISceneLoaderPluginBaseLoadFileCallback option with get, set
        abstract ``directLoad``: ISceneLoaderPluginBaseDirectLoadCallback option with get, set
        abstract ``rewriteRootURL``: ISceneLoaderPluginBaseRewriteRootURLCallback option with get, set

    /// Distinct ambient URL handle.
    [<AllowNullLiteral>]
    type BrowserURL =
        interface end

    /// Exact structural DOMRect surface.
    [<AllowNullLiteral>]
    type BrowserDOMRect =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract top: float with get
        abstract right: float with get
        abstract bottom: float with get
        abstract left: float with get
        abstract toJSON: unit -> obj

    /// Distinct ambient WebXR reference-space handle.
    [<AllowNullLiteral>]
    type BrowserXRReferenceSpace =
        interface end

    /// Distinct ambient WebXR viewer-pose handle.
    [<AllowNullLiteral>]
    type BrowserXRViewerPose =
        interface end

    /// Distinct ambient WebXR pose handle.
    [<AllowNullLiteral>]
    type BrowserXRPose =
        interface end

    /// Distinct ambient WebXR render-state surface.
    [<AllowNullLiteral>]
    type BrowserXRRenderState =
        interface end

    /// Distinct ambient WebXR render-state initialization surface.
    [<AllowNullLiteral>]
    type BrowserXRRenderStateInit =
        interface end

    /// Yield branch returned by an ECMAScript generator.
    [<AllowNullLiteral>]
    type BrowserGeneratorYieldResult<'T> =
        abstract ``done``: bool option with get
        abstract value: 'T with get

    /// Completion branch returned by an ECMAScript generator.
    [<AllowNullLiteral>]
    type BrowserGeneratorReturnResult<'T> =
        abstract ``done``: bool with get
        abstract value: 'T with get

    /// Exact yield-or-return result of an ECMAScript generator.
    type BrowserGeneratorResult<'TYield, 'TReturn> = U2<BrowserGeneratorYieldResult<'TYield>, BrowserGeneratorReturnResult<'TReturn>>

    /// Exact synchronous ECMAScript Generator surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserGenerator<'TYield, 'TReturn, 'TNext> =
        abstract next: ?value: 'TNext -> BrowserGeneratorResult<'TYield, 'TReturn>
        [<Emit("$0.return($1)")>] abstract ``return``: ?value: 'TReturn -> BrowserGeneratorResult<'TYield, 'TReturn>
        [<Emit("$0.throw($1)")>] abstract ``throw``: ?error: obj -> BrowserGeneratorResult<'TYield, 'TReturn>
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> BrowserGenerator<'TYield, 'TReturn, 'TNext>

    /// Exact numeric literal type for 2.
    type NumericLiteral2 =
        | Value = 2

    /// Distinct ambient WebXR WebGL binding handle.
    [<AllowNullLiteral>]
    type BrowserXRWebGLBinding =
        interface end

    /// Distinct ambient WebXR composition-layer handle.
    [<AllowNullLiteral>]
    type BrowserXRCompositionLayer =
        interface end

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4b84b3d5395bObject =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject245949b83ce1Object =
        abstract ``snapDistance``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject9ab80fcd081aObject =
        abstract ``dragOperation``: BabylonjsBindings.Enums.DragOperation with get, set
        abstract ``dragAxis``: BabylonjsBindings.SimpleClasses.Vector3 with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject6e6d35dea1b5Object =
        abstract ``min``: ResizeArray<float> with get, set
        abstract ``max``: ResizeArray<float> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject9ad978739b38Object =
        [<EmitIndexer>] abstract Item: ``level``: string -> ISOGLODEntry with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject862077224ac2Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFAccessor with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb6647b73c7f8Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFBuffer with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject40618ad8ca72Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFBufferView with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject0bb13ccf05ecObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFMesh with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject2bee361904bfObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFLight with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject3525fe6d6b69Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFCamera with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject01ef8d54ded6Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFNode with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb725329683a2Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFImage with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta218610d748dObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFTexture with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte821f00ccd0dObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFShader with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectdc675e818477Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFProgram with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte0362118f635Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFSampler with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject99a8456868b7Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFTechnique with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject0eef0711bd58Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFMaterial with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject1a9615767bc2Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFAnimation with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject2f5deeb4c362Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFSkins with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectf564079fa502Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFScene with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb45d04c56032Object =
        [<EmitIndexer>] abstract Item: ``name``: string -> JS.ArrayBufferView with get, set

    /// @babylonjs/core/Gizmos/gizmo
    [<AllowNullLiteral>]
    type GizmoAxisCache =
        abstract ``gizmoMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.Mesh> with get, set
        abstract ``colliderMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.Mesh> with get, set
        abstract ``material``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``hoverMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``disableMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``active``: bool with get, set
        abstract ``dragBehavior``: BabylonjsBindings.SimpleClasses.PointerDragBehavior with get, set

    /// @babylonjs/core/Rendering/fluidRenderer/fluidRenderer.pure
    [<AllowNullLiteral>]
    type IFluidRenderingRenderObject =
        abstract ``object``: BabylonjsBindings.SimpleClasses.FluidRenderingObject with get, set
        abstract ``targetRenderer``: BabylonjsBindings.SimpleClasses.FluidRenderingTargetRenderer with get, set

    /// @babylonjs/core/Layers/thinHighlightLayer
    [<AllowNullLiteral>]
    type IHighlightLayerExcludedMesh =
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.Mesh with get, set
        abstract ``beforeBind``: BabylonjsBindings.SimpleClasses.Observer<BabylonjsBindings.SimpleClasses.Mesh> option with get, set
        abstract ``afterRender``: BabylonjsBindings.SimpleClasses.Observer<BabylonjsBindings.SimpleClasses.Mesh> option with get, set
        abstract ``stencilState``: bool with get, set

    /// @babylonjs/core/Layers/thinHighlightLayer
    [<AllowNullLiteral>]
    type IHighlightLayerMesh =
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.Mesh with get, set
        abstract ``color``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``observerHighlight``: BabylonjsBindings.SimpleClasses.Observer<BabylonjsBindings.SimpleClasses.Mesh> option with get, set
        abstract ``observerDefault``: BabylonjsBindings.SimpleClasses.Observer<BabylonjsBindings.SimpleClasses.Mesh> option with get, set
        abstract ``glowEmissiveOnly``: bool with get, set

    /// @babylonjs/core/Rendering/IBLShadows/iblShadowsRenderPipeline.pure
    [<AllowNullLiteral>]
    type IIblShadowsSettings =
        abstract ``resolutionExp``: float option with get, set
        abstract ``sampleDirections``: float option with get, set
        abstract ``shadowOpacity``: float option with get, set
        abstract ``envRotation``: float option with get, set
        abstract ``shadowRemanence``: float option with get, set
        abstract ``triPlanarVoxelization``: bool option with get, set
        abstract ``shadowRenderSizeFactor``: float option with get, set
        abstract ``voxelShadowOpacity``: float option with get, set
        abstract ``ssShadowsEnabled``: bool option with get, set
        abstract ``ssShadowSampleCount``: float option with get, set
        abstract ``ssShadowStride``: float option with get, set
        abstract ``ssShadowDistanceScale``: float option with get, set
        abstract ``ssShadowThicknessScale``: float option with get, set

    /// Exact optional-property projection used by Babylon Partial<IIblShadowsSettings> signatures.
    [<AllowNullLiteral>]
    type PartialIIblShadowsSettings =
        abstract ``resolutionExp``: float option with get, set
        abstract ``sampleDirections``: float option with get, set
        abstract ``shadowOpacity``: float option with get, set
        abstract ``envRotation``: float option with get, set
        abstract ``shadowRemanence``: float option with get, set
        abstract ``triPlanarVoxelization``: bool option with get, set
        abstract ``shadowRenderSizeFactor``: float option with get, set
        abstract ``voxelShadowOpacity``: float option with get, set
        abstract ``ssShadowsEnabled``: bool option with get, set
        abstract ``ssShadowSampleCount``: float option with get, set
        abstract ``ssShadowStride``: float option with get, set
        abstract ``ssShadowDistanceScale``: float option with get, set
        abstract ``ssShadowThicknessScale``: float option with get, set

    /// @babylonjs/loaders/SPLAT/gaussianSplattingStream
    [<AllowNullLiteral>]
    type ISOGLODEntry =
        abstract ``file``: float with get, set
        abstract ``offset``: float with get, set
        abstract ``count``: float with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type ISogPackInternal =
        abstract ``version``: U2<NumericLiteral1, NumericLiteral2> with get, set
        abstract ``splatCount``: float with get, set
        abstract ``shDegree``: float with get, set
        abstract ``meansTextureL``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set
        abstract ``meansTextureU``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set
        abstract ``scalesTexture``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set
        abstract ``quatsTexture``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set
        abstract ``sh0Texture``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set
        abstract ``shCentroidsTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``shLabelsTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``codebookTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``meansMin``: (float * float * float) with get, set
        abstract ``meansMax``: (float * float * float) with get, set
        abstract ``scalesMin``: (float * float * float) option with get, set
        abstract ``scalesMax``: (float * float * float) option with get, set
        abstract ``sh0Min``: (float * float * float * float) option with get, set
        abstract ``sh0Max``: (float * float * float * float) option with get, set
        abstract ``shnMin``: float option with get, set
        abstract ``shnMax``: float option with get, set
        abstract ``shCoeffCount``: float with get, set
        abstract ``positions``: JS.Float32Array with get, set

    /// @babylonjs/core/Materials/Textures/textureMerger
    [<AllowNullLiteral>]
    type ITextureMergeConfiguration =
        abstract ``red``: BabylonjsBindings.TypeAliases.ChannelInput with get, set
        abstract ``green``: BabylonjsBindings.TypeAliases.ChannelInput option with get, set
        abstract ``blue``: BabylonjsBindings.TypeAliases.ChannelInput option with get, set
        abstract ``alpha``: BabylonjsBindings.TypeAliases.ChannelInput option with get, set
        abstract ``outputSize``: BabylonjsBindings.TypeAliases.TextureSize option with get, set
        abstract ``generateMipMaps``: bool option with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type IUpdateOptions =
        abstract ``flipY``: bool option with get, set
        abstract ``previousVertexCount``: float option with get, set

    /// @babylonjs/core/Misc/virtualJoystick
    [<AllowNullLiteral>]
    type IVirtualJoystickCustomizations =
        abstract ``puckSize``: float with get, set
        abstract ``containerSize``: float with get, set
        abstract ``color``: string with get, set
        abstract ``puckImage``: string option with get, set
        abstract ``containerImage``: string option with get, set
        abstract ``position``: InlineObject4b84b3d5395bObject option with get, set
        abstract ``alwaysVisible``: bool with get, set
        abstract ``limitToContainer``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IVirtualJoystickCustomizations> signatures.
    [<AllowNullLiteral>]
    type PartialIVirtualJoystickCustomizations =
        abstract ``puckSize``: float option with get, set
        abstract ``containerSize``: float option with get, set
        abstract ``color``: string option with get, set
        abstract ``puckImage``: string option with get, set
        abstract ``containerImage``: string option with get, set
        abstract ``position``: InlineObject4b84b3d5395bObject option with get, set
        abstract ``alwaysVisible``: bool option with get, set
        abstract ``limitToContainer``: bool option with get, set

    /// @babylonjs/core/XR/features/WebXRWalkingLocomotion.pure
    [<AllowNullLiteral>]
    type IWebXRWalkingLocomotionOptions =
        abstract ``locomotionTarget``: U2<BabylonjsBindings.SimpleClasses.WebXRCamera, BabylonjsBindings.SimpleClasses.TransformNode> with get, set

    /// @babylonjs/core/Physics/v2/Plugins/havokPlugin
    [<AllowNullLiteral>]
    type PhysicsWorldRegion =
        abstract ``world``: obj with get, set
        abstract ``floatingOrigin``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``gravity``: ResizeArray<float> with get, set

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    [<AllowNullLiteral>]
    type GreasedLineMaterialBuilderOptions =
        inherit GreasedLineMaterialOptions
        abstract ``createAndAssignMaterial``: bool option with get, set
        abstract ``colorDistribution``: BabylonjsBindings.Enums.GreasedLineMeshColorDistribution option with get, set

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineBaseMesh
    [<AllowNullLiteral>]
    type GreasedLineMeshOptions =
        abstract ``points``: BabylonjsBindings.TypeAliases.GreasedLinePoints with get, set
        abstract ``widths``: ResizeArray<float> option with get, set
        abstract ``instance``: BabylonjsBindings.SimpleClasses.GreasedLineBaseMesh option with get, set
        abstract ``colorPointers``: ResizeArray<float> option with get, set
        abstract ``uvs``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``lazy``: bool option with get, set
        abstract ``ribbonOptions``: BabylonjsBindings.TypeAliases.GreasedLineRibbonOptions option with get, set
        abstract ``pointsOptions``: GreasedLinePointsOptions option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type IAudioEngineV2Options =
        inherit ISpatialAudioListenerOptions
        abstract ``parameterRampDuration``: float with get, set
        abstract ``volume``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IAudioEngineV2Options> signatures.
    [<AllowNullLiteral>]
    type PartialIAudioEngineV2Options =
        inherit PartialISpatialAudioListenerOptions
        abstract ``parameterRampDuration``: float option with get, set
        abstract ``volume``: float option with get, set

    /// @babylonjs/core/Physics/physicsPointProximityQuery
    [<AllowNullLiteral>]
    type IPhysicsPointProximityQuery =
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``maxDistance``: float with get, set
        abstract ``collisionFilter``: IRaycastQuery with get, set
        abstract ``shouldHitTriggers``: bool with get, set
        abstract ``ignoreBody``: BabylonjsBindings.SimpleClasses.PhysicsBody option with get, set

    /// @babylonjs/loaders/SPLAT/gaussianSplattingStream
    [<AllowNullLiteral>]
    type ISOGLODNode =
        abstract ``bound``: InlineObject6e6d35dea1b5Object with get, set
        abstract ``children``: ResizeArray<ISOGLODNode> option with get, set
        abstract ``lods``: InlineObject9ad978739b38Object option with get, set
        abstract ``activeLod``: float option with get, set
        abstract ``optimalLod``: float option with get, set
        abstract ``availableLevels``: ResizeArray<float> option with get, set
        abstract ``baseLod``: float option with get, set
        abstract ``targetLevel``: float option with get, set
        abstract ``lodCooldown``: float option with get, set
        abstract ``inFrustum``: bool option with get, set
        abstract ``cullBounds``: BabylonjsBindings.SimpleClasses.BoundingInfo option with get, set
        abstract ``pendingFile``: float option with get, set
        abstract ``activeFile``: float option with get, set

    /// @babylonjs/core/AudioV2/webAudio/subNodes/webAudioBusAndSoundSubGraph
    [<AllowNullLiteral>]
    type IWebAudioBusAndSoundSubGraphOptions =
        inherit ISpatialAudioOptions
        inherit IStereoAudioOptions
        inherit IVolumeAudioOptions

    /// Exact optional-property projection used by Babylon Partial<IWebAudioBusAndSoundSubGraphOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebAudioBusAndSoundSubGraphOptions =
        inherit PartialISpatialAudioOptions
        inherit PartialIStereoAudioOptions
        inherit PartialIVolumeAudioOptions

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsAffectedBodyWithData =
        abstract ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody with get, set
        abstract ``hitData``: PhysicsHitData with get, set

    /// @babylonjs/core/Physics/physicsHelper
    [<AllowNullLiteral>]
    type PhysicsAffectedImpostorWithData =
        abstract ``impostor``: BabylonjsBindings.SimpleClasses.PhysicsImpostor with get, set
        abstract ``hitData``: PhysicsHitData with get, set

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    [<AllowNullLiteral>]
    type GreasedLineMeshBuilderOptions =
        inherit GreasedLineMeshOptions
        abstract ``widthDistribution``: BabylonjsBindings.Enums.GreasedLineMeshWidthDistribution option with get, set

    /// @babylonjs/core/Gizmos/axisDragGizmo
    [<AllowNullLiteral>]
    type IAxisDragGizmo =
        inherit IGizmo
        abstract ``dragBehavior``: BabylonjsBindings.SimpleClasses.PointerDragBehavior with get, set
        abstract ``snapDistance``: float with get, set
        abstract ``onSnapObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject245949b83ce1Object> with get, set
        abstract ``isEnabled``: bool with get, set
        abstract ``coloredMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``hoverMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``disableMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set

    /// @babylonjs/core/Gizmos/axisScaleGizmo
    [<AllowNullLiteral>]
    type IAxisScaleGizmo =
        inherit IGizmo
        abstract ``dragBehavior``: BabylonjsBindings.SimpleClasses.PointerDragBehavior with get, set
        abstract ``snapDistance``: float with get, set
        abstract ``incrementalSnap``: bool with get, set
        abstract ``onSnapObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject245949b83ce1Object> with get, set
        abstract ``uniformScaling``: bool with get, set
        abstract ``sensitivity``: float with get, set
        abstract ``dragScale``: float with get, set
        abstract ``isEnabled``: bool with get, set
        abstract ``coloredMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``hoverMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``disableMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set

    /// Function-valued IBoundingBoxGizmo.includeChildPredicate property.
    [<AllowNullLiteral>]
    type IBoundingBoxGizmoIncludeChildPredicateCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``abstractMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh -> bool

    /// @babylonjs/core/Gizmos/boundingBoxGizmo
    [<AllowNullLiteral>]
    type IBoundingBoxGizmo =
        inherit IGizmo
        abstract ``ignoreChildren``: bool with get, set
        abstract ``includeChildPredicate``: IBoundingBoxGizmoIncludeChildPredicateCallback option with get, set
        abstract ``rotationSphereSize``: float with get, set
        abstract ``scaleBoxSize``: float with get, set
        abstract ``fixedDragMeshScreenSize``: bool with get, set
        abstract ``fixedDragMeshBoundsSize``: bool with get, set
        abstract ``fixedDragMeshScreenSizeDistanceFactor``: float with get, set
        abstract ``isDragging``: bool with get
        abstract ``onDragStartObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject9ab80fcd081aObject> with get, set
        abstract ``onHoverStartObservable``: BabylonjsBindings.SimpleClasses.Observable<unit> with get, set
        abstract ``onHoverEndObservable``: BabylonjsBindings.SimpleClasses.Observable<unit> with get, set
        abstract ``onScaleBoxDragObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject9ab80fcd081aObject> with get, set
        abstract ``onScaleBoxDragEndObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject9ab80fcd081aObject> with get, set
        abstract ``onRotationSphereDragObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject9ab80fcd081aObject> with get, set
        abstract ``onRotationSphereDragEndObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject9ab80fcd081aObject> with get, set
        abstract ``scalePivot``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``axisFactor``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``scaleDragSpeed``: float with get, set
        abstract ``setColor``: ``color``: BabylonjsBindings.SimpleClasses.Color3 -> unit
        abstract ``getScaleBoxes``: unit -> ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh>
        abstract ``updateBoundingBox``: unit -> unit
        abstract ``setEnabledRotationAxis``: ``axis``: string -> unit
        abstract ``setEnabledScaling``: ``enable``: bool * ?``homogeneousScaling``: bool -> unit
        abstract ``enableDragBehavior``: unit -> unit
        abstract ``releaseDrag``: unit -> unit
        abstract ``coloredMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``hoverMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``scalingSnapDistance``: float with get, set
        abstract ``rotationSnapDistance``: float with get, set

    /// @babylonjs/core/Gizmos/cameraGizmo
    [<AllowNullLiteral>]
    type ICameraGizmo =
        inherit IGizmo
        abstract ``onClickedObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.SimpleClasses.Camera> with get, set
        abstract ``displayFrustum``: bool with get, set
        abstract ``camera``: BabylonjsBindings.SimpleClasses.Camera option with get, set
        abstract ``material``: BabylonjsBindings.SimpleClasses.StandardMaterial with get

    /// @babylonjs/core/Layers/glowLayer.pure
    [<AllowNullLiteral>]
    type IGlowLayerOptions =
        inherit IThinGlowLayerOptions
        abstract ``mainTextureSamples``: float option with get, set
        abstract ``generateStencilBuffer``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<IGlowLayerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIGlowLayerOptions =
        inherit PartialIThinGlowLayerOptions
        abstract ``mainTextureSamples``: float option with get, set
        abstract ``generateStencilBuffer``: bool option with get, set

    /// @babylonjs/core/Layers/highlightLayer.pure
    [<AllowNullLiteral>]
    type IHighlightLayerOptions =
        inherit IThinHighlightLayerOptions
        abstract ``generateStencilBuffer``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<IHighlightLayerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIHighlightLayerOptions =
        inherit PartialIThinHighlightLayerOptions
        abstract ``generateStencilBuffer``: bool option with get, set

    /// @babylonjs/core/Gizmos/lightGizmo
    [<AllowNullLiteral>]
    type ILightGizmo =
        inherit IGizmo
        abstract ``onClickedObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.SimpleClasses.Light> with get, set
        abstract ``light``: BabylonjsBindings.SimpleClasses.Light option with get, set
        abstract ``material``: BabylonjsBindings.SimpleClasses.StandardMaterial with get

    /// @babylonjs/core/Navigation/INavigationEngine
    [<AllowNullLiteral>]
    type INavigationEnginePlugin =
        abstract ``name``: string with get, set
        abstract ``createNavMesh``: ``meshes``: ResizeArray<BabylonjsBindings.SimpleClasses.Mesh> * ``parameters``: INavMeshParameters -> unit
        abstract ``createDebugNavMesh``: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.Mesh
        abstract ``getClosestPoint``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``getClosestPointToRef``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``getRandomPointAround``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``maxRadius``: float -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``getRandomPointAroundToRef``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``maxRadius``: float * ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``moveAlong``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``destination``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``moveAlongToRef``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``destination``: BabylonjsBindings.SimpleClasses.Vector3 * ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``computePath``: ``start``: BabylonjsBindings.SimpleClasses.Vector3 * ``end``: BabylonjsBindings.SimpleClasses.Vector3 -> ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>
        abstract ``computePathSmooth``: ``start``: BabylonjsBindings.SimpleClasses.Vector3 * ``end``: BabylonjsBindings.SimpleClasses.Vector3 -> ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>
        abstract ``isSupported``: unit -> bool
        abstract ``createCrowd``: ``maxAgents``: float * ``maxAgentRadius``: float * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> ICrowd
        abstract ``setDefaultQueryExtent``: ``extent``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``getDefaultQueryExtent``: unit -> BabylonjsBindings.SimpleClasses.Vector3
        abstract ``buildFromNavmeshData``: ``data``: JS.Uint8Array -> unit
        abstract ``getNavmeshData``: unit -> JS.Uint8Array
        abstract ``getDefaultQueryExtentToRef``: ``result``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``setTimeStep``: ``newTimeStep``: float -> unit
        abstract ``getTimeStep``: unit -> float
        abstract ``setMaximumSubStepCount``: ``newStepCount``: float -> unit
        abstract ``getMaximumSubStepCount``: unit -> float
        abstract ``addCylinderObstacle``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``radius``: float * ``height``: float -> BabylonjsBindings.TypeAliases.IObstacle option
        abstract ``addBoxObstacle``: ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``extent``: BabylonjsBindings.SimpleClasses.Vector3 * ``angle``: float -> BabylonjsBindings.TypeAliases.IObstacle option
        abstract ``removeObstacle``: ``obstacle``: BabylonjsBindings.TypeAliases.IObstacle -> unit
        abstract ``dispose``: unit -> unit

    /// Function-valued IObjectAccessor.get property.
    [<AllowNullLiteral>]
    type IObjectAccessorGetCallback<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> =
        [<Emit("$0($1...)")>] abstract Invoke: ``target``: 'GLTFTargetType * ?``index``: float * ?``payload``: obj -> 'BabylonValueType option

    /// Function-valued IObjectAccessor.getTarget property.
    [<AllowNullLiteral>]
    type IObjectAccessorGetTargetCallback<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> =
        [<Emit("$0($1...)")>] abstract Invoke: ``target``: 'GLTFTargetType * ?``index``: float * ?``payload``: obj -> 'BabylonTargetType option

    /// Function-valued IObjectAccessor.set property.
    [<AllowNullLiteral>]
    type IObjectAccessorSetCallback<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> =
        [<Emit("$0($1...)")>] abstract Invoke: ``newValue``: 'BabylonValueType * ``target``: 'GLTFTargetType * ?``index``: float * ?``payload``: obj -> unit

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> =
        abstract ``componentsCount``: float option with get, set
        abstract ``type``: string with get, set
        abstract ``get``: IObjectAccessorGetCallback<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> with get, set
        abstract ``getTarget``: IObjectAccessorGetTargetCallback<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> with get, set
        abstract ``isReadOnly``: bool option with get, set
        abstract ``getPropertyName``: ResizeArray<System.Func<'GLTFTargetType, string>> option with get, set
        abstract ``set``: IObjectAccessorSetCallback<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> option with get, set
        abstract ``interpolation``: ResizeArray<IInterpolationPropertyInfo> option with get, set

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    [<AllowNullLiteral>]
    type IPhysicsEnginePluginV2 =
        abstract ``world``: obj with get, set
        abstract ``name``: string with get, set
        abstract ``onCollisionObservable``: BabylonjsBindings.SimpleClasses.Observable<IPhysicsCollisionEvent> with get, set
        abstract ``onCollisionEndedObservable``: BabylonjsBindings.SimpleClasses.Observable<IBasePhysicsCollisionEvent> with get, set
        abstract ``onTriggerCollisionObservable``: BabylonjsBindings.SimpleClasses.Observable<IBasePhysicsCollisionEvent> with get, set
        abstract ``setGravity``: ``gravity``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``setTimeStep``: ``timeStep``: float -> unit
        abstract ``getTimeStep``: unit -> float
        abstract ``executeStep``: ``delta``: float * ``bodies``: ResizeArray<BabylonjsBindings.SimpleClasses.PhysicsBody> -> unit
        abstract ``getPluginVersion``: unit -> float
        abstract ``setVelocityLimits``: ``maxLinearVelocity``: float * ``maxAngularVelocity``: float -> unit
        abstract ``getMaxLinearVelocity``: unit -> float
        abstract ``getMaxAngularVelocity``: unit -> float
        abstract ``initBody``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``motionType``: BabylonjsBindings.Enums.PhysicsMotionType * ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``orientation``: BabylonjsBindings.SimpleClasses.Quaternion -> unit
        abstract ``initBodyInstances``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``motionType``: BabylonjsBindings.Enums.PhysicsMotionType * ``mesh``: BabylonjsBindings.SimpleClasses.Mesh -> unit
        abstract ``updateBodyInstances``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``mesh``: BabylonjsBindings.SimpleClasses.Mesh -> unit
        abstract ``removeBody``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody -> unit
        abstract ``sync``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody -> unit
        abstract ``syncTransform``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``transformNode``: BabylonjsBindings.SimpleClasses.TransformNode -> unit
        abstract ``setShape``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape option -> unit
        abstract ``getShape``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody -> BabylonjsBindings.SimpleClasses.PhysicsShape option
        abstract ``getShapeType``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape -> BabylonjsBindings.Enums.PhysicsShapeType
        abstract ``setEventMask``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``eventMask``: float * ?``instanceIndex``: float -> unit
        abstract ``getEventMask``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> float
        abstract ``setMotionType``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``motionType``: BabylonjsBindings.Enums.PhysicsMotionType * ?``instanceIndex``: float -> unit
        abstract ``getMotionType``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> BabylonjsBindings.Enums.PhysicsMotionType
        abstract ``computeMassProperties``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> PhysicsMassProperties
        abstract ``setMassProperties``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``massProps``: PhysicsMassProperties * ?``instanceIndex``: float -> unit
        abstract ``getMassProperties``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> PhysicsMassProperties
        abstract ``setLinearDamping``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``damping``: float * ?``instanceIndex``: float -> unit
        abstract ``getLinearDamping``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> float
        abstract ``setAngularDamping``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``damping``: float * ?``instanceIndex``: float -> unit
        abstract ``getAngularDamping``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> float
        abstract ``setLinearVelocity``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``linVel``: BabylonjsBindings.SimpleClasses.Vector3 * ?``instanceIndex``: float -> unit
        abstract ``getLinearVelocityToRef``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``linVel``: BabylonjsBindings.SimpleClasses.Vector3 * ?``instanceIndex``: float -> unit
        abstract ``applyImpulse``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``impulse``: BabylonjsBindings.SimpleClasses.Vector3 * ``location``: BabylonjsBindings.SimpleClasses.Vector3 * ?``instanceIndex``: float -> unit
        abstract ``applyAngularImpulse``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``angularImpulse``: BabylonjsBindings.SimpleClasses.Vector3 * ?``instanceIndex``: float -> unit
        abstract ``applyForce``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``force``: BabylonjsBindings.SimpleClasses.Vector3 * ``location``: BabylonjsBindings.SimpleClasses.Vector3 * ?``instanceIndex``: float -> unit
        abstract ``applyTorque``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``torque``: BabylonjsBindings.SimpleClasses.Vector3 * ?``instanceIndex``: float -> unit
        abstract ``setAngularVelocity``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``angVel``: BabylonjsBindings.SimpleClasses.Vector3 * ?``instanceIndex``: float -> unit
        abstract ``getAngularVelocityToRef``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``angVel``: BabylonjsBindings.SimpleClasses.Vector3 * ?``instanceIndex``: float -> unit
        abstract ``getBodyGeometry``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody -> JavaScriptObject
        abstract ``disposeBody``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody -> unit
        abstract ``setCollisionCallbackEnabled``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``enabled``: bool * ?``instanceIndex``: float -> unit
        abstract ``setCollisionEndedCallbackEnabled``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``enabled``: bool * ?``instanceIndex``: float -> unit
        abstract ``addConstraint``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``childBody``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ?``instanceIndex``: float * ?``childInstanceIndex``: float -> unit
        abstract ``getCollisionObservable``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> BabylonjsBindings.SimpleClasses.Observable<IPhysicsCollisionEvent>
        abstract ``getCollisionEndedObservable``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> BabylonjsBindings.SimpleClasses.Observable<IBasePhysicsCollisionEvent>
        abstract ``setGravityFactor``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``factor``: float * ?``instanceIndex``: float -> unit
        abstract ``getGravityFactor``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ?``instanceIndex``: float -> float
        abstract ``setTargetTransform``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``position``: BabylonjsBindings.SimpleClasses.Vector3 * ``rotation``: BabylonjsBindings.SimpleClasses.Quaternion * ?``instanceIndex``: float -> unit
        abstract ``initShape``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape * ``type``: BabylonjsBindings.Enums.PhysicsShapeType * ``options``: PhysicsShapeParameters -> unit
        abstract ``setShapeFilterMembershipMask``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape * ``membershipMask``: float -> unit
        abstract ``getShapeFilterMembershipMask``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape -> float
        abstract ``setShapeFilterCollideMask``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape * ``collideMask``: float -> unit
        abstract ``getShapeFilterCollideMask``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape -> float
        abstract ``setMaterial``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape * ``material``: PhysicsMaterial -> unit
        abstract ``getMaterial``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape -> PhysicsMaterial
        abstract ``setDensity``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape * ``density``: float -> unit
        abstract ``getDensity``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape -> float
        abstract ``addChild``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape * ``newChild``: BabylonjsBindings.SimpleClasses.PhysicsShape * ?``translation``: BabylonjsBindings.SimpleClasses.Vector3 * ?``rotation``: BabylonjsBindings.SimpleClasses.Quaternion * ?``scale``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``removeChild``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape * ``childIndex``: float -> unit
        abstract ``getNumChildren``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape -> float
        abstract ``getBoundingBox``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape -> BabylonjsBindings.SimpleClasses.BoundingBox
        abstract ``getBodyBoundingBox``: ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody -> BabylonjsBindings.SimpleClasses.BoundingBox
        abstract ``disposeShape``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape -> unit
        abstract ``setTrigger``: ``shape``: BabylonjsBindings.SimpleClasses.PhysicsShape * ``isTrigger``: bool -> unit
        abstract ``initConstraint``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``body``: BabylonjsBindings.SimpleClasses.PhysicsBody * ``childBody``: BabylonjsBindings.SimpleClasses.PhysicsBody -> unit
        abstract ``setEnabled``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``isEnabled``: bool -> unit
        abstract ``getEnabled``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint -> bool
        abstract ``setCollisionsEnabled``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``isEnabled``: bool -> unit
        abstract ``getCollisionsEnabled``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint -> bool
        abstract ``setAxisFriction``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis * ``friction``: float -> unit
        abstract ``getAxisFriction``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis -> float option
        abstract ``setAxisMode``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis * ``limitMode``: BabylonjsBindings.Enums.PhysicsConstraintAxisLimitMode -> unit
        abstract ``getAxisMode``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis -> BabylonjsBindings.Enums.PhysicsConstraintAxisLimitMode option
        abstract ``setAxisMinLimit``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis * ``minLimit``: float -> unit
        abstract ``getAxisMinLimit``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis -> float option
        abstract ``setAxisMaxLimit``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis * ``limit``: float -> unit
        abstract ``getAxisMaxLimit``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis -> float option
        abstract ``setAxisMotorType``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis * ``motorType``: BabylonjsBindings.Enums.PhysicsConstraintMotorType -> unit
        abstract ``getAxisMotorType``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis -> BabylonjsBindings.Enums.PhysicsConstraintMotorType option
        abstract ``setAxisMotorTarget``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis * ``target``: float -> unit
        abstract ``getAxisMotorTarget``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis -> float option
        abstract ``setAxisMotorMaxForce``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis * ``maxForce``: float -> unit
        abstract ``getAxisMotorMaxForce``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint * ``axis``: BabylonjsBindings.Enums.PhysicsConstraintAxis -> float option
        abstract ``disposeConstraint``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint -> unit
        abstract ``getBodiesUsingConstraint``: ``constraint``: BabylonjsBindings.SimpleClasses.PhysicsConstraint -> ResizeArray<BabylonjsBindings.TypeAliases.ConstrainedBodyPair>
        abstract ``raycast``: ``from``: BabylonjsBindings.SimpleClasses.Vector3 * ``to``: BabylonjsBindings.SimpleClasses.Vector3 * ``result``: U2<BabylonjsBindings.SimpleClasses.PhysicsRaycastResult, ResizeArray<BabylonjsBindings.SimpleClasses.PhysicsRaycastResult>> * ?``query``: IRaycastQuery -> unit
        abstract ``dispose``: unit -> unit

    /// @babylonjs/core/Gizmos/planeDragGizmo
    [<AllowNullLiteral>]
    type IPlaneDragGizmo =
        inherit IGizmo
        abstract ``dragBehavior``: BabylonjsBindings.SimpleClasses.PointerDragBehavior with get, set
        abstract ``snapDistance``: float with get, set
        abstract ``onSnapObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject245949b83ce1Object> with get, set
        abstract ``isEnabled``: bool with get, set
        abstract ``coloredMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``hoverMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``disableMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set

    /// @babylonjs/core/Gizmos/planeRotationGizmo.pure
    [<AllowNullLiteral>]
    type IPlaneRotationGizmo =
        inherit IGizmo
        abstract ``dragBehavior``: BabylonjsBindings.SimpleClasses.PointerDragBehavior with get, set
        abstract ``snapDistance``: float with get, set
        abstract ``sensitivity``: float with get, set
        abstract ``onSnapObservable``: BabylonjsBindings.SimpleClasses.Observable<InlineObject245949b83ce1Object> with get, set
        abstract ``angle``: float with get, set
        abstract ``isEnabled``: bool with get, set
        abstract ``coloredMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``hoverMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``rotationColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``disableMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set

    /// @babylonjs/core/Decorators/nodeDecorator
    [<AllowNullLiteral>]
    type IPropertyDescriptionForEdition =
        abstract ``propertyName``: string with get, set
        abstract ``displayName``: string with get, set
        abstract ``type``: BabylonjsBindings.Enums.PropertyTypeForEdition with get, set
        abstract ``groupName``: string with get, set
        abstract ``options``: IEditablePropertyOption with get, set
        abstract ``className``: string with get, set

    /// @babylonjs/core/Layers/selectionOutlineLayer.pure
    [<AllowNullLiteral>]
    type ISelectionOutlineLayerOptions =
        inherit IThinSelectionOutlineLayerOptions
        abstract ``mainTextureSamples``: float option with get, set

    /// Exact optional-property projection used by Babylon Partial<ISelectionOutlineLayerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialISelectionOutlineLayerOptions =
        inherit PartialIThinSelectionOutlineLayerOptions
        abstract ``mainTextureSamples``: float option with get, set

    /// @babylonjs/loaders/SPLAT/gaussianSplattingStream
    [<AllowNullLiteral>]
    type ISOGLODMetadata =
        abstract ``lodLevels``: float with get, set
        abstract ``filenames``: ResizeArray<string> with get, set
        abstract ``environment``: string option with get, set
        abstract ``tree``: ISOGLODNode with get, set

    /// @babylonjs/core/AudioV2/webAudio/webAudioEngine
    [<AllowNullLiteral>]
    type IWebAudioEngineOptions =
        inherit IAudioEngineV2Options
        abstract ``audioContext``: BrowserAudioContext with get, set
        abstract ``defaultUIParentElement``: Browser.Types.HTMLElement option with get, set
        abstract ``disableDefaultUI``: bool option with get, set
        abstract ``resumeOnInteraction``: bool with get, set
        abstract ``resumeOnPause``: bool with get, set
        abstract ``resumeOnPauseRetryInterval``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IWebAudioEngineOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebAudioEngineOptions =
        inherit PartialIAudioEngineV2Options
        abstract ``audioContext``: BrowserAudioContext option with get, set
        abstract ``defaultUIParentElement``: Browser.Types.HTMLElement option with get, set
        abstract ``disableDefaultUI``: bool option with get, set
        abstract ``resumeOnInteraction``: bool option with get, set
        abstract ``resumeOnPause``: bool option with get, set
        abstract ``resumeOnPauseRetryInterval``: float option with get, set

    /// Function-valued IGLTFLoader.importMeshAsync property.
    [<AllowNullLiteral>]
    type IGLTFLoaderImportMeshAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``meshesNames``: U2<string, System.Collections.Generic.IReadOnlyList<string>> option * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``container``: BabylonjsBindings.SimpleClasses.AssetContainer option * ``data``: IGLTFLoaderData * ``rootUrl``: string * ?``onProgress``: System.Action<ISceneLoaderProgressEvent> * ?``fileName``: string -> JS.Promise<ISceneLoaderAsyncResult>

    /// Function-valued IGLTFLoader.loadAsync property.
    [<AllowNullLiteral>]
    type IGLTFLoaderLoadAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: IGLTFLoaderData * ``rootUrl``: string * ?``onProgress``: System.Action<ISceneLoaderProgressEvent> * ?``fileName``: string -> JS.Promise<unit>

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    [<AllowNullLiteral>]
    type IGLTFLoader =
        inherit IDisposable
        abstract ``importMeshAsync``: IGLTFLoaderImportMeshAsyncCallback with get, set
        abstract ``loadAsync``: IGLTFLoaderLoadAsyncCallback with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFRuntime =
        abstract ``extensions``: InlineObjecta21bf015c053Object with get, set
        abstract ``accessors``: InlineObject862077224ac2Object with get, set
        abstract ``buffers``: InlineObjectb6647b73c7f8Object with get, set
        abstract ``bufferViews``: InlineObject40618ad8ca72Object with get, set
        abstract ``meshes``: InlineObject0bb13ccf05ecObject with get, set
        abstract ``lights``: InlineObject2bee361904bfObject with get, set
        abstract ``cameras``: InlineObject3525fe6d6b69Object with get, set
        abstract ``nodes``: InlineObject01ef8d54ded6Object with get, set
        abstract ``images``: InlineObjectb725329683a2Object with get, set
        abstract ``textures``: InlineObjecta218610d748dObject with get, set
        abstract ``shaders``: InlineObjecte821f00ccd0dObject with get, set
        abstract ``programs``: InlineObjectdc675e818477Object with get, set
        abstract ``samplers``: InlineObjecte0362118f635Object with get, set
        abstract ``techniques``: InlineObject99a8456868b7Object with get, set
        abstract ``materials``: InlineObject0eef0711bd58Object with get, set
        abstract ``animations``: InlineObject1a9615767bc2Object with get, set
        abstract ``skins``: InlineObject2f5deeb4c362Object with get, set
        abstract ``currentScene``: JavaScriptObject option with get, set
        abstract ``scenes``: InlineObjectf564079fa502Object with get, set
        abstract ``extensionsUsed``: ResizeArray<string> with get, set
        abstract ``extensionsRequired``: ResizeArray<string> option with get, set
        abstract ``buffersCount``: float with get, set
        abstract ``shaderscount``: float with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get, set
        abstract ``rootUrl``: string with get, set
        abstract ``loadedBufferCount``: float with get, set
        abstract ``loadedBufferViews``: InlineObjectb45d04c56032Object with get, set
        abstract ``loadedShaderCount``: float with get, set
        abstract ``importOnlyMeshes``: bool with get, set
        abstract ``importMeshesNames``: ResizeArray<string> option with get, set
        abstract ``dummyNodes``: ResizeArray<BabylonjsBindings.SimpleClasses.Node> with get, set
        abstract ``assetContainer``: BabylonjsBindings.SimpleClasses.AssetContainer option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IJointNode =
        abstract ``node``: IGLTFNode with get, set
        abstract ``id``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type INodeToRoot =
        abstract ``bone``: BabylonjsBindings.SimpleClasses.Bone with get, set
        abstract ``node``: IGLTFNode with get, set
        abstract ``id``: string with get, set

    /// @babylonjs/core/Physics/IPhysicsEngine
    [<AllowNullLiteral>]
    type IPhysicsEngine =
        abstract ``gravity``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``getPluginVersion``: unit -> float
        abstract ``setGravity``: ``gravity``: BabylonjsBindings.SimpleClasses.Vector3 -> unit
        abstract ``setTimeStep``: ``newTimeStep``: float -> unit
        abstract ``getTimeStep``: unit -> float
        abstract ``setSubTimeStep``: ``subTimeStep``: float -> unit
        abstract ``getSubTimeStep``: unit -> float
        abstract ``dispose``: unit -> unit
        abstract ``getPhysicsPluginName``: unit -> string
        abstract ``getPhysicsPlugin``: unit -> U2<IPhysicsEnginePlugin, IPhysicsEnginePluginV2> option
        abstract ``raycast``: ``from``: BabylonjsBindings.SimpleClasses.Vector3 * ``to``: BabylonjsBindings.SimpleClasses.Vector3 * ?``query``: IRaycastQuery -> BabylonjsBindings.SimpleClasses.PhysicsRaycastResult
        abstract ``_step``: ``delta``: float -> unit

    /// @babylonjs/core/Gizmos/positionGizmo
    [<AllowNullLiteral>]
    type IPositionGizmo =
        inherit IGizmo
        abstract ``xGizmo``: IAxisDragGizmo with get, set
        abstract ``yGizmo``: IAxisDragGizmo with get, set
        abstract ``zGizmo``: IAxisDragGizmo with get, set
        abstract ``xPlaneGizmo``: IPlaneDragGizmo with get, set
        abstract ``yPlaneGizmo``: IPlaneDragGizmo with get, set
        abstract ``zPlaneGizmo``: IPlaneDragGizmo with get, set
        abstract ``isDragging``: bool with get
        abstract ``onDragStartObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragStartEndEvent> with get, set
        abstract ``onDragObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragEvent> with get, set
        abstract ``onDragEndObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragStartEndEvent> with get, set
        abstract ``planarGizmoEnabled``: bool with get, set
        abstract ``snapDistance``: float with get, set
        abstract ``addToAxisCache``: ``mesh``: BabylonjsBindings.SimpleClasses.Mesh * ``cache``: GizmoAxisCache -> unit
        abstract ``releaseDrag``: unit -> unit

    /// @babylonjs/core/Gizmos/rotationGizmo
    [<AllowNullLiteral>]
    type IRotationGizmo =
        inherit IGizmo
        abstract ``isDragging``: bool with get
        abstract ``xGizmo``: IPlaneRotationGizmo with get, set
        abstract ``yGizmo``: IPlaneRotationGizmo with get, set
        abstract ``zGizmo``: IPlaneRotationGizmo with get, set
        abstract ``onDragStartObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragStartEndEvent> with get, set
        abstract ``onDragObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragEvent> with get, set
        abstract ``onDragEndObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragStartEndEvent> with get, set
        abstract ``snapDistance``: float with get, set
        abstract ``sensitivity``: float with get, set
        abstract ``addToAxisCache``: ``mesh``: BabylonjsBindings.SimpleClasses.Mesh * ``cache``: GizmoAxisCache -> unit
        abstract ``releaseDrag``: unit -> unit

    /// @babylonjs/core/Gizmos/scaleGizmo
    [<AllowNullLiteral>]
    type IScaleGizmo =
        inherit IGizmo
        abstract ``isDragging``: bool with get
        abstract ``xGizmo``: IAxisScaleGizmo with get, set
        abstract ``yGizmo``: IAxisScaleGizmo with get, set
        abstract ``zGizmo``: IAxisScaleGizmo with get, set
        abstract ``uniformScaleGizmo``: IAxisScaleGizmo with get, set
        abstract ``onDragStartObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragStartEndEvent> with get, set
        abstract ``onDragObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragEvent> with get, set
        abstract ``onDragEndObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.TypeAliases.DragStartEndEvent> with get, set
        abstract ``snapDistance``: float with get, set
        abstract ``incrementalSnap``: bool with get, set
        abstract ``sensitivity``: float with get, set
        abstract ``addToAxisCache``: ``mesh``: BabylonjsBindings.SimpleClasses.Mesh * ``cache``: GizmoAxisCache -> unit
        abstract ``releaseDrag``: unit -> unit
        abstract ``coloredMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``hoverMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set
        abstract ``disableMaterial``: BabylonjsBindings.SimpleClasses.StandardMaterial with get, set

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderPlugin =
        inherit ISceneLoaderPluginBase
        abstract ``importMesh``: ``meshesNames``: U2<string, System.Collections.Generic.IReadOnlyList<string>> option * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: obj * ``rootUrl``: string * ``meshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> * ``particleSystems``: ResizeArray<IParticleSystem> * ``skeletons``: ResizeArray<BabylonjsBindings.SimpleClasses.Skeleton> * ?``onError``: System.Action<string, obj option> -> bool
        abstract ``load``: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: obj * ``rootUrl``: string * ?``onError``: System.Action<string, obj option> -> bool
        abstract ``loadAssetContainer``: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: obj * ``rootUrl``: string * ?``onError``: System.Action<string, obj option> -> BabylonjsBindings.SimpleClasses.AssetContainer

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderPluginAsync =
        inherit ISceneLoaderPluginBase
        abstract ``importMeshAsync``: ``meshesNames``: U2<string, System.Collections.Generic.IReadOnlyList<string>> option * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: obj * ``rootUrl``: string * ?``onProgress``: System.Action<ISceneLoaderProgressEvent> * ?``fileName``: string -> JS.Promise<ISceneLoaderAsyncResult>
        abstract ``loadAsync``: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: obj * ``rootUrl``: string * ?``onProgress``: System.Action<ISceneLoaderProgressEvent> * ?``fileName``: string -> JS.Promise<unit>
        abstract ``loadAssetContainerAsync``: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: obj * ``rootUrl``: string * ?``onProgress``: System.Action<ISceneLoaderProgressEvent> * ?``fileName``: string -> JS.Promise<BabylonjsBindings.SimpleClasses.AssetContainer>

    /// @babylonjs/core/Sprites/spriteMap.pure
    [<AllowNullLiteral>]
    type ISpriteMap =
        inherit IDisposable
        abstract ``name``: string with get, set
        abstract ``atlasJSON``: ISpriteJSONAtlas with get, set
        abstract ``spriteSheet``: BabylonjsBindings.SimpleClasses.Texture with get, set
        abstract ``options``: ISpriteMapOptions with get, set

    /// Exact structural ECMAScript iterator surface used by readonly sets.
    [<AllowNullLiteral>]
    type BrowserIterator<'T> =
        abstract next: ?value: obj -> JS.IteratorResult<'T>
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> BrowserIterator<'T>

    /// Exact readonly ECMAScript Set surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserReadonlySet<'T> =
        abstract size: float with get
        abstract has: value: 'T -> bool
        abstract forEach: callbackfn: System.Action<'T, 'T, BrowserReadonlySet<'T>> * ?thisArg: obj -> unit
        abstract entries: unit -> BrowserIterator<'T * 'T>
        abstract keys: unit -> BrowserIterator<'T>
        abstract values: unit -> BrowserIterator<'T>
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> BrowserIterator<'T>

    /// Distinct ambient offline Web Audio context handle.
    [<AllowNullLiteral>]
    type BrowserOfflineAudioContext =
        interface end

    /// @babylonjs/core/FlowGraph/flowGraph
    [<AllowNullLiteral>]
    type IFlowGraphParams =
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get, set
        abstract ``coordinator``: BabylonjsBindings.SimpleClasses.FlowGraphCoordinator with get, set
        abstract ``name``: string option with get, set
        abstract ``uniqueId``: string option with get, set

    /// @babylonjs/core/FlowGraph/flowGraphContext
    [<AllowNullLiteral>]
    type IFlowGraphPendingActivation =
        abstract ``block``: BabylonjsBindings.SimpleClasses.FlowGraphExecutionBlock with get
        abstract ``context``: BabylonjsBindings.SimpleClasses.FlowGraphContext with get
        abstract ``signal``: BabylonjsBindings.SimpleClasses.FlowGraphSignalConnection with get

    /// @babylonjs/core/FlowGraph/flowGraphValidator
    [<AllowNullLiteral>]
    type IFlowGraphValidationIssue =
        abstract ``severity``: BabylonjsBindings.Enums.FlowGraphValidationSeverity with get, set
        abstract ``message``: string with get, set
        abstract ``block``: BabylonjsBindings.SimpleClasses.FlowGraphBlock option with get, set
        abstract ``connectionName``: string option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundCloneOptions =
        abstract ``cloneBuffer``: bool with get, set
        abstract ``outBus``: BabylonjsBindings.TypeAliases.PrimaryAudioBus option with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundCloneOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundCloneOptions =
        abstract ``cloneBuffer``: bool option with get, set
        abstract ``outBus``: BabylonjsBindings.TypeAliases.PrimaryAudioBus option with get, set

    /// @babylonjs/core/AudioV2/webAudio/webAudioNode
    [<AllowNullLiteral>]
    type IWebAudioInNode =
        inherit BabylonjsBindings.SimpleClasses.AbstractAudioNode
        abstract ``_inNode``: BrowserAudioNode option with get, set

    /// @babylonjs/core/AudioV2/webAudio/webAudioNode
    [<AllowNullLiteral>]
    type IWebAudioOutNode =
        inherit BabylonjsBindings.SimpleClasses.AbstractAudioNode
        abstract ``_outNode``: BrowserAudioNode option with get, set

    /// @babylonjs/core/AudioV2/webAudio/webAudioNode
    [<AllowNullLiteral>]
    type IWebAudioSubNode =
        inherit BabylonjsBindings.SimpleClasses._AbstractAudioSubNode
        abstract ``node``: BrowserAudioNode with get, set

    /// @babylonjs/core/FlowGraph/flowGraphValidator
    [<AllowNullLiteral>]
    type IFlowGraphValidationResult =
        abstract ``isValid``: bool with get, set
        abstract ``issues``: ResizeArray<IFlowGraphValidationIssue> with get, set
        abstract ``errorCount``: float with get, set
        abstract ``warningCount``: float with get, set
        abstract ``issuesByBlock``: JS.Map<string, ResizeArray<IFlowGraphValidationIssue>> with get, set

    /// @babylonjs/core/AudioV2/webAudio/webAudioNode
    [<AllowNullLiteral>]
    type IWebAudioSuperNode =
        inherit IWebAudioInNode
        inherit IWebAudioOutNode
        abstract ``engine``: BabylonjsBindings.SimpleClasses._WebAudioEngine with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSoundSource
    [<AllowNullLiteral>]
    type ISoundSourceOptions =
        inherit IAbstractAudioOutNodeOptions
        inherit ISpatialAudioOptions
        inherit IStereoAudioOptions
        abstract ``outBus``: BabylonjsBindings.TypeAliases.PrimaryAudioBus option with get, set
        abstract ``outBusAutoDefault``: bool with get, set
        abstract ``mediaStreamSinkEnabled``: bool with get, set
        abstract ``stopMediaStreamTracksOnDispose``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<ISoundSourceOptions> signatures.
    [<AllowNullLiteral>]
    type PartialISoundSourceOptions =
        inherit PartialIAbstractAudioOutNodeOptions
        inherit PartialISpatialAudioOptions
        inherit PartialIStereoAudioOptions
        abstract ``outBus``: BabylonjsBindings.TypeAliases.PrimaryAudioBus option with get, set
        abstract ``outBusAutoDefault``: bool option with get, set
        abstract ``mediaStreamSinkEnabled``: bool option with get, set
        abstract ``stopMediaStreamTracksOnDispose``: bool option with get, set

    /// @babylonjs/core/Gizmos/spatialAudioGizmo
    [<AllowNullLiteral>]
    type ISpatialAudioGizmo =
        inherit IGizmo
        abstract ``onClickedObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.SimpleClasses.AbstractSoundSource> with get, set
        abstract ``soundSource``: BabylonjsBindings.SimpleClasses.AbstractSoundSource option with get, set
        abstract ``material``: BabylonjsBindings.SimpleClasses.StandardMaterial with get

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundOptions =
        inherit IAbstractSoundOptionsBase
        inherit IAbstractSoundPlayOptions
        inherit ISoundSourceOptions

    /// Exact optional-property projection used by Babylon Partial<IAbstractSoundOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractSoundOptions =
        inherit PartialIAbstractSoundOptionsBase
        inherit PartialIAbstractSoundPlayOptions
        inherit PartialISoundSourceOptions

    /// @babylonjs/core/AudioV2/abstractAudio/audioBus
    [<AllowNullLiteral>]
    type IAudioBusOptions =
        inherit IAbstractAudioBusOptions
        inherit ISpatialAudioOptions
        inherit IStereoAudioOptions
        abstract ``outBus``: BabylonjsBindings.TypeAliases.PrimaryAudioBus with get, set

    /// Exact optional-property projection used by Babylon Partial<IAudioBusOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAudioBusOptions =
        inherit PartialIAbstractAudioBusOptions
        inherit PartialISpatialAudioOptions
        inherit PartialIStereoAudioOptions
        abstract ``outBus``: BabylonjsBindings.TypeAliases.PrimaryAudioBus option with get, set

    /// @babylonjs/core/FlowGraph/flowGraphContext
    [<AllowNullLiteral>]
    type IFlowGraphContextConfiguration =
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get
        abstract ``coordinator``: BabylonjsBindings.SimpleClasses.FlowGraphCoordinator with get
        abstract ``sceneEventCoordinator``: BabylonjsBindings.SimpleClasses.FlowGraphSceneEventCoordinator option with get
        abstract ``assetsContext``: IAssetContainer option with get

    /// Function-valued IFlowGraphContextParseOptions.valueParseFunction property.
    [<AllowNullLiteral>]
    type IFlowGraphContextParseOptionsValueParseFunctionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``key``: string * ``serializationObject``: obj * ``assetsContainer``: IAssetContainer * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> obj

    /// @babylonjs/core/FlowGraph/flowGraphContext
    [<AllowNullLiteral>]
    type IFlowGraphContextParseOptions =
        abstract ``valueParseFunction``: IFlowGraphContextParseOptionsValueParseFunctionCallback option with get
        abstract ``graph``: BabylonjsBindings.SimpleClasses.FlowGraph with get

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundOptions =
        inherit IAbstractSoundOptions
        inherit IStaticSoundBufferOptions
        inherit IStaticSoundStoredOptions

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundOptions =
        inherit PartialIAbstractSoundOptions
        inherit PartialIStaticSoundBufferOptions
        inherit PartialIStaticSoundStoredOptions

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSound
    [<AllowNullLiteral>]
    type IStreamingSoundOptions =
        inherit IAbstractSoundOptions
        inherit IStreamingSoundOptionsBase

    /// Exact optional-property projection used by Babylon Partial<IStreamingSoundOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStreamingSoundOptions =
        inherit PartialIAbstractSoundOptions
        inherit PartialIStreamingSoundOptionsBase

    /// Exact WebXR handedness literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRHandedness =
        | [<CompiledName("none")>] None
        | [<CompiledName("left")>] Left
        | [<CompiledName("right")>] Right

    /// Distinct unsigned BigInt typed-array surface missing from the pinned Fable.Core.
    type BrowserBigUint64Array =
        inherit JS.TypedArray<System.Numerics.BigInteger>

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectdf6c375996ebObject =
        abstract ``teleportationFillColor``: string option with get, set
        abstract ``teleportationBorderColor``: string option with get, set
        abstract ``disableAnimation``: bool option with get, set
        abstract ``disableLighting``: bool option with get, set
        abstract ``torusArrowMaterial``: BabylonjsBindings.SimpleClasses.Material option with get, set
        abstract ``teleportationCircleMaterial``: BabylonjsBindings.SimpleClasses.Material option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject494943fe1056Object =
        abstract ``invisible``: bool option with get, set
        abstract ``sourceMesh``: BabylonjsBindings.SimpleClasses.Mesh option with get, set
        abstract ``onHandJointMeshGenerated``: System.Func<BabylonjsBindings.SimpleClasses.InstancedMesh, float, BrowserXRHandedness, BabylonjsBindings.SimpleClasses.AbstractMesh option> option with get, set
        abstract ``keepOriginalVisible``: bool option with get, set
        abstract ``enablePhysics``: bool option with get, set
        abstract ``physicsProps``: InlineObjectcf532358fec2Object option with get, set
        abstract ``scaleFactor``: float option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte8ed28417b64Object =
        abstract ``disableDefaultMeshes``: bool option with get, set
        abstract ``customMeshes``: InlineObject0cd96bc557bdObject option with get, set
        abstract ``meshesUseLeftHandedCoordinates``: bool option with get, set
        abstract ``customRigMappings``: InlineObject16103c7ac4e3Object option with get, set
        abstract ``customColors``: InlineObject3b313932bd42Object option with get, set
        abstract ``disposeOnSessionEnd``: bool option with get, set
        abstract ``disableHandShader``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectcf532358fec2Object =
        abstract ``friction``: float option with get, set
        abstract ``restitution``: float option with get, set
        abstract ``impostorType``: float option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject0cd96bc557bdObject =
        abstract ``right``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set
        abstract ``left``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject16103c7ac4e3Object =
        abstract ``right``: BabylonjsBindings.TypeAliases.XRHandMeshRigMapping with get, set
        abstract ``left``: BabylonjsBindings.TypeAliases.XRHandMeshRigMapping with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject3b313932bd42Object =
        abstract ``base``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``fresnel``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``fingerColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``tipFresnel``: BabylonjsBindings.SimpleClasses.Color3 option with get, set

    /// Function-valued IWebXRControllerPointerSelectionOptions.customSelectionMeshGenerator property.
    [<AllowNullLiteral>]
    type IWebXRControllerPointerSelectionOptionsCustomSelectionMeshGeneratorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> BabylonjsBindings.SimpleClasses.Mesh

    /// Function-valued IWebXRControllerPointerSelectionOptions.customLasterPointerMeshGenerator property.
    [<AllowNullLiteral>]
    type IWebXRControllerPointerSelectionOptionsCustomLasterPointerMeshGeneratorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> BabylonjsBindings.SimpleClasses.AbstractMesh

    /// @babylonjs/core/XR/features/WebXRControllerPointerSelection.pure
    [<AllowNullLiteral>]
    type IWebXRControllerPointerSelectionOptions =
        abstract ``customUtilityLayerScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``disablePointerUpOnTouchOut``: bool with get, set
        abstract ``forceGazeMode``: bool with get, set
        abstract ``gazeModePointerMovedFactor``: float option with get, set
        abstract ``overrideButtonId``: string option with get, set
        abstract ``renderingGroupId``: float option with get, set
        abstract ``timeToSelect``: float option with get, set
        abstract ``useUtilityLayer``: bool option with get, set
        abstract ``gazeCamera``: BabylonjsBindings.SimpleClasses.WebXRCamera option with get, set
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput with get, set
        abstract ``disableScenePointerVectorUpdate``: bool with get, set
        abstract ``enablePointerSelectionOnAllControllers``: bool option with get, set
        abstract ``preferredHandedness``: BrowserXRHandedness option with get, set
        abstract ``disableSwitchOnClick``: bool option with get, set
        abstract ``maxPointerDistance``: float option with get, set
        abstract ``customSelectionMeshGenerator``: IWebXRControllerPointerSelectionOptionsCustomSelectionMeshGeneratorCallback option with get, set
        abstract ``customLasterPointerMeshGenerator``: IWebXRControllerPointerSelectionOptionsCustomLasterPointerMeshGeneratorCallback option with get, set
        abstract ``forceGripIfAvailable``: bool option with get, set
        abstract ``lookAndPickMode``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<IWebXRControllerPointerSelectionOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebXRControllerPointerSelectionOptions =
        abstract ``customUtilityLayerScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``disablePointerUpOnTouchOut``: bool option with get, set
        abstract ``forceGazeMode``: bool option with get, set
        abstract ``gazeModePointerMovedFactor``: float option with get, set
        abstract ``overrideButtonId``: string option with get, set
        abstract ``renderingGroupId``: float option with get, set
        abstract ``timeToSelect``: float option with get, set
        abstract ``useUtilityLayer``: bool option with get, set
        abstract ``gazeCamera``: BabylonjsBindings.SimpleClasses.WebXRCamera option with get, set
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput option with get, set
        abstract ``disableScenePointerVectorUpdate``: bool option with get, set
        abstract ``enablePointerSelectionOnAllControllers``: bool option with get, set
        abstract ``preferredHandedness``: BrowserXRHandedness option with get, set
        abstract ``disableSwitchOnClick``: bool option with get, set
        abstract ``maxPointerDistance``: float option with get, set
        abstract ``customSelectionMeshGenerator``: IWebXRControllerPointerSelectionOptionsCustomSelectionMeshGeneratorCallback option with get, set
        abstract ``customLasterPointerMeshGenerator``: IWebXRControllerPointerSelectionOptionsCustomLasterPointerMeshGeneratorCallback option with get, set
        abstract ``forceGripIfAvailable``: bool option with get, set
        abstract ``lookAndPickMode``: bool option with get, set

    /// @babylonjs/core/XR/features/WebXRHandTracking.pure
    [<AllowNullLiteral>]
    type IWebXRHandTrackingOptions =
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput with get, set
        abstract ``jointMeshes``: InlineObject494943fe1056Object option with get, set
        abstract ``handMeshes``: InlineObjecte8ed28417b64Object option with get, set

    /// Exact optional-property projection used by Babylon Partial<IWebXRHandTrackingOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebXRHandTrackingOptions =
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput option with get, set
        abstract ``jointMeshes``: InlineObject494943fe1056Object option with get, set
        abstract ``handMeshes``: InlineObjecte8ed28417b64Object option with get, set

    /// @babylonjs/core/XR/features/WebXRNearInteraction.pure
    [<AllowNullLiteral>]
    type IWebXRNearInteractionOptions =
        abstract ``customUtilityLayerScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``useUtilityLayer``: bool option with get, set
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput with get, set
        abstract ``enableNearInteractionOnAllControllers``: bool option with get, set
        abstract ``preferredHandedness``: BrowserXRHandedness option with get, set
        abstract ``disableSwitchOnClick``: bool option with get, set
        abstract ``farInteractionFeature``: BabylonjsBindings.SimpleClasses.WebXRControllerPointerSelection option with get, set
        abstract ``nearInteractionControllerMode``: BabylonjsBindings.Enums.WebXRNearControllerMode option with get, set
        abstract ``motionControllerOrbMaterial``: BabylonjsBindings.SimpleClasses.Material option with get, set
        abstract ``motionControllerTouchMaterialSnippetUrl``: string option with get, set

    /// Exact optional-property projection used by Babylon Partial<IWebXRNearInteractionOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebXRNearInteractionOptions =
        abstract ``customUtilityLayerScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``useUtilityLayer``: bool option with get, set
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput option with get, set
        abstract ``enableNearInteractionOnAllControllers``: bool option with get, set
        abstract ``preferredHandedness``: BrowserXRHandedness option with get, set
        abstract ``disableSwitchOnClick``: bool option with get, set
        abstract ``farInteractionFeature``: BabylonjsBindings.SimpleClasses.WebXRControllerPointerSelection option with get, set
        abstract ``nearInteractionControllerMode``: BabylonjsBindings.Enums.WebXRNearControllerMode option with get, set
        abstract ``motionControllerOrbMaterial``: BabylonjsBindings.SimpleClasses.Material option with get, set
        abstract ``motionControllerTouchMaterialSnippetUrl``: string option with get, set

    /// Function-valued IWebXRTeleportationOptions.blockerMeshesPredicate property.
    [<AllowNullLiteral>]
    type IWebXRTeleportationOptionsBlockerMeshesPredicateCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh -> bool

    /// Function-valued IWebXRTeleportationOptions.generateRayPathMesh property.
    [<AllowNullLiteral>]
    type IWebXRTeleportationOptionsGenerateRayPathMeshCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``points``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> * ``pickingInfo``: BabylonjsBindings.SimpleClasses.PickingInfo -> BabylonjsBindings.SimpleClasses.AbstractMesh

    /// @babylonjs/core/XR/features/WebXRControllerTeleportation.pure
    [<AllowNullLiteral>]
    type IWebXRTeleportationOptions =
        abstract ``customUtilityLayerScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``defaultTargetMeshOptions``: InlineObjectdf6c375996ebObject option with get, set
        abstract ``floorMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> option with get, set
        abstract ``renderingGroupId``: float option with get, set
        abstract ``snapPointsOnly``: bool option with get, set
        abstract ``snapPositions``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> option with get, set
        abstract ``snapToPositionRadius``: float option with get, set
        abstract ``teleportationTargetMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set
        abstract ``timeToTeleport``: float option with get, set
        abstract ``timeToTeleportStart``: float option with get, set
        abstract ``useMainComponentOnly``: bool option with get, set
        abstract ``useUtilityLayer``: bool option with get, set
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput with get, set
        abstract ``pickBlockerMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> option with get, set
        abstract ``blockerMeshesPredicate``: IWebXRTeleportationOptionsBlockerMeshesPredicateCallback option with get, set
        abstract ``blockAllPickableMeshes``: bool option with get, set
        abstract ``blockedRayColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set
        abstract ``forceHandedness``: BrowserXRHandedness option with get, set
        abstract ``generateRayPathMesh``: IWebXRTeleportationOptionsGenerateRayPathMeshCallback option with get, set

    /// Exact optional-property projection used by Babylon Partial<IWebXRTeleportationOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebXRTeleportationOptions =
        abstract ``customUtilityLayerScene``: BabylonjsBindings.SimpleClasses.Scene option with get, set
        abstract ``defaultTargetMeshOptions``: InlineObjectdf6c375996ebObject option with get, set
        abstract ``floorMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> option with get, set
        abstract ``renderingGroupId``: float option with get, set
        abstract ``snapPointsOnly``: bool option with get, set
        abstract ``snapPositions``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> option with get, set
        abstract ``snapToPositionRadius``: float option with get, set
        abstract ``teleportationTargetMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set
        abstract ``timeToTeleport``: float option with get, set
        abstract ``timeToTeleportStart``: float option with get, set
        abstract ``useMainComponentOnly``: bool option with get, set
        abstract ``useUtilityLayer``: bool option with get, set
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput option with get, set
        abstract ``pickBlockerMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> option with get, set
        abstract ``blockerMeshesPredicate``: IWebXRTeleportationOptionsBlockerMeshesPredicateCallback option with get, set
        abstract ``blockAllPickableMeshes``: bool option with get, set
        abstract ``blockedRayColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set
        abstract ``forceHandedness``: BrowserXRHandedness option with get, set
        abstract ``generateRayPathMesh``: IWebXRTeleportationOptionsGenerateRayPathMeshCallback option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureIrradianceInfoV1 =
        abstract ``x``: ResizeArray<float> with get, set
        abstract ``y``: ResizeArray<float> with get, set
        abstract ``z``: ResizeArray<float> with get, set
        abstract ``xx``: ResizeArray<float> with get, set
        abstract ``yy``: ResizeArray<float> with get, set
        abstract ``zz``: ResizeArray<float> with get, set
        abstract ``yz``: ResizeArray<float> with get, set
        abstract ``zx``: ResizeArray<float> with get, set
        abstract ``xy``: ResizeArray<float> with get, set
        abstract ``irradianceTexture``: EnvironmentTextureIrradianceTextureInfoV1 option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureInfoV1 =
        abstract ``version``: NumericLiteral1 with get, set
        abstract ``width``: float with get, set
        abstract ``irradiance``: EnvironmentTextureIrradianceInfoV1 option with get, set
        abstract ``specular``: EnvironmentTextureSpecularInfoV1 with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureInfoV2 =
        abstract ``version``: NumericLiteral2 with get, set
        abstract ``width``: float with get, set
        abstract ``irradiance``: EnvironmentTextureIrradianceInfoV1 option with get, set
        abstract ``specular``: EnvironmentTextureSpecularInfoV1 with get, set
        abstract ``imageType``: string with get, set
        abstract ``binaryDataPosition``: float option with get, set

    /// Exact WebXR projection-layer texture literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRTextureType =
        | [<CompiledName("texture")>] Texture
        | [<CompiledName("texture-array")>] TextureArray

    /// Exact ambient WebXR projection-layer initializer.
    [<AllowNullLiteral>]
    type BrowserXRProjectionLayerInit =
        abstract scaleFactor: float option with get, set
        abstract textureType: BrowserXRTextureType option with get, set
        abstract colorFormat: float option with get, set
        abstract depthFormat: float option with get, set
        abstract clearOnAccess: bool option with get, set

    /// @babylonjs/core/XR/features/WebXRLayers.pure
    [<AllowNullLiteral>]
    type IWebXRLayersOptions =
        abstract ``preferMultiviewOnInit``: bool option with get, set
        abstract ``projectionLayerInit``: BrowserXRProjectionLayerInit option with get, set

    /// Exact Web Audio distance-model literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserDistanceModelType =
        | [<CompiledName("exponential")>] Exponential
        | [<CompiledName("inverse")>] Inverse
        | [<CompiledName("linear")>] Linear

    /// Exact Web Audio panning-model literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserPanningModelType =
        | [<CompiledName("HRTF")>] Hrtf
        | [<CompiledName("equalpower")>] EqualPower

    /// Exact WebXR hit-test trackable literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRHitTestTrackableType =
        | [<CompiledName("point")>] Point
        | [<CompiledName("plane")>] Plane
        | [<CompiledName("mesh")>] Mesh

    /// Exact WebXR reflection-format literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRReflectionFormat =
        | [<CompiledName("srgba8")>] Srgba8
        | [<CompiledName("rgba16f")>] Rgba16f

    /// Distinct ambient WebXR anchor handle.
    [<AllowNullLiteral>]
    type BrowserXRAnchor =
        interface end

    /// Distinct ambient WebXR hit-test result handle.
    [<AllowNullLiteral>]
    type BrowserXRHitTestResult =
        interface end

    /// Distinct ambient legacy WebXR hit result handle.
    [<AllowNullLiteral>]
    type BrowserXRHitResult =
        interface end

    /// Distinct ambient WebXR mesh handle.
    [<AllowNullLiteral>]
    type BrowserXRMesh =
        interface end

    /// Distinct ambient WebXR plane handle.
    [<AllowNullLiteral>]
    type BrowserXRPlane =
        interface end

    /// Distinct ambient WebXR image-tracking result handle.
    [<AllowNullLiteral>]
    type BrowserXRImageTrackingResult =
        interface end

    /// @babylonjs/core/XR/features/WebXRAnchorSystem.pure
    [<AllowNullLiteral>]
    type IWebXRAnchor =
        abstract ``id``: float with get, set
        abstract ``transformationMatrix``: BabylonjsBindings.SimpleClasses.Matrix with get, set
        abstract ``xrAnchor``: BrowserXRAnchor with get, set
        abstract ``attachedNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set
        abstract ``remove``: unit -> unit
        abstract ``_removed``: bool with get, set

    /// @babylonjs/core/XR/features/WebXRHitTestLegacy
    [<AllowNullLiteral>]
    type IWebXRLegacyHitResult =
        abstract ``transformationMatrix``: BabylonjsBindings.SimpleClasses.Matrix with get, set
        abstract ``xrHitResult``: U2<BrowserXRHitResult, BrowserXRHitTestResult> with get, set

    /// @babylonjs/core/XR/features/WebXRLightEstimation.pure
    [<AllowNullLiteral>]
    type IWebXRLightEstimationOptions =
        abstract ``disableCubeMapReflection``: bool option with get, set
        abstract ``setSceneEnvironmentTexture``: bool option with get, set
        abstract ``cubeMapPollInterval``: float option with get, set
        abstract ``lightEstimationPollInterval``: float option with get, set
        abstract ``createDirectionalLightSource``: bool option with get, set
        abstract ``directionalLightIntensityFactor``: float option with get, set
        abstract ``reflectionFormat``: BrowserXRReflectionFormat option with get, set
        abstract ``disableVectorReuse``: bool option with get, set
        abstract ``disableSphericalPolynomial``: bool option with get, set
        abstract ``disablePreFiltering``: bool option with get, set

    /// @babylonjs/core/XR/features/WebXRPlaneDetector.pure
    [<AllowNullLiteral>]
    type IWebXRPlane =
        abstract ``id``: float with get, set
        abstract ``polygonDefinition``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``transformationMatrix``: BabylonjsBindings.SimpleClasses.Matrix with get, set
        abstract ``xrPlane``: BrowserXRPlane with get, set

    /// @babylonjs/core/XR/features/WebXRImageTracking.pure
    [<AllowNullLiteral>]
    type IWebXRTrackedImage =
        abstract ``id``: float with get, set
        abstract ``emulated``: bool option with get, set
        abstract ``originalBitmap``: BrowserImageBitmap with get, set
        abstract ``xrTrackingResult``: BrowserXRImageTrackingResult option with get, set
        abstract ``realWorldWidth``: float option with get, set
        abstract ``transformationMatrix``: BabylonjsBindings.SimpleClasses.Matrix with get, set
        abstract ``ratio``: float option with get, set

    /// @babylonjs/core/XR/features/WebXRMeshDetector.pure
    [<AllowNullLiteral>]
    type IWebXRVertexData =
        abstract ``id``: float with get, set
        abstract ``xrMesh``: BrowserXRMesh with get, set
        abstract ``worldParentNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set
        abstract ``positions``: JS.Float32Array option with get, set
        abstract ``indices``: JS.Uint32Array option with get, set
        abstract ``normals``: JS.Float32Array option with get, set
        abstract ``transformationMatrix``: BabylonjsBindings.SimpleClasses.Matrix option with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.Mesh option with get, set

    /// @babylonjs/core/XR/features/WebXRHitTest.pure
    [<AllowNullLiteral>]
    type IWebXRHitResult =
        inherit IWebXRLegacyHitResult
        abstract ``inputSource``: BrowserXRInputSource option with get, set
        abstract ``isTransient``: bool option with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``rotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion with get, set
        abstract ``xrHitResult``: BrowserXRHitTestResult with get, set

    /// @babylonjs/core/XR/features/WebXRHitTest.pure
    [<AllowNullLiteral>]
    type IWebXRHitTestOptions =
        inherit IWebXRLegacyHitTestOptions
        abstract ``disablePermanentHitTest``: bool option with get, set
        abstract ``enableTransientHitTest``: bool option with get, set
        abstract ``transientHitTestProfile``: string option with get, set
        abstract ``offsetRay``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``transientOffsetRay``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``useReferenceSpace``: bool option with get, set
        abstract ``entityTypes``: ResizeArray<BrowserXRHitTestTrackableType> option with get, set

    /// @babylonjs/core/XR/features/WebXRHitTestLegacy
    [<AllowNullLiteral>]
    type IWebXRHitTestFeature<'T when 'T :> IWebXRLegacyHitResult> =
        inherit IWebXRFeature
        abstract ``onHitTestResultObservable``: BabylonjsBindings.SimpleClasses.Observable<ResizeArray<'T>> with get, set

    /// Distinct ambient DOMPointReadOnly handle.
    [<AllowNullLiteral>]
    type BrowserDOMPointReadOnly =
        interface end

    /// Exact WebXR field-of-view shape used by geometry detection.
    [<AllowNullLiteral>]
    type BrowserXRFieldOfView =
        abstract angleLeft: float with get, set
        abstract angleRight: float with get, set
        abstract angleUp: float with get, set
        abstract angleDown: float with get, set

    /// Exact WebXR frustum shape used by geometry detection.
    [<AllowNullLiteral>]
    type BrowserXRFrustum =
        abstract position: BrowserDOMPointReadOnly with get, set
        abstract orientation: BrowserDOMPointReadOnly with get, set
        abstract fieldOfView: BrowserXRFieldOfView with get, set
        abstract farDistance: float with get, set

    /// Exact WebXR geometry-detection boundary discriminator literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRFrustumBoundaryType =
        | [<CompiledName("frustum")>] Frustum

    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRSphereBoundaryType =
        | [<CompiledName("sphere")>] Sphere

    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRBoxBoundaryType =
        | [<CompiledName("box")>] Box

    /// Exact WebXR frustum detection boundary.
    [<AllowNullLiteral>]
    type BrowserXRFrustumDetectionBoundary =
        abstract ``type``: BrowserXRFrustumBoundaryType with get, set
        abstract frustum: BrowserXRFrustum with get, set

    /// Exact WebXR sphere detection boundary.
    [<AllowNullLiteral>]
    type BrowserXRSphereDetectionBoundary =
        abstract ``type``: BrowserXRSphereBoundaryType with get, set
        abstract radius: float with get, set

    /// Exact WebXR box detection boundary.
    [<AllowNullLiteral>]
    type BrowserXRBoxDetectionBoundary =
        abstract ``type``: BrowserXRBoxBoundaryType with get, set
        abstract extent: BrowserDOMPointReadOnly with get, set

    /// Exact WebXR geometry detection boundary union.
    type BrowserXRDetectionBoundary = U3<BrowserXRFrustumDetectionBoundary, BrowserXRSphereDetectionBoundary, BrowserXRBoxDetectionBoundary>

    /// Exact WebXR geometry-detector options.
    [<AllowNullLiteral>]
    type BrowserXRGeometryDetectorOptions =
        abstract detectionBoundary: BrowserXRDetectionBoundary option with get, set
        abstract updateInterval: float option with get, set

    /// @babylonjs/core/XR/features/WebXRMeshDetector.pure
    [<AllowNullLiteral>]
    type IWebXRMeshDetectorOptions =
        abstract ``worldParentNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set
        abstract ``doNotRemoveMeshesOnSessionEnded``: bool option with get, set
        abstract ``preferredDetectorOptions``: BrowserXRGeometryDetectorOptions option with get, set
        abstract ``convertCoordinateSystems``: bool option with get, set
        abstract ``generateMeshes``: bool option with get, set

    /// @babylonjs/core/XR/features/WebXRPlaneDetector.pure
    [<AllowNullLiteral>]
    type IWebXRPlaneDetectorOptions =
        abstract ``worldParentNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set
        abstract ``doNotRemovePlanesOnSessionEnded``: bool option with get, set
        abstract ``preferredDetectorOptions``: BrowserXRGeometryDetectorOptions option with get, set

    /// Exact readonly ECMAScript Map surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserReadonlyMap<'TKey, 'TValue> =
        abstract size: float with get
        abstract has: key: 'TKey -> bool
        abstract get: key: 'TKey -> 'TValue option
        abstract forEach: callbackfn: System.Action<'TValue, 'TKey, BrowserReadonlyMap<'TKey, 'TValue>> * ?thisArg: obj -> unit
        abstract entries: unit -> BrowserIterator<'TKey * 'TValue>
        abstract keys: unit -> BrowserIterator<'TKey>
        abstract values: unit -> BrowserIterator<'TValue>
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> BrowserIterator<'TKey * 'TValue>

    /// Distinct ambient WebXR projection-layer handle.
    [<AllowNullLiteral>]
    type BrowserXRProjectionLayer =
        interface end

    /// Erased nominal representation of the JavaScript `symbol` primitive.
    [<Erase>]
    type BrowserSymbol =
        | BrowserSymbol of obj

    /// Exact ECMAScript property-key union.
    type BrowserPropertyKey = U3<string, float, BrowserSymbol>

    /// Exact TC39 decorator metadata object.
    [<AllowNullLiteral>]
    type BrowserDecoratorMetadataObject =
        [<EmitIndexer>] abstract Item: key: BrowserPropertyKey -> obj with get, set

    /// Exact serialization-decorator context used by Babylon.
    [<AllowNullLiteral>]
    type BrowserSerializableContext =
        abstract name: U2<string, BrowserSymbol> with get, set
        abstract metadata: BrowserDecoratorMetadataObject option with get, set

    /// Exact structural projection of a TypeScript Record.
    [<AllowNullLiteral>]
    type BrowserRecord<'TKey, 'TValue> =
        [<EmitIndexer>] abstract Item: key: 'TKey -> 'TValue with get, set

    /// Exact ECMAScript iterable surface.
    [<AllowNullLiteral>]
    type BrowserIterable<'T> =
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> BrowserIterator<'T>

    /// Exact constructor surface for Babylon typed-array factories.
    [<AllowNullLiteral>]
    type BrowserTypedArrayConstructor<'T> =
        [<Emit("new $0($1)")>] abstract Create: length: float -> 'T
        [<Emit("new $0($1)")>] abstract Create: elements: BrowserIterable<float> -> 'T
        [<Emit("new $0($1...)")>] abstract Create: buffer: U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer> * ?byteOffset: float * ?length: float -> 'T
        abstract BYTES_PER_ELEMENT: float with get

    /// @babylonjs/core/types — exact exported alias over the reviewed constructor support projection.
    type TypedArrayConstructor<'T> = BrowserTypedArrayConstructor<'T>
    type TypedArrayConstructor = TypedArrayConstructor<BabylonjsBindings.TypeAliases.TypedArray>

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    [<AllowNullLiteral>]
    type IDracoAttributeData =
        abstract ``kind``: string with get, set
        abstract ``dracoName``: BabylonjsBindings.StringEnums.DracoAttributeName with get, set
        abstract ``size``: float with get, set
        abstract ``data``: BabylonjsBindings.TypeAliases.VertexDataTypedArray with get, set

    /// Exact experimental HTML-in-Canvas transferable image surface.
    [<AllowNullLiteral>]
    type BrowserElementImage =
        abstract width: float with get
        abstract height: float with get
        abstract close: unit -> unit

    /// Exact source rectangle and sizing configuration for WebGL element-image copies.
    [<AllowNullLiteral>]
    type BrowserWebGLCopyElementImageConfig =
        abstract sx: float option with get, set
        abstract sy: float option with get, set
        abstract swidth: float option with get, set
        abstract sheight: float option with get, set
        abstract width: float option with get, set
        abstract height: float option with get, set

    /// Distinct ambient WebXR rigid transform handle.
    [<AllowNullLiteral>]
    type BrowserXRRigidTransform =
        interface end

    /// Distinct ambient MediaStreamTrack handle.
    [<AllowNullLiteral>]
    type BrowserMediaStreamTrack =
        interface end

    /// @babylonjs/core/Misc/videoRecorder
    [<AllowNullLiteral>]
    type VideoRecorderOptions =
        abstract ``canvas``: Browser.Types.HTMLCanvasElement option with get, set
        abstract ``mimeType``: string with get, set
        abstract ``fps``: float with get, set
        abstract ``recordChunckSize``: float with get, set
        abstract ``audioTracks``: ResizeArray<BrowserMediaStreamTrack> option with get, set

    /// Exact optional-property projection used by Babylon Partial<VideoRecorderOptions> signatures.
    [<AllowNullLiteral>]
    type PartialVideoRecorderOptions =
        abstract ``canvas``: Browser.Types.HTMLCanvasElement option with get, set
        abstract ``mimeType``: string option with get, set
        abstract ``fps``: float option with get, set
        abstract ``recordChunckSize``: float option with get, set
        abstract ``audioTracks``: ResizeArray<BrowserMediaStreamTrack> option with get, set

    /// @babylonjs/core/ObjectModel/objectModelInterfaces
    [<AllowNullLiteral>]
    type IPathToObjectConverter<'T> =
        abstract ``convert``: ``path``: string -> IObjectInfo<'T, obj>

    /// Exact string literal type for "encodeMeshError".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral56b69f7fdd12 =
        | [<CompiledName("encodeMeshError")>] Value

    /// Exact string literal type for "encodeMeshSuccess".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralfcc89b3f4d1f =
        | [<CompiledName("encodeMeshSuccess")>] Value

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    [<AllowNullLiteral>]
    type IDracoEncodedMeshData =
        abstract ``data``: JS.Int8Array with get, set
        abstract ``attributeIds``: BrowserRecord<string, float> with get, set

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    [<AllowNullLiteral>]
    type IDracoEncoderOptions =
        abstract ``decodeSpeed``: float option with get, set
        abstract ``encodeSpeed``: float option with get, set
        abstract ``method``: BabylonjsBindings.StringEnums.DracoEncoderMethod option with get, set
        abstract ``quantizationBits``: BrowserRecord<BabylonjsBindings.StringEnums.DracoAttributeName, float> option with get, set
        abstract ``excludedAttributes``: ResizeArray<string> option with get, set

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    [<AllowNullLiteral>]
    type IEncodeErrorMessage =
        abstract ``id``: StringLiteral56b69f7fdd12 with get, set
        abstract ``errorMessage``: string with get, set

    /// @babylonjs/core/SmartAssets/smartAssetSerializer
    [<AllowNullLiteral>]
    type ISerializedSmartAssetEntry =
        abstract ``url``: string with get
        abstract ``type``: string option with get
        abstract ``extension``: string option with get
        abstract ``metadata``: BrowserRecord<string, obj> option with get

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    [<AllowNullLiteral>]
    type IEncodeSuccessMessage =
        abstract ``id``: StringLiteralfcc89b3f4d1f with get, set
        abstract ``encodedMeshData``: IDracoEncodedMeshData with get, set

    /// @babylonjs/core/SmartAssets/smartAssetSerializer
    [<AllowNullLiteral>]
    type ISerializedSmartAssetMap =
        abstract ``version``: NumericLiteral1 with get
        abstract ``assets``: BrowserRecord<string, ISerializedSmartAssetEntry> with get

    /// @babylonjs/core/Meshes/Compression/dracoCompression
    [<AllowNullLiteral>]
    type IDracoCompressionOptions =
        abstract ``numWorkers``: float option with get, set
        abstract ``workerPool``: BabylonjsBindings.SimpleClasses.WorkerPool option with get, set
        abstract ``wasmBinary``: JS.ArrayBuffer option with get, set

    /// Function-valued INativeEngine.setRenderResetCallback property.
    [<AllowNullLiteral>]
    type INativeEngineSetRenderResetCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``callback``: System.Action -> unit

    /// Function-valued INativeEngine.setDeviceLostCallback property.
    [<AllowNullLiteral>]
    type INativeEngineSetDeviceLostCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``callback``: System.Action -> unit

    /// Function-valued INativeEngine.updateTextureData property.
    [<AllowNullLiteral>]
    type INativeEngineUpdateTextureDataCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture * ``data``: JS.ArrayBufferView * ``xOffset``: float * ``yOffset``: float * ``width``: float * ``height``: float * ``faceIndex``: float * ``lod``: float * ``invertY``: bool -> unit

    /// Function-valued INativeEngine.getTextureLayerCount property.
    [<AllowNullLiteral>]
    type INativeEngineGetTextureLayerCountCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture -> float

    /// Function-valued INativeEngine.createMultiFrameBuffer property.
    [<AllowNullLiteral>]
    type INativeEngineCreateMultiFrameBufferCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``textures``: ResizeArray<BabylonjsBindings.TypeAliases.NativeTexture> * ``width``: float * ``height``: float * ``generateStencilBuffer``: bool * ``generateDepthBuffer``: bool * ``samples``: float -> BabylonjsBindings.TypeAliases.NativeFramebuffer

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeEngine =
        abstract ``dispose``: unit -> unit
        abstract ``requestAnimationFrame``: ``callback``: System.Action -> unit
        abstract ``setRenderResetCallback``: INativeEngineSetRenderResetCallbackCallback option with get, set
        abstract ``setDeviceLostCallback``: INativeEngineSetDeviceLostCallbackCallback option with get, set
        abstract ``createVertexArray``: unit -> BabylonjsBindings.TypeAliases.NativeData
        abstract ``createIndexBuffer``: ``dataBuffer``: U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer> * ``dataByteOffset``: float * ``dataByteLength``: float * ``is32Bits``: bool * ``dynamic``: bool -> BabylonjsBindings.TypeAliases.NativeData
        abstract ``recordIndexBuffer``: ``vertexArray``: BabylonjsBindings.TypeAliases.NativeData * ``indexBuffer``: BabylonjsBindings.TypeAliases.NativeData -> unit
        abstract ``updateDynamicIndexBuffer``: ``indexBuffer``: BabylonjsBindings.TypeAliases.NativeData * ``data``: U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer> * ``dataByteOffset``: float * ``dataByteLength``: float * ``startIndex``: float -> unit
        abstract ``createVertexBuffer``: ``dataBuffer``: U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer> * ``dataByteOffset``: float * ``dataByteLength``: float * ``dynamic``: bool -> BabylonjsBindings.TypeAliases.NativeData
        abstract ``recordVertexBuffer``: ``vertexArray``: BabylonjsBindings.TypeAliases.NativeData * ``vertexBuffer``: BabylonjsBindings.TypeAliases.NativeData * ``location``: float * ``byteOffset``: float * ``byteStride``: float * ``numElements``: float * ``type``: float * ``normalized``: bool * ``instanceDivisor``: float -> unit
        abstract ``updateDynamicVertexBuffer``: ``vertexBuffer``: BabylonjsBindings.TypeAliases.NativeData * ``dataBuffer``: U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer> * ``dataByteOffset``: float * ``dataByteLength``: float * ?``vertexByteOffset``: float -> unit
        abstract ``createProgram``: ``vertexShader``: string * ``fragmentShader``: string -> BabylonjsBindings.TypeAliases.NativeProgram
        abstract ``createProgramAsync``: ``vertexShader``: string * ``fragmentShader``: string * ``onSuccess``: System.Action * ``onError``: System.Action<System.Exception> -> BabylonjsBindings.TypeAliases.NativeProgram
        abstract ``getUniforms``: ``shaderProgram``: BabylonjsBindings.TypeAliases.NativeProgram * ``uniformsNames``: ResizeArray<string> -> ResizeArray<Browser.Types.WebGLUniformLocation>
        abstract ``getAttributes``: ``shaderProgram``: BabylonjsBindings.TypeAliases.NativeProgram * ``attributeNames``: ResizeArray<string> -> ResizeArray<float>
        abstract ``createTexture``: unit -> BabylonjsBindings.TypeAliases.NativeTexture
        abstract ``initializeTexture``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture * ``width``: float * ``height``: float * ``hasMips``: bool * ``format``: float * ``renderTarget``: bool * ``srgb``: bool * ``samples``: float * ?``isCube``: bool -> unit
        abstract ``loadTexture``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture * ``data``: JS.ArrayBufferView * ``generateMips``: bool * ``invertY``: bool * ``srgb``: bool * ``onSuccess``: System.Action * ``onError``: System.Action -> unit
        abstract ``loadRawTexture``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture * ``data``: JS.ArrayBufferView * ``width``: float * ``height``: float * ``format``: float * ``generateMips``: bool * ``invertY``: bool -> unit
        abstract ``updateTextureData``: INativeEngineUpdateTextureDataCallback option with get, set
        abstract ``loadRawTexture2DArray``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture * ``data``: JS.ArrayBufferView option * ``width``: float * ``height``: float * ``depth``: float * ``format``: float * ``generateMipMaps``: bool * ``invertY``: bool -> unit
        abstract ``loadCubeTexture``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture * ``data``: ResizeArray<JS.ArrayBufferView> * ``generateMips``: bool * ``invertY``: bool * ``srgb``: bool * ``onSuccess``: System.Action * ``onError``: System.Action -> unit
        abstract ``loadCubeTextureWithMips``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture * ``data``: ResizeArray<ResizeArray<JS.ArrayBufferView>> * ``invertY``: bool * ``srgb``: bool * ``onSuccess``: System.Action * ``onError``: System.Action -> unit
        abstract ``getTextureWidth``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture -> float
        abstract ``getTextureHeight``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture -> float
        abstract ``getTextureLayerCount``: INativeEngineGetTextureLayerCountCallback option with get, set
        abstract ``deleteTexture``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture -> unit
        abstract ``readTexture``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture * ``mipLevel``: float * ``x``: float * ``y``: float * ``width``: float * ``height``: float * ``buffer``: JS.ArrayBuffer option * ``bufferOffset``: float * ``bufferLength``: float -> JS.Promise<JS.ArrayBuffer>
        abstract ``createImageBitmap``: ``data``: U2<JS.ArrayBuffer, IImage> -> BrowserImageBitmap
        abstract ``resizeImageBitmap``: ``image``: BrowserImageBitmap * ``bufferWidth``: float * ``bufferHeight``: float -> JS.Uint8Array
        abstract ``createFrameBuffer``: ``texture``: BabylonjsBindings.TypeAliases.NativeTexture option * ``width``: float * ``height``: float * ``generateStencilBuffer``: bool * ``generateDepthBuffer``: bool * ``samples``: float * ?``layer``: float -> BabylonjsBindings.TypeAliases.NativeFramebuffer
        abstract ``createMultiFrameBuffer``: INativeEngineCreateMultiFrameBufferCallback option with get, set
        abstract ``getRenderWidth``: unit -> float
        abstract ``getRenderHeight``: unit -> float
        abstract ``setHardwareScalingLevel``: ``level``: float -> unit
        abstract ``setViewPort``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``setCommandDataStream``: ``dataStream``: BabylonjsBindings.SimpleClasses.NativeDataStream -> unit
        abstract ``submitCommands``: unit -> unit
        abstract ``populateFrameStats``: ``stats``: BabylonjsBindings.ObjectTypes.NativeFrameStats -> unit

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<AllowNullLiteral>]
    type IWebXRBodyTrackingOptions =
        abstract ``bodyMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh option with get, set
        abstract ``rigMapping``: BabylonjsBindings.TypeAliases.XRBodyMeshRigMapping option with get, set
        abstract ``jointScaleFactor``: float option with get, set
        abstract ``preserveBindPoseBonePositions``: bool option with get, set
        abstract ``useBoneOrientationOffsets``: bool option with get, set
        abstract ``jointLocalRotationOffset``: BabylonjsBindings.SimpleClasses.Quaternion option with get, set
        abstract ``aimChildOverrides``: BrowserRecord<BabylonjsBindings.StringEnums.WebXRBodyJoint, BabylonjsBindings.StringEnums.WebXRBodyJoint option> option with get, set
        abstract ``isMixamoModel``: bool option with get, set

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IInspectorOptions =
        abstract ``overlay``: bool option with get, set
        abstract ``globalRoot``: Browser.Types.HTMLElement option with get, set
        abstract ``showExplorer``: bool option with get, set
        abstract ``showInspector``: bool option with get, set
        abstract ``embedMode``: bool option with get, set
        abstract ``handleResize``: bool option with get, set
        abstract ``enablePopup``: bool option with get, set
        abstract ``enableClose``: bool option with get, set
        abstract ``explorerExtensibility``: ResizeArray<IExplorerExtensibilityGroup> option with get, set
        abstract ``additionalNodes``: ResizeArray<IExplorerAdditionalNode> option with get, set
        abstract ``inspectorURL``: string option with get, set
        abstract ``initialTab``: BabylonjsBindings.Enums.DebugLayerTab option with get, set
        abstract ``gizmoCamera``: BabylonjsBindings.SimpleClasses.Camera option with get, set
        abstract ``contextMenu``: BrowserRecord<BabylonjsBindings.StringEnums.IInspectorContextMenuType, ResizeArray<IInspectorContextMenuItem> option> option with get, set
        abstract ``contextMenuOverride``: ResizeArray<BabylonjsBindings.StringEnums.IInspectorContextMenuType> option with get, set
        abstract ``skipDefaultFontLoading``: bool option with get, set

    /// Function-valued IFlowGraphBlockParseOptions.valueParseFunction property.
    [<AllowNullLiteral>]
    type IFlowGraphBlockParseOptionsValueParseFunctionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``key``: string * ``serializationObject``: obj * ``assetsContainer``: IAssetContainer * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> obj

    /// @babylonjs/core/FlowGraph/flowGraphBlock
    [<AllowNullLiteral>]
    type IFlowGraphBlockParseOptions =
        abstract ``valueParseFunction``: IFlowGraphBlockParseOptionsValueParseFunctionCallback option with get, set
        abstract ``assetsContainer``: IAssetContainer option with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get, set
        abstract ``pathConverter``: IPathToObjectConverter<IObjectAccessor<obj, obj, obj>> option with get, set

    /// Function-valued IFlowGraphCoordinatorParseOptions.valueParseFunction property.
    [<AllowNullLiteral>]
    type IFlowGraphCoordinatorParseOptionsValueParseFunctionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``key``: string * ``serializationObject``: obj * ``assetsContainer``: IAssetContainer * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> obj

    /// @babylonjs/core/FlowGraph/flowGraphCoordinator
    [<AllowNullLiteral>]
    type IFlowGraphCoordinatorParseOptions =
        abstract ``valueParseFunction``: IFlowGraphCoordinatorParseOptionsValueParseFunctionCallback option with get, set
        abstract ``pathConverter``: IPathToObjectConverter<IObjectAccessor<obj, obj, obj>> option with get, set
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphJsonPointerParserBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphJsonPointerParserBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``jsonPointer``: string with get, set
        abstract ``pathConverter``: IPathToObjectConverter<IObjectAccessor<obj, obj, obj>> with get, set
        abstract ``outputValue``: bool option with get, set

    /// Function-valued IFlowGraphParseOptions.valueParseFunction property.
    [<AllowNullLiteral>]
    type IFlowGraphParseOptionsValueParseFunctionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``key``: string * ``serializationObject``: obj * ``assetsContainer``: IAssetContainer * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> obj

    /// @babylonjs/core/FlowGraph/flowGraph
    [<AllowNullLiteral>]
    type IFlowGraphParseOptions =
        abstract ``valueParseFunction``: IFlowGraphParseOptionsValueParseFunctionCallback option with get, set
        abstract ``coordinator``: BabylonjsBindings.SimpleClasses.FlowGraphCoordinator with get, set
        abstract ``pathConverter``: IPathToObjectConverter<IObjectAccessor<obj, obj, obj>> option with get, set

    /// Distinct ambient WebGL transform-feedback object handle.
    [<AllowNullLiteral>]
    type BrowserWebGLTransformFeedback =
        interface end

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4583f044ad0cObject =
        [<EmitIndexer>] abstract Item: ``name``: string -> IPipelineContext with get, set

    /// @babylonjs/core/Engines/thinEngine.functions
    [<AllowNullLiteral>]
    type IThinEngineStateObject =
        abstract ``_contextWasLost``: bool option with get, set
        abstract ``validateShaderPrograms``: bool option with get, set
        abstract ``_webGLVersion``: float with get, set
        abstract ``parallelShaderCompile``: InlineObject350439cd372aObject option with get, set
        abstract ``disableParallelShaderCompile``: bool option with get, set
        abstract ``_context``: BabylonjsBindings.TypeAliases.WebGLContext option with get, set
        abstract ``_createShaderProgramInjection``: System.Func<BabylonjsBindings.SimpleClasses.WebGLPipelineContext, Browser.Types.WebGLShader, Browser.Types.WebGLShader, BabylonjsBindings.TypeAliases.WebGLContext, ResizeArray<string> option, bool option, Browser.Types.WebGLProgram> option with get, set
        abstract ``createRawShaderProgramInjection``: System.Func<IPipelineContext, string, string, BabylonjsBindings.TypeAliases.WebGLContext, ResizeArray<string> option, System.Func<BabylonjsBindings.SimpleClasses.WebGLPipelineContext, Browser.Types.WebGLShader, Browser.Types.WebGLShader, BabylonjsBindings.TypeAliases.WebGLContext, ResizeArray<string> option, bool option, Browser.Types.WebGLProgram> option, Browser.Types.WebGLProgram> option with get, set
        abstract ``createShaderProgramInjection``: System.Func<IPipelineContext, string, string, string option, BabylonjsBindings.TypeAliases.WebGLContext, ResizeArray<string> option, System.Func<BabylonjsBindings.SimpleClasses.WebGLPipelineContext, Browser.Types.WebGLShader, Browser.Types.WebGLShader, BabylonjsBindings.TypeAliases.WebGLContext, ResizeArray<string> option, bool option, Browser.Types.WebGLProgram> option, Browser.Types.WebGLProgram> option with get, set
        abstract ``loadFileInjection``: System.Func<string, System.Action<U2<string, JS.ArrayBuffer>, string option>, System.Action<obj> option, IOfflineProvider option, bool option, System.Action<IWebRequest option, obj option> option, System.Func<string, System.Action<U2<string, JS.ArrayBuffer>, string option>, System.Action<Browser.Types.ProgressEvent> option, IOfflineProvider option, bool option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest option, BabylonjsBindings.SimpleClasses.LoadFileError option> option, IFileRequest> option, IFileRequest> option with get, set
        abstract ``cachedPipelines``: InlineObject4583f044ad0cObject with get, set

    /// Exact Fetch referrer-policy literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserReferrerPolicy =
        | [<CompiledName("")>] Default
        | [<CompiledName("no-referrer")>] NoReferrer
        | [<CompiledName("no-referrer-when-downgrade")>] NoReferrerWhenDowngrade
        | [<CompiledName("origin")>] Origin
        | [<CompiledName("origin-when-cross-origin")>] OriginWhenCrossOrigin
        | [<CompiledName("same-origin")>] SameOrigin
        | [<CompiledName("strict-origin")>] StrictOrigin
        | [<CompiledName("strict-origin-when-cross-origin")>] StrictOriginWhenCrossOrigin
        | [<CompiledName("unsafe-url")>] UnsafeUrl

    /// Exact ECMAScript function-arguments object surface.
    [<AllowNullLiteral>]
    type BrowserArguments =
        [<EmitIndexer>] abstract Item: index: float -> obj with get, set
        abstract length: float with get
        abstract callee: System.Delegate with get

    /// Distinct ambient WebXR input-source event handle.
    [<AllowNullLiteral>]
    type BrowserXRInputSourceEvent =
        interface end

    /// Distinct ambient WebXR ray handle.
    [<AllowNullLiteral>]
    type BrowserXRRay =
        interface end

    /// Exact numeric enum subset projected from a TypeScript declaration.
    type PointerInputSubsetbd14c9a442 =
        | MouseWheelX = 7
        | MouseWheelY = 8
        | MouseWheelZ = 9

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IWheelEvent =
        inherit IMouseEvent
        abstract ``inputIndex``: PointerInputSubsetbd14c9a442 with get, set
        abstract ``deltaMode``: float with get, set
        abstract ``deltaX``: float with get, set
        abstract ``deltaY``: float with get, set
        abstract ``deltaZ``: float with get, set
        abstract ``wheelDelta``: float option with get, set

    /// Exact JavaScript constructor surface for XMLHttpRequest.
    [<AllowNullLiteral>]
    type BrowserXMLHttpRequestStatic =
        [<EmitConstructor>] abstract Create: unit -> BrowserXMLHttpRequest

    /// Nominal erased representation of the TypeScript `true` singleton.
    [<Erase>]
    type BrowserTrue = private BrowserTrue of bool

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeEngineInfo =
        abstract ``version``: string with get, set
        abstract ``nonFloatVertexBuffers``: BrowserTrue with get, set

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeCameraConstructor =
        abstract ``prototype``: INativeCamera with get, set
        [<EmitConstructor>] abstract Create: unit -> INativeCamera

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeDataStreamConstructor =
        abstract ``prototype``: INativeDataStream with get, set
        [<EmitConstructor>] abstract Create: ``requestFlushCallback``: System.Action -> INativeDataStream
        abstract ``VALIDATION_ENABLED``: bool with get
        abstract ``VALIDATION_UINT_32``: float with get
        abstract ``VALIDATION_INT_32``: float with get
        abstract ``VALIDATION_FLOAT_32``: float with get
        abstract ``VALIDATION_UINT_32_ARRAY``: float with get
        abstract ``VALIDATION_INT_32_ARRAY``: float with get
        abstract ``VALIDATION_FLOAT_32_ARRAY``: float with get
        abstract ``VALIDATION_NATIVE_DATA``: float with get
        abstract ``VALIDATION_BOOLEAN``: float with get

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeImageConstructor =
        abstract ``prototype``: IImage with get, set
        [<EmitConstructor>] abstract Create: unit -> IImage

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type IDeviceInputSystemConstructor =
        abstract ``prototype``: IDeviceInputSystem with get, set
        [<EmitConstructor>] abstract Create: ``onDeviceConnected``: System.Action<BabylonjsBindings.Enums.DeviceType, float> * ``onDeviceDisconnected``: System.Action<BabylonjsBindings.Enums.DeviceType, float> * ``onInputChanged``: System.Action<BabylonjsBindings.Enums.DeviceType, float, float, float> -> IDeviceInputSystem

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeEngineConstructor =
        abstract ``prototype``: INativeEngine with get, set
        [<EmitConstructor>] abstract Create: ``info``: INativeEngineInfo -> INativeEngine
        abstract ``PROTOCOL_VERSION``: float with get
        abstract ``CAPS_LIMITS_MAX_TEXTURE_SIZE``: float with get
        abstract ``CAPS_LIMITS_MAX_TEXTURE_LAYERS``: float with get
        abstract ``TEXTURE_NEAREST_NEAREST``: float with get
        abstract ``TEXTURE_LINEAR_LINEAR``: float with get
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
        abstract ``DEPTH_TEST_LESS``: float with get
        abstract ``DEPTH_TEST_LEQUAL``: float with get
        abstract ``DEPTH_TEST_EQUAL``: float with get
        abstract ``DEPTH_TEST_GEQUAL``: float with get
        abstract ``DEPTH_TEST_GREATER``: float with get
        abstract ``DEPTH_TEST_NOTEQUAL``: float with get
        abstract ``DEPTH_TEST_NEVER``: float with get
        abstract ``DEPTH_TEST_ALWAYS``: float with get
        abstract ``ADDRESS_MODE_WRAP``: float with get
        abstract ``ADDRESS_MODE_MIRROR``: float with get
        abstract ``ADDRESS_MODE_CLAMP``: float with get
        abstract ``ADDRESS_MODE_BORDER``: float with get
        abstract ``ADDRESS_MODE_MIRROR_ONCE``: float with get
        abstract ``TEXTURE_FORMAT_BC1``: float with get
        abstract ``TEXTURE_FORMAT_BC2``: float with get
        abstract ``TEXTURE_FORMAT_BC3``: float with get
        abstract ``TEXTURE_FORMAT_BC4``: float with get
        abstract ``TEXTURE_FORMAT_BC5``: float with get
        abstract ``TEXTURE_FORMAT_BC6H``: float with get
        abstract ``TEXTURE_FORMAT_BC7``: float with get
        abstract ``TEXTURE_FORMAT_ETC1``: float with get
        abstract ``TEXTURE_FORMAT_ETC2``: float with get
        abstract ``TEXTURE_FORMAT_ETC2A``: float with get
        abstract ``TEXTURE_FORMAT_ETC2A1``: float with get
        abstract ``TEXTURE_FORMAT_PTC12``: float with get
        abstract ``TEXTURE_FORMAT_PTC14``: float with get
        abstract ``TEXTURE_FORMAT_PTC12A``: float with get
        abstract ``TEXTURE_FORMAT_PTC14A``: float with get
        abstract ``TEXTURE_FORMAT_PTC22``: float with get
        abstract ``TEXTURE_FORMAT_PTC24``: float with get
        abstract ``TEXTURE_FORMAT_ATC``: float with get
        abstract ``TEXTURE_FORMAT_ATCE``: float with get
        abstract ``TEXTURE_FORMAT_ATCI``: float with get
        abstract ``TEXTURE_FORMAT_ASTC4x4``: float with get
        abstract ``TEXTURE_FORMAT_ASTC5x4``: float with get
        abstract ``TEXTURE_FORMAT_ASTC5x5``: float with get
        abstract ``TEXTURE_FORMAT_ASTC6x5``: float with get
        abstract ``TEXTURE_FORMAT_ASTC6x6``: float with get
        abstract ``TEXTURE_FORMAT_ASTC8x5``: float with get
        abstract ``TEXTURE_FORMAT_ASTC8x6``: float with get
        abstract ``TEXTURE_FORMAT_ASTC8x8``: float with get
        abstract ``TEXTURE_FORMAT_ASTC10x5``: float with get
        abstract ``TEXTURE_FORMAT_ASTC10x6``: float with get
        abstract ``TEXTURE_FORMAT_ASTC10x8``: float with get
        abstract ``TEXTURE_FORMAT_ASTC10x10``: float with get
        abstract ``TEXTURE_FORMAT_ASTC12x10``: float with get
        abstract ``TEXTURE_FORMAT_ASTC12x12``: float with get
        abstract ``TEXTURE_FORMAT_R1``: float with get
        abstract ``TEXTURE_FORMAT_A8``: float with get
        abstract ``TEXTURE_FORMAT_R8``: float with get
        abstract ``TEXTURE_FORMAT_R8I``: float with get
        abstract ``TEXTURE_FORMAT_R8U``: float with get
        abstract ``TEXTURE_FORMAT_R8S``: float with get
        abstract ``TEXTURE_FORMAT_R16``: float with get
        abstract ``TEXTURE_FORMAT_R16I``: float with get
        abstract ``TEXTURE_FORMAT_R16U``: float with get
        abstract ``TEXTURE_FORMAT_R16F``: float with get
        abstract ``TEXTURE_FORMAT_R16S``: float with get
        abstract ``TEXTURE_FORMAT_R32I``: float with get
        abstract ``TEXTURE_FORMAT_R32U``: float with get
        abstract ``TEXTURE_FORMAT_R32F``: float with get
        abstract ``TEXTURE_FORMAT_RG8``: float with get
        abstract ``TEXTURE_FORMAT_RG8I``: float with get
        abstract ``TEXTURE_FORMAT_RG8U``: float with get
        abstract ``TEXTURE_FORMAT_RG8S``: float with get
        abstract ``TEXTURE_FORMAT_RG16``: float with get
        abstract ``TEXTURE_FORMAT_RG16I``: float with get
        abstract ``TEXTURE_FORMAT_RG16U``: float with get
        abstract ``TEXTURE_FORMAT_RG16F``: float with get
        abstract ``TEXTURE_FORMAT_RG16S``: float with get
        abstract ``TEXTURE_FORMAT_RG32I``: float with get
        abstract ``TEXTURE_FORMAT_RG32U``: float with get
        abstract ``TEXTURE_FORMAT_RG32F``: float with get
        abstract ``TEXTURE_FORMAT_RGB8``: float with get
        abstract ``TEXTURE_FORMAT_RGB8I``: float with get
        abstract ``TEXTURE_FORMAT_RGB8U``: float with get
        abstract ``TEXTURE_FORMAT_RGB8S``: float with get
        abstract ``TEXTURE_FORMAT_RGB9E5F``: float with get
        abstract ``TEXTURE_FORMAT_BGRA8``: float with get
        abstract ``TEXTURE_FORMAT_RGBA8``: float with get
        abstract ``TEXTURE_FORMAT_RGBA8I``: float with get
        abstract ``TEXTURE_FORMAT_RGBA8U``: float with get
        abstract ``TEXTURE_FORMAT_RGBA8S``: float with get
        abstract ``TEXTURE_FORMAT_RGBA16``: float with get
        abstract ``TEXTURE_FORMAT_RGBA16I``: float with get
        abstract ``TEXTURE_FORMAT_RGBA16U``: float with get
        abstract ``TEXTURE_FORMAT_RGBA16F``: float with get
        abstract ``TEXTURE_FORMAT_RGBA16S``: float with get
        abstract ``TEXTURE_FORMAT_RGBA32I``: float with get
        abstract ``TEXTURE_FORMAT_RGBA32U``: float with get
        abstract ``TEXTURE_FORMAT_RGBA32F``: float with get
        abstract ``TEXTURE_FORMAT_B5G6R5``: float with get
        abstract ``TEXTURE_FORMAT_R5G6B5``: float with get
        abstract ``TEXTURE_FORMAT_BGRA4``: float with get
        abstract ``TEXTURE_FORMAT_RGBA4``: float with get
        abstract ``TEXTURE_FORMAT_BGR5A1``: float with get
        abstract ``TEXTURE_FORMAT_RGB5A1``: float with get
        abstract ``TEXTURE_FORMAT_RGB10A2``: float with get
        abstract ``TEXTURE_FORMAT_RG11B10F``: float with get
        abstract ``TEXTURE_FORMAT_D16``: float with get
        abstract ``TEXTURE_FORMAT_D24``: float with get
        abstract ``TEXTURE_FORMAT_D24S8``: float with get
        abstract ``TEXTURE_FORMAT_D32``: float with get
        abstract ``TEXTURE_FORMAT_D16F``: float with get
        abstract ``TEXTURE_FORMAT_D24F``: float with get
        abstract ``TEXTURE_FORMAT_D32F``: float with get
        abstract ``TEXTURE_FORMAT_D0S8``: float with get
        abstract ``ATTRIB_TYPE_INT8``: float with get
        abstract ``ATTRIB_TYPE_UINT8``: float with get
        abstract ``ATTRIB_TYPE_INT16``: float with get
        abstract ``ATTRIB_TYPE_UINT16``: float with get
        abstract ``ATTRIB_TYPE_FLOAT``: float with get
        abstract ``ALPHA_DISABLE``: float with get
        abstract ``ALPHA_ADD``: float with get
        abstract ``ALPHA_COMBINE``: float with get
        abstract ``ALPHA_SUBTRACT``: float with get
        abstract ``ALPHA_MULTIPLY``: float with get
        abstract ``ALPHA_MAXIMIZED``: float with get
        abstract ``ALPHA_ONEONE``: float with get
        abstract ``ALPHA_ONEONE_ONEONE``: float option with get
        abstract ``ALPHA_LAYER_ACCUMULATE``: float option with get
        abstract ``ALPHA_PREMULTIPLIED``: float with get
        abstract ``ALPHA_PREMULTIPLIED_PORTERDUFF``: float with get
        abstract ``ALPHA_INTERPOLATE``: float with get
        abstract ``ALPHA_SCREENMODE``: float with get
        abstract ``ALPHA_REPLACE_COLOR``: float option with get
        abstract ``STENCIL_TEST_LESS``: float with get
        abstract ``STENCIL_TEST_LEQUAL``: float with get
        abstract ``STENCIL_TEST_EQUAL``: float with get
        abstract ``STENCIL_TEST_GEQUAL``: float with get
        abstract ``STENCIL_TEST_GREATER``: float with get
        abstract ``STENCIL_TEST_NOTEQUAL``: float with get
        abstract ``STENCIL_TEST_NEVER``: float with get
        abstract ``STENCIL_TEST_ALWAYS``: float with get
        abstract ``STENCIL_OP_FAIL_S_ZERO``: float with get
        abstract ``STENCIL_OP_FAIL_S_KEEP``: float with get
        abstract ``STENCIL_OP_FAIL_S_REPLACE``: float with get
        abstract ``STENCIL_OP_FAIL_S_INCR``: float with get
        abstract ``STENCIL_OP_FAIL_S_INCRSAT``: float with get
        abstract ``STENCIL_OP_FAIL_S_DECR``: float with get
        abstract ``STENCIL_OP_FAIL_S_DECRSAT``: float with get
        abstract ``STENCIL_OP_FAIL_S_INVERT``: float with get
        abstract ``STENCIL_OP_FAIL_Z_ZERO``: float with get
        abstract ``STENCIL_OP_FAIL_Z_KEEP``: float with get
        abstract ``STENCIL_OP_FAIL_Z_REPLACE``: float with get
        abstract ``STENCIL_OP_FAIL_Z_INCR``: float with get
        abstract ``STENCIL_OP_FAIL_Z_INCRSAT``: float with get
        abstract ``STENCIL_OP_FAIL_Z_DECR``: float with get
        abstract ``STENCIL_OP_FAIL_Z_DECRSAT``: float with get
        abstract ``STENCIL_OP_FAIL_Z_INVERT``: float with get
        abstract ``STENCIL_OP_PASS_Z_ZERO``: float with get
        abstract ``STENCIL_OP_PASS_Z_KEEP``: float with get
        abstract ``STENCIL_OP_PASS_Z_REPLACE``: float with get
        abstract ``STENCIL_OP_PASS_Z_INCR``: float with get
        abstract ``STENCIL_OP_PASS_Z_INCRSAT``: float with get
        abstract ``STENCIL_OP_PASS_Z_DECR``: float with get
        abstract ``STENCIL_OP_PASS_Z_DECRSAT``: float with get
        abstract ``STENCIL_OP_PASS_Z_INVERT``: float with get
        abstract ``COMMAND_DELETEVERTEXARRAY``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DELETEINDEXBUFFER``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DELETEVERTEXBUFFER``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETPROGRAM``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETMATRIX``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETMATRIX3X3``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETMATRIX2X2``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETMATRICES``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETINT``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETINTARRAY``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETINTARRAY2``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETINTARRAY3``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETINTARRAY4``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETFLOATARRAY``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETFLOATARRAY2``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETFLOATARRAY3``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETFLOATARRAY4``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETTEXTURESAMPLING``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETTEXTUREWRAPMODE``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETTEXTUREANISOTROPICLEVEL``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETTEXTURE``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_UNSETTEXTURE``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DISCARDALLTEXTURES``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_BINDVERTEXARRAY``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETSTATE``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DELETEPROGRAM``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETZOFFSET``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETZOFFSETUNITS``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETDEPTHTEST``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETDEPTHWRITE``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETCOLORWRITE``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETBLENDMODE``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETFLOAT``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETFLOAT2``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETFLOAT3``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETFLOAT4``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_BINDFRAMEBUFFER``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_UNBINDFRAMEBUFFER``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DELETEFRAMEBUFFER``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DRAWINDEXED``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DRAWINDEXEDINSTANCED``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DRAW``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_DRAWINSTANCED``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_CLEAR``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETSTENCIL``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETVIEWPORT``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_SETSCISSOR``: BabylonjsBindings.TypeAliases.NativeData with get
        abstract ``COMMAND_COPYTEXTURE``: BabylonjsBindings.TypeAliases.NativeData with get

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativePath2DConstructor =
        abstract ``prototype``: IPath2D with get, set
        [<EmitConstructor>] abstract Create: ?``d``: string -> IPath2D

    /// Function-valued INative.enablePerformanceLogging property.
    [<AllowNullLiteral>]
    type INativeEnablePerformanceLoggingCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``level``: BabylonjsBindings.Enums.NativeTraceLevel -> unit

    /// Function-valued INative.disablePerformanceLogging property.
    [<AllowNullLiteral>]
    type INativeDisablePerformanceLoggingCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued INative.startPerformanceCounter property.
    [<AllowNullLiteral>]
    type INativeStartPerformanceCounterCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``counter``: string -> obj

    /// Function-valued INative.endPerformanceCounter property.
    [<AllowNullLiteral>]
    type INativeEndPerformanceCounterCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``counter``: obj -> unit

    /// Function-valued INative.sortSplats property.
    [<AllowNullLiteral>]
    type INativeSortSplatsCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``modelViewMatrix``: BabylonjsBindings.SimpleClasses.Matrix * ``splatPositions``: JS.Float32Array * ``splatIndex``: JS.Float32Array * ``useRightHandedSystem``: bool -> unit

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INative =
        abstract ``Engine``: INativeEngineConstructor with get, set
        abstract ``NativeDataStream``: INativeDataStreamConstructor with get, set
        abstract ``Camera``: INativeCameraConstructor option with get, set
        abstract ``Canvas``: INativeCanvasConstructor option with get, set
        abstract ``Image``: INativeImageConstructor option with get, set
        abstract ``Path2D``: INativePath2DConstructor option with get, set
        abstract ``XMLHttpRequest``: BrowserXMLHttpRequestStatic option with get, set
        abstract ``DeviceInputSystem``: IDeviceInputSystemConstructor option with get, set
        abstract ``enablePerformanceLogging``: INativeEnablePerformanceLoggingCallback option with get, set
        abstract ``disablePerformanceLogging``: INativeDisablePerformanceLoggingCallback option with get, set
        abstract ``startPerformanceCounter``: INativeStartPerformanceCounterCallback option with get, set
        abstract ``endPerformanceCounter``: INativeEndPerformanceCounterCallback option with get, set
        abstract ``sortSplats``: INativeSortSplatsCallback option with get, set

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeCanvasConstructor =
        abstract ``prototype``: ICanvas with get, set
        [<EmitConstructor>] abstract Create: unit -> ICanvas
        abstract ``loadTTFAsync``: ``fontName``: string * ``buffer``: JS.ArrayBuffer -> unit

    /// Nominal erased representation of the TypeScript `false` singleton.
    [<Erase>]
    type BrowserFalse = private BrowserFalse of bool

    /// Distinct ambient WebXR space handle.
    [<AllowNullLiteral>]
    type BrowserXRSpace =
        interface end

    /// Distinct ambient WebXR hit-test source handle.
    [<AllowNullLiteral>]
    type BrowserXRHitTestSource =
        interface end

    /// Distinct ambient WebXR anchor set handle.
    [<AllowNullLiteral>]
    type BrowserXRAnchorSet =
        interface end

    /// Distinct ambient WebXR world information handle.
    [<AllowNullLiteral>]
    type BrowserXRWorldInformation =
        interface end

    /// Distinct ambient WebXR plane set handle.
    [<AllowNullLiteral>]
    type BrowserXRPlaneSet =
        interface end

    /// Distinct ambient WebXR joint space handle.
    [<AllowNullLiteral>]
    type BrowserXRJointSpace =
        interface end

    /// Distinct ambient WebXR joint pose handle.
    [<AllowNullLiteral>]
    type BrowserXRJointPose =
        interface end

    /// Distinct ambient WebXR CPU depth information handle.
    [<AllowNullLiteral>]
    type BrowserXRCPUDepthInformation =
        interface end

    /// Distinct ambient native WebXR frame implementation handle.
    [<AllowNullLiteral>]
    type BrowserNativeXRFrame =
        interface end

    /// Exact Compute Pressure source literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserPressureSource =
        | [<CompiledName("cpu")>] Cpu

    /// Exact Compute Pressure state literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserPressureState =
        | [<CompiledName("nominal")>] Nominal
        | [<CompiledName("fair")>] Fair
        | [<CompiledName("serious")>] Serious
        | [<CompiledName("critical")>] Critical

    /// Exact Compute Pressure factor literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserPressureFactor =
        | [<CompiledName("thermal")>] Thermal
        | [<CompiledName("power-supply")>] PowerSupply

    /// Exact experimental Compute Pressure record surface declared by Babylon.
    [<AllowNullLiteral>]
    type BrowserPressureRecord =
        abstract source: BrowserPressureSource with get, set
        abstract state: BrowserPressureState with get, set
        abstract factors: System.Collections.Generic.IReadOnlyList<BrowserPressureFactor> with get, set
        abstract time: float with get, set

    /// Exact experimental Compute Pressure observer options declared by Babylon.
    [<AllowNullLiteral>]
    type BrowserPressureObserverOptions =
        abstract sampleRate: float option with get, set

    /// @babylonjs/core/XR/features/WebXRControllerMovement.pure
    [<AllowNullLiteral>]
    type IWebXRControllerMovementOptions =
        abstract ``customRegistrationConfigurations``: ResizeArray<BabylonjsBindings.TypeAliases.WebXRControllerMovementRegistrationConfiguration> option with get, set
        abstract ``movementEnabled``: bool option with get, set
        abstract ``movementOrientationFollowsViewerPose``: bool with get, set
        abstract ``movementSpeed``: float option with get, set
        abstract ``movementThreshold``: float option with get, set
        abstract ``rotationEnabled``: bool option with get, set
        abstract ``rotationThreshold``: float option with get, set
        abstract ``rotationSpeed``: float option with get, set
        abstract ``xrInput``: BabylonjsBindings.SimpleClasses.WebXRInput with get, set
        abstract ``movementOrientationFollowsController``: bool with get, set
        abstract ``orientationPreferredHandedness``: BrowserXRHandedness option with get, set

    /// Distinct ambient WebXR WebGPU binding handle.
    [<AllowNullLiteral>]
    type BrowserXRGPUBinding =
        interface end

    /// Erased nominal representation of a readonly TypeScript tuple with at least one element.
    [<Erase>]
    type BrowserNonEmptyReadonlyArray<'T> = private BrowserNonEmptyReadonlyArray of System.Collections.Generic.IReadOnlyList<'T>

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type INode =
        abstract ``cap``: string option with get, set
        abstract ``option``: string option with get, set
        abstract ``alpha``: bool option with get, set
        abstract ``transcodeFormat``: U2<BabylonjsBindings.Enums.TranscodeTarget, ResizeArray<BabylonjsBindings.Enums.TranscodeTarget>> option with get, set
        abstract ``needsPowerOfTwo``: bool option with get, set
        abstract ``yes``: U2<INode, ILeaf> option with get, set
        abstract ``no``: U2<INode, ILeaf> option with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type IDecisionTree =
        [<EmitIndexer>] abstract Item: ``textureFormat``: string -> U2<INode, ILeaf> with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type IKTX2DecoderOptions =
        abstract ``useRGBAIfASTCBC7NotAvailableWhenUASTC``: bool option with get, set
        abstract ``forceRGBA``: bool option with get, set
        abstract ``forceR8``: bool option with get, set
        abstract ``forceRG8``: bool option with get, set
        abstract ``bypassTranscoders``: ResizeArray<string> option with get, set
        abstract ``transcodeFormatDecisionTree``: IDecisionTree option with get, set

    /// Exact ECMAScript PromiseLike surface.
    [<AllowNullLiteral>]
    type BrowserPromiseLike<'T> =
        abstract ``then``<'TResult1, 'TResult2>: ?onfulfilled: System.Func<'T, U2<'TResult1, BrowserPromiseLike<'TResult1>>> * ?onrejected: System.Func<obj, U2<'TResult2, BrowserPromiseLike<'TResult2>>> -> BrowserPromiseLike<U2<'TResult1, 'TResult2>>

    /// @babylonjs/core/types
    [<AllowNullLiteral>]
    type TypedArrayLike =
        inherit JS.ArrayBufferView
        abstract ``length``: float with get
        [<EmitIndexer>] abstract Item: ``n``: float -> float with get, set

    /// Exact glTF 2.0 extension dictionary from the pinned companion declaration.
    [<AllowNullLiteral>]
    type GLTF2Extensions =
        [<EmitIndexer>] abstract Item: key: string -> obj with get, set

    /// Exact glTF 2.0 property base from the pinned companion declaration.
    [<AllowNullLiteral>]
    type GLTF2Property =
        abstract extensions: GLTF2Extensions option with get, set
        abstract extras: obj option with get, set

    /// Exact glTF 2.0 child-root property base from the pinned companion declaration.
    [<AllowNullLiteral>]
    type GLTF2ChildRootProperty =
        inherit GLTF2Property
        abstract name: string option with get, set

    /// Exact glTF 2.0 image MIME-type literals from the pinned companion declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2ImageMimeType =
        | [<CompiledName("image/jpeg")>] Jpeg
        | [<CompiledName("image/png")>] Png
        | [<CompiledName("image/webp")>] Webp
        | [<CompiledName("image/avif")>] Avif
        | [<CompiledName("image/ktx2")>] Ktx2

    /// Exact glTF 2.0 image surface from the pinned companion declaration.
    [<AllowNullLiteral>]
    type GLTF2Image =
        inherit GLTF2ChildRootProperty
        abstract uri: string option with get, set
        abstract mimeType: GLTF2ImageMimeType option with get, set
        abstract bufferView: float option with get, set

    /// Exact glTF 2.0 node surface from the pinned companion declaration.
    [<AllowNullLiteral>]
    type GLTF2Node =
        inherit GLTF2ChildRootProperty
        abstract camera: float option with get, set
        abstract children: ResizeArray<float> option with get, set
        abstract skin: float option with get, set
        abstract matrix: ResizeArray<float> option with get, set
        abstract mesh: float option with get, set
        abstract rotation: ResizeArray<float> option with get, set
        abstract scale: ResizeArray<float> option with get, set
        abstract translation: ResizeArray<float> option with get, set
        abstract weights: ResizeArray<float> option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type GLTFImage =
        inherit GLTF2Image
        inherit IArrayItem
        abstract ``_data``: JS.Promise<JS.ArrayBufferView> option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type GLTFNode =
        inherit GLTF2Node
        inherit IArrayItem
        abstract ``parent``: GLTFNode option with get, set
        abstract ``_babylonTransformNode``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set
        abstract ``_babylonTransformNodeForSkin``: BabylonjsBindings.SimpleClasses.TransformNode option with get, set
        abstract ``_primitiveBabylonMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> option with get, set
        abstract ``_numMorphTargets``: float option with get, set
        abstract ``_isJoint``: bool option with get, set

    /// Exact glTF 2.0 animation-sampler interpolation literals from the pinned companion declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2AnimationSamplerInterpolation =
        | [<CompiledName("LINEAR")>] Linear
        | [<CompiledName("STEP")>] Step
        | [<CompiledName("CUBICSPLINE")>] CubicSpline

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type _IAnimationSamplerData =
        abstract ``input``: JS.Float32Array with get, set
        abstract ``interpolation``: GLTF2AnimationSamplerInterpolation with get, set
        abstract ``output``: JS.Float32Array with get, set

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    type GLTF2AccessorComponentType =
        | BYTE = 5120
        | UNSIGNEDBYTE = 5121
        | SHORT = 5122
        | UNSIGNEDSHORT = 5123
        | UNSIGNEDINT = 5125
        | FLOAT = 5126

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2AccessorType =
        | [<CompiledName("SCALAR")>] SCALAR
        | [<CompiledName("VEC2")>] VEC2
        | [<CompiledName("VEC3")>] VEC3
        | [<CompiledName("VEC4")>] VEC4
        | [<CompiledName("MAT2")>] MAT2
        | [<CompiledName("MAT3")>] MAT3
        | [<CompiledName("MAT4")>] MAT4

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2AnimationChannelTargetPath =
        | [<CompiledName("translation")>] TRANSLATION
        | [<CompiledName("rotation")>] ROTATION
        | [<CompiledName("scale")>] SCALE
        | [<CompiledName("weights")>] WEIGHTS
        | [<CompiledName("pointer")>] POINTER

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2CameraType =
        | [<CompiledName("perspective")>] PERSPECTIVE
        | [<CompiledName("orthographic")>] ORTHOGRAPHIC

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2EXTLightsArea_LightType =
        | [<CompiledName("rect")>] RECT
        | [<CompiledName("disk")>] DISK

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2KHRLightsPunctual_LightType =
        | [<CompiledName("directional")>] DIRECTIONAL
        | [<CompiledName("point")>] POINT
        | [<CompiledName("spot")>] SPOT

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2MaterialAlphaMode =
        | [<CompiledName("OPAQUE")>] OPAQUE
        | [<CompiledName("MASK")>] MASK
        | [<CompiledName("BLEND")>] BLEND

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    type GLTF2MeshPrimitiveMode =
        | POINTS = 0
        | LINES = 1
        | LINELOOP = 2
        | LINESTRIP = 3
        | TRIANGLES = 4
        | TRIANGLESTRIP = 5
        | TRIANGLEFAN = 6

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    type GLTF2TextureMagFilter =
        | NEAREST = 9728
        | LINEAR = 9729

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    type GLTF2TextureMinFilter =
        | NEAREST = 9728
        | LINEAR = 9729
        | NEARESTMIPMAPNEAREST = 9984
        | LINEARMIPMAPNEAREST = 9985
        | NEARESTMIPMAPLINEAR = 9986
        | LINEARMIPMAPLINEAR = 9987

    /// Exact enum from the pinned babylonjs-gltf2interface declaration.
    type GLTF2TextureWrapMode =
        | CLAMPTOEDGE = 33071
        | MIRROREDREPEAT = 33648
        | REPEAT = 10497

    /// Ambient glTF EXT_lights_image_based augmentation required by loader interfaces.
    [<AllowNullLiteral>]
    type GLTFExtLightsImageBasedLightImageBased =
        abstract _babylonTexture: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract _loaded: JS.Promise<unit> option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb023cd843632Object =
        [<EmitIndexer>] abstract Item: ``kind``: string -> JS.Promise<BabylonjsBindings.SimpleClasses.VertexBuffer> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject6fd6e205620fObject =
        abstract ``babylonSourceMesh``: BabylonjsBindings.SimpleClasses.Mesh with get, set
        abstract ``promise``: JS.Promise<obj> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb1139181db41Object =
        abstract ``babylonSkeleton``: BabylonjsBindings.SimpleClasses.Skeleton with get, set
        abstract ``promise``: JS.Promise<unit> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectcb14fbe7a9aaObject =
        [<EmitIndexer>] abstract Item: ``name``: string -> float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject558631677ca0Object =
        abstract ``innerConeAngle``: float option with get, set
        abstract ``outerConeAngle``: float option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectdf1fd213e14fObject =
        abstract ``aspect``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject441d9769b966Object =
        [<EmitIndexer>] abstract Item: ``babylonDrawMode``: float -> InlineObjectaf818667734fObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject478d8a76ee46Object =
        abstract ``__target__``: bool with get, set
        abstract ``orthographic``: InlineObject210e6b8963d6Object with get, set
        abstract ``perspective``: InlineObject1aad2313281fObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject5573f38169f7Object =
        abstract ``lights``: InlineObject15d0054181aaObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4aac0a3e9f2eObject =
        abstract ``lights``: InlineObject5b2e64067170Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectdb8f5d73dec2Object =
        abstract ``lights``: InlineObject09e6ceed0bb8Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4559920cb1f2Object =
        abstract ``lights``: InlineObject7b517648b238Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectd156a044a7f9Object =
        abstract ``__target__``: bool with get, set
        abstract ``pbrMetallicRoughness``: InlineObject33bb58fb9047Object with get, set
        abstract ``emissiveFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.Color3> with get, set
        abstract ``normalTexture``: InlineObject8093fc5a8d33Object with get, set
        abstract ``occlusionTexture``: InlineObjecte73ffa123ce1Object with get, set
        abstract ``emissiveTexture``: InlineObject1078c225cfeeObject with get, set
        abstract ``extensions``: InlineObject94daa705c9b5Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectaf818667734fObject =
        abstract ``babylonMaterial``: BabylonjsBindings.SimpleClasses.Material with get, set
        abstract ``babylonMeshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> with get, set
        abstract ``promise``: JS.Promise<unit> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject210e6b8963d6Object =
        abstract ``xmag``: IObjectAccessor<ICamera, ICamera, BabylonjsBindings.SimpleClasses.Vector2> with get, set
        abstract ``ymag``: IObjectAccessor<ICamera, ICamera, BabylonjsBindings.SimpleClasses.Vector2> with get, set
        abstract ``zfar``: IObjectAccessor<ICamera, ICamera, float> with get, set
        abstract ``znear``: IObjectAccessor<ICamera, ICamera, float> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject1aad2313281fObject =
        abstract ``yfov``: IObjectAccessor<ICamera, ICamera, float> with get, set
        abstract ``zfar``: IObjectAccessor<ICamera, ICamera, float> with get, set
        abstract ``znear``: IObjectAccessor<ICamera, ICamera, float> with get, set
        abstract ``aspectRatio``: IObjectAccessor<ICamera, ICamera, float option> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject15d0054181aaObject =
        abstract ``length``: IObjectAccessor<ResizeArray<IKHRLightsPunctual_Light>, ResizeArray<BabylonjsBindings.SimpleClasses.Light>, float> with get, set
        abstract ``__array__``: InlineObject26784fd0c645Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject5b2e64067170Object =
        abstract ``length``: IObjectAccessor<ResizeArray<IEXTLightsArea_Light>, ResizeArray<BabylonjsBindings.SimpleClasses.Light>, float> with get, set
        abstract ``__array__``: InlineObject042f2e24db01Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject09e6ceed0bb8Object =
        abstract ``length``: IObjectAccessor<ResizeArray<IKHRLightsPunctual_Light>, ResizeArray<BabylonjsBindings.SimpleClasses.Light>, float> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject7b517648b238Object =
        abstract ``__array__``: InlineObject5558de345792Object with get, set
        abstract ``length``: IObjectAccessor<ResizeArray<GLTFExtLightsImageBasedLightImageBased>, ResizeArray<BabylonjsBindings.SimpleClasses.BaseTexture>, float> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject1078c225cfeeObject =
        abstract ``extensions``: InlineObjectaeb9702798daObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject33bb58fb9047Object =
        abstract ``baseColorFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.Color4> with get, set
        abstract ``metallicFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float option> with get, set
        abstract ``roughnessFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float option> with get, set
        abstract ``baseColorTexture``: InlineObject1078c225cfeeObject with get, set
        abstract ``metallicRoughnessTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject8093fc5a8d33Object =
        abstract ``scale``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``extensions``: InlineObjectaeb9702798daObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte73ffa123ce1Object =
        abstract ``strength``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``extensions``: InlineObjectaeb9702798daObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject94daa705c9b5Object =
        abstract ``KHR_materials_anisotropy``: InlineObjectafcef396d07dObject with get, set
        abstract ``KHR_materials_clearcoat``: InlineObject5ff644130530Object with get, set
        abstract ``KHR_materials_dispersion``: InlineObjectf39c3b2faf31Object with get, set
        abstract ``KHR_materials_emissive_strength``: InlineObject6322935848e9Object with get, set
        abstract ``KHR_materials_ior``: InlineObject33ca5a8de512Object with get, set
        abstract ``KHR_materials_iridescence``: InlineObject2f522de3a8beObject with get, set
        abstract ``KHR_materials_sheen``: InlineObject7c28b3f4cc79Object with get, set
        abstract ``KHR_materials_specular``: InlineObject61857645fd89Object with get, set
        abstract ``KHR_materials_transmission``: InlineObject341f0df201e4Object with get, set
        abstract ``KHR_materials_diffuse_transmission``: InlineObjectf015a3cb42c5Object with get, set
        abstract ``KHR_materials_volume``: InlineObjectf01754149022Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject26784fd0c645Object =
        abstract ``__target__``: bool with get, set
        abstract ``color``: IObjectAccessor<IKHRLightsPunctual_Light, BabylonjsBindings.SimpleClasses.Light, BabylonjsBindings.SimpleClasses.Color3> with get, set
        abstract ``intensity``: IObjectAccessor<IKHRLightsPunctual_Light, BabylonjsBindings.SimpleClasses.Light, float> with get, set
        abstract ``range``: IObjectAccessor<IKHRLightsPunctual_Light, BabylonjsBindings.SimpleClasses.Light, float> with get, set
        abstract ``spot``: InlineObject99705d71bc87Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject042f2e24db01Object =
        abstract ``__target__``: bool with get, set
        abstract ``color``: IObjectAccessor<IEXTLightsArea_Light, BabylonjsBindings.SimpleClasses.Light, BabylonjsBindings.SimpleClasses.Color3> with get, set
        abstract ``intensity``: IObjectAccessor<IEXTLightsArea_Light, BabylonjsBindings.SimpleClasses.Light, float> with get, set
        abstract ``size``: IObjectAccessor<IEXTLightsArea_Light, BabylonjsBindings.SimpleClasses.Light, float> with get, set
        abstract ``rect``: InlineObject480572826e21Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject5558de345792Object =
        abstract ``__target__``: bool with get, set
        abstract ``intensity``: IObjectAccessor<GLTFExtLightsImageBasedLightImageBased, BabylonjsBindings.SimpleClasses.BaseTexture, float> with get, set
        abstract ``rotation``: IObjectAccessor<GLTFExtLightsImageBasedLightImageBased, BabylonjsBindings.SimpleClasses.BaseTexture, BabylonjsBindings.SimpleClasses.Quaternion> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectaeb9702798daObject =
        abstract ``KHR_texture_transform``: ITextureDefinition with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectafcef396d07dObject =
        abstract ``anisotropyStrength``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``anisotropyRotation``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``anisotropyTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject5ff644130530Object =
        abstract ``clearcoatFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``clearcoatRoughnessFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``clearcoatTexture``: InlineObject1078c225cfeeObject with get, set
        abstract ``clearcoatNormalTexture``: InlineObject8093fc5a8d33Object with get, set
        abstract ``clearcoatRoughnessTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectf39c3b2faf31Object =
        abstract ``dispersion``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject6322935848e9Object =
        abstract ``emissiveStrength``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject33ca5a8de512Object =
        abstract ``ior``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject2f522de3a8beObject =
        abstract ``iridescenceFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``iridescenceIor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``iridescenceThicknessMinimum``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``iridescenceThicknessMaximum``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``iridescenceTexture``: InlineObject1078c225cfeeObject with get, set
        abstract ``iridescenceThicknessTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject7c28b3f4cc79Object =
        abstract ``sheenColorFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.Color3> with get, set
        abstract ``sheenRoughnessFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``sheenColorTexture``: InlineObject1078c225cfeeObject with get, set
        abstract ``sheenRoughnessTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject61857645fd89Object =
        abstract ``specularFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``specularColorFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.Color3> with get, set
        abstract ``specularTexture``: InlineObject1078c225cfeeObject with get, set
        abstract ``specularColorTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject341f0df201e4Object =
        abstract ``transmissionFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``transmissionTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectf015a3cb42c5Object =
        abstract ``diffuseTransmissionFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``diffuseTransmissionTexture``: InlineObject1078c225cfeeObject with get, set
        abstract ``diffuseTransmissionColorFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.Color3 option> with get, set
        abstract ``diffuseTransmissionColorTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectf01754149022Object =
        abstract ``thicknessFactor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``attenuationColor``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.Color3> with get, set
        abstract ``attenuationDistance``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``thicknessTexture``: InlineObject1078c225cfeeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject99705d71bc87Object =
        abstract ``innerConeAngle``: IObjectAccessor<IKHRLightsPunctual_Light, BabylonjsBindings.SimpleClasses.Light, float> with get, set
        abstract ``outerConeAngle``: IObjectAccessor<IKHRLightsPunctual_Light, BabylonjsBindings.SimpleClasses.Light, float> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject480572826e21Object =
        abstract ``aspect``: IObjectAccessor<IEXTLightsArea_Light, BabylonjsBindings.SimpleClasses.Light, float> with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IProperty =
        abstract ``extensions``: InlineObjecta21bf015c053Object option with get, set
        abstract ``extras``: obj option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAccessorSparseIndices =
        inherit GLTF2IProperty
        abstract ``bufferView``: float with get, set
        abstract ``byteOffset``: float option with get, set
        abstract ``componentType``: GLTF2AccessorComponentType with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAccessorSparseValues =
        inherit GLTF2IProperty
        abstract ``bufferView``: float with get, set
        abstract ``byteOffset``: float option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAnimationChannelTarget =
        inherit GLTF2IProperty
        abstract ``node``: float option with get, set
        abstract ``path``: GLTF2AnimationChannelTargetPath with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAnimationSampler =
        inherit GLTF2IProperty
        abstract ``input``: float with get, set
        abstract ``interpolation``: GLTF2AnimationSamplerInterpolation option with get, set
        abstract ``output``: float with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2ICameraOrthographic =
        inherit GLTF2IProperty
        abstract ``xmag``: float with get, set
        abstract ``ymag``: float with get, set
        abstract ``zfar``: float with get, set
        abstract ``znear``: float with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2ICameraPerspective =
        inherit GLTF2IProperty
        abstract ``aspectRatio``: float option with get, set
        abstract ``yfov``: float with get, set
        abstract ``zfar``: float option with get, set
        abstract ``znear``: float with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IChildRootProperty =
        inherit GLTF2IProperty
        abstract ``name``: string option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IMeshPrimitive =
        inherit GLTF2IProperty
        abstract ``attributes``: InlineObjectcb14fbe7a9aaObject with get, set
        abstract ``indices``: float option with get, set
        abstract ``material``: float option with get, set
        abstract ``mode``: GLTF2MeshPrimitiveMode option with get, set
        abstract ``targets``: ResizeArray<InlineObjectcb14fbe7a9aaObject> option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2ITextureInfo =
        inherit GLTF2IProperty
        abstract ``index``: float with get, set
        abstract ``texCoord``: float option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAccessorSparse =
        inherit GLTF2IProperty
        abstract ``count``: float with get, set
        abstract ``indices``: GLTF2IAccessorSparseIndices with get, set
        abstract ``values``: GLTF2IAccessorSparseValues with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAnimationChannel =
        inherit GLTF2IProperty
        abstract ``sampler``: float with get, set
        abstract ``target``: GLTF2IAnimationChannelTarget with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAsset =
        inherit GLTF2IChildRootProperty
        abstract ``copyright``: string option with get, set
        abstract ``generator``: string option with get, set
        abstract ``version``: string with get, set
        abstract ``minVersion``: string option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IBuffer =
        inherit GLTF2IChildRootProperty
        abstract ``uri``: string option with get, set
        abstract ``byteLength``: float with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IBufferView =
        inherit GLTF2IChildRootProperty
        abstract ``buffer``: float with get, set
        abstract ``byteOffset``: float option with get, set
        abstract ``byteLength``: float with get, set
        abstract ``byteStride``: float option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2ICamera =
        inherit GLTF2IChildRootProperty
        abstract ``orthographic``: GLTF2ICameraOrthographic option with get, set
        abstract ``perspective``: GLTF2ICameraPerspective option with get, set
        abstract ``type``: GLTF2CameraType with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IEXTLightsArea_Light =
        inherit GLTF2IChildRootProperty
        abstract ``type``: GLTF2EXTLightsArea_LightType with get, set
        abstract ``color``: ResizeArray<float> option with get, set
        abstract ``intensity``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``rect``: InlineObjectdf1fd213e14fObject option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IEXTLightsIES_Light =
        inherit GLTF2IChildRootProperty
        abstract ``uri``: string option with get, set
        abstract ``bufferView``: float option with get, set
        abstract ``mimeType``: string option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IImage =
        inherit GLTF2IChildRootProperty
        abstract ``uri``: string option with get, set
        abstract ``mimeType``: GLTF2ImageMimeType option with get, set
        abstract ``bufferView``: float option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRLightsPunctual_Light =
        inherit GLTF2IChildRootProperty
        abstract ``type``: GLTF2KHRLightsPunctual_LightType with get, set
        abstract ``color``: ResizeArray<float> option with get, set
        abstract ``intensity``: float option with get, set
        abstract ``range``: float option with get, set
        abstract ``spot``: InlineObject558631677ca0Object option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IMaterialNormalTextureInfo =
        inherit GLTF2ITextureInfo
        abstract ``scale``: float option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IMaterialOcclusionTextureInfo =
        inherit GLTF2ITextureInfo
        abstract ``strength``: float option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IMaterialPbrMetallicRoughness =
        abstract ``baseColorFactor``: ResizeArray<float> option with get, set
        abstract ``baseColorTexture``: GLTF2ITextureInfo option with get, set
        abstract ``metallicFactor``: float option with get, set
        abstract ``roughnessFactor``: float option with get, set
        abstract ``metallicRoughnessTexture``: GLTF2ITextureInfo option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IMesh =
        inherit GLTF2IChildRootProperty
        abstract ``primitives``: ResizeArray<GLTF2IMeshPrimitive> with get, set
        abstract ``weights``: ResizeArray<float> option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2INode =
        inherit GLTF2IChildRootProperty
        abstract ``camera``: float option with get, set
        abstract ``children``: ResizeArray<float> option with get, set
        abstract ``skin``: float option with get, set
        abstract ``matrix``: ResizeArray<float> option with get, set
        abstract ``mesh``: float option with get, set
        abstract ``rotation``: ResizeArray<float> option with get, set
        abstract ``scale``: ResizeArray<float> option with get, set
        abstract ``translation``: ResizeArray<float> option with get, set
        abstract ``weights``: ResizeArray<float> option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2ISampler =
        inherit GLTF2IChildRootProperty
        abstract ``magFilter``: GLTF2TextureMagFilter option with get, set
        abstract ``minFilter``: GLTF2TextureMinFilter option with get, set
        abstract ``wrapS``: GLTF2TextureWrapMode option with get, set
        abstract ``wrapT``: GLTF2TextureWrapMode option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IScene =
        inherit GLTF2IChildRootProperty
        abstract ``nodes``: ResizeArray<float> with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2ISkin =
        inherit GLTF2IChildRootProperty
        abstract ``inverseBindMatrices``: float option with get, set
        abstract ``skeleton``: float option with get, set
        abstract ``joints``: ResizeArray<float> with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2ITexture =
        inherit GLTF2IChildRootProperty
        abstract ``sampler``: float option with get, set
        abstract ``source``: float option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IAnimationSampler =
        inherit GLTF2IAnimationSampler
        inherit IArrayItem
        abstract ``_data``: JS.Promise<_IAnimationSamplerData> option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IMeshPrimitive =
        inherit GLTF2IMeshPrimitive
        inherit IArrayItem
        abstract ``_instanceData``: InlineObject6fd6e205620fObject option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type ITextureInfo =
        inherit GLTF2ITextureInfo
        abstract ``nonColorData``: bool option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAccessor =
        inherit GLTF2IChildRootProperty
        abstract ``bufferView``: float option with get, set
        abstract ``byteOffset``: float option with get, set
        abstract ``componentType``: GLTF2AccessorComponentType with get, set
        abstract ``normalized``: bool option with get, set
        abstract ``count``: float with get, set
        abstract ``type``: GLTF2AccessorType with get, set
        abstract ``max``: ResizeArray<float> option with get, set
        abstract ``min``: ResizeArray<float> option with get, set
        abstract ``sparse``: GLTF2IAccessorSparse option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IAnimation =
        inherit GLTF2IChildRootProperty
        abstract ``channels``: ResizeArray<GLTF2IAnimationChannel> with get, set
        abstract ``samplers``: ResizeArray<GLTF2IAnimationSampler> with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IMaterial =
        inherit GLTF2IChildRootProperty
        abstract ``pbrMetallicRoughness``: GLTF2IMaterialPbrMetallicRoughness option with get, set
        abstract ``normalTexture``: GLTF2IMaterialNormalTextureInfo option with get, set
        abstract ``occlusionTexture``: GLTF2IMaterialOcclusionTextureInfo option with get, set
        abstract ``emissiveTexture``: GLTF2ITextureInfo option with get, set
        abstract ``emissiveFactor``: ResizeArray<float> option with get, set
        abstract ``alphaMode``: GLTF2MaterialAlphaMode option with get, set
        abstract ``alphaCutoff``: float option with get, set
        abstract ``doubleSided``: bool option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IAnimationChannel =
        inherit GLTF2IAnimationChannel
        inherit IArrayItem

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IBuffer =
        inherit GLTF2IBuffer
        inherit IArrayItem
        abstract ``_data``: JS.Promise<JS.ArrayBufferView> option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IBufferView =
        inherit GLTF2IBufferView
        inherit IArrayItem
        abstract ``_data``: JS.Promise<JS.ArrayBufferView> option with get, set
        abstract ``_babylonBuffer``: JS.Promise<BabylonjsBindings.SimpleClasses.Buffer> option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type ICamera =
        inherit GLTF2ICamera
        inherit IArrayItem
        abstract ``_babylonCamera``: BabylonjsBindings.SimpleClasses.Camera option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IEXTLightsArea_Light =
        inherit GLTF2IEXTLightsArea_Light
        inherit IArrayItem
        abstract ``_babylonLight``: BabylonjsBindings.SimpleClasses.Light option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IEXTLightsIES_Light =
        inherit GLTF2IEXTLightsIES_Light
        inherit IArrayItem
        abstract ``_babylonLight``: BabylonjsBindings.SimpleClasses.Light option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IKHRLightsPunctual_Light =
        inherit GLTF2IKHRLightsPunctual_Light
        inherit IArrayItem
        abstract ``_babylonLight``: BabylonjsBindings.SimpleClasses.Light option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IMaterialNormalTextureInfo =
        inherit GLTF2IMaterialNormalTextureInfo
        inherit ITextureInfo

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IMaterialOcclusionTextureInfo =
        inherit GLTF2IMaterialOcclusionTextureInfo
        inherit ITextureInfo

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IMaterialPbrMetallicRoughness =
        inherit GLTF2IMaterialPbrMetallicRoughness
        abstract ``baseColorTexture``: ITextureInfo option with get, set
        abstract ``metallicRoughnessTexture``: ITextureInfo option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IMesh =
        inherit GLTF2IMesh
        inherit IArrayItem
        abstract ``primitives``: ResizeArray<IMeshPrimitive> with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type ISampler =
        inherit GLTF2ISampler
        inherit IArrayItem
        abstract ``_data``: _ISamplerData option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IScene =
        inherit GLTF2IScene
        inherit IArrayItem

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type ISkin =
        inherit GLTF2ISkin
        inherit IArrayItem
        abstract ``_data``: InlineObjectb1139181db41Object option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type ITexture =
        inherit GLTF2ITexture
        inherit IArrayItem
        abstract ``_textureInfo``: ITextureInfo with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IGLTF =
        inherit GLTF2IProperty
        abstract ``accessors``: ResizeArray<GLTF2IAccessor> option with get, set
        abstract ``animations``: ResizeArray<GLTF2IAnimation> option with get, set
        abstract ``asset``: GLTF2IAsset with get, set
        abstract ``buffers``: ResizeArray<GLTF2IBuffer> option with get, set
        abstract ``bufferViews``: ResizeArray<GLTF2IBufferView> option with get, set
        abstract ``cameras``: ResizeArray<GLTF2ICamera> option with get, set
        abstract ``extensionsUsed``: ResizeArray<string> option with get, set
        abstract ``extensionsRequired``: ResizeArray<string> option with get, set
        abstract ``images``: ResizeArray<GLTF2IImage> option with get, set
        abstract ``materials``: ResizeArray<GLTF2IMaterial> option with get, set
        abstract ``meshes``: ResizeArray<GLTF2IMesh> option with get, set
        abstract ``nodes``: ResizeArray<GLTF2INode> option with get, set
        abstract ``samplers``: ResizeArray<GLTF2ISampler> option with get, set
        abstract ``scene``: float option with get, set
        abstract ``scenes``: ResizeArray<GLTF2IScene> option with get, set
        abstract ``skins``: ResizeArray<GLTF2ISkin> option with get, set
        abstract ``textures``: ResizeArray<GLTF2ITexture> option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IAccessor =
        inherit GLTF2IAccessor
        inherit IArrayItem
        abstract ``_data``: JS.Promise<JS.ArrayBufferView> option with get, set
        abstract ``_babylonVertexBuffer``: InlineObjectb023cd843632Object option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IAnimation =
        inherit GLTF2IAnimation
        inherit IArrayItem
        abstract ``channels``: ResizeArray<IAnimationChannel> with get, set
        abstract ``samplers``: ResizeArray<IAnimationSampler> with get, set
        abstract ``_babylonAnimationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup option with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeCamerasObject =
        abstract ``__array__``: InlineObject478d8a76ee46Object with get, set

    /// Named exact intersections for the glTF node object-model tree.
    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeNodeWeightsArray<'GLTFTargetType, 'BabylonTargetType> =
        inherit IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, float>
        abstract ``__target__``: bool with get, set

    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeNodeWeights<'GLTFTargetType, 'BabylonTargetType> =
        inherit IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, ResizeArray<float>>
        abstract ``length``: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, float> with get, set
        abstract ``__array__``: IGLTFObjectModelTreeNodeWeightsArray<'GLTFTargetType, 'BabylonTargetType> with get, set

    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeNodeExtLightsIes =
        abstract ``multiplier``: IObjectAccessor<INode, BabylonjsBindings.SimpleClasses.Light, float> with get, set
        abstract ``color``: IObjectAccessor<INode, BabylonjsBindings.SimpleClasses.Light, BabylonjsBindings.SimpleClasses.Color3> with get, set

    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeNodeVisibility =
        abstract ``visible``: IObjectAccessor<INode, BabylonjsBindings.SimpleClasses.Mesh, bool> with get, set

    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeNodeExtensions =
        abstract ``EXT_lights_ies``: IGLTFObjectModelTreeNodeExtLightsIes option with get, set
        abstract ``KHR_node_visibility``: IGLTFObjectModelTreeNodeVisibility option with get, set

    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeNodeArray<'GLTFTargetType, 'BabylonTargetType> =
        abstract ``__target__``: bool with get, set
        abstract ``translation``: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``rotation``: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, BabylonjsBindings.SimpleClasses.Quaternion> with get, set
        abstract ``scale``: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``matrix``: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, BabylonjsBindings.SimpleClasses.Matrix> with get, set
        abstract ``globalMatrix``: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, BabylonjsBindings.SimpleClasses.Matrix> with get, set
        abstract ``weights``: IGLTFObjectModelTreeNodeWeights<'GLTFTargetType, 'BabylonTargetType> with get, set
        abstract ``extensions``: IGLTFObjectModelTreeNodeExtensions with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeNodesObject<'GLTFTargetType, 'BabylonTargetType> =
        abstract ``length``: IObjectAccessor<ResizeArray<'GLTFTargetType>, ResizeArray<'BabylonTargetType>, float> with get, set
        abstract ``__array__``: IGLTFObjectModelTreeNodeArray<'GLTFTargetType, 'BabylonTargetType> with get, set

    type IGLTFObjectModelTreeNodesObject<'GLTFTargetType> = IGLTFObjectModelTreeNodesObject<'GLTFTargetType, BabylonjsBindings.SimpleClasses.TransformNode>
    type IGLTFObjectModelTreeNodesObject = IGLTFObjectModelTreeNodesObject<INode, BabylonjsBindings.SimpleClasses.TransformNode>

    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeEmptyArray = interface end

    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeAnimationsObject =
        abstract ``length``: IObjectAccessor<ResizeArray<IAnimation>, ResizeArray<BabylonjsBindings.SimpleClasses.AnimationGroup>, float> with get, set
        abstract ``__array__``: IGLTFObjectModelTreeEmptyArray with get, set

    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeMeshesCollectionObject =
        abstract ``length``: IObjectAccessor<ResizeArray<IMesh>, ResizeArray<BabylonjsBindings.SimpleClasses.Mesh option>, float> with get, set
        abstract ``__array__``: IGLTFObjectModelTreeEmptyArray with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type IGLTFObjectModelTree =
        abstract ``cameras``: IGLTFObjectModelTreeCamerasObject with get, set
        abstract ``nodes``: IGLTFObjectModelTreeNodesObject with get, set
        abstract ``materials``: IGLTFObjectModelTreeMaterialsObject with get, set
        abstract ``extensions``: IGLTFObjectModelTreeExtensionsObject with get, set
        abstract ``animations``: IGLTFObjectModelTreeAnimationsObject with get, set
        abstract ``meshes``: IGLTFObjectModelTreeMeshesCollectionObject with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeExtensionsObject =
        abstract ``KHR_lights_punctual``: InlineObject5573f38169f7Object with get, set
        abstract ``EXT_lights_area``: InlineObject4aac0a3e9f2eObject with get, set
        abstract ``EXT_lights_ies``: InlineObjectdb8f5d73dec2Object with get, set
        abstract ``EXT_lights_image_based``: InlineObject4559920cb1f2Object with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IMaterial =
        inherit GLTF2IMaterial
        inherit IArrayItem
        abstract ``pbrMetallicRoughness``: IMaterialPbrMetallicRoughness option with get, set
        abstract ``normalTexture``: IMaterialNormalTextureInfo option with get, set
        abstract ``occlusionTexture``: IMaterialOcclusionTextureInfo option with get, set
        abstract ``emissiveTexture``: ITextureInfo option with get, set
        abstract ``_data``: InlineObject441d9769b966Object option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTF =
        inherit GLTF2IGLTF
        abstract ``accessors``: ResizeArray<IAccessor> option with get, set
        abstract ``animations``: ResizeArray<IAnimation> option with get, set
        abstract ``buffers``: ResizeArray<IBuffer> option with get, set
        abstract ``bufferViews``: ResizeArray<IBufferView> option with get, set
        abstract ``cameras``: ResizeArray<ICamera> option with get, set
        abstract ``images``: ResizeArray<GLTFImage> option with get, set
        abstract ``materials``: ResizeArray<IMaterial> option with get, set
        abstract ``meshes``: ResizeArray<IMesh> option with get, set
        abstract ``nodes``: ResizeArray<GLTFNode> option with get, set
        abstract ``samplers``: ResizeArray<ISampler> option with get, set
        abstract ``scenes``: ResizeArray<IScene> option with get, set
        abstract ``skins``: ResizeArray<ISkin> option with get, set
        abstract ``textures``: ResizeArray<ITexture> option with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type ITextureDefinition =
        abstract ``offset``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.Vector2> with get, set
        abstract ``rotation``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, float> with get, set
        abstract ``scale``: IObjectAccessor<IMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.Vector2> with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/flowGraphGLTFDataProvider
    [<AllowNullLiteral>]
    type IFlowGraphGLTFDataProviderBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``glTF``: IGLTF with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeMaterialsObject =
        abstract ``__array__``: InlineObjectd156a044a7f9Object with get, set

    /// Exact glTF interactivity value-signature literals from the pinned companion declaration.
    [<StringEnum; RequireQualifiedAccess>]
    type GLTF2ValueSignature =
        | [<CompiledName("bool")>] Bool
        | [<CompiledName("float")>] Float
        | [<CompiledName("float2")>] Float2
        | [<CompiledName("float3")>] Float3
        | [<CompiledName("float4")>] Float4
        | [<CompiledName("float2x2")>] Float2x2
        | [<CompiledName("float3x3")>] Float3x3
        | [<CompiledName("float4x4")>] Float4x4
        | [<CompiledName("int")>] Int
        | [<CompiledName("custom")>] Custom

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectdd5fbe357414Object =
        [<EmitIndexer>] abstract Item: ``id``: string -> InlineObject3188917dc4cfObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject5bbc2f1fb479Object =
        [<EmitIndexer>] abstract Item: ``originName``: string -> IGLTFToFlowGraphMappingObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb50b2a1c7176Object =
        abstract ``values``: InlineObject5bbc2f1fb479Object option with get, set
        abstract ``flows``: InlineObject5bbc2f1fb479Object option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject5807e9eb1367Object =
        abstract ``values``: InlineObject5bbc2f1fb479Object option with get, set
        abstract ``flows``: InlineObject5bbc2f1fb479Object option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject298705b65dd9Object =
        abstract ``input``: string with get, set
        abstract ``output``: string with get, set
        abstract ``inputBlockIndex``: float with get, set
        abstract ``outputBlockIndex``: float with get, set
        abstract ``isVariable``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4e409eaefbb8Object =
        abstract ``valid``: bool with get, set
        abstract ``error``: string option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject749f47aaa0bfObject =
        [<EmitIndexer>] abstract Item: ``id``: string -> GLTF2IKHRInteractivity_Variable with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject0c999b4cb06bObject =
        [<EmitIndexer>] abstract Item: ``id``: string -> U2<GLTF2IKHRInteractivity_Variable, GLTF2IKHRInteractivity_OutputSocketReference> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject08fece736369Object =
        [<EmitIndexer>] abstract Item: ``id``: string -> GLTF2IKHRInteractivity_OutputFlow with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4794d27e06d6Object =
        [<EmitIndexer>] abstract Item: ``id``: string -> GLTF2IKHRInteractivity_Configuration with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject3188917dc4cfObject =
        abstract ``type``: float with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_Configuration =
        abstract ``value``: ResizeArray<U3<bool, float, string>> option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_Declaration =
        abstract ``op``: string with get, set
        abstract ``extension``: string option with get, set
        abstract ``outputValueSockets``: InlineObjectdd5fbe357414Object option with get, set
        abstract ``inputValueSockets``: InlineObjectdd5fbe357414Object option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_OutputFlow =
        abstract ``node``: float with get, set
        abstract ``socket``: string option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_OutputSocketReference =
        abstract ``node``: float with get, set
        abstract ``socket``: string option with get, set
        abstract ``type``: float option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_Type =
        abstract ``signature``: GLTF2ValueSignature with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_Variable =
        abstract ``value``: ResizeArray<U2<bool, float>> option with get, set
        abstract ``type``: float with get, set

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    [<AllowNullLiteral>]
    type GLTFFileLoaderExtension =
        abstract ``name``: string with get
        abstract ``enabled``: bool with get, set
        abstract ``order``: float option with get, set

    /// Function-valued IGLTFToFlowGraphMappingObject.dataTransformer property.
    [<AllowNullLiteral>]
    type IGLTFToFlowGraphMappingObjectDataTransformerCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: obj * ``parser``: BabylonjsBindings.SimpleClasses.InteractivityGraphToFlowGraphParser -> obj

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/declarationMapper
    [<AllowNullLiteral>]
    type IGLTFToFlowGraphMappingObject =
        abstract ``name``: string with get, set
        abstract ``gltfType``: string option with get, set
        abstract ``flowGraphType``: string option with get, set
        abstract ``dataTransformer``: IGLTFToFlowGraphMappingObjectDataTransformerCallback option with get, set
        abstract ``isArray``: bool option with get, set
        abstract ``inOptions``: bool option with get, set
        abstract ``isVariable``: bool option with get, set
        abstract ``toBlock``: BabylonjsBindings.StringEnums.FlowGraphBlockNames option with get, set
        abstract ``defaultValue``: obj option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_Event =
        abstract ``id``: string option with get, set
        abstract ``values``: InlineObject749f47aaa0bfObject option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_Node =
        abstract ``declaration``: float with get, set
        abstract ``values``: InlineObject0c999b4cb06bObject option with get, set
        abstract ``flows``: InlineObject08fece736369Object option with get, set
        abstract ``configuration``: InlineObject4794d27e06d6Object option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IKHRInteractivity_Graph =
        abstract ``types``: ResizeArray<GLTF2IKHRInteractivity_Type> option with get, set
        abstract ``variables``: ResizeArray<GLTF2IKHRInteractivity_Variable> option with get, set
        abstract ``events``: ResizeArray<GLTF2IKHRInteractivity_Event> option with get, set
        abstract ``declarations``: ResizeArray<GLTF2IKHRInteractivity_Declaration> option with get, set
        abstract ``nodes``: ResizeArray<GLTF2IKHRInteractivity_Node> option with get, set

    /// Function-valued GLTF2LoaderExtension.onLoading property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionOnLoadingCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued GLTF2LoaderExtension.onReady property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionOnReadyCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued GLTF2LoaderExtension.loadSceneAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadSceneAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``scene``: IScene -> JS.Promise<unit> option

    /// Function-valued GLTF2LoaderExtension.loadNodeAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadNodeAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``node``: GLTFNode * ``assign``: System.Action<BabylonjsBindings.SimpleClasses.TransformNode> -> JS.Promise<BabylonjsBindings.SimpleClasses.TransformNode> option

    /// Function-valued GLTF2LoaderExtension.loadCameraAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadCameraAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``camera``: ICamera * ``assign``: System.Action<BabylonjsBindings.SimpleClasses.Camera> -> JS.Promise<BabylonjsBindings.SimpleClasses.Camera> option

    /// Function-valued GLTF2LoaderExtension._loadVertexDataAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadVertexDataAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``primitive``: IMeshPrimitive * ``babylonMesh``: BabylonjsBindings.SimpleClasses.Mesh -> JS.Promise<BabylonjsBindings.SimpleClasses.Geometry> option

    /// Function-valued GLTF2LoaderExtension._loadMeshPrimitiveAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadMeshPrimitiveAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``name``: string * ``node``: GLTFNode * ``mesh``: IMesh * ``primitive``: IMeshPrimitive * ``assign``: System.Action<BabylonjsBindings.SimpleClasses.AbstractMesh> -> JS.Promise<BabylonjsBindings.SimpleClasses.AbstractMesh> option

    /// Function-valued GLTF2LoaderExtension._loadMaterialAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadMaterialAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``material``: IMaterial * ``babylonMesh``: BabylonjsBindings.SimpleClasses.Mesh option * ``babylonDrawMode``: float * ``assign``: System.Action<BabylonjsBindings.SimpleClasses.Material> -> JS.Promise<BabylonjsBindings.SimpleClasses.Material> option

    /// Function-valued GLTF2LoaderExtension.createMaterial property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionCreateMaterialCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``material``: IMaterial * ``babylonDrawMode``: float -> BabylonjsBindings.SimpleClasses.Material option

    /// Function-valued GLTF2LoaderExtension.loadMaterialPropertiesAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadMaterialPropertiesAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``material``: IMaterial * ``babylonMaterial``: BabylonjsBindings.SimpleClasses.Material -> JS.Promise<unit> option

    /// Function-valued GLTF2LoaderExtension.loadTextureInfoAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadTextureInfoAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``textureInfo``: ITextureInfo * ``assign``: System.Action<BabylonjsBindings.SimpleClasses.BaseTexture> -> JS.Promise<BabylonjsBindings.SimpleClasses.BaseTexture> option

    /// Function-valued GLTF2LoaderExtension._loadTextureAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadTextureAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``texture``: ITexture * ``assign``: System.Action<BabylonjsBindings.SimpleClasses.BaseTexture> -> JS.Promise<BabylonjsBindings.SimpleClasses.BaseTexture> option

    /// Function-valued GLTF2LoaderExtension.loadAnimationAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadAnimationAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``animation``: IAnimation -> JS.Promise<BabylonjsBindings.SimpleClasses.AnimationGroup> option

    /// Function-valued GLTF2LoaderExtension._loadAnimationChannelAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadAnimationChannelAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``animationContext``: string * ``animation``: IAnimation * ``channel``: IAnimationChannel * ``onLoad``: System.Action<IAnimatable, BabylonjsBindings.SimpleClasses.Animation> -> JS.Promise<unit> option

    /// Function-valued GLTF2LoaderExtension._loadSkinAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadSkinAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``node``: GLTFNode * ``skin``: ISkin -> JS.Promise<unit> option

    /// Function-valued GLTF2LoaderExtension._loadUriAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadUriAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``property``: GLTF2IProperty * ``uri``: string -> JS.Promise<JS.ArrayBufferView> option

    /// Function-valued GLTF2LoaderExtension.loadBufferViewAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadBufferViewAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``bufferView``: IBufferView -> JS.Promise<JS.ArrayBufferView> option

    /// Function-valued GLTF2LoaderExtension.loadBufferAsync property.
    [<AllowNullLiteral>]
    type GLTF2LoaderExtensionLoadBufferAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: string * ``buffer``: IBuffer * ``byteOffset``: float * ``byteLength``: float -> JS.Promise<JS.ArrayBufferView> option

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderExtension
    [<AllowNullLiteral>]
    type GLTF2LoaderExtension =
        inherit GLTFFileLoaderExtension
        inherit IDisposable
        abstract ``onLoading``: GLTF2LoaderExtensionOnLoadingCallback option with get, set
        abstract ``onReady``: GLTF2LoaderExtensionOnReadyCallback option with get, set
        abstract ``loadSceneAsync``: GLTF2LoaderExtensionLoadSceneAsyncCallback option with get, set
        abstract ``loadNodeAsync``: GLTF2LoaderExtensionLoadNodeAsyncCallback option with get, set
        abstract ``loadCameraAsync``: GLTF2LoaderExtensionLoadCameraAsyncCallback option with get, set
        abstract ``_loadVertexDataAsync``: GLTF2LoaderExtensionLoadVertexDataAsyncCallback option with get, set
        abstract ``_loadMeshPrimitiveAsync``: GLTF2LoaderExtensionLoadMeshPrimitiveAsyncCallback option with get, set
        abstract ``_loadMaterialAsync``: GLTF2LoaderExtensionLoadMaterialAsyncCallback option with get, set
        abstract ``createMaterial``: GLTF2LoaderExtensionCreateMaterialCallback option with get, set
        abstract ``loadMaterialPropertiesAsync``: GLTF2LoaderExtensionLoadMaterialPropertiesAsyncCallback option with get, set
        abstract ``loadTextureInfoAsync``: GLTF2LoaderExtensionLoadTextureInfoAsyncCallback option with get, set
        abstract ``_loadTextureAsync``: GLTF2LoaderExtensionLoadTextureAsyncCallback option with get, set
        abstract ``loadAnimationAsync``: GLTF2LoaderExtensionLoadAnimationAsyncCallback option with get, set
        abstract ``_loadAnimationChannelAsync``: GLTF2LoaderExtensionLoadAnimationChannelAsyncCallback option with get, set
        abstract ``_loadSkinAsync``: GLTF2LoaderExtensionLoadSkinAsyncCallback option with get, set
        abstract ``_loadUriAsync``: GLTF2LoaderExtensionLoadUriAsyncCallback option with get, set
        abstract ``loadBufferViewAsync``: GLTF2LoaderExtensionLoadBufferViewAsyncCallback option with get, set
        abstract ``loadBufferAsync``: GLTF2LoaderExtensionLoadBufferAsyncCallback option with get, set

    /// Function-valued IGLTFToFlowGraphMapping.validation property.
    [<AllowNullLiteral>]
    type IGLTFToFlowGraphMappingValidationCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``gltfBlock``: GLTF2IKHRInteractivity_Node * ``interactivityGraph``: GLTF2IKHRInteractivity_Graph * ?``glTFObject``: IGLTF -> InlineObject4e409eaefbb8Object

    /// Function-valued IGLTFToFlowGraphMapping.extraProcessor property.
    [<AllowNullLiteral>]
    type IGLTFToFlowGraphMappingExtraProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``gltfBlock``: GLTF2IKHRInteractivity_Node * ``declaration``: GLTF2IKHRInteractivity_Declaration * ``mapping``: IGLTFToFlowGraphMapping * ``parser``: BabylonjsBindings.SimpleClasses.InteractivityGraphToFlowGraphParser * ``serializedObjects``: ResizeArray<ISerializedFlowGraphBlock> * ``context``: ISerializedFlowGraphContext * ?``globalGLTF``: IGLTF -> ResizeArray<ISerializedFlowGraphBlock>

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/declarationMapper
    [<AllowNullLiteral>]
    type IGLTFToFlowGraphMapping =
        abstract ``blocks``: ResizeArray<U2<BabylonjsBindings.StringEnums.FlowGraphBlockNames, string>> with get, set
        abstract ``inputs``: InlineObjectb50b2a1c7176Object option with get, set
        abstract ``outputs``: InlineObject5807e9eb1367Object option with get, set
        abstract ``configuration``: InlineObject5bbc2f1fb479Object option with get, set
        abstract ``typeToTypeMapping``: InlineObject5bbc2f1fb479Object option with get, set
        abstract ``interBlockConnectors``: ResizeArray<InlineObject298705b65dd9Object> option with get, set
        abstract ``validation``: IGLTFToFlowGraphMappingValidationCallback option with get, set
        abstract ``extraProcessor``: IGLTFToFlowGraphMappingExtraProcessorCallback option with get, set

    /// Exact one-argument JavaScript constructor surface.
    [<AllowNullLiteral>]
    type BrowserConstructor<'TArgument, 'TResult> =
        [<Emit("new $0($1)")>] abstract Create: argument: 'TArgument -> 'TResult

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectcef94c628823Object =
        abstract ``generator``: string with get, set
        abstract ``hasAnimations``: bool with get, set
        abstract ``hasDefaultScene``: bool with get, set
        abstract ``hasMaterials``: bool with get, set
        abstract ``hasMorphTargets``: bool with get, set
        abstract ``hasSkins``: bool with get, set
        abstract ``hasTextures``: bool with get, set
        abstract ``maxAttributesUsed``: float with get, set
        abstract ``primitivesCount``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject833fbd107350Object =
        abstract ``messages``: ResizeArray<string> with get, set
        abstract ``numErrors``: float with get, set
        abstract ``numHints``: float with get, set
        abstract ``numInfos``: float with get, set
        abstract ``numWarnings``: float with get, set
        abstract ``truncated``: bool with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type LoaderExtensionOptionBag =
        inherit BrowserRecord<string, obj>
        abstract ``enabled``: bool option with get, set

    /// babylonjs-gltf2interface/babylon.glTF2Interface
    [<AllowNullLiteral>]
    type GLTF2IGLTFValidationResults =
        abstract ``info``: InlineObjectcef94c628823Object with get, set
        abstract ``issues``: InlineObject833fbd107350Object with get, set
        abstract ``mimeType``: string with get, set
        abstract ``uri``: string with get, set
        abstract ``validatedAt``: string with get, set
        abstract ``validatorVersion``: string with get, set

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    [<AllowNullLiteral>]
    type GLTFLoaderExtensionOptions =
        inherit BrowserRecord<string, BrowserRecord<string, obj> option>

    /// @babylonjs/loaders/glTF/2.0/materialLoadingAdapter
    [<AllowNullLiteral>]
    type IMaterialLoadingAdapter =
        abstract ``material``: BabylonjsBindings.SimpleClasses.Material with get
        abstract ``finalizeAsync``: ``loader``: BabylonjsBindings.SimpleClasses.GLTF2Loader -> JS.Promise<unit>
        abstract ``isUnlit``: bool with get, set
        abstract ``backFaceCulling``: bool with get, set
        abstract ``twoSidedLighting``: bool with get, set
        abstract ``alphaCutOff``: float with get, set
        abstract ``useAlphaFromBaseColorTexture``: bool with get, set
        abstract ``transparencyAsAlphaCoverage``: bool with get, set
        abstract ``baseColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``baseColorTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``baseDiffuseRoughness``: float with get, set
        abstract ``baseDiffuseRoughnessTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``baseMetalness``: float with get, set
        abstract ``baseMetalnessTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``useRoughnessFromMetallicTextureGreen``: bool with get, set
        abstract ``useMetallicFromMetallicTextureBlue``: bool with get, set
        abstract ``enableSpecularEdgeColor``: ?``enableEdgeColor``: bool -> unit
        abstract ``configureSpecularGlossiness``: unit -> unit
        abstract ``specularWeight``: float with get, set
        abstract ``specularWeightTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``specularColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``specularColorTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``specularRoughness``: float with get, set
        abstract ``specularRoughnessTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``specularIor``: float with get, set
        abstract ``glossiness``: float with get, set
        abstract ``emissionColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``emissionLuminance``: float with get, set
        abstract ``emissionColorTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``ambientOcclusionTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``ambientOcclusionTextureStrength``: float with get, set
        abstract ``configureCoat``: unit -> unit
        abstract ``coatWeight``: float with get, set
        abstract ``coatWeightTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``coatColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``coatColorTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``coatRoughness``: float with get, set
        abstract ``coatRoughnessTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``coatIor``: float with get, set
        abstract ``coatDarkening``: float with get, set
        abstract ``coatDarkeningTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``coatRoughnessAnisotropy``: float with get, set
        abstract ``geometryCoatTangentAngle``: float with get, set
        abstract ``geometryCoatTangentTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``transmissionWeight``: float with get, set
        abstract ``transmissionWeightTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``transmissionDepth``: float with get, set
        abstract ``transmissionColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``transmissionScatter``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``transmissionScatterTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``transmissionScatterAnisotropy``: float with get, set
        abstract ``transmissionDispersionAbbeNumber``: float with get, set
        abstract ``transmissionDispersionScale``: float with get, set
        abstract ``refractionBackgroundTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``configureTransmission``: unit -> unit
        abstract ``configureVolume``: unit -> unit
        abstract ``geometryThinWalled``: bool with get, set
        abstract ``volumeThicknessTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``volumeThickness``: float with get, set
        abstract ``configureSubsurface``: unit -> unit
        abstract ``subsurfaceWeight``: float with get, set
        abstract ``subsurfaceWeightTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``subsurfaceColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``subsurfaceColorTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``diffuseTransmissionTint``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``diffuseTransmissionTintTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``subsurfaceRadius``: float with get, set
        abstract ``subsurfaceRadiusScale``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``subsurfaceScatterAnisotropy``: float with get, set
        abstract ``isTranslucent``: unit -> bool
        abstract ``configureFuzz``: unit -> unit
        abstract ``fuzzWeight``: float with get, set
        abstract ``fuzzWeightTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``fuzzColor``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``fuzzColorTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``fuzzRoughness``: float with get, set
        abstract ``fuzzRoughnessTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``specularRoughnessAnisotropy``: float with get, set
        abstract ``geometryTangentAngle``: float with get, set
        abstract ``geometryTangentTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``configureGltfStyleAnisotropy``: ?``useGltfStyle``: bool -> unit
        abstract ``thinFilmWeight``: float with get, set
        abstract ``thinFilmIor``: float with get, set
        abstract ``thinFilmThicknessMinimum``: float with get, set
        abstract ``thinFilmThicknessMaximum``: float with get, set
        abstract ``thinFilmWeightTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``thinFilmThicknessTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``unlit``: bool with get, set
        abstract ``geometryOpacity``: float with get, set
        abstract ``geometryNormalTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``setNormalMapInversions``: ``invertX``: bool * ``invertY``: bool -> unit
        abstract ``geometryCoatNormalTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option with get, set
        abstract ``geometryCoatNormalTextureScale``: float with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/transmissionHelper
    [<AllowNullLiteral>]
    type ITransmissionHelperHolder =
        abstract ``_transmissionHelper``: BabylonjsBindings.SimpleClasses.TransmissionHelper option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoader.pure
    [<AllowNullLiteral>]
    type IWithMetadata =
        abstract ``metadata``: obj with get, set
        abstract ``_internalMetadata``: obj with get, set

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type SceneLoaderPluginOptions =
        inherit BrowserRecord<string, BrowserRecord<string, obj> option>

    /// Function-valued ISceneLoaderOptions.onProgress property.
    [<AllowNullLiteral>]
    type ISceneLoaderOptionsOnProgressCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``event``: ISceneLoaderProgressEvent -> unit

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderOptions =
        abstract ``rootUrl``: string option with get, set
        abstract ``onProgress``: ISceneLoaderOptionsOnProgressCallback option with get, set
        abstract ``pluginExtension``: string option with get, set
        abstract ``name``: string option with get, set
        abstract ``pluginOptions``: BrowserRecord<string, LoaderExtensionOptionBag option> option with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/transmissionHelper
    [<AllowNullLiteral>]
    type ITransmissionHelperMaterialImpl =
        abstract ``materialClass``: BabylonjsBindings.SimpleClasses.MaterialStatic with get, set
        abstract ``adapterClass``: BrowserConstructor<BabylonjsBindings.SimpleClasses.Material, IMaterialLoadingAdapter> with get, set

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type AppendOptions =
        inherit ISceneLoaderOptions

    /// Function-valued ImportAnimationsOptions.targetConverter property.
    [<AllowNullLiteral>]
    type ImportAnimationsOptionsTargetConverterCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``target``: obj -> obj

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ImportAnimationsOptions =
        inherit ISceneLoaderOptions
        abstract ``overwriteAnimations``: bool option with get, set
        abstract ``animationGroupLoadingMode``: BabylonjsBindings.Enums.SceneLoaderAnimationGroupLoadingMode option with get, set
        abstract ``targetConverter``: ImportAnimationsOptionsTargetConverterCallback option with get, set

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ImportMeshOptions =
        inherit ISceneLoaderOptions
        abstract ``meshNames``: U2<string, System.Collections.Generic.IReadOnlyList<string>> option with get, set

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type LoadAssetContainerOptions =
        inherit ISceneLoaderOptions

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type LoadOptions =
        inherit ISceneLoaderOptions

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderPluginFactory =
        inherit ISceneLoaderPluginMetadata
        abstract ``createPlugin``: ``options``: SceneLoaderPluginOptions -> U3<ISceneLoaderPlugin, ISceneLoaderPluginAsync, JS.Promise<U2<ISceneLoaderPlugin, ISceneLoaderPluginAsync>>>

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type SceneLoaderSyncPlugin =
        inherit BabylonjsBindings.SimpleInterfaces.ISceneLoaderPlugin
        abstract ``onDisposeObservable``: BabylonjsBindings.SimpleClasses.Observable<unit> option with get

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type SceneLoaderAsyncPlugin =
        inherit BabylonjsBindings.SimpleInterfaces.ISceneLoaderPluginAsync
        abstract ``onDisposeObservable``: BabylonjsBindings.SimpleClasses.Observable<unit> option with get

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type IRegisteredPlugin =
        abstract ``plugin``: U2<U2<SceneLoaderSyncPlugin, SceneLoaderAsyncPlugin>, ISceneLoaderPluginFactory> with get, set
        abstract ``isBinary``: bool with get, set
        abstract ``mimeType``: string option with get, set
