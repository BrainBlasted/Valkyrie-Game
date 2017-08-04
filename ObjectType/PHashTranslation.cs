using System;

namespace GodotEngine
{
    /// <summary>
    /// Optimized translation. Uses real-time compressed translations, which results in very small dictionaries.
    /// </summary>
    public class PHashTranslation : Translation
    {
        private const string nativeName = "PHashTranslation";

        public PHashTranslation() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PHashTranslation_Ctor(this);
        }

        internal PHashTranslation(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "generate");

        public void generate(Translation from)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(from));
        }
    }
}
