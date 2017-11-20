using CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CRM.Controllers
{
    public class EntrenamientosController : Controller
    {
        private ICRMEntities db = new CRMEntities();
        public EntrenamientosController(ICRMEntities p_db)
        {
            db = p_db;
        }
        public EntrenamientosController()
        {
        }
        // GET: Entrenamientos
        public ActionResult Index()
        {
            var contactos = new CRMEntities3();
            string email = Session["usermail"].ToString();
            ViewBag.contactosList = contactos.getVendedores(email).GroupBy(x => x.correo).Select(g => g.First()).ToList();
            return View();
        }
    }
}