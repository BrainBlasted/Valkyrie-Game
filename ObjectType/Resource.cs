using System;

namespace GodotEngine
{
    /// <summary>
    /// Resource is the base class for all resource types. Resources are primarily data containers. They are reference counted and freed when no longer in use. They are also loaded only once from disk, and further attempts to load the resource will return the same reference (all this in contrast to a [Node], which is not reference counted and can be instanced from disk as many times as desired). Resources can be saved externally on disk or bundled into another object, such as a [Node] or another resource.
    /// </summary>
    public class Resource : Reference
    {
        private const string nativeName = "Resource";

        public Resource() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Resource_Ctor(this);
        }

        internal Resource(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_path");

        /// <summary>
        /// Set the path of the resource. This is useful mainly for editors when saving/loading, and shouldn't be changed by anything else. Fails if another [Resource] already has path "path".
        /// </summary>
        public void set_path(string path)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "take_over_path");

        /// <summary>
        /// Set the path of the resource. Differs from set_path(), if another [Resource] exists with "path" it over-takes it, instead of failing.
        /// </summary>
        public void take_over_path(string path)
        {
            NativeCalls.godot_icall_1_35(method_bind_1, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_path");

        /// <summary>
        /// Return the path of the resource. This is useful mainly for editors when saving/loading, and shouldn't be changed by anything else.
        /// </summary>
        public string get_path()
        {
            return NativeCalls.godot_icall_0_2(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_name");

        /// <summary>
        /// Set the name of the resources, any name is valid (it doesn't have to be unique). Name is for descriptive purposes only.
        /// </summary>
        public void set_name(string name)
        {
            NativeCalls.godot_icall_1_35(method_bind_3, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_name");

        /// <summary>
        /// Return the name of the resources, any name is valid (it doesn't have to be unique). Name is for descriptive purposes only.
        /// </summary>
        public string get_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rid");

        /// <summary>
        /// Return the RID of the resource (or an empty RID). Many resources (such as [Texture], [Mesh], etc) are high level abstractions of resources stored in a server, so this function will return the original RID.
        /// </summary>
        public RID get_rid()
        {
            IntPtr ret = NativeCalls.godot_icall_0_122(method_bind_5, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_local_to_scene");

        public void set_local_to_scene(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_6, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_local_to_scene");

        public bool is_local_to_scene()
        {
            return NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_local_scene");

        public Node get_local_scene()
        {
            return NativeCalls.godot_icall_0_119(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "setup_local_to_scene");

        public void setup_local_to_scene()
        {
            NativeCalls.godot_icall_0_8(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "duplicate");

        public Resource duplicate(bool subresources = false)
        {
            return NativeCalls.godot_icall_1_410(method_bind_10, Object.GetPtr(this), subresources);
        }
    }
}
