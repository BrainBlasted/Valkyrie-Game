using System;

namespace GodotEngine
{
    /// <summary>
    /// OGG Vorbis audio stream driver.
    /// </summary>
    public class AudioStreamOGGVorbis : AudioStream
    {
        private const string nativeName = "AudioStreamOGGVorbis";

        public AudioStreamOGGVorbis() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamOGGVorbis_Ctor(this);
        }

        internal AudioStreamOGGVorbis(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_data");

        public void set_data(byte[] data)
        {
            NativeCalls.godot_icall_1_100(method_bind_0, Object.GetPtr(this), data);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_data");

        public byte[] get_data()
        {
            return NativeCalls.godot_icall_0_101(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_loop");

        public void set_loop(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_loop");

        public bool has_loop()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }
    }
}
