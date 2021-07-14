using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class Test_Vendedor
    {
        [TestMethod]
        public void ListaInstanciada()
        {
            //ARRANGE
            Vendedor vendedor = new Vendedor("Yamil");
            //ACT

            //ASSERT
            Assert.IsNotNull(vendedor.Ventas);
        }

        [TestMethod]
        public void AgregarVentas()
        {
            //ARRANGE
            Vendedor vendedor = new Vendedor("Yamil");
            Producto producto = new Producto("PlayStation5", 1);
            //ACT
            vendedor.Ventas.Add(producto);
            //ASSERT
            Assert.IsTrue(vendedor.Ventas.Contains(producto));
        }

        [TestMethod]
        public void SinStock()
        {
            //ARRANGE
            Vendedor vendedor = new Vendedor("Yamil");
            Producto producto = new Producto("PlayStation5", 0);
            bool sinStock = false;
            //ACT
            if (producto.Stock < 1) sinStock = true;
            //ASSERT
            Assert.IsTrue(sinStock);
        }
    }
}
