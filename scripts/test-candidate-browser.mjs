import { createHash } from "node:crypto";
import { spawn } from "node:child_process";
import { createServer } from "node:http";
import { readFile, stat, writeFile } from "node:fs/promises";
import { extname, resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const pagePath = "generated-candidates/runtime/browser/index.html";
const evidencePath = resolve(root, "generated-candidates/runtime/browser-evidence.json");
const sha256 = value => createHash("sha256").update(value).digest("hex");
const mimeTypes = new Map([[".html", "text/html"], [".js", "text/javascript"], [".json", "application/json"]]);
const requestFailures = [];
const run = (command, args) => new Promise((accept, reject) => {
  const child = spawn(command, args, { cwd: root });
  let stdout = "";
  let stderr = "";
  child.stdout.on("data", chunk => { stdout += chunk; });
  child.stderr.on("data", chunk => { stderr += chunk; });
  child.on("error", reject);
  child.on("close", code => code === 0 ? accept({ stdout, stderr }) : reject(new Error(`${command} exited ${code}\n${stdout}\n${stderr}`)));
});

const server = createServer(async (request, response) => {
  try {
    const requestPath = decodeURIComponent(new URL(request.url, "http://127.0.0.1").pathname);
    const file = resolve(root, `.${requestPath}`);
    if (file !== root && !file.startsWith(`${root}/`)) throw new Error("path escapes repository root");
    if (!(await stat(file)).isFile()) throw new Error("not a file");
    response.writeHead(200, { "content-type": mimeTypes.get(extname(file)) ?? "application/octet-stream" });
    response.end(await readFile(file));
  } catch (error) {
    requestFailures.push({ url: request.url, message: error instanceof Error ? error.message : String(error) });
    response.writeHead(404);
    response.end("not found");
  }
});

await new Promise((accept, reject) => {
  server.once("error", reject);
  server.listen(0, "127.0.0.1", accept);
});
try {
  const address = server.address();
  const url = `http://127.0.0.1:${address.port}/${pagePath}`;
  const version = (await run("chromium", ["--version"])).stdout.trim();
  const expected = "Babylon full candidate browser smoke passed";
  let browser;
  for (let attempt = 1; attempt <= 2; attempt += 1) {
    browser = await run("chromium", [
      "--headless", "--no-sandbox", "--disable-gpu", "--virtual-time-budget=8000", "--dump-dom", url
    ]);
    const renderedOutput = browser.stdout.match(/<output>([^<]*)<\/output>/)?.[1];
    if (renderedOutput === expected) break;
    if (attempt === 2) {
      throw new Error(`Chromium did not report success after ${attempt} attempts\nHTTP failures: ${JSON.stringify(requestFailures)}\n${browser.stdout}\n${browser.stderr}`);
    }
  }
  const page = await readFile(resolve(root, pagePath));
  const program = await readFile(resolve(root, "generated-candidates/runtime/dist/Program.js"));
  const evidence = {
    schemaVersion: 1,
    target: "generated-candidate",
    browser: version,
    page: { path: pagePath, sha256: sha256(page) },
    emittedProgramSha256: sha256(program),
    status: "pass"
  };
  await writeFile(evidencePath, `${JSON.stringify(evidence, null, 2)}\n`);
  console.log(`${expected} (${version})`);
} finally {
  await new Promise(accept => server.close(accept));
}
