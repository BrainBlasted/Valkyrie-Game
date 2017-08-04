using System;

namespace GodotEngine
{
    public class VisualScriptSubCall : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSubCall";

        public VisualScriptSubCall() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSubCall_Ctor(this);
        }

        internal VisualScriptSubCall(bool memoryOwn) : base(memoryOwn) {}
    }
}
