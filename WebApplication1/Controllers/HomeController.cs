using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.H4 = "This is my dynamic H4 expression";
            return View();
        }

        public ActionResult JsonResult()
        {
            return Json(new { foo = "bar", baz = "Blech" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Num = 42;
            Console.WriteLine("Test");
            return View();
        }

    }
}