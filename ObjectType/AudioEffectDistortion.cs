using System;

namespace GodotEngine
{
    public class AudioEffectDistortion : AudioEffect
    {
        private const string nativeName = "AudioEffectDistortion";

        public AudioEffectDistortion() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectDistortion_Ctor(this);
        }

        internal AudioEffectDistortion(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_mode");

        public void set_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mode");

        public int get_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pre_gain");

        public void set_pre_gain(float pre_gain)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), pre_gain);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pre_gain");

        public float get_pre_gain()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_keep_hf_hz");

        public void set_keep_hf_hz(float keep_hf_hz)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), keep_hf_hz);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_keep_hf_hz");

        public float get_keep_hf_hz()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_drive");

        public void set_drive(float drive)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), drive);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_drive");

        public float get_drive()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_post_gain");

        public void set_post_gain(float post_gain)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), post_gain);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_post_gain");

        public float get_post_gain()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }
    }
}
