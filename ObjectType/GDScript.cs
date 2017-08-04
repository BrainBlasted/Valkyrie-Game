using System;

namespace GodotEngine
{
    public class GDScript : Script
    {
        private const string nativeName = "GDScript";

        public GDScript() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_GDScript_Ctor(this);
        }

        internal GDScript(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "new");

        public Object @new(params object[] @args)
        {
            return NativeCalls.godot_icall_1_112(method_bind_0, Object.GetPtr(this), @args);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_as_byte_code");

        public byte[] get_as_byte_code()
        {
            return NativeCalls.godot_icall_0_100(method_bind_1, Object.GetPtr(this));
        }
    }
}
