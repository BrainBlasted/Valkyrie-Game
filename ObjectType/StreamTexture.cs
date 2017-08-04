using System;

namespace GodotEngine
{
    public class StreamTexture : Texture
    {
        private const string nativeName = "StreamTexture";

        public StreamTexture() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_StreamTexture_Ctor(this);
        }

        internal StreamTexture(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "load");

        public int load(string path)
        {
            return NativeCalls.godot_icall_1_70(method_bind_0, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_load_path");

        public string get_load_path()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }
    }
}
