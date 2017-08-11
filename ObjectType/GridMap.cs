using System;

namespace GodotEngine
{
    public class GridMap : Spatial
    {
        public const int INVALID_CELL_ITEM = -1;

        private const string nativeName = "GridMap";

        public GridMap() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GridMap_Ctor(this);
        }

        internal GridMap(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_theme");

        public void set_theme(MeshLibrary theme)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(theme));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_theme");

        public MeshLibrary get_theme()
        {
            return NativeCalls.godot_icall_0_222(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cell_size");

        public void set_cell_size(float size)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), size);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cell_size");

        public float get_cell_size()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_octant_size");

        public void set_octant_size(int size)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), size);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_octant_size");

        public int get_octant_size()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cell_item");

        public void set_cell_item(int x, int y, int z, int item, int orientation = 0)
        {
            NativeCalls.godot_icall_5_223(method_bind_6, Object.GetPtr(this), x, y, z, item, orientation);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cell_item");

        public int get_cell_item(int x, int y, int z)
        {
            return NativeCalls.godot_icall_3_224(method_bind_7, Object.GetPtr(this), x, y, z);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cell_item_orientation");

        public int get_cell_item_orientation(int x, int y, int z)
        {
            return NativeCalls.godot_icall_3_224(method_bind_8, Object.GetPtr(this), x, y, z);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "resource_changed");

        public void resource_changed(Resource resource)
        {
            NativeCalls.godot_icall_1_19(method_bind_9, Object.GetPtr(this), Object.GetPtr(resource));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_center_x");

        public void set_center_x(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_10, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_center_x");

        public bool get_center_x()
        {
            return NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_center_y");

        public void set_center_y(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_12, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_center_y");

        public bool get_center_y()
        {
            return NativeCalls.godot_icall_0_3(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_center_z");

        public void set_center_z(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_14, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_center_z");

        public bool get_center_z()
        {
            return NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_clip");

        public void set_clip(bool enabled, bool clipabove = true, int floor = 0, int axis = 0)
        {
            NativeCalls.godot_icall_4_225(method_bind_16, Object.GetPtr(this), enabled, clipabove, floor, axis);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_area");

        public int create_area(int id, Rect3 area)
        {
            return NativeCalls.godot_icall_2_226(method_bind_17, Object.GetPtr(this), id, ref area);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_get_bounds");

        public Rect3 area_get_bounds(int area)
        {
            object ret = NativeCalls.godot_icall_1_227(method_bind_18, Object.GetPtr(this), area);
            return (Rect3)ret;
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_set_exterior_portal");

        public void area_set_exterior_portal(int area, bool enable)
        {
            NativeCalls.godot_icall_2_42(method_bind_19, Object.GetPtr(this), area, enable);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_set_name");

        public void area_set_name(int area, string name)
        {
            NativeCalls.godot_icall_2_69(method_bind_20, Object.GetPtr(this), area, name);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_get_name");

        public string area_get_name(int area)
        {
            return NativeCalls.godot_icall_1_87(method_bind_21, Object.GetPtr(this), area);
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_is_exterior_portal");

        public bool area_is_exterior_portal(int area)
        {
            return NativeCalls.godot_icall_1_22(method_bind_22, Object.GetPtr(this), area);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_set_portal_disable_distance");

        public void area_set_portal_disable_distance(int area, float distance)
        {
            NativeCalls.godot_icall_2_45(method_bind_23, Object.GetPtr(this), area, distance);
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_get_portal_disable_distance");

        public float area_get_portal_disable_distance(int area)
        {
            return NativeCalls.godot_icall_1_6(method_bind_24, Object.GetPtr(this), area);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_set_portal_disable_color");

        public void area_set_portal_disable_color(int area, Color color)
        {
            NativeCalls.godot_icall_2_211(method_bind_25, Object.GetPtr(this), area, ref color);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "area_get_portal_disable_color");

        public Color area_get_portal_disable_color(int area)
        {
            object ret = NativeCalls.godot_icall_1_212(method_bind_26, Object.GetPtr(this), area);
            return (Color)ret;
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "erase_area");

        public void erase_area(int area)
        {
            NativeCalls.godot_icall_1_0(method_bind_27, Object.GetPtr(this), area);
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_unused_area_id");

        public int get_unused_area_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_28, Object.GetPtr(this));
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        public void clear()
        {
            NativeCalls.godot_icall_0_8(method_bind_29, Object.GetPtr(this));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_meshes");

        public object[] get_meshes()
        {
            return NativeCalls.godot_icall_0_85(method_bind_30, Object.GetPtr(this));
        }
    }
}
