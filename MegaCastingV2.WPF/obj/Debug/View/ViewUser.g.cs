﻿#pragma checksum "..\..\..\View\ViewUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F456E0780D58F5D1F47FA88817A7C9116AAF4F746BCC575918EA6693CAC1C258"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MegaCastingV2.WPF.View;
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


namespace MegaCastingV2.WPF.View {
    
    
    /// <summary>
    /// ViewUser
    /// </summary>
    public partial class ViewUser : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\View\ViewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox _ListBoxUserTypes;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\ViewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _ButtonRemoveUser;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\View\ViewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _SelectUserLastname;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\View\ViewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _SelectUserFirstname;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\View\ViewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _SelectUserUsername;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\View\ViewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _SelectUserEmail;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\View\ViewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _ButtonSaveUser;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCastingV2.WPF;component/view/viewuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ViewUser.xaml"
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
            this._ListBoxUserTypes = ((System.Windows.Controls.ListBox)(target));
            
            #line 30 "..\..\..\View\ViewUser.xaml"
            this._ListBoxUserTypes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this._ListBoxUserTypes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this._ButtonRemoveUser = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\View\ViewUser.xaml"
            this._ButtonRemoveUser.Click += new System.Windows.RoutedEventHandler(this._ButtonRemoveUser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this._SelectUserLastname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this._SelectUserFirstname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this._SelectUserUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this._SelectUserEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this._ButtonSaveUser = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\View\ViewUser.xaml"
            this._ButtonSaveUser.Click += new System.Windows.RoutedEventHandler(this._ButtonSaveUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

