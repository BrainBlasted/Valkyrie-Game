using System;

namespace GodotEngine
{
    public class AudioEffectReverb : AudioEffect
    {
        private const string nativeName = "AudioEffectReverb";

        public AudioEffectReverb() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectReverb_Ctor(this);
        }

        internal AudioEffectReverb(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_predelay_msec");

        public void set_predelay_msec(float msec)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), msec);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_predelay_msec");

        public float get_predelay_msec()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_predelay_feedback");

        public void set_predelay_feedback(float feedback)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), feedback);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_predelay_feedback");

        public float get_predelay_feedback()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_room_size");

        public void set_room_size(float size)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), size);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_room_size");

        public float get_room_size()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_damping");

        public void set_damping(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_damping");

        public float get_damping()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_spread");

        public void set_spread(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_spread");

        public float get_spread()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dry");

        public void set_dry(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_10, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dry");

        public float get_dry()
        {
            return NativeCalls.godot_icall_0_11(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_wet");

        public void set_wet(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_12, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_wet");

        public float get_wet()
        {
            return NativeCalls.godot_icall_0_11(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_hpf");

        public void set_hpf(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_hpf");

        public float get_hpf()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }
    }
}
