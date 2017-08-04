using System;

namespace GodotEngine
{
    public class PlaneMesh : PrimitiveMesh
    {
        private const string nativeName = "PlaneMesh";

        public PlaneMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PlaneMesh_Ctor(this);
        }

        internal PlaneMesh(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_size");

        public void set_size(Vector2 size)
        {
            NativeCalls.godot_icall_1_37(method_bind_0, Object.GetPtr(this), ref size);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_size");

        public Vector2 get_size()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_1, Object.GetPtr(this));
            return (Vector2)ret;
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

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_subdivide_depth");

        public void set_subdivide_depth(int subdivide)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), subdivide);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_subdivide_depth");

        public int get_subdivide_depth()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }
    }
}
