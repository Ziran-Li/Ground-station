﻿#pragma checksum "..\..\..\Window\PilotLogWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "40D015CDDC3BFF22E519632DB2E8D712"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HelixToolkit.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace XMonitor_GUI {
    
    
    /// <summary>
    /// PilotLogWindow
    /// </summary>
    public partial class PilotLogWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Close;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PilotName;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MonitorName;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Place;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Weather;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Wind;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePicker1;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calender1;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MustCheck;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView DiscCheck;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\Window\PilotLogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK;
        
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
            System.Uri resourceLocater = new System.Uri("/X-Monitor;component/window/pilotlogwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window\PilotLogWindow.xaml"
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
            this.Close = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Window\PilotLogWindow.xaml"
            this.Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PilotName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MonitorName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Place = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Weather = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Wind = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.DatePicker1 = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.calender1 = ((System.Windows.Controls.Calendar)(target));
            return;
            case 9:
            this.MustCheck = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.DiscCheck = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.OK = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\..\Window\PilotLogWindow.xaml"
            this.OK.Click += new System.Windows.RoutedEventHandler(this.OK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
