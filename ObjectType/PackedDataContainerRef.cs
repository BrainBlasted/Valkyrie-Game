using System;

namespace GodotEngine
{
    public class PackedDataContainerRef : Reference
    {
        private const string nativeName = "PackedDataContainerRef";

        internal PackedDataContainerRef() {}

        internal PackedDataContainerRef(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "size");

        public int size()
        {
            return NativeCalls.godot_icall_0_1(method_bind_0, Object.GetPtr(this));
        }
    }
}
