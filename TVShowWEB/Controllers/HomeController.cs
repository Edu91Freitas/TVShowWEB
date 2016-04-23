using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVShowWEB.Models;

namespace TVShowWEB.Controllers
{
    public class HomeController : Controller
    {
        private TVEnt _db = new TVEnt();
        
       
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
                    _db.Episode.SqlQuery("SELECT * from [dbo].[Episode] Where Id = '" + v +
                                         "' ORDER BY [IdEpisode] DESC").ToList();

                ViewBag.TorrentList =
                    _db.Torrent.SqlQuery("SELECT * From [dbo].[Torrent] Where [IdShow] = '" + v + "'").ToList();

                //List<TVShowWEB.Models.Torrent> list =
                //    _db.Torrent.Where(p => p.IdShow == v).ToList();

                //ViewBag.TEST = list;

                //ViewBag.TorrentList =
                //    _db.Torrent.SqlQuery("SELECT * From [dbo].[Torrent] Where [IdShow] = '" + v +
                //                         "' order by CAST(SUBSTRING(Seed + '0', PATINDEX('%[0-9]%', Seed + '0'), LEN(Seed + '0')) AS INT) DESC").ToList();
            }
            else
            {
                return Content("Invalid Show ID :/");
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