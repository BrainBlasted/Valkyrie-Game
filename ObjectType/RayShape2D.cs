using System;

namespace GodotEngine
{
    /// <summary>
    /// Ray 2D shape resource for physics. A ray is not really a collision body, instead it tries to separate itself from whatever is touching its far endpoint. It's often useful for characters.
    /// </summary>
    public class RayShape2D : Shape2D
    {
        private const string nativeName = "RayShape2D";

        public RayShape2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RayShape2D_Ctor(this);
        }

        internal RayShape2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_length");

        /// <summary>
        /// Set the length of the ray.
        /// </summary>
        public void set_length(float length)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), length);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_length");

        /// <summary>
        /// Return the length of the ray.
        /// </summary>
        public float get_length()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }
    }
}
