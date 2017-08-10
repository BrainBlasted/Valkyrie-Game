using System;

namespace GodotEngine
{
    public class NavigationMeshInstance : Spatial
    {
        private const string nativeName = "NavigationMeshInstance";

        public NavigationMeshInstance() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NavigationMeshInstance_Ctor(this);
        }

        internal NavigationMeshInstance(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_navigation_mesh");

        public void set_navigation_mesh(NavigationMesh navmesh)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(navmesh));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_navigation_mesh");

        public NavigationMesh get_navigation_mesh()
        {
            return NativeCalls.godot_icall_0_299(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_enabled");

        public void set_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_enabled");

        public bool is_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }
    }
}
