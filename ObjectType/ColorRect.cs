using System;

namespace GodotEngine
{
    public class ColorRect : Control
    {
        private const string nativeName = "ColorRect";

        public ColorRect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ColorRect_Ctor(this);
        }

        internal ColorRect(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_frame_color");

        public void set_frame_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_0, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_frame_color");

        public Color get_frame_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_1, Object.GetPtr(this));
            return (Color)ret;
        }
    }
}
