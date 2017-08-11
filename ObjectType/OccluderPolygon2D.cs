using System;

namespace GodotEngine
{
    public class OccluderPolygon2D : Resource
    {
        public const int CULL_DISABLED = 0;
        public const int CULL_CLOCKWISE = 1;
        public const int CULL_COUNTER_CLOCKWISE = 2;

        private const string nativeName = "OccluderPolygon2D";

        public OccluderPolygon2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_OccluderPolygon2D_Ctor(this);
        }

        internal OccluderPolygon2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_closed");

        public void set_closed(bool closed)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), closed);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_closed");

        public bool is_closed()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cull_mode");

        public void set_cull_mode(int cull_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), cull_mode);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cull_mode");

        public int get_cull_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_polygon");

        public void set_polygon(Vector2[] polygon)
        {
            NativeCalls.godot_icall_1_154(method_bind_4, Object.GetPtr(this), polygon);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_polygon");

        public Vector2[] get_polygon()
        {
            return NativeCalls.godot_icall_0_155(method_bind_5, Object.GetPtr(this));
        }
    }
}
