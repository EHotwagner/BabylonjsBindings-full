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
const libDomPath = resolve(root, "node_modules/typescript/lib/lib.dom.d.ts");
const libDomProgram = ts.createProgram([libDomPath], { target: ts.ScriptTarget.ESNext, noLib: true });
const libDomChecker = libDomProgram.getTypeChecker();
const libDomSource = libDomProgram.getSourceFile(libDomPath);
const diagnose = process.argv.includes("--diagnose");
const bootstrapClasses = process.argv.includes("--bootstrap-classes");
const typeFailureCounts = new Map();
const typeFailuresByInterface = new Map();
let diagnosedInterface;
let collectTypeFailures = false;
const utilityInlineTypes = [];
const excludedEnumTypes = new Map();
const numericLiteralValues = new Set();
for (const value of [33776, 33777, 33778, 33779, 34046, 34047, 35916, 35917, 35918, 35919]) numericLiteralValues.add(value);
const stringLiteralTypes = new Map();
const gpuTextureFormats = [
  "r8unorm", "r8snorm", "r8uint", "r8sint", "r16unorm", "r16snorm", "r16uint", "r16sint", "r16float", "rg8unorm", "rg8snorm", "rg8uint", "rg8sint", "r32uint", "r32sint", "r32float", "rg16unorm", "rg16snorm", "rg16uint", "rg16sint", "rg16float", "rgba8unorm", "rgba8unorm-srgb", "rgba8snorm", "rgba8uint", "rgba8sint", "bgra8unorm", "bgra8unorm-srgb", "rgb9e5ufloat", "rgb10a2uint", "rgb10a2unorm", "rg11b10ufloat", "rg32uint", "rg32sint", "rg32float", "rgba16unorm", "rgba16snorm", "rgba16uint", "rgba16sint", "rgba16float", "rgba32uint", "rgba32sint", "rgba32float", "stencil8", "depth16unorm", "depth24plus", "depth24plus-stencil8", "depth32float", "depth32float-stencil8", "bc1-rgba-unorm", "bc1-rgba-unorm-srgb", "bc2-rgba-unorm", "bc2-rgba-unorm-srgb", "bc3-rgba-unorm", "bc3-rgba-unorm-srgb", "bc4-r-unorm", "bc4-r-snorm", "bc5-rg-unorm", "bc5-rg-snorm", "bc6h-rgb-ufloat", "bc6h-rgb-float", "bc7-rgba-unorm", "bc7-rgba-unorm-srgb", "etc2-rgb8unorm", "etc2-rgb8unorm-srgb", "etc2-rgb8a1unorm", "etc2-rgb8a1unorm-srgb", "etc2-rgba8unorm", "etc2-rgba8unorm-srgb", "eac-r11unorm", "eac-r11snorm", "eac-rg11unorm", "eac-rg11snorm", "astc-4x4-unorm", "astc-4x4-unorm-srgb", "astc-5x4-unorm", "astc-5x4-unorm-srgb", "astc-5x5-unorm", "astc-5x5-unorm-srgb", "astc-6x5-unorm", "astc-6x5-unorm-srgb", "astc-6x6-unorm", "astc-6x6-unorm-srgb", "astc-8x5-unorm", "astc-8x5-unorm-srgb", "astc-8x6-unorm", "astc-8x6-unorm-srgb", "astc-8x8-unorm", "astc-8x8-unorm-srgb", "astc-10x5-unorm", "astc-10x5-unorm-srgb", "astc-10x6-unorm", "astc-10x6-unorm-srgb", "astc-10x8-unorm", "astc-10x8-unorm-srgb", "astc-10x10-unorm", "astc-10x10-unorm-srgb", "astc-12x10-unorm", "astc-12x10-unorm-srgb", "astc-12x12-unorm", "astc-12x12-unorm-srgb"
];
const gpuFeatureNames = [
  "core-features-and-limits", "depth-clip-control", "depth32float-stencil8", "texture-compression-bc", "texture-compression-bc-sliced-3d", "texture-compression-etc2", "texture-compression-astc", "texture-compression-astc-sliced-3d", "timestamp-query", "indirect-first-instance", "shader-f16", "rg11b10ufloat-renderable", "bgra8unorm-storage", "float32-filterable", "float32-blendable", "clip-distances", "dual-source-blending", "subgroups", "texture-formats-tier1", "texture-formats-tier2", "primitive-index", "texture-component-swizzle", "subgroup-size-control"
];
const fsharpString = value => `"${value.replaceAll("\\", "\\\\").replaceAll("\"", "\\\"").replaceAll("\n", "\\n").replaceAll("\r", "\\r")}"`;
const stringLiteralType = value => {
  const name = `StringLiteral${createHash("sha256").update(value).digest("hex").slice(0, 12)}`;
  stringLiteralTypes.set(name, value);
  return name;
};
const mappedKeyNames = constraint => {
  if (ts.isTypeOperatorNode(constraint)
    && constraint.operator === ts.SyntaxKind.KeyOfKeyword
    && ts.isTypeReferenceNode(constraint.type)
    && ts.isIdentifier(constraint.type.typeName)) {
    const ambientName = constraint.type.typeName.text;
    const declaration = libDomSource?.statements.find(statement => ts.isInterfaceDeclaration(statement) && statement.name.text === ambientName);
    if (!declaration) return undefined;
    return libDomChecker.getPropertiesOfType(libDomChecker.getTypeAtLocation(declaration)).map(property => property.getName()).sort();
  }
  if (ts.isTypeReferenceNode(constraint) && ts.isIdentifier(constraint.typeName)) {
    let symbol = checker.getSymbolAtLocation(constraint.typeName);
    if (symbol?.flags & ts.SymbolFlags.Alias) {
      try { symbol = checker.getAliasedSymbol(symbol); } catch { return undefined; }
    }
    const declaration = symbol?.declarations?.find(ts.isTypeAliasDeclaration);
    const branches = declaration && ts.isUnionTypeNode(declaration.type) ? declaration.type.types : declaration ? [declaration.type] : [];
    const names = branches.map(branch => ts.isLiteralTypeNode(branch) && ts.isStringLiteral(branch.literal) ? branch.literal.text : undefined);
    return names.length > 0 && names.every(Boolean) ? names.sort() : undefined;
  }
  return undefined;
};
const numericLiteralType = value => {
  const numeric = Number(value);
  if (!Number.isSafeInteger(numeric) || numeric < -2147483648 || numeric > 2147483647) return undefined;
  numericLiteralValues.add(numeric);
  return `NumericLiteral${numeric < 0 ? `Negative${Math.abs(numeric)}` : numeric}`;
};
const excludedEnumType = node => {
  if (!ts.isTypeReferenceNode(node)
    || !ts.isIdentifier(node.typeName)
    || node.typeName.text !== "Exclude"
    || node.typeArguments?.length !== 2
    || !ts.isTypeReferenceNode(node.typeArguments[0])
    || !ts.isIdentifier(node.typeArguments[0].typeName)) return undefined;
  const baseName = node.typeArguments[0].typeName.text;
  let symbol = checker.getSymbolAtLocation(node.typeArguments[0].typeName);
  if (symbol?.flags & ts.SymbolFlags.Alias) {
    try { symbol = checker.getAliasedSymbol(symbol); } catch { return undefined; }
  }
  const declaration = symbol?.declarations?.find(ts.isEnumDeclaration);
  if (!declaration) return undefined;
  const excludedNodes = ts.isUnionTypeNode(node.typeArguments[1]) ? node.typeArguments[1].types : [node.typeArguments[1]];
  const excludedNames = new Set(excludedNodes.map(branch => ts.isTypeReferenceNode(branch) && ts.isQualifiedName(branch.typeName) ? branch.typeName.right.text : undefined).filter(Boolean));
  if (excludedNames.size !== excludedNodes.length) return undefined;
  const members = declaration.members.map(member => ({
    name: (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name)) ? member.name.text : undefined,
    value: checker.getConstantValue(member)
  })).filter(member => member.name && typeof member.value === "number" && !excludedNames.has(member.name));
  if (members.length + excludedNames.size !== declaration.members.length) return undefined;
  const name = `${baseName}Excluding${createHash("sha256").update([...excludedNames].sort().join("|")).digest("hex").slice(0, 10)}`;
  excludedEnumTypes.set(name, members);
  return name;
};
const recordTypeFailure = node => {
  if (!collectTypeFailures) return;
  const text = node.getText().replace(/\s+/g, " ");
  const key = `${ts.SyntaxKind[node.kind]}: ${text.length > 160 ? `${text.slice(0, 157)}...` : text}`;
  typeFailureCounts.set(key, (typeFailureCounts.get(key) ?? 0) + 1);
  if (diagnosedInterface) {
    const failures = typeFailuresByInterface.get(diagnosedInterface) ?? new Set();
    failures.add(key);
    typeFailuresByInterface.set(diagnosedInterface, failures);
  }
};
const deepImmutableInterfaceNames = new Set();
const partialInterfaceNames = new Set();
const requiredNonNullableInterfaceNames = new Set();
const requiredInterfaceNames = new Set();
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
    if (ts.isTypeReferenceNode(node)
      && ts.isIdentifier(node.typeName)
      && node.typeName.text === "Required"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && node.typeArguments[0].typeName.text === "NonNullableFields"
      && node.typeArguments[0].typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0].typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments[0].typeArguments?.length) {
      requiredNonNullableInterfaceNames.add(node.typeArguments[0].typeArguments[0].typeName.text);
    }
    if (ts.isTypeReferenceNode(node)
      && ts.isIdentifier(node.typeName)
      && node.typeName.text === "Required"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments?.length) {
      requiredInterfaceNames.add(node.typeArguments[0].typeName.text);
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
  .map(entry => [entry.name, {
    fsharpSymbol: entry.fsharpSymbol,
    deepImmutableSymbol: entry.deepImmutableSymbol,
    partialSymbol: entry.partialSymbol,
    requiredNonNullableSymbol: entry.requiredNonNullableSymbol,
    requiredSymbol: entry.requiredSymbol,
    arity: entry.typeParameterCount ?? 0
  }]));

