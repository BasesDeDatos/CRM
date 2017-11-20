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
			var reportes = new CRMEntities3();
            ViewBag.reportesList = reportes.getReportes(Session["username"].ToString()).ToList();
			return View();
		}
	}
}