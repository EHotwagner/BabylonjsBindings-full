// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after variable review, compile, import, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact dependency-closed variables and constants exported by Babylon.js 9.19.0.
module SimpleVariables =

    /// Inline object shape of _AudioAnalyzerDefaults.
    [<AllowNullLiteral>]
    type VariableShape__AudioAnalyzerDefaults =
        abstract ``fftSize``: BabylonjsBindings.Enums.AudioAnalyzerFFTSizeType with get
        abstract ``minDecibels``: float with get
        abstract ``maxDecibels``: float with get
        abstract ``smoothing``: float with get

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractAudioAnalyzer
    [<Import("_AudioAnalyzerDefaults", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractAudioAnalyzer.js")>]
    let ``_AudioAnalyzerDefaults``: VariableShape__AudioAnalyzerDefaults = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("_BabylonLoaderRegistered", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``_BabylonLoaderRegistered``: bool = jsNative

    /// @babylonjs/core/Helpers/sceneHelpers.pure
    [<Import("_forceSceneHelpersToBundle", "@babylonjs/core/Helpers/sceneHelpers.pure.js")>]
    let ``_forceSceneHelpersToBundle``: bool = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.transformFeedback.pure
    [<Import("_forceTransformFeedbackToBundle", "@babylonjs/core/Engines/Extensions/engine.transformFeedback.pure.js")>]
    let ``_forceTransformFeedbackToBundle``: bool = jsNative

    /// Inline callable object shape used by _injectLTSFileTools.
    [<AllowNullLiteral>]
    type VariableInline__injectLTSFileTools_Parameter3 =
        abstract ``DefaultRetryStrategy``: obj with get, set
        abstract ``BaseUrl``: obj with get, set
        abstract ``CorsBehavior``: obj with get, set
        abstract ``PreprocessUrl``: obj with get, set
        abstract ``CleanUrl``: obj with get, set

    /// Inline callable object shape used by _injectLTSFileTools.
    [<AllowNullLiteral>]
    type VariableInline__injectLTSFileTools_Parameter10_Parameter2 =
        abstract ``crossOrigin``: string option with get, set

    /// Callable shape of _injectLTSFileTools.
    [<AllowNullLiteral>]
    type VariableFunction__injectLTSFileTools =
        [<Emit("$0($1...)")>] abstract Invoke: ``DecodeBase64UrlToBinary``: System.Func<string, JS.ArrayBuffer> * ``DecodeBase64UrlToString``: System.Func<string, string> * ``FileToolsOptions``: VariableInline__injectLTSFileTools_Parameter3 * ``IsBase64DataUrl``: System.Func<string, bool> * ``IsFileURL``: System.Func<bool> * ``LoadFile``: System.Func<U2<string, Browser.Types.File>, System.Action<U2<string, JS.ArrayBuffer>, string option>, System.Action<Browser.Types.ProgressEvent> option, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, bool option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest option, BabylonjsBindings.SimpleClasses.LoadFileError option> option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest> option, BabylonjsBindings.SimpleInterfaces.IFileRequest> * ``LoadImage``: System.Func<U4<string, JS.ArrayBuffer, JS.ArrayBufferView, Browser.Types.Blob>, System.Action<U2<Browser.Types.HTMLImageElement, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap>>, System.Action<string option, obj option>, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, string option, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmapOptions option, Browser.Types.HTMLImageElement option> * ``ReadFile``: System.Func<Browser.Types.File, System.Action<obj>, System.Func<Browser.Types.ProgressEvent, obj> option, bool option, System.Action<BabylonjsBindings.SimpleClasses.ReadFileError> option, BabylonjsBindings.SimpleInterfaces.IFileRequest> * ``RequestFile``: System.Func<string, System.Action<U2<string, JS.ArrayBuffer>, BabylonjsBindings.SimpleClasses.WebRequest option>, System.Action<Browser.Types.ProgressEvent> option, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, bool option, System.Action<BabylonjsBindings.SimpleClasses.RequestFileError> option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest> option, BabylonjsBindings.SimpleInterfaces.IFileRequest> * ``SetCorsBehavior``: System.Action<U2<string, ResizeArray<string>>, VariableInline__injectLTSFileTools_Parameter10_Parameter2> -> unit

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("_injectLTSFileTools", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``_injectLTSFileTools``: VariableFunction__injectLTSFileTools = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<Import("_IsMacPlatform", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``_IsMacPlatform``: bool = jsNative

    /// Inline object shape of _SpatialAudioDefaults.
    [<AllowNullLiteral>]
    type VariableShape__SpatialAudioDefaults =
        abstract ``coneInnerAngle``: float with get
        abstract ``coneOuterAngle``: float with get
        abstract ``coneOuterVolume``: float with get
        abstract ``distanceModel``: BabylonjsBindings.SimpleInterfaces.BrowserDistanceModelType with get
        abstract ``maxDistance``: float with get
        abstract ``minDistance``: float with get
        abstract ``orientation``: BabylonjsBindings.SimpleClasses.Vector3 with get
        abstract ``panningEnabled``: bool with get
        abstract ``panningModel``: BabylonjsBindings.SimpleInterfaces.BrowserPanningModelType with get
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get
        abstract ``rolloffFactor``: float with get
        abstract ``rotation``: BabylonjsBindings.SimpleClasses.Vector3 with get
        abstract ``rotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion with get

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudio
    [<Import("_SpatialAudioDefaults", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudio.js")>]
    let ``_SpatialAudioDefaults``: VariableShape__SpatialAudioDefaults = jsNative

    /// Inline object shape of _SpatialAudioListenerDefaults.
    [<AllowNullLiteral>]
    type VariableShape__SpatialAudioListenerDefaults =
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get
        abstract ``rotation``: BabylonjsBindings.SimpleClasses.Vector3 with get
        abstract ``rotationQuaternion``: BabylonjsBindings.SimpleClasses.Quaternion with get

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudioListener
    [<Import("_SpatialAudioListenerDefaults", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudioListener.js")>]
    let ``_SpatialAudioListenerDefaults``: VariableShape__SpatialAudioListenerDefaults = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<Import("_StaticOffsetValueColor3", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``_StaticOffsetValueColor3``: BabylonjsBindings.SimpleClasses.DeepImmutableColor3 = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<Import("_StaticOffsetValueColor4", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``_StaticOffsetValueColor4``: BabylonjsBindings.SimpleClasses.DeepImmutableColor4 = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<Import("_StaticOffsetValueQuaternion", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``_StaticOffsetValueQuaternion``: BabylonjsBindings.SimpleClasses.DeepImmutableQuaternion = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<Import("_StaticOffsetValueSize", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``_StaticOffsetValueSize``: BabylonjsBindings.SimpleClasses.DeepImmutableSize = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<Import("_StaticOffsetValueVector2", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``_StaticOffsetValueVector2``: BabylonjsBindings.SimpleClasses.DeepImmutableVector2 = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<Import("_StaticOffsetValueVector3", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``_StaticOffsetValueVector3``: BabylonjsBindings.SimpleClasses.DeepImmutableVector3 = jsNative

    /// Inline object shape of _StereoAudioDefaults.
    [<AllowNullLiteral>]
    type VariableShape__StereoAudioDefaults =
        abstract ``pan``: float with get

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio
    [<Import("_StereoAudioDefaults", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio.js")>]
    let ``_StereoAudioDefaults``: VariableShape__StereoAudioDefaults = jsNative

    /// Inline object shape of _VolumeAudioDefaults.
    [<AllowNullLiteral>]
    type VariableShape__VolumeAudioDefaults =
        abstract ``volume``: float with get

    /// @babylonjs/core/AudioV2/abstractAudio/subNodes/volumeAudioSubNode
    [<Import("_VolumeAudioDefaults", "@babylonjs/core/AudioV2/abstractAudio/subNodes/volumeAudioSubNode.js")>]
    let ``_VolumeAudioDefaults``: VariableShape__VolumeAudioDefaults = jsNative

    /// Inline object shape of anaglyphPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_anaglyphPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/anaglyph.fragment
    [<Import("anaglyphPixelShader", "@babylonjs/core/Shaders/anaglyph.fragment.js")>]
    let ``anaglyphPixelShader``: VariableShape_anaglyphPixelShader = jsNative

    /// Inline object shape of anaglyphPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_anaglyphPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/anaglyph.fragment
    [<Import("anaglyphPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/anaglyph.fragment.js")>]
    let ``anaglyphPixelShaderWGSL``: VariableShape_anaglyphPixelShaderWGSL = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<Import("AnimationCreateFromSnippetAsync", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationCreateFromSnippetAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_AnimationParseFromSnippetAsync = jsNative

    /// Inline object shape of areaLightTextureProcessingPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_areaLightTextureProcessingPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/areaLightTextureProcessing.fragment
    [<Import("areaLightTextureProcessingPixelShader", "@babylonjs/core/Shaders/areaLightTextureProcessing.fragment.js")>]
    let ``areaLightTextureProcessingPixelShader``: VariableShape_areaLightTextureProcessingPixelShader = jsNative

    /// Inline object shape of areaLightTextureProcessingPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_areaLightTextureProcessingPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/areaLightTextureProcessing.fragment
    [<Import("areaLightTextureProcessingPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/areaLightTextureProcessing.fragment.js")>]
    let ``areaLightTextureProcessingPixelShaderWGSL``: VariableShape_areaLightTextureProcessingPixelShaderWGSL = jsNative

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    [<Import("backbufferColorTextureHandle", "@babylonjs/core/FrameGraph/frameGraphTypes.js")>]
    let ``backbufferColorTextureHandle``: BabylonjsBindings.TypeAliases.FrameGraphTextureHandle = jsNative

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    [<Import("backbufferDepthStencilTextureHandle", "@babylonjs/core/FrameGraph/frameGraphTypes.js")>]
    let ``backbufferDepthStencilTextureHandle``: BabylonjsBindings.TypeAliases.FrameGraphTextureHandle = jsNative

    /// Inline object shape of backgroundPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_backgroundPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/background.fragment
    [<Import("backgroundPixelShader", "@babylonjs/core/Shaders/background.fragment.js")>]
    let ``backgroundPixelShader``: VariableShape_backgroundPixelShader = jsNative

    /// Inline object shape of backgroundPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_backgroundPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/background.fragment
    [<Import("backgroundPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/background.fragment.js")>]
    let ``backgroundPixelShaderWGSL``: VariableShape_backgroundPixelShaderWGSL = jsNative

    /// Inline object shape of backgroundVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_backgroundVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/background.vertex
    [<Import("backgroundVertexShader", "@babylonjs/core/Shaders/background.vertex.js")>]
    let ``backgroundVertexShader``: VariableShape_backgroundVertexShader = jsNative

    /// Inline object shape of backgroundVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_backgroundVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/background.vertex
    [<Import("backgroundVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/background.vertex.js")>]
    let ``backgroundVertexShaderWGSL``: VariableShape_backgroundVertexShaderWGSL = jsNative

    /// Inline object shape of bakedVertexAnimation.
    [<AllowNullLiteral>]
    type VariableShape_bakedVertexAnimation =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/bakedVertexAnimation
    [<Import("bakedVertexAnimation", "@babylonjs/core/Shaders/ShadersInclude/bakedVertexAnimation.js")>]
    let ``bakedVertexAnimation``: VariableShape_bakedVertexAnimation = jsNative

    /// Inline object shape of bakedVertexAnimationDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_bakedVertexAnimationDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/bakedVertexAnimationDeclaration
    [<Import("bakedVertexAnimationDeclaration", "@babylonjs/core/Shaders/ShadersInclude/bakedVertexAnimationDeclaration.js")>]
    let ``bakedVertexAnimationDeclaration``: VariableShape_bakedVertexAnimationDeclaration = jsNative

    /// Inline object shape of bakedVertexAnimationDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bakedVertexAnimationDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/bakedVertexAnimationDeclaration
    [<Import("bakedVertexAnimationDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/bakedVertexAnimationDeclaration.js")>]
    let ``bakedVertexAnimationDeclarationWGSL``: VariableShape_bakedVertexAnimationDeclarationWGSL = jsNative

    /// Inline object shape of bakedVertexAnimationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bakedVertexAnimationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/bakedVertexAnimation
    [<Import("bakedVertexAnimationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/bakedVertexAnimation.js")>]
    let ``bakedVertexAnimationWGSL``: VariableShape_bakedVertexAnimationWGSL = jsNative

    /// Inline object shape of BasisTools.
    [<AllowNullLiteral>]
    type VariableShape_BasisTools =
        abstract ``JSModuleURL``: string with get, set
        abstract ``WasmModuleURL``: string with get, set
        abstract ``GetInternalFormatFromBasisFormat``: System.Func<float, BabylonjsBindings.SimpleClasses.AbstractEngine, float> with get, set
        abstract ``TranscodeAsync``: System.Func<U2<JS.ArrayBuffer, JS.ArrayBufferView>, BabylonjsBindings.SimpleClasses.BasisTranscodeConfiguration, JS.Promise<BabylonjsBindings.SimpleClasses.TranscodeResult>> with get, set
        abstract ``LoadTextureFromTranscodeResult``: System.Action<BabylonjsBindings.SimpleClasses.InternalTexture, BabylonjsBindings.SimpleClasses.TranscodeResult> with get, set

    /// @babylonjs/core/Misc/basis.pure
    [<Import("BasisTools", "@babylonjs/core/Misc/basis.pure.js")>]
    let ``BasisTools``: VariableShape_BasisTools = jsNative

    /// Inline object shape of BasisToolsOptions.
    [<AllowNullLiteral>]
    type VariableShape_BasisToolsOptions =
        abstract ``JSModuleURL``: string with get, set
        abstract ``WasmModuleURL``: string with get, set

    /// @babylonjs/core/Misc/basis.pure
    [<Import("BasisToolsOptions", "@babylonjs/core/Misc/basis.pure.js")>]
    let ``BasisToolsOptions``: VariableShape_BasisToolsOptions = jsNative

    /// Inline object shape of bilateralBlurPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_bilateralBlurPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/bilateralBlur.fragment
    [<Import("bilateralBlurPixelShader", "@babylonjs/core/Shaders/bilateralBlur.fragment.js")>]
    let ``bilateralBlurPixelShader``: VariableShape_bilateralBlurPixelShader = jsNative

    /// Inline object shape of bilateralBlurPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bilateralBlurPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/bilateralBlur.fragment
    [<Import("bilateralBlurPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/bilateralBlur.fragment.js")>]
    let ``bilateralBlurPixelShaderWGSL``: VariableShape_bilateralBlurPixelShaderWGSL = jsNative

    /// Inline object shape of bilateralBlurQualityPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_bilateralBlurQualityPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/bilateralBlurQuality.fragment
    [<Import("bilateralBlurQualityPixelShader", "@babylonjs/core/Shaders/bilateralBlurQuality.fragment.js")>]
    let ``bilateralBlurQualityPixelShader``: VariableShape_bilateralBlurQualityPixelShader = jsNative

    /// Inline object shape of bilateralBlurQualityPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bilateralBlurQualityPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/bilateralBlurQuality.fragment
    [<Import("bilateralBlurQualityPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/bilateralBlurQuality.fragment.js")>]
    let ``bilateralBlurQualityPixelShaderWGSL``: VariableShape_bilateralBlurQualityPixelShaderWGSL = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("BITMAP_SIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``BITMAP_SIZE``: float = jsNative

    /// Inline object shape of blackAndWhitePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_blackAndWhitePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/blackAndWhite.fragment
    [<Import("blackAndWhitePixelShader", "@babylonjs/core/Shaders/blackAndWhite.fragment.js")>]
    let ``blackAndWhitePixelShader``: VariableShape_blackAndWhitePixelShader = jsNative

    /// Inline object shape of blackAndWhitePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_blackAndWhitePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/blackAndWhite.fragment
    [<Import("blackAndWhitePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/blackAndWhite.fragment.js")>]
    let ``blackAndWhitePixelShaderWGSL``: VariableShape_blackAndWhitePixelShaderWGSL = jsNative

    /// Inline object shape of bloomMergePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_bloomMergePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/bloomMerge.fragment
    [<Import("bloomMergePixelShader", "@babylonjs/core/Shaders/bloomMerge.fragment.js")>]
    let ``bloomMergePixelShader``: VariableShape_bloomMergePixelShader = jsNative

    /// Inline object shape of bloomMergePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bloomMergePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/bloomMerge.fragment
    [<Import("bloomMergePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/bloomMerge.fragment.js")>]
    let ``bloomMergePixelShaderWGSL``: VariableShape_bloomMergePixelShaderWGSL = jsNative

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<Import("BodyJointParentIndex", "@babylonjs/core/XR/features/WebXRBodyTracking.pure.js")>]
    let ``BodyJointParentIndex``: ResizeArray<float> = jsNative

    /// Inline object shape of bonesDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_bonesDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/bonesDeclaration
    [<Import("bonesDeclaration", "@babylonjs/core/Shaders/ShadersInclude/bonesDeclaration.js")>]
    let ``bonesDeclaration``: VariableShape_bonesDeclaration = jsNative

    /// Inline object shape of bonesDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bonesDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/bonesDeclaration
    [<Import("bonesDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/bonesDeclaration.js")>]
    let ``bonesDeclarationWGSL``: VariableShape_bonesDeclarationWGSL = jsNative

    /// Inline object shape of bonesVertex.
    [<AllowNullLiteral>]
    type VariableShape_bonesVertex =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/bonesVertex
    [<Import("bonesVertex", "@babylonjs/core/Shaders/ShadersInclude/bonesVertex.js")>]
    let ``bonesVertex``: VariableShape_bonesVertex = jsNative

    /// Inline object shape of bonesVertexWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bonesVertexWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/bonesVertex
    [<Import("bonesVertexWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/bonesVertex.js")>]
    let ``bonesVertexWGSL``: VariableShape_bonesVertexWGSL = jsNative

    /// Inline object shape of boundingBoxRendererPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_boundingBoxRendererPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/boundingBoxRenderer.fragment
    [<Import("boundingBoxRendererPixelShader", "@babylonjs/core/Shaders/boundingBoxRenderer.fragment.js")>]
    let ``boundingBoxRendererPixelShader``: VariableShape_boundingBoxRendererPixelShader = jsNative

    /// Inline object shape of boundingBoxRendererPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_boundingBoxRendererPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/boundingBoxRenderer.fragment
    [<Import("boundingBoxRendererPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/boundingBoxRenderer.fragment.js")>]
    let ``boundingBoxRendererPixelShaderWGSL``: VariableShape_boundingBoxRendererPixelShaderWGSL = jsNative

    /// Inline object shape of boundingBoxRendererVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_boundingBoxRendererVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/boundingBoxRenderer.vertex
    [<Import("boundingBoxRendererVertexShader", "@babylonjs/core/Shaders/boundingBoxRenderer.vertex.js")>]
    let ``boundingBoxRendererVertexShader``: VariableShape_boundingBoxRendererVertexShader = jsNative

    /// Inline object shape of boundingBoxRendererVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_boundingBoxRendererVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/boundingBoxRenderer.vertex
    [<Import("boundingBoxRendererVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/boundingBoxRenderer.vertex.js")>]
    let ``boundingBoxRendererVertexShaderWGSL``: VariableShape_boundingBoxRendererVertexShaderWGSL = jsNative

    /// Inline object shape of boundingInfoComputeShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_boundingInfoComputeShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/boundingInfo.compute
    [<Import("boundingInfoComputeShaderWGSL", "@babylonjs/core/ShadersWGSL/boundingInfo.compute.js")>]
    let ``boundingInfoComputeShaderWGSL``: VariableShape_boundingInfoComputeShaderWGSL = jsNative

    /// Inline object shape of BoxBuilder.
    [<AllowNullLiteral>]
    type VariableShape_BoxBuilder =
        abstract ``CreateBox``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateBox with get, set

    /// @babylonjs/core/Meshes/Builders/boxBuilder.pure
    [<Import("BoxBuilder", "@babylonjs/core/Meshes/Builders/boxBuilder.pure.js")>]
    let ``BoxBuilder``: VariableShape_BoxBuilder = jsNative

    /// Inline object shape of BRDFTextureTools.
    [<AllowNullLiteral>]
    type VariableShape_BRDFTextureTools =
        abstract ``GetEnvironmentBRDFTexture``: System.Func<BabylonjsBindings.SimpleClasses.Scene, BabylonjsBindings.SimpleClasses.BaseTexture> with get, set
        abstract ``GetEnvironmentFuzzBRDFTexture``: System.Func<BabylonjsBindings.SimpleClasses.Scene, BabylonjsBindings.SimpleClasses.BaseTexture> with get, set
        abstract ``GetOpenPBREnvironmentBRDFTexture``: System.Func<BabylonjsBindings.SimpleClasses.Scene, BabylonjsBindings.SimpleClasses.BaseTexture> with get, set

    /// @babylonjs/core/Misc/brdfTextureTools
    [<Import("BRDFTextureTools", "@babylonjs/core/Misc/brdfTextureTools.js")>]
    let ``BRDFTextureTools``: VariableShape_BRDFTextureTools = jsNative

    /// Inline object shape of bumpFragment.
    [<AllowNullLiteral>]
    type VariableShape_bumpFragment =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/bumpFragment
    [<Import("bumpFragment", "@babylonjs/core/Shaders/ShadersInclude/bumpFragment.js")>]
    let ``bumpFragment``: VariableShape_bumpFragment = jsNative

    /// Inline object shape of bumpFragmentFunctions.
    [<AllowNullLiteral>]
    type VariableShape_bumpFragmentFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/bumpFragmentFunctions
    [<Import("bumpFragmentFunctions", "@babylonjs/core/Shaders/ShadersInclude/bumpFragmentFunctions.js")>]
    let ``bumpFragmentFunctions``: VariableShape_bumpFragmentFunctions = jsNative

    /// Inline object shape of bumpFragmentFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bumpFragmentFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/bumpFragmentFunctions
    [<Import("bumpFragmentFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/bumpFragmentFunctions.js")>]
    let ``bumpFragmentFunctionsWGSL``: VariableShape_bumpFragmentFunctionsWGSL = jsNative

    /// Inline object shape of bumpFragmentMainFunctions.
    [<AllowNullLiteral>]
    type VariableShape_bumpFragmentMainFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/bumpFragmentMainFunctions
    [<Import("bumpFragmentMainFunctions", "@babylonjs/core/Shaders/ShadersInclude/bumpFragmentMainFunctions.js")>]
    let ``bumpFragmentMainFunctions``: VariableShape_bumpFragmentMainFunctions = jsNative

    /// Inline object shape of bumpFragmentMainFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bumpFragmentMainFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/bumpFragmentMainFunctions
    [<Import("bumpFragmentMainFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/bumpFragmentMainFunctions.js")>]
    let ``bumpFragmentMainFunctionsWGSL``: VariableShape_bumpFragmentMainFunctionsWGSL = jsNative

    /// Inline object shape of bumpFragmentWGSL.
    [<AllowNullLiteral>]
    type VariableShape_bumpFragmentWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/bumpFragment
    [<Import("bumpFragmentWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/bumpFragment.js")>]
    let ``bumpFragmentWGSL``: VariableShape_bumpFragmentWGSL = jsNative

    /// Nested inline object shape used by BVHFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_BVHFileLoaderMetadataProperty2ObjectProperty1Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserFalse with get

    /// Nested inline object shape used by BVHFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_BVHFileLoaderMetadataProperty2Object =
        abstract ``.bvh``: VariableShape_BVHFileLoaderMetadataProperty2ObjectProperty1Object with get

    /// Inline object shape of BVHFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_BVHFileLoaderMetadata =
        abstract ``name``: string with get
        abstract ``extensions``: VariableShape_BVHFileLoaderMetadataProperty2Object with get

    /// @babylonjs/loaders/BVH/bvhFileLoader.metadata
    [<Import("BVHFileLoaderMetadata", "@babylonjs/loaders/BVH/bvhFileLoader.metadata.js")>]
    let ``BVHFileLoaderMetadata``: VariableShape_BVHFileLoaderMetadata = jsNative

    /// Inline object shape of CameraInputTypes.
    [<AllowNullLiteral>]
    type VariableShape_CameraInputTypes =
        interface end

    /// @babylonjs/core/Cameras/cameraInputsManager
    [<Import("CameraInputTypes", "@babylonjs/core/Cameras/cameraInputsManager.js")>]
    let ``CameraInputTypes``: VariableShape_CameraInputTypes = jsNative

    /// Inline object shape of CapsuleBuilder.
    [<AllowNullLiteral>]
    type VariableShape_CapsuleBuilder =
        abstract ``CreateCapsule``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateCapsule with get, set

    /// @babylonjs/core/Meshes/Builders/capsuleBuilder.pure
    [<Import("CapsuleBuilder", "@babylonjs/core/Meshes/Builders/capsuleBuilder.pure.js")>]
    let ``CapsuleBuilder``: VariableShape_CapsuleBuilder = jsNative

    /// Inline object shape of chromaticAberrationPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_chromaticAberrationPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/chromaticAberration.fragment
    [<Import("chromaticAberrationPixelShader", "@babylonjs/core/Shaders/chromaticAberration.fragment.js")>]
    let ``chromaticAberrationPixelShader``: VariableShape_chromaticAberrationPixelShader = jsNative

    /// Inline object shape of chromaticAberrationPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_chromaticAberrationPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/chromaticAberration.fragment
    [<Import("chromaticAberrationPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/chromaticAberration.fragment.js")>]
    let ``chromaticAberrationPixelShaderWGSL``: VariableShape_chromaticAberrationPixelShaderWGSL = jsNative

    /// Inline object shape of circleOfConfusionPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_circleOfConfusionPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/circleOfConfusion.fragment
    [<Import("circleOfConfusionPixelShader", "@babylonjs/core/Shaders/circleOfConfusion.fragment.js")>]
    let ``circleOfConfusionPixelShader``: VariableShape_circleOfConfusionPixelShader = jsNative

    /// Inline object shape of circleOfConfusionPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_circleOfConfusionPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/circleOfConfusion.fragment
    [<Import("circleOfConfusionPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/circleOfConfusion.fragment.js")>]
    let ``circleOfConfusionPixelShaderWGSL``: VariableShape_circleOfConfusionPixelShaderWGSL = jsNative

    /// Inline object shape of clearQuadPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_clearQuadPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/clearQuad.fragment
    [<Import("clearQuadPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/clearQuad.fragment.js")>]
    let ``clearQuadPixelShaderWGSL``: VariableShape_clearQuadPixelShaderWGSL = jsNative

    /// Inline object shape of clearQuadVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_clearQuadVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/clearQuad.vertex
    [<Import("clearQuadVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/clearQuad.vertex.js")>]
    let ``clearQuadVertexShaderWGSL``: VariableShape_clearQuadVertexShaderWGSL = jsNative

    /// Inline object shape of clipPlaneFragment.
    [<AllowNullLiteral>]
    type VariableShape_clipPlaneFragment =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/clipPlaneFragment
    [<Import("clipPlaneFragment", "@babylonjs/core/Shaders/ShadersInclude/clipPlaneFragment.js")>]
    let ``clipPlaneFragment``: VariableShape_clipPlaneFragment = jsNative

    /// Inline object shape of clipPlaneFragmentDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_clipPlaneFragmentDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/clipPlaneFragmentDeclaration
    [<Import("clipPlaneFragmentDeclaration", "@babylonjs/core/Shaders/ShadersInclude/clipPlaneFragmentDeclaration.js")>]
    let ``clipPlaneFragmentDeclaration``: VariableShape_clipPlaneFragmentDeclaration = jsNative

    /// Inline object shape of clipPlaneFragmentDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_clipPlaneFragmentDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/clipPlaneFragmentDeclaration
    [<Import("clipPlaneFragmentDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/clipPlaneFragmentDeclaration.js")>]
    let ``clipPlaneFragmentDeclarationWGSL``: VariableShape_clipPlaneFragmentDeclarationWGSL = jsNative

    /// Inline object shape of clipPlaneFragmentWGSL.
    [<AllowNullLiteral>]
    type VariableShape_clipPlaneFragmentWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/clipPlaneFragment
    [<Import("clipPlaneFragmentWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/clipPlaneFragment.js")>]
    let ``clipPlaneFragmentWGSL``: VariableShape_clipPlaneFragmentWGSL = jsNative

    /// Inline object shape of clipPlaneVertex.
    [<AllowNullLiteral>]
    type VariableShape_clipPlaneVertex =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/clipPlaneVertex
    [<Import("clipPlaneVertex", "@babylonjs/core/Shaders/ShadersInclude/clipPlaneVertex.js")>]
    let ``clipPlaneVertex``: VariableShape_clipPlaneVertex = jsNative

    /// Inline object shape of clipPlaneVertexDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_clipPlaneVertexDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/clipPlaneVertexDeclaration
    [<Import("clipPlaneVertexDeclaration", "@babylonjs/core/Shaders/ShadersInclude/clipPlaneVertexDeclaration.js")>]
    let ``clipPlaneVertexDeclaration``: VariableShape_clipPlaneVertexDeclaration = jsNative

    /// Inline object shape of clipPlaneVertexDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_clipPlaneVertexDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/clipPlaneVertexDeclaration
    [<Import("clipPlaneVertexDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/clipPlaneVertexDeclaration.js")>]
    let ``clipPlaneVertexDeclarationWGSL``: VariableShape_clipPlaneVertexDeclarationWGSL = jsNative

    /// Inline object shape of clipPlaneVertexWGSL.
    [<AllowNullLiteral>]
    type VariableShape_clipPlaneVertexWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/clipPlaneVertex
    [<Import("clipPlaneVertexWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/clipPlaneVertex.js")>]
    let ``clipPlaneVertexWGSL``: VariableShape_clipPlaneVertexWGSL = jsNative

    /// Inline object shape of clusteredLightingFunctions.
    [<AllowNullLiteral>]
    type VariableShape_clusteredLightingFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/clusteredLightingFunctions
    [<Import("clusteredLightingFunctions", "@babylonjs/core/Shaders/ShadersInclude/clusteredLightingFunctions.js")>]
    let ``clusteredLightingFunctions``: VariableShape_clusteredLightingFunctions = jsNative

    /// Inline object shape of clusteredLightingFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_clusteredLightingFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/clusteredLightingFunctions
    [<Import("clusteredLightingFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/clusteredLightingFunctions.js")>]
    let ``clusteredLightingFunctionsWGSL``: VariableShape_clusteredLightingFunctionsWGSL = jsNative

    /// Inline object shape of colorCorrectionPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_colorCorrectionPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/colorCorrection.fragment
    [<Import("colorCorrectionPixelShader", "@babylonjs/core/Shaders/colorCorrection.fragment.js")>]
    let ``colorCorrectionPixelShader``: VariableShape_colorCorrectionPixelShader = jsNative

    /// Inline object shape of colorCorrectionPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_colorCorrectionPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/colorCorrection.fragment
    [<Import("colorCorrectionPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/colorCorrection.fragment.js")>]
    let ``colorCorrectionPixelShaderWGSL``: VariableShape_colorCorrectionPixelShaderWGSL = jsNative

    /// Inline object shape of colorPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_colorPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/color.fragment
    [<Import("colorPixelShader", "@babylonjs/core/Shaders/color.fragment.js")>]
    let ``colorPixelShader``: VariableShape_colorPixelShader = jsNative

    /// Inline object shape of colorPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_colorPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/color.fragment
    [<Import("colorPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/color.fragment.js")>]
    let ``colorPixelShaderWGSL``: VariableShape_colorPixelShaderWGSL = jsNative

    /// Inline object shape of colorVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_colorVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/color.vertex
    [<Import("colorVertexShader", "@babylonjs/core/Shaders/color.vertex.js")>]
    let ``colorVertexShader``: VariableShape_colorVertexShader = jsNative

    /// Inline object shape of colorVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_colorVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/color.vertex
    [<Import("colorVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/color.vertex.js")>]
    let ``colorVertexShaderWGSL``: VariableShape_colorVertexShaderWGSL = jsNative

    /// Inline object shape of CompatibilityOptions.
    [<AllowNullLiteral>]
    type VariableShape_CompatibilityOptions =
        abstract ``UseOpenGLOrientationForUV``: bool with get, set

    /// @babylonjs/core/Compat/compatibilityOptions
    [<Import("CompatibilityOptions", "@babylonjs/core/Compat/compatibilityOptions.js")>]
    let ``CompatibilityOptions``: VariableShape_CompatibilityOptions = jsNative

    /// Inline object shape of convolutionPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_convolutionPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/convolution.fragment
    [<Import("convolutionPixelShader", "@babylonjs/core/Shaders/convolution.fragment.js")>]
    let ``convolutionPixelShader``: VariableShape_convolutionPixelShader = jsNative

    /// Inline object shape of convolutionPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_convolutionPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/convolution.fragment
    [<Import("convolutionPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/convolution.fragment.js")>]
    let ``convolutionPixelShaderWGSL``: VariableShape_convolutionPixelShaderWGSL = jsNative

    /// Inline object shape of copyTexture3DLayerToTexturePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_copyTexture3DLayerToTexturePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/copyTexture3DLayerToTexture.fragment
    [<Import("copyTexture3DLayerToTexturePixelShader", "@babylonjs/core/Shaders/copyTexture3DLayerToTexture.fragment.js")>]
    let ``copyTexture3DLayerToTexturePixelShader``: VariableShape_copyTexture3DLayerToTexturePixelShader = jsNative

    /// Inline object shape of copyTexture3DLayerToTexturePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_copyTexture3DLayerToTexturePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/copyTexture3DLayerToTexture.fragment
    [<Import("copyTexture3DLayerToTexturePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/copyTexture3DLayerToTexture.fragment.js")>]
    let ``copyTexture3DLayerToTexturePixelShaderWGSL``: VariableShape_copyTexture3DLayerToTexturePixelShaderWGSL = jsNative

    /// Inline object shape of copyTextureToTexturePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_copyTextureToTexturePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/copyTextureToTexture.fragment
    [<Import("copyTextureToTexturePixelShader", "@babylonjs/core/Shaders/copyTextureToTexture.fragment.js")>]
    let ``copyTextureToTexturePixelShader``: VariableShape_copyTextureToTexturePixelShader = jsNative

    /// Inline object shape of copyTextureToTexturePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_copyTextureToTexturePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/copyTextureToTexture.fragment
    [<Import("copyTextureToTexturePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/copyTextureToTexture.fragment.js")>]
    let ``copyTextureToTexturePixelShaderWGSL``: VariableShape_copyTextureToTexturePixelShaderWGSL = jsNative

    /// Inline object shape of CopyTools.
    [<AllowNullLiteral>]
    type VariableShape_CopyTools =
        abstract ``GenerateBase64StringFromPixelData``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GenerateBase64StringFromPixelData with get, set
        abstract ``GenerateBase64StringFromTexture``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GenerateBase64StringFromTexture with get, set
        abstract ``GenerateBase64StringFromTextureAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GenerateBase64StringFromTextureAsync with get, set

    /// @babylonjs/core/Misc/copyTools
    [<Import("CopyTools", "@babylonjs/core/Misc/copyTools.js")>]
    let ``CopyTools``: VariableShape_CopyTools = jsNative

    /// Callable shape of createAndPreparePipelineContext.
    [<AllowNullLiteral>]
    type VariableFunction_createAndPreparePipelineContext =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: BabylonjsBindings.SimpleInterfaces.ICreateAndPreparePipelineContextOptions * ``createPipelineContext``: System.Func<BabylonjsBindings.SimpleInterfaces._IShaderProcessingContext option, BabylonjsBindings.SimpleInterfaces.IPipelineContext> * ``_preparePipelineContext``: System.Action<BabylonjsBindings.SimpleInterfaces.IPipelineContext, string, string, bool, string, string, obj, string option, ResizeArray<string> option, string, System.Action> * ``_executeWhenRenderingStateIsCompiled``: System.Action<BabylonjsBindings.SimpleInterfaces.IPipelineContext, System.Action> -> BabylonjsBindings.SimpleInterfaces.IPipelineContext

    /// @babylonjs/core/Materials/effect.functions
    [<Import("createAndPreparePipelineContext", "@babylonjs/core/Materials/effect.functions.js")>]
    let ``createAndPreparePipelineContext``: VariableFunction_createAndPreparePipelineContext = jsNative

    /// Inline object shape of CylinderBuilder.
    [<AllowNullLiteral>]
    type VariableShape_CylinderBuilder =
        abstract ``CreateCylinder``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateCylinder with get, set

    /// @babylonjs/core/Meshes/Builders/cylinderBuilder.pure
    [<Import("CylinderBuilder", "@babylonjs/core/Meshes/Builders/cylinderBuilder.pure.js")>]
    let ``CylinderBuilder``: VariableShape_CylinderBuilder = jsNative

    /// Inline object shape of DecalBuilder.
    [<AllowNullLiteral>]
    type VariableShape_DecalBuilder =
        abstract ``CreateDecal``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateDecal with get, set

    /// @babylonjs/core/Meshes/Builders/decalBuilder.pure
    [<Import("DecalBuilder", "@babylonjs/core/Meshes/Builders/decalBuilder.pure.js")>]
    let ``DecalBuilder``: VariableShape_DecalBuilder = jsNative

    /// Inline object shape of decalFragmentWGSL.
    [<AllowNullLiteral>]
    type VariableShape_decalFragmentWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/decalFragment
    [<Import("decalFragmentWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/decalFragment.js")>]
    let ``decalFragmentWGSL``: VariableShape_decalFragmentWGSL = jsNative

    /// Callable shape of Decode.
    [<AllowNullLiteral>]
    type VariableFunction_Decode =
        [<Emit("$0($1...)")>] abstract Invoke: ``buffer``: U2<JS.Uint8Array, JS.Uint16Array> -> string

    /// @babylonjs/core/Misc/stringTools
    [<Import("Decode", "@babylonjs/core/Misc/stringTools.js")>]
    let ``Decode``: VariableFunction_Decode = jsNative

    /// Callable shape of DecodeBase64ToBinary.
    [<AllowNullLiteral>]
    type VariableFunction_DecodeBase64ToBinary =
        [<Emit("$0($1...)")>] abstract Invoke: ``base64Data``: string -> JS.ArrayBuffer

    /// @babylonjs/core/Misc/stringTools
    [<Import("DecodeBase64ToBinary", "@babylonjs/core/Misc/stringTools.js")>]
    let ``DecodeBase64ToBinary``: VariableFunction_DecodeBase64ToBinary = jsNative

    /// Callable shape of DecodeBase64ToString.
    [<AllowNullLiteral>]
    type VariableFunction_DecodeBase64ToString =
        [<Emit("$0($1...)")>] abstract Invoke: ``base64Data``: string -> string

    /// @babylonjs/core/Misc/stringTools
    [<Import("DecodeBase64ToString", "@babylonjs/core/Misc/stringTools.js")>]
    let ``DecodeBase64ToString``: VariableFunction_DecodeBase64ToString = jsNative

    /// Callable shape of DecodeBase64UrlToString.
    [<AllowNullLiteral>]
    type VariableFunction_DecodeBase64UrlToString =
        [<Emit("$0($1...)")>] abstract Invoke: ``uri``: string -> string

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("DecodeBase64UrlToString", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``DecodeBase64UrlToString``: VariableFunction_DecodeBase64UrlToString = jsNative

    /// Inline object shape of defaultPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_defaultPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/default.fragment
    [<Import("defaultPixelShader", "@babylonjs/core/Shaders/default.fragment.js")>]
    let ``defaultPixelShader``: VariableShape_defaultPixelShader = jsNative

    /// Inline object shape of defaultPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_defaultPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/default.fragment
    [<Import("defaultPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/default.fragment.js")>]
    let ``defaultPixelShaderWGSL``: VariableShape_defaultPixelShaderWGSL = jsNative

    /// Inline object shape of defaultVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_defaultVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/default.vertex
    [<Import("defaultVertexShader", "@babylonjs/core/Shaders/default.vertex.js")>]
    let ``defaultVertexShader``: VariableShape_defaultVertexShader = jsNative

    /// Inline object shape of defaultVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_defaultVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/default.vertex
    [<Import("defaultVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/default.vertex.js")>]
    let ``defaultVertexShaderWGSL``: VariableShape_defaultVertexShaderWGSL = jsNative

    /// @babylonjs/core/XR/features/Layers/WebXRProjectionLayer
    [<Import("DefaultXRProjectionLayerInit", "@babylonjs/core/XR/features/Layers/WebXRProjectionLayer.js")>]
    let ``DefaultXRProjectionLayerInit``: BabylonjsBindings.SimpleInterfaces.BrowserXRProjectionLayerInit = jsNative

    /// Inline object shape of depthBoxBlurPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_depthBoxBlurPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/depthBoxBlur.fragment
    [<Import("depthBoxBlurPixelShader", "@babylonjs/core/Shaders/depthBoxBlur.fragment.js")>]
    let ``depthBoxBlurPixelShader``: VariableShape_depthBoxBlurPixelShader = jsNative

    /// Inline object shape of depthBoxBlurPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_depthBoxBlurPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/depthBoxBlur.fragment
    [<Import("depthBoxBlurPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/depthBoxBlur.fragment.js")>]
    let ``depthBoxBlurPixelShaderWGSL``: VariableShape_depthBoxBlurPixelShaderWGSL = jsNative

    /// Inline object shape of depthOfFieldMergePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_depthOfFieldMergePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/depthOfFieldMerge.fragment
    [<Import("depthOfFieldMergePixelShader", "@babylonjs/core/Shaders/depthOfFieldMerge.fragment.js")>]
    let ``depthOfFieldMergePixelShader``: VariableShape_depthOfFieldMergePixelShader = jsNative

    /// Inline object shape of depthOfFieldMergePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_depthOfFieldMergePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/depthOfFieldMerge.fragment
    [<Import("depthOfFieldMergePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/depthOfFieldMerge.fragment.js")>]
    let ``depthOfFieldMergePixelShaderWGSL``: VariableShape_depthOfFieldMergePixelShaderWGSL = jsNative

    /// Inline object shape of depthOfFieldPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_depthOfFieldPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/depthOfField.fragment
    [<Import("depthOfFieldPixelShader", "@babylonjs/core/Shaders/depthOfField.fragment.js")>]
    let ``depthOfFieldPixelShader``: VariableShape_depthOfFieldPixelShader = jsNative

    /// Inline object shape of depthPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_depthPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/depth.fragment
    [<Import("depthPixelShader", "@babylonjs/core/Shaders/depth.fragment.js")>]
    let ``depthPixelShader``: VariableShape_depthPixelShader = jsNative

    /// Inline object shape of depthPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_depthPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/depth.fragment
    [<Import("depthPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/depth.fragment.js")>]
    let ``depthPixelShaderWGSL``: VariableShape_depthPixelShaderWGSL = jsNative

    /// Inline object shape of depthPrePass.
    [<AllowNullLiteral>]
    type VariableShape_depthPrePass =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/depthPrePass
    [<Import("depthPrePass", "@babylonjs/core/Shaders/ShadersInclude/depthPrePass.js")>]
    let ``depthPrePass``: VariableShape_depthPrePass = jsNative

    /// Inline object shape of depthPrePassWGSL.
    [<AllowNullLiteral>]
    type VariableShape_depthPrePassWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/depthPrePass
    [<Import("depthPrePassWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/depthPrePass.js")>]
    let ``depthPrePassWGSL``: VariableShape_depthPrePassWGSL = jsNative

    /// Inline object shape of depthVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_depthVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/depth.vertex
    [<Import("depthVertexShader", "@babylonjs/core/Shaders/depth.vertex.js")>]
    let ``depthVertexShader``: VariableShape_depthVertexShader = jsNative

    /// Inline object shape of depthVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_depthVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/depth.vertex
    [<Import("depthVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/depth.vertex.js")>]
    let ``depthVertexShaderWGSL``: VariableShape_depthVertexShaderWGSL = jsNative

    /// Inline object shape of DiscBuilder.
    [<AllowNullLiteral>]
    type VariableShape_DiscBuilder =
        abstract ``CreateDisc``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateDisc with get, set

    /// @babylonjs/core/Meshes/Builders/discBuilder.pure
    [<Import("DiscBuilder", "@babylonjs/core/Meshes/Builders/discBuilder.pure.js")>]
    let ``DiscBuilder``: VariableShape_DiscBuilder = jsNative

    /// Inline object shape of displayPassPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_displayPassPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/displayPass.fragment
    [<Import("displayPassPixelShader", "@babylonjs/core/Shaders/displayPass.fragment.js")>]
    let ``displayPassPixelShader``: VariableShape_displayPassPixelShader = jsNative

    /// Inline object shape of displayPassPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_displayPassPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/displayPass.fragment
    [<Import("displayPassPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/displayPass.fragment.js")>]
    let ``displayPassPixelShaderWGSL``: VariableShape_displayPassPixelShaderWGSL = jsNative

    /// Inline object shape of DomManagement.
    [<AllowNullLiteral>]
    type VariableShape_DomManagement =
        abstract ``IsWindowObjectExist``: BabylonjsBindings.SimpleFunctions.FunctionBinding_IsWindowObjectExist with get, set
        abstract ``IsNavigatorAvailable``: BabylonjsBindings.SimpleFunctions.FunctionBinding_IsNavigatorAvailable with get, set
        abstract ``IsDocumentAvailable``: BabylonjsBindings.SimpleFunctions.FunctionBinding_IsDocumentAvailable with get, set
        abstract ``GetDOMTextContent``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetDOMTextContent with get, set

    /// @babylonjs/core/Misc/domManagement
    [<Import("DomManagement", "@babylonjs/core/Misc/domManagement.js")>]
    let ``DomManagement``: VariableShape_DomManagement = jsNative

    /// Inline object shape of DumpTools.
    [<AllowNullLiteral>]
    type VariableShape_DumpTools =
        abstract ``DumpData``: BabylonjsBindings.SimpleFunctions.FunctionBinding_DumpData with get, set
        abstract ``DumpDataAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_DumpDataAsync with get, set
        abstract ``DumpFramebuffer``: BabylonjsBindings.SimpleFunctions.FunctionBinding_DumpFramebuffer with get, set
        abstract ``Dispose``: BabylonjsBindings.SimpleFunctions.FunctionBinding_Dispose with get, set

    /// @babylonjs/core/Misc/dumpTools.pure
    [<Import("DumpTools", "@babylonjs/core/Misc/dumpTools.pure.js")>]
    let ``DumpTools``: VariableShape_DumpTools = jsNative

    /// Callable shape of EmptyGeneratorFunc.
    [<AllowNullLiteral>]
    type VariableFunction_EmptyGeneratorFunc =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Particles/EmitterTypes/customParticleEmitter
    [<Import("EmptyGeneratorFunc", "@babylonjs/core/Particles/EmitterTypes/customParticleEmitter.js")>]
    let ``EmptyGeneratorFunc``: VariableFunction_EmptyGeneratorFunc = jsNative

    /// Callable shape of EncodeArrayBufferToBase64.
    [<AllowNullLiteral>]
    type VariableFunction_EncodeArrayBufferToBase64 =
        [<Emit("$0($1...)")>] abstract Invoke: ``buffer``: U2<JS.ArrayBuffer, JS.ArrayBufferView> -> string

    /// @babylonjs/core/Misc/stringTools
    [<Import("EncodeArrayBufferToBase64", "@babylonjs/core/Misc/stringTools.js")>]
    let ``EncodeArrayBufferToBase64``: VariableFunction_EncodeArrayBufferToBase64 = jsNative

    /// Callable shape of EncodeImageAsync.
    [<AllowNullLiteral>]
    type VariableFunction_EncodeImageAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``pixelData``: JS.ArrayBufferView * ``width``: float * ``height``: float * ?``mimeType``: string * ?``invertY``: bool * ?``quality``: float -> JS.Promise<Browser.Types.Blob>

    /// @babylonjs/core/Misc/dumpTools.pure
    [<Import("EncodeImageAsync", "@babylonjs/core/Misc/dumpTools.pure.js")>]
    let ``EncodeImageAsync``: VariableFunction_EncodeImageAsync = jsNative

    /// Callable shape of EndsWith.
    [<AllowNullLiteral>]
    type VariableFunction_EndsWith =
        [<Emit("$0($1...)")>] abstract Invoke: ``str``: string * ``suffix``: string -> bool

    /// @babylonjs/core/Misc/stringTools
    [<Import("EndsWith", "@babylonjs/core/Misc/stringTools.js")>]
    let ``EndsWith``: VariableFunction_EndsWith = jsNative

    /// Inline object shape of EngineFunctionContext.
    [<AllowNullLiteral>]
    type VariableShape_EngineFunctionContext =
        abstract ``loadFile``: System.Func<string, System.Action<U2<string, JS.ArrayBuffer>, string option>, System.Action<Browser.Types.ProgressEvent> option, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, bool option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest option, BabylonjsBindings.SimpleClasses.LoadFileError option> option, BabylonjsBindings.SimpleInterfaces.IFileRequest> option with get, set
        abstract ``loadImage``: System.Func<U4<string, JS.ArrayBuffer, JS.ArrayBufferView, Browser.Types.Blob>, System.Action<U2<Browser.Types.HTMLImageElement, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap>>, System.Action<string option, obj option>, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, string option, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmapOptions option, BabylonjsBindings.SimpleClasses.AbstractEngine option, Browser.Types.HTMLImageElement option> option with get, set

    /// @babylonjs/core/Engines/abstractEngine.functions
    [<Import("EngineFunctionContext", "@babylonjs/core/Engines/abstractEngine.functions.js")>]
    let ``EngineFunctionContext``: VariableShape_EngineFunctionContext = jsNative

    /// Inline object shape of EnvironmentTextureTools.
    [<AllowNullLiteral>]
    type VariableShape_EnvironmentTextureTools =
        abstract ``GetEnvInfo``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetEnvInfo with get, set
        abstract ``CreateEnvTextureAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateEnvTextureAsync with get, set
        abstract ``CreateRadianceImageDataArrayBufferViews``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateRadianceImageDataArrayBufferViews with get, set
        abstract ``CreateIrradianceImageDataArrayBufferViews``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateIrradianceImageDataArrayBufferViews with get, set
        abstract ``UploadEnvLevelsAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_UploadEnvLevelsAsync with get, set
        abstract ``UploadRadianceLevelsAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_UploadRadianceLevelsAsync with get, set
        abstract ``UploadIrradianceLevelsAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_UploadIrradianceLevelsAsync with get, set
        abstract ``UploadEnvSpherical``: BabylonjsBindings.SimpleFunctions.FunctionBinding_UploadEnvSpherical with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<Import("EnvironmentTextureTools", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``EnvironmentTextureTools``: VariableShape_EnvironmentTextureTools = jsNative

    /// @babylonjs/core/Maths/math.constants
    [<Import("Epsilon", "@babylonjs/core/Maths/math.constants.js")>]
    let ``Epsilon``: float = jsNative

    /// Inline object shape of equirectangularPanoramaPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_equirectangularPanoramaPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/equirectangularPanorama.fragment
    [<Import("equirectangularPanoramaPixelShader", "@babylonjs/core/Shaders/equirectangularPanorama.fragment.js")>]
    let ``equirectangularPanoramaPixelShader``: VariableShape_equirectangularPanoramaPixelShader = jsNative

    /// Inline object shape of ErrorCodes.
    [<AllowNullLiteral>]
    type VariableShape_ErrorCodes =
        abstract ``MeshInvalidPositionsError``: BabylonjsBindings.Enums.ErrorCodesType with get
        abstract ``UnsupportedTextureError``: BabylonjsBindings.Enums.ErrorCodesType with get
        abstract ``GLTFLoaderUnexpectedMagicError``: BabylonjsBindings.Enums.ErrorCodesType with get
        abstract ``SceneLoaderError``: BabylonjsBindings.Enums.ErrorCodesType with get
        abstract ``LoadFileError``: BabylonjsBindings.Enums.ErrorCodesType with get
        abstract ``RequestFileError``: BabylonjsBindings.Enums.ErrorCodesType with get
        abstract ``ReadFileError``: BabylonjsBindings.Enums.ErrorCodesType with get

    /// @babylonjs/core/Misc/error
    [<Import("ErrorCodes", "@babylonjs/core/Misc/error.js")>]
    let ``ErrorCodes``: VariableShape_ErrorCodes = jsNative

    /// Inline object shape of extractHighlightsPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_extractHighlightsPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/extractHighlights.fragment
    [<Import("extractHighlightsPixelShader", "@babylonjs/core/Shaders/extractHighlights.fragment.js")>]
    let ``extractHighlightsPixelShader``: VariableShape_extractHighlightsPixelShader = jsNative

    /// Inline object shape of extractHighlightsPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_extractHighlightsPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/extractHighlights.fragment
    [<Import("extractHighlightsPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/extractHighlights.fragment.js")>]
    let ``extractHighlightsPixelShaderWGSL``: VariableShape_extractHighlightsPixelShaderWGSL = jsNative

    /// Nested inline object shape used by FBXFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_FBXFileLoaderMetadataProperty2ObjectProperty1Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserTrue with get

    /// Nested inline object shape used by FBXFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_FBXFileLoaderMetadataProperty2Object =
        abstract ``.fbx``: VariableShape_FBXFileLoaderMetadataProperty2ObjectProperty1Object with get

    /// Inline object shape of FBXFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_FBXFileLoaderMetadata =
        abstract ``name``: string with get
        abstract ``extensions``: VariableShape_FBXFileLoaderMetadataProperty2Object with get

    /// @babylonjs/loaders/FBX/fbxFileLoader.metadata
    [<Import("FBXFileLoaderMetadata", "@babylonjs/loaders/FBX/fbxFileLoader.metadata.js")>]
    let ``FBXFileLoaderMetadata``: VariableShape_FBXFileLoaderMetadata = jsNative

    /// Nested inline object shape used by FileTools.
    [<AllowNullLiteral>]
    type VariableShape_FileToolsProperty13Parameter2Object =
        abstract ``crossOrigin``: string option with get, set

    /// Inline object shape of FileTools.
    [<AllowNullLiteral>]
    type VariableShape_FileTools =
        abstract ``DecodeBase64UrlToBinary``: System.Func<string, JS.ArrayBuffer> with get, set
        abstract ``DecodeBase64UrlToString``: System.Func<string, string> with get, set
        abstract ``DefaultRetryStrategy``: obj with get, set
        abstract ``BaseUrl``: obj with get, set
        abstract ``CorsBehavior``: obj with get, set
        abstract ``PreprocessUrl``: obj with get, set
        abstract ``IsBase64DataUrl``: System.Func<string, bool> with get, set
        abstract ``IsFileURL``: System.Func<bool> with get, set
        abstract ``LoadFile``: System.Func<U2<string, Browser.Types.File>, System.Action<U2<string, JS.ArrayBuffer>, string option>, System.Action<Browser.Types.ProgressEvent> option, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, bool option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest option, BabylonjsBindings.SimpleClasses.LoadFileError option> option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest> option, BabylonjsBindings.SimpleInterfaces.IFileRequest> with get, set
        abstract ``LoadImage``: System.Func<U4<string, JS.ArrayBuffer, Browser.Types.Blob, JS.ArrayBufferView>, System.Action<U2<Browser.Types.HTMLImageElement, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap>>, System.Action<string option, obj option>, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, string option, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmapOptions option, Browser.Types.HTMLImageElement option> with get, set
        abstract ``ReadFile``: System.Func<Browser.Types.File, System.Action<obj>, System.Func<Browser.Types.ProgressEvent, obj> option, bool option, System.Action<BabylonjsBindings.SimpleClasses.ReadFileError> option, BabylonjsBindings.SimpleInterfaces.IFileRequest> with get, set
        abstract ``RequestFile``: System.Func<string, System.Action<U2<string, JS.ArrayBuffer>, BabylonjsBindings.SimpleClasses.WebRequest option>, System.Action<Browser.Types.ProgressEvent> option, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, bool option, System.Action<BabylonjsBindings.SimpleClasses.RequestFileError> option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest> option, BabylonjsBindings.SimpleInterfaces.IFileRequest> with get, set
        abstract ``SetCorsBehavior``: System.Action<U2<string, ResizeArray<string>>, VariableShape_FileToolsProperty13Parameter2Object> with get, set

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("FileTools", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``FileTools``: VariableShape_FileTools = jsNative

    /// Inline object shape of FileToolsOptions.
    [<AllowNullLiteral>]
    type VariableShape_FileToolsOptions =
        abstract ``DefaultRetryStrategy``: System.Func<string, BabylonjsBindings.SimpleClasses.WebRequest, float, float> with get, set
        abstract ``BaseUrl``: string with get, set
        abstract ``CorsBehavior``: U2<string, System.Func<U2<string, ResizeArray<string>>, string>> with get, set
        abstract ``PreprocessUrl``: System.Func<string, string> with get, set
        abstract ``ScriptBaseUrl``: string with get, set
        abstract ``ScriptPreprocessUrl``: System.Func<string, string> with get, set
        abstract ``CleanUrl``: System.Func<string, string> with get, set

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("FileToolsOptions", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``FileToolsOptions``: VariableShape_FileToolsOptions = jsNative

    /// Inline object shape of filterPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_filterPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/filter.fragment
    [<Import("filterPixelShader", "@babylonjs/core/Shaders/filter.fragment.js")>]
    let ``filterPixelShader``: VariableShape_filterPixelShader = jsNative

    /// Inline object shape of filterPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_filterPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/filter.fragment
    [<Import("filterPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/filter.fragment.js")>]
    let ``filterPixelShaderWGSL``: VariableShape_filterPixelShaderWGSL = jsNative

    /// Callable shape of FindMaterial.
    [<AllowNullLiteral>]
    type VariableFunction_FindMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: ``materialId``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.Material option

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("FindMaterial", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``FindMaterial``: VariableFunction_FindMaterial = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("FLOAT32_SIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``FLOAT32_SIZE``: float = jsNative

    /// Inline object shape of FloatingOriginCurrentScene.
    [<AllowNullLiteral>]
    type VariableShape_FloatingOriginCurrentScene =
        abstract ``getScene``: System.Func<BabylonjsBindings.SimpleClasses.Scene option> with get, set
        abstract ``eyeAtCamera``: bool with get, set

    /// @babylonjs/core/Materials/floatingOriginMatrixOverrides
    [<Import("FloatingOriginCurrentScene", "@babylonjs/core/Materials/floatingOriginMatrixOverrides.js")>]
    let ``FloatingOriginCurrentScene``: VariableShape_FloatingOriginCurrentScene = jsNative

    /// Inline object shape of fluidRenderingBilateralBlurPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingBilateralBlurPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingBilateralBlur.fragment
    [<Import("fluidRenderingBilateralBlurPixelShader", "@babylonjs/core/Shaders/fluidRenderingBilateralBlur.fragment.js")>]
    let ``fluidRenderingBilateralBlurPixelShader``: VariableShape_fluidRenderingBilateralBlurPixelShader = jsNative

    /// Inline object shape of fluidRenderingBilateralBlurPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingBilateralBlurPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingBilateralBlur.fragment
    [<Import("fluidRenderingBilateralBlurPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingBilateralBlur.fragment.js")>]
    let ``fluidRenderingBilateralBlurPixelShaderWGSL``: VariableShape_fluidRenderingBilateralBlurPixelShaderWGSL = jsNative

    /// Inline object shape of fluidRenderingParticleDepthPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleDepthPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingParticleDepth.fragment
    [<Import("fluidRenderingParticleDepthPixelShader", "@babylonjs/core/Shaders/fluidRenderingParticleDepth.fragment.js")>]
    let ``fluidRenderingParticleDepthPixelShader``: VariableShape_fluidRenderingParticleDepthPixelShader = jsNative

    /// Inline object shape of fluidRenderingParticleDepthPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleDepthPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingParticleDepth.fragment
    [<Import("fluidRenderingParticleDepthPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingParticleDepth.fragment.js")>]
    let ``fluidRenderingParticleDepthPixelShaderWGSL``: VariableShape_fluidRenderingParticleDepthPixelShaderWGSL = jsNative

    /// Inline object shape of fluidRenderingParticleDepthVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleDepthVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingParticleDepth.vertex
    [<Import("fluidRenderingParticleDepthVertexShader", "@babylonjs/core/Shaders/fluidRenderingParticleDepth.vertex.js")>]
    let ``fluidRenderingParticleDepthVertexShader``: VariableShape_fluidRenderingParticleDepthVertexShader = jsNative

    /// Inline object shape of fluidRenderingParticleDepthVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleDepthVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingParticleDepth.vertex
    [<Import("fluidRenderingParticleDepthVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingParticleDepth.vertex.js")>]
    let ``fluidRenderingParticleDepthVertexShaderWGSL``: VariableShape_fluidRenderingParticleDepthVertexShaderWGSL = jsNative

    /// Inline object shape of fluidRenderingParticleDiffusePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleDiffusePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingParticleDiffuse.fragment
    [<Import("fluidRenderingParticleDiffusePixelShader", "@babylonjs/core/Shaders/fluidRenderingParticleDiffuse.fragment.js")>]
    let ``fluidRenderingParticleDiffusePixelShader``: VariableShape_fluidRenderingParticleDiffusePixelShader = jsNative

    /// Inline object shape of fluidRenderingParticleDiffusePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleDiffusePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingParticleDiffuse.fragment
    [<Import("fluidRenderingParticleDiffusePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingParticleDiffuse.fragment.js")>]
    let ``fluidRenderingParticleDiffusePixelShaderWGSL``: VariableShape_fluidRenderingParticleDiffusePixelShaderWGSL = jsNative

    /// Inline object shape of fluidRenderingParticleDiffuseVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleDiffuseVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingParticleDiffuse.vertex
    [<Import("fluidRenderingParticleDiffuseVertexShader", "@babylonjs/core/Shaders/fluidRenderingParticleDiffuse.vertex.js")>]
    let ``fluidRenderingParticleDiffuseVertexShader``: VariableShape_fluidRenderingParticleDiffuseVertexShader = jsNative

    /// Inline object shape of fluidRenderingParticleDiffuseVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleDiffuseVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingParticleDiffuse.vertex
    [<Import("fluidRenderingParticleDiffuseVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingParticleDiffuse.vertex.js")>]
    let ``fluidRenderingParticleDiffuseVertexShaderWGSL``: VariableShape_fluidRenderingParticleDiffuseVertexShaderWGSL = jsNative

    /// Inline object shape of fluidRenderingParticleThicknessPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleThicknessPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingParticleThickness.fragment
    [<Import("fluidRenderingParticleThicknessPixelShader", "@babylonjs/core/Shaders/fluidRenderingParticleThickness.fragment.js")>]
    let ``fluidRenderingParticleThicknessPixelShader``: VariableShape_fluidRenderingParticleThicknessPixelShader = jsNative

    /// Inline object shape of fluidRenderingParticleThicknessPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleThicknessPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingParticleThickness.fragment
    [<Import("fluidRenderingParticleThicknessPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingParticleThickness.fragment.js")>]
    let ``fluidRenderingParticleThicknessPixelShaderWGSL``: VariableShape_fluidRenderingParticleThicknessPixelShaderWGSL = jsNative

    /// Inline object shape of fluidRenderingParticleThicknessVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleThicknessVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingParticleThickness.vertex
    [<Import("fluidRenderingParticleThicknessVertexShader", "@babylonjs/core/Shaders/fluidRenderingParticleThickness.vertex.js")>]
    let ``fluidRenderingParticleThicknessVertexShader``: VariableShape_fluidRenderingParticleThicknessVertexShader = jsNative

    /// Inline object shape of fluidRenderingParticleThicknessVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingParticleThicknessVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingParticleThickness.vertex
    [<Import("fluidRenderingParticleThicknessVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingParticleThickness.vertex.js")>]
    let ``fluidRenderingParticleThicknessVertexShaderWGSL``: VariableShape_fluidRenderingParticleThicknessVertexShaderWGSL = jsNative

    /// Inline object shape of fluidRenderingRenderPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingRenderPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingRender.fragment
    [<Import("fluidRenderingRenderPixelShader", "@babylonjs/core/Shaders/fluidRenderingRender.fragment.js")>]
    let ``fluidRenderingRenderPixelShader``: VariableShape_fluidRenderingRenderPixelShader = jsNative

    /// Inline object shape of fluidRenderingRenderPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingRenderPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingRender.fragment
    [<Import("fluidRenderingRenderPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingRender.fragment.js")>]
    let ``fluidRenderingRenderPixelShaderWGSL``: VariableShape_fluidRenderingRenderPixelShaderWGSL = jsNative

    /// Inline object shape of fluidRenderingStandardBlurPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingStandardBlurPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fluidRenderingStandardBlur.fragment
    [<Import("fluidRenderingStandardBlurPixelShader", "@babylonjs/core/Shaders/fluidRenderingStandardBlur.fragment.js")>]
    let ``fluidRenderingStandardBlurPixelShader``: VariableShape_fluidRenderingStandardBlurPixelShader = jsNative

    /// Inline object shape of fluidRenderingStandardBlurPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fluidRenderingStandardBlurPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fluidRenderingStandardBlur.fragment
    [<Import("fluidRenderingStandardBlurPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/fluidRenderingStandardBlur.fragment.js")>]
    let ``fluidRenderingStandardBlurPixelShaderWGSL``: VariableShape_fluidRenderingStandardBlurPixelShaderWGSL = jsNative

    /// Inline object shape of fogFragment.
    [<AllowNullLiteral>]
    type VariableShape_fogFragment =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/fogFragment
    [<Import("fogFragment", "@babylonjs/core/Shaders/ShadersInclude/fogFragment.js")>]
    let ``fogFragment``: VariableShape_fogFragment = jsNative

    /// Inline object shape of fogFragmentDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_fogFragmentDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/fogFragmentDeclaration
    [<Import("fogFragmentDeclaration", "@babylonjs/core/Shaders/ShadersInclude/fogFragmentDeclaration.js")>]
    let ``fogFragmentDeclaration``: VariableShape_fogFragmentDeclaration = jsNative

    /// Inline object shape of fogFragmentDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fogFragmentDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/fogFragmentDeclaration
    [<Import("fogFragmentDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/fogFragmentDeclaration.js")>]
    let ``fogFragmentDeclarationWGSL``: VariableShape_fogFragmentDeclarationWGSL = jsNative

    /// Inline object shape of fogFragmentWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fogFragmentWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/fogFragment
    [<Import("fogFragmentWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/fogFragment.js")>]
    let ``fogFragmentWGSL``: VariableShape_fogFragmentWGSL = jsNative

    /// Inline object shape of fogVertex.
    [<AllowNullLiteral>]
    type VariableShape_fogVertex =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/fogVertex
    [<Import("fogVertex", "@babylonjs/core/Shaders/ShadersInclude/fogVertex.js")>]
    let ``fogVertex``: VariableShape_fogVertex = jsNative

    /// Inline object shape of fogVertexDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_fogVertexDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/fogVertexDeclaration
    [<Import("fogVertexDeclaration", "@babylonjs/core/Shaders/ShadersInclude/fogVertexDeclaration.js")>]
    let ``fogVertexDeclaration``: VariableShape_fogVertexDeclaration = jsNative

    /// Inline object shape of fogVertexDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fogVertexDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/fogVertexDeclaration
    [<Import("fogVertexDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/fogVertexDeclaration.js")>]
    let ``fogVertexDeclarationWGSL``: VariableShape_fogVertexDeclarationWGSL = jsNative

    /// Inline object shape of fogVertexWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fogVertexWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/fogVertex
    [<Import("fogVertexWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/fogVertex.js")>]
    let ``fogVertexWGSL``: VariableShape_fogVertexWGSL = jsNative

    /// Inline object shape of FrameGraphUtils.
    [<AllowNullLiteral>]
    type VariableShape_FrameGraphUtils =
        abstract ``FindMainCamera``: BabylonjsBindings.SimpleFunctions.FunctionBinding_FindMainCamera with get, set
        abstract ``FindMainObjectRenderer``: BabylonjsBindings.SimpleFunctions.FunctionBinding_FindMainObjectRenderer with get, set
        abstract ``CreateUtilityLayerRenderer``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateUtilityLayerRenderer with get, set

    /// @babylonjs/core/FrameGraph/frameGraphUtils
    [<Import("FrameGraphUtils", "@babylonjs/core/FrameGraph/frameGraphUtils.js")>]
    let ``FrameGraphUtils``: VariableShape_FrameGraphUtils = jsNative

    /// Inline object shape of fresnelFunctionWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fresnelFunctionWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/fresnelFunction
    [<Import("fresnelFunctionWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/fresnelFunction.js")>]
    let ``fresnelFunctionWGSL``: VariableShape_fresnelFunctionWGSL = jsNative

    /// Inline object shape of fxaaPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_fxaaPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fxaa.fragment
    [<Import("fxaaPixelShader", "@babylonjs/core/Shaders/fxaa.fragment.js")>]
    let ``fxaaPixelShader``: VariableShape_fxaaPixelShader = jsNative

    /// Inline object shape of fxaaPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fxaaPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fxaa.fragment
    [<Import("fxaaPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/fxaa.fragment.js")>]
    let ``fxaaPixelShaderWGSL``: VariableShape_fxaaPixelShaderWGSL = jsNative

    /// Inline object shape of fxaaVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_fxaaVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/fxaa.vertex
    [<Import("fxaaVertexShader", "@babylonjs/core/Shaders/fxaa.vertex.js")>]
    let ``fxaaVertexShader``: VariableShape_fxaaVertexShader = jsNative

    /// Inline object shape of fxaaVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_fxaaVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/fxaa.vertex
    [<Import("fxaaVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/fxaa.vertex.js")>]
    let ``fxaaVertexShaderWGSL``: VariableShape_fxaaVertexShaderWGSL = jsNative

    /// Inline object shape of gaussianSplatting.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplatting =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/gaussianSplatting
    [<Import("gaussianSplatting", "@babylonjs/core/Shaders/ShadersInclude/gaussianSplatting.js")>]
    let ``gaussianSplatting``: VariableShape_gaussianSplatting = jsNative

    /// Inline object shape of gaussianSplattingDepthPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingDepthPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/gaussianSplattingDepth.fragment
    [<Import("gaussianSplattingDepthPixelShader", "@babylonjs/core/Shaders/gaussianSplattingDepth.fragment.js")>]
    let ``gaussianSplattingDepthPixelShader``: VariableShape_gaussianSplattingDepthPixelShader = jsNative

    /// Inline object shape of gaussianSplattingDepthPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingDepthPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/gaussianSplattingDepth.fragment
    [<Import("gaussianSplattingDepthPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/gaussianSplattingDepth.fragment.js")>]
    let ``gaussianSplattingDepthPixelShaderWGSL``: VariableShape_gaussianSplattingDepthPixelShaderWGSL = jsNative

    /// Inline object shape of gaussianSplattingDepthVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingDepthVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/gaussianSplattingDepth.vertex
    [<Import("gaussianSplattingDepthVertexShader", "@babylonjs/core/Shaders/gaussianSplattingDepth.vertex.js")>]
    let ``gaussianSplattingDepthVertexShader``: VariableShape_gaussianSplattingDepthVertexShader = jsNative

    /// Inline object shape of gaussianSplattingDepthVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingDepthVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/gaussianSplattingDepth.vertex
    [<Import("gaussianSplattingDepthVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/gaussianSplattingDepth.vertex.js")>]
    let ``gaussianSplattingDepthVertexShaderWGSL``: VariableShape_gaussianSplattingDepthVertexShaderWGSL = jsNative

    /// Inline object shape of gaussianSplattingFragmentDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingFragmentDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/gaussianSplattingFragmentDeclaration
    [<Import("gaussianSplattingFragmentDeclaration", "@babylonjs/core/Shaders/ShadersInclude/gaussianSplattingFragmentDeclaration.js")>]
    let ``gaussianSplattingFragmentDeclaration``: VariableShape_gaussianSplattingFragmentDeclaration = jsNative

    /// Inline object shape of gaussianSplattingFragmentDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingFragmentDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/gaussianSplattingFragmentDeclaration
    [<Import("gaussianSplattingFragmentDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/gaussianSplattingFragmentDeclaration.js")>]
    let ``gaussianSplattingFragmentDeclarationWGSL``: VariableShape_gaussianSplattingFragmentDeclarationWGSL = jsNative

    /// @babylonjs/core/Materials/GaussianSplatting/gaussianSplattingMaterial.pure
    [<Import("GaussianSplattingMaxPartCount", "@babylonjs/core/Materials/GaussianSplatting/gaussianSplattingMaterial.pure.js")>]
    let ``GaussianSplattingMaxPartCount``: float = jsNative

    /// Inline object shape of gaussianSplattingVertexDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingVertexDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/gaussianSplattingVertexDeclaration
    [<Import("gaussianSplattingVertexDeclaration", "@babylonjs/core/Shaders/ShadersInclude/gaussianSplattingVertexDeclaration.js")>]
    let ``gaussianSplattingVertexDeclaration``: VariableShape_gaussianSplattingVertexDeclaration = jsNative

    /// Inline object shape of gaussianSplattingVertexDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingVertexDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/gaussianSplattingVertexDeclaration
    [<Import("gaussianSplattingVertexDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/gaussianSplattingVertexDeclaration.js")>]
    let ``gaussianSplattingVertexDeclarationWGSL``: VariableShape_gaussianSplattingVertexDeclarationWGSL = jsNative

    /// Inline object shape of gaussianSplattingWGSL.
    [<AllowNullLiteral>]
    type VariableShape_gaussianSplattingWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/gaussianSplatting
    [<Import("gaussianSplattingWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/gaussianSplatting.js")>]
    let ``gaussianSplattingWGSL``: VariableShape_gaussianSplattingWGSL = jsNative

    /// Inline object shape of geometryPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_geometryPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/geometry.fragment
    [<Import("geometryPixelShader", "@babylonjs/core/Shaders/geometry.fragment.js")>]
    let ``geometryPixelShader``: VariableShape_geometryPixelShader = jsNative

    /// Inline object shape of geometryPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_geometryPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/geometry.fragment
    [<Import("geometryPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/geometry.fragment.js")>]
    let ``geometryPixelShaderWGSL``: VariableShape_geometryPixelShaderWGSL = jsNative

    /// Inline object shape of geometryVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_geometryVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/geometry.vertex
    [<Import("geometryVertexShader", "@babylonjs/core/Shaders/geometry.vertex.js")>]
    let ``geometryVertexShader``: VariableShape_geometryVertexShader = jsNative

    /// Inline object shape of geometryVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_geometryVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/geometry.vertex
    [<Import("geometryVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/geometry.vertex.js")>]
    let ``geometryVertexShaderWGSL``: VariableShape_geometryVertexShaderWGSL = jsNative

    /// Callable shape of GetEnvironmentBRDFTexture.
    [<AllowNullLiteral>]
    type VariableFunction_GetEnvironmentBRDFTexture =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.BaseTexture

    /// @babylonjs/core/Misc/brdfTextureTools
    [<Import("GetEnvironmentBRDFTexture", "@babylonjs/core/Misc/brdfTextureTools.js")>]
    let ``GetEnvironmentBRDFTexture``: VariableFunction_GetEnvironmentBRDFTexture = jsNative

    /// Callable shape of GetEnvironmentFuzzBRDFTexture.
    [<AllowNullLiteral>]
    type VariableFunction_GetEnvironmentFuzzBRDFTexture =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.BaseTexture

    /// @babylonjs/core/Misc/brdfTextureTools
    [<Import("GetEnvironmentFuzzBRDFTexture", "@babylonjs/core/Misc/brdfTextureTools.js")>]
    let ``GetEnvironmentFuzzBRDFTexture``: VariableFunction_GetEnvironmentFuzzBRDFTexture = jsNative

    /// Callable shape of GetInternalFormatFromBasisFormat.
    [<AllowNullLiteral>]
    type VariableFunction_GetInternalFormatFromBasisFormat =
        [<Emit("$0($1...)")>] abstract Invoke: ``basisFormat``: float * ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine -> float

    /// @babylonjs/core/Misc/basis.pure
    [<Import("GetInternalFormatFromBasisFormat", "@babylonjs/core/Misc/basis.pure.js")>]
    let ``GetInternalFormatFromBasisFormat``: VariableFunction_GetInternalFormatFromBasisFormat = jsNative

    /// Callable shape of GetMimeType.
    [<AllowNullLiteral>]
    type VariableFunction_GetMimeType =
        [<Emit("$0($1...)")>] abstract Invoke: ``url``: string -> string option

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("GetMimeType", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``GetMimeType``: VariableFunction_GetMimeType = jsNative

    /// Callable shape of GetOpenPBREnvironmentBRDFTexture.
    [<AllowNullLiteral>]
    type VariableFunction_GetOpenPBREnvironmentBRDFTexture =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.BaseTexture

    /// @babylonjs/core/Misc/brdfTextureTools
    [<Import("GetOpenPBREnvironmentBRDFTexture", "@babylonjs/core/Misc/brdfTextureTools.js")>]
    let ``GetOpenPBREnvironmentBRDFTexture``: VariableFunction_GetOpenPBREnvironmentBRDFTexture = jsNative

    /// Inline object shape of glowBlurPostProcessPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_glowBlurPostProcessPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/glowBlurPostProcess.fragment
    [<Import("glowBlurPostProcessPixelShader", "@babylonjs/core/Shaders/glowBlurPostProcess.fragment.js")>]
    let ``glowBlurPostProcessPixelShader``: VariableShape_glowBlurPostProcessPixelShader = jsNative

    /// Inline object shape of glowBlurPostProcessPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_glowBlurPostProcessPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/glowBlurPostProcess.fragment
    [<Import("glowBlurPostProcessPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/glowBlurPostProcess.fragment.js")>]
    let ``glowBlurPostProcessPixelShaderWGSL``: VariableShape_glowBlurPostProcessPixelShaderWGSL = jsNative

    /// Inline object shape of glowMapGenerationPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_glowMapGenerationPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/glowMapGeneration.fragment
    [<Import("glowMapGenerationPixelShader", "@babylonjs/core/Shaders/glowMapGeneration.fragment.js")>]
    let ``glowMapGenerationPixelShader``: VariableShape_glowMapGenerationPixelShader = jsNative

    /// Inline object shape of glowMapGenerationPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_glowMapGenerationPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/glowMapGeneration.fragment
    [<Import("glowMapGenerationPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/glowMapGeneration.fragment.js")>]
    let ``glowMapGenerationPixelShaderWGSL``: VariableShape_glowMapGenerationPixelShaderWGSL = jsNative

    /// Inline object shape of glowMapGenerationVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_glowMapGenerationVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/glowMapGeneration.vertex
    [<Import("glowMapGenerationVertexShader", "@babylonjs/core/Shaders/glowMapGeneration.vertex.js")>]
    let ``glowMapGenerationVertexShader``: VariableShape_glowMapGenerationVertexShader = jsNative

    /// Inline object shape of glowMapGenerationVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_glowMapGenerationVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/glowMapGeneration.vertex
    [<Import("glowMapGenerationVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/glowMapGeneration.vertex.js")>]
    let ``glowMapGenerationVertexShaderWGSL``: VariableShape_glowMapGenerationVertexShaderWGSL = jsNative

    /// Inline object shape of glowMapMergePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_glowMapMergePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/glowMapMerge.fragment
    [<Import("glowMapMergePixelShader", "@babylonjs/core/Shaders/glowMapMerge.fragment.js")>]
    let ``glowMapMergePixelShader``: VariableShape_glowMapMergePixelShader = jsNative

    /// Inline object shape of glowMapMergePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_glowMapMergePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/glowMapMerge.fragment
    [<Import("glowMapMergePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/glowMapMerge.fragment.js")>]
    let ``glowMapMergePixelShaderWGSL``: VariableShape_glowMapMergePixelShaderWGSL = jsNative

    /// Inline object shape of glowMapMergeVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_glowMapMergeVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/glowMapMerge.vertex
    [<Import("glowMapMergeVertexShader", "@babylonjs/core/Shaders/glowMapMerge.vertex.js")>]
    let ``glowMapMergeVertexShader``: VariableShape_glowMapMergeVertexShader = jsNative

    /// Inline object shape of glowMapMergeVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_glowMapMergeVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/glowMapMerge.vertex
    [<Import("glowMapMergeVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/glowMapMerge.vertex.js")>]
    let ``glowMapMergeVertexShaderWGSL``: VariableShape_glowMapMergeVertexShaderWGSL = jsNative

    /// Nested inline object shape used by GLTFFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_GLTFFileLoaderMetadataProperty2ObjectProperty1Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserFalse with get
        abstract ``mimeType``: string with get

    /// Nested inline object shape used by GLTFFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_GLTFFileLoaderMetadataProperty2ObjectProperty2Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserTrue with get
        abstract ``mimeType``: string with get

    /// Nested inline object shape used by GLTFFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_GLTFFileLoaderMetadataProperty2Object =
        abstract ``.gltf``: VariableShape_GLTFFileLoaderMetadataProperty2ObjectProperty1Object with get
        abstract ``.glb``: VariableShape_GLTFFileLoaderMetadataProperty2ObjectProperty2Object with get

    /// Inline object shape of GLTFFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_GLTFFileLoaderMetadata =
        abstract ``name``: string with get
        abstract ``extensions``: VariableShape_GLTFFileLoaderMetadataProperty2Object with get
        abstract ``canDirectLoad``: System.Func<string, bool> with get

    /// @babylonjs/loaders/glTF/glTFFileLoader.metadata
    [<Import("GLTFFileLoaderMetadata", "@babylonjs/loaders/glTF/glTFFileLoader.metadata.js")>]
    let ``GLTFFileLoaderMetadata``: VariableShape_GLTFFileLoaderMetadata = jsNative

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    [<Import("GLTFLoaderDefaultOptions", "@babylonjs/loaders/glTF/glTFFileLoader.pure.js")>]
    let ``GLTFLoaderDefaultOptions``: BabylonjsBindings.SimpleClasses.GLTFLoaderBaseOptions = jsNative

    /// @babylonjs/loaders/glTF/glTFFileLoader.metadata
    [<Import("GLTFMagicBase64Encoded", "@babylonjs/loaders/glTF/glTFFileLoader.metadata.js")>]
    let ``GLTFMagicBase64Encoded``: string = jsNative

    /// Nested inline object shape used by gltfTypeToBabylonType.
    [<AllowNullLiteral>]
    type VariableShape_gltfTypeToBabylonTypeIndexer1ValueObject =
        abstract ``length``: float with get, set
        abstract ``flowGraphType``: BabylonjsBindings.StringEnums.FlowGraphTypes with get, set
        abstract ``elementType``: U2<string, string> with get, set

    /// Inline object shape of gltfTypeToBabylonType.
    [<AllowNullLiteral>]
    type VariableShape_gltfTypeToBabylonType =
        [<EmitIndexer>] abstract Item: ``key``: string -> VariableShape_gltfTypeToBabylonTypeIndexer1ValueObject with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/interactivityGraphParser
    [<Import("gltfTypeToBabylonType", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/interactivityGraphParser.js")>]
    let ``gltfTypeToBabylonType``: VariableShape_gltfTypeToBabylonType = jsNative

    /// Inline object shape of gpuRenderParticlesPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_gpuRenderParticlesPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/gpuRenderParticles.fragment
    [<Import("gpuRenderParticlesPixelShader", "@babylonjs/core/Shaders/gpuRenderParticles.fragment.js")>]
    let ``gpuRenderParticlesPixelShader``: VariableShape_gpuRenderParticlesPixelShader = jsNative

    /// Inline object shape of gpuRenderParticlesVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_gpuRenderParticlesVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/gpuRenderParticles.vertex
    [<Import("gpuRenderParticlesVertexShader", "@babylonjs/core/Shaders/gpuRenderParticles.vertex.js")>]
    let ``gpuRenderParticlesVertexShader``: VariableShape_gpuRenderParticlesVertexShader = jsNative

    /// Inline object shape of gpuTransformPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_gpuTransformPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/gpuTransform.fragment
    [<Import("gpuTransformPixelShader", "@babylonjs/core/Shaders/gpuTransform.fragment.js")>]
    let ``gpuTransformPixelShader``: VariableShape_gpuTransformPixelShader = jsNative

    /// Inline object shape of gpuTransformVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_gpuTransformVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/gpuTransform.vertex
    [<Import("gpuTransformVertexShader", "@babylonjs/core/Shaders/gpuTransform.vertex.js")>]
    let ``gpuTransformVertexShader``: VariableShape_gpuTransformVertexShader = jsNative

    /// Inline object shape of gpuUpdateParticlesComputeShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_gpuUpdateParticlesComputeShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/gpuUpdateParticles.compute
    [<Import("gpuUpdateParticlesComputeShaderWGSL", "@babylonjs/core/ShadersWGSL/gpuUpdateParticles.compute.js")>]
    let ``gpuUpdateParticlesComputeShaderWGSL``: VariableShape_gpuUpdateParticlesComputeShaderWGSL = jsNative

    /// Inline object shape of gpuUpdateParticlesPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_gpuUpdateParticlesPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/gpuUpdateParticles.fragment
    [<Import("gpuUpdateParticlesPixelShader", "@babylonjs/core/Shaders/gpuUpdateParticles.fragment.js")>]
    let ``gpuUpdateParticlesPixelShader``: VariableShape_gpuUpdateParticlesPixelShader = jsNative

    /// Inline object shape of gpuUpdateParticlesVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_gpuUpdateParticlesVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/gpuUpdateParticles.vertex
    [<Import("gpuUpdateParticlesVertexShader", "@babylonjs/core/Shaders/gpuUpdateParticles.vertex.js")>]
    let ``gpuUpdateParticlesVertexShader``: VariableShape_gpuUpdateParticlesVertexShader = jsNative

    /// Inline object shape of grainPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_grainPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/grain.fragment
    [<Import("grainPixelShader", "@babylonjs/core/Shaders/grain.fragment.js")>]
    let ``grainPixelShader``: VariableShape_grainPixelShader = jsNative

    /// Inline object shape of grainPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_grainPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/grain.fragment
    [<Import("grainPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/grain.fragment.js")>]
    let ``grainPixelShaderWGSL``: VariableShape_grainPixelShaderWGSL = jsNative

    /// Inline object shape of greasedLinePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_greasedLinePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/greasedLine.fragment
    [<Import("greasedLinePixelShader", "@babylonjs/core/Shaders/greasedLine.fragment.js")>]
    let ``greasedLinePixelShader``: VariableShape_greasedLinePixelShader = jsNative

    /// Inline object shape of greasedLinePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_greasedLinePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/greasedLine.fragment
    [<Import("greasedLinePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/greasedLine.fragment.js")>]
    let ``greasedLinePixelShaderWGSL``: VariableShape_greasedLinePixelShaderWGSL = jsNative

    /// @babylonjs/core/Materials/GreasedLine/greasedLineSimpleMaterial
    [<Import("GreasedLineUseOffsetsSimpleMaterialDefine", "@babylonjs/core/Materials/GreasedLine/greasedLineSimpleMaterial.js")>]
    let ``GreasedLineUseOffsetsSimpleMaterialDefine``: string = jsNative

    /// Inline object shape of greasedLineVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_greasedLineVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/greasedLine.vertex
    [<Import("greasedLineVertexShader", "@babylonjs/core/Shaders/greasedLine.vertex.js")>]
    let ``greasedLineVertexShader``: VariableShape_greasedLineVertexShader = jsNative

    /// Inline object shape of greasedLineVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_greasedLineVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/greasedLine.vertex
    [<Import("greasedLineVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/greasedLine.vertex.js")>]
    let ``greasedLineVertexShaderWGSL``: VariableShape_greasedLineVertexShaderWGSL = jsNative

    /// Inline object shape of GroundBuilder.
    [<AllowNullLiteral>]
    type VariableShape_GroundBuilder =
        abstract ``CreateGround``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateGround with get, set
        abstract ``CreateGroundFromHeightMap``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateGroundFromHeightMap with get, set
        abstract ``CreateTiledGround``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTiledGround with get, set

    /// @babylonjs/core/Meshes/Builders/groundBuilder.pure
    [<Import("GroundBuilder", "@babylonjs/core/Meshes/Builders/groundBuilder.pure.js")>]
    let ``GroundBuilder``: VariableShape_GroundBuilder = jsNative

    /// Inline object shape of GUID.
    [<AllowNullLiteral>]
    type VariableShape_GUID =
        abstract ``RandomId``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RandomGUID with get, set

    /// @babylonjs/core/Misc/guid
    [<Import("GUID", "@babylonjs/core/Misc/guid.js")>]
    let ``GUID``: VariableShape_GUID = jsNative

    /// Inline object shape of hdrFilteringFunctions.
    [<AllowNullLiteral>]
    type VariableShape_hdrFilteringFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/hdrFilteringFunctions
    [<Import("hdrFilteringFunctions", "@babylonjs/core/Shaders/ShadersInclude/hdrFilteringFunctions.js")>]
    let ``hdrFilteringFunctions``: VariableShape_hdrFilteringFunctions = jsNative

    /// Inline object shape of hdrFilteringFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_hdrFilteringFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/hdrFilteringFunctions
    [<Import("hdrFilteringFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/hdrFilteringFunctions.js")>]
    let ``hdrFilteringFunctionsWGSL``: VariableShape_hdrFilteringFunctionsWGSL = jsNative

    /// Inline object shape of hdrFilteringPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_hdrFilteringPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/hdrFiltering.fragment
    [<Import("hdrFilteringPixelShader", "@babylonjs/core/Shaders/hdrFiltering.fragment.js")>]
    let ``hdrFilteringPixelShader``: VariableShape_hdrFilteringPixelShader = jsNative

    /// Inline object shape of hdrFilteringPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_hdrFilteringPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/hdrFiltering.fragment
    [<Import("hdrFilteringPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/hdrFiltering.fragment.js")>]
    let ``hdrFilteringPixelShaderWGSL``: VariableShape_hdrFilteringPixelShaderWGSL = jsNative

    /// Inline object shape of hdrFilteringVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_hdrFilteringVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/hdrFiltering.vertex
    [<Import("hdrFilteringVertexShader", "@babylonjs/core/Shaders/hdrFiltering.vertex.js")>]
    let ``hdrFilteringVertexShader``: VariableShape_hdrFilteringVertexShader = jsNative

    /// Inline object shape of hdrFilteringVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_hdrFilteringVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/hdrFiltering.vertex
    [<Import("hdrFilteringVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/hdrFiltering.vertex.js")>]
    let ``hdrFilteringVertexShaderWGSL``: VariableShape_hdrFilteringVertexShaderWGSL = jsNative

    /// Inline object shape of hdrIrradianceFilteringPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_hdrIrradianceFilteringPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/hdrIrradianceFiltering.fragment
    [<Import("hdrIrradianceFilteringPixelShader", "@babylonjs/core/Shaders/hdrIrradianceFiltering.fragment.js")>]
    let ``hdrIrradianceFilteringPixelShader``: VariableShape_hdrIrradianceFilteringPixelShader = jsNative

    /// Inline object shape of hdrIrradianceFilteringPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_hdrIrradianceFilteringPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/hdrIrradianceFiltering.fragment
    [<Import("hdrIrradianceFilteringPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/hdrIrradianceFiltering.fragment.js")>]
    let ``hdrIrradianceFilteringPixelShaderWGSL``: VariableShape_hdrIrradianceFilteringPixelShaderWGSL = jsNative

    /// Inline object shape of hdrIrradianceFilteringVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_hdrIrradianceFilteringVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/hdrIrradianceFiltering.vertex
    [<Import("hdrIrradianceFilteringVertexShader", "@babylonjs/core/Shaders/hdrIrradianceFiltering.vertex.js")>]
    let ``hdrIrradianceFilteringVertexShader``: VariableShape_hdrIrradianceFilteringVertexShader = jsNative

    /// Inline object shape of hdrIrradianceFilteringVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_hdrIrradianceFilteringVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/hdrIrradianceFiltering.vertex
    [<Import("hdrIrradianceFilteringVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/hdrIrradianceFiltering.vertex.js")>]
    let ``hdrIrradianceFilteringVertexShaderWGSL``: VariableShape_hdrIrradianceFilteringVertexShaderWGSL = jsNative

    /// Inline object shape of HDRTools.
    [<AllowNullLiteral>]
    type VariableShape_HDRTools =
        abstract ``RGBE_ReadHeader``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RGBE_ReadHeader with get, set
        abstract ``GetCubeMapTextureData``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetCubeMapTextureData with get, set
        abstract ``RGBE_ReadPixels``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RGBE_ReadPixels with get, set

    /// @babylonjs/core/Misc/HighDynamicRange/hdr
    [<Import("HDRTools", "@babylonjs/core/Misc/HighDynamicRange/hdr.js")>]
    let ``HDRTools``: VariableShape_HDRTools = jsNative

    /// Inline object shape of helperFunctions.
    [<AllowNullLiteral>]
    type VariableShape_helperFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/helperFunctions
    [<Import("helperFunctions", "@babylonjs/core/Shaders/ShadersInclude/helperFunctions.js")>]
    let ``helperFunctions``: VariableShape_helperFunctions = jsNative

    /// Inline object shape of helperFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_helperFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/helperFunctions
    [<Import("helperFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/helperFunctions.js")>]
    let ``helperFunctionsWGSL``: VariableShape_helperFunctionsWGSL = jsNative

    /// Inline object shape of HemisphereBuilder.
    [<AllowNullLiteral>]
    type VariableShape_HemisphereBuilder =
        abstract ``CreateHemisphere``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateHemisphere with get, set

    /// @babylonjs/core/Meshes/Builders/hemisphereBuilder.pure
    [<Import("HemisphereBuilder", "@babylonjs/core/Meshes/Builders/hemisphereBuilder.pure.js")>]
    let ``HemisphereBuilder``: VariableShape_HemisphereBuilder = jsNative

    /// Inline object shape of highlightsPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_highlightsPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/highlights.fragment
    [<Import("highlightsPixelShader", "@babylonjs/core/Shaders/highlights.fragment.js")>]
    let ``highlightsPixelShader``: VariableShape_highlightsPixelShader = jsNative

    /// Inline object shape of highlightsPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_highlightsPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/highlights.fragment
    [<Import("highlightsPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/highlights.fragment.js")>]
    let ``highlightsPixelShaderWGSL``: VariableShape_highlightsPixelShaderWGSL = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("HUF_DECBITS", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``HUF_DECBITS``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("HUF_DECMASK", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``HUF_DECMASK``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("HUF_DECSIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``HUF_DECSIZE``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("HUF_ENCBITS", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``HUF_ENCBITS``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("HUF_ENCSIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``HUF_ENCSIZE``: float = jsNative

    /// Inline object shape of iblCdfDebugPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblCdfDebugPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblCdfDebug.fragment
    [<Import("iblCdfDebugPixelShader", "@babylonjs/core/Shaders/iblCdfDebug.fragment.js")>]
    let ``iblCdfDebugPixelShader``: VariableShape_iblCdfDebugPixelShader = jsNative

    /// Inline object shape of iblCdfDebugPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblCdfDebugPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblCdfDebug.fragment
    [<Import("iblCdfDebugPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblCdfDebug.fragment.js")>]
    let ``iblCdfDebugPixelShaderWGSL``: VariableShape_iblCdfDebugPixelShaderWGSL = jsNative

    /// Inline object shape of iblCdfxPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblCdfxPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblCdfx.fragment
    [<Import("iblCdfxPixelShader", "@babylonjs/core/Shaders/iblCdfx.fragment.js")>]
    let ``iblCdfxPixelShader``: VariableShape_iblCdfxPixelShader = jsNative

    /// Inline object shape of iblCdfxPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblCdfxPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblCdfx.fragment
    [<Import("iblCdfxPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblCdfx.fragment.js")>]
    let ``iblCdfxPixelShaderWGSL``: VariableShape_iblCdfxPixelShaderWGSL = jsNative

    /// Inline object shape of iblCdfyPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblCdfyPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblCdfy.fragment
    [<Import("iblCdfyPixelShader", "@babylonjs/core/Shaders/iblCdfy.fragment.js")>]
    let ``iblCdfyPixelShader``: VariableShape_iblCdfyPixelShader = jsNative

    /// Inline object shape of iblCdfyPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblCdfyPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblCdfy.fragment
    [<Import("iblCdfyPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblCdfy.fragment.js")>]
    let ``iblCdfyPixelShaderWGSL``: VariableShape_iblCdfyPixelShaderWGSL = jsNative

    /// Inline object shape of iblCombineVoxelGridsPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblCombineVoxelGridsPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblCombineVoxelGrids.fragment
    [<Import("iblCombineVoxelGridsPixelShader", "@babylonjs/core/Shaders/iblCombineVoxelGrids.fragment.js")>]
    let ``iblCombineVoxelGridsPixelShader``: VariableShape_iblCombineVoxelGridsPixelShader = jsNative

    /// Inline object shape of iblCombineVoxelGridsPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblCombineVoxelGridsPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblCombineVoxelGrids.fragment
    [<Import("iblCombineVoxelGridsPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblCombineVoxelGrids.fragment.js")>]
    let ``iblCombineVoxelGridsPixelShaderWGSL``: VariableShape_iblCombineVoxelGridsPixelShaderWGSL = jsNative

    /// Inline object shape of iblDominantDirectionPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblDominantDirectionPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblDominantDirection.fragment
    [<Import("iblDominantDirectionPixelShader", "@babylonjs/core/Shaders/iblDominantDirection.fragment.js")>]
    let ``iblDominantDirectionPixelShader``: VariableShape_iblDominantDirectionPixelShader = jsNative

    /// Inline object shape of iblDominantDirectionPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblDominantDirectionPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblDominantDirection.fragment
    [<Import("iblDominantDirectionPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblDominantDirection.fragment.js")>]
    let ``iblDominantDirectionPixelShaderWGSL``: VariableShape_iblDominantDirectionPixelShaderWGSL = jsNative

    /// Inline object shape of iblGenerateVoxelMipPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblGenerateVoxelMipPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblGenerateVoxelMip.fragment
    [<Import("iblGenerateVoxelMipPixelShader", "@babylonjs/core/Shaders/iblGenerateVoxelMip.fragment.js")>]
    let ``iblGenerateVoxelMipPixelShader``: VariableShape_iblGenerateVoxelMipPixelShader = jsNative

    /// Inline object shape of iblGenerateVoxelMipPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblGenerateVoxelMipPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblGenerateVoxelMip.fragment
    [<Import("iblGenerateVoxelMipPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblGenerateVoxelMip.fragment.js")>]
    let ``iblGenerateVoxelMipPixelShaderWGSL``: VariableShape_iblGenerateVoxelMipPixelShaderWGSL = jsNative

    /// Inline object shape of iblIcdfPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblIcdfPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblIcdf.fragment
    [<Import("iblIcdfPixelShader", "@babylonjs/core/Shaders/iblIcdf.fragment.js")>]
    let ``iblIcdfPixelShader``: VariableShape_iblIcdfPixelShader = jsNative

    /// Inline object shape of iblIcdfPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblIcdfPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblIcdf.fragment
    [<Import("iblIcdfPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblIcdf.fragment.js")>]
    let ``iblIcdfPixelShaderWGSL``: VariableShape_iblIcdfPixelShaderWGSL = jsNative

    /// Inline object shape of iblScaledLuminancePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblScaledLuminancePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblScaledLuminance.fragment
    [<Import("iblScaledLuminancePixelShader", "@babylonjs/core/Shaders/iblScaledLuminance.fragment.js")>]
    let ``iblScaledLuminancePixelShader``: VariableShape_iblScaledLuminancePixelShader = jsNative

    /// Inline object shape of iblScaledLuminancePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblScaledLuminancePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblScaledLuminance.fragment
    [<Import("iblScaledLuminancePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblScaledLuminance.fragment.js")>]
    let ``iblScaledLuminancePixelShaderWGSL``: VariableShape_iblScaledLuminancePixelShaderWGSL = jsNative

    /// Inline object shape of iblShadowAccumulationPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowAccumulationPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblShadowAccumulation.fragment
    [<Import("iblShadowAccumulationPixelShader", "@babylonjs/core/Shaders/iblShadowAccumulation.fragment.js")>]
    let ``iblShadowAccumulationPixelShader``: VariableShape_iblShadowAccumulationPixelShader = jsNative

    /// Inline object shape of iblShadowAccumulationPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowAccumulationPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblShadowAccumulation.fragment
    [<Import("iblShadowAccumulationPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblShadowAccumulation.fragment.js")>]
    let ``iblShadowAccumulationPixelShaderWGSL``: VariableShape_iblShadowAccumulationPixelShaderWGSL = jsNative

    /// Inline object shape of iblShadowDebugPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowDebugPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblShadowDebug.fragment
    [<Import("iblShadowDebugPixelShader", "@babylonjs/core/Shaders/iblShadowDebug.fragment.js")>]
    let ``iblShadowDebugPixelShader``: VariableShape_iblShadowDebugPixelShader = jsNative

    /// Inline object shape of iblShadowDebugPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowDebugPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblShadowDebug.fragment
    [<Import("iblShadowDebugPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblShadowDebug.fragment.js")>]
    let ``iblShadowDebugPixelShaderWGSL``: VariableShape_iblShadowDebugPixelShaderWGSL = jsNative

    /// Inline object shape of iblShadowGBufferDebugPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowGBufferDebugPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblShadowGBufferDebug.fragment
    [<Import("iblShadowGBufferDebugPixelShader", "@babylonjs/core/Shaders/iblShadowGBufferDebug.fragment.js")>]
    let ``iblShadowGBufferDebugPixelShader``: VariableShape_iblShadowGBufferDebugPixelShader = jsNative

    /// Inline object shape of iblShadowGBufferDebugPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowGBufferDebugPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblShadowGBufferDebug.fragment
    [<Import("iblShadowGBufferDebugPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblShadowGBufferDebug.fragment.js")>]
    let ``iblShadowGBufferDebugPixelShaderWGSL``: VariableShape_iblShadowGBufferDebugPixelShaderWGSL = jsNative

    /// Inline object shape of iblShadowsCombinePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowsCombinePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblShadowsCombine.fragment
    [<Import("iblShadowsCombinePixelShader", "@babylonjs/core/Shaders/iblShadowsCombine.fragment.js")>]
    let ``iblShadowsCombinePixelShader``: VariableShape_iblShadowsCombinePixelShader = jsNative

    /// Inline object shape of iblShadowsCombinePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowsCombinePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblShadowsCombine.fragment
    [<Import("iblShadowsCombinePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblShadowsCombine.fragment.js")>]
    let ``iblShadowsCombinePixelShaderWGSL``: VariableShape_iblShadowsCombinePixelShaderWGSL = jsNative

    /// Inline object shape of iblShadowSpatialBlurPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowSpatialBlurPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblShadowSpatialBlur.fragment
    [<Import("iblShadowSpatialBlurPixelShader", "@babylonjs/core/Shaders/iblShadowSpatialBlur.fragment.js")>]
    let ``iblShadowSpatialBlurPixelShader``: VariableShape_iblShadowSpatialBlurPixelShader = jsNative

    /// Inline object shape of iblShadowSpatialBlurPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowSpatialBlurPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblShadowSpatialBlur.fragment
    [<Import("iblShadowSpatialBlurPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblShadowSpatialBlur.fragment.js")>]
    let ``iblShadowSpatialBlurPixelShaderWGSL``: VariableShape_iblShadowSpatialBlurPixelShaderWGSL = jsNative

    /// Inline object shape of iblShadowVoxelTracingPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowVoxelTracingPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblShadowVoxelTracing.fragment
    [<Import("iblShadowVoxelTracingPixelShader", "@babylonjs/core/Shaders/iblShadowVoxelTracing.fragment.js")>]
    let ``iblShadowVoxelTracingPixelShader``: VariableShape_iblShadowVoxelTracingPixelShader = jsNative

    /// Inline object shape of iblShadowVoxelTracingPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblShadowVoxelTracingPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblShadowVoxelTracing.fragment
    [<Import("iblShadowVoxelTracingPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblShadowVoxelTracing.fragment.js")>]
    let ``iblShadowVoxelTracingPixelShaderWGSL``: VariableShape_iblShadowVoxelTracingPixelShaderWGSL = jsNative

    /// Inline object shape of iblVoxelGrid2dArrayDebugPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblVoxelGrid2dArrayDebugPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblVoxelGrid2dArrayDebug.fragment
    [<Import("iblVoxelGrid2dArrayDebugPixelShader", "@babylonjs/core/Shaders/iblVoxelGrid2dArrayDebug.fragment.js")>]
    let ``iblVoxelGrid2dArrayDebugPixelShader``: VariableShape_iblVoxelGrid2dArrayDebugPixelShader = jsNative

    /// Inline object shape of iblVoxelGrid2dArrayDebugPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblVoxelGrid2dArrayDebugPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblVoxelGrid2dArrayDebug.fragment
    [<Import("iblVoxelGrid2dArrayDebugPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblVoxelGrid2dArrayDebug.fragment.js")>]
    let ``iblVoxelGrid2dArrayDebugPixelShaderWGSL``: VariableShape_iblVoxelGrid2dArrayDebugPixelShaderWGSL = jsNative

    /// Inline object shape of iblVoxelGridPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_iblVoxelGridPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblVoxelGrid.fragment
    [<Import("iblVoxelGridPixelShader", "@babylonjs/core/Shaders/iblVoxelGrid.fragment.js")>]
    let ``iblVoxelGridPixelShader``: VariableShape_iblVoxelGridPixelShader = jsNative

    /// Inline object shape of iblVoxelGridPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblVoxelGridPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblVoxelGrid.fragment
    [<Import("iblVoxelGridPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/iblVoxelGrid.fragment.js")>]
    let ``iblVoxelGridPixelShaderWGSL``: VariableShape_iblVoxelGridPixelShaderWGSL = jsNative

    /// Inline object shape of iblVoxelGridVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_iblVoxelGridVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/iblVoxelGrid.vertex
    [<Import("iblVoxelGridVertexShader", "@babylonjs/core/Shaders/iblVoxelGrid.vertex.js")>]
    let ``iblVoxelGridVertexShader``: VariableShape_iblVoxelGridVertexShader = jsNative

    /// Inline object shape of iblVoxelGridVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_iblVoxelGridVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/iblVoxelGrid.vertex
    [<Import("iblVoxelGridVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/iblVoxelGrid.vertex.js")>]
    let ``iblVoxelGridVertexShaderWGSL``: VariableShape_iblVoxelGridVertexShaderWGSL = jsNative

    /// Inline object shape of IcoSphereBuilder.
    [<AllowNullLiteral>]
    type VariableShape_IcoSphereBuilder =
        abstract ``CreateIcoSphere``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateIcoSphere with get, set

    /// @babylonjs/core/Meshes/Builders/icoSphereBuilder.pure
    [<Import("IcoSphereBuilder", "@babylonjs/core/Meshes/Builders/icoSphereBuilder.pure.js")>]
    let ``IcoSphereBuilder``: VariableShape_IcoSphereBuilder = jsNative

    /// Inline object shape of imageProcessingCompatibility.
    [<AllowNullLiteral>]
    type VariableShape_imageProcessingCompatibility =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/imageProcessingCompatibility
    [<Import("imageProcessingCompatibility", "@babylonjs/core/Shaders/ShadersInclude/imageProcessingCompatibility.js")>]
    let ``imageProcessingCompatibility``: VariableShape_imageProcessingCompatibility = jsNative

    /// Inline object shape of imageProcessingCompatibilityWGSL.
    [<AllowNullLiteral>]
    type VariableShape_imageProcessingCompatibilityWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/imageProcessingCompatibility
    [<Import("imageProcessingCompatibilityWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/imageProcessingCompatibility.js")>]
    let ``imageProcessingCompatibilityWGSL``: VariableShape_imageProcessingCompatibilityWGSL = jsNative

    /// Inline object shape of imageProcessingDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_imageProcessingDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/imageProcessingDeclaration
    [<Import("imageProcessingDeclaration", "@babylonjs/core/Shaders/ShadersInclude/imageProcessingDeclaration.js")>]
    let ``imageProcessingDeclaration``: VariableShape_imageProcessingDeclaration = jsNative

    /// Inline object shape of imageProcessingDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_imageProcessingDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/imageProcessingDeclaration
    [<Import("imageProcessingDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/imageProcessingDeclaration.js")>]
    let ``imageProcessingDeclarationWGSL``: VariableShape_imageProcessingDeclarationWGSL = jsNative

    /// Inline object shape of imageProcessingFunctions.
    [<AllowNullLiteral>]
    type VariableShape_imageProcessingFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/imageProcessingFunctions
    [<Import("imageProcessingFunctions", "@babylonjs/core/Shaders/ShadersInclude/imageProcessingFunctions.js")>]
    let ``imageProcessingFunctions``: VariableShape_imageProcessingFunctions = jsNative

    /// Inline object shape of imageProcessingFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_imageProcessingFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/imageProcessingFunctions
    [<Import("imageProcessingFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/imageProcessingFunctions.js")>]
    let ``imageProcessingFunctionsWGSL``: VariableShape_imageProcessingFunctionsWGSL = jsNative

    /// Inline object shape of imageProcessingPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_imageProcessingPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/imageProcessing.fragment
    [<Import("imageProcessingPixelShader", "@babylonjs/core/Shaders/imageProcessing.fragment.js")>]
    let ``imageProcessingPixelShader``: VariableShape_imageProcessingPixelShader = jsNative

    /// Inline object shape of imageProcessingPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_imageProcessingPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/imageProcessing.fragment
    [<Import("imageProcessingPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/imageProcessing.fragment.js")>]
    let ``imageProcessingPixelShaderWGSL``: VariableShape_imageProcessingPixelShaderWGSL = jsNative

    /// Inline object shape of importanceSampling.
    [<AllowNullLiteral>]
    type VariableShape_importanceSampling =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/importanceSampling
    [<Import("importanceSampling", "@babylonjs/core/Shaders/ShadersInclude/importanceSampling.js")>]
    let ``importanceSampling``: VariableShape_importanceSampling = jsNative

    /// Inline object shape of importanceSamplingWGSL.
    [<AllowNullLiteral>]
    type VariableShape_importanceSamplingWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/importanceSampling
    [<Import("importanceSamplingWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/importanceSampling.js")>]
    let ``importanceSamplingWGSL``: VariableShape_importanceSamplingWGSL = jsNative

    /// Inline object shape of instancesDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_instancesDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/instancesDeclaration
    [<Import("instancesDeclaration", "@babylonjs/core/Shaders/ShadersInclude/instancesDeclaration.js")>]
    let ``instancesDeclaration``: VariableShape_instancesDeclaration = jsNative

    /// Inline object shape of instancesDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_instancesDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/instancesDeclaration
    [<Import("instancesDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/instancesDeclaration.js")>]
    let ``instancesDeclarationWGSL``: VariableShape_instancesDeclarationWGSL = jsNative

    /// Inline object shape of instancesVertex.
    [<AllowNullLiteral>]
    type VariableShape_instancesVertex =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/instancesVertex
    [<Import("instancesVertex", "@babylonjs/core/Shaders/ShadersInclude/instancesVertex.js")>]
    let ``instancesVertex``: VariableShape_instancesVertex = jsNative

    /// Inline object shape of instancesVertexWGSL.
    [<AllowNullLiteral>]
    type VariableShape_instancesVertexWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/instancesVertex
    [<Import("instancesVertexWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/instancesVertex.js")>]
    let ``instancesVertexWGSL``: VariableShape_instancesVertexWGSL = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("INT16_SIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``INT16_SIZE``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("INT32_SIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``INT32_SIZE``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("INT8_SIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``INT8_SIZE``: float = jsNative

    /// Inline object shape of intersectionFunctions.
    [<AllowNullLiteral>]
    type VariableShape_intersectionFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/intersectionFunctions
    [<Import("intersectionFunctions", "@babylonjs/core/Shaders/ShadersInclude/intersectionFunctions.js")>]
    let ``intersectionFunctions``: VariableShape_intersectionFunctions = jsNative

    /// Inline object shape of intersectionFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_intersectionFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/intersectionFunctions
    [<Import("intersectionFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/intersectionFunctions.js")>]
    let ``intersectionFunctionsWGSL``: VariableShape_intersectionFunctionsWGSL = jsNative

    /// Callable shape of IsBase64DataUrl.
    [<AllowNullLiteral>]
    type VariableFunction_IsBase64DataUrl =
        [<Emit("$0($1...)")>] abstract Invoke: ``uri``: string -> bool

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("IsBase64DataUrl", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``IsBase64DataUrl``: VariableFunction_IsBase64DataUrl = jsNative

    /// Callable shape of IsFileURL.
    [<AllowNullLiteral>]
    type VariableFunction_IsFileURL =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> bool

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("IsFileURL", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``IsFileURL``: VariableFunction_IsFileURL = jsNative

    /// Inline object shape of kernelBlurPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_kernelBlurPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/kernelBlur.fragment
    [<Import("kernelBlurPixelShader", "@babylonjs/core/Shaders/kernelBlur.fragment.js")>]
    let ``kernelBlurPixelShader``: VariableShape_kernelBlurPixelShader = jsNative

    /// Inline object shape of kernelBlurPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_kernelBlurPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/kernelBlur.fragment
    [<Import("kernelBlurPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/kernelBlur.fragment.js")>]
    let ``kernelBlurPixelShaderWGSL``: VariableShape_kernelBlurPixelShaderWGSL = jsNative

    /// Inline object shape of kernelBlurVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_kernelBlurVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/kernelBlur.vertex
    [<Import("kernelBlurVertexShader", "@babylonjs/core/Shaders/kernelBlur.vertex.js")>]
    let ``kernelBlurVertexShader``: VariableShape_kernelBlurVertexShader = jsNative

    /// Inline object shape of kernelBlurVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_kernelBlurVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/kernelBlur.vertex
    [<Import("kernelBlurVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/kernelBlur.vertex.js")>]
    let ``kernelBlurVertexShaderWGSL``: VariableShape_kernelBlurVertexShaderWGSL = jsNative

    /// Inline object shape of LatheBuilder.
    [<AllowNullLiteral>]
    type VariableShape_LatheBuilder =
        abstract ``CreateLathe``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateLathe with get, set

    /// @babylonjs/core/Meshes/Builders/latheBuilder.pure
    [<Import("LatheBuilder", "@babylonjs/core/Meshes/Builders/latheBuilder.pure.js")>]
    let ``LatheBuilder``: VariableShape_LatheBuilder = jsNative

    /// Inline object shape of layerPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_layerPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/layer.fragment
    [<Import("layerPixelShader", "@babylonjs/core/Shaders/layer.fragment.js")>]
    let ``layerPixelShader``: VariableShape_layerPixelShader = jsNative

    /// Inline object shape of layerPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_layerPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/layer.fragment
    [<Import("layerPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/layer.fragment.js")>]
    let ``layerPixelShaderWGSL``: VariableShape_layerPixelShaderWGSL = jsNative

    /// Inline object shape of layerVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_layerVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/layer.vertex
    [<Import("layerVertexShader", "@babylonjs/core/Shaders/layer.vertex.js")>]
    let ``layerVertexShader``: VariableShape_layerVertexShader = jsNative

    /// Inline object shape of layerVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_layerVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/layer.vertex
    [<Import("layerVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/layer.vertex.js")>]
    let ``layerVertexShaderWGSL``: VariableShape_layerVertexShaderWGSL = jsNative

    /// Inline object shape of lensFlarePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_lensFlarePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/lensFlare.fragment
    [<Import("lensFlarePixelShader", "@babylonjs/core/Shaders/lensFlare.fragment.js")>]
    let ``lensFlarePixelShader``: VariableShape_lensFlarePixelShader = jsNative

    /// Inline object shape of lensFlarePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lensFlarePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/lensFlare.fragment
    [<Import("lensFlarePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/lensFlare.fragment.js")>]
    let ``lensFlarePixelShaderWGSL``: VariableShape_lensFlarePixelShaderWGSL = jsNative

    /// Inline object shape of lensFlareVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_lensFlareVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/lensFlare.vertex
    [<Import("lensFlareVertexShader", "@babylonjs/core/Shaders/lensFlare.vertex.js")>]
    let ``lensFlareVertexShader``: VariableShape_lensFlareVertexShader = jsNative

    /// Inline object shape of lensFlareVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lensFlareVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/lensFlare.vertex
    [<Import("lensFlareVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/lensFlare.vertex.js")>]
    let ``lensFlareVertexShaderWGSL``: VariableShape_lensFlareVertexShaderWGSL = jsNative

    /// Inline object shape of lensHighlightsPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_lensHighlightsPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/lensHighlights.fragment
    [<Import("lensHighlightsPixelShader", "@babylonjs/core/Shaders/lensHighlights.fragment.js")>]
    let ``lensHighlightsPixelShader``: VariableShape_lensHighlightsPixelShader = jsNative

    /// Inline object shape of lightFragment.
    [<AllowNullLiteral>]
    type VariableShape_lightFragment =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/lightFragment
    [<Import("lightFragment", "@babylonjs/core/Shaders/ShadersInclude/lightFragment.js")>]
    let ``lightFragment``: VariableShape_lightFragment = jsNative

    /// Inline object shape of lightFragmentDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_lightFragmentDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/lightFragmentDeclaration
    [<Import("lightFragmentDeclaration", "@babylonjs/core/Shaders/ShadersInclude/lightFragmentDeclaration.js")>]
    let ``lightFragmentDeclaration``: VariableShape_lightFragmentDeclaration = jsNative

    /// Inline object shape of lightFragmentWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lightFragmentWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/lightFragment
    [<Import("lightFragmentWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/lightFragment.js")>]
    let ``lightFragmentWGSL``: VariableShape_lightFragmentWGSL = jsNative

    /// Inline object shape of lightingVolumeComputeShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lightingVolumeComputeShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/lightingVolume.compute
    [<Import("lightingVolumeComputeShaderWGSL", "@babylonjs/core/ShadersWGSL/lightingVolume.compute.js")>]
    let ``lightingVolumeComputeShaderWGSL``: VariableShape_lightingVolumeComputeShaderWGSL = jsNative

    /// Inline object shape of lightProxyPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_lightProxyPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/lightProxy.fragment
    [<Import("lightProxyPixelShader", "@babylonjs/core/Shaders/lightProxy.fragment.js")>]
    let ``lightProxyPixelShader``: VariableShape_lightProxyPixelShader = jsNative

    /// Inline object shape of lightProxyPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lightProxyPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/lightProxy.fragment
    [<Import("lightProxyPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/lightProxy.fragment.js")>]
    let ``lightProxyPixelShaderWGSL``: VariableShape_lightProxyPixelShaderWGSL = jsNative

    /// Inline object shape of lightProxyVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_lightProxyVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/lightProxy.vertex
    [<Import("lightProxyVertexShader", "@babylonjs/core/Shaders/lightProxy.vertex.js")>]
    let ``lightProxyVertexShader``: VariableShape_lightProxyVertexShader = jsNative

    /// Inline object shape of lightProxyVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lightProxyVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/lightProxy.vertex
    [<Import("lightProxyVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/lightProxy.vertex.js")>]
    let ``lightProxyVertexShaderWGSL``: VariableShape_lightProxyVertexShaderWGSL = jsNative

    /// Inline object shape of lightsFragmentFunctions.
    [<AllowNullLiteral>]
    type VariableShape_lightsFragmentFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/lightsFragmentFunctions
    [<Import("lightsFragmentFunctions", "@babylonjs/core/Shaders/ShadersInclude/lightsFragmentFunctions.js")>]
    let ``lightsFragmentFunctions``: VariableShape_lightsFragmentFunctions = jsNative

    /// Inline object shape of lightsFragmentFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lightsFragmentFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/lightsFragmentFunctions
    [<Import("lightsFragmentFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/lightsFragmentFunctions.js")>]
    let ``lightsFragmentFunctionsWGSL``: VariableShape_lightsFragmentFunctionsWGSL = jsNative

    /// Inline object shape of lightUboDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_lightUboDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/lightUboDeclaration
    [<Import("lightUboDeclaration", "@babylonjs/core/Shaders/ShadersInclude/lightUboDeclaration.js")>]
    let ``lightUboDeclaration``: VariableShape_lightUboDeclaration = jsNative

    /// Inline object shape of lightUboDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lightUboDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/lightUboDeclaration
    [<Import("lightUboDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/lightUboDeclaration.js")>]
    let ``lightUboDeclarationWGSL``: VariableShape_lightUboDeclarationWGSL = jsNative

    /// Inline object shape of lightVxFragmentDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_lightVxFragmentDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/lightVxFragmentDeclaration
    [<Import("lightVxFragmentDeclaration", "@babylonjs/core/Shaders/ShadersInclude/lightVxFragmentDeclaration.js")>]
    let ``lightVxFragmentDeclaration``: VariableShape_lightVxFragmentDeclaration = jsNative

    /// Inline object shape of lightVxFragmentDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lightVxFragmentDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/lightVxFragmentDeclaration
    [<Import("lightVxFragmentDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/lightVxFragmentDeclaration.js")>]
    let ``lightVxFragmentDeclarationWGSL``: VariableShape_lightVxFragmentDeclarationWGSL = jsNative

    /// Inline object shape of lightVxUboDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_lightVxUboDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/lightVxUboDeclaration
    [<Import("lightVxUboDeclaration", "@babylonjs/core/Shaders/ShadersInclude/lightVxUboDeclaration.js")>]
    let ``lightVxUboDeclaration``: VariableShape_lightVxUboDeclaration = jsNative

    /// Inline object shape of lightVxUboDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lightVxUboDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/lightVxUboDeclaration
    [<Import("lightVxUboDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/lightVxUboDeclaration.js")>]
    let ``lightVxUboDeclarationWGSL``: VariableShape_lightVxUboDeclarationWGSL = jsNative

    /// Inline object shape of linePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_linePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/line.fragment
    [<Import("linePixelShader", "@babylonjs/core/Shaders/line.fragment.js")>]
    let ``linePixelShader``: VariableShape_linePixelShader = jsNative

    /// Inline object shape of linePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_linePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/line.fragment
    [<Import("linePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/line.fragment.js")>]
    let ``linePixelShaderWGSL``: VariableShape_linePixelShaderWGSL = jsNative

    /// Inline object shape of LinesBuilder.
    [<AllowNullLiteral>]
    type VariableShape_LinesBuilder =
        abstract ``CreateDashedLines``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateDashedLines with get, set
        abstract ``CreateLineSystem``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateLineSystem with get, set
        abstract ``CreateLines``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateLines with get, set

    /// @babylonjs/core/Meshes/Builders/linesBuilder.pure
    [<Import("LinesBuilder", "@babylonjs/core/Meshes/Builders/linesBuilder.pure.js")>]
    let ``LinesBuilder``: VariableShape_LinesBuilder = jsNative

    /// Inline object shape of lineVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_lineVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/line.vertex
    [<Import("lineVertexShader", "@babylonjs/core/Shaders/line.vertex.js")>]
    let ``lineVertexShader``: VariableShape_lineVertexShader = jsNative

    /// Inline object shape of lineVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lineVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/line.vertex
    [<Import("lineVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/line.vertex.js")>]
    let ``lineVertexShaderWGSL``: VariableShape_lineVertexShaderWGSL = jsNative

    /// Callable shape of LoadAssetContainer.
    [<AllowNullLiteral>]
    type VariableFunction_LoadAssetContainer =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: U2<string, BabylonjsBindings.SimpleInterfaces.JavaScriptObject> * ``rootUrl``: string * ?``onError``: System.Action<string, obj option> * ?``addToScene``: bool -> BabylonjsBindings.SimpleClasses.AssetContainer

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("LoadAssetContainer", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``LoadAssetContainer``: VariableFunction_LoadAssetContainer = jsNative

    /// Callable shape of LoadDetailLevels.
    [<AllowNullLiteral>]
    type VariableFunction_LoadDetailLevels =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh -> unit

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("LoadDetailLevels", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``LoadDetailLevels``: VariableFunction_LoadDetailLevels = jsNative

    /// Callable shape of LoadFile.
    [<AllowNullLiteral>]
    type VariableFunction_LoadFile =
        [<Emit("$0($1...)")>] abstract Invoke: ``fileOrUrl``: U2<Browser.Types.File, string> * ``onSuccess``: System.Action<U2<string, JS.ArrayBuffer>, string option, string option> * ?``onProgress``: System.Action<Browser.Types.ProgressEvent> * ?``offlineProvider``: BabylonjsBindings.SimpleInterfaces.IOfflineProvider option * ?``useArrayBuffer``: bool * ?``onError``: System.Action<BabylonjsBindings.SimpleClasses.WebRequest option, BabylonjsBindings.SimpleClasses.LoadFileError option> * ?``onOpened``: System.Action<BabylonjsBindings.SimpleClasses.WebRequest> -> BabylonjsBindings.SimpleInterfaces.IFileRequest

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("LoadFile", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``LoadFile``: VariableFunction_LoadFile = jsNative

    /// Callable shape of LoadImage.
    [<AllowNullLiteral>]
    type VariableFunction_LoadImage =
        [<Emit("$0($1...)")>] abstract Invoke: ``input``: U4<string, JS.ArrayBuffer, JS.ArrayBufferView, Browser.Types.Blob> * ``onLoad``: System.Action<U2<Browser.Types.HTMLImageElement, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap>> * ``onError``: System.Action<string option, obj option> * ``offlineProvider``: BabylonjsBindings.SimpleInterfaces.IOfflineProvider option * ?``mimeType``: string * ?``imageBitmapOptions``: BabylonjsBindings.SimpleInterfaces.BrowserImageBitmapOptions * ?``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine option -> Browser.Types.HTMLImageElement option

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("LoadImage", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``LoadImage``: VariableFunction_LoadImage = jsNative

    /// Nested inline object shape used by LoadImageConfiguration.
    [<AllowNullLiteral>]
    type VariableShape_LoadImageConfigurationProperty1NullableReturnObject =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set

    /// Inline object shape of LoadImageConfiguration.
    [<AllowNullLiteral>]
    type VariableShape_LoadImageConfiguration =
        abstract ``getRequiredSize``: System.Func<U4<string, JS.ArrayBuffer, JS.ArrayBufferView, Browser.Types.Blob>, VariableShape_LoadImageConfigurationProperty1NullableReturnObject> option with get, set

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("LoadImageConfiguration", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``LoadImageConfiguration``: VariableShape_LoadImageConfiguration = jsNative

    /// Callable shape of LoadTextureFromTranscodeResult.
    [<AllowNullLiteral>]
    type VariableFunction_LoadTextureFromTranscodeResult =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``transcodeResult``: BabylonjsBindings.SimpleClasses.TranscodeResult -> unit

    /// @babylonjs/core/Misc/basis.pure
    [<Import("LoadTextureFromTranscodeResult", "@babylonjs/core/Misc/basis.pure.js")>]
    let ``LoadTextureFromTranscodeResult``: VariableFunction_LoadTextureFromTranscodeResult = jsNative

    /// Inline object shape of lodCubePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_lodCubePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/lodCube.fragment
    [<Import("lodCubePixelShader", "@babylonjs/core/Shaders/lodCube.fragment.js")>]
    let ``lodCubePixelShader``: VariableShape_lodCubePixelShader = jsNative

    /// Inline object shape of lodCubePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lodCubePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/lodCube.fragment
    [<Import("lodCubePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/lodCube.fragment.js")>]
    let ``lodCubePixelShaderWGSL``: VariableShape_lodCubePixelShaderWGSL = jsNative

    /// Inline object shape of lodPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_lodPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/lod.fragment
    [<Import("lodPixelShader", "@babylonjs/core/Shaders/lod.fragment.js")>]
    let ``lodPixelShader``: VariableShape_lodPixelShader = jsNative

    /// Inline object shape of lodPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_lodPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/lod.fragment
    [<Import("lodPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/lod.fragment.js")>]
    let ``lodPixelShaderWGSL``: VariableShape_lodPixelShaderWGSL = jsNative

    /// Inline object shape of logDepthDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_logDepthDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/logDepthDeclaration
    [<Import("logDepthDeclaration", "@babylonjs/core/Shaders/ShadersInclude/logDepthDeclaration.js")>]
    let ``logDepthDeclaration``: VariableShape_logDepthDeclaration = jsNative

    /// Inline object shape of logDepthDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_logDepthDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/logDepthDeclaration
    [<Import("logDepthDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/logDepthDeclaration.js")>]
    let ``logDepthDeclarationWGSL``: VariableShape_logDepthDeclarationWGSL = jsNative

    /// Inline object shape of logDepthFragment.
    [<AllowNullLiteral>]
    type VariableShape_logDepthFragment =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/logDepthFragment
    [<Import("logDepthFragment", "@babylonjs/core/Shaders/ShadersInclude/logDepthFragment.js")>]
    let ``logDepthFragment``: VariableShape_logDepthFragment = jsNative

    /// Inline object shape of logDepthFragmentWGSL.
    [<AllowNullLiteral>]
    type VariableShape_logDepthFragmentWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/logDepthFragment
    [<Import("logDepthFragmentWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/logDepthFragment.js")>]
    let ``logDepthFragmentWGSL``: VariableShape_logDepthFragmentWGSL = jsNative

    /// Inline object shape of logDepthVertex.
    [<AllowNullLiteral>]
    type VariableShape_logDepthVertex =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/logDepthVertex
    [<Import("logDepthVertex", "@babylonjs/core/Shaders/ShadersInclude/logDepthVertex.js")>]
    let ``logDepthVertex``: VariableShape_logDepthVertex = jsNative

    /// Inline object shape of logDepthVertexWGSL.
    [<AllowNullLiteral>]
    type VariableShape_logDepthVertexWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/logDepthVertex
    [<Import("logDepthVertexWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/logDepthVertex.js")>]
    let ``logDepthVertexWGSL``: VariableShape_logDepthVertexWGSL = jsNative

    /// Inline callable object shape used by logOperation.
    [<AllowNullLiteral>]
    type VariableInline_logOperation_Parameter2 =
        abstract ``file``: string with get, set
        abstract ``name``: string with get, set
        abstract ``version``: string with get, set
        abstract ``exporter_version``: string with get, set

    /// Callable shape of logOperation.
    [<AllowNullLiteral>]
    type VariableFunction_logOperation =
        [<Emit("$0($1...)")>] abstract Invoke: ``operation``: string * ``producer``: VariableInline_logOperation_Parameter2 -> string

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("logOperation", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``logOperation``: VariableFunction_logOperation = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("LONG_ZEROCODE_RUN", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``LONG_ZEROCODE_RUN``: float = jsNative

    /// Inline object shape of ltcHelperFunctions.
    [<AllowNullLiteral>]
    type VariableShape_ltcHelperFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/ltcHelperFunctions
    [<Import("ltcHelperFunctions", "@babylonjs/core/Shaders/ShadersInclude/ltcHelperFunctions.js")>]
    let ``ltcHelperFunctions``: VariableShape_ltcHelperFunctions = jsNative

    /// Inline object shape of ltcHelperFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_ltcHelperFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/ltcHelperFunctions
    [<Import("ltcHelperFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/ltcHelperFunctions.js")>]
    let ``ltcHelperFunctionsWGSL``: VariableShape_ltcHelperFunctionsWGSL = jsNative

    /// @babylonjs/core/Misc/halfFloat
    [<Import("MaxHalfFloat", "@babylonjs/core/Misc/halfFloat.js")>]
    let ``MaxHalfFloat``: float = jsNative

    /// Inline object shape of MeshBuilder.
    [<AllowNullLiteral>]
    type VariableShape_MeshBuilder =
        abstract ``CreateBox``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateBox with get, set
        abstract ``CreateTiledBox``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTiledBox with get, set
        abstract ``CreateSphere``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateSphere with get, set
        abstract ``CreateDisc``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateDisc with get, set
        abstract ``CreateIcoSphere``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateIcoSphere with get, set
        abstract ``CreateRibbon``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateRibbon with get, set
        abstract ``CreateCylinder``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateCylinder with get, set
        abstract ``CreateTorus``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTorus with get, set
        abstract ``CreateTorusKnot``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTorusKnot with get, set
        abstract ``CreateLineSystem``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateLineSystem with get, set
        abstract ``CreateLines``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateLines with get, set
        abstract ``CreateDashedLines``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateDashedLines with get, set
        abstract ``ExtrudeShape``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ExtrudeShape with get, set
        abstract ``ExtrudeShapeCustom``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ExtrudeShapeCustom with get, set
        abstract ``CreateLathe``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateLathe with get, set
        abstract ``CreateTiledPlane``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTiledPlane with get, set
        abstract ``CreatePlane``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreatePlane with get, set
        abstract ``CreateGround``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateGround with get, set
        abstract ``CreateTiledGround``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTiledGround with get, set
        abstract ``CreateGroundFromHeightMap``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateGroundFromHeightMap with get, set
        abstract ``CreatePolygon``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreatePolygon with get, set
        abstract ``ExtrudePolygon``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ExtrudePolygon with get, set
        abstract ``CreateTube``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTube with get, set
        abstract ``CreatePolyhedron``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreatePolyhedron with get, set
        abstract ``CreateGeodesic``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateGeodesic with get, set
        abstract ``CreateGoldberg``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateGoldberg with get, set
        abstract ``CreateDecal``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateDecal with get, set
        abstract ``CreateCapsule``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateCapsule with get, set
        abstract ``CreateText``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateText with get, set

    /// @babylonjs/core/Meshes/meshBuilder.pure
    [<Import("MeshBuilder", "@babylonjs/core/Meshes/meshBuilder.pure.js")>]
    let ``MeshBuilder``: VariableShape_MeshBuilder = jsNative

    /// Inline object shape of meshUboDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_meshUboDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/meshUboDeclaration
    [<Import("meshUboDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/meshUboDeclaration.js")>]
    let ``meshUboDeclarationWGSL``: VariableShape_meshUboDeclarationWGSL = jsNative

    /// Inline object shape of meshUVSpaceRendererFinaliserPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererFinaliserPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/meshUVSpaceRendererFinaliser.fragment
    [<Import("meshUVSpaceRendererFinaliserPixelShader", "@babylonjs/core/Shaders/meshUVSpaceRendererFinaliser.fragment.js")>]
    let ``meshUVSpaceRendererFinaliserPixelShader``: VariableShape_meshUVSpaceRendererFinaliserPixelShader = jsNative

    /// Inline object shape of meshUVSpaceRendererFinaliserPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererFinaliserPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/meshUVSpaceRendererFinaliser.fragment
    [<Import("meshUVSpaceRendererFinaliserPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/meshUVSpaceRendererFinaliser.fragment.js")>]
    let ``meshUVSpaceRendererFinaliserPixelShaderWGSL``: VariableShape_meshUVSpaceRendererFinaliserPixelShaderWGSL = jsNative

    /// Inline object shape of meshUVSpaceRendererFinaliserVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererFinaliserVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/meshUVSpaceRendererFinaliser.vertex
    [<Import("meshUVSpaceRendererFinaliserVertexShader", "@babylonjs/core/Shaders/meshUVSpaceRendererFinaliser.vertex.js")>]
    let ``meshUVSpaceRendererFinaliserVertexShader``: VariableShape_meshUVSpaceRendererFinaliserVertexShader = jsNative

    /// Inline object shape of meshUVSpaceRendererFinaliserVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererFinaliserVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/meshUVSpaceRendererFinaliser.vertex
    [<Import("meshUVSpaceRendererFinaliserVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/meshUVSpaceRendererFinaliser.vertex.js")>]
    let ``meshUVSpaceRendererFinaliserVertexShaderWGSL``: VariableShape_meshUVSpaceRendererFinaliserVertexShaderWGSL = jsNative

    /// Inline object shape of meshUVSpaceRendererMaskerPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererMaskerPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/meshUVSpaceRendererMasker.fragment
    [<Import("meshUVSpaceRendererMaskerPixelShader", "@babylonjs/core/Shaders/meshUVSpaceRendererMasker.fragment.js")>]
    let ``meshUVSpaceRendererMaskerPixelShader``: VariableShape_meshUVSpaceRendererMaskerPixelShader = jsNative

    /// Inline object shape of meshUVSpaceRendererMaskerPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererMaskerPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/meshUVSpaceRendererMasker.fragment
    [<Import("meshUVSpaceRendererMaskerPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/meshUVSpaceRendererMasker.fragment.js")>]
    let ``meshUVSpaceRendererMaskerPixelShaderWGSL``: VariableShape_meshUVSpaceRendererMaskerPixelShaderWGSL = jsNative

    /// Inline object shape of meshUVSpaceRendererMaskerVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererMaskerVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/meshUVSpaceRendererMasker.vertex
    [<Import("meshUVSpaceRendererMaskerVertexShader", "@babylonjs/core/Shaders/meshUVSpaceRendererMasker.vertex.js")>]
    let ``meshUVSpaceRendererMaskerVertexShader``: VariableShape_meshUVSpaceRendererMaskerVertexShader = jsNative

    /// Inline object shape of meshUVSpaceRendererMaskerVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererMaskerVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/meshUVSpaceRendererMasker.vertex
    [<Import("meshUVSpaceRendererMaskerVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/meshUVSpaceRendererMasker.vertex.js")>]
    let ``meshUVSpaceRendererMaskerVertexShaderWGSL``: VariableShape_meshUVSpaceRendererMaskerVertexShaderWGSL = jsNative

    /// Inline object shape of meshUVSpaceRendererPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/meshUVSpaceRenderer.fragment
    [<Import("meshUVSpaceRendererPixelShader", "@babylonjs/core/Shaders/meshUVSpaceRenderer.fragment.js")>]
    let ``meshUVSpaceRendererPixelShader``: VariableShape_meshUVSpaceRendererPixelShader = jsNative

    /// Inline object shape of meshUVSpaceRendererPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/meshUVSpaceRenderer.fragment
    [<Import("meshUVSpaceRendererPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/meshUVSpaceRenderer.fragment.js")>]
    let ``meshUVSpaceRendererPixelShaderWGSL``: VariableShape_meshUVSpaceRendererPixelShaderWGSL = jsNative

    /// Inline object shape of meshUVSpaceRendererVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/meshUVSpaceRenderer.vertex
    [<Import("meshUVSpaceRendererVertexShader", "@babylonjs/core/Shaders/meshUVSpaceRenderer.vertex.js")>]
    let ``meshUVSpaceRendererVertexShader``: VariableShape_meshUVSpaceRendererVertexShader = jsNative

    /// Inline object shape of meshUVSpaceRendererVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_meshUVSpaceRendererVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/meshUVSpaceRenderer.vertex
    [<Import("meshUVSpaceRendererVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/meshUVSpaceRenderer.vertex.js")>]
    let ``meshUVSpaceRendererVertexShaderWGSL``: VariableShape_meshUVSpaceRendererVertexShaderWGSL = jsNative

    /// Inline object shape of minmaxReduxPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_minmaxReduxPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/minmaxRedux.fragment
    [<Import("minmaxReduxPixelShader", "@babylonjs/core/Shaders/minmaxRedux.fragment.js")>]
    let ``minmaxReduxPixelShader``: VariableShape_minmaxReduxPixelShader = jsNative

    /// Inline object shape of minmaxReduxPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_minmaxReduxPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/minmaxRedux.fragment
    [<Import("minmaxReduxPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/minmaxRedux.fragment.js")>]
    let ``minmaxReduxPixelShaderWGSL``: VariableShape_minmaxReduxPixelShaderWGSL = jsNative

    /// Nested inline object shape used by MixamoAimChildOverrides.
    [<AllowNullLiteral>]
    type VariableShape_MixamoAimChildOverridesIndexerObject =
        [<EmitIndexer>] abstract Item: ``key``: BabylonjsBindings.StringEnums.WebXRBodyJoint -> BabylonjsBindings.StringEnums.WebXRBodyJoint option with get, set

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<Import("MixamoAimChildOverrides", "@babylonjs/core/XR/features/WebXRBodyTracking.pure.js")>]
    let ``MixamoAimChildOverrides``: VariableShape_MixamoAimChildOverridesIndexerObject = jsNative

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<Import("MixamoRigMapping", "@babylonjs/core/XR/features/WebXRBodyTracking.pure.js")>]
    let ``MixamoRigMapping``: BabylonjsBindings.TypeAliases.XRBodyMeshRigMapping = jsNative

    /// Inline object shape of morphTargetsVertex.
    [<AllowNullLiteral>]
    type VariableShape_morphTargetsVertex =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/morphTargetsVertex
    [<Import("morphTargetsVertex", "@babylonjs/core/Shaders/ShadersInclude/morphTargetsVertex.js")>]
    let ``morphTargetsVertex``: VariableShape_morphTargetsVertex = jsNative

    /// Inline object shape of morphTargetsVertexDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_morphTargetsVertexDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/morphTargetsVertexDeclaration
    [<Import("morphTargetsVertexDeclaration", "@babylonjs/core/Shaders/ShadersInclude/morphTargetsVertexDeclaration.js")>]
    let ``morphTargetsVertexDeclaration``: VariableShape_morphTargetsVertexDeclaration = jsNative

    /// Inline object shape of morphTargetsVertexDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_morphTargetsVertexDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/morphTargetsVertexDeclaration
    [<Import("morphTargetsVertexDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/morphTargetsVertexDeclaration.js")>]
    let ``morphTargetsVertexDeclarationWGSL``: VariableShape_morphTargetsVertexDeclarationWGSL = jsNative

    /// Inline object shape of morphTargetsVertexGlobal.
    [<AllowNullLiteral>]
    type VariableShape_morphTargetsVertexGlobal =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/morphTargetsVertexGlobal
    [<Import("morphTargetsVertexGlobal", "@babylonjs/core/Shaders/ShadersInclude/morphTargetsVertexGlobal.js")>]
    let ``morphTargetsVertexGlobal``: VariableShape_morphTargetsVertexGlobal = jsNative

    /// Inline object shape of morphTargetsVertexGlobalDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_morphTargetsVertexGlobalDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/morphTargetsVertexGlobalDeclaration
    [<Import("morphTargetsVertexGlobalDeclaration", "@babylonjs/core/Shaders/ShadersInclude/morphTargetsVertexGlobalDeclaration.js")>]
    let ``morphTargetsVertexGlobalDeclaration``: VariableShape_morphTargetsVertexGlobalDeclaration = jsNative

    /// Inline object shape of morphTargetsVertexGlobalDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_morphTargetsVertexGlobalDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/morphTargetsVertexGlobalDeclaration
    [<Import("morphTargetsVertexGlobalDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/morphTargetsVertexGlobalDeclaration.js")>]
    let ``morphTargetsVertexGlobalDeclarationWGSL``: VariableShape_morphTargetsVertexGlobalDeclarationWGSL = jsNative

    /// Inline object shape of morphTargetsVertexGlobalWGSL.
    [<AllowNullLiteral>]
    type VariableShape_morphTargetsVertexGlobalWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/morphTargetsVertexGlobal
    [<Import("morphTargetsVertexGlobalWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/morphTargetsVertexGlobal.js")>]
    let ``morphTargetsVertexGlobalWGSL``: VariableShape_morphTargetsVertexGlobalWGSL = jsNative

    /// Inline object shape of morphTargetsVertexWGSL.
    [<AllowNullLiteral>]
    type VariableShape_morphTargetsVertexWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/morphTargetsVertex
    [<Import("morphTargetsVertexWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/morphTargetsVertex.js")>]
    let ``morphTargetsVertexWGSL``: VariableShape_morphTargetsVertexWGSL = jsNative

    /// Inline object shape of motionBlurPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_motionBlurPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/motionBlur.fragment
    [<Import("motionBlurPixelShader", "@babylonjs/core/Shaders/motionBlur.fragment.js")>]
    let ``motionBlurPixelShader``: VariableShape_motionBlurPixelShader = jsNative

    /// Inline object shape of motionBlurPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_motionBlurPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/motionBlur.fragment
    [<Import("motionBlurPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/motionBlur.fragment.js")>]
    let ``motionBlurPixelShaderWGSL``: VariableShape_motionBlurPixelShaderWGSL = jsNative

    /// Inline object shape of OBJFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_OBJFileLoaderMetadata =
        abstract ``name``: string with get
        abstract ``extensions``: string with get

    /// @babylonjs/loaders/OBJ/objFileLoader.metadata
    [<Import("OBJFileLoaderMetadata", "@babylonjs/loaders/OBJ/objFileLoader.metadata.js")>]
    let ``OBJFileLoaderMetadata``: VariableShape_OBJFileLoaderMetadata = jsNative

    /// Inline object shape of oitBackBlendPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_oitBackBlendPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/oitBackBlend.fragment
    [<Import("oitBackBlendPixelShader", "@babylonjs/core/Shaders/oitBackBlend.fragment.js")>]
    let ``oitBackBlendPixelShader``: VariableShape_oitBackBlendPixelShader = jsNative

    /// Inline object shape of oitBackBlendPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_oitBackBlendPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/oitBackBlend.fragment
    [<Import("oitBackBlendPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/oitBackBlend.fragment.js")>]
    let ``oitBackBlendPixelShaderWGSL``: VariableShape_oitBackBlendPixelShaderWGSL = jsNative

    /// Inline object shape of oitFinalPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_oitFinalPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/oitFinal.fragment
    [<Import("oitFinalPixelShader", "@babylonjs/core/Shaders/oitFinal.fragment.js")>]
    let ``oitFinalPixelShader``: VariableShape_oitFinalPixelShader = jsNative

    /// Inline object shape of oitFinalPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_oitFinalPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/oitFinal.fragment
    [<Import("oitFinalPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/oitFinal.fragment.js")>]
    let ``oitFinalPixelShaderWGSL``: VariableShape_oitFinalPixelShaderWGSL = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<Import("OnAudioEngineV2CreatedObservable", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``OnAudioEngineV2CreatedObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.SimpleClasses.AudioEngineV2> = jsNative

    /// Inline object shape of openpbrPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_openpbrPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/openpbr.fragment
    [<Import("openpbrPixelShader", "@babylonjs/core/Shaders/openpbr.fragment.js")>]
    let ``openpbrPixelShader``: VariableShape_openpbrPixelShader = jsNative

    /// Inline object shape of openpbrPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_openpbrPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/openpbr.fragment
    [<Import("openpbrPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/openpbr.fragment.js")>]
    let ``openpbrPixelShaderWGSL``: VariableShape_openpbrPixelShaderWGSL = jsNative

    /// Inline object shape of openpbrVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_openpbrVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/openpbr.vertex
    [<Import("openpbrVertexShader", "@babylonjs/core/Shaders/openpbr.vertex.js")>]
    let ``openpbrVertexShader``: VariableShape_openpbrVertexShader = jsNative

    /// Inline object shape of openpbrVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_openpbrVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/openpbr.vertex
    [<Import("openpbrVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/openpbr.vertex.js")>]
    let ``openpbrVertexShaderWGSL``: VariableShape_openpbrVertexShaderWGSL = jsNative

    /// Nested inline object shape used by OptionalPathExceptionsList.
    [<AllowNullLiteral>]
    type VariableShape_OptionalPathExceptionsListElementObject =
        abstract ``regex``: BabylonjsBindings.SimpleInterfaces.BrowserRegExp with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/gltfPathToObjectConverter
    [<Import("OptionalPathExceptionsList", "@babylonjs/loaders/glTF/2.0/Extensions/gltfPathToObjectConverter.js")>]
    let ``OptionalPathExceptionsList``: ResizeArray<VariableShape_OptionalPathExceptionsListElementObject> = jsNative

    /// Inline object shape of outlinePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_outlinePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/outline.fragment
    [<Import("outlinePixelShader", "@babylonjs/core/Shaders/outline.fragment.js")>]
    let ``outlinePixelShader``: VariableShape_outlinePixelShader = jsNative

    /// Inline object shape of outlinePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_outlinePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/outline.fragment
    [<Import("outlinePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/outline.fragment.js")>]
    let ``outlinePixelShaderWGSL``: VariableShape_outlinePixelShaderWGSL = jsNative

    /// Inline object shape of outlineVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_outlineVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/outline.vertex
    [<Import("outlineVertexShader", "@babylonjs/core/Shaders/outline.vertex.js")>]
    let ``outlineVertexShader``: VariableShape_outlineVertexShader = jsNative

    /// Inline object shape of outlineVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_outlineVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/outline.vertex
    [<Import("outlineVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/outline.vertex.js")>]
    let ``outlineVertexShaderWGSL``: VariableShape_outlineVertexShaderWGSL = jsNative

    /// Inline object shape of packingFunctions.
    [<AllowNullLiteral>]
    type VariableShape_packingFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/packingFunctions
    [<Import("packingFunctions", "@babylonjs/core/Shaders/ShadersInclude/packingFunctions.js")>]
    let ``packingFunctions``: VariableShape_packingFunctions = jsNative

    /// Inline object shape of packingFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_packingFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/packingFunctions
    [<Import("packingFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/packingFunctions.js")>]
    let ``packingFunctionsWGSL``: VariableShape_packingFunctionsWGSL = jsNative

    /// Callable shape of PadNumber.
    [<AllowNullLiteral>]
    type VariableFunction_PadNumber =
        [<Emit("$0($1...)")>] abstract Invoke: ``num``: float * ``length``: float -> string

    /// @babylonjs/core/Misc/stringTools
    [<Import("PadNumber", "@babylonjs/core/Misc/stringTools.js")>]
    let ``PadNumber``: VariableFunction_PadNumber = jsNative

    /// Inline object shape of particlesPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_particlesPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/particles.fragment
    [<Import("particlesPixelShader", "@babylonjs/core/Shaders/particles.fragment.js")>]
    let ``particlesPixelShader``: VariableShape_particlesPixelShader = jsNative

    /// Inline object shape of particlesPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_particlesPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/particles.fragment
    [<Import("particlesPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/particles.fragment.js")>]
    let ``particlesPixelShaderWGSL``: VariableShape_particlesPixelShaderWGSL = jsNative

    /// Inline object shape of particlesVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_particlesVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/particles.vertex
    [<Import("particlesVertexShader", "@babylonjs/core/Shaders/particles.vertex.js")>]
    let ``particlesVertexShader``: VariableShape_particlesVertexShader = jsNative

    /// Inline object shape of particlesVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_particlesVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/particles.vertex
    [<Import("particlesVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/particles.vertex.js")>]
    let ``particlesVertexShaderWGSL``: VariableShape_particlesVertexShaderWGSL = jsNative

    /// Inline object shape of passCubePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_passCubePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/passCube.fragment
    [<Import("passCubePixelShader", "@babylonjs/core/Shaders/passCube.fragment.js")>]
    let ``passCubePixelShader``: VariableShape_passCubePixelShader = jsNative

    /// Inline object shape of passCubePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_passCubePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/passCube.fragment
    [<Import("passCubePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/passCube.fragment.js")>]
    let ``passCubePixelShaderWGSL``: VariableShape_passCubePixelShaderWGSL = jsNative

    /// Inline object shape of passPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_passPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/pass.fragment
    [<Import("passPixelShader", "@babylonjs/core/Shaders/pass.fragment.js")>]
    let ``passPixelShader``: VariableShape_passPixelShader = jsNative

    /// Inline object shape of passPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_passPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/pass.fragment
    [<Import("passPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/pass.fragment.js")>]
    let ``passPixelShaderWGSL``: VariableShape_passPixelShaderWGSL = jsNative

    /// Inline object shape of pbrBRDFFunctions.
    [<AllowNullLiteral>]
    type VariableShape_pbrBRDFFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/pbrBRDFFunctions
    [<Import("pbrBRDFFunctions", "@babylonjs/core/Shaders/ShadersInclude/pbrBRDFFunctions.js")>]
    let ``pbrBRDFFunctions``: VariableShape_pbrBRDFFunctions = jsNative

    /// Inline object shape of pbrBRDFFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_pbrBRDFFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/pbrBRDFFunctions
    [<Import("pbrBRDFFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/pbrBRDFFunctions.js")>]
    let ``pbrBRDFFunctionsWGSL``: VariableShape_pbrBRDFFunctionsWGSL = jsNative

    /// Inline object shape of pbrPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_pbrPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/pbr.fragment
    [<Import("pbrPixelShader", "@babylonjs/core/Shaders/pbr.fragment.js")>]
    let ``pbrPixelShader``: VariableShape_pbrPixelShader = jsNative

    /// Inline object shape of pbrPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_pbrPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/pbr.fragment
    [<Import("pbrPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/pbr.fragment.js")>]
    let ``pbrPixelShaderWGSL``: VariableShape_pbrPixelShaderWGSL = jsNative

    /// Inline object shape of pbrVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_pbrVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/pbr.vertex
    [<Import("pbrVertexShader", "@babylonjs/core/Shaders/pbr.vertex.js")>]
    let ``pbrVertexShader``: VariableShape_pbrVertexShader = jsNative

    /// Inline object shape of pbrVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_pbrVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/pbr.vertex
    [<Import("pbrVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/pbr.vertex.js")>]
    let ``pbrVertexShaderWGSL``: VariableShape_pbrVertexShaderWGSL = jsNative

    /// @babylonjs/core/Maths/math.constants
    [<Import("PHI", "@babylonjs/core/Maths/math.constants.js")>]
    let ``PHI``: float = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<Import("PickingCustomization", "@babylonjs/core/Culling/ray.core.js")>]
    let ``PickingCustomization``: BabylonjsBindings.SimpleInterfaces.IPickingCustomization = jsNative

    /// Inline object shape of pickingPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_pickingPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/picking.fragment
    [<Import("pickingPixelShader", "@babylonjs/core/Shaders/picking.fragment.js")>]
    let ``pickingPixelShader``: VariableShape_pickingPixelShader = jsNative

    /// Inline object shape of pickingPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_pickingPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/picking.fragment
    [<Import("pickingPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/picking.fragment.js")>]
    let ``pickingPixelShaderWGSL``: VariableShape_pickingPixelShaderWGSL = jsNative

    /// Inline object shape of pickingVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_pickingVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/picking.vertex
    [<Import("pickingVertexShader", "@babylonjs/core/Shaders/picking.vertex.js")>]
    let ``pickingVertexShader``: VariableShape_pickingVertexShader = jsNative

    /// Inline object shape of pickingVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_pickingVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/picking.vertex
    [<Import("pickingVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/picking.vertex.js")>]
    let ``pickingVertexShaderWGSL``: VariableShape_pickingVertexShaderWGSL = jsNative

    /// Inline object shape of PlaneBuilder.
    [<AllowNullLiteral>]
    type VariableShape_PlaneBuilder =
        abstract ``CreatePlane``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreatePlane with get, set

    /// @babylonjs/core/Meshes/Builders/planeBuilder.pure
    [<Import("PlaneBuilder", "@babylonjs/core/Meshes/Builders/planeBuilder.pure.js")>]
    let ``PlaneBuilder``: VariableShape_PlaneBuilder = jsNative

    /// Inline object shape of PolygonBuilder.
    [<AllowNullLiteral>]
    type VariableShape_PolygonBuilder =
        abstract ``ExtrudePolygon``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ExtrudePolygon with get, set
        abstract ``CreatePolygon``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreatePolygon with get, set

    /// @babylonjs/core/Meshes/Builders/polygonBuilder.pure
    [<Import("PolygonBuilder", "@babylonjs/core/Meshes/Builders/polygonBuilder.pure.js")>]
    let ``PolygonBuilder``: VariableShape_PolygonBuilder = jsNative

    /// Inline object shape of PolyhedronBuilder.
    [<AllowNullLiteral>]
    type VariableShape_PolyhedronBuilder =
        abstract ``CreatePolyhedron``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreatePolyhedron with get, set

    /// @babylonjs/core/Meshes/Builders/polyhedronBuilder.pure
    [<Import("PolyhedronBuilder", "@babylonjs/core/Meshes/Builders/polyhedronBuilder.pure.js")>]
    let ``PolyhedronBuilder``: VariableShape_PolyhedronBuilder = jsNative

    /// Inline object shape of postprocessVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_postprocessVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/postprocess.vertex
    [<Import("postprocessVertexShader", "@babylonjs/core/Shaders/postprocess.vertex.js")>]
    let ``postprocessVertexShader``: VariableShape_postprocessVertexShader = jsNative

    /// Inline object shape of postprocessVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_postprocessVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/postprocess.vertex
    [<Import("postprocessVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/postprocess.vertex.js")>]
    let ``postprocessVertexShaderWGSL``: VariableShape_postprocessVertexShaderWGSL = jsNative

    /// Inline object shape of proceduralVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_proceduralVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/procedural.vertex
    [<Import("proceduralVertexShader", "@babylonjs/core/Shaders/procedural.vertex.js")>]
    let ``proceduralVertexShader``: VariableShape_proceduralVertexShader = jsNative

    /// Inline object shape of proceduralVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_proceduralVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/procedural.vertex
    [<Import("proceduralVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/procedural.vertex.js")>]
    let ``proceduralVertexShaderWGSL``: VariableShape_proceduralVertexShaderWGSL = jsNative

    /// Callable shape of ReadFile.
    [<AllowNullLiteral>]
    type VariableFunction_ReadFile =
        [<Emit("$0($1...)")>] abstract Invoke: ``file``: Browser.Types.File * ``onSuccess``: System.Action<obj> * ?``onProgress``: System.Func<Browser.Types.ProgressEvent, obj> * ?``useArrayBuffer``: bool * ?``onError``: System.Action<BabylonjsBindings.SimpleClasses.ReadFileError> -> BabylonjsBindings.SimpleInterfaces.IFileRequest

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("ReadFile", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``ReadFile``: VariableFunction_ReadFile = jsNative

    /// Inline object shape of reflectionFunction.
    [<AllowNullLiteral>]
    type VariableShape_reflectionFunction =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/reflectionFunction
    [<Import("reflectionFunction", "@babylonjs/core/Shaders/ShadersInclude/reflectionFunction.js")>]
    let ``reflectionFunction``: VariableShape_reflectionFunction = jsNative

    /// Inline object shape of reflectionFunctionWGSL.
    [<AllowNullLiteral>]
    type VariableShape_reflectionFunctionWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/reflectionFunction
    [<Import("reflectionFunctionWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/reflectionFunction.js")>]
    let ``reflectionFunctionWGSL``: VariableShape_reflectionFunctionWGSL = jsNative

    /// Inline object shape of refractionPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_refractionPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/refraction.fragment
    [<Import("refractionPixelShader", "@babylonjs/core/Shaders/refraction.fragment.js")>]
    let ``refractionPixelShader``: VariableShape_refractionPixelShader = jsNative

    /// Inline object shape of renderableTextureFormatToIndex.
    [<AllowNullLiteral>]
    type VariableShape_renderableTextureFormatToIndex =
        [<EmitIndexer>] abstract Item: ``name``: string -> float with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuTextureManager
    [<Import("renderableTextureFormatToIndex", "@babylonjs/core/Engines/WebGPU/webgpuTextureManager.js")>]
    let ``renderableTextureFormatToIndex``: VariableShape_renderableTextureFormatToIndex = jsNative

    /// Callable shape of RequestFile.
    [<AllowNullLiteral>]
    type VariableFunction_RequestFile =
        [<Emit("$0($1...)")>] abstract Invoke: ``url``: string * ?``onSuccess``: System.Action<U2<string, JS.ArrayBuffer>, BabylonjsBindings.SimpleClasses.WebRequest option> * ?``onProgress``: System.Action<Browser.Types.ProgressEvent> * ?``offlineProvider``: BabylonjsBindings.SimpleInterfaces.IOfflineProvider option * ?``useArrayBuffer``: bool * ?``onError``: System.Action<BabylonjsBindings.SimpleClasses.RequestFileError> * ?``onOpened``: System.Action<BabylonjsBindings.SimpleClasses.WebRequest> -> BabylonjsBindings.SimpleInterfaces.IFileRequest

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("RequestFile", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``RequestFile``: VariableFunction_RequestFile = jsNative

    /// Inline object shape of rgbdDecodePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_rgbdDecodePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/rgbdDecode.fragment
    [<Import("rgbdDecodePixelShader", "@babylonjs/core/Shaders/rgbdDecode.fragment.js")>]
    let ``rgbdDecodePixelShader``: VariableShape_rgbdDecodePixelShader = jsNative

    /// Inline object shape of rgbdDecodePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_rgbdDecodePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/rgbdDecode.fragment
    [<Import("rgbdDecodePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/rgbdDecode.fragment.js")>]
    let ``rgbdDecodePixelShaderWGSL``: VariableShape_rgbdDecodePixelShaderWGSL = jsNative

    /// Inline object shape of rgbdEncodePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_rgbdEncodePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/rgbdEncode.fragment
    [<Import("rgbdEncodePixelShader", "@babylonjs/core/Shaders/rgbdEncode.fragment.js")>]
    let ``rgbdEncodePixelShader``: VariableShape_rgbdEncodePixelShader = jsNative

    /// Inline object shape of rgbdEncodePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_rgbdEncodePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/rgbdEncode.fragment
    [<Import("rgbdEncodePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/rgbdEncode.fragment.js")>]
    let ``rgbdEncodePixelShaderWGSL``: VariableShape_rgbdEncodePixelShaderWGSL = jsNative

    /// Inline object shape of RibbonBuilder.
    [<AllowNullLiteral>]
    type VariableShape_RibbonBuilder =
        abstract ``CreateRibbon``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateRibbon with get, set

    /// @babylonjs/core/Meshes/Builders/ribbonBuilder.pure
    [<Import("RibbonBuilder", "@babylonjs/core/Meshes/Builders/ribbonBuilder.pure.js")>]
    let ``RibbonBuilder``: VariableShape_RibbonBuilder = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeAny", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeAny``: BabylonjsBindings.SimpleClasses.RichType<obj> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeBoolean", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeBoolean``: BabylonjsBindings.SimpleClasses.RichType<bool> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeColor3", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeColor3``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.Color3> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeColor4", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeColor4``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.Color4> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeFlowGraphInteger", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeFlowGraphInteger``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.FlowGraphInteger> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeMatrix", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeMatrix``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.Matrix> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeMatrix2D", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeMatrix2D``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.FlowGraphMatrix2D> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeMatrix3D", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeMatrix3D``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.FlowGraphMatrix3D> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeNumber", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeNumber``: BabylonjsBindings.SimpleClasses.RichType<float> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeQuaternion", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeQuaternion``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.Quaternion> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeString", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeString``: BabylonjsBindings.SimpleClasses.RichType<string> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeVector2", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeVector2``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.Vector2> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeVector3", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeVector3``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.Vector3> = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<Import("RichTypeVector4", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RichTypeVector4``: BabylonjsBindings.SimpleClasses.RichType<BabylonjsBindings.SimpleClasses.Vector4> = jsNative

    /// Inline object shape of rsmFullGlobalIlluminationPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_rsmFullGlobalIlluminationPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/rsmFullGlobalIllumination.fragment
    [<Import("rsmFullGlobalIlluminationPixelShader", "@babylonjs/core/Shaders/rsmFullGlobalIllumination.fragment.js")>]
    let ``rsmFullGlobalIlluminationPixelShader``: VariableShape_rsmFullGlobalIlluminationPixelShader = jsNative

    /// Inline object shape of rsmFullGlobalIlluminationPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_rsmFullGlobalIlluminationPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/rsmFullGlobalIllumination.fragment
    [<Import("rsmFullGlobalIlluminationPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/rsmFullGlobalIllumination.fragment.js")>]
    let ``rsmFullGlobalIlluminationPixelShaderWGSL``: VariableShape_rsmFullGlobalIlluminationPixelShaderWGSL = jsNative

    /// Inline object shape of rsmGlobalIlluminationPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_rsmGlobalIlluminationPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/rsmGlobalIllumination.fragment
    [<Import("rsmGlobalIlluminationPixelShader", "@babylonjs/core/Shaders/rsmGlobalIllumination.fragment.js")>]
    let ``rsmGlobalIlluminationPixelShader``: VariableShape_rsmGlobalIlluminationPixelShader = jsNative

    /// Inline object shape of rsmGlobalIlluminationPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_rsmGlobalIlluminationPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/rsmGlobalIllumination.fragment
    [<Import("rsmGlobalIlluminationPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/rsmGlobalIllumination.fragment.js")>]
    let ``rsmGlobalIlluminationPixelShaderWGSL``: VariableShape_rsmGlobalIlluminationPixelShaderWGSL = jsNative

    /// Inline object shape of samplerFragmentDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_samplerFragmentDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/samplerFragmentDeclaration
    [<Import("samplerFragmentDeclaration", "@babylonjs/core/Shaders/ShadersInclude/samplerFragmentDeclaration.js")>]
    let ``samplerFragmentDeclaration``: VariableShape_samplerFragmentDeclaration = jsNative

    /// Inline object shape of samplerFragmentDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_samplerFragmentDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/samplerFragmentDeclaration
    [<Import("samplerFragmentDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/samplerFragmentDeclaration.js")>]
    let ``samplerFragmentDeclarationWGSL``: VariableShape_samplerFragmentDeclarationWGSL = jsNative

    /// @babylonjs/core/Rendering/geometryBufferRenderer.pure
    [<Import("Samplers", "@babylonjs/core/Rendering/geometryBufferRenderer.pure.js")>]
    let ``Samplers``: ResizeArray<string> = jsNative

    /// Inline object shape of Scalar.
    [<AllowNullLiteral>]
    type VariableShape_Scalar =
        abstract ``TwoPi``: float with get, set
        abstract ``Sign``: System.Func<float, float> with get, set
        abstract ``Log2``: System.Func<float, float> with get, set
        abstract ``HCF``: System.Func<float, float, float> with get, set
        abstract ``ExtractAsInt``: ``value``: float -> float
        abstract ``WithinEpsilon``: ``a``: float * ``b``: float * ?``epsilon``: float -> bool
        abstract ``OutsideRange``: ``num``: float * ``min``: float * ``max``: float * ?``epsilon``: float -> bool
        abstract ``RandomRange``: ``min``: float * ``max``: float -> float
        abstract ``Lerp``: ``start``: float * ``end``: float * ``amount``: float -> float
        abstract ``LerpAngle``: ``start``: float * ``end``: float * ``amount``: float -> float
        abstract ``InverseLerp``: ``a``: float * ``b``: float * ``value``: float -> float
        abstract ``Hermite``: ``value1``: float * ``tangent1``: float * ``value2``: float * ``tangent2``: float * ``amount``: float -> float
        abstract ``Hermite1stDerivative``: ``value1``: float * ``tangent1``: float * ``value2``: float * ``tangent2``: float * ``time``: float -> float
        abstract ``Clamp``: ``value``: float * ?``min``: float * ?``max``: float -> float
        abstract ``NormalizeRadians``: ``angle``: float -> float
        abstract ``ToHex``: ``i``: float -> string
        abstract ``ILog2``: ``value``: float -> float
        abstract ``Repeat``: ``value``: float * ``length``: float -> float
        abstract ``Normalize``: ``value``: float * ``min``: float * ``max``: float -> float
        abstract ``Denormalize``: ``normalized``: float * ``min``: float * ``max``: float -> float
        abstract ``DeltaAngle``: ``current``: float * ``target``: float -> float
        abstract ``PingPong``: ``tx``: float * ``length``: float -> float
        abstract ``SmoothStep``: ``from``: float * ``to``: float * ``tx``: float -> float
        abstract ``MoveTowards``: ``current``: float * ``target``: float * ``maxDelta``: float -> float
        abstract ``MoveTowardsAngle``: ``current``: float * ``target``: float * ``maxDelta``: float -> float
        abstract ``RangeToPercent``: ``number``: float * ``min``: float * ``max``: float -> float
        abstract ``PercentToRange``: ``percent``: float * ``min``: float * ``max``: float -> float
        abstract ``HighestCommonFactor``: ``a``: float * ``b``: float -> float

    /// @babylonjs/core/Maths/math.scalar
    [<Import("Scalar", "@babylonjs/core/Maths/math.scalar.js")>]
    let ``Scalar``: VariableShape_Scalar = jsNative

    /// Inline object shape of sceneFragmentDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_sceneFragmentDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/sceneFragmentDeclaration
    [<Import("sceneFragmentDeclaration", "@babylonjs/core/Shaders/ShadersInclude/sceneFragmentDeclaration.js")>]
    let ``sceneFragmentDeclaration``: VariableShape_sceneFragmentDeclaration = jsNative

    /// Inline object shape of sceneUboDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_sceneUboDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/sceneUboDeclaration
    [<Import("sceneUboDeclaration", "@babylonjs/core/Shaders/ShadersInclude/sceneUboDeclaration.js")>]
    let ``sceneUboDeclaration``: VariableShape_sceneUboDeclaration = jsNative

    /// Inline object shape of sceneUboDeclarationWGSL.
    [<AllowNullLiteral>]
    type VariableShape_sceneUboDeclarationWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/sceneUboDeclaration
    [<Import("sceneUboDeclarationWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/sceneUboDeclaration.js")>]
    let ``sceneUboDeclarationWGSL``: VariableShape_sceneUboDeclarationWGSL = jsNative

    /// Inline object shape of sceneVertexDeclaration.
    [<AllowNullLiteral>]
    type VariableShape_sceneVertexDeclaration =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/sceneVertexDeclaration
    [<Import("sceneVertexDeclaration", "@babylonjs/core/Shaders/ShadersInclude/sceneVertexDeclaration.js")>]
    let ``sceneVertexDeclaration``: VariableShape_sceneVertexDeclaration = jsNative

    /// Inline object shape of ScreenshotTools.
    [<AllowNullLiteral>]
    type VariableShape_ScreenshotTools =
        abstract ``CreateScreenshot``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateScreenshot with get, set
        abstract ``CreateScreenshotAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateScreenshotAsync with get, set
        abstract ``CreateScreenshotWithResizeAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateScreenshotWithResizeAsync with get, set
        abstract ``CreateScreenshotUsingRenderTarget``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateScreenshotUsingRenderTarget with get, set
        abstract ``CreateScreenshotUsingRenderTargetAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateScreenshotUsingRenderTargetAsync with get, set
        abstract ``CreateScreenshotForFrameGraphAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateScreenshotForFrameGraphAsync with get, set

    /// @babylonjs/core/Misc/screenshotTools.pure
    [<Import("ScreenshotTools", "@babylonjs/core/Misc/screenshotTools.pure.js")>]
    let ``ScreenshotTools``: VariableShape_ScreenshotTools = jsNative

    /// Inline object shape of screenSpaceCurvaturePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_screenSpaceCurvaturePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/screenSpaceCurvature.fragment
    [<Import("screenSpaceCurvaturePixelShader", "@babylonjs/core/Shaders/screenSpaceCurvature.fragment.js")>]
    let ``screenSpaceCurvaturePixelShader``: VariableShape_screenSpaceCurvaturePixelShader = jsNative

    /// Inline object shape of screenSpaceReflection2BlurCombinerPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_screenSpaceReflection2BlurCombinerPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/screenSpaceReflection2BlurCombiner.fragment
    [<Import("screenSpaceReflection2BlurCombinerPixelShader", "@babylonjs/core/Shaders/screenSpaceReflection2BlurCombiner.fragment.js")>]
    let ``screenSpaceReflection2BlurCombinerPixelShader``: VariableShape_screenSpaceReflection2BlurCombinerPixelShader = jsNative

    /// Inline object shape of screenSpaceReflection2BlurCombinerPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_screenSpaceReflection2BlurCombinerPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/screenSpaceReflection2BlurCombiner.fragment
    [<Import("screenSpaceReflection2BlurCombinerPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/screenSpaceReflection2BlurCombiner.fragment.js")>]
    let ``screenSpaceReflection2BlurCombinerPixelShaderWGSL``: VariableShape_screenSpaceReflection2BlurCombinerPixelShaderWGSL = jsNative

    /// Inline object shape of screenSpaceReflection2BlurPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_screenSpaceReflection2BlurPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/screenSpaceReflection2Blur.fragment
    [<Import("screenSpaceReflection2BlurPixelShader", "@babylonjs/core/Shaders/screenSpaceReflection2Blur.fragment.js")>]
    let ``screenSpaceReflection2BlurPixelShader``: VariableShape_screenSpaceReflection2BlurPixelShader = jsNative

    /// Inline object shape of screenSpaceReflection2BlurPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_screenSpaceReflection2BlurPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/screenSpaceReflection2Blur.fragment
    [<Import("screenSpaceReflection2BlurPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/screenSpaceReflection2Blur.fragment.js")>]
    let ``screenSpaceReflection2BlurPixelShaderWGSL``: VariableShape_screenSpaceReflection2BlurPixelShaderWGSL = jsNative

    /// Inline object shape of screenSpaceReflection2PixelShader.
    [<AllowNullLiteral>]
    type VariableShape_screenSpaceReflection2PixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/screenSpaceReflection2.fragment
    [<Import("screenSpaceReflection2PixelShader", "@babylonjs/core/Shaders/screenSpaceReflection2.fragment.js")>]
    let ``screenSpaceReflection2PixelShader``: VariableShape_screenSpaceReflection2PixelShader = jsNative

    /// Inline object shape of screenSpaceReflection2PixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_screenSpaceReflection2PixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/screenSpaceReflection2.fragment
    [<Import("screenSpaceReflection2PixelShaderWGSL", "@babylonjs/core/ShadersWGSL/screenSpaceReflection2.fragment.js")>]
    let ``screenSpaceReflection2PixelShaderWGSL``: VariableShape_screenSpaceReflection2PixelShaderWGSL = jsNative

    /// Inline object shape of screenSpaceReflectionPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_screenSpaceReflectionPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/screenSpaceReflection.fragment
    [<Import("screenSpaceReflectionPixelShader", "@babylonjs/core/Shaders/screenSpaceReflection.fragment.js")>]
    let ``screenSpaceReflectionPixelShader``: VariableShape_screenSpaceReflectionPixelShader = jsNative

    /// Callable shape of SetBasisTranscoderWorker.
    [<AllowNullLiteral>]
    type VariableFunction_SetBasisTranscoderWorker =
        [<Emit("$0($1...)")>] abstract Invoke: ``worker``: BabylonjsBindings.SimpleInterfaces.BrowserWorker -> unit

    /// @babylonjs/core/Misc/basis.pure
    [<Import("SetBasisTranscoderWorker", "@babylonjs/core/Misc/basis.pure.js")>]
    let ``SetBasisTranscoderWorker``: VariableFunction_SetBasisTranscoderWorker = jsNative

    /// Inline callable object shape used by SetCorsBehavior.
    [<AllowNullLiteral>]
    type VariableInline_SetCorsBehavior_Parameter2 =
        abstract ``crossOrigin``: string option with get, set

    /// Callable shape of SetCorsBehavior.
    [<AllowNullLiteral>]
    type VariableFunction_SetCorsBehavior =
        [<Emit("$0($1...)")>] abstract Invoke: ``url``: U2<string, ResizeArray<string>> * ``element``: VariableInline_SetCorsBehavior_Parameter2 -> unit

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("SetCorsBehavior", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``SetCorsBehavior``: VariableFunction_SetCorsBehavior = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/smartFilterFragmentOutputBlock.pure
    [<Import("SfeModeDefine", "@babylonjs/core/Materials/Node/Blocks/Fragment/smartFilterFragmentOutputBlock.pure.js")>]
    let ``SfeModeDefine``: string = jsNative

    /// @babylonjs/core/Materials/shaderMaterial.pure
    [<Import("ShaderMaterialCreateFromSnippetAsync", "@babylonjs/core/Materials/shaderMaterial.pure.js")>]
    let ``ShaderMaterialCreateFromSnippetAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ShaderMaterialParseFromSnippetAsync = jsNative

    /// Inline object shape of shadowMapFragment.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapFragment =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/shadowMapFragment
    [<Import("shadowMapFragment", "@babylonjs/core/Shaders/ShadersInclude/shadowMapFragment.js")>]
    let ``shadowMapFragment``: VariableShape_shadowMapFragment = jsNative

    /// Inline object shape of shadowMapFragmentSoftTransparentShadow.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapFragmentSoftTransparentShadow =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/shadowMapFragmentSoftTransparentShadow
    [<Import("shadowMapFragmentSoftTransparentShadow", "@babylonjs/core/Shaders/ShadersInclude/shadowMapFragmentSoftTransparentShadow.js")>]
    let ``shadowMapFragmentSoftTransparentShadow``: VariableShape_shadowMapFragmentSoftTransparentShadow = jsNative

    /// Inline object shape of shadowMapFragmentSoftTransparentShadowWGSL.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapFragmentSoftTransparentShadowWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/shadowMapFragmentSoftTransparentShadow
    [<Import("shadowMapFragmentSoftTransparentShadowWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/shadowMapFragmentSoftTransparentShadow.js")>]
    let ``shadowMapFragmentSoftTransparentShadowWGSL``: VariableShape_shadowMapFragmentSoftTransparentShadowWGSL = jsNative

    /// Inline object shape of shadowMapFragmentWGSL.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapFragmentWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/shadowMapFragment
    [<Import("shadowMapFragmentWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/shadowMapFragment.js")>]
    let ``shadowMapFragmentWGSL``: VariableShape_shadowMapFragmentWGSL = jsNative

    /// Inline object shape of shadowMapPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/shadowMap.fragment
    [<Import("shadowMapPixelShader", "@babylonjs/core/Shaders/shadowMap.fragment.js")>]
    let ``shadowMapPixelShader``: VariableShape_shadowMapPixelShader = jsNative

    /// Inline object shape of shadowMapPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/shadowMap.fragment
    [<Import("shadowMapPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/shadowMap.fragment.js")>]
    let ``shadowMapPixelShaderWGSL``: VariableShape_shadowMapPixelShaderWGSL = jsNative

    /// Inline object shape of shadowMapVertexMetric.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapVertexMetric =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/shadowMapVertexMetric
    [<Import("shadowMapVertexMetric", "@babylonjs/core/Shaders/ShadersInclude/shadowMapVertexMetric.js")>]
    let ``shadowMapVertexMetric``: VariableShape_shadowMapVertexMetric = jsNative

    /// Inline object shape of shadowMapVertexMetricWGSL.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapVertexMetricWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/shadowMapVertexMetric
    [<Import("shadowMapVertexMetricWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/shadowMapVertexMetric.js")>]
    let ``shadowMapVertexMetricWGSL``: VariableShape_shadowMapVertexMetricWGSL = jsNative

    /// Inline object shape of shadowMapVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/shadowMap.vertex
    [<Import("shadowMapVertexShader", "@babylonjs/core/Shaders/shadowMap.vertex.js")>]
    let ``shadowMapVertexShader``: VariableShape_shadowMapVertexShader = jsNative

    /// Inline object shape of shadowMapVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_shadowMapVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/shadowMap.vertex
    [<Import("shadowMapVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/shadowMap.vertex.js")>]
    let ``shadowMapVertexShaderWGSL``: VariableShape_shadowMapVertexShaderWGSL = jsNative

    /// Inline object shape of shadowsFragmentFunctions.
    [<AllowNullLiteral>]
    type VariableShape_shadowsFragmentFunctions =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/shadowsFragmentFunctions
    [<Import("shadowsFragmentFunctions", "@babylonjs/core/Shaders/ShadersInclude/shadowsFragmentFunctions.js")>]
    let ``shadowsFragmentFunctions``: VariableShape_shadowsFragmentFunctions = jsNative

    /// Inline object shape of shadowsFragmentFunctionsWGSL.
    [<AllowNullLiteral>]
    type VariableShape_shadowsFragmentFunctionsWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/shadowsFragmentFunctions
    [<Import("shadowsFragmentFunctionsWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/shadowsFragmentFunctions.js")>]
    let ``shadowsFragmentFunctionsWGSL``: VariableShape_shadowsFragmentFunctionsWGSL = jsNative

    /// Inline object shape of shadowsVertex.
    [<AllowNullLiteral>]
    type VariableShape_shadowsVertex =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/shadowsVertex
    [<Import("shadowsVertex", "@babylonjs/core/Shaders/ShadersInclude/shadowsVertex.js")>]
    let ``shadowsVertex``: VariableShape_shadowsVertex = jsNative

    /// Inline object shape of shadowsVertexWGSL.
    [<AllowNullLiteral>]
    type VariableShape_shadowsVertexWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/shadowsVertex
    [<Import("shadowsVertexWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/shadowsVertex.js")>]
    let ``shadowsVertexWGSL``: VariableShape_shadowsVertexWGSL = jsNative

    /// Inline object shape of ShapeBuilder.
    [<AllowNullLiteral>]
    type VariableShape_ShapeBuilder =
        abstract ``ExtrudeShape``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ExtrudeShape with get, set
        abstract ``ExtrudeShapeCustom``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ExtrudeShapeCustom with get, set

    /// @babylonjs/core/Meshes/Builders/shapeBuilder.pure
    [<Import("ShapeBuilder", "@babylonjs/core/Meshes/Builders/shapeBuilder.pure.js")>]
    let ``ShapeBuilder``: VariableShape_ShapeBuilder = jsNative

    /// Inline object shape of sharpenPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_sharpenPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/sharpen.fragment
    [<Import("sharpenPixelShader", "@babylonjs/core/Shaders/sharpen.fragment.js")>]
    let ``sharpenPixelShader``: VariableShape_sharpenPixelShader = jsNative

    /// Inline object shape of sharpenPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_sharpenPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/sharpen.fragment
    [<Import("sharpenPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/sharpen.fragment.js")>]
    let ``sharpenPixelShaderWGSL``: VariableShape_sharpenPixelShaderWGSL = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("SHORT_ZEROCODE_RUN", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``SHORT_ZEROCODE_RUN``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("SHORTEST_LONG_RUN", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``SHORTEST_LONG_RUN``: float = jsNative

    /// Inline object shape of SphereBuilder.
    [<AllowNullLiteral>]
    type VariableShape_SphereBuilder =
        abstract ``CreateSphere``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateSphere with get, set

    /// @babylonjs/core/Meshes/Builders/sphereBuilder.pure
    [<Import("SphereBuilder", "@babylonjs/core/Meshes/Builders/sphereBuilder.pure.js")>]
    let ``SphereBuilder``: VariableShape_SphereBuilder = jsNative

    /// Nested inline object shape used by SPLATFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty1Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserTrue with get

    /// Nested inline object shape used by SPLATFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty2Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserTrue with get

    /// Nested inline object shape used by SPLATFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty3Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserTrue with get

    /// Nested inline object shape used by SPLATFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty4Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserFalse with get

    /// Nested inline object shape used by SPLATFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty5Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserTrue with get

    /// Nested inline object shape used by SPLATFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_SPLATFileLoaderMetadataProperty2Object =
        abstract ``.splat``: VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty1Object with get
        abstract ``.ply``: VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty2Object with get
        abstract ``.spz``: VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty3Object with get
        abstract ``.json``: VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty4Object with get
        abstract ``.sog``: VariableShape_SPLATFileLoaderMetadataProperty2ObjectProperty5Object with get

    /// Inline object shape of SPLATFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_SPLATFileLoaderMetadata =
        abstract ``name``: string with get
        abstract ``extensions``: VariableShape_SPLATFileLoaderMetadataProperty2Object with get

    /// @babylonjs/loaders/SPLAT/splatFileLoader.metadata
    [<Import("SPLATFileLoaderMetadata", "@babylonjs/loaders/SPLAT/splatFileLoader.metadata.js")>]
    let ``SPLATFileLoaderMetadata``: VariableShape_SPLATFileLoaderMetadata = jsNative

    /// Inline object shape of spriteMapPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_spriteMapPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/spriteMap.fragment
    [<Import("spriteMapPixelShader", "@babylonjs/core/Shaders/spriteMap.fragment.js")>]
    let ``spriteMapPixelShader``: VariableShape_spriteMapPixelShader = jsNative

    /// Inline object shape of spriteMapVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_spriteMapVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/spriteMap.vertex
    [<Import("spriteMapVertexShader", "@babylonjs/core/Shaders/spriteMap.vertex.js")>]
    let ``spriteMapVertexShader``: VariableShape_spriteMapVertexShader = jsNative

    /// Inline object shape of spritesPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_spritesPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/sprites.fragment
    [<Import("spritesPixelShader", "@babylonjs/core/Shaders/sprites.fragment.js")>]
    let ``spritesPixelShader``: VariableShape_spritesPixelShader = jsNative

    /// Inline object shape of spritesPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_spritesPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/sprites.fragment
    [<Import("spritesPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/sprites.fragment.js")>]
    let ``spritesPixelShaderWGSL``: VariableShape_spritesPixelShaderWGSL = jsNative

    /// Inline object shape of spritesVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_spritesVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/sprites.vertex
    [<Import("spritesVertexShader", "@babylonjs/core/Shaders/sprites.vertex.js")>]
    let ``spritesVertexShader``: VariableShape_spritesVertexShader = jsNative

    /// Inline object shape of spritesVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_spritesVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/sprites.vertex
    [<Import("spritesVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/sprites.vertex.js")>]
    let ``spritesVertexShaderWGSL``: VariableShape_spritesVertexShaderWGSL = jsNative

    /// Inline object shape of ssao2PixelShader.
    [<AllowNullLiteral>]
    type VariableShape_ssao2PixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ssao2.fragment
    [<Import("ssao2PixelShader", "@babylonjs/core/Shaders/ssao2.fragment.js")>]
    let ``ssao2PixelShader``: VariableShape_ssao2PixelShader = jsNative

    /// Inline object shape of ssao2PixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_ssao2PixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ssao2.fragment
    [<Import("ssao2PixelShaderWGSL", "@babylonjs/core/ShadersWGSL/ssao2.fragment.js")>]
    let ``ssao2PixelShaderWGSL``: VariableShape_ssao2PixelShaderWGSL = jsNative

    /// Inline object shape of ssaoCombinePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_ssaoCombinePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ssaoCombine.fragment
    [<Import("ssaoCombinePixelShader", "@babylonjs/core/Shaders/ssaoCombine.fragment.js")>]
    let ``ssaoCombinePixelShader``: VariableShape_ssaoCombinePixelShader = jsNative

    /// Inline object shape of ssaoCombinePixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_ssaoCombinePixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ssaoCombine.fragment
    [<Import("ssaoCombinePixelShaderWGSL", "@babylonjs/core/ShadersWGSL/ssaoCombine.fragment.js")>]
    let ``ssaoCombinePixelShaderWGSL``: VariableShape_ssaoCombinePixelShaderWGSL = jsNative

    /// Inline object shape of ssaoPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_ssaoPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ssao.fragment
    [<Import("ssaoPixelShader", "@babylonjs/core/Shaders/ssao.fragment.js")>]
    let ``ssaoPixelShader``: VariableShape_ssaoPixelShader = jsNative

    /// Inline object shape of standardPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_standardPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/standard.fragment
    [<Import("standardPixelShader", "@babylonjs/core/Shaders/standard.fragment.js")>]
    let ``standardPixelShader``: VariableShape_standardPixelShader = jsNative

    /// Callable shape of StartsWith.
    [<AllowNullLiteral>]
    type VariableFunction_StartsWith =
        [<Emit("$0($1...)")>] abstract Invoke: ``str``: string * ``suffix``: string -> bool

    /// @babylonjs/core/Misc/stringTools
    [<Import("StartsWith", "@babylonjs/core/Misc/stringTools.js")>]
    let ``StartsWith``: VariableFunction_StartsWith = jsNative

    /// Inline object shape of stereoscopicInterlacePixelShader.
    [<AllowNullLiteral>]
    type VariableShape_stereoscopicInterlacePixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/stereoscopicInterlace.fragment
    [<Import("stereoscopicInterlacePixelShader", "@babylonjs/core/Shaders/stereoscopicInterlace.fragment.js")>]
    let ``stereoscopicInterlacePixelShader``: VariableShape_stereoscopicInterlacePixelShader = jsNative

    /// Nested inline object shape used by STLFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_STLFileLoaderMetadataProperty2ObjectProperty1Object =
        abstract ``isBinary``: BabylonjsBindings.SimpleInterfaces.BrowserTrue with get

    /// Nested inline object shape used by STLFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_STLFileLoaderMetadataProperty2Object =
        abstract ``.stl``: VariableShape_STLFileLoaderMetadataProperty2ObjectProperty1Object with get

    /// Inline object shape of STLFileLoaderMetadata.
    [<AllowNullLiteral>]
    type VariableShape_STLFileLoaderMetadata =
        abstract ``name``: string with get
        abstract ``extensions``: VariableShape_STLFileLoaderMetadataProperty2Object with get

    /// @babylonjs/loaders/STL/stlFileLoader.metadata
    [<Import("STLFileLoaderMetadata", "@babylonjs/loaders/STL/stlFileLoader.metadata.js")>]
    let ``STLFileLoaderMetadata``: VariableShape_STLFileLoaderMetadata = jsNative

    /// Inline object shape of StringTools.
    [<AllowNullLiteral>]
    type VariableShape_StringTools =
        abstract ``EndsWith``: System.Func<string, string, bool> with get, set
        abstract ``StartsWith``: System.Func<string, string, bool> with get, set
        abstract ``Decode``: System.Func<U2<JS.Uint8Array, JS.Uint16Array>, string> with get, set
        abstract ``EncodeArrayBufferToBase64``: System.Func<U2<JS.ArrayBuffer, JS.ArrayBufferView>, string> with get, set
        abstract ``DecodeBase64ToString``: System.Func<string, string> with get, set
        abstract ``DecodeBase64ToBinary``: System.Func<string, JS.ArrayBuffer> with get, set
        abstract ``PadNumber``: System.Func<float, float, string> with get, set

    /// @babylonjs/core/Misc/stringTools
    [<Import("StringTools", "@babylonjs/core/Misc/stringTools.js")>]
    let ``StringTools``: VariableShape_StringTools = jsNative

    /// Inline object shape of taaPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_taaPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/taa.fragment
    [<Import("taaPixelShader", "@babylonjs/core/Shaders/taa.fragment.js")>]
    let ``taaPixelShader``: VariableShape_taaPixelShader = jsNative

    /// Inline object shape of taaPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_taaPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/taa.fragment
    [<Import("taaPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/taa.fragment.js")>]
    let ``taaPixelShaderWGSL``: VariableShape_taaPixelShaderWGSL = jsNative

    /// Inline object shape of TempMaterialIndexContainer.
    [<AllowNullLiteral>]
    type VariableShape_TempMaterialIndexContainer =
        [<EmitIndexer>] abstract Item: ``key``: string -> BabylonjsBindings.SimpleClasses.Material with get, set

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("TempMaterialIndexContainer", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``TempMaterialIndexContainer``: VariableShape_TempMaterialIndexContainer = jsNative

    /// Inline object shape of TempMorphTargetManagerIndexContainer.
    [<AllowNullLiteral>]
    type VariableShape_TempMorphTargetManagerIndexContainer =
        [<EmitIndexer>] abstract Item: ``key``: string -> BabylonjsBindings.SimpleClasses.MorphTargetManager with get, set

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("TempMorphTargetManagerIndexContainer", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``TempMorphTargetManagerIndexContainer``: VariableShape_TempMorphTargetManagerIndexContainer = jsNative

    /// Inline object shape of TempSkeletonIndexContainer.
    [<AllowNullLiteral>]
    type VariableShape_TempSkeletonIndexContainer =
        [<EmitIndexer>] abstract Item: ``key``: float -> BabylonjsBindings.SimpleClasses.Skeleton with get, set

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("TempSkeletonIndexContainer", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``TempSkeletonIndexContainer``: VariableShape_TempSkeletonIndexContainer = jsNative

    /// Inline callable object shape used by TestBase64DataUrl.
    [<AllowNullLiteral>]
    type VariableInline_TestBase64DataUrl_Return =
        abstract ``match``: bool with get, set
        abstract ``type``: string with get, set

    /// Callable shape of TestBase64DataUrl.
    [<AllowNullLiteral>]
    type VariableFunction_TestBase64DataUrl =
        [<Emit("$0($1...)")>] abstract Invoke: ``uri``: string -> VariableInline_TestBase64DataUrl_Return

    /// @babylonjs/core/Misc/fileTools.pure
    [<Import("TestBase64DataUrl", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``TestBase64DataUrl``: VariableFunction_TestBase64DataUrl = jsNative

    /// Inline object shape of TextureTools.
    [<AllowNullLiteral>]
    type VariableShape_TextureTools =
        abstract ``CreateResizedCopy``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateResizedCopy with get, set
        abstract ``ApplyPostProcess``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ApplyPostProcess with get, set
        abstract ``ToHalfFloat``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ToHalfFloat with get, set
        abstract ``FromHalfFloat``: BabylonjsBindings.SimpleFunctions.FunctionBinding_FromHalfFloat with get, set
        abstract ``GetTextureDataAsync``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetTextureDataAsync with get, set

    /// @babylonjs/core/Misc/textureTools
    [<Import("TextureTools", "@babylonjs/core/Misc/textureTools.js")>]
    let ``TextureTools``: VariableShape_TextureTools = jsNative

    /// Inline object shape of TGATools.
    [<AllowNullLiteral>]
    type VariableShape_TGATools =
        abstract ``GetTGAHeader``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetTGAHeader with get, set
        abstract ``UploadContent``: BabylonjsBindings.SimpleFunctions.FunctionBinding_UploadContent with get, set
        abstract ``_getImageData8bits``: System.Func<obj, JS.Uint8Array, JS.Uint8Array, float, float, float, float, float, float, JS.Uint8Array> with get, set
        abstract ``_getImageData16bits``: System.Func<obj, JS.Uint8Array, JS.Uint8Array, float, float, float, float, float, float, JS.Uint8Array> with get, set
        abstract ``_getImageData24bits``: System.Func<obj, JS.Uint8Array, JS.Uint8Array, float, float, float, float, float, float, JS.Uint8Array> with get, set
        abstract ``_getImageData32bits``: System.Func<obj, JS.Uint8Array, JS.Uint8Array, float, float, float, float, float, float, JS.Uint8Array> with get, set
        abstract ``_getImageDataGrey8bits``: System.Func<obj, JS.Uint8Array, JS.Uint8Array, float, float, float, float, float, float, JS.Uint8Array> with get, set
        abstract ``_getImageDataGrey16bits``: System.Func<obj, JS.Uint8Array, JS.Uint8Array, float, float, float, float, float, float, JS.Uint8Array> with get, set

    /// @babylonjs/core/Misc/tga
    [<Import("TGATools", "@babylonjs/core/Misc/tga.js")>]
    let ``TGATools``: VariableShape_TGATools = jsNative

    /// Inline object shape of TiledBoxBuilder.
    [<AllowNullLiteral>]
    type VariableShape_TiledBoxBuilder =
        abstract ``CreateTiledBox``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTiledBox with get, set

    /// @babylonjs/core/Meshes/Builders/tiledBoxBuilder.pure
    [<Import("TiledBoxBuilder", "@babylonjs/core/Meshes/Builders/tiledBoxBuilder.pure.js")>]
    let ``TiledBoxBuilder``: VariableShape_TiledBoxBuilder = jsNative

    /// Inline object shape of TiledPlaneBuilder.
    [<AllowNullLiteral>]
    type VariableShape_TiledPlaneBuilder =
        abstract ``CreateTiledPlane``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTiledPlane with get, set

    /// @babylonjs/core/Meshes/Builders/tiledPlaneBuilder.pure
    [<Import("TiledPlaneBuilder", "@babylonjs/core/Meshes/Builders/tiledPlaneBuilder.pure.js")>]
    let ``TiledPlaneBuilder``: VariableShape_TiledPlaneBuilder = jsNative

    /// @babylonjs/core/Maths/math.constants
    [<Import("ToGammaSpace", "@babylonjs/core/Maths/math.constants.js")>]
    let ``ToGammaSpace``: float = jsNative

    /// @babylonjs/core/Maths/math.constants
    [<Import("ToLinearSpace", "@babylonjs/core/Maths/math.constants.js")>]
    let ``ToLinearSpace``: float = jsNative

    /// Inline object shape of tonemapPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_tonemapPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/tonemap.fragment
    [<Import("tonemapPixelShader", "@babylonjs/core/Shaders/tonemap.fragment.js")>]
    let ``tonemapPixelShader``: VariableShape_tonemapPixelShader = jsNative

    /// Inline object shape of tonemapPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_tonemapPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/tonemap.fragment
    [<Import("tonemapPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/tonemap.fragment.js")>]
    let ``tonemapPixelShaderWGSL``: VariableShape_tonemapPixelShaderWGSL = jsNative

    /// Inline object shape of TorusBuilder.
    [<AllowNullLiteral>]
    type VariableShape_TorusBuilder =
        abstract ``CreateTorus``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTorus with get, set

    /// @babylonjs/core/Meshes/Builders/torusBuilder.pure
    [<Import("TorusBuilder", "@babylonjs/core/Meshes/Builders/torusBuilder.pure.js")>]
    let ``TorusBuilder``: VariableShape_TorusBuilder = jsNative

    /// Inline object shape of TorusKnotBuilder.
    [<AllowNullLiteral>]
    type VariableShape_TorusKnotBuilder =
        abstract ``CreateTorusKnot``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTorusKnot with get, set

    /// @babylonjs/core/Meshes/Builders/torusKnotBuilder.pure
    [<Import("TorusKnotBuilder", "@babylonjs/core/Meshes/Builders/torusKnotBuilder.pure.js")>]
    let ``TorusKnotBuilder``: VariableShape_TorusKnotBuilder = jsNative

    /// Callable shape of TranscodeAsync.
    [<AllowNullLiteral>]
    type VariableFunction_TranscodeAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: U2<JS.ArrayBuffer, JS.ArrayBufferView> * ``config``: BabylonjsBindings.SimpleClasses.BasisTranscodeConfiguration -> JS.Promise<BabylonjsBindings.SimpleClasses.TranscodeResult>

    /// @babylonjs/core/Misc/basis.pure
    [<Import("TranscodeAsync", "@babylonjs/core/Misc/basis.pure.js")>]
    let ``TranscodeAsync``: VariableFunction_TranscodeAsync = jsNative

    /// Inline object shape of TubeBuilder.
    [<AllowNullLiteral>]
    type VariableShape_TubeBuilder =
        abstract ``CreateTube``: BabylonjsBindings.SimpleFunctions.FunctionBinding_CreateTube with get, set

    /// @babylonjs/core/Meshes/Builders/tubeBuilder.pure
    [<Import("TubeBuilder", "@babylonjs/core/Meshes/Builders/tubeBuilder.pure.js")>]
    let ``TubeBuilder``: VariableShape_TubeBuilder = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("ULONG_SIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``ULONG_SIZE``: float = jsNative

    /// @babylonjs/core/Rendering/geometryBufferRenderer.pure
    [<Import("Uniforms", "@babylonjs/core/Rendering/geometryBufferRenderer.pure.js")>]
    let ``Uniforms``: ResizeArray<string> = jsNative

    /// @babylonjs/core/Compat/compatibilityOptions
    [<Import("useOpenGLOrientationForUV", "@babylonjs/core/Compat/compatibilityOptions.js")>]
    let ``useOpenGLOrientationForUV``: bool = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("USHORT_RANGE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``USHORT_RANGE``: float = jsNative

    /// Inline object shape of velocityPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_velocityPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/velocity.fragment
    [<Import("velocityPixelShader", "@babylonjs/core/Shaders/velocity.fragment.js")>]
    let ``velocityPixelShader``: VariableShape_velocityPixelShader = jsNative

    /// Inline object shape of velocityVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_velocityVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/velocity.vertex
    [<Import("velocityVertexShader", "@babylonjs/core/Shaders/velocity.vertex.js")>]
    let ``velocityVertexShader``: VariableShape_velocityVertexShader = jsNative

    /// Inline object shape of vertexColorMixing.
    [<AllowNullLiteral>]
    type VariableShape_vertexColorMixing =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/ShadersInclude/vertexColorMixing
    [<Import("vertexColorMixing", "@babylonjs/core/Shaders/ShadersInclude/vertexColorMixing.js")>]
    let ``vertexColorMixing``: VariableShape_vertexColorMixing = jsNative

    /// Inline object shape of vertexColorMixingWGSL.
    [<AllowNullLiteral>]
    type VariableShape_vertexColorMixingWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/ShadersInclude/vertexColorMixing
    [<Import("vertexColorMixingWGSL", "@babylonjs/core/ShadersWGSL/ShadersInclude/vertexColorMixing.js")>]
    let ``vertexColorMixingWGSL``: VariableShape_vertexColorMixingWGSL = jsNative

    /// Inline object shape of volumetricLightScatteringPassPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_volumetricLightScatteringPassPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/volumetricLightScatteringPass.fragment
    [<Import("volumetricLightScatteringPassPixelShader", "@babylonjs/core/Shaders/volumetricLightScatteringPass.fragment.js")>]
    let ``volumetricLightScatteringPassPixelShader``: VariableShape_volumetricLightScatteringPassPixelShader = jsNative

    /// Inline object shape of volumetricLightScatteringPassPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_volumetricLightScatteringPassPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/volumetricLightScatteringPass.fragment
    [<Import("volumetricLightScatteringPassPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/volumetricLightScatteringPass.fragment.js")>]
    let ``volumetricLightScatteringPassPixelShaderWGSL``: VariableShape_volumetricLightScatteringPassPixelShaderWGSL = jsNative

    /// Inline object shape of volumetricLightScatteringPassVertexShader.
    [<AllowNullLiteral>]
    type VariableShape_volumetricLightScatteringPassVertexShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/volumetricLightScatteringPass.vertex
    [<Import("volumetricLightScatteringPassVertexShader", "@babylonjs/core/Shaders/volumetricLightScatteringPass.vertex.js")>]
    let ``volumetricLightScatteringPassVertexShader``: VariableShape_volumetricLightScatteringPassVertexShader = jsNative

    /// Inline object shape of volumetricLightScatteringPassVertexShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_volumetricLightScatteringPassVertexShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/volumetricLightScatteringPass.vertex
    [<Import("volumetricLightScatteringPassVertexShaderWGSL", "@babylonjs/core/ShadersWGSL/volumetricLightScatteringPass.vertex.js")>]
    let ``volumetricLightScatteringPassVertexShaderWGSL``: VariableShape_volumetricLightScatteringPassVertexShaderWGSL = jsNative

    /// Inline object shape of volumetricLightScatteringPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_volumetricLightScatteringPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/volumetricLightScattering.fragment
    [<Import("volumetricLightScatteringPixelShader", "@babylonjs/core/Shaders/volumetricLightScattering.fragment.js")>]
    let ``volumetricLightScatteringPixelShader``: VariableShape_volumetricLightScatteringPixelShader = jsNative

    /// Inline object shape of volumetricLightScatteringPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_volumetricLightScatteringPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/volumetricLightScattering.fragment
    [<Import("volumetricLightScatteringPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/volumetricLightScattering.fragment.js")>]
    let ``volumetricLightScatteringPixelShaderWGSL``: VariableShape_volumetricLightScatteringPixelShaderWGSL = jsNative

    /// Inline object shape of vrDistortionCorrectionPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_vrDistortionCorrectionPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/vrDistortionCorrection.fragment
    [<Import("vrDistortionCorrectionPixelShader", "@babylonjs/core/Shaders/vrDistortionCorrection.fragment.js")>]
    let ``vrDistortionCorrectionPixelShader``: VariableShape_vrDistortionCorrectionPixelShader = jsNative

    /// Inline object shape of vrDistortionCorrectionPixelShaderWGSL.
    [<AllowNullLiteral>]
    type VariableShape_vrDistortionCorrectionPixelShaderWGSL =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/ShadersWGSL/vrDistortionCorrection.fragment
    [<Import("vrDistortionCorrectionPixelShaderWGSL", "@babylonjs/core/ShadersWGSL/vrDistortionCorrection.fragment.js")>]
    let ``vrDistortionCorrectionPixelShaderWGSL``: VariableShape_vrDistortionCorrectionPixelShaderWGSL = jsNative

    /// Inline object shape of vrMultiviewToSingleviewPixelShader.
    [<AllowNullLiteral>]
    type VariableShape_vrMultiviewToSingleviewPixelShader =
        abstract ``name``: string with get, set
        abstract ``shader``: string with get, set

    /// @babylonjs/core/Shaders/vrMultiviewToSingleview.fragment
    [<Import("vrMultiviewToSingleviewPixelShader", "@babylonjs/core/Shaders/vrMultiviewToSingleview.fragment.js")>]
    let ``vrMultiviewToSingleviewPixelShader``: VariableShape_vrMultiviewToSingleviewPixelShader = jsNative

    /// @babylonjs/core/Maths/math.geospatial.functions
    [<Import("Wgs84Ellipsoid", "@babylonjs/core/Maths/math.geospatial.functions.js")>]
    let ``Wgs84Ellipsoid``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIEllipsoidLike = jsNative
