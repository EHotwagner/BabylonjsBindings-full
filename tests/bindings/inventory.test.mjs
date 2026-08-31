import assert from "node:assert/strict";
import { createHash } from "node:crypto";
import { readFile } from "node:fs/promises";
import { resolve } from "node:path";
import test from "node:test";

const root = resolve(import.meta.dirname, "../..");
const manifestPaths = [
  "src/BabylonjsBindings/coverage-manifest.json",
  "src/BabylonjsBindings/string-coverage-manifest.json",
  "src/BabylonjsBindings/object-type-coverage-manifest.json",
  "src/BabylonjsBindings/type-alias-coverage-manifest.json",
  "src/BabylonjsBindings/simple-interface-coverage-manifest.json",
  "src/BabylonjsBindings/simple-class-coverage-manifest.json",
  "src/BabylonjsBindings/simple-function-coverage-manifest.json",
  "src/BabylonjsBindings/simple-variable-coverage-manifest.json",
  "src/BabylonjsBindings/m2-finite-dependent-map-coverage-manifest.json",
  "src/BabylonjsBindings/m3-higher-order-runtime-coverage-manifest.json",
  "src/BabylonjsBindings/m4-type-function-core-coverage-manifest.json",
  "src/BabylonjsBindings/m5-gltf-namespace-coverage-manifest.json"
];
const identity = item => `${item.package}|${item.module}|${item.name}`;
const json = async path => JSON.parse(await readFile(resolve(root, path), "utf8"));

test("every typed locked export is owned by exactly one maintained manifest", async () => {
  const coverage = await json("coverage-and-drift.json");
  assert.deepEqual(coverage.summary, { total: 4323, typed: 4322, runtimeOnly: 1, blocked: 0, lossy: 0 });
  assert.equal(coverage.status, "complete");
  const typed = coverage.exports.filter(item => item.disposition === "typed");
  const manifestEntries = [];
  for (const path of manifestPaths) {
    const manifest = await json(path);
    assert.equal(manifest.schemaVersion, 1, `${path} schema`);
    assert.equal(manifest.reviewStatus, "maintained", `${path} review status`);
    manifestEntries.push(...manifest.exports.map(item => ({ ...item, owner: path })));
  }
  const counts = new Map();
  for (const item of manifestEntries) counts.set(identity(item), (counts.get(identity(item)) ?? 0) + 1);
  assert.deepEqual([...counts].filter(([, count]) => count !== 1), [], "duplicate manifest ownership");
  assert.deepEqual([...counts.keys()].sort(), typed.map(identity).sort(), "manifest/coverage identity equality");
  for (const item of manifestEntries) {
    assert.equal(item.disposition, "typed", identity(item));
    assert.match(item.fsharpSymbol, /^(BabylonjsBindings|Qualification\.Babylon)\./, identity(item));
  }
});

test("locked package, declaration, compiler and npm versions remain exact", async () => {
  const packageJson = await json("package.json");
  const packageLock = await json("package-lock.json");
  const declarationLock = await json("declaration-lock.json");
  const tools = await json(".config/dotnet-tools.json");
  const global = await json("global.json");
  assert.equal(packageJson.dependencies["@babylonjs/core"], "9.19.0");
  assert.equal(packageJson.dependencies["@babylonjs/loaders"], "9.19.0");
  assert.equal(packageLock.packages["node_modules/@babylonjs/core"].version, "9.19.0");
  assert.equal(packageLock.packages["node_modules/@babylonjs/loaders"].version, "9.19.0");
  assert.equal(declarationLock.files.length, 2928);
  assert.equal(tools.tools.fable.version, "5.13.0");
  assert.equal(global.sdk.version, "10.0.302");
  assert.equal(packageJson.engines.node, "26.5.0");
  assert.equal(packageJson.engines.npm, "12.0.1");
});

test("M4 and M5 closed-world inventories are complete and non-lossy", async () => {
  const m4 = await json("analysis/m4-type-function-core-manifest.json");
  const m5 = await json("analysis/m5-gltf-namespace-manifest.json");
  assert.equal(m4.lockedFileCount, 2928);
  assert.equal(m4.instantiationCount, 155);
  assert.equal(m4.fixedShapes.length, 7);
  assert.deepEqual(m4.fixedShapes.map(item => item.coordinates), [2, 3, 4, 4, 3, 4, 16]);
  assert.deepEqual(m5.namespaces.map(item => [item.name, item.declarationCount, item.runtimeKeyCount]), [["GLTF1", 51, 14], ["GLTF2", 158, 114]]);
  for (const namespace of m5.namespaces) {
    assert.equal(new Set(namespace.declarationNames).size, namespace.declarationCount);
    assert.equal(new Set(namespace.runtimeKeys).size, namespace.runtimeKeyCount);
    for (const key of namespace.runtimeKeys) assert.ok(namespace.declarationNames.includes(key), `${namespace.name}.${key}`);
  }
});

test("coverage input digest changes whenever maintained authority changes", async () => {
  const coverage = await json("coverage-and-drift.json");
  const digest = createHash("sha256").update(await readFile(resolve(root, "declaration-lock.json"))).digest("hex");
  assert.equal(coverage.sourceDigest, digest);
  assert.match(coverage.maintainedSurfaceDigest, /^[a-f0-9]{64}$/);
});
