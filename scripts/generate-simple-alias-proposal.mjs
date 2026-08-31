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
const bootstrapClasses = process.argv.includes("--bootstrap-classes");
const typeFailureCounts = new Map();
const failedAliases = new Map();
let diagnosedAlias;
const recordTypeFailure = node => {
  if (!diagnose) return;
  const text = node.getText().replace(/\s+/g, " ");
  const key = `${ts.SyntaxKind[node.kind]}: ${text.length > 160 ? `${text.slice(0, 157)}...` : text}`;
  typeFailureCounts.set(key, (typeFailureCounts.get(key) ?? 0) + 1);
  if (diagnosedAlias) {
    const failures = failedAliases.get(diagnosedAlias) ?? new Set();
    failures.add(key);
    failedAliases.set(diagnosedAlias, failures);
  }
};
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

const dependencyManifestPaths = [
  "src/BabylonjsBindings/coverage-manifest.json",
  "src/BabylonjsBindings/string-coverage-manifest.json",
  "src/BabylonjsBindings/object-type-coverage-manifest.json",
  "generated-candidates/SimpleInterfaces.promotion.json",
  "generated-candidates/SimpleClasses.promotion.json"
];
const dependencyExports = (await Promise.all(dependencyManifestPaths.map(async path => JSON.parse(await readFile(resolve(root, path), "utf8")))))
  .flatMap(manifest => [...(manifest.exports ?? []), ...(manifest.supportTypes ?? [])]);
const maintainedIdentities = new Set(dependencyExports.map(entry => `${entry.package}|${entry.module}|${entry.name}`));
let priorAliasExports = [];
try {
  priorAliasExports = JSON.parse(await readFile(resolve(root, "generated-candidates/SimpleAliases.promotion.json"), "utf8")).exports;
} catch { /* first generation has no prior proposal */ }
const symbolExports = [...dependencyExports, ...priorAliasExports];
const dependencyNameCounts = new Map();
for (const entry of symbolExports) dependencyNameCounts.set(entry.name, (dependencyNameCounts.get(entry.name) ?? 0) + 1);
const maintainedSymbols = new Map(symbolExports
  .filter(entry => dependencyNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { fsharpSymbol: entry.fsharpSymbol, arity: entry.typeParameterCount ?? 0 }]));
if (bootstrapClasses) {
  const rawClassSymbols = new Map();
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
      rawClassSymbols.set(`${packageName}|${module}|${name}`, { name, arity: declaration.typeParameters?.length ?? 0 });
    }
  }
  const classNameCounts = new Map();
  for (const entry of rawClassSymbols.values()) classNameCounts.set(entry.name, (classNameCounts.get(entry.name) ?? 0) + 1);
  for (const entry of rawClassSymbols.values()) {
    if (classNameCounts.get(entry.name) === 1 && !maintainedSymbols.has(entry.name)) {
      maintainedSymbols.set(entry.name, { fsharpSymbol: `BabylonjsBindings.SimpleClasses.${entry.name}`, arity: entry.arity });
    }
  }
}
const isAbsentType = node => node.kind === ts.SyntaxKind.UndefinedKeyword
  || (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword);
