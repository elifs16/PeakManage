using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takipSistemi16.Entity
{
    public class Izin
    {
        public int IzinID { get; set; }
        public string UserName { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }
    }
}
