using _8ViewTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _8ViewTest.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        [HttpGet]
        [Route("~/")]
        public ActionResult Index()
        {
            List<string> tmp = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                tmp.Add(Guid.NewGuid().ToString());

            }


            return View(tmp);
        }

        [HttpGet]
        [Route("~/Test")]
        public ActionResult Test()
        {
            Person p = new Person() { Navn = "ab", Alder = 10, ErILive = true };


            return View(p);
        }
    }
}