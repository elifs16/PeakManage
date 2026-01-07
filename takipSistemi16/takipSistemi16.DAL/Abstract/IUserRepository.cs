using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.Entity;

namespace takipSistemi16.DAL.Abstract
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User Login(string username, string password);
        List<User> GetAllEmployees(); 
    }
}
