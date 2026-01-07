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
    public class AdminManager
    {
        UserRepository _userRepo;
        PerformansRepository _performansRepo;

        public AdminManager()
        {
            _userRepo = new UserRepository();
            _performansRepo = new PerformansRepository();
        }

        public List<AdminEmployeeDto> GetEmployeesWithPerformance()
        {
            var users = _userRepo.GetAllEmployees();
            var performances = _performansRepo.GetAll();

            var result = from u in users
                         join p in performances
                         on u.UserName equals p.UserName into perf
                         from p in perf.DefaultIfEmpty()
                         select new AdminEmployeeDto
                         {
                             UserName = u.UserName,
                             Department = u.Department,
                             Role = u.Role,
                             PerformanceScore = p != null ? p.Puan : 0
                         };

            return result.ToList();
        }
    }
}
