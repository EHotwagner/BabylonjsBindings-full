import { spawn } from "node:child_process";
import { createServer } from "node:http";
import { readFile, stat } from "node:fs/promises";
import { extname, resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const run = (command, args) => new Promise((accept, reject) => {
  const child = spawn(command, args, { cwd: root }); let stdout = ""; let stderr = "";
  child.stdout.on("data", chunk => stdout += chunk); child.stderr.on("data", chunk => stderr += chunk);
  child.on("error", reject); child.on("close", code => code === 0 ? accept({ stdout, stderr }) : reject(new Error(`${command} exited ${code}\n${stdout}\n${stderr}`)));
});
const mime = new Map([[".html", "text/html"], [".js", "text/javascript"]]);
const server = createServer(async (request, response) => {
  try {
    const pathname = decodeURIComponent(new URL(request.url, "http://127.0.0.1").pathname);
    const file = resolve(root, `.${pathname}`);
    if (file !== root && !file.startsWith(`${root}/`)) throw new Error("path escape");
    if (!(await stat(file)).isFile()) throw new Error("not file");
    response.writeHead(200, { "content-type": mime.get(extname(file)) ?? "application/octet-stream" }); response.end(await readFile(file));
  } catch { response.writeHead(404); response.end("not found"); }
});
await new Promise((accept, reject) => { server.once("error", reject); server.listen(0, "127.0.0.1", accept); });
try {
  const url = `http://127.0.0.1:${server.address().port}/runtime/browser/m3-higher-order.html`;
  const version = (await run("chromium", ["--version"])).stdout.trim();
  const browser = await run("chromium", ["--headless", "--no-sandbox", "--disable-gpu", "--virtual-time-budget=8000", "--dump-dom", url]);
  if (!browser.stdout.includes("<output>M3 higher-order runtime smoke passed</output>")) throw new Error(`Chromium M3 smoke failed\n${browser.stdout}\n${browser.stderr}`);
  console.log(`M3 Chromium smoke passed (${version})`);
} finally { await new Promise(accept => server.close(accept)); }
