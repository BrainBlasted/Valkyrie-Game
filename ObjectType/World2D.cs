using System;

namespace GodotEngine
{
    /// <summary>
    /// Class that has everything pertaining to a 2D world. A physics space, a visual scenario and a sound space. 2D nodes register their resources into the current 2D world.
    /// </summary>
    public class World2D : Resource
    {
        private const string nativeName = "World2D";

        public World2D() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_World2D_Ctor(this);
        }

        internal World2D(bool memoryOwn) : base(memoryOwn) {}

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_canvas");

        /// <summary>
        /// Retrieve the [RID] of this world's canvas resource. Used by the [VisualServer] for 2D drawing.
        /// </summary>
        public RID get_canvas()
        {
            IntPtr ret = NativeCalls.godot_icall_0_121(method_bind_0, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_1 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_space");

        /// <summary>
        /// Retrieve the [RID] of this world's physics space resource. Used by the [Physics2DServer] for 2D physics, treating it as both a space and an area.
        /// </summary>
        public RID get_space()
        {
            IntPtr ret = NativeCalls.godot_icall_0_121(method_bind_1, Object.GetPtr(this));
            return new RID(ret);
        }

        private IntPtr method_bind_2 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_direct_space_state");

        /// <summary>
        /// Retrieve the state of this world's physics space. This allows arbitrary querying for collision.
        /// </summary>
        public Physics2DDirectSpaceState get_direct_space_state()
        {
            return NativeCalls.godot_icall_0_342(method_bind_2, Object.GetPtr(this));
        }
    }
}
