using System;

namespace GodotEngine
{
    public class GDNativeLibrary : Resource
    {
        private const string nativeName = "GDNativeLibrary";

        public GDNativeLibrary() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GDNativeLibrary_Ctor(this);
        }

        internal GDNativeLibrary(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_library_path");

        public void set_library_path(string platform, string path)
        {
            NativeCalls.godot_icall_2_56(method_bind_0, Object.GetPtr(this), platform, path);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_library_path");

        public string get_library_path(string platform)
        {
            return NativeCalls.godot_icall_1_60(method_bind_1, Object.GetPtr(this), platform);
        }
    }
}
