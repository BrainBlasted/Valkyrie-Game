using System;

namespace GodotEngine
{
    /// <summary>
    /// Translations are resources that can be loaded/unloaded on demand. They map a string to another string.
    /// </summary>
    public class Translation : Resource
    {
        private const string nativeName = "Translation";

        public Translation() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_Translation_Ctor(this);
        }

        internal Translation(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_locale");

        /// <summary>
        /// Set the locale of the translation.
        /// </summary>
        public void set_locale(string locale)
        {
            NativeCalls.godot_icall_1_34(method_bind_0, Object.GetPtr(this), locale);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_locale");

        /// <summary>
        /// Return the locale of the translation.
        /// </summary>
        public string get_locale()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "add_message");

        /// <summary>
        /// Add a message for translation.
        /// </summary>
        public void add_message(string src_message, string xlated_message)
        {
            NativeCalls.godot_icall_2_55(method_bind_2, Object.GetPtr(this), src_message, xlated_message);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_message");

        /// <summary>
        /// Return a message for translation.
        /// </summary>
        public string get_message(string src_message)
        {
            return NativeCalls.godot_icall_1_59(method_bind_3, Object.GetPtr(this), src_message);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "erase_message");

        /// <summary>
        /// Erase a message.
        /// </summary>
        public void erase_message(string src_message)
        {
            NativeCalls.godot_icall_1_34(method_bind_4, Object.GetPtr(this), src_message);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_message_list");

        /// <summary>
        /// Return all the messages (keys).
        /// </summary>
        public string[] get_message_list()
        {
            return NativeCalls.godot_icall_0_58(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_message_count");

        public int get_message_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_6, Object.GetPtr(this));
        }
    }
}
