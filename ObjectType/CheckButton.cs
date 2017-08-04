using System;

namespace GodotEngine
{
    /// <summary>
    /// CheckButton is a toggle button displayed as a check field.
    /// </summary>
    public class CheckButton : Button
    {
        private const string nativeName = "CheckButton";

        public CheckButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CheckButton_Ctor(this);
        }

        internal CheckButton(bool memoryOwn) : base(memoryOwn) {}
    }
}
