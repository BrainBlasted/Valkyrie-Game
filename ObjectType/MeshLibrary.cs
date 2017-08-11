using System;

namespace GodotEngine
{
    /// <summary>
    /// Library of meshes. Contains a list of [Mesh] resources, each with name and ID. Useful for GridMap or painting Terrain.
    /// </summary>
    public class MeshLibrary : Resource
    {
        private const string nativeName = "MeshLibrary";

        public MeshLibrary() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MeshLibrary_Ctor(this);
        }

        internal MeshLibrary(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_item");

        /// <summary>
        /// Create a new item in the library, supplied an id.
        /// </summary>
        public void create_item(int id)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_item_name");

        /// <summary>
        /// Set the name of the item.
        /// </summary>
        public void set_item_name(int id, string name)
        {
            NativeCalls.godot_icall_2_69(method_bind_1, Object.GetPtr(this), id, name);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_item_mesh");

        /// <summary>
        /// Set the mesh of the item.
        /// </summary>
        public void set_item_mesh(int id, Mesh mesh)
        {
            NativeCalls.godot_icall_2_89(method_bind_2, Object.GetPtr(this), id, Object.GetPtr(mesh));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_item_navmesh");

        public void set_item_navmesh(int id, NavigationMesh navmesh)
        {
            NativeCalls.godot_icall_2_89(method_bind_3, Object.GetPtr(this), id, Object.GetPtr(navmesh));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_item_shape");

        public void set_item_shape(int id, Shape shape)
        {
            NativeCalls.godot_icall_2_89(method_bind_4, Object.GetPtr(this), id, Object.GetPtr(shape));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_item_name");

        /// <summary>
        /// Return the name of the item.
        /// </summary>
        public string get_item_name(int id)
        {
            return NativeCalls.godot_icall_1_87(method_bind_5, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_item_mesh");

        /// <summary>
        /// Return the mesh of the item.
        /// </summary>
        public Mesh get_item_mesh(int id)
        {
            return NativeCalls.godot_icall_1_286(method_bind_6, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_item_navmesh");

        public NavigationMesh get_item_navmesh(int id)
        {
            return NativeCalls.godot_icall_1_287(method_bind_7, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_item_shape");

        public Shape get_item_shape(int id)
        {
            return NativeCalls.godot_icall_1_288(method_bind_8, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_item");

        /// <summary>
        /// Remove the item.
        /// </summary>
        public void remove_item(int id)
        {
            NativeCalls.godot_icall_1_0(method_bind_9, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        /// <summary>
        /// Clear the library.
        /// </summary>
        public void clear()
        {
            NativeCalls.godot_icall_0_8(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_item_list");

        /// <summary>
        /// Return the list of items.
        /// </summary>
        public int[] get_item_list()
        {
            return NativeCalls.godot_icall_0_209(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_last_unused_item_id");

        /// <summary>
        /// Get an unused id for a new item.
        /// </summary>
        public int get_last_unused_item_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_12, Object.GetPtr(this));
        }
    }
}
