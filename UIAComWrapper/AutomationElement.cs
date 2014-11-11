// (c) Copyright Microsoft, 2012.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
// All other rights reserved.


using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UIAComWrapper;
using UIAComWrapperInternal;

namespace System.Windows.Automation
{
    public enum AutomationElementMode
    {
        None,
        Full
    }

    public sealed class AutomationElement : DisposableBaseWithoutFinalizer
    {
    
        public static readonly AutomationProperty AcceleratorKeyProperty = AutomationElementIdentifiers.AcceleratorKeyProperty;
        public static readonly AutomationProperty AccessKeyProperty = AutomationElementIdentifiers.AccessKeyProperty;
        public static readonly AutomationEvent AsyncContentLoadedEvent = AutomationElementIdentifiers.AsyncContentLoadedEvent;
        public static readonly AutomationEvent AutomationFocusChangedEvent = AutomationElementIdentifiers.AutomationFocusChangedEvent;
        public static readonly AutomationProperty AutomationIdProperty = AutomationElementIdentifiers.AutomationIdProperty;
        public static readonly AutomationEvent AutomationPropertyChangedEvent = AutomationElementIdentifiers.AutomationPropertyChangedEvent;
        public static readonly AutomationProperty BoundingRectangleProperty = AutomationElementIdentifiers.BoundingRectangleProperty;
        public static readonly AutomationProperty ClassNameProperty = AutomationElementIdentifiers.ClassNameProperty;
        public static readonly AutomationProperty ClickablePointProperty = AutomationElementIdentifiers.ClickablePointProperty;
        public static readonly AutomationProperty ControlTypeProperty = AutomationElementIdentifiers.ControlTypeProperty;
        public static readonly AutomationProperty CultureProperty = AutomationElementIdentifiers.CultureProperty;
        public static readonly AutomationProperty FrameworkIdProperty = AutomationElementIdentifiers.FrameworkIdProperty;
        public static readonly AutomationProperty HasKeyboardFocusProperty = AutomationElementIdentifiers.HasKeyboardFocusProperty;
        public static readonly AutomationProperty HelpTextProperty = AutomationElementIdentifiers.HelpTextProperty;
        public static readonly AutomationProperty IsContentElementProperty = AutomationElementIdentifiers.IsContentElementProperty;
        public static readonly AutomationProperty IsControlElementProperty = AutomationElementIdentifiers.IsControlElementProperty;
        public static readonly AutomationProperty IsDockPatternAvailableProperty = AutomationElementIdentifiers.IsDockPatternAvailableProperty;
        public static readonly AutomationProperty IsEnabledProperty = AutomationElementIdentifiers.IsEnabledProperty;
        public static readonly AutomationProperty IsExpandCollapsePatternAvailableProperty = AutomationElementIdentifiers.IsExpandCollapsePatternAvailableProperty;
        public static readonly AutomationProperty IsGridItemPatternAvailableProperty = AutomationElementIdentifiers.IsGridItemPatternAvailableProperty;
        public static readonly AutomationProperty IsGridPatternAvailableProperty = AutomationElementIdentifiers.IsGridPatternAvailableProperty;
        public static readonly AutomationProperty IsInvokePatternAvailableProperty = AutomationElementIdentifiers.IsInvokePatternAvailableProperty;
        public static readonly AutomationProperty IsKeyboardFocusableProperty = AutomationElementIdentifiers.IsKeyboardFocusableProperty;
        public static readonly AutomationProperty IsMultipleViewPatternAvailableProperty = AutomationElementIdentifiers.IsMultipleViewPatternAvailableProperty;
        public static readonly AutomationProperty IsOffscreenProperty = AutomationElementIdentifiers.IsOffscreenProperty;
        public static readonly AutomationProperty IsPasswordProperty = AutomationElementIdentifiers.IsPasswordProperty;
        public static readonly AutomationProperty IsRangeValuePatternAvailableProperty = AutomationElementIdentifiers.IsRangeValuePatternAvailableProperty;
        public static readonly AutomationProperty IsRequiredForFormProperty = AutomationElementIdentifiers.IsRequiredForFormProperty;
        public static readonly AutomationProperty IsScrollItemPatternAvailableProperty = AutomationElementIdentifiers.IsScrollItemPatternAvailableProperty;
        public static readonly AutomationProperty IsScrollPatternAvailableProperty = AutomationElementIdentifiers.IsScrollPatternAvailableProperty;
        public static readonly AutomationProperty IsSelectionItemPatternAvailableProperty = AutomationElementIdentifiers.IsSelectionItemPatternAvailableProperty;
        public static readonly AutomationProperty IsSelectionPatternAvailableProperty = AutomationElementIdentifiers.IsSelectionPatternAvailableProperty;
        public static readonly AutomationProperty IsTableItemPatternAvailableProperty = AutomationElementIdentifiers.IsTableItemPatternAvailableProperty;
        public static readonly AutomationProperty IsTablePatternAvailableProperty = AutomationElementIdentifiers.IsTablePatternAvailableProperty;
        public static readonly AutomationProperty IsTextPatternAvailableProperty = AutomationElementIdentifiers.IsTextPatternAvailableProperty;
        public static readonly AutomationProperty IsTogglePatternAvailableProperty = AutomationElementIdentifiers.IsTogglePatternAvailableProperty;
        public static readonly AutomationProperty IsTransformPatternAvailableProperty = AutomationElementIdentifiers.IsTransformPatternAvailableProperty;
        public static readonly AutomationProperty IsValuePatternAvailableProperty = AutomationElementIdentifiers.IsValuePatternAvailableProperty;
        public static readonly AutomationProperty IsWindowPatternAvailableProperty = AutomationElementIdentifiers.IsWindowPatternAvailableProperty;
        public static readonly AutomationProperty ItemStatusProperty = AutomationElementIdentifiers.ItemStatusProperty;
        public static readonly AutomationProperty ItemTypeProperty = AutomationElementIdentifiers.ItemTypeProperty;
        public static readonly AutomationProperty LabeledByProperty = AutomationElementIdentifiers.LabeledByProperty;
        public static readonly AutomationEvent LayoutInvalidatedEvent = AutomationElementIdentifiers.LayoutInvalidatedEvent;
        public static readonly AutomationProperty LocalizedControlTypeProperty = AutomationElementIdentifiers.LocalizedControlTypeProperty;
        public static readonly AutomationEvent MenuClosedEvent = AutomationElementIdentifiers.MenuClosedEvent;
        public static readonly AutomationEvent MenuOpenedEvent = AutomationElementIdentifiers.MenuOpenedEvent;
        public static readonly AutomationProperty NameProperty = AutomationElementIdentifiers.NameProperty;
        public static readonly AutomationProperty NativeWindowHandleProperty = AutomationElementIdentifiers.NativeWindowHandleProperty;
        public static readonly object NotSupported = AutomationElementIdentifiers.NotSupported;
        public static readonly AutomationProperty OrientationProperty = AutomationElementIdentifiers.OrientationProperty;
        public static readonly AutomationProperty ProcessIdProperty = AutomationElementIdentifiers.ProcessIdProperty;
        public static readonly AutomationProperty RuntimeIdProperty = AutomationElementIdentifiers.RuntimeIdProperty;
        public static readonly AutomationEvent StructureChangedEvent = AutomationElementIdentifiers.StructureChangedEvent;
        public static readonly AutomationEvent ToolTipClosedEvent = AutomationElementIdentifiers.ToolTipClosedEvent;
        public static readonly AutomationEvent ToolTipOpenedEvent = AutomationElementIdentifiers.ToolTipOpenedEvent;

