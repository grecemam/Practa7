﻿#pragma checksum "..\..\CardAppointmentsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00D56CB033481354E8D99EEED6B00C98C0AC525539553078C534C44032C9E466"
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
    /// CardAppointmentsPage
    /// </summary>
    public partial class CardAppointmentsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\CardAppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AppointmentsListView;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CardAppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameAppoinment;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\CardAppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DoctorTxb;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\CardAppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AppointmentDateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\CardAppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AppointmentTimeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\CardAppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DiagnosisTextBlock;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\CardAppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RecipesTxb;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\CardAppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PrescriptionsListView;
        
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
            System.Uri resourceLocater = new System.Uri("/DentalClinic;component/cardappointmentspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CardAppointmentsPage.xaml"
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
            this.AppointmentsListView = ((System.Windows.Controls.ListView)(target));
            
            #line 21 "..\..\CardAppointmentsPage.xaml"
            this.AppointmentsListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AppointmentsListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameAppoinment = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.DoctorTxb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.AppointmentDateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.AppointmentTimeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DiagnosisTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.RecipesTxb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.PrescriptionsListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

