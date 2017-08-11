using System;

namespace GodotEngine
{
    public class VisualScriptLocalVar : VisualScriptNode
    {
        private const string nativeName = "VisualScriptLocalVar";

        public VisualScriptLocalVar() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptLocalVar_Ctor(this);
        }

        internal VisualScriptLocalVar(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_var_name");

        public void set_var_name(string name)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_var_name");

        public string get_var_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_var_type");

        public void set_var_type(int type)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), type);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_var_type");

        public int get_var_type()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }
    }
}
