using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.Entity;

namespace takipSistemi16.BLL.Abstract
{
    public interface IUserService
    {
        User Login(string username, string password);
    }
}
