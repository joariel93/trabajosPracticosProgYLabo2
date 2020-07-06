using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void TestVerificalistaPaquetesInstanciada()
        {
            //act
            Correo correoTest;

            //arrange
            correoTest = new Correo();

            //assert
            Assert.IsNotNull(correoTest.Paquetes);

        }
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestVerificaNoIdRepetidos()
        {
            //act
            Correo correoTest;
            Paquete paqueteTest;

            //arrange
            correoTest = new Correo();
            paqueteTest = new Paquete("direccion de prueba", "123456");

            correoTest += paqueteTest;
            correoTest += paqueteTest;
            

        }

    }
}
