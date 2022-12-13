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

namespace Центр_занятости.Rabocie
{
    /// <summary>
    /// Логика взаимодействия для Obrasovanija.xaml
    /// </summary>
    public partial class Obrasovanija : Page
    {
        public Obrasovanija()
        {
            InitializeComponent();
        }

        private void removeObras_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addObras_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Add.Obrasovanie());

        }

        private void updateObras_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Add.Obrasovanie());

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
