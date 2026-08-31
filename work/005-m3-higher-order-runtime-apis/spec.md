---
schemaVersion: 1
workId: 005-m3-higher-order-runtime-apis
title: "Close exactly eight M3 higher-order runtime exports with evidence-derived callable arities and exact decorator and mixin correlations"
stage: specify
changeTier: tier1
status: specified
publicOrToolFacingImpact: true
---

<!-- fsgg-typed-specification/v1 -->
<!-- source-fingerprint: d47cd562eb16b6e990d5f5da71061e91939e167f5345e6593379ba001aba42e9 -->
<!-- generated-fingerprint: c97301bc0d2e00aa369f3535a640b9c8811eef485ca074275d8487f44dd0b4a3 -->
# Specification SPEC-001

- Schema: `1`
- Extension: `requirements/1`
- Source: `work/005-m3-higher-order-runtime-apis/specification.fsx@0000000000000000000000000000000000000000000000000000000000000000`

## Intent

Close exactly eight M3 higher-order runtime exports with evidence-derived callable arities and exact decorator and mixin correlations

## Evidence obligations

- `EV001` (`verification`): Digest-check and scan all 2,928 locked declarations, proving fixed callback arity 10 and recording fixed-callable arity 17 as context.
- `EV002` (`test`): Compile positive arity 0 through 10 calls and reject wrong-arity, parameter, this, result, and broad-projection fixtures.
- `EV003` (`test`): Fable-compile representative coroutine and decorator calls, inspect emitted JavaScript call and this semantics, and execute Node proof.
- `EV004` (`test`): Compile and execute named both-member ImageProcessing, ImageProcessingDefines, and UV mixin specializations without U2 or unconstrained obj.
- `EV005` (`test`): Execute applicable Chromium runtime and import proof for decorator and mixin modules.
- `EV006` (`test`): Aggregate positive, negative, emitted JavaScript, Node, and Chromium checks into one observed non-synthetic test receipt.
- `EV007` (`verification`): Regenerate coverage and prove exactly 4,287 typed, 35 blocked, one runtime-only, and zero lossy with exactly eight exports reclassified.
- `EV008` (`test`): Pack and consume version 0.1.4 in a clean project with exact npm dependencies, emitted imports, Node, and Chromium proof.

## Extension

## User Value

Fable consumers can use Babylon.js coroutine adapters, decorators, native override filtering, and material mixins without losing parameter, this, context/result, or intersection correlations.

## Scope

- SB-001: Close exactly makeSyncFunction, makeAsyncFunction, addAccessorsForMaterialProperty, expandToProperty, nativeOverride, ImageProcessingMixin, ImageProcessingDefinesMixin, and UVDefinesMixin from Babylon.js 9.19.0.
- SB-002: Adopt stable callable families for arities 0 through 10 from the digest-verified 2,928-file callback scan; record broader fixed-callable arity 17 only as context.

## Non-Goals

- SB-003: Closing M4 through M6 exports, changing Babylon.js or toolchain pins, or changing game functionality.
- SB-004: Using ParamArray obj, U2 intersections, unconstrained obj mixin results, fictitious imports, or generated candidates as maintained authority.

## User Stories

- US-001 (P1): A consumer wraps heterogeneous coroutine factories of every locked callback arity while preserving each argument and result type.
- US-002 (P1): A consumer applies accessor and method decorators with exact context, result, explicit JavaScript this, and callable nativeOverride.filter behavior.
- US-003 (P1): A consumer applies each material mixin and receives one named result exposing both exact base members and all added members.
- US-004 (P1): A maintainer proves arity, rejection, emitted calls, runtime behavior, coverage, and clean packed consumption.

## Acceptance Scenarios

- AC-001 [FR-001] [US-004]: Given declaration-lock.json, the scan verifies 2,928 hashes, reports callback maximum 10 and fixed-callable maximum 17, and adopts 0 through 10.
- AC-002 [FR-002] [US-001]: Given factories at arities 0 through 10, arguments and sync or Promise results stay correlated while wrong fixtures fail.
- AC-003 [FR-003] [US-002]: Given accessor target and context, both factories return the exact result and preserve null versus undefined keys in emitted calls.
- AC-004 [FR-004] [US-002]: Given method and context, nativeOverride and filter remain callable, preserve this and all argument/result types, and execute the expected branch.
- AC-005 [FR-005] [US-003]: Given every locked concrete material base, one named mixed result exposes base and added members and runtime construction succeeds.
- AC-006 [FR-006] [US-001] [US-002] [US-003] [US-004]: Given the M3 matrix, positive, negative, emitted JavaScript, Node, and Chromium lanes pass.
- AC-007 [FR-007] [US-004]: Given regenerated coverage, exactly eight M3 identities move to typed and totals are 4,287, 35, one, and zero.
- AC-008 [FR-008] [US-004]: Given a clean consumer of 0.1.4 and exact npm packages, Fable emission, imports, Node, and Chromium pass.

## Functional Requirements

- FR-001: The repository MUST scan and digest-check all 2,928 locked declarations, reject provisional arities 0 through 8, adopt stable callable families 0 through 10, and record fixed-callable declaration arity 17 only as context. (Acceptance: AC-001)
- FR-002: makeSyncFunction and makeAsyncFunction MUST preserve heterogeneous parameter and return correlations for arities 0 through 10 without ParamArray obj erasure. (Acceptance: AC-002)
- FR-003: expandToProperty and addAccessorsForMaterialProperty MUST preserve exact ClassAccessorDecoratorTarget, ClassAccessorDecoratorContext, and ClassAccessorDecoratorResult correlations and Nullable source-key semantics. (Acceptance: AC-003)
- FR-004: nativeOverride MUST be callable with callable filter, preserve explicit JavaScript this and heterogeneous arities 0 through 10, and emit exact decorator calls. (Acceptance: AC-004)
- FR-005: Each material mixin MUST return named both-member interfaces and exact specializations for every locked concrete base use, never U2 or unconstrained obj. (Acceptance: AC-005)
- FR-006: Positive and negative compile fixtures, emitted JavaScript inspection, Node, and Chromium MUST prove coroutine, decorator, filter, this, and mixin behavior. (Acceptance: AC-006)
- FR-007: M3 MUST close exactly eight exports and coverage MUST report exactly 4,287 typed, 35 blocked, one runtime-only, and zero lossy. (Acceptance: AC-007)
- FR-008: The maintained package MUST compile, pack at version 0.1.4, install into a clean consumer, resolve exact npm imports, and execute Node and Chromium proof. (Acceptance: AC-008)

## Ambiguities

- None.

## Public Or Tool-Facing Impact

- Adds eight maintained higher-order exports plus stable arity-indexed callable and named mixin-specialization surfaces.
- Extends the provisional arity ladder from 0 through 8 to evidence-derived 0 through 10 without renaming existing families.

## Lifecycle Notes

- Generated candidates remain review-only; maintained projections are reviewed against locked declarations.
- M3 is non-game work and leaves M4 through M6 unchecked.
