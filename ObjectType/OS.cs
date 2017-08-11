using System;
using System.Collections.Generic;

namespace GodotEngine
{
    /// <summary>
    /// Operating System functions. OS Wraps the most common functionality to communicate with the host Operating System, such as: mouse grabbing, mouse cursors, clipboard, video mode, date and time, timers, environment variables, execution of binaries, command line, etc.
    /// </summary>
    public static class OS
    {
        public const int DAY_SUNDAY = 0;
        public const int DAY_MONDAY = 1;
        public const int DAY_TUESDAY = 2;
        public const int DAY_WEDNESDAY = 3;
        public const int DAY_THURSDAY = 4;
        public const int DAY_FRIDAY = 5;
        public const int DAY_SATURDAY = 6;
        public const int MONTH_JANUARY = 1;
        public const int MONTH_FEBRUARY = 2;
        public const int MONTH_MARCH = 3;
        public const int MONTH_APRIL = 4;
        public const int MONTH_MAY = 5;
        public const int MONTH_JUNE = 6;
        public const int MONTH_JULY = 7;
        public const int MONTH_AUGUST = 8;
        public const int MONTH_SEPTEMBER = 9;
        public const int MONTH_OCTOBER = 10;
        public const int MONTH_NOVEMBER = 11;
        public const int MONTH_DECEMBER = 12;
        public const int SCREEN_ORIENTATION_LANDSCAPE = 0;
        public const int SCREEN_ORIENTATION_PORTRAIT = 1;
        public const int SCREEN_ORIENTATION_REVERSE_LANDSCAPE = 2;
        public const int SCREEN_ORIENTATION_REVERSE_PORTRAIT = 3;
        public const int SCREEN_ORIENTATION_SENSOR_LANDSCAPE = 4;
        public const int SCREEN_ORIENTATION_SENSOR_PORTRAIT = 5;
        public const int SCREEN_ORIENTATION_SENSOR = 6;
        public const int SYSTEM_DIR_DESKTOP = 0;
        public const int SYSTEM_DIR_DCIM = 1;
        public const int SYSTEM_DIR_DOCUMENTS = 2;
        public const int SYSTEM_DIR_DOWNLOADS = 3;
        public const int SYSTEM_DIR_MOVIES = 4;
        public const int SYSTEM_DIR_MUSIC = 5;
        public const int SYSTEM_DIR_PICTURES = 6;
        public const int SYSTEM_DIR_RINGTONES = 7;
        public const int POWERSTATE_UNKNOWN = 0;
        public const int POWERSTATE_ON_BATTERY = 1;
        public const int POWERSTATE_NO_BATTERY = 2;
        public const int POWERSTATE_CHARGING = 3;
        public const int POWERSTATE_CHARGED = 4;

        private const string nativeName = "_OS";
        internal static IntPtr ptr = NativeCalls.godot_icall__OS_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_clipboard");

        /// <summary>
        /// Set clipboard to the OS.
        /// </summary>
        public static void set_clipboard(string clipboard)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, ptr, clipboard);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_clipboard");

