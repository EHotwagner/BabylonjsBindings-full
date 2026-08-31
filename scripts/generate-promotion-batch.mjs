import { readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const check = process.argv.includes("--check");
const targetSize = 200;
const categories = [
  { name: "alias", candidate: "SimpleAliases", maintained: "type-alias" },
  { name: "interface", candidate: "SimpleInterfaces", maintained: "simple-interface" },
  { name: "class", candidate: "SimpleClasses", maintained: "simple-class" },
  { name: "function", candidate: "SimpleFunctions", maintained: "simple-function" },
  { name: "variable", candidate: "SimpleVariables", maintained: "simple-variable" }
];
const identity = entry => `${entry.package}|${entry.module}|${entry.name}`;
const symbolFields = entry => [entry.fsharpSymbol, entry.deepImmutableSymbol, entry.partialSymbol, entry.requiredNonNullableSymbol, entry.requiredSymbol].filter(Boolean);
const ownedSymbolFields = entry => [...symbolFields(entry), ...(entry.category === "function" && entry.fsharpType ? [entry.fsharpType] : [])];
const symbolName = symbol => symbol?.split(".").at(-1);
const declarationName = chunk => {
  const match = chunk.match(/^    (?:type|let) (?:``([^`]+)``|([A-Za-z_][A-Za-z0-9_]*))/m);
  return match?.[1] ?? match?.[2];
};
const proposalChunks = source => source.trimEnd().split(/\n{2,}/).map(text => ({
  text,
  name: declarationName(text)
})).filter(chunk => chunk.name);
const qualifiedSymbolPattern = /BabylonjsBindings\.(?:TypeAliases|SimpleInterfaces|SimpleClasses|SimpleFunctions|SimpleVariables)\.[A-Za-z_][A-Za-z0-9_]*/g;
const identifierPattern = /[A-Za-z_][A-Za-z0-9_]*/g;

const maintainedSymbols = new Set();
const maintainedIdentities = new Set();
const candidateNodes = [];
const summary = {};
for (const category of categories) {
  const maintained = JSON.parse(await readFile(resolve(root, `src/BabylonjsBindings/${category.maintained}-coverage-manifest.json`), "utf8"));
  const candidate = JSON.parse(await readFile(resolve(root, `generated-candidates/${category.candidate}.promotion.json`), "utf8"));
  for (const entry of maintained.exports) {
    maintainedIdentities.add(identity(entry));
    for (const symbol of ownedSymbolFields({ ...entry, category: category.name })) maintainedSymbols.add(symbol);
  }
  for (const entry of candidate.exports) candidateNodes.push({ ...entry, category: category.name, supportOnly: false });
  for (const entry of candidate.supportTypes ?? []) candidateNodes.push({ ...entry, category: category.name, supportOnly: true });
  summary[category.name] = {
    maintained: maintained.exports.length,
    candidate: candidate.exports.length,
    delta: candidate.exports.filter(entry => !maintained.exports.some(existing => identity(existing) === identity(entry))).length
  };
}

const nodeBySymbol = new Map();
for (const node of candidateNodes) for (const symbol of ownedSymbolFields(node)) nodeBySymbol.set(symbol, node);
const nodeByCategoryAndName = new Map();
for (const node of candidateNodes) {
  const nodesByName = nodeByCategoryAndName.get(node.category) ?? new Map();
  for (const symbol of ownedSymbolFields(node)) nodesByName.set(symbolName(symbol), node);
  nodeByCategoryAndName.set(node.category, nodesByName);
}

// Manifest dependencies cover the rendered declaration model. Complete that
// graph from the actual reviewed F# proposals so anonymous helper records and
// variable/function wrapper types cannot hide transitive export dependencies.
const chunksByCategoryAndName = new Map();
for (const category of categories) {
  const source = await readFile(resolve(root, `generated-candidates/${category.candidate}.proposal.fs`), "utf8");
  const chunksByName = new Map();
  for (const chunk of proposalChunks(source)) {
    const values = chunksByName.get(chunk.name) ?? [];
    values.push(chunk);
    chunksByName.set(chunk.name, values);
  }
  chunksByCategoryAndName.set(category.name, chunksByName);
}
const inferredDependencies = node => {
  const dependencies = new Set(node.dependencies ?? []);
  const chunksByName = chunksByCategoryAndName.get(node.category);
  const nodesByName = nodeByCategoryAndName.get(node.category);
  const pending = ownedSymbolFields(node).map(symbolName);
  if (node.category === "class") pending.push(`${node.name}Static`);
  const visited = new Set();
  while (pending.length > 0) {
    const name = pending.pop();
    if (visited.has(name)) continue;
    visited.add(name);
    for (const chunk of chunksByName.get(name) ?? []) {
      const code = chunk.text.split("\n").filter(line => !line.trimStart().startsWith("///")).join("\n");
      for (const symbol of code.match(qualifiedSymbolPattern) ?? []) {
        const dependencyNode = nodeBySymbol.get(symbol);
        if (dependencyNode && dependencyNode.fsharpSymbol !== node.fsharpSymbol) dependencies.add(dependencyNode.fsharpSymbol);
      }
      for (const identifier of code.match(identifierPattern) ?? []) {
        const localNode = nodesByName.get(identifier);
        if (localNode && localNode.fsharpSymbol !== node.fsharpSymbol) dependencies.add(localNode.fsharpSymbol);
        else if (chunksByName.has(identifier)) pending.push(identifier);
      }
    }
  }
  dependencies.delete(node.fsharpSymbol);
  return [...dependencies].sort();
};
for (const node of candidateNodes) node.dependencies = inferredDependencies(node);

const isMaintained = node => !node.supportOnly && maintainedIdentities.has(identity(node));
const closureCache = new Map();
const closureFor = rootNode => {
  if (closureCache.has(rootNode.fsharpSymbol)) return closureCache.get(rootNode.fsharpSymbol);
  const nodes = new Set();
  const unresolved = new Set();
  const fidelityIssues = new Set();
  const pending = [rootNode];
  const visited = new Set();
  while (pending.length > 0) {
    const node = pending.pop();
    if (visited.has(node.fsharpSymbol)) continue;
    visited.add(node.fsharpSymbol);
    if (!isMaintained(node)) nodes.add(node.fsharpSymbol);
    if ((node.fidelityIssues ?? []).length > 0) fidelityIssues.add(node.fsharpSymbol);
    for (const dependency of node.dependencies ?? []) {
      if (maintainedSymbols.has(dependency)) continue;
      const dependencyNode = nodeBySymbol.get(dependency);
      if (!dependencyNode) unresolved.add(dependency);
      else pending.push(dependencyNode);
    }
  }
  const result = { nodes, unresolved, fidelityIssues };
  closureCache.set(rootNode.fsharpSymbol, result);
  return result;
};

const roots = candidateNodes
  .filter(node => !node.supportOnly && !isMaintained(node))
  .map(node => ({ node, closure: closureFor(node) }))
  .filter(item => item.closure.unresolved.size === 0 && item.closure.fidelityIssues.size === 0)
  .sort((left, right) => Number(left.node.name.startsWith("_")) - Number(right.node.name.startsWith("_"))
    || left.closure.nodes.size - right.closure.nodes.size
    || left.node.category.localeCompare(right.node.category)
    || left.node.name.localeCompare(right.node.name));

const selectedSymbols = new Set();
const selectedRoots = [];
for (const item of roots) {
  const additions = [...item.closure.nodes].filter(symbol => !selectedSymbols.has(symbol));
  if (selectedSymbols.size + additions.length > targetSize) continue;
  selectedRoots.push(item.node.fsharpSymbol);
  for (const symbol of additions) selectedSymbols.add(symbol);
  if (selectedSymbols.size === targetSize) break;
}
const selected = [...selectedSymbols].map(symbol => nodeBySymbol.get(symbol)).sort((left, right) => left.category.localeCompare(right.category) || left.name.localeCompare(right.name));
const selectedSet = new Set(selectedSymbols);
const unresolvedSelected = [...new Set(selected.flatMap(node => node.dependencies ?? []).filter(dependency => !maintainedSymbols.has(dependency) && !selectedSet.has(dependency)))].sort();
const document = {
  schemaVersion: 1,
  source: { declarationLock: "declaration-lock.json", packageVersion: "9.19.0" },
  targetSize,
  actualSize: selected.length,
  maintainedBaseline: summary,
  selectedRootCount: selectedRoots.length,
  selectedRoots,
  selected: selected.map(node => ({
    package: node.package,
    module: node.module,
    name: node.name,
    category: node.category,
    supportOnly: node.supportOnly,
    fsharpSymbol: node.fsharpSymbol,
    dependencies: node.dependencies ?? [],
    fidelityIssues: node.fidelityIssues ?? []
  })),
  validation: {
    dependencyClosed: unresolvedSelected.length === 0,
    unresolvedDependencies: unresolvedSelected
  }
};
const rendered = `${JSON.stringify(document, null, 2)}\n`;
const output = resolve(root, "generated-candidates/promotion-batch.json");
if (check) {
  if (await readFile(output, "utf8") !== rendered) throw new Error("promotion batch is stale");
} else {
  await writeFile(output, rendered);
}
if (!document.validation.dependencyClosed || document.actualSize === 0 || document.actualSize > targetSize) throw new Error(`promotion batch is not closed within the ${targetSize}-type ceiling`);
console.log(`generated dependency-closed promotion batch with ${selectedRoots.length} roots and ${selected.length} total types (${targetSize} ceiling)`);
