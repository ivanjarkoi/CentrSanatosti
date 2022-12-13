using Microsoft.Win32;
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

namespace Центр_занятости.Administrator
{
    /// <summary>
    /// Логика взаимодействия для RegistrciaPolsovatela.xaml
    /// </summary>
    public partial class RegistrciaPolsovatela : Page
    {
        public RegistrciaPolsovatela()
        {
            InitializeComponent();
            rol.ItemsSource = Entities1.Go().RolRabotnicovs.ToList();
            nomergrafka.ItemsSource = Entities1.Go().GRafics.ToList();


        }

        private void AddImage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void grafik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void proverka_Click(object sender, RoutedEventArgs e)
        {
            string q1 = passsword.Password.ToString();
            string q2= provpassw.Password.ToString();
            if (q1 !="" && q2!="")
            { 
            if (q1==q2)
            {
                add.IsEnabled= true;
            }
            else
            {
                MessageBox.Show("Проверьте пароль");
            }
            }
            else {
                MessageBox.Show("Заполните поля пароля");

            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(datePik.Text);
            int opl = Convert.ToInt32(oplata.Text.ToString());
            Entities1.Go().Rabotnikis.Add(new Rabotniki { 
                    Login=login.Text.ToString(),
                    Parol=passsword.Password.ToString(),
                FIO=fio.Text.ToLower(),
                    NOmerTelefona=telefon.Text.ToString(),
                    DateRojdenia=date,
                Pocta=pocta.Text.ToString(),

                    RolRabotnicov = (RolRabotnicov)rol.SelectedItem,
                    GRafic =(GRafic)nomergrafka.SelectedItem,
                    Oplata=opl
                });
              //  Entities.Go().SaveChanges();
                try
                {
                Entities1.Go().SaveChanges();
                MessageBox.Show("Пользователь добавлен" );
                }
                catch { }
           
          


        }
        string imgLocation = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if ((bool)dialog.ShowDialog())
            {
                imgLocation = dialog.FileName;
                imaget.Source = new BitmapImage(new Uri(dialog.FileName, UriKind.Absolute));
            }
        }
    }
}
