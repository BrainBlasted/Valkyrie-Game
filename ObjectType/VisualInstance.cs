using System;

namespace GodotEngine
{
    public class VisualInstance : Spatial
    {
        private const string nativeName = "VisualInstance";

        internal VisualInstance() {}

        internal VisualInstance(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_base");

        public void set_base(RID @base)
        {
            NativeCalls.godot_icall_1_359(method_bind_0, Object.GetPtr(this), RID.GetPtr(@base));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_layer_mask");

        public void set_layer_mask(int mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_1, Object.GetPtr(this), mask);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_layer_mask");

        public int get_layer_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_transformed_aabb");

        public Rect3 get_transformed_aabb()
        {
            object ret = NativeCalls.godot_icall_0_92(method_bind_3, Object.GetPtr(this));
            return (Rect3)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_aabb");

        public Rect3 get_aabb()
        {
            object ret = NativeCalls.godot_icall_0_92(method_bind_4, Object.GetPtr(this));
            return (Rect3)ret;
        }
    }
}
