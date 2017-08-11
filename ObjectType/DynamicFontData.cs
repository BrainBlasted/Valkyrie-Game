using System;

namespace GodotEngine
{
    public class DynamicFontData : Resource
    {
        private const string nativeName = "DynamicFontData";

        public DynamicFontData() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_DynamicFontData_Ctor(this);
        }

        internal DynamicFontData(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_font_path");

        public void set_font_path(string path)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_font_path");

        public string get_font_path()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }
    }
}
