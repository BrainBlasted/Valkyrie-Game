using System;

namespace GodotEngine
{
    public class VisualScriptEngineSingleton : VisualScriptNode
    {
        private const string nativeName = "VisualScriptEngineSingleton";

        public VisualScriptEngineSingleton() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptEngineSingleton_Ctor(this);
        }

        internal VisualScriptEngineSingleton(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_singleton");

        public void set_singleton(string name)
        {
            NativeCalls.godot_icall_1_34(method_bind_0, Object.GetPtr(this), name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_singleton");

        public string get_singleton()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }
    }
}
