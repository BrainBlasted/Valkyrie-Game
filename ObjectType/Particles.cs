using System;

namespace GodotEngine
{
    public class Particles : GeometryInstance
    {
        public const int DRAW_ORDER_INDEX = 0;
        public const int DRAW_ORDER_LIFETIME = 1;
        public const int DRAW_ORDER_VIEW_DEPTH = 2;
        public const int MAX_DRAW_PASSES = 4;

        private const string nativeName = "Particles";

        public Particles() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Particles_Ctor(this);
        }

        internal Particles(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emitting");

        public void set_emitting(bool emitting)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), emitting);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_amount");

        public void set_amount(int amount)
        {
            NativeCalls.godot_icall_1_0(method_bind_1, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_lifetime");

        public void set_lifetime(float secs)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), secs);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_one_shot");

        public void set_one_shot(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_3, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pre_process_time");

        public void set_pre_process_time(float secs)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), secs);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_explosiveness_ratio");

        public void set_explosiveness_ratio(float ratio)
        {
            NativeCalls.godot_icall_1_10(method_bind_5, Object.GetPtr(this), ratio);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_randomness_ratio");

        public void set_randomness_ratio(float ratio)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), ratio);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_visibility_aabb");

        public void set_visibility_aabb(Rect3 aabb)
        {
            NativeCalls.godot_icall_1_90(method_bind_7, Object.GetPtr(this), ref aabb);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_use_local_coordinates");

        public void set_use_local_coordinates(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_8, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fixed_fps");

        public void set_fixed_fps(int fps)
        {
            NativeCalls.godot_icall_1_0(method_bind_9, Object.GetPtr(this), fps);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fractional_delta");

        public void set_fractional_delta(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_10, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_process_material");

        public void set_process_material(Material material)
        {
            NativeCalls.godot_icall_1_35(method_bind_11, Object.GetPtr(this), Object.GetPtr(material));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_speed_scale");

        public void set_speed_scale(float scale)
        {
            NativeCalls.godot_icall_1_10(method_bind_12, Object.GetPtr(this), scale);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_emitting");

        public bool is_emitting()
        {
            return NativeCalls.godot_icall_0_3(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_amount");

        public int get_amount()
        {
            return NativeCalls.godot_icall_0_1(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_lifetime");

        public float get_lifetime()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_one_shot");

        public bool get_one_shot()
        {
            return NativeCalls.godot_icall_0_3(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pre_process_time");

        public float get_pre_process_time()
        {
            return NativeCalls.godot_icall_0_11(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_explosiveness_ratio");

        public float get_explosiveness_ratio()
        {
            return NativeCalls.godot_icall_0_11(method_bind_18, Object.GetPtr(this));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_randomness_ratio");

        public float get_randomness_ratio()
        {
            return NativeCalls.godot_icall_0_11(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_visibility_aabb");

        public Rect3 get_visibility_aabb()
        {
            object ret = NativeCalls.godot_icall_0_91(method_bind_20, Object.GetPtr(this));
            return (Rect3)ret;
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_use_local_coordinates");

        public bool get_use_local_coordinates()
        {
            return NativeCalls.godot_icall_0_3(method_bind_21, Object.GetPtr(this));
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fixed_fps");

        public int get_fixed_fps()
        {
            return NativeCalls.godot_icall_0_1(method_bind_22, Object.GetPtr(this));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fractional_delta");

        public bool get_fractional_delta()
        {
            return NativeCalls.godot_icall_0_3(method_bind_23, Object.GetPtr(this));
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_process_material");

        public Material get_process_material()
        {
            return NativeCalls.godot_icall_0_142(method_bind_24, Object.GetPtr(this));
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_speed_scale");

        public float get_speed_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_25, Object.GetPtr(this));
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_draw_order");

        public void set_draw_order(int order)
        {
            NativeCalls.godot_icall_1_0(method_bind_26, Object.GetPtr(this), order);
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_draw_order");

        public int get_draw_order()
        {
            return NativeCalls.godot_icall_0_1(method_bind_27, Object.GetPtr(this));
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_draw_passes");

        public void set_draw_passes(int passes)
        {
            NativeCalls.godot_icall_1_0(method_bind_28, Object.GetPtr(this), passes);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_draw_pass_mesh");

        public void set_draw_pass_mesh(int pass, Mesh mesh)
        {
            NativeCalls.godot_icall_2_88(method_bind_29, Object.GetPtr(this), pass, Object.GetPtr(mesh));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_draw_passes");

        public int get_draw_passes()
        {
            return NativeCalls.godot_icall_0_1(method_bind_30, Object.GetPtr(this));
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_draw_pass_mesh");

        public Mesh get_draw_pass_mesh(int pass)
        {
            return NativeCalls.godot_icall_1_288(method_bind_31, Object.GetPtr(this), pass);
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "restart");

        public void restart()
        {
            NativeCalls.godot_icall_0_8(method_bind_32, Object.GetPtr(this));
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "capture_aabb");

        public Rect3 capture_aabb()
        {
            object ret = NativeCalls.godot_icall_0_91(method_bind_33, Object.GetPtr(this));
            return (Rect3)ret;
        }
    }
}
