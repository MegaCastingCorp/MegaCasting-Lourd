﻿#pragma checksum "..\..\..\..\View\Popup\PopupAddUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64F65CCB2B0611D722D8ED4789A6FFDE332519FC0A85CC79E740FCAAE72A1F2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MegaCastingV2.WPF.View.Popup;
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


namespace MegaCastingV2.WPF.View.Popup {
    
    
    /// <summary>
    /// PopupAddUser
    /// </summary>
    public partial class PopupAddUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\View\Popup\PopupAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PopBoxLastname;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\Popup\PopupAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PopBoxFirstName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\Popup\PopupAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PopBoxUsername;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\Popup\PopupAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PopBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\Popup\PopupAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PopBoxEmail;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\Popup\PopupAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _PopComboBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\Popup\PopupAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _ButtonAddUser;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCastingV2.WPF;component/view/popup/popupadduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Popup\PopupAddUser.xaml"
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
            this.PopBoxLastname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PopBoxFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PopBoxUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PopBoxPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PopBoxEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this._PopComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this._ButtonAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\View\Popup\PopupAddUser.xaml"
            this._ButtonAddUser.Click += new System.Windows.RoutedEventHandler(this._ButtonAddUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

