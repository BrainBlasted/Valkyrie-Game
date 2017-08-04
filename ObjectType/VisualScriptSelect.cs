using System;

namespace GodotEngine
{
    public class VisualScriptSelect : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSelect";

        public VisualScriptSelect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSelect_Ctor(this);
        }

        internal VisualScriptSelect(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_typed");

        public void set_typed(int type)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), type);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_typed");

        public int get_typed()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }
    }
}
