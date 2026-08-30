// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after alias review, compile, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact primitive aliases and dependency-free callbacks exported by Babylon.js 9.19.0.
module TypeAliases =

    /// @babylonjs/core/types
    type double = System.Double

    /// @babylonjs/core/types
    type float = System.Double

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    type FrameGraphTextureHandle = System.Double

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
