using System;

namespace GodotEngine
{
    public class ARVRPositionalTracker : Object
    {
        private const string nativeName = "ARVRPositionalTracker";

        public ARVRPositionalTracker() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRPositionalTracker_Ctor(this);
        }

        internal ARVRPositionalTracker(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_type");

        public int get_type()
        {
            return NativeCalls.godot_icall_0_1(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_name");

        public string get_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_joy_id");

        public int get_joy_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tracks_orientation");

        public bool get_tracks_orientation()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_orientation");

        public Basis get_orientation()
        {
            object ret = NativeCalls.godot_icall_0_12(method_bind_4, Object.GetPtr(this));
            return (Basis)ret;
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tracks_position");

        public bool get_tracks_position()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_position");

        public Vector3 get_position()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_6, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_transform");

        public Transform get_transform(bool adjust_by_reference_frame)
        {
            object ret = NativeCalls.godot_icall_1_13(method_bind_7, Object.GetPtr(this), adjust_by_reference_frame);
            return (Transform)ret;
        }
    }
}
