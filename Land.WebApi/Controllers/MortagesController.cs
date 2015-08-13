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
using Land.Services.Mortgages;

namespace Land.WebApi.Controllers
{
    public class mortgagesController : ApiController
    {
        private IMortgagesService mortgagesService;

        public mortgagesController(IMortgagesService mortgagesService)
        {
            this.mortgagesService = mortgagesService;
        }

        // GET: api/mortgages
        public IHttpActionResult Get()
        {
            List<Mortgage> mortgages = this.mortgagesService.GetMortgages();
            return Ok(mortgages);
        }

        // GET: api/mortgages/5
        [ResponseType(typeof(Mortgage))]
        public IHttpActionResult Get(int id)
        {
            Mortgage mortgage = this.mortgagesService.GetMortgage(id);
            if (mortgage == null)
            {
                return NotFound();
            }

            return Ok(mortgage);
        }

        // PUT: api/mortgages/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putmortgage(Mortgage mortgage)
        {
            bool result = this.mortgagesService.EditMortgage(mortgage);
            return Ok(result);
        }

        // POST: api/mortgages
        [ResponseType(typeof(Mortgage))]
        public IHttpActionResult Postmortgage(Mortgage mortgage)
        {
            string result = this.mortgagesService.CreateMortgage(mortgage);
            return Ok(result);
        }
    }
}