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

namespace Центр_занятости.ProfOrientacija
{
    /// <summary>
    /// Логика взаимодействия для PereObucenie.xaml
    /// </summary>
    public partial class PereObucenie : Page
    {
        public PereObucenie()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void addProfOr_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new ProfOrientacija.addObuc());
        }

        private void removeProfOr_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new ProfOrientacija.addObuc());
        }

        private void updateProfOr_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
