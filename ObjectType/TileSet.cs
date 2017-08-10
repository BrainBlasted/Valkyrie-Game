using System;

namespace GodotEngine
{
    /// <summary>
    /// A TileSet is a library of tiles for a [TileMap]. It contains a list of tiles, each consisting of a sprite and optional collision shapes.
    /// Tiles are referenced by a unique integer ID.
    /// </summary>
    public class TileSet : Resource
    {
        private const string nativeName = "TileSet";

        public TileSet() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TileSet_Ctor(this);
        }

        internal TileSet(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_tile");

        /// <summary>
        /// Create a new tile which will be referenced by the given ID.
        /// </summary>
        public void create_tile(int id)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_name");

        /// <summary>
        /// Set the name of the tile, for descriptive purposes.
        /// </summary>
        public void tile_set_name(int id, string name)
        {
            NativeCalls.godot_icall_2_68(method_bind_1, Object.GetPtr(this), id, name);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_name");

        /// <summary>
        /// Return the name of the tile.
        /// </summary>
        public string tile_get_name(int id)
        {
            return NativeCalls.godot_icall_1_86(method_bind_2, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_texture");

        /// <summary>
        /// Set the texture of the tile.
        /// </summary>
        public void tile_set_texture(int id, Texture texture)
        {
            NativeCalls.godot_icall_2_88(method_bind_3, Object.GetPtr(this), id, Object.GetPtr(texture));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_texture");

        /// <summary>
        /// Return the texture of the tile.
        /// </summary>
        public Texture tile_get_texture(int id)
        {
            return NativeCalls.godot_icall_1_108(method_bind_4, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_normal_map");

        public void tile_set_normal_map(int id, Texture normal_map)
        {
            NativeCalls.godot_icall_2_88(method_bind_5, Object.GetPtr(this), id, Object.GetPtr(normal_map));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_normal_map");

        public Texture tile_get_normal_map(int id)
        {
            return NativeCalls.godot_icall_1_108(method_bind_6, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_material");

        /// <summary>
        /// Set the material of the tile.
        /// </summary>
        public void tile_set_material(int id, ShaderMaterial material)
        {
            NativeCalls.godot_icall_2_88(method_bind_7, Object.GetPtr(this), id, Object.GetPtr(material));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_material");

        /// <summary>
        /// Return the material of the tile.
        /// </summary>
        public ShaderMaterial tile_get_material(int id)
        {
            return NativeCalls.godot_icall_1_474(method_bind_8, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_texture_offset");

        /// <summary>
        /// Set the texture offset of the tile.
        /// </summary>
        public void tile_set_texture_offset(int id, Vector2 texture_offset)
        {
            NativeCalls.godot_icall_2_181(method_bind_9, Object.GetPtr(this), id, ref texture_offset);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_texture_offset");

        /// <summary>
        /// Return the texture offset of the tile.
        /// </summary>
        public Vector2 tile_get_texture_offset(int id)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_10, Object.GetPtr(this), id);
            return (Vector2)ret;
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_region");

        /// <summary>
        /// Set the tile sub-region in the texture. This is common in texture atlases.
        /// </summary>
        public void tile_set_region(int id, Rect2 region)
        {
            NativeCalls.godot_icall_2_261(method_bind_11, Object.GetPtr(this), id, ref region);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_region");

        /// <summary>
        /// Return the tile sub-region in the texture.
        /// </summary>
        public Rect2 tile_get_region(int id)
        {
            object ret = NativeCalls.godot_icall_1_262(method_bind_12, Object.GetPtr(this), id);
            return (Rect2)ret;
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_shape");

        public void tile_set_shape(int id, int shape_id, Shape2D shape)
        {
            NativeCalls.godot_icall_3_475(method_bind_13, Object.GetPtr(this), id, shape_id, Object.GetPtr(shape));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_shape");

        public Shape2D tile_get_shape(int id, int shape_id)
        {
            return NativeCalls.godot_icall_2_476(method_bind_14, Object.GetPtr(this), id, shape_id);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_shape_transform");

        public void tile_set_shape_transform(int id, int shape_id, Transform2D shape_transform)
        {
            NativeCalls.godot_icall_3_477(method_bind_15, Object.GetPtr(this), id, shape_id, ref shape_transform);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_shape_transform");

        public Transform2D tile_get_shape_transform(int id, int shape_id)
        {
            object ret = NativeCalls.godot_icall_2_478(method_bind_16, Object.GetPtr(this), id, shape_id);
            return (Transform2D)ret;
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_shape_one_way");

        public void tile_set_shape_one_way(int id, int shape_id, bool one_way)
        {
            NativeCalls.godot_icall_3_23(method_bind_17, Object.GetPtr(this), id, shape_id, one_way);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_shape_one_way");

        public bool tile_get_shape_one_way(int id, int shape_id)
        {
            return NativeCalls.godot_icall_2_25(method_bind_18, Object.GetPtr(this), id, shape_id);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_add_shape");

        public void tile_add_shape(int id, Shape2D shape, Transform2D shape_transform, bool one_way = false)
        {
            NativeCalls.godot_icall_4_479(method_bind_19, Object.GetPtr(this), id, Object.GetPtr(shape), ref shape_transform, one_way);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_shape_count");

        public int tile_get_shape_count(int id)
        {
            return NativeCalls.godot_icall_1_5(method_bind_20, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_shapes");

        /// <summary>
        /// Set an array of shapes for the tile, enabling physics to collide with it.
        /// </summary>
        public void tile_set_shapes(int id, object[] shapes)
        {
            NativeCalls.godot_icall_2_480(method_bind_21, Object.GetPtr(this), id, shapes);
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_shapes");

        /// <summary>
        /// Return the array of shapes of the tile.
        /// </summary>
        public object[] tile_get_shapes(int id)
        {
            return NativeCalls.godot_icall_1_424(method_bind_22, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_navigation_polygon");

        /// <summary>
        /// Set a navigation polygon for the tile.
        /// </summary>
        public void tile_set_navigation_polygon(int id, NavigationPolygon navigation_polygon)
        {
            NativeCalls.godot_icall_2_88(method_bind_23, Object.GetPtr(this), id, Object.GetPtr(navigation_polygon));
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_navigation_polygon");

        /// <summary>
        /// Return the navigation polygon of the tile.
        /// </summary>
        public NavigationPolygon tile_get_navigation_polygon(int id)
        {
            return NativeCalls.godot_icall_1_481(method_bind_24, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_navigation_polygon_offset");

        /// <summary>
        /// Set an offset for the tile's navigation polygon.
        /// </summary>
        public void tile_set_navigation_polygon_offset(int id, Vector2 navigation_polygon_offset)
        {
            NativeCalls.godot_icall_2_181(method_bind_25, Object.GetPtr(this), id, ref navigation_polygon_offset);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_navigation_polygon_offset");

        /// <summary>
        /// Return the offset of the tile's navigation polygon.
        /// </summary>
        public Vector2 tile_get_navigation_polygon_offset(int id)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_26, Object.GetPtr(this), id);
            return (Vector2)ret;
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_light_occluder");

        /// <summary>
        /// Set a light occluder for the tile.
        /// </summary>
        public void tile_set_light_occluder(int id, OccluderPolygon2D light_occluder)
        {
            NativeCalls.godot_icall_2_88(method_bind_27, Object.GetPtr(this), id, Object.GetPtr(light_occluder));
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_light_occluder");

        /// <summary>
        /// Return the light occluder of the tile.
        /// </summary>
        public OccluderPolygon2D tile_get_light_occluder(int id)
        {
            return NativeCalls.godot_icall_1_482(method_bind_28, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_set_occluder_offset");

        /// <summary>
        /// Set an offset for the tile's light occluder.
        /// </summary>
        public void tile_set_occluder_offset(int id, Vector2 occluder_offset)
        {
            NativeCalls.godot_icall_2_181(method_bind_29, Object.GetPtr(this), id, ref occluder_offset);
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "tile_get_occluder_offset");

        /// <summary>
        /// Return the offset of the tile's light occluder.
        /// </summary>
        public Vector2 tile_get_occluder_offset(int id)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_30, Object.GetPtr(this), id);
            return (Vector2)ret;
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_tile");

        /// <summary>
        /// Remove the tile referenced by the given ID.
        /// </summary>
        public void remove_tile(int id)
        {
            NativeCalls.godot_icall_1_0(method_bind_31, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        /// <summary>
        /// Clear all tiles.
        /// </summary>
        public void clear()
        {
            NativeCalls.godot_icall_0_8(method_bind_32, Object.GetPtr(this));
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_last_unused_tile_id");

        /// <summary>
        /// Return the ID following the last currently used ID, useful when creating a new tile.
        /// </summary>
        public int get_last_unused_tile_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_33, Object.GetPtr(this));
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "find_tile_by_name");

        /// <summary>
        /// Find the first tile matching the given name.
        /// </summary>
        public int find_tile_by_name(string name)
        {
            return NativeCalls.godot_icall_1_70(method_bind_34, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tiles_ids");

        /// <summary>
        /// Return an array of all currently used tile IDs.
        /// </summary>
        public object[] get_tiles_ids()
        {
            return NativeCalls.godot_icall_0_84(method_bind_35, Object.GetPtr(this));
        }
    }
}
