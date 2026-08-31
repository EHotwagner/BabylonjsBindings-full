---
feedbackSchema: 2
date: 2026-08-31
workspace: BabylonjsBindings-full
cycle: roadmap-missing-exports-m0-analysis-infrastructure
lane: sdd
toolVersion: 1.5.0
commit: da89a968e7d13dca3e7622d023c02946813beba7
---

# Development feedback — M0 analysis infrastructure

## §1 Provenance and confidence

- **activation:** active
- **phases:** onboarding-first-build, lifecycle-authoring, implementation-test-evidence, verify-ship-pr
- **material events:** 5
- **zero-event reason:** n/a
- Checkpoints: `feedback/checkpoints/roadmap-missing-exports-m0-analysis-infrastructure.jsonl` (5 events).
- Scope: isolated worker from `origin/main` through SDD charter, specify, clarify, checklist, plan, tasks, analyze, implementation, evidence, verify, ship, critique, and draft PR #2.
- Pins exercised: .NET SDK 10.0.302, Node 26.5.0, npm 12.0.1, Fable 5.13.0, Fable.Core 5.2.0, Babylon.js 9.19.0.
- Confidence: high for the commands and repository artifacts cited below; elapsed wall-clock durations were not reconstructed.

## §2 What worked

- The typed SDD gates, observed-run evidence receipts, durable ship verdict, critique validator, and feedback invalidation guard composed into an inspectable merge boundary.
- Exact local tool installations and an isolated npm user configuration allowed the locked repository build to run without weakening repository pins or changing user configuration.

## §3 What did not

- Referenced lifecycle worked examples were absent from the product checkout.
- The worker image did not contain the exact SDK/Node/npm set required by the repository.
- Typed SDD subprocess hosting and npm inherited ambient host configuration until the worker explicitly aligned or isolated it.
- Three checkpointed observations could not support an actionable finding after cold evidence review; their reduced dispositions are retained in §8.

## §4 Findings

#### §4.1 Lifecycle skill examples are not packaged with the product

- **Kind:** documentation
- **Impact:** An SDD author could not read the worked examples each per-stage skill declares authoritative and had to infer artifact shape from existing work items.
- **Expected:** The referenced `docs/examples/lifecycle-artifacts/` corpus is available wherever the per-stage skills are installed.
- **Observed:** The referenced directory is absent in this checkout.
- **Evidence:** command:test -d docs/examples/lifecycle-artifacts; issue:FS-GG/FS.GG.SDD#539
- **Version:** FS.GG.SDD skills shipped with tool 1.5.0
- **Owner:** FS.GG.SDD skill packaging
- **Recurrence:** seen again in this cycle; existing issue FS-GG/FS.GG.SDD#539 records the same unavailable-product-doc-path root cause, while its PR #543 repointed diagnostic remediation to vendored skills and did not cover the distinct per-stage-skill references observed here
- **Avoidable cost:** one failed reference-reading pass and substitution with existing work artifacts
- **Disposition:** existing issue

## §5 Did not exercise

- Runtime browser playtesting and performance measurement were outside this non-game analysis milestone.
- Package publication and registry activation were not exercised because maintained API/package content did not change.

## §6 Doc-versus-behavior contradictions

- The per-stage SDD skills require `docs/examples/lifecycle-artifacts/` to be read first, but the directory is not packaged in this checkout; see §4.1.

## §7 Workarounds still in the tree

None observed. Exact SDK/Node/npm installs and the empty npm user config were external ephemeral worker setup and were not committed.

## §8 Friction and avoidable cost

- Two initial toolchain/configuration failures, one typed-author host-selection retry, one missing-reference pass, and one draft PR backfill cycle.
- Command durations were not aggregated; no elapsed-time estimate is asserted.
- Checkpoint 1 is deduplicated to existing issue FS-GG/FS.GG.SDD#539 (§4.1).
- Checkpoint 2 is retained only as an accepted observation: the strict-pin failure is reproducible (`/usr/bin/dotnet` exposes 6.0.428 and 10.0.400, not required 10.0.302), but the worker exposes neither a concrete image identifier nor a routable provisioning owner, so it cannot support an actionable finding.
- Checkpoint 3 is retained only as an accepted historical observation: the original compiler diagnostic and exact failing environment were not preserved, so no actionable typed-hosting claim is made.
- Checkpoint 4 is retained only as an accepted historical observation: the original npm diagnostic was not preserved and a current exact-version rerun no longer reproduces it, so no actionable npm claim is made.
- Checkpoint 5 is not retained as a finding: cold review confirmed that existing work-roadmap guidance already prescribes immediate post-open PR-number backfill; the observed extra commit is ordinary orchestration.

## §9 Skill value and gaps

- Invoked: work-roadmap, FS.GG SDD lifecycle and stage skills, typed-author, feedback-report, fable-bindings, fable-project, and fable-testing.
- The critique contract exposed three material implementation gaps before verify; all were repaired and confirmed in one round.
- The SDD skill reference gap is deduplicated in §4.1; weaker or unroutable checkpoint claims were reduced in §8 after independent review.

## §10 Outcome markers

- First build: reached .NET compilation before ambient npm configuration blocked; the isolated-config rerun passed all locked build gates.
- First meaningful test: 4 focused analysis tests, expanded to 8 after independent critique.
- First green verification: SDD verify recorded 8 supported and 8 observed evidence declarations.
- Ship readiness: SDD ship recorded `shipReady` with zero blockers.
- Merge: not yet performed; draft PR #2 is the protected-boundary handoff at report finalization.

## §11 Falsifiable improvements

- For §4.1, FS.GG.SDD skill packaging should include every referenced worked example; acceptance is that `test -d docs/examples/lifecycle-artifacts` and all seven referenced file checks pass in a scaffolded product.

## §12 Development-surface coverage

| Surface | Status | Evidence and result |
|---|---|---|
| scaffolding | not-exercised | Existing repository; no scaffold command run. |
| onboarding-guidance | partial | Read AGENTS.md and early-stage guidance; worked examples were missing. |
| skills | exercised | Roadmap, SDD, feedback, binding, project, and testing skills were invoked. |
| sdd-authoring | exercised | Full typed SDD lifecycle reached shipReady. |
| implementation-apis | exercised | Analysis library, generator, schemas, and CLI scripts were implemented. |
| dependencies-build | exercised | Locked restore/build, exact npm install, proposal checks, and runtime smoke passed. |
| testing | exercised | Eight focused/aggregate checks passed with a committed TRX receipt. |
| evidence | exercised | Eight SDD obligations are supported and observed. |
| runtime-playtest | not-exercised | Non-game analysis milestone. |
| performance | not-exercised | No performance-sensitive functionality changed. |
| documentation | exercised | Roadmap ledger and lifecycle/report artifacts were authored. |
| packaging-upgrade | partial | Package build occurred; version bump/publication were not applicable because maintained API/package content did not change. |
| worker-git-pr | exercised | Isolated worktree, exact commit review, draft PR #2, and historical audit invalidation guard were exercised. |
