using Land.Data.Entities;
using Land.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.Data.Repositories
{
    public class LandPropertyRepository: Repository<LandProperty>,ILandPropertyRepository
    {
    }
}
