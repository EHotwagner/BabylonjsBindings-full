import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const manifest = JSON.parse(await readFile(resolve(root, "generated-candidates/SimpleVariables.promotion.json"), "utf8"));
if (manifest.schemaVersion !== 1 || manifest.source?.packageVersion !== "9.19.0") throw new Error("variable import check requires the locked candidate manifest");

const imports = [];
for (const entry of manifest.exports) {
  const specifier = `${entry.module}.js`;
  const runtimeExport = entry.runtimeExport ?? entry.name;
  const imported = await import(specifier);
  if (!Object.hasOwn(imported, runtimeExport)) throw new Error(`${specifier} does not export ${runtimeExport} for ${entry.name}`);
  const source = await readFile(resolve(root, "node_modules", specifier));
  imports.push({
    package: entry.package,
    module: specifier,
    export: entry.name,
    runtimeExport,
    moduleSha256: createHash("sha256").update(source).digest("hex")
  });
}
const evidence = {
  schemaVersion: 1,
  packages: [
    { name: "@babylonjs/core", version: "9.19.0" },
    { name: "@babylonjs/loaders", version: "9.19.0" }
  ],
  target: "review-candidate",
  imports,
  status: "pass"
};
await writeFile(resolve(root, "generated-candidates/runtime/variable-import-evidence.json"), `${JSON.stringify(evidence, null, 2)}\n`);
console.log(`resolved ${imports.length} candidate variable exports from exact Babylon modules`);
