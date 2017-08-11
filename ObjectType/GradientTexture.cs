using System;

namespace GodotEngine
{
    public class GradientTexture : Texture
    {
        private const string nativeName = "GradientTexture";

        public GradientTexture() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GradientTexture_Ctor(this);
        }

        internal GradientTexture(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_gradient");

        public void set_gradient(Gradient gradient)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(gradient));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_gradient");

        public Gradient get_gradient()
        {
            return NativeCalls.godot_icall_0_217(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_width");

        public void set_width(int width)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), width);
        }
    }
}
