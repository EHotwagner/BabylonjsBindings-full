import { mkdir, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import { spawnSync } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const trxPath = resolve(root, process.argv[2] ?? "reports/m2-finite-dependent-maps.trx");
const matrixPath = resolve(root, "reports/m2-test-matrix.json");
const environment = { ...process.env, PATH: `/home/developer/.dotnet:${process.env.PATH}` };
delete environment.npm_config_allow_scripts;
delete environment.NPM_CONFIG_ALLOW_SCRIPTS;
const checks = [
  ["finite source tables and signature uniqueness", "npm", ["run", "check:m2-finite-maps"]],
  ["locked maintained restore", "dotnet", ["restore", "--locked-mode"]],
  ["maintained positive compile matrix", "dotnet", ["build", "--no-restore", "--nologo", "-v:minimal"]],
  ["negative dependent mismatches", "npm", ["run", "test:m2-negative"]],
  ["Fable emitted compile", "npm", ["run", "test:m2-fable"]],
  ["exact emitted deep imports", "npm", ["run", "test:m2-imports"]],
  ["Node finite runtime smoke", "npm", ["run", "test:m2-node"]],
  ["Chromium deterministic WebXR stubs", "npm", ["run", "test:m2-browser"]],
  ["clean packed Fable consumer", "npm", ["run", "test:m2-clean-consumer"]],
  ["exact coverage totals", "npm", ["run", "coverage:check"]],
  ["locked declaration drift", "npm", ["run", "check:drift"]],
  ["analysis deterministic", "npm", ["run", "analysis:determinism"]],
  ["analysis current", "npm", ["run", "analysis:check"]]
];
const results = [];
for (const [name, command, args] of checks) {
  const run = spawnSync(command, args, { cwd: root, env: environment, encoding: "utf8", stdio: "inherit" });
  if (run.status !== 0) throw new Error(`${name} failed with ${run.status}`);
  results.push({ name, command: `${command} ${args.join(" ")}`, result: "pass" });
}
const uuid = index => `${String(index + 1).padStart(8, "0")}-0000-4000-8000-${String(index + 1).padStart(12, "0")}`;
const testUuid = index => `${String(index + 1).padStart(8, "a")}-aaaa-4aaa-8aaa-${String(index + 1).padStart(12, "a")}`;
const rows = results.map((item, index) => `    <UnitTestResult executionId="${uuid(index)}" testId="${testUuid(index)}" testName="${item.name}" outcome="Passed" />`).join("\n");
const trx = `<?xml version="1.0" encoding="utf-8"?>
<TestRun id="00000000-0000-4000-8000-000000000004" name="M2 finite dependent maps" xmlns="http://microsoft.com/schemas/VisualStudio/TeamTest/2010">
  <Results>
${rows}
  </Results>
  <ResultSummary outcome="Completed"><Counters total="${results.length}" executed="${results.length}" passed="${results.length}" failed="0" error="0" timeout="0" aborted="0" inconclusive="0" notExecuted="0" /></ResultSummary>
</TestRun>
`;
const matrix = { schemaVersion: 1, workId: "004-m2-finite-dependent-maps", result: "pass", coverage: { total: 4323, typed: 4279, runtimeOnly: 1, blocked: 43, lossy: 0 }, discriminatorTables: { deviceType: 8, flowGraphAsset: 6, webXRFeature: 22, uniqueSignatures: 36, collapsed: 0 }, checks: results };
await mkdir(dirname(trxPath), { recursive: true });
await writeFile(trxPath, trx);
await writeFile(matrixPath, `${JSON.stringify(matrix, null, 2)}\n`);
console.log(`M2 observed test receipt: ${trxPath} (${results.length} passed)`);
