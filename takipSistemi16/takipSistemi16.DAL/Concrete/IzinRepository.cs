using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.DAL.Abstract;
using takipSistemi16.Entity;
using takipSistemi16.DAL;

namespace takipSistemi16.DAL.Concrete
{
    public class IzinRepository : DbContext, IIzinRepository
    {
        DbContext _context;

        public IzinRepository()
        {
            _context = new DbContext();
        }
        public void Add(Izin izin)
        {
            string query = @"INSERT INTO izin_talepleri
        (UserName, Baslangic, Bitis, Aciklama, Durum)
        VALUES (@u, @b, @bt, @a, 'Beklemede')";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            cmd.Parameters.AddWithValue("@u", izin.UserName);
            cmd.Parameters.AddWithValue("@b", izin.Baslangic);
            cmd.Parameters.AddWithValue("@bt", izin.Bitis);
            cmd.Parameters.AddWithValue("@a", izin.Aciklama);

            _context.Connection.Open();
            cmd.ExecuteNonQuery();
            _context.Connection.Close();
        }

        public List<Izin> GetByUserName(string userName)
        {
            List<Izin> list = new List<Izin>();

            string query = "SELECT * FROM izin_talepleri WHERE UserName=@u";
            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            cmd.Parameters.AddWithValue("@u", userName);

            _context.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new Izin
                {
                    IzinID = Convert.ToInt32(dr["IzinID"]),
                    UserName = dr["UserName"].ToString(),
                    Baslangic = Convert.ToDateTime(dr["Baslangic"]),
                    Bitis = Convert.ToDateTime(dr["Bitis"]),
                    Aciklama = dr["Aciklama"].ToString(),
                    Durum = dr["Durum"].ToString()
                });
            }

            _context.Connection.Close();
            return list;
        }

        public int GetUsedLeaveDays(string userName)
        {
            string query = @"SELECT IFNULL(SUM(DATEDIFF(Bitis,Baslangic)+1),0)
                     FROM izin_talepleri
                     WHERE UserName=@u AND Durum='Onaylandı'";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            cmd.Parameters.AddWithValue("@u", userName);

            _context.Connection.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            _context.Connection.Close();

            return result;
        }
        public List<Izin> GetAll()
        {
            List<Izin> list = new List<Izin>();

            string query = "SELECT * FROM izin_talepleri";
            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);

            _context.Connection.Open();
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new Izin
                {
                    IzinID = Convert.ToInt32(dr["IzinID"]),
                    UserName = dr["UserName"].ToString(),
                    Baslangic = Convert.ToDateTime(dr["Baslangic"]),
                    Bitis = Convert.ToDateTime(dr["Bitis"]),
                    Aciklama = dr["Aciklama"].ToString(),
                    Durum = dr["Durum"].ToString()
                });
            }

            _context.Connection.Close();
            return list;
        }

        public void UpdateStatus(int izinId, string durum)
        {
            string query = "UPDATE izin_talepleri SET Durum=@d WHERE IzinID=@id";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            cmd.Parameters.AddWithValue("@d", durum);
            cmd.Parameters.AddWithValue("@id", izinId);

            _context.Connection.Open();
            cmd.ExecuteNonQuery();
            _context.Connection.Close();
        }


    }
}
