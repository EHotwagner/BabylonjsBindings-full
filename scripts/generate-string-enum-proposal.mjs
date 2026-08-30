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
const stringEnums = new Map();
const caseNameFor = value => {
  const segments = value.split(/[^A-Za-z0-9]+/).filter(Boolean);
  let result = segments.map(segment => `${segment[0].toUpperCase()}${segment.slice(1)}`).join("") || "Value";
  if (!/^[A-Z]/.test(result)) result = `Value${result}`;
  return result;
};

for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases are excluded */ }
    }
    const declaration = target.declarations?.[0];
    if (!declaration) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    let sourceKind;
    let members;
    if (ts.isEnumDeclaration(declaration)) {
      const values = declaration.members.map(member => checker.getConstantValue(member));
      if (values.every(value => typeof value === "string")) {
        sourceKind = "enum";
        members = declaration.members.map((member, index) => ({ name: caseNameFor(member.name.getText().replace(/^['"]|['"]$/g, "")), value: values[index] }));
      }
    } else if (ts.isTypeAliasDeclaration(declaration)) {
      const nodes = ts.isUnionTypeNode(declaration.type) ? declaration.type.types : [declaration.type];
      if (nodes.every(node => ts.isLiteralTypeNode(node) && ts.isStringLiteral(node.literal))) {
        sourceKind = "type";
        members = nodes.map(node => ({ name: caseNameFor(node.literal.text), value: node.literal.text }));
      }
    }
    if (!members) continue;
    const usedCases = new Set();
    members = members.map((member, index) => {
      let name = member.name;
      while (usedCases.has(name)) name = `${member.name}${index + 1}`;
      usedCases.add(name);
      return { ...member, name };
    });
    // F# emits an `Is<Case>` discriminator for each union case. A Babylon
    // member such as `IsNaN` therefore collides with the discriminator for
    // `NaN`; rename only the F# case while CompiledName preserves JS exactly.
    const generatedDiscriminators = new Set(members.map(member => `Is${member.name}`));
    const finalCaseNames = new Set();
    members = members.map(member => {
      let name = generatedDiscriminators.has(member.name) ? `${member.name}Value` : member.name;
      while (finalCaseNames.has(name)) name = `${name}Value`;
      finalCaseNames.add(name);
      return { ...member, name };
    });
    const name = exported.getName();
    stringEnums.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, sourceKind, members });
  }
}

const entries = [...stringEnums.values()].sort((left, right) => left.name.localeCompare(right.name));
const names = new Set();
for (const entry of entries) {
  if (names.has(entry.name)) throw new Error(`string enum name collision requires explicit module design: ${entry.name}`);
  names.add(entry.name);
}
const fsharpString = value => `"${value.replaceAll("\\", "\\\\").replaceAll("\"", "\\\"").replaceAll("\n", "\\n").replaceAll("\r", "\\r")}"`;
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after string-enum review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact string enums and string-literal unions exported by Babylon.js 9.19.0.",
  "module StringEnums ="
];
for (const entry of entries) {
  lines.push("", `    /// ${entry.module}`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${entry.name} =`);
  for (const member of entry.members) {
    lines.push(`        | [<CompiledName(${fsharpString(member.value)})>] \`\`${member.name}\`\``);
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
    kind: entry.sourceKind,
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.StringEnums.${entry.name}`,
    memberCount: entry.members.length
  }))
};
const proposalPath = resolve(root, "generated-candidates/StringEnums.proposal.fs");
const manifestPath = resolve(root, "generated-candidates/StringEnums.promotion.json");
const renderedManifest = `${JSON.stringify(manifest, null, 2)}\n`;
if (check) {
  if (await readFile(proposalPath, "utf8") !== proposal || await readFile(manifestPath, "utf8") !== renderedManifest) {
    throw new Error("string enum promotion proposal is stale");
  }
} else {
  await writeFile(proposalPath, proposal);
  await writeFile(manifestPath, renderedManifest);
}
console.log(`generated reviewed-promotion proposal for ${entries.length} exact string enums/unions (${sha256(proposal)})`);
