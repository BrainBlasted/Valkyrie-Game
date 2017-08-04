using System;

namespace GodotEngine
{
    /// <summary>
    /// Horizontal box container. See [BoxContainer].
    /// </summary>
    public class HBoxContainer : BoxContainer
    {
        private const string nativeName = "HBoxContainer";

        public HBoxContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_HBoxContainer_Ctor(this);
        }

        internal HBoxContainer(bool memoryOwn) : base(memoryOwn) {}
    }
}