        public static readonly AutomationProperty IsLegacyIAccessiblePatternAvailableProperty = AutomationElementIdentifiers.IsLegacyIAccessiblePatternAvailableProperty;
        public static readonly AutomationProperty IsItemContainerPatternAvailableProperty = AutomationElementIdentifiers.IsItemContainerPatternAvailableProperty;
        public static readonly AutomationProperty IsVirtualizedItemPatternAvailableProperty = AutomationElementIdentifiers.IsVirtualizedItemPatternAvailableProperty;
        public static readonly AutomationProperty IsSynchronizedInputPatternAvailableProperty = AutomationElementIdentifiers.IsSynchronizedInputPatternAvailableProperty;

        public static readonly AutomationProperty AriaRoleProperty = AutomationElementIdentifiers.AriaRoleProperty;
        public static readonly AutomationProperty AriaPropertiesProperty = AutomationElementIdentifiers.AriaPropertiesProperty;
        public static readonly AutomationProperty IsDataValidForFormProperty = AutomationElementIdentifiers.IsDataValidForFormProperty;
        public static readonly AutomationProperty ControllerForProperty = AutomationElementIdentifiers.ControllerForProperty;
        public static readonly AutomationProperty DescribedByProperty = AutomationElementIdentifiers.DescribedByProperty;
        public static readonly AutomationProperty FlowsToProperty = AutomationElementIdentifiers.FlowsToProperty;
        public static readonly AutomationProperty ProviderDescriptionProperty = AutomationElementIdentifiers.ProviderDescriptionProperty;

