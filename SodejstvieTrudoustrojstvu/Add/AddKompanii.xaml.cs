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

namespace Центр_занятости.SodejstvieTrudoustrojstvu.Add
{
    /// <summary>
    /// Логика взаимодействия для AddKompanii.xaml
    /// </summary>
    public partial class AddKompanii : Page
    {
        public AddKompanii()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new SodejstvieTrudoustrojstvu.Kompanii());
        }
    }
}
