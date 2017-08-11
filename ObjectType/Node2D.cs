using System;

namespace GodotEngine
{
    /// <summary>
    /// Base node for 2D system. Node2D contains a position, rotation and scale, which is used to position and animate. It can alternatively be used with a custom 2D transform ([Transform2D]). A tree of Node2Ds allows complex hierarchies for animation and positioning.
    /// </summary>
    public class Node2D : CanvasItem
    {
        private const string nativeName = "Node2D";

        public Node2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Node2D_Ctor(this);
        }

        internal Node2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_position");

        /// <summary>
        /// Set the position of the 2D node.
        /// </summary>
        public void set_position(Vector2 pos)
        {
            NativeCalls.godot_icall_1_37(method_bind_0, Object.GetPtr(this), ref pos);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rotation");

        /// <summary>
        /// Set the rotation in radians of the 2D node.
        /// </summary>
        public void set_rotation(float radians)
        {
            NativeCalls.godot_icall_1_10(method_bind_1, Object.GetPtr(this), radians);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rotation_in_degrees");

        /// <summary>
        /// Set the rotation in degrees of the 2D node.
        /// </summary>
        public void set_rotation_in_degrees(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_scale");

        /// <summary>
        /// Set the scale of the 2D node.
        /// </summary>
        public void set_scale(Vector2 scale)
        {
            NativeCalls.godot_icall_1_37(method_bind_3, Object.GetPtr(this), ref scale);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_position");

        /// <summary>
        /// Return the position of the 2D node.
        /// </summary>
        public Vector2 get_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_4, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rotation");

        /// <summary>
        /// Return the rotation in radians of the 2D node.
        /// </summary>
        public float get_rotation()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rotation_in_degrees");

        /// <summary>
        /// Return the rotation in degrees of the 2D node.
        /// </summary>
        public float get_rotation_in_degrees()
        {
            return NativeCalls.godot_icall_0_11(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_scale");

        /// <summary>
        /// Return the scale of the 2D node.
        /// </summary>
        public Vector2 get_scale()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_7, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "rotate");

        /// <summary>
        /// Apply a rotation (in radians) to the 2D node, starting from its current rotation.
        /// </summary>
        public void rotate(float radians)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), radians);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "move_local_x");

        /// <summary>
        /// Apply a local translation on X axis to the 2D node according to the 'delta' of the process. If 'scaled' is false, the movement is normalized.
        /// </summary>
        public void move_local_x(float delta, bool scaled = false)
        {
            NativeCalls.godot_icall_2_67(method_bind_9, Object.GetPtr(this), delta, scaled);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "move_local_y");

        /// <summary>
        /// Apply a local translation on Y axis to the 2D node according to the 'delta' of the process. If 'scaled' is false, the movement is normalized.
        /// </summary>
        public void move_local_y(float delta, bool scaled = false)
        {
            NativeCalls.godot_icall_2_67(method_bind_10, Object.GetPtr(this), delta, scaled);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "translate");

        /// <summary>
        /// Apply a local translation of 'offset' to the 2D node, starting from its current local position.
        /// </summary>
        public void translate(Vector2 offset)
        {
            NativeCalls.godot_icall_1_37(method_bind_11, Object.GetPtr(this), ref offset);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "global_translate");

        /// <summary>
        /// Apply a global translation of 'offset' to the 2D node, starting from its current global position.
        /// </summary>
        public void global_translate(Vector2 offset)
        {
            NativeCalls.godot_icall_1_37(method_bind_12, Object.GetPtr(this), ref offset);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "apply_scale");

        public void apply_scale(Vector2 ratio)
        {
            NativeCalls.godot_icall_1_37(method_bind_13, Object.GetPtr(this), ref ratio);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_global_position");

        /// <summary>
        /// Set the global position of the 2D node.
        /// </summary>
        public void set_global_position(Vector2 pos)
        {
            NativeCalls.godot_icall_1_37(method_bind_14, Object.GetPtr(this), ref pos);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_position");

        /// <summary>
        /// Return the global position of the 2D node.
        /// </summary>
        public Vector2 get_global_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_15, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_global_rotation");

        /// <summary>
        /// Set the global rotation in radians of the 2D node
        /// </summary>
        public void set_global_rotation(float radians)
        {
            NativeCalls.godot_icall_1_10(method_bind_16, Object.GetPtr(this), radians);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_rotation");

        /// <summary>
        /// Return the global rotation in radians of the 2D node.
        /// </summary>
        public float get_global_rotation()
        {
            return NativeCalls.godot_icall_0_11(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_global_rotation_in_degrees");

        /// <summary>
        /// Set the global rotation in degrees of the 2D node
        /// </summary>
        public void set_global_rotation_in_degrees(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_18, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_rotation_in_degrees");

        /// <summary>
        /// Return the global rotation in degrees of the 2D node.
        /// </summary>
        public float get_global_rotation_in_degrees()
        {
            return NativeCalls.godot_icall_0_11(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_global_scale");

        /// <summary>
        /// Set the global scale of the 2D node.
        /// </summary>
        public void set_global_scale(Vector2 scale)
        {
            NativeCalls.godot_icall_1_37(method_bind_20, Object.GetPtr(this), ref scale);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_scale");

        /// <summary>
        /// Return the global scale of the 2D node.
        /// </summary>
        public Vector2 get_global_scale()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_21, Object.GetPtr(this));
            return (Vector2)ret;
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_transform");

        /// <summary>
        /// Set the local transform [Transform2D] of the 2D node.
        /// </summary>
        public void set_transform(Transform2D xform)
        {
            NativeCalls.godot_icall_1_140(method_bind_22, Object.GetPtr(this), ref xform);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_global_transform");

        /// <summary>
        /// Set the global transform [Transform2D] of the 2D node.
        /// </summary>
        public void set_global_transform(Transform2D xform)
        {
            NativeCalls.godot_icall_1_140(method_bind_23, Object.GetPtr(this), ref xform);
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "look_at");

        /// <summary>
        /// Rotate the 2d node so it points at 'point' position.
        /// </summary>
        public void look_at(Vector2 point)
        {
            NativeCalls.godot_icall_1_37(method_bind_24, Object.GetPtr(this), ref point);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_angle_to");

        /// <summary>
        /// Return the rotation angle in radians needed for the 2d node to point at 'point' position.
        /// </summary>
        public float get_angle_to(Vector2 point)
        {
            return NativeCalls.godot_icall_1_317(method_bind_25, Object.GetPtr(this), ref point);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "to_local");

        public Vector2 to_local(Vector2 global_point)
        {
            object ret = NativeCalls.godot_icall_1_144(method_bind_26, Object.GetPtr(this), ref global_point);
            return (Vector2)ret;
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "to_global");

        public Vector2 to_global(Vector2 local_point)
        {
            object ret = NativeCalls.godot_icall_1_144(method_bind_27, Object.GetPtr(this), ref local_point);
            return (Vector2)ret;
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_z");

        /// <summary>
        /// Set the Z-index value of the 2D node.
        /// </summary>
        public void set_z(int z)
        {
            NativeCalls.godot_icall_1_0(method_bind_28, Object.GetPtr(this), z);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_z");

        /// <summary>
        /// Return the Z-index of the 2D node.
        /// </summary>
        public int get_z()
        {
            return NativeCalls.godot_icall_0_1(method_bind_29, Object.GetPtr(this));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_z_as_relative");

        /// <summary>
        /// Set the Z-index value as relative to the parent node of this 2D node. Thus, if this 2D node's Z-index value is 2 and its parent's effective Z-index is 3, then the effective Z-index value of this 2D node would be 3 + 2 = 5.
        /// </summary>
        public void set_z_as_relative(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_30, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_z_relative");

        /// <summary>
        /// Return true if the Z-index value of this 2D node is relative to its parent's. Else, return false.
        /// </summary>
        public bool is_z_relative()
        {
            return NativeCalls.godot_icall_0_3(method_bind_31, Object.GetPtr(this));
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "edit_set_pivot");

        /// <summary>
        /// Set the pivot position of the 2D node to 'pivot' value. This method is implemented only in some nodes that inherit Node2D.
        /// </summary>
        public void edit_set_pivot(Vector2 pivot)
        {
            NativeCalls.godot_icall_1_37(method_bind_32, Object.GetPtr(this), ref pivot);
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_relative_transform_to_parent");

        public Transform2D get_relative_transform_to_parent(Node parent)
        {
            object ret = NativeCalls.godot_icall_1_318(method_bind_33, Object.GetPtr(this), Object.GetPtr(parent));
            return (Transform2D)ret;
        }
    }
}
