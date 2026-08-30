open Qualification.Babylon
open BabylonjsBindings.Enums
let shaderLanguage: ShaderLanguage = ShaderLanguage.``WGSL``
let loaderState: GLTFLoaderState = GLTFLoaderState.``READY``
let engine = nullEngine ()
let scene = scene engine
let _ = box "compile-smoke" scene
initialiseLoader ()
if int shaderLanguage <> 1 || int loaderState <> 1 then failwith "maintained enum values drifted"
printfn "curated Babylon binding compile smoke passed"
