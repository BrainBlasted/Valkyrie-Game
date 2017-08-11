using System;

namespace GodotEngine
{
    public class Sprite3D : SpriteBase3D
    {
        private const string nativeName = "Sprite3D";

        public Sprite3D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Sprite3D_Ctor(this);
        }

        internal Sprite3D(bool memoryOwn) : base(memoryOwn) {}

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

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_region");

        public void set_region(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_region");

        public bool is_region()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_region_rect");

        public void set_region_rect(Rect2 rect)
        {
            NativeCalls.godot_icall_1_94(method_bind_4, Object.GetPtr(this), ref rect);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_region_rect");

        public Rect2 get_region_rect()
        {
            object ret = NativeCalls.godot_icall_0_95(method_bind_5, Object.GetPtr(this));
            return (Rect2)ret;
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_frame");

        public void set_frame(int frame)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), frame);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_frame");

        public int get_frame()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_vframes");

        public void set_vframes(int vframes)
        {
            NativeCalls.godot_icall_1_0(method_bind_8, Object.GetPtr(this), vframes);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_vframes");

        public int get_vframes()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_hframes");

        public void set_hframes(int hframes)
        {
            NativeCalls.godot_icall_1_0(method_bind_10, Object.GetPtr(this), hframes);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_hframes");

        public int get_hframes()
        {
            return NativeCalls.godot_icall_0_1(method_bind_11, Object.GetPtr(this));
        }
    }
}
