using System;

namespace GodotEngine
{
    public class AudioStreamSample : AudioStream
    {
        private const string nativeName = "AudioStreamSample";

        public AudioStreamSample() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamSample_Ctor(this);
        }

        internal AudioStreamSample(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_format");

        public void set_format(int format)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), format);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_format");

        public int get_format()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_loop_mode");

        public void set_loop_mode(int loop_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), loop_mode);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_loop_mode");

        public int get_loop_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_loop_begin");

        public void set_loop_begin(int loop_begin)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), loop_begin);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_loop_begin");

        public int get_loop_begin()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_loop_end");

        public void set_loop_end(int loop_end)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), loop_end);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_loop_end");

        public int get_loop_end()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_mix_rate");

        public void set_mix_rate(int mix_rate)
        {
            NativeCalls.godot_icall_1_0(method_bind_8, Object.GetPtr(this), mix_rate);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mix_rate");

        public int get_mix_rate()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_stereo");

        public void set_stereo(bool stereo)
        {
            NativeCalls.godot_icall_1_7(method_bind_10, Object.GetPtr(this), stereo);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_stereo");

        public bool is_stereo()
        {
            return NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_data");

        public void set_data(byte[] data)
        {
            NativeCalls.godot_icall_1_99(method_bind_12, Object.GetPtr(this), data);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_data");

        public byte[] get_data()
        {
            return NativeCalls.godot_icall_0_100(method_bind_13, Object.GetPtr(this));
        }
    }
}
