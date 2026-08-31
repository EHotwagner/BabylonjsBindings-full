import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { relative, resolve, sep } from "node:path";
import ts from "typescript";
import { loadPromotionSymbolIndex, referencedPromotionSymbols } from "./promotion-dependencies.mjs";

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
const failedVariables = new Map();
let diagnosedVariable;
const recordTypeFailure = node => {
  if (!diagnose) return;
  const text = node.getText().replace(/\s+/g, " ");
  const key = `${ts.SyntaxKind[node.kind]}: ${text.length > 160 ? `${text.slice(0, 157)}...` : text}`;
  typeFailureCounts.set(key, (typeFailureCounts.get(key) ?? 0) + 1);
  if (diagnosedVariable) {
    const failures = failedVariables.get(diagnosedVariable) ?? new Set();
    failures.add(key);
    failedVariables.set(diagnosedVariable, failures);
  }
};

const dependencyManifestPaths = [
  "src/BabylonjsBindings/coverage-manifest.json",
  "src/BabylonjsBindings/string-coverage-manifest.json",
  "src/BabylonjsBindings/object-type-coverage-manifest.json",
  "generated-candidates/SimpleAliases.promotion.json",
  "generated-candidates/SimpleInterfaces.promotion.json",
  "generated-candidates/SimpleClasses.promotion.json",
  "generated-candidates/SimpleFunctions.promotion.json"
];
const dependencyExports = (await Promise.all(dependencyManifestPaths.map(async path => JSON.parse(await readFile(resolve(root, path), "utf8")))))
  .flatMap(manifest => [...(manifest.exports ?? []), ...(manifest.supportTypes ?? [])]);
const dependencyNameCounts = new Map();
for (const entry of dependencyExports) dependencyNameCounts.set(entry.name, (dependencyNameCounts.get(entry.name) ?? 0) + 1);
const maintainedSymbols = new Map(dependencyExports
  .filter(entry => dependencyNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { fsharpSymbol: entry.fsharpSymbol, fsharpType: entry.fsharpType, deepImmutableSymbol: entry.deepImmutableSymbol, partialSymbol: entry.partialSymbol, arity: entry.typeParameterCount ?? 0 }]));

const isAbsentType = node => node.kind === ts.SyntaxKind.UndefinedKeyword
  || (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword);
