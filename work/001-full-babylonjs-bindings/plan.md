---
schemaVersion: 1
workId: 001-full-babylonjs-bindings
title: Full Babylonjs Bindings
stage: plan
changeTier: tier1
status: planned
sourceSpec: work/001-full-babylonjs-bindings/spec.md
sourceClarifications: work/001-full-babylonjs-bindings/clarifications.md
sourceChecklist: work/001-full-babylonjs-bindings/checklist.md
publicOrToolFacingImpact: true
---

# Full Babylonjs Bindings Plan

Prose status: planned

## Source Snapshot
- spec: work/001-full-babylonjs-bindings/spec.md sha256:73cba09ce133a146c112194247558a97e459022ef56700a096a5a27a0172ddc0 schemaVersion:1
- clarifications: work/001-full-babylonjs-bindings/clarifications.md sha256:abd8073b0139158e7c49c85e8f831708e9f98cb777da0f8e906fac35085fc6bf schemaVersion:1
- checklist: work/001-full-babylonjs-bindings/checklist.md sha256:33f531e82e5327d72784e2773ced7053ba6f9bce69d2d88d01a05f89eb4fe16f schemaVersion:1

## Plan Scope
- Replace the six-symbol qualification slice with a versioned, export-inventory-driven binding for both pinned package index entry points.
- Keep generated candidates under `generated-candidates/`; reviewed source under `src/BabylonjsBindings/` remains the NuGet public surface.
- Add deterministic declaration, generator, coverage, emitted-import, runtime, package, and clean-consumer gates.

## Plan Decisions
- PD-001 [AC-001] [FR-001] [DEC-001] complete: Start closure traversal at `@babylonjs/core/index.d.ts` and `@babylonjs/loaders/index.d.ts`; store sorted relative paths and SHA-256 hashes in schema-versioned `declaration-lock.json`.
- PD-002 [AC-002] [FR-002] [DEC-002] [DEC-004] complete: Pin `babylonjs`, `ts2fable`, and the generator's TypeScript version exactly; strip documentation comments only, capture diagnostics, and write byte-stable candidate/report artifacts without touching maintained source.
- PD-003 [AC-003] [FR-003] [DEC-003] complete: Maintain the reviewed public binding as explicit F# source split by dependency order, with a checked export inventory and public API baseline; signatures/types, static companions, options, overloads, and inheritance remain typed where upstream is typed.
- PD-004 [AC-004] [FR-004] complete: Rewrite candidate module imports to `@babylonjs/core/<path>.js`, keep `@babylonjs/loaders` registrations explicit, and validate emitted imports against installed package exports and files.
- PD-005 [AC-005] [FR-005] [DEC-003] complete: Replace the coarse coverage file with a schema-validated per-export/per-construct report whose blocked or lossy entries fail the complete-coverage gate.
- PD-006 [AC-006] [FR-006] [DEC-004] complete: Extend compile tests and runtime fixtures across engine, scene, maths, cameras, lights, meshes, materials, animation, particles, physics/XR feature availability, and loaders; then pack and test a clean consumer.

## Contract Impact
- PC-001 [PD-001] [PD-003] publicSurface: `src/BabylonjsBindings/BabylonjsBindings.fsi`, the packed NuGet compile surface, and `contracts/coverage-and-drift.schema.json` become versioned public/tool-facing contracts.
- PC-002 [PD-002] generatorContract: `declaration-lock.json`, `generator-lock.json`, generated candidate headers, and generation diagnostics are deterministic review inputs and never release authority by themselves.
- PC-003 [PD-004] runtimeContract: emitted JavaScript imports resolve only against exact `@babylonjs/core@9.19.0` and `@babylonjs/loaders@9.19.0` modular paths.

## Verification Obligations
- VO-001 [PD-001] [PC-002] declarationDrift: Regenerate the complete declaration closure twice and require byte identity plus a clean check-mode run.
- VO-002 [PD-002] [PC-002] candidateDeterminism: Generate in isolated directories twice, compare candidate/report digests, and assert maintained-source and declaration-lock digests are unchanged.
- VO-003 [PD-003] [PC-001] compileAndCoverage: Build the library and clean compile consumer, compare the public surface baseline, and require every exported declaration to have a non-lossy disposition.
- VO-004 [PD-004] [PC-003] emittedImports: Fable-compile representative calls and resolve every emitted module specifier against the locked npm install.
- VO-005 [PD-005] [PC-001] schemaAndNegativeFixture: Validate coverage JSON and prove an unsupported synthetic declaration causes a blocking report without modifying maintained source.
- VO-006 [PD-006] [PC-001] runtimeAndPackage: Run Node and Chromium fixtures, pack the library, and compile/run a clean consumer with exact NuGet and npm dependencies.

## Performance Intent
No performance intent is declared for this work item.

## Migration Posture
- PM-001 [PC-001] additiveThenReplace: Preserve the qualification module during development, add the full public surface and migration aliases, then remove or obsolete narrow constructors only with explicit release notes.
- PM-002 [PC-002] schemaVersioned: Coverage, declaration, and generator lock schemas start at version 1/2 as applicable; unknown versions fail before write and no artifact is silently upgraded.

## Generated View Impact
- GV-001 [PD-001] [PD-005] coverageView: `coverage-and-drift.json` is regenerated from locked declarations and maintained source and reports stale whenever either input digest changes.
- GV-002 [PD-002] candidateView: candidate F# and diagnostics record source/tool hashes; stale or unsupported output remains review-only and blocks promotion.
- GV-003 [PD-006] workModel: readiness views refresh after authored sources and observed evidence, or explicitly report stale inputs.

## Accepted Deferrals
No accepted plan deferrals recorded.

## Planning Findings
No blocking planning findings recorded.

## Advisory Notes
- The comparison run produced 117,099 lines and approximately 19,000 declarations after six syntax repairs, but unresolved re-export and generic alias diagnostics mean it is inventory evidence, not completed typed coverage.
- Optional Governance pointers remain compatibility facts only; publication stays outside this work item.

## Lifecycle Notes
- Implement in dependency-ordered slices while the complete export inventory remains the fixed completion denominator.
- Refresh plan/tasks/analyze after any upstream authority change.
