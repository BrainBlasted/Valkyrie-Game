using System;

namespace GodotEngine
{
    public class VisualScriptIndexSet : VisualScriptNode
    {
        private const string nativeName = "VisualScriptIndexSet";

        public VisualScriptIndexSet() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptIndexSet_Ctor(this);
        }

        internal VisualScriptIndexSet(bool memoryOwn) : base(memoryOwn) {}
    }
}
