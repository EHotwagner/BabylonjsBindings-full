import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { relative, resolve, sep } from "node:path";
import ts from "typescript";
import { loadPromotionSymbolIndex, referencedPromotionSymbols } from "./promotion-dependencies.mjs";

const root = resolve(import.meta.dirname, "..");
const nodeModules = resolve(root, "node_modules");
const check = process.argv.includes("--check");
const diagnose = process.argv.includes("--diagnose");
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
const deepImmutableTypeNames = new Set();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath)) continue;
  const visit = (node, ownerName) => {
    const currentOwner = ts.isClassDeclaration(node) && node.name ? node.name.text : ownerName;
    if (ts.isTypeReferenceNode(node)
      && ts.isIdentifier(node.typeName)
      && node.typeName.text === "DeepImmutable"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments?.length) {
      deepImmutableTypeNames.add(node.typeArguments[0].typeName.text);
    }
    if (currentOwner
      && ts.isTypeReferenceNode(node)
      && ts.isIdentifier(node.typeName)
      && node.typeName.text === "DeepImmutable"
      && node.typeArguments?.length === 1
      && node.typeArguments[0].kind === ts.SyntaxKind.ThisType) {
      deepImmutableTypeNames.add(currentOwner);
    }
    ts.forEachChild(node, child => visit(child, currentOwner));
  };
  visit(sourceFile, undefined);
}
const typeFailureCounts = new Map();
const typeFailuresByClass = new Map();
let collectTypeFailures = false;
let diagnosedClass;
const recordTypeFailure = node => {
  if (!collectTypeFailures) return;
  const text = node.getText().replace(/\s+/g, " ");
  const key = `${ts.SyntaxKind[node.kind]}: ${text.length > 160 ? `${text.slice(0, 157)}...` : text}`;
  typeFailureCounts.set(key, (typeFailureCounts.get(key) ?? 0) + 1);
  if (diagnosedClass) {
    const failures = typeFailuresByClass.get(diagnosedClass) ?? new Set();
    failures.add(key);
    typeFailuresByClass.set(diagnosedClass, failures);
  }
};

const dependencyManifestPaths = [
  "src/BabylonjsBindings/coverage-manifest.json",
  "src/BabylonjsBindings/string-coverage-manifest.json",
  "src/BabylonjsBindings/object-type-coverage-manifest.json",
  "generated-candidates/SimpleAliases.promotion.json",
  "generated-candidates/SimpleInterfaces.promotion.json"
];
const dependencyExports = (await Promise.all(dependencyManifestPaths.map(async path => JSON.parse(await readFile(resolve(root, path), "utf8")))))
  .flatMap(manifest => [...manifest.exports, ...(manifest.supportTypes ?? [])]);
const dependencyNameCounts = new Map();
for (const entry of dependencyExports) dependencyNameCounts.set(entry.name, (dependencyNameCounts.get(entry.name) ?? 0) + 1);
const maintainedSymbols = new Map(dependencyExports
  .filter(entry => dependencyNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { fsharpSymbol: entry.fsharpSymbol, deepImmutableSymbol: entry.deepImmutableSymbol, partialSymbol: entry.partialSymbol, requiredNonNullableSymbol: entry.requiredNonNullableSymbol, requiredSymbol: entry.requiredSymbol, arity: entry.typeParameterCount ?? 0 }]));
const maintainedClassExports = JSON.parse(await readFile(resolve(root, "src/BabylonjsBindings/simple-class-coverage-manifest.json"), "utf8")).exports;
const maintainedClassNameCounts = new Map();
for (const entry of maintainedClassExports) maintainedClassNameCounts.set(entry.name, (maintainedClassNameCounts.get(entry.name) ?? 0) + 1);
const maintainedClassProjections = new Map(maintainedClassExports
  .filter(entry => maintainedClassNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, entry]));

const hasModifier = (node, kind) => node.modifiers?.some(modifier => modifier.kind === kind) ?? false;
const inaccessible = node => hasModifier(node, ts.SyntaxKind.PrivateKeyword) || hasModifier(node, ts.SyntaxKind.ProtectedKeyword);
const isAbsentType = node => node.kind === ts.SyntaxKind.UndefinedKeyword
  || (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword);
