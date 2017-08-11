using System;

namespace GodotEngine
{
    public class ProceduralSky : Sky
    {
        public const int TEXTURE_SIZE_256 = 0;
        public const int TEXTURE_SIZE_512 = 1;
        public const int TEXTURE_SIZE_1024 = 2;
        public const int TEXTURE_SIZE_2048 = 3;
        public const int TEXTURE_SIZE_4096 = 4;
        public const int TEXTURE_SIZE_MAX = 5;

        private const string nativeName = "ProceduralSky";

        public ProceduralSky() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ProceduralSky_Ctor(this);
        }

        internal ProceduralSky(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sky_top_color");

        public void set_sky_top_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_0, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sky_top_color");

        public Color get_sky_top_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_1, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sky_horizon_color");

        public void set_sky_horizon_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_2, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sky_horizon_color");

        public Color get_sky_horizon_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_3, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sky_curve");

        public void set_sky_curve(float curve)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), curve);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sky_curve");

        public float get_sky_curve()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sky_energy");

        public void set_sky_energy(float energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), energy);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sky_energy");

        public float get_sky_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ground_bottom_color");

        public void set_ground_bottom_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_8, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ground_bottom_color");

        public Color get_ground_bottom_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_9, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ground_horizon_color");

        public void set_ground_horizon_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_10, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ground_horizon_color");

        public Color get_ground_horizon_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_11, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ground_curve");

        public void set_ground_curve(float curve)
        {
            NativeCalls.godot_icall_1_10(method_bind_12, Object.GetPtr(this), curve);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ground_curve");

        public float get_ground_curve()
        {
            return NativeCalls.godot_icall_0_11(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ground_energy");

        public void set_ground_energy(float energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), energy);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ground_energy");

        public float get_ground_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sun_color");

        public void set_sun_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_16, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sun_color");

        public Color get_sun_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_17, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sun_latitude");

        public void set_sun_latitude(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_18, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sun_latitude");

        public float get_sun_latitude()
        {
            return NativeCalls.godot_icall_0_11(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sun_longitude");

        public void set_sun_longitude(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_20, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sun_longitude");

        public float get_sun_longitude()
        {
            return NativeCalls.godot_icall_0_11(method_bind_21, Object.GetPtr(this));
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sun_angle_min");

        public void set_sun_angle_min(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_22, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sun_angle_min");

        public float get_sun_angle_min()
        {
            return NativeCalls.godot_icall_0_11(method_bind_23, Object.GetPtr(this));
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sun_angle_max");

        public void set_sun_angle_max(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_24, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sun_angle_max");

        public float get_sun_angle_max()
        {
            return NativeCalls.godot_icall_0_11(method_bind_25, Object.GetPtr(this));
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sun_curve");

        public void set_sun_curve(float curve)
        {
            NativeCalls.godot_icall_1_10(method_bind_26, Object.GetPtr(this), curve);
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sun_curve");

        public float get_sun_curve()
        {
            return NativeCalls.godot_icall_0_11(method_bind_27, Object.GetPtr(this));
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sun_energy");

        public void set_sun_energy(float energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_28, Object.GetPtr(this), energy);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sun_energy");

        public float get_sun_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_29, Object.GetPtr(this));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_texture_size");

        public void set_texture_size(int size)
        {
            NativeCalls.godot_icall_1_0(method_bind_30, Object.GetPtr(this), size);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_texture_size");

        public int get_texture_size()
        {
            return NativeCalls.godot_icall_0_1(method_bind_31, Object.GetPtr(this));
        }
    }
}
