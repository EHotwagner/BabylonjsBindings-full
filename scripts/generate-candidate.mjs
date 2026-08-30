import { createHash } from "node:crypto";
import { mkdtemp, mkdir, readFile, rm, writeFile } from "node:fs/promises";
import { tmpdir } from "node:os";
import { dirname, resolve } from "node:path";
import { spawn } from "node:child_process";

const root = resolve(import.meta.dirname, "..");
const generatedRoot = resolve(root, "generated-candidates");
const declarationLockPath = resolve(root, "declaration-lock.json");
const maintainedPath = resolve(root, "src/BabylonjsBindings/Bindings.fs");
const packageJson = JSON.parse(await readFile(resolve(root, "package.json"), "utf8"));
const sourcePath = resolve(root, "node_modules/babylonjs/babylon.module.d.ts");
const converterPath = resolve(root, "node_modules/ts2fable/dist/ts2fable.js");

const sha256 = value => createHash("sha256").update(value).digest("hex");
const stableJson = value => `${JSON.stringify(value, null, 2)}\n`;
const writeStable = async (path, value) => {
  await mkdir(dirname(path), { recursive: true });
  await writeFile(path, value);
};

const run = (command, args, options = {}) => new Promise((accept, reject) => {
  const child = spawn(command, args, { cwd: root, ...options });
  let stdout = "";
  let stderr = "";
  child.stdout.on("data", chunk => { stdout += chunk; });
  child.stderr.on("data", chunk => { stderr += chunk; });
  child.on("error", reject);
  child.on("close", code => code === 0
    ? accept({ stdout, stderr })
    : reject(new Error(`${command} exited ${code}\n${stdout}\n${stderr}`)));
});

