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
    /// Логика взаимодействия для GrafikRabot.xaml
    /// </summary>
    public partial class GrafikRabot : Page
    {
        public GrafikRabot()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Entities1.Go().GRafics.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void addGrafRab_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Add.addGrafikRabot());

        }



        private void removeGrafRab_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateGrafRab_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Add.addGrafikRabot());

        }
    }
}
