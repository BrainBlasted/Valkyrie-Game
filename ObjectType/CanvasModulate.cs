using System;

namespace GodotEngine
{
    /// <summary>
    /// CanvasModulate tints the canvas elements using its assigned color
    /// </summary>
    public class CanvasModulate : Node2D
    {
        private const string nativeName = "CanvasModulate";

        public CanvasModulate() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CanvasModulate_Ctor(this);
        }

        internal CanvasModulate(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_color");

        /// <summary>
        /// Sets the canvas tint color
        /// </summary>
        public void set_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_0, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_color");

        /// <summary>
        /// Gets the canvas tint color
        /// </summary>
        public Color get_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_1, Object.GetPtr(this));
            return (Color)ret;
        }
    }
}
