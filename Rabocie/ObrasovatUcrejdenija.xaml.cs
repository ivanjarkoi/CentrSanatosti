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
    /// Логика взаимодействия для ObrasovatUcrejdenija.xaml
    /// </summary>
    public partial class ObrasovatUcrejdenija : Page
    {
        public ObrasovatUcrejdenija()
        {
            InitializeComponent();
        }

        private void addObrUc_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Add.addObrasUcrejdenie());
        }

        private void removeObrUc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateObrUc_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Add.addObrasUcrejdenie());

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
