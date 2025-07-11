#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_MAUI_Demos;
namespace Blazor_MAUI_Demos
{
    internal partial class SampleConfig
    {
        public List<Sample> PivotTable { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Pivot Table Example | Default Functionalities | Syncfusion Demos",
                HeaderText = "Blazor Pivot Table Example - Default Functionalities",
                MetaDescription = "This Blazor Pivot Table example demonstrates the default rendering of the Blazor Pivot Table component with a minimum configuration. Explore here for more details.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Live Data",
                Category = "Pivot Table",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/live-data",
                FileName = "LiveData.razor",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"Added a demo to show how the pivot table and pivot chart are frequently updated with live data at a given time period." }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/remote-data",
                FileName = "RemoteData.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pivot Chart",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/pivot-chart",
                FileName = "Chart.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "External Binding",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/external-binding",
                FileName = "ExternalBinding.razor",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"Added a demo to create and update a Heatmap component externally using data obtained from cell selection in the Pivot Table UI." }
            },
            new Sample
            {
                Name = "HeatMap",
                Category = "Integration",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/heatmap",
                FileName = "HeatMap.razor",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"Added a demo to show the pivot table value cells as heatmap cells based on their range." }
            },
            new Sample
            {
                Name = "Grouping Bar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/grouping-bar",
                FileName = "GroupingBar.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Conditional Formatting",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/conditional-formatting",
                FileName = "ConditionalFormatting.razor",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"The custom toolbar demo has been updated with a new UI option ""Apply to Grand Total"" added in the conditional formatting dialog UI, that allows the conditional formatting to be applied to row and column grand totals." }
            },
            new Sample
            {
                Name = "Selection",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/selection",
                FileName = "Selection.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drill Down",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-down",
                FileName = "DrillDown.razor",                
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Show/Hide Totals",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/show-hide-totals",
                FileName = "SummaryCustomization.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "User Interaction",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/toolbar",
                FileName = "Toolbar.razor",
                Type = SampleType.None,
            },            
            new Sample
            {
                Name = "Calculated Field",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/calculated-field",
                FileName = "CalculatedField.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Aggregation",
                Category = "Formula",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/aggregation",
                FileName = "Aggregation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-sorting",
                FileName = "DefaultSorting.razor"
            },
            new Sample
            {
                Name = "Value Sorting",
                Category = "Sorting",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-sorting",
                FileName = "ValueSorting.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Default Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/default-filtering",
                FileName = "MemberFiltering.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Label Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/label-filtering",
                FileName = "LabelFiltering.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Value Filtering",
                Category = "Filtering",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/value-filtering",
                FileName = "ValueFiltering.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/virtual-scrolling",
                FileName = "VirtualScrolling.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Paging",
                Category = "Paging",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/paging",
                FileName = "Paging.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Customization",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/cell-template",
                FileName = "PivotCellTemplate.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Drill Through",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/drill-through",
                FileName = "DrillThrough.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Editing",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/editing",
                FileName = "Editing.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Hyperlink",
                Category = "Miscellaneous",
                Directory = "PivotView/PivotTable",
                Url = "pivot-table/hyperlink",
                FileName = "HyperLink.razor",
                Type = SampleType.None
            },
        };
    }
}
