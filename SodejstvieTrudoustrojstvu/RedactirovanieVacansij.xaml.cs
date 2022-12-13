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
    /// Логика взаимодействия для RedactirovanieVacansij.xaml
    /// </summary>
    public partial class RedactirovanieVacansij : Page
    {
        public RedactirovanieVacansij()
        {
            InitializeComponent();
        }

        private void addRol_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new SodejstvieTrudoustrojstvu.Add.addSapis());
        }

        private void removeRol_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateRol_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new SodejstvieTrudoustrojstvu.Add.addSapis());

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
