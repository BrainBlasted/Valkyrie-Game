using System;

namespace GodotEngine
{
    public class NativeScript : Script
    {
        private const string nativeName = "NativeScript";

        public NativeScript() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_NativeScript_Ctor(this);
        }

        internal NativeScript(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_class_name");

        public void set_class_name(string class_name)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), class_name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_class_name");

        public string get_class_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_library");

        public void set_library(GDNativeLibrary library)
        {
            NativeCalls.godot_icall_1_19(method_bind_2, Object.GetPtr(this), Object.GetPtr(library));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_library");

        public GDNativeLibrary get_library()
        {
            return NativeCalls.godot_icall_0_203(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "new");

        public object @new(params object[] @args)
        {
            return NativeCalls.godot_icall_1_113(method_bind_4, Object.GetPtr(this), @args);
        }
    }
}
