---
title: Missing Babylon.js exports — binding design and completion roadmap
category: Design
categoryindex: 4
index: 1
description: Evidence-backed analysis and dependency-ordered roadmap for the remaining Babylon.js 9.19.0 Fable exports.
date: 2026-08-31T07:29:58Z
---

# Missing Babylon.js exports — binding design and completion roadmap

The roadmap is complete. The maintained binding now classifies all 4,323 locked exports: 4,322 are typed, one loader-registration side effect is intentionally runtime-only, and none are blocked or lossy. The historical analysis below records the obstacles, chosen Fable projections, implementation order, and evidence used to move the final exports from `blocked` to `typed`.

## Scope and authority

This analysis uses the following sources of truth:

- `declaration-lock.json`: 2,928 reachable modular declaration files from `@babylonjs/core@9.19.0` and `@babylonjs/loaders@9.19.0`.
- `coverage-and-drift.json`: the 4,323-export inventory and current disposition of every export.
- The modular declarations under `node_modules/@babylonjs/core` and `node_modules/@babylonjs/loaders`.
- The maintained projections in `src/BabylonjsBindings` and review-only proposals in `generated-candidates`.
- Generator `--diagnose` output for aliases, interfaces, classes, functions, and variables.

The 14 entries in `unsupportedConstructs` are legacy `ts2fable` comparison diagnostics over monolithic bundles. Their occurrence counts are not counts of missing exports. They remain useful regression evidence, but the 85 modular exports below are the implementation roadmap.

## Invariants

Every roadmap item must preserve these rules:

1. Generated output remains a proposal. It never overwrites maintained source or advances the declaration lock.
2. `obj` is permitted only when the authoritative upstream declaration says `any`, `unknown`, or `Object` with no stronger contract.
3. A generic, conditional, mapped, or intersection type is not complete merely because its runtime representation is JavaScript-compatible. Its compile-time correlations must be preserved or represented by exact finite specializations.
4. Type-only exports must not acquire fictitious runtime imports. Conversely, runtime classes, functions, variables, and namespace objects require exact deep-import evidence.
5. Module-qualified identities must remain distinct when names collide, notably the v1 and v2 `PhysicsEngine` classes and the glTF 1.0/2.0 namespace members.
6. Optional (`undefined`) and nullable (`null`) values remain distinct where the declaration distinguishes them.
7. An export becomes `typed` only after maintained F# compilation, Fable emission, import resolution where applicable, runtime proof where meaningful, coverage regeneration, and clean-consumer package proof.

## Inventory

| Family | Count | Missing exports |
|---|---:|---|
| Camera input mapper | 6 | `InputMapEntry`, `InteractionName`, `KeyboardInputMapEntry`, `PointerInputMapEntry`, `TouchInputMapEntry`, `WheelInputMapEntry` |
| Core utility types | 27 | `Add`, `Concat`, `Constructor`, `Decrement`, `DeepImmutable`, `DeepImmutableObject`, `First`, `Flatten`, `FlattenArray`, `FlattenTuple`, `FromLength`, `Immutable`, `Increment`, `IsTuple`, `Last`, `Length`, `Member`, `NonNullableFields`, `Pop`, `Push`, `Remove`, `Shift`, `Subtract`, `Tuple`, `TypedArrayConstructor`, `Unshift`, `WritableObject` |
| Device input | 7 | `DeviceInput`, `DeviceSourceEvent`, `DeviceSourceType`, `IObservableManager`, `DeviceSource`, `DeviceSourceManager`, `InternalDeviceSourceManager` |
| FlowGraph | 9 | `AssetType`, `GetFlowGraphAssetWithType`, `FlowGraphGetAssetBlock`, `FlowGraphGetPropertyBlock`, `IFlowGraphGetPropertyBlockConfiguration`, `FlowGraphJsonPointerParserBlock`, `FlowGraphSwitchBlock`, `FlowGraphSetPropertyBlock`, `IFlowGraphSetPropertyBlockConfiguration` |
| Material mixins | 3 | `ImageProcessingMixin`, `ImageProcessingDefinesMixin`, `UVDefinesMixin` |
| Math/vector/tensor | 7 | `Dimension`, `Tensor`, `TensorLike`, `TensorStatic`, `ValueOfTensor`, `Vector`, `VectorStatic` |
| Miscellaneous higher-order functions | 6 | `makeAsyncFunction`, `makeSyncFunction`, `addAccessorsForMaterialProperty`, `expandToProperty`, `nativeOverride`, `deepMerge` |
| Physics | 2 | `PhysicsEngine` from v1 and `PhysicsEngine` from v2 |
| Typed-array factory | 1 | `CreateAlignedTypedArray` |
| XR and VR | 11 | `WebXRFeatureNameType`, `IWebXRFeatureNameTypeMap`, `IWebXRFeatureNameOptionsMap`, `ResolveWebXRFeature`, `ResolveWebXRFeatureOptions`, `WebXRFeaturesManager`, `WebXRExperienceHelper`, `WebXREnterExitUI`, `WebXRDefaultExperience`, `VRExperienceHelper`, `HandConstraintBehavior` |
| glTF loaders | 6 | `GLTF1`, `GLTF2`, `GetMappingForKey`, `IGLTFObjectModelTree`, `IGLTFObjectModelTreeNodesObject`, `GLTFLoaderOptions` |
| **Total** | **85** | |

