using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3ConrollerDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test1()
        {
            return Content("12");
        }

        public ActionResult Test2()
        {
            return Content("1,2,3", "application/CSV");
        }

        public ActionResult Test3()
        {
            return Redirect("http://www.google.dk");
        }

        public ActionResult Test4()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Test5()
        {


            return Json(Person.Personer(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Test6()
        {


            return View();
        }


        public ActionResult Test8()
        {
            string t = Guid.NewGuid().ToString();
            ViewBag.bla = t;

            return View();
        }

        public ActionResult Test9()
        {
            string t = Guid.NewGuid().ToString();
            Test9ViewModel m = new Test9ViewModel
            {
                Id = 1,
                Streng = t
            };
            return View(m);
        }

        
        public ActionResult test10(string test, int tal=0)
        {
            return View();
        }

        public ActionResult test11(Person p)
        {

            return View();
        }

        public ActionResult test12(Person p)
        {
            if (!ModelState.IsValid) { } else { }
            return View();
        }

    }



    public class Test9ViewModel
    {
        public int Id { get; set; }
        public string Streng { get; set; }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Alder { get; set; }


        public static List<Person> Personer()
        {
            List<Person> p = new List<Person>()
            {
                new Person(){ Id=1, Alder = 10, Navn = "asdf"},
                new Person(){ Id=2, Alder = 30, Navn = "sdfdfsghegsgd"},
                new Person(){ Id=3, Alder = 40, Navn = "dæflkgj lsdfkj lsdfkj dlsj"}
            };
            return p;
        }
    }

}

