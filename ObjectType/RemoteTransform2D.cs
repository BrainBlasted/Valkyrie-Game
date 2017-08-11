using System;

namespace GodotEngine
{
    public class RemoteTransform2D : Node2D
    {
        private const string nativeName = "RemoteTransform2D";

        public RemoteTransform2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RemoteTransform2D_Ctor(this);
        }

        internal RemoteTransform2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_remote_node");

        public void set_remote_node(NodePath path)
        {
            NativeCalls.godot_icall_1_65(method_bind_0, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_remote_node");

        public NodePath get_remote_node()
        {
            IntPtr ret = NativeCalls.godot_icall_0_66(method_bind_1, Object.GetPtr(this));
            return new NodePath(ret);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_use_global_coordinates");

        public void set_use_global_coordinates(bool use_global_coordinates)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), use_global_coordinates);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_use_global_coordinates");

        public bool get_use_global_coordinates()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_update_position");

        public void set_update_position(bool update_remote_position)
        {
            NativeCalls.godot_icall_1_7(method_bind_4, Object.GetPtr(this), update_remote_position);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_update_position");

        public bool get_update_position()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_update_rotation");

        public void set_update_rotation(bool update_remote_rotation)
        {
            NativeCalls.godot_icall_1_7(method_bind_6, Object.GetPtr(this), update_remote_rotation);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_update_rotation");

        public bool get_update_rotation()
        {
            return NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_update_scale");

        public void set_update_scale(bool update_remote_scale)
        {
            NativeCalls.godot_icall_1_7(method_bind_8, Object.GetPtr(this), update_remote_scale);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_update_scale");

        public bool get_update_scale()
        {
            return NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }
    }
}
