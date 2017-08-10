using System;

namespace GodotEngine
{
    /// <summary>
    /// This class is a container/Node-ification of a [Curve2D], so it can have [Node2D] properties and [Node] info.
    /// </summary>
    public class Path2D : Node2D
    {
        private const string nativeName = "Path2D";

        public Path2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Path2D_Ctor(this);
        }

        internal Path2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_curve");

        /// <summary>
        /// Sets the [Curve2D].
        /// </summary>
        public void set_curve(Curve2D curve)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(curve));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_curve");

        /// <summary>
        /// Returns the [Curve2D] contained.
        /// </summary>
        public Curve2D get_curve()
        {
            return NativeCalls.godot_icall_0_340(method_bind_1, Object.GetPtr(this));
        }
    }
}
