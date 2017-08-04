using System;

namespace GodotEngine
{
    /// <summary>
    /// UDP packet peer. Can be used to send raw UDP packets as well as [Variant]\ s.
    /// </summary>
    public class PacketPeerUDP : PacketPeer
    {
        private const string nativeName = "PacketPeerUDP";

        public PacketPeerUDP() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PacketPeerUDP_Ctor(this);
        }

        internal PacketPeerUDP(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "listen");

        /// <summary>
        /// Make this [PacketPeerUDP] listen on the "port" binding to "bind_address" with a buffer size "recv_buf_size".
        /// If "bind_address" is set as "*" (default), the peer will listen on all available addresses (both IPv4 and IPv6).
        /// If "bind_address" is set as "0.0.0.0" (for IPv4) or "::" (for IPv6), the peer will listen on all available addresses matching that IP type.
        /// If "bind_address" is set to any valid address (e.g. "192.168.1.101", "::1", etc), the peer will only listen on the interface with that addresses (or fail if no interface with the given address exists).
        /// </summary>
        public Error listen(int port, string bind_address = "*", int recv_buf_size = 65536)
        {
            int ret = NativeCalls.godot_icall_3_336(method_bind_0, Object.GetPtr(this), port, bind_address, recv_buf_size);
            return (Error)ret;
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "close");

        /// <summary>
        /// Close the UDP socket the [PacketPeerUDP] is currently listening on.
        /// </summary>
        public void close()
        {
            NativeCalls.godot_icall_0_8(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "wait");

        /// <summary>
        /// Wait for a packet to arrive on the listening port, see [method listen].
        /// </summary>
        public Error wait()
        {
            int ret = NativeCalls.godot_icall_0_235(method_bind_2, Object.GetPtr(this));
            return (Error)ret;
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_listening");

        /// <summary>
        /// Return whether this [PacketPeerUDP] is listening.
        /// </summary>
        public bool is_listening()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_packet_ip");

        /// <summary>
        /// Return the IP of the remote peer that sent the last packet(that was received with [method get_packet] or [method get_var]).
        /// </summary>
        public string get_packet_ip()
        {
            return NativeCalls.godot_icall_0_2(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_packet_port");

        /// <summary>
        /// Return the port of the remote peer that sent the last packet(that was received with [method get_packet] or [method get_var]).
        /// </summary>
        public int get_packet_port()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dest_address");

        /// <summary>
        /// Set the destination address and port for sending packets and variables, a hostname will be resolved using if valid.
        /// </summary>
        public int set_dest_address(string host, int port)
        {
            return NativeCalls.godot_icall_2_238(method_bind_6, Object.GetPtr(this), host, port);
        }
    }
}
