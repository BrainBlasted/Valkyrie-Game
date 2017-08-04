using System;

namespace GodotEngine
{
    public class BitMap : Resource
    {
        private const string nativeName = "BitMap";

        public BitMap() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BitMap_Ctor(this);
        }

        internal BitMap(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create");

        public void create(Vector2 size)
        {
            NativeCalls.godot_icall_1_37(method_bind_0, Object.GetPtr(this), ref size);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_from_image_alpha");

        public void create_from_image_alpha(Image image)
        {
            NativeCalls.godot_icall_1_35(method_bind_1, Object.GetPtr(this), Object.GetPtr(image));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bit");

        public void set_bit(Vector2 pos, bool bit)
        {
            NativeCalls.godot_icall_2_104(method_bind_2, Object.GetPtr(this), ref pos, bit);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bit");

        public bool get_bit(Vector2 pos)
        {
            return NativeCalls.godot_icall_1_105(method_bind_3, Object.GetPtr(this), ref pos);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bit_rect");

        public void set_bit_rect(Rect2 p_rect, bool bit)
        {
            NativeCalls.godot_icall_2_106(method_bind_4, Object.GetPtr(this), ref p_rect, bit);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_true_bit_count");

        public int get_true_bit_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_size");

        public Vector2 get_size()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_6, Object.GetPtr(this));
            return (Vector2)ret;
        }
    }
}
