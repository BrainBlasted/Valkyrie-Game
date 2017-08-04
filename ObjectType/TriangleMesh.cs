using System;

namespace GodotEngine
{
    public class TriangleMesh : Reference
    {
        private const string nativeName = "TriangleMesh";

        public TriangleMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_TriangleMesh_Ctor(this);
        }

        internal TriangleMesh(bool memoryOwn) : base(memoryOwn) {}
    }
}
