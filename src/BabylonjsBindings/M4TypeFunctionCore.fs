namespace BabylonjsBindings

open Fable.Core
open BabylonjsBindings.TypeAliases
open BabylonjsBindings.SimpleInterfaces
open BabylonjsBindings.SimpleClasses

/// Closed-world projections of Babylon.js type functions for the locked 9.19.0 declaration closure.
module TypeFunctionCore =

    /// A compile-time witness that a unary TypeScript type function maps input to result.
    [<AllowNullLiteral>]
    type TypeFunction1<'Input, 'Result> =
        interface end

    /// A compile-time witness that a binary TypeScript type function maps both inputs to result.
    [<AllowNullLiteral>]
    type TypeFunction2<'Left, 'Right, 'Result> =
        interface end

    // F# has no type functions. These public witnesses retain the upstream names while the
    // deterministic M4 registry records every concrete use and its expanded maintained shape.
    type Shift<'T, 'Result> = TypeFunction1<'T, 'Result>
    type First<'T, 'Result> = TypeFunction1<'T, 'Result>
    type Unshift<'T, 'A, 'Result> = TypeFunction2<'T, 'A, 'Result>
    type Pop<'T, 'Result> = TypeFunction1<'T, 'Result>
    type Last<'T, 'Result> = TypeFunction1<'T, 'Result>
    type Push<'T, 'A, 'Result> = TypeFunction2<'T, 'A, 'Result>
    type Concat<'A, 'B, 'Result> = TypeFunction2<'A, 'B, 'Result>
    type Remove<'A, 'B, 'Result> = TypeFunction2<'A, 'B, 'Result>
    type Length<'T, 'Result> = TypeFunction1<'T, 'Result>
    type FromLength<'N, 'Result> = TypeFunction1<'N, 'Result>
    type Increment<'N, 'Result> = TypeFunction1<'N, 'Result>
    type Decrement<'N, 'Result> = TypeFunction1<'N, 'Result>
    type Add<'A, 'B, 'Result> = TypeFunction2<'A, 'B, 'Result>
    type Subtract<'A, 'B, 'Result> = TypeFunction2<'A, 'B, 'Result>
    type Member<'T, 'Depth, 'Result> = TypeFunction2<'T, 'Depth, 'Result>
    type FlattenArray<'T, 'Depth, 'Result> = TypeFunction2<'T, 'Depth, 'Result>
    type IsTuple<'T, 'Result> = TypeFunction1<'T, 'Result>
    type FlattenTuple<'T, 'Result> = TypeFunction1<'T, 'Result>
    type Flatten<'T, 'Result> = TypeFunction1<'T, 'Result>
    type Tuple<'T, 'Length, 'Result> = TypeFunction2<'T, 'Length, 'Result>
    type Immutable<'T, 'Result> = TypeFunction1<'T, 'Result>
    type DeepImmutable<'T, 'Result> = TypeFunction1<'T, 'Result>
    type NonNullableFields<'T, 'Result> = TypeFunction1<'T, 'Result>
    type WritableObject<'T, 'Result> = TypeFunction1<'T, 'Result>
    type DeepImmutableObject<'T, 'Result> = TypeFunction1<'T, 'Result>
    type Constructor<'Constructor, 'Instance> = TypeFunction1<'Constructor, 'Instance>

    // Numeric literal witnesses keep dimension values distinct in F# overload resolution.
    type N2 = | Value = 2
    type N3 = | Value = 3
    type N4 = | Value = 4
    type N16 = | Value = 16

    type FloatTuple2 = float * float
    type FloatTuple3 = float * float * float
    type FloatTuple4 = float * float * float * float
    type FloatTuple16 =
        float * float * float * float * float * float * float * float *
        float * float * float * float * float * float * float * float
    type Matrix4Values = FloatTuple4 * FloatTuple4 * FloatTuple4 * FloatTuple4

    /// Exact closed-world witness for the computed dimension of a tensor value.
    type Dimension<'TensorValue, 'Shape> = TypeFunction1<'TensorValue, 'Shape>
    /// Exact closed-world witness for extracting the coordinate value from a tensor.
    type ValueOfTensor<'Tensor, 'Value> = TypeFunction1<'Tensor, 'Value>
    /// Exact closed-world witness for extracting the structural input type from a tensor.
    type TensorLike<'Tensor, 'Like> = TypeFunction1<'Tensor, 'Like>

    [<AllowNullLiteral>]
    type Tensor<'Value, 'Like, 'Shape, 'Coordinates, 'Self> =
        abstract dimension: 'Shape with get
        abstract rank: float with get
        abstract getClassName: unit -> string
        abstract getHashCode: unit -> float
        abstract toArray: array: FloatArray * ?index: float -> 'Self
        abstract fromArray: array: FloatArray * ?index: float -> 'Self
        abstract asArray: unit -> 'Coordinates
        abstract copyFrom: source: 'Like -> 'Self
        [<Emit("$0.copyFromFloats(...$1)")>] abstract copyFromFloats: coordinates: 'Coordinates -> 'Self
        [<Emit("$0.set(...$1)")>] abstract set: coordinates: 'Coordinates -> 'Self
        abstract setAll: value: float -> 'Self
        abstract add: other: 'Like -> 'Self
        abstract addToRef: other: 'Like * result: 'Self -> 'Self
        abstract addInPlace: other: 'Like -> 'Self
        [<Emit("$0.addInPlaceFromFloats(...$1)")>] abstract addInPlaceFromFloats: coordinates: 'Coordinates -> 'Self
        abstract subtract: other: 'Like -> 'Self
        abstract subtractToRef: other: 'Like * result: 'Self -> 'Self
        abstract subtractInPlace: other: 'Like -> 'Self
        [<Emit("$0.subtractFromFloats(...$1)")>] abstract subtractFromFloats: coordinates: 'Coordinates -> 'Self
        abstract multiply: other: 'Like -> 'Self
        abstract multiplyToRef: other: 'Like * result: 'Self -> 'Self
        abstract multiplyInPlace: other: 'Like -> 'Self
        [<Emit("$0.multiplyByFloats(...$1)")>] abstract multiplyByFloats: coordinates: 'Coordinates -> 'Self
        abstract divide: other: 'Like -> 'Self
        abstract divideToRef: other: 'Like * result: 'Self -> 'Self
        abstract divideInPlace: other: 'Like -> 'Self
        abstract minimizeInPlace: other: 'Like -> 'Self
        [<Emit("$0.minimizeInPlaceFromFloats(...$1)")>] abstract minimizeInPlaceFromFloats: coordinates: 'Coordinates -> 'Self
        abstract maximizeInPlace: other: 'Like -> 'Self
        [<Emit("$0.maximizeInPlaceFromFloats(...$1)")>] abstract maximizeInPlaceFromFloats: coordinates: 'Coordinates -> 'Self
        abstract negate: unit -> 'Self
        abstract negateInPlace: unit -> 'Self
        abstract negateToRef: result: 'Self -> 'Self
        abstract scaleInPlace: scale: float -> 'Self
        abstract scale: scale: float -> 'Self
        abstract scaleToRef: scale: float * result: 'Self -> 'Self
        abstract scaleAndAddToRef: scale: float * result: 'Self -> 'Self
        abstract equals: other: 'Like -> bool
        abstract equalsWithEpsilon: other: 'Like * ?epsilon: float -> bool
        [<Emit("$0.equalsToFloats(...$1)")>] abstract equalsToFloats: coordinates: 'Coordinates -> bool
        abstract floor: unit -> 'Self
        abstract floorToRef: result: 'Self -> 'Self
        abstract fract: unit -> 'Self
        abstract fractToRef: result: 'Self -> 'Self
        abstract clone: unit -> 'Self

    [<AllowNullLiteral>]
    type TensorStatic<'Tensor, 'Like, 'Coordinates> =
        [<Emit("new $0(...$1)")>] abstract Create: coordinates: 'Coordinates -> 'Tensor
        abstract prototype: 'Tensor with get
        abstract Random: ?min: float * ?max: float -> 'Tensor
        abstract RandomToRef: min: float option * max: float option * result: 'Tensor -> 'Tensor
        abstract FromArray: array: FloatArray * ?offset: float -> 'Tensor
        abstract FromArrayToRef: array: FloatArray * offset: float * result: 'Tensor -> 'Tensor
        abstract Dot: left: 'Like * right: 'Like -> float
        abstract Minimize: left: 'Like * right: 'Like -> 'Tensor
        abstract Maximize: left: 'Like * right: 'Like -> 'Tensor
        abstract Distance: left: 'Like * right: 'Like -> float
        abstract DistanceSquared: left: 'Like * right: 'Like -> float
        abstract Center: left: 'Like * right: 'Like -> 'Tensor
        abstract CenterToRef: left: 'Like * right: 'Like * result: 'Tensor -> 'Tensor
        abstract Clamp: value: 'Like * min: 'Like * max: 'Like -> 'Tensor
        abstract ClampToRef: value: 'Like * min: 'Like * max: 'Like * result: 'Tensor -> 'Tensor

    [<AllowNullLiteral>]
    type Vector<'Value, 'Like, 'Shape, 'Coordinates, 'Self> =
        inherit Tensor<'Value, 'Like, 'Shape, 'Coordinates, 'Self>
        abstract length: unit -> float
        abstract lengthSquared: unit -> float
        abstract normalize: unit -> 'Self
        abstract normalizeFromLength: length: float -> 'Self
        abstract normalizeToNew: unit -> 'Self
        abstract normalizeToRef: result: 'Self -> 'Self

    [<AllowNullLiteral>]
    type VectorStatic<'Tensor, 'Like, 'Coordinates> =
        inherit TensorStatic<'Tensor, 'Like, 'Coordinates>
        abstract CheckExtends: value: 'Like * min: 'Like * max: 'Like -> unit
        abstract Normalize: vector: 'Tensor -> 'Tensor
        abstract NormalizeToRef: vector: 'Tensor * result: 'Tensor -> 'Tensor

    // The seven tensor/vector implementations reachable from the locked declarations.
    type Vector2Projection = Vector<FloatTuple2, IVector2Like, N2, FloatTuple2, Vector2>
    type Vector3Projection = Vector<FloatTuple3, IVector3Like, N3, FloatTuple3, Vector3>
    type Vector4Projection = Vector<FloatTuple4, IVector4Like, N4, FloatTuple4, Vector4>
    type QuaternionProjection = Vector<FloatTuple4, IQuaternionLike, N4, FloatTuple4, Quaternion>
    type Color3Projection = Vector<FloatTuple3, IColor3Like, N3, FloatTuple3, Color3>
    type Color4Projection = Vector<FloatTuple4, IColor4Like, N4, FloatTuple4, Color4>
    type MatrixProjection = Tensor<Matrix4Values, IMatrixLike, N4 * N4, FloatTuple16, Matrix>
