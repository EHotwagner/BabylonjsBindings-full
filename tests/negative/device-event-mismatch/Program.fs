module DeviceEventMismatch
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.FiniteDependentMaps
let mismatch (source: KeyboardDeviceSource) : Observable<DeviceSourceEventMouse> = source.onInputChangedObservable
