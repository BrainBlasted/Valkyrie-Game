using System;

namespace GodotEngine
{
    public static class ARVRServer
    {
        public const int TRACKER_CONTROLLER = 1;
        public const int TRACKER_BASESTATION = 2;
        public const int TRACKER_ANCHOR = 4;
        public const int TRACKER_UNKNOWN = 128;
        public const int TRACKER_ANY_KNOWN = 127;
        public const int TRACKER_ANY = 255;

        private const string nativeName = "ARVRServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_ARVRServer_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_world_scale");

        public static float get_world_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_0, ptr);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_world_scale");

        public static void set_world_scale(float arg0)
        {
            NativeCalls.godot_icall_1_10(method_bind_1, ptr, arg0);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_reference_frame");

        public static Transform get_reference_frame()
        {
            object ret = NativeCalls.godot_icall_0_14(method_bind_2, ptr);
            return (Transform)ret;
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "request_reference_frame");

        public static void request_reference_frame(bool ignore_tilt, bool keep_height)
        {
            NativeCalls.godot_icall_2_15(method_bind_3, ptr, ignore_tilt, keep_height);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_interface_count");

        public static int get_interface_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_4, ptr);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_interface");

        public static ARVRInterface get_interface(int idx)
        {
            return NativeCalls.godot_icall_1_16(method_bind_5, ptr, idx);
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "find_interface");

        public static ARVRInterface find_interface(string name)
        {
            return NativeCalls.godot_icall_1_17(method_bind_6, ptr, name);
        }

        private static IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tracker_count");

        public static int get_tracker_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, ptr);
        }

        private static IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tracker");

        public static ARVRPositionalTracker get_tracker(int idx)
        {
            return NativeCalls.godot_icall_1_18(method_bind_8, ptr, idx);
        }

        private static IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_primary_interface");

        public static void set_primary_interface(ARVRInterface arg0)
        {
            NativeCalls.godot_icall_1_19(method_bind_9, ptr, Object.GetPtr(arg0));
        }

        private static IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_interface");

        public static void add_interface(ARVRInterface arg0)
        {
            NativeCalls.godot_icall_1_19(method_bind_10, ptr, Object.GetPtr(arg0));
        }

        private static IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_interface");

        public static void remove_interface(ARVRInterface arg0)
        {
            NativeCalls.godot_icall_1_19(method_bind_11, ptr, Object.GetPtr(arg0));
        }
    }
}
