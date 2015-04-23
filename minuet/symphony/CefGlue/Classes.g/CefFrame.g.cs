//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefFrame : IDisposable
    {
        internal static CefFrame FromNative(cef_frame_t* ptr)
        {
            return new CefFrame(ptr);
        }
        
        internal static CefFrame FromNativeOrNull(cef_frame_t* ptr)
        {
            if (ptr == null) return null;
            return new CefFrame(ptr);
        }
        
        private cef_frame_t* _self;
        
        private CefFrame(cef_frame_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefFrame()
        {
            Dispose();
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
            }
        }
        
        internal void AddRef()
        {
            cef_frame_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            bool retVal = cef_frame_t.release(_self);
            if (retVal)
            {
                _self = null;
                GC.SuppressFinalize(this);
            }
            return retVal;
        }
        
        internal bool HasOneRef
        {
            get { return cef_frame_t.has_one_ref(_self); }
        }
        
        internal cef_frame_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
