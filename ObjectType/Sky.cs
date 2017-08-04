using System;

namespace GodotEngine
{
    public class Sky : Resource
    {
        public const int RADIANCE_SIZE_32 = 0;
        public const int RADIANCE_SIZE_64 = 1;
        public const int RADIANCE_SIZE_128 = 2;
        public const int RADIANCE_SIZE_256 = 3;
        public const int RADIANCE_SIZE_512 = 4;
        public const int RADIANCE_SIZE_1024 = 5;
        public const int RADIANCE_SIZE_2048 = 6;
        public const int RADIANCE_SIZE_MAX = 7;

        private const string nativeName = "Sky";

        internal Sky() {}

        internal Sky(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_radiance_size");

        public void set_radiance_size(int size)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), size);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_radiance_size");

        public int get_radiance_size()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }
    }
}
