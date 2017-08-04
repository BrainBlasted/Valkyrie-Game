using System;

namespace GodotEngine
{
    public class AudioEffectChorus : AudioEffect
    {
        private const string nativeName = "AudioEffectChorus";

        public AudioEffectChorus() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectChorus_Ctor(this);
        }

        internal AudioEffectChorus(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_voice_count");

        public void set_voice_count(int voices)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), voices);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_voice_count");

        public int get_voice_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_voice_delay_ms");

        public void set_voice_delay_ms(int voice_idx, float delay_ms)
        {
            NativeCalls.godot_icall_2_45(method_bind_2, Object.GetPtr(this), voice_idx, delay_ms);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_voice_delay_ms");

        public float get_voice_delay_ms(int voice_idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_3, Object.GetPtr(this), voice_idx);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_voice_rate_hz");

        public void set_voice_rate_hz(int voice_idx, float rate_hz)
        {
            NativeCalls.godot_icall_2_45(method_bind_4, Object.GetPtr(this), voice_idx, rate_hz);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_voice_rate_hz");

        public float get_voice_rate_hz(int voice_idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_5, Object.GetPtr(this), voice_idx);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_voice_depth_ms");

        public void set_voice_depth_ms(int voice_idx, float depth_ms)
        {
            NativeCalls.godot_icall_2_45(method_bind_6, Object.GetPtr(this), voice_idx, depth_ms);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_voice_depth_ms");

        public float get_voice_depth_ms(int voice_idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_7, Object.GetPtr(this), voice_idx);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_voice_level_db");

        public void set_voice_level_db(int voice_idx, float level_db)
        {
            NativeCalls.godot_icall_2_45(method_bind_8, Object.GetPtr(this), voice_idx, level_db);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_voice_level_db");

        public float get_voice_level_db(int voice_idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_9, Object.GetPtr(this), voice_idx);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_voice_cutoff_hz");

        public void set_voice_cutoff_hz(int voice_idx, float cutoff_hz)
        {
            NativeCalls.godot_icall_2_45(method_bind_10, Object.GetPtr(this), voice_idx, cutoff_hz);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_voice_cutoff_hz");

        public float get_voice_cutoff_hz(int voice_idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_11, Object.GetPtr(this), voice_idx);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_voice_pan");

        public void set_voice_pan(int voice_idx, float pan)
        {
            NativeCalls.godot_icall_2_45(method_bind_12, Object.GetPtr(this), voice_idx, pan);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_voice_pan");

        public float get_voice_pan(int voice_idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_13, Object.GetPtr(this), voice_idx);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_wet");

        public void set_wet(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_wet");

        public float get_wet()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dry");

        public void set_dry(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_16, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dry");

        public float get_dry()
        {
            return NativeCalls.godot_icall_0_11(method_bind_17, Object.GetPtr(this));
        }
    }
}
