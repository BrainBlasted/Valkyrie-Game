using System;

namespace GodotEngine
{
    public class CollisionObject : Spatial
    {
        private const string nativeName = "CollisionObject";

        internal CollisionObject() {}

        internal CollisionObject(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ray_pickable");

        public void set_ray_pickable(bool ray_pickable)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), ray_pickable);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_ray_pickable");

        public bool is_ray_pickable()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_capture_input_on_drag");

        public void set_capture_input_on_drag(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_capture_input_on_drag");

        public bool get_capture_input_on_drag()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rid");

        public RID get_rid()
        {
            IntPtr ret = NativeCalls.godot_icall_0_121(method_bind_4, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_shape_owner");

        /// <summary>
        /// Creates new holder for the shapes. Argument is a [CollisionShape] node. It will return owner_id which usually you will want to save for later use.
        /// </summary>
        public int create_shape_owner(Object owner)
        {
            return NativeCalls.godot_icall_1_145(method_bind_5, Object.GetPtr(this), Object.GetPtr(owner));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_shape_owner");

        public void remove_shape_owner(int owner_id)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), owner_id);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shape_owners");

        /// <summary>
        /// Shape owner is a node which is holding concrete shape resources. This method will return an array which is holding an integer numbers that are representing unique ID of each owner. You can use those ids when you are using others shape_owner methods.
        /// </summary>
        public object[] get_shape_owners()
        {
            return NativeCalls.godot_icall_0_84(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_set_transform");

        public void shape_owner_set_transform(int owner_id, Transform transform)
        {
            NativeCalls.godot_icall_2_146(method_bind_8, Object.GetPtr(this), owner_id, ref transform);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_get_transform");

        /// <summary>
        /// Will return [Transform] of an owner node.
        /// </summary>
        public Transform shape_owner_get_transform(int owner_id)
        {
            object ret = NativeCalls.godot_icall_1_147(method_bind_9, Object.GetPtr(this), owner_id);
            return (Transform)ret;
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_get_owner");

        public Object shape_owner_get_owner(int owner_id)
        {
            return NativeCalls.godot_icall_1_148(method_bind_10, Object.GetPtr(this), owner_id);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_set_disabled");

        public void shape_owner_set_disabled(int owner_id, bool disabled)
        {
            NativeCalls.godot_icall_2_42(method_bind_11, Object.GetPtr(this), owner_id, disabled);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_shape_owner_disabled");

        public bool is_shape_owner_disabled(int owner_id)
        {
            return NativeCalls.godot_icall_1_22(method_bind_12, Object.GetPtr(this), owner_id);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_add_shape");

        public void shape_owner_add_shape(int owner_id, Shape shape)
        {
            NativeCalls.godot_icall_2_88(method_bind_13, Object.GetPtr(this), owner_id, Object.GetPtr(shape));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_get_shape_count");

        /// <summary>
        /// Returns number of shapes to which given owner is associated to.
        /// </summary>
        public int shape_owner_get_shape_count(int owner_id)
        {
            return NativeCalls.godot_icall_1_5(method_bind_14, Object.GetPtr(this), owner_id);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_get_shape");

        /// <summary>
        /// Will return a [Shape]. First argument owner_id is an integer that can be obtained from [method get_shape_owners]. Shape_id is a position of the shape inside owner; it's a value in range from 0 to [method shape_owner_get_shape_count].
        /// </summary>
        public Object shape_owner_get_shape(int owner_id, int shape_id)
        {
            return NativeCalls.godot_icall_2_149(method_bind_15, Object.GetPtr(this), owner_id, shape_id);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_get_shape_index");

        public int shape_owner_get_shape_index(int owner_id, int shape_id)
        {
            return NativeCalls.godot_icall_2_38(method_bind_16, Object.GetPtr(this), owner_id, shape_id);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_remove_shape");

        /// <summary>
        /// Removes related shape from the owner.
        /// </summary>
        public void shape_owner_remove_shape(int owner_id, int shape_id)
        {
            NativeCalls.godot_icall_2_24(method_bind_17, Object.GetPtr(this), owner_id, shape_id);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_owner_clear_shapes");

        /// <summary>
        /// Will remove all the shapes associated with given owner.
        /// </summary>
        public void shape_owner_clear_shapes(int owner_id)
        {
            NativeCalls.godot_icall_1_0(method_bind_18, Object.GetPtr(this), owner_id);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shape_find_owner");

        public int shape_find_owner(int shape_index)
        {
            return NativeCalls.godot_icall_1_5(method_bind_19, Object.GetPtr(this), shape_index);
        }
    }
}
