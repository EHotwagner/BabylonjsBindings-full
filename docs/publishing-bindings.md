# Publishing the Fable bindings

Fable bindings are published as NuGet packages. The NuGet artifact contains the
F#/.NET binding API; it does not bundle the JavaScript implementation. Consumers
install the binding from NuGet and separately install its native npm packages.

This project therefore uses:

- `Fable.Package.SDK` with `FablePackageType` set to `binding`;
- the `fable-javascript` package target tag;
- private build-only assets for `Fable.Package.SDK`;
- exact Femto metadata for `@babylonjs/core@9.19.0` and
  `@babylonjs/loaders@9.19.0`;
- a clean consumer test that installs both the packed NuGet artifact and the
  exact npm runtime closure before Fable compilation and execution.

## Release procedure

1. Bump `<Version>` in `src/BabylonjsBindings/BabylonjsBindings.fsproj`.
2. Run the full release proof:

   ```bash
   npm test
   ```

3. Pack the reviewed commit:

   ```bash
   dotnet restore BabylonjsBindings.slnx --locked-mode
   dotnet pack src/BabylonjsBindings/BabylonjsBindings.fsproj \
     -c Release --no-restore -o artifacts/release-package
   ```

4. Inspect the `.nupkg` metadata and install it into a clean consumer. The
   package must identify itself as a JavaScript binding, must not expose
   `Fable.Package.SDK` as a runtime dependency, and must resolve emitted imports
   only against the exact Babylon.js npm versions.
5. Publish with a scoped NuGet.org API key:

   ```bash
   dotnet nuget push artifacts/release-package/BabylonjsBindings.<version>.nupkg \
     --api-key "$NUGET_API_KEY" \
     --source https://api.nuget.org/v3/index.json
   ```

6. Verify the immutable package from NuGet.org in another clean consumer.
   After NuGet indexing, the package is also discovered by the Fable Packages
   catalogue; no separate Fable registry upload is required.

Never store the API key in the repository or publish directly from an untested
working tree. The repository CI deliberately proves artifacts but does not
publish them.

## References

- [Fable: Author a Fable package](https://fable.io/docs/your-fable-project/author-a-fable-library.html)
- [Fable: Use a Fable library](https://fable.io/docs/your-fable-project/use-a-fable-library.html)
- [Fable.Package.SDK](https://github.com/fable-compiler/Fable.Package.SDK)
- [Femto native dependency metadata](https://github.com/Zaid-Ajaj/Femto#library-authors-with-javascript)
- [Microsoft: Publish NuGet packages](https://learn.microsoft.com/nuget/nuget-org/publish-a-package)
