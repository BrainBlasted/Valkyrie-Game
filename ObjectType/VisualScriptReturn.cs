using System;

namespace GodotEngine
{
    public class VisualScriptReturn : VisualScriptNode
    {
        private const string nativeName = "VisualScriptReturn";

        public VisualScriptReturn() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptReturn_Ctor(this);
        }

        internal VisualScriptReturn(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_return_type");

        public void set_return_type(int type)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), type);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_return_type");

        public int get_return_type()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_enable_return_value");

        public void set_enable_return_value(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_return_value_enabled");

        public bool is_return_value_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }
    }
}
