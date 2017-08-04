using System;

namespace GodotEngine
{
    /// <summary>
    /// Scrollbars are a [Range] based [Control], that display a draggable area (the size of the page). Horizontal ([HScrollBar]) and Vertical ([VScrollBar]) versions are available.
    /// </summary>
    public class ScrollBar : Range
    {
        private const string nativeName = "ScrollBar";

        internal ScrollBar() {}

        internal ScrollBar(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_custom_step");

        public void set_custom_step(float step)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), step);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_custom_step");

        public float get_custom_step()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }
    }
}
