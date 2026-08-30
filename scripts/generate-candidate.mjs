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
    .replaceAll("type [<RequireQualifiedAccess>] ", "type ")
    .replace("type Error = System.Exception", "type [<AllowNullLiteral>] Error = interface end")
    .replace(/type Empty =\n\s*\n/g, "type Empty =\n        obj\n\n")
    .replaceAll("Nullable<>", "obj")
    .replace(/\?storage:\s+->/g, "?storage: obj ->")
    .replace(/storage:\s+option/g, "storage: obj option")
    .replaceAll("| Object = 2147483648", "| Object = -2147483648")
    .replaceAll("| All = 4294967295", "| All = -1")
    .replace(/ProgressEvent<[^>\n]+>/g, "ProgressEvent")
    .replace(/ArrayBufferView<[^>\n]+>/g, "ArrayBufferView")
    .replace(/^\s*inherit obj\s*$/gm, "")
    .replace(/^(\s*type (?:\[<[^>]+>\]\s*)*[A-Za-z_][A-Za-z0-9_]*(?:<[^\n=]+>)?\s*=)\n(?=\s*\n)/gm, "$1 interface end\n")
    .replace(/^([ \t]*)abstract filter: \('T -> .*ClassMethodDecoratorContext.*$/gm, "$1abstract filter: obj with get, set")
    .replaceAll("_ownerBlock: BlockT -> FlowGraphSignalConnection", "_ownerBlock: FlowGraphExecutionBlock -> FlowGraphSignalConnection")
    .replaceAll("args: obj * 'R -> 'R when 'R :> 'I", "args: obj * 'I -> 'I")
    .replaceAll("[<CompiledName(\"FlowGraphNaNBlock\")>] NaN", "[<CompiledName(\"FlowGraphNaNBlock\")>] NotANumber")
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
  const nonGenericTypes = new Set();
  currentModule = undefined;
  for (const line of repaired.split("\n")) {
    const moduleMatch = line.match(/^module ([A-Za-z_][A-Za-z0-9_]*) =$/);
    if (moduleMatch) {
      currentModule = moduleMatch[1];
      continue;
    }
    const typeMatch = line.match(/^ {4}type (?:\[<[^\]]+>\]\s*)*([A-Za-z_][A-Za-z0-9_]*)(<[^=]+>)\s*=/);
    const nonGenericMatch = line.match(/^ {4}type (?:\[<[^\]]+>\]\s*)*([A-Za-z_][A-Za-z0-9_]*)\s*=/);
    if (currentModule && nonGenericMatch) nonGenericTypes.add(`${currentModule}.${nonGenericMatch[1]}`);
    if (currentModule && typeMatch) {
      const declaration = typeMatch[2].trim();
      const parameters = [...declaration.matchAll(/'[A-Za-z_][A-Za-z0-9_]*/g)].map(match => match[0]);
      const application = `<${[...new Set(parameters)].join(", ")}>`;
      const key = `${currentModule}.${typeMatch[1]}`;
      const variants = generics.get(key) ?? [];
      if (!variants.some(variant => variant.declaration === declaration)) variants.push({ declaration, application });
      generics.set(key, variants);
    }
  }
  repaired = repaired.split("\n").map(line => line.replace(
    /^(\s*)type ([A-Za-z_][A-Za-z0-9_]*)\s*=\s*(Babylonjs_[A-Za-z0-9_]+|BABYLON)\.([A-Za-z_][A-Za-z0-9_]*)\s*$/,
    (whole, indent, alias, moduleName, typeName) => {
      const key = `${moduleName}.${typeName}`;
      const variants = generics.get(key) ?? [];
      if (variants.length === 0) return whole;
      const aliases = variants.map(generic => `${indent}type ${alias}${generic.declaration} = ${moduleName}.${typeName}${generic.application}`);
      return nonGenericTypes.has(key) ? [whole, ...aliases].join("\n") : aliases.join("\n");
    })).join("\n");

  const browserShims = [
    "type ArrayBufferLike = obj",
    "type [<AllowNullLiteral>] InstanceType<'T> = interface end",
    "type Record<'K, 'V> = Map<'K, 'V>",
    "type [<AllowNullLiteral>] IteratorResult<'T, 'TReturn> =",
    "    abstract done': bool option",
    "    abstract value: U2<'T, 'TReturn>",
    "type [<AllowNullLiteral>] Exclude<'T, 'U> = interface end",
    "type [<AllowNullLiteral>] Required<'T> = interface end",
    "type [<AllowNullLiteral>] ConstructorParameters<'T> = interface end",
    "type [<AllowNullLiteral>] ReturnType<'T> = interface end",
    "type [<AllowNullLiteral>] Omit<'T, 'K> = interface end",
    "type [<AllowNullLiteral>] Iterable<'T> = interface end",
    "type [<AllowNullLiteral>] IterableIterator<'T> = inherit Iterable<'T>",
    "type [<AllowNullLiteral>] Generator<'TYield, 'TReturn, 'TNext> = inherit IterableIterator<'TYield>",
    "type [<AllowNullLiteral>] ClassAccessorDecoratorContext<'TThis, 'TValue> = interface end",
    "type [<AllowNullLiteral>] ClassAccessorDecoratorResult<'TThis, 'TValue> = interface end",
    "type [<AllowNullLiteral>] ClassAccessorDecoratorTarget<'TThis, 'TValue> = interface end",
    "type [<AllowNullLiteral>] ClassMethodDecoratorContext<'TThis, 'TValue> = interface end",
    "type WebGLQuery = obj",
    "type AudioBuffer = obj",
    "type GLenum = float",
    "type GLuint = float",
    "type GLint = float",
    "type GLsizei = float",
    "type GLboolean = bool",
    "type DOMHighResTimeStamp = float",
    "type GPUTextureFormat = string",
    "type GPUTextureViewDimension = string",
    "type GPUStorageTextureAccess = string",
    "type GPUFeatureName = string",
    "type GPUBufferUsageFlags = float",
    "type GPUTextureUsageFlags = float",
    "type GPUPowerPreference = string",
    "type GPUAutoLayoutMode = string",
    "type GPUBufferBindingType = string",
    "type GPUTextureSampleType = string",
    "type GPUSamplerBindingType = string",
    "type GPUCompareFunction = string",
    "type BodyInit = obj",
    "type BufferSource = obj",
    "type ImageBitmapSource = obj",
    "type XMLHttpRequestBodyInit = obj",
    "type ReferrerPolicy = string",
    "type XMLHttpRequestResponseType = string",
    "type BigUint64Array = obj",
    "type IArguments = obj",
    "type ImageBitmapRenderingContext = obj",
    "[<AllowNullLiteral>]",
    "type ImageBitmap =",
    "    abstract width: float",
    "    abstract height: float",
    "    abstract close: unit -> unit",
    ...[
      "AbortSignal", "AudioBufferSourceNode", "AudioContext", "AudioDestinationNode", "AudioNode", "AudioParam",
      "DecoratorMetadataObject", "DistanceModelType", "DOMMatrix", "DOMPointInit", "DOMPointReadOnly", "DOMRect",
      "EventListenerOptions", "EventListenerOrEventListenerObject", "GainNode", "GPUBindGroup", "GPUBindGroupEntry",
      "GPUBindGroupLayout", "GPUBindGroupLayoutEntry", "GPUBuffer", "GPUCommandEncoder", "GPUComputePipeline",
      "GPUCopyExternalImageDestInfo", "GPUDevice", "GPUDeviceDescriptor", "GPUPipelineLayout", "GPUProgrammableStage",
      "GPUQuerySet", "GPURenderBundle", "GPURenderBundleEncoder", "GPURenderPassDescriptor", "GPURenderPassEncoder",
      "GPURenderPipeline", "GPURenderPipelineDescriptor", "GPUSampler", "GPUTextureView", "ImageBitmapOptions",
      "MediaStream", "MediaStreamTrack", "MediaTrackConstraints", "PannerNode", "PanningModelType", "PointerEventInit",
      "MediaStreamAudioDestinationNode", "OfflineAudioContext", "GPUComputePassDescriptor",
      "Response", "StereoPannerNode", "URL", "VideoFrame", "WebGLTransformFeedback", "WebGLVertexArrayObject", "Worker",
      "XMLHttpRequest", "XMLHttpRequestEventMap", "CanvasCompositing", "CanvasDrawImage", "CanvasDrawPath",
      "CanvasFillStrokeStyles", "CanvasFilters", "CanvasImageData", "CanvasImageSmoothing", "CanvasPath",
      "CanvasPathDrawingStyles", "CanvasRect", "CanvasShadowStyles", "CanvasState", "CanvasText",
      "CanvasTextDrawingStyles", "CanvasTransform", "WebGL2RenderingContextBase", "OVR_multiview2",
      "EXT_texture_filter_anisotropic", "WEBGL_compressed_texture_s3tc", "WEBGL_compressed_texture_s3tc_srgb"
    ].flatMap(name => [`type [<AllowNullLiteral>] ${name} = interface end`])
  ].join("\n");
  repaired = repaired.replace("type Symbol = obj", `type Symbol = obj\n${browserShims}`);
  repaired = repaired.replace("type ArrayBufferLike = obj", "type Animation = Babylonjs_Animations_animation_pure.Animation\ntype ArrayBufferLike = obj");
  repaired = repaired.replace(
    /(module BABYLON =[\s\S]*?)abstract Sound: StaticSoundStatic/,
    '$1[<Emit("$0.Sound")>] abstract StaticSound: StaticSoundStatic');
  repaired = repaired
    .replace(/Uint32Array<[^>\n]+>/g, "Uint32Array")
    .replaceAll("Babylonjs_types.float", "float");

  // Conditional/mapped TypeScript helpers that ts2fable reduces to `obj`
  // cannot remain generic F# abbreviations because F# 10 rejects unused type
  // parameters. Keep their nominal generic identity as empty interfaces; the
  // corresponding lossy conversion remains recorded as review-required.
  const phantomLines = repaired.split("\n");
  for (let index = 0; index < phantomLines.length; index += 1) {
    const oneLine = phantomLines[index].match(/^(\s*)type (?:\[<AllowNullLiteral>\]\s*)?([A-Za-z_][A-Za-z0-9_]*)(<.+>)\s*=\s*obj\s*$/);
    const multiLine = phantomLines[index].match(/^(\s*)type (?:\[<AllowNullLiteral>\]\s*)?([A-Za-z_][A-Za-z0-9_]*)(<.+>)\s*=\s*$/);
    const isMultilineObject = multiLine && phantomLines[index + 1]?.trim() === "obj";
    const match = oneLine ?? (isMultilineObject ? multiLine : undefined);
    if (!match) continue;
    const parameters = [...new Set([...match[3].matchAll(/'[A-Za-z_][A-Za-z0-9_]*/g)].map(item => item[0]))];
    if (parameters.length === 0) continue;
    phantomLines[index] = `${match[1]}type [<AllowNullLiteral>] ${match[2]}<${parameters.join(", ")}> = interface end`;
    if (isMultilineObject) phantomLines.splice(index + 1, 1);
  }
  repaired = phantomLines.join("\n");

  // ts2fable represents some class-expression bases as exported `*_base`
  // values but does not emit their nominal type declarations. Materialize the
  // interface in its owning module so derived bindings retain the relationship.
  const moduleLines = repaired.split("\n");
  for (let start = 0; start < moduleLines.length;) {
    if (!/^module [A-Za-z_][A-Za-z0-9_]* =$/.test(moduleLines[start])) {
      start += 1;
      continue;
    }
    let end = start + 1;
    while (end < moduleLines.length && !/^module [A-Za-z_][A-Za-z0-9_]* =$/.test(moduleLines[end])) end += 1;
    const block = moduleLines.slice(start + 1, end);
    const declared = new Set(block.flatMap(line => {
      const found = line.match(/^ {4}type (?:\[<[^>]+>\]\s*)*([A-Za-z_][A-Za-z0-9_]*)/);
      return found ? [found[1]] : [];
    }));
    const missingBases = [...new Set(block.flatMap(line => {
      const found = line.match(/^ {8}inherit ([A-Za-z_][A-Za-z0-9_]*_base)\s*$/);
      return found && !declared.has(found[1]) ? [found[1]] : [];
    }))].sort();
    if (missingBases.length > 0) {
      moduleLines.splice(start + 1, 0, ...missingBases.flatMap(name => [
        `    type [<AllowNullLiteral>] ${name} = interface end`,
        ""
      ]));
      end += missingBases.length * 2;
    }
    start = end;
  }
  repaired = moduleLines.join("\n");

  // TypeScript permits constraints against unions, enums, and structural
  // records. Those are sealed/non-inheritable in F#, so retain the generic
  // parameter but drop only the unrepresentable subtype constraint.
  for (const constrained of [
    "TensorValue", "FlowGraphAssetType", "FlowGraphNumber", "DeviceType", "WebXRFeatureNameType", "NodeRenderGraphValueType",
    "Record<string, obj>", "Babylonjs_Cameras_camera_pure.Camera", "Babylonjs_Helpers_textureDome.Texture",
    "Babylonjs_FrameGraph_Passes_pass.FrameGraphContext", "Babylonjs_FlowGraph_flowGraphConnection.IConnectable"
  ]) {
    const escaped = constrained.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");
    repaired = repaired.replace(new RegExp(` when ('[A-Za-z_][A-Za-z0-9_]*) :> ${escaped}`, "g"), "");
  }
  repaired = repaired
    .replace(/ when ('[A-Za-z_][A-Za-z0-9_]*) :> (Camera|Texture|FrameGraphContext|IConnectable)\b/g, "")
    .replace(/Tensor<ResizeArray<obj option>, _I>/g, "Tensor<ResizeArray<obj option>, TensorLike<'T>>")
    .replace(/Vector<ResizeArray<obj option>, _I>/g, "Vector<ResizeArray<obj option>, TensorLike<'T>>")
    .replace(/result: 'R -> 'R when 'R :> 'I/g, "result: 'I -> 'I")
    .replace(/reference: 'T -> 'T when 'T :> 'I/g, "reference: 'I -> 'I")
    .replace(/type TensorValue =\n\s*U2<ResizeArray<float>, ResizeArray<TensorValue>>/g,
      "type [<Erase>] TensorValue =\n        | TensorScalars of ResizeArray<float>\n        | NestedTensorValues of ResizeArray<TensorValue>");

  // Global interface augmentations can otherwise resolve an unqualified base
  // name to the recursive declaration itself (for example XRFrame : XRFrame).
  const withoutSelfInheritance = [];
  let activeType;
  for (const line of repaired.split("\n")) {
    const declaration = line.match(/^\s*type (?:\[<[^>]+>\]\s*)*([A-Za-z_][A-Za-z0-9_]*)/);
    if (declaration) activeType = declaration[1];
    const inherited = line.match(/^\s*inherit ([A-Za-z_][A-Za-z0-9_]*)\s*$/);
    if (inherited?.[1] === activeType) continue;
    withoutSelfInheritance.push(line);
  }
  repaired = withoutSelfInheritance.join("\n");

  // Declaration merging can repeat the same member in a single generated
  // interface. F# requires one declaration; the JavaScript member is unchanged.
  const deduplicatedMembers = [];
  let memberKeys = new Set();
  for (const line of repaired.split("\n")) {
    if (/^\s*type /.test(line) || /^module /.test(line)) memberKeys = new Set();
    const member = line.match(/^\s*(?:\[<[^>]+>\]\s*)*abstract (.+)$/);
    if (member && memberKeys.has(member[1])) continue;
    if (member) memberKeys.add(member[1]);
    deduplicatedMembers.push(line);
  }
  repaired = deduplicatedMembers.join("\n");
  if (!/^module rec /m.test(repaired)) {
    repaired = [
      "module rec BabylonjsBindings.FullCandidate",
      "",
      "#nowarn \"3390\"",
      "",
      "open System",
      "open Fable.Core",
      "open Fable.Core.JS",
      "open Browser.Types",
      "",
      "[<Erase>] type KeyOf<'T> = Key of string",
      repaired
    ].join("\n");
  }
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
