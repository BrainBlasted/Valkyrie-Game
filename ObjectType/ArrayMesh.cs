using System;

namespace GodotEngine
{
    public class ArrayMesh : Mesh
    {
        /// <summary>
        /// Default value used for index_array_len when no indices are present.
        /// </summary>
        public const int NO_INDEX_ARRAY = -1;
        /// <summary>
        /// Amount of weights/bone indices per vertex (always 4).
        /// </summary>
        public const int ARRAY_WEIGHTS_SIZE = 4;
        /// <summary>
        /// Vertex array (array of [Vector3] vertices).
        /// </summary>
        public const int ARRAY_VERTEX = 0;
        /// <summary>
        /// Normal array (array of [Vector3] normals).
        /// </summary>
        public const int ARRAY_NORMAL = 1;
        /// <summary>
        /// Tangent array, array of groups of 4 floats. first 3 floats determine the tangent, and the last the binormal direction as -1 or 1.
        /// </summary>
        public const int ARRAY_TANGENT = 2;
        /// <summary>
        /// Vertex array (array of [Color] colors).
        /// </summary>
        public const int ARRAY_COLOR = 3;
        /// <summary>
        /// UV array (array of [Vector3] UVs or float array of groups of 2 floats (u,v)).
        /// </summary>
        public const int ARRAY_TEX_UV = 4;
        /// <summary>
        /// Second UV array (array of [Vector3] UVs or float array of groups of 2 floats (u,v)).
        /// </summary>
        public const int ARRAY_TEX_UV2 = 5;
        /// <summary>
        /// Array of bone indices, as a float array. Each element in groups of 4 floats.
        /// </summary>
        public const int ARRAY_BONES = 6;
        /// <summary>
        /// Array of bone weights, as a float array. Each element in groups of 4 floats.
        /// </summary>
        public const int ARRAY_WEIGHTS = 7;
        /// <summary>
        /// Array of integers, used as indices referencing vertices. No index can be beyond the vertex array size.
        /// </summary>
        public const int ARRAY_INDEX = 8;
        /// <summary>
        /// Array format will include vertices (mandatory).
        /// </summary>
        public const int ARRAY_FORMAT_VERTEX = 1;
        /// <summary>
        /// Array format will include normals
        /// </summary>
        public const int ARRAY_FORMAT_NORMAL = 2;
        /// <summary>
        /// Array format will include tangents
        /// </summary>
        public const int ARRAY_FORMAT_TANGENT = 4;
        /// <summary>
        /// Array format will include a color array.
        /// </summary>
        public const int ARRAY_FORMAT_COLOR = 8;
        /// <summary>
        /// Array format will include UVs.
        /// </summary>
        public const int ARRAY_FORMAT_TEX_UV = 16;
        /// <summary>
        /// Array format will include another set of UVs.
        /// </summary>
        public const int ARRAY_FORMAT_TEX_UV2 = 32;
        /// <summary>
        /// Array format will include bone indices.
        /// </summary>
        public const int ARRAY_FORMAT_BONES = 64;
        /// <summary>
        /// Array format will include bone weights.
        /// </summary>
        public const int ARRAY_FORMAT_WEIGHTS = 128;
        /// <summary>
        /// Index array will be used.
        /// </summary>
        public const int ARRAY_FORMAT_INDEX = 256;

        private const string nativeName = "ArrayMesh";

        public ArrayMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ArrayMesh_Ctor(this);
        }

