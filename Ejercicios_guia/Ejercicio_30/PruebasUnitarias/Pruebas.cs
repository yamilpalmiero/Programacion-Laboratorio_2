using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class Pruebas
    {
        [TestMethod]
        public void Test_ListaDeVehiculos()
        {
            //ARRANGE
            Competencia c;
            //ACT
            c = new Competencia(10, 20, Competencia.TipoCompetencia.F1);
            //ASSERT
            Assert.IsNotNull(c.Competidores);
        }


        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Test_CompetenciaNoDisponibleException_Throws()
        {
            //ARRANGE   
            Competencia c;
            AutoF1 a;
            //ACT
            c = new Competencia(10, 20, Competencia.TipoCompetencia.MotoCross);
            a = new AutoF1(10, "Ferrari");
            bool pudo = c + a;
            //ASSERT es manejado en el ExpectedException
        }


        [TestMethod]
        public void Test_CompetenciaNoDisponibleException_NoThrows()
        {
            //ARRANGE   
            Competencia c;
            MotoCross m;
            //ACT
            c = new Competencia(10, 20, Competencia.TipoCompetencia.MotoCross);
            m = new MotoCross(46, "Honda");
            //ASSERT
            Assert.IsTrue(c + m);
        }


        [TestMethod]
        public void Test_ComprobarAltaDeVehiculo()
        {
            //ARRANGE
            Competencia competencia = new Competencia(2, 40, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(44, "KTM");
            //ACT
            bool pudo = competencia + motoCross;
            //ASSERT
            Assert.IsTrue(competencia + motoCross);
            Assert.IsTrue(competencia == motoCross);
        }


        [TestMethod]
        public void Test_ComprobarBajaDeVehiculo()
        {
            //ARRANGE
            Competencia competencia = new Competencia(2, 40, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(44, "KTM");
            //ACT
            bool pudo = competencia + motoCross;
            //ASSERT
            Assert.IsTrue(competencia - motoCross);
            Assert.IsTrue(competencia != motoCross);
        }
    }
}
