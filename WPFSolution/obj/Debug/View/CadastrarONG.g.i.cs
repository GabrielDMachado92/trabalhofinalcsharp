﻿#pragma checksum "..\..\..\View\CadastrarONG.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DE0602AE07CBE9105FEC2BAF6D44FF4CCD2E71AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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
using WPFSolution;


namespace WPFSolution {
    
    
    /// <summary>
    /// CadastrarONG
    /// </summary>
    public partial class CadastrarONG : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\View\CadastrarONG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCadastrarONG;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\View\CadastrarONG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelNomeONG;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\CadastrarONG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCadastroONG;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\CadastrarONG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\CadastrarONG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCnpjONG;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\CadastrarONG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCadastrarONG;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\CadastrarONG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonVoltarCadastrarONG;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFSolution;component/view/cadastrarong.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CadastrarONG.xaml"
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
            this.labelCadastrarONG = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labelNomeONG = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.textBoxCadastroONG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.textBoxCnpjONG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.buttonCadastrarONG = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\CadastrarONG.xaml"
            this.buttonCadastrarONG.Click += new System.Windows.RoutedEventHandler(this.buttonCadastrarONG_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonVoltarCadastrarONG = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\CadastrarONG.xaml"
            this.buttonVoltarCadastrarONG.Click += new System.Windows.RoutedEventHandler(this.buttonVoltarCadastrarONG_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

