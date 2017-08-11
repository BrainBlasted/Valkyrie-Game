using System;

namespace GodotEngine
{
    public class ViewportTexture : Texture
    {
        private const string nativeName = "ViewportTexture";

        public ViewportTexture() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ViewportTexture_Ctor(this);
        }

        internal ViewportTexture(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_viewport_path_in_scene");

        public void set_viewport_path_in_scene(NodePath path)
        {
            NativeCalls.godot_icall_1_65(method_bind_0, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_viewport_path_in_scene");

        public NodePath get_viewport_path_in_scene()
        {
            IntPtr ret = NativeCalls.godot_icall_0_66(method_bind_1, Object.GetPtr(this));
            return new NodePath(ret);
        }
    }
}
