using System;

namespace GodotEngine
{
    public class AudioEffectHighPassFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectHighPassFilter";

        public AudioEffectHighPassFilter() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectHighPassFilter_Ctor(this);
        }

        internal AudioEffectHighPassFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}
