﻿#pragma checksum "..\..\CadastrarDoador.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ACAB400AA00466E49A6D26B27D59CD602B9C7E29"
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
    /// CadastrarDoador
    /// </summary>
    public partial class CadastrarDoador : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCadastrarDoador;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelNomeDoador;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNomeDoador;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCPF;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelIdade;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxIdade;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCadastrarDoador;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CadastrarDoador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonVoltarCadastroDoador;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFSolution;component/cadastrardoador.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CadastrarDoador.xaml"
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
            this.labelCadastrarDoador = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labelNomeDoador = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.textBoxNomeDoador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.textBoxCPF = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.labelIdade = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.textBoxIdade = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.buttonCadastrarDoador = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.buttonVoltarCadastroDoador = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\CadastrarDoador.xaml"
            this.buttonVoltarCadastroDoador.Click += new System.Windows.RoutedEventHandler(this.buttonVoltarCadastroDoador_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
