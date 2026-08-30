// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after string-enum review, compile, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact string enums and string-literal unions exported by Babylon.js 9.19.0.
module StringEnums =

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type AddressMode =
        | [<CompiledName("clamp-to-edge")>] ``ClampToEdge``
        | [<CompiledName("repeat")>] ``Repeat``
        | [<CompiledName("mirror-repeat")>] ``MirrorRepeat``

    /// @babylonjs/core/Misc/khronosTextureContainer2Worker
    [<StringEnum; RequireQualifiedAccess>]
    type AllowedKeys =
        | [<CompiledName("wasmBaseUrl")>] ``WasmBaseUrl``
        | [<CompiledName("wasmUASTCToASTC")>] ``WasmUASTCToASTC``
        | [<CompiledName("wasmUASTCToBC7")>] ``WasmUASTCToBC7``
        | [<CompiledName("wasmUASTCToRGBA_UNORM")>] ``WasmUASTCToRGBAUNORM``
        | [<CompiledName("wasmUASTCToRGBA_SRGB")>] ``WasmUASTCToRGBASRGB``
        | [<CompiledName("wasmUASTCToR8_UNORM")>] ``WasmUASTCToR8UNORM``
        | [<CompiledName("wasmUASTCToRG8_UNORM")>] ``WasmUASTCToRG8UNORM``
        | [<CompiledName("wasmMSCTranscoder")>] ``WasmMSCTranscoder``
        | [<CompiledName("wasmZSTDDecoder")>] ``WasmZSTDDecoder``
        | [<CompiledName("jsDecoderModule")>] ``JsDecoderModule``
        | [<CompiledName("jsMSCTranscoder")>] ``JsMSCTranscoder``

    /// @babylonjs/core/Cameras/arcRotateCameraMovement
    [<StringEnum; RequireQualifiedAccess>]
    type ArcRotateInteraction =
        | [<CompiledName("pan")>] ``Pan``
        | [<CompiledName("rotate")>] ``Rotate``
        | [<CompiledName("zoom")>] ``Zoom``

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<StringEnum; RequireQualifiedAccess>]
    type AudioEngineV2State =
        | [<CompiledName("closed")>] ``Closed``
        | [<CompiledName("interrupted")>] ``Interrupted``
        | [<CompiledName("running")>] ``Running``
        | [<CompiledName("suspended")>] ``Suspended``

    /// @babylonjs/core/AudioV2/audioParameter
    [<StringEnum; RequireQualifiedAccess>]
    type AudioParameterRampShape =
        | [<CompiledName("linear")>] ``Linear``
        | [<CompiledName("exponential")>] ``Exponential``
        | [<CompiledName("logarithmic")>] ``Logarithmic``
        | [<CompiledName("none")>] ``None``

    /// @babylonjs/core/AudioV2/abstractAudio/subNodes/audioSubNode
    [<StringEnum; RequireQualifiedAccess>]
    type AudioSubNode =
        | [<CompiledName("Analyzer")>] ``ANALYZER``
        | [<CompiledName("Stereo")>] ``STEREO``
        | [<CompiledName("Spatial")>] ``SPATIAL``
        | [<CompiledName("Volume")>] ``VOLUME``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type AutoLayoutMode =
        | [<CompiledName("auto")>] ``Auto``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type BlendFactor =
        | [<CompiledName("zero")>] ``Zero``
        | [<CompiledName("one")>] ``One``
        | [<CompiledName("src")>] ``Src``
        | [<CompiledName("one-minus-src")>] ``OneMinusSrc``
        | [<CompiledName("src-alpha")>] ``SrcAlpha``
        | [<CompiledName("one-minus-src-alpha")>] ``OneMinusSrcAlpha``
        | [<CompiledName("dst")>] ``Dst``
        | [<CompiledName("one-minus-dst")>] ``OneMinusDst``
        | [<CompiledName("dst-alpha")>] ``DstAlpha``
        | [<CompiledName("one-minus-dst-alpha")>] ``OneMinusDstAlpha``
        | [<CompiledName("src-alpha-saturated")>] ``SrcAlphaSaturated``
        | [<CompiledName("constant")>] ``Constant``
        | [<CompiledName("one-minus-constant")>] ``OneMinusConstant``
        | [<CompiledName("src1")>] ``Src1``
        | [<CompiledName("one-minus-src1")>] ``OneMinusSrc1``
        | [<CompiledName("src1-alpha")>] ``Src1Alpha``
        | [<CompiledName("one-minus-src1-alpha")>] ``OneMinusSrc1Alpha``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type BlendOperation =
        | [<CompiledName("add")>] ``Add``
        | [<CompiledName("subtract")>] ``Subtract``
        | [<CompiledName("reverse-subtract")>] ``ReverseSubtract``
        | [<CompiledName("min")>] ``Min``
        | [<CompiledName("max")>] ``Max``

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<StringEnum; RequireQualifiedAccess>]
    type BodyPart =
        | [<CompiledName("torso")>] ``TORSO``
        | [<CompiledName("left-arm")>] ``LEFTARM``
        | [<CompiledName("right-arm")>] ``RIGHTARM``
        | [<CompiledName("left-hand")>] ``LEFTHAND``
        | [<CompiledName("right-hand")>] ``RIGHTHAND``
        | [<CompiledName("left-leg")>] ``LEFTLEG``
        | [<CompiledName("right-leg")>] ``RIGHTLEG``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type BufferBindingType =
        | [<CompiledName("uniform")>] ``Uniform``
        | [<CompiledName("storage")>] ``Storage``
        | [<CompiledName("read-only-storage")>] ``ReadOnlyStorage``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type BufferMapState =
        | [<CompiledName("unmapped")>] ``Unmapped``
        | [<CompiledName("pending")>] ``Pending``
        | [<CompiledName("mapped")>] ``Mapped``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type CanvasAlphaMode =
        | [<CompiledName("opaque")>] ``Opaque``
        | [<CompiledName("premultiplied")>] ``Premultiplied``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type CanvasToneMappingMode =
        | [<CompiledName("standard")>] ``Standard``
        | [<CompiledName("extended")>] ``Extended``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type CompareFunction =
        | [<CompiledName("never")>] ``Never``
        | [<CompiledName("less")>] ``Less``
        | [<CompiledName("equal")>] ``Equal``
        | [<CompiledName("less-equal")>] ``LessEqual``
        | [<CompiledName("greater")>] ``Greater``
        | [<CompiledName("not-equal")>] ``NotEqual``
        | [<CompiledName("greater-equal")>] ``GreaterEqual``
        | [<CompiledName("always")>] ``Always``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type CompilationMessageType =
        | [<CompiledName("error")>] ``Error``
        | [<CompiledName("warning")>] ``Warning``
        | [<CompiledName("info")>] ``Info``

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    [<StringEnum; RequireQualifiedAccess>]
    type ComputeCompilationMessageType =
        | [<CompiledName("error")>] ``Error``
        | [<CompiledName("warning")>] ``Warning``
        | [<CompiledName("info")>] ``Info``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type ComputePassTimestampLocation =
        | [<CompiledName("beginning")>] ``Beginning``
        | [<CompiledName("end")>] ``End``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type CullMode =
        | [<CompiledName("none")>] ``None``
        | [<CompiledName("front")>] ``Front``
        | [<CompiledName("back")>] ``Back``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type DeviceLostReason =
        | [<CompiledName("unknown")>] ``Unknown``
        | [<CompiledName("destroyed")>] ``Destroyed``

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    [<StringEnum; RequireQualifiedAccess>]
    type DracoAttributeName =
        | [<CompiledName("POSITION")>] ``POSITION``
        | [<CompiledName("NORMAL")>] ``NORMAL``
        | [<CompiledName("COLOR")>] ``COLOR``
        | [<CompiledName("TEX_COORD")>] ``TEXCOORD``
        | [<CompiledName("GENERIC")>] ``GENERIC``

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    [<StringEnum; RequireQualifiedAccess>]
    type DracoEncoderMethod =
        | [<CompiledName("MESH_SEQUENTIAL_ENCODING")>] ``MESHSEQUENTIALENCODING``
        | [<CompiledName("MESH_EDGEBREAKER_ENCODING")>] ``MESHEDGEBREAKERENCODING``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type ErrorFilter =
        | [<CompiledName("validation")>] ``Validation``
        | [<CompiledName("out-of-memory")>] ``OutOfMemory``
        | [<CompiledName("internal")>] ``Internal``

    /// @babylonjs/loaders/FBX/fbxFileLoader.pure
    [<StringEnum; RequireQualifiedAccess>]
    type FBXNormalMapCoordinateSystem =
        | [<CompiledName("y-up")>] ``YUp``
        | [<CompiledName("y-down")>] ``YDown``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type FeatureName =
        | [<CompiledName("core-features-and-limits")>] ``CoreFeaturesAndLimits``
        | [<CompiledName("depth-clip-control")>] ``DepthClipControl``
        | [<CompiledName("depth32float-stencil8")>] ``Depth32FloatStencil8``
        | [<CompiledName("texture-compression-bc")>] ``TextureCompressionBC``
        | [<CompiledName("texture-compression-bc-sliced-3d")>] ``TextureCompressionBCSliced3D``
        | [<CompiledName("texture-compression-etc2")>] ``TextureCompressionETC2``
        | [<CompiledName("texture-compression-astc")>] ``TextureCompressionASTC``
        | [<CompiledName("texture-compression-astc-sliced-3d")>] ``TextureCompressionASTCSliced3D``
        | [<CompiledName("timestamp-query")>] ``TimestampQuery``
        | [<CompiledName("indirect-first-instance")>] ``IndirectFirstInstance``
        | [<CompiledName("shader-f16")>] ``ShaderF16``
        | [<CompiledName("rg11b10ufloat-renderable")>] ``RG11B10UFloatRenderable``
        | [<CompiledName("bgra8unorm-storage")>] ``BGRA8UnormStorage``
        | [<CompiledName("float32-filterable")>] ``Float32Filterable``
        | [<CompiledName("float32-blendable")>] ``Float32Blendable``
        | [<CompiledName("clip-distances")>] ``ClipDistances``
        | [<CompiledName("dual-source-blending")>] ``DualSourceBlending``
        | [<CompiledName("subgroups")>] ``Subgroups``
        | [<CompiledName("texture-formats-tier1")>] ``TextureFormatsTier1``
        | [<CompiledName("texture-formats-tier2")>] ``TextureFormatsTier2``
        | [<CompiledName("primitive-index")>] ``PrimitiveIndex``
        | [<CompiledName("texture-component-swizzle")>] ``TextureComponentSwizzle``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type FilterMode =
        | [<CompiledName("nearest")>] ``Nearest``
        | [<CompiledName("linear")>] ``Linear``

    /// @babylonjs/core/FlowGraph/flowGraphLogger
    [<StringEnum; RequireQualifiedAccess>]
    type FlowGraphAction =
        | [<CompiledName("ExecuteBlock")>] ``ExecuteBlock``
        | [<CompiledName("ExecuteEvent")>] ``ExecuteEvent``
        | [<CompiledName("TriggerConnection")>] ``TriggerConnection``
        | [<CompiledName("ContextVariableSet")>] ``ContextVariableSet``
        | [<CompiledName("GlobalVariableSet")>] ``GlobalVariableSet``
        | [<CompiledName("GlobalVariableDelete")>] ``GlobalVariableDelete``
        | [<CompiledName("GlobalVariableGet")>] ``GlobalVariableGet``
        | [<CompiledName("AddConnection")>] ``AddConnection``
        | [<CompiledName("GetConnectionValue")>] ``GetConnectionValue``
        | [<CompiledName("SetConnectionValue")>] ``SetConnectionValue``
        | [<CompiledName("ActivateSignal")>] ``ActivateSignal``
        | [<CompiledName("ContextVariableGet")>] ``ContextVariableGet``

    /// @babylonjs/core/FlowGraph/flowGraphAssetsContext
    [<StringEnum; RequireQualifiedAccess>]
    type FlowGraphAssetType =
        | [<CompiledName("Animation")>] ``Animation``
        | [<CompiledName("AnimationGroup")>] ``AnimationGroup``
        | [<CompiledName("Mesh")>] ``Mesh``
        | [<CompiledName("Material")>] ``Material``
        | [<CompiledName("Camera")>] ``Camera``
        | [<CompiledName("Light")>] ``Light``

    /// @babylonjs/core/FlowGraph/Blocks/flowGraphBlockNames
    [<StringEnum; RequireQualifiedAccess>]
    type FlowGraphBlockNames =
        | [<CompiledName("FlowGraphPlayAnimationBlock")>] ``PlayAnimation``
        | [<CompiledName("FlowGraphStopAnimationBlock")>] ``StopAnimation``
        | [<CompiledName("FlowGraphPauseAnimationBlock")>] ``PauseAnimation``
        | [<CompiledName("FlowGraphInterpolationBlock")>] ``ValueInterpolation``
        | [<CompiledName("FlowGraphSceneReadyEventBlock")>] ``SceneReadyEvent``
        | [<CompiledName("FlowGraphSceneTickEventBlock")>] ``SceneTickEvent``
        | [<CompiledName("FlowGraphSendCustomEventBlock")>] ``SendCustomEvent``
        | [<CompiledName("FlowGraphReceiveCustomEventBlock")>] ``ReceiveCustomEvent``
        | [<CompiledName("FlowGraphMeshPickEventBlock")>] ``MeshPickEvent``
        | [<CompiledName("FlowGraphPointerEventBlock")>] ``PointerEvent``
        | [<CompiledName("FlowGraphPointerDownEventBlock")>] ``PointerDownEvent``
        | [<CompiledName("FlowGraphPointerUpEventBlock")>] ``PointerUpEvent``
        | [<CompiledName("FlowGraphPointerMoveEventBlock")>] ``PointerMoveEvent``
        | [<CompiledName("FlowGraphPointerOverEventBlock")>] ``PointerOverEvent``
        | [<CompiledName("FlowGraphPointerOutEventBlock")>] ``PointerOutEvent``
        | [<CompiledName("FlowGraphKeyDownEventBlock")>] ``KeyDownEvent``
        | [<CompiledName("FlowGraphKeyUpEventBlock")>] ``KeyUpEvent``
        | [<CompiledName("FlowGraphIsKeyPressedBlock")>] ``IsKeyPressed``
        | [<CompiledName("FlowGraphEBlock")>] ``E``
        | [<CompiledName("FlowGraphPIBlock")>] ``PI``
        | [<CompiledName("FlowGraphInfBlock")>] ``Inf``
        | [<CompiledName("FlowGraphNaNBlock")>] ``NaN``
        | [<CompiledName("FlowGraphRandomBlock")>] ``Random``
        | [<CompiledName("FlowGraphAddBlock")>] ``Add``
        | [<CompiledName("FlowGraphSubtractBlock")>] ``Subtract``
        | [<CompiledName("FlowGraphMultiplyBlock")>] ``Multiply``
        | [<CompiledName("FlowGraphDivideBlock")>] ``Divide``
        | [<CompiledName("FlowGraphAbsBlock")>] ``Abs``
        | [<CompiledName("FlowGraphSignBlock")>] ``Sign``
        | [<CompiledName("FlowGraphTruncBlock")>] ``Trunc``
        | [<CompiledName("FlowGraphFloorBlock")>] ``Floor``
        | [<CompiledName("FlowGraphCeilBlock")>] ``Ceil``
        | [<CompiledName("FlowGraphRoundBlock")>] ``Round``
        | [<CompiledName("FlowGraphFractBlock")>] ``Fraction``
        | [<CompiledName("FlowGraphNegationBlock")>] ``Negation``
        | [<CompiledName("FlowGraphModuloBlock")>] ``Modulo``
        | [<CompiledName("FlowGraphMinBlock")>] ``Min``
        | [<CompiledName("FlowGraphMaxBlock")>] ``Max``
        | [<CompiledName("FlowGraphClampBlock")>] ``Clamp``
        | [<CompiledName("FlowGraphSaturateBlock")>] ``Saturate``
        | [<CompiledName("FlowGraphMathInterpolationBlock")>] ``MathInterpolation``
        | [<CompiledName("FlowGraphEqualityBlock")>] ``Equality``
        | [<CompiledName("FlowGraphLessThanBlock")>] ``LessThan``
        | [<CompiledName("FlowGraphLessThanOrEqualBlock")>] ``LessThanOrEqual``
        | [<CompiledName("FlowGraphGreaterThanBlock")>] ``GreaterThan``
        | [<CompiledName("FlowGraphGreaterThanOrEqualBlock")>] ``GreaterThanOrEqual``
        | [<CompiledName("FlowGraphIsNaNBlock")>] ``IsNaNValue``
        | [<CompiledName("FlowGraphIsInfBlock")>] ``IsInfinity``
        | [<CompiledName("FlowGraphDegToRadBlock")>] ``DegToRad``
        | [<CompiledName("FlowGraphRadToDegBlock")>] ``RadToDeg``
        | [<CompiledName("FlowGraphSinBlock")>] ``Sin``
        | [<CompiledName("FlowGraphCosBlock")>] ``Cos``
        | [<CompiledName("FlowGraphTanBlock")>] ``Tan``
        | [<CompiledName("FlowGraphASinBlock")>] ``Asin``
        | [<CompiledName("FlowGraphACosBlock")>] ``Acos``
        | [<CompiledName("FlowGraphATanBlock")>] ``Atan``
        | [<CompiledName("FlowGraphATan2Block")>] ``Atan2``
        | [<CompiledName("FlowGraphSinhBlock")>] ``Sinh``
        | [<CompiledName("FlowGraphCoshBlock")>] ``Cosh``
        | [<CompiledName("FlowGraphTanhBlock")>] ``Tanh``
        | [<CompiledName("FlowGraphASinhBlock")>] ``Asinh``
        | [<CompiledName("FlowGraphACoshBlock")>] ``Acosh``
        | [<CompiledName("FlowGraphATanhBlock")>] ``Atanh``
        | [<CompiledName("FlowGraphExponentialBlock")>] ``Exponential``
        | [<CompiledName("FlowGraphLogBlock")>] ``Log``
        | [<CompiledName("FlowGraphLog2Block")>] ``Log2``
        | [<CompiledName("FlowGraphLog10Block")>] ``Log10``
        | [<CompiledName("FlowGraphSquareRootBlock")>] ``SquareRoot``
        | [<CompiledName("FlowGraphCubeRootBlock")>] ``CubeRoot``
        | [<CompiledName("FlowGraphPowerBlock")>] ``Power``
        | [<CompiledName("FlowGraphLengthBlock")>] ``Length``
        | [<CompiledName("FlowGraphNormalizeBlock")>] ``Normalize``
        | [<CompiledName("FlowGraphDotBlock")>] ``Dot``
        | [<CompiledName("FlowGraphCrossBlock")>] ``Cross``
        | [<CompiledName("FlowGraphRotate2DBlock")>] ``Rotate2D``
        | [<CompiledName("FlowGraphRotate3DBlock")>] ``Rotate3D``
        | [<CompiledName("FlowGraphTransposeBlock")>] ``Transpose``
        | [<CompiledName("FlowGraphDeterminantBlock")>] ``Determinant``
        | [<CompiledName("FlowGraphInvertMatrixBlock")>] ``InvertMatrix``
        | [<CompiledName("FlowGraphMatrixMultiplicationBlock")>] ``MatrixMultiplication``
        | [<CompiledName("FlowGraphBitwiseAndBlock")>] ``BitwiseAnd``
        | [<CompiledName("FlowGraphBitwiseOrBlock")>] ``BitwiseOr``
        | [<CompiledName("FlowGraphBitwiseXorBlock")>] ``BitwiseXor``
        | [<CompiledName("FlowGraphBitwiseNotBlock")>] ``BitwiseNot``
        | [<CompiledName("FlowGraphBitwiseLeftShiftBlock")>] ``BitwiseLeftShift``
        | [<CompiledName("FlowGraphBitwiseRightShiftBlock")>] ``BitwiseRightShift``
        | [<CompiledName("FlowGraphLeadingZerosBlock")>] ``LeadingZeros``
        | [<CompiledName("FlowGraphTrailingZerosBlock")>] ``TrailingZeros``
        | [<CompiledName("FlowGraphOneBitsCounterBlock")>] ``OneBitsCounter``
        | [<CompiledName("FlowGraphBranchBlock")>] ``Branch``
        | [<CompiledName("FlowGraphSetDelayBlock")>] ``SetDelay``
        | [<CompiledName("FlowGraphCancelDelayBlock")>] ``CancelDelay``
        | [<CompiledName("FlowGraphCallCounterBlock")>] ``CallCounter``
        | [<CompiledName("FlowGraphDebounceBlock")>] ``Debounce``
        | [<CompiledName("FlowGraphThrottleBlock")>] ``Throttle``
        | [<CompiledName("FlowGraphDoNBlock")>] ``DoN``
        | [<CompiledName("FlowGraphFlipFlopBlock")>] ``FlipFlop``
        | [<CompiledName("FlowGraphForLoopBlock")>] ``ForLoop``
        | [<CompiledName("FlowGraphMultiGateBlock")>] ``MultiGate``
        | [<CompiledName("FlowGraphSequenceBlock")>] ``Sequence``
        | [<CompiledName("FlowGraphSwitchBlock")>] ``Switch``
        | [<CompiledName("FlowGraphWaitAllBlock")>] ``WaitAll``
        | [<CompiledName("FlowGraphWhileLoopBlock")>] ``WhileLoop``
        | [<CompiledName("FlowGraphConsoleLogBlock")>] ``ConsoleLog``
        | [<CompiledName("FlowGraphConditionalBlock")>] ``Conditional``
        | [<CompiledName("FlowGraphConstantBlock")>] ``Constant``
        | [<CompiledName("FlowGraphTransformCoordinatesSystemBlock")>] ``TransformCoordinatesSystem``
        | [<CompiledName("FlowGraphGetAssetBlock")>] ``GetAsset``
        | [<CompiledName("FlowGraphGetPropertyBlock")>] ``GetProperty``
        | [<CompiledName("FlowGraphSetPropertyBlock")>] ``SetProperty``
        | [<CompiledName("FlowGraphGetVariableBlock")>] ``GetVariable``
        | [<CompiledName("FlowGraphSetVariableBlock")>] ``SetVariable``
        | [<CompiledName("FlowGraphJsonPointerParserBlock")>] ``JsonPointerParser``
        | [<CompiledName("FlowGraphCombineVector2Block")>] ``CombineVector2``
        | [<CompiledName("FlowGraphCombineVector3Block")>] ``CombineVector3``
        | [<CompiledName("FlowGraphCombineVector4Block")>] ``CombineVector4``
        | [<CompiledName("FlowGraphCombineMatrixBlock")>] ``CombineMatrix``
        | [<CompiledName("FlowGraphCombineMatrix2DBlock")>] ``CombineMatrix2D``
        | [<CompiledName("FlowGraphCombineMatrix3DBlock")>] ``CombineMatrix3D``
        | [<CompiledName("FlowGraphExtractVector2Block")>] ``ExtractVector2``
        | [<CompiledName("FlowGraphExtractVector3Block")>] ``ExtractVector3``
        | [<CompiledName("FlowGraphExtractVector4Block")>] ``ExtractVector4``
        | [<CompiledName("FlowGraphExtractMatrixBlock")>] ``ExtractMatrix``
        | [<CompiledName("FlowGraphExtractMatrix2DBlock")>] ``ExtractMatrix2D``
        | [<CompiledName("FlowGraphExtractMatrix3DBlock")>] ``ExtractMatrix3D``
        | [<CompiledName("FlowGraphTransformVectorBlock")>] ``TransformVector``
        | [<CompiledName("FlowGraphTransformCoordinatesBlock")>] ``TransformCoordinates``
        | [<CompiledName("FlowGraphConjugateBlock")>] ``Conjugate``
        | [<CompiledName("FlowGraphAngleBetweenBlock")>] ``AngleBetween``
        | [<CompiledName("FlowGraphQuaternionFromAxisAngleBlock")>] ``QuaternionFromAxisAngle``
        | [<CompiledName("FlowGraphAxisAngleFromQuaternionBlock")>] ``AxisAngleFromQuaternion``
        | [<CompiledName("FlowGraphQuaternionFromDirectionsBlock")>] ``QuaternionFromDirections``
        | [<CompiledName("FlowGraphMatrixDecompose")>] ``MatrixDecompose``
        | [<CompiledName("FlowGraphMatrixCompose")>] ``MatrixCompose``
        | [<CompiledName("FlowGraphBooleanToFloat")>] ``BooleanToFloat``
        | [<CompiledName("FlowGraphBooleanToInt")>] ``BooleanToInt``
        | [<CompiledName("FlowGraphFloatToBoolean")>] ``FloatToBoolean``
        | [<CompiledName("FlowGraphIntToBoolean")>] ``IntToBoolean``
        | [<CompiledName("FlowGraphIntToFloat")>] ``IntToFloat``
        | [<CompiledName("FlowGraphFloatToInt")>] ``FloatToInt``
        | [<CompiledName("FlowGraphEasingBlock")>] ``Easing``
        | [<CompiledName("FlowGraphContextBlock")>] ``Context``
        | [<CompiledName("FlowGraphArrayIndexBlock")>] ``ArrayIndex``
        | [<CompiledName("FlowGraphCodeExecutionBlock")>] ``CodeExecution``
        | [<CompiledName("FlowGraphIndexOfBlock")>] ``IndexOf``
        | [<CompiledName("FlowGraphFunctionReference")>] ``FunctionReference``
        | [<CompiledName("FlowGraphBezierCurveEasing")>] ``BezierCurveEasing``
        | [<CompiledName("FlowGraphDataSwitchBlock")>] ``DataSwitch``
        | [<CompiledName("FlowGraphDebugBlock")>] ``DebugBlock``
        | [<CompiledName("FlowGraphPhysicsCollisionEventBlock")>] ``PhysicsCollisionEvent``
        | [<CompiledName("FlowGraphApplyForceBlock")>] ``PhysicsApplyForce``
        | [<CompiledName("FlowGraphApplyImpulseBlock")>] ``PhysicsApplyImpulse``
        | [<CompiledName("FlowGraphSetLinearVelocityBlock")>] ``PhysicsSetLinearVelocity``
        | [<CompiledName("FlowGraphSetAngularVelocityBlock")>] ``PhysicsSetAngularVelocity``
        | [<CompiledName("FlowGraphSetPhysicsMotionTypeBlock")>] ``PhysicsSetMotionType``
        | [<CompiledName("FlowGraphGetLinearVelocityBlock")>] ``PhysicsGetLinearVelocity``
        | [<CompiledName("FlowGraphGetAngularVelocityBlock")>] ``PhysicsGetAngularVelocity``
        | [<CompiledName("FlowGraphGetPhysicsMassPropertiesBlock")>] ``PhysicsGetMassProperties``
        | [<CompiledName("FlowGraphPlaySoundBlock")>] ``AudioPlaySound``
        | [<CompiledName("FlowGraphStopSoundBlock")>] ``AudioStopSound``
        | [<CompiledName("FlowGraphPauseSoundBlock")>] ``AudioPauseSound``
        | [<CompiledName("FlowGraphSetSoundVolumeBlock")>] ``AudioSetVolume``
        | [<CompiledName("FlowGraphSoundEndedEventBlock")>] ``AudioSoundEndedEvent``
        | [<CompiledName("FlowGraphGetSoundVolumeBlock")>] ``AudioGetVolume``
        | [<CompiledName("FlowGraphIsSoundPlayingBlock")>] ``AudioIsSoundPlaying``

    /// @babylonjs/core/FlowGraph/flowGraphEventType
    [<StringEnum; RequireQualifiedAccess>]
    type FlowGraphEventType =
        | [<CompiledName("SceneReady")>] ``SceneReady``
        | [<CompiledName("SceneDispose")>] ``SceneDispose``
        | [<CompiledName("SceneBeforeRender")>] ``SceneBeforeRender``
        | [<CompiledName("SceneAfterRender")>] ``SceneAfterRender``
        | [<CompiledName("MeshPick")>] ``MeshPick``
        | [<CompiledName("PointerDown")>] ``PointerDown``
        | [<CompiledName("PointerUp")>] ``PointerUp``
        | [<CompiledName("PointerMove")>] ``PointerMove``
        | [<CompiledName("PointerOver")>] ``PointerOver``
        | [<CompiledName("PointerOut")>] ``PointerOut``
        | [<CompiledName("KeyDown")>] ``KeyDown``
        | [<CompiledName("KeyUp")>] ``KeyUp``
        | [<CompiledName("NoTrigger")>] ``NoTrigger``

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<StringEnum; RequireQualifiedAccess>]
    type FlowGraphTypes =
        | [<CompiledName("any")>] ``Any``
        | [<CompiledName("string")>] ``String``
        | [<CompiledName("number")>] ``Number``
        | [<CompiledName("boolean")>] ``Boolean``
        | [<CompiledName("object")>] ``Object``
        | [<CompiledName("FlowGraphInteger")>] ``Integer``
        | [<CompiledName("Vector2")>] ``Vector2``
        | [<CompiledName("Vector3")>] ``Vector3``
        | [<CompiledName("Vector4")>] ``Vector4``
        | [<CompiledName("Quaternion")>] ``Quaternion``
        | [<CompiledName("Matrix")>] ``Matrix``
        | [<CompiledName("Matrix2D")>] ``Matrix2D``
        | [<CompiledName("Matrix3D")>] ``Matrix3D``
        | [<CompiledName("Color3")>] ``Color3``
        | [<CompiledName("Color4")>] ``Color4``

    /// @babylonjs/core/FrameGraph/Tasks/Layers/baseLayerTask
    [<StringEnum; RequireQualifiedAccess>]
    type FrameGraphBaseLayerBlurType =
        | [<CompiledName("none")>] ``None``
        | [<CompiledName("standard")>] ``Standard``
        | [<CompiledName("glow")>] ``Glow``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type FrontFace =
        | [<CompiledName("ccw")>] ``CCW``
        | [<CompiledName("cw")>] ``CW``

    /// @babylonjs/loaders/SPLAT/gaussianSplattingStream
    [<StringEnum; RequireQualifiedAccess>]
    type GaussianSplattingStreamDebugLodSource =
        | [<CompiledName("optimal")>] ``Optimal``
        | [<CompiledName("current")>] ``Current``

    /// @babylonjs/core/Cameras/geospatialCameraMovement
    [<StringEnum; RequireQualifiedAccess>]
    type GeospatialInteraction =
        | [<CompiledName("pan")>] ``Pan``
        | [<CompiledName("rotate")>] ``Rotate``
        | [<CompiledName("zoom")>] ``Zoom``

    /// @babylonjs/core/XR/features/WebXRHandTracking.pure
    [<StringEnum; RequireQualifiedAccess>]
    type HandPart =
        | [<CompiledName("wrist")>] ``WRIST``
        | [<CompiledName("thumb")>] ``THUMB``
        | [<CompiledName("index")>] ``INDEX``
        | [<CompiledName("middle")>] ``MIDDLE``
        | [<CompiledName("ring")>] ``RING``
        | [<CompiledName("little")>] ``LITTLE``

    /// @babylonjs/core/Debug/debugLayer.pure
    [<StringEnum; RequireQualifiedAccess>]
    type IInspectorContextMenuType =
        | [<CompiledName("pipeline")>] ``Pipeline``
        | [<CompiledName("node")>] ``Node``
        | [<CompiledName("materials")>] ``Materials``
        | [<CompiledName("spriteManagers")>] ``SpriteManagers``
        | [<CompiledName("particleSystems")>] ``ParticleSystems``
        | [<CompiledName("frameGraphs")>] ``FrameGraphs``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type IndexFormat =
        | [<CompiledName("uint16")>] ``Uint16``
        | [<CompiledName("uint32")>] ``Uint32``

    /// @babylonjs/core/Cameras/inputMapper
    [<StringEnum; RequireQualifiedAccess>]
    type InputSource =
        | [<CompiledName("pointer")>] ``Pointer``
        | [<CompiledName("wheel")>] ``Wheel``
        | [<CompiledName("touch")>] ``Touch``
        | [<CompiledName("keyboard")>] ``Keyboard``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type LoadOp =
        | [<CompiledName("load")>] ``Load``
        | [<CompiledName("clear")>] ``Clear``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type MipmapFilterMode =
        | [<CompiledName("nearest")>] ``Nearest``
        | [<CompiledName("linear")>] ``Linear``

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<StringEnum; RequireQualifiedAccess>]
    type MotionControllerComponentStateType =
        | [<CompiledName("default")>] ``Default``
        | [<CompiledName("touched")>] ``Touched``
        | [<CompiledName("pressed")>] ``Pressed``

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<StringEnum; RequireQualifiedAccess>]
    type MotionControllerComponentType =
        | [<CompiledName("trigger")>] ``Trigger``
        | [<CompiledName("squeeze")>] ``Squeeze``
        | [<CompiledName("touchpad")>] ``Touchpad``
        | [<CompiledName("thumbstick")>] ``Thumbstick``
        | [<CompiledName("button")>] ``Button``

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<StringEnum; RequireQualifiedAccess>]
    type MotionControllerHandedness =
        | [<CompiledName("none")>] ``None``
        | [<CompiledName("left")>] ``Left``
        | [<CompiledName("right")>] ``Right``

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    [<StringEnum; RequireQualifiedAccess>]
    type PhysicsEventType =
        | [<CompiledName("COLLISION_STARTED")>] ``COLLISIONSTARTED``
        | [<CompiledName("COLLISION_CONTINUED")>] ``COLLISIONCONTINUED``
        | [<CompiledName("COLLISION_FINISHED")>] ``COLLISIONFINISHED``
        | [<CompiledName("TRIGGER_ENTERED")>] ``TRIGGERENTERED``
        | [<CompiledName("TRIGGER_EXITED")>] ``TRIGGEREXITED``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type PipelineErrorReason =
        | [<CompiledName("validation")>] ``Validation``
        | [<CompiledName("internal")>] ``Internal``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type PowerPreference =
        | [<CompiledName("low-power")>] ``LowPower``
        | [<CompiledName("high-performance")>] ``HighPerformance``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type PrimitiveTopology =
        | [<CompiledName("point-list")>] ``PointList``
        | [<CompiledName("line-list")>] ``LineList``
        | [<CompiledName("line-strip")>] ``LineStrip``
        | [<CompiledName("triangle-list")>] ``TriangleList``
        | [<CompiledName("triangle-strip")>] ``TriangleStrip``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type QueryType =
        | [<CompiledName("occlusion")>] ``Occlusion``
        | [<CompiledName("timestamp")>] ``Timestamp``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type RenderPassTimestampLocation =
        | [<CompiledName("beginning")>] ``Beginning``
        | [<CompiledName("end")>] ``End``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type SamplerBindingType =
        | [<CompiledName("filtering")>] ``Filtering``
        | [<CompiledName("non-filtering")>] ``NonFiltering``
        | [<CompiledName("comparison")>] ``Comparison``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type StencilOperation =
        | [<CompiledName("keep")>] ``Keep``
        | [<CompiledName("zero")>] ``Zero``
        | [<CompiledName("replace")>] ``Replace``
        | [<CompiledName("invert")>] ``Invert``
        | [<CompiledName("increment-clamp")>] ``IncrementClamp``
        | [<CompiledName("decrement-clamp")>] ``DecrementClamp``
        | [<CompiledName("increment-wrap")>] ``IncrementWrap``
        | [<CompiledName("decrement-wrap")>] ``DecrementWrap``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type StorageTextureAccess =
        | [<CompiledName("write-only")>] ``WriteOnly``
        | [<CompiledName("read-only")>] ``ReadOnly``
        | [<CompiledName("read-write")>] ``ReadWrite``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type StoreOp =
        | [<CompiledName("store")>] ``Store``
        | [<CompiledName("discard")>] ``Discard``

    /// @babylonjs/core/Cameras/targetCameraMovement
    [<StringEnum; RequireQualifiedAccess>]
    type TargetCameraInteraction =
        | [<CompiledName("rotate")>] ``Rotate``
        | [<CompiledName("translate")>] ``Translate``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type TextureAspect =
        | [<CompiledName("all")>] ``All``
        | [<CompiledName("stencil-only")>] ``StencilOnly``
        | [<CompiledName("depth-only")>] ``DepthOnly``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type TextureDimension =
        | [<CompiledName("1d")>] ``E1d``
        | [<CompiledName("2d")>] ``E2d``
        | [<CompiledName("3d")>] ``E3d``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type TextureFormat =
        | [<CompiledName("r8unorm")>] ``R8Unorm``
        | [<CompiledName("r8snorm")>] ``R8Snorm``
        | [<CompiledName("r8uint")>] ``R8Uint``
        | [<CompiledName("r8sint")>] ``R8Sint``
        | [<CompiledName("r16uint")>] ``R16Uint``
        | [<CompiledName("r16sint")>] ``R16Sint``
        | [<CompiledName("r16float")>] ``R16Float``
        | [<CompiledName("rg8unorm")>] ``RG8Unorm``
        | [<CompiledName("rg8snorm")>] ``RG8Snorm``
        | [<CompiledName("rg8uint")>] ``RG8Uint``
        | [<CompiledName("rg8sint")>] ``RG8Sint``
        | [<CompiledName("r16unorm")>] ``R16Unorm``
        | [<CompiledName("r16snorm")>] ``R16Snorm``
        | [<CompiledName("r32uint")>] ``R32Uint``
        | [<CompiledName("r32sint")>] ``R32Sint``
        | [<CompiledName("r32float")>] ``R32Float``
        | [<CompiledName("rg16uint")>] ``RG16Uint``
        | [<CompiledName("rg16sint")>] ``RG16Sint``
        | [<CompiledName("rg16float")>] ``RG16Float``
        | [<CompiledName("rgba8unorm")>] ``RGBA8Unorm``
        | [<CompiledName("rgba8unorm-srgb")>] ``RGBA8UnormSRGB``
        | [<CompiledName("rgba8snorm")>] ``RGBA8Snorm``
        | [<CompiledName("rgba8uint")>] ``RGBA8Uint``
        | [<CompiledName("rgba8sint")>] ``RGBA8Sint``
        | [<CompiledName("bgra8unorm")>] ``BGRA8Unorm``
        | [<CompiledName("bgra8unorm-srgb")>] ``BGRA8UnormSRGB``
        | [<CompiledName("rg16unorm")>] ``RG16Unorm``
        | [<CompiledName("rg16snorm")>] ``RG16Snorm``
        | [<CompiledName("rgb9e5ufloat")>] ``RGB9E5UFloat``
        | [<CompiledName("rgb10a2uint")>] ``RGB10A2UINT``
        | [<CompiledName("rgb10a2unorm")>] ``RGB10A2Unorm``
        | [<CompiledName("rg11b10ufloat")>] ``RG11B10UFloat``
        | [<CompiledName("rg32uint")>] ``RG32Uint``
        | [<CompiledName("rg32sint")>] ``RG32Sint``
        | [<CompiledName("rg32float")>] ``RG32Float``
        | [<CompiledName("rgba16uint")>] ``RGBA16Uint``
        | [<CompiledName("rgba16sint")>] ``RGBA16Sint``
        | [<CompiledName("rgba16float")>] ``RGBA16Float``
        | [<CompiledName("rgba16unorm")>] ``RGBA16Unorm``
        | [<CompiledName("rgba16snorm")>] ``RGBA16Snorm``
        | [<CompiledName("rgba32uint")>] ``RGBA32Uint``
        | [<CompiledName("rgba32sint")>] ``RGBA32Sint``
        | [<CompiledName("rgba32float")>] ``RGBA32Float``
        | [<CompiledName("stencil8")>] ``Stencil8``
        | [<CompiledName("depth16unorm")>] ``Depth16Unorm``
        | [<CompiledName("depth24plus")>] ``Depth24Plus``
        | [<CompiledName("depth24plus-stencil8")>] ``Depth24PlusStencil8``
        | [<CompiledName("depth32float")>] ``Depth32Float``
        | [<CompiledName("bc1-rgba-unorm")>] ``BC1RGBAUnorm``
        | [<CompiledName("bc1-rgba-unorm-srgb")>] ``BC1RGBAUnormSRGB``
        | [<CompiledName("bc2-rgba-unorm")>] ``BC2RGBAUnorm``
        | [<CompiledName("bc2-rgba-unorm-srgb")>] ``BC2RGBAUnormSRGB``
        | [<CompiledName("bc3-rgba-unorm")>] ``BC3RGBAUnorm``
        | [<CompiledName("bc3-rgba-unorm-srgb")>] ``BC3RGBAUnormSRGB``
        | [<CompiledName("bc4-r-unorm")>] ``BC4RUnorm``
        | [<CompiledName("bc4-r-snorm")>] ``BC4RSnorm``
        | [<CompiledName("bc5-rg-unorm")>] ``BC5RGUnorm``
        | [<CompiledName("bc5-rg-snorm")>] ``BC5RGSnorm``
        | [<CompiledName("bc6h-rgb-ufloat")>] ``BC6HRGBUFloat``
        | [<CompiledName("bc6h-rgb-float")>] ``BC6HRGBFloat``
        | [<CompiledName("bc7-rgba-unorm")>] ``BC7RGBAUnorm``
        | [<CompiledName("bc7-rgba-unorm-srgb")>] ``BC7RGBAUnormSRGB``
        | [<CompiledName("etc2-rgb8unorm")>] ``ETC2RGB8Unorm``
        | [<CompiledName("etc2-rgb8unorm-srgb")>] ``ETC2RGB8UnormSRGB``
        | [<CompiledName("etc2-rgb8a1unorm")>] ``ETC2RGB8A1Unorm``
        | [<CompiledName("etc2-rgb8a1unorm-srgb")>] ``ETC2RGB8A1UnormSRGB``
        | [<CompiledName("etc2-rgba8unorm")>] ``ETC2RGBA8Unorm``
        | [<CompiledName("etc2-rgba8unorm-srgb")>] ``ETC2RGBA8UnormSRGB``
        | [<CompiledName("eac-r11unorm")>] ``EACR11Unorm``
        | [<CompiledName("eac-r11snorm")>] ``EACR11Snorm``
        | [<CompiledName("eac-rg11unorm")>] ``EACRG11Unorm``
        | [<CompiledName("eac-rg11snorm")>] ``EACRG11Snorm``
        | [<CompiledName("astc-4x4-unorm")>] ``ASTC4x4Unorm``
        | [<CompiledName("astc-4x4-unorm-srgb")>] ``ASTC4x4UnormSRGB``
        | [<CompiledName("astc-5x4-unorm")>] ``ASTC5x4Unorm``
        | [<CompiledName("astc-5x4-unorm-srgb")>] ``ASTC5x4UnormSRGB``
        | [<CompiledName("astc-5x5-unorm")>] ``ASTC5x5Unorm``
        | [<CompiledName("astc-5x5-unorm-srgb")>] ``ASTC5x5UnormSRGB``
        | [<CompiledName("astc-6x5-unorm")>] ``ASTC6x5Unorm``
        | [<CompiledName("astc-6x5-unorm-srgb")>] ``ASTC6x5UnormSRGB``
        | [<CompiledName("astc-6x6-unorm")>] ``ASTC6x6Unorm``
        | [<CompiledName("astc-6x6-unorm-srgb")>] ``ASTC6x6UnormSRGB``
        | [<CompiledName("astc-8x5-unorm")>] ``ASTC8x5Unorm``
        | [<CompiledName("astc-8x5-unorm-srgb")>] ``ASTC8x5UnormSRGB``
        | [<CompiledName("astc-8x6-unorm")>] ``ASTC8x6Unorm``
        | [<CompiledName("astc-8x6-unorm-srgb")>] ``ASTC8x6UnormSRGB``
        | [<CompiledName("astc-8x8-unorm")>] ``ASTC8x8Unorm``
        | [<CompiledName("astc-8x8-unorm-srgb")>] ``ASTC8x8UnormSRGB``
        | [<CompiledName("astc-10x5-unorm")>] ``ASTC10x5Unorm``
        | [<CompiledName("astc-10x5-unorm-srgb")>] ``ASTC10x5UnormSRGB``
        | [<CompiledName("astc-10x6-unorm")>] ``ASTC10x6Unorm``
        | [<CompiledName("astc-10x6-unorm-srgb")>] ``ASTC10x6UnormSRGB``
        | [<CompiledName("astc-10x8-unorm")>] ``ASTC10x8Unorm``
        | [<CompiledName("astc-10x8-unorm-srgb")>] ``ASTC10x8UnormSRGB``
        | [<CompiledName("astc-10x10-unorm")>] ``ASTC10x10Unorm``
        | [<CompiledName("astc-10x10-unorm-srgb")>] ``ASTC10x10UnormSRGB``
        | [<CompiledName("astc-12x10-unorm")>] ``ASTC12x10Unorm``
        | [<CompiledName("astc-12x10-unorm-srgb")>] ``ASTC12x10UnormSRGB``
        | [<CompiledName("astc-12x12-unorm")>] ``ASTC12x12Unorm``
        | [<CompiledName("astc-12x12-unorm-srgb")>] ``ASTC12x12UnormSRGB``
        | [<CompiledName("depth32float-stencil8")>] ``Depth32FloatStencil8``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type TextureSampleType =
        | [<CompiledName("float")>] ``Float``
        | [<CompiledName("unfilterable-float")>] ``UnfilterableFloat``
        | [<CompiledName("depth")>] ``Depth``
        | [<CompiledName("sint")>] ``Sint``
        | [<CompiledName("uint")>] ``Uint``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type TextureViewDimension =
        | [<CompiledName("1d")>] ``E1d``
        | [<CompiledName("2d")>] ``E2d``
        | [<CompiledName("2d-array")>] ``E2dArray``
        | [<CompiledName("cube")>] ``Cube``
        | [<CompiledName("cube-array")>] ``CubeArray``
        | [<CompiledName("3d")>] ``E3d``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type VertexFormat =
        | [<CompiledName("uint8")>] ``Uint8``
        | [<CompiledName("uint8x2")>] ``Uint8x2``
        | [<CompiledName("uint8x4")>] ``Uint8x4``
        | [<CompiledName("sint8")>] ``Sint8``
        | [<CompiledName("sint8x2")>] ``Sint8x2``
        | [<CompiledName("sint8x4")>] ``Sint8x4``
        | [<CompiledName("unorm8")>] ``Unorm8``
        | [<CompiledName("unorm8x2")>] ``Unorm8x2``
        | [<CompiledName("unorm8x4")>] ``Unorm8x4``
        | [<CompiledName("snorm8")>] ``Snorm8``
        | [<CompiledName("snorm8x2")>] ``Snorm8x2``
        | [<CompiledName("snorm8x4")>] ``Snorm8x4``
        | [<CompiledName("uint16")>] ``Uint16``
        | [<CompiledName("uint16x2")>] ``Uint16x2``
        | [<CompiledName("uint16x4")>] ``Uint16x4``
        | [<CompiledName("sint16")>] ``Sint16``
        | [<CompiledName("sint16x2")>] ``Sint16x2``
        | [<CompiledName("sint16x4")>] ``Sint16x4``
        | [<CompiledName("unorm16")>] ``Unorm16``
        | [<CompiledName("unorm16x2")>] ``Unorm16x2``
        | [<CompiledName("unorm16x4")>] ``Unorm16x4``
        | [<CompiledName("snorm16")>] ``Snorm16``
        | [<CompiledName("snorm16x2")>] ``Snorm16x2``
        | [<CompiledName("snorm16x4")>] ``Snorm16x4``
        | [<CompiledName("float16")>] ``Float16``
        | [<CompiledName("float16x2")>] ``Float16x2``
        | [<CompiledName("float16x4")>] ``Float16x4``
        | [<CompiledName("float32")>] ``Float32``
        | [<CompiledName("float32x2")>] ``Float32x2``
        | [<CompiledName("float32x3")>] ``Float32x3``
        | [<CompiledName("float32x4")>] ``Float32x4``
        | [<CompiledName("uint32")>] ``Uint32``
        | [<CompiledName("uint32x2")>] ``Uint32x2``
        | [<CompiledName("uint32x3")>] ``Uint32x3``
        | [<CompiledName("uint32x4")>] ``Uint32x4``
        | [<CompiledName("sint32")>] ``Sint32``
        | [<CompiledName("sint32x2")>] ``Sint32x2``
        | [<CompiledName("sint32x3")>] ``Sint32x3``
        | [<CompiledName("sint32x4")>] ``Sint32x4``
        | [<CompiledName("unorm10-10-10-2")>] ``UNORM10x10x10x2``
        | [<CompiledName("unorm8x4-bgra")>] ``UNORM8x4BGRA``

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    [<StringEnum; RequireQualifiedAccess>]
    type VertexStepMode =
        | [<CompiledName("vertex")>] ``Vertex``
        | [<CompiledName("instance")>] ``Instance``

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<StringEnum; RequireQualifiedAccess>]
    type WebXRBodyJoint =
        | [<CompiledName("hips")>] ``HIPS``
        | [<CompiledName("spine-lower")>] ``SPINELOWER``
        | [<CompiledName("spine-middle")>] ``SPINEMIDDLE``
        | [<CompiledName("spine-upper")>] ``SPINEUPPER``
        | [<CompiledName("chest")>] ``CHEST``
        | [<CompiledName("neck")>] ``NECK``
        | [<CompiledName("head")>] ``HEAD``
        | [<CompiledName("left-shoulder")>] ``LEFTSHOULDER``
        | [<CompiledName("left-scapula")>] ``LEFTSCAPULA``
        | [<CompiledName("left-arm-upper")>] ``LEFTARMUPPER``
        | [<CompiledName("left-arm-lower")>] ``LEFTARMLOWER``
        | [<CompiledName("left-hand-wrist-twist")>] ``LEFTHANDWRISTTWIST``
        | [<CompiledName("right-shoulder")>] ``RIGHTSHOULDER``
        | [<CompiledName("right-scapula")>] ``RIGHTSCAPULA``
        | [<CompiledName("right-arm-upper")>] ``RIGHTARMUPPER``
        | [<CompiledName("right-arm-lower")>] ``RIGHTARMLOWER``
        | [<CompiledName("right-hand-wrist-twist")>] ``RIGHTHANDWRISTTWIST``
        | [<CompiledName("left-hand-palm")>] ``LEFTHANDPALM``
        | [<CompiledName("left-hand-wrist")>] ``LEFTHANDWRIST``
        | [<CompiledName("left-hand-thumb-metacarpal")>] ``LEFTHANDTHUMBMETACARPAL``
        | [<CompiledName("left-hand-thumb-phalanx-proximal")>] ``LEFTHANDTHUMBPHALANXPROXIMAL``
        | [<CompiledName("left-hand-thumb-phalanx-distal")>] ``LEFTHANDTHUMBPHALANXDISTAL``
        | [<CompiledName("left-hand-thumb-tip")>] ``LEFTHANDTHUMBTIP``
        | [<CompiledName("left-hand-index-metacarpal")>] ``LEFTHANDINDEXMETACARPAL``
        | [<CompiledName("left-hand-index-phalanx-proximal")>] ``LEFTHANDINDEXPHALANXPROXIMAL``
        | [<CompiledName("left-hand-index-phalanx-intermediate")>] ``LEFTHANDINDEXPHALANXINTERMEDIATE``
        | [<CompiledName("left-hand-index-phalanx-distal")>] ``LEFTHANDINDEXPHALANXDISTAL``
        | [<CompiledName("left-hand-index-tip")>] ``LEFTHANDINDEXTIP``
        | [<CompiledName("left-hand-middle-metacarpal")>] ``LEFTHANDMIDDLEMETACARPAL``
        | [<CompiledName("left-hand-middle-phalanx-proximal")>] ``LEFTHANDMIDDLEPHALANXPROXIMAL``
        | [<CompiledName("left-hand-middle-phalanx-intermediate")>] ``LEFTHANDMIDDLEPHALANXINTERMEDIATE``
        | [<CompiledName("left-hand-middle-phalanx-distal")>] ``LEFTHANDMIDDLEPHALANXDISTAL``
        | [<CompiledName("left-hand-middle-tip")>] ``LEFTHANDMIDDLETIP``
        | [<CompiledName("left-hand-ring-metacarpal")>] ``LEFTHANDRINGMETACARPAL``
        | [<CompiledName("left-hand-ring-phalanx-proximal")>] ``LEFTHANDRINGPHALANXPROXIMAL``
        | [<CompiledName("left-hand-ring-phalanx-intermediate")>] ``LEFTHANDRINGPHALANXINTERMEDIATE``
        | [<CompiledName("left-hand-ring-phalanx-distal")>] ``LEFTHANDRINGPHALANXDISTAL``
        | [<CompiledName("left-hand-ring-tip")>] ``LEFTHANDRINGTIP``
        | [<CompiledName("left-hand-little-metacarpal")>] ``LEFTHANDLITTLEMETACARPAL``
        | [<CompiledName("left-hand-little-phalanx-proximal")>] ``LEFTHANDLITTLEPHALANXPROXIMAL``
        | [<CompiledName("left-hand-little-phalanx-intermediate")>] ``LEFTHANDLITTLEPHALANXINTERMEDIATE``
        | [<CompiledName("left-hand-little-phalanx-distal")>] ``LEFTHANDLITTLEPHALANXDISTAL``
        | [<CompiledName("left-hand-little-tip")>] ``LEFTHANDLITTLETIP``
        | [<CompiledName("right-hand-palm")>] ``RIGHTHANDPALM``
        | [<CompiledName("right-hand-wrist")>] ``RIGHTHANDWRIST``
        | [<CompiledName("right-hand-thumb-metacarpal")>] ``RIGHTHANDTHUMBMETACARPAL``
        | [<CompiledName("right-hand-thumb-phalanx-proximal")>] ``RIGHTHANDTHUMBPHALANXPROXIMAL``
        | [<CompiledName("right-hand-thumb-phalanx-distal")>] ``RIGHTHANDTHUMBPHALANXDISTAL``
        | [<CompiledName("right-hand-thumb-tip")>] ``RIGHTHANDTHUMBTIP``
        | [<CompiledName("right-hand-index-metacarpal")>] ``RIGHTHANDINDEXMETACARPAL``
        | [<CompiledName("right-hand-index-phalanx-proximal")>] ``RIGHTHANDINDEXPHALANXPROXIMAL``
        | [<CompiledName("right-hand-index-phalanx-intermediate")>] ``RIGHTHANDINDEXPHALANXINTERMEDIATE``
        | [<CompiledName("right-hand-index-phalanx-distal")>] ``RIGHTHANDINDEXPHALANXDISTAL``
        | [<CompiledName("right-hand-index-tip")>] ``RIGHTHANDINDEXTIP``
        | [<CompiledName("right-hand-middle-metacarpal")>] ``RIGHTHANDMIDDLEMETACARPAL``
        | [<CompiledName("right-hand-middle-phalanx-proximal")>] ``RIGHTHANDMIDDLEPHALANXPROXIMAL``
        | [<CompiledName("right-hand-middle-phalanx-intermediate")>] ``RIGHTHANDMIDDLEPHALANXINTERMEDIATE``
        | [<CompiledName("right-hand-middle-phalanx-distal")>] ``RIGHTHANDMIDDLEPHALANXDISTAL``
        | [<CompiledName("right-hand-middle-tip")>] ``RIGHTHANDMIDDLETIP``
        | [<CompiledName("right-hand-ring-metacarpal")>] ``RIGHTHANDRINGMETACARPAL``
        | [<CompiledName("right-hand-ring-phalanx-proximal")>] ``RIGHTHANDRINGPHALANXPROXIMAL``
        | [<CompiledName("right-hand-ring-phalanx-intermediate")>] ``RIGHTHANDRINGPHALANXINTERMEDIATE``
        | [<CompiledName("right-hand-ring-phalanx-distal")>] ``RIGHTHANDRINGPHALANXDISTAL``
        | [<CompiledName("right-hand-ring-tip")>] ``RIGHTHANDRINGTIP``
        | [<CompiledName("right-hand-little-metacarpal")>] ``RIGHTHANDLITTLEMETACARPAL``
        | [<CompiledName("right-hand-little-phalanx-proximal")>] ``RIGHTHANDLITTLEPHALANXPROXIMAL``
        | [<CompiledName("right-hand-little-phalanx-intermediate")>] ``RIGHTHANDLITTLEPHALANXINTERMEDIATE``
        | [<CompiledName("right-hand-little-phalanx-distal")>] ``RIGHTHANDLITTLEPHALANXDISTAL``
        | [<CompiledName("right-hand-little-tip")>] ``RIGHTHANDLITTLETIP``
        | [<CompiledName("left-upper-leg")>] ``LEFTUPPERLEG``
        | [<CompiledName("left-lower-leg")>] ``LEFTLOWERLEG``
        | [<CompiledName("left-foot-ankle-twist")>] ``LEFTFOOTANKLETWIST``
        | [<CompiledName("left-foot-ankle")>] ``LEFTFOOTANKLE``
        | [<CompiledName("left-foot-subtalar")>] ``LEFTFOOTSUBTALAR``
        | [<CompiledName("left-foot-transverse")>] ``LEFTFOOTTRANSVERSE``
        | [<CompiledName("left-foot-ball")>] ``LEFTFOOTBALL``
        | [<CompiledName("right-upper-leg")>] ``RIGHTUPPERLEG``
        | [<CompiledName("right-lower-leg")>] ``RIGHTLOWERLEG``
        | [<CompiledName("right-foot-ankle-twist")>] ``RIGHTFOOTANKLETWIST``
        | [<CompiledName("right-foot-ankle")>] ``RIGHTFOOTANKLE``
        | [<CompiledName("right-foot-subtalar")>] ``RIGHTFOOTSUBTALAR``
        | [<CompiledName("right-foot-transverse")>] ``RIGHTFOOTTRANSVERSE``
        | [<CompiledName("right-foot-ball")>] ``RIGHTFOOTBALL``

    /// @babylonjs/core/XR/webXRLayerWrapper
    [<StringEnum; RequireQualifiedAccess>]
    type WebXRCompositionLayerType =
        | [<CompiledName("XRProjectionLayer")>] ``XRProjectionLayer``

    /// @babylonjs/core/XR/features/WebXRDepthSensing.pure
    [<StringEnum; RequireQualifiedAccess>]
    type WebXRDepthDataFormat =
        | [<CompiledName("ushort")>] ``Ushort``
        | [<CompiledName("float")>] ``Float``
        | [<CompiledName("luminance-alpha")>] ``LuminanceAlpha``

    /// @babylonjs/core/XR/features/WebXRDepthSensing.pure
    [<StringEnum; RequireQualifiedAccess>]
    type WebXRDepthUsage =
        | [<CompiledName("cpu")>] ``Cpu``
        | [<CompiledName("gpu")>] ``Gpu``

    /// @babylonjs/core/XR/features/WebXRHandTracking.pure
    [<StringEnum; RequireQualifiedAccess>]
    type WebXRHandJoint =
        | [<CompiledName("wrist")>] ``WRIST``
        | [<CompiledName("thumb-metacarpal")>] ``THUMBMETACARPAL``
        | [<CompiledName("thumb-phalanx-proximal")>] ``THUMBPHALANXPROXIMAL``
        | [<CompiledName("thumb-phalanx-distal")>] ``THUMBPHALANXDISTAL``
        | [<CompiledName("thumb-tip")>] ``THUMBTIP``
        | [<CompiledName("index-finger-metacarpal")>] ``INDEXFINGERMETACARPAL``
        | [<CompiledName("index-finger-phalanx-proximal")>] ``INDEXFINGERPHALANXPROXIMAL``
        | [<CompiledName("index-finger-phalanx-intermediate")>] ``INDEXFINGERPHALANXINTERMEDIATE``
        | [<CompiledName("index-finger-phalanx-distal")>] ``INDEXFINGERPHALANXDISTAL``
        | [<CompiledName("index-finger-tip")>] ``INDEXFINGERTIP``
        | [<CompiledName("middle-finger-metacarpal")>] ``MIDDLEFINGERMETACARPAL``
        | [<CompiledName("middle-finger-phalanx-proximal")>] ``MIDDLEFINGERPHALANXPROXIMAL``
        | [<CompiledName("middle-finger-phalanx-intermediate")>] ``MIDDLEFINGERPHALANXINTERMEDIATE``
        | [<CompiledName("middle-finger-phalanx-distal")>] ``MIDDLEFINGERPHALANXDISTAL``
        | [<CompiledName("middle-finger-tip")>] ``MIDDLEFINGERTIP``
        | [<CompiledName("ring-finger-metacarpal")>] ``RINGFINGERMETACARPAL``
        | [<CompiledName("ring-finger-phalanx-proximal")>] ``RINGFINGERPHALANXPROXIMAL``
        | [<CompiledName("ring-finger-phalanx-intermediate")>] ``RINGFINGERPHALANXINTERMEDIATE``
        | [<CompiledName("ring-finger-phalanx-distal")>] ``RINGFINGERPHALANXDISTAL``
        | [<CompiledName("ring-finger-tip")>] ``RINGFINGERTIP``
        | [<CompiledName("pinky-finger-metacarpal")>] ``PINKYFINGERMETACARPAL``
        | [<CompiledName("pinky-finger-phalanx-proximal")>] ``PINKYFINGERPHALANXPROXIMAL``
        | [<CompiledName("pinky-finger-phalanx-intermediate")>] ``PINKYFINGERPHALANXINTERMEDIATE``
        | [<CompiledName("pinky-finger-phalanx-distal")>] ``PINKYFINGERPHALANXDISTAL``
        | [<CompiledName("pinky-finger-tip")>] ``PINKYFINGERTIP``

    /// @babylonjs/core/XR/webXRLayerWrapper
    [<StringEnum; RequireQualifiedAccess>]
    type WebXRLayerType =
        | [<CompiledName("XRProjectionLayer")>] ``XRProjectionLayer``
        | [<CompiledName("XRQuadLayer")>] ``XRQuadLayer``
        | [<CompiledName("XRWebGLLayer")>] ``XRWebGLLayer``

    /// @babylonjs/core/XR/webXRLayerWrapper
    [<StringEnum; RequireQualifiedAccess>]
    type WebXRQuadLayerType =
        | [<CompiledName("XRQuadLayer")>] ``XRQuadLayer``
