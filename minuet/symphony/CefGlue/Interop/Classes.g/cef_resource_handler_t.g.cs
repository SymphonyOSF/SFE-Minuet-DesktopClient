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
    internal unsafe struct cef_resource_handler_t
    {
        internal cef_base_t _base;
        internal IntPtr _process_request;
        internal IntPtr _get_response_headers;
        internal IntPtr _read_response;
        internal IntPtr _can_get_cookie;
        internal IntPtr _can_set_cookie;
        internal IntPtr _cancel;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_resource_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate bool release_delegate(cef_resource_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate bool has_one_ref_delegate(cef_resource_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int process_request_delegate(cef_resource_handler_t* self, cef_request_t* request, cef_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void get_response_headers_delegate(cef_resource_handler_t* self, cef_response_t* response, long* response_length, cef_string_t* redirectUrl);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int read_response_delegate(cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int can_get_cookie_delegate(cef_resource_handler_t* self, cef_cookie_t* cookie);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int can_set_cookie_delegate(cef_resource_handler_t* self, cef_cookie_t* cookie);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void cancel_delegate(cef_resource_handler_t* self);
        
        private static int _sizeof;
        
        static cef_resource_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_resource_handler_t));
        }
        
        internal static cef_resource_handler_t* Alloc()
        {
            var ptr = (cef_resource_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_resource_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_resource_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
