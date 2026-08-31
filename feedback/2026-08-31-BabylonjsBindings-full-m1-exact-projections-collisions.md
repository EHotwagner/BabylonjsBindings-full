---
feedbackSchema: 2
date: 2026-08-31
workspace: BabylonjsBindings-full
cycle: roadmap-missing-exports-m1-exact-projections-collisions
lane: sdd
toolVersion: 1.5.0
commit: 480b90aee330872b021fa219d1622d9a69e79c74
---

# Development feedback — M1 exact projections and collisions

## §1 Provenance and confidence

- **activation:** active
- **phases:** onboarding-first-build, lifecycle-authoring, implementation-test-evidence, verify-ship-pr
- **material events:** 4
- **zero-event reason:** n/a
- Checkpoints: `feedback/checkpoints/roadmap-missing-exports-m1-exact-projections-collisions.jsonl` (4 events).
- Scope: isolated worker from exact `origin/main` commit `169356dec98076b2081cdab2e62b71da218db15b` through the full Typed SDD lifecycle, implementation, clean consumer, independent critique, observed evidence, and durable ship readiness.
- Pins exercised: .NET SDK 10.0.302, Fable 5.13.0, Babylon.js core/loaders 9.19.0; the ambient Node/npm pair was 26.8.1/12.0.2 while the repository requests 26.5.0/12.0.1.
- Confidence: high for commands and committed artifacts; no elapsed-time total is asserted.

## §2 What worked

- The exact-projection checker combines declaration-lock hashes, reviewed semantic shapes, matching declaration/support structural digests, exact default arities, and the full eleven-case constructor/return map.
- F# compile, Fable emitted-import inspection, Node smoke, and a clean packed consumer jointly covered type-only/runtime boundaries and module-qualified collisions.
- SDD verify failed closed on self-attested evidence and became green only after parsing the actual twelve-check TRX; refresh then produced a compact durable ship verdict suitable for tracked-only host validation.
- One independent critique repair round found and closed three material exactness gaps before protected-boundary work.

## §3 What did not

- The first locked restore could not start until the exact repository SDK was provisioned.
- Initial evidence was complete but self-attested; the first verify attempt correctly blocked until an observed test receipt existed.
- Cold feedback review found that the first aggregate runners hard-coded the worker's `.NET` path; both runners were repaired to resolve `dotnet` from the caller's environment and reran green before report finalization.

## §4 Findings

None observed.

## §5 Did not exercise

- Browser/WebXR playtesting and performance measurement were outside this non-game milestone.
- Registry publication was not performed in the implementation cycle; the required post-merge patch release remains a protected-boundary step.

## §6 Doc-versus-behavior contradictions

None observed in this cycle.

## §7 Workarounds still in the tree

- `scripts/run-m1-tests.mjs` and `scripts/test-m1-clean-consumer.mjs` remove inherited npm `allow-scripts` variables only from spawned child environments so user-level npm policy is not reinterpreted as project configuration. Removal condition: nested npm invocations no longer receive or reject that user-level list setting. Risk: low and confined to verification subprocesses; the guard does not change repository or user npm configuration.
- Cold feedback review removed machine-specific `.NET` paths from both runners before finalization.

## §8 Friction and avoidable cost

- One failed locked restore preceded installation of SDK 10.0.302.
- One SDD verify attempt blocked on zero observed receipts and led to the committed aggregate TRX runner. This cost was productive because it prevented ten self-attested declarations from reaching ship.
- One cold-feedback repair removed machine-specific `.NET` paths from two verification scripts and reran the twelve-check receipt without changing its exact-byte digest.
- No elapsed duration was aggregated.

## §9 Skill value and gaps

- Invoked: work-roadmap; FS.GG SDD lifecycle, Typed authoring, every routed stage, refresh and agents; feedback-report; fable-bindings; fable-interop; fable-testing; and fable-project.
- The binding/testing skills drove the layered compile/emission/runtime/package matrix and prevented type-only symbols from acquiring fictitious runtime imports.
- The critique contract caught missing default arities, an unsupported structural-digest claim, and incomplete compile correlation coverage; all were resolved in one repair round.
- The feedback skill preserved four boundary observations without promoting host-specific friction into unsupported actionable findings.

## §10 Outcome markers

- First build: blocked at exact SDK availability, then compiled the maintained solution with zero warnings/errors.
- First meaningful test: exact 15-export checker plus compile/emission and Node smoke.
- Full observed run: 12 tests passed in `reports/m1-exact-projections.trx`.
- First green verification: 10 supported and 10 observed evidence declarations, zero self-attested or synthetic.
- Ship readiness: `shipReady` with zero blockers in `readiness/003-m1-exact-projections-collisions/ship-verdict.json`.
- Merge: not yet performed at report finalization; implementation merge and the mandatory post-merge patch release remain protected-boundary steps.

## §11 Falsifiable improvements

None proposed. The observed host provisioning/configuration facts lack a stable image identity or product-owned reproduction boundary, and the SDD receipt rejection behaved as designed.

## §12 Development-surface coverage

| Surface | Status | Evidence and result |
|---|---|---|
| scaffolding | not-exercised | Existing repository and worktree; no product scaffold command run. |
| onboarding-guidance | exercised | Roadmap and local agent/skill guidance were read before lifecycle work. |
| skills | exercised | Roadmap, SDD, feedback, binding, interop, testing, and project skills were used. |
| sdd-authoring | exercised | Full Typed SDD lifecycle reached shipReady. |
| implementation-apis | exercised | Fifteen exact maintained exports were closed with reviewed support projections and deep imports. |
| dependencies-build | exercised | Locked restore/build, proposal checks, declaration drift, coverage, and analysis currency passed. |
| testing | exercised | Twelve aggregate checks passed with committed TRX evidence. |
| evidence | exercised | Ten obligations are supported and observed; critique schema-v3 validates. |
| runtime-playtest | partial | Node/runtime and clean consumer ran; browser-only behavior was out of scope. |
| performance | not-exercised | No performance-sensitive implementation was requested. |
| documentation | exercised | SDD artifacts, critique, feedback, and roadmap evidence surfaces were maintained. |
| packaging-upgrade | partial | A clean 0.1.1 pre-release package consumer passed; 0.1.2 release work remains post-merge. |
| worker-git-pr | partial | Isolated worktree, exact-SHA critique, and durable handoff are complete; PR/merge remains. |
