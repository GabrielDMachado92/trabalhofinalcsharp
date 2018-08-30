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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSolution
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCadastrarLivro_Click(object sender, RoutedEventArgs e)
        {
            CadastrarLivro cadLivro = new CadastrarLivro();
            cadLivro.Show();
            this.Close();
        }

        private void buttonCadastrarDoador_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDoador cadDoador = new CadastrarDoador();
            cadDoador.Show();
            this.Close();
        }

        private void buttonCadastrarOng_Click(object sender, RoutedEventArgs e)
        {
            CadastrarONG cadOng = new CadastrarONG();
            cadOng.Show();
            this.Close();
        }

        private void buttonRelatorios_Click(object sender, RoutedEventArgs e)
        {
            Relatorios rel = new Relatorios();
            rel.Show();
            this.Close();
        }
    }
}