const asOption = type => type.endsWith(" option") ? type : `${type} option`;
const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "DataView", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
const browserTypes = new Set([
  "AudioBuffer", "AudioContext", "AudioNode", "Blob", "Event", "File", "HTMLElement", "HTMLCanvasElement", "HTMLImageElement", "HTMLVideoElement", "KeyboardEvent",
  "ImageData", "OfflineAudioContext", "WebGLUniformLocation", "WebGLRenderingContext",
  "WebGLProgram", "WebGLShader", "WebGLBuffer", "WebGLTexture", "WebGLFramebuffer", "WebGLRenderbuffer",
]);
const initializerType = node => {
  if (ts.isNumericLiteral(node) || (ts.isPrefixUnaryExpression(node) && ts.isNumericLiteral(node.operand))) return "float";
  if (ts.isStringLiteral(node) || ts.isNoSubstitutionTemplateLiteral(node)) return "string";
  if (node.kind === ts.SyntaxKind.TrueKeyword || node.kind === ts.SyntaxKind.FalseKeyword) return "bool";
  return undefined;
};
const fsharpType = node => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.NeverKeyword) return "BabylonjsBindings.SimpleClasses.Never";
  if (node.kind === ts.SyntaxKind.ObjectKeyword) return "BabylonjsBindings.SimpleInterfaces.JavaScriptObject";
  if (node.kind === ts.SyntaxKind.SymbolKeyword) return "BabylonjsBindings.SimpleInterfaces.BrowserSymbol";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isLiteralTypeNode(node) && ts.isNumericLiteral(node.literal)) return "float";
  if (ts.isLiteralTypeNode(node) && ts.isStringLiteral(node.literal)) return "string";
  if (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.TrueKeyword) return "BabylonjsBindings.SimpleInterfaces.BrowserTrue";
  if (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.FalseKeyword) return "BabylonjsBindings.SimpleInterfaces.BrowserFalse";
  if (ts.isTypePredicateNode(node)) return "bool";
  if (ts.isParenthesizedTypeNode(node)) return fsharpType(node.type);
  if (ts.isTypeOperatorNode(node) && node.operator === ts.SyntaxKind.ReadonlyKeyword) {
    if (ts.isArrayTypeNode(node.type)) {
      const element = fsharpType(node.type.elementType);
      return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
    }
    return fsharpType(node.type);
  }
  if (ts.isUnionTypeNode(node) && node.types.length === 2 && node.types.filter(isAbsentType).length === 1) {
    const inner = fsharpType(node.types.find(branch => !isAbsentType(branch)));
    return inner ? asOption(inner) : undefined;
  }
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
  if (ts.isFunctionTypeNode(node)
    && !node.typeParameters?.length
    && !node.parameters.some(parameter => parameter.dotDotDotToken)) {
    const parameterTypes = node.parameters.map(parameter => {
      const rendered = parameter.type ? fsharpType(parameter.type) : undefined;
      return parameter.questionToken && rendered ? asOption(rendered) : rendered;
    });
    const returnType = fsharpType(node.type);
    if (returnType && parameterTypes.every(Boolean)) {
      if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
      return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
    }
  }
  if (ts.isTypeLiteralNode(node)
    && node.members.length === 1
    && ts.isCallSignatureDeclaration(node.members[0])
    && !node.members[0].typeParameters?.length
    && !node.members[0].parameters.some(parameter => parameter.dotDotDotToken)
    && node.members[0].type) {
    const call = node.members[0];
    const parameterTypes = call.parameters.map(parameter => {
      const rendered = parameter.type ? fsharpType(parameter.type) : undefined;
      return parameter.questionToken && rendered ? asOption(rendered) : rendered;
    });
    const returnType = fsharpType(call.type);
    if (returnType && parameterTypes.every(Boolean)) {
      if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
      return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
    }
  }
  if (ts.isImportTypeNode(node)
    && node.qualifier
    && ts.isIdentifier(node.qualifier)
    && !node.typeArguments?.length) {
    const target = maintainedSymbols.get(node.qualifier.text);
    if (target?.arity === 0) return target.fsharpSymbol;
  }
  if (ts.isTypeQueryNode(node)) {
    const maintained = ts.isIdentifier(node.exprName) ? maintainedSymbols.get(node.exprName.text)?.fsharpType : undefined;
    if (maintained) return maintained;
    let symbol = checker.getSymbolAtLocation(node.exprName);
    if (symbol?.flags & ts.SymbolFlags.Alias) {
      try { symbol = checker.getAliasedSymbol(symbol); } catch { return undefined; }
    }
    const declarations = symbol?.declarations?.filter(declaration => ts.isFunctionDeclaration(declaration)
      || ts.isMethodDeclaration(declaration)
      || ts.isMethodSignature(declaration)) ?? [];
    if (declarations.length !== 1) return undefined;
    const callable = declarations[0];
    if (!callable.type
      || callable.typeParameters?.length
      || callable.parameters.some(parameter => parameter.dotDotDotToken || (ts.isIdentifier(parameter.name) && parameter.name.text === "this"))) return undefined;
    const parameterTypes = callable.parameters.map(parameter => {
      const rendered = parameter.type ? fsharpType(parameter.type) : undefined;
      return parameter.questionToken && rendered ? asOption(rendered) : rendered;
    });
    const returnType = fsharpType(callable.type);
    if (!returnType || parameterTypes.some(parameter => !parameter)) return undefined;
    if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
    return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (!node.typeArguments?.length && node.typeName.text === "SerializableContext") return "BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext";
    if (!node.typeArguments?.length && node.typeName.text === "DecoratorMetadataObject") return "BabylonjsBindings.SimpleInterfaces.BrowserDecoratorMetadataObject";
    if (node.typeName.text === "ProgressEvent" && (node.typeArguments?.length ?? 0) <= 1) return "Browser.Types.ProgressEvent";
    if (node.typeName.text === "DeepImmutable"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && !node.typeArguments[0].typeArguments?.length) {
      return maintainedSymbols.get(node.typeArguments[0].typeName.text)?.deepImmutableSymbol;
    }
    if (node.typeName.text === "Partial" && node.typeArguments?.length === 1) {
      const inner = node.typeArguments[0];
      if (ts.isTypeReferenceNode(inner) && ts.isIdentifier(inner.typeName) && !inner.typeArguments?.length) return maintainedSymbols.get(inner.typeName.text)?.partialSymbol;
    }
    if (node.typeName.text === "Array" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `ResizeArray<${inner}>` : undefined;
    }
    if (["ArrayLike", "ReadonlyArray"].includes(node.typeName.text) && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `System.Collections.Generic.IReadOnlyList<${inner}>` : undefined;
    }
    if (node.typeName.text === "Promise" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `JS.Promise<${inner}>` : undefined;
    }
    if (node.typeName.text === "Nullable" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `${inner} option` : undefined;
    }
    if (node.typeName.text === "ArrayBufferLike" && !node.typeArguments?.length) return "U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer>";
    if (node.typeName.text === "Set" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `JS.Set<${inner}>` : undefined;
    }
    if (node.typeName.text === "ReadonlySet" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0]);
      return inner ? `BabylonjsBindings.SimpleInterfaces.BrowserReadonlySet<${inner}>` : undefined;
    }
    if (node.typeName.text === "Map" && node.typeArguments?.length === 2) {
      const key = fsharpType(node.typeArguments[0]);
      const value = fsharpType(node.typeArguments[1]);
      return key && value ? `JS.Map<${key}, ${value}>` : undefined;
    }
    if (node.typeName.text === "ReadonlyMap" && node.typeArguments?.length === 2) {
      const key = fsharpType(node.typeArguments[0]);
      const value = fsharpType(node.typeArguments[1]);
      return key && value ? `BabylonjsBindings.SimpleInterfaces.BrowserReadonlyMap<${key}, ${value}>` : undefined;
    }
    if (node.typeName.text === "Error" && !node.typeArguments?.length) return "System.Exception";
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    if (!node.typeArguments?.length && node.typeName.text === "ImageBitmap") return "BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap";
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
    if (!node.typeArguments?.length && node.typeName.text === "RegExp") return "BabylonjsBindings.SimpleInterfaces.BrowserRegExp";
    if (!node.typeArguments?.length && node.typeName.text === "Worker") return "BabylonjsBindings.SimpleInterfaces.BrowserWorker";
    if (!node.typeArguments?.length && node.typeName.text === "BigUint64Array") return "BabylonjsBindings.SimpleInterfaces.BrowserBigUint64Array";
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
  recordTypeFailure(node);
  return undefined;
};
const functionShape = (node, exportName) => {
  let callable = node;
  if (ts.isTypeQueryNode(node)) {
    let symbol = checker.getSymbolAtLocation(node.exprName);
    if (symbol?.flags & ts.SymbolFlags.Alias) {
      try { symbol = checker.getAliasedSymbol(symbol); } catch { return undefined; }
    }
    const declarations = symbol?.declarations?.filter(declaration => ts.isFunctionDeclaration(declaration) || ts.isMethodDeclaration(declaration) || ts.isMethodSignature(declaration)) ?? [];
    if (declarations.length !== 1) return undefined;
    callable = declarations[0];
  }
  if (!(ts.isFunctionTypeNode(callable) || ts.isFunctionDeclaration(callable) || ts.isMethodDeclaration(callable) || ts.isMethodSignature(callable))
    || !callable.type
    || callable.typeParameters?.length
    || callable.parameters.some(parameter => parameter.dotDotDotToken || (ts.isIdentifier(parameter.name) && parameter.name.text === "this"))) return undefined;
  const inlineShapes = [];
  const renderType = (typeNode, role) => {
    const direct = fsharpType(typeNode);
    if (direct) return direct;
    if (ts.isTypeLiteralNode(typeNode)) {
      const members = typeLiteralShape(typeNode, undefined, inlineShapes, `VariableInline_${exportName.replace(/[^A-Za-z0-9_]/g, "_")}_${role.replace(/[^A-Za-z0-9_]/g, "_")}`);
      if (!members) return undefined;
      const name = `VariableInline_${exportName.replace(/[^A-Za-z0-9_]/g, "_")}_${role.replace(/[^A-Za-z0-9_]/g, "_")}`;
      inlineShapes.push({ name, members });
      return name;
    }
    if (ts.isTypeReferenceNode(typeNode)
      && ts.isIdentifier(typeNode.typeName)
      && typeNode.typeName.text === "Nullable"
      && typeNode.typeArguments?.length === 1) {
      const inner = renderType(typeNode.typeArguments[0], `${role}_Nullable`);
      return inner ? asOption(inner) : undefined;
    }
    if (ts.isUnionTypeNode(typeNode) && typeNode.types.filter(isAbsentType).length === 1) {
      const present = typeNode.types.filter(branch => !isAbsentType(branch));
      if (present.length === 1) {
        const inner = renderType(present[0], `${role}_Present`);
        return inner ? asOption(inner) : undefined;
      }
    }
    if (ts.isFunctionTypeNode(typeNode)
      && !typeNode.typeParameters?.length
      && !typeNode.parameters.some(parameter => parameter.dotDotDotToken)) {
      const parameterTypes = typeNode.parameters.map((parameter, index) => {
        const rendered = parameter.type ? renderType(parameter.type, `${role}_Parameter${index + 1}`) : undefined;
        return parameter.questionToken && rendered ? asOption(rendered) : rendered;
      });
      const returnType = renderType(typeNode.type, `${role}_Return`);
      if (!returnType || parameterTypes.some(parameter => !parameter)) return undefined;
      if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
      return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
    }
    return undefined;
  };
  const returnType = renderType(callable.type, "Return");
  const parameters = callable.parameters.map((parameter, index) => ({
    name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
    type: parameter.type ? renderType(parameter.type, `Parameter${index + 1}`) : undefined,
    optional: Boolean(parameter.questionToken)
  }));
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters, inlineShapes } : undefined;
};
const typeLiteralShape = (node, numericLiteralType, nestedShapes = [], context = "VariableInline") => {
  if (!ts.isTypeLiteralNode(node)) return undefined;
  const nestedType = (typeNode, role) => {
    const direct = fsharpType(typeNode);
    if (direct) return direct;
    if (ts.isTypeLiteralNode(typeNode)) {
      const name = `${context}${role}Object`;
      const nestedMembers = typeLiteralShape(typeNode, numericLiteralType, nestedShapes, name);
      if (!nestedMembers) return undefined;
      nestedShapes.push({ name, members: nestedMembers });
      return name;
    }
    if (ts.isTypeReferenceNode(typeNode)
      && ts.isIdentifier(typeNode.typeName)
      && typeNode.typeName.text === "Nullable"
      && typeNode.typeArguments?.length === 1) {
      const inner = nestedType(typeNode.typeArguments[0], `${role}Nullable`);
      return inner ? asOption(inner) : undefined;
    }
    if (ts.isUnionTypeNode(typeNode) && typeNode.types.filter(isAbsentType).length === 1) {
      const present = typeNode.types.filter(branch => !isAbsentType(branch));
      if (present.length === 1) {
        const inner = nestedType(present[0], `${role}Present`);
        return inner ? asOption(inner) : undefined;
      }
    }
    if (ts.isFunctionTypeNode(typeNode)
      && !typeNode.typeParameters?.length
      && !typeNode.parameters.some(parameter => parameter.dotDotDotToken)) {
      const parameterTypes = typeNode.parameters.map((parameter, parameterIndex) => {
        const rendered = parameter.type ? nestedType(parameter.type, `${role}Parameter${parameterIndex + 1}`) : undefined;
        return parameter.questionToken && rendered ? asOption(rendered) : rendered;
      });
      const returnType = nestedType(typeNode.type, `${role}Return`);
      if (!returnType || parameterTypes.some(parameter => !parameter)) return undefined;
      if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
      return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
    }
    return undefined;
  };
  const members = [];
  for (const [index, member] of node.members.entries()) {
    if (ts.isPropertySignature(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      let type = numericLiteralType
        && ts.isLiteralTypeNode(member.type)
        && (ts.isNumericLiteral(member.type.literal) || (ts.isPrefixUnaryExpression(member.type.literal) && ts.isNumericLiteral(member.type.literal.operand)))
        ? numericLiteralType
        : nestedType(member.type, `Property${index + 1}`);
      if (!type) return undefined;
      members.push({
        kind: "property",
        name: member.name.text,
        type: member.questionToken ? `${type} option` : type,
        readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false
      });
    } else if (ts.isIndexSignatureDeclaration(member) && member.parameters.length === 1 && member.parameters[0].type && member.type && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type);
      const valueType = nestedType(member.type, `Indexer${index + 1}Value`);
      if (!keyType || !valueType) return undefined;
      members.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else if (ts.isMethodSignature(member)
      && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))
      && member.type
      && !member.typeParameters?.length
      && !member.parameters.some(parameter => parameter.dotDotDotToken)) {
      const parameters = member.parameters.map((parameter, parameterIndex) => ({
        name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
        type: parameter.type ? nestedType(parameter.type, `Method${index + 1}Parameter${parameterIndex + 1}`) : undefined,
        optional: Boolean(parameter.questionToken)
      }));
      const returnType = nestedType(member.type, `Method${index + 1}Return`);
      if (!returnType || !parameters.every(parameter => parameter.name && parameter.type)) return undefined;
      members.push({ kind: "method", name: member.name.text, parameters, returnType });
    } else return undefined;
  }
  return members;
};

