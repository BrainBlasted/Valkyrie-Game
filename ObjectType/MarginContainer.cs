using System;

namespace GodotEngine
{
    /// <summary>
    /// Simple margin container. Adds a left margin to anything contained.
    /// </summary>
    public class MarginContainer : Container
    {
        private const string nativeName = "MarginContainer";

        public MarginContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MarginContainer_Ctor(this);
        }

        internal MarginContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}
