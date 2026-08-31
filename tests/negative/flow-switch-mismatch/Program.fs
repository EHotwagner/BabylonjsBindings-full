module FlowSwitchMismatch
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.FiniteDependentMaps
let mismatch (config: IFlowGraphSwitchBlockConfiguration<float>) : FlowGraphIntegerSwitchBlock = FlowGraphSwitchBlock.Create config
