using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.BLL.Abstract;
using takipSistemi16.DAL;
using takipSistemi16.DAL.Concrete;
using takipSistemi16.Entity;

namespace takipSistemi16.BLL.Concrete
{
    public class UserManager : IUserService
    {
        UserRepository _repo = new UserRepository();

        public User Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                throw new Exception("Kullanıcı adı ve şifre boş olamaz");

            return _repo.Login(username, password);
        }
    }
}
