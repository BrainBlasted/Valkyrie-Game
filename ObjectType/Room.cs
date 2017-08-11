using System;

namespace GodotEngine
{
    /// <summary>
    /// Room contains the data to define the bounds of a scene (using a BSP Tree). It is instanced by a [VisualInstance] node to create rooms. See that class documentation for more information about rooms.
    /// </summary>
    public class Room : VisualInstance
    {
        private const string nativeName = "Room";

        public Room() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Room_Ctor(this);
        }

        internal Room(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_room");

        public void set_room(RoomBounds room)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(room));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_room");

        public RoomBounds get_room()
        {
            return NativeCalls.godot_icall_0_416(method_bind_1, Object.GetPtr(this));
        }
    }
}
