using System;

namespace GodotEngine
{
    /// <summary>
    /// Native image datatype. Contains image data, which can be converted to a texture, and several functions to interact with it.
    /// </summary>
    public class Image : Resource
    {
        public const int FORMAT_L8 = 0;
        public const int FORMAT_LA8 = 1;
        public const int FORMAT_R8 = 2;
        public const int FORMAT_RG8 = 3;
        public const int FORMAT_RGB8 = 4;
        public const int FORMAT_RGBA8 = 5;
        public const int FORMAT_RGBA4444 = 6;
        public const int FORMAT_RGBA5551 = 7;
        public const int FORMAT_RF = 8;
        public const int FORMAT_RGF = 9;
        public const int FORMAT_RGBF = 10;
        public const int FORMAT_RGBAF = 11;
        public const int FORMAT_RH = 12;
        public const int FORMAT_RGH = 13;
        public const int FORMAT_RGBH = 14;
        public const int FORMAT_RGBAH = 15;
        public const int FORMAT_RGBE9995 = 16;
        public const int FORMAT_DXT1 = 17;
        public const int FORMAT_DXT3 = 18;
        public const int FORMAT_DXT5 = 19;
        public const int FORMAT_RGTC_R = 20;
        public const int FORMAT_RGTC_RG = 21;
        public const int FORMAT_BPTC_RGBA = 22;
        public const int FORMAT_BPTC_RGBF = 23;
        public const int FORMAT_BPTC_RGBFU = 24;
        public const int FORMAT_PVRTC2 = 25;
        public const int FORMAT_PVRTC2A = 26;
        public const int FORMAT_PVRTC4 = 27;
        public const int FORMAT_PVRTC4A = 28;
        public const int FORMAT_ETC = 29;
        public const int FORMAT_ETC2_R11 = 30;
        public const int FORMAT_ETC2_R11S = 31;
        public const int FORMAT_ETC2_RG11 = 32;
        public const int FORMAT_ETC2_RG11S = 33;
        public const int FORMAT_ETC2_RGB8 = 34;
        public const int FORMAT_ETC2_RGBA8 = 35;
        public const int FORMAT_ETC2_RGB8A1 = 36;
        public const int FORMAT_MAX = 37;
        public const int INTERPOLATE_NEAREST = 0;
        public const int INTERPOLATE_BILINEAR = 1;
        public const int INTERPOLATE_CUBIC = 2;
        public const int ALPHA_NONE = 0;
        public const int ALPHA_BIT = 1;
        public const int ALPHA_BLEND = 2;
        public const int COMPRESS_S3TC = 0;
        public const int COMPRESS_PVRTC2 = 1;
        public const int COMPRESS_PVRTC4 = 2;
        public const int COMPRESS_ETC = 3;
        public const int COMPRESS_ETC2 = 4;
        public const int COMPRESS_SOURCE_GENERIC = 0;
        public const int COMPRESS_SOURCE_SRGB = 1;
        public const int COMPRESS_SOURCE_NORMAL = 2;

        private const string nativeName = "Image";

        public Image() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Image_Ctor(this);
        }

