using System;

namespace GodotEngine
{
    public class Navigation2D : Node2D
    {
        private const string nativeName = "Navigation2D";

        public Navigation2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Navigation2D_Ctor(this);
        }

        internal Navigation2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "navpoly_create");

        public int navpoly_create(NavigationPolygon mesh, Transform2D xform, Object owner = null)
        {
            return NativeCalls.godot_icall_3_294(method_bind_0, Object.GetPtr(this), Object.GetPtr(mesh), ref xform, Object.GetPtr(owner));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "navpoly_set_transform");

        public void navpoly_set_transform(int id, Transform2D xform)
        {
            NativeCalls.godot_icall_2_151(method_bind_1, Object.GetPtr(this), id, ref xform);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "navpoly_remove");

        public void navpoly_remove(int id)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), id);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_simple_path");

        public Vector2[] get_simple_path(Vector2 start, Vector2 end, bool optimize = true)
        {
            return NativeCalls.godot_icall_3_295(method_bind_3, Object.GetPtr(this), ref start, ref end, optimize);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_point");

        public Vector2 get_closest_point(Vector2 to_point)
        {
            object ret = NativeCalls.godot_icall_1_144(method_bind_4, Object.GetPtr(this), ref to_point);
            return (Vector2)ret;
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_closest_point_owner");

        public Object get_closest_point_owner(Vector2 to_point)
        {
            return NativeCalls.godot_icall_1_296(method_bind_5, Object.GetPtr(this), ref to_point);
        }
    }
}
