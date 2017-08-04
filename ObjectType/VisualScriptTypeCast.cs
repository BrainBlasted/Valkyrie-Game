using System;

namespace GodotEngine
{
    public class VisualScriptTypeCast : VisualScriptNode
    {
        private const string nativeName = "VisualScriptTypeCast";

        public VisualScriptTypeCast() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptTypeCast_Ctor(this);
        }

        internal VisualScriptTypeCast(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_base_type");

        public void set_base_type(string type)
        {
            NativeCalls.godot_icall_1_34(method_bind_0, Object.GetPtr(this), type);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_base_type");

        public string get_base_type()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_base_script");

        public void set_base_script(string path)
        {
            NativeCalls.godot_icall_1_34(method_bind_2, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_base_script");

        public string get_base_script()
        {
            return NativeCalls.godot_icall_0_2(method_bind_3, Object.GetPtr(this));
        }
    }
}
