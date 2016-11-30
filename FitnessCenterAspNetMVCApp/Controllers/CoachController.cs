using FitnessCenterAspNetMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCenterAspNetMVCApp.Controllers
{
    public class CoachController : Controller
    {
        // GET: Coach

        DB_FitnessCenterWebEntities db = new DB_FitnessCenterWebEntities();

        public ActionResult Index()
        {
            IEnumerable<Coach> coaches = db.Coach;

            ViewBag.Coach = coaches;

            return View();
        }
    }
}