using System;

namespace GodotEngine
{
    /// <summary>
    /// This class describes a Bezier curve in 3D space. It is mainly used to give a shape to a [Path], but can be manually sampled for other purposes.
    /// It keeps a cache of precalculated points along the curve, to speed further calculations up.
    /// </summary>
    public class Curve3D : Resource
    {
        private const string nativeName = "Curve3D";

        public Curve3D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Curve3D_Ctor(this);
        }

        internal Curve3D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_count");

        /// <summary>
        /// Returns the number of points describing the curve.
        /// </summary>
        public int get_point_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_point");

        /// <summary>
        /// Adds a point to a curve, at position "pos", with control points "in" and "out".
        /// If "atpos" is given, the point is inserted before the point number "atpos", moving that point (and every point after) after the inserted point. If "atpos" is not given, or is an illegal value (atpos <0 or atpos >= [method get_point_count]), the point will be appended at the end of the point list.
        /// <param name="@in">If the param is null, then the default value is new Vector3(0, 0, 0)</param>
        /// <param name="@out">If the param is null, then the default value is new Vector3(0, 0, 0)</param>
        /// </summary>
        public void add_point(Vector3 pos, Nullable<Vector3> @in = null, Nullable<Vector3> @out = null, int atpos = -1)
        {
            Vector3 @in_in = @in.HasValue ? @in.Value : new Vector3(0, 0, 0);
            Vector3 @out_in = @out.HasValue ? @out.Value : new Vector3(0, 0, 0);
            NativeCalls.godot_icall_4_186(method_bind_1, Object.GetPtr(this), ref pos, ref @in_in, ref @out_in, atpos);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_pos");

        /// <summary>
        /// Sets the position for the vertex "idx". If the index is out of bounds, the function sends an error to the console.
        /// </summary>
        public void set_point_pos(int idx, Vector3 pos)
        {
            NativeCalls.godot_icall_2_187(method_bind_2, Object.GetPtr(this), idx, ref pos);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_pos");

        /// <summary>
        /// Returns the position of the vertex "idx". If the index is out of bounds, the function sends an error to the console, and returns (0, 0, 0).
        /// </summary>
        public Vector3 get_point_pos(int idx)
        {
            object ret = NativeCalls.godot_icall_1_21(method_bind_3, Object.GetPtr(this), idx);
            return (Vector3)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_tilt");

        /// <summary>
        /// Sets the tilt angle in radians for the point "idx". If the index is out of bounds, the function sends an error to the console.
        /// The tilt controls the rotation along the look-at axis an object traveling the path would have. In the case of a curve controlling a [PathFollow], this tilt is an offset over the natural tilt the PathFollow calculates.
        /// </summary>
        public void set_point_tilt(int idx, float tilt)
        {
            NativeCalls.godot_icall_2_45(method_bind_4, Object.GetPtr(this), idx, tilt);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_tilt");

        /// <summary>
        /// Returns the tilt angle in radians for the point "idx". If the index is out of bounds, the function sends an error to the console, and returns 0.
        /// </summary>
        public float get_point_tilt(int idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_5, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_in");

        /// <summary>
        /// Sets the position of the control point leading to the vertex "idx". If the index is out of bounds, the function sends an error to the console.
        /// </summary>
        public void set_point_in(int idx, Vector3 pos)
        {
            NativeCalls.godot_icall_2_187(method_bind_6, Object.GetPtr(this), idx, ref pos);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_in");

        /// <summary>
        /// Returns the position of the control point leading to the vertex "idx". If the index is out of bounds, the function sends an error to the console, and returns (0, 0, 0).
        /// </summary>
        public Vector3 get_point_in(int idx)
        {
            object ret = NativeCalls.godot_icall_1_21(method_bind_7, Object.GetPtr(this), idx);
            return (Vector3)ret;
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_out");

        /// <summary>
        /// Sets the position of the control point leading out of the vertex "idx". If the index is out of bounds, the function sends an error to the console.
        /// </summary>
        public void set_point_out(int idx, Vector3 pos)
        {
            NativeCalls.godot_icall_2_187(method_bind_8, Object.GetPtr(this), idx, ref pos);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_out");

        /// <summary>
        /// Returns the position of the control point leading out of the vertex "idx". If the index is out of bounds, the function sends an error to the console, and returns (0, 0, 0).
        /// </summary>
        public Vector3 get_point_out(int idx)
        {
            object ret = NativeCalls.godot_icall_1_21(method_bind_9, Object.GetPtr(this), idx);
            return (Vector3)ret;
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_point");

        /// <summary>
        /// Deletes the point "idx" from the curve. Sends an error to the console if "idx" is out of bounds.
        /// </summary>
        public void remove_point(int idx)
        {
            NativeCalls.godot_icall_1_0(method_bind_10, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear_points");

        public void clear_points()
        {
            NativeCalls.godot_icall_0_8(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "interpolate");

        /// <summary>
        /// Returns the position between the vertex "idx" and the vertex "idx"+1, where "t" controls if the point is the first vertex (t = 0.0), the last vertex (t = 1.0), or in between. Values of "t" outside the range (0.0 >= t  <=1) give strange, but predictable results.
        /// If "idx" is out of bounds it is truncated to the first or last vertex, and "t" is ignored. If the curve has no points, the function sends an error to the console, and returns (0, 0, 0).
        /// </summary>
        public Vector3 interpolate(int idx, float t)
        {
            object ret = NativeCalls.godot_icall_2_188(method_bind_12, Object.GetPtr(this), idx, t);
            return (Vector3)ret;
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "interpolatef");

        /// <summary>
        /// Returns the position at the vertex "fofs". It calls [method interpolate] using the integer part of fofs as "idx", and its fractional part as "t".
        /// </summary>
        public Vector3 interpolatef(float fofs)
        {
            object ret = NativeCalls.godot_icall_1_189(method_bind_13, Object.GetPtr(this), fofs);
            return (Vector3)ret;
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bake_interval");

        /// <summary>
        /// Sets the distance in 3D units between two adjacent cached points. Changing it forces the cache to be recomputed the next time a xxx_baked_xxx function is called. The less distance, the more points the cache will have, and the more memory it will consume, so use with care.
        /// </summary>
        public void set_bake_interval(float distance)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), distance);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bake_interval");

        /// <summary>
        /// Returns the distance between two adjacent cached points.
        /// </summary>
        public float get_bake_interval()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_baked_length");

        /// <summary>
        /// Returns the total length of the curve, based on the cached points. Given enough density (see [method set_bake_interval]), it should be approximate enough.
        /// </summary>
        public float get_baked_length()
        {
            return NativeCalls.godot_icall_0_11(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "interpolate_baked");

        /// <summary>
        /// Returns a point within the curve at position "offset", where "offset" is measured as a distance in 3D units along the curve.
        /// To do that, it finds the two cached points where the "offset" lies between, then interpolates the values. This interpolation is cubic if "cubic" is set to true, or linear if set to false.
        /// Cubic interpolation tends to follow the curves better, but linear is faster (and often, precise enough).
        /// </summary>
        public Vector3 interpolate_baked(float offset, bool cubic = false)
        {
            object ret = NativeCalls.godot_icall_2_190(method_bind_17, Object.GetPtr(this), offset, cubic);
            return (Vector3)ret;
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_baked_points");

        /// <summary>
        /// Returns the cache of points as a [PoolVector3Array].
        /// </summary>
        public Vector3[] get_baked_points()
        {
            return NativeCalls.godot_icall_0_160(method_bind_18, Object.GetPtr(this));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_baked_tilts");

        /// <summary>
        /// Returns the cache of tilts as a [RealArray].
        /// </summary>
        public float[] get_baked_tilts()
        {
            return NativeCalls.godot_icall_0_191(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tessellate");

        public Vector3[] tessellate(int max_stages = 5, float tolerance_degrees = 4)
        {
            return NativeCalls.godot_icall_2_192(method_bind_20, Object.GetPtr(this), max_stages, tolerance_degrees);
        }
    }
}
