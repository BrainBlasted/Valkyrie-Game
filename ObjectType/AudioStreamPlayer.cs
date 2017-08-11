using System;

namespace GodotEngine
{
    public class AudioStreamPlayer : Node
    {
        private const string nativeName = "AudioStreamPlayer";

        public AudioStreamPlayer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamPlayer_Ctor(this);
        }

        internal AudioStreamPlayer(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_stream");

        public void set_stream(AudioStream stream)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(stream));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_stream");

        public AudioStream get_stream()
        {
            return NativeCalls.godot_icall_0_102(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_volume_db");

        public void set_volume_db(float volume_db)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), volume_db);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_volume_db");

        public float get_volume_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "play");

        public void play(float from_pos = 0f)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), from_pos);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "seek");

        public void seek(float to_pos)
        {
            NativeCalls.godot_icall_1_10(method_bind_5, Object.GetPtr(this), to_pos);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "stop");

        public void stop()
        {
            NativeCalls.godot_icall_0_8(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_playing");

        public bool is_playing()
        {
            return NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pos");

        public float get_pos()
        {
            return NativeCalls.godot_icall_0_11(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus");

        public void set_bus(string bus)
        {
            NativeCalls.godot_icall_1_35(method_bind_9, Object.GetPtr(this), bus);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus");

        public string get_bus()
        {
            return NativeCalls.godot_icall_0_2(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_autoplay");

        public void set_autoplay(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_11, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_autoplay_enabled");

        public bool is_autoplay_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_mix_target");

        public void set_mix_target(int mix_target)
        {
            NativeCalls.godot_icall_1_0(method_bind_13, Object.GetPtr(this), mix_target);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mix_target");

        public int get_mix_target()
        {
            return NativeCalls.godot_icall_0_1(method_bind_14, Object.GetPtr(this));
        }
    }
}
