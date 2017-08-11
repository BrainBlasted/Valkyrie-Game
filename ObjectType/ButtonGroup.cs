using System;

namespace GodotEngine
{
    /// <summary>
    /// Group of [Button]. All direct and indirect children buttons become radios. Only one allows being pressed.
    /// </summary>
    public class ButtonGroup : Resource
    {
        private const string nativeName = "ButtonGroup";

        public ButtonGroup() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ButtonGroup_Ctor(this);
        }

        internal ButtonGroup(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pressed_button");

        /// <summary>
        /// Return the pressed button.
        /// </summary>
        public BaseButton get_pressed_button()
        {
            return NativeCalls.godot_icall_0_112(method_bind_0, Object.GetPtr(this));
        }
    }
}
