import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { resolve, relative, sep } from "node:path";
import ts from "typescript";
import Ajv2020 from "ajv/dist/2020.js";

const root = resolve(import.meta.dirname, "..");
const nodeModules = resolve(root, "node_modules");
const reportPath = resolve(root, "coverage-and-drift.json");
const lockPath = resolve(root, "declaration-lock.json");
const maintainedPath = resolve(root, "src/BabylonjsBindings/Bindings.fs");
const promotionFamilies = [
  {
    maintainedPath: "src/BabylonjsBindings/Enums.fs",
    manifestPath: "src/BabylonjsBindings/coverage-manifest.json",
    proposalPath: "generated-candidates/CoreEnums.proposal.fs",
    description: "numeric enum or integer-literal union"
  },
  {
    maintainedPath: "src/BabylonjsBindings/StringEnums.fs",
    manifestPath: "src/BabylonjsBindings/string-coverage-manifest.json",
    proposalPath: "generated-candidates/StringEnums.proposal.fs",
    description: "string enum or literal union"
  },
  {
    maintainedPath: "src/BabylonjsBindings/ObjectTypes.fs",
    manifestPath: "src/BabylonjsBindings/object-type-coverage-manifest.json",
    proposalPath: "generated-candidates/SimpleObjectTypes.proposal.fs",
    description: "primitive-property object alias"
  }
];
const schemaPath = resolve(root, "work/001-full-babylonjs-bindings/contracts/coverage-and-drift.schema.json");
const check = process.argv.includes("--check");
const requireComplete = process.argv.includes("--require-complete");
const sha256 = value => createHash("sha256").update(value).digest("hex");

const lockText = await readFile(lockPath, "utf8");
const maintainedText = await readFile(maintainedPath, "utf8");
const promotions = await Promise.all(promotionFamilies.map(async family => {
  const maintainedSource = await readFile(resolve(root, family.maintainedPath), "utf8");
  const proposalSource = await readFile(resolve(root, family.proposalPath), "utf8");
  const manifest = JSON.parse(await readFile(resolve(root, family.manifestPath), "utf8"));
  if (manifest.schemaVersion !== 1 || manifest.reviewStatus !== "maintained") {
    throw new Error(`${family.description} coverage manifest has an unsupported schema or is not reviewed`);
  }
  if (maintainedSource.split("\n").slice(1).join("\n") !== proposalSource.split("\n").slice(1).join("\n")) {
    throw new Error(`maintained ${family.description} bindings drifted from the reviewed exact-declaration proposal`);
  }
  return { ...family, maintainedSource, manifest };
}));
const lock = JSON.parse(lockText);
const lockedPaths = new Set(lock.files.map(file => file.path));
const absolutePaths = [...lockedPaths].map(file => resolve(nodeModules, file));
const program = ts.createProgram(absolutePaths, {
  target: ts.ScriptTarget.ESNext,
  module: ts.ModuleKind.NodeNext,
  moduleResolution: ts.ModuleResolutionKind.NodeNext,
  noLib: true,
  skipLibCheck: true
});
const checker = program.getTypeChecker();

const normalizePath = file => relative(nodeModules, file).split(sep).join("/");
const modulePath = file => normalizePath(file).replace(/\.d\.ts$/, "");
const packageFor = module => module.startsWith("@babylonjs/core/")
  ? "@babylonjs/core"
  : module.startsWith("@babylonjs/loaders/")
    ? "@babylonjs/loaders"
    : undefined;
const kindFor = declaration => {
  if (!declaration) return "type";
  if (ts.isClassDeclaration(declaration)) return "class";
  if (ts.isInterfaceDeclaration(declaration)) return "interface";
  if (ts.isTypeAliasDeclaration(declaration)) return "type";
  if (ts.isEnumDeclaration(declaration)) return "enum";
  if (ts.isFunctionDeclaration(declaration)) return "function";
  if (ts.isVariableDeclaration(declaration) || ts.isVariableStatement(declaration)) return "variable";
  if (ts.isModuleDeclaration(declaration) || ts.isSourceFile(declaration)) return "namespace";
  return "type";
};

const partialWrappers = new Map([
  ["@babylonjs/core/Engines/nullEngine.pure|NullEngine", "Qualification.Babylon.Engine"],
  ["@babylonjs/core/scene.pure|Scene", "Qualification.Babylon.Scene"],
  ["@babylonjs/core/Maths/math.vector.pure|Vector3", "Qualification.Babylon.Vector3"],
  ["@babylonjs/core/Cameras/freeCamera.pure|FreeCamera", "Qualification.Babylon.Camera"],
  ["@babylonjs/core/Lights/hemisphericLight.pure|HemisphericLight", "Qualification.Babylon.Light"],
  ["@babylonjs/core/Meshes/meshBuilder.pure|MeshBuilder", "Qualification.Babylon.Box"]
]);

