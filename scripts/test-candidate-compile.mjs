import { createHash } from "node:crypto";
import { spawnSync } from "node:child_process";
import { readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const candidatePath = resolve(root, "generated-candidates/BabylonBindings.generated.fs");
const loadersCandidatePath = resolve(root, "generated-candidates/BabylonLoadersBindings.generated.fs");
const gltfInterfaceCandidatePath = resolve(root, "generated-candidates/BabylonGltf2Interface.generated.fs");
const enumProposalPath = resolve(root, "generated-candidates/CoreEnums.proposal.fs");
const stringEnumProposalPath = resolve(root, "generated-candidates/StringEnums.proposal.fs");
const reportPath = resolve(root, "generated-candidates/compile-diagnostics.json");
const candidate = await readFile(candidatePath);
const loadersCandidate = await readFile(loadersCandidatePath);
const gltfInterfaceCandidate = await readFile(gltfInterfaceCandidatePath);
const enumProposal = await readFile(enumProposalPath);
const stringEnumProposal = await readFile(stringEnumProposalPath);
const execution = spawnSync(
  "dotnet",
  ["build", "generated-candidates/BabylonjsBindings.FullCandidate.fsproj", "--no-restore"],
  { cwd: root, encoding: "utf8", maxBuffer: 64 * 1024 * 1024 }
);
const output = `${execution.stdout ?? ""}${execution.stderr ?? ""}`;
process.stdout.write(output);

const diagnostics = new Map();
const pattern = /^(.+\.fs)\((\d+),(\d+)\): error (FS\d+): (.+?) \[[^\]]+\]$/;
for (const line of output.split("\n")) {
  const match = line.match(pattern);
  if (!match) continue;
  const [, absolutePath, lineNumber, column, code, message] = match;
  const path = absolutePath.startsWith(`${root}/`) ? absolutePath.slice(root.length + 1) : absolutePath;
  const key = `${path}:${lineNumber}:${column}:${code}:${message}`;
  diagnostics.set(key, { path, line: Number(lineNumber), column: Number(column), code, message });
}
const countsByCode = {};
for (const diagnostic of diagnostics.values()) countsByCode[diagnostic.code] = (countsByCode[diagnostic.code] ?? 0) + 1;
const report = {
  schemaVersion: 1,
  candidateSha256: createHash("sha256").update(candidate).digest("hex"),
  loadersCandidateSha256: createHash("sha256").update(loadersCandidate).digest("hex"),
  gltfInterfaceCandidateSha256: createHash("sha256").update(gltfInterfaceCandidate).digest("hex"),
  enumProposalSha256: createHash("sha256").update(enumProposal).digest("hex"),
  stringEnumProposalSha256: createHash("sha256").update(stringEnumProposal).digest("hex"),
  status: execution.status === 0 ? "pass" : "fail",
  exitCode: execution.status,
  errorCount: diagnostics.size,
  countsByCode: Object.fromEntries(Object.entries(countsByCode).sort(([left], [right]) => left.localeCompare(right))),
  diagnostics: [...diagnostics.values()].sort((left, right) => left.line - right.line || left.column - right.column || left.code.localeCompare(right.code))
};
await writeFile(reportPath, `${JSON.stringify(report, null, 2)}\n`);
process.exitCode = execution.status ?? 1;
