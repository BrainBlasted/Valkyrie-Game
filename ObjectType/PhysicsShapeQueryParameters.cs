using System;

namespace GodotEngine
{
    public class PhysicsShapeQueryParameters : Reference
    {
        private const string nativeName = "PhysicsShapeQueryParameters";

        public PhysicsShapeQueryParameters() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PhysicsShapeQueryParameters_Ctor(this);
        }

        internal PhysicsShapeQueryParameters(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shape");

        public void set_shape(Resource shape)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(shape));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shape_rid");

        public void set_shape_rid(RID shape)
        {
            NativeCalls.godot_icall_1_359(method_bind_1, Object.GetPtr(this), RID.GetPtr(shape));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shape_rid");

        public RID get_shape_rid()
        {
            IntPtr ret = NativeCalls.godot_icall_0_122(method_bind_2, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_transform");

        public void set_transform(Transform transform)
        {
            NativeCalls.godot_icall_1_207(method_bind_3, Object.GetPtr(this), ref transform);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_transform");

        public Transform get_transform()
        {
            object ret = NativeCalls.godot_icall_0_14(method_bind_4, Object.GetPtr(this));
            return (Transform)ret;
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_margin");

        public void set_margin(float margin)
        {
            NativeCalls.godot_icall_1_10(method_bind_5, Object.GetPtr(this), margin);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_margin");

        public float get_margin()
        {
            return NativeCalls.godot_icall_0_11(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_collision_layer");

        public void set_collision_layer(int collision_layer)
        {
            NativeCalls.godot_icall_1_0(method_bind_7, Object.GetPtr(this), collision_layer);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_collision_layer");

        public int get_collision_layer()
        {
            return NativeCalls.godot_icall_0_1(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_object_type_mask");

        public void set_object_type_mask(int object_type_mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_9, Object.GetPtr(this), object_type_mask);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_object_type_mask");

        public int get_object_type_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_exclude");

        public void set_exclude(object[] exclude)
        {
            NativeCalls.godot_icall_1_373(method_bind_11, Object.GetPtr(this), exclude);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_exclude");

        public object[] get_exclude()
        {
            return NativeCalls.godot_icall_0_85(method_bind_12, Object.GetPtr(this));
        }
    }
}
