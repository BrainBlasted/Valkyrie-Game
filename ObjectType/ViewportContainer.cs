using System;

namespace GodotEngine
{
    public class ViewportContainer : Container
    {
        private const string nativeName = "ViewportContainer";

        public ViewportContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ViewportContainer_Ctor(this);
        }

        internal ViewportContainer(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_stretch");

        public void set_stretch(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_stretch_enabled");

        public bool is_stretch_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }
    }
}
