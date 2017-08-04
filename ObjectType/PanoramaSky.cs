using System;

namespace GodotEngine
{
    public class PanoramaSky : Sky
    {
        private const string nativeName = "PanoramaSky";

        public PanoramaSky() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PanoramaSky_Ctor(this);
        }

        internal PanoramaSky(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_panorama");

        public void set_panorama(Texture texture)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_panorama");

        public Texture get_panorama()
        {
            return NativeCalls.godot_icall_0_92(method_bind_1, Object.GetPtr(this));
        }
    }
}
