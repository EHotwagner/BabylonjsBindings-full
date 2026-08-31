---
schemaVersion: 1
workId: 005-m3-higher-order-runtime-apis
title: Close exactly eight M3 higher-order runtime exports with evidence-derived callable arities and exact decorator and mixin correlations
stage: clarify
changeTier: tier1
status: clarified
sourceSpec: work/005-m3-higher-order-runtime-apis/spec.md
publicOrToolFacingImpact: true
---

# Close exactly eight M3 higher-order runtime exports with evidence-derived callable arities and exact decorator and mixin correlations Clarifications

## Source Specification
- work/005-m3-higher-order-runtime-apis/spec.md

## Clarification Questions
- **CQ-001** [FR-001] [FR-002] [FR-004]: Does the provisional 0 through 8 ladder cover the locked declaration callback closure?
- **CQ-002** [FR-005]: Which concrete bases consume the three mixins in the locked Babylon.js implementation?
- **CQ-003** [FR-003] [FR-004]: How are decorator callability, context/results, and JavaScript `this` preserved without tuple erasure?

## Answers
- CQ-001 → No. The digest-verified scan finds fixed callback arity 10, so stable families 0 through 10 are required; fixed-callable arity 17 is broader context, not this scoped ladder.
- CQ-002 → ImageProcessing uses PushMaterial; defines mixins compose over MaterialDefines and named UV/prepass/environment-lighting specializations observed in the locked implementation.
- CQ-003 → Use arity-indexed callable interfaces, explicit `Emit` call helpers for `this`, exact TC39 accessor/method context and result projections, and one callable `NativeOverride` interface exposing callable `filter`.

## Decisions
- **DEC-001** [CQ-001] [FR-001] [FR-002] [FR-004] [AC-001]: Adopt stable callable families 0 through 10; never silently truncate to 8 or over-expand this milestone to unrelated arity 17.
- **DEC-002** [CQ-002] [FR-005] [AC-005]: Publish deterministic named both-member mixin result interfaces and exact locked-base specializations; reject U2 and unconstrained obj.
- **DEC-003** [CQ-003] [FR-003] [FR-004] [AC-003] [AC-004]: Preserve exact decorator target/context/result and explicit JavaScript this semantics, including callable nativeOverride.filter.

## Accepted Deferrals
No accepted deferrals recorded.

## Remaining Ambiguity
No blocking ambiguity remains.

## Lifecycle Notes
- Next lifecycle action: `fsgg-sdd checklist --work 005-m3-higher-order-runtime-apis`.
