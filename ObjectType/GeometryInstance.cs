using System;

namespace GodotEngine
{
    /// <summary>
    /// Base node for geometry based visual instances. Shares some common functionality like visibility and custom materials.
    /// </summary>
    public class GeometryInstance : VisualInstance
    {
        public const int FLAG_CAST_SHADOW = 0;
        public const int FLAG_VISIBLE_IN_ALL_ROOMS = 1;
        public const int FLAG_MAX = 3;
        public const int SHADOW_CASTING_SETTING_OFF = 0;
        public const int SHADOW_CASTING_SETTING_ON = 1;
        public const int SHADOW_CASTING_SETTING_DOUBLE_SIDED = 2;
        public const int SHADOW_CASTING_SETTING_SHADOWS_ONLY = 3;

        private const string nativeName = "GeometryInstance";

        internal GeometryInstance() {}

        internal GeometryInstance(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_material_override");

        public void set_material_override(Material material)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(material));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_material_override");

        /// <summary>
        /// Return the material override for the whole geometry.
        /// </summary>
        public Material get_material_override()
        {
            return NativeCalls.godot_icall_0_143(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_flag");

        public void set_flag(int flag, bool value)
        {
            NativeCalls.godot_icall_2_42(method_bind_2, Object.GetPtr(this), flag, value);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_flag");

        public bool get_flag(int flag)
        {
            return NativeCalls.godot_icall_1_22(method_bind_3, Object.GetPtr(this), flag);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cast_shadows_setting");

        public void set_cast_shadows_setting(int shadow_casting_setting)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), shadow_casting_setting);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cast_shadows_setting");

        public int get_cast_shadows_setting()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_lod_max_hysteresis");

        public void set_lod_max_hysteresis(float mode)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_lod_max_hysteresis");

        public float get_lod_max_hysteresis()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_lod_max_distance");

        public void set_lod_max_distance(float mode)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_lod_max_distance");

        public float get_lod_max_distance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_lod_min_hysteresis");

        public void set_lod_min_hysteresis(float mode)
        {
            NativeCalls.godot_icall_1_10(method_bind_10, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_lod_min_hysteresis");

        public float get_lod_min_hysteresis()
        {
            return NativeCalls.godot_icall_0_11(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_lod_min_distance");

        public void set_lod_min_distance(float mode)
        {
            NativeCalls.godot_icall_1_10(method_bind_12, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_lod_min_distance");

        public float get_lod_min_distance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_extra_cull_margin");

        public void set_extra_cull_margin(float margin)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), margin);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_extra_cull_margin");

        public float get_extra_cull_margin()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }
    }
}
