using System;

namespace GodotEngine
{
    /// <summary>
    /// Editor-only class. This is not present when running the game. It's used in the editor to properly edit and position collision shapes in [CollisionObject2D]. This is not accessible from regular code. This class is for editing custom shape polygons.
    /// </summary>
    public class CollisionPolygon2D : Node2D
    {
        private const string nativeName = "CollisionPolygon2D";

        public CollisionPolygon2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CollisionPolygon2D_Ctor(this);
        }

        internal CollisionPolygon2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_polygon");

        /// <summary>
        /// Set the array of points forming the polygon.
        /// When editing the point list via the editor, depending on [method get_build_mode], it has to be a list of points (for [code]build_mode==0[/code]), or a list of lines (for [code]build_mode==1[/code]). In the second case, the even elements of the array define the start point of the line, and the odd elements the end point.
        /// </summary>
        public void set_polygon(Vector2[] polygon)
        {
            NativeCalls.godot_icall_1_154(method_bind_0, Object.GetPtr(this), polygon);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_polygon");

        /// <summary>
        /// Return the list of points that define the polygon.
        /// </summary>
        public Vector2[] get_polygon()
        {
            return NativeCalls.godot_icall_0_155(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_build_mode");

        /// <summary>
        /// Set whether the polygon is to be a [ConvexPolygonShape2D] ([code]build_mode==0[/code]), or a [ConcavePolygonShape2D] ([code]build_mode==1[/code]).
        /// </summary>
        public void set_build_mode(int build_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), build_mode);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_build_mode");

        /// <summary>
        /// Return whether the polygon is a [ConvexPolygonShape2D] ([code]build_mode==0[/code]), or a [ConcavePolygonShape2D] ([code]build_mode==1[/code]).
        /// </summary>
        public int get_build_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_disabled");

        public void set_disabled(bool disabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_4, Object.GetPtr(this), disabled);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_disabled");

        public bool is_disabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_one_way_collision");

        public void set_one_way_collision(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_6, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_one_way_collision_enabled");

        public bool is_one_way_collision_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }
    }
}
