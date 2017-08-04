using System;

namespace GodotEngine
{
    public class VisualScriptSceneTree : VisualScriptNode
    {
        private const string nativeName = "VisualScriptSceneTree";

        public VisualScriptSceneTree() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_VisualScriptSceneTree_Ctor(this);
        }

        internal VisualScriptSceneTree(bool memoryOwn) : base(memoryOwn) {}
    }
}
