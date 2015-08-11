using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Land.Data.Entities;
using Land.Data.Repositories;
using Land.Services.Mortages;

namespace Land.WebApi.Controllers
{
    public class MortagesController : ApiController
    {
        private IMortagesService mortagesService;

        public MortagesController(IMortagesService mortagesService)
        {
            this.mortagesService = mortagesService;
        }

        // GET: api/Mortages
        public IHttpActionResult Get()
        {
            List<Mortage> mortages = this.mortagesService.GetMortages();
            return Ok(mortages);
        }

        // GET: api/Mortages/5
        [ResponseType(typeof(Mortage))]
        public IHttpActionResult Get(int id)
        {
            Mortage mortage = this.mortagesService.GetMortage(id);
            if (mortage == null)
            {
                return NotFound();
            }

            return Ok(mortage);
        }

        // PUT: api/Mortages/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMortage(Mortage mortage)
        {
            bool result = this.mortagesService.EditMortage(mortage);
            return Ok(result);
        }

        // POST: api/Mortages
        [ResponseType(typeof(Mortage))]
        public IHttpActionResult PostMortage(Mortage mortage)
        {
            int result = this.mortagesService.CreateMortage(mortage);
            return Ok(result);
        }
    }
}