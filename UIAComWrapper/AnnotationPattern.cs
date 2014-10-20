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
    public class AnnotationPattern : BasePattern<UIAutomationClient.IUIAutomationAnnotationPattern>
    {

        public static readonly AutomationProperty AnnotationTypeIdProperty = AnnotationPatternIdentifiers.AnnotationTypeIdProperty;
        public static readonly AutomationProperty AnnotationTypeNameProperty = AnnotationPatternIdentifiers.AnnotationTypeNameProperty;
        public static readonly AutomationProperty AuthorProperty = AnnotationPatternIdentifiers.AuthorProperty;
        public static readonly AutomationProperty DateTimeProperty = AnnotationPatternIdentifiers.DateTimeProperty;
        public static readonly AutomationProperty TargetProperty = AnnotationPatternIdentifiers.TargetProperty;
        public static readonly AutomationPattern Pattern = AnnotationPatternIdentifiers.Pattern;


        private AnnotationPattern(AutomationElement el, UIAutomationClient.IUIAutomationAnnotationPattern pattern, bool cached)
            : base(el, pattern, cached)
        {
        }

        internal static object Wrap(AutomationElement el, object pattern, bool cached)
        {
            return (pattern == null) ? null : new AnnotationPattern(el, (UIAutomationClient.IUIAutomationAnnotationPattern)pattern, cached);
        }

        public AnnotationPatternInformation Cached
        {
            get
            {
                CheckDisposed();
                Utility.ValidateCached(this._cached);

                return new AnnotationPatternInformation(this._el, true);
            }
        }

        public AnnotationPatternInformation Current
        {
            get
            {
                CheckDisposed();

                return new AnnotationPatternInformation(this._el, false);
            }
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct AnnotationPatternInformation
        {
            private AutomationElement _el;
            private bool _isCached;
            internal AnnotationPatternInformation(AutomationElement element, bool isCached)
            {
                this._el = element;
                this._isCached = isCached;
            }

            public AnnotationType AnnotationTypeId
            {
                get
                {
                    return (AnnotationType)this._el.GetCurrentPropertyValue(AnnotationPattern.AnnotationTypeIdProperty, _isCached);
                }
            }

            public string AnnotationTypeName
            {
                get
                {
                    return (string)this._el.GetCurrentPropertyValue(AnnotationPattern.AnnotationTypeNameProperty, _isCached);
                }
            }

            public string Author
            {
                get
                {
                    return (string)this._el.GetCurrentPropertyValue(AnnotationPattern.AuthorProperty, _isCached);
                }
            }

            public string DateTime
            {
                get
                {
                    return (string)this._el.GetCurrentPropertyValue(AnnotationPattern.DateTimeProperty, _isCached);
                }
            }

            public AutomationElement Target
            {
                get
                {
                    return (AutomationElement)this._el.GetCurrentPropertyValue(AnnotationPattern.TargetProperty, _isCached);
                }
            }
        }
    }
}
