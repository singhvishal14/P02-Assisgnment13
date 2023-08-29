using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assisgnment_13.Models;

namespace Assisgnment_13.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<TeamsAndWorldCup> twc = new List<TeamsAndWorldCup>() {
            new TeamsAndWorldCup(){Id=1,Name="India",NoOfWorldCups=2},
            new TeamsAndWorldCup(){Id=2,Name="Australia",NoOfWorldCups=4},
            new TeamsAndWorldCup(){Id=3,Name="WestIndies",NoOfWorldCups=2},
            new TeamsAndWorldCup(){Id=4,Name="England",NoOfWorldCups=1},

            };
            return View(twc);
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