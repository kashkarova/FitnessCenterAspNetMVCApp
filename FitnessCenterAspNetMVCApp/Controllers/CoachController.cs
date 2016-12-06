using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Web.Mvc;
using FitnessCenterAspNetMVCApp.Models;

namespace FitnessCenterAspNetMVCApp.Controllers
{
    public class CoachController : Controller
    {
        DbModel db = new DbModel();
        
        // GET: Coach
        public ActionResult CoachView()
        {
            ViewBag.coachList = db.Coach.ToList();

            return View();
        }
    }
}