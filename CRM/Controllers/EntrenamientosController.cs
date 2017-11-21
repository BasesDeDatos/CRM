using CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
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
        private ICRMEntities3 db;
        public EntrenamientosController(ICRMEntities3 p_db)
        {
            db = p_db;
        }
        public EntrenamientosController()
        {
            db = new CRMEntities3();
        }
        // GET: Entrenamientos
        public ActionResult Index()
        {
            string username = Session["username"].ToString();
            ViewBag.entrenamientosList = getEntrenamientos(username);
            return View();
        }
        public List<getEntrenamientos_Result> getEntrenamientos(String pUsername)
        {
            return db.getEntrenamientos(pUsername).OrderBy(o => o.estado).ToList();
        }
    }
}