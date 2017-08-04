using System;

namespace GodotEngine
{
    public class AudioEffectStereoEnhance : AudioEffect
    {
        private const string nativeName = "AudioEffectStereoEnhance";

        public AudioEffectStereoEnhance() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectStereoEnhance_Ctor(this);
        }

        internal AudioEffectStereoEnhance(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pan_pullout");

        public void set_pan_pullout(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pan_pullout");

        public float get_pan_pullout()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_time_pullout");

        public void set_time_pullout(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_time_pullout");

        public float get_time_pullout()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_surround");

        public void set_surround(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_surround");

        public float get_surround()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }
    }
}
