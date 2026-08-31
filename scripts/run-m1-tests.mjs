import { mkdir, writeFile } from "node:fs/promises";
import { dirname, resolve } from "node:path";
import { spawnSync } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const output = resolve(root, process.argv[2] ?? "reports/m1-exact-projections.trx");
const fableOutput = resolve(root, "artifacts/m1-fable-dist");
const dotnet = "dotnet";
const environment = { ...process.env };
delete environment.npm_config_allow_scripts;
delete environment.NPM_CONFIG_ALLOW_SCRIPTS;

const checks = [
  { name: "exact locked projections and correlations", command: process.execPath, args: ["scripts/check-m1-exact-projections.mjs"] },
  { name: "maintained binding locked restore", command: dotnet, args: ["restore", "BabylonjsBindings.slnx", "--locked-mode"] },
  { name: "maintained binding compile", command: dotnet, args: ["build", "BabylonjsBindings.slnx", "--no-restore", "--nologo", "-v:minimal"] },
  { name: "Fable compile exact consumer surface", command: dotnet, args: ["fable", "tests/BabylonjsBindings.CompileTests/BabylonjsBindings.CompileTests.fsproj", "--outDir", fableOutput, "--noCache"] },
  { name: "emitted deep-import and type-only boundary", command: process.execPath, args: ["-e", `const fs=require('fs');const p=${JSON.stringify(resolve(fableOutput, "Program.js"))};const s=fs.readFileSync(p,'utf8');for(const m of ['@babylonjs/core/Buffers/bufferUtils.js','@babylonjs/core/Misc/deepMerger.js','@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping.js','@babylonjs/core/Physics/v1/physicsEngine.js','@babylonjs/core/Physics/v2/physicsEngine.js'])if(!s.includes(m))throw new Error('missing '+m);if(s.includes('GLTFLoaderOptions'))throw new Error('type-only import emitted');`] },
  { name: "Node runtime smoke", command: process.execPath, args: ["runtime/node/smoke.mjs"] },
  { name: "clean packed Fable consumer", command: process.execPath, args: ["scripts/test-m1-clean-consumer.mjs"] },
  { name: "exact coverage totals", command: process.execPath, args: ["--max-old-space-size=8192", "scripts/generate-coverage.mjs", "--check"] },
  { name: "locked declaration drift", command: process.execPath, args: ["scripts/lock-declarations.mjs", "--check"] },
  { name: "maintained recursive projection", command: process.execPath, args: ["scripts/generate-simple-types-proposal.mjs", "--maintained", "--check"] },
  { name: "analysis report determinism", command: process.execPath, args: ["scripts/check-analysis-determinism.mjs"] },
  { name: "analysis report currency", command: process.execPath, args: ["scripts/generate-analysis-infrastructure.mjs", "--check"] }
];

for (const check of checks) {
  const run = spawnSync(check.command, check.args, { cwd: root, encoding: "utf8", stdio: "inherit", env: environment });
  if (run.status !== 0) throw new Error(`${check.name} failed with exit code ${run.status}`);
}

const idFor = index => `${String(index + 1).padStart(8, "0")}-0000-4000-8000-${String(index + 1).padStart(12, "0")}`;
const testIdFor = index => `${String(index + 1).padStart(8, "a")}-aaaa-4aaa-8aaa-${String(index + 1).padStart(12, "a")}`;
const results = checks.map((check, index) => `    <UnitTestResult executionId="${idFor(index)}" testId="${testIdFor(index)}" testName="${check.name}" outcome="Passed" />`).join("\n");
const trx = `<?xml version="1.0" encoding="utf-8"?>
<TestRun id="00000000-0000-4000-8000-000000000003" name="M1 exact projections and collisions" xmlns="http://microsoft.com/schemas/VisualStudio/TeamTest/2010">
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
console.log(`M1 observed test receipt: ${output}`);
