// (c) Copyright Microsoft, 2012.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
// All other rights reserved.



using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UIAComWrapper;

namespace System.Windows.Automation
{
    public class BasePattern<T> : DisposableBaseWithoutFinalizer
        where T : class
    {
        protected readonly T _pattern;
        protected readonly AutomationElement _el;
        protected readonly bool _cached;

        protected BasePattern(AutomationElement el, T pattern, bool cached)
        {
            Debug.Assert(el != null);
            Debug.Assert(pattern != null);

            this._el = el;
            this._pattern = pattern;
            this._cached = cached;
        }

        protected override void DisposeManagedResource()
        {
            Marshal.FinalReleaseComObject(_pattern);
            base.DisposeManagedResource();
        }
    }
}
