using System;

namespace GodotEngine
{
    public class CSharpScript : Script
    {
        private const string nativeName = "CSharpScript";

        public CSharpScript() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_CSharpScript_Ctor(this);
        }

        internal CSharpScript(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "new");

        public object @new(params object[] @args)
        {
            return NativeCalls.godot_icall_1_113(method_bind_0, Object.GetPtr(this), @args);
        }
    }
}
