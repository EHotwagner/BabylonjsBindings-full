open Qualification.Babylon
open BabylonjsBindings.Enums
open BabylonjsBindings.StringEnums
open BabylonjsBindings.ObjectTypes
let shaderLanguage: ShaderLanguage = ShaderLanguage.``WGSL``
let loaderState: GLTFLoaderState = GLTFLoaderState.``READY``
let fftSize: AudioAnalyzerFFTSizeType = AudioAnalyzerFFTSizeType.``N32768``
let powerPreference: PowerPreference = PowerPreference.``HighPerformance``
let sizeLike: SizeLike = Unchecked.defaultof<SizeLike>
let engine = nullEngine ()
let scene = scene engine
let _ = box "compile-smoke" scene
initialiseLoader ()
if int shaderLanguage <> 1 || int loaderState <> 1 || int fftSize <> 32768 then failwith "maintained enum values drifted"
powerPreference |> ignore
sizeLike |> ignore
printfn "curated Babylon binding compile smoke passed"
