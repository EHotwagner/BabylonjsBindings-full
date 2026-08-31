import { makeAsyncFunction, makeSyncFunction, inlineScheduler } from "@babylonjs/core/Misc/coroutine.js";
import { addAccessorsForMaterialProperty, expandToProperty, nativeOverride } from "@babylonjs/core/Misc/decorators.js";
import { ImageProcessingMixin } from "@babylonjs/core/Materials/imageProcessing.js";
import { ImageProcessingDefinesMixin } from "@babylonjs/core/Materials/imageProcessingConfiguration.defines.js";
import { UVDefinesMixin } from "@babylonjs/core/Materials/uv.defines.js";
import { MaterialDefines } from "@babylonjs/core/Materials/materialDefines.js";

const ten = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
const sync = makeSyncFunction(function* (...args) { yield; return args.reduce((a, b) => a + b, 0); });
if (sync(...ten) !== 55) throw new Error("arity-10 sync coroutine correlation failed");
const asyncFn = makeAsyncFunction(function* (...args) { yield Promise.resolve(); return args.join(""); }, inlineScheduler);
if (await asyncFn(...ten) !== "12345678910") throw new Error("arity-10 async coroutine correlation failed");

const accessorContext = { name: "value", static: false, private: false, metadata: {}, access: {}, addInitializer() {} };
const backing = { _value: 2, dirty: 0, markDirty() { this.dirty++; } };
const expanded = expandToProperty("markDirty")(undefined, accessorContext);
expanded.set.call(backing, 7);
if (expanded.get.call(backing) !== 7 || backing.dirty !== 1) throw new Error("expandToProperty this/result semantics failed");
const explicit = { backing: 11, _value: 2, dirty: 0, markDirty() { this.dirty++; } };
const explicitlyNamed = expandToProperty("markDirty", "backing")(undefined, accessorContext);
explicitlyNamed.set.call(explicit, 12);
const explicitlyNull = expandToProperty("markDirty", null)(undefined, accessorContext);
explicitlyNull.set.call(explicit, 13);
if (explicit.backing !== 12 || explicit._value !== 13 || explicit.dirty !== 2) throw new Error("expandToProperty named/null key semantics failed");
const wrapped = { _value: { value: 3 }, dirty: 0, markDirty() { this.dirty++; } };
const materialAccessor = addAccessorsForMaterialProperty("markDirty")(undefined, accessorContext);
materialAccessor.set.call(wrapped, 9);
if (materialAccessor.get.call(wrapped) !== 9 || wrapped.dirty !== 1) throw new Error("material accessor this/result semantics failed");
const materialKeys = { backing: { value: 4 }, _value: { value: 5 }, dirty: 0, markDirty() { this.dirty++; } };
addAccessorsForMaterialProperty("markDirty", "backing")(undefined, accessorContext).set.call(materialKeys, 14);
addAccessorsForMaterialProperty("markDirty", null)(undefined, accessorContext).set.call(materialKeys, 15);
if (materialKeys.backing.value !== 14 || materialKeys._value.value !== 15 || materialKeys.dirty !== 2) throw new Error("material accessor named/null key semantics failed");

const methodContext = { name: "sum", static: false, private: false, metadata: {}, access: {}, addInitializer() {} };
const original = function (...args) { return this.bias + args.reduce((a, b) => a + b, 0); };
const direct = nativeOverride(original, methodContext);
if (direct.call({ bias: 5 }, ...ten) !== 60) throw new Error("nativeOverride original this semantics failed");
const filtered = nativeOverride.filter((...args) => args.length === 10)(original, methodContext);
if (filtered.call({ bias: 5 }, ...ten) !== 60) throw new Error("nativeOverride.filter JS branch/this failed");
if (typeof nativeOverride.filter !== "function") throw new Error("nativeOverride.filter callable property missing");

const UVDefines = UVDefinesMixin(MaterialDefines);
const uv = new UVDefines();
uv.UV6 = true;
uv.markAsProcessed();
if (uv.UV6 !== true || uv._isDirty !== false) throw new Error("UV both-member mixin result failed");
for (const name of ["BackgroundMaterialDefinesBase", "PBRMaterialDefinesBase", "StandardMaterialDefinesBase", "OpenPBRMaterialDefinesWithEnvLighting", "NodeMaterialDefinesBase"]) {
  const Base = { [name]: class extends MaterialDefines { constructor() { super(); this.baseIdentity = name; } } }[name];
  const ImageDefines = ImageProcessingDefinesMixin(Base);
  const imageDefines = new ImageDefines();
  imageDefines.IMAGEPROCESSING = true;
  imageDefines.markAsProcessed();
  if (imageDefines.baseIdentity !== name || imageDefines.IMAGEPROCESSING !== true || imageDefines._isDirty !== false) throw new Error(`${name} image defines both-member mixin result failed`);
}
class BaseMaterial { constructor(name) { this.name = name; this._scene = null; } getScene() { return this._scene; } }
const ImageMaterial = ImageProcessingMixin(BaseMaterial);
const imageMaterial = new ImageMaterial("mixed");
imageMaterial._imageProcessingConfiguration = { exposure: 1 };
imageMaterial.cameraExposure = 1.25;
if (imageMaterial.name !== "mixed" || imageMaterial.cameraExposure !== 1.25) throw new Error("image processing both-member mixin result failed");

console.log("M3 Node smoke passed: arity 0-10 boundary, null/omitted decorators, 5 defines bases, 3 mixins");
