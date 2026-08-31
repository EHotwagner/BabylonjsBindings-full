module BabylonjsBindings.Examples.VillageStarter

open System
open Browser.Dom
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop

// The example deliberately binds only the runtime members used by the tutorial.
// The exact module paths are part of the maintained Babylon.js 9.19.0 closure.
[<AllowNullLiteral>]
type Engine = interface end

[<AllowNullLiteral>]
type Scene = interface end

[<AllowNullLiteral>]
type Quaternion =
    abstract clone: unit -> Quaternion

[<AllowNullLiteral>]
type Vector3 =
    abstract x: float with get, set
    abstract y: float with get, set
    abstract z: float with get, set

[<AllowNullLiteral>]
type Material =
    abstract alpha: float with get, set

[<AllowNullLiteral>]
type Animation = interface end

[<AllowNullLiteral>]
type Mesh =
    abstract name: string with get, set
    abstract position: Vector3 with get, set
    abstract rotation: Vector3 with get, set
    abstract rotationQuaternion: Quaternion option with get, set
    abstract scaling: Vector3 with get, set
    abstract material: Material option with get, set
    abstract animations: ResizeArray<Animation> with get, set

[<AllowNullLiteral>]
type Skeleton = interface end

[<AllowNullLiteral>]
type ImportResult =
    abstract meshes: ResizeArray<Mesh> with get
    abstract skeletons: ResizeArray<Skeleton> with get

[<AllowNullLiteral>]
type Vector3Constructor =
    [<EmitConstructor>]
    abstract Create: x: float * y: float * z: float -> Vector3

[<AllowNullLiteral>]
type EngineConstructor =
    [<EmitConstructor>]
    abstract Create: canvas: HTMLCanvasElement * antialias: bool -> Engine

[<AllowNullLiteral>]
type SceneConstructor =
    [<EmitConstructor>]
    abstract Create: engine: Engine -> Scene

[<AllowNullLiteral>]
type ArcRotateCameraConstructor =
    [<EmitConstructor>]
    abstract Create: name: string * alpha: float * beta: float * radius: float * target: Vector3 * scene: Scene -> obj

[<AllowNullLiteral>]
type HemisphericLightConstructor =
    [<EmitConstructor>]
    abstract Create: name: string * direction: Vector3 * scene: Scene -> obj

[<AllowNullLiteral>]
type StandardMaterialConstructor =
    [<EmitConstructor>]
    abstract Create: name: string * scene: Scene -> Material

[<AllowNullLiteral>]
type AnimationConstructor =
    [<EmitConstructor>]
    abstract Create: name: string * targetProperty: string * framesPerSecond: float * dataType: float * loopMode: float -> Animation

[<Import("Vector3", "@babylonjs/core/Maths/math.vector.js")>]
let Vector3: Vector3Constructor = jsNative

[<Import("Engine", "@babylonjs/core/Engines/engine.js")>]
let Engine: EngineConstructor = jsNative

[<Import("Scene", "@babylonjs/core/scene.js")>]
let Scene: SceneConstructor = jsNative

[<Import("ArcRotateCamera", "@babylonjs/core/Cameras/arcRotateCamera.js")>]
let ArcRotateCamera: ArcRotateCameraConstructor = jsNative

[<Import("HemisphericLight", "@babylonjs/core/Lights/hemisphericLight.js")>]
let HemisphericLight: HemisphericLightConstructor = jsNative

[<Import("StandardMaterial", "@babylonjs/core/Materials/standardMaterial.js")>]
let StandardMaterial: StandardMaterialConstructor = jsNative

[<Import("Animation", "@babylonjs/core/Animations/animation.js")>]
let Animation: AnimationConstructor = jsNative

[<Import("CreateBox", "@babylonjs/core/Meshes/Builders/boxBuilder.js")>]
let createBox (name: string) (options: obj) (scene: Scene): Mesh = jsNative

