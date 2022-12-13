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

namespace Центр_занятости.OtdelKadrov.Vsaimodejstvie
{
    /// <summary>
    /// Логика взаимодействия для Rabotniki.xaml
    /// </summary>
    public partial class Rabotniki : Page
    {
        public string Login { get; internal set; }
        public string Parol { get; internal set; }
        public string FIO { get; internal set; }
        public string NOmerTelefona { get; internal set; }
        public DateTime DateRojdenia { get; internal set; }
        public string Pocta { get; internal set; }

        public Rabotniki()
        {
            InitializeComponent();
            DataContext = Entities1.Go().Rabotnikis.ToList();
        }

        private void addRol_Click(object sender, RoutedEventArgs e)
        {
            PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Add.addRabotniki(null));
        }

        private void removeRol_Click(object sender, RoutedEventArgs e)
        {

            var cellInfo = DataGrid1.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;
            if (MessageBox.Show("Вы действитель хотите удалить?", "Сообщение", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {

                var r = Entities1.Go().Rabotnikis.Where(p=>p.Login==content);
                try
                {
                    Entities1.Go().Rabotnikis.RemoveRange(r);
                    Entities1.Go().SaveChanges();
                    DataGrid1.ItemsSource = Entities1.Go().Rabotnikis.ToList();
                }
                catch { }
            }
            DataGrid1.ItemsSource = Entities1.Go().Rabotnikis.ToList();
          

        }
        public string log;
        private void updateRol_Click(object sender, RoutedEventArgs e)
        {
            var basadan = Entities1.Go().Rabotnikis.ToList();
            var cellInfo = DataGrid1.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;
            foreach (var bd in basadan)
            {
                if (((Центр_занятости.Rabotniki)bd).Login== content)
                {

                  
                  
                   string log = ((Центр_занятости.Rabotniki)bd).Login;
                   string p = ((Центр_занятости.Rabotniki)bd).Parol;
                     
                    string f = ((Центр_занятости.Rabotniki)bd).FIO;
                    string nom= ((Центр_занятости.Rabotniki)bd).NOmerTelefona;
                     string dat=Convert.ToString(((Центр_занятости.Rabotniki)bd).DateRojdenia)  ;
                    string poc=((Центр_занятости.Rabotniki)bd).Pocta;

                    int rol = ((Центр_занятости.Rabotniki)bd).RolRabotnikaNomre;
                    int graf = ((Центр_занятости.Rabotniki)bd).RolRabotnikaNomre;
                    Pomoh pomoh = new Pomoh { Login=log};
                
                    PerecKlasov.Min.MAinFrmae.Navigate(new OtdelKadrov.Vsaimodejstvie.Add.addRabotniki(
                        (sender as Button).DataContext as Rabotniki)
                    { logint = log, par = p, Fioo = f,tel=nom,datar=dat, pocti=poc,roli=rol,graF=graf }) ;


                }
             

            }

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Entities1.Go().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DataGrid1.ItemsSource = Entities1.Go().Rabotnikis.ToList();
        }
    }
}
