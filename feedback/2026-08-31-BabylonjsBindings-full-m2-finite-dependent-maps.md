---
feedbackSchema: 2
date: 2026-08-31
workspace: BabylonjsBindings-full
cycle: roadmap-missing-exports-m2-finite-dependent-maps
lane: sdd
toolVersion: 1.5.0
commit: 325531220632c6a4537d719719d6a87c7ce1612f
---

# Development feedback — M2 finite dependent maps cycle

## §1 Provenance and confidence

- **activation:** active
- **phases:** onboarding-first-build, lifecycle-authoring, implementation-test-evidence, verify-ship-pr
- **material events:** 5
- **zero-event reason:** n/a
- Checkpoints: `feedback/checkpoints/roadmap-missing-exports-m2-finite-dependent-maps.jsonl` (5 events).
- Scope: isolated implementation worker from exact `origin/main` commit `99ead9f5b7d8d27b950e8d02c4e68f3d8a319436`, full Typed SDD lifecycle, two-round independent critique, implementation PR #6 and squash merge, then separate 0.1.3 release worktree and PR #7.
- Pins exercised: .NET SDK 10.0.302, Fable 5.13.0, Babylon.js core/loaders 9.19.0, Chromium 151.0.7922.173; ambient Node/npm were 26.8.1/12.0.2 while the repository requests 26.5.0/12.0.1.
- Confidence: high for committed artifacts and reproducible commands. No total elapsed duration is asserted. One checkpoint expanded the worker PATH; this report intentionally uses only workspace-relative evidence locators.

## §2 What worked

- The finite-table generator combined locked declaration inspection with exact 8/6/22 row projections, uniqueness checks, direct resolver/constructor signature checks, and negative compile fixtures.
- The testing stack composed maintained F# compilation, Fable emission, nine deep-import checks, Node, deterministic Chromium WebXR stubs, and a clean packed consumer under both Node and Chromium into one 13-test TRX receipt.
- SDD verification accepted 19 supported and observed obligations with zero self-attested or synthetic evidence, and emitted a compact durable ship verdict that the host check validates without transient views.
- The plan stage preserved Typed SDD authority by diagnosing performance text placed on a generated plan view and pointing to the correct spec-frontmatter source.

## §3 What did not

- The default `dotnet` executable did not satisfy strict SDK pin 10.0.302; the user-local installation had to be placed first on PATH, recurring from M0/M1.
- The first clean-consumer npm invocation inherited project-scoped `allow-scripts` settings; the harness was repaired to remove both environment spellings for its isolated child process.
- One `fsgg-sdd refresh` attempt reported all milestone views current alongside an overwrite refusal, but an exact-commit rerun blocked earlier for missing Typed SDD authority; the original JSON receipt was not preserved, so no actionable refresh claim is made.
- The release consumer runner assumed a prior restore while using `dotnet build --no-restore`, causing two avoidable fresh-worktree retries before the explicit project restore.

## §4 Findings

#### §4.1 Typed plan diagnostics identify intent authored on generated authority

- **Kind:** positive-pattern
- **Impact:** Typed SDD authors receive an explicit correction before generated plan prose can be mistaken for durable performance authority.
- **Expected:** Generated views identify their durable authority when authored intent is placed on the wrong surface.
- **Observed:** The plan stage emitted `performanceIntentReclaimed` for performance text on the generated plan surface and named typed spec front matter as the durable source.
- **Evidence:** command:fsgg-sdd plan --root . --work 004-m2-finite-dependent-maps; issue:FS-GG/FS.GG.SDD#821
- **Version:** FS.GG.SDD 1.5.0
- **Owner:** FS.GG.SDD plan authoring diagnostics
- **Recurrence:** seen again after FS-GG/FS.GG.SDD#821; merged PR FS-GG/FS.GG.SDD#823 introduced the reclaim diagnostic pattern
- **Avoidable cost:** none
- **Disposition:** accepted

#### §4.2 Clean-consumer release runner omits its fresh-worktree restore prerequisite

- **Kind:** friction
- **Impact:** A release worker following the clean-consumer command in a new worktree receives NETSDK1004 before any package or consumer proof runs.
- **Expected:** The release runner is self-contained for a clean worktree or documents and checks the required restore explicitly.
- **Observed:** The runner calls `dotnet build --no-restore`; it passed only after `dotnet restore src/BabylonjsBindings/BabylonjsBindings.fsproj --locked-mode` created the assets file.
- **Evidence:** file:scripts/test-m2-clean-consumer.mjs; file:feedback/checkpoints/roadmap-missing-exports-m2-finite-dependent-maps.jsonl; issue:EHotwagner/BabylonjsBindings-full#8
- **Version:** BabylonjsBindings release 0.1.3
- **Owner:** BabylonjsBindings release test scripts
- **Recurrence:** first reported in EHotwagner/BabylonjsBindings-full#8; the same `--no-restore` implementation pattern predates M2 in the M1 runner, but no earlier failure report was found
- **Avoidable cost:** two release-loop retries
- **Disposition:** issue

## §5 Did not exercise

