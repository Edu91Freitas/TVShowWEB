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
            string v = Request.QueryString["id"];
            if (v != null)
            {
                ViewBag.ID = v;
                ViewBag.Name = _db.Show.Find(v).Name;
                ViewBag.Cat = _db.Show.Find(v).Cat;
                ViewBag.Akt = _db.Show.Find(v).ActualSeasone;


                ViewBag.EpisodeList =
                    _db.Episode.SqlQuery("SELECT * from [dbo].[Episode] Where Id = '"+v+ "' ORDER BY [IdEpisode] DESC").ToList();

            }
            


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}