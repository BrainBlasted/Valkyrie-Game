using System;
using System.Collections.Generic;

namespace GodotEngine
{
    /// <summary>
    /// Kinematic bodies are special types of bodies that are meant to be user-controlled. They are not affected by physics at all (to other types of bodies, such a character or a rigid body, these are the same as a static body). They have however, two main uses:
    /// Simulated Motion: When these bodies are moved manually, either from code or from an AnimationPlayer (with process mode set to fixed), the physics will automatically compute an estimate of their linear and angular velocity. This makes them very useful for moving platforms or other AnimationPlayer-controlled objects (like a door, a bridge that opens, etc).
    /// Kinematic Characters: KinematicBody2D also has an api for moving objects (the [method move] method) while performing collision tests. This makes them really useful to implement characters that collide against a world, but that don't require advanced physics.
    /// </summary>
    public class KinematicBody2D : PhysicsBody2D
    {
        private const string nativeName = "KinematicBody2D";

        public KinematicBody2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_KinematicBody2D_Ctor(this);
        }

        internal KinematicBody2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "move");

        /// <summary>
        /// Move the body in the given direction, stopping if there is an obstacle. If as a result of a movement there will be any collision then informations about this collision will be in returned dictionary.	Dictionary will contains those keys:
        /// - "position" - collision position
        /// - "normal" - collision normal
        /// - "local_shape" - id of this kinematic body shape that took part in a collision
        /// - "travel" -  traveled movement before being stopped
        /// - "remainder" - remaining movement before being stopped
        /// - "collider_id" - id of the collider, it can be used when dealing with [Physics2DServer]
        /// - "collider" - colliding body
        /// - "collider_shape_index" - index of the colliding shape, inside collider body "collider_metadata"
        /// If the body did not intersect anything, then an empty dictionary (dir.empty()==true) is returned instead. Please note that this method is less user friendly than [method move_and_slide]. If you don't want to program each edge case manually, then it's recommended to use [method move_and_slide] instead.
        /// </summary>
        public Dictionary<object, object> move(Vector2 rel_vec)
        {
            return NativeCalls.godot_icall_1_268(method_bind_0, Object.GetPtr(this), ref rel_vec);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "move_and_slide");

        public Vector2 move_and_slide(Vector2 linear_velocity, Nullable<Vector2> floor_normal = null, float slope_stop_min_velocity = 5, int max_bounces = 4, float floor_max_angle = 0.785398f)
        {
            Vector2 floor_normal_in = floor_normal.HasValue ? floor_normal.Value : new Vector2(0, 0);
            object ret = NativeCalls.godot_icall_5_269(method_bind_1, Object.GetPtr(this), ref linear_velocity, ref floor_normal_in, slope_stop_min_velocity, max_bounces, floor_max_angle);
            return (Vector2)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "test_move");

        /// <summary>
        /// Return true if there would be a collision if the body moved from the given point in the given direction.
        /// </summary>
        public bool test_move(Transform2D from, Vector2 rel_vec)
        {
            return NativeCalls.godot_icall_2_270(method_bind_2, Object.GetPtr(this), ref from, ref rel_vec);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_on_floor");

        public bool is_on_floor()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_on_ceiling");

        public bool is_on_ceiling()
        {
            return NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_on_wall");

        public bool is_on_wall()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_floor_velocity");

        public Vector2 get_floor_velocity()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_6, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_safe_margin");

        public void set_safe_margin(float pixels)
        {
            NativeCalls.godot_icall_1_10(method_bind_7, Object.GetPtr(this), pixels);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_safe_margin");

        public float get_safe_margin()
        {
            return NativeCalls.godot_icall_0_11(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_count");

        public int get_collision_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_position");

        public Vector2 get_collision_position(int collision)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_10, Object.GetPtr(this), collision);
            return (Vector2)ret;
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_normal");

        public Vector2 get_collision_normal(int collision)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_11, Object.GetPtr(this), collision);
            return (Vector2)ret;
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_travel");

        public Vector2 get_collision_travel(int collision)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_12, Object.GetPtr(this), collision);
            return (Vector2)ret;
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_remainder");

        public Vector2 get_collision_remainder(int collision)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_13, Object.GetPtr(this), collision);
            return (Vector2)ret;
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_local_shape");

        public Object get_collision_local_shape(int collision)
        {
            return NativeCalls.godot_icall_1_149(method_bind_14, Object.GetPtr(this), collision);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_collider");

        public Object get_collision_collider(int collision)
        {
            return NativeCalls.godot_icall_1_149(method_bind_15, Object.GetPtr(this), collision);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_collider_id");

        public int get_collision_collider_id(int collision)
        {
            return NativeCalls.godot_icall_1_5(method_bind_16, Object.GetPtr(this), collision);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_collider_shape");

        public Object get_collision_collider_shape(int collision)
        {
            return NativeCalls.godot_icall_1_149(method_bind_17, Object.GetPtr(this), collision);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_collider_shape_index");

        public int get_collision_collider_shape_index(int collision)
        {
            return NativeCalls.godot_icall_1_5(method_bind_18, Object.GetPtr(this), collision);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_collider_velocity");

        /// <summary>
        /// Return the velocity of the body that collided with this one.
        /// </summary>
        public Vector2 get_collision_collider_velocity(int collision)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_19, Object.GetPtr(this), collision);
            return (Vector2)ret;
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_collider_metadata");

        public object get_collision_collider_metadata(int collision)
        {
            return NativeCalls.godot_icall_1_262(method_bind_20, Object.GetPtr(this), collision);
        }
    }
}
