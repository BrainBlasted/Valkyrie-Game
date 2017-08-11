using System;
using System.Collections.Generic;

namespace GodotEngine
{
    /// <summary>
    /// Contains global variables accessible from everywhere. Use the normal [Object] API, such as "ProjectSettings.get(variable)", "ProjectSettings.set(variable,value)" or "ProjectSettings.has(variable)" to access them. Variables stored in project.godot are also loaded into ProjectSettings, making this object very useful for reading custom game configuration options.
    /// </summary>
    public static class ProjectSettings
    {
        private const string nativeName = "ProjectSettings";
        internal static IntPtr ptr = NativeCalls.godot_icall_ProjectSettings_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has");

        /// <summary>
        /// Return true if a configuration value is present.
        /// </summary>
        public static bool has(string name)
        {
            return NativeCalls.godot_icall_1_57(method_bind_0, ptr, name);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_order");

        /// <summary>
        /// Set the order of a configuration value (influences when saved to the config file).
        /// </summary>
        public static void set_order(string name, int pos)
        {
            NativeCalls.godot_icall_2_79(method_bind_1, ptr, name, pos);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_order");

        /// <summary>
        /// Return the order of a configuration value (influences when saved to the config file).
        /// </summary>
        public static int get_order(string name)
        {
            return NativeCalls.godot_icall_1_71(method_bind_2, ptr, name);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_initial_value");

        public static void set_initial_value(string name, object value)
        {
            NativeCalls.godot_icall_2_315(method_bind_3, ptr, name, value);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_property_info");

        /// <summary>
        /// Add a custom property info to a property. The dictionary must contain: name:[String](the name of the property) and type:[int](see TYPE_* in [@Global Scope]), and optionally hint:[int](see PROPERTY_HINT_* in [@Global Scope]), hint_string:[String].
        /// Example:
        /// [codeblock]
        /// ProjectSettings.set("category/property_name", 0)
        /// var property_info = {
        /// "name": "category/property_name",
        /// "type": TYPE_INT,
        /// "hint": PROPERTY_HINT_ENUM,
        /// "hint_string": "one,two,three"
        /// }
        /// ProjectSettings.add_property_info(property_info)
        /// [/codeblock]
        /// </summary>
        public static void add_property_info(Dictionary<object, object> hint)
        {
            NativeCalls.godot_icall_1_405(method_bind_4, ptr, hint);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        /// <summary>
        /// Clear the whole configuration (not recommended, may break things).
        /// </summary>
        public static void clear(string name)
        {
            NativeCalls.godot_icall_1_35(method_bind_5, ptr, name);
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "localize_path");

        /// <summary>
        /// Convert a path to a localized path (res:// path).
        /// </summary>
        public static string localize_path(string path)
        {
            return NativeCalls.godot_icall_1_60(method_bind_6, ptr, path);
        }

        private static IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "globalize_path");

        /// <summary>
        /// Convert a localized path (res://) to a full native OS path.
        /// </summary>
        public static string globalize_path(string path)
        {
            return NativeCalls.godot_icall_1_60(method_bind_7, ptr, path);
        }

        private static IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "save");

        public static int save()
        {
            return NativeCalls.godot_icall_0_1(method_bind_8, ptr);
        }

        private static IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_singleton");

        public static bool has_singleton(string name)
        {
            return NativeCalls.godot_icall_1_57(method_bind_9, ptr, name);
        }

        private static IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_singleton");

        public static Object get_singleton(string name)
        {
            return NativeCalls.godot_icall_1_406(method_bind_10, ptr, name);
        }

        private static IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "load_resource_pack");

        public static bool load_resource_pack(string pack)
        {
            return NativeCalls.godot_icall_1_57(method_bind_11, ptr, pack);
        }

        private static IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "property_can_revert");

        public static bool property_can_revert(string name)
        {
            return NativeCalls.godot_icall_1_57(method_bind_12, ptr, name);
        }

        private static IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "property_get_revert");

        public static object property_get_revert(string name)
        {
            return NativeCalls.godot_icall_1_319(method_bind_13, ptr, name);
        }

        private static IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "save_custom");

        public static int save_custom(string file)
        {
            return NativeCalls.godot_icall_1_71(method_bind_14, ptr, file);
        }
    }
}
