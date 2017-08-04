using System;

namespace GodotEngine
{
    public class AudioEffectPhaser : AudioEffect
    {
        private const string nativeName = "AudioEffectPhaser";

        public AudioEffectPhaser() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectPhaser_Ctor(this);
        }

        internal AudioEffectPhaser(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_range_min_hz");

        public void set_range_min_hz(float hz)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), hz);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_range_min_hz");

        public float get_range_min_hz()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_range_max_hz");

        public void set_range_max_hz(float hz)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), hz);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_range_max_hz");

        public float get_range_max_hz()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rate_hz");

        public void set_rate_hz(float hz)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), hz);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rate_hz");

        public float get_rate_hz()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_feedback");

        public void set_feedback(float fbk)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), fbk);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_feedback");

        public float get_feedback()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_depth");

        public void set_depth(float depth)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), depth);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_depth");

        public float get_depth()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }
    }
}
