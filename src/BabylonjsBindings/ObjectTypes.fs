// MAINTAINED REVIEWED BINDING — exact Babylon.js 9.19.0 primitive object aliases
namespace BabylonjsBindings

/// Exact primitive-property object aliases exported by Babylon.js 9.19.0.
module ObjectTypes =

    /// @babylonjs/loaders/BVH/bvhLoadingOptions
    [<AllowNullLiteral>]
    type BVHLoadingOptions =
        abstract ``loopMode``: float with get, set

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    [<AllowNullLiteral>]
    type ComputeBindingLocation =
        abstract ``group``: float with get, set
        abstract ``binding``: float with get, set

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    [<AllowNullLiteral>]
    type FrameGraphTextureOptions =
        abstract ``createMipMaps``: bool option with get, set
        abstract ``samples``: float option with get, set
        abstract ``targetTypes``: ResizeArray<float> option with get, set
        abstract ``layerCounts``: ResizeArray<float> option with get, set
        abstract ``types``: ResizeArray<float> option with get, set
        abstract ``formats``: ResizeArray<float> option with get, set
        abstract ``useSRGBBuffers``: ResizeArray<bool> option with get, set
        abstract ``creationFlags``: ResizeArray<float> option with get, set
        abstract ``labels``: ResizeArray<string> option with get, set

    /// @babylonjs/core/Meshes/Builders/goldbergBuilder
    [<AllowNullLiteral>]
    type GoldbergVertexDataOption =
        abstract ``size``: float option with get, set
        abstract ``sizeX``: float option with get, set
        abstract ``sizeY``: float option with get, set
        abstract ``sizeZ``: float option with get, set
        abstract ``sideOrientation``: float option with get, set

    /// @babylonjs/core/Compute/computeEffect
    [<AllowNullLiteral>]
    type IComputeShaderPath =
        abstract ``computeSource``: string option with get, set
        abstract ``compute``: string option with get, set
        abstract ``computeElement``: string option with get, set

    /// @babylonjs/core/Materials/fresnelParameters.pure
    [<AllowNullLiteral>]
    type IFresnelParametersSerialized =
        abstract ``leftColor``: ResizeArray<float> with get, set
        abstract ``rightColor``: ResizeArray<float> with get, set
        abstract ``bias``: float with get, set
        abstract ``power``: float option with get, set
        abstract ``isEnabled``: bool with get, set

    /// @babylonjs/core/Cameras/inputMapper
    [<AllowNullLiteral>]
    type InputModifiers =
        abstract ``ctrl``: bool option with get, set
        abstract ``shift``: bool option with get, set
        abstract ``alt``: bool option with get, set

    /// @babylonjs/core/Materials/effect.pure
    [<AllowNullLiteral>]
    type IShaderPath =
        abstract ``vertexSource``: string option with get, set
        abstract ``fragmentSource``: string option with get, set
        abstract ``vertex``: string option with get, set
        abstract ``fragment``: string option with get, set
        abstract ``vertexElement``: string option with get, set
        abstract ``fragmentElement``: string option with get, set
        abstract ``spectorName``: string option with get, set

    /// @babylonjs/core/FrameGraph/Passes/renderPass
    [<AllowNullLiteral>]
    type LayerAndFaceIndex =
        abstract ``targetIndex``: float with get, set
        abstract ``layerIndex``: float option with get, set
        abstract ``faceIndex``: float option with get, set

    /// @babylonjs/core/Materials/materialPluginEvent
    [<AllowNullLiteral>]
    type MaterialPluginDisposed =
        abstract ``forceDisposeTextures``: bool option with get, set

    /// @babylonjs/core/Materials/materialPluginEvent
    [<AllowNullLiteral>]
    type MaterialPluginHasRenderTargetTextures =
        abstract ``hasRenderTargetTextures``: bool with get, set

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type NativeFrameStats =
        abstract ``gpuTimeNs``: float with get, set

    /// @babylonjs/core/Behaviors/Cameras/interpolatingBehavior
    [<AllowNullLiteral>]
    type SizeLike =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set

    /// @babylonjs/core/Cameras/inputMapper
    [<AllowNullLiteral>]
    type TouchConditions =
        abstract ``touchCount``: float option with get, set

    /// @babylonjs/core/XR/features/WebXRControllerMovement.pure
    [<AllowNullLiteral>]
    type WebXRControllerMovementState =
        abstract ``moveX``: float with get, set
        abstract ``moveY``: float with get, set
        abstract ``rotateX``: float with get, set
        abstract ``rotateY``: float with get, set
