using System;
using System.Runtime.InteropServices;

namespace Dogged.Native
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int config_foreach_callback(
        git_config_entry* entry,
        IntPtr payload);

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct git_config_entry
    {
        public char* namePtr;
        public char* valuePtr;
        public uint include_depth;
        public uint level;
        public void* freePtr;
        public void* payloadPtr;
    }

    public struct git_config { }
}
