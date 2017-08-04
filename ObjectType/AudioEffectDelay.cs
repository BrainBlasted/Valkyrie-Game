using System;

namespace GodotEngine
{
    public class AudioEffectDelay : AudioEffect
    {
        private const string nativeName = "AudioEffectDelay";

        public AudioEffectDelay() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectDelay_Ctor(this);
        }

        internal AudioEffectDelay(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dry");

        public void set_dry(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dry");

        public float get_dry()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tap1_active");

        public void set_tap1_active(bool amount)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_tap1_active");

        public bool is_tap1_active()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tap1_delay_ms");

        public void set_tap1_delay_ms(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tap1_delay_ms");

        public float get_tap1_delay_ms()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tap1_level_db");

        public void set_tap1_level_db(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tap1_level_db");

        public float get_tap1_level_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tap1_pan");

        public void set_tap1_pan(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tap1_pan");

        public float get_tap1_pan()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tap2_active");

        public void set_tap2_active(bool amount)
        {
            NativeCalls.godot_icall_1_7(method_bind_10, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_tap2_active");

        public bool is_tap2_active()
        {
            return NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tap2_delay_ms");

        public void set_tap2_delay_ms(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_12, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tap2_delay_ms");

        public float get_tap2_delay_ms()
        {
            return NativeCalls.godot_icall_0_11(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tap2_level_db");

        public void set_tap2_level_db(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tap2_level_db");

        public float get_tap2_level_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tap2_pan");

        public void set_tap2_pan(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_16, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tap2_pan");

        public float get_tap2_pan()
        {
            return NativeCalls.godot_icall_0_11(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_feedback_active");

        public void set_feedback_active(bool amount)
        {
            NativeCalls.godot_icall_1_7(method_bind_18, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_feedback_active");

        public bool is_feedback_active()
        {
            return NativeCalls.godot_icall_0_3(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_feedback_delay_ms");

        public void set_feedback_delay_ms(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_20, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_feedback_delay_ms");

        public float get_feedback_delay_ms()
        {
            return NativeCalls.godot_icall_0_11(method_bind_21, Object.GetPtr(this));
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_feedback_level_db");

        public void set_feedback_level_db(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_22, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_feedback_level_db");

        public float get_feedback_level_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_23, Object.GetPtr(this));
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_feedback_lowpass");

        public void set_feedback_lowpass(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_24, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_feedback_lowpass");

        public float get_feedback_lowpass()
        {
            return NativeCalls.godot_icall_0_11(method_bind_25, Object.GetPtr(this));
        }
    }
}
