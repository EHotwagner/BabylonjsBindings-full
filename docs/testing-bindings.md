# Testing the bindings

Run the complete maintained binding test matrix with:

```bash
npm test
```

The command is intentionally broader than a .NET build. It verifies the exact
declaration inventory, compiles the F# surface, emits and executes JavaScript,
loads every maintained Babylon.js module import, exercises Node and Chromium,
checks negative compile fixtures, and installs the packed binding into a clean
consumer.

## Test layers

| Layer | Proof |
| --- | --- |
| Declaration inventory | Every typed coverage identity has exactly one reviewed maintained-manifest owner; locked declaration and tool versions match repository policy. |
| Runtime imports | Every `Import`, `ImportAll`, and `ImportDefault` resolves to an exact modular Babylon.js package path, and every named import exists at runtime. |
| .NET compilation | The complete solution builds from locked NuGet restores. Negative fixtures prove deliberately unsupported generic and overload shapes remain rejected. |
| Cross-runtime fixture | The same canonical enum/value fixture runs under .NET and Fable-emitted Node JavaScript and must produce identical JSON. |
| Full Fable emission | The entire binding project emits JavaScript; generated imports and maintained namespace/runtime shapes are checked before execution. |
| Node | Base, M2, M3, M5, and full-emission smoke programs execute against the pinned Babylon.js packages. |
| Chromium | M2 and M3 browser fixtures execute in headless Chromium against browser-real module loading. |
| Analysis and coverage | Analysis unit, determinism, drift, and complete-coverage checks prove all locked declarations remain classified. |
| Packed consumer | A clean temporary consumer installs the produced NuGet package and pinned npm packages, then builds, emits, and runs it. |

The comprehensive runner writes machine-readable evidence to:

- `reports/bindings-comprehensive.json`
- `reports/bindings-comprehensive.junit.xml`
- `reports/bindings-runtime-import-inventory.json`
- `reports/bindings-cross-runtime.json`

Focused commands are available when iterating:

```bash
npm run test:bindings:inventory
npm run test:bindings:cross-runtime
npm run test:m2-node
npm run test:m3-node
npm run test:m5-node
npm run test:m2-browser
npm run test:m3-browser
```

`./build.sh` includes the fast inventory and runtime-import layer. Use
`npm test` for release-boundary evidence across every runtime and packaging
layer.
