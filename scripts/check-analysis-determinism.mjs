import { mkdtemp, readFile, rm } from "node:fs/promises";
import { tmpdir } from "node:os";
import { join, resolve } from "node:path";
import { spawnSync } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const temporaryRoot = await mkdtemp(join(tmpdir(), "babylon-analysis-determinism-"));
const first = join(temporaryRoot, "first");
const second = join(temporaryRoot, "second");
try {
  for (const output of [first, second]) {
    const run = spawnSync(process.execPath, ["scripts/generate-analysis-infrastructure.mjs", "--out-dir", output], { cwd: root, encoding: "utf8" });
    if (run.status !== 0) throw new Error(run.stderr || run.stdout || `generation failed with exit ${run.status}`);
  }
  for (const name of ["blocked-families.json", "dependent-map-completeness.json"]) {
    const [left, right] = await Promise.all([readFile(join(first, name)), readFile(join(second, name))]);
    if (!left.equals(right)) throw new Error(`${name} differs across independent generations`);
  }
  console.log("analysis determinism passed: two isolated report generations are byte-identical");
} finally {
  await rm(temporaryRoot, { recursive: true, force: true });
}
