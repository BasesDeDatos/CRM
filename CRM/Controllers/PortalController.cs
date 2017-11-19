using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class PortalController : Controller
    {
        private ICRMEntities db = new CRMEntities();

        public PortalController(ICRMEntities p_db)
        {
            db = p_db;
        }

        public PortalController() { }

        // GET: Portal
        public ActionResult Index()
        {
            return View();
        }

        // GET: Portal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Portal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Portal/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Portal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Portal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Portal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Portal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
