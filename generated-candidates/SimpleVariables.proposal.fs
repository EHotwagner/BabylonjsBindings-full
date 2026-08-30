// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after variable review, compile, import, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact dependency-closed variables and constants exported by Babylon.js 9.19.0.
module SimpleVariables =

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<Import("_BabylonLoaderRegistered", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``_BabylonLoaderRegistered``: bool = jsNative

    /// @babylonjs/core/Helpers/sceneHelpers.pure
    [<Import("_forceSceneHelpersToBundle", "@babylonjs/core/Helpers/sceneHelpers.pure.js")>]
    let ``_forceSceneHelpersToBundle``: bool = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.transformFeedback.pure
    [<Import("_forceTransformFeedbackToBundle", "@babylonjs/core/Engines/Extensions/engine.transformFeedback.pure.js")>]
    let ``_forceTransformFeedbackToBundle``: bool = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<Import("_IsMacPlatform", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``_IsMacPlatform``: bool = jsNative

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    [<Import("backbufferColorTextureHandle", "@babylonjs/core/FrameGraph/frameGraphTypes.js")>]
    let ``backbufferColorTextureHandle``: BabylonjsBindings.TypeAliases.FrameGraphTextureHandle = jsNative

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    [<Import("backbufferDepthStencilTextureHandle", "@babylonjs/core/FrameGraph/frameGraphTypes.js")>]
    let ``backbufferDepthStencilTextureHandle``: BabylonjsBindings.TypeAliases.FrameGraphTextureHandle = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("BITMAP_SIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``BITMAP_SIZE``: float = jsNative

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<Import("BodyJointParentIndex", "@babylonjs/core/XR/features/WebXRBodyTracking.pure.js")>]
    let ``BodyJointParentIndex``: ResizeArray<float> = jsNative

    /// @babylonjs/core/Maths/math.constants
    [<Import("Epsilon", "@babylonjs/core/Maths/math.constants.js")>]
    let ``Epsilon``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("HUF_DECMASK", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``HUF_DECMASK``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("HUF_DECSIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``HUF_DECSIZE``: float = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("HUF_ENCSIZE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``HUF_ENCSIZE``: float = jsNative

    /// @babylonjs/core/Maths/math.constants
    [<Import("PHI", "@babylonjs/core/Maths/math.constants.js")>]
    let ``PHI``: float = jsNative

    /// @babylonjs/core/Rendering/geometryBufferRenderer.pure
    [<Import("Samplers", "@babylonjs/core/Rendering/geometryBufferRenderer.pure.js")>]
    let ``Samplers``: ResizeArray<string> = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("SHORTEST_LONG_RUN", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``SHORTEST_LONG_RUN``: float = jsNative

    /// @babylonjs/core/Maths/math.constants
    [<Import("ToGammaSpace", "@babylonjs/core/Maths/math.constants.js")>]
    let ``ToGammaSpace``: float = jsNative

    /// @babylonjs/core/Rendering/geometryBufferRenderer.pure
    [<Import("Uniforms", "@babylonjs/core/Rendering/geometryBufferRenderer.pure.js")>]
    let ``Uniforms``: ResizeArray<string> = jsNative

    /// @babylonjs/core/Compat/compatibilityOptions
    [<Import("useOpenGLOrientationForUV", "@babylonjs/core/Compat/compatibilityOptions.js")>]
    let ``useOpenGLOrientationForUV``: bool = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<Import("USHORT_RANGE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces.js")>]
    let ``USHORT_RANGE``: float = jsNative
