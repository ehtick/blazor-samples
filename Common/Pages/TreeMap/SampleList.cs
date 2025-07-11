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
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> TreeMap { get; set; } = new List<Sample>{
           new Sample {
                Name = "Default Functionalities",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor TreeMap Component | Hierarchical Data Visualization | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Default Functionalities",
                MetaDescription = "This Blazor TreeMap example demonstrates the basic functionalities of TreeMap component. Visualize hierarchical data with nested rectangles sized proportionally to data values.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Layout",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/layout",
                FileName = "Layout.razor",
                MetaTitle = "Blazor TreeMap Layout Types | Slice, Dice, and Algorithm | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Layout Types",
                MetaDescription = "This Blazor TreeMap example demonstrates different layout types including Slice, Dice, SliceAndDice and Squarified algorithms for optimal data representation based on your visualization needs.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Drilldown",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/drill-down",
                FileName = "Drilldown.razor",
                MetaTitle = "Blazor TreeMap Drill Down | Hierarchical Data Navigation | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Drill Down Functionality",
                MetaDescription = "This Blazor TreeMap example demonstrates drill-down functionality that allows users to navigate through hierarchical data levels. Click on tiles to explore deeper levels of your data structure.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Color Mapping",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/color-mapping",
                FileName = "ColorMapping.razor",
                MetaTitle = "Blazor TreeMap Color Mapping | Data Visualization | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Color Mapping",
                MetaDescription = "This Blazor TreeMap example demonstrates various color mapping techniques including range, equal, and desaturation color mapping to enhance data visualization with meaningful color representation.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Selection & Highlight",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/selection-highlight",
                FileName = "Selection.razor",
                MetaTitle = "Blazor TreeMap Selection & Highlight | Interactive Features | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Selection and Highlighting",
                MetaDescription = "This Blazor TreeMap example demonstrates selection and highlighting capabilities that allow users to interact with TreeMap items. Enhance user experience with visual feedback on hover and selection.",
                Type = SampleType.None
            },
             new Sample {
                Name = "Label",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/label",
                FileName = "TreeMapLabel.razor",
                MetaTitle = "Blazor TreeMap Labels | Text Formatting and Positioning | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Label Customization",
                MetaDescription = "This Blazor TreeMap example shows how to customize labels with various formatting options including position, alignment, overflow handling, and styling to improve data readability.",
                Type = SampleType.None
            },
             new Sample {
                Name = "Legend",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/legend",
                FileName = "Legend.razor",
                MetaTitle = "Blazor TreeMap Legend | Data Interpretation Guide | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Legend Configuration",
                MetaDescription = "This Blazor TreeMap example demonstrates legend configuration options including positioning, orientation, and customization. Add contextual information to help users interpret color-coded data.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Template",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor TreeMap Templating | Custom UI Elements | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Custom Templates",
                MetaDescription = "This Blazor TreeMap example demonstrates template customization capabilities that allow you to create rich, personalized visualizations with custom HTML content and styling for TreeMap items.",
                Type = SampleType.None
            },
              new Sample {
                Name = "Tooltip",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/tooltip",
                FileName = "Tooltip.razor",
                MetaTitle = "Blazor TreeMap Tooltip | Interactive Data Details | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Tooltip Configuration",
                MetaDescription = "This Blazor TreeMap example demonstrates tooltip functionality that provides additional information when users hover over TreeMap tiles. Customize tooltip content and appearance for better insights.",
                Type = SampleType.None
            },
            new Sample {
                Name = "Print & Export",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/print",
                FileName = "Print.razor",
                MetaTitle = "Blazor TreeMap Print & Export | Image & PDF Generation | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Print and Export Functionality",
                MetaDescription = "This Blazor TreeMap example demonstrates print and export capabilities allowing users to generate PNG, JPEG, SVG, and PDF files from the TreeMap visualization for reports and presentations.",
                Type = SampleType.None
            },
                new Sample
            {
                Name = "RTL",
                Category = "TreeMap",
                Directory = "TreeMap/TreeMap",
                Url = "treemap/rtl",
                FileName = "Rtl.razor",
                MetaTitle = "Blazor TreeMap RTL Support | Right-to-Left Layout | Syncfusion",
                HeaderText = "Blazor TreeMap Example - Right-to-Left (RTL) Mode",
                MetaDescription = "This Blazor TreeMap example demonstrates Right-to-Left (RTL) support for languages like Arabic and Hebrew. The TreeMap layout and elements are aligned from right to left for proper localization.",
                Type = SampleType.None
            }
        };
    }
}
