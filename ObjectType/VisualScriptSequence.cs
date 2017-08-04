using System;

namespace GodotEngine
{
    public class VisualScriptSequence : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSequence";

        public VisualScriptSequence() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSequence_Ctor(this);
        }

        internal VisualScriptSequence(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_steps");

        public void set_steps(int steps)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), steps);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_steps");

        public int get_steps()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }
    }
}
