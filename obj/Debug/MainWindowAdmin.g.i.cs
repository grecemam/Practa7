﻿#pragma checksum "..\..\MainWindowAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D2F707B70737D48D240E911C1D926579FA4A679663841BA76537432B2496430"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DentalClinic;
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
    /// MainWindowAdmin
    /// </summary>
    public partial class MainWindowAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\MainWindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PatientReportsTb;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ServicesReportsTb;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ScheduleEmplTb;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ScheduleUsersTb;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EmployeeTb;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountMaterTb;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NamePatient;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/DentalClinic;component/mainwindowadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindowAdmin.xaml"
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
            this.PatientReportsTb = ((System.Windows.Controls.TextBlock)(target));
            
            #line 26 "..\..\MainWindowAdmin.xaml"
            this.PatientReportsTb.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.PatientReportsTb_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ServicesReportsTb = ((System.Windows.Controls.TextBlock)(target));
            
            #line 27 "..\..\MainWindowAdmin.xaml"
            this.ServicesReportsTb.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ServicesReportsTb_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ScheduleEmplTb = ((System.Windows.Controls.TextBlock)(target));
            
            #line 34 "..\..\MainWindowAdmin.xaml"
            this.ScheduleEmplTb.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ScheduleEmplTb_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ScheduleUsersTb = ((System.Windows.Controls.TextBlock)(target));
            
            #line 39 "..\..\MainWindowAdmin.xaml"
            this.ScheduleUsersTb.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ScheduleUsersTb_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EmployeeTb = ((System.Windows.Controls.TextBlock)(target));
            
            #line 44 "..\..\MainWindowAdmin.xaml"
            this.EmployeeTb.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.EmployeeTb_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CountMaterTb = ((System.Windows.Controls.TextBlock)(target));
            
            #line 49 "..\..\MainWindowAdmin.xaml"
            this.CountMaterTb.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CountMaterTb_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NamePatient = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

