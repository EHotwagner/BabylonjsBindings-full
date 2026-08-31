import { readFile } from "node:fs/promises";
import { resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const dist = process.argv[2] ?? "runtime/full-dist";
const emitted = await readFile(resolve(root, dist, "Program.js"), "utf8");
if (!emitted.includes('from "@babylonjs/loaders/glTF/index.js"')) throw new Error("full consumer lacks the exact glTF namespace import");
if (!emitted.includes("value.set(...[1, 2])")) throw new Error("Vector2 fixed coordinates did not emit as a spread");
if (!emitted.includes("value.set(...[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16])")) throw new Error("Matrix fixed coordinates did not emit as a 16-value spread");
for (const item of ["GLTF1", "GLTF2"]) if (!emitted.includes(item)) throw new Error(`missing ${item} namespace reference`);
console.log("M6 emitted imports/calls passed: exact glTF index plus 2/16 coordinate spreads");
