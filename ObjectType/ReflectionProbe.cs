using System;

namespace GodotEngine
{
    public class ReflectionProbe : VisualInstance
    {
        public const int UPDATE_ONCE = 0;
        public const int UPDATE_ALWAYS = 1;

        private const string nativeName = "ReflectionProbe";

        public ReflectionProbe() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ReflectionProbe_Ctor(this);
        }

        internal ReflectionProbe(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_intensity");

        public void set_intensity(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_intensity");

        public float get_intensity()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_interior_ambient");

        public void set_interior_ambient(Color ambient)
        {
            NativeCalls.godot_icall_1_122(method_bind_2, Object.GetPtr(this), ref ambient);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_interior_ambient");

        public Color get_interior_ambient()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_3, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_interior_ambient_energy");

        public void set_interior_ambient_energy(float ambient_energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), ambient_energy);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_interior_ambient_energy");

        public float get_interior_ambient_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_interior_ambient_probe_contribution");

        public void set_interior_ambient_probe_contribution(float ambient_probe_contribution)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), ambient_probe_contribution);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_interior_ambient_probe_contribution");

        public float get_interior_ambient_probe_contribution()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_max_distance");

        public void set_max_distance(float max_distance)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), max_distance);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_max_distance");

        public float get_max_distance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_extents");

        public void set_extents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_83(method_bind_10, Object.GetPtr(this), ref extents);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_extents");

        public Vector3 get_extents()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_11, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_origin_offset");

        public void set_origin_offset(Vector3 origin_offset)
        {
            NativeCalls.godot_icall_1_83(method_bind_12, Object.GetPtr(this), ref origin_offset);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_origin_offset");

        public Vector3 get_origin_offset()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_13, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_as_interior");

        public void set_as_interior(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_14, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_set_as_interior");

        public bool is_set_as_interior()
        {
            return NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_enable_box_projection");

        public void set_enable_box_projection(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_16, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_box_projection_enabled");

        public bool is_box_projection_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_enable_shadows");

        public void set_enable_shadows(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_18, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "are_shadows_enabled");

        public bool are_shadows_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cull_mask");

        public void set_cull_mask(int layers)
        {
            NativeCalls.godot_icall_1_0(method_bind_20, Object.GetPtr(this), layers);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cull_mask");

        public int get_cull_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_21, Object.GetPtr(this));
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_update_mode");

        public void set_update_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_22, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_update_mode");

        public int get_update_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_23, Object.GetPtr(this));
        }
    }
}
