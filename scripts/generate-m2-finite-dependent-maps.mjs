import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const check = process.argv.includes("--check");
const sha256 = value => createHash("sha256").update(value).digest("hex");

const device = [
  ["Generic", "DeviceTypeGeneric", "float", "Never"],
  ["Keyboard", "DeviceTypeKeyboard", "float", "IKeyboardEvent"],
  ["Mouse", "DeviceTypeMouse", "PointerDeviceInput", "U2<IWheelEvent, IPointerEvent>"],
  ["Touch", "DeviceTypeTouch", "PointerDeviceInput", "IPointerEvent"],
  ["DualShock", "DeviceTypeDualShock", "DualShockInput", "Never"],
  ["Xbox", "DeviceTypeXbox", "XboxInput", "Never"],
  ["Switch", "DeviceTypeSwitch", "SwitchInput", "Never"],
  ["DualSense", "DeviceTypeDualSense", "DualSenseInput", "Never"]
];
const flow = [
  ["Animation", "FlowGraphAnimationAsset", "Animation"],
  ["AnimationGroup", "FlowGraphAnimationGroupAsset", "AnimationGroup"],
  ["Mesh", "FlowGraphMeshAsset", "Mesh"],
  ["Material", "FlowGraphMaterialAsset", "Material"],
  ["Camera", "FlowGraphCameraAsset", "Camera"],
  ["Light", "FlowGraphLightAsset", "Light"]
];
const xr = [
  ["ANCHOR_SYSTEM", "xr-anchor-system", "XRAnchorSystem", "IWebXRAnchorSystemOptions", "WebXRAnchorSystem"],
  ["BACKGROUND_REMOVER", "xr-background-remover", "XRBackgroundRemover", "IWebXRBackgroundRemoverOptions", "WebXRBackgroundRemover"],
  ["HIT_TEST", "xr-hit-test", "XRHitTest", "IWebXRHitTestOptions", "WebXRHitTest"],
  ["MESH_DETECTION", "xr-mesh-detection", "XRMeshDetection", "IWebXRMeshDetectorOptions", "WebXRMeshDetector"],
  ["PHYSICS_CONTROLLERS", "xr-physics-controller", "XRPhysicsController", "IWebXRControllerPhysicsOptions", "WebXRControllerPhysics"],
  ["PLANE_DETECTION", "xr-plane-detection", "XRPlaneDetection", "IWebXRPlaneDetectorOptions", "WebXRPlaneDetector"],
  ["POINTER_SELECTION", "xr-controller-pointer-selection", "XRPointerSelection", "IWebXRControllerPointerSelectionOptions", "WebXRControllerPointerSelection"],
  ["TELEPORTATION", "xr-controller-teleportation", "XRTeleportation", "IWebXRTeleportationOptions", "WebXRMotionControllerTeleportation"],
  ["FEATURE_POINTS", "xr-feature-points", "XRFeaturePoints", "undefined", "WebXRFeaturePointSystem"],
  ["HAND_TRACKING", "xr-hand-tracking", "XRHandTracking", "IWebXRHandTrackingOptions", "WebXRHandTracking"],
  ["IMAGE_TRACKING", "xr-image-tracking", "XRImageTracking", "IWebXRImageTrackingOptions", "WebXRImageTracking"],
  ["NEAR_INTERACTION", "xr-near-interaction", "XRNearInteraction", "IWebXRNearInteractionOptions", "WebXRNearInteraction"],
  ["DOM_OVERLAY", "xr-dom-overlay", "XRDomOverlay", "IWebXRDomOverlayOptions", "WebXRDomOverlay"],
  ["MOVEMENT", "xr-controller-movement", "XRMovement", "IWebXRControllerMovementOptions", "WebXRControllerMovement"],
  ["LIGHT_ESTIMATION", "xr-light-estimation", "XRLightEstimation", "IWebXRLightEstimationOptions", "WebXRLightEstimation"],
  ["EYE_TRACKING", "xr-eye-tracking", "XREyeTracking", "undefined", "WebXREyeTracking"],
  ["WALKING_LOCOMOTION", "xr-walking-locomotion", "XRWalkingLocomotion", "IWebXRWalkingLocomotionOptions", "WebXRWalkingLocomotion"],
  ["LAYERS", "xr-layers", "XRLayers", "IWebXRLayersOptions", "WebXRLayers"],
  ["DEPTH_SENSING", "xr-depth-sensing", "XRDepthSensing", "IWebXRDepthSensingOptions", "WebXRDepthSensing"],
  ["SPACE_WARP", "xr-space-warp", "XRSpaceWarp", "undefined", "WebXRSpaceWarp"],
  ["RAW_CAMERA_ACCESS", "xr-raw-camera-access", "XRRawCameraAccess", "IWebXRRawCameraAccessOptions", "WebXRRawCameraAccess"],
  ["BODY_TRACKING", "xr-body-tracking", "XRBodyTracking", "IWebXRBodyTrackingOptions", "WebXRBodyTracking"]
];

