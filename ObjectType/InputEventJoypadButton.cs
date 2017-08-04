using System;

namespace GodotEngine
{
    public class InputEventJoypadButton : InputEvent
    {
        private const string nativeName = "InputEventJoypadButton";

        public InputEventJoypadButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventJoypadButton_Ctor(this);
        }

        internal InputEventJoypadButton(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_button_index");

        public void set_button_index(int button_index)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), button_index);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_button_index");

        public int get_button_index()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pressure");

        public void set_pressure(float pressure)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), pressure);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pressure");

        public float get_pressure()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pressed");

        public void set_pressed(bool pressed)
        {
            NativeCalls.godot_icall_1_7(method_bind_4, Object.GetPtr(this), pressed);
        }
    }
}
