using System;

namespace GodotEngine
{
    /// <summary>
    /// Spatial is the base for every type of 3D [Node]. It contains a 3D [Transform] which can be set or get as local or global. If a Spatial [Node] has Spatial children, their transforms will be relative to the parent.
    /// </summary>
    public class Spatial : Node
    {
        /// <summary>
        /// Spatial nodes receive this notification with their global transform changes. This means that either the current or a parent node changed its transform.
        /// </summary>
        public const int NOTIFICATION_TRANSFORM_CHANGED = 29;
        public const int NOTIFICATION_ENTER_WORLD = 41;
        public const int NOTIFICATION_EXIT_WORLD = 42;
        public const int NOTIFICATION_VISIBILITY_CHANGED = 43;

        private const string nativeName = "Spatial";

        public Spatial() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Spatial_Ctor(this);
        }

        internal Spatial(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_transform");

        /// <summary>
        /// Set the transform locally, relative to the parent spatial node.
        /// </summary>
        public void set_transform(Transform local)
        {
            NativeCalls.godot_icall_1_208(method_bind_0, Object.GetPtr(this), ref local);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_transform");

        /// <summary>
        /// Return the local transform, relative to the bone parent.
        /// </summary>
        public Transform get_transform()
        {
            object ret = NativeCalls.godot_icall_0_14(method_bind_1, Object.GetPtr(this));
            return (Transform)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_translation");

        public void set_translation(Vector3 translation)
        {
            NativeCalls.godot_icall_1_83(method_bind_2, Object.GetPtr(this), ref translation);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_translation");

        public Vector3 get_translation()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_3, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rotation");

        /// <summary>
        /// Set the rotation (in radians).
        /// </summary>
        public void set_rotation(Vector3 rotation_rad)
        {
            NativeCalls.godot_icall_1_83(method_bind_4, Object.GetPtr(this), ref rotation_rad);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rotation");

        /// <summary>
        /// Return the rotation (in radians).
        /// </summary>
        public Vector3 get_rotation()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_5, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rotation_deg");

        /// <summary>
        /// Set the rotation (in degrees).
        /// </summary>
        public void set_rotation_deg(Vector3 rotation_deg)
        {
            NativeCalls.godot_icall_1_83(method_bind_6, Object.GetPtr(this), ref rotation_deg);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rotation_deg");

        /// <summary>
        /// Return the rotation (in degrees).
        /// </summary>
        public Vector3 get_rotation_deg()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_7, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_scale");

        public void set_scale(Vector3 scale)
        {
            NativeCalls.godot_icall_1_83(method_bind_8, Object.GetPtr(this), ref scale);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_scale");

        public Vector3 get_scale()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_9, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_global_transform");

        /// <summary>
        /// Set the transform globally, relative to worldspace.
        /// </summary>
        public void set_global_transform(Transform global)
        {
            NativeCalls.godot_icall_1_208(method_bind_10, Object.GetPtr(this), ref global);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_global_transform");

        /// <summary>
        /// Return the global transform, relative to worldspace.
        /// </summary>
        public Transform get_global_transform()
        {
            object ret = NativeCalls.godot_icall_0_14(method_bind_11, Object.GetPtr(this));
            return (Transform)ret;
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_parent_spatial");

        /// <summary>
        /// Return the parent [Spatial], or an empty [Object] if no parent exists or parent is not of type [Spatial].
        /// </summary>
        public Spatial get_parent_spatial()
        {
            return NativeCalls.godot_icall_0_438(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ignore_transform_notification");

        public void set_ignore_transform_notification(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_13, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_as_toplevel");

        public void set_as_toplevel(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_14, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_set_as_toplevel");

        public bool is_set_as_toplevel()
        {
            return NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_world");

        public World get_world()
        {
            return NativeCalls.godot_icall_0_439(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "update_gizmo");

        public void update_gizmo()
        {
            NativeCalls.godot_icall_0_8(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_gizmo");

        public void set_gizmo(SpatialGizmo gizmo)
        {
            NativeCalls.godot_icall_1_35(method_bind_18, Object.GetPtr(this), Object.GetPtr(gizmo));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_gizmo");

        public SpatialGizmo get_gizmo()
        {
            return NativeCalls.godot_icall_0_440(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_visible");

        public void set_visible(bool visible)
        {
            NativeCalls.godot_icall_1_7(method_bind_20, Object.GetPtr(this), visible);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_visible");

        public bool is_visible()
        {
            return NativeCalls.godot_icall_0_3(method_bind_21, Object.GetPtr(this));
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_visible_in_tree");

        public bool is_visible_in_tree()
        {
            return NativeCalls.godot_icall_0_3(method_bind_22, Object.GetPtr(this));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "show");

        public void show()
        {
            NativeCalls.godot_icall_0_8(method_bind_23, Object.GetPtr(this));
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "hide");

        public void hide()
        {
            NativeCalls.godot_icall_0_8(method_bind_24, Object.GetPtr(this));
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_notify_local_transform");

        public void set_notify_local_transform(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_25, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_local_transform_notification_enabled");

        public bool is_local_transform_notification_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_26, Object.GetPtr(this));
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_notify_transform");

        public void set_notify_transform(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_27, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_transform_notification_enabled");

        public bool is_transform_notification_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_28, Object.GetPtr(this));
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "rotate");

        public void rotate(Vector3 normal, float radians)
        {
            NativeCalls.godot_icall_2_441(method_bind_29, Object.GetPtr(this), ref normal, radians);
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "global_rotate");

        public void global_rotate(Vector3 normal, float radians)
        {
            NativeCalls.godot_icall_2_441(method_bind_30, Object.GetPtr(this), ref normal, radians);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "rotate_x");

        public void rotate_x(float radians)
        {
            NativeCalls.godot_icall_1_10(method_bind_31, Object.GetPtr(this), radians);
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "rotate_y");

        public void rotate_y(float radians)
        {
            NativeCalls.godot_icall_1_10(method_bind_32, Object.GetPtr(this), radians);
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "rotate_z");

        public void rotate_z(float radians)
        {
            NativeCalls.godot_icall_1_10(method_bind_33, Object.GetPtr(this), radians);
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "translate");

        public void translate(Vector3 offset)
        {
            NativeCalls.godot_icall_1_83(method_bind_34, Object.GetPtr(this), ref offset);
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "global_translate");

        public void global_translate(Vector3 offset)
        {
            NativeCalls.godot_icall_1_83(method_bind_35, Object.GetPtr(this), ref offset);
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "orthonormalize");

        public void orthonormalize()
        {
            NativeCalls.godot_icall_0_8(method_bind_36, Object.GetPtr(this));
        }

        private IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_identity");

        public void set_identity()
        {
            NativeCalls.godot_icall_0_8(method_bind_37, Object.GetPtr(this));
        }

        private IntPtr method_bind_38 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "look_at");

        public void look_at(Vector3 target, Vector3 up)
        {
            NativeCalls.godot_icall_2_378(method_bind_38, Object.GetPtr(this), ref target, ref up);
        }

        private IntPtr method_bind_39 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "look_at_from_pos");

        public void look_at_from_pos(Vector3 pos, Vector3 target, Vector3 up)
        {
            NativeCalls.godot_icall_3_442(method_bind_39, Object.GetPtr(this), ref pos, ref target, ref up);
        }

        private IntPtr method_bind_40 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "to_local");

        public Vector3 to_local(Vector3 global_point)
        {
            object ret = NativeCalls.godot_icall_1_27(method_bind_40, Object.GetPtr(this), ref global_point);
            return (Vector3)ret;
        }

        private IntPtr method_bind_41 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "to_global");

        public Vector3 to_global(Vector3 local_point)
        {
            object ret = NativeCalls.godot_icall_1_27(method_bind_41, Object.GetPtr(this), ref local_point);
            return (Vector3)ret;
        }
    }
}
