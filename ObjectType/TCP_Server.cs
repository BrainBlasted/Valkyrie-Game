using System;

namespace GodotEngine
{
    /// <summary>
    /// TCP Server class. Listens to connections on a port and returns a [StreamPeerTCP] when got a connection.
    /// </summary>
    public class TCP_Server : Reference
    {
        private const string nativeName = "TCP_Server";

        public TCP_Server() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TCP_Server_Ctor(this);
        }

        internal TCP_Server(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "listen");

        /// <summary>
        /// Listen on the "port" binding to "bind_address".
        /// If "bind_address" is set as "*" (default), the server will listen on all available addresses (both IPv4 and IPv6).
        /// If "bind_address" is set as "0.0.0.0" (for IPv4) or "::" (for IPv6), the server will listen on all available addresses matching that IP type.
        /// If "bind_address" is set to any valid address (e.g. "192.168.1.101", "::1", etc), the server will only listen on the interface with that addresses (or fail if no interface with the given address exists).
        /// </summary>
        public int listen(int port, string bind_address = "*")
        {
            return NativeCalls.godot_icall_2_457(method_bind_0, Object.GetPtr(this), port, bind_address);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_connection_available");

        /// <summary>
        /// Return true if a connection is available for taking.
        /// </summary>
        public bool is_connection_available()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "take_connection");

        /// <summary>
        /// If a connection is available, return a StreamPeerTCP with the connection/
        /// </summary>
        public StreamPeerTCP take_connection()
        {
            return NativeCalls.godot_icall_0_458(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "stop");

        /// <summary>
        /// Stop listening.
        /// </summary>
        public void stop()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this));
        }
    }
}
