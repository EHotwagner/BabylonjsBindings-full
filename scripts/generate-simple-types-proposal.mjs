import { readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const check = process.argv.includes("--check");
const maintained = process.argv.includes("--maintained");
const aliasPath = resolve(root, maintained ? "src/BabylonjsBindings/TypeAliases.fs" : "generated-candidates/SimpleAliases.proposal.fs");
const interfacePath = resolve(root, maintained ? "src/BabylonjsBindings/SimpleInterfaces.fs" : "generated-candidates/SimpleInterfaces.proposal.fs");
const classPath = resolve(root, maintained ? "src/BabylonjsBindings/SimpleClasses.fs" : "generated-candidates/SimpleClasses.proposal.fs");
const outputPath = resolve(root, maintained ? "src/BabylonjsBindings/SimpleTypes.fs" : "generated-candidates/SimpleTypes.proposal.fs");

const moduleBody = (source, moduleName) => {
  const lines = source.split("\n");
  const moduleIndex = lines.findIndex(line => line === `module ${moduleName} =`);
  if (moduleIndex < 1) throw new Error(`proposal does not contain ${moduleName}`);
  const documentationIndex = lines[moduleIndex - 1].startsWith("/// ") ? moduleIndex - 1 : moduleIndex;
  return lines.slice(documentationIndex).join("\n").trimEnd();
};

const aliases = moduleBody(await readFile(aliasPath, "utf8"), "TypeAliases");
const interfaces = moduleBody(await readFile(interfacePath, "utf8"), "SimpleInterfaces");
const classes = moduleBody(await readFile(classPath, "utf8"), "SimpleClasses");
const proposal = [
  maintained
    ? "// DERIVED BUILD PROJECTION — authoritative reviewed fragments are TypeAliases.fs, SimpleInterfaces.fs, and SimpleClasses.fs"
    : "// REVIEWED-PROMOTION PROPOSAL — recursive alias/interface/class closure compiled as one F# namespace",
  "namespace rec BabylonjsBindings",
  "",
  "open Fable.Core",
  "",
  aliases,
  "",
  interfaces,
  "",
  classes,
  ""
].join("\n");

if (check) {
  if (await readFile(outputPath, "utf8") !== proposal) throw new Error("combined simple type proposal is stale");
} else {
  await writeFile(outputPath, proposal);
}

console.log(`generated combined recursive alias/interface/class ${maintained ? "maintained build projection" : "proposal"}`);
