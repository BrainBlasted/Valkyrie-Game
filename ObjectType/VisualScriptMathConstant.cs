using System;

namespace GodotEngine
{
    public class VisualScriptMathConstant : VisualScriptNode
    {
        private const string nativeName = "VisualScriptMathConstant";

        public VisualScriptMathConstant() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptMathConstant_Ctor(this);
        }

        internal VisualScriptMathConstant(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_math_constant");

        public void set_math_constant(int which)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), which);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_math_constant");

        public int get_math_constant()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }
    }
}
