using System;

namespace GodotEngine
{
    /// <summary>
    /// Convex polygon shape resource, which can be set into a [PhysicsBody] or area.
    /// </summary>
    public class ConvexPolygonShape : Shape
    {
        private const string nativeName = "ConvexPolygonShape";

        public ConvexPolygonShape() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConvexPolygonShape_Ctor(this);
        }

        internal ConvexPolygonShape(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_points");

        public void set_points(Vector3[] points)
        {
            NativeCalls.godot_icall_1_159(method_bind_0, Object.GetPtr(this), points);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_points");

        public Vector3[] get_points()
        {
            return NativeCalls.godot_icall_0_160(method_bind_1, Object.GetPtr(this));
        }
    }
}
