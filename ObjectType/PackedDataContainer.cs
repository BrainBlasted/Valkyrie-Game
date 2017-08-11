using System;

namespace GodotEngine
{
    public class PackedDataContainer : Resource
    {
        private const string nativeName = "PackedDataContainer";

        public PackedDataContainer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PackedDataContainer_Ctor(this);
        }

        internal PackedDataContainer(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "pack");

        public int pack(object value)
        {
            return NativeCalls.godot_icall_1_328(method_bind_0, Object.GetPtr(this), value);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "size");

        public int size()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }
    }
}
