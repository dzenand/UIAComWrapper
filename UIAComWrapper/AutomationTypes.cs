// (c) Copyright Microsoft, 2012.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
// All other rights reserved.


using System;
using System.Collections;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using UIAComWrapperInternal;
using UIAutomationClient;

namespace System.Windows.Automation
{
    #region Well-known properties

    public static class AutomationElementIdentifiers
    {
        public static readonly AutomationProperty AcceleratorKeyProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AcceleratorKeyPropertyId, "AutomationElementIdentifiers.AcceleratorKeyProperty");
        public static readonly AutomationProperty AccessKeyProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AccessKeyPropertyId, "AutomationElementIdentifiers.AccessKeyProperty");
        public static readonly AutomationEvent AsyncContentLoadedEvent = AutomationEvent.Register(UIA_EventIds.UIA_AsyncContentLoadedEventId, "AutomationElementIdentifiers.AsyncContentLoadedEvent");
        public static readonly AutomationEvent AutomationFocusChangedEvent = AutomationEvent.Register(UIA_EventIds.UIA_AutomationFocusChangedEventId, "AutomationElementIdentifiers.AutomationFocusChangedEvent");
        public static readonly AutomationProperty AutomationIdProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AutomationIdPropertyId, "AutomationElementIdentifiers.AutomationIdProperty");
        public static readonly AutomationEvent AutomationPropertyChangedEvent = AutomationEvent.Register(UIA_EventIds.UIA_AutomationPropertyChangedEventId, "AutomationElementIdentifiers.AutomationPropertyChangedEvent");
        public static readonly AutomationProperty BoundingRectangleProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_BoundingRectanglePropertyId, "AutomationElementIdentifiers.BoundingRectangleProperty");
        public static readonly AutomationProperty ClassNameProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ClassNamePropertyId, "AutomationElementIdentifiers.ClassNameProperty");
        public static readonly AutomationProperty ClickablePointProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ClickablePointPropertyId, "AutomationElementIdentifiers.ClickablePointProperty");
        public static readonly AutomationProperty ControlTypeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ControlTypePropertyId, "AutomationElementIdentifiers.ControlTypeProperty");
        public static readonly AutomationProperty CultureProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_CulturePropertyId, "AutomationElementIdentifiers.CultureProperty");
        public static readonly AutomationProperty FrameworkIdProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_FrameworkIdPropertyId, "AutomationElementIdentifiers.FrameworkIdProperty");
        public static readonly AutomationProperty HasKeyboardFocusProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_HasKeyboardFocusPropertyId, "AutomationElementIdentifiers.HasKeyboardFocusProperty");
        public static readonly AutomationProperty HelpTextProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_HelpTextPropertyId, "AutomationElementIdentifiers.HelpTextProperty");
        public static readonly AutomationProperty IsContentElementProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsContentElementPropertyId, "AutomationElementIdentifiers.IsContentElementProperty");
        public static readonly AutomationProperty IsControlElementProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsControlElementPropertyId, "AutomationElementIdentifiers.IsControlElementProperty");
        public static readonly AutomationProperty IsDockPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsDockPatternAvailablePropertyId, "AutomationElementIdentifiers.IsDockPatternAvailableProperty");
        public static readonly AutomationProperty IsEnabledProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsEnabledPropertyId, "AutomationElementIdentifiers.IsEnabledProperty");
        public static readonly AutomationProperty IsExpandCollapsePatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsExpandCollapsePatternAvailablePropertyId, "AutomationElementIdentifiers.IsExpandCollapsePatternAvailableProperty");
        public static readonly AutomationProperty IsGridItemPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsGridItemPatternAvailablePropertyId, "AutomationElementIdentifiers.IsGridItemPatternAvailableProperty");
        public static readonly AutomationProperty IsGridPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsGridPatternAvailablePropertyId, "AutomationElementIdentifiers.IsGridPatternAvailableProperty");
        public static readonly AutomationProperty IsInvokePatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsInvokePatternAvailablePropertyId, "AutomationElementIdentifiers.IsInvokePatternAvailableProperty");
        public static readonly AutomationProperty IsKeyboardFocusableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsKeyboardFocusablePropertyId, "AutomationElementIdentifiers.IsKeyboardFocusableProperty");
        public static readonly AutomationProperty IsMultipleViewPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsMultipleViewPatternAvailablePropertyId, "AutomationElementIdentifiers.IsMultipleViewPatternAvailableProperty");
        public static readonly AutomationProperty IsOffscreenProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsOffscreenPropertyId, "AutomationElementIdentifiers.IsOffscreenProperty");
        public static readonly AutomationProperty IsPasswordProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsPasswordPropertyId, "AutomationElementIdentifiers.IsPasswordProperty");
        public static readonly AutomationProperty IsRangeValuePatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsRangeValuePatternAvailablePropertyId, "AutomationElementIdentifiers.IsRangeValuePatternAvailableProperty");
        public static readonly AutomationProperty IsRequiredForFormProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsRequiredForFormPropertyId, "AutomationElementIdentifiers.IsRequiredForFormProperty");
        public static readonly AutomationProperty IsScrollItemPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsScrollItemPatternAvailablePropertyId, "AutomationElementIdentifiers.IsScrollItemPatternAvailableProperty");
        public static readonly AutomationProperty IsScrollPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsScrollPatternAvailablePropertyId, "AutomationElementIdentifiers.IsScrollPatternAvailableProperty");
        public static readonly AutomationProperty IsSelectionItemPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsSelectionItemPatternAvailablePropertyId, "AutomationElementIdentifiers.IsSelectionItemPatternAvailableProperty");
        public static readonly AutomationProperty IsSelectionPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsSelectionPatternAvailablePropertyId, "AutomationElementIdentifiers.IsSelectionPatternAvailableProperty");
        public static readonly AutomationProperty IsTableItemPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsTableItemPatternAvailablePropertyId, "AutomationElementIdentifiers.IsTableItemPatternAvailableProperty");
        public static readonly AutomationProperty IsTablePatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsTablePatternAvailablePropertyId, "AutomationElementIdentifiers.IsTablePatternAvailableProperty");
        public static readonly AutomationProperty IsTextPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsTextPatternAvailablePropertyId, "AutomationElementIdentifiers.IsTextPatternAvailableProperty");
        public static readonly AutomationProperty IsTogglePatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsTogglePatternAvailablePropertyId, "AutomationElementIdentifiers.IsTogglePatternAvailableProperty");
        public static readonly AutomationProperty IsTransformPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsTransformPatternAvailablePropertyId, "AutomationElementIdentifiers.IsTransformPatternAvailableProperty");
        public static readonly AutomationProperty IsValuePatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsValuePatternAvailablePropertyId, "AutomationElementIdentifiers.IsValuePatternAvailableProperty");
        public static readonly AutomationProperty IsWindowPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsWindowPatternAvailablePropertyId, "AutomationElementIdentifiers.IsWindowPatternAvailableProperty");
        public static readonly AutomationProperty ItemStatusProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ItemStatusPropertyId, "AutomationElementIdentifiers.ItemStatusProperty");
        public static readonly AutomationProperty ItemTypeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ItemTypePropertyId, "AutomationElementIdentifiers.ItemTypeProperty");
        public static readonly AutomationProperty LabeledByProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LabeledByPropertyId, "AutomationElementIdentifiers.LabeledByProperty");
        public static readonly AutomationEvent LayoutInvalidatedEvent = AutomationEvent.Register(UIA_EventIds.UIA_LayoutInvalidatedEventId, "AutomationElementIdentifiers.LayoutInvalidatedEvent");
        public static readonly AutomationProperty LocalizedControlTypeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LocalizedControlTypePropertyId, "AutomationElementIdentifiers.LocalizedControlTypeProperty");
        public static readonly AutomationEvent MenuClosedEvent = AutomationEvent.Register(UIA_EventIds.UIA_MenuClosedEventId, "AutomationElementIdentifiers.MenuClosedEvent");
        public static readonly AutomationEvent MenuOpenedEvent = AutomationEvent.Register(UIA_EventIds.UIA_MenuOpenedEventId, "AutomationElementIdentifiers.MenuOpenedEvent");
        public static readonly AutomationProperty NameProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_NamePropertyId, "AutomationElementIdentifiers.NameProperty");
        public static readonly AutomationProperty NativeWindowHandleProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_NativeWindowHandlePropertyId, "AutomationElementIdentifiers.NativeWindowHandleProperty");
        public static readonly object NotSupported = Automation.Factory.ReservedNotSupportedValue;
        public static readonly AutomationProperty OrientationProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_OrientationPropertyId, "AutomationElementIdentifiers.OrientationProperty");
        public static readonly AutomationProperty ProcessIdProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ProcessIdPropertyId, "AutomationElementIdentifiers.ProcessIdProperty");
        public static readonly AutomationProperty RuntimeIdProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_RuntimeIdPropertyId, "AutomationElementIdentifiers.RuntimeIdProperty");
        public static readonly AutomationEvent StructureChangedEvent = AutomationEvent.Register(UIA_EventIds.UIA_StructureChangedEventId, "AutomationElementIdentifiers.StructureChangedEvent");
        public static readonly AutomationEvent ToolTipClosedEvent = AutomationEvent.Register(UIA_EventIds.UIA_ToolTipClosedEventId, "AutomationElementIdentifiers.ToolTipClosedEvent");
        public static readonly AutomationEvent ToolTipOpenedEvent = AutomationEvent.Register(UIA_EventIds.UIA_ToolTipOpenedEventId, "AutomationElementIdentifiers.ToolTipOpenedEvent");

        // New for Windows 7
        //

        public static readonly AutomationProperty IsLegacyIAccessiblePatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsLegacyIAccessiblePatternAvailablePropertyId, "AutomationElementIdentifiers.IsLegacyIAccessiblePatternAvailableProperty");
        public static readonly AutomationProperty IsItemContainerPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsItemContainerPatternAvailablePropertyId, "AutomationElementIdentifiers.IsItemContainerPatternAvailableProperty");
        public static readonly AutomationProperty IsVirtualizedItemPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsVirtualizedItemPatternAvailablePropertyId, "AutomationElementIdentifiers.IsVirtualizedItemPatternAvailableProperty");
        public static readonly AutomationProperty IsSynchronizedInputPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsSynchronizedInputPatternAvailablePropertyId, "AutomationElementIdentifiers.IsSynchronizedInputPatternAvailableProperty");

        public static readonly AutomationProperty AriaRoleProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AriaRolePropertyId, "AutomationElementIdentifiers.AriaRoleProperty");
        public static readonly AutomationProperty AriaPropertiesProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AriaPropertiesPropertyId, "AutomationElementIdentifiers.AriaPropertiesProperty");
        public static readonly AutomationProperty IsDataValidForFormProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsDataValidForFormPropertyId, "AutomationElementIdentifiers.IsDataValidForFormProperty");
        public static readonly AutomationProperty ControllerForProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ControllerForPropertyId, "AutomationElementIdentifiers.ControllerForProperty");
        public static readonly AutomationProperty DescribedByProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_DescribedByPropertyId, "AutomationElementIdentifiers.DescribedByProperty");
        public static readonly AutomationProperty FlowsToProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_FlowsToPropertyId, "AutomationElementIdentifiers.FlowsToProperty");
        public static readonly AutomationProperty ProviderDescriptionProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ProviderDescriptionPropertyId, "AutomationElementIdentifiers.Property");

        public static readonly AutomationEvent MenuModeStartEvent = AutomationEvent.Register(UIA_EventIds.UIA_MenuModeStartEventId, "AutomationElementIdentifiers.MenuModeStartEvent");
        public static readonly AutomationEvent MenuModeEndEvent = AutomationEvent.Register(UIA_EventIds.UIA_MenuModeEndEventId, "AutomationElementIdentifiers.MenuModeEndEvent");

        // New for Windows 8
        //

        public static readonly AutomationProperty IsObjectModelPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsObjectModelPatternAvailablePropertyId, "AutomationElementIdentifiers.IsObjectModelPatternAvailableProperty");
        public static readonly AutomationProperty IsAnnotationPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsAnnotationPatternAvailablePropertyId, "AutomationElementIdentifiers.IsAnnotationPatternAvailableProperty");
        public static readonly AutomationProperty IsTextPattern2AvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsTextPattern2AvailablePropertyId, "AutomationElementIdentifiers.IsTextPattern2AvailableProperty");
        public static readonly AutomationProperty IsStylesPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsStylesPatternAvailablePropertyId, "AutomationElementIdentifiers.IsStylesPatternAvailableProperty");
        public static readonly AutomationProperty IsSpreadsheetPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsSpreadsheetPatternAvailablePropertyId, "AutomationElementIdentifiers.IsSpreadsheetPatternAvailableProperty");
        public static readonly AutomationProperty IsSpreadsheetItemPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsSpreadsheetItemPatternAvailablePropertyId, "AutomationElementIdentifiers.IsSpreadsheetItemPatternAvailableProperty");
        public static readonly AutomationProperty IsTransformPattern2AvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsTransformPattern2AvailablePropertyId, "AutomationElementIdentifiers.IsTransformPattern2AvailableProperty");
        public static readonly AutomationProperty IsTextChildPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsTextChildPatternAvailablePropertyId, "AutomationElementIdentifiers.IsTextChildPatternAvailableProperty");
        public static readonly AutomationProperty IsDragPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsDragPatternAvailablePropertyId, "AutomationElementIdentifiers.IsDragPatternAvailableProperty");
        public static readonly AutomationProperty IsDropTargetPatternAvailableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_IsDropTargetPatternAvailablePropertyId, "AutomationElementIdentifiers.IsDropTargetPatternAvailableProperty");

        public static readonly AutomationProperty OptimizeForVisualContentProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_OptimizeForVisualContentPropertyId, "AutomationElementIdentifiers.OptimizeForVisualContentProperty");
        public static readonly AutomationProperty LiveSettingProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LiveSettingPropertyId, "AutomationElementIdentifiers.LiveSettingProperty");

        public static readonly AutomationEvent SystemAlertEvent = AutomationEvent.Register(UIA_EventIds.UIA_SystemAlertEventId, "AutomationElementIdentifiers.SystemAlertEvent");
        public static readonly AutomationEvent LiveRegionChangedEvent = AutomationEvent.Register(UIA_EventIds.UIA_LiveRegionChangedEventId, "AutomationElementIdentifiers.LiveRegionChangedEvent");
        public static readonly AutomationEvent HostedFragmentRootsInvalidatedEvent = AutomationEvent.Register(UIA_EventIds.UIA_HostedFragmentRootsInvalidatedEventId, "AutomationElementIdentifiers.HostedFragmentRootsInvalidatedEvent");

        //New for Windows 8.1
        public static readonly AutomationEvent EditTextChangedEvent = AutomationEvent.Register(UIA_EventIds.UIA_TextEdit_TextChangedEventId, "AutomationElementIdentifiers.TextEditTextChangedEvent");

        public static readonly AutomationProperty CurrentIsPeripheral = AutomationProperty.Register(UIA_PropertyIds.UIA_IsPeripheralPropertyId, "AutomationElementIdentifiers.IsPeripheralProperty");


    }

    public static class DockPatternIdentifiers
    {

        public static readonly AutomationProperty DockPositionProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_DockDockPositionPropertyId, "DockPatternIdentifiers.DockPositionProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_DockPatternId, "DockPatternIdentifiers.Pattern");
    }

    public static class ExpandCollapsePatternIdentifiers
    {

        public static readonly AutomationProperty ExpandCollapseStateProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ExpandCollapseExpandCollapseStatePropertyId, "ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_ExpandCollapsePatternId, "ExpandCollapsePatternIdentifiers.Pattern");
    }

    public static class GridItemPatternIdentifiers
    {

        public static readonly AutomationProperty ColumnProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_GridItemColumnPropertyId, "GridItemPatternIdentifiers.ColumnProperty");
        public static readonly AutomationProperty ColumnSpanProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_GridItemColumnSpanPropertyId, "GridItemPatternIdentifiers.ColumnSpanProperty");
        public static readonly AutomationProperty ContainingGridProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_GridItemContainingGridPropertyId, "GridItemPatternIdentifiers.ContainingGridProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_GridItemPatternId, "GridItemPatternIdentifiers.Pattern");
        public static readonly AutomationProperty RowProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_GridItemRowPropertyId, "GridItemPatternIdentifiers.RowProperty");
        public static readonly AutomationProperty RowSpanProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_GridItemRowSpanPropertyId, "GridItemPatternIdentifiers.RowSpanProperty");
    }

    public static class GridPatternIdentifiers
    {

        public static readonly AutomationProperty ColumnCountProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_GridColumnCountPropertyId, "GridPatternIdentifiers.ColumnCountProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_GridPatternId, "GridPatternIdentifiers.Pattern");
        public static readonly AutomationProperty RowCountProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_GridRowCountPropertyId, "GridPatternIdentifiers.RowCountProperty");
    }

    public static class InvokePatternIdentifiers
    {

        public static readonly AutomationEvent InvokedEvent = AutomationEvent.Register(UIA_EventIds.UIA_Invoke_InvokedEventId, "InvokePatternIdentifiers.InvokedEvent");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_InvokePatternId, "InvokePatternIdentifiers.Pattern");
    }

    public static class MultipleViewPatternIdentifiers
    {

        public static readonly AutomationProperty CurrentViewProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_MultipleViewCurrentViewPropertyId, "MultipleViewPatternIdentifiers.CurrentViewProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_MultipleViewPatternId, "MultipleViewPatternIdentifiers.Pattern");
        public static readonly AutomationProperty SupportedViewsProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_MultipleViewSupportedViewsPropertyId, "MultipleViewPatternIdentifiers.SupportedViewsProperty");
    }

    public static class RangeValuePatternIdentifiers
    {

        public static readonly AutomationProperty IsReadOnlyProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_RangeValueIsReadOnlyPropertyId, "RangeValuePatternIdentifiers.IsReadOnlyProperty");
        public static readonly AutomationProperty LargeChangeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_RangeValueLargeChangePropertyId, "RangeValuePatternIdentifiers.LargeChangeProperty");
        public static readonly AutomationProperty MaximumProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_RangeValueMaximumPropertyId, "RangeValuePatternIdentifiers.MaximumProperty");
        public static readonly AutomationProperty MinimumProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_RangeValueMinimumPropertyId, "RangeValuePatternIdentifiers.MinimumProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_RangeValuePatternId, "RangeValuePatternIdentifiers.Pattern");
        public static readonly AutomationProperty SmallChangeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_RangeValueSmallChangePropertyId, "RangeValuePatternIdentifiers.SmallChangeProperty");
        public static readonly AutomationProperty ValueProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_RangeValueValuePropertyId, "RangeValuePatternIdentifiers.ValueProperty");
    }

    public static class ScrollItemPatternIdentifiers
    {

        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_ScrollItemPatternId, "ScrollItemPatternIdentifiers.Pattern");
    }

    public static class ScrollPatternIdentifiers
    {

        public static readonly AutomationProperty HorizontallyScrollableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ScrollHorizontallyScrollablePropertyId, "ScrollPatternIdentifiers.HorizontallyScrollableProperty");
        public static readonly AutomationProperty HorizontalScrollPercentProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ScrollHorizontalScrollPercentPropertyId, "ScrollPatternIdentifiers.HorizontalScrollPercentProperty");
        public static readonly AutomationProperty HorizontalViewSizeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ScrollHorizontalViewSizePropertyId, "ScrollPatternIdentifiers.HorizontalViewSizeProperty");
        public const double NoScroll = -1.0;
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_ScrollPatternId, "ScrollPatternIdentifiers.Pattern");
        public static readonly AutomationProperty VerticallyScrollableProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ScrollVerticallyScrollablePropertyId, "ScrollPatternIdentifiers.VerticallyScrollableProperty");
        public static readonly AutomationProperty VerticalScrollPercentProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ScrollVerticalScrollPercentPropertyId, "ScrollPatternIdentifiers.VerticalScrollPercentProperty");
        public static readonly AutomationProperty VerticalViewSizeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ScrollVerticalViewSizePropertyId, "ScrollPatternIdentifiers.VerticalViewSizeProperty");
    }

    public static class SelectionItemPatternIdentifiers
    {

        public static readonly AutomationEvent ElementAddedToSelectionEvent = AutomationEvent.Register(UIA_EventIds.UIA_SelectionItem_ElementAddedToSelectionEventId, "SelectionItemPatternIdentifiers.ElementAddedToSelectionEvent");
        public static readonly AutomationEvent ElementRemovedFromSelectionEvent = AutomationEvent.Register(UIA_EventIds.UIA_SelectionItem_ElementRemovedFromSelectionEventId, "SelectionItemPatternIdentifiers.ElementRemovedFromSelectionEvent");
        public static readonly AutomationEvent ElementSelectedEvent = AutomationEvent.Register(UIA_EventIds.UIA_SelectionItem_ElementSelectedEventId, "SelectionItemPatternIdentifiers.ElementSelectedEvent");
        public static readonly AutomationProperty IsSelectedProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SelectionItemIsSelectedPropertyId, "SelectionItemPatternIdentifiers.IsSelectedProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_SelectionItemPatternId, "SelectionItemPatternIdentifiers.Pattern");
        public static readonly AutomationProperty SelectionContainerProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SelectionItemSelectionContainerPropertyId, "SelectionItemPatternIdentifiers.SelectionContainerProperty");
    }

    public static class SelectionPatternIdentifiers
    {

        public static readonly AutomationProperty CanSelectMultipleProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SelectionCanSelectMultiplePropertyId, "SelectionPatternIdentifiers.CanSelectMultipleProperty");
        public static readonly AutomationEvent InvalidatedEvent = AutomationEvent.Register(UIA_EventIds.UIA_Selection_InvalidatedEventId, "SelectionPatternIdentifiers.InvalidatedEvent");
        public static readonly AutomationProperty IsSelectionRequiredProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SelectionIsSelectionRequiredPropertyId, "SelectionPatternIdentifiers.IsSelectionRequiredProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_SelectionPatternId, "SelectionPatternIdentifiers.Pattern");
        public static readonly AutomationProperty SelectionProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SelectionSelectionPropertyId, "SelectionPatternIdentifiers.SelectionProperty");
    }

    public static class TableItemPatternIdentifiers
    {

        public static readonly AutomationProperty ColumnHeaderItemsProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_TableItemColumnHeaderItemsPropertyId, "TableItemPatternIdentifiers.ColumnHeaderItemsProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_TableItemPatternId, "TableItemPatternIdentifiers.Pattern");
        public static readonly AutomationProperty RowHeaderItemsProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_TableItemRowHeaderItemsPropertyId, "TableItemPatternIdentifiers.RowHeaderItemsProperty");
    }

    public static class TablePatternIdentifiers
    {

        public static readonly AutomationProperty ColumnHeadersProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_TableColumnHeadersPropertyId, "TablePatternIdentifiers.ColumnHeadersProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_TablePatternId, "TablePatternIdentifiers.Pattern");
        public static readonly AutomationProperty RowHeadersProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_TableRowHeadersPropertyId, "TablePatternIdentifiers.RowHeadersProperty");
        public static readonly AutomationProperty RowOrColumnMajorProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_TableRowOrColumnMajorPropertyId, "TablePatternIdentifiers.RowOrColumnMajorProperty");
    }

    public static class TextPatternIdentifiers
    {

        public static readonly AutomationTextAttribute AnimationStyleAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_AnimationStyleAttributeId, "TextPatternIdentifiers.AnimationStyleAttribute");
        public static readonly AutomationTextAttribute BackgroundColorAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_BackgroundColorAttributeId, "TextPatternIdentifiers.BackgroundColorAttribute");
        public static readonly AutomationTextAttribute BulletStyleAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_BulletStyleAttributeId, "TextPatternIdentifiers.BulletStyleAttribute");
        public static readonly AutomationTextAttribute CapStyleAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_CapStyleAttributeId, "TextPatternIdentifiers.CapStyleAttribute");
        public static readonly AutomationTextAttribute CultureAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_CultureAttributeId, "TextPatternIdentifiers.CultureAttribute");
        public static readonly AutomationTextAttribute FontNameAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_FontNameAttributeId, "TextPatternIdentifiers.FontNameAttribute");
        public static readonly AutomationTextAttribute FontSizeAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_FontSizeAttributeId, "TextPatternIdentifiers.FontSizeAttribute");
        public static readonly AutomationTextAttribute FontWeightAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_FontWeightAttributeId, "TextPatternIdentifiers.FontWeightAttribute");
        public static readonly AutomationTextAttribute ForegroundColorAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_ForegroundColorAttributeId, "TextPatternIdentifiers.ForegroundColorAttribute");
        public static readonly AutomationTextAttribute HorizontalTextAlignmentAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_HorizontalTextAlignmentAttributeId, "TextPatternIdentifiers.HorizontalTextAlignmentAttribute");
        public static readonly AutomationTextAttribute IndentationFirstLineAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IndentationFirstLineAttributeId, "TextPatternIdentifiers.IndentationFirstLineAttribute");
        public static readonly AutomationTextAttribute IndentationLeadingAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IndentationLeadingAttributeId, "TextPatternIdentifiers.IndentationLeadingAttribute");
        public static readonly AutomationTextAttribute IndentationTrailingAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IndentationTrailingAttributeId, "TextPatternIdentifiers.IndentationTrailingAttribute");
        public static readonly AutomationTextAttribute IsHiddenAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IsHiddenAttributeId, "TextPatternIdentifiers.IsHiddenAttribute");
        public static readonly AutomationTextAttribute IsItalicAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IsItalicAttributeId, "TextPatternIdentifiers.IsItalicAttribute");
        public static readonly AutomationTextAttribute IsReadOnlyAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IsReadOnlyAttributeId, "TextPatternIdentifiers.IsReadOnlyAttribute");
        public static readonly AutomationTextAttribute IsSubscriptAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IsSubscriptAttributeId, "TextPatternIdentifiers.IsSubscriptAttribute");
        public static readonly AutomationTextAttribute IsSuperscriptAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IsSuperscriptAttributeId, "TextPatternIdentifiers.IsSuperscriptAttribute");
        public static readonly AutomationTextAttribute MarginBottomAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_MarginBottomAttributeId, "TextPatternIdentifiers.MarginBottomAttribute");
        public static readonly AutomationTextAttribute MarginLeadingAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_MarginLeadingAttributeId, "TextPatternIdentifiers.MarginLeadingAttribute");
        public static readonly AutomationTextAttribute MarginTopAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_MarginTopAttributeId, "TextPatternIdentifiers.MarginTopAttribute");
        public static readonly AutomationTextAttribute MarginTrailingAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_MarginTrailingAttributeId, "TextPatternIdentifiers.MarginTrailingAttribute");
        public static readonly object MixedAttributeValue = Automation.Factory.ReservedMixedAttributeValue;
        public static readonly AutomationTextAttribute OutlineStylesAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_OutlineStylesAttributeId, "TextPatternIdentifiers.OutlineStylesAttribute");
        public static readonly AutomationTextAttribute OverlineColorAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_OverlineColorAttributeId, "TextPatternIdentifiers.OverlineColorAttribute");
        public static readonly AutomationTextAttribute OverlineStyleAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_OverlineStyleAttributeId, "TextPatternIdentifiers.OverlineStyleAttribute");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_TextPatternId, "TextPatternIdentifiers.Pattern");
        public static readonly AutomationTextAttribute StrikethroughColorAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_StrikethroughColorAttributeId, "TextPatternIdentifiers.StrikethroughColorAttribute");
        public static readonly AutomationTextAttribute StrikethroughStyleAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_StrikethroughStyleAttributeId, "TextPatternIdentifiers.StrikethroughStyleAttribute");
        public static readonly AutomationTextAttribute TabsAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_TabsAttributeId, "TextPatternIdentifiers.TabsAttribute");
        public static readonly AutomationEvent TextChangedEvent = AutomationEvent.Register(UIA_EventIds.UIA_Text_TextChangedEventId, "TextPatternIdentifiers.TextChangedEvent");
        public static readonly AutomationTextAttribute TextFlowDirectionsAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_TextFlowDirectionsAttributeId, "TextPatternIdentifiers.TextFlowDirectionsAttribute");
        public static readonly AutomationEvent TextSelectionChangedEvent = AutomationEvent.Register(UIA_EventIds.UIA_Text_TextSelectionChangedEventId, "TextPatternIdentifiers.TextSelectionChangedEvent");
        public static readonly AutomationTextAttribute UnderlineColorAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_UnderlineColorAttributeId, "TextPatternIdentifiers.UnderlineColorAttribute");
        public static readonly AutomationTextAttribute UnderlineStyleAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_UnderlineStyleAttributeId, "TextPatternIdentifiers.UnderlineStyleAttribute");
    }

    public static class TogglePatternIdentifiers
    {

        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_TogglePatternId, "TogglePatternIdentifiers.Pattern");
        public static readonly AutomationProperty ToggleStateProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ToggleToggleStatePropertyId, "TogglePatternIdentifiers.ToggleStateProperty");
    }

    public static class TransformPatternIdentifiers
    {

        public static readonly AutomationProperty CanMoveProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_TransformCanMovePropertyId, "TransformPatternIdentifiers.CanMoveProperty");
        public static readonly AutomationProperty CanResizeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_TransformCanResizePropertyId, "TransformPatternIdentifiers.CanResizeProperty");
        public static readonly AutomationProperty CanRotateProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_TransformCanRotatePropertyId, "TransformPatternIdentifiers.CanRotateProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_TransformPatternId, "TransformPatternIdentifiers.Pattern");
    }

    public static class ValuePatternIdentifiers
    {

        public static readonly AutomationProperty IsReadOnlyProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ValueIsReadOnlyPropertyId, "ValuePatternIdentifiers.IsReadOnlyProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_ValuePatternId, "ValuePatternIdentifiers.Pattern");
        public static readonly AutomationProperty ValueProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_ValueValuePropertyId, "ValuePatternIdentifiers.ValueProperty");
    }

    public static class WindowPatternIdentifiers
    {

        public static readonly AutomationProperty CanMaximizeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_WindowCanMaximizePropertyId, "WindowPatternIdentifiers.CanMaximizeProperty");
        public static readonly AutomationProperty CanMinimizeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_WindowCanMinimizePropertyId, "WindowPatternIdentifiers.CanMinimizeProperty");
        public static readonly AutomationProperty IsModalProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_WindowIsModalPropertyId, "WindowPatternIdentifiers.IsModalProperty");
        public static readonly AutomationProperty IsTopmostProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_WindowIsTopmostPropertyId, "WindowPatternIdentifiers.IsTopmostProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_WindowPatternId, "WindowPatternIdentifiers.Pattern");
        public static readonly AutomationEvent WindowClosedEvent = AutomationEvent.Register(UIA_EventIds.UIA_Window_WindowClosedEventId, "WindowPatternIdentifiers.WindowClosedProperty");
        public static readonly AutomationProperty WindowInteractionStateProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_WindowWindowInteractionStatePropertyId, "WindowPatternIdentifiers.WindowInteractionStateProperty");
        public static readonly AutomationEvent WindowOpenedEvent = AutomationEvent.Register(UIA_EventIds.UIA_Window_WindowOpenedEventId, "WindowPatternIdentifiers.WindowOpenedProperty");
        public static readonly AutomationProperty WindowVisualStateProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_WindowWindowVisualStatePropertyId, "WindowPatternIdentifiers.WindowVisualStateProperty");
    }

    // New for Windows 7
    //
    public static class LegacyIAccessiblePatternIdentifiers
    {
        public static readonly AutomationProperty ChildIdProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleChildIdPropertyId, "LegacyIAccessiblePatternIdentifiers.ChildIdProperty");
        public static readonly AutomationProperty NameProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleNamePropertyId, "LegacyIAccessiblePatternIdentifiers.NameProperty");
        public static readonly AutomationProperty ValueProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleValuePropertyId, "LegacyIAccessiblePatternIdentifiers.ValueProperty");
        public static readonly AutomationProperty DescriptionProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleDescriptionPropertyId, "LegacyIAccessiblePatternIdentifiers.DescriptionProperty");
        public static readonly AutomationProperty RoleProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleRolePropertyId, "LegacyIAccessiblePatternIdentifiers.RoleProperty");
        public static readonly AutomationProperty StateProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleStatePropertyId, "LegacyIAccessiblePatternIdentifiers.StateProperty");
        public static readonly AutomationProperty HelpProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleHelpPropertyId, "LegacyIAccessiblePatternIdentifiers.HelpProperty");
        public static readonly AutomationProperty KeyboardShortcutProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleKeyboardShortcutPropertyId, "LegacyIAccessiblePatternIdentifiers.KeyboardShortcutProperty");
        public static readonly AutomationProperty SelectionProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleSelectionPropertyId, "LegacyIAccessiblePatternIdentifiers.SelectionProperty");
        public static readonly AutomationProperty DefaultActionProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_LegacyIAccessibleDefaultActionPropertyId, "LegacyIAccessiblePatternIdentifiers.DefaultActionProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_LegacyIAccessiblePatternId, "LegacyIAccessiblePatternIdentifiers.Pattern");
    }

    public static class ItemContainerPatternIdentifiers
    {
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_ItemContainerPatternId, "ItemContainerPatternIdentifiers.Pattern");
    }

    public static class VirtualizedItemPatternIdentifiers
    {
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_VirtualizedItemPatternId, "VirtualizedItemPatternIdentifiers.Pattern");
    }

    public static class SynchronizedInputPatternIdentifiers
    {
        public static readonly AutomationEvent InputReachedTargetEvent = AutomationEvent.Register(UIA_EventIds.UIA_InputReachedTargetEventId, "SynchronizedInputPatternIdentifiers.InputReachedTargetEvent");
        public static readonly AutomationEvent InputReachedOtherElementEvent = AutomationEvent.Register(UIA_EventIds.UIA_InputReachedOtherElementEventId, "SynchronizedInputPatternIdentifiers.InputReachedOtherElementEvent");
        public static readonly AutomationEvent InputDiscardedEvent = AutomationEvent.Register(UIA_EventIds.UIA_InputDiscardedEventId, "SynchronizedInputPatternIdentifiers.InputDiscardedEvent");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_SynchronizedInputPatternId, "SynchronizedInputPatternIdentifiers.Pattern");
    }

    // New for Windows 8
    //

    public static class ObjectModelPatternIdentifiers
    {
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_ObjectModelPatternId, "ObjectModelPatternIdentifiers.Pattern");
    }

    public static class AnnotationPatternIdentifiers
    {
        public static readonly AutomationProperty AnnotationTypeIdProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AnnotationAnnotationTypeIdPropertyId, "AnnotationPatternIdentifiers.AnnotationTypeIdProperty");
        public static readonly AutomationProperty AnnotationTypeNameProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AnnotationAnnotationTypeNamePropertyId, "AnnotationPatternIdentifiers.AnnotationTypeNameProperty");
        public static readonly AutomationProperty AuthorProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SpreadsheetItemAnnotationTypesPropertyId, "AnnotationPatternIdentifiers.AuthorProperty");
        public static readonly AutomationProperty DateTimeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AnnotationDateTimePropertyId, "AnnotationPatternIdentifiers.DateTimeProperty");
        public static readonly AutomationProperty TargetProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_AnnotationTargetPropertyId, "AnnotationPatternIdentifiers.TargetProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_AnnotationPatternId, "AnnotationPatternIdentifiers.Pattern");
    }

    public static class TextPattern2Identifiers
    {
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_TextPattern2Id, "TextPattern2Identifiers.Pattern");
        public static readonly AutomationTextAttribute AnnotationTypesAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_AnnotationTypesAttributeId, "TextPatternIdentifiers.AnnotationTypesAttribute");
        public static readonly AutomationTextAttribute AnnotationObjectsAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_AnnotationObjectsAttributeId, "TextPatternIdentifiers.AnnotationObjectsAttribute");
        public static readonly AutomationTextAttribute StyleNameAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_StyleNameAttributeId, "TextPatternIdentifiers.StyleNameAttribute");
        public static readonly AutomationTextAttribute StyleIdAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_StyleIdAttributeId, "TextPatternIdentifiers.StyleIdAttribute");
        public static readonly AutomationTextAttribute LinkAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_LinkAttributeId, "TextPatternIdentifiers.LinkAttribute");
        public static readonly AutomationTextAttribute IsActiveAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_IsActiveAttributeId, "TextPatternIdentifiers.IsActiveAttribute");
        public static readonly AutomationTextAttribute SelectionActiveEndAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_SelectionActiveEndAttributeId, "TextPatternIdentifiers.SelectionActiveEndAttribute");
        public static readonly AutomationTextAttribute CaretPositionAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_CaretPositionAttributeId, "TextPatternIdentifiers.CaretPositionAttribute");
        public static readonly AutomationTextAttribute CaretBidiModeAttribute = AutomationTextAttribute.Register(UIA_TextAttributeIds.UIA_CaretBidiModeAttributeId, "TextPatternIdentifiers.CaretBidiModeAttribute");
    }

    public static class StylesPatternIdentifiers
    {
        public static readonly AutomationProperty StyleIdProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_StylesStyleIdPropertyId, "StylesPatternIdentifiers.StyleIdProperty");
        public static readonly AutomationProperty StyleNameProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_StylesStyleNamePropertyId, "StylesPatternIdentifiers.StyleNameProperty");
        public static readonly AutomationProperty FillColorProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_StylesFillColorPropertyId, "StylesPatternIdentifiers.FillColorProperty");
        public static readonly AutomationProperty FillPatternStyleProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_StylesFillPatternStylePropertyId, "StylesPatternIdentifiers.FillPatternStyleProperty");
        public static readonly AutomationProperty ShapeProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_StylesShapePropertyId, "StylesPatternIdentifiers.ShapeProperty");
        public static readonly AutomationProperty FillPatternColorProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_StylesFillPatternColorPropertyId, "StylesPatternIdentifiers.FillPatternColorProperty");
        public static readonly AutomationProperty ExtendedPropertiesProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_StylesExtendedPropertiesPropertyId, "StylesPatternIdentifiers.ExtendedPropertiesProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_StylesPatternId, "StylesPatternIdentifiers.Pattern");

    }

    public static class SpreadsheetPatternIdentifiers
    {
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_SpreadsheetPatternId, "SpreadsheetPatternIdentifiers.Pattern");
    }

    public static class SpreadsheetItemPatternIdentifiers
    {
        public static readonly AutomationProperty FormulaProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SpreadsheetItemFormulaPropertyId, "SpreadsheetItemPatternIdentifiers.FormulaProperty");
        public static readonly AutomationProperty AnnotationObjectsProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SpreadsheetItemAnnotationObjectsPropertyId, "SpreadsheetItemPatternIdentifiers.AnnotationObjectsProperty");
        public static readonly AutomationProperty AnnotationTypesProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_SpreadsheetItemAnnotationTypesPropertyId, "SpreadsheetItemPatternIdentifiers.AnnotationTypesProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_SpreadsheetItemPatternId, "SpreadsheetItemPatternIdentifiers.Pattern");
    }

    public static class TransformPattern2Identifiers
    {
        public static readonly AutomationProperty CanZoomProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_Transform2CanZoomPropertyId, "TransformPattern2Identifiers.CanZoomProperty");
        public static readonly AutomationProperty ZoomLevelProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_Transform2ZoomLevelPropertyId, "TransformPattern2Identifiers.ZoomLevelProperty");
        public static readonly AutomationProperty ZoomMinimumProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_Transform2ZoomMinimumPropertyId, "TransformPattern2Identifiers.ZoomMinimumProperty");
        public static readonly AutomationProperty ZoomMaximumProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_Transform2ZoomMaximumPropertyId, "TransformPattern2Identifiers.ZoomMaximumProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_TransformPattern2Id, "TransformPattern2Identifiers.Pattern");
    }

    public static class TextChildPatternIdentifiers
    {
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_TextChildPatternId, "TextChildPatternIdentifiers.Pattern");
    }

    public static class DragPatternIdentifiers
    {
        public static readonly AutomationProperty IsGrabbedProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_DragIsGrabbedPropertyId, "DragPatternIdentifiers.IsGrabbedProperty");
        public static readonly AutomationProperty GrabbedItemsProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_DragGrabbedItemsPropertyId, "DragPatternIdentifiers.GrabbedItemsProperty");
        public static readonly AutomationProperty DropEffectProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_DragDropEffectPropertyId, "DragPatternIdentifiers.DropEffectProperty");
        public static readonly AutomationProperty DropEffectsProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_DragDropEffectsPropertyId, "DragPatternIdentifiers.DropEffectsProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_DragPatternId, "DragPatternIdentifiers.Pattern");
        public static readonly AutomationEvent DragStartEvent = AutomationEvent.Register(UIA_EventIds.UIA_Drag_DragStartEventId, "DragPatternIdentifiers.DragStartEvent");
        public static readonly AutomationEvent DragCancelEvent = AutomationEvent.Register(UIA_EventIds.UIA_Drag_DragCancelEventId, "DragPatternIdentifiers.DragCancelEvent");
        public static readonly AutomationEvent DragCompleteEvent = AutomationEvent.Register(UIA_EventIds.UIA_Drag_DragCompleteEventId, "DragPatternIdentifiers.DragCompleteEvent");
    }

    public static class DropTargetPatternIdentifiers
    {
        public static readonly AutomationProperty DropTargetEffectProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_DropTargetDropTargetEffectPropertyId, "DropTargetPatternIdentifiers.DropTargetEffectProperty");
        public static readonly AutomationProperty DropTargetEffectsProperty = AutomationProperty.Register(UIA_PropertyIds.UIA_DropTargetDropTargetEffectsPropertyId, "DropTargetPatternIdentifiers.DropTargetEffectsProperty");
        public static readonly AutomationPattern Pattern = AutomationPattern.Register(UIA_PatternIds.UIA_DropTargetPatternId, "DropTargetPatternIdentifiers.Pattern");
        public static readonly AutomationEvent DragEnterEvent = AutomationEvent.Register(UIA_EventIds.UIA_DropTarget_DragEnterEventId, "DropTargetPatternIdentifiers.DragEnterEvent");
        public static readonly AutomationEvent DragLeaveEvent = AutomationEvent.Register(UIA_EventIds.UIA_DropTarget_DragLeaveEventId, "DropTargetPatternIdentifiers.DragLeaveEvent");
        public static readonly AutomationEvent DroppedEvent = AutomationEvent.Register(UIA_EventIds.UIA_DropTarget_DroppedEventId, "DropTargetPatternIdentifiers.DroppedEvent");
    }

    #endregion

    #region Identifier classes

    /// <summary>
    /// Core Automation Identifier - essentially a wrapped integer
    /// </summary>
    public class AutomationIdentifier : IComparable
    {

        private int _id;
        private static Hashtable _identifierDirectory = new Hashtable(200, 1f);
        private string _programmaticName;
        private UiaCoreIds.AutomationIdType _type;


        internal AutomationIdentifier(UiaCoreIds.AutomationIdType type, int id, string programmaticName)
        {
            this._id = id;
            this._type = type;
            this._programmaticName = programmaticName;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }
            return (this.GetHashCode() - obj.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            AutomationIdentifier objAutomationIdentifier;
            if (obj == null || (objAutomationIdentifier = (obj as AutomationIdentifier)) == null)
            {
                return false;
            }

            return (objAutomationIdentifier == this);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        internal static AutomationIdentifier LookupById(UiaCoreIds.AutomationIdType type, int id)
        {
            AutomationIdentifier identifier;
            lock (_identifierDirectory)
            {
                identifier = (AutomationIdentifier)_identifierDirectory[id];
            }
            if (identifier == null)
            {
                return null;
            }
            if (identifier._type != type)
            {
                return null;
            }
            return identifier;
        }

        internal static AutomationIdentifier Register(UiaCoreIds.AutomationIdType type, int id, string programmaticName)
        {
            if (id == 0)
            {
                return null;
            }
            lock (_identifierDirectory)
            {
                AutomationIdentifier identifier = (AutomationIdentifier)_identifierDirectory[id];
                if (identifier == null)
                {
                    switch (type)
                    {
                        case UiaCoreIds.AutomationIdType.Property:
                            identifier = new AutomationProperty(id, programmaticName);
                            break;

                        case UiaCoreIds.AutomationIdType.Pattern:
                            identifier = new AutomationPattern(id, programmaticName);
                            break;

                        case UiaCoreIds.AutomationIdType.Event:
                            identifier = new AutomationEvent(id, programmaticName);
                            break;

                        case UiaCoreIds.AutomationIdType.ControlType:
                            identifier = new ControlType(id, programmaticName);
                            break;

                        case UiaCoreIds.AutomationIdType.TextAttribute:
                            identifier = new AutomationTextAttribute(id, programmaticName);
                            break;

                        default:
                            throw new InvalidOperationException("Invalid type specified for AutomationIdentifier");
                    }
                    _identifierDirectory[id] = identifier;
                }
                return identifier;
            }
        }


        public int Id
        {
            get
            {
                return this._id;
            }
        }

        public string ProgrammaticName
        {
            get
            {
                return this._programmaticName;
            }
        }
    }

    public class AutomationEvent : AutomationIdentifier
    {

        internal AutomationEvent(int id, string programmaticName)
            : base(UiaCoreIds.AutomationIdType.Event, id, programmaticName)
        {
        }

        public static AutomationEvent LookupById(int id)
        {
            return (AutomationEvent)AutomationIdentifier.LookupById(UiaCoreIds.AutomationIdType.Event, id);
        }

        internal static AutomationEvent Register(int id, string programmaticName)
        {
            return (AutomationEvent)AutomationIdentifier.Register(UiaCoreIds.AutomationIdType.Event, id, programmaticName);
        }
    }

    public class AutomationPattern : AutomationIdentifier
    {

        internal AutomationPattern(int id, string programmaticName)
            : base(UiaCoreIds.AutomationIdType.Pattern, id, programmaticName)
        {
        }

        public static AutomationPattern LookupById(int id)
        {
            return (AutomationPattern)AutomationIdentifier.LookupById(UiaCoreIds.AutomationIdType.Pattern, id);
        }

        internal static AutomationPattern Register(int id, string programmaticName)
        {
            return (AutomationPattern)AutomationIdentifier.Register(UiaCoreIds.AutomationIdType.Pattern, id, programmaticName);
        }
    }


    public class AutomationProperty : AutomationIdentifier
    {

        internal AutomationProperty(int id, string programmaticName)
            : base(UiaCoreIds.AutomationIdType.Property, id, programmaticName)
        {
        }

        public static AutomationProperty LookupById(int id)
        {
            return (AutomationProperty)AutomationIdentifier.LookupById(UiaCoreIds.AutomationIdType.Property, id);
        }

        internal static AutomationProperty Register(int id, string programmaticName)
        {
            return (AutomationProperty)AutomationIdentifier.Register(UiaCoreIds.AutomationIdType.Property, id, programmaticName);
        }
    }

    public class AutomationTextAttribute : AutomationIdentifier
    {

        internal AutomationTextAttribute(int id, string programmaticName)
            : base(UiaCoreIds.AutomationIdType.TextAttribute, id, programmaticName)
        {
        }

        public static AutomationTextAttribute LookupById(int id)
        {
            return (AutomationTextAttribute)AutomationIdentifier.LookupById(UiaCoreIds.AutomationIdType.TextAttribute, id);
        }

        internal static AutomationTextAttribute Register(int id, string programmaticName)
        {
            return (AutomationTextAttribute)AutomationIdentifier.Register(UiaCoreIds.AutomationIdType.TextAttribute, id, programmaticName);
        }
    }

    public class ControlType : AutomationIdentifier
    {
        /// <summary>
        /// Ensures the types are not marked with the beforefieldinit flag (causing lazy initialization).
        /// This ensures the registration (mapping) of the control GUIDs to the Uia_ControlIds is  
        /// guaranteed to exist during first access of the '_identifierDirectory' via ControlType.LookupById()
        /// Note on the static constructor performance: The performance points measured typically depend on 
        /// the initialization that goes with the type initialization. So if that's within permissible limits, 
        /// in this case the Register() calls for the controltypes which aren't expensive, having static
        /// constructor isn't that bad. Follow link for more details.
        /// http://coderjournal.com/2009/08/static-constructors-in-net-3-5-still-a-bad-thing/
        /// </summary>
        static ControlType() { }

        private AutomationPattern[] _neverSupportedPatterns;
        private AutomationPattern[][] _requiredPatternsSets;
        private AutomationProperty[] _requiredProperties;
        public static readonly ControlType Button = Register(UIA_ControlTypeIds.UIA_ButtonControlTypeId, "ControlType.Button", new AutomationPattern[][] { new AutomationPattern[] { InvokePatternIdentifiers.Pattern } });
        public static readonly ControlType Calendar = Register(UIA_ControlTypeIds.UIA_CalendarControlTypeId, "ControlType.Calendar", new AutomationPattern[][] { new AutomationPattern[] { GridPatternIdentifiers.Pattern, ValuePatternIdentifiers.Pattern, SelectionPatternIdentifiers.Pattern } });
        public static readonly ControlType CheckBox = Register(UIA_ControlTypeIds.UIA_CheckBoxControlTypeId, "ControlType.CheckBox", new AutomationPattern[][] { new AutomationPattern[] { TogglePatternIdentifiers.Pattern } });
        public static readonly ControlType ComboBox = Register(UIA_ControlTypeIds.UIA_ComboBoxControlTypeId, "ControlType.ComboBox", new AutomationPattern[][] { new AutomationPattern[] { SelectionPatternIdentifiers.Pattern, ExpandCollapsePatternIdentifiers.Pattern } });
        public static readonly ControlType Custom = Register(UIA_ControlTypeIds.UIA_CustomControlTypeId, "ControlType.Custom");
        public static readonly ControlType DataGrid = Register(UIA_ControlTypeIds.UIA_DataGridControlTypeId, "ControlType.DataGrid", new AutomationPattern[][] { new AutomationPattern[] { GridPatternIdentifiers.Pattern }, new AutomationPattern[] { SelectionPatternIdentifiers.Pattern }, new AutomationPattern[] { TablePatternIdentifiers.Pattern } });
        public static readonly ControlType DataItem = Register(UIA_ControlTypeIds.UIA_DataItemControlTypeId, "ControlType.DataItem", new AutomationPattern[][] { new AutomationPattern[] { SelectionItemPatternIdentifiers.Pattern } });
        public static readonly ControlType Document = Register(UIA_ControlTypeIds.UIA_DocumentControlTypeId, "ControlType.Document", new AutomationProperty[0], new AutomationPattern[] { ValuePatternIdentifiers.Pattern }, new AutomationPattern[][] { new AutomationPattern[] { ScrollPatternIdentifiers.Pattern }, new AutomationPattern[] { TextPatternIdentifiers.Pattern } });
        public static readonly ControlType Edit = Register(UIA_ControlTypeIds.UIA_EditControlTypeId, "ControlType.Edit", new AutomationPattern[][] { new AutomationPattern[] { ValuePatternIdentifiers.Pattern } });
        public static readonly ControlType Group = Register(UIA_ControlTypeIds.UIA_GroupControlTypeId, "ControlType.Group");
        public static readonly ControlType Header = Register(UIA_ControlTypeIds.UIA_HeaderControlTypeId, "ControlType.Header");
        public static readonly ControlType HeaderItem = Register(UIA_ControlTypeIds.UIA_HeaderItemControlTypeId, "ControlType.HeaderItem");
        public static readonly ControlType Hyperlink = Register(UIA_ControlTypeIds.UIA_HyperlinkControlTypeId, "ControlType.Hyperlink", new AutomationPattern[][] { new AutomationPattern[] { InvokePatternIdentifiers.Pattern } });
        public static readonly ControlType Image = Register(UIA_ControlTypeIds.UIA_ImageControlTypeId, "ControlType.Image");
        public static readonly ControlType List = Register(UIA_ControlTypeIds.UIA_ListControlTypeId, "ControlType.List", new AutomationPattern[][] { new AutomationPattern[] { SelectionPatternIdentifiers.Pattern, TablePatternIdentifiers.Pattern, GridPatternIdentifiers.Pattern, MultipleViewPatternIdentifiers.Pattern } });
        public static readonly ControlType ListItem = Register(UIA_ControlTypeIds.UIA_ListItemControlTypeId, "ControlType.ListItem", new AutomationPattern[][] { new AutomationPattern[] { SelectionItemPatternIdentifiers.Pattern } });
        public static readonly ControlType Menu = Register(UIA_ControlTypeIds.UIA_MenuControlTypeId, "ControlType.Menu");
        public static readonly ControlType MenuBar = Register(UIA_ControlTypeIds.UIA_MenuBarControlTypeId, "ControlType.MenuBar");
        public static readonly ControlType MenuItem = Register(UIA_ControlTypeIds.UIA_MenuItemControlTypeId, "ControlType.MenuItem", new AutomationPattern[][] { new AutomationPattern[] { InvokePatternIdentifiers.Pattern }, new AutomationPattern[] { ExpandCollapsePatternIdentifiers.Pattern }, new AutomationPattern[] { TogglePatternIdentifiers.Pattern } });
        public static readonly ControlType Pane = Register(UIA_ControlTypeIds.UIA_PaneControlTypeId, "ControlType.Pane", new AutomationPattern[][] { new AutomationPattern[] { TransformPatternIdentifiers.Pattern } });
        public static readonly ControlType ProgressBar = Register(UIA_ControlTypeIds.UIA_ProgressBarControlTypeId, "ControlType.ProgressBar", new AutomationPattern[][] { new AutomationPattern[] { ValuePatternIdentifiers.Pattern } });
        public static readonly ControlType RadioButton = Register(UIA_ControlTypeIds.UIA_RadioButtonControlTypeId, "ControlType.RadioButton");
        public static readonly ControlType ScrollBar = Register(UIA_ControlTypeIds.UIA_ScrollBarControlTypeId, "ControlType.ScrollBar");
        public static readonly ControlType Separator = Register(UIA_ControlTypeIds.UIA_SeparatorControlTypeId, "ControlType.Separator");
        public static readonly ControlType Slider = Register(UIA_ControlTypeIds.UIA_SliderControlTypeId, "ControlType.Slider", new AutomationPattern[][] { new AutomationPattern[] { RangeValuePatternIdentifiers.Pattern }, new AutomationPattern[] { SelectionPatternIdentifiers.Pattern } });
        public static readonly ControlType Spinner = Register(UIA_ControlTypeIds.UIA_SpinnerControlTypeId, "ControlType.Spinner", new AutomationPattern[][] { new AutomationPattern[] { RangeValuePatternIdentifiers.Pattern }, new AutomationPattern[] { SelectionPatternIdentifiers.Pattern } });
        public static readonly ControlType SplitButton = Register(UIA_ControlTypeIds.UIA_SplitButtonControlTypeId, "ControlType.SplitButton", new AutomationPattern[][] { new AutomationPattern[] { InvokePatternIdentifiers.Pattern }, new AutomationPattern[] { ExpandCollapsePatternIdentifiers.Pattern } });
        public static readonly ControlType StatusBar = Register(UIA_ControlTypeIds.UIA_StatusBarControlTypeId, "ControlType.StatusBar");
        public static readonly ControlType Tab = Register(UIA_ControlTypeIds.UIA_TabControlTypeId, "ControlType.Tab");
        public static readonly ControlType TabItem = Register(UIA_ControlTypeIds.UIA_TabItemControlTypeId, "ControlType.TabItem");
        public static readonly ControlType Table = Register(UIA_ControlTypeIds.UIA_TableControlTypeId, "ControlType.Table", new AutomationPattern[][] { new AutomationPattern[] { GridPatternIdentifiers.Pattern }, new AutomationPattern[] { SelectionPatternIdentifiers.Pattern }, new AutomationPattern[] { TablePatternIdentifiers.Pattern } });
        public static readonly ControlType Text = Register(UIA_ControlTypeIds.UIA_TextControlTypeId, "ControlType.Text");
        public static readonly ControlType Thumb = Register(UIA_ControlTypeIds.UIA_ThumbControlTypeId, "ControlType.Thumb");
        public static readonly ControlType TitleBar = Register(UIA_ControlTypeIds.UIA_TitleBarControlTypeId, "ControlType.TitleBar");
        public static readonly ControlType ToolBar = Register(UIA_ControlTypeIds.UIA_ToolBarControlTypeId, "ControlType.ToolBar");
        public static readonly ControlType ToolTip = Register(UIA_ControlTypeIds.UIA_ToolTipControlTypeId, "ControlType.ToolTip");
        public static readonly ControlType Tree = Register(UIA_ControlTypeIds.UIA_TreeControlTypeId, "ControlType.Tree");
        public static readonly ControlType TreeItem = Register(UIA_ControlTypeIds.UIA_TreeItemControlTypeId, "ControlType.TreeItem");
        public static readonly ControlType Window = Register(UIA_ControlTypeIds.UIA_WindowControlTypeId, "ControlType.Window", new AutomationPattern[][] { new AutomationPattern[] { TransformPatternIdentifiers.Pattern }, new AutomationPattern[] { WindowPatternIdentifiers.Pattern } });

        public static readonly ControlType SemanticZoom = Register(UIA_ControlTypeIds.UIA_SemanticZoomControlTypeId, "ControlType.SemanticZoom", new AutomationPattern[][] { new AutomationPattern[] { TogglePatternIdentifiers.Pattern } });
        public static readonly ControlType AppBar = Register(UIA_ControlTypeIds.UIA_AppBarControlTypeId, "ControlType.AppBarControl");



        internal ControlType(int id, string programmaticName)
            : base(UiaCoreIds.AutomationIdType.ControlType, id, programmaticName)
        {
        }

        public AutomationPattern[] GetNeverSupportedPatterns()
        {
            return (AutomationPattern[])this._neverSupportedPatterns.Clone();
        }

        public AutomationPattern[][] GetRequiredPatternSets()
        {
            int length = this._requiredPatternsSets.Length;
            AutomationPattern[][] patternArray = new AutomationPattern[length][];
            for (int i = 0; i < length; i++)
            {
                patternArray[i] = (AutomationPattern[])this._requiredPatternsSets[i].Clone();
            }
            return patternArray;
        }

        public AutomationProperty[] GetRequiredProperties()
        {
            return (AutomationProperty[])this._requiredProperties.Clone();
        }

        public static ControlType LookupById(int id)
        {
            return (ControlType)AutomationIdentifier.LookupById(UiaCoreIds.AutomationIdType.ControlType, id);
        }

        internal static ControlType Register(int id, string programmaticName)
        {
            return (ControlType)AutomationIdentifier.Register(UiaCoreIds.AutomationIdType.ControlType, id, programmaticName);
        }

        internal static ControlType Register(int id, string programmaticName, AutomationProperty[] requiredProperties)
        {
            return Register(id, programmaticName, requiredProperties, new AutomationPattern[0], new AutomationPattern[0][]);
        }

        internal static ControlType Register(int id, string programmaticName, AutomationPattern[][] requiredPatternsSets)
        {
            return Register(id, programmaticName, new AutomationProperty[0], new AutomationPattern[0], requiredPatternsSets);
        }

        internal static ControlType Register(int id, string programmaticName, AutomationProperty[] requiredProperties, AutomationPattern[] neverSupportedPatterns, AutomationPattern[][] requiredPatternsSets)
        {
            ControlType type = (ControlType)AutomationIdentifier.Register(UiaCoreIds.AutomationIdType.ControlType, id, programmaticName);
            type._requiredPatternsSets = requiredPatternsSets;
            type._neverSupportedPatterns = neverSupportedPatterns;
            type._requiredProperties = requiredProperties;
            return type;
        }


        public string LocalizedControlType
        {
            get
            {
                throw new NotImplementedException("UI Automation COM API does not have a matching method");
            }
        }
    }

    #endregion

    #region Exceptions

    [Serializable]
    public class ElementNotAvailableException : SystemException
    {
        public ElementNotAvailableException()
            : base("Element not available")
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTAVAILABLE;
        }

        public ElementNotAvailableException(Exception innerException)
            : base("Element not available", innerException)
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTAVAILABLE;
        }

        public ElementNotAvailableException(string message)
            : base(message)
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTAVAILABLE;
        }

        protected ElementNotAvailableException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTAVAILABLE;
        }

        public ElementNotAvailableException(string message, Exception innerException)
            : base(message, innerException)
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTAVAILABLE;
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }


    [Serializable]
    public class ElementNotEnabledException : InvalidOperationException
    {
        public ElementNotEnabledException()
            : base("Element not enabled")
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTENABLED;
        }

        public ElementNotEnabledException(Exception innerException)
            : base("Element not enabled", innerException)
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTENABLED;
        }

        public ElementNotEnabledException(string message)
            : base(message)
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTENABLED;
        }

        protected ElementNotEnabledException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTENABLED;
        }

        public ElementNotEnabledException(string message, Exception innerException)
            : base(message, innerException)
        {
            base.HResult = UiaCoreIds.UIA_E_ELEMENTNOTENABLED;
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }

    [Serializable]
    public class NoClickablePointException : Exception
    {

        public NoClickablePointException()
        {
        }

        public NoClickablePointException(Exception innerException) :
            base(String.Empty, innerException)
        {
        }

        public NoClickablePointException(string message)
            : base(message)
        {
        }

        protected NoClickablePointException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public NoClickablePointException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }

    [Serializable]
    public class ProxyAssemblyNotLoadedException : Exception
    {

        public ProxyAssemblyNotLoadedException()
        {
        }

        public ProxyAssemblyNotLoadedException(Exception innerException) :
            base(String.Empty, innerException)
        {
        }

        public ProxyAssemblyNotLoadedException(string message)
            : base(message)
        {
        }

        protected ProxyAssemblyNotLoadedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ProxyAssemblyNotLoadedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }

    #endregion

    #region Enums

    [Guid("70d46e77-e3a8-449d-913c-e30eb2afecdb"), ComVisible(true)]
    public enum DockPosition
    {
        Top,
        Left,
        Bottom,
        Right,
        Fill,
        None
    }

    [Guid("76d12d7e-b227-4417-9ce2-42642ffa896a"), ComVisible(true)]
    public enum ExpandCollapseState
    {
        Collapsed,
        Expanded,
        PartiallyExpanded,
        LeafNode
    }

    [Guid("5F8A77B4-E685-48c1-94D0-8BB6AFA43DF9"), ComVisible(true)]
    public enum OrientationType
    {
        None,
        Horizontal,
        Vertical
    }

    [ComVisible(true), Guid("15fdf2e2-9847-41cd-95dd-510612a025ea")]
    public enum RowOrColumnMajor
    {
        RowMajor,
        ColumnMajor,
        Indeterminate
    }

    [ComVisible(true), Guid("bd52d3c7-f990-4c52-9ae3-5c377e9eb772")]
    public enum ScrollAmount
    {
        LargeDecrement,
        SmallDecrement,
        NoAmount,
        LargeIncrement,
        SmallIncrement
    }

    [Flags, ComVisible(true), Guid("3d9e3d8f-bfb0-484f-84ab-93ff4280cbc4")]
    public enum SupportedTextSelection
    {
        None,
        Single,
        Multiple
    }

    [Guid("ad7db4af-7166-4478-a402-ad5b77eab2fa"), ComVisible(true)]
    public enum ToggleState
    {
        Off,
        On,
        Indeterminate
    }

    [Flags]
    public enum TreeScope
    {
        Element = 1,
        Children = 2,
        Descendants = 4,
        Subtree = 7,
        Parent = 8,
        Ancestors = 16,
    }

    [Guid("65101cc7-7904-408e-87a7-8c6dbd83a18b"), ComVisible(true)]
    public enum WindowInteractionState
    {
        Running,
        Closing,
        ReadyForUserInteraction,
        BlockedByModalWindow,
        NotResponding
    }

    [ComVisible(true), Guid("fdc8f176-aed2-477a-8c89-ea04cc5f278d")]
    public enum WindowVisualState
    {
        Normal,
        Maximized,
        Minimized
    }

    // New for Windows 7
    //

    [Flags]
    public enum SynchronizedInputType
    {
        KeyUp = 0x01,
        KeyDown = 0x02,
        LeftMouseUp = 0x04,
        LeftMouseDown = 0x08,
        RightMouseUp = 0x10,
        RightMouseDown = 0x20
    };

    // New for Windows 8
    //

    public enum AnnotationType
    {
        Unknown = 0xEA60,
        SpellingError,
        GrammarError,
        Comment,
        FormulaError,
        TrackChanges,
        Header,
        Footer,
        Highlighted
    };

    public enum StyleId
    {
        Custom = 0x11170,
        Heading1,
        Heading2,
        Heading3,
        Heading4,
        Heading5,
        Heading6,
        Heading7,
        Heading8,
        Heading9,
        Title,
        Subtitle,
        Normal,
        Emphasis,
        Quote
    }

    public enum ZoomUnit
    {
        NoAmount = 0,
        LargeDecrement,
        SmallDecrement,
        LargeIncrement,
        SmallIncrement
    }

    public enum LiveSetting
    {
        Off = 0,
        Polite = 1,
        Assertive = 2
    };

    public enum ActiveEnd
    {
        None = 0,
        Start = 1,
        End = 2
    };

    public enum CaretPosition
    {
        Unknown = 0,
        EndOfLine = 1,
        BeginningOfLine = 2
    };

    public enum CaretBidiMode
    {
        LTR = 0,
        RTL = 1
    };

    //New for windows 8.1

    public enum TextEditChangeType
    {
        None = 0,
        AutoCorrect = 1,
        Composition = 2,
        CompositionFinalized = 3
    };



    #endregion

}