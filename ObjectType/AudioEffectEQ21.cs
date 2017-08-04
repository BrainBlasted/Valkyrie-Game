using System;

namespace GodotEngine
{
    public class AudioEffectEQ21 : AudioEffectEQ
    {
        private const string nativeName = "AudioEffectEQ21";

        public AudioEffectEQ21() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectEQ21_Ctor(this);
        }

        internal AudioEffectEQ21(bool memoryOwn) : base(memoryOwn) {}
    }
}
