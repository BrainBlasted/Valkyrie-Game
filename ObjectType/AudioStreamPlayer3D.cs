using System;

namespace GodotEngine
{
    public class AudioStreamPlayer3D : Spatial
    {
        public const int ATTENUATION_INVERSE_DISTANCE = 0;
        public const int ATTENUATION_INVERSE_SQUARE_DISTANCE = 1;
        public const int ATTENUATION_LOGARITHMIC = 2;
        public const int OUT_OF_RANGE_MIX = 0;
        public const int OUT_OF_RANGE_PAUSE = 1;
        public const int DOPPLER_TRACKING_DISABLED = 0;
        public const int DOPPLER_TRACKING_IDLE_STEP = 1;
        public const int DOPPLER_TRACKING_FIXED_STEP = 2;

        private const string nativeName = "AudioStreamPlayer3D";

        public AudioStreamPlayer3D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AudioStreamPlayer3D_Ctor(this);
        }

        internal AudioStreamPlayer3D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_stream");

        public void set_stream(AudioStream stream)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(stream));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_stream");

        public Object get_stream()
        {
            return NativeCalls.godot_icall_0_30(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_unit_db");

        public void set_unit_db(float unit_db)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), unit_db);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_unit_db");

        public float get_unit_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_unit_size");

        public void set_unit_size(float unit_size)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), unit_size);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_unit_size");

        public float get_unit_size()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_max_db");

        public void set_max_db(float max_db)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), max_db);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_max_db");

        public float get_max_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "play");

        public void play(float from_pos = 0f)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), from_pos);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "seek");

        public void seek(float to_pos)
        {
            NativeCalls.godot_icall_1_10(method_bind_9, Object.GetPtr(this), to_pos);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "stop");

        public void stop()
        {
            NativeCalls.godot_icall_0_8(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_playing");

        public bool is_playing()
        {
            return NativeCalls.godot_icall_0_3(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pos");

        public float get_pos()
        {
            return NativeCalls.godot_icall_0_11(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bus");

        public void set_bus(string bus)
        {
            NativeCalls.godot_icall_1_34(method_bind_13, Object.GetPtr(this), bus);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bus");

        public string get_bus()
        {
            return NativeCalls.godot_icall_0_2(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_autoplay");

        public void set_autoplay(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_15, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_autoplay_enabled");

        public bool is_autoplay_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_max_distance");

        public void set_max_distance(float metres)
        {
            NativeCalls.godot_icall_1_10(method_bind_17, Object.GetPtr(this), metres);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_max_distance");

        public float get_max_distance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_18, Object.GetPtr(this));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_area_mask");

        public void set_area_mask(int mask)
        {
            NativeCalls.godot_icall_1_0(method_bind_19, Object.GetPtr(this), mask);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_area_mask");

        public int get_area_mask()
        {
            return NativeCalls.godot_icall_0_1(method_bind_20, Object.GetPtr(this));
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_angle");

        public void set_emission_angle(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_21, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_angle");

        public float get_emission_angle()
        {
            return NativeCalls.godot_icall_0_11(method_bind_22, Object.GetPtr(this));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_angle_enabled");

        public void set_emission_angle_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_23, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_emission_angle_enabled");

        public bool is_emission_angle_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_24, Object.GetPtr(this));
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_angle_filter_attenuation_db");

        public void set_emission_angle_filter_attenuation_db(float db)
        {
            NativeCalls.godot_icall_1_10(method_bind_25, Object.GetPtr(this), db);
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_angle_filter_attenuation_db");

        public float get_emission_angle_filter_attenuation_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_26, Object.GetPtr(this));
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_attenuation_filter_cutoff_hz");

        public void set_attenuation_filter_cutoff_hz(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_27, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_attenuation_filter_cutoff_hz");

        public float get_attenuation_filter_cutoff_hz()
        {
            return NativeCalls.godot_icall_0_11(method_bind_28, Object.GetPtr(this));
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_attenuation_filter_db");

        public void set_attenuation_filter_db(float db)
        {
            NativeCalls.godot_icall_1_10(method_bind_29, Object.GetPtr(this), db);
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_attenuation_filter_db");

        public float get_attenuation_filter_db()
        {
            return NativeCalls.godot_icall_0_11(method_bind_30, Object.GetPtr(this));
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_attenuation_model");

        public void set_attenuation_model(int model)
        {
            NativeCalls.godot_icall_1_0(method_bind_31, Object.GetPtr(this), model);
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_attenuation_model");

        public int get_attenuation_model()
        {
            return NativeCalls.godot_icall_0_1(method_bind_32, Object.GetPtr(this));
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_out_of_range_mode");

        public void set_out_of_range_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_33, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_out_of_range_mode");

        public int get_out_of_range_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_34, Object.GetPtr(this));
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_doppler_tracking");

        public void set_doppler_tracking(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_35, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_doppler_tracking");

        public int get_doppler_tracking()
        {
            return NativeCalls.godot_icall_0_1(method_bind_36, Object.GetPtr(this));
        }
    }
}
