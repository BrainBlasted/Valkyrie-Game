using System;

namespace GodotEngine
{
    public class VisualScriptBasicTypeConstant : VisualScriptNode
    {
        private const string nativeName = "VisualScriptBasicTypeConstant";

        public VisualScriptBasicTypeConstant() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptBasicTypeConstant_Ctor(this);
        }

        internal VisualScriptBasicTypeConstant(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_basic_type");

        public void set_basic_type(int name)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_basic_type");

        public int get_basic_type()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_basic_type_constant");

        public void set_basic_type_constant(string name)
        {
            NativeCalls.godot_icall_1_34(method_bind_2, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_basic_type_constant");

        public string get_basic_type_constant()
        {
            return NativeCalls.godot_icall_0_2(method_bind_3, Object.GetPtr(this));
        }
    }
}
