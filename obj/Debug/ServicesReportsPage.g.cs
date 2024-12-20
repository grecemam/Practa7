﻿#pragma checksum "..\..\ServicesReportsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "859B419938676E67FE2E01A69DDA6DC5C281B211C216CABA9E6BC84B16265BF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DentalClinic;
using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace DentalClinic {
    
    
    /// <summary>
    /// ServicesReportsPage
    /// </summary>
    public partial class ServicesReportsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\ServicesReportsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ServicesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ServicesReportsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ChartView;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ServicesReportsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart ServicesChart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DentalClinic;component/servicesreportspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ServicesReportsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 23 "..\..\ServicesReportsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewListButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 26 "..\..\ServicesReportsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowChartButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 29 "..\..\ServicesReportsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExportToPdfButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ServicesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.ChartView = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.ServicesChart = ((LiveCharts.Wpf.PieChart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

