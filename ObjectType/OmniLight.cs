using System;

namespace GodotEngine
{
    /// <summary>
    /// An OmniDirectional light is a type of [Light] node that emits lights in all directions. The light is attenuated through the distance and this attenuation can be configured by changing the energy, radius and attenuation parameters of [Light].
    /// </summary>
    public class OmniLight : Light
    {
        private const string nativeName = "OmniLight";

        public OmniLight() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_OmniLight_Ctor(this);
        }

        internal OmniLight(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shadow_mode");

        public void set_shadow_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shadow_mode");

        public int get_shadow_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shadow_detail");

        public void set_shadow_detail(int detail)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), detail);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shadow_detail");

        public int get_shadow_detail()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }
    }
}
