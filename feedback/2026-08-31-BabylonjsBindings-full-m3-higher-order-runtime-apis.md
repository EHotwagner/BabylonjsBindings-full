---
feedbackSchema: 2
date: 2026-08-31
workspace: BabylonjsBindings-full
cycle: roadmap-missing-exports-m3-higher-order-runtime-apis
lane: sdd
toolVersion: 1.5.0
commit: 78c14aad6f56b35db1e9a8da0de0bd12febaf934
---

# Development feedback — M3 higher-order runtime APIs cycle

## §1 Provenance and confidence

- **activation:** active
- **phases:** onboarding-first-build, lifecycle-authoring, implementation-test-evidence, verify-ship-pr
- **material events:** 5
- **zero-event reason:** n/a
- Checkpoints: `feedback/checkpoints/roadmap-missing-exports-m3-higher-order-runtime-apis.jsonl` (5 events).
- Scope: isolated worker from exact `c26e516970ee59a5ab04a16626874f8d32233760`, Typed SDD work `005-m3-higher-order-runtime-apis`, one independent critique repair round, and candidate 0.1.4 package proof before protected-boundary orchestration.
- Pins exercised: .NET SDK 10.0.302, Fable 5.13.0, Babylon.js core/loaders 9.19.0, Chromium 151.0.7922.173.
- Confidence is high for committed artifacts and reproducible commands. No aggregate elapsed-time claim is made.

## §2 What worked

- A digest-verifying TypeScript AST scan made the arity decision reproducible across all 2,928 locked declaration files and corrected the roadmap proposal from 0–8 to 0–10 before implementation.
- Arity-indexed F# callable families, explicit decorator `this` calls, a callable `nativeOverride.filter`, and named both-member mixin results composed cleanly across .NET compilation and Fable emission.
- The 14-lane observed receipt combined three negative projects, emitted-call inspection, Node, Chromium, exact coverage/drift/analysis, and an isolated 0.1.4 packed consumer.
- Independent critique caught package-version evidence, null-versus-omitted decorator calls, and a private Background mixin-base identity before verify/ship.

## §3 What did not

- The default `dotnet` executable did not resolve the pinned SDK until the user-local SDK was placed first on PATH.
- Typed SDD child compilation also required explicit `DOTNET_ROOT` and `DOTNET_HOST_PATH` to avoid selecting the system SDK.
- The checkpoint attributes two failed clean-consumer attempts to reused 0.1.3 package metadata; the original failure output and resolved stale package identity were not preserved. The successful harness uses a consumer-scoped NuGet package cache, but the historical diagnosis remains confidence-limited.
- A post-ship refresh reported every generated view current but still refused an authored-content overwrite; the separate agents command confirmed both targets current. The command output was not committed, so this remains an observation rather than an actionable finding.

## §4 Findings

#### §4.1 Locked-declaration arity scanning turns a provisional API ladder into reviewable policy

- **Kind:** positive-pattern
- **Impact:** Binding maintainers can extend callable families to the observed callback maximum without erasing correlations or over-expanding to unrelated fixed methods.
- **Expected:** Callable arity policy is derived from the locked declaration closure and fails when file digests or adopted bounds drift.
- **Observed:** The scan verified 2,928 file hashes, reported callback maximum 10 and broader callable context maximum 17, and the maintained policy adopted only 0–10.
- **Evidence:** file:reports/m3-callable-arity-scan.json; command:npm run scan:m3-arity
- **Version:** Babylon.js 9.19.0 declaration lock
- **Owner:** BabylonjsBindings declaration-analysis and binding-policy scripts
- **Recurrence:** new
- **Avoidable cost:** none
- **Disposition:** accepted

## §5 Did not exercise

- Remote NuGet registry publication was not exercised; the required local feed was used.
- Browser GPU rendering and game playability were not applicable to these runtime helpers (`game_functionality=false`).
- M4–M6 exports were intentionally not touched.

## §6 Doc-versus-behavior contradictions

None observed.

## §7 Workarounds still in the tree

