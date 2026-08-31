module M3MixinMismatch
open BabylonjsBindings.HigherOrderRuntimeApis

let collapse
    (value: ImageProcessingDefinesPBRMaterialDefinesBase)
    : ImageProcessingDefinesStandardMaterialDefinesBase = value
