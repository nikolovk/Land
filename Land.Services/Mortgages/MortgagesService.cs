using Land.Data.Entities;
using Land.Data.Repositories;
using Land.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.Services.Mortgages
{
    public class MortgagesService : Land.Services.Mortgages.IMortgagesService
    {
        private ImortgageRepository mortgageRepository;

        public MortgagesService(ImortgageRepository mortgageRepository)
        {
            this.mortgageRepository = mortgageRepository;
        }

        public List<Mortgage> GetMortgages()
        {
            return this.mortgageRepository.GetAll();
        }

        public Mortgage GetMortgage(int id)
        {
            return this.mortgageRepository.FindById(id);
        }

        public string CreateMortgage(Mortgage mortgage)
        {
            this.mortgageRepository.Add(mortgage);
            this.mortgageRepository.SaveChanges();
            return mortgage.UPI;
        }

        public bool EditMortgage(Mortgage mortgage)
        {
            this.mortgageRepository.Update(mortgage);
            this.mortgageRepository.SaveChanges();
            return true;
        }
    }
}
