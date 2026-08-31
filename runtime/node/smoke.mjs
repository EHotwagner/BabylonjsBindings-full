import { NullEngine } from "@babylonjs/core/Engines/nullEngine.js";
import { Scene } from "@babylonjs/core/scene.js";
import { Vector3 } from "@babylonjs/core/Maths/math.vector.js";
import { FreeCamera } from "@babylonjs/core/Cameras/freeCamera.js";
import { HemisphericLight } from "@babylonjs/core/Lights/hemisphericLight.js";
import { MeshBuilder } from "@babylonjs/core/Meshes/meshBuilder.js";
import { GetRegisteredSceneLoaderPluginMetadata } from "@babylonjs/core/Loading/sceneLoader.js";
import { registeredGLTFExtensions } from "@babylonjs/loaders/glTF/2.0/glTFLoaderExtensionRegistry.js";
import { CreateAlignedTypedArray } from "@babylonjs/core/Buffers/bufferUtils.js";
import { deepMerge } from "@babylonjs/core/Misc/deepMerger.js";
import { PhysicsEngine as PhysicsEngineV1 } from "@babylonjs/core/Physics/v1/physicsEngine.js";
import { PhysicsEngine as PhysicsEngineV2 } from "@babylonjs/core/Physics/v2/physicsEngine.js";
import { GetMappingForKey } from "@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping.js";
import "@babylonjs/loaders/glTF/index.js";

const engine = new NullEngine();
const scene = new Scene(engine);
new FreeCamera("camera", new Vector3(0, 0, 0), scene);
new HemisphericLight("light", new Vector3(0, 1, 0), scene);
const box = MeshBuilder.CreateBox("box", {}, scene);
if (!box || scene.meshes.length !== 1) throw new Error("Babylon runtime slice did not construct a mesh");
if (!Array.isArray(GetRegisteredSceneLoaderPluginMetadata())) throw new Error("SceneLoader plugin metadata did not return an array");
if (!(registeredGLTFExtensions instanceof Map)) throw new Error("glTF extension registry did not resolve as a readonly map");
const typedArrayConstructors = [Int8Array, Uint8Array, Uint8ClampedArray, Int16Array, Uint16Array, Int32Array, Uint32Array, Float32Array, Float64Array, BigInt64Array, BigUint64Array];
for (const TypedArray of typedArrayConstructors) {
  const aligned = CreateAlignedTypedArray(TypedArray, 3);
  if (!(aligned instanceof TypedArray) || aligned.length < 3) throw new Error(`aligned typed-array correlation failed for ${TypedArray.name}`);
}
const merged = deepMerge({ nested: { left: 1 }, items: [1] }, { nested: { right: 2 }, items: [2] });
if (merged.nested.left !== 1 || merged.nested.right !== 2 || merged.items.join(",") !== "1,2") throw new Error("deepMerge runtime contract failed");
const emissiveMapping = GetMappingForKey("/materials/{}/emissiveFactor");
if (!emissiveMapping || typeof emissiveMapping.get !== "function" || typeof emissiveMapping.getTarget !== "function") throw new Error("glTF object mapping import failed");
if (PhysicsEngineV1 === PhysicsEngineV2 || PhysicsEngineV1.name !== "PhysicsEngine" || PhysicsEngineV2.name !== "PhysicsEngine") throw new Error("physics engine module collision was not preserved");
engine.dispose();
console.log("Babylon runtime smoke passed");
