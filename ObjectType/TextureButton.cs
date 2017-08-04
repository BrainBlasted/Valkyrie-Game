using System;

namespace GodotEngine
{
    /// <summary>
    /// Button that can be themed with textures. This is like a regular [Button] but can be themed by assigning textures to it. This button is intended to be easy to theme, however a regular button can expand (that uses styleboxes) and still be better if the interface is expect to have internationalization of texts.
    /// Only the normal texture is required, the others are optional.
    /// </summary>
    public class TextureButton : BaseButton
    {
        public const int STRETCH_SCALE = 0;
        public const int STRETCH_TILE = 1;
        public const int STRETCH_KEEP = 2;
        public const int STRETCH_KEEP_CENTERED = 3;
        public const int STRETCH_KEEP_ASPECT = 4;
        public const int STRETCH_KEEP_ASPECT_CENTERED = 5;
        public const int STRETCH_KEEP_ASPECT_COVERED = 6;

        private const string nativeName = "TextureButton";

        public TextureButton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TextureButton_Ctor(this);
        }

        internal TextureButton(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_normal_texture");

        public void set_normal_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pressed_texture");

        public void set_pressed_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_35(method_bind_1, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_hover_texture");

        public void set_hover_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_35(method_bind_2, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_disabled_texture");

        public void set_disabled_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_35(method_bind_3, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_focused_texture");

        public void set_focused_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_35(method_bind_4, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_click_mask");

        public void set_click_mask(BitMap mask)
        {
            NativeCalls.godot_icall_1_35(method_bind_5, Object.GetPtr(this), Object.GetPtr(mask));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_expand");

        public void set_expand(bool p_expand)
        {
            NativeCalls.godot_icall_1_7(method_bind_6, Object.GetPtr(this), p_expand);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_stretch_mode");

        public void set_stretch_mode(int p_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_7, Object.GetPtr(this), p_mode);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_normal_texture");

        public Texture get_normal_texture()
        {
            return NativeCalls.godot_icall_0_92(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pressed_texture");

        public Texture get_pressed_texture()
        {
            return NativeCalls.godot_icall_0_92(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_hover_texture");

        public Texture get_hover_texture()
        {
            return NativeCalls.godot_icall_0_92(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_disabled_texture");

        public Texture get_disabled_texture()
        {
            return NativeCalls.godot_icall_0_92(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_focused_texture");

        public Texture get_focused_texture()
        {
            return NativeCalls.godot_icall_0_92(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_click_mask");

        public BitMap get_click_mask()
        {
            return NativeCalls.godot_icall_0_466(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_expand");

        public bool get_expand()
        {
            return NativeCalls.godot_icall_0_3(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_stretch_mode");

        public int get_stretch_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_15, Object.GetPtr(this));
        }
    }
}
