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

namespace Центр_занятости.SodejstvieTrudoustrojstvu
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

        private void perehKompanii_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new SodejstvieTrudoustrojstvu.Kompanii());
        }

        private void perehPRosmiVacansii_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new SodejstvieTrudoustrojstvu.RedactirovanieVacansij());

        }
    }
}
