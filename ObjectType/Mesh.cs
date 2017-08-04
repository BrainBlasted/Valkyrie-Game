using System;

namespace GodotEngine
{
    /// <summary>
    /// Mesh is a type of [Resource] that contains vertex-array based geometry, divided in [i]surfaces[/i]. Each surface contains a completely separate array and a material used to draw it. Design wise, a mesh with multiple surfaces is preferred to a single surface, because objects created in 3D editing software commonly contain multiple materials.
    /// </summary>
    public class Mesh : Resource
    {
        /// <summary>
        /// Render array as points (one vertex equals one point).
        /// </summary>
        public const int PRIMITIVE_POINTS = 0;
        /// <summary>
        /// Render array as lines (every two vertices a line is created).
        /// </summary>
        public const int PRIMITIVE_LINES = 1;
        /// <summary>
        /// Render array as line strip.
        /// </summary>
        public const int PRIMITIVE_LINE_STRIP = 2;
        /// <summary>
        /// Render array as line loop (like line strip, but closed).
        /// </summary>
        public const int PRIMITIVE_LINE_LOOP = 3;
        /// <summary>
        /// Render array as triangles (every three vertices a triangle is created).
        /// </summary>
        public const int PRIMITIVE_TRIANGLES = 4;
        /// <summary>
        /// Render array as triangle strips.
        /// </summary>
        public const int PRIMITIVE_TRIANGLE_STRIP = 5;
        /// <summary>
        /// Render array as triangle fans.
        /// </summary>
        public const int PRIMITIVE_TRIANGLE_FAN = 6;

        private const string nativeName = "Mesh";

        internal Mesh() {}

        internal Mesh(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_trimesh_shape");

        public Shape create_trimesh_shape()
        {
            return NativeCalls.godot_icall_0_154(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_convex_shape");

        public Shape create_convex_shape()
        {
            return NativeCalls.godot_icall_0_154(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_outline");

        public ArrayMesh create_outline(float margin)
        {
            return NativeCalls.godot_icall_1_278(method_bind_2, Object.GetPtr(this), margin);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_faces");

        public Vector3[] get_faces()
        {
            return NativeCalls.godot_icall_0_158(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "generate_triangle_mesh");

        public TriangleMesh generate_triangle_mesh()
        {
            return NativeCalls.godot_icall_0_279(method_bind_4, Object.GetPtr(this));
        }
    }
}
