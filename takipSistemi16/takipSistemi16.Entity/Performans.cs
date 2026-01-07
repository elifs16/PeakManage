using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takipSistemi16.Entity
{
    public class Performans
    {
        public int PerformansID { get; set; }
        public string UserName { get; set; }
        public int Puan { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
