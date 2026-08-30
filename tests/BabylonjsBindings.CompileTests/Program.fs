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
let computePipelineContext: IComputePipelineContext = Unchecked.defaultof<IComputePipelineContext>
let mipmap: IMipmap = Unchecked.defaultof<IMipmap>
let simplificationInterface: ISimplificationSettings = Unchecked.defaultof<ISimplificationSettings>
let decodedData: IDecodedData = Unchecked.defaultof<IDecodedData>
let bitArray: BitArray = Unchecked.defaultof<BitArray>
let bitArrayFactory: BitArrayStatic = BitArray
let animationMaskFactory: AnimationGroupMaskStatic = AnimationGroupMask
let alphaStateFactory: AlphaStateStatic = AlphaState
let richTypeFactory: RichTypeStatic = RichType
let lazyFactoryType: LazyStatic = Lazy
let smartArrayFactory: SmartArrayStatic = SmartArray
let smartArrayNoDuplicateFactory: SmartArrayNoDuplicateStatic = SmartArrayNoDuplicate
let animationEventFactory: AnimationEventStatic = AnimationEvent
let factorGradientFactory: FactorGradientStatic = FactorGradient
let performanceConfiguratorFactory: PerformanceConfiguratorStatic = PerformanceConfigurator
let simplificationSettingsFactory: SimplificationSettingsStatic = SimplificationSettings
let stencilStateComposerFactory: StencilStateComposerStatic = StencilStateComposer
let webGLHardwareTextureFactory: WebGLHardwareTextureStatic = WebGLHardwareTexture
let constantsFactory: ConstantsStatic = Constants
let easingFunctionFactory: EasingFunctionStatic = EasingFunction
let backEaseFactory: BackEaseStatic = BackEase
let bezierCurveEaseFactory: BezierCurveEaseStatic = BezierCurveEase
let bounceEaseFactory: BounceEaseStatic = BounceEase
let circleEaseFactory: CircleEaseStatic = CircleEase
let cubicEaseFactory: CubicEaseStatic = CubicEase
let elasticEaseFactory: ElasticEaseStatic = ElasticEase
let exponentialEaseFactory: ExponentialEaseStatic = ExponentialEase
let powerEaseFactory: PowerEaseStatic = PowerEase
let quadraticEaseFactory: QuadraticEaseStatic = QuadraticEase
let quarticEaseFactory: QuarticEaseStatic = QuarticEase
let quinticEaseFactory: QuinticEaseStatic = QuinticEase
let sineEaseFactory: SineEaseStatic = SineEase
let stencilStateFactory: StencilStateStatic = StencilState
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
computePipelineContext |> ignore
mipmap |> ignore
simplificationInterface |> ignore
decodedData |> ignore
bitArray |> ignore
bitArrayFactory |> ignore
animationMaskFactory |> ignore
alphaStateFactory |> ignore
richTypeFactory |> ignore
lazyFactoryType |> ignore
smartArrayFactory |> ignore
smartArrayNoDuplicateFactory |> ignore
animationEventFactory |> ignore
factorGradientFactory |> ignore
performanceConfiguratorFactory |> ignore
simplificationSettingsFactory |> ignore
stencilStateComposerFactory |> ignore
webGLHardwareTextureFactory |> ignore
constantsFactory |> ignore
easingFunctionFactory |> ignore
backEaseFactory |> ignore
bezierCurveEaseFactory |> ignore
bounceEaseFactory |> ignore
circleEaseFactory |> ignore
cubicEaseFactory |> ignore
elasticEaseFactory |> ignore
exponentialEaseFactory |> ignore
powerEaseFactory |> ignore
quadraticEaseFactory |> ignore
quarticEaseFactory |> ignore
quinticEaseFactory |> ignore
sineEaseFactory |> ignore
stencilStateFactory |> ignore
strideFunction |> ignore
epsilon |> ignore
shaderDescriptor |> ignore
padNumber |> ignore
testBase64DataUrl |> ignore
printfn "curated Babylon binding compile smoke passed"
