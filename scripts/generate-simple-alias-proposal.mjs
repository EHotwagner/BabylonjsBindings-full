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
  .flatMap(manifest => manifest.exports);
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
const isAbsentType = node => node.kind === ts.SyntaxKind.UndefinedKeyword
  || (ts.isLiteralTypeNode(node) && node.literal.kind === ts.SyntaxKind.NullKeyword);
const asOption = type => type.endsWith(" option") ? type : `${type} option`;
const erasedUnionType = branches => {
  if (branches.length < 2) return branches[0];
  if (branches.length <= 9) return `U${branches.length}<${branches.join(", ")}>`;
  return `U2<${erasedUnionType(branches.slice(0, 8))}, ${erasedUnionType(branches.slice(8))}>`;
};

const fsharpType = node => {
  if (node.kind === ts.SyntaxKind.StringKeyword) return "string";
  if (node.kind === ts.SyntaxKind.NumberKeyword) return "System.Double";
  if (node.kind === ts.SyntaxKind.BooleanKeyword) return "bool";
  if (node.kind === ts.SyntaxKind.VoidKeyword) return "unit";
  if (node.kind === ts.SyntaxKind.AnyKeyword || node.kind === ts.SyntaxKind.UnknownKeyword) return "obj";
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
  if (ts.isUnionTypeNode(node) && node.types.length >= 2) {
    const branches = node.types.map(fsharpType);
    return branches.every(Boolean) ? erasedUnionType(branches) : undefined;
  }
  if (ts.isArrayTypeNode(node)) {
    const element = fsharpType(node.elementType);
    return element ? `ResizeArray<${element}>` : undefined;
  }
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
    && !node.parameters.some(parameter => parameter.dotDotDotToken || parameter.questionToken)) {
    const parameterTypes = node.parameters.map(parameter => parameter.type ? fsharpType(parameter.type) : undefined);
    const returnType = fsharpType(node.type);
    if (returnType && parameterTypes.every(Boolean)) {
      if (returnType === "unit") return parameterTypes.length === 0 ? "System.Action" : `System.Action<${parameterTypes.join(", ")}>`;
      return `System.Func<${[...parameterTypes, returnType].join(", ")}>`;
    }
  }
  if (ts.isTypeReferenceNode(node) && ts.isIdentifier(node.typeName)) {
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
    if (node.typeName.text === "Map" && node.typeArguments?.length === 2) {
      const key = fsharpType(node.typeArguments[0]);
      const value = fsharpType(node.typeArguments[1]);
      return key && value ? `JS.Map<${key}, ${value}>` : undefined;
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
      && node.typeArguments[0].typeName.text === "ArrayBuffer"
      && !node.typeArguments[0].typeArguments?.length) return `JS.${node.typeName.text}`;
    const browserTypes = new Set(["AudioBuffer", "AudioContext", "AudioNode", "Blob", "Event", "File", "HTMLElement", "HTMLCanvasElement", "HTMLImageElement", "HTMLVideoElement", "ImageData", "KeyboardEvent", "OfflineAudioContext", "WebGLRenderingContext"]);
    if (!node.typeArguments?.length && browserTypes.has(node.typeName.text)) return `Browser.Types.${node.typeName.text}`;
    const maintained = maintainedSymbols.get(node.typeName.text);
    if (maintained) {
      const arguments_ = node.typeArguments ?? [];
      if (arguments_.length !== maintained.arity) return undefined;
      const renderedArguments = arguments_.map(fsharpType);
      if (renderedArguments.some(argument => !argument)) return undefined;
      return maintained.arity === 0 ? maintained.fsharpSymbol : `${maintained.fsharpSymbol}<${renderedArguments.join(", ")}>`;
    }
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
      if (!rendered) return undefined;
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
      if (!keyType || !valueType) return undefined;
      members.push({ kind: "indexer", name: member.parameters[0].name.text, keyType, valueType, readonly: member.modifiers?.some(modifier => modifier.kind === ts.SyntaxKind.ReadonlyKeyword) ?? false });
    } else return undefined;
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
      if (!rendered) return undefined;
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
const lines = [
  "// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after alias review, compile, and runtime proof",
  "namespace BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  "/// Exact primitive aliases and dependency-free callbacks exported by Babylon.js 9.19.0.",
  "module TypeAliases ="
];
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
  } else if (entry.shape === "callback") {
    const argumentsType = entry.parameters.length === 0
      ? "unit"
      : entry.parameters.map(parameter => `${parameter.optional ? "?" : ""}${parameter.name}: ${parameter.type}`).join(" * ");
    lines.push("    [<AllowNullLiteral>]", `    type ${entry.name} =`, `        [<Emit("$0($1...)")>] abstract Invoke: ${argumentsType} -> ${entry.returnType}`);
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
    ...(entry.deepImmutableTarget ? { deepImmutableSymbol: `BabylonjsBindings.TypeAliases.DeepImmutable${entry.name}` } : {}),
    shape: entry.shape,
    ...(entry.shape === "genericAlias" ? { typeParameterCount: 1 } : {}),
    memberCount: entry.shape === "callback" ? entry.parameters.length : entry.shape === "objectAlias" ? entry.members.length : entry.shape === "intersectionAlias" ? entry.bases.length + entry.members.length : 1
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
