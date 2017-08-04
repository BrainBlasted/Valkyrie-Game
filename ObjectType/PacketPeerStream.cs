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

        /// <summary>
        /// Set the StreamPeer object to be wrapped
        /// </summary>
        public void set_stream_peer(StreamPeer peer)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(peer));
        }
    }
}
