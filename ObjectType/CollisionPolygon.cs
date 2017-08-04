using System;

namespace GodotEngine
{
    public class CollisionPolygon : Spatial
    {
        private const string nativeName = "CollisionPolygon";

        public CollisionPolygon() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CollisionPolygon_Ctor(this);
        }

        internal CollisionPolygon(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_depth");

        public void set_depth(float depth)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), depth);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_depth");

        public float get_depth()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_polygon");

        public void set_polygon(Vector2[] polygon)
        {
            NativeCalls.godot_icall_1_152(method_bind_2, Object.GetPtr(this), polygon);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_polygon");

        public Vector2[] get_polygon()
        {
            return NativeCalls.godot_icall_0_153(method_bind_3, Object.GetPtr(this));
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
    }
}
