import { mkdtemp, rm, writeFile } from "node:fs/promises";
import { tmpdir } from "node:os";
import { resolve } from "node:path";
import { spawnSync } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const directory = await mkdtemp(resolve(tmpdir(), "babylon-m4-negative-"));
try {
  await writeFile(resolve(directory, "Negative.fsproj"), `<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><TargetFramework>net10.0</TargetFramework><RestoreLockedMode>false</RestoreLockedMode></PropertyGroup><ItemGroup><ProjectReference Include="${resolve(root, "src/BabylonjsBindings/BabylonjsBindings.fsproj")}"/></ItemGroup><ItemGroup><Compile Include="Program.fs"/></ItemGroup></Project>\n`);
  await writeFile(resolve(directory, "Program.fs"), `module WrongShape\nopen BabylonjsBindings.TypeFunctionCore\nlet wrong (value: Vector2Projection) = value.set(1.0, 2.0, 3.0)\n`);
  const run = spawnSync("dotnet", ["build", "Negative.fsproj", "--nologo", "-v:minimal", "-p:RestoreLockedMode=false"], { cwd: directory, encoding: "utf8", env: { ...process.env, PATH: `/home/developer/.dotnet:${process.env.PATH}` } });
  const output = `${run.stdout}\n${run.stderr}`;
  if (run.status === 0) throw new Error("wrong-length Vector2 coordinates unexpectedly compiled");
  if (!/error FS(0001|0003|0005|0041|0193)/.test(output)) throw new Error(`negative fixture failed unexpectedly:\n${output}`);
  console.log("M4 negative fixed-shape fixture rejected as expected");
} finally {
  await rm(directory, { recursive: true, force: true });
}
