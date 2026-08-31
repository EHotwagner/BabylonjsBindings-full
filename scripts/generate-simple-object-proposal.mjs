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
  if (ts.isTupleTypeNode(node) && node.elements.length >= 2) {
    const elements = node.elements.map(element => ts.isNamedTupleMember(element) && !element.questionToken && !element.dotDotDotToken ? fsharpType(element.type, available, dependencies) : !ts.isNamedTupleMember(element) ? fsharpType(element, available, dependencies) : undefined);
    return elements.every(Boolean) ? `(${elements.join(" * ")})` : undefined;
  }
  if (ts.isTypeReferenceNode(node) && !node.typeArguments?.length && ts.isIdentifier(node.typeName) && available.has(node.typeName.text)) {
    dependencies.add(node.typeName.text);
    return node.typeName.text;
  }
  return undefined;
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
    const declaration = target.declarations?.[0];
    if (!declaration || !ts.isTypeAliasDeclaration(declaration) || !ts.isTypeLiteralNode(declaration.type)) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    if (declaration.typeParameters?.length) continue;
    declarations.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, declaration });
  }
}

const nameCounts = new Map();
for (const entry of declarations.values()) nameCounts.set(entry.name, (nameCounts.get(entry.name) ?? 0) + 1);
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
  for (const member of declaration.type.members) {
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

const selected = new Map();
const available = new Set();
let rank = 0;
while (true) {
  const additions = [];
  for (const [identity, entry] of declarations) {
    if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
    const rendered = renderMembers(entry.declaration, available);
    if (rendered) additions.push([identity, { ...entry, ...rendered, rank }]);
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
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after object-shape review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact dependency-closed object aliases exported by Babylon.js 9.19.0.",
  "module ObjectTypes ="
];
lines.push("", "    /// Phantom structural witness for TypeScript Record<string, unknown> constraints.", "    [<AllowNullLiteral>]", "    type JavaScriptStringUnknownRecord =", "        interface end");
const stringUnknownRecordAliases = new Set(["ArcRotateHandlers", "GeospatialHandlers", "TargetCameraHandlers"]);
for (const entry of entries) {
  for (const member of entry.members.filter(member => member.kind === "callbackProperty")) {
    const helperName = `${entry.name}${pascal(member.name)}Callback`;
    member.helperName = helperName;
    lines.push("", `    /// Function-valued ${entry.name}.${member.name} property.`, "    [<AllowNullLiteral>]", `    type ${helperName} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
  }
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${entry.name} =`);
  if (stringUnknownRecordAliases.has(entry.name)) lines.push("        inherit JavaScriptStringUnknownRecord");
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
    kind: "type",
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.ObjectTypes.${entry.name}`,
    memberCount: entry.members.length
  }))
};
const proposalPath = resolve(root, "generated-candidates/SimpleObjectTypes.proposal.fs");
const manifestPath = resolve(root, "generated-candidates/SimpleObjectTypes.promotion.json");
const renderedManifest = `${JSON.stringify(manifest, null, 2)}\n`;
if (check) {
  if (await readFile(proposalPath, "utf8") !== proposal || await readFile(manifestPath, "utf8") !== renderedManifest) {
    throw new Error("simple object-type promotion proposal is stale");
  }
} else {
  await writeFile(proposalPath, proposal);
  await writeFile(manifestPath, renderedManifest);
}
console.log(`generated reviewed-promotion proposal for ${entries.length} exact dependency-closed object aliases (${sha256(proposal)})`);
