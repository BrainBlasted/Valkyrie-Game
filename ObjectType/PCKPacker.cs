using System;

namespace GodotEngine
{
    public class PCKPacker : Reference
    {
        private const string nativeName = "PCKPacker";

        public PCKPacker() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PCKPacker_Ctor(this);
        }

        internal PCKPacker(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "pck_start");

        public int pck_start(string pck_name, int alignment)
        {
            return NativeCalls.godot_icall_2_238(method_bind_0, Object.GetPtr(this), pck_name, alignment);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_file");

        public int add_file(string pck_path, string source_path)
        {
            return NativeCalls.godot_icall_2_69(method_bind_1, Object.GetPtr(this), pck_path, source_path);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "flush");

        public int flush(bool verbose)
        {
            return NativeCalls.godot_icall_1_330(method_bind_2, Object.GetPtr(this), verbose);
        }
    }
}
