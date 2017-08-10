using System;

namespace GodotEngine
{
    public class PlaneShape : Shape
    {
        private const string nativeName = "PlaneShape";

        public PlaneShape() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PlaneShape_Ctor(this);
        }

        internal PlaneShape(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_plane");

        public void set_plane(Plane plane)
        {
            NativeCalls.godot_icall_1_249(method_bind_0, Object.GetPtr(this), ref plane);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_plane");

        public Plane get_plane()
        {
            object ret = NativeCalls.godot_icall_0_398(method_bind_1, Object.GetPtr(this));
            return (Plane)ret;
        }
    }
}
