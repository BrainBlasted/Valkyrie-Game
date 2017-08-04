using System;

namespace GodotEngine
{
    /// <summary>
    /// A RayCast represents a line from its origin to its destination position [code]cast_to[/code], it is used to query the 3D space in order to find the closest object intersecting with the ray.
    /// RayCast can ignore some objects by adding them to the exception list via [code]add_exception[/code], setting proper filtering with layers, or by filtering object types with type masks.
    /// Only enabled raycasts will be able to query the space and report collisions!
    /// RayCast calculates intersection every fixed frame (see [Node]), and the result is cached so it can be used later until the next frame. If multiple queries are required between fixed frames (or during the same frame) use [method force_raycast_update] after adjusting the raycast.
    /// </summary>
    public class RayCast : Spatial
    {
        private const string nativeName = "RayCast";

        public RayCast() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_RayCast_Ctor(this);
        }

        internal RayCast(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_enabled");

        /// <summary>
        /// Enables the RayCast2D. Only enabled raycasts will be able to query the space and report collisions.
        /// </summary>
        public void set_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_enabled");

        /// <summary>
        /// Returns whether this raycast is enabled or not.
        /// </summary>
        public bool is_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cast_to");

        /// <summary>
        /// Sets to which point ray should be casted. This point is in [b]local[/b] coordinate system.
        /// </summary>
        public void set_cast_to(Vector3 local_point)
        {
            NativeCalls.godot_icall_1_83(method_bind_2, Object.GetPtr(this), ref local_point);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cast_to");

        /// <summary>
        /// Return the destination point of this ray object.
        /// </summary>
        public Vector3 get_cast_to()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_3, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_colliding");

        /// <summary>
        /// Return whether the closest object the ray is pointing to is colliding with the vector (considering the vector length).
        /// </summary>
        public bool is_colliding()
        {
            return NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "force_raycast_update");

        /// <summary>
        /// Updates the collision information in case if this object's properties changed during the current frame (for example position, rotation or the cast_point). Note, [code]set_enabled[/code] is not required for this to work.
        /// </summary>
        public void force_raycast_update()
        {
            NativeCalls.godot_icall_0_8(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collider");

        /// <summary>
        /// Return the closest object the ray is pointing to. Note that this does not consider the length of the vector, so you must also use [method is_colliding] to check if the object returned is actually colliding with the ray.
        /// </summary>
        public Object get_collider()
        {
            return NativeCalls.godot_icall_0_30(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collider_shape");

        /// <summary>
        /// Returns the collision shape of the closest object the ray is pointing to.
        /// </summary>
        public int get_collider_shape()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_point");

        /// <summary>
        /// Returns collision point. This point is in [b]global[/b] coordinate system.
        /// </summary>
        public Vector3 get_collision_point()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_8, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_normal");

        /// <summary>
        /// Returns the normal of the intersecting object shape face containing the collision point.
        /// </summary>
        public Vector3 get_collision_normal()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_9, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_exception_rid");

        public void add_exception_rid(RID rid)
        {
            NativeCalls.godot_icall_1_351(method_bind_10, Object.GetPtr(this), RID.GetPtr(rid));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_exception");

        /// <summary>
        /// Adds a collision exception so the ray does not report collisions with the specified [code]node[/code].
        /// </summary>
        public void add_exception(Object node)
        {
            NativeCalls.godot_icall_1_19(method_bind_11, Object.GetPtr(this), Object.GetPtr(node));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_exception_rid");

        public void remove_exception_rid(RID rid)
        {
            NativeCalls.godot_icall_1_351(method_bind_12, Object.GetPtr(this), RID.GetPtr(rid));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_exception");

        /// <summary>
        /// Removes a collision exception so the ray does report collisions with the specified [code]node[/code].
        /// </summary>
        public void remove_exception(Object node)
        {
            NativeCalls.godot_icall_1_19(method_bind_13, Object.GetPtr(this), Object.GetPtr(node));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear_exceptions");

        /// <summary>
        /// Removes all collision exception for this ray.
        /// </summary>
        public void clear_exceptions()
        {
            NativeCalls.godot_icall_0_8(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_collision_layer");

        /// <summary>
        /// Set the mask to filter objects. Only objects with at least the same mask element set will be detected.
        /// </summary>
        public void set_collision_layer(int layer)
        {
            NativeCalls.godot_icall_1_0(method_bind_15, Object.GetPtr(this), layer);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_layer");

        /// <summary>
        /// Returns the collision layer for this ray.
        /// </summary>
        public int get_collision_layer()
        {
            return NativeCalls.godot_icall_0_1(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_type_mask");

        /// <summary>
        /// Set the types of objects to detect. For [code]mask[/code] use a logic sum (OR operation) of constants defined in [PhysicsDirectSpaceState], eg. [code]PhysicsDirectSpaceState.TYPE_MASK_STATIC_BODY | PhysicsDirectSpaceState.TYPE_MASK_KINEMATIC_BODY[/code] to detect only those two types.
        /// </summary>
        public void set_type_mask(int mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_17, Object.GetPtr(this), mask);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_type_mask");

        /// <summary>
        /// Returns the type mask (types of objects to detect) for this ray. The value is a sum (bitwise OR'd) of constants available for [PhysicsDirectSpaceState].
        /// </summary>
        public int get_type_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_18, Object.GetPtr(this));
        }
    }
}
