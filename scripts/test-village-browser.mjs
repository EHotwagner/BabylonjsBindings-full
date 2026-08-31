import assert from "node:assert/strict";
import { spawn, spawnSync } from "node:child_process";
import { mkdir, mkdtemp, readFile, rm, stat, writeFile } from "node:fs/promises";
import { createServer } from "node:http";
import { extname, resolve } from "node:path";

const root = resolve(import.meta.dirname, "..");
const headed = process.argv.includes("--headed");
const wait = milliseconds => new Promise(accept => setTimeout(accept, milliseconds));
const mime = new Map([[".html", "text/html"], [".js", "text/javascript"], [".json", "application/json"], [".wasm", "application/wasm"]]);

const appServer = createServer(async (request, response) => {
  try {
    const requestedPath = decodeURIComponent(new URL(request.url, "http://127.0.0.1").pathname);
    const pathname = requestedPath.endsWith("/") ? `${requestedPath}index.html` : requestedPath;
    const file = resolve(root, `.${pathname}`);
    if (file !== root && !file.startsWith(`${root}/`)) throw new Error("path escape");
    if (!(await stat(file)).isFile()) throw new Error("not a file");
    response.writeHead(200, { "content-type": mime.get(extname(file)) ?? "application/octet-stream" });
    response.end(await readFile(file));
  } catch {
    response.writeHead(404);
    response.end("not found");
  }
});

const listen = server => new Promise((accept, reject) => {
  server.once("error", reject);
  server.listen(0, "127.0.0.1", accept);
});
const close = server => new Promise(accept => server.close(accept));

const reservePort = async () => {
  const server = createServer();
  await listen(server);
  const port = server.address().port;
  await close(server);
  return port;
};

const cdp = (webSocketDebuggerUrl, method, params = {}) => new Promise((accept, reject) => {
  const socket = new WebSocket(webSocketDebuggerUrl);
  const id = 1;
  socket.addEventListener("open", () => socket.send(JSON.stringify({ id, method, params })));
  socket.addEventListener("message", event => {
    const message = JSON.parse(event.data);
    if (message.id !== id) return;
    socket.close();
    if (message.error) reject(new Error(`${method}: ${message.error.message}`));
    else accept(message.result);
  });
  socket.addEventListener("error", reject);
});

await mkdir(resolve(root, ".tmp"), { recursive: true });
await mkdir(resolve(root, "reports"), { recursive: true });
const profile = await mkdtemp(resolve(root, ".tmp/village-chromium-"));
const debugPort = await reservePort();
await listen(appServer);
const appPort = appServer.address().port;
const url = `http://127.0.0.1:${appPort}/examples/VillageStarter/`;
const args = [
  ...(headed ? [] : ["--headless"]),
  "--no-sandbox",
  "--remote-allow-origins=*",
  `--remote-debugging-port=${debugPort}`,
  `--user-data-dir=${profile}`,
  "--window-size=1280,800",
  "--new-window",
  url
];
const chromium = spawn("chromium", args, { cwd: root, stdio: ["ignore", "pipe", "pipe"] });
const chromiumClosed = new Promise(accept => chromium.once("close", accept));
let browserOutput = "";
chromium.stdout.on("data", chunk => browserOutput += chunk);
chromium.stderr.on("data", chunk => browserOutput += chunk);

