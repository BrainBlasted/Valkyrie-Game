using System;

namespace GodotEngine
{
    public class NinePatchRect : Control
    {
        public const int AXIS_STRETCH_MODE_STRETCH = 0;
        public const int AXIS_STRETCH_MODE_TILE = 1;
        public const int AXIS_STRETCH_MODE_TILE_FIT = 2;

        private const string nativeName = "NinePatchRect";

        public NinePatchRect() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NinePatchRect_Ctor(this);
        }

        internal NinePatchRect(bool memoryOwn) : base(memoryOwn) {}

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

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_patch_margin");

        public void set_patch_margin(int margin, int value)
        {
            NativeCalls.godot_icall_2_24(method_bind_2, Object.GetPtr(this), margin, value);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_patch_margin");

        public int get_patch_margin(int margin)
        {
            return NativeCalls.godot_icall_1_5(method_bind_3, Object.GetPtr(this), margin);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_region_rect");

        public void set_region_rect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_93(method_bind_4, Object.GetPtr(this), ref rect);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_region_rect");

        public Rect2 get_region_rect()
        {
            object ret = NativeCalls.godot_icall_0_94(method_bind_5, Object.GetPtr(this));
            return (Rect2)ret;
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_draw_center");

        public void set_draw_center(bool draw_center)
        {
            NativeCalls.godot_icall_1_7(method_bind_6, Object.GetPtr(this), draw_center);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_draw_center");

        public bool get_draw_center()
        {
            return NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_h_axis_stretch_mode");

        public void set_h_axis_stretch_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_8, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_h_axis_stretch_mode");

        public int get_h_axis_stretch_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_v_axis_stretch_mode");

        public void set_v_axis_stretch_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_10, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_v_axis_stretch_mode");

        public int get_v_axis_stretch_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_11, Object.GetPtr(this));
        }
    }
}
