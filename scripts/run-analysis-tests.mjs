import { mkdir, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import { spawnSync } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const output = resolve(root, process.argv[2] ?? "reports/m0-analysis.trx");
const checks = [
  { name: "analysis fixtures", command: process.execPath, args: ["--test", "scripts/test-analysis-infrastructure.mjs"] },
  { name: "deterministic analysis reports", command: process.execPath, args: ["scripts/generate-analysis-infrastructure.mjs", "--check"] },
  { name: "unchanged coverage baseline", command: process.execPath, args: ["--max-old-space-size=8192", "scripts/generate-coverage.mjs", "--check"] }
];

for (const check of checks) {
  const run = spawnSync(check.command, check.args, { cwd: root, encoding: "utf8", stdio: "inherit" });
  if (run.status !== 0) throw new Error(`${check.name} failed with exit code ${run.status}`);
}

const ids = [
  ["11111111-1111-4111-8111-111111111111", "aaaaaaaa-aaaa-4aaa-8aaa-aaaaaaaaaaaa"],
  ["22222222-2222-4222-8222-222222222222", "bbbbbbbb-bbbb-4bbb-8bbb-bbbbbbbbbbbb"],
  ["33333333-3333-4333-8333-333333333333", "cccccccc-cccc-4ccc-8ccc-cccccccccccc"]
];
const results = checks.map((check, index) => `    <UnitTestResult executionId="${ids[index][0]}" testId="${ids[index][1]}" testName="${check.name}" outcome="Passed" />`).join("\n");
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
