import { mkdir, readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const check = process.argv.includes("--check");
const outputRoot = resolve(root, "generated-candidates/promotion-batch");
const batch = JSON.parse(await readFile(resolve(root, "generated-candidates/promotion-batch.json"), "utf8"));
if (!batch.validation?.dependencyClosed) throw new Error("promotion preview requires a dependency-closed batch");

const specifications = [
  { category: "alias", candidateName: "SimpleAliases", maintainedFile: "TypeAliases.fs", moduleName: "TypeAliases" },
  { category: "interface", candidateName: "SimpleInterfaces", maintainedFile: "SimpleInterfaces.fs", moduleName: "SimpleInterfaces" },
  { category: "class", candidateName: "SimpleClasses", maintainedFile: "SimpleClasses.fs", moduleName: "SimpleClasses" },
  { category: "function", candidateName: "SimpleFunctions", maintainedFile: "SimpleFunctions.fs", moduleName: "SimpleFunctions" },
  { category: "variable", candidateName: "SimpleVariables", maintainedFile: "SimpleVariables.fs", moduleName: "SimpleVariables" }
];
const declarationNamesInChunk = chunk => [...chunk.matchAll(/^    (?:type|let) (?:``([^`]+)``|([A-Za-z_][A-Za-z0-9_]*))/gm)].map(match => match[1] ?? match[2]);
const chunks = source => source.trimEnd().split(/\n{2,}/).map((text, index) => ({ index, text, names: declarationNamesInChunk(text) }));
const symbolName = symbol => symbol?.split(".").at(-1);
const declarationNames = (entry, category) => [entry.name, symbolName(entry.deepImmutableSymbol), symbolName(entry.partialSymbol), symbolName(entry.requiredNonNullableSymbol), symbolName(entry.requiredSymbol), category === "function" ? symbolName(entry.fsharpType) : undefined, category === "class" ? `${entry.name}Static` : undefined].filter(Boolean);
const identifierPattern = /[A-Za-z_][A-Za-z0-9_]*/g;
const qualifiedPattern = /BabylonjsBindings\.(TypeAliases|SimpleInterfaces|SimpleClasses|SimpleFunctions|SimpleVariables)\.([A-Za-z_][A-Za-z0-9_]*)/g;
const escapePattern = value => value.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");

const contexts = new Map();
const categoryByModule = new Map(specifications.map(specification => [specification.moduleName, specification.category]));
for (const specification of specifications) {
  const candidateSource = await readFile(resolve(root, `generated-candidates/${specification.candidateName}.proposal.fs`), "utf8");
  const maintainedSource = await readFile(resolve(root, `src/BabylonjsBindings/${specification.maintainedFile}`), "utf8");
  const manifest = JSON.parse(await readFile(resolve(root, `generated-candidates/${specification.candidateName}.promotion.json`), "utf8"));
  const manifestEntries = [...manifest.exports, ...(manifest.supportTypes ?? [])];
  const manifestBySymbol = new Map(manifestEntries.map(entry => [entry.fsharpSymbol, entry]));
  const candidateChunks = chunks(candidateSource);
  const maintainedChunks = chunks(maintainedSource);
  const chunksByName = new Map();
  for (const chunk of candidateChunks) {
    for (const name of chunk.names) {
      const values = chunksByName.get(name) ?? [];
      values.push(chunk);
      chunksByName.set(name, values);
    }
  }
  const selectedBatchEntries = batch.selected.filter(entry => entry.category === specification.category);
  const selectedEntries = selectedBatchEntries.map(entry => manifestBySymbol.get(entry.fsharpSymbol)).filter(Boolean);
  contexts.set(specification.category, {
    specification, maintainedSource, maintainedChunks, candidateChunks, chunksByName,
    maintainedNames: new Set(maintainedChunks.flatMap(chunk => chunk.names)),
    exportDeclarationNames: new Set(manifestEntries.flatMap(entry => declarationNames(entry, specification.category))),
    selectedDeclarationNames: new Set(selectedEntries.flatMap(entry => declarationNames(entry, specification.category))),
    projectedDeclarationNames: new Set(selectedBatchEntries.filter(entry => entry.projectionOnly).map(entry => symbolName(entry.fsharpSymbol))),
    selectedEntries, selectedChunkIndices: new Set()
  });
}

const pending = [];
for (const [category, context] of contexts) for (const name of context.selectedDeclarationNames) pending.push({ category, name });
// Maintained exports can reference proposal-only helper declarations that were
// pulled into an earlier compile preview. Seed those references as well so the
// promoted source remains closed even when a category has no newly selected
// public export in the current batch.
for (const [category, context] of contexts) {
  const code = context.maintainedSource.split("\n").filter(line => !line.trimStart().startsWith("///")).join("\n");
  const typeCode = code.replace(/"(?:\\.|[^"\\])*"/g, "");
  for (const match of code.matchAll(qualifiedPattern)) {
    const targetCategory = categoryByModule.get(match[1]);
    if (targetCategory && !contexts.get(targetCategory).maintainedNames.has(match[2])) pending.push({ category: targetCategory, name: match[2] });
  }
  for (const match of typeCode.matchAll(/(?:[:<,*=>]|\binherit\s+)\s*([A-Za-z_][A-Za-z0-9_]*)/g)) {
    const referencedName = match[1];
    if (context.chunksByName.has(referencedName) && !context.maintainedNames.has(referencedName)) pending.push({ category, name: referencedName });
  }
}
const visited = new Set();
const unresolved = new Set();
const missingBatchDependencies = new Set();
while (pending.length > 0) {
  const item = pending.pop();
  const key = `${item.category}:${item.name}`;
  if (visited.has(key)) continue;
  visited.add(key);
  const context = contexts.get(item.category);
  if (context.maintainedNames.has(item.name)) continue;
  if (context.exportDeclarationNames.has(item.name) && !context.selectedDeclarationNames.has(item.name)) {
    missingBatchDependencies.add(key);
    continue;
  }
  const matchingChunks = context.chunksByName.get(item.name);
  if (!matchingChunks) {
    unresolved.add(key);
    continue;
  }
  for (const chunk of matchingChunks) {
    if (context.selectedChunkIndices.has(chunk.index)) continue;
    context.selectedChunkIndices.add(chunk.index);
    const code = chunk.text.split("\n").filter(line => !line.trimStart().startsWith("///")).join("\n");
    const typeCode = code.replace(/"(?:\\.|[^"\\])*"/g, "");
    for (const match of code.matchAll(qualifiedPattern)) {
      const targetCategory = categoryByModule.get(match[1]);
      if (targetCategory) pending.push({ category: targetCategory, name: match[2] });
    }
    for (const referencedName of code.match(identifierPattern) ?? []) {
      const usedAsType = new RegExp(`(?:[:<,*=>]|\\binherit\\s+)\\s*${escapePattern(referencedName)}(?:\\b|<)`).test(typeCode);
      if (usedAsType && context.chunksByName.has(referencedName)) pending.push({ category: item.category, name: referencedName });
    }
  }
}
if (unresolved.size > 0) throw new Error(`promotion preview has unresolved declaration chunks: ${[...unresolved].sort().join(", ")}`);
if (missingBatchDependencies.size > 0) throw new Error(`promotion batch omitted proposal dependencies: ${[...missingBatchDependencies].sort().join(", ")}`);

const outputs = new Map();
const previewSummary = {};
for (const [category, context] of contexts) {
  const additions = context.candidateChunks.filter(chunk => context.selectedChunkIndices.has(chunk.index)).map(chunk => chunk.text);
  const maintained = context.maintainedChunks
    .filter(chunk => !chunk.names.some(name => context.projectedDeclarationNames.has(name)))
    .map(chunk => chunk.text);
  outputs.set(context.specification.maintainedFile, additions.length === 0
    ? context.maintainedSource
    : `${maintained.join("\n\n")}\n\n${additions.join("\n\n")}\n`);
  previewSummary[category] = { selectedExports: context.selectedEntries.filter(entry => !entry.kind.endsWith("-support")).length, selectedChunks: additions.length };
}

const moduleBody = (source, moduleName) => {
  const lines = source.split("\n");
  const moduleIndex = lines.findIndex(line => line === `module ${moduleName} =`);
  if (moduleIndex < 1) throw new Error(`preview does not contain ${moduleName}`);
  const documentationIndex = lines[moduleIndex - 1].startsWith("/// ") ? moduleIndex - 1 : moduleIndex;
  return lines.slice(documentationIndex).join("\n").trimEnd();
};
outputs.set("SimpleTypes.fs", ["// PROMOTION PREVIEW — authoritative maintained fragments plus the dependency-closed review batch", "namespace rec BabylonjsBindings", "", "open Fable.Core", "", moduleBody(outputs.get("TypeAliases.fs"), "TypeAliases"), "", moduleBody(outputs.get("SimpleInterfaces.fs"), "SimpleInterfaces"), "", moduleBody(outputs.get("SimpleClasses.fs"), "SimpleClasses"), ""].join("\n"));
outputs.set("preview-summary.json", `${JSON.stringify({ schemaVersion: 1, batchSize: batch.actualSize, categories: previewSummary }, null, 2)}\n`);

await mkdir(outputRoot, { recursive: true });
for (const [name, value] of outputs) {
  const path = resolve(outputRoot, name);
  if (check) {
    if (await readFile(path, "utf8") !== value) throw new Error(`${name} promotion preview is stale`);
  } else await writeFile(path, value);
}
console.log(`generated compile preview for ${batch.actualSize} dependency-closed promotion types`);
