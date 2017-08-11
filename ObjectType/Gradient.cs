using System;

namespace GodotEngine
{
    /// <summary>
    /// Given a set of colors, this node will interpolate them in order, meaning, that if you have color 1, color 2 and color3, the ramp will interpolate (generate the colors between two colors) from color 1 to color 2 and from color 2 to color 3. Initially the ramp will have 2 colors (black and white), one (black) at ramp lower offset offset 0 and the other (white) at the ramp higher offset 1.
    /// </summary>
    public class Gradient : Resource
    {
        private const string nativeName = "Gradient";

        public Gradient() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Gradient_Ctor(this);
        }

        internal Gradient(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_point");

        /// <summary>
        /// Adds the specified color to the end of the ramp, with the specified offset
        /// </summary>
        public void add_point(float offset, Color color)
        {
            NativeCalls.godot_icall_2_210(method_bind_0, Object.GetPtr(this), offset, ref color);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_point");

        /// <summary>
        /// Removes the color at the index [i]offset[/i]
        /// </summary>
        public void remove_point(int offset)
        {
            NativeCalls.godot_icall_1_0(method_bind_1, Object.GetPtr(this), offset);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_offset");

        /// <summary>
        /// Sets the offset for the ramp color at index [i]point[/i]
        /// </summary>
        public void set_offset(int point, float offset)
        {
            NativeCalls.godot_icall_2_45(method_bind_2, Object.GetPtr(this), point, offset);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_offset");

        /// <summary>
        /// Returns the offset of the ramp color at index [i]point[/i]
        /// </summary>
        public float get_offset(int point)
        {
            return NativeCalls.godot_icall_1_6(method_bind_3, Object.GetPtr(this), point);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_color");

        /// <summary>
        /// Sets the color of the ramp color at index [i]point[/i]
        /// </summary>
        public void set_color(int point, Color color)
        {
            NativeCalls.godot_icall_2_211(method_bind_4, Object.GetPtr(this), point, ref color);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_color");

        /// <summary>
        /// Returns the color of the ramp color at index [i]point[/i]
        /// </summary>
        public Color get_color(int point)
        {
            object ret = NativeCalls.godot_icall_1_212(method_bind_5, Object.GetPtr(this), point);
            return (Color)ret;
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "interpolate");

        /// <summary>
        /// Returns the interpolated color specified by [i]offset[/i]
        /// </summary>
        public Color interpolate(float offset)
        {
            object ret = NativeCalls.godot_icall_1_213(method_bind_6, Object.GetPtr(this), offset);
            return (Color)ret;
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_count");

        /// <summary>
        /// Returns the number of colors in the ramp
        /// </summary>
        public int get_point_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_offsets");

        /// <summary>
        /// Sets the offset for the specified amount of elements. Calling this function with a different number of elements than previously defined causes the ramp to resize its colors and offsets array to accommodate the new elements, all new colors will be black by default.
        /// </summary>
        public void set_offsets(float[] offsets)
        {
            NativeCalls.godot_icall_1_214(method_bind_8, Object.GetPtr(this), offsets);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_offsets");

        /// <summary>
        /// Returns the offsets for the colors in this ramp
        /// </summary>
        public float[] get_offsets()
        {
            return NativeCalls.godot_icall_0_191(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_colors");

        /// <summary>
        /// Sets the colors for the specified amount of elements. Calling this function with a different number of elements than previously defined causes the ramp to resize its colors and offsets array to accommodate the new elements.
        /// </summary>
        public void set_colors(Color[] colors)
        {
            NativeCalls.godot_icall_1_215(method_bind_10, Object.GetPtr(this), colors);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_colors");

        /// <summary>
        /// Returns the colors in the ramp
        /// </summary>
        public Color[] get_colors()
        {
            return NativeCalls.godot_icall_0_216(method_bind_11, Object.GetPtr(this));
        }
    }
}