        internal ArrayMesh(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_blend_shape");

        public void add_blend_shape(string name)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_blend_shape_count");

        public int get_blend_shape_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_blend_shape_name");

        public string get_blend_shape_name(int index)
        {
            return NativeCalls.godot_icall_1_87(method_bind_2, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear_blend_shapes");

        public void clear_blend_shapes()
        {
            NativeCalls.godot_icall_0_8(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_blend_shape_mode");

        public void set_blend_shape_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_blend_shape_mode");

        public int get_blend_shape_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_surface_from_arrays");

        /// <summary>
        /// Create a new surface ([method get_surface_count] that will become surf_idx for this.
        /// Surfaces are created to be rendered using a "primitive", which may be PRIMITIVE_POINTS, PRIMITIVE_LINES, PRIMITIVE_LINE_STRIP, PRIMITIVE_LINE_LOOP, PRIMITIVE_TRIANGLES, PRIMITIVE_TRIANGLE_STRIP, PRIMITIVE_TRIANGLE_FAN. (As a note, when using indices, it is recommended to only use just points, lines or triangles).
        /// <param name="blend_shapes">If the param is null, then the default value is new object[] {}</param>
        /// </summary>
        public void add_surface_from_arrays(int primitive, object[] arrays, object[] blend_shapes = null, int compress_flags = 97792)
        {
            object[] blend_shapes_in = blend_shapes != null ? blend_shapes : new object[] {};
            NativeCalls.godot_icall_4_88(method_bind_6, Object.GetPtr(this), primitive, arrays, blend_shapes_in, compress_flags);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_surface_count");

        /// <summary>
        /// Return the amount of surfaces that the [ArrayMesh] holds.
        /// </summary>
        public int get_surface_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_remove");

        /// <summary>
        /// Remove a surface at position surf_idx, shifting greater surfaces one surf_idx slot down.
        /// </summary>
        public void surface_remove(int surf_idx)
        {
            NativeCalls.godot_icall_1_0(method_bind_8, Object.GetPtr(this), surf_idx);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_get_array_len");

        /// <summary>
        /// Return the length in vertices of the vertex array in the requested surface (see [method add_surface]).
        /// </summary>
        public int surface_get_array_len(int surf_idx)
        {
            return NativeCalls.godot_icall_1_5(method_bind_9, Object.GetPtr(this), surf_idx);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_get_array_index_len");

        /// <summary>
        /// Return the length in indices of the index array in the requested surface (see [method add_surface]).
        /// </summary>
        public int surface_get_array_index_len(int surf_idx)
        {
            return NativeCalls.godot_icall_1_5(method_bind_10, Object.GetPtr(this), surf_idx);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_get_format");

        /// <summary>
        /// Return the format mask of the requested surface (see [method add_surface]).
        /// </summary>
        public int surface_get_format(int surf_idx)
        {
            return NativeCalls.godot_icall_1_5(method_bind_11, Object.GetPtr(this), surf_idx);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_get_primitive_type");

        /// <summary>
        /// Return the primitive type of the requested surface (see [method add_surface]).
        /// </summary>
        public int surface_get_primitive_type(int surf_idx)
        {
            return NativeCalls.godot_icall_1_5(method_bind_12, Object.GetPtr(this), surf_idx);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_set_material");

        public void surface_set_material(int surf_idx, Material material)
        {
            NativeCalls.godot_icall_2_89(method_bind_13, Object.GetPtr(this), surf_idx, Object.GetPtr(material));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_get_material");

        /// <summary>
        /// Return a [Material] in a given surface. Surface is rendered using this material.
        /// </summary>
        public Material surface_get_material(int surf_idx)
        {
            return NativeCalls.godot_icall_1_90(method_bind_14, Object.GetPtr(this), surf_idx);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_set_name");

        /// <summary>
        /// Set a [Material] for a given surface. Surface will be rendered using this material.
        /// </summary>
        public void surface_set_name(int surf_idx, string name)
        {
            NativeCalls.godot_icall_2_69(method_bind_15, Object.GetPtr(this), surf_idx, name);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "surface_get_name");

        public string surface_get_name(int surf_idx)
        {
            return NativeCalls.godot_icall_1_87(method_bind_16, Object.GetPtr(this), surf_idx);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "center_geometry");

        public void center_geometry()
        {
            NativeCalls.godot_icall_0_8(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "regen_normalmaps");

        public void regen_normalmaps()
        {
            NativeCalls.godot_icall_0_8(method_bind_18, Object.GetPtr(this));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_custom_aabb");

        public void set_custom_aabb(Rect3 aabb)
        {
            NativeCalls.godot_icall_1_91(method_bind_19, Object.GetPtr(this), ref aabb);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_custom_aabb");

        public Rect3 get_custom_aabb()
        {
            object ret = NativeCalls.godot_icall_0_92(method_bind_20, Object.GetPtr(this));
            return (Rect3)ret;
        }
    }
}
