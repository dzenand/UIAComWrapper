// (c) Copyright Microsoft, 2012.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
// All other rights reserved.



using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UIAComWrapperInternal;

namespace System.Windows.Automation
{
    public class DockPattern : BasePattern<UIAutomationClient.IUIAutomationDockPattern>
    {
        
        public static readonly AutomationProperty DockPositionProperty = DockPatternIdentifiers.DockPositionProperty;
        public static readonly AutomationPattern Pattern = DockPatternIdentifiers.Pattern;

        
        private DockPattern(AutomationElement el, UIAutomationClient.IUIAutomationDockPattern pattern, bool cached)
            : base(el, pattern, cached)
        {
        }

        public void SetDockPosition(DockPosition dockPosition)
        {
            CheckDisposed();

            try
            {
                this._pattern.SetDockPosition((UIAutomationClient.DockPosition)dockPosition);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        internal static object Wrap(AutomationElement el, object pattern, bool cached)
        {
            return (pattern == null) ? null : new DockPattern(el, (UIAutomationClient.IUIAutomationDockPattern)pattern, cached);
        }

        
        public DockPatternInformation Cached
        {
            get
            {
                CheckDisposed();
                Utility.ValidateCached(this._cached);

                return new DockPatternInformation(this._el, true);
            }
        }

        public DockPatternInformation Current
        {
            get
            {
                CheckDisposed();

                return new DockPatternInformation(this._el, false);
            }
        }

        
        [StructLayout(LayoutKind.Sequential)]
        public struct DockPatternInformation
        {
            private AutomationElement _el;
            private bool _isCached;
            internal DockPatternInformation(AutomationElement element, bool isCached)
            {
                this._el = element;
                this._isCached = isCached;
            }

            public DockPosition DockPosition
            {
                get
                {
                    return (DockPosition)this._el.GetPropertyValue(DockPattern.DockPositionProperty, _isCached);
                }
            }
        }
    }
}
