﻿#pragma checksum "..\..\..\Authorization\PageRegister.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C5F16C50B0AEA228688030EA09CE539B6ECD2257CE50D5B2DE5CD86A43BB60B"
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
using TestDemoExam4.Authorization;


namespace TestDemoExam4.Authorization {
    
    
    /// <summary>
    /// PageRegister
    /// </summary>
    public partial class PageRegister : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Authorization\PageRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLogin;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Authorization\PageRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEmail;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Authorization\PageRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPhone;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Authorization\PageRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbPassword;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Authorization\PageRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCost;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Authorization\PageRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDeteOfBirth;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Authorization\PageRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Authorization\PageRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/TestDemoExam4;component/authorization/pageregister.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Authorization\PageRegister.xaml"
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
            this.tbLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Authorization\PageRegister.xaml"
            this.tbPhone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbPhone_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.tbCost = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Authorization\PageRegister.xaml"
            this.tbCost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbCost_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dpDeteOfBirth = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Authorization\PageRegister.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Authorization\PageRegister.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

