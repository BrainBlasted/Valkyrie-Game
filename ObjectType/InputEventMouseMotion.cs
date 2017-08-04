using System;

namespace GodotEngine
{
    public class InputEventMouseMotion : InputEventMouse
    {
        private const string nativeName = "InputEventMouseMotion";

        public InputEventMouseMotion() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventMouseMotion_Ctor(this);
        }

        internal InputEventMouseMotion(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_relative");

        public void set_relative(Vector2 relative)
        {
            NativeCalls.godot_icall_1_37(method_bind_0, Object.GetPtr(this), ref relative);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_relative");

        public Vector2 get_relative()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_1, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_speed");

        public void set_speed(Vector2 speed)
        {
            NativeCalls.godot_icall_1_37(method_bind_2, Object.GetPtr(this), ref speed);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_speed");

        public Vector2 get_speed()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_3, Object.GetPtr(this));
            return (Vector2)ret;
        }
    }
}
