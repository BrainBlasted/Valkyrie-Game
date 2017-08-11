using System;

namespace GodotEngine
{
    /// <summary>
    /// Light is the abstract base class for light nodes, so it shouldn't be used directly (It can't be instanced). Other types of light nodes inherit from it. Light contains the common variables and parameters used for lighting.
    /// </summary>
    public class Light : VisualInstance
    {
        public const int PARAM_ENERGY = 0;
        public const int PARAM_SPECULAR = 1;
        public const int PARAM_RANGE = 2;
        public const int PARAM_ATTENUATION = 3;
        public const int PARAM_SPOT_ANGLE = 4;
        public const int PARAM_SPOT_ATTENUATION = 5;
        public const int PARAM_CONTACT_SHADOW_SIZE = 6;
        public const int PARAM_SHADOW_MAX_DISTANCE = 7;
        public const int PARAM_SHADOW_SPLIT_1_OFFSET = 8;
        public const int PARAM_SHADOW_SPLIT_2_OFFSET = 9;
        public const int PARAM_SHADOW_SPLIT_3_OFFSET = 10;
        public const int PARAM_SHADOW_NORMAL_BIAS = 11;
        public const int PARAM_SHADOW_BIAS = 12;
        public const int PARAM_MAX = 13;

        private const string nativeName = "Light";

        internal Light() {}

        internal Light(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_editor_only");

        public void set_editor_only(bool editor_only)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), editor_only);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_editor_only");

        public bool is_editor_only()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_param");

        public void set_param(int param, float value)
        {
            NativeCalls.godot_icall_2_45(method_bind_2, Object.GetPtr(this), param, value);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_param");

        public float get_param(int param)
        {
            return NativeCalls.godot_icall_1_6(method_bind_3, Object.GetPtr(this), param);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shadow");

        public void set_shadow(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_4, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_shadow");

        public bool has_shadow()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_negative");

        public void set_negative(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_6, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_negative");

        public bool is_negative()
        {
            return NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cull_mask");

        public void set_cull_mask(int cull_mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_8, Object.GetPtr(this), cull_mask);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cull_mask");

        public int get_cull_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_color");

        public void set_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_10, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_color");

        public Color get_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_11, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shadow_color");

        public void set_shadow_color(Color shadow_color)
        {
            NativeCalls.godot_icall_1_123(method_bind_12, Object.GetPtr(this), ref shadow_color);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shadow_color");

        public Color get_shadow_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_13, Object.GetPtr(this));
            return (Color)ret;
        }
    }
}
