import { GLTF1, GLTF2 } from "@babylonjs/loaders/glTF/index.js";
import manifest from "../../analysis/m5-gltf-namespace-manifest.json" with { type: "json" };

for (const [name, runtime] of [["GLTF1", GLTF1], ["GLTF2", GLTF2]]) {
  const expected = manifest.namespaces.find(item => item.name === name).runtimeKeys;
  const actual = Object.keys(runtime).sort();
  if (JSON.stringify(actual) !== JSON.stringify(expected)) throw new Error(`${name} runtime namespace keys drifted`);
  for (const key of expected) if (runtime[key] === undefined) throw new Error(`${name}.${key} is undefined`);
}
console.log("M5 runtime namespaces passed: 14 GLTF1 and 114 GLTF2 keys");
