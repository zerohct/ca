﻿#pragma checksum "..\..\..\..\..\View\Form\EMainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EC13B1AC12EF76DD9024EA5CC45E6C2F53300821"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DoAnLTWin_QuanLyPhongKhamNhaKhoa.Form;
using DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace DoAnLTWin_QuanLyPhongKhamNhaKhoa.Form {
    
    
    /// <summary>
    /// EMainWindow
    /// </summary>
    public partial class EMainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\..\View\Form\EMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock chucVutext;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\View\Form\EMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander PatientExpander;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\..\View\Form\EMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHoaDon;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\..\View\Form\EMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_logout;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\..\View\Form\EMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\..\View\Form\EMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_search;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\..\..\View\Form\EMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl contentControl;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DoAnLTWin-QuanLyPhongKhamNhaKhoa;V1.0.0.0;component/view/form/emainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Form\EMainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 17 "..\..\..\..\..\View\Form\EMainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chucVutext = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.PatientExpander = ((System.Windows.Controls.Expander)(target));
            return;
            case 4:
            
            #line 57 "..\..\..\..\..\View\Form\EMainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PatientButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnHoaDon = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\..\..\View\Form\EMainWindow.xaml"
            this.btnHoaDon.Click += new System.Windows.RoutedEventHandler(this.btnHoaDon_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_logout = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\..\..\View\Form\EMainWindow.xaml"
            this.btn_logout.Click += new System.Windows.RoutedEventHandler(this.btn_logout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btn_search = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            
            #line 196 "..\..\..\..\..\View\Form\EMainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AboutUs_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 197 "..\..\..\..\..\View\Form\EMainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Helpme_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.contentControl = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

