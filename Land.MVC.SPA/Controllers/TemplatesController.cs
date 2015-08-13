using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Land.MVC.SPA.Controllers
{
    public class TemplatesController : Controller
    {
        // GET: Templates
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Owners()
        {
            return View();
        }

        public ActionResult OwnersModal()
        {
            return View();
        }

        public ActionResult Mortgages()
        {
            return View();
        }

        public ActionResult MortgagesModal()
        {
            return View();
        }

        public ActionResult LandProperties()
        {
            return View();
        }

        public ActionResult LandPropertiesModal()
        {
            return View();
        }
    }
}