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

namespace Центр_занятости.OtdelKadrov.Vsaimodejstvie.Add
{
    /// <summary>
    /// Логика взаимодействия для addRabotniki.xaml
    /// </summary>


    public partial class addRabotniki : Page
    {
        public string logint { get; set; }
        public string par { get; set; }
        public string Fioo { get; set; }
        public string tel { get; set; }
        public string datar { get; set; }
        public string pocti { get; set; }
        public int roli { get; set; }
        public int graF { get; set; }


        public addRabotniki(Rabotniki Rabotniki)
        {
            InitializeComponent();
          
            OtdelKadrov.Vsaimodejstvie.Rabotniki rabotniki = new Rabotniki();
            Pomoh pomoh = new Pomoh();
            login.Text = logint;

            rol.ItemsSource = Entities1.Go().RolRabotnicovs.ToList();
            nomergrafka.ItemsSource = Entities1.Go().GRafics.ToList();
            
        }



     
        private void add_Click(object sender, RoutedEventArgs e, Центр_занятости.Rabotniki rabotniki2)
        {

            DateTime date = Convert.ToDateTime(datePik.Text);
            Entities1.Go().Rabotnikis.Add(new Центр_занятости.Rabotniki
            {
                Login = login.Text.ToString(),
                Parol = passsword.Password.ToString(),
                FIO = fio.Text.ToLower(),
                NOmerTelefona = telefon.Text.ToString(),
                DateRojdenia = date,
                Pocta = pocta.Text.ToString(),
            });
            try
            {
                Entities1.Go().SaveChanges();
                MessageBox.Show("Всё хорошо");
                PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Rabotniki());
            }
            catch
            {

            }
      
        }

        private void proverka_Click(object sender, RoutedEventArgs e)
        {
            string q1 = passsword.Password.ToString();
            string q2 = provpassw.Password.ToString();
            if (q1 != "" && q2 != "")
            {
                if (q1 == q2)
                {
                    ADD.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Проверьте пароль");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля пароля");

            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
          
            PerecKlasov.Rabocie rabocie = new PerecKlasov.Rabocie();
            if (logint == "")
            {
                DateTime date = Convert.ToDateTime(datePik.Text);
                Entities1.Go().Rabotnikis.Add(new Центр_занятости.Rabotniki
                {
                    Login = login.Text.ToString(),
                    Parol = passsword.Password.ToString(),
                    FIO = fio.Text.ToLower(),
                    NOmerTelefona = telefon.Text.ToString(),
                    DateRojdenia = date,
                    Pocta = pocta.Text.ToString(),
                    RolRabotnicov = (RolRabotnicov)rol.SelectedItem,
                    GRafic = (GRafic)nomergrafka.SelectedItem,
                });
                try
                {
                    Entities1.Go().SaveChanges();
                    MessageBox.Show("Всё хорошо");
                    PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Rabotniki());
                }
                catch
                {

                }
            }
            else
            {
                DateTime date = Convert.ToDateTime(datePik.Text);
                Entities1.Go().Rabotnikis.Where(p => p.Login == rabocie.Login).Select(
                    p => new Центр_занятости.Rabotniki {
                        Login = login.Text.ToString(),
                        Parol = passsword.Password.ToString(),
                        FIO = fio.Text.ToLower(),
                        NOmerTelefona = telefon.Text.ToString(),
                        DateRojdenia = date,
                        Pocta = pocta.Text.ToString(),
                        RolRabotnicov = (RolRabotnicov)rol.SelectedItem,
                        GRafic = (GRafic)nomergrafka.SelectedItem,
                    });
                try
                {
                    Entities1.Go().SaveChanges();
                    MessageBox.Show("Всё хорошо");
                    PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Rabotniki());

                }
                catch
                {
                    MessageBox.Show("Лох");
                }
            }

        }

        private void ADD_Click_1(object sender, RoutedEventArgs e)
        {


            try
            {
 //DateTime date = ; 
        
            try
            {

                    Entities1.Go().Rabotnikis.Add(new Центр_занятости.Rabotniki
                    {
                        Login = login.Text.ToString(),
                        Parol = passsword.Password.ToString(),
                        FIO = fio.Text.ToLower(),
                        NOmerTelefona = telefon.Text.ToString(),
                        DateRojdenia = Convert.ToDateTime(datePik.Text),
                        Pocta = pocta.Text.ToString(),

                        RolRabotnicov = (RolRabotnicov)rol.SelectedItem,
                        GRafic = (GRafic)nomergrafka.SelectedItem,
                    });

                    try
                    {

                        Entities1.Go().SaveChanges();
                        MessageBox.Show("Добавлен пользователь");
                        PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Rabotniki());
                    }
                    catch
                    {
                          MessageBox.Show("Допущена ошибка");
                    }
               
            }
               
            catch { }
          
            if(logint!=null)
            {
                    Центр_занятости.Rabotniki rabotniki = new Центр_занятости.Rabotniki();
                    var r = Entities1.Go().Rabotnikis.Where(p => p.Login == logint);
                    Entities1.Go().Rabotnikis.RemoveRange(r);
                    rabotniki.Login = login.Text.ToString();
                    Entities1.Go().SaveChanges();
                    logint = null;
                    MessageBox.Show("Пользователь изменён");
                    PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Rabotniki());
                }
            }
            catch
            {

            }


           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Центр_занятости.PerecKlasov.Rabocie rabocie = new PerecKlasov.Rabocie();
      


            login.Text = logint;
            passsword.Password = par;
            fio.Text = Fioo;
            telefon.Text = tel;
            datePik.Text = datar;
            pocta.Text = pocti;
            rol.SelectedIndex = roli - 1;
            provpassw.Password = par;
            nomergrafka.SelectedIndex = graF - 1;
            Pomoh pomoh = new Pomoh();
          
        }

          
    }

       
    } 
