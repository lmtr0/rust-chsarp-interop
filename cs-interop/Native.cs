using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace cs_interop
{
    public static class Native
    {
        public const string DllName = "rust_interop";

        [DllImport(DllName, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public static extern void printc(string content);
        [DllImport(DllName, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.FunctionPtr)]
        public static extern Action takeFunctionPointerAndCallIt(Action content);
    }
}