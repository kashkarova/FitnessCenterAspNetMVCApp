using FitnessCenterAspNetMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace FitnessCenterAspNetMVCApp.Controllers
{
    public class AddNewAbonementController : Controller
    {
        // GET: AddNewAbonement

        DbModel db = new DbModel();
        IEnumerable<SelectListItem> services;
        public ActionResult AddNewAbonementView()
        {

            services = db.Service.Select(s => new SelectListItem()
            {
                Text = s.s_title,
                Value = s.s_id.ToString()
            });


            ViewBag.services = services;
            return View(new AddNewAbonement());
        }

        public ActionResult SaveNewAbonement(AddNewAbonement abNew)
        {
            Client cli = new Client(abNew.c_name, abNew.c_surname, abNew.c_phone);

            db.Client.Add(cli);

            int s_id = int.Parse(db.Service.Where(s => s.s_title == abNew.s_title).ToString());

            Abonement ab = new Abonement(cli.c_id, abNew.date_begin, s_id, abNew.date_end, abNew.a_count);

            db.SaveChanges();

            return RedirectToAction("AddNewAbonementView");
        }
    }
}