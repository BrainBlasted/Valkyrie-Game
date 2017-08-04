using System;

namespace GodotEngine
{
    public class AudioEffectAmplify : AudioEffect
    {
        private const string nativeName = "AudioEffectAmplify";

        public AudioEffectAmplify() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectAmplify_Ctor(this);
        }

        internal AudioEffectAmplify(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_volume_db");

        public void set_volume_db(float volume)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), volume);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_volume_db");

        public float get_volume_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }
    }
}
