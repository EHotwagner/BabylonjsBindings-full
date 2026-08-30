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

const fsharpType = node => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType);
    return element ? `ResizeArray<${element}>` : undefined;
  }
  return undefined;
};
const objectTypes = new Map();
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
    const members = [];
    let supported = true;
    for (const member of declaration.type.members) {
      if (!ts.isPropertySignature(member) || !member.type || (!ts.isIdentifier(member.name) && !ts.isStringLiteral(member.name))) {
        supported = false;
        break;
      }
      const type = fsharpType(member.type);
      if (!type) {
        supported = false;
        break;
      }
      members.push({
        name: member.name.text,
        type: member.questionToken ? `${type} option` : type,
        readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false
      });
    }
    if (!supported) continue;
    const name = exported.getName();
    objectTypes.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, members });
  }
}

const entries = [...objectTypes.values()].sort((left, right) => left.name.localeCompare(right.name));
const names = new Set();
for (const entry of entries) {
  if (names.has(entry.name)) throw new Error(`simple object type name collision requires explicit module design: ${entry.name}`);
  names.add(entry.name);
}
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after object-shape review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "/// Exact primitive-property object aliases exported by Babylon.js 9.19.0.",
  "module ObjectTypes ="
];
for (const entry of entries) {
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${entry.name} =`);
  for (const member of entry.members) {
    lines.push(`        abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`);
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
console.log(`generated reviewed-promotion proposal for ${entries.length} exact primitive object aliases (${sha256(proposal)})`);
