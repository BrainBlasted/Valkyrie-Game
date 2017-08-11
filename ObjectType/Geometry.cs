using System;
using System.Collections.Generic;

namespace GodotEngine
{
    public static class Geometry
    {
        private const string nativeName = "_Geometry";
        internal static IntPtr ptr = NativeCalls.godot_icall__Geometry_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "build_box_planes");

        public static object[] build_box_planes(Vector3 extents)
        {
            return NativeCalls.godot_icall_1_529(method_bind_0, ptr, ref extents);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "build_cylinder_planes");

        public static object[] build_cylinder_planes(float radius, float height, int sides, int axis = 2)
        {
            return NativeCalls.godot_icall_4_530(method_bind_1, ptr, radius, height, sides, axis);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "build_capsule_planes");

        public static object[] build_capsule_planes(float radius, float height, int sides, int lats, int axis = 2)
        {
            return NativeCalls.godot_icall_5_531(method_bind_2, ptr, radius, height, sides, lats, axis);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "segment_intersects_circle");

        public static float segment_intersects_circle(Vector2 segment_from, Vector2 segment_to, Vector2 circle_pos, float circle_radius)
        {
            return NativeCalls.godot_icall_4_532(method_bind_3, ptr, ref segment_from, ref segment_to, ref circle_pos, circle_radius);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "segment_intersects_segment_2d");

        public static object segment_intersects_segment_2d(Vector2 from_a, Vector2 to_a, Vector2 from_b, Vector2 to_b)
        {
            return NativeCalls.godot_icall_4_533(method_bind_4, ptr, ref from_a, ref to_a, ref from_b, ref to_b);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_points_between_segments_2d");

        public static Vector2[] get_closest_points_between_segments_2d(Vector2 p1, Vector2 q1, Vector2 p2, Vector2 q2)
        {
            return NativeCalls.godot_icall_4_534(method_bind_5, ptr, ref p1, ref q1, ref p2, ref q2);
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_points_between_segments");

        public static Vector3[] get_closest_points_between_segments(Vector3 p1, Vector3 p2, Vector3 q1, Vector3 q2)
        {
            return NativeCalls.godot_icall_4_535(method_bind_6, ptr, ref p1, ref p2, ref q1, ref q2);
        }

        private static IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_point_to_segment_2d");

        public static Vector2 get_closest_point_to_segment_2d(Vector2 point, Vector2 s1, Vector2 s2)
        {
            object ret = NativeCalls.godot_icall_3_536(method_bind_7, ptr, ref point, ref s1, ref s2);
            return (Vector2)ret;
        }

        private static IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_point_to_segment");

        public static Vector3 get_closest_point_to_segment(Vector3 point, Vector3 s1, Vector3 s2)
        {
            object ret = NativeCalls.godot_icall_3_537(method_bind_8, ptr, ref point, ref s1, ref s2);
            return (Vector3)ret;
        }

        private static IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_point_to_segment_uncapped_2d");

        public static Vector2 get_closest_point_to_segment_uncapped_2d(Vector2 point, Vector2 s1, Vector2 s2)
        {
            object ret = NativeCalls.godot_icall_3_536(method_bind_9, ptr, ref point, ref s1, ref s2);
            return (Vector2)ret;
        }

        private static IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_point_to_segment_uncapped");

        public static Vector3 get_closest_point_to_segment_uncapped(Vector3 point, Vector3 s1, Vector3 s2)
        {
            object ret = NativeCalls.godot_icall_3_537(method_bind_10, ptr, ref point, ref s1, ref s2);
            return (Vector3)ret;
        }

        private static IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_uv84_normal_bit");

        public static int get_uv84_normal_bit(Vector3 normal)
        {
            return NativeCalls.godot_icall_1_26(method_bind_11, ptr, ref normal);
        }

        private static IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "ray_intersects_triangle");

        public static object ray_intersects_triangle(Vector3 from, Vector3 dir, Vector3 a, Vector3 b, Vector3 c)
        {
            return NativeCalls.godot_icall_5_538(method_bind_12, ptr, ref from, ref dir, ref a, ref b, ref c);
        }

        private static IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "segment_intersects_triangle");

        public static object segment_intersects_triangle(Vector3 from, Vector3 to, Vector3 a, Vector3 b, Vector3 c)
        {
            return NativeCalls.godot_icall_5_538(method_bind_13, ptr, ref from, ref to, ref a, ref b, ref c);
        }

        private static IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "segment_intersects_sphere");

        public static Vector3[] segment_intersects_sphere(Vector3 from, Vector3 to, Vector3 spos, float sradius)
        {
            return NativeCalls.godot_icall_4_539(method_bind_14, ptr, ref from, ref to, ref spos, sradius);
        }

        private static IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "segment_intersects_cylinder");

        public static Vector3[] segment_intersects_cylinder(Vector3 from, Vector3 to, float height, float radius)
        {
            return NativeCalls.godot_icall_4_540(method_bind_15, ptr, ref from, ref to, height, radius);
        }

        private static IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "segment_intersects_convex");

        public static Vector3[] segment_intersects_convex(Vector3 from, Vector3 to, object[] planes)
        {
            return NativeCalls.godot_icall_3_541(method_bind_16, ptr, ref from, ref to, planes);
        }

        private static IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "point_is_inside_triangle");

        public static bool point_is_inside_triangle(Vector2 point, Vector2 a, Vector2 b, Vector2 c)
        {
            return NativeCalls.godot_icall_4_542(method_bind_17, ptr, ref point, ref a, ref b, ref c);
        }

        private static IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "triangulate_polygon");

        public static int[] triangulate_polygon(Vector2[] polygon)
        {
            return NativeCalls.godot_icall_1_543(method_bind_18, ptr, polygon);
        }

        private static IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "make_atlas");

        public static Dictionary<object, object> make_atlas(Vector2[] sizes)
        {
            return NativeCalls.godot_icall_1_544(method_bind_19, ptr, sizes);
        }
    }
}
