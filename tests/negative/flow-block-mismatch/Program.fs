module FlowBlockMismatch
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.FiniteDependentMaps
let mismatch (config: IFlowGraphGetPropertyBlockConfiguration<FlowGraphMeshAsset, Mesh>) : FlowGraphGetPropertyBlock<float, FlowGraphAnimationAsset, Animation> = FlowGraphGetPropertyBlock.Create config
