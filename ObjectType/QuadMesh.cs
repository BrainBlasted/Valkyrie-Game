using System;

namespace GodotEngine
{
    public class QuadMesh : PrimitiveMesh
    {
        private const string nativeName = "QuadMesh";

        public QuadMesh() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_QuadMesh_Ctor(this);
        }

        internal QuadMesh(bool memoryOwn) : base(memoryOwn) {}
    }
}
