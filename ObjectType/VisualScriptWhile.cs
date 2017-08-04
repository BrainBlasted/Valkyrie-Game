using System;

namespace GodotEngine
{
    public class VisualScriptWhile : VisualScriptNode
    {
        private const string nativeName = "VisualScriptWhile";

        public VisualScriptWhile() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptWhile_Ctor(this);
        }

        internal VisualScriptWhile(bool memoryOwn) : base(memoryOwn) {}
    }
}
