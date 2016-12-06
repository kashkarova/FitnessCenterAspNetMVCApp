using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCenterAspNetMVCApp.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service

        private DbModel db = new DbModel();
        public ActionResult ServiceView()
        {
            ViewBag.serviceList = db.Service.ToList();

            return View();
        }
    }
}