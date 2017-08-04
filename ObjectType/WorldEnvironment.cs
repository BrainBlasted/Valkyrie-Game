using System;

namespace GodotEngine
{
    /// <summary>
    /// The [WorldEnvironment] node can be added to a scene in order to set default [Environment] variables for the scene. The [WorldEnvironment] can be overridden by an [Environment] node set on the current [Camera]. Additionally, only one [WorldEnvironment] may be instanced in a given scene at a time. The [WorldEnvironment] allows the user to specify default lighting parameters (e.g. ambient lighting), various post-processing effects (e.g. SSAO, DOF, Tonemapping), and how to draw the background (e.g. solid color, skybox).
    /// </summary>
    public class WorldEnvironment : Node
    {
        private const string nativeName = "WorldEnvironment";

        public WorldEnvironment() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_WorldEnvironment_Ctor(this);
        }

        internal WorldEnvironment(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_environment");

        /// <summary>
        /// Set the currently bound [Environment] to the one specified.
        /// </summary>
        public void set_environment(Environment env)
        {
            NativeCalls.godot_icall_1_35(method_bind_0, Object.GetPtr(this), Object.GetPtr(env));
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_environment");

        /// <summary>
        /// Return the [Environment] currently bound.
        /// </summary>
        public Environment get_environment()
        {
            return NativeCalls.godot_icall_0_117(method_bind_1, Object.GetPtr(this));
        }
    }
}
