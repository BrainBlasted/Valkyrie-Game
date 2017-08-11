using System;

namespace GodotEngine
{
    /// <summary>
    /// Material is a base [Resource] used for coloring and shading geometry. All materials inherit from it and almost all [VisualInstance] derived nodes carry a Material. A few flags and parameters are shared between all material types and are configured here.
    /// </summary>
    public class Material : Resource
    {
        private const string nativeName = "Material";

        internal Material() {}

        internal Material(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_next_pass");

        public void set_next_pass(Material next_pass)
        {
            NativeCalls.godot_icall_1_19(method_bind_0, Object.GetPtr(this), Object.GetPtr(next_pass));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_next_pass");

        public Material get_next_pass()
        {
            return NativeCalls.godot_icall_0_143(method_bind_1, Object.GetPtr(this));
        }
    }
}
