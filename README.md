# BabylonjsBindings

[![CI](https://github.com/EHotwagner/BabylonjsBindings-full/actions/workflows/ci.yml/badge.svg)](https://github.com/EHotwagner/BabylonjsBindings-full/actions/workflows/ci.yml)
[![GitHub release](https://img.shields.io/github/v/release/EHotwagner/BabylonjsBindings-full)](https://github.com/EHotwagner/BabylonjsBindings-full/releases/latest)

Complete, version-locked Fable bindings for Babylon.js, covering
`@babylonjs/core@9.19.0` and `@babylonjs/loaders@9.19.0`.

| Current state | Value |
| --- | --- |
| Latest release | [v0.2.0](https://github.com/EHotwagner/BabylonjsBindings-full/releases/tag/v0.2.0), distributed on GitHub |
| Development version | 0.2.1 on `main` |
| Typed exports | 4,322 of 4,323 |
| Runtime-only exports | 1 intentional loader-registration side effect |
| Blocked / lossy exports | 0 / 0 |
| Qualified toolchain | Fable 5.13.0, Fable.Core 5.2.0, Babylon.js 9.19.0 |

## Install the current release

Version 0.2.0 is currently a **GitHub release, not a NuGet.org publication**.
Download the package into a local source and reference it explicitly:

```bash
mkdir -p packages
curl -L \
  -o packages/BabylonjsBindings.0.2.0.nupkg \
  https://github.com/EHotwagner/BabylonjsBindings-full/releases/download/v0.2.0/BabylonjsBindings.0.2.0.nupkg

dotnet add YourApp.fsproj package BabylonjsBindings \
  --version 0.2.0 \
  --source ./packages

npm install --save-exact \
  @babylonjs/core@9.19.0 \
  @babylonjs/loaders@9.19.0
```

The binding package contains the F#/.NET API only. Babylon.js remains a native
JavaScript dependency and is installed separately from npm. NuGet.org
publication is intentionally deferred until its release workflow is completed
and verified.

## Try the Village Starter scene

[`examples/VillageStarter`](examples/VillageStarter/) recreates Babylon.js
Getting Started Chapter 4 with the village, animated car and wheels, walking
Dude, collision zone, and interactive arc-rotate camera.

```bash
npm ci
npm run build:village
npm run test:village-browser -- --headed
```

The last command opens and validates the scene in a real Chromium window.

## Build and test

```bash
npm ci
npm test
```

The comprehensive suite runs 26 checks across locked .NET builds, Fable
compilation, emitted JavaScript imports, Node, Chromium, export coverage,
package shape, and an isolated clean consumer. See
[`docs/testing-bindings.md`](docs/testing-bindings.md) for the test inventory
and [`docs/publishing-bindings.md`](docs/publishing-bindings.md) for the current
distribution boundary and eventual NuGet procedure.

## How the bindings are maintained

`npm run generate:candidate` writes only tracked `generated-candidates/`; it never overwrites maintained source or advances the declaration lock. `npm run check:drift` follows every selected relative declaration import/export and fails on changed transitive hashes. Unsupported TypeScript constructs must be recorded in `coverage-and-drift.json`, never silently exposed as `obj`. Product skills are supplied by the Templates-owned `fable-bindings` skill manifest rather than copied into this provider template. Local proof precedes publication and any registry/wizard activation.

`npm run coverage:generate` inventories every reachable module export in the locked core/loaders declaration graph and assigns a typed, runtime-only, blocked, or lossy disposition. `npm run coverage:check` validates the report schema and input digests; `npm run coverage:require-complete` fails while any modular export is blocked or lossy. Legacy `ts2fable` monolithic-bundle diagnostics remain visible as comparison evidence but are not modular export gaps. A compile-clean generated candidate does not count as typed maintained coverage.

The maintained surface combines reviewed simple projections, finite dependent maps, arity-indexed higher-order APIs, a 155-use closed-world type-function registry with seven fixed tensor/vector shapes, and checker-derived glTF namespace facades. Module-qualified identities keep colliding declarations distinct. GLTF1/GLTF2 expose all 51/158 declaration names and runtime namespace interfaces for the exact 14/114 JavaScript keys. Mutually recursive aliases, interfaces, and classes compile through the derived `SimpleTypes.fs` projection while their reviewed fragments remain independently auditable. `npm run test:m6-release` runs the complete drift, .NET, Fable, emitted-import, Node, Chromium, coverage, package, and isolated-consumer matrix.

## Package locking

`./build.sh` (also `npm run build`) is this workspace's .NET entrypoint: it asserts the lockfiles, restores in locked mode, builds, then runs the pinned npm install, doctor, drift and Node runtime lanes.

This workspace restores in **locked mode** (`RestoreLockedMode` in `Directory.Build.props`), so every `packages.lock.json` beside a project is enforced: a package whose content hash differs from the committed one fails the restore rather than being silently substituted.

Locked mode is only meaningful if the lock can be regenerated, so here is the path. After changing any `PackageVersion` in `Directory.Packages.props` or any `PackageReference`, regenerate and commit the affected locks:

```bash
dotnet restore BabylonjsBindings.slnx --force-evaluate
```

Never hand-edit a lock file; a hash typed by a human is a hash no restore can reproduce.

Three settings keep those hashes reproducible, and all are load-bearing (see `FS.GG.Templates#384`, whose root cause was established by `#380`):

- **`NuGet.config` pins the source.** Its `<clear />` drops every source inherited from the machine, so a package is never served by whatever local feed the host happens to configure. To use a private or mirrored feed, add it there and then regenerate the locks with the command above.
- **`DisableImplicitLibraryPacksFolder` in `Directory.Build.props`** stops the F# SDK appending its own bundled `library-packs` folder to the restore sources. That folder ships an `FSharp.Core` archive with the same version as nuget.org's but different bytes, so leaving it enabled lets one restore record one content hash and the next restore reject it with `NU1403: Package content hash validation failed`. These projects target `netstandard2.1` and resolve FSharp.Core 4.7.2 transitively, which the SDK folder does not ship, so today this is a forward guardrail rather than a live repair — it stops the collision arriving unobserved when a floor or a target framework moves.
- **`RestorePackagesPath` in `Directory.Build.props`** gives this workspace its own `.nuget/packages` folder instead of the machine-wide one. Source pinning alone is not enough: NuGet's shared package folder is keyed by id and version only, so whichever build reached it first decides which archive lives there, and a later restore validates the committed hash against *that* entry. A private folder is what makes the committed hash enforceable on any machine rather than only on machines that happen to agree. Two consequences worth knowing: packages are not shared with your other checkouts, so a cold build downloads its own copies; and `.nuget/` belongs in your ignore file — this workspace ships without one, in common with `bin/`, `obj/` and `node_modules/`.

`build.sh` refuses to restore at all if the lock files are missing, and `npm run doctor` fails on the same condition, because a locked-mode restore with no lock on disk does not fail — it quietly writes a new lock from whatever the machine resolves, which defeats the entire mechanism.

## Continuous integration

GitHub Actions runs two independent lanes so comprehensive candidate proof does not lengthen feedback from the maintained-source build:

- **Locked build and drift** runs `./build.sh`, including locked .NET/npm restores, proposal drift checks, coverage validation, and the maintained Node smoke.
- **Full candidate and clean consumer** regenerates the review-only declaration candidate, checks its deterministic artifacts, then runs F# and Fable compilation, exact import resolution, Node and pinned Chromium smokes, and the isolated packed-package consumer. It runs for pull requests, manual dispatches, and push commits marked `[full-ci]`; ordinary checkpoint pushes use only the fast lane.

The workflow pins action revisions and tool versions, caches only lock-keyed npm/NuGet downloads, grants read-only repository access, cancels superseded runs on the same ref, and never publishes packages.

`node scripts/lifecycle-evidence.mjs --expect clean --junit reports/bindings.junit.xml --handoff readiness/002-bindings-upstream-review/governance-handoff.json` turns the executable closure check into runner evidence and a narrow upstream-review verdict. `npm run test:lifecycle` first records the Governance F# public-surface receipt, then imports the report into the supported SDD lifecycle and requires observed verification, ship readiness, and a coherent doctor result. The composition acceptance routes both the SDD-emitted handoff and the upstream-review verdict through Governance: unchanged pins pass, while upstream declaration drift is a blocking review state. These commands are local acceptance only; they do not publish or activate the provider.
