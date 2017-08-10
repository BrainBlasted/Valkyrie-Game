using System;

namespace GodotEngine
{
    public class InputEvent : Resource
    {
        private const string nativeName = "InputEvent";

        internal InputEvent() {}

        internal InputEvent(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_id");

        public void set_id(int id)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_id");

        public int get_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_device");

        public void set_device(int device)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), device);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_device");

        public int get_device()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_pressed");

        /// <summary>
        /// Return if this input event is pressed. Not relevant for the event types MOUSE_MOTION, SCREEN_DRAG and NONE.
        /// </summary>
        public bool is_pressed()
        {
            return NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_action");

        /// <summary>
        /// Return if this input event matches a pre-defined action, no matter the type.
        /// </summary>
        public bool is_action(string action)
        {
            return NativeCalls.godot_icall_1_56(method_bind_5, Object.GetPtr(this), action);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_action_pressed");

        /// <summary>
        /// Return whether the given action is being pressed (and is not an echo event for KEY events). Not relevant for the event types MOUSE_MOTION, SCREEN_DRAG and NONE.
        /// </summary>
        public bool is_action_pressed(string action)
        {
            return NativeCalls.godot_icall_1_56(method_bind_6, Object.GetPtr(this), action);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_action_released");

        /// <summary>
        /// Return whether the given action is released (i.e. not pressed). Not relevant for the event types MOUSE_MOTION, SCREEN_DRAG and NONE.
        /// </summary>
        public bool is_action_released(string action)
        {
            return NativeCalls.godot_icall_1_56(method_bind_7, Object.GetPtr(this), action);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_echo");

        /// <summary>
        /// Return if this input event is an echo event (only for events of type KEY, it will return false for other types).
        /// </summary>
        public bool is_echo()
        {
            return NativeCalls.godot_icall_0_3(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "as_text");

        public string as_text()
        {
            return NativeCalls.godot_icall_0_2(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "action_match");

        public bool action_match(InputEvent @event)
        {
            return NativeCalls.godot_icall_1_253(method_bind_10, Object.GetPtr(this), Object.GetPtr(@event));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shortcut_match");

        public bool shortcut_match(InputEvent @event)
        {
            return NativeCalls.godot_icall_1_253(method_bind_11, Object.GetPtr(this), Object.GetPtr(@event));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_action_type");

        public bool is_action_type()
        {
            return NativeCalls.godot_icall_0_3(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "xformed_by");

        public InputEvent xformed_by(Transform2D xform, Nullable<Vector2> local_ofs = null)
        {
            Vector2 local_ofs_in = local_ofs.HasValue ? local_ofs.Value : new Vector2(0, 0);
            return NativeCalls.godot_icall_2_254(method_bind_13, Object.GetPtr(this), ref xform, ref local_ofs_in);
        }
    }
}
