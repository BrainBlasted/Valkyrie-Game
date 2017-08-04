using System;

namespace GodotEngine
{
    /// <summary>
    /// Encapsulates a [ColorPicker] making it accesible by pressing a button, pressing the button will toggle the [ColorPicker] visibility
    /// </summary>
    public class ColorPickerButton : Button
    {
        private const string nativeName = "ColorPickerButton";

        public ColorPickerButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ColorPickerButton_Ctor(this);
        }

        internal ColorPickerButton(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pick_color");

        public void set_pick_color(Color color)
        {
            NativeCalls.godot_icall_1_122(method_bind_0, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pick_color");

        public Color get_pick_color()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_1, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_picker");

        public ColorPicker get_picker()
        {
            return NativeCalls.godot_icall_0_156(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_edit_alpha");

        /// <summary>
        /// See [method ColorPicker.set_edit_alpha]
        /// </summary>
        public void set_edit_alpha(bool show)
        {
            NativeCalls.godot_icall_1_7(method_bind_3, Object.GetPtr(this), show);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_editing_alpha");

        /// <summary>
        /// See [method ColorPicker.is_edit_alpha]
        /// </summary>
        public bool is_editing_alpha()
        {
            return NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }
    }
}
