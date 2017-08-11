using System;

namespace GodotEngine
{
    public class GIProbe : VisualInstance
    {
        public const int SUBDIV_64 = 0;
        public const int SUBDIV_128 = 1;
        public const int SUBDIV_256 = 2;
        public const int SUBDIV_MAX = 4;

        private const string nativeName = "GIProbe";

        public GIProbe() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GIProbe_Ctor(this);
        }

        internal GIProbe(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_probe_data");

        public void set_probe_data(GIProbeData data)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(data));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_probe_data");

        public GIProbeData get_probe_data()
        {
            return NativeCalls.godot_icall_0_205(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_subdiv");

        public void set_subdiv(int subdiv)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), subdiv);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_subdiv");

        public int get_subdiv()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_extents");

        public void set_extents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_84(method_bind_4, Object.GetPtr(this), ref extents);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_extents");

        public Vector3 get_extents()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_5, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dynamic_range");

        public void set_dynamic_range(int max)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), max);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dynamic_range");

        public int get_dynamic_range()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_energy");

        public void set_energy(float max)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), max);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_energy");

        public float get_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bias");

        public void set_bias(float max)
        {
            NativeCalls.godot_icall_1_10(method_bind_10, Object.GetPtr(this), max);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bias");

        public float get_bias()
        {
            return NativeCalls.godot_icall_0_11(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_normal_bias");

        public void set_normal_bias(float max)
        {
            NativeCalls.godot_icall_1_10(method_bind_12, Object.GetPtr(this), max);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_normal_bias");

        public float get_normal_bias()
        {
            return NativeCalls.godot_icall_0_11(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_propagation");

        public void set_propagation(float max)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), max);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_propagation");

        public float get_propagation()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_interior");

        public void set_interior(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_16, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_interior");

        public bool is_interior()
        {
            return NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_compress");

        public void set_compress(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_18, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_compressed");

        public bool is_compressed()
        {
            return NativeCalls.godot_icall_0_3(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "bake");

        public void bake(Node from_node = null, bool create_visual_debug = false)
        {
            NativeCalls.godot_icall_2_206(method_bind_20, Object.GetPtr(this), Object.GetPtr(from_node), create_visual_debug);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "debug_bake");

        public void debug_bake()
        {
            NativeCalls.godot_icall_0_8(method_bind_21, Object.GetPtr(this));
        }
    }
}
