using CRM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
	public class ReporteErroresController : Controller
	{
        private ICRMEntities3 db;
        public ReporteErroresController(ICRMEntities3 p_db)
        {
            db = p_db;
        }
        public ReporteErroresController()
        {
            db = new CRMEntities3();
        }
        // GET: Home
        public ActionResult Index()
		{
            CRMEntities3 reportes = (CRMEntities3)db;
            string username = Session["username"].ToString();
            ViewBag.reportesList = getReportes(username);
            ViewBag.productosList = getProductos();
            return View();
		}

        public List<getReportes_Result> getReportes(string pUsername)
        {
            return db.getReportes(pUsername).ToList();
        }

        public List<Producto> getProductos()
        {
            return db.Productos.OrderBy(o => o.nombre).ToList();
        }

        public Boolean insertarReporte(String descripcionTextBox, String ddProductos)
        {
            /*
            var db = new CRMEntities3();
            try
            {
                Reporte reporte = new Reporte
                {
                    estado = "Abierto",
                    descripcion = descripcionTextBox,
                    producto_id = Int32.Parse(ddProductos),
                    usuario_id = db.Users.Where(x => x.username == Session["username"].ToString()).Select(x => new { x.ID }).FirstOrDefault().ID
                };
                var insert = db.Reportes.Add(reporte);
                db.SaveChanges();
                if (insert != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            */
            return false;

        }
        [HttpPost]
        public ActionResult agregarReporte(string ddProductos, string descripcionTextBox)
        {
            /*
            var db = new CRMEntities();
            var insertoCorrectamente = insertarReporte(descripcionTextBox, ddProductos);

            if (insertoCorrectamente)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index", "ReporteErrores");
            }
            */
            return View();
        }

    }
}