- `scripts/test-m3-clean-consumer.mjs` uses a temporary consumer-scoped `NUGET_PACKAGES`. Removal condition: every implementation proof uses a unique prerelease version or an independently evidenced alternative provides equal cache isolation. Risk: low; isolation strengthens determinism.
- M3 commands explicitly select the user-local .NET SDK. Removal condition: the worker image exposes pinned SDK 10.0.302 as its default. Risk: low and host-local; no absolute SDK path is stored in product source.

## §8 Friction and avoidable cost

- One SDK discovery retry and one Typed SDD host-selection retry occurred during onboarding/lifecycle authoring.
- Two clean-consumer retries preceded NuGet cache isolation.
- Independent critique required one bounded repair round for three major findings.
- One refresh inspection plus a separate agents command was needed after ship.
- No aggregate wall-clock estimate is asserted.

## §9 Skill value and gaps

- Invoked: work-roadmap and its host/ledger/feedback/critique contracts; full Typed SDD lifecycle and routed stages; feedback-report; fable-bindings; fable-interop; fable-testing; and fable-project.
- Binding guidance prevented `ParamArray<obj>`, `U2`, and unconstrained mixin-result shortcuts; testing guidance required emitted JavaScript, Node, Chromium, and packed-consumer proof.
- The critique contract materially improved acceptance accuracy by finding three gaps not detected by the initial green aggregate.
- No unavailable skill blocked the cycle; `pnext-item` was explicitly unavailable and its exact-SHA/PR discipline was preserved through the roadmap contract.

## §10 Outcome markers

- First build: passed with zero warnings/errors after selecting pinned SDK 10.0.302.
- First meaningful test: all 0–10 positive callable boundaries and three negative correlation projects compiled/rejected as intended.
- Full observed run: 14 tests passed in `reports/m3-higher-order-runtime-apis.trx`.
- Coverage: 4,287 typed / 35 blocked / 1 runtime-only / 0 lossy.
- First green verification: 20 supported and observed obligations, zero self-attested/synthetic.
- Ship readiness: `shipReady`, zero blocking findings, at `readiness/005-m3-higher-order-runtime-apis/ship-verdict.json`.
- Merge and final release: pending at report drafting.

## §11 Falsifiable improvements

- Preserve the consumer-scoped NuGet cache pattern noted in §3 for future package replacement tests; acceptance is a fresh temporary consumer resolving the newly packed assembly without consulting a pre-existing global BabylonjsBindings entry and recording package version plus a per-run artifact hash.
- Promote the arity scan pattern from §4.1 for future callable families; acceptance is digest verification of every locked declaration plus a committed report that distinguishes scoped callback maximum from broader callable context.

## §12 Development-surface coverage

| Surface | Status | Evidence and result |
|---|---|---|
| scaffolding | not-exercised | Existing repository and isolated worktree; no scaffold command run. |
| onboarding-guidance | exercised | Roadmap, AGENTS.md, and required skills/contracts guided the cycle. |
| skills | exercised | Roadmap, SDD, feedback, binding, interop, testing, and project skills were invoked. |
| sdd-authoring | exercised | Full Typed SDD lifecycle reached verificationReady and shipReady. |
| implementation-apis | exercised | Exactly eight higher-order runtime exports were added with arities 0–10 and named mixin results. |
| dependencies-build | exercised | Locked npm/declaration closure, pinned .NET build, coverage, drift, and analysis passed. |
| testing | exercised | Positive compile, three negative fixtures, Fable emission, Node, Chromium, and consumer passed. |
| evidence | exercised | Twenty obligations are supported/observed and critique schema-v3 validates after one repair. |
| runtime-playtest | exercised | Node and real Chromium executed applicable coroutine/decorator/mixin behavior. |
| performance | partial | No runtime benchmark was acceptance-relevant; deterministic scan/build execution was exercised. |
| documentation | exercised | Typed SDD, critique, receipts, and feedback artifacts were maintained. |
| packaging-upgrade | exercised | Candidate 0.1.4 packed consumer passed with exact npm dependencies, Node, and Chromium. |
| worker-git-pr | partial | Isolated worker/branch and exact-SHA critique were exercised; PR/merge was pending at draft time. |
