using System;

namespace GodotEngine
{
    /// <summary>
    /// A weakref can hold a [Reference], without contributing to the reference counter. A weakref can be created from an [Object] using [method @GDScript.weakref]. If this object is not a reference, weakref still works, however, it does not have any effect on the object. Weakrefs are useful in cases where multiple classes have variables that refer to eachother. Without weakrefs, using these classes could lead to memory leaks, since both references keep eachother from being released. Making part of the variables a weakref can prevent this cyclic dependency, and allows the references to be released.
    /// </summary>
    public class WeakRef : Reference
    {
        private const string nativeName = "WeakRef";

        public WeakRef() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WeakRef_Ctor(this);
        }

        internal WeakRef(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ref");

        /// <summary>
        /// Returns the [Object] this weakref is referring to.
        /// </summary>
        public object get_ref()
        {
            return NativeCalls.godot_icall_0_121(method_bind_0, Object.GetPtr(this));
        }
    }
}