const dependent = JSON.parse(await readFile(resolve(root, "analysis/dependent-maps.json"), "utf8"));
const table = id => dependent.tables.find(item => item.id === id)?.mappings.map(item => item.key) ?? [];
const assertExact = (id, actual, expected) => {
  const missing = expected.filter(value => !actual.includes(value));
  const extra = actual.filter(value => !expected.includes(value));
  const duplicate = actual.filter((value, index) => actual.indexOf(value) !== index);
  if (missing.length || extra.length || duplicate.length) throw new Error(`${id} incomplete: missing=${missing} extra=${extra} duplicate=${duplicate}`);
};
assertExact("device-type", table("device-type"), device.map(row => row[0]));
assertExact("flow-graph-asset-type", table("flow-graph-asset-type"), flow.map(row => row[0]));
assertExact("webxr-feature-name", table("webxr-feature-name"), xr.map(row => row[1]));

const xrDeclaration = await readFile(resolve(root, "node_modules/@babylonjs/core/XR/webXRFeaturesManager.d.ts"), "utf8");
for (const [constant, literal, , options, result] of xr) {
  if (!xrDeclaration.includes(`static readonly ${constant}: "${literal}";`)) throw new Error(`missing WebXR literal ${constant}/${literal}`);
  if (!new RegExp(`\\[WebXRFeatureName\\.${constant}\\]:\\s*${result.replace(/[.*+?^${}()|[\]\\]/g, "\\$&")}\\s*;`).test(xrDeclaration)) throw new Error(`missing WebXR result map ${literal}/${result}`);
  if (!new RegExp(`\\[WebXRFeatureName\\.${constant}\\]:\\s*${options.replace(/[.*+?^${}()|[\]\\]/g, "\\$&")}\\s*;`).test(xrDeclaration)) throw new Error(`missing WebXR options map ${literal}/${options}`);
}

const signatures = [
  ...device.map(row => `device|${row.slice(1).join("|")}`),
  ...flow.map(row => `flow|${row.slice(1).join("|")}`),
  ...xr.map(row => `xr|${row.slice(2).join("|")}`)
];
if (new Set(signatures).size !== signatures.length) throw new Error("collapsed maintained finite-map signature");

const maintainedPath = resolve(root, "src/BabylonjsBindings/M2FiniteDependentMaps.fs");
const maintained = await readFile(maintainedPath, "utf8");
if ((maintained.match(/abstract enableFeature:/g) ?? []).length !== 22 || (maintained.match(/abstract getEnabledFeature:/g) ?? []).length !== 22) throw new Error("WebXR manager overload matrix is incomplete");
for (const token of [...device.flatMap(row => row.slice(1)), ...flow.flatMap(row => row.slice(1)), ...xr.flatMap(row => row.slice(2))]) {
  if (token !== "undefined" && !maintained.includes(token)) throw new Error(`maintained projection is missing ${token}`);
}

const report = {
  schemaVersion: 1,
  source: "Babylon.js 9.19.0 locked declarations",
  tables: [
    { id: "device-type", sourceKeyCount: 8, mappingCount: 8, complete: true, rows: device.map(([key, discriminator, input, event]) => ({ key, discriminator, input, event, signature: `DeviceSource<${discriminator},${input},${event}>` })) },
    { id: "flow-graph-asset-type", sourceKeyCount: 6, mappingCount: 6, complete: true, rows: flow.map(([key, discriminator, result]) => ({ key, discriminator, result, signature: `GetFlowGraphAssetWithType(${discriminator})->${result} option` })) },
    { id: "webxr-feature-name", sourceKeyCount: 22, mappingCount: 22, complete: true, rows: xr.map(([constant, key, discriminator, options, result]) => ({ constant, key, discriminator, options, result, signature: `enableFeature(${discriminator},${options})->${result}` })) }
  ],
  totals: { sourceRows: 36, uniqueSignatures: 36, missing: 0, extra: 0, duplicate: 0, collapsed: 0 }
};

