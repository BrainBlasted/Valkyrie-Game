using System;

namespace GodotEngine
{
    public class VisualScriptVariableSet : VisualScriptNode
    {
        private const string nativeName = "VisualScriptVariableSet";

        public VisualScriptVariableSet() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptVariableSet_Ctor(this);
        }

        internal VisualScriptVariableSet(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_variable");

        public void set_variable(string name)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_variable");

        public string get_variable()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }
    }
}
