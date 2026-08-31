# Village Starter

This Fable example recreates the Babylon.js Getting Started Chapter 4 village
collision scene. It includes the imported village, animated car and wheels,
walking Dude skeleton, invisible danger box, collision-aware movement, and an
interactive arc-rotate camera.

Build the F# source and run its browser proof with:

```bash
npm run build:village
npm run test:village-browser
```

To watch the browser proof in a real Chromium window:

```bash
npm run test:village-browser -- --headed
```

For interactive use, serve the repository root over HTTP and open
`/examples/VillageStarter/`. The page relies on the repository's exact npm
lock and import map; opening the HTML directly from disk will not resolve its
ES modules.

Source tutorial: <https://doc.babylonjs.com/features/introductionToFeatures/chap4/>
