﻿#pragma checksum "..\..\..\MenuPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AD0AB55191510187303048F6BF477F0C4FED81EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SafariExplorerWPF;
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


namespace SafariExplorerWPF {
    
    
    /// <summary>
    /// MenuPage
    /// </summary>
    public partial class MenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame _menuFrame;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStartSafari;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStartQuiz;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnJournal;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlockWelcome;
        
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
            System.Uri resourceLocater = new System.Uri("/SafariExplorerWPF;V1.0.0.0;component/menupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenuPage.xaml"
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
            this._menuFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.BtnStartSafari = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\MenuPage.xaml"
            this.BtnStartSafari.Click += new System.Windows.RoutedEventHandler(this.BtnStartSafari_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnStartQuiz = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\MenuPage.xaml"
            this.BtnStartQuiz.Click += new System.Windows.RoutedEventHandler(this.BtnStartQuiz_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnJournal = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\MenuPage.xaml"
            this.BtnJournal.Click += new System.Windows.RoutedEventHandler(this.BtnClickOpenJournal);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtBlockWelcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