const asOption = type => type.endsWith(" option") ? type : `${type} option`;
const asOptionalParameterType = type => type.endsWith(" option") ? type.slice(0, -" option".length) : type;
const erasedUnionType = branches => {
  if (branches.length < 2) return branches[0];
  if (branches.length <= 9) return `U${branches.length}<${branches.join(", ")}>`;
  return `U2<${erasedUnionType(branches.slice(0, 8))}, ${erasedUnionType(branches.slice(8))}>`;
};
const numericLiteralValues = new Set();
const stringLiteralTypes = new Map();
const utilityInlineTypes = [];
const utilityConstructorTypes = [];
const internalEnumTypes = new Map();
const resolvingInternalAliases = new Set();
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
const enumMemberUnionType = node => {
  if (!ts.isUnionTypeNode(node) || node.types.length < 2) return undefined;
  const references = node.types.map(branch => ts.isTypeReferenceNode(branch) && ts.isQualifiedName(branch.typeName) ? branch.typeName : undefined);
  if (references.some(reference => !reference)) return undefined;
  const enumName = references[0].left.getText();
  if (!references.every(reference => reference.left.getText() === enumName)) return undefined;
  let symbol = checker.getSymbolAtLocation(references[0].left);
  if (symbol?.flags & ts.SymbolFlags.Alias) {
    try { symbol = checker.getAliasedSymbol(symbol); } catch { return undefined; }
  }
  const declaration = symbol?.declarations?.find(ts.isEnumDeclaration);
  if (!declaration) return undefined;
  const selectedNames = new Set(references.map(reference => reference.right.text));
  const members = declaration.members
    .filter(member => (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name)) && selectedNames.has(member.name.text))
    .map(member => ({ name: member.name.text, value: checker.getConstantValue(member) }));
  if (members.length !== selectedNames.size || !members.every(member => typeof member.value === "number")) return undefined;
  const name = `${enumName.replace(/[^A-Za-z0-9_]/g, "")}Subset${createHash("sha256").update([...selectedNames].sort().join("|")).digest("hex").slice(0, 8)}`;
  internalEnumTypes.set(name, members);
  return name;
};
const fsharpType = (node, available, dependencies = new Set(), typeParameters = new Set()) => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.UndefinedKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.NeverKeyword) return "Never";
  if (node.kind === ts.SyntaxKind.ObjectKeyword) return "BabylonjsBindings.SimpleInterfaces.JavaScriptObject";
  if (node.kind === ts.SyntaxKind.SymbolKeyword) return "BabylonjsBindings.SimpleInterfaces.BrowserSymbol";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isLiteralTypeNode(node) && ts.isNumericLiteral(node.literal)) return numericLiteralType(node.literal.text);
  if (ts.isLiteralTypeNode(node) && ts.isStringLiteral(node.literal)) return stringLiteralType(node.literal.text);
  if (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword) return "BabylonjsBindings.SimpleInterfaces.JavaScriptNull";
  if (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.TrueKeyword) return "BabylonjsBindings.SimpleInterfaces.BrowserTrue";
  if (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.FalseKeyword) return "BabylonjsBindings.SimpleInterfaces.BrowserFalse";
  if (ts.isTypePredicateNode(node)) return "bool";
  if (node.kind === ts.SyntaxKind.ThisType && typeParameters.ownerName) return typeParameters.ownerName;
  if (ts.isParenthesizedTypeNode(node)) return fsharpType(node.type, available, dependencies, typeParameters);
  const restrictedEnum = enumMemberUnionType(node);
  if (restrictedEnum) return restrictedEnum;
  if (ts.isTypeOperatorNode(node) && node.operator === ts.SyntaxKind.ReadonlyKeyword) {
    if (ts.isArrayTypeNode(node.type)) {
      const element = fsharpType(node.type.elementType, available, dependencies, typeParameters);
      return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
    }
    return fsharpType(node.type, available, dependencies, typeParameters);
  }
  if (ts.isTypeOperatorNode(node)
    && node.operator === ts.SyntaxKind.KeyOfKeyword
    && ts.isTypeReferenceNode(node.type)
    && ts.isIdentifier(node.type.typeName)
    && typeParameters.has(node.type.typeName.text)) return `BabylonjsBindings.SimpleInterfaces.JavaScriptKeyOf<'${node.type.typeName.text}>`;
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
  if (ts.isTupleTypeNode(node) && node.elements.length === 0) return "ResizeArray<Never>";
  if (ts.isTupleTypeNode(node) && node.elements.length >= 1) {
    const elements = node.elements.map(element => ts.isNamedTupleMember(element) && !element.questionToken && !element.dotDotDotToken ? fsharpType(element.type, available, dependencies, typeParameters) : !ts.isNamedTupleMember(element) ? fsharpType(element, available, dependencies, typeParameters) : undefined);
    return elements.every(Boolean) ? node.elements.length === 1 ? `ReadonlyTuple1<${elements[0]}>` : `(${elements.join(" * ")})` : undefined;
  }
  if (ts.isMappedTypeNode(node) && node.typeParameter.constraint && node.type) {
    const keyType = fsharpType(node.typeParameter.constraint, available, dependencies, typeParameters);
    const valueType = fsharpType(node.type, available, dependencies, typeParameters);
    if (keyType && valueType) {
      const name = `MappedObject${createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12)}`;
      if (!utilityInlineTypes.some(inline => inline.name === name)) {
        utilityInlineTypes.push({ name, genericParameters: "", members: [{ kind: "indexer", name: "key", keyType, valueType: node.questionToken ? asOption(valueType) : valueType, readonly: false }] });
      }
      return name;
    }
  }
  if (ts.isConstructorTypeNode(node)
    && !node.typeParameters?.length
    && node.parameters.length === 1
    && node.parameters[0].dotDotDotToken
    && node.parameters[0].type
    && ts.isArrayTypeNode(node.parameters[0].type)
    && node.parameters[0].type.elementType.kind === ts.SyntaxKind.AnyKeyword) {
    const instanceType = fsharpType(node.type, available, dependencies, typeParameters);
    return instanceType ? `Constructor<${instanceType}>` : undefined;
  }
  if (ts.isConstructorTypeNode(node) && !node.parameters.some(parameter => parameter.dotDotDotToken)) {
    const renderedParameters = node.parameters.map(parameter => {
      const rendered = parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined;
      return {
        name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
        type: parameter.questionToken && rendered ? asOptionalParameterType(rendered) : rendered,
        optional: Boolean(parameter.questionToken)
      };
    });
    const returnType = fsharpType(node.type, available, dependencies, typeParameters);
    if (returnType && renderedParameters.every(parameter => parameter.name && parameter.type)) {
      const name = `TypedConstructor${createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12)}`;
      const genericParameters = typeParameters.size ? `<${[...typeParameters].map(value => `'${value}`).join(", ")}>` : "";
      if (!utilityConstructorTypes.some(type => type.name === name)) utilityConstructorTypes.push({ name, genericParameters, parameters: renderedParameters, returnType });
      return `${name}${genericParameters}`;
    }
  }
  if (ts.isImportTypeNode(node)
    && node.qualifier
    && ts.isIdentifier(node.qualifier)
    && node.qualifier.text === "DeepImmutableObject"
    && node.typeArguments?.length === 1) {
    const inner = node.typeArguments[0];
    if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && !inner.typeArguments?.length) {
      const name = inner.typeName.text;
      const target = available.get(name) ?? maintainedSymbols.get(name);
      if (target?.deepImmutableSymbol) {
        if (available.has(name)) dependencies.add(name);
        return target.deepImmutableSymbol;
      }
    }
  }
  if (ts.isImportTypeNode(node)
    && node.qualifier
    && ts.isIdentifier(node.qualifier)) {
    const name = node.qualifier.text;
    const target = available.get(name) ?? maintainedSymbols.get(name);
    const arguments_ = node.typeArguments ?? [];
    if (target && arguments_.length === target.arity) {
      const renderedArguments = arguments_.map(argument => fsharpType(argument, available, dependencies, typeParameters));
      if (renderedArguments.every(Boolean)) {
        if (available.has(name)) dependencies.add(name);
        const symbol = available.has(name) ? name : target.fsharpSymbol;
        return target.arity === 0 ? symbol : `${symbol}<${renderedArguments.join(", ")}>`;
      }
    }
  }
  if (ts.isTypeQueryNode(node) && ts.isQualifiedName(node.exprName)) {
    if (ts.isIdentifier(node.exprName.left) && node.exprName.left.text === "WebGL2RenderingContext") {
      const values = new Map([["SRGB", 0x8C40], ["SRGB8", 0x8C41], ["SRGB8_ALPHA8", 0x8C43]]);
      if (values.has(node.exprName.right.text)) return numericLiteralType(values.get(node.exprName.right.text));
    }
    let symbol = checker.getSymbolAtLocation(node.exprName.right);
    if (symbol?.flags & ts.SymbolFlags.Alias) {
      try { symbol = checker.getAliasedSymbol(symbol); } catch { symbol = undefined; }
    }
    const method = symbol?.declarations?.find(ts.isMethodDeclaration);
    if (method?.type && !method.typeParameters?.length && !method.parameters.some(parameter => parameter.dotDotDotToken)) {
      const parameterTypes = method.parameters.map(parameter => {
        const rendered = parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined;
        return parameter.questionToken && rendered ? asOption(rendered) : rendered;
      });
      const returnType = fsharpType(method.type, available, dependencies, typeParameters);
      if (returnType && parameterTypes.every(Boolean)) {
        return returnType === "unit"
          ? parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`
          : `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
      }
    }
    recordTypeFailure(node);
    return undefined;
  }
  if (ts.isTypeQueryNode(node) && ts.isIdentifier(node.exprName)) {
    const target = available.get(node.exprName.text) ?? maintainedSymbols.get(node.exprName.text);
    if (target?.staticSymbol) {
      if (available.has(node.exprName.text)) dependencies.add(node.exprName.text);
      return target.staticSymbol;
    }
    let symbol = checker.getSymbolAtLocation(node.exprName);
    if (symbol?.flags & ts.SymbolFlags.Alias) {
      try { symbol = checker.getAliasedSymbol(symbol); } catch { return undefined; }
    }
    const aliases = symbol?.declarations?.filter(ts.isTypeAliasDeclaration) ?? [];
    if (aliases.length === 1) return fsharpType(aliases[0].type, available, dependencies, typeParameters);
    const declarations = symbol?.declarations?.filter(declaration => ts.isFunctionDeclaration(declaration)
      || ts.isMethodDeclaration(declaration)
      || ts.isMethodSignature(declaration)) ?? [];
    if (declarations.length !== 1) return undefined;
    const callable = declarations[0];
    if (!callable.type
      || callable.typeParameters?.length
      || callable.parameters.some(parameter => parameter.dotDotDotToken || (ts.isIdentifier(parameter.name) && parameter.name.text === "this"))) return undefined;
    const parameterTypes = callable.parameters.map(parameter => {
      const rendered = parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined;
      return parameter.questionToken && rendered ? asOption(rendered) : rendered;
    });
    const returnType = fsharpType(callable.type, available, dependencies, typeParameters);
    if (!returnType || parameterTypes.some(parameter => !parameter)) return undefined;
    if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
    return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
  }
  if (ts.isIndexedAccessTypeNode(node)
    && ts.isTypeReferenceNode(node.objectType)
    && ts.isIdentifier(node.objectType.typeName)
    && node.objectType.typeName.text === "EXT_sRGB"
    && ts.isLiteralTypeNode(node.indexType)
    && ts.isStringLiteral(node.indexType.literal)
    && node.indexType.literal.text === "SRGB_ALPHA_EXT") return numericLiteralType(0x8C42);
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
  if (ts.isTypeLiteralNode(node) && node.members.length === 1 && ts.isCallSignatureDeclaration(node.members[0])) {
    const callback = directCallbackShape(node.members[0], available, dependencies, typeParameters);
    return callback ? directDelegateType(callback) : undefined;
  }
  if (ts.isTypeLiteralNode(node)) {
    const digest = createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12);
    return inlineObjectType(node, available, dependencies, typeParameters, utilityInlineTypes, `InlineObject${digest}`);
  }
  if (ts.isIntersectionTypeNode(node)) {
    return intersectionObjectType(node, available, dependencies, typeParameters, utilityInlineTypes);
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (!node.typeArguments?.length && node.typeName.text === "ReferrerPolicy") return "BabylonjsBindings.SimpleInterfaces.BrowserReferrerPolicy";
    if (!node.typeArguments?.length && node.typeName.text === "IArguments") return "BabylonjsBindings.SimpleInterfaces.BrowserArguments";
    if (node.typeName.text === "IObjectAccessor" && (node.typeArguments?.length ?? 0) < 3) {
      const target = available.get("IObjectAccessor") ?? maintainedSymbols.get("IObjectAccessor");
      if (target) {
        const rendered = (node.typeArguments ?? []).map(argument => fsharpType(argument, available, dependencies, typeParameters));
        if (rendered.some(argument => !argument)) return undefined;
        if (available.has("IObjectAccessor")) dependencies.add("IObjectAccessor");
        return `${available.has("IObjectAccessor") ? "IObjectAccessor" : target.fsharpSymbol}<${[...rendered, ...Array.from({ length: 3 - rendered.length }, () => "obj")].join(", ")}>`;
      }
    }
    if (node.typeName.text === "IObjectInfo" && node.typeArguments?.length === 1) {
      const target = available.get("IObjectInfo") ?? maintainedSymbols.get("IObjectInfo");
      const rendered = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      if (target && rendered) {
        if (available.has("IObjectInfo")) dependencies.add("IObjectInfo");
        return `${available.has("IObjectInfo") ? "IObjectInfo" : target.fsharpSymbol}<${rendered}, obj>`;
      }
    }
    if (!node.typeArguments?.length && node.typeName.text === "SerializableContext") return "BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext";
    if (!node.typeArguments?.length && node.typeName.text === "DecoratorMetadataObject") return "BabylonjsBindings.SimpleInterfaces.BrowserDecoratorMetadataObject";
    if (!node.typeArguments?.length && node.typeName.text === "Function") return "System.Delegate";
    if (node.typeName.text === "InteractionName"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && typeParameters.has(node.typeArguments[0].typeName.text)) return `BabylonjsBindings.SimpleInterfaces.JavaScriptKeyOf<'${node.typeArguments[0].typeName.text}>`;
    if (node.typeName.text === "InputMapEntry" && node.typeArguments?.length === 1) {
      const interaction = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return interaction ? `BabylonjsBindings.SimpleInterfaces.BrowserInputMapEntry<${interaction}>` : undefined;
    }
    if (node.typeName.text === "InterpolatingBehavior" && !node.typeArguments?.length && available.has("InterpolatingBehavior") && available.has("Camera")) {
      dependencies.add("InterpolatingBehavior");
      dependencies.add("Camera");
      return "InterpolatingBehavior<Camera>";
    }
    if (!node.typeArguments?.length && new Set(["GLenum", "GLbitfield", "GLint", "GLsizei", "GLintptr", "GLsizeiptr", "GLuint", "GLfloat", "GLclampf"]).has(node.typeName.text)) return "float";
    if (!node.typeArguments?.length && node.typeName.text === "GLboolean") return "bool";
    if (node.typeName.text === "Record" && node.typeArguments?.length === 2) {
      const keyType = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      const valueType = fsharpType(node.typeArguments[1], available, dependencies, typeParameters);
      if (!keyType || !valueType) return undefined;
      const name = `RecordObject${createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12)}`;
      if (!utilityInlineTypes.some(inline => inline.name === name)) {
        utilityInlineTypes.push({ name, genericParameters: "", members: [{ kind: "indexer", name: "key", keyType, valueType, readonly: false }] });
      }
      return name;
    }
    if (node.typeName.text === "Required"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && node.typeArguments[0].typeName.text === "NonNullableFields"
      && node.typeArguments[0].typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0].typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments[0].typeArguments?.length) {
      return maintainedSymbols.get(node.typeArguments[0].typeArguments[0].typeName.text)?.requiredNonNullableSymbol;
    }
    if (node.typeName.text === "Required"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments?.length) {
      return maintainedSymbols.get(node.typeArguments[0].typeName.text)?.requiredSymbol;
    }
    if (node.typeName.text === "Immutable" && node.typeArguments?.length === 1) {
      const inner = node.typeArguments[0];
      if (ts.isArrayTypeNode(inner)) {
        const element = fsharpType(inner.elementType, available, dependencies, typeParameters);
        return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
      }
      if (ts.isTypeReferenceNode(inner)
        && ts.isIdentifier(inner.typeName)
        && inner.typeName.text === "Array"
        && inner.typeArguments?.length === 1) {
        const element = fsharpType(inner.typeArguments[0], available, dependencies, typeParameters);
        return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
      }
      return fsharpType(inner, available, dependencies, typeParameters);
    }
    if (node.typeName.text === "Partial"
      && node.typeArguments?.length === 1) {
      const inner = node.typeArguments[0];
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && inner.typeName.text === "XRSessionInit" && !inner.typeArguments?.length) {
        return "BabylonjsBindings.SimpleInterfaces.BrowserXRSessionInit";
      }
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && inner.typeName.text === "XRProjectionLayerInit" && !inner.typeArguments?.length) {
        return "BabylonjsBindings.SimpleInterfaces.BrowserXRProjectionLayerInit";
      }
      if (ts.isTypeReferenceNode(inner)
        && ts.isIdentifier(inner.typeName)
        && inner.typeName.text === "Record"
        && inner.typeArguments?.length === 2) {
        const key = fsharpType(inner.typeArguments[0], available, dependencies, typeParameters);
        const value = fsharpType(inner.typeArguments[1], available, dependencies, typeParameters);
        return key && value ? `BabylonjsBindings.SimpleInterfaces.BrowserRecord<${key}, ${asOption(value)}>` : undefined;
      }
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && !inner.typeArguments?.length) {
        const partial = maintainedSymbols.get(inner.typeName.text)?.partialSymbol
          ?? maintainedClassProjections.get(inner.typeName.text)?.partialSymbol;
        if (partial) return partial;
      }
      if (ts.isTypeLiteralNode(inner)) {
        const digest = createHash("sha256").update(inner.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12);
        const partial = inlineObjectType(inner, available, dependencies, typeParameters, utilityInlineTypes, `PartialObject${digest}`, true);
        if (partial) return partial;
      }
      recordTypeFailure(node);
      return undefined;
    }
    if (node.typeName.text === "DeepImmutable" && node.typeArguments?.length === 1) {
      const inner = node.typeArguments[0];
      if (ts.isTypeReferenceNode(inner)
        && ts.isIdentifier(inner.typeName)
        && !inner.typeArguments?.length
        && typeParameters.deepImmutableSymbols?.has(inner.typeName.text)) {
        return typeParameters.deepImmutableSymbols.get(inner.typeName.text);
      }
      if (inner.kind === ts.SyntaxKind.ThisType && typeParameters.ownerName) {
        const owner = available.get(typeParameters.ownerName);
        if (owner?.deepImmutableSymbol) return owner.deepImmutableSymbol;
      }
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && !inner.typeArguments?.length) {
        const name = inner.typeName.text;
        const candidate = available.get(name);
        if (candidate?.deepImmutableSymbol) {
          dependencies.add(name);
          return candidate.deepImmutableSymbol;
        }
        const maintained = maintainedSymbols.get(name)?.deepImmutableSymbol;
        if (maintained) return maintained;
        const typedArrays = new Set(["BigInt64Array", "BigUint64Array", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
        if (typedArrays.has(name)) return `JS.${name}`;
      }
      if (ts.isArrayTypeNode(inner)) {
        let element;
        if (ts.isTypeReferenceNode(inner.elementType) && ts.isIdentifier(inner.elementType.typeName) && !inner.elementType.typeArguments?.length) {
          const name = inner.elementType.typeName.text;
          const candidate = available.get(name);
          if (candidate?.deepImmutableSymbol) {
            dependencies.add(name);
            element = candidate.deepImmutableSymbol;
          } else element = maintainedSymbols.get(name)?.deepImmutableSymbol;
        }
        element ??= fsharpType(inner.elementType, available, dependencies, typeParameters);
        if (element) return `System.Collections.Generic.IReadOnlyList<${element}>`;
      }
      if (ts.isTypeReferenceNode(inner)
        && ts.isIdentifier(inner.typeName)
        && ["Array", "ArrayLike", "ReadonlyArray"].includes(inner.typeName.text)
        && inner.typeArguments?.length === 1) {
        const element = fsharpType(inner.typeArguments[0], available, dependencies, typeParameters);
        if (element) return `System.Collections.Generic.IReadOnlyList<${element}>`;
      }
      if (ts.isUnionTypeNode(inner) && inner.types.length >= 2) {
        const branches = inner.types.map(branch => {
          if (ts.isArrayTypeNode(branch)) {
            const element = fsharpType(branch.elementType, available, dependencies, typeParameters);
            return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
          }
          if (ts.isTypeReferenceNode(branch) && ts.isIdentifier(branch.typeName) && !branch.typeArguments?.length) {
            const typedArrays = new Set(["BigInt64Array", "BigUint64Array", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
            if (typedArrays.has(branch.typeName.text)) return `JS.${branch.typeName.text}`;
          }
          return fsharpType(branch, available, dependencies, typeParameters);
        });
        if (branches.every(Boolean)) return erasedUnionType(branches);
      }
      const rendered = fsharpType(inner, available, dependencies, typeParameters);
      if (rendered && (ts.isTupleTypeNode(inner) || (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && inner.typeName.text === "Tuple"))) return rendered;
      recordTypeFailure(node);
      return undefined;
    }
    if (node.typeName.text === "Tuple" && node.typeArguments?.length === 2) {
      const element = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      const lengthNode = node.typeArguments[1];
      const length = ts.isLiteralTypeNode(lengthNode) && ts.isNumericLiteral(lengthNode.literal) ? Number(lengthNode.literal.text) : undefined;
      return element && Number.isInteger(length) && length >= 1 && length <= 32
        ? length === 1 ? `ReadonlyTuple1<${element}>` : `(${Array.from({ length }, () => element).join(" * ")})`
        : undefined;
    }
    if (node.typeName.text === "Error" && !node.typeArguments?.length) return "System.Exception";
    if (node.typeName.text === "Array" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `ResizeArray<${inner}>` : undefined;
    }
    if (node.typeName.text === "ArrayLike" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `System.Collections.Generic.IReadOnlyList<${inner}>` : undefined;
    }
    if (node.typeName.text === "ReadonlyArray" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `System.Collections.Generic.IReadOnlyList<${inner}>` : undefined;
    }
    if (node.typeName.text === "Readonly" && node.typeArguments?.length === 1 && ts.isTupleTypeNode(node.typeArguments[0])) {
      return fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
    }
    if (node.typeName.text === "Promise" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `JS.Promise<${inner}>` : undefined;
    }
    if (node.typeName.text === "Generator" && node.typeArguments?.length === 3) {
      const yieldType = node.typeArguments[0].kind === ts.SyntaxKind.UndefinedKeyword ? "unit" : fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      const returnType = fsharpType(node.typeArguments[1], available, dependencies, typeParameters);
      const nextType = node.typeArguments[2].kind === ts.SyntaxKind.UnknownKeyword ? "obj" : fsharpType(node.typeArguments[2], available, dependencies, typeParameters);
      return yieldType && returnType && nextType ? `BabylonjsBindings.SimpleInterfaces.BrowserGenerator<${yieldType}, ${returnType}, ${nextType}>` : undefined;
    }
    if (node.typeName.text === "Set" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `JS.Set<${inner}>` : undefined;
    }
    if (node.typeName.text === "ReadonlySet" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `BabylonjsBindings.SimpleInterfaces.BrowserReadonlySet<${inner}>` : undefined;
    }
    if (node.typeName.text === "Map" && node.typeArguments?.length === 2) {
      const key = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      const value = fsharpType(node.typeArguments[1], available, dependencies, typeParameters);
      return key && value ? `JS.Map<${key}, ${value}>` : undefined;
    }
    if (node.typeName.text === "ReadonlyMap" && node.typeArguments?.length === 2) {
      const key = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      const value = fsharpType(node.typeArguments[1], available, dependencies, typeParameters);
      return key && value ? `BabylonjsBindings.SimpleInterfaces.BrowserReadonlyMap<${key}, ${value}>` : undefined;
    }
    if (node.typeName.text === "Nullable" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? asOption(inner) : undefined;
    }
    if (node.typeName.text === "ArrayBufferLike" && !node.typeArguments?.length) return "U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer>";
    const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    if (node.typeArguments?.length === 1
      && jsTypes.has(node.typeName.text)
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && ["ArrayBuffer", "ArrayBufferLike"].includes(node.typeArguments[0].typeName.text)
      && !node.typeArguments[0].typeArguments?.length) return `JS.${node.typeName.text}`;
    const browserTypes = new Set([
      "AudioBuffer", "AudioBufferSourceNode", "AudioContext", "AudioDestinationNode", "AudioNode", "Blob", "Document", "Element", "Event", "File", "FocusEvent", "GainNode", "HTMLElement", "HTMLButtonElement", "HTMLCanvasElement", "HTMLDivElement", "HTMLImageElement", "HTMLMediaElement", "HTMLVideoElement", "KeyboardEvent", "MediaStreamAudioDestinationNode", "MediaTrackConstraints", "OfflineAudioContext", "PointerEvent", "PointerEventInit", "ProgressEvent", "Window", "XMLHttpRequest",
      "ImageData", "WebGLUniformLocation", "WebGL2RenderingContext", "WebGLRenderingContext",
      "WebGLProgram", "WebGLShader", "WebGLBuffer", "WebGLTexture", "WebGLFramebuffer", "WebGLRenderbuffer", "WebGLVertexArrayObject",
    ]);
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmapSource") return "BabylonjsBindings.SimpleInterfaces.BrowserImageBitmapSource";
    if (!node.typeArguments?.length && node.typeName.text === "AudioContext") return "BabylonjsBindings.SimpleInterfaces.BrowserAudioContext";
    if (!node.typeArguments?.length && node.typeName.text === "AudioDestinationNode") return "BabylonjsBindings.SimpleInterfaces.BrowserAudioDestinationNode";
    if (!node.typeArguments?.length && node.typeName.text === "MediaStreamAudioDestinationNode") return "BabylonjsBindings.SimpleInterfaces.BrowserMediaStreamAudioDestinationNode";
    if (!node.typeArguments?.length && node.typeName.text === "WebGL2RenderingContext") return "BabylonjsBindings.SimpleInterfaces.BrowserWebGL2RenderingContext";
    if (!node.typeArguments?.length && node.typeName.text === "Response") return "BabylonjsBindings.SimpleInterfaces.BrowserResponse";
    if (!node.typeArguments?.length && node.typeName.text === "BodyInit") return "BabylonjsBindings.SimpleInterfaces.BrowserBodyInit";
    if (!node.typeArguments?.length && node.typeName.text === "MediaStream") return "BabylonjsBindings.SimpleInterfaces.BrowserMediaStream";
    if (!node.typeArguments?.length && node.typeName.text === "XRReferenceSpace") return "BabylonjsBindings.SimpleInterfaces.BrowserXRReferenceSpace";
    if (!node.typeArguments?.length && node.typeName.text === "XRFrame") return "BabylonjsBindings.SimpleInterfaces.BrowserXRFrame";
    if (!node.typeArguments?.length && node.typeName.text === "XRSession") return "BabylonjsBindings.SimpleInterfaces.BrowserXRSession";
    if (!node.typeArguments?.length && node.typeName.text === "XRViewerPose") return "BabylonjsBindings.SimpleInterfaces.BrowserXRViewerPose";
    if (!node.typeArguments?.length && node.typeName.text === "XRInputSource") return "BabylonjsBindings.SimpleInterfaces.BrowserXRInputSource";
    if (!node.typeArguments?.length && node.typeName.text === "XRInputSourceEvent") return "BabylonjsBindings.SimpleInterfaces.BrowserXRInputSourceEvent";
    if (!node.typeArguments?.length && node.typeName.text === "XRPose") return "BabylonjsBindings.SimpleInterfaces.BrowserXRPose";
    if (!node.typeArguments?.length && node.typeName.text === "XRView") return "BabylonjsBindings.SimpleInterfaces.BrowserXRView";
    if (!node.typeArguments?.length && node.typeName.text === "XRSessionMode") return "BabylonjsBindings.SimpleInterfaces.BrowserXRSessionMode";
    if (!node.typeArguments?.length && node.typeName.text === "XREye") return "BabylonjsBindings.SimpleInterfaces.BrowserXREye";
    if (!node.typeArguments?.length && node.typeName.text === "XRLayer") return "BabylonjsBindings.SimpleInterfaces.BrowserXRLayer";
    if (!node.typeArguments?.length && node.typeName.text === "XRWebGLLayer") return "BabylonjsBindings.SimpleInterfaces.BrowserXRWebGLLayer";
    if (!node.typeArguments?.length && node.typeName.text === "XRWebGLLayerInit") return "BabylonjsBindings.SimpleInterfaces.BrowserXRWebGLLayerInit";
    if (!node.typeArguments?.length && node.typeName.text === "XRSessionInit") return "BabylonjsBindings.SimpleInterfaces.BrowserXRSessionInit";
    if (!node.typeArguments?.length && node.typeName.text === "XRRenderState") return "BabylonjsBindings.SimpleInterfaces.BrowserXRRenderState";
    if (!node.typeArguments?.length && node.typeName.text === "XRRenderStateInit") return "BabylonjsBindings.SimpleInterfaces.BrowserXRRenderStateInit";
    if (!node.typeArguments?.length && node.typeName.text === "XRReferenceSpaceType") return "BabylonjsBindings.SimpleInterfaces.BrowserXRReferenceSpaceType";
    if (!node.typeArguments?.length && node.typeName.text === "XRHandedness") return "BabylonjsBindings.SimpleInterfaces.BrowserXRHandedness";
    if (!node.typeArguments?.length && node.typeName.text === "XRProjectionLayerInit") return "BabylonjsBindings.SimpleInterfaces.BrowserXRProjectionLayerInit";
    if (!node.typeArguments?.length && node.typeName.text === "XRProjectionLayer") return "BabylonjsBindings.SimpleInterfaces.BrowserXRProjectionLayer";
    if (!node.typeArguments?.length && node.typeName.text === "XRAnchor") return "BabylonjsBindings.SimpleInterfaces.BrowserXRAnchor";
    if (!node.typeArguments?.length && node.typeName.text === "XRHitTestResult") return "BabylonjsBindings.SimpleInterfaces.BrowserXRHitTestResult";
    if (!node.typeArguments?.length && node.typeName.text === "XRHitResult") return "BabylonjsBindings.SimpleInterfaces.BrowserXRHitResult";
    if (!node.typeArguments?.length && node.typeName.text === "XRMesh") return "BabylonjsBindings.SimpleInterfaces.BrowserXRMesh";
    if (!node.typeArguments?.length && node.typeName.text === "XRPlane") return "BabylonjsBindings.SimpleInterfaces.BrowserXRPlane";
    if (!node.typeArguments?.length && node.typeName.text === "XRImageTrackingResult") return "BabylonjsBindings.SimpleInterfaces.BrowserXRImageTrackingResult";
    if (!node.typeArguments?.length && node.typeName.text === "XRHitTestTrackableType") return "BabylonjsBindings.SimpleInterfaces.BrowserXRHitTestTrackableType";
    if (!node.typeArguments?.length && node.typeName.text === "XRReflectionFormat") return "BabylonjsBindings.SimpleInterfaces.BrowserXRReflectionFormat";
    if (!node.typeArguments?.length && node.typeName.text === "XRGeometryDetectorOptions") return "BabylonjsBindings.SimpleInterfaces.BrowserXRGeometryDetectorOptions";
    if (!node.typeArguments?.length && node.typeName.text === "DistanceModelType") return "BabylonjsBindings.SimpleInterfaces.BrowserDistanceModelType";
    if (!node.typeArguments?.length && node.typeName.text === "PanningModelType") return "BabylonjsBindings.SimpleInterfaces.BrowserPanningModelType";
    if (!node.typeArguments?.length && node.typeName.text === "BigUint64Array") return "BabylonjsBindings.SimpleInterfaces.BrowserBigUint64Array";
    if (!node.typeArguments?.length && node.typeName.text === "GPUPowerPreference") return "BabylonjsBindings.SimpleInterfaces.BrowserGPUPowerPreference";
    if (!node.typeArguments?.length && node.typeName.text === "XMLHttpRequestBodyInit") return "BabylonjsBindings.SimpleInterfaces.BrowserXMLHttpRequestBodyInit";
    if (!node.typeArguments?.length && node.typeName.text === "XMLHttpRequest") return "BabylonjsBindings.SimpleInterfaces.BrowserXMLHttpRequest";
    if (!node.typeArguments?.length && node.typeName.text === "URL") return "BabylonjsBindings.SimpleInterfaces.BrowserURL";
    if (!node.typeArguments?.length && node.typeName.text === "DOMRect") return "BabylonjsBindings.SimpleInterfaces.BrowserDOMRect";
    const ambientHandleTypes = new Map([
      ["GPUDevice", "BrowserGPUDevice"],
      ["GPUBuffer", "BrowserGPUBuffer"],
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
      ["XRWebGLBinding", "BrowserXRWebGLBinding"]
      ,["XRCompositionLayer", "BrowserXRCompositionLayer"]
      ,["WebGLContextEvent", "BrowserWebGLContextEvent"]
      ,["AudioBuffer", "BrowserAudioBuffer"]
      ,["AudioNode", "BrowserAudioNode"]
      ,["GainNode", "BrowserGainNode"]
      ,["OfflineAudioContext", "BrowserOfflineAudioContext"]
      ,["AudioBufferSourceNode", "BrowserAudioBufferSourceNode"]
      ,["MediaTrackConstraints", "BrowserMediaTrackConstraints"]
      ,["PointerEventInit", "BrowserPointerEventInit"]
      ,["WebGLVertexArrayObject", "BrowserWebGLVertexArrayObject"]
      ,["WebGLTransformFeedback", "BrowserWebGLTransformFeedback"]
      ,["Worker", "BrowserWorker"]
    ]);
    if (!node.typeArguments?.length && ambientHandleTypes.has(node.typeName.text)) return `BabylonjsBindings.SimpleInterfaces.${ambientHandleTypes.get(node.typeName.text)}`;
    if (!node.typeArguments?.length && node.typeName.text === "GPUBufferUsageFlags") return "float";
    if (!node.typeArguments?.length && node.typeName.text === "WebXRRenderTarget" && (available.has("WebXRRenderTarget") || maintainedSymbols.has("WebXRRenderTarget"))) {
      if (available.has("WebXRRenderTarget")) dependencies.add("WebXRRenderTarget");
      return "BabylonjsBindings.SimpleInterfaces.WebXRRenderTarget<Browser.Types.WebGLRenderingContext, BabylonjsBindings.SimpleInterfaces.BrowserXRWebGLLayer>";
    }
    if (!node.typeArguments?.length && node.typeName.text === "XMLHttpRequestResponseType") return "BabylonjsBindings.SimpleInterfaces.BrowserXMLHttpRequestResponseType";
    if (!node.typeArguments?.length && node.typeName.text === "OffscreenCanvas") return "BabylonjsBindings.SimpleInterfaces.BrowserOffscreenCanvas";
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmapOptions") return "BabylonjsBindings.SimpleInterfaces.BrowserImageBitmapOptions";
    if (!node.typeArguments?.length && node.typeName.text === "ElementImage") return "BabylonjsBindings.SimpleInterfaces.BrowserElementImage";
    if (!node.typeArguments?.length && node.typeName.text === "WebGLCopyElementImageConfig") return "BabylonjsBindings.SimpleInterfaces.BrowserWebGLCopyElementImageConfig";
    if (!node.typeArguments?.length && node.typeName.text === "XRRigidTransform") return "BabylonjsBindings.SimpleInterfaces.BrowserXRRigidTransform";
    if (!node.typeArguments?.length && node.typeName.text === "XRSpace") return "BabylonjsBindings.SimpleInterfaces.BrowserXRSpace";
    if (!node.typeArguments?.length && node.typeName.text === "XRRay") return "BabylonjsBindings.SimpleInterfaces.BrowserXRRay";
    if (!node.typeArguments?.length && node.typeName.text === "XRHitTestSource") return "BabylonjsBindings.SimpleInterfaces.BrowserXRHitTestSource";
    if (!node.typeArguments?.length && node.typeName.text === "XRAnchorSet") return "BabylonjsBindings.SimpleInterfaces.BrowserXRAnchorSet";
    if (!node.typeArguments?.length && node.typeName.text === "XRWorldInformation") return "BabylonjsBindings.SimpleInterfaces.BrowserXRWorldInformation";
    if (!node.typeArguments?.length && node.typeName.text === "XRPlaneSet") return "BabylonjsBindings.SimpleInterfaces.BrowserXRPlaneSet";
    if (!node.typeArguments?.length && node.typeName.text === "XRJointSpace") return "BabylonjsBindings.SimpleInterfaces.BrowserXRJointSpace";
    if (!node.typeArguments?.length && node.typeName.text === "XRJointPose") return "BabylonjsBindings.SimpleInterfaces.BrowserXRJointPose";
    if (!node.typeArguments?.length && node.typeName.text === "XRCPUDepthInformation") return "BabylonjsBindings.SimpleInterfaces.BrowserXRCPUDepthInformation";
    if (!node.typeArguments?.length && node.typeName.text === "INativeXRFrame") return "BabylonjsBindings.SimpleInterfaces.BrowserNativeXRFrame";
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmap") return "BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap";
    if (!node.typeArguments?.length && node.typeName.text === "VideoFrame") return "BabylonjsBindings.SimpleInterfaces.BrowserVideoFrame";
    if (!node.typeArguments?.length && node.typeName.text === "RegExp") return "BabylonjsBindings.SimpleInterfaces.BrowserRegExp";
    if (!node.typeArguments?.length && node.typeName.text === "WebGLQuery") return "BabylonjsBindings.SimpleInterfaces.BrowserWebGLQuery";
    if (!node.typeArguments?.length && browserTypes.has(node.typeName.text)) return `Browser.Types.${node.typeName.text}`;
    if (!node.typeArguments?.length && typeParameters.substitutions?.has(node.typeName.text)) return typeParameters.substitutions.get(node.typeName.text);
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
    if (!node.typeArguments?.length) {
      let symbol = checker.getSymbolAtLocation(node.typeName);
      if (symbol?.flags & ts.SymbolFlags.Alias) {
        try { symbol = checker.getAliasedSymbol(symbol); } catch { symbol = undefined; }
      }
      const aliasDeclaration = symbol?.declarations?.find(ts.isTypeAliasDeclaration);
      if (aliasDeclaration && !aliasDeclaration.typeParameters?.length && ts.isTypeLiteralNode(aliasDeclaration.type)) {
        const digest = createHash("sha256").update(`${node.typeName.text}|${aliasDeclaration.type.getText().replace(/\s+/g, " ")}`).digest("hex").slice(0, 12);
        return inlineObjectType(aliasDeclaration.type, available, dependencies, typeParameters, utilityInlineTypes, `InternalAlias${digest}`);
      }
      if (aliasDeclaration && !aliasDeclaration.typeParameters?.length && !resolvingInternalAliases.has(aliasDeclaration)) {
        resolvingInternalAliases.add(aliasDeclaration);
        const rendered = fsharpType(aliasDeclaration.type, available, dependencies, typeParameters);
        resolvingInternalAliases.delete(aliasDeclaration);
        if (rendered) return rendered;
      }
      const enumDeclaration = symbol?.declarations?.find(ts.isEnumDeclaration);
      if (enumDeclaration) {
        const members = enumDeclaration.members.map(member => ({
          name: (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name)) ? member.name.text : undefined,
          value: checker.getConstantValue(member)
        }));
        if (members.length > 0 && members.every(member => member.name && typeof member.value === "number")) {
          internalEnumTypes.set(node.typeName.text, members);
          return node.typeName.text;
        }
      }
    }
  }
  recordTypeFailure(node);
  return undefined;
};
const directCallbackShape = (node, available, dependencies, typeParameters) => {
  if (node.typeParameters?.length || node.parameters.some(parameter => parameter.dotDotDotToken)) return undefined;
  const returnType = node.type ? fsharpType(node.type, available, dependencies, typeParameters) : undefined;
  const parameters = node.parameters.map(parameter => {
    const rendered = parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined;
    return {
      name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
      type: parameter.questionToken && rendered ? asOption(rendered) : rendered,
      optional: Boolean(parameter.questionToken)
    };
  });
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters } : undefined;
};
const directDelegateType = callback => {
  const parameterTypes = callback.parameters.map(parameter => parameter.type);
  if (callback.returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
  return `System.Func<${[...parameterTypes, callback.returnType].join(", ")}>`;
};
const initializerType = node => {
  if (!node) return undefined;
  if (ts.isNumericLiteral(node)) return "float";
  if (ts.isStringLiteral(node) || ts.isNoSubstitutionTemplateLiteral(node)) return "string";
  if (node.kind === ts.SyntaxKind.TrueKeyword || node.kind === ts.SyntaxKind.FalseKeyword) return "bool";
  if (ts.isPrefixUnaryExpression(node) && (node.operator === ts.SyntaxKind.PlusToken || node.operator === ts.SyntaxKind.MinusToken) && ts.isNumericLiteral(node.operand)) return "float";
  return undefined;
};
const functionType = node => ts.isFunctionTypeNode(node)
  ? node
  : ts.isParenthesizedTypeNode(node) && ts.isFunctionTypeNode(node.type)
    ? node.type
    : undefined;
const callbackPropertyType = node => {
  const direct = functionType(node);
  if (direct) return { node: direct, optional: false };
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName) && node.typeName.text === "Nullable" && node.typeArguments?.length === 1 && functionType(node.typeArguments[0])) {
    return { node: functionType(node.typeArguments[0]), optional: true };
  }
  if (ts.isUnionTypeNode(node) && node.types.length === 2) {
    const absent = node.types.find(isAbsentType);
    const callback = node.types.map(functionType).find(Boolean);
    if (absent && callback) return { node: callback, optional: true };
  }
  return undefined;
};
const expandFixedRestTypes = (node, available, dependencies, typeParameters) => {
  if (ts.isTypeReferenceNode(node)
    && ts.isIdentifier(node.typeName)
    && node.typeName.text === "Tuple"
    && node.typeArguments?.length === 2) {
    const element = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
    const lengthNode = node.typeArguments[1];
    const length = ts.isLiteralTypeNode(lengthNode) && ts.isNumericLiteral(lengthNode.literal) ? Number(lengthNode.literal.text) : undefined;
    return element && Number.isInteger(length) && length >= 1 && length <= 32 ? Array.from({ length }, () => element) : undefined;
  }
  if (ts.isTupleTypeNode(node)) {
    const expanded = [];
    for (const element of node.elements) {
      const nested = ts.isNamedTupleMember(element) && element.dotDotDotToken
        ? expandFixedRestTypes(element.type, available, dependencies, typeParameters)
        : ts.isRestTypeNode(element)
          ? expandFixedRestTypes(element.type, available, dependencies, typeParameters)
          : undefined;
      if (nested) {
        expanded.push(...nested);
        continue;
      }
      const rendered = ts.isNamedTupleMember(element)
        ? !element.questionToken ? fsharpType(element.type, available, dependencies, typeParameters) : undefined
        : fsharpType(element, available, dependencies, typeParameters);
      if (!rendered) return undefined;
      expanded.push(rendered);
    }
    return expanded;
  }
  return undefined;
};
const inlineObjectType = (node, available, dependencies, typeParameters, inlineTypes, context, forceOptional = false) => {
  if (!ts.isTypeLiteralNode(node)) return undefined;
  const name = `${context}Object`;
  const existing = inlineTypes.find(inline => inline.name === name);
  if (existing) return `${name}${existing.genericParameters}`;
  const genericParameters = typeParameters.size ? `<${[...typeParameters].map(value => `'${value}`).join(", ")}>` : "";
  const members = [];
  const renderedAccessors = new Set();
  for (const [memberIndex, member] of node.members.entries()) {
    if (ts.isPropertySignature(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      let type = ts.isTypeLiteralNode(member.type)
        ? inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${name}Property${memberIndex + 1}`, forceOptional)
        : fsharpType(member.type, available, dependencies, typeParameters);
      if (!type) return undefined;
      members.push({ kind: "property", name: member.name.text, type: member.questionToken || forceOptional ? asOption(type) : type, readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword) });
    } else if (ts.isIndexSignatureDeclaration(member) && member.parameters.length === 1 && member.parameters[0].type && member.type && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type, available, dependencies, typeParameters);
      let valueType = ts.isTypeLiteralNode(member.type)
        ? inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${name}Value${memberIndex + 1}`, forceOptional)
        : fsharpType(member.type, available, dependencies, typeParameters);
      if (!keyType || !valueType) return undefined;
      members.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword) });
    } else if (ts.isMethodSignature(member)
      && !member.typeParameters?.length
      && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      const callback = directCallbackShape(member, available, dependencies, typeParameters);
      if (!callback) return undefined;
      members.push({ kind: "method", name: member.name.text, callback: { ...callback, genericParameters: "" } });
    } else if ((ts.isGetAccessorDeclaration(member) || ts.isSetAccessorDeclaration(member))
      && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      if (renderedAccessors.has(member.name.text)) continue;
      const accessors = node.members.filter(candidate => (ts.isGetAccessorDeclaration(candidate) || ts.isSetAccessorDeclaration(candidate))
        && (ts.isIdentifier(candidate.name) || ts.isStringLiteral(candidate.name))
        && candidate.name.text === member.name.text);
      const getter = accessors.find(ts.isGetAccessorDeclaration);
      const setter = accessors.find(ts.isSetAccessorDeclaration);
      const getterType = getter?.type ? fsharpType(getter.type, available, dependencies, typeParameters) : undefined;
      const setterType = setter?.parameters?.[0]?.type ? fsharpType(setter.parameters[0].type, available, dependencies, typeParameters) : undefined;
      const type = getterType ?? setterType;
      if (!type || (getterType && setterType && getterType !== setterType)) return undefined;
      members.push({ kind: "accessor", name: member.name.text, type, canGet: Boolean(getter), canSet: Boolean(setter) });
      renderedAccessors.add(member.name.text);
    } else {
      recordTypeFailure(member);
      return undefined;
    }
  }
  inlineTypes.push({ name, genericParameters, members });
  return `${name}${genericParameters}`;
};
const intersectionObjectType = (node, available, dependencies, typeParameters, inlineTypes) => {
  if (!ts.isIntersectionTypeNode(node)) return undefined;
  const objectBranches = node.types.filter(ts.isTypeLiteralNode);
  if (objectBranches.length !== 1) return undefined;
  const digest = createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12);
  const name = `InlineIntersection${digest}Object`;
  const existing = inlineTypes.find(inline => inline.name === name);
  if (existing) return `${name}${existing.genericParameters}`;
  const objectBase = inlineObjectType(objectBranches[0], available, dependencies, typeParameters, inlineTypes, `${name}Members`);
  const otherBases = node.types.filter(branch => !ts.isTypeLiteralNode(branch)).map(branch => fsharpType(branch, available, dependencies, typeParameters));
  if (!objectBase || otherBases.some(base => !base)) return undefined;
  const genericParameters = typeParameters.size ? `<${[...typeParameters].map(value => `'${value}`).join(", ")}>` : "";
  inlineTypes.push({ name, genericParameters, bases: [...otherBases, objectBase], members: [] });
  return `${name}${genericParameters}`;
};
const flowGraphAssetKinds = [
  ["Animation", "FlowGraphAnimationAssetType"],
  ["AnimationGroup", "FlowGraphAnimationGroupAssetType"],
  ["Mesh", "FlowGraphMeshAssetType"],
  ["Material", "FlowGraphMaterialAssetType"],
  ["Camera", "FlowGraphCameraAssetType"],
  ["Light", "FlowGraphLightAssetType"]
];
const xmlHttpRequestEventKinds = [
  ["abort", "XmlHttpRequestAbortEventType", "Browser.Types.ProgressEvent"],
  ["error", "XmlHttpRequestErrorEventType", "Browser.Types.ProgressEvent"],
  ["load", "XmlHttpRequestLoadEventType", "Browser.Types.ProgressEvent"],
  ["loadend", "XmlHttpRequestLoadEndEventType", "Browser.Types.ProgressEvent"],
  ["loadstart", "XmlHttpRequestLoadStartEventType", "Browser.Types.ProgressEvent"],
  ["progress", "XmlHttpRequestProgressEventType", "Browser.Types.ProgressEvent"],
  ["readystatechange", "XmlHttpRequestReadyStateChangeEventType", "Browser.Types.Event"],
  ["timeout", "XmlHttpRequestTimeoutEventType", "Browser.Types.ProgressEvent"]
];
const perfMetadataKinds = [
  ["category", "PerfMetadataCategoryProperty", "string"],
  ["color", "PerfMetadataColorProperty", "string"],
  ["hidden", "PerfMetadataHiddenProperty", "bool"]
];
const isNominalFsharpConstraint = node => {
  if (!ts.isTypeReferenceNode(node) || !ts.isIdentifier(node.typeName)) return false;
  let symbol = checker.getSymbolAtLocation(node.typeName);
  if (symbol?.flags & ts.SymbolFlags.Alias) {
    try { symbol = checker.getAliasedSymbol(symbol); } catch { return false; }
  }
  return Boolean(symbol?.declarations?.some(declaration => ts.isClassDeclaration(declaration) || ts.isInterfaceDeclaration(declaration)));
};
const isProjectedKeyofConstraint = (constraint, ownerTypeParameters) => constraint
  && ts.isTypeOperatorNode(constraint)
  && constraint.operator === ts.SyntaxKind.KeyOfKeyword
  && ts.isTypeReferenceNode(constraint.type)
  && ts.isIdentifier(constraint.type.typeName)
  && !constraint.type.typeArguments?.length
  && ownerTypeParameters.has(constraint.type.typeName.text);
