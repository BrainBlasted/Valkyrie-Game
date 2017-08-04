using System;

namespace GodotEngine
{
    public class AudioEffectBandLimitFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectBandLimitFilter";

        public AudioEffectBandLimitFilter() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectBandLimitFilter_Ctor(this);
        }

        internal AudioEffectBandLimitFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}
