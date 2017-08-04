using System;

namespace GodotEngine
{
    public class ARVRInterface : Reference
    {
        public const int EYE_MONO = 0;
        public const int EYE_LEFT = 1;
        public const int EYE_RIGHT = 2;

        private const string nativeName = "ARVRInterface";

        internal ARVRInterface() {}

        internal ARVRInterface(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_name");

        public string get_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_primary");

        public bool is_primary()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_is_primary");

        public void set_is_primary(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_installed");

        public bool is_installed()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "hmd_is_present");

        public bool hmd_is_present()
        {
            return NativeCalls.godot_icall_0_3(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "supports_hmd");

        public bool supports_hmd()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_initialized");

        public bool is_initialized()
        {
            return NativeCalls.godot_icall_0_3(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "initialize");

        public bool initialize()
        {
            return NativeCalls.godot_icall_0_3(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "uninitialize");

        public void uninitialize()
        {
            NativeCalls.godot_icall_0_8(method_bind_8, Object.GetPtr(this));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_recommended_render_targetsize");

        public Vector2 get_recommended_render_targetsize()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_9, Object.GetPtr(this));
            return (Vector2)ret;
        }
    }
}
