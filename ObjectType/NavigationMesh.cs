using System;

namespace GodotEngine
{
    public class NavigationMesh : Resource
    {
        private const string nativeName = "NavigationMesh";

        public NavigationMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NavigationMesh_Ctor(this);
        }

        internal NavigationMesh(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertices");

        public void set_vertices(Vector3[] vertices)
        {
            NativeCalls.godot_icall_1_157(method_bind_0, Object.GetPtr(this), vertices);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertices");

        public Vector3[] get_vertices()
        {
            return NativeCalls.godot_icall_0_158(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_polygon");

        public void add_polygon(int[] polygon)
        {
            NativeCalls.godot_icall_1_209(method_bind_2, Object.GetPtr(this), polygon);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_polygon_count");

        public int get_polygon_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_polygon");

        public int[] get_polygon(int idx)
        {
            return NativeCalls.godot_icall_1_285(method_bind_4, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear_polygons");

        public void clear_polygons()
        {
            NativeCalls.godot_icall_0_8(method_bind_5, Object.GetPtr(this));
        }
    }
}
