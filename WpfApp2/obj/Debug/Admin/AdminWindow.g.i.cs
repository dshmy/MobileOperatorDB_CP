﻿#pragma checksum "..\..\..\Admin\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17223101ADE3FC827E52022CA7D8A255BEF1C68502018CDDFED2E9AD74E63420"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp2;


namespace WpfApp2.Admin {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Employees;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid employees;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addEmployee;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Numbers;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tarsDG;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTariffPlan;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/admin/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin\AdminWindow.xaml"
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
            
            #line 8 "..\..\..\Admin\AdminWindow.xaml"
            ((WpfApp2.Admin.AdminWindow)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Employees = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.employees = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.addEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Admin\AdminWindow.xaml"
            this.addEmployee.Click += new System.Windows.RoutedEventHandler(this.addEmployee_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Numbers = ((System.Windows.Controls.TabItem)(target));
            return;
            case 6:
            this.tarsDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.addTariffPlan = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\Admin\AdminWindow.xaml"
            this.addTariffPlan.Click += new System.Windows.RoutedEventHandler(this.addTariffPlan_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\Admin\AdminWindow.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

