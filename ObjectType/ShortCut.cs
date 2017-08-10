using System;

namespace GodotEngine
{
    public class ShortCut : Resource
    {
        private const string nativeName = "ShortCut";

        public ShortCut() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ShortCut_Ctor(this);
        }

        internal ShortCut(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shortcut");

        public void set_shortcut(InputEvent @event)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(@event));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shortcut");

        public InputEvent get_shortcut()
        {
            return NativeCalls.godot_icall_0_437(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_valid");

        public bool is_valid()
        {
            return NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_shortcut");

        public bool is_shortcut(InputEvent @event)
        {
            return NativeCalls.godot_icall_1_253(method_bind_3, Object.GetPtr(this), Object.GetPtr(@event));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_as_text");

        public string get_as_text()
        {
            return NativeCalls.godot_icall_0_2(method_bind_4, Object.GetPtr(this));
        }
    }
}
