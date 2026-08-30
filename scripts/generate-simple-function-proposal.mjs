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
const diagnose = process.argv.includes("--diagnose");
const typeFailureCounts = new Map();
const failedFunctions = new Map();
let diagnosedFunction;
const recordTypeFailure = node => {
  if (!diagnose) return;
  const text = node.getText().replace(/\s+/g, " ");
  const key = `${ts.SyntaxKind[node.kind]}: ${text.length > 160 ? `${text.slice(0, 157)}...` : text}`;
  typeFailureCounts.set(key, (typeFailureCounts.get(key) ?? 0) + 1);
  if (diagnosedFunction) {
    const failures = failedFunctions.get(diagnosedFunction) ?? new Set();
    failures.add(key);
    failedFunctions.set(diagnosedFunction, failures);
  }
};

const dependencyManifestPaths = [
  "src/BabylonjsBindings/coverage-manifest.json",
  "src/BabylonjsBindings/string-coverage-manifest.json",
  "src/BabylonjsBindings/object-type-coverage-manifest.json",
  "generated-candidates/SimpleAliases.promotion.json",
  "generated-candidates/SimpleInterfaces.promotion.json",
  "generated-candidates/SimpleClasses.promotion.json"
];
const dependencyExports = (await Promise.all(dependencyManifestPaths.map(async path => JSON.parse(await readFile(resolve(root, path), "utf8")))))
  .flatMap(manifest => manifest.exports);
const dependencyNameCounts = new Map();
for (const entry of dependencyExports) dependencyNameCounts.set(entry.name, (dependencyNameCounts.get(entry.name) ?? 0) + 1);
const maintainedSymbols = new Map(dependencyExports
  .filter(entry => dependencyNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { fsharpSymbol: entry.fsharpSymbol, deepImmutableSymbol: entry.deepImmutableSymbol, partialSymbol: entry.partialSymbol, arity: entry.typeParameterCount ?? 0 }]));

const isAbsentType = node => node.kind === ts.SyntaxKind.UndefinedKeyword
  || (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword);
