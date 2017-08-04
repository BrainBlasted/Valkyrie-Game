using System;

namespace GodotEngine
{
    /// <summary>
    /// Concave polygon shape resource, which can be set into a [PhysicsBody] or area. This shape is created by feeding a list of triangles.
    /// </summary>
    public class ConcavePolygonShape : Shape
    {
        private const string nativeName = "ConcavePolygonShape";

        public ConcavePolygonShape() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConcavePolygonShape_Ctor(this);
        }

        internal ConcavePolygonShape(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_faces");

        /// <summary>
        /// Set the faces (an array of triangles).
        /// </summary>
        public void set_faces(Vector3[] faces)
        {
            NativeCalls.godot_icall_1_157(method_bind_0, Object.GetPtr(this), faces);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_faces");

        /// <summary>
        /// Return the faces (an array of triangles).
        /// </summary>
        public Vector3[] get_faces()
        {
            return NativeCalls.godot_icall_0_158(method_bind_1, Object.GetPtr(this));
        }
    }
}
