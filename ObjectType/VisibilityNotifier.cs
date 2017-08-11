using System;

namespace GodotEngine
{
    /// <summary>
    /// The VisibilityNotifier is used to notify when its bounding box enters the screen, is visible on the screen, or when it exits the screen.
    /// </summary>
    public class VisibilityNotifier : Spatial
    {
        private const string nativeName = "VisibilityNotifier";

        public VisibilityNotifier() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisibilityNotifier_Ctor(this);
        }

        internal VisibilityNotifier(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_aabb");

        /// <summary>
        /// Set the visibility bounding box of the VisibilityNotifier.
        /// </summary>
        public void set_aabb(Rect3 rect)
        {
            NativeCalls.godot_icall_1_91(method_bind_0, Object.GetPtr(this), ref rect);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_aabb");

        /// <summary>
        /// Return the visibility bounding box of the VisibilityNotifier.
        /// </summary>
        public Rect3 get_aabb()
        {
            object ret = NativeCalls.godot_icall_0_92(method_bind_1, Object.GetPtr(this));
            return (Rect3)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_on_screen");

        /// <summary>
        /// Return true if any part of the bounding box is on the screen.
        /// </summary>
        public bool is_on_screen()
        {
            return NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }
    }
}
