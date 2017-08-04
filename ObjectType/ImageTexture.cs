using System;

namespace GodotEngine
{
    /// <summary>
    /// A [Texture] based on an [Image]. Can be created from an [Image].
    /// </summary>
    public class ImageTexture : Texture
    {
        /// <summary>
        /// [Image] data is stored raw and unaltered.
        /// </summary>
        public const int STORAGE_RAW = 0;
        /// <summary>
        /// [Image] data is compressed with a lossy algorithm. You can set the storage quality with [method set_lossy_storage_quality].
        /// </summary>
        public const int STORAGE_COMPRESS_LOSSY = 1;
        /// <summary>
        /// [Image] data is compressed with a lossless algorithm.
        /// </summary>
        public const int STORAGE_COMPRESS_LOSSLESS = 2;

        private const string nativeName = "ImageTexture";

        public ImageTexture() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ImageTexture_Ctor(this);
        }

        internal ImageTexture(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create");

        /// <summary>
        /// Create a new [ImageTexture] with "width" and "height".
        /// "format" one of [Image].FORMAT_*.
        /// "flags" one or more of [Texture].FLAG_*.
        /// </summary>
        public void create(int width, int height, int format, int flags = 7)
        {
            NativeCalls.godot_icall_4_247(method_bind_0, Object.GetPtr(this), width, height, format, flags);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "create_from_image");

        /// <summary>
        /// Create a new [ImageTexture] from an [Image] with "flags" from [Texture].FLAG_*.
        /// </summary>
        public void create_from_image(Image image, int flags = 7)
        {
            NativeCalls.godot_icall_2_248(method_bind_1, Object.GetPtr(this), Object.GetPtr(image), flags);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_format");

        /// <summary>
        /// Return the format of the [ImageTexture], one of [Image].FORMAT_*.
        /// </summary>
        public int get_format()
        {
            return NativeCalls.godot_icall_0_1(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "load");

        /// <summary>
        /// Load an [ImageTexure].
        /// </summary>
        public void load(string path)
        {
            NativeCalls.godot_icall_1_34(method_bind_3, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_data");

        /// <summary>
        /// Set the [Image] of this [ImageTexture].
        /// </summary>
        public void set_data(Image image)
        {
            NativeCalls.godot_icall_1_35(method_bind_4, Object.GetPtr(this), Object.GetPtr(image));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_data");

        /// <summary>
        /// Return the [Image] of this [ImageTexture].
        /// </summary>
        public Image get_data()
        {
            return NativeCalls.godot_icall_0_249(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_storage");

        /// <summary>
        /// Set the storage type. One of [ImageTexture].STORAGE_*.
        /// </summary>
        public void set_storage(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_6, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_storage");

        /// <summary>
        /// Return the storage type. One of [ImageTexture].STORAGE_*.
        /// </summary>
        public int get_storage()
        {
            return NativeCalls.godot_icall_0_1(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_lossy_storage_quality");

        /// <summary>
        /// Set the storage quality in case of [ImageTexture].STORAGE_COMPRESS_LOSSY.
        /// </summary>
        public void set_lossy_storage_quality(float quality)
        {
            NativeCalls.godot_icall_1_10(method_bind_8, Object.GetPtr(this), quality);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_lossy_storage_quality");

        /// <summary>
        /// Return the storage quality for [ImageTexture].STORAGE_COMPRESS_LOSSY.
        /// </summary>
        public float get_lossy_storage_quality()
        {
            return NativeCalls.godot_icall_0_11(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_size_override");

        public void set_size_override(Vector2 size)
        {
            NativeCalls.godot_icall_1_37(method_bind_10, Object.GetPtr(this), ref size);
        }
    }
}
