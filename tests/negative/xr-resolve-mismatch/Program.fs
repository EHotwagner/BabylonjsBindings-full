module XRResolveMismatch
open BabylonjsBindings.FiniteDependentMaps
let mismatch (resolver: ResolveWebXRFeature) : ResolveWebXRFeatureAnchorSystem = resolver.Resolve XRHitTest.Value
