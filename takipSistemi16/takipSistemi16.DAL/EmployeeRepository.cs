using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.Entity;

namespace takipSistemi16.DAL
{
    public class EmployeeRepository: DbContext
    {
        DbContext _context = new DbContext();
        public List<User> GetAllEmployees()
        {
            List<User> list = new List<User>();

            string query = "SELECT * FROM users WHERE IsActive = 1";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            _context.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new User
                {
                    UserID = Convert.ToInt32(dr["UserID"]),
                    UserName = dr["UserName"].ToString(),
                    Role = dr["Role"].ToString(),
                    Department = dr["Department"].ToString(),
                    Maas = Convert.ToDecimal(dr["Maas"]),
                    PersonelID = dr["PersonelID"] == DBNull.Value ? null : (int?)Convert.ToInt32(dr["PersonelID"]),
                    IsActive = Convert.ToBoolean(dr["IsActive"])
                });
            }

            _context.Connection.Close();
            return list;
        }
    }
}
