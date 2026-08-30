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

const hasModifier = (node, kind) => node.modifiers?.some(modifier => modifier.kind === kind) ?? false;
const inaccessible = node => hasModifier(node, ts.SyntaxKind.PrivateKeyword) || hasModifier(node, ts.SyntaxKind.ProtectedKeyword);
const fsharpType = node => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType);
    return element ? `ResizeArray<${element}>` : undefined;
  }
  return undefined;
};
const callbackShape = node => {
  if (node.parameters.some(parameter => parameter.dotDotDotToken)) return undefined;
  const returnType = node.type ? fsharpType(node.type) : undefined;
  const parameters = node.parameters.map(parameter => ({
    name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
    type: parameter.type ? fsharpType(parameter.type) : undefined,
    optional: Boolean(parameter.questionToken)
  }));
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters } : undefined;
};
const renderClass = declaration => {
  const instanceMembers = [];
  const staticMembers = [];
  const constructors = [];
  const accessors = new Map();
  const constructorDeclarations = declaration.members.filter(ts.isConstructorDeclaration);
  for (const member of declaration.members) {
    if (inaccessible(member)) continue;
    const target = hasModifier(member, ts.SyntaxKind.StaticKeyword) ? staticMembers : instanceMembers;
    if (ts.isConstructorDeclaration(member)) {
      const callback = callbackShape({ parameters: member.parameters, type: { kind: ts.SyntaxKind.VoidKeyword } });
      if (!callback) return undefined;
      constructors.push(callback);
    } else if (ts.isPropertyDeclaration(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      if (member.questionToken && hasModifier(member, ts.SyntaxKind.ReadonlyKeyword)) {
        // Optional readonly is representable; the branch merely documents that
        // both flags participate independently below.
      }
      if (ts.isFunctionTypeNode(member.type)) {
        const callback = callbackShape(member.type);
        if (!callback) return undefined;
        target.push({ kind: "callbackProperty", name: member.name.text, optional: Boolean(member.questionToken), readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword), callback });
      } else {
        const type = fsharpType(member.type);
        if (!type) return undefined;
        target.push({ kind: "property", name: member.name.text, type: member.questionToken ? `${type} option` : type, readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword) });
      }
    } else if (ts.isMethodDeclaration(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      if (member.questionToken) return undefined;
      const callback = callbackShape(member);
      if (!callback) return undefined;
      target.push({ kind: "method", name: member.name.text, callback });
    } else if ((ts.isGetAccessorDeclaration(member) || ts.isSetAccessorDeclaration(member)) && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      const key = `${hasModifier(member, ts.SyntaxKind.StaticKeyword) ? "static" : "instance"}|${member.name.text}`;
      const accessor = accessors.get(key) ?? { kind: "accessor", name: member.name.text, static: hasModifier(member, ts.SyntaxKind.StaticKeyword), canGet: false, canSet: false };
      if (ts.isGetAccessorDeclaration(member)) {
        const type = member.type ? fsharpType(member.type) : undefined;
        if (!type) return undefined;
        accessor.type = type;
        accessor.canGet = true;
      } else {
        const type = member.parameters.length === 1 && member.parameters[0].type ? fsharpType(member.parameters[0].type) : undefined;
        if (!type) return undefined;
        if (accessor.type && accessor.type !== type) return undefined;
        accessor.type = type;
        accessor.canSet = true;
      }
      accessors.set(key, accessor);
    } else {
      return undefined;
    }
  }
  for (const accessor of accessors.values()) (accessor.static ? staticMembers : instanceMembers).push(accessor);
  if (constructorDeclarations.length === 0 && !hasModifier(declaration, ts.SyntaxKind.AbstractKeyword)) {
    constructors.push({ parameters: [], returnType: "unit" });
  }
  return { instanceMembers, staticMembers, constructors };
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
    const classDeclarations = target.declarations?.filter(ts.isClassDeclaration) ?? [];
    if (classDeclarations.length !== 1) continue;
    const declaration = classDeclarations[0];
    if (declaration.typeParameters?.length || declaration.heritageClauses?.length) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const rendered = renderClass(declaration);
    if (!rendered) continue;
    const name = exported.getName();
    declarations.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, ...rendered });
  }
}

const nameCounts = new Map();
for (const entry of declarations.values()) nameCounts.set(entry.name, (nameCounts.get(entry.name) ?? 0) + 1);
const entries = [...declarations.values()].filter(entry => nameCounts.get(entry.name) === 1).sort((left, right) => left.name.localeCompare(right.name));
const pascal = value => value.replace(/(^|[^A-Za-z0-9]+)([A-Za-z0-9])/g, (_, __, character) => character.toUpperCase());
const callbackArguments = callback => callback.parameters.length === 0
  ? "unit"
  : callback.parameters.map(parameter => `${parameter.optional ? "?" : ""}${parameter.name}: ${parameter.type}`).join(" * ");
const renderMember = member => {
  if (member.kind === "property") return `abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`;
  if (member.kind === "accessor") return `abstract \`\`${member.name}\`\`: ${member.type} with ${member.canGet ? "get" : ""}${member.canGet && member.canSet ? ", " : ""}${member.canSet ? "set" : ""}`;
  if (member.kind === "callbackProperty") return `abstract \`\`${member.name}\`\`: ${member.helperName}${member.optional ? " option" : ""} with get${member.readonly ? "" : ", set"}`;
  return `abstract \`\`${member.name}\`\`: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`;
};
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after class review, compile, import, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact dependency-free runtime classes exported by Babylon.js 9.19.0.",
  "module SimpleClasses ="
];
for (const entry of entries) {
  for (const member of [...entry.instanceMembers, ...entry.staticMembers].filter(member => member.kind === "callbackProperty")) {
    const helperName = `${entry.name}${pascal(member.name)}Callback`;
    member.helperName = helperName;
    lines.push("", `    /// Function-valued ${entry.name}.${member.name} property.`, "    [<AllowNullLiteral>]", `    type ${helperName} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
  }
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${entry.name} =`);
  if (entry.instanceMembers.length === 0) lines.push("        interface end");
  else for (const member of entry.instanceMembers) lines.push(`        ${renderMember(member)}`);
  lines.push("", "    [<AllowNullLiteral>]", `    type ${entry.name}Static =`);
  if (entry.constructors.length === 0 && entry.staticMembers.length === 0) lines.push("        interface end");
  for (const constructor of entry.constructors) lines.push(`        [<EmitConstructor>] abstract Create: ${callbackArguments(constructor)} -> ${entry.name}`);
  for (const member of entry.staticMembers) lines.push(`        ${renderMember(member)}`);
  lines.push("", `    [<Import("${entry.name}", "${entry.module}.js")>]`, `    let ${entry.name}: ${entry.name}Static = jsNative`);
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
    kind: "class",
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.SimpleClasses.${entry.name}`,
    memberCount: entry.instanceMembers.length + entry.staticMembers.length + entry.constructors.length
  }))
};
const proposalPath = resolve(root, "generated-candidates/SimpleClasses.proposal.fs");
const manifestPath = resolve(root, "generated-candidates/SimpleClasses.promotion.json");
const renderedManifest = `${JSON.stringify(manifest, null, 2)}\n`;
if (check) {
  if (await readFile(proposalPath, "utf8") !== proposal || await readFile(manifestPath, "utf8") !== renderedManifest) throw new Error("simple class promotion proposal is stale");
} else {
  await writeFile(proposalPath, proposal);
  await writeFile(manifestPath, renderedManifest);
}
console.log(`generated reviewed-promotion proposal for ${entries.length} exact dependency-free classes (${sha256(proposal)})`);
