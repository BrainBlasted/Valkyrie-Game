using System;

namespace GodotEngine
{
    public class SpatialMaterial : Material
    {
        public const int TEXTURE_ALBEDO = 0;
        public const int TEXTURE_METALLIC = 1;
        public const int TEXTURE_ROUGHNESS = 2;
        public const int TEXTURE_EMISSION = 3;
        public const int TEXTURE_NORMAL = 4;
        public const int TEXTURE_RIM = 5;
        public const int TEXTURE_CLEARCOAT = 6;
        public const int TEXTURE_FLOWMAP = 7;
        public const int TEXTURE_AMBIENT_OCCLUSION = 8;
        public const int TEXTURE_DEPTH = 9;
        public const int TEXTURE_SUBSURFACE_SCATTERING = 10;
        public const int TEXTURE_REFRACTION = 11;
        public const int TEXTURE_DETAIL_MASK = 12;
        public const int TEXTURE_DETAIL_ALBEDO = 13;
        public const int TEXTURE_DETAIL_NORMAL = 14;
        public const int TEXTURE_MAX = 15;
        public const int DETAIL_UV_1 = 0;
        public const int DETAIL_UV_2 = 1;
        public const int FEATURE_TRANSPARENT = 0;
        public const int FEATURE_EMISSION = 1;
        public const int FEATURE_NORMAL_MAPPING = 2;
        public const int FEATURE_RIM = 3;
        public const int FEATURE_CLEARCOAT = 4;
        public const int FEATURE_ANISOTROPY = 5;
        public const int FEATURE_AMBIENT_OCCLUSION = 6;
        public const int FEATURE_DEPTH_MAPPING = 7;
        public const int FEATURE_SUBSURACE_SCATTERING = 8;
        public const int FEATURE_REFRACTION = 9;
        public const int FEATURE_DETAIL = 10;
        public const int FEATURE_MAX = 11;
        public const int BLEND_MODE_MIX = 0;
        public const int BLEND_MODE_ADD = 1;
        public const int BLEND_MODE_SUB = 2;
        public const int BLEND_MODE_MUL = 3;
        public const int DEPTH_DRAW_OPAQUE_ONLY = 0;
        public const int DEPTH_DRAW_ALWAYS = 1;
        public const int DEPTH_DRAW_DISABLED = 2;
        public const int DEPTH_DRAW_ALPHA_OPAQUE_PREPASS = 3;
        public const int CULL_BACK = 0;
        public const int CULL_FRONT = 1;
        public const int CULL_DISABLED = 2;
        public const int FLAG_UNSHADED = 0;
        public const int FLAG_USE_VERTEX_LIGHTING = 1;
        public const int FLAG_ONTOP = 2;
        public const int FLAG_ALBEDO_FROM_VERTEX_COLOR = 3;
        public const int FLAG_SRGB_VERTEX_COLOR = 4;
        public const int FLAG_USE_POINT_SIZE = 5;
        public const int FLAG_FIXED_SIZE = 6;
        public const int FLAG_UV1_USE_TRIPLANAR = 7;
        public const int FLAG_UV2_USE_TRIPLANAR = 8;
        public const int FLAG_AO_ON_UV2 = 9;
        public const int FLAG_USE_ALPHA_SCISSOR = 10;
        public const int FLAG_MAX = 11;
        public const int DIFFUSE_LAMBERT = 0;
        public const int DIFFUSE_HALF_LAMBERT = 1;
        public const int DIFFUSE_OREN_NAYAR = 2;
        public const int DIFFUSE_BURLEY = 3;
        public const int DIFFUSE_TOON = 4;
        public const int SPECULAR_SCHLICK_GGX = 0;
        public const int SPECULAR_BLINN = 1;
        public const int SPECULAR_PHONG = 2;
        public const int SPECULAR_TOON = 3;
        public const int SPECULAR_DISABLED = 4;
        public const int BILLBOARD_DISABLED = 0;
        public const int BILLBOARD_ENABLED = 1;
        public const int BILLBOARD_FIXED_Y = 2;
        public const int BILLBOARD_PARTICLES = 3;
        public const int TEXTURE_CHANNEL_RED = 0;
        public const int TEXTURE_CHANNEL_GREEN = 1;
        public const int TEXTURE_CHANNEL_BLUE = 2;
        public const int TEXTURE_CHANNEL_ALPHA = 3;
        public const int TEXTURE_CHANNEL_GRAYSCALE = 4;

