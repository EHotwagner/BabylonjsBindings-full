import { createHash } from "node:crypto";
import { access, readFile, writeFile } from "node:fs/promises";
import { dirname, extname, normalize, relative, resolve } from "node:path";

const args = process.argv.slice(2);
const valueAfter = flag => {
  const index = args.indexOf(flag);
  return index < 0 ? undefined : args[index + 1];
};
const root = resolve(valueAfter("--declarations-root") ?? resolve(import.meta.dirname, "..", "node_modules"));
const lockPath = resolve(valueAfter("--lock") ?? resolve(import.meta.dirname, "..", "declaration-lock.json"));
const entryPoints = valueAfter("--entry") ? [valueAfter("--entry")] : [
  "@babylonjs/core/index.d.ts",
  "@babylonjs/loaders/index.d.ts"
];

const asDeclarationPath = async requested => {
  const extension = extname(requested);
  const candidates = requested.endsWith(".d.ts")
    ? [requested]
    : extension === ".js"
    ? [`${requested.slice(0, -3)}.d.ts`]
    : [`${requested}.d.ts`, resolve(requested, "index.d.ts")];
  for (const candidate of candidates) {
    try {
      await access(candidate);
      return relative(root, candidate).replaceAll("\\", "/");
    } catch {}
  }
  throw new Error(`cannot resolve declaration: ${relative(root, requested)}`);
};

const declarationPath = async (from, specifier) => {
  if (!specifier.startsWith(".")) {
    const segments = specifier.split("/");
    const packageName = specifier.startsWith("@") ? segments.slice(0, 2).join("/") : segments[0];
    const subpath = segments.slice(specifier.startsWith("@") ? 2 : 1).join("/");
    const packageRoot = resolve(root, packageName);
    if (subpath) return asDeclarationPath(resolve(packageRoot, subpath));
    const manifest = JSON.parse(await readFile(resolve(packageRoot, "package.json"), "utf8"));
    return asDeclarationPath(resolve(packageRoot, manifest.types ?? manifest.typings ?? "index.d.ts"));
  }
  const requested = normalize(resolve(dirname(resolve(root, from)), specifier));
  if (!requested.startsWith(`${root}/`)) throw new Error(`relative declaration escaped root: ${from} -> ${specifier}`);
  return asDeclarationPath(requested);
};

// Covers re-exports, dynamic imports, and static side-effect imports.
const references = source => {
  const syntax = source.replace(/\/\*[\s\S]*?\*\//g, "").replace(/\/\/.*$/gm, "");
  return [...syntax.matchAll(/(?:\bfrom\s*|\bimport\s*\(\s*|\bimport\s*)["']([^"']+?)["']/g)].map(match => match[1]);
};
const seen = new Set();
const pending = [...entryPoints].sort();
while (pending.length > 0) {
  const path = pending.shift();
  if (seen.has(path)) continue;
  const source = await readFile(resolve(root, path), "utf8");
  seen.add(path);
  for (const specifier of references(source)) pending.push(await declarationPath(path, specifier));
  pending.sort();
}

const files = await Promise.all([...seen].sort().map(async path => ({
  path,
  sha256: createHash("sha256").update(await readFile(resolve(root, path))).digest("hex")
})));
const document = { schema: 2, package: "@babylonjs/core@9.19.0", companionPackage: "@babylonjs/loaders@9.19.0", entryPoints, files };
const rendered = `${JSON.stringify(document, null, 2)}\n`;
if (args.includes("--write")) {
  await writeFile(lockPath, rendered);
  console.log(`wrote ${lockPath} (${files.length} declaration files)`);
} else {
  if (await readFile(lockPath, "utf8") !== rendered) throw new Error("declaration closure drifted; review the lock, curated bindings, runtime evidence, and release notes together");
  console.log(`declaration closure is locked (${files.length} declaration files)`);
}
