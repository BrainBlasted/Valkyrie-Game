using System;

namespace GodotEngine
{
    public class TouchScreenButton : Node2D
    {
        private const string nativeName = "TouchScreenButton";

        public TouchScreenButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TouchScreenButton_Ctor(this);
        }

        internal TouchScreenButton(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_texture");

        public void set_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_texture");

        public Texture get_texture()
        {
            return NativeCalls.godot_icall_0_92(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_texture_pressed");

        public void set_texture_pressed(Texture texture_pressed)
        {
            NativeCalls.godot_icall_1_35(method_bind_2, Object.GetPtr(this), Object.GetPtr(texture_pressed));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_texture_pressed");

        public Texture get_texture_pressed()
        {
            return NativeCalls.godot_icall_0_92(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bitmask");

        public void set_bitmask(BitMap bitmask)
        {
            NativeCalls.godot_icall_1_35(method_bind_4, Object.GetPtr(this), Object.GetPtr(bitmask));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bitmask");

        public BitMap get_bitmask()
        {
            return NativeCalls.godot_icall_0_466(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shape");

        public void set_shape(Shape2D shape)
        {
            NativeCalls.godot_icall_1_35(method_bind_6, Object.GetPtr(this), Object.GetPtr(shape));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_shape");

        public Shape2D get_shape()
        {
            return NativeCalls.godot_icall_0_155(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shape_centered");

        public void set_shape_centered(bool @bool)
        {
            NativeCalls.godot_icall_1_7(method_bind_8, Object.GetPtr(this), @bool);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_shape_centered");

        public bool is_shape_centered()
        {
            return NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_shape_visible");

        public void set_shape_visible(bool @bool)
        {
            NativeCalls.godot_icall_1_7(method_bind_10, Object.GetPtr(this), @bool);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_shape_visible");

        public bool is_shape_visible()
        {
            return NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_action");

        public void set_action(string action)
        {
            NativeCalls.godot_icall_1_34(method_bind_12, Object.GetPtr(this), action);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_action");

        public string get_action()
        {
            return NativeCalls.godot_icall_0_2(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_visibility_mode");

        public void set_visibility_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_14, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_visibility_mode");

        public int get_visibility_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_passby_press");

        public void set_passby_press(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_16, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_passby_press_enabled");

        public bool is_passby_press_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_pressed");

        public bool is_pressed()
        {
            return NativeCalls.godot_icall_0_3(method_bind_18, Object.GetPtr(this));
        }
    }
}
