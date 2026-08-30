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
  "src/BabylonjsBindings/type-alias-coverage-manifest.json",
  "src/BabylonjsBindings/simple-interface-coverage-manifest.json",
  "src/BabylonjsBindings/simple-class-coverage-manifest.json"
];
const dependencyExports = (await Promise.all(dependencyManifestPaths.map(async path => JSON.parse(await readFile(resolve(root, path), "utf8")))))
  .flatMap(manifest => manifest.exports);
const dependencyNameCounts = new Map();
for (const entry of dependencyExports) dependencyNameCounts.set(entry.name, (dependencyNameCounts.get(entry.name) ?? 0) + 1);
const maintainedSymbols = new Map(dependencyExports
  .filter(entry => dependencyNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { fsharpSymbol: entry.fsharpSymbol, arity: entry.typeParameterCount ?? 0 }]));

const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "BigUint64Array", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
const browserTypes = new Set([
  "Event", "File", "HTMLElement", "HTMLCanvasElement", "HTMLImageElement", "HTMLVideoElement", "KeyboardEvent",
  "ImageBitmap", "ImageData", "OffscreenCanvas", "WebGLUniformLocation", "WebGLRenderingContext", "WebGL2RenderingContext",
  "WebGLProgram", "WebGLShader", "WebGLBuffer", "WebGLTexture", "WebGLFramebuffer", "WebGLRenderbuffer",
  "WebGLSampler", "WebGLTransformFeedback", "WebGLVertexArrayObject"
]);
const fsharpType = node => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
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
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (node.typeName.text === "Array" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `ResizeArray<${inner}>` : undefined;
    }
    if (node.typeName.text === "Promise" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `JS.Promise<${inner}>` : undefined;
    }
    if (node.typeName.text === "Nullable" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `${inner} option` : undefined;
    }
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    if (!node.typeArguments?.length && browserTypes.has(node.typeName.text)) return `Browser.Types.${node.typeName.text}`;
    if (maintainedSymbols.has(node.typeName.text)) {
      const target = maintainedSymbols.get(node.typeName.text);
      const arguments_ = node.typeArguments ?? [];
      if (arguments_.length !== target.arity) return undefined;
      const renderedArguments = arguments_.map(fsharpType);
      if (renderedArguments.some(argument => !argument)) return undefined;
      return target.arity === 0 ? target.fsharpSymbol : `${target.fsharpSymbol}<${renderedArguments.join(", ")}>`;
    }
  }
  return undefined;
};
const functionShape = node => {
  if (!ts.isFunctionTypeNode(node) || node.typeParameters?.length || node.parameters.some(parameter => parameter.dotDotDotToken || (ts.isIdentifier(parameter.name) && parameter.name.text === "this"))) return undefined;
  const returnType = fsharpType(node.type);
  const parameters = node.parameters.map(parameter => ({
    name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
    type: parameter.type ? fsharpType(parameter.type) : undefined,
    optional: Boolean(parameter.questionToken)
  }));
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters } : undefined;
};
const typeLiteralShape = node => {
  if (!ts.isTypeLiteralNode(node) || node.members.length === 0) return undefined;
  const members = [];
  for (const member of node.members) {
    if (!ts.isPropertySignature(member) || !member.type || (!ts.isIdentifier(member.name) && !ts.isStringLiteral(member.name))) return undefined;
    const type = fsharpType(member.type);
    if (!type) return undefined;
    members.push({
      name: member.name.text,
      type: member.questionToken ? `${type} option` : type,
      readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false
    });
  }
  return members;
};

const variables = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases are excluded */ }
    }
    const declarations = target.declarations ?? [];
    const variableDeclarations = declarations.filter(ts.isVariableDeclaration);
    if (variableDeclarations.length !== 1 || declarations.some(declaration => !ts.isVariableDeclaration(declaration))) continue;
    const declaration = variableDeclarations[0];
    if (!declaration.type || !ts.isIdentifier(declaration.name)) continue;
    const shape = typeLiteralShape(declaration.type);
    const callable = functionShape(declaration.type);
    const type = fsharpType(declaration.type);
    if (!type && !shape && !callable) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    const runtimeExport = target.getName();
    variables.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, runtimeExport, type, shape, callable });
  }
}

const nameCounts = new Map();
for (const entry of variables.values()) nameCounts.set(entry.name, (nameCounts.get(entry.name) ?? 0) + 1);
const entries = [...variables.values()].filter(entry => nameCounts.get(entry.name) === 1).sort((left, right) => left.name.localeCompare(right.name));
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after variable review, compile, import, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact dependency-closed variables and constants exported by Babylon.js 9.19.0.",
  "module SimpleVariables ="
];
const safeName = value => `VariableShape_${value.replace(/[^A-Za-z0-9_]/g, "_")}`;
const safeFunctionName = value => `VariableFunction_${value.replace(/[^A-Za-z0-9_]/g, "_")}`;
const callbackArguments = callback => callback.parameters.length === 0
  ? "unit"
  : callback.parameters.map(parameter => `${parameter.optional ? "?" : ""}\`\`${parameter.name}\`\`: ${parameter.type}`).join(" * ");
for (const entry of entries) {
  if (entry.shape) {
    entry.type = safeName(entry.name);
    lines.push("", `    /// Inline object shape of ${entry.name}.`, "    [<AllowNullLiteral>]", `    type ${entry.type} =`);
    for (const member of entry.shape) lines.push(`        abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`);
  } else if (entry.callable) {
    entry.type = safeFunctionName(entry.name);
    lines.push("", `    /// Callable shape of ${entry.name}.`, "    [<AllowNullLiteral>]", `    type ${entry.type} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(entry.callable)} -> ${entry.callable.returnType}`);
  }
  lines.push("", `    /// ${entry.module}`, `    [<Import("${entry.runtimeExport}", "${entry.module}.js")>]`, `    let \`\`${entry.name}\`\`: ${entry.type} = jsNative`);
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
    kind: "variable",
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.SimpleVariables.${entry.name}`,
    ...(entry.runtimeExport !== entry.name ? { runtimeExport: entry.runtimeExport } : {}),
    fsharpType: entry.type,
    ...(entry.shape ? { memberCount: entry.shape.length } : {}),
    ...(entry.callable ? { parameterCount: entry.callable.parameters.length } : {})
  }))
};
const proposalPath = resolve(root, "generated-candidates/SimpleVariables.proposal.fs");
const manifestPath = resolve(root, "generated-candidates/SimpleVariables.promotion.json");
const renderedManifest = `${JSON.stringify(manifest, null, 2)}\n`;
if (check) {
  if (await readFile(proposalPath, "utf8") !== proposal || await readFile(manifestPath, "utf8") !== renderedManifest) throw new Error("simple variable promotion proposal is stale");
} else {
  await writeFile(proposalPath, proposal);
  await writeFile(manifestPath, renderedManifest);
}
console.log(`generated reviewed-promotion proposal for ${entries.length} exact dependency-closed variables (${sha256(proposal)})`);
