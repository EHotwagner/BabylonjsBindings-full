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
let collectTypeFailures = false;
const utilityInlineTypes = [];
const numericLiteralValues = new Set();
const stringLiteralTypes = new Map();
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
const recordTypeFailure = node => {
  if (!collectTypeFailures) return;
  const text = node.getText().replace(/\s+/g, " ");
  const key = `${ts.SyntaxKind[node.kind]}: ${text.length > 160 ? `${text.slice(0, 157)}...` : text}`;
  typeFailureCounts.set(key, (typeFailureCounts.get(key) ?? 0) + 1);
};
const deepImmutableInterfaceNames = new Set();
const partialInterfaceNames = new Set();
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
      deepImmutableInterfaceNames.add(node.typeArguments[0].typeName.text);
    }
    if (ts.isTypeReferenceNode(node)
      && ts.isIdentifier(node.typeName)
      && node.typeName.text === "Partial"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments?.length) {
      partialInterfaceNames.add(node.typeArguments[0].typeName.text);
    }
    ts.forEachChild(node, visit);
  };
  visit(sourceFile);
}

const dependencyManifestPaths = [
  "src/BabylonjsBindings/coverage-manifest.json",
  "src/BabylonjsBindings/string-coverage-manifest.json",
  "src/BabylonjsBindings/object-type-coverage-manifest.json",
  "generated-candidates/SimpleAliases.promotion.json",
  "generated-candidates/SimpleClasses.promotion.json"
];
const dependencyExports = (await Promise.all(dependencyManifestPaths.map(async path => JSON.parse(await readFile(resolve(root, path), "utf8")))))
  .flatMap(manifest => manifest.exports);
const dependencyNameCounts = new Map();
for (const entry of dependencyExports) dependencyNameCounts.set(entry.name, (dependencyNameCounts.get(entry.name) ?? 0) + 1);
const maintainedSymbols = new Map(dependencyExports
  .filter(entry => dependencyNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { fsharpSymbol: entry.fsharpSymbol, arity: entry.typeParameterCount ?? 0 }]));

const isAbsentType = node => node.kind === ts.SyntaxKind.UndefinedKeyword
  || (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword);
