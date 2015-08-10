using Land.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.Services.Mortages
{
    public class MortagesService
    {
        private MortageRepository mortageRepository;

        public MortagesService(MortageRepository mortageRepository)
        {
            this.mortageRepository = mortageRepository;
        }
    }
}
