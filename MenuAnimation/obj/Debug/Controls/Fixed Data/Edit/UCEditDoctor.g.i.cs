﻿#pragma checksum "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21DEDFC2C02EEB0A3EC1EF006907E0CD95F661E33CD2850E26F6C8A42DB97B3C"
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
using Astmara6.Controls.Fixed_Data.Edit;
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


namespace Astmara6.Controls.Fixed_Data.Edit {
    
    
    /// <summary>
    /// UCEditDoctor
    /// </summary>
    public partial class UCEditDoctor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid _TeachersDataGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNEdit_Copy;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNRemove_Copy;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNRemoveAll_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Astmara6;component/controls/fixed%20data/edit/uceditdoctor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
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
            
            #line 9 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
            ((Astmara6.Controls.Fixed_Data.Edit.UCEditDoctor)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this._TeachersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BTNEdit_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
            this.BTNEdit_Copy.Click += new System.Windows.RoutedEventHandler(this.BTNEdit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTNRemove_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
            this.BTNRemove_Copy.Click += new System.Windows.RoutedEventHandler(this.BTNRemove_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTNRemoveAll_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
            this.BTNRemoveAll_Copy.Click += new System.Windows.RoutedEventHandler(this.BTNRemoveAll_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 29 "..\..\..\..\..\Controls\Fixed Data\Edit\UCEditDoctor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
