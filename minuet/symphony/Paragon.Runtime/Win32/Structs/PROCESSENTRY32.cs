﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global

namespace Paragon.Runtime.Win32
{
    [ExcludeFromCodeCoverage]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct PROCESSENTRY32
    {
        private const int MAX_PATH = 260;
        public UInt32 dwSize;
        public UInt32 cntUsage;
        public UInt32 th32ProcessID;
        public IntPtr th32DefaultHeapID;
        public UInt32 th32ModuleID;
        public UInt32 cntThreads;
        public UInt32 th32ParentProcessID;
        public Int32 pcPriClassBase;
        public UInt32 dwFlags;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
        public string szExeFile;
    }
}