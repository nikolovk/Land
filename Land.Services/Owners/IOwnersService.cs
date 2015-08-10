using Land.Data.Entities;
using System;
using System.Collections.Generic;
namespace Land.Services.Owners
{
    public interface IOwnersService
    {
        bool CreateOwner(Land.Data.Entities.Owner owner);
        bool EditOwner(Land.Data.Entities.Owner owner);
        List<Owner> GetOwners();
    }
}
