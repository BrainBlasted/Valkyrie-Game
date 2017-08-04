using System;

namespace GodotEngine
{
    public static class Marshalls
    {
        private const string nativeName = "_Marshalls";
        internal static IntPtr ptr = NativeCalls.godot_icall__Marshalls_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "variant_to_base64");

        public static string variant_to_base64(object variant)
        {
            return NativeCalls.godot_icall_1_413(method_bind_0, ptr, variant);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "base64_to_variant");

        public static object base64_to_variant(string base64_str)
        {
            return NativeCalls.godot_icall_1_322(method_bind_1, ptr, base64_str);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "raw_to_base64");

        public static string raw_to_base64(byte[] array)
        {
            return NativeCalls.godot_icall_1_550(method_bind_2, ptr, array);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "base64_to_raw");

        public static byte[] base64_to_raw(string base64_str)
        {
            return NativeCalls.godot_icall_1_551(method_bind_3, ptr, base64_str);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "utf8_to_base64");

        public static string utf8_to_base64(string utf8_str)
        {
            return NativeCalls.godot_icall_1_59(method_bind_4, ptr, utf8_str);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "base64_to_utf8");

        public static string base64_to_utf8(string base64_str)
        {
            return NativeCalls.godot_icall_1_59(method_bind_5, ptr, base64_str);
        }
    }
}
