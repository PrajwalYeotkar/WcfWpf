#pragma checksum "..\..\ViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0491335E8D727A667421CBEE0CB74BFD397B416A388464761EC8C6CE8BC9DC7"
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
    /// ViewPage
    /// </summary>
    public partial class ViewPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtid;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtemail;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtaddress;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtmbnum;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnview;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnprevious;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnnext;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFCrud;component/viewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewPage.xaml"
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
            this.txtid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtemail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtaddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtmbnum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnview = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\ViewPage.xaml"
            this.btnview.Click += new System.Windows.RoutedEventHandler(this.btnview_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnprevious = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ViewPage.xaml"
            this.btnprevious.Click += new System.Windows.RoutedEventHandler(this.btnprevious_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnnext = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ViewPage.xaml"
            this.btnnext.Click += new System.Windows.RoutedEventHandler(this.btnnext_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnViewDataGrid = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\ViewPage.xaml"
            this.btnViewDataGrid.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

