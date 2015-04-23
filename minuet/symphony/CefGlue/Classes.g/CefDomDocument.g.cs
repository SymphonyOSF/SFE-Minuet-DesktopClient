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
    public sealed unsafe partial class CefDomDocument : IDisposable
    {
        internal static CefDomDocument FromNative(cef_domdocument_t* ptr)
        {
            return new CefDomDocument(ptr);
        }
        
        internal static CefDomDocument FromNativeOrNull(cef_domdocument_t* ptr)
        {
            if (ptr == null) return null;
            return new CefDomDocument(ptr);
        }
        
        private cef_domdocument_t* _self;
        
        private CefDomDocument(cef_domdocument_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefDomDocument()
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
            cef_domdocument_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            bool retVal = cef_domdocument_t.release(_self);
            if (retVal)
            {
                _self = null;
                Dispose();
            }
            return retVal;
        }
        
        internal bool HasOneRef
        {
            get { return cef_domdocument_t.has_one_ref(_self); }
        }
        
        internal cef_domdocument_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
