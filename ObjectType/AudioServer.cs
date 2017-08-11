using System;

namespace GodotEngine
{
    /// <summary>
    /// AudioServer is a low level server interface for audio access. It is in charge of creating sample data (playable audio) as well as its playback via a voice interface.
    /// </summary>
    public static class AudioServer
    {
        private const string nativeName = "AudioServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_AudioServer_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_count");

        public static void set_bus_count(int amount)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, ptr, amount);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_count");

        public static int get_bus_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, ptr);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_bus");

        public static void remove_bus(int index)
        {
            NativeCalls.godot_icall_1_0(method_bind_2, ptr, index);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_bus");

        public static void add_bus(int at_pos = -1)
        {
            NativeCalls.godot_icall_1_0(method_bind_3, ptr, at_pos);
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "move_bus");

        public static void move_bus(int index, int to_index)
        {
            NativeCalls.godot_icall_2_24(method_bind_4, ptr, index, to_index);
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_name");

        public static void set_bus_name(int bus_idx, string name)
        {
            NativeCalls.godot_icall_2_69(method_bind_5, ptr, bus_idx, name);
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_name");

        public static string get_bus_name(int bus_idx)
        {
            return NativeCalls.godot_icall_1_87(method_bind_6, ptr, bus_idx);
        }

        private static IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_index");

        public static int get_bus_index(string bus_name)
        {
            return NativeCalls.godot_icall_1_71(method_bind_7, ptr, bus_name);
        }

        private static IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_volume_db");

        public static void set_bus_volume_db(int bus_idx, float volume_db)
        {
            NativeCalls.godot_icall_2_45(method_bind_8, ptr, bus_idx, volume_db);
        }

        private static IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_volume_db");

        public static float get_bus_volume_db(int bus_idx)
        {
            return NativeCalls.godot_icall_1_6(method_bind_9, ptr, bus_idx);
        }

        private static IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_send");

        public static void set_bus_send(int bus_idx, string send)
        {
            NativeCalls.godot_icall_2_69(method_bind_10, ptr, bus_idx, send);
        }

        private static IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_send");

        public static string get_bus_send(int bus_idx)
        {
            return NativeCalls.godot_icall_1_87(method_bind_11, ptr, bus_idx);
        }

        private static IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_solo");

        public static void set_bus_solo(int bus_idx, bool enable)
        {
            NativeCalls.godot_icall_2_42(method_bind_12, ptr, bus_idx, enable);
        }

        private static IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_bus_solo");

        public static bool is_bus_solo(int bus_idx)
        {
            return NativeCalls.godot_icall_1_22(method_bind_13, ptr, bus_idx);
        }

        private static IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_mute");

        public static void set_bus_mute(int bus_idx, bool enable)
        {
            NativeCalls.godot_icall_2_42(method_bind_14, ptr, bus_idx, enable);
        }

        private static IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_bus_mute");

        public static bool is_bus_mute(int bus_idx)
        {
            return NativeCalls.godot_icall_1_22(method_bind_15, ptr, bus_idx);
        }

        private static IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_bypass_effects");

        public static void set_bus_bypass_effects(int bus_idx, bool enable)
        {
            NativeCalls.godot_icall_2_42(method_bind_16, ptr, bus_idx, enable);
        }

        private static IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_bus_bypassing_effects");

        public static bool is_bus_bypassing_effects(int bus_idx)
        {
            return NativeCalls.godot_icall_1_22(method_bind_17, ptr, bus_idx);
        }

        private static IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_bus_effect");

        public static void add_bus_effect(int bus_idx, AudioEffect effect, int at_pos = -1)
        {
            NativeCalls.godot_icall_3_96(method_bind_18, ptr, bus_idx, Object.GetPtr(effect), at_pos);
        }

        private static IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_bus_effect");

        public static void remove_bus_effect(int bus_idx, int effect_idx)
        {
            NativeCalls.godot_icall_2_24(method_bind_19, ptr, bus_idx, effect_idx);
        }

        private static IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_effect_count");

        public static int get_bus_effect_count(int bus_idx)
        {
            return NativeCalls.godot_icall_1_5(method_bind_20, ptr, bus_idx);
        }

        private static IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_effect");

        public static AudioEffect get_bus_effect(int bus_idx, int effect_idx)
        {
            return NativeCalls.godot_icall_2_97(method_bind_21, ptr, bus_idx, effect_idx);
        }

        private static IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "swap_bus_effects");

        public static void swap_bus_effects(int bus_idx, int effect_idx, int by_effect_idx)
        {
            NativeCalls.godot_icall_3_98(method_bind_22, ptr, bus_idx, effect_idx, by_effect_idx);
        }

        private static IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_effect_enabled");

        public static void set_bus_effect_enabled(int bus_idx, int effect_idx, bool enabled)
        {
            NativeCalls.godot_icall_3_23(method_bind_23, ptr, bus_idx, effect_idx, enabled);
        }

        private static IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_bus_effect_enabled");

        public static bool is_bus_effect_enabled(int bus_idx, int effect_idx)
        {
            return NativeCalls.godot_icall_2_25(method_bind_24, ptr, bus_idx, effect_idx);
        }

        private static IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_peak_volume_left_db");

        public static float get_bus_peak_volume_left_db(int bus_idx, int channel)
        {
            return NativeCalls.godot_icall_2_48(method_bind_25, ptr, bus_idx, channel);
        }

        private static IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus_peak_volume_right_db");

        public static float get_bus_peak_volume_right_db(int bus_idx, int channel)
        {
            return NativeCalls.godot_icall_2_48(method_bind_26, ptr, bus_idx, channel);
        }

        private static IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "lock");

        public static void @lock()
        {
            NativeCalls.godot_icall_0_8(method_bind_27, ptr);
        }

        private static IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "unlock");

        public static void unlock()
        {
            NativeCalls.godot_icall_0_8(method_bind_28, ptr);
        }

        private static IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_speaker_mode");

        public static int get_speaker_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_29, ptr);
        }

        private static IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mix_rate");

        public static float get_mix_rate()
        {
            return NativeCalls.godot_icall_0_11(method_bind_30, ptr);
        }

        private static IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus_layout");

        public static void set_bus_layout(AudioBusLayout bus_layout)
        {
            NativeCalls.godot_icall_1_19(method_bind_31, ptr, Object.GetPtr(bus_layout));
        }

        private static IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "generate_bus_layout");

        public static AudioBusLayout generate_bus_layout()
        {
            return NativeCalls.godot_icall_0_99(method_bind_32, ptr);
        }
    }
}
