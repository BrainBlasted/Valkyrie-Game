using System;

namespace GodotEngine
{
    public class SphereMesh : PrimitiveMesh
    {
        private const string nativeName = "SphereMesh";

        public SphereMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SphereMesh_Ctor(this);
        }

        internal SphereMesh(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_radius");

        public void set_radius(float radius)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), radius);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_radius");

        public float get_radius()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_height");

        public void set_height(float height)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), height);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_height");

        public float get_height()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_radial_segments");

        public void set_radial_segments(int radial_segments)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), radial_segments);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_radial_segments");

        public int get_radial_segments()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rings");

        public void set_rings(int rings)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), rings);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rings");

        public int get_rings()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_is_hemisphere");

        public void set_is_hemisphere(bool is_hemisphere)
        {
            NativeCalls.godot_icall_1_7(method_bind_8, Object.GetPtr(this), is_hemisphere);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_is_hemisphere");

        public bool get_is_hemisphere()
        {
            return NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }
    }
}
