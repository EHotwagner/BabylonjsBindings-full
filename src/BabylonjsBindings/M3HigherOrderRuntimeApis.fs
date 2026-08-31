namespace BabylonjsBindings

open Fable.Core
open Fable.Core.JsInterop
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.SimpleClasses
open BabylonjsBindings.TypeAliases

/// Curated higher-order runtime projections for Babylon.js 9.19.0.
module HigherOrderRuntimeApis =

    type CoroutineFactory0<'R> = System.Func<Coroutine<'R>>
    type AsyncCoroutineFactory0<'R> = System.Func<AsyncCoroutine<'R>>
    type SyncCallable0<'R> = System.Func<'R>
    type AsyncCallable0<'R> = System.Func<JS.Promise<'R>>
    type Predicate0 = System.Func<bool>

    type CoroutineFactory1<'A1, 'R> = System.Func<'A1, Coroutine<'R>>
    type AsyncCoroutineFactory1<'A1, 'R> = System.Func<'A1, AsyncCoroutine<'R>>
    type SyncCallable1<'A1, 'R> = System.Func<'A1, 'R>
    type AsyncCallable1<'A1, 'R> = System.Func<'A1, JS.Promise<'R>>
    type Predicate1<'A1> = System.Func<'A1, bool>

    type CoroutineFactory2<'A1, 'A2, 'R> = System.Func<'A1, 'A2, Coroutine<'R>>
    type AsyncCoroutineFactory2<'A1, 'A2, 'R> = System.Func<'A1, 'A2, AsyncCoroutine<'R>>
    type SyncCallable2<'A1, 'A2, 'R> = System.Func<'A1, 'A2, 'R>
    type AsyncCallable2<'A1, 'A2, 'R> = System.Func<'A1, 'A2, JS.Promise<'R>>
    type Predicate2<'A1, 'A2> = System.Func<'A1, 'A2, bool>

    type CoroutineFactory3<'A1, 'A2, 'A3, 'R> = System.Func<'A1, 'A2, 'A3, Coroutine<'R>>
    type AsyncCoroutineFactory3<'A1, 'A2, 'A3, 'R> = System.Func<'A1, 'A2, 'A3, AsyncCoroutine<'R>>
    type SyncCallable3<'A1, 'A2, 'A3, 'R> = System.Func<'A1, 'A2, 'A3, 'R>
    type AsyncCallable3<'A1, 'A2, 'A3, 'R> = System.Func<'A1, 'A2, 'A3, JS.Promise<'R>>
    type Predicate3<'A1, 'A2, 'A3> = System.Func<'A1, 'A2, 'A3, bool>

    type CoroutineFactory4<'A1, 'A2, 'A3, 'A4, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, Coroutine<'R>>
    type AsyncCoroutineFactory4<'A1, 'A2, 'A3, 'A4, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, AsyncCoroutine<'R>>
    type SyncCallable4<'A1, 'A2, 'A3, 'A4, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'R>
    type AsyncCallable4<'A1, 'A2, 'A3, 'A4, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, JS.Promise<'R>>
    type Predicate4<'A1, 'A2, 'A3, 'A4> = System.Func<'A1, 'A2, 'A3, 'A4, bool>

    type CoroutineFactory5<'A1, 'A2, 'A3, 'A4, 'A5, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, Coroutine<'R>>
    type AsyncCoroutineFactory5<'A1, 'A2, 'A3, 'A4, 'A5, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, AsyncCoroutine<'R>>
    type SyncCallable5<'A1, 'A2, 'A3, 'A4, 'A5, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'R>
    type AsyncCallable5<'A1, 'A2, 'A3, 'A4, 'A5, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, JS.Promise<'R>>
    type Predicate5<'A1, 'A2, 'A3, 'A4, 'A5> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, bool>

    type CoroutineFactory6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, Coroutine<'R>>
    type AsyncCoroutineFactory6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, AsyncCoroutine<'R>>
    type SyncCallable6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>
    type AsyncCallable6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, JS.Promise<'R>>
    type Predicate6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, bool>

    type CoroutineFactory7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, Coroutine<'R>>
    type AsyncCoroutineFactory7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, AsyncCoroutine<'R>>
    type SyncCallable7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>
    type AsyncCallable7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, JS.Promise<'R>>
    type Predicate7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, bool>

    type CoroutineFactory8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, Coroutine<'R>>
    type AsyncCoroutineFactory8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, AsyncCoroutine<'R>>
    type SyncCallable8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>
    type AsyncCallable8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, JS.Promise<'R>>
    type Predicate8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, bool>

    type CoroutineFactory9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, Coroutine<'R>>
    type AsyncCoroutineFactory9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, AsyncCoroutine<'R>>
    type SyncCallable9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>
    type AsyncCallable9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, JS.Promise<'R>>
    type Predicate9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, bool>

    type CoroutineFactory10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, Coroutine<'R>>
    type AsyncCoroutineFactory10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, AsyncCoroutine<'R>>
    type SyncCallable10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>
    type AsyncCallable10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, JS.Promise<'R>>
    type Predicate10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10> = System.Func<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, bool>

    [<AllowNullLiteral>]
    type ThisCallable0<'This, 'R> =
        [<Emit("$0()")>] abstract Invoke: unit -> 'R
        [<Emit("$0.call($1)")>] abstract Call: thisArg: 'This -> 'R

    [<AllowNullLiteral>]
    type ThisCallable1<'This, 'A1, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 -> 'R
        [<Emit("$0.call($1, $2)")>] abstract Call: thisArg: 'This * arg1: 'A1 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable2<'This, 'A1, 'A2, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 -> 'R
        [<Emit("$0.call($1, $2, $3)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable3<'This, 'A1, 'A2, 'A3, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 * arg3: 'A3 -> 'R
        [<Emit("$0.call($1, $2, $3, $4)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 * arg3: 'A3 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 -> 'R
        [<Emit("$0.call($1, $2, $3, $4, $5)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 -> 'R
        [<Emit("$0.call($1, $2, $3, $4, $5, $6)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 -> 'R
        [<Emit("$0.call($1, $2, $3, $4, $5, $6, $7)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 * arg7: 'A7 -> 'R
        [<Emit("$0.call($1, $2, $3, $4, $5, $6, $7, $8)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 * arg7: 'A7 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 * arg7: 'A7 * arg8: 'A8 -> 'R
        [<Emit("$0.call($1, $2, $3, $4, $5, $6, $7, $8, $9)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 * arg7: 'A7 * arg8: 'A8 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 * arg7: 'A7 * arg8: 'A8 * arg9: 'A9 -> 'R
        [<Emit("$0.call($1, $2, $3, $4, $5, $6, $7, $8, $9, $10)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 * arg7: 'A7 * arg8: 'A8 * arg9: 'A9 -> 'R

    [<AllowNullLiteral>]
    type ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 * arg7: 'A7 * arg8: 'A8 * arg9: 'A9 * arg10: 'A10 -> 'R
        [<Emit("$0.call($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11)")>] abstract Call: thisArg: 'This * arg1: 'A1 * arg2: 'A2 * arg3: 'A3 * arg4: 'A4 * arg5: 'A5 * arg6: 'A6 * arg7: 'A7 * arg8: 'A8 * arg9: 'A9 * arg10: 'A10 -> 'R

    [<AllowNullLiteral>]
    type MakeSyncFunction =
        [<Emit("$0($1...)")>] abstract Invoke<'R>: coroutineFactory: CoroutineFactory0<'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable0<'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'R>: coroutineFactory: CoroutineFactory1<'A1, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable1<'A1, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'R>: coroutineFactory: CoroutineFactory2<'A1, 'A2, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable2<'A1, 'A2, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'R>: coroutineFactory: CoroutineFactory3<'A1, 'A2, 'A3, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable3<'A1, 'A2, 'A3, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'R>: coroutineFactory: CoroutineFactory4<'A1, 'A2, 'A3, 'A4, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable4<'A1, 'A2, 'A3, 'A4, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'R>: coroutineFactory: CoroutineFactory5<'A1, 'A2, 'A3, 'A4, 'A5, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable5<'A1, 'A2, 'A3, 'A4, 'A5, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>: coroutineFactory: CoroutineFactory6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>: coroutineFactory: CoroutineFactory7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>: coroutineFactory: CoroutineFactory8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>: coroutineFactory: CoroutineFactory9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>: coroutineFactory: CoroutineFactory10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> * ?abortSignal: BrowserAbortSignal -> SyncCallable10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>

    [<Import("makeSyncFunction", "@babylonjs/core/Misc/coroutine.js")>]
    let makeSyncFunction: MakeSyncFunction = jsNative

    [<AllowNullLiteral>]
    type MakeAsyncFunction =
        [<Emit("$0($1...)")>] abstract Invoke<'R>: coroutineFactory: AsyncCoroutineFactory0<'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable0<'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'R>: coroutineFactory: AsyncCoroutineFactory1<'A1, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable1<'A1, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'R>: coroutineFactory: AsyncCoroutineFactory2<'A1, 'A2, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable2<'A1, 'A2, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'R>: coroutineFactory: AsyncCoroutineFactory3<'A1, 'A2, 'A3, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable3<'A1, 'A2, 'A3, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'R>: coroutineFactory: AsyncCoroutineFactory4<'A1, 'A2, 'A3, 'A4, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable4<'A1, 'A2, 'A3, 'A4, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'R>: coroutineFactory: AsyncCoroutineFactory5<'A1, 'A2, 'A3, 'A4, 'A5, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable5<'A1, 'A2, 'A3, 'A4, 'A5, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>: coroutineFactory: AsyncCoroutineFactory6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>: coroutineFactory: AsyncCoroutineFactory7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>: coroutineFactory: AsyncCoroutineFactory8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>: coroutineFactory: AsyncCoroutineFactory9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>: coroutineFactory: AsyncCoroutineFactory10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> * scheduler: CoroutineScheduler<'R> * ?abortSignal: BrowserAbortSignal -> AsyncCallable10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>

    [<Import("makeAsyncFunction", "@babylonjs/core/Misc/coroutine.js")>]
    let makeAsyncFunction: MakeAsyncFunction = jsNative

    [<StringEnum; RequireQualifiedAccess>]
    type AccessorDecoratorKind = | [<CompiledName("accessor")>] Accessor
    [<StringEnum; RequireQualifiedAccess>]
    type MethodDecoratorKind = | [<CompiledName("method")>] Method

    [<AllowNullLiteral>]
    type AccessorDecoratorAccess<'This, 'V> =
        abstract has: value: 'This -> bool
        abstract get: value: 'This -> 'V
        abstract set: value: 'This * newValue: 'V -> unit
    [<AllowNullLiteral>]
    type MethodDecoratorAccess<'This, 'Method> =
        abstract has: value: 'This -> bool
        abstract get: value: 'This -> 'Method
    [<AllowNullLiteral>]
    type ClassAccessorDecoratorTarget<'This, 'V> =
        abstract get: ThisCallable0<'This, 'V> with get
        abstract set: ThisCallable1<'This, 'V, unit> with get
    [<AllowNullLiteral>]
    type ClassAccessorDecoratorContext<'This, 'V> =
        abstract kind: AccessorDecoratorKind with get
        abstract name: U2<string, BrowserSymbol> with get
        abstract access: AccessorDecoratorAccess<'This, 'V> with get
        abstract ``static``: bool with get
        abstract ``private``: bool with get
        abstract addInitializer: initializer: ThisCallable0<'This, unit> -> unit
        abstract metadata: BrowserDecoratorMetadataObject with get
    [<AllowNullLiteral>]
    type ClassAccessorDecoratorResult<'This, 'V> =
        abstract get: ThisCallable0<'This, 'V> option with get, set
        abstract set: ThisCallable1<'This, 'V, unit> option with get, set
        abstract init: ThisCallable1<'This, 'V, 'V> option with get, set
    [<AllowNullLiteral>]
    type AccessorDecorator<'This, 'V> =
        [<Emit("$0($1...)")>] abstract Invoke: value: ClassAccessorDecoratorTarget<'This, 'V> * context: ClassAccessorDecoratorContext<'This, 'V> -> ClassAccessorDecoratorResult<'This, 'V>
    [<AllowNullLiteral>]
    type AccessorDecoratorFactory =
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'V>: callback: string * ?targetKey: string option -> AccessorDecorator<'This, 'V>
    [<Import("expandToProperty", "@babylonjs/core/Misc/decorators.js")>]
    let expandToProperty: AccessorDecoratorFactory = jsNative
    [<Import("addAccessorsForMaterialProperty", "@babylonjs/core/Misc/decorators.js")>]
    let addAccessorsForMaterialProperty: AccessorDecoratorFactory = jsNative

    [<AllowNullLiteral>]
    type ClassMethodDecoratorContext<'This, 'Method> =
        abstract kind: MethodDecoratorKind with get
        abstract name: U2<string, BrowserSymbol> with get
        abstract access: MethodDecoratorAccess<'This, 'Method> with get
        abstract ``static``: bool with get
        abstract ``private``: bool with get
        abstract addInitializer: initializer: ThisCallable0<'This, unit> -> unit
        abstract metadata: BrowserDecoratorMetadataObject with get

    [<AllowNullLiteral>]
    type MethodDecorator0<'This, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable0<'This, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable0<'This, 'R>> -> ThisCallable0<'This, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory0<'This, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable0<'This, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable0<'This, 'R>> -> ThisCallable0<'This, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator1<'This, 'A1, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable1<'This, 'A1, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable1<'This, 'A1, 'R>> -> ThisCallable1<'This, 'A1, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory1<'This, 'A1, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable1<'This, 'A1, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable1<'This, 'A1, 'R>> -> ThisCallable1<'This, 'A1, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator2<'This, 'A1, 'A2, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable2<'This, 'A1, 'A2, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable2<'This, 'A1, 'A2, 'R>> -> ThisCallable2<'This, 'A1, 'A2, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory2<'This, 'A1, 'A2, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable2<'This, 'A1, 'A2, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable2<'This, 'A1, 'A2, 'R>> -> ThisCallable2<'This, 'A1, 'A2, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator3<'This, 'A1, 'A2, 'A3, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable3<'This, 'A1, 'A2, 'A3, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable3<'This, 'A1, 'A2, 'A3, 'R>> -> ThisCallable3<'This, 'A1, 'A2, 'A3, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory3<'This, 'A1, 'A2, 'A3, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable3<'This, 'A1, 'A2, 'A3, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable3<'This, 'A1, 'A2, 'A3, 'R>> -> ThisCallable3<'This, 'A1, 'A2, 'A3, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator4<'This, 'A1, 'A2, 'A3, 'A4, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R>> -> ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory4<'This, 'A1, 'A2, 'A3, 'A4, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R>> -> ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>> -> ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>> -> ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>> -> ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>> -> ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>> -> ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>> -> ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>> -> ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>> -> ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>> -> ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>> -> ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>

    [<AllowNullLiteral>]
    type MethodDecorator10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>> -> ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilterFactory10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> =
        [<Emit("$0($1...)")>] abstract Invoke: originalMethod: ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>> -> ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>

    [<AllowNullLiteral>]
    type NativeOverrideFilter =
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'R>: predicate: Predicate0 -> NativeOverrideFilterFactory0<'This, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'R>: predicate: Predicate1<'A1> -> NativeOverrideFilterFactory1<'This, 'A1, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'R>: predicate: Predicate2<'A1, 'A2> -> NativeOverrideFilterFactory2<'This, 'A1, 'A2, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'R>: predicate: Predicate3<'A1, 'A2, 'A3> -> NativeOverrideFilterFactory3<'This, 'A1, 'A2, 'A3, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'R>: predicate: Predicate4<'A1, 'A2, 'A3, 'A4> -> NativeOverrideFilterFactory4<'This, 'A1, 'A2, 'A3, 'A4, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>: predicate: Predicate5<'A1, 'A2, 'A3, 'A4, 'A5> -> NativeOverrideFilterFactory5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>: predicate: Predicate6<'A1, 'A2, 'A3, 'A4, 'A5, 'A6> -> NativeOverrideFilterFactory6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>: predicate: Predicate7<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7> -> NativeOverrideFilterFactory7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>: predicate: Predicate8<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8> -> NativeOverrideFilterFactory8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>: predicate: Predicate9<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9> -> NativeOverrideFilterFactory9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>: predicate: Predicate10<'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10> -> NativeOverrideFilterFactory10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>

    [<AllowNullLiteral>]
    type NativeOverride =
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'R>: originalMethod: ThisCallable0<'This, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable0<'This, 'R>> -> ThisCallable0<'This, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'R>: originalMethod: ThisCallable1<'This, 'A1, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable1<'This, 'A1, 'R>> -> ThisCallable1<'This, 'A1, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'R>: originalMethod: ThisCallable2<'This, 'A1, 'A2, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable2<'This, 'A1, 'A2, 'R>> -> ThisCallable2<'This, 'A1, 'A2, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'R>: originalMethod: ThisCallable3<'This, 'A1, 'A2, 'A3, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable3<'This, 'A1, 'A2, 'A3, 'R>> -> ThisCallable3<'This, 'A1, 'A2, 'A3, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'R>: originalMethod: ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R>> -> ThisCallable4<'This, 'A1, 'A2, 'A3, 'A4, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>: originalMethod: ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>> -> ThisCallable5<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>: originalMethod: ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>> -> ThisCallable6<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>: originalMethod: ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>> -> ThisCallable7<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>: originalMethod: ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>> -> ThisCallable8<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>: originalMethod: ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>> -> ThisCallable9<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'R>
        [<Emit("$0($1...)")>] abstract Invoke<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>: originalMethod: ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R> * context: ClassMethodDecoratorContext<'This, ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>> -> ThisCallable10<'This, 'A1, 'A2, 'A3, 'A4, 'A5, 'A6, 'A7, 'A8, 'A9, 'A10, 'R>
        abstract filter: NativeOverrideFilter with get
    [<Import("nativeOverride", "@babylonjs/core/Misc/decorators.js")>]
    let nativeOverride: NativeOverride = jsNative

    [<AllowNullLiteral>]
    type ImageProcessingMixinMembers =
        abstract _imageProcessingConfiguration: ImageProcessingConfiguration with get, set
        abstract imageProcessingConfiguration: ImageProcessingConfiguration with get, set
        abstract _imageProcessingObserver: Observer<ImageProcessingConfiguration> option with get, set
        abstract _attachImageProcessingConfiguration: configuration: ImageProcessingConfiguration option -> unit
        abstract cameraColorCurvesEnabled: bool with get, set
        abstract cameraColorGradingEnabled: bool with get, set
        abstract cameraToneMappingEnabled: bool with get, set
        abstract cameraExposure: float with get, set
        abstract cameraContrast: float with get, set
        abstract cameraColorGradingTexture: BaseTexture option with get, set
        abstract cameraColorCurves: ColorCurves option with get, set
    [<AllowNullLiteral>]
    type ImageProcessingPushMaterial =
        inherit PushMaterial
        inherit ImageProcessingMixinMembers
    [<AllowNullLiteral>]
    type ImageProcessingPushMaterialStatic =
        [<EmitConstructor>] abstract Create: name: string * ?scene: Scene * ?storeEffectOnSubMeshes: bool * ?forceGLSL: bool -> ImageProcessingPushMaterial
    [<AllowNullLiteral>]
    type ImageProcessingMixinBinding =
        [<Emit("$0($1)")>] abstract Invoke: ``base``: PushMaterialStatic -> ImageProcessingPushMaterialStatic
    [<Import("ImageProcessingMixin", "@babylonjs/core/Materials/imageProcessing.js")>]
    let ImageProcessingMixin: ImageProcessingMixinBinding = jsNative

    [<AllowNullLiteral>]
    type ImageProcessingDefinesMixinMembers =
        inherit IImageProcessingConfigurationDefines

    [<AllowNullLiteral>]
    type ImageProcessingDefinesMaterialDefines =
        inherit MaterialDefines
        inherit ImageProcessingDefinesMixinMembers
    [<AllowNullLiteral>]
    type ImageProcessingDefinesPBRMaterialDefinesBase =
        inherit PBRMaterialDefinesBase
        inherit ImageProcessingDefinesMixinMembers
    [<AllowNullLiteral>]
    type ImageProcessingDefinesStandardMaterialDefinesBase =
        inherit StandardMaterialDefinesBase
        inherit ImageProcessingDefinesMixinMembers
    [<AllowNullLiteral>]
    type ImageProcessingDefinesOpenPBRMaterialDefinesWithEnvLighting =
        inherit OpenPBRMaterialDefinesWithEnvLighting
        inherit ImageProcessingDefinesMixinMembers
    [<AllowNullLiteral>]
    type ImageProcessingDefinesNodeMaterialDefinesBase =
        inherit NodeMaterialDefinesBase
        inherit ImageProcessingDefinesMixinMembers
    [<AllowNullLiteral>]
    type ImageProcessingDefinesMaterialDefinesStatic =
        [<EmitConstructor>] abstract Create: ?externalProperties: MaterialDefinesConstructor19Parameter1Object -> ImageProcessingDefinesMaterialDefines
    [<AllowNullLiteral>]
    type ImageProcessingDefinesPBRMaterialDefinesBaseStatic =
        [<EmitConstructor>] abstract Create: ?externalProperties: MaterialDefinesConstructor19Parameter1Object -> ImageProcessingDefinesPBRMaterialDefinesBase
    [<AllowNullLiteral>]
    type ImageProcessingDefinesStandardMaterialDefinesBaseStatic =
        [<EmitConstructor>] abstract Create: ?externalProperties: MaterialDefinesConstructor19Parameter1Object -> ImageProcessingDefinesStandardMaterialDefinesBase
    [<AllowNullLiteral>]
    type ImageProcessingDefinesOpenPBRMaterialDefinesWithEnvLightingStatic =
        [<EmitConstructor>] abstract Create: ?externalProperties: MaterialDefinesConstructor19Parameter1Object -> ImageProcessingDefinesOpenPBRMaterialDefinesWithEnvLighting
    [<AllowNullLiteral>]
    type ImageProcessingDefinesNodeMaterialDefinesBaseStatic =
        [<EmitConstructor>] abstract Create: ?externalProperties: MaterialDefinesConstructor19Parameter1Object -> ImageProcessingDefinesNodeMaterialDefinesBase
    [<AllowNullLiteral>]
    type ImageProcessingDefinesMixinBinding =
        [<Emit("$0($1)")>] abstract Invoke: ``base``: MaterialDefinesStatic -> ImageProcessingDefinesMaterialDefinesStatic
        [<Emit("$0($1)")>] abstract Invoke: ``base``: PBRMaterialDefinesBaseStatic -> ImageProcessingDefinesPBRMaterialDefinesBaseStatic
        [<Emit("$0($1)")>] abstract Invoke: ``base``: StandardMaterialDefinesBaseStatic -> ImageProcessingDefinesStandardMaterialDefinesBaseStatic
        [<Emit("$0($1)")>] abstract Invoke: ``base``: OpenPBRMaterialDefinesWithEnvLightingStatic -> ImageProcessingDefinesOpenPBRMaterialDefinesWithEnvLightingStatic
        [<Emit("$0($1)")>] abstract Invoke: ``base``: NodeMaterialDefinesBaseStatic -> ImageProcessingDefinesNodeMaterialDefinesBaseStatic
    [<Import("ImageProcessingDefinesMixin", "@babylonjs/core/Materials/imageProcessingConfiguration.defines.js")>]
    let ImageProcessingDefinesMixin: ImageProcessingDefinesMixinBinding = jsNative

    [<AllowNullLiteral>]
    type UVDefinesMixinMembers =
        abstract MAINUV1: bool with get, set
        abstract MAINUV2: bool with get, set
        abstract MAINUV3: bool with get, set
        abstract MAINUV4: bool with get, set
        abstract MAINUV5: bool with get, set
        abstract MAINUV6: bool with get, set
        abstract UV1: bool with get, set
        abstract UV2: bool with get, set
        abstract UV3: bool with get, set
        abstract UV4: bool with get, set
        abstract UV5: bool with get, set
        abstract UV6: bool with get, set
    [<AllowNullLiteral>]
    type UVDefinesMaterialDefines =
        inherit MaterialDefines
        inherit UVDefinesMixinMembers
    [<AllowNullLiteral>]
    type UVDefinesMaterialDefinesStatic =
        [<EmitConstructor>] abstract Create: ?externalProperties: MaterialDefinesConstructor19Parameter1Object -> UVDefinesMaterialDefines
    [<AllowNullLiteral>]
    type UVDefinesMixinBinding =
        [<Emit("$0($1)")>] abstract Invoke: ``base``: MaterialDefinesStatic -> UVDefinesMaterialDefinesStatic
    [<Import("UVDefinesMixin", "@babylonjs/core/Materials/uv.defines.js")>]
    let UVDefinesMixin: UVDefinesMixinBinding = jsNative
