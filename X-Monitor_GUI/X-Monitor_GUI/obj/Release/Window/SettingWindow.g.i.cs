﻿#pragma checksum "..\..\..\Window\SettingWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7F6F6A0A2752381EE2BCE246A78DB5F10AD0917"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace XMonitor_GUI {
    
    
    /// <summary>
    /// SettingWindow
    /// </summary>
    public partial class SettingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 197 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox M_Text_Set;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Maintain_Success_Btn;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OptionViwer;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LatText;
        
        #line default
        #line hidden
        
        
        #line 262 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LngText;
        
        #line default
        #line hidden
        
        
        #line 266 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressText;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddressRec;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddressDel;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AddressListView;
        
        #line default
        #line hidden
        
        
        #line 308 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton zhibao_style;
        
        #line default
        #line hidden
        
        
        #line 309 "..\..\..\Window\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton hangpai_style;
        
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
            System.Uri resourceLocater = new System.Uri("/X-Monitor;component/window/settingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window\SettingWindow.xaml"
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
            
            #line 4 "..\..\..\Window\SettingWindow.xaml"
            ((XMonitor_GUI.SettingWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 33 "..\..\..\Window\SettingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.M_Text_Set = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Maintain_Success_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 199 "..\..\..\Window\SettingWindow.xaml"
            this.Maintain_Success_Btn.Click += new System.Windows.RoutedEventHandler(this.Maintain_Success_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OptionViwer = ((System.Windows.Controls.ListView)(target));
            
            #line 222 "..\..\..\Window\SettingWindow.xaml"
            this.OptionViwer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ViwerSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LatText = ((System.Windows.Controls.TextBox)(target));
            
            #line 260 "..\..\..\Window\SettingWindow.xaml"
            this.LatText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 260 "..\..\..\Window\SettingWindow.xaml"
            this.LatText.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.Lat_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 260 "..\..\..\Window\SettingWindow.xaml"
            this.LatText.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.LatText_TouchDown);
            
            #line default
            #line hidden
            
            #line 260 "..\..\..\Window\SettingWindow.xaml"
            this.LatText.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBoxNumDot_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LngText = ((System.Windows.Controls.TextBox)(target));
            
            #line 262 "..\..\..\Window\SettingWindow.xaml"
            this.LngText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            
            #line 262 "..\..\..\Window\SettingWindow.xaml"
            this.LngText.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.Lng_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 262 "..\..\..\Window\SettingWindow.xaml"
            this.LngText.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.LngText_TouchDown);
            
            #line default
            #line hidden
            
            #line 262 "..\..\..\Window\SettingWindow.xaml"
            this.LngText.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBoxNumDot_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddressText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.AddressRec = ((System.Windows.Controls.Button)(target));
            
            #line 267 "..\..\..\Window\SettingWindow.xaml"
            this.AddressRec.Click += new System.Windows.RoutedEventHandler(this.AddressRec_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddressDel = ((System.Windows.Controls.Button)(target));
            
            #line 268 "..\..\..\Window\SettingWindow.xaml"
            this.AddressDel.Click += new System.Windows.RoutedEventHandler(this.AddressDel_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 269 "..\..\..\Window\SettingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Set);
            
            #line default
            #line hidden
            return;
            case 12:
            this.AddressListView = ((System.Windows.Controls.ListView)(target));
            
            #line 271 "..\..\..\Window\SettingWindow.xaml"
            this.AddressListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AddressListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.zhibao_style = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 14:
            this.hangpai_style = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 15:
            
            #line 394 "..\..\..\Window\SettingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Init);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 399 "..\..\..\Window\SettingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 400 "..\..\..\Window\SettingWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

