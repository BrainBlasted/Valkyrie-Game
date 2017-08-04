using System;

namespace GodotEngine
{
    /// <summary>
    /// To be changed, ignore.
    /// </summary>
    public class Shader : Resource
    {
        public const int MODE_SPATIAL = 0;
        public const int MODE_CANVAS_ITEM = 1;
        public const int MODE_PARTICLES = 2;

        private const string nativeName = "Shader";

        public Shader() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Shader_Ctor(this);
        }

        internal Shader(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mode");

        public int get_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_code");

        public void set_code(string code)
        {
            NativeCalls.godot_icall_1_34(method_bind_1, Object.GetPtr(this), code);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_code");

        public string get_code()
        {
            return NativeCalls.godot_icall_0_2(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_default_texture_param");

        public void set_default_texture_param(string param, Texture texture)
        {
            NativeCalls.godot_icall_2_72(method_bind_3, Object.GetPtr(this), param, Object.GetPtr(texture));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_default_texture_param");

        public Texture get_default_texture_param(string param)
        {
            return NativeCalls.godot_icall_1_432(method_bind_4, Object.GetPtr(this), param);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_param");

        public bool has_param(string name)
        {
            return NativeCalls.godot_icall_1_56(method_bind_5, Object.GetPtr(this), name);
        }
    }
}
