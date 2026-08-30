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
  "src/BabylonjsBindings/simple-interface-coverage-manifest.json"
];
const dependencyExports = (await Promise.all(dependencyManifestPaths.map(async path => JSON.parse(await readFile(resolve(root, path), "utf8")))))
  .flatMap(manifest => manifest.exports);
const dependencyNameCounts = new Map();
for (const entry of dependencyExports) dependencyNameCounts.set(entry.name, (dependencyNameCounts.get(entry.name) ?? 0) + 1);
const maintainedSymbols = new Map(dependencyExports
  .filter(entry => dependencyNameCounts.get(entry.name) === 1)
  .map(entry => [entry.name, { fsharpSymbol: entry.fsharpSymbol, arity: entry.typeParameterCount ?? 0 }]));

const hasModifier = (node, kind) => node.modifiers?.some(modifier => modifier.kind === kind) ?? false;
const inaccessible = node => hasModifier(node, ts.SyntaxKind.PrivateKeyword) || hasModifier(node, ts.SyntaxKind.ProtectedKeyword);
const isAbsentType = node => node.kind === ts.SyntaxKind.UndefinedKeyword
  || (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword);
const asOption = type => type.endsWith(" option") ? type : `${type} option`;
const asOptionalParameterType = type => type.endsWith(" option") ? type.slice(0, -" option".length) : type;
const fsharpType = (node, available, dependencies = new Set(), typeParameters = new Set()) => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "float";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
  if (ts.isParenthesizedTypeNode(node)) return fsharpType(node.type, available, dependencies, typeParameters);
  if (ts.isUnionTypeNode(node) && node.types.length === 2 && node.types.filter(isAbsentType).length === 1) {
    const inner = fsharpType(node.types.find(branch => !isAbsentType(branch)), available, dependencies, typeParameters);
    return inner ? asOption(inner) : undefined;
  }
  if (ts.isUnionTypeNode(node) && node.types.length >= 2 && node.types.length <= 9) {
    const branches = node.types.map(branch => fsharpType(branch, available, dependencies, typeParameters));
    return branches.every(Boolean) ? `U${branches.length}<${branches.join(", ")}>` : undefined;
  }
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType, available, dependencies, typeParameters);
    return element ? `ResizeArray<${element}>` : undefined;
  }
  if (ts.isTupleTypeNode(node) && node.elements.length >= 2) {
    const elements = node.elements.map(element => ts.isNamedTupleMember(element) && !element.questionToken && !element.dotDotDotToken ? fsharpType(element.type, available, dependencies, typeParameters) : !ts.isNamedTupleMember(element) ? fsharpType(element, available, dependencies, typeParameters) : undefined);
    return elements.every(Boolean) ? `(${elements.join(" * ")})` : undefined;
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
    if (node.typeName.text === "Array" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `ResizeArray<${inner}>` : undefined;
    }
    if (node.typeName.text === "Promise" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? `JS.Promise<${inner}>` : undefined;
    }
    if (node.typeName.text === "Nullable" && node.typeArguments?.length === 1) {
      const inner = fsharpType(node.typeArguments[0], available, dependencies, typeParameters);
      return inner ? asOption(inner) : undefined;
    }
    const jsTypes = new Set(["ArrayBuffer", "ArrayBufferView", "BigInt64Array", "BigUint64Array", "Float32Array", "Float64Array", "Int8Array", "Int16Array", "Int32Array", "Uint8Array", "Uint8ClampedArray", "Uint16Array", "Uint32Array"]);
    if (!node.typeArguments?.length && jsTypes.has(node.typeName.text)) return `JS.${node.typeName.text}`;
    const browserTypes = new Set([
      "Event", "File", "HTMLElement", "HTMLCanvasElement", "HTMLImageElement", "HTMLVideoElement", "KeyboardEvent",
      "ImageData", "WebGLUniformLocation", "WebGLRenderingContext",
      "WebGLProgram", "WebGLShader", "WebGLBuffer", "WebGLTexture", "WebGLFramebuffer", "WebGLRenderbuffer",
    ]);
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
  return undefined;
};
const directCallbackShape = (node, available, dependencies, typeParameters) => {
  if (node.typeParameters?.length || node.parameters.some(parameter => parameter.dotDotDotToken || parameter.questionToken)) return undefined;
  const returnType = node.type ? fsharpType(node.type, available, dependencies, typeParameters) : undefined;
  const parameters = node.parameters.map(parameter => ({
    name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
    type: parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined,
    optional: Boolean(parameter.questionToken)
  }));
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters } : undefined;
};
const callbackShape = (node, available, dependencies, typeParameters, nestedCallbacks, context, ownerName) => {
  if (node.parameters.some(parameter => parameter.dotDotDotToken)) return undefined;
  const returnType = node.type ? fsharpType(node.type, available, dependencies, typeParameters) : undefined;
  const parameters = node.parameters.map((parameter, index) => {
    let type = parameter.type ? fsharpType(parameter.type, available, dependencies, typeParameters) : undefined;
    if (!type && parameter.type && ts.isFunctionTypeNode(parameter.type)) {
      const nested = directCallbackShape(parameter.type, available, dependencies, typeParameters);
      const usesOwner = nested && [nested.returnType, ...nested.parameters.map(item => item.type)].some(type => new RegExp(`(^|[^A-Za-z0-9_])${ownerName}([^A-Za-z0-9_]|$)`).test(type));
      if (nested && !usesOwner) {
        const name = `${context}Parameter${index + 1}Callback`;
        const genericParameters = typeParameters.size ? `<${[...typeParameters].map(value => `'${value}`).join(", ")}>` : "";
        nestedCallbacks.push({ name, genericParameters, callback: nested });
        type = `${name}${genericParameters}`;
      }
    }
    return {
      name: ts.isIdentifier(parameter.name) ? parameter.name.text : undefined,
      type: parameter.questionToken && type ? asOptionalParameterType(type) : type,
      optional: Boolean(parameter.questionToken)
    };
  });
  return returnType && parameters.every(parameter => parameter.name && parameter.type) ? { returnType, parameters } : undefined;
};
const renderClass = (declaration, available, hasBase) => {
  const dependencies = new Set();
  const typeParameters = new Set((declaration.typeParameters ?? []).map(parameter => parameter.name.text));
  const nestedCallbacks = [];
  const instanceMembers = [];
  const staticMembers = [];
  const constructors = [];
  const accessors = new Map();
  const constructorDeclarations = declaration.members.filter(ts.isConstructorDeclaration);
  for (const [memberIndex, member] of declaration.members.entries()) {
    if (inaccessible(member)) continue;
    const target = hasModifier(member, ts.SyntaxKind.StaticKeyword) ? staticMembers : instanceMembers;
    if (ts.isConstructorDeclaration(member)) {
      const callback = callbackShape({ parameters: member.parameters, type: { kind: ts.SyntaxKind.VoidKeyword } }, available, dependencies, typeParameters, nestedCallbacks, `${declaration.name.text}Constructor${memberIndex + 1}`, declaration.name.text);
      if (!callback) return undefined;
      constructors.push(callback);
    } else if (ts.isPropertyDeclaration(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      if (member.questionToken && hasModifier(member, ts.SyntaxKind.ReadonlyKeyword)) {
        // Optional readonly is representable; the branch merely documents that
        // both flags participate independently below.
      }
      if (ts.isFunctionTypeNode(member.type)) {
        const callback = callbackShape(member.type, available, dependencies, typeParameters, nestedCallbacks, `${declaration.name.text}Property${memberIndex + 1}`, declaration.name.text);
        if (!callback) return undefined;
        target.push({ kind: "callbackProperty", name: member.name.text, optional: Boolean(member.questionToken), readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword), callback });
      } else {
        const type = fsharpType(member.type, available, dependencies, typeParameters);
        if (!type) return undefined;
        target.push({ kind: "property", name: member.name.text, type: member.questionToken ? asOption(type) : type, readonly: hasModifier(member, ts.SyntaxKind.ReadonlyKeyword) });
      }
    } else if (ts.isMethodDeclaration(member) && member.type && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      if (member.questionToken) return undefined;
      const callback = callbackShape(member, available, dependencies, typeParameters, nestedCallbacks, `${declaration.name.text}Method${memberIndex + 1}`, declaration.name.text);
      if (!callback) return undefined;
      target.push({ kind: "method", name: member.name.text, callback });
    } else if ((ts.isGetAccessorDeclaration(member) || ts.isSetAccessorDeclaration(member)) && (ts.isIdentifier(member.name) || ts.isStringLiteral(member.name))) {
      const key = `${hasModifier(member, ts.SyntaxKind.StaticKeyword) ? "static" : "instance"}|${member.name.text}`;
      const accessor = accessors.get(key) ?? { kind: "accessor", name: member.name.text, static: hasModifier(member, ts.SyntaxKind.StaticKeyword), canGet: false, canSet: false };
      if (ts.isGetAccessorDeclaration(member)) {
        const type = member.type ? fsharpType(member.type, available, dependencies, typeParameters) : undefined;
        if (!type) return undefined;
        accessor.type = type;
        accessor.canGet = true;
      } else {
        const type = member.parameters.length === 1 && member.parameters[0].type ? fsharpType(member.parameters[0].type, available, dependencies, typeParameters) : undefined;
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
  if (constructorDeclarations.length === 0 && !hasBase && !hasModifier(declaration, ts.SyntaxKind.AbstractKeyword)) {
    constructors.push({ parameters: [], returnType: "unit" });
  }
  return { instanceMembers, staticMembers, constructors, nestedCallbacks, dependencies: [...dependencies] };
};
const renderBase = (declaration, available) => {
  const extendsTypes = (declaration.heritageClauses ?? [])
    .filter(clause => clause.token === ts.SyntaxKind.ExtendsKeyword)
    .flatMap(clause => [...clause.types]);
  if (extendsTypes.length === 0) return undefined;
  if (extendsTypes.length !== 1 || !ts.isIdentifier(extendsTypes[0].expression)) return null;
  const name = extendsTypes[0].expression.text;
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
    if (declaration.typeParameters?.some(parameter => parameter.constraint || parameter.default)) continue;
    const module = normalize(declaration.getSourceFile().fileName).replace(/\.d\.ts$/, "");
    const packageName = module.startsWith("@babylonjs/core/")
      ? "@babylonjs/core"
      : module.startsWith("@babylonjs/loaders/")
        ? "@babylonjs/loaders"
        : undefined;
    if (!packageName) continue;
    const name = exported.getName();
    declarations.set(`${packageName}|${module}|${name}`, { package: packageName, module, name, declaration, arity: declaration.typeParameters?.length ?? 0 });
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
    renderAvailable.set(entry.name, { arity: entry.arity });
    const rendered = renderClass(entry.declaration, renderAvailable, Boolean(base));
    if (!rendered) continue;
    if (base && entry.declaration.members.every(member => !ts.isConstructorDeclaration(member))) {
      rendered.constructors = selectedByName.get(base.name).constructors.map(constructor => ({ ...constructor }));
    }
    additions.push([identity, { ...entry, ...rendered, base, rank }]);
  }
  if (additions.length === 0) break;
  for (const [identity, entry] of additions) {
    selected.set(identity, entry);
    selectedByName.set(entry.name, entry);
    available.set(entry.name, { arity: entry.arity });
  }
  rank += 1;
}
const entries = [...selected.values()].sort((left, right) => left.rank - right.rank || left.name.localeCompare(right.name));
const pascal = value => value.replace(/(^|[^A-Za-z0-9]+)([A-Za-z0-9])/g, (_, __, character) => character.toUpperCase());
const callbackArguments = callback => callback.parameters.length === 0
  ? "unit"
  : callback.parameters.map(parameter => `${parameter.optional ? "?" : ""}\`\`${parameter.name}\`\`: ${parameter.type}`).join(" * ");
const delegateType = callback => {
  const parameterTypes = callback.parameters.map(parameter => parameter.type);
  if (callback.returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
  return `System.Func<${[...parameterTypes, callback.returnType].join(", ")}>`;
};
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
  "/// Exact dependency-closed runtime classes exported by Babylon.js 9.19.0.",
  "module SimpleClasses ="
];
for (const entry of entries) {
  const genericParameters = entry.arity ? `<${entry.declaration.typeParameters.map(parameter => `'${parameter.name.text}`).join(", ")}>` : "";
  for (const nested of entry.nestedCallbacks) {
    lines.push("", `    /// Uncurried function-valued argument used by ${entry.name}.`, `    type ${nested.name}${nested.genericParameters} = ${delegateType(nested.callback)}`);
  }
  for (const member of [...entry.instanceMembers, ...entry.staticMembers].filter(member => member.kind === "callbackProperty")) {
    const helperName = `${entry.name}${pascal(member.name)}Callback`;
    member.helperName = `${helperName}${genericParameters}`;
    lines.push("", `    /// Function-valued ${entry.name}.${member.name} property.`, "    [<AllowNullLiteral>]", `    type ${helperName}${genericParameters} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${callbackArguments(member.callback)} -> ${member.callback.returnType}`);
  }
  lines.push("", `    /// ${entry.module}`, "    [<AllowNullLiteral>]", `    type ${entry.name}${genericParameters} =`);
  if (entry.base) lines.push(`        inherit ${entry.base.rendered}`);
  if (entry.instanceMembers.length === 0 && !entry.base) lines.push("        interface end");
  else for (const member of entry.instanceMembers) lines.push(`        ${renderMember(member)}`);
  lines.push("", "    [<AllowNullLiteral>]", `    type ${entry.name}Static =`);
  if (entry.base) lines.push(`        inherit ${entry.base.name}Static`);
  if (entry.constructors.length === 0 && entry.staticMembers.length === 0 && !entry.base) lines.push("        interface end");
  for (const constructor of entry.constructors) lines.push(`        [<EmitConstructor>] abstract Create${genericParameters}: ${callbackArguments(constructor)} -> ${entry.name}${genericParameters}`);
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
    ...(entry.arity ? { typeParameterCount: entry.arity } : {}),
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
console.log(`generated reviewed-promotion proposal for ${entries.length} exact dependency-closed classes (${sha256(proposal)})`);
