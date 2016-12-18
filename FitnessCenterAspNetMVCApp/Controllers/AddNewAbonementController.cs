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
                Value=s.s_id.ToString()
            });


            ViewBag.services = services;
            return View(new AddNewAbonementModel());
        }

        public ActionResult SaveNewAbonement(AddNewAbonementModel abNew)
        {
            Client cli = new Client(abNew.c_name, abNew.c_surname, abNew.c_phone);

            db.Client.Add(cli);

            int id = 0;

            int temp_title = 0;

            temp_title = int.Parse(abNew.s_title);

            var servs = db.Service
                        .Where(s=>s.s_id== temp_title)
                        .Select(s => s);

            foreach (Service se in servs)
                id = se.s_id;


            Abonement ab = new Abonement(cli.c_id, abNew.date_begin, id, abNew.date_end, abNew.a_count);

            db.Abonement.Add(ab);

            db.SaveChanges();

            return RedirectToAction("AddNewAbonementView");
        }
    }
}