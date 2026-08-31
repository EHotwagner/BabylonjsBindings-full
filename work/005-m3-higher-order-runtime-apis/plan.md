---
schemaVersion: 1
workId: 005-m3-higher-order-runtime-apis
title: M3 Higher Order Runtime Apis
stage: plan
changeTier: tier1
status: planned
sourceSpec: work/005-m3-higher-order-runtime-apis/spec.md
sourceClarifications: work/005-m3-higher-order-runtime-apis/clarifications.md
sourceChecklist: work/005-m3-higher-order-runtime-apis/checklist.md
publicOrToolFacingImpact: true
---

# M3 Higher Order Runtime Apis Plan

Prose status: planned

## Source Snapshot
- spec: work/005-m3-higher-order-runtime-apis/spec.md sha256:900156d50fd35d0289e5aa233f632f6678ff4193e4ced70ed310b314462e7ea1 schemaVersion:1
- clarifications: work/005-m3-higher-order-runtime-apis/clarifications.md sha256:efc2857ad48a9e96274b3f0db133bc3031b7aa775882111849a459db487e70f0 schemaVersion:1
- checklist: work/005-m3-higher-order-runtime-apis/checklist.md sha256:61c1b727a9d14f7cd5e2d43a46b321ff716d0cb340bc05f7c51e4b8b96ba6997 schemaVersion:1

## Plan Scope
- Add one deterministic declaration-arity scanner and reviewed M3 manifest/proposal, then curate maintained higher-order runtime projections.
- Add compile-positive and compile-negative fixtures, Fable emitted-call assertions, Node and Chromium runtime tests, exact coverage, and clean package-consumer proof.
- Keep implementation and release PRs separate; only the release PR marks roadmap M3 complete after code-head CI is green.

## Plan Decisions
- PD-001 [DEC-001] [AC-001] [FR-001] complete: `scripts/scan-m3-callable-arity.mjs` verifies every locked digest, records proposed 0–8 versus adopted 0–10, and keeps arity 17 as non-scoped context.
- PD-002 [DEC-001] [AC-002] [FR-002] complete: Generate named sync/async coroutine factory and returned-callable interfaces for every arity 0–10 with one type variable per parameter and no parameter array.
- PD-003 [DEC-003] [AC-003] [FR-003] complete: Declare exact TC39 accessor target/context/result interfaces and bind accessor decorator factories with `Nullable<string>` optional key semantics.
- PD-004 [DEC-003] [AC-004] [FR-004] complete: Bind `nativeOverride` as one imported callable interface with callable `filter`; arity-index method decorators and explicit `Emit("$0.call($1, ...)")` helpers preserve JavaScript `this`.
- PD-005 [DEC-002] [AC-005] [FR-005] complete: Generate deterministic named added-member interfaces plus both-member results specialized to PushMaterial, MaterialDefines, and each locked composed defines base without U2 or unconstrained obj.
- PD-006 [AC-006] [FR-006] complete: Extend compile tests and negative fixtures, Fable-emit representative low/boundary arities, inspect imports/calls, and execute exact upstream modules in Node and Chromium.
- PD-007 [AC-007] [FR-007] complete: Extend coverage policy with the reviewed M3 manifest and require exactly eight disposition changes and totals 4,287/35/1/0.
- PD-008 [AC-008] [FR-008] complete: After implementation acceptance, pack 0.1.4 into the local feed and prove an outside clean consumer through Fable, imports, Node, and Chromium before the release PR.

## Contract Impact
- PC-001 [PD-001] [PD-002] [PD-003] [PD-004] [PD-005] publicSurface: Add stable arity-indexed callable interfaces, exact decorator projections, callable nativeOverride.filter, named mixin results/specializations, and `analysis/m3-higher-order-runtime-manifest.json` without renaming existing APIs.

## Verification Obligations
- VO-001 [PD-001] [PD-002] [PD-003] [PD-004] [PD-005] [PD-006] [PD-007] [PD-008] [PC-001] runtimeMatrix: Require deterministic generation, exact compile rejections, emitted JavaScript call inspection, Node, Chromium, coverage, locked drift, package, and clean-consumer evidence.

## Performance Intent
No performance intent is declared for this work item.

## Migration Posture
- PM-001 [PC-001] additive: Public arity family names are additive and stable, the Babylon.js 9.19.0 declaration lock is unchanged, and the NuGet patch version advances from 0.1.3 to 0.1.4 only after acceptance.

## Generated View Impact
- GV-001 [PD-001] [PD-007] reviewOnly: The scanner, proposal, coverage, SDD readiness, feedback, critique, and release receipt regenerate deterministically or validate exact immutable state; generated candidates never overwrite maintained source.

## Accepted Deferrals
No accepted plan deferrals recorded.

## Planning Findings
No blocking planning findings recorded.

## Advisory Notes
- Optional Governance pointers remain compatibility facts only.

## Lifecycle Notes
- Next lifecycle action: `fsgg-sdd tasks --work 005-m3-higher-order-runtime-apis`.
