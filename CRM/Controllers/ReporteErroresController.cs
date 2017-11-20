using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
	public class ReporteErroresController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			var db = new CRMEntities3();
            ViewBag.reportesList = db.getReportes(Session["username"].ToString()).ToList();
            ViewBag.productosList = db.Productos.Select(x => new { x.nombre, x.producto_id }).OrderBy(o => o.nombre).ToList();
            return View();
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