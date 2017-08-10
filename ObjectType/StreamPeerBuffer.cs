using System;

namespace GodotEngine
{
    public class StreamPeerBuffer : StreamPeer
    {
        private const string nativeName = "StreamPeerBuffer";

        public StreamPeerBuffer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StreamPeerBuffer_Ctor(this);
        }

        internal StreamPeerBuffer(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "seek");

        public void seek(int pos)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), pos);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_size");

        public int get_size()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pos");

        public int get_pos()
        {
            return NativeCalls.godot_icall_0_1(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "resize");

        public void resize(int size)
        {
            NativeCalls.godot_icall_1_0(method_bind_3, Object.GetPtr(this), size);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_data_array");

        public void set_data_array(byte[] data)
        {
            NativeCalls.godot_icall_1_99(method_bind_4, Object.GetPtr(this), data);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_data_array");

        public byte[] get_data_array()
        {
            return NativeCalls.godot_icall_0_100(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        public void clear()
        {
            NativeCalls.godot_icall_0_8(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "duplicate");

        public StreamPeerBuffer duplicate()
        {
            return NativeCalls.godot_icall_0_448(method_bind_7, Object.GetPtr(this));
        }
    }
}
