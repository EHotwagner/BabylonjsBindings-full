---
schemaVersion: 1
workId: 002-m0-analysis-infrastructure
title: "Deterministic analysis infrastructure for the remaining Babylon.js exports"
stage: specify
changeTier: tier1
status: specified
publicOrToolFacingImpact: true
---

<!-- fsgg-typed-specification/v1 -->
<!-- source-fingerprint: d60dd2bbd2f0d199a42ec381105641bbc3dc26686c8af5af998e023339bf9663 -->
<!-- generated-fingerprint: 6ba7781f5dc7cfc5e5822a30cacec1dd9e9476f8f34e909e1d14f91d14cd4048 -->
# Specification SPEC-001

- Schema: `1`
- Extension: `requirements/1`
- Source: `work/002-m0-analysis-infrastructure/specification.fsx@0000000000000000000000000000000000000000000000000000000000000000`

## Intent

Deterministic analysis infrastructure for the remaining Babylon.js exports

## Evidence obligations

- `EV001` (`test`): Generate and validate normalized blocked-family diagnostics twice with byte-identical results.
- `EV002` (`test`): Exercise dependent-map completeness with passing and missing-key fixtures.
- `EV003` (`test`): Validate the versioned instantiation registry and reject malformed or duplicate entries.
- `EV004` (`verification`): Verify maintained API files and coverage dispositions remain unchanged at 4,237 typed exports.

## Extension

## User Value

Binding maintainers can see deterministic, machine-readable reasons and dependency obligations for every remaining export family before promoting any public API.

## Scope

- SB-001: Add analysis-only generators, schemas, reports, fixtures, and tests for the pinned Babylon.js 9.19.0 declaration closure.
- SB-002: Preserve all maintained F# sources, reviewed coverage manifests, package pins, and export dispositions.

## Non-Goals

- SB-003: Promoting any blocked export to typed or adding any maintained binding API.
- SB-004: Implementing the later roadmap families or publishing a NuGet package.

## User Stories

- US-001 (P1): A binding maintainer can group all 85 blocked exports by normalized family and inspect stable reasons and identities.
- US-002 (P1): A generator author can fail early when a finite dependent map omits, adds, or duplicates a discriminator mapping.
- US-003 (P1): A binding author can record exact closed-world type-function instantiations in a validated, deterministic registry.

## Acceptance Scenarios

- AC-001 [FR-001] [US-001]: Given the pinned declaration lock and coverage report, two analysis generations are byte-identical and account for all 85 blocked exports exactly once.
- AC-002 [FR-002] [US-002]: Given complete, missing-key, extra-key, and duplicate-key fixtures, only the complete dependent map passes and each failure reports sorted actionable keys.
- AC-003 [FR-003] [US-003]: Given the committed empty M0 registry and malformed fixtures, the registry validates deterministically while invalid schema, duplicate identity, and non-normalized expression inputs fail.
- AC-004 [FR-004] [US-001] [US-002] [US-003]: Given the M0 diff and regenerated coverage, maintained F# API and reviewed manifests are unchanged and the typed total remains 4,237.

## Functional Requirements

- FR-001: The analysis generator MUST classify every blocked export into one normalized family with stable declaration identity and reason data and MUST emit byte-identical output for identical locked inputs. (Acceptance: AC-001)
- FR-002: The dependent-map completeness checker MUST compare declared discriminator keys with mapped keys and MUST reject missing, extra, or duplicate mappings deterministically. (Acceptance: AC-002)
- FR-003: The instantiation registry MUST have a versioned machine-readable schema, normalized TypeScript expressions, unique declaration identities, deterministic ordering, and explicit reviewed projection status. (Acceptance: AC-003)
- FR-004: M0 MUST close zero exports, preserve the maintained public API, and retain exactly 4,237 typed, 85 blocked, one runtime-only, and zero lossy exports. (Acceptance: AC-004)

## Ambiguities

- None.

## Public Or Tool-Facing Impact

- Adds versioned analysis report and registry contracts plus generator/check commands; no maintained binding API changes.

## Lifecycle Notes

- Later milestones consume these analysis contracts; M0 does not promote generated candidates.
- Roadmap milestone M0 closes zero exports and is non-game work.
