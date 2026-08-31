---
schemaVersion: 1
workId: 002-m0-analysis-infrastructure
title: M0 Analysis Infrastructure
stage: plan
changeTier: tier1
status: planned
sourceSpec: work/002-m0-analysis-infrastructure/spec.md
sourceClarifications: work/002-m0-analysis-infrastructure/clarifications.md
sourceChecklist: work/002-m0-analysis-infrastructure/checklist.md
publicOrToolFacingImpact: true
---

# M0 Analysis Infrastructure Plan

Prose status: planned

## Source Snapshot
- spec: work/002-m0-analysis-infrastructure/spec.md sha256:0e417769f5315b01cb46dbf97a83565ec98fdc6fa176fad16eca761b8f2bede9 schemaVersion:1
- clarifications: work/002-m0-analysis-infrastructure/clarifications.md sha256:238ff48feabde93f42acf2fb78e56468cfc6c73544a54832ed138968af041387 schemaVersion:1
- checklist: work/002-m0-analysis-infrastructure/checklist.md sha256:0b32793477cd95848186063a12525f83fbbb82eb8d76489a719e4a3fc9d136bb schemaVersion:1

## Plan Scope
- Add an analysis-only Node module, CLI, fixtures, JSON schemas, and deterministic committed reports over `coverage-and-drift.json`.
- Keep the analysis inputs explicit: the coverage inventory, normalized family rules, dependent-map registry, and instantiation registry.
- Do not edit `src/BabylonjsBindings/*.fs`, reviewed coverage manifests, declaration locks, package pins, or export dispositions.

## Plan Decisions
- PD-001 [AC-001] [FR-001] complete: Classify blocked exports with an explicit ordered family-rule registry keyed by exact package/module/export identity and fail on unclassified, multiply classified, or count-drifted exports.
- PD-002 [AC-002] [FR-002] complete: Represent finite dependent maps as arrays with explicit source keys and mapping rows so duplicate keys remain observable; validate exact set equality and emit sorted missing/extra/duplicate diagnostics.
- PD-003 [AC-003] [FR-003] complete: Define a schema-version-1 instantiation registry whose entries carry declaration identity, normalized TypeScript expression, deterministic F# symbol, status, and evidence, while M0 commits the valid empty registry.
- PD-004 [AC-004] [FR-004] complete: Pin expected coverage counts in analysis policy, run existing coverage drift checks, and use the branch diff to prove no maintained API or reviewed-manifest change.

## Contract Impact
- PC-001 [PD-001] [PD-002] [PD-003] versionedJson: Add schema-version-1 JSON contracts under `analysis/schemas/` and committed inputs/reports under `analysis/`; these are new tool-facing analysis surfaces and do not alter the binding API.

## Verification Obligations
- VO-001 [PD-001] [PD-002] [PD-003] [PD-004] [PC-001] semanticTest: Run analysis fixture tests, generate twice and compare bytes, run `analysis:check`, run `coverage:check`, build/test the binding, and assert the maintained API path set is absent from the branch diff.

## Performance Intent
No performance intent is declared for this work item.

## Migration Posture
- PM-001 [PC-001] additiveV1: Introduce schema version 1 with strict unknown-field rejection; later compatible additions require a schema bump or optional fields, and no existing artifact migration is required.

## Generated View Impact
- GV-001 [PD-001] [PD-002] [PD-003] analysisReports: `analysis/blocked-families.json` and `analysis/dependent-map-completeness.json` are regenerated deterministically and fail `--check` when stale; SDD readiness views refresh separately from authored lifecycle sources.

## Accepted Deferrals
No accepted plan deferrals recorded.

## Planning Findings
No blocking planning findings recorded.

## Advisory Notes
- Optional Governance pointers remain compatibility facts only.

## Lifecycle Notes
- Next lifecycle action: `fsgg-sdd tasks --work 002-m0-analysis-infrastructure`.