        private const string nativeName = "SpatialMaterial";

        public SpatialMaterial() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpatialMaterial_Ctor(this);
        }

        internal SpatialMaterial(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_albedo");

        public void set_albedo(Color albedo)
        {
            NativeCalls.godot_icall_1_122(method_bind_0, Object.GetPtr(this), ref albedo);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_albedo");

        public Color get_albedo()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_1, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_specular");

        public void set_specular(float specular)
        {
            NativeCalls.godot_icall_1_10(method_bind_2, Object.GetPtr(this), specular);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_specular");

        public float get_specular()
        {
            return NativeCalls.godot_icall_0_11(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_metallic");

        public void set_metallic(float metallic)
        {
            NativeCalls.godot_icall_1_10(method_bind_4, Object.GetPtr(this), metallic);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_metallic");

        public float get_metallic()
        {
            return NativeCalls.godot_icall_0_11(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_roughness");

        public void set_roughness(float roughness)
        {
            NativeCalls.godot_icall_1_10(method_bind_6, Object.GetPtr(this), roughness);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_roughness");

        public float get_roughness()
        {
            return NativeCalls.godot_icall_0_11(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission");

        public void set_emission(Color emission)
        {
            NativeCalls.godot_icall_1_122(method_bind_8, Object.GetPtr(this), ref emission);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission");

        public Color get_emission()
        {
            object ret = NativeCalls.godot_icall_0_123(method_bind_9, Object.GetPtr(this));
            return (Color)ret;
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_emission_energy");

        public void set_emission_energy(float emission_energy)
        {
            NativeCalls.godot_icall_1_10(method_bind_10, Object.GetPtr(this), emission_energy);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_emission_energy");

        public float get_emission_energy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_11, Object.GetPtr(this));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_normal_scale");

        public void set_normal_scale(float normal_scale)
        {
            NativeCalls.godot_icall_1_10(method_bind_12, Object.GetPtr(this), normal_scale);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_normal_scale");

        public float get_normal_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rim");

        public void set_rim(float rim)
        {
            NativeCalls.godot_icall_1_10(method_bind_14, Object.GetPtr(this), rim);
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rim");

        public float get_rim()
        {
            return NativeCalls.godot_icall_0_11(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_rim_tint");

        public void set_rim_tint(float rim_tint)
        {
            NativeCalls.godot_icall_1_10(method_bind_16, Object.GetPtr(this), rim_tint);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rim_tint");

        public float get_rim_tint()
        {
            return NativeCalls.godot_icall_0_11(method_bind_17, Object.GetPtr(this));
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_clearcoat");

        public void set_clearcoat(float clearcoat)
        {
            NativeCalls.godot_icall_1_10(method_bind_18, Object.GetPtr(this), clearcoat);
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_clearcoat");

        public float get_clearcoat()
        {
            return NativeCalls.godot_icall_0_11(method_bind_19, Object.GetPtr(this));
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_clearcoat_gloss");

        public void set_clearcoat_gloss(float clearcoat_gloss)
        {
            NativeCalls.godot_icall_1_10(method_bind_20, Object.GetPtr(this), clearcoat_gloss);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_clearcoat_gloss");

        public float get_clearcoat_gloss()
        {
            return NativeCalls.godot_icall_0_11(method_bind_21, Object.GetPtr(this));
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_anisotropy");

        public void set_anisotropy(float anisotropy)
        {
            NativeCalls.godot_icall_1_10(method_bind_22, Object.GetPtr(this), anisotropy);
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_anisotropy");

        public float get_anisotropy()
        {
            return NativeCalls.godot_icall_0_11(method_bind_23, Object.GetPtr(this));
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_depth_scale");

        public void set_depth_scale(float depth_scale)
        {
            NativeCalls.godot_icall_1_10(method_bind_24, Object.GetPtr(this), depth_scale);
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_depth_scale");

        public float get_depth_scale()
        {
            return NativeCalls.godot_icall_0_11(method_bind_25, Object.GetPtr(this));
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_subsurface_scattering_strength");

        public void set_subsurface_scattering_strength(float strength)
        {
            NativeCalls.godot_icall_1_10(method_bind_26, Object.GetPtr(this), strength);
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_subsurface_scattering_strength");

        public float get_subsurface_scattering_strength()
        {
            return NativeCalls.godot_icall_0_11(method_bind_27, Object.GetPtr(this));
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_refraction");

        public void set_refraction(float refraction)
        {
            NativeCalls.godot_icall_1_10(method_bind_28, Object.GetPtr(this), refraction);
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_refraction");

        public float get_refraction()
        {
            return NativeCalls.godot_icall_0_11(method_bind_29, Object.GetPtr(this));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_line_width");

        public void set_line_width(float line_width)
        {
            NativeCalls.godot_icall_1_10(method_bind_30, Object.GetPtr(this), line_width);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_line_width");

        public float get_line_width()
        {
            return NativeCalls.godot_icall_0_11(method_bind_31, Object.GetPtr(this));
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_point_size");

        public void set_point_size(float point_size)
        {
            NativeCalls.godot_icall_1_10(method_bind_32, Object.GetPtr(this), point_size);
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_point_size");

        public float get_point_size()
        {
            return NativeCalls.godot_icall_0_11(method_bind_33, Object.GetPtr(this));
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_detail_uv");

        public void set_detail_uv(int detail_uv)
        {
            NativeCalls.godot_icall_1_0(method_bind_34, Object.GetPtr(this), detail_uv);
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_detail_uv");

        public int get_detail_uv()
        {
            return NativeCalls.godot_icall_0_1(method_bind_35, Object.GetPtr(this));
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_blend_mode");

        public void set_blend_mode(int blend_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_36, Object.GetPtr(this), blend_mode);
        }

        private IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_blend_mode");

        public int get_blend_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_37, Object.GetPtr(this));
        }

        private IntPtr method_bind_38 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_depth_draw_mode");

        public void set_depth_draw_mode(int depth_draw_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_38, Object.GetPtr(this), depth_draw_mode);
        }

        private IntPtr method_bind_39 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_depth_draw_mode");

        public int get_depth_draw_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_39, Object.GetPtr(this));
        }

        private IntPtr method_bind_40 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_cull_mode");

        public void set_cull_mode(int cull_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_40, Object.GetPtr(this), cull_mode);
        }

        private IntPtr method_bind_41 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_cull_mode");

        public int get_cull_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_41, Object.GetPtr(this));
        }

        private IntPtr method_bind_42 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_diffuse_mode");

        public void set_diffuse_mode(int diffuse_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_42, Object.GetPtr(this), diffuse_mode);
        }

        private IntPtr method_bind_43 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_diffuse_mode");

        public int get_diffuse_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_43, Object.GetPtr(this));
        }

        private IntPtr method_bind_44 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_specular_mode");

        public void set_specular_mode(int specular_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_44, Object.GetPtr(this), specular_mode);
        }

        private IntPtr method_bind_45 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_specular_mode");

        public int get_specular_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_45, Object.GetPtr(this));
        }

        private IntPtr method_bind_46 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_flag");

        public void set_flag(int flag, bool enable)
        {
            NativeCalls.godot_icall_2_42(method_bind_46, Object.GetPtr(this), flag, enable);
        }

        private IntPtr method_bind_47 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_flag");

        public bool get_flag(int flag)
        {
            return NativeCalls.godot_icall_1_22(method_bind_47, Object.GetPtr(this), flag);
        }

        private IntPtr method_bind_48 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_feature");

        public void set_feature(int feature, bool enable)
        {
            NativeCalls.godot_icall_2_42(method_bind_48, Object.GetPtr(this), feature, enable);
        }

        private IntPtr method_bind_49 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_feature");

        public bool get_feature(int feature)
        {
            return NativeCalls.godot_icall_1_22(method_bind_49, Object.GetPtr(this), feature);
        }

        private IntPtr method_bind_50 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_texture");

        public void set_texture(int param, Texture texture)
        {
            NativeCalls.godot_icall_2_88(method_bind_50, Object.GetPtr(this), param, Object.GetPtr(texture));
        }

        private IntPtr method_bind_51 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_texture");

        public Texture get_texture(int param)
        {
            return NativeCalls.godot_icall_1_108(method_bind_51, Object.GetPtr(this), param);
        }

        private IntPtr method_bind_52 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_detail_blend_mode");

        public void set_detail_blend_mode(int detail_blend_mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_52, Object.GetPtr(this), detail_blend_mode);
        }

        private IntPtr method_bind_53 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_detail_blend_mode");

        public int get_detail_blend_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_53, Object.GetPtr(this));
        }

        private IntPtr method_bind_54 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_uv1_scale");

        public void set_uv1_scale(Vector3 scale)
        {
            NativeCalls.godot_icall_1_83(method_bind_54, Object.GetPtr(this), ref scale);
        }

        private IntPtr method_bind_55 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_uv1_scale");

        public Vector3 get_uv1_scale()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_55, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_56 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_uv1_offset");

        public void set_uv1_offset(Vector3 offset)
        {
            NativeCalls.godot_icall_1_83(method_bind_56, Object.GetPtr(this), ref offset);
        }

        private IntPtr method_bind_57 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_uv1_offset");

        public Vector3 get_uv1_offset()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_57, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_58 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_uv1_triplanar_blend_sharpness");

        public void set_uv1_triplanar_blend_sharpness(float sharpness)
        {
            NativeCalls.godot_icall_1_10(method_bind_58, Object.GetPtr(this), sharpness);
        }

        private IntPtr method_bind_59 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_uv1_triplanar_blend_sharpness");

        public float get_uv1_triplanar_blend_sharpness()
        {
            return NativeCalls.godot_icall_0_11(method_bind_59, Object.GetPtr(this));
        }

        private IntPtr method_bind_60 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_uv2_scale");

        public void set_uv2_scale(Vector3 scale)
        {
            NativeCalls.godot_icall_1_83(method_bind_60, Object.GetPtr(this), ref scale);
        }

        private IntPtr method_bind_61 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_uv2_scale");

        public Vector3 get_uv2_scale()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_61, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_62 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_uv2_offset");

        public void set_uv2_offset(Vector3 offset)
        {
            NativeCalls.godot_icall_1_83(method_bind_62, Object.GetPtr(this), ref offset);
        }

        private IntPtr method_bind_63 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_uv2_offset");

        public Vector3 get_uv2_offset()
        {
            object ret = NativeCalls.godot_icall_0_4(method_bind_63, Object.GetPtr(this));
            return (Vector3)ret;
        }

        private IntPtr method_bind_64 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_uv2_triplanar_blend_sharpness");

        public void set_uv2_triplanar_blend_sharpness(float sharpness)
        {
            NativeCalls.godot_icall_1_10(method_bind_64, Object.GetPtr(this), sharpness);
        }

        private IntPtr method_bind_65 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_uv2_triplanar_blend_sharpness");

        public float get_uv2_triplanar_blend_sharpness()
        {
            return NativeCalls.godot_icall_0_11(method_bind_65, Object.GetPtr(this));
        }

        private IntPtr method_bind_66 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_billboard_mode");

        public void set_billboard_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_66, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_67 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_billboard_mode");

        public int get_billboard_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_67, Object.GetPtr(this));
        }

        private IntPtr method_bind_68 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_particles_anim_h_frames");

        public void set_particles_anim_h_frames(int frames)
        {
            NativeCalls.godot_icall_1_0(method_bind_68, Object.GetPtr(this), frames);
        }

        private IntPtr method_bind_69 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_particles_anim_h_frames");

        public int get_particles_anim_h_frames()
        {
            return NativeCalls.godot_icall_0_1(method_bind_69, Object.GetPtr(this));
        }

        private IntPtr method_bind_70 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_particles_anim_v_frames");

        public void set_particles_anim_v_frames(int frames)
        {
            NativeCalls.godot_icall_1_0(method_bind_70, Object.GetPtr(this), frames);
        }

        private IntPtr method_bind_71 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_particles_anim_v_frames");

        public int get_particles_anim_v_frames()
        {
            return NativeCalls.godot_icall_0_1(method_bind_71, Object.GetPtr(this));
        }

        private IntPtr method_bind_72 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_particles_anim_loop");

        public void set_particles_anim_loop(int frames)
        {
            NativeCalls.godot_icall_1_0(method_bind_72, Object.GetPtr(this), frames);
        }

        private IntPtr method_bind_73 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_particles_anim_loop");

        public int get_particles_anim_loop()
        {
            return NativeCalls.godot_icall_0_1(method_bind_73, Object.GetPtr(this));
        }

        private IntPtr method_bind_74 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_depth_deep_parallax");

        public void set_depth_deep_parallax(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_74, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_75 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_depth_deep_parallax_enabled");

        public bool is_depth_deep_parallax_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_75, Object.GetPtr(this));
        }

        private IntPtr method_bind_76 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_depth_deep_parallax_min_layers");

        public void set_depth_deep_parallax_min_layers(int layer)
        {
            NativeCalls.godot_icall_1_0(method_bind_76, Object.GetPtr(this), layer);
        }

        private IntPtr method_bind_77 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_depth_deep_parallax_min_layers");

        public int get_depth_deep_parallax_min_layers()
        {
            return NativeCalls.godot_icall_0_1(method_bind_77, Object.GetPtr(this));
        }

        private IntPtr method_bind_78 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_depth_deep_parallax_max_layers");

        public void set_depth_deep_parallax_max_layers(int layer)
        {
            NativeCalls.godot_icall_1_0(method_bind_78, Object.GetPtr(this), layer);
        }

        private IntPtr method_bind_79 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_depth_deep_parallax_max_layers");

        public int get_depth_deep_parallax_max_layers()
        {
            return NativeCalls.godot_icall_0_1(method_bind_79, Object.GetPtr(this));
        }

        private IntPtr method_bind_80 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_grow");

        public void set_grow(float amount)
        {
            NativeCalls.godot_icall_1_10(method_bind_80, Object.GetPtr(this), amount);
        }

        private IntPtr method_bind_81 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_grow");

        public float get_grow()
        {
            return NativeCalls.godot_icall_0_11(method_bind_81, Object.GetPtr(this));
        }

        private IntPtr method_bind_82 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_alpha_scissor_threshold");

        public void set_alpha_scissor_threshold(float threshold)
        {
            NativeCalls.godot_icall_1_10(method_bind_82, Object.GetPtr(this), threshold);
        }

        private IntPtr method_bind_83 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_alpha_scissor_threshold");

        public float get_alpha_scissor_threshold()
        {
            return NativeCalls.godot_icall_0_11(method_bind_83, Object.GetPtr(this));
        }

        private IntPtr method_bind_84 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_grow_enabled");

        public void set_grow_enabled(bool enable)
        {
            NativeCalls.godot_icall_1_7(method_bind_84, Object.GetPtr(this), enable);
        }

        private IntPtr method_bind_85 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_grow_enabled");

        public bool is_grow_enabled()
        {
            return NativeCalls.godot_icall_0_3(method_bind_85, Object.GetPtr(this));
        }

        private IntPtr method_bind_86 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_metallic_texture_channel");

        public void set_metallic_texture_channel(int channel)
        {
            NativeCalls.godot_icall_1_0(method_bind_86, Object.GetPtr(this), channel);
        }

        private IntPtr method_bind_87 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_metallic_texture_channel");

        public int get_metallic_texture_channel()
        {
            return NativeCalls.godot_icall_0_1(method_bind_87, Object.GetPtr(this));
        }

        private IntPtr method_bind_88 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_roughness_texture_channel");

        public void set_roughness_texture_channel(int channel)
        {
            NativeCalls.godot_icall_1_0(method_bind_88, Object.GetPtr(this), channel);
        }

        private IntPtr method_bind_89 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_roughness_texture_channel");

        public int get_roughness_texture_channel()
        {
            return NativeCalls.godot_icall_0_1(method_bind_89, Object.GetPtr(this));
        }

        private IntPtr method_bind_90 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_ao_texture_channel");

        public void set_ao_texture_channel(int channel)
        {
            NativeCalls.godot_icall_1_0(method_bind_90, Object.GetPtr(this), channel);
        }

        private IntPtr method_bind_91 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_ao_texture_channel");

        public int get_ao_texture_channel()
        {
            return NativeCalls.godot_icall_0_1(method_bind_91, Object.GetPtr(this));
        }

        private IntPtr method_bind_92 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_refraction_texture_channel");

        public void set_refraction_texture_channel(int channel)
        {
            NativeCalls.godot_icall_1_0(method_bind_92, Object.GetPtr(this), channel);
        }

        private IntPtr method_bind_93 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_refraction_texture_channel");

        public int get_refraction_texture_channel()
        {
            return NativeCalls.godot_icall_0_1(method_bind_93, Object.GetPtr(this));
        }
    }
}
