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
    /// Логика взаимодействия для BeasrabotnijProfessia.xaml
    /// </summary>
    public partial class BeasrabotnijProfessia : Page
    {
        public BeasrabotnijProfessia()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void addProfIMeut_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Add.AddProfBesrab());

        }

        private void removeProfIMeut_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Add.AddProfBesrab());

        }

        private void updateProfIMeut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
