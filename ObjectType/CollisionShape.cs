using System;

namespace GodotEngine
{
    public class CollisionShape : Spatial
    {
        private const string nativeName = "CollisionShape";

        public CollisionShape() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CollisionShape_Ctor(this);
        }

        internal CollisionShape(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "resource_changed");

        public void resource_changed(Resource resource)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(resource));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shape");

        public void set_shape(Shape shape)
        {
            NativeCalls.godot_icall_1_35(method_bind_1, Object.GetPtr(this), Object.GetPtr(shape));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shape");

        public Shape get_shape()
        {
            return NativeCalls.godot_icall_0_154(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_disabled");

        public void set_disabled(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_3, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_disabled");

        public bool is_disabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "make_convex_from_brothers");

        public void make_convex_from_brothers()
        {
            NativeCalls.godot_icall_0_8(method_bind_5, Object.GetPtr(this));
        }
    }
}
