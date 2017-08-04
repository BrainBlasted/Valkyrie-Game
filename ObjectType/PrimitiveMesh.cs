using System;

namespace GodotEngine
{
    public class PrimitiveMesh : Mesh
    {
        private const string nativeName = "PrimitiveMesh";

        internal PrimitiveMesh() {}

        internal PrimitiveMesh(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_material");

        public void set_material(Material material)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(material));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_material");

        public Material get_material()
        {
            return NativeCalls.godot_icall_0_142(method_bind_1, Object.GetPtr(this));
        }
    }
}
