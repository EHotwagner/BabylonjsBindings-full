// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after interface review, compile, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact dependency-closed interfaces exported by Babylon.js 9.19.0.
module SimpleInterfaces =

    /// Exact structural browser ImageBitmap surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserImageBitmap =
        abstract width: float with get
        abstract height: float with get
        abstract close: unit -> unit

    /// Distinct ambient OffscreenCanvas handle used by ImageBitmapSource.
    [<AllowNullLiteral>]
    type BrowserOffscreenCanvas =
        interface end

    /// Distinct ambient VideoFrame handle used by ImageBitmapSource.
    [<AllowNullLiteral>]
    type BrowserVideoFrame =
        interface end

    /// Distinct ambient SVGImageElement handle used by ImageBitmapSource.
    [<AllowNullLiteral>]
    type BrowserSVGImageElement =
        interface end

    /// Exact standard ImageBitmapSource union accepted by Babylon engine APIs.
    type BrowserImageBitmapSource = U9<Browser.Types.HTMLImageElement, BrowserSVGImageElement, Browser.Types.HTMLVideoElement, Browser.Types.HTMLCanvasElement, BrowserImageBitmap, BrowserOffscreenCanvas, BrowserVideoFrame, Browser.Types.Blob, Browser.Types.ImageData>

    /// Distinct ambient WebGL2 rendering-context handle.
    [<AllowNullLiteral>]
    type BrowserWebGL2RenderingContext =
        interface end

    /// Distinct ambient WebAudio context handle.
    [<AllowNullLiteral>]
    type BrowserAudioContext =
        interface end

    /// Distinct ambient WebAudio destination-node handle.
    [<AllowNullLiteral>]
    type BrowserAudioDestinationNode =
        interface end

    /// Distinct ambient media-stream audio destination-node handle.
    [<AllowNullLiteral>]
    type BrowserMediaStreamAudioDestinationNode =
        interface end

    /// Distinct ambient Fetch Response handle.
    [<AllowNullLiteral>]
    type BrowserResponse =
        interface end

    /// Distinct ambient Fetch BodyInit value handle.
    [<AllowNullLiteral>]
    type BrowserBodyInit =
        interface end

    /// Distinct ambient MediaStream handle.
    [<AllowNullLiteral>]
    type BrowserMediaStream =
        interface end

    /// Distinct ambient AbortSignal handle.
    [<AllowNullLiteral>]
    type BrowserAbortSignal =
        interface end

    /// Ambient XMLHttpRequest handle used by Babylon request modifiers.
    [<AllowNullLiteral>]
    type BrowserXMLHttpRequest =
        abstract setRequestHeader: name: string * value: string -> unit

    /// Distinct ambient URL handle.
    [<AllowNullLiteral>]
    type BrowserURL =
        interface end

    /// Exact structural DOMRect surface.
    [<AllowNullLiteral>]
    type BrowserDOMRect =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract width: float with get, set
        abstract height: float with get, set
        abstract top: float with get
        abstract right: float with get
        abstract bottom: float with get
        abstract left: float with get
        abstract toJSON: unit -> obj

    /// Distinct ambient FormData handle.
    [<AllowNullLiteral>]
    type BrowserFormData =
        interface end

    /// Distinct ambient URLSearchParams handle.
    [<AllowNullLiteral>]
    type BrowserURLSearchParams =
        interface end

    /// Exact XMLHttpRequest request-body union.
    type BrowserXMLHttpRequestBodyInit = U6<Browser.Types.Blob, JS.ArrayBufferView, JS.ArrayBuffer, BrowserFormData, BrowserURLSearchParams, string>

    /// Exact DOM event-listener options surface.
    [<AllowNullLiteral>]
    type BrowserEventListenerOptions =
        abstract capture: bool option with get, set

    /// Exact DOM add-event-listener options surface.
    [<AllowNullLiteral>]
    type BrowserAddEventListenerOptions =
        inherit BrowserEventListenerOptions
        abstract once: bool option with get, set
        abstract passive: bool option with get, set
        abstract signal: BrowserAbortSignal option with get, set

    /// Distinct ambient WebXR reference-space handle.
    [<AllowNullLiteral>]
    type BrowserXRReferenceSpace =
        interface end

    /// Distinct ambient WebXR frame handle.
    [<AllowNullLiteral>]
    type BrowserXRFrame =
        interface end

    /// Distinct ambient WebXR session handle.
    [<AllowNullLiteral>]
    type BrowserXRSession =
        interface end

    /// Distinct ambient WebXR viewer-pose handle.
    [<AllowNullLiteral>]
    type BrowserXRViewerPose =
        interface end

    /// Distinct ambient WebXR input-source handle.
    [<AllowNullLiteral>]
    type BrowserXRInputSource =
        interface end

    /// Distinct ambient WebXR pose handle.
    [<AllowNullLiteral>]
    type BrowserXRPose =
        interface end

    /// Distinct ambient WebXR view handle.
    [<AllowNullLiteral>]
    type BrowserXRView =
        interface end

    /// Distinct ambient WebXR layer handle.
    [<AllowNullLiteral>]
    type BrowserXRLayer =
        interface end

    /// Distinct ambient WebXR WebGL-layer handle.
    [<AllowNullLiteral>]
    type BrowserXRWebGLLayer =
        inherit BrowserXRLayer

    /// Distinct ambient WebXR WebGL-layer initialization surface.
    [<AllowNullLiteral>]
    type BrowserXRWebGLLayerInit =
        interface end

    /// Distinct ambient WebXR session initialization surface.
    [<AllowNullLiteral>]
    type BrowserXRSessionInit =
        interface end

    /// Distinct ambient WebXR render-state surface.
    [<AllowNullLiteral>]
    type BrowserXRRenderState =
        interface end

    /// Distinct ambient WebXR render-state initialization surface.
    [<AllowNullLiteral>]
    type BrowserXRRenderStateInit =
        interface end

    /// Exact WebXR reference-space literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRReferenceSpaceType =
        | [<CompiledName("viewer")>] Viewer
        | [<CompiledName("local")>] Local
        | [<CompiledName("local-floor")>] LocalFloor
        | [<CompiledName("bounded-floor")>] BoundedFloor
        | [<CompiledName("unbounded")>] Unbounded

    /// Exact WebXR session-mode literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXRSessionMode =
        | [<CompiledName("inline")>] Inline
        | [<CompiledName("immersive-ar")>] ImmersiveAr
        | [<CompiledName("immersive-vr")>] ImmersiveVr

    /// Exact WebXR eye literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXREye =
        | [<CompiledName("left")>] Left
        | [<CompiledName("none")>] None
        | [<CompiledName("right")>] Right

    /// Exact WebGPU power-preference literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUPowerPreference =
        | [<CompiledName("high-performance")>] HighPerformance
        | [<CompiledName("low-power")>] LowPower

    /// Exact XMLHttpRequest response-type literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserXMLHttpRequestResponseType =
        | [<CompiledName("")>] Default
        | [<CompiledName("arraybuffer")>] ArrayBuffer
        | [<CompiledName("blob")>] Blob
        | [<CompiledName("document")>] Document
        | [<CompiledName("json")>] Json
        | [<CompiledName("text")>] Text

    /// Exact browser image color-space conversion literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserColorSpaceConversion =
        | [<CompiledName("default")>] Default
        | [<CompiledName("none")>] None

    /// Exact browser image orientation literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserImageOrientation =
        | [<CompiledName("flipY")>] FlipY
        | [<CompiledName("from-image")>] FromImage
        | [<CompiledName("none")>] None

    /// Exact browser premultiplied-alpha literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserPremultiplyAlpha =
        | [<CompiledName("default")>] Default
        | [<CompiledName("none")>] None
        | [<CompiledName("premultiply")>] Premultiply

    /// Exact browser bitmap resize-quality literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserResizeQuality =
        | [<CompiledName("high")>] High
        | [<CompiledName("low")>] Low
        | [<CompiledName("medium")>] Medium
        | [<CompiledName("pixelated")>] Pixelated

    /// Exact structural browser ImageBitmapOptions surface.
    [<AllowNullLiteral>]
    type BrowserImageBitmapOptions =
        abstract colorSpaceConversion: BrowserColorSpaceConversion option with get, set
        abstract imageOrientation: BrowserImageOrientation option with get, set
        abstract premultiplyAlpha: BrowserPremultiplyAlpha option with get, set
        abstract resizeHeight: float option with get, set
        abstract resizeQuality: BrowserResizeQuality option with get, set
        abstract resizeWidth: float option with get, set

    /// Structural non-primitive JavaScript object surface used by TypeScript `object` declarations.
    [<AllowNullLiteral>]
    type JavaScriptObject =
        interface end

    /// Exact structural ECMAScript iterator surface used by readonly sets.
    [<AllowNullLiteral>]
    type BrowserIterator<'T> =
        abstract next: ?value: obj -> JS.IteratorResult<'T>
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> BrowserIterator<'T>

    /// Yield branch returned by an ECMAScript generator.
    [<AllowNullLiteral>]
    type BrowserGeneratorYieldResult<'T> =
        abstract ``done``: bool option with get
        abstract value: 'T with get

    /// Completion branch returned by an ECMAScript generator.
    [<AllowNullLiteral>]
    type BrowserGeneratorReturnResult<'T> =
        abstract ``done``: bool with get
        abstract value: 'T with get

    /// Exact yield-or-return result of an ECMAScript generator.
    type BrowserGeneratorResult<'TYield, 'TReturn> = U2<BrowserGeneratorYieldResult<'TYield>, BrowserGeneratorReturnResult<'TReturn>>

    /// Exact synchronous ECMAScript Generator surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserGenerator<'TYield, 'TReturn, 'TNext> =
        abstract next: ?value: 'TNext -> BrowserGeneratorResult<'TYield, 'TReturn>
        [<Emit("$0.return($1)")>] abstract ``return``: ?value: 'TReturn -> BrowserGeneratorResult<'TYield, 'TReturn>
        [<Emit("$0.throw($1)")>] abstract ``throw``: ?error: obj -> BrowserGeneratorResult<'TYield, 'TReturn>
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> BrowserGenerator<'TYield, 'TReturn, 'TNext>

    /// Exact readonly ECMAScript Set surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserReadonlySet<'T> =
        abstract size: float with get
        abstract has: value: 'T -> bool
        abstract forEach: callbackfn: System.Action<'T, 'T, BrowserReadonlySet<'T>> * ?thisArg: obj -> unit
        abstract entries: unit -> BrowserIterator<'T * 'T>
        abstract keys: unit -> BrowserIterator<'T>
        abstract values: unit -> BrowserIterator<'T>
        [<Emit("$0[Symbol.iterator]()")>] abstract GetIterator: unit -> BrowserIterator<'T>

    /// Exact numeric literal type for 1.
    type NumericLiteral1 =
        | Value = 1

    /// Exact numeric literal type for 2.
    type NumericLiteral2 =
        | Value = 2

    /// Exact numeric literal type for 33776.
    type NumericLiteral33776 =
        | Value = 33776

    /// Exact numeric literal type for 33777.
    type NumericLiteral33777 =
        | Value = 33777

    /// Exact numeric literal type for 33778.
    type NumericLiteral33778 =
        | Value = 33778

    /// Exact numeric literal type for 33779.
    type NumericLiteral33779 =
        | Value = 33779

    /// Exact numeric literal type for 34046.
    type NumericLiteral34046 =
        | Value = 34046

    /// Exact numeric literal type for 34047.
    type NumericLiteral34047 =
        | Value = 34047

    /// Exact numeric literal type for 35916.
    type NumericLiteral35916 =
        | Value = 35916

    /// Exact numeric literal type for 35917.
    type NumericLiteral35917 =
        | Value = 35917

    /// Exact numeric literal type for 35918.
    type NumericLiteral35918 =
        | Value = 35918

    /// Exact numeric literal type for 35919.
    type NumericLiteral35919 =
        | Value = 35919

    /// Exact numeric enum subset projected from a TypeScript Exclude utility.
    type PointerInputExcluding6a48353fe9 =
        | LeftClick = 2
        | MiddleClick = 3
        | RightClick = 4
        | BrowserBack = 5
        | BrowserForward = 6
        | MouseWheelX = 7
        | MouseWheelY = 8
        | MouseWheelZ = 9
        | Move = 12

    /// Exact numeric enum subset projected from a TypeScript Exclude utility.
    type PointerInputExcluding9b1eb22bd0 =
        | LeftClick = 2
        | MiddleClick = 3
        | RightClick = 4
        | BrowserBack = 5
        | BrowserForward = 6
        | Move = 12

    /// Exact opaque WebGLQuery handle.
    [<AllowNullLiteral>]
    type BrowserWebGLQuery =
        interface end

    /// Exact WebGL context-event extension surface.
    [<AllowNullLiteral>]
    type BrowserWebGLContextEvent =
        inherit Browser.Types.Event
        abstract statusMessage: string with get

    /// Distinct opaque handle for the ambient JavaScript RegExp API.
    [<AllowNullLiteral>]
    type BrowserRegExp =
        interface end

    /// Exact nominal type for a required JavaScript null literal.
    [<AllowNullLiteral>]
    type JavaScriptNull =
        interface end

    /// Erased, owner-typed JavaScript property key.
    [<Erase>]
    type JavaScriptKeyOf<'TOwner> =
        | JavaScriptKeyOf of string

    /// Exact pointer input-source discriminator.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserPointerInputSource =
        | [<CompiledName("pointer")>] Value

    /// Exact wheel input-source discriminator.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserWheelInputSource =
        | [<CompiledName("wheel")>] Value

    /// Exact touch input-source discriminator.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserTouchInputSource =
        | [<CompiledName("touch")>] Value

    /// Exact keyboard input-source discriminator.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserKeyboardInputSource =
        | [<CompiledName("keyboard")>] Value

    /// Exact modifier state shared by Babylon input-map entries.
    [<AllowNullLiteral>]
    type BrowserInputModifiers =
        abstract ctrl: bool option with get, set
        abstract shift: bool option with get, set
        abstract alt: bool option with get, set

    /// Exact pointer input-map entry.
    [<AllowNullLiteral>]
    type BrowserPointerInputMapEntry<'TInteraction> =
        abstract source: BrowserPointerInputSource with get, set
        abstract interaction: 'TInteraction with get, set
        abstract sensitivity: float option with get, set
        abstract sensitivityX: float option with get, set
        abstract sensitivityY: float option with get, set
        abstract button: float option with get, set
        abstract modifiers: BrowserInputModifiers option with get, set

    /// Exact wheel input-map entry.
    [<AllowNullLiteral>]
    type BrowserWheelInputMapEntry<'TInteraction> =
        abstract source: BrowserWheelInputSource with get, set
        abstract interaction: 'TInteraction with get, set
        abstract sensitivity: float option with get, set
        abstract modifiers: BrowserInputModifiers option with get, set

    /// Exact touch input-map entry.
    [<AllowNullLiteral>]
    type BrowserTouchInputMapEntry<'TInteraction> =
        abstract source: BrowserTouchInputSource with get, set
        abstract interaction: 'TInteraction with get, set
        abstract sensitivity: float option with get, set
        abstract sensitivityX: float option with get, set
        abstract sensitivityY: float option with get, set
        abstract touchCount: float option with get, set

    /// Exact keyboard input-map entry.
    [<AllowNullLiteral>]
    type BrowserKeyboardInputMapEntry<'TInteraction> =
        abstract source: BrowserKeyboardInputSource with get, set
        abstract interaction: 'TInteraction with get, set
        abstract sensitivity: float option with get, set
        abstract key: U2<float, ResizeArray<float>> option with get, set
        abstract modifiers: BrowserInputModifiers option with get, set

    /// Exact discriminated union of Babylon input-map entries.
    type BrowserInputMapEntry<'TInteraction> = U4<BrowserPointerInputMapEntry<'TInteraction>, BrowserWheelInputMapEntry<'TInteraction>, BrowserTouchInputMapEntry<'TInteraction>, BrowserKeyboardInputMapEntry<'TInteraction>>

    /// Exact GPUBuffer map-state literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUBufferMapState =
        | [<CompiledName("mapped")>] Mapped
        | [<CompiledName("pending")>] Pending
        | [<CompiledName("unmapped")>] Unmapped

    /// Exact WebGPU comparison-function literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUCompareFunction =
        | [<CompiledName("never")>] Never
        | [<CompiledName("less")>] Less
        | [<CompiledName("equal")>] Equal
        | [<CompiledName("less-equal")>] LessEqual
        | [<CompiledName("greater")>] Greater
        | [<CompiledName("not-equal")>] NotEqual
        | [<CompiledName("greater-equal")>] GreaterEqual
        | [<CompiledName("always")>] Always

    /// Exact WebGPU storage-texture access literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUStorageTextureAccess =
        | [<CompiledName("write-only")>] WriteOnly
        | [<CompiledName("read-only")>] ReadOnly
        | [<CompiledName("read-write")>] ReadWrite

    /// Exact WebGPU texture sample type literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUTextureSampleType =
        | [<CompiledName("float")>] Float
        | [<CompiledName("unfilterable-float")>] UnfilterableFloat
        | [<CompiledName("depth")>] Depth
        | [<CompiledName("sint")>] Sint
        | [<CompiledName("uint")>] Uint

    /// Exact WebGPU sampler binding type literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUSamplerBindingType =
        | [<CompiledName("filtering")>] Filtering
        | [<CompiledName("non-filtering")>] NonFiltering
        | [<CompiledName("comparison")>] Comparison

    /// Exact WebGPU texture-view dimension literals.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUTextureViewDimension =
        | [<CompiledName("1d")>] D1d
        | [<CompiledName("2d")>] D2d
        | [<CompiledName("2d-array")>] D2dArray
        | [<CompiledName("cube")>] Cube
        | [<CompiledName("cube-array")>] CubeArray
        | [<CompiledName("3d")>] D3d

    /// Exact WebGPU GPUBuffer instance surface used by Babylon declarations.
    [<AllowNullLiteral>]
    type BrowserGPUBuffer =
        abstract label: string with get, set
        abstract size: float with get
        abstract usage: float with get
        abstract mapState: BrowserGPUBufferMapState with get
        abstract mapAsync: mode: float * ?offset: float * ?size: float -> JS.Promise<unit>
        abstract getMappedRange: ?offset: float * ?size: float -> JS.ArrayBuffer
        abstract unmap: unit -> unit
        abstract destroy: unit -> unit

    /// Distinct ambient WebGPU device handle.
    [<AllowNullLiteral>]
    type BrowserGPUDevice =
        interface end

    /// Distinct ambient WebGPU render-pass encoder handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderPassEncoder =
        interface end

    /// Distinct ambient WebGPU render pipeline handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderPipeline =
        interface end

    /// Distinct ambient WebGPU query set handle.
    [<AllowNullLiteral>]
    type BrowserGPUQuerySet =
        interface end

    /// Distinct ambient WebGPU command encoder handle.
    [<AllowNullLiteral>]
    type BrowserGPUCommandEncoder =
        interface end

    /// Distinct ambient WebGPU render bundle handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderBundle =
        interface end

    /// Distinct ambient WebGPU texture handle.
    [<AllowNullLiteral>]
    type BrowserGPUTexture =
        interface end

    /// Distinct ambient WebGPU sampler handle.
    [<AllowNullLiteral>]
    type BrowserGPUSampler =
        interface end

    /// Distinct ambient WebGPU bind group handle.
    [<AllowNullLiteral>]
    type BrowserGPUBindGroup =
        interface end

    /// Distinct ambient WebGPU bind-group layout handle.
    [<AllowNullLiteral>]
    type BrowserGPUBindGroupLayout =
        interface end

    /// Distinct ambient WebGPU pipeline layout handle.
    [<AllowNullLiteral>]
    type BrowserGPUPipelineLayout =
        interface end

    /// Distinct ambient WebGPU shader module handle.
    [<AllowNullLiteral>]
    type BrowserGPUShaderModule =
        interface end

    /// Distinct ambient WebGPU compute pipeline handle.
    [<AllowNullLiteral>]
    type BrowserGPUComputePipeline =
        interface end

    /// Distinct ambient WebGPU command buffer handle.
    [<AllowNullLiteral>]
    type BrowserGPUCommandBuffer =
        interface end

    /// Distinct ambient WebGPU texture view handle.
    [<AllowNullLiteral>]
    type BrowserGPUTextureView =
        interface end

    /// Distinct ambient WebGPU adapter handle.
    [<AllowNullLiteral>]
    type BrowserGPUAdapter =
        interface end

    /// Distinct ambient WebGPU canvas context handle.
    [<AllowNullLiteral>]
    type BrowserGPUCanvasContext =
        interface end

    /// Distinct ambient WebGPU external texture handle.
    [<AllowNullLiteral>]
    type BrowserGPUExternalTexture =
        interface end

    /// Distinct ambient WebGPU render-bundle encoder handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderBundleEncoder =
        interface end

    /// Distinct ambient WebGPU render-pass descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderPassDescriptor =
        interface end

    /// Distinct ambient WebGPU render-pipeline descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPURenderPipelineDescriptor =
        interface end

    /// Distinct ambient WebGPU programmable-stage descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPUProgrammableStage =
        interface end

    /// Distinct ambient WebGPU bind-group-layout entry handle.
    [<AllowNullLiteral>]
    type BrowserGPUBindGroupLayoutEntry =
        interface end

    /// Distinct ambient WebGPU bind-group entry handle.
    [<AllowNullLiteral>]
    type BrowserGPUBindGroupEntry =
        interface end

    /// Distinct ambient WebGPU compute-pass descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPUComputePassDescriptor =
        interface end

    /// Distinct ambient WebGPU texture-view descriptor handle.
    [<AllowNullLiteral>]
    type BrowserGPUTextureViewDescriptor =
        interface end

    /// Distinct ambient WebXR WebGL binding handle.
    [<AllowNullLiteral>]
    type BrowserXRWebGLBinding =
        interface end

    /// Distinct ambient WebXR composition-layer handle.
    [<AllowNullLiteral>]
    type BrowserXRCompositionLayer =
        interface end

    /// Distinct ambient Web Audio buffer handle.
    [<AllowNullLiteral>]
    type BrowserAudioBuffer =
        interface end

    /// Distinct ambient Web Audio node handle.
    [<AllowNullLiteral>]
    type BrowserAudioNode =
        interface end

    /// Distinct ambient Web Audio gain node handle.
    [<AllowNullLiteral>]
    type BrowserGainNode =
        interface end

    /// Distinct ambient offline Web Audio context handle.
    [<AllowNullLiteral>]
    type BrowserOfflineAudioContext =
        interface end

    /// Distinct ambient Web Audio buffer-source node handle.
    [<AllowNullLiteral>]
    type BrowserAudioBufferSourceNode =
        interface end

    /// Distinct ambient media-track constraints handle.
    [<AllowNullLiteral>]
    type BrowserMediaTrackConstraints =
        interface end

    /// Distinct ambient pointer-event initializer handle.
    [<AllowNullLiteral>]
    type BrowserPointerEventInit =
        interface end

    /// Distinct ambient WebGL vertex-array object handle.
    [<AllowNullLiteral>]
    type BrowserWebGLVertexArrayObject =
        interface end

    /// Distinct ambient WebGPU device-descriptor surface.
    [<AllowNullLiteral>]
    type BrowserGPUDeviceDescriptor =
        interface end

    /// Exact WebGPU adapter-request options surface.
    [<AllowNullLiteral>]
    type BrowserGPURequestAdapterOptions =
        abstract featureLevel: string option with get, set
        abstract powerPreference: BrowserGPUPowerPreference option with get, set
        abstract forceFallbackAdapter: bool option with get, set
        abstract xrCompatible: bool option with get, set

    /// Exact indexed WebGPU supported-limits surface exposed by Babylon's declaration augmentation.
    [<AllowNullLiteral>]
    type BrowserGPUSupportedLimits =
        [<EmitIndexer>] abstract Item: name: string -> float with get

    /// Exact GPUTextureFormat literals from the WebGPU specification.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUTextureFormat =
        | [<CompiledName("r8unorm")>] R8unorm
        | [<CompiledName("r8snorm")>] R8snorm
        | [<CompiledName("r8uint")>] R8uint
        | [<CompiledName("r8sint")>] R8sint
        | [<CompiledName("r16unorm")>] R16unorm
        | [<CompiledName("r16snorm")>] R16snorm
        | [<CompiledName("r16uint")>] R16uint
        | [<CompiledName("r16sint")>] R16sint
        | [<CompiledName("r16float")>] R16float
        | [<CompiledName("rg8unorm")>] Rg8unorm
        | [<CompiledName("rg8snorm")>] Rg8snorm
        | [<CompiledName("rg8uint")>] Rg8uint
        | [<CompiledName("rg8sint")>] Rg8sint
        | [<CompiledName("r32uint")>] R32uint
        | [<CompiledName("r32sint")>] R32sint
        | [<CompiledName("r32float")>] R32float
        | [<CompiledName("rg16unorm")>] Rg16unorm
        | [<CompiledName("rg16snorm")>] Rg16snorm
        | [<CompiledName("rg16uint")>] Rg16uint
        | [<CompiledName("rg16sint")>] Rg16sint
        | [<CompiledName("rg16float")>] Rg16float
        | [<CompiledName("rgba8unorm")>] Rgba8unorm
        | [<CompiledName("rgba8unorm-srgb")>] Rgba8unormSrgb
        | [<CompiledName("rgba8snorm")>] Rgba8snorm
        | [<CompiledName("rgba8uint")>] Rgba8uint
        | [<CompiledName("rgba8sint")>] Rgba8sint
        | [<CompiledName("bgra8unorm")>] Bgra8unorm
        | [<CompiledName("bgra8unorm-srgb")>] Bgra8unormSrgb
        | [<CompiledName("rgb9e5ufloat")>] Rgb9e5ufloat
        | [<CompiledName("rgb10a2uint")>] Rgb10a2uint
        | [<CompiledName("rgb10a2unorm")>] Rgb10a2unorm
        | [<CompiledName("rg11b10ufloat")>] Rg11b10ufloat
        | [<CompiledName("rg32uint")>] Rg32uint
        | [<CompiledName("rg32sint")>] Rg32sint
        | [<CompiledName("rg32float")>] Rg32float
        | [<CompiledName("rgba16unorm")>] Rgba16unorm
        | [<CompiledName("rgba16snorm")>] Rgba16snorm
        | [<CompiledName("rgba16uint")>] Rgba16uint
        | [<CompiledName("rgba16sint")>] Rgba16sint
        | [<CompiledName("rgba16float")>] Rgba16float
        | [<CompiledName("rgba32uint")>] Rgba32uint
        | [<CompiledName("rgba32sint")>] Rgba32sint
        | [<CompiledName("rgba32float")>] Rgba32float
        | [<CompiledName("stencil8")>] Stencil8
        | [<CompiledName("depth16unorm")>] Depth16unorm
        | [<CompiledName("depth24plus")>] Depth24plus
        | [<CompiledName("depth24plus-stencil8")>] Depth24plusStencil8
        | [<CompiledName("depth32float")>] Depth32float
        | [<CompiledName("depth32float-stencil8")>] Depth32floatStencil8
        | [<CompiledName("bc1-rgba-unorm")>] Bc1RgbaUnorm
        | [<CompiledName("bc1-rgba-unorm-srgb")>] Bc1RgbaUnormSrgb
        | [<CompiledName("bc2-rgba-unorm")>] Bc2RgbaUnorm
        | [<CompiledName("bc2-rgba-unorm-srgb")>] Bc2RgbaUnormSrgb
        | [<CompiledName("bc3-rgba-unorm")>] Bc3RgbaUnorm
        | [<CompiledName("bc3-rgba-unorm-srgb")>] Bc3RgbaUnormSrgb
        | [<CompiledName("bc4-r-unorm")>] Bc4RUnorm
        | [<CompiledName("bc4-r-snorm")>] Bc4RSnorm
        | [<CompiledName("bc5-rg-unorm")>] Bc5RgUnorm
        | [<CompiledName("bc5-rg-snorm")>] Bc5RgSnorm
        | [<CompiledName("bc6h-rgb-ufloat")>] Bc6hRgbUfloat
        | [<CompiledName("bc6h-rgb-float")>] Bc6hRgbFloat
        | [<CompiledName("bc7-rgba-unorm")>] Bc7RgbaUnorm
        | [<CompiledName("bc7-rgba-unorm-srgb")>] Bc7RgbaUnormSrgb
        | [<CompiledName("etc2-rgb8unorm")>] Etc2Rgb8unorm
        | [<CompiledName("etc2-rgb8unorm-srgb")>] Etc2Rgb8unormSrgb
        | [<CompiledName("etc2-rgb8a1unorm")>] Etc2Rgb8a1unorm
        | [<CompiledName("etc2-rgb8a1unorm-srgb")>] Etc2Rgb8a1unormSrgb
        | [<CompiledName("etc2-rgba8unorm")>] Etc2Rgba8unorm
        | [<CompiledName("etc2-rgba8unorm-srgb")>] Etc2Rgba8unormSrgb
        | [<CompiledName("eac-r11unorm")>] EacR11unorm
        | [<CompiledName("eac-r11snorm")>] EacR11snorm
        | [<CompiledName("eac-rg11unorm")>] EacRg11unorm
        | [<CompiledName("eac-rg11snorm")>] EacRg11snorm
        | [<CompiledName("astc-4x4-unorm")>] Astc4x4Unorm
        | [<CompiledName("astc-4x4-unorm-srgb")>] Astc4x4UnormSrgb
        | [<CompiledName("astc-5x4-unorm")>] Astc5x4Unorm
        | [<CompiledName("astc-5x4-unorm-srgb")>] Astc5x4UnormSrgb
        | [<CompiledName("astc-5x5-unorm")>] Astc5x5Unorm
        | [<CompiledName("astc-5x5-unorm-srgb")>] Astc5x5UnormSrgb
        | [<CompiledName("astc-6x5-unorm")>] Astc6x5Unorm
        | [<CompiledName("astc-6x5-unorm-srgb")>] Astc6x5UnormSrgb
        | [<CompiledName("astc-6x6-unorm")>] Astc6x6Unorm
        | [<CompiledName("astc-6x6-unorm-srgb")>] Astc6x6UnormSrgb
        | [<CompiledName("astc-8x5-unorm")>] Astc8x5Unorm
        | [<CompiledName("astc-8x5-unorm-srgb")>] Astc8x5UnormSrgb
        | [<CompiledName("astc-8x6-unorm")>] Astc8x6Unorm
        | [<CompiledName("astc-8x6-unorm-srgb")>] Astc8x6UnormSrgb
        | [<CompiledName("astc-8x8-unorm")>] Astc8x8Unorm
        | [<CompiledName("astc-8x8-unorm-srgb")>] Astc8x8UnormSrgb
        | [<CompiledName("astc-10x5-unorm")>] Astc10x5Unorm
        | [<CompiledName("astc-10x5-unorm-srgb")>] Astc10x5UnormSrgb
        | [<CompiledName("astc-10x6-unorm")>] Astc10x6Unorm
        | [<CompiledName("astc-10x6-unorm-srgb")>] Astc10x6UnormSrgb
        | [<CompiledName("astc-10x8-unorm")>] Astc10x8Unorm
        | [<CompiledName("astc-10x8-unorm-srgb")>] Astc10x8UnormSrgb
        | [<CompiledName("astc-10x10-unorm")>] Astc10x10Unorm
        | [<CompiledName("astc-10x10-unorm-srgb")>] Astc10x10UnormSrgb
        | [<CompiledName("astc-12x10-unorm")>] Astc12x10Unorm
        | [<CompiledName("astc-12x10-unorm-srgb")>] Astc12x10UnormSrgb
        | [<CompiledName("astc-12x12-unorm")>] Astc12x12Unorm
        | [<CompiledName("astc-12x12-unorm-srgb")>] Astc12x12UnormSrgb

    /// Exact GPUFeatureName literals from the WebGPU specification.
    [<StringEnum; RequireQualifiedAccess>]
    type BrowserGPUFeatureName =
        | [<CompiledName("core-features-and-limits")>] CoreFeaturesAndLimits
        | [<CompiledName("depth-clip-control")>] DepthClipControl
        | [<CompiledName("depth32float-stencil8")>] Depth32floatStencil8
        | [<CompiledName("texture-compression-bc")>] TextureCompressionBc
        | [<CompiledName("texture-compression-bc-sliced-3d")>] TextureCompressionBcSliced3d
        | [<CompiledName("texture-compression-etc2")>] TextureCompressionEtc2
        | [<CompiledName("texture-compression-astc")>] TextureCompressionAstc
        | [<CompiledName("texture-compression-astc-sliced-3d")>] TextureCompressionAstcSliced3d
        | [<CompiledName("timestamp-query")>] TimestampQuery
        | [<CompiledName("indirect-first-instance")>] IndirectFirstInstance
        | [<CompiledName("shader-f16")>] ShaderF16
        | [<CompiledName("rg11b10ufloat-renderable")>] Rg11b10ufloatRenderable
        | [<CompiledName("bgra8unorm-storage")>] Bgra8unormStorage
        | [<CompiledName("float32-filterable")>] Float32Filterable
        | [<CompiledName("float32-blendable")>] Float32Blendable
        | [<CompiledName("clip-distances")>] ClipDistances
        | [<CompiledName("dual-source-blending")>] DualSourceBlending
        | [<CompiledName("subgroups")>] Subgroups
        | [<CompiledName("texture-formats-tier1")>] TextureFormatsTier1
        | [<CompiledName("texture-formats-tier2")>] TextureFormatsTier2
        | [<CompiledName("primitive-index")>] PrimitiveIndex
        | [<CompiledName("texture-component-swizzle")>] TextureComponentSwizzle
        | [<CompiledName("subgroup-size-control")>] SubgroupSizeControl

    /// Exact WEBGL_compressed_texture_s3tc extension surface.
    [<AllowNullLiteral>]
    type BrowserWebGLCompressedTextureS3tc =
        abstract COMPRESSED_RGB_S3TC_DXT1_EXT: NumericLiteral33776 with get
        abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: NumericLiteral33777 with get
        abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: NumericLiteral33778 with get
        abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: NumericLiteral33779 with get

    /// Exact WEBGL_compressed_texture_s3tc_srgb extension surface.
    [<AllowNullLiteral>]
    type BrowserWebGLCompressedTextureS3tcSrgb =
        abstract COMPRESSED_SRGB_S3TC_DXT1_EXT: NumericLiteral35916 with get
        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT: NumericLiteral35917 with get
        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT: NumericLiteral35918 with get
        abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT: NumericLiteral35919 with get

    /// Exact EXT_texture_filter_anisotropic extension surface.
    [<AllowNullLiteral>]
    type BrowserExtTextureFilterAnisotropic =
        abstract TEXTURE_MAX_ANISOTROPY_EXT: NumericLiteral34046 with get
        abstract MAX_TEXTURE_MAX_ANISOTROPY_EXT: NumericLiteral34047 with get

    /// Exact Babylon EXT_disjoint_timer_query extension surface.
    [<AllowNullLiteral>]
    type BrowserExtDisjointTimerQuery =
        abstract QUERY_COUNTER_BITS_EXT: float with get, set
        abstract TIME_ELAPSED_EXT: float with get, set
        abstract TIMESTAMP_EXT: float with get, set
        abstract GPU_DISJOINT_EXT: float with get, set
        abstract QUERY_RESULT_EXT: float with get, set
        abstract QUERY_RESULT_AVAILABLE_EXT: float with get, set
        abstract queryCounterEXT: query: BrowserWebGLQuery * target: float -> unit
        abstract createQueryEXT: unit -> BrowserWebGLQuery
        abstract beginQueryEXT: target: float * query: BrowserWebGLQuery -> unit
        abstract endQueryEXT: target: float -> unit
        abstract getQueryObjectEXT: query: BrowserWebGLQuery * target: float -> obj
        abstract deleteQueryEXT: query: BrowserWebGLQuery -> unit

    /// Exact string literal type for "form".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral07397d633f25 =
        | [<CompiledName("form")>] Value

    /// Exact string literal type for "status".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral073c1634c496 =
        | [<CompiledName("status")>] Value

    /// Exact string literal type for "separator".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral080856f98d1e =
        | [<CompiledName("separator")>] Value

    /// Exact string literal type for "marquee".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral0ada0c035439 =
        | [<CompiledName("marquee")>] Value

    /// Exact string literal type for "table".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral0d4fc4a78d37 =
        | [<CompiledName("table")>] Value

    /// Exact string literal type for "main".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral0d6e4079e367 =
        | [<CompiledName("main")>] Value

    /// Exact string literal type for "ceil".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral0fdfeaa68c7b =
        | [<CompiledName("ceil")>] Value

    /// Exact string literal type for "searchbox".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral131ff8f4616b =
        | [<CompiledName("searchbox")>] Value

    /// Exact string literal type for "none".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral140bedbf9c3f =
        | [<CompiledName("none")>] Value

    /// Exact string literal type for "treegrid".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral189c7d737ca4 =
        | [<CompiledName("treegrid")>] Value

    /// Exact string literal type for "Y".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral18f5384d58bc =
        | [<CompiledName("Y")>] Value

    /// Exact string literal type for "listitem".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral1bbc1b324415 =
        | [<CompiledName("listitem")>] Value

    /// Exact string literal type for "xr-standard".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral1f8f7b54dd3a =
        | [<CompiledName("xr-standard")>] Value

    /// Exact string literal type for "tooltip".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral1fb691986729 =
        | [<CompiledName("tooltip")>] Value

    /// Exact string literal type for "application".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral1fe289205936 =
        | [<CompiledName("application")>] Value

    /// Exact string literal type for "rowheader".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral224f0009e42e =
        | [<CompiledName("rowheader")>] Value

    /// Exact string literal type for "search".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral241932906782 =
        | [<CompiledName("search")>] Value

    /// Exact string literal type for "scrollbar".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral255512839036 =
        | [<CompiledName("scrollbar")>] Value

    /// Exact string literal type for "directory".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral333178788eae =
        | [<CompiledName("directory")>] Value

    /// Exact string literal type for "menu".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral398991009da1 =
        | [<CompiledName("menu")>] Value

    /// Exact string literal type for "cell".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral39d02b42938b =
        | [<CompiledName("cell")>] Value

    /// Exact string literal type for "document".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral43cc23fa52b8 =
        | [<CompiledName("document")>] Value

    /// Exact string literal type for "xAxis".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral49563714cd71 =
        | [<CompiledName("xAxis")>] Value

    /// Exact string literal type for "X".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral4b68ab3847fe =
        | [<CompiledName("X")>] Value

    /// Exact string literal type for "state".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral4ba69735ca53 =
        | [<CompiledName("state")>] Value

    /// Exact string literal type for "definition".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral4c4ed1afbfda =
        | [<CompiledName("definition")>] Value

    /// Exact string literal type for "encodeMeshError".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral56b69f7fdd12 =
        | [<CompiledName("encodeMeshError")>] Value

    /// Exact string literal type for "math".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral58a6d6801ae7 =
        | [<CompiledName("math")>] Value

    /// Exact string literal type for "term".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral599f7703547e =
        | [<CompiledName("term")>] Value

    /// Exact string literal type for "heading".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral5e60ff5ac0ec =
        | [<CompiledName("heading")>] Value

    /// Exact string literal type for "meter".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral5eff322a1bd4 =
        | [<CompiledName("meter")>] Value

    /// Exact string literal type for "rowgroup".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral60f68f2044f1 =
        | [<CompiledName("rowgroup")>] Value

    /// Exact string literal type for "row".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral634768dae147 =
        | [<CompiledName("row")>] Value

    /// Exact string literal type for "yAxis".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral6633baa8668f =
        | [<CompiledName("yAxis")>] Value

    /// Exact string literal type for "dialog".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral694018943365 =
        | [<CompiledName("dialog")>] Value

    /// Exact string literal type for "tab".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral7508386a2056 =
        | [<CompiledName("tab")>] Value

    /// Exact string literal type for "inverse".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral7705accd2694 =
        | [<CompiledName("inverse")>] Value

    /// Exact string literal type for "switch".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral78b49fb2cc2d =
        | [<CompiledName("switch")>] Value

    /// Exact string literal type for "visibility".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral7d2fb3da93a0 =
        | [<CompiledName("visibility")>] Value

    /// Exact string literal type for "linear".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral7f2fe580edb3 =
        | [<CompiledName("linear")>] Value

    /// Exact string literal type for "log".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral836ff184e7b4 =
        | [<CompiledName("log")>] Value

    /// Exact string literal type for "article".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral84393add8c48 =
        | [<CompiledName("article")>] Value

    /// Exact string literal type for "figure".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral889393fb69a5 =
        | [<CompiledName("figure")>] Value

    /// Exact string literal type for "banner".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral8c7ed2d9be59 =
        | [<CompiledName("banner")>] Value

    /// Exact string literal type for "indices".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral91744de3d4d8 =
        | [<CompiledName("indices")>] Value

    /// Exact string literal type for "combobox".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral92b4bb2797eb =
        | [<CompiledName("combobox")>] Value

    /// Exact string literal type for "contentinfo".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteral9b3294b2882a =
        | [<CompiledName("contentinfo")>] Value

    /// Exact string literal type for "list".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala330395cc0a5 =
        | [<CompiledName("list")>] Value

    /// Exact string literal type for "floor".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala3e1f4935b09 =
        | [<CompiledName("floor")>] Value

    /// Exact string literal type for "alertdialog".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala52734c22880 =
        | [<CompiledName("alertdialog")>] Value

    /// Exact string literal type for "attribute".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala92bfd02c450 =
        | [<CompiledName("attribute")>] Value

    /// Exact string literal type for "round".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterala97b0931730e =
        | [<CompiledName("round")>] Value

    /// Exact string literal type for "transform".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralaa214ea38326 =
        | [<CompiledName("transform")>] Value

    /// Exact string literal type for "group".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralad936fcbed63 =
        | [<CompiledName("group")>] Value

    /// Exact string literal type for "columnheader".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraladb0e4b720cb =
        | [<CompiledName("columnheader")>] Value

    /// Exact string literal type for "treeitem".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralafe1839cc6d9 =
        | [<CompiledName("treeitem")>] Value

    /// Exact string literal type for "img".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralb29814cf5792 =
        | [<CompiledName("img")>] Value

    /// Exact string literal type for "menubar".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralb451d42f5637 =
        | [<CompiledName("menubar")>] Value

    /// Exact string literal type for "Z".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralbbeebd879e1d =
        | [<CompiledName("Z")>] Value

    /// Exact string literal type for "decodeMeshDone".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralbe5728c055e1 =
        | [<CompiledName("decodeMeshDone")>] Value

    /// Exact string literal type for "presentation".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralbfac314fefdc =
        | [<CompiledName("presentation")>] Value

    /// Exact string literal type for "button".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralc3e2d78f3ff3 =
        | [<CompiledName("button")>] Value

    /// Exact string literal type for "region".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralc697d2981bf4 =
        | [<CompiledName("region")>] Value

    /// Exact string literal type for "feed".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralc8bc2586cdd8 =
        | [<CompiledName("feed")>] Value

    /// Exact string literal type for "tablist".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralcd3a6cfa3373 =
        | [<CompiledName("tablist")>] Value

    /// Exact string literal type for "timer".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralcd94ec90364d =
        | [<CompiledName("timer")>] Value

    /// Exact string literal type for "exponential".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterald075063d475b =
        | [<CompiledName("exponential")>] Value

    /// Exact string literal type for "toolbar".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterald45928fd48ad =
        | [<CompiledName("toolbar")>] Value

    /// Exact string literal type for "navigation".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterald70d5a7909ed =
        | [<CompiledName("navigation")>] Value

    /// Exact string literal type for "tabpanel".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraldc6cd41a7aaf =
        | [<CompiledName("tabpanel")>] Value

    /// Exact string literal type for "tree".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraldc9c5edb8b2d =
        | [<CompiledName("tree")>] Value

    /// Exact string literal type for "alert".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraldf905058dd67 =
        | [<CompiledName("alert")>] Value

    /// Exact string literal type for "slider".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterale0d98dc32438 =
        | [<CompiledName("slider")>] Value

    /// Exact string literal type for "".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiterale3b0c44298fc =
        | [<CompiledName("")>] Value

    /// Exact string literal type for "note".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteraledb465624291 =
        | [<CompiledName("note")>] Value

    /// Exact string literal type for "complementary".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralf3051005444c =
        | [<CompiledName("complementary")>] Value

    /// Exact string literal type for "spinbutton".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralf4a201309311 =
        | [<CompiledName("spinbutton")>] Value

    /// Exact string literal type for "encodeMeshSuccess".
    [<StringEnum; RequireQualifiedAccess>]
    type StringLiteralfcc89b3f4d1f =
        | [<CompiledName("encodeMeshSuccess")>] Value

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta21f2044e128Object =
        [<EmitIndexer>] abstract Item: ``kind``: string -> float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject8681f48cdb3dObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> string with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte519efeffba5Object =
        abstract ``backgroundColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb55cb151e7bcObject =
        [<EmitIndexer>] abstract Item: ``componentId``: string -> InlineObject6f954ab3fd3eObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte17e9af72fe0Object =
        abstract ``value``: float with get, set
        abstract ``touched``: bool with get, set
        abstract ``pressed``: bool with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta635a5848c40Object =
        abstract ``pulse``: System.Func<float, float, JS.Promise<bool>> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectcead31b74f8fObject =
        abstract ``src``: U2<string, BrowserImageBitmap> with get, set
        abstract ``estimatedRealWorldWidth``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4b84b3d5395bObject =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectb710d9eb561bObject =
        abstract ``type``: BabylonjsBindings.StringEnums.ComputeCompilationMessageType with get, set
        abstract ``text``: string with get, set
        abstract ``line``: float option with get, set
        abstract ``column``: float option with get, set
        abstract ``length``: float option with get, set
        abstract ``offset``: float option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject350439cd372aObject =
        abstract ``COMPLETION_STATUS_KHR``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta21bf015c053Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> obj with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject8f714ae92303Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> InlineObject8cfb1cd4bfe4Object with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4d78ed30f56dObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> InlineObjectbcd9ce4e2e0aObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta0383ee925a9Object =
        abstract ``force``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject672ce066a49aObject =
        abstract ``singleTile``: bool with get, set
        abstract ``longName``: bool with get, set
        abstract ``deepFormat``: bool with get, set
        abstract ``multiPart``: bool with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte6832153d51cObject =
        abstract ``xMin``: float with get, set
        abstract ``xMax``: float with get, set
        abstract ``yMin``: float with get, set
        abstract ``yMax``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectf9136a0bdd3aObject =
        abstract ``isBinary``: bool with get
        abstract ``mimeType``: string option with get

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject4f1820232dd6Object =
        abstract ``url``: string with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecte60cc9a00305Object =
        abstract ``yMax``: float with get, set
        abstract ``yMin``: float with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjecta5f9699c9ae7Object =
        [<EmitIndexer>] abstract Item: ``kind``: string -> JS.Float32Array with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject5839704047beObject<'T> =
        abstract ``mask``: float option with get, set
        abstract ``insertFirst``: bool option with get, set
        abstract ``scope``: obj option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectedc17de1126fObject =
        abstract ``backgroundColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set
        abstract ``disposeOnClose``: bool option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type MappedObject582662fc4f76 =
        abstract ``abort``: System.Action<Browser.Types.Event option> with get, set
        abstract ``animationcancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``animationend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``animationiteration``: System.Action<Browser.Types.Event option> with get, set
        abstract ``animationstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``auxclick``: System.Action<Browser.Types.Event option> with get, set
        abstract ``beforeinput``: System.Action<Browser.Types.Event option> with get, set
        abstract ``beforematch``: System.Action<Browser.Types.Event option> with get, set
        abstract ``beforetoggle``: System.Action<Browser.Types.Event option> with get, set
        abstract ``blur``: System.Action<Browser.Types.Event option> with get, set
        abstract ``cancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``canplay``: System.Action<Browser.Types.Event option> with get, set
        abstract ``canplaythrough``: System.Action<Browser.Types.Event option> with get, set
        abstract ``change``: System.Action<Browser.Types.Event option> with get, set
        abstract ``click``: System.Action<Browser.Types.Event option> with get, set
        abstract ``close``: System.Action<Browser.Types.Event option> with get, set
        abstract ``compositionend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``compositionstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``compositionupdate``: System.Action<Browser.Types.Event option> with get, set
        abstract ``contextlost``: System.Action<Browser.Types.Event option> with get, set
        abstract ``contextmenu``: System.Action<Browser.Types.Event option> with get, set
        abstract ``contextrestored``: System.Action<Browser.Types.Event option> with get, set
        abstract ``copy``: System.Action<Browser.Types.Event option> with get, set
        abstract ``cuechange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``cut``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dblclick``: System.Action<Browser.Types.Event option> with get, set
        abstract ``drag``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragenter``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragleave``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragover``: System.Action<Browser.Types.Event option> with get, set
        abstract ``dragstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``drop``: System.Action<Browser.Types.Event option> with get, set
        abstract ``durationchange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``emptied``: System.Action<Browser.Types.Event option> with get, set
        abstract ``ended``: System.Action<Browser.Types.Event option> with get, set
        abstract ``error``: System.Action<Browser.Types.Event option> with get, set
        abstract ``focus``: System.Action<Browser.Types.Event option> with get, set
        abstract ``focusin``: System.Action<Browser.Types.Event option> with get, set
        abstract ``focusout``: System.Action<Browser.Types.Event option> with get, set
        abstract ``formdata``: System.Action<Browser.Types.Event option> with get, set
        abstract ``fullscreenchange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``fullscreenerror``: System.Action<Browser.Types.Event option> with get, set
        abstract ``gotpointercapture``: System.Action<Browser.Types.Event option> with get, set
        abstract ``input``: System.Action<Browser.Types.Event option> with get, set
        abstract ``invalid``: System.Action<Browser.Types.Event option> with get, set
        abstract ``keydown``: System.Action<Browser.Types.Event option> with get, set
        abstract ``keypress``: System.Action<Browser.Types.Event option> with get, set
        abstract ``keyup``: System.Action<Browser.Types.Event option> with get, set
        abstract ``load``: System.Action<Browser.Types.Event option> with get, set
        abstract ``loadeddata``: System.Action<Browser.Types.Event option> with get, set
        abstract ``loadedmetadata``: System.Action<Browser.Types.Event option> with get, set
        abstract ``loadstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``lostpointercapture``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mousedown``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseenter``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseleave``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mousemove``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseout``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseover``: System.Action<Browser.Types.Event option> with get, set
        abstract ``mouseup``: System.Action<Browser.Types.Event option> with get, set
        abstract ``paste``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pause``: System.Action<Browser.Types.Event option> with get, set
        abstract ``play``: System.Action<Browser.Types.Event option> with get, set
        abstract ``playing``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointercancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerdown``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerenter``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerleave``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointermove``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerout``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerover``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerrawupdate``: System.Action<Browser.Types.Event option> with get, set
        abstract ``pointerup``: System.Action<Browser.Types.Event option> with get, set
        abstract ``progress``: System.Action<Browser.Types.Event option> with get, set
        abstract ``ratechange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``reset``: System.Action<Browser.Types.Event option> with get, set
        abstract ``resize``: System.Action<Browser.Types.Event option> with get, set
        abstract ``scroll``: System.Action<Browser.Types.Event option> with get, set
        abstract ``scrollend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``securitypolicyviolation``: System.Action<Browser.Types.Event option> with get, set
        abstract ``seeked``: System.Action<Browser.Types.Event option> with get, set
        abstract ``seeking``: System.Action<Browser.Types.Event option> with get, set
        abstract ``select``: System.Action<Browser.Types.Event option> with get, set
        abstract ``selectionchange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``selectstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``slotchange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``stalled``: System.Action<Browser.Types.Event option> with get, set
        abstract ``submit``: System.Action<Browser.Types.Event option> with get, set
        abstract ``suspend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``timeupdate``: System.Action<Browser.Types.Event option> with get, set
        abstract ``toggle``: System.Action<Browser.Types.Event option> with get, set
        abstract ``touchcancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``touchend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``touchmove``: System.Action<Browser.Types.Event option> with get, set
        abstract ``touchstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``transitioncancel``: System.Action<Browser.Types.Event option> with get, set
        abstract ``transitionend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``transitionrun``: System.Action<Browser.Types.Event option> with get, set
        abstract ``transitionstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``volumechange``: System.Action<Browser.Types.Event option> with get, set
        abstract ``waiting``: System.Action<Browser.Types.Event option> with get, set
        abstract ``webkitanimationend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``webkitanimationiteration``: System.Action<Browser.Types.Event option> with get, set
        abstract ``webkitanimationstart``: System.Action<Browser.Types.Event option> with get, set
        abstract ``webkittransitionend``: System.Action<Browser.Types.Event option> with get, set
        abstract ``wheel``: System.Action<Browser.Types.Event option> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type MappedObjectb2cbdb655794 =
        abstract ``aria-activedescendant``: obj with get, set
        abstract ``aria-atomic``: obj with get, set
        abstract ``aria-autocomplete``: obj with get, set
        abstract ``aria-busy``: obj with get, set
        abstract ``aria-checked``: obj with get, set
        abstract ``aria-colcount``: obj with get, set
        abstract ``aria-colindex``: obj with get, set
        abstract ``aria-colspan``: obj with get, set
        abstract ``aria-controls``: obj with get, set
        abstract ``aria-describedby``: obj with get, set
        abstract ``aria-description``: obj with get, set
        abstract ``aria-details``: obj with get, set
        abstract ``aria-disabled``: obj with get, set
        abstract ``aria-dropeffect``: obj with get, set
        abstract ``aria-errormessage``: obj with get, set
        abstract ``aria-expanded``: obj with get, set
        abstract ``aria-flowto``: obj with get, set
        abstract ``aria-grabbed``: obj with get, set
        abstract ``aria-haspopup``: obj with get, set
        abstract ``aria-hidden``: obj with get, set
        abstract ``aria-invalid``: obj with get, set
        abstract ``aria-label``: obj with get, set
        abstract ``aria-labelledby``: obj with get, set
        abstract ``aria-level``: obj with get, set
        abstract ``aria-live``: obj with get, set
        abstract ``aria-modal``: obj with get, set
        abstract ``aria-multiline``: obj with get, set
        abstract ``aria-multiselectable``: obj with get, set
        abstract ``aria-orientation``: obj with get, set
        abstract ``aria-owns``: obj with get, set
        abstract ``aria-placeholder``: obj with get, set
        abstract ``aria-posinset``: obj with get, set
        abstract ``aria-pressed``: obj with get, set
        abstract ``aria-readonly``: obj with get, set
        abstract ``aria-relevant``: obj with get, set
        abstract ``aria-required``: obj with get, set
        abstract ``aria-rowcount``: obj with get, set
        abstract ``aria-rowindex``: obj with get, set
        abstract ``aria-rowspan``: obj with get, set
        abstract ``aria-selected``: obj with get, set
        abstract ``aria-setsize``: obj with get, set
        abstract ``aria-sort``: obj with get, set
        abstract ``aria-valuemax``: obj with get, set
        abstract ``aria-valuemin``: obj with get, set
        abstract ``aria-valuenow``: obj with get, set
        abstract ``aria-valuetext``: obj with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject93dc13e6dc30Object =
        abstract ``eventData``: bool with get, set
        abstract ``id``: string with get, set
        abstract ``type``: string with get, set
        abstract ``value``: obj option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectff2afb4ca968Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> U3<float, string, bool> option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectafdc7fcd70d1Object =
        abstract ``vertexCode``: string with get, set
        abstract ``fragmentCode``: string with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject1f7e3b7e13b4Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGlyphData with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectc6343ebc447eObject =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFTechniqueParameter with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject249788b2ccc7Object =
        [<EmitIndexer>] abstract Item: ``key``: string -> IGLTFAnimationSampler with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject6f954ab3fd3eObject =
        abstract ``type``: BabylonjsBindings.StringEnums.MotionControllerComponentType with get, set
        abstract ``gamepadIndices``: InlineObject35c0cd1bec32Object with get, set
        abstract ``rootNodeName``: string with get, set
        abstract ``visualResponses``: InlineObjectd24882c70775Object with get, set
        abstract ``touchPointNodeName``: string option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject8cfb1cd4bfe4Object =
        abstract ``type``: BabylonjsBindings.SimpleClasses.RichType<obj> with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectbcd9ce4e2e0aObject =
        abstract ``type``: BabylonjsBindings.SimpleClasses.RichType<obj> with get, set
        abstract ``value``: obj option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObject35c0cd1bec32Object =
        abstract ``button``: float option with get, set
        abstract ``xAxis``: float option with get, set
        abstract ``yAxis``: float option with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectd24882c70775Object =
        [<EmitIndexer>] abstract Item: ``stateKey``: string -> InlineObjectbee9436f1edeObject with get, set

    /// Exact inline object used by a Babylon interface signature.
    [<AllowNullLiteral>]
    type InlineObjectbee9436f1edeObject =
        abstract ``componentProperty``: U4<StringLiteral49563714cd71, StringLiteral6633baa8668f, StringLiteralc3e2d78f3ff3, StringLiteral4ba69735ca53> with get, set
        abstract ``states``: ResizeArray<BabylonjsBindings.StringEnums.MotionControllerComponentStateType> with get, set
        abstract ``valueNodeProperty``: U2<StringLiteralaa214ea38326, StringLiteral7d2fb3da93a0> with get, set
        abstract ``valueNodeName``: string option with get, set
        abstract ``minNodeName``: string option with get, set
        abstract ``maxNodeName``: string option with get, set

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type _IAnimationState =
        abstract ``key``: float with get, set
        abstract ``repeatCount``: float with get, set
        abstract ``workValue``: obj option with get, set
        abstract ``loopMode``: float option with get, set
        abstract ``offsetValue``: obj option with get, set
        abstract ``highLimitValue``: obj option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type _ISamplerData =
        abstract ``noMipMaps``: bool with get, set
        abstract ``samplingMode``: float with get, set
        abstract ``wrapU``: float with get, set
        abstract ``wrapV``: float with get, set

    /// @babylonjs/core/Engines/Processors/shaderProcessingOptions
    [<AllowNullLiteral>]
    type _IShaderProcessingContext =
        abstract ``vertexBufferKindToNumberOfComponents``: InlineObjecta21f2044e128Object option with get, set

    /// @babylonjs/core/Misc/workerPool
    [<AllowNullLiteral>]
    type AutoReleaseWorkerPoolOptions =
        abstract ``idleTimeElapsedBeforeRelease``: float with get, set

    /// @babylonjs/core/Behaviors/behavior
    [<AllowNullLiteral>]
    type Behavior<'T> =
        abstract ``name``: string with get, set
        abstract ``init``: unit -> unit
        abstract ``attach``: ``target``: 'T -> unit
        abstract ``detach``: unit -> unit
        abstract ``attachedNode``: 'T option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type BufferImageData =
        abstract ``length``: float with get, set
        abstract ``position``: float with get, set

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    [<AllowNullLiteral>]
    type ComputeCompilationMessages =
        abstract ``numErrors``: float with get, set
        abstract ``messages``: ResizeArray<InlineObjectb710d9eb561bObject> with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type CreateEnvTextureOptions =
        abstract ``imageType``: string option with get, set
        abstract ``imageQuality``: float option with get, set
        abstract ``disableIrradianceTexture``: bool option with get, set

    /// @babylonjs/core/Misc/HighDynamicRange/panoramaToCubemap
    [<AllowNullLiteral>]
    type CubeMapInfo =
        abstract ``front``: JS.ArrayBufferView option with get, set
        abstract ``back``: JS.ArrayBufferView option with get, set
        abstract ``left``: JS.ArrayBufferView option with get, set
        abstract ``right``: JS.ArrayBufferView option with get, set
        abstract ``up``: JS.ArrayBufferView option with get, set
        abstract ``down``: JS.ArrayBufferView option with get, set
        abstract ``size``: float with get, set
        abstract ``format``: float with get, set
        abstract ``type``: float with get, set
        abstract ``gammaSpace``: bool with get, set

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type DataCursor =
        abstract ``value``: float with get, set

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    [<AllowNullLiteral>]
    type DepthTextureCreationOptions =
        abstract ``generateStencil``: bool option with get, set
        abstract ``bilinearFiltering``: bool option with get, set
        abstract ``comparisonFunction``: float option with get, set
        abstract ``isCube``: bool option with get, set
        abstract ``samples``: float option with get, set
        abstract ``depthTextureFormat``: float option with get, set
        abstract ``label``: string option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type DOMMatrix =
        abstract ``is2D``: bool with get, set
        abstract ``isIdentity``: bool with get, set
        abstract ``a``: float with get, set
        abstract ``b``: float with get, set
        abstract ``c``: float with get, set
        abstract ``d``: float with get, set
        abstract ``e``: float with get, set
        abstract ``f``: float with get, set
        abstract ``m11``: float with get, set
        abstract ``m12``: float with get, set
        abstract ``m13``: float with get, set
        abstract ``m14``: float with get, set
        abstract ``m21``: float with get, set
        abstract ``m22``: float with get, set
        abstract ``m23``: float with get, set
        abstract ``m24``: float with get, set
        abstract ``m31``: float with get, set
        abstract ``m32``: float with get, set
        abstract ``m33``: float with get, set
        abstract ``m34``: float with get, set
        abstract ``m41``: float with get, set
        abstract ``m42``: float with get, set
        abstract ``m43``: float with get, set
        abstract ``m44``: float with get, set

    /// @babylonjs/core/Engines/engineCapabilities
    [<AllowNullLiteral>]
    type EngineCapabilities =
        abstract ``maxTexturesImageUnits``: float with get, set
        abstract ``maxVertexTextureImageUnits``: float with get, set
        abstract ``maxCombinedTexturesImageUnits``: float with get, set
        abstract ``maxTextureSize``: float with get, set
        abstract ``maxSamples``: float option with get, set
        abstract ``maxDrawBuffers``: float option with get, set
        abstract ``maxCubemapTextureSize``: float with get, set
        abstract ``maxRenderTextureSize``: float with get, set
        abstract ``maxVertexAttribs``: float with get, set
        abstract ``maxVaryingVectors``: float with get, set
        abstract ``maxVertexUniformVectors``: float with get, set
        abstract ``maxFragmentUniformVectors``: float with get, set
        abstract ``shaderFloatPrecision``: float with get, set
        abstract ``standardDerivatives``: bool with get, set
        abstract ``s3tc``: BrowserWebGLCompressedTextureS3tc option with get, set
        abstract ``s3tc_srgb``: BrowserWebGLCompressedTextureS3tcSrgb option with get, set
        abstract ``pvrtc``: obj with get, set
        abstract ``etc1``: obj with get, set
        abstract ``etc2``: obj with get, set
        abstract ``astc``: obj with get, set
        abstract ``bptc``: obj with get, set
        abstract ``textureFloat``: bool with get, set
        abstract ``vertexArrayObject``: bool with get, set
        abstract ``textureAnisotropicFilterExtension``: BrowserExtTextureFilterAnisotropic option with get, set
        abstract ``maxAnisotropy``: float with get, set
        abstract ``instancedArrays``: bool with get, set
        abstract ``uintIndices``: bool with get, set
        abstract ``highPrecisionShaderSupported``: bool with get, set
        abstract ``fragmentDepthSupported``: bool with get, set
        abstract ``textureFloatLinearFiltering``: bool with get, set
        abstract ``textureFloatRender``: bool with get, set
        abstract ``textureHalfFloat``: bool with get, set
        abstract ``textureHalfFloatLinearFiltering``: bool with get, set
        abstract ``textureHalfFloatRender``: bool with get, set
        abstract ``textureLOD``: bool with get, set
        abstract ``texelFetch``: bool with get, set
        abstract ``drawBuffersExtension``: bool with get, set
        abstract ``depthTextureExtension``: bool with get, set
        abstract ``colorBufferFloat``: bool with get, set
        abstract ``blendFloat``: bool with get, set
        abstract ``colorBufferHalfFloat``: bool option with get, set
        abstract ``timerQuery``: BrowserExtDisjointTimerQuery option with get, set
        abstract ``canUseTimestampForTimerQuery``: bool with get, set
        abstract ``supportOcclusionQuery``: bool with get, set
        abstract ``multiview``: obj option with get, set
        abstract ``oculusMultiview``: obj option with get, set
        abstract ``parallelShaderCompile``: InlineObject350439cd372aObject option with get, set
        abstract ``maxMSAASamples``: float with get, set
        abstract ``blendMinMax``: bool with get, set
        abstract ``canUseGLInstanceID``: bool with get, set
        abstract ``canUseGLVertexID``: bool with get, set
        abstract ``supportComputeShaders``: bool with get, set
        abstract ``supportSRGBBuffers``: bool with get, set
        abstract ``supportTransformFeedbacks``: bool with get, set
        abstract ``textureMaxLevel``: bool with get, set
        abstract ``texture2DArrayMaxLayerCount``: float with get, set
        abstract ``disableMorphTargetTexture``: bool with get, set
        abstract ``supportFloatTexturesResolve``: bool with get, set
        abstract ``rg11b10ufColorRenderable``: bool with get, set
        abstract ``textureNorm16``: bool with get, set
        abstract ``blendParametersPerTarget``: bool with get, set
        abstract ``dualSourceBlending``: bool with get, set
        abstract ``supportReadWriteStorageTextures``: bool with get, set

    /// @babylonjs/core/Engines/engineFeatures
    [<AllowNullLiteral>]
    type EngineFeatures =
        abstract ``forceBitmapOverHTMLImageElement``: bool with get, set
        abstract ``supportRenderAndCopyToLodForFloatTextures``: bool with get, set
        abstract ``supportDepthStencilTexture``: bool with get, set
        abstract ``supportShadowSamplers``: bool with get, set
        abstract ``uniformBufferHardCheckMatrix``: bool with get, set
        abstract ``allowTexturePrefiltering``: bool with get, set
        abstract ``trackUbosInFrame``: bool with get, set
        abstract ``checkUbosContentBeforeUpload``: bool with get, set
        abstract ``supportCSM``: bool with get, set
        abstract ``basisNeedsPOT``: bool with get, set
        abstract ``support3DTextures``: bool with get, set
        abstract ``needTypeSuffixInShaderConstants``: bool with get, set
        abstract ``supportMSAA``: bool with get, set
        abstract ``supportSSAO2``: bool with get, set
        abstract ``supportIBLShadows``: bool with get, set
        abstract ``supportExtendedTextureFormats``: bool with get, set
        abstract ``supportSwitchCaseInShader``: bool with get, set
        abstract ``supportSyncTextureRead``: bool with get, set
        abstract ``needsInvertingBitmap``: bool with get, set
        abstract ``useUBOBindingCache``: bool with get, set
        abstract ``needShaderCodeInlining``: bool with get, set
        abstract ``needToAlwaysBindUniformBuffers``: bool with get, set
        abstract ``supportRenderPasses``: bool with get, set
        abstract ``supportSpriteInstancing``: bool with get, set
        abstract ``forceVertexBufferStrideAndOffsetMultiple4Bytes``: bool with get, set
        abstract ``_checkNonFloatVertexBuffersDontRecreatePipelineContext``: bool with get, set

    /// @babylonjs/loaders/FBX/fbxFileLoader.pure
    [<AllowNullLiteral>]
    type FBXFileLoaderOptions =
        abstract ``normalMapCoordinateSystem``: BabylonjsBindings.StringEnums.FBXNormalMapCoordinateSystem option with get, set

    /// Exact optional-property projection used by Babylon Partial<FBXFileLoaderOptions> signatures.
    [<AllowNullLiteral>]
    type PartialFBXFileLoaderOptions =
        abstract ``normalMapCoordinateSystem``: BabylonjsBindings.StringEnums.FBXNormalMapCoordinateSystem option with get, set

    /// @babylonjs/core/Gamepads/gamepad
    [<AllowNullLiteral>]
    type GamepadButtonChanges =
        abstract ``changed``: bool with get, set
        abstract ``pressChanged``: bool with get, set
        abstract ``touchChanged``: bool with get, set
        abstract ``valueChanged``: bool with get, set

    /// @babylonjs/core/Engines/webgpuEngine.pure
    [<AllowNullLiteral>]
    type GlslangOptions =
        abstract ``glslang``: obj option with get, set
        abstract ``jsPath``: string option with get, set
        abstract ``wasmPath``: string option with get, set

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineBaseMesh
    [<AllowNullLiteral>]
    type GreasedLinePointsOptions =
        abstract ``floatArrayStride``: float option with get, set

    /// @babylonjs/core/Physics/v2/Plugins/havokPlugin
    [<AllowNullLiteral>]
    type HavokPluginParameters =
        abstract ``maxQueryCollectorHits``: float option with get, set
        abstract ``floatingOriginWorldRadius``: float option with get, set

    /// @babylonjs/core/Misc/HighDynamicRange/hdr
    [<AllowNullLiteral>]
    type HDRInfo =
        abstract ``height``: float with get, set
        abstract ``width``: float with get, set
        abstract ``dataPosition``: float with get, set

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type HostInformation =
        abstract ``isMobile``: bool with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundOptionsBase =
        abstract ``autoplay``: bool with get, set
        abstract ``maxInstances``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundPlayOptionsBase =
        abstract ``loop``: bool with get, set
        abstract ``startOffset``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IAbstractSoundPlayOptionsBase> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractSoundPlayOptionsBase =
        abstract ``loop``: bool option with get, set
        abstract ``startOffset``: float option with get, set

    /// @babylonjs/core/IAccessibilityTag
    [<AllowNullLiteral>]
    type IAccessibilityTag =
        abstract ``description``: string option with get, set
        abstract ``eventHandler``: MappedObject582662fc4f76 option with get, set
        abstract ``role``: U2<U8<StringLiterald45928fd48ad, StringLiteral1fb691986729, StringLiteralc8bc2586cdd8, StringLiteral58a6d6801ae7, StringLiteralbfac314fefdc, StringLiteral140bedbf9c3f, StringLiteraledb465624291, StringLiteral1fe289205936>, U2<U8<StringLiteral84393add8c48, StringLiteral39d02b42938b, StringLiteraladb0e4b720cb, StringLiteral4c4ed1afbfda, StringLiteral333178788eae, StringLiteral43cc23fa52b8, StringLiteral889393fb69a5, StringLiteralad936fcbed63>, U2<U8<StringLiteral5e60ff5ac0ec, StringLiteralb29814cf5792, StringLiterala330395cc0a5, StringLiteral1bbc1b324415, StringLiteral5eff322a1bd4, StringLiteral634768dae147, StringLiteral60f68f2044f1, StringLiteral224f0009e42e>, U2<U8<StringLiteral080856f98d1e, StringLiteral0d4fc4a78d37, StringLiteral599f7703547e, StringLiteral255512839036, StringLiteral131ff8f4616b, StringLiterale0d98dc32438, StringLiteralf4a201309311, StringLiteral78b49fb2cc2d>, U2<U8<StringLiteral7508386a2056, StringLiteraldc6cd41a7aaf, StringLiteralafe1839cc6d9, StringLiteral92b4bb2797eb, StringLiteral398991009da1, StringLiteralb451d42f5637, StringLiteralcd3a6cfa3373, StringLiteraldc9c5edb8b2d>, U2<U8<StringLiteral189c7d737ca4, StringLiteral8c7ed2d9be59, StringLiteralf3051005444c, StringLiteral9b3294b2882a, StringLiteral07397d633f25, StringLiteral0d6e4079e367, StringLiterald70d5a7909ed, StringLiteralc697d2981bf4>, U8<StringLiteral241932906782, StringLiteraldf905058dd67, StringLiteral836ff184e7b4, StringLiteral0ada0c035439, StringLiteral073c1634c496, StringLiteralcd94ec90364d, StringLiterala52734c22880, StringLiteral694018943365>>>>>>> option with get, set
        abstract ``aria``: MappedObjectb2cbdb655794 option with get, set

    /// @babylonjs/core/Navigation/INavigationEngine
    [<AllowNullLiteral>]
    type IAgentParameters =
        abstract ``radius``: float with get, set
        abstract ``height``: float with get, set
        abstract ``maxAcceleration``: float with get, set
        abstract ``maxSpeed``: float with get, set
        abstract ``collisionQueryRange``: float with get, set
        abstract ``pathOptimizationRange``: float with get, set
        abstract ``separationWeight``: float with get, set
        abstract ``reachRadius``: float option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IArrayItem =
        abstract ``index``: float with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type IAttributeData =
        abstract ``kind``: string with get, set
        abstract ``data``: JS.ArrayBufferView with get, set
        abstract ``size``: float with get, set
        abstract ``byteOffset``: float with get, set
        abstract ``byteStride``: float with get, set
        abstract ``normalized``: bool with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractAudioAnalyzer
    [<AllowNullLiteral>]
    type IAudioAnalyzerOptions =
        abstract ``analyzerEnabled``: bool with get, set
        abstract ``analyzerFFTSize``: BabylonjsBindings.Enums.AudioAnalyzerFFTSizeType with get, set
        abstract ``analyzerMinDecibels``: float with get, set
        abstract ``analyzerMaxDecibels``: float with get, set
        abstract ``analyzerSmoothing``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IAudioAnalyzerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAudioAnalyzerOptions =
        abstract ``analyzerEnabled``: bool option with get, set
        abstract ``analyzerFFTSize``: BabylonjsBindings.Enums.AudioAnalyzerFFTSizeType option with get, set
        abstract ``analyzerMinDecibels``: float option with get, set
        abstract ``analyzerMaxDecibels``: float option with get, set
        abstract ``analyzerSmoothing``: float option with get, set

    /// @babylonjs/core/Audio/Interfaces/IAudioEngineOptions
    [<AllowNullLiteral>]
    type IAudioEngineOptions =
        abstract ``audioContext``: BrowserAudioContext option with get, set
        abstract ``audioDestination``: U2<BrowserAudioDestinationNode, BrowserMediaStreamAudioDestinationNode> option with get, set

    /// @babylonjs/core/AudioV2/audioParameter
    [<AllowNullLiteral>]
    type IAudioParameterRampOptions =
        abstract ``duration``: float with get, set
        abstract ``shape``: BabylonjsBindings.StringEnums.AudioParameterRampShape with get, set

    /// Exact optional-property projection used by Babylon Partial<IAudioParameterRampOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAudioParameterRampOptions =
        abstract ``duration``: float option with get, set
        abstract ``shape``: BabylonjsBindings.StringEnums.AudioParameterRampShape option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type ICanvasGradient =
        abstract ``addColorStop``: ``offset``: float * ``color``: string -> unit

    /// Exact readonly projection of IColor3Like used by Babylon DeepImmutable<IColor3Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIColor3Like =
        abstract ``r``: BabylonjsBindings.TypeAliases.float with get
        abstract ``g``: BabylonjsBindings.TypeAliases.float with get
        abstract ``b``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IColor3Like =
        inherit DeepImmutableIColor3Like
        abstract ``r``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``g``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``b``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type ICompressedFormatCapabilities =
        abstract ``astc``: bool option with get, set
        abstract ``bptc``: bool option with get, set
        abstract ``s3tc``: bool option with get, set
        abstract ``pvrtc``: bool option with get, set
        abstract ``etc2``: bool option with get, set
        abstract ``etc1``: bool option with get, set

    /// @babylonjs/core/Compute/IComputeContext
    [<AllowNullLiteral>]
    type IComputeContext =
        abstract ``clear``: unit -> unit

    /// @babylonjs/core/Compute/IComputePipelineContext
    [<AllowNullLiteral>]
    type IComputePipelineContext =
        abstract ``isAsync``: bool with get, set
        abstract ``isReady``: bool with get, set
        abstract ``_name``: string option with get, set
        abstract ``_getComputeShaderCode``: unit -> string option
        abstract ``dispose``: unit -> unit

    /// Function-valued IComputeShaderOptions.processFinalCode property.
    [<AllowNullLiteral>]
    type IComputeShaderOptionsProcessFinalCodeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string -> string

    /// @babylonjs/core/Compute/computeShader.pure
    [<AllowNullLiteral>]
    type IComputeShaderOptions =
        abstract ``bindingsMapping``: BabylonjsBindings.TypeAliases.ComputeBindingMapping with get, set
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``entryPoint``: string option with get, set
        abstract ``processFinalCode``: IComputeShaderOptionsProcessFinalCodeCallback option with get, set
        abstract ``useExplicitComputePipelineLayout``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<IComputeShaderOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIComputeShaderOptions =
        abstract ``bindingsMapping``: BabylonjsBindings.TypeAliases.ComputeBindingMapping option with get, set
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``entryPoint``: string option with get, set
        abstract ``processFinalCode``: IComputeShaderOptionsProcessFinalCodeCallback option with get, set
        abstract ``useExplicitComputePipelineLayout``: bool option with get, set

    /// @babylonjs/core/FlowGraph/flowGraphConnection
    [<AllowNullLiteral>]
    type IConnectable =
        abstract ``uniqueId``: string with get, set
        abstract ``_connectedPoint``: ResizeArray<IConnectable> with get, set
        abstract ``_isSingularConnection``: unit -> bool
        abstract ``_connectionType``: BabylonjsBindings.Enums.FlowGraphConnectionType with get, set
        abstract ``connectTo``: ``point``: IConnectable -> unit

    /// @babylonjs/core/Materials/Textures/textureMerger
    [<AllowNullLiteral>]
    type IConstantChannelInput =
        abstract ``value``: float with get, set

    /// @babylonjs/core/Misc/decorators.serialization
    [<AllowNullLiteral>]
    type ICopySourceOptions =
        abstract ``cloneTexturesOnlyOnce``: bool option with get, set

    /// @babylonjs/core/scene.pure
    [<AllowNullLiteral>]
    type ICreateSceneUboOptions =
        abstract ``trackUBOsInFrame``: bool option with get, set
        abstract ``forceMono``: bool option with get, set

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type ICreateTexture2DArrayFromKTX2Options =
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``invertY``: bool option with get, set

    /// @babylonjs/core/Meshes/csg2
    [<AllowNullLiteral>]
    type ICSG2Options =
        abstract ``manifoldUrl``: string option with get, set
        abstract ``manifoldInstance``: obj with get, set
        abstract ``manifoldMeshInstance``: obj with get, set

    /// Exact optional-property projection used by Babylon Partial<ICSG2Options> signatures.
    [<AllowNullLiteral>]
    type PartialICSG2Options =
        abstract ``manifoldUrl``: string option with get, set
        abstract ``manifoldInstance``: obj option with get, set
        abstract ``manifoldMeshInstance``: obj option with get, set

    /// Function-valued ICubeTextureCreationOptions.onLoad property.
    [<AllowNullLiteral>]
    type ICubeTextureCreationOptionsOnLoadCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued ICubeTextureCreationOptions.onError property.
    [<AllowNullLiteral>]
    type ICubeTextureCreationOptionsOnErrorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``message``: string * ?``exception``: obj -> unit

    /// @babylonjs/core/Materials/Textures/cubeTexture.pure
    [<AllowNullLiteral>]
    type ICubeTextureCreationOptions =
        abstract ``extensions``: ResizeArray<string> option with get, set
        abstract ``noMipmap``: bool option with get, set
        abstract ``files``: ResizeArray<string> option with get, set
        abstract ``buffer``: JS.ArrayBufferView option with get, set
        abstract ``onLoad``: ICubeTextureCreationOptionsOnLoadCallback option with get, set
        abstract ``onError``: ICubeTextureCreationOptionsOnErrorCallback option with get, set
        abstract ``format``: float option with get, set
        abstract ``prefiltered``: bool option with get, set
        abstract ``forcedExtension``: obj option with get, set
        abstract ``createPolynomials``: bool option with get, set
        abstract ``lodScale``: float option with get, set
        abstract ``lodOffset``: float option with get, set
        abstract ``loaderOptions``: obj option with get, set
        abstract ``useSRGBBuffer``: bool option with get, set
        abstract ``sphericalPolynomialTargetSize``: float option with get, set

    /// @babylonjs/core/Misc/customAnimationFrameRequester
    [<AllowNullLiteral>]
    type ICustomAnimationFrameRequester =
        abstract ``renderFunction``: System.Delegate option with get, set
        abstract ``requestAnimationFrame``: System.Delegate with get, set
        abstract ``requestID``: float option with get, set
        abstract ``cancelAnimationFrame``: System.Delegate option with get, set

    /// @babylonjs/core/Materials/material.pure
    [<AllowNullLiteral>]
    type ICustomShaderNameResolveOptions =
        abstract ``processFinalCode``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set

    /// @babylonjs/core/Lights/Shadows/shadowGenerator
    [<AllowNullLiteral>]
    type ICustomShaderOptions =
        abstract ``shaderName``: string with get, set
        abstract ``attributes``: ResizeArray<string> option with get, set
        abstract ``uniforms``: ResizeArray<string> option with get, set
        abstract ``samplers``: ResizeArray<string> option with get, set
        abstract ``defines``: ResizeArray<string> option with get, set

    /// @babylonjs/core/Misc/dataReader
    [<AllowNullLiteral>]
    type IDataBuffer =
        abstract ``readAsync``: ``byteOffset``: float * ``byteLength``: float -> JS.Promise<JS.ArrayBufferView>
        abstract ``byteLength``: float with get

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<AllowNullLiteral>]
    type IDecodeChannel =
        [<EmitIndexer>] abstract Item: ``name``: string -> float with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type IDecodeMeshDoneMessage =
        abstract ``id``: StringLiteralbe5728c055e1 with get, set
        abstract ``totalVertices``: float with get, set

    /// @babylonjs/core/scene.pure
    [<AllowNullLiteral>]
    type IDisposable =
        abstract ``dispose``: unit -> unit

    /// @babylonjs/core/Engines/IDrawContext
    [<AllowNullLiteral>]
    type IDrawContext =
        abstract ``uniqueId``: float with get, set
        abstract ``useInstancing``: bool with get, set
        abstract ``enableIndirectDraw``: bool with get, set
        abstract ``indirectDrawBuffer``: BrowserGPUBuffer option with get, set
        abstract ``setIndirectData``: ``indexOrVertexCount``: float * ``instanceCount``: float * ``firstIndexOrVertex``: float * ?``forceUpdate``: bool -> unit
        abstract ``reset``: unit -> unit
        abstract ``dispose``: unit -> unit

    /// @babylonjs/core/Animations/easing
    [<AllowNullLiteral>]
    type IEasingFunction =
        abstract ``ease``: ``gradient``: float -> float

    /// @babylonjs/core/Rendering/edgesRenderer.pure
    [<AllowNullLiteral>]
    type IEdgesRendererOptions =
        abstract ``useAlternateEdgeFinder``: bool option with get, set
        abstract ``useFastVertexMerger``: bool option with get, set
        abstract ``epsilonVertexMerge``: float option with get, set
        abstract ``applyTessellation``: bool option with get, set
        abstract ``epsilonVertexAligned``: float option with get, set
        abstract ``removeDegeneratedTriangles``: bool option with get, set

    /// @babylonjs/core/Decorators/nodeDecorator
    [<AllowNullLiteral>]
    type IEditablePropertyListOption =
        abstract ``label``: string with get, set
        abstract ``value``: float with get, set

    /// @babylonjs/core/Materials/effectRenderer.pure
    [<AllowNullLiteral>]
    type IEffectRendererOptions =
        abstract ``positions``: ResizeArray<float> option with get, set
        abstract ``indices``: ResizeArray<float> option with get, set

    /// Exact readonly projection of IEllipsoidLike used by Babylon DeepImmutable<IEllipsoidLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIEllipsoidLike =
        abstract ``semiMajorAxis``: float with get
        abstract ``semiMinorAxis``: float with get
        abstract ``flattening``: float with get
        abstract ``firstEccentricitySquared``: float with get
        abstract ``secondEccentricitySquared``: float with get

    /// @babylonjs/core/Maths/math.geospatial
    [<AllowNullLiteral>]
    type IEllipsoidLike =
        inherit DeepImmutableIEllipsoidLike
        abstract ``semiMajorAxis``: float with get, set
        abstract ``semiMinorAxis``: float with get, set
        abstract ``flattening``: float with get, set
        abstract ``firstEccentricitySquared``: float with get, set
        abstract ``secondEccentricitySquared``: float with get, set

    /// @babylonjs/core/Meshes/Compression/dracoEncoder.types
    [<AllowNullLiteral>]
    type IEncodeErrorMessage =
        abstract ``id``: StringLiteral56b69f7fdd12 with get, set
        abstract ``errorMessage``: string with get, set

    /// Function-valued IExplorerExtensibilityOption.action property.
    [<AllowNullLiteral>]
    type IExplorerExtensibilityOptionActionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``entity``: obj -> unit

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IExplorerExtensibilityOption =
        abstract ``label``: string with get, set
        abstract ``action``: IExplorerExtensibilityOptionActionCallback with get, set
        abstract ``keepOpenAfterClick``: bool option with get, set

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<AllowNullLiteral>]
    type IEXRCHannel =
        abstract ``name``: string with get, set
        abstract ``pixelType``: float with get, set

    /// Function-valued IFileRequest.abort property.
    [<AllowNullLiteral>]
    type IFileRequestAbortCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Misc/fileRequest
    [<AllowNullLiteral>]
    type IFileRequest =
        abstract ``onCompleteObservable``: BabylonjsBindings.SimpleClasses.Observable<IFileRequest> with get, set
        abstract ``abort``: IFileRequestAbortCallback with get, set

    /// @babylonjs/core/FlowGraph/flowGraphBlock
    [<AllowNullLiteral>]
    type IFlowGraphBlockConfiguration =
        abstract ``name``: string option with get, set
        [<EmitIndexer>] abstract Item: ``extraPropertyKey``: string -> obj with get, set

    /// @babylonjs/core/FlowGraph/flowGraphSceneEventCoordinator
    [<AllowNullLiteral>]
    type IFlowGraphEventTrigger =
        abstract ``type``: BabylonjsBindings.StringEnums.FlowGraphEventType with get, set
        abstract ``payload``: obj option with get, set

    /// @babylonjs/core/FlowGraph/flowGraphLogger
    [<AllowNullLiteral>]
    type IFlowGraphLogItem =
        abstract ``time``: float option with get, set
        abstract ``className``: string with get, set
        abstract ``uniqueId``: string with get, set
        abstract ``action``: BabylonjsBindings.StringEnums.FlowGraphAction with get, set
        abstract ``payload``: obj option with get, set

    /// @babylonjs/core/FlowGraph/CustomTypes/flowGraphMatrix
    [<AllowNullLiteral>]
    type IFlowGraphMatrix<'VectorType> =
        abstract ``m``: ResizeArray<float> with get, set
        abstract ``transformVector``: ``v``: 'VectorType -> 'VectorType
        abstract ``transformVectorToRef``: ``v``: 'VectorType * ``result``: 'VectorType -> 'VectorType
        abstract ``asArray``: unit -> ResizeArray<float>
        abstract ``toArray``: ``emptyArray``: ResizeArray<float> -> ResizeArray<float>
        abstract ``fromArray``: ``array``: ResizeArray<float> -> IFlowGraphMatrix<'VectorType>
        abstract ``multiplyToRef``: ``other``: IFlowGraphMatrix<'VectorType> * ``result``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``multiply``: ``other``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``divideToRef``: ``other``: IFlowGraphMatrix<'VectorType> * ``result``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``divide``: ``other``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``addToRef``: ``other``: IFlowGraphMatrix<'VectorType> * ``result``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``add``: ``other``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``subtractToRef``: ``other``: IFlowGraphMatrix<'VectorType> * ``result``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``subtract``: ``other``: IFlowGraphMatrix<'VectorType> -> IFlowGraphMatrix<'VectorType>
        abstract ``transpose``: unit -> IFlowGraphMatrix<'VectorType>
        abstract ``determinant``: unit -> float
        abstract ``inverse``: unit -> IFlowGraphMatrix<'VectorType>
        abstract ``getClassName``: unit -> string
        abstract ``equals``: ``other``: IFlowGraphMatrix<'VectorType> * ?``epsilon``: float -> bool

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphSceneTickEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphOnTickEventPayload =
        abstract ``timeSinceStart``: float with get, set
        abstract ``deltaTime``: float with get, set

    /// @babylonjs/core/FrameGraph/Tasks/Rendering/geometryRendererTask
    [<AllowNullLiteral>]
    type IFrameGraphGeometryRendererTextureDescription =
        abstract ``type``: float with get, set
        abstract ``textureType``: float with get, set
        abstract ``textureFormat``: float with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type IGaussianSplattingSplatRange =
        abstract ``offset``: float with get, set
        abstract ``count``: float with get, set

    /// @babylonjs/loaders/SPLAT/gaussianSplattingStream
    [<AllowNullLiteral>]
    type IGaussianSplattingStreamOptions =
        abstract ``deflateURL``: string option with get, set
        abstract ``fflate``: obj option with get, set
        abstract ``debugDisplay``: bool option with get, set
        abstract ``debugLodSource``: BabylonjsBindings.StringEnums.GaussianSplattingStreamDebugLodSource option with get, set
        abstract ``lodBaseDistance``: float option with get, set
        abstract ``lodMultiplier``: float option with get, set
        abstract ``lodBehindPenalty``: float option with get, set
        abstract ``lodRangeMin``: float option with get, set
        abstract ``lodRangeMax``: float option with get, set
        abstract ``maxDecodesPerFrame``: float option with get, set
        abstract ``lodCooldownFrames``: float option with get, set
        abstract ``lodUpdateInterval``: float option with get, set
        abstract ``lodUpdateDistance``: float option with get, set
        abstract ``maxDetailLod``: float option with get, set
        abstract ``frustumCulling``: bool option with get, set
        abstract ``maxConcurrentDownloads``: float option with get, set
        abstract ``maxDownloadRetries``: float option with get, set
        abstract ``memoryBudgetMb``: float option with get, set
        abstract ``maxResidentSplats``: float option with get, set
        abstract ``evictionCooldownFrames``: float option with get, set

    /// @babylonjs/core/Rendering/geometryBufferRenderer.pure
    [<AllowNullLiteral>]
    type IGeometryBufferTextureTypeAndFormat =
        abstract ``textureType``: float with get, set
        abstract ``textureFormat``: float with get, set
        abstract ``samplingMode``: float option with get, set

    /// @babylonjs/core/Meshes/mesh.vertexData
    [<AllowNullLiteral>]
    type IGetSetVerticesData =
        abstract ``isVerticesDataPresent``: ``kind``: string -> bool
        abstract ``getVerticesData``: ``kind``: string * ?``copyWhenShared``: bool * ?``forceCopy``: bool -> BabylonjsBindings.TypeAliases.FloatArray option
        abstract ``getIndices``: ?``copyWhenShared``: bool * ?``forceCopy``: bool -> BabylonjsBindings.TypeAliases.IndicesArray option
        abstract ``setVerticesData``: ``kind``: string * ``data``: BabylonjsBindings.TypeAliases.FloatArray * ``updatable``: bool * ?``stride``: float -> unit
        abstract ``updateVerticesData``: ``kind``: string * ``data``: BabylonjsBindings.TypeAliases.FloatArray * ?``updateExtends``: bool * ?``makeItUnique``: bool -> unit
        abstract ``setIndices``: ``indices``: BabylonjsBindings.TypeAliases.IndicesArray * ``totalVertices``: float option * ?``updatable``: bool -> unit

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAmbienLight =
        abstract ``color``: ResizeArray<float> option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAnimationChannelTarget =
        abstract ``id``: string with get, set
        abstract ``path``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAnimationSampler =
        abstract ``input``: string with get, set
        abstract ``output``: string with get, set
        abstract ``interpolation``: string option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFCameraOrthographic =
        abstract ``xmag``: float with get, set
        abstract ``ymag``: float with get, set
        abstract ``zfar``: float with get, set
        abstract ``znear``: float with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFCameraPerspective =
        abstract ``aspectRatio``: float with get, set
        abstract ``yfov``: float with get, set
        abstract ``zfar``: float with get, set
        abstract ``znear``: float with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFDirectionalLight =
        abstract ``color``: ResizeArray<float> option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFNodeInstanceSkin =
        abstract ``skeletons``: ResizeArray<string> with get, set
        abstract ``skin``: string with get, set
        abstract ``meshes``: ResizeArray<string> with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type IGLTFObjectModelTreeMeshesObject =
        interface end

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFPointLight =
        abstract ``color``: ResizeArray<float> option with get, set
        abstract ``constantAttenuation``: float option with get, set
        abstract ``linearAttenuation``: float option with get, set
        abstract ``quadraticAttenuation``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFProperty =
        abstract ``extensions``: InlineObjecta21bf015c053Object option with get, set
        abstract ``extras``: JavaScriptObject option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFSpotLight =
        abstract ``color``: ResizeArray<float> option with get, set
        abstract ``constantAttenuation``: float option with get, set
        abstract ``fallOfAngle``: float option with get, set
        abstract ``fallOffExponent``: float option with get, set
        abstract ``linearAttenuation``: float option with get, set
        abstract ``quadraticAttenuation``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechniqueCommonProfile =
        abstract ``lightingModel``: string with get, set
        abstract ``texcoordBindings``: JavaScriptObject with get, set
        abstract ``parameters``: ResizeArray<obj> option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechniqueParameter =
        abstract ``type``: float with get, set
        abstract ``count``: float option with get, set
        abstract ``semantic``: string option with get, set
        abstract ``node``: string option with get, set
        abstract ``value``: U4<float, bool, string, ResizeArray<obj>> option with get, set
        abstract ``source``: string option with get, set
        abstract ``babylonValue``: obj option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechniqueStatesFunctions =
        abstract ``blendColor``: ResizeArray<float> option with get, set
        abstract ``blendEquationSeparate``: ResizeArray<float> option with get, set
        abstract ``blendFuncSeparate``: ResizeArray<float> option with get, set
        abstract ``colorMask``: ResizeArray<bool> with get, set
        abstract ``cullFace``: ResizeArray<float> with get, set

    /// @babylonjs/loaders/glTF/glTFValidation
    [<AllowNullLiteral>]
    type IGLTFValidationConfiguration =
        abstract ``url``: string with get, set

    /// @babylonjs/core/Meshes/Builders/textBuilder
    [<AllowNullLiteral>]
    type IGlyphData =
        abstract ``o``: string with get, set
        abstract ``ha``: float with get, set

    /// @babylonjs/core/Collisions/gpuPicker
    [<AllowNullLiteral>]
    type IGPUMultiPickOptions =
        abstract ``readbackStrategy``: BabylonjsBindings.Enums.GPUMultiPickReadbackStrategy option with get, set
        abstract ``maxIndividualReadbackCount``: float option with get, set
        abstract ``individualReadbackAreaRatio``: float option with get, set

    /// @babylonjs/core/Materials/Textures/hardwareTextureWrapper
    [<AllowNullLiteral>]
    type IHardwareTextureWrapper =
        abstract ``underlyingResource``: obj with get, set
        abstract ``set``: ``hardwareTexture``: obj -> unit
        abstract ``setUsage``: ``textureSource``: float * ``generateMipMaps``: bool * ``is2DArray``: bool * ``isCube``: bool * ``is3D``: bool * ``width``: float * ``height``: float * ``depth``: float -> unit
        abstract ``reset``: unit -> unit
        abstract ``release``: unit -> unit

    /// @babylonjs/core/Materials/Textures/Filtering/hdrFiltering
    [<AllowNullLiteral>]
    type IHDRFilteringOptions =
        abstract ``hdrScale``: float option with get, set
        abstract ``quality``: float option with get, set

    /// Function-valued IHtmlInCanvasPolyfillModule.installHtmlInCanvasPolyfill property.
    [<AllowNullLiteral>]
    type IHtmlInCanvasPolyfillModuleInstallHtmlInCanvasPolyfillCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``options``: InlineObjecta0383ee925a9Object -> unit

    /// Function-valued IHtmlInCanvasPolyfillModule.uninstallHtmlInCanvasPolyfill property.
    [<AllowNullLiteral>]
    type IHtmlInCanvasPolyfillModuleUninstallHtmlInCanvasPolyfillCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill
    [<AllowNullLiteral>]
    type IHtmlInCanvasPolyfillModule =
        abstract ``installHtmlInCanvasPolyfill``: IHtmlInCanvasPolyfillModuleInstallHtmlInCanvasPolyfillCallback option with get, set
        abstract ``uninstallHtmlInCanvasPolyfill``: IHtmlInCanvasPolyfillModuleUninstallHtmlInCanvasPolyfillCallback option with get, set

    /// @babylonjs/core/Materials/Textures/HTML/htmlInteractionManager
    [<AllowNullLiteral>]
    type IHtmlInteractionManagerOptions =
        abstract ``targetElement``: Browser.Types.HTMLElement option with get, set
        abstract ``enablePointerEvents``: bool option with get, set

    /// @babylonjs/core/Materials/Textures/HTML/htmlRaycastInteractionManager
    [<AllowNullLiteral>]
    type IHtmlRaycastInteractionManagerOptions =
        abstract ``targetElement``: Browser.Types.HTMLElement option with get, set
        abstract ``backFaceCulling``: bool option with get, set
        abstract ``invertY``: bool option with get, set

    /// @babylonjs/core/Rendering/IBLShadows/iblShadowsRenderPipeline.pure
    [<AllowNullLiteral>]
    type IIblShadowsSettings =
        abstract ``resolutionExp``: float option with get, set
        abstract ``sampleDirections``: float option with get, set
        abstract ``shadowOpacity``: float option with get, set
        abstract ``envRotation``: float option with get, set
        abstract ``shadowRemanence``: float option with get, set
        abstract ``triPlanarVoxelization``: bool option with get, set
        abstract ``shadowRenderSizeFactor``: float option with get, set
        abstract ``voxelShadowOpacity``: float option with get, set
        abstract ``ssShadowsEnabled``: bool option with get, set
        abstract ``ssShadowSampleCount``: float option with get, set
        abstract ``ssShadowStride``: float option with get, set
        abstract ``ssShadowDistanceScale``: float option with get, set
        abstract ``ssShadowThicknessScale``: float option with get, set

    /// Exact optional-property projection used by Babylon Partial<IIblShadowsSettings> signatures.
    [<AllowNullLiteral>]
    type PartialIIblShadowsSettings =
        abstract ``resolutionExp``: float option with get, set
        abstract ``sampleDirections``: float option with get, set
        abstract ``shadowOpacity``: float option with get, set
        abstract ``envRotation``: float option with get, set
        abstract ``shadowRemanence``: float option with get, set
        abstract ``triPlanarVoxelization``: bool option with get, set
        abstract ``shadowRenderSizeFactor``: float option with get, set
        abstract ``voxelShadowOpacity``: float option with get, set
        abstract ``ssShadowsEnabled``: bool option with get, set
        abstract ``ssShadowSampleCount``: float option with get, set
        abstract ``ssShadowStride``: float option with get, set
        abstract ``ssShadowDistanceScale``: float option with get, set
        abstract ``ssShadowThicknessScale``: float option with get, set

    /// @babylonjs/core/Lights/IES/iesLoader
    [<AllowNullLiteral>]
    type IIESTextureData =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``data``: JS.Float32Array with get, set

    /// Function-valued IImage.onload property.
    [<AllowNullLiteral>]
    type IImageOnloadCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``ev``: Browser.Types.Event -> obj

    /// Function-valued IImage.onerror property.
    [<AllowNullLiteral>]
    type IImageOnerrorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``ev``: Browser.Types.Event -> obj

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type IImage =
        abstract ``onload``: IImageOnloadCallback option with get, set
        abstract ``onerror``: IImageOnerrorCallback option with get, set
        abstract ``src``: string with get, set
        abstract ``width``: float with get
        abstract ``height``: float with get
        abstract ``naturalHeight``: float with get
        abstract ``naturalWidth``: float with get
        abstract ``crossOrigin``: string option with get, set
        abstract ``referrerPolicy``: string with get, set

    /// @babylonjs/core/Materials/imageProcessingConfiguration.defines
    [<AllowNullLiteral>]
    type IImageProcessingConfigurationDefines =
        abstract ``IMAGEPROCESSING``: bool with get, set
        abstract ``VIGNETTE``: bool with get, set
        abstract ``VIGNETTEBLENDMODEMULTIPLY``: bool with get, set
        abstract ``VIGNETTEBLENDMODEOPAQUE``: bool with get, set
        abstract ``TONEMAPPING``: float with get, set
        abstract ``CONTRAST``: bool with get, set
        abstract ``EXPOSURE``: bool with get, set
        abstract ``COLORCURVES``: bool with get, set
        abstract ``COLORGRADING``: bool with get, set
        abstract ``COLORGRADING3D``: bool with get, set
        abstract ``SAMPLER3DGREENDEPTH``: bool with get, set
        abstract ``SAMPLER3DBGRMAP``: bool with get, set
        abstract ``DITHER``: bool with get, set
        abstract ``IMAGEPROCESSINGPOSTPROCESS``: bool with get, set
        abstract ``SKIPFINALCOLORCLAMP``: bool with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type IIndicesMessage =
        abstract ``id``: StringLiteral91744de3d4d8 with get, set
        abstract ``data``: U2<JS.Uint16Array, JS.Uint32Array> with get, set

    /// @babylonjs/core/Misc/iInspectable
    [<AllowNullLiteral>]
    type IInspectableOptions =
        abstract ``label``: string with get, set
        abstract ``value``: U2<float, string> with get, set
        abstract ``selected``: bool option with get, set

    /// Function-valued IInspectorContextMenuItem.action property.
    [<AllowNullLiteral>]
    type IInspectorContextMenuItemActionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ?``entity``: obj -> unit

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IInspectorContextMenuItem =
        abstract ``label``: string with get, set
        abstract ``action``: IInspectorContextMenuItemActionCallback with get, set

    /// @babylonjs/core/Materials/shadowDepthWrapper
    [<AllowNullLiteral>]
    type IIOptionShadowDepthMaterial =
        abstract ``remappedVariables``: ResizeArray<string> option with get, set
        abstract ``standalone``: bool option with get, set
        abstract ``doNotInjectCode``: bool option with get, set

    /// Exact readonly projection of ILatLonLike used by Babylon DeepImmutable<ILatLonLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableILatLonLike =
        abstract ``lat``: float with get
        abstract ``lon``: float with get

    /// @babylonjs/core/Maths/math.geospatial
    [<AllowNullLiteral>]
    type ILatLonLike =
        inherit DeepImmutableILatLonLike
        abstract ``lat``: float with get, set
        abstract ``lon``: float with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type ILeaf =
        abstract ``transcodeFormat``: BabylonjsBindings.Enums.TranscodeTarget with get, set
        abstract ``engineFormat``: BabylonjsBindings.Enums.EngineFormat with get, set
        abstract ``roundToMultiple4``: bool option with get, set

    /// Function-valued ILoadingScreen.displayLoadingUI property.
    [<AllowNullLiteral>]
    type ILoadingScreenDisplayLoadingUICallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued ILoadingScreen.hideLoadingUI property.
    [<AllowNullLiteral>]
    type ILoadingScreenHideLoadingUICallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Loading/loadingScreen.pure
    [<AllowNullLiteral>]
    type ILoadingScreen =
        abstract ``displayLoadingUI``: ILoadingScreenDisplayLoadingUICallback with get, set
        abstract ``hideLoadingUI``: ILoadingScreenHideLoadingUICallback with get, set
        abstract ``loadingUIBackgroundColor``: string with get, set
        abstract ``loadingUIText``: string with get, set

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type IMakeAnimationAdditiveOptions =
        abstract ``referenceFrame``: float option with get, set
        abstract ``range``: string option with get, set
        abstract ``cloneOriginalAnimation``: bool option with get, set
        abstract ``clonedAnimationName``: string option with get, set
        abstract ``fromFrame``: float option with get, set
        abstract ``toFrame``: float option with get, set
        abstract ``clipKeys``: bool option with get, set

    /// @babylonjs/core/Materials/material.pure
    [<AllowNullLiteral>]
    type IMaterialCompilationOptions =
        abstract ``clipPlane``: bool with get, set
        abstract ``useInstances``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IMaterialCompilationOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIMaterialCompilationOptions =
        abstract ``clipPlane``: bool option with get, set
        abstract ``useInstances``: bool option with get, set

    /// @babylonjs/core/Engines/IMaterialContext
    [<AllowNullLiteral>]
    type IMaterialContext =
        abstract ``uniqueId``: float with get, set
        abstract ``useVertexPulling``: bool with get, set
        abstract ``reset``: unit -> unit

    /// Exact readonly projection of IMatrixLike used by Babylon DeepImmutable<IMatrixLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIMatrixLike =
        abstract ``asArray``: unit -> (float * float * float * float * float * float * float * float * float * float * float * float * float * float * float * float)
        abstract ``updateFlag``: BabylonjsBindings.TypeAliases.int with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IMatrixLike =
        inherit DeepImmutableIMatrixLike
        abstract ``asArray``: unit -> (float * float * float * float * float * float * float * float * float * float * float * float * float * float * float * float)
        abstract ``updateFlag``: BabylonjsBindings.TypeAliases.int with get, set

    /// @babylonjs/core/Meshes/abstractMesh.pure
    [<AllowNullLiteral>]
    type IMeshDataCache =
        abstract ``_outputData``: JS.Float32Array option with get, set
        abstract ``_vertexData``: InlineObjecta5f9699c9ae7Object option with get, set

    /// @babylonjs/core/Meshes/Compression/meshoptCompression
    [<AllowNullLiteral>]
    type IMeshoptCompressionConfiguration =
        abstract ``decoder``: InlineObject4f1820232dd6Object with get, set

    /// @babylonjs/core/Meshes/meshUVSpaceRenderer.pure
    [<AllowNullLiteral>]
    type IMeshUVSpaceRendererOptions =
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``textureType``: float option with get, set
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``optimizeUVAllocation``: bool option with get, set
        abstract ``uvEdgeBlending``: bool option with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMinimalMotionControllerObject =
        abstract ``axes``: ResizeArray<float> with get, set
        abstract ``buttons``: ResizeArray<InlineObjecte17e9af72fe0Object> with get, set
        abstract ``hapticActuators``: ResizeArray<InlineObjecta635a5848c40Object> option with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type IMipmap =
        abstract ``data``: JS.Uint8Array option with get, set
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``layerIndex``: float with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMotionControllerLayout =
        abstract ``assetPath``: string with get, set
        abstract ``components``: InlineObjectb55cb151e7bcObject with get, set
        abstract ``gamepadMapping``: U2<StringLiterale3b0c44298fc, StringLiteral1f8f7b54dd3a> with get, set
        abstract ``rootNodeName``: string with get, set
        abstract ``selectComponentId``: string with get, set

    /// @babylonjs/core/Physics/v1/physicsJoint
    [<AllowNullLiteral>]
    type IMotorEnabledJoint =
        abstract ``physicsJoint``: obj with get, set
        abstract ``setMotor``: ?``force``: float * ?``maxForce``: float * ?``motorIndex``: float -> unit
        abstract ``setLimit``: ``upperLimit``: float * ?``lowerLimit``: float * ?``motorIndex``: float -> unit

    /// @babylonjs/core/Materials/Textures/multiRenderTarget.pure
    [<AllowNullLiteral>]
    type IMultiRenderTargetOptions =
        abstract ``createMipMaps``: bool option with get, set
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``types``: ResizeArray<float> option with get, set
        abstract ``samplingModes``: ResizeArray<float> option with get, set
        abstract ``useSRGBBuffers``: ResizeArray<bool> option with get, set
        abstract ``generateDepthBuffer``: bool option with get, set
        abstract ``generateStencilBuffer``: bool option with get, set
        abstract ``generateDepthTexture``: bool option with get, set
        abstract ``formats``: ResizeArray<float> option with get, set
        abstract ``depthTextureFormat``: float option with get, set
        abstract ``textureCount``: float option with get, set
        abstract ``doNotChangeAspectRatio``: bool option with get, set
        abstract ``defaultType``: float option with get, set
        abstract ``samples``: float option with get, set
        abstract ``drawOnlyOnFirstAttachmentByDefault``: bool option with get, set
        abstract ``targetTypes``: ResizeArray<float> option with get, set
        abstract ``faceIndex``: ResizeArray<float> option with get, set
        abstract ``layerIndex``: ResizeArray<float> option with get, set
        abstract ``layerCounts``: ResizeArray<float> option with get, set
        abstract ``creationFlags``: ResizeArray<float> option with get, set
        abstract ``labels``: ResizeArray<string> option with get, set
        abstract ``label``: string option with get, set
        abstract ``dontCreateTextures``: bool option with get, set

    /// @babylonjs/core/Engines/Native/nativeInterfaces
    [<AllowNullLiteral>]
    type INativeDataStream =
        abstract ``writeBuffer``: ``buffer``: JS.ArrayBuffer * ``length``: float -> unit

    /// @babylonjs/core/Navigation/INavigationEngine
    [<AllowNullLiteral>]
    type INavMeshParameters =
        abstract ``cs``: float with get, set
        abstract ``ch``: float with get, set
        abstract ``walkableSlopeAngle``: float with get, set
        abstract ``walkableHeight``: float with get, set
        abstract ``walkableClimb``: float with get, set
        abstract ``walkableRadius``: float with get, set
        abstract ``maxEdgeLen``: float with get, set
        abstract ``maxSimplificationError``: float with get, set
        abstract ``minRegionArea``: float with get, set
        abstract ``mergeRegionArea``: float with get, set
        abstract ``maxVertsPerPoly``: float with get, set
        abstract ``detailSampleDist``: float with get, set
        abstract ``detailSampleMaxError``: float with get, set
        abstract ``tileSize``: float option with get, set
        abstract ``borderSize``: float option with get, set

    /// Function-valued INodeGeometryExecutionContext.getOverridePositionsContextualValue property.
    [<AllowNullLiteral>]
    type INodeGeometryExecutionContextGetOverridePositionsContextualValueCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> obj

    /// Function-valued INodeGeometryExecutionContext.getOverrideNormalsContextualValue property.
    [<AllowNullLiteral>]
    type INodeGeometryExecutionContextGetOverrideNormalsContextualValueCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> obj

    /// Function-valued INodeGeometryExecutionContext.getOverrideUVs1ContextualValue property.
    [<AllowNullLiteral>]
    type INodeGeometryExecutionContextGetOverrideUVs1ContextualValueCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> obj

    /// @babylonjs/core/Meshes/Node/Interfaces/nodeGeometryExecutionContext
    [<AllowNullLiteral>]
    type INodeGeometryExecutionContext =
        abstract ``getExecutionIndex``: unit -> float
        abstract ``getExecutionFaceIndex``: unit -> float
        abstract ``getExecutionLoopIndex``: unit -> float
        abstract ``getOverridePositionsContextualValue``: INodeGeometryExecutionContextGetOverridePositionsContextualValueCallback option with get, set
        abstract ``getOverrideNormalsContextualValue``: INodeGeometryExecutionContextGetOverrideNormalsContextualValueCallback option with get, set
        abstract ``getOverrideUVs1ContextualValue``: INodeGeometryExecutionContextGetOverrideUVs1ContextualValueCallback option with get, set

    /// @babylonjs/core/Meshes/Node/Interfaces/nodeGeometryInstancingContext
    [<AllowNullLiteral>]
    type INodeGeometryInstancingContext =
        abstract ``getInstanceIndex``: unit -> float

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type INodeMaterialEditorOptions =
        abstract ``editorURL``: string option with get, set
        abstract ``nodeEditorConfig``: InlineObjecte519efeffba5Object option with get, set

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type INodeMaterialOptions =
        abstract ``emitComments``: bool with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage with get, set

    /// Exact optional-property projection used by Babylon Partial<INodeMaterialOptions> signatures.
    [<AllowNullLiteral>]
    type PartialINodeMaterialOptions =
        abstract ``emitComments``: bool option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set

    /// @babylonjs/core/Particles/Node/nodeParticleSystemSet
    [<AllowNullLiteral>]
    type INodeParticleEditorOptions =
        abstract ``editorURL``: string option with get, set
        abstract ``nodeEditorConfig``: InlineObjectedc17de1126fObject option with get, set

    /// @babylonjs/core/Particles/Node/Blocks/particleSourceTextureBlock.pure
    [<AllowNullLiteral>]
    type INodeParticleTextureData =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``data``: JS.Uint8ClampedArray with get, set

    /// @babylonjs/core/FrameGraph/Node/Types/nodeRenderGraphTypes
    [<AllowNullLiteral>]
    type INodeRenderGraphCreateOptions =
        abstract ``debugTextures``: bool option with get, set
        abstract ``rebuildGraphOnEngineResize``: bool option with get, set
        abstract ``verbose``: bool option with get, set
        abstract ``autoConfigure``: bool option with get, set
        abstract ``autoFillExternalInputs``: bool option with get, set

    /// @babylonjs/core/Engines/instancingAttributeInfo
    [<AllowNullLiteral>]
    type InstancingAttributeInfo =
        abstract ``attributeName``: string with get, set
        abstract ``index``: float option with get, set
        abstract ``attributeSize``: float with get, set
        abstract ``offset``: float with get, set
        abstract ``divisor``: float option with get, set
        abstract ``attributeType``: float option with get, set
        abstract ``normalized``: bool option with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/interactivityGraphParser
    [<AllowNullLiteral>]
    type InteractivityEvent =
        abstract ``eventId``: string with get, set
        abstract ``eventData``: ResizeArray<InlineObject93dc13e6dc30Object> option with get, set

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    [<AllowNullLiteral>]
    type InternalTextureCreationOptions =
        abstract ``createMipMaps``: bool option with get, set
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``type``: float option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``format``: float option with get, set
        abstract ``samples``: float option with get, set
        abstract ``creationFlags``: float option with get, set
        abstract ``useSRGBBuffer``: bool option with get, set
        abstract ``label``: string option with get, set
        abstract ``createMSAATexture``: bool option with get, set
        abstract ``comparisonFunction``: float option with get, set
        abstract ``isCube``: bool option with get, set

    /// @babylonjs/core/ObjectModel/objectModelInterfaces
    [<AllowNullLiteral>]
    type IObjectInfo<'T, 'O> =
        abstract ``object``: 'O with get, set
        abstract ``info``: 'T with get, set

    /// @babylonjs/core/Cameras/camera.pure
    [<AllowNullLiteral>]
    type IObliqueParams =
        abstract ``angle``: float with get, set
        abstract ``length``: float with get, set
        abstract ``offset``: float with get, set

    /// @babylonjs/core/Misc/observable.pure
    [<AllowNullLiteral>]
    type IObserver =
        abstract ``remove``: ?``defer``: bool -> unit

    /// @babylonjs/core/Offline/IOfflineProvider
    [<AllowNullLiteral>]
    type IOfflineProvider =
        abstract ``enableSceneOffline``: bool with get, set
        abstract ``enableTexturesOffline``: bool with get, set
        abstract ``open``: ``successCallback``: System.Action * ``errorCallback``: System.Action -> unit
        abstract ``loadImage``: ``url``: string * ``image``: Browser.Types.HTMLImageElement -> unit
        abstract ``loadFile``: ``url``: string * ``sceneLoaded``: System.Action<obj> * ?``progressCallBack``: System.Action<obj> * ?``errorCallback``: System.Action * ?``useArrayBuffer``: bool -> unit

    /// @babylonjs/core/Misc/interfaces/iPerfViewer
    [<AllowNullLiteral>]
    type IPerfCustomEvent =
        abstract ``name``: string with get, set
        abstract ``value``: float option with get, set

    /// @babylonjs/core/Misc/interfaces/iPerfViewer
    [<AllowNullLiteral>]
    type IPerfDatasets =
        abstract ``ids``: ResizeArray<string> with get, set
        abstract ``data``: BabylonjsBindings.SimpleClasses.DynamicFloat32Array with get, set
        abstract ``startingIndices``: BabylonjsBindings.SimpleClasses.DynamicFloat32Array with get, set

    /// @babylonjs/core/Misc/interfaces/iPerfViewer
    [<AllowNullLiteral>]
    type IPerfMetadata =
        abstract ``color``: string option with get, set
        abstract ``hidden``: bool option with get, set
        abstract ``category``: string option with get, set

    /// Function-valued IPerfViewerCollectionStrategy.getData property.
    [<AllowNullLiteral>]
    type IPerfViewerCollectionStrategyGetDataCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> float

    /// Function-valued IPerfViewerCollectionStrategy.dispose property.
    [<AllowNullLiteral>]
    type IPerfViewerCollectionStrategyDisposeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Misc/PerformanceViewer/performanceViewerCollectionStrategies
    [<AllowNullLiteral>]
    type IPerfViewerCollectionStrategy =
        abstract ``id``: string with get, set
        abstract ``getData``: IPerfViewerCollectionStrategyGetDataCallback with get, set
        abstract ``dispose``: IPerfViewerCollectionStrategyDisposeCallback with get, set

    /// @babylonjs/core/Rendering/renderingManager
    [<AllowNullLiteral>]
    type IRenderingManagerAutoClearSetup =
        abstract ``autoClear``: bool with get, set
        abstract ``depth``: bool with get, set
        abstract ``stencil``: bool with get, set

    /// @babylonjs/core/Animations/animatorAvatar
    [<AllowNullLiteral>]
    type IRetargetOptions =
        abstract ``animationGroupName``: string option with get, set
        abstract ``fixAnimations``: bool option with get, set
        abstract ``checkHierarchy``: bool option with get, set
        abstract ``retargetAnimationKeys``: bool option with get, set
        abstract ``fixRootPosition``: bool option with get, set
        abstract ``fixGroundReference``: bool option with get, set
        abstract ``fixGroundReferenceDynamicRefNode``: bool option with get, set
        abstract ``rootNodeName``: string option with get, set
        abstract ``groundReferenceNodeName``: string option with get, set
        abstract ``groundReferenceVerticalAxis``: U4<StringLiterale3b0c44298fc, StringLiteral4b68ab3847fe, StringLiteral18f5384d58bc, StringLiteralbbeebd879e1d> option with get, set
        abstract ``mapNodeNames``: JS.Map<string, string> option with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type ISafeOrbitCameraLimits =
        abstract ``radiusMin``: float option with get, set
        abstract ``elevationMinMax``: (float * float) option with get, set

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderPluginExtensions =
        [<EmitIndexer>] abstract Item: ``extension``: string -> InlineObjectf9136a0bdd3aObject with get

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderPluginInternal =
        abstract ``onDisposeObservable``: BabylonjsBindings.SimpleClasses.Observable<unit> with get

    /// Exact optional-property projection used by Babylon Partial<ISceneLoaderPluginInternal> signatures.
    [<AllowNullLiteral>]
    type PartialISceneLoaderPluginInternal =
        abstract ``onDisposeObservable``: BabylonjsBindings.SimpleClasses.Observable<unit> option with get

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderProgressEvent =
        abstract ``lengthComputable``: bool with get
        abstract ``loaded``: float with get
        abstract ``total``: float with get

    /// @babylonjs/core/Misc/interfaces/screenshotSize
    [<AllowNullLiteral>]
    type IScreenshotSize =
        abstract ``height``: float option with get, set
        abstract ``precision``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``finalWidth``: float option with get, set
        abstract ``finalHeight``: float option with get, set

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type ISerializedFlowGraphConnection =
        abstract ``uniqueId``: string with get, set
        abstract ``name``: string with get, set
        abstract ``_connectionType``: BabylonjsBindings.Enums.FlowGraphConnectionType with get, set
        abstract ``connectedPointIds``: ResizeArray<string> with get, set
        abstract ``defaultValue``: obj option with get, set

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type ISerializedFlowGraphContext =
        abstract ``uniqueId``: string with get, set
        abstract ``name``: string option with get, set
        abstract ``_userVariables``: InlineObjecta21bf015c053Object with get, set
        abstract ``_variableTypes``: InlineObject8681f48cdb3dObject option with get, set
        abstract ``_connectionValues``: InlineObjecta21bf015c053Object with get, set
        abstract ``_assetsContext``: InlineObjecta21bf015c053Object option with get, set
        abstract ``enableLogging``: bool option with get, set

    /// Function-valued IShaderMaterialOptions.extraInitializationsAsync property.
    [<AllowNullLiteral>]
    type IShaderMaterialOptionsExtraInitializationsAsyncCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> JS.Promise<unit>

    /// @babylonjs/core/Materials/shaderMaterial.pure
    [<AllowNullLiteral>]
    type IShaderMaterialOptions =
        abstract ``needAlphaBlending``: bool with get, set
        abstract ``needAlphaTesting``: bool with get, set
        abstract ``attributes``: ResizeArray<string> with get, set
        abstract ``uniforms``: ResizeArray<string> with get, set
        abstract ``uniformBuffers``: ResizeArray<string> with get, set
        abstract ``samplers``: ResizeArray<string> with get, set
        abstract ``externalTextures``: ResizeArray<string> with get, set
        abstract ``samplerObjects``: ResizeArray<string> with get, set
        abstract ``storageBuffers``: ResizeArray<string> with get, set
        abstract ``defines``: ResizeArray<string> with get, set
        abstract ``useClipPlane``: bool option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set
        abstract ``extraInitializationsAsync``: IShaderMaterialOptionsExtraInitializationsAsyncCallback option with get, set

    /// Exact optional-property projection used by Babylon Partial<IShaderMaterialOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIShaderMaterialOptions =
        abstract ``needAlphaBlending``: bool option with get, set
        abstract ``needAlphaTesting``: bool option with get, set
        abstract ``attributes``: ResizeArray<string> option with get, set
        abstract ``uniforms``: ResizeArray<string> option with get, set
        abstract ``uniformBuffers``: ResizeArray<string> option with get, set
        abstract ``samplers``: ResizeArray<string> option with get, set
        abstract ``externalTextures``: ResizeArray<string> option with get, set
        abstract ``samplerObjects``: ResizeArray<string> option with get, set
        abstract ``storageBuffers``: ResizeArray<string> option with get, set
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``useClipPlane``: bool option with get, set
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage option with get, set
        abstract ``extraInitializationsAsync``: IShaderMaterialOptionsExtraInitializationsAsyncCallback option with get, set

    /// @babylonjs/core/Meshes/meshSimplification.common
    [<AllowNullLiteral>]
    type ISimplificationSettings =
        abstract ``quality``: float with get, set
        abstract ``distance``: float with get, set
        abstract ``optimizeMesh``: bool option with get, set

    /// @babylonjs/core/Maths/math.size
    [<AllowNullLiteral>]
    type ISize =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set

    /// @babylonjs/core/Debug/ISkeletonViewer
    [<AllowNullLiteral>]
    type ISkeletonMapShaderColorMapKnot =
        abstract ``color``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``location``: float with get, set

    /// @babylonjs/core/Debug/ISkeletonViewer
    [<AllowNullLiteral>]
    type ISkeletonViewerDisplayOptions =
        abstract ``midStep``: float option with get, set
        abstract ``midStepFactor``: float option with get, set
        abstract ``sphereBaseSize``: float option with get, set
        abstract ``sphereScaleUnit``: float option with get, set
        abstract ``sphereFactor``: float option with get, set
        abstract ``spurFollowsChild``: bool option with get, set
        abstract ``showLocalAxes``: bool option with get, set
        abstract ``localAxesSize``: float option with get, set

    /// @babylonjs/core/Misc/smartArray
    [<AllowNullLiteral>]
    type ISmartArrayLike<'T> =
        abstract ``data``: ResizeArray<'T> with get, set
        abstract ``length``: float with get, set

    /// @babylonjs/loaders/SPLAT/gaussianSplattingStream
    [<AllowNullLiteral>]
    type ISOGLODEntry =
        abstract ``file``: float with get, set
        abstract ``offset``: float with get, set
        abstract ``count``: float with get, set

    /// @babylonjs/core/Lights/lightConstants
    [<AllowNullLiteral>]
    type ISortableLight =
        abstract ``shadowEnabled``: bool with get, set
        abstract ``renderPriority``: float with get, set

    /// @babylonjs/core/Audio/Interfaces/ISoundOptions
    [<AllowNullLiteral>]
    type ISoundOptions =
        abstract ``autoplay``: bool option with get, set
        abstract ``loop``: bool option with get, set
        abstract ``volume``: float option with get, set
        abstract ``spatialSound``: bool option with get, set
        abstract ``maxDistance``: float option with get, set
        abstract ``useCustomAttenuation``: bool option with get, set
        abstract ``rolloffFactor``: float option with get, set
        abstract ``refDistance``: float option with get, set
        abstract ``distanceModel``: U3<StringLiteral7f2fe580edb3, StringLiteral7705accd2694, StringLiterald075063d475b> option with get, set
        abstract ``playbackRate``: float option with get, set
        abstract ``streaming``: bool option with get, set
        abstract ``length``: float option with get, set
        abstract ``offset``: float option with get, set
        abstract ``skipCodecCheck``: bool option with get, set

    /// @babylonjs/core/Audio/soundTrack
    [<AllowNullLiteral>]
    type ISoundTrackOptions =
        abstract ``volume``: float option with get, set
        abstract ``mainTrack``: bool option with get, set

    /// @babylonjs/core/Sprites/ISprites
    [<AllowNullLiteral>]
    type ISpriteJSONSpriteFrameData =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set
        abstract ``w``: float with get, set
        abstract ``h``: float with get, set

    /// @babylonjs/core/Sprites/ISprites
    [<AllowNullLiteral>]
    type ISpriteJSONSpriteSourceSize =
        abstract ``w``: float with get, set
        abstract ``h``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSoundBuffer
    [<AllowNullLiteral>]
    type IStaticSoundBufferCloneOptions =
        abstract ``name``: string with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundBufferCloneOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundBufferCloneOptions =
        abstract ``name``: string option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSoundBuffer
    [<AllowNullLiteral>]
    type IStaticSoundBufferOptions =
        abstract ``skipCodecCheck``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundBufferOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundBufferOptions =
        abstract ``skipCodecCheck``: bool option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundOptionsBase =
        abstract ``duration``: float with get, set
        abstract ``loopEnd``: float with get, set
        abstract ``loopStart``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundOptionsBase> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundOptionsBase =
        abstract ``duration``: float option with get, set
        abstract ``loopEnd``: float option with get, set
        abstract ``loopStart``: float option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundStopOptions =
        abstract ``waitTime``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundStopOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundStopOptions =
        abstract ``waitTime``: float option with get, set

    /// @babylonjs/core/States/IStencilState
    [<AllowNullLiteral>]
    type IStencilStateProperties =
        abstract ``enabled``: bool with get, set
        abstract ``mask``: float with get, set
        abstract ``funcMask``: float with get, set
        abstract ``funcRef``: float with get, set
        abstract ``func``: float with get, set
        abstract ``opStencilDepthPass``: float with get, set
        abstract ``opStencilFail``: float with get, set
        abstract ``opDepthFail``: float with get, set
        abstract ``backFunc``: float with get, set
        abstract ``backOpStencilDepthPass``: float with get, set
        abstract ``backOpStencilFail``: float with get, set
        abstract ``backOpDepthFail``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio
    [<AllowNullLiteral>]
    type IStereoAudioOptions =
        abstract ``stereoEnabled``: bool with get, set
        abstract ``stereoPan``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IStereoAudioOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStereoAudioOptions =
        abstract ``stereoEnabled``: bool option with get, set
        abstract ``stereoPan``: float option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSound
    [<AllowNullLiteral>]
    type IStreamingSoundOptionsBase =
        abstract ``preloadCount``: float with get, set

    /// @babylonjs/core/Meshes/mesh.vertexData.subdivide
    [<AllowNullLiteral>]
    type ISubdivideOptions =
        abstract ``flatOnly``: bool option with get, set
        abstract ``split``: bool option with get, set
        abstract ``uvSmooth``: bool option with get, set
        abstract ``preserveEdges``: bool option with get, set
        abstract ``weight``: float option with get, set

    /// Exact optional-property projection used by Babylon Partial<ISubdivideOptions> signatures.
    [<AllowNullLiteral>]
    type PartialISubdivideOptions =
        abstract ``flatOnly``: bool option with get, set
        abstract ``split``: bool option with get, set
        abstract ``uvSmooth``: bool option with get, set
        abstract ``preserveEdges``: bool option with get, set
        abstract ``weight``: float option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type ITextMetrics =
        abstract ``width``: float with get
        abstract ``actualBoundingBoxLeft``: float with get
        abstract ``actualBoundingBoxRight``: float with get
        abstract ``actualBoundingBoxAscent``: float with get
        abstract ``actualBoundingBoxDescent``: float with get

    /// @babylonjs/core/Materials/Textures/Packer/packer
    [<AllowNullLiteral>]
    type ITexturePackerOptions =
        abstract ``map``: ResizeArray<string> option with get, set
        abstract ``uvsIn``: string option with get, set
        abstract ``uvsOut``: string option with get, set
        abstract ``layout``: float option with get, set
        abstract ``colnum``: float option with get, set
        abstract ``updateInputMeshes``: bool option with get, set
        abstract ``disposeSources``: bool option with get, set
        abstract ``fillBlanks``: bool option with get, set
        abstract ``customFillColor``: string option with get, set
        abstract ``frameSize``: float option with get, set
        abstract ``paddingRatio``: float option with get, set
        abstract ``paddingMode``: float option with get, set
        abstract ``paddingColor``: U2<BabylonjsBindings.SimpleClasses.Color3, BabylonjsBindings.SimpleClasses.Color4> option with get, set

    /// @babylonjs/core/Misc/timer
    [<AllowNullLiteral>]
    type ITimerData<'T> =
        abstract ``startTime``: float with get, set
        abstract ``currentTime``: float with get, set
        abstract ``deltaTime``: float with get, set
        abstract ``completeRate``: float with get, set
        abstract ``payload``: 'T with get, set

    /// @babylonjs/core/Meshes/trailMesh.pure
    [<AllowNullLiteral>]
    type ITrailMeshOptions =
        abstract ``diameter``: float option with get, set
        abstract ``length``: float option with get, set
        abstract ``segments``: float option with get, set
        abstract ``sections``: float option with get, set
        abstract ``doNotTaper``: bool option with get, set
        abstract ``autoStart``: bool option with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/transmissionHelper
    [<AllowNullLiteral>]
    type ITransmissionHelperOptions =
        abstract ``renderSize``: float with get, set
        abstract ``samples``: float with get, set
        abstract ``lodGenerationScale``: float with get, set
        abstract ``lodGenerationOffset``: float with get, set
        abstract ``renderTargetTextureType``: float with get, set
        abstract ``generateMipmaps``: bool with get, set
        abstract ``clearColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set

    /// Exact optional-property projection used by Babylon Partial<ITransmissionHelperOptions> signatures.
    [<AllowNullLiteral>]
    type PartialITransmissionHelperOptions =
        abstract ``renderSize``: float option with get, set
        abstract ``samples``: float option with get, set
        abstract ``lodGenerationScale``: float option with get, set
        abstract ``lodGenerationOffset``: float option with get, set
        abstract ``renderTargetTextureType``: float option with get, set
        abstract ``generateMipmaps``: bool option with get, set
        abstract ``clearColor``: BabylonjsBindings.SimpleClasses.Color4 option with get, set

    /// Function-valued IUIEvent.preventDefault property.
    [<AllowNullLiteral>]
    type IUIEventPreventDefaultCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IUIEvent =
        abstract ``inputIndex``: float with get, set
        abstract ``currentTarget``: obj option with get, set
        abstract ``srcElement``: obj option with get, set
        abstract ``type``: string with get, set
        abstract ``target``: obj with get, set
        abstract ``preventDefault``: IUIEventPreventDefaultCallback with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type IUpdateOptions =
        abstract ``flipY``: bool option with get, set
        abstract ``previousVertexCount``: float option with get, set

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type IUploadImageToTexture2DArrayLayerOptions =
        abstract ``invertY``: bool option with get, set
        abstract ``premultiplyAlpha``: bool option with get, set

    /// @babylonjs/core/Misc/gradients
    [<AllowNullLiteral>]
    type IValueGradient =
        abstract ``gradient``: float with get, set

    /// Exact readonly projection of IVector2Like used by Babylon DeepImmutable<IVector2Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIVector2Like =
        abstract ``x``: BabylonjsBindings.TypeAliases.float with get
        abstract ``y``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IVector2Like =
        inherit DeepImmutableIVector2Like
        abstract ``x``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``y``: BabylonjsBindings.TypeAliases.float with get, set

    /// Exact readonly projection of IVector3LikeInternal used by Babylon DeepImmutable<IVector3LikeInternal> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIVector3LikeInternal =
        abstract ``_x``: float with get
        abstract ``_y``: float with get
        abstract ``_z``: float with get
        abstract ``_isDirty``: bool option with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IVector3LikeInternal =
        inherit DeepImmutableIVector3LikeInternal
        abstract ``_x``: float with get, set
        abstract ``_y``: float with get, set
        abstract ``_z``: float with get, set
        abstract ``_isDirty``: bool option with get, set

    /// @babylonjs/core/Buffers/buffer.pure
    [<AllowNullLiteral>]
    type IVertexBufferOptions =
        abstract ``updatable``: bool option with get, set
        abstract ``postponeInternalCreation``: bool option with get, set
        abstract ``stride``: float option with get, set
        abstract ``instanced``: bool option with get, set
        abstract ``offset``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``type``: float option with get, set
        abstract ``normalized``: bool option with get, set
        abstract ``useBytes``: bool option with get, set
        abstract ``divisor``: float option with get, set
        abstract ``takeBufferOwnership``: bool option with get, set
        abstract ``label``: string option with get, set

    /// @babylonjs/core/Meshes/mesh.vertexData
    [<AllowNullLiteral>]
    type IVertexDataLike =
        abstract ``positions``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``normals``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``tangents``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs2``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs3``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs4``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs5``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``uvs6``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``colors``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``matricesIndices``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``matricesWeights``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``matricesIndicesExtra``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``matricesWeightsExtra``: BabylonjsBindings.TypeAliases.FloatArray option with get, set
        abstract ``indices``: BabylonjsBindings.TypeAliases.IndicesArray option with get, set

    /// @babylonjs/core/Meshes/csg2
    [<AllowNullLiteral>]
    type IVertexDataRebuildOptions =
        abstract ``rebuildNormals``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<IVertexDataRebuildOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIVertexDataRebuildOptions =
        abstract ``rebuildNormals``: bool option with get, set

    /// @babylonjs/core/Materials/vertexPullingHelper.functions
    [<AllowNullLiteral>]
    type IVertexPullingMetadata =
        abstract ``offset``: float with get, set
        abstract ``stride``: float with get, set
        abstract ``type``: float with get, set
        abstract ``normalized``: bool with get, set

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IViewportLike =
        abstract ``x``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``y``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``width``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``height``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Misc/virtualJoystick
    [<AllowNullLiteral>]
    type IVirtualJoystickCustomizations =
        abstract ``puckSize``: float with get, set
        abstract ``containerSize``: float with get, set
        abstract ``color``: string with get, set
        abstract ``puckImage``: string option with get, set
        abstract ``containerImage``: string option with get, set
        abstract ``position``: InlineObject4b84b3d5395bObject option with get, set
        abstract ``alwaysVisible``: bool with get, set
        abstract ``limitToContainer``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<IVirtualJoystickCustomizations> signatures.
    [<AllowNullLiteral>]
    type PartialIVirtualJoystickCustomizations =
        abstract ``puckSize``: float option with get, set
        abstract ``containerSize``: float option with get, set
        abstract ``color``: string option with get, set
        abstract ``puckImage``: string option with get, set
        abstract ``containerImage``: string option with get, set
        abstract ``position``: InlineObject4b84b3d5395bObject option with get, set
        abstract ``alwaysVisible``: bool option with get, set
        abstract ``limitToContainer``: bool option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/subNodes/volumeAudioSubNode
    [<AllowNullLiteral>]
    type IVolumeAudioOptions =
        abstract ``volume``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IVolumeAudioOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIVolumeAudioOptions =
        abstract ``volume``: float option with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuMaterialContext
    [<AllowNullLiteral>]
    type IWebGPUMaterialContextSamplerCache =
        abstract ``sampler``: BabylonjsBindings.SimpleClasses.TextureSampler option with get, set
        abstract ``hashCode``: float with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuBundleList
    [<AllowNullLiteral>]
    type IWebGPURenderItem =
        abstract ``run``: ``renderPass``: BrowserGPURenderPassEncoder -> unit
        abstract ``clone``: unit -> IWebGPURenderItem

    /// @babylonjs/core/Engines/WebGPU/webgpuPipelineContext
    [<AllowNullLiteral>]
    type IWebGPURenderPipelineStageDescriptor =
        abstract ``vertexStage``: BrowserGPUProgrammableStage with get, set
        abstract ``fragmentStage``: BrowserGPUProgrammableStage option with get, set

    /// @babylonjs/core/Misc/interfaces/iWebRequest
    [<AllowNullLiteral>]
    type IWebRequest =
        abstract ``responseURL``: string with get, set
        abstract ``status``: float with get, set
        abstract ``statusText``: string with get, set

    /// @babylonjs/core/XR/webXRInputSource
    [<AllowNullLiteral>]
    type IWebXRControllerOptions =
        abstract ``disableMotionControllerAnimation``: bool option with get, set
        abstract ``doNotLoadControllerMesh``: bool option with get, set
        abstract ``forceControllerProfile``: string option with get, set
        abstract ``renderingGroupId``: float option with get, set

    /// @babylonjs/core/XR/features/WebXRDepthSensing.pure
    [<AllowNullLiteral>]
    type IWebXRDepthSensingOptions =
        abstract ``usagePreference``: ResizeArray<BabylonjsBindings.StringEnums.WebXRDepthUsage> with get, set
        abstract ``dataFormatPreference``: ResizeArray<BabylonjsBindings.StringEnums.WebXRDepthDataFormat> with get, set
        abstract ``disableDepthSensingOnMaterials``: bool option with get, set
        abstract ``useToleranceFactorForDepthSensing``: bool option with get, set
        abstract ``prepareTextureForVisualization``: bool option with get, set

    /// @babylonjs/core/XR/features/WebXRDOMOverlay.pure
    [<AllowNullLiteral>]
    type IWebXRDomOverlayOptions =
        abstract ``element``: U2<Browser.Types.Element, string> with get, set
        abstract ``supressXRSelectEvents``: bool option with get, set

    /// @babylonjs/core/XR/webXRGraphicsBinding
    [<AllowNullLiteral>]
    type IWebXRGraphicsBinding =
        abstract ``bindingType``: BabylonjsBindings.Enums.WebXRGraphicsBindingType with get

    /// @babylonjs/core/XR/features/WebXRImageTracking.pure
    [<AllowNullLiteral>]
    type IWebXRImageTrackingOptions =
        abstract ``images``: ResizeArray<InlineObjectcead31b74f8fObject> with get, set

    /// @babylonjs/core/XR/motionController/webXRControllerComponent
    [<AllowNullLiteral>]
    type IWebXRMotionControllerAxesValue =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    /// @babylonjs/core/XR/motionController/webXRControllerComponent
    [<AllowNullLiteral>]
    type IWebXRMotionControllerComponentChangesValues<'T> =
        abstract ``current``: 'T with get, set
        abstract ``previous``: 'T with get, set

    /// @babylonjs/core/XR/features/WebXRRawCameraAccess.pure
    [<AllowNullLiteral>]
    type IWebXRRawCameraAccessOptions =
        abstract ``doNotDisposeOnDetach``: bool option with get, set

    /// @babylonjs/loaders/glTF/2.0/glTFLoader.pure
    [<AllowNullLiteral>]
    type IWithMetadata =
        abstract ``metadata``: obj with get, set
        abstract ``_internalMetadata``: obj with get, set

    /// @babylonjs/core/Physics/castingResult
    [<AllowNullLiteral>]
    type IXYZ =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set
        abstract ``z``: float with get, set

    /// @babylonjs/core/Materials/meshDebugPluginMaterial.pure
    [<AllowNullLiteral>]
    type MeshDebugOptions =
        abstract ``mode``: BabylonjsBindings.Enums.MeshDebugMode option with get, set
        abstract ``multiply``: bool option with get, set
        abstract ``shadedDiffuseColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``shadedSpecularColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``shadedSpecularPower``: float option with get, set
        abstract ``wireframeThickness``: float option with get, set
        abstract ``wireframeTrianglesColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``wireframeVerticesColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``vertexColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``vertexRadius``: float option with get, set
        abstract ``uvScale``: float option with get, set
        abstract ``uvPrimaryColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``uvSecondaryColor``: BabylonjsBindings.SimpleClasses.Color3 option with get, set

    /// @babylonjs/core/Rendering/objectRenderer
    [<AllowNullLiteral>]
    type ObjectRendererOptions =
        abstract ``numPasses``: float option with get, set
        abstract ``doNotChangeAspectRatio``: bool option with get, set
        abstract ``enableClusteredLights``: bool option with get, set

    /// Exact required-property projection used by Required<ObjectRendererOptions> signatures.
    [<AllowNullLiteral>]
    type RequiredObjectRendererOptions =
        abstract ``numPasses``: float with get, set
        abstract ``doNotChangeAspectRatio``: bool with get, set
        abstract ``enableClusteredLights``: bool with get, set

    /// @babylonjs/core/Physics/v1/physicsImpostor.pure
    [<AllowNullLiteral>]
    type PhysicsImpostorParameters =
        abstract ``mass``: float with get, set
        abstract ``friction``: float option with get, set
        abstract ``restitution``: float option with get, set
        abstract ``nativeOptions``: obj option with get, set
        abstract ``ignoreParent``: bool option with get, set
        abstract ``disableBidirectionalTransformation``: bool option with get, set
        abstract ``pressure``: float option with get, set
        abstract ``stiffness``: float option with get, set
        abstract ``velocityIterations``: float option with get, set
        abstract ``positionIterations``: float option with get, set
        abstract ``fixedPoints``: float option with get, set
        abstract ``margin``: float option with get, set
        abstract ``damping``: float option with get, set
        abstract ``path``: obj option with get, set
        abstract ``shape``: obj option with get, set

    /// @babylonjs/core/Physics/v2/physicsMaterial
    [<AllowNullLiteral>]
    type PhysicsMaterial =
        abstract ``friction``: float option with get, set
        abstract ``staticFriction``: float option with get, set
        abstract ``restitution``: float option with get, set
        abstract ``frictionCombine``: BabylonjsBindings.Enums.PhysicsMaterialCombineMode option with get, set
        abstract ``restitutionCombine``: BabylonjsBindings.Enums.PhysicsMaterialCombineMode option with get, set

    /// @babylonjs/core/Gizmos/rotationGizmo
    [<AllowNullLiteral>]
    type PlaneRotationGizmoOptions =
        abstract ``color``: BabylonjsBindings.SimpleClasses.Color3 option with get, set

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type PLYHeader =
        abstract ``vertexCount``: float with get, set
        abstract ``chunkCount``: float with get, set
        abstract ``rowVertexLength``: float with get, set
        abstract ``rowChunkLength``: float with get, set
        abstract ``vertexProperties``: ResizeArray<BabylonjsBindings.TypeAliases.PlyProperty> with get, set
        abstract ``chunkProperties``: ResizeArray<BabylonjsBindings.TypeAliases.PlyProperty> with get, set
        abstract ``dataView``: JS.DataView with get, set
        abstract ``buffer``: JS.ArrayBuffer with get, set
        abstract ``shDegree``: float with get, set
        abstract ``shCoefficientCount``: float with get, set
        abstract ``shBuffer``: JS.ArrayBuffer option with get, set

    /// @babylonjs/core/Events/pointerEvents
    [<AllowNullLiteral>]
    type PointerTouch =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set
        abstract ``pointerId``: float with get, set
        abstract ``type``: obj with get, set
        abstract ``button``: float option with get, set

    /// @babylonjs/core/scene.pure
    [<AllowNullLiteral>]
    type SceneOptions =
        abstract ``useGeometryUniqueIdsMap``: bool option with get, set
        abstract ``useMaterialMeshMap``: bool option with get, set
        abstract ``useClonedMeshMap``: bool option with get, set
        abstract ``useFloatingOrigin``: bool option with get, set
        abstract ``virtual``: bool option with get, set
        abstract ``defaultCameraLayerMask``: float option with get, set
        abstract ``defaultRenderableLayerMask``: float option with get, set

    /// @babylonjs/core/Misc/snapshotRenderingHelper
    [<AllowNullLiteral>]
    type SnapshotRenderingHelpersOptions =
        abstract ``morphTargetsNumMaxInfluences``: float option with get, set

    /// @babylonjs/core/Sprites/spriteRenderer
    [<AllowNullLiteral>]
    type SpriteRendererOptions =
        abstract ``pixelPerfect``: bool option with get, set

    /// @babylonjs/core/Engines/thinEngine.pure
    [<AllowNullLiteral>]
    type TexImageParameters =
        abstract ``internalFormat``: float with get, set
        abstract ``format``: float with get, set
        abstract ``type``: float with get, set

    /// @babylonjs/core/Engines/thinNativeEngine.pure
    [<AllowNullLiteral>]
    type ThinNativeEngineOptions =
        abstract ``adaptToDeviceRatio``: bool option with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuTintWASM
    [<AllowNullLiteral>]
    type TwgslOptions =
        abstract ``twgsl``: obj option with get, set
        abstract ``jsPath``: string option with get, set
        abstract ``wasmPath``: string option with get, set

    /// @babylonjs/core/Materials/Textures/videoTexture.pure
    [<AllowNullLiteral>]
    type VideoTextureSettings =
        abstract ``autoPlay``: bool option with get, set
        abstract ``muted``: bool option with get, set
        abstract ``loop``: bool option with get, set
        abstract ``autoUpdateTexture``: bool with get, set
        abstract ``poster``: string option with get, set
        abstract ``format``: float option with get, set
        abstract ``independentVideoSource``: bool option with get, set

    /// Exact optional-property projection used by Babylon Partial<VideoTextureSettings> signatures.
    [<AllowNullLiteral>]
    type PartialVideoTextureSettings =
        abstract ``autoPlay``: bool option with get, set
        abstract ``muted``: bool option with get, set
        abstract ``loop``: bool option with get, set
        abstract ``autoUpdateTexture``: bool option with get, set
        abstract ``poster``: string option with get, set
        abstract ``format``: float option with get, set
        abstract ``independentVideoSource``: bool option with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUBindGroupLayoutEntryInfo =
        abstract ``name``: string with get, set
        abstract ``index``: float with get, set
        abstract ``nameInArrayOfTexture``: string option with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUBindingInfo =
        abstract ``groupIndex``: float with get, set
        abstract ``bindingIndex``: float with get, set

    /// @babylonjs/core/XR/webXRExperienceHelper
    [<AllowNullLiteral>]
    type WebXRSpectatorModeOption =
        abstract ``fps``: float option with get, set
        abstract ``preferredCameraIndex``: float option with get, set

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type AbstractEngineOptions =
        abstract ``limitDeviceRatio``: float option with get, set
        abstract ``audioEngine``: bool option with get, set
        abstract ``audioEngineOptions``: IAudioEngineOptions option with get, set
        abstract ``deterministicLockstep``: bool option with get, set
        abstract ``lockstepMaxSteps``: float option with get, set
        abstract ``timeStep``: float option with get, set
        abstract ``doNotHandleContextLost``: bool option with get, set
        abstract ``doNotHandleTouchAction``: bool option with get, set
        abstract ``useHighPrecisionMatrix``: bool option with get, set
        abstract ``useLargeWorldRendering``: bool option with get
        abstract ``adaptToDeviceRatio``: bool option with get, set
        abstract ``antialias``: bool option with get, set
        abstract ``stencil``: bool option with get, set
        abstract ``premultipliedAlpha``: bool option with get, set
        abstract ``useExactSrgbConversions``: bool option with get, set
        abstract ``canvasTabIndex``: float option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureIrradianceTextureInfoV1 =
        abstract ``size``: float with get, set
        abstract ``faces``: ResizeArray<BufferImageData> with get, set
        abstract ``dominantDirection``: ResizeArray<float> option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureSpecularInfoV1 =
        abstract ``mipmaps``: ResizeArray<BufferImageData> with get, set
        abstract ``lodGenerationScale``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractAudioOutNode
    [<AllowNullLiteral>]
    type IAbstractAudioOutNodeOptions =
        inherit IAudioAnalyzerOptions
        inherit IVolumeAudioOptions

    /// Exact optional-property projection used by Babylon Partial<IAbstractAudioOutNodeOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractAudioOutNodeOptions =
        inherit PartialIAudioAnalyzerOptions
        inherit PartialIVolumeAudioOptions

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSoundInstance
    [<AllowNullLiteral>]
    type IAbstractSoundInstanceOptions =
        inherit IAbstractSoundPlayOptionsBase

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundPlayOptions =
        inherit IAbstractSoundPlayOptionsBase
        inherit IVolumeAudioOptions

    /// Exact optional-property projection used by Babylon Partial<IAbstractSoundPlayOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractSoundPlayOptions =
        inherit PartialIAbstractSoundPlayOptionsBase
        inherit PartialIVolumeAudioOptions

    /// @babylonjs/core/AudioV2/abstractAudio/abstractSound
    [<AllowNullLiteral>]
    type IAbstractSoundStoredOptions =
        inherit IAbstractSoundOptionsBase
        inherit IAbstractSoundPlayOptionsBase

    /// @babylonjs/core/Animations/animationKey
    [<AllowNullLiteral>]
    type IAnimationKey =
        abstract ``frame``: float with get, set
        abstract ``value``: obj with get, set
        abstract ``inTangent``: obj option with get, set
        abstract ``outTangent``: obj option with get, set
        abstract ``interpolation``: BabylonjsBindings.Enums.AnimationKeyInterpolation option with get, set
        abstract ``lockedTangent``: bool option with get, set
        abstract ``easingFunction``: IEasingFunction option with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type IAttributeMessage =
        inherit IAttributeData
        abstract ``id``: StringLiterala92bfd02c450 with get, set

    /// @babylonjs/core/Behaviors/behavior
    [<AllowNullLiteral>]
    type IBehaviorAware<'T> =
        abstract ``addBehavior``: ``behavior``: Behavior<'T> -> 'T
        abstract ``removeBehavior``: ``behavior``: Behavior<'T> -> 'T
        abstract ``getBehaviorByName``: ``name``: string -> Behavior<'T> option

    /// Exact readonly projection of IColor4Like used by Babylon DeepImmutable<IColor4Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIColor4Like =
        inherit DeepImmutableIColor3Like
        abstract ``a``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IColor4Like =
        inherit DeepImmutableIColor4Like
        inherit IColor3Like
        abstract ``a``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type ICreateTexture2DArrayFromImageUrlsOptions =
        inherit IUploadImageToTexture2DArrayLayerOptions
        abstract ``generateMipMaps``: bool option with get, set
        abstract ``samplingMode``: float option with get, set
        abstract ``textureType``: float option with get, set
        abstract ``imageBitmapOptions``: BrowserImageBitmapOptions option with get, set

    /// @babylonjs/core/Materials/Textures/ktx2decoderTypes
    [<AllowNullLiteral>]
    type IDecodedData =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``transcodedFormat``: float with get, set
        abstract ``mipmaps``: ResizeArray<IMipmap> with get, set
        abstract ``layerCount``: float with get, set
        abstract ``isInGammaSpace``: bool with get, set
        abstract ``hasAlpha``: bool with get, set
        abstract ``transcoderName``: string with get, set
        abstract ``errors``: string option with get, set

    /// @babylonjs/core/DeviceInput/inputInterfaces
    [<AllowNullLiteral>]
    type IDeviceInputSystem =
        inherit IDisposable
        abstract ``pollInput``: ``deviceType``: BabylonjsBindings.Enums.DeviceType * ``deviceSlot``: float * ``inputIndex``: float -> float
        abstract ``isDeviceAvailable``: ``deviceType``: BabylonjsBindings.Enums.DeviceType -> bool

    /// Function-valued IExplorerExtensibilityGroup.predicate property.
    [<AllowNullLiteral>]
    type IExplorerExtensibilityGroupPredicateCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``entity``: obj -> bool

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IExplorerExtensibilityGroup =
        abstract ``predicate``: IExplorerExtensibilityGroupPredicateCallback with get, set
        abstract ``entries``: ResizeArray<IExplorerExtensibilityOption> with get, set

    /// Function-valued IEXRDecoder.scanOrder property.
    [<AllowNullLiteral>]
    type IEXRDecoderScanOrderCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float -> float

    /// Function-valued IEXRDecoder.uncompress property.
    [<AllowNullLiteral>]
    type IEXRDecoderUncompressCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``decoder``: IEXRDecoder -> JS.DataView

    /// Function-valued IEXRDecoder.getter property.
    [<AllowNullLiteral>]
    type IEXRDecoderGetterCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: DataCursor -> float

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<AllowNullLiteral>]
    type IEXRDecoder =
        abstract ``size``: float with get, set
        abstract ``viewer``: JS.DataView with get, set
        abstract ``array``: JS.Uint8Array with get, set
        abstract ``byteArray``: U2<JS.Float32Array, JS.Uint16Array> option with get, set
        abstract ``offset``: DataCursor with get, set
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``channels``: float with get, set
        abstract ``channelLineOffsets``: IDecodeChannel with get, set
        abstract ``scanOrder``: IEXRDecoderScanOrderCallback with get, set
        abstract ``bytesPerLine``: float with get, set
        abstract ``outLineWidth``: float with get, set
        abstract ``lines``: float with get, set
        abstract ``scanlineBlockSize``: float with get, set
        abstract ``inputSize``: float option with get, set
        abstract ``type``: float with get, set
        abstract ``uncompress``: IEXRDecoderUncompressCallback option with get, set
        abstract ``getter``: IEXRDecoderGetterCallback with get, set
        abstract ``format``: float with get, set
        abstract ``outputChannels``: float with get, set
        abstract ``decodeChannels``: IDecodeChannel with get, set
        abstract ``blockCount``: float option with get, set
        abstract ``linearSpace``: bool with get, set
        abstract ``textureType``: float with get, set

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.interfaces
    [<AllowNullLiteral>]
    type IEXRHeader =
        abstract ``version``: float with get, set
        abstract ``spec``: InlineObject672ce066a49aObject with get, set
        abstract ``dataWindow``: InlineObjecte6832153d51cObject with get, set
        abstract ``channels``: ResizeArray<IEXRCHannel> with get, set
        [<EmitIndexer>] abstract Item: ``name``: string -> obj with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphBitwiseBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``valueType``: BabylonjsBindings.StringEnums.FlowGraphTypes with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathCombineExtractBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphCombineMatrixBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``inputIsColumnMajor``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/flowGraphConsoleLogBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphConsoleLogBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``messageTemplate``: string option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphConstantBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphConstantBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``value``: 'T with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphDataSwitchBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphDataSwitchBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``cases``: ResizeArray<BabylonjsBindings.TypeAliases.FlowGraphNumber> with get, set
        abstract ``treatCasesAsIntegers``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphDoNBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphDoNBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``startIndex``: BabylonjsBindings.SimpleClasses.FlowGraphInteger option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphFlipFlopBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphFlipFlopBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``startValue``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphTypeToTypeBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphFloatToIntConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``roundingMode``: U3<StringLiterala3e1f4935b09, StringLiteral0fdfeaa68c7b, StringLiterala97b0931730e> option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphForLoopBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphForLoopBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``initialIndex``: BabylonjsBindings.TypeAliases.FlowGraphNumber option with get, set
        abstract ``incrementIndexWhenLoopDone``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetAssetBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphGetAssetBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``type``: 'T with get, set
        abstract ``index``: U2<float, BabylonjsBindings.SimpleClasses.FlowGraphInteger> option with get, set
        abstract ``useIndexAsUniqueId``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetVariableBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphGetVariableBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``variable``: string with get, set
        abstract ``initialValue``: 'T option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphInterpolationBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphInterpolationBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``keyFramesCount``: float option with get, set
        abstract ``duration``: float option with get, set
        abstract ``propertyName``: U2<string, ResizeArray<string>> option with get, set
        abstract ``animationType``: U2<float, BabylonjsBindings.StringEnums.FlowGraphTypes> option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphKeyboardEventBlock
    [<AllowNullLiteral>]
    type IFlowGraphKeyboardEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``stopPropagation``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphMathBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``useMatrixPerComponent``: bool option with get, set
        abstract ``type``: BabylonjsBindings.StringEnums.FlowGraphTypes option with get, set
        abstract ``preventIntegerFloatArithmetic``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMatrixMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphMatrixBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``matrixType``: BabylonjsBindings.StringEnums.FlowGraphTypes with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphMultiGateBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphMultiGateBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``outputSignalCount``: float with get, set
        abstract ``isRandom``: bool option with get, set
        abstract ``isLoop``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphVectorMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphNormalizeBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``nanOnZeroLength``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPhysicsCollisionEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphPhysicsCollisionEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphRandomBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``min``: float option with get, set
        abstract ``max``: float option with get, set
        abstract ``seed``: float option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphReceiveCustomEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphReceiveCustomEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``eventId``: string with get, set
        abstract ``eventData``: InlineObject8f714ae92303Object with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphRoundBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``roundHalfAwayFromZero``: bool option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphSendCustomEventBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphSendCustomEventBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``eventId``: string with get, set
        abstract ``eventData``: InlineObject4d78ed30f56dObject with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSequenceBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphSequenceBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``outputSignalCount``: float option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetVariableBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphSetVariableBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``variable``: string option with get, set
        abstract ``variables``: ResizeArray<string> option with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSwitchBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphSwitchBlockConfiguration<'T> =
        inherit IFlowGraphBlockConfiguration
        abstract ``cases``: ResizeArray<'T> with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphVectorMathBlocks.pure
    [<AllowNullLiteral>]
    type IFlowGraphTransformBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``vectorType``: BabylonjsBindings.StringEnums.FlowGraphTypes with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphWaitAllBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphWaitAllBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``inputSignalCount``: float with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphWhileLoopBlock.pure
    [<AllowNullLiteral>]
    type IFlowGraphWhileLoopBlockConfiguration =
        inherit IFlowGraphBlockConfiguration
        abstract ``doWhile``: bool option with get, set

    /// @babylonjs/core/Meshes/Builders/textBuilder
    [<AllowNullLiteral>]
    type IFontData =
        abstract ``resolution``: float with get, set
        abstract ``underlineThickness``: float with get, set
        abstract ``boundingBox``: InlineObjecte60cc9a00305Object with get, set
        abstract ``glyphs``: InlineObject1f7e3b7e13b4Object with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAnimationChannel =
        abstract ``sampler``: string with get, set
        abstract ``target``: IGLTFAnimationChannelTarget with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFChildRootProperty =
        inherit IGLTFProperty
        abstract ``name``: string option with get, set

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    [<AllowNullLiteral>]
    type IGLTFLoaderData =
        abstract ``json``: JavaScriptObject with get, set
        abstract ``bin``: IDataBuffer option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFMeshPrimitive =
        inherit IGLTFProperty
        abstract ``attributes``: InlineObject8681f48cdb3dObject with get, set
        abstract ``indices``: string with get, set
        abstract ``material``: string with get, set
        abstract ``mode``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechniqueStates =
        abstract ``enable``: ResizeArray<float> with get, set
        abstract ``functions``: IGLTFTechniqueStatesFunctions with get, set

    /// Function-valued IInspectable.callback property.
    [<AllowNullLiteral>]
    type IInspectableCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// Function-valued IInspectable.fileCallback property.
    [<AllowNullLiteral>]
    type IInspectableFileCallbackCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``file``: Browser.Types.File -> unit

    /// @babylonjs/core/Misc/iInspectable
    [<AllowNullLiteral>]
    type IInspectable =
        abstract ``label``: string with get, set
        abstract ``propertyName``: string with get, set
        abstract ``type``: BabylonjsBindings.Enums.InspectableType with get, set
        abstract ``min``: float option with get, set
        abstract ``max``: float option with get, set
        abstract ``step``: float option with get, set
        abstract ``callback``: IInspectableCallbackCallback option with get, set
        abstract ``fileCallback``: IInspectableFileCallbackCallback option with get, set
        abstract ``options``: ResizeArray<IInspectableOptions> option with get, set
        abstract ``accept``: string option with get, set

    /// @babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill
    [<AllowNullLiteral>]
    type IInstallHtmlInCanvasPolyfillOptions =
        abstract ``force``: bool option with get, set
        abstract ``moduleSpecifier``: string option with get, set
        abstract ``polyfillModule``: IHtmlInCanvasPolyfillModule option with get, set

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IKeyboardEvent =
        inherit IUIEvent
        abstract ``altKey``: bool with get, set
        abstract ``charCode``: float option with get, set
        abstract ``code``: string with get, set
        abstract ``ctrlKey``: bool with get, set
        abstract ``key``: string with get, set
        abstract ``keyCode``: float with get, set
        abstract ``metaKey``: bool with get, set
        abstract ``shiftKey``: bool with get, set
        abstract ``repeat``: bool option with get, set

    /// Exact readonly projection of ILatLonAltLike used by Babylon DeepImmutable<ILatLonAltLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableILatLonAltLike =
        inherit DeepImmutableILatLonLike
        abstract ``alt``: float with get

    /// @babylonjs/core/Maths/math.geospatial
    [<AllowNullLiteral>]
    type ILatLonAltLike =
        inherit DeepImmutableILatLonAltLike
        inherit ILatLonLike
        abstract ``alt``: float with get, set

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type IMakeAnimationGroupAdditiveOptions =
        inherit IMakeAnimationAdditiveOptions
        abstract ``cloneOriginalAnimationGroup``: bool option with get, set
        abstract ``clonedAnimationGroupName``: string option with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMotionControllerLayoutMap =
        [<EmitIndexer>] abstract Item: ``handedness``: string -> IMotionControllerLayout with get, set

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IMouseEvent =
        inherit IUIEvent
        abstract ``inputIndex``: PointerInputExcluding6a48353fe9 with get, set
        abstract ``altKey``: bool with get, set
        abstract ``button``: float with get, set
        abstract ``buttons``: float with get, set
        abstract ``clientX``: float with get, set
        abstract ``clientY``: float with get, set
        abstract ``ctrlKey``: bool with get, set
        abstract ``detail``: float option with get, set
        abstract ``metaKey``: bool with get, set
        abstract ``movementX``: float with get, set
        abstract ``movementY``: float with get, set
        abstract ``mozMovementX``: float option with get, set
        abstract ``mozMovementY``: float option with get, set
        abstract ``msMovementX``: float option with get, set
        abstract ``msMovementY``: float option with get, set
        abstract ``offsetX``: float with get, set
        abstract ``offsetY``: float with get, set
        abstract ``pageX``: float with get, set
        abstract ``pageY``: float with get, set
        abstract ``shiftKey``: bool with get, set
        abstract ``webkitMovementX``: float option with get, set
        abstract ``webkitMovementY``: float option with get, set
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type IPath2D =
        abstract ``addPath``: ``path``: IPath2D * ?``transform``: DOMMatrix -> unit
        abstract ``closePath``: unit -> unit
        abstract ``moveTo``: ``x``: float * ``y``: float -> unit
        abstract ``lineTo``: ``x``: float * ``y``: float -> unit
        abstract ``bezierCurveTo``: ``cp1x``: float * ``cp1y``: float * ``cp2x``: float * ``cp2y``: float * ``x``: float * ``y``: float -> unit
        abstract ``quadraticCurveTo``: ``cpx``: float * ``cpy``: float * ``x``: float * ``y``: float -> unit
        abstract ``arc``: ``x``: float * ``y``: float * ``radius``: float * ``startAngle``: float * ``endAngle``: float * ?``counterclockwise``: bool -> unit
        abstract ``arcTo``: ``x1``: float * ``y1``: float * ``x2``: float * ``y2``: float * ``radius``: float -> unit
        abstract ``ellipse``: ``x``: float * ``y``: float * ``radiusX``: float * ``radiusY``: float * ``rotation``: float * ``startAngle``: float * ``endAngle``: float * ?``counterclockwise``: bool -> unit
        abstract ``rect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``roundRect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float * ``radii``: float -> unit

    /// @babylonjs/core/Misc/observable.pure
    [<AllowNullLiteral>]
    type IReadonlyObservable<'T> =
        abstract ``add``: ``callback``: System.Action<'T, BabylonjsBindings.SimpleClasses.EventState> * ?``mask``: float * ?``insertFirst``: bool * ?``scope``: obj * ?``unregisterOnFirstCall``: bool -> IObserver
        abstract ``addOnce``: ``callback``: System.Action<'T, BabylonjsBindings.SimpleClasses.EventState> -> IObserver

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type ISceneLike =
        abstract ``addPendingData``: ``data``: obj -> unit
        abstract ``removePendingData``: ``data``: obj -> unit
        abstract ``offlineProvider``: IOfflineProvider with get, set

    /// Function-valued ISceneLoaderPluginMetadata.canDirectLoad property.
    [<AllowNullLiteral>]
    type ISceneLoaderPluginMetadataCanDirectLoadCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: string -> bool

    /// @babylonjs/core/Loading/sceneLoader
    [<AllowNullLiteral>]
    type ISceneLoaderPluginMetadata =
        abstract ``name``: string with get
        abstract ``extensions``: U2<string, ISceneLoaderPluginExtensions> with get
        abstract ``canDirectLoad``: ISceneLoaderPluginMetadataCanDirectLoadCallback option with get, set

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type ISerializedFlowGraphBlock =
        abstract ``className``: string with get, set
        abstract ``type``: string with get, set
        abstract ``config``: obj with get, set
        abstract ``uniqueId``: string with get, set
        abstract ``dataInputs``: ResizeArray<ISerializedFlowGraphConnection> with get, set
        abstract ``dataOutputs``: ResizeArray<ISerializedFlowGraphConnection> with get, set
        abstract ``metadata``: obj with get, set
        abstract ``signalInputs``: ResizeArray<ISerializedFlowGraphConnection> with get, set
        abstract ``signalOutputs``: ResizeArray<ISerializedFlowGraphConnection> with get, set

    /// Function-valued IShaderProcessor.preProcessShaderCode property.
    [<AllowNullLiteral>]
    type IShaderProcessorPreProcessShaderCodeCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string * ``isFragment``: bool -> string

    /// Function-valued IShaderProcessor.attributeProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorAttributeProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``attribute``: string * ``preProcessors``: InlineObject8681f48cdb3dObject * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.varyingCheck property.
    [<AllowNullLiteral>]
    type IShaderProcessorVaryingCheckCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``varying``: string * ``isFragment``: bool -> bool

    /// Function-valued IShaderProcessor.varyingProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorVaryingProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``varying``: string * ``isFragment``: bool * ``preProcessors``: InlineObject8681f48cdb3dObject * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.uniformProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorUniformProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``uniform``: string * ``isFragment``: bool * ``preProcessors``: InlineObject8681f48cdb3dObject * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.uniformBufferProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorUniformBufferProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``uniformBuffer``: string * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.textureProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorTextureProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: string * ``isFragment``: bool * ``preProcessors``: InlineObject8681f48cdb3dObject * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.endOfUniformBufferProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorEndOfUniformBufferProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``closingBracketLine``: string * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.lineProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorLineProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``line``: string * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.preProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorPreProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string * ``defines``: ResizeArray<string> * ``preProcessors``: InlineObject8681f48cdb3dObject * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option -> string

    /// Function-valued IShaderProcessor.postProcessor property.
    [<AllowNullLiteral>]
    type IShaderProcessorPostProcessorCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``code``: string * ``defines``: ResizeArray<string> * ``isFragment``: bool * ``processingContext``: _IShaderProcessingContext option * ``patameters``: InlineObjectff2afb4ca968Object * ``preProcessors``: InlineObject8681f48cdb3dObject * ``preProcessorsFromCode``: InlineObject8681f48cdb3dObject -> string

    /// Function-valued IShaderProcessor.initializeShaders property.
    [<AllowNullLiteral>]
    type IShaderProcessorInitializeShadersCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``processingContext``: _IShaderProcessingContext option -> unit

    /// Function-valued IShaderProcessor.finalizeShaders property.
    [<AllowNullLiteral>]
    type IShaderProcessorFinalizeShadersCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``vertexCode``: string * ``fragmentCode``: string * ``processingContext``: _IShaderProcessingContext option -> InlineObjectafdc7fcd70d1Object

    /// @babylonjs/core/Engines/Processors/iShaderProcessor
    [<AllowNullLiteral>]
    type IShaderProcessor =
        abstract ``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage with get, set
        abstract ``uniformRegexp``: BrowserRegExp option with get, set
        abstract ``uniformBufferRegexp``: BrowserRegExp option with get, set
        abstract ``textureRegexp``: BrowserRegExp option with get, set
        abstract ``noPrecision``: bool option with get, set
        abstract ``parseGLES3``: bool option with get, set
        abstract ``attributeKeywordName``: string option with get, set
        abstract ``varyingVertexKeywordName``: string option with get, set
        abstract ``varyingFragmentKeywordName``: string option with get, set
        abstract ``preProcessShaderCode``: IShaderProcessorPreProcessShaderCodeCallback option with get, set
        abstract ``attributeProcessor``: IShaderProcessorAttributeProcessorCallback option with get, set
        abstract ``varyingCheck``: IShaderProcessorVaryingCheckCallback option with get, set
        abstract ``varyingProcessor``: IShaderProcessorVaryingProcessorCallback option with get, set
        abstract ``uniformProcessor``: IShaderProcessorUniformProcessorCallback option with get, set
        abstract ``uniformBufferProcessor``: IShaderProcessorUniformBufferProcessorCallback option with get, set
        abstract ``textureProcessor``: IShaderProcessorTextureProcessorCallback option with get, set
        abstract ``endOfUniformBufferProcessor``: IShaderProcessorEndOfUniformBufferProcessorCallback option with get, set
        abstract ``lineProcessor``: IShaderProcessorLineProcessorCallback option with get, set
        abstract ``preProcessor``: IShaderProcessorPreProcessorCallback option with get, set
        abstract ``postProcessor``: IShaderProcessorPostProcessorCallback option with get, set
        abstract ``initializeShaders``: IShaderProcessorInitializeShadersCallback option with get, set
        abstract ``finalizeShaders``: IShaderProcessorFinalizeShadersCallback option with get, set

    /// @babylonjs/core/Debug/ISkeletonViewer
    [<AllowNullLiteral>]
    type ISkeletonViewerOptions =
        abstract ``pauseAnimations``: bool with get, set
        abstract ``returnToRest``: bool with get, set
        abstract ``displayMode``: float with get, set
        abstract ``displayOptions``: ISkeletonViewerDisplayOptions with get, set
        abstract ``computeBonesUsingShaders``: bool with get, set
        abstract ``useAllBones``: bool with get, set

    /// Exact optional-property projection used by Babylon Partial<ISkeletonViewerOptions> signatures.
    [<AllowNullLiteral>]
    type PartialISkeletonViewerOptions =
        abstract ``pauseAnimations``: bool option with get, set
        abstract ``returnToRest``: bool option with get, set
        abstract ``displayMode``: float option with get, set
        abstract ``displayOptions``: ISkeletonViewerDisplayOptions option with get, set
        abstract ``computeBonesUsingShaders``: bool option with get, set
        abstract ``useAllBones``: bool option with get, set

    /// @babylonjs/core/Sprites/ISprites
    [<AllowNullLiteral>]
    type ISpriteJSONSprite =
        abstract ``filename``: string with get, set
        abstract ``frame``: ISpriteJSONSpriteFrameData with get, set
        abstract ``rotated``: bool with get, set
        abstract ``trimmed``: bool with get, set
        abstract ``spriteSourceSize``: ISpriteJSONSpriteFrameData with get, set
        abstract ``sourceSize``: ISpriteJSONSpriteSourceSize with get, set

    /// @babylonjs/core/States/IStencilState
    [<AllowNullLiteral>]
    type IStencilState =
        inherit IStencilStateProperties
        abstract ``reset``: unit -> unit

    /// @babylonjs/core/Materials/Textures/Packer/packer
    [<AllowNullLiteral>]
    type ITexturePackerJSON =
        abstract ``name``: string with get, set
        abstract ``sets``: obj with get, set
        abstract ``options``: ITexturePackerOptions with get, set
        abstract ``frames``: ResizeArray<float> with get, set

    /// Function-valued ITimerOptions.breakCondition property.
    [<AllowNullLiteral>]
    type ITimerOptionsBreakConditionCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ?``data``: ITimerData<'T> -> bool

    /// Function-valued ITimerOptions.onEnded property.
    [<AllowNullLiteral>]
    type ITimerOptionsOnEndedCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: ITimerData<obj> -> unit

    /// Function-valued ITimerOptions.onAborted property.
    [<AllowNullLiteral>]
    type ITimerOptionsOnAbortedCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: ITimerData<obj> -> unit

    /// Function-valued ITimerOptions.onTick property.
    [<AllowNullLiteral>]
    type ITimerOptionsOnTickCallback<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: ITimerData<obj> -> unit

    /// @babylonjs/core/Misc/timer
    [<AllowNullLiteral>]
    type ITimerOptions<'T> =
        abstract ``timeout``: float with get, set
        abstract ``contextObservable``: BabylonjsBindings.SimpleClasses.Observable<'T> with get, set
        abstract ``observableParameters``: InlineObject5839704047beObject<'T> option with get, set
        abstract ``breakCondition``: ITimerOptionsBreakConditionCallback<'T> option with get, set
        abstract ``onEnded``: ITimerOptionsOnEndedCallback<'T> option with get, set
        abstract ``onAborted``: ITimerOptionsOnAbortedCallback<'T> option with get, set
        abstract ``onTick``: ITimerOptionsOnTickCallback<'T> option with get, set

    /// Exact readonly projection of IVector3Like used by Babylon DeepImmutable<IVector3Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIVector3Like =
        inherit DeepImmutableIVector2Like
        abstract ``z``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IVector3Like =
        inherit DeepImmutableIVector3Like
        inherit IVector2Like
        abstract ``z``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.dom.pure
    [<AllowNullLiteral>]
    type IViewportOwnerLike =
        abstract ``viewport``: IViewportLike with get, set

    /// @babylonjs/core/AudioV2/webAudio/subNodes/webAudioBaseSubGraph
    [<AllowNullLiteral>]
    type IWebAudioBaseSubGraphOptions =
        inherit IAudioAnalyzerOptions
        inherit IVolumeAudioOptions

    /// Exact optional-property projection used by Babylon Partial<IWebAudioBaseSubGraphOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebAudioBaseSubGraphOptions =
        inherit PartialIAudioAnalyzerOptions
        inherit PartialIVolumeAudioOptions

    /// Function-valued IWebXRFeature.getXRSessionInitExtension property.
    [<AllowNullLiteral>]
    type IWebXRFeatureGetXRSessionInitExtensionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> JS.Promise<BrowserXRSessionInit>

    /// @babylonjs/core/XR/webXRFeaturesManager
    [<AllowNullLiteral>]
    type IWebXRFeature =
        inherit IDisposable
        abstract ``attached``: bool with get, set
        abstract ``disableAutoAttach``: bool with get, set
        abstract ``attach``: ?``force``: bool -> bool
        abstract ``detach``: unit -> bool
        abstract ``isCompatible``: unit -> bool
        abstract ``isDisposed``: bool with get, set
        abstract ``xrNativeFeatureName``: string option with get, set
        abstract ``dependsOn``: ResizeArray<string> option with get, set
        abstract ``getXRSessionInitExtension``: IWebXRFeatureGetXRSessionInitExtensionCallback option with get, set
        abstract ``onFeatureAttachObservable``: BabylonjsBindings.SimpleClasses.Observable<IWebXRFeature> with get, set
        abstract ``onFeatureDetachObservable``: BabylonjsBindings.SimpleClasses.Observable<IWebXRFeature> with get, set

    /// @babylonjs/core/XR/webXRInput
    [<AllowNullLiteral>]
    type IWebXRInputOptions =
        abstract ``doNotLoadControllerMeshes``: bool option with get, set
        abstract ``forceInputProfile``: string option with get, set
        abstract ``disableOnlineControllerRepository``: bool option with get, set
        abstract ``customControllersRepositoryURL``: string option with get, set
        abstract ``disableControllerAnimation``: bool option with get, set
        abstract ``controllerOptions``: IWebXRControllerOptions option with get, set

    /// Exact optional-property projection used by Babylon Partial<IWebXRInputOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIWebXRInputOptions =
        abstract ``doNotLoadControllerMeshes``: bool option with get, set
        abstract ``forceInputProfile``: string option with get, set
        abstract ``disableOnlineControllerRepository``: bool option with get, set
        abstract ``customControllersRepositoryURL``: string option with get, set
        abstract ``disableControllerAnimation``: bool option with get, set
        abstract ``controllerOptions``: IWebXRControllerOptions option with get, set

    /// @babylonjs/core/XR/motionController/webXRControllerComponent
    [<AllowNullLiteral>]
    type IWebXRMotionControllerComponentChanges =
        abstract ``axes``: IWebXRMotionControllerComponentChangesValues<IWebXRMotionControllerAxesValue> option with get, set
        abstract ``pressed``: IWebXRMotionControllerComponentChangesValues<bool> option with get, set
        abstract ``touched``: IWebXRMotionControllerComponentChangesValues<bool> option with get, set
        abstract ``value``: IWebXRMotionControllerComponentChangesValues<float> option with get, set

    /// @babylonjs/core/Meshes/Compression/dracoDecoder.types
    [<AllowNullLiteral>]
    type MeshData =
        abstract ``indices``: U2<JS.Uint16Array, JS.Uint32Array> option with get, set
        abstract ``attributes``: ResizeArray<IAttributeData> with get, set
        abstract ``totalVertices``: float with get, set

    /// @babylonjs/core/Engines/nativeEngine.pure
    [<AllowNullLiteral>]
    type NativeEngineOptions =
        inherit ThinNativeEngineOptions

    /// @babylonjs/core/Sprites/spriteManager
    [<AllowNullLiteral>]
    type SpriteManagerOptions =
        abstract ``spriteRendererOptions``: SpriteRendererOptions with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUBufferDescription =
        abstract ``binding``: WebGPUBindingInfo with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUSamplerDescription =
        abstract ``binding``: WebGPUBindingInfo with get, set
        abstract ``type``: BrowserGPUSamplerBindingType with get, set

    /// @babylonjs/core/Engines/WebGPU/webgpuShaderProcessingContext
    [<AllowNullLiteral>]
    type WebGPUTextureDescription =
        abstract ``autoBindSampler``: bool option with get, set
        abstract ``isTextureArray``: bool with get, set
        abstract ``isStorageTexture``: bool with get, set
        abstract ``storageTextureAccess``: BrowserGPUStorageTextureAccess option with get, set
        abstract ``textures``: ResizeArray<WebGPUBindingInfo> with get, set
        abstract ``sampleType``: BrowserGPUTextureSampleType option with get, set

    /// @babylonjs/core/XR/webXRTypes
    [<AllowNullLiteral>]
    type WebXRRenderTarget<'TContext, 'TLayer when 'TLayer :> BrowserXRLayer> =
        inherit IDisposable
        abstract ``canvasContext``: 'TContext with get, set
        abstract ``xrLayer``: 'TLayer option with get, set
        abstract ``initializeXRLayerAsync``: ``xrSession``: BrowserXRSession -> JS.Promise<'TLayer>

    /// @babylonjs/core/Engines/Processors/shaderProcessingOptions
    [<AllowNullLiteral>]
    type _IProcessingOptions =
        abstract ``defines``: ResizeArray<string> with get, set
        abstract ``indexParameters``: obj with get, set
        abstract ``isFragment``: bool with get, set
        abstract ``shouldUseHighPrecisionShader``: bool with get, set
        abstract ``supportsUniformBuffers``: bool with get, set
        abstract ``shadersRepository``: string with get, set
        abstract ``includesShadersStore``: InlineObject8681f48cdb3dObject with get, set
        abstract ``processor``: IShaderProcessor option with get, set
        abstract ``version``: string with get, set
        abstract ``platformName``: string with get, set
        abstract ``lookForClosingBracketForUniformBuffer``: bool option with get, set
        abstract ``processingContext``: _IShaderProcessingContext option with get, set
        abstract ``isNDCHalfZRange``: bool with get, set
        abstract ``useReverseDepthBuffer``: bool with get, set
        abstract ``processCodeAfterIncludes``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set

    /// Exact optional-property projection used by Babylon Partial<_IProcessingOptions> signatures.
    [<AllowNullLiteral>]
    type Partial_IProcessingOptions =
        abstract ``defines``: ResizeArray<string> option with get, set
        abstract ``indexParameters``: obj option with get, set
        abstract ``isFragment``: bool option with get, set
        abstract ``shouldUseHighPrecisionShader``: bool option with get, set
        abstract ``supportsUniformBuffers``: bool option with get, set
        abstract ``shadersRepository``: string option with get, set
        abstract ``includesShadersStore``: InlineObject8681f48cdb3dObject option with get, set
        abstract ``processor``: IShaderProcessor option with get, set
        abstract ``version``: string option with get, set
        abstract ``platformName``: string option with get, set
        abstract ``lookForClosingBracketForUniformBuffer``: bool option with get, set
        abstract ``processingContext``: _IShaderProcessingContext option with get, set
        abstract ``isNDCHalfZRange``: bool option with get, set
        abstract ``useReverseDepthBuffer``: bool option with get, set
        abstract ``processCodeAfterIncludes``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option with get, set

    /// @babylonjs/core/Engines/thinEngine.pure
    [<AllowNullLiteral>]
    type EngineOptions =
        inherit AbstractEngineOptions
        inherit Browser.Types.WebGLContextAttributes
        abstract ``disableWebGL2Support``: bool option with get, set
        abstract ``useHighPrecisionFloats``: bool option with get, set
        abstract ``xrCompatible``: bool option with get, set
        abstract ``failIfMajorPerformanceCaveat``: bool option with get, set
        abstract ``forceSRGBBufferSupportState``: bool option with get, set
        abstract ``loseContextOnDispose``: bool option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureIrradianceInfoV1 =
        abstract ``x``: ResizeArray<float> with get, set
        abstract ``y``: ResizeArray<float> with get, set
        abstract ``z``: ResizeArray<float> with get, set
        abstract ``xx``: ResizeArray<float> with get, set
        abstract ``yy``: ResizeArray<float> with get, set
        abstract ``zz``: ResizeArray<float> with get, set
        abstract ``yz``: ResizeArray<float> with get, set
        abstract ``zx``: ResizeArray<float> with get, set
        abstract ``xy``: ResizeArray<float> with get, set
        abstract ``irradianceTexture``: EnvironmentTextureIrradianceTextureInfoV1 option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/abstractAudioBus
    [<AllowNullLiteral>]
    type IAbstractAudioBusOptions =
        inherit IAbstractAudioOutNodeOptions

    /// Exact optional-property projection used by Babylon Partial<IAbstractAudioBusOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIAbstractAudioBusOptions =
        inherit PartialIAbstractAudioOutNodeOptions

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IExplorerAdditionalChild =
        abstract ``name``: string with get, set
        abstract ``getClassName``: unit -> string
        abstract ``inspectableCustomProperties``: ResizeArray<IInspectable> with get, set

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphKeyDownEventBlock
    [<AllowNullLiteral>]
    type IFlowGraphKeyDownEventBlockConfiguration =
        inherit IFlowGraphKeyboardEventBlockConfiguration
        abstract ``ignoreRepeat``: bool option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAccessor =
        inherit IGLTFChildRootProperty
        abstract ``bufferView``: string with get, set
        abstract ``byteOffset``: float with get, set
        abstract ``byteStride``: float with get, set
        abstract ``count``: float with get, set
        abstract ``type``: string with get, set
        abstract ``componentType``: BabylonjsBindings.Enums.EComponentType with get, set
        abstract ``max``: ResizeArray<float> option with get, set
        abstract ``min``: ResizeArray<float> option with get, set
        abstract ``name``: string option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFAnimation =
        inherit IGLTFChildRootProperty
        abstract ``channels``: ResizeArray<IGLTFAnimationChannel> option with get, set
        abstract ``parameters``: InlineObject8681f48cdb3dObject option with get, set
        abstract ``samplers``: InlineObject249788b2ccc7Object option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFBuffer =
        inherit IGLTFChildRootProperty
        abstract ``uri``: string with get, set
        abstract ``byteLength``: float option with get, set
        abstract ``type``: string option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFBufferView =
        inherit IGLTFChildRootProperty
        abstract ``buffer``: string with get, set
        abstract ``byteOffset``: float with get, set
        abstract ``byteLength``: float with get, set
        abstract ``byteStride``: float with get, set
        abstract ``target``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFCamera =
        inherit IGLTFChildRootProperty
        abstract ``type``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFImage =
        inherit IGLTFChildRootProperty
        abstract ``uri``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFLight =
        inherit IGLTFChildRootProperty
        abstract ``type``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFMaterial =
        inherit IGLTFChildRootProperty
        abstract ``technique``: string option with get, set
        abstract ``values``: ResizeArray<string> with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFMesh =
        inherit IGLTFChildRootProperty
        abstract ``primitives``: ResizeArray<IGLTFMeshPrimitive> with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFProgram =
        inherit IGLTFChildRootProperty
        abstract ``attributes``: ResizeArray<string> with get, set
        abstract ``fragmentShader``: string with get, set
        abstract ``vertexShader``: string with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFSampler =
        inherit IGLTFChildRootProperty
        abstract ``magFilter``: float option with get, set
        abstract ``minFilter``: float option with get, set
        abstract ``wrapS``: float option with get, set
        abstract ``wrapT``: float option with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFScene =
        inherit IGLTFChildRootProperty
        abstract ``nodes``: ResizeArray<string> with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFShader =
        inherit IGLTFChildRootProperty
        abstract ``uri``: string with get, set
        abstract ``type``: BabylonjsBindings.Enums.EShaderType with get, set

    /// @babylonjs/loaders/glTF/1.0/glTFLoaderInterfaces
    [<AllowNullLiteral>]
    type IGLTFTechnique =
        inherit IGLTFChildRootProperty
        abstract ``parameters``: InlineObjectc6343ebc447eObject with get, set
        abstract ``program``: string with get, set
        abstract ``attributes``: InlineObject8681f48cdb3dObject with get, set
        abstract ``uniforms``: InlineObject8681f48cdb3dObject with get, set
        abstract ``states``: IGLTFTechniqueStates with get, set

    /// @babylonjs/core/XR/motionController/webXRAbstractMotionController
    [<AllowNullLiteral>]
    type IMotionControllerProfile =
        abstract ``fallbackProfileIds``: ResizeArray<string> with get, set
        abstract ``layouts``: IMotionControllerLayoutMap with get, set
        abstract ``profileId``: string with get, set

    /// Exact readonly projection of IPlaneLike used by Babylon DeepImmutable<IPlaneLike> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIPlaneLike =
        abstract ``normal``: DeepImmutableIVector3Like with get
        abstract ``d``: BabylonjsBindings.TypeAliases.float with get
        abstract ``normalize``: unit -> unit

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IPlaneLike =
        inherit DeepImmutableIPlaneLike
        abstract ``normal``: IVector3Like with get, set
        abstract ``d``: BabylonjsBindings.TypeAliases.float with get, set
        abstract ``normalize``: unit -> unit

    /// @babylonjs/core/Events/deviceInputEvents
    [<AllowNullLiteral>]
    type IPointerEvent =
        inherit IMouseEvent
        abstract ``inputIndex``: PointerInputExcluding9b1eb22bd0 with get, set
        abstract ``pointerId``: float with get, set
        abstract ``pointerType``: string with get, set

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IQuaternionLike =
        inherit IVector3Like
        abstract ``w``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/FlowGraph/typeDefinitions
    [<AllowNullLiteral>]
    type ISerializedFlowGraph =
        abstract ``name``: string option with get, set
        abstract ``uniqueId``: string option with get, set
        abstract ``executionContexts``: ResizeArray<ISerializedFlowGraphContext> with get, set
        abstract ``allBlocks``: ResizeArray<ISerializedFlowGraphBlock> with get, set
        abstract ``rightHanded``: bool option with get, set

    /// @babylonjs/core/Sprites/ISprites
    [<AllowNullLiteral>]
    type ISpriteJSONAtlas =
        abstract ``frames``: ResizeArray<ISpriteJSONSprite> with get, set
        abstract ``meta``: JavaScriptObject option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSoundInstance
    [<AllowNullLiteral>]
    type IStaticSoundInstanceOptions =
        inherit IAbstractSoundInstanceOptions
        inherit IStaticSoundOptionsBase

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundPlayOptions =
        inherit IAbstractSoundPlayOptions
        inherit IStaticSoundOptionsBase
        abstract ``waitTime``: float with get, set

    /// Exact optional-property projection used by Babylon Partial<IStaticSoundPlayOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStaticSoundPlayOptions =
        inherit PartialIAbstractSoundPlayOptions
        inherit PartialIStaticSoundOptionsBase
        abstract ``waitTime``: float option with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/staticSound
    [<AllowNullLiteral>]
    type IStaticSoundStoredOptions =
        inherit IAbstractSoundStoredOptions
        inherit IStaticSoundOptionsBase
        abstract ``pitch``: float with get, set
        abstract ``playbackRate``: float with get, set

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSoundInstance
    [<AllowNullLiteral>]
    type IStreamingSoundInstanceOptions =
        inherit IAbstractSoundInstanceOptions
        inherit IStreamingSoundOptionsBase

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSound
    [<AllowNullLiteral>]
    type IStreamingSoundPlayOptions =
        inherit IAbstractSoundPlayOptions

    /// Exact optional-property projection used by Babylon Partial<IStreamingSoundPlayOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIStreamingSoundPlayOptions =
        inherit PartialIAbstractSoundPlayOptions

    /// @babylonjs/core/AudioV2/abstractAudio/streamingSound
    [<AllowNullLiteral>]
    type IStreamingSoundStoredOptions =
        inherit IAbstractSoundStoredOptions
        inherit IStreamingSoundOptionsBase

    /// Exact readonly projection of IVector4Like used by Babylon DeepImmutable<IVector4Like> signatures.
    [<AllowNullLiteral>]
    type DeepImmutableIVector4Like =
        inherit DeepImmutableIVector3Like
        abstract ``w``: BabylonjsBindings.TypeAliases.float with get

    /// @babylonjs/core/Maths/math.like
    [<AllowNullLiteral>]
    type IVector4Like =
        inherit DeepImmutableIVector4Like
        inherit IVector3Like
        abstract ``w``: BabylonjsBindings.TypeAliases.float with get, set

    /// @babylonjs/core/Engines/webgpuEngine.pure
    [<AllowNullLiteral>]
    type WebGPUEngineOptions =
        inherit AbstractEngineOptions
        inherit BrowserGPURequestAdapterOptions
        abstract ``featureLevel``: string option with get, set
        abstract ``powerPreference``: BrowserGPUPowerPreference option with get, set
        abstract ``forceFallbackAdapter``: bool option with get, set
        abstract ``xrCompatible``: bool option with get, set
        abstract ``deviceDescriptor``: BrowserGPUDeviceDescriptor option with get, set
        abstract ``enableAllFeatures``: bool option with get, set
        abstract ``setMaximumLimits``: bool option with get, set
        abstract ``swapChainFormat``: BrowserGPUTextureFormat option with get, set
        abstract ``enableGPUDebugMarkers``: bool option with get, set
        abstract ``glslangOptions``: GlslangOptions option with get, set
        abstract ``twgslOptions``: TwgslOptions option with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureInfoV1 =
        abstract ``version``: NumericLiteral1 with get, set
        abstract ``width``: float with get, set
        abstract ``irradiance``: EnvironmentTextureIrradianceInfoV1 option with get, set
        abstract ``specular``: EnvironmentTextureSpecularInfoV1 with get, set

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type EnvironmentTextureInfoV2 =
        abstract ``version``: NumericLiteral2 with get, set
        abstract ``width``: float with get, set
        abstract ``irradiance``: EnvironmentTextureIrradianceInfoV1 option with get, set
        abstract ``specular``: EnvironmentTextureSpecularInfoV1 with get, set
        abstract ``imageType``: string with get, set
        abstract ``binaryDataPosition``: float option with get, set

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type IExplorerAdditionalNode =
        abstract ``name``: string with get, set
        abstract ``getContent``: unit -> ResizeArray<IExplorerAdditionalChild>

    /// @babylonjs/core/AudioV2/abstractAudio/mainAudioBus
    [<AllowNullLiteral>]
    type IMainAudioBusOptions =
        inherit IAbstractAudioBusOptions

    /// Exact optional-property projection used by Babylon Partial<IMainAudioBusOptions> signatures.
    [<AllowNullLiteral>]
    type PartialIMainAudioBusOptions =
        inherit PartialIAbstractAudioBusOptions

    /// Function-valued ICanvas.remove property.
    [<AllowNullLiteral>]
    type ICanvasRemoveCallback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type ICanvas =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``getContext``: ``contextType``: string * ?``contextAttributes``: obj -> ICanvasRenderingContext
        abstract ``toDataURL``: ``mime``: string -> string
        abstract ``remove``: ICanvasRemoveCallback option with get, set

    /// @babylonjs/core/Engines/ICanvas
    [<AllowNullLiteral>]
    type ICanvasRenderingContext =
        abstract ``lineJoin``: string with get, set
        abstract ``miterLimit``: float with get, set
        abstract ``font``: string with get, set
        abstract ``strokeStyle``: U2<string, ICanvasGradient> with get, set
        abstract ``fillStyle``: U2<string, ICanvasGradient> with get, set
        abstract ``filter``: string with get, set
        abstract ``globalAlpha``: float with get, set
        abstract ``shadowColor``: string with get, set
        abstract ``shadowBlur``: float with get, set
        abstract ``shadowOffsetX``: float with get, set
        abstract ``shadowOffsetY``: float with get, set
        abstract ``lineWidth``: float with get, set
        abstract ``canvas``: ICanvas with get
        abstract ``clearRect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``save``: unit -> unit
        abstract ``restore``: unit -> unit
        abstract ``fillRect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``scale``: ``x``: float * ``y``: float -> unit
        abstract ``rotate``: ``angle``: float -> unit
        abstract ``translate``: ``x``: float * ``y``: float -> unit
        abstract ``strokeRect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``rect``: ``x``: float * ``y``: float * ``width``: float * ``height``: float -> unit
        abstract ``clip``: unit -> unit
        abstract ``putImageData``: ``imageData``: Browser.Types.ImageData * ``dx``: float * ``dy``: float -> unit
        abstract ``arc``: ``x``: float * ``y``: float * ``radius``: float * ``startAngle``: float * ``endAngle``: float * ?``anticlockwise``: bool -> unit
        abstract ``beginPath``: unit -> unit
        abstract ``closePath``: unit -> unit
        abstract ``moveTo``: ``x``: float * ``y``: float -> unit
        abstract ``lineTo``: ``x``: float * ``y``: float -> unit
        abstract ``quadraticCurveTo``: ``cpx``: float * ``cpy``: float * ``x``: float * ``y``: float -> unit
        abstract ``measureText``: ``text``: string -> ITextMetrics
        abstract ``stroke``: ?``path``: IPath2D -> unit
        abstract ``fill``: unit -> unit
        abstract ``drawImage``: ``image``: obj * ``sx``: float * ``sy``: float * ``sWidth``: float * ``sHeight``: float * ``dx``: float * ``dy``: float * ``dWidth``: float * ``dHeight``: float -> unit
        abstract ``drawImage``: ``image``: obj * ``dx``: float * ``dy``: float * ``dWidth``: float * ``dHeight``: float -> unit
        abstract ``drawImage``: ``image``: obj * ``dx``: float * ``dy``: float -> unit
        abstract ``getImageData``: ``sx``: float * ``sy``: float * ``sw``: float * ``sh``: float -> Browser.Types.ImageData
        abstract ``setLineDash``: ``segments``: ResizeArray<float> -> unit
        abstract ``fillText``: ``text``: string * ``x``: float * ``y``: float * ?``maxWidth``: float -> unit
        abstract ``strokeText``: ``text``: string * ``x``: float * ``y``: float * ?``maxWidth``: float -> unit
        abstract ``createLinearGradient``: ``x0``: float * ``y0``: float * ``x1``: float * ``y1``: float -> ICanvasGradient
        abstract ``createRadialGradient``: ``x0``: float * ``y0``: float * ``r0``: float * ``x1``: float * ``y1``: float * ``r1``: float -> ICanvasGradient
        abstract ``setTransform``: ``a``: float * ``b``: float * ``c``: float * ``d``: float * ``e``: float * ``f``: float -> unit
        abstract ``getTransform``: unit -> DOMMatrix
