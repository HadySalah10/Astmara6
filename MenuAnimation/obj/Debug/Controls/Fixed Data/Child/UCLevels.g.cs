﻿#pragma checksum "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1BEA44C58F78801E60A9D49218FBC320E6C698A642594564E9A6B1D960E4C444"
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
using Astmara6Con;
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


namespace Astmara6Con {
    
    
    /// <summary>
    /// UCLevels
    /// </summary>
    public partial class UCLevels : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNameLevels;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNNext;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNAdd;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNBack;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGLevelsView;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNRemove;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNEdit;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Astmara6;component/controls/fixed%20data/child/uclevels.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
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
            this.TBNameLevels = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
            this.TBNameLevels.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
            this.TBNameLevels.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBNameLevels_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTNNext = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
            this.BTNNext.Click += new System.Windows.RoutedEventHandler(this.BTNNext_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTNAdd = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
            this.BTNAdd.Click += new System.Windows.RoutedEventHandler(this.BTNAdd_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTNBack = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
            this.BTNBack.Click += new System.Windows.RoutedEventHandler(this.BTNBack_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DGLevelsView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.BTNRemove = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
            this.BTNRemove.Click += new System.Windows.RoutedEventHandler(this.BTNRemove_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTNEdit = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
            this.BTNEdit.Click += new System.Windows.RoutedEventHandler(this.BTNEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BTNRemoveAll = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\Controls\Fixed Data\Child\UCLevels.xaml"
            this.BTNRemoveAll.Click += new System.Windows.RoutedEventHandler(this.BTNRemoveAll_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

