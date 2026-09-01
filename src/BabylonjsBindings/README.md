# BabylonjsBindings

This package contains curated Fable interop for `@babylonjs/core@9.19.0` and
`@babylonjs/loaders@9.19.0`. It covers 4,322 typed exports, with one intentional
runtime-only loader-registration side effect and no blocked or lossy exports.

Version 0.2.0 is distributed from the GitHub release page and is not yet
published to NuGet.org. Download `BabylonjsBindings.0.2.0.nupkg` into a local
package directory, then install it explicitly:

```bash
dotnet add YourApp.fsproj package BabylonjsBindings \
  --version 0.2.0 \
  --source ./packages

npm install --save-exact @babylonjs/core@9.19.0 @babylonjs/loaders@9.19.0
```

Consumers must install those exact npm runtime dependencies separately; the
binding package never republishes Babylon.js.

The package carries Femto npm-dependency metadata, so consumers that use Femto
can validate or resolve the JavaScript side with `dotnet femto --resolve`.

Release: <https://github.com/EHotwagner/BabylonjsBindings-full/releases/tag/v0.2.0>
