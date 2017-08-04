using System;

namespace GodotEngine
{
    public class AudioEffectLowPassFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectLowPassFilter";

        public AudioEffectLowPassFilter() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectLowPassFilter_Ctor(this);
        }

        internal AudioEffectLowPassFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}
