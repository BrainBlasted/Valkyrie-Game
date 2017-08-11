using System;

namespace GodotEngine
{
    /// <summary>
    /// Resource Loader. This is a static object accessible as [ResourceLoader]. GDScript has a simplified load() function, though.
    /// </summary>
    public static class ResourceLoader
    {
        private const string nativeName = "_ResourceLoader";
        internal static IntPtr ptr = NativeCalls.godot_icall__ResourceLoader_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "load_interactive");

        /// <summary>
        /// Load a resource interactively, the returned object allows to load with high granularity.
        /// </summary>
        public static ResourceInteractiveLoader load_interactive(string path, string type_hint = "")
        {
            return NativeCalls.godot_icall_2_550(method_bind_0, ptr, path, type_hint);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "load");

        public static Resource load(string path, string type_hint = "", bool p_no_cache = false)
        {
            return NativeCalls.godot_icall_3_551(method_bind_1, ptr, path, type_hint, p_no_cache);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_recognized_extensions_for_type");

        /// <summary>
        /// Return the list of recognized extensions for a resource type.
        /// </summary>
        public static string[] get_recognized_extensions_for_type(string type)
        {
            return NativeCalls.godot_icall_1_164(method_bind_2, ptr, type);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_abort_on_missing_resources");

        /// <summary>
        /// Change the behavior on missing sub-resources. Default is to abort load.
        /// </summary>
        public static void set_abort_on_missing_resources(bool abort)
        {
            NativeCalls.godot_icall_1_7(method_bind_3, ptr, abort);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dependencies");

        public static string[] get_dependencies(string path)
        {
            return NativeCalls.godot_icall_1_164(method_bind_4, ptr, path);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has");

        public static bool has(string path)
        {
            return NativeCalls.godot_icall_1_57(method_bind_5, ptr, path);
        }
    }
}
