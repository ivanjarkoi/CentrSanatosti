using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Центр_занятости.PerecKlasov
{
     class Rabocie
    {
        

        public  string Login { get; set; }
        public string Parol { get; set; }
        public string FIO { get; set; }  
        public string Telefon { get; set; }
        public byte[] Foto { get; set; }
        public DateTime DataRojDenija { get; set; }
        public string Pocta { get; set; }
        public int RolRabotnika { get; set; }
        public int NomerGrafika { get; set; }
        public int Oplata { get; set; }

    }
}
