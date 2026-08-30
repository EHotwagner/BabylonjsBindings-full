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
const deepImmutableAliasNames = new Set();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath)) continue;
  const visit = node => {
    if (ts.isTypeReferenceNode(node)
      && ts.isIdentifier(node.typeName)
      && node.typeName.text === "DeepImmutable"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments?.length) {
      deepImmutableAliasNames.add(node.typeArguments[0].typeName.text);
    }
    ts.forEachChild(node, visit);
  };
  visit(sourceFile);
}

const fsharpType = node => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "System.Double";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isParenthesizedTypeNode(node)) return fsharpType(node.type);
  if (ts.isUnionTypeNode(node) && node.types.length >= 2 && node.types.length <= 9) {
    const branches = node.types.map(fsharpType);
    return branches.every(Boolean) ? `U${branches.length}<${branches.join(", ")}>` : undefined;
  }
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType);
    return element ? `ResizeArray<${element}>` : undefined;
  }
  if (ts.isTupleTypeNode(node) && node.elements.length >= 2) {
    const elements = node.elements.map(element => ts.isNamedTupleMember(element) && !element.questionToken && !element.dotDotDotToken ? fsharpType(element.type) : !ts.isNamedTupleMember(element) ? fsharpType(element) : undefined);
    return elements.every(Boolean) ? `(${elements.join(" * ")})` : undefined;
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (node.typeName.text === "Array" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `ResizeArray<${inner}>` : undefined;
    }
    const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "BigUint64Array", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    const browserTypes = new Set(["HTMLCanvasElement", "HTMLImageElement", "HTMLVideoElement", "ImageData"]);
    if (!node.typeArguments?.length && browserTypes.has(node.typeName.text)) return `Browser.Types.${node.typeName.text}`;
  }
  return undefined;
};
const deepImmutableFsharpType = node => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "System.Double";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (ts.isParenthesizedTypeNode(node)) return deepImmutableFsharpType(node.type);
  if (ts.isUnionTypeNode(node) && node.types.length >= 2 && node.types.length <= 9) {
    const branches = node.types.map(deepImmutableFsharpType);
    return branches.every(Boolean) ? `U${branches.length}<${branches.join(", ")}>` : undefined;
  }
  if (ts.isArrayTypeNode(node)) {
    const element = deepImmutableFsharpType(node.elementType);
    return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (node.typeName.text === "Array" && node.typeArguments?.length === 1) {
      const element = deepImmutableFsharpType(node.typeArguments[0]);
      return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
    }
    const typedArrays = new Set(["BigInt64Array", "BigUint64Array", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
    if (!node.typeArguments?.length && typedArrays.has(node.typeName.text)) return `JS.${node.typeName.text}`;
  }
  return undefined;
};

const entriesByIdentity = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases are excluded */ }
    }
    const declaration = target.declarations?.[0];
    if (!declaration || !ts.isTypeAliasDeclaration(declaration)) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    let entry;
    const isNullable = name === "Nullable"
      && declaration.typeParameters?.length === 1
      && ts.isUnionTypeNode(declaration.type)
      && declaration.type.types.length === 2
      && declaration.type.types.some(node => ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName) && node.typeName.text === declaration.typeParameters[0].name.text)
      && declaration.type.types.some(node => ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword);
    if (isNullable) {
      entry = { package: packageName, module, name, shape: "genericAlias", typeParameter: declaration.typeParameters[0].name.text, target: `'${declaration.typeParameters[0].name.text} option` };
    } else if (!declaration.typeParameters?.length && ts.isFunctionTypeNode(declaration.type)) {
      if (declaration.type.parameters.some(parameter => parameter.dotDotDotToken)) continue;
      const returnType = fsharpType(declaration.type.type);
      const parameters = declaration.type.parameters.map(parameter => ({
        name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
        type: parameter.type ? fsharpType(parameter.type) : undefined,
        optional: Boolean(parameter.questionToken)
      }));
      if (!returnType || parameters.some(parameter => !parameter.name || !parameter.type)) continue;
      entry = { package: packageName, module, name, shape: "callback", returnType, parameters };
    } else if (!declaration.typeParameters?.length) {
      const targetType = fsharpType(declaration.type);
      if (targetType) entry = {
        package: packageName,
        module,
        name,
        shape: "alias",
        target: targetType,
        ...(deepImmutableAliasNames.has(name) && deepImmutableFsharpType(declaration.type) ? { deepImmutableTarget: deepImmutableFsharpType(declaration.type) } : {})
      };
    }
    if (entry) entriesByIdentity.set(`${packageName}|${module}|${name}`, entry);
  }
}

const entries = [...entriesByIdentity.values()].sort((left, right) => left.name.localeCompare(right.name));
const names = new Set();
for (const entry of entries) {
  if (names.has(entry.name)) throw new Error(`simple alias name collision requires explicit module design: ${entry.name}`);
  names.add(entry.name);
}
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after alias review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact primitive aliases and dependency-free callbacks exported by Babylon.js 9.19.0.",
  "module TypeAliases ="
];
for (const entry of entries) {
  lines.push("", `    /// ${entry.module}`);
  if (entry.shape === "alias" || entry.shape === "genericAlias") {
    const generic = entry.shape === "genericAlias" ? `<'${entry.typeParameter}>` : "";
    lines.push(`    type ${entry.name}${generic} = ${entry.target}`);
    if (entry.deepImmutableTarget) lines.push(`    type DeepImmutable${entry.name} = ${entry.deepImmutableTarget}`);
  } else {
    const argumentsType = entry.parameters.length === 0
      ? "unit"
      : entry.parameters.map(parameter => `${parameter.optional ? "?" : ""}${parameter.name}: ${parameter.type}`).join(" * ");
    lines.push("    [<AllowNullLiteral>]", `    type ${entry.name} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${argumentsType} -> ${entry.returnType}`);
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
    fsharpSymbol: `BabylonjsBindings.TypeAliases.${entry.name}`,
    ...(entry.deepImmutableTarget ? { deepImmutableSymbol: `BabylonjsBindings.TypeAliases.DeepImmutable${entry.name}` } : {}),
    shape: entry.shape,
    ...(entry.shape === "genericAlias" ? { typeParameterCount: 1 } : {}),
    memberCount: entry.shape === "callback" ? entry.parameters.length : 1
  }))
};
const proposalPath = resolve(root, "generated-candidates/SimpleAliases.proposal.fs");
const manifestPath = resolve(root, "generated-candidates/SimpleAliases.promotion.json");
const renderedManifest = `${JSON.stringify(manifest, null, 2)}\n`;
if (check) {
  if (await readFile(proposalPath, "utf8") !== proposal || await readFile(manifestPath, "utf8") !== renderedManifest) {
    throw new Error("simple alias promotion proposal is stale");
  }
} else {
  await writeFile(proposalPath, proposal);
  await writeFile(manifestPath, renderedManifest);
}
console.log(`generated reviewed-promotion proposal for ${entries.length} exact primitive/callback aliases (${sha256(proposal)})`);
