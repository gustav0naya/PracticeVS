using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tryagain.Models;

namespace tryagain.Controllers
{
    public class PlayerController : Controller
    {
        public ActionResult NBAHistory()
        {
            var nbaplayer = new NBAPlayer(){Name = "Gilbert Arenas"};
            return View(nbaplayer);
        }
    }
}
