using CRM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class PuntosDeContactoController : Controller
    {
        private ICRMEntities3 db;
        public PuntosDeContactoController(ICRMEntities3 p_db)
        {
            db = p_db;
        }
        public PuntosDeContactoController()
        {
            db = new CRMEntities3();
        }
        // GET: PuntosDeContacto
        public ActionResult Index()
        {
            string email = Session["usermail"].ToString();
            ViewBag.contactosList = getVendedores(email);
            return View();
        }

        public List<getVendedores_Result> getVendedores(String pEmail)
        {
            return db.getVendedores(pEmail).GroupBy(x => x.correo).Select(g => g.First()).ToList();
        }
    }
}