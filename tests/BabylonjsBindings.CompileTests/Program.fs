open Qualification.Babylon
open BabylonjsBindings.Enums
open BabylonjsBindings.StringEnums
open BabylonjsBindings.ObjectTypes
open BabylonjsBindings.SimpleInterfaces
let shaderLanguage: ShaderLanguage = ShaderLanguage.``WGSL``
let loaderState: GLTFLoaderState = GLTFLoaderState.``READY``
let fftSize: AudioAnalyzerFFTSizeType = AudioAnalyzerFFTSizeType.``N32768``
let powerPreference: PowerPreference = PowerPreference.``HighPerformance``
let sizeLike: SizeLike = Unchecked.defaultof<SizeLike>
let textureHandle: BabylonjsBindings.TypeAliases.FrameGraphTextureHandle = 1.0
let stageAction: BabylonjsBindings.TypeAliases.SimpleStageAction = Unchecked.defaultof<BabylonjsBindings.TypeAliases.SimpleStageAction>
let easing: IEasingFunction = Unchecked.defaultof<IEasingFunction>
let engine = nullEngine ()
let scene = scene engine
let _ = box "compile-smoke" scene
initialiseLoader ()
if int shaderLanguage <> 1 || int loaderState <> 1 || int fftSize <> 32768 then failwith "maintained enum values drifted"
powerPreference |> ignore
sizeLike |> ignore
textureHandle |> ignore
stageAction |> ignore
easing |> ignore
printfn "curated Babylon binding compile smoke passed"
