import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { relative, resolve, sep } from "node:path";
import ts from "typescript";

const root = resolve(import.meta.dirname, "..");
const check = process.argv.includes("--check");
const nodeModules = resolve(root, "node_modules");
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
const enums = new Map();

for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases are not enum proposals */ }
    }
    const declaration = target.declarations?.find(node => ts.isEnumDeclaration(node) || ts.isTypeAliasDeclaration(node));
    if (!declaration) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    let kind;
    let members;
    if (ts.isEnumDeclaration(declaration)) {
      kind = "enum";
      members = declaration.members.map(member => ({
        name: member.name.getText(),
        value: checker.getConstantValue(member)
      }));
    } else {
      const nodes = ts.isUnionTypeNode(declaration.type) ? declaration.type.types : [declaration.type];
      if (!nodes.every(node => ts.isLiteralTypeNode(node) && ts.isNumericLiteral(node.literal))) continue;
      kind = "type";
      members = nodes.map(node => ({ name: `N${node.literal.text}`, value: Number(node.literal.text) }));
    }
    if (!members.every(member => typeof member.value === "number" && Number.isInteger(member.value))) continue;
    const name = exported.getName();
    enums.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, kind, members });
  }
}

const entries = [...enums.values()].sort((left, right) => left.name.localeCompare(right.name));
const names = new Set();
for (const entry of entries) {
  if (names.has(entry.name)) throw new Error(`numeric enum name collision requires explicit module design: ${entry.name}`);
  names.add(entry.name);
}
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after enum review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "/// Exact numeric enums and integer-literal unions exported by @babylonjs/core and @babylonjs/loaders 9.19.0.",
  "module Enums ="
];
for (const entry of entries) {
  const unsigned = entry.members.some(member => member.value > 2147483647);
  lines.push("", `    /// ${entry.module}`, `    type ${entry.name} =`);
  for (const member of entry.members) {
    const value = unsigned ? `${member.value}u` : `${member.value}`;
    lines.push(`        | \`${"`"}${member.name}\`${"`"} = ${value}`);
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
    kind: entry.kind,
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.Enums.${entry.name}`,
    memberCount: entry.members.length
  }))
};
const proposalPath = resolve(root, "generated-candidates/CoreEnums.proposal.fs");
const manifestPath = resolve(root, "generated-candidates/CoreEnums.promotion.json");
const renderedManifest = `${JSON.stringify(manifest, null, 2)}\n`;
if (check) {
  if (await readFile(proposalPath, "utf8") !== proposal || await readFile(manifestPath, "utf8") !== renderedManifest) {
    throw new Error("numeric enum promotion proposal is stale");
  }
} else {
  await writeFile(proposalPath, proposal);
  await writeFile(manifestPath, renderedManifest);
}
console.log(`generated reviewed-promotion proposal for ${entries.length} exact numeric enums/unions (${sha256(proposal)})`);
