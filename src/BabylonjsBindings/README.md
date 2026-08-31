# BabylonjsBindings

This NuGet package contains curated Fable interop for `@babylonjs/core@9.19.0` and `@babylonjs/loaders@9.19.0`.
Consumers must separately install those exact npm runtime dependencies; this package never republishes them.

```bash
dotnet add package BabylonjsBindings --version 0.2.0
npm install --save-exact @babylonjs/core@9.19.0 @babylonjs/loaders@9.19.0
```

The package carries Femto npm-dependency metadata, so consumers that use Femto
can validate or resolve the JavaScript side with `dotnet femto --resolve`.
