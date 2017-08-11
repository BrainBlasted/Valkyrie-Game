using System;

namespace GodotEngine
{
    /// <summary>
    /// Sprite frame library for [AnimatedSprite].
    /// </summary>
    public class SpriteFrames : Resource
    {
        private const string nativeName = "SpriteFrames";

        public SpriteFrames() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_SpriteFrames_Ctor(this);
        }

        internal SpriteFrames(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_animation");

        public void add_animation(string anim)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), anim);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_animation");

        public bool has_animation(string anim)
        {
            return NativeCalls.godot_icall_1_57(method_bind_1, Object.GetPtr(this), anim);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_animation");

        public void remove_animation(string anim)
        {
            NativeCalls.godot_icall_1_35(method_bind_2, Object.GetPtr(this), anim);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "rename_animation");

        public void rename_animation(string anim, string newname)
        {
            NativeCalls.godot_icall_2_56(method_bind_3, Object.GetPtr(this), anim, newname);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_animation_speed");

        public void set_animation_speed(string anim, float speed)
        {
            NativeCalls.godot_icall_2_64(method_bind_4, Object.GetPtr(this), anim, speed);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_animation_speed");

        public float get_animation_speed(string anim)
        {
            return NativeCalls.godot_icall_1_75(method_bind_5, Object.GetPtr(this), anim);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_animation_loop");

        public void set_animation_loop(string anim, bool loop)
        {
            NativeCalls.godot_icall_2_76(method_bind_6, Object.GetPtr(this), anim, loop);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_animation_loop");

        public bool get_animation_loop(string anim)
        {
            return NativeCalls.godot_icall_1_57(method_bind_7, Object.GetPtr(this), anim);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_frame");

        public void add_frame(string anim, Texture frame, int atpos = -1)
        {
            NativeCalls.godot_icall_3_441(method_bind_8, Object.GetPtr(this), anim, Object.GetPtr(frame), atpos);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_frame_count");

        public int get_frame_count(string anim)
        {
            return NativeCalls.godot_icall_1_71(method_bind_9, Object.GetPtr(this), anim);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_frame");

        public Texture get_frame(string anim, int idx)
        {
            return NativeCalls.godot_icall_2_442(method_bind_10, Object.GetPtr(this), anim, idx);
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_frame");

        public void set_frame(string anim, int idx, Texture txt)
        {
            NativeCalls.godot_icall_3_443(method_bind_11, Object.GetPtr(this), anim, idx, Object.GetPtr(txt));
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_frame");

        public void remove_frame(string anim, int idx)
        {
            NativeCalls.godot_icall_2_79(method_bind_12, Object.GetPtr(this), anim, idx);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear");

        public void clear(string anim)
        {
            NativeCalls.godot_icall_1_35(method_bind_13, Object.GetPtr(this), anim);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "clear_all");

        public void clear_all()
        {
            NativeCalls.godot_icall_0_8(method_bind_14, Object.GetPtr(this));
        }
    }
}