const indexedConstObjectName = node => {
  if (!ts.isIndexedAccessTypeNode(node)) return undefined;
  const objectType = ts.isParenthesizedTypeNode(node.objectType) ? node.objectType.type : node.objectType;
  if (!ts.isTypeQueryNode(objectType)
    || !ts.isIdentifier(objectType.exprName)
    || !ts.isTypeOperatorNode(node.indexType)
    || node.indexType.operator !== ts.SyntaxKind.KeyOfKeyword
    || !ts.isTypeQueryNode(node.indexType.type)
    || objectType.exprName.getText() !== node.indexType.type.exprName.getText()) return undefined;
  return objectType.exprName.text;
};
const indexedConstEnumTypes = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    diagnosedVariable = exported.getName();
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { continue; }
    }
    const declaration = target.declarations?.find(ts.isTypeAliasDeclaration);
    const objectName = declaration ? indexedConstObjectName(declaration.type) : undefined;
    const maintained = maintainedSymbols.get(exported.getName());
    if (objectName && maintained?.arity === 0) {
      const declarationModule = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
      indexedConstEnumTypes.set(`${declarationModule}|${objectName}`, maintained.fsharpSymbol);
    }
  }
}
diagnosedVariable = undefined;

const variables = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    diagnosedVariable = exported.getName();
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases are excluded */ }
    }
    const declarations = target.declarations ?? [];
    const variableDeclarations = declarations.filter(ts.isVariableDeclaration);
    if (variableDeclarations.length !== 1 || declarations.some(declaration => !ts.isVariableDeclaration(declaration))) continue;
    const declaration = variableDeclarations[0];
    if ((!declaration.type && !declaration.initializer) || !ts.isIdentifier(declaration.name)) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const shapeHelpers = [];
    const shapeContext = `VariableShape_${exported.getName().replace(/[^A-Za-z0-9_]/g, "_")}`;
    const shape = declaration.type ? typeLiteralShape(declaration.type, indexedConstEnumTypes.get(`${module}|${exported.getName()}`), shapeHelpers, shapeContext) : undefined;
    const callable = declaration.type ? functionShape(declaration.type, exported.getName()) : undefined;
    let type = declaration.type ? fsharpType(declaration.type) : initializerType(declaration.initializer);
    if (!type && declaration.type
      && ts.isTypeReferenceNode(declaration.type)
      && ts.isIdentifier(declaration.type.typeName)
      && declaration.type.typeName.text === "Partial"
      && declaration.type.typeArguments?.length === 1) {
      const record = declaration.type.typeArguments[0];
      if (ts.isTypeReferenceNode(record)
        && ts.isIdentifier(record.typeName)
        && record.typeName.text === "Record"
        && record.typeArguments?.length === 2) {
        const keyType = fsharpType(record.typeArguments[0]);
        const valueType = fsharpType(record.typeArguments[1]);
        if (keyType && valueType) {
          const helperName = `${shapeContext}IndexerObject`;
          shapeHelpers.push({ name: helperName, members: [{ kind: "indexer", name: "key", keyType, valueType: `${valueType} option`, readonly: false }] });
          type = helperName;
        }
      }
    }
    if (!type && declaration.type && ts.isArrayTypeNode(declaration.type) && ts.isTypeLiteralNode(declaration.type.elementType)) {
      const helperName = `${shapeContext}ElementObject`;
      const helperMembers = typeLiteralShape(declaration.type.elementType, undefined, shapeHelpers, helperName);
      if (helperMembers) {
        shapeHelpers.push({ name: helperName, members: helperMembers });
        type = `ResizeArray<${helperName}>`;
      }
    }
    if (!type && !shape && !callable) continue;
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    const runtimeExport = target.getName();
    variables.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, runtimeExport, type, shape, shapeHelpers, callable });
  }
}
diagnosedVariable = undefined;

