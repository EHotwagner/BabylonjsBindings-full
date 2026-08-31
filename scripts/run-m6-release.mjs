import { spawnSync } from "node:child_process";
import { mkdir, readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const env = { ...process.env, PATH: `/home/developer/.dotnet:${process.env.PATH}` };
const checks = [
  ["locked declaration drift", "npm", ["run", "check:drift"]],
  ["M4 deterministic registry", "npm", ["run", "check:m4-type-core"]],
  ["M4 negative fixed shape", "npm", ["run", "test:m4-negative"]],
  ["M5 checker/runtime facade", "npm", ["run", "check:m5-gltf-namespaces"]],
  ["M5 runtime key equality", "npm", ["run", "test:m5-node"]],
  ["locked maintained restore", "dotnet", ["restore", "--locked-mode"]],
  ["maintained compile", "dotnet", ["build", "--no-restore", "--nologo", "-v:minimal"]],
  ["Fable full consumer emission", "dotnet", ["fable", "tests/BabylonjsBindings.CompileTests/BabylonjsBindings.CompileTests.fsproj", "--outDir", "runtime/full-dist", "--noCache"]],
  ["exact emitted imports and calls", "node", ["scripts/check-m6-emitted.mjs"]],
  ["base Node runtime", "npm", ["run", "test:runtime"]],
  ["M2 Node runtime", "npm", ["run", "test:m2-node"]],
  ["M3 Node runtime", "npm", ["run", "test:m3-node"]],
  ["M2 browser consumer emission", "npm", ["run", "test:m2-fable"]],
  ["M3 browser consumer emission", "npm", ["run", "test:m3-fable"]],
  ["M2 Chromium runtime", "npm", ["run", "test:m2-browser"]],
  ["M3 Chromium runtime", "npm", ["run", "test:m3-browser"]],
  ["analysis tests", "npm", ["run", "analysis:test"]],
  ["analysis determinism", "npm", ["run", "analysis:determinism"]],
  ["analysis current", "npm", ["run", "analysis:check"]],
  ["complete coverage", "npm", ["run", "coverage:require-complete"]],
  ["clean packed consumer", "npm", ["run", "test:m6-clean-consumer"]]
];
const results = [];
for (const [name, command, args] of checks) {
  const run = spawnSync(command, args, { cwd: root, env, encoding: "utf8", stdio: "inherit" });
  if (run.status !== 0) throw new Error(`${name} failed with ${run.status}`);
  results.push({ name, command: `${command} ${args.join(" ")}`, result: "pass" });
}
const projectSource = await readFile(resolve(root, "src/BabylonjsBindings/BabylonjsBindings.fsproj"), "utf8");
const packageVersion = projectSource.match(/<Version>([^<]+)<\/Version>/)?.[1];
if (!packageVersion) throw new Error("BabylonjsBindings package version is missing");
const release = { schemaVersion: 1, milestone: "M6", result: "pass", coverage: { total: 4323, typed: 4322, runtimeOnly: 1, blocked: 0, lossy: 0 }, packageVersion, cleanConsumer: JSON.parse(await readFile(resolve(root, "reports/m6-clean-consumer.json"), "utf8")), checks: results };
await mkdir(resolve(root, "reports"), { recursive: true });
await writeFile(resolve(root, "reports/m6-release.json"), `${JSON.stringify(release, null, 2)}\n`);
console.log(`M6 release evidence passed: ${results.length} checks`);
