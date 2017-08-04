using System;

namespace GodotEngine
{
    public class VisualScriptSelf : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSelf";

        public VisualScriptSelf() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSelf_Ctor(this);
        }

        internal VisualScriptSelf(bool memoryOwn) : base(memoryOwn) {}
    }
}