const repairCandidate = source => {
  let repaired = source
    .replace(/^module rec .*$/m, "module rec BabylonjsBindings.FullCandidate")
    .replace(/type Empty =\n\s*\n/g, "type Empty =\n        obj\n\n")
    .replaceAll("Nullable<>", "obj")
    .replace(/\?storage:\s+->/g, "?storage: obj ->")
    .replace(/storage:\s+option/g, "storage: obj option")
    .replaceAll("| Object = 2147483648", "| Object = -2147483648")
    .replaceAll("| All = 4294967295", "| All = -1")
    .replace(/^\s*module BABYLON = Babylonjs_index\s*$/gm, "");

  repaired = repaired.replace(
    /let \[<ImportAll\("[^"]+"\)>\] ``(babylonjs(?:\/[^`]+)?)``:/g,
    (line, moduleName) => {
      const suffix = moduleName === "babylonjs" || moduleName === "babylonjs/index"
        ? "index"
        : moduleName.slice("babylonjs/".length);
      return line.replace(/ImportAll\("[^"]+"\)/, `ImportAll("@babylonjs/core/${suffix}.js")`);
    });

  const moduleNames = new Set([...repaired.matchAll(/^module ([A-Za-z_][A-Za-z0-9_]*) =$/gm)].map(match => match[1]));
  const referencedModules = new Set([...repaired.matchAll(/\b(Babylonjs_[A-Za-z0-9_]+)\./g)].map(match => match[1]));
  for (const missing of [...referencedModules].sort()) {
    if (missing === "Babylonjs_index" || moduleNames.has(missing)) continue;
    const replacement = [`${missing}_pure`, `${missing}_core`, `${missing}_types`].find(candidate => moduleNames.has(candidate));
    if (replacement) repaired = repaired.replaceAll(`${missing}.`, `${replacement}.`);
  }

  const definitions = new Map();
  const declaredTypes = new Set();
  let currentModule;
  for (const line of repaired.split("\n")) {
    const moduleMatch = line.match(/^module ([A-Za-z_][A-Za-z0-9_]*) =$/);
    if (moduleMatch) {
      currentModule = moduleMatch[1];
      continue;
    }
    const typeMatch = line.match(/^ {4}type (?:\[<[^\]]+>\]\s*)*([A-Za-z_][A-Za-z0-9_]*)(<[^=]+>)?\s*=\s*(.*)$/);
    if (!currentModule || !typeMatch) continue;
    const [, name, generic = "", body] = typeMatch;
    declaredTypes.add(`${currentModule}.${name}`);
    if (body.startsWith("Babylonjs_") || body.startsWith("BABYLON.")) continue;
    const score = (currentModule.endsWith("_pure") ? 8 : 0) + (body.length === 0 ? 4 : 0) + (body === "obj" ? -4 : 0);
    const entries = definitions.get(name) ?? [];
    entries.push({ module: currentModule, generic: generic.trim(), score });
    definitions.set(name, entries);
  }

  const rootNames = new Set([...repaired.matchAll(/Babylonjs_index\.([A-Za-z_][A-Za-z0-9_]*)/g)].map(match => match[1]));
  for (const name of [...rootNames].sort()) {
    const choices = (definitions.get(name) ?? []).sort((left, right) => right.score - left.score || left.module.localeCompare(right.module));
    if (choices.length > 0) repaired = repaired.replaceAll(`Babylonjs_index.${name}`, `${choices[0].module}.${name}`);
  }

  repaired = repaired.replace(
    /Babylonjs_[A-Za-z0-9_]+\.(Babylonjs_[A-Za-z0-9_]+\.[A-Za-z_][A-Za-z0-9_]*)/g,
    (whole, inner) => moduleNames.has(inner.slice(0, inner.lastIndexOf("."))) ? inner : whole);

  const qualifiedTypes = new Set([...repaired.matchAll(/\b((?:Babylonjs_[A-Za-z0-9_]+|BABYLON))\.([A-Za-z_][A-Za-z0-9_]*)/g)]
    .map(match => `${match[1]}.${match[2]}`));
  for (const qualified of [...qualifiedTypes].sort()) {
    if (declaredTypes.has(qualified)) continue;
    const separator = qualified.lastIndexOf(".");
    const name = qualified.slice(separator + 1);
    const choices = (definitions.get(name) ?? []).sort((left, right) => right.score - left.score || left.module.localeCompare(right.module));
    if (choices.length > 0) repaired = repaired.replaceAll(qualified, `${choices[0].module}.${name}`);
  }

  repaired = repaired.split("\n").map(line => {
    const alias = line.match(/^(\s*)type ([A-Za-z_][A-Za-z0-9_]*)\s*=\s*((?:Babylonjs_[A-Za-z0-9_]+|BABYLON)\.([A-Za-z_][A-Za-z0-9_]*))\s*$/);
    if (!alias || declaredTypes.has(alias[3])) return line;
    return `${alias[1]}type ${alias[2]} = obj`;
  }).join("\n");

  const generics = new Map();
  currentModule = undefined;
  for (const line of repaired.split("\n")) {
    const moduleMatch = line.match(/^module ([A-Za-z_][A-Za-z0-9_]*) =$/);
    if (moduleMatch) {
      currentModule = moduleMatch[1];
      continue;
    }
    const typeMatch = line.match(/^ {4}type (?:\[<[^\]]+>\]\s*)*([A-Za-z_][A-Za-z0-9_]*)(<[^=]+>)\s*=/);
    if (currentModule && typeMatch) {
      const declaration = typeMatch[2].trim();
      const parameters = [...declaration.matchAll(/'[A-Za-z_][A-Za-z0-9_]*/g)].map(match => match[0]);
      const application = `<${[...new Set(parameters)].join(", ")}>`;
      generics.set(`${currentModule}.${typeMatch[1]}`, { declaration, application });
    }
  }
  repaired = repaired.split("\n").map(line => line.replace(
    /^(\s*)type ([A-Za-z_][A-Za-z0-9_]*)\s*=\s*(Babylonjs_[A-Za-z0-9_]+|BABYLON)\.([A-Za-z_][A-Za-z0-9_]*)\s*$/,
    (whole, indent, alias, moduleName, typeName) => {
      const generic = generics.get(`${moduleName}.${typeName}`);
      return generic ? `${indent}type ${alias}${generic.declaration} = ${moduleName}.${typeName}${generic.application}` : whole;
    })).join("\n");

  const browserShims = [
    "type ArrayBufferLike = obj",
    "type InstanceType<'T> = obj",
    "type Record<'K, 'V> = Map<'K, 'V>",
    "type IteratorResult<'T, 'TReturn> = Fable.Core.JS.IteratorResult<'T>",
    "type Exclude<'T, 'U> = obj",
    "type WebGLQuery = obj",
    "type AudioBuffer = obj",
    "type ImageBitmapRenderingContext = obj",
    "[<AllowNullLiteral>]",
    "type ImageBitmap =",
    "    abstract width: float",
    "    abstract height: float",
    "    abstract close: unit -> unit"
  ].join("\n");
  repaired = repaired.replace("type Symbol = obj", `type Symbol = obj\n${browserShims}`);
  repaired = repaired
    .replace(/Uint32Array<[^>\n]+>/g, "Uint32Array")
    .replaceAll("Babylonjs_types.float", "float");
  return repaired.split("\n").map(line => line.trimEnd()).join("\n");
};

const tempRoot = await mkdtemp(resolve(tmpdir(), "babylon-bindings-candidate-"));
try {
  const declarationLock = await readFile(declarationLockPath);
  const maintained = await readFile(maintainedPath);
  const source = await readFile(sourcePath, "utf8");
  const stripped = source.replace(/\/\*\*[\s\S]*?\*\//g, "");
  const inputPath = resolve(tempRoot, "babylon.module.no-docs.d.ts");
  const rawPath = resolve(tempRoot, "Babylon.Full.raw.fs");
  await writeFile(inputPath, stripped);
  const execution = await run(process.execPath, ["--max-old-space-size=12288", converterPath, inputPath, rawPath]);
  const rawCandidate = await readFile(rawPath, "utf8");
  const candidateBody = repairCandidate(rawCandidate);
  const sourceDigest = sha256(source);
  const candidate = [
    "// REVIEW-ONLY GENERATED CANDIDATE — NOT COMPILED INTO THE PACKAGE",
    `// source babylonjs@9.19.0 babylon.module.d.ts sha256: ${sourceDigest}`,
    `// generator ts2fable@${packageJson.devDependencies.ts2fable} with typescript@5.1.6`,
    candidateBody
  ].join("\n");
  const normalizedLog = `${execution.stdout}\n${execution.stderr}`.replaceAll(tempRoot, "<temp>");
  const diagnostics = new Map();
  for (const line of normalizedLog.split("\n").map(line => line.trim()).filter(Boolean)) {
    if (!line.startsWith("unsupported ")) continue;
    diagnostics.set(line, (diagnostics.get(line) ?? 0) + 1);
  }
  const diagnosticDocument = {
    schemaVersion: 1,
    generator: { name: "ts2fable", version: packageJson.devDependencies.ts2fable, typescript: "5.1.6" },
    source: { package: "babylonjs", version: "9.19.0", path: "babylon.module.d.ts", sha256: sourceDigest },
    candidateSha256: sha256(candidate),
    diagnostics: [...diagnostics].sort(([left], [right]) => left.localeCompare(right)).map(([message, count]) => ({ message, count })),
    status: diagnostics.size === 0 ? "clean" : "review-required"
  };
  const generatorLock = {
    schemaVersion: 1,
    source: { package: "babylonjs", version: "9.19.0", path: "babylon.module.d.ts", sha256: sourceDigest },
    authoritativeDeclarationLockSha256: sha256(declarationLock),
    maintainedSurfaceSha256: sha256(maintained),
    tools: {
      node: process.version,
      ts2fable: packageJson.devDependencies.ts2fable,
      ts2fableTypescript: "5.1.6",
      glutinum: packageJson.devDependencies["@glutinum/cli"],
      glutinumTypescript: "5.2.2"
    }
  };
  const lineCount = candidate.split("\n").length;
  const proposal = [
    "# Full Babylon.js candidate proposal",
    "",
    `- Source: \`babylonjs@9.19.0/babylon.module.d.ts\` (SHA-256 \`${sourceDigest}\`)`,
    `- Candidate: ${lineCount.toLocaleString("en-US")} lines (SHA-256 \`${sha256(candidate)}\`)`,
    `- Converter: \`ts2fable@${packageJson.devDependencies.ts2fable}\` with \`typescript@5.1.6\``,
    `- Unique unsupported diagnostics: ${diagnostics.size}`,
    "",
    "This is a deterministic, review-only inventory. It never overwrites `src/` or advances `declaration-lock.json`.",
    "Promotion requires a clean F# compile, modular import resolution, per-export non-lossy coverage, and runtime evidence."
  ].join("\n") + "\n";
  await writeStable(resolve(generatedRoot, "BabylonBindings.generated.fs"), candidate);
  await writeStable(resolve(generatedRoot, "BabylonBindings.proposal.md"), proposal);
  await writeStable(resolve(generatedRoot, "candidate-diagnostics.json"), stableJson(diagnosticDocument));
  await writeStable(resolve(root, "generator-lock.json"), stableJson(generatorLock));
  console.log(`updated review-only candidate (${lineCount} lines, ${diagnostics.size} unique unsupported diagnostics)`);
} finally {
  await rm(tempRoot, { recursive: true, force: true });
}
