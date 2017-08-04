using System;

namespace GodotEngine
{
    public class VisualScriptFunctionState : Reference
    {
        private const string nativeName = "VisualScriptFunctionState";

        internal VisualScriptFunctionState() {}

        internal VisualScriptFunctionState(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "connect_to_signal");

        public void connect_to_signal(Object obj, string signals, object[] args)
        {
            NativeCalls.godot_icall_3_516(method_bind_0, Object.GetPtr(this), Object.GetPtr(obj), signals, args);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "resume");

        public object[] resume(object[] args = null)
        {
            return NativeCalls.godot_icall_1_517(method_bind_1, Object.GetPtr(this), args);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_valid");

        public bool is_valid()
        {
            return NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }
    }
}
