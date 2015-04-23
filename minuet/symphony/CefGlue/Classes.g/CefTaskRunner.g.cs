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
    public sealed unsafe partial class CefTaskRunner : IDisposable
    {
        internal static CefTaskRunner FromNative(cef_task_runner_t* ptr)
        {
            return new CefTaskRunner(ptr);
        }
        
        internal static CefTaskRunner FromNativeOrNull(cef_task_runner_t* ptr)
        {
            if (ptr == null) return null;
            return new CefTaskRunner(ptr);
        }
        
        private cef_task_runner_t* _self;
        
        private CefTaskRunner(cef_task_runner_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefTaskRunner()
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
            cef_task_runner_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            bool retVal = cef_task_runner_t.release(_self);
            if (retVal)
            {
                _self = null;
                GC.SuppressFinalize(this);
            }
            return retVal;
        }
        
        internal bool HasOneRef
        {
            get { return cef_task_runner_t.has_one_ref(_self); }
        }
        
        internal cef_task_runner_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