- Registry publication and installation from a remote NuGet registry were not exercised; the release proof used the required local feed.
- Physical XR hardware was intentionally not exercised; deterministic browser stubs covered the WebXR session boundary.
- Game playability was not applicable (`game_functionality=false`).

## §6 Doc-versus-behavior contradictions

None observed. The refresh issue in §4.2 is a command-result composition problem, not a contradiction in the loaded guidance.

## §7 Workarounds still in the tree

- `scripts/test-m2-clean-consumer.mjs` removes inherited `npm_config_allow_scripts` and `NPM_CONFIG_ALLOW_SCRIPTS` only for spawned clean-consumer commands. Removal condition: npm no longer treats a host project-scoped list as configuration for the temporary consumer. Risk: low; the isolation does not change repository or user npm policy.
- The release workflow currently performs an explicit locked restore before invoking the runner. Removal condition: §4.3 is fixed by making the runner self-contained or by a checked prerequisite. Risk: low but easy to omit in another fresh worktree.

## §8 Friction and avoidable cost

- One strict-SDK restore failure recurred from M0/M1; it remains an accepted host observation because no stable worker-image identity or routable provisioning owner is available.
- One inherited npm-configuration failure led to a committed, isolated harness correction.
- Independent critique required two repair rounds: the first closed negative/browser gaps but exposed remaining named-resolver and FlowGraph discriminator-shape mismatches; the second closed them.
- One refresh diagnostic inspection and separate agents invocation were required, but the exact original diagnostic was not preserved and a cold exact-commit rerun did not reproduce the overwrite conflict; this remains a historical checkpoint only.
- Two fresh-release retries preceded the explicit packable-project restore (§4.2).
- No aggregate wall-clock estimate is asserted.

## §9 Skill value and gaps

- Invoked: work-roadmap; FS.GG SDD lifecycle, Typed authoring, every routed stage, refresh, agents, and validation contracts; feedback-report; fable-bindings; fable-interop; fable-testing; and fable-project.
- Binding and testing guidance materially shaped singleton/overload projections, rejected broad unions as acceptance, and required emitted/package/browser proof.
- The roadmap critique contract caught four major gaps and held verify/ship until the same critic confirmed two repair rounds.
- The feedback skill forced immediate preservation of refresh and release-runner friction that would otherwise be lost after successful retries.

## §10 Outcome markers

- First build: strict SDK selection required one correction; the pinned-SDK maintained build then passed with zero warnings/errors.
- First meaningful test: complete 8 DeviceType, 6 FlowGraph, and 22 WebXR tables with 36 unique signatures and zero collapsed signatures.
- Full observed run: 13 aggregate tests passed in `reports/m2-finite-dependent-maps.trx`, including eight negative projects, Node, and Chromium.
- First green verification: 19 supported and 19 observed obligations, zero self-attested/synthetic.
- Ship readiness: `shipReady` with zero blocking findings in `readiness/004-m2-finite-dependent-maps/ship-verdict.json`.
- Implementation merge: PR #6 squash-merged as `0962dc3f6238ccf4927e43608345e32a8fe3b1ca` after both CI jobs passed.
- Release: PR #7 opened with 0.1.3 local-feed package and clean Node/Chromium consumer evidence; merge was pending at report drafting.

## §11 Falsifiable improvements

- For §4.2, the clean-consumer runner should restore its packable project (locked) or fail immediately with a named prerequisite; acceptance is the runner succeeding from a fresh Git archive with no pre-existing `obj/project.assets.json`.

## §12 Development-surface coverage

| Surface | Status | Evidence and result |
|---|---|---|
| scaffolding | not-exercised | Existing repository and worktrees; no scaffold command run. |
| onboarding-guidance | exercised | Roadmap, AGENTS.md, and required skill/contracts were read before lifecycle work. |
| skills | exercised | Roadmap, SDD, feedback, binding, interop, testing, and project skills drove the cycle. |
| sdd-authoring | exercised | Full Typed SDD lifecycle reached verificationReady and shipReady. |
| implementation-apis | exercised | Twenty-seven finite dependent-map exports were implemented with exact specialized views. |
| dependencies-build | exercised | Locked npm/declaration closure, pinned .NET build, coverage, and deterministic analysis passed. |
| testing | exercised | Compile, eight negative fixtures, emission/imports, Node, Chromium, and clean consumer passed. |
| evidence | exercised | Nineteen obligations are supported/observed; critique schema-v3 validates after two rounds. |
| runtime-playtest | exercised | Node and deterministic Chromium WebXR runtime paths ran; physical hardware was intentionally unnecessary. |
| performance | partial | Typed performance intent was authored and diagnosed; no benchmark was applicable to binding declarations. |
| documentation | exercised | SDD, critique, release receipt, feedback, and roadmap ledger were maintained. |
| packaging-upgrade | exercised | Both packable projects were packed; clean 0.1.3 Node/Chromium consumer and cache cleanup passed. |
| worker-git-pr | exercised | Isolated implementation/release worktrees, PR #6 merge, branch cleanup, and release PR #7 were exercised. |
