using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.DAL;
using takipSistemi16.DAL.Concrete;
using takipSistemi16.Entity;
using takipSistemi16.DAL.Abstract;


namespace takipSistemi16.BLL.Concrete
{
    public class IzinManager
    {
        IIzinRepository _repo;

        public IzinManager()
        {
            _repo = new IzinRepository();
        }

        public void Add(Izin izin)
        {
            int talepGun = (izin.Bitis - izin.Baslangic).Days + 1;

            if (talepGun <= 0)
                throw new Exception("Tarih aralığı hatalı");

            int kullanilanGun = _repo.GetUsedLeaveDays(izin.UserName);

            if (kullanilanGun + talepGun > 14)
                throw new Exception("İzin hakkınız 14 günü geçemez");

            _repo.Add(izin);
        }

        public List<Izin> GetMyLeaves(string userName)
        {
            return _repo.GetByUserName(userName);
        }

        public List<Izin> GetAllIzinler()
        {
            return _repo.GetAll();
        }

        public void Onayla(int izinId)
        {
            _repo.UpdateStatus(izinId, "Onaylandı");
        }

        public void Reddet(int izinId)
        {
            _repo.UpdateStatus(izinId, "Reddedildi");
        }
   

    }
}
