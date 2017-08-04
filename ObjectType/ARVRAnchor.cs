using System;

namespace GodotEngine
{
    public class ARVRAnchor : Spatial
    {
        private const string nativeName = "ARVRAnchor";

        public ARVRAnchor() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRAnchor_Ctor(this);
        }

        internal ARVRAnchor(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_anchor_id");

        public void set_anchor_id(int anchor_id)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), anchor_id);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_anchor_id");

        public int get_anchor_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_anchor_name");

        public string get_anchor_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_is_active");

        public bool get_is_active()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_size");

        public Vector3 get_size()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_4, Object.GetPtr(this));
            return (Vector3)ret;
        }
    }
}
