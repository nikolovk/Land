using Land.Data.Entities;
using Land.Services.Owners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Land.WebApi.Controllers
{
    public class OwnersController : ApiController
    {
        private IOwnersService ownersService;

        public OwnersController(IOwnersService ownersService)
        {
            this.ownersService = ownersService;
        }

        // GET: api/Owners
        public IHttpActionResult Get()
        {
            List<Owner> owners = this.ownersService.GetOwners();
            return Ok(owners);
        }

        // GET: api/Owners/5
        public IHttpActionResult Get(string id)
        {
            Owner owner = this.ownersService.GetOwner(id);
            return Ok(owner);
        }

        // POST: api/Owners
        public IHttpActionResult Post(Owner owner)
        {
            bool result = this.ownersService.CreateOwner(owner);
            return Ok(result);
        }

        // PUT: api/Owners/5
        public IHttpActionResult Put(Owner owner)
        {
            bool result = this.ownersService.EditOwner(owner);
            return Ok(result);
        }

        // DELETE: api/Owners/5
        public void Delete(int id)
        {
        }
    }
}
