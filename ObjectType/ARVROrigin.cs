using System;

namespace GodotEngine
{
    public class ARVROrigin : Spatial
    {
        private const string nativeName = "ARVROrigin";

        public ARVROrigin() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVROrigin_Ctor(this);
        }

        internal ARVROrigin(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_world_scale");

        public void set_world_scale(float world_scale)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), world_scale);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_world_scale");

        public float get_world_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }
    }
}
