using Land.Data.Entities;
using Land.Data.Repositories;
using Land.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.Services.LandProperties
{

    public class LandPropertiesService : Land.Services.LandProperties.ILandPropertiesService
    {
        private ILandPropertyRepository landPropertyRepository;

        public LandPropertiesService(ILandPropertyRepository landPropertyRepository)
        {
            this.landPropertyRepository = landPropertyRepository;
        }

        public List<LandProperty> GetLandProperties()
        {
            return this.landPropertyRepository.GetAll();
        }

        public LandProperty GetLandProperty(string id)
        {
            return this.landPropertyRepository.FindById(id);
        }

        public string CreateLandProperty(LandProperty landProperty)
        {
            this.landPropertyRepository.Add(landProperty);
            this.landPropertyRepository.SaveChanges();
            return landProperty.UPI;
        }

        public bool EditLandProperty(LandProperty landProperty)
        {
            this.landPropertyRepository.Update(landProperty);
            this.landPropertyRepository.SaveChanges();
            return true;
        }
    }
}
