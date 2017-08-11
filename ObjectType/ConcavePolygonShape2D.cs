using System;

namespace GodotEngine
{
    /// <summary>
    /// Concave polygon 2D shape resource for physics. It is made out of segments and is very optimal for complex polygonal concave collisions. It is really not advised to use for [RigidBody2D] nodes. A CollisionPolygon2D in convex decomposition mode (solids) or several convex objects are advised for that instead. Otherwise, a concave polygon 2D shape is better for static collisions.
    /// The main difference between a [ConvexPolygonShape2D] and a [ConcavePolygonShape2D] is that a concave polygon assumes it is concave and uses a more complex method of collision detection, and a convex one forces itself to be convex in order to speed up collision detection.
    /// </summary>
    public class ConcavePolygonShape2D : Shape2D
    {
        private const string nativeName = "ConcavePolygonShape2D";

        public ConcavePolygonShape2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConcavePolygonShape2D_Ctor(this);
        }

        internal ConcavePolygonShape2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_segments");

        /// <summary>
        /// Set the array of segments.
        /// </summary>
        public void set_segments(Vector2[] segments)
        {
            NativeCalls.godot_icall_1_154(method_bind_0, Object.GetPtr(this), segments);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_segments");

        /// <summary>
        /// Return the array of segments.
        /// </summary>
        public Vector2[] get_segments()
        {
            return NativeCalls.godot_icall_0_155(method_bind_1, Object.GetPtr(this));
        }
    }
}
