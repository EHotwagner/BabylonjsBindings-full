// REVIEW-ONLY GENERATED LOADERS CANDIDATE — NOT COMPILED INTO THE PACKAGE
// source babylonjs-loaders@9.19.0 babylonjs.loaders.module.d.ts sha256: 7cd12a3b7152867f045ad440581ec8cdad0d9cb30305e3de5229b9149d5dbffb
// generator ts2fable@0.9.0-build.738 with typescript@5.1.6
module rec BabylonjsBindings.FullLoadersCandidate

#nowarn "3390"

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open BabylonjsBindings.FullCandidate

[<Erase>] type KeyOf<'T> = Key of string
type Array<'T> = System.Collections.Generic.IList<'T>
type ArrayLike<'T> = System.Collections.Generic.IList<'T>
type ReadonlyMap<'K, 'V> = Map<'K, 'V>
type RegExp = System.Text.RegularExpressions.Regex

let [<ImportAll("@babylonjs/loaders/dynamic.js")>] ``babylonjs-loaders/dynamic``: Babylonjs_loaders_dynamic.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/legacy/legacy-glTF2.js")>] ``babylonjs-loaders/legacy/legacy-glTF2``: Babylonjs_loaders_legacy_legacy_glTF2.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/glTFValidation.js")>] ``babylonjs-loaders/glTF/glTFValidation``: Babylonjs_loaders_glTF_glTFValidation.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/glTFFileLoader.pure.js")>] ``babylonjs-loaders/glTF/glTFFileLoader.pure``: Babylonjs_loaders_glTF_glTFFileLoader_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/glTFFileLoader.metadata.js")>] ``babylonjs-loaders/glTF/glTFFileLoader.metadata``: Babylonjs_loaders_glTF_glTFFileLoader_metadata.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/pbrMaterialLoadingAdapter.js")>] ``babylonjs-loaders/glTF/2.0/pbrMaterialLoadingAdapter``: Babylonjs_loaders_glTF_2_0_pbrMaterialLoadingAdapter.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/openpbrMaterialLoadingAdapter.js")>] ``babylonjs-loaders/glTF/2.0/openpbrMaterialLoadingAdapter``: Babylonjs_loaders_glTF_2_0_openpbrMaterialLoadingAdapter.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/glTFLoaderExtensionRegistry.js")>] ``babylonjs-loaders/glTF/2.0/glTFLoaderExtensionRegistry``: Babylonjs_loaders_glTF_2_0_glTFLoaderExtensionRegistry.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/glTFLoaderAnimation.js")>] ``babylonjs-loaders/glTF/2.0/glTFLoaderAnimation``: Babylonjs_loaders_glTF_2_0_glTFLoaderAnimation.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/glTFLoader.pure.js")>] ``babylonjs-loaders/glTF/2.0/glTFLoader.pure``: Babylonjs_loaders_glTF_2_0_glTFLoader_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/transmissionHelper.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/transmissionHelper``: Babylonjs_loaders_glTF_2_0_Extensions_transmissionHelper.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/objectModelMapping``: Babylonjs_loaders_glTF_2_0_Extensions_objectModelMapping.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/gltfPathToObjectConverter.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/gltfPathToObjectConverter``: Babylonjs_loaders_glTF_2_0_Extensions_gltfPathToObjectConverter.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/dynamic.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/dynamic``: Babylonjs_loaders_glTF_2_0_Extensions_dynamic.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/MSFT_sRGBFactors.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/MSFT_sRGBFactors.pure``: Babylonjs_loaders_glTF_2_0_Extensions_MSFT_sRGBFactors_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/MSFT_minecraftMesh.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/MSFT_minecraftMesh.pure``: Babylonjs_loaders_glTF_2_0_Extensions_MSFT_minecraftMesh_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/MSFT_lod.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/MSFT_lod.pure``: Babylonjs_loaders_glTF_2_0_Extensions_MSFT_lod_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/MSFT_audio_emitter.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/MSFT_audio_emitter.pure``: Babylonjs_loaders_glTF_2_0_Extensions_MSFT_audio_emitter_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_xmp_json_ld.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_xmp_json_ld.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_xmp_json_ld_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_texture_transform.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_texture_transform.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_texture_transform_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_texture_basisu.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_texture_basisu.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_texture_basisu_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_node_visibility.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_node_visibility.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_visibility_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_node_selectability.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_node_selectability.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_selectability_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_node_hoverability.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_node_hoverability.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_hoverability_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_mesh_quantization.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_mesh_quantization.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_mesh_quantization_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_volume_scatter.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_volume_scatter.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_volume_scatter_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_volume.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_volume.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_volume_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_variants.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_variants.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_variants_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_unlit.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_unlit.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_unlit_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_transmission.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_transmission.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_transmission_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_specular.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_specular.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_specular_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_sheen.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_sheen.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_sheen_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_pbrSpecularGlossiness.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_pbrSpecularGlossiness.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_pbrSpecularGlossiness_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_iridescence.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_iridescence.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_iridescence_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_ior.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_ior.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_ior_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_fuzz.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_fuzz.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_fuzz_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_emissive_strength.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_emissive_strength.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_emissive_strength_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_dispersion.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_dispersion.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_dispersion_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_diffuse_transmission.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_diffuse_transmission.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_diffuse_transmission_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_diffuse_roughness.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_diffuse_roughness.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_diffuse_roughness_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_coat.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_coat.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_coat_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_clearcoat.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_clearcoat.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_clearcoat_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_anisotropy.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_materials_anisotropy.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_anisotropy_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_lights_punctual.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_lights_punctual.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_lights_punctual_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_interactivity.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_gaussian_splatting.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_gaussian_splatting.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_gaussian_splatting_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_draco_mesh_compression.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_draco_mesh_compression.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_draco_mesh_compression_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_animation_pointer.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_animation_pointer.pure``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_animation_pointer_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/ExtrasAsMetadata.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/ExtrasAsMetadata.pure``: Babylonjs_loaders_glTF_2_0_Extensions_ExtrasAsMetadata_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/EXT_texture_webp.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/EXT_texture_webp.pure``: Babylonjs_loaders_glTF_2_0_Extensions_EXT_texture_webp_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/EXT_texture_avif.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/EXT_texture_avif.pure``: Babylonjs_loaders_glTF_2_0_Extensions_EXT_texture_avif_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/EXT_meshopt_compression.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/EXT_meshopt_compression.pure``: Babylonjs_loaders_glTF_2_0_Extensions_EXT_meshopt_compression_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/EXT_mesh_gpu_instancing.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/EXT_mesh_gpu_instancing.pure``: Babylonjs_loaders_glTF_2_0_Extensions_EXT_mesh_gpu_instancing_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_image_based.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/EXT_lights_image_based.pure``: Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_image_based_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_ies.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/EXT_lights_ies.pure``: Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_ies_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_area.pure.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/EXT_lights_area.pure``: Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_area_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/interactivityGraphParser.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_interactivity/interactivityGraphParser``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_interactivityGraphParser.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/flowGraphGLTFDataProvider.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_interactivity/flowGraphGLTFDataProvider``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_flowGraphGLTFDataProvider.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/declarationMapper.js")>] ``babylonjs-loaders/glTF/2.0/Extensions/KHR_interactivity/declarationMapper``: Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_declarationMapper.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/1.0/glTFMaterialsCommonExtension.js")>] ``babylonjs-loaders/glTF/1.0/glTFMaterialsCommonExtension``: Babylonjs_loaders_glTF_1_0_glTFMaterialsCommonExtension.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/1.0/glTFLoaderUtils.js")>] ``babylonjs-loaders/glTF/1.0/glTFLoaderUtils``: Babylonjs_loaders_glTF_1_0_glTFLoaderUtils.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/1.0/glTFLoader.js")>] ``babylonjs-loaders/glTF/1.0/glTFLoader``: Babylonjs_loaders_glTF_1_0_glTFLoader.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/glTF/1.0/glTFBinaryExtension.js")>] ``babylonjs-loaders/glTF/1.0/glTFBinaryExtension``: Babylonjs_loaders_glTF_1_0_glTFBinaryExtension.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/STL/stlFileLoader.pure.js")>] ``babylonjs-loaders/STL/stlFileLoader.pure``: Babylonjs_loaders_STL_stlFileLoader_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/STL/stlFileLoader.metadata.js")>] ``babylonjs-loaders/STL/stlFileLoader.metadata``: Babylonjs_loaders_STL_stlFileLoader_metadata.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/spz.js")>] ``babylonjs-loaders/SPLAT/spz``: Babylonjs_loaders_SPLAT_spz.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/splatFileLoader.pure.js")>] ``babylonjs-loaders/SPLAT/splatFileLoader.pure``: Babylonjs_loaders_SPLAT_splatFileLoader_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/splatFileLoader.metadata.js")>] ``babylonjs-loaders/SPLAT/splatFileLoader.metadata``: Babylonjs_loaders_SPLAT_splatFileLoader_metadata.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/sog.pure.js")>] ``babylonjs-loaders/SPLAT/sog.pure``: Babylonjs_loaders_SPLAT_sog_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/gaussianSplattingWorkBufferShaders.js")>] ``babylonjs-loaders/SPLAT/gaussianSplattingWorkBufferShaders``: Babylonjs_loaders_SPLAT_gaussianSplattingWorkBufferShaders.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/gaussianSplattingWorkBuffer.js")>] ``babylonjs-loaders/SPLAT/gaussianSplattingWorkBuffer``: Babylonjs_loaders_SPLAT_gaussianSplattingWorkBuffer.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/gaussianSplattingStream.js")>] ``babylonjs-loaders/SPLAT/gaussianSplattingStream``: Babylonjs_loaders_SPLAT_gaussianSplattingStream.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/gaussianSplattingResidencyController.js")>] ``babylonjs-loaders/SPLAT/gaussianSplattingResidencyController``: Babylonjs_loaders_SPLAT_gaussianSplattingResidencyController.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/gaussianSplattingDownloadManager.js")>] ``babylonjs-loaders/SPLAT/gaussianSplattingDownloadManager``: Babylonjs_loaders_SPLAT_gaussianSplattingDownloadManager.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/SPLAT/gaussianSplattingBlockAllocator.js")>] ``babylonjs-loaders/SPLAT/gaussianSplattingBlockAllocator``: Babylonjs_loaders_SPLAT_gaussianSplattingBlockAllocator.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/OBJ/solidParser.js")>] ``babylonjs-loaders/OBJ/solidParser``: Babylonjs_loaders_OBJ_solidParser.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/OBJ/objFileLoader.pure.js")>] ``babylonjs-loaders/OBJ/objFileLoader.pure``: Babylonjs_loaders_OBJ_objFileLoader_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/OBJ/objFileLoader.metadata.js")>] ``babylonjs-loaders/OBJ/objFileLoader.metadata``: Babylonjs_loaders_OBJ_objFileLoader_metadata.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/OBJ/mtlFileLoader.js")>] ``babylonjs-loaders/OBJ/mtlFileLoader``: Babylonjs_loaders_OBJ_mtlFileLoader.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/fbxFileLoader.pure.js")>] ``babylonjs-loaders/FBX/fbxFileLoader.pure``: Babylonjs_loaders_FBX_fbxFileLoader_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/fbxFileLoader.metadata.js")>] ``babylonjs-loaders/FBX/fbxFileLoader.metadata``: Babylonjs_loaders_FBX_fbxFileLoader_metadata.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/types/fbxTypes.js")>] ``babylonjs-loaders/FBX/types/fbxTypes``: Babylonjs_loaders_FBX_types_fbxTypes.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/parsers/zlibInflate.js")>] ``babylonjs-loaders/FBX/parsers/zlibInflate``: Babylonjs_loaders_FBX_parsers_zlibInflate.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/parsers/fbxBinaryParser.js")>] ``babylonjs-loaders/FBX/parsers/fbxBinaryParser``: Babylonjs_loaders_FBX_parsers_fbxBinaryParser.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/parsers/fbxAsciiParser.js")>] ``babylonjs-loaders/FBX/parsers/fbxAsciiParser``: Babylonjs_loaders_FBX_parsers_fbxAsciiParser.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/transform.js")>] ``babylonjs-loaders/FBX/interpreter/transform``: Babylonjs_loaders_FBX_interpreter_transform.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/skeleton.js")>] ``babylonjs-loaders/FBX/interpreter/skeleton``: Babylonjs_loaders_FBX_interpreter_skeleton.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/sceneDiagnostics.js")>] ``babylonjs-loaders/FBX/interpreter/sceneDiagnostics``: Babylonjs_loaders_FBX_interpreter_sceneDiagnostics.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/rig.js")>] ``babylonjs-loaders/FBX/interpreter/rig``: Babylonjs_loaders_FBX_interpreter_rig.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/propertyTemplates.js")>] ``babylonjs-loaders/FBX/interpreter/propertyTemplates``: Babylonjs_loaders_FBX_interpreter_propertyTemplates.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/materials.js")>] ``babylonjs-loaders/FBX/interpreter/materials``: Babylonjs_loaders_FBX_interpreter_materials.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/geometry.js")>] ``babylonjs-loaders/FBX/interpreter/geometry``: Babylonjs_loaders_FBX_interpreter_geometry.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/fbxInterpreter.js")>] ``babylonjs-loaders/FBX/interpreter/fbxInterpreter``: Babylonjs_loaders_FBX_interpreter_fbxInterpreter.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/connections.js")>] ``babylonjs-loaders/FBX/interpreter/connections``: Babylonjs_loaders_FBX_interpreter_connections.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/blendShapes.js")>] ``babylonjs-loaders/FBX/interpreter/blendShapes``: Babylonjs_loaders_FBX_interpreter_blendShapes.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/FBX/interpreter/animation.js")>] ``babylonjs-loaders/FBX/interpreter/animation``: Babylonjs_loaders_FBX_interpreter_animation.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/BVH/bvhLoader.js")>] ``babylonjs-loaders/BVH/bvhLoader``: Babylonjs_loaders_BVH_bvhLoader.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/BVH/bvhFileLoader.pure.js")>] ``babylonjs-loaders/BVH/bvhFileLoader.pure``: Babylonjs_loaders_BVH_bvhFileLoader_pure.IExports = jsNative
let [<ImportAll("@babylonjs/loaders/BVH/bvhFileLoader.metadata.js")>] ``babylonjs-loaders/BVH/bvhFileLoader.metadata``: Babylonjs_loaders_BVH_bvhFileLoader_metadata.IExports = jsNative

module Babylonjs_loaders_dynamic =

    type [<AllowNullLiteral>] IExports =
        abstract registerBuiltInLoaders: unit -> unit

module Babylonjs_loaders_legacy_legacy_glTF2 =
    module GLTF2 = Babylonjs_loaders_glTF_2_0_glTFLoader_pure

    type [<AllowNullLiteral>] IExports =
        abstract GLTF2Legacy: obj

module Babylonjs_loaders_legacy_legacy_glTF1 =
    module GLTF1 = Babylonjs_loaders_glTF_1_0_glTFLoader

module Babylonjs_loaders_glTF_pure =
    module GLTF1 = Babylonjs_loaders_glTF_1_0_glTFLoader
    module GLTF2 = Babylonjs_loaders_glTF_2_0_glTFLoader_pure

module Babylonjs_loaders_glTF_index =
    module GLTF1 = Babylonjs_loaders_glTF_1_0_glTFLoader
    module GLTF2 = Babylonjs_loaders_glTF_2_0_glTFLoader_pure

module Babylonjs_loaders_glTF_glTFValidation =
    module GLTF2 = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2
    type Nullable<'T> = 'T

    type [<AllowNullLiteral>] IExports =
        abstract GLTFValidation: GLTFValidationStatic

    type [<AllowNullLiteral>] IGLTFValidationConfiguration =
        abstract url: string with get, set

    type [<AllowNullLiteral>] GLTFValidation =
        interface end

    type [<AllowNullLiteral>] GLTFValidationStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFValidation
        abstract Configuration: IGLTFValidationConfiguration with get, set
        abstract _LastResults: Nullable<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults> with get, set
        abstract ValidateAsync: data: U2<string, Uint8Array> * rootUrl: string * fileName: string * getExternalResource: (string -> Promise<Uint8Array>) -> Promise<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults>

module Babylonjs_loaders_glTF_glTFFileLoader_types =
    type GLTFFileLoaderMetadata = obj
    type GLTFLoaderOptions = Babylonjs_loaders_glTF_glTFFileLoader_pure.GLTFLoaderOptions

    module Babylonjs_Loading_sceneLoader =

        type [<AllowNullLiteral>] SceneLoaderPluginOptions =
            abstract ``[GLTFFileLoaderMetadata.name]``: obj with get, set

module Babylonjs_loaders_glTF_glTFFileLoader_pure =
    module GLTF2 = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2
    type Nullable<'T> = 'T
    type Observable<'T> = BabylonjsBindings.FullCandidate.BABYLON.Observable<'T>
    type Camera = obj
    type BaseTexture = obj
    type Material = obj
    type AbstractMesh = obj
    type ISceneLoaderPluginFactory = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginFactory
    type ISceneLoaderPluginAsync = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginAsync
    type ISceneLoaderProgressEvent = obj
    type ISceneLoaderAsyncResult = obj
    type SceneLoaderPluginOptions = obj
    type AssetContainer = obj
    type Scene = obj
    type IDisposable = BabylonjsBindings.FullCandidate.BABYLON.IDisposable
    type WebRequest = obj
    type IFileRequest = obj
    type IDataBuffer = obj
    type LoadFileError = obj
    type TransformNode = obj

    type [<AllowNullLiteral>] IExports =
        abstract GLTFLoaderBaseOptions: GLTFLoaderBaseOptionsStatic
        abstract GLTFLoaderDefaultOptions: GLTFLoaderBaseOptions
        abstract GLTFLoaderOptions: GLTFLoaderOptionsStatic
        abstract GLTFFileLoader: GLTFFileLoaderStatic
        abstract RegisterGLTFFileLoader: unit -> unit

    type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
        inherit Record<string, Record<string, obj> option>

    type GLTFLoaderCoordinateSystemMode =
        | AUTO = 0
        | FORCE_RIGHT_HANDED = 1

    type GLTFLoaderAnimationStartMode =
        | NONE = 0
        | FIRST = 1
        | ALL = 2

    type [<AllowNullLiteral>] IGLTFLoaderData =
        abstract json: obj with get, set
        abstract bin: Nullable<IDataBuffer> with get, set

    type [<AllowNullLiteral>] IGLTFLoaderExtension =
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float option with get, set

    type GLTFLoaderState =
        | LOADING = 0
        | READY = 1
        | COMPLETE = 2

    type [<AllowNullLiteral>] IGLTFLoader =
        inherit IDisposable
        abstract importMeshAsync: (U2<string, ResizeArray<string>> option -> Scene -> Nullable<AssetContainer> -> IGLTFLoaderData -> string -> ((ISceneLoaderProgressEvent -> unit)) option -> (string) option -> Promise<ISceneLoaderAsyncResult>) with get, set
        abstract loadAsync: (Scene -> IGLTFLoaderData -> string -> ((ISceneLoaderProgressEvent -> unit)) option -> (string) option -> Promise<unit>) with get, set

    type [<AllowNullLiteral>] DefaultExtensionOptions<'BaseExtensionOptions> =
        interface end

    type [<AllowNullLiteral>] GLTFLoaderBaseOptions =
        abstract alwaysComputeBoundingBox: bool with get, set
        abstract alwaysComputeSkeletonRootNode: bool with get, set
        abstract animationStartMode: GLTFLoaderAnimationStartMode with get, set
        abstract compileMaterials: bool with get, set
        abstract compileShadowGenerators: bool with get, set
        abstract coordinateSystemMode: GLTFLoaderCoordinateSystemMode with get, set
        abstract createInstances: bool with get, set
        abstract loadAllMaterials: bool with get, set
        abstract loadMorphTargets: bool with get, set
        abstract useMaxMorphTargetInfluencers: bool with get, set
        abstract loadNodeAnimations: bool with get, set
        abstract loadOnlyMaterials: bool with get, set
        abstract loadSkins: bool with get, set
        abstract skipMaterials: bool with get, set
        abstract targetFps: float with get, set
        abstract transparencyAsCoverage: bool with get, set
        abstract useClipPlane: bool with get, set
        abstract useGltfTextureNames: bool with get, set
        abstract useRangeRequests: bool with get, set
        abstract useSRGBBuffers: bool with get, set
        abstract validate: bool with get, set
        abstract useOpenPBR: bool with get, set
        abstract dontUseTransmissionHelper: bool with get, set

    type [<AllowNullLiteral>] GLTFLoaderBaseOptionsStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFLoaderBaseOptions

    type [<AllowNullLiteral>] GLTFLoaderOptions =
        inherit GLTFLoaderBaseOptions
        abstract copyFrom: ?options: obj -> unit
        abstract onParsed: (IGLTFLoaderData -> unit) option with get, set
        abstract capturePerformanceCounters: bool with get, set
        abstract customRootNode: Nullable<TransformNode> option with get, set
        abstract extensionOptions: obj with get, set
        abstract loggingEnabled: bool with get, set
        abstract onCameraLoaded: (Camera -> unit) option with get, set
        abstract onMaterialLoaded: (Material -> unit) option with get, set
        abstract onMeshLoaded: (AbstractMesh -> unit) option with get, set
        abstract onSkinLoaded: (TransformNode -> TransformNode -> unit) option with get, set
        abstract onTextureLoaded: (BaseTexture -> unit) option with get, set
        abstract onValidated: (BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults -> unit) option with get, set
        abstract preprocessUrlAsync: (string -> Promise<string>) with get, set

    type [<AllowNullLiteral>] GLTFLoaderOptionsStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFLoaderOptions

    type [<AllowNullLiteral>] GLTFFileLoader =
        inherit GLTFLoaderOptions
        inherit IDisposable
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract onParsedObservable: Observable<IGLTFLoaderData> with get, set
        abstract onParsed: (IGLTFLoaderData -> unit) option with set
        abstract onMeshLoadedObservable: Observable<AbstractMesh>
        abstract onMeshLoaded: (AbstractMesh -> unit) option with set
        abstract onSkinLoadedObservable: Observable<{| node: TransformNode; skinnedNode: TransformNode |}>
        abstract onSkinLoaded: (TransformNode -> TransformNode -> unit) option with set
        abstract onTextureLoadedObservable: Observable<BaseTexture>
        abstract onTextureLoaded: (BaseTexture -> unit) option with set
        abstract onMaterialLoadedObservable: Observable<Material>
        abstract onMaterialLoaded: (Material -> unit) option with set
        abstract onCameraLoadedObservable: Observable<Camera>
        abstract onCameraLoaded: (Camera -> unit) option with set
        abstract onCompleteObservable: Observable<unit>
        abstract onComplete: (unit -> unit) with set
        abstract onErrorObservable: Observable<obj option>
        abstract onError: (obj option -> unit) with set
        abstract onDisposeObservable: Observable<unit>
        abstract onDispose: (unit -> unit) with set
        abstract onExtensionLoadedObservable: Observable<IGLTFLoaderExtension>
        abstract onExtensionLoaded: (IGLTFLoaderExtension -> unit) with set
        abstract loggingEnabled: bool with get, set
        abstract capturePerformanceCounters: bool with get, set
        abstract onValidatedObservable: Observable<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults>
        abstract onValidated: (BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults -> unit) with set
        abstract name: string
        abstract extensions: {| ``.gltf``: {| isBinary: bool; mimeType: string |}; ``.glb``: {| isBinary: bool; mimeType: string |} |}
        abstract dispose: unit -> unit
        abstract loadFile: scene: Scene * fileOrUrl: U3<File, string, ArrayBufferView> * rootUrl: string * onSuccess: (obj -> (string) option -> unit) * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?useArrayBuffer: bool * ?onError: ((WebRequest) option -> (LoadFileError) option -> unit) * ?name: string -> Nullable<IFileRequest>
        abstract importMeshAsync: meshesNames: U2<string, ResizeArray<string>> option * scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<unit>
        abstract loadAssetContainerAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<AssetContainer>
        abstract canDirectLoad: data: string -> bool
        abstract directLoad: scene: Scene * data: string -> Promise<obj>
        abstract rewriteRootURL: rootUrl: string * ?responseURL: string -> string
        abstract createPlugin: options: SceneLoaderPluginOptions -> ISceneLoaderPluginAsync
        abstract loaderState: Nullable<GLTFLoaderState>
        abstract onLoaderStateChangedObservable: Observable<Nullable<GLTFLoaderState>> with get, set
        abstract whenCompleteAsync: unit -> Promise<unit>
        abstract _setState: state: GLTFLoaderState -> unit
        abstract _loadFile: scene: Scene * fileOrUrl: U2<File, string> * onSuccess: (U2<string, ArrayBuffer> -> unit) * ?useArrayBuffer: bool * ?onError: ((WebRequest) option -> unit) * ?onOpened: (WebRequest -> unit) -> IFileRequest
        abstract _log: (string -> unit) with get, set
        abstract _logOpen: message: string -> unit
        abstract _logClose: unit -> unit
        abstract _startPerformanceCounter: (string -> unit) with get, set
        abstract _endPerformanceCounter: (string -> unit) with get, set

    type [<AllowNullLiteral>] GLTFFileLoaderStatic =
        abstract _CreateGLTF1Loader: (GLTFFileLoader -> IGLTFLoader) with get, set
        abstract _CreateGLTF2Loader: (GLTFFileLoader -> IGLTFLoader) with get, set
        [<EmitConstructor>] abstract Create: ?options: obj -> GLTFFileLoader
        abstract IncrementalLoading: bool with get, set
        abstract HomogeneousCoordinates: bool with get, set

module Babylonjs_loaders_glTF_glTFFileLoader_metadata =

    type [<AllowNullLiteral>] IExports =
        abstract GLTFMagicBase64Encoded: obj
        abstract GLTFFileLoaderMetadata: {| name: string; extensions: {| ``.gltf``: {| isBinary: bool; mimeType: string |}; ``.glb``: {| isBinary: bool; mimeType: string |} |}; canDirectLoad: string -> bool |}

module Babylonjs_loaders_glTF_2_0_pbrMaterialLoadingAdapter =
    type PBRMaterial = obj
    type Material = obj
    type BaseTexture = obj
    type Nullable<'T> = 'T
    type Color3 = obj
    type IMaterialLoadingAdapter = Babylonjs_loaders_glTF_2_0_materialLoadingAdapter.IMaterialLoadingAdapter
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract PBRMaterialLoadingAdapter: PBRMaterialLoadingAdapterStatic

    type [<AllowNullLiteral>] PBRMaterialLoadingAdapter =
        inherit IMaterialLoadingAdapter
        abstract material: PBRMaterial
        abstract finalizeAsync: _loader: GLTFLoader -> Promise<unit>
        abstract isUnlit: bool with get, set
        abstract backFaceCulling: bool with get, set
        abstract twoSidedLighting: bool with get, set
        abstract alphaCutOff: float with get, set
        abstract useAlphaFromBaseColorTexture: bool with get, set
        abstract transparencyAsAlphaCoverage: bool with get, set
        abstract baseColor: Color3 with get, set
        abstract baseColorTexture: Nullable<BaseTexture> with get, set
        abstract baseDiffuseRoughness: float with get, set
        abstract baseDiffuseRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract baseMetalness: float with get, set
        abstract baseMetalnessTexture: Nullable<BaseTexture> with get, set
        abstract useRoughnessFromMetallicTextureGreen: bool with set
        abstract useMetallicFromMetallicTextureBlue: bool with set
        abstract enableSpecularEdgeColor: ?enableEdgeColor: bool -> unit
        abstract configureSpecularGlossiness: unit -> unit
        abstract specularWeight: float with get, set
        abstract specularWeightTexture: Nullable<BaseTexture> with get, set
        abstract specularColor: Color3 with get, set
        abstract specularColorTexture: Nullable<BaseTexture> with get, set
        abstract specularRoughness: float with get, set
        abstract specularRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract specularIor: float with get, set
        abstract glossiness: float with get, set
        abstract emissionColor: Color3 with get, set
        abstract emissionLuminance: float with get, set
        abstract emissionColorTexture: Nullable<BaseTexture> with get, set
        abstract ambientOcclusionTexture: Nullable<BaseTexture> with get, set
        abstract ambientOcclusionTextureStrength: float with get, set
        abstract configureCoat: unit -> unit
        abstract coatWeight: float with get, set
        abstract coatWeightTexture: Nullable<BaseTexture> with get, set
        abstract coatColor: Color3 with set
        abstract coatColorTexture: Nullable<BaseTexture> with set
        abstract coatRoughness: float with get, set
        abstract coatRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract coatIor: float with set
        abstract coatDarkening: float with set
        abstract coatDarkeningTexture: Nullable<BaseTexture> with set
        abstract coatRoughnessAnisotropy: float with get, set
        abstract geometryCoatTangentAngle: float with set
        abstract geometryCoatTangentTexture: Nullable<BaseTexture> with get, set
        abstract transmissionWeight: float with get, set
        abstract transmissionWeightTexture: Nullable<BaseTexture> with set
        abstract transmissionDepth: float with get, set
        abstract transmissionColor: Color3 with get, set
        abstract transmissionScatter: Color3 with get, set
        abstract transmissionScatterTexture: Nullable<BaseTexture> with set
        abstract transmissionScatterAnisotropy: float with set
        abstract transmissionDispersionAbbeNumber: float with set
        abstract transmissionDispersionScale: float with set
        abstract refractionBackgroundTexture: Nullable<BaseTexture> with get, set
        abstract configureTransmission: unit -> unit
        abstract configureVolume: unit -> unit
        abstract geometryThinWalled: bool with get, set
        abstract volumeThicknessTexture: Nullable<BaseTexture> with set
        abstract volumeThickness: float with set
        abstract configureSubsurface: unit -> unit
        abstract subsurfaceWeight: float with get, set
        abstract subsurfaceWeightTexture: Nullable<BaseTexture> with set
        abstract subsurfaceColor: Color3 with set
        abstract subsurfaceColorTexture: Nullable<BaseTexture> with set
        abstract diffuseTransmissionTint: Color3 with get, set
        abstract diffuseTransmissionTintTexture: Nullable<BaseTexture> with set
        abstract subsurfaceRadius: float with get, set
        abstract subsurfaceRadiusScale: Color3 with get, set
        abstract subsurfaceScatterAnisotropy: float with set
        abstract isTranslucent: unit -> bool
        abstract configureFuzz: unit -> unit
        abstract fuzzWeight: float with set
        abstract fuzzWeightTexture: Nullable<BaseTexture> with set
        abstract fuzzColor: Color3 with set
        abstract fuzzColorTexture: Nullable<BaseTexture> with set
        abstract fuzzRoughness: float with set
        abstract fuzzRoughnessTexture: Nullable<BaseTexture> with set
        abstract specularRoughnessAnisotropy: float with get, set
        abstract geometryTangentAngle: float with set
        abstract geometryTangentTexture: Nullable<BaseTexture> with get, set
        abstract configureGltfStyleAnisotropy: ?useGltfStyle: bool -> unit
        abstract thinFilmWeight: float with set
        abstract thinFilmIor: float with set
        abstract thinFilmThicknessMinimum: float with set
        abstract thinFilmThicknessMaximum: float with set
        abstract thinFilmWeightTexture: Nullable<BaseTexture> with set
        abstract thinFilmThicknessTexture: Nullable<BaseTexture> with set
        abstract unlit: bool with set
        abstract geometryOpacity: float with get, set
        abstract geometryNormalTexture: Nullable<BaseTexture> with get, set
        abstract setNormalMapInversions: invertX: bool * invertY: bool -> unit
        abstract geometryCoatNormalTexture: Nullable<BaseTexture> with get, set
        abstract geometryCoatNormalTextureScale: float with set

    type [<AllowNullLiteral>] PBRMaterialLoadingAdapterStatic =
        [<EmitConstructor>] abstract Create: material: Material -> PBRMaterialLoadingAdapter

module Babylonjs_loaders_glTF_2_0_openpbrMaterialLoadingAdapter =
    type OpenPBRMaterial = obj
    type Material = obj
    type BaseTexture = obj
    type Nullable<'T> = 'T
    type Color3 = obj
    type IMaterialLoadingAdapter = Babylonjs_loaders_glTF_2_0_materialLoadingAdapter.IMaterialLoadingAdapter
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract OpenPBRMaterialLoadingAdapter: OpenPBRMaterialLoadingAdapterStatic

    type [<AllowNullLiteral>] OpenPBRMaterialLoadingAdapter =
        inherit IMaterialLoadingAdapter
        abstract material: OpenPBRMaterial
        abstract isUnlit: bool with get, set
        abstract backFaceCulling: bool with get, set
        abstract twoSidedLighting: bool with get, set
        abstract alphaCutOff: float with get, set
        abstract useAlphaFromBaseColorTexture: bool with get, set
        abstract transparencyAsAlphaCoverage: bool with get, set
        abstract baseColor: Color3 with get, set
        abstract baseColorTexture: Nullable<BaseTexture> with get, set
        abstract baseDiffuseRoughness: float with get, set
        abstract baseDiffuseRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract baseMetalness: float with get, set
        abstract baseMetalnessTexture: Nullable<BaseTexture> with get, set
        abstract useRoughnessFromMetallicTextureGreen: bool with set
        abstract useMetallicFromMetallicTextureBlue: bool with set
        abstract enableSpecularEdgeColor: ?_enableEdgeColor: bool -> unit
        abstract configureSpecularGlossiness: unit -> unit
        abstract specularWeight: float with get, set
        abstract specularWeightTexture: Nullable<BaseTexture> with get, set
        abstract specularColor: Color3 with get, set
        abstract specularColorTexture: Nullable<BaseTexture> with get, set
        abstract specularRoughness: float with get, set
        abstract specularRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract specularIor: float with get, set
        abstract glossiness: float with get, set
        abstract emissionColor: Color3 with get, set
        abstract emissionLuminance: float with get, set
        abstract emissionColorTexture: Nullable<BaseTexture> with get, set
        abstract ambientOcclusionTexture: Nullable<BaseTexture> with get, set
        abstract ambientOcclusionTextureStrength: float with get, set
        abstract configureCoat: unit -> unit
        abstract coatWeight: float with get, set
        abstract coatWeightTexture: Nullable<BaseTexture> with get, set
        abstract coatColor: Color3 with get, set
        abstract coatColorTexture: Nullable<BaseTexture> with set
        abstract coatRoughness: float with get, set
        abstract coatRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract coatIor: float with get, set
        abstract coatDarkening: float with get, set
        abstract coatDarkeningTexture: Nullable<BaseTexture> with set
        abstract coatRoughnessAnisotropy: float with get, set
        abstract geometryCoatTangentAngle: float with set
        abstract geometryCoatTangentTexture: Nullable<BaseTexture> with get, set
        abstract configureTransmission: unit -> unit
        abstract transmissionWeightTexture: Nullable<BaseTexture> with get, set
        abstract transmissionWeight: float with get, set
        abstract transmissionScatter: Color3 with get, set
        abstract transmissionScatterTexture: Nullable<BaseTexture> with get, set
        abstract transmissionScatterAnisotropy: float with set
        abstract transmissionDispersionAbbeNumber: float with set
        abstract transmissionDispersionScale: float with set
        abstract transmissionDepth: float with get, set
        abstract transmissionColor: Color3 with get, set
        abstract refractionBackgroundTexture: Nullable<BaseTexture> with get, set
        abstract configureVolume: unit -> unit
        abstract geometryThinWalled: bool with get, set
        abstract volumeThicknessTexture: Nullable<BaseTexture> with set
        abstract volumeThickness: float with set
        abstract configureSubsurface: unit -> unit
        abstract subsurfaceWeight: float with get, set
        abstract subsurfaceWeightTexture: Nullable<BaseTexture> with get, set
        abstract subsurfaceColor: Color3 with set
        abstract subsurfaceColorTexture: Nullable<BaseTexture> with set
        abstract diffuseTransmissionTint: Color3 with get, set
        abstract diffuseTransmissionTintTexture: Nullable<BaseTexture> with set
        abstract subsurfaceRadius: float with get, set
        abstract subsurfaceRadiusScale: Color3 with get, set
        abstract subsurfaceScatterAnisotropy: float with set
        abstract isTranslucent: unit -> bool
        abstract configureFuzz: unit -> unit
        abstract fuzzWeight: float with set
        abstract fuzzWeightTexture: Nullable<BaseTexture> with set
        abstract fuzzColor: Color3 with set
        abstract fuzzColorTexture: Nullable<BaseTexture> with set
        abstract fuzzRoughness: float with set
        abstract fuzzRoughnessTexture: Nullable<BaseTexture> with set
        abstract specularRoughnessAnisotropy: float with get, set
        abstract geometryTangentAngle: float with set
        abstract geometryTangentTexture: Nullable<BaseTexture> with get, set
        abstract configureGltfStyleAnisotropy: ?useGltfStyle: bool -> unit
        abstract thinFilmWeight: float with set
        abstract thinFilmIor: float with set
        abstract thinFilmThicknessMinimum: float with set
        abstract thinFilmThicknessMaximum: float with set
        abstract thinFilmWeightTexture: Nullable<BaseTexture> with set
        abstract thinFilmThicknessTexture: Nullable<BaseTexture> with set
        abstract unlit: bool with set
        abstract geometryOpacity: float with get, set
        abstract geometryNormalTexture: Nullable<BaseTexture> with get, set
        abstract setNormalMapInversions: invertX: bool * invertY: bool -> unit
        abstract geometryCoatNormalTexture: Nullable<BaseTexture> with get, set
        abstract geometryCoatNormalTextureScale: float with set
        abstract finalizeAsync: loader: GLTFLoader -> Promise<unit>

    type [<AllowNullLiteral>] OpenPBRMaterialLoadingAdapterStatic =
        [<EmitConstructor>] abstract Create: material: Material -> OpenPBRMaterialLoadingAdapter

module Babylonjs_loaders_glTF_2_0_materialLoadingAdapter =
    type Material = obj
    type BaseTexture = obj
    type Nullable<'T> = 'T
    type Color3 = obj
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IMaterialLoadingAdapter =
        abstract material: Material
        abstract finalizeAsync: loader: GLTFLoader -> Promise<unit>
        abstract isUnlit: bool with get, set
        abstract backFaceCulling: bool with get, set
        abstract twoSidedLighting: bool with get, set
        abstract alphaCutOff: float with get, set
        abstract useAlphaFromBaseColorTexture: bool with get, set
        abstract transparencyAsAlphaCoverage: bool with get, set
        abstract baseColor: Color3 with get, set
        abstract baseColorTexture: Nullable<BaseTexture> with get, set
        abstract baseDiffuseRoughness: float with get, set
        abstract baseDiffuseRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract baseMetalness: float with get, set
        abstract baseMetalnessTexture: Nullable<BaseTexture> with get, set
        abstract useRoughnessFromMetallicTextureGreen: bool with get, set
        abstract useMetallicFromMetallicTextureBlue: bool with get, set
        abstract enableSpecularEdgeColor: ?enableEdgeColor: bool -> unit
        abstract configureSpecularGlossiness: unit -> unit
        abstract specularWeight: float with get, set
        abstract specularWeightTexture: Nullable<BaseTexture> with get, set
        abstract specularColor: Color3 with get, set
        abstract specularColorTexture: Nullable<BaseTexture> with get, set
        abstract specularRoughness: float with get, set
        abstract specularRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract specularIor: float with get, set
        abstract glossiness: float with get, set
        abstract emissionColor: Color3 with get, set
        abstract emissionLuminance: float with get, set
        abstract emissionColorTexture: Nullable<BaseTexture> with get, set
        abstract ambientOcclusionTexture: Nullable<BaseTexture> with get, set
        abstract ambientOcclusionTextureStrength: float with get, set
        abstract configureCoat: unit -> unit
        abstract coatWeight: float with get, set
        abstract coatWeightTexture: Nullable<BaseTexture> with get, set
        abstract coatColor: Color3 with get, set
        abstract coatColorTexture: Nullable<BaseTexture> with get, set
        abstract coatRoughness: float with get, set
        abstract coatRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract coatIor: float with get, set
        abstract coatDarkening: float with get, set
        abstract coatDarkeningTexture: Nullable<BaseTexture> with get, set
        abstract coatRoughnessAnisotropy: float with get, set
        abstract geometryCoatTangentAngle: float with get, set
        abstract geometryCoatTangentTexture: Nullable<BaseTexture> with get, set
        abstract transmissionWeight: float with get, set
        abstract transmissionWeightTexture: Nullable<BaseTexture> with get, set
        abstract transmissionDepth: float with get, set
        abstract transmissionColor: Color3 with get, set
        abstract transmissionScatter: Color3 with get, set
        abstract transmissionScatterTexture: Nullable<BaseTexture> with get, set
        abstract transmissionScatterAnisotropy: float with get, set
        abstract transmissionDispersionAbbeNumber: float with get, set
        abstract transmissionDispersionScale: float with get, set
        abstract refractionBackgroundTexture: Nullable<BaseTexture> with get, set
        abstract configureTransmission: unit -> unit
        abstract configureVolume: unit -> unit
        abstract geometryThinWalled: bool with get, set
        abstract volumeThicknessTexture: Nullable<BaseTexture> with get, set
        abstract volumeThickness: float with get, set
        abstract configureSubsurface: unit -> unit
        abstract subsurfaceWeight: float with get, set
        abstract subsurfaceWeightTexture: Nullable<BaseTexture> with get, set
        abstract subsurfaceColor: Color3 with get, set
        abstract subsurfaceColorTexture: Nullable<BaseTexture> with get, set
        abstract diffuseTransmissionTint: Color3 with get, set
        abstract diffuseTransmissionTintTexture: Nullable<BaseTexture> with get, set
        abstract subsurfaceRadius: float with get, set
        abstract subsurfaceRadiusScale: Color3 with get, set
        abstract subsurfaceScatterAnisotropy: float with get, set
        abstract isTranslucent: unit -> bool
        abstract configureFuzz: unit -> unit
        abstract fuzzWeight: float with get, set
        abstract fuzzWeightTexture: Nullable<BaseTexture> with get, set
        abstract fuzzColor: Color3 with get, set
        abstract fuzzColorTexture: Nullable<BaseTexture> with get, set
        abstract fuzzRoughness: float with get, set
        abstract fuzzRoughnessTexture: Nullable<BaseTexture> with get, set
        abstract specularRoughnessAnisotropy: float with get, set
        abstract geometryTangentAngle: float with get, set
        abstract geometryTangentTexture: Nullable<BaseTexture> with get, set
        abstract configureGltfStyleAnisotropy: ?useGltfStyle: bool -> unit
        abstract thinFilmWeight: float with get, set
        abstract thinFilmIor: float with get, set
        abstract thinFilmThicknessMinimum: float with get, set
        abstract thinFilmThicknessMaximum: float with get, set
        abstract thinFilmWeightTexture: Nullable<BaseTexture> with get, set
        abstract thinFilmThicknessTexture: Nullable<BaseTexture> with get, set
        abstract unlit: bool with get, set
        abstract geometryOpacity: float with get, set
        abstract geometryNormalTexture: Nullable<BaseTexture> with get, set
        abstract setNormalMapInversions: invertX: bool * invertY: bool -> unit
        abstract geometryCoatNormalTexture: Nullable<BaseTexture> with get, set
        abstract geometryCoatNormalTextureScale: float with get, set

module Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces =
    module GLTF2 = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2
    type AnimationGroup = obj
    type Skeleton = obj
    type Material = obj
    type TransformNode = obj
    type Buffer = obj
    type VertexBuffer = obj
    type AbstractMesh = obj
    type Mesh = obj
    type Camera = obj
    type Light = obj

    type [<AllowNullLiteral>] IArrayItem =
        abstract index: float with get, set

    type [<AllowNullLiteral>] IAccessor =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IAccessor
        inherit IArrayItem
        abstract _data: Promise<ArrayBufferView> option with get, set
        abstract _babylonVertexBuffer: IAccessor_babylonVertexBuffer option with get, set

    type [<AllowNullLiteral>] IAnimationChannel =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IAnimationChannel
        inherit IArrayItem

    type [<AllowNullLiteral>] _IAnimationSamplerData =
        abstract input: Float32Array with get, set
        abstract interpolation: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.AnimationSamplerInterpolation with get, set
        abstract output: Float32Array with get, set

    type [<AllowNullLiteral>] IAnimationSampler =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IAnimationSampler
        inherit IArrayItem
        abstract _data: Promise<_IAnimationSamplerData> option with get, set

    type [<AllowNullLiteral>] IAnimation =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IAnimation
        inherit IArrayItem
        abstract channels: ResizeArray<IAnimationChannel> with get, set
        abstract samplers: ResizeArray<IAnimationSampler> with get, set
        abstract _babylonAnimationGroup: AnimationGroup option with get, set

    type [<AllowNullLiteral>] IBuffer =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IBuffer
        inherit IArrayItem
        abstract _data: Promise<ArrayBufferView> option with get, set

    type [<AllowNullLiteral>] IBufferView =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IBufferView
        inherit IArrayItem
        abstract _data: Promise<ArrayBufferView> option with get, set
        abstract _babylonBuffer: Promise<Buffer> option with get, set

    type [<AllowNullLiteral>] ICamera =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ICamera
        inherit IArrayItem
        abstract _babylonCamera: Camera option with get, set

    type [<AllowNullLiteral>] IImage =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IImage
        inherit IArrayItem
        abstract _data: Promise<ArrayBufferView> option with get, set

    type [<AllowNullLiteral>] IMaterialNormalTextureInfo =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMaterialNormalTextureInfo
        inherit ITextureInfo

    type [<AllowNullLiteral>] IMaterialOcclusionTextureInfo =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMaterialOcclusionTextureInfo
        inherit ITextureInfo

    type [<AllowNullLiteral>] IMaterialPbrMetallicRoughness =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMaterialPbrMetallicRoughness
        abstract baseColorTexture: ITextureInfo option with get, set
        abstract metallicRoughnessTexture: ITextureInfo option with get, set

    type [<AllowNullLiteral>] IMaterial =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMaterial
        inherit IArrayItem
        abstract pbrMetallicRoughness: IMaterialPbrMetallicRoughness option with get, set
        abstract normalTexture: IMaterialNormalTextureInfo option with get, set
        abstract occlusionTexture: IMaterialOcclusionTextureInfo option with get, set
        abstract emissiveTexture: ITextureInfo option with get, set
        abstract _data: IMaterial_data option with get, set

    type [<AllowNullLiteral>] IMesh =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMesh
        inherit IArrayItem
        abstract primitives: ResizeArray<IMeshPrimitive> with get, set

    type [<AllowNullLiteral>] IMeshPrimitive =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMeshPrimitive
        inherit IArrayItem
        abstract _instanceData: {| babylonSourceMesh: Mesh; promise: Promise<obj option> |} option with get, set

    type [<AllowNullLiteral>] INode =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.INode
        inherit IArrayItem
        abstract parent: INode option with get, set
        abstract _babylonTransformNode: TransformNode option with get, set
        abstract _babylonTransformNodeForSkin: TransformNode option with get, set
        abstract _primitiveBabylonMeshes: ResizeArray<AbstractMesh> option with get, set
        abstract _numMorphTargets: float option with get, set
        abstract _isJoint: bool option with get, set

    type [<AllowNullLiteral>] _ISamplerData =
        abstract noMipMaps: bool with get, set
        abstract samplingMode: float with get, set
        abstract wrapU: float with get, set
        abstract wrapV: float with get, set

    type [<AllowNullLiteral>] ISampler =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ISampler
        inherit IArrayItem
        abstract _data: _ISamplerData option with get, set

    type [<AllowNullLiteral>] IScene =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IScene
        inherit IArrayItem

    type [<AllowNullLiteral>] ISkin =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ISkin
        inherit IArrayItem
        abstract _data: {| babylonSkeleton: Skeleton; promise: Promise<unit> |} option with get, set

    type [<AllowNullLiteral>] ITexture =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ITexture
        inherit IArrayItem
        abstract _textureInfo: ITextureInfo with get, set

    type [<AllowNullLiteral>] ITextureInfo =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ITextureInfo
        abstract nonColorData: bool option with get, set

    type [<AllowNullLiteral>] IGLTF =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTF
        abstract accessors: ResizeArray<IAccessor> option with get, set
        abstract animations: ResizeArray<IAnimation> option with get, set
        abstract buffers: ResizeArray<IBuffer> option with get, set
        abstract bufferViews: ResizeArray<IBufferView> option with get, set
        abstract cameras: ResizeArray<ICamera> option with get, set
        abstract images: ResizeArray<IImage> option with get, set
        abstract materials: ResizeArray<IMaterial> option with get, set
        abstract meshes: ResizeArray<IMesh> option with get, set
        abstract nodes: ResizeArray<INode> option with get, set
        abstract samplers: ResizeArray<ISampler> option with get, set
        abstract scenes: ResizeArray<IScene> option with get, set
        abstract skins: ResizeArray<ISkin> option with get, set
        abstract textures: ResizeArray<ITexture> option with get, set

    type [<AllowNullLiteral>] IKHRLightsPunctual_Light =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRLightsPunctual_Light
        inherit IArrayItem
        abstract _babylonLight: Light option with get, set

    type [<AllowNullLiteral>] IEXTLightsIES_Light =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IEXTLightsIES_Light
        inherit IArrayItem
        abstract _babylonLight: Light option with get, set

    type [<AllowNullLiteral>] IEXTLightsArea_Light =
        inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IEXTLightsArea_Light
        inherit IArrayItem
        abstract _babylonLight: Light option with get, set

    type [<AllowNullLiteral>] IAccessor_babylonVertexBuffer =
        [<EmitIndexer>] abstract Item: kind: string -> Promise<VertexBuffer> with get, set

    type [<AllowNullLiteral>] IMaterial_data =
        [<EmitIndexer>] abstract Item: babylonDrawMode: float -> {| babylonMaterial: Material; babylonMeshes: ResizeArray<AbstractMesh>; promise: Promise<unit> |} with get, set

module Babylonjs_loaders_glTF_2_0_glTFLoaderExtensionRegistry =
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension

    type [<AllowNullLiteral>] IExports =
        abstract registeredGLTFExtensions: ReadonlyMap<string, obj>
        abstract registerGLTFExtension: name: string * isGLTFExtension: bool * factory: GLTFExtensionFactory -> unit
        abstract unregisterGLTFExtension: name: string -> bool

    type [<AllowNullLiteral>] IRegisteredGLTFExtension =
        abstract isGLTFExtension: bool with get, set
        abstract factory: GLTFExtensionFactory with get, set

    type [<AllowNullLiteral>] GLTFExtensionFactory =
        [<Emit("$0($1...)")>] abstract Invoke: loader: GLTFLoader -> U2<IGLTFLoaderExtension, Promise<IGLTFLoaderExtension>>

module Babylonjs_loaders_glTF_2_0_glTFLoaderExtension =
    type Nullable<'T> = 'T
    type Animation = obj
    type AnimationGroup = obj
    type Material = obj
    type Camera = obj
    type Geometry = obj
    type TransformNode = obj
    type BaseTexture = obj
    type Mesh = obj
    type AbstractMesh = obj
    type IDisposable = BabylonjsBindings.FullCandidate.BABYLON.IDisposable
    type IScene = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IScene
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IMesh = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMesh
    type ISkin = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ISkin
    type ICamera = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ICamera
    type IMeshPrimitive = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMeshPrimitive
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type ITextureInfo = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ITextureInfo
    type IAnimation = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimation
    type ITexture = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ITexture
    type IBufferView = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IBufferView
    type IBuffer = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IBuffer
    type IAnimationChannel = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimationChannel
    type IGLTFBaseLoaderExtension = Babylonjs_loaders_glTF_glTFFileLoader_pure.IGLTFLoaderExtension
    type IProperty = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IProperty
    type IAnimatable = obj

    type [<AllowNullLiteral>] IGLTFLoaderExtension =
        inherit IGLTFBaseLoaderExtension
        inherit IDisposable
        abstract onLoading: unit -> unit
        abstract onReady: unit -> unit
        abstract loadSceneAsync: context: string * scene: IScene -> Nullable<Promise<unit>>
        abstract loadNodeAsync: context: string * node: INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>
        abstract loadCameraAsync: context: string * camera: ICamera * assign: (Camera -> unit) -> Nullable<Promise<Camera>>
        abstract _loadVertexDataAsync: context: string * primitive: IMeshPrimitive * babylonMesh: Mesh -> Nullable<Promise<Geometry>>
        abstract _loadMeshPrimitiveAsync: context: string * name: string * node: INode * mesh: IMesh * primitive: IMeshPrimitive * assign: (AbstractMesh -> unit) -> Nullable<Promise<AbstractMesh>>
        abstract _loadMaterialAsync: context: string * material: IMaterial * babylonMesh: Nullable<Mesh> * babylonDrawMode: float * assign: (Material -> unit) -> Nullable<Promise<Material>>
        abstract createMaterial: context: string * material: IMaterial * babylonDrawMode: float -> Nullable<Material>
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>
        abstract loadTextureInfoAsync: context: string * textureInfo: ITextureInfo * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>
        abstract _loadTextureAsync: context: string * texture: ITexture * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>
        abstract loadAnimationAsync: context: string * animation: IAnimation -> Nullable<Promise<AnimationGroup>>
        abstract _loadAnimationChannelAsync: context: string * animationContext: string * animation: IAnimation * channel: IAnimationChannel * onLoad: (IAnimatable -> Animation -> unit) -> Nullable<Promise<unit>>
        abstract _loadSkinAsync: context: string * node: INode * skin: ISkin -> Nullable<Promise<unit>>
        abstract _loadUriAsync: context: string * property: IProperty * uri: string -> Nullable<Promise<ArrayBufferView>>
        abstract loadBufferViewAsync: context: string * bufferView: IBufferView -> Nullable<Promise<ArrayBufferView>>
        abstract loadBufferAsync: context: string * buffer: IBuffer * byteOffset: float * byteLength: float -> Nullable<Promise<ArrayBufferView>>

module Babylonjs_loaders_glTF_2_0_glTFLoaderAnimation =
    type Animation = obj
    type Quaternion = obj
    type Vector3 = obj
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IAnimatable = obj

    type [<AllowNullLiteral>] IExports =
        abstract getVector3: _target: obj option * source: Float32Array * offset: float * scale: float -> Vector3
        abstract getQuaternion: _target: obj option * source: Float32Array * offset: float * scale: float -> Quaternion
        abstract getWeights: target: INode * source: Float32Array * offset: float * scale: float -> Array<float>
        abstract AnimationPropertyInfo: AnimationPropertyInfoStatic
        abstract TransformNodeAnimationPropertyInfo: TransformNodeAnimationPropertyInfoStatic
        abstract WeightAnimationPropertyInfo: WeightAnimationPropertyInfoStatic

    type [<AllowNullLiteral>] GetValueFn =
        [<Emit("$0($1...)")>] abstract Invoke: target: obj option * source: Float32Array * offset: float * scale: float -> obj option

    type [<AllowNullLiteral>] AnimationPropertyInfo =
        abstract ``type``: float
        abstract name: string
        abstract getValue: GetValueFn
        abstract getStride: obj option -> float
        abstract _buildAnimation: name: string * fps: float * keys: ResizeArray<obj option> -> Animation
        abstract buildAnimations: target: obj option * name: string * fps: float * keys: ResizeArray<obj option> -> ResizeArray<{| babylonAnimatable: IAnimatable; babylonAnimation: Animation |}>

    type [<AllowNullLiteral>] AnimationPropertyInfoStatic =
        [<EmitConstructor>] abstract Create: ``type``: float * name: string * getValue: GetValueFn * getStride: (obj option -> float) -> AnimationPropertyInfo

    type [<AllowNullLiteral>] TransformNodeAnimationPropertyInfo =
        inherit AnimationPropertyInfo
        abstract buildAnimations: target: INode * name: string * fps: float * keys: ResizeArray<obj option> -> ResizeArray<{| babylonAnimatable: IAnimatable; babylonAnimation: Animation |}>

    type [<AllowNullLiteral>] TransformNodeAnimationPropertyInfoStatic =
        [<EmitConstructor>] abstract Create: ``type``: float * name: string * getValue: GetValueFn * getStride: (obj option -> float) -> TransformNodeAnimationPropertyInfo

    type [<AllowNullLiteral>] WeightAnimationPropertyInfo =
        inherit AnimationPropertyInfo
        abstract buildAnimations: target: INode * name: string * fps: float * keys: ResizeArray<obj option> -> ResizeArray<{| babylonAnimatable: IAnimatable; babylonAnimation: Animation |}>

    type [<AllowNullLiteral>] WeightAnimationPropertyInfoStatic =
        [<EmitConstructor>] abstract Create: ``type``: float * name: string * getValue: GetValueFn * getStride: (obj option -> float) -> WeightAnimationPropertyInfo

module Babylonjs_loaders_glTF_2_0_glTFLoader_pure =
    type IndicesArray = obj
    type Nullable<'T> = 'T
    type Camera = obj
    type Animation = obj
    type IAnimatable = obj
    type AnimationGroup = obj
    type Material = obj
    type BaseTexture = obj
    type TransformNode = obj
    type Buffer = obj
    type VertexBuffer = obj
    type AbstractMesh = obj
    type Mesh = obj
    type ISceneLoaderAsyncResult = obj
    type ISceneLoaderProgressEvent = obj
    type Scene = obj
    type IProperty = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IProperty
    type IGLTF = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IGLTF
    type ISampler = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ISampler
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IScene = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IScene
    type IMesh = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMesh
    type IAccessor = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAccessor
    type ICamera = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ICamera
    type IAnimation = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimation
    type IBuffer = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IBuffer
    type IBufferView = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IBufferView
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type ITextureInfo = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ITextureInfo
    type ITexture = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ITexture
    type IImage = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IImage
    type IMeshPrimitive = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMeshPrimitive
    type IArrayItem = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IArrayItem
    type IAnimationChannel = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimationChannel
    type IGLTFLoader = Babylonjs_loaders_glTF_glTFFileLoader_pure.IGLTFLoader
    type IGLTFLoaderData = Babylonjs_loaders_glTF_glTFFileLoader_pure.IGLTFLoaderData
    type GLTFFileLoader = Babylonjs_loaders_glTF_glTFFileLoader_pure.GLTFFileLoader
    type IDataBuffer = obj
    type Light = obj
    type BoundingInfo = obj
    type AssetContainer = obj
    type AnimationPropertyInfo = Babylonjs_loaders_glTF_2_0_glTFLoaderAnimation.AnimationPropertyInfo
    type IObjectInfo<'T> = BabylonjsBindings.FullCandidate.BABYLON.IObjectInfo<'T>
    type GLTFExtensionFactory = Babylonjs_loaders_glTF_2_0_glTFLoaderExtensionRegistry.GLTFExtensionFactory
    type IInterpolationPropertyInfo = obj
    type IMaterialLoadingAdapter = Babylonjs_loaders_glTF_2_0_materialLoadingAdapter.IMaterialLoadingAdapter

    type [<AllowNullLiteral>] IExports =
        abstract ArrayItem: ArrayItemStatic
        abstract LoadBoundingInfoFromPositionAccessor: accessor: IAccessor -> Nullable<BoundingInfo>
        abstract GLTFLoader: GLTFLoaderStatic
        abstract RegisterGLTF2Loader: unit -> unit

    type [<AllowNullLiteral>] IWithMetadata =
        abstract metadata: obj option with get, set
        abstract _internalMetadata: obj option with get, set

    type [<AllowNullLiteral>] ArrayItem =
        interface end

    type [<AllowNullLiteral>] ArrayItemStatic =
        [<EmitConstructor>] abstract Create: unit -> ArrayItem
        abstract Get: context: string * array: ArrayLike<'T> option * index: float option -> 'T
        abstract TryGet: array: ArrayLike<'T> option * index: float option -> Nullable<'T>
        abstract Assign: ?array: ResizeArray<IArrayItem> -> unit

    type [<AllowNullLiteral>] IAnimationTargetInfo =
        abstract target: obj with get, set
        abstract properties: Array<AnimationPropertyInfo> with get, set

    type [<AllowNullLiteral>] PBRMaterialImplementation =
        abstract materialClass: obj with get, set
        abstract adapterClass: obj with get, set

    type [<AllowNullLiteral>] GLTFLoader =
        inherit IGLTFLoader
        abstract _completePromises: ResizeArray<Promise<obj>>
        abstract _assetContainer: Nullable<AssetContainer> with get, set
        abstract _babylonLights: ResizeArray<Light> with get, set
        abstract _disableInstancedMesh: float with get, set
        abstract _allMaterialsDirtyRequired: bool with get, set
        abstract _skipStartAnimationStep: bool with get, set
        abstract _disposed: bool with get, set
        abstract _pbrMaterialImpls: Map<string, obj>
        abstract isMatchingMaterialType: material: Nullable<Material> -> bool
        abstract gltf: IGLTF
        abstract bin: Nullable<IDataBuffer>
        abstract parent: GLTFFileLoader
        abstract babylonScene: Scene
        abstract rootBabylonMesh: Nullable<TransformNode>
        abstract rootUrl: Nullable<string>
        abstract _getOrCreateMaterialAdapter: material: Material -> IMaterialLoadingAdapter
        abstract dispose: unit -> unit
        abstract importMeshAsync: meshesNames: U2<string, ResizeArray<string>> option * scene: Scene * container: Nullable<AssetContainer> * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<unit>
        abstract loadSceneAsync: context: string * scene: IScene -> Promise<unit>
        abstract loadNodeAsync: context: string * node: INode * ?assign: (TransformNode -> unit) -> Promise<TransformNode>
        abstract _loadMeshPrimitiveAsync: context: string * name: string * node: INode * mesh: IMesh * primitive: IMeshPrimitive * assign: (AbstractMesh -> unit) -> Promise<AbstractMesh>
        abstract loadCameraAsync: context: string * camera: ICamera * ?assign: (Camera -> unit) -> Promise<Camera>
        abstract loadAnimationAsync: context: string * animation: IAnimation -> Promise<AnimationGroup>
        abstract _loadAnimationChannelAsync: context: string * animationContext: string * animation: IAnimation * channel: IAnimationChannel * onLoad: (IAnimatable -> Animation -> unit) -> Promise<unit>
        abstract _loadAnimationChannelFromTargetInfoAsync: context: string * animationContext: string * animation: IAnimation * channel: IAnimationChannel * targetInfo: IObjectInfo<ResizeArray<IInterpolationPropertyInfo>> * onLoad: (IAnimatable -> Animation -> unit) -> Promise<unit>
        abstract loadBufferAsync: context: string * buffer: IBuffer * byteOffset: float * byteLength: float -> Promise<ArrayBufferView>
        abstract loadBufferViewAsync: context: string * bufferView: IBufferView -> Promise<ArrayBufferView>
        abstract _loadFloatAccessorAsync: context: string * accessor: IAccessor -> Promise<Float32Array>
        abstract _loadIndicesAccessorAsync: context: string * accessor: IAccessor -> Promise<IndicesArray>
        abstract _loadVertexBufferViewAsync: bufferView: IBufferView -> Promise<Buffer>
        abstract _loadVertexAccessorAsync: context: string * accessor: IAccessor * kind: string -> Promise<VertexBuffer>
        abstract _loadMaterialAsync: context: string * material: IMaterial * babylonMesh: Nullable<Mesh> * babylonDrawMode: float * ?assign: (Material -> unit) -> Promise<Material>
        abstract createMaterial: context: string * material: IMaterial * babylonDrawMode: float -> Material
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Promise<unit>
        abstract loadMaterialBasePropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Promise<unit>
        abstract loadMaterialAlphaProperties: context: string * material: IMaterial * babylonMaterial: Material -> unit
        abstract loadTextureInfoAsync: context: string * textureInfo: ITextureInfo * ?assign: (BaseTexture -> unit) -> Promise<BaseTexture>
        abstract _loadTextureAsync: context: string * texture: ITexture * ?assign: (BaseTexture -> unit) -> Promise<BaseTexture>
        abstract _createTextureAsync: context: string * sampler: ISampler * image: IImage * ?assign: (BaseTexture -> unit) * ?textureLoaderOptions: obj * ?useSRGBBuffer: bool -> Promise<BaseTexture>
        abstract loadImageAsync: context: string * image: IImage -> Promise<ArrayBufferView>
        abstract loadUriAsync: context: string * property: IProperty * uri: string -> Promise<ArrayBufferView>
        abstract isExtensionUsed: name: string -> bool
        abstract logOpen: message: string -> unit
        abstract logClose: unit -> unit
        abstract log: message: string -> unit
        abstract startPerformanceCounter: counterName: string -> unit
        abstract endPerformanceCounter: counterName: string -> unit

    type [<AllowNullLiteral>] GLTFLoaderStatic =
        abstract DefaultSampler: ISampler
        abstract RegisterExtension: name: string * factory: GLTFExtensionFactory -> unit
        abstract UnregisterExtension: name: string -> bool
        [<EmitConstructor>] abstract Create: parent: GLTFFileLoader -> GLTFLoader
        abstract AddPointerMetadata: babylonObject: IWithMetadata * pointer: string -> unit
        abstract _GetDrawMode: context: string * mode: float option -> float
        abstract LoadExtensionAsync: context: string * property: IProperty * extensionName: string * actionAsync: (string -> 'TExtension -> Nullable<Promise<'TResult>>) -> Nullable<Promise<'TResult>>
        abstract LoadExtraAsync: context: string * property: IProperty * extensionName: string * actionAsync: (string -> 'TExtra -> Nullable<Promise<'TResult>>) -> Nullable<Promise<'TResult>>

module Babylonjs_loaders_glTF_2_0_Extensions_transmissionHelper =
    type Nullable<'T> = 'T
    type Material = obj
    type Scene = obj
    type Texture = obj
    type Observable<'T> = BabylonjsBindings.FullCandidate.BABYLON.Observable<'T>
    type Color4 = obj
    type IMaterialLoadingAdapter = Babylonjs_loaders_glTF_2_0_materialLoadingAdapter.IMaterialLoadingAdapter
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract TransmissionHelper: TransmissionHelperStatic
        abstract ensureTransmissionHelper: loader: GLTFLoader * babylonMaterial: Material -> unit

    type [<AllowNullLiteral>] ITransmissionHelperMaterialImpl =
        abstract materialClass: obj with get, set
        abstract adapterClass: obj with get, set

    type [<AllowNullLiteral>] ITransmissionHelperHolder =
        abstract _transmissionHelper: TransmissionHelper option with get, set

    type [<AllowNullLiteral>] ITransmissionHelperOptions =
        abstract renderSize: float with get, set
        abstract samples: float with get, set
        abstract lodGenerationScale: float with get, set
        abstract lodGenerationOffset: float with get, set
        abstract renderTargetTextureType: float with get, set
        abstract generateMipmaps: bool with get, set
        abstract clearColor: Color4 option with get, set

    type [<AllowNullLiteral>] TransmissionHelper =
        abstract onErrorObservable: Observable<{| message: string option; ``exception``: obj option |}> with get, set
        abstract addMaterialImpl: impl: ITransmissionHelperMaterialImpl -> unit
        abstract updateOptions: options: obj -> unit
        abstract getOpaqueTarget: unit -> Nullable<Texture>
        abstract _isRenderTargetValid: unit -> bool
        abstract _setupRenderTargets: unit -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] TransmissionHelperStatic =
        [<EmitConstructor>] abstract Create: options: obj * scene: Scene -> TransmissionHelper

module Babylonjs_loaders_glTF_2_0_Extensions_objectModelMapping =
    type TransformNode = obj
    type IAnimation = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimation
    type ICamera = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ICamera
    type IGLTF = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IGLTF
    type IKHRLightsPunctual_Light = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IKHRLightsPunctual_Light
    type IEXTLightsArea_Light = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IEXTLightsArea_Light
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IMesh = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMesh
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type Vector3 = obj
    type Matrix = obj
    type Quaternion = obj
    type Vector2 = obj
    type Color3 = obj
    type Color4 = obj
    type PBRMaterial = obj
    type Light = obj
    type Nullable<'T> = 'T
    type IEXTLightsImageBased_LightImageBased = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IEXTLightsImageBased_LightImageBased
    type BaseTexture = obj
    type IInterpolationPropertyInfo = obj
    type IObjectAccessor = BabylonjsBindings.FullCandidate.BABYLON.IObjectAccessor
    type IObjectAccessor<'T, 'BabylonType, 'BabylonValue> = BabylonjsBindings.FullCandidate.BABYLON.IObjectAccessor<'T, 'BabylonType, 'BabylonValue>
    type GLTFPathToObjectConverter<'T, 'BabylonType, 'BabylonValue> = Babylonjs_loaders_glTF_2_0_Extensions_gltfPathToObjectConverter.GLTFPathToObjectConverter<'T, 'BabylonType, 'BabylonValue>
    type AnimationGroup = obj
    type Mesh = obj

    type [<AllowNullLiteral>] IExports =
        abstract GetPathToObjectConverter: gltf: IGLTF -> GLTFPathToObjectConverter<obj, obj, obj>
        abstract GetMappingForKey: key: string -> IObjectAccessor option
        abstract SetInterpolationForKey: key: string * ?interpolation: ResizeArray<IInterpolationPropertyInfo> -> unit
        abstract AddObjectAccessorToKey: key: string * accessor: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> -> unit

    type [<AllowNullLiteral>] IGLTFObjectModelTree =
        abstract cameras: IGLTFObjectModelTreeCamerasObject with get, set
        abstract nodes: IGLTFObjectModelTreeNodesObject with get, set
        abstract materials: IGLTFObjectModelTreeMaterialsObject with get, set
        abstract extensions: IGLTFObjectModelTreeExtensionsObject with get, set
        abstract animations: {| length: IObjectAccessor<ResizeArray<IAnimation>, ResizeArray<AnimationGroup>, float>; __array__: IGLTFObjectModelTreeAnimations__array__ |} with get, set
        abstract meshes: {| length: IObjectAccessor<ResizeArray<IMesh>, ResizeArray<Mesh option>, float>; __array__: IGLTFObjectModelTreeAnimations__array__ |} with get, set

    type IGLTFObjectModelTreeNodesObject =
        IGLTFObjectModelTreeNodesObject<INode, TransformNode>

    type IGLTFObjectModelTreeNodesObject<'GLTFTargetType> =
        IGLTFObjectModelTreeNodesObject<'GLTFTargetType, TransformNode>

    type [<AllowNullLiteral>] IGLTFObjectModelTreeNodesObject<'GLTFTargetType, 'BabylonTargetType> =
        abstract length: IObjectAccessor<ResizeArray<'GLTFTargetType>, ResizeArray<'BabylonTargetType>, float> with get, set
        abstract __array__: IGLTFObjectModelTreeNodesObject__array__<'GLTFTargetType, 'BabylonTargetType> with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeCamerasObject =
        abstract __array__: {| __target__: bool; orthographic: {| xmag: IObjectAccessor<ICamera, ICamera, Vector2>; ymag: IObjectAccessor<ICamera, ICamera, Vector2>; zfar: IObjectAccessor<ICamera, ICamera, float>; znear: IObjectAccessor<ICamera, ICamera, float> |}; perspective: {| yfov: IObjectAccessor<ICamera, ICamera, float>; zfar: IObjectAccessor<ICamera, ICamera, float>; znear: IObjectAccessor<ICamera, ICamera, float>; aspectRatio: IObjectAccessor<ICamera, ICamera, Nullable<float>> |} |} with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject =
        abstract __array__: IGLTFObjectModelTreeMaterialsObject__array__ with get, set

    type [<AllowNullLiteral>] ITextureDefinition =
        abstract offset: IObjectAccessor<IMaterial, PBRMaterial, Vector2> with get, set
        abstract rotation: IObjectAccessor<IMaterial, PBRMaterial, float> with get, set
        abstract scale: IObjectAccessor<IMaterial, PBRMaterial, Vector2> with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeMeshesObject =
        interface end

    type [<AllowNullLiteral>] IGLTFObjectModelTreeExtensionsObject =
        abstract KHR_lights_punctual: {| lights: {| length: IObjectAccessor<ResizeArray<IKHRLightsPunctual_Light>, ResizeArray<Light>, float>; __array__: IGLTFObjectModelTreeExtensionsObjectKHR_lights_punctualLights__array__ |} |} with get, set
        abstract EXT_lights_area: {| lights: {| length: IObjectAccessor<ResizeArray<IEXTLightsArea_Light>, ResizeArray<Light>, float>; __array__: IGLTFObjectModelTreeExtensionsObjectEXT_lights_areaLights__array__ |} |} with get, set
        abstract EXT_lights_ies: {| lights: {| length: IObjectAccessor<ResizeArray<IKHRLightsPunctual_Light>, ResizeArray<Light>, float> |} |} with get, set
        abstract EXT_lights_image_based: {| lights: {| __array__: {| __target__: bool; intensity: IObjectAccessor<IEXTLightsImageBased_LightImageBased, BaseTexture, float>; rotation: IObjectAccessor<IEXTLightsImageBased_LightImageBased, BaseTexture, Quaternion> |}; length: IObjectAccessor<ResizeArray<IEXTLightsImageBased_LightImageBased>, ResizeArray<BaseTexture>, float> |} |} with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeAnimations__array__ =
        interface end

    type [<AllowNullLiteral>] IGLTFObjectModelTreeNodesObject__array__<'GLTFTargetType, 'BabylonTargetType> =
        abstract __target__: bool with get, set
        abstract translation: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Vector3> with get, set
        abstract rotation: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Quaternion> with get, set
        abstract scale: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Vector3> with get, set
        abstract matrix: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Matrix> with get, set
        abstract globalMatrix: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Matrix> with get, set
        abstract weights: obj with get, set
        abstract extensions: {| EXT_lights_ies: {| multiplier: IObjectAccessor<INode, Light, float>; color: IObjectAccessor<INode, Light, Color3> |} option; KHR_node_visibility: {| visible: IObjectAccessor<INode, Mesh, bool> |} option |} with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__PbrMetallicRoughness =
        abstract baseColorFactor: IObjectAccessor<IMaterial, PBRMaterial, Color4> with get, set
        abstract metallicFactor: IObjectAccessor<IMaterial, PBRMaterial, Nullable<float>> with get, set
        abstract roughnessFactor: IObjectAccessor<IMaterial, PBRMaterial, Nullable<float>> with get, set
        abstract baseColorTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
        abstract metallicRoughnessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__ExtensionsKHR_materials_clearcoat =
        abstract clearcoatFactor: IObjectAccessor<IMaterial, PBRMaterial, float> with get, set
        abstract clearcoatRoughnessFactor: IObjectAccessor<IMaterial, PBRMaterial, float> with get, set
        abstract clearcoatTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
        abstract clearcoatNormalTexture: {| scale: IObjectAccessor<IMaterial, PBRMaterial, float>; extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
        abstract clearcoatRoughnessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__ExtensionsKHR_materials_iridescence =
        abstract iridescenceFactor: IObjectAccessor<IMaterial, PBRMaterial, float> with get, set
        abstract iridescenceIor: IObjectAccessor<IMaterial, PBRMaterial, float> with get, set
        abstract iridescenceThicknessMinimum: IObjectAccessor<IMaterial, PBRMaterial, float> with get, set
        abstract iridescenceThicknessMaximum: IObjectAccessor<IMaterial, PBRMaterial, float> with get, set
        abstract iridescenceTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
        abstract iridescenceThicknessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__Extensions =
        abstract KHR_materials_anisotropy: {| anisotropyStrength: IObjectAccessor<IMaterial, PBRMaterial, float>; anisotropyRotation: IObjectAccessor<IMaterial, PBRMaterial, float>; anisotropyTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
        abstract KHR_materials_clearcoat: IGLTFObjectModelTreeMaterialsObject__array__ExtensionsKHR_materials_clearcoat with get, set
        abstract KHR_materials_dispersion: {| dispersion: IObjectAccessor<IMaterial, PBRMaterial, float> |} with get, set
        abstract KHR_materials_emissive_strength: {| emissiveStrength: IObjectAccessor<IMaterial, PBRMaterial, float> |} with get, set
        abstract KHR_materials_ior: {| ior: IObjectAccessor<IMaterial, PBRMaterial, float> |} with get, set
        abstract KHR_materials_iridescence: IGLTFObjectModelTreeMaterialsObject__array__ExtensionsKHR_materials_iridescence with get, set
        abstract KHR_materials_sheen: {| sheenColorFactor: IObjectAccessor<IMaterial, PBRMaterial, Color3>; sheenRoughnessFactor: IObjectAccessor<IMaterial, PBRMaterial, float>; sheenColorTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |}; sheenRoughnessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
        abstract KHR_materials_specular: {| specularFactor: IObjectAccessor<IMaterial, PBRMaterial, float>; specularColorFactor: IObjectAccessor<IMaterial, PBRMaterial, Color3>; specularTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |}; specularColorTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
        abstract KHR_materials_transmission: {| transmissionFactor: IObjectAccessor<IMaterial, PBRMaterial, float>; transmissionTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
        abstract KHR_materials_diffuse_transmission: {| diffuseTransmissionFactor: IObjectAccessor<IMaterial, PBRMaterial, float>; diffuseTransmissionTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |}; diffuseTransmissionColorFactor: IObjectAccessor<IMaterial, PBRMaterial, Nullable<Color3>>; diffuseTransmissionColorTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
        abstract KHR_materials_volume: {| thicknessFactor: IObjectAccessor<IMaterial, PBRMaterial, float>; attenuationColor: IObjectAccessor<IMaterial, PBRMaterial, Color3>; attenuationDistance: IObjectAccessor<IMaterial, PBRMaterial, float>; thicknessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__ =
        abstract __target__: bool with get, set
        abstract pbrMetallicRoughness: IGLTFObjectModelTreeMaterialsObject__array__PbrMetallicRoughness with get, set
        abstract emissiveFactor: IObjectAccessor<IMaterial, PBRMaterial, Color3> with get, set
        abstract normalTexture: {| scale: IObjectAccessor<IMaterial, PBRMaterial, float>; extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
        abstract occlusionTexture: {| strength: IObjectAccessor<IMaterial, PBRMaterial, float>; extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
        abstract emissiveTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
        abstract extensions: IGLTFObjectModelTreeMaterialsObject__array__Extensions with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeExtensionsObjectKHR_lights_punctualLights__array__ =
        abstract __target__: bool with get, set
        abstract color: IObjectAccessor<IKHRLightsPunctual_Light, Light, Color3> with get, set
        abstract intensity: IObjectAccessor<IKHRLightsPunctual_Light, Light, float> with get, set
        abstract range: IObjectAccessor<IKHRLightsPunctual_Light, Light, float> with get, set
        abstract spot: {| innerConeAngle: IObjectAccessor<IKHRLightsPunctual_Light, Light, float>; outerConeAngle: IObjectAccessor<IKHRLightsPunctual_Light, Light, float> |} with get, set

    type [<AllowNullLiteral>] IGLTFObjectModelTreeExtensionsObjectEXT_lights_areaLights__array__ =
        abstract __target__: bool with get, set
        abstract color: IObjectAccessor<IEXTLightsArea_Light, Light, Color3> with get, set
        abstract intensity: IObjectAccessor<IEXTLightsArea_Light, Light, float> with get, set
        abstract size: IObjectAccessor<IEXTLightsArea_Light, Light, float> with get, set
        abstract rect: {| aspect: IObjectAccessor<IEXTLightsArea_Light, Light, float> |} with get, set

module Babylonjs_loaders_glTF_2_0_Extensions_gltfPathToObjectConverter =
    type IObjectInfo<'T> = BabylonjsBindings.FullCandidate.BABYLON.IObjectInfo<'T>
    type IPathToObjectConverter<'T> = BabylonjsBindings.FullCandidate.BABYLON.IPathToObjectConverter<'T>
    type IGLTF = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IGLTF
    type IObjectAccessor = BabylonjsBindings.FullCandidate.BABYLON.IObjectAccessor
    type IObjectAccessor<'T, 'BabylonType, 'BabylonValue> = BabylonjsBindings.FullCandidate.BABYLON.IObjectAccessor<'T, 'BabylonType, 'BabylonValue>

    type [<AllowNullLiteral>] IExports =
        abstract OptionalPathExceptionsList: ResizeArray<{| regex: RegExp |}>
        abstract GLTFPathToObjectConverter: GLTFPathToObjectConverterStatic

    type [<AllowNullLiteral>] GLTFPathToObjectConverter<'T, 'BabylonType, 'BabylonValue> =
        inherit IPathToObjectConverter<IObjectAccessor<'T, 'BabylonType, 'BabylonValue>>
        abstract convert: path: string -> IObjectInfo<IObjectAccessor<'T, 'BabylonType, 'BabylonValue>>

    type [<AllowNullLiteral>] GLTFPathToObjectConverterStatic =
        [<EmitConstructor>] abstract Create: _gltf: IGLTF * _infoTree: obj option -> GLTFPathToObjectConverter<'T, 'BabylonType, 'BabylonValue>

module Babylonjs_loaders_glTF_2_0_Extensions_dynamic =

    type [<AllowNullLiteral>] IExports =
        abstract registerBuiltInGLTFExtensions: unit -> unit

module Babylonjs_loaders_glTF_2_0_Extensions_MSFT_sRGBFactors_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["MSFT_sRGBFactors"]``: GLTFLoaderExtensionOptions__MSFT_sRGBFactors__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__MSFT_sRGBFactors__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_MSFT_sRGBFactors_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract MSFT_sRGBFactors: MSFT_sRGBFactorsStatic
        abstract RegisterMSFT_sRGBFactors: unit -> unit

    type [<AllowNullLiteral>] MSFT_sRGBFactors =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] MSFT_sRGBFactorsStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> MSFT_sRGBFactors

module Babylonjs_loaders_glTF_2_0_Extensions_MSFT_minecraftMesh_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["MSFT_minecraftMesh"]``: GLTFLoaderExtensionOptions__MSFT_minecraftMesh__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__MSFT_minecraftMesh__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_MSFT_minecraftMesh_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract MSFT_minecraftMesh: MSFT_minecraftMeshStatic
        abstract RegisterMSFT_minecraftMesh: unit -> unit

    type [<AllowNullLiteral>] MSFT_minecraftMesh =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] MSFT_minecraftMeshStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> MSFT_minecraftMesh

module Babylonjs_loaders_glTF_2_0_Extensions_MSFT_lod_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["MSFT_lod"]``: obj with get, set

module Babylonjs_loaders_glTF_2_0_Extensions_MSFT_lod_pure =
    type Nullable<'T> = 'T
    type Observable<'T> = BabylonjsBindings.FullCandidate.BABYLON.Observable<'T>
    type Material = obj
    type TransformNode = obj
    type Mesh = obj
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IBuffer = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IBuffer
    type IScene = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IScene
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type IProperty = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IProperty

    type [<AllowNullLiteral>] IExports =
        abstract MSFT_lod: MSFT_lodStatic
        abstract RegisterMSFT_lod: unit -> unit

    type [<AllowNullLiteral>] MSFT_lod =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract maxLODsToLoad: float with get, set
        abstract onNodeLODsLoadedObservable: Observable<float> with get, set
        abstract onMaterialLODsLoadedObservable: Observable<float> with get, set
        abstract dispose: unit -> unit
        abstract onReady: unit -> unit
        abstract loadSceneAsync: context: string * scene: IScene -> Nullable<Promise<unit>>
        abstract loadNodeAsync: context: string * node: INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>
        abstract _loadMaterialAsync: context: string * material: IMaterial * babylonMesh: Nullable<Mesh> * babylonDrawMode: float * assign: (Material -> unit) -> Nullable<Promise<Material>>
        abstract _loadUriAsync: context: string * property: IProperty * uri: string -> Nullable<Promise<ArrayBufferView>>
        abstract loadBufferAsync: context: string * buffer: IBuffer * byteOffset: float * byteLength: float -> Nullable<Promise<ArrayBufferView>>

    type [<AllowNullLiteral>] MSFT_lodStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> MSFT_lod

module Babylonjs_loaders_glTF_2_0_Extensions_MSFT_audio_emitter_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["MSFT_audio_emitter"]``: GLTFLoaderExtensionOptions__MSFT_audio_emitter__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__MSFT_audio_emitter__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_MSFT_audio_emitter_pure =
    type Nullable<'T> = 'T
    type AnimationGroup = obj
    type TransformNode = obj
    type IScene = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IScene
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IAnimation = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimation
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract MSFT_audio_emitter: MSFT_audio_emitterStatic
        abstract RegisterMSFT_audio_emitter: unit -> unit

    type [<AllowNullLiteral>] MSFT_audio_emitter =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract onLoading: unit -> unit
        abstract loadSceneAsync: context: string * scene: IScene -> Nullable<Promise<unit>>
        abstract loadNodeAsync: context: string * node: INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>
        abstract loadAnimationAsync: context: string * animation: IAnimation -> Nullable<Promise<AnimationGroup>>

    type [<AllowNullLiteral>] MSFT_audio_emitterStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> MSFT_audio_emitter

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_xmp_json_ld_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_xmp_json_ld"]``: GLTFLoaderExtensionOptions__KHR_xmp_json_ld__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_xmp_json_ld__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_xmp_json_ld_pure =
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_xmp_json_ld: KHR_xmp_json_ldStatic
        abstract RegisterKHR_xmp_json_ld: unit -> unit

    type [<AllowNullLiteral>] KHR_xmp_json_ld =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract onLoading: unit -> unit

    type [<AllowNullLiteral>] KHR_xmp_json_ldStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_xmp_json_ld

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_texture_transform_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_texture_transform"]``: GLTFLoaderExtensionOptions__KHR_texture_transform__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_texture_transform__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_texture_transform_pure =
    type Nullable<'T> = 'T
    type BaseTexture = obj
    type ITextureInfo = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ITextureInfo
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_texture_transform: KHR_texture_transformStatic
        abstract RegisterKHR_texture_transform: unit -> unit

    type [<AllowNullLiteral>] KHR_texture_transform =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract loadTextureInfoAsync: context: string * textureInfo: ITextureInfo * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>

    type [<AllowNullLiteral>] KHR_texture_transformStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_texture_transform

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_texture_basisu_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_texture_basisu"]``: GLTFLoaderExtensionOptions__KHR_texture_basisu__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_texture_basisu__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_texture_basisu_pure =
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type ITexture = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ITexture
    type BaseTexture = obj
    type Nullable<'T> = 'T

    type [<AllowNullLiteral>] IExports =
        abstract KHR_texture_basisu: KHR_texture_basisuStatic
        abstract RegisterKHR_texture_basisu: unit -> unit

    type [<AllowNullLiteral>] KHR_texture_basisu =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract _loadTextureAsync: context: string * texture: ITexture * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>

    type [<AllowNullLiteral>] KHR_texture_basisuStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_texture_basisu

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_visibility_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_node_visibility"]``: GLTFLoaderExtensionOptions__KHR_node_visibility__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_node_visibility__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_visibility_pure =
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension

    type [<AllowNullLiteral>] IExports =
        abstract KHR_node_visibility: KHR_node_visibilityStatic
        abstract RegisterKHR_node_visibility: unit -> unit

    type [<AllowNullLiteral>] KHR_node_visibility =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract onReady: unit -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] KHR_node_visibilityStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_node_visibility

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_selectability_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_node_selectability"]``: GLTFLoaderExtensionOptions__KHR_node_selectability__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_node_selectability__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_selectability_pure =
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension

    type [<AllowNullLiteral>] IExports =
        abstract KHR_node_selectability: KHR_node_selectabilityStatic
        abstract RegisterKHR_node_selectability: unit -> unit

    type [<AllowNullLiteral>] KHR_node_selectability =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract onReady: unit -> Promise<unit>
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] KHR_node_selectabilityStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_node_selectability

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_hoverability_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_node_hoverability"]``: GLTFLoaderExtensionOptions__KHR_node_hoverability__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_node_hoverability__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_node_hoverability_pure =
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension

    type [<AllowNullLiteral>] IExports =
        abstract KHR_node_hoverability: KHR_node_hoverabilityStatic
        abstract RegisterKHR_node_hoverability: unit -> unit

    type [<AllowNullLiteral>] KHR_node_hoverability =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract onReady: unit -> Promise<unit>
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] KHR_node_hoverabilityStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_node_hoverability

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_mesh_quantization_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_mesh_quantization"]``: GLTFLoaderExtensionOptions__KHR_mesh_quantization__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_mesh_quantization__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_mesh_quantization_pure =
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_mesh_quantization: KHR_mesh_quantizationStatic
        abstract RegisterKHR_mesh_quantization: unit -> unit

    type [<AllowNullLiteral>] KHR_mesh_quantization =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] KHR_mesh_quantizationStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_mesh_quantization

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_volume_scatter_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_volume_scatter"]``: GLTFLoaderExtensionOptions__KHR_materials_volume_scatter__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_volume_scatter__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_volume_scatter_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_volume_scatter: KHR_materials_volume_scatterStatic
        abstract RegisterKHR_materials_volume_scatter: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_volume_scatter =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_volume_scatterStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_volume_scatter

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_volume_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_volume"]``: GLTFLoaderExtensionOptions__KHR_materials_volume__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_volume__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_volume_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_volume: KHR_materials_volumeStatic
        abstract RegisterKHR_materials_volume: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_volume =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_volumeStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_volume

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_variants_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] MaterialVariantsController =
            abstract variants: ResizeArray<string>
            abstract selectedVariant: string with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_variants"]``: obj with get, set

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_variants_pure =
    type Nullable<'T> = 'T
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type AbstractMesh = obj
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IMeshPrimitive = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMeshPrimitive
    type IMesh = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMesh
    type TransformNode = obj

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_variants: KHR_materials_variantsStatic
        abstract RegisterKHR_materials_variants: unit -> unit

    type [<AllowNullLiteral>] MaterialVariantsController =
        abstract variants: ResizeArray<string>
        abstract selectedVariant: string with get, set

    type [<AllowNullLiteral>] KHR_materials_variants =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract getAvailableVariants: rootNode: TransformNode -> ResizeArray<string>
        abstract selectVariant: rootNode: TransformNode * variantName: U2<string, ResizeArray<string>> -> unit
        abstract reset: rootNode: TransformNode -> unit
        abstract getLastSelectedVariant: rootNode: TransformNode -> Nullable<U2<string, ResizeArray<string>>>
        abstract onLoading: unit -> unit
        abstract onReady: unit -> unit
        abstract _loadMeshPrimitiveAsync: context: string * name: string * node: INode * mesh: IMesh * primitive: IMeshPrimitive * assign: (AbstractMesh -> unit) -> Nullable<Promise<AbstractMesh>>

    type [<AllowNullLiteral>] KHR_materials_variantsStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_variants
        abstract GetAvailableVariants: rootNode: TransformNode -> ResizeArray<string>
        abstract SelectVariant: rootNode: TransformNode * variantName: U2<string, ResizeArray<string>> -> unit
        abstract Reset: rootNode: TransformNode -> unit
        abstract GetLastSelectedVariant: rootNode: TransformNode -> Nullable<U2<string, ResizeArray<string>>>

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_unlit_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_unlit"]``: GLTFLoaderExtensionOptions__KHR_materials_unlit__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_unlit__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_unlit_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_unlit: KHR_materials_unlitStatic
        abstract RegisterKHR_materials_unlit: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_unlit =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_unlitStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_unlit

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_transmission_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_transmission"]``: GLTFLoaderExtensionOptions__KHR_materials_transmission__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_transmission__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_transmission_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_transmission: KHR_materials_transmissionStatic
        abstract RegisterKHR_materials_transmission: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_transmission =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_transmissionStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_transmission

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_specular_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_specular"]``: GLTFLoaderExtensionOptions__KHR_materials_specular__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_specular__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_specular_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_specular: KHR_materials_specularStatic
        abstract RegisterKHR_materials_specular: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_specular =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_specularStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_specular

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_sheen_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_sheen"]``: GLTFLoaderExtensionOptions__KHR_materials_sheen__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_sheen__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_sheen_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_sheen: KHR_materials_sheenStatic
        abstract RegisterKHR_materials_sheen: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_sheen =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_sheenStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_sheen

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_pbrSpecularGlossiness_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_pbrSpecularGlossiness"]``: GLTFLoaderExtensionOptions__KHR_materials_pbrSpecularGlossiness__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_pbrSpecularGlossiness__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_pbrSpecularGlossiness_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_pbrSpecularGlossiness: KHR_materials_pbrSpecularGlossinessStatic
        abstract RegisterKHR_materials_pbrSpecularGlossiness: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_pbrSpecularGlossiness =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_pbrSpecularGlossinessStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_pbrSpecularGlossiness

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_iridescence_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_iridescence"]``: GLTFLoaderExtensionOptions__KHR_materials_iridescence__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_iridescence__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_iridescence_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_iridescence: KHR_materials_iridescenceStatic
        abstract RegisterKHR_materials_iridescence: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_iridescence =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_iridescenceStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_iridescence

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_ior_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_ior"]``: GLTFLoaderExtensionOptions__KHR_materials_ior__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_ior__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_ior_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_ior: KHR_materials_iorStatic
        abstract RegisterKHR_materials_ior: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_ior =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_iorStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_ior

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_fuzz_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_fuzz"]``: GLTFLoaderExtensionOptions__KHR_materials_fuzz__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_fuzz__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_fuzz_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_fuzz: KHR_materials_fuzzStatic
        abstract RegisterKHR_materials_fuzz: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_fuzz =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_fuzzStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_fuzz

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_emissive_strength_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_emissive_strength"]``: GLTFLoaderExtensionOptions__KHR_materials_emissive_strength__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_emissive_strength__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_emissive_strength_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_emissive_strength: KHR_materials_emissive_strengthStatic
        abstract RegisterKHR_materials_emissive_strength: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_emissive_strength =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_emissive_strengthStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_emissive_strength

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_dispersion_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_dispersion"]``: GLTFLoaderExtensionOptions__KHR_materials_dispersion__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_dispersion__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_dispersion_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_dispersion: KHR_materials_dispersionStatic
        abstract RegisterKHR_materials_dispersion: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_dispersion =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_dispersionStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_dispersion

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_diffuse_transmission_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_diffuse_transmission"]``: GLTFLoaderExtensionOptions__KHR_materials_diffuse_transmission__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_diffuse_transmission__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_diffuse_transmission_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_diffuse_transmission: KHR_materials_diffuse_transmissionStatic
        abstract RegisterKHR_materials_diffuse_transmission: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_diffuse_transmission =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_diffuse_transmissionStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_diffuse_transmission

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_diffuse_roughness_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_diffuse_roughness"]``: GLTFLoaderExtensionOptions__KHR_materials_diffuse_roughness__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_diffuse_roughness__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_diffuse_roughness_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_diffuse_roughness: KHR_materials_diffuse_roughnessStatic
        abstract RegisterKHR_materials_diffuse_roughness: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_diffuse_roughness =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_diffuse_roughnessStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_diffuse_roughness

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_coat_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_coat"]``: GLTFLoaderExtensionOptions__KHR_materials_coat__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_coat__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_coat_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_coat: KHR_materials_coatStatic
        abstract RegisterKHR_materials_coat: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_coat =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_coatStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_coat

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_clearcoat_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_clearcoat"]``: GLTFLoaderExtensionOptions__KHR_materials_clearcoat__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_clearcoat__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_clearcoat_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_clearcoat: KHR_materials_clearcoatStatic
        abstract RegisterKHR_materials_clearcoat: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_clearcoat =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_clearcoatStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_clearcoat

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_anisotropy_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_materials_anisotropy"]``: GLTFLoaderExtensionOptions__KHR_materials_anisotropy__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_materials_anisotropy__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_materials_anisotropy_pure =
    type Nullable<'T> = 'T
    type Material = obj
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_materials_anisotropy: KHR_materials_anisotropyStatic
        abstract RegisterKHR_materials_anisotropy: unit -> unit

    type [<AllowNullLiteral>] KHR_materials_anisotropy =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float with get, set
        abstract dispose: unit -> unit
        abstract loadMaterialPropertiesAsync: context: string * material: IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_materials_anisotropyStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_materials_anisotropy

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_lights_punctual_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_lights_punctual"]``: GLTFLoaderExtensionOptions__KHR_lights_punctual__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_lights_punctual__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_lights_punctual_pure =
    type Nullable<'T> = 'T
    type TransformNode = obj
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_lights: KHR_lightsStatic
        abstract RegisterKHR_lights: unit -> unit

    type [<AllowNullLiteral>] KHR_lights =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract onLoading: unit -> unit
        abstract loadNodeAsync: context: string * node: INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>

    type [<AllowNullLiteral>] KHR_lightsStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_lights

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_interactivity"]``: GLTFLoaderExtensionOptions__KHR_interactivity__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_interactivity__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_pure =
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type Scene = obj

    type [<AllowNullLiteral>] IExports =
        abstract KHR_interactivity: KHR_interactivityStatic
        abstract _AddInteractivityObjectModel: scene: Scene -> unit
        abstract RegisterKHR_interactivity: unit -> unit

    type [<AllowNullLiteral>] KHR_interactivity =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract onReady: unit -> Promise<unit>

    type [<AllowNullLiteral>] KHR_interactivityStatic =
        [<EmitConstructor>] abstract Create: _loader: GLTFLoader -> KHR_interactivity

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_gaussian_splatting_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_gaussian_splatting"]``: GLTFLoaderExtensionOptions__KHR_gaussian_splatting__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_gaussian_splatting__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_gaussian_splatting_pure =
    type Nullable<'T> = 'T
    type AbstractMesh = obj
    type IMeshPrimitive = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMeshPrimitive
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IMesh = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMesh
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_gaussian_splatting: KHR_gaussian_splattingStatic
        abstract RegisterKHR_gaussian_splatting: unit -> unit

    type [<AllowNullLiteral>] KHR_gaussian_splatting =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract _loadMeshPrimitiveAsync: context: string * name: string * node: INode * mesh: IMesh * primitive: IMeshPrimitive * assign: (AbstractMesh -> unit) -> Nullable<Promise<AbstractMesh>>

    type [<AllowNullLiteral>] KHR_gaussian_splattingStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_gaussian_splatting

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_draco_mesh_compression_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_draco_mesh_compression"]``: GLTFLoaderExtensionOptions__KHR_draco_mesh_compression__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_draco_mesh_compression__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_draco_mesh_compression_pure =
    type DracoDecoder = obj
    type Nullable<'T> = 'T
    type Geometry = obj
    type Mesh = obj
    type IMeshPrimitive = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMeshPrimitive
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract KHR_draco_mesh_compression: KHR_draco_mesh_compressionStatic
        abstract RegisterKHR_draco_mesh_compression: unit -> unit

    type [<AllowNullLiteral>] KHR_draco_mesh_compression =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract dracoDecoder: DracoDecoder option with get, set
        abstract enabled: bool with get, set
        abstract useNormalizedFlagFromAccessor: bool with get, set
        abstract dispose: unit -> unit
        abstract _loadVertexDataAsync: context: string * primitive: IMeshPrimitive * babylonMesh: Mesh -> Nullable<Promise<Geometry>>

    type [<AllowNullLiteral>] KHR_draco_mesh_compressionStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_draco_mesh_compression

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_animation_pointer_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["KHR_animation_pointer"]``: GLTFLoaderExtensionOptions__KHR_animation_pointer__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__KHR_animation_pointer__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_animation_pointer_pure =
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type Nullable<'T> = 'T
    type Animation = obj
    type IAnimatable = obj
    type IAnimation = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimation
    type IAnimationChannel = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimationChannel

    type [<AllowNullLiteral>] IExports =
        abstract KHR_animation_pointer: KHR_animation_pointerStatic
        abstract RegisterKHR_animation_pointer: unit -> unit

    type [<AllowNullLiteral>] KHR_animation_pointer =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool
        abstract dispose: unit -> unit
        abstract _loadAnimationChannelAsync: context: string * animationContext: string * animation: IAnimation * channel: IAnimationChannel * onLoad: (IAnimatable -> Animation -> unit) -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] KHR_animation_pointerStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> KHR_animation_pointer

module Babylonjs_loaders_glTF_2_0_Extensions_ExtrasAsMetadata_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["ExtrasAsMetadata"]``: GLTFLoaderExtensionOptions__ExtrasAsMetadata__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__ExtrasAsMetadata__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_ExtrasAsMetadata_pure =
    type Nullable<'T> = 'T
    type TransformNode = obj
    type Camera = obj
    type AnimationGroup = obj
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type ICamera = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ICamera
    type IMaterial = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IMaterial
    type IAnimation = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IAnimation
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type Material = obj

    type [<AllowNullLiteral>] IExports =
        abstract ExtrasAsMetadata: ExtrasAsMetadataStatic
        abstract RegisterExtrasAsMetadata: unit -> unit

    type [<AllowNullLiteral>] ExtrasAsMetadata =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract loadNodeAsync: context: string * node: INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>
        abstract loadCameraAsync: context: string * camera: ICamera * assign: (Camera -> unit) -> Nullable<Promise<Camera>>
        abstract createMaterial: context: string * material: IMaterial * babylonDrawMode: float -> Nullable<Material>
        abstract loadAnimationAsync: context: string * animation: IAnimation -> Nullable<Promise<AnimationGroup>>

    type [<AllowNullLiteral>] ExtrasAsMetadataStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> ExtrasAsMetadata

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_texture_webp_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["EXT_texture_webp"]``: GLTFLoaderExtensionOptions__EXT_texture_webp__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__EXT_texture_webp__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_texture_webp_pure =
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type ITexture = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ITexture
    type BaseTexture = obj
    type Nullable<'T> = 'T

    type [<AllowNullLiteral>] IExports =
        abstract EXT_texture_webp: EXT_texture_webpStatic
        abstract RegisterEXT_texture_webp: unit -> unit

    type [<AllowNullLiteral>] EXT_texture_webp =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract _loadTextureAsync: context: string * texture: ITexture * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>

    type [<AllowNullLiteral>] EXT_texture_webpStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> EXT_texture_webp

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_texture_avif_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["EXT_texture_avif"]``: GLTFLoaderExtensionOptions__EXT_texture_avif__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__EXT_texture_avif__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_texture_avif_pure =
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type ITexture = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.ITexture
    type BaseTexture = obj
    type Nullable<'T> = 'T

    type [<AllowNullLiteral>] IExports =
        abstract EXT_texture_avif: EXT_texture_avifStatic
        abstract RegisterEXT_texture_avif: unit -> unit

    type [<AllowNullLiteral>] EXT_texture_avif =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract _loadTextureAsync: context: string * texture: ITexture * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>

    type [<AllowNullLiteral>] EXT_texture_avifStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> EXT_texture_avif

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_meshopt_compression_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["EXT_meshopt_compression"]``: GLTFLoaderExtensionOptions__EXT_meshopt_compression__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__EXT_meshopt_compression__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_meshopt_compression_pure =
    type Nullable<'T> = 'T
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type IBufferView = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IBufferView

    type [<AllowNullLiteral>] IExports =
        abstract EXT_meshopt_compression: EXT_meshopt_compressionStatic
        abstract RegisterEXT_meshopt_compression: unit -> unit

    type [<AllowNullLiteral>] EXT_meshopt_compression =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract loadBufferViewAsync: context: string * bufferView: IBufferView -> Nullable<Promise<ArrayBufferView>>

    type [<AllowNullLiteral>] EXT_meshopt_compressionStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> EXT_meshopt_compression

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_mesh_gpu_instancing_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["EXT_mesh_gpu_instancing"]``: GLTFLoaderExtensionOptions__EXT_mesh_gpu_instancing__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__EXT_mesh_gpu_instancing__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_mesh_gpu_instancing_pure =
    type TransformNode = obj
    type Nullable<'T> = 'T
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode

    type [<AllowNullLiteral>] IExports =
        abstract EXT_mesh_gpu_instancing: EXT_mesh_gpu_instancingStatic
        abstract RegisterEXT_mesh_gpu_instancing: unit -> unit

    type [<AllowNullLiteral>] EXT_mesh_gpu_instancing =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract loadNodeAsync: context: string * node: INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>

    type [<AllowNullLiteral>] EXT_mesh_gpu_instancingStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> EXT_mesh_gpu_instancing

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_image_based_types =
    type BaseTexture = obj

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["EXT_lights_image_based"]``: GLTFLoaderExtensionOptions__EXT_lights_image_based__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__EXT_lights_image_based__ =
            interface end

    module Babylonjs_gltf2interface_augmentation =

        type [<AllowNullLiteral>] IEXTLightsImageBased_LightImageBased =
            abstract _babylonTexture: BaseTexture option with get, set
            abstract _loaded: Promise<unit> option with get, set

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_image_based_pure =
    type Nullable<'T> = 'T
    type IScene = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IScene
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract EXT_lights_image_based: EXT_lights_image_basedStatic
        abstract RegisterEXT_lights_image_based: unit -> unit

    type [<AllowNullLiteral>] EXT_lights_image_based =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract onLoading: unit -> unit
        abstract loadSceneAsync: context: string * scene: IScene -> Nullable<Promise<unit>>

    type [<AllowNullLiteral>] EXT_lights_image_basedStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> EXT_lights_image_based

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_ies_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["EXT_lights_ies"]``: GLTFLoaderExtensionOptions__EXT_lights_ies__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__EXT_lights_ies__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_ies_pure =
    type Nullable<'T> = 'T
    type TransformNode = obj
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract EXT_lights_ies: EXT_lights_iesStatic
        abstract RegisterEXT_lights_ies: unit -> unit

    type [<AllowNullLiteral>] EXT_lights_ies =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract onLoading: unit -> unit
        abstract loadNodeAsync: context: string * node: INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>

    type [<AllowNullLiteral>] EXT_lights_iesStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> EXT_lights_ies

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_area_types =

    module Babylonjs_loaders_glTF_glTFFileLoader =

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
            abstract ``["EXT_lights_area"]``: GLTFLoaderExtensionOptions__EXT_lights_area__ with get, set

        type [<AllowNullLiteral>] GLTFLoaderExtensionOptions__EXT_lights_area__ =
            interface end

module Babylonjs_loaders_glTF_2_0_Extensions_EXT_lights_area_pure =
    type Nullable<'T> = 'T
    type TransformNode = obj
    type INode = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.INode
    type IGLTFLoaderExtension = Babylonjs_loaders_glTF_2_0_glTFLoaderExtension.IGLTFLoaderExtension
    type GLTFLoader = Babylonjs_loaders_glTF_2_0_glTFLoader_pure.GLTFLoader

    type [<AllowNullLiteral>] IExports =
        abstract EXT_lights_area: EXT_lights_areaStatic
        abstract RegisterEXT_lights_area: unit -> unit

    type [<AllowNullLiteral>] EXT_lights_area =
        inherit IGLTFLoaderExtension
        abstract name: string
        abstract enabled: bool with get, set
        abstract dispose: unit -> unit
        abstract onLoading: unit -> unit
        abstract loadNodeAsync: context: string * node: INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>

    type [<AllowNullLiteral>] EXT_lights_areaStatic =
        [<EmitConstructor>] abstract Create: loader: GLTFLoader -> EXT_lights_area

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_interactivityGraphParser =
    type IKHRInteractivity_Graph = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Graph
    type IGLTF = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IGLTF
    type IGLTFToFlowGraphMapping = Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_declarationMapper.IGLTFToFlowGraphMapping
    type ISerializedFlowGraph = obj
    type ISerializedFlowGraphBlock = obj
    type FlowGraphTypes = obj

    type [<AllowNullLiteral>] IExports =
        abstract gltfTypeToBabylonType: IExportsGltfTypeToBabylonType
        abstract InteractivityGraphToFlowGraphParser: InteractivityGraphToFlowGraphParserStatic

    type [<AllowNullLiteral>] InteractivityEvent =
        abstract eventId: string with get, set
        abstract eventData: ResizeArray<{| eventData: bool; id: string; ``type``: string; value: obj option |}> option with get, set

    type [<AllowNullLiteral>] InteractivityGraphToFlowGraphParser =
        abstract _animationTargetFps: float with get, set
        abstract arrays: InteractivityGraphToFlowGraphParserArrays
        abstract getVariableName: index: float -> string
        abstract serializeToFlowGraph: unit -> ISerializedFlowGraph

    type [<AllowNullLiteral>] InteractivityGraphToFlowGraphParserStatic =
        [<EmitConstructor>] abstract Create: _interactivityGraph: IKHRInteractivity_Graph * _gltf: IGLTF * ?_animationTargetFps: float -> InteractivityGraphToFlowGraphParser

    type [<StringEnum>] [<RequireQualifiedAccess>] IExportsGltfTypeToBabylonTypeItemElementType =
        | Number
        | Boolean

    type [<AllowNullLiteral>] IExportsGltfTypeToBabylonType =
        [<EmitIndexer>] abstract Item: key: string -> {| length: float; flowGraphType: FlowGraphTypes; elementType: IExportsGltfTypeToBabylonTypeItemElementType |} with get, set

    type [<AllowNullLiteral>] InteractivityGraphToFlowGraphParserArrays =
        abstract types: ResizeArray<{| length: float; flowGraphType: FlowGraphTypes; elementType: IExportsGltfTypeToBabylonTypeItemElementType |}> with get, set
        abstract mappings: ResizeArray<{| flowGraphMapping: IGLTFToFlowGraphMapping; fullOperationName: string |}> with get, set
        abstract staticVariables: ResizeArray<{| ``type``: FlowGraphTypes; value: ResizeArray<obj option> |}> with get, set
        abstract events: ResizeArray<InteractivityEvent> with get, set
        abstract nodes: ResizeArray<{| blocks: ResizeArray<ISerializedFlowGraphBlock>; fullOperationName: string |}> with get, set

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_flowGraphGLTFDataProvider =
    type IFlowGraphBlockConfiguration = BabylonjsBindings.FullCandidate.BABYLON.IFlowGraphBlockConfiguration
    type FlowGraphBlock = BabylonjsBindings.FullCandidate.BABYLON.FlowGraphBlock
    type IGLTF = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IGLTF
    type FlowGraphDataConnection<'T> = BabylonjsBindings.FullCandidate.BABYLON.FlowGraphDataConnection<'T>
    type AnimationGroup = obj
    type TransformNode = obj

    type [<AllowNullLiteral>] IExports =
        abstract FlowGraphGLTFDataProvider: FlowGraphGLTFDataProviderStatic

    type [<AllowNullLiteral>] IFlowGraphGLTFDataProviderBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract glTF: IGLTF with get, set

    type [<AllowNullLiteral>] FlowGraphGLTFDataProvider =
        inherit FlowGraphBlock
        abstract animationGroups: FlowGraphDataConnection<ResizeArray<AnimationGroup>>
        abstract nodes: FlowGraphDataConnection<ResizeArray<TransformNode>>
        abstract getClassName: unit -> string

    type [<AllowNullLiteral>] FlowGraphGLTFDataProviderStatic =
        [<EmitConstructor>] abstract Create: config: IFlowGraphGLTFDataProviderBlockConfiguration -> FlowGraphGLTFDataProvider

module Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_declarationMapper =
    type IKHRInteractivity_Declaration = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Declaration
    type IKHRInteractivity_Graph = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Graph
    type IKHRInteractivity_Node = BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Node
    type FlowGraphBlockNames = obj
    type ISerializedFlowGraphBlock = obj
    type ISerializedFlowGraphContext = obj
    type InteractivityGraphToFlowGraphParser = Babylonjs_loaders_glTF_2_0_Extensions_KHR_interactivity_interactivityGraphParser.InteractivityGraphToFlowGraphParser
    type IGLTF = Babylonjs_loaders_glTF_2_0_glTFLoaderInterfaces.IGLTF

    type [<AllowNullLiteral>] IExports =
        abstract getMappingForFullOperationName: fullOperationName: string -> IGLTFToFlowGraphMapping option
        abstract getMappingForDeclaration: declaration: IKHRInteractivity_Declaration * ?returnNoOpIfNotAvailable: bool -> IGLTFToFlowGraphMapping option
        abstract addNewInteractivityFlowGraphMapping: key: string * extension: string * mapping: IGLTFToFlowGraphMapping -> unit
        abstract getAllSupportedNativeNodeTypes: unit -> ResizeArray<string>

    type [<AllowNullLiteral>] IGLTFToFlowGraphMappingObject =
        abstract name: string with get, set
        abstract gltfType: string option with get, set
        abstract flowGraphType: string option with get, set
        abstract dataTransformer: (obj option -> InteractivityGraphToFlowGraphParser -> obj option) option with get, set
        abstract isArray: bool option with get, set
        abstract inOptions: bool option with get, set
        abstract isVariable: bool option with get, set
        abstract toBlock: FlowGraphBlockNames option with get, set
        abstract defaultValue: obj option with get, set

    type [<AllowNullLiteral>] IGLTFToFlowGraphMapping =
        abstract blocks: ResizeArray<U2<FlowGraphBlockNames, string>> with get, set
        abstract inputs: {| values: IGLTFToFlowGraphMappingInputsValues option; flows: IGLTFToFlowGraphMappingInputsValues option |} option with get, set
        abstract outputs: {| values: IGLTFToFlowGraphMappingInputsValues option; flows: IGLTFToFlowGraphMappingInputsValues option |} option with get, set
        abstract configuration: IGLTFToFlowGraphMappingInputsValues option with get, set
        abstract typeToTypeMapping: IGLTFToFlowGraphMappingInputsValues option with get, set
        abstract interBlockConnectors: ResizeArray<IGLTFToFlowGraphMappingInterBlockConnectors> option with get, set
        abstract validation: (IKHRInteractivity_Node -> IKHRInteractivity_Graph -> (IGLTF) option -> {| valid: bool; error: string option |}) option with get, set
        abstract extraProcessor: (IKHRInteractivity_Node -> IKHRInteractivity_Declaration -> IGLTFToFlowGraphMapping -> InteractivityGraphToFlowGraphParser -> ResizeArray<ISerializedFlowGraphBlock> -> ISerializedFlowGraphContext -> (IGLTF) option -> ResizeArray<ISerializedFlowGraphBlock>) option with get, set

    type [<AllowNullLiteral>] IGLTFToFlowGraphMappingInputsValues =
        [<EmitIndexer>] abstract Item: originName: string -> IGLTFToFlowGraphMappingObject with get, set

    type [<AllowNullLiteral>] IGLTFToFlowGraphMappingInterBlockConnectors =
        abstract input: string with get, set
        abstract output: string with get, set
        abstract inputBlockIndex: float with get, set
        abstract outputBlockIndex: float with get, set
        abstract isVariable: bool option with get, set

module Babylonjs_loaders_glTF_1_0_glTFMaterialsCommonExtension =
    type GLTFLoaderExtension = Babylonjs_loaders_glTF_1_0_glTFLoader.GLTFLoaderExtension
    type IGLTFRuntime = Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces.IGLTFRuntime
    type Material = obj

    type [<AllowNullLiteral>] IExports =
        abstract GLTFMaterialsCommonExtension: GLTFMaterialsCommonExtensionStatic

    type [<AllowNullLiteral>] GLTFMaterialsCommonExtension =
        inherit GLTFLoaderExtension
        abstract loadRuntimeExtensionsAsync: gltfRuntime: IGLTFRuntime -> bool
        abstract loadMaterialAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (Material -> unit) * onError: (string -> unit) -> bool

    type [<AllowNullLiteral>] GLTFMaterialsCommonExtensionStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFMaterialsCommonExtension

module Babylonjs_loaders_glTF_1_0_glTFLoaderUtils =
    type IGLTFTechniqueParameter = Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces.IGLTFTechniqueParameter
    type IGLTFAccessor = Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces.IGLTFAccessor
    type IGLTFRuntime = Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces.IGLTFRuntime
    type IGLTFBufferView = Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces.IGLTFBufferView
    type EComponentType = Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces.EComponentType
    type Effect = obj
    type ShaderMaterial = obj
    type Node = obj
    type Scene = obj

    type [<AllowNullLiteral>] IExports =
        abstract GLTFUtils: GLTFUtilsStatic

    type [<AllowNullLiteral>] GLTFUtils =
        interface end

    type [<AllowNullLiteral>] GLTFUtilsStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFUtils
        abstract SetMatrix: scene: Scene * source: Node * parameter: IGLTFTechniqueParameter * uniformName: string * shaderMaterial: U2<ShaderMaterial, Effect> -> unit
        abstract SetUniform: shaderMaterial: U2<ShaderMaterial, Effect> * uniform: string * value: obj option * ``type``: float -> bool
        abstract GetWrapMode: mode: float -> float
        abstract GetByteStrideFromType: accessor: IGLTFAccessor -> float
        abstract GetTextureFilterMode: mode: float -> float
        abstract GetBufferFromBufferView: gltfRuntime: IGLTFRuntime * bufferView: IGLTFBufferView * byteOffset: float * byteLength: float * componentType: EComponentType -> ArrayBufferView
        abstract GetBufferFromAccessor: gltfRuntime: IGLTFRuntime * accessor: IGLTFAccessor -> obj option
        abstract DecodeBufferToText: view: ArrayBufferView -> string
        abstract GetDefaultMaterial: scene: Scene -> ShaderMaterial

module Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces =
    type AssetContainer = obj
    type Bone = obj
    type Skeleton = obj
    type Texture = obj
    type Node = obj
    type Scene = obj
    type Nullable<'T> = 'T

    type EComponentType =
        | BYTE = 5120
        | UNSIGNED_BYTE = 5121
        | SHORT = 5122
        | UNSIGNED_SHORT = 5123
        | FLOAT = 5126

    type EShaderType =
        | FRAGMENT = 35632
        | VERTEX = 35633

    type EParameterType =
        | BYTE = 5120
        | UNSIGNED_BYTE = 5121
        | SHORT = 5122
        | UNSIGNED_SHORT = 5123
        | INT = 5124
        | UNSIGNED_INT = 5125
        | FLOAT = 5126
        | FLOAT_VEC2 = 35664
        | FLOAT_VEC3 = 35665
        | FLOAT_VEC4 = 35666
        | INT_VEC2 = 35667
        | INT_VEC3 = 35668
        | INT_VEC4 = 35669
        | BOOL = 35670
        | BOOL_VEC2 = 35671
        | BOOL_VEC3 = 35672
        | BOOL_VEC4 = 35673
        | FLOAT_MAT2 = 35674
        | FLOAT_MAT3 = 35675
        | FLOAT_MAT4 = 35676
        | SAMPLER_2D = 35678

    type ETextureWrapMode =
        | CLAMP_TO_EDGE = 33071
        | MIRRORED_REPEAT = 33648
        | REPEAT = 10497

    type ETextureFilterType =
        | NEAREST = 9728
        | LINEAR = 9728
        | NEAREST_MIPMAP_NEAREST = 9984
        | LINEAR_MIPMAP_NEAREST = 9985
        | NEAREST_MIPMAP_LINEAR = 9986
        | LINEAR_MIPMAP_LINEAR = 9987

    type ETextureFormat =
        | ALPHA = 6406
        | RGB = 6407
        | RGBA = 6408
        | LUMINANCE = 6409
        | LUMINANCE_ALPHA = 6410

    type ECullingType =
        | FRONT = 1028
        | BACK = 1029
        | FRONT_AND_BACK = 1032

    type EBlendingFunction =
        | ZERO = 0
        | ONE = 1
        | SRC_COLOR = 768
        | ONE_MINUS_SRC_COLOR = 769
        | DST_COLOR = 774
        | ONE_MINUS_DST_COLOR = 775
        | SRC_ALPHA = 770
        | ONE_MINUS_SRC_ALPHA = 771
        | DST_ALPHA = 772
        | ONE_MINUS_DST_ALPHA = 773
        | CONSTANT_COLOR = 32769
        | ONE_MINUS_CONSTANT_COLOR = 32770
        | CONSTANT_ALPHA = 32771
        | ONE_MINUS_CONSTANT_ALPHA = 32772
        | SRC_ALPHA_SATURATE = 776

    type [<AllowNullLiteral>] IGLTFProperty =
        abstract extensions: IGLTFPropertyExtensions option with get, set
        abstract extras: obj option with get, set

    type [<AllowNullLiteral>] IGLTFChildRootProperty =
        inherit IGLTFProperty
        abstract name: string option with get, set

    type [<AllowNullLiteral>] IGLTFAccessor =
        inherit IGLTFChildRootProperty
        abstract bufferView: string with get, set
        abstract byteOffset: float with get, set
        abstract byteStride: float with get, set
        abstract count: float with get, set
        abstract ``type``: string with get, set
        abstract componentType: EComponentType with get, set
        abstract max: ResizeArray<float> option with get, set
        abstract min: ResizeArray<float> option with get, set
        abstract name: string option with get, set

    type [<AllowNullLiteral>] IGLTFBufferView =
        inherit IGLTFChildRootProperty
        abstract buffer: string with get, set
        abstract byteOffset: float with get, set
        abstract byteLength: float with get, set
        abstract byteStride: float with get, set
        abstract target: float option with get, set

    type [<AllowNullLiteral>] IGLTFBuffer =
        inherit IGLTFChildRootProperty
        abstract uri: string with get, set
        abstract byteLength: float option with get, set
        abstract ``type``: string option with get, set

    type [<AllowNullLiteral>] IGLTFShader =
        inherit IGLTFChildRootProperty
        abstract uri: string with get, set
        abstract ``type``: EShaderType with get, set

    type [<AllowNullLiteral>] IGLTFProgram =
        inherit IGLTFChildRootProperty
        abstract attributes: ResizeArray<string> with get, set
        abstract fragmentShader: string with get, set
        abstract vertexShader: string with get, set

    type [<AllowNullLiteral>] IGLTFTechniqueParameter =
        abstract ``type``: float with get, set
        abstract count: float option with get, set
        abstract semantic: string option with get, set
        abstract node: string option with get, set
        abstract value: U4<float, bool, string, Array<obj option>> option with get, set
        abstract source: string option with get, set
        abstract babylonValue: obj option with get, set

    type [<AllowNullLiteral>] IGLTFTechniqueCommonProfile =
        abstract lightingModel: string with get, set
        abstract texcoordBindings: obj with get, set
        abstract parameters: Array<obj option> option with get, set

    type [<AllowNullLiteral>] IGLTFTechniqueStatesFunctions =
        abstract blendColor: ResizeArray<float> option with get, set
        abstract blendEquationSeparate: ResizeArray<float> option with get, set
        abstract blendFuncSeparate: ResizeArray<float> option with get, set
        abstract colorMask: ResizeArray<bool> with get, set
        abstract cullFace: ResizeArray<float> with get, set

    type [<AllowNullLiteral>] IGLTFTechniqueStates =
        abstract enable: ResizeArray<float> with get, set
        abstract functions: IGLTFTechniqueStatesFunctions with get, set

    type [<AllowNullLiteral>] IGLTFTechnique =
        inherit IGLTFChildRootProperty
        abstract parameters: IGLTFTechniqueParameters with get, set
        abstract program: string with get, set
        abstract attributes: IGLTFTechniqueAttributes with get, set
        abstract uniforms: IGLTFTechniqueAttributes with get, set
        abstract states: IGLTFTechniqueStates with get, set

    type [<AllowNullLiteral>] IGLTFMaterial =
        inherit IGLTFChildRootProperty
        abstract technique: string option with get, set
        abstract values: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] IGLTFMeshPrimitive =
        inherit IGLTFProperty
        abstract attributes: IGLTFTechniqueAttributes with get, set
        abstract indices: string with get, set
        abstract material: string with get, set
        abstract mode: float option with get, set

    type [<AllowNullLiteral>] IGLTFMesh =
        inherit IGLTFChildRootProperty
        abstract primitives: ResizeArray<IGLTFMeshPrimitive> with get, set

    type [<AllowNullLiteral>] IGLTFImage =
        inherit IGLTFChildRootProperty
        abstract uri: string with get, set

    type [<AllowNullLiteral>] IGLTFSampler =
        inherit IGLTFChildRootProperty
        abstract magFilter: float option with get, set
        abstract minFilter: float option with get, set
        abstract wrapS: float option with get, set
        abstract wrapT: float option with get, set

    type [<AllowNullLiteral>] IGLTFTexture =
        inherit IGLTFChildRootProperty
        abstract sampler: string with get, set
        abstract source: string with get, set
        abstract format: ETextureFormat option with get, set
        abstract internalFormat: ETextureFormat option with get, set
        abstract target: float option with get, set
        abstract ``type``: float option with get, set
        abstract babylonTexture: Texture option with get, set

    type [<AllowNullLiteral>] IGLTFAmbienLight =
        abstract color: ResizeArray<float> option with get, set

    type [<AllowNullLiteral>] IGLTFDirectionalLight =
        abstract color: ResizeArray<float> option with get, set

    type [<AllowNullLiteral>] IGLTFPointLight =
        abstract color: ResizeArray<float> option with get, set
        abstract constantAttenuation: float option with get, set
        abstract linearAttenuation: float option with get, set
        abstract quadraticAttenuation: float option with get, set

    type [<AllowNullLiteral>] IGLTFSpotLight =
        abstract color: ResizeArray<float> option with get, set
        abstract constantAttenuation: float option with get, set
        abstract fallOfAngle: float option with get, set
        abstract fallOffExponent: float option with get, set
        abstract linearAttenuation: float option with get, set
        abstract quadraticAttenuation: float option with get, set

    type [<AllowNullLiteral>] IGLTFLight =
        inherit IGLTFChildRootProperty
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] IGLTFCameraOrthographic =
        abstract xmag: float with get, set
        abstract ymag: float with get, set
        abstract zfar: float with get, set
        abstract znear: float with get, set

    type [<AllowNullLiteral>] IGLTFCameraPerspective =
        abstract aspectRatio: float with get, set
        abstract yfov: float with get, set
        abstract zfar: float with get, set
        abstract znear: float with get, set

    type [<AllowNullLiteral>] IGLTFCamera =
        inherit IGLTFChildRootProperty
        abstract ``type``: string with get, set

    type [<AllowNullLiteral>] IGLTFAnimationChannelTarget =
        abstract id: string with get, set
        abstract path: string with get, set

    type [<AllowNullLiteral>] IGLTFAnimationChannel =
        abstract sampler: string with get, set
        abstract target: IGLTFAnimationChannelTarget with get, set

    type [<AllowNullLiteral>] IGLTFAnimationSampler =
        abstract input: string with get, set
        abstract output: string with get, set
        abstract interpolation: string option with get, set

    type [<AllowNullLiteral>] IGLTFAnimation =
        inherit IGLTFChildRootProperty
        abstract channels: ResizeArray<IGLTFAnimationChannel> option with get, set
        abstract parameters: IGLTFTechniqueAttributes option with get, set
        abstract samplers: IGLTFAnimationSamplers option with get, set

    type [<AllowNullLiteral>] IGLTFNodeInstanceSkin =
        abstract skeletons: ResizeArray<string> with get, set
        abstract skin: string with get, set
        abstract meshes: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] IGLTFSkins =
        inherit IGLTFChildRootProperty
        abstract bindShapeMatrix: ResizeArray<float> with get, set
        abstract inverseBindMatrices: string with get, set
        abstract jointNames: ResizeArray<string> with get, set
        abstract babylonSkeleton: Skeleton option with get, set

    type [<AllowNullLiteral>] IGLTFNode =
        inherit IGLTFChildRootProperty
        abstract camera: string option with get, set
        abstract children: ResizeArray<string> with get, set
        abstract skin: string option with get, set
        abstract jointName: string option with get, set
        abstract light: string option with get, set
        abstract matrix: ResizeArray<float> with get, set
        abstract mesh: string option with get, set
        abstract meshes: ResizeArray<string> option with get, set
        abstract rotation: ResizeArray<float> option with get, set
        abstract scale: ResizeArray<float> option with get, set
        abstract translation: ResizeArray<float> option with get, set
        abstract babylonNode: Node option with get, set

    type [<AllowNullLiteral>] IGLTFScene =
        inherit IGLTFChildRootProperty
        abstract nodes: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] IGLTFRuntime =
        abstract extensions: IGLTFPropertyExtensions with get, set
        abstract accessors: IGLTFRuntimeAccessors with get, set
        abstract buffers: IGLTFRuntimeBuffers with get, set
        abstract bufferViews: IGLTFRuntimeBufferViews with get, set
        abstract meshes: IGLTFRuntimeMeshes with get, set
        abstract lights: IGLTFRuntimeLights with get, set
        abstract cameras: IGLTFRuntimeCameras with get, set
        abstract nodes: IGLTFRuntimeNodes with get, set
        abstract images: IGLTFRuntimeImages with get, set
        abstract textures: IGLTFRuntimeTextures with get, set
        abstract shaders: IGLTFRuntimeShaders with get, set
        abstract programs: IGLTFRuntimePrograms with get, set
        abstract samplers: IGLTFRuntimeSamplers with get, set
        abstract techniques: IGLTFRuntimeTechniques with get, set
        abstract materials: IGLTFRuntimeMaterials with get, set
        abstract animations: IGLTFRuntimeAnimations with get, set
        abstract skins: IGLTFRuntimeSkins with get, set
        abstract currentScene: obj option with get, set
        abstract scenes: IGLTFRuntimeScenes with get, set
        abstract extensionsUsed: ResizeArray<string> with get, set
        abstract extensionsRequired: ResizeArray<string> option with get, set
        abstract buffersCount: float with get, set
        abstract shaderscount: float with get, set
        abstract scene: Scene with get, set
        abstract rootUrl: string with get, set
        abstract loadedBufferCount: float with get, set
        abstract loadedBufferViews: IGLTFRuntimeLoadedBufferViews with get, set
        abstract loadedShaderCount: float with get, set
        abstract importOnlyMeshes: bool with get, set
        abstract importMeshesNames: ResizeArray<string> option with get, set
        abstract dummyNodes: ResizeArray<Node> with get, set
        abstract assetContainer: Nullable<AssetContainer> with get, set

    type [<AllowNullLiteral>] INodeToRoot =
        abstract bone: Bone with get, set
        abstract node: IGLTFNode with get, set
        abstract id: string with get, set

    type [<AllowNullLiteral>] IJointNode =
        abstract node: IGLTFNode with get, set
        abstract id: string with get, set

    type [<AllowNullLiteral>] IGLTFPropertyExtensions =
        [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

    type [<AllowNullLiteral>] IGLTFTechniqueParameters =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFTechniqueParameter with get, set

    type [<AllowNullLiteral>] IGLTFTechniqueAttributes =
        [<EmitIndexer>] abstract Item: key: string -> string with get, set

    type [<AllowNullLiteral>] IGLTFAnimationSamplers =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFAnimationSampler with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeAccessors =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFAccessor with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeBuffers =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFBuffer with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeBufferViews =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFBufferView with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeMeshes =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFMesh with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeLights =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFLight with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeCameras =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFCamera with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeNodes =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFNode with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeImages =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFImage with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeTextures =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFTexture with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeShaders =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFShader with get, set

    type [<AllowNullLiteral>] IGLTFRuntimePrograms =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFProgram with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeSamplers =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFSampler with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeTechniques =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFTechnique with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeMaterials =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFMaterial with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeAnimations =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFAnimation with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeSkins =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFSkins with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeScenes =
        [<EmitIndexer>] abstract Item: key: string -> IGLTFScene with get, set

    type [<AllowNullLiteral>] IGLTFRuntimeLoadedBufferViews =
        [<EmitIndexer>] abstract Item: name: string -> ArrayBufferView with get, set

module Babylonjs_loaders_glTF_1_0_glTFLoader =
    type IGLTFRuntime = Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces.IGLTFRuntime
    type Nullable<'T> = 'T
    type Material = obj
    type Texture = obj
    type ISceneLoaderAsyncResult = obj
    type ISceneLoaderProgressEvent = obj
    type Scene = obj
    type IGLTFLoader = Babylonjs_loaders_glTF_glTFFileLoader_pure.IGLTFLoader
    type IGLTFLoaderData = Babylonjs_loaders_glTF_glTFFileLoader_pure.IGLTFLoaderData
    type AssetContainer = obj

    type [<AllowNullLiteral>] IExports =
        abstract GLTFLoaderBase: GLTFLoaderBaseStatic
        abstract GLTFLoader: GLTFLoaderStatic
        abstract GLTFLoaderExtension: GLTFLoaderExtensionStatic

    type [<AllowNullLiteral>] GLTFLoaderBase =
        interface end

    type [<AllowNullLiteral>] GLTFLoaderBaseStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFLoaderBase
        abstract CreateRuntime: parsedData: obj option * scene: Scene * rootUrl: string -> IGLTFRuntime
        abstract LoadBufferAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) * ?onProgress: (unit -> unit) -> unit
        abstract LoadTextureBufferAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (Nullable<ArrayBufferView> -> unit) * onError: (string -> unit) -> unit
        abstract CreateTextureAsync: gltfRuntime: IGLTFRuntime * id: string * buffer: Nullable<ArrayBufferView> * onSuccess: (Texture -> unit) -> unit
        abstract LoadShaderStringAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (U2<string, ArrayBuffer> -> unit) * ?onError: (string -> unit) -> unit
        abstract LoadMaterialAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (Material -> unit) * onError: (string -> unit) -> unit

    type [<AllowNullLiteral>] GLTFLoader =
        inherit IGLTFLoader
        abstract dispose: unit -> unit
        abstract importMeshAsync: meshesNames: obj option * scene: Scene * assetContainer: Nullable<AssetContainer> * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) -> Promise<unit>

    type [<AllowNullLiteral>] GLTFLoaderStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFLoader
        abstract Extensions: GLTFLoaderStaticExtensions with get, set
        abstract RegisterExtension: extension: GLTFLoaderExtension -> unit

    type [<AllowNullLiteral>] GLTFLoaderExtension =
        abstract name: string
        abstract loadRuntimeAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onSuccess: (IGLTFRuntime -> unit) * ?onError: (string -> unit) -> bool
        abstract loadRuntimeExtensionsAsync: gltfRuntime: IGLTFRuntime * onSuccess: (unit -> unit) * ?onError: (string -> unit) -> bool
        abstract loadBufferAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) * ?onProgress: (unit -> unit) -> bool
        abstract loadTextureBufferAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) -> bool
        abstract createTextureAsync: gltfRuntime: IGLTFRuntime * id: string * buffer: ArrayBufferView * onSuccess: (Texture -> unit) * onError: (string -> unit) -> bool
        abstract loadShaderStringAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (string -> unit) * onError: (string -> unit) -> bool
        abstract loadMaterialAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (Material -> unit) * onError: (string -> unit) -> bool

    type [<AllowNullLiteral>] GLTFLoaderExtensionStatic =
        [<EmitConstructor>] abstract Create: name: string -> GLTFLoaderExtension
        abstract LoadRuntimeAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onSuccess: (IGLTFRuntime -> unit) * ?onError: (string -> unit) -> unit
        abstract LoadRuntimeExtensionsAsync: gltfRuntime: IGLTFRuntime * onSuccess: (unit -> unit) * ?onError: (string -> unit) -> unit
        abstract LoadBufferAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) * ?onProgress: (unit -> unit) -> unit
        abstract LoadTextureAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (Texture -> unit) * onError: (string -> unit) -> unit
        abstract LoadShaderStringAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (U2<string, ArrayBuffer> -> unit) * onError: (string -> unit) -> unit
        abstract LoadMaterialAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (Material -> unit) * onError: (string -> unit) -> unit

    type [<AllowNullLiteral>] GLTFLoaderStaticExtensions =
        [<EmitIndexer>] abstract Item: name: string -> GLTFLoaderExtension with get, set

module Babylonjs_loaders_glTF_1_0_glTFBinaryExtension =
    type GLTFLoaderExtension = Babylonjs_loaders_glTF_1_0_glTFLoader.GLTFLoaderExtension
    type Scene = obj
    type IGLTFLoaderData = Babylonjs_loaders_glTF_glTFFileLoader_pure.IGLTFLoaderData
    type IGLTFRuntime = Babylonjs_loaders_glTF_1_0_glTFLoaderInterfaces.IGLTFRuntime

    type [<AllowNullLiteral>] IExports =
        abstract GLTFBinaryExtension: GLTFBinaryExtensionStatic

    type [<AllowNullLiteral>] GLTFBinaryExtension =
        inherit GLTFLoaderExtension
        abstract loadRuntimeAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * onSuccess: (IGLTFRuntime -> unit) -> bool
        abstract loadBufferAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) -> bool
        abstract loadTextureBufferAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) -> bool
        abstract loadShaderStringAsync: gltfRuntime: IGLTFRuntime * id: string * onSuccess: (string -> unit) -> bool

    type [<AllowNullLiteral>] GLTFBinaryExtensionStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFBinaryExtension

module Babylonjs_loaders_STL_stlFileLoader_types =
    type STLFileLoaderMetadata = obj

    module Babylonjs_Loading_sceneLoader =

        type [<AllowNullLiteral>] SceneLoaderPluginOptions =
            abstract ``[STLFileLoaderMetadata.name]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set

        type [<AllowNullLiteral>] SceneLoaderPluginOptions_STLFileLoaderMetadataName_ =
            interface end

module Babylonjs_loaders_STL_stlFileLoader_pure =
    type Nullable<'T> = 'T
    type AbstractMesh = obj
    type ISceneLoaderPlugin = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPlugin
    type AssetContainer = obj
    type Scene = obj

    type [<AllowNullLiteral>] IExports =
        abstract STLFileLoader: STLFileLoaderStatic
        abstract RegisterSTLFileLoader: unit -> unit

    type [<AllowNullLiteral>] STLFileLoader =
        inherit ISceneLoaderPlugin
        abstract solidPattern: RegExp with get, set
        abstract facetsPattern: RegExp with get, set
        abstract normalPattern: RegExp with get, set
        abstract vertexPattern: RegExp with get, set
        abstract name: string
        abstract extensions: {| ``.stl``: {| isBinary: bool |} |}
        abstract importMesh: meshesNames: obj option * scene: Scene * data: obj option * rootUrl: string * meshes: Nullable<ResizeArray<AbstractMesh>> -> bool
        abstract load: scene: Scene * data: obj option * rootUrl: string -> bool
        abstract loadAssetContainer: scene: Scene * data: string * rootUrl: string -> AssetContainer

    type [<AllowNullLiteral>] STLFileLoaderStatic =
        [<EmitConstructor>] abstract Create: unit -> STLFileLoader
        abstract DO_NOT_ALTER_FILE_COORDINATES: bool with get, set

module Babylonjs_loaders_STL_stlFileLoader_metadata =

    type [<AllowNullLiteral>] IExports =
        abstract STLFileLoaderMetadata: {| name: string; extensions: {| ``.stl``: {| isBinary: bool |} |} |}

module Babylonjs_loaders_SPLAT_spz =
    type Scene = obj
    type Coroutine<'T> = BabylonjsBindings.FullCandidate.BABYLON.Coroutine<'T>
    type SPLATLoadingOptions = Babylonjs_loaders_SPLAT_splatLoadingOptions.SPLATLoadingOptions
    type IParsedSplat = Babylonjs_loaders_SPLAT_splatDefs.IParsedSplat

    type [<AllowNullLiteral>] IExports =
        abstract ParseSpz: data: ArrayBuffer * scene: Scene * _loadingOptions: SPLATLoadingOptions -> Promise<IParsedSplat>
        abstract GetSpzModule: url: string -> Promise<obj option>
        abstract ConvertSpzToSplat: cloud: obj option * scene: Scene * ?useCoroutine: bool -> Coroutine<IParsedSplat>
        abstract ConvertSpzToSplatAsync: cloud: obj option * scene: Scene -> Promise<IParsedSplat>

module Babylonjs_loaders_SPLAT_splatLoadingOptions =
    type GaussianSplattingMesh = BabylonjsBindings.FullCandidate.BABYLON.GaussianSplattingMesh

    type [<AllowNullLiteral>] SPLATLoadingOptions =
        abstract keepInRam: bool option with get, set
        abstract flipY: bool option with get, set
        abstract deflateURL: string option with get, set
        abstract fflate: obj option with get, set
        abstract disableAutoCameraLimits: bool option with get, set
        abstract gaussianSplattingMesh: GaussianSplattingMesh option with get, set
        abstract needsRotationScaleTextures: bool option with get, set
        abstract useSogTextures: bool option with get, set
        abstract spzLibraryUrl: string option with get, set

module Babylonjs_loaders_SPLAT_splatFileLoader_types =
    type SPLATFileLoaderMetadata = obj
    type SPLATLoadingOptions = Babylonjs_loaders_SPLAT_splatLoadingOptions.SPLATLoadingOptions

    module Babylonjs_Loading_sceneLoader =

        type [<AllowNullLiteral>] SceneLoaderPluginOptions =
            abstract ``[SPLATFileLoaderMetadata.name]``: obj with get, set

module Babylonjs_loaders_SPLAT_splatFileLoader_pure =
    type ISceneLoaderPluginAsync = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginAsync
    type ISceneLoaderPluginFactory = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginFactory
    type ISceneLoaderAsyncResult = obj
    type ISceneLoaderProgressEvent = obj
    type SceneLoaderPluginOptions = obj
    type AssetContainer = obj
    type Scene = obj
    type SPLATLoadingOptions = Babylonjs_loaders_SPLAT_splatLoadingOptions.SPLATLoadingOptions

    type [<AllowNullLiteral>] IExports =
        abstract SPLATFileLoader: SPLATFileLoaderStatic
        abstract RegisterSPLATFileLoader: unit -> unit

    type [<AllowNullLiteral>] SPLATFileLoader =
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract name: string
        abstract extensions: SPLATFileLoaderExtensions
        abstract createPlugin: options: SceneLoaderPluginOptions -> ISceneLoaderPluginAsync
        abstract importMeshAsync: meshesNames: obj option * scene: Scene * data: obj option * rootUrl: string * ?_onProgress: (ISceneLoaderProgressEvent -> unit) * ?_fileName: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAssetContainerAsync: scene: Scene * data: string * rootUrl: string -> Promise<AssetContainer>
        abstract loadAsync: scene: Scene * data: string * rootUrl: string -> Promise<unit>

    type [<AllowNullLiteral>] SPLATFileLoaderStatic =
        [<EmitConstructor>] abstract Create: ?loadingOptions: obj -> SPLATFileLoader

    type [<AllowNullLiteral>] SPLATFileLoaderExtensions =
        abstract ``.splat``: {| isBinary: bool |}
        abstract ``.ply``: {| isBinary: bool |}
        abstract ``.spz``: {| isBinary: bool |}
        abstract ``.json``: {| isBinary: bool |}
        abstract ``.sog``: {| isBinary: bool |}

module Babylonjs_loaders_SPLAT_splatFileLoader_metadata =

    type [<AllowNullLiteral>] IExports =
        abstract SPLATFileLoaderMetadata: {| name: string; extensions: IExportsSPLATFileLoaderMetadataExtensions |}

    type [<AllowNullLiteral>] IExportsSPLATFileLoaderMetadataExtensions =
        abstract ``.splat``: {| isBinary: bool |}
        abstract ``.ply``: {| isBinary: bool |}
        abstract ``.spz``: {| isBinary: bool |}
        abstract ``.json``: {| isBinary: bool |}
        abstract ``.sog``: {| isBinary: bool |}

module Babylonjs_loaders_SPLAT_splatDefs =
    type BaseTexture = obj

    type Mode =
        | Splat = 0
        | PointCloud = 1
        | Mesh = 2
        | Reject = 3

    type [<AllowNullLiteral>] ISogTexturePack =
        abstract version: ISogTexturePackVersion with get, set
        abstract splatCount: float with get, set
        abstract shDegree: float with get, set
        abstract meansTextureL: BaseTexture with get, set
        abstract meansTextureU: BaseTexture with get, set
        abstract scalesTexture: BaseTexture with get, set
        abstract quatsTexture: BaseTexture with get, set
        abstract sh0Texture: BaseTexture with get, set
        abstract shCentroidsTexture: BaseTexture option with get, set
        abstract shLabelsTexture: BaseTexture option with get, set
        abstract codebookTexture: BaseTexture option with get, set
        abstract meansMin: float * float * float with get, set
        abstract meansMax: float * float * float with get, set
        abstract scalesMin: (float * float * float) option with get, set
        abstract scalesMax: (float * float * float) option with get, set
        abstract sh0Min: (float * float * float * float) option with get, set
        abstract sh0Max: (float * float * float * float) option with get, set
        abstract shnMin: float option with get, set
        abstract shnMax: float option with get, set
        abstract shCoeffCount: float with get, set
        abstract positions: Float32Array with get, set

    type [<AllowNullLiteral>] IParsedSplat =
        abstract data: ArrayBuffer with get, set
        abstract mode: Mode with get, set
        abstract faces: ResizeArray<float> option with get, set
        abstract hasVertexColors: bool option with get, set
        abstract sh: ResizeArray<Uint8Array> option with get, set
        abstract shDegree: float option with get, set
        abstract trainedWithAntialiasing: bool option with get, set
        abstract compressed: bool option with get, set
        abstract rawSplat: bool option with get, set
        abstract safeOrbitCameraRadiusMin: float option with get, set
        abstract safeOrbitCameraElevationMinMax: (float * float) option with get, set
        abstract upAxis: IParsedSplatUpAxis option with get, set
        abstract chirality: IParsedSplatChirality option with get, set
        abstract sogTextures: ISogTexturePack option with get, set

    type ISogTexturePackVersion =
        | N1 = 1
        | N2 = 2

    type [<StringEnum>] [<RequireQualifiedAccess>] IParsedSplatUpAxis =
        | [<CompiledName("X")>] X
        | [<CompiledName("Y")>] Y
        | [<CompiledName("Z")>] Z

    type [<StringEnum>] [<RequireQualifiedAccess>] IParsedSplatChirality =
        | [<CompiledName("LeftHanded")>] LeftHanded
        | [<CompiledName("RightHanded")>] RightHanded

module Babylonjs_loaders_SPLAT_sog_pure =
    type Scene = obj
    type IParsedSplat = Babylonjs_loaders_SPLAT_splatDefs.IParsedSplat
    type GaussianSplattingDownloadManager = Babylonjs_loaders_SPLAT_gaussianSplattingDownloadManager.GaussianSplattingDownloadManager
    type DownloadGroupId = Babylonjs_loaders_SPLAT_gaussianSplattingDownloadManager.DownloadGroupId

    type [<AllowNullLiteral>] IExports =
        abstract ParseSogMeta: dataOrFiles: U2<SOGRootData, Map<string, Uint8Array>> * rootUrl: string * scene: Scene -> Promise<IParsedSplat>
        abstract ParseSogMetaAsTextures: dataOrFiles: U2<SOGRootData, Map<string, Uint8Array>> * rootUrl: string * scene: Scene * ?computeCpuPositions: bool * ?downloadManager: GaussianSplattingDownloadManager * ?downloadGroupId: DownloadGroupId -> Promise<IParsedSplat>

    type [<AllowNullLiteral>] SOGDataFile =
        abstract shape: ResizeArray<float> with get, set
        abstract dtype: string with get, set
        abstract mins: U2<float, ResizeArray<float>> option with get, set
        abstract maxs: U2<float, ResizeArray<float>> option with get, set
        abstract codebook: ResizeArray<float> option with get, set
        abstract encoding: string option with get, set
        abstract quantization: float option with get, set
        abstract files: ResizeArray<string> with get, set
        abstract bands: float option with get, set

    type [<AllowNullLiteral>] SOGRootData =
        abstract version: float option with get, set
        abstract means: SOGDataFile with get, set
        abstract scales: SOGDataFile with get, set
        abstract quats: SOGDataFile with get, set
        abstract sh0: SOGDataFile with get, set
        abstract shN: SOGDataFile option with get, set
        abstract count: float option with get, set

module Babylonjs_loaders_SPLAT_gaussianSplattingWorkBufferShaders =

    type [<AllowNullLiteral>] IExports =
        abstract GaussianSplattingWorkBufferShaderName: obj
        abstract GaussianSplattingWorkBufferVertexShaderGLSL: obj
        abstract GaussianSplattingWorkBufferFragmentShaderGLSL: obj
        abstract GaussianSplattingWorkBufferVertexShaderWGSL: obj
        abstract GaussianSplattingWorkBufferFragmentShaderWGSL: obj
        abstract GaussianSplattingWorkBufferRelayoutShaderName: obj
        abstract GaussianSplattingWorkBufferRelayoutFragmentShaderGLSL: obj
        abstract GaussianSplattingWorkBufferRelayoutFragmentShaderWGSL: obj

module Babylonjs_loaders_SPLAT_gaussianSplattingWorkBuffer =
    type Texture = obj
    type Scene = obj
    type Nullable<'T> = 'T
    type ISogTexturePack = Babylonjs_loaders_SPLAT_splatDefs.ISogTexturePack

    type [<AllowNullLiteral>] IExports =
        abstract GaussianSplattingWorkBuffer: GaussianSplattingWorkBufferStatic

    type [<AllowNullLiteral>] GaussianSplattingWorkBuffer =
        abstract supportsAsyncCentersReadback: bool
        abstract textureSize: float
        abstract textures: ResizeArray<Texture>
        abstract decodeAsync: pack: ISogTexturePack * offset: float -> Promise<unit>
        abstract isRelayoutReady: unit -> bool
        abstract relayoutSync: srcIndexByDst: Float32Array -> unit
        abstract readCentersRangeAsync: splatOffset: float * splatCount: float -> Promise<Nullable<Float32Array>>
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] GaussianSplattingWorkBufferStatic =
        [<EmitConstructor>] abstract Create: scene: Scene * capacity: float -> GaussianSplattingWorkBuffer

module Babylonjs_loaders_SPLAT_gaussianSplattingStream =
    type GaussianSplattingMesh = BabylonjsBindings.FullCandidate.BABYLON.GaussianSplattingMesh
    type Scene = obj
    type Nullable<'T> = 'T
    type Camera = obj
    type BoundingInfo = obj

    type [<AllowNullLiteral>] IExports =
        abstract GaussianSplattingStream: GaussianSplattingStreamStatic

    type [<AllowNullLiteral>] ISOGLODEntry =
        abstract file: float with get, set
        abstract offset: float with get, set
        abstract count: float with get, set

    type [<AllowNullLiteral>] ISOGLODNode =
        abstract bound: {| min: ResizeArray<float>; max: ResizeArray<float> |} with get, set
        abstract children: ResizeArray<ISOGLODNode> option with get, set
        abstract lods: ISOGLODNodeLods option with get, set
        abstract activeLod: float option with get, set
        abstract optimalLod: float option with get, set
        abstract availableLevels: ResizeArray<float> option with get, set
        abstract baseLod: float option with get, set
        abstract targetLevel: float option with get, set
        abstract lodCooldown: float option with get, set
        abstract inFrustum: bool option with get, set
        abstract cullBounds: BoundingInfo option with get, set
        abstract pendingFile: float option with get, set
        abstract activeFile: float option with get, set

    type [<AllowNullLiteral>] ISOGLODMetadata =
        abstract lodLevels: float with get, set
        abstract filenames: ResizeArray<string> with get, set
        abstract environment: string option with get, set
        abstract tree: ISOGLODNode with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] GaussianSplattingStreamDebugLodSource =
        | Optimal
        | Current

    type [<AllowNullLiteral>] IGaussianSplattingStreamOptions =
        abstract deflateURL: string option with get, set
        abstract fflate: obj option with get, set
        abstract debugDisplay: bool option with get, set
        abstract debugLodSource: GaussianSplattingStreamDebugLodSource option with get, set
        abstract lodBaseDistance: float option with get, set
        abstract lodMultiplier: float option with get, set
        abstract lodBehindPenalty: float option with get, set
        abstract lodRangeMin: float option with get, set
        abstract lodRangeMax: float option with get, set
        abstract maxDecodesPerFrame: float option with get, set
        abstract lodCooldownFrames: float option with get, set
        abstract lodUpdateInterval: float option with get, set
        abstract lodUpdateDistance: float option with get, set
        abstract maxDetailLod: float option with get, set
        abstract frustumCulling: bool option with get, set
        abstract maxConcurrentDownloads: float option with get, set
        abstract maxDownloadRetries: float option with get, set
        abstract memoryBudgetMb: float option with get, set
        abstract maxResidentSplats: float option with get, set
        abstract evictionCooldownFrames: float option with get, set

    type [<AllowNullLiteral>] GaussianSplattingStream =
        inherit GaussianSplattingMesh
        abstract getClassName: unit -> string
        abstract whenSettledAsync: ?stableFrames: float -> Promise<unit>
        abstract maxDetailLod: float with get, set
        abstract maxLodLevel: float
        abstract frustumCulling: bool with get, set
        abstract debugDisplay: bool with get, set
        abstract debugLodSource: GaussianSplattingStreamDebugLodSource with get, set
        abstract dispose: ?doNotRecurse: bool -> unit
        abstract evaluateOptimalLods: ?camera: Nullable<Camera> -> unit

    type [<AllowNullLiteral>] GaussianSplattingStreamStatic =
        abstract IsLODMetadata: data: obj -> bool
        [<EmitConstructor>] abstract Create: name: string * metadata: ISOGLODMetadata * rootUrl: string * scene: Scene * ?options: IGaussianSplattingStreamOptions -> GaussianSplattingStream

    type [<AllowNullLiteral>] ISOGLODNodeLods =
        [<EmitIndexer>] abstract Item: level: string -> ISOGLODEntry with get, set

module Babylonjs_loaders_SPLAT_gaussianSplattingResidencyController =
    type Nullable<'T> = 'T

    type [<AllowNullLiteral>] IExports =
        abstract GaussianSplattingResidencyController: GaussianSplattingResidencyControllerStatic

    type [<AllowNullLiteral>] IResidencyMove =
        abstract file: float with get, set
        abstract oldOffset: float with get, set
        abstract newOffset: float with get, set
        abstract count: float with get, set

    type [<AllowNullLiteral>] GaussianSplattingResidencyController =
        abstract capacity: float
        abstract residentCount: float
        abstract freeSize: float
        abstract has: file: float -> bool
        abstract offset: file: float -> float option
        abstract allocate: file: float * count: float -> Nullable<float>
        abstract pin: file: float * count: float -> Nullable<float>
        abstract free: file: float -> unit
        abstract compact: unit -> ResizeArray<IResidencyMove>
        abstract getResidentBlocks: unit -> Array<{| file: float; offset: float; count: float |}>
        abstract scheduleEviction: file: float -> unit
        abstract cancelEviction: file: float -> unit
        abstract tick: unit -> ResizeArray<float>
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] GaussianSplattingResidencyControllerStatic =
        [<EmitConstructor>] abstract Create: capacity: float * cooldownFrames: float * onEvict: (float -> unit) -> GaussianSplattingResidencyController

module Babylonjs_loaders_SPLAT_gaussianSplattingDownloadManager =

    type [<AllowNullLiteral>] IExports =
        abstract GaussianSplattingDownloadManager: GaussianSplattingDownloadManagerStatic

    type [<AllowNullLiteral>] IGaussianSplattingDownloadManagerOptions =
        abstract maxConcurrent: float option with get, set
        abstract maxRetries: float option with get, set

    type DownloadGroupId =
        U2<string, float>

    type [<AllowNullLiteral>] GaussianSplattingDownloadManager =
        abstract maxConcurrent: float
        abstract maxRetries: float
        abstract isIdle: bool
        abstract loadFileAsync: url: string * ?groupId: DownloadGroupId -> Promise<ArrayBuffer>
        abstract cancel: url: string -> unit
        abstract cancelGroup: groupId: DownloadGroupId -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] GaussianSplattingDownloadManagerStatic =
        [<EmitConstructor>] abstract Create: ?options: IGaussianSplattingDownloadManagerOptions -> GaussianSplattingDownloadManager

module Babylonjs_loaders_SPLAT_gaussianSplattingBlockAllocator =
    type Nullable<'T> = 'T

    type [<AllowNullLiteral>] IExports =
        abstract GaussianSplattingMemBlock: GaussianSplattingMemBlockStatic
        abstract GaussianSplattingBlockAllocator: GaussianSplattingBlockAllocatorStatic

    type [<AllowNullLiteral>] GaussianSplattingMemBlock =
        abstract _offset: float with get, set
        abstract _size: float with get, set
        abstract _free: bool with get, set
        abstract _prev: Nullable<GaussianSplattingMemBlock> with get, set
        abstract _next: Nullable<GaussianSplattingMemBlock> with get, set
        abstract _prevFree: Nullable<GaussianSplattingMemBlock> with get, set
        abstract _nextFree: Nullable<GaussianSplattingMemBlock> with get, set
        abstract _bucket: float with get, set
        abstract offset: float
        abstract size: float

    type [<AllowNullLiteral>] GaussianSplattingMemBlockStatic =
        [<EmitConstructor>] abstract Create: unit -> GaussianSplattingMemBlock

    type [<AllowNullLiteral>] GaussianSplattingBlockAllocator =
        abstract capacity: float
        abstract usedSize: float
        abstract freeSize: float
        abstract fragmentation: float
        abstract allocate: size: float -> Nullable<GaussianSplattingMemBlock>
        abstract free: block: GaussianSplattingMemBlock -> unit
        abstract grow: newCapacity: float -> unit
        abstract defrag: ?maxMoves: float * ?result: Set<GaussianSplattingMemBlock> -> Set<GaussianSplattingMemBlock>
        abstract updateAllocation: toFree: ResizeArray<GaussianSplattingMemBlock> * toAllocate: Array<U2<float, GaussianSplattingMemBlock>> -> bool

    type [<AllowNullLiteral>] GaussianSplattingBlockAllocatorStatic =
        [<EmitConstructor>] abstract Create: ?capacity: float * ?growMultiplier: float -> GaussianSplattingBlockAllocator

module Babylonjs_loaders_OBJ_solidParser =
    type AssetContainer = obj
    type Mesh = obj
    type Scene = obj
    type Nullable<'T> = 'T
    type OBJLoadingOptions = Babylonjs_loaders_OBJ_objLoadingOptions.OBJLoadingOptions

    type [<AllowNullLiteral>] IExports =
        abstract SolidParser: SolidParserStatic

    type [<AllowNullLiteral>] SolidParser =
        abstract parse: meshesNames: obj option * data: string * scene: Scene * assetContainer: Nullable<AssetContainer> * onFileToLoadFound: (string -> unit) -> unit

    type [<AllowNullLiteral>] SolidParserStatic =
        abstract ObjectDescriptor: RegExp with get, set
        abstract GroupDescriptor: RegExp with get, set
        abstract MtlLibGroupDescriptor: RegExp with get, set
        abstract UseMtlDescriptor: RegExp with get, set
        abstract SmoothDescriptor: RegExp with get, set
        abstract VertexPattern: RegExp with get, set
        abstract NormalPattern: RegExp with get, set
        abstract UVPattern: RegExp with get, set
        abstract FacePattern1: RegExp with get, set
        abstract FacePattern2: RegExp with get, set
        abstract FacePattern3: RegExp with get, set
        abstract FacePattern4: RegExp with get, set
        abstract FacePattern5: RegExp with get, set
        abstract LinePattern1: RegExp with get, set
        abstract LinePattern2: RegExp with get, set
        abstract LinePattern3: RegExp with get, set
        [<EmitConstructor>] abstract Create: materialToUse: ResizeArray<string> * babylonMeshesArray: Array<Mesh> * loadingOptions: OBJLoadingOptions -> SolidParser

module Babylonjs_loaders_OBJ_objLoadingOptions =
    type Vector2 = obj

    type [<AllowNullLiteral>] OBJLoadingOptions =
        abstract optimizeWithUV: bool with get, set
        abstract UVScaling: Vector2 with get, set
        abstract invertY: bool with get, set
        abstract invertTextureY: bool with get, set
        abstract importVertexColors: bool with get, set
        abstract computeNormals: bool with get, set
        abstract optimizeNormals: bool with get, set
        abstract skipMaterials: bool with get, set
        abstract materialLoadingFailsSilently: bool with get, set
        abstract useLegacyBehavior: bool with get, set

module Babylonjs_loaders_OBJ_objFileLoader_types =
    type OBJFileLoaderMetadata = obj
    type OBJLoadingOptions = Babylonjs_loaders_OBJ_objLoadingOptions.OBJLoadingOptions

    module Babylonjs_Loading_sceneLoader =

        type [<AllowNullLiteral>] SceneLoaderPluginOptions =
            abstract ``[OBJFileLoaderMetadata.name]``: obj with get, set

module Babylonjs_loaders_OBJ_objFileLoader_pure =
    type Vector2 = obj
    type ISceneLoaderPluginAsync = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginAsync
    type ISceneLoaderPluginFactory = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginFactory
    type ISceneLoaderPlugin = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPlugin
    type ISceneLoaderAsyncResult = obj
    type SceneLoaderPluginOptions = obj
    type AssetContainer = obj
    type Scene = obj
    type OBJLoadingOptions = Babylonjs_loaders_OBJ_objLoadingOptions.OBJLoadingOptions

    type [<AllowNullLiteral>] IExports =
        abstract OBJFileLoader: OBJFileLoaderStatic
        abstract RegisterOBJFileLoader: unit -> unit

    type [<AllowNullLiteral>] OBJFileLoader =
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract name: string
        abstract extensions: string
        abstract createPlugin: options: SceneLoaderPluginOptions -> U2<ISceneLoaderPluginAsync, ISceneLoaderPlugin>
        abstract canDirectLoad: unit -> bool
        abstract importMeshAsync: meshesNames: obj option * scene: Scene * data: obj option * rootUrl: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: string * rootUrl: string -> Promise<unit>
        abstract loadAssetContainerAsync: scene: Scene * data: string * rootUrl: string -> Promise<AssetContainer>

    type [<AllowNullLiteral>] OBJFileLoaderStatic =
        abstract OPTIMIZE_WITH_UV: bool with get, set
        abstract INVERT_Y: bool with get, set
        abstract INVERT_TEXTURE_Y: bool with get, set
        abstract IMPORT_VERTEX_COLORS: bool with get, set
        abstract COMPUTE_NORMALS: bool with get, set
        abstract OPTIMIZE_NORMALS: bool with get, set
        abstract UV_SCALING: Vector2 with get, set
        abstract SKIP_MATERIALS: bool with get, set
        abstract MATERIAL_LOADING_FAILS_SILENTLY: bool with get, set
        abstract USE_LEGACY_BEHAVIOR: bool with get, set
        [<EmitConstructor>] abstract Create: ?loadingOptions: obj -> OBJFileLoader

module Babylonjs_loaders_OBJ_objFileLoader_metadata =

    type [<AllowNullLiteral>] IExports =
        abstract OBJFileLoaderMetadata: {| name: string; extensions: string |}

module Babylonjs_loaders_OBJ_mtlFileLoader =
    type Nullable<'T> = 'T
    type StandardMaterial = obj
    type Scene = obj
    type AssetContainer = obj

    type [<AllowNullLiteral>] IExports =
        abstract MTLFileLoader: MTLFileLoaderStatic

    type [<AllowNullLiteral>] MTLFileLoader =
        abstract materials: ResizeArray<StandardMaterial> with get, set
        abstract parseMTL: scene: Scene * data: U2<string, ArrayBuffer> * rootUrl: string * assetContainer: Nullable<AssetContainer> -> unit

    type [<AllowNullLiteral>] MTLFileLoaderStatic =
        [<EmitConstructor>] abstract Create: unit -> MTLFileLoader
        abstract INVERT_TEXTURE_Y: bool with get, set

module Babylonjs_loaders_FBX_fbxFileLoader_types =
    type FBXFileLoaderMetadata = obj
    type FBXFileLoaderOptions = Babylonjs_loaders_FBX_fbxFileLoader_pure.FBXFileLoaderOptions

    module Babylonjs_Loading_sceneLoader =

        type [<AllowNullLiteral>] SceneLoaderPluginOptions =
            abstract ``[FBXFileLoaderMetadata.name]``: obj with get, set

module Babylonjs_loaders_FBX_fbxFileLoader_pure =
    type ISceneLoaderPluginAsync = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginAsync
    type ISceneLoaderPluginFactory = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginFactory
    type ISceneLoaderAsyncResult = obj
    type ISceneLoaderProgressEvent = obj
    type SceneLoaderPluginOptions = obj
    type Scene = obj
    type AssetContainer = obj

    type [<AllowNullLiteral>] IExports =
        abstract FBXFileLoader: FBXFileLoaderStatic
        abstract RegisterFBXFileLoader: unit -> unit

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXNormalMapCoordinateSystem =
        | [<CompiledName("y-up")>] YUp
        | [<CompiledName("y-down")>] YDown

    type [<AllowNullLiteral>] FBXFileLoaderOptions =
        abstract normalMapCoordinateSystem: FBXNormalMapCoordinateSystem option with get, set

    type [<AllowNullLiteral>] FBXFileLoader =
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract name: string
        abstract extensions: {| ``.fbx``: {| isBinary: bool |} |}
        abstract createPlugin: options: SceneLoaderPluginOptions -> ISceneLoaderPluginAsync
        abstract importMeshAsync: meshesNames: U2<string, ResizeArray<string>> option * scene: Scene * data: obj * rootUrl: string * ?_onProgress: (ISceneLoaderProgressEvent -> unit) * ?_fileName: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: obj * rootUrl: string * ?_onProgress: (ISceneLoaderProgressEvent -> unit) * ?_fileName: string -> Promise<unit>
        abstract loadAssetContainerAsync: scene: Scene * data: obj * rootUrl: string * ?_onProgress: (ISceneLoaderProgressEvent -> unit) * ?_fileName: string -> Promise<AssetContainer>

    type [<AllowNullLiteral>] FBXFileLoaderStatic =
        [<EmitConstructor>] abstract Create: ?options: FBXFileLoaderOptions -> FBXFileLoader

module Babylonjs_loaders_FBX_fbxFileLoader_metadata =

    type [<AllowNullLiteral>] IExports =
        abstract FBXFileLoaderMetadata: {| name: string; extensions: {| ``.fbx``: {| isBinary: bool |} |} |}

module Babylonjs_loaders_FBX_types_fbxTypes =

    type [<AllowNullLiteral>] IExports =
        abstract findChildByName: node: FBXNode * name: string -> FBXNode option
        abstract findChildrenByName: node: FBXNode * name: string -> ResizeArray<FBXNode>
        abstract findDocumentNode: doc: FBXDocument * name: string -> FBXNode option
        abstract getPropertyValue: node: FBXNode * index: float -> 'T option
        abstract getSafeFBXObjectId: value: obj -> float option
        abstract getNodeId: node: FBXNode -> float option
        abstract cleanFBXName: fbxName: string -> string

    type FBXPropertyValue =
        U7<bool, float, string, Float32Array, Float64Array, Int32Array, Uint8Array>

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXPropertyType =
        | Boolean
        | Int16
        | Int32
        | Int64
        | Float32
        | Float64
        | String
        | Raw
        | [<CompiledName("float32[]")>] Float32_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET
        | [<CompiledName("float64[]")>] Float64_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET
        | [<CompiledName("int32[]")>] Int32_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET
        | [<CompiledName("int64[]")>] Int64_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET
        | [<CompiledName("boolean[]")>] Boolean_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET

    type [<AllowNullLiteral>] FBXProperty =
        abstract ``type``: FBXPropertyType with get, set
        abstract value: FBXPropertyValue with get, set

    type [<AllowNullLiteral>] FBXNode =
        abstract name: string with get, set
        abstract properties: ResizeArray<FBXProperty> with get, set
        abstract children: ResizeArray<FBXNode> with get, set

    type [<AllowNullLiteral>] FBXDocument =
        abstract version: float with get, set
        abstract nodes: ResizeArray<FBXNode> with get, set

module Babylonjs_loaders_FBX_parsers_zlibInflate =

    type [<AllowNullLiteral>] IExports =
        abstract inflateZlib: input: Uint8Array * expectedLength: float -> Uint8Array

module Babylonjs_loaders_FBX_parsers_fbxBinaryParser =
    type FBXDocument = Babylonjs_loaders_FBX_types_fbxTypes.FBXDocument

    type [<AllowNullLiteral>] IExports =
        abstract parseBinaryFBX: buffer: ArrayBuffer -> FBXDocument

module Babylonjs_loaders_FBX_parsers_fbxAsciiParser =
    type FBXDocument = Babylonjs_loaders_FBX_types_fbxTypes.FBXDocument

    type [<AllowNullLiteral>] IExports =
        abstract parseAsciiFBX: text: string -> FBXDocument

module Babylonjs_loaders_FBX_interpreter_transform =
    type Matrix = obj

    type [<AllowNullLiteral>] IExports =
        abstract eulerToMatrixXYZ: rx: float * ry: float * rz: float -> Matrix
        abstract eulerToMatrix: rx: float * ry: float * rz: float * order: float -> Matrix
        abstract computeFBXGeometricMatrix: translation: FBXVector3 * rotation: FBXVector3 * scale: FBXVector3 -> Matrix
        abstract computeFBXGeometricDeltaMatrix: rotation: FBXVector3 * scale: FBXVector3 -> Matrix
        abstract computeFBXGeometricNormalMatrix: rotation: FBXVector3 * scale: FBXVector3 -> Matrix
        abstract computeFBXLocalMatrix: components: FBXTransformComponents -> Matrix

    type FBXVector3 =
        float * float * float

    type [<AllowNullLiteral>] FBXTransformComponents =
        abstract translation: FBXVector3 with get, set
        abstract rotation: FBXVector3 with get, set
        abstract scale: FBXVector3 with get, set
        abstract preRotation: FBXVector3 with get, set
        abstract postRotation: FBXVector3 with get, set
        abstract rotationPivot: FBXVector3 with get, set
        abstract scalingPivot: FBXVector3 with get, set
        abstract rotationOffset: FBXVector3 with get, set
        abstract scalingOffset: FBXVector3 with get, set
        abstract rotationOrder: float with get, set
        abstract inheritType: float option with get, set

module Babylonjs_loaders_FBX_interpreter_skeleton =
    type FBXNode = Babylonjs_loaders_FBX_types_fbxTypes.FBXNode
    type FBXObjectMap = Babylonjs_loaders_FBX_interpreter_connections.FBXObjectMap

    type [<AllowNullLiteral>] IExports =
        abstract extractSkins: objectMap: FBXObjectMap -> ResizeArray<FBXSkinData>
        abstract isSkeletonModel: modelNode: FBXNode -> bool
        abstract extractBoneTransform: modelNode: FBXNode -> ExtractBoneTransformReturn

    type [<AllowNullLiteral>] ExtractBoneTransformReturn =
        abstract translation: float * float * float with get, set
        abstract rotation: float * float * float with get, set
        abstract preRotation: float * float * float with get, set
        abstract postRotation: float * float * float with get, set
        abstract rotationPivot: float * float * float with get, set
        abstract scalingPivot: float * float * float with get, set
        abstract rotationOffset: float * float * float with get, set
        abstract scalingOffset: float * float * float with get, set
        abstract scale: float * float * float with get, set
        abstract rotationOrder: float with get, set
        abstract inheritType: float with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXClusterMode =
        | [<CompiledName("Normalize")>] Normalize
        | [<CompiledName("Additive")>] Additive
        | [<CompiledName("TotalOne")>] TotalOne
        | [<CompiledName("Unknown")>] Unknown

    type [<AllowNullLiteral>] FBXSkinDiagnostic =
        abstract ``type``: FBXSkinDiagnosticType with get, set
        abstract message: string with get, set
        abstract boneModelId: float option with get, set
        abstract boneName: string option with get, set
        abstract clusterMode: FBXClusterMode option with get, set

    type [<AllowNullLiteral>] FBXBoneData =
        abstract modelId: float with get, set
        abstract name: string with get, set
        abstract index: float with get, set
        abstract parentIndex: float with get, set
        abstract isCluster: bool with get, set
        abstract translation: float * float * float with get, set
        abstract rotation: float * float * float with get, set
        abstract preRotation: float * float * float with get, set
        abstract postRotation: float * float * float with get, set
        abstract rotationPivot: float * float * float with get, set
        abstract scalingPivot: float * float * float with get, set
        abstract rotationOffset: float * float * float with get, set
        abstract scalingOffset: float * float * float with get, set
        abstract scale: float * float * float with get, set
        abstract rotationOrder: float with get, set
        abstract inheritType: float with get, set
        abstract clusterMode: FBXClusterMode with get, set
        abstract bindPoseMatrix: Float64Array option with get, set
        abstract transformLinkMatrix: Float64Array option with get, set
        abstract transformAssociateModelMatrix: Float64Array option with get, set
        abstract modelBindPoseMatrix: Float64Array option with get, set
        abstract diagnostics: ResizeArray<FBXSkinDiagnostic> with get, set

    type [<AllowNullLiteral>] FBXSkinData =
        abstract id: float with get, set
        abstract geometryId: float with get, set
        abstract meshBindPoseMatrix: Float64Array option with get, set
        abstract bones: ResizeArray<FBXBoneData> with get, set
        abstract boneIndices: ResizeArray<ResizeArray<float>> with get, set
        abstract boneWeights: ResizeArray<ResizeArray<float>> with get, set
        abstract diagnostics: ResizeArray<FBXSkinDiagnostic> with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXSkinDiagnosticType =
        | [<CompiledName("cluster-mode-runtime-unsupported")>] ClusterModeRuntimeUnsupported
        | [<CompiledName("missing-cluster-transform")>] MissingClusterTransform
        | [<CompiledName("missing-cluster-transform-link")>] MissingClusterTransformLink
        | [<CompiledName("missing-bind-pose-matrix")>] MissingBindPoseMatrix
        | [<CompiledName("associate-model-present")>] AssociateModelPresent

module Babylonjs_loaders_FBX_interpreter_sceneDiagnostics =
    type FBXObjectMap = Babylonjs_loaders_FBX_interpreter_connections.FBXObjectMap

    type [<AllowNullLiteral>] IExports =
        abstract extractSceneDiagnostics: objectMap: FBXObjectMap -> ResizeArray<FBXSceneDiagnostic>

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXSceneDiagnosticType =
        | [<CompiledName("unsupported-constraint")>] UnsupportedConstraint
        | [<CompiledName("unsupported-helper")>] UnsupportedHelper
        | [<CompiledName("unsupported-deformer")>] UnsupportedDeformer
        | [<CompiledName("unsupported-node-attribute")>] UnsupportedNodeAttribute
        | [<CompiledName("unsupported-pose")>] UnsupportedPose
        | [<CompiledName("unsupported-layered-texture")>] UnsupportedLayeredTexture
        | [<CompiledName("connection-graph")>] ConnectionGraph

    type [<AllowNullLiteral>] FBXSceneDiagnostic =
        abstract ``type``: FBXSceneDiagnosticType with get, set
        abstract message: string with get, set
        abstract objectId: float option with get, set
        abstract objectName: string option with get, set
        abstract nodeName: string option with get, set
        abstract subType: string option with get, set
        abstract parentCount: float option with get, set
        abstract childCount: float option with get, set

module Babylonjs_loaders_FBX_interpreter_rig =
    type FBXObjectMap = Babylonjs_loaders_FBX_interpreter_connections.FBXObjectMap
    type FBXBoneData = Babylonjs_loaders_FBX_interpreter_skeleton.FBXBoneData
    type FBXSkinData = Babylonjs_loaders_FBX_interpreter_skeleton.FBXSkinData

    type [<AllowNullLiteral>] IExports =
        abstract resolveRigs: objectMap: FBXObjectMap * skins: ResizeArray<FBXSkinData> -> ResizeArray<FBXRigData>

    type FBXRigBoneData =
        FBXBoneData

    type [<AllowNullLiteral>] FBXSkinBindingData =
        abstract skinId: float with get, set
        abstract geometryId: float with get, set
        abstract rigId: string with get, set
        abstract skinBoneIndexToRigBoneIndex: ResizeArray<float> with get, set
        abstract clusterModelIds: Set<float> with get, set

    type [<AllowNullLiteral>] FBXRigData =
        abstract id: string with get, set
        abstract rootModelIds: ResizeArray<float> with get, set
        abstract bones: ResizeArray<FBXRigBoneData> with get, set
        abstract modelIdToBoneIndex: Map<float, float> with get, set
        abstract clusterModelIds: Set<float> with get, set
        abstract skinBindings: ResizeArray<FBXSkinBindingData> with get, set
        abstract warnings: ResizeArray<string> with get, set

module Babylonjs_loaders_FBX_interpreter_propertyTemplates =
    type FBXDocument = Babylonjs_loaders_FBX_types_fbxTypes.FBXDocument
    type FBXNode = Babylonjs_loaders_FBX_types_fbxTypes.FBXNode
    type FBXPropertyValue = Babylonjs_loaders_FBX_types_fbxTypes.FBXPropertyValue

    type [<AllowNullLiteral>] IExports =
        abstract extractPropertyTemplates: doc: FBXDocument -> FBXPropertyTemplateMap
        abstract getPropertyTemplate: templates: FBXPropertyTemplateMap * objectType: string * ?templateName: string -> FBXPropertyTemplate option
        abstract getTemplatePropertyValue: template: FBXPropertyTemplate option * propertyName: string * ?valueIndex: float -> 'T option
        abstract resolvePropertyValue: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string * ?valueIndex: float -> 'T option
        abstract resolveNumberProperty: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string * fallback: float -> float
        abstract resolveVector2Property: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string * fallback: float * float -> float * float
        abstract resolveVector3Property: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string * fallback: float * float * float -> float * float * float
        abstract resolvePropertyValues: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string -> ResizeArray<FBXPropertyValue> option

    type [<AllowNullLiteral>] FBXTemplateProperty =
        abstract name: string with get, set
        abstract propertyType: string with get, set
        abstract label: string with get, set
        abstract flags: string with get, set
        abstract values: ResizeArray<FBXPropertyValue> with get, set

    type [<AllowNullLiteral>] FBXPropertyTemplate =
        abstract objectType: string with get, set
        abstract templateName: string with get, set
        abstract properties: Map<string, FBXTemplateProperty> with get, set

    type FBXPropertyTemplateMap =
        Map<string, Map<string, FBXPropertyTemplate>>

module Babylonjs_loaders_FBX_interpreter_materials =
    type FBXNode = Babylonjs_loaders_FBX_types_fbxTypes.FBXNode
    type FBXObjectMap = Babylonjs_loaders_FBX_interpreter_connections.FBXObjectMap
    type FBXPropertyTemplateMap = Babylonjs_loaders_FBX_interpreter_propertyTemplates.FBXPropertyTemplateMap

    type [<AllowNullLiteral>] IExports =
        abstract extractMaterial: materialNode: FBXNode * materialId: float * objectMap: FBXObjectMap * ?templates: FBXPropertyTemplateMap -> FBXMaterialData

    type [<AllowNullLiteral>] FBXMaterialData =
        abstract id: float with get, set
        abstract name: string with get, set
        abstract ``type``: FBXMaterialDataType with get, set
        abstract properties: FBXMaterialProperties with get, set
        abstract textures: ResizeArray<FBXTextureRef> with get, set

    type [<AllowNullLiteral>] FBXMaterialProperties =
        abstract diffuseColor: (float * float * float) option with get, set
        abstract diffuseFactor: float option with get, set
        abstract ambientColor: (float * float * float) option with get, set
        abstract ambientFactor: float option with get, set
        abstract specularColor: (float * float * float) option with get, set
        abstract specularFactor: float option with get, set
        abstract shininess: float option with get, set
        abstract emissiveColor: (float * float * float) option with get, set
        abstract emissiveFactor: float option with get, set
        abstract opacity: float option with get, set
        abstract transparencyFactor: float option with get, set

    type [<AllowNullLiteral>] FBXTextureRef =
        abstract propertyName: string with get, set
        abstract fileName: string with get, set
        abstract relativeFileName: string with get, set
        abstract id: float with get, set
        abstract embeddedData: Uint8Array option with get, set
        abstract uvTranslation: (float * float) option with get, set
        abstract uvScaling: (float * float) option with get, set
        abstract uvRotation: float option with get, set
        abstract uvSetIndex: float option with get, set
        abstract uvSetName: string option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXMaterialDataType =
        | [<CompiledName("Lambert")>] Lambert
        | [<CompiledName("Phong")>] Phong

module Babylonjs_loaders_FBX_interpreter_geometry =
    type FBXNode = Babylonjs_loaders_FBX_types_fbxTypes.FBXNode

    type [<AllowNullLiteral>] IExports =
        abstract extractGeometry: geometryNode: FBXNode * nodeId: float -> FBXGeometryData

    type [<AllowNullLiteral>] FBXUVSet =
        abstract name: string with get, set
        abstract data: Float64Array with get, set

    type [<AllowNullLiteral>] FBXGeometryDiagnostic =
        abstract ``type``: FBXGeometryDiagnosticType with get, set
        abstract message: string with get, set
        abstract polygonIndex: float option with get, set
        abstract layerName: string option with get, set
        abstract index: float option with get, set

    type [<AllowNullLiteral>] FBXGeometryData =
        abstract id: float with get, set
        abstract name: string with get, set
        abstract positions: Float64Array with get, set
        abstract indices: Uint32Array with get, set
        abstract normals: Float64Array option with get, set
        abstract uvs: Float64Array option with get, set
        abstract uvSets: ResizeArray<FBXUVSet> with get, set
        abstract colors: Float32Array option with get, set
        abstract tangents: Float64Array option with get, set
        abstract binormals: Float64Array option with get, set
        abstract controlPointIndices: Uint32Array option with get, set
        abstract materialIndices: Int32Array option with get, set
        abstract diagnostics: ResizeArray<FBXGeometryDiagnostic> with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXGeometryDiagnosticType =
        | [<CompiledName("degenerate-polygon")>] DegeneratePolygon
        | [<CompiledName("triangulation-fallback")>] TriangulationFallback
        | [<CompiledName("layer-index-out-of-bounds")>] LayerIndexOutOfBounds
        | [<CompiledName("layer-data-too-short")>] LayerDataTooShort

module Babylonjs_loaders_FBX_interpreter_fbxInterpreter =
    type FBXDocument = Babylonjs_loaders_FBX_types_fbxTypes.FBXDocument
    type FBXGeometryData = Babylonjs_loaders_FBX_interpreter_geometry.FBXGeometryData
    type FBXMaterialData = Babylonjs_loaders_FBX_interpreter_materials.FBXMaterialData
    type FBXSkinData = Babylonjs_loaders_FBX_interpreter_skeleton.FBXSkinData
    type FBXRigData = Babylonjs_loaders_FBX_interpreter_rig.FBXRigData
    type FBXAnimationStackData = Babylonjs_loaders_FBX_interpreter_animation.FBXAnimationStackData
    type FBXBlendShapeData = Babylonjs_loaders_FBX_interpreter_blendShapes.FBXBlendShapeData
    type FBXSceneDiagnostic = Babylonjs_loaders_FBX_interpreter_sceneDiagnostics.FBXSceneDiagnostic

    type [<AllowNullLiteral>] IExports =
        abstract interpretFBX: doc: FBXDocument -> FBXSceneData

    type [<AllowNullLiteral>] FBXModelData =
        abstract id: float with get, set
        abstract name: string with get, set
        abstract subType: string with get, set
        abstract geometry: FBXGeometryData option with get, set
        abstract materials: ResizeArray<FBXMaterialData> with get, set
        abstract children: ResizeArray<FBXModelData> with get, set
        abstract translation: float * float * float with get, set
        abstract rotation: float * float * float with get, set
        abstract scale: float * float * float with get, set
        abstract preRotation: float * float * float with get, set
        abstract postRotation: float * float * float with get, set
        abstract rotationPivot: float * float * float with get, set
        abstract scalingPivot: float * float * float with get, set
        abstract rotationOffset: float * float * float with get, set
        abstract scalingOffset: float * float * float with get, set
        abstract geometricTranslation: float * float * float with get, set
        abstract geometricRotation: float * float * float with get, set
        abstract geometricScaling: float * float * float with get, set
        abstract rotationOrder: float with get, set
        abstract inheritType: float with get, set
        abstract cullingOff: bool with get, set
        abstract customProperties: Record<string, U3<string, float, bool>> option with get, set
        abstract diagnostics: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FBXCameraData =
        abstract modelId: float with get, set
        abstract name: string with get, set
        abstract fieldOfView: float with get, set
        abstract nearPlane: float with get, set
        abstract farPlane: float with get, set
        abstract aspectRatio: float with get, set
        abstract projectionType: FBXCameraDataProjectionType with get, set
        abstract focalLength: float option with get, set
        abstract filmWidth: float option with get, set
        abstract filmHeight: float option with get, set
        abstract orthoZoom: float option with get, set
        abstract roll: float option with get, set
        abstract unknownProperties: ResizeArray<string> with get, set
        abstract diagnostics: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FBXLightData =
        abstract modelId: float with get, set
        abstract name: string with get, set
        abstract lightType: float with get, set
        abstract color: float * float * float with get, set
        abstract intensity: float with get, set
        abstract coneAngle: float with get, set
        abstract decayType: float with get, set
        abstract innerAngle: float option with get, set
        abstract outerAngle: float option with get, set
        abstract decayStart: float option with get, set
        abstract enableNearAttenuation: bool option with get, set
        abstract enableFarAttenuation: bool option with get, set
        abstract castShadows: bool option with get, set
        abstract unknownProperties: ResizeArray<string> with get, set
        abstract diagnostics: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FBXSceneData =
        abstract rootModels: ResizeArray<FBXModelData> with get, set
        abstract geometries: ResizeArray<FBXGeometryData> with get, set
        abstract materials: ResizeArray<FBXMaterialData> with get, set
        abstract skins: ResizeArray<FBXSkinData> with get, set
        abstract rigs: ResizeArray<FBXRigData> with get, set
        abstract blendShapes: ResizeArray<FBXBlendShapeData> with get, set
        abstract animations: ResizeArray<FBXAnimationStackData> with get, set
        abstract cameras: ResizeArray<FBXCameraData> with get, set
        abstract lights: ResizeArray<FBXLightData> with get, set
        abstract diagnostics: ResizeArray<FBXSceneDiagnostic> with get, set
        abstract upAxis: float with get, set
        abstract upAxisSign: float with get, set
        abstract frontAxis: float with get, set
        abstract frontAxisSign: float with get, set
        abstract coordAxis: float with get, set
        abstract coordAxisSign: float with get, set
        abstract unitScaleFactor: float with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXCameraDataProjectionType =
        | Perspective
        | Orthographic

module Babylonjs_loaders_FBX_interpreter_connections =
    type FBXDocument = Babylonjs_loaders_FBX_types_fbxTypes.FBXDocument
    type FBXNode = Babylonjs_loaders_FBX_types_fbxTypes.FBXNode

    type [<AllowNullLiteral>] IExports =
        abstract resolveConnections: doc: FBXDocument -> FBXObjectMap
        abstract getChildren: map: FBXObjectMap * parentId: float * ?nodeName: string -> ResizeArray<{| id: float; node: FBXNode; propertyName: string option |}>

    type [<StringEnum>] [<RequireQualifiedAccess>] ConnectionType =
        | [<CompiledName("OO")>] OO
        | [<CompiledName("OP")>] OP

    type [<AllowNullLiteral>] FBXConnection =
        abstract ``type``: ConnectionType with get, set
        abstract childId: float with get, set
        abstract parentId: float with get, set
        abstract propertyName: string option with get, set

    type [<AllowNullLiteral>] FBXObjectEntry =
        abstract id: float with get, set
        abstract node: FBXNode with get, set
        abstract source: FBXObjectEntrySource with get, set
        abstract legacyName: string option with get, set
        abstract synthetic: bool with get, set

    type [<AllowNullLiteral>] FBXConnectionEntry =
        abstract source: FBXConnectionEntrySource with get, set
        abstract rawType: string option with get, set
        abstract childId: float option with get, set
        abstract parentId: float option with get, set
        abstract propertyName: string option with get, set
        abstract accepted: bool with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXConnectionDiagnosticReason =
        | [<CompiledName("unsupported-connection-type")>] UnsupportedConnectionType
        | [<CompiledName("missing-connection-endpoint")>] MissingConnectionEndpoint
        | [<CompiledName("unresolved-legacy-endpoint")>] UnresolvedLegacyEndpoint
        | [<CompiledName("unresolved-object-reference")>] UnresolvedObjectReference
        | [<CompiledName("duplicate-parent")>] DuplicateParent
        | [<CompiledName("self-loop")>] SelfLoop

    type [<AllowNullLiteral>] FBXConnectionDiagnostic =
        abstract reason: FBXConnectionDiagnosticReason with get, set
        abstract message: string with get, set
        abstract connectionIndex: float option with get, set
        abstract ``type``: string option with get, set
        abstract childId: float option with get, set
        abstract parentId: float option with get, set
        abstract propertyName: string option with get, set

    type [<AllowNullLiteral>] FBXObjectMap =
        abstract objects: Map<float, FBXNode> with get, set
        abstract objectEntries: ResizeArray<FBXObjectEntry> with get, set
        abstract childrenOf: Map<float, ResizeArray<{| id: float; propertyName: string option |}>> with get, set
        abstract parentOf: Map<float, {| id: float; propertyName: string option |}> with get, set
        abstract connections: ResizeArray<FBXConnection> with get, set
        abstract connectionEntries: ResizeArray<FBXConnectionEntry> with get, set
        abstract diagnostics: ResizeArray<FBXConnectionDiagnostic> with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXObjectEntrySource =
        | [<CompiledName("Objects")>] Objects
        | LegacySyntheticGeometry

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXConnectionEntrySource =
        | [<CompiledName("C")>] C
        | [<CompiledName("Connect")>] Connect

module Babylonjs_loaders_FBX_interpreter_blendShapes =
    type FBXObjectMap = Babylonjs_loaders_FBX_interpreter_connections.FBXObjectMap

    type [<AllowNullLiteral>] IExports =
        abstract extractBlendShapes: objectMap: FBXObjectMap -> ResizeArray<FBXBlendShapeData>

    type [<AllowNullLiteral>] FBXShapeData =
        abstract indices: Uint32Array with get, set
        abstract vertices: Float64Array with get, set
        abstract normals: Float64Array option with get, set

    type [<AllowNullLiteral>] FBXBlendShapeDiagnostic =
        abstract ``type``: FBXBlendShapeDiagnosticType with get, set
        abstract message: string with get, set
        abstract channelId: float with get, set
        abstract channelName: string with get, set

    type [<AllowNullLiteral>] FBXBlendShapeChannelData =
        abstract name: string with get, set
        abstract id: float with get, set
        abstract deformPercent: float with get, set
        abstract shapes: ResizeArray<FBXShapeData> with get, set
        abstract fullWeights: ResizeArray<float> option with get, set
        abstract diagnostics: ResizeArray<FBXBlendShapeDiagnostic> with get, set

    type [<AllowNullLiteral>] FBXBlendShapeData =
        abstract id: float with get, set
        abstract geometryId: float with get, set
        abstract channels: ResizeArray<FBXBlendShapeChannelData> with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXBlendShapeDiagnosticType =
        | [<CompiledName("full-weights-mismatch")>] FullWeightsMismatch
        | [<CompiledName("missing-full-weights")>] MissingFullWeights

module Babylonjs_loaders_FBX_interpreter_animation =
    type FBXObjectMap = Babylonjs_loaders_FBX_interpreter_connections.FBXObjectMap

    type [<AllowNullLiteral>] IExports =
        abstract extractAnimations: objectMap: FBXObjectMap -> ResizeArray<FBXAnimationStackData>
        abstract isFrameBakedSampledCurve: keys: ResizeArray<FBXKeyframe> -> bool
        abstract sampleFBXCurveAtTime: curveData: FBXCurveData option * time: float -> float option

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXInterpolationType =
        | Constant
        | Linear
        | Cubic

    type [<AllowNullLiteral>] FBXKeyframe =
        abstract time: float with get, set
        abstract value: float with get, set
        abstract interpolation: FBXInterpolationType with get, set
        abstract constantMode: FBXKeyframeConstantMode option with get, set
        abstract rightSlope: float option with get, set
        abstract nextLeftSlope: float option with get, set

    type [<AllowNullLiteral>] FBXCurveData =
        abstract channel: string with get, set
        abstract keys: ResizeArray<FBXKeyframe> with get, set
        abstract isSampled: bool option with get, set

    type [<AllowNullLiteral>] FBXCurveNodeData =
        abstract ``type``: string with get, set
        abstract targetModelId: float with get, set
        abstract curves: ResizeArray<FBXCurveData> with get, set

    type [<AllowNullLiteral>] FBXUnsupportedCurveNodeData =
        abstract ``type``: string with get, set
        abstract id: float with get, set
        abstract targetId: float option with get, set
        abstract propertyName: string option with get, set
        abstract curveCount: float with get, set
        abstract curves: ResizeArray<FBXCurveData> with get, set
        abstract defaultValues: Record<string, float> with get, set

    type [<AllowNullLiteral>] FBXAnimationDiagnostic =
        abstract ``type``: FBXAnimationDiagnosticType with get, set
        abstract message: string with get, set
        abstract layerName: string option with get, set
        abstract curveNodeId: float option with get, set
        abstract curveNodeType: string option with get, set
        abstract targetId: float option with get, set
        abstract propertyName: string option with get, set

    type [<AllowNullLiteral>] FBXAnimationLayerData =
        abstract name: string with get, set
        abstract weight: float with get, set
        abstract normalizedWeight: float with get, set
        abstract blendMode: float with get, set
        abstract curveNodes: ResizeArray<FBXCurveNodeData> with get, set
        abstract unsupportedCurveNodes: ResizeArray<FBXUnsupportedCurveNodeData> with get, set
        abstract diagnostics: ResizeArray<FBXAnimationDiagnostic> with get, set

    type [<AllowNullLiteral>] FBXAnimationStackData =
        abstract name: string with get, set
        abstract startTime: float with get, set
        abstract stopTime: float with get, set
        abstract duration: float with get, set
        abstract curveNodes: ResizeArray<FBXCurveNodeData> with get, set
        abstract layers: ResizeArray<FBXAnimationLayerData> with get, set
        abstract unsupportedCurveNodes: ResizeArray<FBXUnsupportedCurveNodeData> with get, set
        abstract diagnostics: ResizeArray<FBXAnimationDiagnostic> with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXKeyframeConstantMode =
        | Standard
        | Next

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXAnimationDiagnosticType =
        | [<CompiledName("multiple-animation-layers")>] MultipleAnimationLayers
        | [<CompiledName("unsupported-layer-blend-mode")>] UnsupportedLayerBlendMode
        | [<CompiledName("partial-layer-weight")>] PartialLayerWeight
        | [<CompiledName("unsupported-curve-node")>] UnsupportedCurveNode

module Babylonjs_loaders_BVH_bvhLoadingOptions =

    type [<AllowNullLiteral>] BVHLoadingOptions =
        abstract loopMode: float with get, set

module Babylonjs_loaders_BVH_bvhLoader =
    type Skeleton = obj
    type Scene = obj
    type Nullable<'T> = 'T
    type BVHLoadingOptions = Babylonjs_loaders_BVH_bvhLoadingOptions.BVHLoadingOptions
    type AssetContainer = obj

    type [<AllowNullLiteral>] IExports =
        abstract ReadBvh: text: string * scene: Scene * assetContainer: Nullable<AssetContainer> * loadingOptions: BVHLoadingOptions -> Skeleton

module Babylonjs_loaders_BVH_bvhFileLoader_types =
    type BVHLoadingOptions = Babylonjs_loaders_BVH_bvhLoadingOptions.BVHLoadingOptions
    type BVHFileLoaderMetadata = obj

    module Babylonjs_Loading_sceneLoader =

        type [<AllowNullLiteral>] SceneLoaderPluginOptions =
            abstract ``[BVHFileLoaderMetadata.name]``: obj with get, set

module Babylonjs_loaders_BVH_bvhFileLoader_pure =
    type ISceneLoaderPluginAsync = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginAsync
    type ISceneLoaderPluginFactory = BabylonjsBindings.FullCandidate.BABYLON.ISceneLoaderPluginFactory
    type ISceneLoaderAsyncResult = obj
    type SceneLoaderPluginOptions = obj
    type AssetContainer = obj
    type Scene = obj
    type BVHLoadingOptions = Babylonjs_loaders_BVH_bvhLoadingOptions.BVHLoadingOptions

    type [<AllowNullLiteral>] IExports =
        abstract BVHFileLoader: BVHFileLoaderStatic
        abstract RegisterBVHFileLoader: unit -> unit

    type [<AllowNullLiteral>] BVHFileLoader =
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract name: string
        abstract extensions: {| ``.bvh``: {| isBinary: bool |} |}
        abstract createPlugin: options: SceneLoaderPluginOptions -> ISceneLoaderPluginAsync
        abstract canDirectLoad: data: string -> bool
        abstract isBvhHeader: text: string -> bool
        abstract isNotBvhHeader: text: string -> bool
        abstract importMeshAsync: _meshesNames: U2<string, ResizeArray<string>> option * scene: Scene * data: obj -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: obj -> Promise<unit>
        abstract loadAssetContainerAsync: scene: Scene * data: obj -> Promise<AssetContainer>

    type [<AllowNullLiteral>] BVHFileLoaderStatic =
        [<EmitConstructor>] abstract Create: ?loadingOptions: obj -> BVHFileLoader

module Babylonjs_loaders_BVH_bvhFileLoader_metadata =

    type [<AllowNullLiteral>] IExports =
        abstract BVHFileLoaderMetadata: {| name: string; extensions: {| ``.bvh``: {| isBinary: bool |} |} |}

module BABYLON =
    open BabylonjsBindings.FullCandidate.BABYLON
    let [<Import("GLTF2","babylonjs.loaders.module.no-docs/BABYLON")>] gLTF2: GLTF2.IExports = jsNative
    let [<Import("GLTF1","babylonjs.loaders.module.no-docs/BABYLON")>] gLTF1: GLTF1.IExports = jsNative

    type [<AllowNullLiteral>] IExports =
        abstract registerBuiltInLoaders: unit -> unit
        abstract GLTF2Legacy: obj with get, set
        abstract GLTFValidation: GLTFValidationStatic
        abstract GLTFLoaderBaseOptions: GLTFLoaderBaseOptionsStatic
        abstract GLTFLoaderDefaultOptions: GLTFLoaderBaseOptions with get, set
        abstract GLTFLoaderOptions: GLTFLoaderOptionsStatic
        abstract GLTFFileLoader: GLTFFileLoaderStatic
        abstract RegisterGLTFFileLoader: unit -> unit
        abstract GLTFMagicBase64Encoded: obj
        abstract GLTFFileLoaderMetadata: {| name: string; extensions: {| ``.gltf``: {| isBinary: bool; mimeType: string |}; ``.glb``: {| isBinary: bool; mimeType: string |} |}; canDirectLoad: string -> bool |} with get, set
        abstract STLFileLoader: STLFileLoaderStatic
        abstract RegisterSTLFileLoader: unit -> unit
        abstract STLFileLoaderMetadata: {| name: string; extensions: {| ``.stl``: {| isBinary: bool |} |} |} with get, set
        abstract ParseSpz: data: ArrayBuffer * scene: Scene * _loadingOptions: SPLATLoadingOptions -> Promise<IParsedSplat>
        abstract GetSpzModule: url: string -> Promise<obj option>
        abstract ConvertSpzToSplat: cloud: obj option * scene: Scene * ?useCoroutine: bool -> Coroutine<IParsedSplat>
        abstract ConvertSpzToSplatAsync: cloud: obj option * scene: Scene -> Promise<IParsedSplat>
        abstract SPLATFileLoader: SPLATFileLoaderStatic
        abstract RegisterSPLATFileLoader: unit -> unit
        abstract SPLATFileLoaderMetadata: {| name: string; extensions: IExportsSPLATFileLoaderMetadataExtensions |} with get, set
        abstract ParseSogMeta: dataOrFiles: U2<SOGRootData, Map<string, Uint8Array>> * rootUrl: string * scene: Scene -> Promise<IParsedSplat>
        abstract ParseSogMetaAsTextures: dataOrFiles: U2<SOGRootData, Map<string, Uint8Array>> * rootUrl: string * scene: Scene * ?computeCpuPositions: bool * ?downloadManager: GaussianSplattingDownloadManager * ?downloadGroupId: DownloadGroupId -> Promise<IParsedSplat>
        abstract GaussianSplattingWorkBufferShaderName: obj
        abstract GaussianSplattingWorkBufferVertexShaderGLSL: obj
        abstract GaussianSplattingWorkBufferFragmentShaderGLSL: obj
        abstract GaussianSplattingWorkBufferVertexShaderWGSL: obj
        abstract GaussianSplattingWorkBufferFragmentShaderWGSL: obj
        abstract GaussianSplattingWorkBufferRelayoutShaderName: obj
        abstract GaussianSplattingWorkBufferRelayoutFragmentShaderGLSL: obj
        abstract GaussianSplattingWorkBufferRelayoutFragmentShaderWGSL: obj
        abstract GaussianSplattingWorkBuffer: GaussianSplattingWorkBufferStatic
        abstract GaussianSplattingStream: GaussianSplattingStreamStatic
        abstract GaussianSplattingResidencyController: GaussianSplattingResidencyControllerStatic
        abstract GaussianSplattingDownloadManager: GaussianSplattingDownloadManagerStatic
        abstract GaussianSplattingMemBlock: GaussianSplattingMemBlockStatic
        abstract GaussianSplattingBlockAllocator: GaussianSplattingBlockAllocatorStatic
        abstract SolidParser: SolidParserStatic
        abstract OBJFileLoader: OBJFileLoaderStatic
        abstract RegisterOBJFileLoader: unit -> unit
        abstract OBJFileLoaderMetadata: {| name: string; extensions: string |} with get, set
        abstract MTLFileLoader: MTLFileLoaderStatic
        abstract FBXFileLoader: FBXFileLoaderStatic
        abstract RegisterFBXFileLoader: unit -> unit
        abstract FBXFileLoaderMetadata: {| name: string; extensions: {| ``.fbx``: {| isBinary: bool |} |} |} with get, set
        abstract findChildByName: node: FBXNode * name: string -> FBXNode option
        abstract findChildrenByName: node: FBXNode * name: string -> ResizeArray<FBXNode>
        abstract findDocumentNode: doc: FBXDocument * name: string -> FBXNode option
        abstract getPropertyValue: node: FBXNode * index: float -> 'T option
        abstract getSafeFBXObjectId: value: obj -> float option
        abstract getNodeId: node: FBXNode -> float option
        abstract cleanFBXName: fbxName: string -> string
        abstract inflateZlib: input: Uint8Array * expectedLength: float -> Uint8Array
        abstract parseBinaryFBX: buffer: ArrayBuffer -> FBXDocument
        abstract parseAsciiFBX: text: string -> FBXDocument
        abstract eulerToMatrixXYZ: rx: float * ry: float * rz: float -> Matrix
        abstract eulerToMatrix: rx: float * ry: float * rz: float * order: float -> Matrix
        abstract computeFBXGeometricMatrix: translation: FBXVector3 * rotation: FBXVector3 * scale: FBXVector3 -> Matrix
        abstract computeFBXGeometricDeltaMatrix: rotation: FBXVector3 * scale: FBXVector3 -> Matrix
        abstract computeFBXGeometricNormalMatrix: rotation: FBXVector3 * scale: FBXVector3 -> Matrix
        abstract computeFBXLocalMatrix: components: FBXTransformComponents -> Matrix
        abstract extractSkins: objectMap: FBXObjectMap -> ResizeArray<FBXSkinData>
        abstract isSkeletonModel: modelNode: FBXNode -> bool
        abstract extractBoneTransform: modelNode: FBXNode -> ExtractBoneTransformReturn
        abstract extractSceneDiagnostics: objectMap: FBXObjectMap -> ResizeArray<FBXSceneDiagnostic>
        abstract resolveRigs: objectMap: FBXObjectMap * skins: ResizeArray<FBXSkinData> -> ResizeArray<FBXRigData>
        abstract extractPropertyTemplates: doc: FBXDocument -> FBXPropertyTemplateMap
        abstract getPropertyTemplate: templates: FBXPropertyTemplateMap * objectType: string * ?templateName: string -> FBXPropertyTemplate option
        abstract getTemplatePropertyValue: template: FBXPropertyTemplate option * propertyName: string * ?valueIndex: float -> 'T option
        abstract resolvePropertyValue: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string * ?valueIndex: float -> 'T option
        abstract resolveNumberProperty: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string * fallback: float -> float
        abstract resolveVector2Property: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string * fallback: float * float -> float * float
        abstract resolveVector3Property: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string * fallback: float * float * float -> float * float * float
        abstract resolvePropertyValues: node: FBXNode * template: FBXPropertyTemplate option * propertyName: string -> ResizeArray<FBXPropertyValue> option
        abstract extractMaterial: materialNode: FBXNode * materialId: float * objectMap: FBXObjectMap * ?templates: FBXPropertyTemplateMap -> FBXMaterialData
        abstract extractGeometry: geometryNode: FBXNode * nodeId: float -> FBXGeometryData
        abstract interpretFBX: doc: FBXDocument -> FBXSceneData
        abstract resolveConnections: doc: FBXDocument -> FBXObjectMap
        abstract getChildren: map: FBXObjectMap * parentId: float * ?nodeName: string -> ResizeArray<{| id: float; node: FBXNode; propertyName: string option |}>
        abstract extractBlendShapes: objectMap: FBXObjectMap -> ResizeArray<FBXBlendShapeData>
        abstract extractAnimations: objectMap: FBXObjectMap -> ResizeArray<FBXAnimationStackData>
        abstract isFrameBakedSampledCurve: keys: ResizeArray<FBXKeyframe> -> bool
        abstract sampleFBXCurveAtTime: curveData: FBXCurveData option * time: float -> float option
        abstract ReadBvh: text: string * scene: Scene * assetContainer: Nullable<AssetContainer> * loadingOptions: BVHLoadingOptions -> Skeleton
        abstract BVHFileLoader: BVHFileLoaderStatic
        abstract RegisterBVHFileLoader: unit -> unit
        abstract BVHFileLoaderMetadata: {| name: string; extensions: {| ``.bvh``: {| isBinary: bool |} |} |} with get, set

    type [<AllowNullLiteral>] ExtractBoneTransformReturn =
        abstract translation: float * float * float with get, set
        abstract rotation: float * float * float with get, set
        abstract preRotation: float * float * float with get, set
        abstract postRotation: float * float * float with get, set
        abstract rotationPivot: float * float * float with get, set
        abstract scalingPivot: float * float * float with get, set
        abstract rotationOffset: float * float * float with get, set
        abstract scalingOffset: float * float * float with get, set
        abstract scale: float * float * float with get, set
        abstract rotationOrder: float with get, set
        abstract inheritType: float with get, set

    type [<AllowNullLiteral>] IGLTFValidationConfiguration =
        abstract url: string with get, set

    type [<AllowNullLiteral>] GLTFValidation =
        interface end

    type [<AllowNullLiteral>] GLTFValidationStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFValidation
        abstract Configuration: IGLTFValidationConfiguration with get, set
        abstract _LastResults: Nullable<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults> with get, set
        abstract ValidateAsync: data: U2<string, Uint8Array> * rootUrl: string * fileName: string * getExternalResource: (string -> Promise<Uint8Array>) -> Promise<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults>

    type [<AllowNullLiteral>] SceneLoaderPluginOptions =
        abstract ``[GLTFFileLoaderMetadata.name]``: obj with get, set
        abstract ``[STLFileLoaderMetadata.name]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``[SPLATFileLoaderMetadata.name]``: obj with get, set
        abstract ``[OBJFileLoaderMetadata.name]``: obj with get, set
        abstract ``[FBXFileLoaderMetadata.name]``: obj with get, set
        abstract ``[BVHFileLoaderMetadata.name]``: obj with get, set

    type [<AllowNullLiteral>] GLTFLoaderExtensionOptions =
        inherit Record<string, Record<string, obj> option>
        abstract ``["MSFT_sRGBFactors"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["MSFT_minecraftMesh"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["MSFT_lod"]``: obj with get, set
        abstract ``["MSFT_audio_emitter"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_xmp_json_ld"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_texture_transform"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_texture_basisu"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_node_visibility"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_node_selectability"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_node_hoverability"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_mesh_quantization"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_volume_scatter"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_volume"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_variants"]``: obj with get, set
        abstract ``["KHR_materials_unlit"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_transmission"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_specular"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_sheen"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_pbrSpecularGlossiness"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_iridescence"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_ior"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_fuzz"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_emissive_strength"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_dispersion"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_diffuse_transmission"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_diffuse_roughness"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_coat"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_clearcoat"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_materials_anisotropy"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_lights_punctual"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_interactivity"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_gaussian_splatting"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_draco_mesh_compression"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["KHR_animation_pointer"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["ExtrasAsMetadata"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["EXT_texture_webp"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["EXT_texture_avif"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["EXT_meshopt_compression"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["EXT_mesh_gpu_instancing"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["EXT_lights_image_based"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["EXT_lights_ies"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set
        abstract ``["EXT_lights_area"]``: SceneLoaderPluginOptions_STLFileLoaderMetadataName_ with get, set

    type GLTFLoaderCoordinateSystemMode =
        | AUTO = 0
        | FORCE_RIGHT_HANDED = 1

    type GLTFLoaderAnimationStartMode =
        | NONE = 0
        | FIRST = 1
        | ALL = 2

    type [<AllowNullLiteral>] IGLTFLoaderData =
        abstract json: obj with get, set
        abstract bin: Nullable<IDataBuffer> with get, set

    type [<AllowNullLiteral>] IGLTFLoaderExtension =
        abstract name: string
        abstract enabled: bool with get, set
        abstract order: float option with get, set

    type GLTFLoaderState =
        | LOADING = 0
        | READY = 1
        | COMPLETE = 2

    type [<AllowNullLiteral>] IGLTFLoader =
        inherit IDisposable
        abstract importMeshAsync: (U2<string, ResizeArray<string>> option -> Scene -> Nullable<AssetContainer> -> IGLTFLoaderData -> string -> ((ISceneLoaderProgressEvent -> unit)) option -> (string) option -> Promise<ISceneLoaderAsyncResult>) with get, set
        abstract loadAsync: (Scene -> IGLTFLoaderData -> string -> ((ISceneLoaderProgressEvent -> unit)) option -> (string) option -> Promise<unit>) with get, set

    type [<AllowNullLiteral>] DefaultExtensionOptions<'BaseExtensionOptions> =
        interface end

    type [<AllowNullLiteral>] GLTFLoaderBaseOptions =
        abstract alwaysComputeBoundingBox: bool with get, set
        abstract alwaysComputeSkeletonRootNode: bool with get, set
        abstract animationStartMode: GLTFLoaderAnimationStartMode with get, set
        abstract compileMaterials: bool with get, set
        abstract compileShadowGenerators: bool with get, set
        abstract coordinateSystemMode: GLTFLoaderCoordinateSystemMode with get, set
        abstract createInstances: bool with get, set
        abstract loadAllMaterials: bool with get, set
        abstract loadMorphTargets: bool with get, set
        abstract useMaxMorphTargetInfluencers: bool with get, set
        abstract loadNodeAnimations: bool with get, set
        abstract loadOnlyMaterials: bool with get, set
        abstract loadSkins: bool with get, set
        abstract skipMaterials: bool with get, set
        abstract targetFps: float with get, set
        abstract transparencyAsCoverage: bool with get, set
        abstract useClipPlane: bool with get, set
        abstract useGltfTextureNames: bool with get, set
        abstract useRangeRequests: bool with get, set
        abstract useSRGBBuffers: bool with get, set
        abstract validate: bool with get, set
        abstract useOpenPBR: bool with get, set
        abstract dontUseTransmissionHelper: bool with get, set

    type [<AllowNullLiteral>] GLTFLoaderBaseOptionsStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFLoaderBaseOptions

    type [<AllowNullLiteral>] GLTFLoaderOptions =
        inherit GLTFLoaderBaseOptions
        abstract copyFrom: ?options: obj -> unit
        abstract onParsed: (IGLTFLoaderData -> unit) option with get, set
        abstract capturePerformanceCounters: bool with get, set
        abstract customRootNode: Nullable<TransformNode> option with get, set
        abstract extensionOptions: obj with get, set
        abstract loggingEnabled: bool with get, set
        abstract onCameraLoaded: (Camera -> unit) option with get, set
        abstract onMaterialLoaded: (Material -> unit) option with get, set
        abstract onMeshLoaded: (AbstractMesh -> unit) option with get, set
        abstract onSkinLoaded: (TransformNode -> TransformNode -> unit) option with get, set
        abstract onTextureLoaded: (BaseTexture -> unit) option with get, set
        abstract onValidated: (BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults -> unit) option with get, set
        abstract preprocessUrlAsync: (string -> Promise<string>) with get, set

    type [<AllowNullLiteral>] GLTFLoaderOptionsStatic =
        [<EmitConstructor>] abstract Create: unit -> GLTFLoaderOptions

    type [<AllowNullLiteral>] GLTFFileLoader =
        inherit GLTFLoaderOptions
        inherit IDisposable
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract onParsedObservable: Observable<IGLTFLoaderData> with get, set
        abstract onParsed: (IGLTFLoaderData -> unit) option with set
        abstract onMeshLoadedObservable: Observable<AbstractMesh>
        abstract onMeshLoaded: (AbstractMesh -> unit) option with set
        abstract onSkinLoadedObservable: Observable<{| node: TransformNode; skinnedNode: TransformNode |}>
        abstract onSkinLoaded: (TransformNode -> TransformNode -> unit) option with set
        abstract onTextureLoadedObservable: Observable<BaseTexture>
        abstract onTextureLoaded: (BaseTexture -> unit) option with set
        abstract onMaterialLoadedObservable: Observable<Material>
        abstract onMaterialLoaded: (Material -> unit) option with set
        abstract onCameraLoadedObservable: Observable<Camera>
        abstract onCameraLoaded: (Camera -> unit) option with set
        abstract onCompleteObservable: Observable<unit>
        abstract onComplete: (unit -> unit) with set
        abstract onErrorObservable: Observable<obj option>
        abstract onError: (obj option -> unit) with set
        abstract onDisposeObservable: Observable<unit>
        abstract onDispose: (unit -> unit) with set
        abstract onExtensionLoadedObservable: Observable<IGLTFLoaderExtension>
        abstract onExtensionLoaded: (IGLTFLoaderExtension -> unit) with set
        abstract loggingEnabled: bool with get, set
        abstract capturePerformanceCounters: bool with get, set
        abstract onValidatedObservable: Observable<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults>
        abstract onValidated: (BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTFValidationResults -> unit) with set
        abstract name: string
        abstract extensions: {| ``.gltf``: {| isBinary: bool; mimeType: string |}; ``.glb``: {| isBinary: bool; mimeType: string |} |}
        abstract dispose: unit -> unit
        abstract loadFile: scene: Scene * fileOrUrl: U3<File, string, ArrayBufferView> * rootUrl: string * onSuccess: (obj -> (string) option -> unit) * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?useArrayBuffer: bool * ?onError: ((WebRequest) option -> (LoadFileError) option -> unit) * ?name: string -> Nullable<IFileRequest>
        abstract importMeshAsync: meshesNames: U2<string, ResizeArray<string>> option * scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<unit>
        abstract loadAssetContainerAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<AssetContainer>
        abstract canDirectLoad: data: string -> bool
        abstract directLoad: scene: Scene * data: string -> Promise<obj>
        abstract rewriteRootURL: rootUrl: string * ?responseURL: string -> string
        abstract createPlugin: options: SceneLoaderPluginOptions -> ISceneLoaderPluginAsync
        abstract loaderState: Nullable<GLTFLoaderState>
        abstract onLoaderStateChangedObservable: Observable<Nullable<GLTFLoaderState>> with get, set
        abstract whenCompleteAsync: unit -> Promise<unit>
        abstract _setState: state: GLTFLoaderState -> unit
        abstract _loadFile: scene: Scene * fileOrUrl: U2<File, string> * onSuccess: (U2<string, ArrayBuffer> -> unit) * ?useArrayBuffer: bool * ?onError: ((WebRequest) option -> unit) * ?onOpened: (WebRequest -> unit) -> IFileRequest
        abstract _log: (string -> unit) with get, set
        abstract _logOpen: message: string -> unit
        abstract _logClose: unit -> unit
        abstract _startPerformanceCounter: (string -> unit) with get, set
        abstract _endPerformanceCounter: (string -> unit) with get, set

    type [<AllowNullLiteral>] GLTFFileLoaderStatic =
        abstract _CreateGLTF1Loader: (GLTFFileLoader -> IGLTFLoader) with get, set
        abstract _CreateGLTF2Loader: (GLTFFileLoader -> IGLTFLoader) with get, set
        [<EmitConstructor>] abstract Create: ?options: obj -> GLTFFileLoader
        abstract IncrementalLoading: bool with get, set
        abstract HomogeneousCoordinates: bool with get, set

    module GLTF2 =
        open BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2

        type [<AllowNullLiteral>] IExports =
            abstract PBRMaterialLoadingAdapter: PBRMaterialLoadingAdapterStatic
            abstract OpenPBRMaterialLoadingAdapter: OpenPBRMaterialLoadingAdapterStatic
            abstract registeredGLTFExtensions: ReadonlyMap<string, obj> with get, set
            abstract registerGLTFExtension: name: string * isGLTFExtension: bool * factory: GLTFExtensionFactory -> unit
            abstract unregisterGLTFExtension: name: string -> bool
            abstract getVector3: _target: obj option * source: Float32Array * offset: float * scale: float -> Vector3
            abstract getQuaternion: _target: obj option * source: Float32Array * offset: float * scale: float -> Quaternion
            abstract getWeights: target: BABYLON.GLTF2.Loader.INode * source: Float32Array * offset: float * scale: float -> Array<float>
            abstract AnimationPropertyInfo: AnimationPropertyInfoStatic
            abstract TransformNodeAnimationPropertyInfo: TransformNodeAnimationPropertyInfoStatic
            abstract WeightAnimationPropertyInfo: WeightAnimationPropertyInfoStatic
            abstract ArrayItem: ArrayItemStatic
            abstract LoadBoundingInfoFromPositionAccessor: accessor: BABYLON.GLTF2.Loader.IAccessor -> Nullable<BoundingInfo>
            abstract GLTFLoader: GLTFLoaderStatic
            abstract RegisterGLTF2Loader: unit -> unit

        type [<AllowNullLiteral>] PBRMaterialLoadingAdapter =
            inherit BABYLON.GLTF2.IMaterialLoadingAdapter
            abstract material: PBRMaterial
            abstract finalizeAsync: _loader: BABYLON.GLTF2.GLTFLoader -> Promise<unit>
            abstract isUnlit: bool with get, set
            abstract backFaceCulling: bool with get, set
            abstract twoSidedLighting: bool with get, set
            abstract alphaCutOff: float with get, set
            abstract useAlphaFromBaseColorTexture: bool with get, set
            abstract transparencyAsAlphaCoverage: bool with get, set
            abstract baseColor: Color3 with get, set
            abstract baseColorTexture: Nullable<BaseTexture> with get, set
            abstract baseDiffuseRoughness: float with get, set
            abstract baseDiffuseRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract baseMetalness: float with get, set
            abstract baseMetalnessTexture: Nullable<BaseTexture> with get, set
            abstract useRoughnessFromMetallicTextureGreen: bool with set
            abstract useMetallicFromMetallicTextureBlue: bool with set
            abstract enableSpecularEdgeColor: ?enableEdgeColor: bool -> unit
            abstract configureSpecularGlossiness: unit -> unit
            abstract specularWeight: float with get, set
            abstract specularWeightTexture: Nullable<BaseTexture> with get, set
            abstract specularColor: Color3 with get, set
            abstract specularColorTexture: Nullable<BaseTexture> with get, set
            abstract specularRoughness: float with get, set
            abstract specularRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract specularIor: float with get, set
            abstract glossiness: float with get, set
            abstract emissionColor: Color3 with get, set
            abstract emissionLuminance: float with get, set
            abstract emissionColorTexture: Nullable<BaseTexture> with get, set
            abstract ambientOcclusionTexture: Nullable<BaseTexture> with get, set
            abstract ambientOcclusionTextureStrength: float with get, set
            abstract configureCoat: unit -> unit
            abstract coatWeight: float with get, set
            abstract coatWeightTexture: Nullable<BaseTexture> with get, set
            abstract coatColor: Color3 with set
            abstract coatColorTexture: Nullable<BaseTexture> with set
            abstract coatRoughness: float with get, set
            abstract coatRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract coatIor: float with set
            abstract coatDarkening: float with set
            abstract coatDarkeningTexture: Nullable<BaseTexture> with set
            abstract coatRoughnessAnisotropy: float with get, set
            abstract geometryCoatTangentAngle: float with set
            abstract geometryCoatTangentTexture: Nullable<BaseTexture> with get, set
            abstract transmissionWeight: float with get, set
            abstract transmissionWeightTexture: Nullable<BaseTexture> with set
            abstract transmissionDepth: float with get, set
            abstract transmissionColor: Color3 with get, set
            abstract transmissionScatter: Color3 with get, set
            abstract transmissionScatterTexture: Nullable<BaseTexture> with set
            abstract transmissionScatterAnisotropy: float with set
            abstract transmissionDispersionAbbeNumber: float with set
            abstract transmissionDispersionScale: float with set
            abstract refractionBackgroundTexture: Nullable<BaseTexture> with get, set
            abstract configureTransmission: unit -> unit
            abstract configureVolume: unit -> unit
            abstract geometryThinWalled: bool with get, set
            abstract volumeThicknessTexture: Nullable<BaseTexture> with set
            abstract volumeThickness: float with set
            abstract configureSubsurface: unit -> unit
            abstract subsurfaceWeight: float with get, set
            abstract subsurfaceWeightTexture: Nullable<BaseTexture> with set
            abstract subsurfaceColor: Color3 with set
            abstract subsurfaceColorTexture: Nullable<BaseTexture> with set
            abstract diffuseTransmissionTint: Color3 with get, set
            abstract diffuseTransmissionTintTexture: Nullable<BaseTexture> with set
            abstract subsurfaceRadius: float with get, set
            abstract subsurfaceRadiusScale: Color3 with get, set
            abstract subsurfaceScatterAnisotropy: float with set
            abstract isTranslucent: unit -> bool
            abstract configureFuzz: unit -> unit
            abstract fuzzWeight: float with set
            abstract fuzzWeightTexture: Nullable<BaseTexture> with set
            abstract fuzzColor: Color3 with set
            abstract fuzzColorTexture: Nullable<BaseTexture> with set
            abstract fuzzRoughness: float with set
            abstract fuzzRoughnessTexture: Nullable<BaseTexture> with set
            abstract specularRoughnessAnisotropy: float with get, set
            abstract geometryTangentAngle: float with set
            abstract geometryTangentTexture: Nullable<BaseTexture> with get, set
            abstract configureGltfStyleAnisotropy: ?useGltfStyle: bool -> unit
            abstract thinFilmWeight: float with set
            abstract thinFilmIor: float with set
            abstract thinFilmThicknessMinimum: float with set
            abstract thinFilmThicknessMaximum: float with set
            abstract thinFilmWeightTexture: Nullable<BaseTexture> with set
            abstract thinFilmThicknessTexture: Nullable<BaseTexture> with set
            abstract unlit: bool with set
            abstract geometryOpacity: float with get, set
            abstract geometryNormalTexture: Nullable<BaseTexture> with get, set
            abstract setNormalMapInversions: invertX: bool * invertY: bool -> unit
            abstract geometryCoatNormalTexture: Nullable<BaseTexture> with get, set
            abstract geometryCoatNormalTextureScale: float with set

        type [<AllowNullLiteral>] PBRMaterialLoadingAdapterStatic =
            [<EmitConstructor>] abstract Create: material: Material -> PBRMaterialLoadingAdapter

        type [<AllowNullLiteral>] OpenPBRMaterialLoadingAdapter =
            inherit BABYLON.GLTF2.IMaterialLoadingAdapter
            abstract material: OpenPBRMaterial
            abstract isUnlit: bool with get, set
            abstract backFaceCulling: bool with get, set
            abstract twoSidedLighting: bool with get, set
            abstract alphaCutOff: float with get, set
            abstract useAlphaFromBaseColorTexture: bool with get, set
            abstract transparencyAsAlphaCoverage: bool with get, set
            abstract baseColor: Color3 with get, set
            abstract baseColorTexture: Nullable<BaseTexture> with get, set
            abstract baseDiffuseRoughness: float with get, set
            abstract baseDiffuseRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract baseMetalness: float with get, set
            abstract baseMetalnessTexture: Nullable<BaseTexture> with get, set
            abstract useRoughnessFromMetallicTextureGreen: bool with set
            abstract useMetallicFromMetallicTextureBlue: bool with set
            abstract enableSpecularEdgeColor: ?_enableEdgeColor: bool -> unit
            abstract configureSpecularGlossiness: unit -> unit
            abstract specularWeight: float with get, set
            abstract specularWeightTexture: Nullable<BaseTexture> with get, set
            abstract specularColor: Color3 with get, set
            abstract specularColorTexture: Nullable<BaseTexture> with get, set
            abstract specularRoughness: float with get, set
            abstract specularRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract specularIor: float with get, set
            abstract glossiness: float with get, set
            abstract emissionColor: Color3 with get, set
            abstract emissionLuminance: float with get, set
            abstract emissionColorTexture: Nullable<BaseTexture> with get, set
            abstract ambientOcclusionTexture: Nullable<BaseTexture> with get, set
            abstract ambientOcclusionTextureStrength: float with get, set
            abstract configureCoat: unit -> unit
            abstract coatWeight: float with get, set
            abstract coatWeightTexture: Nullable<BaseTexture> with get, set
            abstract coatColor: Color3 with get, set
            abstract coatColorTexture: Nullable<BaseTexture> with set
            abstract coatRoughness: float with get, set
            abstract coatRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract coatIor: float with get, set
            abstract coatDarkening: float with get, set
            abstract coatDarkeningTexture: Nullable<BaseTexture> with set
            abstract coatRoughnessAnisotropy: float with get, set
            abstract geometryCoatTangentAngle: float with set
            abstract geometryCoatTangentTexture: Nullable<BaseTexture> with get, set
            abstract configureTransmission: unit -> unit
            abstract transmissionWeightTexture: Nullable<BaseTexture> with get, set
            abstract transmissionWeight: float with get, set
            abstract transmissionScatter: Color3 with get, set
            abstract transmissionScatterTexture: Nullable<BaseTexture> with get, set
            abstract transmissionScatterAnisotropy: float with set
            abstract transmissionDispersionAbbeNumber: float with set
            abstract transmissionDispersionScale: float with set
            abstract transmissionDepth: float with get, set
            abstract transmissionColor: Color3 with get, set
            abstract refractionBackgroundTexture: Nullable<BaseTexture> with get, set
            abstract configureVolume: unit -> unit
            abstract geometryThinWalled: bool with get, set
            abstract volumeThicknessTexture: Nullable<BaseTexture> with set
            abstract volumeThickness: float with set
            abstract configureSubsurface: unit -> unit
            abstract subsurfaceWeight: float with get, set
            abstract subsurfaceWeightTexture: Nullable<BaseTexture> with get, set
            abstract subsurfaceColor: Color3 with set
            abstract subsurfaceColorTexture: Nullable<BaseTexture> with set
            abstract diffuseTransmissionTint: Color3 with get, set
            abstract diffuseTransmissionTintTexture: Nullable<BaseTexture> with set
            abstract subsurfaceRadius: float with get, set
            abstract subsurfaceRadiusScale: Color3 with get, set
            abstract subsurfaceScatterAnisotropy: float with set
            abstract isTranslucent: unit -> bool
            abstract configureFuzz: unit -> unit
            abstract fuzzWeight: float with set
            abstract fuzzWeightTexture: Nullable<BaseTexture> with set
            abstract fuzzColor: Color3 with set
            abstract fuzzColorTexture: Nullable<BaseTexture> with set
            abstract fuzzRoughness: float with set
            abstract fuzzRoughnessTexture: Nullable<BaseTexture> with set
            abstract specularRoughnessAnisotropy: float with get, set
            abstract geometryTangentAngle: float with set
            abstract geometryTangentTexture: Nullable<BaseTexture> with get, set
            abstract configureGltfStyleAnisotropy: ?useGltfStyle: bool -> unit
            abstract thinFilmWeight: float with set
            abstract thinFilmIor: float with set
            abstract thinFilmThicknessMinimum: float with set
            abstract thinFilmThicknessMaximum: float with set
            abstract thinFilmWeightTexture: Nullable<BaseTexture> with set
            abstract thinFilmThicknessTexture: Nullable<BaseTexture> with set
            abstract unlit: bool with set
            abstract geometryOpacity: float with get, set
            abstract geometryNormalTexture: Nullable<BaseTexture> with get, set
            abstract setNormalMapInversions: invertX: bool * invertY: bool -> unit
            abstract geometryCoatNormalTexture: Nullable<BaseTexture> with get, set
            abstract geometryCoatNormalTextureScale: float with set
            abstract finalizeAsync: loader: BABYLON.GLTF2.GLTFLoader -> Promise<unit>

        type [<AllowNullLiteral>] OpenPBRMaterialLoadingAdapterStatic =
            [<EmitConstructor>] abstract Create: material: Material -> OpenPBRMaterialLoadingAdapter

        type [<AllowNullLiteral>] IMaterialLoadingAdapter =
            abstract material: Material
            abstract finalizeAsync: loader: BABYLON.GLTF2.GLTFLoader -> Promise<unit>
            abstract isUnlit: bool with get, set
            abstract backFaceCulling: bool with get, set
            abstract twoSidedLighting: bool with get, set
            abstract alphaCutOff: float with get, set
            abstract useAlphaFromBaseColorTexture: bool with get, set
            abstract transparencyAsAlphaCoverage: bool with get, set
            abstract baseColor: Color3 with get, set
            abstract baseColorTexture: Nullable<BaseTexture> with get, set
            abstract baseDiffuseRoughness: float with get, set
            abstract baseDiffuseRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract baseMetalness: float with get, set
            abstract baseMetalnessTexture: Nullable<BaseTexture> with get, set
            abstract useRoughnessFromMetallicTextureGreen: bool with get, set
            abstract useMetallicFromMetallicTextureBlue: bool with get, set
            abstract enableSpecularEdgeColor: ?enableEdgeColor: bool -> unit
            abstract configureSpecularGlossiness: unit -> unit
            abstract specularWeight: float with get, set
            abstract specularWeightTexture: Nullable<BaseTexture> with get, set
            abstract specularColor: Color3 with get, set
            abstract specularColorTexture: Nullable<BaseTexture> with get, set
            abstract specularRoughness: float with get, set
            abstract specularRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract specularIor: float with get, set
            abstract glossiness: float with get, set
            abstract emissionColor: Color3 with get, set
            abstract emissionLuminance: float with get, set
            abstract emissionColorTexture: Nullable<BaseTexture> with get, set
            abstract ambientOcclusionTexture: Nullable<BaseTexture> with get, set
            abstract ambientOcclusionTextureStrength: float with get, set
            abstract configureCoat: unit -> unit
            abstract coatWeight: float with get, set
            abstract coatWeightTexture: Nullable<BaseTexture> with get, set
            abstract coatColor: Color3 with get, set
            abstract coatColorTexture: Nullable<BaseTexture> with get, set
            abstract coatRoughness: float with get, set
            abstract coatRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract coatIor: float with get, set
            abstract coatDarkening: float with get, set
            abstract coatDarkeningTexture: Nullable<BaseTexture> with get, set
            abstract coatRoughnessAnisotropy: float with get, set
            abstract geometryCoatTangentAngle: float with get, set
            abstract geometryCoatTangentTexture: Nullable<BaseTexture> with get, set
            abstract transmissionWeight: float with get, set
            abstract transmissionWeightTexture: Nullable<BaseTexture> with get, set
            abstract transmissionDepth: float with get, set
            abstract transmissionColor: Color3 with get, set
            abstract transmissionScatter: Color3 with get, set
            abstract transmissionScatterTexture: Nullable<BaseTexture> with get, set
            abstract transmissionScatterAnisotropy: float with get, set
            abstract transmissionDispersionAbbeNumber: float with get, set
            abstract transmissionDispersionScale: float with get, set
            abstract refractionBackgroundTexture: Nullable<BaseTexture> with get, set
            abstract configureTransmission: unit -> unit
            abstract configureVolume: unit -> unit
            abstract geometryThinWalled: bool with get, set
            abstract volumeThicknessTexture: Nullable<BaseTexture> with get, set
            abstract volumeThickness: float with get, set
            abstract configureSubsurface: unit -> unit
            abstract subsurfaceWeight: float with get, set
            abstract subsurfaceWeightTexture: Nullable<BaseTexture> with get, set
            abstract subsurfaceColor: Color3 with get, set
            abstract subsurfaceColorTexture: Nullable<BaseTexture> with get, set
            abstract diffuseTransmissionTint: Color3 with get, set
            abstract diffuseTransmissionTintTexture: Nullable<BaseTexture> with get, set
            abstract subsurfaceRadius: float with get, set
            abstract subsurfaceRadiusScale: Color3 with get, set
            abstract subsurfaceScatterAnisotropy: float with get, set
            abstract isTranslucent: unit -> bool
            abstract configureFuzz: unit -> unit
            abstract fuzzWeight: float with get, set
            abstract fuzzWeightTexture: Nullable<BaseTexture> with get, set
            abstract fuzzColor: Color3 with get, set
            abstract fuzzColorTexture: Nullable<BaseTexture> with get, set
            abstract fuzzRoughness: float with get, set
            abstract fuzzRoughnessTexture: Nullable<BaseTexture> with get, set
            abstract specularRoughnessAnisotropy: float with get, set
            abstract geometryTangentAngle: float with get, set
            abstract geometryTangentTexture: Nullable<BaseTexture> with get, set
            abstract configureGltfStyleAnisotropy: ?useGltfStyle: bool -> unit
            abstract thinFilmWeight: float with get, set
            abstract thinFilmIor: float with get, set
            abstract thinFilmThicknessMinimum: float with get, set
            abstract thinFilmThicknessMaximum: float with get, set
            abstract thinFilmWeightTexture: Nullable<BaseTexture> with get, set
            abstract thinFilmThicknessTexture: Nullable<BaseTexture> with get, set
            abstract unlit: bool with get, set
            abstract geometryOpacity: float with get, set
            abstract geometryNormalTexture: Nullable<BaseTexture> with get, set
            abstract setNormalMapInversions: invertX: bool * invertY: bool -> unit
            abstract geometryCoatNormalTexture: Nullable<BaseTexture> with get, set
            abstract geometryCoatNormalTextureScale: float with get, set

        module Loader =
            let [<Import("Extensions","babylonjs.loaders.module.no-docs/BABYLON/GLTF2/Loader")>] extensions: Extensions.IExports = jsNative

            type [<AllowNullLiteral>] IArrayItem =
                abstract index: float with get, set

            type [<AllowNullLiteral>] IAccessor =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IAccessor
                inherit IArrayItem
                abstract _data: Promise<ArrayBufferView> option with get, set
                abstract _babylonVertexBuffer: IAccessor_babylonVertexBuffer option with get, set

            type [<AllowNullLiteral>] IAnimationChannel =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IAnimationChannel
                inherit IArrayItem

            type [<AllowNullLiteral>] _IAnimationSamplerData =
                abstract input: Float32Array with get, set
                abstract interpolation: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.AnimationSamplerInterpolation with get, set
                abstract output: Float32Array with get, set

            type [<AllowNullLiteral>] IAnimationSampler =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IAnimationSampler
                inherit IArrayItem
                abstract _data: Promise<_IAnimationSamplerData> option with get, set

            type [<AllowNullLiteral>] IAnimation =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IAnimation
                inherit IArrayItem
                abstract channels: ResizeArray<IAnimationChannel> with get, set
                abstract samplers: ResizeArray<IAnimationSampler> with get, set
                abstract _babylonAnimationGroup: AnimationGroup option with get, set

            type [<AllowNullLiteral>] IBuffer =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IBuffer
                inherit IArrayItem
                abstract _data: Promise<ArrayBufferView> option with get, set

            type [<AllowNullLiteral>] IBufferView =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IBufferView
                inherit IArrayItem
                abstract _data: Promise<ArrayBufferView> option with get, set
                abstract _babylonBuffer: Promise<Buffer> option with get, set

            type [<AllowNullLiteral>] ICamera =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ICamera
                inherit IArrayItem
                abstract _babylonCamera: Camera option with get, set

            type [<AllowNullLiteral>] IImage =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IImage
                inherit IArrayItem
                abstract _data: Promise<ArrayBufferView> option with get, set

            type [<AllowNullLiteral>] IMaterialNormalTextureInfo =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMaterialNormalTextureInfo
                inherit ITextureInfo

            type [<AllowNullLiteral>] IMaterialOcclusionTextureInfo =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMaterialOcclusionTextureInfo
                inherit ITextureInfo

            type [<AllowNullLiteral>] IMaterialPbrMetallicRoughness =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMaterialPbrMetallicRoughness
                abstract baseColorTexture: ITextureInfo option with get, set
                abstract metallicRoughnessTexture: ITextureInfo option with get, set

            type [<AllowNullLiteral>] IMaterial =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMaterial
                inherit IArrayItem
                abstract pbrMetallicRoughness: IMaterialPbrMetallicRoughness option with get, set
                abstract normalTexture: IMaterialNormalTextureInfo option with get, set
                abstract occlusionTexture: IMaterialOcclusionTextureInfo option with get, set
                abstract emissiveTexture: ITextureInfo option with get, set
                abstract _data: IMaterial_data option with get, set

            type [<AllowNullLiteral>] IMesh =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMesh
                inherit IArrayItem
                abstract primitives: ResizeArray<IMeshPrimitive> with get, set

            type [<AllowNullLiteral>] IMeshPrimitive =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IMeshPrimitive
                inherit IArrayItem
                abstract _instanceData: {| babylonSourceMesh: Mesh; promise: Promise<obj option> |} option with get, set

            type [<AllowNullLiteral>] INode =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.INode
                inherit IArrayItem
                abstract parent: INode option with get, set
                abstract _babylonTransformNode: TransformNode option with get, set
                abstract _babylonTransformNodeForSkin: TransformNode option with get, set
                abstract _primitiveBabylonMeshes: ResizeArray<AbstractMesh> option with get, set
                abstract _numMorphTargets: float option with get, set
                abstract _isJoint: bool option with get, set

            type [<AllowNullLiteral>] _ISamplerData =
                abstract noMipMaps: bool with get, set
                abstract samplingMode: float with get, set
                abstract wrapU: float with get, set
                abstract wrapV: float with get, set

            type [<AllowNullLiteral>] ISampler =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ISampler
                inherit IArrayItem
                abstract _data: _ISamplerData option with get, set

            type [<AllowNullLiteral>] IScene =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IScene
                inherit IArrayItem

            type [<AllowNullLiteral>] ISkin =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ISkin
                inherit IArrayItem
                abstract _data: {| babylonSkeleton: Skeleton; promise: Promise<unit> |} option with get, set

            type [<AllowNullLiteral>] ITexture =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ITexture
                inherit IArrayItem
                abstract _textureInfo: ITextureInfo with get, set

            type [<AllowNullLiteral>] ITextureInfo =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.ITextureInfo
                abstract nonColorData: bool option with get, set

            type [<AllowNullLiteral>] IGLTF =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IGLTF
                abstract accessors: ResizeArray<IAccessor> option with get, set
                abstract animations: ResizeArray<IAnimation> option with get, set
                abstract buffers: ResizeArray<IBuffer> option with get, set
                abstract bufferViews: ResizeArray<IBufferView> option with get, set
                abstract cameras: ResizeArray<ICamera> option with get, set
                abstract images: ResizeArray<IImage> option with get, set
                abstract materials: ResizeArray<IMaterial> option with get, set
                abstract meshes: ResizeArray<IMesh> option with get, set
                abstract nodes: ResizeArray<INode> option with get, set
                abstract samplers: ResizeArray<ISampler> option with get, set
                abstract scenes: ResizeArray<IScene> option with get, set
                abstract skins: ResizeArray<ISkin> option with get, set
                abstract textures: ResizeArray<ITexture> option with get, set

            type [<AllowNullLiteral>] IKHRLightsPunctual_Light =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRLightsPunctual_Light
                inherit IArrayItem
                abstract _babylonLight: Light option with get, set

            type [<AllowNullLiteral>] IEXTLightsIES_Light =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IEXTLightsIES_Light
                inherit IArrayItem
                abstract _babylonLight: Light option with get, set

            type [<AllowNullLiteral>] IEXTLightsArea_Light =
                inherit BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IEXTLightsArea_Light
                inherit IArrayItem
                abstract _babylonLight: Light option with get, set

            module Extensions =

                type [<AllowNullLiteral>] IExports =
                    abstract TransmissionHelper: TransmissionHelperStatic
                    abstract ensureTransmissionHelper: loader: BABYLON.GLTF2.GLTFLoader * babylonMaterial: Material -> unit
                    abstract GetPathToObjectConverter: gltf: BABYLON.GLTF2.Loader.IGLTF -> BABYLON.GLTF2.Loader.Extensions.GLTFPathToObjectConverter<obj, obj, obj>
                    abstract GetMappingForKey: key: string -> IObjectAccessor option
                    abstract SetInterpolationForKey: key: string * ?interpolation: ResizeArray<IInterpolationPropertyInfo> -> unit
                    abstract AddObjectAccessorToKey: key: string * accessor: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> -> unit
                    abstract OptionalPathExceptionsList: ResizeArray<{| regex: RegExp |}> with get, set
                    abstract GLTFPathToObjectConverter: GLTFPathToObjectConverterStatic
                    abstract registerBuiltInGLTFExtensions: unit -> unit
                    abstract MSFT_sRGBFactors: MSFT_sRGBFactorsStatic
                    abstract RegisterMSFT_sRGBFactors: unit -> unit
                    abstract MSFT_minecraftMesh: MSFT_minecraftMeshStatic
                    abstract RegisterMSFT_minecraftMesh: unit -> unit
                    abstract MSFT_lod: MSFT_lodStatic
                    abstract RegisterMSFT_lod: unit -> unit
                    abstract MSFT_audio_emitter: MSFT_audio_emitterStatic
                    abstract RegisterMSFT_audio_emitter: unit -> unit
                    abstract KHR_xmp_json_ld: KHR_xmp_json_ldStatic
                    abstract RegisterKHR_xmp_json_ld: unit -> unit
                    abstract KHR_texture_transform: KHR_texture_transformStatic
                    abstract RegisterKHR_texture_transform: unit -> unit
                    abstract KHR_texture_basisu: KHR_texture_basisuStatic
                    abstract RegisterKHR_texture_basisu: unit -> unit
                    abstract KHR_node_visibility: KHR_node_visibilityStatic
                    abstract RegisterKHR_node_visibility: unit -> unit
                    abstract KHR_node_selectability: KHR_node_selectabilityStatic
                    abstract RegisterKHR_node_selectability: unit -> unit
                    abstract KHR_node_hoverability: KHR_node_hoverabilityStatic
                    abstract RegisterKHR_node_hoverability: unit -> unit
                    abstract KHR_mesh_quantization: KHR_mesh_quantizationStatic
                    abstract RegisterKHR_mesh_quantization: unit -> unit
                    abstract KHR_materials_volume_scatter: KHR_materials_volume_scatterStatic
                    abstract RegisterKHR_materials_volume_scatter: unit -> unit
                    abstract KHR_materials_volume: KHR_materials_volumeStatic
                    abstract RegisterKHR_materials_volume: unit -> unit
                    abstract KHR_materials_variants: KHR_materials_variantsStatic
                    abstract RegisterKHR_materials_variants: unit -> unit
                    abstract KHR_materials_unlit: KHR_materials_unlitStatic
                    abstract RegisterKHR_materials_unlit: unit -> unit
                    abstract KHR_materials_transmission: KHR_materials_transmissionStatic
                    abstract RegisterKHR_materials_transmission: unit -> unit
                    abstract KHR_materials_specular: KHR_materials_specularStatic
                    abstract RegisterKHR_materials_specular: unit -> unit
                    abstract KHR_materials_sheen: KHR_materials_sheenStatic
                    abstract RegisterKHR_materials_sheen: unit -> unit
                    abstract KHR_materials_pbrSpecularGlossiness: KHR_materials_pbrSpecularGlossinessStatic
                    abstract RegisterKHR_materials_pbrSpecularGlossiness: unit -> unit
                    abstract KHR_materials_iridescence: KHR_materials_iridescenceStatic
                    abstract RegisterKHR_materials_iridescence: unit -> unit
                    abstract KHR_materials_ior: KHR_materials_iorStatic
                    abstract RegisterKHR_materials_ior: unit -> unit
                    abstract KHR_materials_fuzz: KHR_materials_fuzzStatic
                    abstract RegisterKHR_materials_fuzz: unit -> unit
                    abstract KHR_materials_emissive_strength: KHR_materials_emissive_strengthStatic
                    abstract RegisterKHR_materials_emissive_strength: unit -> unit
                    abstract KHR_materials_dispersion: KHR_materials_dispersionStatic
                    abstract RegisterKHR_materials_dispersion: unit -> unit
                    abstract KHR_materials_diffuse_transmission: KHR_materials_diffuse_transmissionStatic
                    abstract RegisterKHR_materials_diffuse_transmission: unit -> unit
                    abstract KHR_materials_diffuse_roughness: KHR_materials_diffuse_roughnessStatic
                    abstract RegisterKHR_materials_diffuse_roughness: unit -> unit
                    abstract KHR_materials_coat: KHR_materials_coatStatic
                    abstract RegisterKHR_materials_coat: unit -> unit
                    abstract KHR_materials_clearcoat: KHR_materials_clearcoatStatic
                    abstract RegisterKHR_materials_clearcoat: unit -> unit
                    abstract KHR_materials_anisotropy: KHR_materials_anisotropyStatic
                    abstract RegisterKHR_materials_anisotropy: unit -> unit
                    abstract KHR_lights: KHR_lightsStatic
                    abstract RegisterKHR_lights: unit -> unit
                    abstract KHR_interactivity: KHR_interactivityStatic
                    abstract _AddInteractivityObjectModel: scene: Scene -> unit
                    abstract RegisterKHR_interactivity: unit -> unit
                    abstract KHR_gaussian_splatting: KHR_gaussian_splattingStatic
                    abstract RegisterKHR_gaussian_splatting: unit -> unit
                    abstract KHR_draco_mesh_compression: KHR_draco_mesh_compressionStatic
                    abstract RegisterKHR_draco_mesh_compression: unit -> unit
                    abstract KHR_animation_pointer: KHR_animation_pointerStatic
                    abstract RegisterKHR_animation_pointer: unit -> unit
                    abstract ExtrasAsMetadata: ExtrasAsMetadataStatic
                    abstract RegisterExtrasAsMetadata: unit -> unit
                    abstract EXT_texture_webp: EXT_texture_webpStatic
                    abstract RegisterEXT_texture_webp: unit -> unit
                    abstract EXT_texture_avif: EXT_texture_avifStatic
                    abstract RegisterEXT_texture_avif: unit -> unit
                    abstract EXT_meshopt_compression: EXT_meshopt_compressionStatic
                    abstract RegisterEXT_meshopt_compression: unit -> unit
                    abstract EXT_mesh_gpu_instancing: EXT_mesh_gpu_instancingStatic
                    abstract RegisterEXT_mesh_gpu_instancing: unit -> unit
                    abstract EXT_lights_image_based: EXT_lights_image_basedStatic
                    abstract RegisterEXT_lights_image_based: unit -> unit
                    abstract EXT_lights_ies: EXT_lights_iesStatic
                    abstract RegisterEXT_lights_ies: unit -> unit
                    abstract EXT_lights_area: EXT_lights_areaStatic
                    abstract RegisterEXT_lights_area: unit -> unit
                    abstract gltfTypeToBabylonType: IExportsGltfTypeToBabylonType with get, set
                    abstract InteractivityGraphToFlowGraphParser: InteractivityGraphToFlowGraphParserStatic
                    abstract FlowGraphGLTFDataProvider: FlowGraphGLTFDataProviderStatic
                    abstract getMappingForFullOperationName: fullOperationName: string -> IGLTFToFlowGraphMapping option
                    abstract getMappingForDeclaration: declaration: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Declaration * ?returnNoOpIfNotAvailable: bool -> IGLTFToFlowGraphMapping option
                    abstract addNewInteractivityFlowGraphMapping: key: string * extension: string * mapping: IGLTFToFlowGraphMapping -> unit
                    abstract getAllSupportedNativeNodeTypes: unit -> ResizeArray<string>

                type [<AllowNullLiteral>] ITransmissionHelperMaterialImpl =
                    abstract materialClass: obj with get, set
                    abstract adapterClass: obj with get, set

                type [<AllowNullLiteral>] ITransmissionHelperHolder =
                    abstract _transmissionHelper: TransmissionHelper option with get, set

                type [<AllowNullLiteral>] ITransmissionHelperOptions =
                    abstract renderSize: float with get, set
                    abstract samples: float with get, set
                    abstract lodGenerationScale: float with get, set
                    abstract lodGenerationOffset: float with get, set
                    abstract renderTargetTextureType: float with get, set
                    abstract generateMipmaps: bool with get, set
                    abstract clearColor: Color4 option with get, set

                type [<AllowNullLiteral>] TransmissionHelper =
                    abstract onErrorObservable: Observable<{| message: string option; ``exception``: obj option |}> with get, set
                    abstract addMaterialImpl: impl: ITransmissionHelperMaterialImpl -> unit
                    abstract updateOptions: options: obj -> unit
                    abstract getOpaqueTarget: unit -> Nullable<Texture>
                    abstract _isRenderTargetValid: unit -> bool
                    abstract _setupRenderTargets: unit -> unit
                    abstract dispose: unit -> unit

                type [<AllowNullLiteral>] TransmissionHelperStatic =
                    [<EmitConstructor>] abstract Create: options: obj * scene: Scene -> TransmissionHelper

                type [<AllowNullLiteral>] IGLTFObjectModelTree =
                    abstract cameras: IGLTFObjectModelTreeCamerasObject with get, set
                    abstract nodes: IGLTFObjectModelTreeNodesObject with get, set
                    abstract materials: IGLTFObjectModelTreeMaterialsObject with get, set
                    abstract extensions: IGLTFObjectModelTreeExtensionsObject with get, set
                    abstract animations: {| length: IObjectAccessor<ResizeArray<BABYLON.GLTF2.Loader.IAnimation>, ResizeArray<AnimationGroup>, float>; __array__: IGLTFObjectModelTreeAnimations__array__ |} with get, set
                    abstract meshes: {| length: IObjectAccessor<ResizeArray<BABYLON.GLTF2.Loader.IMesh>, ResizeArray<Mesh option>, float>; __array__: IGLTFObjectModelTreeAnimations__array__ |} with get, set

                type IGLTFObjectModelTreeNodesObject =
                    IGLTFObjectModelTreeNodesObject<BABYLON.GLTF2.Loader.INode, TransformNode>

                type IGLTFObjectModelTreeNodesObject<'GLTFTargetType> =
                    IGLTFObjectModelTreeNodesObject<'GLTFTargetType, TransformNode>

                type [<AllowNullLiteral>] IGLTFObjectModelTreeNodesObject<'GLTFTargetType, 'BabylonTargetType> =
                    abstract length: IObjectAccessor<ResizeArray<'GLTFTargetType>, ResizeArray<'BabylonTargetType>, float> with get, set
                    abstract __array__: IGLTFObjectModelTreeNodesObject__array__<'GLTFTargetType, 'BabylonTargetType> with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeCamerasObject =
                    abstract __array__: {| __target__: bool; orthographic: {| xmag: IObjectAccessor<BABYLON.GLTF2.Loader.ICamera, BABYLON.GLTF2.Loader.ICamera, Vector2>; ymag: IObjectAccessor<BABYLON.GLTF2.Loader.ICamera, BABYLON.GLTF2.Loader.ICamera, Vector2>; zfar: IObjectAccessor<BABYLON.GLTF2.Loader.ICamera, BABYLON.GLTF2.Loader.ICamera, float>; znear: IObjectAccessor<BABYLON.GLTF2.Loader.ICamera, BABYLON.GLTF2.Loader.ICamera, float> |}; perspective: {| yfov: IObjectAccessor<BABYLON.GLTF2.Loader.ICamera, BABYLON.GLTF2.Loader.ICamera, float>; zfar: IObjectAccessor<BABYLON.GLTF2.Loader.ICamera, BABYLON.GLTF2.Loader.ICamera, float>; znear: IObjectAccessor<BABYLON.GLTF2.Loader.ICamera, BABYLON.GLTF2.Loader.ICamera, float>; aspectRatio: IObjectAccessor<BABYLON.GLTF2.Loader.ICamera, BABYLON.GLTF2.Loader.ICamera, Nullable<float>> |} |} with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject =
                    abstract __array__: IGLTFObjectModelTreeMaterialsObject__array__ with get, set

                type [<AllowNullLiteral>] ITextureDefinition =
                    abstract offset: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Vector2> with get, set
                    abstract rotation: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> with get, set
                    abstract scale: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Vector2> with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeMeshesObject =
                    interface end

                type [<AllowNullLiteral>] IGLTFObjectModelTreeExtensionsObject =
                    abstract KHR_lights_punctual: {| lights: {| length: IObjectAccessor<ResizeArray<BABYLON.GLTF2.Loader.IKHRLightsPunctual_Light>, ResizeArray<Light>, float>; __array__: IGLTFObjectModelTreeExtensionsObjectKHR_lights_punctualLights__array__ |} |} with get, set
                    abstract EXT_lights_area: {| lights: {| length: IObjectAccessor<ResizeArray<BABYLON.GLTF2.Loader.IEXTLightsArea_Light>, ResizeArray<Light>, float>; __array__: IGLTFObjectModelTreeExtensionsObjectEXT_lights_areaLights__array__ |} |} with get, set
                    abstract EXT_lights_ies: {| lights: {| length: IObjectAccessor<ResizeArray<BABYLON.GLTF2.Loader.IKHRLightsPunctual_Light>, ResizeArray<Light>, float> |} |} with get, set
                    abstract EXT_lights_image_based: {| lights: {| __array__: {| __target__: bool; intensity: IObjectAccessor<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IEXTLightsImageBased_LightImageBased, BaseTexture, float>; rotation: IObjectAccessor<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IEXTLightsImageBased_LightImageBased, BaseTexture, Quaternion> |}; length: IObjectAccessor<ResizeArray<BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IEXTLightsImageBased_LightImageBased>, ResizeArray<BaseTexture>, float> |} |} with get, set

                type [<AllowNullLiteral>] GLTFPathToObjectConverter<'T, 'BabylonType, 'BabylonValue> =
                    inherit IPathToObjectConverter<IObjectAccessor<'T, 'BabylonType, 'BabylonValue>>
                    abstract convert: path: string -> IObjectInfo<IObjectAccessor<'T, 'BabylonType, 'BabylonValue>>

                type [<AllowNullLiteral>] GLTFPathToObjectConverterStatic =
                    [<EmitConstructor>] abstract Create: _gltf: BABYLON.GLTF2.Loader.IGLTF * _infoTree: obj option -> GLTFPathToObjectConverter<'T, 'BabylonType, 'BabylonValue>

                type [<AllowNullLiteral>] MSFT_sRGBFactors =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] MSFT_sRGBFactorsStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> MSFT_sRGBFactors

                type [<AllowNullLiteral>] MSFT_minecraftMesh =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] MSFT_minecraftMeshStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> MSFT_minecraftMesh

                type [<AllowNullLiteral>] MSFT_lod =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract maxLODsToLoad: float with get, set
                    abstract onNodeLODsLoadedObservable: Observable<float> with get, set
                    abstract onMaterialLODsLoadedObservable: Observable<float> with get, set
                    abstract dispose: unit -> unit
                    abstract onReady: unit -> unit
                    abstract loadSceneAsync: context: string * scene: BABYLON.GLTF2.Loader.IScene -> Nullable<Promise<unit>>
                    abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>
                    abstract _loadMaterialAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMesh: Nullable<Mesh> * babylonDrawMode: float * assign: (Material -> unit) -> Nullable<Promise<Material>>
                    abstract _loadUriAsync: context: string * property: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IProperty * uri: string -> Nullable<Promise<ArrayBufferView>>
                    abstract loadBufferAsync: context: string * buffer: BABYLON.GLTF2.Loader.IBuffer * byteOffset: float * byteLength: float -> Nullable<Promise<ArrayBufferView>>

                type [<AllowNullLiteral>] MSFT_lodStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> MSFT_lod

                type [<AllowNullLiteral>] MSFT_audio_emitter =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract onLoading: unit -> unit
                    abstract loadSceneAsync: context: string * scene: BABYLON.GLTF2.Loader.IScene -> Nullable<Promise<unit>>
                    abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>
                    abstract loadAnimationAsync: context: string * animation: BABYLON.GLTF2.Loader.IAnimation -> Nullable<Promise<AnimationGroup>>

                type [<AllowNullLiteral>] MSFT_audio_emitterStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> MSFT_audio_emitter

                type [<AllowNullLiteral>] KHR_xmp_json_ld =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract onLoading: unit -> unit

                type [<AllowNullLiteral>] KHR_xmp_json_ldStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_xmp_json_ld

                type [<AllowNullLiteral>] KHR_texture_transform =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract loadTextureInfoAsync: context: string * textureInfo: BABYLON.GLTF2.Loader.ITextureInfo * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>

                type [<AllowNullLiteral>] KHR_texture_transformStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_texture_transform

                type [<AllowNullLiteral>] KHR_texture_basisu =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract _loadTextureAsync: context: string * texture: BABYLON.GLTF2.Loader.ITexture * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>

                type [<AllowNullLiteral>] KHR_texture_basisuStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_texture_basisu

                type [<AllowNullLiteral>] KHR_node_visibility =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract onReady: unit -> unit
                    abstract dispose: unit -> unit

                type [<AllowNullLiteral>] KHR_node_visibilityStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_node_visibility

                type [<AllowNullLiteral>] KHR_node_selectability =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract onReady: unit -> Promise<unit>
                    abstract dispose: unit -> unit

                type [<AllowNullLiteral>] KHR_node_selectabilityStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_node_selectability

                type [<AllowNullLiteral>] KHR_node_hoverability =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract onReady: unit -> Promise<unit>
                    abstract dispose: unit -> unit

                type [<AllowNullLiteral>] KHR_node_hoverabilityStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_node_hoverability

                type [<AllowNullLiteral>] KHR_mesh_quantization =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit

                type [<AllowNullLiteral>] KHR_mesh_quantizationStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_mesh_quantization

                type [<AllowNullLiteral>] KHR_materials_volume_scatter =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_volume_scatterStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_volume_scatter

                type [<AllowNullLiteral>] KHR_materials_volume =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_volumeStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_volume

                type [<AllowNullLiteral>] MaterialVariantsController =
                    abstract variants: ResizeArray<string>
                    abstract selectedVariant: string with get, set

                type [<AllowNullLiteral>] KHR_materials_variants =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract getAvailableVariants: rootNode: TransformNode -> ResizeArray<string>
                    abstract selectVariant: rootNode: TransformNode * variantName: U2<string, ResizeArray<string>> -> unit
                    abstract reset: rootNode: TransformNode -> unit
                    abstract getLastSelectedVariant: rootNode: TransformNode -> Nullable<U2<string, ResizeArray<string>>>
                    abstract onLoading: unit -> unit
                    abstract onReady: unit -> unit
                    abstract _loadMeshPrimitiveAsync: context: string * name: string * node: BABYLON.GLTF2.Loader.INode * mesh: BABYLON.GLTF2.Loader.IMesh * primitive: BABYLON.GLTF2.Loader.IMeshPrimitive * assign: (AbstractMesh -> unit) -> Nullable<Promise<AbstractMesh>>

                type [<AllowNullLiteral>] KHR_materials_variantsStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_variants
                    abstract GetAvailableVariants: rootNode: TransformNode -> ResizeArray<string>
                    abstract SelectVariant: rootNode: TransformNode * variantName: U2<string, ResizeArray<string>> -> unit
                    abstract Reset: rootNode: TransformNode -> unit
                    abstract GetLastSelectedVariant: rootNode: TransformNode -> Nullable<U2<string, ResizeArray<string>>>

                type [<AllowNullLiteral>] KHR_materials_unlit =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_unlitStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_unlit

                type [<AllowNullLiteral>] KHR_materials_transmission =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_transmissionStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_transmission

                type [<AllowNullLiteral>] KHR_materials_specular =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_specularStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_specular

                type [<AllowNullLiteral>] KHR_materials_sheen =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_sheenStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_sheen

                type [<AllowNullLiteral>] KHR_materials_pbrSpecularGlossiness =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_pbrSpecularGlossinessStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_pbrSpecularGlossiness

                type [<AllowNullLiteral>] KHR_materials_iridescence =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_iridescenceStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_iridescence

                type [<AllowNullLiteral>] KHR_materials_ior =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_iorStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_ior

                type [<AllowNullLiteral>] KHR_materials_fuzz =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_fuzzStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_fuzz

                type [<AllowNullLiteral>] KHR_materials_emissive_strength =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_emissive_strengthStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_emissive_strength

                type [<AllowNullLiteral>] KHR_materials_dispersion =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_dispersionStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_dispersion

                type [<AllowNullLiteral>] KHR_materials_diffuse_transmission =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_diffuse_transmissionStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_diffuse_transmission

                type [<AllowNullLiteral>] KHR_materials_diffuse_roughness =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_diffuse_roughnessStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_diffuse_roughness

                type [<AllowNullLiteral>] KHR_materials_coat =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_coatStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_coat

                type [<AllowNullLiteral>] KHR_materials_clearcoat =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_clearcoatStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_clearcoat

                type [<AllowNullLiteral>] KHR_materials_anisotropy =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract order: float with get, set
                    abstract dispose: unit -> unit
                    abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_materials_anisotropyStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_materials_anisotropy

                type [<AllowNullLiteral>] KHR_lights =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract onLoading: unit -> unit
                    abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>

                type [<AllowNullLiteral>] KHR_lightsStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_lights

                type [<AllowNullLiteral>] KHR_interactivity =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract onReady: unit -> Promise<unit>

                type [<AllowNullLiteral>] KHR_interactivityStatic =
                    [<EmitConstructor>] abstract Create: _loader: BABYLON.GLTF2.GLTFLoader -> KHR_interactivity

                type [<AllowNullLiteral>] KHR_gaussian_splatting =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract _loadMeshPrimitiveAsync: context: string * name: string * node: BABYLON.GLTF2.Loader.INode * mesh: BABYLON.GLTF2.Loader.IMesh * primitive: BABYLON.GLTF2.Loader.IMeshPrimitive * assign: (AbstractMesh -> unit) -> Nullable<Promise<AbstractMesh>>

                type [<AllowNullLiteral>] KHR_gaussian_splattingStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_gaussian_splatting

                type [<AllowNullLiteral>] KHR_draco_mesh_compression =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract dracoDecoder: DracoDecoder option with get, set
                    abstract enabled: bool with get, set
                    abstract useNormalizedFlagFromAccessor: bool with get, set
                    abstract dispose: unit -> unit
                    abstract _loadVertexDataAsync: context: string * primitive: BABYLON.GLTF2.Loader.IMeshPrimitive * babylonMesh: Mesh -> Nullable<Promise<Geometry>>

                type [<AllowNullLiteral>] KHR_draco_mesh_compressionStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_draco_mesh_compression

                type [<AllowNullLiteral>] KHR_animation_pointer =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool
                    abstract dispose: unit -> unit
                    abstract _loadAnimationChannelAsync: context: string * animationContext: string * animation: BABYLON.GLTF2.Loader.IAnimation * channel: BABYLON.GLTF2.Loader.IAnimationChannel * onLoad: (IAnimatable -> Animation -> unit) -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] KHR_animation_pointerStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> KHR_animation_pointer

                type [<AllowNullLiteral>] ExtrasAsMetadata =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>
                    abstract loadCameraAsync: context: string * camera: BABYLON.GLTF2.Loader.ICamera * assign: (Camera -> unit) -> Nullable<Promise<Camera>>
                    abstract createMaterial: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonDrawMode: float -> Nullable<Material>
                    abstract loadAnimationAsync: context: string * animation: BABYLON.GLTF2.Loader.IAnimation -> Nullable<Promise<AnimationGroup>>

                type [<AllowNullLiteral>] ExtrasAsMetadataStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> ExtrasAsMetadata

                type [<AllowNullLiteral>] EXT_texture_webp =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract _loadTextureAsync: context: string * texture: BABYLON.GLTF2.Loader.ITexture * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>

                type [<AllowNullLiteral>] EXT_texture_webpStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> EXT_texture_webp

                type [<AllowNullLiteral>] EXT_texture_avif =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract _loadTextureAsync: context: string * texture: BABYLON.GLTF2.Loader.ITexture * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>

                type [<AllowNullLiteral>] EXT_texture_avifStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> EXT_texture_avif

                type [<AllowNullLiteral>] EXT_meshopt_compression =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract loadBufferViewAsync: context: string * bufferView: BABYLON.GLTF2.Loader.IBufferView -> Nullable<Promise<ArrayBufferView>>

                type [<AllowNullLiteral>] EXT_meshopt_compressionStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> EXT_meshopt_compression

                type [<AllowNullLiteral>] EXT_mesh_gpu_instancing =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>

                type [<AllowNullLiteral>] EXT_mesh_gpu_instancingStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> EXT_mesh_gpu_instancing

                type [<AllowNullLiteral>] IEXTLightsImageBased_LightImageBased =
                    abstract _babylonTexture: BaseTexture option with get, set
                    abstract _loaded: Promise<unit> option with get, set

                type [<AllowNullLiteral>] EXT_lights_image_based =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract onLoading: unit -> unit
                    abstract loadSceneAsync: context: string * scene: BABYLON.GLTF2.Loader.IScene -> Nullable<Promise<unit>>

                type [<AllowNullLiteral>] EXT_lights_image_basedStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> EXT_lights_image_based

                type [<AllowNullLiteral>] EXT_lights_ies =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract onLoading: unit -> unit
                    abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>

                type [<AllowNullLiteral>] EXT_lights_iesStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> EXT_lights_ies

                type [<AllowNullLiteral>] EXT_lights_area =
                    inherit BABYLON.GLTF2.IGLTFLoaderExtension
                    abstract name: obj
                    abstract enabled: bool with get, set
                    abstract dispose: unit -> unit
                    abstract onLoading: unit -> unit
                    abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>

                type [<AllowNullLiteral>] EXT_lights_areaStatic =
                    [<EmitConstructor>] abstract Create: loader: BABYLON.GLTF2.GLTFLoader -> EXT_lights_area

                type [<AllowNullLiteral>] InteractivityEvent =
                    abstract eventId: string with get, set
                    abstract eventData: ResizeArray<{| eventData: bool; id: string; ``type``: string; value: obj option |}> option with get, set

                type [<AllowNullLiteral>] InteractivityGraphToFlowGraphParser =
                    abstract _animationTargetFps: float with get, set
                    abstract arrays: InteractivityGraphToFlowGraphParserArrays
                    abstract getVariableName: index: float -> string
                    abstract serializeToFlowGraph: unit -> ISerializedFlowGraph

                type [<AllowNullLiteral>] InteractivityGraphToFlowGraphParserStatic =
                    [<EmitConstructor>] abstract Create: _interactivityGraph: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Graph * _gltf: BABYLON.GLTF2.Loader.IGLTF * ?_animationTargetFps: float -> InteractivityGraphToFlowGraphParser

                type [<AllowNullLiteral>] IFlowGraphGLTFDataProviderBlockConfiguration =
                    inherit IFlowGraphBlockConfiguration
                    abstract glTF: BABYLON.GLTF2.Loader.IGLTF with get, set

                type [<AllowNullLiteral>] FlowGraphGLTFDataProvider =
                    inherit FlowGraphBlock
                    abstract animationGroups: FlowGraphDataConnection<ResizeArray<AnimationGroup>>
                    abstract nodes: FlowGraphDataConnection<ResizeArray<TransformNode>>
                    abstract getClassName: unit -> string

                type [<AllowNullLiteral>] FlowGraphGLTFDataProviderStatic =
                    [<EmitConstructor>] abstract Create: config: IFlowGraphGLTFDataProviderBlockConfiguration -> FlowGraphGLTFDataProvider

                type [<AllowNullLiteral>] IGLTFToFlowGraphMappingObject =
                    abstract name: string with get, set
                    abstract gltfType: string option with get, set
                    abstract flowGraphType: string option with get, set
                    abstract dataTransformer: (obj option -> BABYLON.GLTF2.Loader.Extensions.InteractivityGraphToFlowGraphParser -> obj option) option with get, set
                    abstract isArray: bool option with get, set
                    abstract inOptions: bool option with get, set
                    abstract isVariable: bool option with get, set
                    abstract toBlock: FlowGraphBlockNames option with get, set
                    abstract defaultValue: obj option with get, set

                type [<AllowNullLiteral>] IGLTFToFlowGraphMapping =
                    abstract blocks: ResizeArray<U2<FlowGraphBlockNames, string>> with get, set
                    abstract inputs: {| values: IGLTFToFlowGraphMappingInputsValues option; flows: IGLTFToFlowGraphMappingInputsValues option |} option with get, set
                    abstract outputs: {| values: IGLTFToFlowGraphMappingInputsValues option; flows: IGLTFToFlowGraphMappingInputsValues option |} option with get, set
                    abstract configuration: IGLTFToFlowGraphMappingInputsValues option with get, set
                    abstract typeToTypeMapping: IGLTFToFlowGraphMappingInputsValues option with get, set
                    abstract interBlockConnectors: ResizeArray<IGLTFToFlowGraphMappingInterBlockConnectors> option with get, set
                    abstract validation: (BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Node -> BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Graph -> (BABYLON.GLTF2.Loader.IGLTF) option -> {| valid: bool; error: string option |}) option with get, set
                    abstract extraProcessor: (BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Node -> BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IKHRInteractivity_Declaration -> IGLTFToFlowGraphMapping -> BABYLON.GLTF2.Loader.Extensions.InteractivityGraphToFlowGraphParser -> ResizeArray<ISerializedFlowGraphBlock> -> ISerializedFlowGraphContext -> (BABYLON.GLTF2.Loader.IGLTF) option -> ResizeArray<ISerializedFlowGraphBlock>) option with get, set

                type [<StringEnum>] [<RequireQualifiedAccess>] IExportsGltfTypeToBabylonTypeItemElementType =
                    | Number
                    | Boolean

                type [<AllowNullLiteral>] IExportsGltfTypeToBabylonType =
                    [<EmitIndexer>] abstract Item: key: string -> {| length: float; flowGraphType: FlowGraphTypes; elementType: IExportsGltfTypeToBabylonTypeItemElementType |} with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeAnimations__array__ =
                    interface end

                type [<AllowNullLiteral>] IGLTFObjectModelTreeNodesObject__array__<'GLTFTargetType, 'BabylonTargetType> =
                    abstract __target__: bool with get, set
                    abstract translation: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Vector3> with get, set
                    abstract rotation: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Quaternion> with get, set
                    abstract scale: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Vector3> with get, set
                    abstract matrix: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Matrix> with get, set
                    abstract globalMatrix: IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, Matrix> with get, set
                    abstract weights: obj with get, set
                    abstract extensions: {| EXT_lights_ies: {| multiplier: IObjectAccessor<BABYLON.GLTF2.Loader.INode, Light, float>; color: IObjectAccessor<BABYLON.GLTF2.Loader.INode, Light, Color3> |} option; KHR_node_visibility: {| visible: IObjectAccessor<BABYLON.GLTF2.Loader.INode, Mesh, bool> |} option |} with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__PbrMetallicRoughness =
                    abstract baseColorFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Color4> with get, set
                    abstract metallicFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Nullable<float>> with get, set
                    abstract roughnessFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Nullable<float>> with get, set
                    abstract baseColorTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
                    abstract metallicRoughnessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__ExtensionsKHR_materials_clearcoat =
                    abstract clearcoatFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> with get, set
                    abstract clearcoatRoughnessFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> with get, set
                    abstract clearcoatTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
                    abstract clearcoatNormalTexture: {| scale: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
                    abstract clearcoatRoughnessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__ExtensionsKHR_materials_iridescence =
                    abstract iridescenceFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> with get, set
                    abstract iridescenceIor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> with get, set
                    abstract iridescenceThicknessMinimum: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> with get, set
                    abstract iridescenceThicknessMaximum: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> with get, set
                    abstract iridescenceTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
                    abstract iridescenceThicknessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__Extensions =
                    abstract KHR_materials_anisotropy: {| anisotropyStrength: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; anisotropyRotation: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; anisotropyTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
                    abstract KHR_materials_clearcoat: IGLTFObjectModelTreeMaterialsObject__array__ExtensionsKHR_materials_clearcoat with get, set
                    abstract KHR_materials_dispersion: {| dispersion: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> |} with get, set
                    abstract KHR_materials_emissive_strength: {| emissiveStrength: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> |} with get, set
                    abstract KHR_materials_ior: {| ior: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float> |} with get, set
                    abstract KHR_materials_iridescence: IGLTFObjectModelTreeMaterialsObject__array__ExtensionsKHR_materials_iridescence with get, set
                    abstract KHR_materials_sheen: {| sheenColorFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Color3>; sheenRoughnessFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; sheenColorTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |}; sheenRoughnessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
                    abstract KHR_materials_specular: {| specularFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; specularColorFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Color3>; specularTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |}; specularColorTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
                    abstract KHR_materials_transmission: {| transmissionFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; transmissionTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
                    abstract KHR_materials_diffuse_transmission: {| diffuseTransmissionFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; diffuseTransmissionTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |}; diffuseTransmissionColorFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Nullable<Color3>>; diffuseTransmissionColorTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set
                    abstract KHR_materials_volume: {| thicknessFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; attenuationColor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Color3>; attenuationDistance: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; thicknessTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} |} with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeMaterialsObject__array__ =
                    abstract __target__: bool with get, set
                    abstract pbrMetallicRoughness: IGLTFObjectModelTreeMaterialsObject__array__PbrMetallicRoughness with get, set
                    abstract emissiveFactor: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, Color3> with get, set
                    abstract normalTexture: {| scale: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
                    abstract occlusionTexture: {| strength: IObjectAccessor<BABYLON.GLTF2.Loader.IMaterial, PBRMaterial, float>; extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
                    abstract emissiveTexture: {| extensions: {| KHR_texture_transform: ITextureDefinition |} |} with get, set
                    abstract extensions: IGLTFObjectModelTreeMaterialsObject__array__Extensions with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeExtensionsObjectKHR_lights_punctualLights__array__ =
                    abstract __target__: bool with get, set
                    abstract color: IObjectAccessor<BABYLON.GLTF2.Loader.IKHRLightsPunctual_Light, Light, Color3> with get, set
                    abstract intensity: IObjectAccessor<BABYLON.GLTF2.Loader.IKHRLightsPunctual_Light, Light, float> with get, set
                    abstract range: IObjectAccessor<BABYLON.GLTF2.Loader.IKHRLightsPunctual_Light, Light, float> with get, set
                    abstract spot: {| innerConeAngle: IObjectAccessor<BABYLON.GLTF2.Loader.IKHRLightsPunctual_Light, Light, float>; outerConeAngle: IObjectAccessor<BABYLON.GLTF2.Loader.IKHRLightsPunctual_Light, Light, float> |} with get, set

                type [<AllowNullLiteral>] IGLTFObjectModelTreeExtensionsObjectEXT_lights_areaLights__array__ =
                    abstract __target__: bool with get, set
                    abstract color: IObjectAccessor<BABYLON.GLTF2.Loader.IEXTLightsArea_Light, Light, Color3> with get, set
                    abstract intensity: IObjectAccessor<BABYLON.GLTF2.Loader.IEXTLightsArea_Light, Light, float> with get, set
                    abstract size: IObjectAccessor<BABYLON.GLTF2.Loader.IEXTLightsArea_Light, Light, float> with get, set
                    abstract rect: {| aspect: IObjectAccessor<BABYLON.GLTF2.Loader.IEXTLightsArea_Light, Light, float> |} with get, set

                type [<AllowNullLiteral>] InteractivityGraphToFlowGraphParserArrays =
                    abstract types: ResizeArray<{| length: float; flowGraphType: FlowGraphTypes; elementType: IExportsGltfTypeToBabylonTypeItemElementType |}> with get, set
                    abstract mappings: ResizeArray<{| flowGraphMapping: BABYLON.GLTF2.Loader.Extensions.IGLTFToFlowGraphMapping; fullOperationName: string |}> with get, set
                    abstract staticVariables: ResizeArray<{| ``type``: FlowGraphTypes; value: ResizeArray<obj option> |}> with get, set
                    abstract events: ResizeArray<InteractivityEvent> with get, set
                    abstract nodes: ResizeArray<{| blocks: ResizeArray<ISerializedFlowGraphBlock>; fullOperationName: string |}> with get, set

                type [<AllowNullLiteral>] IGLTFToFlowGraphMappingInputsValues =
                    [<EmitIndexer>] abstract Item: originName: string -> IGLTFToFlowGraphMappingObject with get, set

                type [<AllowNullLiteral>] IGLTFToFlowGraphMappingInterBlockConnectors =
                    abstract input: string with get, set
                    abstract output: string with get, set
                    abstract inputBlockIndex: float with get, set
                    abstract outputBlockIndex: float with get, set
                    abstract isVariable: bool option with get, set

            type [<AllowNullLiteral>] IAccessor_babylonVertexBuffer =
                [<EmitIndexer>] abstract Item: kind: string -> Promise<VertexBuffer> with get, set

            type [<AllowNullLiteral>] IMaterial_data =
                [<EmitIndexer>] abstract Item: babylonDrawMode: float -> {| babylonMaterial: Material; babylonMeshes: ResizeArray<AbstractMesh>; promise: Promise<unit> |} with get, set

        type [<AllowNullLiteral>] IRegisteredGLTFExtension =
            abstract isGLTFExtension: bool with get, set
            abstract factory: GLTFExtensionFactory with get, set

        type [<AllowNullLiteral>] GLTFExtensionFactory =
            [<Emit("$0($1...)")>] abstract Invoke: loader: BABYLON.GLTF2.GLTFLoader -> U2<BABYLON.GLTF2.IGLTFLoaderExtension, Promise<BABYLON.GLTF2.IGLTFLoaderExtension>>

        type [<AllowNullLiteral>] IGLTFLoaderExtension =
            inherit BABYLON.IGLTFLoaderExtension
            inherit IDisposable
            abstract onLoading: unit -> unit
            abstract onReady: unit -> unit
            abstract loadSceneAsync: context: string * scene: BABYLON.GLTF2.Loader.IScene -> Nullable<Promise<unit>>
            abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * assign: (TransformNode -> unit) -> Nullable<Promise<TransformNode>>
            abstract loadCameraAsync: context: string * camera: BABYLON.GLTF2.Loader.ICamera * assign: (Camera -> unit) -> Nullable<Promise<Camera>>
            abstract _loadVertexDataAsync: context: string * primitive: BABYLON.GLTF2.Loader.IMeshPrimitive * babylonMesh: Mesh -> Nullable<Promise<Geometry>>
            abstract _loadMeshPrimitiveAsync: context: string * name: string * node: BABYLON.GLTF2.Loader.INode * mesh: BABYLON.GLTF2.Loader.IMesh * primitive: BABYLON.GLTF2.Loader.IMeshPrimitive * assign: (AbstractMesh -> unit) -> Nullable<Promise<AbstractMesh>>
            abstract _loadMaterialAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMesh: Nullable<Mesh> * babylonDrawMode: float * assign: (Material -> unit) -> Nullable<Promise<Material>>
            abstract createMaterial: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonDrawMode: float -> Nullable<Material>
            abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Nullable<Promise<unit>>
            abstract loadTextureInfoAsync: context: string * textureInfo: BABYLON.GLTF2.Loader.ITextureInfo * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>
            abstract _loadTextureAsync: context: string * texture: BABYLON.GLTF2.Loader.ITexture * assign: (BaseTexture -> unit) -> Nullable<Promise<BaseTexture>>
            abstract loadAnimationAsync: context: string * animation: BABYLON.GLTF2.Loader.IAnimation -> Nullable<Promise<AnimationGroup>>
            abstract _loadAnimationChannelAsync: context: string * animationContext: string * animation: BABYLON.GLTF2.Loader.IAnimation * channel: BABYLON.GLTF2.Loader.IAnimationChannel * onLoad: (IAnimatable -> Animation -> unit) -> Nullable<Promise<unit>>
            abstract _loadSkinAsync: context: string * node: BABYLON.GLTF2.Loader.INode * skin: BABYLON.GLTF2.Loader.ISkin -> Nullable<Promise<unit>>
            abstract _loadUriAsync: context: string * property: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IProperty * uri: string -> Nullable<Promise<ArrayBufferView>>
            abstract loadBufferViewAsync: context: string * bufferView: BABYLON.GLTF2.Loader.IBufferView -> Nullable<Promise<ArrayBufferView>>
            abstract loadBufferAsync: context: string * buffer: BABYLON.GLTF2.Loader.IBuffer * byteOffset: float * byteLength: float -> Nullable<Promise<ArrayBufferView>>

        type [<AllowNullLiteral>] GetValueFn =
            [<Emit("$0($1...)")>] abstract Invoke: target: obj option * source: Float32Array * offset: float * scale: float -> obj option

        type [<AllowNullLiteral>] AnimationPropertyInfo =
            abstract ``type``: float
            abstract name: string
            abstract getValue: GetValueFn
            abstract getStride: obj option -> float
            abstract _buildAnimation: name: string * fps: float * keys: ResizeArray<obj option> -> Animation
            abstract buildAnimations: target: obj option * name: string * fps: float * keys: ResizeArray<obj option> -> ResizeArray<{| babylonAnimatable: IAnimatable; babylonAnimation: Animation |}>

        type [<AllowNullLiteral>] AnimationPropertyInfoStatic =
            [<EmitConstructor>] abstract Create: ``type``: float * name: string * getValue: GetValueFn * getStride: (obj option -> float) -> AnimationPropertyInfo

        type [<AllowNullLiteral>] TransformNodeAnimationPropertyInfo =
            inherit AnimationPropertyInfo
            abstract buildAnimations: target: BABYLON.GLTF2.Loader.INode * name: string * fps: float * keys: ResizeArray<obj option> -> ResizeArray<{| babylonAnimatable: IAnimatable; babylonAnimation: Animation |}>

        type [<AllowNullLiteral>] TransformNodeAnimationPropertyInfoStatic =
            [<EmitConstructor>] abstract Create: ``type``: float * name: string * getValue: GetValueFn * getStride: (obj option -> float) -> TransformNodeAnimationPropertyInfo

        type [<AllowNullLiteral>] WeightAnimationPropertyInfo =
            inherit AnimationPropertyInfo
            abstract buildAnimations: target: BABYLON.GLTF2.Loader.INode * name: string * fps: float * keys: ResizeArray<obj option> -> ResizeArray<{| babylonAnimatable: IAnimatable; babylonAnimation: Animation |}>

        type [<AllowNullLiteral>] WeightAnimationPropertyInfoStatic =
            [<EmitConstructor>] abstract Create: ``type``: float * name: string * getValue: GetValueFn * getStride: (obj option -> float) -> WeightAnimationPropertyInfo

        type [<AllowNullLiteral>] IWithMetadata =
            abstract metadata: obj option with get, set
            abstract _internalMetadata: obj option with get, set

        type [<AllowNullLiteral>] ArrayItem =
            interface end

        type [<AllowNullLiteral>] ArrayItemStatic =
            [<EmitConstructor>] abstract Create: unit -> ArrayItem
            abstract Get: context: string * array: ArrayLike<'T> option * index: float option -> 'T
            abstract TryGet: array: ArrayLike<'T> option * index: float option -> Nullable<'T>
            abstract Assign: ?array: ResizeArray<BABYLON.GLTF2.Loader.IArrayItem> -> unit

        type [<AllowNullLiteral>] IAnimationTargetInfo =
            abstract target: obj with get, set
            abstract properties: Array<BABYLON.GLTF2.AnimationPropertyInfo> with get, set

        type [<AllowNullLiteral>] PBRMaterialImplementation =
            abstract materialClass: obj with get, set
            abstract adapterClass: obj with get, set

        type [<AllowNullLiteral>] GLTFLoader =
            inherit IGLTFLoader
            abstract _completePromises: ResizeArray<Promise<obj>>
            abstract _assetContainer: Nullable<AssetContainer> with get, set
            abstract _babylonLights: ResizeArray<Light> with get, set
            abstract _disableInstancedMesh: float with get, set
            abstract _allMaterialsDirtyRequired: bool with get, set
            abstract _skipStartAnimationStep: bool with get, set
            abstract _disposed: bool with get, set
            abstract _pbrMaterialImpls: Map<string, obj>
            abstract isMatchingMaterialType: material: Nullable<Material> -> bool
            abstract gltf: BABYLON.GLTF2.Loader.IGLTF
            abstract bin: Nullable<IDataBuffer>
            abstract parent: GLTFFileLoader
            abstract babylonScene: Scene
            abstract rootBabylonMesh: Nullable<TransformNode>
            abstract rootUrl: Nullable<string>
            abstract _getOrCreateMaterialAdapter: material: Material -> BABYLON.GLTF2.IMaterialLoadingAdapter
            abstract dispose: unit -> unit
            abstract importMeshAsync: meshesNames: U2<string, ResizeArray<string>> option * scene: Scene * container: Nullable<AssetContainer> * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<ISceneLoaderAsyncResult>
            abstract loadAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) * ?fileName: string -> Promise<unit>
            abstract loadSceneAsync: context: string * scene: BABYLON.GLTF2.Loader.IScene -> Promise<unit>
            abstract loadNodeAsync: context: string * node: BABYLON.GLTF2.Loader.INode * ?assign: (TransformNode -> unit) -> Promise<TransformNode>
            abstract _loadMeshPrimitiveAsync: context: string * name: string * node: BABYLON.GLTF2.Loader.INode * mesh: BABYLON.GLTF2.Loader.IMesh * primitive: BABYLON.GLTF2.Loader.IMeshPrimitive * assign: (AbstractMesh -> unit) -> Promise<AbstractMesh>
            abstract loadCameraAsync: context: string * camera: BABYLON.GLTF2.Loader.ICamera * ?assign: (Camera -> unit) -> Promise<Camera>
            abstract loadAnimationAsync: context: string * animation: BABYLON.GLTF2.Loader.IAnimation -> Promise<AnimationGroup>
            abstract _loadAnimationChannelAsync: context: string * animationContext: string * animation: BABYLON.GLTF2.Loader.IAnimation * channel: BABYLON.GLTF2.Loader.IAnimationChannel * onLoad: (IAnimatable -> Animation -> unit) -> Promise<unit>
            abstract _loadAnimationChannelFromTargetInfoAsync: context: string * animationContext: string * animation: BABYLON.GLTF2.Loader.IAnimation * channel: BABYLON.GLTF2.Loader.IAnimationChannel * targetInfo: IObjectInfo<ResizeArray<IInterpolationPropertyInfo>> * onLoad: (IAnimatable -> Animation -> unit) -> Promise<unit>
            abstract loadBufferAsync: context: string * buffer: BABYLON.GLTF2.Loader.IBuffer * byteOffset: float * byteLength: float -> Promise<ArrayBufferView>
            abstract loadBufferViewAsync: context: string * bufferView: BABYLON.GLTF2.Loader.IBufferView -> Promise<ArrayBufferView>
            abstract _loadFloatAccessorAsync: context: string * accessor: BABYLON.GLTF2.Loader.IAccessor -> Promise<Float32Array>
            abstract _loadIndicesAccessorAsync: context: string * accessor: BABYLON.GLTF2.Loader.IAccessor -> Promise<IndicesArray>
            abstract _loadVertexBufferViewAsync: bufferView: BABYLON.GLTF2.Loader.IBufferView -> Promise<Buffer>
            abstract _loadVertexAccessorAsync: context: string * accessor: BABYLON.GLTF2.Loader.IAccessor * kind: string -> Promise<VertexBuffer>
            abstract _loadMaterialAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMesh: Nullable<Mesh> * babylonDrawMode: float * ?assign: (Material -> unit) -> Promise<Material>
            abstract createMaterial: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonDrawMode: float -> Material
            abstract loadMaterialPropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Promise<unit>
            abstract loadMaterialBasePropertiesAsync: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> Promise<unit>
            abstract loadMaterialAlphaProperties: context: string * material: BABYLON.GLTF2.Loader.IMaterial * babylonMaterial: Material -> unit
            abstract loadTextureInfoAsync: context: string * textureInfo: BABYLON.GLTF2.Loader.ITextureInfo * ?assign: (BaseTexture -> unit) -> Promise<BaseTexture>
            abstract _loadTextureAsync: context: string * texture: BABYLON.GLTF2.Loader.ITexture * ?assign: (BaseTexture -> unit) -> Promise<BaseTexture>
            abstract _createTextureAsync: context: string * sampler: BABYLON.GLTF2.Loader.ISampler * image: BABYLON.GLTF2.Loader.IImage * ?assign: (BaseTexture -> unit) * ?textureLoaderOptions: obj * ?useSRGBBuffer: bool -> Promise<BaseTexture>
            abstract loadImageAsync: context: string * image: BABYLON.GLTF2.Loader.IImage -> Promise<ArrayBufferView>
            abstract loadUriAsync: context: string * property: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IProperty * uri: string -> Promise<ArrayBufferView>
            abstract isExtensionUsed: name: string -> bool
            abstract logOpen: message: string -> unit
            abstract logClose: unit -> unit
            abstract log: message: string -> unit
            abstract startPerformanceCounter: counterName: string -> unit
            abstract endPerformanceCounter: counterName: string -> unit

        type [<AllowNullLiteral>] GLTFLoaderStatic =
            abstract DefaultSampler: BABYLON.GLTF2.Loader.ISampler
            abstract RegisterExtension: name: string * factory: BABYLON.GLTF2.GLTFExtensionFactory -> unit
            abstract UnregisterExtension: name: string -> bool
            [<EmitConstructor>] abstract Create: parent: GLTFFileLoader -> GLTFLoader
            abstract AddPointerMetadata: babylonObject: IWithMetadata * pointer: string -> unit
            abstract _GetDrawMode: context: string * mode: float option -> float
            abstract LoadExtensionAsync: context: string * property: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IProperty * extensionName: string * actionAsync: (string -> 'TExtension -> Nullable<Promise<'TResult>>) -> Nullable<Promise<'TResult>>
            abstract LoadExtraAsync: context: string * property: BabylonjsBindings.FullGltf2InterfaceCandidate.BABYLON.GLTF2.IProperty * extensionName: string * actionAsync: (string -> 'TExtra -> Nullable<Promise<'TResult>>) -> Nullable<Promise<'TResult>>

    type [<AllowNullLiteral>] MaterialVariantsController =
        abstract variants: ResizeArray<string>
        abstract selectedVariant: string with get, set

    module GLTF1 =

        type [<AllowNullLiteral>] IExports =
            abstract GLTFMaterialsCommonExtension: GLTFMaterialsCommonExtensionStatic
            abstract GLTFUtils: GLTFUtilsStatic
            abstract GLTFLoaderBase: GLTFLoaderBaseStatic
            abstract GLTFLoader: GLTFLoaderStatic
            abstract GLTFLoaderExtension: GLTFLoaderExtensionStatic
            abstract GLTFBinaryExtension: GLTFBinaryExtensionStatic

        type [<AllowNullLiteral>] GLTFMaterialsCommonExtension =
            inherit BABYLON.GLTF1.GLTFLoaderExtension
            abstract loadRuntimeExtensionsAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime -> bool
            abstract loadMaterialAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (Material -> unit) * onError: (string -> unit) -> bool

        type [<AllowNullLiteral>] GLTFMaterialsCommonExtensionStatic =
            [<EmitConstructor>] abstract Create: unit -> GLTFMaterialsCommonExtension

        type [<AllowNullLiteral>] GLTFUtils =
            interface end

        type [<AllowNullLiteral>] GLTFUtilsStatic =
            [<EmitConstructor>] abstract Create: unit -> GLTFUtils
            abstract SetMatrix: scene: Scene * source: Node * parameter: BABYLON.GLTF1.IGLTFTechniqueParameter * uniformName: string * shaderMaterial: U2<ShaderMaterial, Effect> -> unit
            abstract SetUniform: shaderMaterial: U2<ShaderMaterial, Effect> * uniform: string * value: obj option * ``type``: float -> bool
            abstract GetWrapMode: mode: float -> float
            abstract GetByteStrideFromType: accessor: BABYLON.GLTF1.IGLTFAccessor -> float
            abstract GetTextureFilterMode: mode: float -> float
            abstract GetBufferFromBufferView: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * bufferView: BABYLON.GLTF1.IGLTFBufferView * byteOffset: float * byteLength: float * componentType: BABYLON.GLTF1.EComponentType -> ArrayBufferView
            abstract GetBufferFromAccessor: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * accessor: BABYLON.GLTF1.IGLTFAccessor -> obj option
            abstract DecodeBufferToText: view: ArrayBufferView -> string
            abstract GetDefaultMaterial: scene: Scene -> ShaderMaterial

        type EComponentType =
            | BYTE = 5120
            | UNSIGNED_BYTE = 5121
            | SHORT = 5122
            | UNSIGNED_SHORT = 5123
            | FLOAT = 5126

        type EShaderType =
            | FRAGMENT = 35632
            | VERTEX = 35633

        type EParameterType =
            | BYTE = 5120
            | UNSIGNED_BYTE = 5121
            | SHORT = 5122
            | UNSIGNED_SHORT = 5123
            | INT = 5124
            | UNSIGNED_INT = 5125
            | FLOAT = 5126
            | FLOAT_VEC2 = 35664
            | FLOAT_VEC3 = 35665
            | FLOAT_VEC4 = 35666
            | INT_VEC2 = 35667
            | INT_VEC3 = 35668
            | INT_VEC4 = 35669
            | BOOL = 35670
            | BOOL_VEC2 = 35671
            | BOOL_VEC3 = 35672
            | BOOL_VEC4 = 35673
            | FLOAT_MAT2 = 35674
            | FLOAT_MAT3 = 35675
            | FLOAT_MAT4 = 35676
            | SAMPLER_2D = 35678

        type ETextureWrapMode =
            | CLAMP_TO_EDGE = 33071
            | MIRRORED_REPEAT = 33648
            | REPEAT = 10497

        type ETextureFilterType =
            | NEAREST = 9728
            | LINEAR = 9728
            | NEAREST_MIPMAP_NEAREST = 9984
            | LINEAR_MIPMAP_NEAREST = 9985
            | NEAREST_MIPMAP_LINEAR = 9986
            | LINEAR_MIPMAP_LINEAR = 9987

        type ETextureFormat =
            | ALPHA = 6406
            | RGB = 6407
            | RGBA = 6408
            | LUMINANCE = 6409
            | LUMINANCE_ALPHA = 6410

        type ECullingType =
            | FRONT = 1028
            | BACK = 1029
            | FRONT_AND_BACK = 1032

        type EBlendingFunction =
            | ZERO = 0
            | ONE = 1
            | SRC_COLOR = 768
            | ONE_MINUS_SRC_COLOR = 769
            | DST_COLOR = 774
            | ONE_MINUS_DST_COLOR = 775
            | SRC_ALPHA = 770
            | ONE_MINUS_SRC_ALPHA = 771
            | DST_ALPHA = 772
            | ONE_MINUS_DST_ALPHA = 773
            | CONSTANT_COLOR = 32769
            | ONE_MINUS_CONSTANT_COLOR = 32770
            | CONSTANT_ALPHA = 32771
            | ONE_MINUS_CONSTANT_ALPHA = 32772
            | SRC_ALPHA_SATURATE = 776

        type [<AllowNullLiteral>] IGLTFProperty =
            abstract extensions: IGLTFPropertyExtensions option with get, set
            abstract extras: obj option with get, set

        type [<AllowNullLiteral>] IGLTFChildRootProperty =
            inherit IGLTFProperty
            abstract name: string option with get, set

        type [<AllowNullLiteral>] IGLTFAccessor =
            inherit IGLTFChildRootProperty
            abstract bufferView: string with get, set
            abstract byteOffset: float with get, set
            abstract byteStride: float with get, set
            abstract count: float with get, set
            abstract ``type``: string with get, set
            abstract componentType: EComponentType with get, set
            abstract max: ResizeArray<float> option with get, set
            abstract min: ResizeArray<float> option with get, set
            abstract name: string option with get, set

        type [<AllowNullLiteral>] IGLTFBufferView =
            inherit IGLTFChildRootProperty
            abstract buffer: string with get, set
            abstract byteOffset: float with get, set
            abstract byteLength: float with get, set
            abstract byteStride: float with get, set
            abstract target: float option with get, set

        type [<AllowNullLiteral>] IGLTFBuffer =
            inherit IGLTFChildRootProperty
            abstract uri: string with get, set
            abstract byteLength: float option with get, set
            abstract ``type``: string option with get, set

        type [<AllowNullLiteral>] IGLTFShader =
            inherit IGLTFChildRootProperty
            abstract uri: string with get, set
            abstract ``type``: EShaderType with get, set

        type [<AllowNullLiteral>] IGLTFProgram =
            inherit IGLTFChildRootProperty
            abstract attributes: ResizeArray<string> with get, set
            abstract fragmentShader: string with get, set
            abstract vertexShader: string with get, set

        type [<AllowNullLiteral>] IGLTFTechniqueParameter =
            abstract ``type``: float with get, set
            abstract count: float option with get, set
            abstract semantic: string option with get, set
            abstract node: string option with get, set
            abstract value: U4<float, bool, string, Array<obj option>> option with get, set
            abstract source: string option with get, set
            abstract babylonValue: obj option with get, set

        type [<AllowNullLiteral>] IGLTFTechniqueCommonProfile =
            abstract lightingModel: string with get, set
            abstract texcoordBindings: obj with get, set
            abstract parameters: Array<obj option> option with get, set

        type [<AllowNullLiteral>] IGLTFTechniqueStatesFunctions =
            abstract blendColor: ResizeArray<float> option with get, set
            abstract blendEquationSeparate: ResizeArray<float> option with get, set
            abstract blendFuncSeparate: ResizeArray<float> option with get, set
            abstract colorMask: ResizeArray<bool> with get, set
            abstract cullFace: ResizeArray<float> with get, set

        type [<AllowNullLiteral>] IGLTFTechniqueStates =
            abstract enable: ResizeArray<float> with get, set
            abstract functions: IGLTFTechniqueStatesFunctions with get, set

        type [<AllowNullLiteral>] IGLTFTechnique =
            inherit IGLTFChildRootProperty
            abstract parameters: IGLTFTechniqueParameters with get, set
            abstract program: string with get, set
            abstract attributes: IGLTFTechniqueAttributes with get, set
            abstract uniforms: IGLTFTechniqueAttributes with get, set
            abstract states: IGLTFTechniqueStates with get, set

        type [<AllowNullLiteral>] IGLTFMaterial =
            inherit IGLTFChildRootProperty
            abstract technique: string option with get, set
            abstract values: ResizeArray<string> with get, set

        type [<AllowNullLiteral>] IGLTFMeshPrimitive =
            inherit IGLTFProperty
            abstract attributes: IGLTFTechniqueAttributes with get, set
            abstract indices: string with get, set
            abstract material: string with get, set
            abstract mode: float option with get, set

        type [<AllowNullLiteral>] IGLTFMesh =
            inherit IGLTFChildRootProperty
            abstract primitives: ResizeArray<IGLTFMeshPrimitive> with get, set

        type [<AllowNullLiteral>] IGLTFImage =
            inherit IGLTFChildRootProperty
            abstract uri: string with get, set

        type [<AllowNullLiteral>] IGLTFSampler =
            inherit IGLTFChildRootProperty
            abstract magFilter: float option with get, set
            abstract minFilter: float option with get, set
            abstract wrapS: float option with get, set
            abstract wrapT: float option with get, set

        type [<AllowNullLiteral>] IGLTFTexture =
            inherit IGLTFChildRootProperty
            abstract sampler: string with get, set
            abstract source: string with get, set
            abstract format: ETextureFormat option with get, set
            abstract internalFormat: ETextureFormat option with get, set
            abstract target: float option with get, set
            abstract ``type``: float option with get, set
            abstract babylonTexture: Texture option with get, set

        type [<AllowNullLiteral>] IGLTFAmbienLight =
            abstract color: ResizeArray<float> option with get, set

        type [<AllowNullLiteral>] IGLTFDirectionalLight =
            abstract color: ResizeArray<float> option with get, set

        type [<AllowNullLiteral>] IGLTFPointLight =
            abstract color: ResizeArray<float> option with get, set
            abstract constantAttenuation: float option with get, set
            abstract linearAttenuation: float option with get, set
            abstract quadraticAttenuation: float option with get, set

        type [<AllowNullLiteral>] IGLTFSpotLight =
            abstract color: ResizeArray<float> option with get, set
            abstract constantAttenuation: float option with get, set
            abstract fallOfAngle: float option with get, set
            abstract fallOffExponent: float option with get, set
            abstract linearAttenuation: float option with get, set
            abstract quadraticAttenuation: float option with get, set

        type [<AllowNullLiteral>] IGLTFLight =
            inherit IGLTFChildRootProperty
            abstract ``type``: string with get, set

        type [<AllowNullLiteral>] IGLTFCameraOrthographic =
            abstract xmag: float with get, set
            abstract ymag: float with get, set
            abstract zfar: float with get, set
            abstract znear: float with get, set

        type [<AllowNullLiteral>] IGLTFCameraPerspective =
            abstract aspectRatio: float with get, set
            abstract yfov: float with get, set
            abstract zfar: float with get, set
            abstract znear: float with get, set

        type [<AllowNullLiteral>] IGLTFCamera =
            inherit IGLTFChildRootProperty
            abstract ``type``: string with get, set

        type [<AllowNullLiteral>] IGLTFAnimationChannelTarget =
            abstract id: string with get, set
            abstract path: string with get, set

        type [<AllowNullLiteral>] IGLTFAnimationChannel =
            abstract sampler: string with get, set
            abstract target: IGLTFAnimationChannelTarget with get, set

        type [<AllowNullLiteral>] IGLTFAnimationSampler =
            abstract input: string with get, set
            abstract output: string with get, set
            abstract interpolation: string option with get, set

        type [<AllowNullLiteral>] IGLTFAnimation =
            inherit IGLTFChildRootProperty
            abstract channels: ResizeArray<IGLTFAnimationChannel> option with get, set
            abstract parameters: IGLTFTechniqueAttributes option with get, set
            abstract samplers: IGLTFAnimationSamplers option with get, set

        type [<AllowNullLiteral>] IGLTFNodeInstanceSkin =
            abstract skeletons: ResizeArray<string> with get, set
            abstract skin: string with get, set
            abstract meshes: ResizeArray<string> with get, set

        type [<AllowNullLiteral>] IGLTFSkins =
            inherit IGLTFChildRootProperty
            abstract bindShapeMatrix: ResizeArray<float> with get, set
            abstract inverseBindMatrices: string with get, set
            abstract jointNames: ResizeArray<string> with get, set
            abstract babylonSkeleton: Skeleton option with get, set

        type [<AllowNullLiteral>] IGLTFNode =
            inherit IGLTFChildRootProperty
            abstract camera: string option with get, set
            abstract children: ResizeArray<string> with get, set
            abstract skin: string option with get, set
            abstract jointName: string option with get, set
            abstract light: string option with get, set
            abstract matrix: ResizeArray<float> with get, set
            abstract mesh: string option with get, set
            abstract meshes: ResizeArray<string> option with get, set
            abstract rotation: ResizeArray<float> option with get, set
            abstract scale: ResizeArray<float> option with get, set
            abstract translation: ResizeArray<float> option with get, set
            abstract babylonNode: Node option with get, set

        type [<AllowNullLiteral>] IGLTFScene =
            inherit IGLTFChildRootProperty
            abstract nodes: ResizeArray<string> with get, set

        type [<AllowNullLiteral>] IGLTFRuntime =
            abstract extensions: IGLTFPropertyExtensions with get, set
            abstract accessors: IGLTFRuntimeAccessors with get, set
            abstract buffers: IGLTFRuntimeBuffers with get, set
            abstract bufferViews: IGLTFRuntimeBufferViews with get, set
            abstract meshes: IGLTFRuntimeMeshes with get, set
            abstract lights: IGLTFRuntimeLights with get, set
            abstract cameras: IGLTFRuntimeCameras with get, set
            abstract nodes: IGLTFRuntimeNodes with get, set
            abstract images: IGLTFRuntimeImages with get, set
            abstract textures: IGLTFRuntimeTextures with get, set
            abstract shaders: IGLTFRuntimeShaders with get, set
            abstract programs: IGLTFRuntimePrograms with get, set
            abstract samplers: IGLTFRuntimeSamplers with get, set
            abstract techniques: IGLTFRuntimeTechniques with get, set
            abstract materials: IGLTFRuntimeMaterials with get, set
            abstract animations: IGLTFRuntimeAnimations with get, set
            abstract skins: IGLTFRuntimeSkins with get, set
            abstract currentScene: obj option with get, set
            abstract scenes: IGLTFRuntimeScenes with get, set
            abstract extensionsUsed: ResizeArray<string> with get, set
            abstract extensionsRequired: ResizeArray<string> option with get, set
            abstract buffersCount: float with get, set
            abstract shaderscount: float with get, set
            abstract scene: Scene with get, set
            abstract rootUrl: string with get, set
            abstract loadedBufferCount: float with get, set
            abstract loadedBufferViews: IGLTFRuntimeLoadedBufferViews with get, set
            abstract loadedShaderCount: float with get, set
            abstract importOnlyMeshes: bool with get, set
            abstract importMeshesNames: ResizeArray<string> option with get, set
            abstract dummyNodes: ResizeArray<Node> with get, set
            abstract assetContainer: Nullable<AssetContainer> with get, set

        type [<AllowNullLiteral>] INodeToRoot =
            abstract bone: Bone with get, set
            abstract node: IGLTFNode with get, set
            abstract id: string with get, set

        type [<AllowNullLiteral>] IJointNode =
            abstract node: IGLTFNode with get, set
            abstract id: string with get, set

        type [<AllowNullLiteral>] GLTFLoaderBase =
            interface end

        type [<AllowNullLiteral>] GLTFLoaderBaseStatic =
            [<EmitConstructor>] abstract Create: unit -> GLTFLoaderBase
            abstract CreateRuntime: parsedData: obj option * scene: Scene * rootUrl: string -> BABYLON.GLTF1.IGLTFRuntime
            abstract LoadBufferAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) * ?onProgress: (unit -> unit) -> unit
            abstract LoadTextureBufferAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (Nullable<ArrayBufferView> -> unit) * onError: (string -> unit) -> unit
            abstract CreateTextureAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * buffer: Nullable<ArrayBufferView> * onSuccess: (Texture -> unit) -> unit
            abstract LoadShaderStringAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (U2<string, ArrayBuffer> -> unit) * ?onError: (string -> unit) -> unit
            abstract LoadMaterialAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (Material -> unit) * onError: (string -> unit) -> unit

        type [<AllowNullLiteral>] GLTFLoader =
            inherit IGLTFLoader
            abstract dispose: unit -> unit
            abstract importMeshAsync: meshesNames: obj option * scene: Scene * assetContainer: Nullable<AssetContainer> * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) -> Promise<ISceneLoaderAsyncResult>
            abstract loadAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onProgress: (ISceneLoaderProgressEvent -> unit) -> Promise<unit>

        type [<AllowNullLiteral>] GLTFLoaderStatic =
            [<EmitConstructor>] abstract Create: unit -> GLTFLoader
            abstract Extensions: GLTFLoaderStaticExtensions with get, set
            abstract RegisterExtension: extension: GLTFLoaderExtension -> unit

        type [<AllowNullLiteral>] GLTFLoaderExtension =
            abstract name: string
            abstract loadRuntimeAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onSuccess: (BABYLON.GLTF1.IGLTFRuntime -> unit) * ?onError: (string -> unit) -> bool
            abstract loadRuntimeExtensionsAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * onSuccess: (unit -> unit) * ?onError: (string -> unit) -> bool
            abstract loadBufferAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) * ?onProgress: (unit -> unit) -> bool
            abstract loadTextureBufferAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) -> bool
            abstract createTextureAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * buffer: ArrayBufferView * onSuccess: (Texture -> unit) * onError: (string -> unit) -> bool
            abstract loadShaderStringAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (string -> unit) * onError: (string -> unit) -> bool
            abstract loadMaterialAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (Material -> unit) * onError: (string -> unit) -> bool

        type [<AllowNullLiteral>] GLTFLoaderExtensionStatic =
            [<EmitConstructor>] abstract Create: name: string -> GLTFLoaderExtension
            abstract LoadRuntimeAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * ?onSuccess: (BABYLON.GLTF1.IGLTFRuntime -> unit) * ?onError: (string -> unit) -> unit
            abstract LoadRuntimeExtensionsAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * onSuccess: (unit -> unit) * ?onError: (string -> unit) -> unit
            abstract LoadBufferAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) * ?onProgress: (unit -> unit) -> unit
            abstract LoadTextureAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (Texture -> unit) * onError: (string -> unit) -> unit
            abstract LoadShaderStringAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (U2<string, ArrayBuffer> -> unit) * onError: (string -> unit) -> unit
            abstract LoadMaterialAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (Material -> unit) * onError: (string -> unit) -> unit

        type [<AllowNullLiteral>] GLTFBinaryExtension =
            inherit BABYLON.GLTF1.GLTFLoaderExtension
            abstract loadRuntimeAsync: scene: Scene * data: IGLTFLoaderData * rootUrl: string * onSuccess: (BABYLON.GLTF1.IGLTFRuntime -> unit) -> bool
            abstract loadBufferAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) * onError: (string -> unit) -> bool
            abstract loadTextureBufferAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (ArrayBufferView -> unit) -> bool
            abstract loadShaderStringAsync: gltfRuntime: BABYLON.GLTF1.IGLTFRuntime * id: string * onSuccess: (string -> unit) -> bool

        type [<AllowNullLiteral>] GLTFBinaryExtensionStatic =
            [<EmitConstructor>] abstract Create: unit -> GLTFBinaryExtension

        type [<AllowNullLiteral>] IGLTFPropertyExtensions =
            [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

        type [<AllowNullLiteral>] IGLTFTechniqueParameters =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFTechniqueParameter with get, set

        type [<AllowNullLiteral>] IGLTFTechniqueAttributes =
            [<EmitIndexer>] abstract Item: key: string -> string with get, set

        type [<AllowNullLiteral>] IGLTFAnimationSamplers =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFAnimationSampler with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeAccessors =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFAccessor with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeBuffers =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFBuffer with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeBufferViews =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFBufferView with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeMeshes =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFMesh with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeLights =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFLight with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeCameras =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFCamera with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeNodes =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFNode with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeImages =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFImage with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeTextures =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFTexture with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeShaders =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFShader with get, set

        type [<AllowNullLiteral>] IGLTFRuntimePrograms =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFProgram with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeSamplers =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFSampler with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeTechniques =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFTechnique with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeMaterials =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFMaterial with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeAnimations =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFAnimation with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeSkins =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFSkins with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeScenes =
            [<EmitIndexer>] abstract Item: key: string -> IGLTFScene with get, set

        type [<AllowNullLiteral>] IGLTFRuntimeLoadedBufferViews =
            [<EmitIndexer>] abstract Item: name: string -> ArrayBufferView with get, set

        type [<AllowNullLiteral>] GLTFLoaderStaticExtensions =
            [<EmitIndexer>] abstract Item: name: string -> GLTFLoaderExtension with get, set

    type [<AllowNullLiteral>] STLFileLoader =
        inherit ISceneLoaderPlugin
        abstract solidPattern: RegExp with get, set
        abstract facetsPattern: RegExp with get, set
        abstract normalPattern: RegExp with get, set
        abstract vertexPattern: RegExp with get, set
        abstract name: string
        abstract extensions: {| ``.stl``: {| isBinary: bool |} |}
        abstract importMesh: meshesNames: obj option * scene: Scene * data: obj option * rootUrl: string * meshes: Nullable<ResizeArray<AbstractMesh>> -> bool
        abstract load: scene: Scene * data: obj option * rootUrl: string -> bool
        abstract loadAssetContainer: scene: Scene * data: string * rootUrl: string -> AssetContainer

    type [<AllowNullLiteral>] STLFileLoaderStatic =
        [<EmitConstructor>] abstract Create: unit -> STLFileLoader
        abstract DO_NOT_ALTER_FILE_COORDINATES: bool with get, set

    type [<AllowNullLiteral>] SPLATLoadingOptions =
        abstract keepInRam: bool option with get, set
        abstract flipY: bool option with get, set
        abstract deflateURL: string option with get, set
        abstract fflate: obj option with get, set
        abstract disableAutoCameraLimits: bool option with get, set
        abstract gaussianSplattingMesh: GaussianSplattingMesh option with get, set
        abstract needsRotationScaleTextures: bool option with get, set
        abstract useSogTextures: bool option with get, set
        abstract spzLibraryUrl: string option with get, set

    type [<AllowNullLiteral>] SPLATFileLoader =
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract name: string
        abstract extensions: IExportsSPLATFileLoaderMetadataExtensions
        abstract createPlugin: options: SceneLoaderPluginOptions -> ISceneLoaderPluginAsync
        abstract importMeshAsync: meshesNames: obj option * scene: Scene * data: obj option * rootUrl: string * ?_onProgress: (ISceneLoaderProgressEvent -> unit) * ?_fileName: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAssetContainerAsync: scene: Scene * data: string * rootUrl: string -> Promise<AssetContainer>
        abstract loadAsync: scene: Scene * data: string * rootUrl: string -> Promise<unit>

    type [<AllowNullLiteral>] SPLATFileLoaderStatic =
        [<EmitConstructor>] abstract Create: ?loadingOptions: obj -> SPLATFileLoader

    type Mode =
        | Splat = 0
        | PointCloud = 1
        | Mesh = 2
        | Reject = 3

    type [<AllowNullLiteral>] ISogTexturePack =
        abstract version: ISogTexturePackVersion with get, set
        abstract splatCount: float with get, set
        abstract shDegree: float with get, set
        abstract meansTextureL: BaseTexture with get, set
        abstract meansTextureU: BaseTexture with get, set
        abstract scalesTexture: BaseTexture with get, set
        abstract quatsTexture: BaseTexture with get, set
        abstract sh0Texture: BaseTexture with get, set
        abstract shCentroidsTexture: BaseTexture option with get, set
        abstract shLabelsTexture: BaseTexture option with get, set
        abstract codebookTexture: BaseTexture option with get, set
        abstract meansMin: float * float * float with get, set
        abstract meansMax: float * float * float with get, set
        abstract scalesMin: (float * float * float) option with get, set
        abstract scalesMax: (float * float * float) option with get, set
        abstract sh0Min: (float * float * float * float) option with get, set
        abstract sh0Max: (float * float * float * float) option with get, set
        abstract shnMin: float option with get, set
        abstract shnMax: float option with get, set
        abstract shCoeffCount: float with get, set
        abstract positions: Float32Array with get, set

    type [<AllowNullLiteral>] IParsedSplat =
        abstract data: ArrayBuffer with get, set
        abstract mode: Mode with get, set
        abstract faces: ResizeArray<float> option with get, set
        abstract hasVertexColors: bool option with get, set
        abstract sh: ResizeArray<Uint8Array> option with get, set
        abstract shDegree: float option with get, set
        abstract trainedWithAntialiasing: bool option with get, set
        abstract compressed: bool option with get, set
        abstract rawSplat: bool option with get, set
        abstract safeOrbitCameraRadiusMin: float option with get, set
        abstract safeOrbitCameraElevationMinMax: (float * float) option with get, set
        abstract upAxis: IParsedSplatUpAxis option with get, set
        abstract chirality: IParsedSplatChirality option with get, set
        abstract sogTextures: ISogTexturePack option with get, set

    type [<AllowNullLiteral>] SOGDataFile =
        abstract shape: ResizeArray<float> with get, set
        abstract dtype: string with get, set
        abstract mins: U2<float, ResizeArray<float>> option with get, set
        abstract maxs: U2<float, ResizeArray<float>> option with get, set
        abstract codebook: ResizeArray<float> option with get, set
        abstract encoding: string option with get, set
        abstract quantization: float option with get, set
        abstract files: ResizeArray<string> with get, set
        abstract bands: float option with get, set

    type [<AllowNullLiteral>] SOGRootData =
        abstract version: float option with get, set
        abstract means: SOGDataFile with get, set
        abstract scales: SOGDataFile with get, set
        abstract quats: SOGDataFile with get, set
        abstract sh0: SOGDataFile with get, set
        abstract shN: SOGDataFile option with get, set
        abstract count: float option with get, set

    type [<AllowNullLiteral>] GaussianSplattingWorkBuffer =
        abstract supportsAsyncCentersReadback: bool
        abstract textureSize: float
        abstract textures: ResizeArray<Texture>
        abstract decodeAsync: pack: ISogTexturePack * offset: float -> Promise<unit>
        abstract isRelayoutReady: unit -> bool
        abstract relayoutSync: srcIndexByDst: Float32Array -> unit
        abstract readCentersRangeAsync: splatOffset: float * splatCount: float -> Promise<Nullable<Float32Array>>
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] GaussianSplattingWorkBufferStatic =
        [<EmitConstructor>] abstract Create: scene: Scene * capacity: float -> GaussianSplattingWorkBuffer

    type [<AllowNullLiteral>] ISOGLODEntry =
        abstract file: float with get, set
        abstract offset: float with get, set
        abstract count: float with get, set

    type [<AllowNullLiteral>] ISOGLODNode =
        abstract bound: {| min: ResizeArray<float>; max: ResizeArray<float> |} with get, set
        abstract children: ResizeArray<ISOGLODNode> option with get, set
        abstract lods: ISOGLODNodeLods option with get, set
        abstract activeLod: float option with get, set
        abstract optimalLod: float option with get, set
        abstract availableLevels: ResizeArray<float> option with get, set
        abstract baseLod: float option with get, set
        abstract targetLevel: float option with get, set
        abstract lodCooldown: float option with get, set
        abstract inFrustum: bool option with get, set
        abstract cullBounds: BoundingInfo option with get, set
        abstract pendingFile: float option with get, set
        abstract activeFile: float option with get, set

    type [<AllowNullLiteral>] ISOGLODMetadata =
        abstract lodLevels: float with get, set
        abstract filenames: ResizeArray<string> with get, set
        abstract environment: string option with get, set
        abstract tree: ISOGLODNode with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] GaussianSplattingStreamDebugLodSource =
        | Optimal
        | Current

    type [<AllowNullLiteral>] IGaussianSplattingStreamOptions =
        abstract deflateURL: string option with get, set
        abstract fflate: obj option with get, set
        abstract debugDisplay: bool option with get, set
        abstract debugLodSource: GaussianSplattingStreamDebugLodSource option with get, set
        abstract lodBaseDistance: float option with get, set
        abstract lodMultiplier: float option with get, set
        abstract lodBehindPenalty: float option with get, set
        abstract lodRangeMin: float option with get, set
        abstract lodRangeMax: float option with get, set
        abstract maxDecodesPerFrame: float option with get, set
        abstract lodCooldownFrames: float option with get, set
        abstract lodUpdateInterval: float option with get, set
        abstract lodUpdateDistance: float option with get, set
        abstract maxDetailLod: float option with get, set
        abstract frustumCulling: bool option with get, set
        abstract maxConcurrentDownloads: float option with get, set
        abstract maxDownloadRetries: float option with get, set
        abstract memoryBudgetMb: float option with get, set
        abstract maxResidentSplats: float option with get, set
        abstract evictionCooldownFrames: float option with get, set

    type [<AllowNullLiteral>] GaussianSplattingStream =
        inherit GaussianSplattingMesh
        abstract getClassName: unit -> string
        abstract whenSettledAsync: ?stableFrames: float -> Promise<unit>
        abstract maxDetailLod: float with get, set
        abstract maxLodLevel: float
        abstract frustumCulling: bool with get, set
        abstract debugDisplay: bool with get, set
        abstract debugLodSource: GaussianSplattingStreamDebugLodSource with get, set
        abstract dispose: ?doNotRecurse: bool -> unit
        abstract evaluateOptimalLods: ?camera: Nullable<Camera> -> unit

    type [<AllowNullLiteral>] GaussianSplattingStreamStatic =
        abstract IsLODMetadata: data: obj -> bool
        [<EmitConstructor>] abstract Create: name: string * metadata: ISOGLODMetadata * rootUrl: string * scene: Scene * ?options: IGaussianSplattingStreamOptions -> GaussianSplattingStream

    type [<AllowNullLiteral>] IResidencyMove =
        abstract file: float with get, set
        abstract oldOffset: float with get, set
        abstract newOffset: float with get, set
        abstract count: float with get, set

    type [<AllowNullLiteral>] GaussianSplattingResidencyController =
        abstract capacity: float
        abstract residentCount: float
        abstract freeSize: float
        abstract has: file: float -> bool
        abstract offset: file: float -> float option
        abstract allocate: file: float * count: float -> Nullable<float>
        abstract pin: file: float * count: float -> Nullable<float>
        abstract free: file: float -> unit
        abstract compact: unit -> ResizeArray<IResidencyMove>
        abstract getResidentBlocks: unit -> Array<{| file: float; offset: float; count: float |}>
        abstract scheduleEviction: file: float -> unit
        abstract cancelEviction: file: float -> unit
        abstract tick: unit -> ResizeArray<float>
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] GaussianSplattingResidencyControllerStatic =
        [<EmitConstructor>] abstract Create: capacity: float * cooldownFrames: float * onEvict: (float -> unit) -> GaussianSplattingResidencyController

    type [<AllowNullLiteral>] IGaussianSplattingDownloadManagerOptions =
        abstract maxConcurrent: float option with get, set
        abstract maxRetries: float option with get, set

    type DownloadGroupId =
        U2<string, float>

    type [<AllowNullLiteral>] GaussianSplattingDownloadManager =
        abstract maxConcurrent: float
        abstract maxRetries: float
        abstract isIdle: bool
        abstract loadFileAsync: url: string * ?groupId: DownloadGroupId -> Promise<ArrayBuffer>
        abstract cancel: url: string -> unit
        abstract cancelGroup: groupId: DownloadGroupId -> unit
        abstract dispose: unit -> unit

    type [<AllowNullLiteral>] GaussianSplattingDownloadManagerStatic =
        [<EmitConstructor>] abstract Create: ?options: IGaussianSplattingDownloadManagerOptions -> GaussianSplattingDownloadManager

    type [<AllowNullLiteral>] GaussianSplattingMemBlock =
        abstract _offset: float with get, set
        abstract _size: float with get, set
        abstract _free: bool with get, set
        abstract _prev: Nullable<GaussianSplattingMemBlock> with get, set
        abstract _next: Nullable<GaussianSplattingMemBlock> with get, set
        abstract _prevFree: Nullable<GaussianSplattingMemBlock> with get, set
        abstract _nextFree: Nullable<GaussianSplattingMemBlock> with get, set
        abstract _bucket: float with get, set
        abstract offset: float
        abstract size: float

    type [<AllowNullLiteral>] GaussianSplattingMemBlockStatic =
        [<EmitConstructor>] abstract Create: unit -> GaussianSplattingMemBlock

    type [<AllowNullLiteral>] GaussianSplattingBlockAllocator =
        abstract capacity: float
        abstract usedSize: float
        abstract freeSize: float
        abstract fragmentation: float
        abstract allocate: size: float -> Nullable<GaussianSplattingMemBlock>
        abstract free: block: GaussianSplattingMemBlock -> unit
        abstract grow: newCapacity: float -> unit
        abstract defrag: ?maxMoves: float * ?result: Set<GaussianSplattingMemBlock> -> Set<GaussianSplattingMemBlock>
        abstract updateAllocation: toFree: ResizeArray<GaussianSplattingMemBlock> * toAllocate: Array<U2<float, GaussianSplattingMemBlock>> -> bool

    type [<AllowNullLiteral>] GaussianSplattingBlockAllocatorStatic =
        [<EmitConstructor>] abstract Create: ?capacity: float * ?growMultiplier: float -> GaussianSplattingBlockAllocator

    type [<AllowNullLiteral>] SolidParser =
        abstract parse: meshesNames: obj option * data: string * scene: Scene * assetContainer: Nullable<AssetContainer> * onFileToLoadFound: (string -> unit) -> unit

    type [<AllowNullLiteral>] SolidParserStatic =
        abstract ObjectDescriptor: RegExp with get, set
        abstract GroupDescriptor: RegExp with get, set
        abstract MtlLibGroupDescriptor: RegExp with get, set
        abstract UseMtlDescriptor: RegExp with get, set
        abstract SmoothDescriptor: RegExp with get, set
        abstract VertexPattern: RegExp with get, set
        abstract NormalPattern: RegExp with get, set
        abstract UVPattern: RegExp with get, set
        abstract FacePattern1: RegExp with get, set
        abstract FacePattern2: RegExp with get, set
        abstract FacePattern3: RegExp with get, set
        abstract FacePattern4: RegExp with get, set
        abstract FacePattern5: RegExp with get, set
        abstract LinePattern1: RegExp with get, set
        abstract LinePattern2: RegExp with get, set
        abstract LinePattern3: RegExp with get, set
        [<EmitConstructor>] abstract Create: materialToUse: ResizeArray<string> * babylonMeshesArray: Array<Mesh> * loadingOptions: OBJLoadingOptions -> SolidParser

    type [<AllowNullLiteral>] OBJLoadingOptions =
        abstract optimizeWithUV: bool with get, set
        abstract UVScaling: Vector2 with get, set
        abstract invertY: bool with get, set
        abstract invertTextureY: bool with get, set
        abstract importVertexColors: bool with get, set
        abstract computeNormals: bool with get, set
        abstract optimizeNormals: bool with get, set
        abstract skipMaterials: bool with get, set
        abstract materialLoadingFailsSilently: bool with get, set
        abstract useLegacyBehavior: bool with get, set

    type [<AllowNullLiteral>] OBJFileLoader =
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract name: string
        abstract extensions: string
        abstract createPlugin: options: SceneLoaderPluginOptions -> U2<ISceneLoaderPluginAsync, ISceneLoaderPlugin>
        abstract canDirectLoad: unit -> bool
        abstract importMeshAsync: meshesNames: obj option * scene: Scene * data: obj option * rootUrl: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: string * rootUrl: string -> Promise<unit>
        abstract loadAssetContainerAsync: scene: Scene * data: string * rootUrl: string -> Promise<AssetContainer>

    type [<AllowNullLiteral>] OBJFileLoaderStatic =
        abstract OPTIMIZE_WITH_UV: bool with get, set
        abstract INVERT_Y: bool with get, set
        abstract INVERT_TEXTURE_Y: bool with get, set
        abstract IMPORT_VERTEX_COLORS: bool with get, set
        abstract COMPUTE_NORMALS: bool with get, set
        abstract OPTIMIZE_NORMALS: bool with get, set
        abstract UV_SCALING: Vector2 with get, set
        abstract SKIP_MATERIALS: bool with get, set
        abstract MATERIAL_LOADING_FAILS_SILENTLY: bool with get, set
        abstract USE_LEGACY_BEHAVIOR: bool with get, set
        [<EmitConstructor>] abstract Create: ?loadingOptions: obj -> OBJFileLoader

    type [<AllowNullLiteral>] MTLFileLoader =
        abstract materials: ResizeArray<StandardMaterial> with get, set
        abstract parseMTL: scene: Scene * data: U2<string, ArrayBuffer> * rootUrl: string * assetContainer: Nullable<AssetContainer> -> unit

    type [<AllowNullLiteral>] MTLFileLoaderStatic =
        [<EmitConstructor>] abstract Create: unit -> MTLFileLoader
        abstract INVERT_TEXTURE_Y: bool with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXNormalMapCoordinateSystem =
        | [<CompiledName("y-up")>] YUp
        | [<CompiledName("y-down")>] YDown

    type [<AllowNullLiteral>] FBXFileLoaderOptions =
        abstract normalMapCoordinateSystem: FBXNormalMapCoordinateSystem option with get, set

    type [<AllowNullLiteral>] FBXFileLoader =
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract name: string
        abstract extensions: {| ``.fbx``: {| isBinary: bool |} |}
        abstract createPlugin: options: SceneLoaderPluginOptions -> ISceneLoaderPluginAsync
        abstract importMeshAsync: meshesNames: U2<string, ResizeArray<string>> option * scene: Scene * data: obj * rootUrl: string * ?_onProgress: (ISceneLoaderProgressEvent -> unit) * ?_fileName: string -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: obj * rootUrl: string * ?_onProgress: (ISceneLoaderProgressEvent -> unit) * ?_fileName: string -> Promise<unit>
        abstract loadAssetContainerAsync: scene: Scene * data: obj * rootUrl: string * ?_onProgress: (ISceneLoaderProgressEvent -> unit) * ?_fileName: string -> Promise<AssetContainer>

    type [<AllowNullLiteral>] FBXFileLoaderStatic =
        [<EmitConstructor>] abstract Create: ?options: FBXFileLoaderOptions -> FBXFileLoader

    type FBXPropertyValue =
        U7<bool, float, string, Float32Array, Float64Array, Int32Array, Uint8Array>

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXPropertyType =
        | Boolean
        | Int16
        | Int32
        | Int64
        | Float32
        | Float64
        | String
        | Raw
        | [<CompiledName("float32[]")>] Float32_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET
        | [<CompiledName("float64[]")>] Float64_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET
        | [<CompiledName("int32[]")>] Int32_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET
        | [<CompiledName("int64[]")>] Int64_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET
        | [<CompiledName("boolean[]")>] Boolean_LEFT_SQUARE_BRACKET_RIGHT_SQUARE_BRACKET

    type [<AllowNullLiteral>] FBXProperty =
        abstract ``type``: FBXPropertyType with get, set
        abstract value: FBXPropertyValue with get, set

    type [<AllowNullLiteral>] FBXNode =
        abstract name: string with get, set
        abstract properties: ResizeArray<FBXProperty> with get, set
        abstract children: ResizeArray<FBXNode> with get, set

    type [<AllowNullLiteral>] FBXDocument =
        abstract version: float with get, set
        abstract nodes: ResizeArray<FBXNode> with get, set

    type FBXVector3 =
        float * float * float

    type [<AllowNullLiteral>] FBXTransformComponents =
        abstract translation: FBXVector3 with get, set
        abstract rotation: FBXVector3 with get, set
        abstract scale: FBXVector3 with get, set
        abstract preRotation: FBXVector3 with get, set
        abstract postRotation: FBXVector3 with get, set
        abstract rotationPivot: FBXVector3 with get, set
        abstract scalingPivot: FBXVector3 with get, set
        abstract rotationOffset: FBXVector3 with get, set
        abstract scalingOffset: FBXVector3 with get, set
        abstract rotationOrder: float with get, set
        abstract inheritType: float option with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXClusterMode =
        | [<CompiledName("Normalize")>] Normalize
        | [<CompiledName("Additive")>] Additive
        | [<CompiledName("TotalOne")>] TotalOne
        | [<CompiledName("Unknown")>] Unknown

    type [<AllowNullLiteral>] FBXSkinDiagnostic =
        abstract ``type``: FBXSkinDiagnosticType with get, set
        abstract message: string with get, set
        abstract boneModelId: float option with get, set
        abstract boneName: string option with get, set
        abstract clusterMode: FBXClusterMode option with get, set

    type [<AllowNullLiteral>] FBXBoneData =
        abstract modelId: float with get, set
        abstract name: string with get, set
        abstract index: float with get, set
        abstract parentIndex: float with get, set
        abstract isCluster: bool with get, set
        abstract translation: float * float * float with get, set
        abstract rotation: float * float * float with get, set
        abstract preRotation: float * float * float with get, set
        abstract postRotation: float * float * float with get, set
        abstract rotationPivot: float * float * float with get, set
        abstract scalingPivot: float * float * float with get, set
        abstract rotationOffset: float * float * float with get, set
        abstract scalingOffset: float * float * float with get, set
        abstract scale: float * float * float with get, set
        abstract rotationOrder: float with get, set
        abstract inheritType: float with get, set
        abstract clusterMode: FBXClusterMode with get, set
        abstract bindPoseMatrix: Float64Array option with get, set
        abstract transformLinkMatrix: Float64Array option with get, set
        abstract transformAssociateModelMatrix: Float64Array option with get, set
        abstract modelBindPoseMatrix: Float64Array option with get, set
        abstract diagnostics: ResizeArray<FBXSkinDiagnostic> with get, set

    type [<AllowNullLiteral>] FBXSkinData =
        abstract id: float with get, set
        abstract geometryId: float with get, set
        abstract meshBindPoseMatrix: Float64Array option with get, set
        abstract bones: ResizeArray<FBXBoneData> with get, set
        abstract boneIndices: ResizeArray<ResizeArray<float>> with get, set
        abstract boneWeights: ResizeArray<ResizeArray<float>> with get, set
        abstract diagnostics: ResizeArray<FBXSkinDiagnostic> with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXSceneDiagnosticType =
        | [<CompiledName("unsupported-constraint")>] UnsupportedConstraint
        | [<CompiledName("unsupported-helper")>] UnsupportedHelper
        | [<CompiledName("unsupported-deformer")>] UnsupportedDeformer
        | [<CompiledName("unsupported-node-attribute")>] UnsupportedNodeAttribute
        | [<CompiledName("unsupported-pose")>] UnsupportedPose
        | [<CompiledName("unsupported-layered-texture")>] UnsupportedLayeredTexture
        | [<CompiledName("connection-graph")>] ConnectionGraph

    type [<AllowNullLiteral>] FBXSceneDiagnostic =
        abstract ``type``: FBXSceneDiagnosticType with get, set
        abstract message: string with get, set
        abstract objectId: float option with get, set
        abstract objectName: string option with get, set
        abstract nodeName: string option with get, set
        abstract subType: string option with get, set
        abstract parentCount: float option with get, set
        abstract childCount: float option with get, set

    type FBXRigBoneData =
        FBXBoneData

    type [<AllowNullLiteral>] FBXSkinBindingData =
        abstract skinId: float with get, set
        abstract geometryId: float with get, set
        abstract rigId: string with get, set
        abstract skinBoneIndexToRigBoneIndex: ResizeArray<float> with get, set
        abstract clusterModelIds: Set<float> with get, set

    type [<AllowNullLiteral>] FBXRigData =
        abstract id: string with get, set
        abstract rootModelIds: ResizeArray<float> with get, set
        abstract bones: ResizeArray<FBXRigBoneData> with get, set
        abstract modelIdToBoneIndex: Map<float, float> with get, set
        abstract clusterModelIds: Set<float> with get, set
        abstract skinBindings: ResizeArray<FBXSkinBindingData> with get, set
        abstract warnings: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FBXTemplateProperty =
        abstract name: string with get, set
        abstract propertyType: string with get, set
        abstract label: string with get, set
        abstract flags: string with get, set
        abstract values: ResizeArray<FBXPropertyValue> with get, set

    type [<AllowNullLiteral>] FBXPropertyTemplate =
        abstract objectType: string with get, set
        abstract templateName: string with get, set
        abstract properties: Map<string, FBXTemplateProperty> with get, set

    type FBXPropertyTemplateMap =
        Map<string, Map<string, FBXPropertyTemplate>>

    type [<AllowNullLiteral>] FBXMaterialData =
        abstract id: float with get, set
        abstract name: string with get, set
        abstract ``type``: FBXMaterialDataType with get, set
        abstract properties: FBXMaterialProperties with get, set
        abstract textures: ResizeArray<FBXTextureRef> with get, set

    type [<AllowNullLiteral>] FBXMaterialProperties =
        abstract diffuseColor: (float * float * float) option with get, set
        abstract diffuseFactor: float option with get, set
        abstract ambientColor: (float * float * float) option with get, set
        abstract ambientFactor: float option with get, set
        abstract specularColor: (float * float * float) option with get, set
        abstract specularFactor: float option with get, set
        abstract shininess: float option with get, set
        abstract emissiveColor: (float * float * float) option with get, set
        abstract emissiveFactor: float option with get, set
        abstract opacity: float option with get, set
        abstract transparencyFactor: float option with get, set

    type [<AllowNullLiteral>] FBXTextureRef =
        abstract propertyName: string with get, set
        abstract fileName: string with get, set
        abstract relativeFileName: string with get, set
        abstract id: float with get, set
        abstract embeddedData: Uint8Array option with get, set
        abstract uvTranslation: (float * float) option with get, set
        abstract uvScaling: (float * float) option with get, set
        abstract uvRotation: float option with get, set
        abstract uvSetIndex: float option with get, set
        abstract uvSetName: string option with get, set

    type [<AllowNullLiteral>] FBXUVSet =
        abstract name: string with get, set
        abstract data: Float64Array with get, set

    type [<AllowNullLiteral>] FBXGeometryDiagnostic =
        abstract ``type``: FBXGeometryDiagnosticType with get, set
        abstract message: string with get, set
        abstract polygonIndex: float option with get, set
        abstract layerName: string option with get, set
        abstract index: float option with get, set

    type [<AllowNullLiteral>] FBXGeometryData =
        abstract id: float with get, set
        abstract name: string with get, set
        abstract positions: Float64Array with get, set
        abstract indices: Uint32Array with get, set
        abstract normals: Float64Array option with get, set
        abstract uvs: Float64Array option with get, set
        abstract uvSets: ResizeArray<FBXUVSet> with get, set
        abstract colors: Float32Array option with get, set
        abstract tangents: Float64Array option with get, set
        abstract binormals: Float64Array option with get, set
        abstract controlPointIndices: Uint32Array option with get, set
        abstract materialIndices: Int32Array option with get, set
        abstract diagnostics: ResizeArray<FBXGeometryDiagnostic> with get, set

    type [<AllowNullLiteral>] FBXModelData =
        abstract id: float with get, set
        abstract name: string with get, set
        abstract subType: string with get, set
        abstract geometry: FBXGeometryData option with get, set
        abstract materials: ResizeArray<FBXMaterialData> with get, set
        abstract children: ResizeArray<FBXModelData> with get, set
        abstract translation: float * float * float with get, set
        abstract rotation: float * float * float with get, set
        abstract scale: float * float * float with get, set
        abstract preRotation: float * float * float with get, set
        abstract postRotation: float * float * float with get, set
        abstract rotationPivot: float * float * float with get, set
        abstract scalingPivot: float * float * float with get, set
        abstract rotationOffset: float * float * float with get, set
        abstract scalingOffset: float * float * float with get, set
        abstract geometricTranslation: float * float * float with get, set
        abstract geometricRotation: float * float * float with get, set
        abstract geometricScaling: float * float * float with get, set
        abstract rotationOrder: float with get, set
        abstract inheritType: float with get, set
        abstract cullingOff: bool with get, set
        abstract customProperties: Record<string, U3<string, float, bool>> option with get, set
        abstract diagnostics: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FBXCameraData =
        abstract modelId: float with get, set
        abstract name: string with get, set
        abstract fieldOfView: float with get, set
        abstract nearPlane: float with get, set
        abstract farPlane: float with get, set
        abstract aspectRatio: float with get, set
        abstract projectionType: FBXCameraDataProjectionType with get, set
        abstract focalLength: float option with get, set
        abstract filmWidth: float option with get, set
        abstract filmHeight: float option with get, set
        abstract orthoZoom: float option with get, set
        abstract roll: float option with get, set
        abstract unknownProperties: ResizeArray<string> with get, set
        abstract diagnostics: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FBXLightData =
        abstract modelId: float with get, set
        abstract name: string with get, set
        abstract lightType: float with get, set
        abstract color: float * float * float with get, set
        abstract intensity: float with get, set
        abstract coneAngle: float with get, set
        abstract decayType: float with get, set
        abstract innerAngle: float option with get, set
        abstract outerAngle: float option with get, set
        abstract decayStart: float option with get, set
        abstract enableNearAttenuation: bool option with get, set
        abstract enableFarAttenuation: bool option with get, set
        abstract castShadows: bool option with get, set
        abstract unknownProperties: ResizeArray<string> with get, set
        abstract diagnostics: ResizeArray<string> with get, set

    type [<AllowNullLiteral>] FBXSceneData =
        abstract rootModels: ResizeArray<FBXModelData> with get, set
        abstract geometries: ResizeArray<FBXGeometryData> with get, set
        abstract materials: ResizeArray<FBXMaterialData> with get, set
        abstract skins: ResizeArray<FBXSkinData> with get, set
        abstract rigs: ResizeArray<FBXRigData> with get, set
        abstract blendShapes: ResizeArray<FBXBlendShapeData> with get, set
        abstract animations: ResizeArray<FBXAnimationStackData> with get, set
        abstract cameras: ResizeArray<FBXCameraData> with get, set
        abstract lights: ResizeArray<FBXLightData> with get, set
        abstract diagnostics: ResizeArray<FBXSceneDiagnostic> with get, set
        abstract upAxis: float with get, set
        abstract upAxisSign: float with get, set
        abstract frontAxis: float with get, set
        abstract frontAxisSign: float with get, set
        abstract coordAxis: float with get, set
        abstract coordAxisSign: float with get, set
        abstract unitScaleFactor: float with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] ConnectionType =
        | [<CompiledName("OO")>] OO
        | [<CompiledName("OP")>] OP

    type [<AllowNullLiteral>] FBXConnection =
        abstract ``type``: ConnectionType with get, set
        abstract childId: float with get, set
        abstract parentId: float with get, set
        abstract propertyName: string option with get, set

    type [<AllowNullLiteral>] FBXObjectEntry =
        abstract id: float with get, set
        abstract node: FBXNode with get, set
        abstract source: FBXObjectEntrySource with get, set
        abstract legacyName: string option with get, set
        abstract synthetic: bool with get, set

    type [<AllowNullLiteral>] FBXConnectionEntry =
        abstract source: FBXConnectionEntrySource with get, set
        abstract rawType: string option with get, set
        abstract childId: float option with get, set
        abstract parentId: float option with get, set
        abstract propertyName: string option with get, set
        abstract accepted: bool with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXConnectionDiagnosticReason =
        | [<CompiledName("unsupported-connection-type")>] UnsupportedConnectionType
        | [<CompiledName("missing-connection-endpoint")>] MissingConnectionEndpoint
        | [<CompiledName("unresolved-legacy-endpoint")>] UnresolvedLegacyEndpoint
        | [<CompiledName("unresolved-object-reference")>] UnresolvedObjectReference
        | [<CompiledName("duplicate-parent")>] DuplicateParent
        | [<CompiledName("self-loop")>] SelfLoop

    type [<AllowNullLiteral>] FBXConnectionDiagnostic =
        abstract reason: FBXConnectionDiagnosticReason with get, set
        abstract message: string with get, set
        abstract connectionIndex: float option with get, set
        abstract ``type``: string option with get, set
        abstract childId: float option with get, set
        abstract parentId: float option with get, set
        abstract propertyName: string option with get, set

    type [<AllowNullLiteral>] FBXObjectMap =
        abstract objects: Map<float, FBXNode> with get, set
        abstract objectEntries: ResizeArray<FBXObjectEntry> with get, set
        abstract childrenOf: Map<float, ResizeArray<{| id: float; propertyName: string option |}>> with get, set
        abstract parentOf: Map<float, {| id: float; propertyName: string option |}> with get, set
        abstract connections: ResizeArray<FBXConnection> with get, set
        abstract connectionEntries: ResizeArray<FBXConnectionEntry> with get, set
        abstract diagnostics: ResizeArray<FBXConnectionDiagnostic> with get, set

    type [<AllowNullLiteral>] FBXShapeData =
        abstract indices: Uint32Array with get, set
        abstract vertices: Float64Array with get, set
        abstract normals: Float64Array option with get, set

    type [<AllowNullLiteral>] FBXBlendShapeDiagnostic =
        abstract ``type``: FBXBlendShapeDiagnosticType with get, set
        abstract message: string with get, set
        abstract channelId: float with get, set
        abstract channelName: string with get, set

    type [<AllowNullLiteral>] FBXBlendShapeChannelData =
        abstract name: string with get, set
        abstract id: float with get, set
        abstract deformPercent: float with get, set
        abstract shapes: ResizeArray<FBXShapeData> with get, set
        abstract fullWeights: ResizeArray<float> option with get, set
        abstract diagnostics: ResizeArray<FBXBlendShapeDiagnostic> with get, set

    type [<AllowNullLiteral>] FBXBlendShapeData =
        abstract id: float with get, set
        abstract geometryId: float with get, set
        abstract channels: ResizeArray<FBXBlendShapeChannelData> with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXInterpolationType =
        | Constant
        | Linear
        | Cubic

    type [<AllowNullLiteral>] FBXKeyframe =
        abstract time: float with get, set
        abstract value: float with get, set
        abstract interpolation: FBXInterpolationType with get, set
        abstract constantMode: FBXKeyframeConstantMode option with get, set
        abstract rightSlope: float option with get, set
        abstract nextLeftSlope: float option with get, set

    type [<AllowNullLiteral>] FBXCurveData =
        abstract channel: string with get, set
        abstract keys: ResizeArray<FBXKeyframe> with get, set
        abstract isSampled: bool option with get, set

    type [<AllowNullLiteral>] FBXCurveNodeData =
        abstract ``type``: string with get, set
        abstract targetModelId: float with get, set
        abstract curves: ResizeArray<FBXCurveData> with get, set

    type [<AllowNullLiteral>] FBXUnsupportedCurveNodeData =
        abstract ``type``: string with get, set
        abstract id: float with get, set
        abstract targetId: float option with get, set
        abstract propertyName: string option with get, set
        abstract curveCount: float with get, set
        abstract curves: ResizeArray<FBXCurveData> with get, set
        abstract defaultValues: Record<string, float> with get, set

    type [<AllowNullLiteral>] FBXAnimationDiagnostic =
        abstract ``type``: FBXAnimationDiagnosticType with get, set
        abstract message: string with get, set
        abstract layerName: string option with get, set
        abstract curveNodeId: float option with get, set
        abstract curveNodeType: string option with get, set
        abstract targetId: float option with get, set
        abstract propertyName: string option with get, set

    type [<AllowNullLiteral>] FBXAnimationLayerData =
        abstract name: string with get, set
        abstract weight: float with get, set
        abstract normalizedWeight: float with get, set
        abstract blendMode: float with get, set
        abstract curveNodes: ResizeArray<FBXCurveNodeData> with get, set
        abstract unsupportedCurveNodes: ResizeArray<FBXUnsupportedCurveNodeData> with get, set
        abstract diagnostics: ResizeArray<FBXAnimationDiagnostic> with get, set

    type [<AllowNullLiteral>] FBXAnimationStackData =
        abstract name: string with get, set
        abstract startTime: float with get, set
        abstract stopTime: float with get, set
        abstract duration: float with get, set
        abstract curveNodes: ResizeArray<FBXCurveNodeData> with get, set
        abstract layers: ResizeArray<FBXAnimationLayerData> with get, set
        abstract unsupportedCurveNodes: ResizeArray<FBXUnsupportedCurveNodeData> with get, set
        abstract diagnostics: ResizeArray<FBXAnimationDiagnostic> with get, set

    type [<AllowNullLiteral>] BVHLoadingOptions =
        abstract loopMode: float with get, set

    type [<AllowNullLiteral>] BVHFileLoader =
        inherit ISceneLoaderPluginAsync
        inherit ISceneLoaderPluginFactory
        abstract name: string
        abstract extensions: {| ``.bvh``: {| isBinary: bool |} |}
        abstract createPlugin: options: SceneLoaderPluginOptions -> ISceneLoaderPluginAsync
        abstract canDirectLoad: data: string -> bool
        abstract isBvhHeader: text: string -> bool
        abstract isNotBvhHeader: text: string -> bool
        abstract importMeshAsync: _meshesNames: U2<string, ResizeArray<string>> option * scene: Scene * data: obj -> Promise<ISceneLoaderAsyncResult>
        abstract loadAsync: scene: Scene * data: obj -> Promise<unit>
        abstract loadAssetContainerAsync: scene: Scene * data: obj -> Promise<AssetContainer>

    type [<AllowNullLiteral>] BVHFileLoaderStatic =
        [<EmitConstructor>] abstract Create: ?loadingOptions: obj -> BVHFileLoader

    type [<AllowNullLiteral>] IExportsSPLATFileLoaderMetadataExtensions =
        abstract ``.splat``: {| isBinary: bool |}
        abstract ``.ply``: {| isBinary: bool |}
        abstract ``.spz``: {| isBinary: bool |}
        abstract ``.json``: {| isBinary: bool |}
        abstract ``.sog``: {| isBinary: bool |}

    type [<AllowNullLiteral>] SceneLoaderPluginOptions_STLFileLoaderMetadataName_ =
        interface end

    type ISogTexturePackVersion =
        | N1 = 1
        | N2 = 2

    type [<StringEnum>] [<RequireQualifiedAccess>] IParsedSplatUpAxis =
        | [<CompiledName("X")>] X
        | [<CompiledName("Y")>] Y
        | [<CompiledName("Z")>] Z

    type [<StringEnum>] [<RequireQualifiedAccess>] IParsedSplatChirality =
        | [<CompiledName("LeftHanded")>] LeftHanded
        | [<CompiledName("RightHanded")>] RightHanded

    type [<AllowNullLiteral>] ISOGLODNodeLods =
        [<EmitIndexer>] abstract Item: level: string -> ISOGLODEntry with get, set

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXSkinDiagnosticType =
        | [<CompiledName("cluster-mode-runtime-unsupported")>] ClusterModeRuntimeUnsupported
        | [<CompiledName("missing-cluster-transform")>] MissingClusterTransform
        | [<CompiledName("missing-cluster-transform-link")>] MissingClusterTransformLink
        | [<CompiledName("missing-bind-pose-matrix")>] MissingBindPoseMatrix
        | [<CompiledName("associate-model-present")>] AssociateModelPresent

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXMaterialDataType =
        | [<CompiledName("Lambert")>] Lambert
        | [<CompiledName("Phong")>] Phong

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXGeometryDiagnosticType =
        | [<CompiledName("degenerate-polygon")>] DegeneratePolygon
        | [<CompiledName("triangulation-fallback")>] TriangulationFallback
        | [<CompiledName("layer-index-out-of-bounds")>] LayerIndexOutOfBounds
        | [<CompiledName("layer-data-too-short")>] LayerDataTooShort

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXCameraDataProjectionType =
        | Perspective
        | Orthographic

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXObjectEntrySource =
        | [<CompiledName("Objects")>] Objects
        | LegacySyntheticGeometry

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXConnectionEntrySource =
        | [<CompiledName("C")>] C
        | [<CompiledName("Connect")>] Connect

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXBlendShapeDiagnosticType =
        | [<CompiledName("full-weights-mismatch")>] FullWeightsMismatch
        | [<CompiledName("missing-full-weights")>] MissingFullWeights

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXKeyframeConstantMode =
        | Standard
        | Next

    type [<StringEnum>] [<RequireQualifiedAccess>] FBXAnimationDiagnosticType =
        | [<CompiledName("multiple-animation-layers")>] MultipleAnimationLayers
        | [<CompiledName("unsupported-layer-blend-mode")>] UnsupportedLayerBlendMode
        | [<CompiledName("partial-layer-weight")>] PartialLayerWeight
        | [<CompiledName("unsupported-curve-node")>] UnsupportedCurveNode
