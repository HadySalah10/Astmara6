﻿#pragma checksum "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A028437B0968ED71E4D33523CF212CF9266C693F8382DBD5028D063A8F13A0F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Astmara6;
using Astmara6Con.Controls;
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


namespace Astmara6Con.Controls {
    
    
    /// <summary>
    /// UCDepartment
    /// </summary>
    public partial class UCDepartment : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNameDepartment;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNBack;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNNext;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNAdd;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGDepartmentView;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNEdit;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNRemove;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNRemoveAll;
        
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
            System.Uri resourceLocater = new System.Uri("/Astmara6;component/controls/fixed%20data/child/ucdepartment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
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
            this.TBNameDepartment = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
            this.TBNameDepartment.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTNBack = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
            this.BTNBack.Click += new System.Windows.RoutedEventHandler(this.BTNBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTNNext = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
            this.BTNNext.Click += new System.Windows.RoutedEventHandler(this.BTNNext_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTNAdd = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
            this.BTNAdd.Click += new System.Windows.RoutedEventHandler(this.BTNAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DGDepartmentView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.BTNEdit = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
            this.BTNEdit.Click += new System.Windows.RoutedEventHandler(this.BTNEdit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTNRemove = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
            this.BTNRemove.Click += new System.Windows.RoutedEventHandler(this.BTNRemove_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BTNRemoveAll = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\Controls\Fixed Data\Child\UCDepartment.xaml"
            this.BTNRemoveAll.Click += new System.Windows.RoutedEventHandler(this.BTNRemoveAll_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

