﻿#pragma checksum "..\..\Changelog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6EBD7CB8728DB0AFABBB6CAB11773715CA3059DE4E5B398AE4BE4A6A258A43B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using EraLauncher;
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


namespace EraLauncher {
    
    
    /// <summary>
    /// Changelog
    /// </summary>
    public partial class Changelog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\Changelog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBG;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Changelog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel UpperPanel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Changelog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Title;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Changelog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Changelog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimalize;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Changelog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Logs_Content;
        
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
            System.Uri resourceLocater = new System.Uri("/EraLauncher;component/changelog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Changelog.xaml"
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
            this.GridBG = ((System.Windows.Controls.Grid)(target));
            
            #line 9 "..\..\Changelog.xaml"
            this.GridBG.MouseMove += new System.Windows.Input.MouseEventHandler(this.GridBG_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UpperPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.Title = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Changelog.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.Close_Button_Event);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Minimalize = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Changelog.xaml"
            this.Minimalize.Click += new System.Windows.RoutedEventHandler(this.Minimalize_Button_Event);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Logs_Content = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

