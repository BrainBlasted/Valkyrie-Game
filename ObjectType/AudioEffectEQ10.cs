using System;

namespace GodotEngine
{
    public class AudioEffectEQ10 : AudioEffectEQ
    {
        private const string nativeName = "AudioEffectEQ10";

        public AudioEffectEQ10() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectEQ10_Ctor(this);
        }

        internal AudioEffectEQ10(bool memoryOwn) : base(memoryOwn) {}
    }
}
