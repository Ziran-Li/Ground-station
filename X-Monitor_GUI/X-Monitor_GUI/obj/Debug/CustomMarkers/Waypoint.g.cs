﻿#pragma checksum "..\..\..\CustomMarkers\Waypoint.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "532B75AFDD8D1A757D496D9C2E7EABEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace XMonitor_GUI.CustomMarkers {
    
    
    /// <summary>
    /// Waypoint
    /// </summary>
    public partial class Waypoint : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\CustomMarkers\Waypoint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid FlickArea;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\CustomMarkers\Waypoint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanvas;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\CustomMarkers\Waypoint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image icon;
        
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
            System.Uri resourceLocater = new System.Uri("/X-Monitor;component/custommarkers/waypoint.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomMarkers\Waypoint.xaml"
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
            
            #line 8 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.UAVWayPoint_Unloaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UAVWayPoint_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MarkerControl_MouseEnter);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MarkerControl_MouseLeave);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.UAVWayPoint_MouseMove);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.UAVWayPoint_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UAVWayPoint_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).TouchEnter += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.MarkerControl_TouchEnter);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).TouchLeave += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.MarkerControl_TouchLeave);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.MarkerControl_TouchDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).TouchUp += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.MarkerControl_TouchUp);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\CustomMarkers\Waypoint.xaml"
            ((XMonitor_GUI.CustomMarkers.Waypoint)(target)).TouchMove += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.MarkerControl_TouchMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FlickArea = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.myCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.icon = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

