using Land.Data.Entities;
using Land.Data.Repositories;
using Land.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land.Services.Owners
{
    public class OwnersService : Land.Services.Owners.IOwnersService
    {
        private IOwnerRepository ownerRepository;

        public OwnersService(IOwnerRepository ownerRepository)
        {
            this.ownerRepository = ownerRepository;
        }

        public List<Owner> GetOwners()
        {
            return this.ownerRepository.GetAll();
        }

        public Owner GetOwner(string id)
        {
            return this.ownerRepository.FindById(id);
        }

        public bool CreateOwner(Owner owner)
        {
            this.ownerRepository.Add(owner);
            this.ownerRepository.SaveChanges();
            return true;
        }

        public bool EditOwner(Owner owner)
        {
            this.ownerRepository.Update(owner);
            this.ownerRepository.SaveChanges();
            return true;
        }
    }
}
