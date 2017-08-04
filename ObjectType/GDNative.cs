using System;

namespace GodotEngine
{
    public class GDNative : Reference
    {
        private const string nativeName = "GDNative";

        public GDNative() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GDNative_Ctor(this);
        }

        internal GDNative(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_library");

        public void set_library(GDNativeLibrary library)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(library));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_library");

        public GDNativeLibrary get_library()
        {
            return NativeCalls.godot_icall_0_204(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "initialize");

        public bool initialize()
        {
            return NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "terminate");

        public bool terminate()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "call_native");

        public object call_native(string procedure_name, object[] arguments, object[] arg2)
        {
            return NativeCalls.godot_icall_3_205(method_bind_4, Object.GetPtr(this), procedure_name, arguments, arg2);
        }
    }
}