## Dependency shape

The blocked graph has a small number of load-bearing roots:

```text
Core tuple/mapped utilities ──> Tensor/Vector

AssetType ──> FlowGraph configurations ──> FlowGraph property classes
         └──> GetFlowGraphAssetWithType / FlowGraphGetAssetBlock

WebXR feature maps ──> ResolveWebXRFeature(*) ──> WebXRFeaturesManager
                    └───────────────────────────> WebXRExperienceHelper
                                                  ├──> WebXREnterExitUI
                                                  ├──> WebXRDefaultExperience ──> VRExperienceHelper
                                                  └──> HandConstraintBehavior

DeviceInput / DeviceSourceEvent ──> DeviceSource
DeviceSourceType ──────────────────> IObservableManager
                                  ├──> InternalDeviceSourceManager
                                  └──> DeviceSourceManager

IGLTFObjectModelTreeNodesObject ──> IGLTFObjectModelTree ──> GLTF2 facade
```

This graph is why promoting a dependent class in isolation is unsafe. For example, `HandConstraintBehavior` compiles only after both `WebXRExperienceHelper` and `WebXRFeaturesManager` are maintained.

## Projection mechanisms to add

### 1. Export aliases over reviewed support projections

Several exact shapes already exist under internal `Browser*` or support-only names. Add exported aliases and manifest identities instead of regenerating them:

```fsharp
type PointerInputMapEntry<'TInteraction> =
    BrowserPointerInputMapEntry<'TInteraction>

type InputMapEntry<'TInteraction> =
    BrowserInputMapEntry<'TInteraction>

type InteractionName<'THandlers> =
    JavaScriptKeyOf<'THandlers>
```

Apply the same rule to `TypedArrayConstructor<'T>` and the existing `GLTFLoaderOptions` support class. Alias promotion is acceptable only after a structural comparison proves the support projection still covers every declaration member.

### 2. Finite dependent-type overload generation

TypeScript conditional types frequently map a finite discriminator to a result type. F# cannot directly express `AssetType<T>` or `ResolveWebXRFeature<T>`, but the exact domain is finite and locked. Generate one overload per discriminator and assert that the overload matrix covers every source map key.

For example, FlowGraph has six asset kinds. The maintained source already defines six singleton discriminator types. `GetFlowGraphAssetWithType` can therefore expose six exact calls:

```fsharp
abstract Invoke:
    assets: IAssetContainer *
    assetType: FlowGraphMeshAssetType *
    index: float *
    ?useIndexAsUniqueId: bool -> Mesh option
```

The same generator pattern applies to:

- 8 `DeviceType` cases and their input/event result types;
- 6 `FlowGraphAssetType` cases;
- 22 `WebXRFeatureName` cases and their exact option/implementation pairs;
- 11 concrete JavaScript typed-array constructors.

The generator must fail when the upstream discriminator set changes, a map key is absent, or two keys collapse to the same F# overload signature.

### 3. Named intersection projections

