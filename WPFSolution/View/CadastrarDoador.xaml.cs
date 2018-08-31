using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFSolution.Models;

namespace WPFSolution
{
    /// <summary>
    /// Lógica interna para CadastrarDoador.xaml
    /// </summary>
    public partial class CadastrarDoador : Window
    {
        public CadastrarDoador()
        {
            InitializeComponent();
        }

        private void buttonVoltarCadastroDoador_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void buttonCadastrarDoador_Click(object sender, RoutedEventArgs e)
        {
            Doador doador = new Doador();
            doador.Nome = textBoxNomeDoador.Text;
            doador.CPF = textBoxCPF.Text;
            doador.Idade = int.Parse(textBoxIdade.Text);

            MessageBoxResult mbResult = MessageBox.Show("Doador cadastrado com sucesso, você quer ir a página de relatórios?", "Doacao Livros", MessageBoxButton.YesNo);
            switch (mbResult)
            {
                case MessageBoxResult.Yes:
                    Relatorios r = new Relatorios();
                    r.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                    break;
            }
        }
    }
}
