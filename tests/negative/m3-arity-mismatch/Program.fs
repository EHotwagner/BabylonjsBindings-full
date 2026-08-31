module M3ArityMismatch
open BabylonjsBindings.HigherOrderRuntimeApis

let collapse
    (factory: CoroutineFactory10<int, int, int, int, int, int, int, int, int, int, int>)
    : SyncCallable9<int, int, int, int, int, int, int, int, int, int> =
    makeSyncFunction.Invoke(factory)
