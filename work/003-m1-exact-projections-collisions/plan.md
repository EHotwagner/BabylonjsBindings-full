---
schemaVersion: 1
workId: 003-m1-exact-projections-collisions
title: M1 Exact Projections Collisions
stage: plan
changeTier: tier1
status: planned
sourceSpec: work/003-m1-exact-projections-collisions/spec.md
sourceClarifications: work/003-m1-exact-projections-collisions/clarifications.md
sourceChecklist: work/003-m1-exact-projections-collisions/checklist.md
publicOrToolFacingImpact: true
---

# M1 Exact Projections Collisions Plan

Prose status: planned

## Source Snapshot
- spec: work/003-m1-exact-projections-collisions/spec.md sha256:067cc23aa414e37db79119ac27c1037beb27720328ba129f4c54b1f61279fe19 schemaVersion:1
- clarifications: work/003-m1-exact-projections-collisions/clarifications.md sha256:21cdb7e204d81acda1d36e5faa1d63e9edd5225533e89820cb29c886bcef72fe schemaVersion:1
- checklist: work/003-m1-exact-projections-collisions/checklist.md sha256:66ade24a9c46c63fe09fb29cf3124bf92c7c79bb4105c23479b902d13657d8f0 schemaVersion:1

## Plan Scope
- Add one curated M1 projection layer plus a deterministic exact-projection manifest/checker sourced from the locked declarations.
- Extend compile fixtures, Fable runtime smoke, emitted-import checks, coverage generation, and clean-consumer package proof for exactly the fifteen exports.
- Keep generated candidates as comparison input only and preserve all M2–M6 blocked dispositions.

## Plan Decisions
- PD-001 [AC-001] [FR-001] complete: Promote aliases over reviewed support shapes and prove normalized declaration/support structural digests equal without runtime imports.
- PD-002 [AC-002] [FR-002] complete: Hand-curate named recursive glTF interfaces; weights inherits the exact object-accessor interface and also exposes length and __array__, never U2.
- PD-003 [AC-003] [FR-003] complete: Represent the eleven typed-array alternatives with overloads that pair a concrete constructor witness with its matching return type; retain upstream-authorized obj only for omitted-any GetMappingForKey defaults.
- PD-004 [AC-004] [FR-004] complete: Add module-qualified PhysicsEngineV1/PhysicsEngineV2 maintained names with identical runtime export names but exact distinct deep module paths.
- PD-005 [AC-005] [FR-005] complete: Add a schema-versioned M1 manifest/checker over exact package/module/name identities and require the coverage delta to be precisely the named fifteen exports.
- PD-006 [AC-006] [FR-006] complete: Exercise locked .NET/Fable compilation, emitted imports, Node runtime semantics, pack, and an external clean consumer before acceptance.

## Contract Impact
- PC-001 [PD-001] [PD-002] [PD-003] [PD-004] [PD-005] maintainedApi: Add fifteen exact public Fable binding exports and their reviewed projection manifest without changing Babylon.js runtime export names.

## Verification Obligations
- VO-001 [PD-001] [PD-002] [PD-003] [PD-004] [PD-005] [PD-006] [PC-001] semanticTest: Run deterministic manifest generation/check, structural/correlation compile fixtures, exact emitted-import checks, Node smoke, coverage exact-count/delta assertions, locked solution build, pack, and clean-consumer execution.

## Performance Intent
No performance intent is declared for this work item.

## Migration Posture
- PM-001 [PC-001] additivePatch: Additive binding exports require a patch release after the implementation merge; no consumer migration is required.

## Generated View Impact
- GV-001 [PD-005] projectionManifest: The M1 projection manifest and coverage report regenerate deterministically; SDD readiness views refresh after authored lifecycle changes.

## Accepted Deferrals
No accepted plan deferrals recorded.

## Planning Findings
No blocking planning findings recorded.

## Advisory Notes
- Optional Governance pointers remain compatibility facts only.

## Lifecycle Notes
- Next lifecycle action: `fsgg-sdd tasks --work 003-m1-exact-projections-collisions`.
