﻿#pragma checksum "..\..\..\..\..\UI\Registros\rPrestamo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64B2F71A722C6F8C37DA0542BDBA3B39D399E61C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Prestamos;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Prestamos.UI.Registros {
    
    
    /// <summary>
    /// rPrestamo
    /// </summary>
    public partial class rPrestamo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrestamoIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuscarButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Fecha_DatePicker;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PersonaIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConceptoTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MontoTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BalanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/prestamos;V1.0.0.0;component/ui/registros/rprestamo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PrestamoIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BuscarButton = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            this.BuscarButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Fecha_DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.PersonaIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ConceptoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MontoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BalanceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.NewButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            this.NewButton.Click += new System.Windows.RoutedEventHandler(this.NewButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\UI\Registros\rPrestamo.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

