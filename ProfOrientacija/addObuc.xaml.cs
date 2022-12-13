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
    /// Логика взаимодействия для addObuc.xaml
    /// </summary>
    public partial class addObuc : Page
    {
        public addObuc()
        {
            InitializeComponent();
        }

        private void addProfOr_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new ProfOrientacija.PereObucenie());
        }
    }
}
