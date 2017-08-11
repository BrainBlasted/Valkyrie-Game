using System;

namespace GodotEngine
{
    public class SpatialVelocityTracker : Reference
    {
        private const string nativeName = "SpatialVelocityTracker";

        public SpatialVelocityTracker() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpatialVelocityTracker_Ctor(this);
        }

        internal SpatialVelocityTracker(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_track_fixed_step");

        public void set_track_fixed_step(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_0, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_tracking_fixed_step");

        public bool is_tracking_fixed_step()
        {
            return NativeCalls.godot_icall_0_3(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "update_position");

        public void update_position(Vector3 position)
        {
            NativeCalls.godot_icall_1_84(method_bind_2, Object.GetPtr(this), ref position);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tracked_linear_velocity");

        public Vector3 get_tracked_linear_velocity()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_3, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "reset");

        public void reset(Vector3 position)
        {
            NativeCalls.godot_icall_1_84(method_bind_4, Object.GetPtr(this), ref position);
        }
    }
}
