using System;

namespace GodotEngine
{
    public class VisualScriptIterator : VisualScriptNode
    {
        private const string nativeName = "VisualScriptIterator";

        public VisualScriptIterator() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptIterator_Ctor(this);
        }

        internal VisualScriptIterator(bool memoryOwn) : base(memoryOwn) {}
    }
}
