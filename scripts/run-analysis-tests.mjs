import { mkdir, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import { spawnSync } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const output = resolve(root, process.argv[2] ?? "reports/m0-analysis.trx");
const checks = [
  { name: "analysis fixtures", command: process.execPath, args: ["--test", "scripts/test-analysis-infrastructure.mjs"] },
  { name: "two-generation byte identity", command: process.execPath, args: ["scripts/check-analysis-determinism.mjs"] },
  { name: "deterministic analysis reports", command: process.execPath, args: ["scripts/generate-analysis-infrastructure.mjs", "--check"] },
  { name: "unchanged coverage baseline", command: process.execPath, args: ["--max-old-space-size=8192", "scripts/generate-coverage.mjs", "--check"] },
  { name: "maintained binding locked restore", command: "dotnet", args: ["restore", "BabylonjsBindings.slnx", "--locked-mode"] },
  { name: "maintained binding build", command: "dotnet", args: ["build", "BabylonjsBindings.slnx", "--no-restore", "--nologo", "-v:minimal"] },
  { name: "maintained binding runtime smoke", command: process.execPath, args: ["runtime/node/smoke.mjs"] },
  { name: "no maintained API changes", command: "git", args: ["diff", "--quiet", "origin/main", "--", "src/BabylonjsBindings", "coverage-and-drift.json", "declaration-lock.json", "package-lock.json"] }
];

for (const check of checks) {
  const run = spawnSync(check.command, check.args, { cwd: root, encoding: "utf8", stdio: "inherit" });
  if (run.status !== 0) throw new Error(`${check.name} failed with exit code ${run.status}`);
}

const idFor = index => `${String(index + 1).padStart(8, "0")}-0000-4000-8000-${String(index + 1).padStart(12, "0")}`;
const testIdFor = index => `${String(index + 1).padStart(8, "a")}-aaaa-4aaa-8aaa-${String(index + 1).padStart(12, "a")}`;
const results = checks.map((check, index) => `    <UnitTestResult executionId="${idFor(index)}" testId="${testIdFor(index)}" testName="${check.name}" outcome="Passed" />`).join("\n");
const trx = `<?xml version="1.0" encoding="utf-8"?>
<TestRun id="00000000-0000-4000-8000-000000000002" name="M0 analysis infrastructure" xmlns="http://microsoft.com/schemas/VisualStudio/TeamTest/2010">
  <Results>
${results}
  </Results>
  <ResultSummary outcome="Completed">
    <Counters total="${checks.length}" executed="${checks.length}" passed="${checks.length}" failed="0" error="0" timeout="0" aborted="0" inconclusive="0" notExecuted="0" />
  </ResultSummary>
</TestRun>
`;
await mkdir(dirname(output), { recursive: true });
await writeFile(output, trx);
console.log(`analysis test receipt: ${output}`);
