using System;

namespace GodotEngine
{
    public class ARVRCamera : Camera
    {
        private const string nativeName = "ARVRCamera";

        public ARVRCamera() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRCamera_Ctor(this);
        }

        internal ARVRCamera(bool memoryOwn) : base(memoryOwn) {}
    }
}
