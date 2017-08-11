using System;

namespace GodotEngine
{
    /// <summary>
    /// PacketStreamPeer provides a wrapper for working using packets over a stream. This allows for using packet based code with StreamPeers. PacketPeerStream implements a custom protocol over the StreamPeer, so the user should not read or write to the wrapped StreamPeer directly.
    /// </summary>
    public class PacketPeerStream : PacketPeer
    {
        private const string nativeName = "PacketPeerStream";

        public PacketPeerStream() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PacketPeerStream_Ctor(this);
        }

        internal PacketPeerStream(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_stream_peer");

        public void set_stream_peer(Reference peer)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(peer));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_input_buffer_max_size");

        public void set_input_buffer_max_size(int max_size_bytes)
        {
            NativeCalls.godot_icall_1_0(method_bind_1, Object.GetPtr(this), max_size_bytes);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_output_buffer_max_size");

        public void set_output_buffer_max_size(int max_size_bytes)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), max_size_bytes);
        }
    }
}
