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

namespace Центр_занятости
{
    /// <summary>
    /// Логика взаимодействия для Autorisacia.xaml
    /// </summary>
    public partial class Autorisacia : Page
    {
        public Autorisacia()
        {
            InitializeComponent();
        }

        private void avtorisaacia_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Rabocie rabocie = new PerecKlasov.Rabocie();
            rabocie.Login = login.Text.ToString();
            rabocie.Parol = password.Password.ToString();
            if (login.Text!="" && password.Password!="")
            {
                var basadan = Entities1.Go().Rabotnikis.ToList();
                foreach (var bd in basadan)
                {
                    if (((Rabotniki)bd).Login==rabocie.Login && ((Rabotniki)bd).Parol == rabocie.Parol)
                    {
                    //    rabocie.Login = ((Rabotniki)bd).Login;
                        rabocie.Parol = ((Rabotniki)bd).Parol;
                        rabocie.FIO = ((Rabotniki)bd).FIO;
                        rabocie.RolRabotnika = ((Rabotniki)bd).RolRabotnikaNomre;
                        break;
                    }
                 
                }
                switch (rabocie.RolRabotnika)
                { 
                    case 4:
                        PerecKlasov.Min.MAinFrmae.Navigate(new Buhgalterija.GlavForm());
                        break;
                    case 5:
                        PerecKlasov.Min.MAinFrmae.Navigate(new Administrator.RegistrciaPolsovatela());
                        break;
                    case 6:
                        PerecKlasov.Min.MAinFrmae.Navigate(new SodejstvieTrudoustrojstvu.GlavForm());
                        break;
                    case 8:
                        PerecKlasov.Min.MAinFrmae.Navigate(new ProfOrientacija.PereObucenie());
                        break;
                    case 9:
                        PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.GlavForm());
                        break;
                    case 10:
                        PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.GlavForm());
                        break;
                    default:
                        MessageBox.Show("Пользователя с таким логином или паролем нет","Сообщение",MessageBoxButton.OK,MessageBoxImage.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Заполиите логин и пароль","Сообщение",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            //   PerecKlasov.Min.MAinFrmae.Navigate(new Administrator.RegistrciaPolsovatela());
          //  PerecKlasov.Min.MAinFrmae.Navigate(new Rabocie.GlavForm());
        }
    }
}