const asOption = type => type.endsWith(" option") ? type : `${type} option`;
const erasedUnionType = branches => {
  if (branches.length < 2) return branches[0];
  if (branches.length <= 9) return `U${branches.length}<${branches.join(", ")}>`;
  return `U2<${erasedUnionType(branches.slice(0, 8))}, ${erasedUnionType(branches.slice(8))}>`;
};
const numericLiteralValues = new Set();
const stringLiteralTypes = new Map();
const localEnumTypes = new Map();
const fsharpString = value => `"${value.replaceAll("\\", "\\\\").replaceAll("\"", "\\\"").replaceAll("\n", "\\n").replaceAll("\r", "\\r")}"`;
const numericLiteralType = value => {
  const numeric = Number(value);
  if (!Number.isSafeInteger(numeric) || numeric < -2147483648 || numeric > 2147483647) return undefined;
  numericLiteralValues.add(numeric);
  return `NumericLiteral${numeric < 0 ? `Negative${Math.abs(numeric)}` : numeric}`;
};
const stringLiteralType = value => {
  const name = `StringLiteral${createHash("sha256").update(value).digest("hex").slice(0, 12)}`;
  stringLiteralTypes.set(name, value);
  return name;
};
const fsharpType = node => {
  if (node.kind === ts.SyntaxKind.UndefinedKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "System.Double";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.NeverKeyword) return "BabylonjsBindings.SimpleClasses.Never";
  if (node.kind === ts.SyntaxKind.ObjectKeyword) return "BabylonjsBindings.SimpleInterfaces.JavaScriptObject";
  if (node.kind === ts.SyntaxKind.SymbolKeyword) return "BabylonjsBindings.SimpleInterfaces.BrowserSymbol";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isLiteralTypeNode(node) && ts.isNumericLiteral(node.literal)) return numericLiteralType(node.literal.text);
  if (ts.isLiteralTypeNode(node) && ts.isStringLiteral(node.literal)) return stringLiteralType(node.literal.text);
  if (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword) return "BabylonjsBindings.SimpleInterfaces.JavaScriptNull";
  if (ts.isLiteralTypeNode(node) && (node.literal.kind === ts.SyntaxKind.TrueKeyword || node.literal.kind === ts.SyntaxKind.FalseKeyword)) return "bool";
  if (ts.isParenthesizedTypeNode(node)) return fsharpType(node.type);
  if (ts.isTypeOperatorNode(node) && node.operator === ts.SyntaxKind.ReadonlyKeyword) {
    if (ts.isArrayTypeNode(node.type)) {
      const element = fsharpType(node.type.elementType);
      return element ? `System.Collections.Generic.IReadOnlyList<${element}>` : undefined;
    }
    return fsharpType(node.type);
  }
  if (ts.isUnionTypeNode(node) && node.types.some(isAbsentType)) {
    const branches = node.types.filter(branch => !isAbsentType(branch)).map(fsharpType);
    if (branches.some(branch => !branch) || branches.length === 0) return undefined;
    return asOption(branches.length === 1 ? branches[0] : erasedUnionType(branches));
  }
  if (ts.isUnionTypeNode(node) && node.types.length >= 2) {
    const branches = node.types.map(fsharpType);
    return branches.every(Boolean) ? erasedUnionType(branches) : undefined;
  }
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType);
    return element ? `ResizeArray<${element}>` : undefined;
  }
  if (ts.isTupleTypeNode(node) && node.elements.length === 0) return "ResizeArray<BabylonjsBindings.SimpleClasses.Never>";
  if (ts.isTupleTypeNode(node) && node.elements.length >= 2) {
    const elements = node.elements.map(element => ts.isNamedTupleMember(element) && !element.questionToken && !element.dotDotDotToken ? fsharpType(element.type) : !ts.isNamedTupleMember(element) ? fsharpType(element) : undefined);
    return elements.every(Boolean) ? `(${elements.join(" * ")})` : undefined;
  }
  if (ts.isTypeLiteralNode(node)) return auxiliaryTypeForTypeLiteral(node);
  if (ts.isMappedTypeNode(node)
    && node.typeParameter.constraint
    && node.type) return auxiliaryIndexerType(node, fsharpType(node.typeParameter.constraint), fsharpType(node.type), Boolean(node.questionToken));
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
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (node.getText().replace(/\s+/g, " ") === "Exclude<TypedArray, Float64Array | BigInt64Array | BigUint64Array>") {
      return "U8<JS.Int8Array, JS.Uint8Array, JS.Uint8ClampedArray, JS.Int16Array, JS.Uint16Array, JS.Int32Array, JS.Uint32Array, JS.Float32Array>";
    }
    if (!node.typeArguments?.length && node.typeName.text === "SerializableContext") return "BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext";
    if (!node.typeArguments?.length && node.typeName.text === "DecoratorMetadataObject") return "BabylonjsBindings.SimpleInterfaces.BrowserDecoratorMetadataObject";
    if (node.typeName.text === "Pick"
      && node.typeArguments?.length === 2
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)) {
      let symbol = checker.getSymbolAtLocation(node.typeArguments[0].typeName);
      if (symbol?.flags & ts.SymbolFlags.Alias) {
        try { symbol = checker.getAliasedSymbol(symbol); } catch { return undefined; }
      }
      const declaration = symbol?.declarations?.find(ts.isTypeAliasDeclaration);
      const keyNodes = ts.isUnionTypeNode(node.typeArguments[1]) ? node.typeArguments[1].types : [node.typeArguments[1]];
      const keys = keyNodes.map(branch => ts.isLiteralTypeNode(branch) && ts.isStringLiteral(branch.literal) ? branch.literal.text : undefined);
      if (declaration && ts.isTypeLiteralNode(declaration.type) && keys.length > 0 && keys.every(Boolean)) {
        const members = typeLiteralShape(declaration.type, `${node.typeArguments[0].typeName.text}Pick`)?.filter(member => keys.includes(member.name));
        if (members?.length === keys.length) {
          const name = `PickObject${createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12)}`;
          auxiliaryObjectTypes.set(name, { name, members });
          return name;
        }
      }
      recordTypeFailure(node);
      return undefined;
    }
    if (node.typeName.text === "ArrayBufferLike" && !node.typeArguments?.length) {
      return "U2<JS.ArrayBuffer, BrowserSharedArrayBuffer>";
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
      return inner ? asOption(inner) : undefined;
    }
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
    if (node.typeName.text === "Record" && node.typeArguments?.length === 2) {
      return auxiliaryIndexerType(node, fsharpType(node.typeArguments[0]), fsharpType(node.typeArguments[1]), false);
    }
    if (node.typeName.text === "Partial"
      && node.typeArguments?.length === 1
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && node.typeArguments[0].typeName.text === "Record"
      && node.typeArguments[0].typeArguments?.length === 2) {
      const record = node.typeArguments[0];
      return auxiliaryIndexerType(node, fsharpType(record.typeArguments[0]), fsharpType(record.typeArguments[1]), true);
    }
    const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "DataView", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    if (node.typeArguments?.length === 1
      && jsTypes.has(node.typeName.text)
      && ts.isTypeReferenceNode(node.typeArguments[0])
      && ts.isIdentifier(node.typeArguments[0].typeName)
      && ["ArrayBuffer", "ArrayBufferLike"].includes(node.typeArguments[0].typeName.text)
      && !node.typeArguments[0].typeArguments?.length) return `JS.${node.typeName.text}`;
    const browserTypes = new Set(["AudioContext", "Blob", "Event", "File", "HTMLElement", "HTMLCanvasElement", "HTMLDivElement", "HTMLImageElement", "HTMLVideoElement", "ImageData", "KeyboardEvent", "WebGLRenderingContext"]);
    if (!node.typeArguments?.length && browserTypes.has(node.typeName.text)) return `Browser.Types.${node.typeName.text}`;
    if (!node.typeArguments?.length && node.typeName.text === "WebGL2RenderingContext") return "BabylonjsBindings.SimpleInterfaces.BrowserWebGL2RenderingContext";
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
    if (!node.typeArguments?.length && node.typeName.text === "VideoFrame") return "BabylonjsBindings.SimpleInterfaces.BrowserVideoFrame";
    if (!node.typeArguments?.length && node.typeName.text === "OffscreenCanvas") return "BabylonjsBindings.SimpleInterfaces.BrowserOffscreenCanvas";
    if (!node.typeArguments?.length && node.typeName.text === "WebGLQuery") return "BabylonjsBindings.SimpleInterfaces.BrowserWebGLQuery";
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
      ,["Worker", "BrowserWorker"]
      ,["XRReferenceSpace", "BrowserXRReferenceSpace"]
      ,["XRFrame", "BrowserXRFrame"]
      ,["XRSession", "BrowserXRSession"]
      ,["XRViewerPose", "BrowserXRViewerPose"]
      ,["XRInputSource", "BrowserXRInputSource"]
      ,["XRPose", "BrowserXRPose"]
      ,["XRView", "BrowserXRView"]
    ]);
    if (!node.typeArguments?.length && ambientHandleTypes.has(node.typeName.text)) return `BabylonjsBindings.SimpleInterfaces.${ambientHandleTypes.get(node.typeName.text)}`;
    if (!node.typeArguments?.length && node.typeName.text === "GPUBufferUsageFlags") return "float";
    if (!node.typeArguments?.length) {
      let symbol = checker.getSymbolAtLocation(node.typeName);
      if (symbol?.flags & ts.SymbolFlags.Alias) {
        try { symbol = checker.getAliasedSymbol(symbol); } catch { symbol = undefined; }
      }
      const declaration = symbol?.declarations?.find(ts.isEnumDeclaration);
      if (declaration && !declaration.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ExportKeyword)) {
        const members = declaration.members.map(member => ({ name: member.name.getText(), value: checker.getConstantValue(member) }));
        if (members.length > 0 && members.every(member => Number.isInteger(member.value) && member.value >= -2147483648 && member.value <= 2147483647)) {
          const identity = `${normalize(declaration.getSourceFile().fileName)}|${declaration.name.text}`;
          const name = `AliasEnum${createHash("sha256").update(identity).digest("hex").slice(0, 12)}`;
          localEnumTypes.set(name, { name, members });
          return name;
        }
      }
    }
    const maintained = maintainedSymbols.get(node.typeName.text);
    if (maintained) {
      const arguments_ = node.typeArguments ?? [];
      if (arguments_.length !== maintained.arity) return undefined;
      const renderedArguments = arguments_.map(fsharpType);
      if (renderedArguments.some(argument => !argument)) return undefined;
      return maintained.arity === 0 ? maintained.fsharpSymbol : `${maintained.fsharpSymbol}<${renderedArguments.join(", ")}>`;
    }
    if (!node.typeArguments?.length && node.typeName.text === diagnosedAlias) return `BabylonjsBindings.TypeAliases.${diagnosedAlias}`;
  }
  recordTypeFailure(node);
  return undefined;
};
const auxiliaryObjectTypes = new Map();
const typeLiteralShape = (node, context = "Alias") => {
  if (!ts.isTypeLiteralNode(node)) return undefined;
  const members = [];
  for (const [index, member] of node.members.entries()) {
    if (ts.isPropertySignature(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      let rendered = fsharpType(member.type);
      if (!rendered && ts.isTypeLiteralNode(member.type)) {
        const nestedMembers = typeLiteralShape(member.type, `${context}Property${index + 1}`);
        if (nestedMembers) {
          const nestedName = `AliasObject${createHash("sha256").update(`${context}|${member.type.getText().replace(/\s+/g, " ")}`).digest("hex").slice(0, 12)}`;
          auxiliaryObjectTypes.set(nestedName, { name: nestedName, members: nestedMembers });
          rendered = nestedName;
        }
      }
      if (!rendered) {
        recordTypeFailure(member);
        return undefined;
      }
      members.push({ kind: "property", name: member.name.text, type: member.questionToken ? asOption(rendered) : rendered, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else if (ts.isIndexSignatureDeclaration(member)
      && member.parameters.length === 1
      && member.parameters[0].type
      && member.type
      && ts.isIdentifier(member.parameters[0].name)) {
      const keyType = fsharpType(member.parameters[0].type);
      let valueType = fsharpType(member.type);
      if (!valueType && ts.isTypeLiteralNode(member.type)) {
        const nestedMembers = typeLiteralShape(member.type, `${context}Value${index + 1}`);
        if (nestedMembers) {
          const nestedName = `AliasObject${createHash("sha256").update(`${context}|${member.type.getText().replace(/\s+/g, " ")}`).digest("hex").slice(0, 12)}`;
          auxiliaryObjectTypes.set(nestedName, { name: nestedName, members: nestedMembers });
          valueType = nestedName;
        }
      }
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
  return members;
};
const auxiliaryTypeForTypeLiteral = node => {
  const members = typeLiteralShape(node, "InlineAlias");
  if (!members) return undefined;
  const name = `AliasObject${createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12)}`;
  auxiliaryObjectTypes.set(name, { name, members });
  return name;
};
const auxiliaryIndexerType = (node, keyType, valueType, optional) => {
  if (!keyType || !valueType) return undefined;
  const name = `AliasObject${createHash("sha256").update(node.getText().replace(/\s+/g, " ")).digest("hex").slice(0, 12)}`;
  auxiliaryObjectTypes.set(name, { name, members: [{ kind: "indexer", name: "key", keyType, valueType: optional ? asOption(valueType) : valueType, readonly: false }] });
  return name;
};
const intersectionShape = node => {
  if (!ts.isIntersectionTypeNode(node)) return undefined;
  const bases = [];
  const members = [];
  for (const branch of node.types) {
    if (ts.isTypeLiteralNode(branch)) {
      const renderedMembers = typeLiteralShape(branch, "IntersectionAlias");
      if (!renderedMembers) return undefined;
      members.push(...renderedMembers);
    } else {
      const rendered = fsharpType(branch);
      if (!rendered || /^U\d</.test(rendered)) {
        recordTypeFailure(branch);
        return undefined;
      }
      bases.push(rendered);
    }
  }
  return { bases, members };
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
    if (!node.typeArguments?.length && node.typeName.text === "BigUint64Array") return "BabylonjsBindings.SimpleInterfaces.BrowserBigUint64Array";
    const typedArrays = new Set(["BigInt64Array", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
    if (!node.typeArguments?.length && typedArrays.has(node.typeName.text)) return `JS.${node.typeName.text}`;
  }
  return undefined;
};

const entriesByIdentity = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalize(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    diagnosedAlias = exported.getName();
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
    const isCoroutine = name === "Coroutine"
      && declaration.typeParameters?.length === 1
      && declaration.typeParameters[0].name.text === "T";
    const coroutineGeneric = declaration.typeParameters?.length === 1
      && declaration.typeParameters[0].name.text === "T";
    if (isCoroutine) {
      entry = { package: packageName, module, name, shape: "coroutine", typeParameter: "T" };
    } else if (name === "AsyncCoroutine" && coroutineGeneric) {
      entry = { package: packageName, module, name, shape: "genericAlias", typeParameter: "T", target: "BabylonjsBindings.SimpleInterfaces.BrowserGenerator<U2<unit, JS.Promise<unit>>, 'T, unit>" };
    } else if (name === "CoroutineStep" && coroutineGeneric) {
      entry = { package: packageName, module, name, shape: "genericAlias", typeParameter: "T", target: "BabylonjsBindings.SimpleInterfaces.BrowserGeneratorResult<unit, 'T>" };
    } else if (name === "CoroutineScheduler" && coroutineGeneric) {
      entry = { package: packageName, module, name, shape: "genericAlias", typeParameter: "T", target: "System.Action<BabylonjsBindings.SimpleInterfaces.BrowserGenerator<U2<unit, JS.Promise<unit>>, 'T, unit>, System.Action<BabylonjsBindings.SimpleInterfaces.BrowserGeneratorResult<unit, 'T>>, System.Action<obj>>" };
    } else if (isNullable) {
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
      const selfSymbol = `BabylonjsBindings.TypeAliases.${name}`;
      const recursiveUnionBranches = ts.isUnionTypeNode(declaration.type)
        ? declaration.type.types.map(fsharpType)
        : [];
      if (recursiveUnionBranches.length >= 2 && recursiveUnionBranches.every(Boolean) && recursiveUnionBranches.some(branch => branch.includes(selfSymbol))) {
        entry = { package: packageName, module, name, shape: "recursiveUnionAlias", branches: recursiveUnionBranches };
      } else if (targetType) entry = {
        package: packageName,
        module,
        name,
        shape: "alias",
        target: targetType,
        ...(deepImmutableAliasNames.has(name) && deepImmutableFsharpType(declaration.type) ? { deepImmutableTarget: deepImmutableFsharpType(declaration.type) } : {})
      };
      else {
        const members = typeLiteralShape(declaration.type, name);
        if (members) entry = { package: packageName, module, name, shape: "objectAlias", members };
        else {
          const intersection = intersectionShape(declaration.type);
          if (intersection) entry = { package: packageName, module, name, shape: "intersectionAlias", ...intersection };
        }
      }
    }
    const identity = `${packageName}|${module}|${name}`;
    if (entry && !maintainedIdentities.has(identity)) entriesByIdentity.set(identity, entry);
  }
}
diagnosedAlias = undefined;

const allEntries = [...entriesByIdentity.values()];
const aliasNameCounts = new Map();
for (const entry of allEntries) aliasNameCounts.set(entry.name, (aliasNameCounts.get(entry.name) ?? 0) + 1);
const entries = allEntries.filter(entry => aliasNameCounts.get(entry.name) === 1).sort((left, right) => left.name.localeCompare(right.name));
const promotionSymbolIndex = await loadPromotionSymbolIndex(root, [
  "generated-candidates/SimpleInterfaces.promotion.json",
  "generated-candidates/SimpleClasses.promotion.json"
]);
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after alias review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact primitive aliases and dependency-free callbacks exported by Babylon.js 9.19.0.",
  "module TypeAliases ="
];
lines.push("", "    /// Phantom structural witness for TypeScript Function constraints.", "    [<AllowNullLiteral>]", "    type JavaScriptFunction =", "        interface end");
const stageActionAliases = new Set(["CameraStageAction", "CameraStageFrameBufferAction", "EvaluateSubMeshStageAction", "MeshStageAction", "PointerMoveStageAction", "PointerUpDownStageAction", "PreActiveMeshStageAction", "RenderTargetStageAction", "RenderTargetsStageAction", "RenderingGroupStageAction", "RenderingMeshStageAction", "SimpleStageAction"]);
lines.push("", "    /// Exact Symbol.toStringTag literal exposed by SharedArrayBuffer.", "    [<StringEnum; RequireQualifiedAccess>]", "    type BrowserSharedArrayBufferTag =", "        | [<CompiledName(\"SharedArrayBuffer\")>] SharedArrayBuffer");
lines.push("", "    /// Phantom structural witness for NodeRenderGraphValueType generic constraints.", "    [<AllowNullLiteral>]", "    type NodeRenderGraphValue =", "        interface end");
lines.push("", "    /// Exact ESNext SharedArrayBuffer instance surface used by ArrayBufferLike declarations.", "    [<AllowNullLiteral>]", "    type BrowserSharedArrayBuffer =", "        abstract byteLength: float with get", "        abstract growable: bool with get", "        abstract maxByteLength: float with get", "        abstract slice: ?beginIndex: float * ?endIndex: float -> BrowserSharedArrayBuffer", "        abstract grow: ?newByteLength: float -> unit", "        [<Emit(\"$0[Symbol.toStringTag]\")>] abstract toStringTag: BrowserSharedArrayBufferTag with get");
lines.push("", "    /// Yield branch returned by a Babylon coroutine iterator.", "    [<AllowNullLiteral>]", "    type CoroutineInternalYieldResult =", "        abstract ``done``: bool option with get", "        abstract value: unit with get");
lines.push("", "    /// Completion branch returned by a Babylon coroutine iterator.", "    [<AllowNullLiteral>]", "    type CoroutineInternalReturnResult<'T> =", "        abstract ``done``: bool with get", "        abstract value: 'T with get");
lines.push("", "    /// Exact IteratorResult<void, T> union returned by a Babylon coroutine.", "    type CoroutineInternalResult<'T> = U2<CoroutineInternalYieldResult, CoroutineInternalReturnResult<'T>>");
const aliasReferenceText = JSON.stringify(entries);
for (const value of [...numericLiteralValues].filter(value => aliasReferenceText.includes(`NumericLiteral${value < 0 ? `Negative${Math.abs(value)}` : value}`)).sort((left, right) => left - right)) {
  const name = `NumericLiteral${value < 0 ? `Negative${Math.abs(value)}` : value}`;
  lines.push("", `    /// Exact numeric literal type for ${value}.`, `    type ${name} =`, `        | Value = ${value}`);
}
const auxiliaryTypeReferenceText = `${aliasReferenceText}${JSON.stringify([...auxiliaryObjectTypes.values()])}`;
for (const [name, value] of [...stringLiteralTypes].filter(([name]) => auxiliaryTypeReferenceText.includes(name)).sort(([left], [right]) => left.localeCompare(right))) {
  lines.push("", `    /// Exact string literal type for ${fsharpString(value)}.`, "    [<StringEnum; RequireQualifiedAccess>]", `    type ${name} =`, `        | [<CompiledName(${fsharpString(value)})>] Value`);
}
const localEnumReferenceText = auxiliaryTypeReferenceText;
for (const { name, members } of [...localEnumTypes.values()].filter(entry => localEnumReferenceText.includes(entry.name)).sort((left, right) => left.name.localeCompare(right.name))) {
  lines.push("", "    /// Exact internal numeric enum required by an exported Babylon alias.", `    type ${name} =`);
  for (const member of members) lines.push(`        | \`\`${member.name}\`\` = ${member.value}`);
}
let auxiliaryReferenceText = JSON.stringify(entries);
const retainedAuxiliaryObjectTypes = [];
while (true) {
  const additions = [...auxiliaryObjectTypes.values()].filter(auxiliary => !retainedAuxiliaryObjectTypes.includes(auxiliary) && auxiliaryReferenceText.includes(auxiliary.name));
  if (additions.length === 0) break;
  retainedAuxiliaryObjectTypes.push(...additions);
  auxiliaryReferenceText += JSON.stringify(additions);
}
for (const auxiliary of retainedAuxiliaryObjectTypes) {
  lines.push("", "    /// Exact nested object used by a Babylon type alias.", "    [<AllowNullLiteral>]", `    type ${auxiliary.name} =`);
  if (auxiliary.members.length === 0) lines.push("        interface end");
  for (const member of auxiliary.members) {
    if (member.kind === "property") lines.push(`        abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`);
    else lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`);
  }
}
for (const entry of entries) {
  lines.push("", `    /// ${entry.module}`);
  if (entry.shape === "alias" || entry.shape === "genericAlias") {
    const generic = entry.shape === "genericAlias" ? `<'${entry.typeParameter}>` : "";
    lines.push(`    type ${entry.name}${generic} = ${entry.target}`);
    if (entry.deepImmutableTarget) lines.push(`    type DeepImmutable${entry.name} = ${entry.deepImmutableTarget}`);
  } else if (entry.shape === "coroutine") {
    lines.push("    [<AllowNullLiteral>]", `    type ${entry.name}<'${entry.typeParameter}> =`, `        abstract next: ?value: unit -> CoroutineInternalResult<'${entry.typeParameter}>`, `        [<Emit(\"$0.return === undefined ? undefined : $0.return($1)\")>] abstract tryReturn: ?value: '${entry.typeParameter} -> CoroutineInternalResult<'${entry.typeParameter}> option`, `        [<Emit(\"$0.throw === undefined ? undefined : $0.throw($1)\")>] abstract tryThrow: ?error: obj -> CoroutineInternalResult<'${entry.typeParameter}> option`, `        [<Emit(\"$0[Symbol.iterator]()\")>] abstract GetIterator: unit -> ${entry.name}<'${entry.typeParameter}>`);
  } else if (entry.shape === "callback") {
    const argumentsType = entry.parameters.length === 0
      ? "unit"
      : entry.parameters.map(parameter => `${parameter.optional ? "?" : ""}${parameter.name}: ${parameter.type}`).join(" * ");
    lines.push("    [<AllowNullLiteral>]", `    type ${entry.name} =`);
    if (stageActionAliases.has(entry.name)) lines.push("        inherit JavaScriptFunction");
    lines.push(`        [<Emit("$0($1...)")>] abstract Invoke: ${argumentsType} -> ${entry.returnType}`);
  } else if (entry.shape === "recursiveUnionAlias") {
    lines.push("    [<Erase>]", `    type ${entry.name} =`);
    entry.branches.forEach((branch, index) => lines.push(`        | ${entry.name}Case${index + 1} of ${branch}`));
  } else if (entry.shape === "objectAlias") {
    lines.push("    [<AllowNullLiteral>]", `    type ${entry.name} =`);
    for (const member of entry.members) {
      if (member.kind === "property") lines.push(`        abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`);
      else lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`);
    }
  } else {
    lines.push("    [<AllowNullLiteral>]", `    type ${entry.name} =`);
    for (const base of entry.bases) lines.push(`        inherit ${base}`);
    if (entry.bases.length === 0 && entry.members.length === 0) lines.push("        interface end");
    for (const member of entry.members) {
      if (member.kind === "property") lines.push(`        abstract \`\`${member.name}\`\`: ${member.type} with get${member.readonly ? "" : ", set"}`);
      else lines.push(`        [<EmitIndexer>] abstract Item: \`\`${member.name}\`\`: ${member.keyType} -> ${member.valueType} with get${member.readonly ? "" : ", set"}`);
    }
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
    dependencies: referencedPromotionSymbols(entry, promotionSymbolIndex, `BabylonjsBindings.TypeAliases.${entry.name}`),
    ...(entry.deepImmutableTarget ? { deepImmutableSymbol: `BabylonjsBindings.TypeAliases.DeepImmutable${entry.name}` } : {}),
    shape: entry.shape,
    ...(["genericAlias", "coroutine"].includes(entry.shape) ? { typeParameterCount: 1 } : {}),
    memberCount: entry.shape === "callback" ? entry.parameters.length : entry.shape === "recursiveUnionAlias" ? entry.branches.length : entry.shape === "objectAlias" ? entry.members.length : entry.shape === "intersectionAlias" ? entry.bases.length + entry.members.length : 1
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
if (diagnose) {
  console.log("top unresolved alias member types:");
  console.log([...typeFailureCounts].sort((left, right) => right[1] - left[1] || left[0].localeCompare(right[0])).slice(0, 120).map(([type, count]) => `${count} ${type}`).join("\n"));
  console.log(`diagnostic: ${failedAliases.size} exported aliases encountered unresolved types`);
  console.log("sample blocked aliases:");
  console.log([...failedAliases].sort(([left], [right]) => left.localeCompare(right)).slice(0, 180).map(([name, failures]) => `${name}: ${[...failures].slice(0, 5).join(" | ")}`).join("\n"));
}
