using System;

namespace GodotEngine
{
    public class AudioBusLayout : Resource
    {
        private const string nativeName = "AudioBusLayout";

        public AudioBusLayout() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioBusLayout_Ctor(this);
        }

        internal AudioBusLayout(bool memoryOwn) : base(memoryOwn) {}
    }
}
