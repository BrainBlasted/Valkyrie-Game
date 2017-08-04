using System;

namespace GodotEngine
{
    public class AudioEffectLowShelfFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectLowShelfFilter";

        public AudioEffectLowShelfFilter() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectLowShelfFilter_Ctor(this);
        }

        internal AudioEffectLowShelfFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}
