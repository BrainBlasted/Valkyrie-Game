using System;

namespace GodotEngine
{
    /// <summary>
    /// The [SurfaceTool] is used to construct a [Mesh] by specifying vertex attributes individually. It can be used to construct a [Mesh] from script. All properties except index need to be added before a call to [method add_vertex]. For example adding vertex colors and UVs looks like
    /// [codeblock]
    /// var st = SurfaceTool.new()
    /// st.begin(Mesh.PRIMITIVE_TRIANGLES)
    /// st.add_color(Color(1, 0, 0))
    /// st.add_uv(Vector2(0, 0))
    /// st.add_vertex(Vector3(0, 0, 0))
    /// [/codeblock]
    /// The [SurfaceTool] now contains one vertex of a triangle which has a UV coordinate and a specified [Color]. If another vertex were added without calls to [method add_uv] or [method add_color] then the last values would be used.
    /// It is very important that vertex attributes are passed [b]before[/b] the call to [method add_vertex], failure to do this will result in an error when committing the vertex information to a mesh.
    /// </summary>
    public class SurfaceTool : Reference
    {
        private const string nativeName = "SurfaceTool";

        public SurfaceTool() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SurfaceTool_Ctor(this);
        }

        internal SurfaceTool(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "begin");

        /// <summary>
        /// Called before adding any Vertices. Takes the primitive type as an argument (e.g. Mesh.PRIMITIVE_TRIANGLES).
        /// </summary>
        public void begin(int primitive)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), primitive);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_vertex");

        /// <summary>
        /// Specify position of current Vertex. Should be called after specifying other vertex properties (e.g. Color, UV).
        /// </summary>
        public void add_vertex(Vector3 vertex)
        {
            NativeCalls.godot_icall_1_83(method_bind_1, Object.GetPtr(this), ref vertex);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_color");

        /// <summary>
        /// Specify a [Color] for the next Vertex to use.
        /// </summary>
        public void add_color(Color color)
        {
            NativeCalls.godot_icall_1_122(method_bind_2, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_normal");

        /// <summary>
        /// Specify a normal for the next Vertex to use.
        /// </summary>
        public void add_normal(Vector3 normal)
        {
            NativeCalls.godot_icall_1_83(method_bind_3, Object.GetPtr(this), ref normal);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_tangent");

        /// <summary>
        /// Specify a Tangent for the next Vertex to use.
        /// </summary>
        public void add_tangent(Plane tangent)
        {
            NativeCalls.godot_icall_1_249(method_bind_4, Object.GetPtr(this), ref tangent);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_uv");

        /// <summary>
        /// Specify UV Coordinate for next Vertex to use.
        /// </summary>
        public void add_uv(Vector2 uv)
        {
            NativeCalls.godot_icall_1_37(method_bind_5, Object.GetPtr(this), ref uv);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_uv2");

        /// <summary>
        /// Specify an optional second set of UV coordinates for next Vertex to use.
        /// </summary>
        public void add_uv2(Vector2 uv2)
        {
            NativeCalls.godot_icall_1_37(method_bind_6, Object.GetPtr(this), ref uv2);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_bones");

        /// <summary>
        /// Add an array of bones for the next Vertex to use.
        /// </summary>
        public void add_bones(int[] bones)
        {
            NativeCalls.godot_icall_1_209(method_bind_7, Object.GetPtr(this), bones);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_weights");

        /// <summary>
        /// Specify weight value for next Vertex to use.
        /// </summary>
        public void add_weights(float[] weights)
        {
            NativeCalls.godot_icall_1_215(method_bind_8, Object.GetPtr(this), weights);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_smooth_group");

        /// <summary>
        /// Specify whether current Vertex (if using only Vertex arrays) or current index (if also using index arrays) should utilize smooth normals for normal calculation.
        /// </summary>
        public void add_smooth_group(bool smooth)
        {
            NativeCalls.godot_icall_1_7(method_bind_9, Object.GetPtr(this), smooth);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_triangle_fan");

        /// <summary>
        /// Insert a triangle fan made of array data into [Mesh] being constructed.
        /// <param name="uvs">If the param is null, then the default value is new Vector2[] {}</param>
        /// <param name="colors">If the param is null, then the default value is new Color[] {}</param>
        /// <param name="uv2s">If the param is null, then the default value is new Vector2[] {}</param>
        /// <param name="normals">If the param is null, then the default value is new Vector3[] {}</param>
        /// <param name="tangents">If the param is null, then the default value is new object[] {}</param>
        /// </summary>
        public void add_triangle_fan(Vector3[] vertexes, Vector2[] uvs = null, Color[] colors = null, Vector2[] uv2s = null, Vector3[] normals = null, object[] tangents = null)
        {
            Vector2[] uvs_in = uvs != null ? uvs : new Vector2[] {};
            Color[] colors_in = colors != null ? colors : new Color[] {};
            Vector2[] uv2s_in = uv2s != null ? uv2s : new Vector2[] {};
            Vector3[] normals_in = normals != null ? normals : new Vector3[] {};
            object[] tangents_in = tangents != null ? tangents : new object[] {};
            NativeCalls.godot_icall_6_453(method_bind_10, Object.GetPtr(this), vertexes, uvs_in, colors_in, uv2s_in, normals_in, tangents_in);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_index");

        /// <summary>
        /// Adds an index to index array if you are using indexed Vertices. Does not need to be called before adding Vertex.
        /// </summary>
        public void add_index(int index)
        {
            NativeCalls.godot_icall_1_0(method_bind_11, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "index");

        /// <summary>
        /// Shrinks Vertex array by creating an index array. Avoids reusing Vertices.
        /// </summary>
        public void index()
        {
            NativeCalls.godot_icall_0_8(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "deindex");

        /// <summary>
        /// Removes index array by expanding Vertex array.
        /// </summary>
        public void deindex()
        {
            NativeCalls.godot_icall_0_8(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "generate_normals");

        /// <summary>
        /// Generates normals from Vertices so you do not have to do it manually.
        /// </summary>
        public void generate_normals()
        {
            NativeCalls.godot_icall_0_8(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "generate_tangents");

        public void generate_tangents()
        {
            NativeCalls.godot_icall_0_8(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_to_format");

        public void add_to_format(int flags)
        {
            NativeCalls.godot_icall_1_0(method_bind_16, Object.GetPtr(this), flags);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_material");

        /// <summary>
        /// Sets [Material] to be used by the [Mesh] you are constructing.
        /// </summary>
        public void set_material(Material material)
        {
            NativeCalls.godot_icall_1_35(method_bind_17, Object.GetPtr(this), Object.GetPtr(material));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        /// <summary>
        /// Clear all information passed into the surface tool so far.
        /// </summary>
        public void clear()
        {
            NativeCalls.godot_icall_0_8(method_bind_18, Object.GetPtr(this));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_from");

        public void create_from(Mesh existing, int surface)
        {
            NativeCalls.godot_icall_2_248(method_bind_19, Object.GetPtr(this), Object.GetPtr(existing), surface);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "append_from");

        public void append_from(Mesh existing, int surface, Transform transform)
        {
            NativeCalls.godot_icall_3_454(method_bind_20, Object.GetPtr(this), Object.GetPtr(existing), surface, ref transform);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "commit");

        /// <summary>
        /// Returns a constructed [Mesh] from current information passed in. If an existing [Mesh] is passed in as an argument, will add an extra surface to the existing [Mesh].
        /// </summary>
        public Mesh commit(Mesh existing = null)
        {
            return NativeCalls.godot_icall_1_455(method_bind_21, Object.GetPtr(this), Object.GetPtr(existing));
        }
    }
}
