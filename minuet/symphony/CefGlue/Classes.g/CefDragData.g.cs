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
    public sealed unsafe partial class CefDragData : IDisposable
    {
        internal static CefDragData FromNative(cef_drag_data_t* ptr)
        {
            return new CefDragData(ptr);
        }
        
        internal static CefDragData FromNativeOrNull(cef_drag_data_t* ptr)
        {
            if (ptr == null) return null;
            return new CefDragData(ptr);
        }
        
        private cef_drag_data_t* _self;
        
        private CefDragData(cef_drag_data_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefDragData()
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
            cef_drag_data_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            bool retVal = cef_drag_data_t.release(_self);
            if (retVal)
            {
                _self = null;
                GC.SuppressFinalize(this);
            }
            return retVal;
        }
        
        internal bool HasOneRef
        {
            get { return cef_drag_data_t.has_one_ref(_self); }
        }
        
        internal cef_drag_data_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
