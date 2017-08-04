using System;

namespace GodotEngine
{
    /// <summary>
    /// Horizontal scroll bar. See [ScrollBar]. This one goes from left (min) to right (max).
    /// </summary>
    public class HScrollBar : ScrollBar
    {
        private const string nativeName = "HScrollBar";

        public HScrollBar() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HScrollBar_Ctor(this);
        }

        internal HScrollBar(bool memoryOwn) : base(memoryOwn) {}
    }
}
