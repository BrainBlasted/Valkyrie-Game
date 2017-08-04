using System;

namespace GodotEngine
{
    public class ARVRController : Spatial
    {
        private const string nativeName = "ARVRController";

        public ARVRController() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRController_Ctor(this);
        }

        internal ARVRController(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_controller_id");

        public void set_controller_id(int controller_id)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), controller_id);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_controller_id");

        public int get_controller_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_controller_name");

        public string get_controller_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_joystick_id");

        public int get_joystick_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_button_pressed");

        public int is_button_pressed(int button)
        {
            return NativeCalls.godot_icall_1_5(method_bind_4, Object.GetPtr(this), button);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_joystick_axis");

        public float get_joystick_axis(int axis)
        {
            return NativeCalls.godot_icall_1_6(method_bind_5, Object.GetPtr(this), axis);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_is_active");

        public bool get_is_active()
        {
            return NativeCalls.godot_icall_0_3(method_bind_6, Object.GetPtr(this));
        }
    }
}
