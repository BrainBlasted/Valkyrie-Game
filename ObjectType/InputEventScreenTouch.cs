using System;

namespace GodotEngine
{
    public class InputEventScreenTouch : InputEvent
    {
        private const string nativeName = "InputEventScreenTouch";

        public InputEventScreenTouch() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventScreenTouch_Ctor(this);
        }

        internal InputEventScreenTouch(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_index");

        public void set_index(int index)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_index");

        public int get_index()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_position");

        public void set_position(Vector2 pos)
        {
            NativeCalls.godot_icall_1_37(method_bind_2, Object.GetPtr(this), ref pos);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_position");

        public Vector2 get_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_3, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pressed");

        public void set_pressed(bool pressed)
        {
            NativeCalls.godot_icall_1_7(method_bind_4, Object.GetPtr(this), pressed);
        }
    }
}