Translate TypeScript intersections of object shapes to named F# interfaces with multiple inheritance. Do not use erased unions for intersections: a union means “either”, while the declaration requires “both”.

This mechanism is needed for the glTF object-model tree and the return constructors of material mixins. Inline intersections should receive deterministic names derived from their declaration identity and normalized syntax, not ordinal names that drift when declarations are reordered.

### 4. Arity-indexed callable families

`makeSyncFunction`, `makeAsyncFunction`, and decorator functions preserve heterogeneous parameter tuples. A `ParamArray<obj>` would erase those correlations. Generate callable interfaces by arity:

```text
CoroutineFactory0<'R>
CoroutineFactory1<'A,'R>
...
CoroutineFactoryN<'A,...,'R>
```

The first supported range should be arities 0–8, accompanied by a locked-closure scan proving the maximum arity actually used by Babylon.js. If a public consumer needs a higher arity, extend the ladder without changing existing names. An export cannot be called universally complete unless the accepted arity policy is recorded in coverage; until then, keep it blocked.

### 5. Closed-world mapped and tuple specializations

Universal TypeScript type functions such as `Flatten<T>`, `DeepImmutable<T>`, and `Tuple<T,N>` have no direct F# type-function equivalent. The practical exact strategy is:

1. Inventory every instantiation reachable from the locked public declarations.
2. Emit a named F# projection for each normalized instantiation.
3. Record the mapping from TypeScript expression to F# symbol in a machine-readable manifest.
4. Fail generation when an unrecognized instantiation appears.
5. Keep the generic exported utility blocked until policy explicitly accepts closed-world semantic coverage for type-only helpers.

This is stricter than replacing tuple lengths with arrays. It preserves the actual Babylon.js public closure while making the limitation visible.

### 6. Qualified collision names

Add declaration-identity-based names for the two runtime `PhysicsEngine` classes:

- `PhysicsEngineV1` importing runtime export `PhysicsEngine` from `@babylonjs/core/Physics/v1/physicsEngine.js`;
- `PhysicsEngineV2` importing runtime export `PhysicsEngine` from `@babylonjs/core/Physics/v2/physicsEngine.js`.

The collision map must use package + module + source export, never the unqualified TypeScript name.

### 7. Namespace facades

`GLTF1` and `GLTF2` are real runtime namespace objects exported by `@babylonjs/loaders/glTF/index.js`, as well as type namespaces containing 51 and 158 declaration exports respectively. Bind them in two layers:

- an F# module containing type aliases and forwarded functions/classes for compile-time discoverability;
- a runtime namespace-object interface containing only actual JavaScript exports, imported from the exact glTF index module.

Generate both layers from the TypeScript checker’s module export table. Validate all 51/158 declaration names and all runtime object keys independently.

## Family analysis and strategy

### Camera input mapper — 6 exports

**Constructs.** Four generic object intersections, one four-way discriminated union, and `keyof THandlers & string`.

**Existing assets.** `BrowserPointerInputMapEntry`, `BrowserWheelInputMapEntry`, `BrowserTouchInputMapEntry`, `BrowserKeyboardInputMapEntry`, `BrowserInputMapEntry`, and `JavaScriptKeyOf` already support the maintained `InputMapper` class.

**Strategy.** Promote public type aliases over those reviewed shapes. Preserve generic defaults in documentation and provide non-generic convenience aliases using `string`; F# callers of the generic aliases must supply the interaction type explicitly. Verify all discriminator literals and optional condition fields.

**Risk.** Low. No new runtime import is required.

### Typed-array constructor and `CreateAlignedTypedArray` — 2 exports

**Constructs.** A generic interface with three constructor overloads and a default/constrained type parameter; a function whose return type equals the constructor’s element type.

**Existing assets.** `BrowserTypedArrayConstructor<'T>` already preserves the three constructor overloads and `BYTES_PER_ELEMENT`.

**Strategy.** Promote `TypedArrayConstructor<'T>` as an alias to the reviewed support interface. Bind `CreateAlignedTypedArray` with generated overloads for each of the 11 exact typed-array alternatives in `TypedArray`, so input constructor and return value remain correlated. Do not use one unconstrained generic overload.

