---
schemaVersion: 1
workId: 005-m3-higher-order-runtime-apis
title: M3 higher-order runtime APIs
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

# M3 higher-order runtime APIs Charter

## Identity
- Complete roadmap M3 by closing exactly eight Babylon.js 9.19.0 higher-order runtime exports while preserving heterogeneous callable, decorator, JavaScript `this`, and mixin-intersection correlations.

## Principles
- Derive the callable ladder from the digest-verified declaration closure: stable arities 0 through 10, with broader fixed-callable arity 17 recorded only as context.
- Keep generated candidates review-only; maintained source is curated against exact declarations and runtime modules.
- Preserve decorator target/context/result and explicit JavaScript `this` semantics; `nativeOverride.filter` remains a callable member on a callable object.
- Model mixin intersections as named both-member results and exact locked-base specializations, never `U2` or unconstrained `obj`.

## Scope Boundaries
- In: the five remaining miscellaneous functions and three material mixins named by M3; arity 0 through 10; positive, negative, emitted-JavaScript, Node, Chromium, exact coverage, clean consumer, critique, feedback, PR, and 0.1.4 patch-release evidence.
- Out: M4 through M6 exports, Babylon.js/toolchain pin changes, direct pushes to main, and game functionality.

## Policy Pointers
- Honor `.fsgg/constitution.md` principles I, II, III, VI, VII, and VIII.
- Follow `docs/2026-08-31T072958Z-missing-exports-design-roadmap.md` plus fable-bindings, fable-interop, fable-testing, fable-project, work-roadmap, critique, and feedback contracts.

## Lifecycle Notes
- Tier 1 maintained public binding and package change.
- `game_functionality: false`.
- M3 completes only at exactly 4,287 typed, 35 blocked, one runtime-only, and zero lossy exports; contradictory export counts stop classification changes.
- After the first green implementation/test/evidence loop, one fresh independent critic owns the bounded confirmation loop.
- Next lifecycle action: `fsgg-sdd specify --work 005-m3-higher-order-runtime-apis`.
