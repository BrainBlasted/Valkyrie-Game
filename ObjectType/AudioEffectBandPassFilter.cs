using System;

namespace GodotEngine
{
    public class AudioEffectBandPassFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectBandPassFilter";

        public AudioEffectBandPassFilter() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectBandPassFilter_Ctor(this);
        }

        internal AudioEffectBandPassFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}
