using System;

namespace GodotEngine
{
    public class AudioEffectLimiter : AudioEffect
    {
        private const string nativeName = "AudioEffectLimiter";

        public AudioEffectLimiter() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectLimiter_Ctor(this);
        }

        internal AudioEffectLimiter(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ceiling_db");

        public void set_ceiling_db(float ceiling)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), ceiling);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ceiling_db");

        public float get_ceiling_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_threshold_db");

        public void set_threshold_db(float threshold)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), threshold);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_threshold_db");

        public float get_threshold_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_soft_clip_db");

        public void set_soft_clip_db(float soft_clip)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), soft_clip);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_soft_clip_db");

        public float get_soft_clip_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_soft_clip_ratio");

        public void set_soft_clip_ratio(float soft_clip)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), soft_clip);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_soft_clip_ratio");

        public float get_soft_clip_ratio()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }
    }
}
