---
schemaVersion: 1
workId: 002-m0-analysis-infrastructure
title: M0 analysis infrastructure
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

# M0 analysis infrastructure Charter

## Identity
- Establish deterministic analysis infrastructure for the remaining Babylon.js exports before any export is promoted.

## Principles
- Generated analysis remains review-only and reproducible from the exact declaration lock.
- Diagnostics identify blocked families and dependency-map gaps without changing maintained F# source or coverage dispositions.
- The typed-export baseline remains exactly 4,237 of 4,323 with 85 blocked, one runtime-only, and zero lossy exports.

## Scope Boundaries
- In: normalized blocked-family diagnostics, dependent-map completeness validation, and a versioned instantiation-registry format.
- In: deterministic tests, schemas, generated reports, SDD evidence, feedback, critique, and roadmap ledger normalization.
- Out: closing exports, editing maintained public F# API files or manifests, changing Babylon.js/toolchain pins, and publishing packages.

## Policy Pointers
- Honor `.fsgg/constitution.md` principles I, II, III, VI, VII, and VIII.
- Follow the binding roadmap at `docs/2026-08-31T072958Z-missing-exports-design-roadmap.md` and exact lock discipline from the `fable-bindings` skill.

## Lifecycle Notes
- Tier 1 tool-facing schema/report change with no maintained API change.
- `game_functionality: false`.
- Next lifecycle action: `fsgg-sdd specify --work 002-m0-analysis-infrastructure`.
