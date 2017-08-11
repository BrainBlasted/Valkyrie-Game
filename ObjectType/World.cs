using System;

namespace GodotEngine
{
    /// <summary>
    /// Class that has everything pertaining to a world. A physics space, a visual scenario and a sound space. Spatial nodes register their resources into the current world.
    /// </summary>
    public class World : Resource
    {
        private const string nativeName = "World";

        public World() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_World_Ctor(this);
        }

        internal World(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_space");

        public RID get_space()
        {
            IntPtr ret = NativeCalls.godot_icall_0_122(method_bind_0, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_scenario");

        public RID get_scenario()
        {
            IntPtr ret = NativeCalls.godot_icall_0_122(method_bind_1, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_environment");

        public void set_environment(Environment env)
        {
            NativeCalls.godot_icall_1_19(method_bind_2, Object.GetPtr(this), Object.GetPtr(env));
        }

        private IntPtr method_bind_3 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_environment");

        public Environment get_environment()
        {
            return NativeCalls.godot_icall_0_118(method_bind_3, Object.GetPtr(this));
        }

        private IntPtr method_bind_4 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "set_fallback_environment");

        public void set_fallback_environment(Environment env)
        {
            NativeCalls.godot_icall_1_19(method_bind_4, Object.GetPtr(this), Object.GetPtr(env));
        }

        private IntPtr method_bind_5 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_fallback_environment");

        public Environment get_fallback_environment()
        {
            return NativeCalls.godot_icall_0_118(method_bind_5, Object.GetPtr(this));
        }

        private IntPtr method_bind_6 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_direct_space_state");

        public PhysicsDirectSpaceState get_direct_space_state()
        {
            return NativeCalls.godot_icall_0_376(method_bind_6, Object.GetPtr(this));
        }
    }
}
