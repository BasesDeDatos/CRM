using CRM.Controllers;
using CRM.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestCases
{
    [TestFixture]
    class Test_PuntosDeContacto_Controller
    {
        [TestCase]
        public void getVendedores_hayVendedores_ReturnVendedores()
        {
            PuntosDeContactoController puntosDeContactoController = new PuntosDeContactoController();
            List<getVendedores_Result> resultado = puntosDeContactoController.getVendedores("mollyta@mail.com");
            Assert.AreNotEqual(0, resultado.Count);
        }
        [TestCase]
        public void getVendedores_noHayVendedores_ReturnVendedoresVacios()
        {
            PuntosDeContactoController puntosDeContactoController = new PuntosDeContactoController();
            List<getVendedores_Result> resultado = puntosDeContactoController.getVendedores("mollyta2@mail.com");
            Assert.AreEqual(0, resultado.Count);
        }
    }
}
