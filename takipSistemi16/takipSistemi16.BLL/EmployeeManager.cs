using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.DAL;
using takipSistemi16.DAL.Concrete;
using takipSistemi16.Entity;

namespace takipSistemi16.BLL
{
    public class EmployeeManager
    {
        UserRepository _repo;

        public EmployeeManager()
        {
            _repo = new UserRepository();
        }

    
        public List<User> GetEmployees()
        {
            return _repo.GetAllEmployees();
        }

   
        public void AddEmployee(User user)
        {
            if (string.IsNullOrWhiteSpace(user.UserName))
                throw new Exception("Kullanıcı adı boş olamaz");

            if (string.IsNullOrWhiteSpace(user.Password))
                throw new Exception("Şifre boş olamaz");

            if (string.IsNullOrWhiteSpace(user.Role))
                throw new Exception("Rol seçilmelidir");

            _repo.AddUser(user);
        }
    }
}
