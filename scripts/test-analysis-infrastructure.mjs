import assert from "node:assert/strict";
import test from "node:test";
import { resolve } from "node:path";
import {
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
    { declarationIdentity: "a", typeScriptExpression: "Tuple<T,2>", fsharpSymbol: "A" },
    { declarationIdentity: "a", typeScriptExpression: " Tuple<T,3> ", fsharpSymbol: "A" }
  ];
  assert.deepEqual(validateInstantiationEntries(entries), [
    "duplicate declarationIdentity: a",
    "duplicate fsharpSymbol: A",
    "non-normalized typeScriptExpression:  Tuple<T,3> "
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