**Risk.** Low to medium. BigInt typed arrays need Node and browser feature checks.

### Physics engines — 2 exports

**Constructs.** Two unrelated runtime classes with the same exported name.

**Strategy.** Extend the class collision map with module-qualified `PhysicsEngineV1` and `PhysicsEngineV2` names. Generate the complete member surface and use `runtimeExport: "PhysicsEngine"` in both manifests.

**Risk.** Low. Runtime smoke can instantiate only with explicit mock/real plugins; import and static-surface checks are mandatory even if construction is not portable.

### glTF loader structures — 4 non-namespace exports

**Constructs.** A support-only abstract class re-exported as a type, deeply nested object literals, intersections with `IObjectAccessor`, generic defaults, and an unparameterized generic return using upstream `any` defaults.

**Strategy.**

- Promote the already maintained `GLTFLoaderOptions` support class as a type-only export; do not add a runtime import.
- Model `IGLTFObjectModelTreeNodesObject` with deterministic named interfaces. Translate the `weights` intersection by inheriting `IObjectAccessor<...>` and adding `length`/`__array__` members.
- Promote `IGLTFObjectModelTree` once its `nodes` dependency compiles.
- Bind `GetMappingForKey` to `IObjectAccessor<obj,obj,obj> option`; `obj` is justified here by the declaration’s omitted generic arguments whose defaults are `any`.

**Risk.** Medium. The nodes tree is large, but its shape is mechanical and compile-only.

### Device input — 7 exports

**Constructs.** Two conditional types over an 8-case numeric enum, a distributed union, and generic classes whose event/input types depend on the enum case.

**Strategy.** Generate singleton numeric discriminator types for all eight `DeviceType` values. Generate specialized device-source views and overload `DeviceSourceManager.getDeviceSource(s)` per discriminator. Use `Never` for event cases where `DeviceSourceEvent<T>` evaluates to `never`. Build `DeviceSourceType` as the erased union of all eight specialized views.

**Risk.** Medium. F# overload resolution must be tested for all enum singleton types, and the union may need nesting because Fable erased unions have an arity limit.

### FlowGraph — 9 exports

**Constructs.** A six-case conditional asset map and two generic constraints that are unions rather than nominal base types (`FlowGraphNumber` and `FlowGraphAssetType`).

**Existing assets.** Six singleton FlowGraph asset discriminator types already exist for exact overloads.

**Strategy.** Generate the six-case `AssetType` matrix first. Use it to emit overloads and specialized configuration interfaces for the asset function and get/set property blocks. Split `FlowGraphSwitchBlock` into number and `FlowGraphInteger` views that import the same runtime class. Generate six specialized `FlowGraphJsonPointerParserBlock` views for its constrained asset discriminator.

**Risk.** Medium. A broad `U6` return is acceptable only as an additional convenience member; it cannot replace the exact discriminator overloads.

### XR and VR — 11 exports

**Constructs.** A 22-key computed-property map, indexed access over static string literals, conditional option/result lookup, and five downstream classes.

**Strategy.** Generate a 22-row source table from `WebXRFeatureName`, `IWebXRFeatureNameTypeMap`, and `IWebXRFeatureNameOptionsMap`. From that one table emit:

- the exact `WebXRFeatureNameType` string union;
- both map interfaces with compiled property names;
- exact option and result aliases;
- 22 overloads each for `enableFeature` and `getEnabledFeature`;
- the remaining non-dependent manager members.

After `WebXRFeaturesManager` passes, promote `WebXRExperienceHelper`, then `WebXREnterExitUI` and `HandConstraintBehavior`, then `WebXRDefaultExperience`, and finally `VRExperienceHelper`.

**Risk.** Medium to high. Browser-only runtime proof requires Chromium with WebXR APIs stubbed or feature checks that do not start a physical XR session.

### Material mixins — 3 exports

**Constructs.** Higher-order constructor functions that return an anonymous constructor whose instance is the intersection of the base instance and added members.

**Strategy.** Generate named interfaces for each mixin-added instance surface and a constructor result interface. Because F# lacks arbitrary intersection types, initially provide exact specializations for every constructor base used in the locked Babylon declaration closure. Record those base/result pairs in a manifest and keep the universal generic form blocked until an erased intersection wrapper is proven sound in Fable output.

