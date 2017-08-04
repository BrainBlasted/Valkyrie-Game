using System;

namespace GodotEngine
{
    public class VisualScriptSwitch : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSwitch";

        public VisualScriptSwitch() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSwitch_Ctor(this);
        }

        internal VisualScriptSwitch(bool memoryOwn) : base(memoryOwn) {}
    }
}
