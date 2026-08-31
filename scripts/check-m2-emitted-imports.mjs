import { readFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const program = await readFile(resolve(root, "runtime/m2-dist/Program.js"), "utf8");
const expected = [
  ["DeviceSourceManager", "@babylonjs/core/DeviceInput/InputDevices/deviceSourceManager.js"],
  ["InternalDeviceSourceManager", "@babylonjs/core/DeviceInput/internalDeviceSourceManager.pure.js"],
  ["GetFlowGraphAssetWithType", "@babylonjs/core/FlowGraph/flowGraphAssetsContext.js"],
  ["WebXRFeaturesManager", "@babylonjs/core/XR/webXRFeaturesManager.js"],
  ["WebXRExperienceHelper", "@babylonjs/core/XR/webXRExperienceHelper.js"],
  ["WebXREnterExitUI", "@babylonjs/core/XR/webXREnterExitUI.js"],
  ["WebXRDefaultExperience", "@babylonjs/core/XR/webXRDefaultExperience.js"],
  ["VRExperienceHelper", "@babylonjs/core/Cameras/VR/vrExperienceHelper.pure.js"],
  ["HandConstraintBehavior", "@babylonjs/core/Behaviors/Meshes/handConstraintBehavior.js"]
];
for (const [name, module] of expected) {
  if (!program.includes(name) || !program.includes(`from \"${module}\"`)) throw new Error(`missing exact emitted import ${name} from ${module}`);
}
console.log(`M2 emitted imports exact: ${expected.length} runtime modules`);
