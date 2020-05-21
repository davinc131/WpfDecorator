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
using Model;
using Model.Adicional;
using Repository;

namespace WpfApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private TargetRepository repository { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            repository = new TargetRepository();
            cbDestino.ItemsSource = repository.getDestinos();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(cbDestino.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um destino!");
                }
                else
                {
                    var item = cbDestino.SelectedItem as Passagem;

                    if (checkBagagem.IsChecked.Equals(true))
                        item = new BagagemDeMao(item);
                    if (checkExcedente.IsChecked.Equals(true))
                        item = new PesoExcedente(item);
                    if (checkPoltrona.IsChecked.Equals(true))
                        item = new PoltronaExtra(item);

                    lbValor.Content = item.getValorPassagem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
