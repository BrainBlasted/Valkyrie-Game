using System;

namespace GodotEngine
{
    public class AudioEffectEQ6 : AudioEffectEQ
    {
        private const string nativeName = "AudioEffectEQ6";

        public AudioEffectEQ6() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectEQ6_Ctor(this);
        }

        internal AudioEffectEQ6(bool memoryOwn) : base(memoryOwn) {}
    }
}
