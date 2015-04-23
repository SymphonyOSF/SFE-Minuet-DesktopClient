namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    /// <summary>
    /// Implement this interface to handle context menu events. The methods of this
    /// class will be called on the UI thread.
    /// </summary>
    public abstract unsafe partial class CefContextMenuHandler
    {
        private void on_before_context_menu(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefContextMenuHandler.OnBeforeContextMenu
        }
        
        /// <summary>
        /// Called before a context menu is displayed. |params| provides information
        /// about the context menu state. |model| initially contains the default
        /// context menu. The |model| can be cleared to show no context menu or
        /// modified to show a custom menu. Do not keep references to |params| or
        /// |model| outside of this callback.
        /// </summary>
        // protected abstract void OnBeforeContextMenu(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model);
        
        private int on_context_menu_command(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, int command_id, CefEventFlags event_flags)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefContextMenuHandler.OnContextMenuCommand
        }
        
        /// <summary>
        /// Called to execute a command selected from the context menu. Return true if
        /// the command was handled or false for the default implementation. See
        /// cef_menu_id_t for the command ids that have default implementations. All
        /// user-defined command ids should be between MENU_ID_USER_FIRST and
        /// MENU_ID_USER_LAST. |params| will have the same values as what was passed to
        /// OnBeforeContextMenu(). Do not keep a reference to |params| outside of this
        /// callback.
        /// </summary>
        // protected abstract int OnContextMenuCommand(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, int command_id, CefEventFlags event_flags);
        
        private void on_context_menu_dismissed(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame)
        {
            CheckSelf(self);
            throw new NotImplementedException(); // TODO: CefContextMenuHandler.OnContextMenuDismissed
        }
        
        /// <summary>
        /// Called when the context menu is dismissed irregardless of whether the menu
        /// was empty or a command was selected.
        /// </summary>
        // protected abstract void OnContextMenuDismissed(cef_browser_t* browser, cef_frame_t* frame);
        
    }
}
