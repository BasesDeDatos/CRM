using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class PuntosDeContactoController : Controller
    {
        private ICRMEntities db = new CRMEntities();
        public PuntosDeContactoController(ICRMEntities p_db)
        {
            db = p_db;
        }
        public PuntosDeContactoController()
        {
        }
        // GET: PuntosDeContacto
        public ActionResult Index()
        {
            var contactos = new CRMEntities3();
            string email = Session["usermail"].ToString();
            ViewBag.contactosList = contactos.getVendedores(email).GroupBy(x => x.correo).Select(g => g.First()).ToList();
            return View();
        }
    }
}