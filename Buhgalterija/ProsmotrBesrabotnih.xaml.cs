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
    /// Логика взаимодействия для ProsmotrBesrabotnih.xaml
    /// </summary>
    public partial class ProsmotrBesrabotnih : Page
    {
        public ProsmotrBesrabotnih()
        {
            InitializeComponent();
            
            Rol.ItemsSource= Entities1.Go().Professias.ToList();
            Duttiput.ItemsSource = Entities1.Go().BesRabs.ToList();
        }

        private void Rol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            int t = Convert.ToInt32(Rol.SelectedValue);
            Duttiput.ItemsSource = Entities1.Go().BesRabs.Where(p=> p.NomerProfessia==t).ToList();
        }
    }
}
