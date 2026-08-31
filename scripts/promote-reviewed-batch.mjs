import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
if (!process.argv.includes("--apply-reviewed")) throw new Error("refusing to modify maintained authority without --apply-reviewed");
const batch = JSON.parse(await readFile(resolve(root, "generated-candidates/promotion-batch.json"), "utf8"));
if (!batch.validation?.dependencyClosed || batch.selected.some(entry => (entry.fidelityIssues ?? []).length > 0)) throw new Error("only a dependency-closed, fidelity-clean batch can be promoted");

const specifications = [
  { category: "alias", candidateName: "SimpleAliases", maintainedFile: "TypeAliases.fs", manifestFile: "type-alias-coverage-manifest.json" },
  { category: "interface", candidateName: "SimpleInterfaces", maintainedFile: "SimpleInterfaces.fs", manifestFile: "simple-interface-coverage-manifest.json" },
  { category: "class", candidateName: "SimpleClasses", maintainedFile: "SimpleClasses.fs", manifestFile: "simple-class-coverage-manifest.json" },
  { category: "function", candidateName: "SimpleFunctions", maintainedFile: "SimpleFunctions.fs", manifestFile: "simple-function-coverage-manifest.json" },
  { category: "variable", candidateName: "SimpleVariables", maintainedFile: "SimpleVariables.fs", manifestFile: "simple-variable-coverage-manifest.json" }
];
const identity = entry => `${entry.package}|${entry.module}|${entry.name}`;
const sha256 = value => createHash("sha256").update(value).digest("hex");
let promotedExports = 0;

for (const specification of specifications) {
  const maintainedManifestPath = resolve(root, `src/BabylonjsBindings/${specification.manifestFile}`);
  const maintainedManifest = JSON.parse(await readFile(maintainedManifestPath, "utf8"));
  const candidateManifest = JSON.parse(await readFile(resolve(root, `generated-candidates/${specification.candidateName}.promotion.json`), "utf8"));
  const candidateSource = await readFile(resolve(root, `generated-candidates/${specification.candidateName}.proposal.fs`), "utf8");
  const maintainedSource = await readFile(resolve(root, `src/BabylonjsBindings/${specification.maintainedFile}`), "utf8");
  const previewSource = await readFile(resolve(root, `generated-candidates/promotion-batch/${specification.maintainedFile}`), "utf8");
  const selectedEntries = batch.selected.filter(entry => entry.category === specification.category && !entry.supportOnly);
  if (selectedEntries.length === 0 && previewSource === maintainedSource) continue;
  const selectedIdentities = new Set(selectedEntries.filter(entry => !entry.projectionOnly).map(identity));
  const projectionIdentities = new Set(selectedEntries.filter(entry => entry.projectionOnly).map(identity));
  const maintainedIdentities = new Set(maintainedManifest.exports.map(identity));
  const additions = candidateManifest.exports.filter(entry => selectedIdentities.has(identity(entry)) && !maintainedIdentities.has(identity(entry)));
  if (additions.length !== selectedIdentities.size) throw new Error(`${specification.category} selected export set did not map exactly to candidate exports`);
  const proposalHeader = candidateSource.split("\n", 1)[0];
  const maintainedAsProposal = [proposalHeader, ...previewSource.split("\n").slice(1)].join("\n");
  const nextManifest = {
    ...maintainedManifest,
    proposalSha256: sha256(maintainedAsProposal),
    exports: [...maintainedManifest.exports.map(entry => projectionIdentities.has(identity(entry))
      ? candidateManifest.exports.find(candidate => identity(candidate) === identity(entry))
      : entry), ...additions],
    reviewStatus: "maintained"
  };
  await writeFile(resolve(root, `src/BabylonjsBindings/${specification.maintainedFile}`), previewSource);
  await writeFile(maintainedManifestPath, `${JSON.stringify(nextManifest, null, 2)}\n`);
  promotedExports += additions.length;
}

console.log(`promoted ${promotedExports} reviewed Babylon exports from the dependency-closed batch`);
