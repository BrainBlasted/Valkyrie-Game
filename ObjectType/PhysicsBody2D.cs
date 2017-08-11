using System;

namespace GodotEngine
{
    /// <summary>
    /// PhysicsBody2D is an abstract base class for implementing a physics body. All *Body2D types inherit from it.
    /// </summary>
    public class PhysicsBody2D : CollisionObject2D
    {
        private const string nativeName = "PhysicsBody2D";

        internal PhysicsBody2D() {}

        internal PhysicsBody2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_collision_layer");

        /// <summary>
        /// Set the physics layers this area is in.
        /// Collidable objects can exist in any of 32 different layers. These layers are not visual, but more of a tagging system instead. A collidable can use these layers/tags to select with which objects it can collide, using [method set_collision_mask].
        /// A contact is detected if object A is in any of the layers that object B scans, or object B is in any layer scanned by object A.
        /// </summary>
        public void set_collision_layer(int layer)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), layer);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_layer");

        /// <summary>
        /// Return the physics layer this area is in.
        /// </summary>
        public int get_collision_layer()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_collision_mask");

        /// <summary>
        /// Set the physics layers this area can scan for collisions.
        /// </summary>
        public void set_collision_mask(int mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), mask);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_mask");

        /// <summary>
        /// Return the physics layers this area can scan for collisions.
        /// </summary>
        public int get_collision_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_collision_mask_bit");

        /// <summary>
        /// Set/clear individual bits on the collision mask. This makes selecting the areas scanned easier.
        /// </summary>
        public void set_collision_mask_bit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_42(method_bind_4, Object.GetPtr(this), bit, value);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_mask_bit");

        /// <summary>
        /// Return an individual bit on the collision mask.
        /// </summary>
        public bool get_collision_mask_bit(int bit)
        {
            return NativeCalls.godot_icall_1_22(method_bind_5, Object.GetPtr(this), bit);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_collision_layer_bit");

        /// <summary>
        /// Set/clear individual bits on the layer mask. This makes getting a body in/out of only one layer easier.
        /// </summary>
        public void set_collision_layer_bit(int bit, bool value)
        {
            NativeCalls.godot_icall_2_42(method_bind_6, Object.GetPtr(this), bit, value);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_layer_bit");

        /// <summary>
        /// Return an individual bit on the collision mask.
        /// </summary>
        public bool get_collision_layer_bit(int bit)
        {
            return NativeCalls.godot_icall_1_22(method_bind_7, Object.GetPtr(this), bit);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_collision_exception_with");

        public void add_collision_exception_with(Node body)
        {
            NativeCalls.godot_icall_1_34(method_bind_8, Object.GetPtr(this), Object.GetPtr(body));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_collision_exception_with");

        public void remove_collision_exception_with(Node body)
        {
            NativeCalls.godot_icall_1_34(method_bind_9, Object.GetPtr(this), Object.GetPtr(body));
        }
    }
}
