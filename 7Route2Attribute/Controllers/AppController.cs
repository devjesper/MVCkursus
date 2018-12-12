using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7Route2Attribute.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        [HttpGet]
        [Route("~/")]
        [Route("~/Forside")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        
        [Route("~/Salg/{kundeid:int}")]
        public ActionResult Salg(int kundeid)

        {
            ViewBag.kundeid = kundeid;
            return View();
        }
    }
}