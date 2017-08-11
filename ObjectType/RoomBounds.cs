using System;

namespace GodotEngine
{
    public class RoomBounds : Resource
    {
        private const string nativeName = "RoomBounds";

        public RoomBounds() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RoomBounds_Ctor(this);
        }

        internal RoomBounds(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_geometry_hint");

        public void set_geometry_hint(Vector3[] triangles)
        {
            NativeCalls.godot_icall_1_159(method_bind_0, Object.GetPtr(this), triangles);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_geometry_hint");

        public Vector3[] get_geometry_hint()
        {
            return NativeCalls.godot_icall_0_160(method_bind_1, Object.GetPtr(this));
        }
    }
}
