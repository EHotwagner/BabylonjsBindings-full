# Full Babylon.js candidate proposal

- Source: `babylonjs@9.19.0/babylon.module.d.ts` (SHA-256 `8fc0a46461ab5909d3eac13032a2a17e24a86317251500302a13e2fca8d9e651`)
- Candidate: 117,225 lines (SHA-256 `c6a4de040e2c567359b11f7f0fd4ceed069cdb618f4288591cc23d84a3ac9763`)
- Loaders source: `babylonjs-loaders@9.19.0/babylonjs.loaders.module.d.ts` (SHA-256 `7cd12a3b7152867f045ad440581ec8cdad0d9cb30305e3de5229b9149d5dbffb`)
- Loaders candidate: 7,583 lines (SHA-256 `82cb8f78f88c70c1460c7be91be4cbaf5f4a561ecfac1ad1ed970fb7d57315ae`)
- glTF2 interface candidate: 719 lines (SHA-256 `53ed8a36bfe892d1f2222e1fc2bd0c412f1a314a770be226b7d59d6b6a88ffdb`)
- Converter: `ts2fable@0.9.0-build.738` with `typescript@5.1.6`
- Unique unsupported diagnostics: 8
- Unique loaders unsupported diagnostics: 4
- Unique glTF2 interface unsupported diagnostics: 2

This is a deterministic, review-only inventory. It never overwrites `src/` or advances `declaration-lock.json`.
Promotion requires a clean F# compile, modular import resolution, per-export non-lossy coverage, and runtime evidence.