try {
  let page;
  const deadline = Date.now() + 60000;
  while (Date.now() < deadline && !page) {
    try {
      const targets = await (await fetch(`http://127.0.0.1:${debugPort}/json/list`)).json();
      page = targets.find(target => target.type === "page" && target.url === url);
    } catch { /* Chromium is still starting. */ }
    if (!page) await wait(200);
  }
  assert.ok(page, `headed=${headed}: Chromium did not open ${url}\n${browserOutput}`);

  let state;
  while (Date.now() < deadline) {
    const evaluated = await cdp(page.webSocketDebuggerUrl, "Runtime.evaluate", {
      expression: `JSON.stringify((() => {
        const scene = window.__villageScene;
        const hitBox = scene?.getMeshByName("carbox");
        return {
          status: document.body.dataset.sceneStatus,
          message: document.querySelector("#status")?.textContent,
          canvas: { width: document.querySelector("#renderCanvas")?.width, height: document.querySelector("#renderCanvas")?.height },
          meshCount: scene?.meshes.length ?? 0,
          hasVillage: Boolean(scene?.getMeshByName("ground") || scene?.getMeshByName("village")),
          hasCar: Boolean(scene?.getMeshByName("car")),
          hasDude: Boolean(scene?.getMeshByName("DudeRoot")),
          hasHitBox: Boolean(hitBox),
          hitBoxAlpha: hitBox?.material?.alpha,
          camera: scene?.activeCamera?.getClassName(),
          activeAnimations: scene?.animatables?.length ?? scene?._activeAnimatables?.length ?? 0,
          activeAnimationTargets: (scene?.animatables ?? scene?._activeAnimatables ?? []).map(animation => animation.target?.name ?? animation.target?.id ?? "anonymous"),
          carAnimations: scene?.getMeshByName("car")?.animations?.length ?? 0,
          wheelCount: ["wheelRB", "wheelRF", "wheelLB", "wheelLF"].filter(name => scene?.getMeshByName(name)).length,
          skeletonCount: scene?.skeletons?.length ?? 0
        };
      })())`,
      returnByValue: true
    });
    state = JSON.parse(evaluated.result.value);
    if (state.status === "ready" || state.status === "failed") break;
    await wait(250);
  }

  assert.equal(state.status, "ready", `${JSON.stringify(state)}\n${browserOutput}`);
  assert.ok(state.canvas.width >= 1000 && state.canvas.height >= 600, "render canvas has no real viewport");
  assert.ok(state.meshCount >= 20, `expected loaded village scene, got ${state.meshCount} meshes`);
  assert.equal(state.hasVillage, true);
  assert.equal(state.hasCar, true);
  assert.equal(state.hasDude, true);
  assert.equal(state.hasHitBox, true);
  assert.equal(state.hitBoxAlpha, 0);
  assert.equal(state.camera, "ArcRotateCamera");
  assert.equal(state.carAnimations, 1, `car animation was not attached: ${JSON.stringify(state)}`);
  assert.ok(state.skeletonCount >= 1, `Dude skeleton was not loaded: ${JSON.stringify(state)}`);
  assert.equal(state.wheelCount, 4, `car wheel meshes were not loaded: ${JSON.stringify(state)}`);
  assert.ok(state.activeAnimations >= 2, `expected durable car and skeleton animations: ${JSON.stringify(state)}`);
  assert.ok(state.activeAnimationTargets.includes("car"), `missing active car animation: ${JSON.stringify(state)}`);

  const screenshot = await cdp(page.webSocketDebuggerUrl, "Page.captureScreenshot", { format: "png" });
  await writeFile(resolve(root, "reports/village-starter.png"), Buffer.from(screenshot.data, "base64"));
  const report = {
    schemaVersion: 1,
    result: "pass",
    mode: headed ? "headed" : "headless",
    chromium: spawnSync("chromium", ["--version"], { encoding: "utf8" }).stdout.trim(),
    url,
    scene: state,
    screenshot: "reports/village-starter.png"
  };
  await writeFile(resolve(root, "reports/village-starter-browser.json"), `${JSON.stringify(report, null, 2)}\n`);
  console.log(`Village starter passed in ${report.mode} ${report.chromium}: ${state.meshCount} meshes, ${state.activeAnimations} active animations`);
  if (headed) await wait(2000);
} finally {
  if (chromium.exitCode === null) chromium.kill("SIGTERM");
  await Promise.race([chromiumClosed, wait(5000)]);
  await close(appServer);
  await rm(profile, { recursive: true, force: true, maxRetries: 3, retryDelay: 100 });
}
