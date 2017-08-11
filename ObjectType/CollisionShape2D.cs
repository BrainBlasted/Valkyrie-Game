using System;

namespace GodotEngine
{
    /// <summary>
    /// Editor-only class. This is not present when running the game. It's used in the editor to properly edit and position collision shapes in [CollisionObject2D]. This is not accessible from regular code.
    /// </summary>
    public class CollisionShape2D : Node2D
    {
        private const string nativeName = "CollisionShape2D";

        public CollisionShape2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CollisionShape2D_Ctor(this);
        }

        internal CollisionShape2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shape");

        public void set_shape(Shape2D shape)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(shape));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shape");

        /// <summary>
        /// Return this shape's [Shape2D].
        /// </summary>
        public Shape2D get_shape()
        {
            return NativeCalls.godot_icall_0_157(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_disabled");

        public void set_disabled(bool disabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), disabled);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_disabled");

        public bool is_disabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_one_way_collision");

        public void set_one_way_collision(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_4, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_one_way_collision_enabled");

        public bool is_one_way_collision_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }
    }
}
