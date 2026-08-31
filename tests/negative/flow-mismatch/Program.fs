module FlowMismatch
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.FiniteDependentMaps
let mismatch (assets: BabylonjsBindings.SimpleInterfaces.IAssetContainer) : Mesh option = GetFlowGraphAssetWithType.Invoke(assets, FlowGraphAnimationAsset.Value, 0.0)
