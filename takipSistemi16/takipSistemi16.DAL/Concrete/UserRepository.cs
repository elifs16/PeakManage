using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.DAL.Abstract;
using takipSistemi16.Entity;
using takipSistemi16.DAL;

namespace takipSistemi16.DAL.Concrete
{
    public class UserRepository : DbContext, IUserRepository
    {

        private DbContext _context;

        public UserRepository()
        {
            _context = new DbContext();
        }

        public void AddUser(User user)
        {
            string query = @"INSERT INTO users (UserName, Password, Role, Department, Maas)
                             VALUES (@u, @p, @r, @d, @m)";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            cmd.Parameters.AddWithValue("@u", user.UserName);
            cmd.Parameters.AddWithValue("@p", user.Password);
            cmd.Parameters.AddWithValue("@r", user.Role);
            cmd.Parameters.AddWithValue("@d", user.Department);
            cmd.Parameters.AddWithValue("@m", user.Maas);

            _context.Connection.Open();
            cmd.ExecuteNonQuery();
            _context.Connection.Close();
        }

        public User Login(string username, string password)
        {
            User user = null;

            string query = @"SELECT * FROM users 
                             WHERE UserName=@u AND Password=@p AND IsActive=1";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            _context.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                user = new User()
                {
                    UserID = Convert.ToInt32(dr["UserID"]),
                    UserName = dr["UserName"].ToString(),
                    Role = dr["Role"].ToString(),
                    Department = dr["Department"] == DBNull.Value
                                    ? null
                                    : dr["Department"].ToString(),
                    Maas = Convert.ToDecimal(dr["Maas"]),
                    PersonelID = dr["PersonelID"] == DBNull.Value
                                    ? null
                                    : (int?)Convert.ToInt32(dr["PersonelID"]),
                    IsActive = Convert.ToBoolean(dr["IsActive"])
                };
            }

            _context.Connection.Close();
            return user;
        }

            public List<User> GetAllEmployees()
        {
            List<User> users = new List<User>();

            string query = "SELECT * FROM users WHERE IsActive = 1";

            MySqlCommand cmd = new MySqlCommand(query, _context.Connection);
            _context.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                users.Add(new User
                {
                    UserID = Convert.ToInt32(dr["UserID"]),
                    UserName = dr["UserName"].ToString(),
                    Role = dr["Role"].ToString(),
                    Department = dr["Department"] == DBNull.Value
                                    ? null
                                    : dr["Department"].ToString(),
                    Maas = dr["Maas"] == DBNull.Value
                                    ? 0
                                    : Convert.ToDecimal(dr["Maas"]),
                    IsActive = Convert.ToBoolean(dr["IsActive"])
                });
            }

            _context.Connection.Close();
            return users;
        }

    }
}






