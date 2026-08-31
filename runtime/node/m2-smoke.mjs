import { DeviceSourceManager } from "@babylonjs/core/DeviceInput/InputDevices/deviceSourceManager.js";
import { InternalDeviceSourceManager } from "@babylonjs/core/DeviceInput/internalDeviceSourceManager.pure.js";
import { FlowGraphAssetType, GetFlowGraphAssetWithType } from "@babylonjs/core/FlowGraph/flowGraphAssetsContext.js";
import { WebXRFeatureName, WebXRFeaturesManager } from "@babylonjs/core/XR/webXRFeaturesManager.js";
import { WebXRExperienceHelper } from "@babylonjs/core/XR/webXRExperienceHelper.js";
import { WebXREnterExitUI } from "@babylonjs/core/XR/webXREnterExitUI.js";
import { WebXRDefaultExperience } from "@babylonjs/core/XR/webXRDefaultExperience.js";
import { VRExperienceHelper } from "@babylonjs/core/Cameras/VR/vrExperienceHelper.pure.js";
import { HandConstraintBehavior } from "@babylonjs/core/Behaviors/Meshes/handConstraintBehavior.js";

const assets = {
  animations: [{ uniqueId: 11, kind: "animation" }], animationGroups: [{ uniqueId: 12, kind: "group" }],
  meshes: [{ uniqueId: 13, kind: "mesh" }], materials: [{ uniqueId: 14, kind: "material" }],
  cameras: [{ uniqueId: 15, kind: "camera" }], lights: [{ uniqueId: 16, kind: "light" }]
};
const expected = [
  [FlowGraphAssetType.Animation, "animation"], [FlowGraphAssetType.AnimationGroup, "group"],
  [FlowGraphAssetType.Mesh, "mesh"], [FlowGraphAssetType.Material, "material"],
  [FlowGraphAssetType.Camera, "camera"], [FlowGraphAssetType.Light, "light"]
];
for (const [kind, value] of expected) if (GetFlowGraphAssetWithType(assets, kind, 0)?.kind !== value) throw new Error(`FlowGraph ${kind} correlation failed`);
const names = Object.values(WebXRFeatureName);
if (new Set(names).size !== 22) throw new Error(`expected 22 unique WebXR names, got ${new Set(names).size}`);
const available = WebXRFeaturesManager.GetAvailableFeatures();
if (!Array.isArray(available)) throw new Error("WebXR feature registry did not return an array");
const behavior = new HandConstraintBehavior();
if (behavior.name !== "HandConstraint") throw new Error("HandConstraintBehavior runtime export did not construct");
for (const runtimeExport of [DeviceSourceManager, InternalDeviceSourceManager, WebXRFeaturesManager, WebXRExperienceHelper, WebXREnterExitUI, WebXRDefaultExperience, VRExperienceHelper, HandConstraintBehavior]) {
  if (typeof runtimeExport !== "function") throw new Error("M2 runtime class export missing");
}
console.log("M2 Node smoke passed: 6 FlowGraph rows, 22 WebXR names, 8 runtime classes");
