using System;
using System.Runtime.InteropServices;

namespace Dogged.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct git_buf
    {
        public IntPtr ptr;
        public UIntPtr asize;
        public UIntPtr size;
    }
}
