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

        private DB_FitnessCenterWebEntities db = new DB_FitnessCenterWebEntities();

        public ActionResult Index()
        {
            var coachList = db.Coach.ToList();

            return View(coachList);
        }
    }
}