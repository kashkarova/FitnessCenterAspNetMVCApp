using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCenterAspNetMVCApp.Controllers
{
    public class TimetableController : Controller
    {
        // GET: Timetable

        DbModel db = new DbModel();
        public ActionResult TimetableView()
        {
            ViewBag.result = db.TimetableView.ToList();

            return View();
        }
    }
}