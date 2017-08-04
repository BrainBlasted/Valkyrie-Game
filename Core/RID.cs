using System;

namespace GodotEngine
{
    public class RID
    {
        private const string nativeName = "RID";

        private bool disposed = false;

        internal IntPtr ptr;

        internal static IntPtr GetPtr(RID instance)
        {
            return instance == null ? IntPtr.Zero : instance.ptr;
        }

        ~RID()
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
                NativeCalls.godot_icall_RID_Dtor(ptr);
                    ptr = IntPtr.Zero;
            }
            GC.SuppressFinalize(this);
            disposed = true;
        }

        internal RID(IntPtr ptr)
        {
            this.ptr = ptr;
        }

        public bool HasValidHandle()
        {
            return ptr == IntPtr.Zero;
        }

        internal RID()
        {
            this.ptr = IntPtr.Zero;
        }

        private IntPtr method_bind_0 = NativeCalls.godot_icall_TypeDB_get_method(nativeName, "get_id");

        public int get_id()
        {
            return NativeCalls.godot_icall_0_1(method_bind_0, RID.GetPtr(this));
        }
    }
}
