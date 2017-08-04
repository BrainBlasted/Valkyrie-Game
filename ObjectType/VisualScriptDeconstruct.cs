using System;

namespace GodotEngine
{
    public class VisualScriptDeconstruct : VisualScriptNode
    {
        private const string nativeName = "VisualScriptDeconstruct";

        public VisualScriptDeconstruct() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptDeconstruct_Ctor(this);
        }

        internal VisualScriptDeconstruct(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_deconstruct_type");

        public void set_deconstruct_type(int type)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), type);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_deconstruct_type");

        public int get_deconstruct_type()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }
    }
}
