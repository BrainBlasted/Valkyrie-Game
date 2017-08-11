using System;

namespace GodotEngine
{
    public class VisualScriptPropertyGet : VisualScriptNode
    {
        public const int CALL_MODE_SELF = 0;
        public const int CALL_MODE_NODE_PATH = 1;
        public const int CALL_MODE_INSTANCE = 2;

        private const string nativeName = "VisualScriptPropertyGet";

        public VisualScriptPropertyGet() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptPropertyGet_Ctor(this);
        }

        internal VisualScriptPropertyGet(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_base_type");

        public void set_base_type(string base_type)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), base_type);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_base_type");

        public string get_base_type()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_base_script");

        public void set_base_script(string base_script)
        {
            NativeCalls.godot_icall_1_35(method_bind_2, Object.GetPtr(this), base_script);
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_base_script");

        public string get_base_script()
        {
            return NativeCalls.godot_icall_0_2(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_basic_type");

        public void set_basic_type(int basic_type)
        {
            NativeCalls.godot_icall_1_0(method_bind_4, Object.GetPtr(this), basic_type);
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_basic_type");

        public int get_basic_type()
        {
            return NativeCalls.godot_icall_0_1(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_property");

        public void set_property(string property)
        {
            NativeCalls.godot_icall_1_35(method_bind_6, Object.GetPtr(this), property);
        }

        private IntPtr method_bind_7 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_property");

        public string get_property()
        {
            return NativeCalls.godot_icall_0_2(method_bind_7, Object.GetPtr(this));
        }

        private IntPtr method_bind_8 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_call_mode");

        public void set_call_mode(int mode)
        {
            NativeCalls.godot_icall_1_0(method_bind_8, Object.GetPtr(this), mode);
        }

        private IntPtr method_bind_9 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_call_mode");

        public int get_call_mode()
        {
            return NativeCalls.godot_icall_0_1(method_bind_9, Object.GetPtr(this));
        }

        private IntPtr method_bind_10 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_base_path");

        public void set_base_path(NodePath base_path)
        {
            NativeCalls.godot_icall_1_65(method_bind_10, Object.GetPtr(this), NodePath.GetPtr(base_path));
        }

        private IntPtr method_bind_11 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_base_path");

        public NodePath get_base_path()
        {
            IntPtr ret = NativeCalls.godot_icall_0_66(method_bind_11, Object.GetPtr(this));
            return new NodePath(ret);
        }

        private IntPtr method_bind_12 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_index");

        public void set_index(string index)
        {
            NativeCalls.godot_icall_1_35(method_bind_12, Object.GetPtr(this), index);
        }

        private IntPtr method_bind_13 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_index");

        public string get_index()
        {
            return NativeCalls.godot_icall_0_2(method_bind_13, Object.GetPtr(this));
        }
    }
}
