using System;

namespace GodotEngine
{
    public class Environment : Resource
    {
        public const int BG_KEEP = 4;
        public const int BG_CLEAR_COLOR = 0;
        public const int BG_COLOR = 1;
        public const int BG_SKY = 2;
        public const int BG_CANVAS = 3;
        public const int BG_MAX = 5;
        public const int GLOW_BLEND_MODE_ADDITIVE = 0;
        public const int GLOW_BLEND_MODE_SCREEN = 1;
        public const int GLOW_BLEND_MODE_SOFTLIGHT = 2;
        public const int GLOW_BLEND_MODE_REPLACE = 3;
        public const int TONE_MAPPER_LINEAR = 0;
        public const int TONE_MAPPER_REINHARDT = 1;
        public const int TONE_MAPPER_FILMIC = 2;
        public const int TONE_MAPPER_ACES = 3;
        public const int DOF_BLUR_QUALITY_LOW = 0;
        public const int DOF_BLUR_QUALITY_MEDIUM = 1;
        public const int DOF_BLUR_QUALITY_HIGH = 2;

        private const string nativeName = "Environment";

        public Environment() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Environment_Ctor(this);
        }

        internal Environment(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_background");

        public void set_background(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_0, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sky");

        public void set_sky(Sky sky)
        {
            NativeCalls.godot_icall_1_35(method_bind_1, Object.GetPtr(this), Object.GetPtr(sky));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_sky_scale");

        public void set_sky_scale(float scale)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), scale);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bg_color");

        public void set_bg_color(Color color)
        {
            NativeCalls.godot_icall_1_122(method_bind_3, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bg_energy");

        public void set_bg_energy(float energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), energy);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_canvas_max_layer");

        public void set_canvas_max_layer(int layer)
        {
            NativeCalls.godot_icall_1_0(method_bind_5, Object.GetPtr(this), layer);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ambient_light_color");

        public void set_ambient_light_color(Color color)
        {
            NativeCalls.godot_icall_1_122(method_bind_6, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ambient_light_energy");

        public void set_ambient_light_energy(float energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_7, Object.GetPtr(this), energy);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ambient_light_sky_contribution");

        public void set_ambient_light_sky_contribution(float energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), energy);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_background");

        public int get_background()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sky");

        public CubeMap get_sky()
        {
            return NativeCalls.godot_icall_0_196(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sky_scale");

        public float get_sky_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bg_color");

        public Color get_bg_color()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_12, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bg_energy");

        public float get_bg_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_canvas_max_layer");

        public int get_canvas_max_layer()
        {
            return NativeCalls.godot_icall_0_1(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ambient_light_color");

        public Color get_ambient_light_color()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_15, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ambient_light_energy");

        public float get_ambient_light_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_16, Object.GetPtr(this));
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ambient_light_sky_contribution");

        public float get_ambient_light_sky_contribution()
        {
            return NativeCalls.godot_icall_0_11(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_enabled");

        public void set_fog_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_18, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_fog_enabled");

        public bool is_fog_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_color");

        public void set_fog_color(Color color)
        {
            NativeCalls.godot_icall_1_122(method_bind_20, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_color");

        public Color get_fog_color()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_21, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_sun_color");

        public void set_fog_sun_color(Color color)
        {
            NativeCalls.godot_icall_1_122(method_bind_22, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_sun_color");

        public Color get_fog_sun_color()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_23, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_sun_amount");

        public void set_fog_sun_amount(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_24, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_sun_amount");

        public float get_fog_sun_amount()
        {
            return NativeCalls.godot_icall_0_11(method_bind_25, Object.GetPtr(this));
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_depth_enabled");

        public void set_fog_depth_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_26, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_fog_depth_enabled");

        public bool is_fog_depth_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_27, Object.GetPtr(this));
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_depth_begin");

        public void set_fog_depth_begin(float distance)
        {
            NativeCalls.godot_icall_1_10(method_bind_28, Object.GetPtr(this), distance);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_depth_begin");

        public float get_fog_depth_begin()
        {
            return NativeCalls.godot_icall_0_11(method_bind_29, Object.GetPtr(this));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_depth_curve");

        public void set_fog_depth_curve(float curve)
        {
            NativeCalls.godot_icall_1_10(method_bind_30, Object.GetPtr(this), curve);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_depth_curve");

        public float get_fog_depth_curve()
        {
            return NativeCalls.godot_icall_0_11(method_bind_31, Object.GetPtr(this));
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_transmit_enabled");

        public void set_fog_transmit_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_32, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_fog_transmit_enabled");

        public bool is_fog_transmit_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_33, Object.GetPtr(this));
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_transmit_curve");

        public void set_fog_transmit_curve(float curve)
        {
            NativeCalls.godot_icall_1_10(method_bind_34, Object.GetPtr(this), curve);
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_transmit_curve");

        public float get_fog_transmit_curve()
        {
            return NativeCalls.godot_icall_0_11(method_bind_35, Object.GetPtr(this));
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_height_enabled");

        public void set_fog_height_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_36, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_fog_height_enabled");

        public bool is_fog_height_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_37, Object.GetPtr(this));
        }

        private IntPtr method_bind_38 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_height_min");

        public void set_fog_height_min(float height)
        {
            NativeCalls.godot_icall_1_10(method_bind_38, Object.GetPtr(this), height);
        }

        private IntPtr method_bind_39 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_height_min");

        public float get_fog_height_min()
        {
            return NativeCalls.godot_icall_0_11(method_bind_39, Object.GetPtr(this));
        }

        private IntPtr method_bind_40 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_height_max");

        public void set_fog_height_max(float height)
        {
            NativeCalls.godot_icall_1_10(method_bind_40, Object.GetPtr(this), height);
        }

        private IntPtr method_bind_41 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_height_max");

        public float get_fog_height_max()
        {
            return NativeCalls.godot_icall_0_11(method_bind_41, Object.GetPtr(this));
        }

        private IntPtr method_bind_42 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fog_height_curve");

        public void set_fog_height_curve(float curve)
        {
            NativeCalls.godot_icall_1_10(method_bind_42, Object.GetPtr(this), curve);
        }

        private IntPtr method_bind_43 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fog_height_curve");

        public float get_fog_height_curve()
        {
            return NativeCalls.godot_icall_0_11(method_bind_43, Object.GetPtr(this));
        }

        private IntPtr method_bind_44 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tonemapper");

        public void set_tonemapper(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_44, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_45 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tonemapper");

        public int get_tonemapper()
        {
            return NativeCalls.godot_icall_0_1(method_bind_45, Object.GetPtr(this));
        }

        private IntPtr method_bind_46 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tonemap_exposure");

        public void set_tonemap_exposure(float exposure)
        {
            NativeCalls.godot_icall_1_10(method_bind_46, Object.GetPtr(this), exposure);
        }

        private IntPtr method_bind_47 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tonemap_exposure");

        public float get_tonemap_exposure()
        {
            return NativeCalls.godot_icall_0_11(method_bind_47, Object.GetPtr(this));
        }

        private IntPtr method_bind_48 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tonemap_white");

        public void set_tonemap_white(float white)
        {
            NativeCalls.godot_icall_1_10(method_bind_48, Object.GetPtr(this), white);
        }

        private IntPtr method_bind_49 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tonemap_white");

        public float get_tonemap_white()
        {
            return NativeCalls.godot_icall_0_11(method_bind_49, Object.GetPtr(this));
        }

        private IntPtr method_bind_50 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tonemap_auto_exposure");

        public void set_tonemap_auto_exposure(bool auto_exposure)
        {
            NativeCalls.godot_icall_1_7(method_bind_50, Object.GetPtr(this), auto_exposure);
        }

        private IntPtr method_bind_51 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tonemap_auto_exposure");

        public bool get_tonemap_auto_exposure()
        {
            return NativeCalls.godot_icall_0_3(method_bind_51, Object.GetPtr(this));
        }

        private IntPtr method_bind_52 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tonemap_auto_exposure_max");

        public void set_tonemap_auto_exposure_max(float exposure_max)
        {
            NativeCalls.godot_icall_1_10(method_bind_52, Object.GetPtr(this), exposure_max);
        }

        private IntPtr method_bind_53 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tonemap_auto_exposure_max");

        public float get_tonemap_auto_exposure_max()
        {
            return NativeCalls.godot_icall_0_11(method_bind_53, Object.GetPtr(this));
        }

        private IntPtr method_bind_54 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tonemap_auto_exposure_min");

        public void set_tonemap_auto_exposure_min(float exposure_min)
        {
            NativeCalls.godot_icall_1_10(method_bind_54, Object.GetPtr(this), exposure_min);
        }

        private IntPtr method_bind_55 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tonemap_auto_exposure_min");

        public float get_tonemap_auto_exposure_min()
        {
            return NativeCalls.godot_icall_0_11(method_bind_55, Object.GetPtr(this));
        }

        private IntPtr method_bind_56 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tonemap_auto_exposure_speed");

        public void set_tonemap_auto_exposure_speed(float exposure_speed)
        {
            NativeCalls.godot_icall_1_10(method_bind_56, Object.GetPtr(this), exposure_speed);
        }

        private IntPtr method_bind_57 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tonemap_auto_exposure_speed");

        public float get_tonemap_auto_exposure_speed()
        {
            return NativeCalls.godot_icall_0_11(method_bind_57, Object.GetPtr(this));
        }

        private IntPtr method_bind_58 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tonemap_auto_exposure_grey");

        public void set_tonemap_auto_exposure_grey(float exposure_grey)
        {
            NativeCalls.godot_icall_1_10(method_bind_58, Object.GetPtr(this), exposure_grey);
        }

        private IntPtr method_bind_59 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tonemap_auto_exposure_grey");

        public float get_tonemap_auto_exposure_grey()
        {
            return NativeCalls.godot_icall_0_11(method_bind_59, Object.GetPtr(this));
        }

        private IntPtr method_bind_60 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssr_enabled");

        public void set_ssr_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_60, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_61 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_ssr_enabled");

        public bool is_ssr_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_61, Object.GetPtr(this));
        }

        private IntPtr method_bind_62 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssr_max_steps");

        public void set_ssr_max_steps(int max_steps)
        {
            NativeCalls.godot_icall_1_0(method_bind_62, Object.GetPtr(this), max_steps);
        }

        private IntPtr method_bind_63 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssr_max_steps");

        public int get_ssr_max_steps()
        {
            return NativeCalls.godot_icall_0_1(method_bind_63, Object.GetPtr(this));
        }

        private IntPtr method_bind_64 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssr_fade_in");

        public void set_ssr_fade_in(float fade_in)
        {
            NativeCalls.godot_icall_1_10(method_bind_64, Object.GetPtr(this), fade_in);
        }

        private IntPtr method_bind_65 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssr_fade_in");

        public float get_ssr_fade_in()
        {
            return NativeCalls.godot_icall_0_11(method_bind_65, Object.GetPtr(this));
        }

        private IntPtr method_bind_66 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssr_fade_out");

        public void set_ssr_fade_out(float fade_out)
        {
            NativeCalls.godot_icall_1_10(method_bind_66, Object.GetPtr(this), fade_out);
        }

        private IntPtr method_bind_67 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssr_fade_out");

        public float get_ssr_fade_out()
        {
            return NativeCalls.godot_icall_0_11(method_bind_67, Object.GetPtr(this));
        }

        private IntPtr method_bind_68 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssr_depth_tolerance");

        public void set_ssr_depth_tolerance(float depth_tolerance)
        {
            NativeCalls.godot_icall_1_10(method_bind_68, Object.GetPtr(this), depth_tolerance);
        }

        private IntPtr method_bind_69 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssr_depth_tolerance");

        public float get_ssr_depth_tolerance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_69, Object.GetPtr(this));
        }

        private IntPtr method_bind_70 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssr_rough");

        public void set_ssr_rough(bool rough)
        {
            NativeCalls.godot_icall_1_7(method_bind_70, Object.GetPtr(this), rough);
        }

        private IntPtr method_bind_71 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_ssr_rough");

        public bool is_ssr_rough()
        {
            return NativeCalls.godot_icall_0_3(method_bind_71, Object.GetPtr(this));
        }

        private IntPtr method_bind_72 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_enabled");

        public void set_ssao_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_72, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_73 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_ssao_enabled");

        public bool is_ssao_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_73, Object.GetPtr(this));
        }

        private IntPtr method_bind_74 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_radius");

        public void set_ssao_radius(float radius)
        {
            NativeCalls.godot_icall_1_10(method_bind_74, Object.GetPtr(this), radius);
        }

        private IntPtr method_bind_75 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssao_radius");

        public float get_ssao_radius()
        {
            return NativeCalls.godot_icall_0_11(method_bind_75, Object.GetPtr(this));
        }

        private IntPtr method_bind_76 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_intensity");

        public void set_ssao_intensity(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_76, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_77 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssao_intensity");

        public float get_ssao_intensity()
        {
            return NativeCalls.godot_icall_0_11(method_bind_77, Object.GetPtr(this));
        }

        private IntPtr method_bind_78 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_radius2");

        public void set_ssao_radius2(float radius)
        {
            NativeCalls.godot_icall_1_10(method_bind_78, Object.GetPtr(this), radius);
        }

        private IntPtr method_bind_79 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssao_radius2");

        public float get_ssao_radius2()
        {
            return NativeCalls.godot_icall_0_11(method_bind_79, Object.GetPtr(this));
        }

        private IntPtr method_bind_80 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_intensity2");

        public void set_ssao_intensity2(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_80, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_81 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssao_intensity2");

        public float get_ssao_intensity2()
        {
            return NativeCalls.godot_icall_0_11(method_bind_81, Object.GetPtr(this));
        }

        private IntPtr method_bind_82 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_bias");

        public void set_ssao_bias(float bias)
        {
            NativeCalls.godot_icall_1_10(method_bind_82, Object.GetPtr(this), bias);
        }

        private IntPtr method_bind_83 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssao_bias");

        public float get_ssao_bias()
        {
            return NativeCalls.godot_icall_0_11(method_bind_83, Object.GetPtr(this));
        }

        private IntPtr method_bind_84 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_direct_light_affect");

        public void set_ssao_direct_light_affect(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_84, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_85 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssao_direct_light_affect");

        public float get_ssao_direct_light_affect()
        {
            return NativeCalls.godot_icall_0_11(method_bind_85, Object.GetPtr(this));
        }

        private IntPtr method_bind_86 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_color");

        public void set_ssao_color(Color color)
        {
            NativeCalls.godot_icall_1_122(method_bind_86, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_87 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ssao_color");

        public Color get_ssao_color()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_87, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_88 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ssao_blur");

        public void set_ssao_blur(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_88, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_89 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_ssao_blur_enabled");

        public bool is_ssao_blur_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_89, Object.GetPtr(this));
        }

        private IntPtr method_bind_90 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_far_enabled");

        public void set_dof_blur_far_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_90, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_91 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_dof_blur_far_enabled");

        public bool is_dof_blur_far_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_91, Object.GetPtr(this));
        }

        private IntPtr method_bind_92 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_far_distance");

        public void set_dof_blur_far_distance(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_92, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_93 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dof_blur_far_distance");

        public float get_dof_blur_far_distance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_93, Object.GetPtr(this));
        }

        private IntPtr method_bind_94 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_far_transition");

        public void set_dof_blur_far_transition(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_94, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_95 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dof_blur_far_transition");

        public float get_dof_blur_far_transition()
        {
            return NativeCalls.godot_icall_0_11(method_bind_95, Object.GetPtr(this));
        }

        private IntPtr method_bind_96 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_far_amount");

        public void set_dof_blur_far_amount(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_96, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_97 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dof_blur_far_amount");

        public float get_dof_blur_far_amount()
        {
            return NativeCalls.godot_icall_0_11(method_bind_97, Object.GetPtr(this));
        }

        private IntPtr method_bind_98 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_far_quality");

        public void set_dof_blur_far_quality(int intensity)
        {
            NativeCalls.godot_icall_1_0(method_bind_98, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_99 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dof_blur_far_quality");

        public int get_dof_blur_far_quality()
        {
            return NativeCalls.godot_icall_0_1(method_bind_99, Object.GetPtr(this));
        }

        private IntPtr method_bind_100 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_near_enabled");

        public void set_dof_blur_near_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_100, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_101 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_dof_blur_near_enabled");

        public bool is_dof_blur_near_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_101, Object.GetPtr(this));
        }

        private IntPtr method_bind_102 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_near_distance");

        public void set_dof_blur_near_distance(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_102, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_103 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dof_blur_near_distance");

        public float get_dof_blur_near_distance()
        {
            return NativeCalls.godot_icall_0_11(method_bind_103, Object.GetPtr(this));
        }

        private IntPtr method_bind_104 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_near_transition");

        public void set_dof_blur_near_transition(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_104, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_105 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dof_blur_near_transition");

        public float get_dof_blur_near_transition()
        {
            return NativeCalls.godot_icall_0_11(method_bind_105, Object.GetPtr(this));
        }

        private IntPtr method_bind_106 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_near_amount");

        public void set_dof_blur_near_amount(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_106, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_107 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dof_blur_near_amount");

        public float get_dof_blur_near_amount()
        {
            return NativeCalls.godot_icall_0_11(method_bind_107, Object.GetPtr(this));
        }

        private IntPtr method_bind_108 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_dof_blur_near_quality");

        public void set_dof_blur_near_quality(int level)
        {
            NativeCalls.godot_icall_1_0(method_bind_108, Object.GetPtr(this), level);
        }

        private IntPtr method_bind_109 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_dof_blur_near_quality");

        public int get_dof_blur_near_quality()
        {
            return NativeCalls.godot_icall_0_1(method_bind_109, Object.GetPtr(this));
        }

        private IntPtr method_bind_110 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_enabled");

        public void set_glow_enabled(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_110, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_111 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_glow_enabled");

        public bool is_glow_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_111, Object.GetPtr(this));
        }

        private IntPtr method_bind_112 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_level");

        public void set_glow_level(int idx, bool enabled)
        {
            NativeCalls.godot_icall_2_42(method_bind_112, Object.GetPtr(this), idx, enabled);
        }

        private IntPtr method_bind_113 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_glow_level_enabled");

        public bool is_glow_level_enabled(int idx)
        {
            return NativeCalls.godot_icall_1_22(method_bind_113, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_114 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_intensity");

        public void set_glow_intensity(float intensity)
        {
            NativeCalls.godot_icall_1_10(method_bind_114, Object.GetPtr(this), intensity);
        }

        private IntPtr method_bind_115 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_glow_intensity");

        public float get_glow_intensity()
        {
            return NativeCalls.godot_icall_0_11(method_bind_115, Object.GetPtr(this));
        }

        private IntPtr method_bind_116 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_strength");

        public void set_glow_strength(float strength)
        {
            NativeCalls.godot_icall_1_10(method_bind_116, Object.GetPtr(this), strength);
        }

        private IntPtr method_bind_117 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_glow_strength");

        public float get_glow_strength()
        {
            return NativeCalls.godot_icall_0_11(method_bind_117, Object.GetPtr(this));
        }

        private IntPtr method_bind_118 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_bloom");

        public void set_glow_bloom(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_118, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_119 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_glow_bloom");

        public float get_glow_bloom()
        {
            return NativeCalls.godot_icall_0_11(method_bind_119, Object.GetPtr(this));
        }

        private IntPtr method_bind_120 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_blend_mode");

        public void set_glow_blend_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_120, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_121 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_glow_blend_mode");

        public int get_glow_blend_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_121, Object.GetPtr(this));
        }

        private IntPtr method_bind_122 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_hdr_bleed_threshold");

        public void set_glow_hdr_bleed_threshold(float threshold)
        {
            NativeCalls.godot_icall_1_10(method_bind_122, Object.GetPtr(this), threshold);
        }

        private IntPtr method_bind_123 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_glow_hdr_bleed_threshold");

        public float get_glow_hdr_bleed_threshold()
        {
            return NativeCalls.godot_icall_0_11(method_bind_123, Object.GetPtr(this));
        }

        private IntPtr method_bind_124 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_hdr_bleed_scale");

        public void set_glow_hdr_bleed_scale(float scale)
        {
            NativeCalls.godot_icall_1_10(method_bind_124, Object.GetPtr(this), scale);
        }

        private IntPtr method_bind_125 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_glow_hdr_bleed_scale");

        public float get_glow_hdr_bleed_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_125, Object.GetPtr(this));
        }

        private IntPtr method_bind_126 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_glow_bicubic_upscale");

        public void set_glow_bicubic_upscale(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_126, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_127 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_glow_bicubic_upscale_enabled");

        public bool is_glow_bicubic_upscale_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_127, Object.GetPtr(this));
        }

        private IntPtr method_bind_128 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_adjustment_enable");

        public void set_adjustment_enable(bool enabled)
        {
            NativeCalls.godot_icall_1_7(method_bind_128, Object.GetPtr(this), enabled);
        }

        private IntPtr method_bind_129 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_adjustment_enabled");

        public bool is_adjustment_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_129, Object.GetPtr(this));
        }

        private IntPtr method_bind_130 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_adjustment_brightness");

        public void set_adjustment_brightness(float brightness)
        {
            NativeCalls.godot_icall_1_10(method_bind_130, Object.GetPtr(this), brightness);
        }

        private IntPtr method_bind_131 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_adjustment_brightness");

        public float get_adjustment_brightness()
        {
            return NativeCalls.godot_icall_0_11(method_bind_131, Object.GetPtr(this));
        }

        private IntPtr method_bind_132 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_adjustment_contrast");

        public void set_adjustment_contrast(float contrast)
        {
            NativeCalls.godot_icall_1_10(method_bind_132, Object.GetPtr(this), contrast);
        }

        private IntPtr method_bind_133 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_adjustment_contrast");

        public float get_adjustment_contrast()
        {
            return NativeCalls.godot_icall_0_11(method_bind_133, Object.GetPtr(this));
        }

        private IntPtr method_bind_134 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_adjustment_saturation");

        public void set_adjustment_saturation(float saturation)
        {
            NativeCalls.godot_icall_1_10(method_bind_134, Object.GetPtr(this), saturation);
        }

        private IntPtr method_bind_135 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_adjustment_saturation");

        public float get_adjustment_saturation()
        {
            return NativeCalls.godot_icall_0_11(method_bind_135, Object.GetPtr(this));
        }

        private IntPtr method_bind_136 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_adjustment_color_correction");

        public void set_adjustment_color_correction(Texture color_correction)
        {
            NativeCalls.godot_icall_1_35(method_bind_136, Object.GetPtr(this), Object.GetPtr(color_correction));
        }

        private IntPtr method_bind_137 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_adjustment_color_correction");

        public Texture get_adjustment_color_correction()
        {
            return NativeCalls.godot_icall_0_92(method_bind_137, Object.GetPtr(this));
        }
    }
}
