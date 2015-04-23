//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_get_geolocation_callback_t
    {
        internal cef_base_t _base;
        internal IntPtr _on_location_update;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_get_geolocation_callback_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate bool release_delegate(cef_get_geolocation_callback_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate bool has_one_ref_delegate(cef_get_geolocation_callback_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_location_update_delegate(cef_get_geolocation_callback_t* self, cef_geoposition_t* position);
        
        private static int _sizeof;
        
        static cef_get_geolocation_callback_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_get_geolocation_callback_t));
        }
        
        internal static cef_get_geolocation_callback_t* Alloc()
        {
            var ptr = (cef_get_geolocation_callback_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_get_geolocation_callback_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_get_geolocation_callback_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
