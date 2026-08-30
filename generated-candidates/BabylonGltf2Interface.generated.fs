// REVIEW-ONLY GENERATED GLTF2 INTERFACE CANDIDATE — NOT COMPILED INTO THE PACKAGE
// source babylonjs-gltf2interface@9.19.0 babylon.glTF2Interface.d.ts sha256: c66882ddaf8ecd70aacdb6b9ab6f4a93220be059449ea3e30926acc5a7f85395
// generator ts2fable@0.9.0-build.738 with typescript@5.1.6
module rec BabylonjsBindings.FullGltf2InterfaceCandidate

#nowarn "3390"

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open BabylonjsBindings.FullCandidate

[<Erase>] type KeyOf<'T> = Key of string
type Array<'T> = System.Collections.Generic.IList<'T>


module BABYLON =

    module GLTF2 =

        type AccessorComponentType =
            | BYTE = 5120
            | UNSIGNED_BYTE = 5121
            | SHORT = 5122
            | UNSIGNED_SHORT = 5123
            | UNSIGNED_INT = 5125
            | FLOAT = 5126

        type [<StringEnum>] [<RequireQualifiedAccess>] AccessorType =
            | [<CompiledName("SCALAR")>] SCALAR
            | [<CompiledName("VEC2")>] VEC2
            | [<CompiledName("VEC3")>] VEC3
            | [<CompiledName("VEC4")>] VEC4
            | [<CompiledName("MAT2")>] MAT2
            | [<CompiledName("MAT3")>] MAT3
            | [<CompiledName("MAT4")>] MAT4

        type [<StringEnum>] [<RequireQualifiedAccess>] AnimationChannelTargetPath =
            | [<CompiledName("translation")>] TRANSLATION
            | [<CompiledName("rotation")>] ROTATION
            | [<CompiledName("scale")>] SCALE
            | [<CompiledName("weights")>] WEIGHTS
            | [<CompiledName("pointer")>] POINTER

        type [<StringEnum>] [<RequireQualifiedAccess>] AnimationSamplerInterpolation =
            | [<CompiledName("LINEAR")>] LINEAR
            | [<CompiledName("STEP")>] STEP
            | [<CompiledName("CUBICSPLINE")>] CUBICSPLINE

        type [<StringEnum>] [<RequireQualifiedAccess>] CameraType =
            | [<CompiledName("perspective")>] PERSPECTIVE
            | [<CompiledName("orthographic")>] ORTHOGRAPHIC

        type [<StringEnum>] [<RequireQualifiedAccess>] ImageMimeType =
            | [<CompiledName("image/jpeg")>] JPEG
            | [<CompiledName("image/png")>] PNG
            | [<CompiledName("image/webp")>] WEBP
            | [<CompiledName("image/avif")>] AVIF
            | [<CompiledName("image/ktx2")>] KTX2

        type [<StringEnum>] [<RequireQualifiedAccess>] MaterialAlphaMode =
            | [<CompiledName("OPAQUE")>] OPAQUE
            | [<CompiledName("MASK")>] MASK
            | [<CompiledName("BLEND")>] BLEND

        type MeshPrimitiveMode =
            | POINTS = 0
            | LINES = 1
            | LINE_LOOP = 2
            | LINE_STRIP = 3
            | TRIANGLES = 4
            | TRIANGLE_STRIP = 5
            | TRIANGLE_FAN = 6

        type TextureMagFilter =
            | NEAREST = 9728
            | LINEAR = 9729

        type TextureMinFilter =
            | NEAREST = 9728
            | LINEAR = 9729
            | NEAREST_MIPMAP_NEAREST = 9984
            | LINEAR_MIPMAP_NEAREST = 9985
            | NEAREST_MIPMAP_LINEAR = 9986
            | LINEAR_MIPMAP_LINEAR = 9987

        type TextureWrapMode =
            | CLAMP_TO_EDGE = 33071
            | MIRRORED_REPEAT = 33648
            | REPEAT = 10497

        type [<AllowNullLiteral>] IProperty =
            abstract extensions: IPropertyExtensions option with get, set
            abstract extras: obj option with get, set

        type [<AllowNullLiteral>] IChildRootProperty =
            inherit IProperty
            abstract name: string option with get, set

        type [<AllowNullLiteral>] IAccessorSparseIndices =
            inherit IProperty
            abstract bufferView: float with get, set
            abstract byteOffset: float option with get, set
            abstract componentType: AccessorComponentType with get, set

        type [<AllowNullLiteral>] IAccessorSparseValues =
            inherit IProperty
            abstract bufferView: float with get, set
            abstract byteOffset: float option with get, set

        type [<AllowNullLiteral>] IAccessorSparse =
            inherit IProperty
            abstract count: float with get, set
            abstract indices: IAccessorSparseIndices with get, set
            abstract values: IAccessorSparseValues with get, set

        type [<AllowNullLiteral>] IAccessor =
            inherit IChildRootProperty
            abstract bufferView: float option with get, set
            abstract byteOffset: float option with get, set
            abstract componentType: AccessorComponentType with get, set
            abstract normalized: bool option with get, set
            abstract count: float with get, set
            abstract ``type``: AccessorType with get, set
            abstract max: ResizeArray<float> option with get, set
            abstract min: ResizeArray<float> option with get, set
            abstract sparse: IAccessorSparse option with get, set

        type [<AllowNullLiteral>] IAnimationChannel =
            inherit IProperty
            abstract sampler: float with get, set
            abstract target: IAnimationChannelTarget with get, set

        type [<AllowNullLiteral>] IAnimationChannelTarget =
            inherit IProperty
            abstract node: float option with get, set
            abstract path: AnimationChannelTargetPath with get, set

        type [<AllowNullLiteral>] IAnimationSampler =
            inherit IProperty
            abstract input: float with get, set
            abstract interpolation: AnimationSamplerInterpolation option with get, set
            abstract output: float with get, set

        type [<AllowNullLiteral>] IAnimation =
            inherit IChildRootProperty
            abstract channels: ResizeArray<IAnimationChannel> with get, set
            abstract samplers: ResizeArray<IAnimationSampler> with get, set

        type [<AllowNullLiteral>] IAsset =
            inherit IChildRootProperty
            abstract copyright: string option with get, set
            abstract generator: string option with get, set
            abstract version: string with get, set
            abstract minVersion: string option with get, set

        type [<AllowNullLiteral>] IBuffer =
            inherit IChildRootProperty
            abstract uri: string option with get, set
            abstract byteLength: float with get, set

        type [<AllowNullLiteral>] IBufferView =
            inherit IChildRootProperty
            abstract buffer: float with get, set
            abstract byteOffset: float option with get, set
            abstract byteLength: float with get, set
            abstract byteStride: float option with get, set

        type [<AllowNullLiteral>] ICameraOrthographic =
            inherit IProperty
            abstract xmag: float with get, set
            abstract ymag: float with get, set
            abstract zfar: float with get, set
            abstract znear: float with get, set

        type [<AllowNullLiteral>] ICameraPerspective =
            inherit IProperty
            abstract aspectRatio: float option with get, set
            abstract yfov: float with get, set
            abstract zfar: float option with get, set
            abstract znear: float with get, set

        type [<AllowNullLiteral>] ICamera =
            inherit IChildRootProperty
            abstract orthographic: ICameraOrthographic option with get, set
            abstract perspective: ICameraPerspective option with get, set
            abstract ``type``: CameraType with get, set

        type [<AllowNullLiteral>] IImage =
            inherit IChildRootProperty
            abstract uri: string option with get, set
            abstract mimeType: ImageMimeType option with get, set
            abstract bufferView: float option with get, set

        type [<AllowNullLiteral>] IMaterialNormalTextureInfo =
            inherit ITextureInfo
            abstract scale: float option with get, set

        type [<AllowNullLiteral>] IMaterialOcclusionTextureInfo =
            inherit ITextureInfo
            abstract strength: float option with get, set

        type [<AllowNullLiteral>] IMaterialPbrMetallicRoughness =
            abstract baseColorFactor: ResizeArray<float> option with get, set
            abstract baseColorTexture: ITextureInfo option with get, set
            abstract metallicFactor: float option with get, set
            abstract roughnessFactor: float option with get, set
            abstract metallicRoughnessTexture: ITextureInfo option with get, set

        type [<AllowNullLiteral>] IMaterial =
            inherit IChildRootProperty
            abstract pbrMetallicRoughness: IMaterialPbrMetallicRoughness option with get, set
            abstract normalTexture: IMaterialNormalTextureInfo option with get, set
            abstract occlusionTexture: IMaterialOcclusionTextureInfo option with get, set
            abstract emissiveTexture: ITextureInfo option with get, set
            abstract emissiveFactor: ResizeArray<float> option with get, set
            abstract alphaMode: MaterialAlphaMode option with get, set
            abstract alphaCutoff: float option with get, set
            abstract doubleSided: bool option with get, set

        type [<AllowNullLiteral>] IMeshPrimitive =
            inherit IProperty
            abstract attributes: IMeshPrimitiveAttributes with get, set
            abstract indices: float option with get, set
            abstract material: float option with get, set
            abstract mode: MeshPrimitiveMode option with get, set
            abstract targets: ResizeArray<IMeshPrimitiveAttributes> option with get, set

        type [<AllowNullLiteral>] IMesh =
            inherit IChildRootProperty
            abstract primitives: ResizeArray<IMeshPrimitive> with get, set
            abstract weights: ResizeArray<float> option with get, set

        type [<AllowNullLiteral>] INode =
            inherit IChildRootProperty
            abstract camera: float option with get, set
            abstract children: ResizeArray<float> option with get, set
            abstract skin: float option with get, set
            abstract matrix: ResizeArray<float> option with get, set
            abstract mesh: float option with get, set
            abstract rotation: ResizeArray<float> option with get, set
            abstract scale: ResizeArray<float> option with get, set
            abstract translation: ResizeArray<float> option with get, set
            abstract weights: ResizeArray<float> option with get, set

        type [<AllowNullLiteral>] ISampler =
            inherit IChildRootProperty
            abstract magFilter: TextureMagFilter option with get, set
            abstract minFilter: TextureMinFilter option with get, set
            abstract wrapS: TextureWrapMode option with get, set
            abstract wrapT: TextureWrapMode option with get, set

        type [<AllowNullLiteral>] IScene =
            inherit IChildRootProperty
            abstract nodes: ResizeArray<float> with get, set

        type [<AllowNullLiteral>] ISkin =
            inherit IChildRootProperty
            abstract inverseBindMatrices: float option with get, set
            abstract skeleton: float option with get, set
            abstract joints: ResizeArray<float> with get, set

        type [<AllowNullLiteral>] ITexture =
            inherit IChildRootProperty
            abstract sampler: float option with get, set
            abstract source: float option with get, set

        type [<AllowNullLiteral>] ITextureInfo =
            inherit IProperty
            abstract index: float with get, set
            abstract texCoord: float option with get, set

        type [<AllowNullLiteral>] IGLTF =
            inherit IProperty
            abstract accessors: ResizeArray<IAccessor> option with get, set
            abstract animations: ResizeArray<IAnimation> option with get, set
            abstract asset: IAsset with get, set
            abstract buffers: ResizeArray<IBuffer> option with get, set
            abstract bufferViews: ResizeArray<IBufferView> option with get, set
            abstract cameras: ResizeArray<ICamera> option with get, set
            abstract extensionsUsed: ResizeArray<string> option with get, set
            abstract extensionsRequired: ResizeArray<string> option with get, set
            abstract images: ResizeArray<IImage> option with get, set
            abstract materials: ResizeArray<IMaterial> option with get, set
            abstract meshes: ResizeArray<IMesh> option with get, set
            abstract nodes: ResizeArray<INode> option with get, set
            abstract samplers: ResizeArray<ISampler> option with get, set
            abstract scene: float option with get, set
            abstract scenes: ResizeArray<IScene> option with get, set
            abstract skins: ResizeArray<ISkin> option with get, set
            abstract textures: ResizeArray<ITexture> option with get, set

        type [<AllowNullLiteral>] IGLTFValidationResults =
            abstract info: IGLTFValidationResultsInfo with get, set
            abstract issues: IGLTFValidationResultsIssues with get, set
            abstract mimeType: string with get, set
            abstract uri: string with get, set
            abstract validatedAt: string with get, set
            abstract validatorVersion: string with get, set

        type [<AllowNullLiteral>] IGLTFValidationOptions =
            abstract uri: string option with get, set
            abstract externalResourceFunction: (string -> Promise<Uint8Array>) option with get, set
            abstract validateAccessorData: bool option with get, set
            abstract maxIssues: float option with get, set
            abstract ignoredIssues: Array<string> option with get, set
            abstract severityOverrides: Object option with get, set

        type [<AllowNullLiteral>] IGLTFValidator =
            abstract validateBytes: (Uint8Array -> (IGLTFValidationOptions) option -> Promise<IGLTFValidationResults>) with get, set
            abstract validateString: (string -> (IGLTFValidationOptions) option -> Promise<IGLTFValidationResults>) with get, set

        type [<AllowNullLiteral>] IEXTLightsImageBased_LightReferenceImageBased =
            abstract light: float with get, set

        type [<AllowNullLiteral>] IEXTLightsImageBased_LightImageBased =
            inherit IChildRootProperty
            abstract intensity: float with get, set
            abstract rotation: ResizeArray<float> with get, set
            abstract specularImageSize: float with get, set
            abstract specularImages: ResizeArray<ResizeArray<float>> with get, set
            abstract irradianceCoefficients: ResizeArray<ResizeArray<float>> with get, set

        type [<AllowNullLiteral>] IEXTLightsImageBased =
            abstract lights: ResizeArray<IEXTLightsImageBased_LightImageBased> with get, set

        type [<AllowNullLiteral>] IEXTMeshGpuInstancing =
            abstract mesh: float option with get, set
            abstract attributes: IMeshPrimitiveAttributes with get, set

        type [<AllowNullLiteral>] IKHRDracoMeshCompression =
            abstract bufferView: float with get, set
            abstract attributes: IMeshPrimitiveAttributes with get, set

        type [<AllowNullLiteral>] IKHRGaussianSplatting =
            abstract kernel: string with get, set
            abstract colorSpace: string with get, set
            abstract projection: string option with get, set
            abstract sortingMethod: string option with get, set

        type [<AllowNullLiteral>] IEXTLightsIES_LightReference =
            abstract light: float with get, set
            abstract color: ResizeArray<float> option with get, set
            abstract multiplier: float option with get, set

        type [<AllowNullLiteral>] IEXTLightsIES_Light =
            inherit IChildRootProperty
            abstract uri: string option with get, set
            abstract bufferView: float option with get, set
            abstract mimeType: string option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] KHRLightsPunctual_LightType =
            | [<CompiledName("directional")>] DIRECTIONAL
            | [<CompiledName("point")>] POINT
            | [<CompiledName("spot")>] SPOT

        type [<AllowNullLiteral>] IKHRLightsPunctual_LightReference =
            abstract light: float with get, set

        type [<AllowNullLiteral>] IKHRLightsPunctual_Light =
            inherit IChildRootProperty
            abstract ``type``: KHRLightsPunctual_LightType with get, set
            abstract color: ResizeArray<float> option with get, set
            abstract intensity: float option with get, set
            abstract range: float option with get, set
            abstract spot: {| innerConeAngle: float option; outerConeAngle: float option |} option with get, set

        type [<AllowNullLiteral>] IKHRLightsPunctual =
            abstract lights: ResizeArray<IKHRLightsPunctual_Light> with get, set

        type [<AllowNullLiteral>] IKHRMaterialsClearcoat =
            abstract clearcoatFactor: float option with get, set
            abstract clearcoatTexture: ITextureInfo option with get, set
            abstract clearcoatRoughnessFactor: float option with get, set
            abstract clearcoatRoughnessTexture: ITextureInfo option with get, set
            abstract clearcoatNormalTexture: IMaterialNormalTextureInfo option with get, set
            abstract extensions: IPropertyExtensions option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsCoat =
            abstract coatFactor: float option with get, set
            abstract coatTexture: ITextureInfo option with get, set
            abstract coatRoughnessFactor: float option with get, set
            abstract coatRoughnessTexture: ITextureInfo option with get, set
            abstract coatNormalTexture: IMaterialNormalTextureInfo option with get, set
            abstract coatIor: float option with get, set
            abstract coatDarkeningFactor: float option with get, set
            abstract coatColorFactor: ResizeArray<float> option with get, set
            abstract coatColorTexture: ITextureInfo option with get, set
            abstract coatAnisotropyStrength: float option with get, set
            abstract coatAnisotropyRotation: float option with get, set
            abstract coatAnisotropyTexture: ITextureInfo option with get, set
            abstract extensions: IPropertyExtensions option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsClearcoatAnisotropy =
            abstract clearcoatAnisotropyStrength: float option with get, set
            abstract clearcoatAnisotropyRotation: float option with get, set
            abstract clearcoatAnisotropyTexture: ITextureInfo option with get, set
            abstract extensions: IPropertyExtensions option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsIridescence =
            abstract iridescenceFactor: float option with get, set
            abstract iridescenceIor: float option with get, set
            abstract iridescenceThicknessMinimum: float option with get, set
            abstract iridescenceThicknessMaximum: float option with get, set
            abstract iridescenceTexture: ITextureInfo option with get, set
            abstract iridescenceThicknessTexture: ITextureInfo option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsAnisotropy =
            abstract anisotropyStrength: float option with get, set
            abstract anisotropyRotation: float option with get, set
            abstract anisotropyTexture: ITextureInfo option with get, set
            abstract extensions: IPropertyExtensions option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsAnisotropyOpenPbr =
            abstract anisotropyOpenPbrEnabled: bool with get, set

        type [<AllowNullLiteral>] IKHRMaterialsIor =
            abstract ior: float option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsVolume =
            abstract thicknessFactor: float option with get, set
            abstract thicknessTexture: ITextureInfo option with get, set
            abstract attenuationDistance: float option with get, set
            abstract attenuationColor: ResizeArray<float> option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsVolumeScatter =
            abstract scatterAnisotropy: float option with get, set
            abstract multiscatterColorFactor: ResizeArray<float> option with get, set
            abstract multiscatterColorTexture: ITextureInfo option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsDispersion =
            abstract dispersion: float option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsSpecular =
            abstract specularFactor: float option with get, set
            abstract specularColorFactor: ResizeArray<float> option with get, set
            abstract specularTexture: ITextureInfo option with get, set
            abstract specularColorTexture: ITextureInfo option with get, set
            abstract extensions: IPropertyExtensions option with get, set

        type [<AllowNullLiteral>] IEXTMaterialsSpecularEdgeColor =
            abstract specularEdgeColorEnabled: bool option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsTransmission =
            abstract transmissionFactor: float option with get, set
            abstract transmissionTexture: ITextureInfo option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsEmissiveStrength =
            abstract emissiveStrength: float with get, set

        type [<AllowNullLiteral>] IKHRMaterialsPbrSpecularGlossiness =
            abstract diffuseFactor: ResizeArray<float> with get, set
            abstract diffuseTexture: ITextureInfo with get, set
            abstract specularFactor: ResizeArray<float> with get, set
            abstract glossinessFactor: float with get, set
            abstract specularGlossinessTexture: ITextureInfo with get, set

        type [<AllowNullLiteral>] IKHRMaterialsSheen =
            abstract sheenColorFactor: ResizeArray<float> option with get, set
            abstract sheenColorTexture: ITextureInfo option with get, set
            abstract sheenRoughnessFactor: float option with get, set
            abstract sheenRoughnessTexture: ITextureInfo option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsFuzz =
            abstract fuzzFactor: float option with get, set
            abstract fuzzTexture: ITextureInfo option with get, set
            abstract fuzzColorFactor: ResizeArray<float> option with get, set
            abstract fuzzColorTexture: ITextureInfo option with get, set
            abstract fuzzRoughnessFactor: float option with get, set
            abstract fuzzRoughnessTexture: ITextureInfo option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsDiffuseTransmission =
            abstract diffuseTransmissionFactor: float option with get, set
            abstract diffuseTransmissionTexture: ITextureInfo option with get, set
            abstract diffuseTransmissionColorFactor: ResizeArray<float> option with get, set
            abstract diffuseTransmissionColorTexture: ITextureInfo option with get, set

        type [<AllowNullLiteral>] IKHRMaterialsDiffuseRoughness =
            abstract diffuseRoughnessFactor: float option with get, set
            abstract diffuseRoughnessTexture: ITextureInfo option with get, set

        type [<AllowNullLiteral>] IKHRMaterialVariants_Mapping =
            inherit IProperty
            abstract mappings: Array<{| variants: ResizeArray<float>; material: float |}> with get, set

        type [<AllowNullLiteral>] IKHRMaterialVariants_Variant =
            inherit IProperty
            abstract name: string with get, set

        type [<AllowNullLiteral>] IKHRMaterialVariants_Variants =
            inherit IChildRootProperty
            abstract variants: Array<IKHRMaterialVariants_Variant> with get, set

        type [<AllowNullLiteral>] IKHRTextureBasisU =
            abstract source: float with get, set

        type [<AllowNullLiteral>] IEXTTextureWebP =
            abstract source: float with get, set

        type [<AllowNullLiteral>] IEXTTextureAVIF =
            abstract source: float with get, set

        type [<AllowNullLiteral>] IKHRTextureTransform =
            abstract offset: ResizeArray<float> option with get, set
            abstract rotation: float option with get, set
            abstract scale: ResizeArray<float> option with get, set
            abstract texCoord: float option with get, set

        type [<AllowNullLiteral>] IKHRXmpJsonLd_Gltf =
            abstract packets: Array<IKHRXmpJsonLd_GltfPacketsArray> with get, set

        type [<AllowNullLiteral>] IKHRXmpJsonLd_Node =
            abstract packet: float with get, set

        type [<AllowNullLiteral>] IKHRAnimationPointer =
            abstract pointer: string with get, set

        type [<AllowNullLiteral>] IMSFTAudioEmitter_ClipReference =
            abstract clip: float with get, set
            abstract weight: float option with get, set

        type [<AllowNullLiteral>] IMSFTAudioEmitter_EmittersReference =
            abstract emitters: ResizeArray<float> with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] IMSFTAudioEmitter_DistanceModel =
            | Linear
            | Inverse
            | Exponential

        type [<AllowNullLiteral>] IMSFTAudioEmitter_Emitter =
            abstract name: string option with get, set
            abstract distanceModel: IMSFTAudioEmitter_DistanceModel option with get, set
            abstract refDistance: float option with get, set
            abstract maxDistance: float option with get, set
            abstract rolloffFactor: float option with get, set
            abstract innerAngle: float option with get, set
            abstract outerAngle: float option with get, set
            abstract loop: bool option with get, set
            abstract volume: float option with get, set
            abstract clips: ResizeArray<IMSFTAudioEmitter_ClipReference> with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] IMSFTAudioEmitter_AudioMimeType =
            | [<CompiledName("audio/wav")>] WAV

        type [<AllowNullLiteral>] IMSFTAudioEmitter_Clip =
            inherit IProperty
            abstract uri: string option with get, set
            abstract bufferView: float option with get, set
            abstract mimeType: IMSFTAudioEmitter_AudioMimeType option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] IMSFTAudioEmitter_AnimationEventAction =
            | Play
            | Pause
            | Stop

        type [<AllowNullLiteral>] IMSFTAudioEmitter_AnimationEvent =
            abstract action: IMSFTAudioEmitter_AnimationEventAction with get, set
            abstract emitter: float with get, set
            abstract time: float with get, set
            abstract startOffset: float option with get, set

        type [<AllowNullLiteral>] IMSFTLOD =
            abstract ids: ResizeArray<float> with get, set

        type [<AllowNullLiteral>] IEXTMeshoptCompression =
            abstract buffer: float with get, set
            abstract byteOffset: float option with get, set
            abstract byteLength: float with get, set
            abstract byteStride: float with get, set
            abstract count: float with get, set
            abstract mode: IEXTMeshoptCompressionMode with get, set
            abstract filter: IEXTMeshoptCompressionFilter option with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] EXTLightsArea_LightType =
            | [<CompiledName("rect")>] RECT
            | [<CompiledName("disk")>] DISK

        type [<AllowNullLiteral>] IEXTLightsArea_LightReference =
            abstract light: float with get, set

        type [<AllowNullLiteral>] IEXTLightsArea_Light =
            inherit IChildRootProperty
            abstract ``type``: EXTLightsArea_LightType with get, set
            abstract color: ResizeArray<float> option with get, set
            abstract intensity: float option with get, set
            abstract size: float option with get, set
            abstract rect: {| aspect: float |} option with get, set

        type [<AllowNullLiteral>] IEXTLightsArea =
            abstract lights: ResizeArray<IEXTLightsArea_Light> with get, set

        type [<AllowNullLiteral>] IKHRInteractivity =
            abstract graphs: ResizeArray<IKHRInteractivity_Graph> with get, set
            abstract graph: float option with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_Graph =
            abstract types: ResizeArray<IKHRInteractivity_Type> option with get, set
            abstract variables: ResizeArray<IKHRInteractivity_Variable> option with get, set
            abstract events: ResizeArray<IKHRInteractivity_Event> option with get, set
            abstract declarations: ResizeArray<IKHRInteractivity_Declaration> option with get, set
            abstract nodes: ResizeArray<IKHRInteractivity_Node> option with get, set

        type TypeIndex =
            float

        type DeclarationIndex =
            float

        type NodeIndex =
            float

        type ValueType =
            ResizeArray<U2<bool, float>>

        type [<StringEnum>] [<RequireQualifiedAccess>] ValueSignature =
            | Bool
            | Float
            | Float2
            | Float3
            | Float4
            | Float2x2
            | Float3x3
            | Float4x4
            | Int
            | Custom

        type ConfigurationValueType =
            ResizeArray<U3<bool, float, string>>

        type [<AllowNullLiteral>] IKHRInteractivity_Event =
            abstract id: string option with get, set
            abstract values: IKHRInteractivity_EventValues option with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_Type =
            abstract signature: ValueSignature with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_Variable =
            abstract value: ValueType option with get, set
            abstract ``type``: TypeIndex with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_Declaration =
            abstract op: string with get, set
            abstract extension: string option with get, set
            abstract outputValueSockets: IKHRInteractivity_DeclarationOutputValueSockets option with get, set
            abstract inputValueSockets: IKHRInteractivity_DeclarationOutputValueSockets option with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_Node =
            abstract declaration: DeclarationIndex with get, set
            abstract values: IKHRInteractivity_NodeValues option with get, set
            abstract flows: IKHRInteractivity_NodeFlows option with get, set
            abstract configuration: IKHRInteractivity_NodeConfiguration option with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_OutputSocketReference =
            abstract node: NodeIndex with get, set
            abstract socket: string option with get, set
            abstract ``type``: TypeIndex option with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_OutputFlow =
            abstract node: NodeIndex with get, set
            abstract socket: string option with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_Configuration =
            abstract value: ConfigurationValueType option with get, set

        type [<AllowNullLiteral>] IPropertyExtensions =
            [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

        type [<AllowNullLiteral>] IMeshPrimitiveAttributes =
            [<EmitIndexer>] abstract Item: name: string -> float with get, set

        type [<AllowNullLiteral>] IGLTFValidationResultsInfo =
            abstract generator: string with get, set
            abstract hasAnimations: bool with get, set
            abstract hasDefaultScene: bool with get, set
            abstract hasMaterials: bool with get, set
            abstract hasMorphTargets: bool with get, set
            abstract hasSkins: bool with get, set
            abstract hasTextures: bool with get, set
            abstract maxAttributesUsed: float with get, set
            abstract primitivesCount: float with get, set

        type [<AllowNullLiteral>] IGLTFValidationResultsIssues =
            abstract messages: Array<string> with get, set
            abstract numErrors: float with get, set
            abstract numHints: float with get, set
            abstract numInfos: float with get, set
            abstract numWarnings: float with get, set
            abstract truncated: bool with get, set

        type [<AllowNullLiteral>] IKHRXmpJsonLd_GltfPacketsArray =
            [<EmitIndexer>] abstract Item: key: string -> obj with get, set

        type [<StringEnum>] [<RequireQualifiedAccess>] IEXTMeshoptCompressionMode =
            | [<CompiledName("ATTRIBUTES")>] ATTRIBUTES
            | [<CompiledName("TRIANGLES")>] TRIANGLES
            | [<CompiledName("INDICES")>] INDICES

        type [<StringEnum>] [<RequireQualifiedAccess>] IEXTMeshoptCompressionFilter =
            | [<CompiledName("NONE")>] NONE
            | [<CompiledName("OCTAHEDRAL")>] OCTAHEDRAL
            | [<CompiledName("QUATERNION")>] QUATERNION
            | [<CompiledName("EXPONENTIAL")>] EXPONENTIAL

        type [<AllowNullLiteral>] IKHRInteractivity_EventValues =
            [<EmitIndexer>] abstract Item: id: string -> IKHRInteractivity_Variable with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_DeclarationOutputValueSockets =
            [<EmitIndexer>] abstract Item: id: string -> {| ``type``: TypeIndex |} with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_NodeValues =
            [<EmitIndexer>] abstract Item: id: string -> U2<IKHRInteractivity_Variable, IKHRInteractivity_OutputSocketReference> with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_NodeFlows =
            [<EmitIndexer>] abstract Item: id: string -> IKHRInteractivity_OutputFlow with get, set

        type [<AllowNullLiteral>] IKHRInteractivity_NodeConfiguration =
            [<EmitIndexer>] abstract Item: id: string -> IKHRInteractivity_Configuration with get, set
