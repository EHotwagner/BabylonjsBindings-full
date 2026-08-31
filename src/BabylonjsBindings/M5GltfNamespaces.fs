namespace BabylonjsBindings

open Fable.Core

/// Exact glTF 1.0 and 2.0 declaration facades and runtime namespace objects.
module GltfNamespaces =

    [<AllowNullLiteral>]
    type JavaScriptConstructor<'Instance> =
        interface end

    [<AllowNullLiteral>]
    type JavaScriptEnumObject<'Value> =
        interface end

    module GLTF1 =

        type ``EBlendingFunction`` = BabylonjsBindings.Enums.EBlendingFunction
        type ``EComponentType`` = BabylonjsBindings.Enums.EComponentType
        type ``ECullingType`` = BabylonjsBindings.Enums.ECullingType
        type ``EParameterType`` = BabylonjsBindings.Enums.EParameterType
        type ``EShaderType`` = BabylonjsBindings.Enums.EShaderType
        type ``ETextureFilterType`` = BabylonjsBindings.Enums.ETextureFilterType
        type ``ETextureFormat`` = BabylonjsBindings.Enums.ETextureFormat
        type ``ETextureWrapMode`` = BabylonjsBindings.Enums.ETextureWrapMode
        type ``GLTFBinaryExtension`` = BabylonjsBindings.SimpleClasses.GLTFBinaryExtension
        type ``GLTFLoader`` = BabylonjsBindings.SimpleClasses.GLTF1Loader
        type ``GLTFLoaderBase`` = BabylonjsBindings.SimpleClasses.GLTFLoaderBase
        type ``GLTFLoaderExtension`` = BabylonjsBindings.SimpleClasses.GLTFLoaderExtension
        type ``GLTFMaterialsCommonExtension`` = BabylonjsBindings.SimpleClasses.GLTFMaterialsCommonExtension
        type ``GLTFUtils`` = BabylonjsBindings.SimpleClasses.GLTFUtils
        type ``IGLTFAccessor`` = BabylonjsBindings.SimpleInterfaces.IGLTFAccessor
        type ``IGLTFAmbienLight`` = BabylonjsBindings.SimpleInterfaces.IGLTFAmbienLight
        type ``IGLTFAnimation`` = BabylonjsBindings.SimpleInterfaces.IGLTFAnimation
        type ``IGLTFAnimationChannel`` = BabylonjsBindings.SimpleInterfaces.IGLTFAnimationChannel
        type ``IGLTFAnimationChannelTarget`` = BabylonjsBindings.SimpleInterfaces.IGLTFAnimationChannelTarget
        type ``IGLTFAnimationSampler`` = BabylonjsBindings.SimpleInterfaces.IGLTFAnimationSampler
        type ``IGLTFBuffer`` = BabylonjsBindings.SimpleInterfaces.IGLTFBuffer
        type ``IGLTFBufferView`` = BabylonjsBindings.SimpleInterfaces.IGLTFBufferView
        type ``IGLTFCamera`` = BabylonjsBindings.SimpleInterfaces.IGLTFCamera
        type ``IGLTFCameraOrthographic`` = BabylonjsBindings.SimpleInterfaces.IGLTFCameraOrthographic
        type ``IGLTFCameraPerspective`` = BabylonjsBindings.SimpleInterfaces.IGLTFCameraPerspective
        type ``IGLTFChildRootProperty`` = BabylonjsBindings.SimpleInterfaces.IGLTFChildRootProperty
        type ``IGLTFDirectionalLight`` = BabylonjsBindings.SimpleInterfaces.IGLTFDirectionalLight
        type ``IGLTFImage`` = BabylonjsBindings.SimpleInterfaces.IGLTFImage
        type ``IGLTFLight`` = BabylonjsBindings.SimpleInterfaces.IGLTFLight
        type ``IGLTFMaterial`` = BabylonjsBindings.SimpleInterfaces.IGLTFMaterial
        type ``IGLTFMesh`` = BabylonjsBindings.SimpleInterfaces.IGLTFMesh
        type ``IGLTFMeshPrimitive`` = BabylonjsBindings.SimpleInterfaces.IGLTFMeshPrimitive
        type ``IGLTFNode`` = BabylonjsBindings.SimpleInterfaces.IGLTFNode
        type ``IGLTFNodeInstanceSkin`` = BabylonjsBindings.SimpleInterfaces.IGLTFNodeInstanceSkin
        type ``IGLTFPointLight`` = BabylonjsBindings.SimpleInterfaces.IGLTFPointLight
        type ``IGLTFProgram`` = BabylonjsBindings.SimpleInterfaces.IGLTFProgram
        type ``IGLTFProperty`` = BabylonjsBindings.SimpleInterfaces.IGLTFProperty
        type ``IGLTFRuntime`` = BabylonjsBindings.SimpleInterfaces.IGLTFRuntime
        type ``IGLTFSampler`` = BabylonjsBindings.SimpleInterfaces.IGLTFSampler
        type ``IGLTFScene`` = BabylonjsBindings.SimpleInterfaces.IGLTFScene
        type ``IGLTFShader`` = BabylonjsBindings.SimpleInterfaces.IGLTFShader
        type ``IGLTFSkins`` = BabylonjsBindings.SimpleInterfaces.IGLTFSkins
        type ``IGLTFSpotLight`` = BabylonjsBindings.SimpleInterfaces.IGLTFSpotLight
        type ``IGLTFTechnique`` = BabylonjsBindings.SimpleInterfaces.IGLTFTechnique
        type ``IGLTFTechniqueCommonProfile`` = BabylonjsBindings.SimpleInterfaces.IGLTFTechniqueCommonProfile
        type ``IGLTFTechniqueParameter`` = BabylonjsBindings.SimpleInterfaces.IGLTFTechniqueParameter
        type ``IGLTFTechniqueStates`` = BabylonjsBindings.SimpleInterfaces.IGLTFTechniqueStates
        type ``IGLTFTechniqueStatesFunctions`` = BabylonjsBindings.SimpleInterfaces.IGLTFTechniqueStatesFunctions
        type ``IGLTFTexture`` = BabylonjsBindings.SimpleInterfaces.IGLTFTexture
        type ``IJointNode`` = BabylonjsBindings.SimpleInterfaces.IJointNode
        type ``INodeToRoot`` = BabylonjsBindings.SimpleInterfaces.INodeToRoot

        [<AllowNullLiteral>]
        type RuntimeNamespace =
            abstract ``EBlendingFunction``: JavaScriptEnumObject<BabylonjsBindings.Enums.EBlendingFunction> with get
            abstract ``EComponentType``: JavaScriptEnumObject<BabylonjsBindings.Enums.EComponentType> with get
            abstract ``ECullingType``: JavaScriptEnumObject<BabylonjsBindings.Enums.ECullingType> with get
            abstract ``EParameterType``: JavaScriptEnumObject<BabylonjsBindings.Enums.EParameterType> with get
            abstract ``EShaderType``: JavaScriptEnumObject<BabylonjsBindings.Enums.EShaderType> with get
            abstract ``ETextureFilterType``: JavaScriptEnumObject<BabylonjsBindings.Enums.ETextureFilterType> with get
            abstract ``ETextureFormat``: JavaScriptEnumObject<BabylonjsBindings.Enums.ETextureFormat> with get
            abstract ``ETextureWrapMode``: JavaScriptEnumObject<BabylonjsBindings.Enums.ETextureWrapMode> with get
            abstract ``GLTFBinaryExtension``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.GLTFBinaryExtension> with get
            abstract ``GLTFLoader``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.GLTF1Loader> with get
            abstract ``GLTFLoaderBase``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.GLTFLoaderBase> with get
            abstract ``GLTFLoaderExtension``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.GLTFLoaderExtension> with get
            abstract ``GLTFMaterialsCommonExtension``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.GLTFMaterialsCommonExtension> with get
            abstract ``GLTFUtils``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.GLTFUtils> with get

        [<Import("GLTF1", "@babylonjs/loaders/glTF/index.js")>]
        let runtime: RuntimeNamespace = jsNative

    module GLTF2 =

        let ``_AddInteractivityObjectModel`` = BabylonjsBindings.SimpleFunctions._AddInteractivityObjectModel
        type ``_IAnimationSamplerData`` = BabylonjsBindings.SimpleInterfaces._IAnimationSamplerData
        type ``_ISamplerData`` = BabylonjsBindings.SimpleInterfaces._ISamplerData
        let ``addNewInteractivityFlowGraphMapping`` = BabylonjsBindings.SimpleFunctions.addNewInteractivityFlowGraphMapping
        let ``AddObjectAccessorToKey`` = BabylonjsBindings.SimpleFunctions.AddObjectAccessorToKey
        type ``AnimationPropertyInfo`` = BabylonjsBindings.SimpleClasses.AnimationPropertyInfo
        type ``ArrayItem`` = BabylonjsBindings.SimpleClasses.ArrayItem
        let ``ensureTransmissionHelper`` = BabylonjsBindings.SimpleFunctions.ensureTransmissionHelper
        type ``EXT_lights_area`` = BabylonjsBindings.SimpleClasses.EXT_lights_area
        type ``EXT_lights_ies`` = BabylonjsBindings.SimpleClasses.EXT_lights_ies
        type ``EXT_lights_image_based`` = BabylonjsBindings.SimpleClasses.EXT_lights_image_based
        type ``EXT_mesh_gpu_instancing`` = BabylonjsBindings.SimpleClasses.EXT_mesh_gpu_instancing
        type ``EXT_meshopt_compression`` = BabylonjsBindings.SimpleClasses.EXT_meshopt_compression
        type ``EXT_texture_avif`` = BabylonjsBindings.SimpleClasses.EXT_texture_avif
        type ``EXT_texture_webp`` = BabylonjsBindings.SimpleClasses.EXT_texture_webp
        type ``ExtrasAsMetadata`` = BabylonjsBindings.SimpleClasses.ExtrasAsMetadata
        type ``FlowGraphGLTFDataProvider`` = BabylonjsBindings.SimpleClasses.FlowGraphGLTFDataProvider
        let ``getAllSupportedNativeNodeTypes`` = BabylonjsBindings.SimpleFunctions.getAllSupportedNativeNodeTypes
        let ``getMappingForDeclaration`` = BabylonjsBindings.SimpleFunctions.getMappingForDeclaration
        let ``getMappingForFullOperationName`` = BabylonjsBindings.SimpleFunctions.getMappingForFullOperationName
        let ``GetMappingForKey`` = BabylonjsBindings.SimpleFunctions.GetMappingForKey
        let ``GetPathToObjectConverter`` = BabylonjsBindings.SimpleFunctions.GetPathToObjectConverter
        let ``getQuaternion`` = BabylonjsBindings.SimpleFunctions.getQuaternion
        type ``GetValueFn`` = BabylonjsBindings.TypeAliases.GetValueFn
        let ``getVector3`` = BabylonjsBindings.SimpleFunctions.getVector3
        let ``getWeights`` = BabylonjsBindings.SimpleFunctions.getWeights
        type ``GLTFExtensionFactory`` = BabylonjsBindings.TypeAliases.GLTFExtensionFactory
        type ``GLTFFileLoader`` = BabylonjsBindings.SimpleClasses.GLTFFileLoader
        type ``GLTFLoader`` = BabylonjsBindings.SimpleClasses.GLTF2Loader
        let ``gltfTypeToBabylonType`` = BabylonjsBindings.SimpleVariables.gltfTypeToBabylonType
        type ``IAccessor`` = BabylonjsBindings.SimpleInterfaces.IAccessor
        type ``IAnimation`` = BabylonjsBindings.SimpleInterfaces.IAnimation
        type ``IAnimationChannel`` = BabylonjsBindings.SimpleInterfaces.IAnimationChannel
        type ``IAnimationSampler`` = BabylonjsBindings.SimpleInterfaces.IAnimationSampler
        type ``IAnimationTargetInfo`` = BabylonjsBindings.SimpleInterfaces.IAnimationTargetInfo
        type ``IArrayItem`` = BabylonjsBindings.SimpleInterfaces.IArrayItem
        type ``IBuffer`` = BabylonjsBindings.SimpleInterfaces.IBuffer
        type ``IBufferView`` = BabylonjsBindings.SimpleInterfaces.IBufferView
        type ``ICamera`` = BabylonjsBindings.SimpleInterfaces.ICamera
        type ``IEXTLightsArea_Light`` = BabylonjsBindings.SimpleInterfaces.IEXTLightsArea_Light
        type ``IEXTLightsIES_Light`` = BabylonjsBindings.SimpleInterfaces.IEXTLightsIES_Light
        type ``IFlowGraphGLTFDataProviderBlockConfiguration`` = BabylonjsBindings.SimpleInterfaces.IFlowGraphGLTFDataProviderBlockConfiguration
        type ``IGLTF`` = BabylonjsBindings.SimpleInterfaces.IGLTF
        type ``IGLTFLoaderExtension`` = BabylonjsBindings.SimpleInterfaces.GLTF2LoaderExtension
        type ``IGLTFObjectModelTree`` = BabylonjsBindings.SimpleInterfaces.IGLTFObjectModelTree
        type ``IGLTFObjectModelTreeCamerasObject`` = BabylonjsBindings.SimpleInterfaces.IGLTFObjectModelTreeCamerasObject
        type ``IGLTFObjectModelTreeExtensionsObject`` = BabylonjsBindings.SimpleInterfaces.IGLTFObjectModelTreeExtensionsObject
        type ``IGLTFObjectModelTreeMaterialsObject`` = BabylonjsBindings.SimpleInterfaces.IGLTFObjectModelTreeMaterialsObject
        type ``IGLTFObjectModelTreeMeshesObject`` = BabylonjsBindings.SimpleInterfaces.IGLTFObjectModelTreeMeshesObject
        type ``IGLTFObjectModelTreeNodesObject`` = BabylonjsBindings.SimpleInterfaces.IGLTFObjectModelTreeNodesObject
        type ``IGLTFToFlowGraphMapping`` = BabylonjsBindings.SimpleInterfaces.IGLTFToFlowGraphMapping
        type ``IImage`` = BabylonjsBindings.SimpleInterfaces.GLTFImage
        type ``IKHRLightsPunctual_Light`` = BabylonjsBindings.SimpleInterfaces.IKHRLightsPunctual_Light
        type ``IMaterial`` = BabylonjsBindings.SimpleInterfaces.IMaterial
        type ``IMaterialNormalTextureInfo`` = BabylonjsBindings.SimpleInterfaces.IMaterialNormalTextureInfo
        type ``IMaterialOcclusionTextureInfo`` = BabylonjsBindings.SimpleInterfaces.IMaterialOcclusionTextureInfo
        type ``IMaterialPbrMetallicRoughness`` = BabylonjsBindings.SimpleInterfaces.IMaterialPbrMetallicRoughness
        type ``IMesh`` = BabylonjsBindings.SimpleInterfaces.IMesh
        type ``IMeshPrimitive`` = BabylonjsBindings.SimpleInterfaces.IMeshPrimitive
        type ``INode`` = BabylonjsBindings.SimpleInterfaces.GLTFNode
        type ``InteractivityEvent`` = BabylonjsBindings.SimpleInterfaces.InteractivityEvent
        type ``InteractivityGraphToFlowGraphParser`` = BabylonjsBindings.SimpleClasses.InteractivityGraphToFlowGraphParser
        type ``ISampler`` = BabylonjsBindings.SimpleInterfaces.ISampler
        type ``IScene`` = BabylonjsBindings.SimpleInterfaces.IScene
        type ``ISkin`` = BabylonjsBindings.SimpleInterfaces.ISkin
        type ``ITexture`` = BabylonjsBindings.SimpleInterfaces.ITexture
        type ``ITextureInfo`` = BabylonjsBindings.SimpleInterfaces.ITextureInfo
        type ``ITransmissionHelperHolder`` = BabylonjsBindings.SimpleInterfaces.ITransmissionHelperHolder
        type ``ITransmissionHelperMaterialImpl`` = BabylonjsBindings.SimpleInterfaces.ITransmissionHelperMaterialImpl
        type ``ITransmissionHelperOptions`` = BabylonjsBindings.SimpleInterfaces.ITransmissionHelperOptions
        type ``KHR_animation_pointer`` = BabylonjsBindings.SimpleClasses.KHR_animation_pointer
        type ``KHR_draco_mesh_compression`` = BabylonjsBindings.SimpleClasses.KHR_draco_mesh_compression
        type ``KHR_gaussian_splatting`` = BabylonjsBindings.SimpleClasses.KHR_gaussian_splatting
        type ``KHR_interactivity`` = BabylonjsBindings.SimpleClasses.KHR_interactivity
        type ``KHR_lights`` = BabylonjsBindings.SimpleClasses.KHR_lights
        type ``KHR_materials_anisotropy`` = BabylonjsBindings.SimpleClasses.KHR_materials_anisotropy
        type ``KHR_materials_clearcoat`` = BabylonjsBindings.SimpleClasses.KHR_materials_clearcoat
        type ``KHR_materials_coat`` = BabylonjsBindings.SimpleClasses.KHR_materials_coat
        type ``KHR_materials_diffuse_roughness`` = BabylonjsBindings.SimpleClasses.KHR_materials_diffuse_roughness
        type ``KHR_materials_diffuse_transmission`` = BabylonjsBindings.SimpleClasses.KHR_materials_diffuse_transmission
        type ``KHR_materials_dispersion`` = BabylonjsBindings.SimpleClasses.KHR_materials_dispersion
        type ``KHR_materials_emissive_strength`` = BabylonjsBindings.SimpleClasses.KHR_materials_emissive_strength
        type ``KHR_materials_fuzz`` = BabylonjsBindings.SimpleClasses.KHR_materials_fuzz
        type ``KHR_materials_ior`` = BabylonjsBindings.SimpleClasses.KHR_materials_ior
        type ``KHR_materials_iridescence`` = BabylonjsBindings.SimpleClasses.KHR_materials_iridescence
        type ``KHR_materials_pbrSpecularGlossiness`` = BabylonjsBindings.SimpleClasses.KHR_materials_pbrSpecularGlossiness
        type ``KHR_materials_sheen`` = BabylonjsBindings.SimpleClasses.KHR_materials_sheen
        type ``KHR_materials_specular`` = BabylonjsBindings.SimpleClasses.KHR_materials_specular
        type ``KHR_materials_transmission`` = BabylonjsBindings.SimpleClasses.KHR_materials_transmission
        type ``KHR_materials_unlit`` = BabylonjsBindings.SimpleClasses.KHR_materials_unlit
        type ``KHR_materials_variants`` = BabylonjsBindings.SimpleClasses.KHR_materials_variants
        type ``KHR_materials_volume`` = BabylonjsBindings.SimpleClasses.KHR_materials_volume
        type ``KHR_materials_volume_scatter`` = BabylonjsBindings.SimpleClasses.KHR_materials_volume_scatter
        type ``KHR_mesh_quantization`` = BabylonjsBindings.SimpleClasses.KHR_mesh_quantization
        type ``KHR_node_hoverability`` = BabylonjsBindings.SimpleClasses.KHR_node_hoverability
        type ``KHR_node_selectability`` = BabylonjsBindings.SimpleClasses.KHR_node_selectability
        type ``KHR_node_visibility`` = BabylonjsBindings.SimpleClasses.KHR_node_visibility
        type ``KHR_texture_basisu`` = BabylonjsBindings.SimpleClasses.KHR_texture_basisu
        type ``KHR_texture_transform`` = BabylonjsBindings.SimpleClasses.KHR_texture_transform
        type ``KHR_xmp_json_ld`` = BabylonjsBindings.SimpleClasses.KHR_xmp_json_ld
        let ``LoadBoundingInfoFromPositionAccessor`` = BabylonjsBindings.SimpleFunctions.LoadBoundingInfoFromPositionAccessor
        type ``MaterialVariantsController`` = BabylonjsBindings.TypeAliases.MaterialVariantsController
        type ``MSFT_audio_emitter`` = BabylonjsBindings.SimpleClasses.MSFT_audio_emitter
        type ``MSFT_lod`` = BabylonjsBindings.SimpleClasses.MSFT_lod
        type ``MSFT_minecraftMesh`` = BabylonjsBindings.SimpleClasses.MSFT_minecraftMesh
        type ``MSFT_sRGBFactors`` = BabylonjsBindings.SimpleClasses.MSFT_sRGBFactors
        type ``OpenPBRMaterialLoadingAdapter`` = BabylonjsBindings.SimpleClasses.OpenPBRMaterialLoadingAdapter
        type ``PBRMaterialLoadingAdapter`` = BabylonjsBindings.SimpleClasses.PBRMaterialLoadingAdapter
        let ``registeredGLTFExtensions`` = BabylonjsBindings.SimpleVariables.registeredGLTFExtensions
        let ``RegisterEXT_lights_area`` = BabylonjsBindings.SimpleFunctions.RegisterEXT_lights_area
        let ``RegisterEXT_lights_ies`` = BabylonjsBindings.SimpleFunctions.RegisterEXT_lights_ies
        let ``RegisterEXT_lights_image_based`` = BabylonjsBindings.SimpleFunctions.RegisterEXT_lights_image_based
        let ``RegisterEXT_mesh_gpu_instancing`` = BabylonjsBindings.SimpleFunctions.RegisterEXT_mesh_gpu_instancing
        let ``RegisterEXT_meshopt_compression`` = BabylonjsBindings.SimpleFunctions.RegisterEXT_meshopt_compression
        let ``RegisterEXT_texture_avif`` = BabylonjsBindings.SimpleFunctions.RegisterEXT_texture_avif
        let ``RegisterEXT_texture_webp`` = BabylonjsBindings.SimpleFunctions.RegisterEXT_texture_webp
        let ``RegisterExtrasAsMetadata`` = BabylonjsBindings.SimpleFunctions.RegisterExtrasAsMetadata
        let ``RegisterGLTF2Loader`` = BabylonjsBindings.SimpleFunctions.RegisterGLTF2Loader
        let ``registerGLTFExtension`` = BabylonjsBindings.SimpleFunctions.registerGLTFExtension
        let ``RegisterKHR_animation_pointer`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_animation_pointer
        let ``RegisterKHR_draco_mesh_compression`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_draco_mesh_compression
        let ``RegisterKHR_gaussian_splatting`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_gaussian_splatting
        let ``RegisterKHR_interactivity`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_interactivity
        let ``RegisterKHR_lights`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_lights
        let ``RegisterKHR_materials_anisotropy`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_anisotropy
        let ``RegisterKHR_materials_clearcoat`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_clearcoat
        let ``RegisterKHR_materials_coat`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_coat
        let ``RegisterKHR_materials_diffuse_roughness`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_diffuse_roughness
        let ``RegisterKHR_materials_diffuse_transmission`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_diffuse_transmission
        let ``RegisterKHR_materials_dispersion`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_dispersion
        let ``RegisterKHR_materials_emissive_strength`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_emissive_strength
        let ``RegisterKHR_materials_fuzz`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_fuzz
        let ``RegisterKHR_materials_ior`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_ior
        let ``RegisterKHR_materials_iridescence`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_iridescence
        let ``RegisterKHR_materials_pbrSpecularGlossiness`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_pbrSpecularGlossiness
        let ``RegisterKHR_materials_sheen`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_sheen
        let ``RegisterKHR_materials_specular`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_specular
        let ``RegisterKHR_materials_transmission`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_transmission
        let ``RegisterKHR_materials_unlit`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_unlit
        let ``RegisterKHR_materials_variants`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_variants
        let ``RegisterKHR_materials_volume`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_volume
        let ``RegisterKHR_materials_volume_scatter`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_materials_volume_scatter
        let ``RegisterKHR_mesh_quantization`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_mesh_quantization
        let ``RegisterKHR_node_hoverability`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_node_hoverability
        let ``RegisterKHR_node_selectability`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_node_selectability
        let ``RegisterKHR_node_visibility`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_node_visibility
        let ``RegisterKHR_texture_basisu`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_texture_basisu
        let ``RegisterKHR_texture_transform`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_texture_transform
        let ``RegisterKHR_xmp_json_ld`` = BabylonjsBindings.SimpleFunctions.RegisterKHR_xmp_json_ld
        let ``RegisterMSFT_audio_emitter`` = BabylonjsBindings.SimpleFunctions.RegisterMSFT_audio_emitter
        let ``RegisterMSFT_lod`` = BabylonjsBindings.SimpleFunctions.RegisterMSFT_lod
        let ``RegisterMSFT_minecraftMesh`` = BabylonjsBindings.SimpleFunctions.RegisterMSFT_minecraftMesh
        let ``RegisterMSFT_sRGBFactors`` = BabylonjsBindings.SimpleFunctions.RegisterMSFT_sRGBFactors
        let ``SetInterpolationForKey`` = BabylonjsBindings.SimpleFunctions.SetInterpolationForKey
        type ``TransformNodeAnimationPropertyInfo`` = BabylonjsBindings.SimpleClasses.TransformNodeAnimationPropertyInfo
        type ``TransmissionHelper`` = BabylonjsBindings.SimpleClasses.TransmissionHelper
        let ``unregisterGLTFExtension`` = BabylonjsBindings.SimpleFunctions.unregisterGLTFExtension
        type ``WeightAnimationPropertyInfo`` = BabylonjsBindings.SimpleClasses.WeightAnimationPropertyInfo

        [<AllowNullLiteral>]
        type RuntimeNamespace =
            abstract ``AddObjectAccessorToKey``: BabylonjsBindings.SimpleFunctions.FunctionBinding_AddObjectAccessorToKey with get
            abstract ``AnimationPropertyInfo``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.AnimationPropertyInfo> with get
            abstract ``ArrayItem``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.ArrayItem> with get
            abstract ``EXT_lights_area``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.EXT_lights_area> with get
            abstract ``EXT_lights_ies``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.EXT_lights_ies> with get
            abstract ``EXT_lights_image_based``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.EXT_lights_image_based> with get
            abstract ``EXT_mesh_gpu_instancing``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.EXT_mesh_gpu_instancing> with get
            abstract ``EXT_meshopt_compression``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.EXT_meshopt_compression> with get
            abstract ``EXT_texture_avif``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.EXT_texture_avif> with get
            abstract ``EXT_texture_webp``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.EXT_texture_webp> with get
            abstract ``ExtrasAsMetadata``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.ExtrasAsMetadata> with get
            abstract ``FlowGraphGLTFDataProvider``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.FlowGraphGLTFDataProvider> with get
            abstract ``GLTFFileLoader``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.GLTFFileLoader> with get
            abstract ``GLTFLoader``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.GLTF2Loader> with get
            abstract ``GetMappingForKey``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetMappingForKey with get
            abstract ``GetPathToObjectConverter``: BabylonjsBindings.SimpleFunctions.FunctionBinding_GetPathToObjectConverter with get
            abstract ``InteractivityGraphToFlowGraphParser``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.InteractivityGraphToFlowGraphParser> with get
            abstract ``KHR_animation_pointer``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_animation_pointer> with get
            abstract ``KHR_draco_mesh_compression``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_draco_mesh_compression> with get
            abstract ``KHR_gaussian_splatting``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_gaussian_splatting> with get
            abstract ``KHR_interactivity``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_interactivity> with get
            abstract ``KHR_lights``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_lights> with get
            abstract ``KHR_materials_anisotropy``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_anisotropy> with get
            abstract ``KHR_materials_clearcoat``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_clearcoat> with get
            abstract ``KHR_materials_coat``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_coat> with get
            abstract ``KHR_materials_diffuse_roughness``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_diffuse_roughness> with get
            abstract ``KHR_materials_diffuse_transmission``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_diffuse_transmission> with get
            abstract ``KHR_materials_dispersion``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_dispersion> with get
            abstract ``KHR_materials_emissive_strength``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_emissive_strength> with get
            abstract ``KHR_materials_fuzz``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_fuzz> with get
            abstract ``KHR_materials_ior``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_ior> with get
            abstract ``KHR_materials_iridescence``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_iridescence> with get
            abstract ``KHR_materials_pbrSpecularGlossiness``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_pbrSpecularGlossiness> with get
            abstract ``KHR_materials_sheen``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_sheen> with get
            abstract ``KHR_materials_specular``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_specular> with get
            abstract ``KHR_materials_transmission``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_transmission> with get
            abstract ``KHR_materials_unlit``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_unlit> with get
            abstract ``KHR_materials_variants``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_variants> with get
            abstract ``KHR_materials_volume``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_volume> with get
            abstract ``KHR_materials_volume_scatter``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_materials_volume_scatter> with get
            abstract ``KHR_mesh_quantization``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_mesh_quantization> with get
            abstract ``KHR_node_hoverability``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_node_hoverability> with get
            abstract ``KHR_node_selectability``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_node_selectability> with get
            abstract ``KHR_node_visibility``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_node_visibility> with get
            abstract ``KHR_texture_basisu``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_texture_basisu> with get
            abstract ``KHR_texture_transform``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_texture_transform> with get
            abstract ``KHR_xmp_json_ld``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.KHR_xmp_json_ld> with get
            abstract ``LoadBoundingInfoFromPositionAccessor``: BabylonjsBindings.SimpleFunctions.FunctionBinding_LoadBoundingInfoFromPositionAccessor with get
            abstract ``MSFT_audio_emitter``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.MSFT_audio_emitter> with get
            abstract ``MSFT_lod``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.MSFT_lod> with get
            abstract ``MSFT_minecraftMesh``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.MSFT_minecraftMesh> with get
            abstract ``MSFT_sRGBFactors``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.MSFT_sRGBFactors> with get
            abstract ``OpenPBRMaterialLoadingAdapter``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.OpenPBRMaterialLoadingAdapter> with get
            abstract ``PBRMaterialLoadingAdapter``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.PBRMaterialLoadingAdapter> with get
            abstract ``RegisterEXT_lights_area``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterEXT_lights_area with get
            abstract ``RegisterEXT_lights_ies``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterEXT_lights_ies with get
            abstract ``RegisterEXT_lights_image_based``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterEXT_lights_image_based with get
            abstract ``RegisterEXT_mesh_gpu_instancing``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterEXT_mesh_gpu_instancing with get
            abstract ``RegisterEXT_meshopt_compression``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterEXT_meshopt_compression with get
            abstract ``RegisterEXT_texture_avif``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterEXT_texture_avif with get
            abstract ``RegisterEXT_texture_webp``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterEXT_texture_webp with get
            abstract ``RegisterExtrasAsMetadata``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterExtrasAsMetadata with get
            abstract ``RegisterGLTF2Loader``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterGLTF2Loader with get
            abstract ``RegisterKHR_animation_pointer``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_animation_pointer with get
            abstract ``RegisterKHR_draco_mesh_compression``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_draco_mesh_compression with get
            abstract ``RegisterKHR_gaussian_splatting``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_gaussian_splatting with get
            abstract ``RegisterKHR_interactivity``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_interactivity with get
            abstract ``RegisterKHR_lights``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_lights with get
            abstract ``RegisterKHR_materials_anisotropy``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_anisotropy with get
            abstract ``RegisterKHR_materials_clearcoat``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_clearcoat with get
            abstract ``RegisterKHR_materials_coat``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_coat with get
            abstract ``RegisterKHR_materials_diffuse_roughness``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_diffuse_roughness with get
            abstract ``RegisterKHR_materials_diffuse_transmission``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_diffuse_transmission with get
            abstract ``RegisterKHR_materials_dispersion``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_dispersion with get
            abstract ``RegisterKHR_materials_emissive_strength``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_emissive_strength with get
            abstract ``RegisterKHR_materials_fuzz``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_fuzz with get
            abstract ``RegisterKHR_materials_ior``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_ior with get
            abstract ``RegisterKHR_materials_iridescence``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_iridescence with get
            abstract ``RegisterKHR_materials_pbrSpecularGlossiness``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_pbrSpecularGlossiness with get
            abstract ``RegisterKHR_materials_sheen``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_sheen with get
            abstract ``RegisterKHR_materials_specular``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_specular with get
            abstract ``RegisterKHR_materials_transmission``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_transmission with get
            abstract ``RegisterKHR_materials_unlit``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_unlit with get
            abstract ``RegisterKHR_materials_variants``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_variants with get
            abstract ``RegisterKHR_materials_volume``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_volume with get
            abstract ``RegisterKHR_materials_volume_scatter``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_materials_volume_scatter with get
            abstract ``RegisterKHR_mesh_quantization``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_mesh_quantization with get
            abstract ``RegisterKHR_node_hoverability``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_node_hoverability with get
            abstract ``RegisterKHR_node_selectability``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_node_selectability with get
            abstract ``RegisterKHR_node_visibility``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_node_visibility with get
            abstract ``RegisterKHR_texture_basisu``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_texture_basisu with get
            abstract ``RegisterKHR_texture_transform``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_texture_transform with get
            abstract ``RegisterKHR_xmp_json_ld``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterKHR_xmp_json_ld with get
            abstract ``RegisterMSFT_audio_emitter``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterMSFT_audio_emitter with get
            abstract ``RegisterMSFT_lod``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterMSFT_lod with get
            abstract ``RegisterMSFT_minecraftMesh``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterMSFT_minecraftMesh with get
            abstract ``RegisterMSFT_sRGBFactors``: BabylonjsBindings.SimpleFunctions.FunctionBinding_RegisterMSFT_sRGBFactors with get
            abstract ``SetInterpolationForKey``: BabylonjsBindings.SimpleFunctions.FunctionBinding_SetInterpolationForKey with get
            abstract ``TransformNodeAnimationPropertyInfo``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.TransformNodeAnimationPropertyInfo> with get
            abstract ``TransmissionHelper``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.TransmissionHelper> with get
            abstract ``WeightAnimationPropertyInfo``: JavaScriptConstructor<BabylonjsBindings.SimpleClasses.WeightAnimationPropertyInfo> with get
            abstract ``_AddInteractivityObjectModel``: BabylonjsBindings.SimpleFunctions.FunctionBinding__AddInteractivityObjectModel with get
            abstract ``addNewInteractivityFlowGraphMapping``: BabylonjsBindings.SimpleFunctions.FunctionBinding_addNewInteractivityFlowGraphMapping with get
            abstract ``ensureTransmissionHelper``: BabylonjsBindings.SimpleFunctions.FunctionBinding_ensureTransmissionHelper with get
            abstract ``getAllSupportedNativeNodeTypes``: BabylonjsBindings.SimpleFunctions.FunctionBinding_getAllSupportedNativeNodeTypes with get
            abstract ``getMappingForDeclaration``: BabylonjsBindings.SimpleFunctions.FunctionBinding_getMappingForDeclaration with get
            abstract ``getMappingForFullOperationName``: BabylonjsBindings.SimpleFunctions.FunctionBinding_getMappingForFullOperationName with get
            abstract ``getQuaternion``: BabylonjsBindings.SimpleFunctions.FunctionBinding_getQuaternion with get
            abstract ``getVector3``: BabylonjsBindings.SimpleFunctions.FunctionBinding_getVector3 with get
            abstract ``getWeights``: BabylonjsBindings.SimpleFunctions.FunctionBinding_getWeights with get
            abstract ``gltfTypeToBabylonType``: BabylonjsBindings.SimpleVariables.VariableShape_gltfTypeToBabylonType with get
            abstract ``registerGLTFExtension``: BabylonjsBindings.SimpleFunctions.FunctionBinding_registerGLTFExtension with get
            abstract ``registeredGLTFExtensions``: BabylonjsBindings.SimpleVariables.VariableShape_registeredGLTFExtensions with get
            abstract ``unregisterGLTFExtension``: BabylonjsBindings.SimpleFunctions.FunctionBinding_unregisterGLTFExtension with get

        [<Import("GLTF2", "@babylonjs/loaders/glTF/index.js")>]
        let runtime: RuntimeNamespace = jsNative

