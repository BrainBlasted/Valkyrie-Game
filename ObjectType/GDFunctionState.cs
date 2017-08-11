using System;

namespace GodotEngine
{
    /// <summary>
    /// Calling [method @GDScript.yield] within a function will cause that function to yield and return its current state as an object of this type. The yielded function call can then be resumed later by calling [method resume] on this state object.
    /// </summary>
    public class GDFunctionState : Reference
    {
        private const string nativeName = "GDFunctionState";

        internal GDFunctionState() {}

        internal GDFunctionState(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "resume");

        /// <summary>
        /// Resume execution of the yielded function call.
        /// If handed an argument, return the argument from the [method @GDScript.yield] call in the yielded function call. You can pass e.g. an [Array] to hand multiple arguments.
        /// This function returns what the resumed function call returns, possibly another function state if yielded again.
        /// </summary>
        public object resume(object arg = null)
        {
            return NativeCalls.godot_icall_1_201(method_bind_0, Object.GetPtr(this), arg);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_valid");

        /// <summary>
        /// Check whether the function call may be resumed. This is not the case if the function state was already resumed.
        /// If [code]extended_check[/code] is enabled, it also checks if the associated script and object still exist. The extended check is done in debug mode as part of [method GDFunctionState.resume], but you can use this if you know you may be trying to resume without knowing for sure the object and/or script have survived up to that point.
        /// </summary>
        public bool is_valid(bool extended_check = false)
        {
            return NativeCalls.godot_icall_1_202(method_bind_1, Object.GetPtr(this), extended_check);
        }
    }
}
