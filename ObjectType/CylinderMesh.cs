using System;

namespace GodotEngine
{
    public class CylinderMesh : PrimitiveMesh
    {
        private const string nativeName = "CylinderMesh";

        public CylinderMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CylinderMesh_Ctor(this);
        }

        internal CylinderMesh(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_top_radius");

        public void set_top_radius(float radius)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), radius);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_top_radius");

        public float get_top_radius()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bottom_radius");

        public void set_bottom_radius(float radius)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), radius);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bottom_radius");

        public float get_bottom_radius()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_height");

        public void set_height(float height)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), height);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_height");

        public float get_height()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_radial_segments");

        public void set_radial_segments(int segments)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), segments);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_radial_segments");

        public int get_radial_segments()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rings");

        public void set_rings(int rings)
        {
            NativeCalls.godot_icall_1_0(method_bind_8, Object.GetPtr(this), rings);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rings");

        public int get_rings()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }
    }
}
