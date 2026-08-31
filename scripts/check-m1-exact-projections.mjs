import { readFile } from "node:fs/promises";
import { resolve } from "node:path";
import { createHash } from "node:crypto";

const root = resolve(import.meta.dirname, "..");
const readJson = async path => JSON.parse(await readFile(resolve(root, path), "utf8"));
const read = path => readFile(resolve(root, path), "utf8");
const identity = value => `${value.package}|${value.module}|${value.name}`;
const sha256 = value => createHash("sha256").update(value).digest("hex");
const targets = [
  ["@babylonjs/core", "@babylonjs/core/Cameras/inputMapper", "InputMapEntry"],
  ["@babylonjs/core", "@babylonjs/core/Cameras/inputMapper", "InteractionName"],
  ["@babylonjs/core", "@babylonjs/core/Cameras/inputMapper", "KeyboardInputMapEntry"],
  ["@babylonjs/core", "@babylonjs/core/Cameras/inputMapper", "PointerInputMapEntry"],
  ["@babylonjs/core", "@babylonjs/core/Cameras/inputMapper", "TouchInputMapEntry"],
  ["@babylonjs/core", "@babylonjs/core/Cameras/inputMapper", "WheelInputMapEntry"],
  ["@babylonjs/core", "@babylonjs/core/types", "TypedArrayConstructor"],
  ["@babylonjs/core", "@babylonjs/core/Buffers/bufferUtils", "CreateAlignedTypedArray"],
  ["@babylonjs/core", "@babylonjs/core/Physics/v1/physicsEngine", "PhysicsEngine"],
  ["@babylonjs/core", "@babylonjs/core/Physics/v2/physicsEngine", "PhysicsEngine"],
  ["@babylonjs/loaders", "@babylonjs/loaders/glTF/glTFFileLoader.pure", "GLTFLoaderOptions"],
  ["@babylonjs/loaders", "@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping", "IGLTFObjectModelTreeNodesObject"],
  ["@babylonjs/loaders", "@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping", "IGLTFObjectModelTree"],
  ["@babylonjs/loaders", "@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping", "GetMappingForKey"],
  ["@babylonjs/core", "@babylonjs/core/Misc/deepMerger", "deepMerge"]
].map(([packageName, module, name]) => `${packageName}|${module}|${name}`).sort();

const coverage = await readJson("coverage-and-drift.json");
const actualTargets = coverage.exports.filter(entry => targets.includes(identity(entry)) && entry.disposition === "typed").map(identity).sort();
if (JSON.stringify(actualTargets) !== JSON.stringify(targets)) throw new Error("the exact M1 target identity set is not typed");
if (JSON.stringify(coverage.summary) !== JSON.stringify({ total: 4323, typed: 4252, runtimeOnly: 1, blocked: 70, lossy: 0 })) throw new Error(`unexpected coverage totals: ${JSON.stringify(coverage.summary)}`);

