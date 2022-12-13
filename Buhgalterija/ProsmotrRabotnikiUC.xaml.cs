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

namespace Центр_занятости.Buhgalterija
{
    /// <summary>
    /// Логика взаимодействия для ProsmotrRabotnikiUC.xaml
    /// </summary>
    public partial class ProsmotrRabotnikiUC : Page
    {
        public ProsmotrRabotnikiUC()
        {
            InitializeComponent();
            Rol.ItemsSource = Entities1.Go().RolRabotnicovs.ToList();
            dataGrid.ItemsSource = Entities1.Go().Rabotnikis.ToList();
        }

        private void Rol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int t = Convert.ToInt32(Rol.SelectedValue);
            dataGrid.ItemsSource = Entities1.Go().Rabotnikis.Where(p => p.RolRabotnikaNomre == t).ToList();
        }
    }
}
