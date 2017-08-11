using System;

namespace GodotEngine
{
    public class AudioStreamRandomPitch : AudioStream
    {
        private const string nativeName = "AudioStreamRandomPitch";

        public AudioStreamRandomPitch() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamRandomPitch_Ctor(this);
        }

        internal AudioStreamRandomPitch(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_audio_stream");

        public void set_audio_stream(AudioStream stream)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(stream));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_audio_stream");

        public AudioStream get_audio_stream()
        {
            return NativeCalls.godot_icall_0_102(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_random_pitch");

        public void set_random_pitch(float scale)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), scale);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_random_pitch");

        public float get_random_pitch()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }
    }
}
