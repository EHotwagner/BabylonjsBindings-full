import { execFileSync } from "node:child_process";
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
run("generate-simple-alias-proposal.mjs");
run("generate-simple-interface-proposal.mjs");
run("generate-simple-class-proposal.mjs");

run("generate-simple-function-proposal.mjs");
run("generate-simple-variable-proposal.mjs");
run("generate-simple-types-proposal.mjs");