const asOption = type => type.endsWith(" option") ? type : `${type} option`;
const asOptionalParameterType = type => type.endsWith(" option") ? type.slice(0, -" option".length) : type;
const erasedUnionType = branches => {
  if (branches.length < 2) return branches[0];
  if (branches.length <= 9) return `U${branches.length}<${branches.join(", ")}>`;
  return `U2<${erasedUnionType(branches.slice(0, 8))}, ${erasedUnionType(branches.slice(8))}>`;
};
const fsharpType = (node, available, dependencies = new Set(), typeParameters = new Set()) => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.ObjectKeyword) return "JavaScriptObject";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isLiteralTypeNode(node) && ts.isNumericLiteral(node.literal)) return numericLiteralType(node.literal.text);
  if (ts.isLiteralTypeNode(node) && ts.isStringLiteral(node.literal)) return stringLiteralType(node.literal.text);
  if (ts.isParenthesizedTypeNode(node)) return fsharpType(node.type, available, dependencies, typeParameters);
  if (ts.isTypeOperatorNode(node) && node.operator === ts.SyntaxKind.ReadonlyKeyword) {
    if (ts.isArrayTypeNode(node.type)) {
      const element = fsharpType(node.type.elementType, available, dependencies, typeParameters);
      return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
    }
    return fsharpType(node.type, available, dependencies, typeParameters);
  }
  if (ts.isUnionTypeNode(node) && node.types.some(isAbsentType)) {
    const branches = node.types.filter(branch => !isAbsentType(branch)).map(branch => fsharpType(branch, available, dependencies, typeParameters));
    if (branches.some(branch => !branch) || branches.length === 0) return undefined;
    return asOption(branches.length === 1 ? branches[0] : erasedUnionType(branches));
  }
  if (ts.isUnionTypeNode(node) && node.types.length >= 2) {
    const branches = node.types.map(branch => fsharpType(branch, available, dependencies, typeParameters));
    return branches.every(Boolean) ? erasedUnionType(branches) : undefined;
  }
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType, available, dependencies, typeParameters);
    return element ? `ResizeArray<${element}>` : undefined;
  }
  if (ts.isTupleTypeNode(node) && node.elements.length >= 2) {
    const elements = node.elements.map(element => ts.isNamedTupleMember(element) && !element.questionToken && !element.dotDotDotToken ? fsharpType(element.type, available, dependencies, typeParameters) : !ts.isNamedTupleMember(element) ? fsharpType(element, available, dependencies, typeParameters) : undefined);
    return elements.every(Boolean) ? `(${elements.join(" * ")})` : undefined;
  }
  if (ts.isFunctionTypeNode(node)
    && !node.typeParameters?.length
    && !node.parameters.some(parameter => parameter.dotDotDotToken || parameter.questionToken)) {
    const parameterTypes = node.parameters.map(parameter => parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined);
    const returnType = node.type ? fsharpType(node.type, available, dependencies, typeParameters) : undefined;
    if (returnType && parameterTypes.every(Boolean)) {
      if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
      return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
    }
  }
  if (ts.isTypeLiteralNode(node)) {
    const digest = createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12);
    return inlineObjectType(node, available, dependencies, typeParameters, utilityInlineTypes, `InlineObject${digest}`);
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (node.typeName.text === "Tuple" && node.typeArguments?.length === 2) {
      const element = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      const lengthNode = node.typeArguments[1];
      const length = ts.isLiteralTypeNode(lengthNode) && ts.isNumericLiteral(lengthNode.literal)
        ? Number(lengthNode.literal.text)
        : undefined;
      return element && Number.isInteger(length) && length >= 2 && length <= 32
        ? `(${Array.from({ length }, () => element).join(" * ")})`
        : undefined;
    }
    if (node.typeName.text === "Array" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `ResizeArray<${inner}>` : undefined;
    }
    if (node.typeName.text === "Promise" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `JS.Promise<${inner}>` : undefined;
    }
    if (node.typeName.text === "Set" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `JS.Set<${inner}>` : undefined;
    }
    if (node.typeName.text === "Map" && node.typeArguments?.length === 2) {
      const key = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      const value = fsharpType(node.typeArguments[1], available, dependencies, typeParameters);
      return key && value ? `JS.Map<${key}, ${value}>` : undefined;
    }
    if (node.typeName.text === "Nullable" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? asOption(inner) : undefined;
    }
    const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "BigUint64Array", "DataView", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    const browserTypes = new Set([
      "AudioContext", "AudioDestinationNode", "AudioNode", "Blob", "Element", "Event", "File", "GainNode", "HTMLElement", "HTMLCanvasElement", "HTMLImageElement", "HTMLVideoElement", "KeyboardEvent",
      "ImageData", "OfflineAudioContext", "WebGLUniformLocation", "WebGLRenderingContext",
      "WebGLProgram", "WebGLShader", "WebGLBuffer", "WebGLTexture", "WebGLFramebuffer", "WebGLRenderbuffer",
    ]);
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmapOptions") return "BrowserImageBitmapOptions";
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmap") return "BrowserImageBitmap";
    if (!node.typeArguments?.length && browserTypes.has(node.typeName.text)) return `Browser.Types.${node.typeName.text}`;
    if (!node.typeArguments?.length && typeParameters.has(node.typeName.text)) return `'${node.typeName.text}`;
    if (available.has(node.typeName.text)) {
      const target = available.get(node.typeName.text);
      const arguments_ = node.typeArguments ?? [];
      if (arguments_.length !== target.arity) return undefined;
      const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
      if (renderedArguments.some(argument => !argument)) return undefined;
      dependencies.add(node.typeName.text);
      return target.arity === 0 ? node.typeName.text : `${node.typeName.text}<${renderedArguments.join(", ")}>`;
    }
    if (maintainedSymbols.has(node.typeName.text)) {
      const target = maintainedSymbols.get(node.typeName.text);
      const arguments_ = node.typeArguments ?? [];
      if (arguments_.length !== target.arity) return undefined;
      const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
      if (renderedArguments.some(argument => !argument)) return undefined;
      return target.arity === 0 ? target.fsharpSymbol : `${target.fsharpSymbol}<${renderedArguments.join(", ")}>`;
    }
  }
  recordTypeFailure(node);
  return undefined;
};
const inlineObjectType = (node, available, dependencies, typeParameters, inlineTypes, context) => {
  if (!ts.isTypeLiteralNode(node)) return undefined;
  const name = `${context}Object`;
  const genericParameters = typeParameters.size ? `<${[...typeParameters].map(value => `'${value}`).join(", ")}>` : "";
  const members = [];
  for (const [memberIndex, member] of node.members.entries()) {
    if (ts.isPropertySignature(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      let type = fsharpType(member.type, available, dependencies, typeParameters);
      if (!type && ts.isTypeLiteralNode(member.type)) type = inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${name}Property${memberIndex + 1}`);
      if (!type) return undefined;
      members.push({ kind: "property", name: member.name.text, type: member.questionToken ? asOption(type) : type, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else if (ts.isIndexSignatureDeclaration(member) && member.parameters.length === 1 && member.parameters[0].type && member.type && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type, available, dependencies, typeParameters);
      let valueType = fsharpType(member.type, available, dependencies, typeParameters);
      if (!valueType && ts.isTypeLiteralNode(member.type)) valueType = inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${name}Value${memberIndex + 1}`);
      if (!keyType || !valueType) return undefined;
      members.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else {
      return undefined;
    }
  }
  inlineTypes.push({ name, genericParameters, members });
  return `${name}${genericParameters}`;
};
const callbackShape = (node, available, dependencies, typeParameters) => {
  if (node.typeParameters?.length) return undefined;
  if (node.parameters.some(parameter => parameter.dotDotDotToken)) return undefined;
  const returnType = fsharpType(node.type, available, dependencies, typeParameters);
  const parameters = node.parameters.map(parameter => {
    const type = parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined;
    return {
      name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
      type: parameter.questionToken && type ? asOptionalParameterType(type) : type,
      optional: Boolean(parameter.questionToken)
    };
  });
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters } : undefined;
};
const functionType = node => ts.isFunctionTypeNode(node)
  ? node
  : ts.isParenthesizedTypeNode(node) && ts.isFunctionTypeNode(node.type)
    ? node.type
    : undefined;
