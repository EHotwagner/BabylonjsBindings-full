import { spawnSync } from "node:child_process";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const fixtures = [
  "m3-arity-mismatch/M3ArityMismatch.fsproj",
  "m3-decorator-mismatch/M3DecoratorMismatch.fsproj",
  "m3-mixin-mismatch/M3MixinMismatch.fsproj"
];

for (const fixture of fixtures) {
  const project = resolve(root, "tests/negative", fixture);
  const run = spawnSync("dotnet", ["build", project, "--nologo", "-v:minimal"], {
    cwd: root,
    encoding: "utf8",
    env: { ...process.env, PATH: `/home/developer/.dotnet:${process.env.PATH}` }
  });
  const output = `${run.stdout}\n${run.stderr}`;
  if (run.status === 0) throw new Error(`${fixture} unexpectedly compiled; M3 correlation collapsed`);
  if (!/error FS(0001|0041|0193)/.test(output)) throw new Error(`${fixture} failed for an unexpected reason:\n${output}`);
  console.log(`${fixture}: rejected as expected`);
}
