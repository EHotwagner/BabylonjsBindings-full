import assert from "node:assert/strict";
import test from "node:test";
import { resolve } from "node:path";
import {
  classifyBlockedExports,
  loadSchemaValidator,
  normalizeTypeScriptExpression,
  validateDependentMap,
  validateInstantiationEntries
} from "./analysis-infrastructure-lib.mjs";

const root = resolve(import.meta.dirname, "..");
const baseMap = {
  id: "fixture",
  sourceIdentity: "pkg|module|Map",
  sourceKeys: ["b", "a"],
  mappings: [{ key: "a", status: "blocked" }, { key: "b", status: "blocked" }]
};

test("dependent map accepts exact unordered key coverage", () => {
  assert.deepEqual(validateDependentMap(baseMap), {
    id: "fixture", sourceIdentity: "pkg|module|Map", sourceKeyCount: 2, mappingCount: 2,
    complete: true, missingKeys: [], extraKeys: [], duplicateKeys: []
  });
});

test("dependent map reports sorted missing, extra, and duplicate keys", () => {
  const result = validateDependentMap({
    ...baseMap,
    sourceKeys: ["a", "b", "c"],
    mappings: [{ key: "b" }, { key: "b" }, { key: "z" }]
  });
  assert.equal(result.complete, false);
  assert.deepEqual(result.missingKeys, ["a", "c"]);
  assert.deepEqual(result.extraKeys, ["z"]);
  assert.deepEqual(result.duplicateKeys, ["b"]);
});

test("instantiation registry normalization and uniqueness are enforced", () => {
  assert.equal(normalizeTypeScriptExpression(" Tuple< T , 2 > "), "Tuple<T,2>");
  const entries = [
    { declarationIdentity: "pkg|module|Tuple", typeScriptExpression: "Tuple<T,3>", fsharpSymbol: "A" },
    { declarationIdentity: "pkg|module|Tuple", typeScriptExpression: " Tuple<T,2> ", fsharpSymbol: "A" }
  ];
  assert.deepEqual(validateInstantiationEntries(entries), [
    "duplicate fsharpSymbol: A",
    "entries are not in canonical order: pkg|module|Tuple|Tuple<T,3> before pkg|module|Tuple|Tuple<T,2>",
    "non-normalized typeScriptExpression:  Tuple<T,2> "
  ]);
});

test("instantiation registry accepts ordered distinct instantiations of one declaration", () => {
  assert.deepEqual(validateInstantiationEntries([
    { declarationIdentity: "pkg|module|Tuple", typeScriptExpression: "Tuple<T,2>", fsharpSymbol: "Tuple2" },
    { declarationIdentity: "pkg|module|Tuple", typeScriptExpression: "Tuple<T,3>", fsharpSymbol: "Tuple3" }
  ]), []);
});

test("instantiation registry rejects a duplicate normalized instantiation", () => {
  assert.deepEqual(validateInstantiationEntries([
    { declarationIdentity: "pkg|module|Tuple", typeScriptExpression: "Tuple<T,2>", fsharpSymbol: "Tuple2" },
    { declarationIdentity: "pkg|module|Tuple", typeScriptExpression: "Tuple<T,2>", fsharpSymbol: "Tuple2Again" }
  ]), [
    "duplicate instantiation: pkg|module|Tuple|Tuple<T,2>",
    "entries are not in canonical order: pkg|module|Tuple|Tuple<T,2> before pkg|module|Tuple|Tuple<T,2>"
  ]);
});

test("family classification rejects a same-name wrong-module substitution", () => {
  const policy = { families: [{ id: "physics", label: "Physics", expectedCount: 1, exports: ["pkg|right|PhysicsEngine"] }] };
  const result = classifyBlockedExports([{ package: "pkg", module: "wrong", name: "PhysicsEngine", kind: "class", reason: "blocked" }], policy);
  assert.deepEqual(result.diagnostics, ["physics expected 1 exports but found 0", "pkg|wrong|PhysicsEngine matched 0 families"]);
});

test("family classification rejects duplicate blocked and policy identities", () => {
  const item = { package: "pkg", module: "right", name: "PhysicsEngine", kind: "class", reason: "blocked" };
  const policy = { families: [{ id: "physics", label: "Physics", expectedCount: 2, exports: ["pkg|right|PhysicsEngine", "pkg|right|PhysicsEngine"] }] };
  const result = classifyBlockedExports([item, item], policy);
  assert.deepEqual(result.diagnostics, [
    "duplicate blocked export identity: pkg|right|PhysicsEngine",
    "duplicate family policy identity: pkg|right|PhysicsEngine"
  ]);
});

test("instantiation registry schema rejects unknown fields and malformed identities", async () => {
  const validate = await loadSchemaValidator(root, "instantiation-registry");
  assert.equal(validate({ schemaVersion: 1, source: "declaration-lock.json", entries: [] }), true);
  assert.equal(validate({ schemaVersion: 1, source: "declaration-lock.json", entries: [], surprise: true }), false);
  assert.equal(validate({ schemaVersion: 1, source: "declaration-lock.json", entries: [{
    declarationIdentity: "not-qualified", typeScriptExpression: "Tuple<T,2>", fsharpSymbol: "Tuple2", status: "reviewed", evidence: ["x"]
  }] }), false);
});
