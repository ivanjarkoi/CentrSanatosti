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
    /// Логика взаимодействия для Professie.xaml
    /// </summary>
    public partial class Professie : Page
    {
        public Professie()
        {
            InitializeComponent();
        }

        private void addProfessia_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.Add.addprofessia());
        }

        private void removeProfessia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateProfessia_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.Add.addprofessia());

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