const exportsByIdentity = new Map();
for (const sourceFile of program.getSourceFiles()) {
  const lockedPath = normalizePath(sourceFile.fileName);
  if (!lockedPaths.has(lockedPath) || !sourceFile.symbol) continue;
  for (const exported of checker.getExportsOfModule(sourceFile.symbol)) {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) {
      try { target = checker.getAliasedSymbol(exported); } catch { /* unresolved aliases remain blocked below */ }
    }
    const declaration = target.declarations?.[0] ?? exported.declarations?.[0];
    const declarationModule = declaration ? modulePath(declaration.getSourceFile().fileName) : modulePath(sourceFile.fileName);
    const packageName = packageFor(declarationModule) ?? packageFor(modulePath(sourceFile.fileName));
    if (!packageName) continue;
    const name = exported.getName();
    const identity = `${packageName}|${declarationModule}|${name}`;
    if (exportsByIdentity.has(identity)) continue;
    const wrapper = partialWrappers.get(`${declarationModule}|${name}`);
    exportsByIdentity.set(identity, {
      package: packageName,
      module: declarationModule,
      name,
      kind: kindFor(declaration),
      disposition: wrapper ? "lossy" : "blocked",
      ...(wrapper ? { fsharpSymbol: wrapper } : {}),
      reason: wrapper
        ? "The maintained qualification wrapper exposes only a small behavior slice, not the complete upstream declaration."
        : "Present only in a review-only generated candidate; promotion to maintained F# source is pending."
    });
  }
}

const exports = [...exportsByIdentity.values()];
const exportIndex = new Map(exports.map(item => [`${item.package}|${item.module}|${item.name}`, item]));
for (const promotion of promotions) {
  for (const reviewed of promotion.manifest.exports) {
    const identity = `${reviewed.package}|${reviewed.module}|${reviewed.name}`;
    const item = exportIndex.get(identity);
    if (!item) throw new Error(`reviewed maintained export is absent from the locked inventory: ${identity}`);
    if (item.kind !== reviewed.kind || reviewed.disposition !== "typed") {
      throw new Error(`reviewed maintained export no longer has its expected kind/disposition: ${identity}`);
    }
    item.disposition = "typed";
    item.fsharpSymbol = reviewed.fsharpSymbol;
    item.reason = `Reviewed maintained ${promotion.description} with every upstream member and value preserved exactly.`;
  }
}
exports.push({
  package: "@babylonjs/loaders",
  module: "@babylonjs/loaders/glTF/index",
  name: "*",
  kind: "side-effect",
  disposition: "runtime-only",
  reason: "Explicit loader registration import; it has runtime behavior but no typed declaration surface."
});
exports.sort((left, right) => left.package.localeCompare(right.package)
  || left.module.localeCompare(right.module)
  || left.name.localeCompare(right.name));

const diagnosticFiles = [
  "generated-candidates/candidate-diagnostics.json",
  "generated-candidates/gltf2interface-candidate-diagnostics.json",
  "generated-candidates/loaders-candidate-diagnostics.json"
];
const unsupportedConstructs = [];
for (const file of diagnosticFiles) {
  const document = JSON.parse(await readFile(resolve(root, file), "utf8"));
  for (const diagnostic of document.diagnostics) {
    const syntaxKind = diagnostic.message.replace(/^unsupported\s+/, "") || "unknown";
    unsupportedConstructs.push({
      path: `${document.source.package}@${document.source.version}/${document.source.path}`,
      syntaxKind,
      reason: `ts2fable reported ${diagnostic.count} occurrence(s); repaired output remains review-only until each occurrence is dispositioned.`,
      disposition: "lossy",
      occurrences: diagnostic.count,
      coverageImpact: "excluded-from-typed"
    });
  }
}
unsupportedConstructs.sort((left, right) => left.path.localeCompare(right.path) || left.syntaxKind.localeCompare(right.syntaxKind));

const summary = { total: exports.length, typed: 0, runtimeOnly: 0, blocked: 0, lossy: 0 };
for (const item of exports) {
  if (item.disposition === "typed") summary.typed += 1;
  else if (item.disposition === "runtime-only") summary.runtimeOnly += 1;
  else if (item.disposition === "blocked") summary.blocked += 1;
  else if (item.disposition === "lossy") summary.lossy += 1;
}
const report = {
  schemaVersion: 1,
  packages: [
    { name: "@babylonjs/core", version: "9.19.0" },
    { name: "@babylonjs/loaders", version: "9.19.0" }
  ],
  sourceDigest: sha256(lockText),
  maintainedSurfaceDigest: sha256([
    maintainedText,
    ...promotions.flatMap(promotion => [promotion.maintainedSource, JSON.stringify(promotion.manifest)])
  ].join("\n")),
  summary,
  exports,
  unsupportedConstructs,
  status: summary.blocked === 0 && summary.lossy === 0 && unsupportedConstructs.length === 0 ? "complete" : "incomplete"
};
const schema = JSON.parse(await readFile(schemaPath, "utf8"));
const validate = new Ajv2020({ allErrors: true }).compile(schema);
if (!validate(report)) throw new Error(`generated coverage report violates its schema: ${JSON.stringify(validate.errors)}`);
const rendered = `${JSON.stringify(report, null, 2)}\n`;

if (check) {
  const existing = await readFile(reportPath, "utf8");
  const existingDocument = JSON.parse(existing);
  if (!validate(existingDocument)) throw new Error(`coverage-and-drift.json violates its schema: ${JSON.stringify(validate.errors)}`);
  if (existing !== rendered) throw new Error("coverage-and-drift.json is stale; run npm run coverage:generate and review every changed disposition");
} else {
  await writeFile(reportPath, rendered);
}
if (requireComplete && report.status !== "complete") {
  throw new Error(`typed coverage is incomplete: ${summary.typed}/${summary.total} typed, ${summary.blocked} blocked, ${summary.lossy} lossy`);
}
console.log(`coverage ${report.status}: ${summary.typed}/${summary.total} typed, ${summary.runtimeOnly} runtime-only, ${summary.blocked} blocked, ${summary.lossy} lossy; ${unsupportedConstructs.length} unsupported categories`);
