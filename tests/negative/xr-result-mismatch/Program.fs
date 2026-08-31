module XRResultMismatch
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.FiniteDependentMaps
let mismatch (manager: WebXRFeaturesManager) : WebXRHitTest = manager.getEnabledFeature XRAnchorSystem.Value
