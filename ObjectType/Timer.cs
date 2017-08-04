using System;

namespace GodotEngine
{
    /// <summary>
    /// Timer node. This is a simple node that will emit a timeout callback when the timer runs out. It can optionally be set to loop.
    /// </summary>
    public class Timer : Node
    {
        /// <summary>
        /// Update the timer at fixed intervals (framerate processing).
        /// </summary>
        public const int TIMER_PROCESS_FIXED = 0;
        /// <summary>
        /// Update the timer during the idle time at each frame.
        /// </summary>
        public const int TIMER_PROCESS_IDLE = 1;

        private const string nativeName = "Timer";

        public Timer() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Timer_Ctor(this);
        }

        internal Timer(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_wait_time");

        /// <summary>
        /// Set wait time in seconds. When the time is over, it will emit the timeout signal.
        /// </summary>
        public void set_wait_time(float time_sec)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), time_sec);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_wait_time");

        /// <summary>
        /// Return the wait time in seconds.
        /// </summary>
        public float get_wait_time()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_one_shot");

        /// <summary>
        /// Set as one-shot. If enabled, the timer will stop after timeout, otherwise it will automatically restart.
        /// </summary>
        public void set_one_shot(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_2, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_one_shot");

        /// <summary>
        /// Return true if configured as one-shot.
        /// </summary>
        public bool is_one_shot()
        {
            return NativeCalls.godot_icall_0_3(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_autostart");

        /// <summary>
        /// Set to automatically start when entering the scene.
        /// </summary>
        public void set_autostart(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_4, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_autostart");

        /// <summary>
        /// Return true if set to automatically start when entering the scene.
        /// </summary>
        public bool has_autostart()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "start");

        /// <summary>
        /// Start the timer.
        /// </summary>
        public void start()
        {
            NativeCalls.godot_icall_0_8(method_bind_6, Object.GetPtr(this));
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "stop");

        /// <summary>
        /// Stop (cancel) the timer.
        /// </summary>
        public void stop()
        {
            NativeCalls.godot_icall_0_8(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_paused");

        /// <summary>
        /// Set whether the timer is paused or not. A paused timer will be inactive until it is unpaused again.
        /// </summary>
        public void set_paused(bool paused)
        {
            NativeCalls.godot_icall_1_7(method_bind_8, Object.GetPtr(this), paused);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_paused");

        /// <summary>
        /// Return if the timer is paused or not.
        /// </summary>
        public bool is_paused()
        {
            return NativeCalls.godot_icall_0_3(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_stopped");

        public bool is_stopped()
        {
            return NativeCalls.godot_icall_0_3(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_time_left");

        /// <summary>
        /// Return the time left for timeout in seconds if the timer is active, 0 otherwise.
        /// </summary>
        public float get_time_left()
        {
            return NativeCalls.godot_icall_0_11(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_timer_process_mode");

        /// <summary>
        /// Set the timer's processing mode (fixed or idle, use TIMER_PROCESS_* constants as argument).
        /// </summary>
        public void set_timer_process_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_12, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_timer_process_mode");

        /// <summary>
        /// Return the timer's processing mode.
        /// </summary>
        public int get_timer_process_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_13, Object.GetPtr(this));
        }
    }
}