        internal Image(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_width");

        /// <summary>
        /// Return the width of the [Image].
        /// </summary>
        public int get_width()
        {
            return NativeCalls.godot_icall_0_1(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_height");

        /// <summary>
        /// Return the height of the [Image].
        /// </summary>
        public int get_height()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_mipmaps");

        public bool has_mipmaps()
        {
            return NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_format");

        /// <summary>
        /// Return the format of the [Image], one of [Image].FORMAT_*.
        /// </summary>
        public int get_format()
        {
            return NativeCalls.godot_icall_0_1(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_data");

        /// <summary>
        /// Return the raw data of the [Image].
        /// </summary>
        public byte[] get_data()
        {
            return NativeCalls.godot_icall_0_101(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "convert");

        public void convert(int format)
        {
            NativeCalls.godot_icall_1_0(method_bind_5, Object.GetPtr(this), format);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_mipmap_offset");

        public int get_mipmap_offset(int mipmap)
        {
            return NativeCalls.godot_icall_1_5(method_bind_6, Object.GetPtr(this), mipmap);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "resize_to_po2");

        public void resize_to_po2(bool square = false)
        {
            NativeCalls.godot_icall_1_7(method_bind_7, Object.GetPtr(this), square);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "resize");

        public void resize(int width, int height, int interpolation = 1)
        {
            NativeCalls.godot_icall_3_98(method_bind_8, Object.GetPtr(this), width, height, interpolation);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "shrink_x2");

        public void shrink_x2()
        {
            NativeCalls.godot_icall_0_8(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "expand_x2_hq2x");

        public void expand_x2_hq2x()
        {
            NativeCalls.godot_icall_0_8(method_bind_10, Object.GetPtr(this));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "crop");

        public void crop(int width, int height)
        {
            NativeCalls.godot_icall_2_24(method_bind_11, Object.GetPtr(this), width, height);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "flip_x");

        public void flip_x()
        {
            NativeCalls.godot_icall_0_8(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "flip_y");

        public void flip_y()
        {
            NativeCalls.godot_icall_0_8(method_bind_13, Object.GetPtr(this));
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "generate_mipmaps");

        public int generate_mipmaps()
        {
            return NativeCalls.godot_icall_0_1(method_bind_14, Object.GetPtr(this));
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear_mipmaps");

        public void clear_mipmaps()
        {
            NativeCalls.godot_icall_0_8(method_bind_15, Object.GetPtr(this));
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create");

        /// <summary>
        /// Create an empty image of a specific size and format.
        /// </summary>
        public void create(int width, int height, bool use_mipmaps, int format)
        {
            NativeCalls.godot_icall_4_237(method_bind_16, Object.GetPtr(this), width, height, use_mipmaps, format);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_from_data");

        public void create_from_data(int width, int height, bool use_mipmaps, int format, byte[] data)
        {
            NativeCalls.godot_icall_5_238(method_bind_17, Object.GetPtr(this), width, height, use_mipmaps, format, data);
        }

        private IntPtr method_bind_18 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_empty");

        public bool is_empty()
        {
            return NativeCalls.godot_icall_0_3(method_bind_18, Object.GetPtr(this));
        }

        private IntPtr method_bind_19 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "load");

        /// <summary>
        /// Load an [Image].
        /// </summary>
        public int load(string path)
        {
            return NativeCalls.godot_icall_1_71(method_bind_19, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_20 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "save_png");

        /// <summary>
        /// Save this [Image] as a png.
        /// </summary>
        public int save_png(string path)
        {
            return NativeCalls.godot_icall_1_71(method_bind_20, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_21 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "detect_alpha");

        public int detect_alpha()
        {
            return NativeCalls.godot_icall_0_1(method_bind_21, Object.GetPtr(this));
        }

        private IntPtr method_bind_22 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_invisible");

        public bool is_invisible()
        {
            return NativeCalls.godot_icall_0_3(method_bind_22, Object.GetPtr(this));
        }

        private IntPtr method_bind_23 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "compress");

        public int compress(int mode, int source, float lossy_quality)
        {
            return NativeCalls.godot_icall_3_239(method_bind_23, Object.GetPtr(this), mode, source, lossy_quality);
        }

        private IntPtr method_bind_24 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "decompress");

        public int decompress()
        {
            return NativeCalls.godot_icall_0_1(method_bind_24, Object.GetPtr(this));
        }

        private IntPtr method_bind_25 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_compressed");

        public bool is_compressed()
        {
            return NativeCalls.godot_icall_0_3(method_bind_25, Object.GetPtr(this));
        }

        private IntPtr method_bind_26 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "fix_alpha_edges");

        public void fix_alpha_edges()
        {
            NativeCalls.godot_icall_0_8(method_bind_26, Object.GetPtr(this));
        }

        private IntPtr method_bind_27 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "premultiply_alpha");

        public void premultiply_alpha()
        {
            NativeCalls.godot_icall_0_8(method_bind_27, Object.GetPtr(this));
        }

        private IntPtr method_bind_28 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "srgb_to_linear");

        public void srgb_to_linear()
        {
            NativeCalls.godot_icall_0_8(method_bind_28, Object.GetPtr(this));
        }

        private IntPtr method_bind_29 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "normalmap_to_xy");

        public void normalmap_to_xy()
        {
            NativeCalls.godot_icall_0_8(method_bind_29, Object.GetPtr(this));
        }

        private IntPtr method_bind_30 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "blit_rect");

        /// <summary>
        /// Copy a "src_rect" [Rect2] from "src" [Image] to this [Image] on coordinates "dest".
        /// </summary>
        public void blit_rect(Image src, Rect2 src_rect, Vector2 dst)
        {
            NativeCalls.godot_icall_3_240(method_bind_30, Object.GetPtr(this), Object.GetPtr(src), ref src_rect, ref dst);
        }

        private IntPtr method_bind_31 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "blit_rect_mask");

        /// <summary>
        /// Blits a "src_rect" [Rect2] from "src" [Image] to this [Image] using a "mask" [Image] on coordinates "dest". Alpha channel is required for "mask", will copy src pixel onto dest if the corresponding mask pixel's alpha value is not 0. "src" [Image] and "mask" [Image] *must* have the same size (width and height) but they can have different formats
        /// </summary>
        public void blit_rect_mask(Image src, Image mask, Rect2 src_rect, Vector2 dst)
        {
            NativeCalls.godot_icall_4_241(method_bind_31, Object.GetPtr(this), Object.GetPtr(src), Object.GetPtr(mask), ref src_rect, ref dst);
        }

        private IntPtr method_bind_32 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "blend_rect");

        /// <summary>
        /// Alpha-blends a "src_rect" [Rect2] from "src" [Image] to this [Image] on coordinates "dest".
        /// </summary>
        public void blend_rect(Image src, Rect2 src_rect, Vector2 dst)
        {
            NativeCalls.godot_icall_3_240(method_bind_32, Object.GetPtr(this), Object.GetPtr(src), ref src_rect, ref dst);
        }

        private IntPtr method_bind_33 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "blend_rect_mask");

        /// <summary>
        /// Alpha-blends a "src_rect" [Rect2] from "src" [Image] to this [Image] using a "mask" [Image] on coordinates "dest". Alpha channels are required for both "src" and "mask", dest pixels and src pixels will blend if the corresponding mask pixel's alpha value is not 0. "src" [Image] and "mask" [Image] *must* have the same size (width and height) but they can have different formats
        /// </summary>
        public void blend_rect_mask(Image src, Image mask, Rect2 src_rect, Vector2 dst)
        {
            NativeCalls.godot_icall_4_241(method_bind_33, Object.GetPtr(this), Object.GetPtr(src), Object.GetPtr(mask), ref src_rect, ref dst);
        }

        private IntPtr method_bind_34 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "fill");

        /// <summary>
        /// Fills an [Image] with a specified [Color]
        /// </summary>
        public void fill(Color color)
        {
            NativeCalls.godot_icall_1_123(method_bind_34, Object.GetPtr(this), ref color);
        }

        private IntPtr method_bind_35 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_used_rect");

        /// <summary>
        /// Return the area of this [Image] that is used/visibly colored/opaque.
        /// </summary>
        public Rect2 get_used_rect()
        {
            object ret = NativeCalls.godot_icall_0_95(method_bind_35, Object.GetPtr(this));
            return (Rect2)ret;
        }

        private IntPtr method_bind_36 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_rect");

        /// <summary>
        /// Return a new [Image] that is a copy of "area" in this [Image].
        /// </summary>
        public Image get_rect(Rect2 rect)
        {
            return NativeCalls.godot_icall_1_242(method_bind_36, Object.GetPtr(this), ref rect);
        }

        private IntPtr method_bind_37 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "copy_from");

        public void copy_from(Image src)
        {
            NativeCalls.godot_icall_1_19(method_bind_37, Object.GetPtr(this), Object.GetPtr(src));
        }

        private IntPtr method_bind_38 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "lock");

        public void @lock()
        {
            NativeCalls.godot_icall_0_8(method_bind_38, Object.GetPtr(this));
        }

        private IntPtr method_bind_39 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "unlock");

        public void unlock()
        {
            NativeCalls.godot_icall_0_8(method_bind_39, Object.GetPtr(this));
        }

        private IntPtr method_bind_40 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_pixel");

        public void set_pixel(int x, int y, Color color)
        {
            NativeCalls.godot_icall_3_243(method_bind_40, Object.GetPtr(this), x, y, ref color);
        }

        private IntPtr method_bind_41 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_pixel");

        public Color get_pixel(int x, int y)
        {
            object ret = NativeCalls.godot_icall_2_244(method_bind_41, Object.GetPtr(this), x, y);
            return (Color)ret;
        }
    }
}
