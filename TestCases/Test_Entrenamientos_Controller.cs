using CRM.Controllers;
using CRM.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestCases
{
    [TestFixture]
    class Test_Entrenamientos_Controller
    {
        [TestCase]
        public void getEntrenamientos_hayEntrenamientos_ReturnEntrenamiento()
        {
            EntrenamientosController entrenamientoController = new EntrenamientosController();
            List<getEntrenamientos_Result> resultado = entrenamientoController.getEntrenamientos("jeffrey");
            Assert.AreNotEqual(0, resultado.Count);
        }
        [TestCase]
        public void getEntrenamientos_noHayEntrenamientos_ReturnEntrenamientoVacio()
        {
            EntrenamientosController entrenamientoController = new EntrenamientosController();
            List<getEntrenamientos_Result> resultado = entrenamientoController.getEntrenamientos("jeffrey_a12");
            Assert.AreEqual(0, resultado.Count);
        }
    }
}
