using System;

namespace GodotEngine
{
    public class CapsuleMesh : PrimitiveMesh
    {
        private const string nativeName = "CapsuleMesh";

        public CapsuleMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CapsuleMesh_Ctor(this);
        }

        internal CapsuleMesh(bool memoryOwn) : base(memoryOwn) {}

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

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_mid_height");

        public void set_mid_height(float mid_height)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), mid_height);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mid_height");

        public float get_mid_height()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_radial_segments");

        public void set_radial_segments(int segments)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), segments);
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
    }
}
