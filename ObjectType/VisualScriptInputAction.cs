using System;

namespace GodotEngine
{
    public class VisualScriptInputAction : VisualScriptNode
    {
        private const string nativeName = "VisualScriptInputAction";

        public VisualScriptInputAction() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptInputAction_Ctor(this);
        }

        internal VisualScriptInputAction(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_action_name");

        public void set_action_name(string name)
        {
            NativeCalls.godot_icall_1_34(method_bind_0, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_action_name");

        public string get_action_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_action_mode");

        public void set_action_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_action_mode");

        public int get_action_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }
    }
}