**Risk.** High. Returning `U2<Base,Mixin>` would be semantically wrong and is rejected.

### Miscellaneous higher-order functions — 6 exports

**Constructs.** Heterogeneous variadic tuples, explicit JavaScript `this`, standard ECMAScript decorator context/result interfaces, a function with a merged namespace property, and homogeneous object merging.

**Strategy.**

- Implement `deepMerge` first as a homogeneous generic ParamArray binding with an object/reference-type constraint.
- Add exact browser projections for accessor and method decorator target/context/result types.
- Represent `nativeOverride` as a callable object that also exposes its `filter` member; preserve `this` with explicit `.call` emits.
- Generate arity-indexed wrappers for `makeSyncFunction`, `makeAsyncFunction`, `expandToProperty`, `addAccessorsForMaterialProperty`, and `nativeOverride`.

**Risk.** High. Decorator semantics require emitted-JavaScript tests, not compile-only evidence.

### Core utility types — 26 remaining after typed-array promotion

**Constructs.** Recursive conditional types, tuple inference/spreads, arithmetic encoded through tuple length, mapped modifiers, recursive readonly conversion, and constructor reflection utilities.

**Strategy.** Divide into three subgroups:

1. **Tuple selectors/builders:** `First`, `Last`, `Shift`, `Pop`, `Push`, `Unshift`, `Concat`, `Remove`, `Tuple`, `FromLength`.
2. **Tuple arithmetic/flattening:** `Length`, `Increment`, `Decrement`, `Add`, `Subtract`, `Member`, `IsTuple`, `FlattenArray`, `FlattenTuple`, `Flatten`.
3. **Mapped/constructor utilities:** `Immutable`, `DeepImmutable`, `DeepImmutableObject`, `NonNullableFields`, `WritableObject`, `Constructor`.

Build a normalized instantiation registry and exact closed-world projections. Existing `DeepImmutable*`, partial, required, and readonly symbols should be incorporated rather than duplicated. Add a coverage rule that every use of one of these utilities either resolves to a reviewed projection or remains blocking.

**Risk.** Very high. These exports are primarily compile-time type functions; runtime compatibility alone provides no evidence of fidelity.

### Math/vector/tensor — 7 exports

**Constructs.** Recursive tensor dimensions, variadic tuple flattening, type extraction, self types, deep immutable inputs, and static constructors whose arity depends on tensor shape.

**Observed closure.** The pinned declarations instantiate these abstractions through `Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color3`, `Color4`, and 4×4 `Matrix`.

**Strategy.** Build this family after core utilities. Generate exact rank/shape projections for the seven observed concrete implementations, including 2-, 3-, 4-, and 16-value overloads. Retain generic structural interfaces only where every dependent operation can carry shape and flattened-coordinate witnesses without broad arrays.

**Risk.** Very high. Replacing fixed tuple lengths with `float[]` would be lossy and must not satisfy coverage.

### glTF namespace facades — 2 exports

**Constructs.** Runtime namespace objects plus type namespaces re-exporting 51 GLTF1 and 158 GLTF2 names.

**Strategy.** Generate facade modules and runtime namespace-object bindings from the checker export table. Resolve collisions through module-qualified aliases. Run both compile-time name-count checks and dynamic runtime-key checks (currently 14 GLTF1 and 114 GLTF2 runtime keys at the pinned version).

**Risk.** Medium to high because the facade is broad, but it is mechanical once all underlying exports are typed.

## Roadmap

