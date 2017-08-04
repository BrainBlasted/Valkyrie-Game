using System;
using System.Collections.Generic;

namespace GodotEngine
{
    public static class Engine
    {
        private const string nativeName = "_Engine";
        internal static IntPtr ptr = NativeCalls.godot_icall__Engine_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_iterations_per_second");

        /// <summary>
        /// Set the amount of fixed iterations per second (for fixed process and physics).
        /// </summary>
        public static void set_iterations_per_second(int iterations_per_second)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, ptr, iterations_per_second);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_iterations_per_second");

        /// <summary>
        /// Return the amount of fixed iterations per second (for fixed process and physics).
        /// </summary>
        public static int get_iterations_per_second()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, ptr);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_target_fps");

        public static void set_target_fps(int target_fps)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, ptr, target_fps);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_target_fps");

        public static float get_target_fps()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, ptr);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_time_scale");

        public static void set_time_scale(float time_scale)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, ptr, time_scale);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_time_scale");

        public static float get_time_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, ptr);
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_custom_level");

        /// <summary>
        /// Returns the value of the commandline argument "-level".
        /// </summary>
        public static string get_custom_level()
        {
            return NativeCalls.godot_icall_0_2(method_bind_6, ptr);
        }

        private static IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_frames_drawn");

        /// <summary>
        /// Return the total amount of frames drawn.
        /// </summary>
        public static int get_frames_drawn()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, ptr);
        }

        private static IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_frames_per_second");

        /// <summary>
        /// Returns the frames per second of the running game.
        /// </summary>
        public static float get_frames_per_second()
        {
            return NativeCalls.godot_icall_0_11(method_bind_8, ptr);
        }

        private static IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_main_loop");

        /// <summary>
        /// Return the main loop object (see [MainLoop] and [SceneTree]).
        /// </summary>
        public static MainLoop get_main_loop()
        {
            return NativeCalls.godot_icall_0_529(method_bind_9, ptr);
        }

        private static IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_version_info");

        /// <summary>
        /// Returns the current engine version information in a Dictionary.
        /// "major"    - Holds the major version number as a String
        /// "minor"    - Holds the minor version number as a String
        /// "patch"    - Holds the patch version number as a String
        /// "status"   - Holds the status (e.g. "beta", "rc1", "rc2", ... "stable") as a String
        /// "revision" - Holds the revision (e.g. "custom-build") as a String
        /// "string"   - major + minor + patch + status + revision in a single String
        /// </summary>
        public static Dictionary<object, object> get_version_info()
        {
            return NativeCalls.godot_icall_0_234(method_bind_10, ptr);
        }

        private static IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_in_fixed_frame");

        public static bool is_in_fixed_frame()
        {
            return NativeCalls.godot_icall_0_3(method_bind_11, ptr);
        }
    }
}
