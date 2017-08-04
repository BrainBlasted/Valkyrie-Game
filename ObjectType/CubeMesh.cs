using System;

namespace GodotEngine
{
    public class CubeMesh : PrimitiveMesh
    {
        private const string nativeName = "CubeMesh";

        public CubeMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CubeMesh_Ctor(this);
        }

        internal CubeMesh(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_size");

        public void set_size(Vector3 size)
        {
            NativeCalls.godot_icall_1_83(method_bind_0, Object.GetPtr(this), ref size);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_size");

        public Vector3 get_size()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_1, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_subdivide_width");

        public void set_subdivide_width(int subdivide)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), subdivide);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_subdivide_width");

        public int get_subdivide_width()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_subdivide_height");

        public void set_subdivide_height(int divisions)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), divisions);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_subdivide_height");

        public int get_subdivide_height()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_subdivide_depth");

        public void set_subdivide_depth(int divisions)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), divisions);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_subdivide_depth");

        public int get_subdivide_depth()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }
    }
}
