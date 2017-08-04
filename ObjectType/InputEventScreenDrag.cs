using System;

namespace GodotEngine
{
    public class InputEventScreenDrag : InputEvent
    {
        private const string nativeName = "InputEventScreenDrag";

        public InputEventScreenDrag() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_InputEventScreenDrag_Ctor(this);
        }

        internal InputEventScreenDrag(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_index");

        public void set_index(int index)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_index");

        public int get_index()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_position");

        public void set_position(Vector2 position)
        {
            NativeCalls.godot_icall_1_37(method_bind_2, Object.GetPtr(this), ref position);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_position");

        public Vector2 get_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_3, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_relative");

        public void set_relative(Vector2 relative)
        {
            NativeCalls.godot_icall_1_37(method_bind_4, Object.GetPtr(this), ref relative);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_relative");

        public Vector2 get_relative()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_5, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_speed");

        public void set_speed(Vector2 speed)
        {
            NativeCalls.godot_icall_1_37(method_bind_6, Object.GetPtr(this), ref speed);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_speed");

        public Vector2 get_speed()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_7, Object.GetPtr(this));
            return (Vector2)ret;
        }
    }
}
