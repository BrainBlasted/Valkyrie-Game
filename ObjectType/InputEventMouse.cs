using System;

namespace GodotEngine
{
    public class InputEventMouse : InputEventWithModifiers
    {
        private const string nativeName = "InputEventMouse";

        internal InputEventMouse() {}

        internal InputEventMouse(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_button_mask");

        public void set_button_mask(int button_mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), button_mask);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_button_mask");

        public int get_button_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_position");

        public void set_position(Vector2 position)
        {
            NativeCalls.godot_icall_1_37(method_bind_2, Object.GetPtr(this), ref position);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_position");

        public Vector2 get_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_3, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_global_position");

        public void set_global_position(Vector2 global_position)
        {
            NativeCalls.godot_icall_1_37(method_bind_4, Object.GetPtr(this), ref global_position);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_position");

        public Vector2 get_global_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_5, Object.GetPtr(this));
            return (Vector2)ret;
        }
    }
}
