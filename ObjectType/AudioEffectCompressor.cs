using System;

namespace GodotEngine
{
    public class AudioEffectCompressor : AudioEffect
    {
        private const string nativeName = "AudioEffectCompressor";

        public AudioEffectCompressor() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectCompressor_Ctor(this);
        }

        internal AudioEffectCompressor(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_threshold");

        public void set_threshold(float threshold)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), threshold);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_threshold");

        public float get_threshold()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ratio");

        public void set_ratio(float ratio)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), ratio);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ratio");

        public float get_ratio()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_gain");

        public void set_gain(float gain)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), gain);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_gain");

        public float get_gain()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_attack_us");

        public void set_attack_us(float attack_us)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), attack_us);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_attack_us");

        public float get_attack_us()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_release_ms");

        public void set_release_ms(float release_ms)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), release_ms);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_release_ms");

        public float get_release_ms()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_mix");

        public void set_mix(float mix)
        {
            NativeCalls.godot_icall_1_10(method_bind_10, Object.GetPtr(this), mix);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mix");

        public float get_mix()
        {
            return NativeCalls.godot_icall_0_11(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sidechain");

        public void set_sidechain(string sidechain)
        {
            NativeCalls.godot_icall_1_35(method_bind_12, Object.GetPtr(this), sidechain);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sidechain");

        public string get_sidechain()
        {
            return NativeCalls.godot_icall_0_2(method_bind_13, Object.GetPtr(this));
        }
    }
}
