import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { resolve, relative, sep } from "node:path";
import ts from "typescript";

const root = resolve(import.meta.dirname, "..");
const check = process.argv.includes("--check");
const sha256 = value => createHash("sha256").update(value).digest("hex");
const lock = JSON.parse(await readFile(resolve(root, "declaration-lock.json"), "utf8"));
const sourcePath = resolve(root, "src/BabylonjsBindings/M4TypeFunctionCore.fs");
const proposalPath = resolve(root, "generated-candidates/M4TypeFunctionCore.proposal.fs");
const analysisPath = resolve(root, "analysis/m4-type-function-core-manifest.json");
const coveragePath = resolve(root, "src/BabylonjsBindings/m4-type-function-core-coverage-manifest.json");
const source = await readFile(sourcePath, "utf8");
const proposal = source.replace("namespace BabylonjsBindings", "// REVIEW-ONLY M4 TYPE-FUNCTION CORE PROPOSAL — maintained source requires explicit review");
const utilityNames = [
  "Add", "Concat", "Constructor", "Decrement", "DeepImmutable", "DeepImmutableObject", "First",
  "Flatten", "FlattenArray", "FlattenTuple", "FromLength", "Immutable", "Increment", "IsTuple",
  "Last", "Length", "Member", "NonNullableFields", "Pop", "Push", "Remove", "Shift", "Subtract",
  "Tuple", "Unshift", "WritableObject"
];
const tensorNames = ["Dimension", "Tensor", "TensorLike", "TensorStatic", "ValueOfTensor"];
const vectorNames = ["Vector", "VectorStatic"];
const tracked = new Set([...utilityNames, ...tensorNames, ...vectorNames]);
const lockedRelative = new Set(lock.files.map(item => item.path));
const nodeModules = resolve(root, "node_modules");
const files = lock.files.map(item => resolve(nodeModules, item.path));
const program = ts.createProgram(files, {
  target: ts.ScriptTarget.ESNext,
  module: ts.ModuleKind.NodeNext,
  moduleResolution: ts.ModuleResolutionKind.NodeNext,
  skipLibCheck: true,
  noLib: true
});
const normalize = value => value.replace(/\s+/g, " ").replace(/\s*([<>,\[\]|&])\s*/g, "$1").trim();
const uses = [];
for (const file of program.getSourceFiles()) {
  const lockedPath = relative(nodeModules, file.fileName).split(sep).join("/");
  if (!lockedRelative.has(lockedPath)) continue;
  const module = lockedPath.replace(/\.d\.ts$/, "");
  const visit = node => {
    if (ts.isTypeReferenceNode(node)) {
      const name = node.typeName.getText(file).split(".").at(-1);
      if (tracked.has(name)) uses.push({ name, expression: normalize(node.getText(file)), module });
    }
    ts.forEachChild(node, visit);
  };
  visit(file);
}
const uniqueUses = [...new Map(uses.map(item => [`${item.name}|${item.expression}|${item.module}`, item])).values()]
  .sort((a, b) => a.name.localeCompare(b.name) || a.expression.localeCompare(b.expression) || a.module.localeCompare(b.module));
const sourceFor = name => utilityNames.includes(name)
  ? { package: "@babylonjs/core", module: "@babylonjs/core/types" }
  : vectorNames.includes(name)
    ? { package: "@babylonjs/core", module: "@babylonjs/core/Maths/math.vector.pure" }
    : { package: "@babylonjs/core", module: "@babylonjs/core/Maths/tensor" };
const exports = [...utilityNames, ...tensorNames, ...vectorNames].map(name => ({
  ...sourceFor(name),
  name,
  kind: vectorNames.includes(name) || ["Tensor", "TensorStatic"].includes(name) ? "interface" : "type",
  disposition: "typed",
  fsharpSymbol: `BabylonjsBindings.TypeFunctionCore.${name}`
})).sort((a, b) => a.module.localeCompare(b.module) || a.name.localeCompare(b.name));
const analysis = {
  schemaVersion: 1,
  source: "declaration-lock.json",
  lockedFileCount: lock.files.length,
  policy: "closed-world-exact-specializations",
  utilityExportCount: utilityNames.length,
  tensorVectorExportCount: tensorNames.length + vectorNames.length,
  instantiationCount: uniqueUses.length,
  instantiations: uniqueUses,
  fixedShapes: [
    { name: "Vector2", shape: [2], coordinates: 2 },
    { name: "Vector3", shape: [3], coordinates: 3 },
    { name: "Vector4", shape: [4], coordinates: 4 },
    { name: "Quaternion", shape: [4], coordinates: 4 },
    { name: "Color3", shape: [3], coordinates: 3 },
    { name: "Color4", shape: [4], coordinates: 4 },
    { name: "Matrix", shape: [4, 4], coordinates: 16 }
  ],
  rejected: ["array-for-fixed-tuple", "unconstrained-obj", "unregistered-instantiation"]
};
const analysisText = `${JSON.stringify(analysis, null, 2)}\n`;
const coverage = {
  schemaVersion: 1,
  reviewStatus: "maintained",
  proposalSha256: sha256(proposal),
  policy: analysis.policy,
  instantiationManifestSha256: sha256(analysisText),
  exports
};
const outputs = [
  [proposalPath, proposal],
  [analysisPath, analysisText],
  [coveragePath, `${JSON.stringify(coverage, null, 2)}\n`]
];
for (const [path, content] of outputs) {
  if (check) {
    if (await readFile(path, "utf8") !== content) throw new Error(`${relative(root, path)} is stale`);
  } else await writeFile(path, content);
}
console.log(`M4 registry current: ${exports.length} exports, ${uniqueUses.length} locked instantiations, 7 fixed shapes`);
