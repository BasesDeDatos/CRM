using CRM.Controllers;
using CRM.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestCases
{
    [TestFixture]
    class Test_ReporteErrores_COntroller
    {
        [TestCase]
        public void getReportes_hayReportes_ReturnReportes()
        {
            ReporteErroresController reporteErroresController = new ReporteErroresController();
            List<getReportes_Result> resultado = reporteErroresController.getReportes("jeffrey");
            Assert.AreNotEqual(0, resultado.Count);
        }
        [TestCase]
        public void getReportes_noHayReportes_ReturnReportesVacio()
        {
            ReporteErroresController reporteErroresController = new ReporteErroresController();
            List<getReportes_Result> resultado = reporteErroresController.getReportes("jeffrey_a12");
            Assert.AreEqual(0, resultado.Count);
        }

        [TestCase]
        public void getProductos_hayProductos_ReturnProductos()
        {
            ReporteErroresController reporteErroresController = new ReporteErroresController();
            List<Producto> resultado = reporteErroresController.getProductos();
            Assert.AreNotEqual(0, resultado.Count);
        }
    }
}
