using System;

namespace GodotEngine
{
    /// <summary>
    /// Rectangle Shape for 2D Physics. This shape is useful for modeling box-like 2D objects.
    /// </summary>
    public class RectangleShape2D : Shape2D
    {
        private const string nativeName = "RectangleShape2D";

        public RectangleShape2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RectangleShape2D_Ctor(this);
        }

        internal RectangleShape2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_extents");

        /// <summary>
        /// Set the half extents, the actual width and height of this shape is twice the half extents.
        /// </summary>
        public void set_extents(Vector2 extents)
        {
            NativeCalls.godot_icall_1_37(method_bind_0, Object.GetPtr(this), ref extents);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_extents");

        /// <summary>
        /// Return the half extents, the actual width and height of this shape is twice the half extents.
        /// </summary>
        public Vector2 get_extents()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_1, Object.GetPtr(this));
            return (Vector2)ret;
        }
    }
}
