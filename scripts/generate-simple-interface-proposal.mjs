import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { relative, resolve, sep } from "node:path";
import ts from "typescript";

const root = resolve(import.meta.dirname, "..");
const nodeModules = resolve(root, "node_modules");
const check = process.argv.includes("--check");
const lock = JSON.parse(await readFile(resolve(root, "declaration-lock.json"), "utf8"));
const lockedPaths = new Set(lock.files.map(file => file.path));
const normalize = file => relative(nodeModules, file).split(sep).join("/");
const sha256 = value => createHash("sha256").update(value).digest("hex");
const program = ts.createProgram([...lockedPaths].map(file => resolve(nodeModules, file)), {
  target: ts.ScriptTarget.ESNext,
  module: ts.ModuleKind.NodeNext,
  moduleResolution: ts.ModuleResolutionKind.NodeNext,
  noLib: true,
  skipLibCheck: true
});
const checker = program.getTypeChecker();

const dependencyManifestPaths = [
  "src/BabylonjsBindings/coverage-manifest.json",
  "src/BabylonjsBindings/string-coverage-manifest.json",
  "src/BabylonjsBindings/object-type-coverage-manifest.json",
  "src/BabylonjsBindings/type-alias-coverage-manifest.json"
];
const dependencyExports = (await Promise.all(dependencyManifestPaths.map(async path => JSON.parse(await readFile(resolve(root, path), "utf8")))))
  .flatMap(manifest => manifest.exports);
const dependencyNameCounts = new Map();
for (const entry of dependencyExports) dependencyNameCounts.set(entry.name, (dependencyNameCounts.get(entry.name) ?? 0) + 1);
const maintainedSymbols = new Map(dependencyExports
  .filter(entry => dependencyNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, entry.fsharpSymbol]));

const fsharpType = (node, available, dependencies = new Set()) => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType, available, dependencies);
    return element ? `ResizeArray<${element}>` : undefined;
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (node.typeName.text === "Nullable" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies);
      return inner ? `${inner} option` : undefined;
    }
    if (!node.typeArguments?.length && available.has(node.typeName.text)) {
      dependencies.add(node.typeName.text);
      return node.typeName.text;
    }
    if (!node.typeArguments?.length && maintainedSymbols.has(node.typeName.text)) return maintainedSymbols.get(node.typeName.text);
  }
  return undefined;
};
const callbackShape = (node, available, dependencies) => {
  if (node.parameters.some(parameter => parameter.dotDotDotToken)) return undefined;
  const returnType = fsharpType(node.type, available, dependencies);
  const parameters = node.parameters.map(parameter => ({
    name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
    type: parameter.type ? fsharpType(parameter.type, available, dependencies) : undefined,
    optional: Boolean(parameter.questionToken)
  }));
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters } : undefined;
};
const renderMembers = (declaration, available) => {
  const dependencies = new Set();
  const members = [];
  for (const member of declaration.members) {
    if ((ts.isPropertySignature(member) || ts.isMethodSignature(member)) && (!ts.isIdentifier(member.name) && !ts.isStringLiteral(member.name))) return undefined;
    if (ts.isPropertySignature(member) && member.type) {
      if (ts.isFunctionTypeNode(member.type)) {
        const callback = callbackShape(member.type, available, dependencies);
        if (!callback) return undefined;
        members.push({ kind: "callbackProperty", name: member.name.text, optional: Boolean(member.questionToken), readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false, callback });
      } else {
        const type = fsharpType(member.type, available, dependencies);
        if (!type) return undefined;
        members.push({ kind: "property", name: member.name.text, type: member.questionToken ? `${type} option` : type, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
      }
    } else if (ts.isMethodSignature(member)) {
      if (member.questionToken) return undefined;
      const callback = callbackShape(member, available, dependencies);
      if (!callback) return undefined;
      members.push({ kind: "method", name: member.name.text, callback });
    } else {
      return undefined;
    }
  }
  return { members, dependencies: [...dependencies] };
};
const renderHeritage = (declaration, available) => {
  const dependencies = new Set();
  const bases = [];
  for (const clause of declaration.heritageClauses ?? []) {
    if (clause.token !== ts.SyntaxKind.ExtendsKeyword) return undefined;
    for (const type of clause.types) {
      if (type.typeArguments?.length || !ts.isIdentifier(type.expression)) return undefined;
      const name = type.expression.text;
      if (available.has(name)) {
        dependencies.add(name);
        bases.push(name);
      } else if (maintainedSymbols.has(name)) {
        bases.push(maintainedSymbols.get(name));
      } else {
        return undefined;
      }
    }
  }
  return { bases, dependencies: [...dependencies] };
};

const declarations = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases are excluded */ }
    }
    const interfaceDeclarations = target.declarations?.filter(ts.isInterfaceDeclaration) ?? [];
    if (interfaceDeclarations.length !== 1) continue;
    const declaration = interfaceDeclarations[0];
    if (declaration.typeParameters?.length) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    declarations.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, declaration });
  }
}

