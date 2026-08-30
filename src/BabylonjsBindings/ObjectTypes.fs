// REVIEWED MAINTAINED SOURCE — exact declaration review and runtime shape proof recorded in generated-candidates
namespace BabylonjsBindings

open Fable.Core

/// Exact dependency-closed object aliases exported by Babylon.js 9.19.0.
module ObjectTypes =

    /// Function-valued ArcRotateHandlers.pan property.
    [<AllowNullLiteral>]
    type ArcRotateHandlersPanCallback =
        [<Emit("$0($1...)")>] abstract Invoke: deltaX: float * deltaY: float -> unit

    /// Function-valued ArcRotateHandlers.rotate property.
    [<AllowNullLiteral>]
    type ArcRotateHandlersRotateCallback =
        [<Emit("$0($1...)")>] abstract Invoke: deltaX: float * deltaY: float -> unit

    /// Function-valued ArcRotateHandlers.zoom property.
    [<AllowNullLiteral>]
    type ArcRotateHandlersZoomCallback =
        [<Emit("$0($1...)")>] abstract Invoke: delta: float -> unit

    /// @babylonjs/core/Cameras/arcRotateCameraMovement
    [<AllowNullLiteral>]
    type ArcRotateHandlers =
        abstract ``pan``: ArcRotateHandlersPanCallback with get, set
        abstract ``rotate``: ArcRotateHandlersRotateCallback with get, set
        abstract ``zoom``: ArcRotateHandlersZoomCallback with get, set

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

    /// @babylonjs/core/Cameras/geospatialCameraMovement
    [<AllowNullLiteral>]
    type GeospatialPanHandler =
        abstract ``start``: screenX: float * screenY: float -> unit
        abstract ``update``: screenX: float * screenY: float -> unit
        abstract ``stop``: unit -> unit

    /// @babylonjs/core/Meshes/Builders/goldbergBuilder
    [<AllowNullLiteral>]
    type GoldbergVertexDataOption =
        abstract ``size``: float option with get, set
        abstract ``sizeX``: float option with get, set
        abstract ``sizeY``: float option with get, set
        abstract ``sizeZ``: float option with get, set
        abstract ``sideOrientation``: float option with get, set

    /// @babylonjs/core/Meshes/abstractMesh.hotSpot
    [<AllowNullLiteral>]
    type HotSpotQuery =
        abstract ``pointIndex``: (float * float * float) with get, set
        abstract ``barycentric``: (float * float * float) with get, set

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

    /// Function-valued TargetCameraHandlers.translate property.
    [<AllowNullLiteral>]
    type TargetCameraHandlersTranslateCallback =
        [<Emit("$0($1...)")>] abstract Invoke: deltaX: float * deltaY: float * deltaZ: float -> unit

    /// Function-valued TargetCameraHandlers.rotate property.
    [<AllowNullLiteral>]
    type TargetCameraHandlersRotateCallback =
        [<Emit("$0($1...)")>] abstract Invoke: pitch: float * yaw: float -> unit

    /// @babylonjs/core/Cameras/targetCameraMovement
    [<AllowNullLiteral>]
    type TargetCameraHandlers =
        abstract ``translate``: TargetCameraHandlersTranslateCallback with get, set
        abstract ``rotate``: TargetCameraHandlersRotateCallback with get, set

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

    /// Function-valued GeospatialHandlers.rotate property.
    [<AllowNullLiteral>]
    type GeospatialHandlersRotateCallback =
        [<Emit("$0($1...)")>] abstract Invoke: yaw: float * pitch: float -> unit

    /// Function-valued GeospatialHandlers.zoom property.
    [<AllowNullLiteral>]
    type GeospatialHandlersZoomCallback =
        [<Emit("$0($1...)")>] abstract Invoke: delta: float * toCursor: bool -> unit

    /// @babylonjs/core/Cameras/geospatialCameraMovement
    [<AllowNullLiteral>]
    type GeospatialHandlers =
        abstract ``pan``: GeospatialPanHandler with get, set
        abstract ``rotate``: GeospatialHandlersRotateCallback with get, set
        abstract ``zoom``: GeospatialHandlersZoomCallback with get, set

    /// @babylonjs/core/Cameras/inputMapper
    [<AllowNullLiteral>]
    type InputConditions =
        abstract ``button``: float option with get, set
        abstract ``modifiers``: InputModifiers option with get, set
        abstract ``touchCount``: float option with get, set
        abstract ``key``: float option with get, set

    /// @babylonjs/core/Cameras/inputMapper
    [<AllowNullLiteral>]
    type KeyboardConditions =
        abstract ``key``: float option with get, set
        abstract ``modifiers``: InputModifiers option with get, set

    /// @babylonjs/core/Cameras/inputMapper
    [<AllowNullLiteral>]
    type PointerConditions =
        abstract ``button``: float option with get, set
        abstract ``modifiers``: InputModifiers option with get, set

    /// @babylonjs/core/Cameras/inputMapper
    [<AllowNullLiteral>]
    type WheelConditions =
        abstract ``modifiers``: InputModifiers option with get, set
