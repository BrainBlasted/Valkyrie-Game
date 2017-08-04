using System;

namespace GodotEngine
{
    public class InputEventMouseButton : InputEventMouse
    {
        private const string nativeName = "InputEventMouseButton";

        public InputEventMouseButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventMouseButton_Ctor(this);
        }

        internal InputEventMouseButton(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_factor");

        public void set_factor(float factor)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), factor);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_factor");

        public float get_factor()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_button_index");

        public void set_button_index(int button_index)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), button_index);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_button_index");

        public int get_button_index()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pressed");

        public void set_pressed(bool pressed)
        {
            NativeCalls.godot_icall_1_7(method_bind_4, Object.GetPtr(this), pressed);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_doubleclick");

        public void set_doubleclick(bool doubleclick)
        {
            NativeCalls.godot_icall_1_7(method_bind_5, Object.GetPtr(this), doubleclick);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_doubleclick");

        public bool is_doubleclick()
        {
            return NativeCalls.godot_icall_0_3(method_bind_6, Object.GetPtr(this));
        }
    }
}
