using System;

namespace GodotEngine
{
    public class VisualScriptSceneNode : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSceneNode";

        public VisualScriptSceneNode() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSceneNode_Ctor(this);
        }

        internal VisualScriptSceneNode(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_node_path");

        public void set_node_path(NodePath path)
        {
            NativeCalls.godot_icall_1_64(method_bind_0, Object.GetPtr(this), NodePath.GetPtr(path));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_node_path");

        public NodePath get_node_path()
        {
            IntPtr ret = NativeCalls.godot_icall_0_65(method_bind_1, Object.GetPtr(this));
            return new NodePath(ret);
        }
    }
}
