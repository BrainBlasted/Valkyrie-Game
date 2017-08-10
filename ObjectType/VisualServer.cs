using System;

namespace GodotEngine
{
    /// <summary>
    /// Server for anything visible. The visual server is the API backend for everything visible. The whole scene system mounts on it to display.
    /// The visual server is completely opaque, the internals are entirely implementation specific and cannot be accessed.
    /// </summary>
    public static class VisualServer
    {
        private const string nativeName = "VisualServer";
        internal static IntPtr ptr = NativeCalls.godot_icall_VisualServer_get_singleton();

        private static IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "texture_create");

        public static RID texture_create()
        {
            IntPtr ret = NativeCalls.godot_icall_0_121(method_bind_0, ptr);
            return new RID(ret);
        }

        private static IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "texture_create_from_image");

        public static RID texture_create_from_image(Image image, int flags = 7)
        {
            IntPtr ret = NativeCalls.godot_icall_2_519(method_bind_1, ptr, Object.GetPtr(image), flags);
            return new RID(ret);
        }

        private static IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "texture_set_flags");

        public static void texture_set_flags(RID texture, int arg1)
        {
            NativeCalls.godot_icall_2_358(method_bind_2, ptr, RID.GetPtr(texture), arg1);
        }

        private static IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "texture_get_flags");

        public static int texture_get_flags(RID texture)
        {
            return NativeCalls.godot_icall_1_349(method_bind_3, ptr, RID.GetPtr(texture));
        }

        private static IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "texture_get_width");

        public static int texture_get_width(RID texture)
        {
            return NativeCalls.godot_icall_1_349(method_bind_4, ptr, RID.GetPtr(texture));
        }

        private static IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "texture_get_height");

        public static int texture_get_height(RID texture)
        {
            return NativeCalls.godot_icall_1_349(method_bind_5, ptr, RID.GetPtr(texture));
        }

        private static IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "texture_set_shrink_all_x2_on_set_data");

        public static void texture_set_shrink_all_x2_on_set_data(bool shrink)
        {
            NativeCalls.godot_icall_1_7(method_bind_6, ptr, shrink);
        }
    }
}
