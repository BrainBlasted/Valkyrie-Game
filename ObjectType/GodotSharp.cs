using System;

namespace GodotEngine
{
    public static class GodotSharp
    {
        private const string nativeName = "_GodotSharp";
        internal static IntPtr ptr = NativeCalls.godot_icall__GodotSharp_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "attach_thread");

        public static void attach_thread()
        {
            NativeCalls.godot_icall_0_8(method_bind_0, ptr);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "detach_thread");

        public static void detach_thread()
        {
            NativeCalls.godot_icall_0_8(method_bind_1, ptr);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_unloading_domain");

        public static bool is_unloading_domain()
        {
            return NativeCalls.godot_icall_0_3(method_bind_2, ptr);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_domain_loaded");

        public static bool is_domain_loaded()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, ptr);
        }
    }
}
