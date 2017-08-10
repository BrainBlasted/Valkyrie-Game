using System;

namespace GodotEngine
{
    /// <summary>
    /// TODO: explain ownership, and that node does not need to own itself
    /// </summary>
    public class PackedScene : Resource
    {
        public const int GEN_EDIT_STATE_DISABLED = 0;
        public const int GEN_EDIT_STATE_INSTANCE = 1;
        public const int GEN_EDIT_STATE_MAIN = 2;

        private const string nativeName = "PackedScene";

        public PackedScene() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_PackedScene_Ctor(this);
        }

        internal PackedScene(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "pack");

        /// <summary>
        /// Pack will ignore any sub-nodes not owned by given node. See [method Node.set_owner].
        /// </summary>
        public int pack(Node path)
        {
            return NativeCalls.godot_icall_1_145(method_bind_0, Object.GetPtr(this), Object.GetPtr(path));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "instance");

        public Node instance(int edit_state = 0)
        {
            return NativeCalls.godot_icall_1_306(method_bind_1, Object.GetPtr(this), edit_state);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "can_instance");

        public bool can_instance()
        {
            return NativeCalls.godot_icall_0_3(method_bind_2, Object.GetPtr(this));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_state");

        public SceneState get_state()
        {
            return NativeCalls.godot_icall_0_332(method_bind_3, Object.GetPtr(this));
        }
    }
}
