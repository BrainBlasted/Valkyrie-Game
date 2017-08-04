using System;

namespace GodotEngine
{
    public class InputEventKey : InputEventWithModifiers
    {
        private const string nativeName = "InputEventKey";

        public InputEventKey() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventKey_Ctor(this);
        }

        internal InputEventKey(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pressed");

        public void set_pressed(bool pressed)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), pressed);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_scancode");

        public void set_scancode(int scancode)
        {
            NativeCalls.godot_icall_1_0(method_bind_1, Object.GetPtr(this), scancode);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_scancode");

        public int get_scancode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_unicode");

        public void set_unicode(int unicode)
        {
            NativeCalls.godot_icall_1_0(method_bind_3, Object.GetPtr(this), unicode);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_unicode");

        public int get_unicode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_echo");

        public void set_echo(bool echo)
        {
            NativeCalls.godot_icall_1_7(method_bind_5, Object.GetPtr(this), echo);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_scancode_with_modifiers");

        public int get_scancode_with_modifiers()
        {
            return NativeCalls.godot_icall_0_1(method_bind_6, Object.GetPtr(this));
        }
    }
}
