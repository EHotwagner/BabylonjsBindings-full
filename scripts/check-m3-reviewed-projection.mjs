import { createHash } from "node:crypto";
import { readFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const source = await readFile(resolve(root, "src/BabylonjsBindings/M3HigherOrderRuntimeApis.fs"), "utf8");
const proposal = await readFile(resolve(root, "generated-candidates/M3HigherOrderRuntimeApis.proposal.fs"), "utf8");
const coverage = JSON.parse(await readFile(resolve(root, "src/BabylonjsBindings/m3-higher-order-runtime-coverage-manifest.json"), "utf8"));
const analysis = JSON.parse(await readFile(resolve(root, "analysis/m3-higher-order-runtime-manifest.json"), "utf8"));
const expectedProposal = source.replace("namespace BabylonjsBindings", "// REVIEW-ONLY M3 HIGHER-ORDER RUNTIME API PROPOSAL — maintained source requires explicit review");
if (proposal !== expectedProposal) throw new Error("M3 review-only proposal is stale relative to maintained source");
const hash = createHash("sha256").update(proposal).digest("hex");
if (coverage.proposalSha256 !== hash) throw new Error(`M3 proposal digest mismatch: ${hash}`);
if (coverage.exports.length !== 8 || new Set(coverage.exports.map(item => item.name)).size !== 8 || analysis.exportsClosed !== 8) throw new Error("M3 manifest must close exactly eight unique exports");
if (analysis.arityPolicy.adopted.minimum !== 0 || analysis.arityPolicy.adopted.maximum !== 10) throw new Error("M3 arity policy drifted from 0-10");
for (const forbidden of ["ParamArray<obj>", "U2<Base,Mixin>", "unconstrained obj result"]) {
  if (!analysis.rejected.includes(forbidden)) throw new Error(`missing rejected shortcut ${forbidden}`);
}
console.log(`M3 reviewed projection current: 8 exports, sha256 ${hash}`);
