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
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Owners
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Owners/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Owners/5
        public void Delete(int id)
        {
        }
    }
}