| Milestone | Scope | Exports closed | Expected typed total | Exit criteria |
|---|---|---:|---:|---|
| [x] M0 — analysis infrastructure | Add normalized blocked-family diagnostics, dependent-map completeness checks, and instantiation registry format | 0 | 4,237 | Deterministic reports; no maintained API changes.<br>Evidence: PR #2; merge date/outcome: 2026-08-31 / squash-merged; corrective acceptance PR #3; durable SDD verdict `readiness/002-m0-analysis-infrastructure/ship-verdict.json` (`verificationReady`, `shipReady`, 8 supported/observed, 0 blockers), host check `npm run check:m0-sdd-readiness`; critique `reviews/roadmap/roadmap-missing-exports-m0-analysis-infrastructure.json`; feedback `feedback/2026-08-31-BabylonjsBindings-full.md`. |
| [x] M1 — exact existing projections and collisions | Camera input aliases (6), typed-array constructor/function (2), physics collisions (2), glTF options/tree/function (4), `deepMerge` (1) | 15 | 4,252 | Compile, import checks, Node smoke, coverage 70 blocked.<br>Evidence: implementation PR #4, 2026-08-31 squash-merged as `f930a427d7d373ad1e259be99392349d05136047`; release PR #5 with 0.1.2 package evidence `reports/m1-release.json`; critique `reviews/roadmap/roadmap-missing-exports-m1-exact-projections-collisions.json` (1 repair round, pass); feedback `feedback/2026-08-31-BabylonjsBindings-full-m1-exact-projections-collisions.md`, audit, and 4 checkpoints; durable SDD verdict `readiness/003-m1-exact-projections-collisions/ship-verdict.json`; host readiness `npm run check:m1-sdd-readiness`; exact coverage 4,252 typed / 70 blocked / 1 runtime-only / 0 lossy. |
| [x] M2 — finite dependent maps | Device input (7), FlowGraph (9), XR/VR (11) | 27 | 4,279 | Every discriminator table complete; browser XR smoke; coverage 43 blocked.<br>Evidence: implementation PR #6, 2026-08-31 squash-merged as `0962dc3f6238ccf4927e43608345e32a8fe3b1ca`; release PR #7 with 0.1.3 package evidence `reports/m2-release.json`; critique `reviews/roadmap/roadmap-missing-exports-m2-finite-dependent-maps.json` (2 repair rounds, pass); feedback `feedback/2026-08-31-BabylonjsBindings-full-m2-finite-dependent-maps.md` and audit; durable SDD verdict `readiness/004-m2-finite-dependent-maps/ship-verdict.json`; host readiness `npm run check:m2-sdd-readiness`; exact coverage 4,279 typed / 43 blocked / 1 runtime-only / 0 lossy. |
| [x] M3 — higher-order runtime APIs | Remaining miscellaneous functions (5) and material mixins (3) | 8 | 4,287 | Arity policy recorded; emitted decorator/mixin runtime tests; coverage 35 blocked.<br>Evidence: implementation PR #9 squash-merged as `4c1b5b73e02b4e2a137e2a3c2f9ecb0842278629`; release PR #10 with 0.1.4 package evidence `reports/m3-release.json`; critique `reviews/roadmap/roadmap-missing-exports-m3-higher-order-runtime-apis.json` (1 repair round, pass); feedback `feedback/2026-08-31-BabylonjsBindings-full-m3-higher-order-runtime-apis.md` and audit; durable SDD verdict `readiness/005-m3-higher-order-runtime-apis/ship-verdict.json`, host command `npm run check:m3-sdd-readiness`; arity policy 0–10 with broader fixed-callable context 17; exact coverage 4,287 typed / 35 blocked / 1 runtime-only / 0 lossy. |
| [x] M4 — type-function core | Remaining utility types (26), then tensor/vector (7) | 33 | 4,320 | Closed-world registry records 155 locked instantiations and seven concrete shapes; wrong-length coordinates are rejected; 2 blocked remain.<br>Evidence: `analysis/m4-type-function-core-manifest.json`, `src/BabylonjsBindings/m4-type-function-core-coverage-manifest.json`, `generated-candidates/M4TypeFunctionCore.proposal.fs`, and the M6 release matrix. |
| [x] M5 — namespace closure | GLTF1 and GLTF2 facades | 2 | 4,322 typed + 1 runtime-only | Checker-derived facades expose 51/158 declaration names and exact runtime interfaces expose 14/114 keys; zero blocked/lossy.<br>Evidence: `analysis/m5-gltf-namespace-manifest.json`, `src/BabylonjsBindings/m5-gltf-namespace-coverage-manifest.json`, `generated-candidates/M5GltfNamespaces.proposal.fs`, and `runtime/node/m5-gltf-namespaces.mjs`. |
| [x] M6 — release evidence | Clean packed consumer, Node, Chromium, import resolution, drift and full-coverage gates | 0 | unchanged | Package 0.2.0 passes all 21 release checks, including complete coverage, exact emitted imports/calls, Node, deterministic Chromium XR, and isolated clean consumption.<br>Evidence: `reports/m6-release.json`, `reports/m6-clean-consumer.json`, and `artifacts/release-package/BabylonjsBindings.0.2.0.nupkg`. |