const asOption = type => type.endsWith(" option") ? type : `${type} option`;
const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "DataView", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
const browserTypes = new Set([
  "AudioBuffer", "AudioContext", "AudioNode", "Blob", "Event", "File", "HTMLElement", "HTMLCanvasElement", "HTMLImageElement", "HTMLVideoElement", "KeyboardEvent",
  "ImageData", "OfflineAudioContext", "WebGLUniformLocation", "WebGLRenderingContext",
  "WebGLProgram", "WebGLShader", "WebGLBuffer", "WebGLTexture", "WebGLFramebuffer", "WebGLRenderbuffer",
]);
const numericLiteralValues = new Set();
const stringLiteralTypes = new Map();
const inlineTypesByName = new Map();
const fsharpString = value => `"${value.replaceAll("\\", "\\\\").replaceAll("\"", "\\\"").replaceAll("\n", "\\n").replaceAll("\r", "\\r")}"`;
const stringLiteralType = value => {
  const name = `StringLiteral${createHash("sha256").update(value).digest("hex").slice(0, 12)}`;
  stringLiteralTypes.set(name, value);
  return name;
};
const numericLiteralType = value => {
  const numeric = Number(value);
  if (!Number.isSafeInteger(numeric) || numeric < -2147483648 || numeric > 2147483647) return undefined;
  numericLiteralValues.add(numeric);
  return `NumericLiteral${numeric < 0 ? `Negative${Math.abs(numeric)}` : numeric}`;
};
const fsharpType = (node, typeParameters = new Map()) => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.NeverKeyword) return "BabylonjsBindings.SimpleClasses.Never";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isLiteralTypeNode(node) && ts.isNumericLiteral(node.literal)) return numericLiteralType(node.literal.text);
  if (ts.isLiteralTypeNode(node) && ts.isStringLiteral(node.literal)) return stringLiteralType(node.literal.text);
  if (ts.isTypePredicateNode(node)) return "bool";
  if (ts.isParenthesizedTypeNode(node)) return fsharpType(node.type, typeParameters);
  if (ts.isTypeOperatorNode(node) && node.operator === ts.SyntaxKind.ReadonlyKeyword) {
    if (ts.isArrayTypeNode(node.type)) {
      const element = fsharpType(node.type.elementType, typeParameters);
      return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
    }
    return fsharpType(node.type, typeParameters);
  }
  if (ts.isUnionTypeNode(node) && node.types.length === 2 && node.types.filter(isAbsentType).length === 1) {
    const inner = fsharpType(node.types.find(branch => !isAbsentType(branch)), typeParameters);
    return inner ? asOption(inner) : undefined;
  }
  if (ts.isUnionTypeNode(node) && node.types.length >= 2 && node.types.length <= 9) {
    const branches = node.types.map(branch => fsharpType(branch, typeParameters));
    return branches.every(Boolean) ? `U${branches.length}<${branches.join(", ")}>` : undefined;
  }
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType, typeParameters);
    return element ? `ResizeArray<${element}>` : undefined;
  }
  if (ts.isTupleTypeNode(node) && node.elements.length >= 2) {
    const elements = node.elements.map(element => ts.isNamedTupleMember(element) && !element.questionToken && !element.dotDotDotToken ? fsharpType(element.type, typeParameters) : !ts.isNamedTupleMember(element) ? fsharpType(element, typeParameters) : undefined);
    return elements.every(Boolean) ? `(${elements.join(" * ")})` : undefined;
  }
  if (ts.isFunctionTypeNode(node)
    && !node.typeParameters?.length
    && !node.parameters.some(parameter => parameter.dotDotDotToken || parameter.questionToken)) {
    const parameterTypes = node.parameters.map(parameter => parameter.type ? fsharpType(parameter.type, typeParameters) : undefined);
    const returnType = fsharpType(node.type, typeParameters);
    if (returnType && parameterTypes.every(Boolean)) {
      if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
      return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
    }
  }
  if (ts.isTypeLiteralNode(node)) return inlineObjectType(node, typeParameters);
  if (ts.isImportTypeNode(node)
    && node.qualifier
    && ts.isIdentifier(node.qualifier)
    && !node.typeArguments?.length) {
    const target = maintainedSymbols.get(node.qualifier.text);
    if (target?.arity === 0) return target.fsharpSymbol;
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (!node.typeArguments?.length && typeParameters.has(node.typeName.text)) return `'${node.typeName.text}`;
    if (node.typeName.text === "DeepImmutable"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments?.length) {
      return maintainedSymbols.get(node.typeArguments[0].typeName.text)?.deepImmutableSymbol;
    }
    if (node.typeName.text === "Partial" && node.typeArguments?.length === 1) {
      const inner = node.typeArguments[0];
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && !inner.typeArguments?.length) {
        return maintainedSymbols.get(inner.typeName.text)?.partialSymbol;
      }
    }
    if (node.typeName.text === "Array" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], typeParameters);
      return inner ? `ResizeArray<${inner}>` : undefined;
    }
    if (["ArrayLike", "ReadonlyArray"].includes(node.typeName.text) && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], typeParameters);
      return inner ? `System.Collections.Generic.IReadOnlyList<${inner}>` : undefined;
    }
    if (node.typeName.text === "Promise" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], typeParameters);
      return inner ? `JS.Promise<${inner}>` : undefined;
    }
    if (node.typeName.text === "Nullable" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], typeParameters);
      return inner ? `${inner} option` : undefined;
    }
    if (node.typeName.text === "Set" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], typeParameters);
      return inner ? `JS.Set<${inner}>` : undefined;
    }
    if (node.typeName.text === "Map" && node.typeArguments?.length === 2) {
      const key = fsharpType(node.typeArguments[0], typeParameters);
      const value = fsharpType(node.typeArguments[1], typeParameters);
      return key && value ? `JS.Map<${key}, ${value}>` : undefined;
    }
    if (node.typeName.text === "Error" && !node.typeArguments?.length) return "System.Exception";
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmap") return "BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap";
    if (!node.typeArguments?.length && browserTypes.has(node.typeName.text)) return `Browser.Types.${node.typeName.text}`;
    if (maintainedSymbols.has(node.typeName.text)) {
      const target = maintainedSymbols.get(node.typeName.text);
      const arguments_ = node.typeArguments ?? [];
      if (arguments_.length !== target.arity) return undefined;
      const renderedArguments = arguments_.map(argument => fsharpType(argument, typeParameters));
      if (renderedArguments.some(argument => !argument)) return undefined;
      return target.arity === 0 ? target.fsharpSymbol : `${target.fsharpSymbol}<${renderedArguments.join(", ")}>`;
    }
  }
  recordTypeFailure(node);
  return undefined;
};
const inlineObjectType = (node, typeParameters) => {
  const parameterNames = [...typeParameters.keys()];
  const digest = createHash("sha256").update(`${node.getText().replace(/\s+/g, " ")}|${parameterNames.join(",")}`).digest("hex").slice(0, 12);
  const name = `InlineObject${digest}`;
  const genericParameters = parameterNames.length ? `<${parameterNames.map(value => `'${value}`).join(", ")}>` : "";
  if (inlineTypesByName.has(name)) return `${name}${genericParameters}`;
  const members = [];
  for (const member of node.members) {
    if (ts.isPropertySignature(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      const rendered = fsharpType(member.type, typeParameters);
      if (!rendered) return undefined;
      members.push({ kind: "property", name: member.name.text, type: member.questionToken ? asOption(rendered) : rendered, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else if (ts.isIndexSignatureDeclaration(member)
      && member.parameters.length === 1
      && member.parameters[0].type
      && member.type
      && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type, typeParameters);
      const valueType = fsharpType(member.type, typeParameters);
      if (!keyType || !valueType) return undefined;
      members.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else {
      recordTypeFailure(member);
      return undefined;
    }
  }
  inlineTypesByName.set(name, { name, genericParameters, members });
  return `${name}${genericParameters}`;
};
const signature = declaration => {
  if (!declaration.type || declaration.parameters.some(parameter => parameter.dotDotDotToken)) return undefined;
  const typeParameters = new Map();
  for (const parameter of declaration.typeParameters ?? []) {
    if (parameter.default
      || !parameter.constraint
      || !ts.isTypeReferenceNode(parameter.constraint)
      || !ts.isIdentifier(parameter.constraint.typeName)
      || parameter.constraint.typeArguments?.length
      || !maintainedSymbols.has(parameter.constraint.typeName.text)) return undefined;
    typeParameters.set(parameter.name.text, maintainedSymbols.get(parameter.constraint.typeName.text).fsharpSymbol);
  }
  const returnType = fsharpType(declaration.type, typeParameters);
  const parameters = declaration.parameters.map(parameter => ({
    name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
    type: parameter.type ? fsharpType(parameter.type, typeParameters) : undefined,
    optional: Boolean(parameter.questionToken)
  }));
  const genericParameters = typeParameters.size
    ? `<${[...typeParameters.keys()].map(name => `'${name}`).join(", ")} when ${[...typeParameters].map(([name, constraint]) => `'${name} :> ${constraint}`).join(" and ")}>`
    : "";
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters, genericParameters } : undefined;
};

const functions = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    diagnosedFunction = exported.getName();
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
diagnosedFunction = undefined;

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
let inlineReferenceText = JSON.stringify(entries);
const retainedFunctionInlineTypes = [];
while (true) {
  const additions = [...inlineTypesByName.values()].filter(inline => !retainedFunctionInlineTypes.includes(inline) && inlineReferenceText.includes(inline.name));
  if (additions.length === 0) break;
  retainedFunctionInlineTypes.push(...additions);
  inlineReferenceText += JSON.stringify(additions);
}
for (const inline of retainedFunctionInlineTypes) {
  lines.push("", "    /// Exact inline object used by a Babylon function signature.", "    [<AllowNullLiteral>]", `    type ${inline.name}${inline.genericParameters} =`);
  if (inline.members.length === 0) lines.push("        interface end");
  for (const member of inline.members) {
    if (member.kind === "property") lines.push(`        abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`);
    else lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`);
  }
}
for (const value of [...numericLiteralValues].sort((left, right) => left - right)) {
  const name = `NumericLiteral${value < 0 ? `Negative${Math.abs(value)}` : value}`;
  lines.push("", `    /// Exact numeric literal type for ${value}.`, `    type ${name} =`, `        | Value = ${value}`);
}
for (const [name, value] of [...stringLiteralTypes].sort(([left], [right]) => left.localeCompare(right))) {
  lines.push("", `    /// Exact string literal type for ${fsharpString(value)}.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, `        | [<CompiledName(${fsharpString(value)})>] Value`);
}
for (const entry of entries) {
  const bindingType = safeName(entry.name);
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${bindingType} =`);
  for (const overload of entry.signatures) lines.push(`        [<Emit("$0($1...)")>] abstract Invoke${overload.genericParameters}: ${callbackArguments(overload)} -> ${overload.returnType}`);
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
if (diagnose) {
  console.log("top unresolved function member types:");
  console.log([...typeFailureCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 100).map(([type, count]) => `${count} ${type}`).join("\n"));
  console.log(`diagnostic: ${failedFunctions.size} exported names encountered unresolved function types`);
  console.log("sample blocked functions:");
  console.log([...failedFunctions].sort(([left], [right]) => left.localeCompare(right)).slice(0, 120).map(([name, failures]) => `${name}: ${[...failures].slice(0, 5).join(" | ")}`).join("\n"));
}
