using System;

namespace GodotEngine
{
    public class GDNativeClass : Reference
    {
        private const string nativeName = "GDNativeClass";

        internal GDNativeClass() {}

        internal GDNativeClass(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "new");

        public object @new()
        {
            return NativeCalls.godot_icall_0_121(method_bind_0, Object.GetPtr(this));
        }
    }
}
