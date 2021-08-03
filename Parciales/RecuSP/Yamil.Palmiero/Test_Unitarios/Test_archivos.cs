using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class Test_archivos
    {
        [TestMethod]
        public void SerializadorXML_test()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]//Pruebo la excepcion ArchivoException
        public void Exception_Test()
        {
            GestorDeArchivos gestorArchivo = new GestorDeArchivos("");//No es un archivo XML o no existe
            gestorArchivo.LeerXML();//Intento leerlo
        }
    }
}
