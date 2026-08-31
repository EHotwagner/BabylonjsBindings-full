module DeviceMismatch
open BabylonjsBindings.FiniteDependentMaps
let mismatch (source: KeyboardDeviceSource) = source.getInput PointerDeviceInput.LeftClick
