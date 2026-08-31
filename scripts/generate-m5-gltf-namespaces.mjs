import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { resolve, relative, sep } from "node:path";
import ts from "typescript";

const root = resolve(import.meta.dirname, "..");
const check = process.argv.includes("--check");
const bootstrap = process.argv.includes("--bootstrap");
const sha256 = value => createHash("sha256").update(value).digest("hex");
const coverage = JSON.parse(await readFile(resolve(root, "coverage-and-drift.json"), "utf8"));
const functions = JSON.parse(await readFile(resolve(root, "src/BabylonjsBindings/simple-function-coverage-manifest.json"), "utf8"));
const variables = JSON.parse(await readFile(resolve(root, "src/BabylonjsBindings/simple-variable-coverage-manifest.json"), "utf8"));
const lock = JSON.parse(await readFile(resolve(root, "declaration-lock.json"), "utf8"));
const nodeModules = resolve(root, "node_modules");
const program = ts.createProgram(lock.files.map(item => resolve(nodeModules, item.path)), {
  target: ts.ScriptTarget.ESNext, module: ts.ModuleKind.NodeNext,
  moduleResolution: ts.ModuleResolutionKind.NodeNext, skipLibCheck: true, noLib: true
});
const checker = program.getTypeChecker();
const normalizePath = file => relative(nodeModules, file).split(sep).join("/").replace(/\.d\.ts$/, "");
const coverageIndex = new Map(coverage.exports.map(item => [`${item.module}|${item.name}`, item]));
const functionIndex = new Map(functions.exports.map(item => [`${item.module}|${item.name}`, item]));
const variableIndex = new Map(variables.exports.map(item => [`${item.module}|${item.name}`, item]));
const facade = [];
for (const [version, fileName] of [["GLTF1", "@babylonjs/loaders/glTF/1.0/index.d.ts"], ["GLTF2", "@babylonjs/loaders/glTF/2.0/index.d.ts"]]) {
  const source = program.getSourceFile(resolve(nodeModules, fileName));
  const exports = checker.getExportsOfModule(source.symbol).map(exported => {
    let target = exported;
    if (exported.flags & ts.SymbolFlags.Alias) target = checker.getAliasedSymbol(exported);
    const declaration = target.declarations?.[0] ?? exported.declarations?.[0];
    const module = normalizePath(declaration.getSourceFile().fileName);
    const maintained = coverageIndex.get(`${module}|${exported.name}`);
    if (!maintained?.fsharpSymbol) throw new Error(`${version}.${exported.name} has no maintained target for ${module}`);
    return { name: exported.name, kind: maintained.kind, module, fsharpSymbol: maintained.fsharpSymbol };
  }).sort((a, b) => a.name.localeCompare(b.name));
  const runtimeModule = await import(resolve(nodeModules, "@babylonjs/loaders/glTF/index.js"));
  const runtimeKeys = Object.keys(runtimeModule[version]).sort();
  const runtime = runtimeKeys.map(name => {
    const item = exports.find(entry => entry.name === name);
    if (!item) throw new Error(`${version} runtime key ${name} is absent from declarations`);
    let fsharpType;
    if (item.kind === "class") fsharpType = `JavaScriptConstructor<${item.fsharpSymbol}>`;
    else if (item.kind === "enum") fsharpType = `JavaScriptEnumObject<${item.fsharpSymbol}>`;
    else if (item.kind === "function") {
      const entry = functionIndex.get(`${item.module}|${item.name}`);
      if (!entry?.fsharpType) throw new Error(`${version}.${name} lacks a function binding type`);
      fsharpType = entry.fsharpType;
    } else if (item.kind === "variable") {
      const entry = variableIndex.get(`${item.module}|${item.name}`);
      if (!entry?.fsharpType) throw new Error(`${version}.${name} lacks a variable binding type`);
      fsharpType = entry.fsharpType.includes(".") ? entry.fsharpType : `BabylonjsBindings.SimpleVariables.${entry.fsharpType}`;
    } else throw new Error(`${version}.${name} runtime kind ${item.kind} is unsupported`);
    return { ...item, fsharpType };
  });
  facade.push({ version, exports, runtimeKeys, runtime });
}
const lines = [
  "namespace BabylonjsBindings", "", "open Fable.Core", "", "/// Exact glTF 1.0 and 2.0 declaration facades and runtime namespace objects.", "module GltfNamespaces =", "",
  "    [<AllowNullLiteral>]", "    type JavaScriptConstructor<'Instance> =", "        interface end", "",
  "    [<AllowNullLiteral>]", "    type JavaScriptEnumObject<'Value> =", "        interface end", ""
];
for (const group of facade) {
  lines.push(`    module ${group.version} =`, "");
  for (const item of group.exports) {
    if (["type", "interface", "class", "enum"].includes(item.kind)) lines.push(`        type \`\`${item.name}\`\` = ${item.fsharpSymbol}`);
    else if (item.kind === "function") lines.push(`        let \`\`${item.name}\`\` = ${item.fsharpSymbol}`);
    else if (item.kind === "variable") lines.push(`        let \`\`${item.name}\`\` = ${item.fsharpSymbol}`);
  }
  lines.push("", "        [<AllowNullLiteral>]", "        type RuntimeNamespace =");
  for (const item of group.runtime) lines.push(`            abstract \`\`${item.name}\`\`: ${item.fsharpType} with get`);
  lines.push("", `        [<Import(\"${group.version}\", \"@babylonjs/loaders/glTF/index.js\")>]`, "        let runtime: RuntimeNamespace = jsNative", "");
}
const generatedSource = `${lines.join("\n")}\n`;
const sourcePath = resolve(root, "src/BabylonjsBindings/M5GltfNamespaces.fs");
const proposalPath = resolve(root, "generated-candidates/M5GltfNamespaces.proposal.fs");
if (bootstrap) {
  await writeFile(proposalPath, generatedSource.replace("namespace BabylonjsBindings", "// REVIEW-ONLY M5 GLTF NAMESPACE PROPOSAL — maintained source requires explicit review"));
  console.log(`M5 bootstrap proposal: ${facade[0].exports.length}/${facade[1].exports.length} declarations, ${facade[0].runtime.length}/${facade[1].runtime.length} runtime keys`);
  process.exit(0);
}
const source = await readFile(sourcePath, "utf8");
if (source !== generatedSource) throw new Error("maintained M5 facade differs from the checker-derived source; review and update it explicitly");
const proposal = generatedSource.replace("namespace BabylonjsBindings", "// REVIEW-ONLY M5 GLTF NAMESPACE PROPOSAL — maintained source requires explicit review");
const analysis = {
  schemaVersion: 1, source: "declaration-lock.json", runtimeSource: "@babylonjs/loaders/glTF/index.js",
  namespaces: facade.map(item => ({ name: item.version, declarationCount: item.exports.length, declarationNames: item.exports.map(x => x.name), runtimeKeyCount: item.runtimeKeys.length, runtimeKeys: item.runtimeKeys }))
};
const exports = [
  { package: "@babylonjs/loaders", module: "@babylonjs/loaders/glTF/1.0/index", name: "GLTF1", kind: "namespace", disposition: "typed", fsharpSymbol: "BabylonjsBindings.GltfNamespaces.GLTF1" },
  { package: "@babylonjs/loaders", module: "@babylonjs/loaders/glTF/2.0/index", name: "GLTF2", kind: "namespace", disposition: "typed", fsharpSymbol: "BabylonjsBindings.GltfNamespaces.GLTF2" }
];
const coverageManifest = { schemaVersion: 1, reviewStatus: "maintained", proposalSha256: sha256(proposal), analysisSha256: sha256(`${JSON.stringify(analysis, null, 2)}\n`), exports };
const outputs = [
  [proposalPath, proposal],
  [resolve(root, "analysis/m5-gltf-namespace-manifest.json"), `${JSON.stringify(analysis, null, 2)}\n`],
  [resolve(root, "src/BabylonjsBindings/m5-gltf-namespace-coverage-manifest.json"), `${JSON.stringify(coverageManifest, null, 2)}\n`]
];
for (const [path, content] of outputs) {
  if (check) {
    if (await readFile(path, "utf8") !== content) throw new Error(`${relative(root, path)} is stale`);
  } else await writeFile(path, content);
}
console.log(`M5 namespace closure current: 51/158 declarations, 14/114 runtime keys`);
