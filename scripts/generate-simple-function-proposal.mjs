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
  "ImageData", "WebGLUniformLocation", "WebGLRenderingContext",
  "WebGLProgram", "WebGLShader", "WebGLBuffer", "WebGLTexture", "WebGLFramebuffer", "WebGLRenderbuffer",
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
  if (ts.isTupleTypeNode(node) && node.elements.length >= 2) {
    const elements = node.elements.map(element => ts.isNamedTupleMember(element) && !element.questionToken && !element.dotDotDotToken ? fsharpType(element.type) : !ts.isNamedTupleMember(element) ? fsharpType(element) : undefined);
    return elements.every(Boolean) ? `(${elements.join(" * ")})` : undefined;
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
const signature = declaration => {
  if (declaration.typeParameters?.length || !declaration.type || declaration.parameters.some(parameter => parameter.dotDotDotToken)) return undefined;
  const returnType = fsharpType(declaration.type);
  const parameters = declaration.parameters.map(parameter => ({
    name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
    type: parameter.type ? fsharpType(parameter.type) : undefined,
    optional: Boolean(parameter.questionToken)
  }));
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters } : undefined;
};

const functions = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases are excluded */ }
    }
    const declarations = target.declarations ?? [];
    const functionDeclarations = declarations.filter(ts.isFunctionDeclaration);
    if (functionDeclarations.length === 0 || declarations.some(declaration => ts.isClassDeclaration(declaration) || ts.isInterfaceDeclaration(declaration) || ts.isModuleDeclaration(declaration) || ts.isVariableDeclaration(declaration))) continue;
    const signatures = functionDeclarations.map(signature);
    if (signatures.some(value => !value)) continue;
    const declaration = functionDeclarations[0];
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    if (functionDeclarations.some(item => normalize(item.getSourceFile().fileName).replace(/\.d\.ts$/, "") !== module)) continue;
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    const runtimeExport = target.getName();
    functions.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, runtimeExport, signatures });
  }
}

const nameCounts = new Map();
for (const entry of functions.values()) nameCounts.set(entry.name, (nameCounts.get(entry.name) ?? 0) + 1);
const entries = [...functions.values()].filter(entry => nameCounts.get(entry.name) === 1).sort((left, right) => left.name.localeCompare(right.name));
const callbackArguments = callback => callback.parameters.length === 0
  ? "unit"
  : callback.parameters.map(parameter => `${parameter.optional ? "?" : ""}\`\`${parameter.name}\`\`: ${parameter.type}`).join(" * ");
const safeName = value => `FunctionBinding_${value.replace(/[^A-Za-z0-9_]/g, "_")}`;
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after function review, compile, import, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact dependency-closed functions exported by Babylon.js 9.19.0.",
  "module SimpleFunctions ="
];
for (const entry of entries) {
  const bindingType = safeName(entry.name);
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${bindingType} =`);
  for (const overload of entry.signatures) lines.push(`        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(overload)} -> ${overload.returnType}`);
  lines.push("", `    [<Import("${entry.runtimeExport}", "${entry.module}.js")>]`, `    let \`\`${entry.name}\`\`: ${bindingType} = jsNative`);
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
    kind: "function",
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.SimpleFunctions.${entry.name}`,
    ...(entry.runtimeExport !== entry.name ? { runtimeExport: entry.runtimeExport } : {}),
    overloadCount: entry.signatures.length
  }))
};
const proposalPath = resolve(root, "generated-candidates/SimpleFunctions.proposal.fs");
const manifestPath = resolve(root, "generated-candidates/SimpleFunctions.promotion.json");
const renderedManifest = `${JSON.stringify(manifest, null, 2)}\n`;
if (check) {
  if (await readFile(proposalPath, "utf8") !== proposal || await readFile(manifestPath, "utf8") !== renderedManifest) throw new Error("simple function promotion proposal is stale");
} else {
  await writeFile(proposalPath, proposal);
  await writeFile(manifestPath, renderedManifest);
}
console.log(`generated reviewed-promotion proposal for ${entries.length} exact dependency-closed functions (${sha256(proposal)})`);
