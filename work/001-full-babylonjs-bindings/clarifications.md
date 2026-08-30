---
schemaVersion: 1
workId: 001-full-babylonjs-bindings
title: Full Babylon.js Fable bindings
stage: clarify
changeTier: tier1
status: clarified
sourceSpec: work/001-full-babylonjs-bindings/spec.md
publicOrToolFacingImpact: true
---

# Full Babylon.js Fable bindings Clarifications

## Source Specification
- work/001-full-babylonjs-bindings/spec.md

## Clarification Questions
- **CQ-001**: Does complete coverage mean every declaration file, every package export, or every runtime symbol?
- **CQ-002**: May a monolithic same-version Babylon declaration bundle be used as generator input when runtime packages remain modular?
- **CQ-003**: Can generated `obj` fallbacks be counted as typed coverage?
- **CQ-004**: Should the generated 117k-line comparison output become maintained source automatically?

## Answers
- CQ-001 → complete coverage is measured over reachable exported declarations from both pinned package index entry points; runtime-only side effects are classified separately.
- CQ-002 → yes, as a deterministic review input whose version and hash match the authoritative modular declarations.
- CQ-003 → no; an `obj` is either justified by an upstream `any`/`unknown` contract or reported as lossy and excluded from typed coverage.
- CQ-004 → no; generator output remains a candidate until compile, import, coverage, and runtime review passes.

## Decisions
- **DEC-001** [CQ-001] [FR-001] [FR-003] [AC-001] [AC-003]: Coverage authority is the complete reachable export inventory from `@babylonjs/core` and `@babylonjs/loaders` index declarations at 9.19.0.
- **DEC-002** [CQ-002] [FR-002] [AC-002]: The official `babylonjs@9.19.0` monolithic declaration bundle may seed deterministic candidate generation, but modular declarations and imports remain authoritative.
- **DEC-003** [CQ-003] [FR-003] [FR-005] [AC-003] [AC-005]: Dynamic or lossy fallbacks never satisfy typed coverage; every such disposition is machine-readable.
- **DEC-004** [CQ-004] [FR-002] [FR-006] [AC-002] [AC-006]: Candidate generation is review-only. Maintained source changes only after compile, modular import, runtime, and clean-consumer evidence.

## Accepted Deferrals
No accepted deferrals recorded.

## Remaining Ambiguity
No blocking ambiguity remains.

## Lifecycle Notes
- Next lifecycle action: `fsgg-sdd checklist --work 001-full-babylonjs-bindings`.
