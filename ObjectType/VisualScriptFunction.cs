using System;

namespace GodotEngine
{
    public class VisualScriptFunction : VisualScriptNode
    {
        private const string nativeName = "VisualScriptFunction";

        public VisualScriptFunction() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptFunction_Ctor(this);
        }

        internal VisualScriptFunction(bool memoryOwn) : base(memoryOwn) {}
    }
}
