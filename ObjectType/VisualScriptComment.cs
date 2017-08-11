using System;

namespace GodotEngine
{
    public class VisualScriptComment : VisualScriptNode
    {
        private const string nativeName = "VisualScriptComment";

        public VisualScriptComment() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptComment_Ctor(this);
        }

        internal VisualScriptComment(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_title");

        public void set_title(string title)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), title);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_title");

        public string get_title()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_description");

        public void set_description(string description)
        {
            NativeCalls.godot_icall_1_35(method_bind_2, Object.GetPtr(this), description);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_description");

        public string get_description()
        {
            return NativeCalls.godot_icall_0_2(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_size");

        public void set_size(Vector2 size)
        {
            NativeCalls.godot_icall_1_37(method_bind_4, Object.GetPtr(this), ref size);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_size");

        public Vector2 get_size()
        {
            object ret = NativeCalls.godot_icall_0_9(method_bind_5, Object.GetPtr(this));
            return (Vector2)ret;
        }
    }
}
