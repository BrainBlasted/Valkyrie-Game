using System;

namespace GodotEngine
{
    public class ToolButton : Button
    {
        private const string nativeName = "ToolButton";

        public ToolButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ToolButton_Ctor(this);
        }

        internal ToolButton(bool memoryOwn) : base(memoryOwn) {}
    }
}
