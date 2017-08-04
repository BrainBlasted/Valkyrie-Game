using System;

namespace GodotEngine
{
    /// <summary>
    /// Empty stylebox (really does not display anything).
    /// </summary>
    public class StyleBoxEmpty : StyleBox
    {
        private const string nativeName = "StyleBoxEmpty";

        public StyleBoxEmpty() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StyleBoxEmpty_Ctor(this);
        }

        internal StyleBoxEmpty(bool memoryOwn) : base(memoryOwn) {}
    }
}