const lock = await readJson("declaration-lock.json");
const lockedFiles = new Map(lock.files.map(file => [file.path, file.sha256]));
const manifest = await readJson("analysis/m1-exact-projection-manifest.json");
if (manifest.projections.length !== 8) throw new Error("expected eight existing-projection manifest entries");
for (const projection of manifest.projections) {
  const declaration = await read(projection.declaration.path);
  const support = await read(projection.support.path);
  for (const snippet of projection.declaration.snippets) if (!declaration.includes(snippet)) throw new Error(`${projection.identity}: locked declaration lacks ${snippet}`);
  for (const snippet of projection.support.snippets) if (!support.includes(snippet)) throw new Error(`${projection.identity}: support projection lacks ${snippet}`);
  const lockPath = projection.declaration.path.replace(/^node_modules\//, "");
  const lockedDigest = lockedFiles.get(lockPath);
  if (!lockedDigest || sha256(declaration) !== lockedDigest) throw new Error(`${projection.identity}: declaration does not match declaration-lock.json`);
  const structuralDigest = sha256(JSON.stringify(projection.semanticShape));
  if (projection.declarationStructuralDigest !== structuralDigest || projection.supportStructuralDigest !== structuralDigest) {
    throw new Error(`${projection.identity}: declaration/support structural digests differ from reviewed semantic shape`);
  }
}

const interfaces = await read("src/BabylonjsBindings/SimpleInterfaces.fs");
const functions = await read("src/BabylonjsBindings/SimpleFunctions.fs");
const classes = await read("src/BabylonjsBindings/SimpleClasses.fs");
for (const [exportName, supportName] of [["PointerInputMapEntry", "BrowserPointerInputMapEntry"], ["WheelInputMapEntry", "BrowserWheelInputMapEntry"], ["TouchInputMapEntry", "BrowserTouchInputMapEntry"], ["KeyboardInputMapEntry", "BrowserKeyboardInputMapEntry"], ["InputMapEntry", "BrowserInputMapEntry"], ["InteractionName", "JavaScriptKeyOf"]]) {
  if (!interfaces.includes(`type ${exportName}<'T`) || !interfaces.includes(`= ${supportName}<'T`)) throw new Error(`missing exact support alias ${exportName} -> ${supportName}`);
}
for (const exportName of ["PointerInputMapEntry", "WheelInputMapEntry", "TouchInputMapEntry", "KeyboardInputMapEntry", "InputMapEntry"]) {
  if (!interfaces.includes(`type ${exportName} = ${exportName}<string>`)) throw new Error(`missing TypeScript-default convenience projection for ${exportName}`);
}
if (!interfaces.includes("type TypedArrayConstructor<'T> = BrowserTypedArrayConstructor<'T>")) throw new Error("TypedArrayConstructor is not the reviewed support alias");
if (!interfaces.includes("type TypedArrayConstructor = TypedArrayConstructor<BabylonjsBindings.TypeAliases.TypedArray>")) throw new Error("TypedArrayConstructor default specialization is missing");

const alignedBlock = functions.slice(functions.indexOf("type FunctionBinding_CreateAlignedTypedArray"), functions.indexOf("let ``CreateAlignedTypedArray``"));
const correlationNames = [...alignedBlock.matchAll(/abstract (Invoke[A-Za-z0-9]+):/g)].map(match => match[1]);
if (correlationNames.length !== 11 || new Set(correlationNames).size !== 11 || alignedBlock.includes("Invoke<'T")) throw new Error("typed-array constructor/return matrix is not the exact finite 11-case projection");
const typedArrayCorrelations = new Map([
  ["InvokeInt8", "JS.Int8Array"], ["InvokeUint8", "JS.Uint8Array"], ["InvokeUint8Clamped", "JS.Uint8ClampedArray"],
  ["InvokeInt16", "JS.Int16Array"], ["InvokeUint16", "JS.Uint16Array"], ["InvokeInt32", "JS.Int32Array"],
  ["InvokeUint32", "JS.Uint32Array"], ["InvokeFloat32", "JS.Float32Array"], ["InvokeFloat64", "JS.Float64Array"],
  ["InvokeBigInt64", "JS.BigInt64Array"], ["InvokeBigUint64", "BabylonjsBindings.SimpleInterfaces.BrowserBigUint64Array"]
]);
for (const [method, type] of typedArrayCorrelations) {
  const expected = `abstract ${method}: \`\`type\`\`: BabylonjsBindings.SimpleInterfaces.TypedArrayConstructor<${type}> * \`\`elementCount\`\`: float -> ${type}`;
  if (!alignedBlock.includes(expected)) throw new Error(`${method} does not preserve constructor/return correlation for ${type}`);
}

const nodesBlock = interfaces.slice(interfaces.indexOf("type IGLTFObjectModelTreeNodeWeightsArray"), interfaces.indexOf("type IGLTFObjectModelTreeExtensionsObject"));
for (const member of ["inherit IObjectAccessor", "``length``", "``__array__``", "``translation``", "``rotation``", "``scale``", "``matrix``", "``globalMatrix``", "``weights``", "``extensions``"]) if (!nodesBlock.includes(member)) throw new Error(`glTF node intersection lacks ${member}`);
if (nodesBlock.includes("U2<") || nodesBlock.includes(": obj")) throw new Error("glTF node intersection contains a lossy union or object fallback");
if (!interfaces.includes("type IGLTFObjectModelTreeNodesObject<'GLTFTargetType> = IGLTFObjectModelTreeNodesObject<'GLTFTargetType, BabylonjsBindings.SimpleClasses.TransformNode>")) throw new Error("glTF nodes one-argument default specialization is missing");
if (!interfaces.includes("type IGLTFObjectModelTreeNodesObject = IGLTFObjectModelTreeNodesObject<INode, BabylonjsBindings.SimpleClasses.TransformNode>")) throw new Error("glTF nodes zero-argument default specialization is missing");
const treeBlock = interfaces.slice(interfaces.indexOf("type IGLTFObjectModelTree ="), interfaces.indexOf("type IGLTFObjectModelTreeExtensionsObject"));
for (const member of ["cameras", "nodes", "materials", "extensions", "animations", "meshes"]) if (!treeBlock.includes(`\`\`${member}\`\``)) throw new Error(`glTF tree lacks ${member}`);

for (const [name, module] of [["PhysicsEngineV1", "@babylonjs/core/Physics/v1/physicsEngine.js"], ["PhysicsEngineV2", "@babylonjs/core/Physics/v2/physicsEngine.js"]]) {
  if (!classes.includes(`[<Import("PhysicsEngine", "${module}")>]\n    let ${name}:`)) throw new Error(`missing exact collision import for ${name}`);
}
if (classes.includes(`[<Import("GLTFLoaderOptions"`)) throw new Error("type-only GLTFLoaderOptions acquired a fictitious runtime import");
if (!functions.includes('[<Import("GetMappingForKey", "@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping.js")>]')) throw new Error("GetMappingForKey deep import drifted");
if (!functions.includes('[<Import("deepMerge", "@babylonjs/core/Misc/deepMerger.js")>]')) throw new Error("deepMerge deep import drifted");

console.log(JSON.stringify({ schemaVersion: 1, milestone: "M1", exports: targets.length, coverage: coverage.summary, exactExistingProjections: manifest.projections.length, lockedDeclarationsVerified: manifest.projections.length, structuralDigestMatches: manifest.projections.length, typedArrayCorrelations: correlationNames, intersections: { unionFallbacks: 0, objectFallbacks: 0 }, runtimeCollisions: 2, lossy: 0 }, null, 2));
