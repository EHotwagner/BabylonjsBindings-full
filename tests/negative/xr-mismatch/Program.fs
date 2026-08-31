module XRMismatch
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.FiniteDependentMaps
let mismatch (manager: WebXRFeaturesManager) (hitOptions: IWebXRHitTestOptions) = manager.enableFeature(XRAnchorSystem.Value, moduleOptions = hitOptions)
