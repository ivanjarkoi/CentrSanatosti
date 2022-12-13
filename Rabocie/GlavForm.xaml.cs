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
    /// Логика взаимодействия для GlavForm.xaml
    /// </summary>
    public partial class GlavForm : Page
    {
        public GlavForm()
        {
            InitializeComponent();
        }

        private void ProfBesrab_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.BeasrabotnijProfessia());
        }

        private void besrabotnie_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.Besrabotnie());
        }

        private void obrasovanie_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.Obrasovanija());
        }

        private void OBRUcrejdenija_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.ObrasovatUcrejdenija());
        }

        private void professija_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.Professie());
        }
    }
}
