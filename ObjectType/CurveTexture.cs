using System;

namespace GodotEngine
{
    public class CurveTexture : Texture
    {
        private const string nativeName = "CurveTexture";

        public CurveTexture() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CurveTexture_Ctor(this);
        }

        internal CurveTexture(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_width");

        public void set_width(int width)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), width);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_curve");

        public void set_curve(Curve curve)
        {
            NativeCalls.godot_icall_1_19(method_bind_1, Object.GetPtr(this), Object.GetPtr(curve));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_curve");

        public Curve get_curve()
        {
            return NativeCalls.godot_icall_0_193(method_bind_2, Object.GetPtr(this));
        }
    }
}
