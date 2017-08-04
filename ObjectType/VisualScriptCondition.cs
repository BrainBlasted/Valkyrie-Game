using System;

namespace GodotEngine
{
    public class VisualScriptCondition : VisualScriptNode
    {
        private const string nativeName = "VisualScriptCondition";

        public VisualScriptCondition() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptCondition_Ctor(this);
        }

        internal VisualScriptCondition(bool memoryOwn) : base(memoryOwn) {}
    }
}