        /// <summary>
        /// Get clipboard from the host OS.
        /// </summary>
        public static string get_clipboard()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, ptr);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_screen_count");

        /// <summary>
        /// Returns the number of displays attached to the host machine
        /// </summary>
        public static int get_screen_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_2, ptr);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_current_screen");

        /// <summary>
        /// Returns the current screen index (0 padded).
        /// </summary>
        public static int get_current_screen()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, ptr);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_current_screen");

        public static void set_current_screen(int screen)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, ptr, screen);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_screen_position");

        public static Vector2 get_screen_position(int screen = 0)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_5, ptr, screen);
            return (Vector2)ret;
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_screen_size");

        /// <summary>
        /// Returns the dimensions in pixels of the specified screen.
        /// </summary>
        public static Vector2 get_screen_size(int screen = 0)
        {
            object ret = NativeCalls.godot_icall_1_178(method_bind_6, ptr, screen);
            return (Vector2)ret;
        }

        private static IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_screen_dpi");

        /// <summary>
        /// Returns the dots per inch density of the specified screen.
        /// On Android Devices, the actual screen densities are grouped into six generalized densities:
        /// ldpi    - 120 dpi
        /// mdpi    - 160 dpi
        /// hdpi    - 240 dpi
        /// xhdpi   - 320 dpi
        /// xxhdpi  - 480 dpi
        /// xxxhdpi - 640 dpi
        /// </summary>
        public static int get_screen_dpi(int screen = 0)
        {
            return NativeCalls.godot_icall_1_5(method_bind_7, ptr, screen);
        }

        private static IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_window_position");

        /// <summary>
        /// Returns the window position relative to the screen, the origin is the top left corner, +Y axis goes to the bottom and +X axis goes to the right.
        /// </summary>
        public static Vector2 get_window_position()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_8, ptr);
            return (Vector2)ret;
        }

        private static IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_window_position");

        /// <summary>
        /// Sets the position of the window to the specified position (this function could be restricted by the window manager, meaning that there could be some unreachable areas of the screen).
        /// </summary>
        public static void set_window_position(Vector2 position)
        {
            NativeCalls.godot_icall_1_37(method_bind_9, ptr, ref position);
        }

        private static IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_window_size");

        /// <summary>
        /// Returns the size of the window (without counting window manager decorations).
        /// </summary>
        public static Vector2 get_window_size()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_10, ptr);
            return (Vector2)ret;
        }

        private static IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_window_size");

        /// <summary>
        /// Sets the window size to the specified size.
        /// </summary>
        public static void set_window_size(Vector2 size)
        {
            NativeCalls.godot_icall_1_37(method_bind_11, ptr, ref size);
        }

        private static IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_window_fullscreen");

        /// <summary>
        /// Sets window fullscreen mode to the [i]enabled[/i] argument, [i]enabled[/i] is a toggle for the fullscreen mode, calling the function with [i]enabled[/i] true when the screen is not on fullscreen mode will cause the screen to go to fullscreen mode, calling the function with [i]enabled[/i] false when the screen is in fullscreen mode will cause the window to exit the fullscreen mode.
        /// </summary>
        public static void set_window_fullscreen(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_12, ptr, enabled);
        }

        private static IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_window_fullscreen");

        /// <summary>
        /// Returns whether the window is in fullscreen mode or not.
        /// </summary>
        public static bool is_window_fullscreen()
        {
            return NativeCalls.godot_icall_0_3(method_bind_13, ptr);
        }

        private static IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_window_resizable");

        /// <summary>
        /// Set the window resizable state, if the window is not resizable it will preserve the dimensions specified in the project settings.
        /// </summary>
        public static void set_window_resizable(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_14, ptr, enabled);
        }

        private static IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_window_resizable");

        /// <summary>
        /// Returns whether the window is resizable or not.
        /// </summary>
        public static bool is_window_resizable()
        {
            return NativeCalls.godot_icall_0_3(method_bind_15, ptr);
        }

        private static IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_window_minimized");

        /// <summary>
        /// Set whether the window is minimized.
        /// </summary>
        public static void set_window_minimized(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_16, ptr, enabled);
        }

        private static IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_window_minimized");

        /// <summary>
        /// Return true if the window is minimized.
        /// </summary>
        public static bool is_window_minimized()
        {
            return NativeCalls.godot_icall_0_3(method_bind_17, ptr);
        }

        private static IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_window_maximized");

        /// <summary>
        /// Set the window size to maximized.
        /// </summary>
        public static void set_window_maximized(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_18, ptr, enabled);
        }

        private static IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_window_maximized");

        /// <summary>
        /// Return true if the window is maximized.
        /// </summary>
        public static bool is_window_maximized()
        {
            return NativeCalls.godot_icall_0_3(method_bind_19, ptr);
        }

        private static IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "request_attention");

        /// <summary>
        /// Request the user attention to the window. It'll flash the taskbar button on Windows or bounce the dock icon on OSX.
        /// </summary>
        public static void request_attention()
        {
            NativeCalls.godot_icall_0_8(method_bind_20, ptr);
        }

        private static IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_borderless_window");

        public static void set_borderless_window(bool borderless)
        {
            NativeCalls.godot_icall_1_7(method_bind_21, ptr, borderless);
        }

        private static IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_borderless_window");

        /// <summary>
        /// Returns true if the current window is borderless.
        /// </summary>
        public static bool get_borderless_window()
        {
            return NativeCalls.godot_icall_0_3(method_bind_22, ptr);
        }

        private static IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ime_position");

        public static void set_ime_position(Vector2 position)
        {
            NativeCalls.godot_icall_1_37(method_bind_23, ptr, ref position);
        }

        private static IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_screen_orientation");

        /// <summary>
        /// Sets the current screen orientation, the argument value must be one of the SCREEN_ORIENTATION constants in this class.
        /// </summary>
        public static void set_screen_orientation(int orientation)
        {
            NativeCalls.godot_icall_1_0(method_bind_24, ptr, orientation);
        }

        private static IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_screen_orientation");

        /// <summary>
        /// Returns the current screen orientation, the return value will be one of the SCREEN_ORIENTATION constants in this class.
        /// </summary>
        public static int get_screen_orientation()
        {
            return NativeCalls.godot_icall_0_1(method_bind_25, ptr);
        }

        private static IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_keep_screen_on");

        /// <summary>
        /// Set keep screen on if true, or goes to sleep by device setting if false. (for Android/iOS)
        /// </summary>
        public static void set_keep_screen_on(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_26, ptr, enabled);
        }

        private static IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_keep_screen_on");

        /// <summary>
        /// Returns whether the screen is being kept on or not.
        /// </summary>
        public static bool is_keep_screen_on()
        {
            return NativeCalls.godot_icall_0_3(method_bind_27, ptr);
        }

        private static IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_touchscreen_ui_hint");

        public static bool has_touchscreen_ui_hint()
        {
            return NativeCalls.godot_icall_0_3(method_bind_28, ptr);
        }

        private static IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_window_title");

        /// <summary>
        /// Sets the window title to the specified string.
        /// </summary>
        public static void set_window_title(string title)
        {
            NativeCalls.godot_icall_1_35(method_bind_29, ptr, title);
        }

        private static IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_low_processor_usage_mode");

        /// <summary>
        /// Set to true to enable the low cpu usage mode. In this mode, the screen only redraws when there are changes, and a considerable sleep time is inserted between frames. This way, editors using the engine UI only use very little cpu.
        /// </summary>
        public static void set_low_processor_usage_mode(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_30, ptr, enable);
        }

        private static IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_in_low_processor_usage_mode");

        /// <summary>
        /// Return true if low cpu usage mode is enabled.
        /// </summary>
        public static bool is_in_low_processor_usage_mode()
        {
            return NativeCalls.godot_icall_0_3(method_bind_31, ptr);
        }

        private static IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_processor_count");

        /// <summary>
        /// Returns the number of cores available in the host machine.
        /// </summary>
        public static int get_processor_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_32, ptr);
        }

        private static IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_executable_path");

        /// <summary>
        /// Return the path to the current engine executable.
        /// </summary>
        public static string get_executable_path()
        {
            return NativeCalls.godot_icall_0_2(method_bind_33, ptr);
        }

        private static IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "execute");

        /// <summary>
        /// Execute the binary file in given path, optionally blocking until it returns. A process ID is returned.
        /// <param name="output">If the param is null, then the default value is new object[] {}</param>
        /// </summary>
        public static int execute(string path, string[] arguments, bool blocking, object[] output = null)
        {
            object[] output_in = output != null ? output : new object[] {};
            return NativeCalls.godot_icall_4_547(method_bind_34, ptr, path, arguments, blocking, output_in);
        }

        private static IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "kill");

        /// <summary>
        /// Kill a process ID (this method can be used to kill processes that were not spawned by the game).
        /// </summary>
        public static int kill(int pid)
        {
            return NativeCalls.godot_icall_1_5(method_bind_35, ptr, pid);
        }

        private static IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shell_open");

        public static int shell_open(string uri)
        {
            return NativeCalls.godot_icall_1_71(method_bind_36, ptr, uri);
        }

        private static IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_process_id");

        /// <summary>
        /// Returns the game process ID
        /// </summary>
        public static int get_process_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_37, ptr);
        }

        private static IntPtr method_bind_38 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_environment");

        /// <summary>
        /// Return an environment variable.
        /// </summary>
        public static string get_environment(string environment)
        {
            return NativeCalls.godot_icall_1_60(method_bind_38, ptr, environment);
        }

        private static IntPtr method_bind_39 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_environment");

        /// <summary>
        /// Return true if an environment variable exists.
        /// </summary>
        public static bool has_environment(string environment)
        {
            return NativeCalls.godot_icall_1_57(method_bind_39, ptr, environment);
        }

        private static IntPtr method_bind_40 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_name");

        /// <summary>
        /// Return the name of the host OS. Possible values are: "Android", "Haiku", "iOS", "HTML5", "OSX", "Server", "Windows", "UWP", "X11".
        /// </summary>
        public static string get_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_40, ptr);
        }

        private static IntPtr method_bind_41 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cmdline_args");

        /// <summary>
        /// Return the commandline passed to the engine.
        /// </summary>
        public static string[] get_cmdline_args()
        {
            return NativeCalls.godot_icall_0_59(method_bind_41, ptr);
        }

        private static IntPtr method_bind_42 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_datetime");

        /// <summary>
        /// Returns current datetime as a dictionary of keys: year, month, day, weekday, dst (daylight savings time), hour, minute, second.
        /// </summary>
        public static Dictionary<object, object> get_datetime(bool utc = false)
        {
            return NativeCalls.godot_icall_1_256(method_bind_42, ptr, utc);
        }

        private static IntPtr method_bind_43 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_date");

        /// <summary>
        /// Returns current date as a dictionary of keys: year, month, day, weekday, dst (daylight savings time).
        /// </summary>
        public static Dictionary<object, object> get_date(bool utc = false)
        {
            return NativeCalls.godot_icall_1_256(method_bind_43, ptr, utc);
        }

        private static IntPtr method_bind_44 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_time");

        /// <summary>
        /// Returns current time as a dictionary of keys: hour, minute, second
        /// </summary>
        public static Dictionary<object, object> get_time(bool utc = false)
        {
            return NativeCalls.godot_icall_1_256(method_bind_44, ptr, utc);
        }

        private static IntPtr method_bind_45 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_time_zone_info");

        public static Dictionary<object, object> get_time_zone_info()
        {
            return NativeCalls.godot_icall_0_233(method_bind_45, ptr);
        }

        private static IntPtr method_bind_46 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_unix_time");

        /// <summary>
        /// Return	the current unix timestamp.
        /// </summary>
        public static int get_unix_time()
        {
            return NativeCalls.godot_icall_0_1(method_bind_46, ptr);
        }

        private static IntPtr method_bind_47 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_datetime_from_unix_time");

        /// <summary>
        /// Get a dictionary of time values when given epoch time.
        /// Dictionary Time values will be a union of values from [method get_time] and [method get_date] dictionaries (with the exception of dst = day light standard time, as it cannot be determined from epoch).
        /// </summary>
        public static Dictionary<object, object> get_datetime_from_unix_time(int unix_time_val)
        {
            return NativeCalls.godot_icall_1_484(method_bind_47, ptr, unix_time_val);
        }

        private static IntPtr method_bind_48 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_unix_time_from_datetime");

        /// <summary>
        /// Get an epoch time value from a dictionary of time values.
        /// [code]datetime[/code] must be populated with the following keys: year, month, day, hour, minute, second.
        /// You can pass the output from [method get_datetime_from_unix_time] directly into this function. Daylight savings time (dst), if present, is ignored.
        /// </summary>
        public static int get_unix_time_from_datetime(Dictionary<object, object> datetime)
        {
            return NativeCalls.godot_icall_1_548(method_bind_48, ptr, datetime);
        }

        private static IntPtr method_bind_49 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_system_time_secs");

        public static int get_system_time_secs()
        {
            return NativeCalls.godot_icall_0_1(method_bind_49, ptr);
        }

        private static IntPtr method_bind_50 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_icon");

        public static void set_icon(Image icon)
        {
            NativeCalls.godot_icall_1_19(method_bind_50, ptr, Object.GetPtr(icon));
        }

        private static IntPtr method_bind_51 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_exit_code");

        public static int get_exit_code()
        {
            return NativeCalls.godot_icall_0_1(method_bind_51, ptr);
        }

        private static IntPtr method_bind_52 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_exit_code");

        public static void set_exit_code(int code)
        {
            NativeCalls.godot_icall_1_0(method_bind_52, ptr, code);
        }

        private static IntPtr method_bind_53 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "delay_usec");

        /// <summary>
        /// Delay executing of the current thread by given microseconds.
        /// </summary>
        public static void delay_usec(int usec)
        {
            NativeCalls.godot_icall_1_0(method_bind_53, ptr, usec);
        }

        private static IntPtr method_bind_54 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "delay_msec");

        /// <summary>
        /// Delay executing of the current thread by given milliseconds.
        /// </summary>
        public static void delay_msec(int msec)
        {
            NativeCalls.godot_icall_1_0(method_bind_54, ptr, msec);
        }

        private static IntPtr method_bind_55 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ticks_msec");

        /// <summary>
        /// Return the amount of time passed in milliseconds since the engine started.
        /// </summary>
        public static int get_ticks_msec()
        {
            return NativeCalls.godot_icall_0_1(method_bind_55, ptr);
        }

        private static IntPtr method_bind_56 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_splash_tick_msec");

        public static int get_splash_tick_msec()
        {
            return NativeCalls.godot_icall_0_1(method_bind_56, ptr);
        }

        private static IntPtr method_bind_57 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_locale");

        /// <summary>
        /// Return the host OS locale.
        /// </summary>
        public static string get_locale()
        {
            return NativeCalls.godot_icall_0_2(method_bind_57, ptr);
        }

        private static IntPtr method_bind_58 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_latin_keyboard_variant");

        /// <summary>
        /// Returns the current latin keyboard variant as a String.
        /// Possible return values are: "QWERTY", "AZERTY", "QZERTY", "DVORAK", "NEO" or "ERROR"
        /// </summary>
        public static string get_latin_keyboard_variant()
        {
            return NativeCalls.godot_icall_0_2(method_bind_58, ptr);
        }

        private static IntPtr method_bind_59 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_model_name");

        /// <summary>
        /// Returns the model name of the current device.
        /// </summary>
        public static string get_model_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_59, ptr);
        }

        private static IntPtr method_bind_60 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "can_draw");

        /// <summary>
        /// Return true if the host OS allows drawing.
        /// </summary>
        public static bool can_draw()
        {
            return NativeCalls.godot_icall_0_3(method_bind_60, ptr);
        }

        private static IntPtr method_bind_61 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_stdout_verbose");

        /// <summary>
        /// Return true if the engine was executed with -v (verbose stdout).
        /// </summary>
        public static bool is_stdout_verbose()
        {
            return NativeCalls.godot_icall_0_3(method_bind_61, ptr);
        }

        private static IntPtr method_bind_62 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "can_use_threads");

        /// <summary>
        /// Returns if the current host platform is using multiple threads.
        /// </summary>
        public static bool can_use_threads()
        {
            return NativeCalls.godot_icall_0_3(method_bind_62, ptr);
        }

        private static IntPtr method_bind_63 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_debug_build");

        public static bool is_debug_build()
        {
            return NativeCalls.godot_icall_0_3(method_bind_63, ptr);
        }

        private static IntPtr method_bind_64 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "dump_memory_to_file");

        /// <summary>
        /// Dumps the memory allocation ringlist to a file (only works in debug).
        /// Entry format per line: "Address - Size - Description"
        /// </summary>
        public static void dump_memory_to_file(string file)
        {
            NativeCalls.godot_icall_1_35(method_bind_64, ptr, file);
        }

        private static IntPtr method_bind_65 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "dump_resources_to_file");

        /// <summary>
        /// Dumps all used resources to file (only works in debug).
        /// Entry format per line: "Resource Type : Resource Location"
        /// At the end of the file is a statistic of all used Resource Types.
        /// </summary>
        public static void dump_resources_to_file(string file)
        {
            NativeCalls.godot_icall_1_35(method_bind_65, ptr, file);
        }

        private static IntPtr method_bind_66 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_virtual_keyboard");

        /// <summary>
        /// Returns true if the platform has a virtual keyboard, false otherwise.
        /// </summary>
        public static bool has_virtual_keyboard()
        {
            return NativeCalls.godot_icall_0_3(method_bind_66, ptr);
        }

        private static IntPtr method_bind_67 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "show_virtual_keyboard");

        /// <summary>
        /// Shows the virtual keyboard if the platform has one. The [i]existing_text[/i] parameter is useful for implementing your own LineEdit, as it tells the virtual keyboard what text has already been typed (the virtual keyboard uses it for auto-correct and predictions).
        /// </summary>
        public static void show_virtual_keyboard(string existing_text = "")
        {
            NativeCalls.godot_icall_1_35(method_bind_67, ptr, existing_text);
        }

        private static IntPtr method_bind_68 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "hide_virtual_keyboard");

        /// <summary>
        /// Hides the virtual keyboard if it is shown, does nothing otherwise.
        /// </summary>
        public static void hide_virtual_keyboard()
        {
            NativeCalls.godot_icall_0_8(method_bind_68, ptr);
        }

        private static IntPtr method_bind_69 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "print_resources_in_use");

        public static void print_resources_in_use(bool @short = false)
        {
            NativeCalls.godot_icall_1_7(method_bind_69, ptr, @short);
        }

        private static IntPtr method_bind_70 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "print_all_resources");

        public static void print_all_resources(string tofile = "")
        {
            NativeCalls.godot_icall_1_35(method_bind_70, ptr, tofile);
        }

        private static IntPtr method_bind_71 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_static_memory_usage");

        public static int get_static_memory_usage()
        {
            return NativeCalls.godot_icall_0_1(method_bind_71, ptr);
        }

        private static IntPtr method_bind_72 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_static_memory_peak_usage");

        /// <summary>
        /// Return the max amount of static memory used (only works in debug).
        /// </summary>
        public static int get_static_memory_peak_usage()
        {
            return NativeCalls.godot_icall_0_1(method_bind_72, ptr);
        }

        private static IntPtr method_bind_73 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dynamic_memory_usage");

        /// <summary>
        /// Return the total amount of dynamic memory used (only works in debug).
        /// </summary>
        public static int get_dynamic_memory_usage()
        {
            return NativeCalls.godot_icall_0_1(method_bind_73, ptr);
        }

        private static IntPtr method_bind_74 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_data_dir");

        /// <summary>
        /// Return the absolute directory path of user data path([user://]).
        /// </summary>
        public static string get_data_dir()
        {
            return NativeCalls.godot_icall_0_2(method_bind_74, ptr);
        }

        private static IntPtr method_bind_75 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_system_dir");

        public static string get_system_dir(int dir)
        {
            return NativeCalls.godot_icall_1_87(method_bind_75, ptr, dir);
        }

        private static IntPtr method_bind_76 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_unique_id");

        public static string get_unique_id()
        {
            return NativeCalls.godot_icall_0_2(method_bind_76, ptr);
        }

        private static IntPtr method_bind_77 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_ok_left_and_cancel_right");

        public static bool is_ok_left_and_cancel_right()
        {
            return NativeCalls.godot_icall_0_3(method_bind_77, ptr);
        }

        private static IntPtr method_bind_78 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "print_all_textures_by_size");

        public static void print_all_textures_by_size()
        {
            NativeCalls.godot_icall_0_8(method_bind_78, ptr);
        }

        private static IntPtr method_bind_79 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "print_resources_by_type");

        public static void print_resources_by_type(string[] types)
        {
            NativeCalls.godot_icall_1_197(method_bind_79, ptr, types);
        }

        private static IntPtr method_bind_80 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "native_video_play");

        public static int native_video_play(string path, float volume, string audio_track, string subtitle_track)
        {
            return NativeCalls.godot_icall_4_549(method_bind_80, ptr, path, volume, audio_track, subtitle_track);
        }

        private static IntPtr method_bind_81 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "native_video_is_playing");

        public static bool native_video_is_playing()
        {
            return NativeCalls.godot_icall_0_3(method_bind_81, ptr);
        }

        private static IntPtr method_bind_82 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "native_video_stop");

        public static void native_video_stop()
        {
            NativeCalls.godot_icall_0_8(method_bind_82, ptr);
        }

        private static IntPtr method_bind_83 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "native_video_pause");

        public static void native_video_pause()
        {
            NativeCalls.godot_icall_0_8(method_bind_83, ptr);
        }

        private static IntPtr method_bind_84 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "native_video_unpause");

        public static void native_video_unpause()
        {
            NativeCalls.godot_icall_0_8(method_bind_84, ptr);
        }

        private static IntPtr method_bind_85 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_scancode_string");

        /// <summary>
        /// Returns the given scancode as a string (e.g. Return values: "Escape", "Shift+Escape").
        /// </summary>
        public static string get_scancode_string(int code)
        {
            return NativeCalls.godot_icall_1_87(method_bind_85, ptr, code);
        }

        private static IntPtr method_bind_86 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_scancode_unicode");

        public static bool is_scancode_unicode(int code)
        {
            return NativeCalls.godot_icall_1_22(method_bind_86, ptr, code);
        }

        private static IntPtr method_bind_87 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "find_scancode_from_string");

        /// <summary>
        /// Returns the scancode of the given string (e.g. "Escape")
        /// </summary>
        public static int find_scancode_from_string(string @string)
        {
            return NativeCalls.godot_icall_1_71(method_bind_87, ptr, @string);
        }

        private static IntPtr method_bind_88 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_use_file_access_save_and_swap");

        public static void set_use_file_access_save_and_swap(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_88, ptr, enabled);
        }

        private static IntPtr method_bind_89 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "alert");

        /// <summary>
        /// Displays a modal dialog box utilizing the host OS.
        /// </summary>
        public static void alert(string text, string title = "Alert!")
        {
            NativeCalls.godot_icall_2_56(method_bind_89, ptr, text, title);
        }

        private static IntPtr method_bind_90 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_thread_name");

        public static int set_thread_name(string name)
        {
            return NativeCalls.godot_icall_1_71(method_bind_90, ptr, name);
        }

        private static IntPtr method_bind_91 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_use_vsync");

        public static void set_use_vsync(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_91, ptr, enable);
        }

        private static IntPtr method_bind_92 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_vsync_enabled");

        public static bool is_vsync_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_92, ptr);
        }

        private static IntPtr method_bind_93 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_power_state");

        public static int get_power_state()
        {
            return NativeCalls.godot_icall_0_1(method_bind_93, ptr);
        }

        private static IntPtr method_bind_94 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_power_seconds_left");

        public static int get_power_seconds_left()
        {
            return NativeCalls.godot_icall_0_1(method_bind_94, ptr);
        }

        private static IntPtr method_bind_95 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_power_percent_left");

        public static int get_power_percent_left()
        {
            return NativeCalls.godot_icall_0_1(method_bind_95, ptr);
        }
    }
}
