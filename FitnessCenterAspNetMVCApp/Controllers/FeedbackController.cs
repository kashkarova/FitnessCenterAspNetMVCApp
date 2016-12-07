using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCenterAspNetMVCApp.Controllers
{
    public class FeedbackController : Controller
    {
        private DbModel db = new DbModel();

        public ActionResult AddFeedback()
        {
            return View(new Feedback());
        }

        public ActionResult SaveFeedback(Feedback fb)
        {
            db.Feedback.Add(fb);
            db.SaveChanges();

            return RedirectToAction("ShowFeedback");
        }

        public ActionResult ShowFeedback()
        {
            ViewBag.listFeedback = db.Feedback.ToList();

            return View();
        }
    }
}