﻿#pragma checksum "..\..\ScheduleEmployeesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "495F5C517298E3A5691215731AD7C2A758EC8D183D46DEF4461BF1E85229883C"
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
    /// ScheduleEmployeesPage
    /// </summary>
    public partial class ScheduleEmployeesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\ScheduleEmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\ScheduleEmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DayComboBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ScheduleEmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ShiftComboBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\ScheduleEmployeesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StatusTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/DentalClinic;component/scheduleemployeespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ScheduleEmployeesPage.xaml"
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
            this.EmployeesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\ScheduleEmployeesPage.xaml"
            this.EmployeesDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EmployeesDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DayComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ShiftComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 81 "..\..\ScheduleEmployeesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateScheduleButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StatusTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

