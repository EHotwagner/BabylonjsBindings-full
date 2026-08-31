---
schemaVersion: 1
workId: 004-m2-finite-dependent-maps
title: M2 Finite Dependent Maps
stage: plan
changeTier: tier1
status: planned
sourceSpec: work/004-m2-finite-dependent-maps/spec.md
sourceClarifications: work/004-m2-finite-dependent-maps/clarifications.md
sourceChecklist: work/004-m2-finite-dependent-maps/checklist.md
publicOrToolFacingImpact: true
---

# M2 Finite Dependent Maps Plan

Prose status: planned

## Source Snapshot
- spec: work/004-m2-finite-dependent-maps/spec.md sha256:461cd1e0602ea07b670e17a5f32442265fa1ccda97d2a114df1f98c9cdd109ba schemaVersion:1
- clarifications: work/004-m2-finite-dependent-maps/clarifications.md sha256:f02b416dd7473ebd0e3835649d46e9e317165287df569230e0426a26b47adf36 schemaVersion:1
- checklist: work/004-m2-finite-dependent-maps/checklist.md sha256:195d633b7ba7a9364049a6711d74a3a8cdf0c35b6ffee9c22ce694feb6cddd87 schemaVersion:1

## Plan Scope
- Add one curated maintained M2 projection layer after the existing generated support types, with exact Fable singleton markers and overload/specialized interfaces generated from a reviewed declaration-derived manifest.
- Extend M0 analysis generation so the 8/6/22 tables carry normalized input/options/result symbols and reject missing, extra, duplicate, or emitted-signature-collapsed rows.
- Keep candidate generation review-only; coverage advances only from explicit maintained manifest entries for the twenty-seven locked identities.

## Plan Decisions
- PD-001 [AC-001] [FR-001] complete: Extend the M0 TypeScript-checker analysis with one normalized M2 manifest that derives all DeviceType, FlowGraph asset, and WebXR feature correlations and validates source and F# signature uniqueness.
- PD-002 [AC-002] [FR-002] complete: Model DeviceType cases as singleton marker interfaces, emit case-specific DeviceInput and DeviceSourceEvent aliases/views, represent never events with an uninhabited marker, and expose exact manager/source overloads plus a nested erased union convenience type.
- PD-003 [AC-003] [FR-003] complete: Emit six exact FlowGraph asset aliases and function overloads, six specialized asset/property/parser configurations and blocks, and distinct float/FlowGraphInteger switch views over the same runtime export.
- PD-004 [AC-004] [FR-004] complete: Emit a 22-row WebXR map with singleton feature names, exact options/result aliases, manager enable/get overloads, and curated downstream WebXRExperienceHelper, WebXREnterExitUI, WebXRDefaultExperience, VRExperienceHelper, and HandConstraintBehavior deep imports.
- PD-005 [AC-005] [FR-005] complete: Add generated positive compile cases for every row, isolated negative projects whose expected compiler failures are asserted, Fable emitted-import checks, Node import/runtime smoke, and a locally served deterministic Chromium page that installs WebXR stubs.
- PD-006 [AC-006] [FR-006] complete: Add a fail-closed M2 acceptance script that regenerates analysis and coverage and asserts the exact 4,279/43/1/0 totals and exact twenty-seven identity transition set.
- PD-007 [AC-007] [FR-007] complete: Pack the maintained library and run an external clean consumer with locked .NET/npm inputs, exact imports, Node behavior, and Chromium XR-stub proof; repeat from the released 0.1.3 package in the post-merge release flow.

## Contract Impact
- PC-001 [PD-001] manifest: analysis/m2-finite-dependent-map-manifest.json schemaVersion 1 is the reviewed projection/table contract and lists every source key, mapped TypeScript symbol, maintained F# symbol, runtime module/export, and emitted-signature key.
- PC-002 [PD-002] [PD-003] [PD-004] public surface: src/BabylonjsBindings/M2FiniteDependentMaps.fs declares the curated API after all generated support declarations and before Bindings.fs aggregation.
- PC-003 [PD-005] [PD-006] acceptance: reports/m2-test-matrix.json and reports/m2-finite-dependent-maps.trx bind compile, negative, analysis, import, Node, Chromium, coverage, and clean-consumer results.

## Verification Obligations
- VO-001 [PD-001] [PC-001] semanticTest: Generate M2 tables twice, compare bytes, and mutation-test missing, extra, duplicate, and collapsed rows.
- VO-002 [PD-002] [PD-003] [PD-004] [PC-002] compileTest: Compile all 36 discriminator rows and run expected-failure negative fixtures for each correlation family.
- VO-003 [PD-004] [PD-005] [PC-003] browserTest: Execute deterministic Chromium XR smoke with navigator.xr and session/reference-space stubs and no physical XR device.
- VO-004 [PD-005] [PD-007] [PC-003] packageTest: Inspect emitted imports, run meaningful Node smoke, then build and execute a clean packed consumer with exact npm dependencies.
- VO-005 [PD-006] [PC-001] coverageTest: Regenerate coverage and assert exactly twenty-seven named transitions and totals 4,279 typed, 43 blocked, one runtime-only, zero lossy.

## Performance Intent
No performance intent is declared for this work item.

## Migration Posture
- PM-001 [PC-001] additive: Manifest schemaVersion 1 and new public symbols are additive at package 0.1.3; any source-table drift blocks regeneration pending review.

## Generated View Impact
- GV-001 [PD-001] analysis: analysis/dependent-maps.json and analysis/dependent-map-completeness.json remain generated from the locked declarations and gain M2 exact-correlation validation.
- GV-002 [PD-006] coverage: coverage-and-drift.json and maintained coverage manifests regenerate only after reviewed source promotion.
- GV-003 [PD-005] runtime: Fable emission and browser/consumer outputs stay ephemeral; committed TRX and matrix receipts summarize reproducible commands.

## Accepted Deferrals
No accepted plan deferrals recorded.

## Planning Findings
No blocking planning findings recorded.

## Advisory Notes
- `pnext-item` is unavailable in this host; the loaded work-roadmap contracts remain authoritative for exact-SHA, critique, PR, release, ledger, and cleanup gates.
- This is non-game work (`game_functionality: false`), so no player-journey evidence applies.

## Lifecycle Notes
- Next lifecycle action: `fsgg-sdd tasks --work 004-m2-finite-dependent-maps`.
