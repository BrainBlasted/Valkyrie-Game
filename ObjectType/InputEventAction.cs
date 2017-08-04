using System;

namespace GodotEngine
{
    public class InputEventAction : InputEvent
    {
        private const string nativeName = "InputEventAction";

        public InputEventAction() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventAction_Ctor(this);
        }

        internal InputEventAction(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_action");

        public void set_action(string action)
        {
            NativeCalls.godot_icall_1_34(method_bind_0, Object.GetPtr(this), action);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_action");

        public string get_action()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pressed");

        public void set_pressed(bool pressed)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), pressed);
        }
    }
}
