using System;

namespace GodotEngine
{
    public class SceneTreeTimer : Reference
    {
        private const string nativeName = "SceneTreeTimer";

        internal SceneTreeTimer() {}

        internal SceneTreeTimer(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_time_left");

        public void set_time_left(float time)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), time);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_time_left");

        public float get_time_left()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }
    }
}