const isObjectConstraint = constraint => constraint?.kind === ts.SyntaxKind.ObjectKeyword;
const isStringUnknownRecordConstraint = constraint => constraint?.getText().replace(/\s+/g, " ") === "Record<string, unknown>";
const isFunctionConstraint = constraint => ts.isTypeReferenceNode(constraint) && ts.isIdentifier(constraint.typeName) && constraint.typeName.text === "Function" && !constraint.typeArguments?.length;
const isNodeRenderGraphValueConstraint = constraint => ts.isTypeReferenceNode(constraint) && ts.isIdentifier(constraint.typeName) && constraint.typeName.text === "NodeRenderGraphValueType" && !constraint.typeArguments?.length;
const classGenericDefaults = declaration => {
  const defaults = [];
  const collect = (parameters, context) => {
    for (const parameter of parameters ?? []) if (parameter.default) defaults.push({
      context,
      parameter: parameter.name.text,
      defaultType: parameter.default.getText().replace(/\s+/g, " ")
    });
  };
  collect(declaration.typeParameters, declaration.name?.text ?? "class");
  for (const member of declaration.members) {
    if (inaccessible(member)) continue;
    const memberName = member.name && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name)) ? member.name.text : ts.SyntaxKind[member.kind];
    collect(member.typeParameters, `${declaration.name?.text ?? "class"}.${memberName}`);
  }
  return defaults;
};
const classStructuralImplements = declaration => (declaration.heritageClauses ?? [])
  .filter(clause => clause.token === ts.SyntaxKind.ImplementsKeyword)
  .flatMap(clause => clause.types)
  .map(type => type.getText().replace(/\s+/g, " "))
  .filter(type => type.startsWith("Tensor<") || type.startsWith("Vector<"));
