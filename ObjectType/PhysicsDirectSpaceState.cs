using System;
using System.Collections.Generic;

namespace GodotEngine
{
    public class PhysicsDirectSpaceState : Object
    {
        public const int TYPE_MASK_STATIC_BODY = 1;
        public const int TYPE_MASK_KINEMATIC_BODY = 2;
        public const int TYPE_MASK_RIGID_BODY = 4;
        public const int TYPE_MASK_CHARACTER_BODY = 8;
        public const int TYPE_MASK_AREA = 16;
        public const int TYPE_MASK_COLLISION = 15;

        private const string nativeName = "PhysicsDirectSpaceState";

        internal PhysicsDirectSpaceState() {}

        internal PhysicsDirectSpaceState(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "intersect_ray");

        public Dictionary<object, object> intersect_ray(Vector3 from, Vector3 to, object[] exclude = null, int collision_layer = 2147483647, int type_mask = 15)
        {
            object[] exclude_in = exclude != null ? exclude : new object[] {};
            return NativeCalls.godot_icall_5_381(method_bind_0, Object.GetPtr(this), ref from, ref to, exclude_in, collision_layer, type_mask);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "intersect_shape");

        public object[] intersect_shape(PhysicsShapeQueryParameters shape, int max_results = 32)
        {
            return NativeCalls.godot_icall_2_346(method_bind_1, Object.GetPtr(this), Object.GetPtr(shape), max_results);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "cast_motion");

        public object[] cast_motion(PhysicsShapeQueryParameters shape, Vector3 motion)
        {
            return NativeCalls.godot_icall_2_382(method_bind_2, Object.GetPtr(this), Object.GetPtr(shape), ref motion);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "collide_shape");

        public object[] collide_shape(PhysicsShapeQueryParameters shape, int max_results = 32)
        {
            return NativeCalls.godot_icall_2_346(method_bind_3, Object.GetPtr(this), Object.GetPtr(shape), max_results);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rest_info");

        public Dictionary<object, object> get_rest_info(PhysicsShapeQueryParameters shape)
        {
            return NativeCalls.godot_icall_1_348(method_bind_4, Object.GetPtr(this), Object.GetPtr(shape));
        }
    }
}