The numerical targets assume no upstream pin change. Any Babylon.js update restarts the declaration-lock and blocked-family audit before roadmap counts are adjusted.

## Batch implementation protocol

Each milestone should be split into dependency-closed review batches. For every batch:

1. Extend the relevant proposal generator and emit a machine-readable projection manifest.
2. Regenerate proposals twice and require byte identity.
3. Generate a compile preview without touching maintained source.
4. Review imports, overloads, nullability, generic correlations, callbacks, static companions, and namespace collisions.
5. Fable-compile representative calls and inspect emitted imports/calls.
6. Execute Node tests and Chromium tests for browser-only semantics.
7. Promote only the reviewed batch and regenerate `SimpleTypes.fs` when recursive types are involved.
8. Regenerate coverage and assert the exact expected decrement in blocked exports.
9. Pack the NuGet library and consume it from a clean project with exact npm runtime dependencies.
10. Update this roadmap’s milestone status and record evidence paths.

## Required test matrix

| Concern | Minimum proof |
|---|---|
| Alias/support promotion | F# compile test assigning both exported and support names; manifest structural digest equality |
| Dependent discriminator maps | One positive compile case per discriminator; negative compile fixtures for mismatched options/results; table-completeness assertion |
| Generic callbacks | Fable emitted-call snapshot for every supported arity; runtime argument/return round trip |
| Intersections | Compile access to every constituent member on one value; no `U2` or `obj` substitution |
| Mapped readonly/writable types | Compile fixtures that allow/deny setters as upstream does |
| Tuple/tensor shape | Arity-specific constructor and method fixtures; negative wrong-length fixtures |
| Runtime collisions | Dynamic import of both exact modules and verification of `runtimeExport` |
| XR | Chromium execution with deterministic WebXR stubs; no physical device dependency |
| glTF namespaces | Checker export-name equality plus dynamic runtime-key/import checks |
| Packaging | Clean consumer installs packed NuGet plus exact npm dependencies, Fable-compiles, resolves imports, and runs |

Negative compile fixtures are important for the remaining work: successful compilation proves availability, but only rejected mismatches prove that dependent correlations were not broadened.

## Decisions and rejected shortcuts

- **Decision:** prefer finite exact overloads for locked discriminator maps. **Rejected:** one generic method returning a broad erased union, because it loses the input/result relationship.
- **Decision:** use named multiple-inheritance interfaces for intersections. **Rejected:** `U2` projections, because unions do not guarantee both member sets.
- **Decision:** retain type-only exports without runtime imports. **Rejected:** importing abstract/type-only declarations from JavaScript.
- **Decision:** qualify duplicate runtime names by module identity. **Rejected:** merging v1/v2 physics surfaces under one F# type.
- **Decision:** require an instantiation registry for TypeScript type functions. **Rejected:** arrays for fixed tuples and universal `obj` fallbacks.
- **Decision:** implement namespace facades last. **Rejected:** marking a namespace typed when only its runtime object or only its type aliases are covered.

## Completion definition

The bindings are complete for Babylon.js 9.19.0 only when:

- all 4,323 exports are `typed` or intentionally `runtime-only`;
- blocked and lossy counts are zero;
- the declaration and tool locks are unchanged and verified;
- every type-level specialization is accounted for by a deterministic manifest;
- every runtime import resolves from the pinned modular packages;
- maintained .NET and Fable compilation, Node, Chromium, package, and clean-consumer evidence pass;
- no generated candidate was promoted without review.

These conditions are satisfied by the 0.2.0 release candidate. `coverage:require-complete` is green at 4,322 typed, one intentional runtime-only, zero blocked, and zero lossy exports.