const nameCounts = new Map();
for (const entry of variables.values()) nameCounts.set(entry.name, (nameCounts.get(entry.name) ?? 0) + 1);
const entries = [...variables.values()].filter(entry => nameCounts.get(entry.name) === 1).sort((left, right) => left.name.localeCompare(right.name));
const promotionSymbolIndex = await loadPromotionSymbolIndex(root, [
  "generated-candidates/SimpleAliases.promotion.json",
  "generated-candidates/SimpleInterfaces.promotion.json",
  "generated-candidates/SimpleClasses.promotion.json"
]);
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
const renderShapeMember = member => member.kind === "indexer"
  ? `[<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`
  : member.kind === "method"
    ? `abstract \`\`${member.name}\`\`: ${member.parameters.length === 0 ? "unit" : member.parameters.map(parameter => `${parameter.optional ? "?" : ""}\`\`${parameter.name}\`\`: ${parameter.type}`).join(" * ")} -> ${member.returnType}`
    : `abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`;
for (const entry of entries) {
  for (const helper of entry.shapeHelpers) {
    lines.push("", `    /// Nested inline object shape used by ${entry.name}.`, "    [<AllowNullLiteral>]", `    type ${helper.name} =`);
    if (helper.members.length === 0) lines.push("        interface end");
    else for (const member of helper.members) lines.push(`        ${renderShapeMember(member)}`);
  }
  if (entry.shape) {
    entry.type = safeName(entry.name);
    lines.push("", `    /// Inline object shape of ${entry.name}.`, "    [<AllowNullLiteral>]", `    type ${entry.type} =`);
    if (entry.shape.length === 0) lines.push("        interface end");
    else for (const member of entry.shape) lines.push(`        ${renderShapeMember(member)}`);
  } else if (entry.callable) {
    entry.type = safeFunctionName(entry.name);
    for (const inlineShape of entry.callable.inlineShapes) {
      lines.push("", `    /// Inline callable object shape used by ${entry.name}.`, "    [<AllowNullLiteral>]", `    type ${inlineShape.name} =`);
      for (const member of inlineShape.members) lines.push(`        abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`);
    }
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
    dependencies: referencedPromotionSymbols(entry, promotionSymbolIndex, `BabylonjsBindings.SimpleVariables.${entry.name}`),
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
if (diagnose) {
  console.log("top unresolved variable types:");
  console.log([...typeFailureCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 100).map(([type, count]) => `${count} ${type}`).join("\n"));
  console.log(`diagnostic: ${failedVariables.size} exported variables encountered unresolved types`);
  console.log("sample blocked variables:");
  console.log([...failedVariables].sort(([left], [right]) => left.localeCompare(right)).slice(0, 160).map(([name, failures]) => `${name}: ${[...failures].slice(0, 5).join(" | ")}`).join("\n"));
}
