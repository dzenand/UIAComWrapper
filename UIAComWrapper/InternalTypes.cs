// (c) Copyright Microsoft, 2012.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
// All other rights reserved.


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace UIAComWrapperInternal
{
  
    internal static class UiaCoreIds
    {
        
        internal const int UIA_E_ELEMENTNOTAVAILABLE = -2147220991;
        internal const int UIA_E_ELEMENTNOTENABLED = -2147220992;
        internal const int UIA_E_NOCLICKABLEPOINT = -2147220990;
        internal const int UIA_E_PROXYASSEMBLYNOTLOADED = -2147220989;

        internal enum AutomationIdType
        {
            Property,
            Pattern,
            Event,
            ControlType,
            TextAttribute
        }
    }
}
