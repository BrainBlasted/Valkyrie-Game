using System;

namespace GodotEngine
{
    /// <summary>
    /// PacketPeer is an abstraction and base class for packet-based protocols (such as UDP). It provides an API for sending and receiving packets both as raw data or variables. This makes it easy to transfer data over a protocol, without having to encode data as low level bytes or having to worry about network ordering.
    /// </summary>
    public class PacketPeer : Reference
    {
        private const string nativeName = "PacketPeer";

        internal PacketPeer() {}

        internal PacketPeer(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_var");

        /// <summary>
        /// Get a Variant.
        /// </summary>
        public object get_var()
        {
            return NativeCalls.godot_icall_0_120(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "put_var");

        /// <summary>
        /// Send a Variant as a packet.
        /// </summary>
        public int put_var(object var)
        {
            return NativeCalls.godot_icall_1_334(method_bind_1, Object.GetPtr(this), var);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_packet");

        /// <summary>
        /// Get a raw packet.
        /// </summary>
        public byte[] get_packet()
        {
            return NativeCalls.godot_icall_0_100(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "put_packet");

        /// <summary>
        /// Send a raw packet.
        /// </summary>
        public Error put_packet(byte[] buffer)
        {
            int ret = NativeCalls.godot_icall_1_335(method_bind_3, Object.GetPtr(this), buffer);
            return (Error)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_packet_error");

        /// <summary>
        /// Return the error state of the last packet received (via [method get_packet] and [method get_var]).
        /// </summary>
        public Error get_packet_error()
        {
            int ret = NativeCalls.godot_icall_0_235(method_bind_4, Object.GetPtr(this));
            return (Error)ret;
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_available_packet_count");

        /// <summary>
        /// Return the number of packets currently available in the ring-buffer.
        /// </summary>
        public int get_available_packet_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }
    }
}
