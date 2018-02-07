using GraGieldowa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraGieldowa.Controllers
{
    public class GameController : Controller
    {

        // GET: Game
        public ActionResult Index()
        {
            UstawieniaGryModel ustawienia = (UstawieniaGryModel)Session["Ustawienia"];

            return View();
        }
    }
}