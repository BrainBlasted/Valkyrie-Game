using System;

namespace GodotEngine
{
    public class AudioEffectPitchShift : AudioEffect
    {
        private const string nativeName = "AudioEffectPitchShift";

        public AudioEffectPitchShift() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectPitchShift_Ctor(this);
        }

        internal AudioEffectPitchShift(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pitch_scale");

        public void set_pitch_scale(float rate)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), rate);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pitch_scale");

        public float get_pitch_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }
    }
}
