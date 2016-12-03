using FitnessCenterAspNetMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCenterAspNetMVCApp.Controllers
{
    public class FeedbackController : Controller
    {
        DB_FitnessCenterWebEntities db = new DB_FitnessCenterWebEntities();
        
        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }
    }
}