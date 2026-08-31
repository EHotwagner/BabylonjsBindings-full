import { readFile } from "node:fs/promises";
import { resolve } from "node:path";
import Ajv2020 from "ajv/dist/2020.js";

export const identityOf = value => `${value.package}|${value.module}|${value.name}`;

export const normalizeTypeScriptExpression = value => value
  .trim()
  .replace(/\s+/g, " ")
  .replace(/\s*([<>{}\[\](),|&?:])\s*/g, "$1");

export const validateDependentMap = table => {
  const expected = [...table.sourceKeys].sort();
  const mapped = table.mappings.map(row => row.key);
  const counts = new Map();
  for (const key of mapped) counts.set(key, (counts.get(key) ?? 0) + 1);
  const uniqueMapped = [...counts.keys()].sort();
  return {
    id: table.id,
    sourceIdentity: table.sourceIdentity,
    sourceKeyCount: expected.length,
    mappingCount: mapped.length,
    complete: expected.length === uniqueMapped.length
      && expected.every((key, index) => key === uniqueMapped[index])
      && [...counts.values()].every(count => count === 1),
    missingKeys: expected.filter(key => !counts.has(key)),
    extraKeys: uniqueMapped.filter(key => !expected.includes(key)),
    duplicateKeys: [...counts.entries()].filter(([, count]) => count > 1).map(([key]) => key).sort()
  };
};

export const validateInstantiationEntries = entries => {
  const instantiations = new Set();
  const symbols = new Set();
  const diagnostics = [];
  let previousKey;
  for (const entry of entries) {
    const key = `${entry.declarationIdentity}|${normalizeTypeScriptExpression(entry.typeScriptExpression)}`;
    if (instantiations.has(key)) diagnostics.push(`duplicate instantiation: ${key}`);
    instantiations.add(key);
    if (symbols.has(entry.fsharpSymbol)) diagnostics.push(`duplicate fsharpSymbol: ${entry.fsharpSymbol}`);
    symbols.add(entry.fsharpSymbol);
    if (normalizeTypeScriptExpression(entry.typeScriptExpression) !== entry.typeScriptExpression) {
      diagnostics.push(`non-normalized typeScriptExpression: ${entry.typeScriptExpression}`);
    }
    if (previousKey !== undefined && previousKey.localeCompare(key) >= 0) diagnostics.push(`entries are not in canonical order: ${previousKey} before ${key}`);
    previousKey = key;
  }
  return diagnostics.sort();
};

export const loadSchemaValidator = async (root, name) => {
  const schema = JSON.parse(await readFile(resolve(root, `analysis/schemas/${name}.schema.json`), "utf8"));
  return new Ajv2020({ allErrors: true }).compile(schema);
};

const declarationPath = (root, sourceIdentity) => {
  const [, module] = sourceIdentity.split("|");
  return resolve(root, "node_modules", `${module}.d.ts`);
};

export const extractDeclaredKeys = async (root, table) => {
  const source = await readFile(declarationPath(root, table.sourceIdentity), "utf8");
  if (table.sourceKind === "enum") {
    const match = source.match(new RegExp(`export declare enum ${table.sourceSymbol} \\{([\\s\\S]*?)\\n\\}`));
    if (!match) throw new Error(`could not locate enum ${table.sourceSymbol}`);
    return [...match[1].matchAll(/^\s*([A-Za-z_][A-Za-z0-9_]*)\s*=/gm)].map(item => item[1]);
  }
  if (table.sourceKind === "static-string-literals") {
    const match = source.match(new RegExp(`export declare class ${table.sourceSymbol} \\{([\\s\\S]*?)\\n\\}`));
    if (!match) throw new Error(`could not locate class ${table.sourceSymbol}`);
    return [...match[1].matchAll(/static readonly [A-Za-z_][A-Za-z0-9_]*:\s*"([^"]+)";/g)].map(item => item[1]);
  }
  if (table.sourceKind === "type-union") {
    const match = source.match(new RegExp(`export type ${table.sourceSymbol} = ([^;]+);`));
    if (!match) throw new Error(`could not locate type union ${table.sourceSymbol}`);
    return match[1].split("|").map(value => value.trim());
  }
  throw new Error(`unsupported dependent-map sourceKind: ${table.sourceKind}`);
};

export const classifyBlockedExports = (blocked, policy) => {
  const matches = new Map(policy.families.map(family => [family.id, []]));
  const diagnostics = [];
  const policyIdentities = policy.families.flatMap(family => family.exports);
  const duplicatePolicyIdentities = policyIdentities.filter((identity, index) => policyIdentities.indexOf(identity) !== index);
  for (const identity of [...new Set(duplicatePolicyIdentities)].sort()) diagnostics.push(`duplicate family policy identity: ${identity}`);
  const seenBlocked = new Set();
  for (const item of blocked) {
    const identity = identityOf(item);
    if (seenBlocked.has(identity)) diagnostics.push(`duplicate blocked export identity: ${identity}`);
    seenBlocked.add(identity);
    const familyMatches = policy.families.filter(family => family.exports.includes(identity));
    if (familyMatches.length !== 1) diagnostics.push(`${identityOf(item)} matched ${familyMatches.length} families`);
    else matches.get(familyMatches[0].id).push(item);
  }
  const families = policy.families.map(family => ({
    id: family.id,
    label: family.label,
    count: matches.get(family.id).length,
    expectedCount: family.expectedCount,
    exports: matches.get(family.id).map(item => ({
      identity: identityOf(item),
      package: item.package,
      module: item.module,
      name: item.name,
      kind: item.kind,
      reason: item.reason
    })).sort((left, right) => left.identity.localeCompare(right.identity))
  }));
  for (const family of families) {
    if (family.count !== family.expectedCount) diagnostics.push(`${family.id} expected ${family.expectedCount} exports but found ${family.count}`);
  }
  return { families, diagnostics: diagnostics.sort() };
};
