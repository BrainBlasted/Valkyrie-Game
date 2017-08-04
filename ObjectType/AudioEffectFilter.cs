using System;

namespace GodotEngine
{
    public class AudioEffectFilter : AudioEffect
    {
        private const string nativeName = "AudioEffectFilter";

        internal AudioEffectFilter() {}

        internal AudioEffectFilter(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cutoff");

        public void set_cutoff(float freq)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), freq);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cutoff");

        public float get_cutoff()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_resonance");

        public void set_resonance(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_resonance");

        public float get_resonance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_gain");

        public void set_gain(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_gain");

        public float get_gain()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_db");

        public void set_db(int amount)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_db");

        public int get_db()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }
    }
}
