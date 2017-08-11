using System;

namespace GodotEngine
{
    public class VisualScriptPreload : VisualScriptNode
    {
        private const string nativeName = "VisualScriptPreload";

        public VisualScriptPreload() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptPreload_Ctor(this);
        }

        internal VisualScriptPreload(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_preload");

        public void set_preload(Resource resource)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(resource));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_preload");

        public Resource get_preload()
        {
            return NativeCalls.godot_icall_0_411(method_bind_1, Object.GetPtr(this));
        }
    }
}
