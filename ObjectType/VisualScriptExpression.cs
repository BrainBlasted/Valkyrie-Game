using System;

namespace GodotEngine
{
    public class VisualScriptExpression : VisualScriptNode
    {
        private const string nativeName = "VisualScriptExpression";

        public VisualScriptExpression() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptExpression_Ctor(this);
        }

        internal VisualScriptExpression(bool memoryOwn) : base(memoryOwn) {}
    }
}
