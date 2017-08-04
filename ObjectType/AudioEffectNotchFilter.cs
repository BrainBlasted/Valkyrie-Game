using System;

namespace GodotEngine
{
    public class AudioEffectNotchFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectNotchFilter";

        public AudioEffectNotchFilter() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectNotchFilter_Ctor(this);
        }

        internal AudioEffectNotchFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}
