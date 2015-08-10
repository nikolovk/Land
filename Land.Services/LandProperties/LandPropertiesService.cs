using Land.Data.Entities;
using Land.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.Services.LandProperties
{

    public class LandPropertiesService
    {
        private LandPropertyRepository landPropertyRepository;

        public LandPropertiesService(LandPropertyRepository landPropertyRepository)
        {
            this.landPropertyRepository = landPropertyRepository;
        }
    }
}
