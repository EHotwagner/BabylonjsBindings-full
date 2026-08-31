---
schemaVersion: 1
workId: 003-m1-exact-projections-collisions
title: M1 exact existing projections and collisions
stage: charter
changeTier: tier1
status: chartered
policyPointers:
  - .fsgg/sdd.yml
  - .fsgg/agents.yml
  - .fsgg/policy.yml
  - .fsgg/capabilities.yml
  - .fsgg/tooling.yml
---

# M1 exact existing projections and collisions Charter

## Identity
- Complete roadmap M1 by promoting exactly fifteen exact Babylon.js 9.19.0 exports from blocked to typed.

## Principles
- Generated candidates remain review-only; maintained curated F# and reviewed manifests are authoritative.
- Preserve exact type-only/runtime boundaries, deep imports, constructor/return correlations, and module-qualified collisions.
- Model intersections as both-member interfaces, never erased unions, and use `obj` only for upstream `any`/`unknown`/`Object` boundaries.

## Scope Boundaries
- In: camera aliases (6), typed-array constructor/factory (2), physics v1/v2 collisions (2), glTF options/tree/mapping (4), and `deepMerge` (1), plus tests, evidence, critique, feedback, roadmap, package/release proof.
- Out: every M2–M6 export, Babylon.js/toolchain pin changes, lossy projections, and direct pushes to main.

## Policy Pointers
- Honor `.fsgg/constitution.md` principles I, II, III, VI, VII, and VIII.
- Follow `docs/2026-08-31T072958Z-missing-exports-design-roadmap.md` and the fable bindings/interop/testing/project contracts.

## Lifecycle Notes
- Tier 1 maintained public binding/API and package change.
- `game_functionality: false`.
- M1 may complete only at exactly 4,252 typed, 70 blocked, one runtime-only, and zero lossy exports; a contrary locked-source count blocks completion.
- Next lifecycle action: `fsgg-sdd specify --work 003-m1-exact-projections-collisions`.