[<Import("ImportMeshAsync", "@babylonjs/core/Loading/sceneLoader.js")>]
let importMeshAsync (source: string) (scene: Scene): JS.Promise<ImportResult> = jsNative

[<ImportAll("@babylonjs/loaders/glTF/index.js")>]
let private registerGltfLoader: obj = jsNative

[<ImportAll("@babylonjs/core/Loading/Plugins/babylonFileLoader.js")>]
let private registerBabylonLoader: obj = jsNative

[<ImportAll("@babylonjs/core/Animations/animatable.js")>]
let private registerAnimatable: obj = jsNative

[<Emit("$0.attachControl($1, true)")>]
let attachCamera (camera: obj) (canvas: HTMLCanvasElement): unit = jsNative

[<Emit("$0.runRenderLoop($1)")>]
let runRenderLoop (engine: Engine) (render: unit -> unit): unit = jsNative

[<Emit("$0.resize()")>]
let resize (engine: Engine): unit = jsNative

[<Emit("$0.render()")>]
let render (scene: Scene): unit = jsNative

[<Emit("$0.getMeshByName($1)")>]
let getMeshByName (scene: Scene) (name: string): Mesh = jsNative

[<Emit("$0.beginAnimation($1, $2, $3, $4, $5)")>]
let beginAnimation (scene: Scene) (target: obj) (fromFrame: float) (toFrame: float) (loop: bool) (speedRatio: float): unit = jsNative

[<Emit("$0.setKeys($1)")>]
let setAnimationKeys (animation: Animation) (keys: ResizeArray<obj>): unit = jsNative

[<Emit("$0.onBeforeRenderObservable.add($1)")>]
let beforeRender (scene: Scene) (callback: unit -> unit): unit = jsNative

[<Emit("$0.getChildren()")>]
let getChildren (mesh: Mesh): ResizeArray<Mesh> = jsNative

[<Emit("$0.intersectsMesh($1)")>]
let intersectsMesh (mesh: Mesh) (other: Mesh): bool = jsNative

[<Emit("$0.movePOV($1, $2, $3)")>]
let movePov (mesh: Mesh) (right: float) (up: float) (forward: float): unit = jsNative

[<Emit("$0.rotate($1, $2, 0)")>]
let rotateLocal (mesh: Mesh) (axis: Vector3) (angle: float): unit = jsNative

[<Emit("$0.rotationQuaternion.clone()")>]
let cloneRotation (mesh: Mesh): Quaternion = jsNative

[<Emit("$0.rotationQuaternion = $1.clone()")>]
let restoreRotation (mesh: Mesh) (rotation: Quaternion): unit = jsNative

[<Emit("$0.then($1)")>]
let onResolved (promise: JS.Promise<'T>) (callback: 'T -> unit): unit = jsNative

