open Qualification.Babylon
open BabylonjsBindings.Enums
open BabylonjsBindings.StringEnums
open BabylonjsBindings.ObjectTypes
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.SimpleClasses
let shaderLanguage: ShaderLanguage = ShaderLanguage.``WGSL``
let loaderState: GLTFLoaderState = GLTFLoaderState.``READY``
let fftSize: AudioAnalyzerFFTSizeType = AudioAnalyzerFFTSizeType.``N32768``
let powerPreference: PowerPreference = PowerPreference.``HighPerformance``
let arcRotateInteraction: ArcRotateInteraction = ArcRotateInteraction.``Pan``
let sizeLike: SizeLike = Unchecked.defaultof<SizeLike>
let hotSpotQuery: HotSpotQuery = Unchecked.defaultof<HotSpotQuery>
let textureHandle: BabylonjsBindings.TypeAliases.FrameGraphTextureHandle = 1.0
let stageAction: BabylonjsBindings.TypeAliases.SimpleStageAction = Unchecked.defaultof<BabylonjsBindings.TypeAliases.SimpleStageAction>
let nullableLabel: BabylonjsBindings.TypeAliases.Nullable<string> = None
let easing: IEasingFunction = Unchecked.defaultof<IEasingFunction>
let inspectableOptions: IInspectableOptions = Unchecked.defaultof<IInspectableOptions>
let bitArray: BitArray = Unchecked.defaultof<BitArray>
let bitArrayFactory: BitArrayStatic = BitArray
let animationMaskFactory: AnimationGroupMaskStatic = AnimationGroupMask
let alphaStateFactory: AlphaStateStatic = AlphaState
let strideFunction = BabylonjsBindings.SimpleFunctions.``VertexBufferDeduceStride``
let epsilon = BabylonjsBindings.SimpleVariables.``Epsilon``
let shaderDescriptor = BabylonjsBindings.SimpleVariables.``clearQuadVertexShaderWGSL``
let padNumber = BabylonjsBindings.SimpleVariables.``PadNumber``
let testBase64DataUrl = BabylonjsBindings.SimpleVariables.``TestBase64DataUrl``
let engine = nullEngine ()
let scene = scene engine
let _ = box "compile-smoke" scene
initialiseLoader ()
if int shaderLanguage <> 1 || int loaderState <> 1 || int fftSize <> 32768 then failwith "maintained enum values drifted"
powerPreference |> ignore
arcRotateInteraction |> ignore
sizeLike |> ignore
hotSpotQuery |> ignore
textureHandle |> ignore
stageAction |> ignore
nullableLabel |> ignore
easing |> ignore
inspectableOptions |> ignore
bitArray |> ignore
bitArrayFactory |> ignore
animationMaskFactory |> ignore
alphaStateFactory |> ignore
strideFunction |> ignore
epsilon |> ignore
shaderDescriptor |> ignore
padNumber |> ignore
testBase64DataUrl |> ignore
printfn "curated Babylon binding compile smoke passed"
