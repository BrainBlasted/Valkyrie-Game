using System;

namespace GodotEngine
{
    public class GIProbeData : Resource
    {
        private const string nativeName = "GIProbeData";

        public GIProbeData() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GIProbeData_Ctor(this);
        }

        internal GIProbeData(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bounds");

        public void set_bounds(Rect3 bounds)
        {
            NativeCalls.godot_icall_1_90(method_bind_0, Object.GetPtr(this), ref bounds);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bounds");

        public Rect3 get_bounds()
        {
            object ret = NativeCalls.godot_icall_0_91(method_bind_1, Object.GetPtr(this));
            return (Rect3)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cell_size");

        public void set_cell_size(float cell_size)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), cell_size);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cell_size");

        public float get_cell_size()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_to_cell_xform");

        public void set_to_cell_xform(Transform to_cell_xform)
        {
            NativeCalls.godot_icall_1_208(method_bind_4, Object.GetPtr(this), ref to_cell_xform);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_to_cell_xform");

        public Transform get_to_cell_xform()
        {
            object ret = NativeCalls.godot_icall_0_14(method_bind_5, Object.GetPtr(this));
            return (Transform)ret;
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dynamic_data");

        public void set_dynamic_data(int[] dynamic_data)
        {
            NativeCalls.godot_icall_1_209(method_bind_6, Object.GetPtr(this), dynamic_data);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dynamic_data");

        public int[] get_dynamic_data()
        {
            return NativeCalls.godot_icall_0_210(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dynamic_range");

        public void set_dynamic_range(int dynamic_range)
        {
            NativeCalls.godot_icall_1_0(method_bind_8, Object.GetPtr(this), dynamic_range);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dynamic_range");

        public int get_dynamic_range()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_energy");

        public void set_energy(float energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_10, Object.GetPtr(this), energy);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_energy");

        public float get_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bias");

        public void set_bias(float bias)
        {
            NativeCalls.godot_icall_1_10(method_bind_12, Object.GetPtr(this), bias);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bias");

        public float get_bias()
        {
            return NativeCalls.godot_icall_0_11(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_normal_bias");

        public void set_normal_bias(float bias)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), bias);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_normal_bias");

        public float get_normal_bias()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_propagation");

        public void set_propagation(float propagation)
        {
            NativeCalls.godot_icall_1_10(method_bind_16, Object.GetPtr(this), propagation);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_propagation");

        public float get_propagation()
        {
            return NativeCalls.godot_icall_0_11(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_interior");

        public void set_interior(bool interior)
        {
            NativeCalls.godot_icall_1_7(method_bind_18, Object.GetPtr(this), interior);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_interior");

        public bool is_interior()
        {
            return NativeCalls.godot_icall_0_3(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_compress");

        public void set_compress(bool compress)
        {
            NativeCalls.godot_icall_1_7(method_bind_20, Object.GetPtr(this), compress);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_compressed");

        public bool is_compressed()
        {
            return NativeCalls.godot_icall_0_3(method_bind_21, Object.GetPtr(this));
        }
    }
}
