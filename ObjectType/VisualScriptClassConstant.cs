using System;

namespace GodotEngine
{
    public class VisualScriptClassConstant : VisualScriptNode
    {
        private const string nativeName = "VisualScriptClassConstant";

        public VisualScriptClassConstant() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptClassConstant_Ctor(this);
        }

        internal VisualScriptClassConstant(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_class_constant");

        public void set_class_constant(string name)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_class_constant");

        public string get_class_constant()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_base_type");

        public void set_base_type(string name)
        {
            NativeCalls.godot_icall_1_35(method_bind_2, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_base_type");

        public string get_base_type()
        {
            return NativeCalls.godot_icall_0_2(method_bind_3, Object.GetPtr(this));
        }
    }
}
