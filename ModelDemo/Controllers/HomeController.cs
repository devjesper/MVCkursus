using ModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Person p = new Person();
            p.age = 10;
            p.name = "Mads";
            p.isAlive = true;

            return View(p);
        }

        public ActionResult Index2(Person person)
        {
            Person p = new Person();
            p.age = 10;
            p.name = "Mads";
            p.isAlive = true;

            return View(p);
        }

        public ActionResult Login(ModelDemo.Models.LoginViewModel login)
        {
            return View();
        }
    }
}