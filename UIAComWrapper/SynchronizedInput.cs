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
    public class SynchronizedInputPattern : BasePattern<UIAutomationClient.IUIAutomationSynchronizedInputPattern>
    {
        public static readonly AutomationEvent InputReachedTargetEvent = SynchronizedInputPatternIdentifiers.InputReachedTargetEvent;
        public static readonly AutomationEvent InputReachedOtherElementEvent = SynchronizedInputPatternIdentifiers.InputReachedOtherElementEvent;
        public static readonly AutomationEvent InputDiscardedEvent = SynchronizedInputPatternIdentifiers.InputDiscardedEvent;
        public static readonly AutomationPattern Pattern = SynchronizedInputPatternIdentifiers.Pattern;

        private SynchronizedInputPattern(AutomationElement el, UIAutomationClient.IUIAutomationSynchronizedInputPattern pattern, bool cached)
            : base(el, pattern, cached)
        {
        }

        public void Cancel()
        {
            CheckDisposed();

            try
            {
                this._pattern.Cancel();
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public void StartListening(SynchronizedInputType type)
        {
            CheckDisposed();

            try
            {
                this._pattern.StartListening((UIAutomationClient.SynchronizedInputType)type);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        internal static object Wrap(AutomationElement el, object pattern, bool cached)
        {
            return (pattern == null) ? null : new SynchronizedInputPattern(el, (UIAutomationClient.IUIAutomationSynchronizedInputPattern)pattern, cached);
        }
    }
}
