using System;

namespace GodotEngine
{
    /// <summary>
    /// Texture Based 3x3 scale style. This stylebox performs a 3x3 scaling of a texture, where only the center cell is fully stretched. This allows for the easy creation of bordered styles.
    /// </summary>
    public class StyleBoxTexture : StyleBox
    {
        private const string nativeName = "StyleBoxTexture";

        public StyleBoxTexture() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StyleBoxTexture_Ctor(this);
        }

        internal StyleBoxTexture(bool memoryOwn) : base(memoryOwn) {}

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

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_normal_map");

        public void set_normal_map(Texture normal_map)
        {
            NativeCalls.godot_icall_1_35(method_bind_2, Object.GetPtr(this), Object.GetPtr(normal_map));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_normal_map");

        public Texture get_normal_map()
        {
            return NativeCalls.godot_icall_0_92(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_margin_size");

        public void set_margin_size(int margin, float size)
        {
            NativeCalls.godot_icall_2_45(method_bind_4, Object.GetPtr(this), margin, size);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_margin_size");

        public float get_margin_size(int margin)
        {
            return NativeCalls.godot_icall_1_6(method_bind_5, Object.GetPtr(this), margin);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_expand_margin_size");

        public void set_expand_margin_size(int margin, float size)
        {
            NativeCalls.godot_icall_2_45(method_bind_6, Object.GetPtr(this), margin, size);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_expand_margin_size");

        public float get_expand_margin_size(int margin)
        {
            return NativeCalls.godot_icall_1_6(method_bind_7, Object.GetPtr(this), margin);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_region_rect");

        public void set_region_rect(Rect2 region)
        {
            NativeCalls.godot_icall_1_93(method_bind_8, Object.GetPtr(this), ref region);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_region_rect");

        public Rect2 get_region_rect()
        {
            object ret = NativeCalls.godot_icall_0_94(method_bind_9, Object.GetPtr(this));
            return (Rect2)ret;
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_draw_center");

        public void set_draw_center(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_10, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_draw_center");

        public bool get_draw_center()
        {
            return NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_modulate");

        public void set_modulate(Color color)
        {
            NativeCalls.godot_icall_1_122(method_bind_12, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_modulate");

        public Color get_modulate()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_13, Object.GetPtr(this));
            return (Color)ret;
        }
    }
}
