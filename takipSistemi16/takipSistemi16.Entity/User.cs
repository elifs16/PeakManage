using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takipSistemi16.Entity
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public decimal Maas { get; set; }
        public int? PersonelID { get; set; }
        public bool IsActive { get; set; }
    }
}