// The maintained build compiles aliases, interfaces, and classes in one recursive
// namespace. A bootstrap pass can therefore expose exact class names to interface
// rendering long enough for the class generator to discover the reciprocal side
// of a closed dependency graph. A subsequent normal pass prunes every interface
// whose class dependency was not actually admitted by the class generator.
const rawBootstrapClassSymbols = new Map();
if (bootstrapClasses) {
  for (const sourceFile of program.getSourceFiles()) {
    const lockedPath = normalize(sourceFile.fileName);
    if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
    for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
      let target = exported;
      if (exported.flags & ts.SymbolFlags.Alias) {
        try { target = checker.getAliasedSymbol(exported); } catch { continue; }
      }
      const declarations = target.declarations?.filter(ts.isClassDeclaration) ?? [];
      if (declarations.length !== 1) continue;
      const declaration = declarations[0];
      const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
      const packageName = module.startsWith("@babylonjs/core/")
        ? "@babylonjs/core"
        : module.startsWith("@babylonjs/loaders/")
          ? "@babylonjs/loaders"
          : undefined;
      if (!packageName) continue;
      const name = exported.getName();
      rawBootstrapClassSymbols.set(`${packageName}|${module}|${name}`, {
        name,
        arity: declaration.typeParameters?.length ?? 0,
        ...(deepImmutableInterfaceNames.has(name) ? { deepImmutableSymbol: `BabylonjsBindings.SimpleClasses.DeepImmutable${name}` } : {})
      });
    }
  }
}
const bootstrapClassNameCounts = new Map();
for (const entry of rawBootstrapClassSymbols.values()) bootstrapClassNameCounts.set(entry.name, (bootstrapClassNameCounts.get(entry.name) ?? 0) + 1);
const bootstrapClassSymbols = new Map([...rawBootstrapClassSymbols.values()]
  .filter(entry => bootstrapClassNameCounts.get(entry.name) === 1 && !maintainedSymbols.has(entry.name))
  .map(entry => [entry.name, { fsharpSymbol: `BabylonjsBindings.SimpleClasses.${entry.name}`, deepImmutableSymbol: entry.deepImmutableSymbol, arity: entry.arity }]));

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
  if (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword) return "JavaScriptNull";
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
  if (ts.isMappedTypeNode(node)) {
    const keys = node.typeParameter.constraint ? mappedKeyNames(node.typeParameter.constraint) : undefined;
    const valueType = node.type ? fsharpType(node.type, available, dependencies, typeParameters) : undefined;
    if (keys?.length && valueType) {
      const digest = createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12);
      const name = `MappedObject${digest}`;
      if (!utilityInlineTypes.some(inline => inline.name === name)) {
        utilityInlineTypes.push({
          name,
          genericParameters: "",
          members: keys.map(key => ({ kind: "property", name: key, type: node.questionToken ? asOption(valueType) : valueType, readonly: Boolean(node.readonlyToken) }))
        });
      }
      return name;
    }
  }
  if (ts.isFunctionTypeNode(node)
    && !node.typeParameters?.length
    && !node.parameters.some(parameter => parameter.dotDotDotToken)) {
    const runtimeParameters = node.parameters.filter(parameter => !ts.isIdentifier(parameter.name) || parameter.name.text !== "this");
    const parameterTypes = runtimeParameters.map(parameter => {
      const rendered = parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined;
      return parameter.questionToken && rendered ? asOption(rendered) : rendered;
    });
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
    const excludedEnum = excludedEnumType(node);
    if (excludedEnum) return excludedEnum;
    if (node.typeName.text === "Immutable" && node.typeArguments?.length === 1) {
      const inner = node.typeArguments[0];
      if (ts.isTypeLiteralNode(inner)) {
        const digest = createHash("sha256").update(inner.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12);
        return inlineObjectType(inner, available, dependencies, typeParameters, utilityInlineTypes, `ImmutableObject${digest}`, true);
      }
      if (ts.isArrayTypeNode(inner)) {
        const element = fsharpType(inner.elementType, available, dependencies, typeParameters);
        return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
      }
      return fsharpType(inner, available, dependencies, typeParameters);
    }
    if (node.typeName.text === "DeepImmutable" && node.typeArguments?.length === 1) {
      const inner = node.typeArguments[0];
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && !inner.typeArguments?.length) {
        const name = inner.typeName.text;
        const target = available.get(name) ?? bootstrapClassSymbols.get(name) ?? maintainedSymbols.get(name);
        if (target?.deepImmutableSymbol) {
          if (available.has(name) || bootstrapClassSymbols.has(name)) dependencies.add(name);
          return target.deepImmutableSymbol;
        }
      }
      recordTypeFailure(node);
      return undefined;
    }
    if (node.typeName.text === "Partial" && node.typeArguments?.length === 1) {
      const inner = node.typeArguments[0];
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && inner.typeName.text === "XRSessionInit" && !inner.typeArguments?.length) {
        return "BrowserXRSessionInit";
      }
      if (ts.isTypeLiteralNode(inner)) {
        const digest = createHash("sha256").update(inner.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12);
        return inlineObjectType(inner, available, dependencies, typeParameters, utilityInlineTypes, `PartialObject${digest}`, false, true);
      }
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && !inner.typeArguments?.length) {
        const name = inner.typeName.text;
        const target = available.get(name) ?? maintainedSymbols.get(name);
        if (target?.partialSymbol) {
          if (available.has(name)) dependencies.add(name);
          return target.partialSymbol;
        }
      }
      recordTypeFailure(node);
      return undefined;
    }
    if (node.typeName.text === "Function" && !node.typeArguments?.length) return "System.Delegate";
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
    if (node.typeName.text === "ReadonlySet" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `BrowserReadonlySet<${inner}>` : undefined;
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
    const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "DataView", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    if (node.typeArguments?.length === 1
      && jsTypes.has(node.typeName.text)
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && ["ArrayBuffer", "ArrayBufferLike"].includes(node.typeArguments[0].typeName.text)
      && !node.typeArguments[0].typeArguments?.length) return `JS.${node.typeName.text}`;
    const browserTypes = new Set([
      "AudioContext", "AudioDestinationNode", "AudioNode", "Blob", "Element", "Event", "File", "GainNode", "HTMLElement", "HTMLCanvasElement", "HTMLDivElement", "HTMLImageElement", "HTMLVideoElement", "KeyboardEvent", "MediaStreamAudioDestinationNode",
      "ImageData", "OfflineAudioContext", "WebGLContextAttributes", "WebGLUniformLocation", "WebGL2RenderingContext", "WebGLRenderingContext",
      "WebGLProgram", "WebGLShader", "WebGLBuffer", "WebGLTexture", "WebGLFramebuffer", "WebGLRenderbuffer",
    ]);
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmapOptions") return "BrowserImageBitmapOptions";
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmap") return "BrowserImageBitmap";
    if (!node.typeArguments?.length && node.typeName.text === "WebXRRenderTarget" && available.has("WebXRRenderTarget")) {
      dependencies.add("WebXRRenderTarget");
      return "WebXRRenderTarget<Browser.Types.WebGLRenderingContext, BrowserXRWebGLLayer>";
    }
    const browserExtensionTypes = new Map([
      ["AudioContext", "BrowserAudioContext"],
      ["AudioDestinationNode", "BrowserAudioDestinationNode"],
      ["MediaStreamAudioDestinationNode", "BrowserMediaStreamAudioDestinationNode"],
      ["WEBGL_compressed_texture_s3tc", "BrowserWebGLCompressedTextureS3tc"],
      ["WEBGL_compressed_texture_s3tc_srgb", "BrowserWebGLCompressedTextureS3tcSrgb"],
      ["EXT_texture_filter_anisotropic", "BrowserExtTextureFilterAnisotropic"],
      ["EXT_disjoint_timer_query", "BrowserExtDisjointTimerQuery"],
      ["GPUBuffer", "BrowserGPUBuffer"],
      ["GPUDevice", "BrowserGPUDevice"],
      ["GPURenderPassEncoder", "BrowserGPURenderPassEncoder"],
      ["GPURenderPipeline", "BrowserGPURenderPipeline"],
      ["GPUQuerySet", "BrowserGPUQuerySet"],
      ["GPUCommandEncoder", "BrowserGPUCommandEncoder"],
      ["GPURenderBundle", "BrowserGPURenderBundle"],
      ["GPUTexture", "BrowserGPUTexture"],
      ["GPUSampler", "BrowserGPUSampler"],
      ["GPUBindGroup", "BrowserGPUBindGroup"],
      ["GPUBindGroupLayout", "BrowserGPUBindGroupLayout"],
      ["GPUPipelineLayout", "BrowserGPUPipelineLayout"],
      ["GPUShaderModule", "BrowserGPUShaderModule"],
      ["GPUComputePipeline", "BrowserGPUComputePipeline"],
      ["GPUCommandBuffer", "BrowserGPUCommandBuffer"],
      ["GPUTextureView", "BrowserGPUTextureView"],
      ["GPUAdapter", "BrowserGPUAdapter"],
      ["GPUCanvasContext", "BrowserGPUCanvasContext"],
      ["GPUExternalTexture", "BrowserGPUExternalTexture"],
      ["GPURenderBundleEncoder", "BrowserGPURenderBundleEncoder"],
      ["GPURenderPassDescriptor", "BrowserGPURenderPassDescriptor"],
      ["GPURenderPipelineDescriptor", "BrowserGPURenderPipelineDescriptor"],
      ["GPUProgrammableStage", "BrowserGPUProgrammableStage"],
      ["GPUBindGroupLayoutEntry", "BrowserGPUBindGroupLayoutEntry"],
      ["GPUBindGroupEntry", "BrowserGPUBindGroupEntry"],
      ["GPUComputePassDescriptor", "BrowserGPUComputePassDescriptor"],
      ["GPUTextureViewDescriptor", "BrowserGPUTextureViewDescriptor"],
      ["GPUDeviceDescriptor", "BrowserGPUDeviceDescriptor"],
      ["GPUTextureFormat", "BrowserGPUTextureFormat"],
      ["GPUFeatureName", "BrowserGPUFeatureName"],
      ["GPUCompareFunction", "BrowserGPUCompareFunction"],
      ["GPUStorageTextureAccess", "BrowserGPUStorageTextureAccess"],
      ["GPUTextureSampleType", "BrowserGPUTextureSampleType"],
      ["GPUSamplerBindingType", "BrowserGPUSamplerBindingType"],
      ["GPUTextureViewDimension", "BrowserGPUTextureViewDimension"],
      ["GPUSupportedLimits", "BrowserGPUSupportedLimits"],
      ["XRWebGLBinding", "BrowserXRWebGLBinding"],
      ["XRCompositionLayer", "BrowserXRCompositionLayer"],
      ["AudioBuffer", "BrowserAudioBuffer"],
      ["AudioNode", "BrowserAudioNode"],
      ["GainNode", "BrowserGainNode"],
      ["OfflineAudioContext", "BrowserOfflineAudioContext"],
      ["AudioBufferSourceNode", "BrowserAudioBufferSourceNode"],
      ["MediaTrackConstraints", "BrowserMediaTrackConstraints"],
      ["PointerEventInit", "BrowserPointerEventInit"],
      ["WebGLVertexArrayObject", "BrowserWebGLVertexArrayObject"],
      ["Worker", "BrowserWorker"],
      ["RegExp", "BrowserRegExp"],
      ["XMLHttpRequest", "BrowserXMLHttpRequest"],
      ["URL", "BrowserURL"],
      ["DOMRect", "BrowserDOMRect"],
      ["WebGLQuery", "BrowserWebGLQuery"]
      ,["WebGLContextEvent", "BrowserWebGLContextEvent"]
      ,["WebGL2RenderingContext", "BrowserWebGL2RenderingContext"]
      ,["XRLayer", "BrowserXRLayer"]
      ,["XRWebGLLayer", "BrowserXRWebGLLayer"]
      ,["XRWebGLLayerInit", "BrowserXRWebGLLayerInit"]
      ,["XRReferenceSpace", "BrowserXRReferenceSpace"]
      ,["XRFrame", "BrowserXRFrame"]
      ,["XRSession", "BrowserXRSession"]
      ,["XRViewerPose", "BrowserXRViewerPose"]
      ,["XRInputSource", "BrowserXRInputSource"]
      ,["XRPose", "BrowserXRPose"]
      ,["XRView", "BrowserXRView"]
      ,["XRSessionInit", "BrowserXRSessionInit"]
      ,["XRRenderState", "BrowserXRRenderState"]
      ,["XRRenderStateInit", "BrowserXRRenderStateInit"]
      ,["XRReferenceSpaceType", "BrowserXRReferenceSpaceType"]
      ,["XRSessionMode", "BrowserXRSessionMode"]
      ,["XREye", "BrowserXREye"]
      ,["GPUPowerPreference", "BrowserGPUPowerPreference"]
      ,["XMLHttpRequestBodyInit", "BrowserXMLHttpRequestBodyInit"]
    ]);
    if (!node.typeArguments?.length && browserExtensionTypes.has(node.typeName.text)) return browserExtensionTypes.get(node.typeName.text);
    if (!node.typeArguments?.length && node.typeName.text === "GPUBufferUsageFlags") return "float";
    if (!node.typeArguments?.length && browserTypes.has(node.typeName.text)) return `Browser.Types.${node.typeName.text}`;
    if (!node.typeArguments?.length && typeParameters.has(node.typeName.text)) return `'${node.typeName.text}`;
    if (!node.typeArguments?.length && node.typeName.text === "AcceptedRole") {
      let symbol = checker.getSymbolAtLocation(node.typeName);
      if (symbol?.flags & ts.SymbolFlags.Alias) {
        try { symbol = checker.getAliasedSymbol(symbol); } catch { return undefined; }
      }
      const declaration = symbol?.declarations?.find(ts.isTypeAliasDeclaration);
      if (declaration) return fsharpType(declaration.type, available, dependencies, typeParameters);
    }
    if (available.has(node.typeName.text)) {
      const target = available.get(node.typeName.text);
      const arguments_ = node.typeArguments ?? [];
      if (arguments_.length !== target.arity) return undefined;
      const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
      if (renderedArguments.some(argument => !argument)) return undefined;
      dependencies.add(node.typeName.text);
      return target.arity === 0 ? node.typeName.text : `${node.typeName.text}<${renderedArguments.join(", ")}>`;
    }
    if (bootstrapClassSymbols.has(node.typeName.text)) {
      const target = bootstrapClassSymbols.get(node.typeName.text);
      const arguments_ = node.typeArguments ?? [];
      if (arguments_.length !== target.arity) return undefined;
      const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
      if (renderedArguments.some(argument => !argument)) return undefined;
      dependencies.add(node.typeName.text);
      return target.arity === 0 ? target.fsharpSymbol : `${target.fsharpSymbol}<${renderedArguments.join(", ")}>`;
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
const inlineObjectType = (node, available, dependencies, typeParameters, inlineTypes, context, forceReadonly = false, forceOptional = false) => {
  if (!ts.isTypeLiteralNode(node)) return undefined;
  const name = `${context}Object`;
  const genericParameters = typeParameters.size ? `<${[...typeParameters].map(value => `'${value}`).join(", ")}>` : "";
  const members = [];
  for (const [memberIndex, member] of node.members.entries()) {
    if (ts.isPropertySignature(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      let type = fsharpType(member.type, available, dependencies, typeParameters);
      if (!type && ts.isTypeLiteralNode(member.type)) type = inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${name}Property${memberIndex + 1}`, forceReadonly, forceOptional);
      if (!type) return undefined;
      members.push({ kind: "property", name: member.name.text, type: member.questionToken || forceOptional ? asOption(type) : type, readonly: forceReadonly || (member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false) });
    } else if (ts.isIndexSignatureDeclaration(member) && member.parameters.length === 1 && member.parameters[0].type && member.type && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type, available, dependencies, typeParameters);
      let valueType = fsharpType(member.type, available, dependencies, typeParameters);
      if (!valueType && ts.isTypeLiteralNode(member.type)) valueType = inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${name}Value${memberIndex + 1}`, forceReadonly, forceOptional);
      if (!keyType || !valueType) return undefined;
      members.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: forceReadonly || (member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false) });
    } else {
      return undefined;
    }
  }
  inlineTypes.push({ name, genericParameters, members });
  return `${name}${genericParameters}`;
};
const callbackShape = (node, available, dependencies, typeParameters) => {
  const localTypeParameters = new Set(typeParameters);
  const constraints = [];
  for (const parameter of node.typeParameters ?? []) {
    localTypeParameters.add(parameter.name.text);
    if (!parameter.constraint) continue;
    if (!ts.isTypeReferenceNode(parameter.constraint)
      || !ts.isIdentifier(parameter.constraint.typeName)
      || parameter.constraint.typeArguments?.length) return undefined;
    const constraint = fsharpType(parameter.constraint, available, dependencies, localTypeParameters);
    if (!constraint) return undefined;
    constraints.push(`'${parameter.name.text} :> ${constraint}`);
  }
  if (node.parameters.some(parameter => parameter.dotDotDotToken)) return undefined;
  // A TypeScript `this` parameter only constrains the callback receiver at
  // compile time; it is not part of the JavaScript call argument list.
  const runtimeParameters = node.parameters.filter(parameter => !ts.isIdentifier(parameter.name) || parameter.name.text !== "this");
  const returnType = fsharpType(node.type, available, dependencies, localTypeParameters);
  const parameters = runtimeParameters.map(parameter => {
    const type = parameter.type ? fsharpType(parameter.type, available, dependencies, localTypeParameters) : undefined;
    return {
      name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
      type: parameter.questionToken && type ? asOptionalParameterType(type) : type,
      optional: Boolean(parameter.questionToken)
    };
  });
  const genericParameters = node.typeParameters?.length
    ? `<${node.typeParameters.map(parameter => `'${parameter.name.text}`).join(", ")}${constraints.length ? ` when ${constraints.join(" and ")}` : ""}>`
    : "";
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters, genericParameters } : undefined;
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
  const genericConstraints = [];
  for (const parameter of declaration.typeParameters ?? []) {
    if (!parameter.constraint) continue;
    const constraint = fsharpType(parameter.constraint, available, dependencies, typeParameters);
    if (!constraint) return undefined;
    genericConstraints.push(`'${parameter.name.text} :> ${constraint}`);
  }
  const members = [];
  const inlineTypes = [];
  const seenMemberTexts = new Set();
  for (const member of declaration.members) {
    const memberText = member.getText().replace(/\s+/g, " ");
    if (seenMemberTexts.has(memberText)) continue;
    seenMemberTexts.add(memberText);
    if ((ts.isPropertySignature(member) || ts.isMethodSignature(member)) && (!ts.isIdentifier(member.name) && !ts.isStringLiteral(member.name))) return undefined;
    if (ts.isPropertySignature(member) && member.type) {
      const callbackProperty = callbackPropertyType(member.type);
      if (callbackProperty) {
        const callback = callbackShape(callbackProperty.node, available, dependencies, typeParameters);
        if (!callback) {
          recordTypeFailure(member);
          return undefined;
        }
        members.push({ kind: "callbackProperty", name: member.name.text, optional: Boolean(member.questionToken) || callbackProperty.optional, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false, callback });
      } else {
        let type = fsharpType(member.type, available, dependencies, typeParameters);
        if (!type && ts.isTypeLiteralNode(member.type)) type = inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${declaration.name.text}Property${members.length + 1}`);
        if (!type) {
          recordTypeFailure(member);
          return undefined;
        }
        members.push({ kind: "property", name: member.name.text, type: member.questionToken ? asOption(type) : type, optionalProperty: Boolean(member.questionToken), readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
      }
    } else if (ts.isMethodSignature(member)) {
      if (member.questionToken) {
        const callback = callbackShape(member, available, dependencies, typeParameters);
        if (!callback) {
          recordTypeFailure(member);
          return undefined;
        }
        members.push({ kind: "callbackProperty", name: member.name.text, optional: true, readonly: false, callback });
        continue;
      }
      const callback = callbackShape(member, available, dependencies, typeParameters);
      if (!callback) {
        recordTypeFailure(member);
        return undefined;
      }
      members.push({ kind: "method", name: member.name.text, callback });
    } else if (ts.isIndexSignatureDeclaration(member)
      && member.parameters.length === 1
      && member.parameters[0].type
      && member.type
      && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type, available, dependencies, typeParameters);
      const valueType = fsharpType(member.type, available, dependencies, typeParameters);
      if (!keyType || !valueType) {
        recordTypeFailure(member);
        return undefined;
      }
      members.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else {
      recordTypeFailure(member);
      return undefined;
    }
  }
  return { members, inlineTypes, genericConstraints, dependencies: [...dependencies] };
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
      } else if (bootstrapClassSymbols.has(name)) {
        const target = bootstrapClassSymbols.get(name);
        const arguments_ = type.typeArguments ?? [];
        if (arguments_.length !== target.arity) return undefined;
        const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
        if (renderedArguments.some(argument => !argument)) return undefined;
        dependencies.add(name);
        bases.push(target.arity === 0 ? target.fsharpSymbol : `${target.fsharpSymbol}<${renderedArguments.join(", ")}>`);
      } else if (maintainedSymbols.has(name)) {
        const target = maintainedSymbols.get(name);
        const arguments_ = type.typeArguments ?? [];
        if (arguments_.length !== target.arity) return undefined;
        const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
        if (renderedArguments.some(argument => !argument)) return undefined;
        bases.push(target.arity === 0 ? target.fsharpSymbol : `${target.fsharpSymbol}<${renderedArguments.join(", ")}>`);
      } else if (name === "WebGLContextAttributes" && !type.typeArguments?.length) {
        bases.push("Browser.Types.WebGLContextAttributes");
      } else if (name === "GPURequestAdapterOptions" && !type.typeArguments?.length) {
        bases.push("BrowserGPURequestAdapterOptions");
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
  const module = lockedPath.replace(/\.d\.ts$/, "");
  const packageName = module.startsWith("@babylonjs/core/")
    ? "@babylonjs/core"
    : module.startsWith("@babylonjs/loaders/")
      ? "@babylonjs/loaders"
      : undefined;
  if (!packageName) continue;
  for (const declaration of sourceFile.statements.filter(ts.isInterfaceDeclaration)) {
    if (declaration.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ExportKeyword)) continue;
    const name = declaration.name.text;
    rawDeclarations.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, declaration, internalSupport: true });
  }
}

const declarations = new Map();
const declarationsByName = new Map();
// Distinct Babylon declarations can occasionally export the same simple name.
// Until the public binding has module-qualified collision namespaces, select
// only a reviewed declaration and leave the other export uncovered.
const preferredCollisionModules = new Map([
  ["IImage", "@babylonjs/core/Engines/ICanvas"]
]);
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
      coverageEntries: group.filter(([, entry]) => !entry.internalSupport).map(([, entry]) => ({ package: entry.package, module: entry.module, name: entry.name }))
    });
  } else {
    const preferredModule = preferredCollisionModules.get(group[0][1].name);
    const selectedGroup = preferredModule ? group.filter(([, entry]) => entry.module === preferredModule) : group;
    for (const [identity, entry] of selectedGroup) declarations.set(identity, { ...entry, coverageEntries: entry.internalSupport ? [] : [{ package: entry.package, module: entry.module, name: entry.name }] });
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
    available.set(entry.name, { arity: entry.declaration.typeParameters?.length ?? 0, ...(deepImmutableInterfaceNames.has(entry.name) ? { deepImmutableSymbol: `DeepImmutable${entry.name}` } : {}), ...(partialInterfaceNames.has(entry.name) ? { partialSymbol: `Partial${entry.name}` } : {}) });
  }
  rank += 1;
}
const recursiveOptimistic = new Map([...declarations.values()]
  .filter(entry => nameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { arity: entry.declaration.typeParameters?.length ?? 0, ...(deepImmutableInterfaceNames.has(entry.name) ? { deepImmutableSymbol: `DeepImmutable${entry.name}` } : {}), ...(partialInterfaceNames.has(entry.name) ? { partialSymbol: `Partial${entry.name}` } : {}) }]));
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
  const rejected = [...recursiveCandidates].filter(([, entry]) => entry.dependencies.some(dependency => !available.has(dependency) && !candidateNames.has(dependency) && !bootstrapClassSymbols.has(dependency)));
  if (rejected.length === 0) break;
  for (const [identity] of rejected) recursiveCandidates.delete(identity);
}
for (const [identity, entry] of recursiveCandidates) {
  selected.set(identity, entry);
  available.set(entry.name, { arity: entry.declaration.typeParameters?.length ?? 0, ...(deepImmutableInterfaceNames.has(entry.name) ? { deepImmutableSymbol: `DeepImmutable${entry.name}` } : {}), ...(partialInterfaceNames.has(entry.name) ? { partialSymbol: `Partial${entry.name}` } : {}) });
}
const entries = [...selected.values()].sort((left, right) => left.rank - right.rank || left.name.localeCompare(right.name));
if (diagnose) {
  const optimistic = new Map([...declarations.values()]
    .filter(entry => nameCounts.get(entry.name) === 1)
    .map(entry => [entry.name, { arity: entry.declaration.typeParameters?.length ?? 0, ...(deepImmutableInterfaceNames.has(entry.name) ? { deepImmutableSymbol: `DeepImmutable${entry.name}` } : {}), ...(partialInterfaceNames.has(entry.name) ? { partialSymbol: `Partial${entry.name}` } : {}) }]));
  let shapeReady = 0;
  const missingCounts = new Map();
  const missingByInterface = new Map();
  collectTypeFailures = true;
  for (const [identity, entry] of declarations) {
    if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
    diagnosedInterface = entry.name;
    const renderedMembers = renderMembers(entry.declaration, optimistic);
    const renderedHeritage = renderHeritage(entry.declaration, optimistic);
    if (renderedMembers && renderedHeritage) {
      shapeReady += 1;
      const missing = [...new Set([...renderedMembers.dependencies, ...renderedHeritage.dependencies].filter(dependency => !available.has(dependency)))];
      missingByInterface.set(entry.name, missing);
      for (const dependency of [...renderedMembers.dependencies, ...renderedHeritage.dependencies]) {
        if (!available.has(dependency)) missingCounts.set(dependency, (missingCounts.get(dependency) ?? 0) + 1);
      }
    }
  }
  diagnosedInterface = undefined;
  collectTypeFailures = false;
  console.log("top unresolved interface member types:");
  console.log([...typeFailureCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 80).map(([type, count]) => `${count} ${type}`).join("\n"));
  console.log(`diagnostic: ${shapeReady} additional interfaces have renderable shapes with unresolved dependencies`);
  console.log("top unresolved interface dependencies:");
  console.log([...missingCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 40).map(([name, count]) => `${name} ${count}`).join("\n"));
  console.log("failure types for foundational interface bridge targets:");
  console.log(["AbstractEngineOptions", "EngineOptions", "IAccessibilityTag", "IAudioEngineOptions", "IAudioBusOptions", "IAbstractSoundOptions", "IStaticSoundOptions", "IStreamingSoundOptions", "ICreateAndPreparePipelineContextOptions", "IInternalTextureLoader", "IImage", "IMeshDataOptions", "IParticleSystem", "IPipelineGenerationOptions", "IShadowGenerator", "ICollisionCoordinator", "IFlowGraphPendingActivation", "IAssetContainer", "IBakedVertexAnimationManager", "ICullable", "IPipelineContext", "IShaderProcessor", "EngineCapabilities", "WebXRRenderTarget", "IWebXRFeature", "WebGPUEngineOptions", "ITransmissionHelperMaterialImpl"]
    .map(name => {
      const identities = [...declarations].filter(([, entry]) => entry.name === name).map(([identity]) => identity);
      const state = `declarations=${identities.length}, selected=${identities.filter(identity => selected.has(identity)).length}, recursive=${identities.filter(identity => recursiveCandidates.has(identity)).length}, missing=${(missingByInterface.get(name) ?? []).join(",") || "none"}`;
      return `${name} (${state}): ${[...(typeFailuresByInterface.get(name) ?? [])].slice(0, 12).join(" | ") || "renderable or dependency-only"}`;
    })
    .join("\n"));
}
const projectedNames = new Set(entries.filter(entry => deepImmutableInterfaceNames.has(entry.name)).map(entry => entry.name));
const entryByName = new Map(entries.map(entry => [entry.name, entry]));
const partialProjectedNames = new Set(entries.filter(entry => partialInterfaceNames.has(entry.name)).map(entry => entry.name));
const requiredNonNullableProjectedNames = new Set(entries.filter(entry => requiredNonNullableInterfaceNames.has(entry.name)).map(entry => entry.name));
const requiredProjectedNames = new Set(entries.filter(entry => requiredInterfaceNames.has(entry.name)).map(entry => entry.name));
while (true) {
  const additions = [...partialProjectedNames].flatMap(name => entryByName.get(name)?.bases ?? [])
    .map(base => base.replace(/<.*$/, "").replace(/^.*\./, ""))
    .filter(name => entryByName.has(name) && !partialProjectedNames.has(name));
  if (additions.length === 0) break;
  for (const name of additions) partialProjectedNames.add(name);
}
while (true) {
  const additions = [...requiredProjectedNames].flatMap(name => entryByName.get(name)?.bases ?? [])
    .map(base => base.replace(/<.*$/, "").replace(/^.*\./, ""))
    .filter(name => entryByName.has(name) && !requiredProjectedNames.has(name));
  if (additions.length === 0) break;
  for (const name of additions) requiredProjectedNames.add(name);
}
while (true) {
  const additions = [...requiredNonNullableProjectedNames].flatMap(name => entryByName.get(name)?.bases ?? [])
    .map(base => base.replace(/<.*$/, "").replace(/^.*\./, ""))
    .filter(name => entryByName.has(name) && !requiredNonNullableProjectedNames.has(name));
  if (additions.length === 0) break;
  for (const name of additions) requiredNonNullableProjectedNames.add(name);
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
lines.push("", "    /// Distinct ambient OffscreenCanvas handle used by ImageBitmapSource.", "    [<AllowNullLiteral>]", "    type BrowserOffscreenCanvas =", "        interface end");
lines.push("", "    /// Distinct ambient VideoFrame handle used by ImageBitmapSource.", "    [<AllowNullLiteral>]", "    type BrowserVideoFrame =", "        interface end");
lines.push("", "    /// Distinct ambient SVGImageElement handle used by ImageBitmapSource.", "    [<AllowNullLiteral>]", "    type BrowserSVGImageElement =", "        interface end");
lines.push("", "    /// Exact standard ImageBitmapSource union accepted by Babylon engine APIs.", "    type BrowserImageBitmapSource = U9<Browser.Types.HTMLImageElement, BrowserSVGImageElement, Browser.Types.HTMLVideoElement, Browser.Types.HTMLCanvasElement, BrowserImageBitmap, BrowserOffscreenCanvas, BrowserVideoFrame, Browser.Types.Blob, Browser.Types.ImageData>");
lines.push("", "    /// Distinct ambient WebGL2 rendering-context handle.", "    [<AllowNullLiteral>]", "    type BrowserWebGL2RenderingContext =", "        interface end");
lines.push("", "    /// Distinct ambient WebAudio context handle.", "    [<AllowNullLiteral>]", "    type BrowserAudioContext =", "        interface end");
lines.push("", "    /// Distinct ambient WebAudio destination-node handle.", "    [<AllowNullLiteral>]", "    type BrowserAudioDestinationNode =", "        interface end");
lines.push("", "    /// Distinct ambient media-stream audio destination-node handle.", "    [<AllowNullLiteral>]", "    type BrowserMediaStreamAudioDestinationNode =", "        interface end");
lines.push("", "    /// Distinct ambient Fetch Response handle.", "    [<AllowNullLiteral>]", "    type BrowserResponse =", "        interface end");
lines.push("", "    /// Distinct ambient Fetch BodyInit value handle.", "    [<AllowNullLiteral>]", "    type BrowserBodyInit =", "        interface end");
lines.push("", "    /// Distinct ambient MediaStream handle.", "    [<AllowNullLiteral>]", "    type BrowserMediaStream =", "        interface end");
lines.push("", "    /// Distinct ambient AbortSignal handle.", "    [<AllowNullLiteral>]", "    type BrowserAbortSignal =", "        interface end");
lines.push("", "    /// Ambient XMLHttpRequest handle used by Babylon request modifiers.", "    [<AllowNullLiteral>]", "    type BrowserXMLHttpRequest =", "        abstract setRequestHeader: name: string * value: string -> unit");
lines.push("", "    /// Distinct ambient URL handle.", "    [<AllowNullLiteral>]", "    type BrowserURL =", "        interface end");
lines.push("", "    /// Exact structural DOMRect surface.", "    [<AllowNullLiteral>]", "    type BrowserDOMRect =", "        abstract x: float with get, set", "        abstract y: float with get, set", "        abstract width: float with get, set", "        abstract height: float with get, set", "        abstract top: float with get", "        abstract right: float with get", "        abstract bottom: float with get", "        abstract left: float with get", "        abstract toJSON: unit -> obj");
lines.push("", "    /// Distinct ambient FormData handle.", "    [<AllowNullLiteral>]", "    type BrowserFormData =", "        interface end");
lines.push("", "    /// Distinct ambient URLSearchParams handle.", "    [<AllowNullLiteral>]", "    type BrowserURLSearchParams =", "        interface end");
lines.push("", "    /// Exact XMLHttpRequest request-body union.", "    type BrowserXMLHttpRequestBodyInit = U6<Browser.Types.Blob, JS.ArrayBufferView, JS.ArrayBuffer, BrowserFormData, BrowserURLSearchParams, string>");
lines.push("", "    /// Exact DOM event-listener options surface.", "    [<AllowNullLiteral>]", "    type BrowserEventListenerOptions =", "        abstract capture: bool option with get, set");
lines.push("", "    /// Exact DOM add-event-listener options surface.", "    [<AllowNullLiteral>]", "    type BrowserAddEventListenerOptions =", "        inherit BrowserEventListenerOptions", "        abstract once: bool option with get, set", "        abstract passive: bool option with get, set", "        abstract signal: BrowserAbortSignal option with get, set");
lines.push("", "    /// Distinct ambient WebXR reference-space handle.", "    [<AllowNullLiteral>]", "    type BrowserXRReferenceSpace =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR frame handle.", "    [<AllowNullLiteral>]", "    type BrowserXRFrame =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR session handle.", "    [<AllowNullLiteral>]", "    type BrowserXRSession =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR viewer-pose handle.", "    [<AllowNullLiteral>]", "    type BrowserXRViewerPose =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR input-source handle.", "    [<AllowNullLiteral>]", "    type BrowserXRInputSource =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR pose handle.", "    [<AllowNullLiteral>]", "    type BrowserXRPose =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR view handle.", "    [<AllowNullLiteral>]", "    type BrowserXRView =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR layer handle.", "    [<AllowNullLiteral>]", "    type BrowserXRLayer =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR WebGL-layer handle.", "    [<AllowNullLiteral>]", "    type BrowserXRWebGLLayer =", "        inherit BrowserXRLayer");
lines.push("", "    /// Distinct ambient WebXR WebGL-layer initialization surface.", "    [<AllowNullLiteral>]", "    type BrowserXRWebGLLayerInit =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR session initialization surface.", "    [<AllowNullLiteral>]", "    type BrowserXRSessionInit =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR render-state surface.", "    [<AllowNullLiteral>]", "    type BrowserXRRenderState =", "        interface end");
lines.push("", "    /// Distinct ambient WebXR render-state initialization surface.", "    [<AllowNullLiteral>]", "    type BrowserXRRenderStateInit =", "        interface end");
lines.push("", "    /// Exact WebXR reference-space literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserXRReferenceSpaceType =", "        | [<CompiledName(\"viewer\")>] Viewer", "        | [<CompiledName(\"local\")>] Local", "        | [<CompiledName(\"local-floor\")>] LocalFloor", "        | [<CompiledName(\"bounded-floor\")>] BoundedFloor", "        | [<CompiledName(\"unbounded\")>] Unbounded");
lines.push("", "    /// Exact WebXR session-mode literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserXRSessionMode =", "        | [<CompiledName(\"inline\")>] Inline", "        | [<CompiledName(\"immersive-ar\")>] ImmersiveAr", "        | [<CompiledName(\"immersive-vr\")>] ImmersiveVr");
lines.push("", "    /// Exact WebXR eye literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserXREye =", "        | [<CompiledName(\"left\")>] Left", "        | [<CompiledName(\"none\")>] None", "        | [<CompiledName(\"right\")>] Right");
lines.push("", "    /// Exact WebGPU power-preference literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserGPUPowerPreference =", "        | [<CompiledName(\"high-performance\")>] HighPerformance", "        | [<CompiledName(\"low-power\")>] LowPower");
lines.push("", "    /// Exact XMLHttpRequest response-type literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserXMLHttpRequestResponseType =", "        | [<CompiledName(\"\")>] Default", "        | [<CompiledName(\"arraybuffer\")>] ArrayBuffer", "        | [<CompiledName(\"blob\")>] Blob", "        | [<CompiledName(\"document\")>] Document", "        | [<CompiledName(\"json\")>] Json", "        | [<CompiledName(\"text\")>] Text");
lines.push("", "    /// Exact browser image color-space conversion literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserColorSpaceConversion =", "        | [<CompiledName(\"default\")>] Default", "        | [<CompiledName(\"none\")>] None");
lines.push("", "    /// Exact browser image orientation literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserImageOrientation =", "        | [<CompiledName(\"flipY\")>] FlipY", "        | [<CompiledName(\"from-image\")>] FromImage", "        | [<CompiledName(\"none\")>] None");
lines.push("", "    /// Exact browser premultiplied-alpha literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserPremultiplyAlpha =", "        | [<CompiledName(\"default\")>] Default", "        | [<CompiledName(\"none\")>] None", "        | [<CompiledName(\"premultiply\")>] Premultiply");
lines.push("", "    /// Exact browser bitmap resize-quality literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserResizeQuality =", "        | [<CompiledName(\"high\")>] High", "        | [<CompiledName(\"low\")>] Low", "        | [<CompiledName(\"medium\")>] Medium", "        | [<CompiledName(\"pixelated\")>] Pixelated");
lines.push("", "    /// Exact structural browser ImageBitmapOptions surface.", "    [<AllowNullLiteral>]", "    type BrowserImageBitmapOptions =", "        abstract colorSpaceConversion: BrowserColorSpaceConversion option with get, set", "        abstract imageOrientation: BrowserImageOrientation option with get, set", "        abstract premultiplyAlpha: BrowserPremultiplyAlpha option with get, set", "        abstract resizeHeight: float option with get, set", "        abstract resizeQuality: BrowserResizeQuality option with get, set", "        abstract resizeWidth: float option with get, set");
lines.push("", "    /// Structural non-primitive JavaScript object surface used by TypeScript `object` declarations.", "    [<AllowNullLiteral>]", "    type JavaScriptObject =", "        interface end");
lines.push("", "    /// Exact structural ECMAScript iterator surface used by readonly sets.", "    [<AllowNullLiteral>]", "    type BrowserIterator<'T> =", "        abstract next: ?value: obj -> JS.IteratorResult<'T>", "        [<Emit(\"$0[Symbol.iterator]()\")>] abstract GetIterator: unit -> BrowserIterator<'T>");
lines.push("", "    /// Yield branch returned by an ECMAScript generator.", "    [<AllowNullLiteral>]", "    type BrowserGeneratorYieldResult<'T> =", "        abstract ``done``: bool option with get", "        abstract value: 'T with get");
lines.push("", "    /// Completion branch returned by an ECMAScript generator.", "    [<AllowNullLiteral>]", "    type BrowserGeneratorReturnResult<'T> =", "        abstract ``done``: bool with get", "        abstract value: 'T with get");
lines.push("", "    /// Exact yield-or-return result of an ECMAScript generator.", "    type BrowserGeneratorResult<'TYield, 'TReturn> = U2<BrowserGeneratorYieldResult<'TYield>, BrowserGeneratorReturnResult<'TReturn>>");
lines.push("", "    /// Exact synchronous ECMAScript Generator surface used by Babylon declarations.", "    [<AllowNullLiteral>]", "    type BrowserGenerator<'TYield, 'TReturn, 'TNext> =", "        abstract next: ?value: 'TNext -> BrowserGeneratorResult<'TYield, 'TReturn>", "        [<Emit(\"$0.return($1)\")>] abstract ``return``: ?value: 'TReturn -> BrowserGeneratorResult<'TYield, 'TReturn>", "        [<Emit(\"$0.throw($1)\")>] abstract ``throw``: ?error: obj -> BrowserGeneratorResult<'TYield, 'TReturn>", "        [<Emit(\"$0[Symbol.iterator]()\")>] abstract GetIterator: unit -> BrowserGenerator<'TYield, 'TReturn, 'TNext>");
lines.push("", "    /// Exact readonly ECMAScript Set surface used by Babylon declarations.", "    [<AllowNullLiteral>]", "    type BrowserReadonlySet<'T> =", "        abstract size: float with get", "        abstract has: value: 'T -> bool", "        abstract forEach: callbackfn: System.Action<'T, 'T, BrowserReadonlySet<'T>> * ?thisArg: obj -> unit", "        abstract entries: unit -> BrowserIterator<'T * 'T>", "        abstract keys: unit -> BrowserIterator<'T>", "        abstract values: unit -> BrowserIterator<'T>", "        [<Emit(\"$0[Symbol.iterator]()\")>] abstract GetIterator: unit -> BrowserIterator<'T>");
for (const value of [...numericLiteralValues].sort((left, right) => left - right)) {
  const name = `NumericLiteral${value < 0 ? `Negative${Math.abs(value)}` : value}`;
  lines.push("", `    /// Exact numeric literal type for ${value}.`, `    type ${name} =`, `        | Value = ${value}`);
}
for (const [name, members] of [...excludedEnumTypes].sort(([left], [right]) => left.localeCompare(right))) {
  lines.push("", "    /// Exact numeric enum subset projected from a TypeScript Exclude utility.", `    type ${name} =`);
  for (const member of members) lines.push(`        | ${member.name} = ${member.value}`);
}
lines.push("", "    /// Exact opaque WebGLQuery handle.", "    [<AllowNullLiteral>]", "    type BrowserWebGLQuery =", "        interface end");
lines.push("", "    /// Exact WebGL context-event extension surface.", "    [<AllowNullLiteral>]", "    type BrowserWebGLContextEvent =", "        inherit Browser.Types.Event", "        abstract statusMessage: string with get");
lines.push("", "    /// Distinct opaque handle for the ambient JavaScript RegExp API.", "    [<AllowNullLiteral>]", "    type BrowserRegExp =", "        interface end");
lines.push("", "    /// Exact nominal type for a required JavaScript null literal.", "    [<AllowNullLiteral>]", "    type JavaScriptNull =", "        interface end");
lines.push("", "    /// Erased, owner-typed JavaScript property key.", "    [<Erase>]", "    type JavaScriptKeyOf<'TOwner> =", "        | JavaScriptKeyOf of string");
for (const [name, value] of [["BrowserPointerInputSource", "pointer"], ["BrowserWheelInputSource", "wheel"], ["BrowserTouchInputSource", "touch"], ["BrowserKeyboardInputSource", "keyboard"]]) {
  lines.push("", `    /// Exact ${value} input-source discriminator.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, `        | [<CompiledName(${fsharpString(value)})>] Value`);
}
lines.push("", "    /// Exact modifier state shared by Babylon input-map entries.", "    [<AllowNullLiteral>]", "    type BrowserInputModifiers =", "        abstract ctrl: bool option with get, set", "        abstract shift: bool option with get, set", "        abstract alt: bool option with get, set");
lines.push("", "    /// Exact pointer input-map entry.", "    [<AllowNullLiteral>]", "    type BrowserPointerInputMapEntry<'TInteraction> =", "        abstract source: BrowserPointerInputSource with get, set", "        abstract interaction: 'TInteraction with get, set", "        abstract sensitivity: float option with get, set", "        abstract sensitivityX: float option with get, set", "        abstract sensitivityY: float option with get, set", "        abstract button: float option with get, set", "        abstract modifiers: BrowserInputModifiers option with get, set");
lines.push("", "    /// Exact wheel input-map entry.", "    [<AllowNullLiteral>]", "    type BrowserWheelInputMapEntry<'TInteraction> =", "        abstract source: BrowserWheelInputSource with get, set", "        abstract interaction: 'TInteraction with get, set", "        abstract sensitivity: float option with get, set", "        abstract modifiers: BrowserInputModifiers option with get, set");
lines.push("", "    /// Exact touch input-map entry.", "    [<AllowNullLiteral>]", "    type BrowserTouchInputMapEntry<'TInteraction> =", "        abstract source: BrowserTouchInputSource with get, set", "        abstract interaction: 'TInteraction with get, set", "        abstract sensitivity: float option with get, set", "        abstract sensitivityX: float option with get, set", "        abstract sensitivityY: float option with get, set", "        abstract touchCount: float option with get, set");
lines.push("", "    /// Exact keyboard input-map entry.", "    [<AllowNullLiteral>]", "    type BrowserKeyboardInputMapEntry<'TInteraction> =", "        abstract source: BrowserKeyboardInputSource with get, set", "        abstract interaction: 'TInteraction with get, set", "        abstract sensitivity: float option with get, set", "        abstract key: U2<float, ResizeArray<float>> option with get, set", "        abstract modifiers: BrowserInputModifiers option with get, set");
lines.push("", "    /// Exact discriminated union of Babylon input-map entries.", "    type BrowserInputMapEntry<'TInteraction> = U4<BrowserPointerInputMapEntry<'TInteraction>, BrowserWheelInputMapEntry<'TInteraction>, BrowserTouchInputMapEntry<'TInteraction>, BrowserKeyboardInputMapEntry<'TInteraction>>");
lines.push("", "    /// Exact GPUBuffer map-state literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserGPUBufferMapState =", "        | [<CompiledName(\"mapped\")>] Mapped", "        | [<CompiledName(\"pending\")>] Pending", "        | [<CompiledName(\"unmapped\")>] Unmapped");
lines.push("", "    /// Exact WebGPU comparison-function literals.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserGPUCompareFunction =", ...["never", "less", "equal", "less-equal", "greater", "not-equal", "greater-equal", "always"].map(value => `        | [<CompiledName(${fsharpString(value)})>] ${value.split("-").map(part => `${part[0].toUpperCase()}${part.slice(1)}`).join("")}`));
for (const [name, description, values] of [
  ["BrowserGPUStorageTextureAccess", "storage-texture access", ["write-only", "read-only", "read-write"]],
  ["BrowserGPUTextureSampleType", "texture sample type", ["float", "unfilterable-float", "depth", "sint", "uint"]],
  ["BrowserGPUSamplerBindingType", "sampler binding type", ["filtering", "non-filtering", "comparison"]],
  ["BrowserGPUTextureViewDimension", "texture-view dimension", ["1d", "2d", "2d-array", "cube", "cube-array", "3d"]]
]) lines.push("", `    /// Exact WebGPU ${description} literals.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, ...values.map(value => `        | [<CompiledName(${fsharpString(value)})>] ${value.split(/[^A-Za-z0-9]+/).map(part => `${/^[0-9]/.test(part) ? "D" : ""}${part[0].toUpperCase()}${part.slice(1)}`).join("")}`));
lines.push("", "    /// Exact WebGPU GPUBuffer instance surface used by Babylon declarations.", "    [<AllowNullLiteral>]", "    type BrowserGPUBuffer =", "        abstract label: string with get, set", "        abstract size: float with get", "        abstract usage: float with get", "        abstract mapState: BrowserGPUBufferMapState with get", "        abstract mapAsync: mode: float * ?offset: float * ?size: float -> JS.Promise<unit>", "        abstract getMappedRange: ?offset: float * ?size: float -> JS.ArrayBuffer", "        abstract unmap: unit -> unit", "        abstract destroy: unit -> unit");
for (const [name, description] of [["BrowserGPUDevice", "WebGPU device"], ["BrowserGPURenderPassEncoder", "WebGPU render-pass encoder"], ["BrowserGPURenderPipeline", "WebGPU render pipeline"], ["BrowserGPUQuerySet", "WebGPU query set"], ["BrowserGPUCommandEncoder", "WebGPU command encoder"], ["BrowserGPURenderBundle", "WebGPU render bundle"], ["BrowserGPUTexture", "WebGPU texture"], ["BrowserGPUSampler", "WebGPU sampler"], ["BrowserGPUBindGroup", "WebGPU bind group"], ["BrowserGPUPipelineLayout", "WebGPU pipeline layout"], ["BrowserGPUBindGroupLayout", "WebGPU bind-group layout"], ["BrowserGPUShaderModule", "WebGPU shader module"], ["BrowserGPUComputePipeline", "WebGPU compute pipeline"], ["BrowserGPUCommandBuffer", "WebGPU command buffer"], ["BrowserGPUTextureView", "WebGPU texture view"], ["BrowserGPUAdapter", "WebGPU adapter"], ["BrowserGPUCanvasContext", "WebGPU canvas context"], ["BrowserGPUExternalTexture", "WebGPU external texture"], ["BrowserGPURenderBundleEncoder", "WebGPU render-bundle encoder"], ["BrowserGPURenderPassDescriptor", "WebGPU render-pass descriptor"], ["BrowserGPURenderPipelineDescriptor", "WebGPU render-pipeline descriptor"], ["BrowserGPUProgrammableStage", "WebGPU programmable-stage descriptor"], ["BrowserGPUBindGroupLayoutEntry", "WebGPU bind-group-layout entry"], ["BrowserGPUBindGroupEntry", "WebGPU bind-group entry"], ["BrowserGPUComputePassDescriptor", "WebGPU compute-pass descriptor"], ["BrowserGPUTextureViewDescriptor", "WebGPU texture-view descriptor"], ["BrowserXRWebGLBinding", "WebXR WebGL binding"], ["BrowserXRCompositionLayer", "WebXR composition-layer"], ["BrowserAudioBuffer", "Web Audio buffer"], ["BrowserAudioNode", "Web Audio node"], ["BrowserGainNode", "Web Audio gain node"], ["BrowserOfflineAudioContext", "offline Web Audio context"], ["BrowserAudioBufferSourceNode", "Web Audio buffer-source node"], ["BrowserMediaTrackConstraints", "media-track constraints"], ["BrowserPointerEventInit", "pointer-event initializer"], ["BrowserWebGLVertexArrayObject", "WebGL vertex-array object"], ["BrowserWorker", "Web Worker"]]) {
  lines.push("", `    /// Distinct ambient ${description} handle.`, "    [<AllowNullLiteral>]", `    type ${name} =`, "        interface end");
}
lines.push("", "    /// Distinct ambient WebGPU device-descriptor surface.", "    [<AllowNullLiteral>]", "    type BrowserGPUDeviceDescriptor =", "        interface end");
lines.push("", "    /// Exact WebGPU adapter-request options surface.", "    [<AllowNullLiteral>]", "    type BrowserGPURequestAdapterOptions =", "        abstract featureLevel: string option with get, set", "        abstract powerPreference: BrowserGPUPowerPreference option with get, set", "        abstract forceFallbackAdapter: bool option with get, set", "        abstract xrCompatible: bool option with get, set");
lines.push("", "    /// Exact indexed WebGPU supported-limits surface exposed by Babylon's declaration augmentation.", "    [<AllowNullLiteral>]", "    type BrowserGPUSupportedLimits =", "        [<EmitIndexer>] abstract Item: name: string -> float with get");
lines.push("", "    /// Exact GPUTextureFormat literals from the WebGPU specification.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserGPUTextureFormat =", ...gpuTextureFormats.map(value => `        | [<CompiledName(${fsharpString(value)})>] ${value.split(/[^A-Za-z0-9]+/).map(part => `${part[0].toUpperCase()}${part.slice(1)}`).join("")}`));
lines.push("", "    /// Exact GPUFeatureName literals from the WebGPU specification.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserGPUFeatureName =", ...gpuFeatureNames.map(value => `        | [<CompiledName(${fsharpString(value)})>] ${value.split(/[^A-Za-z0-9]+/).map(part => `${part[0].toUpperCase()}${part.slice(1)}`).join("")}`));
lines.push("", "    /// Exact WEBGL_compressed_texture_s3tc extension surface.", "    [<AllowNullLiteral>]", "    type BrowserWebGLCompressedTextureS3tc =", "        abstract COMPRESSED_RGB_S3TC_DXT1_EXT: NumericLiteral33776 with get", "        abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: NumericLiteral33777 with get", "        abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: NumericLiteral33778 with get", "        abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: NumericLiteral33779 with get");
lines.push("", "    /// Exact WEBGL_compressed_texture_s3tc_srgb extension surface.", "    [<AllowNullLiteral>]", "    type BrowserWebGLCompressedTextureS3tcSrgb =", "        abstract COMPRESSED_SRGB_S3TC_DXT1_EXT: NumericLiteral35916 with get", "        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT: NumericLiteral35917 with get", "        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT: NumericLiteral35918 with get", "        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT: NumericLiteral35919 with get");
lines.push("", "    /// Exact EXT_texture_filter_anisotropic extension surface.", "    [<AllowNullLiteral>]", "    type BrowserExtTextureFilterAnisotropic =", "        abstract TEXTURE_MAX_ANISOTROPY_EXT: NumericLiteral34046 with get", "        abstract MAX_TEXTURE_MAX_ANISOTROPY_EXT: NumericLiteral34047 with get");
lines.push("", "    /// Exact Babylon EXT_disjoint_timer_query extension surface.", "    [<AllowNullLiteral>]", "    type BrowserExtDisjointTimerQuery =", "        abstract QUERY_COUNTER_BITS_EXT: float with get, set", "        abstract TIME_ELAPSED_EXT: float with get, set", "        abstract TIMESTAMP_EXT: float with get, set", "        abstract GPU_DISJOINT_EXT: float with get, set", "        abstract QUERY_RESULT_EXT: float with get, set", "        abstract QUERY_RESULT_AVAILABLE_EXT: float with get, set", "        abstract queryCounterEXT: query: BrowserWebGLQuery * target: float -> unit", "        abstract createQueryEXT: unit -> BrowserWebGLQuery", "        abstract beginQueryEXT: target: float * query: BrowserWebGLQuery -> unit", "        abstract endQueryEXT: target: float -> unit", "        abstract getQueryObjectEXT: query: BrowserWebGLQuery * target: float -> obj", "        abstract deleteQueryEXT: query: BrowserWebGLQuery -> unit");
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
  const genericParameterNames = entry.declaration.typeParameters?.map(parameter => `'${parameter.name.text}`) ?? [];
  const genericArguments = genericParameterNames.length ? `<${genericParameterNames.join(", ")}>` : "";
  const genericParameters = genericParameterNames.length
    ? `<${genericParameterNames.join(", ")}${entry.genericConstraints.length ? ` when ${entry.genericConstraints.join(" and ")}` : ""}>`
    : "";
  for (const inline of entry.inlineTypes) {
    if (emittedInlineTypeNames.has(inline.name)) continue;
    emittedInlineTypeNames.add(inline.name);
    lines.push("", `    /// Inline object shape used by ${entry.name}.`, "    [<AllowNullLiteral>]", `    type ${inline.name}${inline.genericParameters} =`);
    if (inline.members.length === 0) lines.push("        interface end");
    else for (const member of inline.members) lines.push(`        ${renderInlineMember(member)}`);
  }
  for (const member of entry.members.filter(member => member.kind === "callbackProperty")) {
    member.helperName = `${entry.name}${pascal(member.name)}Callback${genericArguments}`;
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
        lines.push(`        abstract \`\`${member.name}\`\`${member.callback.genericParameters}: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
      }
    }
  }
  for (const member of entry.members.filter(member => member.kind === "callbackProperty")) {
    const helperName = `${entry.name}${pascal(member.name)}Callback`;
    lines.push("", `    /// Function-valued ${entry.name}.${member.name} property.`, "    [<AllowNullLiteral>]", `    type ${helperName}${genericParameters} =`, `        [<Emit("$0($1...)")>] abstract Invoke${member.callback.genericParameters}: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
  }
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${entry.name}${genericParameters} =`);
  if (hasProjection) lines.push(`        inherit DeepImmutable${entry.name}${genericArguments}`);
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
      lines.push(`        abstract \`\`${member.name}\`\`${member.callback.genericParameters}: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
    }
  }
  if (requiredNonNullableProjectedNames.has(entry.name)) {
    lines.push("", `    /// Exact required non-null projection used by Required<NonNullableFields<${entry.name}>> signatures.`, "    [<AllowNullLiteral>]", `    type RequiredNonNullable${entry.name}${genericParameters} =`);
    for (const base of entry.bases) {
      const baseName = base.replace(/<.*$/, "").replace(/^.*\./, "");
      lines.push(`        inherit ${requiredNonNullableProjectedNames.has(baseName) ? `RequiredNonNullable${base}` : base}`);
    }
    if (entry.members.length === 0 && entry.bases.length === 0) lines.push("        interface end");
    for (const member of entry.members) {
      if (member.kind === "property") lines.push(`        abstract \`\`${member.name}\`\`: ${member.type.endsWith(" option") ? member.type.slice(0, -" option".length) : member.type} with get${member.readonly ? "" : ", set"}`);
      else if (member.kind === "callbackProperty") lines.push(`        abstract \`\`${member.name}\`\`: ${member.helperName} with get${member.readonly ? "" : ", set"}`);
      else if (member.kind === "indexer") lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType.endsWith(" option") ? member.valueType.slice(0, -" option".length) : member.valueType} with get${member.readonly ? "" : ", set"}`);
      else lines.push(`        abstract \`\`${member.name}\`\`${member.callback.genericParameters}: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
    }
  }
  if (requiredProjectedNames.has(entry.name)) {
    lines.push("", `    /// Exact required-property projection used by Required<${entry.name}> signatures.`, "    [<AllowNullLiteral>]", `    type Required${entry.name}${genericParameters} =`);
    for (const base of entry.bases) {
      const baseName = base.replace(/<.*$/, "").replace(/^.*\./, "");
      lines.push(`        inherit ${requiredProjectedNames.has(baseName) ? `Required${base}` : base}`);
    }
    if (entry.members.length === 0 && entry.bases.length === 0) lines.push("        interface end");
    for (const member of entry.members) {
      if (member.kind === "property") lines.push(`        abstract \`\`${member.name}\`\`: ${member.optionalProperty && member.type.endsWith(" option") ? member.type.slice(0, -" option".length) : member.type} with get${member.readonly ? "" : ", set"}`);
      else if (member.kind === "callbackProperty") lines.push(`        abstract \`\`${member.name}\`\`: ${member.helperName} with get${member.readonly ? "" : ", set"}`);
      else if (member.kind === "indexer") lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`);
      else lines.push(`        abstract \`\`${member.name}\`\`${member.callback.genericParameters}: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
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
      for (const callback of callbacks) lines.push(`        [<Emit("$0($1...)")>] abstract Invoke${callback.genericParameters}: ${callbackArguments(callback)} -> ${callback.returnType}`);
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
        lines.push(`        abstract \`\`${member.name}\`\`: ${entry.name}${pascal(member.name)}PartialCallback${genericArguments} option with get, set`);
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
    ...(requiredNonNullableProjectedNames.has(entry.name) ? { requiredNonNullableSymbol: `BabylonjsBindings.SimpleInterfaces.RequiredNonNullable${entry.name}` } : {}),
    ...(requiredProjectedNames.has(entry.name) ? { requiredSymbol: `BabylonjsBindings.SimpleInterfaces.Required${entry.name}` } : {}),
    ...(entry.declaration.typeParameters?.length ? { typeParameterCount: entry.declaration.typeParameters.length } : {}),
    memberCount: entry.members.length
  }))),
  supportTypes: entries.filter(entry => entry.internalSupport).map(entry => ({
    package: entry.package,
    module: entry.module,
    name: entry.name,
    kind: "interface-support",
    fsharpSymbol: `BabylonjsBindings.SimpleInterfaces.${entry.name}`,
    ...(projectedNames.has(entry.name) ? { deepImmutableSymbol: `BabylonjsBindings.SimpleInterfaces.DeepImmutable${entry.name}` } : {}),
    ...(partialProjectedNames.has(entry.name) ? { partialSymbol: `BabylonjsBindings.SimpleInterfaces.Partial${entry.name}` } : {}),
    ...(requiredNonNullableProjectedNames.has(entry.name) ? { requiredNonNullableSymbol: `BabylonjsBindings.SimpleInterfaces.RequiredNonNullable${entry.name}` } : {}),
    ...(requiredProjectedNames.has(entry.name) ? { requiredSymbol: `BabylonjsBindings.SimpleInterfaces.Required${entry.name}` } : {}),
    ...(entry.declaration.typeParameters?.length ? { typeParameterCount: entry.declaration.typeParameters.length } : {}),
    memberCount: entry.members.length
  }))
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
console.log(`generated reviewed-promotion proposal for ${manifest.exports.length} exact dependency-closed interfaces plus ${manifest.supportTypes.length} internal support types (${sha256(proposal)})`);
