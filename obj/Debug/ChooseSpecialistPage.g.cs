﻿#pragma checksum "..\..\ChooseSpecialistPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "858DCCE19C8B3EAAB41BBE9848E3348CD4A9D1DAA1960E97176812718C334B20"
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
    /// ChooseSpecialistPage
    /// </summary>
    public partial class ChooseSpecialistPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\ChooseSpecialistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock specName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ChooseSpecialistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel specialistListPanel;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ChooseSpecialistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SpecName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ChooseSpecialistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid CurrentWeekGrid;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ChooseSpecialistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid NextWeekGrid;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ChooseSpecialistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel morningPanel;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ChooseSpecialistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel dayPanel;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ChooseSpecialistPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel eveningPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/DentalClinic;component/choosespecialistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChooseSpecialistPage.xaml"
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
            this.specName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.specialistListPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.SpecName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.CurrentWeekGrid = ((System.Windows.Controls.Primitives.UniformGrid)(target));
            return;
            case 5:
            this.NextWeekGrid = ((System.Windows.Controls.Primitives.UniformGrid)(target));
            return;
            case 6:
            this.morningPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 7:
            this.dayPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 8:
            this.eveningPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 9:
            
            #line 61 "..\..\ChooseSpecialistPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 62 "..\..\ChooseSpecialistPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ScheduleAppointmentButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

