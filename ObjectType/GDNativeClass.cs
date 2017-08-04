using System;

namespace GodotEngine
{
    public class GDNativeClass : Reference
    {
        private const string nativeName = "GDNativeClass";

        internal GDNativeClass() {}

        internal GDNativeClass(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "new");

        public void @new()
        {
            NativeCalls.godot_icall_0_8(method_bind_0, Object.GetPtr(this));
        }
    }
}