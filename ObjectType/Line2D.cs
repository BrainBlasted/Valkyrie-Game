using System;

namespace GodotEngine
{
    public class Line2D : Node2D
    {
        public const int LINE_JOINT_SHARP = 0;
        public const int LINE_JOINT_BEVEL = 1;
        public const int LINE_JOINT_ROUND = 2;
        public const int LINE_CAP_NONE = 0;
        public const int LINE_CAP_BOX = 1;
        public const int LINE_CAP_ROUND = 2;
        public const int LINE_TEXTURE_NONE = 0;
        public const int LINE_TEXTURE_TILE = 1;

        private const string nativeName = "Line2D";

        public Line2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Line2D_Ctor(this);
        }

        internal Line2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_points");

        public void set_points(Vector2[] points)
        {
            NativeCalls.godot_icall_1_154(method_bind_0, Object.GetPtr(this), points);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_points");

        public Vector2[] get_points()
        {
            return NativeCalls.godot_icall_0_155(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_pos");

        public void set_point_pos(int i, Vector2 pos)
        {
            NativeCalls.godot_icall_2_181(method_bind_2, Object.GetPtr(this), i, ref pos);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_pos");

        public Vector2 get_point_pos(int i)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_3, Object.GetPtr(this), i);
            return (Vector2)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_count");

        public int get_point_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_point");

        public void add_point(Vector2 pos)
        {
            NativeCalls.godot_icall_1_37(method_bind_5, Object.GetPtr(this), ref pos);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_point");

        public void remove_point(int i)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), i);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_width");

        public void set_width(float width)
        {
            NativeCalls.godot_icall_1_10(method_bind_7, Object.GetPtr(this), width);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_width");

        public float get_width()
        {
            return NativeCalls.godot_icall_0_11(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_default_color");

        public void set_default_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_9, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_default_color");

        public Color get_default_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_10, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_gradient");

        public void set_gradient(Gradient color)
        {
            NativeCalls.godot_icall_1_19(method_bind_11, Object.GetPtr(this), Object.GetPtr(color));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_gradient");

        public Gradient get_gradient()
        {
            return NativeCalls.godot_icall_0_217(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_texture");

        public void set_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_19(method_bind_13, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_texture");

        public Texture get_texture()
        {
            return NativeCalls.godot_icall_0_93(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_texture_mode");

        public void set_texture_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_15, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_texture_mode");

        public int get_texture_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_joint_mode");

        public void set_joint_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_17, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_joint_mode");

        public int get_joint_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_18, Object.GetPtr(this));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_begin_cap_mode");

        public void set_begin_cap_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_19, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_begin_cap_mode");

        public int get_begin_cap_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_20, Object.GetPtr(this));
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_end_cap_mode");

        public void set_end_cap_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_21, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_end_cap_mode");

        public int get_end_cap_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_22, Object.GetPtr(this));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sharp_limit");

        public void set_sharp_limit(float limit)
        {
            NativeCalls.godot_icall_1_10(method_bind_23, Object.GetPtr(this), limit);
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sharp_limit");

        public float get_sharp_limit()
        {
            return NativeCalls.godot_icall_0_11(method_bind_24, Object.GetPtr(this));
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_round_precision");

        public void set_round_precision(int precision)
        {
            NativeCalls.godot_icall_1_0(method_bind_25, Object.GetPtr(this), precision);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_round_precision");

        public int get_round_precision()
        {
            return NativeCalls.godot_icall_0_1(method_bind_26, Object.GetPtr(this));
        }
    }
}
