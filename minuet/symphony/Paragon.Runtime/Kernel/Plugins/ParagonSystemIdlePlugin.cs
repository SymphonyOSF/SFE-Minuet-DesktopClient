﻿using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Paragon.Plugins;
using Paragon.Runtime.Annotations;
using Paragon.Runtime.Win32;

namespace Paragon.Runtime.Kernel.Plugins
{
    [JavaScriptPlugin(Name = "paragon.idle")]
    public sealed class ParagonSystemIdlePlugin : ParagonPlugin, IDisposable
    {
        private bool _locked;
        private uint _queryInterval = 10*1000; // 10 seconds
        private Timer _queryTimer;
        private string _state = "active";

        [JavaScriptPluginMember(Name = "stateChanged"), UsedImplicitly]
        public event JavaScriptPluginCallback StateChanged;

        [JavaScriptPluginMember(Name = "setDetectionInterval"), UsedImplicitly]
        public void SetDetectionInterval(int seconds)
        {
            if (_queryTimer != null)
            {
                _queryInterval = (uint) (seconds*1000);
                _queryTimer.Change(0, _queryInterval);
            }
        }

        [JavaScriptPluginMember(Name = "queryState")]
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public string QueryState(uint since)
        {
            if (_locked)
            {
                return "locked";
            }

            var lastInput = new LASTINPUTINFO();
            lastInput.cbSize = (uint) Marshal.SizeOf(lastInput);
            if (!NativeMethods.GetLastInputInfo(ref lastInput))
            {
                throw Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error());
            }

            return ((uint) Environment.TickCount - lastInput.dwTime) > since ? "idle" : "active";
        }

        private void OnSessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock || e.Reason == SessionSwitchReason.SessionUnlock)
            {
                _locked = e.Reason == SessionSwitchReason.SessionLock;
                FireStateChangedIfNeeded(QueryState(_queryInterval));
            }
        }

        private void FireStateChangedIfNeeded(string state)
        {
            if (state.Equals(_state, StringComparison.InvariantCultureIgnoreCase))
            {
                _state = state;
                if (StateChanged != null)
                {
                    StateChanged(this, state);
                }
            }
        }

        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void OnInitialize()
        {
            SystemEvents.SessionSwitch += OnSessionSwitch;

            _queryTimer = new Timer(s => FireStateChangedIfNeeded(QueryState(_queryInterval)), null, 0, _queryInterval);

            base.OnInitialize();
        }

        protected override void OnShutdown()
        {
            _queryTimer.Dispose();
            _queryTimer = null;
            base.OnShutdown();
        }

        public void Dispose()
        {
            if (_queryTimer != null)
            {
                _queryTimer.Dispose();
                _queryTimer = null;
            }
        }
    }
}