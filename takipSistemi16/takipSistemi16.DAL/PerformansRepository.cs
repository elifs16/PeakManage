using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using takipSistemi16.DAL;
using takipSistemi16.Entity;

namespace takipSistemi16.DAL
{
    public class PerformansRepository
    {
        private DbContext _context;

        public PerformansRepository()
        {
            _context = new DbContext();
        }

        public void Add(string userName, int puan, string aciklama)
        {
            string query = @"INSERT INTO personel_performans 
                            (UserName, Puan, Tarih, Aciklama)
                            VALUES (@u, @p, @t, @a)";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            cmd.Parameters.AddWithValue("@u", userName);
            cmd.Parameters.AddWithValue("@p", puan);
            cmd.Parameters.AddWithValue("@t", DateTime.Now);
            cmd.Parameters.AddWithValue("@a", aciklama);

            _context.Connection.Open();
            cmd.ExecuteNonQuery();
            _context.Connection.Close();
        }

        public List<Performans> GetAll()
        {
            List<Performans> list = new List<Performans>();

            string query = "SELECT * FROM personel_performans";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            _context.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new Performans
                {
                    PerformansID = Convert.ToInt32(dr["PerformansID"]),
                    UserName = dr["UserName"].ToString(),
                    Puan = Convert.ToInt32(dr["Puan"]),
                    Tarih = Convert.ToDateTime(dr["Tarih"]),
                    Aciklama = dr["Aciklama"].ToString()
                });
            }

            _context.Connection.Close();
            return list;
        }

    }
}
