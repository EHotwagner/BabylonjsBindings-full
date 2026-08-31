// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after alias review, compile, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact primitive aliases and dependency-free callbacks exported by Babylon.js 9.19.0.
module TypeAliases =

    /// Phantom structural witness for TypeScript Function constraints.
    [<AllowNullLiteral>]
    type JavaScriptFunction =
        interface end

    /// Exact Symbol.toStringTag literal exposed by SharedArrayBuffer.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserSharedArrayBufferTag =
        | [<CompiledName("SharedArrayBuffer")>] SharedArrayBuffer

    /// Phantom structural witness for NodeRenderGraphValueType generic constraints.
    [<AllowNullLiteral>]
    type NodeRenderGraphValue =
        interface end

    /// Exact ESNext SharedArrayBuffer instance surface used by ArrayBufferLike declarations.
    [<AllowNullLiteral>]
    type BrowserSharedArrayBuffer =
        abstract byteLength: float with get
        abstract growable: bool with get
        abstract maxByteLength: float with get
        abstract slice: ?beginIndex: float * ?endIndex: float -> BrowserSharedArrayBuffer
        abstract grow: ?newByteLength: float -> unit
        [<Emit("$0[Symbol.toStringTag]")>] abstract toStringTag: BrowserSharedArrayBufferTag with get

    /// Yield branch returned by a Babylon coroutine iterator.
    [<AllowNullLiteral>]
    type CoroutineInternalYieldResult =
        abstract ``done``: bool option with get
        abstract value: unit with get

    /// Completion branch returned by a Babylon coroutine iterator.
    [<AllowNullLiteral>]
    type CoroutineInternalReturnResult<'T> =
        abstract ``done``: bool with get
        abstract value: 'T with get

    /// Exact IteratorResult<void, T> union returned by a Babylon coroutine.
    type CoroutineInternalResult<'T> = U2<CoroutineInternalYieldResult, CoroutineInternalReturnResult<'T>>

    /// Exact string literal type for "cylinder".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral05fa0965c7c3 =
        | [<CompiledName("cylinder")>] Value

    /// Exact string literal type for "box".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral26f8567f2569 =
        | [<CompiledName("box")>] Value

    /// Exact internal numeric enum required by an exported Babylon alias.
    type AliasEnum150995365430 =
        | ``FLOAT`` = 0
        | ``INT`` = 1
        | ``UINT`` = 2
        | ``DOUBLE`` = 3
        | ``UCHAR`` = 4
        | ``UNDEFINED`` = 5

    /// Exact internal numeric enum required by an exported Babylon alias.
    type AliasEnum6bfd9a7c2404 =
        | ``MIN_X`` = 0
        | ``MIN_Y`` = 1
        | ``MIN_Z`` = 2
        | ``MAX_X`` = 3
        | ``MAX_Y`` = 4
        | ``MAX_Z`` = 5
        | ``MIN_SCALE_X`` = 6
        | ``MIN_SCALE_Y`` = 7
        | ``MIN_SCALE_Z`` = 8
        | ``MAX_SCALE_X`` = 9
        | ``MAX_SCALE_Y`` = 10
        | ``MAX_SCALE_Z`` = 11
        | ``PACKED_POSITION`` = 12
        | ``PACKED_ROTATION`` = 13
        | ``PACKED_SCALE`` = 14
        | ``PACKED_COLOR`` = 15
        | ``X`` = 16
        | ``Y`` = 17
        | ``Z`` = 18
        | ``SCALE_0`` = 19
        | ``SCALE_1`` = 20
        | ``SCALE_2`` = 21
        | ``DIFFUSE_RED`` = 22
        | ``DIFFUSE_GREEN`` = 23
        | ``DIFFUSE_BLUE`` = 24
        | ``OPACITY`` = 25
        | ``F_DC_0`` = 26
        | ``F_DC_1`` = 27
        | ``F_DC_2`` = 28
        | ``F_DC_3`` = 29
        | ``ROT_0`` = 30
        | ``ROT_1`` = 31
        | ``ROT_2`` = 32
        | ``ROT_3`` = 33
        | ``MIN_COLOR_R`` = 34
        | ``MIN_COLOR_G`` = 35
        | ``MIN_COLOR_B`` = 36
        | ``MAX_COLOR_R`` = 37
        | ``MAX_COLOR_G`` = 38
        | ``MAX_COLOR_B`` = 39
        | ``SH_0`` = 40
        | ``SH_1`` = 41
        | ``SH_2`` = 42
        | ``SH_3`` = 43
        | ``SH_4`` = 44
        | ``SH_5`` = 45
        | ``SH_6`` = 46
        | ``SH_7`` = 47
        | ``SH_8`` = 48
        | ``SH_9`` = 49
        | ``SH_10`` = 50
        | ``SH_11`` = 51
        | ``SH_12`` = 52
        | ``SH_13`` = 53
        | ``SH_14`` = 54
        | ``SH_15`` = 55
        | ``SH_16`` = 56
        | ``SH_17`` = 57
        | ``SH_18`` = 58
        | ``SH_19`` = 59
        | ``SH_20`` = 60
        | ``SH_21`` = 61
        | ``SH_22`` = 62
        | ``SH_23`` = 63
        | ``SH_24`` = 64
        | ``SH_25`` = 65
        | ``SH_26`` = 66
        | ``SH_27`` = 67
        | ``SH_28`` = 68
        | ``SH_29`` = 69
        | ``SH_30`` = 70
        | ``SH_31`` = 71
        | ``SH_32`` = 72
        | ``SH_33`` = 73
        | ``SH_34`` = 74
        | ``SH_35`` = 75
        | ``SH_36`` = 76
        | ``SH_37`` = 77
        | ``SH_38`` = 78
        | ``SH_39`` = 79
        | ``SH_40`` = 80
        | ``SH_41`` = 81
        | ``SH_42`` = 82
        | ``SH_43`` = 83
        | ``SH_44`` = 84
        | ``SH_45`` = 85
        | ``SH_46`` = 86
        | ``SH_47`` = 87
        | ``SH_48`` = 88
        | ``SH_49`` = 89
        | ``SH_50`` = 90
        | ``SH_51`` = 91
        | ``SH_52`` = 92
        | ``SH_53`` = 93
        | ``SH_54`` = 94
        | ``SH_55`` = 95
        | ``SH_56`` = 96
        | ``SH_57`` = 97
        | ``SH_58`` = 98
        | ``SH_59`` = 99
        | ``SH_60`` = 100
        | ``SH_61`` = 101
        | ``SH_62`` = 102
        | ``SH_63`` = 103
        | ``SH_64`` = 104
        | ``SH_65`` = 105
        | ``SH_66`` = 106
        | ``SH_67`` = 107
        | ``SH_68`` = 108
        | ``SH_69`` = 109
        | ``SH_70`` = 110
        | ``SH_71`` = 111
        | ``UNDEFINED`` = 112

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectde9f6c1b6b0f =
        abstract ``width``: System.Double with get, set
        abstract ``height``: System.Double with get, set
        abstract ``depth``: System.Double option with get, set
        abstract ``layers``: System.Double option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject38fb0477dfc1 =
        abstract ``mergeRuntimeAnimations``: BabylonjsBindings.SimpleInterfaces.BrowserFalse with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectc2a40b3b5670 =
        abstract ``mergeRuntimeAnimations``: BabylonjsBindings.SimpleInterfaces.BrowserTrue with get, set
        abstract ``mergeKeyFrames``: bool with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type PartialAliasObject38fb0477dfc1 =
        abstract ``mergeRuntimeAnimations``: BabylonjsBindings.SimpleInterfaces.BrowserFalse option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type PartialAliasObjectc2a40b3b5670 =
        abstract ``mergeRuntimeAnimations``: BabylonjsBindings.SimpleInterfaces.BrowserTrue option with get, set
        abstract ``mergeKeyFrames``: bool option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject38742680c103 =
        abstract ``width``: System.Double with get, set
        abstract ``height``: System.Double with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject6772b28860e6 =
        abstract ``processCodeAfterIncludes``: System.Func<string, string, string, string> option with get, set
        abstract ``processFinalCode``: System.Func<string, string, string, string> option with get, set
        abstract ``defineCustomBindings``: System.Func<string, string option, ResizeArray<string>, ResizeArray<string>, string option> option with get, set
        abstract ``bindCustomBindings``: System.Action<string, BabylonjsBindings.SimpleClasses.Effect> option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectdb70335810f5 =
        abstract ``planetRadius``: System.Double with get, set
        abstract ``pickPredicate``: BabylonjsBindings.TypeAliases.MeshPredicate option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject8a8f0eb7b989 =
        abstract ``delta``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``dragPlanePoint``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``dragPlaneNormal``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``dragDistance``: System.Double with get, set
        abstract ``pointerId``: System.Double with get, set
        abstract ``pointerInfo``: BabylonjsBindings.SimpleClasses.PointerInfo option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type PickObject26759efc7574 =
        abstract ``dragPlanePoint``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``pointerId``: System.Double with get, set
        abstract ``pointerInfo``: BabylonjsBindings.SimpleClasses.PointerInfo option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject4d81806d37f7 =
        [<EmitIndexer>] abstract Item: ``key``: BabylonjsBindings.StringEnums.WebXRBodyJoint -> string option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectc11d826e4a3c =
        abstract ``movementEnabled``: bool with get, set
        abstract ``movementOrientationFollowsViewerPose``: bool with get, set
        abstract ``movementOrientationFollowsController``: bool with get, set
        abstract ``orientationPreferredHandedness``: BabylonjsBindings.SimpleInterfaces.BrowserXRHandedness option with get, set
        abstract ``movementSpeed``: System.Double with get, set
        abstract ``movementThreshold``: System.Double with get, set
        abstract ``rotationEnabled``: bool with get, set
        abstract ``rotationSpeed``: System.Double with get, set
        abstract ``rotationThreshold``: System.Double with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject2d7882d93505 =
        abstract ``allowedComponentTypes``: ResizeArray<BabylonjsBindings.StringEnums.MotionControllerComponentType> option with get, set
        abstract ``forceHandedness``: BabylonjsBindings.SimpleInterfaces.BrowserXRHandedness option with get, set
        abstract ``mainComponentOnly``: bool option with get, set
        abstract ``componentSelectionPredicate``: System.Func<BabylonjsBindings.SimpleClasses.WebXRInputSource, BabylonjsBindings.SimpleClasses.WebXRControllerComponent option> option with get, set
        abstract ``axisChangedHandler``: System.Action<BabylonjsBindings.SimpleInterfaces.IWebXRMotionControllerAxesValue, BabylonjsBindings.ObjectTypes.WebXRControllerMovementState, BabylonjsBindings.TypeAliases.WebXRControllerMovementFeatureContext, BabylonjsBindings.SimpleClasses.WebXRInput> with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject406c176bc0c4 =
        abstract ``allowedComponentTypes``: ResizeArray<BabylonjsBindings.StringEnums.MotionControllerComponentType> option with get, set
        abstract ``forceHandedness``: BabylonjsBindings.SimpleInterfaces.BrowserXRHandedness option with get, set
        abstract ``mainComponentOnly``: bool option with get, set
        abstract ``componentSelectionPredicate``: System.Func<BabylonjsBindings.SimpleClasses.WebXRInputSource, BabylonjsBindings.SimpleClasses.WebXRControllerComponent option> option with get, set
        abstract ``buttonChangedHandler``: System.Action<BabylonjsBindings.SimpleInterfaces.IWebXRMotionControllerComponentChangesValues<bool>, BabylonjsBindings.ObjectTypes.WebXRControllerMovementState, BabylonjsBindings.TypeAliases.WebXRControllerMovementFeatureContext, BabylonjsBindings.SimpleClasses.WebXRInput> with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectf8c432911558 =
        abstract ``parentBody``: BabylonjsBindings.SimpleClasses.PhysicsBody with get, set
        abstract ``parentBodyIndex``: System.Double with get, set
        abstract ``childBody``: BabylonjsBindings.SimpleClasses.PhysicsBody with get, set
        abstract ``childBodyIndex``: System.Double with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectfe6bed7521ea =
        [<EmitIndexer>] abstract Item: ``key``: BabylonjsBindings.StringEnums.WebXRHandJoint -> string with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject1818ddef00ab =
        [<EmitIndexer>] abstract Item: ``key``: string -> BabylonjsBindings.ObjectTypes.ComputeBindingLocation with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject6d99c3efc0a5 =
        [<EmitIndexer>] abstract Item: ``key``: string -> AliasObjectf9837e5af8ce with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject48d35bfa5654 =
        abstract ``size``: BabylonjsBindings.TypeAliases.TextureSize with get, set
        abstract ``options``: BabylonjsBindings.ObjectTypes.FrameGraphTextureOptions with get, set
        abstract ``sizeIsPercentage``: bool with get, set
        abstract ``isHistoryTexture``: bool option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject5ddd70d906f6 =
        abstract ``size``: AliasObject38742680c103 with get, set
        abstract ``options``: BabylonjsBindings.ObjectTypes.FrameGraphTextureOptions with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject1508f3d151ec =
        abstract ``leftColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``rightColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``bias``: System.Double option with get, set
        abstract ``power``: System.Double option with get, set
        abstract ``isEnabled``: bool option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject8100b17d32ab =
        abstract ``hasTexture``: bool with get, set
        abstract ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject6203b669d6e3 =
        abstract ``isReadyForSubMesh``: bool with get, set
        abstract ``defines``: BabylonjsBindings.SimpleClasses.MaterialDefines with get, set
        abstract ``subMesh``: BabylonjsBindings.SimpleClasses.SubMesh with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject680fbaa03d9c =
        abstract ``defineNames``: AliasObject1aaf511ae5b6 option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject94ac0c75db2a =
        abstract ``defines``: BabylonjsBindings.SimpleClasses.MaterialDefines with get, set
        abstract ``fallbacks``: BabylonjsBindings.SimpleClasses.EffectFallbacks with get, set
        abstract ``fallbackRank``: System.Double with get, set
        abstract ``customCode``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set
        abstract ``attributes``: ResizeArray<string> with get, set
        abstract ``uniforms``: ResizeArray<string> with get, set
        abstract ``samplers``: ResizeArray<string> with get, set
        abstract ``uniformBuffersNames``: ResizeArray<string> with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set
        abstract ``indexParameters``: obj with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject30d71ade1570 =
        abstract ``defines``: BabylonjsBindings.SimpleClasses.MaterialDefines with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject4db22449cde4 =
        abstract ``ubo``: BabylonjsBindings.SimpleClasses.UniformBuffer with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject973e5db2a604 =
        abstract ``subMesh``: BabylonjsBindings.SimpleClasses.SubMesh with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectb703bdd55640 =
        abstract ``animatables``: ResizeArray<BabylonjsBindings.SimpleInterfaces.IAnimatable> with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject7127b8abcbb2 =
        abstract ``activeTextures``: ResizeArray<BabylonjsBindings.SimpleClasses.BaseTexture> with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectf7cf6b4f3727 =
        abstract ``renderTargets``: BabylonjsBindings.SimpleClasses.SmartArray<BabylonjsBindings.SimpleClasses.RenderTargetTexture> with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectb68403858bab =
        abstract ``value``: AliasEnum6bfd9a7c2404 with get, set
        abstract ``type``: AliasEnum150995365430 with get, set
        abstract ``offset``: System.Double with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectf3be3b8e2a6a =
        abstract ``defines``: AliasObjectcb14fbe7a9aa with get, set
        abstract ``previousWorldMatrices``: AliasObject412d911943f6 with get, set
        abstract ``previousViewProjection``: BabylonjsBindings.SimpleClasses.Matrix with get, set
        abstract ``currentViewProjection``: BabylonjsBindings.SimpleClasses.Matrix with get, set
        abstract ``previousBones``: AliasObject39ce38c5be16 with get, set
        abstract ``lastUpdateFrameId``: System.Double with get, set
        abstract ``excludedSkinnedMesh``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> with get, set
        abstract ``reverseCulling``: bool with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject1ef54cec7ea7 =
        abstract ``LTC1``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set
        abstract ``LTC2``: BabylonjsBindings.SimpleClasses.BaseTexture with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectcc17c3f88910 =
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> with get, set
        abstract ``faceCenters``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``faceZaxis``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``faceXaxis``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``faceYaxis``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``nbSharedFaces``: System.Double with get, set
        abstract ``nbUnsharedFaces``: System.Double with get, set
        abstract ``nbFaces``: System.Double with get, set
        abstract ``nbFacesAtPole``: System.Double with get, set
        abstract ``adjacentFaces``: ResizeArray<ResizeArray<System.Double>> with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject044785759537 =
        abstract ``pointsMode``: BabylonjsBindings.Enums.GreasedLineRibbonPointsMode option with get, set
        abstract ``directions``: U2<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>, BabylonjsBindings.SimpleClasses.Vector3> option with get, set
        abstract ``directionsAutoMode``: BabylonjsBindings.Enums.GreasedLineRibbonAutoDirectionMode option with get, set
        abstract ``width``: System.Double option with get, set
        abstract ``facesMode``: BabylonjsBindings.Enums.GreasedLineRibbonFacesMode option with get, set
        abstract ``closePath``: bool option with get, set
        abstract ``smoothShading``: bool option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject601302d1d559 =
        abstract ``type``: StringLiteral26f8567f2569 with get, set
        abstract ``ref``: obj with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``halfExtents``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``angle``: System.Double with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectf26a216b7486 =
        abstract ``type``: StringLiteral05fa0965c7c3 with get, set
        abstract ``ref``: obj with get, set
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``radius``: System.Double with get, set
        abstract ``height``: System.Double with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectcd9be493dba9 =
        abstract ``scene``: BabylonjsBindings.SimpleClasses.Scene with get
        abstract ``onChangedObservable``: BabylonjsBindings.SimpleClasses.Observable<unit> with get
        abstract ``onAssetNotFound``: System.Func<string, string, JS.Promise<U2<string, Browser.Types.File> option>> option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type PickObject0b0b499b89e1 =
        abstract ``type``: string option with get
        abstract ``extension``: string option with get
        abstract ``metadata``: AliasObject00831351dc53 option with get

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject5e89a90967c6 =
        abstract ``optimizeWithUV``: bool with get, set
        abstract ``UVScaling``: BabylonjsBindings.SimpleClasses.Vector2 with get, set
        abstract ``invertY``: bool with get, set
        abstract ``invertTextureY``: bool with get, set
        abstract ``importVertexColors``: bool with get, set
        abstract ``computeNormals``: bool with get, set
        abstract ``optimizeNormals``: bool with get, set
        abstract ``skipMaterials``: bool with get, set
        abstract ``materialLoadingFailsSilently``: bool with get, set
        abstract ``useLegacyBehavior``: bool with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject21cda25aa7be =
        abstract ``keepInRam``: bool option with get, set
        abstract ``flipY``: bool option with get, set
        abstract ``deflateURL``: string option with get, set
        abstract ``fflate``: obj option with get, set
        abstract ``disableAutoCameraLimits``: bool option with get, set
        abstract ``gaussianSplattingMesh``: BabylonjsBindings.SimpleClasses.GaussianSplattingMesh option with get, set
        abstract ``needsRotationScaleTextures``: bool option with get, set
        abstract ``useSogTextures``: bool option with get, set
        abstract ``spzLibraryUrl``: string option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectf497ac798630 =
        abstract ``variants``: System.Collections.Generic.IReadOnlyList<string> with get
        abstract ``selectedVariant``: string with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectf9837e5af8ce =
        abstract ``type``: BabylonjsBindings.Enums.ComputeBindingType with get, set
        abstract ``object``: obj with get, set
        abstract ``indexInGroupEntries``: System.Double option with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject1aaf511ae5b6 =
        [<EmitIndexer>] abstract Item: ``name``: string -> AliasObjectaa4e4b93b6db with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectcb14fbe7a9aa =
        [<EmitIndexer>] abstract Item: ``name``: string -> System.Double with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject412d911943f6 =
        [<EmitIndexer>] abstract Item: ``index``: System.Double -> BabylonjsBindings.SimpleClasses.Matrix with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject39ce38c5be16 =
        [<EmitIndexer>] abstract Item: ``index``: System.Double -> JS.Float32Array with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObject00831351dc53 =
        [<EmitIndexer>] abstract Item: ``key``: string -> obj with get, set

    /// Exact nested object used by a Babylon type alias.
    [<AllowNullLiteral>]
    type AliasObjectaa4e4b93b6db =
        abstract ``type``: string with get, set
        abstract ``default``: obj with get, set

    /// @babylonjs/core/Behaviors/Cameras/interpolatingBehavior
    type AllowedAnimValue = U8<System.Double, BabylonjsBindings.SimpleInterfaces.IVector2Like, BabylonjsBindings.SimpleInterfaces.IVector3Like, BabylonjsBindings.SimpleInterfaces.IQuaternionLike, BabylonjsBindings.SimpleInterfaces.IMatrixLike, BabylonjsBindings.SimpleInterfaces.IColor3Like, BabylonjsBindings.SimpleInterfaces.IColor4Like, BabylonjsBindings.ObjectTypes.SizeLike> option

    /// @babylonjs/core/Animations/animation.optimizations
    type AnimationOptimization = U2<AliasObject38fb0477dfc1, AliasObjectc2a40b3b5670>
    type PartialAnimationOptimization = U2<PartialAliasObject38fb0477dfc1, PartialAliasObjectc2a40b3b5670>

    /// @babylonjs/core/Misc/coroutine
    type AsyncCoroutine<'T> = BabylonjsBindings.SimpleInterfaces.BrowserGenerator<U2<unit, JS.Promise<unit>>, 'T, unit>

    /// @babylonjs/core/Loading/Plugins/babylonFileParser.function
    [<AllowNullLiteral>]
    type BabylonFileParser =
        [<Emit("$0($1...)")>] abstract Invoke: parsedData: obj * scene: BabylonjsBindings.SimpleClasses.Scene * container: BabylonjsBindings.SimpleClasses.AssetContainer * rootUrl: string -> unit

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type CameraStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: camera: BabylonjsBindings.SimpleClasses.Camera -> unit

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type CameraStageFrameBufferAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: camera: BabylonjsBindings.SimpleClasses.Camera -> bool

    /// @babylonjs/core/Materials/Textures/textureMerger
    type ChannelInput = U2<BabylonjsBindings.SimpleInterfaces.ITextureChannelInput, BabylonjsBindings.SimpleInterfaces.IConstantChannelInput>

    /// @babylonjs/core/PostProcesses/circleOfConfusionPostProcess.pure
    [<AllowNullLiteral>]
    type CircleOfConfusionPostProcessOptions =
        inherit BabylonjsBindings.SimpleInterfaces.ThinCircleOfConfusionPostProcessOptions
        inherit BabylonjsBindings.TypeAliases.PostProcessOptions

    /// @babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphCodeExecutionBlock
    [<AllowNullLiteral>]
    type CodeExecutionFunction =
        [<Emit("$0($1...)")>] abstract Invoke: value: obj * context: BabylonjsBindings.SimpleClasses.FlowGraphContext -> obj

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    type ComputeBindingList = AliasObject6d99c3efc0a5

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    type ComputeBindingMapping = AliasObject1818ddef00ab

    /// @babylonjs/core/Physics/v2/IPhysicsEnginePlugin
    type ConstrainedBodyPair = AliasObjectf8c432911558

    /// @babylonjs/core/Misc/coroutine
    [<AllowNullLiteral>]
    type Coroutine<'T> =
        abstract next: ?value: unit -> CoroutineInternalResult<'T>
        [<Emit("$0.return === undefined ? undefined : $0.return($1)")>] abstract tryReturn: ?value: 'T -> CoroutineInternalResult<'T> option
        [<Emit("$0.throw === undefined ? undefined : $0.throw($1)")>] abstract tryThrow: ?error: obj -> CoroutineInternalResult<'T> option
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> Coroutine<'T>

    /// @babylonjs/core/Misc/coroutine
    type CoroutineScheduler<'T> = System.Action<BabylonjsBindings.SimpleInterfaces.BrowserGenerator<U2<unit, JS.Promise<unit>>, 'T, unit>, System.Action<BabylonjsBindings.SimpleInterfaces.BrowserGeneratorResult<unit, 'T>>, System.Action<obj>>

    /// @babylonjs/core/Misc/coroutine
    type CoroutineStep<'T> = BabylonjsBindings.SimpleInterfaces.BrowserGeneratorResult<unit, 'T>

    /// @babylonjs/core/types
    type DataArray = U3<ResizeArray<System.Double>, U2<JS.ArrayBuffer, BrowserSharedArrayBuffer>, JS.ArrayBufferView>

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    type DecoderMessage = U3<BabylonjsBindings.SimpleInterfaces.IDecodeMeshDoneMessage, BabylonjsBindings.SimpleInterfaces.IIndicesMessage, BabylonjsBindings.SimpleInterfaces.IAttributeMessage>

    /// @babylonjs/core/types
    type double = System.Double

    /// @babylonjs/core/Behaviors/Meshes/pointerDragEvents
    type DragEvent = AliasObject8a8f0eb7b989

    /// @babylonjs/core/Behaviors/Meshes/pointerDragEvents
    type DragStartEndEvent = PickObject26759efc7574

    /// @babylonjs/core/Materials/effectRenderer.pure
    type EffectWrapperCustomShaderCodeProcessing = AliasObject6772b28860e6

    /// @babylonjs/core/types
    type Empty = ResizeArray<BabylonjsBindings.SimpleClasses.Never>

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    type EncoderMessage = U2<BabylonjsBindings.SimpleInterfaces.IEncodeSuccessMessage, BabylonjsBindings.SimpleInterfaces.IEncodeErrorMessage>

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    type EnvironmentTextureInfo = U2<BabylonjsBindings.SimpleInterfaces.EnvironmentTextureInfoV1, BabylonjsBindings.SimpleInterfaces.EnvironmentTextureInfoV2>

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type EvaluateSubMeshStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: mesh: BabylonjsBindings.SimpleClasses.AbstractMesh * subMesh: BabylonjsBindings.SimpleClasses.SubMesh -> unit

    /// @babylonjs/core/types
    type float = System.Double

    /// @babylonjs/core/types
    type FloatArray = U2<ResizeArray<System.Double>, JS.Float32Array>
    type DeepImmutableFloatArray = U2<System.Collections.Generic.IReadOnlyList<System.Double>, JS.Float32Array>

    /// @babylonjs/core/FlowGraph/utils
    type FlowGraphMathOperationType = U4<BabylonjsBindings.TypeAliases.FlowGraphNumber, BabylonjsBindings.TypeAliases.FlowGraphVector, BabylonjsBindings.TypeAliases.FlowGraphMatrix, bool>

    /// @babylonjs/core/FlowGraph/utils
    type FlowGraphMatrix = U3<BabylonjsBindings.SimpleClasses.Matrix, BabylonjsBindings.SimpleClasses.FlowGraphMatrix2D, BabylonjsBindings.SimpleClasses.FlowGraphMatrix3D>

    /// @babylonjs/core/FlowGraph/utils
    type FlowGraphNumber = U2<System.Double, BabylonjsBindings.SimpleClasses.FlowGraphInteger>

    /// @babylonjs/core/FlowGraph/utils
    type FlowGraphVector = U4<BabylonjsBindings.SimpleClasses.Vector2, BabylonjsBindings.SimpleClasses.Vector3, BabylonjsBindings.SimpleClasses.Vector4, BabylonjsBindings.SimpleClasses.Quaternion>

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    type FrameGraphTextureCreationOptions = AliasObject48d35bfa5654

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    type FrameGraphTextureDescription = AliasObject5ddd70d906f6

    /// @babylonjs/core/FrameGraph/frameGraphTypes
    type FrameGraphTextureHandle = System.Double

    /// @babylonjs/core/Materials/materialHelper.geometryrendering
    type GeometryRenderingConfiguration = AliasObjectf3be3b8e2a6a

    /// @babylonjs/core/Cameras/geospatialCamera.pure
    type GeospatialCameraOptions = AliasObjectdb70335810f5

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderAnimation
    [<AllowNullLiteral>]
    type GetValueFn =
        [<Emit("$0($1...)")>] abstract Invoke: target: obj * source: JS.Float32Array * offset: System.Double * scale: System.Double -> obj

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderExtensionRegistry
    [<AllowNullLiteral>]
    type GLTFExtensionFactory =
        [<Emit("$0($1...)")>] abstract Invoke: loader: BabylonjsBindings.SimpleClasses.GLTF2Loader -> U2<BabylonjsBindings.SimpleInterfaces.GLTF2LoaderExtension, JS.Promise<BabylonjsBindings.SimpleInterfaces.GLTF2LoaderExtension>>

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_variants.types
    type GLTFFileLoaderMaterialVariantsController = AliasObjectf497ac798630

    /// @babylonjs/core/Meshes/Builders/goldbergBuilder
    [<AllowNullLiteral>]
    type GoldbergCreationOption =
        inherit BabylonjsBindings.ObjectTypes.GoldbergVertexDataOption
        abstract ``m``: System.Double option with get, set
        abstract ``n``: System.Double option with get, set
        abstract ``updatable``: bool option with get, set

    /// @babylonjs/core/Meshes/goldbergMesh.pure
    type GoldbergData = AliasObjectcc17c3f88910

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineBaseMesh
    type GreasedLinePoints = U6<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>, ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>>, JS.Float32Array, ResizeArray<JS.Float32Array>, ResizeArray<ResizeArray<System.Double>>, ResizeArray<System.Double>>

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineBaseMesh
    type GreasedLineRibbonOptions = AliasObject044785759537

    /// @babylonjs/core/Materials/fresnelParameters.pure
    type IFresnelParametersCreationOptions = AliasObject1508f3d151ec

    /// @babylonjs/core/Lights/LTC/ltcTextureTool
    type ILTCTextures = AliasObject1ef54cec7ea7

    /// @babylonjs/core/types
    type ImageSource = U6<BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap, Browser.Types.ImageData, Browser.Types.HTMLImageElement, Browser.Types.HTMLCanvasElement, Browser.Types.HTMLVideoElement, BabylonjsBindings.SimpleInterfaces.BrowserOffscreenCanvas>

    /// @babylonjs/core/types
    type IndicesArray = U4<ResizeArray<System.Double>, JS.Int32Array, JS.Uint32Array, JS.Uint16Array>

    /// @babylonjs/core/Loading/Plugins/babylonFileParser.function
    [<AllowNullLiteral>]
    type IndividualBabylonFileParser =
        [<Emit("$0($1...)")>] abstract Invoke: parsedData: obj * scene: BabylonjsBindings.SimpleClasses.Scene * rootUrl: string -> obj

    /// @babylonjs/core/types
    type int = System.Double

    /// @babylonjs/core/Sprites/spriteSceneComponent.pure
    [<AllowNullLiteral>]
    type InternalSpriteAugmentedScene =
        inherit BabylonjsBindings.SimpleClasses.Scene
        abstract ``_onNewSpriteManagerAddedObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.SimpleInterfaces.ISpriteManager> option with get, set
        abstract ``_onSpriteManagerRemovedObservable``: BabylonjsBindings.SimpleClasses.Observable<BabylonjsBindings.SimpleInterfaces.ISpriteManager> option with get, set

    /// @babylonjs/core/Navigation/INavigationEngine
    type IObstacle = U2<AliasObject601302d1d559, AliasObjectf26a216b7486>

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginBindForSubMesh = AliasObject973e5db2a604

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginCreated = BabylonjsBindings.SimpleInterfaces.JavaScriptObject

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginFillRenderTargetTextures = AliasObjectf7cf6b4f3727

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginGetActiveTextures = AliasObject7127b8abcbb2

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginGetAnimatables = AliasObjectb703bdd55640

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginGetDefineNames = AliasObject680fbaa03d9c

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginHardBindForSubMesh = AliasObject973e5db2a604

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginHasTexture = AliasObject8100b17d32ab

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginIsReadyForSubMesh = AliasObject6203b669d6e3

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginPrepareDefines = AliasObject30d71ade1570

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginPrepareEffect = AliasObject94ac0c75db2a

    /// @babylonjs/core/Materials/materialPluginEvent
    type MaterialPluginPrepareUniformBuffer = AliasObject4db22449cde4

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_variants.pure
    type MaterialVariantsController = AliasObjectf497ac798630

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type MeshPredicate =
        [<Emit("$0($1...)")>] abstract Invoke: mesh: BabylonjsBindings.SimpleClasses.AbstractMesh * thinInstanceIndex: System.Double -> bool

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type MeshStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: mesh: BabylonjsBindings.SimpleClasses.AbstractMesh * hardwareInstancedRendering: bool -> bool

    /// @babylonjs/core/XR/motionController/webXRMotionControllerManager.pure
    [<AllowNullLiteral>]
    type MotionControllerConstructor =
        [<Emit("$0($1...)")>] abstract Invoke: xrInput: BabylonjsBindings.SimpleInterfaces.BrowserXRInputSource * scene: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.WebXRAbstractMotionController

    /// @babylonjs/core/Engines/Native/nativeDataStream
    type NativeData = JS.Uint32Array

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeFramebuffer = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeProgram = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeTexture = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeUniform = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    type NativeVertexArrayObject = BabylonjsBindings.TypeAliases.NativeData

    /// @babylonjs/core/node
    [<AllowNullLiteral>]
    type NodeConstructor =
        [<Emit("$0($1...)")>] abstract Invoke: name: string * scene: BabylonjsBindings.SimpleClasses.Scene * ?options: obj -> System.Func<BabylonjsBindings.SimpleClasses.Node>

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    type NodeMaterialTextureBlocks = U9<BabylonjsBindings.SimpleClasses.TextureBlock, BabylonjsBindings.SimpleClasses.ReflectionTextureBaseBlock, BabylonjsBindings.SimpleClasses.RefractionBlock, BabylonjsBindings.SimpleClasses.CurrentScreenBlock, BabylonjsBindings.SimpleClasses.ParticleTextureBlock, BabylonjsBindings.SimpleClasses.ImageSourceBlock, BabylonjsBindings.SimpleClasses.TriPlanarBlock, BabylonjsBindings.SimpleClasses.BiPlanarBlock, BabylonjsBindings.SimpleClasses.PrePassTextureBlock>

    /// @babylonjs/core/FrameGraph/Node/Types/nodeRenderGraphTypes
    type NodeRenderGraphBlockConnectionPointValueType = U6<BabylonjsBindings.TypeAliases.FrameGraphTextureHandle, BabylonjsBindings.SimpleClasses.Camera, BabylonjsBindings.SimpleClasses.FrameGraphObjectList, BabylonjsBindings.SimpleInterfaces.IShadowLight, BabylonjsBindings.SimpleClasses.FrameGraphShadowGeneratorTask, BabylonjsBindings.SimpleClasses.FrameGraphObjectRendererTask>

    /// @babylonjs/core/FrameGraph/Node/Blocks/inputBlock.pure
    type NodeRenderGraphInputCreationOptions = BabylonjsBindings.TypeAliases.FrameGraphTextureCreationOptions

    /// @babylonjs/core/FrameGraph/Node/Blocks/inputBlock.pure
    type NodeRenderGraphValueType = U4<BabylonjsBindings.SimpleClasses.InternalTexture, BabylonjsBindings.SimpleClasses.Camera, BabylonjsBindings.SimpleClasses.FrameGraphObjectList, BabylonjsBindings.SimpleInterfaces.IShadowLight>

    /// @babylonjs/core/types
    type Nullable<'T> = 'T option

    /// @babylonjs/loaders/OBJ/objLoadingOptions
    type OBJLoadingOptions = AliasObject5e89a90967c6

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.query.pure
    type OcclusionQuery = U2<BabylonjsBindings.SimpleInterfaces.BrowserWebGLQuery, System.Double>

    /// @babylonjs/core/Misc/PerformanceViewer/performanceViewerCollectionStrategies
    [<AllowNullLiteral>]
    type PerfStrategyInitialization =
        [<Emit("$0($1...)")>] abstract Invoke: scene: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleInterfaces.IPerfViewerCollectionStrategy

    /// @babylonjs/core/Materials/materialPluginManager.pure
    [<AllowNullLiteral>]
    type PluginMaterialFactory =
        [<Emit("$0($1...)")>] abstract Invoke: material: BabylonjsBindings.SimpleClasses.Material -> BabylonjsBindings.SimpleClasses.MaterialPluginBase option

    /// @babylonjs/core/Loading/sceneLoader
    type PluginOptions = BabylonjsBindings.SimpleInterfaces.BrowserRecord<string, BabylonjsBindings.SimpleInterfaces.LoaderExtensionOptionBag option> option

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    type PlyProperty = AliasObjectb68403858bab

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type PointerMoveStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: unTranslatedPointerX: System.Double * unTranslatedPointerY: System.Double * pickResult: BabylonjsBindings.SimpleClasses.PickingInfo option * isMeshPicked: bool * element: Browser.Types.HTMLElement option -> BabylonjsBindings.SimpleClasses.PickingInfo option

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type PointerUpDownStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: unTranslatedPointerX: System.Double * unTranslatedPointerY: System.Double * pickResult: BabylonjsBindings.SimpleClasses.PickingInfo option * evt: BabylonjsBindings.SimpleInterfaces.IPointerEvent * doubleClick: bool -> BabylonjsBindings.SimpleClasses.PickingInfo option

    /// @babylonjs/core/PostProcesses/postProcess.pure
    [<AllowNullLiteral>]
    type PostProcessOptions =
        inherit BabylonjsBindings.SimpleInterfaces.EffectWrapperCreationOptions
        abstract ``width``: System.Double option with get, set
        abstract ``height``: System.Double option with get, set
        abstract ``size``: U2<System.Double, AliasObject38742680c103> option with get, set
        abstract ``camera``: BabylonjsBindings.SimpleClasses.Camera option with get, set
        abstract ``samplingMode``: System.Double option with get, set
        abstract ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine option with get, set
        abstract ``reusable``: bool option with get, set
        abstract ``textureType``: System.Double option with get, set
        abstract ``textureFormat``: System.Double option with get, set
        abstract ``effectWrapper``: BabylonjsBindings.SimpleClasses.EffectWrapper option with get, set

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type PreActiveMeshStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: mesh: BabylonjsBindings.SimpleClasses.AbstractMesh -> unit

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type PrepareTextureFunction =
        [<Emit("$0($1...)")>] abstract Invoke: texture: BabylonjsBindings.SimpleClasses.InternalTexture * extension: string * scene: BabylonjsBindings.SimpleInterfaces.ISceneLike option * img: U3<Browser.Types.HTMLImageElement, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap, AliasObject38742680c103> * invertY: bool * noMipmap: bool * isCompressed: bool * processFunction: BabylonjsBindings.TypeAliases.PrepareTextureProcessFunction * samplingMode: System.Double -> unit

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type PrepareTextureProcessFunction =
        [<Emit("$0($1...)")>] abstract Invoke: width: System.Double * height: System.Double * img: U3<Browser.Types.HTMLImageElement, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap, AliasObject38742680c103> * extension: string * texture: BabylonjsBindings.SimpleClasses.InternalTexture * continuationCallback: System.Action -> bool

    /// @babylonjs/core/AudioV2/abstractAudio/audioBus
    type PrimaryAudioBus = U2<BabylonjsBindings.SimpleClasses.MainAudioBus, BabylonjsBindings.SimpleClasses.AudioBus>

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type RenderingGroupStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: renderingGroupId: System.Double -> unit

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type RenderingMeshStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: mesh: BabylonjsBindings.SimpleClasses.Mesh * subMesh: BabylonjsBindings.SimpleClasses.SubMesh * batch: obj * effect: BabylonjsBindings.SimpleClasses.Effect option -> unit

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type RenderTargetsStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: renderTargets: BabylonjsBindings.SimpleClasses.SmartArrayNoDuplicate<BabylonjsBindings.SimpleClasses.RenderTargetTexture> -> unit

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type RenderTargetStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: renderTarget: BabylonjsBindings.SimpleClasses.RenderTargetTexture * ?faceIndex: System.Double * ?layer: System.Double -> unit

    /// @babylonjs/core/Engines/Extensions/engine.renderTarget.pure
    type RenderTargetTextureSize = BabylonjsBindings.TypeAliases.TextureSize

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type SceneLoaderSuccessCallback =
        [<Emit("$0($1...)")>] abstract Invoke: meshes: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> * particleSystems: ResizeArray<BabylonjsBindings.SimpleInterfaces.IParticleSystem> * skeletons: ResizeArray<BabylonjsBindings.SimpleClasses.Skeleton> * animationGroups: ResizeArray<BabylonjsBindings.SimpleClasses.AnimationGroup> * transformNodes: ResizeArray<BabylonjsBindings.SimpleClasses.TransformNode> * geometries: ResizeArray<BabylonjsBindings.SimpleClasses.Geometry> * lights: ResizeArray<BabylonjsBindings.SimpleClasses.Light> * spriteManagers: ResizeArray<BabylonjsBindings.SimpleInterfaces.ISpriteManager> -> unit

    /// @babylonjs/core/Engines/Processors/shaderProcessingOptions
    [<AllowNullLiteral>]
    type ShaderCustomProcessingFunction =
        [<Emit("$0($1...)")>] abstract Invoke: shaderType: string * code: string * ?defines: ResizeArray<string> -> string

    /// @babylonjs/core/sceneComponent
    [<AllowNullLiteral>]
    type SimpleStageAction =
        inherit JavaScriptFunction
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type SmartAssetLoadOptions =
        inherit PickObject0b0b499b89e1
        abstract ``reloadSource``: System.Func<JS.Promise<Browser.Types.File>> option with get

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    type SmartAssetManager = AliasObjectcd9be493dba9

    /// @babylonjs/loaders/SPLAT/splatLoadingOptions
    type SPLATLoadingOptions = AliasObject21cda25aa7be

    /// @babylonjs/core/Maths/tensor
    [<Erase>]
    type TensorValue =
        | TensorValueCase1 of ResizeArray<System.Double>
        | TensorValueCase2 of ResizeArray<BabylonjsBindings.TypeAliases.TensorValue>

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    type TextureSize = U2<System.Double, AliasObjectde9f6c1b6b0f>

    /// @babylonjs/core/PostProcesses/tonemapPostProcess.pure
    [<AllowNullLiteral>]
    type ToneMapPostProcessOptions =
        inherit BabylonjsBindings.SimpleInterfaces.ThinTonemapPostProcessOptions
        inherit BabylonjsBindings.TypeAliases.PostProcessOptions

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type TrianglePickingPredicate =
        [<Emit("$0($1...)")>] abstract Invoke: p0: BabylonjsBindings.SimpleClasses.Vector3 * p1: BabylonjsBindings.SimpleClasses.Vector3 * p2: BabylonjsBindings.SimpleClasses.Vector3 * ray: BabylonjsBindings.SimpleClasses.Ray * i0: System.Double * i1: System.Double * i2: System.Double -> bool

    /// @babylonjs/core/types
    type TypedArray = U2<U8<JS.Int8Array, JS.Uint8Array, JS.Uint8ClampedArray, JS.Int16Array, JS.Uint16Array, JS.Int32Array, JS.Uint32Array, JS.Float32Array>, U3<JS.Float64Array, JS.BigInt64Array, BabylonjsBindings.SimpleInterfaces.BrowserBigUint64Array>>

    /// @babylonjs/core/Buffers/bufferUtils
    type VertexDataTypedArray = U8<JS.Int8Array, JS.Uint8Array, JS.Uint8ClampedArray, JS.Int16Array, JS.Uint16Array, JS.Int32Array, JS.Uint32Array, JS.Float32Array>

    /// @babylonjs/core/Engines/thinEngine.functions
    type WebGLContext = U2<Browser.Types.WebGLRenderingContext, BabylonjsBindings.SimpleInterfaces.BrowserWebGL2RenderingContext>

    /// @babylonjs/core/XR/features/WebXRControllerMovement.pure
    type WebXRControllerMovementFeatureContext = AliasObjectc11d826e4a3c

    /// @babylonjs/core/XR/features/WebXRControllerMovement.pure
    type WebXRControllerMovementRegistrationConfiguration = U2<AliasObject2d7882d93505, AliasObject406c176bc0c4>

    /// @babylonjs/core/XR/webXRFeaturesManager
    [<AllowNullLiteral>]
    type WebXRFeatureConstructor =
        [<Emit("$0($1...)")>] abstract Invoke: xrSessionManager: BabylonjsBindings.SimpleClasses.WebXRSessionManager * ?options: obj -> System.Func<BabylonjsBindings.SimpleInterfaces.IWebXRFeature>

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    type XRBodyMeshRigMapping = AliasObject4d81806d37f7

    /// @babylonjs/core/XR/features/WebXRHandTracking.pure
    type XRHandMeshRigMapping = AliasObjectfe6bed7521ea
