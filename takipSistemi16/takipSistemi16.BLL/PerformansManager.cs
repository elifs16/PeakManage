using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using takipSistemi16.DAL;
using takipSistemi16.Entity;

namespace takipSistemi16.BLL
{
    public class PerformansManager
    {
        PerformansRepository _repo;

        public PerformansManager()
        {
            _repo = new PerformansRepository();
        }

        public List<Performans> GetAll()
        {
            return _repo.GetAll();
        }

        public List<Performans> GetByUser(string userName)
        {
            return _repo.GetAll()
                        .Where(x => x.UserName == userName)
                        .ToList();
        }


        public void AddScore(string userName, int puan, string aciklama)
        {
            if (puan < 0 || puan > 10)
                throw new Exception("Performans puanı 0-10 arası olmalı");

            _repo.Add(userName, puan, aciklama);

        }
    }
}
