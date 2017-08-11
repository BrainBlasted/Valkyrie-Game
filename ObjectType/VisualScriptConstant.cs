using System;

namespace GodotEngine
{
    public class VisualScriptConstant : VisualScriptNode
    {
        private const string nativeName = "VisualScriptConstant";

        public VisualScriptConstant() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptConstant_Ctor(this);
        }

        internal VisualScriptConstant(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_constant_type");

        public void set_constant_type(int type)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), type);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_constant_type");

        public int get_constant_type()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_constant_value");

        public void set_constant_value(object value)
        {
            NativeCalls.godot_icall_1_120(method_bind_2, Object.GetPtr(this), value);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_constant_value");

        public object get_constant_value()
        {
            return NativeCalls.godot_icall_0_121(method_bind_3, Object.GetPtr(this));
        }
    }
}
