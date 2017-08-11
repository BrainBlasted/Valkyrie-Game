using System;

namespace GodotEngine
{
    public class AudioStreamPlayer2D : Node2D
    {
        private const string nativeName = "AudioStreamPlayer2D";

        public AudioStreamPlayer2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamPlayer2D_Ctor(this);
        }

        internal AudioStreamPlayer2D(bool memoryOwn) : base(memoryOwn) {}

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

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_max_distance");

        public void set_max_distance(float pixels)
        {
            NativeCalls.godot_icall_1_10(method_bind_13, Object.GetPtr(this), pixels);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_max_distance");

        public float get_max_distance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_attenuation");

        public void set_attenuation(float curve)
        {
            NativeCalls.godot_icall_1_10(method_bind_15, Object.GetPtr(this), curve);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_attenuation");

        public float get_attenuation()
        {
            return NativeCalls.godot_icall_0_11(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_area_mask");

        public void set_area_mask(int mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_17, Object.GetPtr(this), mask);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_area_mask");

        public int get_area_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_18, Object.GetPtr(this));
        }
    }
}
