using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6Route1.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Salg()
        {
            return View();
        }

        public ActionResult Fejl(string q)
        {
            return View();
        }
    }
}