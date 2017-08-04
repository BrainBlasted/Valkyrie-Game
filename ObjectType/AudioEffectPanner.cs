using System;

namespace GodotEngine
{
    public class AudioEffectPanner : AudioEffect
    {
        private const string nativeName = "AudioEffectPanner";

        public AudioEffectPanner() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioEffectPanner_Ctor(this);
        }

        internal AudioEffectPanner(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pan");

        public void set_pan(float cpanume)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), cpanume);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pan");

        public float get_pan()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }
    }
}
