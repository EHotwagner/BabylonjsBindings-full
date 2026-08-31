import assert from "node:assert/strict";
import { spawn } from "node:child_process";
import { mkdir, writeFile } from "node:fs/promises";
import { homedir } from "node:os";
import { delimiter, resolve } from "node:path";
import test from "node:test";

const root = resolve(import.meta.dirname, "../..");
const project = "tests/BabylonjsBindings.CrossRuntimeTests/BabylonjsBindings.CrossRuntimeTests.fsproj";
const dist = ".tmp/bindings-cross-runtime-dist";
const dotnetRoot = resolve(homedir(), ".dotnet");
const env = { ...process.env, DOTNET_ROOT: dotnetRoot, PATH: `${dotnetRoot}${delimiter}${process.env.PATH}` };
const run = (command, args) => new Promise((accept, reject) => {
  const child = spawn(command, args, { cwd: root, env }); let output = "";
  child.stdout.on("data", chunk => output += chunk); child.stderr.on("data", chunk => output += chunk);
  child.on("error", reject); child.on("close", code => code === 0 ? accept(output) : reject(new Error(`${command} ${args.join(" ")} exited ${code}\n${output}`)));
});
const fixture = output => output.split(/\r?\n/).find(line => line.startsWith("FIXTURE:"))?.slice("FIXTURE:".length);

test("the same serialized binding fixture agrees in .NET and emitted JavaScript", { timeout: 120000 }, async () => {
  const dotnetOutput = await run("dotnet", ["run", "--project", project, "--no-restore"]);
  await run("dotnet", ["fable", project, "--outDir", dist, "--noCache"]);
  const nodeOutput = await run("node", [`${dist}/Program.js`]);
  const dotnetFixture = fixture(dotnetOutput);
  const nodeFixture = fixture(nodeOutput);
  assert.ok(dotnetFixture, "missing .NET fixture");
  assert.equal(nodeFixture, dotnetFixture);
  assert.deepEqual(JSON.parse(nodeFixture), { shaderLanguage: 1, loaderReady: 1, fft32768: 32768, sceneLoaderError: 3000 });
  const report = { schemaVersion: 1, result: "pass", project, emitted: `${dist}/Program.js`, dotnet: JSON.parse(dotnetFixture), node: JSON.parse(nodeFixture) };
  await mkdir(resolve(root, "reports"), { recursive: true });
  await writeFile(resolve(root, "reports/bindings-cross-runtime.json"), `${JSON.stringify(report, null, 2)}\n`);
});
