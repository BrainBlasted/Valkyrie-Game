using System;

namespace GodotEngine
{
    /// <summary>
    /// Simple tabs control, similar to [TabContainer] but is only in charge of drawing tabs, not interact with children.
    /// </summary>
    public class Tabs : Control
    {
        public const int ALIGN_LEFT = 0;
        public const int ALIGN_CENTER = 1;
        public const int ALIGN_RIGHT = 2;
        public const int ALIGN_MAX = 3;
        public const int CLOSE_BUTTON_SHOW_ACTIVE_ONLY = 1;
        public const int CLOSE_BUTTON_SHOW_ALWAYS = 2;
        public const int CLOSE_BUTTON_SHOW_NEVER = 0;
        public const int CLOSE_BUTTON_MAX = 3;

        private const string nativeName = "Tabs";

        public Tabs() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Tabs_Ctor(this);
        }

        internal Tabs(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tab_count");

        public int get_tab_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_0, Object.GetPtr(this));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_current_tab");

        public void set_current_tab(int tab_idx)
        {
            NativeCalls.godot_icall_1_0(method_bind_1, Object.GetPtr(this), tab_idx);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_current_tab");

        public int get_current_tab()
        {
            return NativeCalls.godot_icall_0_1(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tab_title");

        public void set_tab_title(int tab_idx, string title)
        {
            NativeCalls.godot_icall_2_68(method_bind_3, Object.GetPtr(this), tab_idx, title);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tab_title");

        public string get_tab_title(int tab_idx)
        {
            return NativeCalls.godot_icall_1_86(method_bind_4, Object.GetPtr(this), tab_idx);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tab_icon");

        public void set_tab_icon(int tab_idx, Texture icon)
        {
            NativeCalls.godot_icall_2_88(method_bind_5, Object.GetPtr(this), tab_idx, Object.GetPtr(icon));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tab_icon");

        public Texture get_tab_icon(int tab_idx)
        {
            return NativeCalls.godot_icall_1_108(method_bind_6, Object.GetPtr(this), tab_idx);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tab_disabled");

        public void set_tab_disabled(int tab_idx, bool disabled)
        {
            NativeCalls.godot_icall_2_42(method_bind_7, Object.GetPtr(this), tab_idx, disabled);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tab_disabled");

        public bool get_tab_disabled(int tab_idx)
        {
            return NativeCalls.godot_icall_1_22(method_bind_8, Object.GetPtr(this), tab_idx);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "remove_tab");

        public void remove_tab(int tab_idx)
        {
            NativeCalls.godot_icall_1_0(method_bind_9, Object.GetPtr(this), tab_idx);
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_tab");

        public void add_tab(string title = "", Texture icon = null)
        {
            NativeCalls.godot_icall_2_72(method_bind_10, Object.GetPtr(this), title, Object.GetPtr(icon));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tab_align");

        public void set_tab_align(int align)
        {
            NativeCalls.godot_icall_1_0(method_bind_11, Object.GetPtr(this), align);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tab_align");

        public int get_tab_align()
        {
            return NativeCalls.godot_icall_0_1(method_bind_12, Object.GetPtr(this));
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "ensure_tab_visible");

        public void ensure_tab_visible(int idx)
        {
            NativeCalls.godot_icall_1_0(method_bind_13, Object.GetPtr(this), idx);
        }

        private IntPtr method_bind_14 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tab_rect");

        /// <summary>
        /// Returns tab [Rect2] with local position and size.
        /// </summary>
        public Rect2 get_tab_rect(int tab_idx)
        {
            object ret = NativeCalls.godot_icall_1_263(method_bind_14, Object.GetPtr(this), tab_idx);
            return (Rect2)ret;
        }

        private IntPtr method_bind_15 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "move_tab");

        /// <summary>
        /// Rearrange tab.
        /// </summary>
        public void move_tab(int from, int to)
        {
            NativeCalls.godot_icall_2_24(method_bind_15, Object.GetPtr(this), from, to);
        }

        private IntPtr method_bind_16 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_tab_close_display_policy");

        public void set_tab_close_display_policy(int policy)
        {
            NativeCalls.godot_icall_1_0(method_bind_16, Object.GetPtr(this), policy);
        }

        private IntPtr method_bind_17 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_tab_close_display_policy");

        public int get_tab_close_display_policy()
        {
            return NativeCalls.godot_icall_0_1(method_bind_17, Object.GetPtr(this));
        }
    }
}
