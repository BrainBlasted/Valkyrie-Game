using System;

namespace GodotEngine
{
    /// <summary>
    /// Control frame that simply draws an assigned texture. It can stretch or not. It's a simple way to just show an image in a UI.
    /// </summary>
    public class TextureRect : Control
    {
        public const int STRETCH_SCALE_ON_EXPAND = 0;
        public const int STRETCH_SCALE = 1;
        public const int STRETCH_TILE = 2;
        public const int STRETCH_KEEP = 3;
        public const int STRETCH_KEEP_CENTERED = 4;
        public const int STRETCH_KEEP_ASPECT = 5;
        public const int STRETCH_KEEP_ASPECT_CENTERED = 6;
        public const int STRETCH_KEEP_ASPECT_COVERED = 7;

        private const string nativeName = "TextureRect";

        public TextureRect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TextureRect_Ctor(this);
        }

        internal TextureRect(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_texture");

        public void set_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_texture");

        public Texture get_texture()
        {
            return NativeCalls.godot_icall_0_93(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_expand");

        public void set_expand(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_expand");

        public bool has_expand()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_stretch_mode");

        public void set_stretch_mode(int stretch_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), stretch_mode);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_stretch_mode");

        public int get_stretch_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }
    }
}