        public static readonly AutomationEvent MenuModeStartEvent = AutomationElementIdentifiers.MenuModeStartEvent;
        public static readonly AutomationEvent MenuModeEndEvent = AutomationElementIdentifiers.MenuModeEndEvent;

        // New for Windows 8
        public static readonly AutomationProperty IsObjectModelPatternAvailableProperty = AutomationElementIdentifiers.IsObjectModelPatternAvailableProperty;
        public static readonly AutomationProperty IsAnnotationPatternAvailableProperty = AutomationElementIdentifiers.IsAnnotationPatternAvailableProperty;
        public static readonly AutomationProperty IsTextPattern2AvailableProperty = AutomationElementIdentifiers.IsTextPattern2AvailableProperty;
        public static readonly AutomationProperty IsStylesPatternAvailableProperty = AutomationElementIdentifiers.IsStylesPatternAvailableProperty;
        public static readonly AutomationProperty IsSpreadsheetPatternAvailableProperty = AutomationElementIdentifiers.IsSpreadsheetPatternAvailableProperty;
        public static readonly AutomationProperty IsSpreadsheetItemPatternAvailableProperty = AutomationElementIdentifiers.IsSpreadsheetItemPatternAvailableProperty;
        public static readonly AutomationProperty IsTransformPattern2AvailableProperty = AutomationElementIdentifiers.IsTransformPattern2AvailableProperty;
        public static readonly AutomationProperty IsTextChildPatternAvailableProperty = AutomationElementIdentifiers.IsTextChildPatternAvailableProperty;
        public static readonly AutomationProperty IsDragPatternAvailableProperty = AutomationElementIdentifiers.IsDragPatternAvailableProperty;
        public static readonly AutomationProperty IsDropTargetPatternAvailableProperty = AutomationElementIdentifiers.IsDropTargetPatternAvailableProperty;

        public static readonly AutomationProperty OptimizeForVisualContentProperty = AutomationElementIdentifiers.OptimizeForVisualContentProperty;
        public static readonly AutomationProperty LiveSettingProperty = AutomationElementIdentifiers.LiveSettingProperty;

        public static readonly AutomationEvent SystemAlertEvent = AutomationElementIdentifiers.SystemAlertEvent;
        public static readonly AutomationEvent LiveRegionChangedEvent = AutomationElementIdentifiers.LiveRegionChangedEvent;
        public static readonly AutomationEvent HostedFragmentRootsInvalidatedEvent = AutomationElementIdentifiers.HostedFragmentRootsInvalidatedEvent;
        
        //Windows 8.1
        public static readonly AutomationEvent EditTextChangedEvent = AutomationElementIdentifiers.EditTextChangedEvent;

        public static readonly AutomationProperty CurrentIsPeripheral = AutomationElementIdentifiers.CurrentIsPeripheral;

        #region Element object

        private readonly UIAutomationClient.IUIAutomationElement _AutomationElement;

        private UIAutomationClient.IUIAutomationElement2 _AutomationElement2
        {
            get
            {
                if (_AutomationElement != null)
                {
                    UIAutomationClient.IUIAutomationElement2 element =
                        _AutomationElement as UIAutomationClient.IUIAutomationElement2;
                    if (element == null)
                    {
                        throw new NotImplementedException("Operation is not available without IUIAutomationElement2 support on OS");
                    }

                    return element;
                }

                return null;
            }
        }

