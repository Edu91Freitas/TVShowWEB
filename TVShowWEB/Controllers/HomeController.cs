using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TVShowWEB.Controllers
{
    public class HomeController : Controller
    {
        private TVEntity _db = new TVEntity();
       
        public ActionResult Index()
        {

            ViewBag.MyList = _db.Show.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}