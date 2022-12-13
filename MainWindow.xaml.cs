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

using Центр_занятости.PerecKlasov;

namespace Центр_занятости
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Autorisacia());
            Min.MAinFrmae = MainFrame;
        }

        private void Spravka_Click(object sender, RoutedEventArgs e)
        {
            Min.MAinFrmae.Navigate(new Spravka());
        }

        private void Nasad_Click(object sender, RoutedEventArgs e)
        {
            Min.MAinFrmae.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                Nasad.Visibility = Visibility.Visible;
                Spravka.Visibility = Visibility.Visible;
            }
            else
            {
                Nasad.Visibility = Visibility.Hidden;
                Spravka.Visibility = Visibility.Hidden;
            }
        }
    }
}
