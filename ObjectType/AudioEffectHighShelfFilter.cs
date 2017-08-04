using System;

namespace GodotEngine
{
    public class AudioEffectHighShelfFilter : AudioEffectFilter
    {
        private const string nativeName = "AudioEffectHighShelfFilter";

        public AudioEffectHighShelfFilter() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectHighShelfFilter_Ctor(this);
        }

        internal AudioEffectHighShelfFilter(bool memoryOwn) : base(memoryOwn) {}
    }
}
