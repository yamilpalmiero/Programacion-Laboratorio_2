using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using CentralitaHerencia;

namespace Ejercicio_44
{
    [TestClass]
    public class TestCentralita
    {
        [TestMethod]
        public void Test_ListaInstanciada()
        {
            //ARRANGE
            Centralita centralita;

            //ACT
            centralita = new Centralita("Call Center");

            //ASSERT
            Assert.AreNotEqual(centralita.Llamadas, null);
        }
    }
}
