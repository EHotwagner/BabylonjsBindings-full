// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after enum review, compile, and runtime proof
namespace BabylonjsBindings

/// Exact numeric enums exported by @babylonjs/core and @babylonjs/loaders 9.19.0.
module Enums =

    /// @babylonjs/core/Meshes/Node/Blocks/Set/aggregatorBlock.pure
    type Aggregations =
        | ``Max`` = 0
        | ``Min`` = 1
        | ``Sum`` = 2

    /// @babylonjs/core/Materials/Node/Blocks/Input/animatedInputBlockTypes
    type AnimatedInputBlockTypes =
        | ``None`` = 0
        | ``Time`` = 1
        | ``RealTime`` = 2
        | ``MouseInfo`` = 3

    /// @babylonjs/core/Animations/animationGroupMask
    type AnimationGroupMaskMode =
        | ``Include`` = 0
        | ``Exclude`` = 1

    /// @babylonjs/core/Animations/animationKey
    type AnimationKeyInterpolation =
        | ``NONE`` = 0
        | ``STEP`` = 1

    /// @babylonjs/core/Misc/assetsManager
    type AssetTaskState =
        | ``INIT`` = 0
        | ``RUNNING`` = 1
        | ``DONE`` = 2
        | ``ERROR`` = 3

    /// @babylonjs/core/AudioV2/abstractAudio/abstractAudioNode
    type AudioNodeType =
        | ``HAS_INPUTS`` = 1
        | ``HAS_OUTPUTS`` = 2
        | ``HAS_INPUTS_AND_OUTPUTS`` = 3

    /// @babylonjs/core/Meshes/Node/Blocks/booleanGeometryBlock.pure
    type BooleanGeometryOperations =
        | ``Intersect`` = 0
        | ``Subtract`` = 1
        | ``Union`` = 2

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    type BufferUsage =
        | ``MapRead`` = 1
        | ``MapWrite`` = 2
        | ``CopySrc`` = 4
        | ``CopyDst`` = 8
        | ``Index`` = 16
        | ``Vertex`` = 32
        | ``Uniform`` = 64
        | ``Storage`` = 128
        | ``Indirect`` = 256
        | ``QueryResolve`` = 512

    /// @babylonjs/core/Materials/Textures/textureProcessor
    type ChannelMask =
        | ``R`` = 1
        | ``G`` = 2
        | ``B`` = 4
        | ``A`` = 8
        | ``RGB`` = 7
        | ``RGBA`` = 15

    /// @babylonjs/core/Physics/v2/characterController
    type CharacterSupportedState =
        | ``UNSUPPORTED`` = 0
        | ``SLIDING`` = 1
        | ``SUPPORTED`` = 2

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    type ColorWrite =
        | ``Red`` = 1
        | ``Green`` = 2
        | ``Blue`` = 4
        | ``Alpha`` = 8
        | ``All`` = 15

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    type CompressionCodes =
        | ``NO_COMPRESSION`` = 0
        | ``RLE_COMPRESSION`` = 1
        | ``ZIPS_COMPRESSION`` = 2
        | ``ZIP_COMPRESSION`` = 3
        | ``PIZ_COMPRESSION`` = 4
        | ``PXR24_COMPRESSION`` = 5

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    type ComputeBindingType =
        | ``Texture`` = 0
        | ``StorageTexture`` = 1
        | ``UniformBuffer`` = 2
        | ``StorageBuffer`` = 3
        | ``TextureWithoutSampler`` = 4
        | ``Sampler`` = 5
        | ``ExternalTexture`` = 6
        | ``DataBuffer`` = 7
        | ``InternalTexture`` = 8

    /// @babylonjs/core/Materials/Node/Blocks/conditionalBlock.pure
    type ConditionalBlockConditions =
        | ``Equal`` = 0
        | ``NotEqual`` = 1
        | ``LessThan`` = 2
        | ``GreaterThan`` = 3
        | ``LessOrEqual`` = 4
        | ``GreaterOrEqual`` = 5
        | ``Xor`` = 6
        | ``Or`` = 7
        | ``And`` = 8

    /// @babylonjs/core/Meshes/Node/Blocks/conditionBlock.pure
    type ConditionBlockTests =
        | ``Equal`` = 0
        | ``NotEqual`` = 1
        | ``LessThan`` = 2
        | ``GreaterThan`` = 3
        | ``LessOrEqual`` = 4
        | ``GreaterOrEqual`` = 5
        | ``Xor`` = 6
        | ``Or`` = 7
        | ``And`` = 8

    /// @babylonjs/core/Misc/copyTextureToTexture
    type ConversionMode =
        | ``None`` = 0
        | ``ToLinearSpace`` = 1
        | ``ToGammaSpace`` = 2

    /// @babylonjs/core/Maths/math.axis
    type Coordinate =
        | ``X`` = 0
        | ``Y`` = 1
        | ``Z`` = 2

    /// @babylonjs/core/Materials/Node/Blocks/curveBlock.pure
    type CurveBlockTypes =
        | ``EaseInSine`` = 0
        | ``EaseOutSine`` = 1
        | ``EaseInOutSine`` = 2
        | ``EaseInQuad`` = 3
        | ``EaseOutQuad`` = 4
        | ``EaseInOutQuad`` = 5
        | ``EaseInCubic`` = 6
        | ``EaseOutCubic`` = 7
        | ``EaseInOutCubic`` = 8
        | ``EaseInQuart`` = 9
        | ``EaseOutQuart`` = 10
        | ``EaseInOutQuart`` = 11
        | ``EaseInQuint`` = 12
        | ``EaseOutQuint`` = 13
        | ``EaseInOutQuint`` = 14
        | ``EaseInExpo`` = 15
        | ``EaseOutExpo`` = 16
        | ``EaseInOutExpo`` = 17
        | ``EaseInCirc`` = 18
        | ``EaseOutCirc`` = 19
        | ``EaseInOutCirc`` = 20
        | ``EaseInBack`` = 21
        | ``EaseOutBack`` = 22
        | ``EaseInOutBack`` = 23
        | ``EaseInElastic`` = 24
        | ``EaseOutElastic`` = 25
        | ``EaseInOutElastic`` = 26

    /// @babylonjs/core/Debug/debugLayer.pure
    type DebugLayerTab =
        | ``Properties`` = 0
        | ``Debug`` = 1
        | ``Statistics`` = 2
        | ``Tools`` = 3
        | ``Settings`` = 4

    /// @babylonjs/core/PostProcesses/depthOfFieldEffect
    type DepthOfFieldEffectBlurLevel =
        | ``Low`` = 0
        | ``Medium`` = 1
        | ``High`` = 2

    /// @babylonjs/core/Misc/thinMinMaxReducer
    type DepthTextureType =
        | ``NormalizedViewDepth`` = 0
        | ``ViewDepth`` = 1
        | ``ScreenDepth`` = 2

    /// @babylonjs/core/Events/deviceInputEvents
    type DeviceInputEventType =
        | ``PointerMove`` = 0
        | ``PointerDown`` = 1
        | ``PointerUp`` = 2

    /// @babylonjs/core/DeviceInput/InputDevices/deviceEnums
    type DeviceType =
        | ``Generic`` = 0
        | ``Keyboard`` = 1
        | ``Mouse`` = 2
        | ``Touch`` = 3
        | ``DualShock`` = 4
        | ``Xbox`` = 5
        | ``Switch`` = 6
        | ``DualSense`` = 7

    /// @babylonjs/core/Gizmos/boundingBoxGizmo
    type DragOperation =
        | ``Rotation`` = 0
        | ``Scaling`` = 1

    /// @babylonjs/core/DeviceInput/InputDevices/deviceEnums
    type DualSenseInput =
        | ``Cross`` = 0
        | ``Circle`` = 1
        | ``Square`` = 2
        | ``Triangle`` = 3
        | ``L1`` = 4
        | ``R1`` = 5
        | ``L2`` = 6
        | ``R2`` = 7
        | ``Create`` = 8
        | ``Options`` = 9
        | ``L3`` = 10
        | ``R3`` = 11
        | ``DPadUp`` = 12
        | ``DPadDown`` = 13
        | ``DPadLeft`` = 14
        | ``DPadRight`` = 15
        | ``Home`` = 16
        | ``TouchPad`` = 17
        | ``LStickXAxis`` = 18
        | ``LStickYAxis`` = 19
        | ``RStickXAxis`` = 20
        | ``RStickYAxis`` = 21

    /// @babylonjs/core/Gamepads/dualShockGamepad
    type DualShockButton =
        | ``Cross`` = 0
        | ``Circle`` = 1
        | ``Square`` = 2
        | ``Triangle`` = 3
        | ``L1`` = 4
        | ``R1`` = 5
        | ``Share`` = 8
        | ``Options`` = 9
        | ``LeftStick`` = 10
        | ``RightStick`` = 11

    /// @babylonjs/core/Gamepads/dualShockGamepad
    type DualShockDpad =
        | ``Up`` = 12
        | ``Down`` = 13
        | ``Left`` = 14
        | ``Right`` = 15

    /// @babylonjs/core/DeviceInput/InputDevices/deviceEnums
    type DualShockInput =
        | ``Cross`` = 0
        | ``Circle`` = 1
        | ``Square`` = 2
        | ``Triangle`` = 3
        | ``L1`` = 4
        | ``R1`` = 5
        | ``L2`` = 6
        | ``R2`` = 7
        | ``Share`` = 8
        | ``Options`` = 9
        | ``L3`` = 10
        | ``R3`` = 11
        | ``DPadUp`` = 12
        | ``DPadDown`` = 13
        | ``DPadLeft`` = 14
        | ``DPadRight`` = 15
        | ``Home`` = 16
        | ``TouchPad`` = 17
        | ``LStickXAxis`` = 18
        | ``LStickYAxis`` = 19
        | ``RStickXAxis`` = 20
        | ``RStickYAxis`` = 21

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphEasingBlock.pure
    type EasingFunctionType =
        | ``CircleEase`` = 0
        | ``BackEase`` = 1
        | ``BounceEase`` = 2
        | ``CubicEase`` = 3
        | ``ElasticEase`` = 4
        | ``ExponentialEase`` = 5
        | ``PowerEase`` = 6
        | ``QuadraticEase`` = 7
        | ``QuarticEase`` = 8
        | ``QuinticEase`` = 9
        | ``SineEase`` = 10
        | ``BezierCurveEase`` = 11

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    type EBlendingFunction =
        | ``ZERO`` = 0
        | ``ONE`` = 1
        | ``SRC_COLOR`` = 768
        | ``ONE_MINUS_SRC_COLOR`` = 769
        | ``DST_COLOR`` = 774
        | ``ONE_MINUS_DST_COLOR`` = 775
        | ``SRC_ALPHA`` = 770
        | ``ONE_MINUS_SRC_ALPHA`` = 771
        | ``DST_ALPHA`` = 772
        | ``ONE_MINUS_DST_ALPHA`` = 773
        | ``CONSTANT_COLOR`` = 32769
        | ``ONE_MINUS_CONSTANT_COLOR`` = 32770
        | ``CONSTANT_ALPHA`` = 32771
        | ``ONE_MINUS_CONSTANT_ALPHA`` = 32772
        | ``SRC_ALPHA_SATURATE`` = 776

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    type EComponentType =
        | ``BYTE`` = 5120
        | ``UNSIGNED_BYTE`` = 5121
        | ``SHORT`` = 5122
        | ``UNSIGNED_SHORT`` = 5123
        | ``FLOAT`` = 5126

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    type ECullingType =
        | ``FRONT`` = 1028
        | ``BACK`` = 1029
        | ``FRONT_AND_BACK`` = 1032

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    type EngineFormat =
        | ``COMPRESSED_RGBA_BPTC_UNORM_EXT`` = 36492
        | ``COMPRESSED_RGBA_ASTC_4X4_KHR`` = 37808
        | ``COMPRESSED_RGB_S3TC_DXT1_EXT`` = 33776
        | ``COMPRESSED_RGBA_S3TC_DXT5_EXT`` = 33779
        | ``COMPRESSED_RGBA_PVRTC_4BPPV1_IMG`` = 35842
        | ``COMPRESSED_RGB_PVRTC_4BPPV1_IMG`` = 35840
        | ``COMPRESSED_RGBA8_ETC2_EAC`` = 37496
        | ``COMPRESSED_RGB8_ETC2`` = 37492
        | ``COMPRESSED_RGB_ETC1_WEBGL`` = 36196
        | ``RGBA8Format`` = 32856
        | ``R8Format`` = 33321
        | ``RG8Format`` = 33323

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    type EParameterType =
        | ``BYTE`` = 5120
        | ``UNSIGNED_BYTE`` = 5121
        | ``SHORT`` = 5122
        | ``UNSIGNED_SHORT`` = 5123
        | ``INT`` = 5124
        | ``UNSIGNED_INT`` = 5125
        | ``FLOAT`` = 5126
        | ``FLOAT_VEC2`` = 35664
        | ``FLOAT_VEC3`` = 35665
        | ``FLOAT_VEC4`` = 35666
        | ``INT_VEC2`` = 35667
        | ``INT_VEC3`` = 35668
        | ``INT_VEC4`` = 35669
        | ``BOOL`` = 35670
        | ``BOOL_VEC2`` = 35671
        | ``BOOL_VEC3`` = 35672
        | ``BOOL_VEC4`` = 35673
        | ``FLOAT_MAT2`` = 35674
        | ``FLOAT_MAT3`` = 35675
        | ``FLOAT_MAT4`` = 35676
        | ``SAMPLER_2D`` = 35678

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    type EShaderType =
        | ``FRAGMENT`` = 35632
        | ``VERTEX`` = 35633

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    type ETextureFilterType =
        | ``NEAREST`` = 9728
        | ``LINEAR`` = 9728
        | ``NEAREST_MIPMAP_NEAREST`` = 9984
        | ``LINEAR_MIPMAP_NEAREST`` = 9985
        | ``NEAREST_MIPMAP_LINEAR`` = 9986
        | ``LINEAR_MIPMAP_LINEAR`` = 9987

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    type ETextureFormat =
        | ``ALPHA`` = 6406
        | ``RGB`` = 6407
        | ``RGBA`` = 6408
        | ``LUMINANCE`` = 6409
        | ``LUMINANCE_ALPHA`` = 6410

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    type ETextureWrapMode =
        | ``CLAMP_TO_EDGE`` = 33071
        | ``MIRRORED_REPEAT`` = 33648
        | ``REPEAT`` = 10497

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.configuration
    type EXROutputType =
        | ``Float`` = 0
        | ``HalfFloat`` = 1

    /// @babylonjs/core/Meshes/Node/Blocks/extrudeGeometryBlock.pure
    type ExtrudeGeometryCap =
        | ``NoCap`` = 0
        | ``CapStart`` = 1
        | ``CapEnd`` = 2
        | ``CapAll`` = 3

    /// @babylonjs/core/FlowGraph/flowGraphConnection
    type FlowGraphConnectionType =
        | ``Input`` = 0
        | ``Output`` = 1

    /// @babylonjs/core/FlowGraph/flowGraph
    type FlowGraphState =
        | ``Stopped`` = 0
        | ``Started`` = 1
        | ``Paused`` = 2

    /// @babylonjs/core/FlowGraph/flowGraphValidator
    type FlowGraphValidationSeverity =
        | ``Error`` = 0
        | ``Warning`` = 1

    /// @babylonjs/core/Rendering/fluidRenderer/fluidRenderingTargetRenderer
    type FluidRenderingDebug =
        | ``DepthTexture`` = 0
        | ``DepthBlurredTexture`` = 1
        | ``ThicknessTexture`` = 2
        | ``ThicknessBlurredTexture`` = 3
        | ``DiffuseTexture`` = 4
        | ``Normals`` = 5
        | ``DiffuseRendering`` = 6

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/fragmentOutputBlock.pure
    type FragmentOutputBlockColorSpace =
        | ``NoColorSpace`` = 0
        | ``Gamma`` = 1
        | ``Linear`` = 2

    /// @babylonjs/core/Meshes/Node/Blocks/geometryCurveBlock.pure
    type GeometryCurveBlockTypes =
        | ``EaseInSine`` = 0
        | ``EaseOutSine`` = 1
        | ``EaseInOutSine`` = 2
        | ``EaseInQuad`` = 3
        | ``EaseOutQuad`` = 4
        | ``EaseInOutQuad`` = 5
        | ``EaseInCubic`` = 6
        | ``EaseOutCubic`` = 7
        | ``EaseInOutCubic`` = 8
        | ``EaseInQuart`` = 9
        | ``EaseOutQuart`` = 10
        | ``EaseInOutQuart`` = 11
        | ``EaseInQuint`` = 12
        | ``EaseOutQuint`` = 13
        | ``EaseInOutQuint`` = 14
        | ``EaseInExpo`` = 15
        | ``EaseOutExpo`` = 16
        | ``EaseInOutExpo`` = 17
        | ``EaseInCirc`` = 18
        | ``EaseOutCirc`` = 19
        | ``EaseInOutCirc`` = 20
        | ``EaseInBack`` = 21
        | ``EaseOutBack`` = 22
        | ``EaseInOutBack`` = 23
        | ``EaseInElastic`` = 24
        | ``EaseOutElastic`` = 25
        | ``EaseInOutElastic`` = 26

    /// @babylonjs/core/Meshes/Node/Blocks/geometryEaseBlock.pure
    type GeometryEaseBlockTypes =
        | ``EaseInSine`` = 0
        | ``EaseOutSine`` = 1
        | ``EaseInOutSine`` = 2
        | ``EaseInQuad`` = 3
        | ``EaseOutQuad`` = 4
        | ``EaseInOutQuad`` = 5
        | ``EaseInCubic`` = 6
        | ``EaseOutCubic`` = 7
        | ``EaseInOutCubic`` = 8
        | ``EaseInQuart`` = 9
        | ``EaseOutQuart`` = 10
        | ``EaseInOutQuart`` = 11
        | ``EaseInQuint`` = 12
        | ``EaseOutQuint`` = 13
        | ``EaseInOutQuint`` = 14
        | ``EaseInExpo`` = 15
        | ``EaseOutExpo`` = 16
        | ``EaseInOutExpo`` = 17
        | ``EaseInCirc`` = 18
        | ``EaseOutCirc`` = 19
        | ``EaseInOutCirc`` = 20
        | ``EaseInBack`` = 21
        | ``EaseOutBack`` = 22
        | ``EaseInOutBack`` = 23
        | ``EaseInElastic`` = 24
        | ``EaseOutElastic`` = 25
        | ``EaseInOutElastic`` = 26

    /// @babylonjs/core/Materials/materialHelper.geometryrendering
    type GeometryRenderingTextureClearType =
        | ``Zero`` = 0
        | ``One`` = 1
        | ``MaxViewZ`` = 2
        | ``NoClear`` = 3

    /// @babylonjs/core/Meshes/Node/Blocks/geometryTrigonometryBlock.pure
    type GeometryTrigonometryBlockOperations =
        | ``Cos`` = 0
        | ``Sin`` = 1
        | ``Abs`` = 2
        | ``Exp`` = 3
        | ``Round`` = 4
        | ``Floor`` = 5
        | ``Ceiling`` = 6
        | ``Sqrt`` = 7
        | ``Log`` = 8
        | ``Tan`` = 9
        | ``ArcTan`` = 10
        | ``ArcCos`` = 11
        | ``ArcSin`` = 12
        | ``Sign`` = 13
        | ``Negate`` = 14
        | ``OneMinus`` = 15
        | ``Reciprocal`` = 16
        | ``ToDegrees`` = 17
        | ``ToRadians`` = 18
        | ``Fract`` = 19
        | ``Exp2`` = 20

    /// @babylonjs/core/Gizmos/gizmo
    type GizmoAnchorPoint =
        | ``Origin`` = 0
        | ``Pivot`` = 1

    /// @babylonjs/core/Gizmos/gizmo
    type GizmoCoordinatesMode =
        | ``World`` = 0
        | ``Local`` = 1

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    type GLTFLoaderAnimationStartMode =
        | ``NONE`` = 0
        | ``FIRST`` = 1
        | ``ALL`` = 2

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    type GLTFLoaderCoordinateSystemMode =
        | ``AUTO`` = 0
        | ``FORCE_RIGHT_HANDED`` = 1

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    type GLTFLoaderState =
        | ``LOADING`` = 0
        | ``READY`` = 1
        | ``COMPLETE`` = 2

    /// @babylonjs/core/Collisions/gpuPicker
    type GPUMultiPickReadbackStrategy =
        | ``Auto`` = 0
        | ``Rectangle`` = 1
        | ``Individual`` = 2

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    type GreasedLineMeshColorDistribution =
        | ``COLOR_DISTRIBUTION_NONE`` = 0
        | ``COLOR_DISTRIBUTION_REPEAT`` = 1
        | ``COLOR_DISTRIBUTION_EVEN`` = 2
        | ``COLOR_DISTRIBUTION_START`` = 3
        | ``COLOR_DISTRIBUTION_END`` = 4
        | ``COLOR_DISTRIBUTION_START_END`` = 5

    /// @babylonjs/core/Materials/GreasedLine/greasedLineMaterialInterfaces
    type GreasedLineMeshColorDistributionType =
        | ``COLOR_DISTRIBUTION_TYPE_SEGMENT`` = 0
        | ``COLOR_DISTRIBUTION_TYPE_LINE`` = 1

    /// @babylonjs/core/Materials/GreasedLine/greasedLineMaterialInterfaces
    type GreasedLineMeshColorMode =
        | ``COLOR_MODE_SET`` = 0
        | ``COLOR_MODE_ADD`` = 1
        | ``COLOR_MODE_MULTIPLY`` = 2

    /// @babylonjs/core/Materials/GreasedLine/greasedLineMaterialInterfaces
    type GreasedLineMeshMaterialType =
        | ``MATERIAL_TYPE_STANDARD`` = 0
        | ``MATERIAL_TYPE_PBR`` = 1
        | ``MATERIAL_TYPE_SIMPLE`` = 2

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    type GreasedLineMeshWidthDistribution =
        | ``WIDTH_DISTRIBUTION_NONE`` = 0
        | ``WIDTH_DISTRIBUTION_REPEAT`` = 1
        | ``WIDTH_DISTRIBUTION_EVEN`` = 2
        | ``WIDTH_DISTRIBUTION_START`` = 3
        | ``WIDTH_DISTRIBUTION_END`` = 4
        | ``WIDTH_DISTRIBUTION_START_END`` = 5

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineBaseMesh
    type GreasedLineRibbonAutoDirectionMode =
        | ``AUTO_DIRECTIONS_FROM_FIRST_SEGMENT`` = 0
        | ``AUTO_DIRECTIONS_FROM_ALL_SEGMENTS`` = 1
        | ``AUTO_DIRECTIONS_ENHANCED`` = 2
        | ``AUTO_DIRECTIONS_FACE_TO`` = 3
        | ``AUTO_DIRECTIONS_NONE`` = 99

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineBaseMesh
    type GreasedLineRibbonFacesMode =
        | ``FACES_MODE_SINGLE_SIDED`` = 0
        | ``FACES_MODE_SINGLE_SIDED_NO_BACKFACE_CULLING`` = 1
        | ``FACES_MODE_DOUBLE_SIDED`` = 2

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineBaseMesh
    type GreasedLineRibbonPointsMode =
        | ``POINTS_MODE_POINTS`` = 0
        | ``POINTS_MODE_PATHS`` = 1

    /// @babylonjs/core/Behaviors/Meshes/handConstraintBehavior
    type HandConstraintOrientation =
        | ``LOOK_AT_CAMERA`` = 0
        | ``HAND_ROTATION`` = 1

    /// @babylonjs/core/Behaviors/Meshes/handConstraintBehavior
    type HandConstraintVisibility =
        | ``ALWAYS_VISIBLE`` = 0
        | ``PALM_UP`` = 1
        | ``GAZE_FOCUS`` = 2
        | ``PALM_AND_GAZE`` = 3

    /// @babylonjs/core/Behaviors/Meshes/handConstraintBehavior
    type HandConstraintZone =
        | ``ABOVE_FINGER_TIPS`` = 0
        | ``RADIAL_SIDE`` = 1
        | ``ULNAR_SIDE`` = 2
        | ``BELOW_WRIST`` = 3

    /// @babylonjs/core/Misc/iInspectable
    type InspectableType =
        | ``Checkbox`` = 0
        | ``Slider`` = 1
        | ``Vector3`` = 2
        | ``Quaternion`` = 3
        | ``Color3`` = 4
        | ``String`` = 5
        | ``Button`` = 6
        | ``Options`` = 7
        | ``Tab`` = 8
        | ``FileButton`` = 9
        | ``Vector2`` = 10

    /// @babylonjs/core/Materials/Textures/internalTexture
    type InternalTextureSource =
        | ``Unknown`` = 0
        | ``Url`` = 1
        | ``Temp`` = 2
        | ``Raw`` = 3
        | ``Dynamic`` = 4
        | ``RenderTarget`` = 5
        | ``MultiRenderTarget`` = 6
        | ``Cube`` = 7
        | ``CubeRaw`` = 8
        | ``CubePrefiltered`` = 9
        | ``Raw3D`` = 10
        | ``Raw2DArray`` = 11
        | ``DepthStencil`` = 12
        | ``CubeRawRGBD`` = 13
        | ``Depth`` = 14
        | ``External`` = 15

    /// @babylonjs/core/Misc/virtualJoystick
    type JoystickAxis =
        | ``X`` = 0
        | ``Y`` = 1
        | ``Z`` = 2

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    type MapMode =
        | ``Read`` = 1
        | ``Write`` = 2

    /// @babylonjs/core/Meshes/Node/Blocks/mappingBlock.pure
    type MappingTypes =
        | ``Spherical`` = 0
        | ``Cylindrical`` = 1
        | ``Cubic`` = 2

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginEvent =
        | ``Created`` = 1
        | ``Disposed`` = 2
        | ``GetDefineNames`` = 4
        | ``PrepareUniformBuffer`` = 8
        | ``IsReadyForSubMesh`` = 16
        | ``PrepareDefines`` = 32
        | ``BindForSubMesh`` = 64
        | ``PrepareEffect`` = 128
        | ``GetAnimatables`` = 256
        | ``GetActiveTextures`` = 512
        | ``HasTexture`` = 1024
        | ``FillRenderTargetTextures`` = 2048
        | ``HasRenderTargetTextures`` = 4096
        | ``HardBindForSubMesh`` = 8192

    /// @babylonjs/core/Meshes/Node/Blocks/mathBlock.pure
    type MathBlockOperations =
        | ``Add`` = 0
        | ``Subtract`` = 1
        | ``Multiply`` = 2
        | ``Divide`` = 3
        | ``Max`` = 4
        | ``Min`` = 5

    /// @babylonjs/core/Materials/Node/Blocks/meshAttributeExistsBlock.pure
    type MeshAttributeExistsBlockTypes =
        | ``None`` = 0
        | ``Normal`` = 1
        | ``Tangent`` = 2
        | ``VertexColor`` = 3
        | ``UV1`` = 4
        | ``UV2`` = 5
        | ``UV3`` = 6
        | ``UV4`` = 7
        | ``UV5`` = 8
        | ``UV6`` = 9

    /// @babylonjs/core/Materials/meshDebugPluginMaterial.pure
    type MeshDebugMode =
        | ``NONE`` = 0
        | ``TRIANGLES`` = 1
        | ``VERTICES`` = 2
        | ``TRIANGLES_VERTICES`` = 3
        | ``UV0`` = 4
        | ``UV1`` = 5
        | ``VERTEXCOLORS`` = 6
        | ``MATERIALIDS`` = 7

    /// @babylonjs/core/DeviceInput/InputDevices/deviceEnums
    type NativePointerInput =
        | ``Horizontal`` = 0
        | ``Vertical`` = 1
        | ``LeftClick`` = 2
        | ``MiddleClick`` = 3
        | ``RightClick`` = 4
        | ``BrowserBack`` = 5
        | ``BrowserForward`` = 6
        | ``MouseWheelX`` = 7
        | ``MouseWheelY`` = 8
        | ``MouseWheelZ`` = 9
        | ``DeltaHorizontal`` = 10
        | ``DeltaVertical`` = 11

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeTraceLevel =
        | ``Mark`` = 1
        | ``Log`` = 2

    /// @babylonjs/core/Meshes/Node/Enums/nodeGeometryConnectionPointTypes
    type NodeGeometryBlockConnectionPointTypes =
        | ``Int`` = 1
        | ``Float`` = 2
        | ``Vector2`` = 4
        | ``Vector3`` = 8
        | ``Vector4`` = 16
        | ``Matrix`` = 32
        | ``Geometry`` = 64
        | ``Texture`` = 128
        | ``AutoDetect`` = 1024
        | ``BasedOnInput`` = 2048
        | ``Undefined`` = 4096
        | ``All`` = 4095

    /// @babylonjs/core/Meshes/Node/nodeGeometryBlockConnectionPoint
    type NodeGeometryConnectionPointCompatibilityStates =
        | ``Compatible`` = 0
        | ``TypeIncompatible`` = 1
        | ``HierarchyIssue`` = 2

    /// @babylonjs/core/Meshes/Node/nodeGeometryBlockConnectionPoint
    type NodeGeometryConnectionPointDirection =
        | ``Input`` = 0
        | ``Output`` = 1

    /// @babylonjs/core/Meshes/Node/Enums/nodeGeometryContextualSources
    type NodeGeometryContextualSources =
        | ``None`` = 0
        | ``Positions`` = 1
        | ``Normals`` = 2
        | ``Tangents`` = 3
        | ``UV`` = 4
        | ``UV2`` = 5
        | ``UV3`` = 6
        | ``UV4`` = 7
        | ``UV5`` = 8
        | ``UV6`` = 9
        | ``Colors`` = 10
        | ``VertexID`` = 11
        | ``FaceID`` = 12
        | ``GeometryID`` = 13
        | ``CollectionID`` = 14
        | ``LoopID`` = 15
        | ``InstanceID`` = 16
        | ``LatticeID`` = 17
        | ``LatticeControl`` = 18

    /// @babylonjs/core/Materials/Node/Enums/nodeMaterialBlockConnectionPointMode
    type NodeMaterialBlockConnectionPointMode =
        | ``Uniform`` = 0
        | ``Attribute`` = 1
        | ``Varying`` = 2
        | ``Undefined`` = 3

    /// @babylonjs/core/Materials/Node/Enums/nodeMaterialBlockConnectionPointTypes
    type NodeMaterialBlockConnectionPointTypes =
        | ``Float`` = 1
        | ``Int`` = 2
        | ``Vector2`` = 4
        | ``Vector3`` = 8
        | ``Vector4`` = 16
        | ``Color3`` = 32
        | ``Color4`` = 64
        | ``Matrix`` = 128
        | ``Object`` = 256
        | ``AutoDetect`` = 1024
        | ``BasedOnInput`` = 2048
        | ``All`` = 4095

    /// @babylonjs/core/Materials/Node/Enums/nodeMaterialBlockTargets
    type NodeMaterialBlockTargets =
        | ``Vertex`` = 1
        | ``Fragment`` = 2
        | ``Neutral`` = 4
        | ``VertexAndFragment`` = 3

    /// @babylonjs/core/Materials/Node/nodeMaterialBlockConnectionPoint
    type NodeMaterialConnectionPointCompatibilityStates =
        | ``Compatible`` = 0
        | ``TypeIncompatible`` = 1
        | ``TargetIncompatible`` = 2
        | ``HierarchyIssue`` = 3

    /// @babylonjs/core/Materials/Node/nodeMaterialBlockConnectionPoint
    type NodeMaterialConnectionPointDirection =
        | ``Input`` = 0
        | ``Output`` = 1

    /// @babylonjs/core/Materials/Node/Enums/nodeMaterialModes
    type NodeMaterialModes =
        | ``Material`` = 0
        | ``PostProcess`` = 1
        | ``Particle`` = 2
        | ``ProceduralTexture`` = 3
        | ``GaussianSplatting`` = 4
        | ``SFE`` = 5

    /// @babylonjs/core/Materials/Node/Enums/nodeMaterialSystemValues
    type NodeMaterialSystemValues =
        | ``World`` = 1
        | ``View`` = 2
        | ``Projection`` = 3
        | ``ViewProjection`` = 4
        | ``WorldView`` = 5
        | ``WorldViewProjection`` = 6
        | ``CameraPosition`` = 7
        | ``FogColor`` = 8
        | ``DeltaTime`` = 9
        | ``CameraParameters`` = 10
        | ``MaterialAlpha`` = 11
        | ``ProjectionInverse`` = 12
        | ``CameraForward`` = 13

    /// @babylonjs/core/Particles/Node/Enums/nodeParticleBlockConnectionPointTypes
    type NodeParticleBlockConnectionPointTypes =
        | ``Int`` = 1
        | ``Float`` = 2
        | ``Vector2`` = 4
        | ``Vector3`` = 8
        | ``Matrix`` = 16
        | ``Particle`` = 32
        | ``Texture`` = 64
        | ``Color4`` = 128
        | ``FloatGradient`` = 256
        | ``Vector2Gradient`` = 512
        | ``Vector3Gradient`` = 1024
        | ``Color4Gradient`` = 2048
        | ``System`` = 4096
        | ``AutoDetect`` = 8192
        | ``BasedOnInput`` = 16384
        | ``Undefined`` = 32768
        | ``All`` = 65535

    /// @babylonjs/core/Particles/Node/nodeParticleBlockConnectionPoint
    type NodeParticleConnectionPointCompatibilityStates =
        | ``Compatible`` = 0
        | ``TypeIncompatible`` = 1
        | ``HierarchyIssue`` = 2

    /// @babylonjs/core/Particles/Node/nodeParticleBlockConnectionPoint
    type NodeParticleConnectionPointDirection =
        | ``Input`` = 0
        | ``Output`` = 1

    /// @babylonjs/core/Particles/Node/Enums/nodeParticleContextualSources
    type NodeParticleContextualSources =
        | ``None`` = 0
        | ``Position`` = 1
        | ``Direction`` = 2
        | ``Age`` = 3
        | ``Lifetime`` = 4
        | ``Color`` = 5
        | ``ScaledDirection`` = 6
        | ``Scale`` = 7
        | ``AgeGradient`` = 8
        | ``Angle`` = 9
        | ``SpriteCellIndex`` = 16
        | ``SpriteCellStart`` = 17
        | ``SpriteCellEnd`` = 18
        | ``InitialColor`` = 19
        | ``ColorDead`` = 20
        | ``InitialDirection`` = 21
        | ``ColorStep`` = 22
        | ``ScaledColorStep`` = 23
        | ``LocalPositionUpdated`` = 24
        | ``Size`` = 25
        | ``DirectionScale`` = 32

    /// @babylonjs/core/Particles/Node/Enums/nodeParticleSystemSources
    type NodeParticleSystemSources =
        | ``None`` = 0
        | ``Time`` = 1
        | ``Delta`` = 2
        | ``Emitter`` = 3
        | ``CameraPosition`` = 4

    /// @babylonjs/core/FrameGraph/Node/Types/nodeRenderGraphTypes
    type NodeRenderGraphBlockConnectionPointTypes =
        | ``Texture`` = 1u
        | ``TextureBackBuffer`` = 2u
        | ``TextureBackBufferDepthStencilAttachment`` = 4u
        | ``TextureDepthStencilAttachment`` = 8u
        | ``TextureViewDepth`` = 16u
        | ``TextureViewNormal`` = 32u
        | ``TextureAlbedo`` = 64u
        | ``TextureReflectivity`` = 128u
        | ``TextureWorldPosition`` = 256u
        | ``TextureVelocity`` = 512u
        | ``TextureIrradiance`` = 1024u
        | ``TextureAlbedoSqrt`` = 2048u
        | ``TextureScreenDepth`` = 4096u
        | ``TextureWorldNormal`` = 8192u
        | ``TextureLocalPosition`` = 16384u
        | ``TextureLinearVelocity`` = 32768u
        | ``TextureNormalizedViewDepth`` = 65536u
        | ``TextureAllButBackBufferDepthStencil`` = 1048571u
        | ``TextureAllButBackBuffer`` = 1048569u
        | ``TextureAll`` = 1048575u
        | ``ResourceContainer`` = 1048576u
        | ``ShadowGenerator`` = 2097152u
        | ``ShadowLight`` = 4194304u
        | ``Camera`` = 16777216u
        | ``ObjectList`` = 33554432u
        | ``AutoDetect`` = 268435456u
        | ``BasedOnInput`` = 536870912u
        | ``Undefined`` = 1073741824u
        | ``Object`` = 2147483648u
        | ``All`` = 4294967295u

    /// @babylonjs/core/FrameGraph/Node/Types/nodeRenderGraphTypes
    type NodeRenderGraphConnectionPointCompatibilityStates =
        | ``Compatible`` = 0
        | ``TypeIncompatible`` = 1
        | ``HierarchyIssue`` = 2

    /// @babylonjs/core/FrameGraph/Node/Types/nodeRenderGraphTypes
    type NodeRenderGraphConnectionPointDirection =
        | ``Input`` = 0
        | ``Output`` = 1

    /// @babylonjs/core/Maths/math.path
    type Orientation =
        | ``CW`` = 0
        | ``CCW`` = 1

    /// @babylonjs/core/Particles/Node/Blocks/Conditions/particleConditionBlock.pure
    type ParticleConditionBlockTests =
        | ``Equal`` = 0
        | ``NotEqual`` = 1
        | ``LessThan`` = 2
        | ``GreaterThan`` = 3
        | ``LessOrEqual`` = 4
        | ``GreaterOrEqual`` = 5
        | ``Xor`` = 6
        | ``Or`` = 7
        | ``And`` = 8

    /// @babylonjs/core/Particles/Node/Blocks/particleFloatToIntBlock.pure
    type ParticleFloatToIntBlockOperations =
        | ``Round`` = 0
        | ``Ceil`` = 1
        | ``Floor`` = 2
        | ``Truncate`` = 3

    /// @babylonjs/core/Particles/Node/Blocks/particleLocalVariableBlock.pure
    type ParticleLocalVariableBlockScope =
        | ``Particle`` = 0
        | ``Loop`` = 1

    /// @babylonjs/core/Particles/Node/Blocks/particleMathBlock.pure
    type ParticleMathBlockOperations =
        | ``Add`` = 0
        | ``Subtract`` = 1
        | ``Multiply`` = 2
        | ``Divide`` = 3
        | ``Max`` = 4
        | ``Min`` = 5

    /// @babylonjs/core/Particles/Node/Blocks/particleNumberMathBlock.pure
    type ParticleNumberMathBlockOperations =
        | ``Modulo`` = 0
        | ``Pow`` = 1

    /// @babylonjs/core/Particles/Node/Blocks/particleRandomBlock.pure
    type ParticleRandomBlockLocks =
        | ``None`` = 0
        | ``PerParticle`` = 1
        | ``PerSystem`` = 2
        | ``OncePerParticle`` = 3

    /// @babylonjs/core/Particles/Node/Blocks/particleTrigonometryBlock.pure
    type ParticleTrigonometryBlockOperations =
        | ``Cos`` = 0
        | ``Sin`` = 1
        | ``Abs`` = 2
        | ``Exp`` = 3
        | ``Exp2`` = 4
        | ``Round`` = 5
        | ``Floor`` = 6
        | ``Ceiling`` = 7
        | ``Sqrt`` = 8
        | ``Log`` = 9
        | ``Tan`` = 10
        | ``ArcTan`` = 11
        | ``ArcCos`` = 12
        | ``ArcSin`` = 13
        | ``Sign`` = 14
        | ``Negate`` = 15
        | ``OneMinus`` = 16
        | ``Reciprocal`` = 17
        | ``ToDegrees`` = 18
        | ``ToRadians`` = 19
        | ``Fract`` = 20

    /// @babylonjs/core/Particles/Node/Blocks/particleVectorMathBlock.pure
    type ParticleVectorMathBlockOperations =
        | ``Dot`` = 0
        | ``Distance`` = 1

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type PhysicsActivationControl =
        | ``SIMULATION_CONTROLLED`` = 0
        | ``ALWAYS_ACTIVE`` = 1
        | ``ALWAYS_INACTIVE`` = 2

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type PhysicsConstraintAxis =
        | ``LINEAR_X`` = 0
        | ``LINEAR_Y`` = 1
        | ``LINEAR_Z`` = 2
        | ``ANGULAR_X`` = 3
        | ``ANGULAR_Y`` = 4
        | ``ANGULAR_Z`` = 5
        | ``LINEAR_DISTANCE`` = 6

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type PhysicsConstraintAxisLimitMode =
        | ``FREE`` = 0
        | ``LIMITED`` = 1
        | ``LOCKED`` = 2

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type PhysicsConstraintMotorType =
        | ``NONE`` = 0
        | ``VELOCITY`` = 1
        | ``POSITION`` = 2

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type PhysicsConstraintType =
        | ``BALL_AND_SOCKET`` = 1
        | ``DISTANCE`` = 2
        | ``HINGE`` = 3
        | ``SLIDER`` = 4
        | ``LOCK`` = 5
        | ``PRISMATIC`` = 6
        | ``SIX_DOF`` = 7

    /// @babylonjs/core/Physics/v2/physicsMaterial
    type PhysicsMaterialCombineMode =
        | ``GEOMETRIC_MEAN`` = 0
        | ``MINIMUM`` = 1
        | ``MAXIMUM`` = 2
        | ``ARITHMETIC_MEAN`` = 3
        | ``MULTIPLY`` = 4

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type PhysicsMotionType =
        | ``STATIC`` = 0
        | ``ANIMATED`` = 1
        | ``DYNAMIC`` = 2

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type PhysicsPrestepType =
        | ``DISABLED`` = 0
        | ``TELEPORT`` = 1
        | ``ACTION`` = 2

    /// @babylonjs/core/Physics/physicsHelper
    type PhysicsRadialImpulseFalloff =
        | ``Constant`` = 0
        | ``Linear`` = 1

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type PhysicsShapeType =
        | ``SPHERE`` = 0
        | ``CAPSULE`` = 1
        | ``CYLINDER`` = 2
        | ``BOX`` = 3
        | ``CONVEX_HULL`` = 4
        | ``CONTAINER`` = 5
        | ``MESH`` = 6
        | ``HEIGHTFIELD`` = 7

    /// @babylonjs/core/Physics/physicsHelper
    type PhysicsUpdraftMode =
        | ``Center`` = 0
        | ``Perpendicular`` = 1

    /// @babylonjs/core/Particles/pointsCloudSystem
    type PointColor =
        | ``Color`` = 2
        | ``UV`` = 1
        | ``Random`` = 0
        | ``Stated`` = 3

    /// @babylonjs/core/DeviceInput/InputDevices/deviceEnums
    type PointerInput =
        | ``Horizontal`` = 0
        | ``Vertical`` = 1
        | ``LeftClick`` = 2
        | ``MiddleClick`` = 3
        | ``RightClick`` = 4
        | ``BrowserBack`` = 5
        | ``BrowserForward`` = 6
        | ``MouseWheelX`` = 7
        | ``MouseWheelY`` = 8
        | ``MouseWheelZ`` = 9
        | ``Move`` = 12

    /// @babylonjs/core/Decorators/nodeDecorator
    type PropertyTypeForEdition =
        | ``Boolean`` = 0
        | ``Float`` = 1
        | ``Int`` = 2
        | ``Vector2`` = 3
        | ``Vector3`` = 4
        | ``List`` = 5
        | ``Color3`` = 6
        | ``Color4`` = 7
        | ``SamplingMode`` = 8
        | ``TextureFormat`` = 9
        | ``TextureType`` = 10
        | ``String`` = 11
        | ``Matrix`` = 12
        | ``Viewport`` = 13

    /// @babylonjs/core/Meshes/Node/Blocks/randomBlock.pure
    type RandomBlockLocks =
        | ``None`` = 0
        | ``LoopID`` = 1
        | ``InstanceID`` = 2
        | ``Once`` = 3

    /// @babylonjs/core/Loading/sceneLoader
    type SceneLoaderAnimationGroupLoadingMode =
        | ``Clean`` = 0
        | ``Stop`` = 1
        | ``Sync`` = 2
        | ``NoSync`` = 3

    /// @babylonjs/core/scene.pure
    type ScenePerformancePriority =
        | ``BackwardCompatible`` = 0
        | ``Intermediate`` = 1
        | ``Aggressive`` = 2

    /// @babylonjs/core/Materials/shaderLanguage
    type ShaderLanguage =
        | ``GLSL`` = 0
        | ``WGSL`` = 1

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    type ShaderStage =
        | ``Vertex`` = 1
        | ``Fragment`` = 2
        | ``Compute`` = 4

    /// @babylonjs/core/Meshes/meshSimplification.common
    type SimplificationType =
        | ``QUADRATIC`` = 0

    /// @babylonjs/core/AudioV2/soundState
    type SoundState =
        | ``Stopping`` = 0
        | ``Stopped`` = 1
        | ``Starting`` = 2
        | ``Started`` = 3
        | ``FailedToStart`` = 4
        | ``Paused`` = 5

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    type SourceTextureFormat =
        | ``ETC1S`` = 0
        | ``UASTC4x4`` = 1
        | ``RGBA32`` = 2

    /// @babylonjs/core/Maths/math.axis
    type Space =
        | ``LOCAL`` = 0
        | ``WORLD`` = 1
        | ``BONE`` = 2

    /// @babylonjs/core/AudioV2/spatialAudioAttachmentType
    type SpatialAudioAttachmentType =
        | ``Position`` = 1
        | ``Rotation`` = 2
        | ``PositionAndRotation`` = 3

    /// @babylonjs/core/Sprites/spriteMap.pure
    type SpriteMapFrameRotationDirection =
        | ``CCW`` = 0
        | ``CW`` = 1

    /// @babylonjs/core/Particles/subEmitter
    type SubEmitterType =
        | ``ATTACHED`` = 0
        | ``END`` = 1

    /// @babylonjs/core/DeviceInput/InputDevices/deviceEnums
    type SwitchInput =
        | ``B`` = 0
        | ``A`` = 1
        | ``Y`` = 2
        | ``X`` = 3
        | ``L`` = 4
        | ``R`` = 5
        | ``ZL`` = 6
        | ``ZR`` = 7
        | ``Minus`` = 8
        | ``Plus`` = 9
        | ``LS`` = 10
        | ``RS`` = 11
        | ``DPadUp`` = 12
        | ``DPadDown`` = 13
        | ``DPadLeft`` = 14
        | ``DPadRight`` = 15
        | ``Home`` = 16
        | ``Capture`` = 17
        | ``LStickXAxis`` = 18
        | ``LStickYAxis`` = 19
        | ``RStickXAxis`` = 20
        | ``RStickYAxis`` = 21

    /// @babylonjs/core/Materials/Textures/textureProcessor
    type TextureChannel =
        | ``RGBA`` = 0
        | ``R`` = 1
        | ``G`` = 2
        | ``B`` = 3
        | ``A`` = 4

    /// @babylonjs/core/Materials/Textures/textureProcessor
    type TextureColorSpace =
        | ``Linear`` = 0
        | ``SRGB`` = 1

    /// @babylonjs/core/Engines/WebGPU/webgpuConstants
    type TextureUsage =
        | ``CopySrc`` = 1
        | ``CopyDst`` = 2
        | ``TextureBinding`` = 4
        | ``StorageBinding`` = 8
        | ``RenderAttachment`` = 16
        | ``TransientAttachment`` = 32

    /// @babylonjs/core/PostProcesses/thinDepthOfFieldEffect
    type ThinDepthOfFieldEffectBlurLevel =
        | ``Low`` = 0
        | ``Medium`` = 1
        | ``High`` = 2

    /// @babylonjs/core/Misc/timer
    type TimerState =
        | ``INIT`` = 0
        | ``STARTED`` = 1
        | ``ENDED`` = 2

    /// @babylonjs/core/PostProcesses/thinTonemapPostProcess
    type TonemappingOperator =
        | ``Hable`` = 0
        | ``Reinhard`` = 1
        | ``HejiDawson`` = 2
        | ``Photographic`` = 3

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    type TranscodeTarget =
        | ``ASTC_4X4_RGBA`` = 0
        | ``ASTC_4x4_RGBA`` = 0
        | ``BC7_RGBA`` = 1
        | ``BC3_RGBA`` = 2
        | ``BC1_RGB`` = 3
        | ``PVRTC1_4_RGBA`` = 4
        | ``PVRTC1_4_RGB`` = 5
        | ``ETC2_RGBA`` = 6
        | ``ETC1_RGB`` = 7
        | ``RGBA32`` = 8
        | ``R8`` = 9
        | ``RG8`` = 10

    /// @babylonjs/core/Materials/Node/Blocks/trigonometryBlock.pure
    type TrigonometryBlockOperations =
        | ``Cos`` = 0
        | ``Sin`` = 1
        | ``Abs`` = 2
        | ``Exp`` = 3
        | ``Exp2`` = 4
        | ``Round`` = 5
        | ``Floor`` = 6
        | ``Ceiling`` = 7
        | ``Sqrt`` = 8
        | ``Log`` = 9
        | ``Tan`` = 10
        | ``ArcTan`` = 11
        | ``ArcCos`` = 12
        | ``ArcSin`` = 13
        | ``Fract`` = 14
        | ``Sign`` = 15
        | ``Radians`` = 16
        | ``Degrees`` = 17
        | ``Set`` = 18

    /// @babylonjs/core/Materials/Node/Blocks/waveBlock.pure
    type WaveBlockKind =
        | ``SawTooth`` = 0
        | ``Square`` = 1
        | ``Triangle`` = 2

    /// @babylonjs/core/XR/webXRGraphicsBinding
    type WebXRGraphicsBindingType =
        | ``WebGL`` = 0
        | ``WebGPU`` = 1

    /// @babylonjs/core/XR/features/WebXRNearInteraction.pure
    type WebXRNearControllerMode =
        | ``DISABLED`` = 0
        | ``CENTERED_ON_CONTROLLER`` = 1
        | ``CENTERED_IN_FRONT`` = 2

    /// @babylonjs/core/XR/webXRTypes
    type WebXRState =
        | ``ENTERING_XR`` = 0
        | ``EXITING_XR`` = 1
        | ``IN_XR`` = 2
        | ``NOT_IN_XR`` = 3

    /// @babylonjs/core/XR/webXRTypes
    type WebXRTrackingState =
        | ``NOT_TRACKING`` = 0
        | ``TRACKING_LOST`` = 1
        | ``TRACKING`` = 2

    /// @babylonjs/core/Gamepads/xboxGamepad
    type Xbox360Button =
        | ``A`` = 0
        | ``B`` = 1
        | ``X`` = 2
        | ``Y`` = 3
        | ``LB`` = 4
        | ``RB`` = 5
        | ``Back`` = 8
        | ``Start`` = 9
        | ``LeftStick`` = 10
        | ``RightStick`` = 11

    /// @babylonjs/core/Gamepads/xboxGamepad
    type Xbox360Dpad =
        | ``Up`` = 12
        | ``Down`` = 13
        | ``Left`` = 14
        | ``Right`` = 15

    /// @babylonjs/core/DeviceInput/InputDevices/deviceEnums
    type XboxInput =
        | ``A`` = 0
        | ``B`` = 1
        | ``X`` = 2
        | ``Y`` = 3
        | ``LB`` = 4
        | ``RB`` = 5
        | ``LT`` = 6
        | ``RT`` = 7
        | ``Back`` = 8
        | ``Start`` = 9
        | ``LS`` = 10
        | ``RS`` = 11
        | ``DPadUp`` = 12
        | ``DPadDown`` = 13
        | ``DPadLeft`` = 14
        | ``DPadRight`` = 15
        | ``Home`` = 16
        | ``LStickXAxis`` = 17
        | ``LStickYAxis`` = 18
        | ``RStickXAxis`` = 19
        | ``RStickYAxis`` = 20
