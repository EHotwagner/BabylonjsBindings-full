---
schemaVersion: 1
workId: 001-full-babylonjs-bindings
title: Full Babylon.js Fable bindings
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

# Full Babylon.js Fable bindings Charter

## Identity
Expand the scaffold's qualification slice into a release-grade Fable binding for
the complete pinned Babylon.js core and loaders declaration surface.

## Principles
- Exact upstream versions and transitive declaration hashes are immutable inputs.
- Generated output is review material; maintained F# source is the public API.
- Typed coverage is earned through compile and runtime evidence, never inferred
  from an `obj` escape hatch or a generator's exit code.
- Modular deep imports preserve Babylon.js tree-shaking behavior.

## Scope Boundaries
In: `@babylonjs/core@9.19.0`, `@babylonjs/loaders@9.19.0`, deterministic
candidate generation, maintained bindings, coverage/drift reports, compile and
runtime tests, package and clean-consumer evidence. Out: Babylon GUI, materials
library, serializers, inspector, publication, and registry activation.

## Policy Pointers
- Honors constitution I and II: the Typed SDD authority and structured reports
  precede and govern implementation.
- Honors constitution III and VI: public surface, package baseline, tests, docs,
  and evidence move together.
- Honors constitution VII and VIII: generated guidance shares the same contract,
  and drift or unsupported syntax fails with actionable diagnostics.

## Lifecycle Notes
Tier 1 public-surface expansion. The same-version monolithic Babylon declaration
bundle may seed candidate generation, but modular package declarations and
runtime imports remain authoritative.
