using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Clases;
using MisExcepciones;

namespace PruebasUnitarias
{
    [TestClass]
    public class Test_Metodos
    {
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void Test_MetodoDeInstancia()
        {
            //ARRANGE
            OtraClase otra;
            //ACT
            otra = new OtraClase();
            otra.MetodoDeInstancia();
        }


    }
}
