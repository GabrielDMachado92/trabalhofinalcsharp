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
using WPFSolution.Service;

namespace WPFSolution
{
    /// <summary>
    /// Lógica interna para CadastrarLivro.xaml
    /// </summary>
    public partial class CadastrarLivro : Window
    {
        public CadastrarLivro()
        {
            InitializeComponent();
        }

        private void buttonVoltarCadastrarLivros_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void buttonCadastrarLivro_Click(object sender, RoutedEventArgs e)
        {

            Livro livro = new Livro();
            livro.Nome = textBoxNomeLivro.Text;
            livro.Edicao = int.Parse(comboBoxEdicaoLivro.Text);

            Doador d = new Doador();
            d.Nome = "Gabriel";
            d.CPF = "12345698";
            d.Idade = 22;

            Ong o = new Ong();
            o.Nome = "A+";
            o.CNPJ = "99999999";

            livro.ong = o;
            livro.doador = d;

            DBMock.DbLivro.Add(livro);


            MessageBoxResult mbResult = MessageBox.Show("Livro cadastrado com sucesso, você quer ir a página de relatórios?", "Doacao Livros", MessageBoxButton.YesNo);
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
