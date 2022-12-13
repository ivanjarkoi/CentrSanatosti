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

namespace Центр_занятости.OtdelKadrov.Vsaimodejstvie
{
    /// <summary>
    /// Логика взаимодействия для RoliRab.xaml
    /// </summary>
    public partial class RoliRab : Page
    {
        public RoliRab()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Entities1.Go().RolRabotnicovs.ToList();
        }

        private void addRol_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Add.addRoliRab());

        }

        private void removeRol_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateRol_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Add.addRoliRab());

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