const nameCounts = new Map();
for (const entry of declarations.values()) nameCounts.set(entry.name, (nameCounts.get(entry.name) ?? 0) + 1);
const selected = new Map();
const available = new Set();
let rank = 0;
while (true) {
  const additions = [];
  for (const [identity, entry] of declarations) {
    if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
    const renderedMembers = renderMembers(entry.declaration, available);
    const renderedHeritage = renderHeritage(entry.declaration, available);
    if (renderedMembers && renderedHeritage) additions.push([identity, { ...entry, ...renderedMembers, ...renderedHeritage, rank }]);
  }
  if (additions.length === 0) break;
  for (const [identity, entry] of additions) {
    selected.set(identity, entry);
    available.add(entry.name);
  }
  rank += 1;
}
const entries = [...selected.values()].sort((left, right) => left.rank - right.rank || left.name.localeCompare(right.name));
const pascal = value => value.replace(/(^|[^A-Za-z0-9]+)([A-Za-z0-9])/g, (_, __, character) => character.toUpperCase());
const callbackArguments = callback => callback.parameters.length === 0
  ? "unit"
  : callback.parameters.map(parameter => `${parameter.optional ? "?" : ""}${parameter.name}: ${parameter.type}`).join(" * ");
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after interface review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact dependency-closed interfaces exported by Babylon.js 9.19.0.",
  "module SimpleInterfaces ="
];
for (const entry of entries) {
  for (const member of entry.members.filter(member => member.kind === "callbackProperty")) {
    const helperName = `${entry.name}${pascal(member.name)}Callback`;
    member.helperName = helperName;
    lines.push("", `    /// Function-valued ${entry.name}.${member.name} property.`, "    [<AllowNullLiteral>]", `    type ${helperName} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
  }
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${entry.name} =`);
  for (const base of entry.bases) lines.push(`        inherit ${base}`);
  if (entry.members.length === 0 && entry.bases.length === 0) {
    lines.push("        interface end");
    continue;
  }
  for (const member of entry.members) {
    if (member.kind === "property") {
      lines.push(`        abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`);
    } else if (member.kind === "callbackProperty") {
      lines.push(`        abstract \`\`${member.name}\`\`: ${member.helperName}${member.optional ? " option" : ""} with get${member.readonly ? "" : ", set"}`);
    } else {
      lines.push(`        abstract \`\`${member.name}\`\`: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
    }
  }
}
const proposal = `${lines.join("\n")}\n`;
const manifest = {
  schemaVersion: 1,
  source: { declarationLock: "declaration-lock.json", packageVersion: "9.19.0" },
  proposalSha256: sha256(proposal),
  exports: entries.map(entry => ({
    package: entry.package,
    module: entry.module,
    name: entry.name,
    kind: "interface",
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.SimpleInterfaces.${entry.name}`,
    memberCount: entry.members.length
  }))
};
const proposalPath = resolve(root, "generated-candidates/SimpleInterfaces.proposal.fs");
const manifestPath = resolve(root, "generated-candidates/SimpleInterfaces.promotion.json");
const renderedManifest = `${JSON.stringify(manifest, null, 2)}\n`;
if (check) {
  if (await readFile(proposalPath, "utf8") !== proposal || await readFile(manifestPath, "utf8") !== renderedManifest) {
    throw new Error("simple interface promotion proposal is stale");
  }
} else {
  await writeFile(proposalPath, proposal);
  await writeFile(manifestPath, renderedManifest);
}
console.log(`generated reviewed-promotion proposal for ${entries.length} exact dependency-closed interfaces (${sha256(proposal)})`);
