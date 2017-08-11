using System;

namespace GodotEngine
{
    public class VisualScriptEmitSignal : VisualScriptNode
    {
        private const string nativeName = "VisualScriptEmitSignal";

        public VisualScriptEmitSignal() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptEmitSignal_Ctor(this);
        }

        internal VisualScriptEmitSignal(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_signal");

        public void set_signal(string name)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_signal");

        public string get_signal()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }
    }
}
