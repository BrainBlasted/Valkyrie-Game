using System;

namespace GodotEngine
{
    /// <summary>
    /// A* (A star) is a computer algorithm that is widely used in pathfinding and graph traversal, the process of plotting an efficiently directed path between multiple points. It enjoys widespread use due to its performance and accuracy. Godot's A* implementation make use of vectors as points.
    /// You must add points manually with [method AStar.add_point] and create segments manually with [method AStar.connect_points]. So you can test if there is a path between two points with the [method AStar.are_points_connected] function, get the list of existing ids in the found path with [method AStar.get_id_path], or the points list with [method AStar.get_point_path].
    /// </summary>
    public class AStar : Reference
    {
        private const string nativeName = "AStar";

        public AStar() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AStar_Ctor(this);
        }

        internal AStar(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_available_point_id");

        public int get_available_point_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_point");

        /// <summary>
        /// Add a new point at the given position [code]pos[/code] with the given identifier [code]id[/code]. The [code]weight_scale[/code] has to be 1 or larger.
        /// </summary>
        public void add_point(int id, Vector3 pos, float weight_scale = 1f)
        {
            NativeCalls.godot_icall_3_20(method_bind_1, Object.GetPtr(this), id, ref pos, weight_scale);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_pos");

        /// <summary>
        /// Returns the position of point with given id.
        /// </summary>
        public Vector3 get_point_pos(int id)
        {
            object ret = NativeCalls.godot_icall_1_21(method_bind_2, Object.GetPtr(this), id);
            return (Vector3)ret;
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_weight_scale");

        /// <summary>
        /// Returns the weight scale of point with given id.
        /// </summary>
        public float get_point_weight_scale(int id)
        {
            return NativeCalls.godot_icall_1_6(method_bind_3, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_point");

        /// <summary>
        /// Removes the point with given id.
        /// </summary>
        public void remove_point(int id)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_point");

        /// <summary>
        /// Returns if the point with given id exists on AStar;
        /// </summary>
        public bool has_point(int id)
        {
            return NativeCalls.godot_icall_1_22(method_bind_5, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "connect_points");

        /// <summary>
        /// Create a segment between points [code]id[/code] and [code]to_id[/code].
        /// </summary>
        public void connect_points(int id, int to_id, bool bidirectional = true)
        {
            NativeCalls.godot_icall_3_23(method_bind_6, Object.GetPtr(this), id, to_id, bidirectional);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "disconnect_points");

        /// <summary>
        /// Deletes a segment between points [code]id[/code] and [code]to_id[/code].
        /// </summary>
        public void disconnect_points(int id, int to_id)
        {
            NativeCalls.godot_icall_2_24(method_bind_7, Object.GetPtr(this), id, to_id);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "are_points_connected");

        /// <summary>
        /// Returns if there is a connection/segment between points [code]id[/code] and [code]from_id[/code]
        /// </summary>
        public bool are_points_connected(int id, int to_id)
        {
            return NativeCalls.godot_icall_2_25(method_bind_8, Object.GetPtr(this), id, to_id);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        /// <summary>
        /// Clear all the points and segments from AStar instance.
        /// </summary>
        public void clear()
        {
            NativeCalls.godot_icall_0_8(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_point");

        /// <summary>
        /// Returns the id of closest point of given point.  -1 is returned if there are no points on AStar.
        /// </summary>
        public int get_closest_point(Vector3 to_pos)
        {
            return NativeCalls.godot_icall_1_26(method_bind_10, Object.GetPtr(this), ref to_pos);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_pos_in_segment");

        /// <summary>
        /// Returns the position of closest point that has segments.
        /// </summary>
        public Vector3 get_closest_pos_in_segment(Vector3 to_pos)
        {
            object ret = NativeCalls.godot_icall_1_27(method_bind_11, Object.GetPtr(this), ref to_pos);
            return (Vector3)ret;
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_path");

        /// <summary>
        /// Returns an array with the points of path found by AStar between two given points.
        /// </summary>
        public Vector3[] get_point_path(int from_id, int to_id)
        {
            return NativeCalls.godot_icall_2_28(method_bind_12, Object.GetPtr(this), from_id, to_id);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_id_path");

        /// <summary>
        /// Returns an array with the point ids of path found by AStar between two given points.
        /// </summary>
        public int[] get_id_path(int from_id, int to_id)
        {
            return NativeCalls.godot_icall_2_29(method_bind_13, Object.GetPtr(this), from_id, to_id);
        }
    }
}