const classFidelityIssues = declaration => {
  const issues = new Set();
  const ownerTypeParameters = new Set((declaration.typeParameters ?? []).map(parameter => parameter.name.text));
  const inspectTypeParameters = (parameters, context) => {
    for (const parameter of parameters ?? []) {
      const constraint = parameter.constraint;
      if (!constraint || constraint.kind === ts.SyntaxKind.AnyKeyword || isNominalFsharpConstraint(constraint) || isProjectedKeyofConstraint(constraint, ownerTypeParameters) || isObjectConstraint(constraint) || isStringUnknownRecordConstraint(constraint) || isFunctionConstraint(constraint) || isNodeRenderGraphValueConstraint(constraint)) continue;
      issues.add(`${context}: unprojected generic constraint ${parameter.name.text} extends ${constraint.getText().replace(/\s+/g, " ")}`);
    }
  };
  inspectTypeParameters(declaration.typeParameters, declaration.name?.text ?? "class");
  for (const member of declaration.members) {
    if (inaccessible(member)) continue;
    const memberName = member.name && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name)) ? member.name.text : ts.SyntaxKind[member.kind];
    if (declaration.name?.text === "PerformanceViewerCollector" && memberName === "updateMetadata") continue;
    if (declaration.name?.text === "WebRequest" && (memberName === "addEventListener" || memberName === "removeEventListener")) continue;
    if (declaration.name?.text === "FlowGraphContext" && memberName === "getAsset") continue;
    if (declaration.name?.text === "Angle" && memberName === "BetweenTwoVectors") continue;
    inspectTypeParameters(member.typeParameters, `${declaration.name?.text ?? "class"}.${memberName}`);
  }
  const implementsTypes = (declaration.heritageClauses ?? [])
    .filter(clause => clause.token === ts.SyntaxKind.ImplementsKeyword)
    .flatMap(clause => clause.types.map(type => type.getText().replace(/\s+/g, " ")));
  const projectedImplements = new Set(declaration.__projectedImplements ?? []);
  const structuralImplements = new Set(classStructuralImplements(declaration));
  if (declaration.name?.text !== "FlowGraphConnection") for (const type of implementsTypes) {
    if (!projectedImplements.has(type) && !structuralImplements.has(type)) issues.add(`unprojected implements ${type}`);
  }
  return [...issues].sort();
};
const callbackShape = (node, available, dependencies, typeParameters, nestedCallbacks, inlineTypes, context, ownerName) => {
  const localTypeParameters = new Set(typeParameters);
  localTypeParameters.deepImmutableSymbols = new Map(typeParameters.deepImmutableSymbols ?? []);
  localTypeParameters.substitutions = new Map(typeParameters.substitutions ?? []);
  for (const parameter of node.typeParameters ?? []) {
    const constraint = parameter.constraint;
    if (constraint
      && ts.isTypeOperatorNode(constraint)
      && constraint.operator === ts.SyntaxKind.KeyOfKeyword
      && ts.isTypeReferenceNode(constraint.type)
      && ts.isIdentifier(constraint.type.typeName)
      && !constraint.type.typeArguments?.length
      && localTypeParameters.has(constraint.type.typeName.text)) {
      localTypeParameters.substitutions.set(parameter.name.text, `BabylonjsBindings.SimpleInterfaces.JavaScriptKeyOf<'${constraint.type.typeName.text}>`);
    } else {
      localTypeParameters.add(parameter.name.text);
    }
  }
  localTypeParameters.ownerName = typeParameters.ownerName;
  const constraints = [];
  for (const parameter of node.typeParameters ?? []) {
    if (!parameter.constraint) continue;
    if (localTypeParameters.substitutions.has(parameter.name.text)) continue;
    if (isStringUnknownRecordConstraint(parameter.constraint)) {
      constraints.push(`'${parameter.name.text} :> BabylonjsBindings.ObjectTypes.JavaScriptStringUnknownRecord`);
      continue;
    }
    if (isFunctionConstraint(parameter.constraint)) {
      constraints.push(`'${parameter.name.text} :> BabylonjsBindings.TypeAliases.JavaScriptFunction`);
      continue;
    }
    if (isNodeRenderGraphValueConstraint(parameter.constraint)) {
      constraints.push(`'${parameter.name.text} :> BabylonjsBindings.TypeAliases.NodeRenderGraphValue`);
      continue;
    }
    if (isObjectConstraint(parameter.constraint)) {
      constraints.push(`'${parameter.name.text} : not struct`);
      continue;
    }
    if (!isNominalFsharpConstraint(parameter.constraint)) continue;
    const constraint = fsharpType(parameter.constraint, available, dependencies, localTypeParameters);
    if (!constraint) return undefined;
    constraints.push(`'${parameter.name.text} :> ${constraint}`);
    if (ts.isTypeReferenceNode(parameter.constraint)
      && ts.isIdentifier(parameter.constraint.typeName)
      && !parameter.constraint.typeArguments?.length) {
      const target = available.get(parameter.constraint.typeName.text) ?? maintainedSymbols.get(parameter.constraint.typeName.text);
      if (target?.deepImmutableSymbol) localTypeParameters.deepImmutableSymbols.set(parameter.name.text, target.deepImmutableSymbol);
    }
  }
  let returnType = node.type && ts.isTypeLiteralNode(node.type) && !(node.type.members.length === 1 && ts.isCallSignatureDeclaration(node.type.members[0]))
    ? inlineObjectType(node.type, available, dependencies, localTypeParameters, inlineTypes, `${context}Return`)
    : node.type ? fsharpType(node.type, available, dependencies, localTypeParameters) : undefined;
  const parameters = node.parameters.flatMap((parameter, index) => {
    if (parameter.dotDotDotToken) {
      if (parameter.type
        && ts.isArrayTypeNode(parameter.type)
        && (parameter.type.elementType.kind === ts.SyntaxKind.UnknownKeyword || parameter.type.elementType.kind === ts.SyntaxKind.AnyKeyword)) {
        return [{ name: ts.isIdentifier(parameter.name) ? parameter.name.text : "args", type: "obj[]", optional: false, paramArray: true }];
      }
      if (parameter.type && ts.isArrayTypeNode(parameter.type)) {
        const element = fsharpType(parameter.type.elementType, available, dependencies, localTypeParameters);
        if (element) return [{ name: ts.isIdentifier(parameter.name) ? parameter.name.text : "args", type: `${element}[]`, optional: false, paramArray: true }];
      }
      const expanded = parameter.type ? expandFixedRestTypes(parameter.type, available, dependencies, localTypeParameters) : undefined;
      return expanded
        ? expanded.map((type, expandedIndex) => ({ name: `${ts.isIdentifier(parameter.name) ? parameter.name.text : "arg"}${expandedIndex + 1}`, type, optional: false }))
        : [{ name: undefined, type: undefined, optional: false }];
    }
    let type = parameter.type && ts.isTypeLiteralNode(parameter.type) && !(parameter.type.members.length === 1 && ts.isCallSignatureDeclaration(parameter.type.members[0]))
      ? inlineObjectType(parameter.type, available, dependencies, localTypeParameters, inlineTypes, `${context}Parameter${index + 1}`)
      : parameter.type ? fsharpType(parameter.type, available, dependencies, localTypeParameters) : undefined;
    const nestedProperty = parameter.type ? callbackPropertyType(parameter.type) : undefined;
    if (!type && nestedProperty) {
      const nested = directCallbackShape(nestedProperty.node, available, dependencies, localTypeParameters);
      const usesOwner = nested && [nested.returnType, ...nested.parameters.map(item => item.type)].some(type => new RegExp(`(^|[^A-Za-z0-9_])${ownerName}([^A-Za-z0-9_]|$)`).test(type));
      if (nested) {
        if (usesOwner) {
          type = directDelegateType(nested);
        } else {
          const name = `${context}Parameter${index + 1}Callback`;
          const genericParameters = localTypeParameters.size ? `<${[...localTypeParameters].map(value => `'${value}`).join(", ")}>` : "";
          nestedCallbacks.push({ name, genericParameters, callback: nested });
          type = `${name}${genericParameters}`;
        }
        if (nestedProperty.optional) type = asOption(type);
      }
    }
    return [{
      name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
      type: parameter.questionToken && type ? asOptionalParameterType(type) : type,
      optional: Boolean(parameter.questionToken)
    }];
  });
  const emittedTypeParameters = (node.typeParameters ?? []).filter(parameter => !localTypeParameters.substitutions.has(parameter.name.text));
  const genericParameters = emittedTypeParameters.length
    ? `<${emittedTypeParameters.map(parameter => `'${parameter.name.text}`).join(", ")}${constraints.length ? ` when ${constraints.join(" and ")}` : ""}>`
    : "";
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters, genericParameters } : undefined;
};
const renderClass = (declaration, available, hasBase) => {
  const dependencies = new Set();
  const typeParameters = new Set((declaration.typeParameters ?? []).map(parameter => parameter.name.text));
  typeParameters.ownerName = declaration.name.text;
  const genericConstraints = [];
  for (const parameter of declaration.typeParameters ?? []) {
    if (!parameter.constraint) continue;
    if (isStringUnknownRecordConstraint(parameter.constraint)) {
      genericConstraints.push(`'${parameter.name.text} :> BabylonjsBindings.ObjectTypes.JavaScriptStringUnknownRecord`);
      continue;
    }
    if (isFunctionConstraint(parameter.constraint)) {
      genericConstraints.push(`'${parameter.name.text} :> BabylonjsBindings.TypeAliases.JavaScriptFunction`);
      continue;
    }
    if (isNodeRenderGraphValueConstraint(parameter.constraint)) {
      genericConstraints.push(`'${parameter.name.text} :> BabylonjsBindings.TypeAliases.NodeRenderGraphValue`);
      continue;
    }
    if (isObjectConstraint(parameter.constraint)) {
      genericConstraints.push(`'${parameter.name.text} : not struct`);
      continue;
    }
    if (!isNominalFsharpConstraint(parameter.constraint)) continue;
    const constraint = fsharpType(parameter.constraint, available, dependencies, typeParameters);
    if (!constraint) return undefined;
    genericConstraints.push(`'${parameter.name.text} :> ${constraint}`);
  }
  const nestedCallbacks = [];
  const inlineTypes = [];
  const instanceMembers = [];
  const staticMembers = [];
  const constructors = [];
  const accessors = new Map();
  const methodCounts = new Map();
  const renderedMethodNames = new Set();
  const failedOverloadNames = new Set();
  for (const member of declaration.members) {
    if (inaccessible(member) || !ts.isMethodDeclaration(member) || (!ts.isIdentifier(member.name) && !ts.isStringLiteral(member.name))) continue;
    methodCounts.set(member.name.text, (methodCounts.get(member.name.text) ?? 0) + 1);
  }
  const constructorDeclarations = declaration.members.filter(ts.isConstructorDeclaration);
  for (const [memberIndex, member] of declaration.members.entries()) {
    if (inaccessible(member)) continue;
    const target = hasModifier(member, ts.SyntaxKind.StaticKeyword) ? staticMembers : instanceMembers;
    if (ts.isConstructorDeclaration(member)) {
      const callback = callbackShape({ parameters: member.parameters, type: { kind: ts.SyntaxKind.VoidKeyword } }, available, dependencies, typeParameters, nestedCallbacks, inlineTypes, `${declaration.name.text}Constructor${memberIndex + 1}`, declaration.name.text);
      if (!callback) {
        recordTypeFailure(member);
        return undefined;
      }
      constructors.push(callback);
    } else if (ts.isPropertyDeclaration(member) && (member.type || member.initializer) && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      if (member.questionToken && hasModifier(member, ts.SyntaxKind.ReadonlyKeyword)) {
        // Optional readonly is representable; the branch merely documents that
        // both flags participate independently below.
      }
      const callbackProperty = member.type ? callbackPropertyType(member.type) : undefined;
      if (callbackProperty) {
        const callback = callbackShape(callbackProperty.node, available, dependencies, typeParameters, nestedCallbacks, inlineTypes, `${declaration.name.text}Property${memberIndex + 1}`, declaration.name.text);
        if (!callback) {
          recordTypeFailure(member);
          return undefined;
        }
        target.push({ kind: "callbackProperty", name: member.name.text, optional: Boolean(member.questionToken) || callbackProperty.optional, readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword), callback });
      } else {
        let type = member.type && ts.isTypeLiteralNode(member.type)
          ? inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${declaration.name.text}Property${memberIndex + 1}`)
          : member.type ? fsharpType(member.type, available, dependencies, typeParameters) : initializerType(member.initializer);
        if (!type) {
          recordTypeFailure(member);
          return undefined;
        }
        target.push({ kind: "property", name: member.name.text, type: member.questionToken ? asOption(type) : type, readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword) });
      }
    } else if (ts.isMethodDeclaration(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      if (declaration.name.text === "Angle" && member.name.text === "BetweenTwoVectors") {
        for (const vector of ["Vector2", "Vector3", "Vector4"]) {
          const targetVector = available.get(vector);
          if (!targetVector?.deepImmutableSymbol) {
            recordTypeFailure(member);
            return undefined;
          }
          dependencies.add(vector);
          target.push({
            kind: "method",
            name: member.name.text,
            callback: {
              parameters: [
                { name: "a", type: targetVector.deepImmutableSymbol, optional: false },
                { name: "b", type: targetVector.deepImmutableSymbol, optional: false }
              ],
              returnType: "Angle",
              genericParameters: ""
            }
          });
        }
        renderedMethodNames.add(member.name.text);
        continue;
      }
      if (declaration.name.text === "FlowGraphContext" && member.name.text === "getAsset") {
        const missingAsset = flowGraphAssetKinds.find(([asset]) => !available.has(asset));
        if (missingAsset) {
          recordTypeFailure(member);
          return undefined;
        }
        for (const [asset] of flowGraphAssetKinds) dependencies.add(asset);
        const parameters = (type) => [
          { name: "type", type, optional: false },
          { name: "index", type: "float", optional: false }
        ];
        target.push({
          kind: "method",
          name: "getAsset",
          callback: {
            parameters: parameters("BabylonjsBindings.StringEnums.FlowGraphAssetType"),
            returnType: `U6<${flowGraphAssetKinds.map(([asset]) => asset).join(", ")}> option`,
            genericParameters: ""
          }
        });
        for (const [asset, marker] of flowGraphAssetKinds) {
          target.push({
            kind: "method",
            name: "getAsset",
            callback: { parameters: parameters(marker), returnType: `${asset} option`, genericParameters: "" }
          });
        }
        renderedMethodNames.add(member.name.text);
        continue;
      }
      if (declaration.name.text === "WebRequest" && ["addEventListener", "removeEventListener"].includes(member.name.text)) {
        const add = member.name.text === "addEventListener";
        for (const [, marker, eventType] of xmlHttpRequestEventKinds) {
          target.push({
            kind: "method",
            name: member.name.text,
            callback: {
              parameters: [
                { name: "type", type: marker, optional: false },
                { name: "listener", type: `System.Func<${eventType}, obj>`, optional: false },
                { name: "options", type: `U2<bool, BabylonjsBindings.SimpleInterfaces.${add ? "BrowserAddEventListenerOptions" : "BrowserEventListenerOptions"}>`, optional: true }
              ],
              returnType: "unit",
              genericParameters: ""
            }
          });
        }
        renderedMethodNames.add(member.name.text);
        continue;
      }
      if (declaration.name.text === "PerformanceViewerCollector" && member.name.text === "updateMetadata") {
        target.push({ kind: "method", name: member.name.text, callback: {
          parameters: [
            { name: "id", type: "string", optional: false },
            { name: "prop", type: "PerfMetadataProperty", optional: false },
            { name: "value", type: "U2<string, bool>", optional: false }
          ],
          returnType: "unit",
          genericParameters: ""
        }});
        for (const [, marker, valueType] of perfMetadataKinds) {
          target.push({ kind: "method", name: member.name.text, callback: {
            parameters: [
              { name: "id", type: "string", optional: false },
              { name: "prop", type: marker, optional: false },
              { name: "value", type: valueType, optional: false }
            ],
            returnType: "unit",
            genericParameters: ""
          }});
        }
        renderedMethodNames.add(member.name.text);
        continue;
      }
      if (member.questionToken) {
        const callback = callbackShape(member, available, dependencies, typeParameters, nestedCallbacks, inlineTypes, `${declaration.name.text}Method${memberIndex + 1}`, declaration.name.text);
        if (!callback) {
          recordTypeFailure(member);
          return undefined;
        }
        target.push({ kind: "callbackProperty", name: member.name.text, optional: true, readonly: false, callback });
        continue;
      }
      const callback = callbackShape(member, available, dependencies, typeParameters, nestedCallbacks, inlineTypes, `${declaration.name.text}Method${memberIndex + 1}`, declaration.name.text);
      if (!callback) {
        if ((methodCounts.get(member.name.text) ?? 0) > 1) {
          recordTypeFailure(member);
          failedOverloadNames.add(member.name.text);
          continue;
        }
        recordTypeFailure(member);
        return undefined;
      }
      if ((methodCounts.get(member.name.text) ?? 0) > 1) {
        for (let index = target.length - 1; index >= 0; index -= 1) {
          if (target[index].kind === "method" && target[index].name === member.name.text) target.splice(index, 1);
        }
      }
      target.push({ kind: "method", name: member.name.text, callback });
      renderedMethodNames.add(member.name.text);
    } else if (ts.isIndexSignatureDeclaration(member) && member.parameters.length === 1 && member.parameters[0].type && member.type && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type, available, dependencies, typeParameters);
      const valueType = fsharpType(member.type, available, dependencies, typeParameters);
      if (!keyType || !valueType) {
        recordTypeFailure(member);
        return undefined;
      }
      target.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword) });
    } else if ((ts.isGetAccessorDeclaration(member) || ts.isSetAccessorDeclaration(member)) && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      const key = `${hasModifier(member, ts.SyntaxKind.StaticKeyword) ? "static" : "instance"}|${member.name.text}`;
      const accessor = accessors.get(key) ?? { kind: "accessor", name: member.name.text, static: hasModifier(member, ts.SyntaxKind.StaticKeyword), canGet: false, canSet: false };
      if (ts.isGetAccessorDeclaration(member)) {
        let type = member.type && ts.isTypeLiteralNode(member.type)
          ? inlineObjectType(member.type, available, dependencies, typeParameters, inlineTypes, `${declaration.name.text}Accessor${memberIndex + 1}`)
          : member.type ? fsharpType(member.type, available, dependencies, typeParameters) : undefined;
        if (!type) {
          recordTypeFailure(member);
          return undefined;
        }
        accessor.type = type;
        accessor.canGet = true;
      } else {
        const parameterType = member.parameters.length === 1 ? member.parameters[0].type : undefined;
        let type = parameterType && ts.isTypeLiteralNode(parameterType)
          ? inlineObjectType(parameterType, available, dependencies, typeParameters, inlineTypes, `${declaration.name.text}Accessor${memberIndex + 1}`)
          : parameterType ? fsharpType(parameterType, available, dependencies, typeParameters) : undefined;
        if (!type) {
          recordTypeFailure(member);
          return undefined;
        }
        accessor.setterType = type;
        if (!accessor.type) accessor.type = type;
        accessor.canSet = true;
      }
      accessors.set(key, accessor);
    } else {
      recordTypeFailure(member);
      return undefined;
    }
  }
  if ([...failedOverloadNames].some(name => !renderedMethodNames.has(name))) return undefined;
  for (const accessor of accessors.values()) {
    const target = accessor.static ? staticMembers : instanceMembers;
    if (accessor.canGet && accessor.canSet && accessor.setterType && accessor.type !== accessor.setterType) {
      target.push({ ...accessor, canSet: false });
      const setterName = accessor.name.replace(/(^|[^A-Za-z0-9]+)([A-Za-z0-9])/g, (_, __, character) => character.toUpperCase());
      target.push({ kind: "setterMethod", name: `set${setterName}`, emittedName: accessor.name, type: accessor.setterType });
    } else target.push(accessor);
  }
  if (constructorDeclarations.length === 0 && !hasBase && !hasModifier(declaration, ts.SyntaxKind.AbstractKeyword)) {
    constructors.push({ parameters: [], returnType: "unit" });
  }
  return { instanceMembers, staticMembers, constructors, nestedCallbacks, inlineTypes, genericConstraints, dependencies: [...dependencies] };
};
const renderBase = (declaration, available) => {
  const extendsTypes = (declaration.heritageClauses ?? [])
    .filter(clause => clause.token === ts.SyntaxKind.ExtendsKeyword)
    .flatMap(clause => [...clause.types]);
  if (extendsTypes.length === 0) {
    if (declaration.name?.text === "FlowGraphConnection") {
      const connectable = maintainedSymbols.get("IConnectable");
      if (!connectable || connectable.arity !== 0) return null;
      return { name: "IConnectable", rendered: connectable.fsharpSymbol, builtin: true };
    }
    return undefined;
  }
  if (extendsTypes.length !== 1 || !ts.isIdentifier(extendsTypes[0].expression)) return null;
  const name = extendsTypes[0].expression.text;
  if (name === "Error" && !(extendsTypes[0].typeArguments?.length)) {
    return { name: "JavaScriptError", rendered: "JavaScriptError", builtin: true };
  }
  if (name === "Array" && extendsTypes[0].typeArguments?.length === 1) {
    const dependencies = new Set();
    const typeParameters = new Set((declaration.typeParameters ?? []).map(parameter => parameter.name.text));
    const element = fsharpType(extendsTypes[0].typeArguments[0], available, dependencies, typeParameters);
    if (!element) return null;
    return { name: "JavaScriptArray", rendered: `System.Collections.Generic.IList<${element}>`, builtin: true, extraDependencies: [...dependencies] };
  }
  const mixinVariable = declaration.getSourceFile().statements
    .filter(ts.isVariableStatement)
    .flatMap(statement => [...statement.declarationList.declarations])
    .find(variable => ts.isIdentifier(variable.name) && variable.name.text === name);
  if (mixinVariable?.type && ts.isIntersectionTypeNode(mixinVariable.type)) {
    const constructorBranch = mixinVariable.type.types.find(branch => ts.isTypeLiteralNode(branch)
      && branch.members.length === 1
      && ts.isConstructSignatureDeclaration(branch.members[0])
      && ts.isTypeLiteralNode(branch.members[0].type));
    const baseBranch = mixinVariable.type.types.find(ts.isTypeQueryNode);
    const baseName = baseBranch && ts.isIdentifier(baseBranch.exprName) ? baseBranch.exprName.text : undefined;
    const baseTarget = baseName ? available.get(baseName) : undefined;
    if (constructorBranch && baseName && baseTarget && !extendsTypes[0].typeArguments?.length) {
      const instanceShape = constructorBranch.members[0].type;
      const dependencies = new Set();
      const digest = createHash("sha256").update(instanceShape.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12);
      const mixinType = inlineObjectType(instanceShape, available, dependencies, new Set(), utilityInlineTypes, `MixinBase${digest}`);
      if (!mixinType) return null;
      return {
        name: baseName,
        rendered: baseTarget.arity === 0 ? baseName : null,
        extraBases: [mixinType],
        extraDependencies: [...dependencies]
      };
    }
  }
  const target = available.get(name);
  if (!target) return null;
  const arguments_ = extendsTypes[0].typeArguments ?? [];
  if (arguments_.length !== target.arity) return null;
  const typeParameters = new Set((declaration.typeParameters ?? []).map(parameter => parameter.name.text));
  const renderedArguments = arguments_.map(argument => fsharpType(argument, available, new Set(), typeParameters));
  if (renderedArguments.some(argument => !argument)) return null;
  return {
    name,
    rendered: target.arity === 0 ? name : `${name}<${renderedArguments.join(", ")}>`
  };
};
const renderImplements = (declaration, available) => {
  const rendered = [];
  for (const heritage of (declaration.heritageClauses ?? []).filter(clause => clause.token === ts.SyntaxKind.ImplementsKeyword).flatMap(clause => clause.types)) {
    if (!ts.isIdentifier(heritage.expression)) continue;
    if (heritage.expression.text === "XRFrame" && !heritage.typeArguments?.length) {
      rendered.push({ source: "XRFrame", rendered: "BabylonjsBindings.SimpleInterfaces.BrowserXRFrame" });
      continue;
    }
    const target = maintainedSymbols.get(heritage.expression.text);
    if (target && heritage.expression.text === "WebXRRenderTarget" && target.arity === 2 && !heritage.typeArguments?.length) {
      rendered.push({
        source: "WebXRRenderTarget",
        rendered: `${target.fsharpSymbol}<Browser.Types.WebGLRenderingContext, BabylonjsBindings.SimpleInterfaces.BrowserXRWebGLLayer>`
      });
      continue;
    }
    if (!target || target.arity !== (heritage.typeArguments?.length ?? 0)) continue;
    const dependencies = new Set();
    const typeParameters = new Set((declaration.typeParameters ?? []).map(parameter => parameter.name.text));
    const arguments_ = (heritage.typeArguments ?? []).map(argument => fsharpType(argument, available, dependencies, typeParameters));
    if (arguments_.some(argument => !argument)) continue;
    rendered.push({
      source: heritage.getText().replace(/\s+/g, " "),
      rendered: arguments_.length ? `${target.fsharpSymbol}<${arguments_.join(", ")}>` : target.fsharpSymbol
    });
  }
  return rendered;
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
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    const runtimeExport = target.getName();
    declarations.set(`${packageName}|${module}|${name}`, {
      package: packageName,
      module,
      name,
      runtimeExport,
      declaration,
      arity: declaration.typeParameters?.length ?? 0,
      ...(deepImmutableTypeNames.has(name) ? { deepImmutableSymbol: `DeepImmutable${name}` } : {})
    });
  }
}
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath)) continue;
  const module = lockedPath.replace(/\.d\.ts$/, "");
  const packageName = module.startsWith("@babylonjs/core/")
    ? "@babylonjs/core"
    : module.startsWith("@babylonjs/loaders/")
      ? "@babylonjs/loaders"
      : undefined;
  if (!packageName) continue;
  for (const declaration of sourceFile.statements.filter(ts.isClassDeclaration)) {
    if (!declaration.name || hasModifier(declaration, ts.SyntaxKind.ExportKeyword)) continue;
    const name = declaration.name.text;
    declarations.set(`${packageName}|${module}|${name}`, {
      package: packageName,
      module,
      name,
      declaration,
      arity: declaration.typeParameters?.length ?? 0,
      supportOnly: true,
      ...(deepImmutableTypeNames.has(name) ? { deepImmutableSymbol: `DeepImmutable${name}` } : {})
    });
  }
}

const nameCounts = new Map();
for (const entry of declarations.values()) nameCounts.set(entry.name, (nameCounts.get(entry.name) ?? 0) + 1);
const selected = new Map();
const selectedByName = new Map();
const available = new Map();
let rank = 0;
while (true) {
  const additions = [];
  for (const [identity, entry] of declarations) {
    if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
    const base = renderBase(entry.declaration, available);
    if (base === null) continue;
    const renderAvailable = new Map(available);
    renderAvailable.set(entry.name, { arity: entry.arity, deepImmutableSymbol: entry.deepImmutableSymbol });
    const rendered = renderClass(entry.declaration, renderAvailable, Boolean(base));
    if (!rendered) continue;
    if (base && !base.builtin && entry.declaration.members.every(member => !ts.isConstructorDeclaration(member))) {
      rendered.constructors = selectedByName.get(base.name).constructors.map(constructor => ({ ...constructor }));
    }
    additions.push([identity, { ...entry, ...rendered, base, rank }]);
  }
  if (additions.length === 0) break;
  for (const [identity, entry] of additions) {
    selected.set(identity, entry);
    selectedByName.set(entry.name, entry);
    available.set(entry.name, { arity: entry.arity, deepImmutableSymbol: entry.deepImmutableSymbol });
  }
  rank += 1;
}

// The maintained build projects aliases, interfaces, and classes through a
// single `namespace rec` file. Use that recursive boundary to admit a closed
// class dependency graph in one reviewed batch instead of requiring every
// edge to have been selected in an earlier rank.
const optimisticAvailable = new Map(available);
for (const entry of declarations.values()) {
  if (nameCounts.get(entry.name) === 1) optimisticAvailable.set(entry.name, { arity: entry.arity, deepImmutableSymbol: entry.deepImmutableSymbol });
}
const retainedNumericLiterals = new Set(numericLiteralValues);
const retainedStringLiterals = new Map(stringLiteralTypes);
const retainedUtilityInlineTypeCount = utilityInlineTypes.length;
const retainedUtilityConstructorTypeCount = utilityConstructorTypes.length;
const recursiveCandidates = new Map();
for (const [identity, entry] of declarations) {
  if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
  const base = renderBase(entry.declaration, optimisticAvailable);
  if (base === null) continue;
  const rendered = renderClass(entry.declaration, optimisticAvailable, Boolean(base));
  if (!rendered) continue;
  recursiveCandidates.set(entry.name, { identity, entry, base, rendered });
}
const recursivelyClosedNames = new Set(recursiveCandidates.keys());
while (true) {
  const rejected = [...recursivelyClosedNames].filter(name => {
    const candidate = recursiveCandidates.get(name);
    const dependencies = [
      ...(candidate.base && !candidate.base.builtin ? [candidate.base.name] : []),
      ...(candidate.base?.extraDependencies ?? []),
      ...candidate.rendered.dependencies
    ];
    return dependencies.some(dependency => !available.has(dependency) && !recursivelyClosedNames.has(dependency));
  });
  if (rejected.length === 0) break;
  for (const name of rejected) recursivelyClosedNames.delete(name);
}
numericLiteralValues.clear();
for (const value of retainedNumericLiterals) numericLiteralValues.add(value);
stringLiteralTypes.clear();
for (const [name, value] of retainedStringLiterals) stringLiteralTypes.set(name, value);
utilityInlineTypes.length = retainedUtilityInlineTypeCount;
utilityConstructorTypes.length = retainedUtilityConstructorTypeCount;
for (const name of recursivelyClosedNames) {
  const candidate = recursiveCandidates.get(name);
  candidate.base = renderBase(candidate.entry.declaration, optimisticAvailable);
  candidate.rendered = renderClass(candidate.entry.declaration, optimisticAvailable, Boolean(candidate.base));
}
const recursiveConstructors = name => {
  const candidate = recursiveCandidates.get(name);
  if (!candidate || !recursivelyClosedNames.has(name)) return selectedByName.get(name)?.constructors ?? [];
  if (candidate.rendered.constructors.length > 0 || !candidate.base || candidate.base.builtin) return candidate.rendered.constructors;
  return recursiveConstructors(candidate.base.name).map(constructor => ({ ...constructor }));
};
for (const name of [...recursivelyClosedNames].sort()) {
  const candidate = recursiveCandidates.get(name);
  if (candidate.base && !candidate.base.builtin && candidate.entry.declaration.members.every(member => !ts.isConstructorDeclaration(member))) {
    candidate.rendered.constructors = recursiveConstructors(candidate.base.name);
  }
  const promoted = { ...candidate.entry, ...candidate.rendered, base: candidate.base, rank };
  selected.set(candidate.identity, promoted);
  selectedByName.set(name, promoted);
  available.set(name, { arity: promoted.arity, deepImmutableSymbol: promoted.deepImmutableSymbol });
}
const entries = [...selected.values()].sort((left, right) => left.rank - right.rank || left.name.localeCompare(right.name));
for (const entry of entries) {
  entry.implementedBases = renderImplements(entry.declaration, available)
    .filter(implemented => implemented.rendered !== entry.base?.rendered);
  entry.declaration.__projectedImplements = entry.implementedBases.map(implemented => implemented.source);
}
const promotionSymbolIndex = await loadPromotionSymbolIndex(root, [
  "generated-candidates/SimpleAliases.promotion.json",
  "generated-candidates/SimpleInterfaces.promotion.json"
]);
const candidateClassSymbols = new Map(entries.map(entry => [entry.name, `BabylonjsBindings.SimpleClasses.${entry.name}`]));
if (diagnose) {
  const optimistic = new Map([...declarations.values()]
    .filter(entry => nameCounts.get(entry.name) === 1)
    .map(entry => [entry.name, { arity: entry.arity, deepImmutableSymbol: entry.deepImmutableSymbol }]));
  const shapeReady = [];
  const shapeReadyDependencies = new Map();
  const missingCounts = new Map();
  const singleMissing = [];
  collectTypeFailures = true;
  for (const [identity, entry] of declarations) {
    if (selected.has(identity) || nameCounts.get(entry.name) !== 1) continue;
    diagnosedClass = entry.name;
    const base = renderBase(entry.declaration, optimistic);
    if (base === null) {
      const failures = typeFailuresByClass.get(entry.name) ?? new Set();
      const heritage = (entry.declaration.heritageClauses ?? [])
        .filter(clause => clause.token === ts.SyntaxKind.ExtendsKeyword)
        .map(clause => clause.getText(entry.declaration.getSourceFile()).replace(/\s+/g, " "))
        .join(", ");
      failures.add(`Unrenderable base: ${heritage || "unknown"}`);
      typeFailuresByClass.set(entry.name, failures);
    }
    const rendered = base !== null ? renderClass(entry.declaration, optimistic, Boolean(base)) : undefined;
    if (rendered) {
      shapeReady.push(entry.name);
      const missing = [...new Set([...(base && !available.has(base.name) ? [base.name] : []), ...(base?.extraDependencies ?? []).filter(name => !available.has(name)), ...rendered.dependencies.filter(name => !available.has(name))])];
      shapeReadyDependencies.set(entry.name, missing);
      for (const name of missing) missingCounts.set(name, (missingCounts.get(name) ?? 0) + 1);
      if (missing.length === 1) singleMissing.push(`${entry.name} <- ${missing[0]}`);
    }
  }
  diagnosedClass = undefined;
  collectTypeFailures = false;
  console.log("top unresolved class member types:");
  console.log([...typeFailureCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 80).map(([type, count]) => `${count} ${type}`).join("\n"));
  console.log("unresolved member types by class:");
  console.log([...typeFailuresByClass].sort(([left], [right]) => left.localeCompare(right)).map(([name, failures]) => `${name}: ${[...failures].join(" | ")}`).join("\n"));
  console.log(`diagnostic: ${shapeReady.length} additional classes have renderable member shapes but unresolved dependency cycles`);
  console.log("top unresolved class dependencies:");
  console.log([...missingCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 40).map(([name, count]) => `${name} ${count}`).join("\n"));
  console.log("single unresolved dependency:");
  console.log(singleMissing.sort().slice(0, 200).join("\n"));
  console.log("foundational math dependency chains:");
  console.log(["Vector2", "Vector3", "Vector4", "Quaternion", "Matrix", "Plane", "Color3", "Color4"]
    .filter(name => shapeReadyDependencies.has(name))
    .map(name => `${name} <- ${shapeReadyDependencies.get(name).join(", ")}`)
    .join("\n"));
  const unrenderableDependencyCounts = new Map();
  for (const dependencies of shapeReadyDependencies.values()) {
    for (const dependency of dependencies) {
      if (!available.has(dependency) && !shapeReadyDependencies.has(dependency)) {
        unrenderableDependencyCounts.set(dependency, (unrenderableDependencyCounts.get(dependency) ?? 0) + 1);
      }
    }
  }
  console.log("top directly unrenderable class dependencies:");
  const unrenderableDependencies = [...unrenderableDependencyCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0]));
  console.log(unrenderableDependencies.slice(0, 80).map(([name, count]) => `${name} ${count}`).join("\n"));
  console.log("failure types for highest-impact unrenderable classes:");
  console.log(unrenderableDependencies.slice(0, 20).map(([name, count]) => `${name} (${count} downstream): ${[...(typeFailuresByClass.get(name) ?? [])].slice(0, 8).join(" | ") || "non-type member shape"}`).join("\n"));
  console.log("failure types for foundational class bridge targets:");
  console.log(["Node", "TransformNode", "FlowGraphContext", "Scene", "AbstractEngine", "Buffer", "VertexBuffer", "Vector2", "Vector3", "Vector4", "Quaternion", "Matrix", "Plane", "WebGPUEngine", "WebGPUBufferManager", "WebGPUHardwareTexture", "WebGPUPipelineContext", "WebGPUTimestampQuery", "AudioEngineV2", "_WebAudioEngine", "AudioBus", "MainAudioBus", "_WebAudioStaticSound", "_WebAudioStreamingSound", "WorkerPool", "AutoReleaseWorkerPool", "TransmissionHelper", "InteractivityGraphToFlowGraphParser"]
    .map(name => {
      const identities = [...declarations].filter(([, entry]) => entry.name === name).map(([identity]) => identity);
      const missing = shapeReadyDependencies.get(name) ?? [];
      const state = `declarations=${identities.length}, selected=${identities.filter(identity => selected.has(identity)).length}, recursive=${recursiveCandidates.has(name)}, missing=${missing.join(",") || "none"}`;
      return `${name} (${state}): ${[...(typeFailuresByClass.get(name) ?? [])].slice(0, 12).join(" | ") || "non-type member shape"}`;
    })
    .join("\n"));
  const closedNames = new Set(shapeReady);
  while (true) {
    const rejected = [...closedNames].filter(name => shapeReadyDependencies.get(name).some(dependency => !available.has(dependency) && !closedNames.has(dependency)));
    if (rejected.length === 0) break;
    for (const name of rejected) closedNames.delete(name);
  }
  const indices = new Map();
  const lowLinks = new Map();
  const stack = [];
  const onStack = new Set();
  const components = [];
  let nextIndex = 0;
  const visit = name => {
    indices.set(name, nextIndex);
    lowLinks.set(name, nextIndex);
    nextIndex += 1;
    stack.push(name);
    onStack.add(name);
    for (const dependency of shapeReadyDependencies.get(name).filter(value => closedNames.has(value))) {
      if (!indices.has(dependency)) {
        visit(dependency);
        lowLinks.set(name, Math.min(lowLinks.get(name), lowLinks.get(dependency)));
      } else if (onStack.has(dependency)) {
        lowLinks.set(name, Math.min(lowLinks.get(name), indices.get(dependency)));
      }
    }
    if (lowLinks.get(name) === indices.get(name)) {
      const component = [];
      while (true) {
        const member = stack.pop();
        onStack.delete(member);
        component.push(member);
        if (member === name) break;
      }
      components.push(component.sort());
    }
  };
  for (const name of [...closedNames].sort()) if (!indices.has(name)) visit(name);
  const componentByName = new Map(components.flatMap((component, index) => component.map(name => [name, index])));
  const foundations = components.filter((component, index) => component.every(name => shapeReadyDependencies.get(name).every(dependency => available.has(dependency) || componentByName.get(dependency) === index)));
  console.log(`closed renderable dependency graph: ${closedNames.size} classes in ${components.length} strongly connected components`);
  console.log("smallest foundational components:");
  console.log(foundations.sort((left, right) => left.length - right.length || left[0].localeCompare(right[0])).slice(0, 40).map(component => `${component.length}: ${component.join(", ")}`).join("\n"));
}
const selectedByClassName = new Map(entries.map(entry => [entry.name, entry]));
const projectedClassNames = new Set(entries.filter(entry => entry.deepImmutableSymbol).map(entry => entry.name));
while (true) {
  const additions = [...projectedClassNames]
    .map(name => selectedByClassName.get(name)?.base)
    .filter(base => base && !base.builtin && selectedByClassName.has(base.name) && !projectedClassNames.has(base.name))
    .map(base => base.name);
  if (additions.length === 0) break;
  for (const name of additions) projectedClassNames.add(name);
}
const escapeRegExp = value => value.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");
const deepImmutableFsharpType = type => {
  if (type.endsWith(" option")) return `${deepImmutableFsharpType(type.slice(0, -" option".length))} option`;
  if (type.startsWith("ResizeArray<") && type.endsWith(">")) {
    return `System.Collections.Generic.IReadOnlyList<${deepImmutableFsharpType(type.slice("ResizeArray<".length, -1))}>`;
  }
  let rendered = type;
  for (const target of maintainedSymbols.values()) {
    if (target.deepImmutableSymbol) rendered = rendered.replace(new RegExp(escapeRegExp(target.fsharpSymbol), "g"), target.deepImmutableSymbol);
  }
  for (const name of projectedClassNames) rendered = rendered.replace(new RegExp(`\\b${escapeRegExp(name)}\\b`, "g"), `DeepImmutable${name}`);
  return rendered;
};
const pascal = value => value.replace(/(^|[^A-Za-z0-9]+)([A-Za-z0-9])/g, (_, __, character) => character.toUpperCase());
const callbackArguments = callback => callback.parameters.length === 0
  ? "unit"
  : callback.parameters.map(parameter => `${parameter.paramArray ? "[<System.ParamArray>] " : ""}${parameter.optional ? "?" : ""}\`\`${parameter.name}\`\`: ${parameter.type}`).join(" * ");
const delegateType = callback => {
  return directDelegateType(callback);
};
const renderMember = member => {
  if (member.kind === "property") return `abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`;
  if (member.kind === "accessor") return `abstract \`\`${member.name}\`\`: ${member.type} with ${member.canGet ? "get" : ""}${member.canGet && member.canSet ? ", " : ""}${member.canSet ? "set" : ""}`;
  if (member.kind === "callbackProperty") return `abstract \`\`${member.name}\`\`: ${member.helperName}${member.optional ? " option" : ""} with get${member.readonly ? "" : ", set"}`;
  if (member.kind === "indexer") return `[<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`;
  if (member.kind === "setterMethod") return `[<Emit("$0.${member.emittedName} = $1")>] abstract \`\`${member.name}\`\`: value: ${member.type} -> unit`;
  return `abstract \`\`${member.name}\`\`${member.callback.genericParameters} : ${callbackArguments(member.callback)} -> ${member.callback.returnType}`;
};
const renderDeepImmutableMember = member => {
  if (member.kind === "setterMethod") return undefined;
  if (member.kind === "property" || member.kind === "accessor") return `abstract \`\`${member.name}\`\`: ${deepImmutableFsharpType(member.type)} with get`;
  if (member.kind === "callbackProperty") return `abstract \`\`${member.name}\`\`: ${member.helperName}${member.optional ? " option" : ""} with get`;
  if (member.kind === "indexer") return `[<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${deepImmutableFsharpType(member.valueType)} with get`;
  return renderMember(member);
};
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after class review, compile, import, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact dependency-closed runtime classes exported by Babylon.js 9.19.0.",
  "module SimpleClasses =",
  "",
  "    /// Structural instance surface of the standard JavaScript Error base class.",
  "    [<AllowNullLiteral>]",
  "    type JavaScriptError =",
  "        abstract name: string with get, set",
  "        abstract message: string with get, set",
  "        abstract stack: string option with get, set",
  "        abstract cause: obj option with get, set"
];
lines.push("", "    /// Uninhabited return marker for TypeScript `never` members.", "    type Never = private Never of unit");
lines.push("", "    /// JavaScript constructor object compatible with `new (...args: any[]) => T`.", "    [<AllowNullLiteral>]", "    type Constructor<'T> =", "        [<EmitConstructor>] abstract Create: [<System.ParamArray>] args: obj[] -> 'T");
lines.push("", "    /// Exact read-only JavaScript tuple shape with one element.", "    [<AllowNullLiteral>]", "    type ReadonlyTuple1<'T> =", "        [<Emit(\"$0[0]\")>] abstract Item1: 'T");
for (const [value, name] of flowGraphAssetKinds) {
  lines.push("", `    /// Exact ${value} discriminator accepted by FlowGraphContext.getAsset.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, `        | [<CompiledName(${fsharpString(value)})>] Value`);
}
for (const [value, name] of xmlHttpRequestEventKinds) {
  lines.push("", `    /// Exact ${value} event discriminator accepted by WebRequest.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, `        | [<CompiledName(${fsharpString(value)})>] Value`);
}
lines.push("", "    /// Exact metadata properties accepted by PerformanceViewerCollector.updateMetadata.", "    [<StringEnum; RequireQualifiedAccess>]", "    type PerfMetadataProperty =", ...perfMetadataKinds.map(([value]) => `        | [<CompiledName(${fsharpString(value)})>] ${value[0].toUpperCase()}${value.slice(1)}`));
for (const [value, name] of perfMetadataKinds) {
  lines.push("", `    /// Exact ${value} metadata-property discriminator.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, `        | [<CompiledName(${fsharpString(value)})>] Value`);
}
for (const value of [...numericLiteralValues].sort((left, right) => left - right)) {
  const name = `NumericLiteral${value < 0 ? `Negative${Math.abs(value)}` : value}`;
  lines.push("", `    /// Exact numeric literal type for ${value}.`, `    type ${name} =`, `        | Value = ${value}`);
}
for (const [name, value] of [...stringLiteralTypes].sort(([left], [right]) => left.localeCompare(right))) {
  lines.push("", `    /// Exact string literal type for ${fsharpString(value)}.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, `        | [<CompiledName(${fsharpString(value)})>] Value`);
}
for (const [name, members] of [...internalEnumTypes].sort(([left], [right]) => left.localeCompare(right))) {
  lines.push("", "    /// Exact internal numeric enum required by a Babylon class signature.", `    type ${name} =`);
  for (const member of members) lines.push(`        | ${member.name} = ${member.value}`);
}
let classUtilityReferenceText = JSON.stringify(entries.map(entry => ({ instanceMembers: entry.instanceMembers, staticMembers: entry.staticMembers, constructors: entry.constructors, base: entry.base, inlineTypes: entry.inlineTypes, genericConstraints: entry.genericConstraints })));
const retainedClassUtilityInlineTypes = [];
while (true) {
  const additions = utilityInlineTypes.filter(inline => !retainedClassUtilityInlineTypes.includes(inline) && classUtilityReferenceText.includes(inline.name));
  if (additions.length === 0) break;
  retainedClassUtilityInlineTypes.push(...additions);
  classUtilityReferenceText += JSON.stringify(additions);
}
for (const inline of retainedClassUtilityInlineTypes) {
  lines.push("", "    /// Inline object shape used by a TypeScript utility projection.", "    [<AllowNullLiteral>]", `    type ${inline.name}${inline.genericParameters} =`);
  for (const base of inline.bases ?? []) lines.push(`        inherit ${base}`);
  if (inline.members.length === 0 && !(inline.bases?.length)) lines.push("        interface end");
  else for (const member of inline.members) lines.push(`        ${renderMember(member)}`);
}
for (const constructorType of utilityConstructorTypes.filter(type => classUtilityReferenceText.includes(type.name))) {
  lines.push("", "    /// Exact typed JavaScript constructor object used by a Babylon signature.", "    [<AllowNullLiteral>]", `    type ${constructorType.name}${constructorType.genericParameters} =`, `        [<EmitConstructor>] abstract Create: ${callbackArguments({ parameters: constructorType.parameters })} -> ${constructorType.returnType}`);
}
for (const entry of entries) {
  const genericParameterNames = entry.declaration.typeParameters?.map(parameter => `'${parameter.name.text}`) ?? [];
  const genericParameters = entry.arity
    ? `<${genericParameterNames.join(", ")}${entry.genericConstraints.length ? ` when ${entry.genericConstraints.join(" and ")}` : ""}>`
    : "";
  const genericArguments = entry.arity ? `<${genericParameterNames.join(", ")}>` : "";
  for (const inline of entry.inlineTypes) {
    lines.push("", `    /// Inline object shape used by ${entry.name}.`, "    [<AllowNullLiteral>]", `    type ${inline.name}${inline.genericParameters} =`);
    for (const base of inline.bases ?? []) lines.push(`        inherit ${base}`);
    if (inline.members.length === 0 && !(inline.bases?.length)) lines.push("        interface end");
    else for (const member of inline.members) lines.push(`        ${renderMember(member)}`);
  }
  const retainedCallbacks = [...entry.constructors, ...entry.instanceMembers.map(member => member.callback), ...entry.staticMembers.map(member => member.callback)].filter(Boolean);
  const usedNestedCallbacks = entry.nestedCallbacks.filter(nested => retainedCallbacks.some(callback => callback.parameters.some(parameter => parameter.type.includes(nested.name))));
  for (const nested of usedNestedCallbacks) {
    lines.push("", `    /// Uncurried function-valued argument used by ${entry.name}.`, `    type ${nested.name}${nested.genericParameters} = ${delegateType(nested.callback)}`);
  }
  for (const member of [...entry.instanceMembers, ...entry.staticMembers].filter(member => member.kind === "callbackProperty")) {
    const helperName = `${entry.name}${pascal(member.name)}Callback`;
    const callbackText = JSON.stringify(member.callback);
    const helperGenericNames = genericParameterNames.filter(name => callbackText.includes(name));
    const helperConstraints = entry.genericConstraints.filter(constraint => helperGenericNames.some(name => constraint.startsWith(`${name} `)));
    const helperGenericParameters = helperGenericNames.length ? `<${helperGenericNames.join(", ")}${helperConstraints.length ? ` when ${helperConstraints.join(" and ")}` : ""}>` : "";
    const helperGenericArguments = helperGenericNames.length ? `<${helperGenericNames.join(", ")}>` : "";
    member.helperName = `${helperName}${helperGenericArguments}`;
    lines.push("", `    /// Function-valued ${entry.name}.${member.name} property.`, "    [<AllowNullLiteral>]", `    type ${helperName}${helperGenericParameters} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
  }
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${entry.name}${genericParameters} =`);
  if (entry.base) lines.push(`        inherit ${entry.base.rendered}`);
  for (const extraBase of entry.base?.extraBases ?? []) lines.push(`        inherit ${extraBase}`);
  for (const implemented of entry.implementedBases) lines.push(`        inherit ${implemented.rendered}`);
  if (["InternalTexture", "Camera", "FrameGraphObjectList"].includes(entry.name)) lines.push("        inherit BabylonjsBindings.TypeAliases.NodeRenderGraphValue");
  if (entry.instanceMembers.length === 0 && !entry.base && entry.implementedBases.length === 0) lines.push("        interface end");
  else for (const member of entry.instanceMembers) lines.push(`        ${renderMember(member)}`);
  if (projectedClassNames.has(entry.name)) {
    lines.push("", `    /// Exact readonly projection of ${entry.name} used by Babylon DeepImmutable<${entry.name}> signatures.`, "    [<AllowNullLiteral>]", `    type DeepImmutable${entry.name}${genericParameters} =`);
    if (entry.base) lines.push(`        inherit ${entry.base.builtin ? entry.base.rendered : `DeepImmutable${entry.base.rendered}`}`);
    for (const extraBase of entry.base?.extraBases ?? []) lines.push(`        inherit ${extraBase}`);
    if (entry.instanceMembers.length === 0 && !entry.base) lines.push("        interface end");
    else for (const member of entry.instanceMembers) {
      const rendered = renderDeepImmutableMember(member);
      if (rendered) lines.push(`        ${rendered}`);
    }
  }
  lines.push("", "    [<AllowNullLiteral>]", `    type ${entry.name}Static =`);
  if (entry.base && !entry.base.builtin) lines.push(`        inherit ${entry.base.name}Static`);
  if (entry.arity === 0 && entry.constructors.length > 0) lines.push(`        inherit Constructor<${entry.name}>`);
  if (entry.constructors.length === 0 && entry.staticMembers.length === 0 && (!entry.base || entry.base.builtin)) lines.push("        interface end");
  for (const constructor of entry.constructors) lines.push(`        [<EmitConstructor>] abstract Create${genericParameters}: ${callbackArguments(constructor)} -> ${entry.name}${genericArguments}`);
  for (const member of entry.staticMembers) lines.push(`        ${renderMember(member)}`);
  if (entry.supportOnly) continue;
  lines.push("", `    [<Import("${entry.runtimeExport}", "${entry.module}.js")>]`, `    let ${entry.name}: ${entry.name}Static = jsNative`);
}
const proposal = `${lines.join("\n")}\n`;
const hasIdentityPartialProjection = entry => {
  if ((entry.declaration.heritageClauses ?? []).some(clause => clause.token === ts.SyntaxKind.ExtendsKeyword)) return false;
  const publicInstanceMembers = entry.declaration.members.filter(member =>
    !inaccessible(member)
    && !hasModifier(member, ts.SyntaxKind.StaticKeyword)
    && !ts.isConstructorDeclaration(member));
  return publicInstanceMembers.length > 0
    && publicInstanceMembers.every(member => ts.isPropertyDeclaration(member) && Boolean(member.questionToken));
};
const manifest = {
  schemaVersion: 1,
  source: { declarationLock: "declaration-lock.json", packageVersion: "9.19.0" },
  proposalSha256: sha256(proposal),
  exports: entries.filter(entry => !entry.supportOnly).map(entry => ({
    package: entry.package,
    module: entry.module,
    name: entry.name,
    ...(entry.runtimeExport !== entry.name ? { runtimeExport: entry.runtimeExport } : {}),
    kind: "class",
    disposition: "typed",
    fsharpSymbol: `BabylonjsBindings.SimpleClasses.${entry.name}`,
    fidelityIssues: classFidelityIssues(entry.declaration),
    genericDefaults: classGenericDefaults(entry.declaration),
    structuralImplements: classStructuralImplements(entry.declaration),
    dependencies: referencedPromotionSymbols(
      {
        instanceMembers: entry.instanceMembers,
        staticMembers: entry.staticMembers,
        constructors: entry.constructors,
        inlineTypes: entry.inlineTypes,
        genericConstraints: entry.genericConstraints,
        base: entry.base,
        implementedBases: entry.implementedBases
      },
      promotionSymbolIndex,
      `BabylonjsBindings.SimpleClasses.${entry.name}`,
      [...new Set([
        ...(entry.dependencies ?? []),
        ...(entry.base && !entry.base.builtin ? [entry.base.name] : []),
        ...(entry.base?.extraDependencies ?? [])
      ])].map(name => candidateClassSymbols.get(name))
    ),
    ...(entry.arity ? { typeParameterCount: entry.arity } : {}),
    ...(projectedClassNames.has(entry.name) ? { deepImmutableSymbol: `BabylonjsBindings.SimpleClasses.DeepImmutable${entry.name}` } : {}),
    ...(hasIdentityPartialProjection(entry) ? { partialSymbol: `BabylonjsBindings.SimpleClasses.${entry.name}` } : {}),
    memberCount: entry.instanceMembers.length + entry.staticMembers.length + entry.constructors.length
  })),
  supportTypes: entries.filter(entry => entry.supportOnly).map(entry => ({
    package: entry.package,
    module: entry.module,
    name: entry.name,
    kind: "class-support",
    fsharpSymbol: `BabylonjsBindings.SimpleClasses.${entry.name}`,
    fidelityIssues: classFidelityIssues(entry.declaration),
    genericDefaults: classGenericDefaults(entry.declaration),
    structuralImplements: classStructuralImplements(entry.declaration),
    dependencies: referencedPromotionSymbols(
      {
        instanceMembers: entry.instanceMembers,
        staticMembers: entry.staticMembers,
        constructors: entry.constructors,
        inlineTypes: entry.inlineTypes,
        genericConstraints: entry.genericConstraints,
        base: entry.base,
        implementedBases: entry.implementedBases
      },
      promotionSymbolIndex,
      `BabylonjsBindings.SimpleClasses.${entry.name}`,
      [...new Set([
        ...(entry.dependencies ?? []),
        ...(entry.base && !entry.base.builtin ? [entry.base.name] : []),
        ...(entry.base?.extraDependencies ?? [])
      ])].map(name => candidateClassSymbols.get(name))
    ),
    ...(entry.arity ? { typeParameterCount: entry.arity } : {}),
    ...(projectedClassNames.has(entry.name) ? { deepImmutableSymbol: `BabylonjsBindings.SimpleClasses.DeepImmutable${entry.name}` } : {}),
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
console.log(`generated reviewed-promotion proposal for ${manifest.exports.length} exact dependency-closed classes plus ${entries.filter(entry => entry.supportOnly).length} internal support types (${sha256(proposal)})`);