const callbackPropertyType = node => {
  const direct = functionType(node);
  if (direct) return { node: direct, optional: false };
  if (ts.isTypeReferenceNode(node)
    && ts.isIdentifier(node.typeName)
    && node.typeName.text === "Nullable"
    && node.typeArguments?.length === 1
    && functionType(node.typeArguments[0])) return { node: functionType(node.typeArguments[0]), optional: true };
  if (ts.isUnionTypeNode(node) && node.types.length === 2) {
    const callback = node.types.map(functionType).find(Boolean);
    if (callback && node.types.some(isAbsentType)) return { node: callback, optional: true };
  }
  return undefined;
};
const renderMembers = (declaration, available) => {
  const dependencies = new Set();
  const typeParameters = new Set((declaration.typeParameters ?? []).map(parameter => parameter.name.text));
  const members = [];
  const inlineTypes = [];
  for (const member of declaration.members) {
    if ((ts.isPropertySignature(member) || ts.isMethodSignature(member)) && (!ts.isIdentifier(member.name) && !ts.isStringLiteral(member.name))) return undefined;
    if (ts.isPropertySignature(member) && member.type) {
      const callbackProperty = callbackPropertyType(member.type);
      if (callbackProperty) {
        const callback = callbackShape(callbackProperty.node, available, dependencies, typeParameters);
        if (!callback) return undefined;
        members.push({ kind: "callbackProperty", name: member.name.text, optional: Boolean(member.questionToken) || callbackProperty.optional, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false, callback });
      } else {
        let type = fsharpType(member.type, available, dependencies, typeParameters);
        if (!type && ts.isTypeLiteralNode(member.type)) type = inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${declaration.name.text}Property${members.length + 1}`);
        if (!type) return undefined;
        members.push({ kind: "property", name: member.name.text, type: member.questionToken ? asOption(type) : type, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
      }
    } else if (ts.isMethodSignature(member)) {
      if (member.questionToken) return undefined;
      const callback = callbackShape(member, available, dependencies, typeParameters);
      if (!callback) return undefined;
      members.push({ kind: "method", name: member.name.text, callback });
    } else if (ts.isIndexSignatureDeclaration(member)
      && member.parameters.length === 1
      && member.parameters[0].type
      && member.type
      && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type, available, dependencies, typeParameters);
      const valueType = fsharpType(member.type, available, dependencies, typeParameters);
      if (!keyType || !valueType) return undefined;
      members.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else {
      return undefined;
    }
  }
  return { members, inlineTypes, dependencies: [...dependencies] };
};
const renderHeritage = (declaration, available) => {
  const dependencies = new Set();
  const typeParameters = new Set((declaration.typeParameters ?? []).map(parameter => parameter.name.text));
  const bases = [];
  for (const clause of declaration.heritageClauses ?? []) {
    if (clause.token !== ts.SyntaxKind.ExtendsKeyword) return undefined;
    for (const type of clause.types) {
      if (!ts.isIdentifier(type.expression)) return undefined;
      const name = type.expression.text;
      if (available.has(name)) {
        const target = available.get(name);
        const arguments_ = type.typeArguments ?? [];
        if (arguments_.length !== target.arity) return undefined;
        const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
        if (renderedArguments.some(argument => !argument)) return undefined;
        dependencies.add(name);
        bases.push(target.arity === 0 ? name : `${name}<${renderedArguments.join(", ")}>`);
      } else if (maintainedSymbols.has(name)) {
        const target = maintainedSymbols.get(name);
        const arguments_ = type.typeArguments ?? [];
        if (arguments_.length !== target.arity) return undefined;
        const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
        if (renderedArguments.some(argument => !argument)) return undefined;
        bases.push(target.arity === 0 ? target.fsharpSymbol : `${target.fsharpSymbol}<${renderedArguments.join(", ")}>`);
      } else {
        return undefined;
      }
    }
  }
  return { bases, dependencies: [...dependencies] };
};

const rawDeclarations = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases are excluded */ }
    }
    const interfaceDeclarations = target.declarations?.filter(ts.isInterfaceDeclaration) ?? [];
    if (target.declarations?.some(ts.isClassDeclaration)) continue;
    if (interfaceDeclarations.length !== 1) continue;
    const declaration = interfaceDeclarations[0];
    if (declaration.typeParameters?.some(parameter => parameter.constraint || parameter.default)) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    rawDeclarations.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, declaration });
  }
}

const declarations = new Map();
const declarationsByName = new Map();
for (const [identity, entry] of rawDeclarations) {
  const group = declarationsByName.get(entry.name) ?? [];
  group.push([identity, entry]);
  declarationsByName.set(entry.name, group);
}
for (const group of declarationsByName.values()) {
  const normalizedShapes = new Set(group.map(([, entry]) => entry.declaration.getText().replace(/\s+/g, " ")));
  if (normalizedShapes.size === 1) {
    const [identity, representative] = group[0];
    declarations.set(identity, {
      ...representative,
      coverageEntries: group.map(([, entry]) => ({ package: entry.package, module: entry.module, name: entry.name }))
    });
  } else {
    for (const [identity, entry] of group) declarations.set(identity, { ...entry, coverageEntries: [{ package: entry.package, module: entry.module, name: entry.name }] });
  }
}

const nameCounts = new Map();
for (const entry of declarations.values()) nameCounts.set(entry.name, (nameCounts.get(entry.name) ?? 0) + 1);
const selected = new Map();
const available = new Map();
let rank = 0;
while (true) {
  const additions = [];
  for (const [identity, entry] of declarations) {
    if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
    const renderAvailable = new Map(available);
    renderAvailable.set(entry.name, { arity: entry.declaration.typeParameters?.length ?? 0 });
    const renderedMembers = renderMembers(entry.declaration, renderAvailable);
    const renderedHeritage = renderHeritage(entry.declaration, renderAvailable);
    if (renderedMembers && renderedHeritage) additions.push([identity, { ...entry, ...renderedMembers, ...renderedHeritage, rank }]);
  }
  if (additions.length === 0) break;
  for (const [identity, entry] of additions) {
    selected.set(identity, entry);
    available.set(entry.name, { arity: entry.declaration.typeParameters?.length ?? 0 });
  }
  rank += 1;
}
const recursiveOptimistic = new Map([...declarations.values()]
  .filter(entry => nameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { arity: entry.declaration.typeParameters?.length ?? 0 }]));
const recursiveCandidates = new Map();
for (const [identity, entry] of declarations) {
  if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
  const renderedMembers = renderMembers(entry.declaration, recursiveOptimistic);
  const renderedHeritage = renderHeritage(entry.declaration, recursiveOptimistic);
  if (!renderedMembers || !renderedHeritage) continue;
  recursiveCandidates.set(identity, {
    ...entry,
    ...renderedMembers,
    ...renderedHeritage,
    dependencies: [...new Set([...renderedMembers.dependencies, ...renderedHeritage.dependencies])],
    rank
  });
}
while (true) {
  const candidateNames = new Set([...recursiveCandidates.values()].map(entry => entry.name));
  const rejected = [...recursiveCandidates].filter(([, entry]) => entry.dependencies.some(dependency => !available.has(dependency) && !candidateNames.has(dependency)));
  if (rejected.length === 0) break;
  for (const [identity] of rejected) recursiveCandidates.delete(identity);
}
for (const [identity, entry] of recursiveCandidates) {
  selected.set(identity, entry);
  available.set(entry.name, { arity: entry.declaration.typeParameters?.length ?? 0 });
}
const entries = [...selected.values()].sort((left, right) => left.rank - right.rank || left.name.localeCompare(right.name));
if (diagnose) {
  const optimistic = new Map([...declarations.values()]
    .filter(entry => nameCounts.get(entry.name) === 1)
    .map(entry => [entry.name, { arity: entry.declaration.typeParameters?.length ?? 0 }]));
  let shapeReady = 0;
  const missingCounts = new Map();
  collectTypeFailures = true;
  for (const [identity, entry] of declarations) {
    if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
    const renderedMembers = renderMembers(entry.declaration, optimistic);
    const renderedHeritage = renderHeritage(entry.declaration, optimistic);
    if (renderedMembers && renderedHeritage) {
      shapeReady += 1;
      for (const dependency of [...renderedMembers.dependencies, ...renderedHeritage.dependencies]) {
        if (!available.has(dependency)) missingCounts.set(dependency, (missingCounts.get(dependency) ?? 0) + 1);
      }
    }
  }
  collectTypeFailures = false;
  console.log("top unresolved interface member types:");
  console.log([...typeFailureCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 80).map(([type, count]) => `${count} ${type}`).join("\n"));
  console.log(`diagnostic: ${shapeReady} additional interfaces have renderable shapes with unresolved dependencies`);
  console.log("top unresolved interface dependencies:");
  console.log([...missingCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 40).map(([name, count]) => `${name} ${count}`).join("\n"));
}
const projectedNames = new Set(entries.filter(entry => deepImmutableInterfaceNames.has(entry.name)).map(entry => entry.name));
const entryByName = new Map(entries.map(entry => [entry.name, entry]));
const partialProjectedNames = new Set(entries.filter(entry => partialInterfaceNames.has(entry.name)).map(entry => entry.name));
while (true) {
  const additions = [...partialProjectedNames].flatMap(name => entryByName.get(name)?.bases ?? [])
    .map(base => base.replace(/<.*$/, "").replace(/^.*\./, ""))
    .filter(name => entryByName.has(name) && !partialProjectedNames.has(name));
  if (additions.length === 0) break;
  for (const name of additions) partialProjectedNames.add(name);
}
const deepImmutableType = type => {
  let rendered = type;
  for (const name of projectedNames) rendered = rendered.replace(new RegExp(`\\b${name}\\b`, "g"), `DeepImmutable${name}`);
  return rendered;
};
const pascal = value => value.replace(/(^|[^A-Za-z0-9]+)([A-Za-z0-9])/g, (_, __, character) => character.toUpperCase());
const callbackArguments = callback => callback.parameters.length === 0
  ? "unit"
  : callback.parameters.map(parameter => `${parameter.optional ? "?" : ""}\`\`${parameter.name}\`\`: ${parameter.type}`).join(" * ");
const renderInlineMember = member => member.kind === "property"
  ? `abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`
  : `[<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`;
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after interface review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact dependency-closed interfaces exported by Babylon.js 9.19.0.",
  "module SimpleInterfaces ="
];
lines.push("", "    /// Exact structural browser ImageBitmap surface used by Babylon declarations.", "    [<AllowNullLiteral>]", "    type BrowserImageBitmap =", "        abstract width: float with get", "        abstract height: float with get", "        abstract close: unit -> unit");
lines.push("", "    /// Exact browser image color-space conversion literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserColorSpaceConversion =", "        | [<CompiledName(\"default\")>] Default", "        | [<CompiledName(\"none\")>] None");
lines.push("", "    /// Exact browser image orientation literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserImageOrientation =", "        | [<CompiledName(\"flipY\")>] FlipY", "        | [<CompiledName(\"from-image\")>] FromImage", "        | [<CompiledName(\"none\")>] None");
lines.push("", "    /// Exact browser premultiplied-alpha literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserPremultiplyAlpha =", "        | [<CompiledName(\"default\")>] Default", "        | [<CompiledName(\"none\")>] None", "        | [<CompiledName(\"premultiply\")>] Premultiply");
lines.push("", "    /// Exact browser bitmap resize-quality literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserResizeQuality =", "        | [<CompiledName(\"high\")>] High", "        | [<CompiledName(\"low\")>] Low", "        | [<CompiledName(\"medium\")>] Medium", "        | [<CompiledName(\"pixelated\")>] Pixelated");
lines.push("", "    /// Exact structural browser ImageBitmapOptions surface.", "    [<AllowNullLiteral>]", "    type BrowserImageBitmapOptions =", "        abstract colorSpaceConversion: BrowserColorSpaceConversion option with get, set", "        abstract imageOrientation: BrowserImageOrientation option with get, set", "        abstract premultiplyAlpha: BrowserPremultiplyAlpha option with get, set", "        abstract resizeHeight: float option with get, set", "        abstract resizeQuality: BrowserResizeQuality option with get, set", "        abstract resizeWidth: float option with get, set");
lines.push("", "    /// Structural non-primitive JavaScript object surface used by TypeScript `object` declarations.", "    [<AllowNullLiteral>]", "    type JavaScriptObject =", "        interface end");
for (const value of [...numericLiteralValues].sort((left, right) => left - right)) {
  const name = `NumericLiteral${value < 0 ? `Negative${Math.abs(value)}` : value}`;
  lines.push("", `    /// Exact numeric literal type for ${value}.`, `    type ${name} =`, `        | Value = ${value}`);
}
for (const [name, value] of [...stringLiteralTypes].sort(([left], [right]) => left.localeCompare(right))) {
  lines.push("", `    /// Exact string literal type for ${fsharpString(value)}.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, `        | [<CompiledName(${fsharpString(value)})>] Value`);
}
let utilityReferenceText = JSON.stringify(entries.map(entry => ({ members: entry.members, bases: entry.bases, inlineTypes: entry.inlineTypes })));
const retainedUtilityInlineTypes = [];
while (true) {
  const additions = utilityInlineTypes.filter(inline => !retainedUtilityInlineTypes.includes(inline) && utilityReferenceText.includes(inline.name));
  if (additions.length === 0) break;
  retainedUtilityInlineTypes.push(...additions);
  utilityReferenceText += JSON.stringify(additions);
}
const emittedInlineTypeNames = new Set();
for (const inline of retainedUtilityInlineTypes) {
  if (emittedInlineTypeNames.has(inline.name)) continue;
  emittedInlineTypeNames.add(inline.name);
  lines.push("", "    /// Exact inline object used by a Babylon interface signature.", "    [<AllowNullLiteral>]", `    type ${inline.name}${inline.genericParameters} =`);
  if (inline.members.length === 0) lines.push("        interface end");
  else for (const member of inline.members) lines.push(`        ${renderInlineMember(member)}`);
}
for (const entry of entries) {
  const genericParameters = entry.declaration.typeParameters?.length
    ? `<${entry.declaration.typeParameters.map(parameter => `'${parameter.name.text}`).join(", ")}>`
    : "";
  for (const inline of entry.inlineTypes) {
    if (emittedInlineTypeNames.has(inline.name)) continue;
    emittedInlineTypeNames.add(inline.name);
    lines.push("", `    /// Inline object shape used by ${entry.name}.`, "    [<AllowNullLiteral>]", `    type ${inline.name}${inline.genericParameters} =`);
    if (inline.members.length === 0) lines.push("        interface end");
    else for (const member of inline.members) lines.push(`        ${renderInlineMember(member)}`);
  }
  for (const member of entry.members.filter(member => member.kind === "callbackProperty")) {
    member.helperName = `${entry.name}${pascal(member.name)}Callback${genericParameters}`;
  }
  const hasProjection = projectedNames.has(entry.name);
  if (hasProjection) {
    lines.push("", `    /// Exact readonly projection of ${entry.name} used by Babylon DeepImmutable<${entry.name}> signatures.`, "    [<AllowNullLiteral>]", `    type DeepImmutable${entry.name}${genericParameters} =`);
    for (const base of entry.bases) {
      const baseName = base.replace(/<.*$/, "").replace(/^.*\./, "");
      lines.push(`        inherit ${projectedNames.has(baseName) ? `DeepImmutable${base}` : base}`);
    }
    if (entry.members.length === 0 && entry.bases.length === 0) lines.push("        interface end");
    for (const member of entry.members) {
      if (member.kind === "property") {
        lines.push(`        abstract \`\`${member.name}\`\`: ${deepImmutableType(member.type)} with get`);
      } else if (member.kind === "callbackProperty") {
        lines.push(`        abstract \`\`${member.name}\`\`: ${member.helperName}${member.optional ? " option" : ""} with get`);
      } else if (member.kind === "indexer") {
        lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${deepImmutableType(member.valueType)} with get`);
      } else {
        lines.push(`        abstract \`\`${member.name}\`\`: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
      }
    }
  }
  for (const member of entry.members.filter(member => member.kind === "callbackProperty")) {
    const helperName = `${entry.name}${pascal(member.name)}Callback`;
    lines.push("", `    /// Function-valued ${entry.name}.${member.name} property.`, "    [<AllowNullLiteral>]", `    type ${helperName}${genericParameters} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
  }
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${entry.name}${genericParameters} =`);
  if (hasProjection) lines.push(`        inherit DeepImmutable${entry.name}${genericParameters}`);
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
    } else if (member.kind === "indexer") {
      lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`);
    } else {
      lines.push(`        abstract \`\`${member.name}\`\`: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
    }
  }
  if (partialProjectedNames.has(entry.name)) {
    const methodGroups = new Map();
    for (const member of entry.members.filter(member => member.kind === "method")) {
      const group = methodGroups.get(member.name) ?? [];
      group.push(member.callback);
      methodGroups.set(member.name, group);
    }
    for (const [name, callbacks] of methodGroups) {
      lines.push("", `    /// Function-valued ${entry.name}.${name} member used by Partial<${entry.name}>.`, "    [<AllowNullLiteral>]", `    type ${entry.name}${pascal(name)}PartialCallback${genericParameters} =`);
      for (const callback of callbacks) lines.push(`        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(callback)} -> ${callback.returnType}`);
    }
    lines.push("", `    /// Exact optional-property projection used by Babylon Partial<${entry.name}> signatures.`, "    [<AllowNullLiteral>]", `    type Partial${entry.name}${genericParameters} =`);
    for (const base of entry.bases) {
      const baseName = base.replace(/<.*$/, "").replace(/^.*\./, "");
      lines.push(`        inherit ${partialProjectedNames.has(baseName) ? `Partial${base}` : base}`);
    }
    if (entry.members.length === 0 && entry.bases.length === 0) lines.push("        interface end");
    for (const member of entry.members) {
      if (member.kind === "property") {
        lines.push(`        abstract \`\`${member.name}\`\`: ${asOption(member.type)} with get${member.readonly ? "" : ", set"}`);
      } else if (member.kind === "callbackProperty") {
        lines.push(`        abstract \`\`${member.name}\`\`: ${asOption(member.helperName)} with get${member.readonly ? "" : ", set"}`);
      } else if (member.kind === "indexer") {
        lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${asOption(member.valueType)} with get${member.readonly ? "" : ", set"}`);
      } else {
        lines.push(`        abstract \`\`${member.name}\`\`: ${entry.name}${pascal(member.name)}PartialCallback${genericParameters} option with get, set`);
      }
    }
  }
}
const proposal = `${lines.join("\n")}\n`;
const manifest = {
  schemaVersion: 1,
  source: { declarationLock: "declaration-lock.json", packageVersion: "9.19.0" },
  proposalSha256: sha256(proposal),
  exports: entries.flatMap(entry => entry.coverageEntries.map(coverage => ({
    package: coverage.package,
    module: coverage.module,
    name: coverage.name,
    kind: "interface",
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.SimpleInterfaces.${entry.name}`,
    ...(projectedNames.has(entry.name) ? { deepImmutableSymbol: `BabylonjsBindings.SimpleInterfaces.DeepImmutable${entry.name}` } : {}),
    ...(partialProjectedNames.has(entry.name) ? { partialSymbol: `BabylonjsBindings.SimpleInterfaces.Partial${entry.name}` } : {}),
    ...(entry.declaration.typeParameters?.length ? { typeParameterCount: entry.declaration.typeParameters.length } : {}),
    memberCount: entry.members.length
  })))
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
