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
    /// Логика взаимодействия для Kompanii.xaml
    /// </summary>
    public partial class Kompanii : Page
    {
        public Kompanii()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void addKomp_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new SodejstvieTrudoustrojstvu.Add.AddKompanii());
        }

        private void removeKomp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateKomp_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new SodejstvieTrudoustrojstvu.Add.AddKompanii());
        }
    }
}
