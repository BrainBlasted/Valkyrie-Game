using System;

namespace GodotEngine
{
    public class InputEventJoypadMotion : InputEvent
    {
        private const string nativeName = "InputEventJoypadMotion";

        public InputEventJoypadMotion() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventJoypadMotion_Ctor(this);
        }

        internal InputEventJoypadMotion(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_axis");

        public void set_axis(int axis)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), axis);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_axis");

        public int get_axis()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_axis_value");

        public void set_axis_value(float axis_value)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), axis_value);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_axis_value");

        public float get_axis_value()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }
    }
}
