using System;

namespace GodotEngine
{
    public class ARVRScriptInterface : ARVRInterface
    {
        private const string nativeName = "ARVRScriptInterface";

        public ARVRScriptInterface() : this(false)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_ARVRScriptInterface_Ctor(this);
        }

        internal ARVRScriptInterface(bool memoryOwn) : base(memoryOwn) {}
    }
}
