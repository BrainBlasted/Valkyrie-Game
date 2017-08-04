using System;

namespace GodotEngine
{
    /// <summary>
    /// Circular Shape for 2D Physics. This shape is useful for modeling balls or small characters and its collision detection with everything else is very fast.
    /// </summary>
    public class CircleShape2D : Shape2D
    {
        private const string nativeName = "CircleShape2D";

        public CircleShape2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CircleShape2D_Ctor(this);
        }

        internal CircleShape2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_radius");

        /// <summary>
        /// Set the radius of the circle shape.
        /// </summary>
        public void set_radius(float radius)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), radius);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_radius");

        /// <summary>
        /// Return the radius of the circle shape.
        /// </summary>
        public float get_radius()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }
    }
}
