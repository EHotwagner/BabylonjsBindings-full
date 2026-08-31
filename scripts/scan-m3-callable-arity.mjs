import { createHash } from "node:crypto";
import { readFile, writeFile } from "node:fs/promises";
import { resolve } from "node:path";
import ts from "typescript";

const root = resolve(import.meta.dirname, "..");
const lockPath = resolve(root, "declaration-lock.json");
const lockBytes = await readFile(lockPath);
const lock = JSON.parse(lockBytes);
const outputIndex = process.argv.indexOf("--out");
const outputPath = outputIndex === -1 ? null : resolve(root, process.argv[outputIndex + 1]);
const check = process.argv.includes("--check");

const digest = bytes => createHash("sha256").update(bytes).digest("hex");
const fixedCallbacks = [];
const fixedCallables = [];

for (const entry of lock.files) {
  const declarationPath = resolve(root, "node_modules", entry.path);
  const bytes = await readFile(declarationPath);
  const actualDigest = digest(bytes);
  if (actualDigest !== entry.sha256) {
    throw new Error(`locked declaration digest mismatch: ${entry.path}`);
  }

  const source = ts.createSourceFile(
    declarationPath,
    bytes.toString("utf8"),
    ts.ScriptTarget.Latest,
    true,
    ts.ScriptKind.TS,
  );

  const record = (node, collection) => {
    if (node.parameters.some(parameter => parameter.dotDotDotToken)) return;
    const location = source.getLineAndCharacterOfPosition(node.getStart(source));
    collection.push({
      arity: node.parameters.length,
      path: entry.path,
      line: location.line + 1,
      declaration: node.getText(source).replace(/\s+/g, " ").slice(0, 500),
    });
  };

  const visit = node => {
    if (ts.isFunctionTypeNode(node) || ts.isCallSignatureDeclaration(node)) {
      record(node, fixedCallbacks);
    }
    if (
      ts.isFunctionDeclaration(node) ||
      ts.isMethodSignature(node) ||
      ts.isMethodDeclaration(node) ||
      ts.isCallSignatureDeclaration(node) ||
      ts.isFunctionTypeNode(node) ||
      ts.isConstructorTypeNode(node) ||
      ts.isConstructSignatureDeclaration(node)
    ) {
      record(node, fixedCallables);
    }
    ts.forEachChild(node, visit);
  };

  visit(source);
}

const sortRows = rows => rows.sort((left, right) =>
  right.arity - left.arity || left.path.localeCompare(right.path) || left.line - right.line,
);
sortRows(fixedCallbacks);
sortRows(fixedCallables);

const proposedMaximum = 8;
const adoptedMaximum = 10;
const observedCallbackMaximum = fixedCallbacks[0].arity;
const observedCallableMaximum = fixedCallables[0].arity;
const report = {
  schemaVersion: 1,
  declarationLock: {
    path: "declaration-lock.json",
    sha256: digest(lockBytes),
    fileCount: lock.files.length,
    allFileDigestsVerified: true,
  },
  proposedPolicy: { minimumArity: 0, maximumArity: proposedMaximum },
  adoptedPolicy: { minimumArity: 0, maximumArity: adoptedMaximum },
  verdict: observedCallbackMaximum <= adoptedMaximum ? "adopted" : "insufficient",
  observed: {
    maximumFixedCallbackArity: observedCallbackMaximum,
    maximumFixedCallableDeclarationArity: observedCallableMaximum,
    callbacksExceedingProposal: fixedCallbacks.filter(row => row.arity > proposedMaximum),
    highestFixedCallableDeclarations: fixedCallables.filter(row => row.arity === observedCallableMaximum),
  },
};

const text = `${JSON.stringify(report, null, 2)}\n`;
if (outputPath) await writeFile(outputPath, text);
if (check) {
  const committed = await readFile(resolve(root, "reports/m3-callable-arity-scan.json"), "utf8");
  if (committed !== text) throw new Error("M3 callable arity scan is stale");
  process.stdout.write(`M3 callable arity scan current: ${lock.files.length} files, callback ${observedCallbackMaximum}, callable context ${observedCallableMaximum}\n`);
} else process.stdout.write(text);
if (report.verdict !== "adopted") process.exitCode = 1;
