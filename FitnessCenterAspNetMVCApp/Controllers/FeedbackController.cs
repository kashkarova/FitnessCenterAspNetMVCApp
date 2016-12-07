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
        
        // GET: Feedback
        public ActionResult AddFeedback()
        {
            var feedback = new Feedback();

            return View(feedback);
        }

        public ActionResult AddFeedback(Feedback fb)
        {

            return View(fb);
        }

        public ActionResult ShowFeedback()
        {
            ViewBag.listFeedback = db.Feedback.ToList();

            return View();
        }
    }
}