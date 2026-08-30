import { createHash } from "node:crypto";
import { readdir, readFile, stat, writeFile } from "node:fs/promises";
import { dirname, relative, resolve, sep } from "node:path";

const root = resolve(import.meta.dirname, "..");
const dist = resolve(root, process.argv[2] ?? "generated-candidates/runtime/dist");
const evidencePath = resolve(root, process.argv[3] ?? "generated-candidates/runtime/import-evidence.json");
const check = process.argv.includes("--check");
const sha256 = value => createHash("sha256").update(value).digest("hex");
const normalize = value => relative(root, value).split(sep).join("/");
const files = [];
const visit = async directory => {
  for (const entry of await readdir(directory, { withFileTypes: true })) {
    const path = resolve(directory, entry.name);
    if (entry.isDirectory()) await visit(path);
    else if (entry.isFile() && entry.name.endsWith(".js")) files.push(path);
  }
};
await visit(dist);

const imports = new Map();
for (const file of files.sort()) {
  const source = await readFile(file, "utf8");
  const patterns = [
    /\bfrom\s+["']([^"']+)["']/g,
    /\bimport\s+["']([^"']+)["']/g,
    /\bimport\s*\(\s*["']([^"']+)["']\s*\)/g
  ];
  for (const pattern of patterns) {
    for (const match of source.matchAll(pattern)) {
      if (!match[1].startsWith("@babylonjs/")) continue;
      const owners = imports.get(match[1]) ?? new Set();
      owners.add(normalize(file));
      imports.set(match[1], owners);
    }
  }
}

const resolutions = [];
for (const [specifier, owners] of [...imports].sort(([left], [right]) => left.localeCompare(right))) {
  const packageName = specifier.startsWith("@babylonjs/core/")
    ? "@babylonjs/core"
    : specifier.startsWith("@babylonjs/loaders/")
      ? "@babylonjs/loaders"
      : undefined;
  if (!packageName) throw new Error(`non-core/loaders Babylon import emitted: ${specifier}`);
  if (!specifier.endsWith(".js")) throw new Error(`Babylon import is not an explicit modular JavaScript path: ${specifier}`);
  const packageRoot = resolve(root, "node_modules", packageName);
  const packageJson = JSON.parse(await readFile(resolve(packageRoot, "package.json"), "utf8"));
  if (packageJson.version !== "9.19.0") throw new Error(`${packageName} resolved to ${packageJson.version}, expected 9.19.0`);
  const suffix = specifier.slice(packageName.length + 1);
  const resolvedPath = resolve(packageRoot, suffix);
  const resolvedStat = await stat(resolvedPath).catch(() => undefined);
  if (!resolvedStat?.isFile()) throw new Error(`emitted Babylon import does not resolve to a file: ${specifier}`);
  resolutions.push({
    specifier,
    package: packageName,
    version: packageJson.version,
    resolvedPath: normalize(resolvedPath),
    emittedBy: [...owners].sort()
  });
}
if (resolutions.length === 0) throw new Error("no emitted Babylon imports were found");
if (!resolutions.some(item => item.package === "@babylonjs/core")) throw new Error("candidate emitted no @babylonjs/core imports");
if (!resolutions.some(item => item.package === "@babylonjs/loaders")) throw new Error("candidate emitted no explicit @babylonjs/loaders side-effect import");

const programPath = resolve(dist, "Program.js");
const programSource = await readFile(programPath);
const manifest = JSON.parse(await readFile(resolve(root, ".config/dotnet-tools.json"), "utf8"));
const report = {
  schemaVersion: 1,
  target: "generated-candidate",
  fable: manifest.tools.fable.version,
  emittedProgram: { path: normalize(programPath), sha256: sha256(programSource) },
  imports: resolutions,
  status: "pass"
};
const rendered = `${JSON.stringify(report, null, 2)}\n`;
if (check) {
  if (await readFile(evidencePath, "utf8") !== rendered) throw new Error("candidate import evidence is stale");
} else {
  await writeFile(evidencePath, rendered);
}
console.log(`resolved ${resolutions.length} emitted Babylon imports against exact 9.19.0 packages`);
