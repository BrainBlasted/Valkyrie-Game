using System;
using System.Collections.Generic;

namespace GodotEngine
{
    public static class ClassDB
    {
        private const string nativeName = "_ClassDB";
        internal static IntPtr ptr = NativeCalls.godot_icall__ClassDB_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_class_list");

        public static string[] get_class_list()
        {
            return NativeCalls.godot_icall_0_58(method_bind_0, ptr);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_inheriters_from_class");

        public static string[] get_inheriters_from_class(string @class)
        {
            return NativeCalls.godot_icall_1_162(method_bind_1, ptr, @class);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_parent_class");

        public static string get_parent_class(string @class)
        {
            return NativeCalls.godot_icall_1_59(method_bind_2, ptr, @class);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_exists");

        public static bool class_exists(string @class)
        {
            return NativeCalls.godot_icall_1_56(method_bind_3, ptr, @class);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_parent_class");

        public static bool is_parent_class(string @class, string inherits)
        {
            return NativeCalls.godot_icall_2_161(method_bind_4, ptr, @class, inherits);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "can_instance");

        public static bool can_instance(string @class)
        {
            return NativeCalls.godot_icall_1_56(method_bind_5, ptr, @class);
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "instance");

        public static object instance(string @class)
        {
            return NativeCalls.godot_icall_1_321(method_bind_6, ptr, @class);
        }

        private static IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_has_signal");

        public static bool class_has_signal(string @class, string signal)
        {
            return NativeCalls.godot_icall_2_161(method_bind_7, ptr, @class, signal);
        }

        private static IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_get_signal");

        public static Dictionary<object, object> class_get_signal(string @class, string signal)
        {
            return NativeCalls.godot_icall_2_521(method_bind_8, ptr, @class, signal);
        }

        private static IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_get_signal_list");

        public static object[] class_get_signal_list(string @class, bool no_inheritance = false)
        {
            return NativeCalls.godot_icall_2_522(method_bind_9, ptr, @class, no_inheritance);
        }

        private static IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_get_property_list");

        public static object[] class_get_property_list(string @class, bool no_inheritance = false)
        {
            return NativeCalls.godot_icall_2_522(method_bind_10, ptr, @class, no_inheritance);
        }

        private static IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_get_property");

        public static object class_get_property(Object @object, string property)
        {
            return NativeCalls.godot_icall_2_523(method_bind_11, ptr, Object.GetPtr(@object), property);
        }

        private static IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_set_property");

        public static Error class_set_property(Object @object, string property, object value)
        {
            int ret = NativeCalls.godot_icall_3_524(method_bind_12, ptr, Object.GetPtr(@object), property, value);
            return (Error)ret;
        }

        private static IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_has_method");

        public static bool class_has_method(string @class, string method, bool no_inheritance = false)
        {
            return NativeCalls.godot_icall_3_525(method_bind_13, ptr, @class, method, no_inheritance);
        }

        private static IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_get_method_list");

        public static object[] class_get_method_list(string @class, bool no_inheritance = false)
        {
            return NativeCalls.godot_icall_2_522(method_bind_14, ptr, @class, no_inheritance);
        }

        private static IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_get_integer_constant_list");

        public static string[] class_get_integer_constant_list(string @class, bool no_inheritance = false)
        {
            return NativeCalls.godot_icall_2_526(method_bind_15, ptr, @class, no_inheritance);
        }

        private static IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_has_integer_constant");

        public static bool class_has_integer_constant(string @class, string name)
        {
            return NativeCalls.godot_icall_2_161(method_bind_16, ptr, @class, name);
        }

        private static IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_get_integer_constant");

        public static int class_get_integer_constant(string @class, string name)
        {
            return NativeCalls.godot_icall_2_69(method_bind_17, ptr, @class, name);
        }

        private static IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "class_get_category");

        public static string class_get_category(string @class)
        {
            return NativeCalls.godot_icall_1_59(method_bind_18, ptr, @class);
        }

        private static IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_class_enabled");

        public static bool is_class_enabled(string @class)
        {
            return NativeCalls.godot_icall_1_56(method_bind_19, ptr, @class);
        }
    }
}
