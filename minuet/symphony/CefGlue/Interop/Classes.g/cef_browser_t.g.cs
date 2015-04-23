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
    internal unsafe struct cef_browser_t
    {
        internal cef_base_t _base;
        internal IntPtr _get_host;
        internal IntPtr _can_go_back;
        internal IntPtr _go_back;
        internal IntPtr _can_go_forward;
        internal IntPtr _go_forward;
        internal IntPtr _is_loading;
        internal IntPtr _reload;
        internal IntPtr _reload_ignore_cache;
        internal IntPtr _stop_load;
        internal IntPtr _get_identifier;
        internal IntPtr _is_same;
        internal IntPtr _is_popup;
        internal IntPtr _has_document;
        internal IntPtr _get_main_frame;
        internal IntPtr _get_focused_frame;
        internal IntPtr _get_frame_byident;
        internal IntPtr _get_frame;
        internal IntPtr _get_frame_count;
        internal IntPtr _get_frame_identifiers;
        internal IntPtr _get_frame_names;
        internal IntPtr _send_process_message;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate bool release_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate bool has_one_ref_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_browser_host_t* get_host_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int can_go_back_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void go_back_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int can_go_forward_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void go_forward_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_loading_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void reload_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void reload_ignore_cache_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void stop_load_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_identifier_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_same_delegate(cef_browser_t* self, cef_browser_t* that);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_popup_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_document_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_frame_t* get_main_frame_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_frame_t* get_focused_frame_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_frame_t* get_frame_byident_delegate(cef_browser_t* self, long identifier);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_frame_t* get_frame_delegate(cef_browser_t* self, cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate UIntPtr get_frame_count_delegate(cef_browser_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_frame_identifiers_delegate(cef_browser_t* self, UIntPtr* identifiersCount, long* identifiers);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_frame_names_delegate(cef_browser_t* self, cef_string_list* names);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int send_process_message_delegate(cef_browser_t* self, CefProcessId target_process, cef_process_message_t* message);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_browser_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static bool release(cef_browser_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // GetRefCt
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static bool has_one_ref(cef_browser_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // GetHost
        private static IntPtr _p3;
        private static get_host_delegate _d3;
        
        public static cef_browser_host_t* get_host(cef_browser_t* self)
        {
            get_host_delegate d;
            var p = self->_get_host;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (get_host_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_host_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // CanGoBack
        private static IntPtr _p4;
        private static can_go_back_delegate _d4;
        
        public static int can_go_back(cef_browser_t* self)
        {
            can_go_back_delegate d;
            var p = self->_can_go_back;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (can_go_back_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(can_go_back_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // GoBack
        private static IntPtr _p5;
        private static go_back_delegate _d5;
        
        public static void go_back(cef_browser_t* self)
        {
            go_back_delegate d;
            var p = self->_go_back;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (go_back_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(go_back_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            d(self);
        }
        
        // CanGoForward
        private static IntPtr _p6;
        private static can_go_forward_delegate _d6;
        
        public static int can_go_forward(cef_browser_t* self)
        {
            can_go_forward_delegate d;
            var p = self->_can_go_forward;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (can_go_forward_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(can_go_forward_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // GoForward
        private static IntPtr _p7;
        private static go_forward_delegate _d7;
        
        public static void go_forward(cef_browser_t* self)
        {
            go_forward_delegate d;
            var p = self->_go_forward;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (go_forward_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(go_forward_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            d(self);
        }
        
        // IsLoading
        private static IntPtr _p8;
        private static is_loading_delegate _d8;
        
        public static int is_loading(cef_browser_t* self)
        {
            is_loading_delegate d;
            var p = self->_is_loading;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (is_loading_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_loading_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // Reload
        private static IntPtr _p9;
        private static reload_delegate _d9;
        
        public static void reload(cef_browser_t* self)
        {
            reload_delegate d;
            var p = self->_reload;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (reload_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(reload_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            d(self);
        }
        
        // ReloadIgnoreCache
        private static IntPtr _pa;
        private static reload_ignore_cache_delegate _da;
        
        public static void reload_ignore_cache(cef_browser_t* self)
        {
            reload_ignore_cache_delegate d;
            var p = self->_reload_ignore_cache;
            if (p == _pa) { d = _da; }
            else
            {
                d = (reload_ignore_cache_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(reload_ignore_cache_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            d(self);
        }
        
        // StopLoad
        private static IntPtr _pb;
        private static stop_load_delegate _db;
        
        public static void stop_load(cef_browser_t* self)
        {
            stop_load_delegate d;
            var p = self->_stop_load;
            if (p == _pb) { d = _db; }
            else
            {
                d = (stop_load_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(stop_load_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            d(self);
        }
        
        // GetIdentifier
        private static IntPtr _pc;
        private static get_identifier_delegate _dc;
        
        public static int get_identifier(cef_browser_t* self)
        {
            get_identifier_delegate d;
            var p = self->_get_identifier;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (get_identifier_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_identifier_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            return d(self);
        }
        
        // IsSame
        private static IntPtr _pd;
        private static is_same_delegate _dd;
        
        public static int is_same(cef_browser_t* self, cef_browser_t* that)
        {
            is_same_delegate d;
            var p = self->_is_same;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (is_same_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_same_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            return d(self, that);
        }
        
        // IsPopup
        private static IntPtr _pe;
        private static is_popup_delegate _de;
        
        public static int is_popup(cef_browser_t* self)
        {
            is_popup_delegate d;
            var p = self->_is_popup;
            if (p == _pe) { d = _de; }
            else
            {
                d = (is_popup_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_popup_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            return d(self);
        }
        
        // HasDocument
        private static IntPtr _pf;
        private static has_document_delegate _df;
        
        public static int has_document(cef_browser_t* self)
        {
            has_document_delegate d;
            var p = self->_has_document;
            if (p == _pf) { d = _df; }
            else
            {
                d = (has_document_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_document_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            return d(self);
        }
        
        // GetMainFrame
        private static IntPtr _p10;
        private static get_main_frame_delegate _d10;
        
        public static cef_frame_t* get_main_frame(cef_browser_t* self)
        {
            get_main_frame_delegate d;
            var p = self->_get_main_frame;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (get_main_frame_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_main_frame_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            return d(self);
        }
        
        // GetFocusedFrame
        private static IntPtr _p11;
        private static get_focused_frame_delegate _d11;
        
        public static cef_frame_t* get_focused_frame(cef_browser_t* self)
        {
            get_focused_frame_delegate d;
            var p = self->_get_focused_frame;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (get_focused_frame_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_focused_frame_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            return d(self);
        }
        
        // GetFrame
        private static IntPtr _p12;
        private static get_frame_byident_delegate _d12;
        
        public static cef_frame_t* get_frame_byident(cef_browser_t* self, long identifier)
        {
            get_frame_byident_delegate d;
            var p = self->_get_frame_byident;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (get_frame_byident_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_frame_byident_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            return d(self, identifier);
        }
        
        // GetFrame
        private static IntPtr _p13;
        private static get_frame_delegate _d13;
        
        public static cef_frame_t* get_frame(cef_browser_t* self, cef_string_t* name)
        {
            get_frame_delegate d;
            var p = self->_get_frame;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (get_frame_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_frame_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            return d(self, name);
        }
        
        // GetFrameCount
        private static IntPtr _p14;
        private static get_frame_count_delegate _d14;
        
        public static UIntPtr get_frame_count(cef_browser_t* self)
        {
            get_frame_count_delegate d;
            var p = self->_get_frame_count;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (get_frame_count_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_frame_count_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            return d(self);
        }
        
        // GetFrameIdentifiers
        private static IntPtr _p15;
        private static get_frame_identifiers_delegate _d15;
        
        public static void get_frame_identifiers(cef_browser_t* self, UIntPtr* identifiersCount, long* identifiers)
        {
            get_frame_identifiers_delegate d;
            var p = self->_get_frame_identifiers;
            if (p == _p15) { d = _d15; }
            else
            {
                d = (get_frame_identifiers_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_frame_identifiers_delegate));
                if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
            }
            d(self, identifiersCount, identifiers);
        }
        
        // GetFrameNames
        private static IntPtr _p16;
        private static get_frame_names_delegate _d16;
        
        public static void get_frame_names(cef_browser_t* self, cef_string_list* names)
        {
            get_frame_names_delegate d;
            var p = self->_get_frame_names;
            if (p == _p16) { d = _d16; }
            else
            {
                d = (get_frame_names_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_frame_names_delegate));
                if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
            }
            d(self, names);
        }
        
        // SendProcessMessage
        private static IntPtr _p17;
        private static send_process_message_delegate _d17;
        
        public static int send_process_message(cef_browser_t* self, CefProcessId target_process, cef_process_message_t* message)
        {
            send_process_message_delegate d;
            var p = self->_send_process_message;
            if (p == _p17) { d = _d17; }
            else
            {
                d = (send_process_message_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(send_process_message_delegate));
                if (_p17 == IntPtr.Zero) { _d17 = d; _p17 = p; }
            }
            return d(self, target_process, message);
        }
        
    }
}
