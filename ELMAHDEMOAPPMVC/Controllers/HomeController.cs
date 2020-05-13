using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELMAHDEMOAPPMVC.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            //int i = 10;
            //int j;
            //j = i / 0;
            return View();
        }
    }
}