[<Emit("$0.catch($1)")>]
let onRejected (promise: JS.Promise<'T>) (callback: obj -> unit): unit = jsNative

[<Emit("$0.__villageScene = $1")>]
let exposeScene (window: Window) (scene: Scene): unit = jsNative

let private canvas = document.getElementById("renderCanvas") :?> HTMLCanvasElement
let private status = document.getElementById("status")
let private _registeredRuntime = registerGltfLoader, registerBabylonLoader, registerAnimatable
let private engine = Engine.Create(canvas, true)
let private scene = Scene.Create(engine)
let private yAxis = Vector3.Create(0.0, 1.0, 0.0)

let private setStatus state message =
    document.body.setAttribute("data-scene-status", state)
    status.textContent <- message

let private failAsset name (error: obj) =
    console.error [| box (sprintf "Village asset '%s' failed" name); error |]
    setStatus "failed" (sprintf "Could not load %s. See the browser console." name)

let camera = ArcRotateCamera.Create("camera", -Math.PI / 2.2, Math.PI / 2.2, 15.0, Vector3.Create(0.0, 0.0, 0.0), scene)
attachCamera camera canvas
HemisphericLight.Create("light", Vector3.Create(1.0, 1.0, 0.0), scene) |> ignore

let wireMaterial = StandardMaterial.Create("wireMat", scene)
wireMaterial.alpha <- 0.0
let hitBox = createBox "carbox" (createObj [ "width" ==> 0.5; "height" ==> 0.6; "depth" ==> 4.5 ]) scene
hitBox.material <- Some wireMaterial
hitBox.position <- Vector3.Create(3.1, 0.3, -5.0)

let mutable private villageReady = false
let mutable private carReady = false
let mutable private dudeReady = false
let mutable private carMesh: Mesh option = None

let private updateReadyState () =
    if villageReady && carReady && dudeReady then
        setStatus "ready" "Village ready — drag to orbit, scroll to zoom"

let villagePromise = importMeshAsync "https://assets.babylonjs.com/meshes/village.glb" scene
onResolved villagePromise (fun _ -> villageReady <- true; updateReadyState ())
onRejected villagePromise (failAsset "village")

let carPromise = importMeshAsync "https://assets.babylonjs.com/meshes/car.glb" scene
onResolved carPromise (fun result ->
    let car = result.meshes |> Seq.find (fun mesh -> mesh.name = "car")
    carMesh <- Some car
    car.rotation <- Vector3.Create(Math.PI / 2.0, 0.0, -Math.PI / 2.0)
    car.position <- Vector3.Create(-3.0, 0.16, 8.0)

    let carAnimation = Animation.Create("carAnimation", "position.z", 30.0, 0.0, 1.0)
    setAnimationKeys carAnimation (ResizeArray [ createObj [ "frame" ==> 0; "value" ==> 8.0 ]; createObj [ "frame" ==> 150; "value" ==> -7.0 ]; createObj [ "frame" ==> 200; "value" ==> -7.0 ] ])
    car.animations <- ResizeArray [ carAnimation ]
    beginAnimation scene car 0.0 200.0 true 1.0

    for wheelName in [ "wheelRB"; "wheelRF"; "wheelLB"; "wheelLF" ] do
        let wheel = getMeshByName scene wheelName
        if not (isNull (box wheel)) then beginAnimation scene wheel 0.0 30.0 true 1.0

    carReady <- true
    updateReadyState ())
onRejected carPromise (failAsset "car")

let dudePromise = importMeshAsync "https://playground.babylonjs.com/scenes/Dude/Dude.babylon" scene
onResolved dudePromise (fun result ->
    let dude = result.meshes[0]
    dude.name <- "DudeRoot"
    dude.scaling <- Vector3.Create(0.008, 0.008, 0.008)
    dude.position <- Vector3.Create(1.5, 0.0, -6.9)
    rotateLocal dude yAxis (-Math.PI / 2.0)
    let startRotation = cloneRotation dude

    if result.skeletons.Count > 0 then beginAnimation scene result.skeletons[0] 0.0 100.0 true 1.0

    let mutable distance = 0.0
    let mutable leg = 0
    let track = [| (Math.PI, 2.5); (0.0, 5.0) |]
    beforeRender scene (fun () ->
        let carBlocksCrossing =
            match carMesh with
            | Some car when getChildren dude |> Seq.length > 1 ->
                let body = (getChildren dude)[1]
                not (intersectsMesh body hitBox) && intersectsMesh car hitBox
            | _ -> false

        if not carBlocksCrossing then
            movePov dude 0.0 0.0 0.015
            distance <- distance + 0.015
            let turn, limit = track[leg]
            if distance > limit then
                rotateLocal dude yAxis turn
                leg <- (leg + 1) % track.Length
                if leg = 0 then
                    distance <- 0.0
                    dude.position <- Vector3.Create(1.5, 0.0, -6.9)
                    restoreRotation dude startRotation)

    dudeReady <- true
    updateReadyState ())
onRejected dudePromise (failAsset "Dude")

exposeScene window scene
runRenderLoop engine (fun () -> render scene)
window.addEventListener("resize", fun _ -> resize engine)
setStatus "loading" "Loading village, car, and walker…"
