using System;

namespace GodotEngine
{
    /// <summary>
    /// Box shape resource, which can be set into a [PhysicsBody] or area.
    /// </summary>
    public class BoxShape : Shape
    {
        private const string nativeName = "BoxShape";

        public BoxShape() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BoxShape_Ctor(this);
        }

        internal BoxShape(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_extents");

        /// <summary>
        /// Set the half extents for the shape.
        /// </summary>
        public void set_extents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_83(method_bind_0, Object.GetPtr(this), ref extents);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_extents");

        /// <summary>
        /// Return the half extents of the shape.
        /// </summary>
        public Vector3 get_extents()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_1, Object.GetPtr(this));
            return (Vector3)ret;
        }
    }
}
