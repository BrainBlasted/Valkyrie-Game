using System;

namespace GodotEngine
{
    public class ParticlesMaterial : Material
    {
        public const int PARAM_INITIAL_LINEAR_VELOCITY = 0;
        public const int PARAM_ANGULAR_VELOCITY = 1;
        public const int PARAM_ORBIT_VELOCITY = 2;
        public const int PARAM_LINEAR_ACCEL = 3;
        public const int PARAM_RADIAL_ACCEL = 4;
        public const int PARAM_TANGENTIAL_ACCEL = 5;
        public const int PARAM_DAMPING = 6;
        public const int PARAM_ANGLE = 7;
        public const int PARAM_SCALE = 8;
        public const int PARAM_HUE_VARIATION = 9;
        public const int PARAM_ANIM_SPEED = 10;
        public const int PARAM_ANIM_OFFSET = 11;
        public const int PARAM_MAX = 12;
        public const int FLAG_ALIGN_Y_TO_VELOCITY = 0;
        public const int FLAG_ROTATE_Y = 1;
        public const int FLAG_MAX = 4;
        public const int EMISSION_SHAPE_POINT = 0;
        public const int EMISSION_SHAPE_SPHERE = 1;
        public const int EMISSION_SHAPE_BOX = 2;
        public const int EMISSION_SHAPE_POINTS = 3;
        public const int EMISSION_SHAPE_DIRECTED_POINTS = 4;

        private const string nativeName = "ParticlesMaterial";

        public ParticlesMaterial() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ParticlesMaterial_Ctor(this);
        }

        internal ParticlesMaterial(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_spread");

        public void set_spread(float degrees)
        {
            NativeCalls.godot_icall_1_10(method_bind_0, Object.GetPtr(this), degrees);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_spread");

        public float get_spread()
        {
            return NativeCalls.godot_icall_0_11(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_flatness");

        public void set_flatness(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_flatness");

        public float get_flatness()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_param");

        public void set_param(int param, float value)
        {
            NativeCalls.godot_icall_2_45(method_bind_4, Object.GetPtr(this), param, value);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_param");

        public float get_param(int param)
        {
            return NativeCalls.godot_icall_1_6(method_bind_5, Object.GetPtr(this), param);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_param_randomness");

        public void set_param_randomness(int param, float randomness)
        {
            NativeCalls.godot_icall_2_45(method_bind_6, Object.GetPtr(this), param, randomness);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_param_randomness");

        public float get_param_randomness(int param)
        {
            return NativeCalls.godot_icall_1_6(method_bind_7, Object.GetPtr(this), param);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_param_texture");

        public void set_param_texture(int param, Texture texture)
        {
            NativeCalls.godot_icall_2_89(method_bind_8, Object.GetPtr(this), param, Object.GetPtr(texture));
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_param_texture");

        public Texture get_param_texture(int param)
        {
            return NativeCalls.godot_icall_1_109(method_bind_9, Object.GetPtr(this), param);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_color");

        public void set_color(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_10, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_color");

        public Color get_color()
        {
            object ret = NativeCalls.godot_icall_0_124(method_bind_11, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_color_ramp");

        public void set_color_ramp(Texture ramp)
        {
            NativeCalls.godot_icall_1_19(method_bind_12, Object.GetPtr(this), Object.GetPtr(ramp));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_color_ramp");

        public Texture get_color_ramp()
        {
            return NativeCalls.godot_icall_0_93(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_flag");

        public void set_flag(int flag, bool enable)
        {
            NativeCalls.godot_icall_2_42(method_bind_14, Object.GetPtr(this), flag, enable);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_flag");

        public bool get_flag(int flag)
        {
            return NativeCalls.godot_icall_1_22(method_bind_15, Object.GetPtr(this), flag);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_shape");

        public void set_emission_shape(int shape)
        {
            NativeCalls.godot_icall_1_0(method_bind_16, Object.GetPtr(this), shape);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_shape");

        public int get_emission_shape()
        {
            return NativeCalls.godot_icall_0_1(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_sphere_radius");

        public void set_emission_sphere_radius(float radius)
        {
            NativeCalls.godot_icall_1_10(method_bind_18, Object.GetPtr(this), radius);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_sphere_radius");

        public float get_emission_sphere_radius()
        {
            return NativeCalls.godot_icall_0_11(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_box_extents");

        public void set_emission_box_extents(Vector3 extents)
        {
            NativeCalls.godot_icall_1_84(method_bind_20, Object.GetPtr(this), ref extents);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_box_extents");

        public Vector3 get_emission_box_extents()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_21, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_point_texture");

        public void set_emission_point_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_19(method_bind_22, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_point_texture");

        public Texture get_emission_point_texture()
        {
            return NativeCalls.godot_icall_0_93(method_bind_23, Object.GetPtr(this));
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_normal_texture");

        public void set_emission_normal_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_19(method_bind_24, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_normal_texture");

        public Texture get_emission_normal_texture()
        {
            return NativeCalls.godot_icall_0_93(method_bind_25, Object.GetPtr(this));
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_color_texture");

        public void set_emission_color_texture(Texture texture)
        {
            NativeCalls.godot_icall_1_19(method_bind_26, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_color_texture");

        public Texture get_emission_color_texture()
        {
            return NativeCalls.godot_icall_0_93(method_bind_27, Object.GetPtr(this));
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_point_count");

        public void set_emission_point_count(int point_count)
        {
            NativeCalls.godot_icall_1_0(method_bind_28, Object.GetPtr(this), point_count);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_point_count");

        public int get_emission_point_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_29, Object.GetPtr(this));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_trail_divisor");

        public void set_trail_divisor(int divisor)
        {
            NativeCalls.godot_icall_1_0(method_bind_30, Object.GetPtr(this), divisor);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_trail_divisor");

        public int get_trail_divisor()
        {
            return NativeCalls.godot_icall_0_1(method_bind_31, Object.GetPtr(this));
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_trail_size_modifier");

        public void set_trail_size_modifier(CurveTexture texture)
        {
            NativeCalls.godot_icall_1_19(method_bind_32, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_trail_size_modifier");

        public CurveTexture get_trail_size_modifier()
        {
            return NativeCalls.godot_icall_0_331(method_bind_33, Object.GetPtr(this));
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_trail_color_modifier");

        public void set_trail_color_modifier(GradientTexture texture)
        {
            NativeCalls.godot_icall_1_19(method_bind_34, Object.GetPtr(this), Object.GetPtr(texture));
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_trail_color_modifier");

        public GradientTexture get_trail_color_modifier()
        {
            return NativeCalls.godot_icall_0_332(method_bind_35, Object.GetPtr(this));
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_gravity");

        public Vector3 get_gravity()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_36, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_gravity");

        public void set_gravity(Vector3 accel_vec)
        {
            NativeCalls.godot_icall_1_84(method_bind_37, Object.GetPtr(this), ref accel_vec);
        }
    }
}
