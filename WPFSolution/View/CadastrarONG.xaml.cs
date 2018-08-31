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
    /// Lógica interna para CadastrarONG.xaml
    /// </summary>
    public partial class CadastrarONG : Window
    {
        public CadastrarONG()
        {
            InitializeComponent();
        }

        private void buttonVoltarCadastrarONG_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void buttonCadastrarONG_Click(object sender, RoutedEventArgs e)
        {
            Ong ong = new Ong();
            ong.Nome = textBoxCadastroONG.Text;
            ong.CNPJ= textBoxCnpjONG.Text;

            DBMock.DbOng.Add(ong);
            
            MessageBoxResult mbResult = MessageBox.Show("ONG cadastrada com sucesso, você quer ir a página de relatórios?", "Doacao Livros", MessageBoxButton.YesNo);
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
