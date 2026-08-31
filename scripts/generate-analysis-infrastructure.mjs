import { mkdir, readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
import {
  classifyBlockedExports,
  extractDeclaredKeys,
  loadSchemaValidator,
  validateDependentMap,
  validateInstantiationEntries
} from "./analysis-infrastructure-lib.mjs";

const root = resolve(import.meta.dirname, "..");
const check = process.argv.includes("--check");
const outDirIndex = process.argv.indexOf("--out-dir");
const outputRoot = outDirIndex >= 0 ? resolve(root, process.argv[outDirIndex + 1]) : resolve(root, "analysis");
if (outDirIndex >= 0 && !process.argv[outDirIndex + 1]) throw new Error("--out-dir requires a path");
const readJson = async path => JSON.parse(await readFile(resolve(root, path), "utf8"));
const render = value => `${JSON.stringify(value, null, 2)}\n`;
const coverage = await readJson("coverage-and-drift.json");
const policy = await readJson("analysis/analysis-policy.json");
const maps = await readJson("analysis/dependent-maps.json");
const registry = await readJson("analysis/instantiation-registry.json");

const expectedSummary = policy.expectedCoverage;
for (const key of ["total", "typed", "runtimeOnly", "blocked", "lossy"]) {
  if (coverage.summary[key] !== expectedSummary[key]) throw new Error(`coverage ${key} drift: expected ${expectedSummary[key]}, found ${coverage.summary[key]}`);
}

const blocked = coverage.exports.filter(item => item.disposition === "blocked");
const classification = classifyBlockedExports(blocked, policy);
if (classification.diagnostics.length > 0) throw new Error(classification.diagnostics.join("\n"));
const blockedReport = {
  schemaVersion: 1,
  source: "coverage-and-drift.json",
  expectedTypedTotal: expectedSummary.typed,
  blockedExportCount: blocked.length,
  familyCount: classification.families.length,
  families: classification.families
};

const mapResults = [];
for (const table of maps.tables) {
  const declaredKeys = await extractDeclaredKeys(root, table);
  mapResults.push(validateDependentMap({ ...table, sourceKeys: declaredKeys }));
}
const dependentReport = {
  schemaVersion: 1,
  source: "analysis/dependent-maps.json",
  tableCount: mapResults.length,
  complete: mapResults.every(result => result.complete),
  tables: mapResults
};
if (!dependentReport.complete) {
  const failed = mapResults.filter(result => !result.complete)
    .map(result => `${result.id}: missing=[${result.missingKeys}], extra=[${result.extraKeys}], duplicate=[${result.duplicateKeys}]`);
  throw new Error(`dependent maps are incomplete\n${failed.join("\n")}`);
}

const registryDiagnostics = validateInstantiationEntries(registry.entries);
if (registryDiagnostics.length > 0) throw new Error(registryDiagnostics.join("\n"));

for (const [name, document] of [
  ["blocked-families", blockedReport],
  ["dependent-map-completeness", dependentReport],
  ["instantiation-registry", registry]
]) {
  const validate = await loadSchemaValidator(root, name);
  if (!validate(document)) throw new Error(`${name} schema validation failed: ${JSON.stringify(validate.errors)}`);
}

for (const [name, document] of [
  ["blocked-families.json", blockedReport],
  ["dependent-map-completeness.json", dependentReport]
]) {
  const output = resolve(outputRoot, name);
  const rendered = render(document);
  if (check) {
    if (await readFile(output, "utf8") !== rendered) throw new Error(`${output} is stale; run npm run analysis:generate`);
  } else {
    await mkdir(outputRoot, { recursive: true });
    await writeFile(output, rendered);
  }
}

console.log(`analysis complete: ${blocked.length} blocked exports in ${classification.families.length} families; ${mapResults.length} dependent maps complete; ${registry.entries.length} registered instantiations; ${coverage.summary.typed} typed exports unchanged`);
