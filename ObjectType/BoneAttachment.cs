using System;

namespace GodotEngine
{
    /// <summary>
    /// This node must be the child of a [Skeleton] node. You can then select a bone for this node to attach to. The BoneAttachment node will copy the transform of the selected bone.
    /// </summary>
    public class BoneAttachment : Spatial
    {
        private const string nativeName = "BoneAttachment";

        public BoneAttachment() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_BoneAttachment_Ctor(this);
        }

        internal BoneAttachment(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_bone_name");

        public void set_bone_name(string bone_name)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), bone_name);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_bone_name");

        public string get_bone_name()
        {
            return NativeCalls.godot_icall_0_2(method_bind_1, Object.GetPtr(this));
        }
    }
}
