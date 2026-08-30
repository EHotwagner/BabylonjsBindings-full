// REVIEWED MAINTAINED SOURCE — exact declaration review and compile proof recorded in generated-candidates
namespace BabylonjsBindings

open Fable.Core

/// Exact primitive aliases and dependency-free callbacks exported by Babylon.js 9.19.0.
module TypeAliases =

    /// @babylonjs/core/types
    type double = System.Double

    /// @babylonjs/core/types
    type float = System.Double

    /// @babylonjs/core/types
    type FloatArray = U2<ResizeArray<System.Double>, JS.Float32Array>

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    type FrameGraphTextureHandle = System.Double

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderAnimation
    [<AllowNullLiteral>]
    type GetValueFn =
        [<Emit("$0($1...)")>] abstract Invoke: target: obj * source: JS.Float32Array * offset: System.Double * scale: System.Double -> obj

    /// @babylonjs/core/types
    type IndicesArray = U4<ResizeArray<System.Double>, JS.Int32Array, JS.Uint32Array, JS.Uint16Array>

    /// @babylonjs/core/types
    type int = System.Double

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type RenderingGroupStageAction =
        [<Emit("$0($1...)")>] abstract Invoke: renderingGroupId: System.Double -> unit

    /// @babylonjs/core/Engines/Processors/shaderProcessingOptions
    [<AllowNullLiteral>]
    type ShaderCustomProcessingFunction =
        [<Emit("$0($1...)")>] abstract Invoke: shaderType: string * code: string * ?defines: ResizeArray<string> -> string

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type SimpleStageAction =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit
