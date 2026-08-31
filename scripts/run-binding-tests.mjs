import { createHash } from "node:crypto";
import { spawnSync } from "node:child_process";
import { mkdir, readFile, writeFile } from "node:fs/promises";
import { homedir } from "node:os";
import { resolve } from "node:path";
import { delimiter } from "node:path";

const root = resolve(import.meta.dirname, "..");
const dotnetRoot = resolve(homedir(), ".dotnet");
const env = { ...process.env, DOTNET_ROOT: dotnetRoot, PATH: `${dotnetRoot}${delimiter}${process.env.PATH}` };
delete env.npm_config_allow_scripts; delete env.NPM_CONFIG_ALLOW_SCRIPTS;
const checks = [
  ["toolchain and lock doctor", "npm", ["run", "doctor"]],
  ["declaration closure drift", "npm", ["run", "check:drift"]],
  ["typed export and runtime import inventory", "node", ["--test", "tests/bindings/inventory.test.mjs", "tests/bindings/runtime-imports.test.mjs"]],
  ["locked .NET restore", "dotnet", ["restore", "BabylonjsBindings.slnx", "--locked-mode"]],
  ["maintained .NET compile suite", "dotnet", ["build", "BabylonjsBindings.slnx", "--no-restore", "--nologo", "-v:minimal"]],
  ["shared .NET and emitted JavaScript fixture", "node", ["--test", "tests/bindings/cross-runtime.test.mjs"]],
  ["M2 dependent-map negative fixtures", "npm", ["run", "test:m2-negative"]],
  ["M3 higher-order negative fixtures", "npm", ["run", "test:m3-negative"]],
  ["M4 fixed-shape negative fixture", "npm", ["run", "test:m4-negative"]],
  ["full maintained Fable emission", "dotnet", ["fable", "tests/BabylonjsBindings.CompileTests/BabylonjsBindings.CompileTests.fsproj", "--outDir", "runtime/full-dist", "--noCache"]],
  ["all emitted modular imports resolve", "node", ["scripts/check-emitted-imports.mjs", "runtime/full-dist", "reports/bindings-emitted-imports.json"]],
  ["fixed-shape and namespace emitted calls", "node", ["scripts/check-m6-emitted.mjs", "runtime/full-dist"]],
  ["Fable-emitted Node execution", "node", ["runtime/full-dist/Program.js"]],
  ["base Babylon Node smoke", "npm", ["run", "test:runtime"]],
  ["finite-map Node smoke", "npm", ["run", "test:m2-node"]],
  ["higher-order Node smoke", "npm", ["run", "test:m3-node"]],
  ["glTF namespace Node smoke", "npm", ["run", "test:m5-node"]],
  ["M2 browser fixture emission", "npm", ["run", "test:m2-fable"]],
  ["M3 browser fixture emission", "npm", ["run", "test:m3-fable"]],
  ["deterministic WebXR Chromium smoke", "npm", ["run", "test:m2-browser"]],
  ["higher-order Chromium smoke", "npm", ["run", "test:m3-browser"]],
  ["analysis unit tests", "npm", ["run", "analysis:test"]],
  ["analysis deterministic and current", "npm", ["run", "analysis:determinism"]],
  ["analysis generated views current", "npm", ["run", "analysis:check"]],
  ["complete export coverage gate", "npm", ["run", "coverage:require-complete"]],
  ["isolated packed NuGet/npm consumer", "npm", ["run", "test:m6-clean-consumer"]]
];
const escapeXml = value => String(value).replaceAll("&", "&amp;").replaceAll("<", "&lt;").replaceAll(">", "&gt;").replaceAll('"', "&quot;");
const results = [];
let failure;
for (const [name, command, args] of checks) {
  const started = performance.now();
  const run = spawnSync(command, args, { cwd: root, env, encoding: "utf8", stdio: "inherit" });
  const durationSeconds = (performance.now() - started) / 1000;
  const result = { name, command: `${command} ${args.join(" ")}`, result: run.status === 0 ? "pass" : "fail", exitCode: run.status, durationSeconds };
  results.push(result);
  if (run.status !== 0) { failure = result; break; }
}
const version = (command, args) => spawnSync(command, args, { cwd: root, env, encoding: "utf8" }).stdout.trim();
const packageLock = await readFile(resolve(root, "package-lock.json"));
const coverage = JSON.parse(await readFile(resolve(root, "coverage-and-drift.json"), "utf8"));
const importInventory = JSON.parse(await readFile(resolve(root, "reports/bindings-runtime-import-inventory.json"), "utf8"));
const report = {
  schemaVersion: 1,
  result: failure ? "fail" : "pass",
  environment: {
    dotnet: version("dotnet", ["--version"]),
    fable: JSON.parse(await readFile(resolve(root, ".config/dotnet-tools.json"), "utf8")).tools.fable.version,
    node: version("node", ["--version"]),
    npm: version("npm", ["--version"]),
    chromium: version("chromium", ["--version"]),
    packageLockSha256: createHash("sha256").update(packageLock).digest("hex")
  },
  coverage: coverage.summary,
  exhaustiveRuntimeInventory: { requests: importInventory.requestCount, modules: importInventory.moduleCount },
  checks: results
};
const failures = results.filter(item => item.result === "fail");
const testCases = results.map(item => `  <testcase classname="BabylonjsBindings.Comprehensive" name="${escapeXml(item.name)}" time="${item.durationSeconds.toFixed(3)}">${item.result === "fail" ? `<failure message="exit code ${item.exitCode}">${escapeXml(item.command)}</failure>` : ""}</testcase>`).join("\n");
const junit = `<?xml version="1.0" encoding="utf-8"?>\n<testsuite name="BabylonjsBindings comprehensive bindings" tests="${results.length}" failures="${failures.length}" time="${results.reduce((sum, item) => sum + item.durationSeconds, 0).toFixed(3)}">\n${testCases}\n</testsuite>\n`;
await mkdir(resolve(root, "reports"), { recursive: true });
await writeFile(resolve(root, "reports/bindings-comprehensive.json"), `${JSON.stringify(report, null, 2)}\n`);
await writeFile(resolve(root, "reports/bindings-comprehensive.junit.xml"), junit);
if (failure) throw new Error(`${failure.name} failed with exit code ${failure.exitCode}`);
console.log(`Comprehensive bindings suite passed: ${results.length} checks, ${coverage.summary.typed} typed exports, ${importInventory.requestCount} runtime imports`);
