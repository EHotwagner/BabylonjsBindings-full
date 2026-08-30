---
schemaVersion: 1
workId: 001-full-babylonjs-bindings
title: "Full Babylon.js Fable bindings"
stage: specify
changeTier: tier1
status: specified
publicOrToolFacingImpact: false
---

<!-- fsgg-typed-specification/v1 -->
<!-- source-fingerprint: a707f0074d88f61107fdd1eb415783c7fbf582467bd186a79a523a66087b9573 -->
<!-- generated-fingerprint: 4541d236144c5415ae521abac3a48c421e9e74ca38b73c9177935c8d283266c5 -->
# Specification SPEC-001

- Schema: `1`
- Extension: `requirements/1`
- Source: `work/001-full-babylonjs-bindings/specification.fsx@0000000000000000000000000000000000000000000000000000000000000000`

## Intent

Full Babylon.js Fable bindings

## Evidence obligations

- `EV001` (`test`): Compile the maintained F# binding and its clean consumer with the pinned toolchain.
- `EV002` (`test`): Fable-compile representative calls and verify every emitted Babylon import resolves.
- `EV003` (`test`): Run representative engine, scene, maths, mesh, material, animation, loader, and browser behavior.
- `EV004` (`verification`): Verify deterministic declaration and generator locks against the exact Babylon 9.19.0 corpus.
- `EV005` (`verification`): Verify machine-readable export coverage and unsupported-construct accounting.
- `EV006` (`test`): Pack the NuGet library and exercise it from a clean Fable consumer with exact npm runtime dependencies.

## Extension

## User Value

F# and Fable consumers can use the complete exported Babylon.js core and loader API at the pinned version without dropping to dynamic interop for uncovered subsystems.

## Scope

- SB-001: Cover the complete exported declaration surface of @babylonjs/core@9.19.0 and @babylonjs/loaders@9.19.0.
- SB-002: Generate review-only candidates from exact locked inputs, then maintain an explicit compile-clean F# public surface.
- SB-003: Use modular deep imports and verify representative browser and Node execution plus clean consumer packaging.

## Non-Goals

- SB-004: Binding Babylon.js packages other than core and loaders, including GUI, materials library, serializers, and inspector.
- SB-005: Counting dynamic obj escape hatches or unreviewed generator output as typed coverage.
- SB-006: Publishing to NuGet or activating a registry entry as part of this work item.

## User Stories

- US-001 (P1): A Fable application author can discover and call Babylon core and loader APIs through compile-time checked F# bindings.
- US-002 (P1): A binding maintainer can reproduce the candidate and see exact declaration, coverage, import, or unsupported-syntax drift before release.

## Acceptance Scenarios

- AC-001 [FR-001] [US-002]: Given a clean npm install, regenerating the declaration lock from both package index entry points yields no drift and reports the complete reachable file count.
- AC-002 [FR-002] [US-002]: Given identical locked inputs and tools, two candidate runs are byte-identical and leave maintained source and the declaration lock unchanged.
- AC-003 [FR-003] [US-001] [US-002]: Given the export inventory, each export is classified as typed, intentionally runtime-only, or blocked with a reason; all typed entries compile in the maintained library.
- AC-004 [FR-004] [US-001]: Given representative F# calls, Fable output contains only resolvable @babylonjs/core or @babylonjs/loaders deep imports and explicit loader side effects.
- AC-005 [FR-005] [US-002]: Given an unsupported construct, generation records its declaration path, syntax category, disposition, and coverage impact and the full-coverage gate fails.
- AC-006 [FR-006] [US-001]: Given a packed NuGet artifact and exact npm dependencies in a clean consumer, compilation, import resolution, Node smoke, and real-browser smoke all pass.

## Functional Requirements

- FR-001: The declaration lock MUST start from the package index entry points and include every reachable declaration in @babylonjs/core@9.19.0 and @babylonjs/loaders@9.19.0. (Acceptance: AC-001)
- FR-002: Candidate generation MUST be deterministic, tool-version locked, review-only, and MUST NOT overwrite maintained binding source. (Acceptance: AC-002)
- FR-003: The maintained F# surface MUST compile and expose typed declarations for every supported export; dynamic obj escape hatches MUST NOT count as typed coverage. (Acceptance: AC-003)
- FR-004: Every emitted Babylon import MUST resolve to the exact modular npm runtime and remain tree-shakeable; loader registration MUST use explicit side effects. (Acceptance: AC-004)
- FR-005: Unsupported or lossy TypeScript constructs MUST be identified by source location and reason in a machine-readable report and MUST block a claim of complete typed coverage. (Acceptance: AC-005)
- FR-006: The release candidate MUST pass compile, emitted-import, representative Node and real-browser runtime, package, and clean-consumer verification. (Acceptance: AC-006)

## Ambiguities

- None.

## Public Or Tool-Facing Impact

- None.

## Lifecycle Notes

- The monolithic same-version Babylon declaration bundle may be used only as deterministic generator input; modular @babylonjs/core and @babylonjs/loaders declarations and runtime imports remain authoritative.
- Tier 1 public-surface expansion; specification, generator locks, maintained source, coverage report, signatures, tests, docs, and package evidence move together.
