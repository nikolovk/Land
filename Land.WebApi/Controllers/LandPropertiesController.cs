using Land.Data.Entities;
using Land.Services.LandProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Land.WebApi.Controllers
{
    public class LandPropertiesController : ApiController
    {
        private ILandPropertiesService landPropertiesService;

        public LandPropertiesController(ILandPropertiesService landPropertiesService)
        {
            this.landPropertiesService = landPropertiesService;
        }

        // GET: api/LandProperties
        public IHttpActionResult Get()
        {
            List<LandProperty> landProperties = this.landPropertiesService.GetLandProperties();
            return Ok(landProperties);
        }

        // GET: api/LandProperties/5
        [ResponseType(typeof(LandProperty))]
        public IHttpActionResult Get(string id)
        {
            LandProperty landProperty = this.landPropertiesService.GetLandProperty(id);
            if (landProperty == null)
            {
                return NotFound();
            }

            return Ok(landProperty);
        }

        // PUT: api/LandProperties/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(LandProperty LandProperty)
        {
            bool result = this.landPropertiesService.EditLandProperty(LandProperty);
            return Ok(result);
        }

        // POST: api/LandProperties
        [ResponseType(typeof(LandProperty))]
        public IHttpActionResult PostLandProperty(LandProperty LandProperty)
        {
            string result = this.landPropertiesService.CreateLandProperty(LandProperty);
            return Ok(result);
        }

    }
}
