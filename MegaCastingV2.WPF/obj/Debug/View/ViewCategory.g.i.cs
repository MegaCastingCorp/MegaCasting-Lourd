﻿#pragma checksum "..\..\..\View\ViewCategory.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "487E658A38FEE035C915E43869AFCB4305280A4D0D953C98AAE9C50A1BD459D3"
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
    /// ViewCategory
    /// </summary>
    public partial class ViewCategory : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle _RectangleListBoxUser;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox _ListBoxCategory;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxSearchCategory;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _ButtonSearchCategory;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _ButtonAddCategorie;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _ButtonRemoveCategorie;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle _RectangleListBoxUserInfo;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _SelectUserLastname;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\View\ViewCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _ButtonSaveCategory;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCastingV2.WPF;component/view/viewcategory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ViewCategory.xaml"
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
            this._RectangleListBoxUser = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 2:
            this._ListBoxCategory = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.BoxSearchCategory = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\View\ViewCategory.xaml"
            this.BoxSearchCategory.GotFocus += new System.Windows.RoutedEventHandler(this.RemoveTextBar);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\View\ViewCategory.xaml"
            this.BoxSearchCategory.LostFocus += new System.Windows.RoutedEventHandler(this.AddTextBar);
            
            #line default
            #line hidden
            return;
            case 4:
            this._ButtonSearchCategory = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\View\ViewCategory.xaml"
            this._ButtonSearchCategory.Click += new System.Windows.RoutedEventHandler(this._ButtonSearchCategory_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._ButtonAddCategorie = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\View\ViewCategory.xaml"
            this._ButtonAddCategorie.Click += new System.Windows.RoutedEventHandler(this._ButtonAddCategorie_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this._ButtonRemoveCategorie = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\View\ViewCategory.xaml"
            this._ButtonRemoveCategorie.Click += new System.Windows.RoutedEventHandler(this._ButtonRemoveCategorie_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this._RectangleListBoxUserInfo = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this._SelectUserLastname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this._ButtonSaveCategory = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\View\ViewCategory.xaml"
            this._ButtonSaveCategory.Click += new System.Windows.RoutedEventHandler(this._ButtonSaveCategory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

