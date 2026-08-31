import { readFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const program = await readFile(resolve(root, "runtime/m3-dist/Program.js"), "utf8");
const expected = [
  ["makeSyncFunction", "@babylonjs/core/Misc/coroutine.js"],
  ["makeAsyncFunction", "@babylonjs/core/Misc/coroutine.js"],
  ["expandToProperty", "@babylonjs/core/Misc/decorators.js"],
  ["addAccessorsForMaterialProperty", "@babylonjs/core/Misc/decorators.js"],
  ["nativeOverride", "@babylonjs/core/Misc/decorators.js"],
  ["ImageProcessingMixin", "@babylonjs/core/Materials/imageProcessing.js"],
  ["ImageProcessingDefinesMixin", "@babylonjs/core/Materials/imageProcessingConfiguration.defines.js"],
  ["UVDefinesMixin", "@babylonjs/core/Materials/uv.defines.js"]
];
for (const [name, module] of expected) {
  if (!program.includes(name) || !program.includes(`from "${module}"`)) throw new Error(`missing exact emitted import ${name} from ${module}`);
}
if (!program.includes("nativeOverride.filter") || !program.includes("direct.call(thisArg") || !program.includes("filtered.call(thisArg")) {
  throw new Error("emitted decorator property access or explicit this-call semantics missing");
}
if (!program.includes("makeSyncFunction(factory)") || !program.includes("makeAsyncFunction(factory, scheduler)")) {
  throw new Error("emitted coroutine factories lost positional call semantics");
}
for (const call of ["expandToProperty(\"markDirty\")", "expandToProperty(\"markDirty\", null)", "addAccessorsForMaterialProperty(\"markDirty\")", "addAccessorsForMaterialProperty(\"markDirty\", null)"]) {
  if (!program.includes(call)) throw new Error(`missing emitted decorator omitted/null call: ${call}`);
}
console.log("M3 emitted calls exact: 8 exports, callable filter, explicit this");
