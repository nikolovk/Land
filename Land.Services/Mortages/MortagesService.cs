using Land.Data.Entities;
using Land.Data.Repositories;
using Land.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.Services.Mortages
{
    public class MortagesService : Land.Services.Mortages.IMortagesService
    {
        private IMortageRepository mortageRepository;

        public MortagesService(IMortageRepository mortageRepository)
        {
            this.mortageRepository = mortageRepository;
        }

        public List<Mortage> GetMortages()
        {
            return this.mortageRepository.GetAll();
        }

        public Mortage GetMortage(int id)
        {
            return this.mortageRepository.FindById(id);
        }

        public int CreateMortage(Mortage mortage)
        {
            this.mortageRepository.Add(mortage);
            this.mortageRepository.SaveChanges();
            return mortage.MortageID;
        }

        public bool EditMortage(Mortage mortage)
        {
            this.mortageRepository.Update(mortage);
            this.mortageRepository.SaveChanges();
            return true;
        }
    }
}
