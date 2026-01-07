using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.Entity;

namespace takipSistemi16.DAL.Abstract
{
    public interface IIzinRepository
    {
        void Add(Izin izin);
        List<Izin> GetByUserName(string userName);
        int GetUsedLeaveDays(string userName);
        List<Izin> GetAll();
        void UpdateStatus(int izinId, string durum);
    }
}
