using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace takipSistemi16.DAL
{
    public class DbContext
    {
        public MySqlConnection Connection { get; set; }

        public DbContext()
        {
            Connection = new MySqlConnection(
                "Server=172.21.54.253;Port= 3306; Database=26_132430001;Uid=26_132430001;Pwd=İnif123.;");
        }
    
    }
}
