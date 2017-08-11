using System;

namespace GodotEngine
{
    public class MeshDataTool : Reference
    {
        private const string nativeName = "MeshDataTool";

        public MeshDataTool() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_MeshDataTool_Ctor(this);
        }

        internal MeshDataTool(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        public void clear()
        {
            NativeCalls.godot_icall_0_8(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_from_surface");

        public int create_from_surface(ArrayMesh mesh, int surface)
        {
            return NativeCalls.godot_icall_2_277(method_bind_1, Object.GetPtr(this), Object.GetPtr(mesh), surface);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "commit_to_surface");

        public int commit_to_surface(ArrayMesh mesh)
        {
            return NativeCalls.godot_icall_1_278(method_bind_2, Object.GetPtr(this), Object.GetPtr(mesh));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_format");

        public int get_format()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_count");

        public int get_vertex_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_edge_count");

        public int get_edge_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_face_count");

        public int get_face_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex");

        public void set_vertex(int idx, Vector3 vertex)
        {
            NativeCalls.godot_icall_2_187(method_bind_7, Object.GetPtr(this), idx, ref vertex);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex");

        public Vector3 get_vertex(int idx)
        {
            object ret = NativeCalls.godot_icall_1_21(method_bind_8, Object.GetPtr(this), idx);
            return (Vector3)ret;
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex_normal");

        public void set_vertex_normal(int idx, Vector3 normal)
        {
            NativeCalls.godot_icall_2_187(method_bind_9, Object.GetPtr(this), idx, ref normal);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_normal");

        public Vector3 get_vertex_normal(int idx)
        {
            object ret = NativeCalls.godot_icall_1_21(method_bind_10, Object.GetPtr(this), idx);
            return (Vector3)ret;
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex_tangent");

        public void set_vertex_tangent(int idx, Plane tangent)
        {
            NativeCalls.godot_icall_2_279(method_bind_11, Object.GetPtr(this), idx, ref tangent);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_tangent");

        public Plane get_vertex_tangent(int idx)
        {
            object ret = NativeCalls.godot_icall_1_280(method_bind_12, Object.GetPtr(this), idx);
            return (Plane)ret;
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex_uv");

        public void set_vertex_uv(int idx, Vector2 uv)
        {
            NativeCalls.godot_icall_2_181(method_bind_13, Object.GetPtr(this), idx, ref uv);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_uv");

        public Vector2 get_vertex_uv(int idx)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_14, Object.GetPtr(this), idx);
            return (Vector2)ret;
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex_uv2");

        public void set_vertex_uv2(int idx, Vector2 uv2)
        {
            NativeCalls.godot_icall_2_181(method_bind_15, Object.GetPtr(this), idx, ref uv2);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_uv2");

        public Vector2 get_vertex_uv2(int idx)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_16, Object.GetPtr(this), idx);
            return (Vector2)ret;
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex_color");

        public void set_vertex_color(int idx, Color color)
        {
            NativeCalls.godot_icall_2_211(method_bind_17, Object.GetPtr(this), idx, ref color);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_color");

        public Color get_vertex_color(int idx)
        {
            object ret = NativeCalls.godot_icall_1_212(method_bind_18, Object.GetPtr(this), idx);
            return (Color)ret;
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex_bones");

        public void set_vertex_bones(int idx, int[] bones)
        {
            NativeCalls.godot_icall_2_281(method_bind_19, Object.GetPtr(this), idx, bones);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_bones");

        public int[] get_vertex_bones(int idx)
        {
            return NativeCalls.godot_icall_1_282(method_bind_20, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex_weights");

        public void set_vertex_weights(int idx, float[] weights)
        {
            NativeCalls.godot_icall_2_283(method_bind_21, Object.GetPtr(this), idx, weights);
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_weights");

        public float[] get_vertex_weights(int idx)
        {
            return NativeCalls.godot_icall_1_284(method_bind_22, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vertex_meta");

        public void set_vertex_meta(int idx, object meta)
        {
            NativeCalls.godot_icall_2_261(method_bind_23, Object.GetPtr(this), idx, meta);
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_meta");

        public object get_vertex_meta(int idx)
        {
            return NativeCalls.godot_icall_1_262(method_bind_24, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_edges");

        public int[] get_vertex_edges(int idx)
        {
            return NativeCalls.godot_icall_1_282(method_bind_25, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vertex_faces");

        public int[] get_vertex_faces(int idx)
        {
            return NativeCalls.godot_icall_1_282(method_bind_26, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_edge_vertex");

        public int get_edge_vertex(int idx, int vertex)
        {
            return NativeCalls.godot_icall_2_38(method_bind_27, Object.GetPtr(this), idx, vertex);
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_edge_faces");

        public int[] get_edge_faces(int idx)
        {
            return NativeCalls.godot_icall_1_282(method_bind_28, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_edge_meta");

        public void set_edge_meta(int idx, object meta)
        {
            NativeCalls.godot_icall_2_261(method_bind_29, Object.GetPtr(this), idx, meta);
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_edge_meta");

        public object get_edge_meta(int idx)
        {
            return NativeCalls.godot_icall_1_262(method_bind_30, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_face_vertex");

        public int get_face_vertex(int idx, int vertex)
        {
            return NativeCalls.godot_icall_2_38(method_bind_31, Object.GetPtr(this), idx, vertex);
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_face_edge");

        public int get_face_edge(int idx, int edge)
        {
            return NativeCalls.godot_icall_2_38(method_bind_32, Object.GetPtr(this), idx, edge);
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_face_meta");

        public void set_face_meta(int idx, object meta)
        {
            NativeCalls.godot_icall_2_261(method_bind_33, Object.GetPtr(this), idx, meta);
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_face_meta");

        public object get_face_meta(int idx)
        {
            return NativeCalls.godot_icall_1_262(method_bind_34, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_face_normal");

        public Vector3 get_face_normal(int idx)
        {
            object ret = NativeCalls.godot_icall_1_21(method_bind_35, Object.GetPtr(this), idx);
            return (Vector3)ret;
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_material");

        public void set_material(Material material)
        {
            NativeCalls.godot_icall_1_19(method_bind_36, Object.GetPtr(this), Object.GetPtr(material));
        }

        private IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_material");

        public Material get_material()
        {
            return NativeCalls.godot_icall_0_143(method_bind_37, Object.GetPtr(this));
        }
    }
}
