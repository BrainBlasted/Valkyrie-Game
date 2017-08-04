using System;

namespace GodotEngine
{
    public class CanvasItemMaterial : Material
    {
        public const int BLEND_MODE_MIX = 0;
        public const int BLEND_MODE_ADD = 1;
        public const int BLEND_MODE_SUB = 2;
        public const int BLEND_MODE_MUL = 3;
        public const int BLEND_MODE_PREMULT_ALPHA = 4;
        public const int LIGHT_MODE_NORMAL = 0;
        public const int LIGHT_MODE_UNSHADED = 1;
        public const int LIGHT_MODE_LIGHT_ONLY = 2;

        private const string nativeName = "CanvasItemMaterial";

        public CanvasItemMaterial() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CanvasItemMaterial_Ctor(this);
        }

        internal CanvasItemMaterial(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_blend_mode");

        public void set_blend_mode(int blend_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), blend_mode);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_blend_mode");

        public int get_blend_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_light_mode");

        public void set_light_mode(int light_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, Object.GetPtr(this), light_mode);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_light_mode");

        public int get_light_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }
    }
}
