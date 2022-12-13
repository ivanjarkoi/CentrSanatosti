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
    /// Логика взаимодействия для TipGgrafika.xaml
    /// </summary>
    public partial class TipGgrafika : Page
    {
        public TipGgrafika()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Entities1.Go().TipGrafiks.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void updateVidG_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Add.addTipSanatosti());

        }

        private void removeVidG_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addVidG_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Add.addTipSanatosti());

        }
    }
}
