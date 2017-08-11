using System;

namespace GodotEngine
{
    public static class InputMap
    {
        private const string nativeName = "InputMap";
        internal static IntPtr ptr = NativeCalls.godot_icall_InputMap_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_action");

        /// <summary>
        /// Whether this InputMap has a registered action with the given name.
        /// </summary>
        public static bool has_action(string action)
        {
            return NativeCalls.godot_icall_1_57(method_bind_0, ptr, action);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_actions");

        /// <summary>
        /// Return an array of all actions in the [InputMap].
        /// </summary>
        public static object[] get_actions()
        {
            return NativeCalls.godot_icall_0_85(method_bind_1, ptr);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_action");

        /// <summary>
        /// Add an (empty) action to the [InputMap]. An [InputEvent] can then be added to this action with [method action_add_event].
        /// </summary>
        public static void add_action(string action)
        {
            NativeCalls.godot_icall_1_35(method_bind_2, ptr, action);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "erase_action");

        /// <summary>
        /// Remove an action from the [InputMap].
        /// </summary>
        public static void erase_action(string action)
        {
            NativeCalls.godot_icall_1_35(method_bind_3, ptr, action);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "action_add_event");

        public static void action_add_event(string action, InputEvent @event)
        {
            NativeCalls.godot_icall_2_73(method_bind_4, ptr, action, Object.GetPtr(@event));
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "action_has_event");

        public static bool action_has_event(string action, InputEvent @event)
        {
            return NativeCalls.godot_icall_2_253(method_bind_5, ptr, action, Object.GetPtr(@event));
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "action_erase_event");

        public static void action_erase_event(string action, InputEvent @event)
        {
            NativeCalls.godot_icall_2_73(method_bind_6, ptr, action, Object.GetPtr(@event));
        }

        private static IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_action_list");

        /// <summary>
        /// Return an array of InputEvents associated with a given action.
        /// </summary>
        public static object[] get_action_list(string action)
        {
            return NativeCalls.godot_icall_1_254(method_bind_7, ptr, action);
        }

        private static IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "event_is_action");

        public static bool event_is_action(InputEvent @event, string action)
        {
            return NativeCalls.godot_icall_2_255(method_bind_8, ptr, Object.GetPtr(@event), action);
        }

        private static IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "load_from_globals");

        /// <summary>
        /// Clear the [InputMap] and load it anew from [ProjectSettings].
        /// </summary>
        public static void load_from_globals()
        {
            NativeCalls.godot_icall_0_8(method_bind_9, ptr);
        }
    }
}
