#pragma checksum "..\..\PersonPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "321F0357BAE6A56180B6BB68A71B2695788D556FD222C790749DC894DC880668"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WPFCrud;


namespace WPFCrud {
    
    
    /// <summary>
    /// PersonPage
    /// </summary>
    public partial class PersonPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFCrud.PersonPage Crud;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtemail;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtaddress;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtmbnum;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnview;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btninsert;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnupdate;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PersonPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btndelete;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFCrud;component/personpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PersonPage.xaml"
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
            this.Crud = ((WPFCrud.PersonPage)(target));
            
            #line 8 "..\..\PersonPage.xaml"
            this.Crud.Loaded += new System.Windows.RoutedEventHandler(this.Crud_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtemail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtaddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtmbnum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnview = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\PersonPage.xaml"
            this.btnview.Click += new System.Windows.RoutedEventHandler(this.btnview_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btninsert = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\PersonPage.xaml"
            this.btninsert.Click += new System.Windows.RoutedEventHandler(this.btninsert_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnupdate = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\PersonPage.xaml"
            this.btnupdate.Click += new System.Windows.RoutedEventHandler(this.btnupdate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btndelete = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\PersonPage.xaml"
            this.btndelete.Click += new System.Windows.RoutedEventHandler(this.btndelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

