module BabylonjsBindings.CrossRuntimeTests

open BabylonjsBindings.Enums

let fixture =
    sprintf
        "{\"shaderLanguage\":%d,\"loaderReady\":%d,\"fft32768\":%d,\"sceneLoaderError\":%d}"
        (int ShaderLanguage.``WGSL``)
        (int GLTFLoaderState.``READY``)
        (int AudioAnalyzerFFTSizeType.``N32768``)
        (int ErrorCodesType.``SceneLoaderError``)

printfn "FIXTURE:%s" fixture
