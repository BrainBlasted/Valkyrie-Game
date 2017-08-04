using System;

namespace GodotEngine
{
    public class Curve : Resource
    {
        private const string nativeName = "Curve";

        public Curve() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Curve_Ctor(this);
        }

        internal Curve(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_point");

        public int add_point(Vector2 pos, float left_tangent = 0, float right_tangent = 0, int left_mode = 0, int right_mode = 0)
        {
            return NativeCalls.godot_icall_5_177(method_bind_0, Object.GetPtr(this), ref pos, left_tangent, right_tangent, left_mode, right_mode);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_point");

        public void remove_point(int index)
        {
            NativeCalls.godot_icall_1_0(method_bind_1, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear_points");

        public void clear_points()
        {
            NativeCalls.godot_icall_0_8(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_pos");

        public Vector2 get_point_pos(int index)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_3, Object.GetPtr(this), index);
            return (Vector2)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_value");

        public void set_point_value(int index, float y)
        {
            NativeCalls.godot_icall_2_45(method_bind_4, Object.GetPtr(this), index, y);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_offset");

        public void set_point_offset(int index, float offset)
        {
            NativeCalls.godot_icall_2_45(method_bind_5, Object.GetPtr(this), index, offset);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "interpolate");

        public float interpolate(float offset)
        {
            return NativeCalls.godot_icall_1_179(method_bind_6, Object.GetPtr(this), offset);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "interpolate_baked");

        public float interpolate_baked(float offset)
        {
            return NativeCalls.godot_icall_1_179(method_bind_7, Object.GetPtr(this), offset);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_left_tangent");

        public float get_point_left_tangent(int index)
        {
            return NativeCalls.godot_icall_1_6(method_bind_8, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_right_tangent");

        public float get_point_right_tangent(int index)
        {
            return NativeCalls.godot_icall_1_6(method_bind_9, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_left_mode");

        public int get_point_left_mode(int index)
        {
            return NativeCalls.godot_icall_1_5(method_bind_10, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_right_mode");

        public int get_point_right_mode(int index)
        {
            return NativeCalls.godot_icall_1_5(method_bind_11, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_left_tangent");

        public void set_point_left_tangent(int index, float tangent)
        {
            NativeCalls.godot_icall_2_45(method_bind_12, Object.GetPtr(this), index, tangent);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_right_tangent");

        public void set_point_right_tangent(int index, float tangent)
        {
            NativeCalls.godot_icall_2_45(method_bind_13, Object.GetPtr(this), index, tangent);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_left_mode");

        public void set_point_left_mode(int index, int mode)
        {
            NativeCalls.godot_icall_2_24(method_bind_14, Object.GetPtr(this), index, mode);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_right_mode");

        public void set_point_right_mode(int index, int mode)
        {
            NativeCalls.godot_icall_2_24(method_bind_15, Object.GetPtr(this), index, mode);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_min_value");

        public float get_min_value()
        {
            return NativeCalls.godot_icall_0_11(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_min_value");

        public void set_min_value(float min)
        {
            NativeCalls.godot_icall_1_10(method_bind_17, Object.GetPtr(this), min);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_max_value");

        public float get_max_value()
        {
            return NativeCalls.godot_icall_0_11(method_bind_18, Object.GetPtr(this));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_max_value");

        public void set_max_value(float max)
        {
            NativeCalls.godot_icall_1_10(method_bind_19, Object.GetPtr(this), max);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clean_dupes");

        public void clean_dupes()
        {
            NativeCalls.godot_icall_0_8(method_bind_20, Object.GetPtr(this));
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "bake");

        public void bake()
        {
            NativeCalls.godot_icall_0_8(method_bind_21, Object.GetPtr(this));
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bake_resolution");

        public int get_bake_resolution()
        {
            return NativeCalls.godot_icall_0_1(method_bind_22, Object.GetPtr(this));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bake_resolution");

        public void set_bake_resolution(int resolution)
        {
            NativeCalls.godot_icall_1_0(method_bind_23, Object.GetPtr(this), resolution);
        }
    }
}
