using System;

namespace GodotEngine
{
    /// <summary>
    /// Vertical version of [Separator]. It is used to separate objects horizontally, though (but it looks vertical!).
    /// </summary>
    public class VSeparator : Separator
    {
        private const string nativeName = "VSeparator";

        public VSeparator() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VSeparator_Ctor(this);
        }

        internal VSeparator(bool memoryOwn) : base(memoryOwn) {}
    }
}
