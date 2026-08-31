module M3DecoratorMismatch
open BabylonjsBindings.HigherOrderRuntimeApis

let collapse
    (method: ThisCallable1<string, int, int>)
    (context: ClassMethodDecoratorContext<obj, ThisCallable1<obj, int, int>>) =
    nativeOverride.Invoke(method, context)
