using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takipSistemi16.Entity
{
    public class AdminEmployeeDto
    {
        public string UserName { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public int PerformanceScore { get; set; }
    }
}