const exports = [
  ["@babylonjs/core/DeviceInput/InputDevices/deviceTypes", "DeviceInput", "type"],
  ["@babylonjs/core/DeviceInput/InputDevices/deviceSource", "DeviceSourceEvent", "type"],
  ["@babylonjs/core/DeviceInput/internalDeviceSourceManager.pure", "DeviceSourceType", "type"],
  ["@babylonjs/core/DeviceInput/internalDeviceSourceManager.pure", "IObservableManager", "interface"],
  ["@babylonjs/core/DeviceInput/InputDevices/deviceSource", "DeviceSource", "class"],
  ["@babylonjs/core/DeviceInput/InputDevices/deviceSourceManager", "DeviceSourceManager", "class"],
  ["@babylonjs/core/DeviceInput/internalDeviceSourceManager.pure", "InternalDeviceSourceManager", "class"],
  ["@babylonjs/core/FlowGraph/flowGraphAssetsContext", "AssetType", "type"],
  ["@babylonjs/core/FlowGraph/flowGraphAssetsContext", "GetFlowGraphAssetWithType", "function"],
  ["@babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetAssetBlock.pure", "FlowGraphGetAssetBlock", "class"],
  ["@babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetPropertyBlock.pure", "FlowGraphGetPropertyBlock", "class"],
  ["@babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetPropertyBlock.pure", "IFlowGraphGetPropertyBlockConfiguration", "interface"],
  ["@babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphJsonPointerParserBlock.pure", "FlowGraphJsonPointerParserBlock", "class"],
  ["@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSwitchBlock.pure", "FlowGraphSwitchBlock", "class"],
  ["@babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetPropertyBlock.pure", "FlowGraphSetPropertyBlock", "class"],
  ["@babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetPropertyBlock.pure", "IFlowGraphSetPropertyBlockConfiguration", "interface"],
  ["@babylonjs/core/XR/webXRFeaturesManager", "WebXRFeatureNameType", "type"],
  ["@babylonjs/core/XR/webXRFeaturesManager", "IWebXRFeatureNameTypeMap", "interface"],
  ["@babylonjs/core/XR/webXRFeaturesManager", "IWebXRFeatureNameOptionsMap", "interface"],
  ["@babylonjs/core/XR/webXRFeaturesManager", "ResolveWebXRFeature", "type"],
  ["@babylonjs/core/XR/webXRFeaturesManager", "ResolveWebXRFeatureOptions", "type"],
  ["@babylonjs/core/XR/webXRFeaturesManager", "WebXRFeaturesManager", "class"],
  ["@babylonjs/core/XR/webXRExperienceHelper", "WebXRExperienceHelper", "class"],
  ["@babylonjs/core/XR/webXREnterExitUI", "WebXREnterExitUI", "class"],
  ["@babylonjs/core/XR/webXRDefaultExperience", "WebXRDefaultExperience", "class"],
  ["@babylonjs/core/Cameras/VR/vrExperienceHelper.pure", "VRExperienceHelper", "class"],
  ["@babylonjs/core/Behaviors/Meshes/handConstraintBehavior", "HandConstraintBehavior", "class"]
].map(([module, name, kind]) => ({ package: "@babylonjs/core", module, name, kind, disposition: "typed", fsharpSymbol: `BabylonjsBindings.FiniteDependentMaps.${name}` }));

const proposalHeader = "// REVIEW-ONLY M2 FINITE DEPENDENT MAP PROPOSAL — maintained source requires explicit review";
const proposal = `${proposalHeader}\n${maintained.split("\n").slice(1).join("\n")}`;
const coverageManifest = { schemaVersion: 1, reviewStatus: "maintained", proposalSha256: sha256(proposal), exports };

const outputs = [
  ["analysis/m2-finite-dependent-map-manifest.json", `${JSON.stringify(report, null, 2)}\n`],
  ["generated-candidates/M2FiniteDependentMaps.proposal.fs", proposal],
  ["src/BabylonjsBindings/m2-finite-dependent-map-coverage-manifest.json", `${JSON.stringify(coverageManifest, null, 2)}\n`]
];
for (const [path, rendered] of outputs) {
  const absolute = resolve(root, path);
  if (check) {
    if (await readFile(absolute, "utf8") !== rendered) throw new Error(`${path} is stale`);
  } else await writeFile(absolute, rendered);
}
console.log(`M2 finite maps complete: ${device.length} DeviceType, ${flow.length} FlowGraph, ${xr.length} WebXR; ${exports.length} exports`);
