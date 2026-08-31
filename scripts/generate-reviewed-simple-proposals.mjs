import { execFileSync } from "node:child_process";
import { readFileSync } from "node:fs";
import { fileURLToPath } from "node:url";
import { dirname, resolve } from "node:path";

const root = resolve(dirname(fileURLToPath(import.meta.url)), "..");
const run = (script, ...arguments_) => execFileSync(
  process.execPath,
  [resolve(root, "scripts", script), ...arguments_],
  { cwd: root, stdio: "inherit", env: { ...process.env, NODE_OPTIONS: "--max-old-space-size=8192" } }
);

// Admit reciprocal alias/interface/class dependencies against the declaration
// closure, then prune the bootstrap view against the classes actually selected.
run("generate-simple-alias-proposal.mjs", "--bootstrap-classes");
run("generate-simple-interface-proposal.mjs", "--bootstrap-classes");
run("generate-simple-class-proposal.mjs");

const recursiveOutputs = [
  "generated-candidates/SimpleAliases.proposal.fs",
  "generated-candidates/SimpleAliases.promotion.json",
  "generated-candidates/SimpleInterfaces.proposal.fs",
  "generated-candidates/SimpleInterfaces.promotion.json",
  "generated-candidates/SimpleClasses.proposal.fs",
  "generated-candidates/SimpleClasses.promotion.json"
].map(path => resolve(root, path));
let converged = false;
for (let iteration = 0; iteration < 8; iteration += 1) {
  const before = recursiveOutputs.map(path => readFileSync(path, "utf8"));
  run("generate-simple-alias-proposal.mjs");
  run("generate-simple-interface-proposal.mjs");
  run("generate-simple-class-proposal.mjs");
  const after = recursiveOutputs.map(path => readFileSync(path, "utf8"));
  if (after.every((value, index) => value === before[index])) {
    converged = true;
    break;
  }
}
if (!converged) throw new Error("recursive alias/interface/class proposal generation did not converge within 8 iterations");

run("generate-simple-function-proposal.mjs");
run("generate-simple-variable-proposal.mjs");
run("generate-simple-types-proposal.mjs");
