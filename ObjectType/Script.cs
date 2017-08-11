using System;

namespace GodotEngine
{
    /// <summary>
    /// Base class for scripts. Any script that is loaded becomes one of these resources, which can then create instances.
    /// </summary>
    public class Script : Resource
    {
        private const string nativeName = "Script";

        internal Script() {}

        internal Script(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "can_instance");

        /// <summary>
        /// Return true if this script can be instance (ie not a library).
        /// </summary>
        public bool can_instance()
        {
            return NativeCalls.godot_icall_0_3(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "instance_has");

        /// <summary>
        /// Return true if a given object uses an instance of this script.
        /// </summary>
        public bool instance_has(Object base_object)
        {
            return NativeCalls.godot_icall_1_86(method_bind_1, Object.GetPtr(this), Object.GetPtr(base_object));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_source_code");

        /// <summary>
        /// Return true if the script contains source code.
        /// </summary>
        public bool has_source_code()
        {
            return NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_source_code");

        /// <summary>
        /// Return the script source code (if available).
        /// </summary>
        public string get_source_code()
        {
            return NativeCalls.godot_icall_0_2(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_source_code");

        /// <summary>
        /// Set the script source code.
        /// </summary>
        public void set_source_code(string source)
        {
            NativeCalls.godot_icall_1_35(method_bind_4, Object.GetPtr(this), source);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "reload");

        public int reload(bool keep_state = false)
        {
            return NativeCalls.godot_icall_1_327(method_bind_5, Object.GetPtr(this), keep_state);
        }
    }
}