        private UIAutomationClient.IUIAutomationElement3 _AutomationElement3
        {
            get
            {
                if (_AutomationElement != null)
                {
                    UIAutomationClient.IUIAutomationElement3 element =
                        _AutomationElement as UIAutomationClient.IUIAutomationElement3;
                    if (element == null)
                    {
                        throw new NotImplementedException("Operation is not available without IUIAutomationElement3 support on OS");
                    }

                    return element;
                }

                return null;
            }
        }

        #endregion

        internal AutomationElement(UIAutomationClient.IUIAutomationElement automationElement)
        {
            Debug.Assert(automationElement != null);
            this._AutomationElement = automationElement;
        }

        internal static AutomationElement Wrap(UIAutomationClient.IUIAutomationElement obj)
        {
            return (obj == null) ? null : new AutomationElement(obj);
        }

        public override bool Equals(object obj)
        {
            CheckDisposed();

            AutomationElement element = obj as AutomationElement;
            return (((obj != null) && (element != null)) && (Automation.Factory.CompareElements(this._AutomationElement, element._AutomationElement) != 0));
        }

        public AutomationElementCollection FindAll(TreeScope scope, Condition condition)
        {
            CheckDisposed();
            Utility.ValidateArgumentNonNull(condition, "condition");

            try
            {
                UIAutomationClient.IUIAutomationElementArray elemArray =
                    this._AutomationElement.FindAllBuildCache(
                        (UIAutomationClient.TreeScope)scope,
                        condition.NativeCondition,
                        CacheRequest.CurrentNativeCacheRequest);
                return AutomationElementCollection.Wrap(elemArray);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public AutomationElement FindFirst(TreeScope scope, Condition condition)
        {
            CheckDisposed();
            Utility.ValidateArgumentNonNull(condition, "condition");

            try
            {
                UIAutomationClient.IUIAutomationElement elem =
                    this._AutomationElement.FindFirstBuildCache(
                        (UIAutomationClient.TreeScope)scope,
                        condition.NativeCondition,
                        CacheRequest.CurrentNativeCacheRequest);
                return AutomationElement.Wrap(elem);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public static AutomationElement FromHandle(IntPtr hwnd)
        {
            Utility.ValidateArgument(hwnd != IntPtr.Zero, "Hwnd cannot be null");

            try
            {
                UIAutomationClient.IUIAutomationElement element =
                    Automation.Factory.ElementFromHandleBuildCache(hwnd, CacheRequest.CurrentNativeCacheRequest);
                return AutomationElement.Wrap(element);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public static AutomationElement FromIAccessible(Accessibility.IAccessible acc, int childId)
        {
            Utility.ValidateArgumentNonNull(acc, "acc");

            try
            {
                UIAutomationClient.IUIAutomationElement element =
                    Automation.Factory.ElementFromIAccessibleBuildCache(
                        (UIAutomationClient.IAccessible)acc, 
                        childId,
                        CacheRequest.CurrentNativeCacheRequest);
                return AutomationElement.Wrap(element);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public static AutomationElement FromLocalProvider(object /* IRawElementProviderSimple */ localImpl)
        {
            Utility.ValidateArgumentNonNull(localImpl, "localImpl");

            // It's not clear how you'd do this -- COM API doesn't give you
            // the chance to wrap a provider like this.
            throw new NotImplementedException();
        }

        public static AutomationElement FromPoint(Point pt)
        {
            try
            {
                UIAutomationClient.IUIAutomationElement element =
                    Automation.Factory.ElementFromPointBuildCache(
                        Utility.PointManagedToNative(pt),
                        CacheRequest.CurrentNativeCacheRequest);
                return AutomationElement.Wrap(element);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public object GetCachedPattern(AutomationPattern pattern)
        {
            CheckDisposed();

            object patternObj;
            if (!this.TryGetCachedPattern(pattern, out patternObj))
            {
                throw new InvalidOperationException("Unsupported pattern");
            }
            return patternObj;
        }

        public object GetCachedPropertyValue(AutomationProperty property)
        {
            CheckDisposed();

            return this.GetCachedPropertyValue(property, false);
        }

        public object GetCachedPropertyValue(AutomationProperty property, bool ignoreDefaultValue)
        {
            CheckDisposed();
            Utility.ValidateArgumentNonNull(property, "property");

            try
            {
                object obj = this._AutomationElement.GetCachedPropertyValueEx(property.Id, (ignoreDefaultValue) ? 1 : 0);
                return Utility.WrapObjectAsProperty(property, obj);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public Point GetClickablePoint()
        {
            CheckDisposed();

            Point point;
            if (!this.TryGetClickablePoint(out point))
            {
                throw new NoClickablePointException();
            }
            return point;
        }

        public object GetCurrentPattern(AutomationPattern pattern)
        {
            CheckDisposed();

            object patternObj;
            if (!this.TryGetCurrentPattern(pattern, out patternObj))
            {
                throw new InvalidOperationException("Unsupported pattern");
            }
            return patternObj;
        }

        public object GetCurrentPropertyValue(AutomationProperty property)
        {
            CheckDisposed();

            return this.GetCurrentPropertyValue(property, false);
        }

        public object GetCurrentPropertyValue(AutomationProperty property, bool ignoreDefaultValue)
        {
            CheckDisposed();
            Utility.ValidateArgumentNonNull(property, "property");

            try
            {
                object obj = this._AutomationElement.GetCurrentPropertyValueEx(property.Id, (ignoreDefaultValue) ? 1 : 0);
                return Utility.WrapObjectAsProperty(property, obj);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }

        }

        internal object GetPropertyValue(AutomationProperty property, bool cached)
        {
            if (cached)
            {
                return GetCachedPropertyValue(property);
            }
            else
            {
                return GetCurrentPropertyValue(property);
            }
        }

        public override int GetHashCode()
        {
            CheckDisposed();

            int[] runtimeId = GetRuntimeId();
            int num = 0;
            if (runtimeId == null)
            {
                throw new InvalidOperationException("Operation cannot be performed");
            }
            foreach (int i in runtimeId)
            {
                num = (num * 4) ^ i;
            }
            return num;
        }

        internal object GetRawPattern(AutomationPattern pattern, bool isCached)
        {
            try
            {
                if (isCached)
                {
                    return this._AutomationElement.GetCachedPattern(pattern.Id);
                }
                else
                {
                    return this._AutomationElement.GetCurrentPattern(pattern.Id);
                }
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }

        }

        public int[] GetRuntimeId()
        {
            CheckDisposed();

            try
            {
                return (int[])this._AutomationElement.GetRuntimeId();
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public AutomationPattern[] GetSupportedPatterns()
        {
            CheckDisposed();

            Array rawPatternIds;
            Array rawPatternNames;
            try
            {
                Automation.Factory.PollForPotentialSupportedPatterns(this._AutomationElement, out rawPatternIds, out rawPatternNames);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
            int[] patternIds = (int[])rawPatternIds;


            // This element may support patterns that are not registered for this 
            // client.  Filter them out.
            List<AutomationPattern> patterns = new List<AutomationPattern>();
            foreach (int patternId in patternIds)
            {
                AutomationPattern pattern = AutomationPattern.LookupById(patternId);
                if (pattern != null)
                {
                    patterns.Add(pattern);
                }
            }
            return patterns.ToArray();
        }

        public AutomationProperty[] GetSupportedProperties()
        {
            CheckDisposed();

            Array rawPropertyIds;
            Array rawPropertyNames;
            try
            {
                Automation.Factory.PollForPotentialSupportedProperties(this._AutomationElement, out rawPropertyIds, out rawPropertyNames);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
            int[] propertyIds = (int[])rawPropertyIds;

            // This element may support properties that are not registered for this 
            // client.  Filter them out.
            List<AutomationProperty> properties = new List<AutomationProperty>();
            foreach (int propertyId in propertyIds)
            {
                AutomationProperty property = AutomationProperty.LookupById(propertyId);
                if (property != null)
                {
                    properties.Add(property);
                }
            }
            return properties.ToArray();
        }

        public AutomationElement GetUpdatedCache(CacheRequest request)
        {
            CheckDisposed();

            try
            {
                return AutomationElement.Wrap(this._AutomationElement.BuildUpdatedCache(request.NativeCacheRequest));
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }
        }

        public static bool operator ==(AutomationElement left, AutomationElement right)
        {
            if (object.Equals(left, null))
            {
                return (object.Equals(right, null));
            }
            if (object.Equals(right, null))
            {
                return (object.Equals(left, null));
            }
            return left.Equals(right);
        }

        public static bool operator !=(AutomationElement left, AutomationElement right)
        {
            return !(left == right);
        }

        public void SetFocus()
        {
            CheckDisposed();

            try
            {
                this._AutomationElement.SetFocus();
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }

        }

        public bool TryGetCachedPattern(AutomationPattern pattern, out object patternObject)
        {
            CheckDisposed();

            patternObject = null;
            Utility.ValidateArgumentNonNull(pattern, "pattern");
            try
            {
                object nativePattern = this._AutomationElement.GetCachedPattern(pattern.Id);
                patternObject = Utility.WrapObjectAsPattern(this, nativePattern, pattern, true /* cached */);
                return (patternObject != null);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }

        }

        public bool TryGetClickablePoint(out Point pt)
        {
            CheckDisposed();

            pt = new Point(0.0, 0.0);
            UIAutomationClient.tagPOINT nativePoint = new UIAutomationClient.tagPOINT();
            try
            {
                bool success = this._AutomationElement.GetClickablePoint(out nativePoint) != 0;
                if (success)
                {
                    pt.X = nativePoint.x;
                    pt.Y = nativePoint.y;
                }
                return success;
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }

        }

        public bool TryGetCurrentPattern(AutomationPattern pattern, out object patternObject)
        {
            CheckDisposed();

            patternObject = null;
            Utility.ValidateArgumentNonNull(pattern, "pattern");
            try
            {
                object nativePattern = this._AutomationElement.GetCurrentPattern(pattern.Id);
                patternObject = Utility.WrapObjectAsPattern(this, nativePattern, pattern, false /* cached */);
                return (patternObject != null);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }

        }

        
        public AutomationElementInformation Cached
        {
            get
            {
                CheckDisposed();

                return new AutomationElementInformation(this, true);
            }
        }

        public AutomationElementCollection CachedChildren
        {
            get
            {
                CheckDisposed();

                try
                {
                    return AutomationElementCollection.Wrap(this._AutomationElement.GetCachedChildren());
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
                }

            }
        }

        public AutomationElement CachedParent
        {
            get
            {
                CheckDisposed();

                try
                {
                    return AutomationElement.Wrap(this._AutomationElement.GetCachedParent());
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
                }

            }
        }

        public AutomationElementInformation Current
        {
            get
            {
                CheckDisposed();

                return new AutomationElementInformation(this, false);
            }
        }

        public UIAutomationClient.IUIAutomationElement NativeElement
        {
            get
            {
                CheckDisposed();

                return this._AutomationElement;
            }
        }

        public static AutomationElement FocusedElement
        {
            get
            {
                try
                {
                    return AutomationElement.Wrap(Automation.Factory.GetFocusedElement());
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
                }

            }
        }

        public static AutomationElement RootElement
        {
            get
            {
                try
                {
                    UIAutomationClient.IUIAutomationElement element =
                        Automation.Factory.GetRootElementBuildCache(
                            CacheRequest.CurrentNativeCacheRequest);
                    return AutomationElement.Wrap(element);
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
                }

            }
        }

        //Windows 8.1
        public void ShowContextMenu()
        {
            CheckDisposed();

            try
            {
                _AutomationElement3.ShowContextMenu();
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Exception newEx; if (Utility.ConvertException(e, out newEx)) { throw newEx; } else { throw; }
            }

        }
        
        protected override void DisposeManagedResource()
        {
            Marshal.FinalReleaseComObject(_AutomationElement);
            base.DisposeManagedResource();
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct AutomationElementInformation
        {
            private AutomationElement _el;
            private bool _isCached;
            internal AutomationElementInformation(AutomationElement el, bool isCached)
            {
                this._el = el;
                this._isCached = isCached;
            }

            public ControlType ControlType
            {
                get
                {
                    return (ControlType)this._el.GetPropertyValue(AutomationElement.ControlTypeProperty, _isCached);
                }
            }
            public string LocalizedControlType
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.LocalizedControlTypeProperty, _isCached);
                }
            }
            public string Name
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.NameProperty, _isCached);
                }
            }
            public string AcceleratorKey
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.AcceleratorKeyProperty, _isCached);
                }
            }
            public string AccessKey
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.AccessKeyProperty, _isCached);
                }
            }
            public bool HasKeyboardFocus
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.HasKeyboardFocusProperty, _isCached);
                }
            }
            public bool IsKeyboardFocusable
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.IsKeyboardFocusableProperty, _isCached);
                }
            }
            public bool IsEnabled
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.IsEnabledProperty, _isCached);
                }
            }
            public Rect BoundingRectangle
            {
                get
                {
                    return (Rect)this._el.GetPropertyValue(AutomationElement.BoundingRectangleProperty, _isCached);
                }
            }
            public string HelpText
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.HelpTextProperty, _isCached);
                }
            }
            public bool IsControlElement
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.IsControlElementProperty, _isCached);
                }
            }
            public bool IsContentElement
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.IsContentElementProperty, _isCached);
                }
            }
            public AutomationElement LabeledBy
            {
                get
                {
                    return (AutomationElement)this._el.GetPropertyValue(AutomationElement.LabeledByProperty, _isCached);
                }
            }
            public string AutomationId
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.AutomationIdProperty, _isCached);
                }
            }
            public string ItemType
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.ItemTypeProperty, _isCached);
                }
            }
            public bool IsPassword
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.IsPasswordProperty, _isCached);
                }
            }
            public string ClassName
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.ClassNameProperty, _isCached);
                }
            }
            public int NativeWindowHandle
            {
                get
                {
                    return (int)this._el.GetPropertyValue(AutomationElement.NativeWindowHandleProperty, _isCached);
                }
            }
            public int ProcessId
            {
                get
                {
                    return (int)this._el.GetPropertyValue(AutomationElement.ProcessIdProperty, _isCached);
                }
            }
            public bool IsOffscreen
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.IsOffscreenProperty, _isCached);
                }
            }
            public OrientationType Orientation
            {
                get
                {
                    return (OrientationType)this._el.GetPropertyValue(AutomationElement.OrientationProperty, _isCached);
                }
            }
            public string FrameworkId
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.FrameworkIdProperty, _isCached);
                }
            }
            public bool IsRequiredForForm
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.IsRequiredForFormProperty, _isCached);
                }
            }
            public string ItemStatus
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.ItemStatusProperty, _isCached);
                }
            }
            public string AriaRole
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.AriaRoleProperty, _isCached);
                }
            }
            public string AriaProperties
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.AriaPropertiesProperty, _isCached);
                }
            }
            public bool IsDataValidForForm
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.IsDataValidForFormProperty, _isCached);
                }
            }
            public AutomationElement ControllerFor
            {
                get
                {
                    return (AutomationElement)this._el.GetPropertyValue(AutomationElement.ControllerForProperty, _isCached);
                }
            }
            public AutomationElement DescribedBy
            {
                get
                {
                    return (AutomationElement)this._el.GetPropertyValue(AutomationElement.DescribedByProperty, _isCached);
                }
            }
            public AutomationElement FlowsTo
            {
                get
                {
                    return (AutomationElement)this._el.GetPropertyValue(AutomationElement.FlowsToProperty, _isCached);
                }
            }
            public string ProviderDescription
            {
                get
                {
                    return (string)this._el.GetPropertyValue(AutomationElement.ProviderDescriptionProperty, _isCached);
                }
            }

            public bool OptimizeForVisualContent
            {
                get
                {
                    return (bool)this._el.GetPropertyValue(AutomationElement.OptimizeForVisualContentProperty, _isCached);
                }
            }

            public LiveSetting LiveSetting
            {
                get
                {
                    return (LiveSetting)this._el.GetPropertyValue(AutomationElement.LiveSettingProperty, _isCached);
                }
            }

            public bool CurrentIsPeripheral
            {
                get
                {
                    return (bool) this._el.GetPropertyValue(AutomationElement.CurrentIsPeripheral, _isCached);
                }
            }
        }
    }
}
