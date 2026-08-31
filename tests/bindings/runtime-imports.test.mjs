import assert from "node:assert/strict";
import { createHash } from "node:crypto";
import { mkdir, readFile, stat, writeFile } from "node:fs/promises";
import { relative, resolve, sep } from "node:path";
import test from "node:test";

const root = resolve(import.meta.dirname, "../..");
const normalize = path => relative(root, path).split(sep).join("/");
const sha256 = value => createHash("sha256").update(value).digest("hex");

test("every maintained Fable import resolves and exports its requested runtime member", { timeout: 180000 }, async () => {
  const project = await readFile(resolve(root, "src/BabylonjsBindings/BabylonjsBindings.fsproj"), "utf8");
  const includes = [...project.matchAll(/<Compile Include="([^"]+)"\s*\/>/g)].map(match => match[1]);
  assert.ok(includes.length >= 10, "expected maintained F# compile inputs");
  const requests = [];
  for (const include of includes) {
    const path = resolve(root, "src/BabylonjsBindings", include);
    const source = await readFile(path, "utf8");
    for (const match of source.matchAll(/\[<Import\("([^"]+)",\s*"([^"]+)"\)>\]/g)) requests.push({ kind: "named", runtimeExport: match[1], specifier: match[2], source: normalize(path) });
    for (const match of source.matchAll(/\[<ImportAll\("([^"]+)"\)>\]/g)) requests.push({ kind: "all", specifier: match[1], source: normalize(path) });
    for (const match of source.matchAll(/\[<ImportDefault\("([^"]+)"\)>\]/g)) requests.push({ kind: "named", runtimeExport: "default", specifier: match[1], source: normalize(path) });
  }
  assert.ok(requests.length > 3000, `expected broad runtime surface, found ${requests.length}`);
  const byModule = new Map();
  for (const request of requests) {
    assert.match(request.specifier, /^@babylonjs\/(core|loaders)\/.+\.js$/, `${request.source}: ${request.specifier}`);
    const entries = byModule.get(request.specifier) ?? [];
    entries.push(request); byModule.set(request.specifier, entries);
  }
  const modules = [...byModule].sort(([a], [b]) => a.localeCompare(b));
  const evidence = [];
  let cursor = 0;
  const workers = Array.from({ length: 12 }, async () => {
    while (cursor < modules.length) {
      const [specifier, entries] = modules[cursor++];
      const packageName = specifier.startsWith("@babylonjs/core/") ? "@babylonjs/core" : "@babylonjs/loaders";
      const path = resolve(root, "node_modules", packageName, specifier.slice(packageName.length + 1));
      assert.equal((await stat(path)).isFile(), true, specifier);
      const imported = await import(specifier);
      for (const entry of entries) if (entry.kind === "named") assert.ok(Object.hasOwn(imported, entry.runtimeExport), `${specifier} missing ${entry.runtimeExport}`);
      evidence.push({ specifier, sha256: sha256(await readFile(path)), requestedExports: [...new Set(entries.filter(item => item.kind === "named").map(item => item.runtimeExport))].sort(), sources: [...new Set(entries.map(item => item.source))].sort() });
    }
  });
  await Promise.all(workers);
  evidence.sort((a, b) => a.specifier.localeCompare(b.specifier));
  const report = { schemaVersion: 1, result: "pass", requestCount: requests.length, moduleCount: evidence.length, modules: evidence };
  await mkdir(resolve(root, "reports"), { recursive: true });
  await writeFile(resolve(root, "reports/bindings-runtime-import-inventory.json"), `${JSON.stringify(report, null, 2)}\n`);
  assert.ok(evidence.some(item => item.specifier.startsWith("@babylonjs/core/")));
  assert.ok(evidence.some(item => item.specifier.startsWith("@babylonjs/loaders/")));
});
