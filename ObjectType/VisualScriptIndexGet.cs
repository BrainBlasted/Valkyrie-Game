using System;

namespace GodotEngine
{
    public class VisualScriptIndexGet : VisualScriptNode
    {
        private const string nativeName = "VisualScriptIndexGet";

        public VisualScriptIndexGet() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptIndexGet_Ctor(this);
        }

        internal VisualScriptIndexGet(bool memoryOwn) : base(memoryOwn) {}
    }
}
