import { spawnSync } from "node:child_process";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const fixtures = [
  "device-mismatch/DeviceMismatch.fsproj",
  "device-event-mismatch/DeviceEventMismatch.fsproj",
  "flow-mismatch/FlowMismatch.fsproj",
  "flow-block-mismatch/FlowBlockMismatch.fsproj",
  "flow-switch-mismatch/FlowSwitchMismatch.fsproj",
  "xr-mismatch/XRMismatch.fsproj",
  "xr-resolve-mismatch/XRResolveMismatch.fsproj",
  "xr-result-mismatch/XRResultMismatch.fsproj"
];
for (const fixture of fixtures) {
  const project = resolve(root, "tests/negative", fixture);
  const run = spawnSync("dotnet", ["build", project, "--nologo", "-v:minimal"], { cwd: root, encoding: "utf8", env: { ...process.env, PATH: `/home/developer/.dotnet:${process.env.PATH}` } });
  const output = `${run.stdout}\n${run.stderr}`;
  if (run.status === 0) throw new Error(`${fixture} unexpectedly compiled; dependent correlation collapsed`);
  if (!/error FS(0001|0041|0193)/.test(output)) throw new Error(`${fixture} failed for an unexpected reason:\n${output}`);
  console.log(`${fixture}: rejected as expected`);
}
