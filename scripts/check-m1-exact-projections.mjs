import { readFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const readJson = async path => JSON.parse(await readFile(resolve(root, path), "utf8"));
const read = path => readFile(resolve(root, path), "utf8");
const identity = value => `${value.package}|${value.module}|${value.name}`;
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

const interfaces = await read("src/BabylonjsBindings/SimpleInterfaces.fs");
const functions = await read("src/BabylonjsBindings/SimpleFunctions.fs");
const classes = await read("src/BabylonjsBindings/SimpleClasses.fs");
for (const [exportName, supportName] of [["PointerInputMapEntry", "BrowserPointerInputMapEntry"], ["WheelInputMapEntry", "BrowserWheelInputMapEntry"], ["TouchInputMapEntry", "BrowserTouchInputMapEntry"], ["KeyboardInputMapEntry", "BrowserKeyboardInputMapEntry"], ["InputMapEntry", "BrowserInputMapEntry"], ["InteractionName", "JavaScriptKeyOf"]]) {
  if (!interfaces.includes(`type ${exportName}<'T`) || !interfaces.includes(`= ${supportName}<'T`)) throw new Error(`missing exact support alias ${exportName} -> ${supportName}`);
}
if (!interfaces.includes("type TypedArrayConstructor<'T> = BrowserTypedArrayConstructor<'T>")) throw new Error("TypedArrayConstructor is not the reviewed support alias");

const alignedBlock = functions.slice(functions.indexOf("type FunctionBinding_CreateAlignedTypedArray"), functions.indexOf("let ``CreateAlignedTypedArray``"));
const correlationNames = [...alignedBlock.matchAll(/abstract (Invoke[A-Za-z0-9]+):/g)].map(match => match[1]);
if (correlationNames.length !== 11 || new Set(correlationNames).size !== 11 || alignedBlock.includes("Invoke<'T")) throw new Error("typed-array constructor/return matrix is not the exact finite 11-case projection");

const nodesBlock = interfaces.slice(interfaces.indexOf("type IGLTFObjectModelTreeNodeWeightsArray"), interfaces.indexOf("type IGLTFObjectModelTreeExtensionsObject"));
for (const member of ["inherit IObjectAccessor", "``length``", "``__array__``", "``translation``", "``rotation``", "``scale``", "``matrix``", "``globalMatrix``", "``weights``", "``extensions``"]) if (!nodesBlock.includes(member)) throw new Error(`glTF node intersection lacks ${member}`);
if (nodesBlock.includes("U2<") || nodesBlock.includes(": obj")) throw new Error("glTF node intersection contains a lossy union or object fallback");
const treeBlock = interfaces.slice(interfaces.indexOf("type IGLTFObjectModelTree ="), interfaces.indexOf("type IGLTFObjectModelTreeExtensionsObject"));
for (const member of ["cameras", "nodes", "materials", "extensions", "animations", "meshes"]) if (!treeBlock.includes(`\`\`${member}\`\``)) throw new Error(`glTF tree lacks ${member}`);

for (const [name, module] of [["PhysicsEngineV1", "@babylonjs/core/Physics/v1/physicsEngine.js"], ["PhysicsEngineV2", "@babylonjs/core/Physics/v2/physicsEngine.js"]]) {
  if (!classes.includes(`[<Import("PhysicsEngine", "${module}")>]\n    let ${name}:`)) throw new Error(`missing exact collision import for ${name}`);
}
if (classes.includes(`[<Import("GLTFLoaderOptions"`)) throw new Error("type-only GLTFLoaderOptions acquired a fictitious runtime import");
if (!functions.includes('[<Import("GetMappingForKey", "@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping.js")>]')) throw new Error("GetMappingForKey deep import drifted");
if (!functions.includes('[<Import("deepMerge", "@babylonjs/core/Misc/deepMerger.js")>]')) throw new Error("deepMerge deep import drifted");

console.log(JSON.stringify({ schemaVersion: 1, milestone: "M1", exports: targets.length, coverage: coverage.summary, typedArrayCorrelations: correlationNames, intersections: { unionFallbacks: 0, objectFallbacks: 0 }, runtimeCollisions: 2, lossy: 0 }, null, 2));
