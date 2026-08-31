import { readFile } from "node:fs/promises";
import { resolve } from "node:path";

const symbolPattern = /BabylonjsBindings\.(?:TypeAliases|SimpleInterfaces|SimpleClasses)\.[A-Za-z_][A-Za-z0-9_]*/g;

export const loadPromotionSymbolIndex = async (root, manifestPaths) => {
  const index = new Map();
  for (const path of manifestPaths) {
    const manifest = JSON.parse(await readFile(resolve(root, path), "utf8"));
    for (const entry of [...(manifest.exports ?? []), ...(manifest.supportTypes ?? [])]) {
      const canonical = entry.fsharpSymbol;
      if (!canonical) continue;
      for (const symbol of [canonical, entry.deepImmutableSymbol, entry.partialSymbol, entry.requiredNonNullableSymbol, entry.requiredSymbol].filter(Boolean)) {
        index.set(symbol, canonical);
      }
    }
  }
  return index;
};

export const referencedPromotionSymbols = (value, symbolIndex, ownSymbol, additionalSymbols = []) => {
  const dependencies = new Set(additionalSymbols.filter(Boolean));
  const text = JSON.stringify(value);
  for (const match of text.matchAll(symbolPattern)) {
    const canonical = symbolIndex.get(match[0]);
    if (canonical) dependencies.add(canonical);
  }
  dependencies.delete(ownSymbol);
  return [...dependencies].sort();
};
