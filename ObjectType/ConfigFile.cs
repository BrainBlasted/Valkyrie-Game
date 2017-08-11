using System;

namespace GodotEngine
{
    /// <summary>
    /// This helper class can be used to store [Variant] values on the filesystem using an INI-style formatting. The stored values as referenced by a section and a key. The stored data can be saved to or parsed from a file, though ConfigFile objects can also be used directly with accessing the filesystem.
    /// The following example shows how to parse a INI-style file from the system, read its contents and store new values in it:
    /// [codeblock]
    /// var config = ConfigFile.new()
    /// var err = config.load("user://settings.cfg")
    /// if err == OK: # if not, something went wrong with the file loading
    /// # Look for the display/width pair, and default to 1024 if missing
    /// var screen_width = get_value("display", "width", 1024)
    /// # Store a variable if and only it hasn't been defined yet
    /// if not config.has_section_key("audio", "mute"):
    /// config.set_value("audio", "mute", false)
    /// # Save the changes by overwriting the previous file
    /// config.save("user://settings.cfg")
    /// [/codeblock]
    /// </summary>
    public class ConfigFile : Reference
    {
        private const string nativeName = "ConfigFile";

        public ConfigFile() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ConfigFile_Ctor(this);
        }

        internal ConfigFile(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_value");

        /// <summary>
        /// Assign a value to the specified key of the the specified section. If the section and/or the key do not exist, they are created. Passing a [code]NULL[/code] value deletes the specified key if it exists (and deletes the section if it ends up empty once the key has been removed).
        /// </summary>
        public void set_value(string section, string key, object value)
        {
            NativeCalls.godot_icall_3_161(method_bind_0, Object.GetPtr(this), section, key, value);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_value");

        /// <summary>
        /// Return the current value for the specified section and key. If the section and/or the key do not exist, the method returns the value of the optional [i]default[/i] argument (and thus [code]NULL[/code] if not specified).
        /// </summary>
        public object get_value(string section, string key, object @default = null)
        {
            return NativeCalls.godot_icall_3_162(method_bind_1, Object.GetPtr(this), section, key, @default);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_section");

        /// <summary>
        /// Check if the specified section exists.
        /// </summary>
        public bool has_section(string section)
        {
            return NativeCalls.godot_icall_1_57(method_bind_2, Object.GetPtr(this), section);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "has_section_key");

        /// <summary>
        /// Check if the specified section-key pair exists.
        /// </summary>
        public bool has_section_key(string section, string key)
        {
            return NativeCalls.godot_icall_2_163(method_bind_3, Object.GetPtr(this), section, key);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_sections");

        /// <summary>
        /// Return an array of all defined section identifiers.
        /// </summary>
        public string[] get_sections()
        {
            return NativeCalls.godot_icall_0_59(method_bind_4, Object.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_section_keys");

        /// <summary>
        /// Return an array of all defined key identifiers in the specified section.
        /// </summary>
        public string[] get_section_keys(string section)
        {
            return NativeCalls.godot_icall_1_164(method_bind_5, Object.GetPtr(this), section);
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "erase_section");

        public void erase_section(string section)
        {
            NativeCalls.godot_icall_1_35(method_bind_6, Object.GetPtr(this), section);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "load");

        /// <summary>
        /// Load the config file specified as a parameter. The file's contents are parsed and loaded in the ConfigFile object from which the method was called. The return value is one of the OK, FAILED or ERR_* constants listed in [@Global Scope] (if the load was successful, it returns OK).
        /// </summary>
        public int load(string path)
        {
            return NativeCalls.godot_icall_1_71(method_bind_7, Object.GetPtr(this), path);
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "save");

        /// <summary>
        /// Save the contents of the ConfigFile object to the file specified as a parameter. The output file uses an INI-style structure.
        /// The return value is one of the OK, FAILED or ERR_* constants listed in [@Global Scope] (if the save was successful, it returns OK).
        /// </summary>
        public int save(string path)
        {
            return NativeCalls.godot_icall_1_71(method_bind_8, Object.GetPtr(this), path);
        }
    }
}
