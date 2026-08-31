// REVIEWED-PROMOTION PROPOSAL — move to maintained source only after function review, compile, import, and runtime proof
namespace BabylonjsBindings

open Fable.Core

/// Exact dependency-closed functions exported by Babylon.js 9.19.0.
module SimpleFunctions =

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectcea48f3826e5 =
        abstract ``w``: float with get, set
        abstract ``h``: float with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectd76e3eabe256 =
        [<EmitIndexer>] abstract Item: ``key``: string -> string with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject5a70f99fb156 =
        abstract ``segments``: float option with get, set
        abstract ``diameter``: float option with get, set
        abstract ``sideOrientation``: float option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject92022eb5df33 =
        abstract ``size``: float option with get, set
        abstract ``resolution``: float option with get, set
        abstract ``depth``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``perLetterFaceUV``: System.Func<float, ResizeArray<BabylonjsBindings.SimpleClasses.Vector4>> option with get, set
        abstract ``perLetterFaceColors``: System.Func<float, ResizeArray<BabylonjsBindings.SimpleClasses.Color4>> option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject029dbaa31b1f =
        abstract ``m``: float option with get, set
        abstract ``n``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``sizeX``: float option with get, set
        abstract ``sizeY``: float option with get, set
        abstract ``sizeZ``: float option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``flat``: bool option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject36edd74b7156 =
        abstract ``position``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``normal``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``size``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``angle``: float option with get, set
        abstract ``captureUVS``: bool option with get, set
        abstract ``cullBackFaces``: bool option with get, set
        abstract ``localMode``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject2fbc4c4d8792 =
        abstract ``radius``: float option with get, set
        abstract ``radiusX``: float option with get, set
        abstract ``radiusY``: float option with get, set
        abstract ``radiusZ``: float option with get, set
        abstract ``flat``: bool option with get, set
        abstract ``subdivisions``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``updatable``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectcaccb8b55c1c =
        abstract ``radius``: float option with get, set
        abstract ``radiusX``: float option with get, set
        abstract ``radiusY``: float option with get, set
        abstract ``radiusZ``: float option with get, set
        abstract ``flat``: bool option with get, set
        abstract ``subdivisions``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectb58e982b7949 =
        abstract ``type``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``sizeX``: float option with get, set
        abstract ``sizeY``: float option with get, set
        abstract ``sizeZ``: float option with get, set
        abstract ``custom``: obj option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``flat``: bool option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject826c98ff92d9 =
        abstract ``type``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``sizeX``: float option with get, set
        abstract ``sizeY``: float option with get, set
        abstract ``sizeZ``: float option with get, set
        abstract ``custom``: obj option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``flat``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject217c80b25a21 =
        abstract ``path``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``radius``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``radiusFunction``: System.Func<float, float, float> option with get, set
        abstract ``cap``: float option with get, set
        abstract ``arc``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``instance``: BabylonjsBindings.SimpleClasses.Mesh option with get, set
        abstract ``invertUV``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject779dbe2dc4aa =
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``subdivisions``: float option with get, set
        abstract ``minHeight``: float option with get, set
        abstract ``maxHeight``: float option with get, set
        abstract ``colorFilter``: BabylonjsBindings.SimpleClasses.Color3 option with get, set
        abstract ``alphaFilter``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``onReady``: System.Action<BabylonjsBindings.SimpleClasses.GroundMesh, JS.Float32Array option> option with get, set
        abstract ``onError``: System.Action<string option, obj option> option with get, set
        abstract ``passHeightBufferInCallback``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject397db1f36d1a =
        abstract ``data``: JS.Uint8Array with get, set
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject48d2f07b6f20 =
        abstract ``xmin``: float with get, set
        abstract ``zmin``: float with get, set
        abstract ``xmax``: float with get, set
        abstract ``zmax``: float with get, set
        abstract ``subdivisions``: InlineObjectcea48f3826e5 option with get, set
        abstract ``precision``: InlineObjectcea48f3826e5 option with get, set
        abstract ``updatable``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject4d5f5d599acf =
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``subdivisions``: float option with get, set
        abstract ``subdivisionsX``: float option with get, set
        abstract ``subdivisionsY``: float option with get, set
        abstract ``updatable``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject8a290422a0a1 =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``subdivisions``: float with get, set
        abstract ``minHeight``: float with get, set
        abstract ``maxHeight``: float with get, set
        abstract ``colorFilter``: BabylonjsBindings.SimpleClasses.Color3 with get, set
        abstract ``buffer``: JS.Uint8Array with get, set
        abstract ``bufferWidth``: float with get, set
        abstract ``bufferHeight``: float with get, set
        abstract ``alphaFilter``: float with get, set
        abstract ``heightBuffer``: JS.Float32Array option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject7c0d0335de84 =
        abstract ``xmin``: float with get, set
        abstract ``zmin``: float with get, set
        abstract ``xmax``: float with get, set
        abstract ``zmax``: float with get, set
        abstract ``subdivisions``: InlineObjectcea48f3826e5 option with get, set
        abstract ``precision``: InlineObjectcea48f3826e5 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject1bef03141615 =
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``subdivisions``: float option with get, set
        abstract ``subdivisionsX``: float option with get, set
        abstract ``subdivisionsY``: float option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject4cbd04d8c4aa =
        abstract ``pattern``: float option with get, set
        abstract ``tileSize``: float option with get, set
        abstract ``tileWidth``: float option with get, set
        abstract ``tileHeight``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``alignHorizontal``: float option with get, set
        abstract ``alignVertical``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``updatable``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject5579a6854779 =
        abstract ``pattern``: float option with get, set
        abstract ``tileSize``: float option with get, set
        abstract ``tileWidth``: float option with get, set
        abstract ``tileHeight``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``alignHorizontal``: float option with get, set
        abstract ``alignVertical``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjecta1c5ef453764 =
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sourcePlane``: BabylonjsBindings.SimpleClasses.Plane option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectc96e85b1a781 =
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject6559ded43400 =
        abstract ``shape``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``radius``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``clip``: float option with get, set
        abstract ``arc``: float option with get, set
        abstract ``closed``: bool option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``cap``: float option with get, set
        abstract ``invertUV``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject856cb2edcae1 =
        abstract ``shape``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``path``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``scaleFunction``: System.Func<float, float, float> option with get, set
        abstract ``scaleVectorFunction``: System.Func<float, float, BabylonjsBindings.SimpleClasses.Vector3> option with get, set
        abstract ``rotationFunction``: System.Func<float, float, float> option with get, set
        abstract ``ribbonCloseArray``: bool option with get, set
        abstract ``ribbonClosePath``: bool option with get, set
        abstract ``closeShape``: bool option with get, set
        abstract ``closePath``: bool option with get, set
        abstract ``cap``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``instance``: BabylonjsBindings.SimpleClasses.Mesh option with get, set
        abstract ``invertUV``: bool option with get, set
        abstract ``firstNormal``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``adjustFrame``: bool option with get, set
        abstract ``capFunction``: System.Func<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>, ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>> option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject36af2b6fcfa2 =
        abstract ``shape``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``path``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``scale``: float option with get, set
        abstract ``rotation``: float option with get, set
        abstract ``closeShape``: bool option with get, set
        abstract ``closePath``: bool option with get, set
        abstract ``cap``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``instance``: BabylonjsBindings.SimpleClasses.Mesh option with get, set
        abstract ``invertUV``: bool option with get, set
        abstract ``firstNormal``: BabylonjsBindings.SimpleClasses.Vector3 option with get, set
        abstract ``adjustFrame``: bool option with get, set
        abstract ``capFunction``: System.Func<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>, ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>> option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject3e5dd238a114 =
        abstract ``shape``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``holes``: ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>> option with get, set
        abstract ``depth``: float option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``wrap``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject5202c5fb042b =
        abstract ``shape``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``holes``: ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>> option with get, set
        abstract ``depth``: float option with get, set
        abstract ``smoothingThreshold``: float option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``wrap``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectead563e37e7f =
        abstract ``radius``: float option with get, set
        abstract ``tube``: float option with get, set
        abstract ``radialSegments``: float option with get, set
        abstract ``tubularSegments``: float option with get, set
        abstract ``p``: float option with get, set
        abstract ``q``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectd315fd08c896 =
        abstract ``radius``: float option with get, set
        abstract ``tube``: float option with get, set
        abstract ``radialSegments``: float option with get, set
        abstract ``tubularSegments``: float option with get, set
        abstract ``p``: float option with get, set
        abstract ``q``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject6c5139a9e491 =
        abstract ``diameter``: float option with get, set
        abstract ``thickness``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject10ca2bfe1708 =
        abstract ``diameter``: float option with get, set
        abstract ``thickness``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject96930aa8f7f3 =
        abstract ``height``: float option with get, set
        abstract ``diameterTop``: float option with get, set
        abstract ``diameterBottom``: float option with get, set
        abstract ``diameter``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``subdivisions``: float option with get, set
        abstract ``arc``: float option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``hasRings``: bool option with get, set
        abstract ``enclose``: bool option with get, set
        abstract ``cap``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject8fab1a13729f =
        abstract ``height``: float option with get, set
        abstract ``diameterTop``: float option with get, set
        abstract ``diameterBottom``: float option with get, set
        abstract ``diameter``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``subdivisions``: float option with get, set
        abstract ``arc``: float option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``hasRings``: bool option with get, set
        abstract ``enclose``: bool option with get, set
        abstract ``cap``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectb9606f6a9705 =
        abstract ``segments``: float option with get, set
        abstract ``diameter``: float option with get, set
        abstract ``diameterX``: float option with get, set
        abstract ``diameterY``: float option with get, set
        abstract ``diameterZ``: float option with get, set
        abstract ``arc``: float option with get, set
        abstract ``slice``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``updatable``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectb4eea66450dd =
        abstract ``segments``: float option with get, set
        abstract ``diameter``: float option with get, set
        abstract ``diameterX``: float option with get, set
        abstract ``diameterY``: float option with get, set
        abstract ``diameterZ``: float option with get, set
        abstract ``arc``: float option with get, set
        abstract ``slice``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``dedupTopBottomIndices``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject2a5c28e4e1bf =
        abstract ``pattern``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``depth``: float option with get, set
        abstract ``tileSize``: float option with get, set
        abstract ``tileWidth``: float option with get, set
        abstract ``tileHeight``: float option with get, set
        abstract ``alignHorizontal``: float option with get, set
        abstract ``alignVertical``: float option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``updatable``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject76c36f55c96f =
        abstract ``pattern``: float option with get, set
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``depth``: float option with get, set
        abstract ``tileSize``: float option with get, set
        abstract ``tileWidth``: float option with get, set
        abstract ``tileHeight``: float option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``alignHorizontal``: float option with get, set
        abstract ``alignVertical``: float option with get, set
        abstract ``sideOrientation``: float option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectbf22c1ef7eb0 =
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``depth``: float option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``wrap``: bool option with get, set
        abstract ``topBaseAt``: float option with get, set
        abstract ``bottomBaseAt``: float option with get, set
        abstract ``updatable``: bool option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjecta3bdc6edfb6a =
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``depth``: float option with get, set
        abstract ``segments``: float option with get, set
        abstract ``widthSegments``: float option with get, set
        abstract ``heightSegments``: float option with get, set
        abstract ``depthSegments``: float option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject14717b24e5d3 =
        abstract ``size``: float option with get, set
        abstract ``width``: float option with get, set
        abstract ``height``: float option with get, set
        abstract ``depth``: float option with get, set
        abstract ``faceUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> option with get, set
        abstract ``faceColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``wrap``: bool option with get, set
        abstract ``topBaseAt``: float option with get, set
        abstract ``bottomBaseAt``: float option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject8e7c653fb98e =
        abstract ``radius``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``arc``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject5fee21ae3c23 =
        abstract ``radius``: float option with get, set
        abstract ``tessellation``: float option with get, set
        abstract ``arc``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject824634db5d87 =
        abstract ``pathArray``: ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>> with get, set
        abstract ``closeArray``: bool option with get, set
        abstract ``closePath``: bool option with get, set
        abstract ``offset``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``instance``: BabylonjsBindings.SimpleClasses.Mesh option with get, set
        abstract ``invertUV``: bool option with get, set
        abstract ``uvs``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector2> option with get, set
        abstract ``colors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject506dcd8d5509 =
        abstract ``pathArray``: ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>> with get, set
        abstract ``closeArray``: bool option with get, set
        abstract ``closePath``: bool option with get, set
        abstract ``offset``: float option with get, set
        abstract ``sideOrientation``: float option with get, set
        abstract ``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 option with get, set
        abstract ``invertUV``: bool option with get, set
        abstract ``uvs``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector2> option with get, set
        abstract ``colors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject9451621a062c =
        abstract ``minimum``: BabylonjsBindings.SimpleClasses.Vector3 with get, set
        abstract ``maximum``: BabylonjsBindings.SimpleClasses.Vector3 with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject3e8c2fe26aed =
        abstract ``points``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``dashSize``: float option with get, set
        abstract ``gapSize``: float option with get, set
        abstract ``dashNb``: float option with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``instance``: BabylonjsBindings.SimpleClasses.LinesMesh option with get, set
        abstract ``useVertexAlpha``: bool option with get, set
        abstract ``material``: BabylonjsBindings.SimpleClasses.Material option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject34562330571c =
        abstract ``points``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``instance``: BabylonjsBindings.SimpleClasses.LinesMesh option with get, set
        abstract ``colors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> option with get, set
        abstract ``useVertexAlpha``: bool option with get, set
        abstract ``material``: BabylonjsBindings.SimpleClasses.Material option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject82a22c7dc681 =
        abstract ``lines``: ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>> with get, set
        abstract ``updatable``: bool option with get, set
        abstract ``instance``: BabylonjsBindings.SimpleClasses.LinesMesh option with get, set
        abstract ``colors``: ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Color4>> option with get, set
        abstract ``useVertexAlpha``: bool option with get, set
        abstract ``material``: BabylonjsBindings.SimpleClasses.Material option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject86adbb2a4654 =
        abstract ``points``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector3> with get, set
        abstract ``dashSize``: float option with get, set
        abstract ``gapSize``: float option with get, set
        abstract ``dashNb``: float option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectcd71b9b6bd32 =
        abstract ``lines``: ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Vector3>> with get, set
        abstract ``colors``: ResizeArray<ResizeArray<BabylonjsBindings.SimpleClasses.Color4>> option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectabc05a379826 =
        abstract ``needNormals``: bool with get, set
        abstract ``needRebuild``: bool with get, set
        abstract ``shadowEnabled``: bool with get, set
        abstract ``specularEnabled``: bool with get, set
        abstract ``lightmapMode``: bool with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject5f25dfcc2aa3 =
        abstract ``name``: U2<string, BabylonjsBindings.SimpleInterfaces.BrowserSymbol> with get, set
        abstract ``metadata``: BabylonjsBindings.SimpleInterfaces.BrowserDecoratorMetadataObject with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject1d36c15dc75c =
        abstract ``xMin``: float with get, set
        abstract ``yMin``: float with get, set
        abstract ``xMax``: float with get, set
        abstract ``yMax``: float with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject5dbb9f7bffa0 =
        abstract ``redX``: float with get, set
        abstract ``redY``: float with get, set
        abstract ``greenX``: float with get, set
        abstract ``greenY``: float with get, set
        abstract ``blueX``: float with get, set
        abstract ``blueY``: float with get, set
        abstract ``whiteX``: float with get, set
        abstract ``whiteY``: float with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject793fc298b906 =
        abstract ``name``: string with get, set
        abstract ``pixelType``: float with get, set
        abstract ``pLinear``: float with get, set
        abstract ``xSampling``: float with get, set
        abstract ``ySampling``: float with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectd4c7fe3a4c5c =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set
        abstract ``data``: JS.Float32Array option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectd54d549eb3b8 =
        abstract ``x``: float with get, set
        abstract ``y``: float with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObject74fcddba75aa =
        abstract ``ascent``: float with get, set
        abstract ``height``: float with get, set
        abstract ``descent``: float with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjectc35407ceef63 =
        abstract ``name``: string option with get, set
        abstract ``boneMeshSize``: float option with get, set
        abstract ``createMesh``: bool option with get, set
        abstract ``mesh``: BabylonjsBindings.SimpleClasses.Mesh option with get, set

    /// Exact inline object used by a Babylon function signature.
    [<AllowNullLiteral>]
    type InlineObjecte486d92413e0 =
        abstract ``width``: float with get, set
        abstract ``height``: float with get, set

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity.pure
    [<AllowNullLiteral>]
    type FunctionBinding__AddInteractivityObjectModel =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> unit

    [<Import("_AddInteractivityObjectModel", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity.pure.js")>]
    let ``_AddInteractivityObjectModel``: FunctionBinding__AddInteractivityObjectModel = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<AllowNullLiteral>]
    type FunctionBinding__AreSameIntegerClass =
        [<Emit("$0($1...)")>] abstract Invoke: ``className``: string * ``className2``: string -> bool

    [<Import("_AreSameIntegerClass", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``_AreSameIntegerClass``: FunctionBinding__AreSameIntegerClass = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<AllowNullLiteral>]
    type FunctionBinding__AreSameMatrixClass =
        [<Emit("$0($1...)")>] abstract Invoke: ``className``: string * ``className2``: string -> bool

    [<Import("_AreSameMatrixClass", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``_AreSameMatrixClass``: FunctionBinding__AreSameMatrixClass = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<AllowNullLiteral>]
    type FunctionBinding__AreSameVectorOrQuaternionClass =
        [<Emit("$0($1...)")>] abstract Invoke: ``className``: string * ``className2``: string -> bool

    [<Import("_AreSameVectorOrQuaternionClass", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``_AreSameVectorOrQuaternionClass``: FunctionBinding__AreSameVectorOrQuaternionClass = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding__CommonDispose =
        [<Emit("$0($1...)")>] abstract Invoke: ``commonEngine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``canvas``: Browser.Types.HTMLCanvasElement option -> unit

    [<Import("_CommonDispose", "@babylonjs/core/Engines/engine.common.js")>]
    let ``_CommonDispose``: FunctionBinding__CommonDispose = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding__CommonInit =
        [<Emit("$0($1...)")>] abstract Invoke: ``commonEngine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``canvas``: Browser.Types.HTMLCanvasElement * ``creationOptions``: BabylonjsBindings.SimpleInterfaces.AbstractEngineOptions -> unit

    [<Import("_CommonInit", "@babylonjs/core/Engines/engine.common.js")>]
    let ``_CommonInit``: FunctionBinding__CommonInit = jsNative

    /// @babylonjs/core/Engines/abstractEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding__ConcatenateShader =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: string * ``defines``: string option * ?``shaderVersion``: string -> string

    [<Import("_ConcatenateShader", "@babylonjs/core/Engines/abstractEngine.functions.js")>]
    let ``_ConcatenateShader``: FunctionBinding__ConcatenateShader = jsNative

    /// @babylonjs/core/Particles/Queue/executionQueue
    [<AllowNullLiteral>]
    type FunctionBinding__ConnectAfter =
        [<Emit("$0($1...)")>] abstract Invoke: ``newOne``: BabylonjsBindings.SimpleInterfaces._IExecutionQueueItem * ``activeOne``: BabylonjsBindings.SimpleInterfaces._IExecutionQueueItem -> unit

    [<Import("_ConnectAfter", "@babylonjs/core/Particles/Queue/executionQueue.js")>]
    let ``_ConnectAfter``: FunctionBinding__ConnectAfter = jsNative

    /// @babylonjs/core/Particles/Queue/executionQueue
    [<AllowNullLiteral>]
    type FunctionBinding__ConnectAtTheEnd =
        [<Emit("$0($1...)")>] abstract Invoke: ``newOne``: BabylonjsBindings.SimpleInterfaces._IExecutionQueueItem * ``root``: BabylonjsBindings.SimpleInterfaces._IExecutionQueueItem -> unit

    [<Import("_ConnectAtTheEnd", "@babylonjs/core/Particles/Queue/executionQueue.js")>]
    let ``_ConnectAtTheEnd``: FunctionBinding__ConnectAtTheEnd = jsNative

    /// @babylonjs/core/Particles/Queue/executionQueue
    [<AllowNullLiteral>]
    type FunctionBinding__ConnectBefore =
        [<Emit("$0($1...)")>] abstract Invoke: ``newOne``: BabylonjsBindings.SimpleInterfaces._IExecutionQueueItem * ``activeOne``: BabylonjsBindings.SimpleInterfaces._IExecutionQueueItem -> unit

    [<Import("_ConnectBefore", "@babylonjs/core/Particles/Queue/executionQueue.js")>]
    let ``_ConnectBefore``: FunctionBinding__ConnectBefore = jsNative

    /// @babylonjs/core/Engines/thinEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding__executeWhenRenderingStateIsCompiled =
        [<Emit("$0($1...)")>] abstract Invoke: ``pipelineContext``: BabylonjsBindings.SimpleInterfaces.IPipelineContext * ``action``: System.Action<BabylonjsBindings.SimpleInterfaces.IPipelineContext option> -> unit

    [<Import("_executeWhenRenderingStateIsCompiled", "@babylonjs/core/Engines/thinEngine.functions.js")>]
    let ``_executeWhenRenderingStateIsCompiled``: FunctionBinding__executeWhenRenderingStateIsCompiled = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding__GetAudioEngine =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AudioEngineV2 option -> BabylonjsBindings.SimpleClasses.AudioEngineV2

    [<Import("_GetAudioEngine", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``_GetAudioEngine``: FunctionBinding__GetAudioEngine = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<AllowNullLiteral>]
    type FunctionBinding__GetClassNameOf =
        [<Emit("$0($1...)")>] abstract Invoke: ``v``: obj -> obj

    [<Import("_GetClassNameOf", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``_GetClassNameOf``: FunctionBinding__GetClassNameOf = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/textureLoaderManager
    [<AllowNullLiteral>]
    type FunctionBinding__GetCompatibleTextureLoader =
        [<Emit("$0($1...)")>] abstract Invoke: ``extension``: string * ?``mimeType``: string -> JS.Promise<BabylonjsBindings.SimpleInterfaces.IInternalTextureLoader> option

    [<Import("_GetCompatibleTextureLoader", "@babylonjs/core/Materials/Textures/Loaders/textureLoaderManager.js")>]
    let ``_GetCompatibleTextureLoader``: FunctionBinding__GetCompatibleTextureLoader = jsNative

    /// @babylonjs/core/Meshes/Compression/dracoCodec
    [<AllowNullLiteral>]
    type FunctionBinding__GetDefaultNumWorkers =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> float

    [<Import("_GetDefaultNumWorkers", "@babylonjs/core/Meshes/Compression/dracoCodec.js")>]
    let ``_GetDefaultNumWorkers``: FunctionBinding__GetDefaultNumWorkers = jsNative

    /// @babylonjs/core/Engines/abstractEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding__GetGlobalDefines =
        [<Emit("$0($1...)")>] abstract Invoke: ?``defines``: InlineObjectd76e3eabe256 * ?``isNDCHalfZRange``: bool * ?``useReverseDepthBuffer``: bool * ?``useExactSrgbConversions``: bool -> string option

    [<Import("_GetGlobalDefines", "@babylonjs/core/Engines/abstractEngine.functions.js")>]
    let ``_GetGlobalDefines``: FunctionBinding__GetGlobalDefines = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/subNodes/volumeAudioSubNode
    [<AllowNullLiteral>]
    type FunctionBinding__GetVolumeAudioSubNode =
        [<Emit("$0($1...)")>] abstract Invoke: ``subGraph``: BabylonjsBindings.SimpleClasses._AbstractAudioSubGraph -> BabylonjsBindings.SimpleClasses._VolumeAudioSubNode option

    [<Import("_GetVolumeAudioSubNode", "@babylonjs/core/AudioV2/abstractAudio/subNodes/volumeAudioSubNode.js")>]
    let ``_GetVolumeAudioSubNode``: FunctionBinding__GetVolumeAudioSubNode = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractAudioAnalyzer
    [<AllowNullLiteral>]
    type FunctionBinding__HasAudioAnalyzerOptions =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: BabylonjsBindings.SimpleInterfaces.PartialIAudioAnalyzerOptions -> bool

    [<Import("_HasAudioAnalyzerOptions", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractAudioAnalyzer.js")>]
    let ``_HasAudioAnalyzerOptions``: FunctionBinding__HasAudioAnalyzerOptions = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudioListener
    [<AllowNullLiteral>]
    type FunctionBinding__HasSpatialAudioListenerOptions =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: BabylonjsBindings.SimpleInterfaces.PartialISpatialAudioListenerOptions -> bool

    [<Import("_HasSpatialAudioListenerOptions", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudioListener.js")>]
    let ``_HasSpatialAudioListenerOptions``: FunctionBinding__HasSpatialAudioListenerOptions = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudio
    [<AllowNullLiteral>]
    type FunctionBinding__HasSpatialAudioOptions =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: BabylonjsBindings.SimpleInterfaces.PartialISpatialAudioOptions -> bool

    [<Import("_HasSpatialAudioOptions", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractSpatialAudio.js")>]
    let ``_HasSpatialAudioOptions``: FunctionBinding__HasSpatialAudioOptions = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio
    [<AllowNullLiteral>]
    type FunctionBinding__HasStereoAudioOptions =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: BabylonjsBindings.SimpleInterfaces.PartialIStereoAudioOptions -> bool

    [<Import("_HasStereoAudioOptions", "@babylonjs/core/AudioV2/abstractAudio/subProperties/abstractStereoAudio.js")>]
    let ``_HasStereoAudioOptions``: FunctionBinding__HasStereoAudioOptions = jsNative

    /// @babylonjs/core/Meshes/Compression/dracoCodec
    [<AllowNullLiteral>]
    type FunctionBinding__IsConfigurationAvailable =
        [<Emit("$0($1...)")>] abstract Invoke: ``config``: BabylonjsBindings.SimpleInterfaces.IDracoCodecConfiguration -> bool

    [<Import("_IsConfigurationAvailable", "@babylonjs/core/Meshes/Compression/dracoCodec.js")>]
    let ``_IsConfigurationAvailable``: FunctionBinding__IsConfigurationAvailable = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<AllowNullLiteral>]
    type FunctionBinding__IsDescendantOf =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh1``: BabylonjsBindings.SimpleClasses.Node * ``mesh2``: BabylonjsBindings.SimpleClasses.Node -> bool

    [<Import("_IsDescendantOf", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``_IsDescendantOf``: FunctionBinding__IsDescendantOf = jsNative

    /// @babylonjs/core/Engines/thinEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding__isRenderingStateCompiled =
        [<Emit("$0($1...)")>] abstract Invoke: ``pipelineContext``: BabylonjsBindings.SimpleInterfaces.IPipelineContext * ``gl``: BabylonjsBindings.TypeAliases.WebGLContext * ?``validateShaderPrograms``: bool -> bool

    [<Import("_isRenderingStateCompiled", "@babylonjs/core/Engines/thinEngine.functions.js")>]
    let ``_isRenderingStateCompiled``: FunctionBinding__isRenderingStateCompiled = jsNative

    /// @babylonjs/core/Engines/abstractEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding__LoadFile =
        [<Emit("$0($1...)")>] abstract Invoke: ``url``: string * ``onSuccess``: System.Action<U2<string, JS.ArrayBuffer>, string option> * ?``onProgress``: System.Action<obj> * ?``offlineProvider``: BabylonjsBindings.SimpleInterfaces.IOfflineProvider option * ?``useArrayBuffer``: bool * ?``onError``: System.Action<BabylonjsBindings.SimpleInterfaces.IWebRequest option, obj option> * ?``injectedLoadFile``: System.Func<string, System.Action<U2<string, JS.ArrayBuffer>, string option>, System.Action<Browser.Types.ProgressEvent> option, BabylonjsBindings.SimpleInterfaces.IOfflineProvider option, bool option, System.Action<BabylonjsBindings.SimpleClasses.WebRequest option, BabylonjsBindings.SimpleClasses.LoadFileError option> option, BabylonjsBindings.SimpleInterfaces.IFileRequest> -> BabylonjsBindings.SimpleInterfaces.IFileRequest

    [<Import("_LoadFile", "@babylonjs/core/Engines/abstractEngine.functions.js")>]
    let ``_LoadFile``: FunctionBinding__LoadFile = jsNative

    /// @babylonjs/core/Misc/tools.internals
    [<AllowNullLiteral>]
    type FunctionBinding__LoadScriptModuleAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``scriptUrl``: string * ?``scriptId``: string -> JS.Promise<obj>

    [<Import("_LoadScriptModuleAsync", "@babylonjs/core/Misc/tools.internals.js")>]
    let ``_LoadScriptModuleAsync``: FunctionBinding__LoadScriptModuleAsync = jsNative

    /// @babylonjs/core/Materials/effect.functions
    [<AllowNullLiteral>]
    type FunctionBinding__ProcessShaderCode =
        [<Emit("$0($1...)")>] abstract Invoke: ``processorOptions``: BabylonjsBindings.SimpleInterfaces._IProcessingOptions * ``baseName``: obj * ?``processFinalCode``: BabylonjsBindings.TypeAliases.ShaderCustomProcessingFunction option * ?``onFinalCodeReady``: System.Action<string, string> * ?``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage * ?``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ?``effectContext``: BabylonjsBindings.SimpleClasses.Effect -> unit

    [<Import("_ProcessShaderCode", "@babylonjs/core/Materials/effect.functions.js")>]
    let ``_ProcessShaderCode``: FunctionBinding__ProcessShaderCode = jsNative

    /// @babylonjs/core/Particles/Queue/executionQueue
    [<AllowNullLiteral>]
    type FunctionBinding__RemoveFromQueue =
        [<Emit("$0($1...)")>] abstract Invoke: ``item``: BabylonjsBindings.SimpleInterfaces._IExecutionQueueItem -> unit

    [<Import("_RemoveFromQueue", "@babylonjs/core/Particles/Queue/executionQueue.js")>]
    let ``_RemoveFromQueue``: FunctionBinding__RemoveFromQueue = jsNative

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<AllowNullLiteral>]
    type FunctionBinding__ResolveMixamoRigMapping =
        [<Emit("$0($1...)")>] abstract Invoke: ``bodyMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh -> BabylonjsBindings.TypeAliases.XRBodyMeshRigMapping

    [<Import("_ResolveMixamoRigMapping", "@babylonjs/core/XR/features/WebXRBodyTracking.pure.js")>]
    let ``_ResolveMixamoRigMapping``: FunctionBinding__ResolveMixamoRigMapping = jsNative

    /// @babylonjs/core/Engines/thinEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding__setProgram =
        [<Emit("$0($1...)")>] abstract Invoke: ``program``: Browser.Types.WebGLProgram option * ``gl``: BabylonjsBindings.TypeAliases.WebGLContext -> unit

    [<Import("_setProgram", "@babylonjs/core/Engines/thinEngine.functions.js")>]
    let ``_setProgram``: FunctionBinding__setProgram = jsNative

    /// @babylonjs/core/Cameras/RigModes/stereoscopicAnaglyphRigMode
    [<AllowNullLiteral>]
    type FunctionBinding__SetStereoscopicAnaglyphRigMode =
        [<Emit("$0($1...)")>] abstract Invoke: ``camera``: BabylonjsBindings.SimpleClasses.Camera -> unit

    [<Import("_SetStereoscopicAnaglyphRigMode", "@babylonjs/core/Cameras/RigModes/stereoscopicAnaglyphRigMode.js")>]
    let ``_SetStereoscopicAnaglyphRigMode``: FunctionBinding__SetStereoscopicAnaglyphRigMode = jsNative

    /// @babylonjs/core/Cameras/RigModes/stereoscopicRigMode
    [<AllowNullLiteral>]
    type FunctionBinding__SetStereoscopicRigMode =
        [<Emit("$0($1...)")>] abstract Invoke: ``camera``: BabylonjsBindings.SimpleClasses.Camera -> unit

    [<Import("_SetStereoscopicRigMode", "@babylonjs/core/Cameras/RigModes/stereoscopicRigMode.js")>]
    let ``_SetStereoscopicRigMode``: FunctionBinding__SetStereoscopicRigMode = jsNative

    /// @babylonjs/core/Cameras/RigModes/vrRigMode
    [<AllowNullLiteral>]
    type FunctionBinding__SetVrRigMode =
        [<Emit("$0($1...)")>] abstract Invoke: ``camera``: BabylonjsBindings.SimpleClasses.Camera * ``rigParams``: obj -> unit

    [<Import("_SetVrRigMode", "@babylonjs/core/Cameras/RigModes/vrRigMode.js")>]
    let ``_SetVrRigMode``: FunctionBinding__SetVrRigMode = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding__UpdateRGBDAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``internalTexture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``data``: ResizeArray<ResizeArray<JS.ArrayBufferView>> * ``sphericalPolynomial``: BabylonjsBindings.SimpleClasses.SphericalPolynomial option * ``lodScale``: float * ``lodOffset``: float -> JS.Promise<BabylonjsBindings.SimpleClasses.InternalTexture>

    [<Import("_UpdateRGBDAsync", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``_UpdateRGBDAsync``: FunctionBinding__UpdateRGBDAsync = jsNative

    /// @babylonjs/core/Animations/animatable.core
    [<AllowNullLiteral>]
    type FunctionBinding_AddAnimationExtensions =
        [<Emit("$0($1...)")>] abstract Invoke: ``sceneClass``: BabylonjsBindings.SimpleClasses.SceneStatic * ``boneClass``: BabylonjsBindings.SimpleClasses.BoneStatic -> unit

    [<Import("AddAnimationExtensions", "@babylonjs/core/Animations/animatable.core.js")>]
    let ``AddAnimationExtensions``: FunctionBinding_AddAnimationExtensions = jsNative

    /// @babylonjs/core/Materials/clipPlaneMaterialHelper
    [<AllowNullLiteral>]
    type FunctionBinding_AddClipPlaneUniforms =
        [<Emit("$0($1...)")>] abstract Invoke: ``uniforms``: ResizeArray<string> -> unit

    [<Import("AddClipPlaneUniforms", "@babylonjs/core/Materials/clipPlaneMaterialHelper.js")>]
    let ``AddClipPlaneUniforms``: FunctionBinding_AddClipPlaneUniforms = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileParser.function
    [<AllowNullLiteral>]
    type FunctionBinding_AddIndividualParser =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``parser``: BabylonjsBindings.TypeAliases.IndividualBabylonFileParser -> unit

    [<Import("AddIndividualParser", "@babylonjs/core/Loading/Plugins/babylonFileParser.function.js")>]
    let ``AddIndividualParser``: FunctionBinding_AddIndividualParser = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type FunctionBinding_AddObjectAccessorToKey =
        [<Emit("$0($1...)")>] abstract Invoke<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType>: ``key``: string * ``accessor``: BabylonjsBindings.SimpleInterfaces.IObjectAccessor<'GLTFTargetType, 'BabylonTargetType, 'BabylonValueType> -> unit

    [<Import("AddObjectAccessorToKey", "@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping.js")>]
    let ``AddObjectAccessorToKey``: FunctionBinding_AddObjectAccessorToKey = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileParser.function
    [<AllowNullLiteral>]
    type FunctionBinding_AddParser =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``parser``: BabylonjsBindings.TypeAliases.BabylonFileParser -> unit

    [<Import("AddParser", "@babylonjs/core/Loading/Plugins/babylonFileParser.function.js")>]
    let ``AddParser``: FunctionBinding_AddParser = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_AddRayExtensions =
        [<Emit("$0($1...)")>] abstract Invoke: ``sceneClass``: BabylonjsBindings.SimpleClasses.SceneStatic * ``cameraClass``: BabylonjsBindings.SimpleClasses.CameraStatic -> unit

    [<Import("AddRayExtensions", "@babylonjs/core/Culling/ray.core.js")>]
    let ``AddRayExtensions``: FunctionBinding_AddRayExtensions = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AddSmartAssetManagerCreatedObserver =
        [<Emit("$0($1...)")>] abstract Invoke: ``callback``: System.Action<BabylonjsBindings.TypeAliases.SmartAssetManager> -> BabylonjsBindings.SimpleClasses.Observer<BabylonjsBindings.TypeAliases.SmartAssetManager>

    [<Import("AddSmartAssetManagerCreatedObserver", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``AddSmartAssetManagerCreatedObserver``: FunctionBinding_AddSmartAssetManagerCreatedObserver = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/flowGraphBlockFactory
    [<AllowNullLiteral>]
    type FunctionBinding_addToBlockFactory =
        [<Emit("$0($1...)")>] abstract Invoke: ``module``: string * ``blockName``: string * ``factory``: System.Func<JS.Promise<BabylonjsBindings.SimpleClasses.FlowGraphBlockStatic>> -> unit

    [<Import("addToBlockFactory", "@babylonjs/core/FlowGraph/Blocks/flowGraphBlockFactory.js")>]
    let ``addToBlockFactory``: FunctionBinding_addToBlockFactory = jsNative

    /// @babylonjs/core/Engines/abstractEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding_allocateAndCopyTypedBuffer =
        [<Emit("$0($1...)")>] abstract Invoke: ``type``: float * ``sizeOrDstBuffer``: U2<float, U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer>> * ?``sizeInBytes``: bool * ?``copyBuffer``: JS.ArrayBuffer -> JS.ArrayBufferView

    [<Import("allocateAndCopyTypedBuffer", "@babylonjs/core/Engines/abstractEngine.functions.js")>]
    let ``allocateAndCopyTypedBuffer``: FunctionBinding_allocateAndCopyTypedBuffer = jsNative

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AllocateShBuffers =
        [<Emit("$0($1...)")>] abstract Invoke: ``textureCount``: float * ``bytesEach``: float -> ResizeArray<JS.Uint8Array>

    [<Import("AllocateShBuffers", "@babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMeshBase.pure.js")>]
    let ``AllocateShBuffers``: FunctionBinding_AllocateShBuffers = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationAppendSerializedAnimations =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: BabylonjsBindings.SimpleInterfaces.IAnimatable * ``destination``: obj -> unit

    [<Import("AnimationAppendSerializedAnimations", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationAppendSerializedAnimations``: FunctionBinding_AnimationAppendSerializedAnimations = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationCreateAndStartAnimation =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``target``: obj * ``targetProperty``: string * ``framePerSecond``: float * ``totalFrame``: float * ``from``: obj * ``to``: obj * ?``loopMode``: float * ?``easingFunction``: BabylonjsBindings.SimpleClasses.EasingFunction * ?``onAnimationEnd``: System.Action * ?``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.Animatable option

    [<Import("AnimationCreateAndStartAnimation", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationCreateAndStartAnimation``: FunctionBinding_AnimationCreateAndStartAnimation = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationCreateAndStartHierarchyAnimation =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``node``: BabylonjsBindings.SimpleClasses.Node * ``directDescendantsOnly``: bool * ``targetProperty``: string * ``framePerSecond``: float * ``totalFrame``: float * ``from``: obj * ``to``: obj * ?``loopMode``: float * ?``easingFunction``: BabylonjsBindings.SimpleClasses.EasingFunction * ?``onAnimationEnd``: System.Action -> ResizeArray<BabylonjsBindings.SimpleClasses.Animatable> option

    [<Import("AnimationCreateAndStartHierarchyAnimation", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationCreateAndStartHierarchyAnimation``: FunctionBinding_AnimationCreateAndStartHierarchyAnimation = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationCreateAnimation =
        [<Emit("$0($1...)")>] abstract Invoke: ``property``: string * ``animationType``: float * ``framePerSecond``: float * ``easingFunction``: BabylonjsBindings.SimpleClasses.EasingFunction -> BabylonjsBindings.SimpleClasses.Animation

    [<Import("AnimationCreateAnimation", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationCreateAnimation``: FunctionBinding_AnimationCreateAnimation = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationCreateMergeAndStartAnimation =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``node``: BabylonjsBindings.SimpleClasses.Node * ``targetProperty``: string * ``framePerSecond``: float * ``totalFrame``: float * ``from``: obj * ``to``: obj * ?``loopMode``: float * ?``easingFunction``: BabylonjsBindings.SimpleClasses.EasingFunction * ?``onAnimationEnd``: System.Action -> BabylonjsBindings.SimpleClasses.Animatable option

    [<Import("AnimationCreateMergeAndStartAnimation", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationCreateMergeAndStartAnimation``: FunctionBinding_AnimationCreateMergeAndStartAnimation = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationGroupClipFrames =
        [<Emit("$0($1...)")>] abstract Invoke: ``sourceAnimationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup * ``fromFrame``: float * ``toFrame``: float * ?``name``: string * ?``dontCloneAnimations``: bool -> BabylonjsBindings.SimpleClasses.AnimationGroup

    [<Import("AnimationGroupClipFrames", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``AnimationGroupClipFrames``: FunctionBinding_AnimationGroupClipFrames = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationGroupClipFramesInPlace =
        [<Emit("$0($1...)")>] abstract Invoke: ``animationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup * ``fromFrame``: float * ``toFrame``: float * ?``dontCloneAnimations``: bool -> BabylonjsBindings.SimpleClasses.AnimationGroup

    [<Import("AnimationGroupClipFramesInPlace", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``AnimationGroupClipFramesInPlace``: FunctionBinding_AnimationGroupClipFramesInPlace = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationGroupClipInPlace =
        [<Emit("$0($1...)")>] abstract Invoke: ``animationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup * ``start``: float * ``end``: float * ?``dontCloneAnimations``: bool * ?``useFrame``: bool -> BabylonjsBindings.SimpleClasses.AnimationGroup

    [<Import("AnimationGroupClipInPlace", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``AnimationGroupClipInPlace``: FunctionBinding_AnimationGroupClipInPlace = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationGroupClipKeys =
        [<Emit("$0($1...)")>] abstract Invoke: ``sourceAnimationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup * ``fromKey``: float * ``toKey``: float * ?``name``: string * ?``dontCloneAnimations``: bool -> BabylonjsBindings.SimpleClasses.AnimationGroup

    [<Import("AnimationGroupClipKeys", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``AnimationGroupClipKeys``: FunctionBinding_AnimationGroupClipKeys = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationGroupClipKeysInPlace =
        [<Emit("$0($1...)")>] abstract Invoke: ``animationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup * ``fromKey``: float * ``toKey``: float * ?``dontCloneAnimations``: bool -> BabylonjsBindings.SimpleClasses.AnimationGroup

    [<Import("AnimationGroupClipKeysInPlace", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``AnimationGroupClipKeysInPlace``: FunctionBinding_AnimationGroupClipKeysInPlace = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationGroupMakeAnimationAdditive =
        [<Emit("$0($1...)")>] abstract Invoke: ``sourceAnimationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup * ``referenceFrame``: float * ?``range``: string * ?``cloneOriginal``: bool * ?``clonedName``: string -> BabylonjsBindings.SimpleClasses.AnimationGroup
        [<Emit("$0($1...)")>] abstract Invoke: ``sourceAnimationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup * ?``options``: BabylonjsBindings.SimpleInterfaces.IMakeAnimationGroupAdditiveOptions -> BabylonjsBindings.SimpleClasses.AnimationGroup

    [<Import("AnimationGroupMakeAnimationAdditive", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``AnimationGroupMakeAnimationAdditive``: FunctionBinding_AnimationGroupMakeAnimationAdditive = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationGroupMergeAnimationGroups =
        [<Emit("$0($1...)")>] abstract Invoke: ``animationGroups``: ResizeArray<BabylonjsBindings.SimpleClasses.AnimationGroup> * ?``disposeSource``: bool * ?``normalize``: bool * ?``weight``: float -> BabylonjsBindings.SimpleClasses.AnimationGroup option

    [<Import("AnimationGroupMergeAnimationGroups", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``AnimationGroupMergeAnimationGroups``: FunctionBinding_AnimationGroupMergeAnimationGroups = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationGroupParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedAnimationGroup``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``targetLookup``: System.Func<obj, obj> -> BabylonjsBindings.SimpleClasses.AnimationGroup

    [<Import("AnimationGroupParse", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``AnimationGroupParse``: FunctionBinding_AnimationGroupParse = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationMakeAnimationAdditive =
        [<Emit("$0($1...)")>] abstract Invoke: ``sourceAnimation``: BabylonjsBindings.SimpleClasses.Animation * ?``referenceFrame``: float * ?``range``: string * ?``cloneOriginal``: bool * ?``clonedName``: string -> BabylonjsBindings.SimpleClasses.Animation
        [<Emit("$0($1...)")>] abstract Invoke: ``sourceAnimation``: BabylonjsBindings.SimpleClasses.Animation * ?``options``: BabylonjsBindings.SimpleInterfaces.IMakeAnimationAdditiveOptions -> BabylonjsBindings.SimpleClasses.Animation

    [<Import("AnimationMakeAnimationAdditive", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationMakeAnimationAdditive``: FunctionBinding_AnimationMakeAnimationAdditive = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedAnimation``: obj -> BabylonjsBindings.SimpleClasses.Animation

    [<Import("AnimationParse", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationParse``: FunctionBinding_AnimationParse = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationParseFromFileAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string option * ``url``: string -> JS.Promise<U2<BabylonjsBindings.SimpleClasses.Animation, ResizeArray<BabylonjsBindings.SimpleClasses.Animation>>>

    [<Import("AnimationParseFromFileAsync", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationParseFromFileAsync``: FunctionBinding_AnimationParseFromFileAsync = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationParseFromSnippetAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``this``: U2<BabylonjsBindings.SimpleClasses.AnimationStatic, unit> * ``snippetId``: string -> JS.Promise<U2<BabylonjsBindings.SimpleClasses.Animation, ResizeArray<BabylonjsBindings.SimpleClasses.Animation>>>

    [<Import("AnimationParseFromSnippetAsync", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationParseFromSnippetAsync``: FunctionBinding_AnimationParseFromSnippetAsync = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_AnimationTransitionTo =
        [<Emit("$0($1...)")>] abstract Invoke: ``property``: string * ``targetValue``: obj * ``host``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``frameRate``: float * ``transition``: BabylonjsBindings.SimpleClasses.Animation * ``duration``: float * ?``onAnimationEnd``: System.Action option * ?``stopCurrent``: bool * ?``customKeys``: ResizeArray<BabylonjsBindings.SimpleInterfaces.IAnimationKey> -> BabylonjsBindings.SimpleClasses.Animatable option

    [<Import("AnimationTransitionTo", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``AnimationTransitionTo``: FunctionBinding_AnimationTransitionTo = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.huf
    [<AllowNullLiteral>]
    type FunctionBinding_ApplyLut =
        [<Emit("$0($1...)")>] abstract Invoke: ``lut``: JS.Uint16Array * ``data``: JS.Uint16Array * ``nData``: float -> unit

    [<Import("ApplyLut", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.huf.js")>]
    let ``ApplyLut``: FunctionBinding_ApplyLut = jsNative

    /// @babylonjs/core/Misc/textureTools
    [<AllowNullLiteral>]
    type FunctionBinding_ApplyPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: ``postProcessName``: string * ``internalTexture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``type``: float * ?``samplingMode``: float * ?``format``: float * ?``width``: float * ?``height``: float -> JS.Promise<BabylonjsBindings.SimpleClasses.InternalTexture>

    [<Import("ApplyPostProcess", "@babylonjs/core/Misc/textureTools.js")>]
    let ``ApplyPostProcess``: FunctionBinding_ApplyPostProcess = jsNative

    /// @babylonjs/core/Buffers/bufferUtils
    [<AllowNullLiteral>]
    type FunctionBinding_AreIndices32Bits =
        [<Emit("$0($1...)")>] abstract Invoke: ``indices``: BabylonjsBindings.TypeAliases.IndicesArray * ``count``: float * ?``start``: float * ?``offset``: float -> bool

    [<Import("AreIndices32Bits", "@babylonjs/core/Buffers/bufferUtils.js")>]
    let ``AreIndices32Bits``: FunctionBinding_AreIndices32Bits = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_AreLightsTexturesReady =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``maxSimultaneousLights``: float * ?``disableLighting``: bool -> bool

    [<Import("AreLightsTexturesReady", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``AreLightsTexturesReady``: FunctionBinding_AreLightsTexturesReady = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindBonesParameters =
        [<Emit("$0($1...)")>] abstract Invoke: ?``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ?``effect``: BabylonjsBindings.SimpleClasses.Effect * ?``prePassConfiguration``: BabylonjsBindings.SimpleClasses.PrePassConfiguration -> unit

    [<Import("BindBonesParameters", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindBonesParameters``: FunctionBinding_BindBonesParameters = jsNative

    /// @babylonjs/core/Materials/clipPlaneMaterialHelper
    [<AllowNullLiteral>]
    type FunctionBinding_BindClipPlane =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``primaryHolder``: BabylonjsBindings.SimpleInterfaces.IClipPlanesHolder * ``secondaryHolder``: BabylonjsBindings.SimpleInterfaces.IClipPlanesHolder -> unit

    [<Import("BindClipPlane", "@babylonjs/core/Materials/clipPlaneMaterialHelper.js")>]
    let ``BindClipPlane``: FunctionBinding_BindClipPlane = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindFogParameters =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ?``effect``: BabylonjsBindings.SimpleClasses.Effect * ?``linearSpace``: bool -> unit

    [<Import("BindFogParameters", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindFogParameters``: FunctionBinding_BindFogParameters = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindIBLParameters =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``defines``: obj * ``ubo``: BabylonjsBindings.SimpleClasses.UniformBuffer * ``reflectionColor``: BabylonjsBindings.SimpleClasses.Color3 * ?``reflectionTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option * ?``realTimeFiltering``: bool * ?``supportTextureInfo``: bool * ?``supportLocalProjection``: bool * ?``usePBR``: bool * ?``supportSH``: bool * ?``useColor``: bool * ?``reflectionBlur``: float -> unit

    [<Import("BindIBLParameters", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindIBLParameters``: FunctionBinding_BindIBLParameters = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindIBLSamplers =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``defines``: obj * ``ubo``: BabylonjsBindings.SimpleClasses.UniformBuffer * ?``reflectionTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option * ?``realTimeFiltering``: bool -> unit

    [<Import("BindIBLSamplers", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindIBLSamplers``: FunctionBinding_BindIBLSamplers = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindLight =
        [<Emit("$0($1...)")>] abstract Invoke: ``light``: BabylonjsBindings.SimpleClasses.Light * ``lightIndex``: float * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``useSpecular``: bool * ?``receiveShadows``: bool -> unit

    [<Import("BindLight", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindLight``: FunctionBinding_BindLight = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindLightProperties =
        [<Emit("$0($1...)")>] abstract Invoke: ``light``: BabylonjsBindings.SimpleClasses.Light * ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``lightIndex``: float -> unit

    [<Import("BindLightProperties", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindLightProperties``: FunctionBinding_BindLightProperties = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindLights =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``defines``: obj * ?``maxSimultaneousLights``: float -> unit

    [<Import("BindLights", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindLights``: FunctionBinding_BindLights = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindLogDepth =
        [<Emit("$0($1...)")>] abstract Invoke: ``defines``: obj * ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> unit

    [<Import("BindLogDepth", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindLogDepth``: FunctionBinding_BindLogDepth = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindMorphTargetParameters =
        [<Emit("$0($1...)")>] abstract Invoke: ``abstractMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``effect``: BabylonjsBindings.SimpleClasses.Effect -> unit

    [<Import("BindMorphTargetParameters", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindMorphTargetParameters``: FunctionBinding_BindMorphTargetParameters = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindSceneUniformBuffer =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``sceneUbo``: BabylonjsBindings.SimpleClasses.UniformBuffer -> unit

    [<Import("BindSceneUniformBuffer", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindSceneUniformBuffer``: FunctionBinding_BindSceneUniformBuffer = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindTextureMatrix =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture * ``uniformBuffer``: BabylonjsBindings.SimpleClasses.UniformBuffer * ``key``: string -> unit

    [<Import("BindTextureMatrix", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``BindTextureMatrix``: FunctionBinding_BindTextureMatrix = jsNative

    /// @babylonjs/core/Materials/vertexPullingHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_BindVertexPullingUniforms =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: BabylonjsBindings.SimpleClasses.Effect * ``metadata``: JS.Map<string, BabylonjsBindings.SimpleInterfaces.IVertexPullingMetadata> -> unit

    [<Import("BindVertexPullingUniforms", "@babylonjs/core/Materials/vertexPullingHelper.functions.js")>]
    let ``BindVertexPullingUniforms``: FunctionBinding_BindVertexPullingUniforms = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/flowGraphBlockFactory
    [<AllowNullLiteral>]
    type FunctionBinding_blockFactory =
        [<Emit("$0($1...)")>] abstract Invoke: ``blockName``: U2<BabylonjsBindings.StringEnums.FlowGraphBlockNames, string> -> System.Func<JS.Promise<BabylonjsBindings.SimpleClasses.FlowGraphBlockStatic>>

    [<Import("blockFactory", "@babylonjs/core/FlowGraph/Blocks/flowGraphBlockFactory.js")>]
    let ``blockFactory``: FunctionBinding_blockFactory = jsNative

    /// @babylonjs/core/Cameras/camera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CameraParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedCamera``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.Camera

    [<Import("CameraParse", "@babylonjs/core/Cameras/camera.pure.js")>]
    let ``CameraParse``: FunctionBinding_CameraParse = jsNative

    /// @babylonjs/core/Misc/equirectangularCapture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_captureEquirectangularFromScene =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``options``: BabylonjsBindings.SimpleInterfaces.EquiRectangularCaptureOptions -> JS.Promise<JS.ArrayBufferView option>

    [<Import("captureEquirectangularFromScene", "@babylonjs/core/Misc/equirectangularCapture.pure.js")>]
    let ``captureEquirectangularFromScene``: FunctionBinding_captureEquirectangularFromScene = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Clamp =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float * ?``min``: float * ?``max``: float -> float

    [<Import("Clamp", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``Clamp``: FunctionBinding_Clamp = jsNative

    /// @babylonjs/core/Cameras/geospatialCameraMovement
    [<AllowNullLiteral>]
    type FunctionBinding_ClampCenterFromPolesInPlace =
        [<Emit("$0($1...)")>] abstract Invoke: ``center``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.Vector3

    [<Import("ClampCenterFromPolesInPlace", "@babylonjs/core/Cameras/geospatialCameraMovement.js")>]
    let ``ClampCenterFromPolesInPlace``: FunctionBinding_ClampCenterFromPolesInPlace = jsNative

    /// @babylonjs/core/Misc/tools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_className =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``module``: string -> System.Action<BabylonjsBindings.SimpleInterfaces.JavaScriptObject>

    [<Import("className", "@babylonjs/core/Misc/tools.pure.js")>]
    let ``className``: FunctionBinding_className = jsNative

    /// @babylonjs/core/Materials/colorCurves.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ColorCurvesBind =
        [<Emit("$0($1...)")>] abstract Invoke: ``colorCurves``: BabylonjsBindings.SimpleClasses.ColorCurves * ``effect``: BabylonjsBindings.SimpleClasses.Effect * ?``positiveUniform``: string * ?``neutralUniform``: string * ?``negativeUniform``: string -> unit

    [<Import("ColorCurvesBind", "@babylonjs/core/Materials/colorCurves.pure.js")>]
    let ``ColorCurvesBind``: FunctionBinding_ColorCurvesBind = jsNative

    /// @babylonjs/core/Materials/colorCurves.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ColorCurvesParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj -> BabylonjsBindings.SimpleClasses.ColorCurves

    [<Import("ColorCurvesParse", "@babylonjs/core/Materials/colorCurves.pure.js")>]
    let ``ColorCurvesParse``: FunctionBinding_ColorCurvesParse = jsNative

    /// @babylonjs/core/Materials/Textures/colorGradingTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ColorGradingTextureParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedTexture``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.ColorGradingTexture option

    [<Import("ColorGradingTextureParse", "@babylonjs/core/Materials/Textures/colorGradingTexture.pure.js")>]
    let ``ColorGradingTextureParse``: FunctionBinding_ColorGradingTextureParse = jsNative

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CompleteGreasedLineColorTable =
        [<Emit("$0($1...)")>] abstract Invoke: ``pointCount``: float * ``colors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color3> * ``colorDistribution``: BabylonjsBindings.Enums.GreasedLineMeshColorDistribution * ``defaultColor``: BabylonjsBindings.SimpleClasses.Color3 -> ResizeArray<BabylonjsBindings.SimpleClasses.Color3>

    [<Import("CompleteGreasedLineColorTable", "@babylonjs/core/Meshes/Builders/greasedLineBuilder.js")>]
    let ``CompleteGreasedLineColorTable``: FunctionBinding_CompleteGreasedLineColorTable = jsNative

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CompleteGreasedLineWidthTable =
        [<Emit("$0($1...)")>] abstract Invoke: ``pointCount``: float * ``widths``: ResizeArray<float> * ``widthsDistribution``: BabylonjsBindings.Enums.GreasedLineMeshWidthDistribution * ?``defaultWidthUpper``: float * ?``defaultWidthLower``: float -> ResizeArray<float>

    [<Import("CompleteGreasedLineWidthTable", "@babylonjs/core/Meshes/Builders/greasedLineBuilder.js")>]
    let ``CompleteGreasedLineWidthTable``: FunctionBinding_CompleteGreasedLineWidthTable = jsNative

    /// @babylonjs/core/Cameras/arcRotateCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ComputeAlpha =
        [<Emit("$0($1...)")>] abstract Invoke: ``offset``: BabylonjsBindings.SimpleClasses.Vector3 -> float

    [<Import("ComputeAlpha", "@babylonjs/core/Cameras/arcRotateCamera.pure.js")>]
    let ``ComputeAlpha``: FunctionBinding_ComputeAlpha = jsNative

    /// @babylonjs/core/Cameras/arcRotateCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ComputeBeta =
        [<Emit("$0($1...)")>] abstract Invoke: ``verticalOffset``: float * ``radius``: float -> float

    [<Import("ComputeBeta", "@babylonjs/core/Cameras/arcRotateCamera.pure.js")>]
    let ``ComputeBeta``: FunctionBinding_ComputeBeta = jsNative

    /// @babylonjs/core/Cameras/geospatialCameraMovement
    [<AllowNullLiteral>]
    type FunctionBinding_ComputeLocalBasisToRefs =
        [<Emit("$0($1...)")>] abstract Invoke: ``worldPos``: BabylonjsBindings.SimpleClasses.Vector3 * ``refEast``: BabylonjsBindings.SimpleClasses.Vector3 * ``refNorth``: BabylonjsBindings.SimpleClasses.Vector3 * ``refUp``: BabylonjsBindings.SimpleClasses.Vector3 * ?``useRightHandedSystem``: bool * ?``calculateUpVectorFromPointToRef``: System.Func<BabylonjsBindings.SimpleClasses.Vector3, BabylonjsBindings.SimpleClasses.Vector3, BabylonjsBindings.SimpleClasses.Vector3> -> unit

    [<Import("ComputeLocalBasisToRefs", "@babylonjs/core/Cameras/geospatialCameraMovement.js")>]
    let ``ComputeLocalBasisToRefs``: FunctionBinding_ComputeLocalBasisToRefs = jsNative

    /// @babylonjs/core/Cameras/geospatialCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ComputeLookAtFromYawPitchToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``yaw``: float * ``pitch``: float * ``center``: BabylonjsBindings.SimpleClasses.Vector3 * ``useRightHandedSystem``: bool * ``result``: BabylonjsBindings.SimpleClasses.Vector3 * ?``calculateUpVectorFromPointToRef``: System.Func<BabylonjsBindings.SimpleClasses.Vector3, BabylonjsBindings.SimpleClasses.Vector3, BabylonjsBindings.SimpleClasses.Vector3> -> BabylonjsBindings.SimpleClasses.Vector3

    [<Import("ComputeLookAtFromYawPitchToRef", "@babylonjs/core/Cameras/geospatialCamera.pure.js")>]
    let ``ComputeLookAtFromYawPitchToRef``: FunctionBinding_ComputeLookAtFromYawPitchToRef = jsNative

    /// @babylonjs/core/Meshes/meshUtils
    [<AllowNullLiteral>]
    type FunctionBinding_computeMaxExtents =
        [<Emit("$0($1...)")>] abstract Invoke: ``meshes``: ResizeArray<BabylonjsBindings.SimpleClasses.AbstractMesh> * ?``animationGroup``: BabylonjsBindings.SimpleClasses.AnimationGroup option * ?``animationStep``: float -> ResizeArray<InlineObject9451621a062c>

    [<Import("computeMaxExtents", "@babylonjs/core/Meshes/meshUtils.js")>]
    let ``computeMaxExtents``: FunctionBinding_computeMaxExtents = jsNative

    /// @babylonjs/core/Materials/Textures/HTML/htmlInteractionManager
    [<AllowNullLiteral>]
    type FunctionBinding_ComputeOverlayCssTransform =
        [<Emit("$0($1...)")>] abstract Invoke: ``centerX``: float * ``centerY``: float * ``scaleX``: float * ``scaleY``: float * ``rotation``: float * ``elementWidth``: float * ``elementHeight``: float -> string

    [<Import("ComputeOverlayCssTransform", "@babylonjs/core/Materials/Textures/HTML/htmlInteractionManager.js")>]
    let ``ComputeOverlayCssTransform``: FunctionBinding_ComputeOverlayCssTransform = jsNative

    /// @babylonjs/core/Compute/computeShader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ComputeShaderParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.ComputeShader

    [<Import("ComputeShaderParse", "@babylonjs/core/Compute/computeShader.pure.js")>]
    let ``ComputeShaderParse``: FunctionBinding_ComputeShaderParse = jsNative

    /// @babylonjs/core/Cameras/geospatialCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ComputeYawPitchFromLookAtToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``lookAt``: BabylonjsBindings.SimpleClasses.Vector3 * ``center``: BabylonjsBindings.SimpleClasses.Vector3 * ``useRightHandedSystem``: bool * ``currentYaw``: float * ``result``: BabylonjsBindings.SimpleClasses.Vector2 * ?``calculateUpVectorFromPointToRef``: System.Func<BabylonjsBindings.SimpleClasses.Vector3, BabylonjsBindings.SimpleClasses.Vector3, BabylonjsBindings.SimpleClasses.Vector3> -> BabylonjsBindings.SimpleClasses.Vector2

    [<Import("ComputeYawPitchFromLookAtToRef", "@babylonjs/core/Cameras/geospatialCamera.pure.js")>]
    let ``ComputeYawPitchFromLookAtToRef``: FunctionBinding_ComputeYawPitchFromLookAtToRef = jsNative

    /// @babylonjs/core/Particles/Node/nodeParticleSystemSet.helper
    [<AllowNullLiteral>]
    type FunctionBinding_ConvertToNodeParticleSystemSetAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``particleSystemsList``: ResizeArray<BabylonjsBindings.SimpleClasses.ParticleSystem> -> JS.Promise<BabylonjsBindings.SimpleClasses.NodeParticleSystemSet option>

    [<Import("ConvertToNodeParticleSystemSetAsync", "@babylonjs/core/Particles/Node/nodeParticleSystemSet.helper.js")>]
    let ``ConvertToNodeParticleSystemSetAsync``: FunctionBinding_ConvertToNodeParticleSystemSetAsync = jsNative

    /// @babylonjs/core/Buffers/bufferUtils
    [<AllowNullLiteral>]
    type FunctionBinding_CopyFloatData =
        [<Emit("$0($1...)")>] abstract Invoke: ``input``: BabylonjsBindings.TypeAliases.DataArray * ``size``: float * ``type``: float * ``byteOffset``: float * ``byteStride``: float * ``normalized``: bool * ``totalVertices``: float * ``output``: JS.Float32Array -> unit

    [<Import("CopyFloatData", "@babylonjs/core/Buffers/bufferUtils.js")>]
    let ``CopyFloatData``: FunctionBinding_CopyFloatData = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_CopyMatrixToArray =
        [<Emit("$0($1...)")>] abstract Invoke: ``matrix``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``array``: U2<JS.Float32Array, ResizeArray<float>> * ?``offset``: float -> unit

    [<Import("CopyMatrixToArray", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``CopyMatrixToArray``: FunctionBinding_CopyMatrixToArray = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_CopyMatrixToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``matrix``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``target``: BabylonjsBindings.SimpleInterfaces.IMatrixLike -> unit

    [<Import("CopyMatrixToRef", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``CopyMatrixToRef``: FunctionBinding_CopyMatrixToRef = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding_CreateAudioBusAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialIAudioBusOptions * ?``engine``: BabylonjsBindings.SimpleClasses.AudioEngineV2 option -> JS.Promise<BabylonjsBindings.SimpleClasses.AudioBus>

    [<Import("CreateAudioBusAsync", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``CreateAudioBusAsync``: FunctionBinding_CreateAudioBusAsync = jsNative

    /// @babylonjs/core/AudioV2/webAudio/webAudioEngine
    [<AllowNullLiteral>]
    type FunctionBinding_CreateAudioEngineAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ?``options``: BabylonjsBindings.SimpleInterfaces.PartialIWebAudioEngineOptions -> JS.Promise<BabylonjsBindings.SimpleClasses.AudioEngineV2>

    [<Import("CreateAudioEngineAsync", "@babylonjs/core/AudioV2/webAudio/webAudioEngine.js")>]
    let ``CreateAudioEngineAsync``: FunctionBinding_CreateAudioEngineAsync = jsNative

    /// @babylonjs/core/Meshes/Builders/boxBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateBox =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObjectbf22c1ef7eb0 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateBox", "@babylonjs/core/Meshes/Builders/boxBuilder.pure.js")>]
    let ``CreateBox``: FunctionBinding_CreateBox = jsNative

    /// @babylonjs/core/Meshes/Builders/boxBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateBoxVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject14717b24e5d3 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateBoxVertexData", "@babylonjs/core/Meshes/Builders/boxBuilder.pure.js")>]
    let ``CreateBoxVertexData``: FunctionBinding_CreateBoxVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/capsuleBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateCapsule =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: BabylonjsBindings.SimpleInterfaces.ICreateCapsuleOptions * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateCapsule", "@babylonjs/core/Meshes/Builders/capsuleBuilder.pure.js")>]
    let ``CreateCapsule``: FunctionBinding_CreateCapsule = jsNative

    /// @babylonjs/core/Meshes/Builders/capsuleBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateCapsuleVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ?``options``: BabylonjsBindings.SimpleInterfaces.ICreateCapsuleOptions -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateCapsuleVertexData", "@babylonjs/core/Meshes/Builders/capsuleBuilder.pure.js")>]
    let ``CreateCapsuleVertexData``: FunctionBinding_CreateCapsuleVertexData = jsNative

    /// @babylonjs/core/Materials/Textures/textureMerger
    [<AllowNullLiteral>]
    type FunctionBinding_CreateConstantInput =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float -> BabylonjsBindings.SimpleInterfaces.IConstantChannelInput

    [<Import("CreateConstantInput", "@babylonjs/core/Materials/Textures/textureMerger.js")>]
    let ``CreateConstantInput``: FunctionBinding_CreateConstantInput = jsNative

    /// @babylonjs/core/Meshes/Builders/cylinderBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateCylinder =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObject96930aa8f7f3 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateCylinder", "@babylonjs/core/Meshes/Builders/cylinderBuilder.pure.js")>]
    let ``CreateCylinder``: FunctionBinding_CreateCylinder = jsNative

    /// @babylonjs/core/Meshes/Builders/cylinderBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateCylinderVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject8fab1a13729f -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateCylinderVertexData", "@babylonjs/core/Meshes/Builders/cylinderBuilder.pure.js")>]
    let ``CreateCylinderVertexData``: FunctionBinding_CreateCylinderVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/linesBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateDashedLines =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject3e8c2fe26aed * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.LinesMesh

    [<Import("CreateDashedLines", "@babylonjs/core/Meshes/Builders/linesBuilder.pure.js")>]
    let ``CreateDashedLines``: FunctionBinding_CreateDashedLines = jsNative

    /// @babylonjs/core/Meshes/Builders/linesBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateDashedLinesVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject86adbb2a4654 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateDashedLinesVertexData", "@babylonjs/core/Meshes/Builders/linesBuilder.pure.js")>]
    let ``CreateDashedLinesVertexData``: FunctionBinding_CreateDashedLinesVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/decalBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateDecal =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``sourceMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``options``: InlineObject36edd74b7156 -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateDecal", "@babylonjs/core/Meshes/Builders/decalBuilder.pure.js")>]
    let ``CreateDecal``: FunctionBinding_CreateDecal = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.decoder
    [<AllowNullLiteral>]
    type FunctionBinding_CreateDecoderAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``header``: BabylonjsBindings.SimpleInterfaces.IEXRHeader * ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor * ``outputType``: BabylonjsBindings.Enums.EXROutputType -> JS.Promise<BabylonjsBindings.SimpleInterfaces.IEXRDecoder>

    [<Import("CreateDecoderAsync", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.decoder.js")>]
    let ``CreateDecoderAsync``: FunctionBinding_CreateDecoderAsync = jsNative

    /// @babylonjs/core/Materials/materialPluginFactoryExport
    [<AllowNullLiteral>]
    type FunctionBinding_createDetailMapPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``material``: BabylonjsBindings.SimpleClasses.Material -> BabylonjsBindings.SimpleClasses.MaterialPluginBase option

    [<Import("createDetailMapPlugin", "@babylonjs/core/Materials/materialPluginFactoryExport.js")>]
    let ``createDetailMapPlugin``: FunctionBinding_createDetailMapPlugin = jsNative

    /// @babylonjs/core/Meshes/Builders/discBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateDisc =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObject8e7c653fb98e * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateDisc", "@babylonjs/core/Meshes/Builders/discBuilder.pure.js")>]
    let ``CreateDisc``: FunctionBinding_CreateDisc = jsNative

    /// @babylonjs/core/Meshes/Builders/discBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateDiscVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject5fee21ae3c23 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateDiscVertexData", "@babylonjs/core/Meshes/Builders/discBuilder.pure.js")>]
    let ``CreateDiscVertexData``: FunctionBinding_CreateDiscVertexData = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateEnvTextureAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture * ?``options``: BabylonjsBindings.SimpleInterfaces.CreateEnvTextureOptions -> JS.Promise<JS.ArrayBuffer>

    [<Import("CreateEnvTextureAsync", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``CreateEnvTextureAsync``: FunctionBinding_CreateEnvTextureAsync = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_CreateFactorOperand =
        [<Emit("$0($1...)")>] abstract Invoke: ``factor``: BabylonjsBindings.SimpleClasses.Color4 -> BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand

    [<Import("CreateFactorOperand", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``CreateFactorOperand``: FunctionBinding_CreateFactorOperand = jsNative

    /// @babylonjs/core/Meshes/Builders/geodesicBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGeodesic =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject029dbaa31b1f * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateGeodesic", "@babylonjs/core/Meshes/Builders/geodesicBuilder.js")>]
    let ``CreateGeodesic``: FunctionBinding_CreateGeodesic = jsNative

    /// @babylonjs/core/Meshes/Builders/goldbergBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGoldberg =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: BabylonjsBindings.TypeAliases.GoldbergCreationOption * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.GoldbergMesh

    [<Import("CreateGoldberg", "@babylonjs/core/Meshes/Builders/goldbergBuilder.js")>]
    let ``CreateGoldberg``: FunctionBinding_CreateGoldberg = jsNative

    /// @babylonjs/core/Meshes/Builders/goldbergBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGoldbergVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: BabylonjsBindings.ObjectTypes.GoldbergVertexDataOption * ``goldbergData``: BabylonjsBindings.SimpleClasses.PolyhedronData -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateGoldbergVertexData", "@babylonjs/core/Meshes/Builders/goldbergBuilder.js")>]
    let ``CreateGoldbergVertexData``: FunctionBinding_CreateGoldbergVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGreasedLine =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: BabylonjsBindings.SimpleInterfaces.GreasedLineMeshBuilderOptions * ?``materialOptions``: BabylonjsBindings.SimpleInterfaces.GreasedLineMaterialBuilderOptions option * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> U3<BabylonjsBindings.SimpleClasses.GreasedLineBaseMesh, BabylonjsBindings.SimpleClasses.GreasedLineMesh, BabylonjsBindings.SimpleClasses.GreasedLineRibbonMesh>

    [<Import("CreateGreasedLine", "@babylonjs/core/Meshes/Builders/greasedLineBuilder.js")>]
    let ``CreateGreasedLine``: FunctionBinding_CreateGreasedLine = jsNative

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGreasedLineMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: BabylonjsBindings.SimpleInterfaces.GreasedLineMaterialOptions * ``scene``: BabylonjsBindings.SimpleClasses.Scene option -> U3<BabylonjsBindings.SimpleClasses.StandardMaterial, BabylonjsBindings.SimpleClasses.PBRMaterial, BabylonjsBindings.SimpleClasses.GreasedLineSimpleMaterial>

    [<Import("CreateGreasedLineMaterial", "@babylonjs/core/Meshes/Builders/greasedLineBuilder.js")>]
    let ``CreateGreasedLineMaterial``: FunctionBinding_CreateGreasedLineMaterial = jsNative

    /// @babylonjs/core/Meshes/Builders/groundBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGround =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObject4d5f5d599acf * ?``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.GroundMesh

    [<Import("CreateGround", "@babylonjs/core/Meshes/Builders/groundBuilder.pure.js")>]
    let ``CreateGround``: FunctionBinding_CreateGround = jsNative

    /// @babylonjs/core/Meshes/Builders/groundBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGroundFromHeightMap =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``url``: U2<string, InlineObject397db1f36d1a> * ?``options``: InlineObject779dbe2dc4aa * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.GroundMesh

    [<Import("CreateGroundFromHeightMap", "@babylonjs/core/Meshes/Builders/groundBuilder.pure.js")>]
    let ``CreateGroundFromHeightMap``: FunctionBinding_CreateGroundFromHeightMap = jsNative

    /// @babylonjs/core/Meshes/Builders/groundBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGroundFromHeightMapVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject8a290422a0a1 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateGroundFromHeightMapVertexData", "@babylonjs/core/Meshes/Builders/groundBuilder.pure.js")>]
    let ``CreateGroundFromHeightMapVertexData``: FunctionBinding_CreateGroundFromHeightMapVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/groundBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateGroundVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject1bef03141615 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateGroundVertexData", "@babylonjs/core/Meshes/Builders/groundBuilder.pure.js")>]
    let ``CreateGroundVertexData``: FunctionBinding_CreateGroundVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/hemisphereBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateHemisphere =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObject5a70f99fb156 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateHemisphere", "@babylonjs/core/Meshes/Builders/hemisphereBuilder.pure.js")>]
    let ``CreateHemisphere``: FunctionBinding_CreateHemisphere = jsNative

    /// @babylonjs/core/Meshes/abstractMesh.hotSpot
    [<AllowNullLiteral>]
    type FunctionBinding_CreateHotSpotQueryForPickingInfo =
        [<Emit("$0($1...)")>] abstract Invoke: ``pickingInfo``: BabylonjsBindings.SimpleClasses.PickingInfo -> BabylonjsBindings.ObjectTypes.HotSpotQuery

    [<Import("CreateHotSpotQueryForPickingInfo", "@babylonjs/core/Meshes/abstractMesh.hotSpot.js")>]
    let ``CreateHotSpotQueryForPickingInfo``: FunctionBinding_CreateHotSpotQueryForPickingInfo = jsNative

    /// @babylonjs/core/Meshes/Builders/icoSphereBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateIcoSphere =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObject2fbc4c4d8792 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateIcoSphere", "@babylonjs/core/Meshes/Builders/icoSphereBuilder.pure.js")>]
    let ``CreateIcoSphere``: FunctionBinding_CreateIcoSphere = jsNative

    /// @babylonjs/core/Meshes/Builders/icoSphereBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateIcoSphereVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObjectcaccb8b55c1c -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateIcoSphereVertexData", "@babylonjs/core/Meshes/Builders/icoSphereBuilder.pure.js")>]
    let ``CreateIcoSphereVertexData``: FunctionBinding_CreateIcoSphereVertexData = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding_CreateImageBitmapFromSource =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``imageSource``: string * ?``options``: BabylonjsBindings.SimpleInterfaces.BrowserImageBitmapOptions -> JS.Promise<BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap>

    [<Import("CreateImageBitmapFromSource", "@babylonjs/core/Engines/engine.common.js")>]
    let ``CreateImageBitmapFromSource``: FunctionBinding_CreateImageBitmapFromSource = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateIrradianceImageDataArrayBufferViews =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: JS.ArrayBufferView * ``info``: BabylonjsBindings.TypeAliases.EnvironmentTextureInfo -> ResizeArray<JS.ArrayBufferView>

    [<Import("CreateIrradianceImageDataArrayBufferViews", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``CreateIrradianceImageDataArrayBufferViews``: FunctionBinding_CreateIrradianceImageDataArrayBufferViews = jsNative

    /// @babylonjs/core/Meshes/Builders/latheBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateLathe =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject6559ded43400 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateLathe", "@babylonjs/core/Meshes/Builders/latheBuilder.pure.js")>]
    let ``CreateLathe``: FunctionBinding_CreateLathe = jsNative

    /// @babylonjs/core/Meshes/Builders/linesBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateLines =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject34562330571c * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.LinesMesh

    [<Import("CreateLines", "@babylonjs/core/Meshes/Builders/linesBuilder.pure.js")>]
    let ``CreateLines``: FunctionBinding_CreateLines = jsNative

    /// @babylonjs/core/Meshes/Builders/linesBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateLineSystem =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject82a22c7dc681 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.LinesMesh

    [<Import("CreateLineSystem", "@babylonjs/core/Meshes/Builders/linesBuilder.pure.js")>]
    let ``CreateLineSystem``: FunctionBinding_CreateLineSystem = jsNative

    /// @babylonjs/core/Meshes/Builders/linesBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateLineSystemVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObjectcd71b9b6bd32 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateLineSystemVertexData", "@babylonjs/core/Meshes/Builders/linesBuilder.pure.js")>]
    let ``CreateLineSystemVertexData``: FunctionBinding_CreateLineSystemVertexData = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding_CreateMainAudioBusAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialIMainAudioBusOptions * ?``engine``: BabylonjsBindings.SimpleClasses.AudioEngineV2 option -> JS.Promise<BabylonjsBindings.SimpleClasses.MainAudioBus>

    [<Import("CreateMainAudioBusAsync", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``CreateMainAudioBusAsync``: FunctionBinding_CreateMainAudioBusAsync = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding_CreateMicrophoneSoundSourceAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialISoundSourceOptions * ?``engine``: BabylonjsBindings.SimpleClasses.AudioEngineV2 option -> JS.Promise<BabylonjsBindings.SimpleClasses.AbstractSoundSource>

    [<Import("CreateMicrophoneSoundSourceAsync", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``CreateMicrophoneSoundSourceAsync``: FunctionBinding_CreateMicrophoneSoundSourceAsync = jsNative

    /// @babylonjs/core/Materials/materialPluginFactoryExport
    [<AllowNullLiteral>]
    type FunctionBinding_createPBRAnisotropicPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``material``: BabylonjsBindings.SimpleClasses.Material -> BabylonjsBindings.SimpleClasses.MaterialPluginBase option

    [<Import("createPBRAnisotropicPlugin", "@babylonjs/core/Materials/materialPluginFactoryExport.js")>]
    let ``createPBRAnisotropicPlugin``: FunctionBinding_createPBRAnisotropicPlugin = jsNative

    /// @babylonjs/core/Materials/materialPluginFactoryExport
    [<AllowNullLiteral>]
    type FunctionBinding_createPBRBRDFPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``material``: BabylonjsBindings.SimpleClasses.Material -> BabylonjsBindings.SimpleClasses.MaterialPluginBase option

    [<Import("createPBRBRDFPlugin", "@babylonjs/core/Materials/materialPluginFactoryExport.js")>]
    let ``createPBRBRDFPlugin``: FunctionBinding_createPBRBRDFPlugin = jsNative

    /// @babylonjs/core/Materials/materialPluginFactoryExport
    [<AllowNullLiteral>]
    type FunctionBinding_createPBRClearCoatPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``material``: BabylonjsBindings.SimpleClasses.Material -> BabylonjsBindings.SimpleClasses.MaterialPluginBase option

    [<Import("createPBRClearCoatPlugin", "@babylonjs/core/Materials/materialPluginFactoryExport.js")>]
    let ``createPBRClearCoatPlugin``: FunctionBinding_createPBRClearCoatPlugin = jsNative

    /// @babylonjs/core/Materials/materialPluginFactoryExport
    [<AllowNullLiteral>]
    type FunctionBinding_createPBRIridescencePlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``material``: BabylonjsBindings.SimpleClasses.Material -> BabylonjsBindings.SimpleClasses.MaterialPluginBase option

    [<Import("createPBRIridescencePlugin", "@babylonjs/core/Materials/materialPluginFactoryExport.js")>]
    let ``createPBRIridescencePlugin``: FunctionBinding_createPBRIridescencePlugin = jsNative

    /// @babylonjs/core/Materials/materialPluginFactoryExport
    [<AllowNullLiteral>]
    type FunctionBinding_createPBRSheenPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``material``: BabylonjsBindings.SimpleClasses.Material -> BabylonjsBindings.SimpleClasses.MaterialPluginBase option

    [<Import("createPBRSheenPlugin", "@babylonjs/core/Materials/materialPluginFactoryExport.js")>]
    let ``createPBRSheenPlugin``: FunctionBinding_createPBRSheenPlugin = jsNative

    /// @babylonjs/core/Materials/materialPluginFactoryExport
    [<AllowNullLiteral>]
    type FunctionBinding_createPBRSubSurfacePlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``material``: BabylonjsBindings.SimpleClasses.Material -> BabylonjsBindings.SimpleClasses.MaterialPluginBase option

    [<Import("createPBRSubSurfacePlugin", "@babylonjs/core/Materials/materialPluginFactoryExport.js")>]
    let ``createPBRSubSurfacePlugin``: FunctionBinding_createPBRSubSurfacePlugin = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePickingRay =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``x``: float * ``y``: float * ``world``: BabylonjsBindings.SimpleClasses.Matrix option * ``camera``: BabylonjsBindings.SimpleClasses.Camera option * ?``cameraViewSpace``: bool -> BabylonjsBindings.SimpleClasses.Ray

    [<Import("CreatePickingRay", "@babylonjs/core/Culling/ray.core.js")>]
    let ``CreatePickingRay``: FunctionBinding_CreatePickingRay = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePickingRayInCameraSpace =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``x``: float * ``y``: float * ?``camera``: BabylonjsBindings.SimpleClasses.Camera -> BabylonjsBindings.SimpleClasses.Ray

    [<Import("CreatePickingRayInCameraSpace", "@babylonjs/core/Culling/ray.core.js")>]
    let ``CreatePickingRayInCameraSpace``: FunctionBinding_CreatePickingRayInCameraSpace = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePickingRayInCameraSpaceToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``x``: float * ``y``: float * ``result``: BabylonjsBindings.SimpleClasses.Ray * ?``camera``: BabylonjsBindings.SimpleClasses.Camera -> BabylonjsBindings.SimpleClasses.Scene

    [<Import("CreatePickingRayInCameraSpaceToRef", "@babylonjs/core/Culling/ray.core.js")>]
    let ``CreatePickingRayInCameraSpaceToRef``: FunctionBinding_CreatePickingRayInCameraSpaceToRef = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePickingRayToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``x``: float * ``y``: float * ``world``: BabylonjsBindings.SimpleClasses.Matrix option * ``result``: BabylonjsBindings.SimpleClasses.Ray * ``camera``: BabylonjsBindings.SimpleClasses.Camera option * ?``cameraViewSpace``: bool * ?``enableDistantPicking``: bool -> BabylonjsBindings.SimpleClasses.Scene

    [<Import("CreatePickingRayToRef", "@babylonjs/core/Culling/ray.core.js")>]
    let ``CreatePickingRayToRef``: FunctionBinding_CreatePickingRayToRef = jsNative

    /// @babylonjs/core/Engines/thinEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding_createPipelineContext =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: BabylonjsBindings.TypeAliases.WebGLContext * ``_shaderProcessingContext``: BabylonjsBindings.SimpleInterfaces._IShaderProcessingContext option -> BabylonjsBindings.SimpleInterfaces.IPipelineContext

    [<Import("createPipelineContext", "@babylonjs/core/Engines/thinEngine.functions.js")>]
    let ``createPipelineContext``: FunctionBinding_createPipelineContext = jsNative

    /// @babylonjs/core/Meshes/Builders/planeBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePlane =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObjecta1c5ef453764 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreatePlane", "@babylonjs/core/Meshes/Builders/planeBuilder.pure.js")>]
    let ``CreatePlane``: FunctionBinding_CreatePlane = jsNative

    /// @babylonjs/core/Meshes/Builders/planeBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePlaneVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObjectc96e85b1a781 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreatePlaneVertexData", "@babylonjs/core/Meshes/Builders/planeBuilder.pure.js")>]
    let ``CreatePlaneVertexData``: FunctionBinding_CreatePlaneVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/polygonBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePolygon =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject5202c5fb042b * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option * ?``earcutInjection``: obj -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreatePolygon", "@babylonjs/core/Meshes/Builders/polygonBuilder.pure.js")>]
    let ``CreatePolygon``: FunctionBinding_CreatePolygon = jsNative

    /// @babylonjs/core/Meshes/Builders/polygonBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePolygonVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``polygon``: BabylonjsBindings.SimpleClasses.Mesh * ``sideOrientation``: float * ?``fUV``: ResizeArray<BabylonjsBindings.SimpleClasses.Vector4> * ?``fColors``: ResizeArray<BabylonjsBindings.SimpleClasses.Color4> * ?``frontUVs``: BabylonjsBindings.SimpleClasses.Vector4 * ?``backUVs``: BabylonjsBindings.SimpleClasses.Vector4 * ?``wrp``: bool -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreatePolygonVertexData", "@babylonjs/core/Meshes/Builders/polygonBuilder.pure.js")>]
    let ``CreatePolygonVertexData``: FunctionBinding_CreatePolygonVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/polyhedronBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePolyhedron =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObjectb58e982b7949 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreatePolyhedron", "@babylonjs/core/Meshes/Builders/polyhedronBuilder.pure.js")>]
    let ``CreatePolyhedron``: FunctionBinding_CreatePolyhedron = jsNative

    /// @babylonjs/core/Meshes/Builders/polyhedronBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreatePolyhedronVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject826c98ff92d9 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreatePolyhedronVertexData", "@babylonjs/core/Meshes/Builders/polyhedronBuilder.pure.js")>]
    let ``CreatePolyhedronVertexData``: FunctionBinding_CreatePolyhedronVertexData = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateRadianceImageDataArrayBufferViews =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: JS.ArrayBufferView * ``info``: BabylonjsBindings.TypeAliases.EnvironmentTextureInfo -> ResizeArray<ResizeArray<JS.ArrayBufferView>>

    [<Import("CreateRadianceImageDataArrayBufferViews", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``CreateRadianceImageDataArrayBufferViews``: FunctionBinding_CreateRadianceImageDataArrayBufferViews = jsNative

    /// @babylonjs/core/Misc/textureTools
    [<AllowNullLiteral>]
    type FunctionBinding_CreateResizedCopy =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.Texture * ``width``: float * ``height``: float * ?``useBilinearMode``: bool -> BabylonjsBindings.SimpleClasses.Texture

    [<Import("CreateResizedCopy", "@babylonjs/core/Misc/textureTools.js")>]
    let ``CreateResizedCopy``: FunctionBinding_CreateResizedCopy = jsNative

    /// @babylonjs/core/Materials/Textures/textureMerger
    [<AllowNullLiteral>]
    type FunctionBinding_CreateRGBAConfiguration =
        [<Emit("$0($1...)")>] abstract Invoke: ``red``: BabylonjsBindings.TypeAliases.ChannelInput * ?``green``: BabylonjsBindings.TypeAliases.ChannelInput * ?``blue``: BabylonjsBindings.TypeAliases.ChannelInput * ?``alpha``: BabylonjsBindings.TypeAliases.ChannelInput -> BabylonjsBindings.SimpleInterfaces.ITextureMergeConfiguration

    [<Import("CreateRGBAConfiguration", "@babylonjs/core/Materials/Textures/textureMerger.js")>]
    let ``CreateRGBAConfiguration``: FunctionBinding_CreateRGBAConfiguration = jsNative

    /// @babylonjs/core/Meshes/Builders/ribbonBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateRibbon =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject824634db5d87 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateRibbon", "@babylonjs/core/Meshes/Builders/ribbonBuilder.pure.js")>]
    let ``CreateRibbon``: FunctionBinding_CreateRibbon = jsNative

    /// @babylonjs/core/Meshes/Builders/ribbonBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateRibbonVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject506dcd8d5509 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateRibbonVertexData", "@babylonjs/core/Meshes/Builders/ribbonBuilder.pure.js")>]
    let ``CreateRibbonVertexData``: FunctionBinding_CreateRibbonVertexData = jsNative

    /// @babylonjs/core/Misc/screenshotTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateScreenshot =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``camera``: BabylonjsBindings.SimpleClasses.Camera * ``size``: U2<BabylonjsBindings.SimpleInterfaces.IScreenshotSize, float> * ?``successCallback``: System.Action<string> * ?``mimeType``: string * ?``forceDownload``: bool * ?``quality``: float * ?``useFill``: bool * ?``clearWithSceneColor``: bool -> unit

    [<Import("CreateScreenshot", "@babylonjs/core/Misc/screenshotTools.pure.js")>]
    let ``CreateScreenshot``: FunctionBinding_CreateScreenshot = jsNative

    /// @babylonjs/core/Misc/screenshotTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateScreenshotAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``camera``: BabylonjsBindings.SimpleClasses.Camera * ``size``: U2<BabylonjsBindings.SimpleInterfaces.IScreenshotSize, float> * ?``mimeType``: string * ?``quality``: float * ?``useFill``: bool * ?``clearWithSceneColor``: bool * ?``forceDownload``: bool -> JS.Promise<string>

    [<Import("CreateScreenshotAsync", "@babylonjs/core/Misc/screenshotTools.pure.js")>]
    let ``CreateScreenshotAsync``: FunctionBinding_CreateScreenshotAsync = jsNative

    /// @babylonjs/core/Misc/screenshotTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateScreenshotForFrameGraphAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``frameGraph``: BabylonjsBindings.SimpleClasses.FrameGraph * ``camera``: BabylonjsBindings.SimpleClasses.Camera * ``size``: U2<BabylonjsBindings.SimpleInterfaces.IScreenshotSize, float> * ?``mimeType``: string * ?``samples``: float * ?``antialiasing``: bool * ?``fileName``: string * ?``quality``: float * ?``customDumpData``: System.Action<float, float, JS.ArrayBufferView, System.Action<U2<string, JS.ArrayBuffer>> option, string option, string option, bool option, bool option, float option> * ?``automaticDownload``: bool * ?``numberOfFramesToRender``: float -> JS.Promise<U2<string, JS.ArrayBuffer> option>

    [<Import("CreateScreenshotForFrameGraphAsync", "@babylonjs/core/Misc/screenshotTools.pure.js")>]
    let ``CreateScreenshotForFrameGraphAsync``: FunctionBinding_CreateScreenshotForFrameGraphAsync = jsNative

    /// @babylonjs/core/Misc/screenshotTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateScreenshotUsingRenderTarget =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``camera``: BabylonjsBindings.SimpleClasses.Camera * ``size``: U2<BabylonjsBindings.SimpleInterfaces.IScreenshotSize, float> * ?``successCallback``: System.Action<string> * ?``mimeType``: string * ?``samples``: float * ?``antialiasing``: bool * ?``fileName``: string * ?``renderSprites``: bool * ?``enableStencilBuffer``: bool * ?``useLayerMask``: bool * ?``quality``: float * ?``customizeTexture``: System.Action<BabylonjsBindings.SimpleClasses.RenderTargetTexture> * ?``customDumpData``: System.Action<float, float, JS.ArrayBufferView, System.Action<U2<string, JS.ArrayBuffer>> option, string option, string option, bool option, bool option, float option> * ?``timeoutInMilliseconds``: float * ?``timeoutErrorCallback``: System.Action -> unit

    [<Import("CreateScreenshotUsingRenderTarget", "@babylonjs/core/Misc/screenshotTools.pure.js")>]
    let ``CreateScreenshotUsingRenderTarget``: FunctionBinding_CreateScreenshotUsingRenderTarget = jsNative

    /// @babylonjs/core/Misc/screenshotTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateScreenshotUsingRenderTargetAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``camera``: BabylonjsBindings.SimpleClasses.Camera * ``size``: U2<BabylonjsBindings.SimpleInterfaces.IScreenshotSize, float> * ?``mimeType``: string * ?``samples``: float * ?``antialiasing``: bool * ?``fileName``: string * ?``renderSprites``: bool * ?``enableStencilBuffer``: bool * ?``useLayerMask``: bool * ?``quality``: float * ?``customizeTexture``: System.Action<BabylonjsBindings.SimpleClasses.RenderTargetTexture> * ?``customDumpData``: System.Action<float, float, JS.ArrayBufferView, System.Action<U2<string, JS.ArrayBuffer>> option, string option, string option, bool option, bool option, float option> -> JS.Promise<string>

    [<Import("CreateScreenshotUsingRenderTargetAsync", "@babylonjs/core/Misc/screenshotTools.pure.js")>]
    let ``CreateScreenshotUsingRenderTargetAsync``: FunctionBinding_CreateScreenshotUsingRenderTargetAsync = jsNative

    /// @babylonjs/core/Misc/screenshotTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateScreenshotWithResizeAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``camera``: BabylonjsBindings.SimpleClasses.Camera * ``width``: float * ``height``: float * ?``mimeType``: string * ?``quality``: float * ?``useFill``: bool -> JS.Promise<unit>

    [<Import("CreateScreenshotWithResizeAsync", "@babylonjs/core/Misc/screenshotTools.pure.js")>]
    let ``CreateScreenshotWithResizeAsync``: FunctionBinding_CreateScreenshotWithResizeAsync = jsNative

    /// @babylonjs/core/Meshes/Builders/boxBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateSegmentedBoxVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObjecta3bdc6edfb6a -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateSegmentedBoxVertexData", "@babylonjs/core/Meshes/Builders/boxBuilder.pure.js")>]
    let ``CreateSegmentedBoxVertexData``: FunctionBinding_CreateSegmentedBoxVertexData = jsNative

    /// @babylonjs/core/Bones/skeleton.functions
    [<AllowNullLiteral>]
    type FunctionBinding_CreateSkeletonFromTransformNodeHierarchy =
        [<Emit("$0($1...)")>] abstract Invoke: ``rootNode``: BabylonjsBindings.SimpleClasses.TransformNode * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``options``: InlineObjectc35407ceef63 -> BabylonjsBindings.SimpleClasses.Skeleton

    [<Import("CreateSkeletonFromTransformNodeHierarchy", "@babylonjs/core/Bones/skeleton.functions.js")>]
    let ``CreateSkeletonFromTransformNodeHierarchy``: FunctionBinding_CreateSkeletonFromTransformNodeHierarchy = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding_CreateSoundAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``source``: U5<JS.ArrayBuffer, BabylonjsBindings.SimpleInterfaces.BrowserAudioBuffer, BabylonjsBindings.SimpleClasses.StaticSoundBuffer, string, ResizeArray<string>> * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialIStaticSoundOptions * ?``engine``: BabylonjsBindings.SimpleClasses.AudioEngineV2 option -> JS.Promise<BabylonjsBindings.SimpleClasses.StaticSound>

    [<Import("CreateSoundAsync", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``CreateSoundAsync``: FunctionBinding_CreateSoundAsync = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding_CreateSoundBufferAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: U5<JS.ArrayBuffer, BabylonjsBindings.SimpleInterfaces.BrowserAudioBuffer, BabylonjsBindings.SimpleClasses.StaticSoundBuffer, string, ResizeArray<string>> * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialIStaticSoundBufferOptions * ?``engine``: BabylonjsBindings.SimpleClasses.AudioEngineV2 option -> JS.Promise<BabylonjsBindings.SimpleClasses.StaticSoundBuffer>

    [<Import("CreateSoundBufferAsync", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``CreateSoundBufferAsync``: FunctionBinding_CreateSoundBufferAsync = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding_CreateSoundSourceAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``source``: BabylonjsBindings.SimpleInterfaces.BrowserAudioNode * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialISoundSourceOptions * ?``engine``: BabylonjsBindings.SimpleClasses.AudioEngineV2 option -> JS.Promise<BabylonjsBindings.SimpleClasses.AbstractSoundSource>

    [<Import("CreateSoundSourceAsync", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``CreateSoundSourceAsync``: FunctionBinding_CreateSoundSourceAsync = jsNative

    /// @babylonjs/core/Meshes/Builders/sphereBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateSphere =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObjectb9606f6a9705 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateSphere", "@babylonjs/core/Meshes/Builders/sphereBuilder.pure.js")>]
    let ``CreateSphere``: FunctionBinding_CreateSphere = jsNative

    /// @babylonjs/core/Meshes/Builders/sphereBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateSphereVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObjectb4eea66450dd -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateSphereVertexData", "@babylonjs/core/Meshes/Builders/sphereBuilder.pure.js")>]
    let ``CreateSphereVertexData``: FunctionBinding_CreateSphereVertexData = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding_CreateStreamingSoundAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``source``: U3<Browser.Types.HTMLMediaElement, string, ResizeArray<string>> * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialIStreamingSoundOptions * ?``engine``: BabylonjsBindings.SimpleClasses.AudioEngineV2 option -> JS.Promise<BabylonjsBindings.SimpleClasses.StreamingSound>

    [<Import("CreateStreamingSoundAsync", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``CreateStreamingSoundAsync``: FunctionBinding_CreateStreamingSoundAsync = jsNative

    /// @babylonjs/core/Meshes/Builders/textBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CreateText =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``text``: string * ``fontData``: BabylonjsBindings.SimpleInterfaces.IFontData * ?``options``: InlineObject92022eb5df33 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option * ?``earcutInjection``: obj -> BabylonjsBindings.SimpleClasses.Mesh option

    [<Import("CreateText", "@babylonjs/core/Meshes/Builders/textBuilder.js")>]
    let ``CreateText``: FunctionBinding_CreateText = jsNative

    /// @babylonjs/core/Meshes/Builders/textBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTextShapePaths =
        [<Emit("$0($1...)")>] abstract Invoke: ``text``: string * ``size``: float * ``resolution``: float * ``fontData``: BabylonjsBindings.SimpleInterfaces.IFontData -> ResizeArray<BabylonjsBindings.SimpleClasses.ShapePath>

    [<Import("CreateTextShapePaths", "@babylonjs/core/Meshes/Builders/textBuilder.js")>]
    let ``CreateTextShapePaths``: FunctionBinding_CreateTextShapePaths = jsNative

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTexture2DArrayFromKTX2Async =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``data``: U2<string, JS.ArrayBufferView> * ?``options``: BabylonjsBindings.SimpleInterfaces.ICreateTexture2DArrayFromKTX2Options -> JS.Promise<BabylonjsBindings.SimpleClasses.RawTexture2DArray>

    [<Import("CreateTexture2DArrayFromKTX2Async", "@babylonjs/core/Materials/Textures/rawTexture2DArray.functions.js")>]
    let ``CreateTexture2DArrayFromKTX2Async``: FunctionBinding_CreateTexture2DArrayFromKTX2Async = jsNative

    /// @babylonjs/core/Materials/Textures/textureMerger
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTextureInput =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture * ``sourceChannel``: float -> BabylonjsBindings.SimpleInterfaces.ITextureChannelInput

    [<Import("CreateTextureInput", "@babylonjs/core/Materials/Textures/textureMerger.js")>]
    let ``CreateTextureInput``: FunctionBinding_CreateTextureInput = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTextureOperand =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture option * ?``channel``: BabylonjsBindings.Enums.TextureChannel * ?``colorSpace``: BabylonjsBindings.Enums.TextureColorSpace -> BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand

    [<Import("CreateTextureOperand", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``CreateTextureOperand``: FunctionBinding_CreateTextureOperand = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTextureWithFactorOperand =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture option * ``factor``: BabylonjsBindings.SimpleClasses.Color4 * ?``channel``: BabylonjsBindings.Enums.TextureChannel * ?``colorSpace``: BabylonjsBindings.Enums.TextureColorSpace -> BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand

    [<Import("CreateTextureWithFactorOperand", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``CreateTextureWithFactorOperand``: FunctionBinding_CreateTextureWithFactorOperand = jsNative

    /// @babylonjs/core/Meshes/Builders/tiledBoxBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTiledBox =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject2a5c28e4e1bf * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateTiledBox", "@babylonjs/core/Meshes/Builders/tiledBoxBuilder.pure.js")>]
    let ``CreateTiledBox``: FunctionBinding_CreateTiledBox = jsNative

    /// @babylonjs/core/Meshes/Builders/tiledBoxBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTiledBoxVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject76c36f55c96f -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateTiledBoxVertexData", "@babylonjs/core/Meshes/Builders/tiledBoxBuilder.pure.js")>]
    let ``CreateTiledBoxVertexData``: FunctionBinding_CreateTiledBoxVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/groundBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTiledGround =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject48d2f07b6f20 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateTiledGround", "@babylonjs/core/Meshes/Builders/groundBuilder.pure.js")>]
    let ``CreateTiledGround``: FunctionBinding_CreateTiledGround = jsNative

    /// @babylonjs/core/Meshes/Builders/groundBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTiledGroundVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject7c0d0335de84 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateTiledGroundVertexData", "@babylonjs/core/Meshes/Builders/groundBuilder.pure.js")>]
    let ``CreateTiledGroundVertexData``: FunctionBinding_CreateTiledGroundVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/tiledPlaneBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTiledPlane =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject4cbd04d8c4aa * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateTiledPlane", "@babylonjs/core/Meshes/Builders/tiledPlaneBuilder.pure.js")>]
    let ``CreateTiledPlane``: FunctionBinding_CreateTiledPlane = jsNative

    /// @babylonjs/core/Meshes/Builders/tiledPlaneBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTiledPlaneVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject5579a6854779 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateTiledPlaneVertexData", "@babylonjs/core/Meshes/Builders/tiledPlaneBuilder.pure.js")>]
    let ``CreateTiledPlaneVertexData``: FunctionBinding_CreateTiledPlaneVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/torusBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTorus =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObject6c5139a9e491 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateTorus", "@babylonjs/core/Meshes/Builders/torusBuilder.pure.js")>]
    let ``CreateTorus``: FunctionBinding_CreateTorus = jsNative

    /// @babylonjs/core/Meshes/Builders/torusKnotBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTorusKnot =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``options``: InlineObjectead563e37e7f * ?``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateTorusKnot", "@babylonjs/core/Meshes/Builders/torusKnotBuilder.pure.js")>]
    let ``CreateTorusKnot``: FunctionBinding_CreateTorusKnot = jsNative

    /// @babylonjs/core/Meshes/Builders/torusKnotBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTorusKnotVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObjectd315fd08c896 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateTorusKnotVertexData", "@babylonjs/core/Meshes/Builders/torusKnotBuilder.pure.js")>]
    let ``CreateTorusKnotVertexData``: FunctionBinding_CreateTorusKnotVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/torusBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTorusVertexData =
        [<Emit("$0($1...)")>] abstract Invoke: ``options``: InlineObject10ca2bfe1708 -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("CreateTorusVertexData", "@babylonjs/core/Meshes/Builders/torusBuilder.pure.js")>]
    let ``CreateTorusVertexData``: FunctionBinding_CreateTorusVertexData = jsNative

    /// @babylonjs/core/Meshes/Builders/tubeBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CreateTube =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject217c80b25a21 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("CreateTube", "@babylonjs/core/Meshes/Builders/tubeBuilder.pure.js")>]
    let ``CreateTube``: FunctionBinding_CreateTube = jsNative

    /// @babylonjs/core/FrameGraph/frameGraphUtils
    [<AllowNullLiteral>]
    type FunctionBinding_CreateUtilityLayerRenderer =
        [<Emit("$0($1...)")>] abstract Invoke: ``frameFraph``: BabylonjsBindings.SimpleClasses.FrameGraph * ?``handleEvents``: bool -> BabylonjsBindings.SimpleClasses.UtilityLayerRenderer

    [<Import("CreateUtilityLayerRenderer", "@babylonjs/core/FrameGraph/frameGraphUtils.js")>]
    let ``CreateUtilityLayerRenderer``: FunctionBinding_CreateUtilityLayerRenderer = jsNative

    /// @babylonjs/core/Misc/coroutine
    [<AllowNullLiteral>]
    type FunctionBinding_createYieldingScheduler =
        [<Emit("$0($1...)")>] abstract Invoke<'T>: ?``yieldAfterMS``: float -> System.Action<BabylonjsBindings.TypeAliases.AsyncCoroutine<'T>, System.Action<BabylonjsBindings.TypeAliases.CoroutineStep<'T>>, System.Action<obj>>

    [<Import("createYieldingScheduler", "@babylonjs/core/Misc/coroutine.js")>]
    let ``createYieldingScheduler``: FunctionBinding_createYieldingScheduler = jsNative

    /// @babylonjs/core/Materials/Textures/cubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CubeTextureCreateFromImages =
        [<Emit("$0($1...)")>] abstract Invoke: ``files``: ResizeArray<string> * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``noMipmap``: bool -> BabylonjsBindings.SimpleClasses.CubeTexture

    [<Import("CubeTextureCreateFromImages", "@babylonjs/core/Materials/Textures/cubeTexture.pure.js")>]
    let ``CubeTextureCreateFromImages``: FunctionBinding_CubeTextureCreateFromImages = jsNative

    /// @babylonjs/core/Materials/Textures/cubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CubeTextureCreateFromPrefilteredData =
        [<Emit("$0($1...)")>] abstract Invoke: ``url``: string * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``forcedExtension``: obj * ?``createPolynomials``: bool -> BabylonjsBindings.SimpleClasses.CubeTexture

    [<Import("CubeTextureCreateFromPrefilteredData", "@babylonjs/core/Materials/Textures/cubeTexture.pure.js")>]
    let ``CubeTextureCreateFromPrefilteredData``: FunctionBinding_CubeTextureCreateFromPrefilteredData = jsNative

    /// @babylonjs/core/Materials/Textures/cubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_CubeTextureParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedTexture``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.CubeTexture

    [<Import("CubeTextureParse", "@babylonjs/core/Materials/Textures/cubeTexture.pure.js")>]
    let ``CubeTextureParse``: FunctionBinding_CubeTextureParse = jsNative

    /// @babylonjs/core/Misc/fileTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_DecodeBase64UrlToBinary =
        [<Emit("$0($1...)")>] abstract Invoke: ``uri``: string -> JS.ArrayBuffer

    [<Import("DecodeBase64UrlToBinary", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``DecodeBase64UrlToBinary``: FunctionBinding_DecodeBase64UrlToBinary = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_DecodeFloat32 =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("DecodeFloat32", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``DecodeFloat32``: FunctionBinding_DecodeFloat32 = jsNative

    /// @babylonjs/core/Lights/LTC/ltcTextureTool
    [<AllowNullLiteral>]
    type FunctionBinding_DecodeLTCTextureDataAsync =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> JS.Promise<(JS.Uint16Array * JS.Uint16Array)>

    [<Import("DecodeLTCTextureDataAsync", "@babylonjs/core/Lights/LTC/ltcTextureTool.js")>]
    let ``DecodeLTCTextureDataAsync``: FunctionBinding_DecodeLTCTextureDataAsync = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.rle
    [<AllowNullLiteral>]
    type FunctionBinding_DecodeRunLength =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer> -> ResizeArray<float>

    [<Import("DecodeRunLength", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.rle.js")>]
    let ``DecodeRunLength``: FunctionBinding_DecodeRunLength = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/defaultRenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_DefaultRenderingPipelineParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.DefaultRenderingPipeline

    [<Import("DefaultRenderingPipelineParse", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/defaultRenderingPipeline.pure.js")>]
    let ``DefaultRenderingPipelineParse``: FunctionBinding_DefaultRenderingPipelineParse = jsNative

    /// @babylonjs/core/Engines/thinEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding_deleteStateObject =
        [<Emit("$0($1...)")>] abstract Invoke: ``context``: BabylonjsBindings.TypeAliases.WebGLContext -> unit

    [<Import("deleteStateObject", "@babylonjs/core/Engines/thinEngine.functions.js")>]
    let ``deleteStateObject``: FunctionBinding_deleteStateObject = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_DeltaAngle =
        [<Emit("$0($1...)")>] abstract Invoke: ``current``: float * ``target``: float -> float

    [<Import("DeltaAngle", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``DeltaAngle``: FunctionBinding_DeltaAngle = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Denormalize =
        [<Emit("$0($1...)")>] abstract Invoke: ``normalized``: float * ``min``: float * ``max``: float -> float

    [<Import("Denormalize", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``Denormalize``: FunctionBinding_Denormalize = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetSerializer
    [<AllowNullLiteral>]
    type FunctionBinding_DeserializeSmartAssetMap =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: obj -> BabylonjsBindings.SimpleInterfaces.ISerializedSmartAssetMap

    [<Import("DeserializeSmartAssetMap", "@babylonjs/core/SmartAssets/smartAssetSerializer.js")>]
    let ``DeserializeSmartAssetMap``: FunctionBinding_DeserializeSmartAssetMap = jsNative

    /// @babylonjs/core/Misc/dumpTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_Dispose =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("Dispose", "@babylonjs/core/Misc/dumpTools.pure.js")>]
    let ``Dispose``: FunctionBinding_Dispose = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_DisposeSmartAssetManager =
        [<Emit("$0($1...)")>] abstract Invoke: ``manager``: BabylonjsBindings.TypeAliases.SmartAssetManager -> unit

    [<Import("DisposeSmartAssetManager", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``DisposeSmartAssetManager``: FunctionBinding_DisposeSmartAssetManager = jsNative

    /// @babylonjs/core/Misc/dumpTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_DumpData =
        [<Emit("$0($1...)")>] abstract Invoke: ``width``: float * ``height``: float * ``data``: JS.ArrayBufferView * ?``successCallback``: System.Action<U2<string, JS.ArrayBuffer>> * ?``mimeType``: string * ?``fileName``: string * ?``invertY``: bool * ?``toArrayBuffer``: bool * ?``quality``: float -> unit

    [<Import("DumpData", "@babylonjs/core/Misc/dumpTools.pure.js")>]
    let ``DumpData``: FunctionBinding_DumpData = jsNative

    /// @babylonjs/core/Misc/dumpTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_DumpDataAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``width``: float * ``height``: float * ``data``: JS.ArrayBufferView * ``mimeType``: string option * ``fileName``: string option * ``invertY``: bool option * ``toArrayBuffer``: bool * ?``quality``: float -> JS.Promise<JS.ArrayBuffer>
        [<Emit("$0($1...)")>] abstract Invoke: ``width``: float * ``height``: float * ``data``: JS.ArrayBufferView * ?``mimeType``: string * ?``fileName``: string * ?``invertY``: bool * ?``toArrayBuffer``: bool * ?``quality``: float -> JS.Promise<string>

    [<Import("DumpDataAsync", "@babylonjs/core/Misc/dumpTools.pure.js")>]
    let ``DumpDataAsync``: FunctionBinding_DumpDataAsync = jsNative

    /// @babylonjs/core/Misc/dumpTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_DumpFramebuffer =
        [<Emit("$0($1...)")>] abstract Invoke: ``width``: float * ``height``: float * ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ?``successCallback``: System.Action<string> * ?``mimeType``: string * ?``fileName``: string * ?``quality``: float -> JS.Promise<unit>

    [<Import("DumpFramebuffer", "@babylonjs/core/Misc/dumpTools.pure.js")>]
    let ``DumpFramebuffer``: FunctionBinding_DumpFramebuffer = jsNative

    /// @babylonjs/core/Decorators/nodeDecorator
    [<AllowNullLiteral>]
    type FunctionBinding_editableInPropertyPage =
        [<Emit("$0($1...)")>] abstract Invoke: ``displayName``: string * ?``propertyType``: BabylonjsBindings.Enums.PropertyTypeForEdition * ?``groupName``: string * ?``options``: BabylonjsBindings.SimpleInterfaces.IEditablePropertyOption -> System.Action<obj, InlineObject5f25dfcc2aa3>

    [<Import("editableInPropertyPage", "@babylonjs/core/Decorators/nodeDecorator.js")>]
    let ``editableInPropertyPage``: FunctionBinding_editableInPropertyPage = jsNative

    /// @babylonjs/core/Buffers/bufferUtils
    [<AllowNullLiteral>]
    type FunctionBinding_EnumerateFloatValues =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: BabylonjsBindings.TypeAliases.DataArray * ``byteOffset``: float * ``byteStride``: float * ``componentCount``: float * ``componentType``: float * ``count``: float * ``normalized``: bool * ``callback``: System.Action<ResizeArray<float>, float> -> unit

    [<Import("EnumerateFloatValues", "@babylonjs/core/Buffers/bufferUtils.js")>]
    let ``EnumerateFloatValues``: FunctionBinding_EnumerateFloatValues = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding_ExitFullscreen =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("ExitFullscreen", "@babylonjs/core/Engines/engine.common.js")>]
    let ``ExitFullscreen``: FunctionBinding_ExitFullscreen = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding_ExitPointerlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("ExitPointerlock", "@babylonjs/core/Engines/engine.common.js")>]
    let ``ExitPointerlock``: FunctionBinding_ExitPointerlock = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_ExtractAsInt =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float -> float

    [<Import("ExtractAsInt", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``ExtractAsInt``: FunctionBinding_ExtractAsInt = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_ExtractChannelAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``input``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``channel``: BabylonjsBindings.Enums.TextureChannel * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``outputColorSpace``: BabylonjsBindings.Enums.TextureColorSpace * ?``outputChannelMask``: BabylonjsBindings.Enums.ChannelMask -> JS.Promise<BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand>

    [<Import("ExtractChannelAsync", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``ExtractChannelAsync``: FunctionBinding_ExtractChannelAsync = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_ExtractMaxChannelAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``input``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``includeAlpha``: bool * ?``outputColorSpace``: BabylonjsBindings.Enums.TextureColorSpace * ?``outputChannelMask``: BabylonjsBindings.Enums.ChannelMask -> JS.Promise<BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand>

    [<Import("ExtractMaxChannelAsync", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``ExtractMaxChannelAsync``: FunctionBinding_ExtractMaxChannelAsync = jsNative

    /// @babylonjs/core/Maths/math.functions
    [<AllowNullLiteral>]
    type FunctionBinding_extractMinAndMax =
        [<Emit("$0($1...)")>] abstract Invoke: ``positions``: BabylonjsBindings.TypeAliases.FloatArray * ``start``: float * ``count``: float * ?``bias``: BabylonjsBindings.SimpleClasses.Vector2 option * ?``stride``: float -> InlineObject9451621a062c

    [<Import("extractMinAndMax", "@babylonjs/core/Maths/math.functions.js")>]
    let ``extractMinAndMax``: FunctionBinding_extractMinAndMax = jsNative

    /// @babylonjs/core/Maths/math.functions
    [<AllowNullLiteral>]
    type FunctionBinding_extractMinAndMaxIndexed =
        [<Emit("$0($1...)")>] abstract Invoke: ``positions``: BabylonjsBindings.TypeAliases.FloatArray * ``indices``: BabylonjsBindings.TypeAliases.IndicesArray * ``indexStart``: float * ``indexCount``: float * ?``bias``: BabylonjsBindings.SimpleClasses.Vector2 option -> InlineObject9451621a062c

    [<Import("extractMinAndMaxIndexed", "@babylonjs/core/Maths/math.functions.js")>]
    let ``extractMinAndMaxIndexed``: FunctionBinding_extractMinAndMaxIndexed = jsNative

    /// @babylonjs/core/Meshes/Builders/polygonBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ExtrudePolygon =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject3e5dd238a114 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option * ?``earcutInjection``: obj -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("ExtrudePolygon", "@babylonjs/core/Meshes/Builders/polygonBuilder.pure.js")>]
    let ``ExtrudePolygon``: FunctionBinding_ExtrudePolygon = jsNative

    /// @babylonjs/core/Meshes/Builders/shapeBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ExtrudeShape =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject36af2b6fcfa2 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("ExtrudeShape", "@babylonjs/core/Meshes/Builders/shapeBuilder.pure.js")>]
    let ``ExtrudeShape``: FunctionBinding_ExtrudeShape = jsNative

    /// @babylonjs/core/Meshes/Builders/shapeBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ExtrudeShapeCustom =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``options``: InlineObject856cb2edcae1 * ?``scene``: BabylonjsBindings.SimpleClasses.Scene option -> BabylonjsBindings.SimpleClasses.Mesh

    [<Import("ExtrudeShapeCustom", "@babylonjs/core/Meshes/Builders/shapeBuilder.pure.js")>]
    let ``ExtrudeShapeCustom``: FunctionBinding_ExtrudeShapeCustom = jsNative

    /// @babylonjs/core/FrameGraph/frameGraphUtils
    [<AllowNullLiteral>]
    type FunctionBinding_FindMainCamera =
        [<Emit("$0($1...)")>] abstract Invoke: ``frameGraph``: BabylonjsBindings.SimpleClasses.FrameGraph -> BabylonjsBindings.SimpleClasses.Camera option

    [<Import("FindMainCamera", "@babylonjs/core/FrameGraph/frameGraphUtils.js")>]
    let ``FindMainCamera``: FunctionBinding_FindMainCamera = jsNative

    /// @babylonjs/core/FrameGraph/frameGraphUtils
    [<AllowNullLiteral>]
    type FunctionBinding_FindMainObjectRenderer =
        [<Emit("$0($1...)")>] abstract Invoke: ``frameGraph``: BabylonjsBindings.SimpleClasses.FrameGraph -> BabylonjsBindings.SimpleClasses.FrameGraphObjectRendererTask option

    [<Import("FindMainObjectRenderer", "@babylonjs/core/FrameGraph/frameGraphUtils.js")>]
    let ``FindMainObjectRenderer``: FunctionBinding_FindMainObjectRenderer = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_FindSmartAssetKeyForObject =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``object``: U4<BabylonjsBindings.SimpleClasses.Node, BabylonjsBindings.SimpleClasses.Material, BabylonjsBindings.SimpleClasses.BaseTexture, BabylonjsBindings.SimpleClasses.AnimationGroup> -> string option

    [<Import("FindSmartAssetKeyForObject", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``FindSmartAssetKeyForObject``: FunctionBinding_FindSmartAssetKeyForObject = jsNative

    /// @babylonjs/core/Maths/math.functions
    [<AllowNullLiteral>]
    type FunctionBinding_FixFlippedFaces =
        [<Emit("$0($1...)")>] abstract Invoke: ``positions``: BabylonjsBindings.TypeAliases.FloatArray * ``indices``: BabylonjsBindings.TypeAliases.IndicesArray -> unit

    [<Import("FixFlippedFaces", "@babylonjs/core/Maths/math.functions.js")>]
    let ``FixFlippedFaces``: FunctionBinding_FixFlippedFaces = jsNative

    /// @babylonjs/core/Materials/fresnelParameters.pure
    [<AllowNullLiteral>]
    type FunctionBinding_FresnelParametersParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedFresnelParameters``: BabylonjsBindings.ObjectTypes.IFresnelParametersSerialized -> BabylonjsBindings.SimpleClasses.FresnelParameters

    [<Import("FresnelParametersParse", "@babylonjs/core/Materials/fresnelParameters.pure.js")>]
    let ``FresnelParametersParse``: FunctionBinding_FresnelParametersParse = jsNative

    /// @babylonjs/core/Misc/halfFloat
    [<AllowNullLiteral>]
    type FunctionBinding_FromHalfFloat =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float -> float

    [<Import("FromHalfFloat", "@babylonjs/core/Misc/halfFloat.js")>]
    let ``FromHalfFloat``: FunctionBinding_FromHalfFloat = jsNative

    /// @babylonjs/core/Misc/copyTools
    [<AllowNullLiteral>]
    type FunctionBinding_GenerateBase64StringFromPixelData =
        [<Emit("$0($1...)")>] abstract Invoke: ``pixels``: JS.ArrayBufferView * ``size``: BabylonjsBindings.SimpleInterfaces.ISize * ?``invertY``: bool -> string option

    [<Import("GenerateBase64StringFromPixelData", "@babylonjs/core/Misc/copyTools.js")>]
    let ``GenerateBase64StringFromPixelData``: FunctionBinding_GenerateBase64StringFromPixelData = jsNative

    /// @babylonjs/core/Misc/copyTools
    [<AllowNullLiteral>]
    type FunctionBinding_GenerateBase64StringFromTexture =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture * ?``faceIndex``: float * ?``level``: float -> string option

    [<Import("GenerateBase64StringFromTexture", "@babylonjs/core/Misc/copyTools.js")>]
    let ``GenerateBase64StringFromTexture``: FunctionBinding_GenerateBase64StringFromTexture = jsNative

    /// @babylonjs/core/Misc/copyTools
    [<AllowNullLiteral>]
    type FunctionBinding_GenerateBase64StringFromTextureAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture * ?``faceIndex``: float * ?``level``: float -> JS.Promise<string option>

    [<Import("GenerateBase64StringFromTextureAsync", "@babylonjs/core/Misc/copyTools.js")>]
    let ``GenerateBase64StringFromTextureAsync``: FunctionBinding_GenerateBase64StringFromTextureAsync = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_GetAllSmartAssets =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleInterfaces.BrowserReadonlyMap<string, string>

    [<Import("GetAllSmartAssets", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``GetAllSmartAssets``: FunctionBinding_GetAllSmartAssets = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/declarationMapper
    [<AllowNullLiteral>]
    type FunctionBinding_getAllSupportedNativeNodeTypes =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> ResizeArray<string>

    [<Import("getAllSupportedNativeNodeTypes", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity/declarationMapper.js")>]
    let ``getAllSupportedNativeNodeTypes``: FunctionBinding_getAllSupportedNativeNodeTypes = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<AllowNullLiteral>]
    type FunctionBinding_getAnimationTypeByFlowGraphType =
        [<Emit("$0($1...)")>] abstract Invoke: ``flowGraphType``: BabylonjsBindings.StringEnums.FlowGraphTypes -> float

    [<Import("getAnimationTypeByFlowGraphType", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``getAnimationTypeByFlowGraphType``: FunctionBinding_getAnimationTypeByFlowGraphType = jsNative

    /// @babylonjs/core/Buffers/bufferUtils
    [<AllowNullLiteral>]
    type FunctionBinding_GetBlobBufferSource =
        [<Emit("$0($1...)")>] abstract Invoke: ``view``: JS.ArrayBufferView -> U2<JS.ArrayBufferView, JS.ArrayBuffer>

    [<Import("GetBlobBufferSource", "@babylonjs/core/Buffers/bufferUtils.js")>]
    let ``GetBlobBufferSource``: FunctionBinding_GetBlobBufferSource = jsNative

    /// @babylonjs/core/Materials/effect.functions
    [<AllowNullLiteral>]
    type FunctionBinding_getCachedPipeline =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``context``: BabylonjsBindings.TypeAliases.WebGLContext -> BabylonjsBindings.SimpleInterfaces.IPipelineContext option

    [<Import("getCachedPipeline", "@babylonjs/core/Materials/effect.functions.js")>]
    let ``getCachedPipeline``: FunctionBinding_getCachedPipeline = jsNative

    /// @babylonjs/core/Misc/typeStore
    [<AllowNullLiteral>]
    type FunctionBinding_GetClass =
        [<Emit("$0($1...)")>] abstract Invoke: ``fqdn``: string -> obj

    [<Import("GetClass", "@babylonjs/core/Misc/typeStore.js")>]
    let ``GetClass``: FunctionBinding_GetClass = jsNative

    /// @babylonjs/core/Misc/typeStore
    [<AllowNullLiteral>]
    type FunctionBinding_GetClassName =
        [<Emit("$0($1...)")>] abstract Invoke: ``obj``: obj -> string

    [<Import("GetClassName", "@babylonjs/core/Misc/typeStore.js")>]
    let ``GetClassName``: FunctionBinding_GetClassName = jsNative

    /// @babylonjs/core/Misc/HighDynamicRange/hdr
    [<AllowNullLiteral>]
    type FunctionBinding_GetCubeMapTextureData =
        [<Emit("$0($1...)")>] abstract Invoke: ``buffer``: JS.ArrayBuffer * ``size``: float * ?``supersample``: bool -> BabylonjsBindings.SimpleInterfaces.CubeMapInfo

    [<Import("GetCubeMapTextureData", "@babylonjs/core/Misc/HighDynamicRange/hdr.js")>]
    let ``GetCubeMapTextureData``: FunctionBinding_GetCubeMapTextureData = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphParser
    [<AllowNullLiteral>]
    type FunctionBinding_GetDataOutConnectionByUniqueId =
        [<Emit("$0($1...)")>] abstract Invoke: ``blocks``: ResizeArray<BabylonjsBindings.SimpleClasses.FlowGraphBlock> * ``uniqueId``: string -> BabylonjsBindings.SimpleClasses.FlowGraphDataConnection<obj>

    [<Import("GetDataOutConnectionByUniqueId", "@babylonjs/core/FlowGraph/flowGraphParser.js")>]
    let ``GetDataOutConnectionByUniqueId``: FunctionBinding_GetDataOutConnectionByUniqueId = jsNative

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    [<AllowNullLiteral>]
    type FunctionBinding_getDimensionsFromTextureSize =
        [<Emit("$0($1...)")>] abstract Invoke: ``size``: BabylonjsBindings.TypeAliases.TextureSize -> InlineObjecte486d92413e0

    [<Import("getDimensionsFromTextureSize", "@babylonjs/core/Materials/Textures/textureCreationOptions.js")>]
    let ``getDimensionsFromTextureSize``: FunctionBinding_getDimensionsFromTextureSize = jsNative

    /// @babylonjs/core/Misc/domManagement
    [<AllowNullLiteral>]
    type FunctionBinding_GetDOMTextContent =
        [<Emit("$0($1...)")>] abstract Invoke: ``element``: Browser.Types.HTMLElement -> string

    [<Import("GetDOMTextContent", "@babylonjs/core/Misc/domManagement.js")>]
    let ``GetDOMTextContent``: FunctionBinding_GetDOMTextContent = jsNative

    /// @babylonjs/core/Decorators/nodeDecorator
    [<AllowNullLiteral>]
    type FunctionBinding_GetEditableProperties =
        [<Emit("$0($1...)")>] abstract Invoke: ``target``: obj -> ResizeArray<BabylonjsBindings.SimpleInterfaces.IPropertyDescriptionForEdition>

    [<Import("GetEditableProperties", "@babylonjs/core/Decorators/nodeDecorator.js")>]
    let ``GetEditableProperties``: FunctionBinding_GetEditableProperties = jsNative

    /// @babylonjs/core/Materials/Textures/HTML/htmlRaycastInteractionManager
    [<AllowNullLiteral>]
    type FunctionBinding_GetElementPixelFromUv =
        [<Emit("$0($1...)")>] abstract Invoke: ``u``: float * ``v``: float * ``width``: float * ``height``: float * ?``invertY``: bool -> InlineObjectd54d549eb3b8

    [<Import("GetElementPixelFromUv", "@babylonjs/core/Materials/Textures/HTML/htmlRaycastInteractionManager.js")>]
    let ``GetElementPixelFromUv``: FunctionBinding_GetElementPixelFromUv = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_GetEnvInfo =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: JS.ArrayBufferView -> BabylonjsBindings.SimpleInterfaces.EnvironmentTextureInfoV2 option

    [<Import("GetEnvInfo", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``GetEnvInfo``: FunctionBinding_GetEnvInfo = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.header
    [<AllowNullLiteral>]
    type FunctionBinding_GetExrHeader =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> BabylonjsBindings.SimpleInterfaces.IEXRHeader

    [<Import("GetExrHeader", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.header.js")>]
    let ``GetExrHeader``: FunctionBinding_GetExrHeader = jsNative

    /// @babylonjs/core/Misc/urlTools
    [<AllowNullLiteral>]
    type FunctionBinding_GetExtensionFromUrl =
        [<Emit("$0($1...)")>] abstract Invoke: ``url``: string -> string

    [<Import("GetExtensionFromUrl", "@babylonjs/core/Misc/urlTools.js")>]
    let ``GetExtensionFromUrl``: FunctionBinding_GetExtensionFromUrl = jsNative

    /// @babylonjs/core/Buffers/bufferUtils
    [<AllowNullLiteral>]
    type FunctionBinding_GetFloatData =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: BabylonjsBindings.TypeAliases.DataArray * ``size``: float * ``type``: float * ``byteOffset``: float * ``byteStride``: float * ``normalized``: bool * ``totalVertices``: float * ?``forceCopy``: bool -> BabylonjsBindings.TypeAliases.FloatArray

    [<Import("GetFloatData", "@babylonjs/core/Buffers/bufferUtils.js")>]
    let ``GetFloatData``: FunctionBinding_GetFloatData = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_GetFogState =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> bool

    [<Import("GetFogState", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``GetFogState``: FunctionBinding_GetFogState = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding_GetFontOffset =
        [<Emit("$0($1...)")>] abstract Invoke: ``font``: string -> InlineObject74fcddba75aa

    [<Import("GetFontOffset", "@babylonjs/core/Engines/engine.common.js")>]
    let ``GetFontOffset``: FunctionBinding_GetFontOffset = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_GetForwardRay =
        [<Emit("$0($1...)")>] abstract Invoke: ``camera``: BabylonjsBindings.SimpleClasses.Camera * ?``length``: float * ?``transform``: BabylonjsBindings.SimpleClasses.Matrix * ?``origin``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.Ray

    [<Import("GetForwardRay", "@babylonjs/core/Culling/ray.core.js")>]
    let ``GetForwardRay``: FunctionBinding_GetForwardRay = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_GetForwardRayToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``camera``: BabylonjsBindings.SimpleClasses.Camera * ``refRay``: BabylonjsBindings.SimpleClasses.Ray * ?``length``: float * ?``transform``: BabylonjsBindings.SimpleClasses.Matrix * ?``origin``: BabylonjsBindings.SimpleClasses.Vector3 -> BabylonjsBindings.SimpleClasses.Ray

    [<Import("GetForwardRayToRef", "@babylonjs/core/Culling/ray.core.js")>]
    let ``GetForwardRayToRef``: FunctionBinding_GetForwardRayToRef = jsNative

    /// @babylonjs/core/Materials/floatingOriginMatrixOverrides
    [<AllowNullLiteral>]
    type FunctionBinding_GetFullOffsetViewProjectionToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``offset``: BabylonjsBindings.SimpleInterfaces.IVector3Like * ``viewMatrix``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``projectionMatrix``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``ref``: BabylonjsBindings.SimpleInterfaces.IMatrixLike -> BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike

    [<Import("GetFullOffsetViewProjectionToRef", "@babylonjs/core/Materials/floatingOriginMatrixOverrides.js")>]
    let ``GetFullOffsetViewProjectionToRef``: FunctionBinding_GetFullOffsetViewProjectionToRef = jsNative

    /// @babylonjs/core/Materials/GaussianSplatting/gaussianSplattingMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_GetGaussianSplattingMaxPartCount =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine -> float

    [<Import("GetGaussianSplattingMaxPartCount", "@babylonjs/core/Materials/GaussianSplatting/gaussianSplattingMaterial.pure.js")>]
    let ``GetGaussianSplattingMaxPartCount``: FunctionBinding_GetGaussianSplattingMaxPartCount = jsNative

    /// @babylonjs/core/Engines/abstractEngine.functions
    [<AllowNullLiteral>]
    type FunctionBinding_getHostDocument =
        [<Emit("$0($1...)")>] abstract Invoke: ?``renderingCanvas``: Browser.Types.HTMLCanvasElement option -> Browser.Types.Document option

    [<Import("getHostDocument", "@babylonjs/core/Engines/abstractEngine.functions.js")>]
    let ``getHostDocument``: FunctionBinding_getHostDocument = jsNative

    /// @babylonjs/core/Meshes/abstractMesh.hotSpot
    [<AllowNullLiteral>]
    type FunctionBinding_GetHotSpotToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``hotSpotQuery``: BabylonjsBindings.ObjectTypes.HotSpotQuery * ``resPosition``: BabylonjsBindings.SimpleClasses.Vector3 * ?``resNormal``: BabylonjsBindings.SimpleClasses.Vector3 -> bool

    [<Import("GetHotSpotToRef", "@babylonjs/core/Meshes/abstractMesh.hotSpot.js")>]
    let ``GetHotSpotToRef``: FunctionBinding_GetHotSpotToRef = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileParser.function
    [<AllowNullLiteral>]
    type FunctionBinding_GetIndividualParser =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string -> BabylonjsBindings.TypeAliases.IndividualBabylonFileParser option

    [<Import("GetIndividualParser", "@babylonjs/core/Loading/Plugins/babylonFileParser.function.js")>]
    let ``GetIndividualParser``: FunctionBinding_GetIndividualParser = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<AllowNullLiteral>]
    type FunctionBinding_getNumericValue =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: BabylonjsBindings.TypeAliases.FlowGraphNumber -> float

    [<Import("getNumericValue", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``getNumericValue``: FunctionBinding_getNumericValue = jsNative

    /// @babylonjs/core/Materials/floatingOriginMatrixOverrides
    [<AllowNullLiteral>]
    type FunctionBinding_GetOffsetTransformMatrices =
        [<Emit("$0($1...)")>] abstract Invoke: ``offset``: BabylonjsBindings.SimpleInterfaces.IVector3Like * ``viewMatrices``: ResizeArray<BabylonjsBindings.SimpleClasses.Matrix> * ``projectionMatrices``: ResizeArray<BabylonjsBindings.SimpleClasses.Matrix> * ``length``: float * ``resultArray``: JS.Float32Array -> JS.Float32Array

    [<Import("GetOffsetTransformMatrices", "@babylonjs/core/Materials/floatingOriginMatrixOverrides.js")>]
    let ``GetOffsetTransformMatrices``: FunctionBinding_GetOffsetTransformMatrices = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileParser.function
    [<AllowNullLiteral>]
    type FunctionBinding_GetParser =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string -> BabylonjsBindings.TypeAliases.BabylonFileParser option

    [<Import("GetParser", "@babylonjs/core/Loading/Plugins/babylonFileParser.function.js")>]
    let ``GetParser``: FunctionBinding_GetParser = jsNative

    /// @babylonjs/core/Meshes/Builders/greasedLineBuilder
    [<AllowNullLiteral>]
    type FunctionBinding_GetPointsCount =
        [<Emit("$0($1...)")>] abstract Invoke: ``allPoints``: ResizeArray<ResizeArray<float>> -> float

    [<Import("GetPointsCount", "@babylonjs/core/Meshes/Builders/greasedLineBuilder.js")>]
    let ``GetPointsCount``: FunctionBinding_GetPointsCount = jsNative

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderAnimation
    [<AllowNullLiteral>]
    type FunctionBinding_getQuaternion =
        [<Emit("$0($1...)")>] abstract Invoke: ``_target``: obj * ``source``: JS.Float32Array * ``offset``: float * ``scale``: float -> BabylonjsBindings.SimpleClasses.Quaternion

    [<Import("getQuaternion", "@babylonjs/loaders/glTF/2.0/glTFLoaderAnimation.js")>]
    let ``getQuaternion``: FunctionBinding_getQuaternion = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<AllowNullLiteral>]
    type FunctionBinding_getRichTypeByAnimationType =
        [<Emit("$0($1...)")>] abstract Invoke: ``animationType``: float -> BabylonjsBindings.SimpleClasses.RichType<obj>

    [<Import("getRichTypeByAnimationType", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``getRichTypeByAnimationType``: FunctionBinding_getRichTypeByAnimationType = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<AllowNullLiteral>]
    type FunctionBinding_getRichTypeByFlowGraphType =
        [<Emit("$0($1...)")>] abstract Invoke: ?``flowGraphType``: string -> BabylonjsBindings.SimpleClasses.RichType<obj>

    [<Import("getRichTypeByFlowGraphType", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``getRichTypeByFlowGraphType``: FunctionBinding_getRichTypeByFlowGraphType = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<AllowNullLiteral>]
    type FunctionBinding_getRichTypeFromValue =
        [<Emit("$0($1...)")>] abstract Invoke<'T>: ``value``: 'T -> BabylonjsBindings.SimpleClasses.RichType<'T>

    [<Import("getRichTypeFromValue", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``getRichTypeFromValue``: FunctionBinding_getRichTypeFromValue = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphParser
    [<AllowNullLiteral>]
    type FunctionBinding_GetSignalInConnectionByUniqueId =
        [<Emit("$0($1...)")>] abstract Invoke: ``blocks``: ResizeArray<BabylonjsBindings.SimpleClasses.FlowGraphBlock> * ``uniqueId``: string -> BabylonjsBindings.SimpleClasses.FlowGraphSignalConnection

    [<Import("GetSignalInConnectionByUniqueId", "@babylonjs/core/FlowGraph/flowGraphParser.js")>]
    let ``GetSignalInConnectionByUniqueId``: FunctionBinding_GetSignalInConnectionByUniqueId = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_GetSmartAssetManager =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.TypeAliases.SmartAssetManager

    [<Import("GetSmartAssetManager", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``GetSmartAssetManager``: FunctionBinding_GetSmartAssetManager = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_GetSmartAssetTextureExtensions =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> BabylonjsBindings.SimpleInterfaces.BrowserReadonlySet<string>

    [<Import("GetSmartAssetTextureExtensions", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``GetSmartAssetTextureExtensions``: FunctionBinding_GetSmartAssetTextureExtensions = jsNative

    /// @babylonjs/core/Misc/textureTools
    [<AllowNullLiteral>]
    type FunctionBinding_GetTextureDataAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture * ?``width``: float * ?``height``: float * ?``face``: float * ?``lod``: float * ?``forceRTT``: bool * ?``slice``: float -> JS.Promise<JS.Uint8Array>

    [<Import("GetTextureDataAsync", "@babylonjs/core/Misc/textureTools.js")>]
    let ``GetTextureDataAsync``: FunctionBinding_GetTextureDataAsync = jsNative

    /// @babylonjs/core/Misc/tga
    [<AllowNullLiteral>]
    type FunctionBinding_GetTGAHeader =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: JS.Uint8Array -> obj

    [<Import("GetTGAHeader", "@babylonjs/core/Misc/tga.js")>]
    let ``GetTGAHeader``: FunctionBinding_GetTGAHeader = jsNative

    /// @babylonjs/core/Meshes/abstractMesh.hotSpot
    [<AllowNullLiteral>]
    type FunctionBinding_GetTransformedPosition =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``index``: float * ``res``: BabylonjsBindings.SimpleClasses.Vector3 -> bool

    [<Import("GetTransformedPosition", "@babylonjs/core/Meshes/abstractMesh.hotSpot.js")>]
    let ``GetTransformedPosition``: FunctionBinding_GetTransformedPosition = jsNative

    /// @babylonjs/core/Buffers/bufferUtils
    [<AllowNullLiteral>]
    type FunctionBinding_GetTypeByteLength =
        [<Emit("$0($1...)")>] abstract Invoke: ``type``: float -> float

    [<Import("GetTypeByteLength", "@babylonjs/core/Buffers/bufferUtils.js")>]
    let ``GetTypeByteLength``: FunctionBinding_GetTypeByteLength = jsNative

    /// @babylonjs/core/Buffers/bufferUtils
    [<AllowNullLiteral>]
    type FunctionBinding_GetTypedArrayConstructor =
        [<Emit("$0($1...)")>] abstract Invoke: ``componentType``: float -> BabylonjsBindings.SimpleInterfaces.BrowserTypedArrayConstructor<BabylonjsBindings.TypeAliases.VertexDataTypedArray>

    [<Import("GetTypedArrayConstructor", "@babylonjs/core/Buffers/bufferUtils.js")>]
    let ``GetTypedArrayConstructor``: FunctionBinding_GetTypedArrayConstructor = jsNative

    /// @babylonjs/core/Buffers/bufferUtils
    [<AllowNullLiteral>]
    type FunctionBinding_GetTypedArrayData =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: BabylonjsBindings.TypeAliases.DataArray * ``size``: float * ``type``: float * ``byteOffset``: float * ``byteStride``: float * ``totalVertices``: float * ?``forceCopy``: bool -> BabylonjsBindings.TypeAliases.VertexDataTypedArray

    [<Import("GetTypedArrayData", "@babylonjs/core/Buffers/bufferUtils.js")>]
    let ``GetTypedArrayData``: FunctionBinding_GetTypedArrayData = jsNative

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderAnimation
    [<AllowNullLiteral>]
    type FunctionBinding_getVector3 =
        [<Emit("$0($1...)")>] abstract Invoke: ``_target``: obj * ``source``: JS.Float32Array * ``offset``: float * ``scale``: float -> BabylonjsBindings.SimpleClasses.Vector3

    [<Import("getVector3", "@babylonjs/loaders/glTF/2.0/glTFLoaderAnimation.js")>]
    let ``getVector3``: FunctionBinding_getVector3 = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_HandleFallbacksForShadows =
        [<Emit("$0($1...)")>] abstract Invoke: ``defines``: obj * ``fallbacks``: BabylonjsBindings.SimpleClasses.EffectFallbacks * ?``maxSimultaneousLights``: float * ?``rank``: float -> float

    [<Import("HandleFallbacksForShadows", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``HandleFallbacksForShadows``: FunctionBinding_HandleFallbacksForShadows = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Hermite =
        [<Emit("$0($1...)")>] abstract Invoke: ``value1``: float * ``tangent1``: float * ``value2``: float * ``tangent2``: float * ``amount``: float -> float

    [<Import("Hermite", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``Hermite``: FunctionBinding_Hermite = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Hermite1stDerivative =
        [<Emit("$0($1...)")>] abstract Invoke: ``value1``: float * ``tangent1``: float * ``value2``: float * ``tangent2``: float * ``time``: float -> float

    [<Import("Hermite1stDerivative", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``Hermite1stDerivative``: FunctionBinding_Hermite1stDerivative = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_HighestCommonFactor =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: float * ``b``: float -> float

    [<Import("HighestCommonFactor", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``HighestCommonFactor``: FunctionBinding_HighestCommonFactor = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.huf
    [<AllowNullLiteral>]
    type FunctionBinding_HufUncompress =
        [<Emit("$0($1...)")>] abstract Invoke: ``array``: JS.Uint8Array * ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor * ``nCompressed``: float * ``outBuffer``: JS.Uint16Array * ``nRaw``: float -> unit

    [<Import("HufUncompress", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.huf.js")>]
    let ``HufUncompress``: FunctionBinding_HufUncompress = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_IdentityMatrixToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``result``: BabylonjsBindings.SimpleInterfaces.IMatrixLike -> unit

    [<Import("IdentityMatrixToRef", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``IdentityMatrixToRef``: FunctionBinding_IdentityMatrixToRef = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_ILog2 =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float -> float

    [<Import("ILog2", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``ILog2``: FunctionBinding_ILog2 = jsNative

    /// @babylonjs/core/Materials/imageProcessingConfiguration.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ImageProcessingConfigurationParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj -> BabylonjsBindings.SimpleClasses.ImageProcessingConfiguration

    [<Import("ImageProcessingConfigurationParse", "@babylonjs/core/Materials/imageProcessingConfiguration.pure.js")>]
    let ``ImageProcessingConfigurationParse``: FunctionBinding_ImageProcessingConfigurationParse = jsNative

    /// @babylonjs/core/Meshes/csg2
    [<AllowNullLiteral>]
    type FunctionBinding_InitializeCSG2Async =
        [<Emit("$0($1...)")>] abstract Invoke: ?``options``: BabylonjsBindings.SimpleInterfaces.PartialICSG2Options -> JS.Promise<unit>

    [<Import("InitializeCSG2Async", "@babylonjs/core/Meshes/csg2.js")>]
    let ``InitializeCSG2Async``: FunctionBinding_InitializeCSG2Async = jsNative

    /// @babylonjs/core/Misc/coroutine
    [<AllowNullLiteral>]
    type FunctionBinding_inlineScheduler =
        [<Emit("$0($1...)")>] abstract Invoke<'T>: ``coroutine``: BabylonjsBindings.TypeAliases.AsyncCoroutine<'T> * ``onStep``: System.Action<BabylonjsBindings.TypeAliases.CoroutineStep<'T>> * ``onError``: System.Action<obj> -> unit

    [<Import("inlineScheduler", "@babylonjs/core/Misc/coroutine.js")>]
    let ``inlineScheduler``: FunctionBinding_inlineScheduler = jsNative

    /// @babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill
    [<AllowNullLiteral>]
    type FunctionBinding_InstallHtmlInCanvasPolyfill =
        [<Emit("$0($1...)")>] abstract Invoke: ?``options``: BabylonjsBindings.SimpleInterfaces.IInstallHtmlInCanvasPolyfillOptions -> JS.Promise<bool>

    [<Import("InstallHtmlInCanvasPolyfill", "@babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill.js")>]
    let ``InstallHtmlInCanvasPolyfill``: FunctionBinding_InstallHtmlInCanvasPolyfill = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_InterleaveScalar =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: JS.Uint8Array * ``out``: JS.Uint8Array -> unit

    [<Import("InterleaveScalar", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``InterleaveScalar``: FunctionBinding_InterleaveScalar = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_InverseLerp =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: float * ``b``: float * ``value``: float -> float

    [<Import("InverseLerp", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``InverseLerp``: FunctionBinding_InverseLerp = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_InvertMatrixToArray =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``target``: U2<JS.Float32Array, ResizeArray<float>> -> bool

    [<Import("InvertMatrixToArray", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``InvertMatrixToArray``: FunctionBinding_InvertMatrixToArray = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_InvertMatrixToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``target``: BabylonjsBindings.SimpleInterfaces.IMatrixLike -> bool

    [<Import("InvertMatrixToRef", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``InvertMatrixToRef``: FunctionBinding_InvertMatrixToRef = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_InvertTextureAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``input``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``channels``: BabylonjsBindings.Enums.ChannelMask * ?``outputColorSpace``: BabylonjsBindings.Enums.TextureColorSpace * ?``outputChannelMask``: BabylonjsBindings.Enums.ChannelMask -> JS.Promise<BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand>

    [<Import("InvertTextureAsync", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``InvertTextureAsync``: FunctionBinding_InvertTextureAsync = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetSerializer
    [<AllowNullLiteral>]
    type FunctionBinding_IsAbsoluteOrSpecialUrl =
        [<Emit("$0($1...)")>] abstract Invoke: ``url``: string -> bool

    [<Import("IsAbsoluteOrSpecialUrl", "@babylonjs/core/SmartAssets/smartAssetSerializer.js")>]
    let ``IsAbsoluteOrSpecialUrl``: FunctionBinding_IsAbsoluteOrSpecialUrl = jsNative

    /// @babylonjs/core/Meshes/csg2
    [<AllowNullLiteral>]
    type FunctionBinding_IsCSG2Ready =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> bool

    [<Import("IsCSG2Ready", "@babylonjs/core/Meshes/csg2.js")>]
    let ``IsCSG2Ready``: FunctionBinding_IsCSG2Ready = jsNative

    /// @babylonjs/core/Misc/domManagement
    [<AllowNullLiteral>]
    type FunctionBinding_IsDocumentAvailable =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> bool

    [<Import("IsDocumentAvailable", "@babylonjs/core/Misc/domManagement.js")>]
    let ``IsDocumentAvailable``: FunctionBinding_IsDocumentAvailable = jsNative

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_IsGaussianSplattingClassName =
        [<Emit("$0($1...)")>] abstract Invoke: ``className``: string -> bool

    [<Import("IsGaussianSplattingClassName", "@babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMesh.pure.js")>]
    let ``IsGaussianSplattingClassName``: FunctionBinding_IsGaussianSplattingClassName = jsNative

    /// @babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill
    [<AllowNullLiteral>]
    type FunctionBinding_IsHtmlInCanvasSupportedNatively =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> bool

    [<Import("IsHtmlInCanvasSupportedNatively", "@babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill.js")>]
    let ``IsHtmlInCanvasSupportedNatively``: FunctionBinding_IsHtmlInCanvasSupportedNatively = jsNative

    /// @babylonjs/core/Materials/Textures/HTML/htmlTexture
    [<AllowNullLiteral>]
    type FunctionBinding_IsHtmlInCanvasUploadSupported =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine -> bool

    [<Import("IsHtmlInCanvasUploadSupported", "@babylonjs/core/Materials/Textures/HTML/htmlTexture.js")>]
    let ``IsHtmlInCanvasUploadSupported``: FunctionBinding_IsHtmlInCanvasUploadSupported = jsNative

    /// @babylonjs/core/Misc/domManagement
    [<AllowNullLiteral>]
    type FunctionBinding_IsNavigatorAvailable =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> bool

    [<Import("IsNavigatorAvailable", "@babylonjs/core/Misc/domManagement.js")>]
    let ``IsNavigatorAvailable``: FunctionBinding_IsNavigatorAvailable = jsNative

    /// @babylonjs/core/FlowGraph/utils
    [<AllowNullLiteral>]
    type FunctionBinding_isNumeric =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: BabylonjsBindings.TypeAliases.FlowGraphMathOperationType * ?``validIfNaN``: bool -> bool

    [<Import("isNumeric", "@babylonjs/core/FlowGraph/utils.js")>]
    let ``isNumeric``: FunctionBinding_isNumeric = jsNative

    /// @babylonjs/core/Misc/domManagement
    [<AllowNullLiteral>]
    type FunctionBinding_IsWindowObjectExist =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> bool

    [<Import("IsWindowObjectExist", "@babylonjs/core/Misc/domManagement.js")>]
    let ``IsWindowObjectExist``: FunctionBinding_IsWindowObjectExist = jsNative

    /// @babylonjs/core/Materials/drawWrapper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_IsWrapper =
        [<Emit("$0($1...)")>] abstract Invoke: ``effect``: U2<BabylonjsBindings.SimpleClasses.Effect, BabylonjsBindings.SimpleClasses.DrawWrapper> -> bool

    [<Import("IsWrapper", "@babylonjs/core/Materials/drawWrapper.functions.js")>]
    let ``IsWrapper``: FunctionBinding_IsWrapper = jsNative

    /// @babylonjs/core/Misc/khronosTextureContainer2Worker
    [<AllowNullLiteral>]
    type FunctionBinding_KTX2WorkerFunction =
        [<Emit("$0($1...)")>] abstract Invoke: ``KTX2DecoderModule``: obj -> unit

    [<Import("workerFunction", "@babylonjs/core/Misc/khronosTextureContainer2Worker.js")>]
    let ``KTX2WorkerFunction``: FunctionBinding_KTX2WorkerFunction = jsNative

    /// @babylonjs/core/AudioV2/abstractAudio/audioEngineV2
    [<AllowNullLiteral>]
    type FunctionBinding_LastCreatedAudioEngine =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> BabylonjsBindings.SimpleClasses.AudioEngineV2 option

    [<Import("LastCreatedAudioEngine", "@babylonjs/core/AudioV2/abstractAudio/audioEngineV2.js")>]
    let ``LastCreatedAudioEngine``: FunctionBinding_LastCreatedAudioEngine = jsNative

    /// @babylonjs/core/Maths/math.geospatial.functions
    [<AllowNullLiteral>]
    type FunctionBinding_LatLonFromDegreesToRef =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.ILatLonLike>: ``lat``: float * ``lon``: float * ``result``: 'T -> 'T

    [<Import("LatLonFromDegreesToRef", "@babylonjs/core/Maths/math.geospatial.functions.js")>]
    let ``LatLonFromDegreesToRef``: FunctionBinding_LatLonFromDegreesToRef = jsNative

    /// @babylonjs/core/Maths/math.geospatial.functions
    [<AllowNullLiteral>]
    type FunctionBinding_LatLonToNormalToRef =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.IVector3Like>: ``latLon``: BabylonjsBindings.SimpleInterfaces.DeepImmutableILatLonLike * ``result``: 'T -> 'T

    [<Import("LatLonToNormalToRef", "@babylonjs/core/Maths/math.geospatial.functions.js")>]
    let ``LatLonToNormalToRef``: FunctionBinding_LatLonToNormalToRef = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Lerp =
        [<Emit("$0($1...)")>] abstract Invoke: ``start``: float * ``end``: float * ``amount``: float -> float

    [<Import("Lerp", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``Lerp``: FunctionBinding_Lerp = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_LerpAngle =
        [<Emit("$0($1...)")>] abstract Invoke: ``start``: float * ``end``: float * ``amount``: float -> float

    [<Import("LerpAngle", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``LerpAngle``: FunctionBinding_LerpAngle = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_LerpTexturesAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``a``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``b``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``t``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``outputColorSpace``: BabylonjsBindings.Enums.TextureColorSpace * ?``outputChannelMask``: BabylonjsBindings.Enums.ChannelMask -> JS.Promise<BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand>

    [<Import("LerpTexturesAsync", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``LerpTexturesAsync``: FunctionBinding_LerpTexturesAsync = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_LoadAllSmartAssetsAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene -> JS.Promise<ResizeArray<BabylonjsBindings.SimpleClasses.AssetContainer>>

    [<Import("LoadAllSmartAssetsAsync", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``LoadAllSmartAssetsAsync``: FunctionBinding_LoadAllSmartAssetsAsync = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_LoadAssetContainerFromSerializedScene =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``serializedScene``: U2<string, BabylonjsBindings.SimpleInterfaces.JavaScriptObject> * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.AssetContainer

    [<Import("LoadAssetContainerFromSerializedScene", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``LoadAssetContainerFromSerializedScene``: FunctionBinding_LoadAssetContainerFromSerializedScene = jsNative

    /// @babylonjs/core/Lights/IES/iesLoader
    [<AllowNullLiteral>]
    type FunctionBinding_LoadIESData =
        [<Emit("$0($1...)")>] abstract Invoke: ``uint8Array``: JS.Uint8Array -> BabylonjsBindings.SimpleInterfaces.IIESTextureData

    [<Import("LoadIESData", "@babylonjs/core/Lights/IES/iesLoader.js")>]
    let ``LoadIESData``: FunctionBinding_LoadIESData = jsNative

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type FunctionBinding_LoadImageToTexture2DArrayLayerAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.RawTexture2DArray * ``url``: string * ``layer``: float * ?``options``: BabylonjsBindings.SimpleInterfaces.IUploadImageToTexture2DArrayLayerOptions -> JS.Promise<unit>

    [<Import("LoadImageToTexture2DArrayLayerAsync", "@babylonjs/core/Materials/Textures/rawTexture2DArray.functions.js")>]
    let ``LoadImageToTexture2DArrayLayerAsync``: FunctionBinding_LoadImageToTexture2DArrayLayerAsync = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_LoadSmartAssetMapAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``source``: U3<string, Browser.Types.File, BabylonjsBindings.SimpleInterfaces.ISerializedSmartAssetMap> * ?``rootUrl``: string -> JS.Promise<unit>

    [<Import("LoadSmartAssetMapAsync", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``LoadSmartAssetMapAsync``: FunctionBinding_LoadSmartAssetMapAsync = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetSerializer
    [<AllowNullLiteral>]
    type FunctionBinding_MakeRelative =
        [<Emit("$0($1...)")>] abstract Invoke: ``url``: string * ``baseUrl``: string -> string

    [<Import("MakeRelative", "@babylonjs/core/SmartAssets/smartAssetSerializer.js")>]
    let ``MakeRelative``: FunctionBinding_MakeRelative = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_MarkAsDirty =
        [<Emit("$0($1...)")>] abstract Invoke: ``matrix``: BabylonjsBindings.SimpleInterfaces.IMatrixLike -> unit

    [<Import("MarkAsDirty", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``MarkAsDirty``: FunctionBinding_MarkAsDirty = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_MaxTexturesAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``a``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``b``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``outputColorSpace``: BabylonjsBindings.Enums.TextureColorSpace * ?``outputChannelMask``: BabylonjsBindings.Enums.ChannelMask -> JS.Promise<BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand>

    [<Import("MaxTexturesAsync", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``MaxTexturesAsync``: FunctionBinding_MaxTexturesAsync = jsNative

    /// @babylonjs/core/Materials/Textures/textureMerger
    [<AllowNullLiteral>]
    type FunctionBinding_MergeTexturesAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``config``: BabylonjsBindings.SimpleInterfaces.ITextureMergeConfiguration * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> JS.Promise<BabylonjsBindings.SimpleClasses.ProceduralTexture>

    [<Import("MergeTexturesAsync", "@babylonjs/core/Materials/Textures/textureMerger.js")>]
    let ``MergeTexturesAsync``: FunctionBinding_MergeTexturesAsync = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_MoveTowards =
        [<Emit("$0($1...)")>] abstract Invoke: ``current``: float * ``target``: float * ``maxDelta``: float -> float

    [<Import("MoveTowards", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``MoveTowards``: FunctionBinding_MoveTowards = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_MoveTowardsAngle =
        [<Emit("$0($1...)")>] abstract Invoke: ``current``: float * ``target``: float * ``maxDelta``: float -> float

    [<Import("MoveTowardsAngle", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``MoveTowardsAngle``: FunctionBinding_MoveTowardsAngle = jsNative

    /// @babylonjs/core/Materials/multiMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_MultiMaterialParseMultiMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedMultiMaterial``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.MultiMaterial

    [<Import("MultiMaterialParseMultiMaterial", "@babylonjs/core/Materials/multiMaterial.pure.js")>]
    let ``MultiMaterialParseMultiMaterial``: FunctionBinding_MultiMaterialParseMultiMaterial = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_MultiPick =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``x``: float * ``y``: float * ?``predicate``: BabylonjsBindings.TypeAliases.MeshPredicate * ?``camera``: BabylonjsBindings.SimpleClasses.Camera * ?``trianglePredicate``: BabylonjsBindings.TypeAliases.TrianglePickingPredicate -> ResizeArray<BabylonjsBindings.SimpleClasses.PickingInfo> option

    [<Import("MultiPick", "@babylonjs/core/Culling/ray.core.js")>]
    let ``MultiPick``: FunctionBinding_MultiPick = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_MultiPickWithRay =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``ray``: BabylonjsBindings.SimpleClasses.Ray * ?``predicate``: BabylonjsBindings.TypeAliases.MeshPredicate * ?``trianglePredicate``: BabylonjsBindings.TypeAliases.TrianglePickingPredicate -> ResizeArray<BabylonjsBindings.SimpleClasses.PickingInfo> option

    [<Import("MultiPickWithRay", "@babylonjs/core/Culling/ray.core.js")>]
    let ``MultiPickWithRay``: FunctionBinding_MultiPickWithRay = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_MultiplyMatricesToArray =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``b``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``output``: U2<JS.Float32Array, ResizeArray<float>> * ?``offset``: float -> unit

    [<Import("MultiplyMatricesToArray", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``MultiplyMatricesToArray``: FunctionBinding_MultiplyMatricesToArray = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_MultiplyMatricesToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``b``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``result``: BabylonjsBindings.SimpleInterfaces.IMatrixLike * ?``offset``: float -> unit

    [<Import("MultiplyMatricesToRef", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``MultiplyMatricesToRef``: FunctionBinding_MultiplyMatricesToRef = jsNative

    /// @babylonjs/core/Materials/Textures/textureProcessor
    [<AllowNullLiteral>]
    type FunctionBinding_MultiplyTexturesAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``a``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``b``: BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``outputColorSpace``: BabylonjsBindings.Enums.TextureColorSpace * ?``outputChannelMask``: BabylonjsBindings.Enums.ChannelMask -> JS.Promise<BabylonjsBindings.SimpleInterfaces.ITextureProcessOperand>

    [<Import("MultiplyTexturesAsync", "@babylonjs/core/Materials/Textures/textureProcessor.js")>]
    let ``MultiplyTexturesAsync``: FunctionBinding_MultiplyTexturesAsync = jsNative

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_NodeMaterialBlockIsTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: ``block``: BabylonjsBindings.SimpleClasses.NodeMaterialBlock -> bool

    [<Import("NodeMaterialBlockIsTextureBlock", "@babylonjs/core/Materials/Node/nodeMaterial.pure.js")>]
    let ``NodeMaterialBlockIsTextureBlock``: FunctionBinding_NodeMaterialBlockIsTextureBlock = jsNative

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_NodeMaterialCreateDefault =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ?``scene``: BabylonjsBindings.SimpleClasses.Scene -> BabylonjsBindings.SimpleClasses.NodeMaterial

    [<Import("NodeMaterialCreateDefault", "@babylonjs/core/Materials/Node/nodeMaterial.pure.js")>]
    let ``NodeMaterialCreateDefault``: FunctionBinding_NodeMaterialCreateDefault = jsNative

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_NodeMaterialParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``rootUrl``: string * ?``shaderLanguage``: BabylonjsBindings.Enums.ShaderLanguage -> BabylonjsBindings.SimpleClasses.NodeMaterial

    [<Import("NodeMaterialParse", "@babylonjs/core/Materials/Node/nodeMaterial.pure.js")>]
    let ``NodeMaterialParse``: FunctionBinding_NodeMaterialParse = jsNative

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_NodeMaterialParseFromFileAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string * ``url``: string * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``rootUrl``: string * ?``skipBuild``: bool * ?``targetMaterial``: BabylonjsBindings.SimpleClasses.NodeMaterial * ?``urlRewriter``: System.Func<string, string> * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialINodeMaterialOptions -> JS.Promise<BabylonjsBindings.SimpleClasses.NodeMaterial>

    [<Import("NodeMaterialParseFromFileAsync", "@babylonjs/core/Materials/Node/nodeMaterial.pure.js")>]
    let ``NodeMaterialParseFromFileAsync``: FunctionBinding_NodeMaterialParseFromFileAsync = jsNative

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_NodeMaterialParseFromSnippetAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``this``: U2<BabylonjsBindings.SimpleClasses.NodeMaterialStatic, unit> * ``snippetId``: string * ?``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``rootUrl``: string * ?``nodeMaterial``: BabylonjsBindings.SimpleClasses.NodeMaterial * ?``skipBuild``: bool * ?``waitForTextureReadyness``: bool * ?``urlRewriter``: System.Func<string, string> * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialINodeMaterialOptions -> JS.Promise<BabylonjsBindings.SimpleClasses.NodeMaterial>

    [<Import("NodeMaterialParseFromSnippetAsync", "@babylonjs/core/Materials/Node/nodeMaterial.pure.js")>]
    let ``NodeMaterialParseFromSnippetAsync``: FunctionBinding_NodeMaterialParseFromSnippetAsync = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Normalize =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float * ``min``: float * ``max``: float -> float

    [<Import("Normalize", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``Normalize``: FunctionBinding_Normalize = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_normalizeEnvInfo =
        [<Emit("$0($1...)")>] abstract Invoke: ``info``: BabylonjsBindings.TypeAliases.EnvironmentTextureInfo -> BabylonjsBindings.SimpleInterfaces.EnvironmentTextureInfoV2

    [<Import("normalizeEnvInfo", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``normalizeEnvInfo``: FunctionBinding_normalizeEnvInfo = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_NormalizeRadians =
        [<Emit("$0($1...)")>] abstract Invoke: ``angle``: float -> float

    [<Import("NormalizeRadians", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``NormalizeRadians``: FunctionBinding_NormalizeRadians = jsNative

    /// @babylonjs/core/Materials/floatingOriginMatrixOverrides
    [<AllowNullLiteral>]
    type FunctionBinding_OffsetClipPlaneToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``offset``: BabylonjsBindings.SimpleClasses.Vector3 * ``plane``: BabylonjsBindings.SimpleClasses.Plane * ``ref``: BabylonjsBindings.SimpleClasses.Plane -> BabylonjsBindings.SimpleClasses.Plane

    [<Import("OffsetClipPlaneToRef", "@babylonjs/core/Materials/floatingOriginMatrixOverrides.js")>]
    let ``OffsetClipPlaneToRef``: FunctionBinding_OffsetClipPlaneToRef = jsNative

    /// @babylonjs/core/Materials/floatingOriginMatrixOverrides
    [<AllowNullLiteral>]
    type FunctionBinding_OffsetViewToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``offset``: BabylonjsBindings.SimpleInterfaces.IVector3Like * ``view``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike * ``ref``: BabylonjsBindings.SimpleClasses.Matrix -> BabylonjsBindings.SimpleInterfaces.DeepImmutableIMatrixLike

    [<Import("OffsetViewToRef", "@babylonjs/core/Materials/floatingOriginMatrixOverrides.js")>]
    let ``OffsetViewToRef``: FunctionBinding_OffsetViewToRef = jsNative

    /// @babylonjs/core/Meshes/mesh.vertexData.functions
    [<AllowNullLiteral>]
    type FunctionBinding_OptimizeIndices =
        [<Emit("$0($1...)")>] abstract Invoke: ``indices``: BabylonjsBindings.TypeAliases.IndicesArray -> unit

    [<Import("OptimizeIndices", "@babylonjs/core/Meshes/mesh.vertexData.functions.js")>]
    let ``OptimizeIndices``: FunctionBinding_OptimizeIndices = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_OutsideRange =
        [<Emit("$0($1...)")>] abstract Invoke: ``num``: float * ``min``: float * ``max``: float * ?``epsilon``: float -> bool

    [<Import("OutsideRange", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``OutsideRange``: FunctionBinding_OutsideRange = jsNative

    /// @babylonjs/core/Materials/floatingOriginMatrixOverrides
    [<AllowNullLiteral>]
    type FunctionBinding_OverrideMatrixFunctions =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("OverrideMatrixFunctions", "@babylonjs/core/Materials/floatingOriginMatrixOverrides.js")>]
    let ``OverrideMatrixFunctions``: FunctionBinding_OverrideMatrixFunctions = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileParser.function
    [<AllowNullLiteral>]
    type FunctionBinding_Parse =
        [<Emit("$0($1...)")>] abstract Invoke: ``jsonData``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``container``: BabylonjsBindings.SimpleClasses.AssetContainer * ``rootUrl``: string -> unit

    [<Import("Parse", "@babylonjs/core/Loading/Plugins/babylonFileParser.function.js")>]
    let ``Parse``: FunctionBinding_Parse = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseFloat16 =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("ParseFloat16", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseFloat16``: FunctionBinding_ParseFloat16 = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseFloat32 =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("ParseFloat32", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseFloat32``: FunctionBinding_ParseFloat32 = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphParser
    [<AllowNullLiteral>]
    type FunctionBinding_ParseFlowGraphContext =
        [<Emit("$0($1...)")>] abstract Invoke: ``serializationObject``: BabylonjsBindings.SimpleInterfaces.ISerializedFlowGraphContext * ``options``: BabylonjsBindings.SimpleInterfaces.IFlowGraphContextParseOptions * ?``rightHanded``: bool -> BabylonjsBindings.SimpleClasses.FlowGraphContext

    [<Import("ParseFlowGraphContext", "@babylonjs/core/FlowGraph/flowGraphParser.js")>]
    let ``ParseFlowGraphContext``: FunctionBinding_ParseFlowGraphContext = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphParser
    [<AllowNullLiteral>]
    type FunctionBinding_ParseGraphConnectionWithClassType =
        [<Emit("$0($1...)")>] abstract Invoke<'BlockT when 'BlockT :> BabylonjsBindings.SimpleClasses.FlowGraphBlock>: ``serializationObject``: obj option * ``ownerBlock``: 'BlockT * ``classType``: BabylonjsBindings.SimpleClasses.FlowGraphConnectionStatic -> BabylonjsBindings.SimpleClasses.FlowGraphConnection<'BlockT, BabylonjsBindings.SimpleInterfaces.IConnectable>

    [<Import("ParseGraphConnectionWithClassType", "@babylonjs/core/FlowGraph/flowGraphParser.js")>]
    let ``ParseGraphConnectionWithClassType``: FunctionBinding_ParseGraphConnectionWithClassType = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphParser
    [<AllowNullLiteral>]
    type FunctionBinding_ParseGraphDataConnection =
        [<Emit("$0($1...)")>] abstract Invoke: ``serializationObject``: obj * ``ownerBlock``: BabylonjsBindings.SimpleClasses.FlowGraphBlock * ``classType``: BabylonjsBindings.SimpleClasses.FlowGraphDataConnectionStatic -> BabylonjsBindings.SimpleClasses.FlowGraphDataConnection<obj>

    [<Import("ParseGraphDataConnection", "@babylonjs/core/FlowGraph/flowGraphParser.js")>]
    let ``ParseGraphDataConnection``: FunctionBinding_ParseGraphDataConnection = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseInt32 =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("ParseInt32", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseInt32``: FunctionBinding_ParseInt32 = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseInt64 =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("ParseInt64", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseInt64``: FunctionBinding_ParseInt64 = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseNullTerminatedString =
        [<Emit("$0($1...)")>] abstract Invoke: ``buffer``: U2<JS.ArrayBuffer, BabylonjsBindings.TypeAliases.BrowserSharedArrayBuffer> * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> string

    [<Import("ParseNullTerminatedString", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseNullTerminatedString``: FunctionBinding_ParseNullTerminatedString = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseUint16 =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("ParseUint16", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseUint16``: FunctionBinding_ParseUint16 = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseUint32 =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("ParseUint32", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseUint32``: FunctionBinding_ParseUint32 = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseUint8 =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("ParseUint8", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseUint8``: FunctionBinding_ParseUint8 = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseUint8Array =
        [<Emit("$0($1...)")>] abstract Invoke: ``array``: JS.Uint8Array * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> float

    [<Import("ParseUint8Array", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseUint8Array``: FunctionBinding_ParseUint8Array = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_ParseValue =
        [<Emit("$0($1...)")>] abstract Invoke: ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor * ``type``: string * ``size``: float -> U6<string, float, ResizeArray<float>, ResizeArray<InlineObject793fc298b906>, InlineObject5dbb9f7bffa0, InlineObject1d36c15dc75c> option

    [<Import("ParseValue", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``ParseValue``: FunctionBinding_ParseValue = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PercentToRange =
        [<Emit("$0($1...)")>] abstract Invoke: ``percent``: float * ``min``: float * ``max``: float -> float

    [<Import("PercentToRange", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``PercentToRange``: FunctionBinding_PercentToRange = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_Pick =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``x``: float * ``y``: float * ?``predicate``: BabylonjsBindings.TypeAliases.MeshPredicate * ?``fastCheck``: bool * ?``camera``: BabylonjsBindings.SimpleClasses.Camera option * ?``trianglePredicate``: BabylonjsBindings.TypeAliases.TrianglePickingPredicate * ?``_enableDistantPicking``: bool -> BabylonjsBindings.SimpleClasses.PickingInfo

    [<Import("Pick", "@babylonjs/core/Culling/ray.core.js")>]
    let ``Pick``: FunctionBinding_Pick = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_PickWithBoundingInfo =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``x``: float * ``y``: float * ?``predicate``: BabylonjsBindings.TypeAliases.MeshPredicate * ?``fastCheck``: bool * ?``camera``: BabylonjsBindings.SimpleClasses.Camera option -> BabylonjsBindings.SimpleClasses.PickingInfo option

    [<Import("PickWithBoundingInfo", "@babylonjs/core/Culling/ray.core.js")>]
    let ``PickWithBoundingInfo``: FunctionBinding_PickWithBoundingInfo = jsNative

    /// @babylonjs/core/Culling/ray.core
    [<AllowNullLiteral>]
    type FunctionBinding_PickWithRay =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``ray``: BabylonjsBindings.SimpleClasses.Ray * ?``predicate``: BabylonjsBindings.TypeAliases.MeshPredicate * ?``fastCheck``: bool * ?``trianglePredicate``: BabylonjsBindings.TypeAliases.TrianglePickingPredicate -> BabylonjsBindings.SimpleClasses.PickingInfo option

    [<Import("PickWithRay", "@babylonjs/core/Culling/ray.core.js")>]
    let ``PickWithRay``: FunctionBinding_PickWithRay = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PingPong =
        [<Emit("$0($1...)")>] abstract Invoke: ``tx``: float * ``length``: float -> float

    [<Import("PingPong", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``PingPong``: FunctionBinding_PingPong = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core
    [<AllowNullLiteral>]
    type FunctionBinding_Predictor =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: JS.Uint8Array -> unit

    [<Import("Predictor", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.core.js")>]
    let ``Predictor``: FunctionBinding_Predictor = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareAttributesForBakedVertexAnimation =
        [<Emit("$0($1...)")>] abstract Invoke: ``attribs``: ResizeArray<string> * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``defines``: obj -> unit

    [<Import("PrepareAttributesForBakedVertexAnimation", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareAttributesForBakedVertexAnimation``: FunctionBinding_PrepareAttributesForBakedVertexAnimation = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareAttributesForBones =
        [<Emit("$0($1...)")>] abstract Invoke: ``attribs``: ResizeArray<string> * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``defines``: obj * ``fallbacks``: BabylonjsBindings.SimpleClasses.EffectFallbacks -> unit

    [<Import("PrepareAttributesForBones", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareAttributesForBones``: FunctionBinding_PrepareAttributesForBones = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareAttributesForInstances =
        [<Emit("$0($1...)")>] abstract Invoke: ``attribs``: ResizeArray<string> * ``defines``: BabylonjsBindings.SimpleClasses.MaterialDefines -> unit

    [<Import("PrepareAttributesForInstances", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareAttributesForInstances``: FunctionBinding_PrepareAttributesForInstances = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareAttributesForMorphTargets =
        [<Emit("$0($1...)")>] abstract Invoke: ``attribs``: ResizeArray<string> * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``defines``: obj * ?``usePositionMorph``: bool -> unit

    [<Import("PrepareAttributesForMorphTargets", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareAttributesForMorphTargets``: FunctionBinding_PrepareAttributesForMorphTargets = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareAttributesForMorphTargetsInfluencers =
        [<Emit("$0($1...)")>] abstract Invoke: ``attribs``: ResizeArray<string> * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``influencers``: float -> unit

    [<Import("PrepareAttributesForMorphTargetsInfluencers", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareAttributesForMorphTargetsInfluencers``: FunctionBinding_PrepareAttributesForMorphTargetsInfluencers = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesAndAttributesForMorphTargets =
        [<Emit("$0($1...)")>] abstract Invoke: ``morphTargetManager``: BabylonjsBindings.SimpleClasses.MorphTargetManager * ``defines``: ResizeArray<string> * ``attribs``: ResizeArray<string> * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``usePositionMorph``: bool * ``useNormalMorph``: bool * ``useTangentMorph``: bool * ``useUVMorph``: bool * ``useUV2Morph``: bool * ``useColorMorph``: bool -> float

    [<Import("PrepareDefinesAndAttributesForMorphTargets", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesAndAttributesForMorphTargets``: FunctionBinding_PrepareDefinesAndAttributesForMorphTargets = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForAttributes =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``defines``: obj * ``useVertexColor``: bool * ``useBones``: bool * ?``useMorphTargets``: bool * ?``useVertexAlpha``: bool * ?``useBakedVertexAnimation``: bool -> bool

    [<Import("PrepareDefinesForAttributes", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForAttributes``: FunctionBinding_PrepareDefinesForAttributes = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForBakedVertexAnimation =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``defines``: obj -> unit

    [<Import("PrepareDefinesForBakedVertexAnimation", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForBakedVertexAnimation``: FunctionBinding_PrepareDefinesForBakedVertexAnimation = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForBones =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``defines``: obj -> unit

    [<Import("PrepareDefinesForBones", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForBones``: FunctionBinding_PrepareDefinesForBones = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForCamera =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``defines``: obj -> bool

    [<Import("PrepareDefinesForCamera", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForCamera``: FunctionBinding_PrepareDefinesForCamera = jsNative

    /// @babylonjs/core/Materials/clipPlaneMaterialHelper
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForClipPlanes =
        [<Emit("$0($1...)")>] abstract Invoke: ``primaryHolder``: BabylonjsBindings.SimpleInterfaces.IClipPlanesHolder * ``secondaryHolder``: BabylonjsBindings.SimpleInterfaces.IClipPlanesHolder * ``defines``: BabylonjsBindings.SimpleInterfaces.BrowserRecord<string, obj> -> bool

    [<Import("PrepareDefinesForClipPlanes", "@babylonjs/core/Materials/clipPlaneMaterialHelper.js")>]
    let ``PrepareDefinesForClipPlanes``: FunctionBinding_PrepareDefinesForClipPlanes = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForFrameBoundValues =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``material``: BabylonjsBindings.SimpleClasses.Material * ``defines``: obj * ``useInstances``: bool * ?``useClipPlane``: bool option * ?``useThinInstances``: bool -> unit

    [<Import("PrepareDefinesForFrameBoundValues", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForFrameBoundValues``: FunctionBinding_PrepareDefinesForFrameBoundValues = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForIBL =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``reflectionTexture``: BabylonjsBindings.SimpleClasses.BaseTexture option * ``defines``: obj * ?``realTimeFiltering``: bool * ?``realTimeFilteringQuality``: float * ?``forceSHInVertex``: bool -> bool

    [<Import("PrepareDefinesForIBL", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForIBL``: FunctionBinding_PrepareDefinesForIBL = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForLight =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``light``: BabylonjsBindings.SimpleClasses.Light * ``lightIndex``: float * ``defines``: obj * ``specularSupported``: bool * ``state``: InlineObjectabc05a379826 -> unit

    [<Import("PrepareDefinesForLight", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForLight``: FunctionBinding_PrepareDefinesForLight = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForLights =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``defines``: obj * ``specularSupported``: bool * ?``maxSimultaneousLights``: float * ?``disableLighting``: bool -> bool

    [<Import("PrepareDefinesForLights", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForLights``: FunctionBinding_PrepareDefinesForLights = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForMergedUV =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture * ``defines``: obj * ``key``: string -> unit

    [<Import("PrepareDefinesForMergedUV", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForMergedUV``: FunctionBinding_PrepareDefinesForMergedUV = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForMisc =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``useLogarithmicDepth``: bool * ``pointsCloud``: bool * ``fogEnabled``: bool * ``alphaTest``: bool * ``defines``: obj * ?``applyDecalAfterDetail``: bool * ?``useVertexPulling``: bool * ?``renderingMesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ?``setVertexOutputInvariant``: bool -> unit

    [<Import("PrepareDefinesForMisc", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForMisc``: FunctionBinding_PrepareDefinesForMisc = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForMorphTargets =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``defines``: obj -> unit

    [<Import("PrepareDefinesForMorphTargets", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForMorphTargets``: FunctionBinding_PrepareDefinesForMorphTargets = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForMultiview =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``defines``: obj -> unit

    [<Import("PrepareDefinesForMultiview", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForMultiview``: FunctionBinding_PrepareDefinesForMultiview = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForOIT =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``defines``: obj * ``needAlphaBlending``: bool -> unit

    [<Import("PrepareDefinesForOIT", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForOIT``: FunctionBinding_PrepareDefinesForOIT = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareDefinesForPrePass =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``defines``: obj * ``canRenderToMRT``: bool -> unit

    [<Import("PrepareDefinesForPrePass", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareDefinesForPrePass``: FunctionBinding_PrepareDefinesForPrePass = jsNative

    /// @babylonjs/core/Materials/clipPlaneMaterialHelper
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareStringDefinesForClipPlanes =
        [<Emit("$0($1...)")>] abstract Invoke: ``primaryHolder``: BabylonjsBindings.SimpleInterfaces.IClipPlanesHolder * ``secondaryHolder``: BabylonjsBindings.SimpleInterfaces.IClipPlanesHolder * ``defines``: ResizeArray<string> -> unit

    [<Import("PrepareStringDefinesForClipPlanes", "@babylonjs/core/Materials/clipPlaneMaterialHelper.js")>]
    let ``PrepareStringDefinesForClipPlanes``: FunctionBinding_PrepareStringDefinesForClipPlanes = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareUniformLayoutForIBL =
        [<Emit("$0($1...)")>] abstract Invoke: ``ubo``: BabylonjsBindings.SimpleClasses.UniformBuffer * ?``supportTextureInfo``: bool * ?``supportLocalProjection``: bool * ?``usePBR``: bool * ?``supportSH``: bool * ?``useColor``: bool -> unit

    [<Import("PrepareUniformLayoutForIBL", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareUniformLayoutForIBL``: FunctionBinding_PrepareUniformLayoutForIBL = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareUniformsAndSamplersForIBL =
        [<Emit("$0($1...)")>] abstract Invoke: ``uniformsList``: ResizeArray<string> * ``samplersList``: ResizeArray<string> * ``useSH``: bool -> unit

    [<Import("PrepareUniformsAndSamplersForIBL", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareUniformsAndSamplersForIBL``: FunctionBinding_PrepareUniformsAndSamplersForIBL = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareUniformsAndSamplersForLight =
        [<Emit("$0($1...)")>] abstract Invoke: ``lightIndex``: float * ``uniformsList``: ResizeArray<string> * ``samplersList``: ResizeArray<string> * ?``projectedLightTexture``: obj * ?``uniformBuffersList``: ResizeArray<string> option * ?``updateOnlyBuffersList``: bool * ?``iesLightTexture``: bool * ?``clusteredLightTextures``: bool * ?``rectAreaLightTexture``: bool * ?``clusteredLightStorageBuffer``: bool -> unit

    [<Import("PrepareUniformsAndSamplersForLight", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareUniformsAndSamplersForLight``: FunctionBinding_PrepareUniformsAndSamplersForLight = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareUniformsAndSamplersList =
        [<Emit("$0($1...)")>] abstract Invoke: ``uniformsListOrOptions``: U2<ResizeArray<string>, BabylonjsBindings.SimpleInterfaces.IEffectCreationOptions> * ?``samplersList``: ResizeArray<string> * ?``defines``: obj * ?``maxSimultaneousLights``: float -> unit

    [<Import("PrepareUniformsAndSamplersList", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PrepareUniformsAndSamplersList``: FunctionBinding_PrepareUniformsAndSamplersList = jsNative

    /// @babylonjs/core/Materials/vertexPullingHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PrepareVertexPullingUniforms =
        [<Emit("$0($1...)")>] abstract Invoke: ``geometry``: BabylonjsBindings.SimpleClasses.Geometry -> JS.Map<string, BabylonjsBindings.SimpleInterfaces.IVertexPullingMetadata> option

    [<Import("PrepareVertexPullingUniforms", "@babylonjs/core/Materials/vertexPullingHelper.functions.js")>]
    let ``PrepareVertexPullingUniforms``: FunctionBinding_PrepareVertexPullingUniforms = jsNative

    /// @babylonjs/core/Materials/materialHelper.functions
    [<AllowNullLiteral>]
    type FunctionBinding_PushAttributesForInstances =
        [<Emit("$0($1...)")>] abstract Invoke: ``attribs``: ResizeArray<string> * ?``needsPreviousMatrices``: bool -> unit

    [<Import("PushAttributesForInstances", "@babylonjs/core/Materials/materialHelper.functions.js")>]
    let ``PushAttributesForInstances``: FunctionBinding_PushAttributesForInstances = jsNative

    /// @babylonjs/core/Engines/abstractEngine.pure
    [<AllowNullLiteral>]
    type FunctionBinding_QueueNewFrame =
        [<Emit("$0($1...)")>] abstract Invoke: ``func``: System.Action * ?``requester``: obj -> float

    [<Import("QueueNewFrame", "@babylonjs/core/Engines/abstractEngine.pure.js")>]
    let ``QueueNewFrame``: FunctionBinding_QueueNewFrame = jsNative

    /// @babylonjs/core/Misc/guid
    [<AllowNullLiteral>]
    type FunctionBinding_RandomGUID =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> string

    [<Import("RandomGUID", "@babylonjs/core/Misc/guid.js")>]
    let ``RandomGUID``: FunctionBinding_RandomGUID = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_RandomRange =
        [<Emit("$0($1...)")>] abstract Invoke: ``min``: float * ``max``: float -> float

    [<Import("RandomRange", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``RandomRange``: FunctionBinding_RandomRange = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_RangeToPercent =
        [<Emit("$0($1...)")>] abstract Invoke: ``number``: float * ``min``: float * ``max``: float -> float

    [<Import("RangeToPercent", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``RangeToPercent``: FunctionBinding_RangeToPercent = jsNative

    /// @babylonjs/loaders/BVH/bvhLoader
    [<AllowNullLiteral>]
    type FunctionBinding_ReadBvh =
        [<Emit("$0($1...)")>] abstract Invoke: ``text``: string * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``assetContainer``: BabylonjsBindings.SimpleClasses.AssetContainer option * ``loadingOptions``: BabylonjsBindings.ObjectTypes.BVHLoadingOptions -> BabylonjsBindings.SimpleClasses.Skeleton

    [<Import("ReadBvh", "@babylonjs/loaders/BVH/bvhLoader.js")>]
    let ``ReadBvh``: FunctionBinding_ReadBvh = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/exrTextureLoader
    [<AllowNullLiteral>]
    type FunctionBinding_ReadExrDataAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: JS.ArrayBuffer -> JS.Promise<InlineObjectd4c7fe3a4c5c>

    [<Import("ReadExrDataAsync", "@babylonjs/core/Materials/Textures/Loaders/exrTextureLoader.js")>]
    let ``ReadExrDataAsync``: FunctionBinding_ReadExrDataAsync = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetSerializer
    [<AllowNullLiteral>]
    type FunctionBinding_ReadJsonSourceAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: U3<string, Browser.Types.File, BabylonjsBindings.SimpleInterfaces.JavaScriptObject> -> JS.Promise<obj>

    [<Import("ReadJsonSourceAsync", "@babylonjs/core/SmartAssets/smartAssetSerializer.js")>]
    let ``ReadJsonSourceAsync``: FunctionBinding_ReadJsonSourceAsync = jsNative

    /// @babylonjs/core/Probes/reflectionProbe.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ReflectionProbeParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedReflectionProbe``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.ReflectionProbe option

    [<Import("ReflectionProbeParse", "@babylonjs/core/Probes/reflectionProbe.pure.js")>]
    let ``ReflectionProbeParse``: FunctionBinding_ReflectionProbeParse = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.alpha.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineAlpha =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineAlpha", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.alpha.pure.js")>]
    let ``RegisterAbstractEngineAlpha``: FunctionBinding_RegisterAbstractEngineAlpha = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.cubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineCubeTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineCubeTexture", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.cubeTexture.pure.js")>]
    let ``RegisterAbstractEngineCubeTexture``: FunctionBinding_RegisterAbstractEngineCubeTexture = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.dom.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineDom =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineDom", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.dom.pure.js")>]
    let ``RegisterAbstractEngineDom``: FunctionBinding_RegisterAbstractEngineDom = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.loadFile.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineLoadFile =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineLoadFile", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.loadFile.pure.js")>]
    let ``RegisterAbstractEngineLoadFile``: FunctionBinding_RegisterAbstractEngineLoadFile = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.loadingScreen.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineLoadingScreen =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineLoadingScreen", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.loadingScreen.pure.js")>]
    let ``RegisterAbstractEngineLoadingScreen``: FunctionBinding_RegisterAbstractEngineLoadingScreen = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.query.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineQuery =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineQuery", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.query.pure.js")>]
    let ``RegisterAbstractEngineQuery``: FunctionBinding_RegisterAbstractEngineQuery = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.renderPass.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineRenderPass =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineRenderPass", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.renderPass.pure.js")>]
    let ``RegisterAbstractEngineRenderPass``: FunctionBinding_RegisterAbstractEngineRenderPass = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.states.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineStates =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineStates", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.states.pure.js")>]
    let ``RegisterAbstractEngineStates``: FunctionBinding_RegisterAbstractEngineStates = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.stencil.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineStencil =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineStencil", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.stencil.pure.js")>]
    let ``RegisterAbstractEngineStencil``: FunctionBinding_RegisterAbstractEngineStencil = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.texture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineTexture", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.texture.pure.js")>]
    let ``RegisterAbstractEngineTexture``: FunctionBinding_RegisterAbstractEngineTexture = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.textureSelector.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineTextureSelector =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineTextureSelector", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.textureSelector.pure.js")>]
    let ``RegisterAbstractEngineTextureSelector``: FunctionBinding_RegisterAbstractEngineTextureSelector = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.timeQuery.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineTimeQuery =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineTimeQuery", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.timeQuery.pure.js")>]
    let ``RegisterAbstractEngineTimeQuery``: FunctionBinding_RegisterAbstractEngineTimeQuery = jsNative

    /// @babylonjs/core/Engines/AbstractEngine/abstractEngine.views.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractEngineViews =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractEngineViews", "@babylonjs/core/Engines/AbstractEngine/abstractEngine.views.pure.js")>]
    let ``RegisterAbstractEngineViews``: FunctionBinding_RegisterAbstractEngineViews = jsNative

    /// @babylonjs/core/Meshes/abstractMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractMesh", "@babylonjs/core/Meshes/abstractMesh.pure.js")>]
    let ``RegisterAbstractMesh``: FunctionBinding_RegisterAbstractMesh = jsNative

    /// @babylonjs/core/Meshes/abstractMesh.decalMap.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAbstractMeshDecalMap =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAbstractMeshDecalMap", "@babylonjs/core/Meshes/abstractMesh.decalMap.pure.js")>]
    let ``RegisterAbstractMeshDecalMap``: FunctionBinding_RegisterAbstractMeshDecalMap = jsNative

    /// @babylonjs/core/Actions/action.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAction =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAction", "@babylonjs/core/Actions/action.pure.js")>]
    let ``RegisterAction``: FunctionBinding_RegisterAction = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/addBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAddBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAddBlock", "@babylonjs/core/Materials/Node/Blocks/addBlock.pure.js")>]
    let ``RegisterAddBlock``: FunctionBinding_RegisterAddBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Set/aggregatorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAggregatorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAggregatorBlock", "@babylonjs/core/Meshes/Node/Blocks/Set/aggregatorBlock.pure.js")>]
    let ``RegisterAggregatorBlock``: FunctionBinding_RegisterAggregatorBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/alignAngleBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAlignAngleBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAlignAngleBlock", "@babylonjs/core/Particles/Node/Blocks/Update/alignAngleBlock.pure.js")>]
    let ``RegisterAlignAngleBlock``: FunctionBinding_RegisterAlignAngleBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Matrices/alignBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAlignBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAlignBlock", "@babylonjs/core/Meshes/Node/Blocks/Matrices/alignBlock.pure.js")>]
    let ``RegisterAlignBlock``: FunctionBinding_RegisterAlignBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/ambientOcclusionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAmbientOcclusionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAmbientOcclusionBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/ambientOcclusionBlock.pure.js")>]
    let ``RegisterAmbientOcclusionBlock``: FunctionBinding_RegisterAmbientOcclusionBlock = jsNative

    /// @babylonjs/core/Cameras/Stereoscopic/anaglyphArcRotateCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnaglyphArcRotateCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnaglyphArcRotateCamera", "@babylonjs/core/Cameras/Stereoscopic/anaglyphArcRotateCamera.pure.js")>]
    let ``RegisterAnaglyphArcRotateCamera``: FunctionBinding_RegisterAnaglyphArcRotateCamera = jsNative

    /// @babylonjs/core/Cameras/Stereoscopic/anaglyphFreeCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnaglyphFreeCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnaglyphFreeCamera", "@babylonjs/core/Cameras/Stereoscopic/anaglyphFreeCamera.pure.js")>]
    let ``RegisterAnaglyphFreeCamera``: FunctionBinding_RegisterAnaglyphFreeCamera = jsNative

    /// @babylonjs/core/Cameras/Stereoscopic/anaglyphGamepadCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnaglyphGamepadCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnaglyphGamepadCamera", "@babylonjs/core/Cameras/Stereoscopic/anaglyphGamepadCamera.pure.js")>]
    let ``RegisterAnaglyphGamepadCamera``: FunctionBinding_RegisterAnaglyphGamepadCamera = jsNative

    /// @babylonjs/core/PostProcesses/anaglyphPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnaglyphPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnaglyphPostProcess", "@babylonjs/core/PostProcesses/anaglyphPostProcess.pure.js")>]
    let ``RegisterAnaglyphPostProcess``: FunctionBinding_RegisterAnaglyphPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/anaglyphPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnaglyphPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnaglyphPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/anaglyphPostProcessBlock.pure.js")>]
    let ``RegisterAnaglyphPostProcessBlock``: FunctionBinding_RegisterAnaglyphPostProcessBlock = jsNative

    /// @babylonjs/core/Cameras/Stereoscopic/anaglyphUniversalCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnaglyphUniversalCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnaglyphUniversalCamera", "@babylonjs/core/Cameras/Stereoscopic/anaglyphUniversalCamera.pure.js")>]
    let ``RegisterAnaglyphUniversalCamera``: FunctionBinding_RegisterAnaglyphUniversalCamera = jsNative

    /// @babylonjs/core/Animations/animatable.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnimatable =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnimatable", "@babylonjs/core/Animations/animatable.pure.js")>]
    let ``RegisterAnimatable``: FunctionBinding_RegisterAnimatable = jsNative

    /// @babylonjs/core/Animations/animation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnimation =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnimation", "@babylonjs/core/Animations/animation.pure.js")>]
    let ``RegisterAnimation``: FunctionBinding_RegisterAnimation = jsNative

    /// @babylonjs/core/Animations/animationGroup.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnimationGroup =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnimationGroup", "@babylonjs/core/Animations/animationGroup.pure.js")>]
    let ``RegisterAnimationGroup``: FunctionBinding_RegisterAnimationGroup = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/PBR/anisotropyBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAnisotropyBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAnisotropyBlock", "@babylonjs/core/Materials/Node/Blocks/PBR/anisotropyBlock.pure.js")>]
    let ``RegisterAnisotropyBlock``: FunctionBinding_RegisterAnisotropyBlock = jsNative

    /// @babylonjs/core/Cameras/arcRotateCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterArcRotateCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterArcRotateCamera", "@babylonjs/core/Cameras/arcRotateCamera.pure.js")>]
    let ``RegisterArcRotateCamera``: FunctionBinding_RegisterArcRotateCamera = jsNative

    /// @babylonjs/core/Cameras/Inputs/arcRotateCameraVRDeviceOrientationInput.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterArcRotateCameraVRDeviceOrientationInput =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterArcRotateCameraVRDeviceOrientationInput", "@babylonjs/core/Cameras/Inputs/arcRotateCameraVRDeviceOrientationInput.pure.js")>]
    let ``RegisterArcRotateCameraVRDeviceOrientationInput``: FunctionBinding_RegisterArcRotateCameraVRDeviceOrientationInput = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/arcTan2Block.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterArcTan2Block =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterArcTan2Block", "@babylonjs/core/Materials/Node/Blocks/arcTan2Block.pure.js")>]
    let ``RegisterArcTan2Block``: FunctionBinding_RegisterArcTan2Block = jsNative

    /// @babylonjs/core/Audio/audioEngine.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAudioEngine =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterAudioEngine", "@babylonjs/core/Audio/audioEngine.pure.js")>]
    let ``RegisterAudioEngine``: FunctionBinding_RegisterAudioEngine = jsNative

    /// @babylonjs/core/Audio/audioSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterAudioSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``soundClass``: BabylonjsBindings.SimpleClasses.SoundStatic -> unit

    [<Import("RegisterAudioSceneComponent", "@babylonjs/core/Audio/audioSceneComponent.pure.js")>]
    let ``RegisterAudioSceneComponent``: FunctionBinding_RegisterAudioSceneComponent = jsNative

    /// @babylonjs/core/Loading/Plugins/babylonFileLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBabylonFileLoader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBabylonFileLoader", "@babylonjs/core/Loading/Plugins/babylonFileLoader.pure.js")>]
    let ``RegisterBabylonFileLoader``: FunctionBinding_RegisterBabylonFileLoader = jsNative

    /// @babylonjs/core/Materials/Background/backgroundMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBackgroundMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBackgroundMaterial", "@babylonjs/core/Materials/Background/backgroundMaterial.pure.js")>]
    let ``RegisterBackgroundMaterial``: FunctionBinding_RegisterBackgroundMaterial = jsNative

    /// @babylonjs/core/Particles/baseParticleSystem.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBaseParticleSystem =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBaseParticleSystem", "@babylonjs/core/Particles/baseParticleSystem.pure.js")>]
    let ``RegisterBaseParticleSystem``: FunctionBinding_RegisterBaseParticleSystem = jsNative

    /// @babylonjs/core/Materials/Textures/baseTexture.polynomial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBaseTexturePolynomial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBaseTexturePolynomial", "@babylonjs/core/Materials/Textures/baseTexture.polynomial.pure.js")>]
    let ``RegisterBaseTexturePolynomial``: FunctionBinding_RegisterBaseTexturePolynomial = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/basicColorUpdateBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBasicColorUpdateBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBasicColorUpdateBlock", "@babylonjs/core/Particles/Node/Blocks/Update/basicColorUpdateBlock.pure.js")>]
    let ``RegisterBasicColorUpdateBlock``: FunctionBinding_RegisterBasicColorUpdateBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/basicPositionUpdateBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBasicPositionUpdateBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBasicPositionUpdateBlock", "@babylonjs/core/Particles/Node/Blocks/Update/basicPositionUpdateBlock.pure.js")>]
    let ``RegisterBasicPositionUpdateBlock``: FunctionBinding_RegisterBasicPositionUpdateBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/basicSpriteUpdateBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBasicSpriteUpdateBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBasicSpriteUpdateBlock", "@babylonjs/core/Particles/Node/Blocks/Update/basicSpriteUpdateBlock.pure.js")>]
    let ``RegisterBasicSpriteUpdateBlock``: FunctionBinding_RegisterBasicSpriteUpdateBlock = jsNative

    /// @babylonjs/core/Misc/basis.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBasis =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBasis", "@babylonjs/core/Misc/basis.pure.js")>]
    let ``RegisterBasis``: FunctionBinding_RegisterBasis = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/bevelBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBevelBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBevelBlock", "@babylonjs/core/Meshes/Node/Blocks/bevelBlock.pure.js")>]
    let ``RegisterBevelBlock``: FunctionBinding_RegisterBevelBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/biPlanarBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBiPlanarBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBiPlanarBlock", "@babylonjs/core/Materials/Node/Blocks/biPlanarBlock.pure.js")>]
    let ``RegisterBiPlanarBlock``: FunctionBinding_RegisterBiPlanarBlock = jsNative

    /// @babylonjs/core/PostProcesses/blackAndWhitePostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBlackAndWhitePostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBlackAndWhitePostProcess", "@babylonjs/core/PostProcesses/blackAndWhitePostProcess.pure.js")>]
    let ``RegisterBlackAndWhitePostProcess``: FunctionBinding_RegisterBlackAndWhitePostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/blackAndWhitePostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBlackAndWhitePostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBlackAndWhitePostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/blackAndWhitePostProcessBlock.pure.js")>]
    let ``RegisterBlackAndWhitePostProcessBlock``: FunctionBinding_RegisterBlackAndWhitePostProcessBlock = jsNative

    /// @babylonjs/core/PostProcesses/bloomMergePostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBloomMergePostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBloomMergePostProcess", "@babylonjs/core/PostProcesses/bloomMergePostProcess.pure.js")>]
    let ``RegisterBloomMergePostProcess``: FunctionBinding_RegisterBloomMergePostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/bloomPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBloomPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBloomPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/bloomPostProcessBlock.pure.js")>]
    let ``RegisterBloomPostProcessBlock``: FunctionBinding_RegisterBloomPostProcessBlock = jsNative

    /// @babylonjs/core/PostProcesses/blurPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBlurPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBlurPostProcess", "@babylonjs/core/PostProcesses/blurPostProcess.pure.js")>]
    let ``RegisterBlurPostProcess``: FunctionBinding_RegisterBlurPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/blurPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBlurPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBlurPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/blurPostProcessBlock.pure.js")>]
    let ``RegisterBlurPostProcessBlock``: FunctionBinding_RegisterBlurPostProcessBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Vertex/bonesBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBonesBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBonesBlock", "@babylonjs/core/Materials/Node/Blocks/Vertex/bonesBlock.pure.js")>]
    let ``RegisterBonesBlock``: FunctionBinding_RegisterBonesBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/booleanGeometryBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBooleanGeometryBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBooleanGeometryBlock", "@babylonjs/core/Meshes/Node/Blocks/booleanGeometryBlock.pure.js")>]
    let ``RegisterBooleanGeometryBlock``: FunctionBinding_RegisterBooleanGeometryBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/boundingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBoundingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBoundingBlock", "@babylonjs/core/Meshes/Node/Blocks/boundingBlock.pure.js")>]
    let ``RegisterBoundingBlock``: FunctionBinding_RegisterBoundingBlock = jsNative

    /// @babylonjs/core/Rendering/boundingBoxRenderer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBoundingBoxRenderer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBoundingBoxRenderer", "@babylonjs/core/Rendering/boundingBoxRenderer.pure.js")>]
    let ``RegisterBoundingBoxRenderer``: FunctionBinding_RegisterBoundingBoxRenderer = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/boxBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBoxBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBoxBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/boxBlock.pure.js")>]
    let ``RegisterBoxBlock``: FunctionBinding_RegisterBoxBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/boxBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBoxBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBoxBuilder", "@babylonjs/core/Meshes/Builders/boxBuilder.pure.js")>]
    let ``RegisterBoxBuilder``: FunctionBinding_RegisterBoxBuilder = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/boxShapeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBoxShapeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBoxShapeBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/boxShapeBlock.pure.js")>]
    let ``RegisterBoxShapeBlock``: FunctionBinding_RegisterBoxShapeBlock = jsNative

    /// @babylonjs/core/Buffers/buffer.align.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBufferAlign =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBufferAlign", "@babylonjs/core/Buffers/buffer.align.pure.js")>]
    let ``RegisterBufferAlign``: FunctionBinding_RegisterBufferAlign = jsNative

    /// @babylonjs/loaders/dynamic
    [<AllowNullLiteral>]
    type FunctionBinding_registerBuiltInLoaders =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("registerBuiltInLoaders", "@babylonjs/loaders/dynamic.js")>]
    let ``registerBuiltInLoaders``: FunctionBinding_registerBuiltInLoaders = jsNative

    /// @babylonjs/loaders/BVH/bvhFileLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterBVHFileLoader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterBVHFileLoader", "@babylonjs/loaders/BVH/bvhFileLoader.pure.js")>]
    let ``RegisterBVHFileLoader``: FunctionBinding_RegisterBVHFileLoader = jsNative

    /// @babylonjs/core/Cameras/camera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCamera", "@babylonjs/core/Cameras/camera.pure.js")>]
    let ``RegisterCamera``: FunctionBinding_RegisterCamera = jsNative

    /// @babylonjs/core/Physics/v1/Plugins/cannonJSPlugin.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCannonJSPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCannonJSPlugin", "@babylonjs/core/Physics/v1/Plugins/cannonJSPlugin.pure.js")>]
    let ``RegisterCannonJSPlugin``: FunctionBinding_RegisterCannonJSPlugin = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/capsuleBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCapsuleBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCapsuleBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/capsuleBlock.pure.js")>]
    let ``RegisterCapsuleBlock``: FunctionBinding_RegisterCapsuleBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/capsuleBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCapsuleBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCapsuleBuilder", "@babylonjs/core/Meshes/Builders/capsuleBuilder.pure.js")>]
    let ``RegisterCapsuleBuilder``: FunctionBinding_RegisterCapsuleBuilder = jsNative

    /// @babylonjs/core/Lights/Shadows/cascadedShadowGenerator.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCascadedShadowGenerator =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCascadedShadowGenerator", "@babylonjs/core/Lights/Shadows/cascadedShadowGenerator.pure.js")>]
    let ``RegisterCascadedShadowGenerator``: FunctionBinding_RegisterCascadedShadowGenerator = jsNative

    /// @babylonjs/core/PostProcesses/chromaticAberrationPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterChromaticAberrationPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterChromaticAberrationPostProcess", "@babylonjs/core/PostProcesses/chromaticAberrationPostProcess.pure.js")>]
    let ``RegisterChromaticAberrationPostProcess``: FunctionBinding_RegisterChromaticAberrationPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/chromaticAberrationPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterChromaticAberrationPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterChromaticAberrationPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/chromaticAberrationPostProcessBlock.pure.js")>]
    let ``RegisterChromaticAberrationPostProcessBlock``: FunctionBinding_RegisterChromaticAberrationPostProcessBlock = jsNative

    /// @babylonjs/core/PostProcesses/circleOfConfusionPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCircleOfConfusionPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCircleOfConfusionPostProcess", "@babylonjs/core/PostProcesses/circleOfConfusionPostProcess.pure.js")>]
    let ``RegisterCircleOfConfusionPostProcess``: FunctionBinding_RegisterCircleOfConfusionPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/circleOfConfusionPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCircleOfConfusionPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCircleOfConfusionPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/circleOfConfusionPostProcessBlock.pure.js")>]
    let ``RegisterCircleOfConfusionPostProcessBlock``: FunctionBinding_RegisterCircleOfConfusionPostProcessBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/clampBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterClampBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterClampBlock", "@babylonjs/core/Materials/Node/Blocks/clampBlock.pure.js")>]
    let ``RegisterClampBlock``: FunctionBinding_RegisterClampBlock = jsNative

    /// @babylonjs/core/Misc/typeStore
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterClass =
        [<Emit("$0($1...)")>] abstract Invoke: ``className``: string * ``type``: BabylonjsBindings.SimpleInterfaces.JavaScriptObject -> unit

    [<Import("RegisterClass", "@babylonjs/core/Misc/typeStore.js")>]
    let ``RegisterClass``: FunctionBinding_RegisterClass = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/cleanGeometryBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCleanGeometryBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCleanGeometryBlock", "@babylonjs/core/Meshes/Node/Blocks/cleanGeometryBlock.pure.js")>]
    let ``RegisterCleanGeometryBlock``: FunctionBinding_RegisterCleanGeometryBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Textures/clearBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterClearBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterClearBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Textures/clearBlock.pure.js")>]
    let ``RegisterClearBlock``: FunctionBinding_RegisterClearBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/PBR/clearCoatBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterClearCoatBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterClearCoatBlock", "@babylonjs/core/Materials/Node/Blocks/PBR/clearCoatBlock.pure.js")>]
    let ``RegisterClearCoatBlock``: FunctionBinding_RegisterClearCoatBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/clipPlanesBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterClipPlanesBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterClipPlanesBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/clipPlanesBlock.pure.js")>]
    let ``RegisterClipPlanesBlock``: FunctionBinding_RegisterClipPlanesBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/cloudBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCloudBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCloudBlock", "@babylonjs/core/Materials/Node/Blocks/cloudBlock.pure.js")>]
    let ``RegisterCloudBlock``: FunctionBinding_RegisterCloudBlock = jsNative

    /// @babylonjs/core/Lights/Clustered/clusteredLightContainer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterClusteredLightContainer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterClusteredLightContainer", "@babylonjs/core/Lights/Clustered/clusteredLightContainer.pure.js")>]
    let ``RegisterClusteredLightContainer``: FunctionBinding_RegisterClusteredLightContainer = jsNative

    /// @babylonjs/core/Lights/Clustered/clusteredLightingSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterClusteredLightingSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``clusteredLightContainerClass``: BabylonjsBindings.SimpleClasses.ClusteredLightContainerStatic -> unit

    [<Import("RegisterClusteredLightingSceneComponent", "@babylonjs/core/Lights/Clustered/clusteredLightingSceneComponent.pure.js")>]
    let ``RegisterClusteredLightingSceneComponent``: FunctionBinding_RegisterClusteredLightingSceneComponent = jsNative

    /// @babylonjs/core/Collisions/collisionCoordinator.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCollisionCoordinator =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCollisionCoordinator", "@babylonjs/core/Collisions/collisionCoordinator.pure.js")>]
    let ``RegisterCollisionCoordinator``: FunctionBinding_RegisterCollisionCoordinator = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/colorConverterBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterColorConverterBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterColorConverterBlock", "@babylonjs/core/Materials/Node/Blocks/colorConverterBlock.pure.js")>]
    let ``RegisterColorConverterBlock``: FunctionBinding_RegisterColorConverterBlock = jsNative

    /// @babylonjs/core/PostProcesses/colorCorrectionPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterColorCorrectionPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterColorCorrectionPostProcess", "@babylonjs/core/PostProcesses/colorCorrectionPostProcess.pure.js")>]
    let ``RegisterColorCorrectionPostProcess``: FunctionBinding_RegisterColorCorrectionPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/colorCorrectionPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterColorCorrectionPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterColorCorrectionPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/colorCorrectionPostProcessBlock.pure.js")>]
    let ``RegisterColorCorrectionPostProcessBlock``: FunctionBinding_RegisterColorCorrectionPostProcessBlock = jsNative

    /// @babylonjs/core/Materials/colorCurves.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterColorCurves =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterColorCurves", "@babylonjs/core/Materials/colorCurves.pure.js")>]
    let ``RegisterColorCurves``: FunctionBinding_RegisterColorCurves = jsNative

    /// @babylonjs/core/Materials/Textures/colorGradingTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterColorGradingTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterColorGradingTexture", "@babylonjs/core/Materials/Textures/colorGradingTexture.pure.js")>]
    let ``RegisterColorGradingTexture``: FunctionBinding_RegisterColorGradingTexture = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/colorMergerBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterColorMergerBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterColorMergerBlock", "@babylonjs/core/Materials/Node/Blocks/colorMergerBlock.pure.js")>]
    let ``RegisterColorMergerBlock``: FunctionBinding_RegisterColorMergerBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/colorSplitterBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterColorSplitterBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterColorSplitterBlock", "@babylonjs/core/Materials/Node/Blocks/colorSplitterBlock.pure.js")>]
    let ``RegisterColorSplitterBlock``: FunctionBinding_RegisterColorSplitterBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/computeNormalsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterComputeNormalsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterComputeNormalsBlock", "@babylonjs/core/Meshes/Node/Blocks/computeNormalsBlock.pure.js")>]
    let ``RegisterComputeNormalsBlock``: FunctionBinding_RegisterComputeNormalsBlock = jsNative

    /// @babylonjs/core/Compute/computeShader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterComputeShader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterComputeShader", "@babylonjs/core/Compute/computeShader.pure.js")>]
    let ``RegisterComputeShader``: FunctionBinding_RegisterComputeShader = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/computeShaderBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterComputeShaderBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterComputeShaderBlock", "@babylonjs/core/FrameGraph/Node/Blocks/computeShaderBlock.pure.js")>]
    let ``RegisterComputeShaderBlock``: FunctionBinding_RegisterComputeShaderBlock = jsNative

    /// @babylonjs/core/Particles/computeShaderParticleSystem.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterComputeShaderParticleSystem =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterComputeShaderParticleSystem", "@babylonjs/core/Particles/computeShaderParticleSystem.pure.js")>]
    let ``RegisterComputeShaderParticleSystem``: FunctionBinding_RegisterComputeShaderParticleSystem = jsNative

    /// @babylonjs/core/Actions/condition.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCondition =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCondition", "@babylonjs/core/Actions/condition.pure.js")>]
    let ``RegisterCondition``: FunctionBinding_RegisterCondition = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/conditionalBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterConditionalBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterConditionalBlock", "@babylonjs/core/Materials/Node/Blocks/conditionalBlock.pure.js")>]
    let ``RegisterConditionalBlock``: FunctionBinding_RegisterConditionalBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/conditionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterConditionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterConditionBlock", "@babylonjs/core/Meshes/Node/Blocks/conditionBlock.pure.js")>]
    let ``RegisterConditionBlock``: FunctionBinding_RegisterConditionBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/coneShapeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterConeShapeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterConeShapeBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/coneShapeBlock.pure.js")>]
    let ``RegisterConeShapeBlock``: FunctionBinding_RegisterConeShapeBlock = jsNative

    /// @babylonjs/core/PostProcesses/convolutionPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterConvolutionPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterConvolutionPostProcess", "@babylonjs/core/PostProcesses/convolutionPostProcess.pure.js")>]
    let ``RegisterConvolutionPostProcess``: FunctionBinding_RegisterConvolutionPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/convolutionPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterConvolutionPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterConvolutionPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/convolutionPostProcessBlock.pure.js")>]
    let ``RegisterConvolutionPostProcessBlock``: FunctionBinding_RegisterConvolutionPostProcessBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Textures/copyTextureBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCopyTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCopyTextureBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Textures/copyTextureBlock.pure.js")>]
    let ``RegisterCopyTextureBlock``: FunctionBinding_RegisterCopyTextureBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/createParticleBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCreateParticleBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCreateParticleBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/createParticleBlock.pure.js")>]
    let ``RegisterCreateParticleBlock``: FunctionBinding_RegisterCreateParticleBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/crossBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCrossBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCrossBlock", "@babylonjs/core/Materials/Node/Blocks/crossBlock.pure.js")>]
    let ``RegisterCrossBlock``: FunctionBinding_RegisterCrossBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Rendering/csmShadowGeneratorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCsmShadowGeneratorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCsmShadowGeneratorBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Rendering/csmShadowGeneratorBlock.pure.js")>]
    let ``RegisterCsmShadowGeneratorBlock``: FunctionBinding_RegisterCsmShadowGeneratorBlock = jsNative

    /// @babylonjs/core/Materials/Textures/cubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCubeTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCubeTexture", "@babylonjs/core/Materials/Textures/cubeTexture.pure.js")>]
    let ``RegisterCubeTexture``: FunctionBinding_RegisterCubeTexture = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/cullObjectsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCullObjectsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCullObjectsBlock", "@babylonjs/core/FrameGraph/Node/Blocks/cullObjectsBlock.pure.js")>]
    let ``RegisterCullObjectsBlock``: FunctionBinding_RegisterCullObjectsBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/currentScreenBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCurrentScreenBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCurrentScreenBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/currentScreenBlock.pure.js")>]
    let ``RegisterCurrentScreenBlock``: FunctionBinding_RegisterCurrentScreenBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/curveBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCurveBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCurveBlock", "@babylonjs/core/Materials/Node/Blocks/curveBlock.pure.js")>]
    let ``RegisterCurveBlock``: FunctionBinding_RegisterCurveBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/customBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCustomBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCustomBlock", "@babylonjs/core/Materials/Node/Blocks/customBlock.pure.js")>]
    let ``RegisterCustomBlock``: FunctionBinding_RegisterCustomBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/customShapeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCustomShapeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCustomShapeBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/customShapeBlock.pure.js")>]
    let ``RegisterCustomShapeBlock``: FunctionBinding_RegisterCustomShapeBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/cylinderBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCylinderBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCylinderBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/cylinderBlock.pure.js")>]
    let ``RegisterCylinderBlock``: FunctionBinding_RegisterCylinderBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/cylinderBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCylinderBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCylinderBuilder", "@babylonjs/core/Meshes/Builders/cylinderBuilder.pure.js")>]
    let ``RegisterCylinderBuilder``: FunctionBinding_RegisterCylinderBuilder = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/cylinderShapeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterCylinderShapeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterCylinderShapeBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/cylinderShapeBlock.pure.js")>]
    let ``RegisterCylinderShapeBlock``: FunctionBinding_RegisterCylinderShapeBlock = jsNative

    /// @babylonjs/core/Offline/database.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDatabase =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDatabase", "@babylonjs/core/Offline/database.pure.js")>]
    let ``RegisterDatabase``: FunctionBinding_RegisterDatabase = jsNative

    /// @babylonjs/core/Debug/debugLayer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDebugLayer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDebugLayer", "@babylonjs/core/Debug/debugLayer.pure.js")>]
    let ``RegisterDebugLayer``: FunctionBinding_RegisterDebugLayer = jsNative

    /// @babylonjs/core/Meshes/Builders/decalBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDecalBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDecalBuilder", "@babylonjs/core/Meshes/Builders/decalBuilder.pure.js")>]
    let ``RegisterDecalBuilder``: FunctionBinding_RegisterDecalBuilder = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/defaultRenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDefaultRenderingPipeline =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDefaultRenderingPipeline", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/defaultRenderingPipeline.pure.js")>]
    let ``RegisterDefaultRenderingPipeline``: FunctionBinding_RegisterDefaultRenderingPipeline = jsNative

    /// @babylonjs/core/PostProcesses/depthOfFieldBlurPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDepthOfFieldBlurPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDepthOfFieldBlurPostProcess", "@babylonjs/core/PostProcesses/depthOfFieldBlurPostProcess.pure.js")>]
    let ``RegisterDepthOfFieldBlurPostProcess``: FunctionBinding_RegisterDepthOfFieldBlurPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/depthOfFieldPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDepthOfFieldPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDepthOfFieldPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/depthOfFieldPostProcessBlock.pure.js")>]
    let ``RegisterDepthOfFieldPostProcessBlock``: FunctionBinding_RegisterDepthOfFieldPostProcessBlock = jsNative

    /// @babylonjs/core/Rendering/depthPeelingSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDepthPeelingSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``depthPeelingRendererClass``: BabylonjsBindings.SimpleClasses.DepthPeelingRendererStatic -> unit

    [<Import("RegisterDepthPeelingSceneComponent", "@babylonjs/core/Rendering/depthPeelingSceneComponent.pure.js")>]
    let ``RegisterDepthPeelingSceneComponent``: FunctionBinding_RegisterDepthPeelingSceneComponent = jsNative

    /// @babylonjs/core/Rendering/depthRendererSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDepthRendererSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``depthRendererClass``: BabylonjsBindings.SimpleClasses.DepthRendererStatic -> unit

    [<Import("RegisterDepthRendererSceneComponent", "@babylonjs/core/Rendering/depthRendererSceneComponent.pure.js")>]
    let ``RegisterDepthRendererSceneComponent``: FunctionBinding_RegisterDepthRendererSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/depthSourceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDepthSourceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDepthSourceBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/depthSourceBlock.pure.js")>]
    let ``RegisterDepthSourceBlock``: FunctionBinding_RegisterDepthSourceBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/derivativeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDerivativeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDerivativeBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/derivativeBlock.pure.js")>]
    let ``RegisterDerivativeBlock``: FunctionBinding_RegisterDerivativeBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/desaturateBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDesaturateBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDesaturateBlock", "@babylonjs/core/Materials/Node/Blocks/desaturateBlock.pure.js")>]
    let ``RegisterDesaturateBlock``: FunctionBinding_RegisterDesaturateBlock = jsNative

    /// @babylonjs/core/Cameras/deviceOrientationCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDeviceOrientationCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDeviceOrientationCamera", "@babylonjs/core/Cameras/deviceOrientationCamera.pure.js")>]
    let ``RegisterDeviceOrientationCamera``: FunctionBinding_RegisterDeviceOrientationCamera = jsNative

    /// @babylonjs/core/Actions/directActions.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDirectActions =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDirectActions", "@babylonjs/core/Actions/directActions.pure.js")>]
    let ``RegisterDirectActions``: FunctionBinding_RegisterDirectActions = jsNative

    /// @babylonjs/core/Actions/directAudioActions.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDirectAudioActions =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDirectAudioActions", "@babylonjs/core/Actions/directAudioActions.pure.js")>]
    let ``RegisterDirectAudioActions``: FunctionBinding_RegisterDirectAudioActions = jsNative

    /// @babylonjs/core/Lights/directionalLight.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDirectionalLight =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDirectionalLight", "@babylonjs/core/Lights/directionalLight.pure.js")>]
    let ``RegisterDirectionalLight``: FunctionBinding_RegisterDirectionalLight = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/discardBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDiscardBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDiscardBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/discardBlock.pure.js")>]
    let ``RegisterDiscardBlock``: FunctionBinding_RegisterDiscardBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/discBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDiscBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDiscBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/discBlock.pure.js")>]
    let ``RegisterDiscBlock``: FunctionBinding_RegisterDiscBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/discBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDiscBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDiscBuilder", "@babylonjs/core/Meshes/Builders/discBuilder.pure.js")>]
    let ``RegisterDiscBuilder``: FunctionBinding_RegisterDiscBuilder = jsNative

    /// @babylonjs/core/PostProcesses/displayPassPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDisplayPassPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDisplayPassPostProcess", "@babylonjs/core/PostProcesses/displayPassPostProcess.pure.js")>]
    let ``RegisterDisplayPassPostProcess``: FunctionBinding_RegisterDisplayPassPostProcess = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/distanceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDistanceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDistanceBlock", "@babylonjs/core/Materials/Node/Blocks/distanceBlock.pure.js")>]
    let ``RegisterDistanceBlock``: FunctionBinding_RegisterDistanceBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/divideBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDivideBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDivideBlock", "@babylonjs/core/Materials/Node/Blocks/divideBlock.pure.js")>]
    let ``RegisterDivideBlock``: FunctionBinding_RegisterDivideBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/dotBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDotBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDotBlock", "@babylonjs/core/Materials/Node/Blocks/dotBlock.pure.js")>]
    let ``RegisterDotBlock``: FunctionBinding_RegisterDotBlock = jsNative

    /// @babylonjs/core/Misc/dumpTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterDumpTools =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterDumpTools", "@babylonjs/core/Misc/dumpTools.pure.js")>]
    let ``RegisterDumpTools``: FunctionBinding_RegisterDumpTools = jsNative

    /// @babylonjs/core/Rendering/edgesRenderer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEdgesRenderer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEdgesRenderer", "@babylonjs/core/Rendering/edgesRenderer.pure.js")>]
    let ``RegisterEdgesRenderer``: FunctionBinding_RegisterEdgesRenderer = jsNative

    /// @babylonjs/core/Layers/effectLayerSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEffectLayerSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``effectLayerClass``: BabylonjsBindings.SimpleClasses.EffectLayerStatic -> unit

    [<Import("RegisterEffectLayerSceneComponent", "@babylonjs/core/Layers/effectLayerSceneComponent.pure.js")>]
    let ``RegisterEffectLayerSceneComponent``: FunctionBinding_RegisterEffectLayerSceneComponent = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.debugging.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEngineDebugging =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEngineDebugging", "@babylonjs/core/Engines/Extensions/engine.debugging.pure.js")>]
    let ``RegisterEngineDebugging``: FunctionBinding_RegisterEngineDebugging = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.dynamicBuffer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEngineDynamicBuffer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEngineDynamicBuffer", "@babylonjs/core/Engines/Extensions/engine.dynamicBuffer.pure.js")>]
    let ``RegisterEngineDynamicBuffer``: FunctionBinding_RegisterEngineDynamicBuffer = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.multiview.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEngineMultiview =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEngineMultiview", "@babylonjs/core/Engines/Extensions/engine.multiview.pure.js")>]
    let ``RegisterEngineMultiview``: FunctionBinding_RegisterEngineMultiview = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.prefilteredCubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginePrefilteredCubeTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginePrefilteredCubeTexture", "@babylonjs/core/Engines/Extensions/engine.prefilteredCubeTexture.pure.js")>]
    let ``RegisterEnginePrefilteredCubeTexture``: FunctionBinding_RegisterEnginePrefilteredCubeTexture = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.alpha.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineAlpha =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineAlpha", "@babylonjs/core/Engines/Extensions/engine.alpha.pure.js")>]
    let ``RegisterEnginesExtensionsEngineAlpha``: FunctionBinding_RegisterEnginesExtensionsEngineAlpha = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.alphaToCoverage.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineAlphaToCoverage =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineAlphaToCoverage", "@babylonjs/core/Engines/Extensions/engine.alphaToCoverage.pure.js")>]
    let ``RegisterEnginesExtensionsEngineAlphaToCoverage``: FunctionBinding_RegisterEnginesExtensionsEngineAlphaToCoverage = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.computeShader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineComputeShader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineComputeShader", "@babylonjs/core/Engines/Extensions/engine.computeShader.pure.js")>]
    let ``RegisterEnginesExtensionsEngineComputeShader``: FunctionBinding_RegisterEnginesExtensionsEngineComputeShader = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.cubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineCubeTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineCubeTexture", "@babylonjs/core/Engines/Extensions/engine.cubeTexture.pure.js")>]
    let ``RegisterEnginesExtensionsEngineCubeTexture``: FunctionBinding_RegisterEnginesExtensionsEngineCubeTexture = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.dynamicTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineDynamicTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineDynamicTexture", "@babylonjs/core/Engines/Extensions/engine.dynamicTexture.pure.js")>]
    let ``RegisterEnginesExtensionsEngineDynamicTexture``: FunctionBinding_RegisterEnginesExtensionsEngineDynamicTexture = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.multiRender.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineMultiRender =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineMultiRender", "@babylonjs/core/Engines/Extensions/engine.multiRender.pure.js")>]
    let ``RegisterEnginesExtensionsEngineMultiRender``: FunctionBinding_RegisterEnginesExtensionsEngineMultiRender = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.query.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineQuery =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineQuery", "@babylonjs/core/Engines/Extensions/engine.query.pure.js")>]
    let ``RegisterEnginesExtensionsEngineQuery``: FunctionBinding_RegisterEnginesExtensionsEngineQuery = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.rawTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineRawTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineRawTexture", "@babylonjs/core/Engines/Extensions/engine.rawTexture.pure.js")>]
    let ``RegisterEnginesExtensionsEngineRawTexture``: FunctionBinding_RegisterEnginesExtensionsEngineRawTexture = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.readTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineReadTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineReadTexture", "@babylonjs/core/Engines/Extensions/engine.readTexture.pure.js")>]
    let ``RegisterEnginesExtensionsEngineReadTexture``: FunctionBinding_RegisterEnginesExtensionsEngineReadTexture = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.renderTarget.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineRenderTarget =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineRenderTarget", "@babylonjs/core/Engines/Extensions/engine.renderTarget.pure.js")>]
    let ``RegisterEnginesExtensionsEngineRenderTarget``: FunctionBinding_RegisterEnginesExtensionsEngineRenderTarget = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.renderTargetCube.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineRenderTargetCube =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineRenderTargetCube", "@babylonjs/core/Engines/Extensions/engine.renderTargetCube.pure.js")>]
    let ``RegisterEnginesExtensionsEngineRenderTargetCube``: FunctionBinding_RegisterEnginesExtensionsEngineRenderTargetCube = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.renderTargetTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineRenderTargetTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineRenderTargetTexture", "@babylonjs/core/Engines/Extensions/engine.renderTargetTexture.pure.js")>]
    let ``RegisterEnginesExtensionsEngineRenderTargetTexture``: FunctionBinding_RegisterEnginesExtensionsEngineRenderTargetTexture = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.videoTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesExtensionsEngineVideoTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesExtensionsEngineVideoTexture", "@babylonjs/core/Engines/Extensions/engine.videoTexture.pure.js")>]
    let ``RegisterEnginesExtensionsEngineVideoTexture``: FunctionBinding_RegisterEnginesExtensionsEngineVideoTexture = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.alpha.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineAlpha =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineAlpha", "@babylonjs/core/Engines/WebGPU/Extensions/engine.alpha.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineAlpha``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineAlpha = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.alphaToCoverage.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineAlphaToCoverage =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineAlphaToCoverage", "@babylonjs/core/Engines/WebGPU/Extensions/engine.alphaToCoverage.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineAlphaToCoverage``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineAlphaToCoverage = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.computeShader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineComputeShader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineComputeShader", "@babylonjs/core/Engines/WebGPU/Extensions/engine.computeShader.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineComputeShader``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineComputeShader = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.cubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineCubeTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineCubeTexture", "@babylonjs/core/Engines/WebGPU/Extensions/engine.cubeTexture.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineCubeTexture``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineCubeTexture = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.dynamicTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineDynamicTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineDynamicTexture", "@babylonjs/core/Engines/WebGPU/Extensions/engine.dynamicTexture.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineDynamicTexture``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineDynamicTexture = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.multiRender.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineMultiRender =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineMultiRender", "@babylonjs/core/Engines/WebGPU/Extensions/engine.multiRender.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineMultiRender``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineMultiRender = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.query.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineQuery =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineQuery", "@babylonjs/core/Engines/WebGPU/Extensions/engine.query.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineQuery``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineQuery = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.rawTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineRawTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineRawTexture", "@babylonjs/core/Engines/WebGPU/Extensions/engine.rawTexture.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineRawTexture``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineRawTexture = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.readTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineReadTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineReadTexture", "@babylonjs/core/Engines/WebGPU/Extensions/engine.readTexture.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineReadTexture``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineReadTexture = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.renderTarget.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineRenderTarget =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineRenderTarget", "@babylonjs/core/Engines/WebGPU/Extensions/engine.renderTarget.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineRenderTarget``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineRenderTarget = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.renderTargetCube.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineRenderTargetCube =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineRenderTargetCube", "@babylonjs/core/Engines/WebGPU/Extensions/engine.renderTargetCube.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineRenderTargetCube``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineRenderTargetCube = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.renderTargetTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineRenderTargetTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineRenderTargetTexture", "@babylonjs/core/Engines/WebGPU/Extensions/engine.renderTargetTexture.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineRenderTargetTexture``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineRenderTargetTexture = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.videoTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEnginesWebGPUExtensionsEngineVideoTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEnginesWebGPUExtensionsEngineVideoTexture", "@babylonjs/core/Engines/WebGPU/Extensions/engine.videoTexture.pure.js")>]
    let ``RegisterEnginesWebGPUExtensionsEngineVideoTexture``: FunctionBinding_RegisterEnginesWebGPUExtensionsEngineVideoTexture = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.transformFeedback.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEngineTransformFeedback =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEngineTransformFeedback", "@babylonjs/core/Engines/Extensions/engine.transformFeedback.pure.js")>]
    let ``RegisterEngineTransformFeedback``: FunctionBinding_RegisterEngineTransformFeedback = jsNative

    /// @babylonjs/core/Engines/Extensions/engine.uniformBuffer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEngineUniformBuffer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEngineUniformBuffer", "@babylonjs/core/Engines/Extensions/engine.uniformBuffer.pure.js")>]
    let ``RegisterEngineUniformBuffer``: FunctionBinding_RegisterEngineUniformBuffer = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/executeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterExecuteBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterExecuteBlock", "@babylonjs/core/FrameGraph/Node/Blocks/executeBlock.pure.js")>]
    let ``RegisterExecuteBlock``: FunctionBinding_RegisterExecuteBlock = jsNative

    /// @babylonjs/core/Materials/Textures/exrCubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterExrCubeTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterExrCubeTexture", "@babylonjs/core/Materials/Textures/exrCubeTexture.pure.js")>]
    let ``RegisterExrCubeTexture``: FunctionBinding_RegisterExrCubeTexture = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_area.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEXT_lights_area =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEXT_lights_area", "@babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_area.pure.js")>]
    let ``RegisterEXT_lights_area``: FunctionBinding_RegisterEXT_lights_area = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_ies.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEXT_lights_ies =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEXT_lights_ies", "@babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_ies.pure.js")>]
    let ``RegisterEXT_lights_ies``: FunctionBinding_RegisterEXT_lights_ies = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_image_based.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEXT_lights_image_based =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEXT_lights_image_based", "@babylonjs/loaders/glTF/2.0/Extensions/EXT_lights_image_based.pure.js")>]
    let ``RegisterEXT_lights_image_based``: FunctionBinding_RegisterEXT_lights_image_based = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/EXT_mesh_gpu_instancing.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEXT_mesh_gpu_instancing =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEXT_mesh_gpu_instancing", "@babylonjs/loaders/glTF/2.0/Extensions/EXT_mesh_gpu_instancing.pure.js")>]
    let ``RegisterEXT_mesh_gpu_instancing``: FunctionBinding_RegisterEXT_mesh_gpu_instancing = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/EXT_meshopt_compression.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEXT_meshopt_compression =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEXT_meshopt_compression", "@babylonjs/loaders/glTF/2.0/Extensions/EXT_meshopt_compression.pure.js")>]
    let ``RegisterEXT_meshopt_compression``: FunctionBinding_RegisterEXT_meshopt_compression = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/EXT_texture_avif.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEXT_texture_avif =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEXT_texture_avif", "@babylonjs/loaders/glTF/2.0/Extensions/EXT_texture_avif.pure.js")>]
    let ``RegisterEXT_texture_avif``: FunctionBinding_RegisterEXT_texture_avif = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/EXT_texture_webp.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterEXT_texture_webp =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterEXT_texture_webp", "@babylonjs/loaders/glTF/2.0/Extensions/EXT_texture_webp.pure.js")>]
    let ``RegisterEXT_texture_webp``: FunctionBinding_RegisterEXT_texture_webp = jsNative

    /// @babylonjs/core/PostProcesses/extractHighlightsPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterExtractHighlightsPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterExtractHighlightsPostProcess", "@babylonjs/core/PostProcesses/extractHighlightsPostProcess.pure.js")>]
    let ``RegisterExtractHighlightsPostProcess``: FunctionBinding_RegisterExtractHighlightsPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/extractHighlightsPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterExtractHighlightsPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterExtractHighlightsPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/extractHighlightsPostProcessBlock.pure.js")>]
    let ``RegisterExtractHighlightsPostProcessBlock``: FunctionBinding_RegisterExtractHighlightsPostProcessBlock = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/ExtrasAsMetadata.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterExtrasAsMetadata =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterExtrasAsMetadata", "@babylonjs/loaders/glTF/2.0/Extensions/ExtrasAsMetadata.pure.js")>]
    let ``RegisterExtrasAsMetadata``: FunctionBinding_RegisterExtrasAsMetadata = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/extrudeGeometryBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterExtrudeGeometryBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterExtrudeGeometryBlock", "@babylonjs/core/Meshes/Node/Blocks/extrudeGeometryBlock.pure.js")>]
    let ``RegisterExtrudeGeometryBlock``: FunctionBinding_RegisterExtrudeGeometryBlock = jsNative

    /// @babylonjs/loaders/FBX/fbxFileLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFBXFileLoader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFBXFileLoader", "@babylonjs/loaders/FBX/fbxFileLoader.pure.js")>]
    let ``RegisterFBXFileLoader``: FunctionBinding_RegisterFBXFileLoader = jsNative

    /// @babylonjs/core/Misc/fileTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFileTools =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFileTools", "@babylonjs/core/Misc/fileTools.pure.js")>]
    let ``RegisterFileTools``: FunctionBinding_RegisterFileTools = jsNative

    /// @babylonjs/core/PostProcesses/filterPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFilterPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFilterPostProcess", "@babylonjs/core/PostProcesses/filterPostProcess.pure.js")>]
    let ``RegisterFilterPostProcess``: FunctionBinding_RegisterFilterPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/filterPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFilterPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFilterPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/filterPostProcessBlock.pure.js")>]
    let ``RegisterFilterPostProcessBlock``: FunctionBinding_RegisterFilterPostProcessBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphApplyForceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphApplyForceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphApplyForceBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphApplyForceBlock.pure.js")>]
    let ``RegisterFlowGraphApplyForceBlock``: FunctionBinding_RegisterFlowGraphApplyForceBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphApplyImpulseBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphApplyImpulseBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphApplyImpulseBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphApplyImpulseBlock.pure.js")>]
    let ``RegisterFlowGraphApplyImpulseBlock``: FunctionBinding_RegisterFlowGraphApplyImpulseBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphArrayIndexBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphArrayIndexBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphArrayIndexBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphArrayIndexBlock.pure.js")>]
    let ``RegisterFlowGraphArrayIndexBlock``: FunctionBinding_RegisterFlowGraphArrayIndexBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphBezierCurveEasingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphBezierCurveEasingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphBezierCurveEasingBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphBezierCurveEasingBlock.pure.js")>]
    let ``RegisterFlowGraphBezierCurveEasingBlock``: FunctionBinding_RegisterFlowGraphBezierCurveEasingBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphBranchBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphBranchBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphBranchBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphBranchBlock.pure.js")>]
    let ``RegisterFlowGraphBranchBlock``: FunctionBinding_RegisterFlowGraphBranchBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphCancelDelayBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphCancelDelayBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphCancelDelayBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphCancelDelayBlock.pure.js")>]
    let ``RegisterFlowGraphCancelDelayBlock``: FunctionBinding_RegisterFlowGraphCancelDelayBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphConditionalDataBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphConditionalDataBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphConditionalDataBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphConditionalDataBlock.pure.js")>]
    let ``RegisterFlowGraphConditionalDataBlock``: FunctionBinding_RegisterFlowGraphConditionalDataBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/flowGraphConsoleLogBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphConsoleLogBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphConsoleLogBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/flowGraphConsoleLogBlock.pure.js")>]
    let ``RegisterFlowGraphConsoleLogBlock``: FunctionBinding_RegisterFlowGraphConsoleLogBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphConstantBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphConstantBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphConstantBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphConstantBlock.pure.js")>]
    let ``RegisterFlowGraphConstantBlock``: FunctionBinding_RegisterFlowGraphConstantBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphContextBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphContextBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphContextBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphContextBlock.pure.js")>]
    let ``RegisterFlowGraphContextBlock``: FunctionBinding_RegisterFlowGraphContextBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphCounterBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphCounterBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphCounterBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphCounterBlock.pure.js")>]
    let ``RegisterFlowGraphCounterBlock``: FunctionBinding_RegisterFlowGraphCounterBlock = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphDataConnection.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphDataConnection =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphDataConnection", "@babylonjs/core/FlowGraph/flowGraphDataConnection.pure.js")>]
    let ``RegisterFlowGraphDataConnection``: FunctionBinding_RegisterFlowGraphDataConnection = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphDataSwitchBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphDataSwitchBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphDataSwitchBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphDataSwitchBlock.pure.js")>]
    let ``RegisterFlowGraphDataSwitchBlock``: FunctionBinding_RegisterFlowGraphDataSwitchBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphDebounceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphDebounceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphDebounceBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphDebounceBlock.pure.js")>]
    let ``RegisterFlowGraphDebounceBlock``: FunctionBinding_RegisterFlowGraphDebounceBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphDoNBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphDoNBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphDoNBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphDoNBlock.pure.js")>]
    let ``RegisterFlowGraphDoNBlock``: FunctionBinding_RegisterFlowGraphDoNBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphEasingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphEasingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphEasingBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphEasingBlock.pure.js")>]
    let ``RegisterFlowGraphEasingBlock``: FunctionBinding_RegisterFlowGraphEasingBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphFlipFlopBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphFlipFlopBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphFlipFlopBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphFlipFlopBlock.pure.js")>]
    let ``RegisterFlowGraphFlipFlopBlock``: FunctionBinding_RegisterFlowGraphFlipFlopBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphForLoopBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphForLoopBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphForLoopBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphForLoopBlock.pure.js")>]
    let ``RegisterFlowGraphForLoopBlock``: FunctionBinding_RegisterFlowGraphForLoopBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphFunctionReferenceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphFunctionReferenceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphFunctionReferenceBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphFunctionReferenceBlock.pure.js")>]
    let ``RegisterFlowGraphFunctionReferenceBlock``: FunctionBinding_RegisterFlowGraphFunctionReferenceBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Physics/flowGraphGetAngularVelocityBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphGetAngularVelocityBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphGetAngularVelocityBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Physics/flowGraphGetAngularVelocityBlock.pure.js")>]
    let ``RegisterFlowGraphGetAngularVelocityBlock``: FunctionBinding_RegisterFlowGraphGetAngularVelocityBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetAssetBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphGetAssetBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphGetAssetBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetAssetBlock.pure.js")>]
    let ``RegisterFlowGraphGetAssetBlock``: FunctionBinding_RegisterFlowGraphGetAssetBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Physics/flowGraphGetLinearVelocityBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphGetLinearVelocityBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphGetLinearVelocityBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Physics/flowGraphGetLinearVelocityBlock.pure.js")>]
    let ``RegisterFlowGraphGetLinearVelocityBlock``: FunctionBinding_RegisterFlowGraphGetLinearVelocityBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Physics/flowGraphGetPhysicsMassPropertiesBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphGetPhysicsMassPropertiesBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphGetPhysicsMassPropertiesBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Physics/flowGraphGetPhysicsMassPropertiesBlock.pure.js")>]
    let ``RegisterFlowGraphGetPhysicsMassPropertiesBlock``: FunctionBinding_RegisterFlowGraphGetPhysicsMassPropertiesBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetPropertyBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphGetPropertyBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphGetPropertyBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetPropertyBlock.pure.js")>]
    let ``RegisterFlowGraphGetPropertyBlock``: FunctionBinding_RegisterFlowGraphGetPropertyBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Audio/flowGraphGetSoundVolumeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphGetSoundVolumeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphGetSoundVolumeBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Audio/flowGraphGetSoundVolumeBlock.pure.js")>]
    let ``RegisterFlowGraphGetSoundVolumeBlock``: FunctionBinding_RegisterFlowGraphGetSoundVolumeBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetVariableBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphGetVariableBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphGetVariableBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphGetVariableBlock.pure.js")>]
    let ``RegisterFlowGraphGetVariableBlock``: FunctionBinding_RegisterFlowGraphGetVariableBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphIndexOfBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphIndexOfBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphIndexOfBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Utils/flowGraphIndexOfBlock.pure.js")>]
    let ``RegisterFlowGraphIndexOfBlock``: FunctionBinding_RegisterFlowGraphIndexOfBlock = jsNative

    /// @babylonjs/core/FlowGraph/CustomTypes/flowGraphInteger.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphInteger =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphInteger", "@babylonjs/core/FlowGraph/CustomTypes/flowGraphInteger.pure.js")>]
    let ``RegisterFlowGraphInteger``: FunctionBinding_RegisterFlowGraphInteger = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphInterpolationBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphInterpolationBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphInterpolationBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphInterpolationBlock.pure.js")>]
    let ``RegisterFlowGraphInterpolationBlock``: FunctionBinding_RegisterFlowGraphInterpolationBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Audio/flowGraphIsSoundPlayingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphIsSoundPlayingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphIsSoundPlayingBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Audio/flowGraphIsSoundPlayingBlock.pure.js")>]
    let ``RegisterFlowGraphIsSoundPlayingBlock``: FunctionBinding_RegisterFlowGraphIsSoundPlayingBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphJsonPointerParserBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphJsonPointerParserBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphJsonPointerParserBlock", "@babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphJsonPointerParserBlock.pure.js")>]
    let ``RegisterFlowGraphJsonPointerParserBlock``: FunctionBinding_RegisterFlowGraphJsonPointerParserBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphMathBlocks =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphMathBlocks", "@babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathBlocks.pure.js")>]
    let ``RegisterFlowGraphMathBlocks``: FunctionBinding_RegisterFlowGraphMathBlocks = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathCombineExtractBlocks.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphMathCombineExtractBlocks =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphMathCombineExtractBlocks", "@babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMathCombineExtractBlocks.pure.js")>]
    let ``RegisterFlowGraphMathCombineExtractBlocks``: FunctionBinding_RegisterFlowGraphMathCombineExtractBlocks = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMatrixMathBlocks.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphMatrixMathBlocks =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphMatrixMathBlocks", "@babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphMatrixMathBlocks.pure.js")>]
    let ``RegisterFlowGraphMatrixMathBlocks``: FunctionBinding_RegisterFlowGraphMatrixMathBlocks = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphMeshPickEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphMeshPickEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphMeshPickEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphMeshPickEventBlock.pure.js")>]
    let ``RegisterFlowGraphMeshPickEventBlock``: FunctionBinding_RegisterFlowGraphMeshPickEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphMultiGateBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphMultiGateBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphMultiGateBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphMultiGateBlock.pure.js")>]
    let ``RegisterFlowGraphMultiGateBlock``: FunctionBinding_RegisterFlowGraphMultiGateBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphPauseAnimationBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphPauseAnimationBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphPauseAnimationBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphPauseAnimationBlock.pure.js")>]
    let ``RegisterFlowGraphPauseAnimationBlock``: FunctionBinding_RegisterFlowGraphPauseAnimationBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Audio/flowGraphPauseSoundBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphPauseSoundBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphPauseSoundBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Audio/flowGraphPauseSoundBlock.pure.js")>]
    let ``RegisterFlowGraphPauseSoundBlock``: FunctionBinding_RegisterFlowGraphPauseSoundBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPhysicsCollisionEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphPhysicsCollisionEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphPhysicsCollisionEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphPhysicsCollisionEventBlock.pure.js")>]
    let ``RegisterFlowGraphPhysicsCollisionEventBlock``: FunctionBinding_RegisterFlowGraphPhysicsCollisionEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphPlayAnimationBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphPlayAnimationBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphPlayAnimationBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphPlayAnimationBlock.pure.js")>]
    let ``RegisterFlowGraphPlayAnimationBlock``: FunctionBinding_RegisterFlowGraphPlayAnimationBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Audio/flowGraphPlaySoundBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphPlaySoundBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphPlaySoundBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Audio/flowGraphPlaySoundBlock.pure.js")>]
    let ``RegisterFlowGraphPlaySoundBlock``: FunctionBinding_RegisterFlowGraphPlaySoundBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPointerOutEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphPointerOutEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphPointerOutEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphPointerOutEventBlock.pure.js")>]
    let ``RegisterFlowGraphPointerOutEventBlock``: FunctionBinding_RegisterFlowGraphPointerOutEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphPointerOverEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphPointerOverEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphPointerOverEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphPointerOverEventBlock.pure.js")>]
    let ``RegisterFlowGraphPointerOverEventBlock``: FunctionBinding_RegisterFlowGraphPointerOverEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphReceiveCustomEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphReceiveCustomEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphReceiveCustomEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphReceiveCustomEventBlock.pure.js")>]
    let ``RegisterFlowGraphReceiveCustomEventBlock``: FunctionBinding_RegisterFlowGraphReceiveCustomEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphRichTypes.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphRichTypes =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphRichTypes", "@babylonjs/core/FlowGraph/flowGraphRichTypes.pure.js")>]
    let ``RegisterFlowGraphRichTypes``: FunctionBinding_RegisterFlowGraphRichTypes = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphSceneReadyEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSceneReadyEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSceneReadyEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphSceneReadyEventBlock.pure.js")>]
    let ``RegisterFlowGraphSceneReadyEventBlock``: FunctionBinding_RegisterFlowGraphSceneReadyEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphSceneTickEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSceneTickEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSceneTickEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphSceneTickEventBlock.pure.js")>]
    let ``RegisterFlowGraphSceneTickEventBlock``: FunctionBinding_RegisterFlowGraphSceneTickEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphSendCustomEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSendCustomEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSendCustomEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphSendCustomEventBlock.pure.js")>]
    let ``RegisterFlowGraphSendCustomEventBlock``: FunctionBinding_RegisterFlowGraphSendCustomEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSequenceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSequenceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSequenceBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSequenceBlock.pure.js")>]
    let ``RegisterFlowGraphSequenceBlock``: FunctionBinding_RegisterFlowGraphSequenceBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphSetAngularVelocityBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSetAngularVelocityBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSetAngularVelocityBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphSetAngularVelocityBlock.pure.js")>]
    let ``RegisterFlowGraphSetAngularVelocityBlock``: FunctionBinding_RegisterFlowGraphSetAngularVelocityBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSetDelayBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSetDelayBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSetDelayBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSetDelayBlock.pure.js")>]
    let ``RegisterFlowGraphSetDelayBlock``: FunctionBinding_RegisterFlowGraphSetDelayBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphSetLinearVelocityBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSetLinearVelocityBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSetLinearVelocityBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphSetLinearVelocityBlock.pure.js")>]
    let ``RegisterFlowGraphSetLinearVelocityBlock``: FunctionBinding_RegisterFlowGraphSetLinearVelocityBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphSetPhysicsMotionTypeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSetPhysicsMotionTypeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSetPhysicsMotionTypeBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Physics/flowGraphSetPhysicsMotionTypeBlock.pure.js")>]
    let ``RegisterFlowGraphSetPhysicsMotionTypeBlock``: FunctionBinding_RegisterFlowGraphSetPhysicsMotionTypeBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetPropertyBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSetPropertyBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSetPropertyBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetPropertyBlock.pure.js")>]
    let ``RegisterFlowGraphSetPropertyBlock``: FunctionBinding_RegisterFlowGraphSetPropertyBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Audio/flowGraphSetSoundVolumeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSetSoundVolumeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSetSoundVolumeBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Audio/flowGraphSetSoundVolumeBlock.pure.js")>]
    let ``RegisterFlowGraphSetSoundVolumeBlock``: FunctionBinding_RegisterFlowGraphSetSoundVolumeBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetVariableBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSetVariableBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSetVariableBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/flowGraphSetVariableBlock.pure.js")>]
    let ``RegisterFlowGraphSetVariableBlock``: FunctionBinding_RegisterFlowGraphSetVariableBlock = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphSignalConnection.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSignalConnection =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSignalConnection", "@babylonjs/core/FlowGraph/flowGraphSignalConnection.pure.js")>]
    let ``RegisterFlowGraphSignalConnection``: FunctionBinding_RegisterFlowGraphSignalConnection = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Event/flowGraphSoundEndedEventBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSoundEndedEventBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSoundEndedEventBlock", "@babylonjs/core/FlowGraph/Blocks/Event/flowGraphSoundEndedEventBlock.pure.js")>]
    let ``RegisterFlowGraphSoundEndedEventBlock``: FunctionBinding_RegisterFlowGraphSoundEndedEventBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphStopAnimationBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphStopAnimationBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphStopAnimationBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Animation/flowGraphStopAnimationBlock.pure.js")>]
    let ``RegisterFlowGraphStopAnimationBlock``: FunctionBinding_RegisterFlowGraphStopAnimationBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/Audio/flowGraphStopSoundBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphStopSoundBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphStopSoundBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/Audio/flowGraphStopSoundBlock.pure.js")>]
    let ``RegisterFlowGraphStopSoundBlock``: FunctionBinding_RegisterFlowGraphStopSoundBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSwitchBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphSwitchBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphSwitchBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphSwitchBlock.pure.js")>]
    let ``RegisterFlowGraphSwitchBlock``: FunctionBinding_RegisterFlowGraphSwitchBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphThrottleBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphThrottleBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphThrottleBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphThrottleBlock.pure.js")>]
    let ``RegisterFlowGraphThrottleBlock``: FunctionBinding_RegisterFlowGraphThrottleBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/flowGraphTransformCoordinatesSystemBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphTransformCoordinatesSystemBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphTransformCoordinatesSystemBlock", "@babylonjs/core/FlowGraph/Blocks/Data/flowGraphTransformCoordinatesSystemBlock.pure.js")>]
    let ``RegisterFlowGraphTransformCoordinatesSystemBlock``: FunctionBinding_RegisterFlowGraphTransformCoordinatesSystemBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphTypeToTypeBlocks.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphTypeToTypeBlocks =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphTypeToTypeBlocks", "@babylonjs/core/FlowGraph/Blocks/Data/Transformers/flowGraphTypeToTypeBlocks.pure.js")>]
    let ``RegisterFlowGraphTypeToTypeBlocks``: FunctionBinding_RegisterFlowGraphTypeToTypeBlocks = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphVectorMathBlocks.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphVectorMathBlocks =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphVectorMathBlocks", "@babylonjs/core/FlowGraph/Blocks/Data/Math/flowGraphVectorMathBlocks.pure.js")>]
    let ``RegisterFlowGraphVectorMathBlocks``: FunctionBinding_RegisterFlowGraphVectorMathBlocks = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphWaitAllBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphWaitAllBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphWaitAllBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphWaitAllBlock.pure.js")>]
    let ``RegisterFlowGraphWaitAllBlock``: FunctionBinding_RegisterFlowGraphWaitAllBlock = jsNative

    /// @babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphWhileLoopBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlowGraphWhileLoopBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlowGraphWhileLoopBlock", "@babylonjs/core/FlowGraph/Blocks/Execution/ControlFlow/flowGraphWhileLoopBlock.pure.js")>]
    let ``RegisterFlowGraphWhileLoopBlock``: FunctionBinding_RegisterFlowGraphWhileLoopBlock = jsNative

    /// @babylonjs/core/Rendering/fluidRenderer/fluidRenderer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFluidRenderer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFluidRenderer", "@babylonjs/core/Rendering/fluidRenderer/fluidRenderer.pure.js")>]
    let ``RegisterFluidRenderer``: FunctionBinding_RegisterFluidRenderer = jsNative

    /// @babylonjs/core/Cameras/flyCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFlyCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFlyCamera", "@babylonjs/core/Cameras/flyCamera.pure.js")>]
    let ``RegisterFlyCamera``: FunctionBinding_RegisterFlyCamera = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/fogBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFogBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFogBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/fogBlock.pure.js")>]
    let ``RegisterFogBlock``: FunctionBinding_RegisterFogBlock = jsNative

    /// @babylonjs/core/Cameras/followCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFollowCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFollowCamera", "@babylonjs/core/Cameras/followCamera.pure.js")>]
    let ``RegisterFollowCamera``: FunctionBinding_RegisterFollowCamera = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/fragCoordBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFragCoordBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFragCoordBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/fragCoordBlock.pure.js")>]
    let ``RegisterFragCoordBlock``: FunctionBinding_RegisterFragCoordBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/fragDepthBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFragDepthBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFragDepthBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/fragDepthBlock.pure.js")>]
    let ``RegisterFragDepthBlock``: FunctionBinding_RegisterFragDepthBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/fragmentOutputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFragmentOutputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFragmentOutputBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/fragmentOutputBlock.pure.js")>]
    let ``RegisterFragmentOutputBlock``: FunctionBinding_RegisterFragmentOutputBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/elbowBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFrameGraphNodeBlocksElbowBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFrameGraphNodeBlocksElbowBlock", "@babylonjs/core/FrameGraph/Node/Blocks/elbowBlock.pure.js")>]
    let ``RegisterFrameGraphNodeBlocksElbowBlock``: FunctionBinding_RegisterFrameGraphNodeBlocksElbowBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/inputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFrameGraphNodeBlocksInputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFrameGraphNodeBlocksInputBlock", "@babylonjs/core/FrameGraph/Node/Blocks/inputBlock.pure.js")>]
    let ``RegisterFrameGraphNodeBlocksInputBlock``: FunctionBinding_RegisterFrameGraphNodeBlocksInputBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Teleport/teleportInBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFrameGraphNodeBlocksTeleportTeleportInBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFrameGraphNodeBlocksTeleportTeleportInBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Teleport/teleportInBlock.pure.js")>]
    let ``RegisterFrameGraphNodeBlocksTeleportTeleportInBlock``: FunctionBinding_RegisterFrameGraphNodeBlocksTeleportTeleportInBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Teleport/teleportOutBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFrameGraphNodeBlocksTeleportTeleportOutBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFrameGraphNodeBlocksTeleportTeleportOutBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Teleport/teleportOutBlock.pure.js")>]
    let ``RegisterFrameGraphNodeBlocksTeleportTeleportOutBlock``: FunctionBinding_RegisterFrameGraphNodeBlocksTeleportTeleportOutBlock = jsNative

    /// @babylonjs/core/Cameras/freeCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFreeCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFreeCamera", "@babylonjs/core/Cameras/freeCamera.pure.js")>]
    let ``RegisterFreeCamera``: FunctionBinding_RegisterFreeCamera = jsNative

    /// @babylonjs/core/Cameras/Inputs/freeCameraDeviceOrientationInput.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFreeCameraDeviceOrientationInput =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFreeCameraDeviceOrientationInput", "@babylonjs/core/Cameras/Inputs/freeCameraDeviceOrientationInput.pure.js")>]
    let ``RegisterFreeCameraDeviceOrientationInput``: FunctionBinding_RegisterFreeCameraDeviceOrientationInput = jsNative

    /// @babylonjs/core/Cameras/Inputs/freeCameraVirtualJoystickInput.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFreeCameraVirtualJoystickInput =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFreeCameraVirtualJoystickInput", "@babylonjs/core/Cameras/Inputs/freeCameraVirtualJoystickInput.pure.js")>]
    let ``RegisterFreeCameraVirtualJoystickInput``: FunctionBinding_RegisterFreeCameraVirtualJoystickInput = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/fresnelBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFresnelBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFresnelBlock", "@babylonjs/core/Materials/Node/Blocks/fresnelBlock.pure.js")>]
    let ``RegisterFresnelBlock``: FunctionBinding_RegisterFresnelBlock = jsNative

    /// @babylonjs/core/Materials/fresnelParameters.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFresnelParameters =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFresnelParameters", "@babylonjs/core/Materials/fresnelParameters.pure.js")>]
    let ``RegisterFresnelParameters``: FunctionBinding_RegisterFresnelParameters = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/frontFacingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFrontFacingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFrontFacingBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/frontFacingBlock.pure.js")>]
    let ``RegisterFrontFacingBlock``: FunctionBinding_RegisterFrontFacingBlock = jsNative

    /// @babylonjs/core/PostProcesses/fxaaPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFxaaPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFxaaPostProcess", "@babylonjs/core/PostProcesses/fxaaPostProcess.pure.js")>]
    let ``RegisterFxaaPostProcess``: FunctionBinding_RegisterFxaaPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/fxaaPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterFxaaPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterFxaaPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/fxaaPostProcessBlock.pure.js")>]
    let ``RegisterFxaaPostProcessBlock``: FunctionBinding_RegisterFxaaPostProcessBlock = jsNative

    /// @babylonjs/core/Cameras/gamepadCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGamepadCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGamepadCamera", "@babylonjs/core/Cameras/gamepadCamera.pure.js")>]
    let ``RegisterGamepadCamera``: FunctionBinding_RegisterGamepadCamera = jsNative

    /// @babylonjs/core/Gamepads/gamepadSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGamepadSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``gamepadManagerClass``: BabylonjsBindings.SimpleClasses.GamepadManagerStatic -> unit

    [<Import("RegisterGamepadSceneComponent", "@babylonjs/core/Gamepads/gamepadSceneComponent.pure.js")>]
    let ``RegisterGamepadSceneComponent``: FunctionBinding_RegisterGamepadSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/GaussianSplatting/gaussianBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianBlock", "@babylonjs/core/Materials/Node/Blocks/GaussianSplatting/gaussianBlock.pure.js")>]
    let ``RegisterGaussianBlock``: FunctionBinding_RegisterGaussianBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/GaussianSplatting/gaussianSplattingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianSplattingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianSplattingBlock", "@babylonjs/core/Materials/Node/Blocks/GaussianSplatting/gaussianSplattingBlock.pure.js")>]
    let ``RegisterGaussianSplattingBlock``: FunctionBinding_RegisterGaussianSplattingBlock = jsNative

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingCompoundMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianSplattingCompoundMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianSplattingCompoundMesh", "@babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingCompoundMesh.pure.js")>]
    let ``RegisterGaussianSplattingCompoundMesh``: FunctionBinding_RegisterGaussianSplattingCompoundMesh = jsNative

    /// @babylonjs/core/Materials/GaussianSplatting/gaussianSplattingDebugMaterialPlugin.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianSplattingDebugMaterialPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianSplattingDebugMaterialPlugin", "@babylonjs/core/Materials/GaussianSplatting/gaussianSplattingDebugMaterialPlugin.pure.js")>]
    let ``RegisterGaussianSplattingDebugMaterialPlugin``: FunctionBinding_RegisterGaussianSplattingDebugMaterialPlugin = jsNative

    /// @babylonjs/core/Materials/GaussianSplatting/gaussianSplattingGpuPickingMaterialPlugin.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianSplattingGpuPickingMaterialPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianSplattingGpuPickingMaterialPlugin", "@babylonjs/core/Materials/GaussianSplatting/gaussianSplattingGpuPickingMaterialPlugin.pure.js")>]
    let ``RegisterGaussianSplattingGpuPickingMaterialPlugin``: FunctionBinding_RegisterGaussianSplattingGpuPickingMaterialPlugin = jsNative

    /// @babylonjs/core/Materials/GaussianSplatting/gaussianSplattingMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianSplattingMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianSplattingMaterial", "@babylonjs/core/Materials/GaussianSplatting/gaussianSplattingMaterial.pure.js")>]
    let ``RegisterGaussianSplattingMaterial``: FunctionBinding_RegisterGaussianSplattingMaterial = jsNative

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianSplattingMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianSplattingMesh", "@babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingMesh.pure.js")>]
    let ``RegisterGaussianSplattingMesh``: FunctionBinding_RegisterGaussianSplattingMesh = jsNative

    /// @babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingPartProxyMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianSplattingPartProxyMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianSplattingPartProxyMesh", "@babylonjs/core/Meshes/GaussianSplatting/gaussianSplattingPartProxyMesh.pure.js")>]
    let ``RegisterGaussianSplattingPartProxyMesh``: FunctionBinding_RegisterGaussianSplattingPartProxyMesh = jsNative

    /// @babylonjs/core/Materials/GaussianSplatting/gaussianSplattingSolidColorMaterialPlugin.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGaussianSplattingSolidColorMaterialPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGaussianSplattingSolidColorMaterialPlugin", "@babylonjs/core/Materials/GaussianSplatting/gaussianSplattingSolidColorMaterialPlugin.pure.js")>]
    let ``RegisterGaussianSplattingSolidColorMaterialPlugin``: FunctionBinding_RegisterGaussianSplattingSolidColorMaterialPlugin = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Textures/generateMipmapsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGenerateMipmapsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGenerateMipmapsBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Textures/generateMipmapsBlock.pure.js")>]
    let ``RegisterGenerateMipmapsBlock``: FunctionBinding_RegisterGenerateMipmapsBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryArcTan2Block.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryArcTan2Block =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryArcTan2Block", "@babylonjs/core/Meshes/Node/Blocks/geometryArcTan2Block.pure.js")>]
    let ``RegisterGeometryArcTan2Block``: FunctionBinding_RegisterGeometryArcTan2Block = jsNative

    /// @babylonjs/core/Rendering/geometryBufferRenderer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryBufferRenderer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryBufferRenderer", "@babylonjs/core/Rendering/geometryBufferRenderer.pure.js")>]
    let ``RegisterGeometryBufferRenderer``: FunctionBinding_RegisterGeometryBufferRenderer = jsNative

    /// @babylonjs/core/Rendering/geometryBufferRendererSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryBufferRendererSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``geometryBufferRendererClass``: BabylonjsBindings.SimpleClasses.GeometryBufferRendererStatic -> unit

    [<Import("RegisterGeometryBufferRendererSceneComponent", "@babylonjs/core/Rendering/geometryBufferRendererSceneComponent.pure.js")>]
    let ``RegisterGeometryBufferRendererSceneComponent``: FunctionBinding_RegisterGeometryBufferRendererSceneComponent = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryClampBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryClampBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryClampBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryClampBlock.pure.js")>]
    let ``RegisterGeometryClampBlock``: FunctionBinding_RegisterGeometryClampBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryCollectionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryCollectionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryCollectionBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryCollectionBlock.pure.js")>]
    let ``RegisterGeometryCollectionBlock``: FunctionBinding_RegisterGeometryCollectionBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryCrossBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryCrossBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryCrossBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryCrossBlock.pure.js")>]
    let ``RegisterGeometryCrossBlock``: FunctionBinding_RegisterGeometryCrossBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryCurveBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryCurveBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryCurveBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryCurveBlock.pure.js")>]
    let ``RegisterGeometryCurveBlock``: FunctionBinding_RegisterGeometryCurveBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryDesaturateBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryDesaturateBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryDesaturateBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryDesaturateBlock.pure.js")>]
    let ``RegisterGeometryDesaturateBlock``: FunctionBinding_RegisterGeometryDesaturateBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryDistanceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryDistanceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryDistanceBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryDistanceBlock.pure.js")>]
    let ``RegisterGeometryDistanceBlock``: FunctionBinding_RegisterGeometryDistanceBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryDotBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryDotBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryDotBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryDotBlock.pure.js")>]
    let ``RegisterGeometryDotBlock``: FunctionBinding_RegisterGeometryDotBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryEaseBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryEaseBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryEaseBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryEaseBlock.pure.js")>]
    let ``RegisterGeometryEaseBlock``: FunctionBinding_RegisterGeometryEaseBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryElbowBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryElbowBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryElbowBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryElbowBlock.pure.js")>]
    let ``RegisterGeometryElbowBlock``: FunctionBinding_RegisterGeometryElbowBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryInfoBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryInfoBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryInfoBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryInfoBlock.pure.js")>]
    let ``RegisterGeometryInfoBlock``: FunctionBinding_RegisterGeometryInfoBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryInputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryInputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryInputBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryInputBlock.pure.js")>]
    let ``RegisterGeometryInputBlock``: FunctionBinding_RegisterGeometryInputBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryInterceptorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryInterceptorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryInterceptorBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryInterceptorBlock.pure.js")>]
    let ``RegisterGeometryInterceptorBlock``: FunctionBinding_RegisterGeometryInterceptorBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryLengthBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryLengthBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryLengthBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryLengthBlock.pure.js")>]
    let ``RegisterGeometryLengthBlock``: FunctionBinding_RegisterGeometryLengthBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryLerpBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryLerpBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryLerpBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryLerpBlock.pure.js")>]
    let ``RegisterGeometryLerpBlock``: FunctionBinding_RegisterGeometryLerpBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryModBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryModBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryModBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryModBlock.pure.js")>]
    let ``RegisterGeometryModBlock``: FunctionBinding_RegisterGeometryModBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryNLerpBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryNLerpBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryNLerpBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryNLerpBlock.pure.js")>]
    let ``RegisterGeometryNLerpBlock``: FunctionBinding_RegisterGeometryNLerpBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryOptimizeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryOptimizeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryOptimizeBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryOptimizeBlock.pure.js")>]
    let ``RegisterGeometryOptimizeBlock``: FunctionBinding_RegisterGeometryOptimizeBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryOutputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryOutputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryOutputBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryOutputBlock.pure.js")>]
    let ``RegisterGeometryOutputBlock``: FunctionBinding_RegisterGeometryOutputBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryPosterizeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryPosterizeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryPosterizeBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryPosterizeBlock.pure.js")>]
    let ``RegisterGeometryPosterizeBlock``: FunctionBinding_RegisterGeometryPosterizeBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryPowBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryPowBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryPowBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryPowBlock.pure.js")>]
    let ``RegisterGeometryPowBlock``: FunctionBinding_RegisterGeometryPowBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Rendering/geometryRendererBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryRendererBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryRendererBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Rendering/geometryRendererBlock.pure.js")>]
    let ``RegisterGeometryRendererBlock``: FunctionBinding_RegisterGeometryRendererBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryReplaceColorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryReplaceColorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryReplaceColorBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryReplaceColorBlock.pure.js")>]
    let ``RegisterGeometryReplaceColorBlock``: FunctionBinding_RegisterGeometryReplaceColorBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryRotate2dBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryRotate2dBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryRotate2dBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryRotate2dBlock.pure.js")>]
    let ``RegisterGeometryRotate2dBlock``: FunctionBinding_RegisterGeometryRotate2dBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometrySmoothStepBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometrySmoothStepBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometrySmoothStepBlock", "@babylonjs/core/Meshes/Node/Blocks/geometrySmoothStepBlock.pure.js")>]
    let ``RegisterGeometrySmoothStepBlock``: FunctionBinding_RegisterGeometrySmoothStepBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryStepBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryStepBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryStepBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryStepBlock.pure.js")>]
    let ``RegisterGeometryStepBlock``: FunctionBinding_RegisterGeometryStepBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Textures/geometryTextureBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryTextureBlock", "@babylonjs/core/Meshes/Node/Blocks/Textures/geometryTextureBlock.pure.js")>]
    let ``RegisterGeometryTextureBlock``: FunctionBinding_RegisterGeometryTextureBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Textures/geometryTextureFetchBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryTextureFetchBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryTextureFetchBlock", "@babylonjs/core/Meshes/Node/Blocks/Textures/geometryTextureFetchBlock.pure.js")>]
    let ``RegisterGeometryTextureFetchBlock``: FunctionBinding_RegisterGeometryTextureFetchBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryTransformBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryTransformBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryTransformBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryTransformBlock.pure.js")>]
    let ``RegisterGeometryTransformBlock``: FunctionBinding_RegisterGeometryTransformBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/geometryTrigonometryBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeometryTrigonometryBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeometryTrigonometryBlock", "@babylonjs/core/Meshes/Node/Blocks/geometryTrigonometryBlock.pure.js")>]
    let ``RegisterGeometryTrigonometryBlock``: FunctionBinding_RegisterGeometryTrigonometryBlock = jsNative

    /// @babylonjs/core/Cameras/geospatialCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGeospatialCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGeospatialCamera", "@babylonjs/core/Cameras/geospatialCamera.pure.js")>]
    let ``RegisterGeospatialCamera``: FunctionBinding_RegisterGeospatialCamera = jsNative

    /// @babylonjs/core/Rendering/GlobalIllumination/giRSMManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGiRSMManager =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGiRSMManager", "@babylonjs/core/Rendering/GlobalIllumination/giRSMManager.pure.js")>]
    let ``RegisterGiRSMManager``: FunctionBinding_RegisterGiRSMManager = jsNative

    /// @babylonjs/core/Layers/glowLayer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGlowLayer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGlowLayer", "@babylonjs/core/Layers/glowLayer.pure.js")>]
    let ``RegisterGlowLayer``: FunctionBinding_RegisterGlowLayer = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Layers/glowLayerBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGlowLayerBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGlowLayerBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Layers/glowLayerBlock.pure.js")>]
    let ``RegisterGlowLayerBlock``: FunctionBinding_RegisterGlowLayerBlock = jsNative

    /// @babylonjs/loaders/glTF/2.0/glTFLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGLTF2Loader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGLTF2Loader", "@babylonjs/loaders/glTF/2.0/glTFLoader.pure.js")>]
    let ``RegisterGLTF2Loader``: FunctionBinding_RegisterGLTF2Loader = jsNative

    /// @babylonjs/loaders/glTF/glTFFileLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGLTFFileLoader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGLTFFileLoader", "@babylonjs/loaders/glTF/glTFFileLoader.pure.js")>]
    let ``RegisterGLTFFileLoader``: FunctionBinding_RegisterGLTFFileLoader = jsNative

    /// @babylonjs/core/Meshes/goldbergMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGoldbergMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGoldbergMesh", "@babylonjs/core/Meshes/goldbergMesh.pure.js")>]
    let ``RegisterGoldbergMesh``: FunctionBinding_RegisterGoldbergMesh = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/gradientBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGradientBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGradientBlock", "@babylonjs/core/Materials/Node/Blocks/gradientBlock.pure.js")>]
    let ``RegisterGradientBlock``: FunctionBinding_RegisterGradientBlock = jsNative

    /// @babylonjs/core/PostProcesses/grainPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGrainPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGrainPostProcess", "@babylonjs/core/PostProcesses/grainPostProcess.pure.js")>]
    let ``RegisterGrainPostProcess``: FunctionBinding_RegisterGrainPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/grainPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGrainPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGrainPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/grainPostProcessBlock.pure.js")>]
    let ``RegisterGrainPostProcessBlock``: FunctionBinding_RegisterGrainPostProcessBlock = jsNative

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGreasedLineMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGreasedLineMesh", "@babylonjs/core/Meshes/GreasedLine/greasedLineMesh.pure.js")>]
    let ``RegisterGreasedLineMesh``: FunctionBinding_RegisterGreasedLineMesh = jsNative

    /// @babylonjs/core/Materials/GreasedLine/greasedLinePluginMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGreasedLinePluginMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGreasedLinePluginMaterial", "@babylonjs/core/Materials/GreasedLine/greasedLinePluginMaterial.pure.js")>]
    let ``RegisterGreasedLinePluginMaterial``: FunctionBinding_RegisterGreasedLinePluginMaterial = jsNative

    /// @babylonjs/core/Meshes/GreasedLine/greasedLineRibbonMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGreasedLineRibbonMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGreasedLineRibbonMesh", "@babylonjs/core/Meshes/GreasedLine/greasedLineRibbonMesh.pure.js")>]
    let ``RegisterGreasedLineRibbonMesh``: FunctionBinding_RegisterGreasedLineRibbonMesh = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/gridBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGridBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGridBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/gridBlock.pure.js")>]
    let ``RegisterGridBlock``: FunctionBinding_RegisterGridBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/groundBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGroundBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGroundBuilder", "@babylonjs/core/Meshes/Builders/groundBuilder.pure.js")>]
    let ``RegisterGroundBuilder``: FunctionBinding_RegisterGroundBuilder = jsNative

    /// @babylonjs/core/Meshes/groundMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterGroundMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterGroundMesh", "@babylonjs/core/Meshes/groundMesh.pure.js")>]
    let ``RegisterGroundMesh``: FunctionBinding_RegisterGroundMesh = jsNative

    /// @babylonjs/core/Materials/Textures/hdrCubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterHdrCubeTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterHdrCubeTexture", "@babylonjs/core/Materials/Textures/hdrCubeTexture.pure.js")>]
    let ``RegisterHdrCubeTexture``: FunctionBinding_RegisterHdrCubeTexture = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/heightToNormalBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterHeightToNormalBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterHeightToNormalBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/heightToNormalBlock.pure.js")>]
    let ``RegisterHeightToNormalBlock``: FunctionBinding_RegisterHeightToNormalBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/hemisphereBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterHemisphereBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterHemisphereBuilder", "@babylonjs/core/Meshes/Builders/hemisphereBuilder.pure.js")>]
    let ``RegisterHemisphereBuilder``: FunctionBinding_RegisterHemisphereBuilder = jsNative

    /// @babylonjs/core/Lights/hemisphericLight.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterHemisphericLight =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterHemisphericLight", "@babylonjs/core/Lights/hemisphericLight.pure.js")>]
    let ``RegisterHemisphericLight``: FunctionBinding_RegisterHemisphericLight = jsNative

    /// @babylonjs/core/Layers/highlightLayer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterHighlightLayer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterHighlightLayer", "@babylonjs/core/Layers/highlightLayer.pure.js")>]
    let ``RegisterHighlightLayer``: FunctionBinding_RegisterHighlightLayer = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Layers/highlightLayerBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterHighlightLayerBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterHighlightLayerBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Layers/highlightLayerBlock.pure.js")>]
    let ``RegisterHighlightLayerBlock``: FunctionBinding_RegisterHighlightLayerBlock = jsNative

    /// @babylonjs/core/Rendering/iblCdfGeneratorSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterIblCdfGeneratorSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``iblCdfGeneratorClass``: BabylonjsBindings.SimpleClasses.IblCdfGeneratorStatic -> unit

    [<Import("RegisterIblCdfGeneratorSceneComponent", "@babylonjs/core/Rendering/iblCdfGeneratorSceneComponent.pure.js")>]
    let ``RegisterIblCdfGeneratorSceneComponent``: FunctionBinding_RegisterIblCdfGeneratorSceneComponent = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Rendering/iblShadowsRendererBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterIblShadowsRendererBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterIblShadowsRendererBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Rendering/iblShadowsRendererBlock.pure.js")>]
    let ``RegisterIblShadowsRendererBlock``: FunctionBinding_RegisterIblShadowsRendererBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/icoSphereBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterIcoSphereBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterIcoSphereBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/icoSphereBlock.pure.js")>]
    let ``RegisterIcoSphereBlock``: FunctionBinding_RegisterIcoSphereBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/icoSphereBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterIcoSphereBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterIcoSphereBuilder", "@babylonjs/core/Meshes/Builders/icoSphereBuilder.pure.js")>]
    let ``RegisterIcoSphereBuilder``: FunctionBinding_RegisterIcoSphereBuilder = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/imageProcessingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterImageProcessingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterImageProcessingBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/imageProcessingBlock.pure.js")>]
    let ``RegisterImageProcessingBlock``: FunctionBinding_RegisterImageProcessingBlock = jsNative

    /// @babylonjs/core/Materials/imageProcessingConfiguration.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterImageProcessingConfiguration =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterImageProcessingConfiguration", "@babylonjs/core/Materials/imageProcessingConfiguration.pure.js")>]
    let ``RegisterImageProcessingConfiguration``: FunctionBinding_RegisterImageProcessingConfiguration = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/imageProcessingPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterImageProcessingPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterImageProcessingPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/imageProcessingPostProcessBlock.pure.js")>]
    let ``RegisterImageProcessingPostProcessBlock``: FunctionBinding_RegisterImageProcessingPostProcessBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/imageSourceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterImageSourceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterImageSourceBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/imageSourceBlock.pure.js")>]
    let ``RegisterImageSourceBlock``: FunctionBinding_RegisterImageSourceBlock = jsNative

    /// @babylonjs/core/Meshes/instancedMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInstancedMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInstancedMesh", "@babylonjs/core/Meshes/instancedMesh.pure.js")>]
    let ``RegisterInstancedMesh``: FunctionBinding_RegisterInstancedMesh = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Vertex/instancesBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInstancesBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInstancesBlock", "@babylonjs/core/Materials/Node/Blocks/Vertex/instancesBlock.pure.js")>]
    let ``RegisterInstancesBlock``: FunctionBinding_RegisterInstancesBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Instances/instantiateBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInstantiateBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInstantiateBlock", "@babylonjs/core/Meshes/Node/Blocks/Instances/instantiateBlock.pure.js")>]
    let ``RegisterInstantiateBlock``: FunctionBinding_RegisterInstantiateBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Instances/instantiateLinearBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInstantiateLinearBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInstantiateLinearBlock", "@babylonjs/core/Meshes/Node/Blocks/Instances/instantiateLinearBlock.pure.js")>]
    let ``RegisterInstantiateLinearBlock``: FunctionBinding_RegisterInstantiateLinearBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Instances/instantiateOnFacesBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInstantiateOnFacesBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInstantiateOnFacesBlock", "@babylonjs/core/Meshes/Node/Blocks/Instances/instantiateOnFacesBlock.pure.js")>]
    let ``RegisterInstantiateOnFacesBlock``: FunctionBinding_RegisterInstantiateOnFacesBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Instances/instantiateOnVerticesBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInstantiateOnVerticesBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInstantiateOnVerticesBlock", "@babylonjs/core/Meshes/Node/Blocks/Instances/instantiateOnVerticesBlock.pure.js")>]
    let ``RegisterInstantiateOnVerticesBlock``: FunctionBinding_RegisterInstantiateOnVerticesBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Instances/instantiateOnVolumeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInstantiateOnVolumeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInstantiateOnVolumeBlock", "@babylonjs/core/Meshes/Node/Blocks/Instances/instantiateOnVolumeBlock.pure.js")>]
    let ``RegisterInstantiateOnVolumeBlock``: FunctionBinding_RegisterInstantiateOnVolumeBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Instances/instantiateRadialBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInstantiateRadialBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInstantiateRadialBlock", "@babylonjs/core/Meshes/Node/Blocks/Instances/instantiateRadialBlock.pure.js")>]
    let ``RegisterInstantiateRadialBlock``: FunctionBinding_RegisterInstantiateRadialBlock = jsNative

    /// @babylonjs/core/Actions/interpolateValueAction.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterInterpolateValueAction =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterInterpolateValueAction", "@babylonjs/core/Actions/interpolateValueAction.pure.js")>]
    let ``RegisterInterpolateValueAction``: FunctionBinding_RegisterInterpolateValueAction = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/intFloatConverterBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterIntFloatConverterBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterIntFloatConverterBlock", "@babylonjs/core/Meshes/Node/Blocks/intFloatConverterBlock.pure.js")>]
    let ``RegisterIntFloatConverterBlock``: FunctionBinding_RegisterIntFloatConverterBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/PBR/iridescenceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterIridescenceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterIridescenceBlock", "@babylonjs/core/Materials/Node/Blocks/PBR/iridescenceBlock.pure.js")>]
    let ``RegisterIridescenceBlock``: FunctionBinding_RegisterIridescenceBlock = jsNative

    /// @babylonjs/core/Physics/joinedPhysicsEngineComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterJoinedPhysicsEngineComponent =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterJoinedPhysicsEngineComponent", "@babylonjs/core/Physics/joinedPhysicsEngineComponent.pure.js")>]
    let ``RegisterJoinedPhysicsEngineComponent``: FunctionBinding_RegisterJoinedPhysicsEngineComponent = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_animation_pointer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_animation_pointer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_animation_pointer", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_animation_pointer.pure.js")>]
    let ``RegisterKHR_animation_pointer``: FunctionBinding_RegisterKHR_animation_pointer = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_draco_mesh_compression.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_draco_mesh_compression =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_draco_mesh_compression", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_draco_mesh_compression.pure.js")>]
    let ``RegisterKHR_draco_mesh_compression``: FunctionBinding_RegisterKHR_draco_mesh_compression = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_gaussian_splatting.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_gaussian_splatting =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_gaussian_splatting", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_gaussian_splatting.pure.js")>]
    let ``RegisterKHR_gaussian_splatting``: FunctionBinding_RegisterKHR_gaussian_splatting = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_interactivity =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_interactivity", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_interactivity.pure.js")>]
    let ``RegisterKHR_interactivity``: FunctionBinding_RegisterKHR_interactivity = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_lights_punctual.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_lights =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_lights", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_lights_punctual.pure.js")>]
    let ``RegisterKHR_lights``: FunctionBinding_RegisterKHR_lights = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_anisotropy.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_anisotropy =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_anisotropy", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_anisotropy.pure.js")>]
    let ``RegisterKHR_materials_anisotropy``: FunctionBinding_RegisterKHR_materials_anisotropy = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_clearcoat.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_clearcoat =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_clearcoat", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_clearcoat.pure.js")>]
    let ``RegisterKHR_materials_clearcoat``: FunctionBinding_RegisterKHR_materials_clearcoat = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_coat.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_coat =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_coat", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_coat.pure.js")>]
    let ``RegisterKHR_materials_coat``: FunctionBinding_RegisterKHR_materials_coat = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_diffuse_roughness.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_diffuse_roughness =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_diffuse_roughness", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_diffuse_roughness.pure.js")>]
    let ``RegisterKHR_materials_diffuse_roughness``: FunctionBinding_RegisterKHR_materials_diffuse_roughness = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_diffuse_transmission.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_diffuse_transmission =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_diffuse_transmission", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_diffuse_transmission.pure.js")>]
    let ``RegisterKHR_materials_diffuse_transmission``: FunctionBinding_RegisterKHR_materials_diffuse_transmission = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_dispersion.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_dispersion =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_dispersion", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_dispersion.pure.js")>]
    let ``RegisterKHR_materials_dispersion``: FunctionBinding_RegisterKHR_materials_dispersion = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_emissive_strength.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_emissive_strength =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_emissive_strength", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_emissive_strength.pure.js")>]
    let ``RegisterKHR_materials_emissive_strength``: FunctionBinding_RegisterKHR_materials_emissive_strength = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_fuzz.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_fuzz =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_fuzz", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_fuzz.pure.js")>]
    let ``RegisterKHR_materials_fuzz``: FunctionBinding_RegisterKHR_materials_fuzz = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_ior.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_ior =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_ior", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_ior.pure.js")>]
    let ``RegisterKHR_materials_ior``: FunctionBinding_RegisterKHR_materials_ior = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_iridescence.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_iridescence =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_iridescence", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_iridescence.pure.js")>]
    let ``RegisterKHR_materials_iridescence``: FunctionBinding_RegisterKHR_materials_iridescence = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_pbrSpecularGlossiness.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_pbrSpecularGlossiness =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_pbrSpecularGlossiness", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_pbrSpecularGlossiness.pure.js")>]
    let ``RegisterKHR_materials_pbrSpecularGlossiness``: FunctionBinding_RegisterKHR_materials_pbrSpecularGlossiness = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_sheen.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_sheen =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_sheen", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_sheen.pure.js")>]
    let ``RegisterKHR_materials_sheen``: FunctionBinding_RegisterKHR_materials_sheen = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_specular.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_specular =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_specular", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_specular.pure.js")>]
    let ``RegisterKHR_materials_specular``: FunctionBinding_RegisterKHR_materials_specular = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_transmission.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_transmission =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_transmission", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_transmission.pure.js")>]
    let ``RegisterKHR_materials_transmission``: FunctionBinding_RegisterKHR_materials_transmission = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_unlit.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_unlit =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_unlit", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_unlit.pure.js")>]
    let ``RegisterKHR_materials_unlit``: FunctionBinding_RegisterKHR_materials_unlit = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_variants.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_variants =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_variants", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_variants.pure.js")>]
    let ``RegisterKHR_materials_variants``: FunctionBinding_RegisterKHR_materials_variants = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_volume.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_volume =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_volume", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_volume.pure.js")>]
    let ``RegisterKHR_materials_volume``: FunctionBinding_RegisterKHR_materials_volume = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_volume_scatter.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_materials_volume_scatter =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_materials_volume_scatter", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_materials_volume_scatter.pure.js")>]
    let ``RegisterKHR_materials_volume_scatter``: FunctionBinding_RegisterKHR_materials_volume_scatter = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_mesh_quantization.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_mesh_quantization =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_mesh_quantization", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_mesh_quantization.pure.js")>]
    let ``RegisterKHR_mesh_quantization``: FunctionBinding_RegisterKHR_mesh_quantization = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_node_hoverability.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_node_hoverability =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_node_hoverability", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_node_hoverability.pure.js")>]
    let ``RegisterKHR_node_hoverability``: FunctionBinding_RegisterKHR_node_hoverability = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_node_selectability.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_node_selectability =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_node_selectability", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_node_selectability.pure.js")>]
    let ``RegisterKHR_node_selectability``: FunctionBinding_RegisterKHR_node_selectability = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_node_visibility.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_node_visibility =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_node_visibility", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_node_visibility.pure.js")>]
    let ``RegisterKHR_node_visibility``: FunctionBinding_RegisterKHR_node_visibility = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_texture_basisu.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_texture_basisu =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_texture_basisu", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_texture_basisu.pure.js")>]
    let ``RegisterKHR_texture_basisu``: FunctionBinding_RegisterKHR_texture_basisu = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_texture_transform.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_texture_transform =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_texture_transform", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_texture_transform.pure.js")>]
    let ``RegisterKHR_texture_transform``: FunctionBinding_RegisterKHR_texture_transform = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/KHR_xmp_json_ld.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterKHR_xmp_json_ld =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterKHR_xmp_json_ld", "@babylonjs/loaders/glTF/2.0/Extensions/KHR_xmp_json_ld.pure.js")>]
    let ``RegisterKHR_xmp_json_ld``: FunctionBinding_RegisterKHR_xmp_json_ld = jsNative

    /// @babylonjs/core/Meshes/Builders/latheBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLatheBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLatheBuilder", "@babylonjs/core/Meshes/Builders/latheBuilder.pure.js")>]
    let ``RegisterLatheBuilder``: FunctionBinding_RegisterLatheBuilder = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Set/latticeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLatticeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLatticeBlock", "@babylonjs/core/Meshes/Node/Blocks/Set/latticeBlock.pure.js")>]
    let ``RegisterLatticeBlock``: FunctionBinding_RegisterLatticeBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/lengthBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLengthBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLengthBlock", "@babylonjs/core/Materials/Node/Blocks/lengthBlock.pure.js")>]
    let ``RegisterLengthBlock``: FunctionBinding_RegisterLengthBlock = jsNative

    /// @babylonjs/core/LensFlares/lensFlareSystemSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLensFlareSystemSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``lensFlareSystemClass``: BabylonjsBindings.SimpleClasses.LensFlareSystemStatic -> unit

    [<Import("RegisterLensFlareSystemSceneComponent", "@babylonjs/core/LensFlares/lensFlareSystemSceneComponent.pure.js")>]
    let ``RegisterLensFlareSystemSceneComponent``: FunctionBinding_RegisterLensFlareSystemSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/lerpBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLerpBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLerpBlock", "@babylonjs/core/Materials/Node/Blocks/lerpBlock.pure.js")>]
    let ``RegisterLerpBlock``: FunctionBinding_RegisterLerpBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/lightBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLightBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLightBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/lightBlock.pure.js")>]
    let ``RegisterLightBlock``: FunctionBinding_RegisterLightBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Vertex/lightInformationBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLightInformationBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLightInformationBlock", "@babylonjs/core/Materials/Node/Blocks/Vertex/lightInformationBlock.pure.js")>]
    let ``RegisterLightInformationBlock``: FunctionBinding_RegisterLightInformationBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/lightingVolumeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLightingVolumeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLightingVolumeBlock", "@babylonjs/core/FrameGraph/Node/Blocks/lightingVolumeBlock.pure.js")>]
    let ``RegisterLightingVolumeBlock``: FunctionBinding_RegisterLightingVolumeBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/linesBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLinesBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLinesBuilder", "@babylonjs/core/Meshes/Builders/linesBuilder.pure.js")>]
    let ``RegisterLinesBuilder``: FunctionBinding_RegisterLinesBuilder = jsNative

    /// @babylonjs/core/Meshes/linesMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLinesMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLinesMesh", "@babylonjs/core/Meshes/linesMesh.pure.js")>]
    let ``RegisterLinesMesh``: FunctionBinding_RegisterLinesMesh = jsNative

    /// @babylonjs/core/Loading/loadingScreen.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLoadingScreen =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLoadingScreen", "@babylonjs/core/Loading/loadingScreen.pure.js")>]
    let ``RegisterLoadingScreen``: FunctionBinding_RegisterLoadingScreen = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/loopBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterLoopBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterLoopBlock", "@babylonjs/core/Materials/Node/Blocks/loopBlock.pure.js")>]
    let ``RegisterLoopBlock``: FunctionBinding_RegisterLoopBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/mappingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMappingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMappingBlock", "@babylonjs/core/Meshes/Node/Blocks/mappingBlock.pure.js")>]
    let ``RegisterMappingBlock``: FunctionBinding_RegisterMappingBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/mapRangeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMapRangeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMapRangeBlock", "@babylonjs/core/Meshes/Node/Blocks/mapRangeBlock.pure.js")>]
    let ``RegisterMapRangeBlock``: FunctionBinding_RegisterMapRangeBlock = jsNative

    /// @babylonjs/core/Materials/material.decalMapConfiguration.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialDecalMapConfiguration =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaterialDecalMapConfiguration", "@babylonjs/core/Materials/material.decalMapConfiguration.pure.js")>]
    let ``RegisterMaterialDecalMapConfiguration``: FunctionBinding_RegisterMaterialDecalMapConfiguration = jsNative

    /// @babylonjs/core/Materials/materialPluginManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``pluginName``: string * ``factory``: BabylonjsBindings.TypeAliases.PluginMaterialFactory -> unit

    [<Import("RegisterMaterialPlugin", "@babylonjs/core/Materials/materialPluginManager.pure.js")>]
    let ``RegisterMaterialPlugin``: FunctionBinding_RegisterMaterialPlugin = jsNative

    /// @babylonjs/core/Materials/materialPluginBase.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialPluginBase =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaterialPluginBase", "@babylonjs/core/Materials/materialPluginBase.pure.js")>]
    let ``RegisterMaterialPluginBase``: FunctionBinding_RegisterMaterialPluginBase = jsNative

    /// @babylonjs/core/Materials/materialPluginManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialPluginManager =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaterialPluginManager", "@babylonjs/core/Materials/materialPluginManager.pure.js")>]
    let ``RegisterMaterialPluginManager``: FunctionBinding_RegisterMaterialPluginManager = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/debugBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialsNodeBlocksDebugBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaterialsNodeBlocksDebugBlock", "@babylonjs/core/Materials/Node/Blocks/debugBlock.pure.js")>]
    let ``RegisterMaterialsNodeBlocksDebugBlock``: FunctionBinding_RegisterMaterialsNodeBlocksDebugBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/elbowBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialsNodeBlocksElbowBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaterialsNodeBlocksElbowBlock", "@babylonjs/core/Materials/Node/Blocks/elbowBlock.pure.js")>]
    let ``RegisterMaterialsNodeBlocksElbowBlock``: FunctionBinding_RegisterMaterialsNodeBlocksElbowBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Input/inputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialsNodeBlocksInputInputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaterialsNodeBlocksInputInputBlock", "@babylonjs/core/Materials/Node/Blocks/Input/inputBlock.pure.js")>]
    let ``RegisterMaterialsNodeBlocksInputInputBlock``: FunctionBinding_RegisterMaterialsNodeBlocksInputInputBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Teleport/teleportInBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialsNodeBlocksTeleportTeleportInBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaterialsNodeBlocksTeleportTeleportInBlock", "@babylonjs/core/Materials/Node/Blocks/Teleport/teleportInBlock.pure.js")>]
    let ``RegisterMaterialsNodeBlocksTeleportTeleportInBlock``: FunctionBinding_RegisterMaterialsNodeBlocksTeleportTeleportInBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Teleport/teleportOutBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaterialsNodeBlocksTeleportTeleportOutBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaterialsNodeBlocksTeleportTeleportOutBlock", "@babylonjs/core/Materials/Node/Blocks/Teleport/teleportOutBlock.pure.js")>]
    let ``RegisterMaterialsNodeBlocksTeleportTeleportOutBlock``: FunctionBinding_RegisterMaterialsNodeBlocksTeleportTeleportOutBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/mathBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMathBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMathBlock", "@babylonjs/core/Meshes/Node/Blocks/mathBlock.pure.js")>]
    let ``RegisterMathBlock``: FunctionBinding_RegisterMathBlock = jsNative

    /// @babylonjs/core/Maths/math.color.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMathColor =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMathColor", "@babylonjs/core/Maths/math.color.pure.js")>]
    let ``RegisterMathColor``: FunctionBinding_RegisterMathColor = jsNative

    /// @babylonjs/core/Maths/math.vector.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMathVector =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMathVector", "@babylonjs/core/Maths/math.vector.pure.js")>]
    let ``RegisterMathVector``: FunctionBinding_RegisterMathVector = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/matrixBuilderBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMatrixBuilderBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMatrixBuilderBlock", "@babylonjs/core/Materials/Node/Blocks/matrixBuilderBlock.pure.js")>]
    let ``RegisterMatrixBuilderBlock``: FunctionBinding_RegisterMatrixBuilderBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/matrixComposeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMatrixComposeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMatrixComposeBlock", "@babylonjs/core/Meshes/Node/Blocks/matrixComposeBlock.pure.js")>]
    let ``RegisterMatrixComposeBlock``: FunctionBinding_RegisterMatrixComposeBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/matrixDeterminantBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMatrixDeterminantBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMatrixDeterminantBlock", "@babylonjs/core/Materials/Node/Blocks/matrixDeterminantBlock.pure.js")>]
    let ``RegisterMatrixDeterminantBlock``: FunctionBinding_RegisterMatrixDeterminantBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/matrixSplitterBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMatrixSplitterBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMatrixSplitterBlock", "@babylonjs/core/Materials/Node/Blocks/matrixSplitterBlock.pure.js")>]
    let ``RegisterMatrixSplitterBlock``: FunctionBinding_RegisterMatrixSplitterBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/matrixTransposeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMatrixTransposeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMatrixTransposeBlock", "@babylonjs/core/Materials/Node/Blocks/matrixTransposeBlock.pure.js")>]
    let ``RegisterMatrixTransposeBlock``: FunctionBinding_RegisterMatrixTransposeBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/maxBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMaxBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMaxBlock", "@babylonjs/core/Materials/Node/Blocks/maxBlock.pure.js")>]
    let ``RegisterMaxBlock``: FunctionBinding_RegisterMaxBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/mergeGeometryBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMergeGeometryBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMergeGeometryBlock", "@babylonjs/core/Meshes/Node/Blocks/mergeGeometryBlock.pure.js")>]
    let ``RegisterMergeGeometryBlock``: FunctionBinding_RegisterMergeGeometryBlock = jsNative

    /// @babylonjs/core/Meshes/mesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMesh", "@babylonjs/core/Meshes/mesh.pure.js")>]
    let ``RegisterMesh``: FunctionBinding_RegisterMesh = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/meshAttributeExistsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMeshAttributeExistsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMeshAttributeExistsBlock", "@babylonjs/core/Materials/Node/Blocks/meshAttributeExistsBlock.pure.js")>]
    let ``RegisterMeshAttributeExistsBlock``: FunctionBinding_RegisterMeshAttributeExistsBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/meshBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMeshBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMeshBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/meshBlock.pure.js")>]
    let ``RegisterMeshBlock``: FunctionBinding_RegisterMeshBlock = jsNative

    /// @babylonjs/core/Materials/meshDebugPluginMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMeshDebugPluginMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMeshDebugPluginMaterial", "@babylonjs/core/Materials/meshDebugPluginMaterial.pure.js")>]
    let ``RegisterMeshDebugPluginMaterial``: FunctionBinding_RegisterMeshDebugPluginMaterial = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/debugBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMeshesNodeBlocksDebugBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMeshesNodeBlocksDebugBlock", "@babylonjs/core/Meshes/Node/Blocks/debugBlock.pure.js")>]
    let ``RegisterMeshesNodeBlocksDebugBlock``: FunctionBinding_RegisterMeshesNodeBlocksDebugBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Teleport/teleportInBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMeshesNodeBlocksTeleportTeleportInBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMeshesNodeBlocksTeleportTeleportInBlock", "@babylonjs/core/Meshes/Node/Blocks/Teleport/teleportInBlock.pure.js")>]
    let ``RegisterMeshesNodeBlocksTeleportTeleportInBlock``: FunctionBinding_RegisterMeshesNodeBlocksTeleportTeleportInBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Teleport/teleportOutBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMeshesNodeBlocksTeleportTeleportOutBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMeshesNodeBlocksTeleportTeleportOutBlock", "@babylonjs/core/Meshes/Node/Blocks/Teleport/teleportOutBlock.pure.js")>]
    let ``RegisterMeshesNodeBlocksTeleportTeleportOutBlock``: FunctionBinding_RegisterMeshesNodeBlocksTeleportTeleportOutBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/meshShapeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMeshShapeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMeshShapeBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/meshShapeBlock.pure.js")>]
    let ``RegisterMeshShapeBlock``: FunctionBinding_RegisterMeshShapeBlock = jsNative

    /// @babylonjs/core/Meshes/meshSimplificationSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMeshSimplificationSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``simplificationQueueClass``: BabylonjsBindings.SimpleClasses.SimplificationQueueStatic -> unit

    [<Import("RegisterMeshSimplificationSceneComponent", "@babylonjs/core/Meshes/meshSimplificationSceneComponent.pure.js")>]
    let ``RegisterMeshSimplificationSceneComponent``: FunctionBinding_RegisterMeshSimplificationSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/minBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMinBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMinBlock", "@babylonjs/core/Materials/Node/Blocks/minBlock.pure.js")>]
    let ``RegisterMinBlock``: FunctionBinding_RegisterMinBlock = jsNative

    /// @babylonjs/core/Materials/Textures/mirrorTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMirrorTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMirrorTexture", "@babylonjs/core/Materials/Textures/mirrorTexture.pure.js")>]
    let ``RegisterMirrorTexture``: FunctionBinding_RegisterMirrorTexture = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/modBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterModBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterModBlock", "@babylonjs/core/Materials/Node/Blocks/modBlock.pure.js")>]
    let ``RegisterModBlock``: FunctionBinding_RegisterModBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Vertex/morphTargetsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMorphTargetsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMorphTargetsBlock", "@babylonjs/core/Materials/Node/Blocks/Vertex/morphTargetsBlock.pure.js")>]
    let ``RegisterMorphTargetsBlock``: FunctionBinding_RegisterMorphTargetsBlock = jsNative

    /// @babylonjs/core/PostProcesses/motionBlurPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMotionBlurPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMotionBlurPostProcess", "@babylonjs/core/PostProcesses/motionBlurPostProcess.pure.js")>]
    let ``RegisterMotionBlurPostProcess``: FunctionBinding_RegisterMotionBlurPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/motionBlurPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMotionBlurPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMotionBlurPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/motionBlurPostProcessBlock.pure.js")>]
    let ``RegisterMotionBlurPostProcessBlock``: FunctionBinding_RegisterMotionBlurPostProcessBlock = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/MSFT_audio_emitter.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMSFT_audio_emitter =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMSFT_audio_emitter", "@babylonjs/loaders/glTF/2.0/Extensions/MSFT_audio_emitter.pure.js")>]
    let ``RegisterMSFT_audio_emitter``: FunctionBinding_RegisterMSFT_audio_emitter = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/MSFT_lod.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMSFT_lod =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMSFT_lod", "@babylonjs/loaders/glTF/2.0/Extensions/MSFT_lod.pure.js")>]
    let ``RegisterMSFT_lod``: FunctionBinding_RegisterMSFT_lod = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/MSFT_minecraftMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMSFT_minecraftMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMSFT_minecraftMesh", "@babylonjs/loaders/glTF/2.0/Extensions/MSFT_minecraftMesh.pure.js")>]
    let ``RegisterMSFT_minecraftMesh``: FunctionBinding_RegisterMSFT_minecraftMesh = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/MSFT_sRGBFactors.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMSFT_sRGBFactors =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMSFT_sRGBFactors", "@babylonjs/loaders/glTF/2.0/Extensions/MSFT_sRGBFactors.pure.js")>]
    let ``RegisterMSFT_sRGBFactors``: FunctionBinding_RegisterMSFT_sRGBFactors = jsNative

    /// @babylonjs/core/Materials/multiMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMultiMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMultiMaterial", "@babylonjs/core/Materials/multiMaterial.pure.js")>]
    let ``RegisterMultiMaterial``: FunctionBinding_RegisterMultiMaterial = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/multiplyBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterMultiplyBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterMultiplyBlock", "@babylonjs/core/Materials/Node/Blocks/multiplyBlock.pure.js")>]
    let ``RegisterMultiplyBlock``: FunctionBinding_RegisterMultiplyBlock = jsNative

    /// @babylonjs/core/Engines/nativeEngine.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNativeEngine =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNativeEngine", "@babylonjs/core/Engines/nativeEngine.pure.js")>]
    let ``RegisterNativeEngine``: FunctionBinding_RegisterNativeEngine = jsNative

    /// @babylonjs/core/Engines/Native/Extensions/nativeEngine.cubeTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNativeEngineCubeTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNativeEngineCubeTexture", "@babylonjs/core/Engines/Native/Extensions/nativeEngine.cubeTexture.pure.js")>]
    let ``RegisterNativeEngineCubeTexture``: FunctionBinding_RegisterNativeEngineCubeTexture = jsNative

    /// @babylonjs/core/Engines/thinNativeEngine.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNativeTypeAsync =
        [<Emit("$0($1...)")>] abstract Invoke<'Type>: ``typeName``: string * ``constructor``: 'Type -> JS.Promise<unit>

    [<Import("RegisterNativeTypeAsync", "@babylonjs/core/Engines/thinNativeEngine.pure.js")>]
    let ``RegisterNativeTypeAsync``: FunctionBinding_RegisterNativeTypeAsync = jsNative

    /// @babylonjs/core/XR/native/nativeXRFrame.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNativeXRFrame =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNativeXRFrame", "@babylonjs/core/XR/native/nativeXRFrame.pure.js")>]
    let ``RegisterNativeXRFrame``: FunctionBinding_RegisterNativeXRFrame = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/negateBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNegateBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNegateBlock", "@babylonjs/core/Materials/Node/Blocks/negateBlock.pure.js")>]
    let ``RegisterNegateBlock``: FunctionBinding_RegisterNegateBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/nLerpBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNLerpBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNLerpBlock", "@babylonjs/core/Materials/Node/Blocks/nLerpBlock.pure.js")>]
    let ``RegisterNLerpBlock``: FunctionBinding_RegisterNLerpBlock = jsNative

    /// @babylonjs/core/Materials/Node/nodeMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNodeMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNodeMaterial", "@babylonjs/core/Materials/Node/nodeMaterial.pure.js")>]
    let ``RegisterNodeMaterial``: FunctionBinding_RegisterNodeMaterial = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/noiseBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNoiseBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNoiseBlock", "@babylonjs/core/Meshes/Node/Blocks/noiseBlock.pure.js")>]
    let ``RegisterNoiseBlock``: FunctionBinding_RegisterNoiseBlock = jsNative

    /// @babylonjs/core/Materials/Textures/Procedurals/noiseProceduralTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNoiseProceduralTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNoiseProceduralTexture", "@babylonjs/core/Materials/Textures/Procedurals/noiseProceduralTexture.pure.js")>]
    let ``RegisterNoiseProceduralTexture``: FunctionBinding_RegisterNoiseProceduralTexture = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/normalBlendBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNormalBlendBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNormalBlendBlock", "@babylonjs/core/Materials/Node/Blocks/normalBlendBlock.pure.js")>]
    let ``RegisterNormalBlendBlock``: FunctionBinding_RegisterNormalBlendBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/normalizeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNormalizeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNormalizeBlock", "@babylonjs/core/Materials/Node/Blocks/normalizeBlock.pure.js")>]
    let ``RegisterNormalizeBlock``: FunctionBinding_RegisterNormalizeBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/normalizeVectorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNormalizeVectorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNormalizeVectorBlock", "@babylonjs/core/Meshes/Node/Blocks/normalizeVectorBlock.pure.js")>]
    let ``RegisterNormalizeVectorBlock``: FunctionBinding_RegisterNormalizeVectorBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/nullBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterNullBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterNullBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/nullBlock.pure.js")>]
    let ``RegisterNullBlock``: FunctionBinding_RegisterNullBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Rendering/objectRendererBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterObjectRendererBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterObjectRendererBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Rendering/objectRendererBlock.pure.js")>]
    let ``RegisterObjectRendererBlock``: FunctionBinding_RegisterObjectRendererBlock = jsNative

    /// @babylonjs/loaders/OBJ/objFileLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterOBJFileLoader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterOBJFileLoader", "@babylonjs/loaders/OBJ/objFileLoader.pure.js")>]
    let ``RegisterOBJFileLoader``: FunctionBinding_RegisterOBJFileLoader = jsNative

    /// @babylonjs/core/Misc/observableCoroutine.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterObservableCoroutine =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterObservableCoroutine", "@babylonjs/core/Misc/observableCoroutine.pure.js")>]
    let ``RegisterObservableCoroutine``: FunctionBinding_RegisterObservableCoroutine = jsNative

    /// @babylonjs/core/Misc/observable.extensions.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterObservableExtensions =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterObservableExtensions", "@babylonjs/core/Misc/observable.extensions.pure.js")>]
    let ``RegisterObservableExtensions``: FunctionBinding_RegisterObservableExtensions = jsNative

    /// @babylonjs/core/Culling/Octrees/octreeSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterOctreeSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterOctreeSceneComponent", "@babylonjs/core/Culling/Octrees/octreeSceneComponent.pure.js")>]
    let ``RegisterOctreeSceneComponent``: FunctionBinding_RegisterOctreeSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/oneMinusBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterOneMinusBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterOneMinusBlock", "@babylonjs/core/Materials/Node/Blocks/oneMinusBlock.pure.js")>]
    let ``RegisterOneMinusBlock``: FunctionBinding_RegisterOneMinusBlock = jsNative

    /// @babylonjs/core/Materials/PBR/openpbrMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterOpenpbrMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterOpenpbrMaterial", "@babylonjs/core/Materials/PBR/openpbrMaterial.pure.js")>]
    let ``RegisterOpenpbrMaterial``: FunctionBinding_RegisterOpenpbrMaterial = jsNative

    /// @babylonjs/core/Rendering/outlineRenderer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterOutlineRenderer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterOutlineRenderer", "@babylonjs/core/Rendering/outlineRenderer.pure.js")>]
    let ``RegisterOutlineRenderer``: FunctionBinding_RegisterOutlineRenderer = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/outputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterOutputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterOutputBlock", "@babylonjs/core/FrameGraph/Node/Blocks/outputBlock.pure.js")>]
    let ``RegisterOutputBlock``: FunctionBinding_RegisterOutputBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/pannerBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPannerBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPannerBlock", "@babylonjs/core/Materials/Node/Blocks/pannerBlock.pure.js")>]
    let ``RegisterPannerBlock``: FunctionBinding_RegisterPannerBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Particle/particleBlendMultiplyBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleBlendMultiplyBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleBlendMultiplyBlock", "@babylonjs/core/Materials/Node/Blocks/Particle/particleBlendMultiplyBlock.pure.js")>]
    let ``RegisterParticleBlendMultiplyBlock``: FunctionBinding_RegisterParticleBlendMultiplyBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleClampBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleClampBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleClampBlock", "@babylonjs/core/Particles/Node/Blocks/particleClampBlock.pure.js")>]
    let ``RegisterParticleClampBlock``: FunctionBinding_RegisterParticleClampBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Conditions/particleConditionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleConditionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleConditionBlock", "@babylonjs/core/Particles/Node/Blocks/Conditions/particleConditionBlock.pure.js")>]
    let ``RegisterParticleConditionBlock``: FunctionBinding_RegisterParticleConditionBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleConverterBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleConverterBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleConverterBlock", "@babylonjs/core/Particles/Node/Blocks/particleConverterBlock.pure.js")>]
    let ``RegisterParticleConverterBlock``: FunctionBinding_RegisterParticleConverterBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleDebugBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleDebugBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleDebugBlock", "@babylonjs/core/Particles/Node/Blocks/particleDebugBlock.pure.js")>]
    let ``RegisterParticleDebugBlock``: FunctionBinding_RegisterParticleDebugBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleElbowBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleElbowBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleElbowBlock", "@babylonjs/core/Particles/Node/Blocks/particleElbowBlock.pure.js")>]
    let ``RegisterParticleElbowBlock``: FunctionBinding_RegisterParticleElbowBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleFloatToIntBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleFloatToIntBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleFloatToIntBlock", "@babylonjs/core/Particles/Node/Blocks/particleFloatToIntBlock.pure.js")>]
    let ``RegisterParticleFloatToIntBlock``: FunctionBinding_RegisterParticleFloatToIntBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleGradientBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleGradientBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleGradientBlock", "@babylonjs/core/Particles/Node/Blocks/particleGradientBlock.pure.js")>]
    let ``RegisterParticleGradientBlock``: FunctionBinding_RegisterParticleGradientBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleGradientValueBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleGradientValueBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleGradientValueBlock", "@babylonjs/core/Particles/Node/Blocks/particleGradientValueBlock.pure.js")>]
    let ``RegisterParticleGradientValueBlock``: FunctionBinding_RegisterParticleGradientValueBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleInputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleInputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleInputBlock", "@babylonjs/core/Particles/Node/Blocks/particleInputBlock.pure.js")>]
    let ``RegisterParticleInputBlock``: FunctionBinding_RegisterParticleInputBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleLerpBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleLerpBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleLerpBlock", "@babylonjs/core/Particles/Node/Blocks/particleLerpBlock.pure.js")>]
    let ``RegisterParticleLerpBlock``: FunctionBinding_RegisterParticleLerpBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleLocalVariableBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleLocalVariableBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleLocalVariableBlock", "@babylonjs/core/Particles/Node/Blocks/particleLocalVariableBlock.pure.js")>]
    let ``RegisterParticleLocalVariableBlock``: FunctionBinding_RegisterParticleLocalVariableBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleMathBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleMathBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleMathBlock", "@babylonjs/core/Particles/Node/Blocks/particleMathBlock.pure.js")>]
    let ``RegisterParticleMathBlock``: FunctionBinding_RegisterParticleMathBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleNLerpBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleNLerpBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleNLerpBlock", "@babylonjs/core/Particles/Node/Blocks/particleNLerpBlock.pure.js")>]
    let ``RegisterParticleNLerpBlock``: FunctionBinding_RegisterParticleNLerpBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleNumberMathBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleNumberMathBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleNumberMathBlock", "@babylonjs/core/Particles/Node/Blocks/particleNumberMathBlock.pure.js")>]
    let ``RegisterParticleNumberMathBlock``: FunctionBinding_RegisterParticleNumberMathBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Particle/particleRampGradientBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleRampGradientBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleRampGradientBlock", "@babylonjs/core/Materials/Node/Blocks/Particle/particleRampGradientBlock.pure.js")>]
    let ``RegisterParticleRampGradientBlock``: FunctionBinding_RegisterParticleRampGradientBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleRandomBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleRandomBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleRandomBlock", "@babylonjs/core/Particles/Node/Blocks/particleRandomBlock.pure.js")>]
    let ``RegisterParticleRandomBlock``: FunctionBinding_RegisterParticleRandomBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleSmoothStepBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleSmoothStepBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleSmoothStepBlock", "@babylonjs/core/Particles/Node/Blocks/particleSmoothStepBlock.pure.js")>]
    let ``RegisterParticleSmoothStepBlock``: FunctionBinding_RegisterParticleSmoothStepBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleSourceTextureBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleSourceTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleSourceTextureBlock", "@babylonjs/core/Particles/Node/Blocks/particleSourceTextureBlock.pure.js")>]
    let ``RegisterParticleSourceTextureBlock``: FunctionBinding_RegisterParticleSourceTextureBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleStepBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleStepBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleStepBlock", "@babylonjs/core/Particles/Node/Blocks/particleStepBlock.pure.js")>]
    let ``RegisterParticleStepBlock``: FunctionBinding_RegisterParticleStepBlock = jsNative

    /// @babylonjs/core/Particles/particleSystem.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleSystem =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleSystem", "@babylonjs/core/Particles/particleSystem.pure.js")>]
    let ``RegisterParticleSystem``: FunctionBinding_RegisterParticleSystem = jsNative

    /// @babylonjs/core/Particles/particleSystemComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleSystemComponent =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleSystemComponent", "@babylonjs/core/Particles/particleSystemComponent.pure.js")>]
    let ``RegisterParticleSystemComponent``: FunctionBinding_RegisterParticleSystemComponent = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Teleport/particleTeleportInBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleTeleportInBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleTeleportInBlock", "@babylonjs/core/Particles/Node/Blocks/Teleport/particleTeleportInBlock.pure.js")>]
    let ``RegisterParticleTeleportInBlock``: FunctionBinding_RegisterParticleTeleportInBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Teleport/particleTeleportOutBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleTeleportOutBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleTeleportOutBlock", "@babylonjs/core/Particles/Node/Blocks/Teleport/particleTeleportOutBlock.pure.js")>]
    let ``RegisterParticleTeleportOutBlock``: FunctionBinding_RegisterParticleTeleportOutBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Particle/particleTextureBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleTextureBlock", "@babylonjs/core/Materials/Node/Blocks/Particle/particleTextureBlock.pure.js")>]
    let ``RegisterParticleTextureBlock``: FunctionBinding_RegisterParticleTextureBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Triggers/particleTriggerBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleTriggerBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleTriggerBlock", "@babylonjs/core/Particles/Node/Blocks/Triggers/particleTriggerBlock.pure.js")>]
    let ``RegisterParticleTriggerBlock``: FunctionBinding_RegisterParticleTriggerBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleTrigonometryBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleTrigonometryBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleTrigonometryBlock", "@babylonjs/core/Particles/Node/Blocks/particleTrigonometryBlock.pure.js")>]
    let ``RegisterParticleTrigonometryBlock``: FunctionBinding_RegisterParticleTrigonometryBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleVectorLengthBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleVectorLengthBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleVectorLengthBlock", "@babylonjs/core/Particles/Node/Blocks/particleVectorLengthBlock.pure.js")>]
    let ``RegisterParticleVectorLengthBlock``: FunctionBinding_RegisterParticleVectorLengthBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/particleVectorMathBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterParticleVectorMathBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterParticleVectorMathBlock", "@babylonjs/core/Particles/Node/Blocks/particleVectorMathBlock.pure.js")>]
    let ``RegisterParticleVectorMathBlock``: FunctionBinding_RegisterParticleVectorMathBlock = jsNative

    /// @babylonjs/core/PostProcesses/passPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPassPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPassPostProcess", "@babylonjs/core/PostProcesses/passPostProcess.pure.js")>]
    let ``RegisterPassPostProcess``: FunctionBinding_RegisterPassPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/passPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPassPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPassPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/passPostProcessBlock.pure.js")>]
    let ``RegisterPassPostProcessBlock``: FunctionBinding_RegisterPassPostProcessBlock = jsNative

    /// @babylonjs/core/Materials/PBR/pbrMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPbrMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPbrMaterial", "@babylonjs/core/Materials/PBR/pbrMaterial.pure.js")>]
    let ``RegisterPbrMaterial``: FunctionBinding_RegisterPbrMaterial = jsNative

    /// @babylonjs/core/Materials/PBR/pbrMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPBRMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPBRMaterial", "@babylonjs/core/Materials/PBR/pbrMaterial.pure.js")>]
    let ``RegisterPBRMaterial``: FunctionBinding_RegisterPBRMaterial = jsNative

    /// @babylonjs/core/Materials/PBR/pbrMaterial.decalMap.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPbrMaterialDecalMap =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPbrMaterialDecalMap", "@babylonjs/core/Materials/PBR/pbrMaterial.decalMap.pure.js")>]
    let ``RegisterPbrMaterialDecalMap``: FunctionBinding_RegisterPbrMaterialDecalMap = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/PBR/pbrMetallicRoughnessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPbrMetallicRoughnessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPbrMetallicRoughnessBlock", "@babylonjs/core/Materials/Node/Blocks/PBR/pbrMetallicRoughnessBlock.pure.js")>]
    let ``RegisterPbrMetallicRoughnessBlock``: FunctionBinding_RegisterPbrMetallicRoughnessBlock = jsNative

    /// @babylonjs/core/Materials/PBR/pbrMetallicRoughnessMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPbrMetallicRoughnessMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPbrMetallicRoughnessMaterial", "@babylonjs/core/Materials/PBR/pbrMetallicRoughnessMaterial.pure.js")>]
    let ``RegisterPbrMetallicRoughnessMaterial``: FunctionBinding_RegisterPbrMetallicRoughnessMaterial = jsNative

    /// @babylonjs/core/Materials/PBR/pbrSpecularGlossinessMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPbrSpecularGlossinessMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPbrSpecularGlossinessMaterial", "@babylonjs/core/Materials/PBR/pbrSpecularGlossinessMaterial.pure.js")>]
    let ``RegisterPbrSpecularGlossinessMaterial``: FunctionBinding_RegisterPbrSpecularGlossinessMaterial = jsNative

    /// @babylonjs/core/Misc/PerformanceViewer/performanceViewerSceneExtension.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPerformanceViewerSceneExtension =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPerformanceViewerSceneExtension", "@babylonjs/core/Misc/PerformanceViewer/performanceViewerSceneExtension.pure.js")>]
    let ``RegisterPerformanceViewerSceneExtension``: FunctionBinding_RegisterPerformanceViewerSceneExtension = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/perturbNormalBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPerturbNormalBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPerturbNormalBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/perturbNormalBlock.pure.js")>]
    let ``RegisterPerturbNormalBlock``: FunctionBinding_RegisterPerturbNormalBlock = jsNative

    /// @babylonjs/core/Physics/v1/physicsImpostor.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPhysicsImpostor =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPhysicsImpostor", "@babylonjs/core/Physics/v1/physicsImpostor.pure.js")>]
    let ``RegisterPhysicsImpostor``: FunctionBinding_RegisterPhysicsImpostor = jsNative

    /// @babylonjs/core/Physics/v1/physicsEngineComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPhysicsV1PhysicsEngineComponent =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPhysicsV1PhysicsEngineComponent", "@babylonjs/core/Physics/v1/physicsEngineComponent.pure.js")>]
    let ``RegisterPhysicsV1PhysicsEngineComponent``: FunctionBinding_RegisterPhysicsV1PhysicsEngineComponent = jsNative

    /// @babylonjs/core/Physics/v2/physicsEngineComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPhysicsV2PhysicsEngineComponent =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPhysicsV2PhysicsEngineComponent", "@babylonjs/core/Physics/v2/physicsEngineComponent.pure.js")>]
    let ``RegisterPhysicsV2PhysicsEngineComponent``: FunctionBinding_RegisterPhysicsV2PhysicsEngineComponent = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/planeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPlaneBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPlaneBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/planeBlock.pure.js")>]
    let ``RegisterPlaneBlock``: FunctionBinding_RegisterPlaneBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/planeBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPlaneBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPlaneBuilder", "@babylonjs/core/Meshes/Builders/planeBuilder.pure.js")>]
    let ``RegisterPlaneBuilder``: FunctionBinding_RegisterPlaneBuilder = jsNative

    /// @babylonjs/core/Lights/pointLight.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPointLight =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPointLight", "@babylonjs/core/Lights/pointLight.pure.js")>]
    let ``RegisterPointLight``: FunctionBinding_RegisterPointLight = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/pointListBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPointListBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPointListBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/pointListBlock.pure.js")>]
    let ``RegisterPointListBlock``: FunctionBinding_RegisterPointListBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/pointShapeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPointShapeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPointShapeBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/pointShapeBlock.pure.js")>]
    let ``RegisterPointShapeBlock``: FunctionBinding_RegisterPointShapeBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/polygonBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPolygonBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPolygonBuilder", "@babylonjs/core/Meshes/Builders/polygonBuilder.pure.js")>]
    let ``RegisterPolygonBuilder``: FunctionBinding_RegisterPolygonBuilder = jsNative

    /// @babylonjs/core/Meshes/Builders/polyhedronBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPolyhedronBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPolyhedronBuilder", "@babylonjs/core/Meshes/Builders/polyhedronBuilder.pure.js")>]
    let ``RegisterPolyhedronBuilder``: FunctionBinding_RegisterPolyhedronBuilder = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/posterizeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPosterizeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPosterizeBlock", "@babylonjs/core/Materials/Node/Blocks/posterizeBlock.pure.js")>]
    let ``RegisterPosterizeBlock``: FunctionBinding_RegisterPosterizeBlock = jsNative

    /// @babylonjs/core/PostProcesses/postProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPostProcess", "@babylonjs/core/PostProcesses/postProcess.pure.js")>]
    let ``RegisterPostProcess``: FunctionBinding_RegisterPostProcess = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/postProcessRenderPipelineManagerSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPostProcessRenderPipelineManagerSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ?``pipelineManagerClass``: BabylonjsBindings.SimpleClasses.PostProcessRenderPipelineManagerStatic -> unit

    [<Import("RegisterPostProcessRenderPipelineManagerSceneComponent", "@babylonjs/core/PostProcesses/RenderPipeline/postProcessRenderPipelineManagerSceneComponent.pure.js")>]
    let ``RegisterPostProcessRenderPipelineManagerSceneComponent``: FunctionBinding_RegisterPostProcessRenderPipelineManagerSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/powBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPowBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPowBlock", "@babylonjs/core/Materials/Node/Blocks/powBlock.pure.js")>]
    let ``RegisterPowBlock``: FunctionBinding_RegisterPowBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/prePassOutputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPrePassOutputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPrePassOutputBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/prePassOutputBlock.pure.js")>]
    let ``RegisterPrePassOutputBlock``: FunctionBinding_RegisterPrePassOutputBlock = jsNative

    /// @babylonjs/core/Rendering/prePassRendererSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPrePassRendererSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``prePassRendererClass``: BabylonjsBindings.SimpleClasses.PrePassRendererStatic -> unit

    [<Import("RegisterPrePassRendererSceneComponent", "@babylonjs/core/Rendering/prePassRendererSceneComponent.pure.js")>]
    let ``RegisterPrePassRendererSceneComponent``: FunctionBinding_RegisterPrePassRendererSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Input/prePassTextureBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterPrePassTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterPrePassTextureBlock", "@babylonjs/core/Materials/Node/Blocks/Input/prePassTextureBlock.pure.js")>]
    let ``RegisterPrePassTextureBlock``: FunctionBinding_RegisterPrePassTextureBlock = jsNative

    /// @babylonjs/core/Materials/Textures/Procedurals/proceduralTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterProceduralTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterProceduralTexture", "@babylonjs/core/Materials/Textures/Procedurals/proceduralTexture.pure.js")>]
    let ``RegisterProceduralTexture``: FunctionBinding_RegisterProceduralTexture = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/randomBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRandomBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRandomBlock", "@babylonjs/core/Meshes/Node/Blocks/randomBlock.pure.js")>]
    let ``RegisterRandomBlock``: FunctionBinding_RegisterRandomBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/randomNumberBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRandomNumberBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRandomNumberBlock", "@babylonjs/core/Materials/Node/Blocks/randomNumberBlock.pure.js")>]
    let ``RegisterRandomNumberBlock``: FunctionBinding_RegisterRandomNumberBlock = jsNative

    /// @babylonjs/core/Culling/ray.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRay =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRay", "@babylonjs/core/Culling/ray.pure.js")>]
    let ``RegisterRay``: FunctionBinding_RegisterRay = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/reciprocalBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterReciprocalBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterReciprocalBlock", "@babylonjs/core/Materials/Node/Blocks/reciprocalBlock.pure.js")>]
    let ``RegisterReciprocalBlock``: FunctionBinding_RegisterReciprocalBlock = jsNative

    /// @babylonjs/core/Lights/rectAreaLight.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRectAreaLight =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRectAreaLight", "@babylonjs/core/Lights/rectAreaLight.pure.js")>]
    let ``RegisterRectAreaLight``: FunctionBinding_RegisterRectAreaLight = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/reflectBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterReflectBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterReflectBlock", "@babylonjs/core/Materials/Node/Blocks/reflectBlock.pure.js")>]
    let ``RegisterReflectBlock``: FunctionBinding_RegisterReflectBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/PBR/reflectionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterReflectionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterReflectionBlock", "@babylonjs/core/Materials/Node/Blocks/PBR/reflectionBlock.pure.js")>]
    let ``RegisterReflectionBlock``: FunctionBinding_RegisterReflectionBlock = jsNative

    /// @babylonjs/core/Probes/reflectionProbe.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterReflectionProbe =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterReflectionProbe", "@babylonjs/core/Probes/reflectionProbe.pure.js")>]
    let ``RegisterReflectionProbe``: FunctionBinding_RegisterReflectionProbe = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/reflectionTextureBaseBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterReflectionTextureBaseBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterReflectionTextureBaseBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/reflectionTextureBaseBlock.pure.js")>]
    let ``RegisterReflectionTextureBaseBlock``: FunctionBinding_RegisterReflectionTextureBaseBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/reflectionTextureBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterReflectionTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterReflectionTextureBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/reflectionTextureBlock.pure.js")>]
    let ``RegisterReflectionTextureBlock``: FunctionBinding_RegisterReflectionTextureBlock = jsNative

    /// @babylonjs/core/Rendering/reflectiveShadowMap.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterReflectiveShadowMap =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterReflectiveShadowMap", "@babylonjs/core/Rendering/reflectiveShadowMap.pure.js")>]
    let ``RegisterReflectiveShadowMap``: FunctionBinding_RegisterReflectiveShadowMap = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/refractBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRefractBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRefractBlock", "@babylonjs/core/Materials/Node/Blocks/refractBlock.pure.js")>]
    let ``RegisterRefractBlock``: FunctionBinding_RegisterRefractBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/PBR/refractionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRefractionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRefractionBlock", "@babylonjs/core/Materials/Node/Blocks/PBR/refractionBlock.pure.js")>]
    let ``RegisterRefractionBlock``: FunctionBinding_RegisterRefractionBlock = jsNative

    /// @babylonjs/core/PostProcesses/refractionPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRefractionPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRefractionPostProcess", "@babylonjs/core/PostProcesses/refractionPostProcess.pure.js")>]
    let ``RegisterRefractionPostProcess``: FunctionBinding_RegisterRefractionPostProcess = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/remapBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRemapBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRemapBlock", "@babylonjs/core/Materials/Node/Blocks/remapBlock.pure.js")>]
    let ``RegisterRemapBlock``: FunctionBinding_RegisterRemapBlock = jsNative

    /// @babylonjs/core/Materials/Textures/renderTargetTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRenderTargetTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRenderTargetTexture", "@babylonjs/core/Materials/Textures/renderTargetTexture.pure.js")>]
    let ``RegisterRenderTargetTexture``: FunctionBinding_RegisterRenderTargetTexture = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/replaceColorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterReplaceColorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterReplaceColorBlock", "@babylonjs/core/Materials/Node/Blocks/replaceColorBlock.pure.js")>]
    let ``RegisterReplaceColorBlock``: FunctionBinding_RegisterReplaceColorBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/resourceContainerBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterResourceContainerBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterResourceContainerBlock", "@babylonjs/core/FrameGraph/Node/Blocks/resourceContainerBlock.pure.js")>]
    let ``RegisterResourceContainerBlock``: FunctionBinding_RegisterResourceContainerBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/ribbonBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRibbonBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRibbonBuilder", "@babylonjs/core/Meshes/Builders/ribbonBuilder.pure.js")>]
    let ``RegisterRibbonBuilder``: FunctionBinding_RegisterRibbonBuilder = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/rotate2dBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRotate2dBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRotate2dBlock", "@babylonjs/core/Materials/Node/Blocks/rotate2dBlock.pure.js")>]
    let ``RegisterRotate2dBlock``: FunctionBinding_RegisterRotate2dBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Matrices/rotationXBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRotationXBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRotationXBlock", "@babylonjs/core/Meshes/Node/Blocks/Matrices/rotationXBlock.pure.js")>]
    let ``RegisterRotationXBlock``: FunctionBinding_RegisterRotationXBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Matrices/rotationYBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRotationYBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRotationYBlock", "@babylonjs/core/Meshes/Node/Blocks/Matrices/rotationYBlock.pure.js")>]
    let ``RegisterRotationYBlock``: FunctionBinding_RegisterRotationYBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Matrices/rotationZBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterRotationZBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterRotationZBlock", "@babylonjs/core/Meshes/Node/Blocks/Matrices/rotationZBlock.pure.js")>]
    let ``RegisterRotationZBlock``: FunctionBinding_RegisterRotationZBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/scaleBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScaleBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScaleBlock", "@babylonjs/core/Materials/Node/Blocks/scaleBlock.pure.js")>]
    let ``RegisterScaleBlock``: FunctionBinding_RegisterScaleBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Matrices/scalingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScalingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScalingBlock", "@babylonjs/core/Meshes/Node/Blocks/Matrices/scalingBlock.pure.js")>]
    let ``RegisterScalingBlock``: FunctionBinding_RegisterScalingBlock = jsNative

    /// @babylonjs/core/scene.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScene =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScene", "@babylonjs/core/scene.pure.js")>]
    let ``RegisterScene``: FunctionBinding_RegisterScene = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/sceneDepthBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSceneDepthBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSceneDepthBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/sceneDepthBlock.pure.js")>]
    let ``RegisterSceneDepthBlock``: FunctionBinding_RegisterSceneDepthBlock = jsNative

    /// @babylonjs/core/Helpers/sceneHelpers.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSceneHelpers =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSceneHelpers", "@babylonjs/core/Helpers/sceneHelpers.pure.js")>]
    let ``RegisterSceneHelpers``: FunctionBinding_RegisterSceneHelpers = jsNative

    /// @babylonjs/core/Misc/screenshotTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScreenshotTools =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScreenshotTools", "@babylonjs/core/Misc/screenshotTools.pure.js")>]
    let ``RegisterScreenshotTools``: FunctionBinding_RegisterScreenshotTools = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/screenSizeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScreenSizeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScreenSizeBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/screenSizeBlock.pure.js")>]
    let ``RegisterScreenSizeBlock``: FunctionBinding_RegisterScreenSizeBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/screenSpaceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScreenSpaceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScreenSpaceBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/screenSpaceBlock.pure.js")>]
    let ``RegisterScreenSpaceBlock``: FunctionBinding_RegisterScreenSpaceBlock = jsNative

    /// @babylonjs/core/PostProcesses/screenSpaceCurvaturePostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScreenSpaceCurvaturePostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScreenSpaceCurvaturePostProcess", "@babylonjs/core/PostProcesses/screenSpaceCurvaturePostProcess.pure.js")>]
    let ``RegisterScreenSpaceCurvaturePostProcess``: FunctionBinding_RegisterScreenSpaceCurvaturePostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/screenSpaceCurvaturePostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScreenSpaceCurvaturePostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScreenSpaceCurvaturePostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/screenSpaceCurvaturePostProcessBlock.pure.js")>]
    let ``RegisterScreenSpaceCurvaturePostProcessBlock``: FunctionBinding_RegisterScreenSpaceCurvaturePostProcessBlock = jsNative

    /// @babylonjs/core/PostProcesses/screenSpaceReflectionPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterScreenSpaceReflectionPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterScreenSpaceReflectionPostProcess", "@babylonjs/core/PostProcesses/screenSpaceReflectionPostProcess.pure.js")>]
    let ``RegisterScreenSpaceReflectionPostProcess``: FunctionBinding_RegisterScreenSpaceReflectionPostProcess = jsNative

    /// @babylonjs/core/Layers/selectionOutlineLayer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSelectionOutlineLayer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSelectionOutlineLayer", "@babylonjs/core/Layers/selectionOutlineLayer.pure.js")>]
    let ``RegisterSelectionOutlineLayer``: FunctionBinding_RegisterSelectionOutlineLayer = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Layers/selectionOutlineLayerBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSelectionOutlineLayerBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSelectionOutlineLayerBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Layers/selectionOutlineLayerBlock.pure.js")>]
    let ``RegisterSelectionOutlineLayerBlock``: FunctionBinding_RegisterSelectionOutlineLayerBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Set/setColorsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSetColorsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSetColorsBlock", "@babylonjs/core/Meshes/Node/Blocks/Set/setColorsBlock.pure.js")>]
    let ``RegisterSetColorsBlock``: FunctionBinding_RegisterSetColorsBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Set/setMaterialIDBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSetMaterialIDBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSetMaterialIDBlock", "@babylonjs/core/Meshes/Node/Blocks/Set/setMaterialIDBlock.pure.js")>]
    let ``RegisterSetMaterialIDBlock``: FunctionBinding_RegisterSetMaterialIDBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Set/setNormalsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSetNormalsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSetNormalsBlock", "@babylonjs/core/Meshes/Node/Blocks/Set/setNormalsBlock.pure.js")>]
    let ``RegisterSetNormalsBlock``: FunctionBinding_RegisterSetNormalsBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Set/setPositionsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSetPositionsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSetPositionsBlock", "@babylonjs/core/Meshes/Node/Blocks/Set/setPositionsBlock.pure.js")>]
    let ``RegisterSetPositionsBlock``: FunctionBinding_RegisterSetPositionsBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Set/setTangentsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSetTangentsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSetTangentsBlock", "@babylonjs/core/Meshes/Node/Blocks/Set/setTangentsBlock.pure.js")>]
    let ``RegisterSetTangentsBlock``: FunctionBinding_RegisterSetTangentsBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/setupSpriteSheetBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSetupSpriteSheetBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSetupSpriteSheetBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/setupSpriteSheetBlock.pure.js")>]
    let ``RegisterSetupSpriteSheetBlock``: FunctionBinding_RegisterSetupSpriteSheetBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Set/setUVsBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSetUVsBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSetUVsBlock", "@babylonjs/core/Meshes/Node/Blocks/Set/setUVsBlock.pure.js")>]
    let ``RegisterSetUVsBlock``: FunctionBinding_RegisterSetUVsBlock = jsNative

    /// @babylonjs/core/Materials/shaderMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterShaderMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterShaderMaterial", "@babylonjs/core/Materials/shaderMaterial.pure.js")>]
    let ``RegisterShaderMaterial``: FunctionBinding_RegisterShaderMaterial = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Rendering/shadowGeneratorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterShadowGeneratorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterShadowGeneratorBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Rendering/shadowGeneratorBlock.pure.js")>]
    let ``RegisterShadowGeneratorBlock``: FunctionBinding_RegisterShadowGeneratorBlock = jsNative

    /// @babylonjs/core/Lights/Shadows/shadowGeneratorSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterShadowGeneratorSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``shadowGeneratorClass``: BabylonjsBindings.SimpleClasses.ShadowGeneratorStatic -> unit

    [<Import("RegisterShadowGeneratorSceneComponent", "@babylonjs/core/Lights/Shadows/shadowGeneratorSceneComponent.pure.js")>]
    let ``RegisterShadowGeneratorSceneComponent``: FunctionBinding_RegisterShadowGeneratorSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/shadowMapBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterShadowMapBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterShadowMapBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/shadowMapBlock.pure.js")>]
    let ``RegisterShadowMapBlock``: FunctionBinding_RegisterShadowMapBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/shapeBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterShapeBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterShapeBuilder", "@babylonjs/core/Meshes/Builders/shapeBuilder.pure.js")>]
    let ``RegisterShapeBuilder``: FunctionBinding_RegisterShapeBuilder = jsNative

    /// @babylonjs/core/PostProcesses/sharpenPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSharpenPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSharpenPostProcess", "@babylonjs/core/PostProcesses/sharpenPostProcess.pure.js")>]
    let ``RegisterSharpenPostProcess``: FunctionBinding_RegisterSharpenPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/sharpenPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSharpenPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSharpenPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/sharpenPostProcessBlock.pure.js")>]
    let ``RegisterSharpenPostProcessBlock``: FunctionBinding_RegisterSharpenPostProcessBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/PBR/sheenBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSheenBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSheenBlock", "@babylonjs/core/Materials/Node/Blocks/PBR/sheenBlock.pure.js")>]
    let ``RegisterSheenBlock``: FunctionBinding_RegisterSheenBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/simplexPerlin3DBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSimplexPerlin3DBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSimplexPerlin3DBlock", "@babylonjs/core/Materials/Node/Blocks/simplexPerlin3DBlock.pure.js")>]
    let ``RegisterSimplexPerlin3DBlock``: FunctionBinding_RegisterSimplexPerlin3DBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/smartFilterFragmentOutputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSmartFilterFragmentOutputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSmartFilterFragmentOutputBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/smartFilterFragmentOutputBlock.pure.js")>]
    let ``RegisterSmartFilterFragmentOutputBlock``: FunctionBinding_RegisterSmartFilterFragmentOutputBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/smartFilterTextureBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSmartFilterTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSmartFilterTextureBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/smartFilterTextureBlock.pure.js")>]
    let ``RegisterSmartFilterTextureBlock``: FunctionBinding_RegisterSmartFilterTextureBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/smoothStepBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSmoothStepBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSmoothStepBlock", "@babylonjs/core/Materials/Node/Blocks/smoothStepBlock.pure.js")>]
    let ``RegisterSmoothStepBlock``: FunctionBinding_RegisterSmoothStepBlock = jsNative

    /// @babylonjs/core/Audio/sound.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSound =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSound", "@babylonjs/core/Audio/sound.pure.js")>]
    let ``RegisterSound``: FunctionBinding_RegisterSound = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/sphereBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSphereBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSphereBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/sphereBlock.pure.js")>]
    let ``RegisterSphereBlock``: FunctionBinding_RegisterSphereBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/sphereBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSphereBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSphereBuilder", "@babylonjs/core/Meshes/Builders/sphereBuilder.pure.js")>]
    let ``RegisterSphereBuilder``: FunctionBinding_RegisterSphereBuilder = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Emitters/sphereShapeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSphereShapeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSphereShapeBlock", "@babylonjs/core/Particles/Node/Blocks/Emitters/sphereShapeBlock.pure.js")>]
    let ``RegisterSphereShapeBlock``: FunctionBinding_RegisterSphereShapeBlock = jsNative

    /// @babylonjs/loaders/SPLAT/splatFileLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSPLATFileLoader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSPLATFileLoader", "@babylonjs/loaders/SPLAT/splatFileLoader.pure.js")>]
    let ``RegisterSPLATFileLoader``: FunctionBinding_RegisterSPLATFileLoader = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/GaussianSplatting/splatReaderBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSplatReaderBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSplatReaderBlock", "@babylonjs/core/Materials/Node/Blocks/GaussianSplatting/splatReaderBlock.pure.js")>]
    let ``RegisterSplatReaderBlock``: FunctionBinding_RegisterSplatReaderBlock = jsNative

    /// @babylonjs/core/Lights/spotLight.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSpotLight =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSpotLight", "@babylonjs/core/Lights/spotLight.pure.js")>]
    let ``RegisterSpotLight``: FunctionBinding_RegisterSpotLight = jsNative

    /// @babylonjs/core/Sprites/spriteSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSpriteSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSpriteSceneComponent", "@babylonjs/core/Sprites/spriteSceneComponent.pure.js")>]
    let ``RegisterSpriteSceneComponent``: FunctionBinding_RegisterSpriteSceneComponent = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/ssao2PostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSsao2PostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSsao2PostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/ssao2PostProcessBlock.pure.js")>]
    let ``RegisterSsao2PostProcessBlock``: FunctionBinding_RegisterSsao2PostProcessBlock = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/ssao2RenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSsao2RenderingPipeline =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSsao2RenderingPipeline", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/ssao2RenderingPipeline.pure.js")>]
    let ``RegisterSsao2RenderingPipeline``: FunctionBinding_RegisterSsao2RenderingPipeline = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/ssrPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSsrPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSsrPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/ssrPostProcessBlock.pure.js")>]
    let ``RegisterSsrPostProcessBlock``: FunctionBinding_RegisterSsrPostProcessBlock = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/ssrRenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSsrRenderingPipeline =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSsrRenderingPipeline", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/ssrRenderingPipeline.pure.js")>]
    let ``RegisterSsrRenderingPipeline``: FunctionBinding_RegisterSsrRenderingPipeline = jsNative

    /// @babylonjs/core/Materials/standardMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStandardMaterial =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStandardMaterial", "@babylonjs/core/Materials/standardMaterial.pure.js")>]
    let ``RegisterStandardMaterial``: FunctionBinding_RegisterStandardMaterial = jsNative

    /// @babylonjs/core/Materials/standardMaterial.decalMap.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStandardMaterialDecalMap =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStandardMaterialDecalMap", "@babylonjs/core/Materials/standardMaterial.decalMap.pure.js")>]
    let ``RegisterStandardMaterialDecalMap``: FunctionBinding_RegisterStandardMaterialDecalMap = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/standardRenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStandardRenderingPipeline =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStandardRenderingPipeline", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/standardRenderingPipeline.pure.js")>]
    let ``RegisterStandardRenderingPipeline``: FunctionBinding_RegisterStandardRenderingPipeline = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/stepBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStepBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStepBlock", "@babylonjs/core/Materials/Node/Blocks/stepBlock.pure.js")>]
    let ``RegisterStepBlock``: FunctionBinding_RegisterStepBlock = jsNative

    /// @babylonjs/core/Cameras/Stereoscopic/stereoscopicArcRotateCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStereoscopicArcRotateCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStereoscopicArcRotateCamera", "@babylonjs/core/Cameras/Stereoscopic/stereoscopicArcRotateCamera.pure.js")>]
    let ``RegisterStereoscopicArcRotateCamera``: FunctionBinding_RegisterStereoscopicArcRotateCamera = jsNative

    /// @babylonjs/core/Cameras/Stereoscopic/stereoscopicFreeCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStereoscopicFreeCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStereoscopicFreeCamera", "@babylonjs/core/Cameras/Stereoscopic/stereoscopicFreeCamera.pure.js")>]
    let ``RegisterStereoscopicFreeCamera``: FunctionBinding_RegisterStereoscopicFreeCamera = jsNative

    /// @babylonjs/core/Cameras/Stereoscopic/stereoscopicGamepadCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStereoscopicGamepadCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStereoscopicGamepadCamera", "@babylonjs/core/Cameras/Stereoscopic/stereoscopicGamepadCamera.pure.js")>]
    let ``RegisterStereoscopicGamepadCamera``: FunctionBinding_RegisterStereoscopicGamepadCamera = jsNative

    /// @babylonjs/core/Cameras/Stereoscopic/stereoscopicUniversalCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStereoscopicUniversalCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStereoscopicUniversalCamera", "@babylonjs/core/Cameras/Stereoscopic/stereoscopicUniversalCamera.pure.js")>]
    let ``RegisterStereoscopicUniversalCamera``: FunctionBinding_RegisterStereoscopicUniversalCamera = jsNative

    /// @babylonjs/loaders/STL/stlFileLoader.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSTLFileLoader =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSTLFileLoader", "@babylonjs/loaders/STL/stlFileLoader.pure.js")>]
    let ``RegisterSTLFileLoader``: FunctionBinding_RegisterSTLFileLoader = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/storageReadBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStorageReadBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStorageReadBlock", "@babylonjs/core/Materials/Node/Blocks/storageReadBlock.pure.js")>]
    let ``RegisterStorageReadBlock``: FunctionBinding_RegisterStorageReadBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/storageWriteBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterStorageWriteBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterStorageWriteBlock", "@babylonjs/core/Materials/Node/Blocks/storageWriteBlock.pure.js")>]
    let ``RegisterStorageWriteBlock``: FunctionBinding_RegisterStorageWriteBlock = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/subdivideBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSubdivideBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSubdivideBlock", "@babylonjs/core/Meshes/Node/Blocks/subdivideBlock.pure.js")>]
    let ``RegisterSubdivideBlock``: FunctionBinding_RegisterSubdivideBlock = jsNative

    /// @babylonjs/core/Meshes/subMesh.project.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSubMeshProject =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSubMeshProject", "@babylonjs/core/Meshes/subMesh.project.pure.js")>]
    let ``RegisterSubMeshProject``: FunctionBinding_RegisterSubMeshProject = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/PBR/subSurfaceBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSubSurfaceBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSubSurfaceBlock", "@babylonjs/core/Materials/Node/Blocks/PBR/subSurfaceBlock.pure.js")>]
    let ``RegisterSubSurfaceBlock``: FunctionBinding_RegisterSubSurfaceBlock = jsNative

    /// @babylonjs/core/Rendering/subSurfaceSceneComponent.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSubSurfaceSceneComponent =
        [<Emit("$0($1...)")>] abstract Invoke: ``subSurfaceConfigClass``: BabylonjsBindings.SimpleClasses.SubSurfaceConfigurationStatic -> unit

    [<Import("RegisterSubSurfaceSceneComponent", "@babylonjs/core/Rendering/subSurfaceSceneComponent.pure.js")>]
    let ``RegisterSubSurfaceSceneComponent``: FunctionBinding_RegisterSubSurfaceSceneComponent = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/subtractBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSubtractBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSubtractBlock", "@babylonjs/core/Materials/Node/Blocks/subtractBlock.pure.js")>]
    let ``RegisterSubtractBlock``: FunctionBinding_RegisterSubtractBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/systemBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterSystemBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterSystemBlock", "@babylonjs/core/Particles/Node/Blocks/systemBlock.pure.js")>]
    let ``RegisterSystemBlock``: FunctionBinding_RegisterSystemBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/taaPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTaaPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTaaPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/taaPostProcessBlock.pure.js")>]
    let ``RegisterTaaPostProcessBlock``: FunctionBinding_RegisterTaaPostProcessBlock = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/taaRenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTaaRenderingPipeline =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTaaRenderingPipeline", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/taaRenderingPipeline.pure.js")>]
    let ``RegisterTaaRenderingPipeline``: FunctionBinding_RegisterTaaRenderingPipeline = jsNative

    /// @babylonjs/core/Cameras/targetCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTargetCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTargetCamera", "@babylonjs/core/Cameras/targetCamera.pure.js")>]
    let ``RegisterTargetCamera``: FunctionBinding_RegisterTargetCamera = jsNative

    /// @babylonjs/core/Animations/animatable.core
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTargetForLateAnimationBinding =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``runtimeAnimation``: BabylonjsBindings.SimpleClasses.RuntimeAnimation * ``originalValue``: obj -> unit

    [<Import("RegisterTargetForLateAnimationBinding", "@babylonjs/core/Animations/animatable.core.js")>]
    let ``RegisterTargetForLateAnimationBinding``: FunctionBinding_RegisterTargetForLateAnimationBinding = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/TBNBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTBNBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTBNBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/TBNBlock.pure.js")>]
    let ``RegisterTBNBlock``: FunctionBinding_RegisterTBNBlock = jsNative

    /// @babylonjs/core/Materials/Textures/texture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTexture", "@babylonjs/core/Materials/Textures/texture.pure.js")>]
    let ``RegisterTexture``: FunctionBinding_RegisterTexture = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Dual/textureBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTextureBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTextureBlock", "@babylonjs/core/Materials/Node/Blocks/Dual/textureBlock.pure.js")>]
    let ``RegisterTextureBlock``: FunctionBinding_RegisterTextureBlock = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/textureLoaderManager
    [<AllowNullLiteral>]
    type FunctionBinding_registerTextureLoader =
        [<Emit("$0($1...)")>] abstract Invoke: ``extension``: string * ``loaderFactory``: System.Func<string option, U2<BabylonjsBindings.SimpleInterfaces.IInternalTextureLoader, JS.Promise<BabylonjsBindings.SimpleInterfaces.IInternalTextureLoader>>> -> unit

    [<Import("registerTextureLoader", "@babylonjs/core/Materials/Textures/Loaders/textureLoaderManager.js")>]
    let ``registerTextureLoader``: FunctionBinding_registerTextureLoader = jsNative

    /// @babylonjs/core/Engines/thinEngine.scissor.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterThinEngineScissor =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterThinEngineScissor", "@babylonjs/core/Engines/thinEngine.scissor.pure.js")>]
    let ``RegisterThinEngineScissor``: FunctionBinding_RegisterThinEngineScissor = jsNative

    /// @babylonjs/core/Meshes/thinInstanceMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterThinInstanceMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterThinInstanceMesh", "@babylonjs/core/Meshes/thinInstanceMesh.pure.js")>]
    let ``RegisterThinInstanceMesh``: FunctionBinding_RegisterThinInstanceMesh = jsNative

    /// @babylonjs/core/Meshes/Builders/tiledBoxBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTiledBoxBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTiledBoxBuilder", "@babylonjs/core/Meshes/Builders/tiledBoxBuilder.pure.js")>]
    let ``RegisterTiledBoxBuilder``: FunctionBinding_RegisterTiledBoxBuilder = jsNative

    /// @babylonjs/core/Meshes/Builders/tiledPlaneBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTiledPlaneBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTiledPlaneBuilder", "@babylonjs/core/Meshes/Builders/tiledPlaneBuilder.pure.js")>]
    let ``RegisterTiledPlaneBuilder``: FunctionBinding_RegisterTiledPlaneBuilder = jsNative

    /// @babylonjs/core/PostProcesses/tonemapPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTonemapPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTonemapPostProcess", "@babylonjs/core/PostProcesses/tonemapPostProcess.pure.js")>]
    let ``RegisterTonemapPostProcess``: FunctionBinding_RegisterTonemapPostProcess = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/tonemapPostProcessBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTonemapPostProcessBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTonemapPostProcessBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/tonemapPostProcessBlock.pure.js")>]
    let ``RegisterTonemapPostProcessBlock``: FunctionBinding_RegisterTonemapPostProcessBlock = jsNative

    /// @babylonjs/core/Misc/tools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTools =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTools", "@babylonjs/core/Misc/tools.pure.js")>]
    let ``RegisterTools``: FunctionBinding_RegisterTools = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Sources/torusBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTorusBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTorusBlock", "@babylonjs/core/Meshes/Node/Blocks/Sources/torusBlock.pure.js")>]
    let ``RegisterTorusBlock``: FunctionBinding_RegisterTorusBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/torusBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTorusBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTorusBuilder", "@babylonjs/core/Meshes/Builders/torusBuilder.pure.js")>]
    let ``RegisterTorusBuilder``: FunctionBinding_RegisterTorusBuilder = jsNative

    /// @babylonjs/core/Meshes/Builders/torusKnotBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTorusKnotBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTorusKnotBuilder", "@babylonjs/core/Meshes/Builders/torusKnotBuilder.pure.js")>]
    let ``RegisterTorusKnotBuilder``: FunctionBinding_RegisterTorusKnotBuilder = jsNative

    /// @babylonjs/core/Cameras/touchCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTouchCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTouchCamera", "@babylonjs/core/Cameras/touchCamera.pure.js")>]
    let ``RegisterTouchCamera``: FunctionBinding_RegisterTouchCamera = jsNative

    /// @babylonjs/core/Meshes/trailMesh.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTrailMesh =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTrailMesh", "@babylonjs/core/Meshes/trailMesh.pure.js")>]
    let ``RegisterTrailMesh``: FunctionBinding_RegisterTrailMesh = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/transformBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTransformBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTransformBlock", "@babylonjs/core/Materials/Node/Blocks/transformBlock.pure.js")>]
    let ``RegisterTransformBlock``: FunctionBinding_RegisterTransformBlock = jsNative

    /// @babylonjs/core/Meshes/transformNode.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTransformNode =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTransformNode", "@babylonjs/core/Meshes/transformNode.pure.js")>]
    let ``RegisterTransformNode``: FunctionBinding_RegisterTransformNode = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/Matrices/translationBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTranslationBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTranslationBlock", "@babylonjs/core/Meshes/Node/Blocks/Matrices/translationBlock.pure.js")>]
    let ``RegisterTranslationBlock``: FunctionBinding_RegisterTranslationBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/trigonometryBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTrigonometryBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTrigonometryBlock", "@babylonjs/core/Materials/Node/Blocks/trigonometryBlock.pure.js")>]
    let ``RegisterTrigonometryBlock``: FunctionBinding_RegisterTrigonometryBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/triPlanarBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTriPlanarBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTriPlanarBlock", "@babylonjs/core/Materials/Node/Blocks/triPlanarBlock.pure.js")>]
    let ``RegisterTriPlanarBlock``: FunctionBinding_RegisterTriPlanarBlock = jsNative

    /// @babylonjs/core/Meshes/Builders/tubeBuilder.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTubeBuilder =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTubeBuilder", "@babylonjs/core/Meshes/Builders/tubeBuilder.pure.js")>]
    let ``RegisterTubeBuilder``: FunctionBinding_RegisterTubeBuilder = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Fragment/twirlBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterTwirlBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterTwirlBlock", "@babylonjs/core/Materials/Node/Blocks/Fragment/twirlBlock.pure.js")>]
    let ``RegisterTwirlBlock``: FunctionBinding_RegisterTwirlBlock = jsNative

    /// @babylonjs/core/Cameras/universalCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUniversalCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUniversalCamera", "@babylonjs/core/Cameras/universalCamera.pure.js")>]
    let ``RegisterUniversalCamera``: FunctionBinding_RegisterUniversalCamera = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateAgeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateAgeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateAgeBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateAgeBlock.pure.js")>]
    let ``RegisterUpdateAgeBlock``: FunctionBinding_RegisterUpdateAgeBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateAngleBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateAngleBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateAngleBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateAngleBlock.pure.js")>]
    let ``RegisterUpdateAngleBlock``: FunctionBinding_RegisterUpdateAngleBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateAttractorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateAttractorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateAttractorBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateAttractorBlock.pure.js")>]
    let ``RegisterUpdateAttractorBlock``: FunctionBinding_RegisterUpdateAttractorBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateColorBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateColorBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateColorBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateColorBlock.pure.js")>]
    let ``RegisterUpdateColorBlock``: FunctionBinding_RegisterUpdateColorBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateDirectionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateDirectionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateDirectionBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateDirectionBlock.pure.js")>]
    let ``RegisterUpdateDirectionBlock``: FunctionBinding_RegisterUpdateDirectionBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateFlowMapBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateFlowMapBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateFlowMapBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateFlowMapBlock.pure.js")>]
    let ``RegisterUpdateFlowMapBlock``: FunctionBinding_RegisterUpdateFlowMapBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateNoiseBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateNoiseBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateNoiseBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateNoiseBlock.pure.js")>]
    let ``RegisterUpdateNoiseBlock``: FunctionBinding_RegisterUpdateNoiseBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updatePositionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdatePositionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdatePositionBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updatePositionBlock.pure.js")>]
    let ``RegisterUpdatePositionBlock``: FunctionBinding_RegisterUpdatePositionBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateScaleBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateScaleBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateScaleBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateScaleBlock.pure.js")>]
    let ``RegisterUpdateScaleBlock``: FunctionBinding_RegisterUpdateScaleBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateSizeBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateSizeBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateSizeBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateSizeBlock.pure.js")>]
    let ``RegisterUpdateSizeBlock``: FunctionBinding_RegisterUpdateSizeBlock = jsNative

    /// @babylonjs/core/Particles/Node/Blocks/Update/updateSpriteCellIndexBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUpdateSpriteCellIndexBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUpdateSpriteCellIndexBlock", "@babylonjs/core/Particles/Node/Blocks/Update/updateSpriteCellIndexBlock.pure.js")>]
    let ``RegisterUpdateSpriteCellIndexBlock``: FunctionBinding_RegisterUpdateSpriteCellIndexBlock = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/Rendering/utilityLayerRendererBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterUtilityLayerRendererBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterUtilityLayerRendererBlock", "@babylonjs/core/FrameGraph/Node/Blocks/Rendering/utilityLayerRendererBlock.pure.js")>]
    let ``RegisterUtilityLayerRendererBlock``: FunctionBinding_RegisterUtilityLayerRendererBlock = jsNative

    /// @babylonjs/core/Engines/Native/validatedNativeDataStream.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterValidatedNativeDataStream =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterValidatedNativeDataStream", "@babylonjs/core/Engines/Native/validatedNativeDataStream.pure.js")>]
    let ``RegisterValidatedNativeDataStream``: FunctionBinding_RegisterValidatedNativeDataStream = jsNative

    /// @babylonjs/core/Meshes/Node/Blocks/vectorConverterBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVectorConverterBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVectorConverterBlock", "@babylonjs/core/Meshes/Node/Blocks/vectorConverterBlock.pure.js")>]
    let ``RegisterVectorConverterBlock``: FunctionBinding_RegisterVectorConverterBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/vectorMergerBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVectorMergerBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVectorMergerBlock", "@babylonjs/core/Materials/Node/Blocks/vectorMergerBlock.pure.js")>]
    let ``RegisterVectorMergerBlock``: FunctionBinding_RegisterVectorMergerBlock = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/vectorSplitterBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVectorSplitterBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVectorSplitterBlock", "@babylonjs/core/Materials/Node/Blocks/vectorSplitterBlock.pure.js")>]
    let ``RegisterVectorSplitterBlock``: FunctionBinding_RegisterVectorSplitterBlock = jsNative

    /// @babylonjs/core/Buffers/buffer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVertexBuffer =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVertexBuffer", "@babylonjs/core/Buffers/buffer.pure.js")>]
    let ``RegisterVertexBuffer``: FunctionBinding_RegisterVertexBuffer = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/Vertex/vertexOutputBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVertexOutputBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVertexOutputBlock", "@babylonjs/core/Materials/Node/Blocks/Vertex/vertexOutputBlock.pure.js")>]
    let ``RegisterVertexOutputBlock``: FunctionBinding_RegisterVertexOutputBlock = jsNative

    /// @babylonjs/core/Materials/Textures/videoTexture.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVideoTexture =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVideoTexture", "@babylonjs/core/Materials/Textures/videoTexture.pure.js")>]
    let ``RegisterVideoTexture``: FunctionBinding_RegisterVideoTexture = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/viewDirectionBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterViewDirectionBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterViewDirectionBlock", "@babylonjs/core/Materials/Node/Blocks/viewDirectionBlock.pure.js")>]
    let ``RegisterViewDirectionBlock``: FunctionBinding_RegisterViewDirectionBlock = jsNative

    /// @babylonjs/core/Cameras/virtualJoysticksCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVirtualJoysticksCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVirtualJoysticksCamera", "@babylonjs/core/Cameras/virtualJoysticksCamera.pure.js")>]
    let ``RegisterVirtualJoysticksCamera``: FunctionBinding_RegisterVirtualJoysticksCamera = jsNative

    /// @babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/volumetricLightingBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVolumetricLightingBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVolumetricLightingBlock", "@babylonjs/core/FrameGraph/Node/Blocks/PostProcesses/volumetricLightingBlock.pure.js")>]
    let ``RegisterVolumetricLightingBlock``: FunctionBinding_RegisterVolumetricLightingBlock = jsNative

    /// @babylonjs/core/PostProcesses/volumetricLightScatteringPostProcess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVolumetricLightScatteringPostProcess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVolumetricLightScatteringPostProcess", "@babylonjs/core/PostProcesses/volumetricLightScatteringPostProcess.pure.js")>]
    let ``RegisterVolumetricLightScatteringPostProcess``: FunctionBinding_RegisterVolumetricLightScatteringPostProcess = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/voronoiNoiseBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVoronoiNoiseBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVoronoiNoiseBlock", "@babylonjs/core/Materials/Node/Blocks/voronoiNoiseBlock.pure.js")>]
    let ``RegisterVoronoiNoiseBlock``: FunctionBinding_RegisterVoronoiNoiseBlock = jsNative

    /// @babylonjs/core/Cameras/VR/vrDeviceOrientationArcRotateCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVrDeviceOrientationArcRotateCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVrDeviceOrientationArcRotateCamera", "@babylonjs/core/Cameras/VR/vrDeviceOrientationArcRotateCamera.pure.js")>]
    let ``RegisterVrDeviceOrientationArcRotateCamera``: FunctionBinding_RegisterVrDeviceOrientationArcRotateCamera = jsNative

    /// @babylonjs/core/Cameras/VR/vrDeviceOrientationFreeCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVrDeviceOrientationFreeCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVrDeviceOrientationFreeCamera", "@babylonjs/core/Cameras/VR/vrDeviceOrientationFreeCamera.pure.js")>]
    let ``RegisterVrDeviceOrientationFreeCamera``: FunctionBinding_RegisterVrDeviceOrientationFreeCamera = jsNative

    /// @babylonjs/core/Cameras/VR/vrDeviceOrientationGamepadCamera.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterVrDeviceOrientationGamepadCamera =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterVrDeviceOrientationGamepadCamera", "@babylonjs/core/Cameras/VR/vrDeviceOrientationGamepadCamera.pure.js")>]
    let ``RegisterVrDeviceOrientationGamepadCamera``: FunctionBinding_RegisterVrDeviceOrientationGamepadCamera = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/waveBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWaveBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWaveBlock", "@babylonjs/core/Materials/Node/Blocks/waveBlock.pure.js")>]
    let ``RegisterWaveBlock``: FunctionBinding_RegisterWaveBlock = jsNative

    /// @babylonjs/core/Particles/webgl2ParticleSystem.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebgl2ParticleSystem =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebgl2ParticleSystem", "@babylonjs/core/Particles/webgl2ParticleSystem.pure.js")>]
    let ``RegisterWebgl2ParticleSystem``: FunctionBinding_RegisterWebgl2ParticleSystem = jsNative

    /// @babylonjs/core/Engines/WebGPU/Extensions/engine.debugging.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebGPUDebugging =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebGPUDebugging", "@babylonjs/core/Engines/WebGPU/Extensions/engine.debugging.pure.js")>]
    let ``RegisterWebGPUDebugging``: FunctionBinding_RegisterWebGPUDebugging = jsNative

    /// @babylonjs/core/XR/features/WebXRAnchorSystem.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRAnchorSystem =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRAnchorSystem", "@babylonjs/core/XR/features/WebXRAnchorSystem.pure.js")>]
    let ``RegisterWebXRAnchorSystem``: FunctionBinding_RegisterWebXRAnchorSystem = jsNative

    /// @babylonjs/core/XR/features/WebXRBackgroundRemover.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRBackgroundRemover =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRBackgroundRemover", "@babylonjs/core/XR/features/WebXRBackgroundRemover.pure.js")>]
    let ``RegisterWebXRBackgroundRemover``: FunctionBinding_RegisterWebXRBackgroundRemover = jsNative

    /// @babylonjs/core/XR/features/WebXRBodyTracking.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRBodyTracking =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRBodyTracking", "@babylonjs/core/XR/features/WebXRBodyTracking.pure.js")>]
    let ``RegisterWebXRBodyTracking``: FunctionBinding_RegisterWebXRBodyTracking = jsNative

    /// @babylonjs/core/XR/features/WebXRControllerMovement.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRControllerMovement =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRControllerMovement", "@babylonjs/core/XR/features/WebXRControllerMovement.pure.js")>]
    let ``RegisterWebXRControllerMovement``: FunctionBinding_RegisterWebXRControllerMovement = jsNative

    /// @babylonjs/core/XR/features/WebXRControllerPhysics.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRControllerPhysics =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRControllerPhysics", "@babylonjs/core/XR/features/WebXRControllerPhysics.pure.js")>]
    let ``RegisterWebXRControllerPhysics``: FunctionBinding_RegisterWebXRControllerPhysics = jsNative

    /// @babylonjs/core/XR/features/WebXRControllerPointerSelection.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRControllerPointerSelection =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRControllerPointerSelection", "@babylonjs/core/XR/features/WebXRControllerPointerSelection.pure.js")>]
    let ``RegisterWebXRControllerPointerSelection``: FunctionBinding_RegisterWebXRControllerPointerSelection = jsNative

    /// @babylonjs/core/XR/features/WebXRControllerTeleportation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRControllerTeleportation =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRControllerTeleportation", "@babylonjs/core/XR/features/WebXRControllerTeleportation.pure.js")>]
    let ``RegisterWebXRControllerTeleportation``: FunctionBinding_RegisterWebXRControllerTeleportation = jsNative

    /// @babylonjs/core/XR/features/WebXRDepthSensing.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRDepthSensing =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRDepthSensing", "@babylonjs/core/XR/features/WebXRDepthSensing.pure.js")>]
    let ``RegisterWebXRDepthSensing``: FunctionBinding_RegisterWebXRDepthSensing = jsNative

    /// @babylonjs/core/XR/features/WebXRDOMOverlay.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRDOMOverlay =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRDOMOverlay", "@babylonjs/core/XR/features/WebXRDOMOverlay.pure.js")>]
    let ``RegisterWebXRDOMOverlay``: FunctionBinding_RegisterWebXRDOMOverlay = jsNative

    /// @babylonjs/core/XR/features/WebXREyeTracking.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXREyeTracking =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXREyeTracking", "@babylonjs/core/XR/features/WebXREyeTracking.pure.js")>]
    let ``RegisterWebXREyeTracking``: FunctionBinding_RegisterWebXREyeTracking = jsNative

    /// @babylonjs/core/XR/features/WebXRFeaturePointSystem.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRFeaturePointSystem =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRFeaturePointSystem", "@babylonjs/core/XR/features/WebXRFeaturePointSystem.pure.js")>]
    let ``RegisterWebXRFeaturePointSystem``: FunctionBinding_RegisterWebXRFeaturePointSystem = jsNative

    /// @babylonjs/core/XR/motionController/webXRGenericHandController.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRGenericHandController =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRGenericHandController", "@babylonjs/core/XR/motionController/webXRGenericHandController.pure.js")>]
    let ``RegisterWebXRGenericHandController``: FunctionBinding_RegisterWebXRGenericHandController = jsNative

    /// @babylonjs/core/XR/features/WebXRHandTracking.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRHandTracking =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRHandTracking", "@babylonjs/core/XR/features/WebXRHandTracking.pure.js")>]
    let ``RegisterWebXRHandTracking``: FunctionBinding_RegisterWebXRHandTracking = jsNative

    /// @babylonjs/core/XR/features/WebXRHitTest.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRHitTest =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRHitTest", "@babylonjs/core/XR/features/WebXRHitTest.pure.js")>]
    let ``RegisterWebXRHitTest``: FunctionBinding_RegisterWebXRHitTest = jsNative

    /// @babylonjs/core/XR/motionController/webXRHTCViveMotionController.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRHTCViveMotionController =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRHTCViveMotionController", "@babylonjs/core/XR/motionController/webXRHTCViveMotionController.pure.js")>]
    let ``RegisterWebXRHTCViveMotionController``: FunctionBinding_RegisterWebXRHTCViveMotionController = jsNative

    /// @babylonjs/core/XR/features/WebXRImageTracking.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRImageTracking =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRImageTracking", "@babylonjs/core/XR/features/WebXRImageTracking.pure.js")>]
    let ``RegisterWebXRImageTracking``: FunctionBinding_RegisterWebXRImageTracking = jsNative

    /// @babylonjs/core/XR/features/WebXRLayers.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRLayers =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRLayers", "@babylonjs/core/XR/features/WebXRLayers.pure.js")>]
    let ``RegisterWebXRLayers``: FunctionBinding_RegisterWebXRLayers = jsNative

    /// @babylonjs/core/XR/features/WebXRLightEstimation.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRLightEstimation =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRLightEstimation", "@babylonjs/core/XR/features/WebXRLightEstimation.pure.js")>]
    let ``RegisterWebXRLightEstimation``: FunctionBinding_RegisterWebXRLightEstimation = jsNative

    /// @babylonjs/core/XR/features/WebXRMeshDetector.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRMeshDetector =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRMeshDetector", "@babylonjs/core/XR/features/WebXRMeshDetector.pure.js")>]
    let ``RegisterWebXRMeshDetector``: FunctionBinding_RegisterWebXRMeshDetector = jsNative

    /// @babylonjs/core/XR/motionController/webXRMicrosoftMixedRealityController.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRMicrosoftMixedRealityController =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRMicrosoftMixedRealityController", "@babylonjs/core/XR/motionController/webXRMicrosoftMixedRealityController.pure.js")>]
    let ``RegisterWebXRMicrosoftMixedRealityController``: FunctionBinding_RegisterWebXRMicrosoftMixedRealityController = jsNative

    /// @babylonjs/core/XR/motionController/webXRMotionControllerManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRMotionControllerManager =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRMotionControllerManager", "@babylonjs/core/XR/motionController/webXRMotionControllerManager.pure.js")>]
    let ``RegisterWebXRMotionControllerManager``: FunctionBinding_RegisterWebXRMotionControllerManager = jsNative

    /// @babylonjs/core/XR/features/WebXRNearInteraction.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRNearInteraction =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRNearInteraction", "@babylonjs/core/XR/features/WebXRNearInteraction.pure.js")>]
    let ``RegisterWebXRNearInteraction``: FunctionBinding_RegisterWebXRNearInteraction = jsNative

    /// @babylonjs/core/XR/motionController/webXROculusHandController.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXROculusHandController =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXROculusHandController", "@babylonjs/core/XR/motionController/webXROculusHandController.pure.js")>]
    let ``RegisterWebXROculusHandController``: FunctionBinding_RegisterWebXROculusHandController = jsNative

    /// @babylonjs/core/XR/motionController/webXROculusTouchMotionController.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXROculusTouchMotionController =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXROculusTouchMotionController", "@babylonjs/core/XR/motionController/webXROculusTouchMotionController.pure.js")>]
    let ``RegisterWebXROculusTouchMotionController``: FunctionBinding_RegisterWebXROculusTouchMotionController = jsNative

    /// @babylonjs/core/XR/features/WebXRPlaneDetector.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRPlaneDetector =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRPlaneDetector", "@babylonjs/core/XR/features/WebXRPlaneDetector.pure.js")>]
    let ``RegisterWebXRPlaneDetector``: FunctionBinding_RegisterWebXRPlaneDetector = jsNative

    /// @babylonjs/core/XR/features/WebXRRawCameraAccess.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRRawCameraAccess =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRRawCameraAccess", "@babylonjs/core/XR/features/WebXRRawCameraAccess.pure.js")>]
    let ``RegisterWebXRRawCameraAccess``: FunctionBinding_RegisterWebXRRawCameraAccess = jsNative

    /// @babylonjs/core/XR/features/WebXRSpaceWarp.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRSpaceWarp =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRSpaceWarp", "@babylonjs/core/XR/features/WebXRSpaceWarp.pure.js")>]
    let ``RegisterWebXRSpaceWarp``: FunctionBinding_RegisterWebXRSpaceWarp = jsNative

    /// @babylonjs/core/XR/features/WebXRWalkingLocomotion.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWebXRWalkingLocomotion =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWebXRWalkingLocomotion", "@babylonjs/core/XR/features/WebXRWalkingLocomotion.pure.js")>]
    let ``RegisterWebXRWalkingLocomotion``: FunctionBinding_RegisterWebXRWalkingLocomotion = jsNative

    /// @babylonjs/core/Materials/Node/Blocks/worleyNoise3DBlock.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RegisterWorleyNoise3DBlock =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("RegisterWorleyNoise3DBlock", "@babylonjs/core/Materials/Node/Blocks/worleyNoise3DBlock.pure.js")>]
    let ``RegisterWorleyNoise3DBlock``: FunctionBinding_RegisterWorleyNoise3DBlock = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ReloadSmartAssetAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``key``: string -> JS.Promise<U2<BabylonjsBindings.SimpleClasses.AssetContainer, BabylonjsBindings.SimpleClasses.BaseTexture>>

    [<Import("ReloadSmartAssetAsync", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``ReloadSmartAssetAsync``: FunctionBinding_ReloadSmartAssetAsync = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_RemoveSmartAssetAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``key``: string -> JS.Promise<unit>

    [<Import("RemoveSmartAssetAsync", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``RemoveSmartAssetAsync``: FunctionBinding_RemoveSmartAssetAsync = jsNative

    /// @babylonjs/core/Meshes/meshUtils
    [<AllowNullLiteral>]
    type FunctionBinding_RemoveUnreferencedVerticesData =
        [<Emit("$0($1...)")>] abstract Invoke: ``meshes``: System.Collections.Generic.IReadOnlyList<BabylonjsBindings.SimpleClasses.Mesh> -> unit

    [<Import("RemoveUnreferencedVerticesData", "@babylonjs/core/Meshes/meshUtils.js")>]
    let ``RemoveUnreferencedVerticesData``: FunctionBinding_RemoveUnreferencedVerticesData = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Repeat =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float * ``length``: float -> float

    [<Import("Repeat", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``Repeat``: FunctionBinding_Repeat = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding_RequestFullscreen =
        [<Emit("$0($1...)")>] abstract Invoke: ``element``: Browser.Types.HTMLElement -> unit

    [<Import("RequestFullscreen", "@babylonjs/core/Engines/engine.common.js")>]
    let ``RequestFullscreen``: FunctionBinding_RequestFullscreen = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding_RequestPointerlock =
        [<Emit("$0($1...)")>] abstract Invoke: ``element``: Browser.Types.HTMLElement -> unit

    [<Import("RequestPointerlock", "@babylonjs/core/Engines/engine.common.js")>]
    let ``RequestPointerlock``: FunctionBinding_RequestPointerlock = jsNative

    /// @babylonjs/core/Materials/effect.functions
    [<AllowNullLiteral>]
    type FunctionBinding_resetCachedPipeline =
        [<Emit("$0($1...)")>] abstract Invoke: ``pipeline``: BabylonjsBindings.SimpleInterfaces.IPipelineContext -> unit

    [<Import("resetCachedPipeline", "@babylonjs/core/Materials/effect.functions.js")>]
    let ``resetCachedPipeline``: FunctionBinding_resetCachedPipeline = jsNative

    /// @babylonjs/core/Materials/floatingOriginMatrixOverrides
    [<AllowNullLiteral>]
    type FunctionBinding_ResetMatrixFunctions =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("ResetMatrixFunctions", "@babylonjs/core/Materials/floatingOriginMatrixOverrides.js")>]
    let ``ResetMatrixFunctions``: FunctionBinding_ResetMatrixFunctions = jsNative

    /// @babylonjs/core/Engines/engine.common
    [<AllowNullLiteral>]
    type FunctionBinding_ResizeImageBitmap =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``image``: U2<Browser.Types.HTMLImageElement, BabylonjsBindings.SimpleInterfaces.BrowserImageBitmap> * ``bufferWidth``: float * ``bufferHeight``: float -> JS.Uint8Array

    [<Import("ResizeImageBitmap", "@babylonjs/core/Engines/engine.common.js")>]
    let ``ResizeImageBitmap``: FunctionBinding_ResizeImageBitmap = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetSerializer
    [<AllowNullLiteral>]
    type FunctionBinding_ResolveAssetUrl =
        [<Emit("$0($1...)")>] abstract Invoke: ``assetUrl``: string * ``baseUrl``: string -> string

    [<Import("ResolveAssetUrl", "@babylonjs/core/SmartAssets/smartAssetSerializer.js")>]
    let ``ResolveAssetUrl``: FunctionBinding_ResolveAssetUrl = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.huf
    [<AllowNullLiteral>]
    type FunctionBinding_ReverseLutFromBitmap =
        [<Emit("$0($1...)")>] abstract Invoke: ``bitmap``: JS.Uint8Array * ``lut``: JS.Uint16Array -> float

    [<Import("ReverseLutFromBitmap", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.huf.js")>]
    let ``ReverseLutFromBitmap``: FunctionBinding_ReverseLutFromBitmap = jsNative

    /// @babylonjs/core/Misc/HighDynamicRange/hdr
    [<AllowNullLiteral>]
    type FunctionBinding_RGBE_ReadHeader =
        [<Emit("$0($1...)")>] abstract Invoke: ``uint8array``: JS.Uint8Array -> BabylonjsBindings.SimpleInterfaces.HDRInfo

    [<Import("RGBE_ReadHeader", "@babylonjs/core/Misc/HighDynamicRange/hdr.js")>]
    let ``RGBE_ReadHeader``: FunctionBinding_RGBE_ReadHeader = jsNative

    /// @babylonjs/core/Misc/HighDynamicRange/hdr
    [<AllowNullLiteral>]
    type FunctionBinding_RGBE_ReadPixels =
        [<Emit("$0($1...)")>] abstract Invoke: ``uint8array``: JS.Uint8Array * ``hdrInfo``: BabylonjsBindings.SimpleInterfaces.HDRInfo -> JS.Float32Array

    [<Import("RGBE_ReadPixels", "@babylonjs/core/Misc/HighDynamicRange/hdr.js")>]
    let ``RGBE_ReadPixels``: FunctionBinding_RGBE_ReadPixels = jsNative

    /// @babylonjs/core/Misc/coroutine
    [<AllowNullLiteral>]
    type FunctionBinding_runCoroutine =
        [<Emit("$0($1...)")>] abstract Invoke<'T>: ``coroutine``: BabylonjsBindings.TypeAliases.AsyncCoroutine<'T> * ``scheduler``: BabylonjsBindings.TypeAliases.CoroutineScheduler<'T> * ``onSuccess``: System.Action<'T> * ``onError``: System.Action<obj> * ?``abortSignal``: BabylonjsBindings.SimpleInterfaces.BrowserAbortSignal -> unit

    [<Import("runCoroutine", "@babylonjs/core/Misc/coroutine.js")>]
    let ``runCoroutine``: FunctionBinding_runCoroutine = jsNative

    /// @babylonjs/core/Misc/coroutine
    [<AllowNullLiteral>]
    type FunctionBinding_runCoroutineAsync =
        [<Emit("$0($1...)")>] abstract Invoke<'T>: ``coroutine``: BabylonjsBindings.TypeAliases.AsyncCoroutine<'T> * ``scheduler``: BabylonjsBindings.TypeAliases.CoroutineScheduler<'T> * ?``abortSignal``: BabylonjsBindings.SimpleInterfaces.BrowserAbortSignal -> JS.Promise<'T>

    [<Import("runCoroutineAsync", "@babylonjs/core/Misc/coroutine.js")>]
    let ``runCoroutineAsync``: FunctionBinding_runCoroutineAsync = jsNative

    /// @babylonjs/core/Misc/coroutine
    [<AllowNullLiteral>]
    type FunctionBinding_runCoroutineSync =
        [<Emit("$0($1...)")>] abstract Invoke<'T>: ``coroutine``: BabylonjsBindings.TypeAliases.Coroutine<'T> * ?``abortSignal``: BabylonjsBindings.SimpleInterfaces.BrowserAbortSignal -> 'T

    [<Import("runCoroutineSync", "@babylonjs/core/Misc/coroutine.js")>]
    let ``runCoroutineSync``: FunctionBinding_runCoroutineSync = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_ScalingMatrixToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``x``: float * ``y``: float * ``z``: float * ``result``: BabylonjsBindings.SimpleInterfaces.IMatrixLike -> unit

    [<Import("ScalingMatrixToRef", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``ScalingMatrixToRef``: FunctionBinding_ScalingMatrixToRef = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.decoder
    [<AllowNullLiteral>]
    type FunctionBinding_ScanData =
        [<Emit("$0($1...)")>] abstract Invoke: ``decoder``: BabylonjsBindings.SimpleInterfaces.IEXRDecoder * ``header``: BabylonjsBindings.SimpleInterfaces.IEXRHeader * ``dataView``: JS.DataView * ``offset``: BabylonjsBindings.SimpleInterfaces.DataCursor -> unit

    [<Import("ScanData", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.decoder.js")>]
    let ``ScanData``: FunctionBinding_ScanData = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serialize =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serialize", "@babylonjs/core/Misc/decorators.js")>]
    let ``serialize``: FunctionBinding_serialize = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsCameraReference =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsCameraReference", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsCameraReference``: FunctionBinding_serializeAsCameraReference = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsColor3 =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsColor3", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsColor3``: FunctionBinding_serializeAsColor3 = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsColor4 =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsColor4", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsColor4``: FunctionBinding_serializeAsColor4 = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsColorCurves =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsColorCurves", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsColorCurves``: FunctionBinding_serializeAsColorCurves = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsFresnelParameters =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsFresnelParameters", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsFresnelParameters``: FunctionBinding_serializeAsFresnelParameters = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsImageProcessingConfiguration =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsImageProcessingConfiguration", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsImageProcessingConfiguration``: FunctionBinding_serializeAsImageProcessingConfiguration = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsMatrix =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsMatrix", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsMatrix``: FunctionBinding_serializeAsMatrix = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsMeshReference =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsMeshReference", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsMeshReference``: FunctionBinding_serializeAsMeshReference = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsQuaternion =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsQuaternion", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsQuaternion``: FunctionBinding_serializeAsQuaternion = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsTexture =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsTexture", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsTexture``: FunctionBinding_serializeAsTexture = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsVector2 =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsVector2", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsVector2``: FunctionBinding_serializeAsVector2 = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsVector3 =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsVector3", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsVector3``: FunctionBinding_serializeAsVector3 = jsNative

    /// @babylonjs/core/Misc/decorators
    [<AllowNullLiteral>]
    type FunctionBinding_serializeAsVector4 =
        [<Emit("$0($1...)")>] abstract Invoke: ?``sourceName``: string -> System.Action<obj, BabylonjsBindings.SimpleInterfaces.BrowserSerializableContext>

    [<Import("serializeAsVector4", "@babylonjs/core/Misc/decorators.js")>]
    let ``serializeAsVector4``: FunctionBinding_serializeAsVector4 = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_SerializeSmartAssetManagerMap =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``baseUrl``: string -> BabylonjsBindings.SimpleInterfaces.ISerializedSmartAssetMap

    [<Import("SerializeSmartAssetManagerMap", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``SerializeSmartAssetManagerMap``: FunctionBinding_SerializeSmartAssetManagerMap = jsNative

    /// @babylonjs/core/Misc/timer
    [<AllowNullLiteral>]
    type FunctionBinding_setAndStartTimer =
        [<Emit("$0($1...)")>] abstract Invoke<'T>: ``options``: BabylonjsBindings.SimpleInterfaces.ITimerOptions<'T> -> BabylonjsBindings.SimpleClasses.Observer<'T> option

    [<Import("setAndStartTimer", "@babylonjs/core/Misc/timer.js")>]
    let ``setAndStartTimer``: FunctionBinding_setAndStartTimer = jsNative

    /// @babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping
    [<AllowNullLiteral>]
    type FunctionBinding_SetInterpolationForKey =
        [<Emit("$0($1...)")>] abstract Invoke: ``key``: string * ?``interpolation``: ResizeArray<BabylonjsBindings.SimpleInterfaces.IInterpolationPropertyInfo> -> unit

    [<Import("SetInterpolationForKey", "@babylonjs/loaders/glTF/2.0/Extensions/objectModelMapping.js")>]
    let ``SetInterpolationForKey``: FunctionBinding_SetInterpolationForKey = jsNative

    /// @babylonjs/core/Compat/compatibilityOptions
    [<AllowNullLiteral>]
    type FunctionBinding_setOpenGLOrientationForUV =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: bool -> unit

    [<Import("setOpenGLOrientationForUV", "@babylonjs/core/Compat/compatibilityOptions.js")>]
    let ``setOpenGLOrientationForUV``: FunctionBinding_setOpenGLOrientationForUV = jsNative

    /// @babylonjs/core/Materials/Node/nodeMaterialDefault
    [<AllowNullLiteral>]
    type FunctionBinding_SetToDefaultGaussianSplatting =
        [<Emit("$0($1...)")>] abstract Invoke: ``nodeMaterial``: BabylonjsBindings.SimpleClasses.NodeMaterial -> unit

    [<Import("SetToDefaultGaussianSplatting", "@babylonjs/core/Materials/Node/nodeMaterialDefault.js")>]
    let ``SetToDefaultGaussianSplatting``: FunctionBinding_SetToDefaultGaussianSplatting = jsNative

    /// @babylonjs/core/Materials/Node/nodeMaterialDefault
    [<AllowNullLiteral>]
    type FunctionBinding_SetToDefaultSFE =
        [<Emit("$0($1...)")>] abstract Invoke: ``nodeMaterial``: BabylonjsBindings.SimpleClasses.NodeMaterial -> unit

    [<Import("SetToDefaultSFE", "@babylonjs/core/Materials/Node/nodeMaterialDefault.js")>]
    let ``SetToDefaultSFE``: FunctionBinding_SetToDefaultSFE = jsNative

    /// @babylonjs/core/Materials/shaderMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ShaderMaterialParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.ShaderMaterial

    [<Import("ShaderMaterialParse", "@babylonjs/core/Materials/shaderMaterial.pure.js")>]
    let ``ShaderMaterialParse``: FunctionBinding_ShaderMaterialParse = jsNative

    /// @babylonjs/core/Materials/shaderMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ShaderMaterialParseFromFileAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string option * ``url``: string * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``rootUrl``: string -> JS.Promise<BabylonjsBindings.SimpleClasses.ShaderMaterial>

    [<Import("ShaderMaterialParseFromFileAsync", "@babylonjs/core/Materials/shaderMaterial.pure.js")>]
    let ``ShaderMaterialParseFromFileAsync``: FunctionBinding_ShaderMaterialParseFromFileAsync = jsNative

    /// @babylonjs/core/Materials/shaderMaterial.pure
    [<AllowNullLiteral>]
    type FunctionBinding_ShaderMaterialParseFromSnippetAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``this``: U2<BabylonjsBindings.SimpleClasses.ShaderMaterialStatic, unit> * ``snippetId``: string * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ?``rootUrl``: string -> JS.Promise<BabylonjsBindings.SimpleClasses.ShaderMaterial>

    [<Import("ShaderMaterialParseFromSnippetAsync", "@babylonjs/core/Materials/shaderMaterial.pure.js")>]
    let ``ShaderMaterialParseFromSnippetAsync``: FunctionBinding_ShaderMaterialParseFromSnippetAsync = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_SmoothStep =
        [<Emit("$0($1...)")>] abstract Invoke: ``from``: float * ``to``: float * ``tx``: float -> float

    [<Import("SmoothStep", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``SmoothStep``: FunctionBinding_SmoothStep = jsNative

    /// @babylonjs/core/Helpers/materialConversionHelper
    [<AllowNullLiteral>]
    type FunctionBinding_SpecularPowerToRoughness =
        [<Emit("$0($1...)")>] abstract Invoke: ``specularPower``: float * ?``p0``: BabylonjsBindings.SimpleClasses.Vector2 * ?``p1``: BabylonjsBindings.SimpleClasses.Vector2 * ?``p2``: BabylonjsBindings.SimpleClasses.Vector2 * ?``p3``: BabylonjsBindings.SimpleClasses.Vector2 -> float

    [<Import("SpecularPowerToRoughness", "@babylonjs/core/Helpers/materialConversionHelper.js")>]
    let ``SpecularPowerToRoughness``: FunctionBinding_SpecularPowerToRoughness = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/ssao2RenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_SSAO2RenderingPipelineParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.SSAO2RenderingPipeline

    [<Import("SSAO2RenderingPipelineParse", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/ssao2RenderingPipeline.pure.js")>]
    let ``SSAO2RenderingPipelineParse``: FunctionBinding_SSAO2RenderingPipelineParse = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/ssrRenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_SSRRenderingPipelineParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.SSRRenderingPipeline

    [<Import("SSRRenderingPipelineParse", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/ssrRenderingPipeline.pure.js")>]
    let ``SSRRenderingPipelineParse``: FunctionBinding_SSRRenderingPipelineParse = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/standardRenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_StandardRenderingPipelineParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.StandardRenderingPipeline

    [<Import("StandardRenderingPipelineParse", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/standardRenderingPipeline.pure.js")>]
    let ``StandardRenderingPipelineParse``: FunctionBinding_StandardRenderingPipelineParse = jsNative

    /// @babylonjs/core/Meshes/mesh.vertexData.subdivide
    [<AllowNullLiteral>]
    type FunctionBinding_Subdivide =
        [<Emit("$0($1...)")>] abstract Invoke: ``vertexData``: BabylonjsBindings.SimpleClasses.VertexData * ``level``: float * ?``options``: BabylonjsBindings.SimpleInterfaces.PartialISubdivideOptions -> BabylonjsBindings.SimpleClasses.VertexData

    [<Import("Subdivide", "@babylonjs/core/Meshes/mesh.vertexData.subdivide.js")>]
    let ``Subdivide``: FunctionBinding_Subdivide = jsNative

    /// @babylonjs/core/PostProcesses/RenderPipeline/Pipelines/taaRenderingPipeline.pure
    [<AllowNullLiteral>]
    type FunctionBinding_TAARenderingPipelineParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``source``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.TAARenderingPipeline

    [<Import("TAARenderingPipelineParse", "@babylonjs/core/PostProcesses/RenderPipeline/Pipelines/taaRenderingPipeline.pure.js")>]
    let ``TAARenderingPipelineParse``: FunctionBinding_TAARenderingPipelineParse = jsNative

    /// @babylonjs/core/Materials/Textures/textureCreationOptions
    [<AllowNullLiteral>]
    type FunctionBinding_textureSizeIsObject =
        [<Emit("$0($1...)")>] abstract Invoke: ``size``: BabylonjsBindings.TypeAliases.TextureSize -> bool

    [<Import("textureSizeIsObject", "@babylonjs/core/Materials/Textures/textureCreationOptions.js")>]
    let ``textureSizeIsObject``: FunctionBinding_textureSizeIsObject = jsNative

    /// @babylonjs/core/Misc/halfFloat
    [<AllowNullLiteral>]
    type FunctionBinding_ToHalfFloat =
        [<Emit("$0($1...)")>] abstract Invoke: ``value``: float -> float

    [<Import("ToHalfFloat", "@babylonjs/core/Misc/halfFloat.js")>]
    let ``ToHalfFloat``: FunctionBinding_ToHalfFloat = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_ToHex =
        [<Emit("$0($1...)")>] abstract Invoke: ``i``: float -> string

    [<Import("ToHex", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``ToHex``: FunctionBinding_ToHex = jsNative

    /// @babylonjs/core/Meshes/transformNode.pure
    [<AllowNullLiteral>]
    type FunctionBinding_TransformNodeParse =
        [<Emit("$0($1...)")>] abstract Invoke: ``parsedTransformNode``: obj * ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``rootUrl``: string -> BabylonjsBindings.SimpleClasses.TransformNode

    [<Import("TransformNodeParse", "@babylonjs/core/Meshes/transformNode.pure.js")>]
    let ``TransformNodeParse``: FunctionBinding_TransformNodeParse = jsNative

    /// @babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions
    [<AllowNullLiteral>]
    type FunctionBinding_TranslationMatrixToRef =
        [<Emit("$0($1...)")>] abstract Invoke: ``x``: float * ``y``: float * ``z``: float * ``result``: BabylonjsBindings.SimpleInterfaces.IMatrixLike -> unit

    [<Import("TranslationMatrixToRef", "@babylonjs/core/Maths/ThinMaths/thinMath.matrix.functions.js")>]
    let ``TranslationMatrixToRef``: FunctionBinding_TranslationMatrixToRef = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression
    [<AllowNullLiteral>]
    type FunctionBinding_UncompressPIZ =
        [<Emit("$0($1...)")>] abstract Invoke: ``decoder``: BabylonjsBindings.SimpleInterfaces.IEXRDecoder -> JS.DataView

    [<Import("UncompressPIZ", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.js")>]
    let ``UncompressPIZ``: FunctionBinding_UncompressPIZ = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression
    [<AllowNullLiteral>]
    type FunctionBinding_UncompressPXR =
        [<Emit("$0($1...)")>] abstract Invoke: ``decoder``: BabylonjsBindings.SimpleInterfaces.IEXRDecoder -> JS.DataView

    [<Import("UncompressPXR", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.js")>]
    let ``UncompressPXR``: FunctionBinding_UncompressPXR = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression
    [<AllowNullLiteral>]
    type FunctionBinding_UncompressRAW =
        [<Emit("$0($1...)")>] abstract Invoke: ``decoder``: BabylonjsBindings.SimpleInterfaces.IEXRDecoder -> JS.DataView

    [<Import("UncompressRAW", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.js")>]
    let ``UncompressRAW``: FunctionBinding_UncompressRAW = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression
    [<AllowNullLiteral>]
    type FunctionBinding_UncompressRLE =
        [<Emit("$0($1...)")>] abstract Invoke: ``decoder``: BabylonjsBindings.SimpleInterfaces.IEXRDecoder -> JS.DataView

    [<Import("UncompressRLE", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.js")>]
    let ``UncompressRLE``: FunctionBinding_UncompressRLE = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression
    [<AllowNullLiteral>]
    type FunctionBinding_UncompressZIP =
        [<Emit("$0($1...)")>] abstract Invoke: ``decoder``: BabylonjsBindings.SimpleInterfaces.IEXRDecoder -> JS.DataView

    [<Import("UncompressZIP", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.js")>]
    let ``UncompressZIP``: FunctionBinding_UncompressZIP = jsNative

    /// @babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill
    [<AllowNullLiteral>]
    type FunctionBinding_UninstallHtmlInCanvasPolyfill =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("UninstallHtmlInCanvasPolyfill", "@babylonjs/core/Materials/Textures/HTML/htmlInCanvasPolyfill.js")>]
    let ``UninstallHtmlInCanvasPolyfill``: FunctionBinding_UninstallHtmlInCanvasPolyfill = jsNative

    /// @babylonjs/core/SmartAssets/smartAssetManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_UnloadSmartAssetAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``scene``: BabylonjsBindings.SimpleClasses.Scene * ``key``: string -> JS.Promise<unit>

    [<Import("UnloadSmartAssetAsync", "@babylonjs/core/SmartAssets/smartAssetManager.pure.js")>]
    let ``UnloadSmartAssetAsync``: FunctionBinding_UnloadSmartAssetAsync = jsNative

    /// @babylonjs/core/Materials/materialPluginManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_UnregisterAllMaterialPlugins =
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    [<Import("UnregisterAllMaterialPlugins", "@babylonjs/core/Materials/materialPluginManager.pure.js")>]
    let ``UnregisterAllMaterialPlugins``: FunctionBinding_UnregisterAllMaterialPlugins = jsNative

    /// @babylonjs/loaders/glTF/2.0/glTFLoaderExtensionRegistry
    [<AllowNullLiteral>]
    type FunctionBinding_unregisterGLTFExtension =
        [<Emit("$0($1...)")>] abstract Invoke: ``name``: string -> bool

    [<Import("unregisterGLTFExtension", "@babylonjs/loaders/glTF/2.0/glTFLoaderExtensionRegistry.js")>]
    let ``unregisterGLTFExtension``: FunctionBinding_unregisterGLTFExtension = jsNative

    /// @babylonjs/core/Materials/materialPluginManager.pure
    [<AllowNullLiteral>]
    type FunctionBinding_UnregisterMaterialPlugin =
        [<Emit("$0($1...)")>] abstract Invoke: ``pluginName``: string -> bool

    [<Import("UnregisterMaterialPlugin", "@babylonjs/core/Materials/materialPluginManager.pure.js")>]
    let ``UnregisterMaterialPlugin``: FunctionBinding_UnregisterMaterialPlugin = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/textureLoaderManager
    [<AllowNullLiteral>]
    type FunctionBinding_unregisterTextureLoader =
        [<Emit("$0($1...)")>] abstract Invoke: ``extension``: string -> bool

    [<Import("unregisterTextureLoader", "@babylonjs/core/Materials/Textures/Loaders/textureLoaderManager.js")>]
    let ``unregisterTextureLoader``: FunctionBinding_unregisterTextureLoader = jsNative

    /// @babylonjs/core/Misc/tga
    [<AllowNullLiteral>]
    type FunctionBinding_UploadContent =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``data``: JS.Uint8Array -> unit

    [<Import("UploadContent", "@babylonjs/core/Misc/tga.js")>]
    let ``UploadContent``: FunctionBinding_UploadContent = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_UploadEnvLevelsAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``data``: JS.ArrayBufferView * ``info``: BabylonjsBindings.TypeAliases.EnvironmentTextureInfo -> JS.Promise<ResizeArray<unit>>

    [<Import("UploadEnvLevelsAsync", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``UploadEnvLevelsAsync``: FunctionBinding_UploadEnvLevelsAsync = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_UploadEnvSpherical =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``info``: BabylonjsBindings.TypeAliases.EnvironmentTextureInfo -> unit

    [<Import("UploadEnvSpherical", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``UploadEnvSpherical``: FunctionBinding_UploadEnvSpherical = jsNative

    /// @babylonjs/core/Materials/Textures/HTML/htmlTexture
    [<AllowNullLiteral>]
    type FunctionBinding_UploadHtmlElementToTexture =
        [<Emit("$0($1...)")>] abstract Invoke: ``engine``: BabylonjsBindings.SimpleClasses.AbstractEngine * ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture option * ``element``: U2<Browser.Types.Element, BabylonjsBindings.SimpleInterfaces.BrowserElementImage> * ?``invertY``: bool * ?``config``: BabylonjsBindings.SimpleInterfaces.BrowserWebGLCopyElementImageConfig -> bool

    [<Import("UploadHtmlElementToTexture", "@babylonjs/core/Materials/Textures/HTML/htmlTexture.js")>]
    let ``UploadHtmlElementToTexture``: FunctionBinding_UploadHtmlElementToTexture = jsNative

    /// @babylonjs/core/Materials/Textures/rawTexture2DArray.functions
    [<AllowNullLiteral>]
    type FunctionBinding_UploadImageToTexture2DArrayLayer =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.RawTexture2DArray * ``source``: BabylonjsBindings.TypeAliases.ImageSource * ``layer``: float * ?``options``: BabylonjsBindings.SimpleInterfaces.IUploadImageToTexture2DArrayLayerOptions -> unit

    [<Import("UploadImageToTexture2DArrayLayer", "@babylonjs/core/Materials/Textures/rawTexture2DArray.functions.js")>]
    let ``UploadImageToTexture2DArrayLayer``: FunctionBinding_UploadImageToTexture2DArrayLayer = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_UploadIrradianceLevelsAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``mainTexture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``imageData``: ResizeArray<JS.ArrayBufferView> * ``size``: float * ?``imageType``: string * ?``dominantDirection``: BabylonjsBindings.SimpleClasses.Vector3 option -> JS.Promise<unit>

    [<Import("UploadIrradianceLevelsAsync", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``UploadIrradianceLevelsAsync``: FunctionBinding_UploadIrradianceLevelsAsync = jsNative

    /// @babylonjs/core/Misc/environmentTextureTools.pure
    [<AllowNullLiteral>]
    type FunctionBinding_UploadRadianceLevelsAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.InternalTexture * ``imageData``: ResizeArray<ResizeArray<JS.ArrayBufferView>> * ?``imageType``: string -> JS.Promise<unit>

    [<Import("UploadRadianceLevelsAsync", "@babylonjs/core/Misc/environmentTextureTools.pure.js")>]
    let ``UploadRadianceLevelsAsync``: FunctionBinding_UploadRadianceLevelsAsync = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphValidator
    [<AllowNullLiteral>]
    type FunctionBinding_ValidateFlowGraph =
        [<Emit("$0($1...)")>] abstract Invoke: ``flowGraph``: BabylonjsBindings.SimpleClasses.FlowGraph -> BabylonjsBindings.SimpleInterfaces.IFlowGraphValidationResult

    [<Import("ValidateFlowGraph", "@babylonjs/core/FlowGraph/flowGraphValidator.js")>]
    let ``ValidateFlowGraph``: FunctionBinding_ValidateFlowGraph = jsNative

    /// @babylonjs/core/FlowGraph/flowGraphValidator
    [<AllowNullLiteral>]
    type FunctionBinding_ValidateFlowGraphWithBlockList =
        [<Emit("$0($1...)")>] abstract Invoke: ``flowGraph``: BabylonjsBindings.SimpleClasses.FlowGraph * ``allKnownBlocks``: ResizeArray<BabylonjsBindings.SimpleClasses.FlowGraphBlock> -> BabylonjsBindings.SimpleInterfaces.IFlowGraphValidationResult

    [<Import("ValidateFlowGraphWithBlockList", "@babylonjs/core/FlowGraph/flowGraphValidator.js")>]
    let ``ValidateFlowGraphWithBlockList``: FunctionBinding_ValidateFlowGraphWithBlockList = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector2ToFixed =
        [<Emit("$0($1...)")>] abstract Invoke: ``vector``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector2Like * ``decimalCount``: float -> string

    [<Import("Vector2ToFixed", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector2ToFixed``: FunctionBinding_Vector2ToFixed = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3CopyToRef =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.IVector3Like>: ``source``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``result``: 'T -> 'T

    [<Import("Vector3CopyToRef", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3CopyToRef``: FunctionBinding_Vector3CopyToRef = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3Distance =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``b``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like -> float

    [<Import("Vector3Distance", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3Distance``: FunctionBinding_Vector3Distance = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3DistanceSquared =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``b``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like -> float

    [<Import("Vector3DistanceSquared", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3DistanceSquared``: FunctionBinding_Vector3DistanceSquared = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3Dot =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``b``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like -> float

    [<Import("Vector3Dot", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3Dot``: FunctionBinding_Vector3Dot = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3FromFloatsToRef =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.IVector3Like>: ``x``: float * ``y``: float * ``z``: float * ``result``: 'T -> 'T

    [<Import("Vector3FromFloatsToRef", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3FromFloatsToRef``: FunctionBinding_Vector3FromFloatsToRef = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3Length =
        [<Emit("$0($1...)")>] abstract Invoke: ``vector``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like -> float

    [<Import("Vector3Length", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3Length``: FunctionBinding_Vector3Length = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3LengthSquared =
        [<Emit("$0($1...)")>] abstract Invoke: ``vector``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like -> float

    [<Import("Vector3LengthSquared", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3LengthSquared``: FunctionBinding_Vector3LengthSquared = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3LerpToRef =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.IVector3Like>: ``start``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``end``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``amount``: float * ``result``: 'T -> 'T

    [<Import("Vector3LerpToRef", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3LerpToRef``: FunctionBinding_Vector3LerpToRef = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3NormalizeToRef =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.IVector3Like>: ``vector``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``result``: 'T -> 'T

    [<Import("Vector3NormalizeToRef", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3NormalizeToRef``: FunctionBinding_Vector3NormalizeToRef = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3ScaleInPlace =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.IVector3Like>: ``vector``: 'T * ``scale``: float -> 'T

    [<Import("Vector3ScaleInPlace", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3ScaleInPlace``: FunctionBinding_Vector3ScaleInPlace = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3ScaleToRef =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.IVector3Like>: ``a``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``scale``: float * ``result``: 'T -> 'T

    [<Import("Vector3ScaleToRef", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3ScaleToRef``: FunctionBinding_Vector3ScaleToRef = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3SignedDistanceToPlaneFromPositionAndNormal =
        [<Emit("$0($1...)")>] abstract Invoke: ``origin``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``normal``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``point``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like -> float

    [<Import("Vector3SignedDistanceToPlaneFromPositionAndNormal", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3SignedDistanceToPlaneFromPositionAndNormal``: FunctionBinding_Vector3SignedDistanceToPlaneFromPositionAndNormal = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3SubtractToRef =
        [<Emit("$0($1...)")>] abstract Invoke<'T when 'T :> BabylonjsBindings.SimpleInterfaces.IVector3Like>: ``a``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``b``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``result``: 'T -> 'T

    [<Import("Vector3SubtractToRef", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3SubtractToRef``: FunctionBinding_Vector3SubtractToRef = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector3ToFixed =
        [<Emit("$0($1...)")>] abstract Invoke: ``vector``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector3Like * ``decimalCount``: float -> string

    [<Import("Vector3ToFixed", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector3ToFixed``: FunctionBinding_Vector3ToFixed = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector4Dot =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector4Like * ``b``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector4Like -> float

    [<Import("Vector4Dot", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector4Dot``: FunctionBinding_Vector4Dot = jsNative

    /// @babylonjs/core/Maths/math.vector.functions
    [<AllowNullLiteral>]
    type FunctionBinding_Vector4ToFixed =
        [<Emit("$0($1...)")>] abstract Invoke: ``vector``: BabylonjsBindings.SimpleInterfaces.DeepImmutableIVector4Like * ``decimalCount``: float -> string

    [<Import("Vector4ToFixed", "@babylonjs/core/Maths/math.vector.functions.js")>]
    let ``Vector4ToFixed``: FunctionBinding_Vector4ToFixed = jsNative

    /// @babylonjs/core/Buffers/buffer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_VertexBufferDeduceStride =
        [<Emit("$0($1...)")>] abstract Invoke: ``kind``: string -> float

    [<Import("VertexBufferDeduceStride", "@babylonjs/core/Buffers/buffer.pure.js")>]
    let ``VertexBufferDeduceStride``: FunctionBinding_VertexBufferDeduceStride = jsNative

    /// @babylonjs/core/Buffers/buffer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_VertexBufferForEach =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: BabylonjsBindings.TypeAliases.DataArray * ``byteOffset``: float * ``byteStride``: float * ``componentCount``: float * ``componentType``: float * ``count``: float * ``normalized``: bool * ``callback``: System.Action<float, float> -> unit

    [<Import("VertexBufferForEach", "@babylonjs/core/Buffers/buffer.pure.js")>]
    let ``VertexBufferForEach``: FunctionBinding_VertexBufferForEach = jsNative

    /// @babylonjs/core/Buffers/buffer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_VertexBufferGetDataType =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: BabylonjsBindings.TypeAliases.DataArray -> float

    [<Import("VertexBufferGetDataType", "@babylonjs/core/Buffers/buffer.pure.js")>]
    let ``VertexBufferGetDataType``: FunctionBinding_VertexBufferGetDataType = jsNative

    /// @babylonjs/core/Buffers/buffer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_VertexBufferGetFloatData =
        [<Emit("$0($1...)")>] abstract Invoke: ``data``: BabylonjsBindings.TypeAliases.DataArray * ``size``: float * ``type``: float * ``byteOffset``: float * ``byteStride``: float * ``normalized``: bool * ``totalVertices``: float * ?``forceCopy``: bool -> BabylonjsBindings.TypeAliases.FloatArray

    [<Import("VertexBufferGetFloatData", "@babylonjs/core/Buffers/buffer.pure.js")>]
    let ``VertexBufferGetFloatData``: FunctionBinding_VertexBufferGetFloatData = jsNative

    /// @babylonjs/core/Buffers/buffer.pure
    [<AllowNullLiteral>]
    type FunctionBinding_VertexBufferGetTypeByteLength =
        [<Emit("$0($1...)")>] abstract Invoke: ``type``: float -> float

    [<Import("VertexBufferGetTypeByteLength", "@babylonjs/core/Buffers/buffer.pure.js")>]
    let ``VertexBufferGetTypeByteLength``: FunctionBinding_VertexBufferGetTypeByteLength = jsNative

    /// @babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.huf
    [<AllowNullLiteral>]
    type FunctionBinding_Wav2Decode =
        [<Emit("$0($1...)")>] abstract Invoke: ``buffer``: JS.Uint16Array * ``j``: float * ``nx``: float * ``ox``: float * ``ny``: float * ``oy``: float * ``mx``: float -> float option

    [<Import("Wav2Decode", "@babylonjs/core/Materials/Textures/Loaders/EXR/exrLoader.compression.huf.js")>]
    let ``Wav2Decode``: FunctionBinding_Wav2Decode = jsNative

    /// @babylonjs/core/XR/features/WebXRNearInteraction.pure
    [<AllowNullLiteral>]
    type FunctionBinding_WebXRNearInteractionPickMeshWithSphere =
        [<Emit("$0($1...)")>] abstract Invoke: ``mesh``: BabylonjsBindings.SimpleClasses.AbstractMesh * ``sphere``: BabylonjsBindings.SimpleClasses.BoundingSphere * ?``skipBoundingInfo``: bool -> BabylonjsBindings.SimpleClasses.PickingInfo

    [<Import("WebXRNearInteractionPickMeshWithSphere", "@babylonjs/core/XR/features/WebXRNearInteraction.pure.js")>]
    let ``WebXRNearInteractionPickMeshWithSphere``: FunctionBinding_WebXRNearInteractionPickMeshWithSphere = jsNative

    /// @babylonjs/core/Misc/textureTools
    [<AllowNullLiteral>]
    type FunctionBinding_WhenTextureReadyAsync =
        [<Emit("$0($1...)")>] abstract Invoke: ``texture``: BabylonjsBindings.SimpleClasses.BaseTexture -> JS.Promise<unit>

    [<Import("WhenTextureReadyAsync", "@babylonjs/core/Misc/textureTools.js")>]
    let ``WhenTextureReadyAsync``: FunctionBinding_WhenTextureReadyAsync = jsNative

    /// @babylonjs/core/Maths/math.scalar.functions
    [<AllowNullLiteral>]
    type FunctionBinding_WithinEpsilon =
        [<Emit("$0($1...)")>] abstract Invoke: ``a``: float * ``b``: float * ?``epsilon``: float -> bool

    [<Import("WithinEpsilon", "@babylonjs/core/Maths/math.scalar.functions.js")>]
    let ``WithinEpsilon``: FunctionBinding_WithinEpsilon = jsNative

    /// @babylonjs/core/Misc/khronosTextureContainer2Worker
    [<AllowNullLiteral>]
    type FunctionBinding_workerFunction =
        [<Emit("$0($1...)")>] abstract Invoke: ``KTX2DecoderModule``: obj -> unit

    [<Import("workerFunction", "@babylonjs/core/Misc/khronosTextureContainer2Worker.js")>]
    let ``workerFunction``: FunctionBinding_workerFunction = jsNative
