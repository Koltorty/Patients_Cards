﻿#pragma checksum "..\..\..\Windows\VisitsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7182D7A1EBC0EE6E0FBD5813F2ED7979C5AF52C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Patients;
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


namespace Patients {
    
    
    /// <summary>
    /// VisitsWindow
    /// </summary>
    public partial class VisitsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid visitsGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock visitDateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker visitDatePicker;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock diagnosisTextBlock;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox diagnosisTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock visitTypeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox visitTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock errorTextBlock;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\VisitsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Patients;component/windows/visitswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\VisitsWindow.xaml"
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
            this.visitsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.visitDateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.visitDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.diagnosisTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.diagnosisTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.visitTypeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.visitTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\VisitsWindow.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.errorTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Windows\VisitsWindow.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Windows\VisitsWindow.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

