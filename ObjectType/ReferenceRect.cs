using System;

namespace GodotEngine
{
    /// <summary>
    /// Reference frame for GUI. It's just like an empty control, except a red box is displayed while editing around its size at all times.
    /// </summary>
    public class ReferenceRect : Control
    {
        private const string nativeName = "ReferenceRect";

        public ReferenceRect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ReferenceRect_Ctor(this);
        }

        internal ReferenceRect(bool memoryOwn) : base(memoryOwn) {}
    }
}
