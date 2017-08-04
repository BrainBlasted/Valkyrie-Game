using System;

namespace GodotEngine
{
    public class AudioEffectEQ : AudioEffect
    {
        private const string nativeName = "AudioEffectEQ";

        internal AudioEffectEQ() {}

        internal AudioEffectEQ(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_band_gain_db");

        public void set_band_gain_db(int band_idx, float volume_db)
        {
            NativeCalls.godot_icall_2_45(method_bind_0, Object.GetPtr(this), band_idx, volume_db);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_band_gain_db");

        public float get_band_gain_db(int band_idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_1, Object.GetPtr(this), band_idx);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_band_count");

        public int get_band_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_2, Object.GetPtr(this));
        }
    }
}
