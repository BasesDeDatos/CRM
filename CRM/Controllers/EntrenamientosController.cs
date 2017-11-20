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
            var entrenamientos = new CRMEntities3();
            string username = Session["username"].ToString();
            ViewBag.entrenamientosList = entrenamientos.getEntrenamientos(username).OrderBy(o => o.estado).ToList();
            return View();
        }
    }
}