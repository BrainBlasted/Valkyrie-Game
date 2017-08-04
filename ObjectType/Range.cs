using System;

namespace GodotEngine
{
    /// <summary>
    /// Range is a base class for [Control] nodes that change a floating point [i]value[/i] between a [i]minimum[/i] and a [i]maximum[/i], using [i]step[/i] and [i]page[/i], for example a [ScrollBar].
    /// </summary>
    public class Range : Control
    {
        private const string nativeName = "Range";

        public Range() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Range_Ctor(this);
        }

        internal Range(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_value");

        public float get_value()
        {
            return NativeCalls.godot_icall_0_11(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_min");

        /// <summary>
        /// Return the minimum value.
        /// </summary>
        public float get_min()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_max");

        /// <summary>
        /// Return the maximum value.
        /// </summary>
        public float get_max()
        {
            return NativeCalls.godot_icall_0_11(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_step");

        /// <summary>
        /// Return the stepping, if step is 0, stepping is disabled.
        /// </summary>
        public float get_step()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_page");

        /// <summary>
        /// Return the page size, if page is 0, paging is disabled.
        /// </summary>
        public float get_page()
        {
            return NativeCalls.godot_icall_0_11(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_as_ratio");

        /// <summary>
        /// Return value mapped to 0 to 1 range.
        /// </summary>
        public float get_as_ratio()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_value");

        public void set_value(float value)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), value);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_min");

        /// <summary>
        /// Set minimum value, clamped range value to it if it's less.
        /// </summary>
        public void set_min(float minimum)
        {
            NativeCalls.godot_icall_1_10(method_bind_7, Object.GetPtr(this), minimum);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_max");

        public void set_max(float maximum)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), maximum);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_step");

        /// <summary>
        /// Set step value. If step is 0, stepping will be disabled.
        /// </summary>
        public void set_step(float step)
        {
            NativeCalls.godot_icall_1_10(method_bind_9, Object.GetPtr(this), step);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_page");

        /// <summary>
        /// Set page size. Page is mainly used for scrollbars or anything that controls text scrolling.
        /// </summary>
        public void set_page(float pagesize)
        {
            NativeCalls.godot_icall_1_10(method_bind_10, Object.GetPtr(this), pagesize);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_as_ratio");

        /// <summary>
        /// Set value mapped to 0 to 1 (unit) range, it will then be converted to the actual value within min and max.
        /// </summary>
        public void set_as_ratio(float value)
        {
            NativeCalls.godot_icall_1_10(method_bind_11, Object.GetPtr(this), value);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_use_rounded_values");

        public void set_use_rounded_values(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_12, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_using_rounded_values");

        public bool is_using_rounded_values()
        {
            return NativeCalls.godot_icall_0_3(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_exp_ratio");

        public void set_exp_ratio(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_14, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_ratio_exp");

        public bool is_ratio_exp()
        {
            return NativeCalls.godot_icall_0_3(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "share");

        public void share(Node with)
        {
            NativeCalls.godot_icall_1_19(method_bind_16, Object.GetPtr(this), Object.GetPtr(with));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "unshare");

        public void unshare()
        {
            NativeCalls.godot_icall_0_8(method_bind_17, Object.GetPtr(this));
        }
    }
}
