using System;

namespace GodotEngine
{
    public class NodePath
    {
        private const string nativeName = "NodePath";

        private bool disposed = false;

        internal IntPtr ptr;

        internal static IntPtr GetPtr(NodePath instance)
        {
            return instance == null ? IntPtr.Zero : instance.ptr;
        }

        ~NodePath()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (ptr != IntPtr.Zero)
            {
                NativeCalls.godot_icall_NodePath_Dtor(ptr);
                    ptr = IntPtr.Zero;
            }
            GC.SuppressFinalize(this);
            disposed = true;
        }

        internal NodePath(IntPtr ptr)
        {
            this.ptr = ptr;
        }

        public bool HasValidHandle()
        {
            return ptr == IntPtr.Zero;
        }

        public NodePath() : this(string.Empty) {}

        public NodePath(string path)
        {
            this.ptr = NativeCalls.godot_icall_NodePath_Ctor(path);
        }

        public static implicit operator NodePath(string from)
        {
            return new NodePath(from);
        }

        public static implicit operator string(NodePath from)
        {
            return NativeCalls.godot_icall_NodePath_operator_String(NodePath.GetPtr(from));
        }

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_name");

        public string get_name(int idx)
        {
            return NativeCalls.godot_icall_1_86(method_bind_0, NodePath.GetPtr(this), idx);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_name_count");

        public int get_name_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_1, NodePath.GetPtr(this));
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_property");

        public string get_property()
        {
            return NativeCalls.godot_icall_0_2(method_bind_2, NodePath.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_subname");

        public string get_subname(int idx)
        {
            return NativeCalls.godot_icall_1_86(method_bind_3, NodePath.GetPtr(this), idx);
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_subname_count");

        public int get_subname_count()
        {
            return NativeCalls.godot_icall_0_1(method_bind_4, NodePath.GetPtr(this));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_absolute");

        public bool is_absolute()
        {
            return NativeCalls.godot_icall_0_3(method_bind_5, NodePath.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "is_empty");

        public bool is_empty()
        {
            return NativeCalls.godot_icall_0_3(method_bind_6, NodePath.GetPtr(this));
        }
    }
}
