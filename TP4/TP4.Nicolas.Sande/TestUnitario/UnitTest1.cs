using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Correo correo = new Correo();
            Paquete p1 = new Paquete("Alsina 178", "123");
            Paquete p2 = new Paquete("Videla 111", "123");
            
            correo += p1;
            correo += p2;
        }
    }
}
