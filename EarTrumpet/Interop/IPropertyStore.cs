﻿using System;
using System.Runtime.InteropServices;

namespace EarTrumpet.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    struct PROPERTYKEY
    {
        public Guid fmtid;
        public UIntPtr pid;
    }

    [ComImport]
    [Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IPropertyStore
    {
        [PreserveSig]
        int GetCount([Out] out uint cProps);
        [PreserveSig]
        int GetAt([In] uint iProp, out PROPERTYKEY pkey);
        PropVariant GetValue([In] ref PROPERTYKEY key);
        [PreserveSig]
        int SetValue([In] ref PROPERTYKEY key, [In] ref object pv);
        [PreserveSig]
        int Commit();
    }
}